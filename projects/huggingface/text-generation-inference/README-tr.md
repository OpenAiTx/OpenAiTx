<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/Narsil/tgi_assets/resolve/main/thumbnail.png">
</a>

# Metin Üretimi Çıkarımı

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo yıldızları" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API dokümantasyonu" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

Rust, Python ve gRPC sunucusu olan metin üretimi çıkarımı için bir araçtır. [Hugging Face](https://huggingface.co) üretiminde kullanılır
Hugging Chat, Inference API ve Inference Endpoints'i desteklemek için.

</div>

## İçindekiler

  - [Başlarken](#get-started)
    - [Docker](#docker)
    - [API dokümantasyonu](#api-documentation)
    - [Özel veya sınırlı model kullanımı](#using-a-private-or-gated-model)
    - [Paylaşılan Bellek (shm) hakkında not](#a-note-on-shared-memory-shm)
    - [Dağıtık İzleme](#distributed-tracing)
    - [Mimari](#architecture)
    - [Yerel kurulum](#local-install)
    - [Yerel kurulum (Nix)](#local-install-nix)
  - [Optimizasyonlu mimariler](#optimized-architectures)
  - [Yerel çalıştırma](#run-locally)
    - [Çalıştırma](#run)
    - [Kuantizasyon](#quantization)
  - [Geliştirme](#develop)
  - [Test](#testing)

Metin Üretimi Çıkarımı (TGI), Büyük Dil Modelleri (LLM) dağıtımı ve sunumu için bir araç setidir. TGI, Llama, Falcon, StarCoder, BLOOM, GPT-NeoX ve [daha fazlası](https://huggingface.co/docs/text-generation-inference/supported_models) dahil en popüler açık kaynak LLM'ler için yüksek performanslı metin üretimi sağlar. TGI şu özellikleri uygular:

- En popüler LLM'leri servis etmek için basit başlatıcı
- Üretim hazır (Open Telemetry ile dağıtık izleme, Prometheus metrikleri)
- Birden fazla GPU üzerinde daha hızlı çıkarım için Tensör Paralelliği
- Server-Sent Events (SSE) kullanarak token akışı
- Artan toplam verimlilik için gelen isteklerin sürekli toplu işlenmesi
- Open AI Chat Completion API ile uyumlu [Mesajlar API'si](https://huggingface.co/docs/text-generation-inference/en/messages_api)
- En popüler mimarilerde çıkarım için [Flash Attention](https://github.com/HazyResearch/flash-attention) ve [Paged Attention](https://github.com/vllm-project/vllm) kullanarak optimize edilmiş transformers kodu
- Kuantizasyon:
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- [Safetensors](https://github.com/huggingface/safetensors) ağırlık yükleme
- [Büyük Dil Modelleri için Su İşareti](https://arxiv.org/abs/2301.10226) ile watermarking
- Logits düzenleyici (sıcaklık ölçeklendirme, top-p, top-k, tekrar cezası, daha fazla detay için [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor))
- Durdurma dizileri
- Log olasılıkları
- [Spekülasyon](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) ~2 kat gecikme
- [Yönlendirme/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance). Çıktı formatını belirleyerek çıkarımı hızlandırır ve çıktının belirli kurallara uygun olmasını sağlar.
- Özel İstek Oluşturma: Model çıktısını yönlendirmek için özel istemler kullanarak kolayca metin üretimi
- İnce ayar desteği: Belirli görevler için ince ayarlanmış modelleri kullanarak daha yüksek doğruluk ve performans elde etme

### Donanım desteği

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [Intel GPU](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## Başlarken

### Docker

Detaylı başlangıç rehberi için lütfen [Hızlı Tur](https://huggingface.co/docs/text-generation-inference/quicktour) sayfasına bakınız. Başlamanın en kolay yolu resmi Docker konteynerini kullanmaktır:

```shell
model=HuggingFaceH4/zephyr-7b-beta
# Docker konteyneri ile bir klasörü paylaşarak her çalıştırmada ağırlıkları indirmenizi önleyin
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

Daha sonra şu şekilde istek yapabilirsiniz:

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"Derin Öğrenme nedir?","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

Ayrıca [TGI'nin Mesajlar API'sini](https://huggingface.co/docs/text-generation-inference/en/messages_api) kullanarak Open AI Chat Completion API uyumlu yanıtlar alabilirsiniz.

```bash
curl localhost:8080/v1/chat/completions \
    -X POST \
    -d '{
  "model": "tgi",
  "messages": [
    {
      "role": "system",
      "content": "Yardımcı bir asistansınız."
    },
    {
      "role": "user",
      "content": "Derin öğrenme nedir?"
    }
  ],
  "stream": true,
  "max_tokens": 20
}' \
    -H 'Content-Type: application/json'
```

**Not:** NVIDIA GPU'ları kullanmak için [NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html) yüklemeniz gerekmektedir. Ayrıca CUDA sürümü 12.2 veya daha yüksek olan NVIDIA sürücülerini kullanmanızı öneririz. GPU veya CUDA desteği olmayan bir makinede Docker konteynerini çalıştırmak için `--gpus all` bayrağını kaldırıp `--disable-custom-kernels` eklemeniz yeterlidir, ancak CPU bu proje için önerilen platform olmadığından performans düşük olabilir.

**Not:** TGI, AMD Instinct MI210 ve MI250 GPU'ları destekler. Detaylar için [Desteklenen Donanım dokümantasyonuna](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus) bakınız. AMD GPU'ları kullanmak için yukarıdaki komut yerine şu komutu kullanınız: `docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model`.

Modellerinizi servise sunmak için tüm seçenekleri görmek isterseniz (kodda [burada](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs) veya CLI'da):

```
text-generation-launcher --help
```

### API dokümantasyonu

`text-generation-inference` REST API'sinin OpenAPI dokümantasyonunu `/docs` rotası üzerinden inceleyebilirsiniz.
Swagger UI şu adreste de mevcuttur: [https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference).

### Özel veya sınırlı model kullanımı

`text-generation-inference` tarafından kullanılan tokenı yapılandırmak için `HF_TOKEN` ortam değişkenini kullanabilirsiniz. Bu sayede korumalı kaynaklara erişim sağlayabilirsiniz.

Örneğin, sınırlı Llama V2 model varyantlarını sunmak istiyorsanız:

1. https://huggingface.co/settings/tokens adresine gidin
2. CLI READ tokenınızı kopyalayın
3. `HF_TOKEN=<tokenınız>` olarak dışa aktarın

veya Docker ile:

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # Docker konteyneri ile bir klasörü paylaşarak her çalıştırmada ağırlıkları indirmenizi önleyin
token=<CLI READ tokenınız>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### Paylaşılan Bellek (shm) hakkında not

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html), `PyTorch` tarafından dağıtık eğitim/çıkarım için kullanılan bir iletişim çerçevesidir. `text-generation-inference`, büyük dil modelleri için çıkarımı hızlandırmak amacıyla Tensör Paralelliği'ni etkinleştirmek için `NCCL` kullanır.

Bir `NCCL` grubundaki farklı cihazlar arasında veri paylaşmak için, NVLink veya PCI üzerinden peer-to-peer mümkün değilse, `NCCL` host belleğine geri dönebilir.

Konteynerin 1G Paylaşılan Bellek kullanmasına izin vermek ve SHM paylaşımını desteklemek için yukarıdaki komutta `--shm-size 1g` eklenmiştir.

Eğer `text-generation-inference`'i `Kubernetes` içinde çalıştırıyorsanız, aşağıdaki gibi bir hacim oluşturarak konteynere Paylaşılan Bellek ekleyebilirsiniz:

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

ve bunu `/dev/shm` olarak bağlayabilirsiniz.

Son olarak, `NCCL_SHM_DISABLE=1` ortam değişkenini kullanarak SHM paylaşımını devre dışı bırakabilirsiniz. Ancak bu performansı olumsuz etkiler.

### Dağıtık İzleme

`text-generation-inference`, OpenTelemetry kullanarak dağıtık izleme ile donatılmıştır. Bu özelliği kullanmak için `--otlp-endpoint` argümanı ile OTLP toplayıcı adresini belirtebilirsiniz. Varsayılan servis adı `--otlp-service-name` argümanı ile değiştirilebilir.

### Mimari

![TGI mimarisi](https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/huggingface/documentation-images/resolve/main/TGI.png)

TGI iç işleyişi hakkında Adyen tarafından detaylı blog yazısı: [TGI ile Ölçekli LLM çıkarımı (Martin Iglesias Goyanes - Adyen, 2024)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### Yerel kurulum

`text-generation-inference`'i yerel olarak da kurabilirsiniz.

İlk olarak repoyu klonlayın ve içine geçin:
```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

Sonra [Rust yükleyin](https://rustup.rs/) ve en az Python 3.9 ile bir Python sanal ortamı oluşturun, örneğin `conda` veya `python venv` kullanarak:

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

# conda kullanarak
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

# python venv kullanarak
python3 -m venv .venv
source .venv/bin/activate
```

Ayrıca Protoc'u yüklemeniz gerekebilir.

Linux üzerinde:

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

MacOS üzerinde, Homebrew kullanarak:

```shell
brew install protobuf
```

Sonra çalıştırın:

```shell
BUILD_EXTENSIONS=True make install # Depoyu ve CUDA çekirdekleriyle HF/transformer çatallanmasını kur
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**Not:** bazı makinelerde OpenSSL kütüphaneleri ve gcc de gerekebilir. Linux makinelerde şunu çalıştırın:

```shell
sudo apt-get install libssl-dev gcc -y
```

### Yerel kurulum (Nix)

Bir diğer seçenek de `text-generation-inference`'ı yerel olarak [Nix](https://nixos.org) kullanarak kurmaktır. Şu anda,
sadece CUDA GPU'lu x86_64 Linux üzerinde Nix desteklenmektedir. Nix kullanırken tüm bağımlılıklar
ikili önbellekten çekilebilir, böylece yerel olarak derleme gereksinimi ortadan kalkar.

İlk olarak [Cachix'i kurun ve Hugging Face önbelleğini etkinleştirin](https://app.cachix.org/cache/huggingface).
Önbellek kurulumu önemlidir, aksi halde Nix birçok bağımlılığı yerel olarak derleyecektir,
bu saatler sürebilir.

Bundan sonra TGI'yi `nix run` ile çalıştırabilirsiniz:

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**Not:** NixOS olmayan bir sistemde Nix kullanıyorsanız, CUDA sürücü kütüphanelerinin Nix paketleri tarafından görünür olması için [bazı sembolik bağlantılar oluşturmanız gerekir](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library).

TGI geliştirme için `impure` geliştirme kabuğunu kullanabilirsiniz:

```shell
nix develop .#impure

# Geliştirme kabuğu ilk kez başlatıldığında veya protobuf güncellendikten sonra sadece bir kez gereklidir.
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

Tüm geliştirme bağımlılıkları (cargo, Python, Torch vb.) bu geliştirme kabuğunda mevcuttur.

## Optimize Edilmiş Mimari

TGI, tüm modern modeller için optimize edilmiş modelleri kutudan çıkar çıkmaz sunacak şekilde çalışır. Bunlar [bu listede](https://huggingface.co/docs/text-generation-inference/supported_models) bulunabilir.

Diğer mimariler ise en iyi çaba temelinde şu yöntemlerle desteklenir:

`AutoModelForCausalLM.from_pretrained(<model>, device_map="auto")`

veya

`AutoModelForSeq2SeqLM.from_pretrained(<model>, device_map="auto")`



## Yerel Çalıştırma

### Çalıştırma

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### Kuantizasyon

Önceden kuantize edilmiş ağırlıkları (AWQ, GPTQ, Marlin) çalıştırabilir veya VRAM ihtiyacını azaltmak için bitsandbytes, EETQ, fp8 ile ağırlıkları anlık olarak kuantize edebilirsiniz:

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

4bit kuantizasyon, [bitsandbytes'tan NF4 ve FP4 veri tipleri](https://arxiv.org/pdf/2305.14314.pdf) kullanılarak mümkündür. `text-generation-launcher`'a komut satırı argümanı olarak `--quantize bitsandbytes-nf4` veya `--quantize bitsandbytes-fp4` verilerek etkinleştirilebilir.

Kuantizasyon hakkında daha fazla bilgi için [Kuantizasyon dokümantasyonuna](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization) bakınız.

## Geliştirme

```shell
make server-dev
make router-dev
```

## Test Etme

```shell
# python
make python-server-tests
make python-client-tests
# veya hem sunucu hem istemci testleri
make python-tests
# rust cargo testleri
make rust-tests
# entegrasyon testleri
make integration-tests
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---