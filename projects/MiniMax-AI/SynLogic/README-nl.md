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

Deze repository bevat de code en data voor SynLogic, een uitgebreid data-synthese framework voor logisch redeneren dat diverse, verifieerbare redeneerdata op schaal genereert. Ons werk adresseert het kritieke tekort aan hoogwaardige trainingsdata voor logisch redeneren, essentieel voor het ontwikkelen van algemene redeneercapaciteiten in Large Language Models (LLMs).

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## Nieuws
- **[2025/07/07]** :fire: We bieden een handleiding voor het gebruik van SynLogic-data voor RL-training met het Verl-framework. Zie [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) voor meer details. 

- **[2025/06/03]** :fire: Getrainde modellen vrijgegeven op Hugging Face:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: We zijn enthousiast om de resources vrij te geven voor het artikel "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond"

## 📋 Overzicht

**SynLogic** is een data-syntheseframework en uitgebreide dataset die:
- 📊 **35 diverse logisch-redeneertaken omvat** waaronder Sudoku, Game of 24, Cipher, Arrow Maze en meer
- 🎯 **Controleerbare moeilijkheidsgraad mogelijk maakt** met aanpasbare parameters per taak
- ✅ **Verifieerbare beloningen biedt** via regelgebaseerde verificatie voor RL-training
- 🚀 **SOTA-prestaties behaalt** onder open-source datasets, en DeepSeek-R1-Distill-Qwen-32B met 6 punten overtreft op BBEH

### Belangrijkste Kenmerken
- **Schaalbare datageneratie**: Onbeperkte synthese met instelbare moeilijkheidsniveaus
- **Uitgebreide taakdekking**: 35 verschillende logisch-redeneertaken met eigen generators en verifiers
- **RL-Klaar**: Alle voorbeelden zijn verifieerbaar via eenvoudige regels, ideaal voor reinforcement learning
- **Cross-Domein Transfer**: Sterke generalisatie naar wiskunde- en codeerdomeinen

## 🚀 Snelstart

### Installatie
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### Genereer Voorbeelddata (Arrow Maze Voorbeeld)
```bash
# Snel voorbeeld met Arrow Maze
bash games/tasks/arrow_maze/run.sh

# Of met aangepaste parameters
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### Voor RL-Training

We bieden uitgebreide instructies voor het gebruik van SynLogic-data bij reinforcement learning training. Zie [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) voor gedetailleerde instructies over integratie van SynLogic met het Verl-framework.

## :rocket: Resources

### Datasets
| Datasetnaam | Beschrijving | Link |
|:------------:|:------------|:----:|
| **SynLogic** | Dataset | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### Modellen


| Modelnaam | Beschrijving | Link |
|:-----------|:------------|:----:|
| **SynLogic-7B** | 7B-model getraind op SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | 32B-model getraind op SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | 32B-model getraind op gemixte SynLogic-, Wiskunde- en Codeerdata | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 Toekomstige Updates
We werken actief aan het uitbreiden van SynLogic met meer logische redeneertaken.

Volg onze repository voor de laatste updates en releases!

## Referentie
Citeer ons paper als u ons werk nuttig vindt:

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