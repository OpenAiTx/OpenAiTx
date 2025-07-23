<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# 🚀 Нет времени на обучение!  
### Сегментация экземпляров на основе эталонов без обучения  
[![GitHub](https://img.shields.io/badge/%E2%80%8B-No%20Time%20To%20Train-black?logo=github)](https://github.com/miquel-espinosa/no-time-to-train)
[![Website](https://img.shields.io/badge/🌐-Project%20Page-grey)](https://miquel-espinosa.github.io/no-time-to-train/)
[![arXiv](https://img.shields.io/badge/arXiv-2507.02798-b31b1b)](https://arxiv.org/abs/2507.02798)

**Современное состояние (Papers with Code)**

[**_SOTA 1-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-1-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference)

[**_SOTA 10-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-10-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference)

[**_SOTA 30-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-30-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference)

</div>

---

> 🚨 **Обновление (22 июля 2025):** Добавлены инструкции для собственных датасетов!
> 
> 🔔 **Обновление (16 июля 2025):** Код обновлён с инструкциями!

---

## 📋 Оглавление

- [🎯 Основные моменты](#-highlights)
- [📜 Аннотация](#-abstract)
- [🧠 Архитектура](#-architecture)
- [🛠️ Инструкция по установке](#️-installation-instructions)
  - [1. Клонировать репозиторий](#1-clone-the-repository)
  - [2. Создать conda окружение](#2-create-conda-environment)
  - [3. Установить SAM2 и DinoV2](#3-install-sam2-and-dinov2)
  - [4. Скачать датасеты](#4-download-datasets)
  - [5. Скачать контрольные точки SAM2 и DinoV2](#5-download-sam2-and-dinov2-checkpoints)
- [📊 Код инференса: Воспроизведение результатов 30-shot SOTA на Few-shot COCO](#-inference-code)
  - [0. Создать эталонный набор](#0-create-reference-set)
  - [1. Заполнить память эталонами](#1-fill-memory-with-references)
  - [2. Постобработка банка памяти](#2-post-process-memory-bank)
  - [3. Инференс на целевых изображениях](#3-inference-on-target-images)
  - [Результаты](#results)
- [🔍 Собственный датасет](#-custom-dataset)
  - [0. Подготовить собственный датасет ⛵🐦](#0-prepare-a-custom-dataset)
  - [0.1 Если доступны только bbox-аннотации](#01-if-only-bbox-annotations-are-available)
  - [0.2 Конвертировать аннотации coco в файл pickle](#02-convert-coco-annotations-to-pickle-file)
  - [1. Заполнить память эталонами](#1-fill-memory-with-references)
  - [2. Постобработка банка памяти](#2-post-process-memory-bank)
- [📚 Цитирование](#-citation)


## 🎯 Основные моменты
- 💡 **Без обучения**: Без дообучения, без prompt engineering — только эталонное изображение.  
- 🖼️ **На основе эталона**: Сегментируйте новые объекты всего по нескольким примерам.  
- 🔥 **SOTA производительность**: Превосходит предыдущие безобучающие методы на COCO, PASCAL VOC и Cross-Domain FSOD.

**Ссылки:**
- 🧾 [**Статья на arXiv**](https://arxiv.org/abs/2507.02798)  
- 🌐 [**Сайт проекта**](https://miquel-espinosa.github.io/no-time-to-train/)  
- 📈 [**Papers with Code**](https://paperswithcode.com/paper/no-time-to-train-training-free-reference)

## 📜 Аннотация

> Эффективность моделей сегментации изображений исторически ограничивалась высокой стоимостью сбора крупномасштабных размеченных данных. Модель Segment Anything (SAM) решает эту исходную проблему с помощью парадигмы сегментации, не зависящей от семантики и использующей запросы, однако по-прежнему требует ручных визуальных запросов или сложных, зависящих от домена, правил генерации запросов для обработки нового изображения. С целью снижения этой новой нагрузки наша работа исследует задачу сегментации объектов при наличии альтернативно лишь небольшого набора эталонных изображений. Наш ключевой вывод — использовать сильные семантические приоритеты, изученные базовыми моделями, для определения соответствующих областей между эталонным и целевым изображением. Мы обнаружили, что такие соответствия позволяют автоматически генерировать сегментационные маски экземпляров для последующих задач, и реализуем наши идеи с помощью многоэтапного метода без обучения, включающего (1) построение банка памяти; (2) агрегацию представлений и (3) семантически осознанное сопоставление признаков. Наши эксперименты показывают значительные улучшения метрик сегментации, что приводит к передовым результатам на COCO FSOD (36.8% nAP), PASCAL VOC Few-Shot (71.2% nAP50) и превосходит существующие безобучающие подходы на Cross-Domain FSOD (22.4% nAP).

![cdfsod-results-final-comic-sans-min](https://github.com/user-attachments/assets/ab302c02-c080-4042-99fc-0e181ba8abb9)




## 🧠 Архитектура

![training-free-architecture-comic-sans-min](https://github.com/user-attachments/assets/d84dd83a-505e-45a0-8ce3-98e1838017f9)


## 🛠️ Инструкции по установке

### 1. Клонируйте репозиторий

```bash
git clone https://github.com/miquel-espinosa/no-time-to-train.git
cd no-time-to-train
```
### 2. Создайте окружение conda

Мы создадим окружение conda с необходимыми пакетами.

```bash
conda env create -f environment.yml
conda activate no-time-to-train
```
### 3. Установка SAM2 и DinoV2

Мы установим SAM2 и DinoV2 из исходных кодов.

```bash
pip install -e .
cd dinov2
pip install -e .
cd ..
```
### 4. Загрузка наборов данных

Пожалуйста, скачайте набор данных COCO и поместите его в `data/coco`

### 5. Загрузка контрольных точек SAM2 и DinoV2

Мы загрузим именно те контрольные точки SAM2, которые использовались в статье.
(Обратите внимание, что контрольные точки SAM2.1 уже доступны и могут работать лучше.)


```bash
mkdir -p checkpoints/dinov2
cd checkpoints
wget https://dl.fbaipublicfiles.com/segment_anything_2/072824/sam2_hiera_large.pt
cd dinov2
wget https://dl.fbaipublicfiles.com/dinov2/dinov2_vitl14/dinov2_vitl14_pretrain.pth
cd ../..
```
## 📊 Код для инференса

⚠️ Отказ от ответственности: Это исследовательский код — ожидайте некоторого хаоса!

### Воспроизведение результатов SOTA с 30 примерами на Few-shot COCO

Определите полезные переменные и создайте папку для результатов:



```bash
CONFIG=./no_time_to_train/new_exps/coco_fewshot_10shot_Sam2L.yaml
CLASS_SPLIT="few_shot_classes"
RESULTS_DIR=work_dirs/few_shot_results
SHOTS=30
SEED=33
GPUS=4

mkdir -p $RESULTS_DIR
FILENAME=few_shot_${SHOTS}shot_seed${SEED}.pkl
```
#### 0. Создайте эталонный набор


```bash
python no_time_to_train/dataset/few_shot_sampling.py \
        --n-shot $SHOTS \
        --out-path ${RESULTS_DIR}/${FILENAME} \
        --seed $SEED \
        --dataset $CLASS_SPLIT
```
#### 1. Заполните память ссылками


```bash
python run_lightening.py test --config $CONFIG \
                              --model.test_mode fill_memory \
                              --out_path ${RESULTS_DIR}/memory.ckpt \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --model.init_args.dataset_cfgs.fill_memory.memory_pkl ${RESULTS_DIR}/${FILENAME} \
                              --model.init_args.dataset_cfgs.fill_memory.memory_length $SHOTS \
                              --model.init_args.dataset_cfgs.fill_memory.class_split $CLASS_SPLIT \
                              --trainer.logger.save_dir ${RESULTS_DIR}/ \
                              --trainer.devices $GPUS
```
#### 2. Постобработка банка памяти


```bash
python run_lightening.py test --config $CONFIG \
                              --model.test_mode postprocess_memory \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --ckpt_path ${RESULTS_DIR}/memory.ckpt \
                              --out_path ${RESULTS_DIR}/memory_postprocessed.ckpt \
                              --trainer.devices 1
```
#### 3. Инференс на целевых изображениях


```bash
python run_lightening.py test --config $CONFIG  \
                              --ckpt_path ${RESULTS_DIR}/memory_postprocessed.ckpt \
                              --model.init_args.test_mode test \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --model.init_args.model_cfg.dataset_name $CLASS_SPLIT \
                              --model.init_args.dataset_cfgs.test.class_split $CLASS_SPLIT \
                              --trainer.logger.save_dir ${RESULTS_DIR}/ \
                              --trainer.devices $GPUS
```
Если вы хотите видеть результаты инференса онлайн (по мере их вычисления), раскомментируйте строки 1746-1749 в файле `no_time_to_train/models/Sam2MatchingBaseline_noAMG.py` [здесь](https://github.com/miquel-espinosa/no-time-to-train/blob/main/no_time_to_train/models/Sam2MatchingBaseline_noAMG.py#L1746).
Отрегулируйте пороговый параметр `score_thr` по мере необходимости, чтобы видеть больше или меньше сегментированных экземпляров.
Изображения теперь будут сохраняться в `results_analysis/few_shot_classes/`. Изображение слева показывает эталонную разметку, изображение справа — сегментированные экземпляры, найденные нашим методом без обучения.

Обратите внимание, что в этом примере мы используем разбиение `few_shot_classes`, поэтому следует ожидать сегментированные экземпляры только классов из этого разбиения (не всех классов COCO).

#### Результаты

После обработки всех изображений валидационного набора вы должны получить:


```
BBOX RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.368

SEGM RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.342
```
---

## 🔍 Пользовательский датасет

Мы предоставляем инструкции по запуску нашего пайплайна на пользовательском датасете. Формат аннотаций всегда COCO.

> **Кратко;** Чтобы сразу увидеть, как запустить полный пайплайн на *пользовательских датасетах*, смотрите `scripts/matching_cdfsod_pipeline.sh` вместе с примерами скриптов для датасетов CD-FSOD (например, `scripts/dior_fish.sh`)

### 0. Подготовьте пользовательский датасет ⛵🐦

Представим, что мы хотим обнаруживать **лодки**⛵ и **птиц**🐦 в пользовательском датасете. Чтобы использовать наш метод, потребуется:
- Как минимум 1 *аннотированное* эталонное изображение для каждого класса (т.е. 1 эталон для лодки и 1 эталон для птицы)
- Несколько целевых изображений для поиска экземпляров нужных нам классов.

Мы подготовили простой скрипт для создания пользовательского датасета с изображениями coco для **1-shot** сценария.
```bash
python scripts/make_custom_dataset.py
```
Это создаст пользовательский набор данных со следующей структурой папок:
```
data/my_custom_dataset/
    ├── annotations/
    │   ├── custom_references.json
    │   ├── custom_targets.json
    │   └── references_visualisations/
    │       ├── bird_1.jpg
    │       └── boat_1.jpg
    └── images/
        ├── 429819.jpg
        ├── 101435.jpg
        └── (all target and reference images)
```
**Визуализация эталонных изображений (1-shot):**

| 1-shot эталонное изображение для ПТИЦЫ 🐦 | 1-shot эталонное изображение для ЛОДКИ ⛵ |
|:-----------------------------------------:|:------------------------------------------:|
| <img src="https://github.com/user-attachments/assets/e59e580d-a7db-42ac-b386-892af211fc85" alt="bird_1" width="500"/> | <img src="https://github.com/user-attachments/assets/f94ee025-ae37-4a45-9c3e-0cfe8f8cd2bc" alt="boat_1" width="500"/> |


### 0.1 Если доступны только аннотации bbox

Мы также предоставляем скрипт для генерации масок сегментации объектов с помощью SAM2. Это полезно, если для эталонных изображений доступны только аннотации ограничивающими рамками.


```bash
# Download sam_h checkpoint. Feel free to use more recent checkpoints (note: code might need to be adapted)
wget https://dl.fbaipublicfiles.com/segment_anything/sam_vit_h_4b8939.pth -O checkpoints/sam_vit_h_4b8939.pth
# Run automatic instance segmentation from ground truth bounding boxes.
python no_time_to_train/dataset/sam_bbox_to_segm_batch.py \
    --input_json data/my_custom_dataset/annotations/custom_references.json \
    --image_dir data/my_custom_dataset/images \
    --sam_checkpoint checkpoints/sam_vit_h_4b8939.pth \
    --model_type vit_h \
    --device cuda \
    --batch_size 8 \
    --visualize
```
**Референсные изображения с масками сегментации на уровне экземпляра (сгенерировано SAM2 из gt-баундинг-боксов, 1-shot):**

Визуализация сгенерированных масок сегментации сохранена в `data/my_custom_dataset/annotations/custom_references_with_SAM_segm/references_visualisations/`.


| 1-shot референсное изображение ПТИЦЫ 🐦 (автоматически сегментировано SAM) | 1-shot референсное изображение ЛОДКИ ⛵ (автоматически сегментировано SAM) |
|:---------------------------------:|:----------------------------------:|
| <img src="https://github.com/user-attachments/assets/65d38dc4-1454-43cd-9600-e8efc67b3a82" alt="bird_1_with_SAM_segm" width="500"/> | <img src="https://github.com/user-attachments/assets/43a558ad-50ca-4715-8285-9aa3268843c6" alt="boat_1_with_SAM_segm" width="500"/> |


### 0.2 Конвертация аннотаций coco в файл pickle


```bash
python no_time_to_train/dataset/coco_to_pkl.py \
    data/my_custom_dataset/annotations/custom_references_with_segm.json \
    data/my_custom_dataset/annotations/custom_references_with_segm.pkl \
    1
```
### 1. Заполните память ссылками

Сначала определите полезные переменные и создайте папку для результатов. Для корректной визуализации меток имена классов должны быть упорядочены по id категории, как указано в файле json. Например, у `bird` id категории `16`, у `boat` id категории `9`. Следовательно, `CAT_NAMES=boat,bird`.


```bash
DATASET_NAME=my_custom_dataset
DATASET_PATH=data/my_custom_dataset
CAT_NAMES=boat,bird
CATEGORY_NUM=2
SHOT=1
YAML_PATH=no_time_to_train/pl_configs/matching_cdfsod_template.yaml
PATH_TO_SAVE_CKPTS=./tmp_ckpts/my_custom_dataset
mkdir -p $PATH_TO_SAVE_CKPTS
```
Выполните шаг 1:

```bash
python run_lightening.py test --config $YAML_PATH \
    --model.test_mode fill_memory \
    --out_path $PATH_TO_SAVE_CKPTS/$DATASET_NAME\_$SHOT\_refs_memory.pth \
    --model.init_args.dataset_cfgs.fill_memory.root $DATASET_PATH/images \
    --model.init_args.dataset_cfgs.fill_memory.json_file $DATASET_PATH/annotations/custom_references_with_segm.json \
    --model.init_args.dataset_cfgs.fill_memory.memory_pkl $DATASET_PATH/annotations/custom_references_with_segm.pkl \
    --model.init_args.dataset_cfgs.fill_memory.memory_length $SHOT \
    --model.init_args.dataset_cfgs.fill_memory.cat_names $CAT_NAMES \
    --model.init_args.model_cfg.dataset_name $DATASET_NAME \
    --model.init_args.model_cfg.memory_bank_cfg.length $SHOT \
    --model.init_args.model_cfg.memory_bank_cfg.category_num $CATEGORY_NUM \
    --trainer.devices 1
```
### 2. Постобработка банка памяти


```bash
python run_lightening.py test --config $YAML_PATH \
    --model.test_mode postprocess_memory \
    --ckpt_path $PATH_TO_SAVE_CKPTS/$DATASET_NAME\_$SHOT\_refs_memory.pth \
    --out_path $PATH_TO_SAVE_CKPTS/$DATASET_NAME\_$SHOT\_refs_memory_postprocessed.pth \
    --model.init_args.model_cfg.dataset_name $DATASET_NAME \
    --model.init_args.model_cfg.memory_bank_cfg.length $SHOT \
    --model.init_args.model_cfg.memory_bank_cfg.category_num $CATEGORY_NUM \
    --trainer.devices 1
```
### 3. Инференс на целевых изображениях

Если `ONLINE_VIS` установлен в True, результаты предсказания будут сохраняться в `results_analysis/my_custom_dataset/` и отображаться по мере вычисления. ОБРАТИТЕ ВНИМАНИЕ, что запуск с онлайн-визуализацией значительно медленнее.

Не стесняйтесь изменять порог оценки `VIS_THR`, чтобы видеть больше или меньше сегментированных экземпляров.

```bash
ONLINE_VIS=True
VIS_THR=0.4
python run_lightening.py test --config $YAML_PATH \
    --model.test_mode test \
    --ckpt_path $PATH_TO_SAVE_CKPTS/$DATASET_NAME\_$SHOT\_refs_memory_postprocessed.pth \
    --model.init_args.model_cfg.dataset_name $DATASET_NAME \
    --model.init_args.model_cfg.memory_bank_cfg.length $SHOT \
    --model.init_args.model_cfg.memory_bank_cfg.category_num $CATEGORY_NUM \
    --model.init_args.model_cfg.test.imgs_path $DATASET_PATH/images \
    --model.init_args.model_cfg.test.online_vis $ONLINE_VIS \
    --model.init_args.model_cfg.test.vis_thr $VIS_THR \
    --model.init_args.dataset_cfgs.test.root $DATASET_PATH/images \
    --model.init_args.dataset_cfgs.test.json_file $DATASET_PATH/annotations/custom_targets.json \
    --model.init_args.dataset_cfgs.test.cat_names $CAT_NAMES \
    --trainer.devices 1
```
### Результаты

Показатели производительности (с теми же параметрами, что и в приведённых выше командах), должны быть следующими:


```
BBOX RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.478

SEGM RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.458
```
Визуальные результаты сохраняются в `results_analysis/my_custom_dataset/`. Обратите внимание, что наш метод работает и для ложноотрицательных случаев, то есть для изображений, на которых отсутствуют экземпляры нужных классов.

*Нажмите на изображения, чтобы увеличить ⬇️*

| Целевое изображение с лодками ⛵ (слева GT, справа предсказания) | Целевое изображение с птицами 🐦 (слева GT, справа предсказания) |
|:----------------------:|:----------------------:|
| ![000000459673](https://github.com/user-attachments/assets/678dc15a-dd3b-49d5-9287-6290da16aa6b) | ![000000407180](https://github.com/user-attachments/assets/fe306e48-af49-4d83-ac82-76fac6c456d1) |

| Целевое изображение с лодками и птицами ⛵🐦 (слева GT, справа предсказания) | Целевое изображение без лодок и птиц 🚫 (слева GT, справа предсказания) |
|:---------------------------------:|:----------------------------------:|
| ![000000517410](https://github.com/user-attachments/assets/9849b227-7f43-43d7-81ea-58010a623ad5) | ![000000460598](https://github.com/user-attachments/assets/7587700c-e09d-4cf6-8590-3df129c2568e) |


## 📚 Цитирование

Если вы используете эту работу, пожалуйста, цитируйте нас:


```bibtex
@article{espinosa2025notimetotrain,
  title={No time to train! Training-Free Reference-Based Instance Segmentation},
  author={Miguel Espinosa and Chenhongyi Yang and Linus Ericsson and Steven McDonagh and Elliot J. Crowley},
  journal={arXiv preprint arXiv:2507.02798},
  year={2025},
  primaryclass={cs.CV}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---