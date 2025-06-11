<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://huggingface.co/datasets/Narsil/tgi_assets/resolve/main/thumbnail.png">
</a>

# Inferenza per Generazione di Testo

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API documentation" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

Un server Rust, Python e gRPC per l'inferenza nella generazione di testo. Utilizzato in produzione da [Hugging Face](https://huggingface.co)
per alimentare Hugging Chat, l'API di Inferenza e gli Endpoint di Inferenza.

</div>

## Indice

  - [Iniziare](#get-started)
    - [Docker](#docker)
    - [Documentazione API](#api-documentation)
    - [Utilizzo di un modello privato o con accesso limitato](#using-a-private-or-gated-model)
    - [Una nota sulla Memoria Condivisa (shm)](#a-note-on-shared-memory-shm)
    - [Tracciamento Distribuito](#distributed-tracing)
    - [Architettura](#architecture)
    - [Installazione locale](#local-install)
    - [Installazione locale (Nix)](#local-install-nix)
  - [Architetture ottimizzate](#optimized-architectures)
  - [Esecuzione locale](#run-locally)
    - [Esecuzione](#run)
    - [Quantizzazione](#quantization)
  - [Sviluppo](#develop)
  - [Testing](#testing)

Inferenza per Generazione di Testo (TGI) è un toolkit per il deployment e la messa in servizio di Modelli di Linguaggio di Grandi Dimensioni (LLM). TGI consente una generazione di testo ad alte prestazioni per i LLM open-source più popolari, tra cui Llama, Falcon, StarCoder, BLOOM, GPT-NeoX e [altri](https://huggingface.co/docs/text-generation-inference/supported_models). TGI implementa molte funzionalità, come:

- Launcher semplice per servire i LLM più popolari
- Pronto per la produzione (tracciamento distribuito con Open Telemetry, metriche Prometheus)
- Parallelismo Tensoriale per inferenze più veloci su più GPU
- Streaming di token usando Server-Sent Events (SSE)
- Batch continuo delle richieste in ingresso per aumentare la capacità totale
- [Messages API](https://huggingface.co/docs/text-generation-inference/en/messages_api) compatibile con l'Open AI Chat Completion API
- Codice transformers ottimizzato per inferenza utilizzando [Flash Attention](https://github.com/HazyResearch/flash-attention) e [Paged Attention](https://github.com/vllm-project/vllm) sulle architetture più popolari
- Quantizzazione con:
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- Caricamento pesi con [Safetensors](https://github.com/huggingface/safetensors)
- Watermarking con [A Watermark for Large Language Models](https://arxiv.org/abs/2301.10226)
- Logits warper (scalatura della temperatura, top-p, top-k, penalità di ripetizione, maggiori dettagli su [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor))
- Sequenze di stop
- Probabilità logaritmiche
- [Speculation](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) ~2x latenza
- [Guidance/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance). Specifica il formato di output per velocizzare l'inferenza e assicurare che l'output sia valido secondo alcune specifiche.
- Generazione di Prompt Personalizzati: genera facilmente testo fornendo prompt personalizzati per guidare l'output del modello
- Supporto al Fine-tuning: utilizza modelli fine-tuned per compiti specifici per ottenere maggiore accuratezza e prestazioni

### Supporto hardware

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [Intel GPU](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## Iniziare

### Docker

Per una guida dettagliata all'avvio, si veda il [Quick Tour](https://huggingface.co/docs/text-generation-inference/quicktour). Il modo più semplice per iniziare è utilizzare il container Docker ufficiale:

```shell
model=HuggingFaceH4/zephyr-7b-beta
# condividi un volume con il container Docker per evitare di scaricare i pesi ad ogni esecuzione
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

E poi puoi effettuare richieste come

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"Che cos\'è il Deep Learning?","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

Puoi anche usare la [Messages API di TGI](https://huggingface.co/docs/text-generation-inference/en/messages_api) per ottenere risposte compatibili con l'Open AI Chat Completion API.

```bash
curl localhost:8080/v1/chat/completions \
    -X POST \
    -d '{
  "model": "tgi",
  "messages": [
    {
      "role": "system",
      "content": "Sei un assistente utile."
    },
    {
      "role": "user",
      "content": "Che cos\'è il deep learning?"
    }
  ],
  "stream": true,
  "max_tokens": 20
}' \
    -H 'Content-Type: application/json'
```

**Nota:** Per utilizzare le GPU NVIDIA, è necessario installare il [NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html). Raccomandiamo inoltre di usare driver NVIDIA con versione CUDA 12.2 o superiore. Per eseguire il container Docker su una macchina senza GPU o supporto CUDA, è sufficiente rimuovere il flag `--gpus all` e aggiungere `--disable-custom-kernels`, si noti però che la CPU non è la piattaforma prevista per questo progetto, quindi le prestazioni potrebbero essere inferiori.

**Nota:** TGI supporta le GPU AMD Instinct MI210 e MI250. I dettagli si trovano nella [documentazione Hardware Supportato](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus). Per usare GPU AMD, usare `docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model` invece del comando sopra.

Per vedere tutte le opzioni per servire i tuoi modelli (nel [codice](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs) o nella CLI):
```
text-generation-launcher --help
```

### Documentazione API

Puoi consultare la documentazione OpenAPI della REST API `text-generation-inference` usando la rotta `/docs`.
La UI Swagger è anche disponibile su: [https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference).

### Utilizzo di un modello privato o con accesso limitato

Hai la possibilità di utilizzare la variabile d'ambiente `HF_TOKEN` per configurare il token utilizzato da
`text-generation-inference`. Questo ti permette di accedere a risorse protette.

Ad esempio, se vuoi servire le varianti del modello Llama V2 con accesso limitato:

1. Vai su https://huggingface.co/settings/tokens
2. Copia il tuo token READ CLI
3. Esporta `HF_TOKEN=<tuo token READ CLI>`

oppure con Docker:

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # condividi un volume con il container Docker per evitare di scaricare i pesi ad ogni esecuzione
token=<tuo token READ CLI>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### Una nota sulla Memoria Condivisa (shm)

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html) è un framework di comunicazione usato da
`PyTorch` per fare training/inferenza distribuita. `text-generation-inference` fa
uso di `NCCL` per abilitare il Parallelismo Tensoriale e velocizzare drasticamente l'inferenza per i modelli di linguaggio grandi.

Per condividere dati tra i diversi dispositivi di un gruppo `NCCL`, `NCCL` potrebbe ricorrere all'uso della memoria host se
la comunicazione peer-to-peer tramite NVLink o PCI non è possibile.

Per permettere al container di usare 1G di Memoria Condivisa e supportare la condivisione SHM, aggiungiamo `--shm-size 1g` nel comando sopra.

Se stai eseguendo `text-generation-inference` dentro `Kubernetes`, puoi anche aggiungere Memoria Condivisa al container creando un volume con:

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

e montandolo su `/dev/shm`.

Infine, puoi anche disabilitare la condivisione SHM usando la variabile d'ambiente `NCCL_SHM_DISABLE=1`. Tuttavia, nota che
questo influirà sulle prestazioni.

### Tracciamento Distribuito

`text-generation-inference` è strumentato con tracciamento distribuito usando OpenTelemetry. Puoi usare questa funzionalità
impostando l'indirizzo di un collector OTLP con l'argomento `--otlp-endpoint`. Il nome del servizio di default può essere
sovrascritto con l'argomento `--otlp-service-name`

### Architettura

![Architettura TGI](https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/TGI.png)

Dettagliato post sul blog di Adyen sul funzionamento interno di TGI: [Inferenza LLM su larga scala con TGI (Martin Iglesias Goyanes - Adyen, 2024)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### Installazione locale

Puoi anche scegliere di installare `text-generation-inference` localmente.

Prima clona il repository e spostati nella sua directory:
```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

Quindi [installa Rust](https://rustup.rs/) e crea un ambiente virtuale Python con almeno
Python 3.9, ad esempio usando `conda` o `python venv`:

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

# usando conda
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

# usando python venv
python3 -m venv .venv
source .venv/bin/activate
```

Potresti anche dover installare Protoc.

Su Linux:

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://raw.githubusercontent.com/huggingface/text-generation-inference/main/https://github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

Su MacOS, usando Homebrew:

```shell
brew install protobuf
```

Quindi esegui:

```shell
BUILD_EXTENSIONS=True make install # Installa il repository e il fork HF/transformer con kernel CUDA
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**Nota:** su alcune macchine, potresti anche aver bisogno delle librerie OpenSSL e gcc. Su macchine Linux, esegui:

```shell
sudo apt-get install libssl-dev gcc -y
```

### Installazione locale (Nix)

Un'altra opzione è installare `text-generation-inference` localmente usando [Nix](https://nixos.org). Attualmente,
supportiamo solo Nix su Linux x86_64 con GPU CUDA. Quando si usa Nix, tutte le dipendenze possono
essere scaricate da una cache binaria, eliminando la necessità di compilarle localmente.

Per prima cosa segui le istruzioni per [installare Cachix e abilitare la cache Hugging Face](https://app.cachix.org/cache/huggingface).
Configurare la cache è importante, altrimenti Nix compilerà molte dipendenze
localmente, cosa che può richiedere ore.

Dopo di che puoi eseguire TGI con `nix run`:

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**Nota:** quando usi Nix su un sistema non NixOS, devi [creare alcuni symlink](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library)
per rendere visibili le librerie del driver CUDA ai pacchetti Nix.

Per lo sviluppo TGI, puoi usare la shell dev `impure`:

```shell
nix develop .#impure

# Necessario solo la prima volta che si avvia la devshell o dopo aver aggiornato protobuf.
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

Tutte le dipendenze di sviluppo (cargo, Python, Torch), ecc. sono disponibili in questa
dev shell.

## Architetture ottimizzate

TGI funziona immediatamente per servire modelli ottimizzati per tutti i modelli moderni. Possono essere trovati in [questa lista](https://huggingface.co/docs/text-generation-inference/supported_models).

Altre architetture sono supportate a livello di miglior sforzo usando:

`AutoModelForCausalLM.from_pretrained(<model>, device_map="auto")`

o

`AutoModelForSeq2SeqLM.from_pretrained(<model>, device_map="auto")`



## Esecuzione locale

### Esegui

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### Quantizzazione

Puoi anche eseguire pesi pre-quantizzati (AWQ, GPTQ, Marlin) o quantizzare i pesi al volo con bitsandbytes, EETQ, fp8, per ridurre il requisito di VRAM:

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

La quantizzazione a 4bit è disponibile usando i [tipi di dato NF4 e FP4 di bitsandbytes](https://arxiv.org/pdf/2305.14314.pdf). Può essere abilitata fornendo `--quantize bitsandbytes-nf4` o `--quantize bitsandbytes-fp4` come argomento da linea di comando a `text-generation-launcher`.

Leggi di più sulla quantizzazione nella [documentazione sulla Quantizzazione](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization).

## Sviluppo

```shell
make server-dev
make router-dev
```

## Test

```shell
# python
make python-server-tests
make python-client-tests
# o entrambi i test server e client
make python-tests
# test cargo rust
make rust-tests
# test di integrazione
make integration-tests
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---