# Stable Diffusion Web-UI
Eine Web-Oberfläche für Stable Diffusion, implementiert mit der Gradio-Bibliothek.

![](screenshot.png)

## Funktionen
[Ausführliche Funktionsübersicht mit Bildern](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- Ursprüngliche txt2img- und img2img-Modi
- Ein-Klick-Installations- und Ausführungsskript (Python und Git müssen trotzdem installiert sein)
- Outpainting
- Inpainting
- Color Sketch
- Prompt Matrix
- Stable Diffusion Upscale
- Attention, bestimmte Textteile, auf die das Modell besonders achten soll, spezifizieren
    - a man in a `((tuxedo))` – Fokus liegt mehr auf Tuxedo
    - a man in a `(tuxedo:1.21)` – alternative Syntax
    - Text markieren und `Ctrl+Up` oder `Ctrl+Down` (bzw. `Command+Up` oder `Command+Down` unter MacOS) drücken, um die Aufmerksamkeit für ausgewählten Text automatisch anzupassen (Code von anonymem Nutzer beigesteuert)
- Loopback, mehrfache img2img-Verarbeitung in Serie
- X/Y/Z-Plot, eine Möglichkeit, ein 3D-Bild-Plot mit unterschiedlichen Parametern zu erstellen
- Textuelle Inversion
    - beliebig viele Embeddings mit frei wählbaren Namen verwenden
    - mehrere Embeddings mit unterschiedlicher Anzahl von Vektoren pro Token nutzen
    - funktioniert mit halbpräzisen Fließkommazahlen
    - Embeddings auf 8GB trainieren (auch Berichte, dass 6GB funktionieren)
- Extras-Tab mit:
    - GFPGAN, neuronales Netzwerk, das Gesichter repariert
    - CodeFormer, Gesichtsrestaurierung als Alternative zu GFPGAN
    - RealESRGAN, neuronaler Upscaler
    - ESRGAN, neuronaler Upscaler mit vielen Drittanbieter-Modellen
    - SwinIR und Swin2SR ([siehe hier](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), neuronale Upscaler
    - LDSR, Latent Diffusion Super Resolution Upscaling
- Optionen zur Anpassung des Seitenverhältnisses beim Skalieren
- Auswahl der Sampling-Methode
    - Anpassung der Sampler-Eta-Werte (Rauschmultiplier)
    - Erweiterte Einstellmöglichkeiten für das Rauschen
- Verarbeitung jederzeit abbrechen möglich
- 4GB-Grafikkarten-Unterstützung (auch Berichte, dass 2GB funktionieren)
- Korrekte Seeds für Batches
- Live-Validierung der Prompt-Token-Länge
- Generierungsparameter
     - Die zur Bilderzeugung verwendeten Parameter werden mit dem Bild gespeichert
     - In PNG-Chunks für PNG, in EXIF für JPEG
     - Bild in den PNG-Info-Tab ziehen, um Generierungsparameter wiederherzustellen und automatisch ins UI zu kopieren
     - Kann in den Einstellungen deaktiviert werden
     - Bild/Text-Parameter per Drag & Drop in das Prompt-Feld ziehen
- Button "Read Generation Parameters", lädt Parameter aus Promptbox ins UI
- Einstellungsseite
- Ausführen beliebigen Python-Codes aus dem UI (muss mit `--allow-code` gestartet werden)
- Mouseover-Hinweise für die meisten UI-Elemente
- Standard-/Min-/Max-/Step-Werte für UI-Elemente per Textkonfiguration änderbar
- Tiling-Unterstützung, Checkbox für kachelbare Bilder wie Texturen
- Fortschrittsbalken und Live-Vorschau der Bildgenerierung
    - Kann ein separates neuronales Netzwerk für Vorschauen mit minimalem VRAM- oder Rechenbedarf nutzen
- Negative Prompt, ein zusätzliches Textfeld, um Unerwünschtes im generierten Bild auszuschließen
- Styles, Möglichkeit, Teile von Prompts zu speichern und später per Dropdown anzuwenden
- Variationen, Möglichkeit, dasselbe Bild mit kleinen Unterschieden zu generieren
- Seed-Resizing, Möglichkeit, dasselbe Bild in leicht anderer Auflösung zu generieren
- CLIP-Interrogator, Button, der versucht, den Prompt aus einem Bild zu erraten
- Prompt Editing, Möglichkeit, den Prompt während der Generierung zu ändern, z.B. mit einer Wassermelone starten und auf Anime-Girl wechseln
- Batch Processing, Verarbeitung einer Dateigruppe per img2img
- Img2img Alternative, Reverse-Euler-Methode zur Cross-Attention-Steuerung
- Highres Fix, Komfort-Option, um hochauflösende Bilder auf Knopfdruck ohne übliche Verzerrungen zu erzeugen
- Checkpoints im laufenden Betrieb neu laden
- Checkpoint Merger, Tab zum Zusammenführen von bis zu 3 Checkpoints zu einem
- [Custom Scripts](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) mit vielen Erweiterungen aus der Community
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), Möglichkeit, mehrere Prompts gleichzeitig zu nutzen
     - Prompts durch Großbuchstaben `AND` trennen
     - Gewichte für Prompts möglich: `a cat :1.2 AND a dog AND a penguin :2.2`
- Kein Token-Limit für Prompts (Original Stable Diffusion erlaubt max. 75 Tokens)
- DeepDanbooru-Integration, erstellt Danbooru-Style-Tags für Anime-Prompts
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), erhebliche Geschwindigkeitssteigerung für ausgewählte Karten: (fügen Sie `--xformers` zu den Befehlszeilenargumenten hinzu)
- via Erweiterung: [History Tab](https://github.com/yfszzx/stable-diffusion-webui-images-browser): Bilder bequem im UI anzeigen, direkt nutzen und löschen
- "Generate Forever"-Option
- Trainings-Tab
     - Optionen für Hypernetworks und Embeddings
     - Vorverarbeitung von Bildern: Zuschneiden, Spiegeln, Autotagging mit BLIP oder DeepDanbooru (für Anime)
- Clip Skip
- Hypernetworks
- Loras (wie Hypernetworks, aber hübscher)
- Separate UI zur Auswahl, mit Vorschau, welche Embeddings, Hypernetworks oder Loras zum Prompt hinzugefügt werden sollen
- Auswahlmöglichkeit für anderes VAE aus dem Einstellungsbildschirm
- Geschätzte verbleibende Zeit im Fortschrittsbalken
- API
- Unterstützung für dediziertes [Inpainting-Modell](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) von RunwayML
- via Erweiterung: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), Bilder mit spezifischer Ästhetik mittels CLIP-Image-Embeds generieren ([Implementierung](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) Unterstützung – siehe [Wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) für Anweisungen
- [Alt-Diffusion](https://arxiv.org/abs/2211.06679) Unterstützung – siehe [Wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) für Anweisungen
- Jetzt ohne böse Buchstaben!
- Checkpoints im safetensors-Format laden
- Lockerere Auflösungsbeschränkung: Bilddimensionen müssen Vielfache von 8 statt 64 sein
- Jetzt mit Lizenz!
- Elemente im UI aus dem Einstellungsbildschirm umsortierbar
- [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B) Unterstützung

## Installation und Ausführung
Stellen Sie sicher, dass alle [Abhängigkeiten](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) erfüllt sind und folgen Sie der Anleitung für:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (empfohlen)
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPUs.
- [Intel CPUs, Intel GPUs (sowohl integriert als auch dediziert)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (externes Wiki)
- [Ascend NPUs](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (externes Wiki)

Alternativ können Sie Online-Dienste nutzen (wie Google Colab):

- [Liste der Online-Dienste](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Installation unter Windows 10/11 mit NVidia-GPUs mittels Release-Paket
1. Laden Sie `sd.webui.zip` von [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) herunter und entpacken Sie den Inhalt.
2. Führen Sie `update.bat` aus.
3. Führen Sie `run.bat` aus.
> Für weitere Details siehe [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Automatische Installation unter Windows
1. Installieren Sie [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (Neuere Python-Versionen unterstützen torch nicht). Aktivieren Sie "Add Python to PATH".
2. Installieren Sie [git](https://git-scm.com/download/win).
3. Laden Sie das Repository stable-diffusion-webui herunter, z.B. durch Ausführen von `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`.
4. Führen Sie `webui-user.bat` im Windows Explorer als normaler, nicht-administrativer Benutzer aus.

### Automatische Installation unter Linux
1. Installieren Sie die Abhängigkeiten:
```bash
# Debian-basiert:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Red Hat-basiert:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE-basiert:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch-basiert:
sudo pacman -S wget git python3
```
Falls Ihr System sehr neu ist, müssen Sie python3.11 oder python3.10 installieren:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # nicht mit python3.11 verwechseln

# Nur für 3.11
# Dann Umgebungsvariable im Startskript setzen
export python_cmd="python3.11"
# oder in webui-user.sh
python_cmd="python3.11"
```
2. Navigieren Sie in das gewünschte Installationsverzeichnis und führen Sie folgenden Befehl aus:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
Oder klonen Sie das Repo einfach an einen beliebigen Ort:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. Führen Sie `webui.sh` aus.
4. Überprüfen Sie `webui-user.sh` auf Optionen.

### Installation auf Apple Silicon

Die Anleitung finden Sie [hier](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon).

## Mitwirken
So können Sie Code zu diesem Repo beitragen: [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## Dokumentation

Die Dokumentation wurde aus dieser README in das [Wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki) des Projekts verschoben.

Damit Google und andere Suchmaschinen das Wiki crawlen, hier ein Link zum (nicht für Menschen gedachten) [crawlbaren Wiki](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki).

## Danksagungen
Lizenzen für genutzten Code finden Sie unter `Einstellungen -> Lizenzen` und in der Datei `html/licenses.html`.

- Stable Diffusion – https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion – https://github.com/crowsonkb/k-diffusion.git
- Spandrel – https://github.com/chaiNNer-org/spandrel, implementiert
  - GFPGAN – https://github.com/TencentARC/GFPGAN.git
  - CodeFormer – https://github.com/sczhou/CodeFormer
  - ESRGAN – https://github.com/xinntao/ESRGAN
  - SwinIR – https://github.com/JingyunLiang/SwinIR
  - Swin2SR – https://github.com/mv-lab/swin2sr
- LDSR – https://github.com/Hafiidz/latent-diffusion
- MiDaS – https://github.com/isl-org/MiDaS
- Ideen für Optimierungen – https://github.com/basujindal/stable-diffusion
- Cross Attention Layer Optimierung – Doggettx – https://github.com/Doggettx/stable-diffusion, Originalidee für Prompt Editing.
- Cross Attention Layer Optimierung – InvokeAI, lstein – https://github.com/invoke-ai/InvokeAI (ursprünglich http://github.com/lstein/stable-diffusion)
- Sub-quadratische Cross Attention Layer Optimierung – Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textuelle Inversion – Rinon Gal – https://github.com/rinongal/textual_inversion (wir nutzen nicht seinen Code, aber seine Ideen).
- Idee für SD Upscale – https://github.com/jquesnelle/txt2imghd
- Rauschgenerierung für Outpainting mk2 – https://github.com/parlance-zz/g-diffuser-bot
- CLIP Interrogator-Idee und Code-Übernahme – https://github.com/pharmapsychotic/clip-interrogator
- Idee für Composable Diffusion – https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers – https://github.com/facebookresearch/xformers
- DeepDanbooru – Interrogator für Anime-Diffuser https://github.com/KichangKim/DeepDanbooru
- Sampling in float32-Präzision von einem float16 UNet – marunine für die Idee, Birch-san für das Diffusers-Beispiel (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix – Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) – https://github.com/timothybrooks/instruct-pix2pix
- Sicherheitshinweise – RyotaK
- UniPC Sampler – Wenliang Zhao – https://github.com/wl-zhao/UniPC
- TAESD – Ollin Boer Bohan – https://github.com/madebyollin/taesd
- LyCORIS – KohakuBlueleaf
- Restart Sampling – lambertae – https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile – tfernd – https://github.com/tfernd/HyperTile
- Erstes Gradio-Skript – von einem anonymen Nutzer auf 4chan gepostet. Danke an den anonymen Nutzer.
- (Sie)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---