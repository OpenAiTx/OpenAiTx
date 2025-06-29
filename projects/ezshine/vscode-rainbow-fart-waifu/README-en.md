# 🌈 Rainbow Fart Waifu
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

Website: [https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

Languages: [简体中文](./README.zh.md) | English

## Summary

----

This extension's idea comes from [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart), all code rewritten. Compatible with all voice packages, and adds some new features.

## Special Thanks

---

1. The extension includes [@justkowalski](https://github.com/JustKowalski) Chinese voice package. You can [get more voice packages from GitHub](https://github.com/topics/rainbow-fart)
2. The extension includes cmdmp3win.exe, from [@James K. Lawless](http://jiml.us)
3. The default waifu model is from [@二夏](https://erxia207.lofter.com), if you want to design an original waifu just for you, contact her.
4. The extension includes another waifu model named keysoban, open-sourced by [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632).

[Get More Waifu Models](https://github.com/ezshine/live2d-model-collections)

## Supported Platform

---

~~~~
Only supported on MacOS and Windows10
~~~~

## Q&A

---

#### _Waifu doesn't display?_
> A: You need to [download](https://github.com/ezshine/live2d-model-collections) the waifu container. After extracting everything from the zip file, run liv2dplayer.exe, bring up the command list in vscode, and try switching waifu models.

## Manual, Commands

---

🌈 Show Rainbow Fart Waifu Commands

- "Switch Voice Packages"
- "Switch Waifu Models"
- "Open Resource Directory"

> If you download a voice package or model package, you need to use this command to open the resource directory and move those packages under the path

- "Download Waifu Container and More Resources"

## Features

---

1. Removed the WebUI, audio files are played with 'afplay' on MacOS and 'cmdmp3win' on Windows10.
2. Interact with WaifuContainer, put a virtual wife on your desktop to accompany your programming.

## VoicePackage Notice

---

~~~~
Some notes for customizing voice packages or using voice packages downloaded from the internet
~~~~

1. Use 'contributes.json' instead of 'manifest.json'.
2. Add texts in 'contributes.json' to match the voice content.

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
            "Wow, your callback function is amazing!",
            "How about naming this function after me?",
            "No matter how powerful the function is, it can't express my affection for you!"
        ]
    }
]
~~~~

## Support Me

---

If this extension makes your programming happier, can I have a Coke?

![](https://raw.githubusercontent.com/ezshine/vscode-rainbow-fart-waifu/master/resources/donate.jpg)

**Enjoy!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---