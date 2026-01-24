
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Mapperatorinator

Teste das generative Modell [hier](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb), oder MaiMod [hier](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb). Sieh dir eine Video-Demo [hier](https://youtu.be/FEr7t1L2EoA) an.

Mapperatorinator ist ein Multi-Model-Framework, das Spektrogramme als Eingabe nutzt, um voll ausgestattete osu!-Beatmaps für alle Spielmodi zu generieren und [beim Modden von Beatmaps zu unterstützen](#maimod-the-ai-driven-modding-tool).
Das Ziel dieses Projekts ist es, automatisch osu!-Beatmaps in rankbarer Qualität aus jedem beliebigen Song mit einem hohen Maß an Anpassbarkeit zu erstellen.

Dieses Projekt basiert auf [osuT5](https://github.com/gyataro/osuT5) und [osu-diffusion](https://github.com/OliBomby/osu-diffusion). Für die Entwicklung habe ich etwa 2500 Stunden GPU-Rechenzeit in 142 Durchläufen auf meiner 4060 Ti und gemieteten 4090-Instanzen auf vast.ai investiert.

#### Verwenden Sie dieses Tool verantwortungsbewusst. Geben Sie immer die Nutzung von KI in Ihren Beatmaps an.

## Installation

Die folgende Anleitung ermöglicht es Ihnen, Beatmaps auf Ihrem lokalen Rechner zu erstellen. Alternativ können Sie das Tool in der Cloud mit dem [Colab-Notebook](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb) ausführen.

### 1. Klonen Sie das Repository

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. (Optional) Virtuelle Umgebung erstellen

Verwenden Sie Python 3.10, spätere Versionen sind möglicherweise nicht mit den Abhängigkeiten kompatibel.

```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```

### 3. Abhängigkeiten installieren

- Python 3.10
- [Git](https://git-scm.com/downloads)
- [ffmpeg](http://www.ffmpeg.org/)
- [CUDA](https://developer.nvidia.com/cuda-zone) (Für NVIDIA-GPUs) oder [ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html) (Für AMD-GPUs unter Linux)
- [PyTorch](https://pytorch.org/get-started/locally/): Achten Sie darauf, dem Get Started-Guide zu folgen, damit Sie `torch` und `torchaudio` mit GPU-Unterstützung installieren. Wählen Sie die richtige Compute Platform-Version, die Sie im vorherigen Schritt installiert haben.

- und die restlichen Python-Abhängigkeiten:

```sh
pip install -r requirements.txt
```

## Web-GUI (Empfohlen)

Für eine benutzerfreundlichere Erfahrung empfiehlt sich die Nutzung der Web-Oberfläche. Sie bietet eine grafische Oberfläche zum Konfigurieren der Generierungsparameter, Starten des Prozesses und Überwachen der Ausgabe.

### Starten der GUI

Navigieren Sie im Terminal zum geklonten Verzeichnis `Mapperatorinator` und führen Sie aus:

```sh
python web-ui.py
```
Dadurch wird ein lokaler Webserver gestartet und die Benutzeroberfläche automatisch in einem neuen Fenster geöffnet.

### Verwendung der GUI

- **Konfigurieren:** Legen Sie Eingabe-/Ausgabepfade über die Formularfelder und „Durchsuchen“-Schaltflächen fest. Passen Sie Generierungsparameter wie Spielmodus, Schwierigkeitsgrad, Stil (Jahr, Mapper-ID, Deskriptoren), Timing, spezifische Features (Hitsounds, Super Timing) und mehr an, analog zu den Kommandozeilenoptionen. (Hinweis: Wenn Sie einen `beatmap_path` angeben, ermittelt die UI automatisch den `audio_path` und `output_path`, sodass Sie diese Felder leer lassen können)
- **Starten:** Klicken Sie auf die Schaltfläche „Inference starten“, um die Beatmap-Generierung zu beginnen.
- **Abbrechen:** Sie können den laufenden Prozess mit der Schaltfläche „Inference abbrechen“ stoppen.
- **Ausgabe öffnen:** Nach Abschluss können Sie mit der Schaltfläche „Ausgabeordner öffnen“ schnell auf die generierten Dateien zugreifen.

Die Web-UI dient als komfortable Hülle für das Skript `inference.py`. Für erweiterte Optionen oder zur Fehlerbehebung beachten Sie bitte die Kommandozeilenanweisungen.

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## Kommandozeilen-Inferenz

Für Nutzer, die die Kommandozeile bevorzugen oder Zugriff auf erweiterte Konfigurationen benötigen, folgen Sie den untenstehenden Schritten. **Hinweis:** Für eine einfachere grafische Oberfläche siehe bitte den Abschnitt [Web-UI (Empfohlen)](#web-ui-recommended) oben.

Führen Sie `inference.py` aus und übergeben Sie einige Argumente, um Beatmaps zu generieren. Verwenden Sie dazu die [Hydra-Override-Syntax](https://hydra.cc/docs/advanced/override_grammar/basic/). Alle verfügbaren Parameter finden Sie in `configs/inference_v29.yaml`.

```
python inference.py \
  audio_path           [Path to input audio] \
  output_path          [Path to output directory] \
  beatmap_path         [Path to .osu file to autofill metadata, and output_path, or use as reference] \
  
  gamemode             [Game mode to generate 0=std, 1=taiko, 2=ctb, 3=mania] \
  difficulty           [Difficulty star rating to generate] \
  mapper_id            [Mapper user ID for style] \
  year                 [Upload year to simulate] \
  hitsounded           [Whether to add hitsounds] \
  slider_multiplier    [Slider velocity multiplier] \
  circle_size          [Circle size] \
  keycount             [Key count for mania] \
  hold_note_ratio      [Hold note ratio for mania 0-1] \
  scroll_speed_ratio   [Scroll speed ratio for mania and ctb 0-1] \
  descriptors          [List of beatmap user tags for style] \
  negative_descriptors [List of beatmap user tags for classifier-free guidance] \
  
  add_to_beatmap       [Whether to add generated content to the reference beatmap instead of making a new beatmap] \
  start_time           [Generation start time in milliseconds] \
  end_time             [Generation end time in milliseconds] \
  in_context           [List of additional context to provide to the model [NONE,TIMING,KIAI,MAP,GD,NO_HS]] \
  output_type          [List of content types to generate] \
  cfg_scale            [Scale of the classifier-free guidance] \
  super_timing         [Whether to use slow accurate variable BPM timing generator] \
  seed                 [Random seed for generation] \
```

Beispiel:
```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## Interaktive CLI
Für diejenigen, die einen terminalbasierten Workflow bevorzugen, aber eine geführte Einrichtung wünschen, ist das interaktive CLI-Skript eine ausgezeichnete Alternative zur Web-Oberfläche.

### Starten der CLI
Navigieren Sie zum geklonten Verzeichnis. Möglicherweise müssen Sie das Skript zuerst ausführbar machen.

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```

### Verwendung der CLI
Das Skript führt Sie durch eine Reihe von Eingabeaufforderungen, um alle Generierungsparameter zu konfigurieren, genau wie die Web-Oberfläche.

Es verwendet eine farbcodierte Oberfläche für bessere Übersichtlichkeit.
Es stellt ein erweitertes Multi-Select-Menü bereit, um Stil-Deskriptoren mit den Pfeiltasten und der Leertaste auszuwählen.
Nachdem Sie alle Fragen beantwortet haben, zeigt es den endgültigen Befehl zur Überprüfung an.
Sie können dann bestätigen, um ihn direkt auszuführen, oder abbrechen und den Befehl für die manuelle Verwendung kopieren.

## Tipps zur Generierung

- Sie können `configs/inference_v29.yaml` bearbeiten und Ihre Argumente dort eintragen, anstatt sie jedes Mal im Terminal einzugeben.
- Alle verfügbaren Deskriptoren finden Sie [hier](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags).
- Geben Sie immer ein Jahr zwischen 2007 und 2023 an. Wenn Sie dies offen lassen, kann das Modell mit uneinheitlichem Stil generieren.
- Geben Sie immer einen Schwierigkeitsgrad an. Wenn Sie dies offen lassen, kann das Modell mit uneinheitlicher Schwierigkeit generieren.
- Erhöhen Sie den Parameter `cfg_scale`, um die Wirksamkeit der Argumente `mapper_id` und `descriptors` zu steigern.
- Sie können das Argument `negative_descriptors` verwenden, um das Modell von bestimmten Stilen abzulenken. Dies funktioniert nur, wenn `cfg_scale > 1`. Achten Sie darauf, dass die Anzahl der negativen Deskriptoren der der Deskriptoren entspricht.
- Wenn sich der Songstil und der gewünschte Beatmap-Stil nicht gut ergänzen, hält sich das Modell möglicherweise nicht an Ihre Vorgaben. Zum Beispiel ist es schwer, für ein ruhiges Lied eine Beatmap mit hohem SR und hohem SV zu generieren.
- Wenn Sie bereits Timing- und Kiai-Zeiten für ein Lied haben, können Sie diese dem Modell geben, um die Inferenzgeschwindigkeit und Genauigkeit stark zu erhöhen: Verwenden Sie die Argumente `beatmap_path` und `in_context=[TIMING,KIAI]`.
- Um nur einen Teil Ihrer Beatmap neu zu gestalten, verwenden Sie die Argumente `beatmap_path`, `start_time`, `end_time` und `add_to_beatmap=true`.
- Um eine Gast-Schwierigkeit für eine Beatmap zu generieren, verwenden Sie die Argumente `beatmap_path` und `in_context=[GD,TIMING,KIAI]`.
- Um Hitsounds für eine Beatmap zu generieren, verwenden Sie die Argumente `beatmap_path` und `in_context=[NO_HS,TIMING,KIAI]`.
- Um nur das Timing für ein Lied zu generieren, verwenden Sie die Argumente `super_timing=true` und `output_type=[TIMING]`.

## MaiMod: Das KI-gestützte Modding-Tool

MaiMod ist ein Modding-Tool für osu!-Beatmaps, das Mapperatorinator-Vorhersagen verwendet, um potenzielle Fehler und Inkonsistenzen zu finden, die von anderen automatischen Modding-Tools wie [Mapset Verifier](https://github.com/Naxesss/MapsetVerifier) nicht erkannt werden können.
Es kann Probleme wie folgende erkennen:
- Falsches Snapping oder rhythmische Muster
- Ungenaue Timing-Punkte
- Inkonsistente Hit-Objekt-Positionen oder neue Combo-Platzierungen
- Seltsame Slider-Formen
- Inkonsistente Hitsounds oder Lautstärken

Sie können MaiMod [hier](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb) ausprobieren oder lokal ausführen:
Um MaiMod lokal auszuführen, müssen Sie Mapperatorinator installieren. Führen Sie dann das Skript `mai_mod.py` aus und geben Sie den Pfad zu Ihrer Beatmap mit dem Argument `beatmap_path` an.
```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
Dadurch werden die Modding-Vorschläge in der Konsole ausgegeben, die du dann manuell auf deine Beatmap anwenden kannst.
Die Vorschläge sind chronologisch geordnet und in Kategorien gruppiert.
Der erste Wert im Kreis zeigt die „Überraschung“ an, ein Maß dafür, wie unerwartet das Modell das Problem fand, sodass du die wichtigsten Probleme priorisieren kannst.

Das Modell kann Fehler machen, besonders bei Problemen mit niedriger Überraschung, daher solltest du die Vorschläge immer überprüfen, bevor du sie auf deine Beatmap anwendest.
Das Hauptziel ist, dir zu helfen, den Suchraum für potenzielle Probleme einzugrenzen, sodass du nicht jedes einzelne Hit-Objekt deiner Beatmap manuell prüfen musst.

### MaiMod GUI
Um die MaiMod Web-Oberfläche auszuführen, musst du Mapperatorinator installieren.
Danach starte das Skript `mai_mod_ui.py`. Dadurch wird ein lokaler Webserver gestartet und die Oberfläche automatisch in einem neuen Fenster geöffnet:

```sh
python mai_mod_ui.py
```

<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## Übersicht

### Tokenisierung

Mapperatorinator konvertiert osu!-Beatmaps in eine Zwischenrepräsentation von Ereignissen, die direkt in Tokens umgewandelt werden kann und umgekehrt.
Sie umfasst Hit-Objekte, Hitsounds, Slider-Geschwindigkeiten, neue Combos, Timing-Punkte, Kiai-Zeiten sowie Taiko/Mania-Scroll-Geschwindigkeiten.

Hier ist ein kleines Beispiel des Tokenisierungsprozesses:

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

Um den Vokabularumfang zu reduzieren, werden Zeitereignisse auf 10ms-Intervalle quantisiert und Positionskoordinaten auf ein 32-Pixel-Raster.

### Modellarchitektur
Das Modell ist im Wesentlichen ein Wrapper um das [HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration)-Modell mit eigenen Eingabe-Embeddings und Loss-Funktion.
Die Modellgröße beträgt 219 Mio. Parameter.
Für diese Aufgabe erwies sich dieses Modell als schneller und genauer als T5.

Die Übersicht des Modells auf hoher Ebene sieht wie folgt aus:

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

Das Modell verwendet Mel-Spektrogramm-Frames als Encoder-Eingabe, mit einem Frame pro Eingabeposition. Die Decoder-Ausgabe des Modells ist bei jedem Schritt eine Softmax-Verteilung über einen diskreten, vordefinierten Ereignis-Wortschatz. Die Ausgaben sind spärlich, Ereignisse werden nur dann benötigt, wenn ein Hit-Objekt auftritt, anstatt jeden einzelnen Audioframe zu annotieren.

### Multitasking-Trainingsformat

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

Vor dem SOS-Token befinden sich zusätzliche Tokens, die die bedingte Generierung erleichtern. Diese Tokens umfassen den Spielmodus, Schwierigkeitsgrad, Mapper-ID, Jahr und weitere Metadaten.
Während des Trainings haben diese Tokens keine zugehörigen Labels und werden daher nie vom Modell ausgegeben.
Außerdem besteht während des Trainings eine zufällige Chance, dass ein Metadaten-Token durch ein „Unbekannt“-Token ersetzt wird, sodass wir diese „Unbekannt“-Tokens zur Inferenz nutzen können, um den Umfang der an das Modell zu übergebenden Metadaten zu reduzieren.

### Nahtlose lange Generierung

Die Kontextlänge des Modells beträgt 8,192 Sekunden. Das reicht offensichtlich nicht aus, um eine vollständige Beatmap zu erzeugen, daher müssen wir das Lied in mehrere Fenster aufteilen und die Beatmap in kleinen Teilen generieren.
Um sicherzustellen, dass die generierte Beatmap keine auffälligen Nähte zwischen den Fenstern aufweist, verwenden wir eine 90%ige Überlappung und generieren die Fenster nacheinander.
Jedes Generierungsfenster außer dem ersten beginnt mit einem Decoder, der bis zu 50% des Fensters mit Tokens aus den vorherigen Fenstern vorbefüllt ist.
Wir verwenden einen Logit-Prozessor, um sicherzustellen, dass das Modell keine Zeit-Token generieren kann, die im ersten 50 % des Generierungsfensters liegen.
Zusätzlich sind die letzten 40 % des Generierungsfensters für das nächste Fenster reserviert. Alle generierten Zeit-Token in diesem Bereich werden als EOS-Token behandelt.
Dies stellt sicher, dass jedes generierte Token auf mindestens 4 Sekunden vorheriger Token und 3,3 Sekunden zukünftiger Audiodaten zum Antizipieren basiert.

Um ein Offset-Driften während langer Generierung zu verhindern, wurden während des Trainings zufällige Offsets zu den Zeitereignissen im Decoder hinzugefügt.
Dadurch wird das Modell gezwungen, Timing-Fehler zu korrigieren, indem es stattdessen auf die Onsets im Audio hört, was zu einem durchgehend genauen Offset führt.

### Verfeinerte Koordinaten mit Diffusion

Vom Decoder generierte Positionskoordinaten werden auf 32-Pixel-Gitterpunkte quantisiert, daher verwenden wir anschließend Diffusion, um die Koordinaten auf die endgültigen Positionen zu entrauschen.
Dafür haben wir eine modifizierte Version von [osu-diffusion](https://github.com/OliBomby/osu-diffusion) trainiert, die speziell auf die letzten 10 % des Rauschplans spezialisiert ist und die fortschrittlicheren Metadaten-Token akzeptiert, die Mapperatorinator für die bedingte Generierung verwendet.

Da das Mapperatorinator-Modell die SV von Slidern ausgibt, ist die erforderliche Länge des Sliders unabhängig von der Form des Kontrollpunktpfads festgelegt.
Daher versuchen wir, den Diffusionsprozess so zu lenken, dass Koordinaten entstehen, die zu den erforderlichen Slider-Längen passen.
Dies erreichen wir, indem wir nach jedem Schritt des Diffusionsprozesses die Slider-Endpositionen basierend auf der erforderlichen Länge und dem aktuellen Kontrollpunktpfad neu berechnen.
Das bedeutet, dass der Diffusionsprozess keinen direkten Einfluss auf die Slider-Endpositionen hat, diese aber durch Änderung des Kontrollpunktpfads beeinflussen kann.

### Nachbearbeitung

Mapperatorinator führt zusätzliche Nachbearbeitung durch, um die Qualität der generierten Beatmap zu verbessern:

- Verfeinerung der Positionskoordinaten mit Diffusion.
- Zeitereignisse an das nächste Tick mithilfe der vom Modell generierten Snap-Divisoren snappen.
- Fast perfekte Positionsüberlagerungen snappen.
- Mania-Spaltenereignisse in X-Koordinaten umwandeln.
- Sliderpfade für Taiko-Drumrolls generieren.
- Große Diskrepanzen zwischen erforderlicher Sliderlänge und Länge des Kontrollpunktpfads beheben.

### Super Timing Generator

Der Super Timing Generator ist ein Algorithmus, der die Präzision und Genauigkeit der generierten Zeitwerte verbessert, indem er die Zeitwerte für das gesamte Lied 20-mal ermittelt und die Ergebnisse mittelt.
Dies ist nützlich für Lieder mit variablem BPM oder BPM-Wechseln. Das Ergebnis ist fast perfekt, nur gelegentlich muss ein Abschnitt manuell angepasst werden.

## Training

Die folgende Anleitung erstellt eine Trainingsumgebung auf Ihrem lokalen Rechner.

### 1. Klonen Sie das Repository

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. Datensatz erstellen

Erstellen Sie Ihren eigenen Datensatz mit der [Mapperator-Konsolenanwendung](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset). Dafür wird ein [osu! OAuth-Client-Token](https://osu.ppy.sh/home/account/edit) benötigt, um Beatmaps zu verifizieren und zusätzliche Metadaten abzurufen. Legen Sie den Datensatz in einem `datasets`-Verzeichnis neben dem `Mapperatorinator`-Verzeichnis ab.

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3. (Optional) Einrichtung von Weight & Biases zum Logging
Erstellen Sie ein Konto bei [Weight & Biases](https://wandb.ai/site) und holen Sie sich Ihren API-Schlüssel aus den Kontoeinstellungen.
Setzen Sie dann die Umgebungsvariable `WANDB_API_KEY`, damit der Trainingsprozess weiß, dass zu diesem Schlüssel geloggt werden soll.

```sh
export WANDB_API_KEY=<your_api_key>
```

### 4. Docker-Container erstellen
Das Training in Ihrer venv ist ebenfalls möglich, aber wir empfehlen die Verwendung von Docker unter WSL für eine bessere Leistung.
```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. Parameter konfigurieren und Training starten

Alle Konfigurationen befinden sich in `./configs/train/default.yaml`.
Stellen Sie sicher, dass Sie den korrekten `train_dataset_path` und `test_dataset_path` zu Ihrem Datensatz sowie die Start- und End-Mapset-Indizes für die Train/Test-Aufteilung festlegen.
Der Pfad ist lokal zum Docker-Container, also wenn Sie Ihren Datensatz namens `cool_dataset` in das Verzeichnis `datasets` gelegt haben, sollte er `/workspace/datasets/cool_dataset` lauten.

Ich empfehle, eine eigene Konfigurationsdatei zu erstellen, die die Standardkonfiguration überschreibt, damit Sie eine Aufzeichnung Ihrer Trainingskonfiguration für die Reproduzierbarkeit haben.

```yaml
data:
  train_dataset_path: "/workspace/datasets/cool_dataset"
  test_dataset_path: "/workspace/datasets/cool_dataset"
  train_dataset_start: 0
  train_dataset_end: 90
  test_dataset_start: 90
  test_dataset_end: 100
```

Begin training by calling `python osuT5/train.py` or `torchrun --nproc_per_node=NUM_GPUS osuT5/train.py` for multi-GPU training.


```sh
python osuT5/train.py -cn train_v29 train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

### 6. LoRA-Feinabstimmung

Sie können auch ein vortrainiertes Modell mit [LoRA](https://arxiv.org/abs/2106.09685) feinabstimmen, um es an einen bestimmten Stil oder Spielmodus anzupassen.
Passen Sie dazu `configs/train/lora.yaml` an Ihre Anforderungen an und führen Sie die `lora`-Trainingskonfiguration aus:

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

Wichtige LoRA-Parameter, die zu berücksichtigen sind:
- `pretrained_path`: Pfad oder HF-Repository des Basismodells zum Fine-Tuning.
- `r`: Rang der LoRA-Matrizen. Höhere Werte erhöhen die Modellkapazität, aber auch den Speicherverbrauch.
- `lora_alpha`: Skalierungsfaktor für die LoRA-Updates.
- `total_steps`: Gesamtanzahl der Trainingsschritte. Stimmen Sie dies auf die Größe Ihres Datensatzes ab.
- `enable_lora`: Ob LoRA oder vollständiges Modell-Fine-Tuning verwendet wird.

Während der Inferenz können Sie die zu verwendenden LoRA-Gewichte mit dem Argument `lora_path` angeben.
Dies kann ein lokaler Pfad oder ein Hugging Face-Repository sein.

## Siehe auch
- [Mapper Classifier](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## Danksagungen

Besonderer Dank an:
1. Die Autoren von [osuT5](https://github.com/gyataro/osuT5) für ihren Trainingscode.
2. Das Hugging Face-Team für ihre [Tools](https://huggingface.co/docs/transformers/index).
3. [Jason Won](https://github.com/jaswon) und [Richard Nagyfi](https://github.com/sedthh) für das Austauschen von Ideen.
4. [Marvin](https://github.com/minetoblend) für das Spenden von Trainings-Credits.
5. Die osu!-Community für die Beatmaps.

## Verwandte Arbeiten

1. [osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator) von Syps (Nick Sypteras)
2. [osumapper](https://github.com/kotritrona/osumapper) von kotritrona, jyvden, Yoyolick (Ryan Zmuda)
3. [osu-diffusion](https://github.com/OliBomby/osu-diffusion) von OliBomby (Olivier Schipper), NiceAesth (Andrei Baciu)
4. [osuT5](https://github.com/gyataro/osuT5) von gyataro (Xiwen Teoh)
5. [Beat Learning](https://github.com/sedthh/BeatLearning) von sedthh (Richard Nagyfi)
6. [osu!dreamer](https://github.com/jaswon/osu-dreamer) von jaswon (Jason Won)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---