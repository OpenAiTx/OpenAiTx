# 🌈 Rainbow Fart Waifu
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

Strona internetowa：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

Języki: [简体中文](./README.zh.md) | English

## Podsumowanie

----

pomysł na to rozszerzenie pochodzi od [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart), cały kod został przepisany. kompatybilny ze wszystkimi paczkami głosowymi, dodano kilka nowych funkcji.

## Specjalne podziękowania

---

1. rozszerzenie zawiera chińską paczkę głosową autorstwa [@justkowalski](https://github.com/JustKowalski). możesz [pobrać więcej paczek głosowych z githuba](https://github.com/topics/rainbow-fart) 
2. rozszerzenie zawiera cmdmp3win.exe, od [@James K. Lawless](http://jiml.us) 
3. domyślny model waifu pochodzi od [@二夏](https://erxia207.lofter.com), jeśli chcesz zaprojektować oryginalną waifu tylko dla siebie, skontaktuj się z nią. 
4. rozszerzenie zawiera inny model waifu o nazwie keysoban, open source od [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632).

[Pobierz więcej modeli Waifu](https://github.com/ezshine/live2d-model-collections)

## Wspierane platformy

---

~~~~
Obsługiwane tylko MacOS i Windows10
~~~~

## Q&A

---

#### _Waifu się nie wyświetla?_
> O: Musisz [pobrać](https://github.com/ezshine/live2d-model-collections) kontener waifu. Po rozpakowaniu wszystkich plików z archiwum zip uruchom liv2dplayer.exe, wywołaj listę poleceń w vscode i spróbuj przełączyć model waifu.

## Instrukcja, Polecenia

---

🌈 Pokaż polecenia Rainbow Fart Waifu

- "Przełącz paczki głosowe"
- "Przełącz modele Waifu"
- "Otwórz katalog zasobów"

> jeśli pobierzesz paczkę głosową lub model, musisz użyć tego polecenia, aby otworzyć katalog zasobów i przenieść te paczki do wskazanej ścieżki

- "Pobierz kontener Waifu i więcej zasobów"

## Funkcje

---

1. Usunięto WebUI, odtwarzanie plików audio odbywa się za pomocą 'afplay' w MacOS oraz 'cmdmp3win' w Windows10. 
2. Integracja z WaifuContainer, umieść wirtualną żonę na swoim pulpicie, aby towarzyszyła Ci podczas programowania.

## Uwagi do paczek głosowych

---

~~~~
kilka uwag dotyczących dostosowywania paczek głosowych lub korzystania z paczek pobranych z internetu
~~~~

1. używaj 'contributes.json' zamiast 'manifest.json'.
2. dodaj teksty w 'contributes.json', aby dopasować treść głosową.

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
            "哇哦，你的回调函数写的好棒棒呀！",
            "这个函数的命名用我的名字怎么样呀？",
            "再厉害的函数，也执行不出我对你的喜欢！"
        ]
    }
]
~~~~

## Wesprzyj mnie

---

Jeśli to rozszerzenie sprawia, że programowanie jest przyjemniejsze, czy mogę prosić o colę?

![](https://raw.githubusercontent.com/ezshine/vscode-rainbow-fart-waifu/master/resources/donate.jpg)
**Miłej zabawy!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---