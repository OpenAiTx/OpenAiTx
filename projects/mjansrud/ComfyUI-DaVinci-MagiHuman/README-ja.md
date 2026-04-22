Edit: このリポジトリは、モデルで十分に良い結果を生成できなかったためアーカイブされました。現在はLTX2.3を使い続けています。  
引き続き作業を進めていただいて構いません。

Edit: 注意！これはまだ作業中の段階であり、動作を期待しないでください。  
イースター休暇でしばらく離れるため、戻るまで確認できません。  
フォークして作業を続けるか、Kijaiがリリースするバージョンを待ってください。

コードは（現時点では、後で変更予定）必要なテキストエンコーダーとwan vaeをhuggingfaceから自動的にダウンロードします。  
初回実行時は時間がかかることを想定してください。

# ComfyUI-DaVinci-MagiHuman

[daVinci-MagiHuman](https://huggingface.co/GAIR/daVinci-MagiHuman)向けのComfyUIカスタムノード。15Bパラメータの単一ストリームトランスフォーマーによる高速な音声・映像生成用。消費者向けGPU（RTX 5090 32GB）に最適化。

## 特徴

- **ブロック単位のCPU/GPUスワッピング** — 40層のトランスフォーマーのうちGPU上は8層のみ（約6GB対約30GB）  
- **非同期CUDAプリフェッチ** — 現ブロック計算中に次ブロック転送  
- **蒸留モード** — CFGなし8ステップ生成（最速）  
- **1080p超解像** — 256pベースからの潜在空間アップスケーリング  
- **TurboVAEデコーダ** — 出力オフロード付きスライディングウィンドウデコードで1080p対応  
- **音声＋映像** — 単一ストリームの共同生成

## ノード

| ノード | 説明 |
|------|-------------|
| **DaVinci Model Loader** | `blocks_on_gpu`設定可能な蒸留/ベース/SRモデルのロード |
| **DaVinci TurboVAE Loader** | 高速デコード専用VAEのロード |
| **DaVinci Text Encode** | テキストプロンプトから埋め込みへ（外部T5エンコーダー使用可） |
| **DaVinci Sampler** | ノイズ除去ループ（蒸留8ステップ／ベース32ステップ） |
| **DaVinci Super Resolution** | 256p潜在空間をSRモデルで1080pにアップスケール |
| **DaVinci Decode** | TurboVAEによる潜在空間から映像へのデコード（出力オフロード付き） |
| **DaVinci Video Output** | FFmpeg経由でmp4/webmとして保存 |

## ワークフロー

```
Model Loader (distill, 8 blocks on GPU)
  → Text Encode
    → Sampler (256p, 8 steps)
      → [optional] SR Model Loader (1080p_sr) → Super Resolution
        → TurboVAE Loader → Decode → Video Output
```

## 要件

- **GPU**: RTX 5090（32GB）以上。32GB VRAMの場合、GPU上で8ブロックが動作します。
- **RAM**: 64GB以上推奨（CPUオフロードでは約24GBのモデル重みをシステムRAMに保存します）
- **CUDA**: bf16対応のCUDA対応GPU
- **FFmpeg**: 動画出力に必要
- **Pythonパッケージ**: `safetensors`、`torch`、`numpy`

## モデル設定

[HuggingFace](https://huggingface.co/GAIR/daVinci-MagiHuman)からモデル重みをダウンロードしてください：

```bash
cd ComfyUI/models

# Clone without large files
GIT_LFS_SKIP_SMUDGE=1 git clone https://huggingface.co/GAIR/daVinci-MagiHuman

cd daVinci-MagiHuman

# Pull only what you need (skip 540p_sr if you only want 1080p)
git lfs pull --include="distill/*,turbo_vae/*"        # ~61GB - base generation
git lfs pull --include="1080p_sr/*"                    # ~61GB - 1080p upscaling
```
期待されるディレクトリ構造:

```
ComfyUI/models/daVinci-MagiHuman/
├── distill/          # 8-step distilled model (~61GB)
├── 1080p_sr/         # Super-resolution model (~61GB)
├── turbo_vae/        # Fast decoder (small)
├── base/             # Full 32-step model (optional, ~30GB)
└── 540p_sr/          # 540p SR (optional, ~61GB)
```
## VRAM ガイド

| `blocks_on_gpu` | VRAM 使用量 | 速度 | 推奨用途 |
|-----------------|-----------|-------|-----------------|
| 4 | 約3GB + オーバーヘッド | 最遅 | 16GB GPU |
| 8 | 約6GB + オーバーヘッド | 良好 | 24-32GB GPU |
| 16 | 約12GB + オーバーヘッド | 高速 | 48GB GPU |
| 40 | 約30GB | 最速 | 80GB以上のGPU |

## テキストエンコーダー

daVinci-MagiHuman は T5Gemma-9B をテキストエンコーダーとして使用します。**DaVinci Text Encode** ノードは現在以下を提供しています：

- **プレースホルダー埋め込み**（パイプラインのテスト用、ランダムノイズで意味のある出力は生成しません）
- **外部T5入力** — 他のエンコーダーノードから事前計算された T5 埋め込み（3584次元）を接続可能

実運用では、T5-XXL または T5Gemma エンコーダーノードを `t5_embeds` 入力に接続してください。

## アーキテクチャ

モデルは映像と音声を同時に生成するシングルストリームトランスフォーマーです：

- **15B パラメータ**, 40 トランスフォーマーレイヤー
- **隠れ層サイズ**：5120、**GQA**：40 クエリ / 8 KV ヘッド、**ヘッド次元**：128
- **サンドイッチレイヤー**：0-3 と 36-39 はモダリティごとの正規化（映像/音声/テキスト）
- **共有レイヤー**：4-35 は統一処理を使用
- **タイムステップなし**：明示的なタイムステップ埋め込みなし — 入力からノイズ除去状態を推定
- **ヘッドごとのゲーティング**：各アテンションヘッドに学習されたシグモイドゲート

## クレジット

- [daVinci-MagiHuman](https://huggingface.co/GAIR/daVinci-MagiHuman) by SII-GAIR & Sand.ai
- [MagiCompiler](https://github.com/SandAI-org/MagiCompiler) によるオペレーターフュージョン
- Wan2.2 と TurboVAED をベースに構築

## ライセンス

Apache 2.0



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---