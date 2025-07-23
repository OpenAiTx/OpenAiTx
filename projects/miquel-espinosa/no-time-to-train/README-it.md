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
### Segmentazione di istanze basata su riferimento senza addestramento  
[![GitHub](https://img.shields.io/badge/%E2%80%8B-No%20Time%20To%20Train-black?logo=github)](https://github.com/miquel-espinosa/no-time-to-train)
[![Website](https://img.shields.io/badge/🌐-Project%20Page-grey)](https://miquel-espinosa.github.io/no-time-to-train/)
[![arXiv](https://img.shields.io/badge/arXiv-2507.02798-b31b1b)](https://arxiv.org/abs/2507.02798)

**Stato dell’arte (Papers with Code)**

[**_SOTA 1-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-1-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference)

[**_SOTA 10-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-10-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference)

[**_SOTA 30-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-30-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference)

</div>

---

> 🚨 **Aggiornamento (22 luglio 2025):** Aggiunte istruzioni per dataset personalizzati!
> 
> 🔔 **Aggiornamento (16 luglio 2025):** Il codice è stato aggiornato con le istruzioni!

---

## 📋 Indice

- [🎯 Punti salienti](#-highlights)
- [📜 Abstract](#-abstract)
- [🧠 Architettura](#-architecture)
- [🛠️ Istruzioni di installazione](#️-installation-instructions)
  - [1. Clonare il repository](#1-clone-the-repository)
  - [2. Creare un ambiente conda](#2-create-conda-environment)
  - [3. Installare SAM2 e DinoV2](#3-install-sam2-and-dinov2)
  - [4. Scaricare i dataset](#4-download-datasets)
  - [5. Scaricare i checkpoint di SAM2 e DinoV2](#5-download-sam2-and-dinov2-checkpoints)
- [📊 Codice di inferenza: Riproduci risultati SOTA 30-shot in Few-shot COCO](#-inference-code)
  - [0. Crea set di riferimento](#0-create-reference-set)
  - [1. Riempire la memoria con i riferimenti](#1-fill-memory-with-references)
  - [2. Post-elaborazione della banca di memoria](#2-post-process-memory-bank)
  - [3. Inferenza sulle immagini target](#3-inference-on-target-images)
  - [Risultati](#results)
- [🔍 Dataset personalizzato](#-custom-dataset)
  - [0. Prepara un dataset personalizzato ⛵🐦](#0-prepare-a-custom-dataset)
  - [0.1 Se sono disponibili solo annotazioni bbox](#01-if-only-bbox-annotations-are-available)
  - [0.2 Converti le annotazioni coco in file pickle](#02-convert-coco-annotations-to-pickle-file)
  - [1. Riempire la memoria con i riferimenti](#1-fill-memory-with-references)
  - [2. Post-elaborazione della banca di memoria](#2-post-process-memory-bank)
- [📚 Citazione](#-citation)


## 🎯 Punti salienti
- 💡 **Senza addestramento**: Nessun fine-tuning, nessun prompt engineering—solo un’immagine di riferimento.  
- 🖼️ **Basato su riferimento**: Segmenta nuovi oggetti usando solo pochi esempi.  
- 🔥 **Prestazioni SOTA**: Supera i precedenti approcci senza addestramento su COCO, PASCAL VOC e Cross-Domain FSOD.

**Link:**
- 🧾 [**Articolo arXiv**](https://arxiv.org/abs/2507.02798)  
- 🌐 [**Sito del progetto**](https://miquel-espinosa.github.io/no-time-to-train/)  
- 📈 [**Papers with Code**](https://paperswithcode.com/paper/no-time-to-train-training-free-reference)

## 📜 Abstract

> Le prestazioni dei modelli di segmentazione delle immagini sono state storicamente limitate dall’alto costo della raccolta di dati annotati su larga scala. Il Segment Anything Model (SAM) allevia questo problema originale tramite un paradigma di segmentazione promptabile e semanticamente agnostico, ma richiede ancora prompt visivi manuali o regole complesse di generazione prompt dipendenti dal dominio per elaborare una nuova immagine. Per ridurre questo nuovo onere, il nostro lavoro indaga il compito della segmentazione di oggetti fornendo, in alternativa, solo un piccolo set di immagini di riferimento. La nostra intuizione chiave è sfruttare forti priors semantici, appresi dai foundation model, per identificare le regioni corrispondenti tra un’immagine di riferimento e una target. Abbiamo scoperto che le corrispondenze permettono la generazione automatica di maschere di segmentazione a livello di istanza per task a valle, e concretizziamo le nostre idee tramite un metodo multistadio, senza addestramento, che incorpora (1) costruzione di una banca di memoria; (2) aggregazione delle rappresentazioni e (3) feature matching semanticamente consapevole. I nostri esperimenti mostrano notevoli miglioramenti nelle metriche di segmentazione, portando a prestazioni state-of-the-art su COCO FSOD (36,8% nAP), PASCAL VOC Few-Shot (71,2% nAP50) e superando gli approcci esistenti senza addestramento nel benchmark Cross-Domain FSOD (22,4% nAP).

![cdfsod-results-final-comic-sans-min](https://github.com/user-attachments/assets/ab302c02-c080-4042-99fc-0e181ba8abb9)

</translate-content>

## 🧠 Architettura

![training-free-architecture-comic-sans-min](https://github.com/user-attachments/assets/d84dd83a-505e-45a0-8ce3-98e1838017f9)


## 🛠️ Istruzioni di installazione

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
CONFIG=./no_time_to_train/new_exps/coco_fewshot_10shot_Sam2L.yaml
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
python no_time_to_train/dataset/few_shot_sampling.py \
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
Se desideri vedere i risultati dell'inferenza online (man mano che vengono calcolati), decommenta le righe 1746-1749 in `no_time_to_train/models/Sam2MatchingBaseline_noAMG.py` [qui](https://github.com/miquel-espinosa/no-time-to-train/blob/main/no_time_to_train/models/Sam2MatchingBaseline_noAMG.py#L1746).
Regola il parametro della soglia del punteggio `score_thr` secondo necessità per visualizzare più o meno istanze segmentate.
Le immagini verranno ora salvate in `results_analysis/few_shot_classes/`. L'immagine a sinistra mostra la ground truth, l'immagine a destra mostra le istanze segmentate trovate dal nostro metodo senza training.

Nota che in questo esempio stiamo usando la suddivisione `few_shot_classes`, quindi dovremmo aspettarci di vedere solo istanze segmentate delle classi in questa suddivisione (non tutte le classi in COCO).

#### Risultati

Dopo aver elaborato tutte le immagini nel set di validazione, dovresti ottenere:


```
BBOX RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.368

SEGM RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.342
```
---

## 🔍 Dataset personalizzato

Forniamo le istruzioni per eseguire la nostra pipeline su un dataset personalizzato. Il formato delle annotazioni è sempre in formato COCO.

> **TLDR;** Per vedere direttamente come eseguire la pipeline completa su *dataset personalizzati*, consulta `scripts/matching_cdfsod_pipeline.sh` insieme agli script di esempio dei dataset CD-FSOD (ad es. `scripts/dior_fish.sh`)

### 0. Prepara un dataset personalizzato ⛵🐦

Immaginiamo di voler rilevare **barche**⛵ e **uccelli**🐦 in un dataset personalizzato. Per utilizzare il nostro metodo avremo bisogno di:
- Almeno 1 immagine di riferimento *annotata* per ogni classe (cioè 1 immagine di riferimento per barca e 1 per uccello)
- Più immagini target in cui trovare le istanze delle classi desiderate.

Abbiamo preparato uno script di esempio per creare un dataset personalizzato con immagini COCO, per un'impostazione **1-shot**.
```bash
python scripts/make_custom_dataset.py
```
Questo creerà un dataset personalizzato con la seguente struttura di cartelle:
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
**Visualizzazione delle immagini di riferimento (1-shot):**

| Immagine di riferimento 1-shot per UCCELLO 🐦 | Immagine di riferimento 1-shot per BARCA ⛵ |
|:--------------------------------------------:|:-------------------------------------------:|
| <img src="https://github.com/user-attachments/assets/e59e580d-a7db-42ac-b386-892af211fc85" alt="bird_1" width="500"/> | <img src="https://github.com/user-attachments/assets/f94ee025-ae37-4a45-9c3e-0cfe8f8cd2bc" alt="boat_1" width="500"/> |


### 0.1 Se sono disponibili solo annotazioni bbox

Forniamo anche uno script per generare maschere di segmentazione a livello di istanza utilizzando SAM2. Questo è utile se sono disponibili solo annotazioni di bounding box per le immagini di riferimento.


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
**Immagini di riferimento con maschere di segmentazione a livello di istanza (generate da SAM2 dai riquadri gt, 1-shot):**

La visualizzazione delle maschere di segmentazione generate è salvata in `data/my_custom_dataset/annotations/custom_references_with_SAM_segm/references_visualisations/`.


| Immagine di riferimento 1-shot per UCCELLO 🐦 (segmentata automaticamente con SAM) | Immagine di riferimento 1-shot per BARCA ⛵ (segmentata automaticamente con SAM) |
|:---------------------------------:|:----------------------------------:|
| <img src="https://github.com/user-attachments/assets/65d38dc4-1454-43cd-9600-e8efc67b3a82" alt="bird_1_with_SAM_segm" width="500"/> | <img src="https://github.com/user-attachments/assets/43a558ad-50ca-4715-8285-9aa3268843c6" alt="boat_1_with_SAM_segm" width="500"/> |


### 0.2 Convertire annotazioni coco in file pickle


```bash
python no_time_to_train/dataset/coco_to_pkl.py \
    data/my_custom_dataset/annotations/custom_references_with_segm.json \
    data/my_custom_dataset/annotations/custom_references_with_segm.pkl \
    1
```
### 1. Riempire la memoria con riferimenti

Per prima cosa, definire le variabili utili e creare una cartella per i risultati. Per una corretta visualizzazione delle etichette, i nomi delle classi devono essere ordinati in base all'id della categoria come appare nel file json. Ad esempio, `bird` ha id categoria `16`, `boat` ha id categoria `9`. Quindi, `CAT_NAMES=boat,bird`.


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
Esegui il passaggio 1:

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
### 2. Post-elaborazione della memoria di banco


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
### 3. Inferenza sulle immagini di destinazione

Se `ONLINE_VIS` è impostato su True, i risultati delle predizioni verranno salvati in `results_analysis/my_custom_dataset/` e visualizzati man mano che vengono calcolati. NOTA che l'esecuzione con la visualizzazione online è molto più lenta.

Sentiti libero di modificare la soglia di punteggio `VIS_THR` per visualizzare più o meno istanze segmentate.

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
### Risultati

Le metriche di prestazione (con gli stessi parametri esatti dei comandi sopra) dovrebbero essere:


```
BBOX RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.478

SEGM RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.458
```
I risultati visivi sono salvati in `results_analysis/my_custom_dataset/`. Nota che il nostro metodo funziona per i falsi negativi, cioè immagini che non contengono istanze delle classi desiderate.

*Clicca sulle immagini per ingrandirle ⬇️*

| Immagine target con barche ⛵ (sinistra GT, destra predizioni) | Immagine target con uccelli 🐦 (sinistra GT, destra predizioni) |
|:----------------------:|:----------------------:|
| ![000000459673](https://github.com/user-attachments/assets/678dc15a-dd3b-49d5-9287-6290da16aa6b) | ![000000407180](https://github.com/user-attachments/assets/fe306e48-af49-4d83-ac82-76fac6c456d1) |

| Immagine target con barche e uccelli ⛵🐦 (sinistra GT, destra predizioni) | Immagine target senza barche né uccelli 🚫 (sinistra GT, destra predizioni) |
|:---------------------------------:|:----------------------------------:|
| ![000000517410](https://github.com/user-attachments/assets/9849b227-7f43-43d7-81ea-58010a623ad5) | ![000000460598](https://github.com/user-attachments/assets/7587700c-e09d-4cf6-8590-3df129c2568e) |


## 📚 Citazione

Se utilizzi questo lavoro, per favore citaci:


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