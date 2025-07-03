# 🎶 ThinkSound

<p align="center">
  Wenn Sie dieses Projekt nützlich finden, würden wir uns sehr über einen Stern ⭐ auf GitHub freuen!
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

---

**ThinkSound** ist ein einheitliches Any2Audio-Generierungsframework mit Flow Matching, das durch Chain-of-Thought (CoT)-Reasoning geführt wird.

PyTorch-Implementierung für multimodale Audiogenerierung und -bearbeitung: Erzeugen oder Bearbeiten von Audio aus Video, Text und Audio, unterstützt durch schrittweises Reasoning von Multimodalen Large Language Models (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Neuigkeiten
- **2025.07** &nbsp; 🔥Online-Demo auf [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) und [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) für interaktive Erfahrungen!
- **2025.07** &nbsp; 🔥Inference-Skripte und Web-Oberfläche veröffentlicht;
- **2025.06** &nbsp; 🔥[ThinkSound Paper](https://arxiv.org/pdf/2506.21448) auf arXiv veröffentlicht!
- **2025.06** &nbsp; 🔥[Online-Demo](http://thinksound-project.github.io/) ist live – jetzt ausprobieren!

---

## 🚀 Funktionen

- **Any2Audio**: Erzeuge Audio aus beliebigen Modalitäten – Video, Text, Audio oder deren Kombinationen.
- **Video-zu-Audio SOTA**: Erreicht den Stand der Technik auf mehreren V2A-Benchmarks.
- **CoT-gesteuertes Reasoning**: Chain-of-Thought-Reasoning für kompositionelle und kontrollierbare Audiogenerierung via MLLMs.
- **Interaktive objektzentrierte Bearbeitung**: Verfeinere oder bearbeite spezifische Klangereignisse durch Klicken auf visuelle Objekte oder durch Textanweisungen.
- **Einheitliches Framework**: Ein Foundation-Modell unterstützt Generierung, Bearbeitung und interaktiven Workflow.

---

## ✨ Methodenübersicht

ThinkSound zerlegt die Audiogenerierung und -bearbeitung in drei interaktive Phasen, die alle durch MLLM-basiertes Chain-of-Thought (CoT)-Reasoning geführt werden:

1. **Foley-Generierung:** Generiere grundlegende, semantisch und zeitlich ausgerichtete Klanglandschaften aus Video.
2. **Objektzentrierte Verfeinerung:** Verfeinere oder füge Klänge für benutzerspezifizierte Objekte durch Klicks oder Regionen im Video hinzu.
3. **Gezielte Audiobearbeitung:** Bearbeite generiertes Audio mithilfe von hochrangigen Anweisungen in natürlicher Sprache.

![ThinkSound Übersicht](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Ein groß angelegter CoT-annotierter Datensatz (**AudioCoT**) wird zum Training sowohl des Reasoning-Moduls als auch des einheitlichen Audio-Foundation-Modells verwendet.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Schnellstart

**Umgebung vorbereiten:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# Vorgefertigte Gewichte herunterladen https://huggingface.co/liuhuadai/ThinkSound in das Verzeichnis ckpts/
# Modellgewichte können auch von https://www.modelscope.cn/models/iic/ThinkSound heruntergeladen werden
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**Ausführbar machen**
```bash
chmod +x scripts/demo.sh
```

**Skript ausführen**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```

### Nutzung der Web-Oberfläche

Für ein interaktives Erlebnis starte die Gradio-Weboberfläche:

```bash
python app.py
```

---
## 📝 TODO

- ☐ Veröffentlichung der Trainingsskripte für ThinkSound-Modelle
- ☐ Open-Source des AudioCoT-Datensatzes und der automatisierten Pipeline
- ☐ Bereitstellung ausführlicher Dokumentation und API-Referenz
- ☐ Unterstützung weiterer Modalitäten und nachgelagerter Aufgaben hinzufügen

---

## 📄 Lizenz

Dieses Projekt wird unter der [Apache 2.0 Lizenz](LICENSE) veröffentlicht.

> **Hinweis:**  
> Der Code, die Modelle und der Datensatz sind **ausschließlich für Forschungs- und Bildungszwecke** bestimmt.  
> **Kommerzielle Nutzung ist NICHT gestattet.**
>
> Für kommerzielle Lizenzen kontaktieren Sie bitte die Autoren.

---

## 📖 Zitation

Wenn Sie ThinkSound in Ihrer Forschung oder Arbeit verwenden, zitieren Sie bitte unsere Publikation:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo und Wen Wang und Qian Chen und Zhou Zhao und Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
```

---

## 📬 Kontakt

✨ Öffnen Sie gerne [ein Issue](https://github.com/liuhuadai/ThinkSound/issues) oder kontaktieren Sie uns per E-Mail ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)), wenn Sie Fragen oder Anregungen haben!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---