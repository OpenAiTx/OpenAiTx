# リアルタイム放射輝度場レンダリングのための3Dガウシアンスプラッティング - C++およびCUDA実装

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)  
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)  
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

[gsplat](https://github.com/nerfstudio-project/gsplat)のラスタライズバックエンドを基に構築された、高性能な3DガウシアンスプラッティングのC++およびCUDA実装です。

## ニュース
- **[2025-06-10]**: いくつかの問題を修正しました。gsplatの指標との差を縮めていますが、まだ小さな不一致があります。
- **[2025-06-04]**: 最大ガウシアン数を制御する `--max-cap` コマンドラインオプション付きのMCMC戦略を追加しました。
- **[2025-06-03]**: Gsplatバックエンドに切り替え、ライセンスを更新しました。
- **[2024-05-27]**: 互換性とパフォーマンス向上のためLibTorch 2.7.0に更新。オプティマイザの状態管理に関する破壊的変更に対応しました。
- **[2024-05-26]**: このリポジトリの現目標は寛容なライセンスへの移行です。ラスタライザをgsplat実装に置き換える大規模な作業を行いました。

## 指標
現在の実装はgsplat-mcmcと同等の結果は出ていませんが、進行中の作業です。  
バグ修正は時間の問題です。ご協力歓迎します :)  
MCMC戦略の指標は以下の通りです：

| シーン    | イテレーション | PSNR          | SSIM         | LPIPS        | 画像あたり時間 | ガウシアン数 |
| -------- | --------- | ------------- | ------------ | ------------ | -------------- | ------------- |
| garden   | 30000     | 27.112114     | 0.854833     | 0.157624     | 0.304765       | 1000000       |
| bicycle  | 30000     | 25.047745     | 0.767729     | 0.254825     | 0.293618       | 1000000       |
| stump    | 30000     | 26.554749     | 0.784203     | 0.263013     | 0.296536       | 1000000       |
| bonsai   | 30000     | 32.534199     | 0.948675     | 0.246924     | 0.436188       | 1000000       |
| counter  | 30000     | 29.187017     | 0.915823     | 0.242159     | 0.441259       | 1000000       |
| kitchen  | 30000     | 31.680832     | 0.933897     | 0.154965     | 0.449078       | 1000000       |
| room     | 30000     | 32.211632     | 0.930754     | 0.273719     | 0.413519       | 1000000       |
| **平均** | **30000** | **29.189755** | **0.876559** | **0.227604** | **0.376423**   | **1000000**   |

## コミュニティとサポート

議論、サポート、最新情報のために成長中のコミュニティに参加しましょう：  
- 💬 **[Discordコミュニティ](https://discord.gg/TbxJST2BbC)** - ヘルプ、結果共有、開発議論  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - 追加リソースがある公式サイト  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - 包括的な論文リストとリソース  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - 最新情報をフォロー

## ビルドと実行手順

### ソフトウェア要件
1. **Linux**（Ubuntu 22.04でテスト済み） - Windowsは現在非対応
2. **CMake** 3.24以上
3. **CUDA** 11.8以上（手動設定で下位バージョンも動作可能な場合あり）
4. **Python** 開発ヘッダー付き
5. **LibTorch 2.7.0** - セットアップ手順は下記参照
6. その他依存関係はCMakeが自動処理

### ハードウェア要件
1. **CUDA対応NVIDIA GPU**  
    - 成功テスト済み：RTX 4090, RTX A5000, RTX 3090Ti, A100  
    - RTX 3080Tiでは大規模データセットで問題あり（#21参照）
2. 最低コンピュートキャパビリティ：8.0

> 他のハードウェアで成功した場合は、ぜひDiscussionsで体験を共有してください！

### ビルド手順

```bash
# サブモジュール付きでリポジトリをクローン
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# LibTorchのダウンロードとセットアップ
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# プロジェクトのビルド
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

本プロジェクトは最適なパフォーマンスと互換性のために **LibTorch 2.7.0** を使用しています：

- **パフォーマンス向上**：最適化とメモリ管理の改善  
- **API安定性**：最新の安定版PyTorch C++ API  
- **CUDA互換性**：CUDA 11.8以降との統合強化  
- **バグ修正**：オプティマイザ状態管理の問題を解決

### 旧バージョンからのアップグレード方法
1. ビルド手順に従い新しいLibTorchをダウンロード  
2. ビルドディレクトリをクリーン：`rm -rf build/`  
3. プロジェクトを再ビルド

## データセット

元リポジトリからデータセットをダウンロードしてください：  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

プロジェクトルートの `data` フォルダに解凍してください。

## コマンドラインオプション

### 基本オプション

- **`-h, --help`**  
  ヘルプメニューを表示

- **`-d, --data-path [PATH]`**  
  学習データのパス（必須）

- **`-o, --output-path [PATH]`**  
  学習済みモデルの保存先（デフォルト: `./output`）

- **`-i, --iter [NUM]`**  
  学習イテレーション回数（デフォルト: 30000）  
    - 論文では30k推奨だが、6k〜7kでも良好な予備結果が得られることが多い  
    - 7kごとと完了時に出力を保存

- **`-f, --force`**  
  既存の出力フォルダを強制上書き

- **`-r, --resolution [NUM]`**  
  学習画像の解像度設定

### MCMC特有のオプション

- **`--max-cap [NUM]`**  
  MCMC戦略での最大ガウシアン数（デフォルト: 1000000）  
    - 学習中のガウシアンスプラットの上限を制御  
    - メモリ制約環境で有用

### 使用例

基本学習：
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000
```

制限付きガウシアンでのMCMC学習：
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000 --max-cap 500000
```

## 貢献ガイドライン

貢献を歓迎します！始め方は以下の通り：

1. **始めるには**  
    - 初心者向けタスクは **good first issues** ラベルの付いたIssueを確認  
    - 新しいアイデアはディスカッションを開くか、[Discord](https://discord.gg/TbxJST2BbC)に参加

2. **PR提出前に**  
    - 一貫したコードスタイルのため `clang-format` を適用  
    - プレコミットフックを使用：`cp tools/pre-commit .git/hooks/`  
    - 新しい依存関係はまずIssueで相談 - 依存を最小限に抑える方針

## 謝辞

本実装は以下の主要プロジェクトに基づいています：

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**：高度に最適化されたCUDAラスタライズバックエンドを使用し、大幅な性能向上とメモリ効率を実現。
- **オリジナルの3Dガウシアンスプラッティング**：Kerblらによる画期的な研究に基づく。

## 引用

本ソフトウェアを研究に使用する場合は、以下を引用してください：

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## ライセンス

詳細は LICENSE ファイルを参照してください。

---

**つながりましょう：**  
- 🌐 ウェブサイト: [mrnerf.com](https://mrnerf.com)  
- 📚 論文一覧: [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord: [コミュニティに参加](https://discord.gg/TbxJST2BbC)  
- 🐦 Twitter: [@janusch_patas](https://twitter.com/janusch_patas) で開発アップデートをフォロー

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---