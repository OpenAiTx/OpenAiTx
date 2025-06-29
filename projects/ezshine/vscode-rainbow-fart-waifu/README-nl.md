# 🌈 Rainbow Fart Waifu
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

Website：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

Talen: [简体中文](./README.zh.md) | Engels

## Samenvatting

----

Dit extensie-idee komt van [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart), alle code herschreven. Compatibel met alle voicepackages en enkele nieuwe functies toegevoegd.

## Speciale Dank

---

1. De extensie bevat het Chinese voice package van [@justkowalski](https://github.com/JustKowalski). Je kunt [meer voice packages van GitHub halen](https://github.com/topics/rainbow-fart) 
2. De extensie bevat cmdmp3win.exe, van [@James K. Lawless](http://jiml.us) 
3. Het standaard waifu-model is van [@二夏](https://erxia207.lofter.com), als je een origineel waifu-model wilt laten ontwerpen dat alleen van jou is, neem dan contact met haar op. 
4. De extensie bevat een ander waifu-model genaamd keysoban, opensource door [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632).

[Meer Waifu-Modellen Verkrijgen](https://github.com/ezshine/live2d-model-collections)

## Ondersteund Platform

---

~~~~
Alleen ondersteund op MacOS en Windows10
~~~~

## Vragen & Antwoorden

---

#### _Waifu wordt niet weergegeven?_
> A: Je moet de waifu-container [downloaden](https://github.com/ezshine/live2d-model-collections). Na het uitpakken van alle bestanden uit het zip-bestand, voer liv2dplayer.exe uit, roep de commandolijst op in vscode en probeer van waifu-model te wisselen.

## Handleiding, Commando’s

---

🌈 Rainbow Fart Waifu Commando’s Weergeven

- "Wissel Voice Packages"
- "Wissel Waifu Modellen"
- "Open Resource Directory"

> Als je een voicepackage of modelpackage download, gebruik dan dit commando om de resource directory te openen en verplaats deze pakketten naar het juiste pad

- "Download Waifu Container en Meer Resources"

## Functies

---

1. De WebUI is verwijderd, geluidsbestanden worden afgespeeld met 'afplay' op MacOS en 'cmdmp3win' op Windows10. 
2. Interactie met WaifuContainer, plaats een virtuele waifu op je bureaublad die je gezelschap houdt tijdens het programmeren.

## VoicePackage Opmerkingen

---

~~~~
Enkele opmerkingen voor het aanpassen van voice packages of het gebruiken van voice packages van het internet
~~~~

1. Gebruik 'contributes.json' in plaats van 'manifest.json'.
2. Voeg teksten toe in 'contributes.json' om te matchen met de voice-inhoud.

~~~~javascript
"contributes": [
    {
        "keywords": ["function", "=>", "func ", "def "],
        "voices":[
            "function_01.mp3",
            "function_02.mp3",
            "function_03.mp3"
        ],
        "texts":[
            "Wow, je callbackfunctie is geweldig geschreven!",
            "Wat dacht je ervan om deze functie naar mij te vernoemen?",
            "Zelfs de krachtigste functie kan mijn liefde voor jou niet uitvoeren!"
        ]
    }
]
~~~~

## Steun Mij

---

Als deze extensie je programmeerplezier vergroot, mag ik dan een cola?

![](./resources/donate.jpg)

**Geniet ervan!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---