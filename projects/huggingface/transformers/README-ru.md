<!---
Copyright 2020 The HuggingFace Team. All rights reserved.

Лицензировано на условиях лицензии Apache, версия 2.0 (далее — "Лицензия");
вы не можете использовать этот файл, кроме как в соответствии с Лицензией.
Вы можете получить копию Лицензии по адресу

    http://www.apache.org/licenses/LICENSE-2.0

Если это не требуется действующим законодательством или не согласовано в письменной форме, программное обеспечение,
распространяемое на условиях Лицензии, распространяется на основе "КАК ЕСТЬ",
БЕЗ ГАРАНТИЙ ИЛИ УСЛОВИЙ ЛЮБОГО ВИДА, явных или подразумеваемых.
См. Лицензию для конкретных положений, регулирующих разрешения и ограничения по Лицензии.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Библиотека Hugging Face Transformers" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Контрольные точки на Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Сборка" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Документация" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="GitHub релиз" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
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
    <p>Современные предварительно обученные модели для вывода и обучения</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers — это библиотека предварительно обученных моделей для обработки текста, компьютерного зрения, аудио, видео и мультимодальных данных для вывода и обучения. Используйте Transformers для дообучения моделей на ваших данных, создания приложений для вывода и генеративного ИИ для различных модальностей.

