<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">Englisch</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Spanisch</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Französisch</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">Japanisch</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
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
    <img src="https://img.shields.io/badge/ModelScope-Online%20Erlebnis-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  Wenn Sie dieses Projekt nützlich finden,<br>
  würden wir uns sehr über einen Stern ⭐ auf GitHub freuen!
</p>

---

## Repository-Layout

Dieses **ThinkSound** GitHub-Repository beherbergt zwei verwandte Projekte auf separaten Branches:

| Branch | Projekt | Dokumentation |
|--------|---------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — vereinheitlichte Any2Audio-Generierung mit CoT-gestütztem Flow Matching | Diese Datei: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — Folgeprojekt (ICLR 2026) zu Video-zu-Audio mit multidimensionalem CoT-RL | **`README.md`** auf dem [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) Branch |

Für **ThinkSound** nutze den Branch **`master`** (dieses README). Für **PrismAudio** wechsle zu **`prismaudio`** und folge dort **`README.md`**.

---

**ThinkSound** ist ein vereinheitlichter Any2Audio-Generierungsrahmen mit Flow Matching, geleitet durch Chain-of-Thought (CoT)-Reasoning.

PyTorch-Implementierung für multimodale Audio-Generierung und -Bearbeitung: Erzeuge oder bearbeite Audio aus Video, Text und Audio, unterstützt durch schrittweise Reasoning von Multimodalen Large Language Models (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Neuigkeiten
- **2026.03.24** &nbsp; 🔥 **PrismAudio** ist im selben Repo auf dem Branch [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) veröffentlicht — siehe **`README.md`** dort für Setup und Modelle.
- **2026.01.26** &nbsp; 🎉 PrismAudio wurde auf der **ICLR 2026 Main Conference** angenommen (Code/Dokumentation auf `prismaudio`).
- **2025.11.25** &nbsp; 🔥 [Online PrismAudio Demo](http://prismaudio-project.github.io/) ist live.
- **2025.11.25** &nbsp; 🔥 [PrismAudio Paper](https://arxiv.org/pdf/2511.18833) auf arXiv — multidimensionales CoT-RL für Video-zu-Audio.
- **2025.09.19** &nbsp; 🎉 **ThinkSound** wurde auf der **NeurIPS 2025 Main Conference** angenommen!
- **2025.09.01** &nbsp; Unser AudioCoT-Datensatz ist jetzt als Open Source verfügbar auf [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Feintuning aktiviert: Trainings- und Feintuning-Code ist jetzt öffentlich verfügbar, mit klaren Anweisungen zur Nutzung, damit du ThinkSound mit eigenen Daten anpassen und erweitern kannst.
- **2025.07.15** &nbsp; 📦 Vereinfachte Installation und Benutzerfreundlichkeit: Abhängigkeiten auf PyPI für einfache plattformübergreifende Einrichtung; Windows `.bat`-Skripte automatisieren die Umgebungserstellung und das Ausführen von Skripten.
- **2025.07.08** &nbsp;  🔧 Großes Update: Modell verschlankt und optimierter Speicher- und GPU-Verbrauch, unterstützt jetzt hochskalierbare Audio-Generierung!
- **2025.07.01** &nbsp; Online-Demo auf [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) und [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) für interaktives Erlebnis!
- **2025.07.01** &nbsp; Veröffentlicht Inferenz-Skripte und Weboberfläche;
- **2025.06** &nbsp; [ThinkSound Paper](https://arxiv.org/pdf/2506.21448) auf arXiv veröffentlicht!
- **2025.06** &nbsp; [Online Demo](http://thinksound-project.github.io/) ist live – jetzt ausprobieren!

---


<div align="center">

### Folgeprojekt: PrismAudio (selbes Repo, `prismaudio` Branch)

**PrismAudio** ist der Nachfolger von ThinkSound (ICLR 2026), der unter neuem Namen entwickelt wurde, aber weiterhin in diesem Repository auf dem Branch **`prismaudio`** geführt wird. Installation, Checkpoints und Zitation befinden sich in **[`README.md` auf diesem Branch](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**.

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) oder den Branch auf GitHub öffnen.

</div>

---


## 🚀 Funktionen

- **Any2Audio**: Erzeugt Audio aus beliebigen Modalitäten — Video, Text, Audio oder deren Kombinationen.
- **Video-to-Audio SOTA**: Erreicht modernste Ergebnisse auf mehreren V2A-Benchmarks.
- **CoT-gesteuertes Reasoning**: Chain-of-Thought-Reasoning für kompositionelle und steuerbare Audiogenerierung mittels MLLMs.
- **Interaktives objektzentriertes Editieren**: Verfeinere oder bearbeite spezifische Klangereignisse durch Klicken auf visuelle Objekte oder mit Textanweisungen.
- **Einheitliches Framework**: Ein Foundation-Modell unterstützt Generierung, Bearbeitung und interaktiven Workflow.

---

## ✨ Methodenübersicht

ThinkSound zerlegt die Audioerzeugung und -bearbeitung in drei interaktive Phasen, die alle durch MLLM-basiertes Chain-of-Thought-Reasoning (CoT) gesteuert werden:

1. **Foley-Erzeugung:** Erstelle grundlegende, semantisch und zeitlich abgestimmte Klanglandschaften aus Videos.
2. **Objektzentrierte Verfeinerung:** Verfeinere oder füge Sounds für vom Nutzer spezifizierte Objekte durch Klicks oder Regionen im Video hinzu.
3. **Gezieltes Audio-Editing:** Modifiziere generiertes Audio mithilfe hochrangiger Anweisungen in natürlicher Sprache.

![ThinkSound Übersicht](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Ein groß angelegter, mit CoT annotierter Datensatz (**AudioCoT**) wird sowohl zur Schulung des Reasoning-Moduls als auch des einheitlichen Audio-Foundation-Modells verwendet.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Schnellstart

**Umgebungsvorbereitung:**
```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
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
## 🏋️ Modell trainieren

Siehe [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---


## 📄 Lizenz

Dieses Projekt wird unter der Apache 2.0 Lizenz veröffentlicht.

> **Hinweis:**
> Der Code, die Modelle und der Datensatz sind **nur für Forschungs- und Ausbildungszwecke** bestimmt.
> **Kommerzielle Nutzung ist NICHT gestattet.**
> Für kommerzielle Lizenzen wenden Sie sich bitte an die Autoren.

**📦 Komponenten von Drittanbietern**

* **Stable Audio Open VAE** (von Stability AI):
  Dieses Repository enthält ein feinabgestimmtes VAE von [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), lizenziert unter der [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Kommerzielle Nutzung und Weiterverbreitung erfordern die vorherige Genehmigung von Stability AI.**

* 📘 **Alle anderen Codes und Modelle** werden unter der Apache License 2.0 veröffentlicht.

---

## Danksagungen

Vielen Dank an:

* **stable-audio-tools** (von Stability AI):
Für die Bereitstellung eines einfach zu bedienenden Frameworks zur Audiogenerierung sowie des VAE-Moduls und der Gewichte.
* **MMAudio**:
  Für die Implementierung des MM-DiT-Backbones im Audio-Bereich.

---



## 📖 Zitierung

Wenn Sie unser Projekt in Ihrer Forschung oder Arbeit nützlich finden, zitieren Sie bitte unsere Veröffentlichung:

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
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---