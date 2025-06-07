# JavaScript 演算法與資料結構

> 🇺🇦 烏克蘭正遭受[俄羅斯軍隊攻擊](https://war.ukraine.ua/)。平民正在被殺害，住宅區正在被轟炸。
> - 透過以下方式協助烏克蘭：
>   - [Serhiy Prytula 慈善基金會](https://prytulafoundation.org/en/)
>   - [Come Back Alive 慈善基金會](https://savelife.in.ua/en/donate-en/)
>   - [烏克蘭國家銀行](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - 更多資訊參見 [war.ukraine.ua](https://war.ukraine.ua/) 及 [烏克蘭外交部](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

本儲存庫包含許多以 JavaScript 實現的熱門演算法與資料結構範例。

每個演算法與資料結構都有獨立的 README，包含相關說明與延伸閱讀連結（包含 YouTube 影片）。

_以其他語言閱讀：_
[_簡體中文_](README.zh-CN.md),
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

*☝ 注意：本專案僅供學習與研究之用，**不**建議用於生產環境。*

## 資料結構

資料結構是電腦中組織與儲存資料的一種特定方式，能讓資料高效地存取與修改。更精確地說，資料結構是一組資料值、它們之間的關聯，以及可對資料執行的函式或操作。

請記得，每種資料結構都有其取捨。你需要更關注為何選擇某個資料結構，而非僅僅是如何實作它。

`B` - 初學者，`A` - 進階

* `B` [鏈結串列 (Linked List)](src/data-structures/linked-list)
* `B` [雙向鏈結串列 (Doubly Linked List)](src/data-structures/doubly-linked-list)
* `B` [佇列 (Queue)](src/data-structures/queue)
* `B` [堆疊 (Stack)](src/data-structures/stack)
* `B` [雜湊表 (Hash Table)](src/data-structures/hash-table)
* `B` [堆積 (Heap)](src/data-structures/heap) - 最大堆與最小堆版本
* `B` [優先佇列 (Priority Queue)](src/data-structures/priority-queue)
* `A` [字典樹 (Trie)](src/data-structures/trie)
* `A` [樹 (Tree)](src/data-structures/tree)
  * `A` [二元搜尋樹 (Binary Search Tree)](src/data-structures/tree/binary-search-tree)
  * `A` [AVL 樹 (AVL Tree)](src/data-structures/tree/avl-tree)
  * `A` [紅黑樹 (Red-Black Tree)](src/data-structures/tree/red-black-tree)
  * `A` [線段樹 (Segment Tree)](src/data-structures/tree/segment-tree) - 含最小值/最大值/總和區間查詢範例
  * `A` [費尼克樹 (Fenwick Tree)](src/data-structures/tree/fenwick-tree)（二元索引樹）
* `A` [圖 (Graph)](src/data-structures/graph)（有向圖與無向圖）
* `A` [不相交集合 (Disjoint Set)](src/data-structures/disjoint-set) - 合併–查找資料結構
* `A` [布隆過濾器 (Bloom Filter)](src/data-structures/bloom-filter)
* `A` [LRU 快取 (LRU Cache)](src/data-structures/lru-cache/) - 最近最少使用快取

## 演算法

演算法是針對某一類問題的明確解法規範。它是一組明確定義操作順序的規則。

`B` - 初學者，`A` - 進階

### 依主題分類的演算法

* **數學**
  * `B` [位元運算 (Bit Manipulation)](src/algorithms/math/bits) - 設定/取得/更新/清除位元，乘除以二，取相反數等
  * `B` [二進位浮點數 (Binary Floating Point)](src/algorithms/math/binary-floating-point) - 浮點數的二進位表示
  * `B` [階乘 (Factorial)](src/algorithms/math/factorial)
  * `B` [費波那契數 (Fibonacci Number)](src/algorithms/math/fibonacci) - 經典與閉式解
  * `B` [質因數分解 (Prime Factors)](src/algorithms/math/prime-factors) - 利用 Hardy-Ramanujan 定理找質因數與計數
  * `B` [質數判斷 (Primality Test)](src/algorithms/math/primality-test)（試除法）
  * `B` [歐幾里得演算法 (Euclidean Algorithm)](src/algorithms/math/euclidean-algorithm) - 計算最大公因數 (GCD)
  * `B` [最小公倍數 (Least Common Multiple)](src/algorithms/math/least-common-multiple) (LCM)
  * `B` [埃拉托斯特尼篩法 (Sieve of Eratosthenes)](src/algorithms/math/sieve-of-eratosthenes) - 找出小於給定上限的所有質數
  * `B` [是否為 2 的冪 (Is Power of Two)](src/algorithms/math/is-power-of-two) - 判斷數字是否為 2 的冪（含天真與位元運算版本）
  * `B` [帕斯卡三角形 (Pascal's Triangle)](src/algorithms/math/pascal-triangle)
  * `B` [複數 (Complex Number)](src/algorithms/math/complex-number) - 複數及其基本運算
  * `B` [弧度與角度 (Radian & Degree)](src/algorithms/math/radian) - 弧度與角度互轉
  * `B` [快速冪 (Fast Powering)](src/algorithms/math/fast-powering)
  * `B` [霍納法則 (Horner's method)](src/algorithms/math/horner-method) - 多項式運算
  * `B` [矩陣 (Matrices)](src/algorithms/math/matrix) - 矩陣及基本運算（乘法、轉置等）
  * `B` [歐幾里得距離 (Euclidean Distance)](src/algorithms/math/euclidean-distance) - 計算兩點/向量/矩陣間距離
  * `A` [整數分割 (Integer Partition)](src/algorithms/math/integer-partition)
  * `A` [平方根 (Square Root)](src/algorithms/math/square-root) - 牛頓法
  * `A` [劉徽圓周率演算法 (Liu Hui π Algorithm)](src/algorithms/math/liu-hui) - 基於 N 邊形近似圓周率
  * `A` [離散傅立葉轉換 (Discrete Fourier Transform)](src/algorithms/math/fourier-transform) - 將時間函數分解成頻率
* **集合**
  * `B` [笛卡兒積 (Cartesian Product)](src/algorithms/sets/cartesian-product) - 多個集合的乘積
  * `B` [Fisher–Yates 洗牌 (Fisher–Yates Shuffle)](src/algorithms/sets/fisher-yates) - 有限序列的隨機排列
  * `A` [冪集 (Power Set)](src/algorithms/sets/power-set) - 集合的所有子集（位元、回溯、累加法）
  * `A` [排列 (Permutations)](src/algorithms/sets/permutations)（有重複與無重複）
  * `A` [組合 (Combinations)](src/algorithms/sets/combinations)（有重複與無重複）
  * `A` [最長公共子序列 (Longest Common Subsequence)](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [最長遞增子序列 (Longest Increasing Subsequence)](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [最短公共超序列 (Shortest Common Supersequence)](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [背包問題 (Knapsack Problem)](src/algorithms/sets/knapsack-problem) - 「0/1」與「無界」版本
  * `A` [最大子陣列 (Maximum Subarray)](src/algorithms/sets/maximum-subarray) - 「暴力法」與「動態規劃」(Kadane) 版本
  * `A` [組合總和 (Combination Sum)](src/algorithms/sets/combination-sum) - 找出所有組合達到特定和
* **字串**
  * `B` [海明距離 (Hamming Distance)](src/algorithms/string/hamming-distance) - 不同符號位置數
  * `B` [回文 (Palindrome)](src/algorithms/string/palindrome) - 判斷字串正反是否相同
  * `A` [萊文斯坦距離 (Levenshtein Distance)](src/algorithms/string/levenshtein-distance) - 兩序列最小編輯距離
  * `A` [KMP 演算法 (Knuth–Morris–Pratt Algorithm)](src/algorithms/string/knuth-morris-pratt) - 子字串搜尋（模式比對）
  * `A` [Z 演算法 (Z Algorithm)](src/algorithms/string/z-algorithm) - 子字串搜尋（模式比對）
  * `A` [Rabin Karp 演算法 (Rabin Karp Algorithm)](src/algorithms/string/rabin-karp) - 子字串搜尋
  * `A` [最長公共子字串 (Longest Common Substring)](src/algorithms/string/longest-common-substring)
  * `A` [正則表達式比對 (Regular Expression Matching)](src/algorithms/string/regular-expression-matching)
* **搜尋**
  * `B` [線性搜尋 (Linear Search)](src/algorithms/search/linear-search)
  * `B` [跳躍搜尋 (Jump Search)](src/algorithms/search/jump-search)（區塊搜尋）- 已排序陣列
  * `B` [二分搜尋 (Binary Search)](src/algorithms/search/binary-search) - 已排序陣列
  * `B` [插值搜尋 (Interpolation Search)](src/algorithms/search/interpolation-search) - 均勻分布的已排序陣列
* **排序**
  * `B` [泡沫排序 (Bubble Sort)](src/algorithms/sorting/bubble-sort)
  * `B` [選擇排序 (Selection Sort)](src/algorithms/sorting/selection-sort)
  * `B` [插入排序 (Insertion Sort)](src/algorithms/sorting/insertion-sort)
  * `B` [堆積排序 (Heap Sort)](src/algorithms/sorting/heap-sort)
  * `B` [合併排序 (Merge Sort)](src/algorithms/sorting/merge-sort)
  * `B` [快速排序 (Quicksort)](src/algorithms/sorting/quick-sort) - 原地與非原地實作
  * `B` [希爾排序 (Shellsort)](src/algorithms/sorting/shell-sort)
  * `B` [計數排序 (Counting Sort)](src/algorithms/sorting/counting-sort)
  * `B` [基數排序 (Radix Sort)](src/algorithms/sorting/radix-sort)
  * `B` [桶排序 (Bucket Sort)](src/algorithms/sorting/bucket-sort)
* **鏈結串列**
  * `B` [正向遍歷 (Straight Traversal)](src/algorithms/linked-list/traversal)
  * `B` [反向遍歷 (Reverse Traversal)](src/algorithms/linked-list/reverse-traversal)
* **樹**
  * `B` [深度優先搜尋 (Depth-First Search)](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [廣度優先搜尋 (Breadth-First Search)](src/algorithms/tree/breadth-first-search) (BFS)
* **圖**
  * `B` [深度優先搜尋 (Depth-First Search)](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [廣度優先搜尋 (Breadth-First Search)](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [Kruskal 演算法 (Kruskal’s Algorithm)](src/algorithms/graph/kruskal) - 求加權無向圖的最小生成樹 (MST)
  * `A` [Dijkstra 演算法 (Dijkstra Algorithm)](src/algorithms/graph/dijkstra) - 從單一頂點找所有頂點最短路徑
  * `A` [Bellman-Ford 演算法 (Bellman-Ford Algorithm)](src/algorithms/graph/bellman-ford) - 從單一頂點找所有頂點最短路徑
  * `A` [Floyd-Warshall 演算法 (Floyd-Warshall Algorithm)](src/algorithms/graph/floyd-warshall) - 找所有頂點對間最短路徑
  * `A` [偵測環 (Detect Cycle)](src/algorithms/graph/detect-cycle) - 有向與無向圖（DFS 與不相交集合實作）
  * `A` [Prim 演算法 (Prim’s Algorithm)](src/algorithms/graph/prim) - 求加權無向圖的最小生成樹 (MST)
  * `A` [拓撲排序 (Topological Sorting)](src/algorithms/graph/topological-sorting) - DFS 方法
  * `A` [割點 (Articulation Points)](src/algorithms/graph/articulation-points) - Tarjan 演算法 (基於 DFS)
  * `A` [橋 (Bridges)](src/algorithms/graph/bridges) - 基於 DFS 的演算法
  * `A` [歐拉路與歐拉迴路 (Eulerian Path and Eulerian Circuit)](src/algorithms/graph/eulerian-path) - Fleury 演算法 - 每條邊恰好走一次
  * `A` [哈密頓迴路 (Hamiltonian Cycle)](src/algorithms/graph/hamiltonian-cycle) - 每個頂點恰好走一次
  * `A` [強連通分量 (Strongly Connected Components)](src/algorithms/graph/strongly-connected-components) - Kosaraju 演算法
  * `A` [旅行推銷員問題 (Travelling Salesman Problem)](src/algorithms/graph/travelling-salesman) - 走遍所有城市並回到起點的最短路徑
* **密碼學**
  * `B` [多項式雜湊 (Polynomial Hash)](src/algorithms/cryptography/polynomial-hash) - 基於多項式的滾動雜湊
  * `B` [欄柵密碼 (Rail Fence Cipher)](src/algorithms/cryptography/rail-fence-cipher) - 置換加密演算法
  * `B` [凱薩密碼 (Caesar Cipher)](src/algorithms/cryptography/caesar-cipher) - 簡單的替換密碼
  * `B` [希爾密碼 (Hill Cipher)](src/algorithms/cryptography/hill-cipher) - 基於線性代數的替換密碼
* **機器學習**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 7 個簡單 JS 函式展示機器如何學習（前向/反向傳播）
  * `B` [k-最近鄰 (k-NN)](src/algorithms/ml/knn) - k-最近鄰分類演算法
  * `B` [k-平均 (k-Means)](src/algorithms/ml/k-means) - k-平均分群演算法
* **影像處理**
  * `B` [接縫雕刻 (Seam Carving)](src/algorithms/image-processing/seam-carving) - 內容感知影像縮放演算法
* **統計**
  * `B` [加權隨機 (Weighted Random)](src/algorithms/statistics/weighted-random) - 根據權重隨機選擇項目
* **演化演算法**
  * `A` [遺傳演算法 (Genetic algorithm)](https://github.com/trekhleb/self-parking-car-evolution) - 用於自動停車車輛訓練的遺傳演算法範例
* **未分類**
  * `B` [河內塔 (Tower of Hanoi)](src/algorithms/uncategorized/hanoi-tower)
  * `B` [正方形矩陣旋轉 (Square Matrix Rotation)](src/algorithms/uncategorized/square-matrix-rotation) - 原地演算法
  * `B` [跳躍遊戲 (Jump Game)](src/algorithms/uncategorized/jump-game) - 回溯法、動態規劃（自頂向下 + 自底向上）與貪心法
  * `B` [唯一路徑 (Unique Paths)](src/algorithms/uncategorized/unique-paths) - 回溯法、動態規劃與帕斯卡三角形
  * `B` [雨水收集 (Rain Terraces)](src/algorithms/uncategorized/rain-terraces) - 蓄水問題（動態規劃與暴力法）
  * `B` [遞迴樓梯 (Recursive Staircase)](src/algorithms/uncategorized/recursive-staircase) - 計算到達頂端的方法數（4 種解法）
  * `B` [股票買賣最佳時機 (Best Time To Buy Sell Stocks)](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - 分治法與一次遍歷解法
  * `B` [有效括號 (Valid Parentheses)](src/algorithms/stack/valid-parentheses) - 檢查字串括號是否有效（使用堆疊）
  * `A` [N 皇后問題 (N-Queens Problem)](src/algorithms/uncategorized/n-queens)
  * `A` [騎士巡遊 (Knight's Tour)](src/algorithms/uncategorized/knight-tour)

### 依範式分類的演算法

演算法範式是一種設計同類演算法的通用方法或思路。它比演算法抽象得更高，就像演算法比電腦程式抽象得更高一樣。

* **暴力法 (Brute Force)** - 列舉所有可能方案並選擇最佳解
  * `B` [線性搜尋 (Linear Search)](src/algorithms/search/linear-search)
  * `B` [雨水收集 (Rain Terraces)](src/algorithms/uncategorized/rain-terraces)
  * `B` [遞迴樓梯 (Recursive Staircase)](src/algorithms/uncategorized/recursive-staircase)
  * `A` [最大子陣列 (Maximum Subarray)](src/algorithms/sets/maximum-subarray)
  * `A` [旅行推銷員問題 (Travelling Salesman Problem)](src/algorithms/graph/travelling-salesman)
  * `A` [離散傅立葉轉換 (Discrete Fourier Transform)](src/algorithms/math/fourier-transform)
* **貪心法 (Greedy)** - 每一步都選擇當下最優選擇，不考慮未來
  * `B` [跳躍遊戲 (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `A` [無界背包問題 (Unbound Knapsack Problem)](src/algorithms/sets/knapsack-problem)
  * `A` [Dijkstra 演算法 (Dijkstra Algorithm)](src/algorithms/graph/dijkstra)
  * `A` [Prim 演算法 (Prim’s Algorithm)](src/algorithms/graph/prim)
  * `A` [Kruskal 演算法 (Kruskal’s Algorithm)](src/algorithms/graph/kruskal)
* **分治法 (Divide and Conquer)** - 將問題拆分為更小部分再分別解決
  * `B` [二分搜尋 (Binary Search)](src/algorithms/search/binary-search)
  * `B` [河內塔 (Tower of Hanoi)](src/algorithms/uncategorized/hanoi-tower)
  * `B` [帕斯卡三角形 (Pascal's Triangle)](src/algorithms/math/pascal-triangle)
  * `B` [歐幾里得演算法 (Euclidean Algorithm)](src/algorithms/math/euclidean-algorithm)
  * `B` [合併排序 (Merge Sort)](src/algorithms/sorting/merge-sort)
  * `B` [快速排序 (Quicksort)](src/algorithms/sorting/quick-sort)
  * `B` [樹的深度優先搜尋 (Tree Depth-First Search)](src/algorithms/tree/depth-first-search)
  * `B` [圖的深度優先搜尋 (Graph Depth-First Search)](src/algorithms/graph/depth-first-search)
  * `B` [矩陣 (Matrices)](src/algorithms/math/matrix) - 不同形狀矩陣的生成與遍歷
  * `B` [跳躍遊戲 (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `B` [快速冪 (Fast Powering)](src/algorithms/math/fast-powering)
  * `B` [股票買賣最佳時機 (Best Time To Buy Sell Stocks)](src/algorithms/uncategorized/best-time-to-buy-sell-stocks)
  * `A` [排列 (Permutations)](src/algorithms/sets/permutations)
  * `A` [組合 (Combinations)](src/algorithms/sets/combinations)
  * `A` [最大子陣列 (Maximum Subarray)](src/algorithms/sets/maximum-subarray)
* **動態規劃 (Dynamic Programming)** - 利用已知子問題的解構建整體解
  * `B` [費波那契數 (Fibonacci Number)](src/algorithms/math/fibonacci)
  * `B` [跳躍遊戲 (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `B` [唯一路徑 (Unique Paths)](src/algorithms/uncategorized/unique-paths)
  * `B` [雨水收集 (Rain Terraces)](src/algorithms/uncategorized/rain-terraces)
  * `B` [遞迴樓梯 (Recursive Staircase)](src/algorithms/uncategorized/recursive-staircase)
  * `B` [接縫雕刻 (Seam Carving)](src/algorithms/image-processing/seam-carving)
  * `A` [萊文斯坦距離 (Levenshtein Distance)](src/algorithms/string/levenshtein-distance)
  * `A` [最長公共子序列 (Longest Common Subsequence)](src/algorithms/sets/longest-common-subsequence)
  * `A` [最長公共子字串 (Longest Common Substring)](src/algorithms/string/longest-common-substring)
  * `A` [最長遞增子序列 (Longest Increasing Subsequence)](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [最短公共超序列 (Shortest Common Supersequence)](src/algorithms/sets/shortest-common-supersequence)
  * `A` [0/1 背包問題 (0/1 Knapsack Problem)](src/algorithms/sets/knapsack-problem)
  * `A` [整數分割 (Integer Partition)](src/algorithms/math/integer-partition)
  * `A` [最大子陣列 (Maximum Subarray)](src/algorithms/sets/maximum-subarray)
  * `A` [Bellman-Ford 演算法 (Bellman-Ford Algorithm)](src/algorithms/graph/bellman-ford)
  * `A` [Floyd-Warshall 演算法 (Floyd-Warshall Algorithm)](src/algorithms/graph/floyd-warshall)
  * `A` [正則表達式比對 (Regular Expression Matching)](src/algorithms/string/regular-expression-matching)
* **回溯法 (Backtracking)** - 類似暴力法，嘗試生成所有可能解，每次生成新解時檢查是否滿足所有條件，否則回退並嘗試其他路徑。通常採用狀態空間的 DFS 遍歷。
  * `B` [跳躍遊戲 (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `B` [唯一路徑 (Unique Paths)](src/algorithms/uncategorized/unique-paths)
  * `B` [冪集 (Power Set)](src/algorithms/sets/power-set)
  * `A` [哈密頓迴路 (Hamiltonian Cycle)](src/algorithms/graph/hamiltonian-cycle)
  * `A` [N 皇后問題 (N-Queens Problem)](src/algorithms/uncategorized/n-queens)
  * `A` [騎士巡遊 (Knight's Tour)](src/algorithms/uncategorized/knight-tour)
  * `A` [組合總和 (Combination Sum)](src/algorithms/sets/combination-sum)
* **分枝限界法 (Branch & Bound)** - 在回溯搜尋的每一階段記錄已找到的最低成本解，並利用最低成本作為下界來剪枝未來不可能更優的部分解。通常結合 BFS 與 DFS 遍歷狀態空間樹。

## 如何使用本儲存庫

**安裝所有依賴套件**

```
npm install
```

**執行 ESLint**

可用來檢查程式碼品質。

```
npm run lint
```

**執行所有測試**

```
npm test
```

**依名稱執行測試**

```
npm test -- 'LinkedList'
```

**疑難排解**

如果 lint 或測試出現失敗，請嘗試刪除 `node_modules` 資料夾並重新安裝 npm 套件：

```
rm -rf ./node_modules
npm i
```

另外，請確認你的 Node 版本正確（`>=16`）。如果你使用 [nvm](https://github.com/nvm-sh/nvm) 管理 Node 版本，可以在專案根目錄執行 `nvm use`，將自動選用正確版本。

**Playground**

你可以在 `./src/playground/playground.js` 檔案中練習資料結構與演算法，並在 `./src/playground/__test__/playground.test.js` 編寫測試。

接著執行以下指令，測試你的 Playground 程式是否如預期運作：

```
npm test -- 'playground'
```

## 實用資訊

### 參考資料

- [▶ YouTube 上的資料結構與演算法教學](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 資料結構圖解](https://okso.app/showcase/data-structures)

### 大 O 表示法

*大 O 表示法* 用於分類演算法，表示其執行時間或空間需求隨輸入規模的成長情形。
下圖展示常見的演算法成長階數（Big O）：

![Big O graphs](./assets/big-o-graph.png)

來源: [Big O Cheat Sheet](http://bigocheatsheet.com/)

以下是常見的大 O 表示與不同輸入規模下的效能比較：

| Big O 表示法 | 類型        | 10 個元素計算次數 | 100 個元素計算次數 | 1000 個元素計算次數  |
| -------------- | ----------- | ------------------ | ------------------- | --------------------- |
| **O(1)**       | 常數        | 1                  | 1                   | 1                     |
| **O(log N)**   | 對數        | 3                  | 6                   | 9                     |
| **O(N)**       | 線性        | 10                 | 100                 | 1000                  |
| **O(N log N)** | n log(n)    | 30                 | 600                 | 9000                  |
| **O(N^2)**     | 平方        | 100                | 10000               | 1000000               |
| **O(2^N)**     | 指數        | 1024               | 1.26e+29            | 1.07e+301             |
| **O(N!)**      | 階乘        | 3628800            | 9.3e+157            | 4.02e+2567            |

### 資料結構操作複雜度

| 資料結構               | 存取    | 搜尋    | 插入    | 刪除    | 備註  |
| ---------------------- | :-----: | :-----: | :-----: | :-----: | :---- |
| **陣列 (Array)**       | 1       | n       | n       | n       |       |
| **堆疊 (Stack)**       | n       | n       | 1       | 1       |       |
| **佇列 (Queue)**       | n       | n       | 1       | 1       |       |
| **鏈結串列 (Linked List)** | n    | n       | 1       | n       |       |
| **雜湊表 (Hash Table)** | -      | n       | n       | n       | 若雜湊函式完美則為 O(1) |
| **二元搜尋樹 (Binary Search Tree)** | n | n | n | n | 若平衡則為 O(log(n)) |
| **B 樹 (B-Tree)**      | log(n)  | log(n)  | log(n)  | log(n)  |       |
| **紅黑樹 (Red-Black Tree)** | log(n) | log(n) | log(n) | log(n) |   |
| **AVL 樹 (AVL Tree)**  | log(n)  | log(n)  | log(n)  | log(n)  |       |
| **布隆過濾器 (Bloom Filter)** | - | 1 | 1 | - | 搜尋時可能有假陽性 |

### 陣列排序演算法複雜度

| 名稱                  | 最佳            | 平均             | 最差               | 記憶體    | 穩定    | 備註  |
| --------------------- | :-------------: | :--------------: | :----------------: | :-------: | :-----: | :---- |
| **泡沫排序**          | n               | n<sup>2</sup>    | n<sup>2</sup>      | 1         | 是      |       |
| **插入排序**          | n               | n<sup>2</sup>    | n<sup>2</sup>      | 1         | 是      |       |
| **選擇排序**          | n<sup>2</sup>   | n<sup>2</sup>    | n<sup>2</sup>      | 1         | 否      |       |
| **堆積排序**          | n&nbsp;log(n)   | n&nbsp;log(n)    | n&nbsp;log(n)      | 1         | 否      |       |
| **合併排序**          | n&nbsp;log(n)   | n&nbsp;log(n)    | n&nbsp;log(n)      | n         | 是      |       |
| **快速排序**          | n&nbsp;log(n)   | n&nbsp;log(n)    | n<sup>2</sup>      | log(n)    | 否      | 通常為原地排序，堆疊空間 O(log(n)) |
| **希爾排序**          | n&nbsp;log(n)   | 依間隔序列而異   | n&nbsp;(log(n))<sup>2</sup>  | 1      | 否      |       |
| **計數排序**          | n + r           | n + r            | n + r               | n + r     | 是      | r 為陣列最大數 |
| **基數排序**          | n * k           | n * k            | n * k               | n + k     | 是      | k 為最長鍵長度 |

## 專案贊助者

> 你可以透過 ❤️️ [GitHub](https://github.com/sponsors/trekhleb) 或 ❤️️ [Patreon](https://www.patreon.com/trekhleb) 支持本專案。

[贊助本專案的人](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## 作者

[@trekhleb](https://trekhleb.dev)

更多有關 JavaScript 與演算法的[專案](https://trekhleb.dev/projects/)和[文章](https://trekhleb.dev/blog/)，請參見 [trekhleb.dev](https://trekhleb.dev)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---