<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://huggingface.co/datasets/Narsil/tgi_assets/resolve/main/thumbnail.png">
</a>

# Text Generation Inference

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API documentation" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

Một server Rust, Python và gRPC cho suy luận sinh văn bản. Được sử dụng trong sản xuất tại [Hugging Face](https://huggingface.co)
để cung cấp năng lượng cho Hugging Chat, API Suy luận và Các Điểm cuối Suy luận.

</div>

## Mục lục

  - [Bắt đầu](#get-started)
    - [Docker](#docker)
    - [Tài liệu API](#api-documentation)
    - [Sử dụng mô hình riêng tư hoặc giới hạn](#using-a-private-or-gated-model)
    - [Ghi chú về Bộ nhớ Chia sẻ (shm)](#a-note-on-shared-memory-shm)
    - [Theo dõi Phân tán](#distributed-tracing)
    - [Kiến trúc](#architecture)
    - [Cài đặt cục bộ](#local-install)
    - [Cài đặt cục bộ (Nix)](#local-install-nix)
  - [Kiến trúc tối ưu hóa](#optimized-architectures)
  - [Chạy cục bộ](#run-locally)
    - [Chạy](#run)
    - [Lượng tử hóa](#quantization)
  - [Phát triển](#develop)
  - [Kiểm thử](#testing)

Text Generation Inference (TGI) là một bộ công cụ để triển khai và phục vụ các Mô hình Ngôn ngữ Lớn (LLMs). TGI cho phép sinh văn bản hiệu suất cao cho các LLM mã nguồn mở phổ biến nhất, bao gồm Llama, Falcon, StarCoder, BLOOM, GPT-NeoX và [nhiều hơn nữa](https://huggingface.co/docs/text-generation-inference/supported_models). TGI triển khai nhiều tính năng, như:

- Trình khởi chạy đơn giản để phục vụ hầu hết các LLM phổ biến
- Sẵn sàng cho sản xuất (theo dõi phân tán với Open Telemetry, số liệu Prometheus)
- Song song Tensor để suy luận nhanh hơn trên nhiều GPU
- Phát trực tiếp token sử dụng Server-Sent Events (SSE)
- Gom lô yêu cầu liên tục để tăng tổng thông lượng
- [Messages API](https://huggingface.co/docs/text-generation-inference/en/messages_api) tương thích với Open AI Chat Completion API
- Mã transformers tối ưu cho suy luận sử dụng [Flash Attention](https://github.com/HazyResearch/flash-attention) và [Paged Attention](https://github.com/vllm-project/vllm) trên các kiến trúc phổ biến nhất
- Lượng tử hóa với:
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- Tải trọng số bằng [Safetensors](https://github.com/huggingface/safetensors)
- Đóng dấu bản quyền với [A Watermark for Large Language Models](https://arxiv.org/abs/2301.10226)
- Bộ biến đổi logits (điều chỉnh nhiệt độ, top-p, top-k, phạt lặp lại, xem thêm chi tiết tại [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor))
- Dừng chuỗi
- Xác suất log
- [Dự đoán](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) giảm độ trễ khoảng 2 lần
- [Hướng dẫn/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance). Chỉ định định dạng đầu ra để tăng tốc suy luận và đảm bảo đầu ra hợp lệ theo một số tiêu chuẩn.
- Tạo Prompt tùy chỉnh: Dễ dàng tạo văn bản bằng cách cung cấp prompt tùy chỉnh để hướng dẫn đầu ra của mô hình
- Hỗ trợ tinh chỉnh: Sử dụng các mô hình đã được tinh chỉnh cho các tác vụ cụ thể để đạt độ chính xác và hiệu suất cao hơn

### Hỗ trợ phần cứng

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [Intel GPU](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## Bắt đầu

### Docker

Để có hướng dẫn khởi đầu chi tiết, vui lòng xem [Quick Tour](https://huggingface.co/docs/text-generation-inference/quicktour). Cách dễ nhất để bắt đầu là sử dụng container Docker chính thức:

```shell
model=HuggingFaceH4/zephyr-7b-beta
# chia sẻ một volume với container Docker để tránh tải trọng số mỗi lần chạy
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

Và sau đó bạn có thể gửi yêu cầu như

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"What is Deep Learning?","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

Bạn cũng có thể sử dụng [Messages API của TGI](https://huggingface.co/docs/text-generation-inference/en/messages_api) để nhận phản hồi tương thích với Open AI Chat Completion API.

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

**Lưu ý:** Để sử dụng GPU NVIDIA, bạn cần cài đặt [NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html). Chúng tôi cũng khuyến nghị sử dụng driver NVIDIA với phiên bản CUDA 12.2 trở lên. Để chạy container Docker trên máy không có GPU hoặc không hỗ trợ CUDA, chỉ cần bỏ flag `--gpus all` và thêm `--disable-custom-kernels`, lưu ý CPU không phải nền tảng dự kiến cho dự án này nên hiệu năng có thể không cao.

**Lưu ý:** TGI hỗ trợ GPU AMD Instinct MI210 và MI250. Chi tiết có trong [Tài liệu Phần cứng Hỗ trợ](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus). Để sử dụng GPU AMD, vui lòng dùng lệnh `docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model` thay cho lệnh trên.

Để xem tất cả các tùy chọn phục vụ mô hình của bạn (trong [mã nguồn](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs) hoặc trong cli):
```
text-generation-launcher --help
```

### Tài liệu API

Bạn có thể tham khảo tài liệu OpenAPI của REST API `text-generation-inference` thông qua đường dẫn `/docs`.
Giao diện Swagger UI cũng có sẵn tại: [https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference).

### Sử dụng mô hình riêng tư hoặc giới hạn

Bạn có thể sử dụng biến môi trường `HF_TOKEN` để cấu hình token được `text-generation-inference` sử dụng. Điều này cho phép truy cập tài nguyên được bảo vệ.

Ví dụ, nếu bạn muốn phục vụ các biến thể mô hình Llama V2 giới hạn:

1. Truy cập https://huggingface.co/settings/tokens
2. Sao chép token CLI READ của bạn
3. Xuất `HF_TOKEN=<token CLI READ của bạn>`

hoặc với Docker:

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # chia sẻ volume với container Docker để tránh tải trọng số mỗi lần chạy
token=<token cli READ của bạn>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### Ghi chú về Bộ nhớ Chia sẻ (shm)

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html) là một framework giao tiếp được `PyTorch` sử dụng để huấn luyện/suy luận phân tán. `text-generation-inference` sử dụng `NCCL` để kích hoạt Tensor Parallelism giúp tăng tốc suy luận cho các mô hình ngôn ngữ lớn.

Để chia sẻ dữ liệu giữa các thiết bị trong nhóm `NCCL`, `NCCL` có thể dựa vào bộ nhớ host nếu không thể giao tiếp peer-to-peer qua NVLink hoặc PCI.

Để cho phép container sử dụng 1G Bộ nhớ Chia sẻ và hỗ trợ chia sẻ SHM, chúng tôi thêm `--shm-size 1g` vào lệnh trên.

Nếu bạn chạy `text-generation-inference` trong `Kubernetes`, bạn cũng có thể thêm Bộ nhớ Chia sẻ vào container bằng cách tạo volume:

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

và mount nó vào `/dev/shm`.

Cuối cùng, bạn cũng có thể tắt chia sẻ SHM bằng biến môi trường `NCCL_SHM_DISABLE=1`. Tuy nhiên, lưu ý điều này sẽ ảnh hưởng đến hiệu năng.

### Theo dõi Phân tán

`text-generation-inference` được tích hợp theo dõi phân tán sử dụng OpenTelemetry. Bạn có thể sử dụng tính năng này bằng cách đặt địa chỉ tới bộ thu OTLP với tham số `--otlp-endpoint`. Tên dịch vụ mặc định có thể được ghi đè bằng tham số `--otlp-service-name`.

### Kiến trúc

![TGI architecture](https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/TGI.png)

Bài viết chi tiết của Adyen về hoạt động bên trong TGI: [LLM inference at scale with TGI (Martin Iglesias Goyanes - Adyen, 2024)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### Cài đặt cục bộ

Bạn cũng có thể chọn cài đặt `text-generation-inference` cục bộ.

Trước tiên, clone repository và chuyển vào thư mục đó:
Dưới đây là bản dịch tài liệu kỹ thuật sang tiếng Việt, giữ nguyên định dạng Markdown và đường dẫn tương đối đã được hoàn chỉnh với https://raw.githubusercontent.com/huggingface/text-generation-inference/main/:


```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

Sau đó [cài đặt Rust](https://rustup.rs/) và tạo môi trường ảo Python với ít nhất
Python 3.9, ví dụ sử dụng `conda` hoặc `python venv`:

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

# sử dụng conda
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

# sử dụng python venv
python3 -m venv .venv
source .venv/bin/activate
```

Bạn cũng có thể cần cài đặt Protoc.

Trên Linux:

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

Trên MacOS, sử dụng Homebrew:

```shell
brew install protobuf
```

Sau đó chạy:

```shell
BUILD_EXTENSIONS=True make install # Cài đặt kho lưu trữ và bản fork HF/transformer với CUDA kernels
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**Lưu ý:** trên một số máy, bạn cũng có thể cần các thư viện OpenSSL và gcc. Trên các máy Linux, chạy:

```shell
sudo apt-get install libssl-dev gcc -y
```

### Cài đặt cục bộ (Nix)

Một lựa chọn khác là cài đặt `text-generation-inference` cục bộ bằng [Nix](https://nixos.org). Hiện tại,
chúng tôi chỉ hỗ trợ Nix trên Linux x86_64 với GPU CUDA. Khi sử dụng Nix, tất cả các phụ thuộc có thể
được lấy từ bộ nhớ đệm nhị phân, loại bỏ nhu cầu xây dựng chúng cục bộ.

Trước tiên làm theo hướng dẫn để [cài đặt Cachix và kích hoạt bộ nhớ đệm Hugging Face](https://app.cachix.org/cache/huggingface).
Việc thiết lập bộ nhớ đệm rất quan trọng, nếu không Nix sẽ xây dựng nhiều phụ thuộc
tại chỗ, điều này có thể mất nhiều giờ.

Sau đó bạn có thể chạy TGI với `nix run`:

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**Lưu ý:** khi bạn sử dụng Nix trên hệ thống không phải NixOS, bạn phải [tạo một số liên kết tượng trưng](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library)
để làm cho các thư viện trình điều khiển CUDA hiển thị với các gói Nix.

Để phát triển TGI, bạn có thể sử dụng shell phát triển `impure`:

```shell
nix develop .#impure

# Chỉ cần thiết lần đầu khởi động devshell hoặc sau khi cập nhật protobuf.
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

Tất cả các phụ thuộc phát triển (cargo, Python, Torch), v.v... đều có trong
shell phát triển này.

## Kiến trúc tối ưu hóa

TGI hoạt động ngay lập tức để phục vụ các mô hình tối ưu cho tất cả các mô hình hiện đại. Chúng có thể được tìm thấy trong [danh sách này](https://huggingface.co/docs/text-generation-inference/supported_models).

Các kiến trúc khác được hỗ trợ trên cơ sở cố gắng tốt nhất bằng cách sử dụng:

`AutoModelForCausalLM.from_pretrained(<model>, device_map="auto")`

hoặc

`AutoModelForSeq2SeqLM.from_pretrained(<model>, device_map="auto")`



## Chạy cục bộ

### Chạy

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### Lượng tử hóa

Bạn cũng có thể chạy trọng số đã được lượng tử hóa trước (AWQ, GPTQ, Marlin) hoặc lượng tử hóa trọng số khi chạy với bitsandbytes, EETQ, fp8, để giảm yêu cầu VRAM:

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

Lượng tử 4bit có sẵn sử dụng [kiểu dữ liệu NF4 và FP4 từ bitsandbytes](https://arxiv.org/pdf/2305.14314.pdf). Nó có thể được bật bằng cách cung cấp `--quantize bitsandbytes-nf4` hoặc `--quantize bitsandbytes-fp4` như một tham số dòng lệnh cho `text-generation-launcher`.

Đọc thêm về lượng tử hóa trong [tài liệu Lượng tử hóa](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization).

## Phát triển

```shell
make server-dev
make router-dev
```

## Kiểm thử

```shell
# python
make python-server-tests
make python-client-tests
# hoặc kiểm thử cả server và client
make python-tests
# kiểm thử rust cargo
make rust-tests
# kiểm thử tích hợp
make integration-tests
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---