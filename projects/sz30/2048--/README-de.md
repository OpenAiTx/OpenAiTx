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

Eine erweiterte Version des klassischen 2048-Spiels, jetzt mit noch mehr spaßigen Features! Das ist ein kleines Projekt, das ich in meiner Freizeit entwickelt habe – ich hoffe, es bringt dir Freude!

## 🎯 Spiel-Einführung

2048 ist ein einfaches, aber süchtig machendes Zahlenschiebe-Spiel. Auf einem 4x4-Raster kannst du nach oben, unten, links oder rechts wischen, um Felder mit derselben Zahl zu verschmelzen. Das Ziel? Erreiche 2048 (aber hey, du kannst für noch höhere Punktzahlen weiterspielen)!

**So spielt man:**
- Benutze die Pfeiltasten oder WASD, um die Felder zu bewegen.
- Wenn zwei Felder mit derselben Zahl aufeinandertreffen, verschmelzen sie zu einem.
- Nach jedem Zug erscheint zufällig eine neue 2 oder 4 auf einem freien Feld.
- Das Spiel endet, wenn keine Züge mehr möglich sind.

## ✨ Besondere Features

### 1. Rückgängig-Funktion
- Einen falschen Zug gemacht? Kein Problem!
- Drücke einfach den „Rückgängig“-Button, um einen Schritt zurückzugehen.
- Du kannst so oft rückgängig machen, wie du möchtest, bis zum Spielanfang.
- Lass dir nie wieder durch einen Fehlgriff das Spiel verderben!

### 2. Geheimer Cheat-Modus
- Gib die magische Sequenz ein: ←←→→ →→←← (links, links, rechts, rechts,  rechts, rechts, links, links)
- Alle Felder verwandeln sich magisch in 128!
- Das ist ein Easter Egg, nur zum Spaß.
- Profi-Tipp: Schummeln macht Spaß, aber übertreib es nicht! 😉

## 🎯 Demo

🎯 Hier spielen: [2048.765431.xyz](https://2048.765431.xyz/)
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

Möchtest du es anpassen? Verändere `styles.css` für ein neues Aussehen oder tauche in `script.js` ein, um das Gameplay zu ändern. Der gesamte Code ist gut kommentiert und leicht zu modifizieren!

## 📝 Lizenz

GPL-2.0 Lizenz

## 🤝 Beitrag

Wird weiterhin aktualisiert! Issues und Pull Requests sind sehr willkommen – lass uns dieses Spiel gemeinsam noch besser machen!


## 🙏 Danksagungen

Vielen Dank an die folgenden Sponsoren für die Unterstützung dieses Projekts:
- [IDC.REST](https://idc.rest/), stellt den Server bereit
- [Serv00](https://www.serv00.com/), stellt den Server bereit

---
_Zuletzt aktualisiert: Juni 2025_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---