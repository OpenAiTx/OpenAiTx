<div align="center">

Megatron-LM & Megatron-Core
===========================
<h4>Técnicas otimizadas para GPU para treinamento de modelos transformer em escala</h4>

[![Documentação](https://img.shields.io/badge/docs-latest-brightgreen.svg?style=flat)](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html)
[![versão](https://img.shields.io/badge/release-0.5.0-green)](./setup.py)
[![licença](https://img.shields.io/badge/license-OpenBSD-blue)](./LICENSE)

<div align="left">

# Últimas Notícias

- **[2024/7]** Megatron-Core v0.7 melhora a escalabilidade e resiliência do treinamento e adiciona suporte para treinamento multimodal ([blog](https://developer.nvidia.com/blog/train-generative-ai-models-more-efficiently-with-new-nvidia-megatron-core-functionalities/)).
- **[2024/6]** Megatron-Core adicionou suporte para modelos baseados em Mamba. Confira nosso artigo [An Empirical Study of Mamba-based Language Models](https://arxiv.org/pdf/2406.07887) e [exemplo de código](https://github.com/NVIDIA/Megatron-LM/tree/ssm/examples/mamba).
- **[2024/1 Anúncio]** A NVIDIA lançou as capacidades principais do **Megatron-LM** em [**Megatron-Core**](https://github.com/NVIDIA/Megatron-LM/tree/main/megatron/core) neste repositório. Megatron-Core expande as técnicas otimizadas para GPU do Megatron-LM com inovações de ponta em otimizações de nível de sistema, apresentando APIs modulares e compostáveis. Explore a [introdução ao Megatron-Core](#megatron-core) para mais detalhes.

# Índice

- [Megatron-LM \& Megatron-Core](#megatron-lm--megatron-core)
- [Últimas Notícias](#ultimas-noticias)
- [Índice](#indice)
- [Visão Geral do Megatron](#visao-geral-do-megatron)
  - [Megatron-LM](#megatron-lm)
  - [Megatron-Core](#megatron-core)
- [Velocidade de Treinamento e Escalabilidade](#velocidade-de-treinamento-e-escalabilidade)
- [Configuração](#configuracao)
  - [Docker (Recomendado)](#docker-recomendado)
  - [Opções de Instalação](#opcoes-de-instalacao)
    - [Instalar via PyPI](#instalar-via-pypi)
    - [Instalar a partir do código-fonte](#instalar-a-partir-do-codigo-fonte)
  - [Pré-requisitos](#pre-requisitos)
  - [Baixando Checkpoints](#baixando-checkpoints)
- [Uso](#uso)
- [Treinamento](#treinamento)
  - [Pré-processamento de Dados](#pre-processamento-de-dados)
  - [Pré-treinamento BERT](#pre-treinamento-bert)
  - [Pré-treinamento GPT](#pre-treinamento-gpt)
  - [Pré-treinamento T5](#pre-treinamento-t5)
  - [Pré-treinamento Distribuído](#pre-treinamento-distribuido)
  - [Checkpointing de Ativação e Recomputação](#checkpointing-de-ativacao-e-recomputacao)
  - [Otimizador Distribuído](#otimizador-distribuido)
  - [FlashAttention](#flashattention)
  - [Exemplo GPT-3](#exemplo-gpt-3)
  - [Retro e InstructRetro](#retro-e-instructretro)
  - [Modelos de Linguagem baseados em Mamba](#modelos-de-linguagem-baseados-em-mamba)
  - [Mistura de Especialistas (Mixture of Experts)](#mistura-de-especialistas)
- [Avaliação e Tarefas](#avaliacao-e-tarefas)
  - [Geração de Texto GPT](#geracao-de-texto-gpt)
    - [Desintoxicar GPT via Auto-Geração](#desintoxicar-gpt-via-auto-geracao)
  - [Avaliação GPT](#avaliacao-gpt)
    - [Avaliação de Perplexidade WikiText](#avaliacao-de-perplexidade-wikitext)
    - [Acurácia Cloze LAMBADA](#acuracia-cloze-lambada)
  - [Avaliação de Tarefas BERT](#avaliacao-de-tarefas-bert)
    - [Avaliação RACE](#avaliacao-race)
    - [Avaliação MNLI](#avaliacao-mnli)
  - [Inferência e Ajuste Fino Llama-2](#inferencia-e-ajuste-fino-llama-2)
- [Otimização e Implantação de Modelos](#otimizacao-e-implantacao-de-modelos)
  - [Quantização e Implantação com TensorRT-LLM](#quantizacao-e-implantacao-com-tensorrt-llm)
- [Conjuntos de Dados](#conjuntos-de-dados)
  - [Coletando Dados de Treinamento da Wikipedia](#coletando-dados-de-treinamento-da-wikipedia)
  - [Coletando Dados GPT Webtext](#coletando-dados-gpt-webtext)
- [Reprodutibilidade](#reprodutibilidade)
- [Conversão de Checkpoint](#conversao-de-checkpoint)
  - [Conversão de Classe de Modelo](#conversao-de-classe-de-modelo)
  - [Conversão de Formato de Checkpoint](#conversao-de-formato-de-checkpoint)
- [Projetos que Usam Megatron](#projetos-que-usam-megatron)

# Visão Geral do Megatron
Este repositório compreende dois componentes essenciais: **Megatron-LM** e **Megatron-Core**. O Megatron-LM serve como uma estrutura orientada à pesquisa, utilizando o Megatron-Core para treinamento de grandes modelos de linguagem (LLM). O Megatron-Core, por sua vez, é uma biblioteca de técnicas de treinamento otimizadas para GPU que conta com suporte formal de produto, incluindo APIs versionadas e lançamentos regulares. Você pode usar o Megatron-Core junto com o Megatron-LM ou com o [Nvidia NeMo Framework](https://docs.nvidia.com/deeplearning/nemo/user-guide/docs/en/main/nlp/nemo_megatron/mcore_customization.html) para uma solução completa e nativa em nuvem. Alternativamente, é possível integrar os blocos de construção do Megatron-Core ao seu framework de treinamento preferido.

## Megatron-LM
Apresentado pela primeira vez em 2019, Megatron ([1](https://arxiv.org/pdf/1909.08053.pdf), [2](https://arxiv.org/pdf/2104.04473.pdf) e [3](https://arxiv.org/pdf/2205.05198)) impulsionou uma onda de inovação na comunidade de IA, permitindo que pesquisadores e desenvolvedores utilizassem os fundamentos desta biblioteca para avançar nos LLMs. Atualmente, muitos dos frameworks de desenvolvimento LLM mais populares foram inspirados e construídos diretamente com base na biblioteca open-source Megatron-LM, estimulando uma onda de modelos fundacionais e startups de IA. Alguns dos frameworks LLM mais populares construídos sobre o Megatron-LM incluem [Colossal-AI](https://github.com/hpcaitech/ColossalAI), [HuggingFace Accelerate](https://github.com/huggingface/accelerate) e [NVIDIA NeMo Framework](https://www.nvidia.com/en-us/ai-data-science/generative-ai/nemo-framework/). Uma lista de projetos que utilizaram diretamente o Megatron pode ser encontrada [aqui](#projetos-que-usam-megatron).

## Megatron-Core
Megatron-Core é uma biblioteca open-source baseada em PyTorch que contém técnicas otimizadas para GPU e otimizações avançadas de nível de sistema. Ela abstrai essas técnicas em APIs compostáveis e modulares, permitindo flexibilidade total para desenvolvedores e pesquisadores de modelos treinarem transformers customizados em larga escala na infraestrutura de computação acelerada NVIDIA. Esta biblioteca é compatível com todas as GPUs NVIDIA Tensor Core, incluindo suporte para aceleração FP8 em [arquiteturas NVIDIA Hopper](https://www.nvidia.com/en-us/data-center/technologies/hopper-architecture/).

O Megatron-Core oferece blocos de construção essenciais, como mecanismos de atenção, blocos e camadas transformer, camadas de normalização e técnicas de embedding. Funcionalidades adicionais, como recomputação de ativação e checkpointing distribuído, também estão integradas nativamente à biblioteca. Todos os blocos de construção e funcionalidades são otimizados para GPU e podem ser construídos com estratégias avançadas de paralelização para máxima velocidade e estabilidade de treinamento na Infraestrutura de Computação Acelerada da NVIDIA. Outro componente-chave da biblioteca Megatron-Core inclui técnicas avançadas de paralelismo de modelo (tensor, sequência, pipeline, contexto e paralelismo de especialistas MoE).

O Megatron-Core pode ser usado com o [NVIDIA NeMo](https://www.nvidia.com/en-us/ai-data-science/products/nemo/), uma plataforma de IA de nível empresarial. Alternativamente, você pode explorar o Megatron-Core com o loop de treinamento nativo PyTorch [aqui](https://github.com/NVIDIA/Megatron-LM/tree/main/examples). Visite a [documentação Megatron-Core](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html) para saber mais.

# Velocidade de Treinamento e Escalabilidade
Nosso código é capaz de treinar modelos de linguagem grandes de forma eficiente (ou seja, modelos com centenas de bilhões de parâmetros) com paralelismo de modelo e de dados. Para demonstrar como nosso software escala com múltiplas GPUs e tamanhos de modelo, consideramos modelos GPT variando de 2 bilhões a 462 bilhões de parâmetros. Todos os modelos usam um vocabulário de 131.072 e comprimento de sequência de 4096. Variamos o tamanho do hidden, número de cabeças de atenção e número de camadas para chegar a um tamanho de modelo específico. À medida que o modelo aumenta, também aumentamos modestamente o tamanho do batch. Nossos experimentos usam até 6144 GPUs [H100](https://www.nvidia.com/en-us/data-center/h100/). Realizamos sobreposição de comunicação data-parallel (`--overlap-grad-reduce --overlap-param-gather`), tensor-parallel (`--tp-comm-overlap`) e pipeline-parallel (ativado por padrão) com computação para melhorar a escalabilidade. As taxas de transferência reportadas são medidas para treinamento de ponta a ponta e incluem todas as operações, como carregamento de dados, etapas do otimizador, comunicação e até logging. Observe que não treinamos esses modelos até a convergência.

![Tabela de modelos](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/images/model_table.png)

Nossos resultados de weak scaling mostram escalabilidade superlinear (MFU aumenta de 41% para o menor modelo considerado até 47-48% para os maiores); isso ocorre porque GEMMs maiores têm maior intensidade aritmética e, consequentemente, são mais eficientes de executar.

![Weak scaling](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/images/weak_scaling.png)

Também realizamos strong scaling do modelo GPT-3 padrão (nossa versão tem um pouco mais de 175 bilhões de parâmetros devido ao tamanho maior do vocabulário) de 96 GPUs H100 para 4608 GPUs, usando o mesmo batch de 1152 sequências durante todo o experimento. A comunicação torna-se mais evidente em grande escala, levando a uma redução do MFU de 47% para 42%.

![Strong scaling](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/images/strong_scaling.png)

# Configuração

## Docker (Recomendado)

Recomendamos fortemente o uso da versão anterior do [PyTorch NGC Container](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/pytorch) em vez da mais recente. Nossos lançamentos são sempre baseados no container NGC do mês anterior, o que garante compatibilidade e estabilidade. Este container já vem com todas as dependências pré-instaladas com versões compatíveis e configurações otimizadas para GPUs NVIDIA.

```bash
# Baixe o container NGC do mês anterior (substitua 25.04 pela versão do mês anterior)
docker pull nvcr.io/nvidia/pytorch:25.04-py3
```

```bash
# Execute o container com diretórios montados
docker run --gpus all -it --rm \
  -v /path/to/megatron:/workspace/megatron \
  -v /path/to/dataset:/workspace/dataset \
  -v /path/to/checkpoints:/workspace/checkpoints \
  nvcr.io/nvidia/pytorch:25.04-py3
```

## Opções de Instalação

### Pré-requisitos

- PyTorch (versão estável mais recente)
- CUDA, cuDNN, NCCL (versões estáveis mais recentes)
- Suporte para FP8 em GPUs NVIDIA Hopper, Ada e Blackwell
- Para melhor desempenho, utilize GPUs a partir da geração NVIDIA Turing

### Instalar via PyPI

Para instalar a versão estável mais recente com pip:

```bash
# Instale a versão mais recente
pip install megatron-core
```

### Instalar a partir do código-fonte

```bash
# Clone o repositório
git clone https://github.com/NVIDIA/Megatron-LM.git
cd Megatron-LM

# Opcionalmente, troque para um release específico
git checkout v0.11.0

# Instale em modo desenvolvimento
pip install -e .
```

## Baixando Checkpoints
Disponibilizamos checkpoints pré-treinados do [BERT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_bert_345m) e [GPT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_lm_345m) para avaliação ou ajuste fino em tarefas downstream. Para acessar esses checkpoints, primeiro [cadastre-se](https://ngc.nvidia.com/signup) e [configure](https://ngc.nvidia.com/setup/installers/cli) o CLI do NVIDIA GPU Cloud (NGC) Registry. Mais informações para download de modelos podem ser encontradas na [documentação NGC](https://docs.nvidia.com/dgx/ngc-registry-cli-user-guide/index.html#topic_6_4_1).

Alternativamente, você pode baixar diretamente os checkpoints usando:

<pre>
BERT-345M-uncased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_uncased/zip -O megatron_bert_345m_v0.1_uncased.zip
BERT-345M-cased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_cased/zip -O megatron_bert_345m_v0.1_cased.zip
GPT-345M: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_lm_345m/versions/v0.0/zip -O megatron_lm_345m_v0.0.zip
</pre>

Os modelos requerem arquivos de vocabulário para funcionar. O arquivo de vocabulário WordPiece do BERT pode ser extraído dos modelos BERT pré-treinados do Google: [uncased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-uncased-vocab.txt), [cased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-cased-vocab.txt). O [arquivo de vocabulário do GPT](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-vocab.json) e a [tabela de mesclagem](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-merges.txt) podem ser baixados diretamente.

# Uso

Após a instalação, existem vários fluxos de trabalho possíveis. O mais completo é:
1. Pré-processamento de dados
2. Pré-treinamento
3. Ajuste fino (Opcional para tarefas zero-shot)
4. Avaliação de tarefas downstream ou geração de texto

No entanto, os passos 1 e 2 podem ser substituídos pelo uso de um dos modelos pré-treinados mencionados acima.

Fornecemos vários scripts para pré-treinamento tanto do BERT quanto do GPT no diretório [`examples`](./examples), além de scripts para tarefas downstream zero-shot e fine-tuned incluindo avaliações MNLI, RACE, WikiText103 e LAMBADA. Há também um script para geração de texto interativa com GPT.

# Treinamento
## Pré-processamento de Dados
Os dados de treinamento exigem pré-processamento. Primeiro, coloque seus dados de treinamento em formato json solto, com um json contendo uma amostra de texto por linha. Por exemplo:
<pre>
{"src": "www.nvidia.com", "text": "The quick brown fox", "type": "Eng", "id": "0", "title": "First Part"}
{"src": "The Internet", "text": "jumps over the lazy dog", "type": "Eng", "id": "42", "title": "Second Part"}
</pre>

O nome do campo `text` do json pode ser alterado usando o parâmetro `--json-key` em [`preprocess_data.py`](./tools/preprocess_data.py). Os outros metadados são opcionais e não são usados no treinamento.

O json solto é então processado para um formato binário para treinamento. Para converter o json para o formato mmap, use o `preprocess_data.py`. Um exemplo de script para preparar dados para treinamento BERT é:
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-bert \
       --vocab-file bert-vocab.txt \
       --tokenizer-type BertWordPieceLowerCase \
       --split-sentences
</pre>

A saída serão dois arquivos nomeados, neste caso, `my-bert_text_sentence.bin` e `my-bert_text_sentence.idx`. O `--data-path` especificado posteriormente no treinamento BERT é o caminho completo e o novo nome do arquivo, mas sem a extensão.

Para T5 use o mesmo pré-processamento do BERT, talvez renomeando para:
<pre>
       --output-prefix my-t5 \
</pre>
Algumas pequenas modificações são necessárias para o pré-processamento de dados do GPT, nomeadamente, a adição de uma tabela de mesclagem, um token de fim de documento, remoção da divisão de sentenças e uma alteração no tipo de tokenizador:
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-gpt2 \
       --vocab-file gpt2-vocab.json \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file gpt2-merges.txt \
       --append-eod
</pre>

Aqui, os arquivos de saída são nomeados como `my-gpt2_text_document.bin` e `my-gpt2_text_document.idx`. Como antes, no treinamento GPT, utilize o nome mais longo sem a extensão como `--data-path`.

Outros argumentos de linha de comando são descritos no arquivo fonte [`preprocess_data.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/preprocess_data.py).

## Pré-treinamento BERT

O script [`examples/bert/train_bert_340m_distributed.sh`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/bert/train_bert_340m_distributed.sh) executa o pré-treinamento BERT de 345M parâmetros em uma única GPU. O uso principal do treinamento em GPU única é para depuração, já que a base de código e os argumentos de linha de comando são otimizados para treinamento altamente distribuído. A maioria dos argumentos é bastante autoexplicativa. Por padrão, a taxa de aprendizado decai linearmente ao longo das iterações de treinamento, começando em `--lr` até um mínimo definido por `--min-lr` durante `--lr-decay-iters` iterações. A fração de iterações de treinamento usada para aquecimento é definida por `--lr-warmup-fraction`. Embora este seja um treinamento em GPU única, o tamanho do lote especificado por `--micro-batch-size` é o tamanho do lote de um único caminho de forward-backward, e o código irá acumular gradientes até atingir o `global-batch-size`, que é o tamanho do lote por iteração. Os dados são particionados em uma proporção 949:50:1 para conjuntos de treinamento/validação/teste (o padrão é 969:30:1). Essa partição acontece dinamicamente, mas é consistente entre execuções com a mesma semente aleatória (1234 por padrão, ou especificada manualmente com `--seed`). Usamos `train-iters` como as iterações de treinamento solicitadas. Alternativamente, pode-se fornecer `--train-samples`, que é o número total de amostras para treinar. Se esta opção estiver presente, em vez de fornecer `--lr-decay-iters`, será necessário fornecer `--lr-decay-samples`.

As opções de logging, salvamento de checkpoint e intervalo de avaliação são especificadas. Observe que o `--data-path` agora inclui o sufixo adicional `_text_sentence` adicionado no pré-processamento, mas não inclui as extensões de arquivo.

Outros argumentos de linha de comando são descritos no arquivo fonte [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py).

Para executar o `train_bert_340m_distributed.sh`, faça as modificações desejadas, incluindo definir as variáveis de ambiente para `CHECKPOINT_PATH`, `VOCAB_FILE` e `DATA_PATH`. Certifique-se de definir essas variáveis para seus caminhos no container. Em seguida, inicie o container com o Megatron e os caminhos necessários montados (conforme explicado em [Setup](#setup)) e execute o script de exemplo.

## Pré-treinamento GPT

O script `examples/gpt3/train_gpt3_175b_distributed.sh` executa o pré-treinamento GPT de 345M parâmetros em uma única GPU. Como mencionado acima, o treinamento em GPU única é destinado principalmente para fins de depuração, já que o código é otimizado para treinamento distribuído.

Segue, em grande parte, o mesmo formato do script anterior do BERT, com algumas diferenças notáveis: o esquema de tokenização utilizado é BPE (que requer uma tabela de mesclagem e um arquivo de vocabulário `json`) em vez de WordPiece, a arquitetura do modelo permite sequências mais longas (observe que o embedding de posição máxima deve ser maior ou igual ao comprimento máximo da sequência), e o `--lr-decay-style` foi definido como decaimento cossenoidal. Observe que o `--data-path` agora inclui o sufixo adicional `_text_document` adicionado no pré-processamento, mas não inclui as extensões de arquivo.

Outros argumentos de linha de comando são descritos no arquivo fonte [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py).

`train_gpt3_175b_distributed.sh` pode ser executado da mesma maneira que descrito para o BERT. Defina as variáveis de ambiente e faça quaisquer outras modificações, inicie o container com os montagens apropriados e execute o script.
Mais detalhes em [`examples/gpt3/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/gpt3/README.md)

## Pré-treinamento T5

Muito semelhante ao BERT e GPT, o script `examples/t5/train_t5_220m_distributed.sh` executa o pré-treinamento T5 "base" (~220M parâmetros) em GPU única. A principal diferença em relação ao BERT e GPT é a adição dos seguintes argumentos para acomodar a arquitetura T5:

* `--kv-channels` define a dimensão interna das matrizes "key" e "value" de todos os mecanismos de atenção no modelo. Para o BERT e GPT, o padrão é o tamanho oculto dividido pelo número de cabeças de atenção, mas pode ser configurado para o T5.

* `--ffn-hidden-size` define o tamanho oculto nas redes feed-forward dentro de uma camada transformer. Para o BERT e GPT, o padrão é 4 vezes o tamanho oculto do transformer, mas pode ser configurado para o T5.

* `--encoder-seq-length` e `--decoder-seq-length` definem o comprimento da sequência para o codificador e decodificador separadamente.

Todos os outros argumentos permanecem como estavam para o pré-treinamento BERT e GPT. Execute este exemplo com as mesmas etapas descritas acima para os outros scripts.

Mais detalhes em [`examples/t5/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/t5/README.md)

## Pré-treinamento Distribuído

Os scripts `pretrain_{bert,gpt,t5}_distributed.sh` usam o launcher distribuído do PyTorch para treinamento distribuído. Assim, o treinamento multinó pode ser alcançado configurando corretamente as variáveis de ambiente. Veja a [documentação oficial do PyTorch](https://pytorch.org/docs/stable/elastic/run.html#launcher-api) para mais informações sobre essas [variáveis de ambiente](https://pytorch.org/docs/stable/distributed.html#environment-variable-initialization). Por padrão, o treinamento multinó usa o backend distribuído [nccl](https://developer.nvidia.com/nccl). Um conjunto simples de argumentos adicionais e o uso do módulo distribuído do PyTorch com o launcher elástico `torchrun` (equivalente a `python -m torch.distributed.run`) são os únicos requisitos adicionais para adotar o treinamento distribuído. Veja qualquer um dos scripts `pretrain_{bert,gpt,t5}_distributed.sh` para mais detalhes.

Utilizamos dois tipos de paralelismo: paralelismo de dados e de modelo. Nossa implementação de paralelismo de dados está em `megatron/core/distributed`, e suporta sobreposição da redução de gradientes com o backward pass quando a opção de linha de comando `--overlap-grad-reduce` é usada.

Em segundo lugar, desenvolvemos uma abordagem simples e eficiente de paralelismo de modelo bidimensional. Para usar a primeira dimensão, paralelismo de modelo por tensor (dividindo a execução de um único módulo transformer em várias GPUs, veja Seção 3 do [nosso artigo](https://arxiv.org/pdf/1909.08053.pdf)), adicione o argumento `--tensor-model-parallel-size` para especificar o número de GPUs entre as quais dividir o modelo, juntamente com os argumentos passados para o launcher distribuído como mencionado acima. Para usar a segunda dimensão, paralelismo de sequência, especifique `--sequence-parallel`, que também requer que o paralelismo de modelo por tensor esteja habilitado porque divide entre as mesmas GPUs (mais detalhes na Seção 4.2.2 do [nosso artigo](https://arxiv.org/pdf/2205.05198.pdf)).

Para usar o paralelismo de modelo por pipeline (fragmentando os módulos transformer em estágios com número igual de módulos transformer em cada estágio e, então, pipelineizando a execução dividindo o lote em microbatches menores, veja Seção 2.2 do [nosso artigo](https://arxiv.org/pdf/2104.04473.pdf)), use o argumento `--pipeline-model-parallel-size` para especificar o número de estágios em que dividir o modelo (por exemplo, dividir um modelo com 24 camadas transformer em 4 estágios significa que cada estágio recebe 6 camadas transformer).

Temos exemplos de como usar essas duas formas diferentes de paralelismo de modelo nos scripts de exemplo que terminam com `distributed_with_mp.sh`.

Fora essas pequenas alterações, o treinamento distribuído é idêntico ao treinamento em uma única GPU.

O agendamento de pipeline intercalado (mais detalhes na Seção 2.2.2 do [nosso artigo](https://arxiv.org/pdf/2104.04473.pdf)) pode ser habilitado usando o argumento `--num-layers-per-virtual-pipeline-stage`, que controla o número de camadas transformer em um estágio virtual (por padrão, com o agendamento não intercalado, cada GPU executa um único estágio virtual com `NUM_LAYERS / PIPELINE_MP_SIZE` camadas transformer). O número total de camadas no modelo transformer deve ser divisível pelo valor deste argumento. Além disso, o número de microbatches no pipeline (calculado como `GLOBAL_BATCH_SIZE / (DATA_PARALLEL_SIZE * MICRO_BATCH_SIZE)`) deve ser divisível por `PIPELINE_MP_SIZE` ao usar esse agendamento (essa condição é verificada por uma asserção no código). O agendamento intercalado não é suportado para pipelines com 2 estágios (`PIPELINE_MP_SIZE=2`).

## Checkpointing de Ativação e Recomputa

Para reduzir o uso de memória da GPU ao treinar um modelo grande, suportamos várias formas de checkpointing de ativação e recomputa. Em vez de todas as ativações serem armazenadas na memória para serem usadas durante o backprop, como tradicionalmente ocorre em modelos de deep learning, apenas as ativações em certos "checkpoints" no modelo são mantidas (ou armazenadas) na memória, e as outras ativações são recomputadas dinamicamente quando necessário para o backprop. Observe que esse tipo de checkpointing, *checkpointing de ativação*, é muito diferente do checkpointing de parâmetros do modelo e do estado do otimizador, que é mencionado em outro lugar.

Suportamos dois níveis de granularidade de recomputa: `selective` e `full`. A recomputa seletiva é o padrão e é recomendada na maioria dos casos. Este modo mantém na memória as ativações que ocupam menos espaço de armazenamento e são mais caras de recomputar, e recomputa as ativações que ocupam mais espaço de memória, mas são relativamente baratas de recomputar. Veja [nosso artigo](https://arxiv.org/pdf/2205.05198) para detalhes. Você deve perceber que este modo maximiza o desempenho ao mesmo tempo que minimiza a memória necessária para armazenar ativações. Para habilitar a recomputa seletiva de ativações, basta usar `--recompute-activations`.

Para casos em que a memória é muito limitada, a recomputa `full` salva apenas as entradas para uma camada transformer, ou um grupo, ou bloco, de camadas transformer, e recomputa todo o resto. Para habilitar a recomputa total de ativações, use `--recompute-granularity full`. Ao usar recomputa `full` de ativações, existem dois métodos: `uniform` e `block`, escolhidos usando o argumento `--recompute-method`.

* O método `uniform` divide uniformemente as camadas transformer em grupos de camadas (cada grupo com tamanho `--recompute-num-layers`) e armazena as ativações de entrada de cada grupo na memória. O tamanho do grupo de referência é 1 e, neste caso, a ativação de entrada de cada camada transformer é armazenada. Quando a memória da GPU é insuficiente, aumentar o número de camadas por grupo reduz o uso de memória, permitindo treinar um modelo maior. Por exemplo, quando `--recompute-num-layers` é definido como 4, apenas a ativação de entrada de cada grupo de 4 camadas transformer é armazenada.

* O método `block` recomputa as ativações de entrada de um número específico (definido por `--recompute-num-layers`) de camadas transformer individuais por estágio do pipeline e armazena as ativações de entrada das camadas restantes no estágio do pipeline. Reduzir `--recompute-num-layers` resulta em armazenar as ativações de entrada de mais camadas transformer, o que reduz a recomputa de ativações necessária no backprop, melhorando assim o desempenho do treinamento enquanto aumenta o uso de memória. Por exemplo, ao especificar 5 camadas para recomputar de 8 camadas por estágio do pipeline, apenas as ativações de entrada das primeiras 5 camadas transformer são recomputadas na etapa de backprop, enquanto as ativações de entrada das 3 últimas camadas são armazenadas. `--recompute-num-layers` pode ser aumentado incrementalmente até que a quantidade de espaço de armazenamento de memória necessária seja pequena o suficiente para caber na memória disponível, maximizando assim o uso da memória e do desempenho.

## Otimizador Distribuído

Uso: `--use-distributed-optimizer`. Compatível com todos os tipos de modelo e dados.

O otimizador distribuído é uma técnica de economia de memória, pela qual o estado do otimizador é distribuído uniformemente entre os ranks de paralelismo de dados (em vez do método tradicional de replicar o estado do otimizador entre os ranks de paralelismo de dados). Conforme descrito em [ZeRO: Memory Optimizations Toward Training Trillion Parameter Models](https://arxiv.org/abs/1910.02054), nossa implementação distribui todo o estado do otimizador que não se sobrepõe ao estado do modelo. Por exemplo, ao usar parâmetros do modelo fp16, o otimizador distribuído mantém sua própria cópia separada de parâmetros principais fp32 e gradientes, que são distribuídos entre os ranks DP. Ao usar parâmetros do modelo bf16, entretanto, os gradientes principais fp32 do otimizador distribuído são os mesmos que os gradientes fp32 do modelo, de modo que os gradientes, neste caso, não são distribuídos (embora os parâmetros principais fp32 ainda sejam distribuídos, pois são separados dos parâmetros do modelo bf16).

A economia teórica de memória varia dependendo da combinação do tipo de dado de parâmetro do modelo e do tipo de dado de gradiente. Em nossa implementação, o número teórico de bytes por parâmetro é (onde 'd' é o tamanho do paralelismo de dados):

| | Otimizador não distribuído | Otimizador distribuído |
|-|-|-|
| fp16 param, fp16 grads | 20 | 4 + 16/d |
| bf16 param, fp32 grads | 18 | 6 + 12/d |
| fp32 param, fp32 grads | 16 | 8 + 8/d |

Assim como no paralelismo de dados regular, a sobreposição da redução de gradientes (neste caso, um reduce-scatter) com o backward pass pode ser facilitada usando o argumento `--overlap-grad-reduce`. Além disso, a sobreposição do all-gather de parâmetros pode ser sobreposta ao forward pass usando `--overlap-param-gather`.

## FlashAttention

Uso: `--use-flash-attn`. Suporta dimensões de cabeças de atenção de no máximo 128.

[FlashAttention](https://github.com/HazyResearch/flash-attention) é um algoritmo rápido e eficiente em memória para computar atenção exata. Ele acelera o treinamento do modelo e reduz o requisito de memória.

Para instalar o FlashAttention:
```sh
pip install flash-attn
```

## Exemplo GPT-3

Em `examples/gpt3/train_gpt3_175b_distributed.sh` fornecemos um exemplo de como configurar o Megatron para treinar o [GPT-3](https://arxiv.org/abs/2005.14165) com 175 bilhões de parâmetros em 1024 GPUs. O script é projetado para [slurm](https://slurm.schedmd.com/documentation.html) com o plugin [pyxis](https://github.com/NVIDIA/pyxis), mas pode ser facilmente adaptado para qualquer outro scheduler. Ele usa paralelismo de tensor em 8 vias e paralelismo de pipeline em 16 vias. Com as opções `global-batch-size 1536` e `rampup-batch-size 16 16 5859375`, o treinamento começará com batch global de 16 e aumentará linearmente o batch global para 1536 ao longo de 5.859.375 amostras com passos incrementais de 16. O conjunto de dados de treinamento pode ser um conjunto único ou vários conjuntos combinados com um conjunto de pesos.

Com batch global total de 1536 em 1024 GPUs A100, cada iteração leva cerca de 32 segundos, resultando em 138 teraFLOPs por GPU, o que é 44% do pico teórico de FLOPs.

## Retro e InstructRetro

Retro [(Borgeaud et al., 2022)](https://arxiv.org/abs/2112.04426) é um modelo de linguagem (LM) autoregressivo somente decodificador, pré-treinado com aumento por recuperação.
O Retro apresenta escalabilidade prática para suportar pré-treinamento em larga escala do zero, recuperando de trilhões de tokens.
O pré-treinamento com recuperação fornece um mecanismo de armazenamento mais eficiente de conhecimento factual, quando comparado ao armazenamento de conhecimento factual implicitamente nos parâmetros da rede, reduzindo consideravelmente os parâmetros do modelo ao mesmo tempo em que atinge perplexidade menor do que GPT padrão.
O Retro também oferece flexibilidade para atualizar o
conhecimento armazenado em LMs [(Wang et al., 2023a)](https://arxiv.org/abs/2304.06762)
atualizando o banco de dados de recuperação sem treinar novamente os LMs.

InstructRetro [(Wang et al., 2023b)](https://arxiv.org/abs/2310.07713) amplia ainda mais o tamanho do Retro para 48B, apresentando o maior LLM pré-treinado com recuperação (em dezembro de 2023).
O modelo de fundação obtido, Retro 48B, supera amplamente o GPT equivalente em perplexidade.
Com ajuste por instrução no Retro, o InstructRetro demonstra melhoria significativa em relação ao GPT ajustado por instrução em tarefas downstream em configuração zero-shot. Especificamente, a melhoria média do InstructRetro é de 7% em relação ao GPT equivalente em 8 tarefas de QA de resposta curta, e 10% em relação ao GPT em 4 tarefas desafiadoras de QA de resposta longa. Também constatamos que é possível ablar o codificador da arquitetura InstructRetro e usar diretamente o backbone decodificador do InstructRetro como GPT, obtendo resultados comparáveis.

Neste repositório, fornecemos um guia de reprodução ponta a ponta para implementar Retro e InstructRetro, abrangendo
- **Construção de banco de dados de recuperação**, que suporta bilhões ou até trilhões de tokens como base de dados de recuperação em larga escala.
- **Pré-treinamento com recuperação**, que suporta pré-treinamento do zero e pré-treinamento a partir de um modelo GPT pré-treinado (Retro-fitting).
- **Ajuste por instrução**, onde fornecemos um conjunto de dados aberto para ajuste por instrução e a receita de treinamento para ajuste por instrução no Retro.
- **Avaliação em tarefas downstream**, onde fornecemos scripts de geração de texto e avaliação para tarefas de question answering em zero-shot.

Veja [tools/retro/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/retro/README.md) para uma visão geral detalhada.

## Modelos de Linguagem baseados em Mamba

Veja [examples/mamba](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/mamba) para detalhes.

<!--
## Pipeline REALM
Estamos trabalhando na implementação do sistema [REALM](https://arxiv.org/pdf/2002.08909.pdf). As próximas seções (vão) refletir as três etapas de treinamento. Por enquanto, há apenas o código ICT.
Resumidamente, são pré-treinamento dos módulos de recuperação, depois treinamento conjunto do modelo de linguagem e do recuperador, e depois ajuste fino de uma cabeça de question answering no modelo de linguagem com o recuperador fixo.

### Pré-treinamento Inverse Cloze Task (ICT)
1. Tenha um corpus em formato JSON solto com a intenção de criar uma coleção de blocos de texto de tamanho fixo como as unidades fundamentais de dados. Para um corpus como a Wikipédia, isso significa múltiplas sentenças por bloco, mas também múltiplos blocos por documento.
Execute `tools/preprocess_data.py` para construir um ou mais datasets indexados com o argumento `--split-sentences` para fazer das sentenças a unidade básica. Para o sistema REALM original, construímos dois datasets, um com o título de cada documento e outro com o corpo.
Consulte o script abaixo
<pre>
python preprocess_data.py \
    --input /path/to/corpus.json \
    --json-keys text title \
    --split-sentences \
    --tokenizer-type BertWordPieceLowerCase \
    --vocab-file /path/to/vocab.txt \
    --output-prefix corpus_indexed \
    --workers 5  # funciona bem para 10 núcleos de CPU. Escale conforme necessário.
</pre>

2. Use uma função personalizada de mapeamento de amostras no lugar de `megatron/legacy/data/realm_dataset_utils.get_block_samples_mapping`, se necessário. Para isso, será necessário implementar uma nova função em C++ dentro de `megatron/core/datasets/helpers.cpp`. A estrutura de dados de mapeamento de amostras é usada para selecionar os dados que constituirão cada amostra de treinamento antes do loop de treinamento.
 O mapeamento de amostras é responsável por armazenar todos os metadados necessários para construir a amostra a partir de um ou mais datasets indexados. No REALM, o mapeamento contém os índices inicial e final das sentenças, bem como o índice do documento (para encontrar o título correto para um corpo) e um ID único para cada bloco.
3. Pré-treine um modelo de linguagem BERT usando `pretrain_bert.py`, com o comprimento da sequência igual ao tamanho do bloco em ids de token. Este modelo deve ser treinado no mesmo dataset indexado usado para fornecer os blocos para a tarefa de recuperação de informação.
No REALM, trata-se de um modelo bert base uncased treinado com hiperparâmetros padrão.
4. Use `pretrain_ict.py` para treinar um `ICTBertModel` que utiliza dois codificadores baseados em BERT para codificar consultas e blocos para realizar a recuperação.
O script abaixo treina o modelo ICT do REALM. Ele referencia um modelo BERT pré-treinado (passo 3) no argumento `--bert-load`. O batch size usado no artigo é 4096, então seria necessário rodar com world size de paralelismo de dados igual a 32.
<pre>
python pretrain_ict.py \
    --num-layers 12 \
    --num-attention-heads 12 \
    --hidden-size 768 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-head-size 128 \
    --train-iters 100000 \
    --bert-load /path/to/pretrained_bert \
    --load checkpoints \
    --save checkpoints \
    --data-path /path/to/indexed_dataset \
    --titles-data-path /path/to/titles_indexed_dataset \
    --vocab-file /path/to/vocab.txt \
    --lr 0.0001 \
    --num-workers 2 \
    --lr-decay-style linear \
    --weight-decay 1e-2 \
    --clip-grad 1.0 \
    --lr-warmup-fraction .01 \
    --save-interval 3000 \
    --query-in-block-prob 0.1 \
    --fp16

</pre>

### Construindo um Índice de Embeddings de Blocos
Depois de treinar um modelo ICT, agora você pode embutir todo um dataset de blocos criando uma estrutura `BlockData`. Depois que isso for salvo, você pode carregá-lo
e envolvê-lo com um `FaissMIPSIndex` para fazer busca rápida por similaridade, que é fundamental no pipeline de recuperação de informação aprendida. O índice inicial pode ser construído com o seguinte script, que deve ser executado em uma sessão interativa. Ele pode aproveitar múltiplas GPUs em múltiplos nós para indexar grandes datasets muito mais rapidamente.

<pre>
python tools/create_doc_index.py \
    --num-layers 12 \
    --hidden-size 768 \
    --ict-head-size 128 \
    --num-attention-heads 12 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-load /path/to/pretrained_ict \
    --data-path /path/to/indexed_dataset \
    --titles-data-path /path/to/titles_indexed_dataset \
    --block-data-path embedded_blocks.pkl \
    --indexer-log-interval 1000 \
    --indexer-batch-size 128 \
    --vocab-file /path/to/vocab.txt \
    --num-workers 2 \
    --fp16
</pre>

-->

## Mixture of Experts
MoE (Mixture of Experts) é uma arquitetura poderosa de LLM implementada no framework Megatron-Core, projetada para aprimorar a eficiência e a escalabilidade de grandes modelos de linguagem. Ela utiliza o **Paralelismo de Especialistas**, permitindo que múltiplos especialistas sejam distribuídos entre diferentes trabalhadores, onde cada trabalhador processa lotes distintos de amostras de treinamento. Esse método aumenta significativamente o rendimento computacional, permitindo que os modelos alcancem métricas de alto desempenho, como 47% de MFU durante o treinamento em BF16 para 8x7B em H100.

Principais características do MoE:
- **Técnicas de Paralelismo**: O MoE combina várias estratégias de paralelismo, incluindo Paralelismo de Especialistas, Paralelismo de Dados, Paralelismo de Tensores, Paralelismo de Sequência, Paralelismo de Pipeline e Paralelismo de Contexto. Essa combinação permite lidar de forma eficiente com variantes maiores de modelos.
- **Roteador e Balanceamento de Carga**: O sistema emprega mecanismos avançados de roteamento como o roteador Top-K e utiliza algoritmos de balanceamento de carga para otimizar a distribuição de tokens entre os especialistas.
- **Otimizações de Desempenho**: Técnicas como GroupedGEMM e treinamento em FP8 aumentam a eficiência dos modelos MoE, especialmente quando múltiplos especialistas estão envolvidos.
- **Mecanismo de Despacho de Tokens**: O MoE suporta estratégias tanto sem descarte quanto com descarte de tokens para gerenciar de forma eficiente a distribuição dos tokens entre os especialistas.

Para uma visão abrangente das configurações e otimizações de treinamento MoE, consulte o README detalhado localizado em [megatron/core/transformer/moe/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/core/transformer/moe/README.md).

# Avaliação e Tarefas

Fornecemos diversos argumentos de linha de comando, detalhados nos scripts listados abaixo, para lidar com várias tarefas downstream zero-shot e fine-tuned. Entretanto, você também pode ajustar seu modelo a partir de um checkpoint pré-treinado em outros corpora conforme desejar. Para isso, basta adicionar a flag `--finetune` e ajustar os arquivos de entrada e parâmetros de treinamento no script de treinamento original. A contagem de iterações será reiniciada para zero, e o otimizador e estado interno serão reinicializados. Se o fine-tuning for interrompido por qualquer motivo, certifique-se de remover a flag `--finetune` antes de continuar, caso contrário, o treinamento começará novamente do início.

Como a avaliação requer substancialmente menos memória do que o treinamento, pode ser vantajoso mesclar um modelo treinado em paralelo para uso em menos GPUs em tarefas downstream. O script a seguir faz isso. Este exemplo lê um modelo GPT com paralelismo de tensor 4-way e pipeline 4-way e grava um modelo com paralelismo de tensor 2-way e pipeline 2-way.

<pre>
python tools/checkpoint/convert.py \
        --model-type GPT \
        --load-dir checkpoints/gpt3_tp4_pp4 \
        --save-dir checkpoints/gpt3_tp2_pp2 \
        --target-tensor-parallel-size 2 \
        --target-pipeline-parallel-size 2

</pre>

Várias tarefas downstream são descritas para modelos GPT e BERT abaixo. Elas podem ser executadas em modos distribuído e paralelo de modelo com as mesmas alterações usadas nos scripts de treinamento.

## Geração de Texto com GPT

Incluímos um servidor REST simples para geração de texto em `tools/run_text_generation_server.py`. Você o executa de forma semelhante ao início de um trabalho de pré-treinamento, especificando um checkpoint pré-treinado apropriado. Existem também alguns parâmetros opcionais: `temperature`, `top-k` e `top-p`. Veja `--help` ou o arquivo fonte para mais informações. Veja [examples/inference/run_text_generation_server_345M.sh](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/inference/run_text_generation_server_345M.sh) para um exemplo de como executar o servidor.

Uma vez que o servidor esteja rodando, você pode usar `tools/text_generation_cli.py` para consultá-lo, que recebe um argumento que é o host onde o servidor está rodando.

<pre>
tools/text_generation_cli.py localhost:5000
</pre>

Você também pode usar CURL ou outras ferramentas para consultar o servidor diretamente:

<pre>
curl 'http://localhost:5000/api' -X 'PUT' -H 'Content-Type: application/json; charset=UTF-8'  -d '{"prompts":["Hello world"], "tokens_to_generate":1}'
</pre>

Veja [megatron/inference/text_generation_server.py](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/inference/text_generation_server.py) para mais opções de API.

### Detoxificação do GPT via Auto-Geração
Incluímos um exemplo em `examples/academic_paper_scripts/detxoify_lm/` para detoxificar modelos de linguagem aproveitando o poder generativo dos próprios modelos.

Veja [examples/academic_paper_scripts/detxoify_lm/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/academic_paper_scripts/detxoify_lm/README.md) para tutoriais passo a passo sobre como realizar o treinamento adaptativo de domínio e detoxificar LM usando corpus autogerado.


## Avaliação do GPT
Incluímos scripts de exemplo para avaliação do GPT em perplexidade WikiText e acurácia LAMBADA Cloze.

### Avaliação de Perplexidade WikiText
Para comparação justa com trabalhos anteriores, avaliamos a perplexidade no [dataset de teste WikiText-103 em nível de palavra](https://s3.amazonaws.com/research.metamind.io/wikitext/wikitext-103-v1.zip), e calculamos apropriadamente a perplexidade dado a mudança nos tokens ao usar nosso tokenizador subword.

Usamos o seguinte comando para rodar a avaliação WikiText-103 em um modelo de 345M parâmetros.
<pre>
TASK="WIKITEXT103"

VALID_DATA=&#60;wikitext path&#62;.txt
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m

COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 1024 \
                  --max-position-embeddings 1024 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>


### Acurácia LAMBADA Cloze
Para calcular a acurácia LAMBADA cloze (a acurácia de prever o último token dado os tokens precedentes) utilizamos uma versão detokenizada e processada do [dataset LAMBADA](https://github.com/cybertronai/bflm/blob/master/lambada_test.jsonl).

Usamos o seguinte comando para rodar a avaliação LAMBADA em um modelo de 345M parâmetros. Observe que a flag `--strict-lambada` deve ser usada para exigir correspondência de palavra inteira. Certifique-se de que `lambada` faz parte do caminho do arquivo.

<pre>
TASK="LAMBADA"

VALID_DATA=&#60;lambada path&#62;.json
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m
COMMON_TASK_ARGS=&#60;mesmos de <a href="#wikitext-perplexity-evaluation">Avaliação de Perplexidade WikiText</a> acima&#62;

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --strict-lambada \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>

Outros argumentos de linha de comando são descritos no arquivo fonte [`main.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tasks/main.py)

## Avaliação de Tarefas com BERT
### Avaliação RACE
O script a seguir faz fine-tuning do modelo BERT para avaliação no [dataset RACE](http://www.cs.cmu.edu/~glai1/data/race/). Os diretórios `TRAIN_DATA` e `VALID_DATA` contêm o dataset RACE como arquivos `.txt` separados. Note que para RACE, o batch size é o número de questões RACE a serem avaliadas. Como cada questão possui quatro amostras, o batch size efetivo passado pelo modelo será quatro vezes o batch size especificado na linha de comando.

<pre>
TRAIN_DATA="data/RACE/train/middle"
VALID_DATA="data/RACE/dev/middle \
            data/RACE/dev/high"
VOCAB_FILE=bert-vocab.txt
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
CHECKPOINT_PATH=checkpoints/bert_345m_race
COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 512 \
                  --max-position-embeddings 512 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

COMMON_TASK_ARGS_EXT="--train-data $TRAIN_DATA \
                      --valid-data $VALID_DATA \
                      --pretrained-checkpoint $PRETRAINED_CHECKPOINT \
                      --save-interval 10000 \
                      --save $CHECKPOINT_PATH \
                      --log-interval 100 \
                      --eval-interval 1000 \
                      --eval-iters 10 \
                      --weight-decay 1.0e-1"

python tasks/main.py \
       --task RACE \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
       --tokenizer-type BertWordPieceLowerCase \
       --epochs 3 \
       --micro-batch-size 4 \
       --lr 1.0e-5 \
       --lr-warmup-fraction 0.06
</pre>

### Avaliação MNLI
O script a seguir faz fine-tuning do modelo BERT para avaliação com o [corpus de pares de sentenças MultiNLI](https://www.nyu.edu/projects/bowman/multinli/). Como as tarefas de correspondência são bastante semelhantes, o script pode ser rapidamente adaptado para funcionar com o dataset [Quora Question Pairs](https://www.kaggle.com/quora/question-pairs-dataset) (QQP) também.

<pre>

TRAIN_DATA="data/glue_data/MNLI/train.tsv"
VALID_DATA="data/glue_data/MNLI/dev_matched.tsv \
            data/glue_data/MNLI/dev_mismatched.tsv"
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
VOCAB_FILE=bert-vocab.txt
CHECKPOINT_PATH=checkpoints/bert_345m_mnli
COMMON_TASK_ARGS=&#60;mesmos de <a href="#race-evaluation">Avaliação RACE</a> acima&#62;
COMMON_TASK_ARGS_EXT=&#60;mesmos de <a href="#race-evaluation">Avaliação RACE</a> acima&#62;

python tasks/main.py \
       --task MNLI \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
```markdown
       --tokenizer-type BertWordPieceLowerCase \
       --epochs 5 \
       --micro-batch-size 8 \
       --lr 5.0e-5 \
       --lr-warmup-fraction 0.065
</pre>

## Inferência e Ajuste Fino do Llama-2

A [família de modelos Llama-2](https://ai.meta.com/llama/) é um conjunto open-source de modelos pré-treinados e ajustados finamente (para chat) que alcançaram resultados sólidos em uma ampla gama de benchmarks. No momento do lançamento, os modelos Llama-2 atingiram alguns dos melhores resultados entre os modelos open-source e foram competitivos com o modelo fechado GPT-3.5 (veja https://arxiv.org/pdf/2307.09288.pdf).

Os checkpoints do Llama-2 podem ser carregados no Megatron para inferência e ajuste fino. Veja a documentação [aqui](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/docs/llama_mistral.md).

# Otimização e Implantação de Modelos
A família `GPTModel` do Megatron-Core (MCore) suporta algoritmos avançados de quantização e inferência de alto desempenho através do TensorRT-LLM.

## Quantização e Implantação com TensorRT-LLM
Veja [Otimização e Implantação de Modelos Megatron](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/inference/quantization/README.md) para exemplos de `llama2` e `nemotron3`.

# Conjuntos de Dados
Não hospedamos nenhum conjunto de dados para treinamento de GPT ou BERT, porém detalhamos o processo de coleta para que nossos resultados possam ser reproduzidos.

## Coleta de Dados de Treinamento da Wikipedia
Recomendamos seguir o processo de extração de dados da Wikipedia especificado pela Google Research: "o pré-processamento recomendado é baixar [o dump mais recente](https://dumps.wikimedia.org/enwiki/latest/enwiki-latest-pages-articles.xml.bz2), extrair o texto com [WikiExtractor.py](https://github.com/attardi/wikiextractor), e então aplicar a limpeza necessária para convertê-lo em texto puro."

Recomendamos usar o argumento `--json` ao usar o WikiExtractor, que irá exportar os dados da Wikipedia em formato json solto (um objeto json por linha), tornando-o mais gerenciável no sistema de arquivos e também facilmente consumível pelo nosso código. Recomendamos um pré-processamento adicional desse conjunto de dados json com padronização de pontuação via nltk. Para treinamento de BERT, use a flag `--split-sentences` no `preprocess_data.py` conforme descrito [acima](#data-preprocessing) para incluir quebras de sentença no índice produzido. Se desejar usar dados da Wikipedia para treinamento de GPT, ainda deve limpá-los com nltk/spacy/ftfy, mas não utilize a flag `--split-sentences`.

## Coleta de Dados Webtext para GPT
Utilizamos a biblioteca [OpenWebText](https://github.com/eukaryote31/openwebtext) disponível publicamente do [jcpeterson](https://github.com/jcpeterson/openwebtext) e do [eukaryote31](https://github.com/eukaryote31/openwebtext) para baixar URLs. Em seguida, filtramos, limpamos e deduplicamos todo o conteúdo baixado de acordo com o procedimento descrito em nosso diretório [openwebtext](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/openwebtext). Para URLs do reddit correspondentes ao conteúdo até outubro de 2018, chegamos a aproximadamente 37GB de conteúdo.

# Reprodutibilidade
O treinamento com Megatron pode ser reproduzido bit a bit; para habilitar este modo use `--deterministic-mode`. Isso significa que a mesma configuração de treinamento executada duas vezes no mesmo ambiente de HW e SW deve produzir checkpoints de modelo idênticos, assim como valores de perda e métricas de acurácia idênticos (as métricas de tempo por iteração podem variar).

Atualmente existem três otimizações conhecidas do Megatron que quebram a reprodutibilidade, mas ainda produzem execuções de treinamento quase idênticas:
1. O algoritmo NCCL específico usado durante um all-reduce (conforme especificado pela variável de ambiente `NCCL_ALGO`) é importante. Testamos os seguintes: `^NVLS`, `Tree`, `Ring`, `CollnetDirect`, `CollnetChain`. O código permite o uso de `^NVLS`, que permite ao NCCL a escolha de algoritmos não-NVLS; esta escolha parece ser estável.
2. O flash attention é não-determinístico; não use `--use-flash-attn`.
3. Se usar Transformer Engine, também deve definir a variável de ambiente `NVTE_ALLOW_NONDETERMINISTIC_ALGO=0`.

Além disso, o determinismo só foi verificado em containers NGC PyTorch até e posteriores a 23.12. Se observar não-determinismo no treinamento com Megatron sob outras circunstâncias, por favor abra uma issue.

# Conversão de Checkpoints

Suportamos duas formas de conversão de modelos:

1. Conversão de classe de modelo (ou seja, o `GPTModel` em `model.legacy` vs. `model.core`)
2. Conversão de formato de checkpoint (ou seja, checkpoint distribuído vs. não-distribuído)

## Conversão de classe de modelo

O Megatron suporta conversão entre diferentes classes de modelo, incluindo classes de modelos internas (atualmente temos os modelos antigos `legacy` e os modelos novos `core`) e classes de modelos externas (como Meta, Huggingface, Mistral e Mixtral). Além disso, durante esta conversão, é possível atualizar o estado paralelo do modelo (ou seja, alterar o paralelismo tensorial e de pipeline).

Fornecemos a ferramenta `tools/checkpoint/convert.py` para conversão entre classes de modelo. Alguns argumentos importantes incluem:

- `--model-type`: `GPT` ou `BERT`
- `--loader`: formato do checkpoint existente. Os formatos suportados incluem:
  - `legacy`: nossas classes de modelo antigas (em `megatron.legacy.model`)
  - `core`: nossas classes de modelo novas (em `megatron.core.models`)
  - `llama_mistral`: para carregar modelos Llama e Mistral (suporta formatos Meta e Huggingface)
  - `mixtral_hf`: para carregar modelos Mixtral (apenas Huggingface)
- `--load-dir`: diretório para carregar o checkpoint existente
- `--saver`: `legacy` ou `core` (veja descrições em `--loader`)
- `--save-dir`: diretório para salvar o novo checkpoint
- `--target-tensor-parallel-size`: novo tamanho do paralelismo tensorial do modelo
- `--target-pipeline-parallel-size`: novo tamanho do paralelismo de pipeline do modelo

Para mais detalhes de argumentos, consulte o script principal (`convert.py`), scripts de carregamento (`loader_core.py`, `loader_legacy.py`, `loader_llama_mistral.py`, `loader_mixtral_hf.py`), ou scripts de salvamento (`saver_core.py`, `saver_legacy.py`).

Um exemplo de comando para converter um modelo GPT do formato antigo (`legacy`) para o novo formato (`core`) seria o seguinte:

```
python tools/checkpoint/convert.py \
>   --model-type GPT \
>   --loader legacy \
>   --load-dir ${LEGACY_FORMAT_DIR} \
>   --saver core \
>   --save-dir ${CORE_FORMAT_DIR} \
>   --target-tensor-parallel-size ${TP} \
>   --target-pipeline-parallel-size ${PP} \
```

Para exemplos de conversão de modelos Llama/Mistral para o Megatron, consulte [aqui](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/docs/llama_mistral.md).

## Conversão de formato de checkpoint

O Megatron oferece múltiplos formatos de checkpoint, incluindo:

- `torch`: Formato de checkpoint básico com leitura e escrita sequenciais, atrelado a um estado específico de paralelismo tensorial/pipeline (estados TP/PP, respectivamente). (Embora um checkpoint específico esteja atrelado a um estado TP/PP específico, ele ainda pode ser convertido manualmente via o conversor de classe de modelo descrito acima).
- `torch_dist`: Formato de checkpoint distribuído, para leituras e escritas paralelas rápidas, e também é independente do estado de paralelismo (ou seja, pode-se carregar o mesmo checkpoint em diferentes configurações de TP/PP).

De modo geral, `torch_dist` é o formato de checkpoint mais moderno e recomendado devido à sua velocidade. No entanto, dependendo do caso de uso, pode ser desejável converter entre esses dois formatos. Para isso, execute seu script de *treinamento* (por exemplo, via `pretrain_gpt.py`) normalmente, mas com dois argumentos adicionais:

- `--ckpt-convert-format ${FORMAT}`: `${FORMAT}` pode ser `torch` ou `torch_dist`, conforme descrito acima.
- `--ckpt-convert-save ${PATH_TO_SAVE_NEW_FORMAT}`: este caminho deve ser diferente dos caminhos atuais de `--load`/`--save`, para evitar sobrescrever o checkpoint existente. Após a conversão, use este novo caminho para os argumentos `--load`/`--save`.

A ideia geral deste conversor de formato de checkpoint é que ele inicializa o modelo como normalmente seria feito para o treinamento, mas antes de executar qualquer iteração de treinamento, ele salva no novo formato de checkpoint e então encerra. É importante notar que todos os outros argumentos de execução devem permanecer os mesmos, para que o sistema compreenda o formato anterior do checkpoint.

# Projetos Usando Megatron
Abaixo estão alguns dos projetos onde usamos diretamente o Megatron:
* [BERT and GPT Studies Using Megatron](https://arxiv.org/pdf/1909.08053.pdf)
* [BioMegatron: Larger Biomedical Domain Language Model](https://www.aclweb.org/anthology/2020.emnlp-main.379.pdf)
* [End-to-End Training of Neural Retrievers for Open-Domain Question Answering](https://arxiv.org/abs/2101.00408)
* [Large Scale Multi-Actor Generative Dialog Modeling](https://www.aclweb.org/anthology/2020.acl-main.8.pdf)
* [Local Knowledge Powered Conversational Agents](https://arxiv.org/abs/2010.10150)
* [MEGATRON-CNTRL: Controllable Story Generation with External Knowledge Using Large-Scale Language Models](https://www.aclweb.org/anthology/2020.emnlp-main.226.pdf)
* [RACE Reading Comprehension Dataset Leaderboard](http://www.qizhexie.com/data/RACE_leaderboard.html)
* [Training Question Answering Models From Synthetic Data](https://www.aclweb.org/anthology/2020.emnlp-main.468.pdf)
* [Few-shot Instruction Prompts for Pretrained Language Models to Detect Social Biases](https://arxiv.org/abs/2112.07868)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Using DeepSpeed and Megatron to Train Megatron-Turing NLG 530B, A Large-Scale Generative Language Model](https://arxiv.org/abs/2201.11990)
* [Multi-Stage Prompting for Knowledgeable Dialogue Generation](https://arxiv.org/abs/2203.08745)
* [Evaluating Parameter Efficient Learning for Generation](https://aclanthology.org/2022.emnlp-main.319.pdf)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Shall We Pretrain Autoregressive Language Models with Retrieval? A Comprehensive Study](https://arxiv.org/abs/2304.06762)
* [InstructRetro: Instruction Tuning post Retrieval-Augmented Pretraining](https://arxiv.org/abs/2310.07713)
* [An Empirical Study of Mamba-based Language Models](https://arxiv.org/abs/2406.07887)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---