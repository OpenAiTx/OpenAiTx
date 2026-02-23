
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Chocolatey Paketmanager automatischer Installer in Wine, praktisch zum schnellen Installieren von Programmen in Wine (und um anschließend Fehler in Wine zu finden ;) )  
Für einige Fehler wurden Workarounds hinzugefügt, wie für Visual Studio Community 2022 und nodejs, siehe weiter unten.  

Da mir während des Lockdowns langweilig war, habe ich ein benutzerdefiniertes winetricks(.ps1) mit Befehlen geschrieben, die ich praktisch finde. Einfach 'winetricks' ausführen, um sie zu sehen.
Für einige Befehle ist ein vollständiger Neustart von Wine erforderlich (aufgrund aktueller Wine-Änderungen). Sie sehen eine Meldungsbox und die Sitzung wird beendet. Starten Sie einfach PowerShell erneut und versuchen Sie den Befehl noch einmal. Wenn dies einmal erledigt wurde, ist es für keinen Befehl mehr nötig.  

Beispiel:

'winetricks vs22_interactiveinstaller'  (--> Sitzung wird beendet)

Führen Sie 'wine powershell' aus

Führen Sie 'winetricks vs22_interactiveinstaller' aus

(Übrigens: Mit 'winetricks vs22_interactive_installer' können Sie auswählen, was über den Visual Studio 2022 Installer installiert werden soll; 'winetricks vs22_interactive_installer' hat mich jetzt in zehn Minuten ins Hauptprogramm gebracht (Desktopentwicklung mit C++ gewählt)).

Installation:
- Laden Sie die Release-Zip-Datei herunter, entpacken Sie sie und führen Sie 'wine ChoCinstaller_0.5c.751.exe' aus (dauert etwa eine Minute)

Optional:
- Führen Sie den Installer mit 'wine ChoCinstaller_0.5a.751.exe /s' aus, dann werden die Installationsdateien (wie Powershell*.msi und dotnet48) in 
  Eigene Dokumente gespeichert und müssen beim Erstellen eines neuen Prefixes nicht erneut heruntergeladen werden)
Optional:
- Führen Sie den Installer mit 'wine ChoCinstaller_0.5a.751.exe /q' aus, um das automatische Öffnen des Powershell-Fensters zu verhindern (nur Installation).

Optional:
- Überprüfen Sie, ob alles funktioniert hat: "choco install chromium" und "start chrome.exe (--no-sandbox ist ab wine-8,4 nicht mehr nötig)"

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
Über PowerShell:

Tipp: Chocolatey installiert normalerweise die neueste Version eines Programms, was neue Wine-Bugs aufdecken kann. Mit einer älteren Softwareversion haben Sie eventuell mehr Glück.
Beispiel:

choco search --exact microsoft-edge --all (--> listet alle Versionen auf)

choco install microsoft-edge --version --version='135.0.3179.98'

Allgemeine Informationen:

- 'wine powershell.exe' startet die PowerShell-Core-Konsole.

 
Über ConEmu:


Die ConEmu-Konsole leidet unter einigen Wine-Bugs:
  - Ctrl^C zum Beenden eines Programms, das nicht zur Konsole zurückkehrt, funktioniert nicht. Verwenden Sie stattdessen Shift^Ctrl^C.
  - Die Auswahl von Text im ConEmu-Fenster (für Kopieren/Einfügen) hebt die Auswahl nicht hervor. Es ist ein sehr trauriger Hack gegen neuere Wine-Versionen enthalten, der dies umgeht, sodass das Hervorheben jetzt einfach funktionieren sollte.
   
Über winetricks(.ps1):

