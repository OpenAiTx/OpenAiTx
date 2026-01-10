
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
        <img src="https://files.catbox.moe/f4jofb.png" title="icon" alt="icon" width="100" />
    </p>
    <p>
        使用你的 iPhone 作为 AirPlay 接收器
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
    <img src="https://hc-cdn.hel1.your-objectstorage.com/s/v3/739361f1d440b17fc9e2f74e49fc185d86cbec14_badge.png" 
         alt="本项目是 Shipwrecked 的一部分，这是世界上第一个在岛上举办的黑客马拉松活动！" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP 是一个完全原生的 AirPlay 服务器，使用 Swift 编写，适用于 iOS。实际上，AirAP 允许你把 iPhone 作为 AirPlay 接收端使用，可以在 iTunes 或 Mac 上投送音频，这意味着你可以用 iPhone 播放设备的声音。

## 什么是 AirAP？

你是否曾想过将 Mac、Apple TV 或其他 iOS 设备的音频流式传输到你的 iPhone？AirAP 通过在 iOS 上原生实现完整的 AirPlay 服务器，使这一切成为可能。安装后，你的 iPhone 会出现在系统偏好设置的音频面板、音乐应用或任何支持 AirPlay 的应用中作为可用的 AirPlay 目标。

这个概念一开始可能有些反向——毕竟我们习惯了从 iPhone 向其他设备投送内容。但其实在很多场景下，你会希望反过来使用。比如深夜在 Mac 上工作，想把音频通过耳机传到 iPhone，不影响他人（嗨 👋）。又或者你是开发者，在测试音频应用时需要快速切换输出设备。或者你只是想重新利用旧有的有线扬声器。

## 安装 AirAP

想要体验，[打开这个 TestFlight 链接](https://testflight.apple.com/join/8aeqD8Q2)，安装 AirAP，并按照指引操作。安装后，只需启动 AirAP，并确保你的 iPhone 与你要投送音频的设备连接在同一 Wi-Fi 网络。你的 iPhone 会自动出现在 AirPlay 设备列表中，随时准备接收音频——如果没有出现，请尝试重启应用。

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-10

---