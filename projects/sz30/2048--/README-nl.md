<div align="right">
  <details>
    <summary >🌐 Andere Taal</summary>
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

Een verbeterde versie van het klassieke 2048-spel, nu met nog meer leuke functies! Dit is een klein project dat ik in mijn vrije tijd heb gemaakt—ik hoop dat het je wat plezier brengt!

## 🎯 Introductie van het Spel

2048 is een eenvoudig maar verslavend spel waarin je cijfers samenvoegt. Op een 4x4 raster veeg je omhoog, omlaag, naar links of naar rechts om tegels met hetzelfde nummer samen te voegen. Het doel? Bereik 2048 (maar hé, je kunt doorgaan voor nog hogere scores)!

**Hoe te spelen:**
- Gebruik de pijltjestoetsen of WASD om de tegels te bewegen.
- Wanneer twee tegels met hetzelfde nummer botsen, worden ze samengevoegd tot één.
- Na elke zet verschijnt er willekeurig een nieuwe 2 of 4 op een lege plek.
- Het spel eindigt wanneer er geen zetten meer mogelijk zijn.

## ✨ Speciale Functies

### 1. Ongedaan maken Functie
- Een verkeerde zet gemaakt? Geen zorgen!
- Klik gewoon op de "Ongedaan maken"-knop om één stap terug te gaan.
- Je kunt zo vaak ongedaan maken als je wilt, helemaal terug naar het begin.
- Laat een foutje nooit meer je spel verpesten!

### 2. Geheime Cheatmodus
- Voer de magische reeks in: ←←→→ →→←← (links, links, rechts, rechts,  rechts, rechts, links, links)
- Alle tegels veranderen magisch in 128!
- Het is een paasei, gewoon voor de lol.
- Pro tip: Cheaten is leuk, maar doe het niet te vaak! 😉

## 🎯 Demo

🎯 : [Speel hier](http://34.150.49.127:5000/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 Projectstructuur
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
**Bestandsomschrijvingen:**
- `2048.py`: Backendserver geschreven met Flask, handelt de spel-logica en API-verzoeken af.
- `script.js`: Frontend spel-logica, inclusief zetten, animaties en speciale functies.
- `styles.css`: Spelstijlen, zorgt ervoor dat alles er netjes en responsief uitziet.
- `index.html`: De hoofdpagina die alles samenbrengt.

## 🚀 Aan de slag

**Methode 1: Release downloaden**
1. Download de laatste release.
2. Zorg dat je Python 3.x geïnstalleerd hebt.
3. Installeer afhankelijkheden: `pip install flask`
4. Voer uit: `python 2048.py`
5. Open je browser en ga naar: [http://localhost:9969](http://localhost:9969)

**Methode 2: Clonen van GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 Aanpassen

Wil je het eigen maken? Pas `styles.css` aan voor een nieuwe look, of duik in `script.js` om de gameplay te veranderen. Alle code is goed becommentarieerd voor eenvoudig aanpassen!

## 📝 Licentie

GPL-2.0 licentie

## 🤝 Bijdragen

Nog steeds in ontwikkeling! Issues en Pull Requests zijn van harte welkom—laten we samen deze game nog beter maken!


## 🙏 Dankbetuigingen

Dank aan de volgende sponsors voor het steunen van dit project:
- [Geen](https://#/) voor het leveren van de server
- [Serv00](https://www.serv00.com/) voor het leveren van de server

---
_Laatst bijgewerkt: aug. 2025_





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---