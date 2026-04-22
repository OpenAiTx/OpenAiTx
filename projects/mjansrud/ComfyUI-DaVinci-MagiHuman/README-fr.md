Édition : Ce dépôt a été archivé car je n’ai pas réussi à générer de bons résultats (suffisants) avec le modèle, je vais rester sur LTX2.3 pour le moment.  
N’hésitez pas à continuer à y travailler.

Édition : ATTENTION ! Ceci est encore en cours de développement, ne vous attendez pas à ce que ça fonctionne.  
Je pars en vacances de Pâques et n’aurai pas le temps de m’en occuper avant mon retour.  
N’hésitez pas à forker et poursuivre le travail, ou à attendre que Kijai publie sa version.

Le code va (pour l’instant, sera modifié plus tard) télécharger automatiquement l’encodeur de texte requis et le wan vae depuis huggingface,  
préparez-vous à ce que cela prenne un certain temps lors du premier lancement.

# ComfyUI-DaVinci-MagiHuman

Nœuds personnalisés ComfyUI pour [daVinci-MagiHuman](https://huggingface.co/GAIR/daVinci-MagiHuman), un transformeur à flux unique de 15 milliards de paramètres pour une génération rapide audio-vidéo. Optimisé pour les GPU grand public (RTX 5090 32GB).

## Fonctionnalités

- **Échange CPU/GPU au niveau des blocs** — seulement 8 des 40 couches du transformeur sur GPU simultanément (~6GB vs ~30GB)  
- **Préchargement CUDA asynchrone** — transfert du bloc suivant pendant le calcul du bloc actuel  
- **Mode distillation** — génération en 8 étapes sans CFG (le plus rapide)  
- **Super-résolution 1080p** — suréchantillonnage en espace latent depuis une base 256p  
- **Décodeur TurboVAE** — décodage en fenêtre glissante avec déchargement de sortie pour 1080p  
- **Audio + vidéo** — génération conjointe en flux unique

## Nœuds

| Nœud | Description |
|------|-------------|
| **Chargeur de modèle DaVinci** | Charge le modèle distill/base/SR avec `blocks_on_gpu` configurable |
| **Chargeur TurboVAE DaVinci** | Charge le VAE rapide en mode décodage seul |
| **Encodeur de texte DaVinci** | Prompt texte vers embeddings (accepte un encodeur T5 externe) |
| **Échantillonneur DaVinci** | Boucle de débruitage (8 étapes distill / 32 étapes base) |
| **Super-résolution DaVinci** | Suréchantillonne le latent 256p en 1080p avec le modèle SR |
| **Décodage DaVinci** | Latent TurboVAE vers vidéo avec déchargement de sortie |
| **Sortie vidéo DaVinci** | Sauvegarde au format mp4/webm via FFmpeg |

## Flux de travail

```
Model Loader (distill, 8 blocks on GPU)
  → Text Encode
    → Sampler (256p, 8 steps)
      → [optional] SR Model Loader (1080p_sr) → Super Resolution
        → TurboVAE Loader → Decode → Video Output
```

## Exigences

- **GPU** : RTX 5090 (32 Go) ou mieux. 8 blocs sur GPU fonctionne avec 32 Go de VRAM.
- **RAM** : 64 Go+ recommandé (le déchargement CPU stocke ~24 Go de poids du modèle dans la RAM système)
- **CUDA** : GPU compatible CUDA avec prise en charge bf16
- **FFmpeg** : Requis pour la sortie vidéo
- **Packages Python** : `safetensors`, `torch`, `numpy`

## Configuration du modèle

Téléchargez les poids du modèle depuis [HuggingFace](https://huggingface.co/GAIR/daVinci-MagiHuman) :

```bash
cd ComfyUI/models

# Clone without large files
GIT_LFS_SKIP_SMUDGE=1 git clone https://huggingface.co/GAIR/daVinci-MagiHuman

cd daVinci-MagiHuman

# Pull only what you need (skip 540p_sr if you only want 1080p)
git lfs pull --include="distill/*,turbo_vae/*"        # ~61GB - base generation
git lfs pull --include="1080p_sr/*"                    # ~61GB - 1080p upscaling
```

Structure de répertoires attendue :
```
ComfyUI/models/daVinci-MagiHuman/
├── distill/          # 8-step distilled model (~61GB)
├── 1080p_sr/         # Super-resolution model (~61GB)
├── turbo_vae/        # Fast decoder (small)
├── base/             # Full 32-step model (optional, ~30GB)
└── 540p_sr/          # 540p SR (optional, ~61GB)
```

## Guide VRAM

| `blocks_on_gpu` | Utilisation VRAM | Vitesse | Recommandé pour |
|-----------------|------------------|---------|-----------------|
| 4 | ~3GB + surcharge | Le plus lent | GPUs 16GB |
| 8 | ~6GB + surcharge | Bon | GPUs 24-32GB |
| 16 | ~12GB + surcharge | Rapide | GPUs 48GB |
| 40 | ~30GB | Le plus rapide | GPUs 80GB+ |

## Encodeur de texte

daVinci-MagiHuman utilise T5Gemma-9B comme encodeur de texte. Le nœud **DaVinci Text Encode** fournit actuellement :

- **Embeddings de substitution** pour les tests de pipeline (bruit aléatoire — ne produit pas de sortie significative)
- **Entrée T5 externe** — connecter des embeddings T5 pré-calculés (3584 dim) depuis un autre nœud encodeur

Pour une utilisation en production, connectez un nœud encodeur T5-XXL ou T5Gemma à l’entrée `t5_embeds`.

## Architecture

Le modèle est un transformeur à flux unique qui génère conjointement vidéo et audio :

- **15 milliards de paramètres**, 40 couches de transformeur
- **Taille cachée** : 5120, **GQA** : 40 têtes de requête / 8 KV, **Dimension tête** : 128
- **Couches sandwich** : 0-3 et 36-39 ont des normes par modalité (vidéo/audio/texte)
- **Couches partagées** : 4-35 utilisent un traitement unifié
- **Sans incrément de temps** : Pas d’incrément explicite — infère l’état de débruitage depuis l’entrée
- **Gate par tête** : Sigmoïdes apprises sur chaque tête d’attention

## Crédits

- [daVinci-MagiHuman](https://huggingface.co/GAIR/daVinci-MagiHuman) par SII-GAIR & Sand.ai
- [MagiCompiler](https://github.com/SandAI-org/MagiCompiler) pour la fusion d’opérateurs
- Basé sur Wan2.2 et TurboVAED

## Licence

Apache 2.0


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---