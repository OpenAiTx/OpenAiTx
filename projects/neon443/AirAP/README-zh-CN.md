
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
        <img src="https://github.com/neon443/AirAP/blob/main/Icon/icon.png?raw=true" title="icon" alt="icon" width="100" />
    </p>
    <p>
        将你的 iPhone 用作 AirPlay 接收器
        <br/>
        <a href="https://neon443.github.io">
            由 neon443 制作
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
    <img src="https://github.com/neon443/AirAP/blob/main/Icon/shipwrecked.png?raw=true" 
         alt="该项目是 Shipwrecked（世界上第一个岛屿黑客马拉松）的一部分！" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP 是一个完全原生的 AirPlay 服务器，由 Swift 编写，适用于 iOS。本质上，AirAP 允许你将 iPhone 作为 iTunes 或 Mac 上的 AirPlay 接收端，这意味着你可以用 iPhone 播放设备的声音。

## 什么是 AirAP？

你是否曾想过将 Mac、Apple TV 或其他 iOS 设备上的音频流传输到 iPhone？AirAP 通过实现一个完全原生运行于 iOS 的 AirPlay 服务器，让这一切成为可能。安装后，你的 iPhone 会在系统偏好设置的音频面板、Music.app 或任意支持 AirPlay 的应用中显示为可用的 AirPlay 目标。

这个概念刚开始看起来似乎有点反向——毕竟我们习惯于把 iPhone 的音频流到其它设备。但实际上，有很多场景你会希望反过来。比如，你深夜在 Mac 上工作，希望通过 iPhone 和耳机听音频，不打扰其他人（嗨 👋）。或者你是开发者，测试音频应用时需要快速切换输出设备。又或者你只是想重新利用那台老式有线音箱。

## 安装 AirAP

想要体验，只需[打开这个 TestFlight 链接](https://testflight.apple.com/join/8aeqD8Q2)，安装 AirAP 并按提示操作。安装完成后，启动 AirAP 并确保你的 iPhone 和需要投送音频的设备在同一 Wi-Fi 网络下。你的 iPhone 会自动出现在 AirPlay 设备列表中，准备接收音频——如果没有显示，尝试重启应用。

## 编译

请确保你已安装 [homebrew](https://brew.sh)
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-11

---