<!---
Copyright 2020 Zespół HuggingFace. Wszelkie prawa zastrzeżone.

Licencjonowane na podstawie licencji Apache, wersja 2.0 („Licencja”);
nie możesz używać tego pliku poza zakresem Licencji.
Kopię Licencji możesz uzyskać pod adresem

    http://www.apache.org/licenses/LICENSE-2.0

O ile prawo nie stanowi inaczej lub nie zostało to pisemnie uzgodnione, oprogramowanie
dystrybuowane na podstawie Licencji jest dostarczane na zasadzie „TAK JAK JEST”,
BEZ ŻADNYCH GWARANCJI ANI WARUNKÓW, wyraźnych ani domniemanych.
Zobacz Licencję, aby uzyskać szczegółowe informacje dotyczące uprawnień i ograniczeń wynikających z Licencji.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Biblioteka Hugging Face Transformers" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Checkpointy na Hubie" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Dokumentacja" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
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
    <p>Najnowocześniejsze modele wstępnie wytrenowane do wnioskowania i uczenia</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers to biblioteka wstępnie wytrenowanych modeli tekstowych, komputerowego widzenia, audio, wideo i multimodalnych do wnioskowania i uczenia. Użyj Transformers do dostrajania modeli na własnych danych, budowania aplikacji inferencyjnych oraz do zastosowań generatywnej AI w różnych modalnościach.

