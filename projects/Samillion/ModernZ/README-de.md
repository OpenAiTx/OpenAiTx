<h1 align="center">ModernZ - Eine elegante Alternative OSC für mpv</h1>

Ein elegantes und modernes OSC für [mpv](https://mpv.io/), dieses Projekt ist ein Fork von ModernX, der darauf ausgelegt ist, die Funktionalität durch Hinzufügen weiterer Features zu erweitern und dabei die Kernstandards von mpvs OSC zu bewahren.

![ModernZ-OSC](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/f6854de6-1d57-4b2f-848e-7197933b71aa)

<p align="center">
    <a href="#installation"><strong>Installation »</strong></a>
  <br>
  <a href="#configuration">Konfiguration</a>
  ·
  <a href="#controls">Steuerung</a>
  ·
  <a href="#interactive-menus">Interaktive Menüs</a>
  ·
  <a href="#translations">OSC Sprache</a>
  ·
  <a href="#extras">Zusatzskripte</a>
</p>

## Funktionen

- 🎨 Modernes, anpassbares Interface [[Optionen](#configuration)]
- 📷 Bildbetrachter-Modus mit Zoom-Steuerung [[Details](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 🎛️ Buttons: Download, Playlist, Geschwindigkeitskontrolle, Screenshot, Pin, Loop, Cache und mehr. [[Details](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)]
- 📄 Interaktive Menüs für Playlist, Untertitel, Kapitel, Audiotracks und Audiogeräte [[Details](#interactive-menus)]
- 🌐 Mehrsprachige Unterstützung mit JSON [Locale](#translations)-Integration
- ⌨️ Konfigurierbare Steuerungen [[Details](#controls)]
- 🖼️ Video-Thumbnail-Vorschauen mit [thumbfast](https://github.com/po5/thumbfast)

## Anpassung

Du kannst das Icon-Thema auf `fluent` oder `material` ändern, um deinen Geschmack und Stil anzupassen, indem du die Option `icon_theme` in deiner `modernz.conf` verwendest.

![modernz_fluent](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/3aafac8c-a13f-4840-8119-739523eb7a8e)

![modernz_material](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/e5ad6d06-f071-42ef-9210-296d95906d94)

Kein Fan von weißen Buttons und Text? Du hast volle Kontrolle, um Farben und Button-Layouts individuell anzupassen und so deinen Stil perfekt widerzuspiegeln.

![modernz_osc_controls_top](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/9e3df3af-d3ea-41bb-8c9a-9bf64c1d895a)

![modernz_osc_controls_bottom](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/d4e56bf5-ce7b-44e9-90a3-e27e922dd6bd)

Siehe den Abschnitt [Farbanpassung](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style) im Konfigurationsleitfaden für Details zur Anpassung von Farben und Buttons.

## Interaktive Menüs

ModernZ unterstützt mpvs integrierte Konsole/Select ([v0.40+](https://github.com/mpv-player/mpv/releases/tag/v0.40.0)) für Playlist, Untertitel, Kapitelnavigation und mehr.

[![preview_menus](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/4b7a3139-81f1-409b-98f5-f090a81d5ee6)](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/INTERACTIVE_MENUS.md)

## Installation

1. **Deaktiviere das Standard-OSC**

   - Füge `osc=no` in deiner `mpv.conf` hinzu

2. **Dateien kopieren**

   - Platziere `modernz.lua` im mpv Scripts-Verzeichnis
   - Platziere `fluent-system-icons.ttf` und `material-design-icons.ttf` im mpv Fonts-Verzeichnis
   - (OPTIONAL) Platziere `thumbfast.lua` im mpv Scripts-Verzeichnis

3. **Verzeichnisse**

   ```
   Linux:   ~/.config/mpv/
   Windows: C:/Users/%username%/AppData/Roaming/mpv/
   macOS:   ~/Library/Application Support/mpv/
   ```

4. **Ordnerstruktur** [[mpv Handbuch](https://mpv.io/manual/master/#files)]
   ```
   mpv/
   ├── fonts/
   │   ├── fluent-system-icons.ttf
   │   └── material-design-icons.ttf
   ├── script-opts/
   │   └── modernz.conf
   └── scripts/
   	   ├── modernz.lua
   	   └── thumbfast.lua (optional)
   ```

## Konfiguration

1. Erstelle `modernz.conf` im Ordner `/script-opts`, um Einstellungen anzupassen

   - [Standard modernz.conf herunterladen](https://raw.githubusercontent.com/Samillion/ModernZ/main/modernz.conf)

2. Beispiel einer kurzen Konfiguration:

   ```EditorConfig
   # Seekbar-Farbe (Hex-Format)
   seekbarfg_color=#B7410E

   # Interface-Optionen
   playlist_button=no
   title=${media-title}
   scalewindowed=1.0
   window_top_bar=auto
   ```

Für eine vollständige Liste der Optionen, [siehe die detaillierte Liste hier](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md).

## Steuerung

### Button-Interaktionen

- Linksklick: Primäre Aktion
- Rechtsklick: Sekundäre Aktion
- Mittelklick/Shift+Linksklick: Alternative Aktion

> [!HINWEIS]
> Mittelklick führt dieselbe Funktion wie `Shift+linke Maustaste` aus, was eine einhändige Bedienung ermöglicht

Für eine vollständige Liste der Interaktionen, siehe den [Button-Interaktionen Leitfaden](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md).

### Tastenkürzel

ModernZ setzt standardmäßig keine Tastenkürzel, um Konflikte mit deiner aktuellen Konfiguration zu vermeiden. Du kannst Tastenkürzel in der `input.conf` hinzufügen, falls gewünscht:

```
w   script-binding modernz/progress-toggle           # Fortschrittsanzeige umschalten
x   script-message-to modernz osc-show               # OSC anzeigen
y   script-message-to modernz osc-visibility cycle   # Sichtbarkeitsmodi wechseln
z   script-message-to modernz osc-idlescreen         # Idle-Bildschirm umschalten
```

## Übersetzungen

ModernZ ist derzeit in Englisch verfügbar, du kannst es aber leicht auf deine bevorzugte Sprache umstellen! So funktioniert's:

1. **Lade das Locale-Paket herunter:**

Hole die [modernz-locale.json](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/locale/modernz-locale.json) Datei aus diesem Repository. Diese Datei enthält Übersetzungen für verschiedene Sprachen.

2. **Füge die Locales zu mpv hinzu:**

Kopiere die heruntergeladene `modernz-locale.json` Datei in deinen mpv `/script-opts` Ordner.

3. **Wähle deine Sprache:**

Es gibt zwei Möglichkeiten, deine bevorzugte Sprache einzustellen:

- **Empfohlen:** Verwende die `modernz.conf` Datei

  ```ini
  # Beispielkonfiguration in modernz.conf
  # Sprache auf vereinfachtes Chinesisch setzen
  language=zh
  ```

- **Alternativ:** Bearbeite das `modernz.lua` Skript

  Öffne `modernz.lua` und finde den Abschnitt `user_opts` nahe am Anfang. Ändere den Wert `language` auf deinen bevorzugten Sprachcode:

  ```lua
  local user_opts = {
      -- Allgemein
      language = "en",  -- Ändere dies zu deinem bevorzugten Sprachcode
      ...
  }
  ```

**Mehr Informationen benötigt?**

Für eine vollständige Liste verfügbarer Sprachen, Beitragsrichtlinien und ausführliche Übersetzungsdokumentation besuche die [TRANSLATIONS.md](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md).

## Extras

Die folgenden Skripte habe ich geschrieben und pflege sie, du kannst sie gerne verwenden, wenn sie für dich nützlich sind.

- [Pause-Indicator-Lite](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/pause-indicator-lite) - Ein einfaches Skript, das einen Pausenindikator anzeigt

- [ytdlAutoFormat](https://github.com/Samillion/mpv-ytdlautoformat) - Ein einfaches mpv-Skript, das `ytdl-format` (yt-dlp) automatisch für bestimmte Domains ändert.

- [BoxtoWide](https://github.com/Samillion/mpv-boxtowide) - Ein einfaches mpv-Skript, das das Seitenverhältnis 4:3 von Videodateien/-streams automatisch auf 16:9 ändert.

Für noch mehr nützliche Skripte schau dir das [mpv User Scripts Wiki](https://github.com/mpv-player/mpv/wiki/User-Scripts) an. Es bietet eine breite Palette an Community-beigetragenen Skripten zur Verbesserung deines mpv-Erlebnisses.

## Historie

- [Samillion/ModernZ](https://github.com/Samillion/ModernZ)
  - geforkt von [dexeonify/ModernX](https://github.com/dexeonify/mpv-config/blob/main/scripts/modernx.lua)
    - geforkt von [cyl0/ModernX](https://github.com/cyl0/ModernX)
    - geforkt von [maoiscat/mpv-osc-modern](https://github.com/maoiscat/mpv-osc-modern)

**Warum nochmal forken?**

- Um viele Funktionen hinzuzufügen: [Farbanpassung](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style), [Optionen](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md) und [Locale-Integration](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)
- Um Konsole und Select in das OSC zu integrieren, was mpv inspirierte, es im Standard-OSC zu übernehmen. [ref [#1](https://github.com/mpv-player/mpv/pull/15016), [#2](https://github.com/mpv-player/mpv/pull/15031)]
- Um ein dediziertes Layout für Bilder hinzuzufügen. [[Details](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- Um das Projekt vollständig neu zu gestalten und den Standards des mpv Standard-OSC zu entsprechen, um Kompatibilität zu gewährleisten
- Um alte Fehler und Redundanzen im Code zu beseitigen
    - Was anderen `Modern` Forks erlaubt, ModernZ als Basis zu nutzen, wie z.B. [zydezu/ModernX](https://github.com/zydezu/ModernX). [[Referenz](https://github.com/zydezu/ModernX/releases/tag/0.3.9)]

Im Wesentlichen, um den Ursprung von `modern-osc` zu erhalten und wiederzubeleben.
Das gesagt, verwendet ModernZ immer noch Teile des alten Codes, und jeder vorherige und aktuelle Fork-Autor sowie Mitwirkende verdienen Anerkennung (einschließlich des Standard-osc von mpv), weshalb sie detailliert erwähnt werden.

#### Credits:

- Schriftart: UI Fluent System Icons [[Details](https://github.com/microsoft/fluentui-system-icons)] [[Schriftdatei](https://raw.githubusercontent.com/Samillion/ModernZ/main/fluent-system-icons.ttf)]
- Schriftart modifiziert von [Xurdejl](https://github.com/Xurdejl) für die Verwendung im ModernZ osc
- [mpv](https://github.com/mpv-player/mpv) und deren [osc.lua](https://raw.githubusercontent.com/Samillion/ModernZ/main/player/lua/osc.lua), da ModernZ osc auf den Standard-osc von mpv neu basiert wurde und Aktualisierungen daraus übernimmt
- Alle modernen osc-Ursprünge und deren Forks, wie im [Verlauf](#history) erwähnt
- Alle [Mitwirkenden](https://github.com/Samillion/ModernZ/graphs/contributors), Tester und Nutzer, die direkt oder indirekt bei ModernZ osc geholfen haben ❤️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---