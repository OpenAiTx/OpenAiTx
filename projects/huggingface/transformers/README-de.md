<!---
Copyright 2020 The HuggingFace Team. Alle Rechte vorbehalten.

Lizenziert unter der Apache License, Version 2.0 (die "Lizenz");
Sie dürfen diese Datei nur in Übereinstimmung mit der Lizenz verwenden.
Eine Kopie der Lizenz erhalten Sie unter

    http://www.apache.org/licenses/LICENSE-2.0

Sofern nicht durch geltendes Recht vorgeschrieben oder schriftlich vereinbart, wird die Software
vertrieben unter der Lizenz auf einer "AS IS"-BASIS, OHNE GEWÄHRLEISTUNG ODER BEDINGUNGEN JEGLICHER ART, weder ausdrücklich noch stillschweigend.
Siehe die Lizenz für die spezifischen Regeln und Einschränkungen.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Hugging Face Transformers Bibliothek" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Checkpoints auf dem Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Dokumentation" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="GitHub Release" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
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
    <p>State-of-the-Art vortrainierte Modelle für Inferenz und Training</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers ist eine Bibliothek für vortrainierte Text-, Computer Vision-, Audio-, Video- und Multimodal-Modelle für Inferenz und Training. Verwenden Sie Transformers, um Modelle auf Ihren Daten zu finetunen, Inferenzanwendungen zu erstellen und für generative KI-Anwendungen über mehrere Modalitäten hinweg.

