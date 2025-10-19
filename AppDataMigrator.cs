using System;
using System.Diagnostics;
using System.IO;

namespace winC2D
{
    public static class AppDataMigrator
    {
        /// <summary>
        /// ʹ�� mklink Ǩ�� AppData �ļ��е�Ŀ��λ��
        /// </summary>
        /// <param name="appName">Ӧ�����ƣ�AppData�е��ļ�������</param>
        /// <param name="sourcePath">ԭʼ·��</param>
        /// <param name="targetRoot">Ŀ���Ŀ¼</param>
        public static void MigrateWithMklink(string appName, string sourcePath, string targetRoot)
        {
            if (!Directory.Exists(sourcePath))
            {
                throw new DirectoryNotFoundException($"Source directory not found: {sourcePath}");
            }

            // Ŀ��·��
            string targetPath = Path.Combine(targetRoot, "AppData", appName);
            
            // ȷ��Ŀ�길Ŀ¼����
            Directory.CreateDirectory(Path.GetDirectoryName(targetPath));

            // ���Ŀ���Ѵ��ڣ���ɾ��
            if (Directory.Exists(targetPath))
            {
                Directory.Delete(targetPath, true);
            }

            // �����ļ���Ŀ��λ��
            CopyDirectory(sourcePath, targetPath);

            // ����ԭʼĿ¼
            string backupPath = sourcePath + ".backup_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Directory.Move(sourcePath, backupPath);

            // ������������ (ʹ�� mklink /D)
            CreateSymbolicLink(sourcePath, targetPath);

            // ��֤�����Ƿ�ɹ�
            if (!Directory.Exists(sourcePath))
            {
                // ���ʧ�ܣ��ָ�����
                Directory.Move(backupPath, sourcePath);
                throw new Exception("Failed to create symbolic link. Backup restored.");
            }

            // ɾ�����ݣ��ɹ���
            try
            {
                Directory.Delete(backupPath, true);
            }
            catch
            {
                // ����ɾ��ʧ�ܲ�Ӱ��������
            }
        }

        /// <summary>
        /// ʹ�� mklink /D ����Ŀ¼��������
        /// </summary>
        private static void CreateSymbolicLink(string linkPath, string targetPath)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c mklink /D \"{linkPath}\" \"{targetPath}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            using (Process process = Process.Start(psi))
            {
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (process.ExitCode != 0)
                {
                    throw new Exception($"mklink failed: {error}\n{output}");
                }
            }
        }

        /// <summary>
        /// �ݹ鸴��Ŀ¼
        /// </summary>
        private static void CopyDirectory(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(targetDir, fileName);
                File.Copy(file, destFile, true);
            }

            foreach (string dir in Directory.GetDirectories(sourceDir))
            {
                string dirName = Path.GetFileName(dir);
                string destDir = Path.Combine(targetDir, dirName);
                CopyDirectory(dir, destDir);
            }
        }

        /// <summary>
        /// ��ȡĿ¼��С���ݹ飩
        /// </summary>
        public static long GetDirectorySize(string path)
        {
            if (!Directory.Exists(path))
                return 0;

            long size = 0;
            try
            {
                foreach (string file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
                {
                    try
                    {
                        FileInfo fi = new FileInfo(file);
                        size += fi.Length;
                    }
                    catch { }
                }
            }
            catch { }
            return size;
        }

        /// <summary>
        /// ��ʽ���ļ���С
        /// </summary>
        public static string FormatSize(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = bytes;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }
            return $"{len:0.##} {sizes[order]}";
        }
    }

    public class AppDataInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public string SizeText => AppDataMigrator.FormatSize(Size);
        public string Type { get; set; } // Roaming, Local, LocalLow
    }
}
