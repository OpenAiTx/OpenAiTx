# PhotonInfer

<div align="center">

**Un moteur d'inférence LLM haute performance avec un batch continu de type vLLM**

[English](https://raw.githubusercontent.com/lumia431/photon_infer/master/README.md) | [中文](https://raw.githubusercontent.com/lumia431/photon_infer/master/README_ZH.md) | [Démonstration en direct](https://photoninfer.xyz/)

[![Licence : MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![CUDA](https://img.shields.io/badge/CUDA-12.0+-green.svg)](https://developer.nvidia.com/cuda-toolkit)
[![C++20](https://img.shields.io/badge/C++-20-orange.svg)](https://en.cppreference.com/w/cpp/20)

</div>

---

## 🚀 Points forts des performances

PhotonInfer offre des **performances d'inférence de qualité production** pour les LLM avec des capacités avancées de batching. **Prend en charge les modèles Llama-3.2 et Qwen3**.

### Inférence pour une seule requête

| Modèle | PhotonInfer | llama.cpp | Accélération |
|--------|-------------|-----------|--------------|
| Llama 3.2 1B | 185 tok/s | 252 tok/s | 0,73× (llama.cpp plus rapide) |

**TTFT (Temps jusqu'au premier token)** : 387 ms pour un prompt de 100 tokens (quantification INT8)

### Débit d'inférence en batch

| Taille du batch | PhotonInfer | llama.cpp | Accélération |
|-----------------|-------------|-----------|--------------|
| 4               | 410 tok/s   | 252 tok/s | **1,63×**    |
| 8               | 720 tok/s   | 255 tok/s | **2,82×**    |
| 16              | 787 tok/s   | 253 tok/s | **3,07×**    |

**Testé sur** : NVIDIA A100, Llama 3.2 1B, quantification Q8/INT8

## ✨ Fonctionnalités clés

### 🎯 **Regroupement Continu de Style vLLM**
- **Planification dynamique au niveau du token** : Ajouter de nouvelles requêtes en cours de génération sans attendre la fin du lot
- **Planificateur en deux phases** : Continuer sans interruption l’exécution des requêtes tout en en acceptant de nouvelles
- **Suivi de l’état des requêtes** : Gestion précise de `num_computed_tokens` pour une reprise efficace
- **Parfait pour la production** : Services d’inférence haute-concurrence avec réactivité en temps réel

### ⚡ **Kernels Optimisés GPU**
- **Attention par pages en lots** : Gestion du cache KV au niveau des blocs avec utilisation efficace de la mémoire
- **Accès mémoire vectorisé** : Chargements `float4` pour une efficacité de bande passante multipliée par 2-4
- **Opérations fusionnées** : Échantillonnage GPU sans copie, RoPE en lots, et normalisation fusionnée
- **Quantification INT8** : Quantification groupée avec support cuBLASLt INT8 GEMM
- **Softmax optimisé** : CUB BlockReduce pour un calcul d’attention numériquement stable

### 🏗️ **Architecture Moderne C++20**
- **Gestion d’erreurs type-safe** : Type `Result<T, E>` inspiré de Rust pour une propagation explicite des erreurs
- **Conception zéro-copie** : Usage intensif de `std::span` et sémantique de déplacement
- **Indépendant du dispositif** : Interface unifiée pour les backends CPU et CUDA
- **Concepts & Ranges** : Contraintes au moment de la compilation et sécurité de type expressive

## 🚀 Démarrage Rapide

### Prérequis

- **Compilateur** : GCC 12+ (support C++20 requis)
- **CMake** : 3.20+
- **CUDA Toolkit** : 12.0+ (testé sur 12.5)
- **GPU** : GPU NVIDIA avec capacité de calcul 7.0+

### Télécharger le Modèle

Téléchargez un modèle pré-quantifié pour démarrer rapidement :

https://huggingface.co/Lummy666/llama-3.2-1B-Instruct

### Compilation

#### Option 1 : Compiler depuis les Sources

```bash
# Clone repository
cd photon_infer

# Configure with CUDA
mkdir build && cd build
cmake -DCMAKE_BUILD_TYPE=Release -DPHOTON_BUILD_CUDA=ON ..

# Build
cmake --build . -j$(nproc)

# Install (optional)
sudo cmake --install .
```

Après l'installation, vous pouvez exécuter le serveur web directement depuis n'importe où :

```bash
photon_web_server \
    --port 5728 \
    --model /path/to/llama-3.2-1B-Instruct \
    --tokenizer /path/to/llama-3.2-1B-Instruct/tokenizer.json
```

L'installation placera :
- `photon_web_server` → `/usr/local/bin/`
- Fichiers web statiques → `/photon_infer/web/static/`
- Bibliothèque principale → `/usr/local/lib/`

Pour désinstaller :
```bash
cd build
sudo cmake --build . --target uninstall
```
#### Option 2 : Utiliser Docker (Recommandé)


```bash
# Pull the pre-built Docker image
docker pull lumia431/photon_infer:latest

# Run the container with GPU support
docker run --rm --gpus all -p 5728:5728 -e PORT=5728 lumia431/photon_infer:latest
```

L'interface web sera disponible à `http://localhost:5728`

## 🔬 Détails techniques

### Quantification INT8
- **Quantification par groupe** : Taille de groupe configurable (32, 64, 128)
- **Intégration cuBLASLt** : GEMM INT8 accéléré matériellement
- **Perte minimale de précision** : Dégradation < 1 % de la perplexité sur les modèles Llama

### Attention paginée
- **Cache KV au niveau du bloc** : Allocation mémoire efficace sans fragmentation
- **Gestion dynamique des séquences** : Décalages de cache par séquence pour une planification flexible
- **Opérations de cache groupées** : Noyau unique pour écritures K/V multi-séquences

### Ordonnanceur de batch continu
- **Planification en deux phases** :
  1. **Phase 1** : Continuer toutes les requêtes EN COURS (sans interruption)
  2. **Phase 2** : Admettre les requêtes EN ATTENTE pour remplir la capacité restante
- **États des requêtes** : EN ATTENTE → EN COURS → TERMINÉ (avec support de PRÉEMPTION)
- **Granularité au niveau du token** : Suivi de `num_computed_tokens` pour une reprise précise

## 🛣️ Feuille de route

- [x] **Infrastructure de base** : Tensores, opérateurs, gestion mémoire
- [x] **Modèle LLaMA** : Implémentation complète du transformeur avec noyaux CPU/GPU
- [x] **Quantification INT8** : Quantification par groupe avec cuBLASLt
- [x] **Attention paginée** : Gestion du cache KV au niveau du bloc
- [x] **Batch continu** : Planification dynamique des requêtes style vLLM
- [ ] **Flash Attention 2** : Attention consciente des E/S pour longues séquences
- [ ] **Support Multi-GPU** : Parallélisme tensoriel pour grands modèles
- [ ] **Précision mixte FP16/BF16** : Débit amélioré sur GPUs modernes
- [ ] **Décodage spéculatif** : Génération multi-token avec modèle brouillon

## 📖 Documentation

- [Conception du batch continu](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/continuous_batching.md)
- [Guide d’optimisation des performances](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/performance.md)
- [Référence API](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/api.md)

## 🤝 Contribution

Les contributions sont les bienvenues ! Veuillez consulter [CONTRIBUTING.md](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/contributing.md) pour les directives.

## 📝 Licence

Licence MIT - voir [LICENSE](LICENSE) pour les détails.

## 🙏 Remerciements

- Architecture inspirée par [vLLM](https://github.com/vllm-project/vllm)
- Références d’optimisation du noyau [llama.cpp](https://github.com/ggerganov/llama.cpp)
- Conception de la gestion des erreurs tirée de `Result<T, E>` en Rust

---

**Conçu avec ❤️ pour une inférence LLM haute performance**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-22

---