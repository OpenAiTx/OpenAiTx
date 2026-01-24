# 27C322/160/800/400 EPROM プログラミングアダプターシリーズ

![GitHub issues](https://img.shields.io/github/issues-raw/mafe72/27c160-tl866-adapter?logo=Github&style=for-the-badge)

## はじめに

このアダプターは、以下に示す部品（現代のDIPパッケージのマスクROMに類似）を、手に入りやすく安価なTL866シリーズのUSBプログラマーがサポートする27C4096のピン配置に変換します。

対応しているEPROM部品は以下の通りです：
- **27C400:** 40ピン、4Mbit (256k x 16ビット、512k x 8ビット)
- **27C800:** 42ピン、8Mbit (512k x 16ビット、1M x 8ビット)
- **27C160:** 42ピン、16Mbit (1M x 16ビット、2M x 8ビット)
- **27C322:** 42ピン、32Mbit (2M x 16ビット、8ビットアクセスモードなし)

## 設計

このアダプターはKiCad 5.0を用いて設計されており、プロジェクトファイルはkicad-projectというフォルダにあります。

表面：

![top](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/front_th.png)

裏面：

![bottom](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/back_th.png)

## 使用方法

プログラミングアダプターを、ソケットの取っ手が隣接するようにしてTL866に挿入します。EPROMはアダプターの最も下の位置に、ピン1が取っ手に最も近くなるように挿入してください。

![Adapter when in use](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/adapter_in_use.jpg)

27C322 EPROMをプログラミングする場合はスイッチを**Position 27c322**に、27C160、27C400、27C800 EPROMの場合はスイッチを**Position other**にしてください。

![Adapter mode](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/addapter_mode.jpg)

## ソフトウェア

以下の手順は27c160 EPROMの書き込み方法を説明しています。

ソースEPROMを512Kバイトのパーツに分割します。この場合、私はHJSplitを使用しますが、他のプログラムでも構いません。

![HJSplit](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/hjsplit_512k.jpg)

出力パスを指定します。この例では、拡張子が ".001" から ".004" までの512Kバイトサイズの4つのファイルが生成されます。

MiniProソフトウェアを起動し、デバイスとして `AMD 27C4096 DIP40` を選択し、`Check ID` の選択を解除し、`Pulse Delay` を `50us` に設定します。EPROMのデータシートや書き込みの成功状況に応じて、オプションで `VPP Voltage` を `12.50V` に下げることもできます。

![MiniPro Software Configuration](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/minipro.jpg)

EPROMは、設定されたDIPスイッチにより、27C4096デバイスとしてアクセスできるようになり、一度に512kBずつ扱います：

- **27C400:** 一度の書き込みで512kB全てをプログラムします。
- **27C800:** 2回の512kB書き込みでプログラムします。
- **27C160:** 4回の512kB書き込みでプログラムします。
- **27C322:** 8回の512kB書き込みでプログラムします。

DIPスイッチの設定については、以下の表を参照してください：

![DIP Switch configuration](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/dip_config.png)

## トラブルシューティング

書き込みや検証エラーが発生した場合は、以下の手順を試してください：

1. 書き込み前にEPROMが完全に消去されていることを確認してください（`Device -> Blank Check`）。現在入手可能なEPROMは中古品が多く、販売者が消去を十分に行っていない場合があります。

2. アダプターのZIFレバーを数回開閉し、EPROMをソケットにしっかりと真っ直ぐに差し直してください。

3. `VPP Voltage` を `12.50V` から `13.50V` の間で調整してみてください。主観的には、より高い電圧のほうが成功率が高いことがあり、アダプターのロジックを経由したVPPの電圧損失に余裕ができます。

4. 書き込みエラーは時々発生します。特に大容量デバイスほどその可能性は高まります。UV消去器への投資は理にかなっています。eBayなどで約15～20ドルで入手可能です。ほとんどのデバイスはUV光照射で10～20分で消去されます。

5. [Maillouski](https://github.com/Maillouski/)によると、Xgpro v12.38はAT27C4096のVDD Writeのデフォルト値を6.60Vに設定しています。書き込み問題を避けるため、この値を3.30Vに変更することを忘れないでください。

![IC Config Information VDD Write](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/vdd_3v30.png)

6. [Tim aka BeepFixer](https://x.com/@beepfixer)は、AliExpressから入手した**27C160**バリアントの書き込み値を共有しています。

   主な違いは、UVウィンドウパッドの構成で、タイプA、B、Cと呼ばれています。
    - **タイプA**: 利用可能なウィンドウスペースの中央のみを使用する2x2パッド
    - **タイプB**: 利用可能なウィンドウスペースのほとんどを使用する2x2パッド
    - **タイプC**: 2x4パッド

![IC Config Information VDD Write](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/m27c160_variants.jpg)

**テスト結果**

  **タイプA**: 10個中2個のチップは少しの手入れが必要で、推奨設定外の微調整（50usから100usに変更）でプログラム可能かつ検証可能になりました。念のため、使用したフル設定は次の通りです：VPP電圧：13.50V / VCC検証：5.00V / VDD書き込み：5.00V / パルス遅延：100us。他の電圧でも成功しましたが、パルス遅延は100usでなければなりませんでした。

  **タイプB**: 10個中7個のチップは完璧に動作しました。初回試行で、Eladioの推奨設定（50us）を使用。

  **タイプC**: 10個中1個のチップが著しく失敗しました。読み取りと消去は問題なく行え、単語単位の書き込みは可能ですが、それ以上の書き込みを拒否します。おそらく古い厳格なバリアントで、故障ではなくシリコンの個性です。異なる設定で何度も試みましたが、完全なバッチの書き込みはできませんでした。

**実用的なヒント**

   - プログラミング後は必ず検証を行ってください。
   - アダプターのGitHubで言及されているように、電圧差を試してみてください。
   - ファイルの書き込み管理に注意してください。アダプターを使ってイメージを4つのセクションに分割して書き込むため、誤って異なるバンクに間違ったファイルを書き込むことが簡単に起こります（うっかり、私も一度ファイル3をバンク3と4に書き込んでしまいました）。ですので、対象デバイスのEPROMを必ず検証してください！

## ハードウェア変更履歴

R_20231123

* EDG-03 DIPスイッチの極性を正しく修正。
* リビジョン番号をR_20231123に更新。
* バージョン番号を1.1に更新。

V_20180919

* 初回リリース。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---