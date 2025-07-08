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

Este repositório contém o código e os dados do SynLogic, uma estrutura abrangente de síntese de dados para raciocínio lógico que gera dados de raciocínio diversos e verificáveis em larga escala. Nosso trabalho aborda a lacuna crítica de dados de treinamento de raciocínio lógico de alta qualidade para o desenvolvimento de capacidades gerais de raciocínio em Grandes Modelos de Linguagem (LLMs).

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## Novidades
- **[2025/07/07]** :fire: Fornecemos orientações para usar os dados do SynLogic em treinamentos de RL com o framework Verl. Veja [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) para detalhes.

- **[2025/06/03]** :fire: Modelos treinados lançados no Hugging Face:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: Estamos animados em liberar os recursos do artigo "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond"

## 📋 Visão Geral

**SynLogic** é uma estrutura de síntese de dados e um conjunto de dados abrangente que:
- 📊 **Cobre 35 tarefas diversas de raciocínio lógico** incluindo Sudoku, Jogo do 24, Cifra, Labirinto de Setas e mais
- 🎯 **Permite síntese com dificuldade controlável** com parâmetros ajustáveis para cada tarefa
- ✅ **Fornece recompensas verificáveis** por meio de verificação baseada em regras para treinamento em RL
- 🚀 **Alcança desempenho SOTA** entre os conjuntos de dados open-source, superando o DeepSeek-R1-Distill-Qwen-32B em 6 pontos no BBEH

### Características Principais
- **Geração Escalável de Dados**: Síntese ilimitada com níveis de dificuldade controláveis
- **Cobertura Abrangente de Tarefas**: 35 tarefas distintas de raciocínio lógico com geradores e verificadores personalizados
- **Pronto para RL**: Todos os exemplos podem ser verificados por regras simples, tornando-os ideais para aprendizado por reforço
- **Transferência Entre Domínios**: Forte generalização para domínios matemáticos e de programação

## 🚀 Início Rápido

### Instalação
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### Gerar Dados de Exemplo (Exemplo: Labirinto de Setas)
```bash
# Exemplo rápido com Labirinto de Setas
bash games/tasks/arrow_maze/run.sh

# Ou com parâmetros personalizados
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### Para Treinamento de RL

Fornecemos orientações completas para usar os dados do SynLogic em treinamentos de aprendizado por reforço. Veja [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) para instruções detalhadas sobre como integrar o SynLogic ao framework Verl.

## :rocket: Recursos

### Conjuntos de Dados
| Nome do Dataset | Descrição | Link |
|:---------------:|:----------|:----:|
| **SynLogic** | Conjunto de dados | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### Modelos


| Nome do Modelo | Descrição | Link |
|:--------------:|:----------|:----:|
| **SynLogic-7B** | Modelo 7B treinado no SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | Modelo 32B treinado no SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | Modelo 32B treinado com dados mistos de SynLogic, Matemática e Programação | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 Atualizações Futuras
Estamos trabalhando ativamente na expansão do SynLogic com mais tarefas de raciocínio lógico.

Siga nosso repositório para as últimas atualizações e lançamentos!

## Citação
Por favor, cite nosso artigo se você achar nosso trabalho útil:

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