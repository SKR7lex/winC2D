# winC2D ����ָ�� / Translation Guide

## ��ǰ����֧��״̬ / Current Language Support Status

| ���� / Language | ���� / Code | ״̬ / Status | ��ɶ� / Completion |
|-----------------|-------------|--------------|-------------------|
| English | `en` | ? ���� / Complete | 100% |
| �������� / Simplified Chinese | `zh-CN` | ? ���� / Complete | 100% |
| �ձ��Z / Japanese | `ja` | ?? ������ / Needs Translation | 0% (English fallback) |
| ??? / Korean | `ko` | ?? ������ / Needs Translation | 0% (English fallback) |
| Fran?ais / French | `fr` | ?? ������ / Needs Translation | 0% (English fallback) |
| Deutsch / German | `de` | ?? ������ / Needs Translation | 0% (English fallback) |
| Espa?ol / Spanish | `es` | ?? ������ / Needs Translation | 0% (English fallback) |
| ������ܧڧ� / Russian | `ru` | ?? ������ / Needs Translation | 0% (English fallback) |

## �����ӷ��� / How to Add Translations

### ���� 1: �༭��Դ�ļ� / Step 1: Edit Resource File

������Ҫ��������ԣ��༭��Ӧ����Դ�ļ���
Edit the corresponding resource file for your target language:

- ���� / Japanese: `Strings.ja.resx`
- ���� / Korean: `Strings.ko.resx`
- ���� / French: `Strings.fr.resx`
- ���� / German: `Strings.de.resx`
- �������� / Spanish: `Strings.es.resx`
- ���� / Russian: `Strings.ru.resx`

### ���� 2: �����ַ��� / Step 2: Translate Strings

����Դ�ļ��У��ҵ����� `<value>` ��ǩ�е�Ӣ���ı��������Ŀ�����ԡ�
In the resource file, find all English text within `<value>` tags and translate to your target language.

���� / Example:

```xml
<!-- Ӣ�� / English -->
<data name="Title.MainWindow" xml:space="preserve">
  <value>winC2D</value>
</data>

<!-- ����Ϊ���� / Translate to Japanese -->
<data name="Title.MainWindow" xml:space="preserve">
  <value>winC2D</value>
</data>

<!-- ����Ϊ���� / Translate to French -->
<data name="Title.MainWindow" xml:space="preserve">
  <value>winC2D</value>
</data>
```

### ���� 3: ��Ҫ�ַ����б� / Step 3: Important Strings List

��������Ҫ�������Ҫ�ַ������
Here are the main categories of strings to translate:

#### ���ڱ��� / Window Titles
- `Title.MainWindow` - �����ڱ���
- `Title.Tip` - ��ʾ
- `Title.Error` - ����
- `Log.Title` - Ǩ����־
- `Settings.Title` - ����

#### �˵��� / Menu Items
- `Menu.Log` - Ǩ����־
- `Menu.Language` - ����

#### ѡ� / Tabs
- `Tab.SoftwareMigration` - ���Ǩ��
- `Tab.UserFolders` - �û��ļ���
- `Tab.AppData` - AppData (mklink)
- `GroupBox.SystemSettings` - ϵͳ����

#### ��ť / Buttons
- `Button.MigrateSelected` - Ǩ����ѡ
- `Button.RefreshAppData` - ˢ���б�
- `Button.Browse` - ���
- `Button.Apply` - Ӧ��
- `Button.Reset` - �ָ�Ĭ��
- `Button.Rollback` - �ع���ѡ
- `Button.OpenSettings` - ������
- `Button.OpenWindowsStorage` - �� Windows ����

#### �б��� / Column Headers
- `Column.SoftwareName` - �������
- `Column.InstallPath` - ��װ·��
- `Column.Size` - ��С
- `Column.FolderName` - �ļ�������
- `Column.CurrentPath` - ��ǰ·��
- `Column.AppName` - Ӧ������
- `Column.AppPath` - ·��
- `Column.AppSize` - ��С
- `Column.AppType` - ����

#### �ļ������� / Folder Names
- `Folder.Documents` - �ĵ�
- `Folder.Pictures` - ͼƬ
- `Folder.Downloads` - ����
- `Folder.Videos` - ��Ƶ
- `Folder.Desktop` - ����

