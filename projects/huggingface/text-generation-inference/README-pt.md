<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://huggingface.co/datasets/Narsil/tgi_assets/resolve/main/thumbnail.png">
</a>

# Inferência de Geração de Texto

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API documentation" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

Um servidor em Rust, Python e gRPC para inferência de geração de texto. Usado em produção na [Hugging Face](https://huggingface.co) para alimentar o Hugging Chat, a API de Inferência e Endpoints de Inferência.

</div>

## Índice

  - [Começando](#get-started)
    - [Docker](#docker)
    - [Documentação da API](#api-documentation)
    - [Usando um modelo privado ou restrito](#using-a-private-or-gated-model)
    - [Uma nota sobre Memória Compartilhada (shm)](#a-note-on-shared-memory-shm)
    - [Rastreamento Distribuído](#distributed-tracing)
    - [Arquitetura](#architecture)
    - [Instalação local](#local-install)
    - [Instalação local (Nix)](#local-install-nix)
  - [Arquiteturas otimizadas](#optimized-architectures)
  - [Execução local](#run-locally)
    - [Executar](#run)
    - [Quantização](#quantization)
  - [Desenvolvimento](#develop)
  - [Testes](#testing)

Inferência de Geração de Texto (TGI) é um conjunto de ferramentas para implantar e servir Modelos de Linguagem Grande (LLMs). O TGI permite geração de texto de alto desempenho para os LLMs open-source mais populares, incluindo Llama, Falcon, StarCoder, BLOOM, GPT-NeoX e [mais](https://huggingface.co/docs/text-generation-inference/supported_models). O TGI implementa muitos recursos, tais como:

- Inicializador simples para servir os LLMs mais populares
- Pronto para produção (rastreamento distribuído com Open Telemetry, métricas Prometheus)
- Paralelismo Tensorial para inferência mais rápida em múltiplas GPUs
- Streaming de tokens usando Server-Sent Events (SSE)
- Agrupamento contínuo de requisições para maior throughput total
- [API de Mensagens](https://huggingface.co/docs/text-generation-inference/en/messages_api) compatível com a API de Chat Completion da OpenAI
- Código otimizado de transformers para inferência usando [Flash Attention](https://github.com/HazyResearch/flash-attention) e [Paged Attention](https://github.com/vllm-project/vllm) nas arquiteturas mais populares
- Quantização com:
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- Carregamento de pesos com [Safetensors](https://github.com/huggingface/safetensors)
- Marcação d'água com [Uma Marca d'água para Modelos de Linguagem Grande](https://arxiv.org/abs/2301.10226)
- Warper de logits (escalonamento de temperatura, top-p, top-k, penalidade de repetição, mais detalhes em [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor))
- Sequências de parada
- Probabilidades logarítmicas
- [Especulação](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) ~2x redução de latência
- [Guidance/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance). Especifique o formato de saída para acelerar a inferência e garantir que a saída seja válida segundo algumas especificações.
- Geração de Prompt Personalizado: Gere texto facilmente fornecendo prompts personalizados para guiar a saída do modelo
- Suporte a Fine-tuning: Utilize modelos fine-tunados para tarefas específicas para alcançar maior precisão e desempenho

### Suporte a hardware

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [GPU Intel](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## Começando

### Docker

Para um guia detalhado de início rápido, veja o [Tour Rápido](https://huggingface.co/docs/text-generation-inference/quicktour). A forma mais fácil de começar é usando o container Docker oficial:

```shell
model=HuggingFaceH4/zephyr-7b-beta
# compartilhe um volume com o container Docker para evitar baixar os pesos a cada execução
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

E então você pode fazer requisições como

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"O que é Deep Learning?","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

Você também pode usar a [API de Mensagens do TGI](https://huggingface.co/docs/text-generation-inference/en/messages_api) para obter respostas compatíveis com a API de Chat Completion da OpenAI.

```bash
curl localhost:8080/v1/chat/completions \
    -X POST \
    -d '{
  "model": "tgi",
  "messages": [
    {
      "role": "system",
      "content": "Você é um assistente útil."
    },
    {
      "role": "user",
      "content": "O que é deep learning?"
    }
  ],
  "stream": true,
  "max_tokens": 20
}' \
    -H 'Content-Type: application/json'
```

**Nota:** Para usar GPUs NVIDIA, você precisa instalar o [NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html). Também recomendamos usar drivers NVIDIA com versão CUDA 12.2 ou superior. Para executar o container Docker em uma máquina sem GPUs ou suporte CUDA, basta remover a flag `--gpus all` e adicionar `--disable-custom-kernels`, note que CPU não é a plataforma ideal para este projeto, portanto o desempenho pode ser inferior.

**Nota:** O TGI suporta GPUs AMD Instinct MI210 e MI250. Detalhes podem ser encontrados na [documentação de Hardware Suportado](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus). Para usar GPUs AMD, utilize `docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model` em vez do comando acima.

Para ver todas as opções para servir seus modelos (no [código](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs) ou na CLI):
```
text-generation-launcher --help
```

### Documentação da API

Você pode consultar a documentação OpenAPI da API REST `text-generation-inference` usando a rota `/docs`.
A interface Swagger UI também está disponível em: [https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference).

### Usando um modelo privado ou restrito

Você tem a opção de utilizar a variável de ambiente `HF_TOKEN` para configurar o token usado pelo
`text-generation-inference`. Isso permite acessar recursos protegidos.

Por exemplo, se você deseja servir as variantes restritas do modelo Llama V2:

1. Vá para https://huggingface.co/settings/tokens
2. Copie seu token READ para CLI
3. Exporte `HF_TOKEN=<seu token READ para CLI>`

ou com Docker:

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # compartilhe um volume com o container Docker para evitar baixar os pesos a cada execução
token=<seu token READ para CLI>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### Uma nota sobre Memória Compartilhada (shm)

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html) é um framework de comunicação usado pelo
`PyTorch` para realizar treinamento/inferência distribuída. O `text-generation-inference` faz
uso do `NCCL` para habilitar Paralelismo Tensorial e acelerar dramaticamente a inferência para modelos de linguagem grandes.

Para compartilhar dados entre os diferentes dispositivos de um grupo `NCCL`, o `NCCL` pode recorrer ao uso da memória do host se
peer-to-peer usando NVLink ou PCI não for possível.

Para permitir que o container use 1G de Memória Compartilhada e suporte compartilhamento SHM, adicionamos `--shm-size 1g` no comando acima.

Se você estiver executando `text-generation-inference` dentro do `Kubernetes`, você também pode adicionar Memória Compartilhada ao container criando um volume com:

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

e montando-o em `/dev/shm`.

Por fim, você também pode desabilitar o compartilhamento SHM usando a variável de ambiente `NCCL_SHM_DISABLE=1`. No entanto, note que isso impactará o desempenho.

### Rastreamento Distribuído

O `text-generation-inference` é instrumentado com rastreamento distribuído usando OpenTelemetry. Você pode usar esse recurso
definindo o endereço para um coletor OTLP com o argumento `--otlp-endpoint`. O nome do serviço padrão pode ser
substituído com o argumento `--otlp-service-name`

### Arquitetura

![Arquitetura TGI](https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/TGI.png)

Blogpost detalhado por Adyen sobre o funcionamento interno do TGI: [Inferência LLM em escala com TGI (Martin Iglesias Goyanes - Adyen, 2024)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### Instalação local

Você também pode optar por instalar o `text-generation-inference` localmente.

Primeiro clone o repositório e entre nele:
```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

Então [instale o Rust](https://rustup.rs/) e crie um ambiente virtual Python com pelo menos
Python 3.9, por exemplo usando `conda` ou `python venv`:

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

# usando conda
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

# usando python venv
python3 -m venv .venv
source .venv/bin/activate
```

Você também pode precisar instalar o Protoc.

No Linux:

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

No MacOS, usando Homebrew:

```shell
brew install protobuf
```

Então execute:

```shell
BUILD_EXTENSIONS=True make install # Instala o repositório e fork HF/transformer com kernels CUDA
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**Nota:** em algumas máquinas, você também pode precisar das bibliotecas OpenSSL e gcc. Em máquinas Linux, execute:

```shell
sudo apt-get install libssl-dev gcc -y
```

### Instalação local (Nix)

Outra opção é instalar o `text-generation-inference` localmente usando [Nix](https://nixos.org). Atualmente,
suportamos Nix apenas em Linux x86_64 com GPUs CUDA. Ao usar Nix, todas as dependências podem
ser baixadas de um cache binário, eliminando a necessidade de compilá-las localmente.

Primeiro siga as instruções para [instalar Cachix e habilitar o cache Hugging Face](https://app.cachix.org/cache/huggingface).
Configurar o cache é importante, caso contrário o Nix irá compilar muitas dependências
localmente, o que pode levar horas.

Depois disso você pode rodar o TGI com `nix run`:

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**Nota:** quando você usa Nix em um sistema que não é NixOS, precisa [fazer alguns links simbólicos](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library)
para tornar as bibliotecas do driver CUDA visíveis para os pacotes Nix.

Para desenvolvimento do TGI, você pode usar o shell de desenvolvimento `impure`:

```shell
nix develop .#impure

# Necessário apenas na primeira vez que o devshell é iniciado ou após atualizar o protobuf.
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

Todas as dependências de desenvolvimento (cargo, Python, Torch), etc. estão disponíveis neste
shell de desenvolvimento.

## Arquiteturas otimizadas

O TGI funciona imediatamente para servir modelos otimizados para todos os modelos modernos. Eles podem ser encontrados em [esta lista](https://huggingface.co/docs/text-generation-inference/supported_models).

Outras arquiteturas são suportadas na base do melhor esforço usando:

`AutoModelForCausalLM.from_pretrained(<modelo>, device_map="auto")`

ou

`AutoModelForSeq2SeqLM.from_pretrained(<modelo>, device_map="auto")`



## Executar localmente

### Executar

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### Quantização

Você também pode executar pesos pré-quantizados (AWQ, GPTQ, Marlin) ou quantizar pesos em tempo real com bitsandbytes, EETQ, fp8, para reduzir a necessidade de VRAM:

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

A quantização 4bit está disponível usando os [tipos de dados NF4 e FP4 do bitsandbytes](https://arxiv.org/pdf/2305.14314.pdf). Pode ser habilitada fornecendo `--quantize bitsandbytes-nf4` ou `--quantize bitsandbytes-fp4` como argumento de linha de comando para `text-generation-launcher`.

Leia mais sobre quantização na [documentação de Quantização](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization).

## Desenvolver

```shell
make server-dev
make router-dev
```

## Testes

```shell
# python
make python-server-tests
make python-client-tests
# ou ambos testes de servidor e cliente
make python-tests
# testes rust cargo
make rust-tests
# testes de integração
make integration-tests
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---