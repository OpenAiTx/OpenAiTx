![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/title.png)

## Conjunto de Dados
> 📦 **[👉 Acesse o conjunto de dados completo do ChartGalaxy no Hugging Face! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

Devido a limitações de armazenamento, incluímos apenas uma coleção de exemplos representativos.  
Este repositório contém o código associado ao artigo "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation".

## 🔥 Novidades
**2025.5**:  🎉🎉 Lançamos a primeira versão do nosso conjunto de dados, que inclui 1.151.087 gráficos infográficos sintéticos e 104.519 reais, cobrindo 75 tipos de gráficos e 330 variações.

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/teaser.png" style="border:none;box-shadow:none;">

![Imagem de exemplos](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/examples.png)

<!-- ## 🔔 News -->

## Introdução

### Sobre

ChartGalaxy é um conjunto de dados em escala de milhões de gráficos infográficos sintéticos e reais com tabelas de dados, suportando aplicações em compreensão de gráficos infográficos, geração de código e geração de gráficos. O conjunto de dados aborda o desafio de que os conjuntos existentes são, em sua maioria, limitados a gráficos simples, não capturando a diversidade de estilos de design e layouts que são características-chave dos gráficos infográficos.

### Estatísticas

- **Tamanho**: 1.255.606 gráficos infográficos (1.151.087 sintéticos + 104.519 reais)
- **Conteúdo**: Cada gráfico infográfico é emparelhado com a tabela de dados utilizada para criá-lo
- **Tipos de Gráfico**: 75 tipos de gráficos com 330 variações
- **Modelos de Layout**: 68 modelos de layout

### Coleta e Criação de Dados

O ChartGalaxy foi construído através de:

1. **Coleta de Gráficos Infográficos Reais**: Gráficos foram coletados de 19 sites conceituados ricos em gráficos, como Pinterest, Visual Capitalist, Statista e Information is Beautiful.

2. **Criação de Gráficos Infográficos Sintéticos**: Seguindo um processo de estruturação indutiva que:
   - Identifica 75 tipos de gráficos (ex.: gráficos de barras) e 330 variações refletindo diferentes estilos de elementos visuais
   - Extrai 68 modelos de layout definindo relações espaciais entre os elementos
   - Gera programaticamente gráficos sintéticos baseados nesses padrões

## 🎯 Aplicações

A utilidade do ChartGalaxy é demonstrada por meio de três aplicações representativas:

### 1. 🧠 Compreensão de Gráficos Infográficos

O fine-tuning no ChartGalaxy melhora o desempenho de modelos fundacionais na compreensão de gráficos infográficos.

### 2. 💻 Geração de Código para Gráficos Infográficos

Um benchmark para avaliação da geração de código de LVLMs para gráficos infográficos. O benchmark avalia a similaridade entre os gráficos renderizados pelo código D3.js gerado e os de referência em dois níveis de granularidade: alto nível (similaridade visual geral) e baixo nível (similaridade média entre elementos SVG detalhados).

#### Visão Geral

O benchmark avalia a geração de código de gráficos em dois níveis:
- **Baixo nível**: Similaridade elemento a elemento entre SVGs gerados e de referência
- **Alto nível**: Avaliação da fidelidade visual geral e funcionalidade

#### Instalação

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### Uso

1. Configure as definições em `code_generation_benchmark/configs/default_config.yaml`:
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # Descomente os modelos que deseja avaliar
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. Execute o benchmark:
   ```bash
   python main.py
   ```

#### Estrutura dos Dados

Cada pasta de gráfico em `data_root_dir` deve conter:
- `chart.svg`: Gráfico original em formato SVG

O sistema irá gerar:
- `convert_chart.html`: Renderização em HTML do gráfico de referência
- `convert_chart.png`: Captura de tela em PNG do gráfico de referência
- `convert_chart.json`: Estrutura dos elementos do gráfico de referência
- Saídas específicas de cada modelo em subpastas

#### Resultados

Os resultados são salvos em subpastas específicas de cada modelo com:
- Renderizações em HTML/PNG geradas
- Métricas de avaliação em formato JSON
- Logs detalhados em `log_dir`
  

### 3. 🖼️ Geração de Gráfico Infográfico Baseada em Exemplo

Um método baseado em exemplos que transforma dados tabulares fornecidos pelo usuário em um gráfico infográfico, alinhando-se ao layout e estilo visual de um gráfico de exemplo dado. Estudos com usuários mostram que este método supera o GPT-Image-1 em fidelidade, estética e criatividade.


## Contato
- chartgalaxy@163.com

## Links dos Artigos

### 📌 Artigo Principal (Este Repositório)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### Artigos Relacionados

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 Citação
Se você utilizar o ChartGalaxy em sua pesquisa, por favor cite:
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---