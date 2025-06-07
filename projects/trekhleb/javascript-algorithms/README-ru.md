# Алгоритмы и структуры данных на JavaScript

> 🇺🇦 УКРАИНА [ПОДВЕРГАЕТСЯ АТАКЕ](https://war.ukraine.ua/) РОССИЙСКОЙ АРМИИ. ГИБНУТ МИРНЫЕ ЖИТЕЛИ. ЖИЛЫЕ КВАРТАЛЫ БОМБЯТ.
> - Помогите Украине через:
>   - [Благотворительный фонд Сергея Притулы](https://prytulafoundation.org/en/)
>   - [Благотворительный фонд «Повернись живым»](https://savelife.in.ua/en/donate-en/)
>   - [Национальный банк Украины](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - Подробнее на [war.ukraine.ua](https://war.ukraine.ua/) и [МИД Украины](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

Этот репозиторий содержит примеры многих популярных алгоритмов и структур данных на JavaScript.

Каждый алгоритм и структура данных имеют свой отдельный файл README с соответствующими объяснениями и ссылками для дальнейшего изучения (в том числе на видео на YouTube).

_Читайте на других языках:_
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

*☝ Обратите внимание, что этот проект предназначен только для обучения и исследований, и **не** предназначен для использования в продакшене.*

## Структуры данных

Структура данных — это особый способ организации и хранения данных в компьютере, чтобы обеспечить их эффективный доступ и модификацию. Точнее, структура данных — это совокупность значений данных, отношений между ними и функций или операций, которые могут быть применены к этим данным.

Помните, что каждая структура данных имеет свои плюсы и минусы. Важно больше обращать внимание на то, почему вы выбираете ту или иную структуру данных, чем на то, как её реализовать.

`B` — Начальный уровень, `A` — Продвинутый уровень

* `B` [Связанный список (Linked List)](src/data-structures/linked-list)
* `B` [Двунаправленный связанный список (Doubly Linked List)](src/data-structures/doubly-linked-list)
* `B` [Очередь (Queue)](src/data-structures/queue)
* `B` [Стек (Stack)](src/data-structures/stack)
* `B` [Хеш-таблица (Hash Table)](src/data-structures/hash-table)
* `B` [Куча (Heap)](src/data-structures/heap) — максимальная и минимальная версии кучи
* `B` [Очередь с приоритетом (Priority Queue)](src/data-structures/priority-queue)
* `A` [Trie](src/data-structures/trie)
* `A` [Дерево (Tree)](src/data-structures/tree)
  * `A` [Двоичное дерево поиска (Binary Search Tree)](src/data-structures/tree/binary-search-tree)
  * `A` [AVL-дерево](src/data-structures/tree/avl-tree)
  * `A` [Красно-черное дерево (Red-Black Tree)](src/data-structures/tree/red-black-tree)
  * `A` [Сегментное дерево (Segment Tree)](src/data-structures/tree/segment-tree) — примеры запросов min/max/sum на отрезке
  * `A` [Дерево Фенвика (Fenwick Tree)](src/data-structures/tree/fenwick-tree) (Binary Indexed Tree)
* `A` [Граф (Graph)](src/data-structures/graph) (ориентированные и неориентированные)
* `A` [Система непересекающихся множеств (Disjoint Set)](src/data-structures/disjoint-set) — структура данных union–find или merge–find set
* `A` [Блум-фильтр (Bloom Filter)](src/data-structures/bloom-filter)
* `A` [LRU-кэш (LRU Cache)](src/data-structures/lru-cache/) — кэш с вытеснением наименее недавно использованных элементов

## Алгоритмы

Алгоритм — это однозначное описание способа решения класса задач. Это набор правил, которые точно определяют последовательность операций.

`B` — Начальный уровень, `A` — Продвинутый уровень

### Алгоритмы по темам

* **Математика**
  * `B` [Битовые операции (Bit Manipulation)](src/algorithms/math/bits) — установка/получение/обновление/очистка битов, умножение/деление на два, отрицание и т.д.
  * `B` [Двоичная плавающая точка (Binary Floating Point)](src/algorithms/math/binary-floating-point) — двоичное представление чисел с плавающей точкой
  * `B` [Факториал (Factorial)](src/algorithms/math/factorial)
  * `B` [Число Фибоначчи (Fibonacci Number)](src/algorithms/math/fibonacci) — классическая и формула Бине
  * `B` [Простые множители (Prime Factors)](src/algorithms/math/prime-factors) — нахождение и подсчёт простых множителей по теореме Харди–Рамануджана
  * `B` [Проверка на простоту (Primality Test)](src/algorithms/math/primality-test) (метод пробного деления)
  * `B` [Алгоритм Евклида (Euclidean Algorithm)](src/algorithms/math/euclidean-algorithm) — вычисление наибольшего общего делителя (НОД)
  * `B` [Наименьшее общее кратное (Least Common Multiple)](src/algorithms/math/least-common-multiple) (НОК)
  * `B` [Решето Эратосфена (Sieve of Eratosthenes)](src/algorithms/math/sieve-of-eratosthenes) — поиск всех простых чисел до заданного предела
  * `B` [Является ли степенью двойки (Is Power of Two)](src/algorithms/math/is-power-of-two) — проверка, является ли число степенью двойки (наивный и побитовый алгоритмы)
  * `B` [Треугольник Паскаля (Pascal's Triangle)](src/algorithms/math/pascal-triangle)
  * `B` [Комплексное число (Complex Number)](src/algorithms/math/complex-number) — комплексные числа и базовые операции с ними
  * `B` [Радианы и градусы (Radian & Degree)](src/algorithms/math/radian) — преобразование радианов в градусы и обратно
  * `B` [Быстрое возведение в степень (Fast Powering)](src/algorithms/math/fast-powering)
  * `B` [Метод Горнера (Horner's method)](src/algorithms/math/horner-method) — вычисление значения многочлена
  * `B` [Матрицы (Matrices)](src/algorithms/math/matrix) — матрицы и основные операции (умножение, транспонирование и др.)
  * `B` [Евклидово расстояние (Euclidean Distance)](src/algorithms/math/euclidean-distance) — расстояние между двумя точками/векторами/матрицами
  * `A` [Разбиение числа на слагаемые (Integer Partition)](src/algorithms/math/integer-partition)
  * `A` [Квадратный корень (Square Root)](src/algorithms/math/square-root) — метод Ньютона
  * `A` [Алгоритм Лю Хуя для π (Liu Hui π Algorithm)](src/algorithms/math/liu-hui) — приближённые вычисления π на основе N-угольников
  * `A` [Дискретное преобразование Фурье (Discrete Fourier Transform)](src/algorithms/math/fourier-transform) — разложение функции времени (сигнала) на составляющие частоты
* **Множества**
  * `B` [Декартово произведение (Cartesian Product)](src/algorithms/sets/cartesian-product) — произведение нескольких множеств
  * `B` [Перемешивание Фишера–Йейтса (Fisher–Yates Shuffle)](src/algorithms/sets/fisher-yates) — случайная перестановка конечной последовательности
  * `A` [Множество всех подмножеств (Power Set)](src/algorithms/sets/power-set) — все подмножества множества (битовые, с возвратом, каскадные решения)
  * `A` [Перестановки (Permutations)](src/algorithms/sets/permutations) (с повторениями и без)
  * `A` [Сочетания (Combinations)](src/algorithms/sets/combinations) (с повторениями и без)
  * `A` [Наибольшая общая подпоследовательность (Longest Common Subsequence)](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Наибольшая возрастающая подпоследовательность (Longest Increasing Subsequence)](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Кратчайшая общая суперпоследовательность (Shortest Common Supersequence)](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [Задача о рюкзаке (Knapsack Problem)](src/algorithms/sets/knapsack-problem) — "0/1" и "с неограниченным числом предметов"
  * `A` [Максимальная сумма подмассива (Maximum Subarray)](src/algorithms/sets/maximum-subarray) — наивный и динамический (алгоритм Кадане) варианты
  * `A` [Сумма сочетаний (Combination Sum)](src/algorithms/sets/combination-sum) — поиск всех сочетаний, дающих заданную сумму
* **Строки**
  * `B` [Расстояние Хэмминга (Hamming Distance)](src/algorithms/string/hamming-distance) — количество позиций, в которых символы различаются
  * `B` [Палиндром (Palindrome)](src/algorithms/string/palindrome) — проверка, является ли строка палиндромом
  * `A` [Расстояние Левенштейна (Levenshtein Distance)](src/algorithms/string/levenshtein-distance) — минимальное количество правок для преобразования одной строки в другую
  * `A` [Алгоритм Кнута–Морриса–Пратта (Knuth–Morris–Pratt Algorithm)](src/algorithms/string/knuth-morris-pratt) (KMP) — поиск подстроки (сопоставление образца)
  * `A` [Z-алгоритм (Z Algorithm)](src/algorithms/string/z-algorithm) — поиск подстроки (сопоставление образца)
  * `A` [Алгоритм Рабина–Карпа (Rabin Karp Algorithm)](src/algorithms/string/rabin-karp) — поиск подстроки
  * `A` [Наибольшая общая подстрока (Longest Common Substring)](src/algorithms/string/longest-common-substring)
  * `A` [Сопоставление регулярных выражений (Regular Expression Matching)](src/algorithms/string/regular-expression-matching)
* **Поиски**
  * `B` [Линейный поиск (Linear Search)](src/algorithms/search/linear-search)
  * `B` [Прыжковый поиск (Jump Search)](src/algorithms/search/jump-search) (или блочный поиск) — поиск в отсортированном массиве
  * `B` [Бинарный поиск (Binary Search)](src/algorithms/search/binary-search) — поиск в отсортированном массиве
  * `B` [Интерполяционный поиск (Interpolation Search)](src/algorithms/search/interpolation-search) — поиск в равномерно распределённом отсортированном массиве
* **Сортировки**
  * `B` [Пузырьковая сортировка (Bubble Sort)](src/algorithms/sorting/bubble-sort)
  * `B` [Сортировка выбором (Selection Sort)](src/algorithms/sorting/selection-sort)
  * `B` [Сортировка вставками (Insertion Sort)](src/algorithms/sorting/insertion-sort)
  * `B` [Пирамидальная сортировка (Heap Sort)](src/algorithms/sorting/heap-sort)
  * `B` [Сортировка слиянием (Merge Sort)](src/algorithms/sorting/merge-sort)
  * `B` [Быстрая сортировка (Quicksort)](src/algorithms/sorting/quick-sort) — реализована in-place и не-in-place
  * `B` [Сортировка Шелла (Shellsort)](src/algorithms/sorting/shell-sort)
  * `B` [Сортировка подсчётом (Counting Sort)](src/algorithms/sorting/counting-sort)
  * `B` [Поразрядная сортировка (Radix Sort)](src/algorithms/sorting/radix-sort)
  * `B` [Сортировка корзинами (Bucket Sort)](src/algorithms/sorting/bucket-sort)
* **Связанные списки**
  * `B` [Прямой обход (Straight Traversal)](src/algorithms/linked-list/traversal)
  * `B` [Обратный обход (Reverse Traversal)](src/algorithms/linked-list/reverse-traversal)
* **Деревья**
  * `B` [Поиск в глубину (Depth-First Search)](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Поиск в ширину (Breadth-First Search)](src/algorithms/tree/breadth-first-search) (BFS)
* **Графы**
  * `B` [Поиск в глубину (Depth-First Search)](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Поиск в ширину (Breadth-First Search)](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [Алгоритм Крускала (Kruskal’s Algorithm)](src/algorithms/graph/kruskal) — поиск минимального остовного дерева (MST) для взвешенного неориентированного графа
  * `A` [Алгоритм Дейкстры (Dijkstra Algorithm)](src/algorithms/graph/dijkstra) — поиск кратчайших путей до всех вершин графа из одной вершины
  * `A` [Алгоритм Беллмана–Форда (Bellman-Ford Algorithm)](src/algorithms/graph/bellman-ford) — поиск кратчайших путей до всех вершин графа из одной вершины
  * `A` [Алгоритм Флойда–Уоршелла (Floyd-Warshall Algorithm)](src/algorithms/graph/floyd-warshall) — поиск кратчайших путей между всеми парами вершин
  * `A` [Обнаружение цикла (Detect Cycle)](src/algorithms/graph/detect-cycle) — для направленных и ненаправленных графов (DFS и Disjoint Set)
  * `A` [Алгоритм Прима (Prim’s Algorithm)](src/algorithms/graph/prim) — поиск минимального остовного дерева (MST) для взвешенного неориентированного графа
  * `A` [Топологическая сортировка (Topological Sorting)](src/algorithms/graph/topological-sorting) — метод DFS
  * `A` [Точки сочленения (Articulation Points)](src/algorithms/graph/articulation-points) — алгоритм Тарьяна (на основе DFS)
  * `A` [Мосты (Bridges)](src/algorithms/graph/bridges) — алгоритм на основе DFS
  * `A` [Эйлеров путь и цикл (Eulerian Path and Eulerian Circuit)](src/algorithms/graph/eulerian-path) — алгоритм Флёри — проход по каждому ребру ровно один раз
  * `A` [Гамильтонов цикл (Hamiltonian Cycle)](src/algorithms/graph/hamiltonian-cycle) — посещение каждой вершины ровно один раз
  * `A` [Сильно связные компоненты (Strongly Connected Components)](src/algorithms/graph/strongly-connected-components) — алгоритм Косараджу
  * `A` [Задача о коммивояжёре (Travelling Salesman Problem)](src/algorithms/graph/travelling-salesman) — кратчайший путь, проходящий по всем городам и возвращающийся в исходный
* **Криптография**
  * `B` [Полиномиальный хеш (Polynomial Hash)](src/algorithms/cryptography/polynomial-hash) — скользящая хеш-функция на основе полинома
  * `B` [Шифр железнодорожной изгороди (Rail Fence Cipher)](src/algorithms/cryptography/rail-fence-cipher) — алгоритм перестановочного шифра
  * `B` [Шифр Цезаря (Caesar Cipher)](src/algorithms/cryptography/caesar-cipher) — простой шифр подстановки
  * `B` [Шифр Хилла (Hill Cipher)](src/algorithms/cryptography/hill-cipher) — шифр подстановки на основе линейной алгебры
* **Машинное обучение**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) — 7 простых JS-функций, иллюстрирующих, как машины могут учиться (прямое/обратное распространение)
  * `B` [k-NN](src/algorithms/ml/knn) — алгоритм классификации k-ближайших соседей
  * `B` [k-Means](src/algorithms/ml/k-means) — алгоритм кластеризации k-средних
* **Обработка изображений**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) — алгоритм масштабирования изображения с учётом содержимого
* **Статистика**
  * `B` [Взвешенный случайный выбор (Weighted Random)](src/algorithms/statistics/weighted-random) — выбор случайного элемента из списка с учётом весов
* **Эволюционные алгоритмы**
  * `A` [Генетический алгоритм (Genetic algorithm)](https://github.com/trekhleb/self-parking-car-evolution) — пример применения генетического алгоритма для обучения автомобилей с автоматической парковкой
* **Без категории**
  * `B` [Башни Ханоя (Tower of Hanoi)](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Поворот квадратной матрицы (Square Matrix Rotation)](src/algorithms/uncategorized/square-matrix-rotation) — in-place алгоритм
  * `B` [Игра с прыжками (Jump Game)](src/algorithms/uncategorized/jump-game) — примеры с возвратом, динамическим программированием (top-down и bottom-up) и жадным методом
  * `B` [Уникальные пути (Unique Paths)](src/algorithms/uncategorized/unique-paths) — примеры с возвратом, динамическим программированием и треугольником Паскаля
  * `B` [Дождевая терраса (Rain Terraces)](src/algorithms/uncategorized/rain-terraces) — задача о воде между стенками (динамическое программирование и наивный способ)
  * `B` [Рекурсивная лестница (Recursive Staircase)](src/algorithms/uncategorized/recursive-staircase) — подсчёт количества способов подняться наверх (4 решения)
  * `B` [Лучшее время для покупки/продажи акций (Best Time To Buy Sell Stocks)](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) — примеры с разделением и одним проходом
  * `B` [Правильные скобки (Valid Parentheses)](src/algorithms/stack/valid-parentheses) — проверка корректности скобок в строке (с использованием стека)
  * `A` [Задача N ферзей (N-Queens Problem)](src/algorithms/uncategorized/n-queens)
  * `A` [Тур коня (Knight's Tour)](src/algorithms/uncategorized/knight-tour)

### Алгоритмы по парадигмам

Парадигма алгоритма — это общий метод или подход, лежащий в основе проектирования класса алгоритмов. Это абстракция более высокого уровня, чем алгоритм, так же как алгоритм — абстракция выше компьютерной программы.

* **Полный перебор (Brute Force)** — рассмотрение всех вариантов и выбор наилучшего решения
  * `B` [Линейный поиск (Linear Search)](src/algorithms/search/linear-search)
  * `B` [Дождевая терраса (Rain Terraces)](src/algorithms/uncategorized/rain-terraces)
  * `B` [Рекурсивная лестница (Recursive Staircase)](src/algorithms/uncategorized/recursive-staircase)
  * `A` [Максимальная сумма подмассива (Maximum Subarray)](src/algorithms/sets/maximum-subarray)
  * `A` [Задача коммивояжёра (Travelling Salesman Problem)](src/algorithms/graph/travelling-salesman)
  * `A` [Дискретное преобразование Фурье (Discrete Fourier Transform)](src/algorithms/math/fourier-transform)
* **Жадный алгоритм (Greedy)** — выбор наилучшего варианта на текущем шаге без учёта будущего
  * `B` [Игра с прыжками (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `A` [Задача о рюкзаке с неограниченным количеством предметов (Unbound Knapsack Problem)](src/algorithms/sets/knapsack-problem)
  * `A` [Алгоритм Дейкстры (Dijkstra Algorithm)](src/algorithms/graph/dijkstra)
  * `A` [Алгоритм Прима (Prim’s Algorithm)](src/algorithms/graph/prim)
  * `A` [Алгоритм Крускала (Kruskal’s Algorithm)](src/algorithms/graph/kruskal)
* **Разделяй и властвуй (Divide and Conquer)** — разбиение задачи на подзадачи и их решение
  * `B` [Бинарный поиск (Binary Search)](src/algorithms/search/binary-search)
  * `B` [Башни Ханоя (Tower of Hanoi)](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Треугольник Паскаля (Pascal's Triangle)](src/algorithms/math/pascal-triangle)
  * `B` [Алгоритм Евклида (Euclidean Algorithm)](src/algorithms/math/euclidean-algorithm)
  * `B` [Сортировка слиянием (Merge Sort)](src/algorithms/sorting/merge-sort)
  * `B` [Быстрая сортировка (Quicksort)](src/algorithms/sorting/quick-sort)
  * `B` [Поиск в глубину в дереве (Tree Depth-First Search)](src/algorithms/tree/depth-first-search)
  * `B` [Поиск в глубину в графе (Graph Depth-First Search)](src/algorithms/graph/depth-first-search)
  * `B` [Матрицы (Matrices)](src/algorithms/math/matrix)
  * `B` [Игра с прыжками (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `B` [Быстрое возведение в степень (Fast Powering)](src/algorithms/math/fast-powering)
  * `B` [Лучшее время для покупки/продажи акций (Best Time To Buy Sell Stocks)](src/algorithms/uncategorized/best-time-to-buy-sell-stocks)
  * `A` [Перестановки (Permutations)](src/algorithms/sets/permutations)
  * `A` [Сочетания (Combinations)](src/algorithms/sets/combinations)
  * `A` [Максимальная сумма подмассива (Maximum Subarray)](src/algorithms/sets/maximum-subarray)
* **Динамическое программирование (Dynamic Programming)** — построение решения на основе ранее найденных подрешений
  * `B` [Число Фибоначчи (Fibonacci Number)](src/algorithms/math/fibonacci)
  * `B` [Игра с прыжками (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `B` [Уникальные пути (Unique Paths)](src/algorithms/uncategorized/unique-paths)
  * `B` [Дождевая терраса (Rain Terraces)](src/algorithms/uncategorized/rain-terraces)
  * `B` [Рекурсивная лестница (Recursive Staircase)](src/algorithms/uncategorized/recursive-staircase)
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving)
  * `A` [Расстояние Левенштейна (Levenshtein Distance)](src/algorithms/string/levenshtein-distance)
  * `A` [Наибольшая общая подпоследовательность (Longest Common Subsequence)](src/algorithms/sets/longest-common-subsequence)
  * `A` [Наибольшая общая подстрока (Longest Common Substring)](src/algorithms/string/longest-common-substring)
  * `A` [Наибольшая возрастающая подпоследовательность (Longest Increasing Subsequence)](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Кратчайшая общая суперпоследовательность (Shortest Common Supersequence)](src/algorithms/sets/shortest-common-supersequence)
  * `A` [Задача о рюкзаке 0/1 (0/1 Knapsack Problem)](src/algorithms/sets/knapsack-problem)
  * `A` [Разбиение числа на слагаемые (Integer Partition)](src/algorithms/math/integer-partition)
  * `A` [Максимальная сумма подмассива (Maximum Subarray)](src/algorithms/sets/maximum-subarray)
  * `A` [Алгоритм Беллмана–Форда (Bellman-Ford Algorithm)](src/algorithms/graph/bellman-ford)
  * `A` [Алгоритм Флойда–Уоршелла (Floyd-Warshall Algorithm)](src/algorithms/graph/floyd-warshall)
  * `A` [Сопоставление регулярных выражений (Regular Expression Matching)](src/algorithms/string/regular-expression-matching)
* **Backtracking** — аналогично полному перебору, пытается сгенерировать все возможные решения, но при генерации каждого следующего решения проверяет, удовлетворяет ли оно всем условиям, и только тогда продолжает генерацию. Иначе — возвращается (backtrack) и идёт по другому пути. Обычно используется обход в глубину по пространству состояний.
  * `B` [Игра с прыжками (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `B` [Уникальные пути (Unique Paths)](src/algorithms/uncategorized/unique-paths)
  * `B` [Множество всех подмножеств (Power Set)](src/algorithms/sets/power-set)
  * `A` [Гамильтонов цикл (Hamiltonian Cycle)](src/algorithms/graph/hamiltonian-cycle)
  * `A` [Задача N ферзей (N-Queens Problem)](src/algorithms/uncategorized/n-queens)
  * `A` [Тур коня (Knight's Tour)](src/algorithms/uncategorized/knight-tour)
  * `A` [Сумма сочетаний (Combination Sum)](src/algorithms/sets/combination-sum)
* **Branch & Bound** — запоминание самого дешёвого решения на каждом этапе поиска с возвратом (backtracking) и отбрасывание частичных решений, стоимость которых выше, чем уже найденное лучшее. Обычно используется комбинация BFS и DFS по дереву состояний.

## Как использовать этот репозиторий

**Установить все зависимости**

```
npm install
```

**Запуск ESLint**

Вы можете запустить его для проверки качества кода.

```
npm run lint
```

**Запустить все тесты**

```
npm test
```

**Запуск тестов по имени**

```
npm test -- 'LinkedList'
```

**Решение проблем**

Если возникают ошибки при lint или тестировании, попробуйте удалить папку `node_modules` и переустановить пакеты:

```
rm -rf ./node_modules
npm i
```

Также убедитесь, что вы используете правильную версию Node (`>=16`). Если вы используете [nvm](https://github.com/nvm-sh/nvm) для управления версиями Node, выполните `nvm use` из корня проекта, и будет выбрана нужная версия.

**Песочница (Playground)**

Вы можете поиграть со структурами данных и алгоритмами в файле `./src/playground/playground.js` и написать
тесты для него в `./src/playground/__test__/playground.test.js`.

Затем просто выполните следующую команду, чтобы проверить, работает ли ваш код песочницы как ожидается:

```
npm test -- 'playground'
```

## Полезная информация

### Ссылки

- [▶ Структуры данных и алгоритмы на YouTube](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 Эскизы структур данных](https://okso.app/showcase/data-structures)

### Нотация O-большое

*O-большое* используется для классификации алгоритмов по тому, как их время выполнения или требования к памяти растут с увеличением размера входных данных.
На графике ниже представлены наиболее часто встречающиеся порядки роста алгоритмов, выраженные в O-нотации.

![Big O graphs](./assets/big-o-graph.png)

Источник: [Big O Cheat Sheet](http://bigocheatsheet.com/).

Ниже приведён список некоторых наиболее используемых O-нотаций и сравнение их производительности на разных размерах входных данных.

| Нотация O-большое | Тип         | Операций на 10 элементов | Операций на 100 элементов | Операций на 1000 элементов  |
| ----------------- | ----------- | ------------------------ | ------------------------- | --------------------------- |
| **O(1)**          | Константная | 1                        | 1                         | 1                           |
| **O(log N)**      | Логарифмич. | 3                        | 6                         | 9                           |
| **O(N)**          | Линейная    | 10                       | 100                       | 1000                        |
| **O(N log N)**    | n log(n)    | 30                       | 600                       | 9000                        |
| **O(N^2)**        | Квадратич.  | 100                      | 10000                     | 1000000                     |
| **O(2^N)**        | Экспоненц.  | 1024                     | 1.26e+29                  | 1.07e+301                   |
| **O(N!)**         | Факториал   | 3628800                  | 9.3e+157                  | 4.02e+2567                  |

### Сложность операций для структур данных

| Структура данных         | Доступ   | Поиск    | Вставка | Удаление | Комментарии  |
| ------------------------ | :------: | :------: | :-----: | :------: | :----------- |
| **Массив (Array)**       | 1        | n        | n       | n        |              |
| **Стек (Stack)**         | n        | n        | 1       | 1        |              |
| **Очередь (Queue)**      | n        | n        | 1       | 1        |              |
| **Связанный список**     | n        | n        | 1       | n        |              |
| **Хеш-таблица**          | -        | n        | n       | n        | При идеальной хеш-функции операции O(1) |
| **Двоичное дерево поиска**| n        | n        | n       | n        | Для сбалансированного дерева — O(log(n)) |
| **B-дерево**             | log(n)   | log(n)   | log(n)  | log(n)   |              |
| **Красно-черное дерево** | log(n)   | log(n)   | log(n)  | log(n)   |              |
| **AVL-дерево**           | log(n)   | log(n)   | log(n)  | log(n)   |              |
| **Блум-фильтр**          | -        | 1        | 1       | -        | Возможны ложные срабатывания при поиске |

### Сложность алгоритмов сортировки массивов

| Название                | Лучшее          | Среднее           | Худшее            | Память    | Стабильность | Комментарии  |
| ----------------------- | :-------------: | :---------------: | :---------------: | :-------: | :----------: | :----------- |
| **Пузырьковая**         | n               | n<sup>2</sup>     | n<sup>2</sup>     | 1         | Да           |              |
| **Вставками**           | n               | n<sup>2</sup>     | n<sup>2</sup>     | 1         | Да           |              |
| **Выбором**             | n<sup>2</sup>   | n<sup>2</sup>     | n<sup>2</sup>     | 1         | Нет          |              |
| **Пирамидальная**       | n&nbsp;log(n)   | n&nbsp;log(n)     | n&nbsp;log(n)     | 1         | Нет          |              |
| **Слиянием**            | n&nbsp;log(n)   | n&nbsp;log(n)     | n&nbsp;log(n)     | n         | Да           |              |
| **Быстрая**             | n&nbsp;log(n)   | n&nbsp;log(n)     | n<sup>2</sup>     | log(n)    | Нет          | Обычно реализуется in-place с O(log(n)) памяти под стек |
| **Шелла**               | n&nbsp;log(n)   | зависит от шагов  | n&nbsp;(log(n))<sup>2</sup> | 1  | Нет          |              |
| **Подсчётом**           | n + r           | n + r             | n + r             | n + r     | Да           | r — макс. число в массиве |
| **Поразрядная**         | n * k           | n * k             | n * k             | n + k     | Да           | k — длина самого длинного ключа |

## Спонсоры проекта

> Вы можете поддержать этот проект через ❤️️ [GitHub](https://github.com/sponsors/trekhleb) или ❤️️ [Patreon](https://www.patreon.com/trekhleb).

[Люди, поддерживающие проект](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## Автор

[@trekhleb](https://trekhleb.dev)

Ещё [проекты](https://trekhleb.dev/projects/) и [статьи](https://trekhleb.dev/blog/) о JavaScript и алгоритмах на [trekhleb.dev](https://trekhleb.dev)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---