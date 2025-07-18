<div align="center"> 
    <br/>
    <p>
        <img src="https://github.com/neon443/AirAP/blob/main/AirAP/Assets.xcassets/AppIcon.appiconset/Icon.png?raw=true" title="cobalt" alt="cobalt logo" width="100" />
    </p>
    <p>
        あなたのiPhoneをAirPlayレシーバーとして使う
        <br/>
        <a href="https://neon443.github.io">
            neon443によって作成
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
         alt="このプロジェクトはShipwrecked、世界初の島で開催されるハッカソンの一部です！" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAPは、iOS向けにSwiftで書かれた完全ネイティブのAirPlayサーバーです。基本的に、AirAPを使うことで、iTunesやMac上でiPhoneをAirPlayレシーバーとして使用でき、iPhoneでデバイスの音声を再生できます。

## AirAPとは？

Mac、Apple TV、または他のiOSデバイスからiPhoneにオーディオをストリーミングしたいと思ったことはありませんか？AirAPはiOS上でネイティブに動作する完全なAirPlayサーバーを実装することで、これを可能にします。インストールすると、iPhoneはシステム環境設定のオーディオパネル、Music.app、または他のAirPlay対応アプリで利用可能なAirPlayの宛先として表示されます。

このコンセプトは最初は逆に感じるかもしれません。普段はiPhoneから他のデバイスへストリーミングすることに慣れているからです。しかし、実は逆の操作をしたい場面は意外と多いです。たとえば、深夜にMacで作業していて、誰も邪魔しないようにヘッドフォンを使ってiPhoneに音声を送信したい場合（こんにちは👋）。あるいは、オーディオアプリを開発中で異なる出力デバイス間を素早く切り替えたい場合。あるいは、古い有線スピーカーを再活用したい場合などです。

## AirAPのインストール

試してみたい場合は、[このTestFlightリンクを開いて](https://testflight.apple.com/join/8aeqD8Q2)、AirAPをインストールし、指示に従ってください。インストール後は、AirAPを起動し、iPhoneがストリーミング元のデバイスと同じWi-Fiネットワークに接続されていることを確認してください。iPhoneは自動的にAirPlayデバイスリストに表示され、音声を受信できるようになります。表示されない場合は、アプリを再起動してみてください。

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---