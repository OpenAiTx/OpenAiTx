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
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  Se trovi utile questo progetto,<br>
  una stella ⭐ su GitHub sarebbe molto apprezzata!
</p>

---

## Struttura del repository

Questo repository GitHub **ThinkSound** ospita due progetti correlati su rami separati:

| Branch | Progetto | Documentazione |
|--------|----------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — generazione Any2Audio unificata con flow matching guidato da CoT | Questo file: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — lavoro successivo (ICLR 2026) su video-to-audio con CoT-RL multi-dimensionale | **`README.md`** sul ramo [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) |

Per **ThinkSound**, usa il ramo **`master`** (questo README). Per **PrismAudio**, passa a **`prismaudio`** e segui **`README.md`** lì.

---

**ThinkSound** è un framework unificato per la generazione Any2Audio con flow matching guidato dal Chain-of-Thought (CoT) reasoning.

Implementazione PyTorch per generazione ed editing audio multimodale: genera o modifica audio da video, testo e audio, sfruttando il ragionamento step-by-step dei Multimodal Large Language Models (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Novità
- **2026.03.24** &nbsp; 🔥 **PrismAudio** è stato rilasciato nello stesso repo sul ramo [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) — vedi **`README.md`** lì per setup e modelli.
- **2026.01.26** &nbsp; 🎉 PrismAudio accettato alla **ICLR 2026 Main Conference** (codice/doc su `prismaudio`).
- **2025.11.25** &nbsp; 🔥 [Demo online PrismAudio](http://prismaudio-project.github.io/) disponibile.
- **2025.11.25** &nbsp; 🔥 [Paper PrismAudio](https://arxiv.org/pdf/2511.18833) su arXiv — CoT-RL multi-dimensionale per video-to-audio.
- **2025.09.19** &nbsp; 🎉 **ThinkSound** accettato alla **NeurIPS 2025 Main Conference**!
- **2025.09.01** &nbsp; Il nostro dataset AudioCoT è ora open source e disponibile su [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Fine-tuning abilitato: codice di training e fine-tuning ora pubblico, con istruzioni chiare per aiutarti a personalizzare ed estendere ThinkSound con i tuoi dati.
- **2025.07.15** &nbsp; 📦 Installazione semplificata e usabilità: dipendenze su PyPI per facile setup cross-platform; script Windows `.bat` automatizzano la creazione dell’ambiente e l’esecuzione degli script.
- **2025.07.08** &nbsp;  🔧 Major update: modello alleggerito e ottimizzazione uso memoria e GPU, ora supporta generazione audio ad alto throughput su larga scala!
- **2025.07.01** &nbsp; Demo online su [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) e [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) per esperienza interattiva!
- **2025.07.01** &nbsp; Rilasciati script di inferenza e interfaccia web; 
- **2025.06** &nbsp; [Paper ThinkSound](https://arxiv.org/pdf/2506.21448) pubblicato su arXiv!
- **2025.06** &nbsp; [Demo online](http://thinksound-project.github.io/) disponibile - provalo ora!

---


<div align="center">

### Seguito: PrismAudio (stesso repo, ramo `prismaudio`)

**PrismAudio** è il successore di ThinkSound (ICLR 2026), sviluppato sotto un nuovo nome ma mantenuto in questo repository sul branch **`prismaudio`**. Installazione, checkpoint e citazione sono disponibili in **[`README.md` su quel branch](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**.

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) oppure apri il branch su GitHub.

</div>

---


## 🚀 Funzionalità

- **Any2Audio**: Genera audio da modalità arbitrarie — video, testo, audio o loro combinazioni.
- **Video-to-Audio SOTA**: Raggiunge risultati allo stato dell’arte su diversi benchmark V2A.
- **CoT-Driven Reasoning**: Ragionamento Chain-of-Thought per generazione audio composizionale e controllabile tramite MLLMs.
- **Editing Interattivo Oggetto-Centrico**: Affina o modifica eventi sonori specifici cliccando su oggetti visivi o usando istruzioni testuali.
- **Framework Unificato**: Un unico modello di base supporta generazione, editing e workflow interattivo.

---

## ✨ Panoramica del Metodo

ThinkSound scompone la generazione e l’editing audio in tre fasi interattive, tutte guidate dal ragionamento Chain-of-Thought (CoT) basato su MLLM:

1. **Generazione Foley:** Genera paesaggi sonori fondamentali, semanticamente e temporalmente allineati, dal video.
2. **Raffinamento Oggetto-Centrico:** Affina o aggiunge suoni per oggetti specificati dall’utente tramite click o regioni nel video.
3. **Editing Audio Mirato:** Modifica l’audio generato usando istruzioni in linguaggio naturale di alto livello.

![Panoramica ThinkSound](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Un dataset CoT annotato su larga scala (**AudioCoT**) viene utilizzato per addestrare sia il modulo di ragionamento sia il modello audio unificato di base.
![Pipeline AudioCoT](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Avvio Rapido

**Preparazione Ambiente:**
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
## 🏋️ Addestra il Modello

Vedi [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---


## 📄 Licenza

Questo progetto è rilasciato sotto licenza Apache 2.0.

> **Nota:**
> Il codice, i modelli e il dataset sono **solo per scopi di ricerca ed educativi**.
> **L'uso commerciale NON è consentito.**
> Per la licenza commerciale, si prega di contattare gli autori.

**📦 Componenti di Terze Parti**

* **Stable Audio Open VAE** (di Stability AI):
  Questo repository include una VAE perfezionata da [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), rilasciata sotto la [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **L'uso commerciale e la redistribuzione richiedono il previo permesso di Stability AI.**

* 📘 **Tutto il restante codice e i modelli** sono rilasciati sotto licenza Apache 2.0.

---

## Ringraziamenti

Molti ringraziamenti a:

* **stable-audio-tools** (di Stability AI):
Per aver fornito un framework semplice per la generazione audio, oltre al modulo VAE e ai relativi pesi.
* **MMAudio**:
  Per l'implementazione del backbone MM-DiT nel dominio audio.

---



## 📖 Citazione

Se trovi utile il nostro progetto per la tua ricerca o il tuo lavoro, cita il nostro articolo:

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