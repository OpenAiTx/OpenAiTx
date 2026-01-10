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
        <img src="https://files.catbox.moe/f4jofb.png" title="icon" alt="icon" width="100" />
    </p>
    <p>
        使用你的 iPhone 作為 AirPlay 接收器
        <br/>

        <a href="https://neon443.github.io">
            製作：neon443
        </a>
    </p>
    <p>
        <a href="https://testflight.apple.com/join/8aeqD8Q2">
            TestFlight 測試版
        </a>
    </p>
    <br/>
</div>

<div align="center">
  <a href="https://shipwrecked.hackclub.com/?t=ghrm" target="_blank">
    <img src="https://hc-cdn.hel1.your-objectstorage.com/s/v3/739361f1d440b17fc9e2f74e49fc185d86cbec14_badge.png" 
         alt="此專案是 Shipwrecked——全球首個島嶼黑客松——的一部分！" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP 是一款完全以 Swift 編寫的原生 AirPlay 伺服器，適用於 iOS。簡單來說，AirAP 讓你的 iPhone 能作為 iTunes 或 Mac 的 AirPlay 接收器，也就是你可以用 iPhone 來播放裝置的聲音。

## AirAP 是什麼？

你是否曾想過將 Mac、Apple TV 或其他 iOS 裝置的音訊串流到 iPhone 上？AirAP 透過在 iOS 上原生運行完整的 AirPlay 伺服器，讓這一切成為可能。安裝後，你的 iPhone 會在系統偏好設定的音訊面板、Music.app 或其他支援 AirPlay 的應用程式中，顯示為可用的 AirPlay 目的地。

這個概念一開始可能有些反直覺——畢竟我們習慣從 iPhone 串流到其他裝置。但其實有不少情境需要反向串流。也許你深夜在 Mac 上工作，想把音訊導到帶耳機的 iPhone 上避免吵到其他人（嗨 👋），或你是開發者測試音訊應用程式，需要快速切換不同的輸出裝置，甚至只是想重新利用舊有的有線喇叭。

## 安裝 AirAP

想要試用，[請開啟此 TestFlight 連結](https://testflight.apple.com/join/8aeqD8Q2)，安裝 AirAP 並依照指示操作。安裝完成後，直接開啟 AirAP 並確保你的 iPhone 與欲串流裝置連上同一個 Wi-Fi 網路。你的 iPhone 將自動顯示在 AirPlay 裝置清單中，隨時可接收音訊——若未顯示，請嘗試重新啟動 App。

## 編譯

請確保已安裝 [homebrew](https://brew.sh)
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