Es gibt über 500.000+ Transformer-[Modell-Checkpoints](https://huggingface.co/models?library=transformers&sort=trending) auf dem [Hugging Face Hub](https://huggingface.com/models), die Sie verwenden können.

Entdecken Sie noch heute den [Hub](https://huggingface.com/), um ein Modell zu finden und Transformers zu nutzen, damit Sie sofort loslegen können.

## Installation

Transformers funktioniert mit Python 3.9+, [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+ und [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+.

Erstellen und aktivieren Sie eine virtuelle Umgebung mit [venv](https://docs.python.org/3/library/venv.html) oder [uv](https://docs.astral.sh/uv/), einem schnellen, in Rust geschriebenen Python-Paket- und Projektmanager.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

Installieren Sie Transformers in Ihrer virtuellen Umgebung.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

Installieren Sie Transformers aus dem Quellcode, wenn Sie die neuesten Änderungen der Bibliothek wünschen oder beitragen möchten. Die *neueste* Version ist jedoch möglicherweise nicht stabil. Öffnen Sie gerne ein [Issue](https://github.com/huggingface/transformers/issues), wenn Sie auf einen Fehler stoßen.

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## Schnellstart

Starten Sie sofort mit Transformers über die [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial)-API. Die `Pipeline` ist eine High-Level-Inferenzklasse, die Text-, Audio-, Vision- und Multimodal-Aufgaben unterstützt. Sie übernimmt das Vorverarbeiten der Eingabe und gibt die entsprechende Ausgabe zurück.

Instanziieren Sie eine Pipeline und geben Sie das Modell zur Textgenerierung an. Das Modell wird heruntergeladen und zwischengespeichert, sodass Sie es leicht wiederverwenden können. Geben Sie schließlich etwas Text als Prompt an das Modell weiter.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

Um mit einem Modell zu chatten, bleibt das Nutzungsmuster gleich. Der einzige Unterschied ist, dass Sie einen Chatverlauf (die Eingabe für `Pipeline`) zwischen Ihnen und dem System erstellen müssen.

> [!TIPP]
> Sie können auch direkt über die Kommandozeile mit einem Modell chatten.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "Du bist ein frecher, witziger Roboter, wie ihn Hollywood etwa 1986 sich vorgestellt hat."},
    {"role": "user", "content": "Hey, kannst du mir ein paar lustige Dinge sagen, die man in New York machen kann?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

Erweitern Sie die folgenden Beispiele, um zu sehen, wie `Pipeline` für verschiedene Modalitäten und Aufgaben funktioniert.

<details>
<summary>Automatische Spracherkennung</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>Bildklassifikation</summary>

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
<summary>Visuelles Frage-Antworten</summary>


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

## Warum sollte ich Transformers verwenden?

1. Einfach zu bedienende, State-of-the-Art-Modelle:
    - Hohe Leistung bei Sprachverstehen & -generierung, Computer Vision, Audio, Video und Multimodal-Aufgaben.
    - Geringe Einstiegshürde für Forschende, Ingenieure und Entwickler.
    - Wenige benutzerorientierte Abstraktionen mit nur drei zu lernenden Klassen.
    - Eine einheitliche API für alle unsere vortrainierten Modelle.

1. Geringere Rechenkosten, kleinerer CO2-Fußabdruck:
    - Teilen Sie trainierte Modelle, statt von Grund auf neu zu trainieren.
    - Reduzieren Sie Rechenzeit und Produktionskosten.
    - Dutzende Modellarchitekturen mit über 1 Mio. vortrainierten Checkpoints in allen Modalitäten.

1. Wählen Sie das richtige Framework für jede Phase im Lebenszyklus eines Modells:
    - Trainieren Sie State-of-the-Art-Modelle in 3 Zeilen Code.
    - Wechseln Sie ein einzelnes Modell nach Belieben zwischen PyTorch/JAX/TF2.0 Frameworks.
    - Wählen Sie das passende Framework für Training, Evaluation und Produktion.

1. Passen Sie ein Modell oder Beispiel einfach an Ihre Bedürfnisse an:
    - Wir stellen für jede Architektur Beispiele bereit, um die von den Originalautoren veröffentlichten Ergebnisse zu reproduzieren.
    - Die internen Details der Modelle sind so konsistent wie möglich offengelegt.
    - Modelldateien können unabhängig von der Bibliothek für schnelle Experimente genutzt werden.

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## Warum sollte ich Transformers *nicht* verwenden?

- Diese Bibliothek ist kein modulares Baukastensystem für neuronale Netze. Der Code in den Modelldateien ist absichtlich nicht mit zusätzlichen Abstraktionen umgebaut, damit Forschende schnell an jedem der Modelle arbeiten können, ohne sich in weitere Abstraktionsebenen/Dateien einarbeiten zu müssen.
- Die Trainings-API ist darauf optimiert, mit PyTorch-Modellen aus Transformers zu arbeiten. Für generische Machine-Learning-Loops sollten Sie eine andere Bibliothek wie [Accelerate](https://huggingface.co/docs/accelerate) nutzen.
- Die [Beispielskripte]((https://github.com/huggingface/transformers/tree/main/examples)) sind nur *Beispiele*. Sie funktionieren nicht unbedingt direkt für Ihren spezifischen Anwendungsfall und müssen ggf. angepasst werden.

## 100 Projekte, die Transformers verwenden

Transformers ist mehr als nur ein Toolkit zum Verwenden vortrainierter Modelle – es ist eine Community von Projekten, die darauf und dem Hugging Face Hub aufbauen. Wir möchten mit Transformers Entwickler, Forschende, Studierende, Professoren, Ingenieure und alle anderen dabei unterstützen, ihre Wunschprojekte zu realisieren.

Zur Feier von 100.000 Stars für Transformers möchten wir die Community mit der Seite [awesome-transformers](./awesome-transformers.md) ins Rampenlicht rücken, auf der 100 fantastische Projekte aufgeführt sind, die mit Transformers erstellt wurden.

Wenn Sie ein Projekt besitzen oder nutzen, das Ihrer Meinung nach auf die Liste gehört, öffnen Sie bitte einen PR, um es hinzuzufügen!

## Beispielmodelle

Die meisten unserer Modelle können Sie direkt auf deren [Hub-Modellseiten](https://huggingface.co/models) testen.

Erweitern Sie jede Modalität unten, um einige Beispielmodelle für verschiedene Anwendungsfälle zu sehen.

<details>
<summary>Audio</summary>

- Audioklassifikation mit [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)
- Automatische Spracherkennung mit [Moonshine](https://huggingface.co/UsefulSensors/moonshine)
- Schlüsselworterkennung mit [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)
- Sprach-zu-Sprach-Generierung mit [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)
- Text-zu-Audio mit [MusicGen](https://huggingface.co/facebook/musicgen-large)
- Text-zu-Sprache mit [Bark](https://huggingface.co/suno/bark)

</details>

<details>
<summary>Computer Vision</summary>

- Automatische Maskengenerierung mit [SAM](https://huggingface.co/facebook/sam-vit-base)
- Tiefenschätzung mit [DepthPro](https://huggingface.co/apple/DepthPro-hf)
- Bildklassifikation mit [DINO v2](https://huggingface.co/facebook/dinov2-base)
- Keypoint-Erkennung mit [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)
- Keypoint-Matching mit [SuperGlue](https://huggingface.co/magic-leap-community/superglue)
- Objekterkennung mit [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)
- Posenabschätzung mit [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)
- Universelle Segmentierung mit [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)
- Videoklassifikation mit [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)

</details>

<details>
<summary>Multimodal</summary>

- Audio oder Text zu Text mit [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)
- Dokumenten-Fragebeantwortung mit [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)
- Bild oder Text zu Text mit [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)
- Bildbeschreibung mit [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)
- OCR-basiertes Dokumentenverständnis mit [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)
- Tabellen-Fragebeantwortung mit [TAPAS](https://huggingface.co/google/tapas-base)
- Vereinheitlichtes multimodales Verstehen und Generieren mit [Emu3](https://huggingface.co/BAAI/Emu3-Gen)
- Vision zu Text mit [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)
- Visuelles Frage-Antworten mit [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)
- Visuelle referentielle Segmentierung mit [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)

</details>

<details>
<summary>NLP</summary>

- Maskierte Wortvervollständigung mit [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)
- Benannte Entitätenerkennung mit [Gemma](https://huggingface.co/google/gemma-2-2b)
- Fragebeantwortung mit [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)
- Zusammenfassung mit [BART](https://huggingface.co/facebook/bart-large-cnn)
- Übersetzung mit [T5](https://huggingface.co/google-t5/t5-base)
- Textgenerierung mit [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)
- Textklassifikation mit [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)

</details>

## Zitation

Es gibt jetzt ein [Paper](https://www.aclweb.org/anthology/2020.emnlp-demos.6/), das Sie für die 🤗 Transformers-Bibliothek zitieren können:
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