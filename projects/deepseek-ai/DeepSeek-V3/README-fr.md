<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Lien vers l’article</b>👁️</a>
</div>

## Table des matières

1. [Introduction](#1-introduction)
2. [Résumé du modèle](#2-résumé-du-modèle)
3. [Téléchargements du modèle](#3-téléchargements-du-modèle)
4. [Résultats d’évaluation](#4-résultats-d’évaluation)
5. [Site de Chat & Plateforme API](#5-site-de-chat--plateforme-api)
6. [Comment exécuter localement](#6-comment-exécuter-localement)
7. [Licence](#7-licence)
8. [Citation](#8-citation)
9. [Contact](#9-contact)


## 1. Introduction

Nous présentons DeepSeek-V3, un puissant modèle de langage Mixture-of-Experts (MoE) avec 671 milliards de paramètres totaux dont 37 milliards activés par jeton.  
Pour atteindre une inférence efficace et un entraînement économique, DeepSeek-V3 adopte les architectures Multi-head Latent Attention (MLA) et DeepSeekMoE, validées en profondeur dans DeepSeek-V2.  
De plus, DeepSeek-V3 innove avec une stratégie d’équilibrage de charge sans perte auxiliaire et définit un objectif d’entraînement de prédiction multi-jetons pour des performances accrues.  
Nous pré-entraînons DeepSeek-V3 sur 14,8 billions de jetons diversifiés et de haute qualité, suivis par des étapes de fine-tuning supervisé et d’apprentissage par renforcement pour exploiter pleinement ses capacités.  
Des évaluations complètes révèlent que DeepSeek-V3 surpasse les autres modèles open-source et atteint des performances comparables aux modèles propriétaires de pointe.  
Malgré ses excellentes performances, DeepSeek-V3 ne requiert que 2,788 millions d’heures GPU H800 pour son entraînement complet.  
De plus, le processus d’entraînement est remarquablement stable.  
Tout au long de l’entraînement, nous n’avons rencontré aucune montée de perte irrécupérable ni effectué de retour arrière.  
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. Résumé du modèle

---

**Architecture : Stratégie innovante d’équilibrage de charge et objectif d’entraînement**

- Sur la base de l’architecture efficace de DeepSeek-V2, nous innovons avec une stratégie d’équilibrage de charge sans perte auxiliaire, minimisant la dégradation des performances causée par l’équilibrage de charge.
- Nous étudions un objectif de Prédiction Multi-Jetons (MTP) et prouvons son intérêt pour les performances du modèle.  
  Il peut aussi être utilisé pour le décodage spéculatif afin d’accélérer l’inférence.

---

**Pré-entraînement : Vers une efficacité d’entraînement ultime**

- Nous concevons un cadre d’entraînement en précision mixte FP8 et, pour la première fois, validons la faisabilité et l’efficacité de l’entraînement FP8 sur un modèle à très grande échelle.  
- Grâce à la co-conception d’algorithmes, de frameworks et de matériel, nous surmontons le goulot d’étranglement de la communication dans l’entraînement MoE inter-nœuds, atteignant presque un recouvrement complet calcul-communication.  
  Cela améliore considérablement notre efficacité d’entraînement et réduit les coûts, nous permettant d’augmenter encore la taille du modèle sans surcoût.
- À un coût économique de seulement 2,664 millions d’heures GPU H800, nous terminons le pré-entraînement de DeepSeek-V3 sur 14,8T jetons, produisant le modèle open-source de base le plus puissant à ce jour. Les étapes d’entraînement suivantes après le pré-entraînement ne nécessitent que 0,1 million d’heures GPU.

---

**Post-entraînement : Distillation des connaissances depuis DeepSeek-R1**

- Nous introduisons une méthodologie innovante pour distiller les capacités de raisonnement du modèle long-Chain-of-Thought (CoT), en particulier d’un des modèles de la série DeepSeek R1, dans des LLM standards, notamment DeepSeek-V3. Notre pipeline intègre élégamment les motifs de vérification et de réflexion de R1 dans DeepSeek-V3 et améliore nettement ses performances de raisonnement. Nous conservons également le contrôle sur le style et la longueur de sortie de DeepSeek-V3.

---

## 3. Téléchargements du modèle

<div align="center">

| **Modèle** | **#Paramètres totaux** | **#Paramètres activés** | **Longueur de contexte** | **Téléchargement** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTE]
> La taille totale des modèles DeepSeek-V3 sur Hugging Face est de 685B, ce qui inclut 671B pour les poids du modèle principal et 14B pour les poids du module Multi-Token Prediction (MTP).

Pour garantir des performances et une flexibilité optimales, nous avons collaboré avec des communautés open-source et des fournisseurs matériels pour proposer plusieurs méthodes d’exécution locale du modèle. Pour des instructions détaillées, consultez la section 6 : [Comment exécuter localement](#6-comment-exécuter-localement).

Pour les développeurs souhaitant aller plus loin, nous recommandons d’explorer [README_WEIGHTS.md](./README_WEIGHTS.md) pour plus d’informations sur les poids du modèle principal et les modules MTP. Notez que la prise en charge de MTP est en cours de développement au sein de la communauté ; vos contributions et retours sont les bienvenus.

## 4. Résultats d’évaluation
### Modèle de base
#### Benchmarks standards

<div align="center">


|  | Benchmark (Métrique) | # Shots | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|---------------------|----------|--------|-------------|---------------|---------|
| | Architecture | - | MoE | Dense | Dense | MoE |
| | # Param. activés | - | 21B | 72B | 405B | 37B |
| | # Param. totaux | - | 236B | 72B | 405B | 671B |
| Anglais | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Acc.) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Acc.) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Acc.) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Acc.) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Acc.) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Acc.) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Acc.) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Acc.) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (Acc.) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (Acc.) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Acc.) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| Code | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Acc.) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Acc.) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| Math | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| Chinois | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Acc.) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Acc.) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Acc.) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Acc.) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| Multilingue | MMMLU-non-English (Acc.) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTE]
> Les meilleurs résultats sont en gras. Les scores avec un écart inférieur ou égal à 0,3 sont considérés du même niveau. DeepSeek-V3 atteint les meilleures performances sur la plupart des benchmarks, notamment en mathématiques et en programmation.
> Pour plus de détails d’évaluation, consultez notre article.