Na [Hugging Face Hub](https://huggingface.com/models) dostępnych jest ponad 500 tys. [checkpointów modeli](https://huggingface.co/models?library=transformers&sort=trending), których możesz używać.

Odwiedź [Hub](https://huggingface.com/) już dziś, aby znaleźć model i od razu zacząć korzystać z Transformers.

## Instalacja

Transformers współpracuje z Pythonem 3.9+, [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+ oraz [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+.

Utwórz i aktywuj środowisko wirtualne za pomocą [venv](https://docs.python.org/3/library/venv.html) lub [uv](https://docs.astral.sh/uv/), szybkiego menedżera pakietów i projektów Pythona opartego na Rust.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

Zainstaluj Transformers w swoim środowisku wirtualnym.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

Zainstaluj Transformers ze źródła, jeśli chcesz mieć najnowsze zmiany w bibliotece lub chcesz współtworzyć. Jednak *najnowsza* wersja może być niestabilna. Jeśli napotkasz błąd, śmiało otwórz [issue](https://github.com/huggingface/transformers/issues).

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## Szybki start

Rozpocznij pracę z Transformers od razu dzięki API [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial). `Pipeline` to wysokopoziomowa klasa do wnioskowania wspierająca zadania tekstowe, audio, wizualne i multimodalne. Obsługuje wstępne przetwarzanie danych wejściowych i zwraca odpowiednie wyjście.

Utwórz pipeline i określ model do generowania tekstu. Model zostanie pobrany i zapisany w cache, więc możesz łatwo użyć go ponownie. Na końcu podaj tekst, aby zainicjować model.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

Aby rozmawiać z modelem, wzorzec użycia jest taki sam. Jedyna różnica polega na konieczności utworzenia historii czatu (wejścia do `Pipeline`) pomiędzy tobą a systemem.

> [!TIP]
> Możesz również rozmawiać z modelem bezpośrednio z linii poleceń.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "Jesteś zadziornym, dowcipnym robotem wyobrażonym przez Hollywood około 1986 roku."},
    {"role": "user", "content": "Hej, możesz polecić jakieś fajne rzeczy do zrobienia w Nowym Jorku?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

Rozwiń poniższe przykłady, aby zobaczyć jak `Pipeline` działa dla różnych modalności i zadań.

<details>
<summary>Automatyczne rozpoznawanie mowy</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>Klasyfikacja obrazów</summary>

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
<summary>Wizualne odpowiadanie na pytania</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="Co znajduje się na obrazie?",
)
[{'answer': 'statue of liberty'}]
```

</details>

## Dlaczego warto używać Transformers?

1. Łatwe w użyciu najnowocześniejsze modele:
    - Wysoka wydajność w zadaniach rozumienia i generowania języka naturalnego, komputerowego widzenia, audio, wideo i multimodalnych.
    - Niski próg wejścia dla naukowców, inżynierów i programistów.
    - Niewiele abstrakcji skierowanych do użytkownika – wystarczą trzy klasy do nauczenia się.
    - Ujednolicone API do korzystania ze wszystkich naszych modeli wstępnie wytrenowanych.

1. Niższe koszty obliczeniowe, mniejszy ślad węglowy:
    - Udostępniaj wytrenowane modele zamiast trenować od zera.
    - Skróć czas obliczeń i koszty produkcji.
    - Dziesiątki architektur modeli z ponad milionem checkpointów wstępnie wytrenowanych we wszystkich modalnościach.

1. Wybierz odpowiedni framework na każdym etapie życia modelu:
    - Trenuj najnowocześniejsze modele w 3 linijkach kodu.
    - Przenoś pojedynczy model między frameworkami PyTorch/JAX/TF2.0 wedle potrzeb.
    - Wybierz odpowiedni framework do trenowania, ewaluacji i wdrożenia.

1. Łatwo dostosuj model lub przykład do swoich potrzeb:
    - Dostarczamy przykłady dla każdej architektury, aby odtworzyć wyniki opublikowane przez jej autorów.
    - Wnętrze modeli jest eksponowane tak spójnie, jak to możliwe.
    - Pliki modeli można używać niezależnie od biblioteki do szybkich eksperymentów.

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## Dlaczego nie powinieneś używać Transformers?

- Ta biblioteka nie jest modularnym zestawem klocków do budowy sieci neuronowych. Kod w plikach modeli nie jest celowo refaktoryzowany o dodatkowe abstrakcje, aby badacze mogli szybko iterować na każdym modelu bez konieczności zagłębiania się w kolejne warstwy/plików.
- API trenowania jest zoptymalizowane pod kątem modeli PyTorch dostarczanych przez Transformers. Do ogólnych pętli uczenia maszynowego powinieneś użyć innej biblioteki, np. [Accelerate](https://huggingface.co/docs/accelerate).
- [Skrypty przykładów]((https://github.com/huggingface/transformers/tree/main/examples)) są tylko *przykładami*. Mogą nie działać od razu w twoim przypadku i będziesz musiał dostosować kod.

## 100 projektów wykorzystujących Transformers

Transformers to więcej niż narzędzie do korzystania z wstępnie wytrenowanych modeli – to społeczność projektów zbudowanych wokół niego i Hugging Face Hub. Chcemy, aby Transformers umożliwiał deweloperom, badaczom, studentom, profesorom, inżynierom i każdemu innemu realizowanie własnych wymarzonych projektów.

Aby uczcić przekroczenie 100 000 gwiazdek przez Transformers, postanowiliśmy wyróżnić społeczność poprzez stronę [awesome-transformers](./awesome-transformers.md), na której znajdziesz 100 niesamowitych projektów zbudowanych z Transformers.

Jeśli posiadasz lub używasz projektu, który twoim zdaniem powinien znaleźć się na tej liście, otwórz PR, aby go dodać!

## Przykładowe modele

Większość naszych modeli możesz przetestować bezpośrednio na ich [stronach na Hubie](https://huggingface.co/models).

Rozwiń każdą modalność poniżej, aby zobaczyć kilka przykładowych modeli do różnych zastosowań.

<details>
<summary>Audio</summary>

- Klasyfikacja dźwięku z [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)
- Automatyczne rozpoznawanie mowy z [Moonshine](https://huggingface.co/UsefulSensors/moonshine)
- Wykrywanie słów kluczowych z [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)
- Generowanie mowy z mowy z [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)
- Zamiana tekstu na audio z [MusicGen](https://huggingface.co/facebook/musicgen-large)
- Zamiana tekstu na mowę z [Bark](https://huggingface.co/suno/bark)

</details>

<details>
<summary>Komputerowe widzenie</summary>

- Automatyczne generowanie masek z [SAM](https://huggingface.co/facebook/sam-vit-base)
- Szacowanie głębokości z [DepthPro](https://huggingface.co/apple/DepthPro-hf)
- Klasyfikacja obrazów z [DINO v2](https://huggingface.co/facebook/dinov2-base)
- Wykrywanie punktów kluczowych z [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)
- Dopasowywanie punktów kluczowych z [SuperGlue](https://huggingface.co/magic-leap-community/superglue)
- Wykrywanie obiektów z [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)
- Estymacja pozy z [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)
- Uniwersalna segmentacja z [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)
- Klasyfikacja wideo z [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)

</details>

<details>
<summary>Multimodalność</summary>

- Audio lub tekst na tekst z [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)
- Odpowiadanie na pytania o dokumenty z [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)
- Obraz lub tekst na tekst z [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)
- Opisywanie obrazów [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)
- Rozumienie dokumentów OCR z [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)
- Odpowiadanie na pytania o tabelach z [TAPAS](https://huggingface.co/google/tapas-base)
- Zunifikowane rozumienie i generowanie multimodalne z [Emu3](https://huggingface.co/BAAI/Emu3-Gen)
- Wizja na tekst z [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)
- Wizualne odpowiadanie na pytania z [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)
- Wizualna segmentacja wyrażeń referencyjnych z [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)

</details>

<details>
<summary>NLP</summary>

- Uzupełnianie maskowanych słów z [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)
- Rozpoznawanie nazwanych encji z [Gemma](https://huggingface.co/google/gemma-2-2b)
- Odpowiadanie na pytania z [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)
- Streszczanie z [BART](https://huggingface.co/facebook/bart-large-cnn)
- Tłumaczenie z [T5](https://huggingface.co/google-t5/t5-base)
- Generowanie tekstu z [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)
- Klasyfikacja tekstu z [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)

</details>

## Cytowanie

Obecnie mamy [artykuł](https://www.aclweb.org/anthology/2020.emnlp-demos.6/), który możesz zacytować dla biblioteki 🤗 Transformers:
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