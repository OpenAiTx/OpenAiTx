
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## Быстрый и высококачественный текст-в-голос без обучения на примерах с Flow Matching
</div>

## Обзор

ZipVoice — это серия быстрых и высококачественных моделей TTS с нулевым обучением, основанных на flow matching.

### 1. Ключевые особенности

- Маленькая и быстрая: всего 123M параметров.

- Высококачественное клонирование голоса: передовые показатели по похожести голоса, разборчивости и естественности.

- Многоязычность: поддержка китайского и английского языков.

- Мультирежимность: поддержка генерации речи как для одного говорящего, так и для диалога.

### 2. Варианты моделей

<table>
  <thead>
    <tr>
      <th>Название модели</th>
      <th>Описание</th>
      <th>Статья</th>
      <th>Демо</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>Базовая модель, поддерживающая нулевое обучение TTS для одного говорящего на китайском и английском языках.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>Дистиллированная версия ZipVoice, отличающаяся повышенной скоростью при минимальных потерях качества.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Модель для генерации диалогов на основе ZipVoice, способная генерировать одноканальные диалоги между двумя собеседниками.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>Стерео-версия ZipVoice-Dialog, позволяющая создавать диалоги с двумя каналами, при этом каждому собеседнику назначается отдельный канал.</td>
    </tr>
  </tbody>
</table>

## Новости

