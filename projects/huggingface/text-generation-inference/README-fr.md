<div align="center">

<a href="https://www.youtube.com/watch?v=jlMAX2Oaht0">
  <img width=560 alt="Making TGI deployment optimal" src="https://huggingface.co/datasets/Narsil/tgi_assets/resolve/main/thumbnail.png">
</a>

# Inférence de Génération de Texte

<a href="https://github.com/huggingface/text-generation-inference">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/huggingface/text-generation-inference?style=social">
</a>
<a href="https://huggingface.github.io/text-generation-inference">
  <img alt="Swagger API documentation" src="https://img.shields.io/badge/API-Swagger-informational">
</a>

Un serveur Rust, Python et gRPC pour l'inférence de génération de texte. Utilisé en production chez [Hugging Face](https://huggingface.co)
pour alimenter Hugging Chat, l'API d'Inference et les Endpoints d'Inference.

</div>

## Table des matières

  - [Commencer](#get-started)
    - [Docker](#docker)
    - [Documentation API](#api-documentation)
    - [Utilisation d’un modèle privé ou restreint](#using-a-private-or-gated-model)
    - [Note sur la mémoire partagée (shm)](#a-note-on-shared-memory-shm)
    - [Tracing distribué](#distributed-tracing)
    - [Architecture](#architecture)
    - [Installation locale](#local-install)
    - [Installation locale (Nix)](#local-install-nix)
  - [Architectures optimisées](#optimized-architectures)
  - [Exécution locale](#run-locally)
    - [Exécuter](#run)
    - [Quantification](#quantization)
  - [Développement](#develop)
  - [Tests](#testing)

L'Inférence de Génération de Texte (TGI) est une boîte à outils pour déployer et servir des Modèles de Langage Large (LLMs). TGI permet une génération de texte haute performance pour les LLMs open-source les plus populaires, notamment Llama, Falcon, StarCoder, BLOOM, GPT-NeoX, et [plus](https://huggingface.co/docs/text-generation-inference/supported_models). TGI implémente de nombreuses fonctionnalités, telles que :

- Lanceur simple pour servir les LLMs les plus populaires
- Prêt pour la production (tracing distribué avec OpenTelemetry, métriques Prometheus)
- Parallélisme tensoriel pour une inférence plus rapide sur plusieurs GPU
- Streaming de tokens via Server-Sent Events (SSE)
- Regroupement continu des requêtes entrantes pour augmenter le débit total
- [API Messages](https://huggingface.co/docs/text-generation-inference/en/messages_api) compatible avec l'API Open AI Chat Completion
- Code transformers optimisé pour l'inférence utilisant [Flash Attention](https://github.com/HazyResearch/flash-attention) et [Paged Attention](https://github.com/vllm-project/vllm) sur les architectures les plus populaires
- Quantification avec :
  - [bitsandbytes](https://github.com/TimDettmers/bitsandbytes)
  - [GPT-Q](https://arxiv.org/abs/2210.17323)
  - [EETQ](https://github.com/NetEase-FuXi/EETQ)
  - [AWQ](https://github.com/casper-hansen/AutoAWQ)
  - [Marlin](https://github.com/IST-DASLab/marlin)
  - [fp8](https://developer.nvidia.com/blog/nvidia-arm-and-intel-publish-fp8-specification-for-standardization-as-an-interchange-format-for-ai/)
- Chargement de poids avec [Safetensors](https://github.com/huggingface/safetensors)
- Filigrane avec [A Watermark for Large Language Models](https://arxiv.org/abs/2301.10226)
- Warper de logits (mise à l’échelle de la température, top-p, top-k, pénalité de répétition, plus de détails dans [transformers.LogitsProcessor](https://huggingface.co/docs/transformers/internal/generation_utils#transformers.LogitsProcessor))
- Séquences d’arrêt
- Probabilités logarithmiques
- [Spéculation](https://huggingface.co/docs/text-generation-inference/conceptual/speculation) ~2x latence
- [Guidance/JSON](https://huggingface.co/docs/text-generation-inference/conceptual/guidance). Spécifiez le format de sortie pour accélérer l’inférence et garantir que la sortie est valide selon certaines spécifications.
- Génération de prompt personnalisée : générez facilement du texte en fournissant des prompts personnalisés pour guider la sortie du modèle
- Support du fine-tuning : utilisez des modèles fine-tunés pour des tâches spécifiques afin d’atteindre une meilleure précision et performance

### Support matériel

- [Nvidia](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference)
- [AMD](https://github.com/huggingface/text-generation-inference/pkgs/container/text-generation-inference) (-rocm)
- [Inferentia](https://github.com/huggingface/optimum-neuron/tree/main/text-generation-inference)
- [Intel GPU](https://github.com/huggingface/text-generation-inference/pull/1475)
- [Gaudi](https://github.com/huggingface/tgi-gaudi)
- [Google TPU](https://huggingface.co/docs/optimum-tpu/howto/serving)


## Commencer

### Docker

Pour un guide détaillé de démarrage, veuillez consulter la [Visite rapide](https://huggingface.co/docs/text-generation-inference/quicktour). Le moyen le plus simple de commencer est d’utiliser le conteneur Docker officiel :

```shell
model=HuggingFaceH4/zephyr-7b-beta
# partagez un volume avec le conteneur Docker pour éviter de télécharger les poids à chaque exécution
volume=$PWD/data

docker run --gpus all --shm-size 1g -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

Puis vous pouvez faire des requêtes comme

```bash
curl 127.0.0.1:8080/generate_stream \
    -X POST \
    -d '{"inputs":"Qu’est-ce que l’apprentissage profond ?","parameters":{"max_new_tokens":20}}' \
    -H 'Content-Type: application/json'
```

Vous pouvez également utiliser [l’API Messages de TGI](https://huggingface.co/docs/text-generation-inference/en/messages_api) pour obtenir des réponses compatibles avec l'API Open AI Chat Completion.

```bash
curl localhost:8080/v1/chat/completions \
    -X POST \
    -d '{
  "model": "tgi",
  "messages": [
    {
      "role": "system",
      "content": "Vous êtes un assistant utile."
    },
    {
      "role": "user",
      "content": "Qu’est-ce que l’apprentissage profond ?"
    }
  ],
  "stream": true,
  "max_tokens": 20
}' \
    -H 'Content-Type: application/json'
```

**Note :** Pour utiliser les GPU NVIDIA, vous devez installer le [NVIDIA Container Toolkit](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html). Nous recommandons également d’utiliser des pilotes NVIDIA avec CUDA version 12.2 ou supérieure. Pour exécuter le conteneur Docker sur une machine sans GPU ni support CUDA, il suffit de retirer le paramètre `--gpus all` et d’ajouter `--disable-custom-kernels`, notez que le CPU n’est pas la plateforme prévue pour ce projet, donc la performance peut être inférieure.

**Note :** TGI supporte les GPU AMD Instinct MI210 et MI250. Les détails sont disponibles dans la [documentation Matériel Supporté](https://huggingface.co/docs/text-generation-inference/installation_amd#using-tgi-with-amd-gpus). Pour utiliser les GPU AMD, veuillez utiliser `docker run --device /dev/kfd --device /dev/dri --shm-size 1g -p 8080:80 -v $volume:/data ghcr.io/huggingface/text-generation-inference:3.3.2-rocm --model-id $model` au lieu de la commande ci-dessus.

Pour voir toutes les options pour servir vos modèles (dans le [code](https://github.com/huggingface/text-generation-inference/blob/main/launcher/src/main.rs) ou dans le cli) :
```
text-generation-launcher --help
```

### Documentation API

Vous pouvez consulter la documentation OpenAPI de l’API REST `text-generation-inference` en utilisant la route `/docs`.
L’interface Swagger UI est également disponible à : [https://huggingface.github.io/text-generation-inference](https://huggingface.github.io/text-generation-inference).

### Utilisation d’un modèle privé ou restreint

Vous avez la possibilité d’utiliser la variable d’environnement `HF_TOKEN` pour configurer le jeton utilisé par
`text-generation-inference`. Cela vous permet d’accéder à des ressources protégées.

Par exemple, si vous souhaitez servir les variantes du modèle restreint Llama V2 :

1. Rendez-vous sur https://huggingface.co/settings/tokens
2. Copiez votre jeton CLI en lecture seule
3. Exportez `HF_TOKEN=<votre jeton CLI en lecture>`

ou avec Docker :

```shell
model=meta-llama/Meta-Llama-3.1-8B-Instruct
volume=$PWD/data # partagez un volume avec le conteneur Docker pour éviter de télécharger les poids à chaque exécution
token=<votre jeton cli en lecture>

docker run --gpus all --shm-size 1g -e HF_TOKEN=$token -p 8080:80 -v $volume:/data \
    ghcr.io/huggingface/text-generation-inference:3.3.2 --model-id $model
```

### Note sur la mémoire partagée (shm)

[`NCCL`](https://docs.nvidia.com/deeplearning/nccl/user-guide/docs/index.html) est un cadre de communication utilisé par
`PyTorch` pour effectuer l’entraînement/inférence distribuée. `text-generation-inference` utilise
`NCCL` pour activer le parallélisme tensoriel et accélérer considérablement l’inférence pour les grands modèles de langage.

Pour partager des données entre les différents dispositifs d’un groupe `NCCL`, `NCCL` peut retomber sur l’utilisation de la mémoire hôte si
le peer-to-peer via NVLink ou PCI n’est pas possible.

Pour permettre au conteneur d’utiliser 1 Go de mémoire partagée et supporter le partage SHM, nous ajoutons `--shm-size 1g` à la commande ci-dessus.

Si vous exécutez `text-generation-inference` dans `Kubernetes`, vous pouvez aussi ajouter de la mémoire partagée au conteneur en
créant un volume avec :

```yaml
- name: shm
  emptyDir:
   medium: Memory
   sizeLimit: 1Gi
```

et en le montant sur `/dev/shm`.

Enfin, vous pouvez aussi désactiver le partage SHM en utilisant la variable d’environnement `NCCL_SHM_DISABLE=1`. Cependant, notez que
cela impactera les performances.

### Tracing distribué

`text-generation-inference` est instrumenté avec le tracing distribué utilisant OpenTelemetry. Vous pouvez utiliser cette fonctionnalité
en définissant l’adresse d’un collecteur OTLP avec l’argument `--otlp-endpoint`. Le nom de service par défaut peut être
remplacé avec l’argument `--otlp-service-name`

### Architecture

![Architecture TGI](https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/TGI.png)

Article détaillé par Adyen sur le fonctionnement interne de TGI : [LLM inference at scale with TGI (Martin Iglesias Goyanes - Adyen, 2024)](https://www.adyen.com/knowledge-hub/llm-inference-at-scale-with-tgi)

### Installation locale

Vous pouvez également choisir d’installer `text-generation-inference` localement.

Commencez par cloner le dépôt et changez de répertoire :
(Partie 2 sur 2)


```shell
git clone https://github.com/huggingface/text-generation-inference
cd text-generation-inference
```

Ensuite, [installez Rust](https://rustup.rs/) et créez un environnement virtuel Python avec au moins
Python 3.9, par exemple en utilisant `conda` ou `python venv` :

```shell
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh

# utilisation de conda
conda create -n text-generation-inference python=3.11
conda activate text-generation-inference

# utilisation de python venv
python3 -m venv .venv
source .venv/bin/activate
```

Vous devrez peut-être aussi installer Protoc.

Sous Linux :

```shell
PROTOC_ZIP=protoc-21.12-linux-x86_64.zip
curl -OL https://raw.githubusercontent.com/huggingface/text-generation-inference/main/https://github.com/protocolbuffers/protobuf/releases/download/v21.12/$PROTOC_ZIP
sudo unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
sudo unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
rm -f $PROTOC_ZIP
```

Sous MacOS, en utilisant Homebrew :

```shell
brew install protobuf
```

Puis lancez :

```shell
BUILD_EXTENSIONS=True make install # Installe le dépôt et le fork HF/transformer avec les kernels CUDA
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

**Remarque :** sur certaines machines, vous aurez aussi besoin des bibliothèques OpenSSL et gcc. Sur les machines Linux, exécutez :

```shell
sudo apt-get install libssl-dev gcc -y
```

### Installation locale (Nix)

Une autre option est d’installer `text-generation-inference` localement en utilisant [Nix](https://nixos.org). Actuellement,
nous ne supportons Nix que sur Linux x86_64 avec GPU CUDA. En utilisant Nix, toutes les dépendances peuvent
être récupérées depuis un cache binaire, évitant ainsi de les compiler localement.

Commencez par suivre les instructions pour [installer Cachix et activer le cache Hugging Face](https://app.cachix.org/cache/huggingface).
Configurer le cache est important, sinon Nix compilera beaucoup de dépendances
localement, ce qui peut prendre des heures.

Après cela, vous pouvez lancer TGI avec `nix run` :

```shell
cd text-generation-inference
nix run --extra-experimental-features nix-command --extra-experimental-features flakes . -- --model-id meta-llama/Llama-3.1-8B-Instruct
```

**Remarque :** lorsque vous utilisez Nix sur un système non-NixOS, vous devez [créer certains liens symboliques](https://danieldk.eu/Nix-CUDA-on-non-NixOS-systems#make-runopengl-driverlib-and-symlink-the-driver-library)
pour rendre les bibliothèques du pilote CUDA visibles par les paquets Nix.

Pour le développement TGI, vous pouvez utiliser le shell dev `impure` :

```shell
nix develop .#impure

# Nécessaire uniquement la première fois que le devshell est lancé ou après mise à jour de protobuf.
(
cd server
mkdir text_generation_server/pb || true
python -m grpc_tools.protoc -I../proto/v3 --python_out=text_generation_server/pb \
       --grpc_python_out=text_generation_server/pb --mypy_out=text_generation_server/pb ../proto/v3/generate.proto
find text_generation_server/pb/ -type f -name "*.py" -print0 -exec sed -i -e 's/^\(import.*pb2\)/from . \1/g' {} \;
touch text_generation_server/pb/__init__.py
)
```

Toutes les dépendances de développement (cargo, Python, Torch), etc. sont disponibles dans ce
shell dev.

## Architectures optimisées

TGI fonctionne immédiatement pour servir des modèles optimisés pour tous les modèles modernes. Ils peuvent être trouvés dans [cette liste](https://huggingface.co/docs/text-generation-inference/supported_models).

D’autres architectures sont supportées sur une base de « meilleur effort » en utilisant :

`AutoModelForCausalLM.from_pretrained(<model>, device_map="auto")`

ou

`AutoModelForSeq2SeqLM.from_pretrained(<model>, device_map="auto")`



## Exécution locale

### Lancer

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2
```

### Quantification

Vous pouvez aussi exécuter des poids pré-quantifiés (AWQ, GPTQ, Marlin) ou quantifier les poids à la volée avec bitsandbytes, EETQ, fp8, pour réduire la mémoire VRAM requise :

```shell
text-generation-launcher --model-id mistralai/Mistral-7B-Instruct-v0.2 --quantize
```

La quantification 4 bits est disponible en utilisant les types de données [NF4 et FP4 de bitsandbytes](https://arxiv.org/pdf/2305.14314.pdf). Elle peut être activée en fournissant `--quantize bitsandbytes-nf4` ou `--quantize bitsandbytes-fp4` en argument en ligne de commande à `text-generation-launcher`.

Lisez plus sur la quantification dans la [documentation Quantification](https://huggingface.co/docs/text-generation-inference/en/conceptual/quantization).

## Développement

```shell
make server-dev
make router-dev
```

## Tests

```shell
# python
make python-server-tests
make python-client-tests
# ou tests serveur et client
make python-tests
# tests rust cargo
make rust-tests
# tests d’intégration
make integration-tests
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---