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
  <img src="https://img.shields.io/badge/NeurIPS 2025-Main Conference-blue.svg" alt="NeurIPS 2025"/>
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
  Als je dit project nuttig vindt,<br>
  wordt een ster ⭐ op GitHub zeer gewaardeerd!
</p>

---

**ThinkSound** is een uniform Any2Audio generatiekader met flow matching gestuurd door Chain-of-Thought (CoT) redeneren.

PyTorch-implementatie voor multimodale audiogeneratie en -bewerking: genereer of bewerk audio vanuit video, tekst en audio, aangedreven door stapsgewijze redenering van Multimodale Grote Taalmodellen (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Nieuws
- **2025.09.19** &nbsp; 🎉 ThinkSound is geaccepteerd voor de **NeurIPS 2025 Hoofdconferentie**!
- **2025.09.01** &nbsp; 🔥 Onze AudioCoT-dataset is nu open-source en beschikbaar op [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Finetuning ingeschakeld: trainings- en finetuningcode is nu publiekelijk beschikbaar, samen met duidelijke gebruiksinstructies om ThinkSound te personaliseren en uit te breiden met je eigen data.
- **2025.07.15** &nbsp; 📦 Vereenvoudigde installatie en bruikbaarheid: afhankelijkheden op PyPI voor eenvoudige cross-platform installatie; Windows `.bat`-scripts automatiseren het aanmaken van omgevingen en het uitvoeren van scripts.
- **2025.07.08** &nbsp;  🔧 Grote update: model is lichter gemaakt en geoptimaliseerd voor geheugen- en GPU-gebruik, ondersteunt nu grootschalige audiogeneratie met hoge doorvoer!
- **2025.07.01** &nbsp; 🔥Online demo op [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) en [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) voor een interactieve ervaring!
- **2025.07.01** &nbsp; 🔥Inference-scripts en webinterface vrijgegeven; 
- **2025.06** &nbsp; 🔥[ThinkSound-paper](https://arxiv.org/pdf/2506.21448) uitgebracht op arXiv!
- **2025.06** &nbsp; 🔥[Online Demo](http://thinksound-project.github.io/) is live - probeer het nu uit!

---


## 🚀 Functionaliteiten

- **Any2Audio**: Genereer audio vanuit willekeurige modaliteiten — video, tekst, audio of hun combinaties.
- **Video-naar-Audio SOTA**: Behaalt state-of-the-art resultaten op meerdere V2A benchmarks.
- **CoT-Gestuurde Redenering**: Chain-of-Thought-redenering voor compositorische en controleerbare audiogeneratie via MLLMs.
- **Interactieve Objectgerichte Bewerking**: Verfijn of bewerk specifieke geluidsgebeurtenissen door te klikken op visuele objecten of tekstinstructies te gebruiken.
- **Uniform Framework**: Eén basismodel ondersteunt generatie, bewerking en interactieve workflows.

---

## ✨ Methode Overzicht

ThinkSound splitst audiogeneratie en -bewerking op in drie interactieve stadia, allemaal geleid door CoT-redenering op basis van MLLM:

1. **Foley-generatie:** Genereer fundamentele, semantisch en temporeel uitgelijnde geluidslandschappen vanuit video.
2. **Objectgerichte verfijning:** Verfijn of voeg geluiden toe voor door de gebruiker gespecificeerde objecten via klikken of regio's in de video.
3. **Gerichte audiobewerking:** Pas gegenereerde audio aan met behulp van natuurlijke taal instructies op hoog niveau.

![ThinkSound Overzicht](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Een grootschalige CoT-geannoteerde dataset (**AudioCoT**) wordt gebruikt om zowel de redeneermodule als het uniforme audio-basismodel te trainen.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Snelle start

**Omgevingsvoorbereiding:**
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
> ✅ **Windows Tip:**  
> Windows-gebruikers kunnen eenvoudig `setup_windows.bat` uitvoeren (of dubbelklikken) om automatisch de conda-omgeving aan te maken, alle afhankelijkheden te installeren (inclusief FFmpeg) en het voorgetrainde model te downloaden — geen handmatige installatie vereist.  
> Zorg ervoor dat `conda` en `git` zijn geïnstalleerd en beschikbaar zijn in je systeem-PATH voordat je het script uitvoert.


### ▶️ Demo uitvoeren

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

U kunt in plaats daarvan het meegeleverde `.bat`-script gebruiken:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**Opmerking:**

* `<pad-naar-je-demo-video>`: Het pad naar een enkele video
* `[use-half]` (optioneel): Voeg use-half toe aan het einde om halfprecisie feature-extractie in te schakelen.

---

### 📦 Batch-inferentie

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

Gebruik het equivalente `.bat`-script:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**Opmerking:**

* `<video_path>`: Pad naar de hoofdmap met alle .mp4-video’s die verwerkt moeten worden (alle video’s moeten even lang zijn).
* `<csv_path>`: Een CSV-bestand met tekstprompts voor elke video (zie `demo_test.csv` voor het formaat).
* `<save_path>` (optioneel): Locatie om gegenereerde audio op te slaan. Standaard `results/features`.
* `[use-half]` (optioneel): Voeg use-half toe aan het einde om extractie met halve precisie in te schakelen.

---


### Gebruik van de webinterface

Voor een interactieve ervaring start je de Gradio webinterface:


```bash
python app.py
```


## 🏋️ Train het model

Zie [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 TODO & Toekomstplannen
* - [ ] Uitbrengen van een krachtiger basismodel dat meerdere domeinen bestrijkt voor meer boeiende en meeslepende foley-creatie
* - [ ] Ondersteuning toevoegen voor extra modaliteiten en vervolgopdrachten
* - [ ] Modellen uitbrengen op verschillende schalen
* - [x] Open-source AudioCoT dataset en geautomatiseerde pipeline
* - [x] Trainingsscripts voor ThinkSound-modellen uitbrengen
* - [x] Een beginnersvriendelijke Windows quick-start README
---


## 📄 Licentie

Dit project wordt uitgebracht onder de Apache 2.0-licentie.

> **Let op:**
> De code, modellen en dataset zijn **alleen voor onderzoeks- en educatieve doeleinden**.
> **Commercieel gebruik is NIET toegestaan.**
> Voor commerciële licenties kunt u contact opnemen met de auteurs.

**📦 Componenten van derden**

* **Stable Audio Open VAE** (door Stability AI):
  Deze repository bevat een fijn-afgestemde VAE van [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), gelicentieerd onder de [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Commercieel gebruik en herdistributie vereisen voorafgaande toestemming van Stability AI.**

* 📘 **Alle overige code en modellen** worden uitgebracht onder de Apache License 2.0.

---

## Dankbetuigingen

Veel dank aan:

* **stable-audio-tools** (door Stability AI):
Voor het bieden van een gebruiksvriendelijk framework voor audiogeneratie, evenals de VAE-module en gewichten.
* **MMAudio**:
  Voor de implementatie van de MM-DiT backbone in het audiodomein.

---

## 📖 Referentie

Als u ThinkSound nuttig vindt in uw onderzoek of werk, citeer dan onze paper:

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

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-04

---