#### Fenêtre de contexte
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

Résultats d’évaluation sur les tests ``Needle In A Haystack`` (NIAH). DeepSeek-V3 affiche de bonnes performances sur toutes les longueurs de fenêtre de contexte jusqu’à **128K**.

### Modèle de chat
#### Benchmarks standards (modèles > 67B)
<div align="center">

| | **Benchmark (Métrique)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | Architecture | MoE | MoE | Dense | Dense | - | - | MoE |
| | # Param. activés | 21B | 21B | 72B | 405B | - | - | 37B |
| | # Param. totaux | 236B | 236B | 72B | 405B | - | - | 671B |
| Anglais | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correct) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Acc.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Acc.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| Code | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Percentile) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Resolved) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Acc.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Acc.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| Math | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| Chinois | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Correct) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTE]
> Tous les modèles sont évalués dans une configuration limitant la sortie à 8K. Les benchmarks comportant moins de 1000 échantillons sont testés plusieurs fois avec différentes températures afin d’obtenir des résultats robustes. DeepSeek-V3 est le meilleur modèle open-source testé, et affiche également des performances compétitives face aux modèles propriétaires de pointe.

####  Évaluation de génération ouverte

<div align="center">



| Modèle | Arena-Hard | AlpacaEval 2.0 |
|--------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!NOTE]
> Évaluations en conversation ouverte en anglais. Pour AlpacaEval 2.0, nous utilisons le taux de victoire contrôlé en longueur comme métrique.


