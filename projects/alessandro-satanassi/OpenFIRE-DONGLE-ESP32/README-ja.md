## EPS32用 OpenFIRE-DONGLE


![foto_dongle](https://github.com/user-attachments/assets/a38d7390-f7e7-42d7-844c-ad8388670f6d)



https://github.com/user-attachments/assets/70a193a0-686e-4da3-8d30-f0067de6b63c



このリポジトリは、TeamOpenFIREによるオリジナルプロジェクト「OpenFIRE-firmware」のESP32S3マイコン用に移植されたOpenFIRE-Firmware-ESP32プロジェクトのコードと一緒に使用するために作成されました。
PlatformIOを使用して開発された本プロジェクトは、PCに接続されるドングルとして使用されるESP32S3用のファームウェアであり、ESP32のESP-NOWプロトコルを介したワイヤレス接続を可能にします。このドングルは、ライトガンにインストールされるファームウェア「OpenFIRE-Firmware-ESP32」と組み合わせて使用するよう設計されています。
コードはライトガンを自動検出し、独自に設定するよう構成されています。
ライトガンとドングル間の通信は双方向で、ライトガンをUSBで直接PCに接続しているかのように機能します。
PCはUSBでの直接接続とドングルを介したワイヤレス接続の違いを認識しません。
「OpenFIRE」プロジェクトを作成したTeamOpenFIREに心から感謝の意を表します。すべての功績と深い感謝は彼らにあります。
コードの一部はリポジトリ「SerialTransfer」(https://github.com/PowerBroker2/SerialTransfer.git)から抽出・改変されています。
このコードの作者であるPowerBroker2にも感謝いたします。


このリポジトリは、TeamOpenFIREによるオリジナルプロジェクト「OpenFIRE-firmware」のESP32S3マイコン用に移植されたOpenFIRE-Firmware-ESP32プロジェクトのコードと一緒に使用するために作成されました。
PlatformIOを使用して開発された本プロジェクトは、PCに接続されるドングルとして使用されるESP32S3用のファームウェアであり、ESP32のESP-NOWプロトコルを介したワイヤレス接続を可能にします。このドングルは、ライトガンにインストールされるファームウェア「OpenFIRE-Firmware-ESP32」と組み合わせて使用するよう設計されています。
コードはライトガンを自動検出し、独自に設定するよう構成されています。
ライトガンとドングル間の通信は双方向で、ライトガンをUSBで直接PCに接続しているかのように機能します。
PCはUSBでの直接接続とドングルを介したワイヤレス接続の違いを認識しません。
「OpenFIRE」プロジェクトを作成したTeamOpenFIREに心から感謝の意を表します。すべての功績と深い感謝は彼らにあります。
コードの一部はリポジトリ「SerialTransfer」(https://github.com/PowerBroker2/SerialTransfer.git)から抽出・改変されています。
このコードの作者であるPowerBroker2にも感謝いたします。


## ... TeamOpenFIREによる『OpenFIRE-firmware』プロジェクトのオリジナルページが続きます
## ... follows the original project page 'OpenFIRE-firmware' project by TeamOpenFIRE

### 私たちの仕事を気に入りましたか？[開発者を支援することをお忘れなく！](https://github.com/TeamOpenFIRE/.github/blob/main/profile/README.md)

![BannerDark](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-DONGLE-ESP32/main/docs/of_bannerLoD.png#gh-dark-mode-only)![BannerLight](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-DONGLE-ESP32/main/docs/of_bannerDoL.png#gh-light-mode-only)
# OpenFIRE - オープン *フォー・インファー・レッド・エミッター* ライトガンシステム
###### [IR-GUN4ALL](http://github.com/SeongGino/ir-light-gun-plus) の後継であり、これは [Prow Enhanced fork](https://github.com/Prow7/ir-light-gun) を基にし、さらに 4IR Beta「大規模コード更新」[SAMCOプロジェクト](https://github.com/samuelballantyne/IR-Light-Gun) に基づいています

## 特徴:
- **完全装備の周辺機器**、ソレノイド＆振動フィードバック、TMP36温度監視など、今後も追加予定。
- **複数のIRレイアウト対応**、ダブルライトバー（推奨！）やXwiigun風ダイヤモンドレイアウト（他システム対応）向けに*リアルタイムの遠近調整トラッキング*を搭載。
- **柔軟な入力システム**、キーボード、5ボタンABS（絶対位置）マウス、Dパッド対応のデュアルスティックゲームパッドへの出力と、**強力なボタンマッピングシステム**を備え、ニーズに合わせてカスタマイズ可能！
- **簡単インストール**、*.UF2*形式のバイナリを*RP2040*ベースのマイクロコントローラにドラッグ＆ドロップするだけ。
- **オンボード設定のポータブル保存**、キャリブレーションプロファイル、トグル、設定、USB識別子などを保存可能。
- **[OpenFIRE App](https://github.com/TeamOpenFIRE/OpenFIRE-App)**と連携し、ユーザーフレンドリーかつクロスプラットフォームで即時設定が可能。
- **RP2040向けに最適化**、第2コアで入力ポーリング＆キューイングおよびシリアル処理を行い、メインコアでカメラおよび周辺機器の処理を担当（可能な限り）。
- **PC用フォースフィードバックハンドラと互換**、[Mame Hooker](https://dragonking.arcadecontrols.com/static.php?page=aboutmamehooker)、[The Hook Of The Reaper](https://github.com/6Bolt/Hook-Of-The-Reaper)、[QMamehook](https://github.com/SeongGino/QMamehook)などに対応。
- **統合OLEDディスプレイ出力対応**、*SSD1306 I2Cディスプレイ*でメニュー操作やライフ・弾数などゲーム要素の視覚フィードバックが可能。
- **MiSTer FPGAエコシステムと互換**、ユーザー体験を最大限に向上させる専用マッピングを搭載。
- **ライトガンコミュニティに永遠に無料かつオープンソース！**

___
## 感謝:
* Samuel Ballantyne氏、オリジナルのSAMCOプロジェクト、美しいOpenFIREブランディング、遠近調整トラッキングシステムに感謝。
* Prow7氏、拡張SAMCOフォークでポーズモードや保存サブシステムの基礎を提供。
* Odwalla-J、mrkylegp、RG2020、lemmingDev、事前リリースの相談、バグテスト、フィードバックに感謝。
* IR-GUN4ALLテスターの皆様、早期のフィードバックと機能要望なしには実現しませんでした！
* Chris Young氏、TinyUSB対応ライブラリ（現在は`TinyUSB_Devices`の一部）に感謝。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---