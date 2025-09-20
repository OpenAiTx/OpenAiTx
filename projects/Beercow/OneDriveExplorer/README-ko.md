# OneDriveExplorer 요약

OneDriveExplorer는 `<UserCid>.dat`, `<UserCid>.dat.previous` 및/또는 SQLite 데이터베이스에서 OneDrive의 폴더 구조를 재구성하기 위한 명령줄 및 GUI 기반 애플리케이션입니다. 또한 확장자가 `.odl`, `.odlgz`, `.odlsent` 및 `.aold`인 OneDrive 로그 파싱을 지원합니다. 로그 파싱은 Yogesh Khatri의 작업 [odl.py](https://github.com/ydkhatri/OneDrive)에 크게 기반합니다.

## 사용법

설정 파일은 다음 위치에서 찾을 수 있습니다:  
 **Windows**
 * \AppData\Local\Microsoft\OneDrive\settings\Business<span style="color:yellow"><1-9></span>
 * \AppData\Local\Microsoft\OneDrive\settings\Personal
 
 **macOS**
 * /Users/\<username>/Library/Application Support/Onedrive
 
로그 파일은 다음 위치에서 찾을 수 있습니다:  
**Windows**
 * \AppData\Local\Microsoft\OneDrive\logs\Business<span style="color:yellow"><1-9></span>
 * \AppData\Local\Microsoft\OneDrive\logs\Personal
 
 **macOS**
 * /Users/\<username>/Library/Logs/OneDrive
 
 로그 파일은 `ObfuscationStringMap.txt` 및/또는 [`general.keystore`, `vault.keystore`] 파일이 있을 경우 난독화가 해제됩니다.

### 요구사항

이 프로젝트는 여러 추가 모듈이 필요합니다. 제공된 requirements.txt 파일로 다음과 같이 설치할 수 있습니다:

```bash
python3 -m pip install -r requirements.txt
```
<span style="color:red">**&#42;참고:** pytsk3와 quickxorhash는 설치를 위해 컴파일러가 필요합니다. 실행 파일 사용을 권장합니다.</span>

### 명령줄

![cmd_help](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/cmd_help.png)

OneDriveExplorer를 사용하려면 단순히 `-f` 인수에 `.\<UserCid>.dat` 파일을 제공하면 됩니다.


```bash
OneDriveExplorer.exe -f \AppData\Local\Microsoft\OneDrive\settings\Personal/Business<1-9>\d1a7c039-6175-4ddb-bcdb-a8de45cf1678.dat
```

OneDrive의 최신 버전은 SQLite로 전환되었습니다. 대신 -s 스위치를 사용하십시오.

```bash
OneDriveExplorer.exe -s \AppData\Local\Microsoft\OneDrive\settings\Personal/Business<1-9>
```

Depending on the options, OneDriveExplorer can produce JSON, CSV, or HTML files of the parsed data. The `--pretty` option can be used to output the JSON into a more human readable layout.

A user registry hive can be supplied with the `-r` argument. This will resolve some of the mount points associated with OneDrive. Along with the registry hive, $Recycle.Bin can be added with the `-rb` option to look for deleted files.

### Example output

#### JSON

![json](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/json.png)

#### CVS

![csv](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/csv.png)

#### HTML

![html](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/html.png)

## GUI

The GUI consists of three panes: the folder structure on the left, file pane in the middle, and details on the right. By clicking on one of the entries in the left pane or file pane, the details pane will populate with various data such as name, whether it is a file or folder, UUIDs and the number of children, if any. There is also a pane on the bottom that correlates log data back to the selected item.

![gui](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/gui.png)

The GUI is capable of parsing the live system and dat/SQLite files, along with loading JSON or CSV from a previously parsed dat/SQLite file. OneDriveExplorer GUI also supports loading multiple files. When loading a dat/SQLite file, an additional dialog will appear to allow you to supply a registry file. This can be disabled by holding down `SHIFT` or disabling it in the preferences menu.

&#42;OneDrive ODL logs can be enabled in the Preferences menu.

![file_menu](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/file_menu.png)  ![hive](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/hive.png)

Through the preferences menu, there are options available for saving the parsed dat/SQLite file to JSON, CSV, and HTML. There is also an option to disable the hive dialogue.

![preferences](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/preference.png)

OneDriveExplorer GUI is also capable of performing a simple search.

![search](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/search.png)

There are right click menus to help perform various tasks and skin options.

![right_click1](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/rc_menu1.png)
![right_click2](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/rc_menu2.png)

![skins](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/skins.png)

The messages dialogue can be accessed by double clicking on the number in the lower right corner. From this dialogue, you can view, clear and export debug messages.

![indicator](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/message_indicator.png)
![messages](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/message.png)

Projects can also be created to save your work without having to parse the files again. This has the advantage of loading the data more quickly.

![project menu](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/project.png)

If ODL log files are enabled, additional tabs for each users logs will be created.

![ODL logs](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/odl.png)

## File location

The default file location of the `.dat` files are:

- Personal: `C:\Users\<USERNAME>\AppData\Local\Microsoft\OneDrive\settings\Personal\<UserCid.dat>`
- Business: `C:\Users\<USERNAME>\AppData\Local\Microsoft\OneDrive\settings\Business<1-9>\<UserCid.dat>`

## Todo


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---