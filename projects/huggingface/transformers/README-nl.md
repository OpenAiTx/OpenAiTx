<!---
Copyright 2020 The HuggingFace Team. Alle rechten voorbehouden.

Gelicenseerd onder de Apache License, Version 2.0 (de "Licentie");
u mag dit bestand niet gebruiken behalve in overeenstemming met de Licentie.
U kunt een kopie van de Licentie verkrijgen op

    http://www.apache.org/licenses/LICENSE-2.0

Tenzij vereist door toepasselijk recht of schriftelijk overeengekomen, wordt software
gedistribueerd onder de Licentie op een "AS IS" BASIS,
ZONDER ENIGE GARANTIES OF VOORWAARDEN, expliciet of impliciet.
Zie de Licentie voor de specifieke taal die van toepassing is op
toestemmingen en beperkingen onder de Licentie.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Hugging Face Transformers Library" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Checkpoints op Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Documentatie" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
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
    <p>State-of-the-art voorgetrainde modellen voor inferentie en training</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers is een bibliotheek van voorgetrainde tekst-, computer vision-, audio-, video- en multimodale modellen voor inferentie en training. Gebruik Transformers om modellen te fine-tunen op jouw data, inferentie-applicaties te bouwen, en voor generatieve AI-toepassingen over meerdere modaliteiten.

