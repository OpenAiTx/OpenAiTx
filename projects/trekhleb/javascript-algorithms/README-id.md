# Algoritma dan Struktur Data JavaScript

> 🇺🇦 UKRAINA [SEDANG DISERANG](https://war.ukraine.ua/) OLEH TENTARA RUSIA. WARGA SIPIL TERBUNUH. DAERAH PERUMAHAN DI BOM.
> - Bantu Ukraina melalui:
>   - [Serhiy Prytula Charity Foundation](https://prytulafoundation.org/en/)
>   - [Come Back Alive Charity Foundation](https://savelife.in.ua/en/donate-en/)
>   - [National Bank of Ukraine](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - Info lebih lanjut di [war.ukraine.ua](https://war.ukraine.ua/) dan [MFA of Ukraine](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

Repositori ini berisi contoh struktur data dan algoritma populer yang berbasis JavaScript.

Setiap algoritma dan struktur data memiliki README terpisah
dengan penjelasan terkait dan tautan untuk membaca lebih lanjut (termasuk tautan
ke video YouTube).

_Baca ini dalam bahasa lain:_
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

*☝ Perhatikan bahwa proyek ini hanya untuk tujuan pembelajaran dan penelitian
saja, dan **tidak** dimaksudkan untuk digunakan di produksi.*

## Struktur Data

Struktur data adalah cara khusus untuk mengatur dan menyimpan data di dalam komputer sehingga dapat
diakses dan dimodifikasi secara efisien. Secara lebih tepat, struktur data adalah kumpulan nilai data,
hubungan antar data, serta fungsi atau operasi yang dapat diterapkan pada data tersebut.

Ingat bahwa setiap struktur data memiliki kelebihan dan kekurangan masing-masing. Anda perlu lebih memperhatikan alasan memilih struktur data tertentu daripada cara mengimplementasikannya.

`B` - Pemula, `A` - Lanjutan

* `B` [Linked List](src/data-structures/linked-list)
* `B` [Doubly Linked List](src/data-structures/doubly-linked-list)
* `B` [Queue](src/data-structures/queue)
* `B` [Stack](src/data-structures/stack)
* `B` [Hash Table](src/data-structures/hash-table)
* `B` [Heap](src/data-structures/heap) - versi max dan min heap
* `B` [Priority Queue](src/data-structures/priority-queue)
* `A` [Trie](src/data-structures/trie)
* `A` [Tree](src/data-structures/tree)
  * `A` [Binary Search Tree](src/data-structures/tree/binary-search-tree)
  * `A` [AVL Tree](src/data-structures/tree/avl-tree)
  * `A` [Red-Black Tree](src/data-structures/tree/red-black-tree)
  * `A` [Segment Tree](src/data-structures/tree/segment-tree) - dengan contoh kueri rentang min/maks/jumlah
  * `A` [Fenwick Tree](src/data-structures/tree/fenwick-tree) (Binary Indexed Tree)
* `A` [Graph](src/data-structures/graph) (berarah dan tidak berarah)
* `A` [Disjoint Set](src/data-structures/disjoint-set) - struktur data union–find atau merge–find set
* `A` [Bloom Filter](src/data-structures/bloom-filter)
* `A` [LRU Cache](src/data-structures/lru-cache/) - Least Recently Used (LRU) cache

## Algoritma

Algoritma adalah spesifikasi yang jelas tentang cara menyelesaikan suatu kelas masalah. Algoritma merupakan
kumpulan aturan yang secara tepat mendefinisikan urutan operasi.

`B` - Pemula, `A` - Lanjutan

### Algoritma Berdasarkan Topik

* **Matematika**
  * `B` [Bit Manipulation](src/algorithms/math/bits) - set/get/update/clear bit, perkalian/pembagian dua, membuat negatif, dll.
  * `B` [Binary Floating Point](src/algorithms/math/binary-floating-point) - representasi biner dari bilangan floating-point.
  * `B` [Faktorial](src/algorithms/math/factorial)
  * `B` [Bilangan Fibonacci](src/algorithms/math/fibonacci) - versi klasik dan bentuk tertutup
  * `B` [Faktor Prima](src/algorithms/math/prime-factors) - mencari faktor prima dan menghitungnya menggunakan teorema Hardy-Ramanujan
  * `B` [Tes Keprimaan](src/algorithms/math/primality-test) (metode pembagian percobaan)
  * `B` [Algoritma Euclidean](src/algorithms/math/euclidean-algorithm) - menghitung Greatest Common Divisor (GCD)
  * `B` [Least Common Multiple](src/algorithms/math/least-common-multiple) (LCM)
  * `B` [Sieve of Eratosthenes](src/algorithms/math/sieve-of-eratosthenes) - menemukan semua bilangan prima hingga batas tertentu
  * `B` [Is Power of Two](src/algorithms/math/is-power-of-two) - cek apakah bilangan merupakan pangkat dua (algoritma naif dan bitwise)
  * `B` [Segitiga Pascal](src/algorithms/math/pascal-triangle)
  * `B` [Bilangan Kompleks](src/algorithms/math/complex-number) - bilangan kompleks dan operasi dasar
  * `B` [Radian & Derajat](src/algorithms/math/radian) - konversi radian ke derajat dan sebaliknya
  * `B` [Fast Powering](src/algorithms/math/fast-powering)
  * `B` [Metode Horner](src/algorithms/math/horner-method) - evaluasi polinomial
  * `B` [Matriks](src/algorithms/math/matrix) - matriks dan operasi dasar matriks (perkalian, transposisi, dll.)
  * `B` [Jarak Euclidean](src/algorithms/math/euclidean-distance) - jarak antara dua titik/vektor/matriks
  * `A` [Integer Partition](src/algorithms/math/integer-partition)
  * `A` [Akar Kuadrat](src/algorithms/math/square-root) - metode Newton
  * `A` [Algoritma Liu Hui π](src/algorithms/math/liu-hui) - aproksimasi π berdasarkan N-gon
  * `A` [Discrete Fourier Transform](src/algorithms/math/fourier-transform) - menguraikan fungsi waktu (sinyal) menjadi frekuensi penyusunnya
* **Himpunan**
  * `B` [Produk Kartesius](src/algorithms/sets/cartesian-product) - hasil kali beberapa himpunan
  * `B` [Fisher–Yates Shuffle](src/algorithms/sets/fisher-yates) - permutasi acak dari urutan hingga
  * `A` [Power Set](src/algorithms/sets/power-set) - semua subset dari sebuah himpunan (bitwise, backtracking, dan cascading)
  * `A` [Permutasi](src/algorithms/sets/permutations) (dengan dan tanpa pengulangan)
  * `A` [Kombinasi](src/algorithms/sets/combinations) (dengan dan tanpa pengulangan)
  * `A` [Longest Common Subsequence](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Longest Increasing Subsequence](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Shortest Common Supersequence](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [Knapsack Problem](src/algorithms/sets/knapsack-problem) - versi "0/1" dan "Unbound"
  * `A` [Maximum Subarray](src/algorithms/sets/maximum-subarray) - versi "Brute Force" dan "Dynamic Programming" (Kadane)
  * `A` [Combination Sum](src/algorithms/sets/combination-sum) - cari semua kombinasi yang membentuk jumlah tertentu
* **String**
  * `B` [Hamming Distance](src/algorithms/string/hamming-distance) - jumlah posisi di mana simbol berbeda
  * `B` [Palindrome](src/algorithms/string/palindrome) - cek apakah string sama jika dibalik
  * `A` [Levenshtein Distance](src/algorithms/string/levenshtein-distance) - jarak edit minimum antara dua urutan
  * `A` [Algoritma Knuth–Morris–Pratt](src/algorithms/string/knuth-morris-pratt) (KMP) - pencarian substring (pencocokan pola)
  * `A` [Z Algorithm](src/algorithms/string/z-algorithm) - pencarian substring (pencocokan pola)
  * `A` [Algoritma Rabin Karp](src/algorithms/string/rabin-karp) - pencarian substring
  * `A` [Longest Common Substring](src/algorithms/string/longest-common-substring)
  * `A` [Regular Expression Matching](src/algorithms/string/regular-expression-matching)
* **Pencarian**
  * `B` [Linear Search](src/algorithms/search/linear-search)
  * `B` [Jump Search](src/algorithms/search/jump-search) (atau Block Search) - pencarian pada array terurut
  * `B` [Binary Search](src/algorithms/search/binary-search) - pencarian pada array terurut
  * `B` [Interpolation Search](src/algorithms/search/interpolation-search) - pencarian pada array terurut dan terdistribusi seragam
* **Pengurutan**
  * `B` [Bubble Sort](src/algorithms/sorting/bubble-sort)
  * `B` [Selection Sort](src/algorithms/sorting/selection-sort)
  * `B` [Insertion Sort](src/algorithms/sorting/insertion-sort)
  * `B` [Heap Sort](src/algorithms/sorting/heap-sort)
  * `B` [Merge Sort](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort) - implementasi in-place dan non-in-place
  * `B` [Shellsort](src/algorithms/sorting/shell-sort)
  * `B` [Counting Sort](src/algorithms/sorting/counting-sort)
  * `B` [Radix Sort](src/algorithms/sorting/radix-sort)
  * `B` [Bucket Sort](src/algorithms/sorting/bucket-sort)
* **Linked List**
  * `B` [Straight Traversal](src/algorithms/linked-list/traversal)
  * `B` [Reverse Traversal](src/algorithms/linked-list/reverse-traversal)
* **Pohon**
  * `B` [Depth-First Search](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Breadth-First Search](src/algorithms/tree/breadth-first-search) (BFS)
* **Graf**
  * `B` [Depth-First Search](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Breadth-First Search](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [Algoritma Kruskal](src/algorithms/graph/kruskal) - mencari Minimum Spanning Tree (MST) pada graf berbobot tak berarah
  * `A` [Algoritma Dijkstra](src/algorithms/graph/dijkstra) - mencari jalur terpendek ke semua simpul graf dari satu simpul
  * `A` [Algoritma Bellman-Ford](src/algorithms/graph/bellman-ford) - mencari jalur terpendek ke semua simpul graf dari satu simpul
  * `A` [Algoritma Floyd-Warshall](src/algorithms/graph/floyd-warshall) - mencari jalur terpendek antar semua pasangan simpul
  * `A` [Deteksi Siklus](src/algorithms/graph/detect-cycle) - pada graf berarah dan tak berarah (versi DFS dan Disjoint Set)
  * `A` [Algoritma Prim](src/algorithms/graph/prim) - mencari Minimum Spanning Tree (MST) pada graf berbobot tak berarah
  * `A` [Topological Sorting](src/algorithms/graph/topological-sorting) - metode DFS
  * `A` [Articulation Points](src/algorithms/graph/articulation-points) - algoritma Tarjan (berbasis DFS)
  * `A` [Bridges](src/algorithms/graph/bridges) - algoritma berbasis DFS
  * `A` [Eulerian Path dan Eulerian Circuit](src/algorithms/graph/eulerian-path) - algoritma Fleury - Kunjungi setiap edge tepat satu kali
  * `A` [Hamiltonian Cycle](src/algorithms/graph/hamiltonian-cycle) - Kunjungi setiap simpul tepat satu kali
  * `A` [Strongly Connected Components](src/algorithms/graph/strongly-connected-components) - algoritma Kosaraju
  * `A` [Travelling Salesman Problem](src/algorithms/graph/travelling-salesman) - rute terpendek yang mengunjungi setiap kota dan kembali ke kota asal
* **Kriptografi**
  * `B` [Polynomial Hash](src/algorithms/cryptography/polynomial-hash) - fungsi hash rolling berbasis polinomial
  * `B` [Rail Fence Cipher](src/algorithms/cryptography/rail-fence-cipher) - algoritma transposisi untuk mengenkripsi pesan
  * `B` [Caesar Cipher](src/algorithms/cryptography/caesar-cipher) - sandi substitusi sederhana
  * `B` [Hill Cipher](src/algorithms/cryptography/hill-cipher) - sandi substitusi berbasis aljabar linear
* **Machine Learning**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 7 fungsi JS sederhana yang menggambarkan bagaimana mesin dapat belajar (forward/backward propagation)
  * `B` [k-NN](src/algorithms/ml/knn) - algoritma klasifikasi k-nearest neighbors
  * `B` [k-Means](src/algorithms/ml/k-means) - algoritma clustering k-Means
* **Pengolahan Citra**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - algoritma resize gambar berbasis konten
* **Statistik**
  * `B` [Weighted Random](src/algorithms/statistics/weighted-random) - memilih item acak dari daftar berdasarkan bobot item
* **Algoritma Evolusioner**
  * `A` [Genetic algorithm](https://github.com/trekhleb/self-parking-car-evolution) - contoh penerapan algoritma genetika untuk melatih mobil parkir otomatis
* **Tidak Berkategori**
  * `B` [Menara Hanoi](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Rotasi Matriks Persegi](src/algorithms/uncategorized/square-matrix-rotation) - algoritma in-place
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game) - backtracking, dynamic programming (top-down + bottom-up), dan greedy
  * `B` [Unique Paths](src/algorithms/uncategorized/unique-paths) - backtracking, dynamic programming, dan Segitiga Pascal
  * `B` [Rain Terraces](src/algorithms/uncategorized/rain-terraces) - masalah penampungan air hujan (versi dynamic programming dan brute force)
  * `B` [Recursive Staircase](src/algorithms/uncategorized/recursive-staircase) - menghitung jumlah cara mencapai puncak (4 solusi)
  * `B` [Best Time To Buy Sell Stocks](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - contoh divide and conquer dan one-pass
  * `B` [Valid Parentheses](src/algorithms/stack/valid-parentheses) - cek apakah string memiliki tanda kurung yang valid (menggunakan stack)
  * `A` [N-Queens Problem](src/algorithms/uncategorized/n-queens)
  * `A` [Knight's Tour](src/algorithms/uncategorized/knight-tour)

### Algoritma Berdasarkan Paradigma

Paradigma algoritmik adalah metode atau pendekatan umum yang mendasari desain suatu kelas
algoritma. Paradigma ini merupakan abstraksi yang lebih tinggi dibandingkan algoritma, sebagaimana algoritma adalah
abstraksi yang lebih tinggi dibandingkan program komputer.

* **Brute Force** - memeriksa semua kemungkinan dan memilih solusi terbaik
  * `B` [Linear Search](src/algorithms/search/linear-search)
  * `B` [Rain Terraces](src/algorithms/uncategorized/rain-terraces) - masalah penampungan air hujan
  * `B` [Recursive Staircase](src/algorithms/uncategorized/recursive-staircase) - menghitung jumlah cara mencapai puncak
  * `A` [Maximum Subarray](src/algorithms/sets/maximum-subarray)
  * `A` [Travelling Salesman Problem](src/algorithms/graph/travelling-salesman) - rute terpendek yang mengunjungi setiap kota dan kembali ke kota asal
  * `A` [Discrete Fourier Transform](src/algorithms/math/fourier-transform) - menguraikan fungsi waktu (sinyal) menjadi frekuensi penyusunnya
* **Greedy** - memilih opsi terbaik saat ini tanpa mempertimbangkan masa depan
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `A` [Unbound Knapsack Problem](src/algorithms/sets/knapsack-problem)
  * `A` [Algoritma Dijkstra](src/algorithms/graph/dijkstra) - mencari jalur terpendek ke semua simpul graf
  * `A` [Algoritma Prim](src/algorithms/graph/prim) - mencari Minimum Spanning Tree (MST) pada graf berbobot tak berarah
  * `A` [Algoritma Kruskal](src/algorithms/graph/kruskal) - mencari Minimum Spanning Tree (MST) pada graf berbobot tak berarah
* **Divide and Conquer** - membagi masalah menjadi bagian-bagian kecil lalu menyelesaikannya
  * `B` [Binary Search](src/algorithms/search/binary-search)
  * `B` [Menara Hanoi](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Segitiga Pascal](src/algorithms/math/pascal-triangle)
  * `B` [Algoritma Euclidean](src/algorithms/math/euclidean-algorithm) - menghitung GCD
  * `B` [Merge Sort](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort)
  * `B` [Tree Depth-First Search](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Graph Depth-First Search](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Matriks](src/algorithms/math/matrix) - membuat dan menelusuri matriks berbagai bentuk
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Fast Powering](src/algorithms/math/fast-powering)
  * `B` [Best Time To Buy Sell Stocks](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - contoh divide and conquer dan one-pass
  * `A` [Permutasi](src/algorithms/sets/permutations) (dengan dan tanpa pengulangan)
  * `A` [Kombinasi](src/algorithms/sets/combinations) (dengan dan tanpa pengulangan)
  * `A` [Maximum Subarray](src/algorithms/sets/maximum-subarray)
* **Dynamic Programming** - membangun solusi dengan memanfaatkan solusi sub-masalah yang telah ditemukan
  * `B` [Bilangan Fibonacci](src/algorithms/math/fibonacci)
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Unique Paths](src/algorithms/uncategorized/unique-paths)
  * `B` [Rain Terraces](src/algorithms/uncategorized/rain-terraces) - masalah penampungan air hujan
  * `B` [Recursive Staircase](src/algorithms/uncategorized/recursive-staircase) - menghitung jumlah cara mencapai puncak
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - algoritma resize gambar berbasis konten
  * `A` [Levenshtein Distance](src/algorithms/string/levenshtein-distance) - jarak edit minimum antara dua urutan
  * `A` [Longest Common Subsequence](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Longest Common Substring](src/algorithms/string/longest-common-substring)
  * `A` [Longest Increasing Subsequence](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Shortest Common Supersequence](src/algorithms/sets/shortest-common-supersequence)
  * `A` [0/1 Knapsack Problem](src/algorithms/sets/knapsack-problem)
  * `A` [Integer Partition](src/algorithms/math/integer-partition)
  * `A` [Maximum Subarray](src/algorithms/sets/maximum-subarray)
  * `A` [Algoritma Bellman-Ford](src/algorithms/graph/bellman-ford) - mencari jalur terpendek ke semua simpul graf
  * `A` [Algoritma Floyd-Warshall](src/algorithms/graph/floyd-warshall) - mencari jalur terpendek antar semua pasangan simpul
  * `A` [Regular Expression Matching](src/algorithms/string/regular-expression-matching)
* **Backtracking** - mirip brute force, mencoba menghasilkan semua kemungkinan solusi, namun setiap kali solusi dibuat, diuji apakah memenuhi syarat dan hanya melanjutkan jika memenuhi. Jika tidak, mundur (backtrack) dan coba jalur lain. Biasanya menggunakan penelusuran DFS pada state-space.
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Unique Paths](src/algorithms/uncategorized/unique-paths)
  * `B` [Power Set](src/algorithms/sets/power-set) - semua subset dari sebuah himpunan
  * `A` [Hamiltonian Cycle](src/algorithms/graph/hamiltonian-cycle) - Kunjungi setiap simpul tepat satu kali
  * `A` [N-Queens Problem](src/algorithms/uncategorized/n-queens)
  * `A` [Knight's Tour](src/algorithms/uncategorized/knight-tour)
  * `A` [Combination Sum](src/algorithms/sets/combination-sum) - cari semua kombinasi yang membentuk jumlah tertentu
* **Branch & Bound** - mengingat solusi biaya terendah yang ditemukan di setiap tahap pencarian backtracking, dan menggunakan biaya tersebut sebagai batas bawah untuk membuang solusi parsial dengan biaya lebih tinggi dari solusi terbaik yang ditemukan. Biasanya menggunakan BFS dikombinasikan dengan DFS pada state-space tree.

## Cara Menggunakan Repositori Ini

**Pasang semua dependensi**

```
npm install
```

**Jalankan ESLint**

Anda dapat menjalankannya untuk memeriksa kualitas kode.

```
npm run lint
```

**Jalankan semua pengujian**

```
npm test
```

**Jalankan pengujian berdasarkan nama**

```
npm test -- 'LinkedList'
```

**Pemecahan Masalah**

Jika linting atau pengujian gagal, coba hapus folder `node_modules` dan instal ulang paket npm:

```
rm -rf ./node_modules
npm i
```

Juga, pastikan Anda menggunakan versi Node yang benar (`>=16`). Jika Anda menggunakan [nvm](https://github.com/nvm-sh/nvm) untuk manajemen versi Node, Anda dapat menjalankan `nvm use` dari root folder proyek dan versi yang benar akan digunakan.

**Playground**

Anda dapat mencoba struktur data dan algoritma di file `./src/playground/playground.js` dan menulis
tesnya di `./src/playground/__test__/playground.test.js`.

Kemudian cukup jalankan perintah berikut untuk menguji apakah kode playground Anda berjalan sesuai harapan:

```
npm test -- 'playground'
```

## Informasi Bermanfaat

### Referensi

- [▶ Data Structures and Algorithms on YouTube](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 Data Structure Sketches](https://okso.app/showcase/data-structures)

### Notasi Big O

*Notasi Big O* digunakan untuk mengklasifikasikan algoritma berdasarkan bagaimana waktu eksekusi atau kebutuhan memori meningkat seiring pertambahan ukuran input.
Pada grafik di bawah, Anda dapat melihat urutan pertumbuhan algoritma yang paling umum dalam notasi Big O.

![Big O graphs](./assets/big-o-graph.png)

Sumber: [Big O Cheat Sheet](http://bigocheatsheet.com/).

Di bawah ini adalah daftar beberapa notasi Big O yang paling sering digunakan beserta perbandingan performanya terhadap ukuran input yang berbeda.

| Notasi Big O | Tipe        | Komputasi untuk 10 elemen | Komputasi untuk 100 elemen | Komputasi untuk 1000 elemen  |
| -------------- | ----------- | ---------------------------- | ----------------------------- | ------------------------------- |
| **O(1)**       | Konstan     | 1                            | 1                             | 1                               |
| **O(log N)**   | Logaritmik  | 3                            | 6                             | 9                               |
| **O(N)**       | Linear      | 10                           | 100                           | 1000                            |
| **O(N log N)** | n log(n)    | 30                           | 600                           | 9000                            |
| **O(N^2)**     | Kuadratik   | 100                          | 10000                         | 1000000                         |
| **O(2^N)**     | Eksponensial| 1024                         | 1.26e+29                      | 1.07e+301                       |
| **O(N!)**      | Faktorial   | 3628800                      | 9.3e+157                      | 4.02e+2567                      |

### Kompleksitas Operasi Struktur Data

| Struktur Data          | Akses    | Cari     | Sisip    | Hapus    | Komentar  |
| ---------------------- | :------: | :------: | :------: | :------: | :-------- |
| **Array**              | 1        | n        | n        | n        |           |
| **Stack**              | n        | n        | 1        | 1        |           |
| **Queue**              | n        | n        | 1        | 1        |           |
| **Linked List**        | n        | n        | 1        | n        |           |
| **Hash Table**         | -        | n        | n        | n        | Jika fungsi hash sempurna, biaya O(1) |
| **Binary Search Tree** | n        | n        | n        | n        | Jika tree seimbang, biaya O(log(n)) |
| **B-Tree**             | log(n)   | log(n)   | log(n)   | log(n)   |           |
| **Red-Black Tree**     | log(n)   | log(n)   | log(n)   | log(n)   |           |
| **AVL Tree**           | log(n)   | log(n)   | log(n)   | log(n)   |           |
| **Bloom Filter**       | -        | 1        | 1        | -        | Hasil pencarian bisa false positive |

### Kompleksitas Algoritma Pengurutan Array

| Nama                   | Terbaik         | Rata-rata          | Terburuk            | Memori    | Stabil    | Komentar  |
| ---------------------- | :-------------: | :----------------: | :-----------------: | :-------: | :-------: | :-------- |
| **Bubble sort**        | n               | n<sup>2</sup>      | n<sup>2</sup>       | 1         | Ya        |           |
| **Insertion sort**     | n               | n<sup>2</sup>      | n<sup>2</sup>       | 1         | Ya        |           |
| **Selection sort**     | n<sup>2</sup>   | n<sup>2</sup>      | n<sup>2</sup>       | 1         | Tidak     |           |
| **Heap sort**          | n&nbsp;log(n)   | n&nbsp;log(n)      | n&nbsp;log(n)       | 1         | Tidak     |           |
| **Merge sort**         | n&nbsp;log(n)   | n&nbsp;log(n)      | n&nbsp;log(n)       | n         | Ya        |           |
| **Quick sort**         | n&nbsp;log(n)   | n&nbsp;log(n)      | n<sup>2</sup>       | log(n)    | Tidak     | Quicksort biasanya dilakukan in-place dengan ruang stack O(log(n)) |
| **Shell sort**         | n&nbsp;log(n)   | tergantung gap     | n&nbsp;(log(n))<sup>2</sup> | 1    | Tidak     |           |
| **Counting sort**      | n + r           | n + r              | n + r               | n + r     | Ya        | r - angka terbesar di array |
| **Radix sort**         | n * k           | n * k              | n * k               | n + k     | Ya        | k - panjang key terpanjang  |

## Pendukung Proyek

> Anda dapat mendukung proyek ini melalui ❤️️ [GitHub](https://github.com/sponsors/trekhleb) atau ❤️️ [Patreon](https://www.patreon.com/trekhleb).

[Orang-orang yang mendukung proyek ini](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## Penulis

[@trekhleb](https://trekhleb.dev)

Beberapa [proyek](https://trekhleb.dev/projects/) dan [artikel](https://trekhleb.dev/blog/) lainnya tentang JavaScript dan algoritma di [trekhleb.dev](https://trekhleb.dev)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---