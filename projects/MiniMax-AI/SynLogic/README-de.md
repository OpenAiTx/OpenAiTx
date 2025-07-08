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

Dieses Repository enthält den Code und die Daten für SynLogic, ein umfassendes Framework zur Synthese von logischen Schlussfolgerungsdaten, das vielfältige, überprüfbare Reasoning-Daten in großem Maßstab generiert. Unsere Arbeit adressiert die kritische Lücke an hochwertigen Trainingsdaten für logisches Schlussfolgern bei der Entwicklung allgemeiner Reasoning-Fähigkeiten in großen Sprachmodellen (LLMs).

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## Neuigkeiten
- **[2025/07/07]** :fire: Wir stellen eine Anleitung zur Verfügung, wie man SynLogic-Daten für RL-Training mit dem Verl-Framework nutzt. Details siehe [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md). 

- **[2025/06/03]** :fire: Trainierte Modelle auf Hugging Face veröffentlicht:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: Wir freuen uns, die Ressourcen zum Paper "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond" zu veröffentlichen.

## 📋 Übersicht

**SynLogic** ist ein Framework zur Datensynthese und ein umfassender Datensatz, der:
- 📊 **35 verschiedene Aufgaben des logischen Schlussfolgerns abdeckt**, einschließlich Sudoku, Game of 24, Chiffre, Pfeillabyrinth und mehr
- 🎯 **Kontrollierbare Schwierigkeitsgrade ermöglicht** mit einstellbaren Parametern für jede Aufgabe
- ✅ **Überprüfbare Belohnungen bietet** durch regelbasierte Verifikation für RL-Training
- 🚀 **SOTA-Leistung** unter Open-Source-Datensätzen erreicht und DeepSeek-R1-Distill-Qwen-32B um 6 Punkte bei BBEH übertrifft

### Hauptmerkmale
- **Skalierbare Datengenerierung**: Unbegrenzte Synthese mit steuerbaren Schwierigkeitsstufen
- **Umfassende Aufgabenabdeckung**: 35 verschiedene Aufgaben des logischen Schlussfolgerns mit individuellen Generatoren und Verifikatoren
- **RL-fähig**: Alle Beispiele können durch einfache Regeln verifiziert werden und sind daher ideal für Reinforcement Learning
- **Cross-Domain-Transfer**: Starke Generalisierung auf mathematische und Coding-Domänen

## 🚀 Schnellstart

### Installation
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### Beispieldaten generieren (Pfeillabyrinth-Beispiel)
```bash
# Kurzes Beispiel mit Arrow Maze
bash games/tasks/arrow_maze/run.sh

# Oder mit eigenen Parametern
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### Für RL-Training

Wir bieten eine umfassende Anleitung zur Verwendung der SynLogic-Daten im Reinforcement Learning Training. Siehe [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) für detaillierte Anweisungen zur Integration von SynLogic mit dem Verl-Framework.

## :rocket: Ressourcen

### Datensätze
| Dataset-Name | Beschreibung | Link |
|:------------:|:------------|:----:|
| **SynLogic** | Datensatz | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### Modelle


| Modellname | Beschreibung | Link |
|:-----------|:------------|:----:|
| **SynLogic-7B** | 7B-Modell, trainiert auf SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | 32B-Modell, trainiert auf SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | 32B-Modell, trainiert auf gemischten SynLogic-, Mathe- und Coding-Daten | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 Zukünftige Updates
Wir arbeiten aktiv daran, SynLogic um weitere Aufgaben des logischen Schließens zu erweitern.

Folgen Sie unserem Repository für die neuesten Updates und Veröffentlichungen!

## Zitation
Bitte zitieren Sie unsere Arbeit, wenn Sie sie hilfreich finden:

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