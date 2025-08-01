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
  Als je dit project nuttig vindt,<br>
  wordt een ster ⭐ op GitHub zeer gewaardeerd!
</p>

---

**ThinkSound** is een uniform Any2Audio-generatieframework met flow matching geleid door Chain-of-Thought (CoT) redenering.

PyTorch-implementatie voor multimodale audiogeneratie en -bewerking: genereer of bewerk audio vanuit video, tekst en audio, aangedreven door stapsgewijze redenering van Multimodale Large Language Models (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Nieuws
- **2025.07.17** &nbsp; 🧠 Finetuning ingeschakeld: trainings- en finetuningcode is nu openbaar beschikbaar, samen met duidelijke gebruiksinstructies om ThinkSound te personaliseren en uit te breiden met je eigen data.
- **2025.07.15** &nbsp; 📦 Vereenvoudigde installatie en gebruik: afhankelijkheden op PyPI voor eenvoudige cross-platform installatie; Windows `.bat` scripts automatiseren het aanmaken van de omgeving en het uitvoeren van scripts.
- **2025.07.08** &nbsp;  🔧 Grote update: model is lichter gemaakt en geoptimaliseerd voor geheugen- en GPU-gebruik, ondersteunt nu grootschalige audiogeneratie!
- **2025.07.01** &nbsp; 🔥Online demo op [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) en [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) voor interactieve ervaring!
- **2025.07.01** &nbsp; 🔥Uitgebrachte inference-scripts en webinterface; 
- **2025.06** &nbsp; 🔥[ThinkSound paper](https://arxiv.org/pdf/2506.21448) gepubliceerd op arXiv!
- **2025.06** &nbsp; 🔥[Online Demo](http://thinksound-project.github.io/) is live - probeer het nu!

---


## 🚀 Functionaliteiten

- **Any2Audio**: Genereer audio vanuit willekeurige modaliteiten — video, tekst, audio, of hun combinaties.
- **Video-naar-Audio SOTA**: Bereikt state-of-the-art resultaten op meerdere V2A benchmarks.
- **CoT-Aangedreven Redenering**: Chain-of-Thought-redenering voor compositie- en controleerbare audiogeneratie via MLLMs.
- **Interactieve Objectgerichte Bewerking**: Verfijn of bewerk specifieke geluidsevents door op visuele objecten te klikken of tekstinstructies te gebruiken.
- **Uniform Framework**: Eén foundation model ondersteunt generatie, bewerking en interactieve workflow.

---

## ✨ Methode Overzicht

ThinkSound verdeelt audiogeneratie en -bewerking in drie interactieve stadia, allemaal geleid door MLLM-gebaseerde Chain-of-Thought (CoT) redenering:

1. **Foley Generatie:** Genereer fundamentele, semantisch en temporeel uitgelijnde soundscapes vanuit video.
2. **Objectgerichte Verfijning:** Verfijn of voeg geluiden toe aan door de gebruiker gespecificeerde objecten via klikken of regio's in de video.
3. **Gerichte Audiobewerking:** Pas gegenereerde audio aan met behulp van natuurlijke taal op hoog niveau.

![ThinkSound Overzicht](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Een grootschalige CoT-geannoteerde dataset (**AudioCoT**) wordt gebruikt om zowel de redeneermodule als het uniforme audiofundamentmodel te trainen.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Snelstart

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
* - [ ] Open-source AudioCoT dataset en geautomatiseerde pijplijn (Verwacht vóór 23-07-2025)
* - [ ] Een krachtiger foundation model uitbrengen dat meerdere domeinen bestrijkt voor boeiendere en meeslepende foley-creatie (Verwacht eind augustus 2025)
* - [ ] Ondersteuning toevoegen voor extra modaliteiten en downstream-taken (Verwacht vóór eind juli 2025)
* - [ ] Modellen op verschillende schalen uitbrengen (Verwacht vóór eind juli 2025)
* - [x] Trainingsscripts uitbrengen voor ThinkSound-modellen
* - [x] Een beginnersvriendelijke Windows quick-start README
---


## 📄 Licentie

Dit project is uitgebracht onder de Apache 2.0 Licentie.

> **Opmerking:**
> De code, modellen en dataset zijn **alleen voor onderzoeks- en educatieve doeleinden**.
> **Commercieel gebruik is NIET toegestaan.**
> Voor commerciële licenties, neem contact op met de auteurs.

**📦 Componenten van derden**

* **Stable Audio Open VAE** (door Stability AI):
  Deze repository bevat een fijn-afgestelde VAE van [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), gelicentieerd onder de [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Commercieel gebruik en herdistributie vereisen voorafgaande toestemming van Stability AI.**

* 📘 **Alle overige code en modellen** zijn uitgebracht onder de Apache License 2.0.

---

## Dankbetuigingen

Veel dank aan:

* **stable-audio-tools** (door Stability AI):
Voor het bieden van een gebruiksvriendelijk framework voor audiogeneratie, evenals de VAE-module en gewichten.
* **MMAudio**:
  Voor de implementatie van de MM-DiT backbone in het audiodomein.

---

## 📖 Citeren

Als je ThinkSound nuttig vindt voor je onderzoek of werk, citeer dan ons artikel:



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

✨ Neem gerust [contact met ons op via een issue](https://github.com/liuhuadai/ThinkSound/issues) of stuur ons een e-mail ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) als je vragen of suggesties hebt!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---