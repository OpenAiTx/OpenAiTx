> [!IMPORTANT]
> echoのroot化をお探しの場合、このプロジェクトは現在廃止されています；代わりに[こちら](https://xdaforums.com/t/unlock-root-twrp-unbrick-amazon-echo-dot-2nd-gen-2016-biscuit.4761416/)に記載された方法をご利用ください。これを可能にしてくださった皆様、本当にありがとうございました。このプロジェクトに取り組むのはとても楽しかったです！ :)

# EchoCLI
Echo Dot 第2世代向けのテザードrootソリューションです。
開始するには、`main.py`を実行してください。
<br>

[<kbd> <br> これはどう動作するのか？ <br> </kbd>](https://dragon863.github.io/blog/echoroot.html)

## 注意
- ソフトウェアアップデートが常に配信されているため、これがあなたのechoで動作することを保証できません。問題が発生した場合はお気軽にご連絡ください。バグを発見した場合はプルリクエストも歓迎します。
- Windowsでの動作テストができておらず、Windows特有のバグが存在しない保証もないため、**Linux環境での実行を強く推奨します**。

> **警告**
> 
> **これはテザードrootソリューションです** デバイス上のrootを破損または削除するアップデートを防ぐために、AmazonのOTAサーバー（https://d1s31zyz7dcc2d.cloudfront.net および https://d1s31zyz7dcc2d.cloudfront.prod.ota-cloudfront.net）をブロックすることを_推奨_します。デバイスの損害については責任を負いかねます。

## 機能
- USBまたはWi-Fi経由でのrooted ADBシェル
- デバイスからの音声録音
- インターネットなしでHome AssistantのインジケーターとしてEchoを使用
- デバイスを工場出荷時設定に復元

## インストール
- このプロジェクトはpython 3が必要です。
- このプログラムの実行にはLinuxの使用を推奨します。ModemManagerをインストールしている場合は無効化してください。
`pip`を使って必要なパッケージをインストールしてください：
```sh
pip install -r requirements.txt
```
- また、fastbootとADBも必要です。これらのインストール方法については[こちら](https://wiki.lineageos.org/adb_fastboot_guide)に良いガイドがあります。ダウンロード後、config.jsonファイルで実行可能パスを設定できます。  
- Echo Dotを接続するためのマイクロUSBケーブルは、データ転送対応のものを使用し、電源供給のみのケーブルではないことを確認してください。

## ドキュメント  
このツールの動作については[私のウェブサイト](https://dragon863.github.io/blog/echoroot.html)で確認できます。

デバイスのroot化が完了すると、`preloader_no_hdr.bin`というファイルが生成されます。デバイスを起動するには[mtkclient](https://github.com/bkerler/mtkclient)をインストールし、そのディレクトリにファイルをコピーして `python mtk plstage --ptype=kamakiri2 --preloader=preloader_no_hdr.bin` を実行してください。インストールされているPythonのバージョンに応じて`python`を`python3`に置き換えてください。

## Home assistant インジケーター  
Home assistant インジケーター機能を使用する場合、raspberry pi zero wやその他の小型SBCでpython flaskサーバーを実行し、デバイスを起動することを推奨します。crontabを使って起動時にmtkclientを自動実行することが可能です。

## Echoがブリックした？  
root化または部分的にroot化されたEchoのアンブリックには、[こちらのガイド](https://github.com/Dragon863/EchoCLI/blob/main/debrick.md)に従い、mtkclientを使用してください。

## 感謝

このプロジェクトは以下の方々なしでは実現できませんでした：  
- [j10hx40r](https://forum.xda-developers.com/m/j10hx40r.11878441/) - デバイスの初期root化の支援、パッチシステムの再設計、fos_flagsの組み合わせ使用方法の指導、および資源探しの適切な方向付けをしていただきました  
- [xyzz's Amonet](https://github.com/xyzz/amonet) - このデバイス用に適応したエクスプロイトで、bootromエクスプロイトも含みます  
- [chaosmaster](https://github.com/chaosmaster) - 多くの有用なamonetコードを作成し、その中のいくつかのスニペットを使用させていただきました。GPT修正用のコードも含まれます  

## 連絡先  
- メールアドレス: dragon863.dev@gmail.com  
- [XDAフォーラム](https://forum.xda-developers.com/m/lemon86.12487447/)で会話を始めることもできます


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---