Er zijn meer dan 500K+ Transformers [model checkpoints](https://huggingface.co/models?library=transformers&sort=trending) op de [Hugging Face Hub](https://huggingface.com/models) die je kunt gebruiken.

Verken vandaag nog de [Hub](https://huggingface.com/) om een model te vinden en gebruik Transformers om direct aan de slag te gaan.

## Installatie

Transformers werkt met Python 3.9+ [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+, en [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+.

Maak en activeer een virtuele omgeving met [venv](https://docs.python.org/3/library/venv.html) of [uv](https://docs.astral.sh/uv/), een snelle Rust-gebaseerde package- en projectmanager voor Python.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

Installeer Transformers in je virtuele omgeving.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

Installeer Transformers vanaf de bron als je de laatste wijzigingen in de bibliotheek wilt hebben of wilt bijdragen. Houd er echter rekening mee dat de *laatste* versie mogelijk niet stabiel is. Voel je vrij om een [issue](https://github.com/huggingface/transformers/issues) te openen als je een fout tegenkomt.

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## Snelstart

Begin direct met Transformers via de [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial) API. De `Pipeline` is een high-level inferentieklasse die tekst-, audio-, vision- en multimodale taken ondersteunt. Het verzorgt de preprocessing van de input en geeft de juiste output terug.

Maak een pipeline aan en geef het model op voor tekstgeneratie. Het model wordt gedownload en gecachet zodat je het gemakkelijk opnieuw kunt gebruiken. Geef vervolgens wat tekst om het model te laten starten.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("het geheim van het bakken van een echt goede taart is ")
[{'generated_text': 'het geheim van het bakken van een echt goede taart is 1) het gebruiken van de juiste ingrediënten en 2) het exact volgen van het recept. het recept voor de taart is als volgt: 1 kop suiker, 1 kop bloem, 1 kop melk, 1 kop boter, 1 kop eieren, 1 kop chocoladestukjes. als je 2 taarten wilt maken, hoeveel suiker heb je dan nodig? Om 2 taarten te maken heb je 2 kopjes suiker nodig.'}]
```

Om met een model te chatten is het gebruikspatroon hetzelfde. Het enige verschil is dat je een chathistorie (de input voor `Pipeline`) moet opbouwen tussen jou en het systeem.

> [!TIP]
> Je kunt ook rechtstreeks vanaf de commandoregel chatten met een model.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "Je bent een pittige, bijdehante robot zoals bedacht door Hollywood rond 1986."},
    {"role": "user", "content": "Hé, kun je me wat leuke dingen vertellen om te doen in New York?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

Vouw de onderstaande voorbeelden uit om te zien hoe `Pipeline` werkt voor verschillende modaliteiten en taken.

<details>
<summary>Automatische spraakherkenning</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>Beeldclassificatie</summary>

<h3 align="center">
    <a><img src="https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="image-classification", model="facebook/dinov2-small-imagenet1k-1-layer")
pipeline("https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png")
[{'label': 'ara', 'score': 0.997848391532898},
 {'label': 'zwavelkuifkaketoe, Kakatoe galerita, Cacatua galerita',
  'score': 0.0016551691805943847},
 {'label': 'lorikeet', 'score': 0.00018523589824326336},
 {'label': 'grijze roodstaart, Psittacus erithacus',
  'score': 7.85409429227002e-05},
 {'label': 'kwartel', 'score': 5.502637941390276e-05}]
```

</details>

<details>
<summary>Visueel vraag-antwoord</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="Wat staat er op de afbeelding?",
)
[{'answer': 'vrijheidsbeeld'}]
```

</details>

## Waarom zou ik Transformers gebruiken?

1. Gebruiksvriendelijke state-of-the-art modellen:
    - Hoge prestaties op natural language understanding & generation, computer vision, audio, video en multimodale taken.
    - Lage instapdrempel voor onderzoekers, ingenieurs en ontwikkelaars.
    - Weinig gebruikersgerichte abstracties met slechts drie klassen om te leren.
    - Een uniforme API voor al onze voorgetrainde modellen.

1. Lagere rekenkosten, kleinere ecologische voetafdruk:
    - Deel getrainde modellen in plaats van vanaf nul te trainen.
    - Verminder rekentijd en productiekosten.
    - Tientallen modelarchitecturen met 1M+ voorgetrainde checkpoints over alle modaliteiten.

1. Kies het juiste framework voor elk deel van de levenscyclus van een model:
    - Train state-of-the-art modellen in 3 regels code.
    - Verplaats een enkel model eenvoudig tussen PyTorch/JAX/TF2.0 frameworks.
    - Kies het juiste framework voor training, evaluatie en productie.

1. Pas eenvoudig een model of voorbeeld aan je wensen aan:
    - We bieden voorbeelden voor elke architectuur om de resultaten van de oorspronkelijke auteurs te reproduceren.
    - De interne werking van modellen is zo consistent mogelijk toegankelijk gemaakt.
    - Modelfiles kunnen onafhankelijk van de bibliotheek worden gebruikt voor snelle experimenten.

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## Waarom zou ik Transformers niet gebruiken?

- Deze bibliotheek is geen modulaire toolbox van bouwstenen voor neurale netwerken. De code in de modelbestanden is opzettelijk niet geherstructureerd met extra abstracties, zodat onderzoekers snel kunnen itereren op elk van de modellen zonder extra abstracties/bestanden.
- De trainings-API is geoptimaliseerd om te werken met PyTorch-modellen die door Transformers worden geleverd. Voor algemene machine learning-loops kun je beter een andere bibliotheek zoals [Accelerate](https://huggingface.co/docs/accelerate) gebruiken.
- De [voorbeeldscripts]((https://github.com/huggingface/transformers/tree/main/examples)) zijn slechts *voorbeelden*. Ze werken mogelijk niet direct voor jouw specifieke toepassing en je zult de code moeten aanpassen.

## 100 projecten die Transformers gebruiken

Transformers is meer dan alleen een toolkit om voorgetrainde modellen te gebruiken; het is een community van projecten eromheen, samen met de Hugging Face Hub. We willen met Transformers ontwikkelaars, onderzoekers, studenten, docenten, ingenieurs en iedereen in staat stellen hun droomprojecten te bouwen.

Om Transformers' 100.000 sterren te vieren, wilden we de spotlight op de community zetten met de [awesome-transformers](./awesome-transformers.md)-pagina, waarop 100 geweldige projecten staan die met Transformers zijn gebouwd.

Als je een project hebt of gebruikt dat volgens jou op de lijst hoort, open dan een PR om het toe te voegen!

## Voorbeeldmodellen

Je kunt de meeste van onze modellen direct testen op hun [Hub modelpagina's](https://huggingface.co/models).

Vouw elke modaliteit hieronder uit om enkele voorbeeldmodellen voor verschillende toepassingen te bekijken.

<details>
<summary>Audio</summary>

- Audioclassificatie met [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)
- Automatische spraakherkenning met [Moonshine](https://huggingface.co/UsefulSensors/moonshine)
- Keyword spotting met [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)
- Spraak naar spraak generatie met [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)
- Tekst naar audio met [MusicGen](https://huggingface.co/facebook/musicgen-large)
- Tekst naar spraak met [Bark](https://huggingface.co/suno/bark)

</details>

<details>
<summary>Computer vision</summary>

- Automatische maskergeneratie met [SAM](https://huggingface.co/facebook/sam-vit-base)
- Diepte-inschatting met [DepthPro](https://huggingface.co/apple/DepthPro-hf)
- Beeldclassificatie met [DINO v2](https://huggingface.co/facebook/dinov2-base)
- Keypoint-detectie met [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)
- Keypoint-matching met [SuperGlue](https://huggingface.co/magic-leap-community/superglue)
- Objectdetectie met [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)
- Pose schatting met [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)
- Universele segmentatie met [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)
- Video classificatie met [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)

</details>

<details>
<summary>Multimodaal</summary>

- Audio of tekst naar tekst met [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)
- Document vraag-antwoord met [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)
- Beeld of tekst naar tekst met [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)
- Beeldbeschrijving met [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)
- OCR-gebaseerd documentbegrip met [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)
- Tabelvraagbeantwoording met [TAPAS](https://huggingface.co/google/tapas-base)
- Geünificeerd multimodaal begrip en generatie met [Emu3](https://huggingface.co/BAAI/Emu3-Gen)
- Vision naar tekst met [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)
- Visueel vraag-antwoord met [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)
- Visuele verwijzende expressie segmentatie met [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)

</details>

<details>
<summary>NLP</summary>

- Gemaskeerde woordaanvulling met [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)
- Naam entiteit herkenning met [Gemma](https://huggingface.co/google/gemma-2-2b)
- Vraagbeantwoording met [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)
- Samenvatten met [BART](https://huggingface.co/facebook/bart-large-cnn)
- Vertalen met [T5](https://huggingface.co/google-t5/t5-base)
- Tekstgeneratie met [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)
- Tekstclassificatie met [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)

</details>

## Citeren

We hebben nu een [paper](https://www.aclweb.org/anthology/2020.emnlp-demos.6/) die je kunt citeren voor de 🤗 Transformers-bibliotheek:
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