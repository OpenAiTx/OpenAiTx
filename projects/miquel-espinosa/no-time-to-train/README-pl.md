<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

# 🚀 No Time to Train!  
### Segmentacja instancji bez treningu na podstawie referencji  
[![GitHub](https://img.shields.io/badge/%E2%80%8B-No%20Time%20To%20Train-black?logo=github)](https://github.com/miquel-espinosa/no-time-to-train)
[![Website](https://img.shields.io/badge/🌐-Project%20Page-grey)](https://miquel-espinosa.github.io/no-time-to-train/)
[![arXiv](https://img.shields.io/badge/arXiv-2507.02798-b31b1b)](https://arxiv.org/abs/2507.02798)

**Stan techniki (Papers with Code)**

[**_1-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-1-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference)

[**_10-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-10-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference)

[**_30-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-30-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference)

</div>

---

> 🔔 **Aktualizacja (lipiec 2025):** Kod został zaktualizowany wraz z instrukcjami!

---

## 📋 Spis treści

- [🎯 Najważniejsze cechy](#-najwazniejsze-cechy)
- [📜 Abstrakt](#-abstrakt)
- [🧠 Architektura](#-architektura)
- [🛠️ Instrukcje instalacji](#️-instrukcje-instalacji)
  - [1. Sklonuj repozytorium](#1-sklonuj-repozytorium)
  - [2. Utwórz środowisko conda](#2-utworz-srodowisko-conda)
  - [3. Zainstaluj SAM2 i DinoV2](#3-zainstaluj-sam2-i-dinov2)
  - [4. Pobierz zbiory danych](#4-pobierz-zbiory-danych)
  - [5. Pobierz checkpointy SAM2 i DinoV2](#5-pobierz-checkpointy-sam2-i-dinov2)
- [📊 Kod inferencji: Odwzoruj wyniki SOTA 30-shot na Few-shot COCO](#-kod-inferencji)
  - [0. Utwórz zbiór referencyjny](#0-utworz-zbior-referencyjny)
  - [1. Wypełnij pamięć referencjami](#1-wypelnij-pamiec-referencjami)
  - [2. Przetwarzanie końcowe banku pamięci](#2-przetwarzanie-koncowe-banku-pamieci)
  - [3. Inferencja na obrazach docelowych](#3-inferencja-na-obrazach-docelowych)
  - [Wyniki](#wyniki)
- [🔍 Cytowanie](#-cytowanie)


## 🎯 Najważniejsze cechy
- 💡 **Bez treningu**: Bez fine-tuningu, bez inżynierii promptów—tylko obraz referencyjny.  
- 🖼️ **Na podstawie referencji**: Segmentuj nowe obiekty używając tylko kilku przykładów.  
- 🔥 **Wydajność SOTA**: Przewyższa wcześniejsze podejścia beztreningowe na COCO, PASCAL VOC i Cross-Domain FSOD.

**Linki:**
- 🧾 [**Artykuł arXiv**](https://arxiv.org/abs/2507.02798)  
- 🌐 [**Strona projektu**](https://miquel-espinosa.github.io/no-time-to-train/)  
- 📈 [**Papers with Code**](https://paperswithcode.com/paper/no-time-to-train-training-free-reference)

## 📜 Abstrakt

> Wydajność modeli segmentacji obrazów była historycznie ograniczona przez wysokie koszty zbierania dużych, oznakowanych zbiorów danych. Segment Anything Model (SAM) łagodzi ten pierwotny problem poprzez promptowalny, niepowiązany z semantyką paradygmat segmentacji, lecz nadal wymaga ręcznych promptów wizualnych lub złożonych, zależnych od domeny reguł generowania promptów do przetwarzania nowego obrazu. W celu ograniczenia tego nowego obciążenia, nasza praca bada zadanie segmentacji obiektów, gdy zamiast tego dostępny jest jedynie mały zbiór obrazów referencyjnych. Naszym kluczowym spostrzeżeniem jest wykorzystanie silnych semantycznych priors, wyuczonych przez modele bazowe, do identyfikacji odpowiadających sobie regionów pomiędzy obrazem referencyjnym a docelowym. Odkrywamy, że te korespondencje umożliwiają automatyczne generowanie masek segmentacyjnych na poziomie instancji do zadań downstream i realizujemy nasze pomysły poprzez wieloetapową, beztreningową metodę obejmującą (1) budowę banku pamięci; (2) agregację reprezentacji oraz (3) semantycznie świadome dopasowanie cech. Nasze eksperymenty pokazują znaczące ulepszenia na miarach segmentacji, prowadząc do wyników na poziomie SOTA na COCO FSOD (36.8% nAP), PASCAL VOC Few-Shot (71.2% nAP50) i przewyższając istniejące podejścia beztreningowe na benchmarku Cross-Domain FSOD (22.4% nAP).

![cdfsod-results-final-comic-sans-min](https://github.com/user-attachments/assets/ab302c02-c080-4042-99fc-0e181ba8abb9)


## 🧠 Architektura

![training-free-architecture-comic-sans-min](https://github.com/user-attachments/assets/d84dd83a-505e-45a0-8ce3-98e1838017f9)


## 🛠️ Instrukcje instalacji

### 1. Sklonuj repozytorium


```bash
git clone https://github.com/miquel-espinosa/no-time-to-train.git
cd no-time-to-train
```
### 2. Utwórz środowisko conda

Utworzymy środowisko conda z wymaganymi pakietami.

```bash
conda env create -f environment.yml
conda activate no-time-to-train
```
### 3. Zainstaluj SAM2 i DinoV2

Zainstalujemy SAM2 i DinoV2 ze źródeł.

```bash
pip install -e .
cd dinov2
pip install -e .
cd ..
```
### 4. Pobierz zestawy danych

Proszę pobrać zestaw danych COCO i umieścić go w `data/coco`

### 5. Pobierz checkpointy SAM2 i DinoV2

Pobierzemy dokładnie te same checkpointy SAM2, które zostały użyte w artykule.
(Zauważ jednak, że checkpointy SAM2.1 są już dostępne i mogą działać lepiej.)


```bash
mkdir -p checkpoints/dinov2
cd checkpoints
wget https://dl.fbaipublicfiles.com/segment_anything_2/072824/sam2_hiera_large.pt
cd dinov2
wget https://dl.fbaipublicfiles.com/dinov2/dinov2_vitl14/dinov2_vitl14_pretrain.pth
cd ../..
```
## 📊 Kod inferencji

⚠️ Zastrzeżenie: To jest kod badawczy — spodziewaj się trochę chaosu!

### Reprodukowanie wyników SOTA z 30 próbkami w Few-shot COCO

Zdefiniuj przydatne zmienne i utwórz folder na wyniki:



```bash
CONFIG=./dev_hongyi/new_exps/coco_fewshot_10shot_Sam2L.yaml
CLASS_SPLIT="few_shot_classes"
RESULTS_DIR=work_dirs/few_shot_results
SHOTS=30
SEED=33
GPUS=4

mkdir -p $RESULTS_DIR
FILENAME=few_shot_${SHOTS}shot_seed${SEED}.pkl
```
#### 0. Utwórz zestaw referencyjny


```bash
python dev_hongyi/dataset/few_shot_sampling.py \
        --n-shot $SHOTS \
        --out-path ${RESULTS_DIR}/${FILENAME} \
        --seed $SEED \
        --dataset $CLASS_SPLIT
```
#### 1. Wypełnij pamięć odniesieniami


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
#### 2. Post-process pamięci podręcznej


```bash
python run_lightening.py test --config $CONFIG \
                              --model.test_mode postprocess_memory \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --ckpt_path ${RESULTS_DIR}/memory.ckpt \
                              --out_path ${RESULTS_DIR}/memory_postprocessed.ckpt \
                              --trainer.devices 1
```
#### 3. Wnioskowanie na obrazach docelowych


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
Jeśli chcesz zobaczyć wyniki wnioskowania online (w miarę ich obliczania), odkomentuj linie 1746-1749 w pliku `dev_hongyi/models/Sam2MatchingBaseline_noAMG.py` [tutaj](https://github.com/miquel-espinosa/no-time-to-train/blob/main/dev_hongyi/models/Sam2MatchingBaseline_noAMG.py#L1746).
Dostosuj parametr progu punktacji `score_thr` w razie potrzeby, aby zobaczyć więcej lub mniej wysegmentowanych obiektów.
Obrazy zostaną teraz zapisane w `results_analysis/few_shot_classes/`. Obraz po lewej pokazuje prawdziwe oznaczenia (ground truth), obraz po prawej pokazuje wysegmentowane obiekty wykryte przez naszą metodę niewymagającą treningu.

Zwróć uwagę, że w tym przykładzie używamy podziału `few_shot_classes`, zatem powinniśmy spodziewać się wyłącznie wysegmentowanych obiektów należących do tych klas (nie wszystkich klas z COCO).

#### Wyniki

Po przetworzeniu wszystkich obrazów z zestawu walidacyjnego powinieneś uzyskać:


```
BBOX RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.368

SEGM RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.342
```
---


## 🔍 Citation

If you use this work, please cite us:

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---