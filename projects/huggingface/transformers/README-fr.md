<!---
Copyright 2020 The HuggingFace Team. Tous droits réservés.

Sous licence Apache License, Version 2.0 (la "Licence");
vous ne pouvez pas utiliser ce fichier sauf en conformité avec la Licence.
Vous pouvez obtenir une copie de la Licence à l'adresse suivante :

    http://www.apache.org/licenses/LICENSE-2.0

Sauf si la loi l'exige ou sauf accord écrit, le logiciel distribué sous la Licence est distribué "EN L'ÉTAT",
SANS GARANTIE OU CONDITION D'AUCUNE SORTE, expresse ou implicite.
Voir la Licence pour connaître la langue spécifique régissant les permissions et limitations sous la Licence.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Bibliothèque Hugging Face Transformers" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Points de contrôle sur le Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Documentation" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="GitHub release" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/CODE_OF_CONDUCT.md"><img alt="Contributor Covenant" src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg"></a>
    <a href="https://zenodo.org/badge/latestdoi/155220641"><img src="https://zenodo.org/badge/155220641.svg" alt="DOI"></a>
</p>

<h4 align="center">
    <p>
        <b>English</b> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hans.md">简体中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hant.md">繁體中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ko.md">한국어</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_es.md">Español</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ja.md">日本語</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_hd.md">हिन्दी</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ru.md">Русский</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_pt-br.md">Рortuguês</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_te.md">తెలుగు</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_fr.md">Français</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_de.md">Deutsch</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_vi.md">Tiếng Việt</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ar.md">العربية</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ur.md">اردو</a> |
    </p>
</h4>

<h3 align="center">
    <p>Modèles préentraînés à la pointe de la technologie pour l’inférence et l’entraînement</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers est une bibliothèque de modèles préentraînés pour le texte, la vision par ordinateur, l’audio, la vidéo et le multimodal, dédiée à l’inférence et à l’entraînement. Utilisez Transformers pour ajuster les modèles sur vos données, construire des applications d’inférence et pour des cas d’usage d’IA générative sur de multiples modalités.

