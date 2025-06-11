<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/Narsil/tgi_assets/thumbnail.png">
</a>

# การอนุมานการสร้างข้อความ (Text Generation Inference)

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API documentation" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

เซิร์ฟเวอร์ Rust, Python และ gRPC สำหรับการอนุมานการสร้างข้อความ ใช้ในระบบการผลิตที่ [Hugging Face](https://huggingface.co) เพื่อขับเคลื่อน Hugging Chat, Inference API และ Inference Endpoints

</div>

## สารบัญ

  - [เริ่มต้นใช้งาน](#get-started)
    - [Docker](#docker)
    - [เอกสาร API](#api-documentation)
    - [การใช้โมเดลส่วนตัวหรือที่มีการควบคุม](#using-a-private-or-gated-model)
    - [หมายเหตุเกี่ยวกับ Shared Memory (shm)](#a-note-on-shared-memory-shm)
    - [Distributed Tracing](#distributed-tracing)
    - [สถาปัตยกรรม](#architecture)
    - [ติดตั้งแบบโลคอล](#local-install)
    - [ติดตั้งแบบโลคอล (Nix)](#local-install-nix)
  - [สถาปัตยกรรมที่ปรับแต่งแล้ว](#optimized-architectures)
  - [รันแบบโลคอล](#run-locally)
    - [รัน](#run)
    - [การควอนไทเซชัน](#quantization)
  - [พัฒนา](#develop)
  - [การทดสอบ](#testing)

Text Generation Inference (TGI) คือชุดเครื่องมือสำหรับการปรับใช้และให้บริการ Large Language Models (LLMs) TGI ช่วยให้การสร้างข้อความที่มีประสิทธิภาพสูงสำหรับ LLMs โอเพนซอร์สยอดนิยม เช่น Llama, Falcon, StarCoder, BLOOM, GPT-NeoX และ [อื่น ๆ](https://huggingface.co/docs/text-generation-inference/supported_models) TGI มีฟีเจอร์มากมาย เช่น:

- ตัวเรียกใช้งานง่ายสำหรับให้บริการ LLMs ยอดนิยมส่วนใหญ่
- พร้อมใช้งานในระบบการผลิต (distributed tracing ด้วย Open Telemetry, เมตริกของ Prometheus)
- Tensor Parallelism เพื่อเร่งการอนุมานบน GPU หลายตัว
- การสตรีมโทเค็นโดยใช้ Server-Sent Events (SSE)
- การจัดกลุ่มคำขอที่เข้ามาอย่างต่อเนื่องเพื่อเพิ่มประสิทธิภาพโดยรวม
- [Messages API](https://huggingface.co/docs/text-generation-inference/en/messages_api) ที่เข้ากันได้กับ Open AI Chat Completion API
- โค้ด transformers ที่ปรับแต่งเพื่อการอนุมานโดยใช้ [Flash Attention](https://github.com/HazyResearch/flash-attention) และ [Paged Attention](https://github.com/vllm-project/vllm) บนสถาปัตยกรรมยอดนิยม
- การควอนไทเซชันด้วย:
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- การโหลดน้ำหนักด้วย [Safetensors](https://github.com/huggingface/safetensors)
- การประทับลายน้ำด้วย [A Watermark for Large Language Models](https://arxiv.org/abs/2301.10226)
- Logits warper (การปรับอุณหภูมิ, top-p, top-k, โทษการทำซ้ำ, ดูรายละเอียดเพิ่มเติมที่ [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor))
- ลำดับหยุด
- ความน่าจะเป็นแบบล็อก
- [Speculation](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) ลดความหน่วง ~2 เท่า
- [Guidance/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance) กำหนดรูปแบบผลลัพธ์เพื่อเร่งการอนุมานและตรวจสอบให้ผลลัพธ์ถูกต้องตามสเปค
- การสร้าง Prompt ที่กำหนดเอง: สร้างข้อความได้ง่ายโดยให้ prompt ที่กำหนดเองเพื่อชี้นำผลลัพธ์ของโมเดล
- การสนับสนุนการปรับแต่ง: ใช้โมเดลที่ปรับแต่งเฉพาะงานเพื่อความแม่นยำและประสิทธิภาพสูงขึ้น

### การสนับสนุนฮาร์ดแวร์

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [Intel GPU](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## เริ่มต้นใช้งาน

### Docker

สำหรับคู่มือเริ่มต้นแบบละเอียด โปรดดูที่ [Quick Tour](https://huggingface.co/docs/text-generation-inference/quicktour) วิธีที่ง่ายที่สุดในการเริ่มต้นคือการใช้ Docker container อย่างเป็นทางการ:

```shell
model=HuggingFaceH4/zephyr-7b-beta
# แชร์โวลุ่มกับ Docker container เพื่อหลีกเลี่ยงการดาวน์โหลดน้ำหนักซ้ำทุกครั้ง
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

แล้วคุณสามารถส่งคำขอเช่น

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"What is Deep Learning?","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

คุณยังสามารถใช้ [Messages API ของ TGI](https://huggingface.co/docs/text-generation-inference/en/messages_api) เพื่อรับการตอบกลับที่เข้ากันได้กับ Open AI Chat Completion API

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

**หมายเหตุ:** เพื่อใช้ GPU ของ NVIDIA คุณต้องติดตั้ง [NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html) เราแนะนำให้ใช้ไดรเวอร์ NVIDIA ที่มี CUDA เวอร์ชัน 12.2 หรือสูงกว่า สำหรับการรัน Docker container บนเครื่องที่ไม่มี GPU หรือ CUDA เพียงแค่ลบ flag `--gpus all` และเพิ่ม `--disable-custom-kernels` โปรดทราบว่า CPU ไม่ใช่แพลตฟอร์มที่ออกแบบไว้สำหรับโปรเจคนี้ ดังนั้นประสิทธิภาพอาจต่ำกว่าที่คาด

**หมายเหตุ:** TGI รองรับ GPU AMD Instinct MI210 และ MI250 รายละเอียดดูได้ใน [เอกสารฮาร์ดแวร์ที่รองรับ](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus) สำหรับการใช้ GPU AMD โปรดใช้คำสั่ง `docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model` แทนคำสั่งข้างต้น

เพื่อดูตัวเลือกทั้งหมดในการให้บริการโมเดลของคุณ (ใน [โค้ด](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs) หรือใน CLI):
```
text-generation-launcher --help
```

### เอกสาร API

คุณสามารถดูเอกสาร OpenAPI ของ `text-generation-inference` REST API ได้โดยใช้เส้นทาง `/docs`
Swagger UI ยังสามารถเข้าถึงได้ที่: [https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference)

### การใช้โมเดลส่วนตัวหรือที่มีการควบคุม

คุณสามารถใช้ตัวแปรสภาพแวดล้อม `HF_TOKEN` เพื่อกำหนดโทเค็นที่ใช้โดย
`text-generation-inference` ซึ่งช่วยให้คุณเข้าถึงทรัพยากรที่ถูกป้องกันได้

ตัวอย่างเช่น หากต้องการให้บริการโมเดล Llama V2 ที่มีการควบคุม:

1. ไปที่ https://huggingface.co/settings/tokens
2. คัดลอกโทเค็น CLI READ ของคุณ
3. ส่งออก `HF_TOKEN=<your CLI READ token>`

หรือใช้ Docker:

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # แชร์โวลุ่มกับ Docker container เพื่อหลีกเลี่ยงการดาวน์โหลดน้ำหนักซ้ำทุกครั้ง
token=<your cli READ token>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### หมายเหตุเกี่ยวกับ Shared Memory (shm)

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html) เป็นกรอบการสื่อสารที่ใช้โดย
`PyTorch` สำหรับการฝึก/อนุมานแบบกระจาย `text-generation-inference` ใช้
`NCCL` เพื่อเปิดใช้งาน Tensor Parallelism เร่งการอนุมานโมเดลภาษาขนาดใหญ่ได้อย่างมาก

เพื่อแชร์ข้อมูลระหว่างอุปกรณ์ต่าง ๆ ในกลุ่ม `NCCL` หากไม่สามารถเชื่อมต่อ peer-to-peer ผ่าน NVLink หรือ PCI ได้
`NCCL` อาจใช้หน่วยความจำโฮสต์แทน

เพื่อให้ container ใช้ Shared Memory ขนาด 1G และรองรับการแชร์ SHM เราจะเพิ่ม `--shm-size 1g` ในคำสั่งด้านบน

ถ้าคุณรัน `text-generation-inference` ใน `Kubernetes` คุณสามารถเพิ่ม Shared Memory ให้ container ได้โดย
สร้างโวลุ่มด้วย:

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

และแมปไปยัง `/dev/shm`

สุดท้าย คุณยังสามารถปิดการแชร์ SHM ได้โดยใช้ตัวแปรสภาพแวดล้อม `NCCL_SHM_DISABLE=1` แต่โปรดทราบว่าการตั้งค่านี้จะส่งผลต่อประสิทธิภาพ

### Distributed Tracing

`text-generation-inference` ได้ติดตั้ง distributed tracing โดยใช้ OpenTelemetry คุณสามารถใช้ฟีเจอร์นี้
โดยตั้งค่าที่อยู่ไปยัง OTLP collector ด้วยอาร์กิวเมนต์ `--otlp-endpoint` ชื่อบริการเริ่มต้นสามารถเปลี่ยนได้ด้วย `--otlp-service-name`

### สถาปัตยกรรม

![TGI architecture](https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/huggingface/documentation-images/TGI.png)

บทความบล็อกโดย Adyen เกี่ยวกับการทำงานภายในของ TGI: [LLM inference at scale with TGI (Martin Iglesias Goyanes - Adyen, 2024)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### ติดตั้งแบบโลคอล

คุณยังสามารถเลือกติดตั้ง `text-generation-inference` แบบโลคอลได้

เริ่มจากโคลนที่เก็บโค้ดและเปลี่ยนไปยังไดเรกทอรีนั้น:
```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

จากนั้น [ติดตั้ง Rust](https://rustup.rs/) และสร้างสภาพแวดล้อม Python แบบเสมือนที่มี Python 3.9 ขึ้นไป เช่น ใช้ `conda` หรือ `python venv`:

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

#ใช้ conda
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

#ใช้ python venv
python3 -m venv .venv
source .venv/bin/activate
```

คุณอาจจำเป็นต้องติดตั้ง Protoc ด้วย

บน Linux:

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

บน MacOS โดยใช้ Homebrew:

```shell
brew install protobuf
```

จากนั้นรัน:

```shell
BUILD_EXTENSIONS=True make install # ติดตั้ง repository และ HF/transformer fork พร้อม CUDA kernels
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**หมายเหตุ:** บนเครื่องบางเครื่อง คุณอาจต้องติดตั้งไลบรารี OpenSSL และ gcc ด้วย บนเครื่อง Linux รันคำสั่ง:

```shell
sudo apt-get install libssl-dev gcc -y
```

### การติดตั้งแบบโลคอล (Nix)

อีกทางเลือกหนึ่งคือการติดตั้ง `text-generation-inference` แบบโลคอลโดยใช้ [Nix](https://nixos.org) ปัจจุบันรองรับ Nix บน x86_64 Linux ที่มี GPU CUDA เท่านั้น เมื่อใช้ Nix จะดึง dependencies ทั้งหมดจาก binary cache ช่วยลดความจำเป็นในการคอมไพล์เอง

เริ่มต้นด้วยการทำตามคำแนะนำเพื่อ [ติดตั้ง Cachix และเปิดใช้งาน Hugging Face cache](https://app.cachix.org/cache/huggingface) การตั้งค่า cache มีความสำคัญ เพราะถ้าไม่มี Nix จะคอมไพล์ dependencies หลายตัวเอง ซึ่งอาจใช้เวลานาน

หลังจากนั้นคุณสามารถรัน TGI ด้วย `nix run`:

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**หมายเหตุ:** เมื่อใช้ Nix บนระบบที่ไม่ใช่ NixOS คุณต้อง [สร้าง symlinks บางตัว](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library) เพื่อให้ไลบรารี CUDA driver มองเห็นได้โดยแพ็กเกจ Nix

สำหรับการพัฒนา TGI คุณสามารถใช้ `impure` dev shell:

```shell
nix develop .#impure

# จำเป็นเฉพาะครั้งแรกที่เริ่ม devshell หรือหลังจากอัปเดต protobuf เท่านั้น
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

แพ็กเกจสำหรับการพัฒนาทั้งหมด (cargo, Python, Torch) และอื่น ๆ พร้อมใช้งานใน dev shell นี้

## สถาปัตยกรรมที่ปรับแต่ง

TGI ทำงานได้ทันทีเพื่อให้บริการโมเดลที่ปรับแต่งสำหรับโมเดลสมัยใหม่ทั้งหมด ซึ่งสามารถดูได้ใน [รายชื่อโมเดลนี้](https://huggingface.co/docs/text-generation-inference/supported_models)

สถาปัตยกรรมอื่น ๆ รองรับแบบพยายามอย่างดีที่สุดโดยใช้:

`AutoModelForCausalLM.from_pretrained(<model>, device_map="auto")`

หรือ

`AutoModelForSeq2SeqLM.from_pretrained(<model>, device_map="auto")`



## รันแบบโลคอล

### รัน

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### การควอนไทซ์

คุณยังสามารถรันน้ำหนักที่ควอนไทซ์ล่วงหน้า (AWQ, GPTQ, Marlin) หรือควอนไทซ์น้ำหนักแบบ on-the-fly ด้วย bitsandbytes, EETQ, fp8 เพื่อลดความต้องการ VRAM:

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

การควอนไทซ์ 4 บิต มีให้ใช้โดยใช้ [ชนิดข้อมูล NF4 และ FP4 จาก bitsandbytes](https://arxiv.org/pdf/2305.14314.pdf) สามารถเปิดใช้งานโดยระบุ `--quantize bitsandbytes-nf4` หรือ `--quantize bitsandbytes-fp4` เป็นอาร์กิวเมนต์บรรทัดคำสั่งของ `text-generation-launcher`

อ่านเพิ่มเติมเกี่ยวกับการควอนไทซ์ใน [เอกสาร Quantization](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization)

## การพัฒนา

```shell
make server-dev
make router-dev
```

## การทดสอบ

```shell
# python
make python-server-tests
make python-client-tests
# หรือทดสอบทั้ง server และ client
make python-tests
# ทดสอบ rust cargo
make rust-tests
# ทดสอบแบบบูรณาการ
make integration-tests
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---