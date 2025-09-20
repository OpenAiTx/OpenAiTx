# OneDriveExplorer Résumé

OneDriveExplorer est une application en ligne de commande et avec interface graphique pour reconstruire la structure des dossiers de OneDrive à partir des fichiers `<UserCid>.dat`, `<UserCid>.dat.previous` et/ou des bases de données SQLite. Supporte également l'analyse des logs OneDrive avec les extensions `.odl`, `.odlgz`, `.odlsent` et `.aold`. L'analyse des logs est largement basée sur le travail de Yogesh Khatri [odl.py](https://github.com/ydkhatri/OneDrive).

## Utilisation

Les fichiers de configuration se trouvent aux emplacements suivants :  
 **Windows**
 * \AppData\Local\Microsoft\OneDrive\settings\Business<span style="color:yellow"><1-9></span>
 * \AppData\Local\Microsoft\OneDrive\settings\Personal
 
 **macOS**
 * /Users/\<username>/Library/Application Support/Onedrive
 
Les fichiers de logs se trouvent aux emplacements suivants :  
**Windows**
 * \AppData\Local\Microsoft\OneDrive\logs\Business<span style="color:yellow"><1-9></span>
 * \AppData\Local\Microsoft\OneDrive\logs\Personal
 
 **macOS**
 * /Users/\<username>/Library/Logs/OneDrive
 
 Les fichiers de logs seront désobfusqués si le fichier `ObfuscationStringMap.txt` et/ou les fichiers [`general.keystore`, `vault.keystore`] sont présents.

### Exigences

Ce projet nécessite plusieurs modules additionnels. Vous pouvez les installer avec le fichier requirements.txt fourni comme suit :

```bash
python3 -m pip install -r requirements.txt
```

<span style="color:red">**&#42;Remarque :** pytsk3 et quickxorhash nécessitent un compilateur pour l'installation. Il est recommandé d'utiliser les exécutables.</span>

### Ligne de commande

![cmd_help](https://raw.githubusercontent.com/Beercow/OneDriveExplorer/master/./Images/cmd_help.png)

Pour utiliser OneDriveExplorer, fournissez simplement le fichier `.\<UserCid>.dat` à l'argument `-f`

```bash
OneDriveExplorer.exe -f \AppData\Local\Microsoft\OneDrive\settings\Personal/Business<1-9>\d1a7c039-6175-4ddb-bcdb-a8de45cf1678.dat
```

Les versions plus récentes de OneDrive ont basculé vers SQLite. Utilisez plutôt l'option -s.

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