![Logo](https://raw.githubusercontent.com/TA2k/ioBroker.vw-connect/master/admin/vw-connect.png)

# ioBroker.vw-connect

[![NPM version](http://img.shields.io/npm/v/iobroker.vw-connect.svg)](https://www.npmjs.com/package/iobroker.vw-connect)
[![Downloads](https://img.shields.io/npm/dm/iobroker.vw-connect.svg)](https://www.npmjs.com/package/iobroker.vw-connect)
[![Dependency Status](https://img.shields.io/david/ta2k/iobroker.vw-connect.svg)](https://david-dm.org/ta2k/iobroker.vw-connect)
[![Known Vulnerabilities](https://snyk.io/test/github/ta2k/ioBroker.vw-connect/badge.svg)](https://snyk.io/test/github/ta2k/ioBroker.vw-connect)

[![NPM](https://nodei.co/npm/iobroker.vw-connect.png?downloads=true)](https://nodei.co/npm/iobroker.vw-connect/)

**テスト:**: [![Travis-CI](http://img.shields.io/travis/ta2k/ioBroker.vw-connect/master.svg)](https://travis-ci.org/ta2k/ioBroker.vw-connect)

## ioBroker用 vw-connect アダプター

VW We Connect、We Connect ID、We Charge、myAudi、Skoda Connect、Seat Connect、We Connect Go用アダプター

システムをNode 10にアップデートしてください。
<https://forum.iobroker.net/topic/22867/how-to-node-js-f%C3%BCr-iobroker-richtig-updaten>

## 使用方法

リモートコントロール下のステートを使って車をリモートで操作します。
通常のリフレッシュはVAGクラウドからデータを受信するポーリング間隔です。
強制リフレッシュは非電気自動車向けで、車が再度始動されるまでVAGによって制限されるリフレッシュを強制します。
トリップデータは非電気自動車のみ利用可能です。

climatisation温度は
.climater.settings.targetTemperature.content
で設定できます。

## 議論と質問

<https://forum.iobroker.net/topic/26438/test-adapter-vw-connect-für-vw-id-audi-seat-skoda>

## ステータスフィールドの説明

### エントリーの一覧
```

```
## 変更履歴

### 0.7.12 (2025-05-05)

- skodaのリフレッシュトークンの修正
- 換気の起動修正
- 新しい非対応エンドポイントを追加

### 0.7.9 (2025-03-20)

- idウォールチャージャーの修正

### 0.7.7 (2025-03-02)

- skodaの補助暖房と継続時間の修正
- skodaのロック/アンロック修正

### 0.7.6 (2025-02-28)

- 起動時のみの充電状態更新の修正
- skodaの移動中状態の修正

### 0.7.3 (2025-02-26)

- setTemperatureの設定修正
- Skodaのロック/アンロック修正

### 0.7.0 (2025-02-25)

- skodaとseatの修正
- 状態構造を完全に変更しました。古い状態はObjects下で削除してください

### 0.6.1 (2024-10-01)

- skodaログインの修正

### 0.6.0 (2024-04-11)

- 追加のcupraステートを追加

### 0.5.4 (2024-03-17)

- ドア・ウィンドウの状態修正

### 0.4.1

- VWのステータス更新修正

### 0.0.65

- Cupraログイン修正

### 0.0.63

- VW/Skoda etronログイン修正

### 0.0.62

- Audi etronログイン修正

### 0.0.61

- IDログイン修正

### 0.0.60

- 軽微な改善。WeChargeの最小間隔が15分に設定されました

### 0.0.55

- idのステータス更新修正

### 0.0.51

- audi etronログイン修正

### 0.0.48

- ログイン修正、audi更新修正、ウォールボックスの制限追加

### 0.0.43

- リフレッシュトークンのタイムアウト延長

### 0.0.42

- skodaログイン修正

### 0.0.40

- 新しい車向けのclimate v3追加。PowerpassとSeat Elli追加

### 0.0.39

- idログイン修正

### 0.0.36

- Skoda Enyaq対応追加

### 0.0.35

- nodeJS v10 互換性を追加

### 0.0.34

- 新しいプライバシー同意の自動承諾を追加

### 0.0.32

- 最新の最近の旅行の選択を修正

### 0.0.31

- 複数の旅行タイプの選択を有効化

### 0.0.30

- 複数車両問題を修正、VWv2モードを追加。現在VWとVWv2の違いはなし

### 0.0.29

- SkodaのrefreshTokenを修正、小さな改善

### 0.0.26

- バグ修正

### 0.0.25

- we charge を追加

### 0.0.24

- リモート状態更新を追加

### 0.0.23

- Seat と新しいclimatisation v2を追加

### 0.0.22

- Skoda と Audi の外気温を°Cで計算するように変更

### 0.0.21

- id用のリモートを追加

### 0.0.20

- audiログインを修正、IDログインを追加

### 0.0.19

- ステータスオブジェクトを連続番号ではなくidでstateに保存

### 0.0.18

- 2020年モデルのバッテリーステータスを修正

### 0.0.17

- 2020年モデルのサポートを追加

### 0.0.16

- js.controller 3 の問題を修正

### 0.0.11

- 複数車両のaudiバグを修正
- 機能が利用できない場合のステータス更新エラーを非表示に

## ライセンス

MIT ライセンス

Copyright (c) 2019-2030 ta2k <tombox2020@gmail.com>

本ソフトウェアおよび関連文書ファイル（以下「ソフトウェア」）のコピーを取得するすべての人に、使用、複製、改変、結合、公開、配布、サブライセンス、および/または販売する権利を無償で許可します。

ただし、以下の条件に従うものとします：

上記の著作権表示および本許可表示は、ソフトウェアのすべてのコピーまたは重要な部分に記載しなければなりません。

ソフトウェアは「現状のまま」提供され、明示的であれ黙示的であれ、商品性、特定目的への適合性および権利非侵害についての保証を含むいかなる保証もなく提供されます。著作者または著作権者は、契約行為、不法行為またはその他の行為に起因するか否かを問わず、ソフトウェアまたはその使用その他の取引に関して生じるいかなる請求、損害またはその他の責任についても責任を負いません。













---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---