<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Link do Artigo</b>👁️</a>
</div>

## Índice

1. [Introdução](#1-introdução)
2. [Resumo do Modelo](#2-resumo-do-modelo)
3. [Downloads do Modelo](#3-downloads-do-modelo)
4. [Resultados de Avaliação](#4-resultados-de-avaliação)
5. [Website de Chat & Plataforma API](#5-website-de-chat--plataforma-api)
6. [Como Rodar Localmente](#6-como-rodar-localmente)
7. [Licença](#7-licença)
8. [Citação](#8-citação)
9. [Contato](#9-contato)


## 1. Introdução

Apresentamos o DeepSeek-V3, um poderoso modelo de linguagem Mixture-of-Experts (MoE) com 671B parâmetros totais e 37B ativados para cada token.
Para alcançar inferência eficiente e treinamento econômico, o DeepSeek-V3 adota as arquiteturas Multi-head Latent Attention (MLA) e DeepSeekMoE, que foram amplamente validadas no DeepSeek-V2.
Além disso, o DeepSeek-V3 é pioneiro em uma estratégia livre de perda auxiliar para balanceamento de carga e estabelece um objetivo de treinamento de predição multi-token para desempenho superior.
Pré-treinamos o DeepSeek-V3 em 14,8 trilhões de tokens diversos e de alta qualidade, seguido por etapas de Fine-Tuning Supervisionado e Aprendizado por Reforço para explorar totalmente suas capacidades.
Avaliações abrangentes revelam que o DeepSeek-V3 supera outros modelos open-source e alcança desempenho comparável aos principais modelos proprietários.
Apesar de seu excelente desempenho, o DeepSeek-V3 requer apenas 2.788M de horas-GPU H800 para o treinamento completo.
Além disso, seu processo de treinamento é notavelmente estável.
Durante todo o processo de treinamento, não experimentamos nenhum pico de perda irreversível nem realizamos rollback.
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. Resumo do Modelo

---

**Arquitetura: Estratégia Inovadora de Balanceamento de Carga e Objetivo de Treinamento**

- Com base na arquitetura eficiente do DeepSeek-V2, somos pioneiros em uma estratégia livre de perda auxiliar para o balanceamento de carga, minimizando a degradação de desempenho que surge ao incentivar o balanceamento.
- Investigamos um objetivo de Predição Multi-Token (MTP) e provamos ser benéfico para o desempenho do modelo.
    Também pode ser usado para decodificação especulativa visando aceleração de inferência.

---

**Pré-Treinamento: Rumo à Eficiência Máxima de Treinamento**

- Projetamos um framework de treinamento de precisão mista FP8 e, pela primeira vez, validamos a viabilidade e eficácia do treinamento em FP8 em um modelo de escala extremamente grande.
- Por meio do co-design de algoritmos, frameworks e hardware, superamos o gargalo de comunicação no treinamento MoE entre nós, quase atingindo a sobreposição total de computação-comunicação.
  Isso aumenta significativamente a eficiência do nosso treinamento e reduz os custos, permitindo ampliar ainda mais o tamanho do modelo sem custos adicionais.
- A um custo econômico de apenas 2.664M horas-GPU H800, completamos o pré-treinamento do DeepSeek-V3 em 14,8T tokens, produzindo o mais forte modelo base open-source atualmente. As etapas subsequentes após o pré-treinamento requerem apenas 0,1M horas-GPU.

---

**Pós-Treinamento: Destilação de Conhecimento do DeepSeek-R1**

- Introduzimos uma metodologia inovadora para destilar capacidades de raciocínio de um modelo long-Chain-of-Thought (CoT), especificamente de um dos modelos da série DeepSeek R1, para LLMs padrão, em especial ao DeepSeek-V3. Nosso pipeline incorpora elegantemente os padrões de verificação e reflexão do R1 no DeepSeek-V3 e melhora notavelmente seu desempenho em raciocínio. Ao mesmo tempo, mantemos controle sobre o estilo e o comprimento da saída do DeepSeek-V3.

---


## 3. Downloads do Modelo

<div align="center">

| **Modelo** | **#Parâmetros Totais** | **#Parâmetros Ativados** | **Comprimento do Contexto** | **Download** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTA]
> O tamanho total dos modelos DeepSeek-V3 no Hugging Face é 685B, que inclui 671B dos pesos do Modelo Principal e 14B dos pesos do Módulo de Predição Multi-Token (MTP).

Para garantir desempenho e flexibilidade ideais, firmamos parcerias com comunidades open-source e fornecedores de hardware para fornecer diversas formas de rodar o modelo localmente. Para um guia passo a passo, veja a Seção 6: [Como Rodar Localmente](#6-como-rodar-localmente).

Para desenvolvedores que desejam se aprofundar, recomendamos explorar o [README_WEIGHTS.md](./README_WEIGHTS.md) para detalhes sobre os pesos do Modelo Principal e dos Módulos MTP. Observe que o suporte ao MTP está atualmente em desenvolvimento ativo na comunidade, e suas contribuições e feedback são bem-vindos.

## 4. Resultados de Avaliação
### Modelo Base
#### Benchmarks Padrão

<div align="center">


|  | Benchmark (Métrica) | # Shots | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | Arquitetura | - | MoE | Denso | Denso | MoE |
| | # Parâmetros Ativados | - | 21B | 72B | 405B | 37B |
| | # Parâmetros Totais | - | 236B | 72B | 405B | 671B |
| Inglês | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Acc.) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Acc.) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Acc.) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Acc.) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Acc.) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Acc.) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Acc.) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Acc.) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (Acc.) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (Acc.) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Acc.) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| Código | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Acc.) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Acc.) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| Matemática | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| Chinês | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Acc.) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Acc.) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Acc.) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Acc.) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| Multilíngue | MMMLU-non-English (Acc.) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTA]
> Os melhores resultados estão em negrito. Pontuações com diferença não superior a 0,3 são consideradas do mesmo nível. O DeepSeek-V3 atinge o melhor desempenho na maioria dos benchmarks, especialmente em tarefas de matemática e código.
> Para mais detalhes de avaliação, consulte nosso artigo.

