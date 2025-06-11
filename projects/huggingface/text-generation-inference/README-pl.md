<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/Narsil/tgi_assets/resolve/main/thumbnail.png">
</a>

# Text Generation Inference

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API documentation" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

Serwer Rust, Python i gRPC do inferencji generowania tekstu. Używany w produkcji w [Hugging Face](https://huggingface.co) do zasilania Hugging Chat, Inference API oraz Inference Endpoints.

</div>

## Spis treści

  - [Rozpoczęcie pracy](#get-started)
    - [Docker](#docker)
    - [Dokumentacja API](#api-documentation)
    - [Używanie modelu prywatnego lub z ograniczonym dostępem](#using-a-private-or-gated-model)
    - [Uwaga o pamięci współdzielonej (shm)](#a-note-on-shared-memory-shm)
    - [Śledzenie rozproszone](#distributed-tracing)
    - [Architektura](#architecture)
    - [Instalacja lokalna](#local-install)
    - [Instalacja lokalna (Nix)](#local-install-nix)
  - [Zoptymalizowane architektury](#optimized-architectures)
  - [Uruchamianie lokalnie](#run-locally)
    - [Uruchomienie](#run)
    - [Kwantyzacja](#quantization)
  - [Rozwój](#develop)
  - [Testowanie](#testing)

Text Generation Inference (TGI) to zestaw narzędzi do wdrażania i serwowania dużych modeli językowych (LLM). TGI umożliwia wysokowydajne generowanie tekstu dla najpopularniejszych otwartoźródłowych LLM, w tym Llama, Falcon, StarCoder, BLOOM, GPT-NeoX oraz [więcej](https://huggingface.co/docs/text-generation-inference/supported_models). TGI implementuje wiele funkcji, takich jak:

- Prosty launcher do serwowania najpopularniejszych LLM
- Gotowość produkcyjna (śledzenie rozproszone z Open Telemetry, metryki Prometheus)
- Równoległość tensorowa dla szybszej inferencji na wielu GPU
- Strumieniowanie tokenów za pomocą Server-Sent Events (SSE)
- Ciągłe grupowanie przychodzących żądań dla zwiększenia całkowitej przepustowości
- [API Wiadomości](https://huggingface.co/docs/text-generation-inference/en/messages_api) kompatybilne z Open AI Chat Completion API
- Zoptymalizowany kod transformerów do inferencji wykorzystujący [Flash Attention](https://github.com/HazyResearch/flash-attention) oraz [Paged Attention](https://github.com/vllm-project/vllm) na najpopularniejszych architekturach
- Kwantyzacja z użyciem:
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- Ładowanie wag w formacie [Safetensors](https://github.com/huggingface/safetensors)
- Znakowanie wodne z [A Watermark for Large Language Models](https://arxiv.org/abs/2301.10226)
- Logits warper (skalowanie temperatury, top-p, top-k, kara za powtarzanie, więcej szczegółów w [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor))
- Sekwencje zatrzymania
- Prawdopodobieństwa logarytmiczne
- [Spekulacja](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) ~2x opóźnienia
- [Guidance/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance). Określ format wyjścia, aby przyspieszyć inferencję i upewnić się, że wyjście jest zgodne z określonymi specyfikacjami.
- Generowanie niestandardowych promptów: łatwe generowanie tekstu poprzez dostarczenie niestandardowych promptów kierujących wyjściem modelu
- Wsparcie fine-tuningu: wykorzystuj modele dopasowane do konkretnych zadań, aby osiągnąć wyższą dokładność i wydajność

### Wsparcie sprzętowe

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [Intel GPU](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## Rozpoczęcie pracy

### Docker

Szczegółowy przewodnik na start znajdziesz w [Quick Tour](https://huggingface.co/docs/text-generation-inference/quicktour). Najprostszym sposobem na rozpoczęcie jest użycie oficjalnego kontenera Docker:

```shell
model=HuggingFaceH4/zephyr-7b-beta
# udostępnij wolumen z kontenerem Docker, aby uniknąć pobierania wag przy każdym uruchomieniu
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

Następnie możesz wysyłać zapytania takie jak

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"What is Deep Learning?","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

Możesz również korzystać z [Messages API TGI](https://huggingface.co/docs/text-generation-inference/en/messages_api), aby uzyskać odpowiedzi kompatybilne z Open AI Chat Completion API.

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

**Uwaga:** Aby korzystać z GPU NVIDIA, musisz zainstalować [NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html). Zalecamy również używanie sterowników NVIDIA z wersją CUDA 12.2 lub wyższą. Aby uruchomić kontener Docker na maszynie bez GPU lub wsparcia CUDA, wystarczy usunąć flagę `--gpus all` i dodać `--disable-custom-kernels`. Należy jednak pamiętać, że CPU nie jest docelową platformą dla tego projektu, więc wydajność może być niższa.

**Uwaga:** TGI obsługuje GPU AMD Instinct MI210 i MI250. Szczegóły znajdują się w dokumentacji [Supported Hardware](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus). Aby używać GPU AMD, zamiast powyższej komendy użyj `docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model`.

Aby zobaczyć wszystkie opcje serwowania modeli (w [kodzie](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs) lub w CLI):
```
text-generation-launcher --help
```

### Dokumentacja API

Możesz zapoznać się z dokumentacją OpenAPI REST API `text-generation-inference` korzystając z trasy `/docs`.
Swagger UI jest także dostępny pod adresem: [https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference).

### Używanie modelu prywatnego lub z ograniczonym dostępem

Masz możliwość wykorzystania zmiennej środowiskowej `HF_TOKEN` do skonfigurowania tokena używanego przez
`text-generation-inference`. Pozwala to na dostęp do zasobów chronionych.

Na przykład, jeśli chcesz serwować modele gated Llama V2:

1. Przejdź do https://huggingface.co/settings/tokens
2. Skopiuj swój token CLI READ
3. Eksportuj `HF_TOKEN=<twój token CLI READ>`

lub z Dockerem:

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # udostępnij wolumen z kontenerem Docker, aby uniknąć pobierania wag przy każdym uruchomieniu
token=<twój token cli READ>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### Uwaga o pamięci współdzielonej (shm)

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html) to framework komunikacyjny używany przez
`PyTorch` do rozproszonego trenowania/inferencji. `text-generation-inference` wykorzystuje
`NCCL` do umożliwienia Tensor Parallelism, co znacznie przyspiesza inferencję dla dużych modeli językowych.

Aby współdzielić dane między różnymi urządzeniami w grupie `NCCL`, `NCCL` może używać pamięci hosta, jeśli
peer-to-peer za pomocą NVLink lub PCI nie jest możliwe.

Aby umożliwić kontenerowi użycie 1 GB pamięci współdzielonej i wsparcie udostępniania SHM, dodajemy `--shm-size 1g` w powyższej komendzie.

Jeśli uruchamiasz `text-generation-inference` w środowisku `Kubernetes`, możesz dodać pamięć współdzieloną do kontenera
tworząc wolumen z:

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

i montując go pod `/dev/shm`.

Możesz też wyłączyć udostępnianie SHM używając zmiennej środowiskowej `NCCL_SHM_DISABLE=1`. Należy jednak zauważyć, że
wpłynie to na wydajność.

### Śledzenie rozproszone

`text-generation-inference` jest instrumentowany do śledzenia rozproszonego przy użyciu OpenTelemetry. Możesz korzystać z tej funkcji
ustawiając adres kolektora OTLP za pomocą argumentu `--otlp-endpoint`. Domyślną nazwę usługi można
nadpisać argumentem `--otlp-service-name`.

### Architektura

![TGI architecture](https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/huggingface/documentation-images/resolve/main/TGI.png)

Szczegółowy wpis na blogu Adyen o działaniu wewnętrznym TGI: [LLM inference at scale with TGI (Martin Iglesias Goyanes - Adyen, 2024)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### Instalacja lokalna

Możesz także zdecydować się na lokalną instalację `text-generation-inference`.

Najpierw sklonuj repozytorium i przejdź do katalogu:
```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

Następnie [zainstaluj Rust](https://rustup.rs/) i utwórz wirtualne środowisko Pythona z co najmniej
Pythonem 3.9, np. używając `conda` lub `python venv`:

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

# używając conda
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

# używając python venv
python3 -m venv .venv
source .venv/bin/activate
```

Może być również konieczne zainstalowanie Protoc.

Na Linuksie:

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

Na MacOS, używając Homebrew:

```shell
brew install protobuf
```

Następnie uruchom:

```shell
BUILD_EXTENSIONS=True make install # Zainstaluj repozytorium i forka HF/transformer z kernelami CUDA
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**Uwaga:** na niektórych maszynach mogą być również potrzebne biblioteki OpenSSL oraz gcc. Na maszynach z Linuksem uruchom:

```shell
sudo apt-get install libssl-dev gcc -y
```

### Lokalna instalacja (Nix)

Inną opcją jest lokalna instalacja `text-generation-inference` za pomocą [Nix](https://nixos.org). Obecnie
wspieramy tylko Nix na x86_64 Linux z GPU CUDA. Korzystając z Nix, wszystkie zależności mogą
być pobierane z binarnego cache, co eliminuje potrzebę ich lokalnej kompilacji.

Najpierw postępuj zgodnie z instrukcjami, aby [zainstalować Cachix i włączyć cache Hugging Face](https://app.cachix.org/cache/huggingface).
Konfiguracja cache jest ważna, inaczej Nix będzie budował wiele zależności lokalnie, co może zająć godziny.

Po tym możesz uruchomić TGI za pomocą `nix run`:

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**Uwaga:** jeśli używasz Nix na systemie innym niż NixOS, musisz [utworzyć pewne dowiązania symboliczne](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library),
aby biblioteki sterownika CUDA były widoczne dla pakietów Nix.

Do rozwoju TGI możesz użyć powłoki developerskiej `impure`:

```shell
nix develop .#impure

# Potrzebne tylko przy pierwszym uruchomieniu powłoki developerskiej lub po aktualizacji protobuf.
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

Wszystkie zależności developerskie (cargo, Python, Torch) itd. są dostępne w tej powłoce.

## Zoptymalizowane architektury

TGI działa od razu, aby serwować zoptymalizowane modele dla wszystkich nowoczesnych modeli. Można je znaleźć na [tej liście](https://huggingface.co/docs/text-generation-inference/supported_models).

Inne architektury są wspierane na zasadzie najlepszych starań przy użyciu:

`AutoModelForCausalLM.from_pretrained(<model>, device_map="auto")`

lub

`AutoModelForSeq2SeqLM.from_pretrained(<model>, device_map="auto")`



## Uruchom lokalnie

### Uruchomienie

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### Kwantyzacja

Możesz także uruchomić prekwantyzowane wagi (AWQ, GPTQ, Marlin) lub kwantyzować wagi na bieżąco za pomocą bitsandbytes, EETQ, fp8, aby zmniejszyć wymagania VRAM:

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

Kwantyzacja 4-bitowa jest dostępna przy użyciu [typów danych NF4 i FP4 z bitsandbytes](https://arxiv.org/pdf/2305.14314.pdf). Można ją włączyć, podając `--quantize bitsandbytes-nf4` lub `--quantize bitsandbytes-fp4` jako argument wiersza poleceń do `text-generation-launcher`.

Więcej o kwantyzacji można przeczytać w [dokumentacji Kwantyzacji](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization).

## Rozwój

```shell
make server-dev
make router-dev
```

## Testowanie

```shell
# python
make python-server-tests
make python-client-tests
# lub testy serwera i klienta razem
make python-tests
# testy Rust cargo
make rust-tests
# testy integracyjne
make integration-tests
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---