**2025/07/14**: Вышли две модели генерации устных диалогов: **ZipVoice-Dialog** и **ZipVoice-Dialog-Stereo**. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: Выпущен датасет **OpenDialog** — 6,8 тысяч часов устных диалогов. Скачать можно на [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Подробнее на [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: Выпущены **ZipVoice** и **ZipVoice-Distill**. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Установка

### 1. Клонируйте репозиторий ZipVoice

```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (Необязательно) Создайте виртуальное окружение Python


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. Установите необходимые пакеты


```bash
pip install -r requirements.txt
```
### 4. Установите k2 для обучения или эффективного вывода

**k2 необходим для обучения** и может ускорить вывод. Тем не менее, вы всё равно можете использовать режим вывода ZipVoice без установки k2.

> **Примечание:** Убедитесь, что устанавливаете версию k2, соответствующую вашей версии PyTorch и CUDA. Например, если вы используете pytorch 2.5.1 и CUDA 12.1, вы можете установить k2 следующим образом:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Пожалуйста, ознакомьтесь с https://k2-fsa.org/get-started/k2/ для подробностей.
Пользователи из материкового Китая могут обратиться к https://k2-fsa.org/zh-CN/get-started/k2/.

- Чтобы проверить установку k2:


```bash
python3 -c "import k2; print(k2.__file__)"
```
## Использование

### 1. Генерация речи одним говорящим

Чтобы сгенерировать речь от одного говорящего с помощью наших предобученных моделей ZipVoice или ZipVoice-Distill, используйте следующие команды (необходимые модели будут загружены с HuggingFace):

#### 1.1 Инференс одного предложения


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` может быть `zipvoice` или `zipvoice_distill`, что соответствует моделям до и после дистилляции соответственно.
- Если в тексте встречаются `<>` или `[]`, строки, заключённые в них, будут рассматриваться как специальные токены. `<>` обозначает китайскую пиньинь, а `[]` — другие специальные теги.

#### 1.2 Инференс списка предложений

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- Каждая строка файла `test.tsv` имеет формат `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. Диалоговая генерация речи

#### 2.1 Команда для инференса

Чтобы сгенерировать двухсторонние устные диалоги с помощью наших предобученных моделей ZipVoice-Dialogue или ZipVoice-Dialogue-Stereo, используйте следующие команды (необходимые модели будут загружены с HuggingFace):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` может быть `zipvoice_dialog` или `zipvoice_dialog_stereo`,
    которые генерируют соответственно моно- и стерео-диалоги.

#### 2.2 Форматы входных данных

Каждая строка файла `test.tsv` соответствует одному из следующих форматов:

(1) **Формат объединённого запроса**, где аудиозаписи и транскрипции двух реплик объединены в один wav-файл запроса:

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```

- `wav_name` — это имя выходного wav-файла.
- `prompt_transcription` — это транскрипция звукового файла с разговорным запросом, например, "[S1] Привет. [S2] Как дела?"
- `prompt_wav` — это путь к звуковому файлу запроса.
- `text` — это текст для синтеза, например: "[S1] У меня всё хорошо. [S2] Как тебя зовут? [S1] Я Эрик. [S2] Привет, Эрик."

(2) **Формат разделённого запроса**, где аудиофайлы и транскрипции двух говорящих существуют в отдельных файлах:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` — имя выходного wav-файла.
- `spk1_prompt_transcription` — транскрипция подсказки первого говорящего, например, "Hello".
- `spk2_prompt_transcription` — транскрипция подсказки второго говорящего, например, "How are you?"
- `spk1_prompt_wav` — путь к wav-файлу подсказки первого говорящего.
- `spk2_prompt_wav` — путь к wav-файлу подсказки второго говорящего.
- `text` — текст для синтеза, например, "[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric."

### 3 Руководство по лучшему использованию:

#### 3.1 Длина подсказки

Рекомендуем использовать короткий wav-файл подсказки (например, менее 3 секунд для генерации речи одного говорящего, менее 10 секунд для генерации диалога), чтобы ускорить процесс вывода. Очень длинная подсказка замедлит вывод и ухудшит качество речи.

#### 3.2 Оптимизация скорости

Если скорость вывода неудовлетворительная, вы можете ускорить процесс следующим образом:

- **Дистиллированная модель и меньше шагов**: Для модели генерации речи одного говорящего по умолчанию используется модель `zipvoice` для лучшего качества речи. Если приоритет — скорость, можно переключиться на `zipvoice_distill` и уменьшить `--num-steps` до значения `4` (по умолчанию 8).

- **Ускорение на CPU с многопоточностью**: При запуске на CPU вы можете указать параметр `--num-thread` (например, `--num-thread 4`), чтобы увеличить количество потоков и ускорить процесс. По умолчанию используется 1 поток.

- **Ускорение на CPU с ONNX**: При запуске на CPU можно использовать ONNX-модели с помощью `zipvoice.bin.infer_zipvoice_onnx` для ускорения (ONNX пока не поддерживается для моделей генерации диалогов). Для ещё большей скорости можно установить `--onnx-int8 True` и использовать квантованную ONNX-модель с INT8. Обратите внимание, что качество речи при этом может ухудшиться. **Не используйте ONNX на GPU**, так как на GPU он работает медленнее, чем PyTorch.

#### 3.3 Контроль памяти

Введённый текст будет разбит на части по знакам препинания (для генерации речи одного говорящего) или по символу смены говорящего (для генерации диалога). Затем части текста будут обработаны пакетами. Таким образом, модель может обрабатывать текст любой длины при почти постоянном использовании памяти. Вы можете управлять использованием памяти с помощью параметра `--max-duration`.

#### 3.4 "Сырой" режим оценки

По умолчанию мы предварительно обрабатываем входные данные (wav-файл подсказки, транскрипцию подсказки и текст) для эффективного вывода и лучшей производительности. Если вы хотите оценить "сырое" качество модели на точных предоставленных входных данных (например, для воспроизведения результатов из нашей статьи), передайте параметр `--raw-evaluation True`.

#### 3.5 Короткий текст

При генерации речи для очень коротких текстов (например, одно-два слова), сгенерированная речь может иногда пропускать некоторые произношения. Чтобы решить эту проблему, передайте параметр `--speed 0.3` (0.3 — настраиваемое значение), чтобы увеличить длительность сгенерированной речи.

#### 3.6 Исправление неправильного произношения китайских многозначных иероглифов

Мы используем [pypinyin](https://github.com/mozillazg/python-pinyin) для преобразования китайских иероглифов в пиньинь. Однако иногда он может неправильно произносить **многозначные иероглифы** (多音字).


Чтобы вручную исправить эти ошибки произношения, заключайте **исправленный пиньинь** в угловые скобки `< >` и добавляйте **обозначение тона**.

**Пример:**

- Оригинальный текст: `这把剑长三十公分`
- Исправьте пиньинь для `长`:  `这把剑<chang2>三十公分`

> **Примечание:** Если вы хотите вручную назначить несколько вариантов пиньиня, заключайте каждый пиньинь в `<>`, например: `这把<jian4><chang2><san1>十公分`

#### 3.7 Удаление длинных пауз из сгенерированной речи

Модель автоматически определяет позиции и длительность пауз в сгенерированной речи. Иногда в середине речи появляются длинные паузы. Если вы хотите их убрать, передайте флаг `--remove-long-sil` для удаления длинных пауз в середине сгенерированной речи (краевые паузы удаляются по умолчанию).

#### 3.8 Загрузка модели

Если у вас возникают проблемы с подключением к HuggingFace при загрузке предобученных моделей, попробуйте переключить endpoint на зеркальный сайт: `export HF_ENDPOINT=https://hf-mirror.com`.

## Обучение собственной модели

Смотрите директорию [egs](egs) для примеров обучения, дообучения и оценки.

## Развертывание на C++

Посмотрите [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) для решения по развертыванию на C++ на CPU.

## Обсуждение и коммуникация

Вы можете напрямую обсуждать на [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Вы также можете отсканировать QR-код для вступления в нашу группу в WeChat или подписаться на официальный аккаунт WeChat.

| Группа Wechat | Официальный аккаунт Wechat |
| ------------- | -------------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Цитирование

```bibtex
@article{zhu2025zipvoice,
      title={ZipVoice: Fast and High-Quality Zero-Shot Text-to-Speech with Flow Matching},
      author={Zhu, Han and Kang, Wei and Yao, Zengwei and Guo, Liyong and Kuang, Fangjun and Li, Zhaoqing and Zhuang, Weiji and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2506.13053},
      year={2025}
}

@article{zhu2025zipvoicedialog,
      title={ZipVoice-Dialog: Non-Autoregressive Spoken Dialogue Generation with Flow Matching},
      author={Zhu, Han and Kang, Wei and Guo, Liyong and Yao, Zengwei and Kuang, Fangjun and Zhuang, Weiji and Li, Zhaoqing and Han, Zhifeng and Zhang, Dong and Zhang, Xin and Song, Xingchen and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2507.09318},
      year={2025}
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---