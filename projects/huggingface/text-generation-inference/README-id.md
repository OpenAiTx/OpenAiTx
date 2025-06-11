<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/Narsil/tgi_assets/thumbnail.png">
</a>

# Text Generation Inference

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API documentation" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

Server Rust, Python, dan gRPC untuk inferensi generasi teks. Digunakan dalam produksi di [Hugging Face](https://huggingface.co) untuk menjalankan Hugging Chat, API Inferensi, dan Endpoint Inferensi.

</div>

## Daftar Isi

  - [Memulai](#get-started)
    - [Docker](#docker)
    - [Dokumentasi API](#api-documentation)
    - [Menggunakan model privat atau gated](#using-a-private-or-gated-model)
    - [Catatan tentang Shared Memory (shm)](#a-note-on-shared-memory-shm)
    - [Distributed Tracing](#distributed-tracing)
    - [Arsitektur](#architecture)
    - [Instalasi lokal](#local-install)
    - [Instalasi lokal (Nix)](#local-install-nix)
  - [Arsitektur yang dioptimalkan](#optimized-architectures)
  - [Jalankan secara lokal](#run-locally)
    - [Jalankan](#run)
    - [Kuantisasi](#quantization)
  - [Pengembangan](#develop)
  - [Pengujian](#testing)

Text Generation Inference (TGI) adalah toolkit untuk menerapkan dan melayani Large Language Models (LLMs). TGI memungkinkan generasi teks berkinerja tinggi untuk LLM open-source paling populer, termasuk Llama, Falcon, StarCoder, BLOOM, GPT-NeoX, dan [lainnya](https://huggingface.co/docs/text-generation-inference/supported_models). TGI mengimplementasikan banyak fitur, seperti:

- Peluncur sederhana untuk melayani LLM paling populer
- Siap produksi (distributed tracing dengan Open Telemetry, metrik Prometheus)
- Tensor Parallelism untuk inferensi lebih cepat di beberapa GPU
- Streaming token menggunakan Server-Sent Events (SSE)
- Pengelompokan terus-menerus dari permintaan masuk untuk meningkatkan total throughput
- [Messages API](https://huggingface.co/docs/text-generation-inference/en/messages_api) kompatibel dengan Open AI Chat Completion API
- Kode transformer yang dioptimalkan untuk inferensi menggunakan [Flash Attention](https://github.com/HazyResearch/flash-attention) dan [Paged Attention](https://github.com/vllm-project/vllm) pada arsitektur paling populer
- Kuantisasi dengan:
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- Pemuatan bobot [Safetensors](https://github.com/huggingface/safetensors)
- Watermarking dengan [A Watermark for Large Language Models](https://arxiv.org/abs/2301.10226)
- Logits warper (scaling suhu, top-p, top-k, penalti pengulangan, detail lebih lanjut lihat [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor))
- Stop sequences
- Probabilitas log
- [Spekulasi](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) ~2x latensi
- [Guidance/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance). Menentukan format output untuk mempercepat inferensi dan memastikan output valid sesuai beberapa spesifikasi.
- Custom Prompt Generation: Mudah membuat teks dengan memberikan prompt kustom untuk mengarahkan output model
- Dukungan Fine-tuning: Memanfaatkan model yang sudah di-fine-tune untuk tugas spesifik guna mencapai akurasi dan performa lebih tinggi

### Dukungan perangkat keras

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [Intel GPU](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## Memulai

### Docker

Untuk panduan awal yang rinci, silakan lihat [Quick Tour](https://huggingface.co/docs/text-generation-inference/quicktour). Cara termudah memulai adalah menggunakan container Docker resmi:

```shell
model=HuggingFaceH4/zephyr-7b-beta
# bagikan volume dengan container Docker agar tidak mengunduh bobot setiap kali menjalankan
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

Kemudian Anda dapat membuat permintaan seperti

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"Apa itu Deep Learning?","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

Anda juga dapat menggunakan [Messages API TGI](https://huggingface.co/docs/text-generation-inference/en/messages_api) untuk mendapatkan respons yang kompatibel dengan Open AI Chat Completion API.

```bash
curl localhost:8080/v1/chat/completions \
    -X POST \
    -d '{
  "model": "tgi",
  "messages": [
    {
      "role": "system",
      "content": "Anda adalah asisten yang membantu."
    },
    {
      "role": "user",
      "content": "Apa itu deep learning?"
    }
  ],
  "stream": true,
  "max_tokens": 20
}' \
    -H 'Content-Type: application/json'
```

**Catatan:** Untuk menggunakan GPU NVIDIA, Anda perlu menginstal [NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html). Kami juga menyarankan menggunakan driver NVIDIA dengan versi CUDA 12.2 atau lebih tinggi. Untuk menjalankan container Docker pada mesin tanpa GPU atau dukungan CUDA, cukup hapus flag `--gpus all` dan tambahkan `--disable-custom-kernels`, harap dicatat CPU bukan platform yang dimaksud untuk proyek ini, jadi performa mungkin kurang optimal.

**Catatan:** TGI mendukung GPU AMD Instinct MI210 dan MI250. Detail dapat ditemukan di [dokumentasi Supported Hardware](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus). Untuk menggunakan GPU AMD, gunakan perintah `docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model` menggantikan perintah di atas.

Untuk melihat semua opsi untuk melayani model Anda (di [kode](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs) atau di CLI):
```
text-generation-launcher --help
```

### Dokumentasi API

Anda dapat melihat dokumentasi OpenAPI dari REST API `text-generation-inference` menggunakan route `/docs`.
Swagger UI juga tersedia di: [https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference).

### Menggunakan model privat atau gated

Anda dapat menggunakan variabel lingkungan `HF_TOKEN` untuk mengonfigurasi token yang digunakan oleh
`text-generation-inference`. Ini memungkinkan Anda mengakses sumber daya yang dilindungi.

Sebagai contoh, jika Anda ingin melayani varian model gated Llama V2:

1. Kunjungi https://huggingface.co/settings/tokens
2. Salin token CLI READ Anda
3. Ekspor `HF_TOKEN=<token CLI READ Anda>`

atau dengan Docker:

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # bagikan volume dengan container Docker untuk menghindari pengunduhan bobot setiap kali menjalankan
token=<token cli READ Anda>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### Catatan tentang Shared Memory (shm)

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html) adalah kerangka komunikasi yang digunakan oleh
`PyTorch` untuk melakukan pelatihan/inferensi terdistribusi. `text-generation-inference` menggunakan
`NCCL` untuk mengaktifkan Tensor Parallelism guna mempercepat inferensi model bahasa besar secara signifikan.

Untuk berbagi data antar perangkat dalam grup `NCCL`, `NCCL` mungkin menggunakan memori host jika
peer-to-peer melalui NVLink atau PCI tidak memungkinkan.

Untuk mengizinkan container menggunakan 1G Shared Memory dan mendukung berbagi SHM, kami menambahkan `--shm-size 1g` pada perintah di atas.

Jika Anda menjalankan `text-generation-inference` di dalam `Kubernetes`, Anda juga dapat menambahkan Shared Memory ke container dengan
membuat volume dengan:

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

dan memasangnya ke `/dev/shm`.

Akhirnya, Anda juga dapat menonaktifkan berbagi SHM dengan menggunakan variabel lingkungan `NCCL_SHM_DISABLE=1`. Namun, perlu diperhatikan ini akan mempengaruhi performa.

### Distributed Tracing

`text-generation-inference` diinstrumentasi dengan distributed tracing menggunakan OpenTelemetry. Anda dapat menggunakan fitur ini
dengan menetapkan alamat ke kolektor OTLP menggunakan argumen `--otlp-endpoint`. Nama layanan default dapat diubah dengan argumen `--otlp-service-name`

### Arsitektur

![Arsitektur TGI](https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/huggingface/documentation-images/TGI.png)

Posting blog mendetail oleh Adyen tentang cara kerja internal TGI: [LLM inference at scale with TGI (Martin Iglesias Goyanes - Adyen, 2024)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### Instalasi lokal

Anda juga dapat memilih untuk menginstal `text-generation-inference` secara lokal.

Pertama kloning repositori dan masuk ke direktori:
```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

Kemudian [pasang Rust](https://rustup.rs/) dan buat lingkungan virtual Python dengan minimal
Python 3.9, misalnya menggunakan `conda` atau `python venv`:

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

# menggunakan conda
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

# menggunakan python venv
python3 -m venv .venv
source .venv/bin/activate
```

Anda mungkin juga perlu memasang Protoc.

Di Linux:

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

Di MacOS, menggunakan Homebrew:

```shell
brew install protobuf
```

Kemudian jalankan:

```shell
BUILD_EXTENSIONS=True make install # Pasang repositori dan fork HF/transformer dengan kernel CUDA
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**Catatan:** di beberapa mesin, Anda mungkin juga memerlukan pustaka OpenSSL dan gcc. Di mesin Linux, jalankan:

```shell
sudo apt-get install libssl-dev gcc -y
```

### Instalasi lokal (Nix)

Opsi lain adalah memasang `text-generation-inference` secara lokal menggunakan [Nix](https://nixos.org). Saat ini,
kami hanya mendukung Nix pada Linux x86_64 dengan GPU CUDA. Saat menggunakan Nix, semua dependensi dapat
diambil dari cache biner, sehingga tidak perlu membangunnya secara lokal.

Pertama ikuti instruksi untuk [memasang Cachix dan mengaktifkan cache Hugging Face](https://app.cachix.org/cache/huggingface).
Pengaturan cache ini penting, jika tidak Nix akan membangun banyak dependensi
secara lokal, yang bisa memakan waktu berjam-jam.

Setelah itu Anda dapat menjalankan TGI dengan `nix run`:

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**Catatan:** saat menggunakan Nix di sistem yang bukan NixOS, Anda harus [membuat beberapa symlink](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library)
agar pustaka driver CUDA terlihat oleh paket Nix.

Untuk pengembangan TGI, Anda dapat menggunakan shell dev `impure`:

```shell
nix develop .#impure

# Hanya diperlukan pertama kali shell dev dijalankan atau setelah memperbarui protobuf.
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

Semua dependensi pengembangan (cargo, Python, Torch), dll tersedia dalam
shell dev ini.

## Arsitektur yang Dioptimalkan

TGI bekerja langsung untuk melayani model yang dioptimalkan untuk semua model modern. Model-model tersebut dapat ditemukan dalam [daftar ini](https://huggingface.co/docs/text-generation-inference/supported_models).

Arsitektur lain didukung dengan upaya terbaik menggunakan:

`AutoModelForCausalLM.from_pretrained(<model>, device_map="auto")`

atau

`AutoModelForSeq2SeqLM.from_pretrained(<model>, device_map="auto")`



## Jalankan secara lokal

### Jalankan

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### Kuantisasi

Anda juga dapat menjalankan bobot yang telah di-kuantisasi sebelumnya (AWQ, GPTQ, Marlin) atau mengkuantisasi bobot secara langsung dengan bitsandbytes, EETQ, fp8, untuk mengurangi kebutuhan VRAM:

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

Kuantisasi 4bit tersedia menggunakan [tipe data NF4 dan FP4 dari bitsandbytes](https://arxiv.org/pdf/2305.14314.pdf). Ini dapat diaktifkan dengan memberikan argumen baris perintah `--quantize bitsandbytes-nf4` atau `--quantize bitsandbytes-fp4` ke `text-generation-launcher`.

Baca lebih lanjut tentang kuantisasi di [Dokumentasi Kuantisasi](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization).

## Kembangkan

```shell
make server-dev
make router-dev
```

## Pengujian

```shell
# python
make python-server-tests
make python-client-tests
# atau kedua pengujian server dan klien
make python-tests
# pengujian rust cargo
make rust-tests
# pengujian integrasi
make integration-tests
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---