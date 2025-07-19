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


[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

Eine erweiterte Version des klassischen 2048-Spiels, jetzt mit noch mehr spaßigen Features! Dies ist ein kleines Projekt, das ich in meiner Freizeit entwickelt habe—ich hoffe, es bereitet dir Freude!

## 🎯 Spieleinführung

2048 ist ein einfaches, aber süchtig machendes Zahlenschiebe-Spiel. Auf einem 4x4-Raster wische nach oben, unten, links oder rechts, um Felder mit derselben Zahl zu verschmelzen. Das Ziel? Erreiche 2048 (aber du kannst noch weiterspielen und noch höhere Punktzahlen erzielen)!

**So wird gespielt:**
- Benutze die Pfeiltasten oder WASD, um die Felder zu bewegen.
- Wenn zwei Felder mit derselben Zahl zusammenstoßen, verschmelzen sie zu einem.
- Nach jedem Zug erscheint zufällig eine neue 2 oder 4 auf einem freien Platz.
- Das Spiel endet, wenn keine Züge mehr möglich sind.

## ✨ Besondere Funktionen

### 1. Rückgängig-Funktion
- Einen falschen Zug gemacht? Kein Problem!
- Drücke einfach auf den „Rückgängig“-Button, um einen Schritt zurückzugehen.
- Du kannst so oft rückgängig machen, wie du möchtest, sogar bis zum Anfang.
- Lass dir nie wieder durch eine kleine Unachtsamkeit das Spiel verderben!

### 2. Geheimer Cheat-Modus
- Gib die magische Sequenz ein: ←←→→ →→←← (links, links, rechts, rechts,  rechts, rechts, links, links)
- Alle Felder verwandeln sich magisch in 128!
- Das ist ein Easter Egg, nur zum Spaß.
- Profi-Tipp: Schummeln macht Spaß, aber übertreib es nicht! 😉

## 🎯 Demo

🎯 Spiele hier: [http://2048.ct8.pl](http://2048.ct8.pl:9969/)
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
- `script.js`: Frontend-Spielmechanik, einschließlich Züge, Animationen und Spezialfunktionen.
- `styles.css`: Spiel-Styles, sorgt dafür, dass alles schön und responsiv aussieht.
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

Möchten Sie es anpassen? Bearbeiten Sie `styles.css` für ein neues Aussehen oder gehen Sie in `script.js`, um das Gameplay zu verändern. Der gesamte Code ist gut kommentiert und leicht anzupassen!

## 📝 Lizenz

GPL-2.0 Lizenz

## 🤝 Mitwirken

Wird weiterhin aktualisiert! Issues und Pull Requests sind sehr willkommen – lassen Sie uns dieses Spiel gemeinsam noch besser machen!


## 🙏 Danksagungen

Danke an die folgenden Sponsoren für die Unterstützung dieses Projekts:
- [Serv00](https://www.serv00.com/) stellt den Server bereit

---
_Letzte Aktualisierung: Juni 2025_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---