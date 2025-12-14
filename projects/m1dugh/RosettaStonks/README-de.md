
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rosetta Stonks

- [Einleitung](#introduction)
- [Installation](#install)
  - [Chrome](#chrome-basierte-browser)
    - [Visuelle Anleitung](#chrome-basierte-browser)
  - [Firefox](#firefox-basierte-browser)
- [Verwendung](#how-to-use)
  - [Zeit hinzufügen](#zeit-hinzufügen)
    - [Grundlagen](#zeit-hinzufügen-in-grundlagen)
    - [Fluency Builder](#zeit-hinzufügen-in-fluency-builder)
  - [Lektion validieren](#lektion-validieren)
    - [Grundlagen](#lektion-validieren-in-grundlagen)
    - [Fluency Builder](#lektion-validieren-in-fluency-builder)

## Einführung

RosettaStonks ist eine Browser-Erweiterung, mit der man Zeit hinzufügen und Lektionen
auf der Rosetta Stone Sprachlernplattform validieren kann.

> RosettaStonks, und dein Rosetta Stone wird stonks.

## Installation

### Chrome-basierte Browser

➡️ **Neu beim manuellen Installieren von Chrome-Erweiterungen?** Schau dir die [Schritt-für-Schritt-Bilderanleitung](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) an — enthält hilfreiche Screenshots! 🖼️

#### 1. Verwendung des GitHub Release

Um die Erweiterung in einem Chrome-basierten Browser zu nutzen, musst du:

- die Datei `rosettastonks-chrome.tar.gz` aus dem neuesten Release auf
  deinem Rechner herunterladen.
- einen Ordner mit dem Namen `rosettastonks` irgendwo auf deinem Rechner erstellen, um die
  Erweiterung zu speichern
- den folgenden Befehl im `rosettastonks`-Ordner ausführen.

```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. Verwendung des Nix-Paketmanagers

Statt der vorherigen Befehle können Sie auf einem Nix-System mit **Flake-Unterstützung**
die folgenden Befehle ausführen. Dadurch wird ein Ordner unter dem Pfad
`/tmp/rosettastonks` mit allen Dateien installiert.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

Der Ordner ist jetzt unter `/tmp/rosettastonks/` installiert.

**Dieser Abschnitt gilt für alle Benutzer, unabhängig davon, ob Sie die Github-Methode
oder die Nix-Methode verwenden.**

In Ihrem Browser:

- gehen Sie zu `chrome://extensions`
- aktivieren Sie den Schalter `Entwicklermodus`
- klicken Sie auf `Entpackt laden`
- wählen Sie Ihren `rosettastonks`-Ordner aus

### Firefox-basierte Browser

- laden Sie die Datei `rosettastonks.xpi` aus dem neuesten Release herunter.
- alternativ, wenn Sie den Nix-Paketmanager mit Flake-Unterstützung verwenden, können Sie
  den folgenden Befehl ausführen.

```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```
- Gehen Sie in Ihrem Browser zu `about:debugging#/runtime/this-firefox`
- Klicken Sie auf die Einstellungen und gehen Sie zu `Debug Addons`.
- Klicken Sie auf `Temporäres Add-On laden`
- Wählen Sie die Datei `/tmp/rosettastonks.xpi` im Dateiauswahlfenster aus.

_Warnung: Diese Methode installiert die Erweiterung nur vorübergehend. Das bedeutet, dass das Addon deinstalliert wird, wenn Sie Ihren Browser schließen. Dies liegt an den Firefox-Richtlinien, die nicht verifizierte Erweiterungen nicht zulassen._

## Verwendung

### Zeit hinzufügen

#### Zeit hinzufügen in Foundations

Um Zeit im Produkt `foundations` hinzuzufügen, müssen Sie zu Ihren Übungen gehen und
mindestens eine Frage ignorieren oder lösen. Sobald dies erledigt ist, sollte ein Zeitfeld
auf der Erweiterungsseite erscheinen, in das Sie Ihre Zeit eintragen können.

#### Zeit hinzufügen im Fluency Builder

Um Zeit im Produkt `fluency builder` hinzuzufügen, müssen Sie zu Ihren Übungen gehen und
mindestens eine Übung beantworten. Falls das Zeitfeld nicht erscheint, bedeutet das,
dass keine Zeit-Anfrage erkannt wurde. Sie müssen die Frage neu laden und erneut beantworten.
Damit die Zeit hinzugefügt wird, müssen Sie die Lektion abschließen, in der Sie Zeit
hinzugefügt haben.

_Hinweis: Wenn Sie das Zeitfeld nicht sehen, bedeutet das, dass Ihre Aktionen auf der
Rosetta Stone Website nicht dazu geführt haben, dass legitime Zeit hinzugefügt wurde.
Sie müssen daher andere Fragen beantworten._

### Lektion validieren

#### Lektion validieren in Foundations

Um eine Lektion zu validieren, müssen Sie eine Lektion starten und alle Fragen
über die Schaltfläche `Ignorieren` unten rechts durchgehen. Sobald alle
Fragen gesehen wurden, sollte das Klicken auf den Button `Lektion validieren` die
Lektion validieren. Falls nicht, gehen Sie zurück zur Startseite, klicken Sie auf die gleiche Lektion, sie



sollte Sie fragen `Möchten Sie fortfahren oder zurücksetzen?`, Sie können beides wählen und
die Lektion erneut validieren, bis es funktioniert. Es sollte nach maximal 3/4 Mal funktionieren.

#### Lektion im Fluency Builder validieren

Derzeit ist die Funktion zum Validieren von Lektionen auf Rosetta Stonks nicht verfügbar.

## Anwendung bauen

### Den Worker bauen

Der Worker kann mit folgendem Befehl gepackt werden

```
$ deno task build:worker
```

Dadurch wird die Paketdatei `/dist/worker.esm.js` erstellt, welche die Paketdatei
für den Worker ist.

### Frontend bauen

Der Worker kann mit folgendem Befehl paketiert werden

```
$ deno task build:frontend
```

Dadurch wird die Paketdatei `/dist/frontend.esm.js` erstellt, welche die gepackte
Datei für das Frontend ist.

## Paketierung der Erweiterung

### Chrome

Um die Erweiterung für Chrome zu paketieren, kann folgender Befehl ausgeführt werden:

```
$ make chrome
```

### Firefox

Um die Erweiterung für Firefox zu paketieren, kann folgender Befehl ausgeführt werden:

```
$ make firefox
```

Dadurch wird `rosettastonks.xpi` erzeugt, die Datei für die Erweiterung, die in
Firefox geladen werden kann.

📸 Bevorzugen Sie visuelle Darstellungen? Sehen Sie sich die [Chrome-Installationsanleitung mit Bildern](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) an.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---