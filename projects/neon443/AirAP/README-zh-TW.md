<div align="right">
  <details>
    <summary >🌐 語言</summary>
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
        使用你的 iPhone 作為 AirPlay 接收器
        <br/>
        <a href="https://neon443.github.io">
            製作人 neon443
        </a>
    </p>
    <p>
        <a href="https://testflight.apple.com/join/8aeqD8Q2">
            testflight 測試
        </a>
    </p>
    <br/>
</div>

<div align="center">
  <a href="https://shipwrecked.hackclub.com/?t=ghrm" target="_blank">
    <img src="https://hc-cdn.hel1.your-objectstorage.com/s/v3/739361f1d440b17fc9e2f74e49fc185d86cbec14_badge.png" 
         alt="此專案是世界首個在島嶼上舉辦的 Shipwrecked 黑客松的一部分！" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP 是一款完全原生的 AirPlay 伺服器，使用 Swift 為 iOS 撰寫。基本上，AirAP 允許你在 iTunes 或 Mac 上將 iPhone 作為 AirPlay 接收器使用，這意味著你可以用 iPhone 播放裝置的聲音。

## 什麼是 AirAP？

你是否曾經想過，將來自 Mac、Apple TV 或其他 iOS 裝置的音訊串流到你的 iPhone？AirAP 讓這成為可能，因為它在 iOS 上原生實現了完整的 AirPlay 伺服器。安裝後，你的 iPhone 會出現在系統偏好設定的音訊面板、Music.app 或任何支援 AirPlay 的應用程式中，作為可用的 AirPlay 目的地。

這個概念一開始可能有點顛倒——畢竟我們習慣將 iPhone 的內容串流到其他裝置。但其實有不少場合你會想反過來用。或許你半夜在 Mac 上工作，想把音訊導到 iPhone 並用耳機，不打擾他人（嗨 👋）。也許你是開發者，需要測試音訊應用，且必須快速切換不同的輸出裝置。又或者你只是想讓舊的有線喇叭再度發揮作用。

## 安裝 AirAP

想試用的話，[點擊這個 TestFlight 連結](https://testflight.apple.com/join/8aeqD8Q2)，安裝 AirAP 並按照說明操作。安裝後，只需啟動 AirAP，並確保你的 iPhone 和要串流的裝置連接在同一個 Wi-Fi 網路。你的 iPhone 會自動出現在 AirPlay 裝置列表中，隨時準備接收音訊——如果沒有出現，請嘗試重新啟動應用程式。

## 編譯

請確保你已經安裝 [homebrew](https://brew.sh)

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