# 🌈 Rainbow Fart Waifu
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

Sito Web：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

Lingue: [简体中文](./README.zh.md) | English

## Sommario

----

l'idea di questa estensione è tratta da [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart), riscritta completamente. Compatibile con tutti i voicepackage e aggiunte alcune nuove funzionalità.

## Ringraziamenti Speciali

---

1. L'estensione include il pacchetto vocale cinese di [@justkowalski](https://github.com/JustKowalski). Puoi [ottenere altri pacchetti vocali da github](https://github.com/topics/rainbow-fart) 
2. L'estensione include cmdmp3win.exe, da [@James K. Lawless](http://jiml.us) 
3. Il modello waifu predefinito è di [@二夏](https://erxia207.lofter.com), se vuoi progettare una waifu originale solo per te, contattala. 
4. L'estensione include un altro modello waifu chiamato keysoban, open source di [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632).

[Ottieni Altri Modelli Waifu](https://github.com/ezshine/live2d-model-collections)

## Piattaforme Supportate

---

~~~~
Supportato solo su MacOS e Windows10
~~~~

## Q&A

---

#### _La waifu non viene visualizzata?_
> R: Devi [scaricare](https://github.com/ezshine/live2d-model-collections) il contenitore waifu. Dopo aver estratto tutti i file dallo zip, esegui liv2dplayer.exe, richiama la lista comandi in vscode e prova a cambiare modello waifu.

## Manuale, Comandi

---

🌈 Mostra Comandi Rainbow Fart Waifu

- "Cambia Pacchetto Vocale"
- "Cambia Modello Waifu"
- "Apri Directory Risorse"

> Se scarichi un pacchetto vocale o un pacchetto modello, usa questo comando per aprire la directory risorse e sposta lì i pacchetti

- "Scarica Contenitore Waifu e Altre Risorse"

## Caratteristiche

---

1. Rimossa la WebUI, i file audio vengono riprodotti con 'afplay' su MacOS e 'cmdmp3win' su Windows10. 
2. Interagisci con WaifuContainer, metti una moglie virtuale sul tuo desktop che ti accompagna durante la programmazione.

## Avviso Pacchetto Vocale

---

~~~~
alcuni avvisi per personalizzare il pacchetto vocale o usare pacchetti vocali scaricati da internet
~~~~

1. Usa 'contributes.json' invece di 'manifest.json'.
2. Aggiungi testi in 'contributes.json' per abbinare il contenuto vocale.

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
            "Wow, la tua funzione callback è scritta benissimo!",
            "Cosa ne dici di usare il mio nome per questa funzione?",
            "Anche la funzione più potente non può esprimere quanto ti piaccio!"
        ]
    }
]
~~~~

## Supportami

---

Se questa estensione rende la tua programmazione più felice, mi offri una coca?

![](./resources/donate.jpg)
**Divertiti!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---