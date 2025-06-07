# JavaScript Algoritmen en Datastructuren

> 🇺🇦 OEKRAÏNE [WORDT AANGEVALLEN](https://war.ukraine.ua/) DOOR HET RUSSISCHE LEGER. BURGERS WORDEN GEDOOD. WOONWIJKEN WORDEN GEBOMBARDEERD.
> - Help Oekraïne via:
>   - [Serhiy Prytula Charity Foundation](https://prytulafoundation.org/en/)
>   - [Come Back Alive Charity Foundation](https://savelife.in.ua/en/donate-en/)
>   - [Nationale Bank van Oekraïne](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - Meer info op [war.ukraine.ua](https://war.ukraine.ua/) en [MFA van Oekraïne](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

Deze repository bevat op JavaScript gebaseerde voorbeelden van veel
populaire algoritmen en datastructuren.

Elk algoritme en elke datastructuur heeft een eigen aparte README
met bijbehorende uitleg en links voor verdere verdieping (waaronder links
naar YouTube-video's).

_Lees dit in andere talen:_
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

*☝ Let op: dit project is bedoeld voor leer- en onderzoeksdoeleinden
en is **niet** bedoeld voor productiegebruik.*

## Datastructuren

Een datastructuur is een specifieke manier om data te organiseren en op te slaan in een computer zodat deze
efficiënt kan worden benaderd en aangepast. Preciezer gezegd is een datastructuur een verzameling van datapunten,
de onderlinge relaties tussen die data, en de functies of operaties die op de data kunnen worden toegepast.

Onthoud dat elke datastructuur zijn eigen voor- en nadelen heeft. Het is belangrijker om te begrijpen waarom je voor een bepaalde datastructuur kiest, dan hoe je deze implementeert.

`B` - Beginner, `A` - Geavanceerd

* `B` [Linked List](src/data-structures/linked-list)
* `B` [Doubly Linked List](src/data-structures/doubly-linked-list)
* `B` [Queue](src/data-structures/queue)
* `B` [Stack](src/data-structures/stack)
* `B` [Hash Table](src/data-structures/hash-table)
* `B` [Heap](src/data-structures/heap) - max- en min-heap versies
* `B` [Priority Queue](src/data-structures/priority-queue)
* `A` [Trie](src/data-structures/trie)
* `A` [Tree](src/data-structures/tree)
  * `A` [Binary Search Tree](src/data-structures/tree/binary-search-tree)
  * `A` [AVL Tree](src/data-structures/tree/avl-tree)
  * `A` [Red-Black Tree](src/data-structures/tree/red-black-tree)
  * `A` [Segment Tree](src/data-structures/tree/segment-tree) - met min/max/som range query voorbeelden
  * `A` [Fenwick Tree](src/data-structures/tree/fenwick-tree) (Binary Indexed Tree)
* `A` [Graph](src/data-structures/graph) (zowel gericht als ongericht)
* `A` [Disjoint Set](src/data-structures/disjoint-set) - een union–find datastructuur of merge–find set
* `A` [Bloom Filter](src/data-structures/bloom-filter)
* `A` [LRU Cache](src/data-structures/lru-cache/) - Least Recently Used (LRU) cache

## Algoritmen

Een algoritme is een ondubbelzinnige specificatie van hoe een klasse van problemen opgelost moet worden. Het is
een verzameling regels die precies de volgorde van bewerkingen definieert.

`B` - Beginner, `A` - Geavanceerd

### Algoritmen per onderwerp

* **Wiskunde**
  * `B` [Bitmanipulatie](src/algorithms/math/bits) - bits instellen/opvragen/bijwerken/verwijderen, vermenigvuldigen/delen door twee, negatief maken, etc.
  * `B` [Binair drijvendekommapunt](src/algorithms/math/binary-floating-point) - binaire representatie van drijvendekommagetallen.
  * `B` [Faculteit](src/algorithms/math/factorial)
  * `B` [Fibonacci Getal](src/algorithms/math/fibonacci) - klassieke en gesloten-formule versies
  * `B` [Priemfactoren](src/algorithms/math/prime-factors) - vinden van priemfactoren en tellen met Hardy-Ramanujan's stelling
  * `B` [Priemgetaltest](src/algorithms/math/primality-test) (proefdelingmethode)
  * `B` [Euclidisch Algoritme](src/algorithms/math/euclidean-algorithm) - bereken de grootste gemene deler (GCD)
  * `B` [Kleinste Gemene Veelvoud](src/algorithms/math/least-common-multiple) (KGV)
  * `B` [Zeef van Eratosthenes](src/algorithms/math/sieve-of-eratosthenes) - alle priemgetallen tot een gegeven limiet vinden
  * `B` [Is Macht van Twee](src/algorithms/math/is-power-of-two) - controleer of het getal een macht van twee is (naïef en bitwise algoritmen)
  * `B` [Pascal's Driehoek](src/algorithms/math/pascal-triangle)
  * `B` [Complex Getal](src/algorithms/math/complex-number) - complexe getallen en basisoperaties ermee
  * `B` [Radiaal & Graad](src/algorithms/math/radian) - radialen naar graden en omgekeerd
  * `B` [Snelle Machtsverheffing](src/algorithms/math/fast-powering)
  * `B` [Methode van Horner](src/algorithms/math/horner-method) - polynoomevaluatie
  * `B` [Matrices](src/algorithms/math/matrix) - matrices en basis matrixbewerkingen (vermenigvuldiging, transpositie, etc.)
  * `B` [Euclidische Afstand](src/algorithms/math/euclidean-distance) - afstand tussen twee punten/vectoren/matrices
  * `A` [Gehele Getal Partitionering](src/algorithms/math/integer-partition)
  * `A` [Worteltrekken](src/algorithms/math/square-root) - Newtons methode
  * `A` [Liu Hui π Algoritme](src/algorithms/math/liu-hui) - benaderingen van π op basis van N-hoeken
  * `A` [Discrete Fouriertransformatie](src/algorithms/math/fourier-transform) - decompositie van een tijdsfunctie (signaal) in de samenstellende frequenties
* **Verzamelingen**
  * `B` [Cartesisch Product](src/algorithms/sets/cartesian-product) - product van meerdere verzamelingen
  * `B` [Fisher–Yates Shuffle](src/algorithms/sets/fisher-yates) - willekeurige permutatie van een eindige reeks
  * `A` [Vermogensverzameling](src/algorithms/sets/power-set) - alle deelverzamelingen van een set (bitwise, backtracking, en cascaderende oplossingen)
  * `A` [Permutaties](src/algorithms/sets/permutations) (met en zonder herhaling)
  * `A` [Combinaties](src/algorithms/sets/combinations) (met en zonder herhaling)
  * `A` [Langste Gemeenschappelijke Subreeks](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Langste Stijgende Subreeks](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Kortste Gemeenschappelijke Superreeks](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [Knapsack Probleem](src/algorithms/sets/knapsack-problem) - "0/1" en "Onbeperkt"
  * `A` [Maximale Subarray](src/algorithms/sets/maximum-subarray) - "Brute Force" en "Dynamisch Programmeren" (Kadane's) versies
  * `A` [Combinatie Som](src/algorithms/sets/combination-sum) - vind alle combinaties die een specifieke som vormen
* **Strings**
  * `B` [Hamming Afstand](src/algorithms/string/hamming-distance) - aantal posities waarop de symbolen verschillen
  * `B` [Palindroom](src/algorithms/string/palindrome) - controleer of de string hetzelfde is als deze wordt omgekeerd
  * `A` [Levenshtein Afstand](src/algorithms/string/levenshtein-distance) - minimale bewerkingsafstand tussen twee reeksen
  * `A` [Knuth–Morris–Pratt Algoritme](src/algorithms/string/knuth-morris-pratt) (KMP Algoritme) - substring zoekopdracht (patroonherkenning)
  * `A` [Z Algoritme](src/algorithms/string/z-algorithm) - substring zoekopdracht (patroonherkenning)
  * `A` [Rabin Karp Algoritme](src/algorithms/string/rabin-karp) - substring zoekopdracht
  * `A` [Langste Gemeenschappelijke Substring](src/algorithms/string/longest-common-substring)
  * `A` [Reguliere Expressie Matching](src/algorithms/string/regular-expression-matching)
* **Zoekopdrachten**
  * `B` [Lineaire Zoekopdracht](src/algorithms/search/linear-search)
  * `B` [Jump Search](src/algorithms/search/jump-search) (of Block Search) - zoeken in gesorteerde array
  * `B` [Binaire Zoekopdracht](src/algorithms/search/binary-search) - zoeken in gesorteerde array
  * `B` [Interpolatie Zoekopdracht](src/algorithms/search/interpolation-search) - zoeken in uniform verdeelde gesorteerde array
* **Sorteren**
  * `B` [Bubble Sort](src/algorithms/sorting/bubble-sort)
  * `B` [Selection Sort](src/algorithms/sorting/selection-sort)
  * `B` [Insertion Sort](src/algorithms/sorting/insertion-sort)
  * `B` [Heap Sort](src/algorithms/sorting/heap-sort)
  * `B` [Merge Sort](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort) - in-place en niet-in-place implementaties
  * `B` [Shellsort](src/algorithms/sorting/shell-sort)
  * `B` [Counting Sort](src/algorithms/sorting/counting-sort)
  * `B` [Radix Sort](src/algorithms/sorting/radix-sort)
  * `B` [Bucket Sort](src/algorithms/sorting/bucket-sort)
* **Linked Lists**
  * `B` [Rechtstreeks Traverseren](src/algorithms/linked-list/traversal)
  * `B` [Omgekeerd Traverseren](src/algorithms/linked-list/reverse-traversal)
* **Bomen**
  * `B` [Diepte-eerst zoeken](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Breedte-eerst zoeken](src/algorithms/tree/breadth-first-search) (BFS)
* **Grafen**
  * `B` [Diepte-eerst zoeken](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Breedte-eerst zoeken](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [Kruskal’s Algoritme](src/algorithms/graph/kruskal) - vinden van Minimum Spanning Tree (MST) voor gewogen ongerichte graaf
  * `A` [Dijkstra Algoritme](src/algorithms/graph/dijkstra) - kortste paden vinden naar alle grafknooppunten vanaf één knooppunt
  * `A` [Bellman-Ford Algoritme](src/algorithms/graph/bellman-ford) - kortste paden vinden naar alle grafknooppunten vanaf één knooppunt
  * `A` [Floyd-Warshall Algoritme](src/algorithms/graph/floyd-warshall) - vind de kortste paden tussen alle paren van knooppunten
  * `A` [Detecteer Cyclus](src/algorithms/graph/detect-cycle) - voor zowel gerichte als ongerichte grafen (DFS en Disjoint Set gebaseerde versies)
  * `A` [Prim’s Algoritme](src/algorithms/graph/prim) - vinden van Minimum Spanning Tree (MST) voor gewogen ongerichte graaf
  * `A` [Topologische Sortering](src/algorithms/graph/topological-sorting) - DFS-methode
  * `A` [Articulatiepunten](src/algorithms/graph/articulation-points) - Tarjan's algoritme (gebaseerd op DFS)
  * `A` [Bruggen](src/algorithms/graph/bridges) - DFS-gebaseerd algoritme
  * `A` [Eulerpad en Eulerkring](src/algorithms/graph/eulerian-path) - Fleury's algoritme - Bezoek elke rand exact één keer
  * `A` [Hamiltoniaanse Cyclus](src/algorithms/graph/hamiltonian-cycle) - Bezoek elk knooppunt exact één keer
  * `A` [Sterk Verbonden Componenten](src/algorithms/graph/strongly-connected-components) - Kosaraju's algoritme
  * `A` [Travelling Salesman Problem](src/algorithms/graph/travelling-salesman) - kortste mogelijke route die elke stad bezoekt en terugkeert naar de oorsprongstad
* **Cryptografie**
  * `B` [Polynoom Hash](src/algorithms/cryptography/polynomial-hash) - rolling hash functie gebaseerd op polynoom
  * `B` [Rail Fence Cipher](src/algorithms/cryptography/rail-fence-cipher) - een transpositie-cijferalgoritme voor het coderen van berichten
  * `B` [Caesar Cipher](src/algorithms/cryptography/caesar-cipher) - eenvoudige substitutie-cijfer
  * `B` [Hill Cipher](src/algorithms/cryptography/hill-cipher) - substitutie-cijfer gebaseerd op lineaire algebra
* **Machine Learning**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 7 eenvoudige JS-functies die illustreren hoe machines kunnen leren (forward/backward propagatie)
  * `B` [k-NN](src/algorithms/ml/knn) - k-nearest neighbors classificatie-algoritme
  * `B` [k-Means](src/algorithms/ml/k-means) - k-Means clustering algoritme
* **Beeldverwerking**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - content-aware afbeeldingresizing algoritme
* **Statistiek**
  * `B` [Gewogen Willekeur](src/algorithms/statistics/weighted-random) - selecteer een willekeurig item uit de lijst op basis van de gewichten van de items
* **Evolutionaire algoritmen**
  * `A` [Genetisch algoritme](https://github.com/trekhleb/self-parking-car-evolution) - voorbeeld van hoe het genetisch algoritme gebruikt kan worden voor het trainen van zelfparkerende auto's
* **Niet-gecategoriseerd**
  * `B` [Toren van Hanoi](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Vierkante Matrixrotatie](src/algorithms/uncategorized/square-matrix-rotation) - in-place algoritme
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game) - backtracking, dynamisch programmeren (top-down + bottom-up) en greedy voorbeelden
  * `B` [Unieke Paden](src/algorithms/uncategorized/unique-paths) - backtracking, dynamisch programmeren en Pascal's Driehoek gebaseerde voorbeelden
  * `B` [Regen Terrassen](src/algorithms/uncategorized/rain-terraces) - probleem van regenwater opvangen (dynamisch programmeren en brute force versies)
  * `B` [Recursieve Trap](src/algorithms/uncategorized/recursive-staircase) - tel het aantal manieren om de top te bereiken (4 oplossingen)
  * `B` [Beste Tijd Om Aandelen Te Kopen/Verkopen](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - divide en conquer en one-pass voorbeelden
  * `B` [Geldige Haakjes](src/algorithms/stack/valid-parentheses) - controleer of een string geldige haakjes heeft (met behulp van een stack)
  * `A` [N-Queens Probleem](src/algorithms/uncategorized/n-queens)
  * `A` [Knight's Tour](src/algorithms/uncategorized/knight-tour)

### Algoritmen per Paradigma

Een algoritmisch paradigma is een generieke methode of benadering die ten grondslag ligt aan het ontwerp van een klasse
van algoritmen. Het is een abstractie op een hoger niveau dan het begrip algoritme, zoals een
algoritme een abstractie op hoger niveau is dan een computerprogramma.

* **Brute Force** - bekijkt alle mogelijkheden en kiest de beste oplossing
  * `B` [Lineaire Zoekopdracht](src/algorithms/search/linear-search)
  * `B` [Regen Terrassen](src/algorithms/uncategorized/rain-terraces) - regenwateropvangprobleem
  * `B` [Recursieve Trap](src/algorithms/uncategorized/recursive-staircase) - tel het aantal manieren om de top te bereiken
  * `A` [Maximale Subarray](src/algorithms/sets/maximum-subarray)
  * `A` [Travelling Salesman Problem](src/algorithms/graph/travelling-salesman) - kortste mogelijke route die elke stad bezoekt en terugkeert naar de oorsprongstad
  * `A` [Discrete Fouriertransformatie](src/algorithms/math/fourier-transform) - decompositie van een tijdsfunctie (signaal) in de samenstellende frequenties
* **Greedy** - kies de beste optie op het huidige moment, zonder naar de toekomst te kijken
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `A` [Onbeperkt Knapsack Probleem](src/algorithms/sets/knapsack-problem)
  * `A` [Dijkstra Algoritme](src/algorithms/graph/dijkstra) - kortste paden naar alle grafknooppunten
  * `A` [Prim’s Algoritme](src/algorithms/graph/prim) - vinden van Minimum Spanning Tree (MST) voor gewogen ongerichte graaf
  * `A` [Kruskal’s Algoritme](src/algorithms/graph/kruskal) - vinden van Minimum Spanning Tree (MST) voor gewogen ongerichte graaf
* **Divide and Conquer** - verdeel het probleem in kleinere delen en los deze afzonderlijk op
  * `B` [Binaire Zoekopdracht](src/algorithms/search/binary-search)
  * `B` [Toren van Hanoi](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Pascal's Driehoek](src/algorithms/math/pascal-triangle)
  * `B` [Euclidisch Algoritme](src/algorithms/math/euclidean-algorithm) - bereken de grootste gemene deler (GCD)
  * `B` [Merge Sort](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort)
  * `B` [Boom Diepte-eerst Zoeken](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Graaf Diepte-eerst Zoeken](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Matrices](src/algorithms/math/matrix) - genereren en traverseren van matrices van verschillende vormen
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Snelle Machtsverheffing](src/algorithms/math/fast-powering)
  * `B` [Beste Tijd Om Aandelen Te Kopen/Verkopen](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - divide en conquer en one-pass voorbeelden
  * `A` [Permutaties](src/algorithms/sets/permutations) (met en zonder herhaling)
  * `A` [Combinaties](src/algorithms/sets/combinations) (met en zonder herhaling)
  * `A` [Maximale Subarray](src/algorithms/sets/maximum-subarray)
* **Dynamisch Programmeren** - bouw een oplossing op met eerder gevonden deeloplossingen
  * `B` [Fibonacci Getal](src/algorithms/math/fibonacci)
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Unieke Paden](src/algorithms/uncategorized/unique-paths)
  * `B` [Regen Terrassen](src/algorithms/uncategorized/rain-terraces) - regenwateropvangprobleem
  * `B` [Recursieve Trap](src/algorithms/uncategorized/recursive-staircase) - tel het aantal manieren om de top te bereiken
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - content-aware afbeeldingresizing algoritme
  * `A` [Levenshtein Afstand](src/algorithms/string/levenshtein-distance) - minimale bewerkingsafstand tussen twee reeksen
  * `A` [Langste Gemeenschappelijke Subreeks](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Langste Gemeenschappelijke Substring](src/algorithms/string/longest-common-substring)
  * `A` [Langste Stijgende Subreeks](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Kortste Gemeenschappelijke Superreeks](src/algorithms/sets/shortest-common-supersequence)
  * `A` [0/1 Knapsack Probleem](src/algorithms/sets/knapsack-problem)
  * `A` [Gehele Getal Partitionering](src/algorithms/math/integer-partition)
  * `A` [Maximale Subarray](src/algorithms/sets/maximum-subarray)
  * `A` [Bellman-Ford Algoritme](src/algorithms/graph/bellman-ford) - kortste paden naar alle grafknooppunten
  * `A` [Floyd-Warshall Algoritme](src/algorithms/graph/floyd-warshall) - vind de kortste paden tussen alle paren van knooppunten
  * `A` [Reguliere Expressie Matching](src/algorithms/string/regular-expression-matching)
* **Backtracking** - net als brute force proberen om alle mogelijke oplossingen te genereren, maar elke keer dat je een volgende oplossing genereert, test je of deze aan alle voorwaarden voldoet en ga je alleen verder als dat zo is. Anders ga je terug en kies je een andere weg. Meestal wordt DFS-traversal van de toestandsruimte gebruikt.
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Unieke Paden](src/algorithms/uncategorized/unique-paths)
  * `B` [Vermogensverzameling](src/algorithms/sets/power-set) - alle deelverzamelingen van een set
  * `A` [Hamiltoniaanse Cyclus](src/algorithms/graph/hamiltonian-cycle) - Bezoek elk knooppunt exact één keer
  * `A` [N-Queens Probleem](src/algorithms/uncategorized/n-queens)
  * `A` [Knight's Tour](src/algorithms/uncategorized/knight-tour)
  * `A` [Combinatie Som](src/algorithms/sets/combination-sum) - vind alle combinaties die een specifieke som vormen
* **Branch & Bound** - onthoud de oplossing met de laagste kosten die tot nu toe is gevonden bij elke stap van het backtrackingproces, en gebruik de kosten hiervan als ondergrens om partiële oplossingen met hogere kosten uit te sluiten. Meestal wordt BFS-traversal in combinatie met DFS-traversal van de toestandsboom gebruikt.

## Hoe deze repository te gebruiken

**Installeer alle afhankelijkheden**

```
npm install
```

**Voer ESLint uit**

Je kunt dit uitvoeren om de codekwaliteit te controleren.

```
npm run lint
```

**Voer alle tests uit**

```
npm test
```

**Voer tests uit op naam**

```
npm test -- 'LinkedList'
```

**Probleemoplossing**

Als linting of testen niet lukt, probeer dan de map `node_modules` te verwijderen en npm-pakketten opnieuw te installeren:

```
rm -rf ./node_modules
npm i
```

Controleer ook of je de juiste Node-versie gebruikt (`>=16`). Als je [nvm](https://github.com/nvm-sh/nvm) gebruikt voor Node-versiebeheer kun je `nvm use` uitvoeren vanuit de rootmap van het project zodat de juiste versie wordt gekozen.

**Playground**

Je kunt spelen met datastructuren en algoritmen in het bestand `./src/playground/playground.js` en hier tests voor schrijven in `./src/playground/__test__/playground.test.js`.

Voer daarna eenvoudig het volgende commando uit om te testen of je playground-code werkt zoals verwacht:

```
npm test -- 'playground'
```

## Nuttige informatie

### Referenties

- [▶ Datastructuren en Algoritmen op YouTube](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 Datastructuur Schetsen](https://okso.app/showcase/data-structures)

### Big O Notatie

*Big O-notatie* wordt gebruikt om algoritmen te classificeren op basis van hoe hun looptijd of geheugengebruik groeit naarmate de invoergrootte groeit.
In de onderstaande grafiek vind je de meest voorkomende groeisnelheden van algoritmen in Big O-notatie.

![Big O grafieken](./assets/big-o-graph.png)

Bron: [Big O Cheat Sheet](http://bigocheatsheet.com/).

Hieronder volgt een lijst van enkele van de meest gebruikte Big O-notaties en hun prestatievergelijkingen bij verschillende invoergroottes.

| Big O Notatie | Type        | Berekeningen voor 10 elementen | Berekeningen voor 100 elementen | Berekeningen voor 1000 elementen  |
| -------------- | ----------- | ------------------------------ | ------------------------------- | --------------------------------- |
| **O(1)**       | Constant    | 1                              | 1                               | 1                                 |
| **O(log N)**   | Logaritmisch| 3                              | 6                               | 9                                 |
| **O(N)**       | Lineair     | 10                             | 100                             | 1000                              |
| **O(N log N)** | n log(n)    | 30                             | 600                             | 9000                              |
| **O(N^2)**     | Kwadratisch | 100                            | 10000                           | 1000000                           |
| **O(2^N)**     | Exponentieel| 1024                           | 1,26e+29                        | 1,07e+301                         |
| **O(N!)**      | Faculteit   | 3628800                        | 9,3e+157                        | 4,02e+2567                        |

### Complexiteit van Datastructuur Operaties

| Datastructuur          | Toegang   | Zoeken    | Invoegen  | Verwijderen  | Opmerkingen  |
| ---------------------- | :-------: | :-------: | :-------: | :----------: | :----------: |
| **Array**              | 1         | n         | n         | n            |              |
| **Stack**              | n         | n         | 1         | 1            |              |
| **Queue**              | n         | n         | 1         | 1            |              |
| **Linked List**        | n         | n         | 1         | n            |              |
| **Hash Table**         | -         | n         | n         | n            | Bij een perfecte hashfunctie zijn de kosten O(1) |
| **Binaire Zoekboom**   | n         | n         | n         | n            | Bij een gebalanceerde boom zijn de kosten O(log(n)) |
| **B-Boom**             | log(n)    | log(n)    | log(n)    | log(n)       |              |
| **Red-Black Tree**     | log(n)    | log(n)    | log(n)    | log(n)       |              |
| **AVL Tree**           | log(n)    | log(n)    | log(n)    | log(n)       |              |
| **Bloom Filter**       | -         | 1         | 1         | -            | False positives mogelijk bij zoeken |

### Complexiteit van Array-Sorteeralgoritmen

| Naam                   | Best            | Gemiddeld           | Slechtste            | Geheugen   | Stabiel   | Opmerkingen  |
| ---------------------- | :-------------: | :-----------------: | :------------------: | :--------: | :-------: | :----------- |
| **Bubble sort**        | n               | n<sup>2</sup>       | n<sup>2</sup>        | 1          | Ja        |              |
| **Insertion sort**     | n               | n<sup>2</sup>       | n<sup>2</sup>        | 1          | Ja        |              |
| **Selection sort**     | n<sup>2</sup>   | n<sup>2</sup>       | n<sup>2</sup>        | 1          | Nee       |              |
| **Heap sort**          | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)        | 1          | Nee       |              |
| **Merge sort**         | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)        | n          | Ja        |              |
| **Quick sort**         | n&nbsp;log(n)   | n&nbsp;log(n)       | n<sup>2</sup>        | log(n)     | Nee       | Quicksort wordt meestal in-place gedaan met O(log(n)) stackruimte |
| **Shell sort**         | n&nbsp;log(n)   | afhankelijk van gap-sequentie | n&nbsp;(log(n))<sup>2</sup>  | 1    | Nee   |              |
| **Counting sort**      | n + r           | n + r               | n + r                | n + r      | Ja        | r - grootste getal in de array |
| **Radix sort**         | n * k           | n * k               | n * k                | n + k      | Ja        | k - lengte van de langste sleutel |

## Projectondersteuners

> Je kunt dit project steunen via ❤️️ [GitHub](https://github.com/sponsors/trekhleb) of ❤️️ [Patreon](https://www.patreon.com/trekhleb).

[Personen die dit project steunen](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## Auteur

[@trekhleb](https://trekhleb.dev)

Nog meer [projecten](https://trekhleb.dev/projects/) en [artikelen](https://trekhleb.dev/blog/) over JavaScript en algoritmen op [trekhleb.dev](https://trekhleb.dev)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---