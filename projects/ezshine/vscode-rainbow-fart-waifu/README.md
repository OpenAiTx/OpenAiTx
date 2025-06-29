# 🌈 Rainbow Fart Waifu
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

Website：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

Languages: [简体中文](./README.zh.md) | English

## Summary

----

this extension's idea from [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart), rewrite all code. compatible all voicepackages, and add some new features.

## Special Thanks

---

1. the extension included [@justkowalski](https://github.com/JustKowalski) chinese voice package. you can [get more voice packages from github](https://github.com/topics/rainbow-fart) 
2. the extension included cmdmp3win.exe，from [@James K. Lawless](http://jiml.us) 
3. the default waifu model from [@二夏](https://erxia207.lofter.com)，if you want to design a original waifu only belong to you, contact her. 
4. the extension include another waifu model named keysoban, opensource by [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632).

[Get More Waifu Models](https://github.com/ezshine/live2d-model-collections)

## Supported Platform

---

~~~~
Only supported MacOS and Windows10
~~~~

## Q&A

---

#### _Waifu dosn't display?_
> A: You need [download](https://github.com/ezshine/live2d-model-collections) the waifu container. after unextract all in zip file, run liv2dplayer.exe, call out commands list in vscode, try switch waifu model.

## Manual, Commands

---

🌈 Show Rainbow Fart Waifu Commands

- "Switch Voice Packages"
- "Switch Waifu Models"
- "Open Resource Directory"

> if you download voicepackage or modelpackage, you need use this command to open resource directory, move those packages under the path

- "Download Waifu Container and More Resources"

## Features

---

1. Removed the WebUI, play audio file used 'afplay' in MacOS and 'cmdmp3win' in Windows10. 
2. Interact with WaifuContainer, Put a virtual wife on your desktop accompany your programing.

## VoicePackage Notice

---

~~~~
some notice for customize voice package or use voice package download from the internet
~~~~

1. use 'contributes.json' not 'manifest.json'.
2. add texts in 'contributes.json' for match voice content.

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

## Support Me

---

If this extension makes your programming happier, can I have a coke?

![](./resources/donate.jpg)





**Enjoy!**