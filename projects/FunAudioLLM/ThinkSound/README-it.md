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
  Se trovi utile questo progetto,<br>
  una stella ⭐ su GitHub sarebbe molto apprezzata!
</p>

---

**ThinkSound** è un framework unificato per la generazione Any2Audio con flow matching guidato dal ragionamento Chain-of-Thought (CoT).

Implementazione PyTorch per la generazione e modifica multimodale di audio: genera o modifica audio da video, testo e audio, alimentata dal ragionamento step-by-step dei Modelli Multimodali di Linguaggio di Grandi Dimensioni (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Novità
- **2025.11.25** &nbsp; 🔥[Demo PrismAudio Online](http://prismaudio-project.github.io/) attivo - provalo ora!
- **2025.11.25** &nbsp; 🔥[Articolo PrismAudio](https://arxiv.org/pdf/2511.18833) pubblicato su arXiv, il primo framework multi-dimensionale CoT-RL per la generazione Video-to-Audio!
- **2025.09.19** &nbsp; 🎉 ThinkSound è stato accettato alla **Conferenza Principale NeurIPS 2025**!
- **2025.09.01** &nbsp; Il nostro dataset AudioCoT è ora open-source e disponibile su [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Fine-tuning abilitato: codice per training e fine-tuning ora pubblico, con istruzioni dettagliate per personalizzare ed estendere ThinkSound con i tuoi dati.
- **2025.07.15** &nbsp; 📦 Installazione e usabilità semplificate: dipendenze su PyPI per setup facile cross-platform; script `.bat` per Windows automatizzano la creazione dell'ambiente e l'esecuzione degli script.
- **2025.07.08** &nbsp;  🔧 Aggiornamento importante: modello alleggerito e memoria/GPU ottimizzati, ora supporta generazione audio ad alta velocità su larga scala!
- **2025.07.01** &nbsp; Demo online su [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) e [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) per esperienza interattiva!
- **2025.07.01** &nbsp; Rilasciati script di inferenza e interfaccia web;
- **2025.06** &nbsp; [Articolo ThinkSound](https://arxiv.org/pdf/2506.21448) pubblicato su arXiv!
- **2025.06** &nbsp; [Demo Online](http://thinksound-project.github.io/) attivo - provalo ora!

---


## 🚀 Funzionalità

- **Any2Audio**: Genera audio da modalità arbitrarie — video, testo, audio, o loro combinazioni.
- **Video-to-Audio SOTA**: Risultati all'avanguardia su diversi benchmark V2A.
- **Ragionamento CoT-Driven**: Ragionamento Chain-of-Thought per generazione audio composizionale e controllabile tramite MLLMs.
- **Editing Interattivo Oggetto-centrico**: Raffina o modifica specifici eventi sonori cliccando su oggetti visivi o usando istruzioni testuali.
- **Framework Unificato**: Un unico modello di base supporta generazione, editing e flusso di lavoro interattivo.

---

## ✨ Panoramica del Metodo

ThinkSound scompone generazione ed editing audio in tre fasi interattive, tutte guidate dal ragionamento Chain-of-Thought (CoT) basato su MLLM:

1. **Foley Generation:** Genera paesaggi sonori fondamentali, semanticamente e temporalmente allineati, dal video.
2. **Object-Centric Refinement:** Raffina o aggiungi suoni per oggetti specificati dall'utente tramite click o regioni nel video.
3. **Targeted Audio Editing:** Modifica l'audio generato usando istruzioni in linguaggio naturale di alto livello.

![Panoramica ThinkSound](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Un ampio dataset annotato CoT (**AudioCoT**) viene utilizzato per addestrare sia il modulo di ragionamento che il modello audio foundation unificato.
![Pipeline AudioCoT](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Avvio rapido

**Preparazione dell’ambiente:**
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
> ✅ **Suggerimento per Windows:**  
> Gli utenti Windows possono semplicemente eseguire `setup_windows.bat` (o farci doppio clic) per creare automaticamente l'ambiente conda, installare tutte le dipendenze (incluso FFmpeg) e scaricare il modello pre-addestrato — nessuna configurazione manuale richiesta.  
> Assicurati che `conda` e `git` siano installati e disponibili nel PATH di sistema prima di eseguire lo script.


### ▶️ Esegui la Demo

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

In alternativa, puoi utilizzare lo script `.bat` fornito:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**Nota:**

* `<percorso-al-tuo-video-demo>`: Il percorso a un singolo video
* `[usa-half]` (opzionale): Aggiungi usa-half alla fine per abilitare l'estrazione delle caratteristiche in mezza precisione.

---

### 📦 Inferenza in Batch

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

Usa lo script `.bat` equivalente:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**Nota:**

* `<video_path>`: Percorso alla directory principale contenente tutti i video .mp4 da elaborare (tutti i video devono avere la stessa durata).
* `<csv_path>`: Un file CSV con i prompt di testo per ciascun video (vedi `demo_test.csv` per il formato).
* `<save_path>` (opzionale): Dove salvare l'audio generato. Il valore predefinito è `results/features`.
* `[use-half]` (opzionale): Aggiungi use-half alla fine per abilitare l'estrazione delle feature in mezza precisione.

---


### Utilizzo dell'interfaccia web

Per un'esperienza interattiva, avvia l'interfaccia web Gradio:


```bash
python app.py
```


## 🏋️ Allena il Modello

Vedi [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 TODO & Piani Futuri
* - [ ] Rilasciare un modello di base più potente che copra più domini per offrire una creazione di foley più coinvolgente e immersiva
* - [ ] Aggiungere supporto per ulteriori modalità e compiti downstream
* - [ ] Rilasciare modelli di diverse dimensioni
* - [x] Open-source del dataset AudioCoT e pipeline automatizzata
* - [x] Rilasciare gli script di addestramento per i modelli ThinkSound
* - [x] Un README rapido per Windows adatto ai principianti
---


## 📄 Licenza

Questo progetto è rilasciato sotto la Licenza Apache 2.0.

> **Nota:**
> Il codice, i modelli e il dataset sono **solo per scopi di ricerca ed educativi**.
> **L'uso commerciale NON è consentito.**
> Per la licenza commerciale, si prega di contattare gli autori.

**📦 Componenti di Terze Parti**

* **Stable Audio Open VAE** (di Stability AI):
  Questo repository include un VAE ottimizzato da [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), concesso in licenza secondo la [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **L'uso commerciale e la redistribuzione richiedono il permesso preventivo di Stability AI.**

* 📘 **Tutto il resto del codice e dei modelli** è rilasciato sotto la Licenza Apache 2.0.

---

## Ringraziamenti

Molte grazie a:

* **stable-audio-tools** (di Stability AI):
Per aver fornito un framework facile da usare per la generazione audio, oltre al modulo VAE e ai relativi pesi.
* **MMAudio**:
  Per l'implementazione dell'architettura MM-DiT nel dominio audio.

---

## 📖 Citazione

Se trovi ThinkSound utile per la tua ricerca o lavoro, cita il nostro articolo:

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-07

---