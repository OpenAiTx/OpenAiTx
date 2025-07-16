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
  Se trovi utile questo progetto,<br>
  una stella ⭐ su GitHub sarebbe molto apprezzata!
</p>

---

**ThinkSound** è un framework unificato Any2Audio per la generazione guidata da flow matching e ragionamento Chain-of-Thought (CoT).

Implementazione PyTorch per la generazione e l’editing audio multimodale: genera o modifica audio da video, testo e audio, supportato da ragionamento step-by-step tramite Multimodal Large Language Models (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Novità
- **2025.07.15** &nbsp; 📦 Installazione e usabilità semplificate: dipendenze su PyPI per una configurazione cross-platform facile; script Windows `.bat` automatizzano creazione ambiente ed esecuzione script.
- **2025.07.08** &nbsp;  🔧 Aggiornamento principale: modello alleggerito e ottimizzato per uso di memoria e GPU, ora supporta generazione audio ad alto throughput su larga scala!
- **2025.07.01** &nbsp; 🔥Demo online su [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) e [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) per un’esperienza interattiva!
- **2025.07.01** &nbsp; 🔥Rilasciati script di inferenza e interfaccia web;
- **2025.06** &nbsp; 🔥[Articolo ThinkSound](https://arxiv.org/pdf/2506.21448) pubblicato su arXiv!
- **2025.06** &nbsp; 🔥[Demo Online](http://thinksound-project.github.io/) attiva - provala ora!

---


## 🚀 Caratteristiche

- **Any2Audio**: Genera audio da modalità arbitrarie — video, testo, audio o loro combinazioni.
- **Video-to-Audio SOTA**: Raggiunge risultati all’avanguardia su diversi benchmark V2A.
- **Ragionamento guidato CoT**: Ragionamento Chain-of-Thought per generazione audio composizionale e controllabile tramite MLLMs.
- **Editing Interattivo Object-Centric**: Affina o modifica eventi sonori specifici cliccando su oggetti visivi o usando istruzioni testuali.
- **Framework Unificato**: Un modello di base supporta generazione, editing e workflow interattivo.

---

## ✨ Panoramica del Metodo

ThinkSound scompone la generazione e l’editing audio in tre fasi interattive, tutte guidate dal ragionamento CoT basato su MLLM:

1. **Generazione Foley:** Genera paesaggi sonori di base, semanticamente e temporalmente allineati al video.
2. **Raffinamento Object-Centric:** Affina o aggiungi suoni per oggetti specificati dall’utente tramite click o regioni nel video.
3. **Editing Audio Mirato:** Modifica l’audio generato usando istruzioni in linguaggio naturale ad alto livello.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Un dataset su larga scala annotato CoT (**AudioCoT**) è usato per addestrare sia il modulo di ragionamento sia il modello di base audio unificato.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Per iniziare rapidamente

**Preparazione Ambiente:**
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
---

## 📝 TODO & Piani Futuri
* - [ ] Rilasciare gli script di addestramento per i modelli ThinkSound (Previsto prima del 20/07/2025)
* - [ ] Open-source del dataset AudioCoT e della pipeline automatizzata (Previsto prima del 23/07/2025)
* - [ ] Fornire un'immagine ambiente pronta all'uso (Previsto prima del 23/07/2025)
* - [ ] Rilasciare un modello di base più potente che copra più domini per offrire una creazione di foley più coinvolgente e immersiva (Previsto entro la fine di agosto 2025)
* - [ ] Aggiungere il supporto per modalità aggiuntive e compiti downstream (Previsto prima della fine di luglio 2025)
* - [ ] Rilasciare modelli a diverse scale (Previsto prima della fine di luglio 2025)
* - [x] Un README di avvio rapido per Windows adatto ai principianti
---


## 📄 Licenza

Questo progetto è rilasciato sotto licenza Apache 2.0.

> **Nota:**
> Il codice, i modelli e il dataset sono **solo per scopi di ricerca ed educativi**.
> **L'uso commerciale NON è consentito.**
> Per licenze commerciali, contattare gli autori.

**📦 Componenti di Terze Parti**

* **Stable Audio Open VAE** (di Stability AI):
  Questo repository include un VAE ottimizzato da [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), rilasciato sotto la [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **L'uso commerciale e la redistribuzione richiedono il permesso preventivo di Stability AI.**

* 📘 **Tutto il resto del codice e dei modelli** è rilasciato sotto licenza Apache 2.0.

---

## Ringraziamenti

Molte grazie a:

* **stable-audio-tools** (di Stability AI):
Per aver fornito un framework facile da usare per la generazione audio, oltre al modulo VAE e ai relativi pesi.
* **MMAudio**:
  Per l'implementazione del backbone MM-DiT nel dominio audio.

---

## 📖 Citazione

Se trovi ThinkSound utile nella tua ricerca o nel tuo lavoro, cita il nostro articolo:


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

✨ Sentiti libero di [aprire una segnalazione](https://github.com/liuhuadai/ThinkSound/issues) o contattarci via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) se hai domande o suggerimenti!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---