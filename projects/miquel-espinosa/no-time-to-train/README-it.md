<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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
### Segmentazione di istanze basata su riferimenti senza addestramento  
[![GitHub](https://img.shields.io/badge/%E2%80%8B-No%20Time%20To%20Train-black?logo=github)](https://github.com/miquel-espinosa/no-time-to-train)
[![Website](https://img.shields.io/badge/🌐-Project%20Page-grey)](https://miquel-espinosa.github.io/no-time-to-train/)
[![arXiv](https://img.shields.io/badge/arXiv-2507.02798-b31b1b)](https://arxiv.org/abs/2507.02798)

**Stato dell'arte (Papers with Code)**

[**_1-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-1-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference)

[**_10-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-10-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference)

[**_30-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-30-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference)

</div>

---

> 🔔 **Aggiornamento (luglio 2025):** Il codice è stato aggiornato con le istruzioni!

---

## 📋 Indice

- [🎯 Punti salienti](#-highlights)
- [📜 Abstract](#-abstract)
- [🧠 Architettura](#-architecture)
- [🛠️ Istruzioni per l'installazione](#️-installation-instructions)
  - [1. Clona il repository](#1-clone-the-repository)
  - [2. Crea l'ambiente conda](#2-create-conda-environment)
  - [3. Installa SAM2 e DinoV2](#3-install-sam2-and-dinov2)
  - [4. Scarica i dataset](#4-download-datasets)
  - [5. Scarica i checkpoint di SAM2 e DinoV2](#5-download-sam2-and-dinov2-checkpoints)
- [📊 Codice di inferenza: Riproduci i risultati SOTA 30-shot su Few-shot COCO](#-inference-code)
  - [0. Crea set di riferimento](#0-create-reference-set)
  - [1. Riempi la memoria con i riferimenti](#1-fill-memory-with-references)
  - [2. Post-processa la memory bank](#2-post-process-memory-bank)
  - [3. Inferenza sulle immagini target](#3-inference-on-target-images)
  - [Risultati](#results)
- [🔍 Citazione](#-citation)


## 🎯 Punti salienti
- 💡 **Senza Addestramento**: Nessun fine-tuning, nessun prompt engineering—solo un'immagine di riferimento.  
- 🖼️ **Basato su riferimento**: Segmenta nuovi oggetti usando solo pochi esempi.  
- 🔥 **Prestazioni SOTA**: Supera i precedenti approcci senza addestramento su COCO, PASCAL VOC e Cross-Domain FSOD.

**Link:**
- 🧾 [**Articolo su arXiv**](https://arxiv.org/abs/2507.02798)  
- 🌐 [**Sito del progetto**](https://miquel-espinosa.github.io/no-time-to-train/)  
- 📈 [**Papers with Code**](https://paperswithcode.com/paper/no-time-to-train-training-free-reference)

## 📜 Abstract

> Le prestazioni dei modelli di segmentazione delle immagini sono state storicamente limitate dall'alto costo della raccolta di dati annotati su larga scala. Il Segment Anything Model (SAM) allevia questo problema originale attraverso un paradigma di segmentazione promptabile e semanticamente agnostico, ma richiede comunque prompt visivi manuali o regole complesse di generazione dei prompt dipendenti dal dominio per elaborare una nuova immagine. Per ridurre questo nuovo onere, il nostro lavoro indaga il compito della segmentazione degli oggetti quando si dispone, in alternativa, solo di un piccolo set di immagini di riferimento. La nostra intuizione chiave è sfruttare forti prior semantici, appresi dai foundation model, per identificare le regioni corrispondenti tra un'immagine di riferimento e una immagine target. Abbiamo scoperto che le corrispondenze consentono la generazione automatica di maschere di segmentazione a livello di istanza per task downstream e implementiamo le nostre idee tramite un metodo multi-stadio, senza addestramento, che incorpora (1) costruzione della memory bank; (2) aggregazione delle rappresentazioni e (3) matching delle feature consapevole del significato semantico. I nostri esperimenti mostrano miglioramenti significativi sulle metriche di segmentazione, portando a prestazioni allo stato dell'arte su COCO FSOD (36,8% nAP), PASCAL VOC Few-Shot (71,2% nAP50) e superando gli approcci esistenti senza addestramento sul benchmark Cross-Domain FSOD (22,4% nAP).

![cdfsod-results-final-comic-sans-min](https://github.com/user-attachments/assets/ab302c02-c080-4042-99fc-0e181ba8abb9)


## 🧠 Architettura

![training-free-architecture-comic-sans-min](https://github.com/user-attachments/assets/d84dd83a-505e-45a0-8ce3-98e1838017f9)


## 🛠️ Istruzioni per l'installazione

### 1. Clona il repository


```bash
git clone https://github.com/miquel-espinosa/no-time-to-train.git
cd no-time-to-train
```
### 2. Crea l'ambiente conda

Creeremo un ambiente conda con i pacchetti necessari.

```bash
conda env create -f environment.yml
conda activate no-time-to-train
```
### 3. Installa SAM2 e DinoV2

Installeremo SAM2 e DinoV2 dal sorgente.

```bash
pip install -e .
cd dinov2
pip install -e .
cd ..
```
### 4. Scarica i dataset

Per favore scarica il dataset COCO e posizionalo in `data/coco`

### 5. Scarica i checkpoint di SAM2 e DinoV2

Scaricheremo gli stessi checkpoint SAM2 utilizzati nell'articolo.
(Tieni presente, tuttavia, che i checkpoint SAM2.1 sono già disponibili e potrebbero offrire prestazioni migliori.)


```bash
mkdir -p checkpoints/dinov2
cd checkpoints
wget https://dl.fbaipublicfiles.com/segment_anything_2/072824/sam2_hiera_large.pt
cd dinov2
wget https://dl.fbaipublicfiles.com/dinov2/dinov2_vitl14/dinov2_vitl14_pretrain.pth
cd ../..
```
## 📊 Codice di inferenza

⚠️ Disclaimer: Questo è codice di ricerca — aspettatevi un po' di caos!

### Riproduzione dei risultati SOTA a 30-shot su Few-shot COCO

Definire variabili utili e creare una cartella per i risultati:



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
#### 0. Crea set di riferimento


```bash
python dev_hongyi/dataset/few_shot_sampling.py \
        --n-shot $SHOTS \
        --out-path ${RESULTS_DIR}/${FILENAME} \
        --seed $SEED \
        --dataset $CLASS_SPLIT
```
#### 1. Riempire la memoria con riferimenti


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
#### 2. Post-elaborazione della memoria di banco


```bash
python run_lightening.py test --config $CONFIG \
                              --model.test_mode postprocess_memory \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --ckpt_path ${RESULTS_DIR}/memory.ckpt \
                              --out_path ${RESULTS_DIR}/memory_postprocessed.ckpt \
                              --trainer.devices 1
```
#### 3. Inferenza sulle immagini di destinazione


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
Se desideri vedere i risultati dell'inferenza online (man mano che vengono calcolati), decommenta le righe 1746-1749 in `dev_hongyi/models/Sam2MatchingBaseline_noAMG.py` [qui](https://github.com/miquel-espinosa/no-time-to-train/blob/main/dev_hongyi/models/Sam2MatchingBaseline_noAMG.py#L1746).
Regola il parametro `score_thr` della soglia di punteggio secondo necessità per visualizzare più o meno istanze segmentate.
Le immagini verranno ora salvate in `results_analysis/few_shot_classes/`. L'immagine a sinistra mostra la ground truth, mentre quella a destra mostra le istanze segmentate trovate dal nostro metodo senza training.

Nota che in questo esempio stiamo usando la suddivisione `few_shot_classes`, quindi dovremmo aspettarci di vedere solo le istanze segmentate delle classi in questa suddivisione (non tutte le classi in COCO).

#### Risultati

Dopo aver elaborato tutte le immagini nel set di validazione, dovresti ottenere:


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