<div align="center">
  <img src="https://raw.githubusercontent.com/Stallion77RepoOfficial/MetalGoose/main/Assets/logo.png" alt="MetalGoose ロゴ" width="128" height="128">
  
  # MetalGoose
  
  **macOS向けGPUアクセラレーションによるアップスケーリングとフレーム生成**
  
  [![macOS](https://img.shields.io/badge/macOS-26.0%2B-blue?logo=apple)](https://www.apple.com/macos/)
  [![Metal](https://img.shields.io/badge/Metal-4.0-orange?logo=apple)](https://developer.apple.com/metal/)
  [![License](https://img.shields.io/badge/License-GPL--3.0-green)](LICENSE)
  [![Swift](https://img.shields.io/badge/Swift-6.2-FA7343?logo=swift)](https://swift.org)
  
  [機能](#features) • [インストール](#installation) • [使い方](#usage) • [要件](#requirements) • [ビルド](#building) • [ライセンス](#license)
</div>

---

## 概要

MetalGooseはゲームやアプリケーション向けにリアルタイムのアップスケーリングとフレーム生成を提供するmacOSネイティブアプリケーションです。AppleのMetalフレームワークのみで構築されており、NVIDIA DLSSやAMD FSRに似た滑らかで高FPSの体験をmacOS向けに実現します。

## 機能

### MGUP-1 アップスケーリング
- **パフォーマンスモード** — 最小遅延で最速のアップスケーリング
- **バランスモード** — 最適な画質と性能のバランス
- **クオリティモード** — 最大の画質忠実度
- 複数のレンダースケール：ネイティブ、75%、67%、50%、33%
- コントラスト適応型シャープニング（CAS）

### MGFG-1 フレーム生成
- **2倍、3倍、4倍**のフレーム倍率
- **適応型**または**固定**フレーム生成モード
- 動き補償補間
- 光学フローに基づく動き推定
- 画質モード：パフォーマンス、バランス、クオリティ

### アンチエイリアシング
- **FXAA** — 高速近似アンチエイリアシング
- **SMAA** — 強化されたサブピクセル形態学的AA
- **MSAA** — マルチサンプルアンチエイリアシング  
- **TAA** — 履歴を用いた時間的アンチエイリアシング  

### パフォーマンスモニタリング  
- リアルタイムHUDオーバーレイ  
- キャプチャ/出力/補間FPSトラッキング  
- GPU時間およびフレーム時間メトリクス  
- VRAM使用量モニタリング  
- フレーム統計  

## 要件  

| コンポーネント | 要件 |  
|-----------|-------------|  
| **macOS** | 26.0 (Tahoe)以降 |  
| **チップ** | Apple Silicon (M1/M2/M3/M4) |  
| **Xcode** | 26.0以降 |  
| **RAM** | 最低8 GB、推奨16 GB |  

## インストール  

### リリースのダウンロード  
1. [Releases](https://github.com/Stallion77RepoOfficial/MetalGoose/releases)から最新のリリースをダウンロード  
2. `MetalGoose.app`を`/Applications`に移動  
3. 画面録画とアクセシビリティの権限を求められたら許可  

### ソースからビルド
```bash
git clone https://github.com/Stallion77RepoOfficial/MetalGoose
cd MetalGoose
open MetalGoose.xcodeproj
```
## 使用方法

1. **MetalGooseを起動**
2. **ターゲットを選択**
   - キャプチャするウィンドウまたはディスプレイを選択
3. **設定を構成**
   - アップスケーリングを有効化（MGUP-1）
   - フレーム生成を有効化（MGFG-1） 
   - アンチエイリアスモードを選択
4. **スケーリング開始**
   - 「開始」をクリックして処理を開始

### キーボードショートカット

| ショートカット | アクション |
|----------|--------|
| `⌘ + T` | スケールの切り替え |

# MetalGooseエラーコード

## UI (MG-UI)
- MG-UI-002: 最前面のアプリがMetalGooseです。ユーザーはターゲットウィンドウに切り替える必要があります。
- MG-UI-003: 選択したアプリのターゲットウィンドウが見つかりません。
- MG-UI-004: ディスプレイが見つかりません。
- MG-UI-005: 全画面ウィンドウが検出されました。仮想ディスプレイはウィンドウモードまたはボーダーレスモードが必要です。
- MG-UI-006: ターゲットウィンドウの境界が取得できません。
- MG-UI-007: ターゲット画面のディスプレイIDが見つかりません。
- MG-UI-008: ディスプレイのリフレッシュレートが取得できません。

## エンジン (MG-ENG)
- MG-ENG-001: Metalパイプラインの設定に失敗しました。
- MG-ENG-002: Metalデバイスが利用できません。
- MG-ENG-003: Metalコマンドキューが利用できません。
- MG-ENG-004: MetalFXスペーシャルスケーラーの作成に失敗しました。
- MG-ENG-005: オプティカルフローパイプラインが利用できません。
- MG-ENG-006: フレーム補間に失敗しました。
- MG-ENG-007: アンチエイリアシングパイプラインが利用できません。
- MG-ENG-008: スケールパイプラインが利用できません。
- MG-ENG-009: CASパイプラインが利用できません。

- MG-ENG-010: IOSurface テクスチャの作成に失敗しました。
- MG-ENG-011: 光学フローパイプラインが利用できません。
- MG-ENG-012: 光学フローリソースが利用できません。
- MG-ENG-013: フレーム生成パイプラインが利用できません。

## バーチャルディスプレイ (MG-VD)
- MG-VD-001: CGVirtualDisplayDescriptor の作成に失敗しました。
- MG-VD-002: CGVirtualDisplay の作成に失敗しました。
- MG-VD-003: CGVirtualDisplayMode の作成に失敗しました。
- MG-VD-004: CGVirtualDisplaySettings の作成に失敗しました。
- MG-VD-005: バーチャルディスプレイ設定の適用に失敗しました。
- MG-VD-006: アクティブなバーチャルディスプレイがありません。
- MG-VD-007: ScreenCaptureKit にバーチャルディスプレイが見つかりません。
- MG-VD-008: ScreenCaptureKit のキャプチャ開始に失敗しました。
- MG-VD-009: ScreenCaptureKit のキャプチャ停止に失敗しました。
- MG-VD-010: ScreenCaptureKit ストリームがエラーで停止しました。

## アクセシビリティ / ウィンドウ移行 (MG-AX)
- MG-AX-001: アクセシビリティ権限が許可されていません。
- MG-AX-002: AX API からウィンドウリストの読み取りに失敗しました。
- MG-AX-003: 対象 PID のウィンドウが見つかりません。
- MG-AX-004: AX 位置値の作成に失敗しました。
- MG-AX-005: AX ウィンドウ位置の設定に失敗しました。
- MG-AX-006: フルスクリーンウィンドウはバーチャルディスプレイに移動できません。
- MG-AX-007: AX サイズ値の作成に失敗しました。
- MG-AX-008: AX ウィンドウサイズの設定に失敗しました。
- MG-AX-009: バーチャルディスプレイスクリーンが見つかりません。
- MG-AX-010: 対象 PID のウィンドウ ID が見つかりません。

## オーバーレイ (MG-OV)
- MG-OV-001: オーバーレイ作成のための対象スクリーンがありません。
- MG-OV-002: オーバーレイ作成のためのウィンドウフレームがありません。
- MG-OV-003: オーバーレイテクスチャ作成に対応していないピクセルフォーマットです。

## マウスルーティング (MG-MO)
- MG-MO-001: マウスルーティング用にバーチャルディスプレイが設定されていません。

## ライセンス

本プロジェクトは GNU General Public License v3.0 の下でライセンスされています。詳細は [LICENSE](LICENSE) ファイルをご覧ください。

## Acknowledgments

- Apple for the Metal framework and documentation
- The macOS gaming community for feedback and testing
- Contributors who helped improve the project

---

RESOURCES THAT USED FOR THIS PROJECT

https://developer.apple.com/documentation/metal
https://developer.apple.com/documentation/metalfx/
https://developer.apple.com/documentation/coreimage
https://developer.apple.com/documentation/screencapturekit/
https://developer.apple.com/documentation/appkit
https://developer.apple.com/documentation/metal/mtltexture
https://developer.apple.com/documentation/corevideo/cvpixelbuffer
https://developer.apple.com/documentation/metalperformanceshaders
https://developer.apple.com/documentation/metal/compute-passes
https://developer.apple.com/documentation/vision
https://developer.apple.com/documentation/vision/vngenerateopticalflowrequest
https://developer.apple.com/documentation/ScreenCaptureKit/capturing-screen-content-in-macos


<div align="center">
  <sub>Built with ❤️ using Metal for macOS</sub>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-16

---