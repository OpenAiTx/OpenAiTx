
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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
        iPhoneをAirPlayレシーバーとして使う
        <br/>
        <a href="https://neon443.github.io">
            制作者: neon443
        </a>
    </p>
    <p>
        <a href="https://testflight.apple.com/join/8aeqD8Q2">
            TestFlight
        </a>
    </p>
    <br/>
</div>

<div align="center">
  <a href="https://shipwrecked.hackclub.com/?t=ghrm" target="_blank">
    <img src="https://hc-cdn.hel1.your-objectstorage.com/s/v3/739361f1d440b17fc9e2f74e49fc185d86cbec14_badge.png" 
         alt="このプロジェクトは世界初の島上ハッカソン『Shipwrecked』の一部です！" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAPは、iOS向けにSwiftで書かれた完全ネイティブなAirPlayサーバーです。基本的にAirAPは、iPhoneをiTunesやMac上でAirPlayレシーバーとして利用できるようにし、あなたのiPhoneでデバイスの音声を再生できます。

## AirAPとは？

Mac、Apple TV、または他のiOSデバイスからiPhoneに音声をストリーミングしたいと思ったことはありませんか？AirAPは、iOS上でネイティブに動作するフル機能のAirPlayサーバーを実装することでこれを可能にします。インストール後、iPhoneはシステム環境設定の「サウンド」パネル、Music.app、またはその他のAirPlay対応アプリで利用可能なAirPlay宛先として表示されます。

このコンセプトは最初は逆に感じるかもしれません ― というのも、通常はiPhoneから他のデバイスにストリーミングすることが多いからです。しかし、逆にしたい場面は意外と多くあります。例えば、夜遅くにMacで作業していて、誰も邪魔せずにイヤホン付きiPhoneに音声をルーティングしたい時（こんにちは 👋）。または、開発者がオーディオアプリのテストで出力デバイスをすばやく切り替えたい時。あるいは古い有線スピーカーを再利用したいときなどです。

## AirAPのインストール

試してみるには、[このTestFlightリンクを開いて](https://testflight.apple.com/join/8aeqD8Q2)、AirAPをインストールし、指示に従ってください。インストール後、AirAPを起動し、iPhoneがストリーミング元のデバイスと同じWi-Fiネットワークに接続されていることを確認します。iPhoneは自動的にAirPlayデバイス一覧に表示され、すぐに音声受信が可能です ― もし表示されない場合はアプリを再起動してください。

## コンパイル方法

[homebrew](https://brew.sh)がインストールされていることを確認してください。
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