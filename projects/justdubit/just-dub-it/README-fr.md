# JustDubit : Doublage vidéo via diffusion audio-visuelle conjointe

[![Site web](https://img.shields.io/badge/Project-Page-181717?logo=google-chrome)](https://justdubit.github.io)
[![Modèle](https://img.shields.io/badge/HuggingFace-Model-orange?logo=huggingface)](https://huggingface.co/justdubit/justdubit)
[![Jeu de données](https://img.shields.io/badge/HuggingFace-Dataset-blue?logo=huggingface)](https://huggingface.co/datasets/justdubit/audiovisual_translation_dub/settings)

## 📰 Actualités

- [2026/02/10] 🔥 Code, checkpoints et données publiés
- [2026/01/29] 🔥 Rapport technique publié


---

## 📄 Résumé

Les modèles fondamentaux audio-visuels, préentraînés pour générer conjointement du son et du contenu visuel, ont récemment montré une capacité sans précédent à modéliser la génération et l’édition multimodales, ouvrant de nouvelles opportunités pour les tâches en aval.

Parmi ces tâches, le doublage vidéo pourrait grandement bénéficier de tels savoirs, pourtant la plupart des solutions existantes reposent encore sur des pipelines complexes et spécifiques à la tâche qui peinent dans des contextes réels.

Dans ce travail, nous introduisons une approche mono-modèle qui adapte un modèle fondamental de diffusion audio-vidéo pour le doublage vidéo à vidéo via un LoRA léger. Le LoRA permet au modèle de se conditionner sur une entrée audio-vidéo tout en générant conjointement un audio traduit et un mouvement facial synchronisé.

Pour entraîner ce LoRA, nous exploitons le modèle génératif lui-même pour synthétiser des vidéos multilingues appariées du même locuteur. Plus précisément, nous générons des vidéos multilingues avec des changements de langue au sein d’un même clip, puis nous retouchons le visage et l’audio dans chaque moitié pour correspondre à la langue de l’autre moitié.

En tirant parti du riche savoir génératif du modèle audio-visuel, notre approche préserve l’identité du locuteur et la synchronisation labiale tout en restant robuste aux mouvements complexes et aux dynamiques du monde réel. Nous démontrons que notre approche produit des vidéos doublées de haute qualité avec une fidélité visuelle, une synchronisation labiale et une robustesse améliorées par rapport aux pipelines de doublage existants.

---

## 🚀 Liens rapides

| Ressource | Description |
|----------|-------------|
| [**Pipeline d’inférence**](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-pipelines/README.md) | Exécuter le doublage vidéo avec le pipeline JustDubit |
| [**Guide d’entraînement**](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-trainer/README.md) | Entraîner votre propre LoRA JustDubit |

---

## 📦 Structure du dépôt

```
just-dub-it/
├── packages/
│   ├── ltx-pipelines/     # Inference pipeline for video dubbing
│   │   └── README.md      # Pipeline usage guide
│   ├── ltx-trainer/       # Training tools for JustDubit LoRA
│   │   └── README.md      # Training guide
│   └── ltx-core/          # Core model components
└── README.md              # This file
```

---

## 🎬 Inférence

Voir le [README du pipeline](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-pipelines/README.md) pour :
- Instructions d'installation
- Téléchargements des checkpoints de modèle
- Guide de format de prompt
- Référence des arguments CLI

---

## 🏋️ Entraînement

Voir le [README du Trainer](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-trainer/README.md) pour :
- Téléchargement et préparation du dataset
- Pipeline de prétraitement
- Configuration de l'entraînement
- Configuration multi-GPU pour l'entraînement




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-20

---