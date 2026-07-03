# FlashVID : Modèles vidéo à grande échelle efficaces via fusion de tokens spatiotemporels arborescente sans entraînement

<div align="center">
<a href="https://scholar.google.com/citations?user=myU7V58AAAAJ&hl=en">Ziyang Fan</a><sup>1</sup>,&nbsp; <a href="https://github.com/Mirei124">Keyu Chen</a><sup>1</sup>,&nbsp; <a href="https://github.com/xrlexpert">Ruilong Xing</a><sup>1</sup>,&nbsp; <a href="https://scholar.google.com/citations?user=dQssXVsAAAAJ&hl=en">Yulin Li</a><sup>1</sup>,&nbsp; <a href="https://scholar.google.com/citations?user=5cIodxsAAAAJ&hl=en">Li Jiang</a><sup>2,3</sup>,&nbsp; <a href="https://scholar.google.com/citations?user=mEjhz-IAAAAJ&hl=en">Zhuotao Tian</a><sup>1,3*</sup>&nbsp;
<br>
<sup>1</sup> Institut de Technologie de Harbin (Shenzhen) &nbsp;&nbsp;&nbsp; <sup>2</sup> Université chinoise de Hong Kong (Shenzhen)<br> <sup>3</sup> Institut de la zone de boucle de Shenzhen
<br>
<sup>*</sup>Auteur correspondant
<br>
<a href='https://iclr.cc/'><img src='https://img.shields.io/badge/ICLR-2026-78CA2E.svg'></a> &nbsp;
<a href='https://openreview.net/forum?id=H6rDX4w6Al'><img src='https://img.shields.io/badge/Paper-Openreview-8D1B12.svg'></a> &nbsp;
<a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="License"></a> &nbsp;
<a href='https://fanziyang-v.github.io/FlashVID/'><img src='https://img.shields.io/badge/Project-Page-Green'></a> &nbsp;
<a href="https://arxiv.org/abs/2602.08024"><img src="https://img.shields.io/badge/arXiv-2602.08024-b31b1b.svg"></a> &nbsp;
<a href="https://huggingface.co/"><img src="https://img.shields.io/badge/transformers-4.57-FFD21E.svg" alt="transformers"></a> &nbsp;
<!-- <a href="https://python.org/"><img src="https://img.shields.io/badge/Python-3.10%2B-3776ab.svg" alt="Python"></a> &nbsp; -->
<!-- <a href="https://pytorch.org/"><img src="https://img.shields.io/badge/PyTorch-2.5%2B-DF3411.svg" alt="PyTorch"></a> &nbsp; -->
<!-- <a href="#"><img src="https://img.shields.io/badge/#.svg"></a> &nbsp; -->
</div>

## 🔖Table des matières

