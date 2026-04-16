# Quick Prompt

<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

Eine leistungsstarke Browser-Erweiterung, die sich auf das Management und die schnelle Eingabe von Prompts konzentriert. Sie hilft Benutzern, eine Prompt-Bibliothek zu erstellen, zu verwalten und zu organisieren und voreingestellte Prompt-Inhalte schnell in jedes Eingabefeld auf Webseiten einzufügen, um die Arbeitseffizienz zu steigern.

> Da Browser-Erweiterungen nur im Web verwendet werden können, wurde ein funktionsgleiches [Raycast-Plugin](https://github.com/wenyuanw/quick-prompt-raycast) als Open Source veröffentlicht, das mit dem Datenformat der Browser-Erweiterung kompatibel ist und eine nahtlose Migration über identische JSON-Daten ermöglicht.

## ✨ Funktionsmerkmale

- 📚 **Prompt-Verwaltung**: Einfaches Erstellen, Bearbeiten und Verwalten deiner Prompt-Bibliothek
- 🚀 **Schnelle Eingabe**: Schneller Zugriff auf den Prompt-Auswahlbereich durch `/p` in jedem Web-Eingabefeld
- ⌨️ Konfigurierbare Tastenkombinationen zum Öffnen des Prompt-Auswahlbereichs & Speichern von ausgewähltem Text als Prompt
- 📑 Kontextmenü-Unterstützung zum direkten Speichern von ausgewähltem Text als Prompt
- 🎯 Unterstützung für benutzerdefinierte Prompts, inklusive Kategorien, Titel, Inhalt, Tags und Variablen
- 🧑‍💻 **Variablenunterstützung**: Prompts können Variablen im Format `{{Variablenname}}` enthalten, beim Verwenden können konkrete Werte eingetragen werden
- 💾 **Daten-Backup**: Export und Import der Prompt-Bibliothek zur einfachen Geräteübertragung und Sicherung
- 🔗 **Cloud-Synchronisation**: Prompt-Bibliothek kann mit einer Notion-Datenbank oder Gitee/GitHub Gist synchronisiert werden
- 🔍 Unterstützung für Such- und Filterfunktionen in den Prompts
- 🌙 Automatische Anpassung an das helle oder dunkle System-Theme

## 🚀 Anleitung

1. **Schnelle Aktivierung**: Gib `/p` in einem beliebigen Texteingabefeld einer Webseite ein, um den Prompt-Auswahlbereich zu öffnen
2. **Tastenkombination für Auswahlbereich**: Öffne den Prompt-Auswahlbereich mit `Ctrl+Shift+P` (Windows/Linux) oder `Command+Shift+P` (macOS)
3. **Prompt auswählen**: Klicke im Auswahlbereich auf den gewünschten Prompt, er wird automatisch in das aktuelle Eingabefeld eingefügt
4. **Prompt schnell speichern**: Nach Markieren eines beliebigen Textes speichere ihn mit `Ctrl+Shift+S` (Windows/Linux) oder `Command+Shift+S` (macOS) als Prompt
5. **Speichern per Kontextmenü**: Markiere beliebigen Text, klicke mit der rechten Maustaste und wähle "Prompt speichern", um den ausgewählten Inhalt als Prompt zu speichern
6. **Prompt-Bibliothek exportieren**: Klicke im Verwaltungsbereich auf die Schaltfläche "Exportieren", um alle Prompts als JSON-Datei lokal zu speichern
7. **Prompt-Bibliothek importieren**: Klicke im Verwaltungsbereich auf die Schaltfläche "Importieren", um Prompts aus einer lokalen JSON-Datei zu importieren (Unterstützt Zusammenführen oder Überschreiben vorhandener Prompts)

## 📸 Interface-Vorschau

Quick Prompt bietet eine intuitive und benutzerfreundliche Oberfläche, mit der du Prompts einfach verwalten und verwenden kannst.

### Prompt-Auswahlbereich

![Prompt-Auswahlbereich](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Prompt-Auswahlbereich](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Durch das `/p`-Kürzel oder eine Tastenkombination kannst du in jedem Eingabefeld blitzschnell den Prompt-Auswahlbereich öffnen und bequem Prompts auswählen und einfügen.

### Prompt-Verwaltungsseite

![Prompt-Verwaltung](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

Im Verwaltungsbereich kannst du neue Prompts erstellen, vorhandene Prompts bearbeiten, Tags hinzufügen und die Kategorien verwalten. Die Oberfläche ist klar strukturiert und einfach zu bedienen.

### Speichern über das Rechtsklick-Menü

![Speichern über das Rechtsklick-Menü](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Wählen Sie einfach einen beliebigen Text auf der Webseite aus, klicken Sie mit der rechten Maustaste und speichern Sie ihn schnell als Prompt, um die Arbeitseffizienz zu steigern.

### Eingabe von Prompt-Variablen

![Prompt-Variablen-Popup](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Prompts unterstützen die Konfiguration von Variablen, nach Auswahl erscheint ein Popup zur Eingabe des entsprechenden Variablenwerts.

## ⚙️ Benutzerdefinierte Konfiguration

1. Klicken Sie auf das Erweiterungssymbol und dann auf die Schaltfläche „Prompts verwalten“
2. Auf der Verwaltungsseite können Sie:
   - Neue Prompts hinzufügen
   - Bestehende Prompts bearbeiten
   - Nicht benötigte Prompts löschen
   - Prompts mit Tags zur Kategorisierung versehen
   - Die Prompt-Bibliothek zur Sicherung exportieren
   - Eine zuvor gesicherte Prompt-Bibliothek importieren

## 📦 Installationsanleitung

### Installation aus dem App Store

Jetzt im Chrome Web Store verfügbar! [Hier klicken, um herunterzuladen und zu installieren](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Von GitHub Releases beziehen

1. Besuchen Sie die [GitHub Releases Seite](https://github.com/wenyuanw/quick-prompt/releases)
2. Laden Sie das neueste fertig gebaute Plugin-Paket herunter
3. Entpacken Sie die heruntergeladene Datei
4. Installieren Sie die gebaute Erweiterung gemäß der Anleitung unten

### Aus dem Quellcode bauen

1. Repository klonen
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. Abhängigkeiten installieren
   ```bash
   pnpm install
   ```
3. Entwicklung und Aufbau

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```

### Installierte, gebaute Erweiterung

#### Chrome / Edge
1. Öffne die Erweiterungsverwaltung (`chrome://extensions` oder `edge://extensions`)
2. Aktiviere den "Entwicklermodus"
3. Klicke auf "Entpackte Erweiterung laden"
4. Wähle das Verzeichnis `.output/chrome-mv3/` des Projekts aus

#### Firefox
1. Öffne `about:debugging`
2. Klicke auf "Dieser Firefox"
3. Klicke auf "Temporäres Add-on laden"
4. Wähle die Datei `manifest.json` im Verzeichnis `.output/firefox-mv2/` des Projekts aus

## 📄 Lizenz

MIT

## 🤝 Beitragshinweise

Pull Requests und Issues sind willkommen!

1. Forke dieses Repository
2. Erstelle deinen Feature-Branch (`git checkout -b feature/amazing-feature`)
3. Committe deine Änderungen (`git commit -m 'Add some amazing feature'`)
4. Pushe auf den Branch (`git push origin feature/amazing-feature`)
5. Öffne einen Pull Request

## 👏 Liste der Beitragenden

Vielen Dank an alle Entwickler, die zum Projekt beitragen!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---