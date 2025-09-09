<div align="right">
  <details>
    <summary >🌐 Andere Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

Eine verbesserte Version des klassischen 2048-Spiels, jetzt mit noch mehr spaßigen Features! Das ist ein kleines Projekt, das ich in meiner Freizeit zusammengestellt habe—ich hoffe, es macht euch Freude!

## 🎯 Spiel-Einführung

2048 ist ein einfaches, aber süchtig machendes Zahlen-Fusionsspiel. Auf einem 4x4-Raster schiebst du nach oben, unten, links oder rechts, um Felder mit derselben Zahl zu verschmelzen. Das Ziel? Erreiche 2048 (aber hey, du kannst für noch höhere Punktzahlen weitermachen)!

**So spielst du:**
- Benutze die Pfeiltasten oder WASD, um die Felder zu bewegen.
- Wenn zwei Kacheln mit derselben Zahl zusammenstoßen, verschmelzen sie zu einer.
- Nach jedem Zug erscheint zufällig eine neue 2 oder 4 auf einem freien Feld.
- Das Spiel endet, wenn keine weiteren Züge möglich sind.

## ✨ Besondere Funktionen

### 1. Rückgängig-Funktion
- Einen falschen Zug gemacht? Kein Problem!
- Einfach auf die Schaltfläche „Rückgängig“ klicken, um einen Schritt zurückzugehen.
- Sie können beliebig oft rückgängig machen, bis ganz zum Anfang.
- Nie wieder ruiniert ein falscher Fingertipp Ihr Spiel!

### 2. Geheimer Cheat-Modus
- Geben Sie die magische Sequenz ein: ←←→→ →→←← (links, links, rechts, rechts,  rechts, rechts, links, links)
- Alle Kacheln verwandeln sich magisch in 128!
- Es ist ein Easter Egg, nur zum Spaß.
- Profi-Tipp: Schummeln macht Spaß, aber übertreiben Sie es nicht! 😉

## 🎯 Demo

🎯 : [Hier spielen](http://34.150.49.127:5000/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 Projektstruktur
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**Dateibeschreibungen:**
- `2048.py`: Backend-Server geschrieben mit Flask, verarbeitet Spiellogik und API-Anfragen.
- `script.js`: Frontend-Spiellogik, einschließlich Züge, Animationen und Spezialfunktionen.
- `styles.css`: Spiel-Styles, sorgen dafür, dass alles schön und responsiv aussieht.
- `index.html`: Die Hauptseite, die alles zusammenführt.

## 🚀 Erste Schritte

**Methode 1: Release herunterladen**
1. Lade das neueste Release herunter.
2. Stelle sicher, dass Python 3.x installiert ist.
3. Installiere Abhängigkeiten: `pip install flask`
4. Starte: `python 2048.py`
5. Öffne deinen Browser und gehe zu: [http://localhost:9969](http://localhost:9969)

**Methode 2: Von GitHub klonen**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```

## 🎨 Anpassung

Möchtest du es anpassen? Ändere `styles.css` für einen neuen Look oder tauche in `script.js` ein, um das Gameplay zu verändern. Der gesamte Code ist gut kommentiert und leicht zu modifizieren!

## 📝 Lizenz

GPL-2.0 Lizenz

## 🤝 Mitwirken

Wird noch aktualisiert! Issues und Pull Requests sind herzlich willkommen – lasst uns dieses Spiel gemeinsam noch großartiger machen!


## 🙏 Danksagungen

Vielen Dank an die folgenden Sponsoren für die Unterstützung dieses Projekts:
- [Keiner](https://#/) stellt den Server bereit
- [Serv00](https://www.serv00.com/) stellt den Server bereit

---
_Zuletzt aktualisiert: Aug. 2025_




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---