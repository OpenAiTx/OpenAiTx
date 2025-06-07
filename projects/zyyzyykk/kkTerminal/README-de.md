# kkTerminal

> kkTerminal, ein Terminal für Web-SSH-Verbindung
>
> Autor: [zyyzyykk](https://github.com/zyyzyykk/)
>
> Quellcode: https://github.com/zyyzyykk/kkTerminal
>
> Docker Hub Adresse: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> Vorschau: https://ssh.kkbpro.com/
>
> Aktualisierungsdatum: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">Englisch ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ Schnelle Integration

Verwenden Sie das `iframe`-Tag in HTML-Webseiten für eine schnelle Integration:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 Deployment mit Docker

1. Image herunterladen:

```bash
docker pull zyyzyykk/kkterminal
```

2. Container erstellen und für Port-Mapping ausführen: `-p port:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. Benutzerdefiniertes Artword: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. Zugriff im Browser: `http://server-ip:3000/`

### 🛸 Vorschau

Besuchen Sie folgende Webseite: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**Weitere Modul-Vorschauen**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 Funktionsbeschreibung

1. kkTerminal ist ein Terminal für Web-SSH-Verbindungen. Klicken Sie auf das Terminalsymbol oben links und wählen Sie die Verbindungseinstellungen, um eine SSH-Verbindung herzustellen

2. Unterstützung der schnellen Integration in Drittanbieter-Webseiten über das `iframe`-Tag

3. Unterstützung der individuellen Terminal-Konfiguration über [URL-Parameter](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)

4. Unterstützung der Internationalisierung und Sprachumschaltung zwischen Chinesisch und Englisch

5. Unterstützung der lokalen PC-Bereitstellung, öffnet beim Starten automatisch das Browserfenster

6. Unterstützung der adaptiven Fenstergröße und chinesischer Eingabe

7. Unterstützung benutzerdefinierter Einstellungen, sodass Benutzer Hintergrund-/Vordergrundfarbe, Schriftgröße, Cursor-Stil, TCode für das Terminal usw. wählen können

8. Unterstützung von Neustarts: Nach Änderung der SSH-Verbindungseinstellungen oder benutzerdefinierten Einstellungen erfolgt ein automatischer Neustart, oder es kann nach Trennung der SSH-Verbindung manuell neugestartet werden

9. Unterstützung von Kopieren und Einfügen:

   - Kopieren: Wie beim `Git`-Terminal wird Text automatisch beim Markieren kopiert

   - Einfügen: Wie beim `Cmd`-Terminal, Rechtsklick zum Einfügen (Benötigt Browser-Zugriffsberechtigung)

9. Unterstützung der Dateiverwaltung, öffnen Sie das Dateiverwaltungsmodul zum Anzeigen, Entpacken, Hoch- und Herunterladen von Dateien/Ordnern

10. Unterstützung von Tastenkombinationen wie Mehrfach-/Gesamtauswahl, Kopieren und Einfügen, Ausschneiden, Auswahlwechsel, Öffnen usw.

11. Unterstützung der Dateiansicht und -bearbeitung, Datei ändern und mit `ctrl+s` auf den Remote-Server speichern

12. Unterstützung von [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md), mit dem automatisierte Workflows ähnlich wie Shell-Skripte durch benutzerdefinierten TCode realisiert werden können

13. Unterstützung der Aufzeichnungs- und Cloud-Synchronisationsfunktionen

14. Unterstützung von Kooperieren-, Überwachungs- und Docker-Funktionen

### 👨‍💻 Update-Verlauf

##### zyyzyykk/kkterminal:3.6.0: latest

- Erweiterte Kooperieren-Funktion hinzugefügt
- Erweiterte Überwachungs-Funktion hinzugefügt
- Erweiterte Docker-Funktion hinzugefügt
- Optimierung des Paketvolumens & der Webseitenanzeige

##### zyyzyykk/kkterminal:3.5.6:

- Unterstützung weiterer URL-Parameter
- Editor Text- & Bildgrößen-Prozentsatz hinzugefügt
- Webseitenanzeige optimiert

##### zyyzyykk/kkterminal:3.5.3:

- URL-Parameter zur individuellen Terminal-Konfiguration hinzugefügt
- Fehlerbehebung beim Neustart mehrerer Fenster
- Aufzeichnungs- und Cloud-Synchronisationsfunktionen hinzugefügt
- Teilweise Code-Logik überarbeitet

[**Historische Update-Verläufe**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 Architektur

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ Über dieses Projekt

Liebe Nutzer,

Es tut mir leid, Ihnen mitteilen zu müssen, dass ich aufgrund begrenzter Zeit und Energie die Wartung von `kkTerminal` in Zukunft nicht mehr fortsetzen kann.

Wenn Sie an `kkTerminal` interessiert sind oder die Wartung fortsetzen möchten, können Sie mich gerne kontaktieren oder ein Issue eröffnen.

Wenn Sie Fehler entdecken oder neue Funktionen entwickeln möchten, eröffnen Sie bitte ebenfalls ein Issue.

Abschließend danke ich Ihnen für Ihre Unterstützung von `kkTerminal` und hoffe aufrichtig, dass `kkTerminal` Ihnen wirklich helfen kann.

Mit freundlichen Grüßen,

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 Stars

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---