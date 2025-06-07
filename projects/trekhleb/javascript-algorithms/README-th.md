# อัลกอริทึมและโครงสร้างข้อมูลใน JavaScript

> 🇺🇦 ยูเครน [กำลังถูกโจมตี](https://war.ukraine.ua/) โดยกองทัพรัสเซีย พลเรือนกำลังถูกสังหาร พื้นที่ที่อยู่อาศัยกำลังถูกทิ้งระเบิด
> - ช่วยเหลือยูเครนผ่าน:
>   - [มูลนิธิการกุศล Serhiy Prytula](https://prytulafoundation.org/en/)
>   - [มูลนิธิการกุศล Come Back Alive](https://savelife.in.ua/en/donate-en/)
>   - [ธนาคารแห่งชาติยูเครน](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - ข้อมูลเพิ่มเติมที่ [war.ukraine.ua](https://war.ukraine.ua/) และ [MFA ของยูเครน](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

คลังนี้ประกอบด้วยตัวอย่างอัลกอริทึมและโครงสร้างข้อมูลยอดนิยมมากมายที่ใช้ JavaScript

แต่ละอัลกอริทึมและโครงสร้างข้อมูลจะมี README แยกของตนเอง พร้อมคำอธิบายและลิงก์สำหรับอ่านเพิ่มเติม (รวมถึงลิงก์วิดีโอ YouTube)

_อ่านหน้านี้ในภาษาอื่นๆ:_
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

*☝ โปรดทราบว่าโปรเจกต์นี้มีไว้เพื่อการเรียนรู้และการวิจัยเท่านั้น และ **ไม่** เหมาะสำหรับใช้งานในระบบ production*

## โครงสร้างข้อมูล (Data Structures)

โครงสร้างข้อมูลคือวิธีการจัดระเบียบและจัดเก็บข้อมูลในคอมพิวเตอร์เพื่อให้สามารถเข้าถึงและแก้ไขได้อย่างมีประสิทธิภาพ โดยเฉพาะอย่างยิ่ง โครงสร้างข้อมูลคือกลุ่มของค่าข้อมูล ความสัมพันธ์ระหว่างข้อมูลเหล่านั้น และฟังก์ชันหรือการดำเนินการที่สามารถใช้กับข้อมูลได้

โปรดจำไว้ว่าทุกโครงสร้างข้อมูลต่างก็มีข้อดีข้อเสียของตนเอง และคุณควรให้ความสำคัญกับเหตุผลที่เลือกใช้โครงสร้างข้อมูลหนึ่งมากกว่าวิธีการนำไปใช้จริง

`B` - เบื้องต้น, `A` - ขั้นสูง

* `B` [ลิงค์ลิสต์ (Linked List)](src/data-structures/linked-list)
* `B` [ดับเบิลลิงค์ลิสต์ (Doubly Linked List)](src/data-structures/doubly-linked-list)
* `B` [คิว (Queue)](src/data-structures/queue)
* `B` [สแตก (Stack)](src/data-structures/stack)
* `B` [ตารางแฮช (Hash Table)](src/data-structures/hash-table)
* `B` [ฮีป (Heap)](src/data-structures/heap) - มีทั้งแบบ max และ min heap
* `B` [Priority Queue](src/data-structures/priority-queue)
* `A` [Trie](src/data-structures/trie)
* `A` [ต้นไม้ (Tree)](src/data-structures/tree)
  * `A` [ต้นไม้ค้นหาแบบทวิภาค (Binary Search Tree)](src/data-structures/tree/binary-search-tree)
  * `A` [AVL Tree](src/data-structures/tree/avl-tree)
  * `A` [Red-Black Tree](src/data-structures/tree/red-black-tree)
  * `A` [Segment Tree](src/data-structures/tree/segment-tree) - ตัวอย่างการค้นหา min/max/sum ในช่วง
  * `A` [Fenwick Tree](src/data-structures/tree/fenwick-tree) (Binary Indexed Tree)
* `A` [กราฟ (Graph)](src/data-structures/graph) (ทั้งแบบมีทิศทางและไม่มีทิศทาง)
* `A` [Disjoint Set](src/data-structures/disjoint-set) - โครงสร้างข้อมูล union–find หรือ merge–find set
* `A` [Bloom Filter](src/data-structures/bloom-filter)
* `A` [LRU Cache](src/data-structures/lru-cache/) - แคชแบบ Least Recently Used (LRU)

## อัลกอริทึม (Algorithms)

อัลกอริทึมคือข้อกำหนดที่ชัดเจนในการแก้ปัญหาในกลุ่มหนึ่ง เป็นชุดของกฎที่กำหนดลำดับของการดำเนินการอย่างแม่นยำ

`B` - เบื้องต้น, `A` - ขั้นสูง

### อัลกอริทึมตามหัวข้อ

* **คณิตศาสตร์**
  * `B` [Bit Manipulation](src/algorithms/math/bits) - การตั้ง/อ่าน/อัปเดต/ลบ bit, คูณ/หารด้วยสอง, การแปลงค่าติดลบ ฯลฯ
  * `B` [Binary Floating Point](src/algorithms/math/binary-floating-point) - การแทนค่าเลขทศนิยมแบบฐานสอง
  * `B` [แฟกทอเรียล (Factorial)](src/algorithms/math/factorial)
  * `B` [เลขฟีโบนักชี (Fibonacci Number)](src/algorithms/math/fibonacci) - แบบคลาสสิกและแบบสูตรปิด
  * `B` [ตัวประกอบเฉพาะ (Prime Factors)](src/algorithms/math/prime-factors) - หาตัวประกอบเฉพาะและนับจำนวนโดยใช้ทฤษฎี Hardy-Ramanujan
  * `B` [การทดสอบจำนวนเฉพาะ (Primality Test)](src/algorithms/math/primality-test) (วิธี division)
  * `B` [อัลกอริทึมยุคลิด (Euclidean Algorithm)](src/algorithms/math/euclidean-algorithm) - คำนวณหาตัวหารร่วมมาก (GCD)
  * `B` [ห.ร.ม. (Least Common Multiple)](src/algorithms/math/least-common-multiple) (LCM)
  * `B` [Sieve of Eratosthenes](src/algorithms/math/sieve-of-eratosthenes) - หาจำนวนเฉพาะทั้งหมดจนถึงขีดจำกัดที่กำหนด
  * `B` [Is Power of Two](src/algorithms/math/is-power-of-two) - ตรวจสอบว่าค่าเป็นกำลังสองหรือไม่ (วิธี naive และ bitwise)
  * `B` [สามเหลี่ยมปาสกาล (Pascal's Triangle)](src/algorithms/math/pascal-triangle)
  * `B` [จำนวนเชิงซ้อน (Complex Number)](src/algorithms/math/complex-number) - จำนวนเชิงซ้อนและการดำเนินการพื้นฐาน
  * `B` [Radian & Degree](src/algorithms/math/radian) - แปลงระหว่างเรเดียนและองศา
  * `B` [Fast Powering](src/algorithms/math/fast-powering)
  * `B` [Horner's method](src/algorithms/math/horner-method) - การคำนวณพหุนาม
  * `B` [เมทริกซ์ (Matrices)](src/algorithms/math/matrix) - เมทริกซ์และการดำเนินการพื้นฐาน (คูณ, ทรานสโพส ฯลฯ)
  * `B` [Euclidean Distance](src/algorithms/math/euclidean-distance) - ระยะห่างระหว่างจุด/เวกเตอร์/เมทริกซ์
  * `A` [Integer Partition](src/algorithms/math/integer-partition)
  * `A` [Square Root](src/algorithms/math/square-root) - วิธีของนิวตัน
  * `A` [Liu Hui π Algorithm](src/algorithms/math/liu-hui) - ประมาณค่า π โดยใช้ N-gons
  * `A` [Discrete Fourier Transform](src/algorithms/math/fourier-transform) - แยกฟังก์ชันของเวลา (สัญญาณ) ออกเป็นความถี่ต่างๆ
* **เซต**
  * `B` [คาร์ทีเซียนโปรดักต์ (Cartesian Product)](src/algorithms/sets/cartesian-product) - ผลคูณของเซตหลายชุด
  * `B` [Fisher–Yates Shuffle](src/algorithms/sets/fisher-yates) - การสุ่มลำดับของลำดับจำกัด
  * `A` [Power Set](src/algorithms/sets/power-set) - เซตย่อยทั้งหมดของเซตหนึ่ง (แบบ bitwise, backtracking, cascading)
  * `A` [Permutations](src/algorithms/sets/permutations) (แบบมีและไม่มีการทำซ้ำ)
  * `A` [Combinations](src/algorithms/sets/combinations) (แบบมีและไม่มีการทำซ้ำ)
  * `A` [Longest Common Subsequence](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Longest Increasing Subsequence](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Shortest Common Supersequence](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [Knapsack Problem](src/algorithms/sets/knapsack-problem) - แบบ "0/1" และ "Unbound"
  * `A` [Maximum Subarray](src/algorithms/sets/maximum-subarray) - แบบ "Brute Force" และ "Dynamic Programming" (Kadane's)
  * `A` [Combination Sum](src/algorithms/sets/combination-sum) - หาทุกชุดที่รวมกันได้ผลรวมที่กำหนด
* **สตริง**
  * `B` [Hamming Distance](src/algorithms/string/hamming-distance) - จำนวนตำแหน่งที่สัญลักษณ์ต่างกัน
  * `B` [Palindrome](src/algorithms/string/palindrome) - ตรวจสอบว่าสตริงเหมือนเดิมเมื่อกลับด้านหรือไม่
  * `A` [Levenshtein Distance](src/algorithms/string/levenshtein-distance) - ระยะทางแก้ไขน้อยสุดระหว่างสองลำดับ
  * `A` [Knuth–Morris–Pratt Algorithm](src/algorithms/string/knuth-morris-pratt) (KMP) - ค้นหาซับสตริง (Pattern Matching)
  * `A` [Z Algorithm](src/algorithms/string/z-algorithm) - ค้นหาซับสตริง (Pattern Matching)
  * `A` [Rabin Karp Algorithm](src/algorithms/string/rabin-karp) - ค้นหาซับสตริง
  * `A` [Longest Common Substring](src/algorithms/string/longest-common-substring)
  * `A` [Regular Expression Matching](src/algorithms/string/regular-expression-matching)
* **ค้นหา**
  * `B` [Linear Search](src/algorithms/search/linear-search)
  * `B` [Jump Search](src/algorithms/search/jump-search) (หรือ Block Search) - ค้นหาในอาร์เรย์เรียงลำดับ
  * `B` [Binary Search](src/algorithms/search/binary-search) - ค้นหาในอาร์เรย์เรียงลำดับ
  * `B` [Interpolation Search](src/algorithms/search/interpolation-search) - ค้นหาในอาร์เรย์เรียงลำดับที่กระจายอย่างสม่ำเสมอ
* **เรียงลำดับ**
  * `B` [Bubble Sort](src/algorithms/sorting/bubble-sort)
  * `B` [Selection Sort](src/algorithms/sorting/selection-sort)
  * `B` [Insertion Sort](src/algorithms/sorting/insertion-sort)
  * `B` [Heap Sort](src/algorithms/sorting/heap-sort)
  * `B` [Merge Sort](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort) - แบบ in-place และ non-in-place
  * `B` [Shellsort](src/algorithms/sorting/shell-sort)
  * `B` [Counting Sort](src/algorithms/sorting/counting-sort)
  * `B` [Radix Sort](src/algorithms/sorting/radix-sort)
  * `B` [Bucket Sort](src/algorithms/sorting/bucket-sort)
* **ลิงค์ลิสต์**
  * `B` [Straight Traversal](src/algorithms/linked-list/traversal)
  * `B` [Reverse Traversal](src/algorithms/linked-list/reverse-traversal)
* **ต้นไม้**
  * `B` [ค้นหาเชิงลึก (Depth-First Search)](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [ค้นหาแบบกว้าง (Breadth-First Search)](src/algorithms/tree/breadth-first-search) (BFS)
* **กราฟ**
  * `B` [ค้นหาเชิงลึก (Depth-First Search)](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [ค้นหาแบบกว้าง (Breadth-First Search)](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [อัลกอริทึม Kruskal](src/algorithms/graph/kruskal) - หา Minimum Spanning Tree (MST) ในกราฟแบบไม่มีทิศทางถ่วงน้ำหนัก
  * `A` [อัลกอริทึม Dijkstra](src/algorithms/graph/dijkstra) - หาเส้นทางสั้นที่สุดไปยังทุก vertex จาก vertex เดียว
  * `A` [อัลกอริทึม Bellman-Ford](src/algorithms/graph/bellman-ford) - หาเส้นทางสั้นที่สุดไปยังทุก vertex จาก vertex เดียว
  * `A` [อัลกอริทึม Floyd-Warshall](src/algorithms/graph/floyd-warshall) - หาเส้นทางสั้นที่สุดระหว่างทุกคู่ vertex
  * `A` [ตรวจจับวงจร (Detect Cycle)](src/algorithms/graph/detect-cycle) - สำหรับกราฟทั้งแบบมีและไม่มีทิศทาง (DFS และ Disjoint Set)
  * `A` [อัลกอริทึม Prim](src/algorithms/graph/prim) - หา Minimum Spanning Tree (MST) ในกราฟแบบไม่มีทิศทางถ่วงน้ำหนัก
  * `A` [การเรียงลำดับแบบทอปอโลยี (Topological Sorting)](src/algorithms/graph/topological-sorting) - วิธี DFS
  * `A` [Articulation Points](src/algorithms/graph/articulation-points) - อัลกอริทึมของ Tarjan (DFS)
  * `A` [Bridges](src/algorithms/graph/bridges) - อัลกอริทึม DFS
  * `A` [Eulerian Path และ Eulerian Circuit](src/algorithms/graph/eulerian-path) - อัลกอริทึมของ Fleury - เยี่ยมชมทุก edge หนึ่งครั้ง
  * `A` [Hamiltonian Cycle](src/algorithms/graph/hamiltonian-cycle) - เยี่ยมชมทุก vertex หนึ่งครั้ง
  * `A` [Strongly Connected Components](src/algorithms/graph/strongly-connected-components) - อัลกอริทึมของ Kosaraju
  * `A` [Travelling Salesman Problem](src/algorithms/graph/travelling-salesman) - เส้นทางสั้นที่สุดที่ผ่านทุกเมืองและกลับสู่ต้นทาง
* **คริปโตกราฟี**
  * `B` [Polynomial Hash](src/algorithms/cryptography/polynomial-hash) - ฟังก์ชันแฮชแบบ rolling
  * `B` [Rail Fence Cipher](src/algorithms/cryptography/rail-fence-cipher) - อัลกอริทึมเข้ารหัสแบบสลับตำแหน่ง
  * `B` [Caesar Cipher](src/algorithms/cryptography/caesar-cipher) - การเข้ารหัสแบบแทนที่ตัวอักษรง่ายๆ
  * `B` [Hill Cipher](src/algorithms/cryptography/hill-cipher) - การเข้ารหัสแบบใช้พีชคณิตเชิงเส้น
* **Machine Learning**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - ฟังก์ชัน JS 7 ตัวอย่างที่แสดงวิธีที่เครื่องสามารถเรียนรู้ได้ (forward/backward propagation)
  * `B` [k-NN](src/algorithms/ml/knn) - อัลกอริทึมการจัดประเภท k-nearest neighbors
  * `B` [k-Means](src/algorithms/ml/k-means) - อัลกอริทึมการจัดกลุ่ม k-Means
* **การประมวลผลภาพ**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - อัลกอริทึมย่อขนาดภาพตามเนื้อหา
* **สถิติ**
  * `B` [Weighted Random](src/algorithms/statistics/weighted-random) - เลือกรายการแบบสุ่มตามน้ำหนัก
* **อัลกอริทึมวิวัฒนาการ**
  * `A` [อัลกอริทึมพันธุกรรม (Genetic algorithm)](https://github.com/trekhleb/self-parking-car-evolution) - ตัวอย่างการนำอัลกอริทึมพันธุกรรมไปฝึกสอนรถจอดอัตโนมัติ
* **ไม่เข้าหมวด**
  * `B` [หอคอยฮานอย (Tower of Hanoi)](src/algorithms/uncategorized/hanoi-tower)
  * `B` [หมุนเมทริกซ์จัตุรัส (Square Matrix Rotation)](src/algorithms/uncategorized/square-matrix-rotation) - อัลกอริทึมแบบ in-place
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game) - ตัวอย่าง backtracking, dynamic programming (top-down + bottom-up), greedy
  * `B` [Unique Paths](src/algorithms/uncategorized/unique-paths) - ตัวอย่าง backtracking, dynamic programming, Pascal's Triangle
  * `B` [Rain Terraces](src/algorithms/uncategorized/rain-terraces) - ปัญหาน้ำขัง (dynamic programming และ brute force)
  * `B` [Recursive Staircase](src/algorithms/uncategorized/recursive-staircase) - นับจำนวนวิธีไปถึงยอดบันได (4 วิธี)
  * `B` [ช่วงเวลาซื้อขายหุ้นดีที่สุด (Best Time To Buy Sell Stocks)](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - ตัวอย่าง divide and conquer และ one-pass
  * `B` [วงเล็บถูกต้อง (Valid Parentheses)](src/algorithms/stack/valid-parentheses) - ตรวจสอบว่าสตริงมีวงเล็บถูกต้องหรือไม่ (ใช้ stack)
  * `A` [N-Queens Problem](src/algorithms/uncategorized/n-queens)
  * `A` [Knight's Tour](src/algorithms/uncategorized/knight-tour)

### อัลกอริทึมตามรูปแบบ (Paradigm)

รูปแบบของอัลกอริทึม (Algorithmic paradigm) คือวิธีการทั่วไปหรือแนวทางที่อยู่เบื้องหลังการออกแบบอัลกอริทึมในกลุ่มหนึ่ง เป็นนามธรรมที่สูงกว่าความคิดของอัลกอริทึม เช่นเดียวกับที่อัลกอริทึมเป็นนามธรรมที่สูงกว่าคอมพิวเตอร์โปรแกรม

* **Brute Force** - ตรวจสอบความเป็นไปได้ทั้งหมดและเลือกทางออกที่ดีที่สุด
  * `B` [Linear Search](src/algorithms/search/linear-search)
  * `B` [Rain Terraces](src/algorithms/uncategorized/rain-terraces) - ปัญหาน้ำขัง
  * `B` [Recursive Staircase](src/algorithms/uncategorized/recursive-staircase) - นับจำนวนวิธีไปถึงยอดบันได
  * `A` [Maximum Subarray](src/algorithms/sets/maximum-subarray)
  * `A` [Travelling Salesman Problem](src/algorithms/graph/travelling-salesman) - เส้นทางสั้นที่สุดที่ผ่านทุกเมืองและกลับสู่ต้นทาง
  * `A` [Discrete Fourier Transform](src/algorithms/math/fourier-transform) - แยกฟังก์ชันของเวลา (สัญญาณ) ออกเป็นความถี่ต่างๆ
* **Greedy** - เลือกทางออกที่ดีที่สุดในขณะนั้นโดยไม่คำนึงถึงอนาคต
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `A` [Unbound Knapsack Problem](src/algorithms/sets/knapsack-problem)
  * `A` [Dijkstra Algorithm](src/algorithms/graph/dijkstra) - หาเส้นทางสั้นที่สุดไปยังทุก vertex
  * `A` [Prim’s Algorithm](src/algorithms/graph/prim) - หา Minimum Spanning Tree (MST) ในกราฟแบบไม่มีทิศทางถ่วงน้ำหนัก
  * `A` [Kruskal’s Algorithm](src/algorithms/graph/kruskal) - หา Minimum Spanning Tree (MST) ในกราฟแบบไม่มีทิศทางถ่วงน้ำหนัก
* **Divide and Conquer** - แบ่งปัญหาออกเป็นส่วนย่อยแล้วแก้แต่ละส่วน
  * `B` [Binary Search](src/algorithms/search/binary-search)
  * `B` [Tower of Hanoi](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Pascal's Triangle](src/algorithms/math/pascal-triangle)
  * `B` [Euclidean Algorithm](src/algorithms/math/euclidean-algorithm) - คำนวณหาตัวหารร่วมมาก (GCD)
  * `B` [Merge Sort](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort)
  * `B` [Tree Depth-First Search](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Graph Depth-First Search](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Matrices](src/algorithms/math/matrix) - สร้างและเดินเมทริกซ์รูปแบบต่างๆ
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Fast Powering](src/algorithms/math/fast-powering)
  * `B` [Best Time To Buy Sell Stocks](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - ตัวอย่าง divide and conquer และ one-pass
  * `A` [Permutations](src/algorithms/sets/permutations) (แบบมีและไม่มีการทำซ้ำ)
  * `A` [Combinations](src/algorithms/sets/combinations) (แบบมีและไม่มีการทำซ้ำ)
  * `A` [Maximum Subarray](src/algorithms/sets/maximum-subarray)
* **Dynamic Programming** - สร้างคำตอบโดยใช้ผลลัพธ์ย่อยที่เคยคำนวณไว้แล้ว
  * `B` [Fibonacci Number](src/algorithms/math/fibonacci)
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Unique Paths](src/algorithms/uncategorized/unique-paths)
  * `B` [Rain Terraces](src/algorithms/uncategorized/rain-terraces) - ปัญหาน้ำขัง
  * `B` [Recursive Staircase](src/algorithms/uncategorized/recursive-staircase) - นับจำนวนวิธีไปถึงยอดบันได
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - อัลกอริทึมย่อขนาดภาพตามเนื้อหา
  * `A` [Levenshtein Distance](src/algorithms/string/levenshtein-distance) - ระยะทางแก้ไขน้อยสุดระหว่างสองลำดับ
  * `A` [Longest Common Subsequence](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Longest Common Substring](src/algorithms/string/longest-common-substring)
  * `A` [Longest Increasing Subsequence](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Shortest Common Supersequence](src/algorithms/sets/shortest-common-supersequence)
  * `A` [0/1 Knapsack Problem](src/algorithms/sets/knapsack-problem)
  * `A` [Integer Partition](src/algorithms/math/integer-partition)
  * `A` [Maximum Subarray](src/algorithms/sets/maximum-subarray)
  * `A` [Bellman-Ford Algorithm](src/algorithms/graph/bellman-ford) - หาเส้นทางสั้นที่สุดไปยังทุก vertex
  * `A` [Floyd-Warshall Algorithm](src/algorithms/graph/floyd-warshall) - หาเส้นทางสั้นที่สุดระหว่างทุกคู่ vertex
  * `A` [Regular Expression Matching](src/algorithms/string/regular-expression-matching)
* **Backtracking** - คล้าย brute force โดยจะสร้างคำตอบที่เป็นไปได้ทั้งหมด แต่ทุกครั้งที่สร้างคำตอบใหม่จะตรวจสอบว่าตรงตามเงื่อนไขหรือไม่ ถ้าใช่จึงเดินหน้าต่อ มิฉะนั้นจะย้อนกลับ (backtrack) เพื่อหาคำตอบในเส้นทางอื่น ปกติใช้ DFS กับ state-space
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Unique Paths](src/algorithms/uncategorized/unique-paths)
  * `B` [Power Set](src/algorithms/sets/power-set) - เซตย่อยทั้งหมดของเซตหนึ่ง
  * `A` [Hamiltonian Cycle](src/algorithms/graph/hamiltonian-cycle) - เยี่ยมชมทุก vertex หนึ่งครั้ง
  * `A` [N-Queens Problem](src/algorithms/uncategorized/n-queens)
  * `A` [Knight's Tour](src/algorithms/uncategorized/knight-tour)
  * `A` [Combination Sum](src/algorithms/sets/combination-sum) - หาทุกชุดที่รวมกันได้ผลรวมที่กำหนด
* **Branch & Bound** - จดจำทางออกที่มีต้นทุนน้อยที่สุดในแต่ละขั้นของ backtracking และใช้ต้นทุนต่ำสุดนี้เป็นขอบเขตล่าง (lower bound) เพื่อคัดคำตอบย่อยที่ต้นทุนสูงกว่าออก ปกติจะใช้ BFS ผสม DFS กับ state-space tree

## วิธีใช้งานคลังนี้

**ติดตั้ง dependencies ทั้งหมด**

```
npm install
```

**รัน ESLint**

คุณอาจต้องการรันเพื่อตรวจสอบคุณภาพโค้ด

```
npm run lint
```

**รันเทสต์ทั้งหมด**

```
npm test
```

**รันเทสต์เฉพาะชื่อ**

```
npm test -- 'LinkedList'
```

**การแก้ปัญหาเบื้องต้น**

หาก linting หรือ testing ล้มเหลว ให้ลองลบโฟลเดอร์ `node_modules` และติดตั้ง npm packages ใหม่:

```
rm -rf ./node_modules
npm i
```

และตรวจสอบว่าคุณใช้เวอร์ชัน Node ที่ถูกต้อง (`>=16`) หากใช้ [nvm](https://github.com/nvm-sh/nvm) สำหรับจัดการ Node version สามารถรัน `nvm use` จาก root ของโปรเจกต์เพื่อให้เลือกเวอร์ชันที่ถูกต้องโดยอัตโนมัติ

**Playground**

คุณสามารถทดลองเล่นกับโครงสร้างข้อมูลและอัลกอริทึมในไฟล์ `./src/playground/playground.js` และเขียนเทสต์ใน `./src/playground/__test__/playground.test.js`

จากนั้นเพียงรันคำสั่งนี้เพื่อทดสอบว่าโค้ด playground ของคุณทำงานถูกต้องหรือไม่:

```
npm test -- 'playground'
```

## ข้อมูลที่เป็นประโยชน์

### แหล่งอ้างอิง

- [▶ Data Structures and Algorithms on YouTube](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 Data Structure Sketches](https://okso.app/showcase/data-structures)

### สัญลักษณ์ Big O (Big O Notation)

*Big O notation* ใช้สำหรับจัดประเภทอัลกอริทึมตามวิธีที่เวลาการทำงานหรือความต้องการหน่วยความจำเพิ่มขึ้นเมื่อขนาดข้อมูลขาเข้าเพิ่มขึ้น
ในแผนภูมิด้านล่าง คุณจะเห็นลำดับการเติบโตที่พบบ่อยที่สุดของอัลกอริทึมตาม Big O notation

![Big O graphs](./assets/big-o-graph.png)

ที่มา: [Big O Cheat Sheet](http://bigocheatsheet.com/)

ด้านล่างเป็นรายการ Big O ที่ใช้บ่อยที่สุด และเปรียบเทียบประสิทธิภาพกับขนาดข้อมูลขาเข้าต่างๆ

| Big O Notation | ประเภท         | การคำนวณสำหรับ 10 ตัว | การคำนวณสำหรับ 100 ตัว | การคำนวณสำหรับ 1000 ตัว  |
| -------------- | -------------- | --------------------- | ---------------------- | ------------------------- |
| **O(1)**       | คงที่          | 1                     | 1                      | 1                         |
| **O(log N)**   | ลอการิทึม      | 3                     | 6                      | 9                         |
| **O(N)**       | เส้นตรง        | 10                    | 100                    | 1000                      |
| **O(N log N)** | n log(n)       | 30                    | 600                    | 9000                      |
| **O(N^2)**     | กำลังสอง       | 100                   | 10000                  | 1000000                   |
| **O(2^N)**     | เอ็กซ์โพเนนเชียล | 1024                  | 1.26e+29               | 1.07e+301                 |
| **O(N!)**      | แฟกทอเรียล     | 3628800               | 9.3e+157               | 4.02e+2567                |

### ความซับซ้อนของการดำเนินการโครงสร้างข้อมูล

| โครงสร้างข้อมูล        | เข้าถึง   | ค้นหา    | แทรก      | ลบ        | หมายเหตุ  |
| ---------------------- | :-------: | :-------:| :--------:| :--------:| :-------- |
| **Array**              | 1         | n        | n         | n         |           |
| **Stack**              | n         | n        | 1         | 1         |           |
| **Queue**              | n         | n        | 1         | 1         |           |
| **Linked List**        | n         | n        | 1         | n         |           |
| **Hash Table**         | -         | n        | n         | n         | ถ้าใช้แฮชฟังก์ชันที่สมบูรณ์จะเป็น O(1) |
| **Binary Search Tree** | n         | n        | n         | n         | ถ้าเป็นต้นไม้สมดุลจะเป็น O(log(n)) |
| **B-Tree**             | log(n)    | log(n)   | log(n)    | log(n)    |           |
| **Red-Black Tree**     | log(n)    | log(n)   | log(n)    | log(n)    |           |
| **AVL Tree**           | log(n)    | log(n)   | log(n)    | log(n)    |           |
| **Bloom Filter**       | -         | 1        | 1         | -         | อาจมี false positive ในการค้นหา |

### ความซับซ้อนของอัลกอริทึมการเรียงลำดับอาร์เรย์

| ชื่อ                   | กรณีที่ดีที่สุด  | เฉลี่ย         | กรณีที่แย่ที่สุด   | หน่วยความจำ | เสถียร | หมายเหตุ  |
| ---------------------- | :-------------: | :------------: | :----------------: | :---------: | :----: | :-------- |
| **Bubble sort**        | n               | n<sup>2</sup>  | n<sup>2</sup>      | 1           | ใช่     |           |
| **Insertion sort**     | n               | n<sup>2</sup>  | n<sup>2</sup>      | 1           | ใช่     |           |
| **Selection sort**     | n<sup>2</sup>   | n<sup>2</sup>  | n<sup>2</sup>      | 1           | ไม่     |           |
| **Heap sort**          | n&nbsp;log(n)   | n&nbsp;log(n)  | n&nbsp;log(n)      | 1           | ไม่     |           |
| **Merge sort**         | n&nbsp;log(n)   | n&nbsp;log(n)  | n&nbsp;log(n)      | n           | ใช่     |           |
| **Quick sort**         | n&nbsp;log(n)   | n&nbsp;log(n)  | n<sup>2</sup>      | log(n)      | ไม่     | ปกติทำ in-place ใช้ stack O(log(n)) |
| **Shell sort**         | n&nbsp;log(n)   | ขึ้นกับ gap sequence | n&nbsp;(log(n))<sup>2</sup> | 1    | ไม่     |           |
| **Counting sort**      | n + r           | n + r          | n + r              | n + r       | ใช่     | r คือค่ามากที่สุดในอาร์เรย์ |
| **Radix sort**         | n * k           | n * k          | n * k              | n + k       | ใช่     | k คือความยาวของ key ยาวสุด |

## ผู้สนับสนุนโปรเจกต์

> คุณสามารถสนับสนุนโปรเจกต์นี้ผ่าน ❤️️ [GitHub](https://github.com/sponsors/trekhleb) หรือ ❤️️ [Patreon](https://www.patreon.com/trekhleb)

[ผู้สนับสนุนโปรเจกต์นี้](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## ผู้เขียน

[@trekhleb](https://trekhleb.dev)

โปรเจกต์และบทความเพิ่มเติมเกี่ยวกับ JavaScript และอัลกอริทึมที่ [trekhleb.dev](https://trekhleb.dev)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---