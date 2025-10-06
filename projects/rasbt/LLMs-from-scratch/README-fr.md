# Construire un Grand Modèle de Langage (De A à Z)

Ce dépôt contient le code pour développer, préentraîner et affiner un LLM de type GPT et constitue le dépôt officiel du livre [Construire un Grand Modèle de Langage (De A à Z)](https://amzn.to/4fqvn0D).

<br>
<br>

<a href="https://amzn.to/4fqvn0D"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/cover.jpg?123" width="250px"></a>

<br>

Dans [*Construire un Grand Modèle de Langage (De A à Z)*](http://mng.bz/orYv), vous apprendrez et comprendrez le fonctionnement interne des grands modèles de langage (LLM) en les codant de zéro, étape par étape. Dans ce livre, je vous guide à travers la création de votre propre LLM, en expliquant chaque étape avec un texte clair, des diagrammes et des exemples.

La méthode décrite dans ce livre pour entraîner et développer votre propre modèle petit mais fonctionnel à des fins éducatives reflète l’approche utilisée pour créer des modèles fondamentaux à grande échelle comme ceux derrière ChatGPT. De plus, ce livre inclut du code pour charger les poids de modèles préentraînés plus grands afin de les affiner.

- Lien vers le [dépôt officiel du code source](https://github.com/rasbt/LLMs-from-scratch)
- [Lien vers le livre chez Manning (site de l’éditeur)](http://mng.bz/orYv)
- [Lien vers la page du livre sur Amazon.com](https://www.amazon.com/gp/product/1633437167)
- ISBN 9781633437166

<a href="http://mng.bz/orYv#reviews"><img src="https://sebastianraschka.com//images/LLMs-from-scratch-images/other/reviews.png" width="220px"></a>


<br>
<br>

Pour télécharger une copie de ce dépôt, cliquez sur le bouton [Download ZIP](https://github.com/rasbt/LLMs-from-scratch/archive/refs/heads/main.zip) ou exécutez la commande suivante dans votre terminal :

```bash
git clone --depth 1 https://github.com/rasbt/LLMs-from-scratch.git
```

<br>

(If you downloaded the code bundle from the Manning website, please consider visiting the official code repository on GitHub at [https://github.com/rasbt/LLMs-from-scratch](https://github.com/rasbt/LLMs-from-scratch) for the latest updates.)

<br>
<br>


# Table of Contents

Please note that this `README.md` file is a Markdown (`.md`) file. If you have downloaded this code bundle from the Manning website and are viewing it on your local computer, I recommend using a Markdown editor or previewer for proper viewing. If you haven't installed a Markdown editor yet, [Ghostwriter](https://ghostwriter.kde.org) is a good free option.

You can alternatively view this and other files on GitHub at [https://github.com/rasbt/LLMs-from-scratch](https://github.com/rasbt/LLMs-from-scratch) in your browser, which renders Markdown automatically.

<br>
<br>


> **Tip:**
> If you're seeking guidance on installing Python and Python packages and setting up your code environment, I suggest reading the [README.md](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/setup/README.md) file located in the [setup](setup) directory.

<br>
<br>

[![Code tests Linux](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-linux-uv.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-linux-uv.yml)
[![Code tests Windows](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-windows-uv-pip.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-windows-uv-pip.yml)
[![Code tests macOS](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-macos-uv.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-macos-uv.yml)




<br>

| Chapter Title                                              | Main Code (for Quick Access)                                                                                                    | All Code + Supplementary      |
|------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------|-------------------------------|
| [Setup recommendations](setup)                             | -                                                                                                                               | -                             |
| Ch 1: Understanding Large Language Models                  | No code                                                                                                                         | -                             |
| Ch 2: Working with Text Data                               | - [ch02.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/ch02.ipynb)<br/>- [dataloader.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/dataloader.ipynb) (summary)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/exercise-solutions.ipynb)               | [./ch02](./ch02)            |
| Ch 3: Coding Attention Mechanisms                          | - [ch03.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/ch03.ipynb)<br/>- [multihead-attention.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/multihead-attention.ipynb) (summary) <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/exercise-solutions.ipynb)| [./ch03](./ch03)             |
| Chap 4 : Implémentation d’un modèle GPT from scratch          | - [ch04.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/ch04.ipynb)<br/>- [gpt.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/gpt.py) (résumé)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/exercise-solutions.ipynb) | [./ch04](./ch04)           |
| Chap 5 : Préentraînement sur données non étiquetées          | - [ch05.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/ch05.ipynb)<br/>- [gpt_train.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/gpt_train.py) (résumé) <br/>- [gpt_generate.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/gpt_generate.py) (résumé) <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/exercise-solutions.ipynb) | [./ch05](./ch05)              |
| Chap 6 : Ajustement fin pour la classification de texte       | - [ch06.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/ch06.ipynb)  <br/>- [gpt_class_finetune.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/gpt_class_finetune.py)  <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/exercise-solutions.ipynb) | [./ch06](./ch06)              |
| Chap 7 : Ajustement fin pour suivre des instructions          | - [ch07.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/ch07.ipynb)<br/>- [gpt_instruction_finetuning.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/gpt_instruction_finetuning.py) (résumé)<br/>- [ollama_evaluate.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/ollama_evaluate.py) (résumé)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/exercise-solutions.ipynb) | [./ch07](./ch07)  |
| Annexe A : Introduction à PyTorch                             | - [code-part1.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/code-part1.ipynb)<br/>- [code-part2.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/code-part2.ipynb)<br/>- [DDP-script.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/DDP-script.py)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/exercise-solutions.ipynb) | [./appendix-A](./appendix-A) |
| Annexe B : Références et lectures complémentaires             | Pas de code                                                                                                                     | -                             |
| Annexe C : Solutions des exercices                            | Pas de code                                                                                                                     | -                             |
| Annexe D : Ajout de fonctionnalités supplémentaires à la boucle d’entraînement | - [appendix-D.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-D/01_main-chapter-code/appendix-D.ipynb)                                                          | [./appendix-D](./appendix-D)  |
| Annexe E : Ajustement fin paramètre-efficace avec LoRA       | - [appendix-E.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-E/01_main-chapter-code/appendix-E.ipynb)                                                          | [./appendix-E](./appendix-E) |

<br>
&nbsp;

Le modèle mental ci-dessous résume les contenus abordés dans ce livre.

<img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/mental-model.jpg" width="650px">


<br>
&nbsp;

## Prérequis

Le prérequis le plus important est une solide base en programmation Python.
Avec ces connaissances, vous serez bien préparé pour explorer le monde fascinant des LLM
et comprendre les concepts ainsi que les exemples de code présentés dans ce livre.

Si vous avez une certaine expérience des réseaux neuronaux profonds, vous trouverez peut-être certains concepts plus familiers, car les LLM reposent sur ces architectures.

Ce livre utilise PyTorch pour implémenter le code from scratch sans utiliser de bibliothèques LLM externes. Bien qu’une maîtrise de PyTorch ne soit pas obligatoire, une familiarité avec les bases de PyTorch est certainement utile. Si vous débutez avec PyTorch, l’annexe A propose une introduction concise à PyTorch. Sinon, vous pouvez trouver mon livre, [PyTorch en une heure : des tenseurs à l’entraînement de réseaux neuronaux sur plusieurs GPU](https://sebastianraschka.com/teaching/pytorch-1h/), utile pour apprendre les notions essentielles.



<br>
&nbsp;

## Exigences matérielles

Le code des chapitres principaux de ce livre est conçu pour s’exécuter sur des ordinateurs portables conventionnels dans un délai raisonnable et ne nécessite pas de matériel spécialisé. Cette approche garantit qu’un large public peut s’engager avec le matériel. De plus, le code utilise automatiquement les GPU s’ils sont disponibles. (Veuillez consulter la documentation de [configuration](https://github.com/rasbt/LLMs-from-scratch/blob/main/setup/README.md) pour des recommandations supplémentaires.)

&nbsp;
## Cours Vidéo

[Un cours vidéo compagnon de 17 heures et 15 minutes](https://www.manning.com/livevideo/master-and-build-large-language-models) où je code chaque chapitre du livre. Le cours est organisé en chapitres et sections qui reflètent la structure du livre afin qu'il puisse être utilisé comme une alternative autonome au livre ou comme ressource complémentaire pour coder en parallèle.

<a href="https://www.manning.com/livevideo/master-and-build-large-language-models"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/video-screenshot.webp?123" width="350px"></a>


&nbsp;


## Livre Compagnon / Suite

[*Construire un Modèle de Raisonnement (From Scratch)*](https://mng.bz/lZ5B), bien qu’étant un livre autonome, peut être considéré comme une suite à *Construire un Grand Modèle de Langage (From Scratch)*.

Il commence avec un modèle préentraîné et implémente différentes approches de raisonnement, incluant la mise à l’échelle au moment de l’inférence, l’apprentissage par renforcement et la distillation, pour améliorer les capacités de raisonnement du modèle.

Similaire à *Construire un Grand Modèle de Langage (From Scratch)*, [*Construire un Modèle de Raisonnement (From Scratch)*](https://mng.bz/lZ5B) adopte une approche pratique en implémentant ces méthodes à partir de zéro.

<a href="https://mng.bz/lZ5B"><img src="https://sebastianraschka.com/images/reasoning-from-scratch-images/cover.webp?123" width="120px"></a>

- Lien Amazon (À venir)
- [Lien Manning](https://mng.bz/lZ5B)
- [Dépôt GitHub](https://github.com/rasbt/reasoning-from-scratch)

<br>

&nbsp;
## Exercices

Chaque chapitre du livre comprend plusieurs exercices. Les solutions sont résumées en Annexe C, et les notebooks de code correspondants sont disponibles dans les dossiers principaux des chapitres de ce dépôt (par exemple, [./ch02/01_main-chapter-code/exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/./ch02/01_main-chapter-code/exercise-solutions.ipynb)).

En plus des exercices de code, vous pouvez télécharger un PDF gratuit de 170 pages intitulé [Testez-vous sur Construire un Grand Modèle de Langage (From Scratch)](https://www.manning.com/books/test-yourself-on-build-a-large-language-model-from-scratch) depuis le site de Manning. Il contient environ 30 questions de quiz et leurs solutions par chapitre pour vous aider à tester votre compréhension.

<a href="https://www.manning.com/books/test-yourself-on-build-a-large-language-model-from-scratch"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/test-yourself-cover.jpg?123" width="150px"></a>



&nbsp;

## Matériel Bonus

Plusieurs dossiers contiennent des matériaux optionnels en bonus pour les lecteurs intéressés :

- **Installation**
  - [Conseils pour la configuration de Python](setup/01_optional-python-setup-preferences)
  - [Installation des packages et bibliothèques Python utilisés dans ce livre](setup/02_installing-python-libraries)
  - [Guide de configuration de l'environnement Docker](setup/03_optional-docker-environment)
- **Chapitre 2 : Travailler avec des données textuelles**
  - [Tokeniseur Byte Pair Encoding (BPE) depuis zéro](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/05_bpe-from-scratch/bpe-from-scratch.ipynb)
  - [Comparaison de différentes implémentations de Byte Pair Encoding (BPE)](ch02/02_bonus_bytepair-encoder)
  - [Comprendre la différence entre couches d’embedding et couches linéaires](ch02/03_bonus_embedding-vs-matmul)
  - [Intuition sur le dataloader avec des nombres simples](ch02/04_bonus_dataloader-intuition)
- **Chapitre 3 : Coder les mécanismes d’attention**
  - [Comparaison des implémentations efficaces de Multi-Head Attention](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/02_bonus_efficient-multihead-attention/mha-implementations.ipynb)
  - [Comprendre les buffers PyTorch](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/03_understanding-buffers/understanding-buffers.ipynb)
- **Chapitre 4 : Implémenter un modèle GPT depuis zéro**
  - [Analyse des FLOPS](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/02_performance-analysis/flops-analysis.ipynb)
  - [Cache KV](ch04/03_kv-cache)
- **Chapitre 5 : Pré-entraînement sur données non étiquetées :**
  - [Méthodes alternatives de chargement de poids](ch05/02_alternative_weight_loading/)
  - [Pré-entraînement de GPT sur le dataset Project Gutenberg](ch05/03_bonus_pretraining_on_gutenberg)
  - [Ajout de fonctionnalités supplémentaires à la boucle d’entraînement](ch05/04_learning_rate_schedulers)
  - [Optimisation des hyperparamètres pour le pré-entraînement](ch05/05_bonus_hparam_tuning)
  - [Création d’une interface utilisateur pour interagir avec le LLM pré-entraîné](ch05/06_user_interface)
  - [Conversion de GPT en Llama](ch05/07_gpt_to_llama)
  - [Llama 3.2 depuis zéro](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/07_gpt_to_llama/standalone-llama32.ipynb)
  - [Qwen3 Dense et Mixture-of-Experts (MoE) depuis zéro](ch05/11_qwen3/)
  - [Gemma 3 depuis zéro](ch05/12_gemma3/)
  - [Chargement de poids de modèle économe en mémoire](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/08_memory_efficient_weight_loading/memory-efficient-state-dict.ipynb)
  - [Extension du tokeniseur Tiktoken BPE avec de nouveaux tokens](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/09_extending-tokenizers/extend-tiktoken.ipynb)
  - [Conseils PyTorch pour accélérer l’entraînement des LLM](ch05/10_llm-training-speed)
- **Chapitre 6 : Affinage pour la classification**
  - [Expériences supplémentaires d’affinage de différentes couches et utilisation de modèles plus grands](ch06/02_bonus_additional-experiments)
  - [Affinage de différents modèles sur un dataset de 50k critiques de films IMDb](ch06/03_bonus_imdb-classification)
  - [Création d’une interface utilisateur pour interagir avec le classificateur anti-spam basé sur GPT](ch06/04_user_interface)
- **Chapitre 7 : Affinage pour suivre des instructions**
  - [Utilitaires de dataset pour trouver des doublons proches et créer des entrées à la voix passive](ch07/02_dataset-utilities)
  - [Évaluation des réponses aux instructions via l’API OpenAI et Ollama](ch07/03_model-evaluation)
  - [Génération d’un dataset pour l’affinage sur instructions](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/05_dataset-generation/llama3-ollama.ipynb)
  - [Améliorer un jeu de données pour le finetuning d'instructions](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/05_dataset-generation/reflection-gpt4.ipynb)
  - [Générer un jeu de données de préférences avec Llama 3.1 70B et Ollama](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/04_preference-tuning-with-dpo/create-preference-data-ollama.ipynb)
  - [Optimisation directe des préférences (DPO) pour l'alignement des LLM](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/04_preference-tuning-with-dpo/dpo-from-scratch.ipynb)
  - [Créer une interface utilisateur pour interagir avec le modèle GPT finetuné sur instructions](ch07/06_user_interface)

<br>
&nbsp;

## Questions, retours et contributions à ce dépôt


Je suis ouvert à toutes sortes de retours, à partager de préférence via le [Forum Manning](https://livebook.manning.com/forum?product=raschka&page=1) ou les [Discussions GitHub](https://github.com/rasbt/LLMs-from-scratch/discussions). De même, si vous avez des questions ou souhaitez simplement échanger des idées avec d'autres, n'hésitez pas à les poster sur le forum.

Veuillez noter que puisque ce dépôt contient le code correspondant à un livre imprimé, je ne peux actuellement pas accepter de contributions qui étendraient le contenu du code principal des chapitres, car cela créerait des divergences avec le livre physique. Maintenir la cohérence garantit une expérience fluide pour tous.


&nbsp;
## Citation

Si vous trouvez ce livre ou ce code utile pour vos recherches, merci de bien vouloir le citer.

Citation au format Chicago :

> Raschka, Sebastian. *Build A Large Language Model (From Scratch)*. Manning, 2024. ISBN : 978-1633437166.

Entrée BibTeX :

```
@book{build-llms-from-scratch-book,
  author       = {Sebastian Raschka},
  title        = {Build A Large Language Model (From Scratch)},
  publisher    = {Manning},
  year         = {2024},
  isbn         = {978-1633437166},
  url          = {https://www.manning.com/books/build-a-large-language-model-from-scratch},
  github       = {https://github.com/rasbt/LLMs-from-scratch}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---