Il existe plus de 500 000 [points de contrôle de modèles](https://huggingface.co/models?library=transformers&sort=trending) Transformers sur le [Hub Hugging Face](https://huggingface.com/models) que vous pouvez utiliser.

Explorez dès aujourd’hui le [Hub](https://huggingface.com/) pour trouver un modèle et utiliser Transformers pour démarrer immédiatement.

## Installation

Transformers fonctionne avec Python 3.9+, [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+ et [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+.

Créez et activez un environnement virtuel avec [venv](https://docs.python.org/3/library/venv.html) ou [uv](https://docs.astral.sh/uv/), un gestionnaire de paquets et de projets Python rapide basé sur Rust.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

Installez Transformers dans votre environnement virtuel.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

Installez Transformers à partir de la source si vous souhaitez bénéficier des dernières modifications de la bibliothèque ou contribuer au projet. Cependant, la version *la plus récente* peut ne pas être stable. N’hésitez pas à ouvrir une [issue](https://github.com/huggingface/transformers/issues) si vous rencontrez une erreur.

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## Démarrage rapide

Commencez avec Transformers dès maintenant avec l’API [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial). Le `Pipeline` est une classe d’inférence de haut niveau prenant en charge les tâches de texte, d’audio, de vision et multimodales. Il gère le prétraitement de l’entrée et retourne la sortie appropriée.

Instanciez un pipeline et spécifiez le modèle à utiliser pour la génération de texte. Le modèle est téléchargé et mis en cache, ce qui vous permet de le réutiliser facilement. Enfin, fournissez un texte pour amorcer le modèle.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

Pour discuter avec un modèle, le schéma d’utilisation est le même. La seule différence est que vous devez construire un historique de conversation (l’entrée de `Pipeline`) entre vous et le système.

> [!TIP]
> Vous pouvez également discuter avec un modèle directement depuis la ligne de commande.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "Vous êtes un robot impertinent et plein d'esprit, tel qu’imaginé par Hollywood vers 1986."},
    {"role": "user", "content": "Salut, peux-tu me dire des choses amusantes à faire à New York ?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

Développez les exemples ci-dessous pour voir comment `Pipeline` fonctionne pour différentes modalités et tâches.

<details>
<summary>Reconnaissance automatique de la parole</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>Classification d'images</summary>

<h3 align="center">
    <a><img src="https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="image-classification", model="facebook/dinov2-small-imagenet1k-1-layer")
pipeline("https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png")
[{'label': 'macaw', 'score': 0.997848391532898},
 {'label': 'sulphur-crested cockatoo, Kakatoe galerita, Cacatua galerita',
  'score': 0.0016551691805943847},
 {'label': 'lorikeet', 'score': 0.00018523589824326336},
 {'label': 'African grey, African gray, Psittacus erithacus',
  'score': 7.85409429227002e-05},
 {'label': 'quail', 'score': 5.502637941390276e-05}]
```

</details>

<details>
<summary>Questions-réponses visuelles</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="What is in the image?",
)
[{'answer': 'statue of liberty'}]
```

</details>

## Pourquoi utiliser Transformers ?

1. Des modèles à la pointe de la technologie faciles à utiliser :
    - Hautes performances en compréhension et génération du langage naturel, vision par ordinateur, audio, vidéo et tâches multimodales.
    - Faible barrière à l’entrée pour les chercheurs, ingénieurs et développeurs.
    - Peu d’abstractions côté utilisateur, seulement trois classes à apprendre.
    - Une API unifiée pour utiliser tous nos modèles préentraînés.

1. Réduction des coûts de calcul et de l’empreinte carbone :
    - Partagez des modèles entraînés au lieu d’entraîner depuis zéro.
    - Réduisez le temps de calcul et les coûts de production.
    - Des dizaines d’architectures de modèles avec plus de 1M de points de contrôle préentraînés toutes modalités confondues.

1. Choisissez le bon framework à chaque étape du cycle de vie d’un modèle :
    - Entraînez des modèles à la pointe de la technologie en 3 lignes de code.
    - Déplacez un modèle unique entre les frameworks PyTorch/JAX/TF2.0 à volonté.
    - Choisissez le bon framework pour l’entraînement, l’évaluation et la production.

1. Personnalisez facilement un modèle ou un exemple selon vos besoins :
    - Nous fournissons des exemples pour chaque architecture afin de reproduire les résultats publiés par leurs auteurs d’origine.
    - Les internals des modèles sont exposés aussi uniformément que possible.
    - Les fichiers de modèles peuvent être utilisés indépendamment de la bibliothèque pour des expérimentations rapides.

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## Pourquoi ne pas utiliser Transformers ?

- Cette bibliothèque n’est pas une boîte à outils modulaire de briques de construction pour les réseaux neuronaux. Le code des fichiers de modèles n’est pas refactorisé avec des abstractions supplémentaires, afin que les chercheurs puissent itérer rapidement sur chaque modèle sans avoir à naviguer dans des abstractions/fichiers supplémentaires.
- L’API d’entraînement est optimisée pour fonctionner avec les modèles PyTorch fournis par Transformers. Pour des boucles de machine learning génériques, vous devriez utiliser une autre bibliothèque comme [Accelerate](https://huggingface.co/docs/accelerate).
- Les [scripts d’exemple]((https://github.com/huggingface/transformers/tree/main/examples)) sont seulement *des exemples*. Ils peuvent ne pas fonctionner immédiatement pour votre cas d’usage spécifique et vous devrez adapter le code pour qu’il fonctionne.

## 100 projets utilisant Transformers

Transformers est plus qu’un ensemble d’outils pour utiliser des modèles préentraînés, c’est une communauté de projets construits autour de lui et du Hub Hugging Face. Nous voulons que Transformers permette aux développeurs, chercheurs, étudiants, professeurs, ingénieurs et toute autre personne de réaliser leurs projets de rêve.

Pour célébrer les 100 000 étoiles de Transformers, nous avons voulu mettre en avant la communauté avec la page [awesome-transformers](./awesome-transformers.md) qui recense 100 projets incroyables construits avec Transformers.

Si vous possédez ou utilisez un projet qui, selon vous, devrait faire partie de la liste, n’hésitez pas à ouvrir une PR pour l’ajouter !

## Exemples de modèles

Vous pouvez tester la plupart de nos modèles directement sur leurs [pages modèles du Hub](https://huggingface.co/models).

Développez chaque modalité ci-dessous pour voir quelques exemples de modèles pour différents cas d’utilisation.

<details>
<summary>Audio</summary>

- Classification audio avec [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)
- Reconnaissance automatique de la parole avec [Moonshine](https://huggingface.co/UsefulSensors/moonshine)
- Détection de mots-clés avec [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)
- Génération parole à parole avec [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)
- Texte vers audio avec [MusicGen](https://huggingface.co/facebook/musicgen-large)
- Texte vers parole avec [Bark](https://huggingface.co/suno/bark)

</details>

<details>
<summary>Vision par ordinateur</summary>

- Génération automatique de masque avec [SAM](https://huggingface.co/facebook/sam-vit-base)
- Estimation de profondeur avec [DepthPro](https://huggingface.co/apple/DepthPro-hf)
- Classification d’images avec [DINO v2](https://huggingface.co/facebook/dinov2-base)
- Détection de points clés avec [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)
- Appariement de points clés avec [SuperGlue](https://huggingface.co/magic-leap-community/superglue)
- Détection d’objets avec [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)
- Estimation de pose avec [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)
- Segmentation universelle avec [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)
- Classification vidéo avec [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)

</details>

<details>
<summary>Multimodal</summary>

- Audio ou texte vers texte avec [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)
- Questions-réponses sur documents avec [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)
- Image ou texte vers texte avec [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)
- Génération de légendes d’images avec [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)
- Compréhension de documents basée OCR avec [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)
- Questions-réponses sur tableaux avec [TAPAS](https://huggingface.co/google/tapas-base)
- Compréhension et génération multimodale unifiée avec [Emu3](https://huggingface.co/BAAI/Emu3-Gen)
- Vision vers texte avec [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)
- Questions-réponses visuelles avec [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)
- Segmentation d’expression référentielle visuelle avec [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)

</details>

<details>
<summary>TALN</summary>

- Complétion de mots masqués avec [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)
- Reconnaissance d’entités nommées avec [Gemma](https://huggingface.co/google/gemma-2-2b)
- Questions-réponses avec [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)
- Résumé avec [BART](https://huggingface.co/facebook/bart-large-cnn)
- Traduction avec [T5](https://huggingface.co/google-t5/t5-base)
- Génération de texte avec [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)
- Classification de texte avec [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)

</details>

## Citation

Nous avons désormais un [article](https://www.aclweb.org/anthology/2020.emnlp-demos.6/) que vous pouvez citer pour la bibliothèque 🤗 Transformers :
```bibtex
@inproceedings{wolf-etal-2020-transformers,
    title = "Transformers: State-of-the-Art Natural Language Processing",
    author = "Thomas Wolf and Lysandre Debut and Victor Sanh and Julien Chaumond and Clement Delangue and Anthony Moi and Pierric Cistac and Tim Rault and Rémi Louf and Morgan Funtowicz and Joe Davison and Sam Shleifer and Patrick von Platen and Clara Ma and Yacine Jernite and Julien Plu and Canwen Xu and Teven Le Scao and Sylvain Gugger and Mariama Drame and Quentin Lhoest and Alexander M. Rush",
    booktitle = "Proceedings of the 2020 Conference on Empirical Methods in Natural Language Processing: System Demonstrations",
    month = oct,
    year = "2020",
    address = "Online",
    publisher = "Association for Computational Linguistics",
    url = "https://www.aclweb.org/anthology/2020.emnlp-demos.6",
    pages = "38--45"
}
```


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---