## 5. Site de Chat & Plateforme API
Vous pouvez discuter avec DeepSeek-V3 sur le site officiel de DeepSeek : [chat.deepseek.com](https://chat.deepseek.com/sign_in)

Nous proposons également une API compatible OpenAI sur la plateforme DeepSeek : [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Comment exécuter localement

DeepSeek-V3 peut être déployé localement à l’aide du matériel et des logiciels open-source suivants :

1. **DeepSeek-Infer Demo** : Nous proposons une démo simple et légère pour l’inférence FP8 et BF16.
2. **SGLang** : Prise en charge complète du modèle DeepSeek-V3 en modes d’inférence BF16 et FP8, avec Multi-Token Prediction [à venir](https://github.com/sgl-project/sglang/issues/2591).
3. **LMDeploy** : Permet une inférence FP8 et BF16 efficace pour un déploiement local ou cloud.
4. **TensorRT-LLM** : Prise en charge actuelle de l’inférence BF16 et quantification INT4/8, la compatibilité FP8 arrive prochainement.
5. **vLLM** : Prise en charge du modèle DeepSeek-V3 en modes FP8 et BF16 pour le parallélisme de tenseur et le parallélisme de pipeline.
6. **LightLLM** : Prise en charge d’un déploiement efficace sur un ou plusieurs nœuds pour FP8 et BF16.
7. **AMD GPU** : Permet d’exécuter DeepSeek-V3 sur GPU AMD via SGLang en modes BF16 et FP8.
8. **Huawei Ascend NPU** : Prise en charge de DeepSeek-V3 sur les appareils Huawei Ascend.

Puisque l’entraînement FP8 est nativement adopté dans notre framework, nous ne fournissons que les poids FP8. Si vous avez besoin des poids BF16 pour vos expériences, vous pouvez utiliser le script de conversion fourni.

Exemple de conversion de poids FP8 vers BF16 :

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!NOTE]
> Transformers de Hugging Face n’est pas encore directement pris en charge.

### 6.1 Inférence avec la démo DeepSeek-Infer (exemple uniquement)

#### Prérequis système

> [!NOTE] 
> Linux avec Python 3.10 uniquement. Mac et Windows ne sont pas supportés.

Dépendances :
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### Préparation des poids du modèle & du code de démo

Clonez d’abord notre dépôt GitHub DeepSeek-V3 :

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

Rendez-vous dans le dossier `inference` et installez les dépendances listées dans `requirements.txt`. Le plus simple est d’utiliser un gestionnaire d’environnements comme `conda` ou `uv` pour créer un nouvel environnement virtuel et installer les dépendances.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

Téléchargez les poids du modèle depuis Hugging Face et placez-les dans le dossier `/path/to/DeepSeek-V3`.

#### Conversion des poids du modèle

Convertissez les poids du modèle Hugging Face vers le format spécifique :

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### Exécution

Vous pouvez alors discuter avec DeepSeek-V3 :

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

Ou faire une inférence par lot sur un fichier donné :

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 Inférence avec SGLang (recommandé)

[SGLang](https://github.com/sgl-project/sglang) prend actuellement en charge les [optimisations MLA](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [l’attention DP](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8 (W8A8), cache FP8 KV et Torch Compile, offrant des performances de latence et de débit de pointe parmi les frameworks open-source.

Notamment, [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) prend en charge l’exécution de DeepSeek-V3 sur **GPU NVIDIA et AMD**, ce qui en fait une solution très polyvalente et robuste.

SGLang prend également en charge le [parallélisme de tenseur multi-nœuds](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208), permettant d’exécuter ce modèle sur plusieurs machines connectées en réseau.

La Prédiction Multi-Jetons (MTP) est en développement, les avancées sont à suivre dans le [plan d’optimisation](https://github.com/sgl-project/sglang/issues/2591).

Voici les instructions de lancement de l’équipe SGLang : https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 Inférence avec LMDeploy (recommandé)
[LMDeploy](https://github.com/InternLM/lmdeploy), un framework d’inférence et de service flexible et haute performance dédié aux grands modèles de langage, supporte désormais DeepSeek-V3. Il propose à la fois le traitement pipeline hors ligne et le déploiement en ligne, s’intégrant parfaitement aux workflows basés sur PyTorch.

Pour des instructions détaillées sur l’utilisation de DeepSeek-V3 avec LMDeploy, consultez : https://github.com/InternLM/lmdeploy/issues/2960

### 6.4 Inférence avec TRT-LLM (recommandé)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) prend désormais en charge DeepSeek-V3, offrant des options de précision telles que BF16 et INT4/INT8 (poids uniquement). La prise en charge FP8 est en cours de développement et sera bientôt disponible. Vous pouvez accéder à la branche personnalisée de TRTLLM pour DeepSeek-V3 ici : https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3.

### 6.5 Inférence avec vLLM (recommandé)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6 prend en charge l’inférence DeepSeek-V3 pour les modes FP8 et BF16 sur GPU NVIDIA et AMD. Outre les techniques standards, vLLM propose le _parallélisme de pipeline_ permettant de faire tourner ce modèle sur plusieurs machines en réseau. Pour plus d’informations, consultez les [instructions vLLM](https://docs.vllm.ai/en/latest/serving/distributed_serving.html). Vous pouvez également suivre [le plan d’amélioration](https://github.com/vllm-project/vllm/issues/11539).

### 6.6 Inférence avec LightLLM (recommandé)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 prend en charge le déploiement tensoriel parallèle mono et multi-machine pour DeepSeek-R1 (FP8/BF16) et propose un déploiement en précision mixte, avec davantage de modes de quantification intégrés en continu. Pour plus de détails, consultez la [documentation LightLLM](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html). De plus, LightLLM offre un déploiement PD-disaggregation pour DeepSeek-V2, l’implémentation pour DeepSeek-V3 étant en cours de développement.

### 6.7 Fonctionnalité d’inférence recommandée sur GPU AMD

En collaboration avec l’équipe AMD, nous avons assuré une compatibilité Day-One des GPU AMD via SGLang, avec prise en charge complète FP8 et BF16. Pour plus de détails, consultez les [instructions SGLang](#63-inf%C3%A9rence-avec-lmdeploy-recommand%C3%A9).

### 6.8 Fonctionnalité d’inférence recommandée sur Huawei Ascend NPU
Le framework [MindIE](https://www.hiascend.com/en/software/mindie) de la communauté Huawei Ascend a adapté avec succès la version BF16 de DeepSeek-V3. Pour un guide étape par étape sur Ascend NPU, consultez les [instructions ici](https://modelers.cn/models/MindIE/deepseekv3).

## 7. Licence
Ce dépôt de code est sous licence [MIT License](LICENSE-CODE). L’utilisation des modèles DeepSeek-V3 Base/Chat est soumise à [la licence du modèle](LICENSE-MODEL). La série DeepSeek-V3 (Base et Chat inclus) est utilisable à des fins commerciales.

## 8. Citation
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. Contact
Pour toute question, veuillez ouvrir une issue ou nous contacter à [service@deepseek.com](service@deepseek.com).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---