#### ���� / Settings
- `Settings.ProgramFilesSection` - Program Files λ�ã���ͳ�������
- `Settings.ProgramFilesPath` - Program Files Ĭ��λ�ã�64λ��
- `Settings.ProgramFilesPathX86` - Program Files Ĭ��λ�ã�32λ��
- `Settings.CustomX86Path` - �Զ��� 32λ ����·��
- `Settings.ProgramFilesNote` - ��ʾ��Ϣ
- `Settings.StoragePolicySection` - �����ݱ���λ��
- `Settings.StoragePolicyNote` - ��ʾ��Ϣ

#### ��Ϣ / Messages
- `Msg.SelectFolders` - ��ѡ��ҪǨ�Ƶ��ļ���
- `Msg.SelectSoftware` - ��ѡ��ҪǨ�Ƶ����
- `Msg.SelectAppData` - ��ѡ��ҪǨ�Ƶ�AppData�ļ���
- `Msg.MigrateCompleted` - Ǩ����ɣ��ɹ���{0}��ʧ�ܣ�{1}
- `Msg.MklinkNote` - ע�⣺�˲���ʹ�� mklink ������������
- `Msg.InvalidPath` - ��������Ч���ļ���·��
- `Msg.SettingsApplied` - �����ѳɹ�Ӧ�ã�
- `Msg.SelectLogEntry` - ����ѡ��Ҫ�ع���Ǩ�Ƽ�¼
- `Msg.RollbackSuccess` - �ع��ɹ���

### ���� 4: ���Է��� / Step 4: Test Translation

1. ������Ŀ / Build the project
2. ���г��� / Run the application
3. �ڲ˵���ѡ���������� / Select your language from the menu
4. �������UIԪ���Ƿ���ȷ��ʾ / Check if all UI elements display correctly

### ���� 5: �ύ���� / Step 5: Submit Contribution

����������ĳ�����Եķ��룬��ӭ�ύ Pull Request��
If you've completed a translation, feel free to submit a Pull Request!

## ����ע������ / Translation Notes

1. **���ָ�ʽռλ��** / Keep format placeholders
   - �� `{0}`, `{1}` �ȱ��뱣���ڷ������ı���
   - Placeholders like `{0}`, `{1}` must be kept in the translated text

2. **�����ַ�** / Special characters
   - `?` ��Ϣͼ��Ӧ���� / Info icon should be kept
   - `\n` ���з�Ӧ���� / Newline characters should be kept

3. **��������** / Length constraints
   - ��ť�ı�Ӧ������� / Button text should be concise
   - �б���Ӧ�ʺ��п� / Column headers should fit column width

4. **������** / Context
   - �������ʣ���ο�Ӣ�ĺ����İ汾 / When in doubt, refer to English and Chinese versions
   - ����UI��һ���Ժ�רҵ�� / Maintain UI consistency and professionalism

## ��ϵ��ʽ / Contact

���з���������⣬���� GitHub Issues �������
For translation-related questions, please create an issue on GitHub.

## ����ʾ�� / Translation Examples

### ���﷭��ʾ�� / Japanese Translation Example

```xml
<!-- Ӣ�� English -->
<data name="Button.Browse" xml:space="preserve">
  <value>Browse</value>
</data>

<!-- ���� Japanese -->
<data name="Button.Browse" xml:space="preserve">
  <value>����</value>
</data>
```

### ����������ձ� / Common Terms Translation Table

