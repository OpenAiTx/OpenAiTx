[![Version PyPI](https://badge.fury.io/py/rsmf.svg)](https://pypi.org/project/rsmf/)
[![Statut de la documentation](https://readthedocs.org/projects/rsmf/badge/?version=latest)](https://rsmf.readthedocs.io/en/latest/?badge=latest)
[![rsmf](https://circleci.com/gh/johannesjmeyer/rsmf.svg?style=shield)](https://github.com/johannesjmeyer/rsmf)
[![Style de code : black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)


# rsmf (redimensionne mes figures)

Lorsque j’écris un article, je suis un peu exigeant sur les figures. Il est particulièrement important pour moi que les polices et les tailles de police correspondent au document environnant. Comme je trace habituellement avec matplotlib, j’ai créé cette bibliothèque pour m’aider avec cela. Cette bibliothèque fournit un moyen de 
réajuster automatiquement les tailles des figures et des polices dans matplotlib afin qu’elles correspondent à celles utilisées dans les revues scientifiques courantes. Actuellement, `quantumarticle` et `revtex4` sont pris en charge.

# Installation

Vous pouvez obtenir la dernière version publiée depuis PyPI.
```bash
pip install rsmf
```
Pour obtenir la dernière version de développement, vous devez installer le paquet depuis GitHub.
```bash
pip install git+https://www.github.com/johannesjmeyer/rsmf
```

Le package dépend du backend PGF de matplotlib. Pour pouvoir l’utiliser, vous devez disposer d’une distribution TeX fonctionnelle avec `pdflatex` installé (voir plus loin [Issue #2](https://github.com/johannesjmeyer/rsmf/issues/2)).

# Utilisation

Une explication détaillée de l’utilisation est donnée dans la [documentation](https://rsmf.readthedocs.io/en/latest/source/howto.html).

## Configuration
Vous devez indiquer à rsmf comment vous configurez votre document en invoquant `rsmf.setup`. Cela peut se faire de deux manières. Soit vous donnez à rsmf la chaîne `\documentclass` utilisée pour configurer le document, comme dans
```python
import rsmf
formatter = rsmf.setup(r"\documentclass[a4paper,12pt,noarxiv]{quantumarticle}")
```
Le `r` devant la chaîne est nécessaire pour que `\d` ne soit pas pris pour une séquence d’échappement. Si vous avez votre document stocké localement, il existe une méthode encore plus pratique :  
vous pouvez simplement fournir à rsmf le chemin vers votre fichier tex principal (celui contenant la configuration du document) et il le détectera lui-même :
```python
formatter = rsmf.setup("example.tex")
```
Ceci est particulièrement intéressant car rsmf ajustera automatiquement les graphiques lorsque la classe de document sous-jacente est modifiée sans qu'il soit nécessaire de changer le code Python ! Cela facilite grandement le changement de revues.

Si la classe de document que vous ciblez n'est pas prise en charge par `rsmf`, vous pouvez quand même l'utiliser. Dans ce cas, vous devez extraire vous-même les mesures pertinentes et utiliser `rsmf.CustomFormatter`. Une explication détaillée est donnée dans la [documentation](https://rsmf.readthedocs.io/en/latest/source/howto.html).

## Figures
La routine de configuration retournera un formateur. Ce formateur peut ensuite être utilisé pour créer des objets figure matplotlib en invoquant la méthode `formatter.figure`. Elle a trois arguments :

* `aspect_ratio` (float, optionnel) : le rapport d'aspect (hauteur/largeur) de votre graphique. Par défaut, l'inverse du nombre d'or.
* `width_ratio` (float, optionnel) : la largeur de votre graphique en multiples de `\columnwidth`. Par défaut 1.0.
* `wide` (bool, optionnel) : indique si la figure s'étend sur deux colonnes en mode deux colonnes, 
                c'est-à-dire si l'environnement figure* est utilisé, sans effet en mode une colonne. Par défaut False.

C'est ici que vous définissez la largeur de vos graphiques, _pas dans le document LaTeX._ Si vous incluez la figure résultante avec une largeur différente, les tailles de police ne correspondront pas au document environnant !

Par exemple, une figure normale est créée via
```python
fig = formatter.figure(aspect_ratio=.5)

# ... some plotting ...
plt.savefig("example.pdf")
```
et inclus via
```tex
\begin{figure}
	\centering
	\includegraphics{example}
	\caption{...}
\end{figure}
```
Une grande figure qui s'étend sur 80 % de la page, en revanche, est créée par
```python
fig = formatter.figure(width_ratio=.8, wide=True)

# ... some plotting ...
plt.savefig("example_wide.pdf")
```
et inclus via l'environnement multi-colonnes `figure*` :
```tex
\begin{figure*}
	\centering
	\includegraphics{example_wide}
	\caption{...}
\end{figure*}
```

Notez que vous devriez toujours enregistrer vos figures dans un format vectoriel, comme `pdf` et que l'appel à `plt.tight_layout()` avant l'enregistrement rend généralement vos graphiques plus agréables.

De plus, observez que le paramètre ``aspect_ratio`` est défini comme la hauteur du graphique divisée par sa largeur. Bien que les rapports d'aspect soient plus couramment définis comme largeur/hauteur, ce choix permet d'avoir la largeur et la hauteur de la figure proportionnelles respectivement à ``width_ratio`` et ``aspect_ratio``.

Il est également possible de créer les objets figure manuellement, en utilisant `formatter.columnwidth` et `formatter.wide_columnwidth`, la routine `formatter.figure` est un wrapper pratique autour de cela.

## Autres fonctionnalités
Vous pouvez accéder aux tailles de police sous-jacentes via `formatter.fontsizes`. La nomenclature suit celle de LaTeX lui-même, ainsi nous avons par exemple `formatter.fontsizes.tiny` ou `formatter.fontsizes.Large`.
Ceci est particulièrement utile si vous souhaitez ajuster les titres, légendes et annotations tout en gardant des tailles de police cohérentes.

## Utilisation de rsmf avec d'autres frameworks
Vous pouvez utiliser rsmf avec votre framework de tracé préféré, par exemple `seaborn`. Il y a un seul inconvénient : si vous utilisez les styles matplotlib ou seaborn, vous pourriez écraser les réglages imposés par rsmf, notamment en ce qui concerne la taille de la police. À cette fin, les formatteurs ont une méthode `formatter.set_default_fontsizes` qui ne change que les tailles de police sous-jacentes. Un exemple d'utilisation serait
```python
fig = formatter.figure(wide=True)
sns.set(style="ticks")
formatter.set_default_fontsizes()

# ... some plotting ...
```
Parfois, ces styles écrasent également d'autres éléments, comme la famille de polices (serif/sans-serif). Il n'existe pas encore de méthode de correction pour cela.

## Exemple
Un document exemple ainsi qu'un notebook pour réaliser les graphiques utilisés se trouvent dans le dossier `examples`.

# Comment ça fonctionne
En interne, rsmf définit le backend matplotlib sur `pgf`, ce qui permet l'utilisation de LaTeX. Pour chaque classe de document supportée, les largeurs de colonnes spécifiques et les tailles de police sont stockées dans le code, ainsi que les packages chargés qui modifient les polices. Pour `quantumarticle`, par exemple, le package `lmodern` est chargé dans le backend `pgf` pour obtenir la bonne police sans-serif.

Lors de l'appel à `rsmf.setup`, les `rcParams` de matplotlib sont ajustés pour faire correspondre les tailles de police au document environnant. Notez que `formatter.figure` ne modifie pas les `rcParams`.

# Contribuer
Avez-vous des difficultés à configurer des graphiques pour votre classe de document préférée et celle-ci n'est pas prise en charge ici ? N'hésitez pas à faire une PR !

Un grand merci pour les contributions à :
[Samuel J. Palmer](https://github.com/sp94), 
[platipo](https://github.com/platipo), 
[Lorenzo Fioroni](https://github.com/LorenzoFioroni)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-18

---