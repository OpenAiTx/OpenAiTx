
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Flow Matching em PyTorch

Este repositório contém uma implementação simples em PyTorch do artigo [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747).

## Exemplo de Flow Matching 2D

O gif abaixo demonstra o mapeamento de uma única distribuição Gaussiana para uma distribuição em padrão tabuleiro, com o campo vetorial visualizado.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

E aqui está outro exemplo com o conjunto de dados moons.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## Primeiros Passos

Clone o repositório e configure o ambiente Python.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Certifique-se de ter o Python 3.12+ instalado.
Instale o `uv`:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

Então, configure o ambiente:

```bash
uv sync
```

## Conditional Flow Matching [Lipman+ 2023]

Esta é a implementação original do artigo CFM [1]. Alguns componentes do código são adaptados de [2] e [3].

### Conjuntos de Dados Sintéticos 2D

Você pode treinar os modelos CFM em conjuntos de dados sintéticos 2D, como `checkerboard` e `moons`. Especifique o nome do conjunto de dados usando a opção `--dataset`. Os parâmetros de treinamento estão predefinidos no script, e as visualizações dos resultados do treinamento são armazenadas no diretório `outputs/`. Os pontos de verificação dos modelos não estão incluídos, pois são facilmente reproduzíveis com as configurações padrão.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

Os campos vetoriais e amostras geradas, como os exibidos em GIFs no topo deste README, agora podem ser encontrados no diretório `outputs/cfm/`.

### Conjuntos de Dados de Imagens

Você também pode treinar modelos CFM condicionais à classe em conjuntos de dados populares de classificação de imagens. Tanto as amostras geradas quanto os checkpoints do modelo serão armazenados no diretório `outputs/cfm`. Para uma lista detalhada dos parâmetros de treinamento, execute `uv run scripts/train_flow_matching_on_image.py --help`.

Para treinar um CFM condicional à classe no conjunto de dados MNIST, execute:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

Após o treinamento, agora você pode gerar amostras com:

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```

Agora, você deverá conseguir ver as amostras geradas no diretório `outputs/cfm/mnist/`.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Fluxo Retificado [Liu+ 2023]

Esta é uma implementação do modelo Reflow (2-Fluxo Retificado, especificamente) do artigo Rectified Flow [2].

### Dados Sintéticos 2D

Implementamos o Reflow em conjuntos de dados sintéticos 2D, assim como o CFM. Para treinar o reflow, você deve especificar pontos de verificação (checkpoints) CFM pré-treinados, pois o reflow é um modelo de destilação.

Por exemplo, para treinar no conjunto de dados `checkerboard` com um checkpoint CFM pré-treinado:

```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

Os resultados do treinamento, incluindo visualizações do campo vetorial e amostras geradas, são salvos na pasta `outputs/reflow/`.

### Comparação do processo de amostragem entre CFM e Reflow

Para comparar CFM e Reflow em conjuntos de dados 2d, execute:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```
Os GIFs resultantes podem ser encontrados na pasta `outputs/comparisons/`. Abaixo está um exemplo de comparação dos dois métodos no conjunto de dados `checkerboard`:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## Referências

- [1] Lipman, Yaron, et al. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, et al. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---