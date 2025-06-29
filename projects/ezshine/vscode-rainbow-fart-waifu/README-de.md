# 🌈 Rainbow Fart Waifu
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

Website：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

Sprachen: [简体中文](./README.zh.md) | Englisch

## Zusammenfassung

----

Die Idee dieser Erweiterung stammt von [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart), der gesamte Code wurde neu geschrieben. Kompatibel mit allen Sprachpaketen und einige neue Funktionen wurden hinzugefügt.

## Besonderer Dank

---

1. Die Erweiterung enthält das chinesische Sprachpaket von [@justkowalski](https://github.com/JustKowalski). Du kannst [weitere Sprachpakete von GitHub erhalten](https://github.com/topics/rainbow-fart).
2. Die Erweiterung enthält cmdmp3win.exe von [@James K. Lawless](http://jiml.us).
3. Das Standard-Waifu-Modell stammt von [@二夏](https://erxia207.lofter.com). Wenn du ein eigenes, nur dir gehörendes Waifu-Design möchtest, kontaktiere sie.
4. Die Erweiterung enthält ein weiteres Waifu-Modell namens keysoban, Open Source von [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632).

[Weitere Waifu-Modelle erhalten](https://github.com/ezshine/live2d-model-collections)

## Unterstützte Plattformen

---

~~~~
Nur MacOS und Windows10 werden unterstützt
~~~~

## Q&A

---

#### _Waifu wird nicht angezeigt?_
> A: Du musst den [Waifu-Container herunterladen](https://github.com/ezshine/live2d-model-collections). Nachdem du alle Dateien aus dem ZIP extrahiert hast, starte liv2dplayer.exe, rufe die Befehlsliste in VSCode auf und versuche, das Waifu-Modell zu wechseln.

## Handbuch, Befehle

---

🌈 Rainbow Fart Waifu Befehle anzeigen

- "Sprachpakete wechseln"
- "Waifu-Modelle wechseln"
- "Ressourcenverzeichnis öffnen"

> Wenn du ein Sprachpaket oder ein Modellpaket heruntergeladen hast, musst du diesen Befehl nutzen, um das Ressourcenverzeichnis zu öffnen und die Pakete in den Pfad zu verschieben.

- "Waifu-Container und weitere Ressourcen herunterladen"

## Funktionen

---

1. Die WebUI wurde entfernt, Audiodateien werden unter MacOS mit 'afplay' und unter Windows10 mit 'cmdmp3win' abgespielt.
2. Interaktion mit WaifuContainer: Stelle eine virtuelle Ehefrau auf deinen Desktop, die dich beim Programmieren begleitet.

## Hinweise zu Sprachpaketen

---

~~~~
Einige Hinweise zur Anpassung von Sprachpaketen oder zur Nutzung von Sprachpaketen aus dem Internet
~~~~

1. Verwende 'contributes.json' statt 'manifest.json'.
2. Füge Texte in 'contributes.json' hinzu, um die Sprachinhalte abzugleichen.

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
            "Wow, deine Callback-Funktion ist wirklich großartig!",
            "Wie wäre es, wenn du diese Funktion nach mir benennst?",
            "Selbst die beste Funktion kann meine Zuneigung zu dir nicht ausdrücken!"
        ]
    }
]
~~~~

## Unterstütze mich

---

Wenn diese Erweiterung dein Programmieren fröhlicher macht, darf ich dich um eine Cola bitten?

![](https://raw.githubusercontent.com/ezshine/vscode-rainbow-fart-waifu/master/resources/donate.jpg)

**Viel Spaß!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---