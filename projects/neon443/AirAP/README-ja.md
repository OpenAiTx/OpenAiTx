
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
        <img src="https://github.com/neon443/AirAP/blob/main/Icon/icon.png?raw=true" title="icon" alt="icon" width="100" />
    </p>
    <p>
        あなたのiPhoneをAirPlayレシーバーとして使う
        <br/>
        <a href="https://neon443.github.io">
            作成者：neon443
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
    <img src="https://github.com/neon443/AirAP/blob/main/Icon/shipwrecked.png?raw=true" 
         alt="このプロジェクトは世界初の島で開催されるハッカソン Shipwrecked の一部です！" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAPはiOS向けにSwiftで書かれた完全なネイティブAirPlayサーバーです。基本的に、AirAPを使うことでiPhoneをiTunesやMac上のAirPlayレシーバーとして利用でき、デバイスの音声をiPhoneで再生できます。

## AirAPとは？

MacやApple TV、他のiOSデバイスからiPhoneに音声をストリームしたいと思ったことはありませんか？AirAPはiOS上でネイティブに動作する完全なAirPlayサーバーを実装することで、それを可能にします。インストール後、iPhoneはシステム環境設定のオーディオパネルやMusic.app、その他のAirPlay対応アプリで利用可能なAirPlayの宛先として表示されます。

このコンセプトは最初は逆に感じるかもしれません ― これまで私たちはiPhoneから他のデバイスへストリームすることに慣れているからです。しかし逆にしたい場面も意外と多いものです。例えば夜遅くにMacで作業していて、イヤホンをつけたiPhoneに音声を流して誰にも迷惑をかけたくない時（こんにちは 👋）、開発者としてオーディオアプリをテストする際に出力デバイスを素早く切り替えたい時、あるいは古い有線スピーカーを再利用したい時などです。

## AirAPのインストール

試してみるには、[このTestFlightリンクを開いて](https://testflight.apple.com/join/8aeqD8Q2)、AirAPをインストールし、指示に従ってください。インストール後、AirAPを起動し、iPhoneがストリーム元のデバイスと同じWi-Fiネットワークに接続されていることを確認してください。iPhoneは自動的にAirPlayデバイスリストに表示され、音声の受信準備が整います ― 表示されない場合はアプリを再起動してみてください。

## コンパイル方法

[homebrew](https://brew.sh) を必ずインストールしてください
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