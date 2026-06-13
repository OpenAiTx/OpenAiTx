warbleR: Упрощенный биоакустический анализ
================

🌐 **Языки:**  
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

<!-- README.md генерируется из README.Rmd. Пожалуйста, редактируйте этот файл -->
<!-- badges: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Project Status: Active The project has reached a stable, usable state
and is being actively
developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![License: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) предназначен для
упрощения анализа структуры акустических сигналов животных в
R. Пользователи могут собирать записи птиц с открытым доступом или вводить свои
данные в рабочий процесс, который облегчает спектрографическую визуализацию и
измерение акустических параметров.
[warbleR](https://cran.r-project.org/package=warbleR) использует
основные инструменты анализа звука пакета seewave и предлагает новые
инструменты для анализа акустической структуры. Эти инструменты доступны для
пакетного анализа акустических сигналов.

Основные возможности пакета:

- Разнообразные инструменты для измерения акустической структуры
- Использование циклов для применения задач к акустическим сигналам, указанным в
  таблице выбора
- Генерация изображений в рабочем каталоге со спектрограммами для
  организации данных и проверки акустических анализов

Пакет предоставляет функции для:

- Поиска и загрузки записей [Xeno‐Canto](https://xeno-canto.org/)
- Поиска, организации и обработки множества звуковых файлов
- Автоматического обнаружения сигналов (по частоте и времени) (но ознакомьтесь с R
  пакетом [ohun](https://docs.ropensci.org/ohun/) для более полного и удобного решения)
- Создания спектрограмм полных записей или отдельных сигналов
- Проведения различных измерений структуры акустических сигналов
- Оценки эффективности методов измерения
- Каталогизации сигналов
- Характеризации различных структурных уровней акустических сигналов
- Статистического анализа координации дуэтов
- Консолидации баз данных и таблиц аннотаций

Большинство функций позволяют параллелизацию задач, что
распределяет задачи между несколькими процессорами для повышения вычислительной

эффективности. Инструменты для оценки производительности анализа на каждом
этапе также доступны.

## Установка

Установите/загрузите пакет из CRAN следующим образом:

``` r
install.packages("warbleR")

# load package
library(warbleR)
```

Чтобы установить последнюю версию для разработчиков с
[github](https://github.com/), вам понадобится пакет R
[remotes](https://cran.r-project.org/package=remotes):

``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## Использование

Пакет включает несколько виньеток, объясняющих его основные функции. В
[Введении в
warbleR](https://marce10.github.io/warbleR/articles/warbleR.html)
представлен обзор возможностей пакета. Виньетка
[Формат аннотированных данных](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
дает подробное описание требуемого формата входных
аннотаций. Также есть три дополнительных [виньетки
пакета](https://marce10.github.io/warbleR/articles/) с примерами того,
как организовать функции в рабочем процессе акустического анализа.

Полное описание пакета (хотя и немного устаревшее) можно найти
в этой [журнале
статье](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624).

## Другие пакеты

Пакеты [seewave](https://cran.r-project.org/package=seewave) и
[tuneR](https://cran.r-project.org/package=seewave) предоставляют
огромное разнообразие функций для акустического анализа и обработки.
Они в основном работают с wave-объектами, уже импортированными в
среду R. Пакет [baRulho](https://cran.r-project.org/package=baRulho)
сфокусирован на количественной оценке деградации акустических сигналов,
вызванной средой, с входными и выходными данными, схожими с
[warbleR](https://cran.r-project.org/package=warbleR). Пакет
[Rraven](https://cran.r-project.org/package=Rraven) облегчает
обмен данными между R и [Raven sound analysis
software](https://www.ravensoundsoftware.com/) ([Cornell Lab of
Ornithology](https://www.birds.cornell.edu/home)) и может быть очень
полезен для интеграции Raven как инструмента аннотирования в рабочий
процесс акустического анализа в R. Пакет
[ohun](https://docs.ropensci.org/ohun/) работает с автоматическим
обнаружением звуковых событий, предоставляя функции для диагностики и
оптимизации процедур обнаружения. [dynaSpec](https://cran.r-project.org/package=seewave)
позволяет создавать динамические спектрограммы (т.е. видео спектрограмм).

## Цитирование


Пожалуйста, цитируйте [warbleR](https://cran.r-project.org/package=warbleR) следующим образом:

Araya-Salas, M. и Smith-Vidaurre, G. (2017), *warbleR: пакет r для упрощения анализа акустических сигналов животных*. Methods Ecol Evol. 8, 184-191.

ПРИМЕЧАНИЕ: пожалуйста, также цитируйте пакеты
[tuneR](https://cran.r-project.org/package=tuneR) и
[seewave](https://cran.r-project.org/package=seewave), если вы
используете любые функции для создания спектрограмм или измерения акустических характеристик





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---