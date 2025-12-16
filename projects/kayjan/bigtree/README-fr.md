# Package Big Tree Python

Implémentation d'arbre et méthodes pour Python, intégrées avec list, dictionnaire, pandas et DataFrame polars.

C'est pythonique, ce qui le rend facile à apprendre et extensible à de nombreux types de flux de travail.

----

Liens associés :
- [Documentation](https://bigtree.readthedocs.io/)
- [GitHub](https://github.com/kayjan/bigtree/)
- Communauté
  - [Problèmes](https://github.com/kayjan/bigtree/issues)
  / [Discussions](https://github.com/kayjan/bigtree/discussions)
  / [Journal des modifications](https://github.com/kayjan/bigtree/blob/master/CHANGELOG.md)
  / [Contribuer](https://bigtree.readthedocs.io/stable/home/contributing/)
- Package
  - [PyPI](https://pypi.org/project/bigtree/)
  / [Conda](https://anaconda.org/conda-forge/bigtree)
- Articles
  - [Implémentation d'arbre Python avec BigTree](https://medium.com/data-science/python-tree-implementation-with-bigtree-13cdabd77adc#245a-94ae81f0b3f1)
  - [L'algorithme de Reingold Tilford expliqué, avec démonstration](https://medium.com/data-science/reingold-tilford-algorithm-explained-with-walkthrough-be5810e8ed93?sk=2db8e10398cee76c486c4b06b0b33322)
- <div><p>Si vous souhaitez soutenir bigtree, <a href="https://www.buymeacoffee.com/kayjan"><img src="https://img.shields.io/badge/Buy_Me_A_Coffee-FFDD00?style=for-the-badge&logo=buy-me-a-coffee&logoColor=black" alt="Buy Me a Coffee" style="vertical-align:middle"></a></p></div>

-----

## Composants
Il y a 3 segments dans Big Tree comprenant l'implémentation d'Arbre, d'Arbre Binaire et de Graphe Orienté Aciclique (DAG).

Pour l'implémentation **d'Arbre**, il y a 12 composants principaux.

1. [**🌺 Nœud**](https://bigtree.readthedocs.io/stable/bigtree/node/node/)
   1. ``BaseNode``, classe extensible
   2. ``Node``, BaseNode avec un attribut de nom de nœud
2. [**🎄 Arbre**](https://bigtree.readthedocs.io/stable/bigtree/tree/tree/)
   1. ``Tree``, enveloppe autour de ``Node``, fournissant des API de haut niveau pour construire, itérer, interroger et exporter la structure entière de l'arbre
3. [**✨ Construction d'Arbre**](https://bigtree.readthedocs.io/stable/bigtree/tree/construct/)
   1. À partir de `Node`, en utilisant les constructeurs parent et enfants
   2. À partir de *str*, en utilisant l'affichage d'arbre ou la notation Newick
   3. À partir de *list*, en utilisant des chemins ou des tuples parent-enfant
   4. À partir d’un *dictionnaire imbriqué*, en utilisant des paires clé-valeur chemin-attribut ou une structure récursive
   5. À partir d’un *DataFrame pandas*, en utilisant des chemins ou des colonnes parent-enfant
   6. À partir d’un *DataFrame polars*, en utilisant des chemins ou des colonnes parent-enfant
   7. À partir d’une *interface utilisateur interactive*
   8. Ajouter des nœuds à un arbre existant en utilisant une chaîne de chemin
   9. Ajouter des nœuds et des attributs à un arbre existant en utilisant un *dictionnaire*, un *DataFrame pandas* ou un *DataFrame polars*, en utilisant le chemin
   10. Ajouter uniquement des attributs à un arbre existant en utilisant un *dictionnaire*, un *DataFrame pandas* ou un *DataFrame polars*, en utilisant le nom du nœud
4. [**➰ Parcours de l’Arbre**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)
   1. Parcours en pré-ordre
   2. Parcours en post-ordre
   3. Parcours en ordre de niveau
   4. Parcours en groupe par niveau
   5. Parcours ZigZag
   6. Parcours en groupe ZigZag
5. [**🧩 Analyse de l’Arbre**](https://bigtree.readthedocs.io/stable/bigtree/tree/parsing/)
   1. Obtenir les ancêtres communs entre des nœuds
   2. Obtenir le chemin d’un nœud à un autre nœud
6. [**📝 Modification de l’Arbre**](https://bigtree.readthedocs.io/stable/bigtree/tree/modify/)
   1. Copier des nœuds d’un emplacement vers une destination
   2. Déplacer des nœuds d’un emplacement vers une destination
   3. Déplacer et remplacer des nœuds d’un emplacement vers une destination
   4. Copier des nœuds d’un arbre à un autre
   5. Copier et remplacer des nœuds d’un arbre à un autre
7. [**📌 Requête sur l’Arbre**](https://bigtree.readthedocs.io/stable/bigtree/tree/query/)
   1. Filtrer l’arbre en utilisant le langage de requête Tree Query Language
8. [**🔍 Recherche dans l’Arbre**](https://bigtree.readthedocs.io/stable/bigtree/tree/search/)
   1. Trouver plusieurs nœuds selon le nom, chemin partiel, chemin relatif, valeur d’attribut, condition définie par l’utilisateur
   2. Trouver un seul nœud selon le nom, chemin partiel, chemin relatif, chemin complet, valeur d’attribut, condition définie par l’utilisateur
   3. Trouver plusieurs nœuds enfants selon une condition définie par l’utilisateur
   4. Trouver un seul nœud enfant selon le nom, condition définie par l’utilisateur
9. [**🔧 Fonction d’Aide**](https://bigtree.readthedocs.io/stable/bigtree/tree/helper/)
   1. Cloner un arbre vers un autre type de `Node`
   2. Obtenir un sous-arbre (arbre plus petit avec une racine différente)
   3. Élaguer l’arbre (arbre plus petit avec la même racine)
   4. Obtenir la différence entre deux arbres
10. [**📊 Visualisation de l’Arbre**](https://bigtree.readthedocs.io/stable/bigtree/utils/plot/)
   1. Algorithme Reingold-Tilford amélioré pour récupérer les coordonnées (x, y) d’une structure arborescente
   2. Tracer l’arbre en utilisant matplotlib (dépendance optionnelle)
11. [**🔨 Exportation de l’Arbre**](https://bigtree.readthedocs.io/stable/bigtree/tree/export/)
   1. Afficher dans la console, en orientation verticale ou horizontale
   2. Exporter en *notation chaîne Newick*, *dictionnaire*, *dictionnaire imbriqué*, *DataFrame pandas* ou *DataFrame polars*
   3. Exporter l’arbre en *dot* (peut être sauvegardé en fichiers .dot, .png, .svg, .jpeg)
   4. Exporter l’arbre en *Pillow* (peut être sauvegardé en .png, .jpg)
   5. Exporter l’arbre en *Mermaid Flowchart* (peut s’afficher dans .md)
   6. Exporter l’arbre en *Pyvis Network* (peut s’afficher en .html interactif)
12. [**✔️ Workflows**](https://bigtree.readthedocs.io/stable/bigtree/workflows/app_todo)
   1. Exemples de workflows pour démonstration d’arbre !

--------

Pour l’implémentation de **l’Arbre Binaire**, il y a 4 composants principaux.
Le nœud binaire hérite du nœud, donc les composants dans l’implémentation de l’arbre sont aussi disponibles dans l’arbre binaire.

1. [**🌿 Nœud**](https://bigtree.readthedocs.io/stable/bigtree/node/binarynode)
   1. ``BinaryNode``, nœud avec règles d’arbre binaire
2. [**🎄 Arbre Binaire**](https://bigtree.readthedocs.io/stable/bigtree/binarytree/binarytree/)
   1. ``BinaryTree``, wrapper autour de ``BinaryNode``, fournissant des API de haut niveau pour construire, itérer, interroger et exporter toute la structure d’arbre
3. [**✨ Construction de l’Arbre Binaire**](https://bigtree.readthedocs.io/stable/bigtree/binarytree/construct/)
   1. Depuis une *liste*, utilisant une structure de liste aplatie
4. [**➰ Parcours de l’Arbre Binaire**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)
   1. Parcours en ordre

-----

Pour l’implémentation du **Graphe Orienté Acyclique (DAG)**, il y a 6 composants principaux.

1. [**🌼 Nœud**](https://bigtree.readthedocs.io/stable/bigtree/node/dagnode/)
   1. ``DAGNode``, classe extensible pour construire un Graphe Orienté Acyclique (DAG)
2. [**🎄 DAG**](https://bigtree.readthedocs.io/stable/bigtree/dag/dag/)
   1. ``DAG``, wrapper autour de ``DAGNode``, fournissant des API de haut niveau pour construire, exporter et itérer sur tout le DAG
3. [**✨ Construction du DAG**](https://bigtree.readthedocs.io/stable/bigtree/dag/construct/)
   1. Depuis une *liste*, contenant des tuples parent-enfant
   2. Depuis un *dictionnaire imbriqué*
   3. Depuis un *DataFrame pandas*
4. [**➰ Parcours du DAG**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)
   1. Méthode de parcours générique
5. [**🧩 Analyse du DAG**](https://bigtree.readthedocs.io/stable/bigtree/dag/parsing/)
   1. Obtenir les chemins possibles d’un nœud à un autre
6. [**🔨 Exportation du DAG**](https://bigtree.readthedocs.io/stable/bigtree/dag/export/)
   1. Exporter en *liste*, *dictionnaire* ou *DataFrame pandas*
   2. Exporter le DAG au format *dot* (peut être enregistré en fichiers .dot, .png, .svg, .jpeg)

-----

## Installation

`bigtree` nécessite Python 3.10+. Il existe deux façons d’installer `bigtree`, avec pip (recommandé) ou conda.

### a) Installation avec pip

#### Installation de base

Pour installer `bigtree`, exécutez la ligne suivante dans l’invite de commande :

```console
$ pip install bigtree
```

#### Installation des dépendances optionnelles

`bigtree` dispose d'un certain nombre de dépendances optionnelles, qui peuvent être installées en utilisant la syntaxe "extras".

```console
$ pip install 'bigtree[extra_1, extra_2]'
```
Exemples de paquets supplémentaires incluent :

- `all` : inclure toutes les dépendances optionnelles
- `image` : pour exporter l'arbre en image
- `matplotlib` : pour tracer les arbres
- `pandas` : pour les méthodes pandas
- `polars` : pour les méthodes polars
- `query` : pour les méthodes de requête d'arbre
- `vis` : pour la visualisation pyvis

Pour la dépendance supplémentaire `image`, vous devrez peut-être installer plus de plugins.


```console
$ brew install gprof2dot  # for MacOS
$ conda install graphviz  # for Windows
```

### b) Installation avec conda

Pour installer `bigtree` avec conda, exécutez la ligne suivante dans l'invite de commande :

```console
$ conda install -c conda-forge bigtree
```

-----

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=kayjan/bigtree&type=Date)](https://star-history.com/#kayjan/bigtree&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---