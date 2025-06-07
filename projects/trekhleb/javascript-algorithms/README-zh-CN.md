# JavaScript 算法与数据结构

> 🇺🇦 乌克兰正在被[俄罗斯军队攻击](https://war.ukraine.ua/)。平民正在被杀害，居民区正在被轰炸。
> - 支持乌克兰：
>   - [Serhiy Prytula 慈善基金会](https://prytulafoundation.org/en/)
>   - [Come Back Alive 慈善基金会](https://savelife.in.ua/en/donate-en/)
>   - [乌克兰国家银行](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - 更多信息见 [war.ukraine.ua](https://war.ukraine.ua/) 和 [乌克兰外交部](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

本仓库包含了许多流行算法和数据结构的 JavaScript 实现示例。

每个算法和数据结构都有其独立的 README 文件，包含相关解释及进一步阅读的链接（包括 YouTube 视频）。

_其它语言版本：_
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

*☝ 注意：本项目仅用于学习与研究目的，**不**建议用于生产环境。*

## 数据结构

数据结构是一种在计算机中组织和存储数据的特定方式，以便高效地访问和修改。更准确地说，数据结构是一组数据值、它们之间的关系以及可对数据进行的操作和函数的集合。

请记住，每种数据结构都有其权衡。与其关注如何实现，不如更多关注为什么选择某种数据结构。

`B` - 入门, `A` - 进阶

* `B` [链表](src/data-structures/linked-list)
* `B` [双向链表](src/data-structures/doubly-linked-list)
* `B` [队列](src/data-structures/queue)
* `B` [栈](src/data-structures/stack)
* `B` [哈希表](src/data-structures/hash-table)
* `B` [堆](src/data-structures/heap) - 最大堆和最小堆
* `B` [优先队列](src/data-structures/priority-queue)
* `A` [字典树(Trie)](src/data-structures/trie)
* `A` [树](src/data-structures/tree)
  * `A` [二叉搜索树](src/data-structures/tree/binary-search-tree)
  * `A` [AVL 树](src/data-structures/tree/avl-tree)
  * `A` [红黑树](src/data-structures/tree/red-black-tree)
  * `A` [线段树](src/data-structures/tree/segment-tree) - 包含最小/最大/区间求和等查询示例
  * `A` [树状数组](src/data-structures/tree/fenwick-tree)（二进制索引树）
* `A` [图](src/data-structures/graph)（有向图与无向图）
* `A` [并查集](src/data-structures/disjoint-set) - 并查集结构/合并查找集
* `A` [布隆过滤器](src/data-structures/bloom-filter)
* `A` [LRU 缓存](src/data-structures/lru-cache/) - 最近最少使用（LRU）缓存

## 算法

算法是一种明确无歧义的规范，用于解决一类问题。它是一组精确定义操作顺序的规则。

`B` - 入门, `A` - 进阶

### 按主题分类的算法

* **数学**
  * `B` [位运算](src/algorithms/math/bits) - 设置/获取/更新/清除位，乘/除以2，取负等
  * `B` [二进制浮点数](src/algorithms/math/binary-floating-point) - 浮点数的二进制表示
  * `B` [阶乘](src/algorithms/math/factorial)
  * `B` [斐波那契数](src/algorithms/math/fibonacci) - 经典与闭式解法
  * `B` [质因数分解](src/algorithms/math/prime-factors) - 使用 Hardy-Ramanujan 定理查找并计数质因数
  * `B` [素性测试](src/algorithms/math/primality-test)（试除法）
  * `B` [欧几里得算法](src/algorithms/math/euclidean-algorithm) - 求最大公约数（GCD）
  * `B` [最小公倍数](src/algorithms/math/least-common-multiple)（LCM）
  * `B` [埃拉托色尼筛法](src/algorithms/math/sieve-of-eratosthenes) - 找出不超过给定上限的所有质数
  * `B` [是否为2的幂](src/algorithms/math/is-power-of-two) - 判断一个数是否为2的幂（朴素与位运算法）
  * `B` [杨辉三角](src/algorithms/math/pascal-triangle)
  * `B` [复数](src/algorithms/math/complex-number) - 复数及其基本运算
  * `B` [弧度与角度](src/algorithms/math/radian) - 弧度与角度的转换
  * `B` [快速幂](src/algorithms/math/fast-powering)
  * `B` [霍纳法则](src/algorithms/math/horner-method) - 多项式求值
  * `B` [矩阵](src/algorithms/math/matrix) - 矩阵及其基本操作（乘法、转置等）
  * `B` [欧几里得距离](src/algorithms/math/euclidean-distance) - 两点/向量/矩阵间距离
  * `A` [整数划分](src/algorithms/math/integer-partition)
  * `A` [平方根](src/algorithms/math/square-root) - 牛顿法
  * `A` [刘徽圆周率算法](src/algorithms/math/liu-hui) - 基于正多边形的 π 近似计算
  * `A` [离散傅里叶变换](src/algorithms/math/fourier-transform) - 将时间（信号）分解为其频率成分
* **集合**
  * `B` [笛卡尔积](src/algorithms/sets/cartesian-product) - 多集合的乘积
  * `B` [Fisher–Yates 洗牌算法](src/algorithms/sets/fisher-yates) - 有限序列的随机置换
  * `A` [幂集](src/algorithms/sets/power-set) - 集合所有子集（位运算、回溯、级联解法）
  * `A` [全排列](src/algorithms/sets/permutations)（有/无重复）
  * `A` [组合](src/algorithms/sets/combinations)（有/无重复）
  * `A` [最长公共子序列](src/algorithms/sets/longest-common-subsequence)（LCS）
  * `A` [最长递增子序列](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [最短公共超序列](src/algorithms/sets/shortest-common-supersequence)（SCS）
  * `A` [背包问题](src/algorithms/sets/knapsack-problem) - “0/1”与“完全背包”
  * `A` [最大子数组和](src/algorithms/sets/maximum-subarray) - “暴力解法”和“动态规划”（Kadane 算法）
  * `A` [组合总和](src/algorithms/sets/combination-sum) - 求所有和为指定值的组合
* **字符串**
  * `B` [汉明距离](src/algorithms/string/hamming-distance) - 不同字符位置数
  * `B` [回文字符串](src/algorithms/string/palindrome) - 判断字符串反转后是否相同
  * `A` [Levenshtein 距离](src/algorithms/string/levenshtein-distance) - 两序列的最小编辑距离
  * `A` [KMP 算法](src/algorithms/string/knuth-morris-pratt) - 子串搜索（模式匹配）
  * `A` [Z 算法](src/algorithms/string/z-algorithm) - 子串搜索（模式匹配）
  * `A` [Rabin-Karp 算法](src/algorithms/string/rabin-karp) - 子串搜索
  * `A` [最长公共子串](src/algorithms/string/longest-common-substring)
  * `A` [正则表达式匹配](src/algorithms/string/regular-expression-matching)
* **查找**
  * `B` [线性查找](src/algorithms/search/linear-search)
  * `B` [跳跃查找](src/algorithms/search/jump-search)（块查找） - 有序数组查找
  * `B` [二分查找](src/algorithms/search/binary-search) - 有序数组查找
  * `B` [插值查找](src/algorithms/search/interpolation-search) - 均匀分布有序数组查找
* **排序**
  * `B` [冒泡排序](src/algorithms/sorting/bubble-sort)
  * `B` [选择排序](src/algorithms/sorting/selection-sort)
  * `B` [插入排序](src/algorithms/sorting/insertion-sort)
  * `B` [堆排序](src/algorithms/sorting/heap-sort)
  * `B` [归并排序](src/algorithms/sorting/merge-sort)
  * `B` [快速排序](src/algorithms/sorting/quick-sort) - 原地与非原地实现
  * `B` [希尔排序](src/algorithms/sorting/shell-sort)
  * `B` [计数排序](src/algorithms/sorting/counting-sort)
  * `B` [基数排序](src/algorithms/sorting/radix-sort)
  * `B` [桶排序](src/algorithms/sorting/bucket-sort)
* **链表**
  * `B` [正向遍历](src/algorithms/linked-list/traversal)
  * `B` [反向遍历](src/algorithms/linked-list/reverse-traversal)
* **树**
  * `B` [深度优先搜索](src/algorithms/tree/depth-first-search)（DFS）
  * `B` [广度优先搜索](src/algorithms/tree/breadth-first-search)（BFS）
* **图**
  * `B` [深度优先搜索](src/algorithms/graph/depth-first-search)（DFS）
  * `B` [广度优先搜索](src/algorithms/graph/breadth-first-search)（BFS）
  * `B` [Kruskal 算法](src/algorithms/graph/kruskal) - 求加权无向图的最小生成树（MST）
  * `A` [Dijkstra 算法](src/algorithms/graph/dijkstra) - 从单顶点到所有顶点的最短路径
  * `A` [Bellman-Ford 算法](src/algorithms/graph/bellman-ford) - 从单顶点到所有顶点的最短路径
  * `A` [Floyd-Warshall 算法](src/algorithms/graph/floyd-warshall) - 所有顶点对的最短路径
  * `A` [环检测](src/algorithms/graph/detect-cycle) - 有向/无向图的环检测（DFS 与并查集实现）
  * `A` [Prim 算法](src/algorithms/graph/prim) - 求加权无向图的最小生成树（MST）
  * `A` [拓扑排序](src/algorithms/graph/topological-sorting) - DFS 方法
  * `A` [割点](src/algorithms/graph/articulation-points) - Tarjan 算法（基于 DFS）
  * `A` [桥](src/algorithms/graph/bridges) - 基于 DFS 的算法
  * `A` [欧拉路径/回路](src/algorithms/graph/eulerian-path) - Fleury 算法 - 遍历每条边恰一次
  * `A` [哈密顿回路](src/algorithms/graph/hamiltonian-cycle) - 每顶点恰一次
  * `A` [强连通分量](src/algorithms/graph/strongly-connected-components) - Kosaraju 算法
  * `A` [旅行商问题](src/algorithms/graph/travelling-salesman) - 访问每城市一次并回原点的最短路径
* **密码学**
  * `B` [多项式哈希](src/algorithms/cryptography/polynomial-hash) - 基于多项式的滚动哈希函数
  * `B` [栅栏密码](src/algorithms/cryptography/rail-fence-cipher) - 转置密码算法
  * `B` [凯撒密码](src/algorithms/cryptography/caesar-cipher) - 简单替换密码
  * `B` [希尔密码](src/algorithms/cryptography/hill-cipher) - 基于线性代数的替换密码
* **机器学习**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 7 个简单 JS 函数，演示机器如何学习（前向/反向传播）
  * `B` [k-最近邻](src/algorithms/ml/knn) - k-近邻分类算法
  * `B` [k-均值聚类](src/algorithms/ml/k-means) - k-均值聚类算法
* **图像处理**
  * `B` [缝合裁剪](src/algorithms/image-processing/seam-carving) - 内容感知图片缩放算法
* **统计**
  * `B` [加权随机](src/algorithms/statistics/weighted-random) - 根据权重选择随机项
* **进化算法**
  * `A` [遗传算法](https://github.com/trekhleb/self-parking-car-evolution) - 遗传算法用于自动泊车训练示例
* **未分类**
  * `B` [汉诺塔](src/algorithms/uncategorized/hanoi-tower)
  * `B` [正方形矩阵旋转](src/algorithms/uncategorized/square-matrix-rotation) - 原地算法
  * `B` [跳跃游戏](src/algorithms/uncategorized/jump-game) - 回溯、动态规划（自顶向下/自底向上）、贪心
  * `B` [不同路径](src/algorithms/uncategorized/unique-paths) - 回溯、动态规划、杨辉三角
  * `B` [接雨水](src/algorithms/uncategorized/rain-terraces) - 动态规划与暴力解法
  * `B` [递归楼梯](src/algorithms/uncategorized/recursive-staircase) - 到达顶端的方法数（4种解法）
  * `B` [买卖股票的最佳时机](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - 分治与单遍历
  * `B` [有效括号](src/algorithms/stack/valid-parentheses) - 判断字符串括号是否有效（用栈实现）
  * `A` [N 皇后问题](src/algorithms/uncategorized/n-queens)
  * `A` [骑士巡游](src/algorithms/uncategorized/knight-tour)

### 按范式分类的算法

算法范式是一种指导一类算法设计的通用方法或思想。它比“算法”的抽象层次更高，正如算法比计算机程序更抽象一样。

* **暴力法** - 穷举所有可能，选择最优解
  * `B` [线性查找](src/algorithms/search/linear-search)
  * `B` [接雨水](src/algorithms/uncategorized/rain-terraces)
  * `B` [递归楼梯](src/algorithms/uncategorized/recursive-staircase)
  * `A` [最大子数组和](src/algorithms/sets/maximum-subarray)
  * `A` [旅行商问题](src/algorithms/graph/travelling-salesman)
  * `A` [离散傅里叶变换](src/algorithms/math/fourier-transform)
* **贪心法** - 每步选择当前最优，无视后续影响
  * `B` [跳跃游戏](src/algorithms/uncategorized/jump-game)
  * `A` [完全背包问题](src/algorithms/sets/knapsack-problem)
  * `A` [Dijkstra 算法](src/algorithms/graph/dijkstra)
  * `A` [Prim 算法](src/algorithms/graph/prim)
  * `A` [Kruskal 算法](src/algorithms/graph/kruskal)
* **分治法** - 将问题分解为小部分分别解决
  * `B` [二分查找](src/algorithms/search/binary-search)
  * `B` [汉诺塔](src/algorithms/uncategorized/hanoi-tower)
  * `B` [杨辉三角](src/algorithms/math/pascal-triangle)
  * `B` [欧几里得算法](src/algorithms/math/euclidean-algorithm)
  * `B` [归并排序](src/algorithms/sorting/merge-sort)
  * `B` [快速排序](src/algorithms/sorting/quick-sort)
  * `B` [树的深度优先遍历](src/algorithms/tree/depth-first-search)
  * `B` [图的深度优先遍历](src/algorithms/graph/depth-first-search)
  * `B` [矩阵](src/algorithms/math/matrix) - 不同形状矩阵的生成与遍历
  * `B` [跳跃游戏](src/algorithms/uncategorized/jump-game)
  * `B` [快速幂](src/algorithms/math/fast-powering)
  * `B` [买卖股票的最佳时机](src/algorithms/uncategorized/best-time-to-buy-sell-stocks)
  * `A` [全排列](src/algorithms/sets/permutations)
  * `A` [组合](src/algorithms/sets/combinations)
  * `A` [最大子数组和](src/algorithms/sets/maximum-subarray)
* **动态规划** - 利用已求解的子问题构建完整解
  * `B` [斐波那契数](src/algorithms/math/fibonacci)
  * `B` [跳跃游戏](src/algorithms/uncategorized/jump-game)
  * `B` [不同路径](src/algorithms/uncategorized/unique-paths)
  * `B` [接雨水](src/algorithms/uncategorized/rain-terraces)
  * `B` [递归楼梯](src/algorithms/uncategorized/recursive-staircase)
  * `B` [缝合裁剪](src/algorithms/image-processing/seam-carving)
  * `A` [Levenshtein 距离](src/algorithms/string/levenshtein-distance)
  * `A` [最长公共子序列](src/algorithms/sets/longest-common-subsequence)
  * `A` [最长公共子串](src/algorithms/string/longest-common-substring)
  * `A` [最长递增子序列](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [最短公共超序列](src/algorithms/sets/shortest-common-supersequence)
  * `A` [0/1 背包问题](src/algorithms/sets/knapsack-problem)
  * `A` [整数划分](src/algorithms/math/integer-partition)
  * `A` [最大子数组和](src/algorithms/sets/maximum-subarray)
  * `A` [Bellman-Ford 算法](src/algorithms/graph/bellman-ford)
  * `A` [Floyd-Warshall 算法](src/algorithms/graph/floyd-warshall)
  * `A` [正则表达式匹配](src/algorithms/string/regular-expression-matching)
* **回溯法** - 类似暴力法，尝试生成所有解，每生成一个解时测试其合法性，合法则继续，不合法则回退并换路径。通常用 DFS 状态空间遍历。
  * `B` [跳跃游戏](src/algorithms/uncategorized/jump-game)
  * `B` [不同路径](src/algorithms/uncategorized/unique-paths)
  * `B` [幂集](src/algorithms/sets/power-set)
  * `A` [哈密顿回路](src/algorithms/graph/hamiltonian-cycle)
  * `A` [N 皇后问题](src/algorithms/uncategorized/n-queens)
  * `A` [骑士巡游](src/algorithms/uncategorized/knight-tour)
  * `A` [组合总和](src/algorithms/sets/combination-sum)
* **分支限界法** - 在回溯过程中记录当前已找到的最优解并用其作为下界，剪枝丢弃成本更高的部分解。通常结合 BFS 与 DFS 状态空间树遍历。

## 如何使用本仓库

**安装所有依赖**

```
npm install
```

**运行 ESLint**

可用于检查代码质量。

```
npm run lint
```

**运行所有测试**

```
npm test
```

**按名称运行测试**

```
npm test -- 'LinkedList'
```

**故障排查**

若 lint 或测试失败，尝试删除 `node_modules` 文件夹并重新安装 npm 包：

```
rm -rf ./node_modules
npm i
```

此外，确保你使用的 Node 版本为（`>=16`）。如果用 [nvm](https://github.com/nvm-sh/nvm) 管理 Node 版本，可以在项目根目录执行 `nvm use` 自动切换到合适版本。

**Playground**

你可在 `./src/playground/playground.js` 文件中自由试验数据结构和算法，并在 `./src/playground/__test__/playground.test.js` 中为其编写测试。

然后只需运行以下命令测试你的 playground 代码：

```
npm test -- 'playground'
```

## 实用信息

### 参考资料

- [▶ YouTube 数据结构与算法教程](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 数据结构手绘图](https://okso.app/showcase/data-structures)

### 大 O 表示法

*大 O 表示法* 用于根据输入规模增长描述算法运行时间或空间需求的增长情况。
下表展示了常见算法的增长阶数（大 O 表示）：

![Big O graphs](./assets/big-o-graph.png)

来源: [Big O Cheat Sheet](http://bigocheatsheet.com/).

下面是常用大 O 表达式及不同输入规模下的运算量对比：

| 大 O 表示法    | 类型        | 10 个元素的运算次数 | 100 个元素的运算次数 | 1000 个元素的运算次数 |
| -------------- | ----------- | ------------------- | -------------------- | --------------------- |
| **O(1)**       | 常数级      | 1                   | 1                    | 1                     |
| **O(log N)**   | 对数级      | 3                   | 6                    | 9                     |
| **O(N)**       | 线性级      | 10                  | 100                  | 1000                  |
| **O(N log N)** | n log(n)    | 30                  | 600                  | 9000                  |
| **O(N^2)**     | 二次方      | 100                 | 10000                | 1000000               |
| **O(2^N)**     | 指数级      | 1024                | 1.26e+29             | 1.07e+301             |
| **O(N!)**      | 阶乘级      | 3628800             | 9.3e+157             | 4.02e+2567            |

### 数据结构操作复杂度

| 数据结构            | 访问    | 查找    | 插入    | 删除    | 备注      |
| ------------------- | :-----: | :-----: | :-----: | :-----: | :-------- |
| **数组**            | 1       | n       | n       | n       |           |
| **栈**              | n       | n       | 1       | 1       |           |
| **队列**            | n       | n       | 1       | 1       |           |
| **链表**            | n       | n       | 1       | n       |           |
| **哈希表**          | -       | n       | n       | n       | 完美哈希函数下为 O(1) |
| **二叉搜索树**      | n       | n       | n       | n       | 平衡树为 O(log(n)) |
| **B 树**            | log(n)  | log(n)  | log(n)  | log(n)  |           |
| **红黑树**          | log(n)  | log(n)  | log(n)  | log(n)  |           |
| **AVL 树**          | log(n)  | log(n)  | log(n)  | log(n)  |           |
| **布隆过滤器**      | -       | 1       | 1       | -       | 查找可能有误报 |

### 数组排序算法复杂度

| 名称               | 最优            | 平均               | 最坏               | 空间      | 稳定性    | 备注      |
| ------------------ | :-------------: | :----------------: | :----------------: | :-------: | :-------: | :-------- |
| **冒泡排序**       | n               | n<sup>2</sup>      | n<sup>2</sup>      | 1         | 是        |           |
| **插入排序**       | n               | n<sup>2</sup>      | n<sup>2</sup>      | 1         | 是        |           |
| **选择排序**       | n<sup>2</sup>   | n<sup>2</sup>      | n<sup>2</sup>      | 1         | 否        |           |
| **堆排序**         | n&nbsp;log(n)   | n&nbsp;log(n)      | n&nbsp;log(n)      | 1         | 否        |           |
| **归并排序**       | n&nbsp;log(n)   | n&nbsp;log(n)      | n&nbsp;log(n)      | n         | 是        |           |
| **快速排序**       | n&nbsp;log(n)   | n&nbsp;log(n)      | n<sup>2</sup>      | log(n)    | 否        | 通常为原地算法，栈空间 O(log(n)) |
| **希尔排序**       | n&nbsp;log(n)   | 取决于步长序列      | n&nbsp;(log(n))<sup>2</sup> | 1         | 否        |           |
| **计数排序**       | n + r           | n + r              | n + r              | n + r     | 是        | r-数组最大值 |
| **基数排序**       | n * k           | n * k              | n * k              | n + k     | 是        | k-最大关键字长度 |

## 项目支持者

> 你可以通过 ❤️️ [GitHub](https://github.com/sponsors/trekhleb) 或 ❤️️ [Patreon](https://www.patreon.com/trekhleb) 支持本项目。

[支持本项目的人](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## 作者

[@trekhleb](https://trekhleb.dev)

更多关于 JavaScript 和算法的[项目](https://trekhleb.dev/projects/)与[文章](https://trekhleb.dev/blog/)，请访问 [trekhleb.dev](https://trekhleb.dev)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---