#### Janela de Contexto
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

Resultados de avaliação nos testes ``Needle In A Haystack`` (NIAH). O DeepSeek-V3 apresenta bom desempenho em todos os comprimentos de janela de contexto até **128K**.

### Modelo de Chat
#### Benchmarks Padrão (Modelos maiores que 67B)
<div align="center">

| | **Benchmark (Métrica)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | Arquitetura | MoE | MoE | Denso | Denso | - | - | MoE |
| | # Parâmetros Ativados | 21B | 21B | 72B | 405B | - | - | 37B |
| | # Parâmetros Totais | 236B | 236B | 72B | 405B | - | - | 671B |
| Inglês | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correct) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Acc.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Acc.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| Código | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Percentil) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Resolvido) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Acc.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Acc.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| Matemática | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| Chinês | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Correct) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTA]
> Todos os modelos são avaliados em uma configuração que limita o comprimento da saída a 8K. Benchmarks com menos de 1000 amostras são testados várias vezes com diferentes configurações de temperatura para obter resultados finais robustos. O DeepSeek-V3 é o modelo open-source com melhor desempenho, e também apresenta desempenho competitivo frente aos modelos proprietários de ponta.


####  Avaliação de Geração Aberta

<div align="center">



| Modelo | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!NOTA]
> Avaliações de conversação aberta em inglês. Para o AlpacaEval 2.0, usamos como métrica a taxa de vitória com controle de comprimento.


## 5. Website de Chat & Plataforma API
Você pode conversar com o DeepSeek-V3 no site oficial do DeepSeek: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

Também fornecemos API compatível com OpenAI na Plataforma DeepSeek: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Como Rodar Localmente

O DeepSeek-V3 pode ser implantado localmente utilizando o seguinte hardware e softwares da comunidade open-source:

1. **DeepSeek-Infer Demo**: Fornecemos um demo simples e leve para inferência FP8 e BF16.
2. **SGLang**: Suporte total ao modelo DeepSeek-V3 nos modos de inferência BF16 e FP8, com Predição Multi-Token [em breve](https://github.com/sgl-project/sglang/issues/2591).
3. **LMDeploy**: Permite inferência eficiente em FP8 e BF16 para implantação local e em nuvem.
4. **TensorRT-LLM**: Atualmente suporta inferência BF16 e quantização INT4/8, com suporte FP8 em breve.
5. **vLLM**: Suporta o modelo DeepSeek-V3 com modos FP8 e BF16 para paralelismo de tensores e pipeline.
6. **LightLLM**: Suporta implantação eficiente em nó único ou múltiplos nós para FP8 e BF16.
7. **AMD GPU**: Permite rodar o modelo DeepSeek-V3 em GPUs AMD via SGLang em modos BF16 e FP8.
8. **Huawei Ascend NPU**: Suporta rodar o DeepSeek-V3 em dispositivos Huawei Ascend.

Como o treinamento FP8 é adotado nativamente em nosso framework, fornecemos apenas pesos FP8. Se você precisar de pesos BF16 para experimentação, pode usar o script de conversão fornecido para realizar a transformação.

Aqui está um exemplo de conversão de pesos FP8 para BF16:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!NOTA]
> O Transformers do Hugging Face ainda não é suportado diretamente.

### 6.1 Inferência com DeepSeek-Infer Demo (apenas exemplo)

#### Requisitos de Sistema

