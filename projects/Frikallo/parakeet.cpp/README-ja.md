# parakeet.cpp

NVIDIAの[Parakeet](https://huggingface.co/collections/nvidia/parakeet)モデルを使った純粋なC++による高速音声認識。

軽量なテンソルライブラリで自動Metal GPUアクセラレーションを備えた[axiom](https://github.com/frikallo/axiom)上に構築。ONNXランタイムなし、Pythonランタイムなし、重い依存関係なし。C++とPyTorch MPSを凌駕する1つのテンソルライブラリのみ。

**Apple Silicon GPUで10秒音声（110Mモデル）に対して約27msのエンコーダ推論** — CPUより96倍高速。FP16対応でメモリ使用量を約半分に削減。

## 対応モデル

| モデル | クラス | サイズ | 種類 | 説明 |
|-------|-------|------|------|-------------|
| `tdt-ctc-110m` | `ParakeetTDTCTC` | 110M | オフライン | 英語、デュアルCTC/TDTデコーダヘッド |
| `tdt-600m` | `ParakeetTDT` | 600M | オフライン | 多言語、TDTデコーダ |
| `eou-120m` | `ParakeetEOU` | 120M | ストリーミング | 英語、発話終了検出付きRNNT |
| `nemotron-600m` | `ParakeetNemotron` | 600M | ストリーミング | 多言語、遅延設定可能（80ms–1120ms） |
| `sortformer` | `Sortformer` | 117M | ストリーミング | 話者分離（最大4人） |
| `diarized` | `DiarizedTranscriber` | 110M+117M | オフライン | ASR＋話者分離 → 話者属性付き単語 |

すべてのASRモデルは共通の音声パイプラインを使用：16kHzモノラルWAV → 80ビンメルスペクトログラム → FastConformerエンコーダ。

## クイックスタート

```cpp
#include <parakeet/parakeet.hpp>

parakeet::Transcriber t("model.safetensors", "vocab.txt");
t.to_gpu();   // optional — Metal acceleration
t.to_half();  // optional — FP16 inference (~2x memory reduction)

auto result = t.transcribe("audio.wav");
std::cout << result.text << std::endl;
```
## 特徴

- **複数のデコーダー** — CTCグリーディ、TDTグリーディ、CTCビームサーチ、TDTビームサーチ（呼び出し元で切り替え可能）
- **単語ごとのタイムスタンプ** — すべてのデコーダーで単語ごとの開始/終了時間と信頼度スコア
- **ビームサーチ＋LM** — オプションのARPA n-gram言語モデル融合によるCTCおよびTDTビームサーチ
- **フレーズブースティング** — ドメイン固有語彙のためのトークンレベルトライによるコンテキストバイアス
- **バッチ転写** — 複数ファイルを1回のエンコーダ前方伝播で処理
- **VAD前処理** — Silero VADによりASR前に無音を除去；タイムスタンプは自動再マッピング
- **GPUアクセラレーション** — axiomのMPSGraphコンパイラを用いたMetal対応（Apple Siliconで96倍高速化）
- **FP16推論** — 半精度の重みと計算（メモリ使用量約2分の1）
- **ストリーミング** — チャンク化された音声入力対応のEOUおよびNemotronモデル
- **話者分離** — Sortformer（最大4人の話者対応）、ASRと組み合わせて話者付き単語を生成
- **C API** — Python、Swift、Go、Rustなど向けのフラットな`extern "C"` FFI
- **多形式音声対応** — WAV、FLAC、MP3、OGGを自動リサンプリング付きで対応

各機能のコード例は[examples/](examples/)を参照してください。

## インストール

macOS arm64、macOS x86_64、Linux x86_64向けの事前ビルドバイナリは各[GitHubリリース](https://github.com/Frikallo/parakeet.cpp/releases)に添付されています。お使いのプラットフォーム用のtarballをダウンロードして展開してください：


```bash
tar -xzf parakeet-v0.1.0-macos-arm64.tar.gz
cd parakeet-v0.1.0-macos-arm64
# On macOS, clear the Gatekeeper quarantine attribute first:
xattr -dr com.apple.quarantine .
./bin/parakeet --help
```

アーカイブには自己完結型の `bin/parakeet`（および `bin/example-server`）と `lib/libaxiom` が含まれており、`@rpath`/`$ORIGIN` が設定されているため、バイナリはインストールディレクトリを基準に依存関係を解決します — 任意のディレクトリに配置可能です。埋め込み用の C-API ヘッダーは `include/parakeet/` に含まれています。

## ソースからのビルド

```bash
git clone --recursive https://github.com/frikallo/parakeet.cpp
cd parakeet.cpp
make build
make test
```

要件: C++20 (Clang 14以上またはGCC 12以上)、CMake 3.20以上、Metal GPU用のmacOS 13以上。

> **macOS:** ビルドには**フルXcode**のインストールが必要です（Command Line Toolsだけではありません）。axiomはMetalシェーダーを`xcrun metal`と`xcrun metallib`でコンパイルしますが、これらはXcodeにのみ付属しています。parakeetを実行したいだけなら、上記のプリビルドtarballを使用してください。`.metallib`は同梱の`libaxiom.dylib`に組み込まれており、ユーザー側でXcode/CLTのインストールなしで動作します。

## 重みの変換

```bash
# Download from HuggingFace
huggingface-cli download nvidia/parakeet-tdt_ctc-110m --include "*.nemo" --local-dir .

# Convert to safetensors
pip install safetensors torch
python scripts/convert_nemo.py parakeet-tdt_ctc-110m.nemo -o model.safetensors
```
コンバーターはすべてのモデルタイプをサポートしています：`110m-tdt-ctc`（デフォルト）、`600m-tdt`、`eou-120m`、`nemotron-600m`、`sortformer`。


```bash
python scripts/convert_nemo.py checkpoint.nemo -o model.safetensors --model 600m-tdt
```
Silero VADの重み：

```bash
python scripts/convert_silero_vad.py -o silero_vad_v5.safetensors
```

## 例

| 例 | 説明 |
|---------|-------------|
| [basic](examples/basic/) | 最も簡単な書き起こし（約20行） |
| [timestamps](examples/timestamps/) | 単語／トークンのタイムスタンプと信頼度 |
| [beam-search](examples/beam-search/) | CTC/TDT ビームサーチ（オプションでARPA LM付き） |
| [phrase-boost](examples/phrase-boost/) | ドメイン語彙のコンテキストバイアス |
| [batch](examples/batch/) | 複数ファイルのバッチ書き起こし |
| [vad](examples/vad/) | 単独VADおよびASR+VAD前処理 |
| [gpu](examples/gpu/) | Metal GPU + FP16 とタイミング比較 |
| [stream](examples/stream/) | EOU ストリーミング書き起こし |
| [nemotron](examples/nemotron/) | レイテンシモード付きNemotronストリーミング |
| [diarize](examples/diarize/) | Sortformer スピーカーダイアリゼーション |
| [diarized-transcription](examples/diarized-transcription/) | ASR + ダイアリゼーションの組み合わせ |
| [c-api](examples/c-api/) | 純粋なC99 FFIの使用方法 |
| [cli](examples/cli/) | すべてのオプションを備えた完全CLI |

## ライブラリとしての使用

### CMakeの `find_package`

インストール後（`make install` または `cmake --install build`）：

```cmake
find_package(Parakeet REQUIRED)
target_link_libraries(myapp PRIVATE Parakeet::parakeet)
```

### CMake の `add_subdirectory`

```cmake
add_subdirectory(third_party/parakeet.cpp)
target_link_libraries(myapp PRIVATE Parakeet::parakeet)
```

### pkg-config

```bash
g++ -std=c++20 myapp.cpp $(pkg-config --cflags --libs parakeet) -o myapp
```
## アーキテクチャ

### オフラインモデル

共有のFastConformerエンコーダ（Conv2d 8倍サブサンプリング → 相対位置注意付きN個のConformerブロック）上に構築：

| モデル | クラス | デコーダ | 用途 |
|-------|-------|---------|----------|
| CTC | `ParakeetCTC` | 貪欲argmaxまたはビームサーチ（＋LM） | 高速、英語専用 |
| RNNT | `ParakeetRNNT` | オートレグレッシブLSTM | ストリーミング対応 |
| TDT | `ParakeetTDT` | LSTM＋持続時間予測、貪欲またはビームサーチ（＋LM） | RNNTより高精度 |
| TDT-CTC | `ParakeetTDTCTC` | TDTとCTCの両方のヘッド | 推論時にデコーダ切替 |

### ストリーミングモデル

因果畳み込みと境界付きコンテキスト注意を備えたキャッシュ対応ストリーミングFastConformerエンコーダ上に構築：

| モデル | クラス | デコーダ | 用途 |
|-------|-------|---------|----------|
| EOU | `ParakeetEOU` | ストリーミングRNNT | 発話終了検出 |
| Nemotron | `ParakeetNemotron` | ストリーミングTDT | 遅延設定可能なストリーミング |

### 発話者分離

| モデル | クラス | アーキテクチャ | 用途 |
|-------|-------|-------------|----------|
| Sortformer | `Sortformer` | NESTエンコーダ → トランスフォーマー → シグモイド | 発話者分離（最大4人） |

## ベンチマーク

Apple M3 16GB上でシミュレート音声入力（`Tensor::randn`）を用いて測定。時間はエンコーダ1回のフォワードパスあたり（Sortformerは全フォワードパス）。

**エンコーダスループット — 10秒音声：**

| モデル | パラメータ数 | CPU（ms） | GPU（ms） | GPU速度向上率 |
|-------|--------|----------|----------|-------------|
| 110m (TDT-CTC) | 110M | 2,581 | 27 | **96倍** |
| tdt-600m | 600M | 10,779 | 520 | **21倍** |
| rnnt-600m | 600M | 10,648 | 1,468 | **7倍** |

| sortformer | 117M | 3,195 | 479 | **7x** |

**110m GPUによるオーディオ長さごとのスケーリング：**

| Audio | CPU (ms) | GPU (ms) | RTF | スループット |
|-------|----------|----------|-----|------------|
| 1秒 | 262 | 24 | 0.024 | 41x |
| 5秒 | 1,222 | 26 | 0.005 | 190x |
| 10秒 | 2,581 | 27 | 0.003 | 370x |
| 30秒 | 10,061 | 32 | 0.001 | 935x |
| 60秒 | 26,559 | 72 | 0.001 | 833x |

GPUアクセラレーションはaxiomのMetalグラフコンパイラによって実現されており、エンコーダ全体を最適化されたMPSGraph操作に融合しています。

```bash
make bench ARGS="--110m=models/model.safetensors --tdt-600m=models/tdt.safetensors"
```
## ロードマップ

### ティア 1 — 高インパクト

- [x] **信頼度スコア** — トークンのログ確率からトークン単位および単語単位の信頼度
- [x] **フレーズブースティング** — デコード時のトークンレベルトライ文脈バイアス
- [x] **ビームサーチ** — CTCプレフィックスビームサーチとTDT時間同期ビームサーチ
- [x] **N-gram言語モデル融合** — 単語境界でスコアリングされるARPA言語モデル

### オーディオ & 入出力

- [x] **マルチフォーマットオーディオ** — dr_libs + stb_vorbis経由のWAV、FLAC、MP3、OGG対応
- [x] **自動リサンプリング** — 窓関数付きシンク補間（カイザー、16タップ）
- [x] **メモリからの読み込み** — `read_audio(bytes, len)`、float/int16バッファ対応
- [ ] **オーディオ再生時間のクエリ** — フルデコードなしのヘッダーのみの再生時間取得
- [ ] **進捗コールバック** — 長時間ファイル向けのステージ報告
- [ ] **生PCMからのストリーミング** — マイクロフォンバッファの直接供給

### ティア 2 — 本番対応

- [x] **話者分離転写** — ASR + Sortformer → 話者属性付き単語
- [x] **VAD** — Silero VAD v5、スタンドアロン＋ASR前処理
- [x] **バッチ推論** — パディングされた複数ファイルエンコーダ前向き処理
- [ ] **長時間チャンク処理** — 30秒超オーディオの重複ウィンドウ処理
- [ ] **ニューラル言語モデル再スコアリング** — トランスフォーマーLMによるNベスト再ランキング

### ティア 3 — エコシステム

- [x] **C API** — 任意の言語からのFFI用フラットCインターフェース
- [x] **FP16推論** — 半精度の重みと計算
- [ ] **モデル量子化** — モバイル展開用INT8/INT4
- [ ] **ホットワード検出** — トリガーフレーズ検出
- [ ] **話者埋め込み** — Sortformer/TitaNetによる話者検証

## 注意事項

- オーディオ: 16kHzモノラル（WAV、FLAC、MP3、OGG — 自動検出およびリサンプリング対応）
- オフラインモデルは約4～5分の音声長制限あり；長時間音声はストリーミングモデルを使用
- GPUアクセラレーションはMetal対応のApple Siliconが必要


## License

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-20

---