# Algorithmes et Structures de Données JavaScript

> 🇺🇦 L’UKRAINE [EST ATTAQUÉE](https://war.ukraine.ua/) PAR L’ARMÉE RUSSE. DES CIVILS SONT TUÉS. DES ZONES RÉSIDENTIELLES SONT BOMBARDÉES.
> - Aidez l’Ukraine via :
>   - [Fondation caritative Serhiy Prytula](https://prytulafoundation.org/en/)
>   - [Fondation caritative Come Back Alive](https://savelife.in.ua/en/donate-en/)
>   - [Banque Nationale d’Ukraine](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - Plus d’informations sur [war.ukraine.ua](https://war.ukraine.ua/) et [MFA of Ukraine](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

Ce dépôt contient des exemples d’algorithmes et de structures de données populaires
en JavaScript.

Chaque algorithme et structure de données dispose de son propre fichier README
avec des explications associées et des liens pour approfondir le sujet (y compris des liens
vers des vidéos YouTube).

_Lire ceci dans d’autres langues :_
[_简体中文_](README.zh-CN.md),
[_繁體中文_](README.zh-TW.md),
[_한국어_](README.ko-KR.md),
[_日本語_](README.ja-JP.md),
[_Polski_](README.pl-PL.md),
[_Français_](README.fr-FR.md),
[_Español_](README.es-ES.md),
[_Português_](README.pt-BR.md),
[_Русский_](README.ru-RU.md),
[_Türkçe_](README.tr-TR.md),
[_Italiano_](README.it-IT.md),
[_Bahasa Indonesia_](README.id-ID.md),
[_Українська_](README.uk-UA.md),
[_Arabic_](README.ar-AR.md),
[_Tiếng Việt_](README.vi-VN.md),
[_Deutsch_](README.de-DE.md),
[_Uzbek_](README.uz-UZ.md),
[_עברית_](README.he-IL.md)

*☝ Notez que ce projet est destiné uniquement à des fins d’apprentissage et de recherche,
et n’est **pas** destiné à un usage en production.*

## Structures de Données

Une structure de données est une manière particulière d’organiser et de stocker des données dans un ordinateur afin qu’elles puissent être
accédées et modifiées efficacement. Plus précisément, une structure de données est une collection de valeurs de données,
les relations entre elles, et les fonctions ou opérations qui peuvent être appliquées à ces données.

Rappelez-vous que chaque structure de données a ses propres compromis. Il est important de prêter attention à la raison pour laquelle vous choisissez une structure de données particulière plutôt qu’à la façon de l’implémenter.

`B` - Débutant, `A` - Avancé

* `B` [Liste Chaînée](src/data-structures/linked-list)
* `B` [Liste Doubly Chaînée](src/data-structures/doubly-linked-list)
* `B` [File (Queue)](src/data-structures/queue)
* `B` [Pile (Stack)](src/data-structures/stack)
* `B` [Table de Hachage](src/data-structures/hash-table)
* `B` [Tas (Heap)](src/data-structures/heap) - versions max et min
* `B` [File de Priorité](src/data-structures/priority-queue)
* `A` [Trie](src/data-structures/trie)
* `A` [Arbre (Tree)](src/data-structures/tree)
  * `A` [Arbre Binaire de Recherche](src/data-structures/tree/binary-search-tree)
  * `A` [Arbre AVL](src/data-structures/tree/avl-tree)
  * `A` [Arbre Rouge-Noir](src/data-structures/tree/red-black-tree)
  * `A` [Arbre de Segments](src/data-structures/tree/segment-tree) - avec exemples de requêtes min/max/somme sur des intervalles
  * `A` [Arbre de Fenwick](src/data-structures/tree/fenwick-tree) (Arbre binaire indexé)
* `A` [Graphe](src/data-structures/graph) (orienté et non orienté)
* `A` [Ensemble Disjoint](src/data-structures/disjoint-set) - structure union-find
* `A` [Filtre de Bloom](src/data-structures/bloom-filter)
* `A` [Cache LRU](src/data-structures/lru-cache/) - cache Least Recently Used (LRU)

## Algorithmes

Un algorithme est une spécification non ambiguë de la façon de résoudre une classe de problèmes. C’est
un ensemble de règles qui définit précisément une séquence d’opérations.

`B` - Débutant, `A` - Avancé

### Algorithmes par Thème

* **Mathématiques**
  * `B` [Manipulation de Bits](src/algorithms/math/bits) - définir/obtenir/modifier/effacer des bits, multiplication/division par deux, rendre négatif, etc.
  * `B` [Nombre Flottant Binaire](src/algorithms/math/binary-floating-point) - représentation binaire des nombres flottants.
  * `B` [Factorielle](src/algorithms/math/factorial)
  * `B` [Nombre de Fibonacci](src/algorithms/math/fibonacci) - versions classique et forme fermée
  * `B` [Facteurs Premiers](src/algorithms/math/prime-factors) - recherche des facteurs premiers et leur comptage via le théorème de Hardy-Ramanujan
  * `B` [Test de Primalité](src/algorithms/math/primality-test) (méthode de division d’essai)
  * `B` [Algorithme d’Euclide](src/algorithms/math/euclidean-algorithm) - calcul du Plus Grand Commun Diviseur (PGCD)
  * `B` [Plus Petit Commun Multiple](src/algorithms/math/least-common-multiple) (PPCM)
  * `B` [Crible d’Ératosthène](src/algorithms/math/sieve-of-eratosthenes) - trouver tous les nombres premiers jusqu’à une limite donnée
  * `B` [Puissance de Deux](src/algorithms/math/is-power-of-two) - vérifier si un nombre est une puissance de deux (algorithmes naïf et bit à bit)
  * `B` [Triangle de Pascal](src/algorithms/math/pascal-triangle)
  * `B` [Nombre Complexe](src/algorithms/math/complex-number) - nombres complexes et opérations de base
  * `B` [Radian & Degré](src/algorithms/math/radian) - conversion radian/degré et inversement
  * `B` [Puissance Rapide](src/algorithms/math/fast-powering)
  * `B` [Méthode de Horner](src/algorithms/math/horner-method) - évaluation de polynômes
  * `B` [Matrices](src/algorithms/math/matrix) - matrices et opérations basiques (multiplication, transposition, etc.)
  * `B` [Distance Euclidienne](src/algorithms/math/euclidean-distance) - distance entre deux points/vecteurs/matrices
  * `A` [Partition d’Entier](src/algorithms/math/integer-partition)
  * `A` [Racine Carrée](src/algorithms/math/square-root) - méthode de Newton
  * `A` [Algorithme de Liu Hui pour π](src/algorithms/math/liu-hui) - approximation de π basée sur des polygones réguliers
  * `A` [Transformation de Fourier Discrète](src/algorithms/math/fourier-transform) - décomposition d’un signal dans ses fréquences
* **Ensembles**
  * `B` [Produit Cartésien](src/algorithms/sets/cartesian-product) - produit de plusieurs ensembles
  * `B` [Mélange de Fisher-Yates](src/algorithms/sets/fisher-yates) - permutation aléatoire d’une séquence finie
  * `A` [Ensemble des Parties](src/algorithms/sets/power-set) - tous les sous-ensembles d’un ensemble (solutions bit à bit, backtracking et en cascade)
  * `A` [Permutations](src/algorithms/sets/permutations) (avec et sans répétitions)
  * `A` [Combinaisons](src/algorithms/sets/combinations) (avec et sans répétitions)
  * `A` [Plus Longue Sous-séquence Commune](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Plus Longue Sous-séquence Croissante](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Plus Courte Super-séquence Commune](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [Problème du Sac à Dos](src/algorithms/sets/knapsack-problem) - versions "0/1" et "non bornée"
  * `A` [Sous-tableau de Somme Maximale](src/algorithms/sets/maximum-subarray) - versions "force brute" et "programmation dynamique" (Kadane)
  * `A` [Somme de Combinaisons](src/algorithms/sets/combination-sum) - trouver toutes les combinaisons qui forment une somme donnée
* **Chaînes**
  * `B` [Distance de Hamming](src/algorithms/string/hamming-distance) - nombre de positions différentes entre deux chaînes
  * `B` [Palindrome](src/algorithms/string/palindrome) - vérifier si la chaîne est la même à l’envers
  * `A` [Distance de Levenshtein](src/algorithms/string/levenshtein-distance) - distance minimale d’édition entre deux séquences
  * `A` [Algorithme de Knuth-Morris-Pratt](src/algorithms/string/knuth-morris-pratt) (KMP) - recherche de sous-chaîne (reconnaissance de motif)
  * `A` [Algorithme Z](src/algorithms/string/z-algorithm) - recherche de sous-chaîne (reconnaissance de motif)
  * `A` [Algorithme de Rabin Karp](src/algorithms/string/rabin-karp) - recherche de sous-chaîne
  * `A` [Plus Longue Sous-chaîne Commune](src/algorithms/string/longest-common-substring)
  * `A` [Appariement d’Expressions Régulières](src/algorithms/string/regular-expression-matching)
* **Recherches**
  * `B` [Recherche Linéaire](src/algorithms/search/linear-search)
  * `B` [Recherche par Sauts](src/algorithms/search/jump-search) (ou recherche par blocs) - recherche dans un tableau trié
  * `B` [Recherche Binaire](src/algorithms/search/binary-search) - recherche dans un tableau trié
  * `B` [Recherche par Interpolation](src/algorithms/search/interpolation-search) - recherche dans un tableau trié uniformément distribué
* **Tri**
  * `B` [Tri à Bulles](src/algorithms/sorting/bubble-sort)
  * `B` [Tri par Sélection](src/algorithms/sorting/selection-sort)
  * `B` [Tri par Insertion](src/algorithms/sorting/insertion-sort)
  * `B` [Tri par Tas](src/algorithms/sorting/heap-sort)
  * `B` [Tri Fusion](src/algorithms/sorting/merge-sort)
  * `B` [Tri Rapide (Quicksort)](src/algorithms/sorting/quick-sort) - implémentations en place et non en place
  * `B` [Tri de Shell](src/algorithms/sorting/shell-sort)
  * `B` [Tri par Comptage](src/algorithms/sorting/counting-sort)
  * `B` [Tri Radix](src/algorithms/sorting/radix-sort)
  * `B` [Tri par Seaux (Bucket Sort)](src/algorithms/sorting/bucket-sort)
* **Listes Chaînées**
  * `B` [Parcours Simple](src/algorithms/linked-list/traversal)
  * `B` [Parcours Inversé](src/algorithms/linked-list/reverse-traversal)
* **Arbres**
  * `B` [Parcours en Profondeur](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Parcours en Largeur](src/algorithms/tree/breadth-first-search) (BFS)
* **Graphes**
  * `B` [Parcours en Profondeur](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Parcours en Largeur](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [Algorithme de Kruskal](src/algorithms/graph/kruskal) - recherche de l’Arbre de Couverture Minimum (MST) pour un graphe non orienté pondéré
  * `A` [Algorithme de Dijkstra](src/algorithms/graph/dijkstra) - recherche des plus courts chemins depuis un sommet
  * `A` [Algorithme de Bellman-Ford](src/algorithms/graph/bellman-ford) - recherche des plus courts chemins depuis un sommet
  * `A` [Algorithme de Floyd-Warshall](src/algorithms/graph/floyd-warshall) - recherche des plus courts chemins entre toutes les paires de sommets
  * `A` [Détection de Cycle](src/algorithms/graph/detect-cycle) - pour graphes orientés et non orientés (versions DFS et Ensemble Disjoint)
  * `A` [Algorithme de Prim](src/algorithms/graph/prim) - recherche de l’Arbre de Couverture Minimum (MST)
  * `A` [Tri Topologique](src/algorithms/graph/topological-sorting) - méthode DFS
  * `A` [Points d’Articulation](src/algorithms/graph/articulation-points) - algorithme de Tarjan (basé sur DFS)
  * `A` [Ponts](src/algorithms/graph/bridges) - algorithme basé sur DFS
  * `A` [Chemin et Circuit Eulérien](src/algorithms/graph/eulerian-path) - algorithme de Fleury - visiter chaque arête une fois
  * `A` [Cycle Hamiltonien](src/algorithms/graph/hamiltonian-cycle) - visiter chaque sommet une fois
  * `A` [Composantes Fortement Connexes](src/algorithms/graph/strongly-connected-components) - algorithme de Kosaraju
  * `A` [Problème du Voyageur de Commerce](src/algorithms/graph/travelling-salesman) - plus court chemin visitant chaque ville et revenant à l’origine
* **Cryptographie**
  * `B` [Hachage Polynomial](src/algorithms/cryptography/polynomial-hash) - fonction de hachage glissant basée sur un polynôme
  * `B` [Chiffre Rail Fence](src/algorithms/cryptography/rail-fence-cipher) - algorithme de chiffrement par transposition
  * `B` [Chiffre de César](src/algorithms/cryptography/caesar-cipher) - chiffrement par substitution simple
  * `B` [Chiffre de Hill](src/algorithms/cryptography/hill-cipher) - chiffrement basé sur l’algèbre linéaire
* **Apprentissage Automatique**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 7 fonctions JS simples illustrant l’apprentissage machine (propagation avant/arrière)
  * `B` [k-NN](src/algorithms/ml/knn) - algorithme de classification des k plus proches voisins
  * `B` [k-Means](src/algorithms/ml/k-means) - algorithme de clustering k-Means
* **Traitement d’Images**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - redimensionnement d’image intelligent
* **Statistiques**
  * `B` [Aléatoire Pondéré](src/algorithms/statistics/weighted-random) - sélectionner un élément au hasard en fonction de son poids
* **Algorithmes Évolutionnaires**
  * `A` [Algorithme Génétique](https://github.com/trekhleb/self-parking-car-evolution) - exemple d’utilisation pour l’apprentissage de voitures autonomes
* **Non Classés**
  * `B` [Tours de Hanoï](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Rotation de Matrice Carrée](src/algorithms/uncategorized/square-matrix-rotation) - algorithme en place
  * `B` [Jeu de Sauts (Jump Game)](src/algorithms/uncategorized/jump-game) - backtracking, programmation dynamique (top-down + bottom-up) et exemples gloutons
  * `B` [Chemins Uniques](src/algorithms/uncategorized/unique-paths) - backtracking, programmation dynamique et triangle de Pascal
  * `B` [Terrasses de Pluie](src/algorithms/uncategorized/rain-terraces) - problème de piégeage d’eau (programmation dynamique et force brute)
  * `B` [Escalier Récursif](src/algorithms/uncategorized/recursive-staircase) - compter le nombre de façons d’atteindre le sommet (4 solutions)
  * `B` [Meilleur Moment pour Acheter/Vendre des Actions](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - exemples diviser pour régner et en un passage
  * `B` [Parenthèses Valides](src/algorithms/stack/valid-parentheses) - vérifier la validité d’une chaîne de parenthèses (pile)
  * `A` [Problème des N-Reines](src/algorithms/uncategorized/n-queens)
  * `A` [Tour du Cavalier](src/algorithms/uncategorized/knight-tour)

### Algorithmes par Paradigme

Un paradigme algorithmique est une méthode ou approche générique qui sous-tend la conception d’une classe
d’algorithmes. Il s’agit d’une abstraction supérieure à la notion d’algorithme, tout comme un algorithme est une abstraction supérieure à un programme informatique.

* **Force Brute** – examine toutes les possibilités et sélectionne la meilleure solution
  * `B` [Recherche Linéaire](src/algorithms/search/linear-search)
  * `B` [Terrasses de Pluie](src/algorithms/uncategorized/rain-terraces) - problème de piégeage d’eau
  * `B` [Escalier Récursif](src/algorithms/uncategorized/recursive-staircase) - compter le nombre de façons d’atteindre le sommet
  * `A` [Sous-tableau de Somme Maximale](src/algorithms/sets/maximum-subarray)
  * `A` [Problème du Voyageur de Commerce](src/algorithms/graph/travelling-salesman)
  * `A` [Transformation de Fourier Discrète](src/algorithms/math/fourier-transform)
* **Glouton** – choisit la meilleure option à l’instant présent, sans considération pour l’avenir
  * `B` [Jeu de Sauts (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `A` [Problème du Sac à Dos non borné](src/algorithms/sets/knapsack-problem)
  * `A` [Algorithme de Dijkstra](src/algorithms/graph/dijkstra)
  * `A` [Algorithme de Prim](src/algorithms/graph/prim)
  * `A` [Algorithme de Kruskal](src/algorithms/graph/kruskal)
* **Diviser pour Régner** – divise le problème en sous-problèmes et résout ceux-ci
  * `B` [Recherche Binaire](src/algorithms/search/binary-search)
  * `B` [Tours de Hanoï](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Triangle de Pascal](src/algorithms/math/pascal-triangle)
  * `B` [Algorithme d’Euclide](src/algorithms/math/euclidean-algorithm)
  * `B` [Tri Fusion](src/algorithms/sorting/merge-sort)
  * `B` [Tri Rapide](src/algorithms/sorting/quick-sort)
  * `B` [Parcours en Profondeur d’Arbre](src/algorithms/tree/depth-first-search)
  * `B` [Parcours en Profondeur de Graphe](src/algorithms/graph/depth-first-search)
  * `B` [Matrices](src/algorithms/math/matrix)
  * `B` [Jeu de Sauts (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `B` [Puissance Rapide](src/algorithms/math/fast-powering)
  * `B` [Meilleur Moment pour Acheter/Vendre des Actions](src/algorithms/uncategorized/best-time-to-buy-sell-stocks)
  * `A` [Permutations](src/algorithms/sets/permutations)
  * `A` [Combinaisons](src/algorithms/sets/combinations)
  * `A` [Sous-tableau de Somme Maximale](src/algorithms/sets/maximum-subarray)
* **Programmation Dynamique** – construit une solution à partir de sous-solutions déjà trouvées
  * `B` [Nombre de Fibonacci](src/algorithms/math/fibonacci)
  * `B` [Jeu de Sauts (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `B` [Chemins Uniques](src/algorithms/uncategorized/unique-paths)
  * `B` [Terrasses de Pluie](src/algorithms/uncategorized/rain-terraces)
  * `B` [Escalier Récursif](src/algorithms/uncategorized/recursive-staircase)
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving)
  * `A` [Distance de Levenshtein](src/algorithms/string/levenshtein-distance)
  * `A` [Plus Longue Sous-séquence Commune](src/algorithms/sets/longest-common-subsequence)
  * `A` [Plus Longue Sous-chaîne Commune](src/algorithms/string/longest-common-substring)
  * `A` [Plus Longue Sous-séquence Croissante](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Plus Courte Super-séquence Commune](src/algorithms/sets/shortest-common-supersequence)
  * `A` [Problème du Sac à Dos 0/1](src/algorithms/sets/knapsack-problem)
  * `A` [Partition d’Entier](src/algorithms/math/integer-partition)
  * `A` [Sous-tableau de Somme Maximale](src/algorithms/sets/maximum-subarray)
  * `A` [Algorithme de Bellman-Ford](src/algorithms/graph/bellman-ford)
  * `A` [Algorithme de Floyd-Warshall](src/algorithms/graph/floyd-warshall)
  * `A` [Appariement d’Expressions Régulières](src/algorithms/string/regular-expression-matching)
* **Backtracking** – de manière similaire à la force brute, essaie de générer toutes les solutions possibles, mais à chaque génération d’une nouvelle solution, teste
si elle satisfait toutes les conditions, puis continue ou revient en arrière pour explorer un autre chemin. En général, un parcours DFS de l’espace d’états est utilisé.
  * `B` [Jeu de Sauts (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `B` [Chemins Uniques](src/algorithms/uncategorized/unique-paths)
  * `B` [Ensemble des Parties](src/algorithms/sets/power-set)
  * `A` [Cycle Hamiltonien](src/algorithms/graph/hamiltonian-cycle)
  * `A` [Problème des N-Reines](src/algorithms/uncategorized/n-queens)
  * `A` [Tour du Cavalier](src/algorithms/uncategorized/knight-tour)
  * `A` [Somme de Combinaisons](src/algorithms/sets/combination-sum)
* **Branch & Bound** – mémorise la solution de coût minimal trouvée à chaque étape du backtracking,
et utilise ce coût comme borne inférieure pour éliminer les solutions partielles ayant un coût supérieur. En général, un parcours BFS combiné à DFS sur l’arbre d’états est utilisé.

## Comment utiliser ce dépôt

**Installer toutes les dépendances**

```
npm install
```

**Lancer ESLint**

Vous pouvez le lancer pour vérifier la qualité du code.

```
npm run lint
```

**Lancer tous les tests**

```
npm test
```

**Lancer les tests par nom**

```
npm test -- 'LinkedList'
```

**Dépannage**

Si le linting ou les tests échouent, essayez de supprimer le dossier `node_modules` et de réinstaller les paquets npm :

```
rm -rf ./node_modules
npm i
```

Vérifiez aussi que vous utilisez la bonne version de Node (`>=16`). Si vous utilisez [nvm](https://github.com/nvm-sh/nvm) pour la gestion de version Node, vous pouvez lancer `nvm use` depuis le dossier racine du projet et la bonne version sera sélectionnée.

**Aire de jeu (Playground)**

Vous pouvez expérimenter avec les structures de données et algorithmes dans le fichier `./src/playground/playground.js` et écrire
des tests dans `./src/playground/__test__/playground.test.js`.

Ensuite, lancez simplement la commande suivante pour tester votre code playground :

```
npm test -- 'playground'
```

## Informations Utiles

### Références

- [▶ Structures de Données et Algorithmes sur YouTube](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 Croquis de Structures de Données](https://okso.app/showcase/data-structures)

### Notation Big O

*La notation Big O* est utilisée pour classer les algorithmes selon la croissance de leur temps d’exécution ou de leur espace mémoire en fonction de la taille de l’entrée.
Sur le graphique ci-dessous, vous trouverez les ordres de croissance les plus courants d’algorithmes spécifiés en notation Big O.

![Graphiques Big O](./assets/big-o-graph.png)

Source : [Big O Cheat Sheet](http://bigocheatsheet.com/).

Voici la liste de quelques notations Big O les plus utilisées et leur comparaison de performance sur différentes tailles d’entrée.

| Notation Big O | Type        | Calculs pour 10 éléments | Calculs pour 100 éléments | Calculs pour 1000 éléments  |
| -------------- | ----------- | ------------------------ | ------------------------- | --------------------------- |
| **O(1)**       | Constant    | 1                        | 1                         | 1                           |
| **O(log N)**   | Logarithmique | 3                      | 6                         | 9                           |
| **O(N)**       | Linéaire    | 10                       | 100                       | 1000                        |
| **O(N log N)** | n log(n)    | 30                       | 600                       | 9000                        |
| **O(N^2)**     | Quadratique | 100                      | 10000                     | 1000000                     |
| **O(2^N)**     | Exponentielle | 1024                   | 1.26e+29                  | 1.07e+301                   |
| **O(N!)**      | Factorielle | 3628800                  | 9.3e+157                  | 4.02e+2567                  |

### Complexité des Opérations sur les Structures de Données

| Structure de Données      | Accès   | Recherche | Insertion | Suppression | Commentaires |
| ------------------------- | :-----: | :-------: | :-------: | :---------: | :----------- |
| **Tableau**               | 1       | n         | n         | n           |              |
| **Pile**                  | n       | n         | 1         | 1           |              |
| **File**                  | n       | n         | 1         | 1           |              |
| **Liste Chaînée**         | n       | n         | 1         | n           |              |
| **Table de Hachage**      | -       | n         | n         | n           | En cas de fonction de hachage parfaite, le coût serait O(1) |
| **Arbre Binaire de Recherche** | n   | n         | n         | n           | En cas d’arbre équilibré, le coût est O(log(n)) |
| **B-Tree**                | log(n)  | log(n)    | log(n)    | log(n)      |              |
| **Arbre Rouge-Noir**      | log(n)  | log(n)    | log(n)    | log(n)      |              |
| **Arbre AVL**             | log(n)  | log(n)    | log(n)    | log(n)      |              |
| **Filtre de Bloom**       | -       | 1         | 1         | -           | Faux positifs possibles en recherche |

### Complexité des Algorithmes de Tri de Tableau

| Nom                   | Meilleur        | Moyen               | Pire                | Mémoire    | Stable    | Commentaires |
| --------------------- | :-------------: | :-----------------: | :-----------------: | :--------: | :-------: | :----------- |
| **Tri à Bulles**      | n               | n<sup>2</sup>       | n<sup>2</sup>       | 1          | Oui       |              |
| **Tri par Insertion** | n               | n<sup>2</sup>       | n<sup>2</sup>       | 1          | Oui       |              |
| **Tri par Sélection** | n<sup>2</sup>   | n<sup>2</sup>       | n<sup>2</sup>       | 1          | Non       |              |
| **Tri par Tas**       | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)       | 1          | Non       |              |
| **Tri Fusion**        | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)       | n          | Oui       |              |
| **Tri Rapide**        | n&nbsp;log(n)   | n&nbsp;log(n)       | n<sup>2</sup>       | log(n)     | Non       | Habituellement en place avec O(log(n)) d’espace pile |
| **Tri de Shell**      | n&nbsp;log(n)   | dépend de la séquence de gaps | n&nbsp;(log(n))<sup>2</sup>  | 1          | Non        |              |
| **Tri par Comptage**  | n + r           | n + r               | n + r               | n + r      | Oui       | r – plus grand nombre du tableau |
| **Tri Radix**         | n * k           | n * k               | n * k               | n + k      | Oui       | k – longueur de la plus longue clé |

## Soutiens du Projet

> Vous pouvez soutenir ce projet via ❤️️ [GitHub](https://github.com/sponsors/trekhleb) ou ❤️️ [Patreon](https://www.patreon.com/trekhleb).

[Les soutiens de ce projet](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## Auteur

[@trekhleb](https://trekhleb.dev)

Encore plus de [projets](https://trekhleb.dev/projects/) et [articles](https://trekhleb.dev/blog/) sur JavaScript et les algorithmes sur [trekhleb.dev](https://trekhleb.dev)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---