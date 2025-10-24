using System.Windows.Forms;

namespace winC2D
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListView listViewSoftware;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.Button buttonMigrateSoftware;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageSoftware;
        private System.Windows.Forms.TabPage tabPageAppData;
        
        // Settings tab controls
        private System.Windows.Forms.GroupBox groupBoxProgramFiles;
        private System.Windows.Forms.Label labelProgramFilesNote;
        private System.Windows.Forms.Button buttonResetProgramFiles;
        private System.Windows.Forms.Button buttonApplyProgramFiles;
        private System.Windows.Forms.Button buttonBrowseProgramFilesX86;
        private System.Windows.Forms.TextBox textBoxProgramFilesX86;
        private System.Windows.Forms.Label labelProgramFilesX86;
        private System.Windows.Forms.CheckBox checkBoxCustomX86;
        private System.Windows.Forms.Button buttonBrowseProgramFiles;
        private System.Windows.Forms.TextBox textBoxProgramFiles;
        private System.Windows.Forms.Label labelProgramFiles;
        private System.Windows.Forms.GroupBox groupBoxStoragePolicy;
        private System.Windows.Forms.Label labelStoragePolicyNote;
        private System.Windows.Forms.Button buttonOpenWindowsStorage;
        
        private System.Windows.Forms.ListView listViewAppData;
        private System.Windows.Forms.ColumnHeader columnHeaderAppName;
        private System.Windows.Forms.ColumnHeader columnHeaderAppPath;
        private System.Windows.Forms.ColumnHeader columnHeaderAppSize;
        private System.Windows.Forms.ColumnHeader columnHeaderAppType;
        private System.Windows.Forms.Button buttonMigrateAppData;
        private System.Windows.Forms.Button buttonRefreshAppData;
        private System.Windows.Forms.Label labelMklinkNote;
        private System.Windows.Forms.ToolStripMenuItem menuLanguage;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageEnglish;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageChinese;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageJapanese;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageKorean;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageFrench;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageGerman;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageSpanish;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageRussian;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuLog = new ToolStripMenuItem();
            menuLanguage = new ToolStripMenuItem();
            menuLanguageEnglish = new ToolStripMenuItem();
            menuLanguageChinese = new ToolStripMenuItem();
            menuLanguageJapanese = new ToolStripMenuItem();
            menuLanguageKorean = new ToolStripMenuItem();
            menuLanguageFrench = new ToolStripMenuItem();
            menuLanguageGerman = new ToolStripMenuItem();
            menuLanguageSpanish = new ToolStripMenuItem();
            menuLanguageRussian = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPageSettings = new TabPage();
            groupBoxStoragePolicy = new GroupBox();
            buttonOpenWindowsStorage = new Button();
            labelStoragePolicyNote = new Label();
            groupBoxProgramFiles = new GroupBox();
            labelProgramFilesNote = new Label();
            buttonResetProgramFiles = new Button();
            buttonApplyProgramFiles = new Button();
            buttonBrowseProgramFilesX86 = new Button();
            textBoxProgramFilesX86 = new TextBox();
            labelProgramFilesX86 = new Label();
            checkBoxCustomX86 = new CheckBox();
            buttonBrowseProgramFiles = new Button();
            textBoxProgramFiles = new TextBox();
            labelProgramFiles = new Label();
            tabPageSoftware = new TabPage();
            listViewSoftware = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderPath = new ColumnHeader();
            columnHeaderSize = new ColumnHeader();
            buttonMigrateSoftware = new Button();
            tabPageAppData = new TabPage();
            labelMklinkNote = new Label();
            listViewAppData = new ListView();
            columnHeaderAppName = new ColumnHeader();
            columnHeaderAppPath = new ColumnHeader();
            columnHeaderAppSize = new ColumnHeader();
            columnHeaderAppType = new ColumnHeader();
            buttonMigrateAppData = new Button();
            buttonRefreshAppData = new Button();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageSettings.SuspendLayout();
            groupBoxStoragePolicy.SuspendLayout();
            groupBoxProgramFiles.SuspendLayout();
            tabPageSoftware.SuspendLayout();
            tabPageAppData.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuLog, menuLanguage });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(700, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuLog
            // 
            menuLog.Name = "menuLog";
            menuLog.Size = new System.Drawing.Size(68, 21);
            menuLog.Text = "迁移日志";
            menuLog.Click += menuLog_Click;
            // 
            // menuLanguage
            // 
            menuLanguage.DropDownItems.AddRange(new ToolStripItem[] { menuLanguageEnglish, menuLanguageChinese, menuLanguageJapanese, menuLanguageKorean, menuLanguageFrench, menuLanguageGerman, menuLanguageSpanish, menuLanguageRussian });
            menuLanguage.Name = "menuLanguage";
            menuLanguage.Size = new System.Drawing.Size(44, 21);
            menuLanguage.Text = "语言";
            // 
            // menuLanguageEnglish
            // 
            menuLanguageEnglish.Name = "menuLanguageEnglish";
            menuLanguageEnglish.Size = new System.Drawing.Size(124, 22);
            menuLanguageEnglish.Text = "English";
            menuLanguageEnglish.Click += menuLanguageEnglish_Click;
            // 
            // menuLanguageChinese
            // 
            menuLanguageChinese.Name = "menuLanguageChinese";
            menuLanguageChinese.Size = new System.Drawing.Size(124, 22);
            menuLanguageChinese.Text = "中文";
            menuLanguageChinese.Click += menuLanguageChinese_Click;
            // 
            // menuLanguageJapanese
            // 
            menuLanguageJapanese.Name = "menuLanguageJapanese";
            menuLanguageJapanese.Size = new System.Drawing.Size(124, 22);
            menuLanguageJapanese.Text = "日本語";
            menuLanguageJapanese.Click += menuLanguageJapanese_Click;
            // 
            // menuLanguageKorean
            // 
            menuLanguageKorean.Name = "menuLanguageKorean";
            menuLanguageKorean.Size = new System.Drawing.Size(124, 22);
            menuLanguageKorean.Text = "한국어";
            menuLanguageKorean.Click += menuLanguageKorean_Click;
            // 
            // menuLanguageFrench
            // 
            menuLanguageFrench.Name = "menuLanguageFrench";
            menuLanguageFrench.Size = new System.Drawing.Size(124, 22);
            menuLanguageFrench.Text = "Français";
            menuLanguageFrench.Click += menuLanguageFrench_Click;
            // 
            // menuLanguageGerman
            // 
            menuLanguageGerman.Name = "menuLanguageGerman";
            menuLanguageGerman.Size = new System.Drawing.Size(124, 22);
            menuLanguageGerman.Text = "Deutsch";
            menuLanguageGerman.Click += menuLanguageGerman_Click;
            // 
            // menuLanguageSpanish
            // 
            menuLanguageSpanish.Name = "menuLanguageSpanish";
            menuLanguageSpanish.Size = new System.Drawing.Size(124, 22);
            menuLanguageSpanish.Text = "Español";
            menuLanguageSpanish.Click += menuLanguageSpanish_Click;
            // 
            // menuLanguageRussian
            // 
            menuLanguageRussian.Name = "menuLanguageRussian";
            menuLanguageRussian.Size = new System.Drawing.Size(124, 22);
            menuLanguageRussian.Text = "Русский";
            menuLanguageRussian.Click += menuLanguageRussian_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageSettings);
            tabControl1.Controls.Add(tabPageSoftware);
            tabControl1.Controls.Add(tabPageAppData);
            tabControl1.Location = new System.Drawing.Point(10, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(679, 420);
            tabControl1.TabIndex = 1;
            // 
            // tabPageSettings
            // 
            tabPageSettings.Controls.Add(groupBoxStoragePolicy);
            tabPageSettings.Controls.Add(groupBoxProgramFiles);
            tabPageSettings.Location = new System.Drawing.Point(4, 26);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new Padding(3);
            tabPageSettings.Size = new System.Drawing.Size(671, 390);
            tabPageSettings.TabIndex = 0;
            tabPageSettings.Text = "系统设置";
            tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxStoragePolicy
            // 
            groupBoxStoragePolicy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxStoragePolicy.Controls.Add(buttonOpenWindowsStorage);
            groupBoxStoragePolicy.Controls.Add(labelStoragePolicyNote);
            groupBoxStoragePolicy.Location = new System.Drawing.Point(13, 238);
            groupBoxStoragePolicy.Name = "groupBoxStoragePolicy";
            groupBoxStoragePolicy.Size = new System.Drawing.Size(643, 85);
            groupBoxStoragePolicy.TabIndex = 1;
            groupBoxStoragePolicy.TabStop = false;
            groupBoxStoragePolicy.Text = "新内容保存位置（Microsoft Store 应用和用户内容）";
            // 
            // buttonOpenWindowsStorage
            // 
            buttonOpenWindowsStorage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenWindowsStorage.Location = new System.Drawing.Point(481, 30);
            buttonOpenWindowsStorage.Name = "buttonOpenWindowsStorage";
            buttonOpenWindowsStorage.Size = new System.Drawing.Size(149, 42);
            buttonOpenWindowsStorage.TabIndex = 1;
            buttonOpenWindowsStorage.Text = "打开 Windows 设置";
            buttonOpenWindowsStorage.UseVisualStyleBackColor = true;
            buttonOpenWindowsStorage.Click += buttonOpenWindowsStorage_Click;
            // 
            // labelStoragePolicyNote
            // 
            labelStoragePolicyNote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelStoragePolicyNote.ForeColor = System.Drawing.Color.DarkBlue;
            labelStoragePolicyNote.Location = new System.Drawing.Point(13, 26);
            labelStoragePolicyNote.Name = "labelStoragePolicyNote";
            labelStoragePolicyNote.Size = new System.Drawing.Size(451, 51);
            labelStoragePolicyNote.TabIndex = 0;
            labelStoragePolicyNote.Text = "ℹ 此设置影响 Microsoft Store 应用和新用户内容（文档、照片等）。需要 Windows 10 或更高版本。";
            // 
            // groupBoxProgramFiles
            // 
            groupBoxProgramFiles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxProgramFiles.Controls.Add(labelProgramFilesNote);
            groupBoxProgramFiles.Controls.Add(buttonResetProgramFiles);
            groupBoxProgramFiles.Controls.Add(buttonApplyProgramFiles);
            groupBoxProgramFiles.Controls.Add(buttonBrowseProgramFilesX86);
            groupBoxProgramFiles.Controls.Add(textBoxProgramFilesX86);
            groupBoxProgramFiles.Controls.Add(labelProgramFilesX86);
            groupBoxProgramFiles.Controls.Add(checkBoxCustomX86);
            groupBoxProgramFiles.Controls.Add(buttonBrowseProgramFiles);
            groupBoxProgramFiles.Controls.Add(textBoxProgramFiles);
            groupBoxProgramFiles.Controls.Add(labelProgramFiles);
            groupBoxProgramFiles.Location = new System.Drawing.Point(13, 13);
            groupBoxProgramFiles.Name = "groupBoxProgramFiles";
            groupBoxProgramFiles.Size = new System.Drawing.Size(643, 212);
            groupBoxProgramFiles.TabIndex = 0;
            groupBoxProgramFiles.TabStop = false;
            groupBoxProgramFiles.Text = "Program Files 位置（传统桌面程序）";
            // 
            // labelProgramFilesNote
            // 
            labelProgramFilesNote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelProgramFilesNote.ForeColor = System.Drawing.Color.DarkBlue;
            labelProgramFilesNote.Location = new System.Drawing.Point(13, 157);
            labelProgramFilesNote.Name = "labelProgramFilesNote";
            labelProgramFilesNote.Size = new System.Drawing.Size(617, 42);
            labelProgramFilesNote.TabIndex = 9;
            labelProgramFilesNote.Text = "ℹ 此设置影响通过安装程序（.exe、.msi）安装的传统桌面程序。大多数第三方软件使用此位置。";
            // 
            // buttonResetProgramFiles
            // 
            buttonResetProgramFiles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonResetProgramFiles.Location = new System.Drawing.Point(560, 46);
            buttonResetProgramFiles.Name = "buttonResetProgramFiles";
            buttonResetProgramFiles.Size = new System.Drawing.Size(70, 25);
            buttonResetProgramFiles.TabIndex = 8;
            buttonResetProgramFiles.Text = "恢复默认";
            buttonResetProgramFiles.UseVisualStyleBackColor = true;
            buttonResetProgramFiles.Click += buttonResetProgramFiles_Click;
            // 
            // buttonApplyProgramFiles
            // 
            buttonApplyProgramFiles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonApplyProgramFiles.Location = new System.Drawing.Point(481, 46);
            buttonApplyProgramFiles.Name = "buttonApplyProgramFiles";
            buttonApplyProgramFiles.Size = new System.Drawing.Size(70, 25);
            buttonApplyProgramFiles.TabIndex = 7;
            buttonApplyProgramFiles.Text = "应用";
            buttonApplyProgramFiles.UseVisualStyleBackColor = true;
            buttonApplyProgramFiles.Click += buttonApplyProgramFiles_Click;
            // 
            // buttonBrowseProgramFilesX86
            // 
            buttonBrowseProgramFilesX86.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBrowseProgramFilesX86.Enabled = false;
            buttonBrowseProgramFilesX86.Location = new System.Drawing.Point(402, 127);
            buttonBrowseProgramFilesX86.Name = "buttonBrowseProgramFilesX86";
            buttonBrowseProgramFilesX86.Size = new System.Drawing.Size(70, 25);
            buttonBrowseProgramFilesX86.TabIndex = 6;
            buttonBrowseProgramFilesX86.Text = "浏览";
            buttonBrowseProgramFilesX86.UseVisualStyleBackColor = true;
            buttonBrowseProgramFilesX86.Click += buttonBrowseProgramFilesX86_Click;
            // 
            // textBoxProgramFilesX86
            // 
            textBoxProgramFilesX86.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxProgramFilesX86.Enabled = false;
            textBoxProgramFilesX86.Location = new System.Drawing.Point(13, 128);
            textBoxProgramFilesX86.Name = "textBoxProgramFilesX86";
            textBoxProgramFilesX86.Size = new System.Drawing.Size(381, 23);
            textBoxProgramFilesX86.TabIndex = 5;
            // 
            // labelProgramFilesX86
            // 
            labelProgramFilesX86.AutoSize = true;
            labelProgramFilesX86.Enabled = false;
            labelProgramFilesX86.Location = new System.Drawing.Point(13, 106);
            labelProgramFilesX86.Name = "labelProgramFilesX86";
            labelProgramFilesX86.Size = new System.Drawing.Size(202, 17);
            labelProgramFilesX86.TabIndex = 4;
            labelProgramFilesX86.Text = "Program Files 默认位置（32位）：";
            // 
            // checkBoxCustomX86
            // 
            checkBoxCustomX86.AutoSize = true;
            checkBoxCustomX86.Location = new System.Drawing.Point(13, 81);
            checkBoxCustomX86.Name = "checkBoxCustomX86";
            checkBoxCustomX86.Size = new System.Drawing.Size(145, 21);
            checkBoxCustomX86.TabIndex = 3;
            checkBoxCustomX86.Text = "自定义 32位 程序路径";
            checkBoxCustomX86.UseVisualStyleBackColor = true;
            checkBoxCustomX86.CheckedChanged += checkBoxCustomX86_CheckedChanged;
            // 
            // buttonBrowseProgramFiles
            // 
            buttonBrowseProgramFiles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBrowseProgramFiles.Location = new System.Drawing.Point(402, 46);
            buttonBrowseProgramFiles.Name = "buttonBrowseProgramFiles";
            buttonBrowseProgramFiles.Size = new System.Drawing.Size(70, 25);
            buttonBrowseProgramFiles.TabIndex = 2;
            buttonBrowseProgramFiles.Text = "浏览";
            buttonBrowseProgramFiles.UseVisualStyleBackColor = true;
            buttonBrowseProgramFiles.Click += buttonBrowseProgramFiles_Click;
            // 
            // textBoxProgramFiles
            // 
            textBoxProgramFiles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxProgramFiles.Location = new System.Drawing.Point(13, 47);
            textBoxProgramFiles.Name = "textBoxProgramFiles";
            textBoxProgramFiles.Size = new System.Drawing.Size(381, 23);
            textBoxProgramFiles.TabIndex = 1;
            textBoxProgramFiles.TextChanged += textBoxProgramFiles_TextChanged;
            // 
            // labelProgramFiles
            // 
            labelProgramFiles.AutoSize = true;
            labelProgramFiles.Location = new System.Drawing.Point(13, 26);
            labelProgramFiles.Name = "labelProgramFiles";
            labelProgramFiles.Size = new System.Drawing.Size(202, 17);
            labelProgramFiles.TabIndex = 0;
            labelProgramFiles.Text = "Program Files 默认位置（64位）：";
            // 
            // tabPageSoftware
            // 
            tabPageSoftware.Controls.Add(listViewSoftware);
            tabPageSoftware.Controls.Add(buttonMigrateSoftware);
            tabPageSoftware.Location = new System.Drawing.Point(4, 26);
            tabPageSoftware.Name = "tabPageSoftware";
            tabPageSoftware.Padding = new Padding(3);
            tabPageSoftware.Size = new System.Drawing.Size(671, 390);
            tabPageSoftware.TabIndex = 1;
            tabPageSoftware.Text = "软件迁移";
            tabPageSoftware.UseVisualStyleBackColor = true;
            // 
            // listViewSoftware
            // 
            listViewSoftware.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewSoftware.CheckBoxes = true;
            listViewSoftware.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderPath, columnHeaderSize });
            listViewSoftware.FullRowSelect = true;
            listViewSoftware.Location = new System.Drawing.Point(5, 5);
            listViewSoftware.Name = "listViewSoftware";
            listViewSoftware.Size = new System.Drawing.Size(662, 346);
            listViewSoftware.TabIndex = 0;
            listViewSoftware.UseCompatibleStateImageBehavior = false;
            listViewSoftware.View = View.Details;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "软件名称";
            columnHeaderName.Width = 180;
            // 
            // columnHeaderPath
            // 
            columnHeaderPath.Text = "安装路径";
            columnHeaderPath.Width = 400;
            // 
            // columnHeaderSize
            // 
            columnHeaderSize.Text = "大小";
            columnHeaderSize.Width = 120;
            // 
            // buttonMigrateSoftware
            // 
            buttonMigrateSoftware.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonMigrateSoftware.Location = new System.Drawing.Point(567, 357);
            buttonMigrateSoftware.Name = "buttonMigrateSoftware";
            buttonMigrateSoftware.Size = new System.Drawing.Size(98, 27);
            buttonMigrateSoftware.TabIndex = 1;
            buttonMigrateSoftware.Text = "迁移所选";
            buttonMigrateSoftware.UseVisualStyleBackColor = true;
            buttonMigrateSoftware.Click += buttonMigrateSoftware_Click;
            // 
            // tabPageAppData
            // 
            tabPageAppData.Controls.Add(labelMklinkNote);
            tabPageAppData.Controls.Add(listViewAppData);
            tabPageAppData.Controls.Add(buttonMigrateAppData);
            tabPageAppData.Controls.Add(buttonRefreshAppData);
            tabPageAppData.Location = new System.Drawing.Point(4, 26);
            tabPageAppData.Name = "tabPageAppData";
            tabPageAppData.Padding = new Padding(3);
            tabPageAppData.Size = new System.Drawing.Size(671, 390);
            tabPageAppData.TabIndex = 3;
            tabPageAppData.Text = "AppData (mklink)";
            tabPageAppData.UseVisualStyleBackColor = true;
            // 
            // labelMklinkNote
            // 
            labelMklinkNote.AutoSize = true;
            labelMklinkNote.ForeColor = System.Drawing.Color.DarkBlue;
            labelMklinkNote.Location = new System.Drawing.Point(6, 3);
            labelMklinkNote.Name = "labelMklinkNote";
            labelMklinkNote.Size = new System.Drawing.Size(330, 17);
            labelMklinkNote.TabIndex = 3;
            labelMklinkNote.Text = "注意：此操作使用 mklink 创建符号链接，需要管理员权限。";
            // 
            // listViewAppData
            // 
            listViewAppData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewAppData.CheckBoxes = true;
            listViewAppData.Columns.AddRange(new ColumnHeader[] { columnHeaderAppName, columnHeaderAppPath, columnHeaderAppSize, columnHeaderAppType });
            listViewAppData.FullRowSelect = true;
            listViewAppData.Location = new System.Drawing.Point(5, 23);
            listViewAppData.Name = "listViewAppData";
            listViewAppData.Size = new System.Drawing.Size(662, 328);
            listViewAppData.TabIndex = 0;
            listViewAppData.UseCompatibleStateImageBehavior = false;
            listViewAppData.View = View.Details;
            // 
            // columnHeaderAppName
            // 
            columnHeaderAppName.Text = "应用名称";
            columnHeaderAppName.Width = 200;
            // 
            // columnHeaderAppPath
            // 
            columnHeaderAppPath.Text = "路径";
            columnHeaderAppPath.Width = 350;
            // 
            // columnHeaderAppSize
            // 
            columnHeaderAppSize.Text = "大小";
            columnHeaderAppSize.Width = 100;
            // 
            // columnHeaderAppType
            // 
            columnHeaderAppType.Text = "类型";
            columnHeaderAppType.Width = 80;
            // 
            // buttonMigrateAppData
            // 
            buttonMigrateAppData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonMigrateAppData.Location = new System.Drawing.Point(567, 357);
            buttonMigrateAppData.Name = "buttonMigrateAppData";
            buttonMigrateAppData.Size = new System.Drawing.Size(98, 27);
            buttonMigrateAppData.TabIndex = 1;
            buttonMigrateAppData.Text = "迁移所选";
            buttonMigrateAppData.UseVisualStyleBackColor = true;
            buttonMigrateAppData.Click += buttonMigrateAppData_Click;
            // 
            // buttonRefreshAppData
            // 
            buttonRefreshAppData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRefreshAppData.Location = new System.Drawing.Point(463, 357);
            buttonRefreshAppData.Name = "buttonRefreshAppData";
            buttonRefreshAppData.Size = new System.Drawing.Size(98, 27);
            buttonRefreshAppData.TabIndex = 2;
            buttonRefreshAppData.Text = "刷新列表";
            buttonRefreshAppData.UseVisualStyleBackColor = true;
            buttonRefreshAppData.Click += buttonRefreshAppData_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 460);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new System.Drawing.Size(527, 388);
            Name = "MainForm";
            Text = "Windows存储迁移助手";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageSettings.ResumeLayout(false);
            groupBoxStoragePolicy.ResumeLayout(false);
            groupBoxProgramFiles.ResumeLayout(false);
            groupBoxProgramFiles.PerformLayout();
            tabPageSoftware.ResumeLayout(false);
            tabPageAppData.ResumeLayout(false);
            tabPageAppData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
