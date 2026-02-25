# 🐋 Qwen Image 統合 KSampler

[![GitHub](https://img.shields.io/badge/GitHub-luguoli-orange)](https://github.com/luguoli)
[![ComfyUI](https://img.shields.io/badge/ComfyUI-CustomNode-blue)](https://github.com/comfyanonymous/ComfyUI)

[English](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/README-en.md) | **[简体中文](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/README-zh.md)**

QwenImageIntegratedKSampler

これは統合されたComfyUI Qwen-Image画像生成サンプラーノードで、Z-Imageをサポートします。公式のKSamplerを使用する場合と比較して、配線の煩雑さを排除し、テキストから画像生成および画像から画像生成の両方をサポートし、公式ノードのオフセット問題を解決し、プロンプト入力ボックス、自動画像スケーリング、自動メモリ/VRAMクリーンアップ、バッチ生成、自動保存などの包括的な最適化機能を統合しているため、もう母は私の配線の煩雑さを心配する必要がありません~~~~

#### このプロジェクトがあなたの役に立ったら、⭐Starをお願いします — 使っている人がいることを知らせてくれます！

## 🏆 特徴

### 🎨 対応生成モード
- **Z-Image**: Z-Imageモデルをサポート
- **テキストから画像生成**: テキストプロンプトから画像を生成
- **画像から画像生成**: 参照画像に基づく生成、画像編集、最大5枚の画像をサポート

### ⚡ 高度な最適化
- **オフセット問題の最適化**: 公式ノードのオフセット問題を解決し、指示により忠実に従う
- **統合サンプリングアルゴリズム（AuraFlow）**: サンプリングアルゴリズム（AuraFlow）ノードを統合し、追加の配線不要
- **CFGNorm統合**: CFGNormノードを統合し、追加の配線不要

### 🖼️ 画像処理
- **統合プロンプト入力ボックス**: プロンプト入力ボックスを統合し、追加の配線不要
- **複数参照画像対応**: 条件生成のため最大5枚の参照画像をサポート
- **自動画像スケーリング**: 目標サイズにリサイズしつつアスペクト比を維持

- **ControlNet制御対応**: ポーズや深度などの制御のために[🐋 Qwen ControlNet 統合ローダー]への追加接続をサポート

### 🔧 生産性向上
- **バッチ生成**: 一度の操作で複数画像を生成
- **自動VRAMクリーンアップ**: GPU/VRAMメモリの自動クリーンアップオプション
- **自動RAMクリーンアップ**: RAMメモリの自動クリーンアップオプション
- **自動結果保存**: 生成された結果画像を指定フォルダに自動保存
- **完了音通知**: 生成完了後に音声リマインダーを再生

## 🍧 比較表示
### 🔄 ワークフローの複雑さ比較
- **❌ [Qwen Image Integrated KSampler] を使わないワークフロー（複雑、ノード多すぎ、配線多すぎ）**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/1-1-en.png)
- **✅ [Qwen Image Integrated KSampler] を使ったワークフロー（非常にシンプル、単一ノードで完了、ほぼ配線なし）**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/1-2-en.png)

### 🖼️ 生成画像の効果比較
- **❌ [Qwen Image Integrated KSampler] を使わないワークフロー（明らかなオフセット、スケーリング）**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/2-1.png)
- **✅ [Qwen Image Integrated KSampler] を使ったワークフロー（完全にオフセット、スケーリングなし）**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/2-2.png)

## 📦 インストール方法

### 方法1: ComfyUI Manager経由（推奨）
1. ComfyUIインターフェースでComfyUI Managerを開く
2. 「ComfyUI-Qwen-Image-Integrated-KSampler」を検索する
3. インストールをクリックする

### 方法2: 手動インストール
1. ComfyUIのカスタムノードディレクトリに移動する:
   ```bash
   cd /path/to/ComfyUI/custom_nodes
   ```

2. リポジトリをクローンする:
   ```bash
   git clone https://github.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler.git
   or gitee repository:
   git clone https://gitee.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler.git
   ```

3. 依存関係のインストール:
   ```bash
   pip install -r requirements.txt
   ```
4. ComfyUIを再起動する

## 🚀 使用方法

### [ワークフロー例](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/workflow_example.json)

### 基本的なテキストから画像生成

1. ワークフローに「🐋 Qwen Image Integrated KSampler」ノードを追加する
2. `generation_mode` を「text-to-image」に設定する
3. 必要な入力を接続する：
   - モデル (🤖 Model)
   - CLIP (🟡 Clip)
   - VAE (🎨 Vae)