1. [Actualités](#news)
2. [Liste des tâches](#todo-list)
3. [Points forts](#highlights)
4. [Motivation](#motivation)
5. [Méthode](#method)
6. [Installation](#installation)
7. [Démarrage rapide](#quickstart)
8. [Évaluation](#evaluation)
9. [Remerciements](#acknowledgement)
10. [Citation](#citation)

## 🔥Actualités

- [2026.05.01] 🔍Correction d’un bug potentiel de manque de mémoire (OOM) lors de l’extraction manuelle de l’attention [CLS] dans Qwen2.5-VL et Qwen3-VL.
- [2026.02.10] 🚀Publication de notre article sur arXiv.
- [2026.02.06] 🍾Notre article a été sélectionné pour une **présentation orale** à **ICLR 2026**.
- [2026.02.01] ✨Publication du code FlashVID et des démonstrations d’inférence sur *Qwen2.5-VL* et *Qwen3-VL*.
- [2026.01.31] 🚀Ouverture au public de ce dépôt.
- [2026.01.30] ✨Publication du code FlashVID et des démonstrations d’inférence sur *LLaVA-OneVision* et *LLaVA-Video*.
- [2026.01.30] 👏Initialisation de ce dépôt GitHub.
- [2026.01.26] 🎉Notre méthode d’accélération d’inférence sans entraînement [FlashVID](https://openreview.net/forum?id=H6rDX4w6Al) a été acceptée à **ICLR 2026**.
- [2025.12.06] 🌟Publication du dépôt GitHub de [DyTok](https://github.com/yu-lin-li/DyToK).
- [2025.09.18] 🎉 Notre cadre d’accélération d’inférence sans entraînement [DyTok](https://www.arxiv.org/abs/2512.06866) a été accepté à **NeurIPS 2025**.

## 📋Liste des tâches

- [ ] Optimiser l’efficacité du code
- [x] Publier le code FlashVID sur LLaVA-OneVision et LLaVA-Video.
- [x] Publier les démonstrations d’inférence sur différents Video LLMs avec FlashVID.
- [x] Supporter l’évaluation avec [LMMs-Eval](https://github.com/EvolvingLMMs-Lab/lmms-eval).
- [x] Publier le code FlashVID sur Qwen2.5-VL et Qwen3-VL.
- [x] Publier notre article sur arXiv.

## ✨Points forts

![FlashVID Teaser](https://raw.githubusercontent.com/Fanziyang-v/FlashVID/main/assets/teaser.png)

1. Notre FlashVID surpasse significativement les cadres d’accélération à la pointe précédents (par ex., VisionZip, FastVID) sur **trois** VLLMs représentatifs (c.-à-d. LLaVA-OneVision, LLaVA-Video, Qwen2.5-VL) sur **cinq** benchmarks largement utilisés pour la compréhension vidéo (c.-à-d. VideoMME, EgoSchema, LongVideoBench, MVBench, MLVU).
2. FlashVID peut servir de module plug-and-play sans entraînement pour étendre les frames vidéo longues, permettant une augmentation par un facteur **10x** de l’entrée de frames vidéo à Qwen2.5-VL, avec un gain de **8,6%** dans le même budget computationnel.
3. Les méthodes existantes efficaces pour Video LLM compressent souvent indépendamment la redondance spatiale et temporelle, négligeant les relations spatiotemporelles intrinsèques dans les vidéos. Pour y remédier, nous présentons une solution **simple mais efficace** : la fusion de tokens spatiotemporels basée sur un arbre (TSTM) pour une compression fine de la redondance spatiotemporelle.

## 💡Motivation

![Motivation](https://raw.githubusercontent.com/Fanziyang-v/FlashVID/main/assets/motivation.png)

Dans ce travail, nous identifions deux observations clés sur la redondance spatiotemporelle dans les vidéos :

1. **La redondance temporelle n’est pas liée à des emplacements spatiaux fixes.** Les éléments sémantiquement cohérents dans les vidéos se déplacent souvent en position spatiale, échelle ou apparence à cause du mouvement et de la dynamique de la scène, rendant la correspondance spatiale rigide entre les frames peu fiable.
2. **La redondance spatiale et temporelle est intrinsèquement couplée.** Les régions redondantes dans une seule frame persistent fréquemment à travers plusieurs frames. Une compression spatiotemporelle découplée néglige les relations spatiotemporelles intrinsèques, conduisant à une compression sous-optimale.

Pour obtenir une meilleure compression de la redondance spatiotemporelle, nous présentons une solution **simple mais efficace** : **Tree-based Spatiotemporal Token Merging (TSTM)** pour une compression fine de la redondance spatiotemporelle, complétée par le module **Attention and Diversity-based Token Selection (ADTS)** pour la sélection de tokens informatifs.

## 🌈Méthode

![Method](https://raw.githubusercontent.com/Fanziyang-v/FlashVID/main/assets/method.png)

**Illustration de FlashVID**. Nous compressons les tokens visuels via deux modules synergiques.

1. **Sélection de jetons basée sur l'attention et la diversité (ADTS)** priorise les jetons spatiotemporellement informatifs tout en garantissant la diversité des caractéristiques en résolvant un Problème de Diversité Max-Min calibré (MMDP);
2. **Fusion de jetons spatiotemporels basée sur un arbre (TSTM)** modélise la redondance par des arbres de redondance spatiotemporelle, qui capturent efficacement la dynamique fine des vidéos. Chaque arbre de redondance sera agrégé en une seule représentation de jeton.


## 📦Installation

Dans ce projet, nous utilisons [uv](https://github.com/astral-sh/uv) pour la gestion des paquets.

1. **Clonez ce dépôt et naviguez jusqu'au dossier FlashVID :**

```bash
git clone https://github.com/Fanziyang-v/FlashVID.git
cd FlashVID
```

2. **Installer le package d'inférence :**

```bash
uv sync
```

## 🚀Démarrage rapide

Le code de FlashVID est facile à utiliser et fonctionne immédiatement. Il suffit d'encapsuler le modèle avec la fonction `flashvid()`. Actuellement, FlashVID prend en charge LLaVA-OneVision, LLaVA-Video, Qwen2.5-VL et Qwen3-VL.

```python
from flashvid import flashvid

model = flashvid(
    model,
    retention_ratio=0.1,
    alpha=0.7,
    temporal_threshold=0.8,
)
```

📝**Remarque** : Vous pouvez remplacer les paramètres par défaut (par exemple, le taux de rétention) dans la fonction wrapper `flashvid()`.

Des démonstrations d'inférence sont fournies dans `playground/`. Voici un exemple en cours d'exécution :

```bash
python playground/llava_ov_infer.py \
    --video-path assets/Qgr4dcsY-60.mp4 \
    --question "Describe the video in detail." \
    --num-frames 32 \
    --enable-flashvid
```

## 📊Évaluation

Dans ce projet, toutes les expériences sont réalisées en utilisant [LMMs-Eval](https://github.com/EvolvingLMMs-Lab/lmms-eval). Nous fournissons des scripts d'évaluation FlashVID dans `scripts/`, incluant LLaVA-OneVision, LLaVA-Video, Qwen2.5-VL, et Qwen3-VL. Vous pouvez exécuter les scripts pour reproduire nos résultats expérimentaux :

```bash
bash scripts/llava_ov.sh
```

📝**Note** : Il est extrêmement facile d’intégrer FlashVID dans LMMs-Eval en ajoutant des paramètres spécifiques dans `__init__()` et en enveloppant le modèle chargé avec la fonction `flashvid()`. (Voir `lmms_eval/models/simple/llava_onevision.py`)

## 👏Remerciements

Ce projet est construit sur des travaux open-source récents : [FastV](https://github.com/pkunlp-icler/FastV), [VisionZip](https://github.com/dvlab-research/VisionZip), [PruneVID](https://github.com/visual-ai/prunevid), [FastVID](https://github.com/LunarShen/FastVID), [LLaVA-NeXT](https://github.com/LLaVA-VL/LLaVA-NeXT), [Qwen2.5-VL/Qwen3-VL](https://github.com/QwenLM/Qwen3-VL), [LMMs-Eval](https://github.com/EvolvingLMMs-Lab/lmms-eval). Merci pour leur excellent travail !

## 📜Citation

Si vous trouvez ce projet utile dans vos recherches, veuillez envisager de le citer :

```bib
@inproceedings{
    fan2026flashvid,
    title={Flash{VID}: Efficient Video Large Language Models via Training-free Tree-based Spatiotemporal Token Merging},
    author={Ziyang Fan and Keyu Chen and Ruilong Xing and Yulin Li and Li Jiang and Zhuotao Tian},
    booktitle={The Fourteenth International Conference on Learning Representations},
    year={2026},
    url={https://openreview.net/forum?id=H6rDX4w6Al}
}
```

## ⭐️Star History

[![Star History Chart](https://api.star-history.com/svg?repos=Fanziyang-v/FlashVID&type=Date)](https://star-history.com/#Fanziyang-v/FlashVID&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-03

---