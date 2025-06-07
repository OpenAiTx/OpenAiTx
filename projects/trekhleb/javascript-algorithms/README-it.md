# Algoritmi e Strutture Dati in JavaScript

> 🇺🇦 L’UCRAINA [È SOTTO ATTACCO](https://war.ukraine.ua/) DALL’ESERCITO RUSSO. I CIVILI VENGONO UCCISI. LE ZONE RESIDENZIALI SONO BOMBARDATE.
> - Aiuta l’Ucraina tramite:
>   - [Fondazione di beneficenza Serhiy Prytula](https://prytulafoundation.org/en/)
>   - [Fondazione di beneficenza Come Back Alive](https://savelife.in.ua/en/donate-en/)
>   - [Banca Nazionale dell’Ucraina](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - Maggiori informazioni su [war.ukraine.ua](https://war.ukraine.ua/) e [MFA of Ukraine](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

Questo repository contiene esempi in JavaScript di molti
algoritmi e strutture dati popolari.

Ogni algoritmo e struttura dati ha il proprio README separato
con spiegazioni collegate e link per approfondimenti (inclusi link
a video YouTube).

_Leggi questo in altre lingue:_
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

*☝ Nota che questo progetto è pensato solo per scopi didattici e di ricerca
e **non** per l’uso in produzione.*

## Strutture Dati

Una struttura dati è un modo particolare di organizzare e memorizzare i dati in un computer affinché possano
essere accessibili e modificati in modo efficiente. Più precisamente, una struttura dati è una collezione di valori,
le relazioni tra di essi e le funzioni o operazioni che possono essere applicate ai dati.

Ricorda che ogni struttura dati ha i suoi compromessi. È più importante capire perché scegli una certa struttura dati che come implementarla.

`B` - Base, `A` - Avanzato

* `B` [Lista Collegata (Linked List)](src/data-structures/linked-list)
* `B` [Lista Doppiamente Collegata (Doubly Linked List)](src/data-structures/doubly-linked-list)
* `B` [Coda (Queue)](src/data-structures/queue)
* `B` [Pila (Stack)](src/data-structures/stack)
* `B` [Tabella Hash (Hash Table)](src/data-structures/hash-table)
* `B` [Heap](src/data-structures/heap) - versioni max e min heap
* `B` [Coda a Priorità (Priority Queue)](src/data-structures/priority-queue)
* `A` [Trie](src/data-structures/trie)
* `A` [Albero (Tree)](src/data-structures/tree)
  * `A` [Albero Binario di Ricerca (Binary Search Tree)](src/data-structures/tree/binary-search-tree)
  * `A` [Albero AVL (AVL Tree)](src/data-structures/tree/avl-tree)
  * `A` [Albero Rosso-Nero (Red-Black Tree)](src/data-structures/tree/red-black-tree)
  * `A` [Segment Tree](src/data-structures/tree/segment-tree) - esempi di query di intervallo min/max/somma
  * `A` [Albero di Fenwick (Fenwick Tree)](src/data-structures/tree/fenwick-tree) (Binary Indexed Tree)
* `A` [Grafo (Graph)](src/data-structures/graph) (sia orientato che non orientato)
* `A` [Insieme Disgiunto (Disjoint Set)](src/data-structures/disjoint-set) - struttura dati union–find o merge–find set
* `A` [Filtro di Bloom (Bloom Filter)](src/data-structures/bloom-filter)
* `A` [Cache LRU (LRU Cache)](src/data-structures/lru-cache/) - cache Least Recently Used (LRU)

## Algoritmi

Un algoritmo è una specifica non ambigua su come risolvere una classe di problemi. È
un insieme di regole che definiscono con precisione una sequenza di operazioni.

`B` - Base, `A` - Avanzato

### Algoritmi per Argomento

* **Matematica**
  * `B` [Manipolazione Bit](src/algorithms/math/bits) - set/get/update/clear bit, moltiplicazione/divisione per due, negazione ecc.
  * `B` [Floating Point Binario](src/algorithms/math/binary-floating-point) - rappresentazione binaria dei numeri floating-point.
  * `B` [Fattoriale (Factorial)](src/algorithms/math/factorial)
  * `B` [Numero di Fibonacci](src/algorithms/math/fibonacci) - versioni classiche e forma chiusa
  * `B` [Fattori Primi (Prime Factors)](src/algorithms/math/prime-factors) - trovare i fattori primi e contarli usando il teorema di Hardy-Ramanujan
  * `B` [Test di Primalità (Primality Test)](src/algorithms/math/primality-test) (metodo divisione per tentativi)
  * `B` [Algoritmo Euclideo](src/algorithms/math/euclidean-algorithm) - calcolo del massimo comun divisore (GCD)
  * `B` [Minimo Comune Multiplo (Least Common Multiple)](src/algorithms/math/least-common-multiple) (LCM)
  * `B` [Crivello di Eratostene (Sieve of Eratosthenes)](src/algorithms/math/sieve-of-eratosthenes) - trovare tutti i numeri primi fino a un limite dato
  * `B` [Potenza di Due (Is Power of Two)](src/algorithms/math/is-power-of-two) - verifica se il numero è potenza di due (algoritmi ingenui e bitwise)
  * `B` [Triangolo di Pascal (Pascal's Triangle)](src/algorithms/math/pascal-triangle)
  * `B` [Numero Complesso (Complex Number)](src/algorithms/math/complex-number) - numeri complessi e operazioni di base
  * `B` [Radianti & Gradi (Radian & Degree)](src/algorithms/math/radian) - conversione da radianti a gradi e viceversa
  * `B` [Elevamento Rapido a Potenza (Fast Powering)](src/algorithms/math/fast-powering)
  * `B` [Metodo di Horner (Horner's method)](src/algorithms/math/horner-method) - valutazione di polinomi
  * `B` [Matrici (Matrices)](src/algorithms/math/matrix) - matrici e operazioni di base (moltiplicazione, trasposizione, ecc.)
  * `B` [Distanza Euclidea (Euclidean Distance)](src/algorithms/math/euclidean-distance) - distanza tra due punti/vettori/matrici
  * `A` [Partizione di Interi (Integer Partition)](src/algorithms/math/integer-partition)
  * `A` [Radice Quadrata (Square Root)](src/algorithms/math/square-root) - metodo di Newton
  * `A` [Algoritmo di Liu Hui per π (Liu Hui π Algorithm)](src/algorithms/math/liu-hui) - approssimazione di π basata su poligoni N-gon
  * `A` [Trasformata di Fourier Discreta (Discrete Fourier Transform)](src/algorithms/math/fourier-transform) - decomposizione di un segnale nel dominio delle frequenze
* **Insiemi**
  * `B` [Prodotto Cartesiano (Cartesian Product)](src/algorithms/sets/cartesian-product) - prodotto di insiemi multipli
  * `B` [Shuffle di Fisher–Yates](src/algorithms/sets/fisher-yates) - permutazione casuale di una sequenza finita
  * `A` [Insieme Potenza (Power Set)](src/algorithms/sets/power-set) - tutti i sottoinsiemi di un insieme (soluzioni bitwise, backtracking, e cascading)
  * `A` [Permutazioni (Permutations)](src/algorithms/sets/permutations) (con e senza ripetizioni)
  * `A` [Combinazioni (Combinations)](src/algorithms/sets/combinations) (con e senza ripetizioni)
  * `A` [Sottosequenza Comune Massima (Longest Common Subsequence)](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Sottosequenza Crescente Massima (Longest Increasing Subsequence)](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Supersequenza Comune più Breve (Shortest Common Supersequence)](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [Problema dello Zaino (Knapsack Problem)](src/algorithms/sets/knapsack-problem) - versioni "0/1" e "senza limiti"
  * `A` [Sottoarray Massimo (Maximum Subarray)](src/algorithms/sets/maximum-subarray) - versioni "Forza Bruta" e "Programmazione Dinamica" (Kadane)
  * `A` [Somma di Combinazioni (Combination Sum)](src/algorithms/sets/combination-sum) - tutte le combinazioni che formano una somma specifica
* **Stringhe**
  * `B` [Distanza di Hamming (Hamming Distance)](src/algorithms/string/hamming-distance) - numero di posizioni in cui i simboli differiscono
  * `B` [Palindromo (Palindrome)](src/algorithms/string/palindrome) - verifica se la stringa è uguale al contrario
  * `A` [Distanza di Levenshtein (Levenshtein Distance)](src/algorithms/string/levenshtein-distance) - distanza minima di modifica tra due sequenze
  * `A` [Algoritmo di Knuth–Morris–Pratt](src/algorithms/string/knuth-morris-pratt) (Algoritmo KMP) - ricerca di sottostringhe (pattern matching)
  * `A` [Algoritmo Z (Z Algorithm)](src/algorithms/string/z-algorithm) - ricerca di sottostringhe (pattern matching)
  * `A` [Algoritmo Rabin Karp](src/algorithms/string/rabin-karp) - ricerca di sottostringhe
  * `A` [Sottostringa Comune Massima (Longest Common Substring)](src/algorithms/string/longest-common-substring)
  * `A` [Matching con Espressioni Regolari (Regular Expression Matching)](src/algorithms/string/regular-expression-matching)
* **Ricerche**
  * `B` [Ricerca Lineare (Linear Search)](src/algorithms/search/linear-search)
  * `B` [Jump Search](src/algorithms/search/jump-search) (o Block Search) - ricerca in array ordinato
  * `B` [Ricerca Binaria (Binary Search)](src/algorithms/search/binary-search) - ricerca in array ordinato
  * `B` [Ricerca per Interpolazione (Interpolation Search)](src/algorithms/search/interpolation-search) - ricerca in array ordinato distribuito uniformemente
* **Ordinamenti**
  * `B` [Bubble Sort](src/algorithms/sorting/bubble-sort)
  * `B` [Selection Sort](src/algorithms/sorting/selection-sort)
  * `B` [Insertion Sort](src/algorithms/sorting/insertion-sort)
  * `B` [Heap Sort](src/algorithms/sorting/heap-sort)
  * `B` [Merge Sort](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort) - implementazioni in-place e non in-place
  * `B` [Shellsort](src/algorithms/sorting/shell-sort)
  * `B` [Counting Sort](src/algorithms/sorting/counting-sort)
  * `B` [Radix Sort](src/algorithms/sorting/radix-sort)
  * `B` [Bucket Sort](src/algorithms/sorting/bucket-sort)
* **Liste Collegate**
  * `B` [Attraversamento Diretto (Straight Traversal)](src/algorithms/linked-list/traversal)
  * `B` [Attraversamento Inverso (Reverse Traversal)](src/algorithms/linked-list/reverse-traversal)
* **Alberi**
  * `B` [Ricerca in Profondità (Depth-First Search)](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Ricerca in Ampiezza (Breadth-First Search)](src/algorithms/tree/breadth-first-search) (BFS)
* **Grafi**
  * `B` [Ricerca in Profondità (Depth-First Search)](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Ricerca in Ampiezza (Breadth-First Search)](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [Algoritmo di Kruskal (Kruskal’s Algorithm)](src/algorithms/graph/kruskal) - trovare l’albero ricoprente minimo (MST) per grafi pesati non orientati
  * `A` [Algoritmo di Dijkstra](src/algorithms/graph/dijkstra) - trovare il percorso più breve da un vertice a tutti gli altri
  * `A` [Algoritmo di Bellman-Ford](src/algorithms/graph/bellman-ford) - trovare il percorso più breve da un vertice a tutti gli altri
  * `A` [Algoritmo di Floyd-Warshall](src/algorithms/graph/floyd-warshall) - trovare i percorsi minimi tra tutte le coppie di vertici
  * `A` [Rilevamento Cicli (Detect Cycle)](src/algorithms/graph/detect-cycle) - sia per grafi orientati che non (versioni DFS e Disjoint Set)
  * `A` [Algoritmo di Prim (Prim’s Algorithm)](src/algorithms/graph/prim) - trovare l’albero ricoprente minimo (MST)
  * `A` [Ordinamento Topologico (Topological Sorting)](src/algorithms/graph/topological-sorting) - metodo DFS
  * `A` [Punti di Articolazione (Articulation Points)](src/algorithms/graph/articulation-points) - algoritmo di Tarjan (basato su DFS)
  * `A` [Ponti (Bridges)](src/algorithms/graph/bridges) - algoritmo basato su DFS
  * `A` [Cammino e Circuito Euleriano (Eulerian Path and Eulerian Circuit)](src/algorithms/graph/eulerian-path) - algoritmo di Fleury - visita ogni arco esattamente una volta
  * `A` [Ciclo Hamiltoniano (Hamiltonian Cycle)](src/algorithms/graph/hamiltonian-cycle) - visita ogni vertice esattamente una volta
  * `A` [Componenti Fortemente Connesse (Strongly Connected Components)](src/algorithms/graph/strongly-connected-components) - algoritmo di Kosaraju
  * `A` [Problema del Commesso Viaggiatore (Travelling Salesman Problem)](src/algorithms/graph/travelling-salesman) - percorso più breve che visita ogni città e ritorna all’origine
* **Crittografia**
  * `B` [Hash Polinomiale (Polynomial Hash)](src/algorithms/cryptography/polynomial-hash) - funzione di hash rolling basata su polinomi
  * `B` [Cifrario Rail Fence (Rail Fence Cipher)](src/algorithms/cryptography/rail-fence-cipher) - cifrario di trasposizione per codificare messaggi
  * `B` [Cifrario di Cesare (Caesar Cipher)](src/algorithms/cryptography/caesar-cipher) - cifrario a sostituzione semplice
  * `B` [Cifrario di Hill (Hill Cipher)](src/algorithms/cryptography/hill-cipher) - cifrario di sostituzione basato su algebra lineare
* **Machine Learning**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 7 semplici funzioni JS che illustrano come le macchine possano apprendere (propagazione avanti/indietro)
  * `B` [k-NN](src/algorithms/ml/knn) - algoritmo di classificazione k-nearest neighbors
  * `B` [k-Means](src/algorithms/ml/k-means) - algoritmo di clustering k-Means
* **Elaborazione Immagini**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - algoritmo di ridimensionamento immagini content-aware
* **Statistica**
  * `B` [Random Ponderato (Weighted Random)](src/algorithms/statistics/weighted-random) - seleziona un elemento casuale in base ai pesi
* **Algoritmi Evolutivi**
  * `A` [Algoritmo Genetico (Genetic algorithm)](https://github.com/trekhleb/self-parking-car-evolution) - esempio di applicazione per addestrare auto a parcheggio automatico
* **Non Categorizzati**
  * `B` [Torre di Hanoi (Tower of Hanoi)](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Rotazione di Matrice Quadrata (Square Matrix Rotation)](src/algorithms/uncategorized/square-matrix-rotation) - algoritmo in-place
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game) - esempi di backtracking, programmazione dinamica (top-down + bottom-up) e greedy
  * `B` [Percorsi Unici (Unique Paths)](src/algorithms/uncategorized/unique-paths) - esempi di backtracking, programmazione dinamica e basati su Triangolo di Pascal
  * `B` [Rain Terraces](src/algorithms/uncategorized/rain-terraces) - problema del trapping rain water (versioni programmazione dinamica e forza bruta)
  * `B` [Scala Ricorsiva (Recursive Staircase)](src/algorithms/uncategorized/recursive-staircase) - conta i modi per raggiungere la cima (4 soluzioni)
  * `B` [Momento Migliore per Comprare/Vendere Azioni (Best Time To Buy Sell Stocks)](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - esempi divide et impera e one-pass
  * `B` [Parentesi Valide (Valid Parentheses)](src/algorithms/stack/valid-parentheses) - verifica se una stringa ha parentesi valide (uso dello stack)
  * `A` [Problema delle N-Regine (N-Queens Problem)](src/algorithms/uncategorized/n-queens)
  * `A` [Tour del Cavallo (Knight's Tour)](src/algorithms/uncategorized/knight-tour)

### Algoritmi per Paradigma

Un paradigma algoritmico è un metodo generico o approccio che sottende la progettazione di una classe
di algoritmi. È un’astrazione superiore alla nozione di algoritmo, come un
algoritmo è un’astrazione superiore rispetto a un programma.

* **Forza Bruta** - valuta tutte le possibilità e seleziona la soluzione migliore
  * `B` [Ricerca Lineare (Linear Search)](src/algorithms/search/linear-search)
  * `B` [Rain Terraces](src/algorithms/uncategorized/rain-terraces) - problema del trapping rain water
  * `B` [Scala Ricorsiva (Recursive Staircase)](src/algorithms/uncategorized/recursive-staircase) - conteggio dei modi per arrivare in cima
  * `A` [Sottoarray Massimo (Maximum Subarray)](src/algorithms/sets/maximum-subarray)
  * `A` [Problema del Commesso Viaggiatore (Travelling Salesman Problem)](src/algorithms/graph/travelling-salesman) - percorso più breve che visita tutte le città e ritorna all’origine
  * `A` [Trasformata di Fourier Discreta (Discrete Fourier Transform)](src/algorithms/math/fourier-transform) - decomposizione di un segnale nel dominio delle frequenze
* **Greedy** - sceglie l’opzione migliore al momento, senza considerare il futuro
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `A` [Knapsack Problem senza limiti (Unbound Knapsack Problem)](src/algorithms/sets/knapsack-problem)
  * `A` [Algoritmo di Dijkstra](src/algorithms/graph/dijkstra) - ricerca del percorso più breve verso tutti i vertici
  * `A` [Algoritmo di Prim (Prim’s Algorithm)](src/algorithms/graph/prim) - albero ricoprente minimo
  * `A` [Algoritmo di Kruskal (Kruskal’s Algorithm)](src/algorithms/graph/kruskal) - albero ricoprente minimo
* **Divide et Impera** - divide il problema in parti più piccole e risolve quelle
  * `B` [Ricerca Binaria (Binary Search)](src/algorithms/search/binary-search)
  * `B` [Torre di Hanoi (Tower of Hanoi)](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Triangolo di Pascal (Pascal's Triangle)](src/algorithms/math/pascal-triangle)
  * `B` [Algoritmo Euclideo (Euclidean Algorithm)](src/algorithms/math/euclidean-algorithm) - calcolo del GCD
  * `B` [Merge Sort](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort)
  * `B` [Ricerca in Profondità su Alberi (Tree DFS)](src/algorithms/tree/depth-first-search)
  * `B` [Ricerca in Profondità su Grafi (Graph DFS)](src/algorithms/graph/depth-first-search)
  * `B` [Matrici (Matrices)](src/algorithms/math/matrix) - generazione e attraversamento di matrici di varie forme
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Elevamento Rapido a Potenza (Fast Powering)](src/algorithms/math/fast-powering)
  * `B` [Best Time To Buy Sell Stocks](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - esempi divide et impera e one-pass
  * `A` [Permutazioni (Permutations)](src/algorithms/sets/permutations) (con e senza ripetizioni)
  * `A` [Combinazioni (Combinations)](src/algorithms/sets/combinations) (con e senza ripetizioni)
  * `A` [Sottoarray Massimo (Maximum Subarray)](src/algorithms/sets/maximum-subarray)
* **Programmazione Dinamica** - costruisce una soluzione usando sotto-soluzioni già trovate
  * `B` [Numero di Fibonacci](src/algorithms/math/fibonacci)
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Percorsi Unici (Unique Paths)](src/algorithms/uncategorized/unique-paths)
  * `B` [Rain Terraces](src/algorithms/uncategorized/rain-terraces) - problema del trapping rain water
  * `B` [Scala Ricorsiva (Recursive Staircase)](src/algorithms/uncategorized/recursive-staircase) - conteggio dei modi per arrivare in cima
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - ridimensionamento immagini content-aware
  * `A` [Distanza di Levenshtein (Levenshtein Distance)](src/algorithms/string/levenshtein-distance) - distanza minima di modifica
  * `A` [Sottosequenza Comune Massima (Longest Common Subsequence)](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Sottostringa Comune Massima (Longest Common Substring)](src/algorithms/string/longest-common-substring)
  * `A` [Sottosequenza Crescente Massima (Longest Increasing Subsequence)](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Supersequenza Comune più Breve (Shortest Common Supersequence)](src/algorithms/sets/shortest-common-supersequence)
  * `A` [Problema Knapsack 0/1](src/algorithms/sets/knapsack-problem)
  * `A` [Partizione di Interi (Integer Partition)](src/algorithms/math/integer-partition)
  * `A` [Sottoarray Massimo (Maximum Subarray)](src/algorithms/sets/maximum-subarray)
  * `A` [Algoritmo di Bellman-Ford](src/algorithms/graph/bellman-ford) - percorsi minimi su grafi
  * `A` [Algoritmo di Floyd-Warshall](src/algorithms/graph/floyd-warshall) - percorsi minimi tra tutte le coppie
  * `A` [Matching con Espressioni Regolari (Regular Expression Matching)](src/algorithms/string/regular-expression-matching)
* **Backtracking** - simile alla forza bruta, cerca di generare tutte le soluzioni possibili, ma ogni volta che se ne genera una, la si testa
se soddisfa tutte le condizioni e solo allora si continua, altrimenti si torna indietro (backtrack) e si prova un altro percorso. Solitamente viene usato DFS sullo spazio degli stati.
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Percorsi Unici (Unique Paths)](src/algorithms/uncategorized/unique-paths)
  * `B` [Insieme Potenza (Power Set)](src/algorithms/sets/power-set) - tutti i sottoinsiemi
  * `A` [Ciclo Hamiltoniano (Hamiltonian Cycle)](src/algorithms/graph/hamiltonian-cycle) - visita ogni vertice una volta
  * `A` [Problema delle N-Regine (N-Queens Problem)](src/algorithms/uncategorized/n-queens)
  * `A` [Tour del Cavallo (Knight's Tour)](src/algorithms/uncategorized/knight-tour)
  * `A` [Somma di Combinazioni (Combination Sum)](src/algorithms/sets/combination-sum) - tutte le combinazioni per una somma specifica
* **Branch & Bound** - ricorda la soluzione a costo più basso trovata a ogni stadio del backtracking,
e usa il costo della soluzione migliore trovata come limite inferiore per scartare le soluzioni parziali peggiori. Solitamente si usa BFS in combinazione con DFS sullo spazio degli stati.

## Come usare questo repository

**Installa tutte le dipendenze**

```
npm install
```

**Esegui ESLint**

Potresti volerlo eseguire per controllare la qualità del codice.

```
npm run lint
```

**Esegui tutti i test**

```
npm test
```

**Esegui i test per nome**

```
npm test -- 'LinkedList'
```

**Risoluzione dei problemi**

Se il linting o i test falliscono, prova a eliminare la cartella `node_modules` e reinstalla i pacchetti npm:

```
rm -rf ./node_modules
npm i
```

Inoltre, assicurati di usare la versione corretta di Node (`>=16`). Se usi [nvm](https://github.com/nvm-sh/nvm) per la gestione delle versioni di Node puoi eseguire `nvm use` dalla cartella principale del progetto e verrà selezionata la versione corretta.

**Playground**

Puoi sperimentare con strutture dati e algoritmi nel file `./src/playground/playground.js` e scrivere
test in `./src/playground/__test__/playground.test.js`.

Poi, semplicemente esegui il comando seguente per testare se il tuo codice playground funziona come previsto:

```
npm test -- 'playground'
```

## Informazioni Utili

### Riferimenti

- [▶ Strutture Dati e Algoritmi su YouTube](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 Schizzi di Strutture Dati](https://okso.app/showcase/data-structures)

### Notazione Big O

*La notazione Big O* è usata per classificare gli algoritmi in base a come il loro tempo di esecuzione o lo spazio richiesto crescono al crescere della dimensione dell’input.
Nel grafico qui sotto trovi gli ordini di crescita più comuni degli algoritmi espressi in notazione Big O.

![Grafici Big O](./assets/big-o-graph.png)

Fonte: [Big O Cheat Sheet](http://bigocheatsheet.com/).

Qui sotto una tabella con alcune delle notazioni Big O più usate e il confronto delle performance per diverse dimensioni dei dati di input.

| Notazione Big O | Tipo        | Calcoli per 10 elementi | Calcoli per 100 elementi | Calcoli per 1000 elementi  |
| -------------- | ----------- | ----------------------- | ------------------------ | -------------------------- |
| **O(1)**       | Costante    | 1                       | 1                        | 1                          |
| **O(log N)**   | Logaritmica | 3                       | 6                        | 9                          |
| **O(N)**       | Lineare     | 10                      | 100                      | 1000                       |
| **O(N log N)** | n log(n)    | 30                      | 600                      | 9000                       |
| **O(N^2)**     | Quadratica  | 100                     | 10000                    | 1000000                    |
| **O(2^N)**     | Esponenziale| 1024                    | 1.26e+29                 | 1.07e+301                  |
| **O(N!)**      | Fattoriale  | 3628800                 | 9.3e+157                 | 4.02e+2567                 |

### Complessità delle Operazioni delle Strutture Dati

| Struttura Dati         | Accesso   | Ricerca   | Inserimento | Eliminazione | Commenti  |
| ---------------------- | :-------: | :-------: | :---------: | :----------: | :-------- |
| **Array**              | 1         | n         | n           | n            |           |
| **Stack**              | n         | n         | 1           | 1            |           |
| **Queue**              | n         | n         | 1           | 1            |           |
| **Lista Collegata**    | n         | n         | 1           | n            |           |
| **Tabella Hash**       | -         | n         | n           | n            | In caso di funzione hash perfetta il costo è O(1) |
| **Albero Binario Ricerca** | n      | n         | n           | n            | Se l’albero è bilanciato il costo è O(log(n)) |
| **B-Tree**             | log(n)    | log(n)    | log(n)      | log(n)       |           |
| **Albero Rosso-Nero**  | log(n)    | log(n)    | log(n)      | log(n)       |           |
| **Albero AVL**         | log(n)    | log(n)    | log(n)      | log(n)       |           |
| **Bloom Filter**       | -         | 1         | 1           | -            | Possibili falsi positivi in ricerca |

### Complessità degli Algoritmi di Ordinamento degli Array

| Nome                  | Migliore         | Media               | Peggiore             | Memoria   | Stabile   | Commenti  |
| --------------------- | :--------------: | :-----------------: | :------------------: | :-------: | :-------: | :-------- |
| **Bubble sort**       | n                | n<sup>2</sup>       | n<sup>2</sup>        | 1         | Sì        |           |
| **Insertion sort**    | n                | n<sup>2</sup>       | n<sup>2</sup>        | 1         | Sì        |           |
| **Selection sort**    | n<sup>2</sup>    | n<sup>2</sup>       | n<sup>2</sup>        | 1         | No        |           |
| **Heap sort**         | n&nbsp;log(n)    | n&nbsp;log(n)       | n&nbsp;log(n)        | 1         | No        |           |
| **Merge sort**        | n&nbsp;log(n)    | n&nbsp;log(n)       | n&nbsp;log(n)        | n         | Sì        |           |
| **Quick sort**        | n&nbsp;log(n)    | n&nbsp;log(n)       | n<sup>2</sup>        | log(n)    | No        | Solitamente in-place con O(log(n)) di spazio di stack |
| **Shell sort**        | n&nbsp;log(n)    | dipende dalla sequenza dei gap | n&nbsp;(log(n))<sup>2</sup> | 1 | No |           |
| **Counting sort**     | n + r            | n + r               | n + r                | n + r     | Sì        | r = valore massimo in array |
| **Radix sort**        | n * k            | n * k               | n * k                | n + k     | Sì        | k = lunghezza della chiave più lunga |

## Sostenitori del Progetto

> Puoi sostenere questo progetto tramite ❤️️ [GitHub](https://github.com/sponsors/trekhleb) o ❤️️ [Patreon](https://www.patreon.com/trekhleb).

[Persone che supportano questo progetto](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## Autore

[@trekhleb](https://trekhleb.dev)

Altri [progetti](https://trekhleb.dev/projects/) e [articoli](https://trekhleb.dev/blog/) su JavaScript e algoritmi su [trekhleb.dev](https://trekhleb.dev)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---