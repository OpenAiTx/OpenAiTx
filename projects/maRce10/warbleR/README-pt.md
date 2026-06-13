warbleR: Simplifique a Análise Bioacústica
================

🌐 **Idiomas:**  
[English](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[Español](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[Français](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[Deutsch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[Português](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[Italiano](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[Русский](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[中文 (简体)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[中文 (繁體)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[日本語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[한국어](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[हिन्दी](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[ไทย](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[Nederlands](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[Polski](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[العربية](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[فارسی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[Türkçe](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[Tiếng Việt](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[Bahasa Indonesia](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[অসমীয়া](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md é gerado a partir de README.Rmd. Por favor, edite esse arquivo -->
<!-- badges: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Status do Projeto: Ativo O projeto atingiu um estado estável, utilizável
e está sendo ativamente
desenvolvido.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![Licença: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
cobertura](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="logo do warbleR" align="right" width = "25%" height="25%"/>

O [warbleR](https://cran.r-project.org/package=warbleR) foi desenvolvido para
facilitar a análise da estrutura de sinais acústicos de animais no
R. Usuários podem coletar gravações de aves de acesso aberto ou inserir seus próprios
dados em um fluxo de trabalho que facilita a visualização espectrográfica e a
medição de parâmetros acústicos.
O [warbleR](https://cran.r-project.org/package=warbleR) faz uso das
ferramentas fundamentais de análise de som do pacote seewave, e oferece novas
ferramentas para análise da estrutura acústica. Essas ferramentas estão disponíveis para
análise em lote de sinais acústicos.

As principais características do pacote são:

- Diversas ferramentas para medir a estrutura acústica
- O uso de loops para aplicar tarefas em sinais acústicos referenciados em
  uma tabela de seleção
- A produção de imagens no diretório de trabalho com espectrogramas para
  permitir que usuários organizem dados e verifiquem análises acústicas

O pacote oferece funções para:

- Explorar e baixar gravações do [Xeno‐Canto](https://xeno-canto.org/)
- Explorar, organizar e manipular múltiplos arquivos de áudio
- Detectar sinais automaticamente (em frequência e tempo) (mas consulte o pacote R
  [ohun](https://docs.ropensci.org/ohun/) para uma implementação mais completa
  e amigável)
- Criar espectrogramas de gravações completas ou sinais individuais
- Executar diferentes medições da estrutura do sinal acústico
- Avaliar o desempenho dos métodos de medição
- Catalogar sinais
- Caracterizar diferentes níveis estruturais em sinais acústicos
- Análise estatística da coordenação de duetos
- Consolidar bancos de dados e tabelas de anotação

A maioria das funções permite a paralelização de tarefas, o que
distribui as tarefas entre vários processadores para melhorar o processamento computacional
eficiência. Ferramentas para avaliar o desempenho da análise em cada
etapa também estão disponíveis.

## Instalação

Instale/carregue o pacote a partir do CRAN da seguinte forma:

``` r
install.packages("warbleR")

# load package
library(warbleR)
```
Para instalar a versão de desenvolvimento mais recente do
[github](https://github.com/) você precisará do pacote R
[remotes](https://cran.r-project.org/package=remotes):


``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## Uso

O pacote inclui vários vinhetas explicando suas principais funcionalidades. O
[Introdução ao
warbleR](https://marce10.github.io/warbleR/articles/warbleR.html)
fornece uma visão geral das funcionalidades do pacote. O vinheta
[Formato de dados de
anotação](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
dá uma descrição detalhada do formato necessário para as anotações de entrada.
Há também três [vinhetas do pacote](https://marce10.github.io/warbleR/articles/) adicionais com exemplos de
como organizar funções em um fluxo de trabalho de análise acústica.

Uma descrição completa do pacote (embora um pouco desatualizada) pode ser encontrada
neste [artigo de
revista](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624).

## Outros pacotes

Os pacotes [seewave](https://cran.r-project.org/package=seewave) e
[tuneR](https://cran.r-project.org/package=seewave) fornecem uma enorme
variedade de funções para análise e manipulação acústica. Eles trabalham principalmente
com objetos wave já importados para o ambiente R. O
pacote [baRulho](https://cran.r-project.org/package=baRulho) foca em
quantificar a degradação induzida pelo habitat em sinais acústicos com dados de
entrada e saída semelhantes aos do
[warbleR](https://cran.r-project.org/package=warbleR). O pacote
[Rraven](https://cran.r-project.org/package=Rraven) facilita a
troca de dados entre R e o [software de análise sonora Raven
](https://www.ravensoundsoftware.com/) ([Cornell Lab of
Ornithology](https://www.birds.cornell.edu/home)) e pode ser muito
útil para incorporar o Raven como ferramenta de anotação no fluxo de trabalho de
análise acústica no R. O pacote
[ohun](https://docs.ropensci.org/ohun/) trabalha com detecção automatizada de
eventos sonoros, fornecendo funções para diagnosticar e otimizar rotinas de
detecção. [dynaSpec](https://cran.r-project.org/package=seewave) permite
criar espectrogramas dinâmicos (ou seja, vídeos de espectrograma).

## Citação


Por favor, cite [warbleR](https://cran.r-project.org/package=warbleR) como
segue:

Araya-Salas, M. e Smith-Vidaurre, G. (2017), *warbleR: um pacote r para
simplificar a análise de sinais acústicos de animais*. Methods Ecol Evol. 8,
184-191.

NOTA: por favor, cite também os pacotes
[tuneR](https://cran.r-project.org/package=tuneR) e
[seewave](https://cran.r-project.org/package=seewave) caso utilize
quaisquer funções de criação de espectrogramas ou medição acústica


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---