- Wenn Sie es nicht aufrufen ('winetricks' in der Powershell-Konsole), wird nichts heruntergeladen, also entsteht kein Overhead.
- Viele Verben (wie Powershell 5.1) benötigen einige essentielle Dateien, um Inhalte aus msu-Paketen zu extrahieren. Die Installation dieser essenziellen Dateien erfordert zunächst große Downloads und dauert beim ersten Mal lange. Aber sobald alles zwischengespeichert ist, geht es schnell. Wenn Sie zum Beispiel zuerst 'winetricks ps51' ausprobieren, dauert dies etwa 15 Minuten. Einige andere Verben benötigen beim ersten Aufruf etwa 5 Minuten. Aber nach einmaligem Aufruf dieses Verbs ist die Unannehmlichkeit behoben.
- Dateien werden im Verzeichnis Eigene Dokumente zwischengespeichert. Wenn Sie alle Verben aufrufen, werden dort etwa 800 MB belegt.
- Hoffentlich bessere 64-Bit-Unterstützung für verschiedene Verben.
- Möglichkeit, eine Datei zu extrahieren und (zu versuchen) aus einer msu-Datei zu installieren. Führen Sie 'winetricks install_dll_from_msu' aus, um zu sehen wie.
- Ein rudimentäres Powershell 5.1.
- Experimentelle dotnet481-Installation sowie dotnet35 (wird eventuell von Anwendungen benötigt, die mit der aktuellen dotnet48-Installation nicht zufrieden sind).
- Autotab-Vervollständigung. Hinweis: Bei Verwendung mehrerer Verben in der Befehlszeile müssen diese ab sofort durch ein Komma getrennt werden (so handhabt Powershell mehrere Argumente)
  Also funktioniert 'winetricks riched20 gdiplus' nicht mehr, verwenden Sie stattdessen 'winetricks riched20,gdiplus'
- Einige Programme lassen sich aufgrund von Wine-Bugs nicht via Chocolatey installieren/ausführen. Ich habe dafür einige Workarounds in winetricks hinzugefügt, siehe unten.
- Spezielle Verben (winetricks vs19, vs22 und vs22_interactive_installer), um funktionierende Visual Studio Community 2019 und 2022 zu installieren (siehe Screenshot, >10 Min. Installationszeit und benötigt ca. 10 GB! Nach der Installation starten Sie devenv.exe aus dem Verzeichnis c:\Programme\Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/)
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- Spezielles Verb, um Zugriff auf verschiedene Unix-Befehle wie grep, sed, file, less, curl usw. zu erhalten (winetricks git.portable, Hinweis: Einige Befehle funktionieren aufgrund von Wine-Bugs noch nicht)
- Ebenfalls enthalten sind einige Powershell-Skripte, die von im Internet gefundenen Codeschnipseln angepasst wurden:
    - Wie man eine exe in ein Powershell-Skript über Invoke-ReflectivePEInjection einbettet (die exe erscheint nicht im Tasklist).
    - Wie man schicke Messageboxen erstellt
    - Wie man ein Powershell-Skript (ps1) in eine exe umwandelt.
    - Und einige weitere
 
     
Über Systemprogramme:

Es wurde eine Funktion hinzugefügt, um einfache Systemprogramme wie z.B. setx.exe durch eine Funktion in
c:\\Program Files\Powershell\7\profile.ps1 zu ersetzen. Oder um fehlende Systemprogramme wie getmac.exe hinzuzufügen.
Wenn Programme aufgrund nicht ausreichender oder fehlender Systemprogramme fehlschlagen, kann man eine
Funktion schreiben, die das gewünschte Ergebnis des Programms zurückgibt.
Wie in profile.ps1 habe ich (unter anderem) ein wmic.exe hinzugefügt, das etwas mehr Optionen unterstützt,
und ein einfaches setx.exe.
Oder man manipuliert einfach die Argumente, die an das Systemprogramm übergeben werden. Siehe profile.ps1 und choc_install.ps1.
Keine Garantie, dass dies auch für komplexere Programme funktioniert...
 
Anmerkungen:


  - NICHT auf einem bestehenden wineprefix verwenden, sondern nur auf einem frisch neu erstellten Prefix! Der Installer installiert dotnet48 einfach selbst und verändert Registry-Schlüssel.
    Wenn bereits eine dotnet-Version mit dem regulären winetricks.sh installiert wurde, wird es wahrscheinlich fehlschlagen, und selbst wenn es funktioniert, endet man wahrscheinlich mit einem kaputten Prefix.
    Wenn Programme mit dem regulären winetricks.sh installiert werden müssen, verwenden Sie KEINE der dotnet*-Verben.
    Übrigens sind die Verben 'Arial' und 'd3dcompiler_47' bereits standardmäßig installiert.
  - WINEARCH=win32 wird _nicht_ unterstützt!
  - Ein Update von einer vorherigen Version wird derzeit (noch) nicht unterstützt, vielleicht später

Kompilieren:
  - Wenn Sie selbst kompilieren möchten, statt Binärdateien herunterzuladen: siehe Kompilationsanweisungen in mainv1.c und installer.c
  - Kopieren Sie dann choc_install.ps1 in dasselbe Verzeichnis
  - Führen Sie dann 'wine ChoCinstaller_0.5a.735.exe' aus
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---