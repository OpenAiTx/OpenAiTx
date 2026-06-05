# Beampy [![Build Status](https://travis-ci.com/hchauvet/beampy.svg)](https://travis-ci.com/hchauvet/beampy) [![codecov](https://codecov.io/gh/hchauvet/beampy/graph/badge.svg)](https://codecov.io/gh/hchauvet/beampy) ![pypi python version](https://img.shields.io/pypi/pyversions/beampy-slideshow.svg) ![pypi licence](https://img.shields.io/pypi/l/beampy-slideshow.svg) ![pypi download](https://img.shields.io/pypi/dm/beampy-slideshow.svg) ![pypi beampy version](https://img.shields.io/pypi/v/beampy-slideshow.svg)

**Le développement de la branche master est actuellement gelé, (seules les corrections de bugs urgents seront poussées), la nouvelle version de beampy est en cours de développement dans la branche dev qui n’est pas encore assez stable pour être utilisée...**

Beampy est un outil python pour créer des diaporamas en svg pouvant être affichés avec HTML5
(testé sur Firefox et Chromium)
La taille des diapositives est fixe, comme dans un document Latex Beamer.

La présentation Beampy génère un seul fichier html avec tout le contenu intégré.

* [Voir la documentation de Beampy](https://hchauvet.github.io/beampy/)
* [Voir une présentation de tests Beampy](https://rawgit.com/hchauvet/beampy/master/examples/beampy_tests.html) (le source est dans *examples/beampy_tests_modules.py*)

## Installation :

Depuis le Python Package Index :

```bash
pip install beampy-slideshow
```

[See full installation documentation](https://hchauvet.github.io/beampy/install.html#beampy-install)

## A quick example :

```python
from beampy import *

doc = document()

with slide():
    maketitle('Beampy a tool to make simple presentation', ['H. Chauvet'])

with slide('Beampy test'):
    text(r'\href{#0}{Go to Title}')
    text(r'Use LaTeX to render text and $$\sqrt{10}$$', align='center')

with slide('Beampy test with animated layers'):
    text(r'\href{#0}{Go to Title}')[:]
    text(r'Use LaTeX to render text and $$\sqrt{10}$$', align='center')[1]

save('./simple_one.html')

#To save in pdf just change the above command to the following
#save('./simple_one.pdf')
```

[beampy_presentation.html](https://cdn.rawgit.com/hchauvet/beampy/master/examples/simple_one.html)



## Journal des modifications :

### 0.5.5
* Correction de problèmes importants d'encodage pour python 2 et 3.
* Correction des problèmes de références manquantes dans le svg généré par dvisvgm
  (problème de seed [#18](https://github.com/hchauvet/beampy/issues/18) pour
  toute l'histoire), qui crée des parties manquantes du contenu latex dans le
  svg.
* Meilleure gestion des fichiers temporaires
* Mise à jour de scour (optimiseur svg) vers sa dernière version

### 0.5.4

* Beampy est désormais compatible python 3 et 2 (au moins 2.7 et 3.7) !
* Introduction des tests intégrés avec le framework pytest (pas encore de tests unitaires des fonctions cœur de beampy)
* Correction du bug lors de la sauvegarde de multiples formats en même temps, plus de duplication des textes [issue #13](https://github.com/hchauvet/beampy/issues/13)
* Ajout du mode logging.debug pour les sorties
* Ajout d'une option pour spécifier l'emplacement du fichier source de la présentation ( doc = document(source_filename=__name__) )

### 0.5.3

Quelques corrections mineures :
* Correction du bug dans la propagation des couches pour box
* Correction du bug lorsque la dernière couche est définie comme [n:]
* Début de l'utilisation de logging.debug dans les modules

### 0.5.2

* Correction du bug avec la sortie dvisvgm pour tikz dvi (la fonction latex2svg a maintenant
  une option pour écrire le svg produit par dvisvgm).
* Ajout du module tableofcontents [Voir la documentation](https://hchauvet.github.io/beampy/auto_examples/plot_TOC.html).
* Ajout d'un thème BeamerFrankfurt [Voir la documentation](https://hchauvet.github.io/beampy/auto_themes/theme_BeamerFrankfurt.html).
* Le module Figure accepte les gifs animés.
* Des paquets latex supplémentaires peuvent être ajoutés au module texte avec l'argument
  "extra_packages".
* Calculer la taille des rectangles et cercles SVG qui améliorent la vitesse de rendu (pas besoin d'appeler Inkscape).  
* Améliorer le module box (c'est désormais une sous-classe de group) [Voir la documentation](https://hchauvet.github.io/beampy/auto_examples/plot_box.html).  
* Corriger certains facteurs d'échelle dans la fonction convert_unit.  
* La largeur et la hauteur sont désormais des objets Length et acceptent des opérations complexes telles que :  



  ```python

  # 50% of the currentwidth 
  a = rectangle(width='50%', height=10)

  # width/height relative to the a element
  b = rectangle(width=a.width/2+'2cm', height=a.height/'10pt')
  ```

* la position du module (x,y) accepte désormais des objets Longueur (largeur/hauteur) :

  ```python

  a = rectangle(width='50%', height=10)

  b = rectangle(x=a.width+'2cm', y=a.height+5)
  ```
  
* Modifier le cœur de beampy pour rendre les éléments uniquement lorsque cela est nécessaire pour
  une opération sur la position ou la longueur (c’est-à-dire lorsque vous effectuez une opération sur
  une largeur ou une hauteur d’élément inconnue, l’élément sera
  rendu pour obtenir sa taille et permettre l’opération)
* Ajouter l’opération "zorder" pour les modules (au-dessus/en-dessous/dernier/premier) afin de changer
  leur ordre de superposition :

  ```python

  a = rectangle(x='center', y='center', width=50, height=50)
  b = rectangle(x='center', y='center', width=a.height+100,
                height=a.height+100, color='red')

  # Make b appears below a
  b.below(a)
  
  # equivalent to a.above(b) or a.last() or b.first()
  ```

### 0.5.1

* Correction de plusieurs bugs dans les figures bokeh (merci à [Silmathoron](https://github.com/Silmathoron))
* Correction du redimensionnement des figures bokeh, il utilise maintenant "sizing_mode = scale_both" de bokeh et annule la mise à l’échelle par transformation CSS pour la div bokeh.
* Correction du chargeur javascript pour bokeh (la nouvelle version de bokeh (>0.12.6) nomme leur div principale "bk_root")
* Ajout d’une fonction pour mettre en cache un fichier dans la classe cache de beampy
* Mise en cache des fichiers des bibliothèques externes javascript de bokeh (téléchargement depuis leur CDN, si "doc = document(cache=False)")


### 0.5.0
* Ajout d’une fonction box pour décorer un groupe
* Nouvelle méthode expérimentale pour écrire du texte dans la présentation en utilisant un gestionnaire de contexte

  ```python
  with text(width=400):
       """
       Any comment inside the context manager will be passed to the
       text function as input argument. This allows clearer source
       when writing long texts.

       No more need to add an *r* before to protect the text passed to
       latex, it's now automatically added.
       """
  ```
  
* Correction d'un bug lorsque seuls des objets html sont présents dans une diapositive
* Correction de petites fautes dans la section d'installation de la documentation.

### 0.4.9

* Première ébauche de la [documentation Beampy](https://hchauvet.github.io/beampy/)
* Ajout de la documentation dans le module Beampy
* Ajout de la clé 'anchor' au dictionnaire de position pour définir l’ancre le long de la
  boîte englobante du module pour les positionner.
* Ajout de utils.py pour stocker des fonctions qui appellent les modules beampy.
* Ajout de la fonction **bounding_box(module)** dans utils.py pour dessiner une boîte englobante avec
  des ancres autour des modules Beampy. Ajout également d’une fonction pour dessiner des axes sur la diapositive,
  **draw_axes()**

### 0.4.8

* Correction partielle du problème #12.
* Nettoyage de la syntaxe du code.

### 0.4.7

* Introduction du mécanisme de calques. Les éléments de la diapositive peuvent être animés par calques permettant un mécanisme similaire à "\only" de beamer.
  Les calques sont gérés comme des tranches python sur les modules Beampy.

  ```python 
  with slide('Test layers'):
    text('First printed on layer 0')
    text('Secondly printed on layer 1')[1]
    text('Printed from layer 2 to 3')[2,3]
    text('Printed on all layers')[:]
    text('Printed on layer 4')[4]
    
    with group(width=300)[2:]:
        text('Printed inside group')
        text('for layers 2 to end')
  ```
  

### 0.4.6

* The core of Beampy slide processor has been rewritten and now allows recursive group of elements.

  ```python
  with group():
    text('toto')
    with group(width=300):
        text('tata')

        with group(width=200):
            figure('./niceplot.pdf')
            text('nice legend')
  ```

* Si une largeur de groupe est donnée, tous les éléments des groupes sans largeur spécifiée prennent la largeur du groupe

  ```python
  with group(width=200):
    figure('./niceplot.pdf')
    text('nice legend')
    # Figure and text width will be automatically set to 200 px
  ```

* Le placement relatif peut désormais être effectué sur des éléments positionnés automatiquement

  ```python
  t0 = text('toto')
  text('tata', x=t0.center + center(0), t0.bottom + 0.1)
  ```

* La vidéo peut désormais utiliser des liens externes (avec *embedded=True*) plutôt que d’être incluse dans le fichier html.  
  La vidéo est chargée depuis le disque (attention au chemin du fichier) lorsque la diapositive est affichée à l’écran.

### 0.4.5

* Tous les textes sont prétraités dans un seul fichier latex (Latex est appelé une seule fois : amélioration du temps de compilation)  
* Correction du bug de cache : la vidéo et le svg sont désormais mis en cache correctement

### 0.4.4

* Amélioration du cache : un fichier par élément mis en cache (ne pas écrire le cache deux fois !)  
* Svg : ajout des commandes ligne et rectangle pour dessiner facilement des lignes et des rectangles  
* Placement relatif : ajout des raccourcis center(shift), right(shift) et bottom(shift)  
  pour changer l’ancre de l’élément courant.

  ```python 
    e1 = text('Somthing', x=0.2, y=0.4)
    e2 = text('An other thing', 
              x=e1.left + right(0.1), 
              y=e1.center + center(0))
  ```
### 0.4.3

* Les figures Matplotlib peuvent désormais être directement passées à *figure()* ou une liste de figures matplotlib peut être animée avec *animatesvg()*
* Amélioration mineure de la taille du cache (le contenu n'est plus stocké dans le fichier de cache)
* Mise à jour de la version de scour (optimiseur svg)

### 0.4.2
* Les chemins de glyphe issus de Latex sont désormais uniques (cela réduit le nombre de lignes svg dans les documents)
* Ajout de la commande *svg* pour inclure du svg brut dans la diapositive
* Amélioration de la flexibilité du thème, un arrière-plan avec des éléments interactifs peut désormais être créé !

### 0.4.1
* Toutes les diapositives sont maintenant chargées en RAM, amélioration de la vitesse
* Les modules sont désormais des classes qui héritent d'une classe de base "beampy_module" dans modules/core.py
* Le cache est désormais unique pour tous les formats (pdf, svg, html) et des clés spéciales peuvent être ajoutées
  aux modules afin de créer leur identifiant de cache

## Installation

[Voir la page d'installation de la documentation Beampy](https://hchauvet.github.io/beampy/install.html)








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-05

---