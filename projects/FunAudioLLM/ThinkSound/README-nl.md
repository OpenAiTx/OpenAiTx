# 🎶 ThinkSound

<p align="center">
  Als je dit project nuttig vindt, wordt een ster ⭐ op GitHub zeer gewaardeerd!
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

**ThinkSound** is een verenigd Any2Audio-generatieframework met flow matching, geleid door Chain-of-Thought (CoT) redeneren.

PyTorch-implementatie voor multimodale audiogeneratie en -bewerking: genereer of bewerk audio vanuit video, tekst en audio, aangedreven door stapsgewijze redenering vanuit Multimodale Large Language Models (MLLM's).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Nieuws
- **2025.07** &nbsp; 🔥Online demo op [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) en [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) voor interactieve ervaring!
- **2025.07** &nbsp; 🔥Inference scripts en webinterface vrijgegeven;
- **2025.06** &nbsp; 🔥[ThinkSound paper](https://arxiv.org/pdf/2506.21448) gepubliceerd op arXiv!
- **2025.06** &nbsp; 🔥[Online Demo](http://thinksound-project.github.io/) is live - probeer het nu!

---

## 🚀 Functionaliteiten

- **Any2Audio**: Genereer audio uit willekeurige modaliteiten — video, tekst, audio, of combinaties daarvan.
- **Video-naar-Audio SOTA**: Bereikt state-of-the-art resultaten op meerdere V2A-benchmarks.
- **CoT-gedreven Redeneren**: Chain-of-Thought redeneren voor compositionele en controleerbare audiogeneratie via MLLM's.
- **Interactieve Object-centrische Bewerking**: Verfijn of bewerk specifieke geluidseffecten door op visuele objecten te klikken of tekstinstructies te gebruiken.
- **Uniform Framework**: Eén foundation model ondersteunt generatie, bewerking en interactieve workflows.

---

## ✨ Methodeoverzicht

ThinkSound splitst audiogeneratie en -bewerking op in drie interactieve fasen, allemaal geleid door MLLM-gebaseerd Chain-of-Thought (CoT) redeneren:

1. **Foley-generatie:** Genereer fundamentele, semantisch en temporeel uitgelijnde soundscapes vanuit video.
2. **Object-centrische verfijning:** Verfijn of voeg geluiden toe voor door de gebruiker gespecificeerde objecten via klikken of regio's in de video.
3. **Gerichte audiobewerking:** Pas gegenereerde audio aan met behulp van natuurlijke taalopdrachten op hoog niveau.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Een grootschalige CoT-geannoteerde dataset (**AudioCoT**) wordt gebruikt om zowel de redeneermodule als het uniforme audio foundation model te trainen.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Snelstart

**Omgevingsvoorbereiding:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound naar de directory ckpts/
# modelgewichten kunnen ook worden gedownload van https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**Maak het uitvoerbaar**
```bash
chmod +x scripts/demo.sh
```

**Voer het script uit**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### Gebruik van de webinterface

Voor een interactieve ervaring, start de Gradio webinterface:

```bash
python app.py
```

---
## 📝 TODO

- ☐ Trainingsscripts voor ThinkSound-modellen vrijgeven
- ☐ AudioCoT-dataset en geautomatiseerde pipeline open-source maken
- ☐ Gedetailleerde documentatie en API-referentie voorzien
- ☐ Ondersteuning toevoegen voor extra modaliteiten en downstream taken

---

## 📄 Licentie

Dit project is uitgebracht onder de [Apache 2.0 Licentie](LICENSE).

> **Opmerking:**  
> De code, modellen en dataset zijn **alleen voor onderzoeks- en educatieve doeleinden**.  
> **Commercieel gebruik is NIET toegestaan.**
>
> Voor commerciële licenties, neem contact op met de auteurs.

---

## 📖 Citaat

Als u ThinkSound nuttig vindt voor uw onderzoek of werk, citeer dan ons artikel:

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

✨ Voel je vrij om [een issue te openen](https://github.com/liuhuadai/ThinkSound/issues) of contact met ons op te nemen via e-mail ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) als je vragen of suggesties hebt!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---