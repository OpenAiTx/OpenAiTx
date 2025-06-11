<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://huggingface.co/datasets/Narsil/tgi_assets/resolve/main/thumbnail.png">
</a>

# Tekstgeneratie Inference

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API-documentatie" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

Een Rust-, Python- en gRPC-server voor tekstgeneratie-inference. Wordt in productie gebruikt bij [Hugging Face](https://huggingface.co)
om Hugging Chat, de Inference API en Inference Endpoints aan te drijven.

</div>

## Inhoudsopgave

  - [Aan de slag](#get-started)
    - [Docker](#docker)
    - [API-documentatie](#api-documentation)
    - [Een privé- of afgeschermd model gebruiken](#using-a-private-or-gated-model)
    - [Een opmerking over gedeeld geheugen (shm)](#a-note-on-shared-memory-shm)
    - [Gedistribueerde tracing](#distributed-tracing)
    - [Architectuur](#architecture)
    - [Lokale installatie](#local-install)
    - [Lokale installatie (Nix)](#local-install-nix)
  - [Geoptimaliseerde architecturen](#optimized-architectures)
  - [Lokaal uitvoeren](#run-locally)
    - [Uitvoeren](#run)
    - [Quantisatie](#quantization)
  - [Ontwikkelen](#develop)
  - [Testen](#testing)

Tekstgeneratie Inference (TGI) is een toolkit voor het implementeren en bedienen van Large Language Models (LLM's). TGI maakt het mogelijk om tekstgeneratie met hoge prestaties uit te voeren voor de populairste open-source LLM's, waaronder Llama, Falcon, StarCoder, BLOOM, GPT-NeoX en [meer](https://huggingface.co/docs/text-generation-inference/supported_models). TGI implementeert vele functies, zoals:

- Eenvoudige launcher om de populairste LLM's te bedienen
- Productieklaar (gedistribueerde tracing met Open Telemetry, Prometheus-metrics)
- Tensor Parallelisme voor snellere inference op meerdere GPU's
- Token-streaming met Server-Sent Events (SSE)
- Continue batching van binnenkomende verzoeken voor verhoogde totale doorvoer
- [Messages API](https://huggingface.co/docs/text-generation-inference/en/messages_api) compatibel met Open AI Chat Completion API
- Geoptimaliseerde transformers-code voor inference met [Flash Attention](https://github.com/HazyResearch/flash-attention) en [Paged Attention](https://github.com/vllm-project/vllm) op de populairste architecturen
- Quantisatie met:
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- [Safetensors](https://github.com/huggingface/safetensors) gewichtsladen
- Watermerken met [A Watermark for Large Language Models](https://arxiv.org/abs/2301.10226)
- Logits warper (temperatuurschaling, top-p, top-k, herhalingsstraf, meer details zie [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor))
- Stopreeksen
- Log waarschijnlijkheden
- [Speculatie](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) ~2x latentie
- [Guidance/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance). Specificeer uitvoerformaat om inference te versnellen en zorg ervoor dat de uitvoer geldig is volgens bepaalde specificaties.
- Aangepaste Prompt Generatie: genereer eenvoudig tekst door aangepaste prompts te gebruiken om de output van het model te sturen
- Fine-tuning ondersteuning: gebruik fijn-afgestelde modellen voor specifieke taken om hogere nauwkeurigheid en prestaties te bereiken

### Hardware ondersteuning

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [Intel GPU](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## Aan de slag

### Docker

Voor een gedetailleerde startgids, zie de [Quick Tour](https://huggingface.co/docs/text-generation-inference/quicktour). De gemakkelijkste manier om te beginnen is met de officiële Docker-container:

```shell
model=HuggingFaceH4/zephyr-7b-beta
# deel een volume met de Docker-container om te voorkomen dat gewichten bij elke run worden gedownload
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

En dan kun je verzoeken maken zoals

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"Wat is Deep Learning?","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

Je kunt ook gebruikmaken van de [Messages API van TGI](https://huggingface.co/docs/text-generation-inference/en/messages_api) om antwoorden te krijgen die compatibel zijn met de Open AI Chat Completion API.

```bash
curl localhost:8080/v1/chat/completions \
    -X POST \
    -d '{
  "model": "tgi",
  "messages": [
    {
      "role": "system",
      "content": "Je bent een behulpzame assistent."
    },
    {
      "role": "user",
      "content": "Wat is deep learning?"
    }
  ],
  "stream": true,
  "max_tokens": 20
}' \
    -H 'Content-Type: application/json'
```

**Opmerking:** Om NVIDIA GPU's te gebruiken, moet je de [NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html) installeren. We raden ook aan NVIDIA-drivers met CUDA versie 12.2 of hoger te gebruiken. Voor het draaien van de Docker-container op een machine zonder GPU's of CUDA-ondersteuning is het voldoende om de `--gpus all` vlag te verwijderen en `--disable-custom-kernels` toe te voegen. Houd er rekening mee dat CPU niet het beoogde platform is voor dit project, dus de prestaties kunnen ondermaats zijn.

**Opmerking:** TGI ondersteunt AMD Instinct MI210 en MI250 GPU's. Details zijn te vinden in de [Supported Hardware-documentatie](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus). Om AMD GPU's te gebruiken, gebruik in plaats van bovenstaande commando:

```shell
docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model
```

Om alle opties te zien om je modellen te bedienen (in de [code](https://raw.githubusercontent.com/huggingface/text-generation-inference/main/launcher/src/main.rs) of via de cli):
```
text-generation-launcher --help
```

### API-documentatie

Je kunt de OpenAPI-documentatie van de `text-generation-inference` REST API raadplegen via de `/docs` route.
De Swagger UI is ook beschikbaar op: [https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference).

### Een privé- of afgeschermd model gebruiken

Je hebt de optie om de omgevingsvariabele `HF_TOKEN` te gebruiken voor het configureren van de token die
door `text-generation-inference` wordt gebruikt. Dit stelt je in staat om toegang te krijgen tot beveiligde bronnen.

Als je bijvoorbeeld de afgeschermde Llama V2 modelvarianten wilt bedienen:

1. Ga naar https://huggingface.co/settings/tokens
2. Kopieer je CLI READ-token
3. Exporteer `HF_TOKEN=<jouw CLI READ-token>`

of met Docker:

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # deel een volume met de Docker-container om te voorkomen dat gewichten bij elke run worden gedownload
token=<jouw cli READ-token>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### Een opmerking over gedeeld geheugen (shm)

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html) is een communicatieframework dat door
`PyTorch` wordt gebruikt voor gedistribueerde training/inference. `text-generation-inference` maakt
gebruik van `NCCL` om Tensor Parallelisme mogelijk te maken, waardoor inference voor grote taalmodellen aanzienlijk wordt versneld.

Om data te delen tussen de verschillende apparaten van een `NCCL` groep, kan `NCCL` terugvallen op het gebruik van het hostgeheugen als
peer-to-peer via NVLink of PCI niet mogelijk is.

Om de container 1G gedeeld geheugen te laten gebruiken en SHM-sharing te ondersteunen, voegen we `--shm-size 1g` toe aan het bovenstaande commando.

Als je `text-generation-inference` binnen `Kubernetes` draait, kun je gedeeld geheugen aan de container toevoegen door
een volume te maken met:

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

en dit te mounten op `/dev/shm`.

Tot slot kun je SHM-sharing ook uitschakelen door de omgevingsvariabele `NCCL_SHM_DISABLE=1` te gebruiken. Houd er echter rekening mee dat
dit de prestaties zal beïnvloeden.

### Gedistribueerde tracing

`text-generation-inference` is geïnstrumenteerd met gedistribueerde tracing via OpenTelemetry. Je kunt deze functie
gebruiken door het adres van een OTLP-collector in te stellen met het argument `--otlp-endpoint`. De standaard servicenaam kan worden
overschreven met het argument `--otlp-service-name`.

### Architectuur

![TGI architectuur](https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/TGI.png)

Uitgebreide blogpost door Adyen over de interne werking van TGI: [LLM inference at scale with TGI (Martin Iglesias Goyanes - Adyen, 2024)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### Lokale installatie

Je kunt er ook voor kiezen om `text-generation-inference` lokaal te installeren.

Clone eerst de repository en ga ernaartoe:
```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

Installeer vervolgens [Rust](https://rustup.rs/) en maak een Python virtuele omgeving aan met ten minste
Python 3.9, bijvoorbeeld met `conda` of `python venv`:

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

# met conda
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

# met python venv
python3 -m venv .venv
source .venv/bin/activate
```

Mogelijk moet je ook Protoc installeren.

Op Linux:

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

Op MacOS, met Homebrew:

```shell
brew install protobuf
```

Voer daarna uit:

```shell
BUILD_EXTENSIONS=True make install # Installeer repository en HF/transformers fork met CUDA kernels
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**Opmerking:** op sommige systemen heb je mogelijk ook de OpenSSL libraries en gcc nodig. Op Linux systemen, voer uit:

```shell
sudo apt-get install libssl-dev gcc -y
```

### Lokale installatie (Nix)

Een andere optie is om `text-generation-inference` lokaal te installeren met [Nix](https://nixos.org). Momenteel
ondersteunen we alleen Nix op x86_64 Linux met CUDA GPU's. Bij gebruik van Nix kunnen alle dependencies
worden gedownload uit een binaire cache, waardoor lokaal bouwen niet nodig is.

Volg eerst de instructies om [Cachix te installeren en de Hugging Face cache in te schakelen](https://app.cachix.org/cache/huggingface).
Het instellen van de cache is belangrijk, anders zal Nix veel dependencies lokaal bouwen,
wat uren kan duren.

Daarna kun je TGI starten met `nix run`:

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**Opmerking:** wanneer je Nix gebruikt op een niet-NixOS systeem, moet je [enkele symlinks aanmaken](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library)
om de CUDA driver libraries zichtbaar te maken voor Nix pakketten.

Voor TGI ontwikkeling kun je de `impure` dev shell gebruiken:

```shell
nix develop .#impure

# Alleen nodig de eerste keer dat de devshell wordt gestart of na update van protobuf.
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

Alle ontwikkel-dependencies (cargo, Python, Torch), etc. zijn beschikbaar in deze
dev shell.

## Geoptimaliseerde architecturen

TGI werkt direct out-of-the-box om geoptimaliseerde modellen te serveren voor alle moderne modellen. Deze zijn te vinden in [deze lijst](https://huggingface.co/docs/text-generation-inference/supported_models).

Andere architecturen worden op een best-effort basis ondersteund met:

`AutoModelForCausalLM.from_pretrained(<model>, device_map="auto")`

of

`AutoModelForSeq2SeqLM.from_pretrained(<model>, device_map="auto")`



## Lokale uitvoering

### Run

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### Kwantisatie

Je kunt ook vooraf gekwantiseerde gewichten draaien (AWQ, GPTQ, Marlin) of gewichten on-the-fly kwantiseren met bitsandbytes, EETQ, fp8, om het VRAM-verbruik te verlagen:

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

4bit kwantisatie is beschikbaar met de [NF4 en FP4 datatypes van bitsandbytes](https://arxiv.org/pdf/2305.14314.pdf). Dit kan worden ingeschakeld door `--quantize bitsandbytes-nf4` of `--quantize bitsandbytes-fp4` mee te geven als commandoregelargument aan `text-generation-launcher`.

Lees meer over kwantisatie in de [Kwantisatie documentatie](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization).

## Ontwikkeling

```shell
make server-dev
make router-dev
```

## Testen

```shell
# python
make python-server-tests
make python-client-tests
# of zowel server- als client-tests
make python-tests
# rust cargo tests
make rust-tests
# integratietests
make integration-tests
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---