| English | ���� | �ձ��Z | ??? | Fran?ais | Deutsch | Espa?ol | ������ܧڧ� |
|---------|------|--------|--------|----------|---------|---------|---------|
| Browse | ��� | ���� | ???? | Parcourir | Durchsuchen | Examinar | ���ҧ٧�� |
| Apply | Ӧ�� | �m�� | ?? | Appliquer | Anwenden | Aplicar | ����ڧާ֧ߧڧ�� |
| Reset | �ָ�Ĭ�� | �ꥻ�å� | ??? | R��initialiser | Zur��cksetzen | Restablecer | ���ҧ���ڧ�� |
| Documents | �ĵ� | �ɥ������ | ?? | Documents | Dokumente | Documentos | ����ܧ�ާ֧ߧ�� |
| Pictures | ͼƬ | �ԥ����� | ?? | Images | Bilder | Im��genes | ���٧�ҧ�ѧا֧ߧڧ� |
| Downloads | ���� | �������`�� | ???? | T��l��chargements | Downloads | Descargas | ���ѧԧ��٧ܧ� |
| Videos | ��Ƶ | �ӥǥ� | ??? | Vid��os | Videos | V��deos | ���ڧէ֧� |
| Desktop | ���� | �ǥ����ȥå� | ?? ?? | Bureau | Desktop | Escritorio | ���ѧҧ��ڧ� ����� |
| Migration | Ǩ�� | ���� | ?????? | Migration | Migration | Migraci��n | ���ڧԧ�ѧ�ڧ� |
| Software | ��� | ���եȥ����� | ????? | Logiciel | Software | Software | �����ԧ�ѧާާߧ�� ��ҧ֧��֧�֧ߧڧ� |
| Settings | ���� | �O�� | ?? | Param��tres | Einstellungen | Configuraci��n | ���ѧ����ۧܧ� |
| Language | ���� | ���Z | ?? | Langue | Sprache | Idioma | ���٧�� |

## ʹ�� Visual Studio �༭��Դ�ļ� / Editing with Visual Studio

**�Ƽ����� / Recommended Method**:
1. �� Visual Studio �д���Ŀ
2. ˫�� `.resx` �ļ���򿪿��ӻ���Դ�༭��
3. �ڱ༭����ֱ���޸ķ����ı�
4. Visual Studio ���Զ������������

**��Ҫ��ʾ / Important Notes**:
- ?? ��Ҫʹ����ͨ�ı��༭���༭ `.resx` �ļ������ܵ��±������
- ? �Ƽ�ʹ�� Visual Studio �� Visual Studio Code �� resx �༭����չ
- ? ���� resx �ļ�����ʹ�� UTF-8 with BOM ����

## ��ǰ������ɶ� / Current Translation Completion

| ���� | ������� | ����UI | ��Ϣ��ʾ | ����ҳ�� | ��־ҳ�� | ����ɶ� |
|------|----------|--------|----------|----------|----------|----------|
| English (en) | ? | ? | ? | ? | ? | **100%** |
| �������� (zh-CN) | ? | ? | ? | ? | ? | **100%** |
| �ձ��Z (ja) | ? | ?? | ?? | ?? | ?? | **20%** |
| ??? (ko) | ? | ? | ? | ? | ? | **0%** |
| Fran?ais (fr) | ? | ? | ? | ? | ? | **0%** |
| Deutsch (de) | ? | ? | ? | ? | ? | **0%** |
| Espa?ol (es) | ? | ? | ? | ? | ? | **0%** |
| ������ܧڧ� (ru) | ? | ? | ? | ? | ? | **0%** |

## ��л������ / Thanks to Contributors

��л����Ϊ winC2D ���ʻ��������׵ķ����ߣ�
Thanks to all translators who contribute to winC2D internationalization!

### ��γ�Ϊ������ / How to Become a Contributor

1. Fork ����Ŀ / Fork this repository
2. ѡ��һ�����Կ�ʼ���� / Choose a language to translate
3. �༭��Ӧ�� `Strings.xx.resx` �ļ� / Edit the corresponding `Strings.xx.resx` file
4. ���Է���Ч�� / Test your translation
5. �ύ Pull Request / Submit a Pull Request
6. �������ֽ������ڹ������б��� / Your name will be added to the contributors list!

## ���빤���Ƽ� / Recommended Translation Tools

- **Visual Studio 2022** - ���� resx �༭�� / Built-in resx editor
- **Resxer** - ��ѵ� resx �༭���� / Free resx editor tool
- **DeepL** - ��������ο� / Machine translation reference (�����Ϻ� / Good quality)
- **Google Translate** - ��������ο� / Machine translation reference

**ע��**: ������������ο���������˹���˺�����
**Note**: Machine translations are for reference only, please review and correct manually
