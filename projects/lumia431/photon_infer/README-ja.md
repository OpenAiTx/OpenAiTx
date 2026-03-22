# PhotonInfer

<div align="center">

**vLLMスタイルの連続バッチ処理を備えた高性能LLM推論エンジン**

[English](https://raw.githubusercontent.com/lumia431/photon_infer/master/README.md) | [中文](https://raw.githubusercontent.com/lumia431/photon_infer/master/README_ZH.md) | [ライブデモ](https://photoninfer.xyz/)

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![CUDA](https://img.shields.io/badge/CUDA-12.0+-green.svg)](https://developer.nvidia.com/cuda-toolkit)
[![C++20](https://img.shields.io/badge/C++-20-orange.svg)](https://en.cppreference.com/w/cpp/20)

</div>

---

## 🚀 パフォーマンスハイライト

PhotonInferは、高度なバッチ処理機能を備えたLLMの**商用グレード推論性能**を提供します。**Llama-3.2およびQwen3モデルに対応**。

### 単一リクエスト推論

| モデル | PhotonInfer | llama.cpp | スピードアップ |
|-------|-------------|-----------|--------------|
| Llama 3.2 1B | 185 tok/s | 252 tok/s | 0.73×（llama.cppが高速） |

**TTFT（最初のトークン生成時間）**: 387ms @ 100トークンプラ​​ンプト（INT8量子化）

### バッチ推論スループット

| バッチサイズ | PhotonInfer | llama.cpp | スピードアップ |
|------------|-------------|-----------|--------------|
| 4          | 410 tok/s   | 252 tok/s | **1.63×** |
| 8          | 720 tok/s   | 255 tok/s | **2.82×** |
| 16         | 787 tok/s   | 253 tok/s | **3.07×** |

**テスト環境**: NVIDIA A100, Llama 3.2 1B, Q8/INT8量子化

## ✨ 主な特徴

### 🎯 **vLLMスタイルの連続バッチ処理**
- **トークンレベルの動的スケジューリング**: バッチ完了を待たずに生成途中で新規リクエストを追加可能
- **二段階スケジューラ**: 新規リクエストを受け入れつつ継続的に実行を維持
- **リクエスト状態追跡**: 効率的な再開のための正確な `num_computed_tokens` 管理
- **本番環境に最適**: リアルタイム応答性を備えた高並行推論サービス

### ⚡ **GPU最適化カーネル**
- **バッチ化されたページドアテンション**: 効率的なメモリ利用のためのブロックレベルKVキャッシュ管理
- **ベクトル化メモリアクセス**: 2〜4倍の帯域幅効率を実現する `float4` ロード
- **融合オペレーション**: ゼロコピーGPUサンプリング、バッチ化RoPE、融合正規化
- **INT8量子化**: cuBLASLt INT8 GEMM対応のグループ単位量子化
- **最適化ソフトマックス**: 数値的に安定したアテンション計算のためのCUB BlockReduce

### 🏗️ **モダンC++20アーキテクチャ**
- **型安全なエラーハンドリング**: 明示的なエラー伝播のためのRust風 `Result<T, E>` 型
- **ゼロコピー設計**: `std::span` とムーブセマンティクスの多用
- **デバイス非依存**: CPUおよびCUDAバックエンドの統一インターフェース
- **コンセプト＆レンジ**: コンパイル時制約と表現力豊かな型安全性

## 🚀 クイックスタート

### 前提条件

- **コンパイラ**: GCC 12以上（C++20サポート必須）
- **CMake**: 3.20以上
- **CUDAツールキット**: 12.0以上（12.5で動作確認済み）
- **GPU**: Compute Capability 7.0以上のNVIDIA GPU

### モデルのダウンロード

すぐに始められる事前量子化モデルをダウンロード：

https://huggingface.co/Lummy666/llama-3.2-1B-Instruct

### ビルド

#### オプション1: ソースからビルド

```bash
# Clone repository
cd photon_infer

# Configure with CUDA
mkdir build && cd build
cmake -DCMAKE_BUILD_TYPE=Release -DPHOTON_BUILD_CUDA=ON ..

# Build
cmake --build . -j$(nproc)

# Install (optional)
sudo cmake --install .
```
インストール後は、どこからでも直接ウェブサーバーを実行できます：


```bash
photon_web_server \
    --port 5728 \
    --model /path/to/llama-3.2-1B-Instruct \
    --tokenizer /path/to/llama-3.2-1B-Instruct/tokenizer.json
```
インストールは以下の場所に配置されます：
- `photon_web_server` → `/usr/local/bin/`
- 静的ウェブファイル → `/photon_infer/web/static/`
- コアライブラリ → `/usr/local/lib/`

アンインストールするには：

```bash
cd build
sudo cmake --build . --target uninstall
```

#### オプション 2: Docker を使用する（推奨）

```bash
# Pull the pre-built Docker image
docker pull lumia431/photon_infer:latest

# Run the container with GPU support
docker run --rm --gpus all -p 5728:5728 -e PORT=5728 lumia431/photon_infer:latest
```
ウェブインターフェースは `http://localhost:5728` で利用可能です

## 🔬 技術詳細

### INT8 量子化
- **グループ単位の量子化**：グループサイズ（32、64、128）を設定可能
- **cuBLASLt 統合**：ハードウェアアクセラレーションによる INT8 GEMM
- **最小限の精度損失**：Llamaモデルでのパープレキシティ低下が1%未満

### ページドアテンション
- **ブロックレベルのKVキャッシュ**：断片化のない効率的なメモリ割り当て
- **動的シーケンス管理**：シーケンスごとのキャッシュオフセットによる柔軟なスケジューリング
- **バッチ処理キャッシュ操作**：複数シーケンスのK/V書き込みを単一カーネルで実行

### 連続バッチスケジューラ
- **二段階スケジューリング**：
  1. **フェーズ1**：すべてのRUNNINGリクエストを継続（中断なし）
  2. **フェーズ2**：残りの容量を埋めるためにWAITINGリクエストを受け入れ
- **リクエスト状態**：WAITING → RUNNING → FINISHED（PREEMPTED対応あり）
- **トークン単位の粒度**：正確な再開のための `num_computed_tokens` トラッキング

## 🛣️ ロードマップ

- [x] **コアインフラ**：テンソル、演算子、メモリ管理
- [x] **LLaMAモデル**：CPU/GPUカーネルを備えた完全なトランスフォーマー実装
- [x] **INT8量子化**：cuBLASLtによるグループ単位量子化
- [x] **ページドアテンション**：ブロックレベルのKVキャッシュ管理
- [x] **連続バッチ処理**：vLLMスタイルの動的リクエストスケジューリング
- [ ] **Flash Attention 2**：長いシーケンス向けのIO対応アテンション
- [ ] **マルチGPU対応**：大規模モデル向けのテンソル並列処理
- [ ] **FP16/BF16混合精度**：最新GPUでのスループット向上
- [ ] **スペキュレーティブデコーディング**：ドラフトモデルによるマルチトークン生成

## 📖 ドキュメント

- [連続バッチ処理設計](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/continuous_batching.md)
- [パフォーマンス最適化ガイド](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/performance.md)
- [APIリファレンス](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/api.md)


## 🤝 貢献について

貢献を歓迎します！ガイドラインは[CONTRIBUTING.md](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/contributing.md)をご覧ください。

## 📝 ライセンス

MITライセンス - 詳細は[LICENSE](LICENSE)をご覧ください。

## 🙏 謝辞

- アーキテクチャは[vLLM](https://github.com/vllm-project/vllm)に着想を得ています
- カーネル最適化は[llama.cpp](https://github.com/ggerganov/llama.cpp)を参考にしています
- エラー処理の設計はRustの`Result<T, E>`から採用しています

---

**高性能なLLM推論のために❤️を込めて作られました**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-22

---