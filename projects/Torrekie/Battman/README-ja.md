# Battman
Strayersの古き良きiOSデバイスのためのモダンなバッテリーマネージャー。

### 🌍
[简体中文](https://raw.githubusercontent.com/Torrekie/Battman/master/docs/README-zh_CN.md)

## スクリーンショット
<div style="width:20%; margin: auto;" align="middle">
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Main.png?raw=true" alt="Battman Main Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Gas Gauge.png?raw=true" alt="Battman Gas Gauge Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Gas Gauge-1.png?raw=true" alt="Battman Gas Gauge Demo 2" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Adapter.png?raw=true" alt="Battman Adapter Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Inductive.png?raw=true" alt="Battman Inductive Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Inductive-1.png?raw=true" alt="Battman Inductive Demo 2" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Serial.png?raw=true" alt="Battman Serial Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Temperature.png?raw=true" alt="Battman Temperature Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/ChargingMgmt.png?raw=true" alt="Battman Charging Management Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/ChargingLimit.png?raw=true" alt="Battman Charging Limit Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Thermal.png?raw=true" alt="Battman Thermal Demo" width="25%" height="25%" />
</div>

$${\color{grey}真のソフトウェアの優雅さは、表面的なデザインではなく、そのコードの芸術に宿る。}$$

<br />

### 利点
- [x] 完全にObjective-CとCで構築
- [x] UIも素晴らしいObjective-Cコードで純粋に記述
- [x] StoryBoardsなし、追加バイナリなし、Xcodeアセットなし
- [x] SwiftやSwiftUIは一切使用していない
- [x] CocoaPodsなし、Swiftパッケージなし、外部コード不要、サードパーティフレームワークなし
- [x] Xcodeの有無にかかわらずコンパイル可能
- [x] Linuxでもビルド可能（「iOSアプリを作るにはMacが必要」というのはAppleの宣伝）
- [x] ハードウェアからの最深部の生データを直接取得・操作
- [x] iPhone、iPad、iPod、Xcodeシミュレーター、Apple Silicon Macに対応（デバイスの寄付があればApple WatchやApple TVのコーディングも可能）
- [x] Texas Instruments製のバッテリーGas Gauge ICと高度に統合
- [x] IOPSやPowerManagementより多くの電力情報を表示
- [x] 電源アダプター、ワイヤレス充電器、さらにはMagSafeアクセサリーも識別

### Battmanだけができること

iOS向け他のバッテリーユーティリティが実現していないこと  
(2025年3月9日 日曜日 UTC+0 現在)  
- [x] NotChargingReasonの完全デコード（[not_charging_reason.h](https://raw.githubusercontent.com/Torrekie/Battman/master/Battman/battery_utils/not_charging_reason.h)参照）  
- [x] Texas Instruments Impedance Track™ 情報の取得  
- [x] リアルタイムの充電電流／電圧読み取り  
- [x] Xcodeシミュレータで完全動作（他のアプリはIOPSを使用しているためシミュレータ非対応）  
- [x] スマート充電（最適化バッテリー充電）通信  
- [x] 低電力モードの動作制御  
- [x] 接続されたMagSafeアクセサリの詳細情報  
- [x] 接続されたLightningケーブルおよびアクセサリの詳細情報  
- [x] すべてのハードウェア温度センサーの読み取り  

### 必要条件  

- ジェイルブレイク済み、またはTrollStore経由でインストール  
- iOS 12以上 / macOS 11以上（バックポート歓迎）  
- arm64（理論上A7以上 / M1以上）  
- Gettext libintl（オプション、ローカライズ用）  
- GTK+ 3（オプション、GTK+ベースのWMでの実行用）  

### ダウンロード  

最新の[Release](https://github.com/Torrekie/Battman/releases/latest)からプリビルドパッケージを入手してください。  

または、自分でビルドしたい場合：  

```bash
# On macOS, install Xcode and directly build in it
# On Linux or BSD, make sure a LLVM cross toolchain and iPhoneOS.sdk is prepared, modify Battman/Makefile if needed
# On iOS, when you using Torrekie/Comdartiwerk as bootstrap
apt install git odcctools bash clang make sed grep ld64 ldid libintl-dev iphoneos.sdk
git clone https://github.com/Torrekie/Battman
cd Battman
# If Targeting iOS 12 or ealier, download SF-Pro-Display-Regular.otf somewhere, and put it under Battman/
wget <https://LINK/OF/SF-Pro-Display-Regular.otf> -O Battman/SF-Pro-Display-Regular.otf
make -C Battman all
# Produced Battman.ipa will under $(CWD)/Battman/build/Battman.ipa
```
### 既知の問題

- Battmanは、A7からA10のデバイスで実行すると実際にはハードウェアと統合されていません。これらのデバイスにはAppleSMCがなく、代わりにAppleHPMを使用しているため、テストできていません。

### テスト済みデバイス
- iPhone 12 シリーズ (D52)
- iPad Pro 2021 第3世代 (J51)
- iPhone XR
- iPad Air 2

お使いのデバイスでBattmanが正しく動作しない場合は、[issues](../../issues/new)を提出してください。

### TODO
- [ ] macOS用AppKit/Cocoa UI
- [ ] iOS/macOS用GTK+/X11 UI
- [ ] ガスゲージICの自動識別
- [ ] オプションのデータ収集（現在不明なパラメータのデコード用）
- [x] 高度な機能（AppleSMC/ApplePMGRインターフェース）
- [x] サーマルコントロール
- [ ] CLIとして実行
- [ ] デーモンとして実行
- [x] 充電制限
- [x] ワイヤレス/MagSafe統合
- [ ] アプリのレート制限
- [ ] Jetsam制御
- [ ] ファンコントロール
- [ ] Bluetoothアクセサリ（AirPodsなど）

### ライセンス

2025年9月27日（土）UTC+0時点で、BattmanはMITではなく[非フリーライセンス](https://raw.githubusercontent.com/Torrekie/Battman/master/LICENSE/LICENSE.md)を使用しています。これで生計を立てたいと思っても責めないでくださいね？

## 免責事項

本製品は商用利用禁止、保証は一切ありません。使用は自己責任でお願いします。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-23

---