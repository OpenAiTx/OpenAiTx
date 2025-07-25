<div align="right">
  <details>
    <summary >🌐 Andere taal</summary>
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


[Engels](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

Een verbeterde versie van het klassieke 2048 spel, nu met nog meer leuke functies! Dit is een klein project dat ik in mijn vrije tijd heb gemaakt—hopelijk brengt het je wat plezier!

## 🎯 Introductie van het spel

2048 is een eenvoudig maar verslavend spel waarin je getallen samenvoegt. Op een 4x4 raster veeg je omhoog, omlaag, links of rechts om tegels met hetzelfde nummer samen te voegen. Het doel? Bereik 2048 (maar je kunt doorgaan voor een nog hogere score)!

**Hoe te spelen:**
- Gebruik de pijltjestoetsen of WASD om de tegels te verplaatsen.
- Wanneer twee tegels met hetzelfde nummer botsen, worden ze samengevoegd tot één.
- Na elke zet verschijnt er willekeurig een nieuwe 2 of 4 op een lege plek.
- Het spel is voorbij als er geen zetten meer mogelijk zijn.

## ✨ Speciale functies

### 1. Ongedaan maken functie
- Een verkeerde zet gedaan? Geen zorgen!
- Klik gewoon op de "Ongedaan maken" knop om één stap terug te gaan.
- Je kunt zo vaak ongedaan maken als je wilt, helemaal terug naar het begin.
- Laat een slip van de vinger je spel nooit meer verpesten!

### 2. Geheime cheat-modus
- Voer de magische reeks in: ←←→→ →→←← (links, links, rechts, rechts,  rechts, rechts, links, links)
- Alle tegels veranderen magisch in 128!
- Het is een paasei, gewoon voor de lol.
- Pro tip: Cheaten is leuk, maar doe het niet te vaak! 😉

## 🎯 Demo

🎯 Speel hier: [2048.765431.xyz](https://2048.765431.xyz/)
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

Wil je het naar jouw smaak maken? Pas `styles.css` aan voor een nieuw uiterlijk, of duik in `script.js` om de gameplay te veranderen. Alle code is goed becommentarieerd voor gemakkelijk hacken!

## 📝 Licentie

GPL-2.0 licentie

## 🤝 Bijdragen

Nog steeds in ontwikkeling! Issues en Pull Requests zijn zeer welkom—laten we samen deze game nog beter maken!


## 🙏 Erkenningen

Dank aan de volgende sponsors voor het ondersteunen van dit project:
- [IDC.REST](https://idc.rest/) levert de server
- [Serv00](https://www.serv00.com/) levert de server

---
_Laatst bijgewerkt: juni 2025_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---