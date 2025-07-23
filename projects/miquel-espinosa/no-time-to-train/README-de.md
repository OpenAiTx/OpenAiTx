<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

# 🚀 Keine Zeit zum Trainieren!  
### Trainingsfreie, referenzbasierte Instanzsegmentierung  
[![GitHub](https://img.shields.io/badge/%E2%80%8B-No%20Time%20To%20Train-black?logo=github)](https://github.com/miquel-espinosa/no-time-to-train)
[![Website](https://img.shields.io/badge/🌐-Project%20Page-grey)](https://miquel-espinosa.github.io/no-time-to-train/)
[![arXiv](https://img.shields.io/badge/arXiv-2507.02798-b31b1b)](https://arxiv.org/abs/2507.02798)

**Stand der Technik (Papers with Code)**

[**_SOTA 1-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-1-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference)

[**_SOTA 10-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-10-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference)

[**_SOTA 30-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-30-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference)

</div>

---

> 🚨 **Update (22. Juli 2025):** Anweisungen für benutzerdefinierte Datensätze wurden hinzugefügt!
> 
> 🔔 **Update (16. Juli 2025):** Code wurde mit Anweisungen aktualisiert!

---

## 📋 Inhaltsverzeichnis

- [🎯 Highlights](#-highlights)
- [📜 Zusammenfassung](#-abstract)
- [🧠 Architektur](#-architecture)
- [🛠️ Installationsanleitung](#️-installation-instructions)
  - [1. Repository klonen](#1-clone-the-repository)
  - [2. Conda-Umgebung erstellen](#2-create-conda-environment)
  - [3. SAM2 und DinoV2 installieren](#3-install-sam2-and-dinov2)
  - [4. Datensätze herunterladen](#4-download-datasets)
  - [5. SAM2- und DinoV2-Checkpoints herunterladen](#5-download-sam2-and-dinov2-checkpoints)
- [📊 Inferenzcode: 30-shot SOTA-Ergebnisse in Few-shot COCO reproduzieren](#-inference-code)
  - [0. Referenzset erstellen](#0-create-reference-set)
  - [1. Speicher mit Referenzen füllen](#1-fill-memory-with-references)
  - [2. Speicherbank nachbearbeiten](#2-post-process-memory-bank)
  - [3. Inferenz auf Zielbildern](#3-inference-on-target-images)
  - [Ergebnisse](#results)
- [🔍 Benutzerdefinierter Datensatz](#-custom-dataset)
  - [0. Benutzerdefinierten Datensatz vorbereiten ⛵🐦](#0-prepare-a-custom-dataset)
  - [0.1 Falls nur Bbox-Anmerkungen verfügbar sind](#01-if-only-bbox-annotations-are-available)
  - [0.2 COCO-Anmerkungen in Pickle-Datei umwandeln](#02-convert-coco-annotations-to-pickle-file)
  - [1. Speicher mit Referenzen füllen](#1-fill-memory-with-references)
  - [2. Speicherbank nachbearbeiten](#2-post-process-memory-bank)
- [📚 Zitation](#-citation)


## 🎯 Highlights
- 💡 **Trainingsfrei**: Kein Feintuning, kein Prompt-Engineering—nur ein Referenzbild.  
- 🖼️ **Referenzbasiert**: Segmentiere neue Objekte mit nur wenigen Beispielen.  
- 🔥 **SOTA-Leistung**: Übertrifft bisherige trainingsfreie Ansätze auf COCO, PASCAL VOC und Cross-Domain FSOD.

**Links:**
- 🧾 [**arXiv Paper**](https://arxiv.org/abs/2507.02798)  
- 🌐 [**Projekt-Webseite**](https://miquel-espinosa.github.io/no-time-to-train/)  
- 📈 [**Papers with Code**](https://paperswithcode.com/paper/no-time-to-train-training-free-reference)

## 📜 Zusammenfassung

> Die Leistung von Bildsegmentierungsmodellen war historisch durch die hohen Kosten der Erhebung groß angelegter, annotierter Daten begrenzt. Das Segment Anything Model (SAM) entschärft dieses ursprüngliche Problem durch ein prompt-basiertes, semantikagnostisches Segmentierungsparadigma, erfordert aber weiterhin manuelle visuelle Prompts oder komplexe, domänenspezifische Prompt-Generierungsregeln, um ein neues Bild zu verarbeiten. Um diese neue Hürde zu reduzieren, untersucht unsere Arbeit die Aufgabe der Objeksegmentierung, wenn stattdessen nur eine kleine Menge an Referenzbildern zur Verfügung steht. Unser zentraler Ansatz ist die Nutzung starker semantischer Vorannahmen, wie sie von Foundation Models gelernt werden, um entsprechende Regionen zwischen Referenz- und Zielbild zu identifizieren. Wir stellen fest, dass diese Korrespondenzen die automatische Generierung von segmentierungsbezogenen Masken für nachgelagerte Aufgaben ermöglichen und setzen unsere Ideen in einer mehrstufigen, trainingsfreien Methode um, die (1) den Aufbau einer Speicherbank, (2) Repräsentationsaggregation und (3) semantisch-bewusste Merkmalszuordnung beinhaltet. Unsere Experimente zeigen signifikante Verbesserungen bei Segmentierungsmetriken und führen zu einer SOTA-Leistung auf COCO FSOD (36,8% nAP), PASCAL VOC Few-Shot (71,2% nAP50) und einer Überlegenheit gegenüber bestehenden trainingsfreien Ansätzen im Cross-Domain FSOD Benchmark (22,4% nAP).

![cdfsod-results-final-comic-sans-min](https://github.com/user-attachments/assets/ab302c02-c080-4042-99fc-0e181ba8abb9)




## 🧠 Architektur

![training-free-architecture-comic-sans-min](https://github.com/user-attachments/assets/d84dd83a-505e-45a0-8ce3-98e1838017f9)


## 🛠️ Installationsanleitung

### 1. Klonen Sie das Repository

```bash
git clone https://github.com/miquel-espinosa/no-time-to-train.git
cd no-time-to-train
```
### 2. Conda-Umgebung erstellen

Wir werden eine Conda-Umgebung mit den benötigten Paketen erstellen.

```bash
conda env create -f environment.yml
conda activate no-time-to-train
```
### 3. Installieren Sie SAM2 und DinoV2

Wir werden SAM2 und DinoV2 aus dem Quellcode installieren.

```bash
pip install -e .
cd dinov2
pip install -e .
cd ..
```
### 4. Datensätze herunterladen

Bitte laden Sie den COCO-Datensatz herunter und platzieren Sie ihn in `data/coco`

### 5. SAM2- und DinoV2-Checkpoints herunterladen

Wir werden die exakt im Paper verwendeten SAM2-Checkpoints herunterladen.
(Beachten Sie jedoch, dass SAM2.1-Checkpoints bereits verfügbar sind und möglicherweise bessere Ergebnisse liefern.)


```bash
mkdir -p checkpoints/dinov2
cd checkpoints
wget https://dl.fbaipublicfiles.com/segment_anything_2/072824/sam2_hiera_large.pt
cd dinov2
wget https://dl.fbaipublicfiles.com/dinov2/dinov2_vitl14/dinov2_vitl14_pretrain.pth
cd ../..
```
## 📊 Inferenzcode

⚠️ Haftungsausschluss: Dies ist Forschungscode – erwarten Sie ein wenig Chaos!

### Reproduktion der 30-shot SOTA-Ergebnisse bei Few-shot COCO

Definieren Sie nützliche Variablen und erstellen Sie einen Ordner für die Ergebnisse:



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
#### 0. Referenzsatz erstellen


```bash
python no_time_to_train/dataset/few_shot_sampling.py \
        --n-shot $SHOTS \
        --out-path ${RESULTS_DIR}/${FILENAME} \
        --seed $SEED \
        --dataset $CLASS_SPLIT
```
#### 1. Speicher mit Referenzen füllen


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
#### 2. Nachbearbeitung des Speicherbanks


```bash
python run_lightening.py test --config $CONFIG \
                              --model.test_mode postprocess_memory \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --ckpt_path ${RESULTS_DIR}/memory.ckpt \
                              --out_path ${RESULTS_DIR}/memory_postprocessed.ckpt \
                              --trainer.devices 1
```
#### 3. Inferenz auf Zielbildern


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
Wenn Sie die Inferenz-Ergebnisse online sehen möchten (während sie berechnet werden), heben Sie die Auskommentierung der Zeilen 1746-1749 in `no_time_to_train/models/Sam2MatchingBaseline_noAMG.py` [hier](https://github.com/miquel-espinosa/no-time-to-train/blob/main/no_time_to_train/models/Sam2MatchingBaseline_noAMG.py#L1746) auf.
Passen Sie den Schwellenwertparameter `score_thr` nach Bedarf an, um mehr oder weniger segmentierte Instanzen zu sehen.
Bilder werden jetzt in `results_analysis/few_shot_classes/` gespeichert. Das Bild links zeigt die Ground Truth, das Bild rechts die segmentierten Instanzen, die von unserer trainingsfreien Methode gefunden wurden.

Beachten Sie, dass wir in diesem Beispiel den Split `few_shot_classes` verwenden. Daher sollten wir nur segmentierte Instanzen der Klassen aus diesem Split erwarten (nicht alle Klassen in COCO).

#### Ergebnisse

Nachdem alle Bilder im Validierungsdatensatz verarbeitet wurden, sollten Sie Folgendes erhalten:


```
BBOX RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.368

SEGM RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.342
```
---

## 🔍 Benutzerdefiniertes Datenset

Wir stellen Anleitungen zur Verfügung, wie Sie unsere Pipeline mit einem benutzerdefinierten Datenset ausführen können. Das Annotationsformat ist immer im COCO-Format.

> **TLDR;** Um direkt zu sehen, wie die vollständige Pipeline auf *benutzerdefinierten Datensätzen* ausgeführt wird, schauen Sie in `scripts/matching_cdfsod_pipeline.sh` zusammen mit Beispielskripten der CD-FSOD-Datensätze (z.B. `scripts/dior_fish.sh`)

### 0. Vorbereitung eines benutzerdefinierten Datensets ⛵🐦

Angenommen, wir möchten **Boote**⛵ und **Vögel**🐦 in einem benutzerdefinierten Datenset erkennen. Um unsere Methode zu verwenden, benötigen wir:
- Mindestens 1 *annotiertes* Referenzbild pro Klasse (d.h. 1 Referenzbild für Boot und 1 Referenzbild für Vogel)
- Mehrere Zielbilder, um Instanzen unserer gewünschten Klassen zu finden.

Wir haben ein Beispielskript vorbereitet, um mit COCO-Bildern ein benutzerdefiniertes Datenset für ein **1-Shot**-Setting zu erstellen.
```bash
python scripts/make_custom_dataset.py
```
Dadurch wird ein benutzerdefiniertes Dataset mit der folgenden Ordnerstruktur erstellt:
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
**Referenzbild-Visualisierung (1-shot):**

| 1-shot Referenzbild für VOGEL 🐦 | 1-shot Referenzbild für BOOT ⛵ |
|:-------------------------------:|:-------------------------------:|
| <img src="https://github.com/user-attachments/assets/e59e580d-a7db-42ac-b386-892af211fc85" alt="bird_1" width="500"/> | <img src="https://github.com/user-attachments/assets/f94ee025-ae37-4a45-9c3e-0cfe8f8cd2bc" alt="boat_1" width="500"/> |


### 0.1 Falls nur Bbox-Anmerkungen verfügbar sind

Wir stellen auch ein Skript bereit, um instanzbasierte Segmentierungsmasken mit SAM2 zu generieren. Dies ist nützlich, wenn Sie für die Referenzbilder nur Bounding-Box-Anmerkungen zur Verfügung haben.


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
**Referenzbilder mit Instanz-Segmentierungsmasken (generiert von SAM2 aus gt-Bounding-Boxen, 1-shot):**

Visualisierung der generierten Segmentierungsmasken sind gespeichert in `data/my_custom_dataset/annotations/custom_references_with_SAM_segm/references_visualisations/`.


| 1-shot Referenzbild für VOGEL 🐦 (automatisch segmentiert mit SAM) | 1-shot Referenzbild für BOOT ⛵ (automatisch segmentiert mit SAM) |
|:---------------------------------:|:----------------------------------:|
| <img src="https://github.com/user-attachments/assets/65d38dc4-1454-43cd-9600-e8efc67b3a82" alt="bird_1_with_SAM_segm" width="500"/> | <img src="https://github.com/user-attachments/assets/43a558ad-50ca-4715-8285-9aa3268843c6" alt="boat_1_with_SAM_segm" width="500"/> |


### 0.2 Konvertiere coco-Annotationen in eine Pickle-Datei


```bash
python no_time_to_train/dataset/coco_to_pkl.py \
    data/my_custom_dataset/annotations/custom_references_with_segm.json \
    data/my_custom_dataset/annotations/custom_references_with_segm.pkl \
    1
```
### 1. Speicher mit Referenzen füllen

Definieren Sie zunächst nützliche Variablen und erstellen Sie einen Ordner für die Ergebnisse. Für die korrekte Visualisierung der Labels sollten die Klassennamen nach der Kategorie-ID sortiert werden, wie sie in der JSON-Datei erscheint. Zum Beispiel hat `bird` die Kategorie-ID `16`, `boat` hat die Kategorie-ID `9`. Daher gilt: `CAT_NAMES=boat,bird`.


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
Führen Sie Schritt 1 aus:

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
### 2. Nachbearbeitungsspeicherbank


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
### 3. Inferenz auf Zielbildern

Wenn `ONLINE_VIS` auf True gesetzt ist, werden die Vorhersageergebnisse in `results_analysis/my_custom_dataset/` gespeichert und angezeigt, sobald sie berechnet werden. BEACHTEN SIE, dass die Ausführung mit Online-Visualisierung deutlich langsamer ist.

Sie können den Score-Schwellenwert `VIS_THR` beliebig ändern, um mehr oder weniger segmentierte Instanzen anzuzeigen.

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
### Ergebnisse

Leistungskennzahlen (mit genau denselben Parametern wie bei den obigen Befehlen) sollten wie folgt sein:


```
BBOX RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.478

SEGM RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.458
```
Visuelle Ergebnisse werden in `results_analysis/my_custom_dataset/` gespeichert. Beachten Sie, dass unsere Methode auch bei Falsch-Negativen funktioniert, also bei Bildern, die keine Instanzen der gewünschten Klassen enthalten.

*Klicken Sie auf die Bilder, um sie zu vergrößern ⬇️*

| Zielbild mit Booten ⛵ (links GT, rechts Vorhersagen) | Zielbild mit Vögeln 🐦 (links GT, rechts Vorhersagen) |
|:----------------------:|:----------------------:|
| ![000000459673](https://github.com/user-attachments/assets/678dc15a-dd3b-49d5-9287-6290da16aa6b) | ![000000407180](https://github.com/user-attachments/assets/fe306e48-af49-4d83-ac82-76fac6c456d1) |

| Zielbild mit Booten und Vögeln ⛵🐦 (links GT, rechts Vorhersagen) | Zielbild ohne Boote oder Vögel 🚫 (links GT, rechts Vorhersagen) |
|:---------------------------------:|:----------------------------------:|
| ![000000517410](https://github.com/user-attachments/assets/9849b227-7f43-43d7-81ea-58010a623ad5) | ![000000460598](https://github.com/user-attachments/assets/7587700c-e09d-4cf6-8590-3df129c2568e) |


## 📚 Zitation

Wenn Sie diese Arbeit verwenden, zitieren Sie uns bitte:


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