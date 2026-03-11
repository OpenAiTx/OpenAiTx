<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=id">印尼語</a>
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
        使用你的 iPhone 作為 AirPlay 接收器
        <br/>

        <a href="https://neon443.github.io">
            製作人：neon443
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
    <img src="https://github.com/neon443/AirAP/blob/main/Icon/shipwrecked.png?raw=true" 
         alt="本專案是 Shipwrecked 活動的一部分，這是世界上第一個在島上舉辦的黑客松！" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP 是一個完全原生的 AirPlay 伺服器，由 Swift 編寫，專為 iOS 設計。簡單來說，AirAP 讓你能夠將 iPhone 當作 iTunes 或 Mac 上的 AirPlay 接收器，這意味著你可以用 iPhone 來播放你設備的聲音。

## 什麼是 AirAP？

你是否曾經想過，將你的 Mac、Apple TV 或其他 iOS 裝置的音訊串流到你的 iPhone？AirAP 讓這一切成為可能，因為它在 iOS 上原生實現了一個完整的 AirPlay 伺服器。安裝後，你的 iPhone 會出現在「系統偏好設定」的音訊面板、音樂.app 或任何支援 AirPlay 的應用程式中，成為可用的 AirPlay 目的地。

這個概念一開始可能有點反直覺——畢竟我們習慣把音訊從 iPhone 串流到其他裝置。但其實有很多情境會需要反過來。例如你深夜在 Mac 上工作，想用耳機把音訊導到 iPhone，不想吵到任何人（嗨 👋）。或是你是開發者，需要測試音訊應用並快速切換不同輸出裝置。甚至只是想讓舊有的有線喇叭重新發揮作用。

## 安裝 AirAP

想試用的話，[請開啟這個 TestFlight 連結](https://testflight.apple.com/join/8aeqD8Q2)，安裝 AirAP 並依照指示操作。安裝完成後，只需啟動 AirAP，並確保你的 iPhone 和要串流的裝置在同一個 Wi-Fi 網路下。你的 iPhone 會自動顯示在 AirPlay 裝置清單中，隨時準備接收音訊——如果沒有，請嘗試重新啟動應用程式。

## 編譯

請確認你已安裝 [homebrew](https://brew.sh)
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