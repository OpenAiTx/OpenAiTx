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

**ThinkSound** è un framework unificato Any2Audio per la generazione audio guidata da ragionamento Chain-of-Thought (CoT) tramite flow matching.

Implementazione PyTorch per la generazione ed editing audio multimodale: genera o modifica audio da video, testo e audio, sfruttando il ragionamento passo-passo dei Multimodal Large Language Models (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Novità
- **2025.07.17** &nbsp; 🧠 Fine-tuning abilitato: codice per training e fine-tuning ora disponibile pubblicamente, con istruzioni chiare per personalizzare ed estendere ThinkSound con i tuoi dati.
- **2025.07.15** &nbsp; 📦 Installazione e usabilità semplificate: dipendenze su PyPI per una configurazione facile cross-platform; script Windows `.bat` automatizzano la creazione dell'ambiente e l'esecuzione degli script.
- **2025.07.08** &nbsp;  🔧 Aggiornamento principale: modello alleggerito e ottimizzato per uso di memoria e GPU, ora supporta generazione audio ad alta produttività su larga scala!
- **2025.07.01** &nbsp; 🔥Demo online su [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) e [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) per un'esperienza interattiva!
- **2025.07.01** &nbsp; 🔥Rilasciati script di inferenza e interfaccia web;
- **2025.06** &nbsp; 🔥[Articolo ThinkSound](https://arxiv.org/pdf/2506.21448) pubblicato su arXiv!
- **2025.06** &nbsp; 🔥[Demo Online](http://thinksound-project.github.io/) disponibile - provalo ora!

---


## 🚀 Caratteristiche

- **Any2Audio**: Genera audio da qualsiasi modalità — video, testo, audio o loro combinazioni.
- **Video-to-Audio SOTA**: Risultati all'avanguardia su molteplici benchmark V2A.
- **Ragionamento guidato CoT**: Ragionamento Chain-of-Thought per generazione audio compositiva e controllabile tramite MLLMs.
- **Editing interattivo centrato sugli oggetti**: Raffina o modifica eventi sonori specifici cliccando su oggetti visivi o usando istruzioni testuali.
- **Framework unificato**: Un unico modello di base supporta generazione, editing e workflow interattivo.

---

## ✨ Panoramica del Metodo

ThinkSound scompone la generazione e l’editing audio in tre fasi interattive, tutte guidate dal ragionamento Chain-of-Thought (CoT) basato su MLLM:

1. **Generazione Foley:** Genera paesaggi sonori di base, semanticamente e temporalmente allineati al video.
2. **Raffinamento centrato sugli oggetti:** Raffina o aggiungi suoni per oggetti specificati dall’utente tramite click o regioni nel video.
3. **Editing audio mirato:** Modifica l’audio generato usando istruzioni in linguaggio naturale di alto livello.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Un dataset su larga scala annotato CoT (**AudioCoT**) viene usato per addestrare sia il modulo di ragionamento che il modello audio di base unificato.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

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
* - [ ] Open-source del dataset AudioCoT e pipeline automatizzata (Previsto prima del 23/07/2025)
* - [ ] Rilascio di un modello di base più potente che copre più domini per fornire una creazione foley più coinvolgente e immersiva (Previsto entro fine agosto 2025)
* - [ ] Aggiunta del supporto per ulteriori modalità e task downstream (Previsto prima della fine di luglio 2025)
* - [ ] Rilascio di modelli su diverse scale (Previsto prima della fine di luglio 2025)
* - [x] Rilascio degli script di addestramento per i modelli ThinkSound
* - [x] Una README di avvio rapido per Windows adatta ai principianti
---


## 📄 Licenza

Questo progetto è rilasciato sotto licenza Apache 2.0.

> **Nota:**
> Il codice, i modelli e il dataset sono **solo per scopi di ricerca ed educativi**.
> **L'uso commerciale NON è consentito.**
> Per licenze commerciali, si prega di contattare gli autori.

**📦 Componenti di Terze Parti**

* **Stable Audio Open VAE** (di Stability AI):
  Questo repository include una VAE fine-tuned da [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), con licenza [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **L'uso commerciale e la redistribuzione richiedono il permesso preventivo di Stability AI.**

* 📘 **Tutto il restante codice e modelli** sono rilasciati sotto licenza Apache 2.0.

---

## Ringraziamenti

Molte grazie a:

* **stable-audio-tools** (di Stability AI):
Per aver fornito un framework facile da usare per la generazione audio, così come il modulo VAE e i pesi.
* **MMAudio**:
  Per l'implementazione del backbone MM-DiT nel dominio audio.

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

## 📬 Contatto

✨ Sentiti libero di [aprire una issue](https://github.com/liuhuadai/ThinkSound/issues) o contattarci via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) se hai domande o suggerimenti!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---