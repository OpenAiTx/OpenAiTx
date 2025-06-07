# JavaScript-Algorithmen und Datenstrukturen

> 🇺🇦 DIE UKRAINE [WIRD ANGEGRIFFEN](https://war.ukraine.ua/) VON DER RUSSISCHEN ARMEE. ZIVILISTEN WERDEN GETÖTET. WOHNGEBIETE WERDEN BOMBARDIERT.
> - Unterstützen Sie die Ukraine über:
>   - [Serhiy Prytula Charity Foundation](https://prytulafoundation.org/en/)
>   - [Come Back Alive Charity Foundation](https://savelife.in.ua/en/donate-en/)
>   - [Nationalbank der Ukraine](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - Mehr Infos auf [war.ukraine.ua](https://war.ukraine.ua/) und [MFA of Ukraine](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

Dieses Repository enthält JavaScript-basierte Beispiele vieler
bekannter Algorithmen und Datenstrukturen.

Jeder Algorithmus und jede Datenstruktur hat eine eigene README
mit zugehörigen Erklärungen und weiterführenden Links (einschließlich zu
YouTube-Videos).

_Lesen Sie dies in anderen Sprachen:_
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

*☝ Beachten Sie, dass dieses Projekt nur zu Lern- und Forschungszwecken
gedacht ist und **nicht** für den Produktionseinsatz vorgesehen ist.*

## Datenstrukturen

Eine Datenstruktur ist eine spezielle Art, Daten in einem Computer zu organisieren und zu speichern, damit sie effizient
abgerufen und verändert werden können. Genauer gesagt ist eine Datenstruktur eine Sammlung von Datenwerten,
deren Beziehungen untereinander sowie den Funktionen oder Operationen, die auf die Daten angewendet werden können.

Denken Sie daran, dass jede Datenstruktur ihre eigenen Vor- und Nachteile hat. Sie sollten mehr darauf achten, warum Sie eine bestimmte Datenstruktur wählen, als darauf, wie sie implementiert wird.

`B` - Anfänger, `A` - Fortgeschritten

* `B` [Verkettete Liste](src/data-structures/linked-list)
* `B` [Doppelt verkettete Liste](src/data-structures/doubly-linked-list)
* `B` [Warteschlange (Queue)](src/data-structures/queue)
* `B` [Stapel (Stack)](src/data-structures/stack)
* `B` [Hashtabelle](src/data-structures/hash-table)
* `B` [Heap](src/data-structures/heap) - Max- und Min-Heap-Versionen
* `B` [Prioritätswarteschlange](src/data-structures/priority-queue)
* `A` [Trie](src/data-structures/trie)
* `A` [Baum](src/data-structures/tree)
  * `A` [Binärer Suchbaum](src/data-structures/tree/binary-search-tree)
  * `A` [AVL-Baum](src/data-structures/tree/avl-tree)
  * `A` [Rot-Schwarz-Baum](src/data-structures/tree/red-black-tree)
  * `A` [Segmentbaum](src/data-structures/tree/segment-tree) - mit Beispielen für Min/Max/Summenbereichsanfragen
  * `A` [Fenwick-Baum](src/data-structures/tree/fenwick-tree) (Binär-Index-Baum)
* `A` [Graph](src/data-structures/graph) (gerichtet und ungerichtet)
* `A` [Disjoint Set](src/data-structures/disjoint-set) - Union-Find-Datenstruktur oder Merge-Find-Set
* `A` [Bloom-Filter](src/data-structures/bloom-filter)
* `A` [LRU-Cache](src/data-structures/lru-cache/) - Least Recently Used (LRU) Cache

## Algorithmen

Ein Algorithmus ist eine eindeutige Spezifikation, wie eine Klasse von Problemen zu lösen ist.
Er ist eine Reihe von Regeln, die genau eine Abfolge von Operationen definieren.

`B` - Anfänger, `A` - Fortgeschritten

### Algorithmen nach Thema

* **Mathematik**
  * `B` [Bit-Manipulation](src/algorithms/math/bits) - Setzen/Lesen/Aktualisieren/Löschen von Bits, Multiplikation/Division durch zwei, Negation usw.
  * `B` [Binäre Fließkommazahl](src/algorithms/math/binary-floating-point) - binäre Darstellung von Fließkommazahlen
  * `B` [Fakultät](src/algorithms/math/factorial)
  * `B` [Fibonacci-Zahl](src/algorithms/math/fibonacci) - klassische und geschlossene Form
  * `B` [Primfaktoren](src/algorithms/math/prime-factors) - Primfaktorzerlegung und Zählen mittels Hardy-Ramanujan-Theorem
  * `B` [Primzahltest](src/algorithms/math/primality-test) (Teilerprüfung)
  * `B` [Euklidischer Algorithmus](src/algorithms/math/euclidean-algorithm) - Berechnung des größten gemeinsamen Teilers (ggT)
  * `B` [Kleinstes gemeinsames Vielfaches](src/algorithms/math/least-common-multiple) (kgV)
  * `B` [Siebe des Eratosthenes](src/algorithms/math/sieve-of-eratosthenes) - alle Primzahlen bis zu einem bestimmten Limit finden
  * `B` [Ist Potenz von Zwei](src/algorithms/math/is-power-of-two) - Überprüfung, ob eine Zahl eine Zweierpotenz ist (naiv und bitweise)
  * `B` [Pascalsches Dreieck](src/algorithms/math/pascal-triangle)
  * `B` [Komplexe Zahl](src/algorithms/math/complex-number) - Komplexe Zahlen und Grundrechenarten
  * `B` [Bogenmaß & Grad](src/algorithms/math/radian) - Umrechnung zwischen Bogenmaß und Grad
  * `B` [Schnelles Potenzieren](src/algorithms/math/fast-powering)
  * `B` [Horner-Schema](src/algorithms/math/horner-method) - Polynomevaluation
  * `B` [Matrizen](src/algorithms/math/matrix) - Matrizen und Grundoperationen (Multiplikation, Transposition, usw.)
  * `B` [Euklidische Distanz](src/algorithms/math/euclidean-distance) - Abstand zwischen zwei Punkten/Vektoren/Matrizen
  * `A` [Ganzzahlpartition](src/algorithms/math/integer-partition)
  * `A` [Quadratwurzel](src/algorithms/math/square-root) - Newtons Methode
  * `A` [Liu Hui π Algorithmus](src/algorithms/math/liu-hui) - Annäherung von π basierend auf N-Ecken
  * `A` [Diskrete Fourier-Transformation](src/algorithms/math/fourier-transform) - Zerlegung einer Zeitfunktion (Signal) in Frequenzen
* **Mengen**
  * `B` [Kartesisches Produkt](src/algorithms/sets/cartesian-product) - Produkt mehrerer Mengen
  * `B` [Fisher–Yates Shuffle](src/algorithms/sets/fisher-yates) - Zufallspermutation einer endlichen Sequenz
  * `A` [Potenzmenge](src/algorithms/sets/power-set) - alle Teilmengen einer Menge (bitweise, Backtracking und Kaskadierung)
  * `A` [Permutationen](src/algorithms/sets/permutations) (mit und ohne Wiederholungen)
  * `A` [Kombinationen](src/algorithms/sets/combinations) (mit und ohne Wiederholungen)
  * `A` [Längste gemeinsame Teilfolge](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Längste steigende Teilfolge](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Kürzeste gemeinsame Supersequenz](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [Rucksackproblem](src/algorithms/sets/knapsack-problem) - „0/1“ und „Ungebunden“
  * `A` [Maximales Teilarray](src/algorithms/sets/maximum-subarray) - „Brute Force“ und „Dynamische Programmierung“ (Kadane’s Algorithmus)
  * `A` [Combination Sum](src/algorithms/sets/combination-sum) - alle Kombinationen finden, die eine bestimmte Summe ergeben
* **Zeichenketten**
  * `B` [Hamming-Distanz](src/algorithms/string/hamming-distance) - Anzahl der unterschiedlichen Zeichenpositionen
  * `B` [Palindrom](src/algorithms/string/palindrome) - Überprüfung, ob der String rückwärts gleich ist
  * `A` [Levenshtein-Distanz](src/algorithms/string/levenshtein-distance) - minimale Bearbeitungsdistanz zwischen zwei Sequenzen
  * `A` [Knuth–Morris–Pratt Algorithmus](src/algorithms/string/knuth-morris-pratt) (KMP-Algorithmus) - Teilstring-Suche (Mustervergleich)
  * `A` [Z-Algorithmus](src/algorithms/string/z-algorithm) - Teilstring-Suche (Mustervergleich)
  * `A` [Rabin-Karp Algorithmus](src/algorithms/string/rabin-karp) - Teilstring-Suche
  * `A` [Längster gemeinsamer Teilstring](src/algorithms/string/longest-common-substring)
  * `A` [Regulärer Ausdruck Vergleich](src/algorithms/string/regular-expression-matching)
* **Suchen**
  * `B` [Lineare Suche](src/algorithms/search/linear-search)
  * `B` [Jump Search](src/algorithms/search/jump-search) (Blocksuche) - Suche im sortierten Array
  * `B` [Binäre Suche](src/algorithms/search/binary-search) - Suche im sortierten Array
  * `B` [Interpolationssuche](src/algorithms/search/interpolation-search) - Suche im gleichmäßig verteilten sortierten Array
* **Sortieren**
  * `B` [Bubble Sort](src/algorithms/sorting/bubble-sort)
  * `B` [Selection Sort](src/algorithms/sorting/selection-sort)
  * `B` [Insertion Sort](src/algorithms/sorting/insertion-sort)
  * `B` [Heap Sort](src/algorithms/sorting/heap-sort)
  * `B` [Merge Sort](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort) - In-Place und Nicht-In-Place-Implementierungen
  * `B` [Shellsort](src/algorithms/sorting/shell-sort)
  * `B` [Counting Sort](src/algorithms/sorting/counting-sort)
  * `B` [Radix Sort](src/algorithms/sorting/radix-sort)
  * `B` [Bucket Sort](src/algorithms/sorting/bucket-sort)
* **Verkettete Listen**
  * `B` [Vorwärts-Durchlauf](src/algorithms/linked-list/traversal)
  * `B` [Rückwärts-Durchlauf](src/algorithms/linked-list/reverse-traversal)
* **Bäume**
  * `B` [Tiefensuche](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Breitensuche](src/algorithms/tree/breadth-first-search) (BFS)
* **Graphen**
  * `B` [Tiefensuche](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Breitensuche](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [Kruskal-Algorithmus](src/algorithms/graph/kruskal) - Minimaler Spannbaum (MST) für gewichtete ungerichtete Graphen
  * `A` [Dijkstra-Algorithmus](src/algorithms/graph/dijkstra) - Kürzeste Wege zu allen Knoten von einem Startknoten
  * `A` [Bellman-Ford-Algorithmus](src/algorithms/graph/bellman-ford) - Kürzeste Wege zu allen Knoten von einem Startknoten
  * `A` [Floyd-Warshall-Algorithmus](src/algorithms/graph/floyd-warshall) - Kürzeste Wege zwischen allen Knotenpaaren
  * `A` [Zyklus-Erkennung](src/algorithms/graph/detect-cycle) - für gerichtete und ungerichtete Graphen (DFS und Disjoint Set)
  * `A` [Prim-Algorithmus](src/algorithms/graph/prim) - Minimaler Spannbaum (MST) für gewichtete ungerichtete Graphen
  * `A` [Topologisches Sortieren](src/algorithms/graph/topological-sorting) - DFS-Methode
  * `A` [Gelenkpunkte](src/algorithms/graph/articulation-points) - Tarjan-Algorithmus (DFS-basiert)
  * `A` [Brücken](src/algorithms/graph/bridges) - DFS-basierter Algorithmus
  * `A` [Eulerweg und Eulerkreis](src/algorithms/graph/eulerian-path) - Fleury-Algorithmus – Jede Kante genau einmal besuchen
  * `A` [Hamiltonkreis](src/algorithms/graph/hamiltonian-cycle) - Jeden Knoten genau einmal besuchen
  * `A` [Stark zusammenhängende Komponenten](src/algorithms/graph/strongly-connected-components) - Kosaraju-Algorithmus
  * `A` [Handelsreisender-Problem](src/algorithms/graph/travelling-salesman) - Kürzeste Rundreise durch alle Städte
* **Kryptographie**
  * `B` [Polynom-Hash](src/algorithms/cryptography/polynomial-hash) - Rolling-Hash-Funktion basierend auf Polynom
  * `B` [Rail Fence Cipher](src/algorithms/cryptography/rail-fence-cipher) - Transpositionschiffre zum Verschlüsseln von Nachrichten
  * `B` [Caesar-Chiffre](src/algorithms/cryptography/caesar-cipher) - Einfache Substitutionschiffre
  * `B` [Hill-Chiffre](src/algorithms/cryptography/hill-cipher) - Substitutionschiffre basierend auf Linearer Algebra
* **Maschinelles Lernen**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 7 einfache JS-Funktionen, die illustrieren, wie Maschinen lernen können (Vorwärts-/Rückwärtsausbreitung)
  * `B` [k-NN](src/algorithms/ml/knn) - k-nächste Nachbarn Klassifikationsalgorithmus
  * `B` [k-Means](src/algorithms/ml/k-means) - k-Means Clustering-Algorithmus
* **Bildverarbeitung**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - inhaltsbasiertes Bildskalierungsverfahren
* **Statistik**
  * `B` [Gewichtetes Zufallsauswahl](src/algorithms/statistics/weighted-random) - zufällige Auswahl eines Elements basierend auf Gewichtung
* **Evolutionäre Algorithmen**
  * `A` [Genetischer Algorithmus](https://github.com/trekhleb/self-parking-car-evolution) - Beispiel für die Anwendung eines genetischen Algorithmus zum Trainieren von selbstparkenden Autos
* **Nicht kategorisiert**
  * `B` [Türme von Hanoi](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Quadratische Matrixrotation](src/algorithms/uncategorized/square-matrix-rotation) - In-Place-Algorithmus
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game) - Backtracking, dynamische Programmierung (Top-down + Bottom-up) und Greedy-Ansätze
  * `B` [Eindeutige Pfade](src/algorithms/uncategorized/unique-paths) - Backtracking, dynamische Programmierung und Pascalsches Dreieck
  * `B` [Regen-Terrassen](src/algorithms/uncategorized/rain-terraces) - Problem der Regenwassersammlung (dynamische Programmierung und Brute Force)
  * `B` [Rekursive Treppe](src/algorithms/uncategorized/recursive-staircase) - Anzahl der Wege zum Erreichen der obersten Stufe (4 Lösungen)
  * `B` [Bester Zeitpunkt zum Aktienkauf/-verkauf](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - Divide-and-Conquer und One-Pass-Beispiele
  * `B` [Gültige Klammern](src/algorithms/stack/valid-parentheses) - Überprüfung, ob ein String gültige Klammern enthält (mithilfe eines Stacks)
  * `A` [N-Damen-Problem](src/algorithms/uncategorized/n-queens)
  * `A` [Springerproblem](src/algorithms/uncategorized/knight-tour)

### Algorithmen nach Paradigma

Ein algorithmisches Paradigma ist eine allgemeine Methode oder Herangehensweise, die dem Entwurf einer Klasse
von Algorithmen zugrunde liegt. Es ist eine Abstraktion über dem Begriff des Algorithmus, so wie ein
Algorithmus eine Abstraktion über einem Computerprogramm ist.

* **Brute Force** – betrachtet alle Möglichkeiten und wählt die beste Lösung
  * `B` [Lineare Suche](src/algorithms/search/linear-search)
  * `B` [Regen-Terrassen](src/algorithms/uncategorized/rain-terraces) - Problem der Regenwassersammlung
  * `B` [Rekursive Treppe](src/algorithms/uncategorized/recursive-staircase) - Anzahl der Wege zur obersten Stufe
  * `A` [Maximales Teilarray](src/algorithms/sets/maximum-subarray)
  * `A` [Handelsreisender-Problem](src/algorithms/graph/travelling-salesman) - Kürzeste Rundreise durch alle Städte
  * `A` [Diskrete Fourier-Transformation](src/algorithms/math/fourier-transform) - Zerlegung einer Zeitfunktion in Frequenzen
* **Greedy** – wählt zum jeweiligen Zeitpunkt die beste Option, ohne Rücksicht auf die Zukunft
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `A` [Ungebundenes Rucksackproblem](src/algorithms/sets/knapsack-problem)
  * `A` [Dijkstra-Algorithmus](src/algorithms/graph/dijkstra) - Kürzeste Wege zu allen Knoten
  * `A` [Prim-Algorithmus](src/algorithms/graph/prim) - Minimaler Spannbaum
  * `A` [Kruskal-Algorithmus](src/algorithms/graph/kruskal) - Minimaler Spannbaum
* **Divide and Conquer** – zerlegt das Problem in kleinere Teile und löst diese
  * `B` [Binäre Suche](src/algorithms/search/binary-search)
  * `B` [Türme von Hanoi](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Pascalsches Dreieck](src/algorithms/math/pascal-triangle)
  * `B` [Euklidischer Algorithmus](src/algorithms/math/euclidean-algorithm) - ggT
  * `B` [Merge Sort](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort)
  * `B` [Baum-Tiefensuche](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Graph-Tiefensuche](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Matrizen](src/algorithms/math/matrix) - Erzeugung und Durchlauf verschiedener Matrizenformen
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Schnelles Potenzieren](src/algorithms/math/fast-powering)
  * `B` [Bester Zeitpunkt zum Aktienkauf/-verkauf](src/algorithms/uncategorized/best-time-to-buy-sell-stocks)
  * `A` [Permutationen](src/algorithms/sets/permutations)
  * `A` [Kombinationen](src/algorithms/sets/combinations)
  * `A` [Maximales Teilarray](src/algorithms/sets/maximum-subarray)
* **Dynamische Programmierung** – baut eine Lösung mithilfe bereits gefundener Teillösungen auf
  * `B` [Fibonacci-Zahl](src/algorithms/math/fibonacci)
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Eindeutige Pfade](src/algorithms/uncategorized/unique-paths)
  * `B` [Regen-Terrassen](src/algorithms/uncategorized/rain-terraces)
  * `B` [Rekursive Treppe](src/algorithms/uncategorized/recursive-staircase)
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving)
  * `A` [Levenshtein-Distanz](src/algorithms/string/levenshtein-distance)
  * `A` [Längste gemeinsame Teilfolge](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Längster gemeinsamer Teilstring](src/algorithms/string/longest-common-substring)
  * `A` [Längste steigende Teilfolge](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Kürzeste gemeinsame Supersequenz](src/algorithms/sets/shortest-common-supersequence)
  * `A` [0/1-Rucksackproblem](src/algorithms/sets/knapsack-problem)
  * `A` [Ganzzahlpartition](src/algorithms/math/integer-partition)
  * `A` [Maximales Teilarray](src/algorithms/sets/maximum-subarray)
  * `A` [Bellman-Ford-Algorithmus](src/algorithms/graph/bellman-ford)
  * `A` [Floyd-Warshall-Algorithmus](src/algorithms/graph/floyd-warshall)
  * `A` [Regulärer Ausdruck Vergleich](src/algorithms/string/regular-expression-matching)
* **Backtracking** – ähnlich wie Brute Force, versucht alle möglichen Lösungen zu generieren, prüft aber bei jeder neuen Lösung, ob alle Bedingungen erfüllt sind, und geht nur dann weiter. Andernfalls Backtracking und einen anderen Lösungsweg suchen. Normalerweise wird die DFS-Durchquerung des Zustandsraums verwendet.
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Eindeutige Pfade](src/algorithms/uncategorized/unique-paths)
  * `B` [Potenzmenge](src/algorithms/sets/power-set)
  * `A` [Hamiltonkreis](src/algorithms/graph/hamiltonian-cycle)
  * `A` [N-Damen-Problem](src/algorithms/uncategorized/n-queens)
  * `A` [Springerproblem](src/algorithms/uncategorized/knight-tour)
  * `A` [Combination Sum](src/algorithms/sets/combination-sum)
* **Branch & Bound** – merkt sich die bisher günstigste Lösung bei jedem Schritt des Backtracking-Suchvorgangs und verwirft Teillösungen, deren Kosten die der bisher besten Lösung überschreiten. Meist wird BFS kombiniert mit DFS im Zustandsraum-Baum eingesetzt.

## Verwendung dieses Repositories

**Alle Abhängigkeiten installieren**

```
npm install
```

**ESLint ausführen**

Sie können ESLint ausführen, um die Codequalität zu überprüfen.

```
npm run lint
```

**Alle Tests ausführen**

```
npm test
```

**Tests nach Name ausführen**

```
npm test -- 'LinkedList'
```

**Fehlerbehebung**

Falls Linting oder Tests fehlschlagen, löschen Sie den `node_modules`-Ordner und installieren Sie die Pakete erneut:

```
rm -rf ./node_modules
npm i
```

Stellen Sie außerdem sicher, dass Sie die richtige Node-Version (`>=16`) verwenden. Wenn Sie [nvm](https://github.com/nvm-sh/nvm) zur Node-Version-Verwaltung nutzen, können Sie im Projektverzeichnis `nvm use` ausführen, damit die richtige Version verwendet wird.

**Playground**

Sie können im `./src/playground/playground.js` mit Datenstrukturen und Algorithmen experimentieren und dazu Tests in `./src/playground/__test__/playground.test.js` schreiben.

Führen Sie dann einfach den folgenden Befehl aus, um zu testen, ob Ihr Playground-Code wie erwartet funktioniert:

```
npm test -- 'playground'
```

## Nützliche Informationen

### Quellen

- [▶ Datenstrukturen und Algorithmen auf YouTube](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 Data Structure Sketches](https://okso.app/showcase/data-structures)

### Big O-Notation

*Big O-Notation* wird verwendet, um Algorithmen nach dem Wachstum ihres Zeit- oder Speicherbedarfs in Abhängigkeit von der Eingabegröße zu klassifizieren.
Im folgenden Diagramm sehen Sie die häufigsten Wachstumsordnungen von Algorithmen in Big O-Notation.

![Big O graphs](./assets/big-o-graph.png)

Quelle: [Big O Cheat Sheet](http://bigocheatsheet.com/).

Nachfolgend finden Sie die gebräuchlichsten Big O-Notationen und deren Leistungsvergleich bei unterschiedlichen Eingabemengen.

| Big O Notation | Typ         | Berechnungen für 10 Elemente | Berechnungen für 100 Elemente | Berechnungen für 1000 Elemente  |
| -------------- | ----------- | ---------------------------- | ----------------------------- | ------------------------------- |
| **O(1)**       | Konstant    | 1                            | 1                             | 1                               |
| **O(log N)**   | Logarithmisch| 3                           | 6                             | 9                               |
| **O(N)**       | Linear      | 10                           | 100                           | 1000                            |
| **O(N log N)** | n log(n)    | 30                           | 600                           | 9000                            |
| **O(N^2)**     | Quadratisch | 100                          | 10000                         | 1000000                         |
| **O(2^N)**     | Exponentiell| 1024                         | 1,26e+29                      | 1,07e+301                       |
| **O(N!)**      | Fakultativ  | 3628800                      | 9,3e+157                      | 4,02e+2567                      |

### Komplexität von Datenstruktur-Operationen

| Datenstruktur          | Zugriff   | Suche     | Einfügen   | Löschen    | Kommentare  |
| ---------------------- | :-------: | :-------: | :--------: | :--------: | :---------- |
| **Array**              | 1         | n         | n          | n          |             |
| **Stack**              | n         | n         | 1          | 1          |             |
| **Queue**              | n         | n         | 1          | 1          |             |
| **Verkettete Liste**   | n         | n         | 1          | n          |             |
| **Hashtabelle**        | -         | n         | n          | n          | Bei perfekter Hashfunktion O(1) |
| **Binärer Suchbaum**   | n         | n         | n          | n          | Bei balanciertem Baum O(log(n)) |
| **B-Baum**             | log(n)    | log(n)    | log(n)     | log(n)     |             |
| **Rot-Schwarz-Baum**   | log(n)    | log(n)    | log(n)     | log(n)     |             |
| **AVL-Baum**           | log(n)    | log(n)    | log(n)     | log(n)     |             |
| **Bloom-Filter**       | -         | 1         | 1          | -          | False Positives beim Suchen möglich |

### Komplexität der Array-Sortieralgorithmen

| Name                  | Best            | Durchschnitt        | Schlechtester Fall     | Speicher   | Stabil     | Kommentare  |
| --------------------- | :-------------: | :-----------------:| :--------------------: | :--------: | :--------: | :---------- |
| **Bubble Sort**       | n               | n<sup>2</sup>      | n<sup>2</sup>         | 1          | Ja         |             |
| **Insertion Sort**    | n               | n<sup>2</sup>      | n<sup>2</sup>         | 1          | Ja         |             |
| **Selection Sort**    | n<sup>2</sup>   | n<sup>2</sup>      | n<sup>2</sup>         | 1          | Nein       |             |
| **Heap Sort**         | n&nbsp;log(n)   | n&nbsp;log(n)      | n&nbsp;log(n)         | 1          | Nein       |             |
| **Merge Sort**        | n&nbsp;log(n)   | n&nbsp;log(n)      | n&nbsp;log(n)         | n          | Ja         |             |
| **Quick Sort**        | n&nbsp;log(n)   | n&nbsp;log(n)      | n<sup>2</sup>         | log(n)     | Nein       | Meist In-Place mit O(log(n)) Stack-Speicher |
| **Shell Sort**        | n&nbsp;log(n)   | abhängig von Gap-Sequenz | n&nbsp;(log(n))<sup>2</sup> | 1 | Nein  |             |
| **Counting Sort**     | n + r           | n + r              | n + r                 | n + r      | Ja         | r = größte Zahl im Array |
| **Radix Sort**        | n * k           | n * k              | n * k                 | n + k      | Ja         | k = Länge des längsten Schlüssels |

## Unterstützer des Projekts

> Sie können dieses Projekt unterstützen über ❤️️ [GitHub](https://github.com/sponsors/trekhleb) oder ❤️️ [Patreon](https://www.patreon.com/trekhleb).

[Personen, die dieses Projekt unterstützen](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## Autor

[@trekhleb](https://trekhleb.dev)

Weitere [Projekte](https://trekhleb.dev/projects/) und [Artikel](https://trekhleb.dev/blog/) zu JavaScript und Algorithmen auf [trekhleb.dev](https://trekhleb.dev)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---