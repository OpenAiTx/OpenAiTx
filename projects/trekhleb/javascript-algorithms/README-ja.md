# JavaScript アルゴリズムとデータ構造

> 🇺🇦 ウクライナが[ロシア軍によって攻撃されています](https://war.ukraine.ua/)。民間人が殺害され、住宅地が爆撃されています。
> - ウクライナを支援するには:
>   - [Serhiy Prytula Charity Foundation](https://prytulafoundation.org/en/)
>   - [Come Back Alive Charity Foundation](https://savelife.in.ua/en/donate-en/)
>   - [National Bank of Ukraine](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - 詳細は [war.ukraine.ua](https://war.ukraine.ua/) および [ウクライナ外務省](https://twitter.com/MFA_Ukraine) へ

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

このリポジトリには、JavaScript で実装された多くの
有名なアルゴリズムとデータ構造の例が含まれています。

各アルゴリズムとデータ構造には、それぞれの説明と詳細な解説（YouTube動画へのリンクなどを含む）が記載された README が用意されています。

_他の言語で読む:_
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

*☝ このプロジェクトは学習および研究目的のためのものであり、**本番環境での使用を目的としていません**。*

## データ構造

データ構造とは、コンピュータ内でデータを効率的にアクセス・変更できるように整理・格納する特定の方法です。より正確には、データ構造はデータ値の集合、それらの関係、およびデータに適用できる関数や操作の集合です。

各データ構造にはそれぞれ利点と欠点があることに注意しましょう。実装方法よりも、なぜそのデータ構造を選択するのかに注目しましょう。

`B` - 初級, `A` - 上級

* `B` [単方向リスト（Linked List）](src/data-structures/linked-list)
* `B` [双方向リスト（Doubly Linked List）](src/data-structures/doubly-linked-list)
* `B` [キュー（Queue）](src/data-structures/queue)
* `B` [スタック（Stack）](src/data-structures/stack)
* `B` [ハッシュテーブル（Hash Table）](src/data-structures/hash-table)
* `B` [ヒープ（Heap）](src/data-structures/heap) - 最大ヒープ・最小ヒープ
* `B` [優先度付きキュー（Priority Queue）](src/data-structures/priority-queue)
* `A` [トライ木（Trie）](src/data-structures/trie)
* `A` [木構造（Tree）](src/data-structures/tree)
  * `A` [二分探索木（Binary Search Tree）](src/data-structures/tree/binary-search-tree)
  * `A` [AVL木（AVL Tree）](src/data-structures/tree/avl-tree)
  * `A` [赤黒木（Red-Black Tree）](src/data-structures/tree/red-black-tree)
  * `A` [セグメントツリー（Segment Tree）](src/data-structures/tree/segment-tree) - min/max/sum 範囲クエリ例
  * `A` [フェニック木（Fenwick Tree）](src/data-structures/tree/fenwick-tree)（Binary Indexed Tree）
* `A` [グラフ（Graph）](src/data-structures/graph)（有向・無向両方）
* `A` [互いに素集合（Disjoint Set）](src/data-structures/disjoint-set) - Union-Find（ユニオンファインド）構造
* `A` [ブルームフィルタ（Bloom Filter）](src/data-structures/bloom-filter)
* `A` [LRUキャッシュ（LRU Cache）](src/data-structures/lru-cache/) - 最も最近使われていないキャッシュ

## アルゴリズム

アルゴリズムとは、ある問題のクラスを解決するための明確な仕様です。
操作のシーケンスを正確に定義する規則の集合です。

`B` - 初級, `A` - 上級

### トピック別アルゴリズム

* **数学**
  * `B` [ビット演算（Bit Manipulation）](src/algorithms/math/bits) - ビットの設定/取得/更新/クリア、2倍・2分割、符号反転など
  * `B` [2進浮動小数点数（Binary Floating Point）](src/algorithms/math/binary-floating-point) - 浮動小数点数の2進表現
  * `B` [階乗（Factorial）](src/algorithms/math/factorial)
  * `B` [フィボナッチ数（Fibonacci Number）](src/algorithms/math/fibonacci) - 古典的・閉形式
  * `B` [素因数分解（Prime Factors）](src/algorithms/math/prime-factors) - Hardy-Ramanujanの定理による素因数の探索・カウント
  * `B` [素数判定（Primality Test）](src/algorithms/math/primality-test)（割り算法）
  * `B` [ユークリッドの互除法（Euclidean Algorithm）](src/algorithms/math/euclidean-algorithm) - 最大公約数(GCD)の計算
  * `B` [最小公倍数（Least Common Multiple）](src/algorithms/math/least-common-multiple)（LCM）
  * `B` [エラトステネスの篩（Sieve of Eratosthenes）](src/algorithms/math/sieve-of-eratosthenes) - 指定した上限までの素数全探索
  * `B` [2のべき乗判定（Is Power of Two）](src/algorithms/math/is-power-of-two) - 2のべき乗か判定（ナイーブ・ビット演算）
  * `B` [パスカルの三角形（Pascal's Triangle）](src/algorithms/math/pascal-triangle)
  * `B` [複素数（Complex Number）](src/algorithms/math/complex-number) - 複素数の基礎演算
  * `B` [ラジアンと度数法（Radian & Degree）](src/algorithms/math/radian) - ラジアン⇔度数法変換
  * `B` [高速累乗法（Fast Powering）](src/algorithms/math/fast-powering)
  * `B` [ホーナー法（Horner's method）](src/algorithms/math/horner-method) - 多項式評価
  * `B` [行列（Matrices）](src/algorithms/math/matrix) - 行列の基本操作（積、転置など）
  * `B` [ユークリッド距離（Euclidean Distance）](src/algorithms/math/euclidean-distance) - 2点/ベクトル/行列間の距離
  * `A` [整数分割（Integer Partition）](src/algorithms/math/integer-partition)
  * `A` [平方根（Square Root）](src/algorithms/math/square-root) - ニュートン法
  * `A` [劉徽の円周率アルゴリズム（Liu Hui π Algorithm）](src/algorithms/math/liu-hui) - N角形によるπの近似
  * `A` [離散フーリエ変換（Discrete Fourier Transform）](src/algorithms/math/fourier-transform) - 時間関数（信号）を周波数成分に分解
* **集合**
  * `B` [デカルト積（Cartesian Product）](src/algorithms/sets/cartesian-product) - 複数集合の直積
  * `B` [フィッシャー–イエーツシャッフル（Fisher–Yates Shuffle）](src/algorithms/sets/fisher-yates) - 有限列のランダム順列
  * `A` [冪集合（Power Set）](src/algorithms/sets/power-set) - 集合の全部分集合（ビット、バックトラッキング、カスケード）
  * `A` [順列（Permutations）](src/algorithms/sets/permutations)（重複あり・なし）
  * `A` [組み合わせ（Combinations）](src/algorithms/sets/combinations)（重複あり・なし）
  * `A` [最長共通部分列（Longest Common Subsequence: LCS）](src/algorithms/sets/longest-common-subsequence)
  * `A` [最長増加部分列（Longest Increasing Subsequence）](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [最短共通超列（Shortest Common Supersequence: SCS）](src/algorithms/sets/shortest-common-supersequence)
  * `A` [ナップサック問題（Knapsack Problem）](src/algorithms/sets/knapsack-problem) - 「0/1」「無制限」タイプ
  * `A` [最大部分配列（Maximum Subarray）](src/algorithms/sets/maximum-subarray) - 全探索・動的計画法（カデーン法）
  * `A` [組み合わせ和（Combination Sum）](src/algorithms/sets/combination-sum) - 指定和を作る全組み合わせ
* **文字列**
  * `B` [ハミング距離（Hamming Distance）](src/algorithms/string/hamming-distance) - 異なる位置の数
  * `B` [回文（Palindrome）](src/algorithms/string/palindrome) - 逆順でも同じか判定
  * `A` [レーベンシュタイン距離（Levenshtein Distance）](src/algorithms/string/levenshtein-distance) - 2列間の最小編集距離
  * `A` [クヌース–モリス–プラット法（KMP法）](src/algorithms/string/knuth-morris-pratt) - 部分文字列探索（パターンマッチング）
  * `A` [Zアルゴリズム（Z Algorithm）](src/algorithms/string/z-algorithm) - 部分文字列探索
  * `A` [ラビン・カープ法（Rabin Karp Algorithm）](src/algorithms/string/rabin-karp) - 部分文字列探索
  * `A` [最長共通部分文字列（Longest Common Substring）](src/algorithms/string/longest-common-substring)
  * `A` [正規表現マッチング（Regular Expression Matching）](src/algorithms/string/regular-expression-matching)
* **探索**
  * `B` [線形探索（Linear Search）](src/algorithms/search/linear-search)
  * `B` [ジャンプ探索（Jump Search）](src/algorithms/search/jump-search)（ブロック探索） - ソート済み配列
  * `B` [二分探索（Binary Search）](src/algorithms/search/binary-search) - ソート済み配列
  * `B` [補間探索（Interpolation Search）](src/algorithms/search/interpolation-search) - 一様分布ソート済み配列
* **ソート**
  * `B` [バブルソート（Bubble Sort）](src/algorithms/sorting/bubble-sort)
  * `B` [選択ソート（Selection Sort）](src/algorithms/sorting/selection-sort)
  * `B` [挿入ソート（Insertion Sort）](src/algorithms/sorting/insertion-sort)
  * `B` [ヒープソート（Heap Sort）](src/algorithms/sorting/heap-sort)
  * `B` [マージソート（Merge Sort）](src/algorithms/sorting/merge-sort)
  * `B` [クイックソート（Quicksort）](src/algorithms/sorting/quick-sort) - インプレース・非インプレース
  * `B` [シェルソート（Shellsort）](src/algorithms/sorting/shell-sort)
  * `B` [計数ソート（Counting Sort）](src/algorithms/sorting/counting-sort)
  * `B` [基数ソート（Radix Sort）](src/algorithms/sorting/radix-sort)
  * `B` [バケットソート（Bucket Sort）](src/algorithms/sorting/bucket-sort)
* **連結リスト**
  * `B` [順方向走査（Straight Traversal）](src/algorithms/linked-list/traversal)
  * `B` [逆方向走査（Reverse Traversal）](src/algorithms/linked-list/reverse-traversal)
* **木構造**
  * `B` [深さ優先探索（Depth-First Search: DFS）](src/algorithms/tree/depth-first-search)
  * `B` [幅優先探索（Breadth-First Search: BFS）](src/algorithms/tree/breadth-first-search)
* **グラフ**
  * `B` [深さ優先探索（Depth-First Search: DFS）](src/algorithms/graph/depth-first-search)
  * `B` [幅優先探索（Breadth-First Search: BFS）](src/algorithms/graph/breadth-first-search)
  * `B` [クラスカル法（Kruskal’s Algorithm）](src/algorithms/graph/kruskal) - 重み付き無向グラフの最小全域木（MST）
  * `A` [ダイクストラ法（Dijkstra Algorithm）](src/algorithms/graph/dijkstra) - 単一始点から全頂点への最短経路
  * `A` [ベルマン-フォード法（Bellman-Ford Algorithm）](src/algorithms/graph/bellman-ford) - 単一始点から全頂点への最短経路
  * `A` [フロイド-ワーシャル法（Floyd-Warshall Algorithm）](src/algorithms/graph/floyd-warshall) - 全頂点間最短経路
  * `A` [サイクル検出（Detect Cycle）](src/algorithms/graph/detect-cycle) - 有向/無向グラフ（DFS・Disjoint Set法）
  * `A` [プリム法（Prim’s Algorithm）](src/algorithms/graph/prim) - 重み付き無向グラフの最小全域木（MST）
  * `A` [トポロジカルソート（Topological Sorting）](src/algorithms/graph/topological-sorting) - DFS法
  * `A` [関節点（Articulation Points）](src/algorithms/graph/articulation-points) - Tarjanのアルゴリズム（DFSベース）
  * `A` [橋（Bridges）](src/algorithms/graph/bridges) - DFSアルゴリズム
  * `A` [オイラー路・オイラー閉路（Eulerian Path and Circuit）](src/algorithms/graph/eulerian-path) - Fleuryのアルゴリズム - 各辺を一度だけ通る
  * `A` [ハミルトン閉路（Hamiltonian Cycle）](src/algorithms/graph/hamiltonian-cycle) - 各頂点を一度だけ通る
  * `A` [強連結成分（Strongly Connected Components）](src/algorithms/graph/strongly-connected-components) - Kosarajuアルゴリズム
  * `A` [巡回セールスマン問題（Travelling Salesman Problem）](src/algorithms/graph/travelling-salesman) - 各都市を巡り出発点に戻る最短経路
* **暗号**
  * `B` [多項式ハッシュ（Polynomial Hash）](src/algorithms/cryptography/polynomial-hash) - 多項式に基づくローリングハッシュ
  * `B` [レールフェンス暗号（Rail Fence Cipher）](src/algorithms/cryptography/rail-fence-cipher) - 転置暗号
  * `B` [シーザー暗号（Caesar Cipher）](src/algorithms/cryptography/caesar-cipher) - 単純な置換暗号
  * `B` [ヒル暗号（Hill Cipher）](src/algorithms/cryptography/hill-cipher) - 線形代数に基づく置換暗号
* **機械学習**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 機械がどのように学習できるかを示す7つの単純なJS関数（順伝播/逆伝播）
  * `B` [k-NN](src/algorithms/ml/knn) - k近傍法（分類）
  * `B` [k平均法（k-Means）](src/algorithms/ml/k-means) - クラスタリング
* **画像処理**
  * `B` [シームカービング（Seam Carving）](src/algorithms/image-processing/seam-carving) - 内容認識画像リサイズ
* **統計**
  * `B` [重み付きランダム（Weighted Random）](src/algorithms/statistics/weighted-random) - 重みに基づくランダム選択
* **進化的アルゴリズム**
  * `A` [遺伝的アルゴリズム（Genetic algorithm）](https://github.com/trekhleb/self-parking-car-evolution) - 自動駐車車両学習への応用例
* **未分類**
  * `B` [ハノイの塔（Tower of Hanoi）](src/algorithms/uncategorized/hanoi-tower)
  * `B` [正方行列回転（Square Matrix Rotation）](src/algorithms/uncategorized/square-matrix-rotation) - インプレース
  * `B` [ジャンプゲーム（Jump Game）](src/algorithms/uncategorized/jump-game) - バックトラッキング、動的計画法（トップダウン・ボトムアップ）、貪欲法
  * `B` [一意な経路（Unique Paths）](src/algorithms/uncategorized/unique-paths) - バックトラッキング、動的計画法、パスカルの三角形
  * `B` [レインテラス（Rain Terraces）](src/algorithms/uncategorized/rain-terraces) - 雨水トラップ問題（DP・全探索）
  * `B` [再帰的階段（Recursive Staircase）](src/algorithms/uncategorized/recursive-staircase) - 頂上にたどり着く方法数（4つの解法）
  * `B` [株式売買の最適時期（Best Time To Buy Sell Stocks）](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - 分割統治法・一回走査
  * `B` [有効な括弧列（Valid Parentheses）](src/algorithms/stack/valid-parentheses) - スタックで有効性判定
  * `A` [Nクイーン問題（N-Queens Problem）](src/algorithms/uncategorized/n-queens)
  * `A` [ナイトツアー（Knight's Tour）](src/algorithms/uncategorized/knight-tour)

### パラダイム別アルゴリズム

アルゴリズムパラダイムとは、アルゴリズム設計における一般的な方法やアプローチです。アルゴリズムよりも高い抽象度を持ち、アルゴリズムがプログラムよりも高い抽象度を持つのと同様です。

* **全探索（Brute Force）** - 全ての可能性を調べて最良の解を選択
  * `B` [線形探索](src/algorithms/search/linear-search)
  * `B` [レインテラス](src/algorithms/uncategorized/rain-terraces)
  * `B` [再帰的階段](src/algorithms/uncategorized/recursive-staircase)
  * `A` [最大部分配列](src/algorithms/sets/maximum-subarray)
  * `A` [巡回セールスマン問題](src/algorithms/graph/travelling-salesman)
  * `A` [離散フーリエ変換](src/algorithms/math/fourier-transform)
* **貪欲法（Greedy）** - その時点で最良の選択を行い、将来は考慮しない
  * `B` [ジャンプゲーム](src/algorithms/uncategorized/jump-game)
  * `A` [無制限ナップサック問題](src/algorithms/sets/knapsack-problem)
  * `A` [ダイクストラ法](src/algorithms/graph/dijkstra)
  * `A` [プリム法](src/algorithms/graph/prim)
  * `A` [クラスカル法](src/algorithms/graph/kruskal)
* **分割統治法（Divide and Conquer）** - 問題を小さな部分に分割し、それぞれを解く
  * `B` [二分探索](src/algorithms/search/binary-search)
  * `B` [ハノイの塔](src/algorithms/uncategorized/hanoi-tower)
  * `B` [パスカルの三角形](src/algorithms/math/pascal-triangle)
  * `B` [ユークリッドの互除法](src/algorithms/math/euclidean-algorithm)
  * `B` [マージソート](src/algorithms/sorting/merge-sort)
  * `B` [クイックソート](src/algorithms/sorting/quick-sort)
  * `B` [木のDFS](src/algorithms/tree/depth-first-search)
  * `B` [グラフのDFS](src/algorithms/graph/depth-first-search)
  * `B` [行列](src/algorithms/math/matrix)
  * `B` [ジャンプゲーム](src/algorithms/uncategorized/jump-game)
  * `B` [高速累乗法](src/algorithms/math/fast-powering)
  * `B` [株式売買の最適時期](src/algorithms/uncategorized/best-time-to-buy-sell-stocks)
  * `A` [順列](src/algorithms/sets/permutations)
  * `A` [組み合わせ](src/algorithms/sets/combinations)
  * `A` [最大部分配列](src/algorithms/sets/maximum-subarray)
* **動的計画法（Dynamic Programming）** - 以前に求めた部分解を利用して全体解を構築
  * `B` [フィボナッチ数](src/algorithms/math/fibonacci)
  * `B` [ジャンプゲーム](src/algorithms/uncategorized/jump-game)
  * `B` [一意な経路](src/algorithms/uncategorized/unique-paths)
  * `B` [レインテラス](src/algorithms/uncategorized/rain-terraces)
  * `B` [再帰的階段](src/algorithms/uncategorized/recursive-staircase)
  * `B` [シームカービング](src/algorithms/image-processing/seam-carving)
  * `A` [レーベンシュタイン距離](src/algorithms/string/levenshtein-distance)
  * `A` [最長共通部分列](src/algorithms/sets/longest-common-subsequence)
  * `A` [最長共通部分文字列](src/algorithms/string/longest-common-substring)
  * `A` [最長増加部分列](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [最短共通超列](src/algorithms/sets/shortest-common-supersequence)
  * `A` [0/1ナップサック問題](src/algorithms/sets/knapsack-problem)
  * `A` [整数分割](src/algorithms/math/integer-partition)
  * `A` [最大部分配列](src/algorithms/sets/maximum-subarray)
  * `A` [ベルマン-フォード法](src/algorithms/graph/bellman-ford)
  * `A` [フロイド-ワーシャル法](src/algorithms/graph/floyd-warshall)
  * `A` [正規表現マッチング](src/algorithms/string/regular-expression-matching)
* **バックトラッキング（Backtracking）** - 全探索に似ているが、各解を生成するたびに条件を満たすかチェックし、満たさなければ元に戻って別のパスを探索（通常DFSで状態空間を走査）
  * `B` [ジャンプゲーム](src/algorithms/uncategorized/jump-game)
  * `B` [一意な経路](src/algorithms/uncategorized/unique-paths)
  * `B` [冪集合](src/algorithms/sets/power-set)
  * `A` [ハミルトン閉路](src/algorithms/graph/hamiltonian-cycle)
  * `A` [Nクイーン問題](src/algorithms/uncategorized/n-queens)
  * `A` [ナイトツアー](src/algorithms/uncategorized/knight-tour)
  * `A` [組み合わせ和](src/algorithms/sets/combination-sum)
* **分枝限定法（Branch & Bound）** - バックトラッキングの各段階で現在までに見つかった最小コスト解を記録し、それよりコストが大きい部分解を早期に棄却。通常BFSとDFSの組み合わせで状態空間木を走査

## このリポジトリの使い方

**すべての依存関係をインストール**

```
npm install
```

**ESLint を実行**

コード品質をチェックするために実行できます。

```
npm run lint
```

**全テストの実行**

```
npm test
```

**テスト名で絞って実行**

```
npm test -- 'LinkedList'
```

**トラブルシューティング**

lint や test で失敗する場合は、`node_modules` フォルダを削除して npm パッケージを再インストールしてください:

```
rm -rf ./node_modules
npm i
```

また、Node のバージョンが正しいこと（`>=16`）を確認してください。[nvm](https://github.com/nvm-sh/nvm) を使っている場合は、プロジェクトルートで `nvm use` を実行すれば正しいバージョンが適用されます。

**プレイグラウンド**

`./src/playground/playground.js` でデータ構造やアルゴリズムを試したり、
`./src/playground/__test__/playground.test.js` にテストを書くことができます。

その後、以下のコマンドでプレイグラウンドのコードが正しく動作するかテストできます:

```
npm test -- 'playground'
```

## 便利な情報

### 参考文献

- [▶ YouTubeで学ぶデータ構造とアルゴリズム](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 データ構造スケッチ](https://okso.app/showcase/data-structures)

### ビッグO記法

*ビッグO記法*は、アルゴリズムの実行時間やメモリ使用量が入力サイズ増大に伴いどのように成長するかを分類するために使われます。
以下のグラフは、ビッグO記法で記述されたアルゴリズムの一般的な成長オーダーです。

![Big O graphs](./assets/big-o-graph.png)

出典: [Big O Cheat Sheet](http://bigocheatsheet.com/)

下記は、よく使われるビッグO記法と異なる入力サイズに対する計算量の比較です。

| ビッグO記法      | タイプ        | 10要素の計算量      | 100要素の計算量      | 1000要素の計算量       |
| -------------- | ----------- | ------------------ | ------------------- | ---------------------- |
| **O(1)**       | 定数        | 1                  | 1                   | 1                      |
| **O(log N)**   | 対数        | 3                  | 6                   | 9                      |
| **O(N)**       | 線形        | 10                 | 100                 | 1000                   |
| **O(N log N)** | N log(n)    | 30                 | 600                 | 9000                   |
| **O(N^2)**     | 二次        | 100                | 10000               | 1000000                |
| **O(2^N)**     | 指数        | 1024               | 1.26e+29            | 1.07e+301              |
| **O(N!)**      | 階乗        | 3628800            | 9.3e+157            | 4.02e+2567             |

### データ構造の操作計算量

| データ構造                | アクセス    | 探索      | 挿入      | 削除      | コメント  |
| ----------------------- | :-------: | :-------: | :-------: | :-------: | :-------- |
| **配列（Array）**            | 1         | n         | n         | n         |           |
| **スタック（Stack）**        | n         | n         | 1         | 1         |           |
| **キュー（Queue）**          | n         | n         | 1         | 1         |           |
| **連結リスト（Linked List）**| n         | n         | 1         | n         |           |
| **ハッシュテーブル（Hash Table）**| -         | n         | n         | n         | 完全なハッシュ関数なら O(1) |
| **二分探索木（Binary Search Tree）**| n         | n         | n         | n         | 平衡木なら O(log(n)) |
| **B木（B-Tree）**            | log(n)    | log(n)    | log(n)    | log(n)    |           |
| **赤黒木（Red-Black Tree）** | log(n)    | log(n)    | log(n)    | log(n)    |           |
| **AVL木（AVL Tree）**        | log(n)    | log(n)    | log(n)    | log(n)    |           |
| **ブルームフィルタ（Bloom Filter）**| -         | 1         | 1         | -         | 検索時に偽陽性の可能性あり |

### 配列ソートアルゴリズムの計算量

| 名前                  | 最良             | 平均                | 最悪                | メモリ    | 安定性    | コメント  |
| --------------------- | :-------------: | :-----------------: | :-----------------: | :-------: | :-------: | :-------- |
| **バブルソート**       | n               | n<sup>2</sup>       | n<sup>2</sup>       | 1         | Yes       |           |
| **挿入ソート**         | n               | n<sup>2</sup>       | n<sup>2</sup>       | 1         | Yes       |           |
| **選択ソート**         | n<sup>2</sup>   | n<sup>2</sup>       | n<sup>2</sup>       | 1         | No        |           |
| **ヒープソート**       | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)       | 1         | No        |           |
| **マージソート**       | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)       | n         | Yes       |           |
| **クイックソート**     | n&nbsp;log(n)   | n&nbsp;log(n)       | n<sup>2</sup>       | log(n)    | No        | 通常インプレース（O(log(n))スタック） |
| **シェルソート**       | n&nbsp;log(n)   | ギャップ列依存       | n&nbsp;(log(n))<sup>2</sup>  | 1         | No         |           |
| **計数ソート**         | n + r           | n + r               | n + r               | n + r     | Yes       | r=配列内の最大値 |
| **基数ソート**         | n * k           | n * k               | n * k               | n + k     | Yes       | k=最大キー長 |

## プロジェクト支援者

> ❤️️ [GitHub](https://github.com/sponsors/trekhleb) または ❤️️ [Patreon](https://www.patreon.com/trekhleb) でこのプロジェクトを支援できます。

[このプロジェクトを支援してくださっている方々](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## 作者

[@trekhleb](https://trekhleb.dev)

他にも [プロジェクト](https://trekhleb.dev/projects/) や [記事](https://trekhleb.dev/blog/) があります。JavaScript やアルゴリズムについては [trekhleb.dev](https://trekhleb.dev) をご覧ください。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---