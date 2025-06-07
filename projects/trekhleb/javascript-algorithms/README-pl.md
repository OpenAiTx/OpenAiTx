# JavaScript - Algorytmy i Struktury Danych

> 🇺🇦 UKRAINA [JEST ATAKOWANA](https://war.ukraine.ua/) PRZEZ ARMIĘ ROSYJSKĄ. CYWILE SĄ ZABIJANI. OBSZARY MIESZKALNE SĄ BOMBARDOWANE.
> - Wesprzyj Ukrainę poprzez:
>   - [Fundację Charytatywną Serhija Prytuli](https://prytulafoundation.org/en/)
>   - [Fundację Come Back Alive](https://savelife.in.ua/en/donate-en/)
>   - [Narodowy Bank Ukrainy](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - Więcej informacji na [war.ukraine.ua](https://war.ukraine.ua/) oraz [MFA Ukrainy](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

To repozytorium zawiera przykłady wielu
popularnych algorytmów i struktur danych opartych na JavaScript.

Każdy algorytm i struktura danych posiada osobny plik README
z odpowiednimi wyjaśnieniami i linkami do dalszej lektury (w tym do
filmów na YouTube).

_Przeczytaj to w innych językach:_
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

*☝ Zauważ, że ten projekt jest przeznaczony wyłącznie do nauki i badań
i **nie** jest przeznaczony do produkcji.*

## Struktury Danych

Struktura danych to określony sposób organizowania i przechowywania danych w komputerze, tak aby można było
je efektywnie pobierać i modyfikować. Dokładniej, struktura danych to zbiór wartości danych,
relacji między nimi oraz funkcji lub operacji, które można na tych danych wykonywać.

Pamiętaj, że każda struktura danych ma swoje kompromisy. Bardziej niż na tym, jak ją zaimplementować, powinieneś zwracać uwagę, dlaczego wybierasz właśnie tę strukturę danych.

`B` - Początkujący, `A` - Zaawansowany

* `B` [Lista jednokierunkowa](src/data-structures/linked-list)
* `B` [Lista dwukierunkowa](src/data-structures/doubly-linked-list)
* `B` [Kolejka](src/data-structures/queue)
* `B` [Stos](src/data-structures/stack)
* `B` [Tablica mieszająca (Hash Table)](src/data-structures/hash-table)
* `B` [Kopiec (Heap)](src/data-structures/heap) - wersje max i min kopca
* `B` [Kolejka priorytetowa](src/data-structures/priority-queue)
* `A` [Trie](src/data-structures/trie)
* `A` [Drzewo](src/data-structures/tree)
  * `A` [Drzewo BST](src/data-structures/tree/binary-search-tree)
  * `A` [Drzewo AVL](src/data-structures/tree/avl-tree)
  * `A` [Drzewo czerwono-czarne](src/data-structures/tree/red-black-tree)
  * `A` [Drzewo przedziałowe (Segment Tree)](src/data-structures/tree/segment-tree) - z przykładami zapytań min/max/suma w zakresie
  * `A` [Drzewo Fenwicka](src/data-structures/tree/fenwick-tree) (Binary Indexed Tree)
* `A` [Graf](src/data-structures/graph) (zarówno skierowany, jak i nieskierowany)
* `A` [Zbiór rozłączny (Disjoint Set)](src/data-structures/disjoint-set) - struktura zbiorów rozłącznych (union–find)
* `A` [Filtr Blooma (Bloom Filter)](src/data-structures/bloom-filter)
* `A` [LRU Cache](src/data-structures/lru-cache/) - cache o strategii Least Recently Used

## Algorytmy

Algorytm to jednoznaczna specyfikacja sposobu rozwiązania określonej klasy problemów. To
zbiór reguł dokładnie określających sekwencję operacji.

`B` - Początkujący, `A` - Zaawansowany

### Algorytmy według tematu

* **Matematyka**
  * `B` [Operacje na bitach](src/algorithms/math/bits) - ustawianie/pobieranie/aktualizacja/czyszczenie bitów, mnożenie/dzielenie przez dwa, negacja itd.
  * `B` [Liczby zmiennoprzecinkowe binarne](src/algorithms/math/binary-floating-point) - binarna reprezentacja liczb zmiennoprzecinkowych.
  * `B` [Silnia](src/algorithms/math/factorial)
  * `B` [Liczby Fibonacciego](src/algorithms/math/fibonacci) - wersje klasyczne i zamknięte
  * `B` [Czynniki pierwsze](src/algorithms/math/prime-factors) - znajdowanie i liczenie czynników pierwszych (twierdzenie Hardy'ego-Ramanujana)
  * `B` [Test pierwszości](src/algorithms/math/primality-test) (metoda dzielenia próbnego)
  * `B` [Algorytm Euklidesa](src/algorithms/math/euclidean-algorithm) - największy wspólny dzielnik (GCD)
  * `B` [Najmniejsza wspólna wielokrotność](src/algorithms/math/least-common-multiple) (LCM)
  * `B` [Sito Eratostenesa](src/algorithms/math/sieve-of-eratosthenes) - znajdowanie wszystkich liczb pierwszych do określonej granicy
  * `B` [Czy potęga dwójki](src/algorithms/math/is-power-of-two) - sprawdzenie czy liczba jest potęgą dwójki (naiwne i bitowe algorytmy)
  * `B` [Trójkąt Pascala](src/algorithms/math/pascal-triangle)
  * `B` [Liczby zespolone](src/algorithms/math/complex-number) - liczby zespolone i podstawowe operacje
  * `B` [Radiany i stopnie](src/algorithms/math/radian) - konwersja radianów na stopnie i odwrotnie
  * `B` [Szybkie potęgowanie](src/algorithms/math/fast-powering)
  * `B` [Metoda Hornera](src/algorithms/math/horner-method) - obliczanie wartości wielomianu
  * `B` [Macierze](src/algorithms/math/matrix) - macierze i operacje na nich (mnożenie, transpozycja itd.)
  * `B` [Odległość Euklidesowa](src/algorithms/math/euclidean-distance) - odległość między punktami/wektorami/macierzami
  * `A` [Rozkład liczby na sumy](src/algorithms/math/integer-partition)
  * `A` [Pierwiastek kwadratowy](src/algorithms/math/square-root) - metoda Newtona
  * `A` [Algorytm Liu Hui do przybliżania liczby π](src/algorithms/math/liu-hui) - przybliżenia π na podstawie N-wielokątów
  * `A` [Dyskretny transformata Fouriera](src/algorithms/math/fourier-transform) - rozkład sygnału na częstotliwości
* **Zbiory**
  * `B` [Iloczyn kartezjański](src/algorithms/sets/cartesian-product) - iloczyn wielu zbiorów
  * `B` [Tasowanie Fishera–Yatesa](src/algorithms/sets/fisher-yates) - losowa permutacja skończonej sekwencji
  * `A` [Zbiór potęgowy](src/algorithms/sets/power-set) - wszystkie podzbiory zbioru (bitowe, rekurencyjne, kaskadowe)
  * `A` [Permutacje](src/algorithms/sets/permutations) (z powtórzeniami i bez)
  * `A` [Kombinacje](src/algorithms/sets/combinations) (z powtórzeniami i bez)
  * `A` [Najdłuższy wspólny podciąg](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Najdłuższy rosnący podciąg](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Najkrótsza wspólna nadsekwencja](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [Problem plecakowy](src/algorithms/sets/knapsack-problem) - wersje "0/1" i "bez ograniczeń"
  * `A` [Maksymalny podciąg sumy](src/algorithms/sets/maximum-subarray) - wersje "brute force" i "dynamiczne programowanie" (Kadane)
  * `A` [Suma kombinacji](src/algorithms/sets/combination-sum) - znajdowanie wszystkich kombinacji dających określoną sumę
* **Ciągi znaków**
  * `B` [Odległość Hamminga](src/algorithms/string/hamming-distance) - liczba pozycji, na których znaki się różnią
  * `B` [Palindrom](src/algorithms/string/palindrome) - sprawdzenie czy ciąg jest taki sam od końca
  * `A` [Odległość Levenshteina](src/algorithms/string/levenshtein-distance) - minimalna odległość edycyjna między dwoma sekwencjami
  * `A` [Algorytm Knutha–Morrisa–Pratta](src/algorithms/string/knuth-morris-pratt) (KMP) - wyszukiwanie podciągu (dopasowywanie wzorca)
  * `A` [Algorytm Z](src/algorithms/string/z-algorithm) - wyszukiwanie podciągu (dopasowywanie wzorca)
  * `A` [Algorytm Rabina-Karpa](src/algorithms/string/rabin-karp) - wyszukiwanie podciągu
  * `A` [Najdłuższy wspólny podciąg znaków](src/algorithms/string/longest-common-substring)
  * `A` [Dopasowanie wyrażenia regularnego](src/algorithms/string/regular-expression-matching)
* **Wyszukiwanie**
  * `B` [Wyszukiwanie liniowe](src/algorithms/search/linear-search)
  * `B` [Wyszukiwanie skokowe](src/algorithms/search/jump-search) (blokowe) - w posortowanej tablicy
  * `B` [Wyszukiwanie binarne](src/algorithms/search/binary-search) - w posortowanej tablicy
  * `B` [Wyszukiwanie interpolacyjne](src/algorithms/search/interpolation-search) - w równomiernie rozłożonej tablicy posortowanej
* **Sortowanie**
  * `B` [Sortowanie bąbelkowe](src/algorithms/sorting/bubble-sort)
  * `B` [Sortowanie przez wybór](src/algorithms/sorting/selection-sort)
  * `B` [Sortowanie przez wstawianie](src/algorithms/sorting/insertion-sort)
  * `B` [Sortowanie przez kopcowanie](src/algorithms/sorting/heap-sort)
  * `B` [Sortowanie przez scalanie](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort) - implementacje in-place i nie-in-place
  * `B` [Shellsort](src/algorithms/sorting/shell-sort)
  * `B` [Sortowanie przez zliczanie](src/algorithms/sorting/counting-sort)
  * `B` [Sortowanie pozycyjne (Radix Sort)](src/algorithms/sorting/radix-sort)
  * `B` [Sortowanie kubełkowe (Bucket Sort)](src/algorithms/sorting/bucket-sort)
* **Listy**
  * `B` [Przechodzenie w przód](src/algorithms/linked-list/traversal)
  * `B` [Przechodzenie wstecz](src/algorithms/linked-list/reverse-traversal)
* **Drzewa**
  * `B` [Przeszukiwanie wgłąb (DFS)](src/algorithms/tree/depth-first-search)
  * `B` [Przeszukiwanie wszerz (BFS)](src/algorithms/tree/breadth-first-search)
* **Grafy**
  * `B` [Przeszukiwanie wgłąb (DFS)](src/algorithms/graph/depth-first-search)
  * `B` [Przeszukiwanie wszerz (BFS)](src/algorithms/graph/breadth-first-search)
  * `B` [Algorytm Kruskala](src/algorithms/graph/kruskal) - znajdowanie minimalnego drzewa rozpinającego (MST) dla ważonego grafu nieskierowanego
  * `A` [Algorytm Dijkstry](src/algorithms/graph/dijkstra) - najkrótsze ścieżki do wszystkich wierzchołków grafu
  * `A` [Algorytm Bellmana-Forda](src/algorithms/graph/bellman-ford) - najkrótsze ścieżki do wszystkich wierzchołków grafu
  * `A` [Algorytm Floyda-Warshalla](src/algorithms/graph/floyd-warshall) - najkrótsze ścieżki między wszystkimi parami wierzchołków
  * `A` [Wykrywanie cykli](src/algorithms/graph/detect-cycle) - dla grafów skierowanych i nieskierowanych (wersje DFS i zbiorów rozłącznych)
  * `A` [Algorytm Prima](src/algorithms/graph/prim) - znajdowanie minimalnego drzewa rozpinającego (MST) dla ważonego grafu nieskierowanego
  * `A` [Sortowanie topologiczne](src/algorithms/graph/topological-sorting) - metoda DFS
  * `A` [Punkty artykulacji](src/algorithms/graph/articulation-points) - algorytm Tarjana (na bazie DFS)
  * `A` [Mosty](src/algorithms/graph/bridges) - algorytm na bazie DFS
  * `A` [Ścieżka Eulera i cykl Eulera](src/algorithms/graph/eulerian-path) - algorytm Fleury'ego - każda krawędź odwiedzona dokładnie raz
  * `A` [Cykl Hamiltona](src/algorithms/graph/hamiltonian-cycle) - każdy wierzchołek odwiedzony dokładnie raz
  * `A` [Silnie spójne składowe](src/algorithms/graph/strongly-connected-components) - algorytm Kosaraju
  * `A` [Problem komiwojażera](src/algorithms/graph/travelling-salesman) - najkrótsza możliwa trasa odwiedzająca każde miasto i wracająca do punktu początkowego
* **Kryptografia**
  * `B` [Hash wielomianowy](src/algorithms/cryptography/polynomial-hash) - haszowanie "rolling hash" na bazie wielomianu
  * `B` [Szyfr płotkowy (Rail Fence Cipher)](src/algorithms/cryptography/rail-fence-cipher) - szyfr przestawieniowy
  * `B` [Szyfr Cezara](src/algorithms/cryptography/caesar-cipher) - prosty szyfr podstawieniowy
  * `B` [Szyfr Hilla](src/algorithms/cryptography/hill-cipher) - szyfr podstawieniowy oparty na algebrze liniowej
* **Uczenie maszynowe**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 7 prostych funkcji JS ilustrujących naukę maszynową (propagacja w przód/wstecz)
  * `B` [k-NN](src/algorithms/ml/knn) - algorytm klasyfikacji najbliższych sąsiadów
  * `B` [k-Means](src/algorithms/ml/k-means) - algorytm klastrowania k-średnich
* **Przetwarzanie obrazów**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - algorytm zmiany rozmiaru obrazu z zachowaniem treści
* **Statystyka**
  * `B` [Losowanie ważone](src/algorithms/statistics/weighted-random) - wybór losowego elementu z listy na podstawie wag
* **Algorytmy ewolucyjne**
  * `A` [Algorytm genetyczny](https://github.com/trekhleb/self-parking-car-evolution) - przykład zastosowania algorytmu genetycznego do trenowania samoparkujących się samochodów
* **Nieprzypisane**
  * `B` [Wieże Hanoi](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Obrót kwadratowej macierzy](src/algorithms/uncategorized/square-matrix-rotation) - algorytm in-place
  * `B` [Gra skoków](src/algorithms/uncategorized/jump-game) - przykłady z użyciem rekurencji, programowania dynamicznego (top-down, bottom-up) i zachłannego
  * `B` [Unikalne ścieżki](src/algorithms/uncategorized/unique-paths) - przykłady z użyciem rekurencji, programowania dynamicznego i trójkąta Pascala
  * `B` [Tarasy deszczowe](src/algorithms/uncategorized/rain-terraces) - problem magazynowania wody (wersje DP i brute force)
  * `B` [Rekurencyjne schody](src/algorithms/uncategorized/recursive-staircase) - liczba sposobów wejścia na szczyt (4 rozwiązania)
  * `B` [Najlepszy czas na kupno/sprzedaż akcji](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - przykłady podziału i podboju oraz jednokrotnego przejścia
  * `B` [Poprawność nawiasów](src/algorithms/stack/valid-parentheses) - sprawdzenie czy ciąg zawiera poprawne nawiasy (stos)
  * `A` [Problem N-hetmanów](src/algorithms/uncategorized/n-queens)
  * `A` [Trasa skoczka szachowego](src/algorithms/uncategorized/knight-tour)

### Algorytmy według paradygmatu

Paradygmat algorytmiczny to ogólna metoda lub podejście leżące u podstaw projektowania danej klasy
algorytmów. Jest to abstrakcja wyższego poziomu niż pojęcie algorytmu, podobnie jak
algorytm jest abstrakcją wyższą niż program komputerowy.

* **Brute Force** – sprawdza wszystkie możliwości i wybiera najlepsze rozwiązanie
  * `B` [Wyszukiwanie liniowe](src/algorithms/search/linear-search)
  * `B` [Tarasy deszczowe](src/algorithms/uncategorized/rain-terraces) - problem magazynowania wody
  * `B` [Rekurencyjne schody](src/algorithms/uncategorized/recursive-staircase) - liczba sposobów wejścia na szczyt
  * `A` [Maksymalny podciąg sumy](src/algorithms/sets/maximum-subarray)
  * `A` [Problem komiwojażera](src/algorithms/graph/travelling-salesman) - najkrótsza możliwa trasa odwiedzająca każde miasto i wracająca do punktu początkowego
  * `A` [Dyskretny transformata Fouriera](src/algorithms/math/fourier-transform) - rozkład sygnału na częstotliwości
* **Zachłanne** – wybiera najlepszą opcję w danej chwili, nie patrząc na przyszłość
  * `B` [Gra skoków](src/algorithms/uncategorized/jump-game)
  * `A` [Problem plecakowy bez ograniczeń](src/algorithms/sets/knapsack-problem)
  * `A` [Algorytm Dijkstry](src/algorithms/graph/dijkstra) - najkrótsza ścieżka do wszystkich wierzchołków grafu
  * `A` [Algorytm Prima](src/algorithms/graph/prim) - minimalne drzewo rozpinające (MST)
  * `A` [Algorytm Kruskala](src/algorithms/graph/kruskal) - minimalne drzewo rozpinające (MST)
* **Podział i podbój** – dzieli problem na mniejsze części, a następnie rozwiązuje je
  * `B` [Wyszukiwanie binarne](src/algorithms/search/binary-search)
  * `B` [Wieże Hanoi](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Trójkąt Pascala](src/algorithms/math/pascal-triangle)
  * `B` [Algorytm Euklidesa](src/algorithms/math/euclidean-algorithm) - największy wspólny dzielnik (GCD)
  * `B` [Sortowanie przez scalanie](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort)
  * `B` [Przeszukiwanie drzewa DFS](src/algorithms/tree/depth-first-search)
  * `B` [Przeszukiwanie grafu DFS](src/algorithms/graph/depth-first-search)
  * `B` [Macierze](src/algorithms/math/matrix) - generowanie i przechodzenie macierzy o różnych kształtach
  * `B` [Gra skoków](src/algorithms/uncategorized/jump-game)
  * `B` [Szybkie potęgowanie](src/algorithms/math/fast-powering)
  * `B` [Najlepszy czas na kupno/sprzedaż akcji](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - podział i podbój oraz przykłady jednokrotnego przejścia
  * `A` [Permutacje](src/algorithms/sets/permutations) (z powtórzeniami i bez)
  * `A` [Kombinacje](src/algorithms/sets/combinations) (z powtórzeniami i bez)
  * `A` [Maksymalny podciąg sumy](src/algorithms/sets/maximum-subarray)
* **Programowanie dynamiczne** – buduje rozwiązanie na podstawie wcześniej znalezionych podrozwiązań
  * `B` [Liczby Fibonacciego](src/algorithms/math/fibonacci)
  * `B` [Gra skoków](src/algorithms/uncategorized/jump-game)
  * `B` [Unikalne ścieżki](src/algorithms/uncategorized/unique-paths)
  * `B` [Tarasy deszczowe](src/algorithms/uncategorized/rain-terraces) - problem magazynowania wody
  * `B` [Rekurencyjne schody](src/algorithms/uncategorized/recursive-staircase) - liczba sposobów wejścia na szczyt
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - zmiana rozmiaru obrazu z zachowaniem treści
  * `A` [Odległość Levenshteina](src/algorithms/string/levenshtein-distance) - minimalna odległość edycyjna
  * `A` [Najdłuższy wspólny podciąg](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Najdłuższy wspólny podciąg znaków](src/algorithms/string/longest-common-substring)
  * `A` [Najdłuższy rosnący podciąg](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Najkrótsza wspólna nadsekwencja](src/algorithms/sets/shortest-common-supersequence)
  * `A` [Problem plecakowy 0/1](src/algorithms/sets/knapsack-problem)
  * `A` [Rozkład liczby na sumy](src/algorithms/math/integer-partition)
  * `A` [Maksymalny podciąg sumy](src/algorithms/sets/maximum-subarray)
  * `A` [Algorytm Bellmana-Forda](src/algorithms/graph/bellman-ford) - najkrótsza ścieżka do wszystkich wierzchołków grafu
  * `A` [Algorytm Floyda-Warshalla](src/algorithms/graph/floyd-warshall) - najkrótsze ścieżki między wszystkimi parami wierzchołków
  * `A` [Dopasowanie wyrażenia regularnego](src/algorithms/string/regular-expression-matching)
* **Backtracking** – podobnie jak brute force, generuje wszystkie możliwe rozwiązania, ale za każdym razem, gdy generuje kolejne rozwiązanie, sprawdza
czy spełnia wszystkie warunki i tylko wtedy kontynuuje generowanie dalszych rozwiązań. W przeciwnym razie cofa się i wybiera inną ścieżkę. Zazwyczaj używane jest przechodzenie DFS po przestrzeni stanów.
  * `B` [Gra skoków](src/algorithms/uncategorized/jump-game)
  * `B` [Unikalne ścieżki](src/algorithms/uncategorized/unique-paths)
  * `B` [Zbiór potęgowy](src/algorithms/sets/power-set) - wszystkie podzbiory zbioru
  * `A` [Cykl Hamiltona](src/algorithms/graph/hamiltonian-cycle) - każdy wierzchołek odwiedzony dokładnie raz
  * `A` [Problem N-hetmanów](src/algorithms/uncategorized/n-queens)
  * `A` [Trasa skoczka szachowego](src/algorithms/uncategorized/knight-tour)
  * `A` [Suma kombinacji](src/algorithms/sets/combination-sum) - wszystkie kombinacje dające określoną sumę
* **Branch & Bound** – zapamiętuje najtańsze rozwiązanie znalezione na danym etapie przeszukiwania backtrackingowego
i wykorzystuje koszt najlepszego znalezionego rozwiązania jako dolne ograniczenie, by odrzucać częściowe rozwiązania o większych kosztach. Zazwyczaj używana jest kombinacja BFS i DFS po drzewie przestrzeni stanów.

## Jak używać tego repozytorium

**Zainstaluj wszystkie zależności**

```
npm install
```

**Uruchom ESLint**

Możesz uruchomić ten program, aby sprawdzić jakość kodu.

```
npm run lint
```

**Uruchom wszystkie testy**

```
npm test
```

**Uruchom testy według nazwy**

```
npm test -- 'LinkedList'
```

**Rozwiązywanie problemów**

Jeśli lintowanie lub testowanie się nie powiodło, spróbuj usunąć folder `node_modules` i ponownie zainstalować pakiety npm:

```
rm -rf ./node_modules
npm i
```

Upewnij się także, że używasz właściwej wersji Node (`>=16`). Jeśli używasz [nvm](https://github.com/nvm-sh/nvm) do zarządzania wersją Node, możesz uruchomić `nvm use` z katalogu głównego projektu, a odpowiednia wersja zostanie wybrana.

**Playground**

Możesz pobawić się strukturami danych i algorytmami w pliku `./src/playground/playground.js` oraz napisać
do niego testy w `./src/playground/__test__/playground.test.js`.

Następnie po prostu uruchom poniższą komendę, aby sprawdzić, czy Twój kod działa zgodnie z oczekiwaniami:

```
npm test -- 'playground'
```

## Przydatne informacje

### Źródła

- [▶ Struktury danych i algorytmy na YouTube](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 Szkice struktur danych](https://okso.app/showcase/data-structures)

### Notacja Big O

*Notacja Big O* służy do klasyfikowania algorytmów według tego, jak rośnie ich czas działania lub wymagania pamięciowe wraz ze wzrostem rozmiaru danych wejściowych.
Na poniższym wykresie przedstawiono najczęściej spotykane rzędy wzrostu algorytmów w notacji Big O.

![Big O graphs](./assets/big-o-graph.png)

Źródło: [Big O Cheat Sheet](http://bigocheatsheet.com/).

Poniżej znajduje się lista najczęściej używanych notacji Big O i ich porównanie wydajnościowe dla różnych rozmiarów danych wejściowych.

| Notacja Big O   | Typ         | Obliczenia dla 10 elementów | Obliczenia dla 100 elementów | Obliczenia dla 1000 elementów   |
| --------------- | ----------- | --------------------------- | ---------------------------- | ------------------------------- |
| **O(1)**        | Stała       | 1                           | 1                            | 1                               |
| **O(log N)**    | Logarytmiczny| 3                           | 6                            | 9                               |
| **O(N)**        | Liniowy     | 10                          | 100                          | 1000                            |
| **O(N log N)**  | N log(n)    | 30                          | 600                          | 9000                            |
| **O(N^2)**      | Kwadratowy  | 100                         | 10000                        | 1000000                         |
| **O(2^N)**      | Wykładniczy | 1024                        | 1.26e+29                     | 1.07e+301                       |
| **O(N!)**       | Silniowy    | 3628800                     | 9.3e+157                     | 4.02e+2567                      |

### Złożoność operacji na strukturach danych

| Struktura danych         | Odczyt    | Wyszukiwanie | Wstawianie | Usuwanie   | Uwagi  |
| ------------------------ | :-------: | :----------: | :--------: | :--------: | :----- |
| **Tablica**              | 1         | n            | n          | n          |        |
| **Stos**                 | n         | n            | 1          | 1          |        |
| **Kolejka**              | n         | n            | 1          | 1          |        |
| **Lista jednokierunkowa**| n         | n            | 1          | n          |        |
| **Tablica mieszająca**   | -         | n            | n          | n          | Przy idealnej funkcji hashującej O(1) |
| **Drzewo BST**           | n         | n            | n          | n          | Przy zbalansowanym drzewie O(log(n)) |
| **Drzewo B**             | log(n)    | log(n)       | log(n)     | log(n)     |        |
| **Drzewo czerwono-czarne**| log(n)   | log(n)       | log(n)     | log(n)     |        |
| **Drzewo AVL**           | log(n)    | log(n)       | log(n)     | log(n)     |        |
| **Filtr Blooma**         | -         | 1            | 1          | -          | Możliwe fałszywe trafienia przy wyszukiwaniu |

### Złożoność algorytmów sortowania tablic

| Nazwa                 | Najlepszy        | Średni               | Najgorszy             | Pamięć    | Stabilny   | Uwagi     |
| --------------------- | :--------------: | :------------------: | :-------------------: | :-------: | :--------: | :-------- |
| **Sortowanie bąbelkowe** | n             | n<sup>2</sup>        | n<sup>2</sup>         | 1         | Tak        |           |
| **Sortowanie przez wstawianie** | n      | n<sup>2</sup>        | n<sup>2</sup>         | 1         | Tak        |           |
| **Sortowanie przez wybór** | n<sup>2</sup> | n<sup>2</sup>       | n<sup>2</sup>         | 1         | Nie        |           |
| **Sortowanie przez kopcowanie** | n&nbsp;log(n) | n&nbsp;log(n) | n&nbsp;log(n)         | 1         | Nie        |           |
| **Sortowanie przez scalanie** | n&nbsp;log(n) | n&nbsp;log(n) | n&nbsp;log(n)         | n         | Tak        |           |
| **Quicksort**         | n&nbsp;log(n)    | n&nbsp;log(n)        | n<sup>2</sup>         | log(n)    | Nie        | Zwykle in-place z O(log(n)) miejsca na stosie |
| **Shellsort**         | n&nbsp;log(n)    | zależy od sekwencji odstępów | n&nbsp;(log(n))<sup>2</sup> | 1         | Nie        |           |
| **Sortowanie przez zliczanie** | n + r  | n + r                | n + r                 | n + r     | Tak        | r - największa liczba w tablicy |
| **Sortowanie pozycyjne (Radix sort)** | n * k | n * k         | n * k                 | n + k     | Tak        | k - długość najdłuższego klucza |

## Wspierający projekt

> Możesz wesprzeć ten projekt ❤️️ przez [GitHub](https://github.com/sponsors/trekhleb) lub ❤️️ przez [Patreon](https://www.patreon.com/trekhleb).

[Osoby wspierające ten projekt](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## Autor

[@trekhleb](https://trekhleb.dev)

Kilka innych [projektów](https://trekhleb.dev/projects/) i [artykułów](https://trekhleb.dev/blog/) o JavaScript i algorytmach na [trekhleb.dev](https://trekhleb.dev)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---