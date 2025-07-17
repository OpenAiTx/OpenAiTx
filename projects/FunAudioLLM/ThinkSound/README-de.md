<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>

<p align="center">
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  Wenn Sie dieses Projekt nützlich finden,<br>
  würden wir uns sehr über einen Stern ⭐ auf GitHub freuen!
</p>

---

**ThinkSound** ist ein einheitliches Any2Audio-Generierungs-Framework mit Flow Matching, geleitet durch Chain-of-Thought (CoT)-Schlussfolgerungen.

PyTorch-Implementierung für multimodale Audiogenerierung und -bearbeitung: Generieren oder Bearbeiten von Audio aus Video, Text und Audio, unterstützt durch schrittweise Schlussfolgerungen von Multimodalen Large Language Models (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Neuigkeiten
- **2025.07.17** &nbsp; 🧠 Finetuning aktiviert: Trainings- und Finetuning-Code ist jetzt öffentlich verfügbar, zusammen mit klaren Anweisungen, wie Sie ThinkSound mit Ihren eigenen Daten anpassen und erweitern können.
- **2025.07.15** &nbsp; 📦 Vereinfachte Installation und Benutzerfreundlichkeit: Abhängigkeiten auf PyPI für einfache plattformübergreifende Einrichtung; Windows-`.bat`-Skripte automatisieren die Umgebungs-Erstellung und das Ausführen von Skripten.
- **2025.07.08** &nbsp;  🔧 Großes Update: Modell verschlankt und Speicher- sowie GPU-Nutzung optimiert, unterstützt nun hochskalierbare Audiogenerierung!
- **2025.07.01** &nbsp; 🔥Online-Demo auf [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) und [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) für interaktive Erfahrungen!
- **2025.07.01** &nbsp; 🔥Veröffentlichte Inferenz-Skripte und Web-Oberfläche;
- **2025.06** &nbsp; 🔥[ThinkSound-Paper](https://arxiv.org/pdf/2506.21448) auf arXiv veröffentlicht!
- **2025.06** &nbsp; 🔥[Online Demo](http://thinksound-project.github.io/) ist online – jetzt ausprobieren!

---


## 🚀 Funktionen

- **Any2Audio**: Generiere Audio aus beliebigen Modalitäten – Video, Text, Audio oder deren Kombinationen.
- **Video-zu-Audio SOTA**: Erreicht State-of-the-Art-Ergebnisse auf mehreren V2A-Benchmarks.
- **CoT-gesteuerte Schlussfolgerungen**: Chain-of-Thought-Reasoning für kompositorische und kontrollierbare Audiogenerierung mittels MLLMs.
- **Interaktives, objektzentriertes Bearbeiten**: Verfeinere oder bearbeite spezifische Klangereignisse durch Klicks auf visuelle Objekte oder mit Textanweisungen.
- **Einheitliches Framework**: Ein Foundation Model unterstützt Generierung, Bearbeitung und interaktiven Workflow.

---

## ✨ Methodische Übersicht

ThinkSound unterteilt die Audiogenerierung und -bearbeitung in drei interaktive Phasen, alle geführt durch MLLM-basiertes Chain-of-Thought (CoT)-Reasoning:

1. **Foley-Generierung:** Erzeuge grundlegende, semantisch und zeitlich ausgerichtete Klanglandschaften aus Videos.
2. **Objektzentrierte Verfeinerung:** Verfeinere oder füge Klänge für vom Nutzer ausgewählte Objekte über Klicks oder Bereiche im Video hinzu.
3. **Gezielte Audiobearbeitung:** Modifiziere generiertes Audio mittels hochrangiger natürlicher Sprachbefehle.

![ThinkSound Übersicht](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Ein groß angelegter, CoT-annotierter Datensatz (**AudioCoT**) wird verwendet, um sowohl das Reasoning-Modul als auch das einheitliche Audio-Foundation-Model zu trainieren.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Schnellstart

**Umgebungsvorbereitung:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **Windows-Tipp:**  
> Windows-Benutzer können einfach `setup_windows.bat` ausführen (oder doppelt anklicken), um automatisch die Conda-Umgebung zu erstellen, alle Abhängigkeiten zu installieren (einschließlich FFmpeg) und das vortrainierte Modell herunterzuladen — keine manuelle Einrichtung erforderlich.  
> Stellen Sie sicher, dass `conda` und `git` installiert sind und sich in Ihrem System-PATH befinden, bevor Sie das Skript ausführen.


### ▶️ Demo ausführen

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

Stattdessen können Sie das bereitgestellte `.bat`-Skript verwenden:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**Hinweis:**

* `<path-to-your-demo-video>`: Der Pfad zu einem einzelnen Video
* `[use-half]` (optional): Fügen Sie use-half am Ende hinzu, um die Extraktion von Merkmalen mit halber Genauigkeit zu aktivieren.

---

### 📦 Stapel-Inferenz

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

Verwenden Sie das entsprechende `.bat`-Skript:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**Hinweis:**

* `<video_path>`: Pfad zum Stammverzeichnis, das alle zu verarbeitenden .mp4-Videos enthält (alle Videos müssen die gleiche Dauer haben).
* `<csv_path>`: Eine CSV-Datei mit Text-Inputs für jedes Video (siehe `demo_test.csv` für das Format).
* `<save_path>` (optional): Speicherort für die generierte Audiodatei. Standardmäßig `results/features`.
* `[use-half]` (optional): Fügen Sie use-half am Ende hinzu, um die Halbpräzisions-Feature-Extraktion zu aktivieren.

---


### Nutzung der Weboberfläche

Für eine interaktive Erfahrung starten Sie die Gradio-Weboberfläche:


```bash
python app.py
```
## 🏋️ Trainiere das Modell

Siehe [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 TODO & Zukünftige Pläne
* - [ ] Open-Source AudioCoT-Datensatz und automatisierte Pipeline (Erwartet vor dem 23.07.2025)
* - [ ] Veröffentlichung eines leistungsstärkeren Foundation-Modells, das mehrere Domänen abdeckt, um ein ansprechenderes und immersiveres Foley-Erlebnis zu bieten (Erwartet bis Ende August 2025)
* - [ ] Unterstützung für weitere Modalitäten und Downstream-Aufgaben hinzufügen (Erwartet vor Ende Juli 2025)
* - [ ] Veröffentlichung von Modellen in verschiedenen Größenordnungen (Erwartet vor Ende Juli 2025)
* - [x] Veröffentlichung von Trainingsskripten für ThinkSound-Modelle
* - [x] Ein einsteigerfreundliches Windows-Quickstart-README
---


## 📄 Lizenz

Dieses Projekt wird unter der Apache 2.0-Lizenz veröffentlicht.

> **Hinweis:**
> Der Code, die Modelle und der Datensatz sind **nur für Forschungs- und Bildungszwecke bestimmt**.
> **Kommerzielle Nutzung ist NICHT gestattet.**
> Für kommerzielle Lizenzen kontaktieren Sie bitte die Autoren.

**📦 Komponenten von Drittanbietern**

* **Stable Audio Open VAE** (von Stability AI):
  Dieses Repository enthält ein feinabgestimmtes VAE von [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), lizenziert unter der [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Kommerzielle Nutzung und Weiterverbreitung erfordern vorherige Genehmigung von Stability AI.**

* 📘 **Alle anderen Codes und Modelle** werden unter der Apache License 2.0 veröffentlicht.

---

## Danksagungen

Vielen Dank an:

* **stable-audio-tools** (von Stability AI):
Für die Bereitstellung eines benutzerfreundlichen Frameworks für die Audiogenerierung sowie das VAE-Modul und die Gewichte.
* **MMAudio**:
  Für die Implementierung des MM-DiT-Backbones im Audio-Bereich.

---

## 📖 Zitation

Wenn Sie ThinkSound in Ihrer Forschung oder Arbeit verwenden, zitieren Sie bitte unsere Publikation:



```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
```
---

## 📬 Kontakt

✨ Zögern Sie nicht, [ein Issue zu eröffnen](https://github.com/liuhuadai/ThinkSound/issues) oder uns per E-Mail ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) zu kontaktieren, wenn Sie Fragen oder Anregungen haben!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---