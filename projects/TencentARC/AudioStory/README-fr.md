# AudioStory : Génération d'audio narratif long format avec de grands modèles de langage

**[Yuxin Guo<sup>1,2</sup>](https://scholar.google.com/citations?user=x_0spxgAAAAJ&hl=en),  
[Teng Wang<sup>2,&#9993;</sup>](http://ttengwang.com/),  
[Yuying Ge<sup>2</sup>](https://geyuying.github.io/),  
[Shijie Ma<sup>1,2</sup>](https://mashijie1028.github.io/),  
[Yixiao Ge<sup>2</sup>](https://geyixiao.com/),  
[Wei Zou<sup>1</sup>](https://people.ucas.ac.cn/~zouwei),  
[Ying Shan<sup>2</sup>](https://scholar.google.com/citations?user=4oXBp9UAAAAJ&hl=en)**  
<br>  
<sup>1</sup>Institut d’Automatisation, CAS  
<sup>2</sup>ARC Lab, Tencent PCG  
<br>  

## 📖 Publication

[2025/8/28] 🔥🔥 Nous publions le code d’inférence !

[2025/8/28] 🔥🔥 Nous publions nos vidéos de démonstration !

## 🔎 Introduction

![audiostory](https://raw.githubusercontent.com/TencentARC/AudioStory/main/audiostory.png)

✨ **TL; DR : Nous proposons un modèle de génération audio narrative long format basé sur un cadre unifié de compréhension–génération, capable de gérer le doublage vidéo, la continuation audio et la synthèse audio narrative longue.**

Les avancées récentes dans la génération texte-à-audio (TTA) excellent à synthétiser de courts clips audio mais peinent avec l’audio narratif long format, qui requiert cohérence temporelle et raisonnement compositionnel. Pour combler ce vide, nous proposons AudioStory, un cadre unifié intégrant de grands modèles de langage (LLM) avec des systèmes TTA pour générer des narrations audio longues et structurées. AudioStory possède de fortes capacités de génération raisonnée suivant des instructions. Il utilise les LLM pour décomposer des requêtes narratives complexes en sous-tâches ordonnées temporellement avec des indices contextuels, permettant des transitions de scènes cohérentes et une consistance du ton émotionnel. AudioStory présente deux caractéristiques attrayantes :

1) Mécanisme de liaison découplé : AudioStory dissocie la collaboration LLM-diffuseur en deux composants spécialisés — une requête de liaison pour l’alignement sémantique intra-événement et une requête de cohérence pour la préservation de la cohérence inter-événements.  
2) Entraînement de bout en bout : En unifiant la compréhension des instructions et la génération audio dans un cadre unique de bout en bout, AudioStory élimine le besoin de pipelines d’entraînement modulaires tout en renforçant la synergie entre les composants.  
    De plus, nous établissons un benchmark AudioStory-10K, englobant divers domaines tels que paysages sonores animés et narrations de sons naturels.

Des expériences approfondies démontrent la supériorité d’AudioStory tant sur la génération audio unique que sur la génération audio narrative, surpassant les baselines TTA antérieures en capacité de suivi d’instructions et fidélité audio.







## ⭐ Démos

### 1. Doublage vidéo (style Tom & Jerry)
> Le doublage est réalisé à l'aide d'AudioStory (entraîné sur Tom & Jerry) avec des sous-titres visuels extraits des vidéos.

<table class="center">
  <td><video src="https://github.com/user-attachments/assets/f06b5999-6649-44d3-af38-63fdcecd833c"></video></td>
  <td><video src="https://github.com/user-attachments/assets/17727c2a-bfea-4252-9aa8-48fc9ac33500"></video></td>
  <td><video src="https://github.com/user-attachments/assets/09589d82-62c9-47a6-838a-5a62319f35e2"></video></td>
  <tr>
</table >


### 2. Doublage vidéo inter-domaines (style Tom & Jerry)

<table class="center">
    <td><video src="https://github.com/user-attachments/assets/e62d0c09-cdf0-4e51-b550-0a2c23f8d68d"></video></td>
    <td><video src="https://github.com/user-attachments/assets/736d22ca-6636-4ef0-99f3-768e4dfb112a"></video></td>
    <td><video src="https://github.com/user-attachments/assets/f2f7c94c-7f72-4cc0-8edc-290910980b04"></video></td>
  <tr>
  <td><video src="https://github.com/user-attachments/assets/d3e58dd4-31ae-4e32-aef1-03f1e649cb0c"></video></td>
  <td><video src="https://github.com/user-attachments/assets/4f68199f-e48a-4be7-b6dc-1acb8d377a6e"></video></td>
  <td><video src="https://github.com/user-attachments/assets/062236c3-1d26-4622-b843-cc0cd0c58053"></video></td>
	<tr>
  <td><video src="https://github.com/user-attachments/assets/8931f428-dd4d-430f-9927-068f2912dd36"></video></td>
  <td><video src="https://github.com/user-attachments/assets/ab7e46d5-f42c-472e-b66e-df786b658210"></video></td>      
  <td><video src="https://github.com/user-attachments/assets/9a0998ad-b5a4-42ac-bdaf-ceaf796fc586"></video></td>
  <tr>
</table >



### 3. Texte vers audio long (Son naturel)

<table class="center">
  <td style="text-align:center;" width="480">Instruction : "Développez un audio complet qui représente pleinement Jake Shimabukuro interprétant un morceau complexe de ukulélé en studio, reçoit des applaudissements, et parle de sa carrière lors d'une interview. La durée totale est de 49,9 secondes."</td>
  <td><video src="https://github.com/user-attachments/assets/461e8a34-4217-454e-87b3-e4285f36ec43"></video></td>
	<tr>
  <td style="text-align:center;" width="480">Instruction : "Développez un audio complet qui représente pleinement un camion de pompiers quittant la caserne avec les sirènes hurlantes, signalant une intervention d'urgence, et s'éloignant. La durée totale est de 35,1 secondes."</td>
  <td><video src="https://github.com/user-attachments/assets/aac0243f-5d12-480e-9850-a7f6720e4f9c"></video></td>
	<tr>
     <td style="text-align:center;" width="480">Instruction : "Comprendre l'audio d'entrée, déduire les événements suivants, et générer l'audio continu du coach donnant des leçons de basketball aux joueurs. La durée totale est de 36,6 secondes."</td>    
    <td><video src="https://github.com/user-attachments/assets/c4ed306a-651e-43d6-aeea-ee159542418a"></video></td>
	<tr>
</table >




## 🔎 Méthodes

![audiostory_framework](https://raw.githubusercontent.com/TencentARC/AudioStory/main/audiostory_framework.png)

Pour parvenir à une génération audio suivant efficacement les instructions, la capacité à comprendre l'instruction ou le flux audio d'entrée et à raisonner sur les sous-événements audio pertinents est essentielle. À cette fin, AudioStory adopte un cadre unifié de compréhension-génération (Fig.). Plus précisément, donné une instruction textuelle ou une entrée audio, le LLM l'analyse et la décompose en sous-événements audio structurés avec contexte. Sur la base des sous-événements déduits, le LLM effectue une **génération par raisonnement entrelacé**, produisant séquentiellement des légendes, des tokens sémantiques, et des tokens résiduels pour chaque clip audio. Ces deux types de tokens sont fusionnés et transmis au DiT, reliant efficacement le LLM au générateur audio. Grâce à un entraînement progressif, AudioStory atteint finalement à la fois une forte compréhension des instructions et une génération audio de haute qualité.



## 🔩 Installation

### Dépendances

* Python >= 3.10 (Recommandé d'utiliser [Anaconda](https://www.anaconda.com/download/#linux))
* [PyTorch >=2.1.0](https://pytorch.org/)
* GPU NVIDIA + [CUDA](https://developer.nvidia.com/cuda-downloads)

### Installation

```
git clone https://github.com/TencentARC/AudioStory.git
cd AudioStory
conda create -n audiostory python=3.10 -y
conda activate audiostory
bash install_audiostory.sh
```



## 📊 Evaluation

### inference

```
python evaluate/inference.py --model_path /path/to/ckpt --guidance 4.0 --save_folder_name audiostory --total_duration 50
```
## 🔋 Remerciements

Lors de la création de la base de code des débruiteurs continus, nous nous sommes référés à [SEED-X](https://github.com/AILab-CVC/SEED-X) et [TangoFlux](https://github.com/declare-lab/TangoFlux). Merci pour leurs projets remarquables.



## 📆 À FAIRE

- [ ] Publier notre démonstration gradio.
- [ ] Publier les points de contrôle d'AudioStory.
- [ ] Publier les codes d'entraînement des trois étapes.



## 📜 Licence

Ce dépôt est sous la [Licence Apache 2](https://github.com/mashijie1028/Gen4Rep/blob/main/LICENSE).



## 📚 BibTeX




```
@misc{guo2025audiostory,
      title={AudioStory: Generating Long-Form Narrative Audio with Large Language Models}, 
      author={Yuxin Guo and Teng Wang and Yuying Ge and Shijie Ma and Yixiao Ge and Wei Zou and Ying Shan},
      year={2025},
      eprint={2508.20088},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2508.20088}, 
}
```
## 📧 Contact

Si vous avez d'autres questions, n'hésitez pas à me contacter : guoyuxin2021@ia.ac.cn

Les discussions et les collaborations potentielles sont également les bienvenues.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-01

---