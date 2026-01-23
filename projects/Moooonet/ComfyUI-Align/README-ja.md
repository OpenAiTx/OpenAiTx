<div align="center">
<img src="https://moooonet.github.io/assets/Comfy-Align//images/display.jpg" width="100%">
<br><br>

[![Version](https://img.shields.io/badge/Version-3.0.4-cyan)](README.md)
[![Youtube](https://img.shields.io/badge/Video-Tutorial-red)](https://youtu.be/p1niyxwsOes)

</div>

ComfyUI-Alignは、ComfyUIに欠けていたノードの整列機能を補う強力なノード整列、ストレッチ、カラー設定ツールを提供します。

> _このプラグインがあなたの正気を保つ助けになったなら、カフェイン習慣維持のために⭐をお願いします。_

## 環境

- ComfyUI: バージョン0.3.76でテスト済み。理論上は最近および将来のバージョンをサポート。
- Python: Python 3.12でテスト済み
- システム: Windows 11およびUbuntu 25.10でテスト済み。他のLinuxディストリビューションでも動作するはずですので、ご自身でテストしてください。理論上はmacOSもサポートしますが、デバイスがないため未テストです。

## インストール

- **ComfyUIマネージャーから:** ComfyUIマネージャーで「ComfyUI-Align」を検索してインストール。
- **Gitクローン:** ComfyUIディレクトリを開き、`custom_nodes`フォルダに移動して、以下を実行：
  ```bash
  git clone https://github.com/Moooonet/ComfyUI-Align.git
  ```
- **ComfyUIの再起動:** インストール後、新しいプラグインを読み込むためにComfyUIを再起動してください。

## 設定と使い方

- **ショートカットキー:** デフォルトはバッククォートキー <kbd>`</kbd> です。複数システムでの互換性を考慮し、カスタムショートカットキーはComfyUIのネイティブ機能で実装されています。カスタムショートカットキーを設定するには、Keybindingsで「Align Panel」を検索してください。

<div align="center">
  <img src="https://moooonet.github.io/assets/Comfy-Align/images/keybindings.jpg" width="100%">
</div>

- **2つの操作モード:**
- 1. <kbd>`</kbd> キーで整列パネルの表示・非表示を切り替えます。（バッククォートキーはTabキーの上にあります）
- 2. 設定でホールドモードを有効にします（ショートカットを押し続けるとパネルが表示され、ボタンにホバーしてキーを離すとクリックせずに実行されます。またはキーを押し続けて異なるボタンをクリックし、複数の操作を行えます）。

<div align="center">
  <img src="https://moooonet.github.io/assets/Comfy-Align/images/settings.jpg" width="100%">
</div>

## 主な機能

### 1. ノードおよびグループの整列、分布、ストレッチ

- **整列:**

  - **左揃え、右揃え、上揃え、下揃え:**
  - `Alt`キー: <kbd>Alt</kbd>を押しながら整列すると、対象ノードが反転します。

- **分布:**

  - **水平上揃え分布:** まず水平方向に均等に分布し、その後上揃えします。
  - **垂直中央揃え分布:** まず垂直方向に均等に分布し、その後中央揃えします。
  - **間隔設定:** `Align`オプションで間隔を設定できます。

- **ストレッチ:**
  - **左ストレッチ、右ストレッチ、上ストレッチ、下ストレッチ:**
  - **水平両側ストレッチ:** 最も幅の広いノードを基準にし、他のノードが基準ノードの左右に幅を維持してストレッチします。
  - **垂直両側ストレッチ:** 最も高さのあるノードを基準にし、他のノードが基準ノードの上下に高さを維持してストレッチします。
  - **`Alt`キー:** <kbd>Alt</kbd>を押しながらストレッチすると、対象ノードが反転します。

### 2. ノードおよびグループの色管理
- **ColorBar（カラーバー）:**

  - 7つのデフォルトカラー
  - ムーンアイコン（ColorPickerを開くため）
  - カラークリア（選択したノードの色をクリア）
  - カラー適用（プリセットから対応するノードに色を適用）

- **ColorPicker（カラーピッカー）:**

  - カラー選択エリア
  - スポイトツール
  - 色相スライダー
  - アルファスライダー
  - HEX値（クリックでコピー、ダブルクリックで編集）
  - RGBA値（クリックでコピー、ダブルクリックで編集。Ctrlを押しながらで全値コピー）
  - カラーヒストリー
  - カラープリセット

- **ColorPresets（カラープリセット）:**
  - 最初にプラグインのルートディレクトリに`color_presets.json`ファイルが生成され、カスタムカラープリセットを保存します。
  - ノードの色を設定後、`Save`ボタンをクリックしてプリセットを保存します。
  - `Clear`ボタンをクリックして保存されたプリセットカラーをすべてクリアします。
  - `Apply`ボタンをクリックしてプリセットの色を対応するノードに適用します。（`Apply`ボタンは`ColorBar`の最後にあります）

---

<div align="center">
   <a href="https://www.star-history.com/#Moooonet/ComfyUI-Align&Date">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date&theme=dark" />
      <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date" />
      <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date" />
    </picture>
   </a>
</div>

---

<div align="center">

  <p>明示的に許可されていない限り、統合、改変、または再配布はいかなる形態でも厳禁です。</p>
  <p>© 2025 Moooonet. 無断転載を禁じます。</p>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-23

---