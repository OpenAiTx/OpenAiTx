
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Сопоставление потоков в PyTorch

Этот репозиторий содержит простую реализацию на PyTorch статьи [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747).

## Пример сопоставления потока в 2D

Ниже показан gif, демонстрирующий отображение одномерного гауссовского распределения в шахматное распределение с визуализацией векторного поля.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

А вот еще один пример с набором данных "луны".

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## Начало работы

Клонируйте репозиторий и настройте python-окружение.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Убедитесь, что у вас установлен Python версии 3.12 или выше.
Установите `uv`:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

Затем настройте среду:

```bash
uv sync
```

## Conditional Flow Matching [Lipman+ 2023]

Это оригинальная реализация статьи CFM [1]. Некоторые компоненты кода адаптированы из [2] и [3].

### 2D игрушечные датасеты

Вы можете обучать модели CFM на 2D синтетических датасетах, таких как `checkerboard` и `moons`. Укажите название датасета с помощью опции `--dataset`. Параметры обучения заранее определены в скрипте, а визуализации результатов обучения сохраняются в директории `outputs/`. Контрольные точки модели не включены, так как они легко воспроизводимы с настройками по умолчанию.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

Векторные поля и сгенерированные образцы, такие как те, что показаны в GIF-файлах в верхней части этого README, теперь можно найти в директории `outputs/cfm/`.

### Наборы изображений

Вы также можете обучать классово-условные модели CFM на популярных наборах данных для классификации изображений. Как сгенерированные образцы, так и контрольные точки модели будут сохраняться в директории `outputs/cfm`. Для получения подробного списка параметров обучения выполните команду `uv run scripts/train_flow_matching_on_image.py --help`.

Чтобы обучить классово-условную CFM на наборе данных MNIST, выполните:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```
После обучения вы теперь можете генерировать образцы с помощью:


```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```
Теперь вы должны увидеть сгенерированные образцы в директории `outputs/cfm/mnist/`.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Исправленный поток [Liu+ 2023]

Это реализация модели Reflow (а именно 2-Rectified Flow) из статьи Rectified Flow [2].

### 2D синтетические данные

Мы реализовали Reflow на 2d синтетических наборах данных, аналогично CFM. Для обучения reflow необходимо указать заранее обученные контрольные точки CFM, так как reflow является моделью дистилляции.

Например, чтобы обучить на наборе данных `checkerboard` с заранее обученной контрольной точкой CFM:


```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

Результаты обучения, включая визуализации векторных полей и сгенерированные образцы, сохраняются в папке `outputs/reflow/`.

### Сравнение процесса семплирования между CFM и Reflow

Для сравнения CFM и Reflow на двумерных датасетах выполните:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```

Получившиеся GIF-файлы можно найти в папке `outputs/comparisons/`. Ниже приведен пример сравнения двух методов на датасете `checkerboard`:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## Ссылки

- [1] Липман, Ярон и др. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Лю, Синчао и др. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---