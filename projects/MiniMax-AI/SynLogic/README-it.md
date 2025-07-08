<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

Questo repository contiene il codice e i dati per SynLogic, un framework completo per la sintesi di dati di ragionamento logico che genera dati di ragionamento diversificati e verificabili su larga scala. Il nostro lavoro affronta la mancanza critica di dati di addestramento di alta qualità per il ragionamento logico, necessari per sviluppare capacità generali di ragionamento nei Large Language Models (LLM).

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## Novità
- **[2025/07/07]** :fire: Forniamo indicazioni per l'utilizzo dei dati SynLogic nell'addestramento RL con il framework Verl. Vedi [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) per i dettagli.

- **[2025/06/03]** :fire: Modelli addestrati pubblicati su Hugging Face:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: Siamo entusiasti di rilasciare le risorse per l'articolo "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond"

## 📋 Panoramica

**SynLogic** è un framework di sintesi dati e un dataset completo che:
- 📊 **Copre 35 compiti diversi di ragionamento logico** inclusi Sudoku, Gioco del 24, Cifrario, Labirinto di Frecce e molti altri
- 🎯 **Consente la sintesi a difficoltà controllabile** con parametri regolabili per ogni compito
- ✅ **Fornisce ricompense verificabili** tramite verifica basata su regole per l'addestramento RL
- 🚀 **Raggiunge prestazioni SOTA** tra i dataset open-source, superando DeepSeek-R1-Distill-Qwen-32B di 6 punti su BBEH

### Caratteristiche principali
- **Generazione scalabile di dati**: Sintesi illimitata con livelli di difficoltà controllabili
- **Copertura completa dei compiti**: 35 diversi compiti di ragionamento logico con generatori e verificatori personalizzati
- **Pronto per RL**: Tutti gli esempi possono essere verificati tramite regole semplici, rendendoli ideali per l'apprendimento per rinforzo
- **Trasferimento cross-domain**: Forte generalizzazione verso i domini matematici e di programmazione

## 🚀 Guida rapida

### Installazione
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### Genera dati di esempio (esempio Labirinto di Frecce)
```bash
# Esempio rapido con Labirinto di Frecce
bash games/tasks/arrow_maze/run.sh

# Oppure con parametri personalizzati
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### Per l'addestramento RL

Forniamo una guida completa per l'utilizzo dei dati SynLogic nell'addestramento tramite reinforcement learning. Consulta [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) per istruzioni dettagliate sull'integrazione di SynLogic con il framework Verl.

## :rocket: Risorse

### Dataset
| Nome Dataset | Descrizione | Link |
|:------------:|:------------|:----:|
| **SynLogic** | Dataset | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### Modelli


| Nome Modello | Descrizione | Link |
|:-----------|:------------|:----:|
| **SynLogic-7B** | Modello 7B addestrato su SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | Modello 32B addestrato su SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | Modello 32B addestrato su dati misti SynLogic, Math, Coding | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 Aggiornamenti futuri

Stiamo lavorando attivamente all'espansione di SynLogic con ulteriori compiti di ragionamento logico.

Segui il nostro repository per gli ultimi aggiornamenti e release!

## Citazione
Cita il nostro articolo se ritieni che il nostro lavoro sia utile:

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---