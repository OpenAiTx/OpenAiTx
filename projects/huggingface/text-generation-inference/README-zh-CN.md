<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/Narsil/tgi_assets/resolve/main/thumbnail.png">
</a>

# 文本生成推理

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API documentation" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

一个用于文本生成推理的 Rust、Python 和 gRPC 服务器。现已在 [Hugging Face](https://huggingface.co) 生产环境中使用，
为 Hugging Chat、Inference API 和 Inference Endpoints 提供支持。

</div>

## 目录

  - [快速开始](#get-started)
    - [Docker](#docker)
    - [API 文档](#api-documentation)
    - [使用私有或受限模型](#using-a-private-or-gated-model)
    - [关于共享内存（shm）](#a-note-on-shared-memory-shm)
    - [分布式追踪](#distributed-tracing)
    - [架构](#architecture)
    - [本地安装](#local-install)
    - [本地安装（Nix）](#local-install-nix)
  - [优化架构](#optimized-architectures)
  - [本地运行](#run-locally)
    - [运行](#run)
    - [量化](#quantization)
  - [开发](#develop)
  - [测试](#testing)

文本生成推理（TGI）是一个用于部署和服务大型语言模型（LLM）的工具包。TGI 支持最流行的开源 LLM，如 Llama、Falcon、StarCoder、BLOOM、GPT-NeoX 等等，[更多](https://huggingface.co/docs/text-generation-inference/supported_models)。TGI 实现了许多功能，包括：

- 简单的启动器，用于服务大多数流行的 LLM
- 生产就绪（支持 Open Telemetry 分布式追踪，Prometheus 指标）
- 多 GPU 上的张量并行加速推理
- 使用服务器发送事件（SSE）的令牌流式传输
- 连续批处理请求以提升总吞吐量
- 兼容 Open AI 聊天补全 API 的 [消息 API](https://huggingface.co/docs/text-generation-inference/en/messages_api)
- 通过 [Flash Attention](https://github.com/HazyResearch/flash-attention) 和 [Paged Attention](https://github.com/vllm-project/vllm) 优化的变换器推理代码，支持主流架构
- 支持以下量化方案：
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- [Safetensors](https://github.com/huggingface/safetensors) 权重加载
- 结合 [A Watermark for Large Language Models](https://arxiv.org/abs/2301.10226) 的水印功能
- Logits 变换器（温度缩放、top-p、top-k、重复惩罚，详情见 [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor)）
- 停止序列
- 对数概率
- [投机执行](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) 提升约 2 倍延迟
- [指导/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance) ：指定输出格式以加快推理并确保输出符合规范
- 自定义提示生成：通过提供自定义提示轻松生成文本，引导模型输出
- 微调支持：使用微调模型完成特定任务以提升准确率和性能

### 硬件支持

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [Intel GPU](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## 快速开始

### Docker

详细入门指南请参见 [快速导览](https://huggingface.co/docs/text-generation-inference/quicktour)。最简单的启动方式是使用官方 Docker 容器：

```shell
model=HuggingFaceH4/zephyr-7b-beta
# 与 Docker 容器共享卷，避免每次运行都下载权重
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

然后你可以发起请求，例如：

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"什么是深度学习？","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

你也可以使用 [TGI 的消息 API](https://huggingface.co/docs/text-generation-inference/en/messages_api) 获取兼容 Open AI 聊天补全 API 的响应。

```bash
curl localhost:8080/v1/chat/completions \
    -X POST \
    -d '{
  "model": "tgi",
  "messages": [
    {
      "role": "system",
      "content": "你是一个乐于助人的助手。"
    },
    {
      "role": "user",
      "content": "什么是深度学习？"
    }
  ],
  "stream": true,
  "max_tokens": 20
}' \
    -H 'Content-Type: application/json'
```

**注意：** 要使用 NVIDIA GPU，需要安装 [NVIDIA 容器工具包](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html)。我们还建议使用 CUDA 版本 12.2 或更高的 NVIDIA 驱动。若在无 GPU 或无 CUDA 支持的机器上运行 Docker 容器，只需移除 `--gpus all` 标志并添加 `--disable-custom-kernels`，但请注意 CPU 并非本项目的目标平台，性能可能较差。

**注意：** TGI 支持 AMD Instinct MI210 和 MI250 GPU。详情请参见 [支持硬件文档](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus)。使用 AMD GPU 时，请用以下命令替代上述命令：

```shell
docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model
```

查看所有模型服务选项（在[代码](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs)或命令行中）：
```
text-generation-launcher --help
```

### API 文档

你可以通过 `/docs` 路由查看 `text-generation-inference` REST API 的 OpenAPI 文档。
Swagger UI 也可访问：[https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference)。

### 使用私有或受限模型

你可以使用 `HF_TOKEN` 环境变量来配置 `text-generation-inference` 所使用的令牌，从而访问受保护资源。

例如，如果你想服务受限的 Llama V2 模型变体：

1. 访问 https://huggingface.co/settings/tokens
2. 复制你的 CLI 读取（READ）令牌
3. 导出 `HF_TOKEN=<你的 CLI 读取令牌>`

或使用 Docker：

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # 与 Docker 容器共享卷，避免每次运行都下载权重
token=<你的 CLI 读取令牌>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### 关于共享内存（shm）

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html) 是 PyTorch 用于分布式训练/推理的通信框架。`text-generation-inference` 使用 NCCL 实现张量并行，大幅加速大型语言模型的推理。

为了在 NCCL 组的不同设备间共享数据，如果不能通过 NVLink 或 PCI 进行点对点通信，NCCL 可能会回退使用主机内存。

为了让容器使用 1G 共享内存并支持 SHM 共享，以上命令中添加了 `--shm-size 1g`。

如果你在 Kubernetes 中运行 `text-generation-inference`，也可以通过创建如下共享内存卷添加共享内存：

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

并挂载到 `/dev/shm`。

你也可以通过设置环境变量 `NCCL_SHM_DISABLE=1` 来禁用 SHM 共享，但这会影响性能。

### 分布式追踪

`text-generation-inference` 集成了 OpenTelemetry 的分布式追踪。你可以通过 `--otlp-endpoint` 参数设置 OTLP 收集器地址启用此功能。默认服务名称可用 `--otlp-service-name` 参数覆盖。

### 架构

![TGI 架构](https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/huggingface/documentation-images/resolve/main/TGI.png)

Adyen 关于 TGI 内部工作机制的详细博客：[使用 TGI 实现大规模 LLM 推理（Martin Iglesias Goyanes - Adyen, 2024）](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### 本地安装

你也可以选择本地安装 `text-generation-inference`。

首先克隆仓库并切换目录：
```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

然后[安装 Rust](https://rustup.rs/)并创建一个至少包含 Python 3.9 的 Python 虚拟环境，例如使用 `conda` 或 `python venv`：

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

# 使用 conda
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

# 使用 python venv
python3 -m venv .venv
source .venv/bin/activate
```

你可能还需要安装 Protoc。

在 Linux 上：

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://raw.githubusercontent.com/huggingface/text-generation-inference/main/protoc-21.12-linux-x86_64.zip
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

在 MacOS 上，使用 Homebrew：

```shell
brew install protobuf
```

然后运行：

```shell
BUILD_EXTENSIONS=True make install # 安装仓库和带有 CUDA 内核的 HF/transformer 分支
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**注意：** 在某些机器上，你可能还需要 OpenSSL 库和 gcc。在 Linux 机器上，运行：

```shell
sudo apt-get install libssl-dev gcc -y
```

### 本地安装（Nix）

另一种选择是使用 [Nix](https://nixos.org) 本地安装 `text-generation-inference`。目前，
我们仅支持带有 CUDA GPU 的 x86_64 Linux 上的 Nix。使用 Nix 时，所有依赖都可以
从二进制缓存中拉取，无需本地构建。

首先按照说明 [安装 Cachix 并启用 Hugging Face 缓存](https://app.cachix.org/cache/huggingface)。
设置缓存非常重要，否则 Nix 将本地构建许多依赖项，
这可能需要数小时。

完成后，你可以用 `nix run` 运行 TGI：

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**注意：** 当你在非 NixOS 系统上使用 Nix 时，你必须 [创建一些符号链接](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library)
使 CUDA 驱动库对 Nix 包可见。

对于 TGI 开发，你可以使用 `impure` 开发 shell：

```shell
nix develop .#impure

# 仅在第一次启动 devshell 或更新 protobuf 后需要执行
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

所有开发依赖项（cargo、Python、Torch 等）都包含在该
开发 shell 中。

## 优化架构

TGI 开箱即用，支持所有现代模型的优化模型。它们可以在[此列表](https://huggingface.co/docs/text-generation-inference/supported_models)中找到。

其他架构基于最大努力原则支持，使用：

`AutoModelForCausalLM.from_pretrained(<model>, device_map="auto")`

或

`AutoModelForSeq2SeqLM.from_pretrained(<model>, device_map="auto")`



## 本地运行

### 运行

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### 量化

你也可以运行预量化权重（AWQ、GPTQ、Marlin）或使用 bitsandbytes、EETQ、fp8 进行动态量化，以减少显存需求：

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

4bit 量化可通过使用 [bitsandbytes 中的 NF4 和 FP4 数据类型](https://arxiv.org/pdf/2305.14314.pdf) 实现。可以通过给 `text-generation-launcher` 提供命令行参数 `--quantize bitsandbytes-nf4` 或 `--quantize bitsandbytes-fp4` 来启用。

更多关于量化的信息请参阅[量化文档](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization)。

## 开发

```shell
make server-dev
make router-dev
```

## 测试

```shell
# python
make python-server-tests
make python-client-tests
# 或同时运行服务器和客户端测试
make python-tests
# rust cargo 测试
make rust-tests
# 集成测试
make integration-tests
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---