На [Hugging Face Hub](https://huggingface.com/models) доступно более 500 000+ [контрольных точек моделей](https://huggingface.co/models?library=transformers&sort=trending), которые вы можете использовать.

Изучите [Hub](https://huggingface.com/) уже сегодня, чтобы найти подходящую модель и использовать Transformers для быстрого старта.

## Установка

Transformers работает с Python 3.9+, [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+ и [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+.

Создайте и активируйте виртуальное окружение с помощью [venv](https://docs.python.org/3/library/venv.html) или [uv](https://docs.astral.sh/uv/) — быстрого пакетного и проектного менеджера на Rust.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

Установите Transformers в ваше виртуальное окружение.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

Установите Transformers из исходников, если вам нужны последние изменения в библиотеке или вы хотите внести вклад. Однако *самая свежая* версия может быть нестабильной. Не стесняйтесь открывать [issue](https://github.com/huggingface/transformers/issues), если столкнетесь с ошибкой.

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## Быстрый старт

Начните работу с Transformers прямо сейчас с помощью API [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial). `Pipeline` — это высокоуровневый класс для вывода, поддерживающий задачи с текстом, аудио, изображениями и мультимодальные задачи. Он обрабатывает препроцессинг входных данных и возвращает соответствующий результат.

Создайте pipeline и укажите модель для генерации текста. Модель будет загружена и закэширована, чтобы вы могли использовать её повторно. Затем передайте текст для генерации.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

Чтобы пообщаться с моделью, используйте тот же шаблон. Единственное отличие — необходимо построить историю диалога (вход для `Pipeline`) между вами и системой.

> [!ПОДСКАЗКА]
> Вы также можете общаться с моделью напрямую из командной строки.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "Ты остроумный, дерзкий робот, каким его представлял Голливуд в 1986 году."},
    {"role": "user", "content": "Эй, можешь подсказать, чем заняться в Нью-Йорке?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

Разверните примеры ниже, чтобы увидеть, как работает `Pipeline` для разных модальностей и задач.

<details>
<summary>Автоматическое распознавание речи</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>Классификация изображений</summary>

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
<summary>Визуальный вопрос-ответ</summary>


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

## Почему стоит использовать Transformers?

1. Простые в использовании современные модели:
    - Высокая производительность в задачах понимания и генерации естественного языка, компьютерного зрения, аудио, видео и мультимодальных задачах.
    - Низкий порог входа для исследователей, инженеров и разработчиков.
    - Минимум пользовательских абстракций — всего три класса для изучения.
    - Унифицированный API для использования всех наших предварительно обученных моделей.

1. Снижение вычислительных затрат и углеродного следа:
    - Делитесь обученными моделями вместо обучения с нуля.
    - Сокращайте время вычислений и издержки на продакшн.
    - Десятки архитектур моделей с более чем 1 млн предварительно обученных контрольных точек по всем модальностям.

1. Выбор подходящего фреймворка на каждом этапе жизненного цикла модели:
    - Обучайте современные модели в 3 строки кода.
    - Перемещайте одну модель между PyTorch/JAX/TF2.0 по желанию.
    - Выбирайте оптимальный фреймворк для обучения, оценки и продакшна.

1. Легко адаптируйте модель или пример под ваши нужды:
    - Мы предоставляем примеры для каждой архитектуры для воспроизведения результатов, опубликованных авторами.
    - Внутренние компоненты моделей максимально открыты.
    - Файлы моделей можно использовать независимо от библиотеки для быстрых экспериментов.

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## Почему не стоит использовать Transformers?

- Эта библиотека не является модульным набором строительных блоков для нейросетей. Код в файлах моделей специально не рефакторится с дополнительными абстракциями, чтобы исследователи могли быстро тестировать каждую модель без необходимости разбираться в дополнительных абстракциях/файлах.
- API для обучения оптимизирован для работы с моделями PyTorch, предоставляемыми Transformers. Для универсальных циклов машинного обучения используйте другую библиотеку, например, [Accelerate](https://huggingface.co/docs/accelerate).
- [Примерные скрипты]((https://github.com/huggingface/transformers/tree/main/examples)) — это всего лишь *примеры*. Они могут не работать "из коробки" под вашу задачу, и потребуется адаптация кода.

## 100 проектов на базе Transformers

Transformers — это не просто набор инструментов для использования предварительно обученных моделей, это сообщество проектов, построенных вокруг него и Hugging Face Hub. Мы хотим, чтобы Transformers помогал разработчикам, исследователям, студентам, преподавателям, инженерам и всем остальным создавать проекты мечты.

В честь достижения 100 000 звёзд Transformers мы хотим выделить сообщество на странице [awesome-transformers](./awesome-transformers.md), где перечислены 100 потрясающих проектов на базе Transformers.

Если вы являетесь владельцем или пользователем проекта, который должен быть в списке, откройте PR для его добавления!

## Примеры моделей

Вы можете протестировать большинство моделей прямо на их [страницах на Hub](https://huggingface.co/models).

Разверните каждую модальность ниже, чтобы увидеть примеры моделей для разных случаев использования.

<details>
<summary>Аудио</summary>

- Классификация аудио с помощью [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)
- Автоматическое распознавание речи с [Moonshine](https://huggingface.co/UsefulSensors/moonshine)
- Поиск ключевых слов с [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)
- Генерация речи по речи с помощью [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)
- Текст в аудио с [MusicGen](https://huggingface.co/facebook/musicgen-large)
- Текст в речь с помощью [Bark](https://huggingface.co/suno/bark)

</details>

<details>
<summary>Компьютерное зрение</summary>

- Автоматическая генерация масок с помощью [SAM](https://huggingface.co/facebook/sam-vit-base)
- Оценка глубины с [DepthPro](https://huggingface.co/apple/DepthPro-hf)
- Классификация изображений с [DINO v2](https://huggingface.co/facebook/dinov2-base)
- Детекция ключевых точек с [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)
- Сопоставление ключевых точек с [SuperGlue](https://huggingface.co/magic-leap-community/superglue)
- Обнаружение объектов с [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)
- Оценка позы с помощью [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)
- Универсальная сегментация с [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)
- Классификация видео с [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)

</details>

<details>
<summary>Мультимодальные</summary>

- Аудио или текст в текст с помощью [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)
- Вопрос-ответ по документу с [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)
- Изображение или текст в текст с [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)
- Подписи к изображениям [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)
- Понимание документов на основе OCR с помощью [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)
- Вопрос-ответ по таблицам с [TAPAS](https://huggingface.co/google/tapas-base)
- Унифицированное мультимодальное понимание и генерация с [Emu3](https://huggingface.co/BAAI/Emu3-Gen)
- Визуальное восприятие в текст с помощью [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)
- Визуальный вопрос-ответ с [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)
- Визуальная сегментация по выражениям с [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)

</details>

<details>
<summary>NLP</summary>

- Дополнение замаскированных слов с помощью [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)
- Распознавание именованных сущностей с [Gemma](https://huggingface.co/google/gemma-2-2b)
- Вопрос-ответ с [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)
- Реферирование с [BART](https://huggingface.co/facebook/bart-large-cnn)
- Перевод с помощью [T5](https://huggingface.co/google-t5/t5-base)
- Генерация текста с [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)
- Классификация текста с [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)

</details>

## Цитирование

Теперь у нас есть [статья](https://www.aclweb.org/anthology/2020.emnlp-demos.6/), которую вы можете цитировать для библиотеки 🤗 Transformers:
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