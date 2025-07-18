<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center"> 
    <br/>
    <p>
        <img src="https://github.com/neon443/AirAP/blob/main/AirAP/Assets.xcassets/AppIcon.appiconset/Icon.png?raw=true" title="cobalt" alt="cobalt logo" width="100" />
    </p>
    <p>
        将你的 iPhone 用作 AirPlay 接收器
        <br/>
        <a href="https://neon443.github.io">
            由 neon443 开发
        </a>
    </p>
    <p>
        <a href="https://testflight.apple.com/join/8aeqD8Q2">
            testflight 测试版
        </a>
    </p>
    <br/>
</div>

<div align="center">
  <a href="https://shipwrecked.hackclub.com/?t=ghrm" target="_blank">
    <img src="https://hc-cdn.hel1.your-objectstorage.com/s/v3/739361f1d440b17fc9e2f74e49fc185d86cbec14_badge.png" 
         alt="This project is part of Shipwrecked, the world's first hackathon on an island!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP 是一个完全原生的 AirPlay 服务器，使用 Swift 编写，适用于 iOS。简单来说，AirAP 允许你在 iTunes 或 Mac 上将 iPhone 作为 AirPlay 接收器，这意味着你可以用 iPhone 播放你设备的音频。

## 什么是 AirAP？

你是否曾经想过将 Mac、Apple TV 或其他 iOS 设备的音频流传输到你的 iPhone？AirAP 通过实现一个完整的 AirPlay 服务器，并在 iOS 上原生运行，让这一切成为可能。安装后，你的 iPhone 会作为可用的 AirPlay 目标出现在系统偏好设置的音频面板、音乐应用或任何其他兼容 AirPlay 的应用中。

这个概念一开始看起来可能有些反常——毕竟我们习惯了从 iPhone 向其他设备推送流。但实际上有很多场景你会希望反过来使用。比如你在深夜用 Mac 工作，希望将音频通过带耳机的 iPhone 输出，以免打扰到别人（你好👋）。又比如你是开发者，需要测试音频应用，并且想快速切换不同的输出设备。或者你只是想让老旧的有线音箱重新发挥作用。

## 如何安装 AirAP

想要体验，[打开这个 TestFlight 链接](https://testflight.apple.com/join/8aeqD8Q2)，安装 AirAP，并按照指引操作。安装完成后，直接启动 AirAP 并确保你的 iPhone 与需要推送音频的设备连接在同一个 Wi-Fi 网络下。你的 iPhone 会自动出现在 AirPlay 设备列表中，准备接收音频——如果没有显示，请尝试重启应用。

## 编译

请确保你已经安装了 [homebrew](https://brew.sh)

```
brew install carthage
git clone https://github.com/neon443/AirAP
cd AirAP
carthage checkout
open AirAP.xcodeproj
```
After adding your Team ID in Project > AirAP > Signing and Capabilities, hit `Command + R` to build and run! 

### thanks to

[qasim/Airstream](https://github.com/qasim/Airstream)
[shairplay](https://github.com/juhovh/shairplay)
would not have been possible without these

---

<sup>
&copy; 2025 Nihaal Sharma. AirPlay, iPhone, iTunes, Mac, and Apple TV are trademarks of Apple Inc.
</sup>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---