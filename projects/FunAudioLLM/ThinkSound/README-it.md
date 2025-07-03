# 🎶 ThinkSound

<p align="center">
  Se trovi utile questo progetto, una stella ⭐ su GitHub sarebbe molto apprezzata!
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

**ThinkSound** è un framework unificato Any2Audio per la generazione audio, con flow matching guidato da Chain-of-Thought (CoT) reasoning.

Implementazione PyTorch per la generazione ed editing audio multimodale: genera o modifica audio da video, testo e audio, alimentato dal ragionamento step-by-step dei Modelli Multimodali di Linguaggio di Grandi Dimensioni (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Novità
- **2025.07** &nbsp; 🔥Demo online su [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) e [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) per un'esperienza interattiva!
- **2025.07** &nbsp; 🔥Rilasciati script di inferenza e interfaccia web;
- **2025.06** &nbsp; 🔥[Articolo ThinkSound](https://arxiv.org/pdf/2506.21448) pubblicato su arXiv!
- **2025.06** &nbsp; 🔥[Demo online](http://thinksound-project.github.io/) attiva - provala ora!

---

## 🚀 Caratteristiche

- **Any2Audio**: Genera audio da qualsiasi modalità — video, testo, audio o loro combinazioni.
- **Video-to-Audio SOTA**: Raggiunge risultati all’avanguardia su diversi benchmark V2A.
- **CoT-Driven Reasoning**: Chain-of-Thought reasoning per generazione audio compositiva e controllabile tramite MLLMs.
- **Editing Interattivo Object-centric**: Affina o modifica eventi sonori specifici cliccando su oggetti visivi o usando istruzioni testuali.
- **Framework Unificato**: Un unico modello di base supporta generazione, editing e workflow interattivo.

---

## ✨ Panoramica del Metodo

ThinkSound scompone la generazione e l’editing audio in tre fasi interattive, tutte guidate dal ragionamento Chain-of-Thought (CoT) basato su MLLM:

1. **Generazione Foley:** Genera paesaggi sonori fondamentali, semanticamente e temporalmente allineati dal video.
2. **Refinement Object-Centric:** Affina o aggiungi suoni per oggetti specificati dall’utente tramite click o regioni nel video.
3. **Editing Audio Mirato:** Modifica l’audio generato utilizzando istruzioni in linguaggio naturale di alto livello.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Un dataset annotato su larga scala CoT (**AudioCoT**) viene utilizzato per addestrare sia il modulo di ragionamento che il modello audio di base unificato.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Per iniziare rapidamente

**Preparazione dell’ambiente:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# Scarica i pesi preaddestrati da https://huggingface.co/liuhuadai/ThinkSound nella cartella ckpts/
# i pesi del modello possono essere scaricati anche da https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**Rendi eseguibile**
```bash
chmod +x scripts/demo.sh
```

**Esegui lo script**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### Utilizzo dell’interfaccia Web

Per un’esperienza interattiva, avvia l’interfaccia web Gradio:

```bash
python app.py
```

---
## 📝 TODO

- ☐ Rilasciare gli script di addestramento per i modelli ThinkSound
- ☐ Open-source del dataset AudioCoT e pipeline automatizzata
- ☐ Fornire documentazione dettagliata e riferimento API
- ☐ Aggiungere il supporto per ulteriori modalità e task downstream

---

## 📄 Licenza

Questo progetto è rilasciato sotto la [Licenza Apache 2.0](LICENSE).

> **Nota:**  
> Il codice, i modelli e il dataset sono **solo per scopi di ricerca ed educativi**.  
> **L'uso commerciale NON è consentito.**
>
> Per la licenza commerciale, contattare gli autori.

---

## 📖 Citazione

Se trovi ThinkSound utile per la tua ricerca o lavoro, cita il nostro paper:

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

## 📬 Contatti

✨ Sentiti libero di [aprire una issue](https://github.com/liuhuadai/ThinkSound/issues) o di contattarci via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) se hai domande o suggerimenti!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---