<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/Narsil/tgi_assets/thumbnail.png">
</a>

# テキスト生成推論

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API documentation" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

Rust、Python、gRPCサーバーによるテキスト生成推論。  
[Hugging Face](https://huggingface.co)の本番環境で使用されており、Hugging Chat、Inference API、Inference Endpointsを支えています。

</div>

## 目次

  - [はじめに](#get-started)
    - [Docker](#docker)
    - [APIドキュメント](#api-documentation)
    - [プライベートまたはゲートモデルの使用](#using-a-private-or-gated-model)
    - [共有メモリ（shm）について](#a-note-on-shared-memory-shm)
    - [分散トレーシング](#distributed-tracing)
    - [アーキテクチャ](#architecture)
    - [ローカルインストール](#local-install)
    - [ローカルインストール（Nix）](#local-install-nix)
  - [最適化アーキテクチャ](#optimized-architectures)
  - [ローカルでの実行](#run-locally)
    - [実行](#run)
    - [量子化](#quantization)
  - [開発](#develop)
  - [テスト](#testing)

Text Generation Inference (TGI) は、大規模言語モデル（LLM）の展開と提供のためのツールキットです。TGIは、Llama、Falcon、StarCoder、BLOOM、GPT-NeoXなどの最も人気のあるオープンソースLLMで高性能なテキスト生成を可能にします。TGIは以下の多くの機能を実装しています：

- 人気のLLMを簡単に起動可能なランチャー
- 本番環境対応（OpenTelemetryによる分散トレーシング、Prometheusメトリクス）
- 複数GPUでの高速推論のためのテンソル並列処理
- Server-Sent Events (SSE)を用いたトークンストリーミング
- 総スループット向上のためのリクエストの継続的バッチ処理
- Open AI Chat Completion API互換の[Messages API](https://huggingface.co/docs/text-generation-inference/en/messages_api)
- [Flash Attention](https://github.com/HazyResearch/flash-attention)および[Paged Attention](https://github.com/vllm-project/vllm)を用いた最適化されたトランスフォーマー推論コード
- 以下の量子化サポート：
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- [Safetensors](https://github.com/huggingface/safetensors)による重みのロード
- [A Watermark for Large Language Models](https://arxiv.org/abs/2301.10226)を用いたウォーターマーキング
- ロジットワーパー（温度スケーリング、top-p、top-k、繰り返しペナルティなど、詳細は[transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor)参照）
- 停止シーケンス
- 対数確率
- [Speculation](https://huggingface.co/docs/text-generation-inference/conceptual/speculation)（約2倍のレイテンシ削減）
- [Guidance/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance)。出力フォーマットを指定して推論速度を向上させ、出力が仕様に準拠することを保証
- カスタムプロンプト生成：モデルの出力を誘導するカスタムプロンプトを簡単に生成
- ファインチューニング対応：特定タスク向けにファインチューニングされたモデルを利用し、高精度・高性能を実現

### ハードウェアサポート

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)（-rocm）
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [Intel GPU](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## はじめに

### Docker

詳細な開始ガイドは[クイックツアー](https://huggingface.co/docs/text-generation-inference/quicktour)をご覧ください。  
最も簡単な始め方は、公式のDockerコンテナを使用することです：

```shell
model=HuggingFaceH4/zephyr-7b-beta
# Dockerコンテナとボリュームを共有して、毎回の重みのダウンロードを避ける
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

その後、以下のようにリクエストを送ることができます：

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"What is Deep Learning?","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

また、[TGIのMessages API](https://huggingface.co/docs/text-generation-inference/en/messages_api)を使ってOpen AI Chat Completion API互換のレスポンスを取得することも可能です。

```bash
curl localhost:8080/v1/chat/completions \
    -X POST \
    -d '{
  "model": "tgi",
  "messages": [
    {
      "role": "system",
      "content": "You are a helpful assistant."
    },
    {
      "role": "user",
      "content": "What is deep learning?"
    }
  ],
  "stream": true,
  "max_tokens": 20
}' \
    -H 'Content-Type: application/json'
```

**注意：** NVIDIA GPUを使用するには、[NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html)のインストールが必要です。CUDAバージョン12.2以上のNVIDIAドライバーの使用を推奨します。GPUやCUDAを持たないマシンでDockerコンテナを実行する場合は、`--gpus all`フラグを削除し、`--disable-custom-kernels`を追加してください。ただし、このプロジェクトはCPUを想定していないため、パフォーマンスは劣る可能性があります。

**注意：** TGIはAMD Instinct MI210およびMI250 GPUをサポートしています。詳細は[対応ハードウェアのドキュメント](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus)をご覧ください。AMD GPUを使う場合は、上記コマンドの代わりに以下を使用してください：

```shell
docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model
```

モデルを提供するためのすべてのオプションは（[コード](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs)やCLIで）以下で確認できます：

```
text-generation-launcher --help
```

### APIドキュメント

`text-generation-inference` REST APIのOpenAPIドキュメントは`/docs`ルートから参照可能です。  
Swagger UIは以下でも利用できます：  
[https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference).

### プライベートまたはゲートモデルの使用

`text-generation-inference`で使用するトークンを設定するために`HF_TOKEN`環境変数を利用可能です。これにより保護されたリソースにアクセスできます。

例えば、ゲート付きのLlama V2モデルバリアントを提供する場合：

1. https://huggingface.co/settings/tokens にアクセス
2. CLI READトークンをコピー
3. `HF_TOKEN=<your CLI READ token>` をエクスポート

またはDockerで：

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # Dockerコンテナとボリュームを共有して、毎回の重みのダウンロードを避ける
token=<your cli READ token>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### 共有メモリ（shm）について

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html)は`PyTorch`が分散トレーニング／推論で使用する通信フレームワークです。  
`text-generation-inference`は大規模言語モデルの推論を劇的に高速化するためにテンソル並列処理を有効にするために`NCCL`を利用しています。

`NCCL`グループ内の異なるデバイス間でデータを共有する際、NVLinkやPCIを用いたピアツーピア通信が不可能な場合、ホストメモリを利用することがあります。

コンテナが1GBの共有メモリを使い、SHM共有をサポートするために、上記コマンドに`--shm-size 1g`を追加しています。

`text-generation-inference`を`Kubernetes`内で動かす場合は、以下のようにボリュームを作成して共有メモリを追加できます：

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

これを`/dev/shm`にマウントしてください。

また、`NCCL_SHM_DISABLE=1`環境変数を使ってSHM共有を無効化することもできますが、パフォーマンスに影響があります。

### 分散トレーシング

`text-generation-inference`はOpenTelemetryを用いた分散トレーシングに対応しています。  
`--otlp-endpoint`引数でOTLPコレクターのアドレスを設定することで利用可能です。  
デフォルトのサービス名は`--otlp-service-name`引数で上書きできます。

### アーキテクチャ

![TGI architecture](https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/huggingface/documentation-images/TGI.png)

AdyenによるTGIの内部動作に関する詳細なブログ記事：  
[LLM inference at scale with TGI (Martin Iglesias Goyanes - Adyen, 2024)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### ローカルインストール

`text-generation-inference`をローカルにインストールすることも可能です。

まずリポジトリをクローンし、ディレクトリを移動します：
```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

次に[Rustをインストール](https://rustup.rs/)し、少なくともPython 3.9を使ったPython仮想環境を作成します。例えば`conda`や`python venv`を使用します:

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

# condaを使う場合
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

# python venvを使う場合
python3 -m venv .venv
source .venv/bin/activate
```

また、Protocのインストールが必要になる場合があります。

Linuxの場合:

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

MacOSの場合、Homebrewを使用して:

```shell
brew install protobuf
```

その後、以下を実行してください:

```shell
BUILD_EXTENSIONS=True make install # リポジトリとCUDAカーネルを含むHF/transformersのフォークをインストール
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**注意:** 一部のマシンではOpenSSLライブラリとgccも必要になる場合があります。Linuxマシンでは以下を実行してください:

```shell
sudo apt-get install libssl-dev gcc -y
```

### ローカルインストール（Nix）

別の方法として、[Nix](https://nixos.org)を使用して`text-generation-inference`をローカルにインストールできます。現在のところ、
x86_64 LinuxでCUDA GPUを搭載した環境のみサポートしています。Nixを使う場合、すべての依存関係は
バイナリキャッシュから取得できるため、ローカルでビルドする必要がなくなります。

まず[CachixをインストールしHugging Faceキャッシュを有効化する手順](https://app.cachix.org/cache/huggingface)に従ってください。
キャッシュの設定は重要で、設定しないとNixが多くの依存関係をローカルでビルドするため、数時間かかることがあります。

その後、`nix run`でTGIを実行できます:

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**注意:** NixOS以外のシステムでNixを使用する場合、CUDAドライバライブラリをNixパッケージから見えるようにするために[シンボリックリンクを作成する必要があります](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library)。

TGIの開発には`impure`なdevシェルを利用できます:

```shell
nix develop .#impure

# protobufを更新した後やdevshellを初めて起動する際にのみ必要
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

cargo、Python、Torchなど開発に必要なすべての依存関係がこのdevシェルに含まれています。

## 最適化アーキテクチャ

TGIはすべての最新モデルに対して最適化されたモデルをそのまま提供できます。対応モデルは[こちらのリスト](https://huggingface.co/docs/text-generation-inference/supported_models)で確認できます。

その他のアーキテクチャは以下の方法でベストエフォートでサポートされています:

`AutoModelForCausalLM.from_pretrained(<model>, device_map="auto")`

または

`AutoModelForSeq2SeqLM.from_pretrained(<model>, device_map="auto")`



## ローカルでの実行

### 実行

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### 量子化

事前量子化済みの重み（AWQ、GPTQ、Marlin）を使うか、bitsandbytes、EETQ、fp8を使ってオンザフライで重みを量子化し、VRAMの使用量を削減できます:

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

4bit量子化は[bitsandbytesのNF4およびFP4データタイプ](https://arxiv.org/pdf/2305.14314.pdf)を使用して利用可能です。`text-generation-launcher`に`--quantize bitsandbytes-nf4`または`--quantize bitsandbytes-fp4`をコマンドライン引数として渡すことで有効にできます。

量子化の詳細は[量子化ドキュメント](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization)を参照してください。

## 開発

```shell
make server-dev
make router-dev
```

## テスト

```shell
# python
make python-server-tests
make python-client-tests
# またはサーバーとクライアント両方のテスト
make python-tests
# rust cargoテスト
make rust-tests
# 統合テスト
make integration-tests
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---