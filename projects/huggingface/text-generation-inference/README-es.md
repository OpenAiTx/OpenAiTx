<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/Narsil/tgi_assets/thumbnail.png">
</a>

# Inferencia de Generación de Texto

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API documentation" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

Un servidor en Rust, Python y gRPC para inferencia de generación de texto. Usado en producción en [Hugging Face](https://huggingface.co)
para potenciar Hugging Chat, la API de Inferencia y los Endpoints de Inferencia.

</div>

## Tabla de contenidos

  - [Comenzar](#get-started)
    - [Docker](#docker)
    - [Documentación API](#api-documentation)
    - [Uso de un modelo privado o restringido](#using-a-private-or-gated-model)
    - [Una nota sobre Memoria Compartida (shm)](#a-note-on-shared-memory-shm)
    - [Trazado Distribuido](#distributed-tracing)
    - [Arquitectura](#architecture)
    - [Instalación local](#local-install)
    - [Instalación local (Nix)](#local-install-nix)
  - [Arquitecturas optimizadas](#optimized-architectures)
  - [Ejecutar localmente](#run-locally)
    - [Ejecutar](#run)
    - [Cuantización](#quantization)
  - [Desarrollar](#develop)
  - [Pruebas](#testing)

Inferencia de Generación de Texto (TGI) es un conjunto de herramientas para desplegar y servir Modelos de Lenguaje Grandes (LLMs). TGI permite generación de texto de alto rendimiento para los LLMs open-source más populares, incluyendo Llama, Falcon, StarCoder, BLOOM, GPT-NeoX, y [más](https://huggingface.co/docs/text-generation-inference/supported_models). TGI implementa muchas características, tales como:

- Lanzador simple para servir los LLMs más populares
- Listo para producción (trazado distribuido con Open Telemetry, métricas Prometheus)
- Paralelismo Tensorial para inferencia más rápida en múltiples GPUs
- Transmisión de tokens usando Server-Sent Events (SSE)
- Agrupamiento continuo de solicitudes entrantes para aumentar el rendimiento total
- [API de mensajes](https://huggingface.co/docs/text-generation-inference/en/messages_api) compatible con la API de Chat Completion de Open AI
- Código optimizado de transformers para inferencia usando [Flash Attention](https://github.com/HazyResearch/flash-attention) y [Paged Attention](https://github.com/vllm-project/vllm) en las arquitecturas más populares
- Cuantización con :
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- Carga de pesos con [Safetensors](https://github.com/huggingface/safetensors)
- Marcas de agua con [A Watermark for Large Language Models](https://arxiv.org/abs/2301.10226)
- Modificador de logits (escalado de temperatura, top-p, top-k, penalización de repetición, más detalles en [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor))
- Secuencias de parada
- Probabilidades logarítmicas
- [Especulación](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) ~2x reducción de latencia
- [Guía/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance). Especifica el formato de salida para acelerar la inferencia y asegurar que la salida sea válida según ciertas especificaciones.
- Generación personalizada de prompts: Genera texto fácilmente proporcionando prompts personalizados para guiar la salida del modelo
- Soporte para ajuste fino: Utiliza modelos ajustados para tareas específicas para lograr mayor precisión y rendimiento

### Soporte de hardware

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [GPU Intel](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## Comenzar

### Docker

Para una guía detallada de inicio, por favor consulte el [Tour Rápido](https://huggingface.co/docs/text-generation-inference/quicktour). La forma más sencilla de comenzar es usando el contenedor oficial de Docker:

```shell
model=HuggingFaceH4/zephyr-7b-beta
# comparte un volumen con el contenedor Docker para evitar descargar pesos en cada ejecución
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

Y luego puedes hacer solicitudes como

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"¿Qué es el Aprendizaje Profundo?","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

También puedes usar la [API de Mensajes de TGI](https://huggingface.co/docs/text-generation-inference/en/messages_api) para obtener respuestas compatibles con la API de Chat Completion de Open AI.

```bash
curl localhost:8080/v1/chat/completions \
    -X POST \
    -d '{
  "model": "tgi",
  "messages": [
    {
      "role": "system",
      "content": "Eres un asistente útil."
    },
    {
      "role": "user",
      "content": "¿Qué es el aprendizaje profundo?"
    }
  ],
  "stream": true,
  "max_tokens": 20
}' \
    -H 'Content-Type: application/json'
```

**Nota:** Para usar GPUs NVIDIA, necesitas instalar el [NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html). También recomendamos usar drivers NVIDIA con versión CUDA 12.2 o superior. Para ejecutar el contenedor Docker en una máquina sin GPUs o soporte CUDA, basta con remover la bandera `--gpus all` y añadir `--disable-custom-kernels`, ten en cuenta que la CPU no es la plataforma recomendada para este proyecto, por lo que el rendimiento podría ser inferior.

**Nota:** TGI soporta GPUs AMD Instinct MI210 y MI250. Los detalles se encuentran en la [documentación de Hardware Soportado](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus). Para usar GPUs AMD, usa en lugar del comando anterior:

```shell
docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model
```

Para ver todas las opciones para servir tus modelos (en el [código](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs) o en la cli):

```
text-generation-launcher --help
```

### Documentación API

Puedes consultar la documentación OpenAPI de la API REST `text-generation-inference` usando la ruta `/docs`.
La interfaz Swagger UI también está disponible en: [https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference).

### Uso de un modelo privado o restringido

Tienes la opción de utilizar la variable de entorno `HF_TOKEN` para configurar el token usado por
`text-generation-inference`. Esto te permite acceder a recursos protegidos.

Por ejemplo, si deseas servir las variantes restringidas del modelo Llama V2:

1. Ve a https://huggingface.co/settings/tokens
2. Copia tu token READ para CLI
3. Exporta `HF_TOKEN=<tu token READ de CLI>`

o con Docker:

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # comparte un volumen con el contenedor Docker para evitar descargar pesos en cada ejecución
token=<tu token READ de CLI>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### Una nota sobre Memoria Compartida (shm)

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html) es un marco de comunicación usado por
`PyTorch` para realizar entrenamiento/inferencia distribuida. `text-generation-inference` hace
uso de `NCCL` para habilitar el Paralelismo Tensorial y acelerar dramáticamente la inferencia para modelos de lenguaje grandes.

Para compartir datos entre los diferentes dispositivos de un grupo `NCCL`, `NCCL` puede recurrir a usar la memoria del host si
no es posible la conexión peer-to-peer usando NVLink o PCI.

Para permitir que el contenedor use 1G de Memoria Compartida y soporte el uso de SHM, añadimos `--shm-size 1g` en el comando anterior.

Si estás ejecutando `text-generation-inference` dentro de `Kubernetes`, también puedes agregar Memoria Compartida al contenedor
creando un volumen con:

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

y montándolo en `/dev/shm`.

Finalmente, también puedes deshabilitar el uso compartido de SHM usando la variable de entorno `NCCL_SHM_DISABLE=1`. Sin embargo, ten en cuenta que
esto impactará el rendimiento.

### Trazado Distribuido

`text-generation-inference` está instrumentado con trazado distribuido usando OpenTelemetry. Puedes usar esta característica
configurando la dirección hacia un colector OTLP con el argumento `--otlp-endpoint`. El nombre de servicio por defecto puede ser
sobrescrito con el argumento `--otlp-service-name`.

### Arquitectura

![Arquitectura TGI](https://raw.githubusercontent.com/huggingface/text-generation-inference/main/datasets/huggingface/documentation-images/TGI.png)

Blog detallado por Adyen sobre el funcionamiento interno de TGI: [Inferencia LLM a escala con TGI (Martin Iglesias Goyanes - Adyen, 2024)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### Instalación local

También puedes optar por instalar `text-generation-inference` localmente.

Primero clona el repositorio y cambia al directorio:
```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

Luego [instala Rust](https://rustup.rs/) y crea un entorno virtual de Python con al menos
Python 3.9, por ejemplo usando `conda` o `python venv`:

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

#usando conda
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

#usando python venv
python3 -m venv .venv
source .venv/bin/activate
```

También puede que necesites instalar Protoc.

En Linux:

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

En MacOS, usando Homebrew:

```shell
brew install protobuf
```

Luego ejecuta:

```shell
BUILD_EXTENSIONS=True make install # Instala el repositorio y el fork HF/transformers con kernels CUDA
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**Nota:** en algunas máquinas, también puedes necesitar las bibliotecas OpenSSL y gcc. En máquinas Linux, ejecuta:

```shell
sudo apt-get install libssl-dev gcc -y
```

### Instalación local (Nix)

Otra opción es instalar `text-generation-inference` localmente usando [Nix](https://nixos.org). Actualmente,
solo soportamos Nix en Linux x86_64 con GPUs CUDA. Al usar Nix, todas las dependencias pueden
obtenerse desde una caché binaria, eliminando la necesidad de compilarlas localmente.

Primero sigue las instrucciones para [instalar Cachix y habilitar la caché de Hugging Face](https://app.cachix.org/cache/huggingface).
Configurar la caché es importante, de lo contrario Nix compilará muchas dependencias
localmente, lo que puede tomar horas.

Después de eso puedes ejecutar TGI con `nix run`:

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**Nota:** cuando usas Nix en un sistema que no es NixOS, debes [crear algunos enlaces simbólicos](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library)
para hacer visibles las librerías del controlador CUDA a los paquetes Nix.

Para el desarrollo de TGI, puedes usar el entorno de desarrollo `impure`:

```shell
nix develop .#impure

# Solo es necesario la primera vez que se inicia el devshell o después de actualizar protobuf.
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

Todas las dependencias de desarrollo (cargo, Python, Torch), etc. están disponibles en este
entorno de desarrollo.

## Arquitecturas optimizadas

TGI funciona de inmediato para servir modelos optimizados para todos los modelos modernos. Se pueden encontrar en [esta lista](https://huggingface.co/docs/text-generation-inference/supported_models).

Otras arquitecturas son soportadas de manera tentativa usando:

`AutoModelForCausalLM.from_pretrained(<modelo>, device_map="auto")`

o

`AutoModelForSeq2SeqLM.from_pretrained(<modelo>, device_map="auto")`



## Ejecutar localmente

### Ejecutar

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### Cuantización

También puedes ejecutar pesos pre-cuantizados (AWQ, GPTQ, Marlin) o cuantizar los pesos al vuelo con bitsandbytes, EETQ, fp8, para reducir el requerimiento de VRAM:

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

La cuantización 4bit está disponible usando los [tipos de datos NF4 y FP4 de bitsandbytes](https://arxiv.org/pdf/2305.14314.pdf). Puede habilitarse proporcionando `--quantize bitsandbytes-nf4` o `--quantize bitsandbytes-fp4` como argumento en la línea de comandos a `text-generation-launcher`.

Lee más sobre cuantización en la [documentación de Cuantización](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization).

## Desarrollar

```shell
make server-dev
make router-dev
```

## Pruebas

```shell
# python
make python-server-tests
make python-client-tests
# o ambas pruebas de servidor y cliente
make python-tests
# pruebas rust cargo
make rust-tests
# pruebas de integración
make integration-tests
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---