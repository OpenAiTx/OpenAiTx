# Quick Prompt

<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

Eine leistungsstarke Browser-Erweiterung, die sich auf Prompt-Management und schnelle Eingabe konzentriert. Sie hilft Benutzern, eine Prompt-Bibliothek zu erstellen, zu verwalten und zu organisieren und vordefinierte Prompt-Inhalte schnell in jedes Web-Eingabefeld einzufügen, um die Arbeitseffizienz zu steigern.

> Da Browser-Plugins nur im Web verwendet werden können, wurde ein funktional identisches [Raycast-Plugin](https://github.com/wenyuanw/quick-prompt-raycast) als Open Source bereitgestellt, das mit dem Datenformat des Browser-Plugins kompatibel ist und die nahtlose Migration über identische JSON-Daten unterstützt.

## ✨ Funktionen

- 📚 **Prompt-Management**: Einfaches Erstellen, Bearbeiten und Verwalten deiner Prompt-Bibliothek
- 🚀 **Schnelle Eingabe**: Über `/p` schnellen Prompt-Selektor in jedem Web-Eingabefeld auslösen
- ⌨️ Unterstützung für konfigurierbare Tastenkombinationen zum Öffnen des Prompt-Selectors & Speichern von ausgewähltem Text als Prompt
- 📑 Unterstützung für Rechtsklick-Menü, um ausgewählten Text direkt als Prompt zu speichern
- 🎯 Unterstützung für benutzerdefinierte Prompts, einschließlich Kategorien, Titel, Inhalt, Tags und Variablen
- 🧑‍💻 **Variablenunterstützung**: In Prompts können Variablen im Format `{{Variablenname}}` verwendet werden, deren Wert beim Gebrauch eingegeben werden kann
- 💾 **Daten-Backup**: Export und Import der Prompt-Bibliothek zum einfachen Gerätewechsel und zur Sicherung
- 🔗 **Notion-Synchronisation**: Unterstützung für die Synchronisierung der Prompt-Bibliothek mit einer Notion-Datenbank
- 🔍 Unterstützung für Such- und Filterfunktionen für Prompts
- 🌙 Automatisches Anpassen an das helle oder dunkle Systemdesign

## ⚠️ Bekannte Probleme

- Auf der Webseite doubao.com kommt es nach dem Auslösen des Prompt-Selectors mit `/p` in manchen Eingabefeldern vor, dass das `/p` nicht entfernt wird. Keine Sorge, mein langjähriger Partner Cursor und ich arbeiten Tag und Nacht an einer Lösung und hoffen, das Problem bald zu beheben!

## 🚀 Anleitung

1. **Schnelles Auslösen**: Gib `/p` in ein beliebiges Texteingabefeld einer Webseite ein, um den Prompt-Selektor zu öffnen
2. **Tastenkombination zum Öffnen**: Mit `Ctrl+Shift+P` (Windows/Linux) oder `Command+Shift+P` (macOS) Prompt-Selektor öffnen
3. **Prompt auswählen**: Klicke im angezeigten Selektor auf den gewünschten Prompt, dieser wird dann automatisch ins aktuelle Eingabefeld eingefügt
4. **Prompt schnell speichern**: Markiere einen beliebigen Text und speichere ihn mit `Ctrl+Shift+S` (Windows/Linux) oder `Command+Shift+S` (macOS) schnell als Prompt
5. **Prompt über Rechtsklick-Menü speichern**: Markiere beliebigen Text, klicke mit der rechten Maustaste und wähle „Diesen Prompt speichern“, um den ausgewählten Text als Prompt zu sichern
6. **Prompt-Bibliothek exportieren**: Klicke auf der Verwaltungsseite auf „Exportieren“, um alle Prompts als JSON-Datei lokal zu speichern
7. **Prompt-Bibliothek importieren**: Klicke auf der Verwaltungsseite auf „Importieren“, um Prompts aus einer lokalen JSON-Datei zu laden (Unterstützt Zusammenführen oder Überschreiben bestehender Prompts)

## 📸 Interface-Vorschau

Quick Prompt bietet eine intuitive und benutzerfreundliche Oberfläche, mit der du deine Prompts einfach verwalten und nutzen kannst.

### Prompt-Selektor

![Prompt-Selektor](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Prompt-Selektor](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Mit dem `/p`-Kürzel oder der Tastenkombination kannst du in jedem Eingabefeld blitzschnell den Prompt-Selektor aufrufen und bequem die gewünschte Vorlage einfügen.

### Prompt-Management-Seite

![Prompt-Management](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

Auf der Verwaltungsseite kannst du neue Prompts erstellen, bestehende bearbeiten, Tags hinzufügen und Kategorien verwalten. Die Oberfläche ist übersichtlich und die Bedienung einfach.

### Rechtsklick-Menü zum Speichern

![Rechtsklick-Menü speichern](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Markiere einfach einen beliebigen Text auf einer Webseite und speichere ihn mit einem Rechtsklick schnell als Prompt, um deine Effizienz zu steigern.

### Prompt-Variablen-Eingabe

![Prompt-Variablen-Fenster](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Prompts unterstützen Variablenkonfiguration. Nach der Auswahl öffnet sich ein Fenster zur Eingabe der jeweiligen Variablenwerte.

## ⚙️ Benutzerdefinierte Einstellungen

1. Klicke auf das Erweiterungssymbol und dann auf die Schaltfläche „Prompts verwalten“
2. Auf der Verwaltungsseite kannst du:
   - Neue Prompts hinzufügen
   - Bestehende Prompts bearbeiten
   - Nicht benötigte Prompts löschen
   - Prompts mit Tags zur Kategorisierung versehen
   - Die Prompt-Bibliothek zur Sicherung exportieren
   - Eine zuvor gesicherte Prompt-Bibliothek importieren

## 📦 Installationsanleitung

### Installation aus dem Chrome Web Store

Jetzt im Chrome Web Store verfügbar! [Hier klicken zum Download und zur Installation](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Download von GitHub Releases

1. Besuche die [GitHub Releases Seite](https://github.com/wenyuanw/quick-prompt/releases)
2. Lade das neueste, bereits gebaute Plugin-Paket herunter
3. Entpacke die heruntergeladene Datei
4. Installiere die gebaute Erweiterung gemäß den untenstehenden Anweisungen

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
### Installierte Erweiterung einrichten

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
4. Push auf den Branch (`git push origin feature/amazing-feature`)
5. Öffne einen Pull Request

## 👏 Liste der Mitwirkenden

Vielen Dank an alle Entwickler, die zu diesem Projekt beigetragen haben!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---