<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <p>Die folgenden Übersetzungen wurden automatisch mit KI erstellt. Bitte beachten Sie, dass sie Ungenauigkeiten enthalten oder auf ältere Versionen dieser Readme verweisen können.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

In Player Episode Preview
====================
## 📄 Über
Dieses Plugin fügt dem Videoplayer eine Episodenliste hinzu, mit der Sie jede Folge der TV-Serie direkt im Player ansehen können, ohne diesen verlassen zu müssen.

Diese Modifikation unterstützt die folgenden Clients:
* [Jellyfin Web Client](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin Media Player](https://github.com/jellyfin/jellyfin-media-player) (JMP) Desktop-Client

## ✨ Funktionen
* Listet alle Episoden einer Staffel auf
* Wechsel zwischen Staffeln
* Zeigt Episodentitel, Beschreibung, Vorschaubild und Wiedergabefortschritt an
* Zeigt Episodendetails wie Community-Bewertung an
* Episoden als gespielt oder Favorit markieren
* Eine neue Episode starten
* Sollte mit benutzerdefinierten Themes funktionieren

## 📸 Vorschau
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

Verwendetes Theme: (SkinManager) Kaleidochromic
<br>
Diese Vorschau zeigt noch nicht die neuen Buttons zum Markieren einer Episode als abgeschlossen oder Favorit.

## 🔧 Installation

### Jellyfin Web Client (Server)

> [!HINWEIS]
> Es wird dringend empfohlen, [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) mindestens in Version v2.2.1.0 installiert zu haben. Dies hilft, Berechtigungsprobleme beim Ändern der index.html bei jeglicher Installationsart zu vermeiden!
<details open>
<summary> Siehe Anleitung... </summary>

1. Fügen Sie das Manifest `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` als Jellyfin-Plugin-Repository zu Ihrem Server hinzu.
2. Installieren Sie das Plugin `InPlayerEpisodePreview` aus dem Repository.
3. Starten Sie den Jellyfin-Server neu.
</details>

### Jellyfin Media Player (JMP) Desktop Client (Veraltet)
<details>
<summary> Siehe Anleitung... </summary>

**Veraltet seit JMP Version [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)**

Da der neue JMP-Client den aktuellen Web-Player direkt vom Server verwendet, ist es nicht mehr nötig, Änderungen am Client-Code direkt vorzunehmen.

Dies ist die empfohlene Methode, um das Skript auf dem Desktop-Client zu installieren.
Wenn Sie sich nicht wohl dabei fühlen, die Datei nativeshell.js selbst zu bearbeiten (Schritt 3 bis 6), können Sie stattdessen die vollständige Veröffentlichung herunterladen, bei der das Skript bereits zur Datei nativeshell.js hinzugefügt wurde.
Es ist noch unklar, ob es potenzielle Probleme geben könnte, wenn die nativeshell.js-Datei durch die aus der Veröffentlichung ersetzt wird. Daher wird empfohlen, alle folgenden Schritte zu befolgen.

1. Laden Sie die neueste Version [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) oder [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) herunter (enthält das Skript bereits in der nativeshell.js-Datei)
2. Entpacken Sie die ZIP-Datei in Ihr Jellyfin-Verzeichnis (z. B. C:\Program Files\Jellyfin\Jellyfin Media Player)
3. Navigieren Sie innerhalb Ihres Jellyfin-Verzeichnisses zum Ordnerpfad "web-client\extension"
4. Öffnen Sie die Datei "nativeshell.js" in einem Texteditor.
5. Suchen Sie in der Datei den Abschnitt `const plugins = [];`. Fügen Sie am Anfang der Liste eine neue Zeile hinzu und kopieren Sie `'inPlayerEpisodePreviewPlugin',` hinein. Der Abschnitt sollte jetzt ähnlich aussehen:
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. Speichern Sie die Datei und starten Sie den JMP-Client neu.
</details>

## 💡 Fehlerbehebung

### 1. Die Vorschau-Schaltfläche ist nicht sichtbar
Dies hängt höchstwahrscheinlich mit falschen Berechtigungen für die Datei `index.html` zusammen.

<details>
<summary> Siehe eine Liste möglicher Lösungen... </summary>

#### 1.1 Vermeiden Sie dieses Problem mit dem [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) Plugin.

#### 1.2 Besitz innerhalb eines Docker-Containers ändern
Wenn Sie Jellyfin in einem Docker-Container ausführen, können Sie den Besitz mit folgendem Befehl ändern
(ersetzen Sie jellyfin durch Ihren Container-Namen, user und group durch den Benutzer und die Gruppe Ihres Containers):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
Sie können dies als Cron-Job beim Systemstart ausführen.
(Danke an [muisje](https://github.com/muisje) für die Hilfe bei [dieser](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) Lösung)

#### 1.3 Besitzrechte ändern unter einer Windows-Installation
1. Navigieren Sie zu: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. Rechtsklick auf `index.html` → `Eigenschaften` → `Reiter Sicherheit` → Klicken Sie auf `Bearbeiten`
3. Wählen Sie Ihren Benutzer aus der Liste und aktivieren Sie das Kontrollkästchen für das Schreibrecht.
4. Starten Sie sowohl den Server als auch den Client neu.
   (Danke an [xeuc](https://github.com/xeuc) für [diese](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) Lösung)

Falls keine der oben genannten Lösungen funktioniert, werfen Sie bitte einen Blick auf ältere Probleme. Z. B. [hier](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) oder [hier](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
Wenn Sie auf einen Fehler stoßen, den Sie nicht selbst lösen können, öffnen Sie gerne ein Issue.
<br/>Bitte beachten Sie, dass jedes System unterschiedlich ist, was zu unerwartetem Verhalten führen kann. Fügen Sie daher möglichst viele Informationen hinzu.
<br/>Jellyfin-Protokolle und Konsolenprotokolle aus dem Browser (mit Präfix [InPlayerEpisodePreview]) sind immer hilfreich.

## Danksagungen
Die Plugin-Struktur basiert auf und ist inspiriert von dem [Jellyscrub](https://github.com/nicknsy/jellyscrub) Plugin von [NickNSY](https://github.com/nicknsy).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---