4. ポジティブおよびネガティブプロンプトを入力する
5. 幅と高さを設定する（テキストから画像生成に必須）
6. サンプリングパラメータを設定する（ステップ数、CFG、サンプラー、スケジューラ）
7. ワークフローを実行する

### 画像から画像生成

1. ノードをワークフローに追加する
2. `generation_mode` を「image-to-image」に設定する
3. 少なくとも1つの参照画像を接続する（🖼️ Image1）
4. 必要に応じて最大4つまで他の参照画像を追加する
5. ポジティブ／ネガティブプロンプトと指示を入力する
6. スケーリング用のターゲット幅／高さを設定する（任意）
7. 必要に応じて他のパラメータを設定する
8. ワークフローを実行する

### ControlNet制御

1. [🐋 Qwen ControlNet Integrated Loader]ノードを追加し、[📦 ControlNet Data]に接続する

2. ポーズ、深度の制御画像を接続する

3. ControlNetモデルを選択し、制御タイプと強度を設定する

4. ワークフローを実行する

![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/3-en.png)

### 高度な機能

- **メモリ管理**：GPU/CPUクリーンアップオプションを有効にしてリソース効率を向上
- **バッチ処理**：複数画像生成のためにbatch_size > 1を設定
- **自動保存**：自動保存用の出力フォルダを指定
- **AuraFlow調整**：auraflow_shiftで速度と品質のバランスを調整
- **CFG強化**：CFGの安定化機能

## ⚠️ 注意事項

### 📝 使用要件
- **テキストから画像モード**：幅(Width)と高さ(Height)を必ず設定、これらは必須パラメータ
- **画像から画像モード**：少なくとも1枚の参照画像(Image1)を提供、最大5枚の参照画像(Image1-Image5)に対応

### 🎛️ パラメータ設定の推奨
- **バッチサイズ**：1～10の範囲で選択、GPUメモリに応じて調整、初回は1からテスト推奨
- **解像度(幅/高さ)**：8の倍数でなければならず、範囲は0～16384、低解像度(512x512等)からテスト推奨
- **サンプリングステップ数**：Qwenモデルは4～20ステップ推奨、高すぎると計算時間増加だが品質向上は必ずしも保証されない
- **CFG値**：範囲0～100、デフォルト1.0、1.0～7.0の範囲を推奨
- **ノイズ除去強度**：範囲0～1、デフォルト1.0、画像から画像モードでは適宜低減可能
- **AuraFlowシフト**：範囲0～100、デフォルト3.0、生成速度と品質のバランス調整用
- **CFG正規化強度**：範囲0～100、デフォルト1.0、CFGの安定化用

### 🔧 画像処理
- **自動スケーリング**：テキストから画像では幅と高さを入力必須、画像から画像では参照画像をアスペクト比を保持して自動スケール、幅または高さを0に設定するとスケーリング無効
- **参照画像の順序**：最大5枚の参照画像に対応、Image1-Image5の順に処理、Image1がメイン画像
- **画像フォーマット**：標準的な画像入力形式に対応、バッチ次元も自動処理

### 💾 メモリ管理
- **GPUメモリクリーンアップ**：enable_clean_gpu_memoryオプションを有効にし、生成前後にVRAMを自動クリア
- **CPUメモリクリーンアップ**：enable_clean_cpu_memory_after_finishを有効にし、生成完了後にRAM（ファイルキャッシュ、プロセス、動的ライブラリ含む）をクリア
- 大規模連続生成時は、メモリオーバーフロー防止のためクリーンアップオプションを常に有効推奨

### 💾 自動保存
- **出力フォルダ**：auto_save_output_folderを設定して自動保存機能を有効化、空欄で無効、絶対パス・相対パス対応
- **ファイル命名**：output_filename_prefixでカスタム接頭辞設定、デフォルトは"auto_save"
- 保存形式はPNG、ファイル名にシード値とバッチ番号を含む（例：auto_save_123456_00000.png）


### 🔊 通知機能
- **サウンド通知**：Windowsシステムのみ対応

## 📝 更新履歴
### v1.0.6:
- **ローカリゼーションスクリプト追加:** ComfyUI v0.3.68以降、中国語ファイルが無効になりました。自動ローカリゼーションスクリプトを追加し、[自动汉化节点.bat]をダブルクリックしてComfyUIを再起動してください。ComfyUI-DD-Translationプラグインのインストールが必要です。


## 📞 特別カスタマイズのお問い合わせ 📞
- 作者: @luguoli（墙上的向日葵）
- 作者メール: luguoli@vip.qq.com


---

**ComfyUIコミュニティのために❤️を込めて作成**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-25

---