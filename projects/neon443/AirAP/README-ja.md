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
        <img src="https://github.com/neon443/AirAP/blob/main/AirAP/Assets.xcassets/AppIcon.appiconset/Icon.png?raw=true" title="cobalt" alt="cobalt logo" width="100" />
    </p>
    <p>
        iPhoneをAirPlay受信機として使おう
        <br/>
        <a href="https://neon443.github.io">
            neon443 作
        </a>
    </p>
    <p>
        <a href="https://testflight.apple.com/join/8aeqD8Q2">
            testflight
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

AirAPは、iOS向けにSwiftで書かれた完全ネイティブのAirPlayサーバーです。基本的に、AirAPを使うことでiPhoneをiTunesやMacのAirPlay受信機として利用でき、iPhoneでデバイスのサウンドを再生できます。

## AirAPとは？

MacやApple TV、他のiOSデバイスからiPhoneにオーディオをストリーミングしたいと思ったことはありませんか？AirAPは、iOS上でネイティブに動作する完全なAirPlayサーバーを実装することで、それを可能にします。インストールすると、iPhoneがシステム環境設定の「サウンド」ペインやMusic.app、その他のAirPlay対応アプリにAirPlayの出力先として表示されます。

最初は逆の発想に思えるかもしれません ― 通常はiPhoneから他のデバイスへストリーミングすることに慣れていますから。しかし、逆方向にしたい場面も意外と多いものです。例えば夜遅くにMacで作業していて、音声をiPhoneとヘッドホンにルーティングして誰にも迷惑をかけたくない時（こんにちは 👋）。あるいは、音声アプリケーションをテストする開発者で、すぐに出力デバイスを切り替えたい時。もしくは、古い有線スピーカーを再利用したい時などです。

## AirAPのインストール

試してみたい場合は、[このTestFlightリンクを開いて](https://testflight.apple.com/join/8aeqD8Q2)AirAPをインストールし、手順に従ってください。インストール後は、AirAPを起動し、iPhoneがストリーミング元デバイスと同じWi-Fiネットワークに接続されていることを確認します。iPhoneはAirPlayデバイス一覧に自動的に表示され、すぐに音声を受信できるようになります ― もし表示されない場合はアプリを再起動してみてください。

## コンパイル

[homebrew](https://brew.sh)がインストールされていることを確認してください

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