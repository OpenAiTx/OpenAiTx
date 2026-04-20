<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Démo en ligne"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  Si vous trouvez ce projet utile,<br>
  une étoile ⭐ sur GitHub serait grandement appréciée !
</p>

---

## Structure du dépôt

Ce dépôt GitHub **ThinkSound** héberge deux projets liés sur des branches séparées :

| Branche | Projet | Documentation |
|---------|--------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — génération Any2Audio unifiée avec appariement de flux guidé par CoT | Ce fichier : **`README.md`** |
| **`prismaudio`** | **PrismAudio** — suite des travaux (ICLR 2026) sur la conversion vidéo-vers-audio avec CoT-RL multi-dimensionnel | **`README.md`** sur la branche [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) |

Pour **ThinkSound**, utilisez la branche **`master`** (ce README). Pour **PrismAudio**, consultez **`prismaudio`** et suivez le **`README.md`** associé.

---

**ThinkSound** est un cadre unifié de génération Any2Audio avec appariement de flux guidé par un raisonnement de type Chain-of-Thought (CoT).

Implémentation PyTorch pour la génération et l’édition audio multimodales : générez ou éditez de l’audio à partir de vidéo, texte et audio, grâce au raisonnement pas à pas des grands modèles de langage multimodal (MLLM).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Actualités
- **2026.03.24** &nbsp; 🔥 **PrismAudio** est publié dans le même dépôt sur la branche [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) — voir **`README.md`** pour la configuration et les modèles.
- **2026.01.26** &nbsp; 🎉 PrismAudio accepté à la **Conférence Principale ICLR 2026** (code/docs sur `prismaudio`).
- **2025.11.25** &nbsp; 🔥 [Démo PrismAudio en ligne](http://prismaudio-project.github.io/) disponible.
- **2025.11.25** &nbsp; 🔥 [Article PrismAudio](https://arxiv.org/pdf/2511.18833) sur arXiv — CoT-RL multi-dimensionnel pour la vidéo-vers-audio.
- **2025.09.19** &nbsp; 🎉 **ThinkSound** accepté à la **Conférence Principale NeurIPS 2025** !
- **2025.09.01** &nbsp; Notre jeu de données AudioCoT est désormais open source et disponible sur [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT) !
- **2025.07.17** &nbsp; 🧠 Finetuning activé : code d’entraînement et d’ajustement fin désormais public, avec instructions claires pour personnaliser et étendre ThinkSound avec vos propres données.
- **2025.07.15** &nbsp; 📦 Installation et utilisation simplifiées : dépendances sur PyPI pour une configuration multiplateforme facile ; scripts Windows `.bat` pour automatiser la création d’environnement et l’exécution des scripts.
- **2025.07.08** &nbsp;  🔧 Mise à jour majeure : modèle allégé et optimisation de la mémoire et de l’utilisation GPU, supporte désormais la génération audio à haut débit à grande échelle !
- **2025.07.01** &nbsp; Démo en ligne sur [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) et [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) pour une expérience interactive !
- **2025.07.01** &nbsp; Scripts d’inférence et interface web publiés ; 
- **2025.06** &nbsp; [Article ThinkSound](https://arxiv.org/pdf/2506.21448) publié sur arXiv !
- **2025.06** &nbsp; [Démo en ligne](http://thinksound-project.github.io/) disponible - essayez-la dès maintenant !

---


<div align="center">

### Suite : PrismAudio (même dépôt, branche `prismaudio`)

**PrismAudio** est le successeur de ThinkSound (ICLR 2026), développé sous un nouveau nom mais conservé dans ce dépôt sur la branche **`prismaudio`**. L'installation, les checkpoints et la citation sont dans le **[`README.md` de cette branche](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**.

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) ou ouvrez la branche sur GitHub.

</div>

---


## 🚀 Fonctionnalités

- **Any2Audio** : Génération audio à partir de n'importe quelle modalité — vidéo, texte, audio ou leurs combinaisons.
- **Video-to-Audio SOTA** : Atteint des résultats à l'état de l'art sur plusieurs benchmarks V2A.
- **Raisonnement CoT** : Raisonnement Chain-of-Thought pour une génération audio compositionnelle et contrôlable via MLLMs.
- **Édition interactive centrée sur les objets** : Affinez ou éditez des événements sonores spécifiques en cliquant sur des objets visuels ou en utilisant des instructions textuelles.
- **Cadre unifié** : Un modèle fondationnel unique prend en charge la génération, l'édition et le workflow interactif.

---

## ✨ Aperçu de la méthode

ThinkSound décompose la génération et l'édition audio en trois étapes interactives, toutes guidées par un raisonnement Chain-of-Thought (CoT) basé sur MLLM :

1. **Génération Foley :** Génération de paysages sonores fondamentaux, sémantiquement et temporellement alignés à partir de la vidéo.
2. **Affinement centré sur les objets :** Affinez ou ajoutez des sons pour des objets spécifiés par l'utilisateur via des clics ou des régions dans la vidéo.
3. **Édition audio ciblée :** Modifiez l'audio généré à l'aide d'instructions en langage naturel de haut niveau.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Un jeu de données annoté à grande échelle CoT (**AudioCoT**) est utilisé pour entraîner le module de raisonnement et le modèle audio fondationnel unifié.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Démarrage rapide

**Préparation de l'environnement :**
```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **Astuce Windows :**  
> Les utilisateurs de Windows peuvent simplement exécuter `setup_windows.bat` (ou double-cliquer dessus) pour créer automatiquement l'environnement conda, installer toutes les dépendances (y compris FFmpeg) et télécharger le modèle pré-entraîné — aucune configuration manuelle n'est requise.  
> Assurez-vous que `conda` et `git` sont installés et disponibles dans le PATH de votre système avant d'exécuter le script.


### ▶️ Exécuter la démo

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

Vous pouvez utiliser le script `.bat` fourni à la place :


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**Remarque :**

* `<chemin-vers-votre-vidéo-démo>` : Le chemin vers une seule vidéo
* `[utiliser-half]` (optionnel) : Ajoutez utiliser-half à la fin pour activer l’extraction de caractéristiques en demi-précision.

---

### 📦 Inférence par lot

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

Utilisez le script `.bat` équivalent :


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**Remarque :**

* `<video_path>` : Chemin vers le répertoire racine contenant toutes les vidéos .mp4 à traiter (toutes les vidéos doivent avoir la même durée).
* `<csv_path>` : Un fichier CSV avec les invites textuelles pour chaque vidéo (voir `demo_test.csv` pour le format).
* `<save_path>` (optionnel) : Emplacement où enregistrer l'audio généré. Par défaut `results/features`.
* `[use-half]` (optionnel) : Ajoutez use-half à la fin pour activer l'extraction de caractéristiques en demi-précision.

---


### Utilisation de l’interface Web

Pour une expérience interactive, lancez l’interface web Gradio :


```bash
python app.py
```
## 🏋️ Entraîner le modèle

Voir [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---


## 📄 Licence

Ce projet est publié sous la licence Apache 2.0.

> **Remarque :**
> Le code, les modèles et le jeu de données sont **uniquement destinés à la recherche et à l'éducation**.
> **L'utilisation commerciale N'EST PAS autorisée.**
> Pour une licence commerciale, veuillez contacter les auteurs.

**📦 Composants tiers**

* **Stable Audio Open VAE** (par Stability AI) :
  Ce dépôt inclut un VAE affiné issu de [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), sous licence [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **L'utilisation commerciale et la redistribution nécessitent l'autorisation préalable de Stability AI.**

* 📘 **Tout le reste du code et des modèles** est publié sous licence Apache 2.0.

---

## Remerciements

Un grand merci à :

* **stable-audio-tools** (par Stability AI) :
Pour avoir fourni un cadre simple pour la génération audio, ainsi que le module VAE et les poids.
* **MMAudio** :
  Pour l’implémentation de l’architecture MM-DiT dans le domaine audio.

---



## 📖 Citation

Si vous trouvez notre projet utile dans vos recherches ou votre travail, veuillez citer notre article :

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---