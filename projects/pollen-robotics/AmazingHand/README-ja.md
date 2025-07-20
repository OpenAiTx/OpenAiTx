Project is licensed under [Apache 2.0](https://www.apache.org/licenses/LICENSE-2.0)


メカニカルデザインは以下のライセンスの下にあります：
[クリエイティブ・コモンズ 表示 4.0 国際ライセンス][cc-by]。
[![CC BY 4.0][cc-by-image]][cc-by]
[![CC BY 4.0][cc-by-shield]][cc-by]

[cc-by]: http://creativecommons.org/licenses/by/4.0/
[cc-by-image]: https://licensebuttons.net/l/by/4.0/88x31.png
[cc-by-shield]: https://img.shields.io/badge/License-CC%20BY-lightgrey.svg



# Amazing Hand プロジェクト

![Patterns](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Patterns_Overview.jpg)

ロボットハンドはしばしば非常に高価で、表現力もそれほど高くありません。より器用なものは通常ケーブルや前腕に配置されたアクチュエータを必要とします。

本プロジェクトの目的は、リアルなロボット（Reachy2がその完璧な候補です！）でヒューマノイドハンドの可能性を中程度のコストで探求できるようにすることです。
=> 手首インターフェースはReachy2の手首（Orbita 3D）用に設計されていますが、他のロボットの手首にも簡単に適応可能です...

![Reachy](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Reachy.jpg)

Amazing Hand は以下の通りです：
- 8自由度のヒューマノイドハンド、4本の指を持つ
- 各指は2つの指節が連結されている
- ほぼ全体が柔軟なシェルで構成
- ケーブルなしで全アクチュエータが手内部に内蔵
- 3Dプリント可能
- 重量400g
- 低コスト（200€未満）
- オープンソース

[AmazingHand_Overview](/docs/AmazingHand_Overview.pdf)

![Hand Overview](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Hand_Overview.jpg)
各指は平行機構によって駆動されます。
つまり、各指の屈曲/伸展および外転/内転の動きには、小型のFeetech SCS0009サーボモータが2台使用されています。

![Finger Overview](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Finger_Overview.jpg)


制御方法は2通り利用可能です：
- シリアルバスドライバ（例：waveshare）＋Pythonスクリプトを使用
- Arduino＋feetech TTL Linkerを使用

両方式の詳細な説明があり、基本的なデモソフトも用意されています。
お好みでどうぞ！


## 目次

- [ビルドリソース](#build-resources)
    - [BOM（部品表）](#bom-bill-of-materials)
    - [CADファイルとOnshapeドキュメント](#CAD-files-and-onshape-document)
    - [組み立てガイド](#assembly-guide)
    - [基本デモの実行](#Run-basic-Demo)
- [免責事項](#disclaimer)
- [AmazingHand_トラッキングデモ](#AmazingHand_tracking_Demo)
- [プロジェクトの更新＆コミュニティ](#project-updates--community)
    - [更新履歴](#updates-history)
    - [プロジェクト投稿](#project-posts)
    - [やることリスト](#to-do-list)
    - [FAQ](#faq)
    - [連絡先](#contact)
    - [感謝](#thank-you)


# ビルドリソース
## BOM（部品表）
必要なすべてのコンポーネントのリストはこちら：  
[AmazingHand BOM](https://docs.google.com/spreadsheets/d/1QH2ePseqXjAhkWdS9oBYAcHPrxaxkSRCgM_kOK0m52E/edit?gid=1269903342#gid=1269903342)  
![BOM](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/BOM.jpg)

制御方法の選択費用（前述の2つのオプション）も忘れずに追加してください


カスタム3Dプリント部品の詳細はこちら：  
[3Dプリント部品](https://docs.google.com/spreadsheets/d/1QH2ePseqXjAhkWdS9oBYAcHPrxaxkSRCgM_kOK0m52E/edit?gid=2050623549#gid=2050623549)

![3Dparts](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/3Dparts.jpg)

必要なカスタム部品をすべてプリントする方法のガイドはこちら：
[=> 3Dプリントガイド](/docs/AmazingHand_3DprintingTips.pdf)
![3DPrint_example](/assets/3DPrint.jpg) 



## CADファイルとOnshapeドキュメント
STLおよびSTEPファイルは[こちら](https://github.com/pollen-robotics/AmazingHand/tree/main/cad)で入手可能です

左手を作成したい場合も指は同じですが、一部の部品は左右対称です。右手用の特定部品は「R」で始まり、左手用の部品は「L」で始まります。

![Heart](/assets/Heart.jpg)

誰でもOnshapeドキュメントにアクセス可能です：  
[Onshapeリンク](https://cad.onshape.com/documents/430ff184cf3dd9557aaff2be/w/e3658b7152c139971d22c688/e/bd399bf1860732c6c6a2ee45?renderMode=0&uiState=6867fd3ef773466d059edf0c)  

既定の位置は「named position」ツールで使用可能で、対応するサーボ角度があります

![Onshape&Named_Pos](/assets/Named_Pos.jpg)  

## 組み立てガイド

BOM内の標準部品と組み合わせたAmazing Handの組み立てガイドはこちらです：  
[=> 組み立てガイド](/docs/AmazingHand_Assembly.pdf)  
![Assembly_example](/assets/Assembly.jpg)  

各指をキャリブレーションするための簡単なプログラム/スクリプトが必要です。以下から入手可能です：
- Python & Waveshareシリアルバスドライバ使用：[こちら](https://github.com/pollen-robotics/AmazingHand/tree/main/PythonExample)
- Arduino & TTLinker使用：[こちら](https://github.com/pollen-robotics/AmazingHand/tree/main/ArduinoExample)


この組み立てガイドはスタンドアロンの右手用です。

スタンドアロンの左手を作る場合は、サーボの位置IDを同じに保ち、ソフトウェアで右手か左手かを選択できます。

しかし、ロボットに右手と左手の両方を接続する場合は、右手と左手で異なるIDを割り当てる必要があります。同じシリアルバス上で異なるサーボに同じIDは使えません…

## 基本デモの実行

PythonおよびArduinoで利用可能な基本デモです。

手の内部にある8つのアクチュエータに電力を供給するために外部電源が必要です。

まだお持ちでない場合は、簡単な外部電源としてDC/DC 220V -> 5V / 2Aアダプタ（ジャックコネクタ付き）が使えます。
BOMリストを参照してください：
[AmazingHand BOM](https://docs.google.com/spreadsheets/d/1QH2ePseqXjAhkWdS9oBYAcHPrxaxkSRCgM_kOK0m52E/edit?gid=1269903342#gid=1269903342) 

- Pythonスクリプト："AmazingHand_Demo.py" [こちら](https://github.com/pollen-robotics/AmazingHand/tree/main/ArduinoExample)
  
- Arduinoプログラム："AmazingHand_Demo.ino" [こちら](https://github.com/pollen-robotics/AmazingHand/tree/main/PythonExample)


https://github.com/user-attachments/assets/485fc1f4-cc57-4e59-90b5-e84518b9fed0


# 免責事項

屈曲/伸展、外転/内転の理論角度と実際のプロトタイプの角度に差異が見られます。これは複数の変動要因によると思われます（3Dプリント部品の不完全さ、ボールジョイントロッドの手動調整、サーボホーンの加工、プラスチック部品の柔軟性など）。

この設計はまだ長時間かつ複雑な把持作業でのテストを行っていません。物を安全に掴む（サーボや機械部品を損傷しない）ためには、スマートなソフトウェアの構築が必要です。
SCS0009サーボには以下のようなスマート機能があります：
- トルクの有効/無効化
- トルクフィードバック
- 現在位置センサー
- 温度フィードバック
- ...


# AmazingHand 高度デモ
[![Tracking demo](https://img.youtube.com/vi/U0TfeG3ZUto/maxresdefault.jpg)](https://www.youtube.com/watch?v=U0TfeG3ZUto)

逆運動学/順運動学を用いた高度な使用例は[Demo](Demo)ディレクトリにいくつかあり、モータのテストや設定に役立つツールも含まれています。


# プロジェクトの更新とコミュニティ
## コミュニティからの更新

Amazing Hand用のAmazing Base:  
![Base](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Base.jpg)
STLまたはStepファイルはこちらで入手可能です：[こちら](https://github.com/pollen-robotics/AmazingHand/tree/main/cad) 

中国向けの特定BOMはこちら：
[Chinese BOM](https://docs.google.com/spreadsheets/d/1fHZiTky79vyZwICj5UGP2c_RiuLLm89K8HrB3vpb2h4/edit?gid=837395814#gid=837395814)

Jianliang Shenに感謝！


## 今後の課題
- シリアルハブと電源機能を備えた小型カスタムPCB設計、手内にすべて収める
- 把持作業でのテスト
      => 利用可能なモーターフィードバックに基づく賢い閉じ動作の追加
- 4本の異なる指の長さまたは5本目の指追加の検討
- SCS0009の代わりにSTS3032フィーテッドモータの使用検討
      => ほぼ同体積でより強力だが、サーボホーンが異なる
- 剛性リンクをスプリングに置換してコンプライアンスを追加する検討
- 指先センサーを追加し、より高度なスマート制御を実現


## FAQ
準備中

## 連絡先

公開Discordチャンネルはこちら：  
[Discord AmazingHand](https://discord.com/channels/519098054377340948/1395021147346698300)

または  
[私またはPollen Roboticsに連絡](/docs/contact.md)

## ありがとうございました
これまでこのプロジェクトに貢献してくださった皆様に心から感謝します：
- [Steve N'Guyen](https://github.com/SteveNguyen) ベータテスト、RustypotでのFeetechモータ統合、Mujoco/Minkおよびハンドトラッキングデモ
- [Pierre Rouanet](https://github.com/pierre-rouanet) pypotでのFeetechモータ統合  
- [Augustin Crampette](https://fr.linkedin.com/in/augustin-crampette) & [Matthieu Lapeyre](https://www.linkedin.com/in/matthieulapeyre/) オープンディスカッションおよび機械的助言

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---