> [!NOTA] 
> Apenas Linux com Python 3.10. Mac e Windows não são suportados.

Dependências:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### Preparação dos Pesos do Modelo & Código Demo

Primeiro, clone o repositório DeepSeek-V3 do GitHub:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

Navegue até a pasta `inference` e instale as dependências listadas em `requirements.txt`. A forma mais fácil é usar um gerenciador como `conda` ou `uv` para criar um novo ambiente virtual e instalar as dependências.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

Baixe os pesos do modelo no Hugging Face e coloque-os na pasta `/path/to/DeepSeek-V3`.

#### Conversão dos Pesos do Modelo

Converta os pesos do modelo Hugging Face para um formato específico:

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### Execução

Agora você pode conversar com o DeepSeek-V3:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

Ou realizar inferência em lote sobre um arquivo:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 Inferência com SGLang (recomendado)

O [SGLang](https://github.com/sgl-project/sglang) atualmente suporta [otimizações MLA](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8 (W8A8), FP8 KV Cache, e Torch Compile, entregando latência e throughput de ponta entre frameworks open-source.

Notavelmente, o [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) suporta totalmente rodar o DeepSeek-V3 tanto em **GPUs NVIDIA quanto AMD**, tornando-o uma solução versátil e robusta.

O SGLang também suporta [paralelismo de tensores multi-nó](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208), permitindo rodar este modelo em múltiplas máquinas conectadas em rede.

A Predição Multi-Token (MTP) está em desenvolvimento, e o progresso pode ser acompanhado no [plano de otimização](https://github.com/sgl-project/sglang/issues/2591).

Aqui estão as instruções de execução do time SGLang: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 Inferência com LMDeploy (recomendado)
[LMDeploy](https://github.com/InternLM/lmdeploy), um framework flexível e de alto desempenho para inferência e serving de grandes modelos de linguagem, agora suporta o DeepSeek-V3. Oferece tanto processamento offline quanto implantação online, integrando-se facilmente a workflows baseados em PyTorch.

Para instruções detalhadas de execução do DeepSeek-V3 com LMDeploy, consulte: https://github.com/InternLM/lmdeploy/issues/2960


### 6.4 Inferência com TRT-LLM (recomendado)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) agora suporta o modelo DeepSeek-V3, oferecendo opções de precisão como BF16 e INT4/INT8 apenas para pesos. O suporte a FP8 está em andamento e será lançado em breve. Você pode acessar o branch customizado do TRTLLM para suporte específico ao DeepSeek-V3 pelo seguinte link: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3.


### 6.5 Inferência com vLLM (recomendado)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6 suporta inferência DeepSeek-V3 nos modos FP8 e BF16 tanto em GPUs NVIDIA quanto AMD. Além das técnicas padrão, o vLLM oferece _pipeline parallelism_ permitindo rodar este modelo em múltiplas máquinas conectadas em rede. Para orientações detalhadas, consulte as [instruções do vLLM](https://docs.vllm.ai/en/latest/serving/distributed_serving.html). Acompanhe também o [plano de aprimoramento](https://github.com/vllm-project/vllm/issues/11539).

### 6.6 Inferência com LightLLM (recomendado)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 suporta implantação tensor paralela em máquina única e múltiplas máquinas para DeepSeek-R1 (FP8/BF16) e oferece implantação em precisão mista, com mais modos de quantização continuamente integrados. Para mais detalhes, consulte as [instruções do LightLLM](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html). Além disso, o LightLLM oferece implantação PD-disaggregation para o DeepSeek-V2, e a implementação para o DeepSeek-V3 está em desenvolvimento.

### 6.7 Inferência Recomendada com GPUs AMD

Em colaboração com a equipe AMD, alcançamos suporte Day-One para GPUs AMD usando SGLang, com compatibilidade total para precisão FP8 e BF16. Para orientações detalhadas, consulte as [instruções do SGLang](#63-inference-with-lmdeploy-recommended).

### 6.8 Inferência Recomendada com NPUs Huawei Ascend
O framework [MindIE](https://www.hiascend.com/en/software/mindie) da comunidade Huawei Ascend adaptou com sucesso a versão BF16 do DeepSeek-V3. Para um guia passo a passo em NPUs Ascend, siga as [instruções aqui](https://modelers.cn/models/MindIE/deepseekv3).


## 7. Licença
Este repositório de código é licenciado sob [a Licença MIT](LICENSE-CODE). O uso dos modelos DeepSeek-V3 Base/Chat está sujeito à [Licença do Modelo](LICENSE-MODEL). A série DeepSeek-V3 (incluindo Base e Chat) suporta uso comercial.

## 8. Citação
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. Contato
Se você tiver dúvidas, abra uma issue ou entre em contato em [service@deepseek.com](service@deepseek.com).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---