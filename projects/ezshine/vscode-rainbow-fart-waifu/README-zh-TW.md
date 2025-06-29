# 🌈 彩虹屁老婆 (Rainbow Fart Waifu)
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

網站：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

語言: [簡體中文](./README.zh.md) | English

## 摘要

----

本擴充功能的靈感來自 [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart)，全部程式碼重寫。相容所有語音包，並新增了一些新功能。

## 特別感謝

---

1. 本擴充功能內含 [@justkowalski](https://github.com/JustKowalski) 的中文語音包。你可以[從 GitHub 獲取更多語音包](https://github.com/topics/rainbow-fart) 
2. 本擴充功能內含 cmdmp3win.exe，來自 [@James K. Lawless](http://jiml.us) 
3. 預設老婆模型來自 [@二夏](https://erxia207.lofter.com)，如果你想設計專屬於你的原創老婆，請聯繫她。
4. 本擴充功能還內含另一個名為 keysoban 的老婆模型，開源自 [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632)。

[獲取更多老婆模型](https://github.com/ezshine/live2d-model-collections)

## 支援平台

---

~~~~
僅支援 MacOS 和 Windows10
~~~~

## Q&A

---

#### _老婆沒有顯示？_
> A: 你需要[下載](https://github.com/ezshine/live2d-model-collections)老婆容器。解壓縮 zip 檔案後，執行 liv2dplayer.exe，在 vscode 呼叫命令面板，嘗試切換老婆模型。

## 使用說明與指令

---

🌈 顯示彩虹屁老婆指令

- "切換語音包"
- "切換老婆模型"
- "開啟資源目錄"

> 如果你下載了語音包或模型包，需要使用此指令開啟資源目錄，將這些包移動到指定路徑下

- "下載老婆容器及更多資源"

## 功能特色

---

1. 移除了 WebUI，音訊播放在 MacOS 使用 'afplay'，在 Windows10 使用 'cmdmp3win'。
2. 與 WaifuContainer 互動，讓虛擬老婆在你的桌面上陪你一起寫程式。

## 語音包注意事項

---

~~~~
自訂語音包或從網路下載語音包時的注意事項
~~~~

1. 請使用 'contributes.json'，不要用 'manifest.json'。
2. 請在 'contributes.json' 中加入 texts 以對應語音內容。

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
            "哇哦，你的回調函數寫得好棒棒呀！",
            "這個函數的命名用我的名字怎麼樣呀？",
            "再厲害的函數，也執行不出我對你的喜歡！"
        ]
    }
]
~~~~

## 支持我

---

如果這個擴充功能讓你的編程更快樂，請請我喝可樂吧！

![](https://raw.githubusercontent.com/ezshine/vscode-rainbow-fart-waifu/master/resources/donate.jpg)

**享受吧！**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---