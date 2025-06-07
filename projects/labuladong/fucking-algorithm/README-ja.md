[![Star History Chart](https://api.star-history.com/svg?repos=labuladong/fucking-algorithm&type=Date)](https://star-history.com/#labuladong/fucking-algorithm&Date)

英語版は [labuladong.online](https://labuladong.online/algo/en/) にもあります。どうぞお楽しみください：）

# labuladong のアルゴリズムノート

本リポジトリには合計60本以上のオリジナル記事があり、すべてLeetCodeの問題に基づいています。全ての問題タイプやテクニックをカバーし、**一を聞いて十を知る、分かりやすさ**を徹底しています。ただコードを羅列するだけではなく、後述の目次もご覧ください。

まず少し愚痴を言わせてください。**問題を解く、解くのは問題だが、養うのは思考。本リポジトリの目的はこのアルゴリズム的思考を伝えること**です。もしLeetCodeの問題コードだけを載せたリポジトリを書いたとして、それが何の役に立つでしょうか？思考の解説がなく、思考フレームワークもない。ただ時間計算量を書く、それなら一目見れば分かります。

答えだけが欲しいなら簡単です。問題のコメント欄には様々な答えがあり、しばしばPythonの1行コードで解決するものもあり、多くの人がいいねを押しています。しかし、あなたがアルゴリズム問題を解くのは、プログラミング言語の技巧を学ぶためですか？それともアルゴリズム的思考を学ぶためですか？あなたの喜びは、他人の1行コードをコピーしてテストを通すことですか？それとも自分の論理的推論とアルゴリズムフレームワークで答えを導くことですか？

ネット上ではよく「内容が基礎的すぎる」「フレームワーク思考では学べない」などと批判されますが、私たちがアルゴリズムを学ぶのは仕事のためであって、競技のためではありません。私も試行錯誤してきました。必要なのは明確で分かりやすい知識です。難解で曖昧な内容は求めていません。

分かりやすさを追求しなければ、「アルゴリズム導論」を持ち上げて、みんなを恐れさせて退却させるだけでしょうか？

**何事もやり続ければパターンが見えてきます。私は様々なアルゴリズムのパターンやフレームワークをまとめました。他の人が遠回りしないよう役立つと信じています**。私は完全な独学で、1年かけて問題を解きまとめたものです。自作のアルゴリズムチートシートもあります（目次は後述）。ここではこれ以上話しません。

## 学習を始める前に

**1、本リポジトリにstarをお願いします。私の虚栄心を満たしてください**。記事の質には自信があります。今も執筆を続けているので、応援が創作の原動力になります。感謝します。

**2、私のオンラインサイトをブックマークすることをお勧めします。各記事の冒頭に対応するLeetCodeのリンクがあり、記事を読みながら問題を解くことができます。合計で500問ハンドホールドで解けます**：

2024年最新アドレス：https://labuladong.online/algo/

~~GitHub Pages アドレス：https://labuladong.online/algo/~~

~~Gitee Pages アドレス：https://labuladong.gitee.io/algo/~~

## labuladong 問題解決ファミリーバケットの概要

### 1. アルゴリズム可視化パネル

私のアルゴリズムサイトやすべての関連プラグインには、アルゴリズム可視化ツールが統合されています。データ構造や再帰の過程を可視化でき、アルゴリズム理解の難易度を大幅に下げます。ほぼすべての問題解法コードに対応する可視化パネルがあります。詳細は下記をご覧ください。

### 2. 学習サイト

内容はもちろん、私のアルゴリズムチュートリアルシリーズの中で最もコアな部分です。私のアルゴリズムチュートリアルは全て[labuladong.online](https://labuladong.online/algo/)に公開されています。ここで多くの学習時間を費やすことになるでしょう。ただブックマークするだけではありません〜

![](https://labuladong.github.io/pictures/简介/web_intro1.jpg)

### 3. Chrome プラグイン

**主な機能**：Chrome プラグインでは中国語版LeetCodeや英語版LeetCodeで私の「解説」や「思路」を素早く確認でき、問題とアルゴリズムテクニックの参照関係も追加されています。私のサイト/公式アカウント/コースと連携し、読者に最高の問題解決体験を提供します。インストール・使用マニュアルは下記目次をご参照ください。

![](https://labuladong.github.io/pictures/简介/chrome_intro.jpg)

### 4. vscode プラグイン

**主な機能**：Chrome プラグインと基本的に同じ機能です。vscodeで問題を解くのが習慣の読者はこちらをどうぞ。インストール・使用マニュアルは下記目次をご参照ください。

![](https://labuladong.github.io/pictures/简介/vs_intro.jpg)

### 5. Jetbrains プラグイン

**主な機能**：Chrome プラグインと基本的に同じ機能です。Jetbrains系IDE（PyCharm/Intellij/Golandなど）で問題を解くのが習慣の読者はこちらをどうぞ。インストール・使用マニュアルは下記目次をご参照ください。

![](https://labuladong.github.io/pictures/简介/jb_intro.jpg)

最後に、皆さんの楽しい学習と、問題の海での自由な航海をお祈りします！

# 目次

<!-- table start -->

### [本サイトの紹介](https://labuladong.online/algo/home/)

### [関連プラグインとアルゴリズム可視化](https://labuladong.online/algo/menu/tools/)
  * [Chrome 問題解決プラグイン](https://labuladong.online/algo/intro/chrome/)
  * [vscode 問題解決プラグイン](https://labuladong.online/algo/intro/vscode/)
  * [JetBrains 問題解決プラグイン](https://labuladong.online/algo/intro/jetbrains/)
  * [アルゴリズム可視化パネルの使い方](https://labuladong.online/algo/intro/visualize/)
  * [有料会員について](https://labuladong.online/algo/intro/site-vip/)

### [初心者・短期習得向け学習計画](https://labuladong.online/algo/menu/plan/)
  * [アルゴリズム学習のポイントと落とし穴](https://labuladong.online/algo/intro/how-to-learn-algorithms/)
  * [初心者向け学習計画](https://labuladong.online/algo/intro/beginner-learning-plan/)
  * [短期間学習計画](https://labuladong.online/algo/intro/quick-learning-plan/)
  * [練習・復習の方法](https://labuladong.online/algo/intro/how-to-practice/)
  * [アルゴリズム可視化クイックリファレンス](https://labuladong.online/algo/intro/visualize-catalog/)

### [入門：プログラミング言語の基礎と練習](https://labuladong.online/algo/menu/)
  * [本章ガイド](https://labuladong.online/algo/intro/programming-language-basic/)
  * [C++ 言語基礎](https://labuladong.online/algo/programming-language-basic/cpp/)
  * [Java 言語基礎](https://labuladong.online/algo/programming-language-basic/java/)
  * [Golang 言語基礎](https://labuladong.online/algo/programming-language-basic/golang/)
  * [Python 言語基礎](https://labuladong.online/algo/programming-language-basic/python/)
  * [JavaScript 言語基礎](https://labuladong.online/algo/intro/js/)
  * [LeetCode 問題解決の注意点](https://labuladong.online/algo/intro/leetcode/)
  * [プログラミング言語での問題解決実践](https://labuladong.online/algo/programming-language-basic/lc-practice/)

### [基礎：データ構造とソート詳細解説](https://labuladong.online/algo/menu/quick-start/)
  * [本章ガイド](https://labuladong.online/algo/intro/data-structure-basic/)
  * [時間・空間計算量入門](https://labuladong.online/algo/intro/complexity-basic/)

  * [動的配列の実装を手取り足取り解説](https://labuladong.online/algo/menu/dynamic-array/)
    * [配列（順序保存）の基本原理](https://labuladong.online/algo/data-structure-basic/array-basic/)
    * [動的配列のコード実装](https://labuladong.online/algo/data-structure-basic/array-implement/)

  * [単/双方向リストの実装を手取り足取り解説](https://labuladong.online/algo/menu/linked-list/)
    * [リスト（連結保存）の基本原理](https://labuladong.online/algo/data-structure-basic/linkedlist-basic/)
    * [リストのコード実装](https://labuladong.online/algo/data-structure-basic/linkedlist-implement/)

  * [キュー・スタックの実装を手取り足取り解説](https://labuladong.online/algo/menu/queue-stack/)
    * [キュー・スタックの基本原理](https://labuladong.online/algo/data-structure-basic/queue-stack-basic/)
    * [リストによるキュー・スタックの実装](https://labuladong.online/algo/data-structure-basic/linked-queue-stack/)
    * [リングバッファ技法](https://labuladong.online/algo/data-structure-basic/cycle-array/)
    * [配列によるキュー・スタックの実装](https://labuladong.online/algo/data-structure-basic/array-queue-stack/)
    * [両端キュー（Deque）の原理と実装](https://labuladong.online/algo/data-structure-basic/deque-implement/)

  * [ハッシュ表の原理と実装](https://labuladong.online/algo/menu/)
    * [ハッシュ表のコア原理](https://labuladong.online/algo/data-structure-basic/hashmap-basic/)
    * [チェイニング法によるハッシュ表実装](https://labuladong.online/algo/data-structure-basic/hashtable-chaining/)
    * [線形探査法の2つの難点](https://labuladong.online/algo/data-structure-basic/linear-probing-key-point/)
    * [線形探査法の2種のコード実装](https://labuladong.online/algo/data-structure-basic/linear-probing-code/)
    * [ハッシュセットの原理と実装](https://labuladong.online/algo/data-structure-basic/hash-set/)

  * [ハッシュ表構造の様々な変化](https://labuladong.online/algo/menu/)
    * [リストで強化したハッシュ表（LinkedHashMap）](https://labuladong.online/algo/data-structure-basic/hashtable-with-linked-list/)
    * [配列で強化したハッシュ表（ArrayHashMap）](https://labuladong.online/algo/data-structure-basic/hashtable-with-array/)

  * [二分木構造と走査](https://labuladong.online/algo/menu/binary-tree/)
    * [二分木の基礎と主要タイプ](https://labuladong.online/algo/data-structure-basic/binary-tree-basic/)
    * [二分木の再帰/レベル走査](https://labuladong.online/algo/data-structure-basic/binary-tree-traverse-basic/)
    * [多分木の再帰/レベル走査](https://labuladong.online/algo/data-structure-basic/n-ary-tree-traverse-basic/)

  * [二分木構造の様々な変化](https://labuladong.online/algo/menu/binary-tree/)
    * [二分探索木の応用と可視化](https://labuladong.online/algo/data-structure-basic/tree-map-basic/)
    * [赤黒木の完全平衡と可視化](https://labuladong.online/algo/data-structure-basic/rbtree-basic/)
    * [Trie/辞書木/前置木の原理と可視化](https://labuladong.online/algo/data-structure-basic/trie-map-basic/)
    * [二分ヒープのコア原理と可視化](https://labuladong.online/algo/data-structure-basic/binary-heap-basic/)
    * [二分ヒープ・優先度キューの実装](https://labuladong.online/algo/data-structure-basic/binary-heap-implement/)
    * [セグメント木のコア原理と可視化](https://labuladong.online/algo/data-structure-basic/segment-tree-basic/)
    * [更新中](https://labuladong.online/algo/intro/updating/)

  * [グラフ理論データ構造と走査](https://labuladong.online/algo/menu/graph-theory/)
    * [グラフ構造の基礎と汎用実装](https://labuladong.online/algo/data-structure-basic/graph-basic/)
    * [グラフ構造のDFS/BFS走査](https://labuladong.online/algo/data-structure-basic/graph-traverse-basic/)
    * [Union Find（ユニオンファインド）原理](https://labuladong.online/algo/data-structure-basic/union-find-basic/)
    * [更新中](https://labuladong.online/algo/intro/updating/)

  * [10大ソートアルゴリズム原理と可視化](https://labuladong.online/algo/menu/sorting/)
    * [本章ガイド](https://labuladong.online/algo/intro/sorting/)
    * [ソートアルゴリズムの重要指標](https://labuladong.online/algo/data-structure-basic/sort-basic/)
    * [選択ソートの問題点](https://labuladong.online/algo/data-structure-basic/select-sort/)
    * [安定性を持つ：バブルソート](https://labuladong.online/algo/data-structure-basic/bubble-sort/)
    * [逆転思考：挿入ソート](https://labuladong.online/algo/data-structure-basic/insertion-sort/)
    * [O(N^2)突破：シェルソート](https://labuladong.online/algo/data-structure-basic/shell-sort/)
    * [二分木前順位置利用：クイックソート](https://labuladong.online/algo/data-structure-basic/quick-sort/)
    * [二分木後順位置利用：マージソート](https://labuladong.online/algo/data-structure-basic/merge-sort/)
    * [二分ヒープ構造応用：ヒープソート](https://labuladong.online/algo/data-structure-basic/heap-sort/)
    * [新しいソート原理：カウントソート](https://labuladong.online/algo/data-structure-basic/counting-sort/)
    * [長所取り：バケットソート](https://labuladong.online/algo/data-structure-basic/bucket-sort/)
    * [基数ソート（Radix Sort）](https://labuladong.online/algo/data-structure-basic/radix-sort/)

  * [更新中](https://labuladong.online/algo/intro/updating/)

### [第0章、コア問題解決フレームワークまとめ](https://labuladong.online/algo/menu/core/)
  * [本章ガイド](https://labuladong.online/algo/intro/core-intro/)
  * [データ構造とアルゴリズムのフレームワーク思考](https://labuladong.online/algo/essential-technique/algorithm-summary/)
  * [二重ポインタテクニックで7つのリスト問題を一気に攻略](https://labuladong.online/algo/essential-technique/linked-list-skills-summary/)
  * [二重ポインタテクニックで7つの配列問題を一気に攻略](https://labuladong.online/algo/essential-technique/array-two-pointers-summary/)
  * [スライディングウィンドウアルゴリズムのコアコードテンプレート](https://labuladong.online/algo/essential-technique/sliding-window-framework/)
  * [二分探索アルゴリズムのコアコードテンプレート](https://labuladong.online/algo/essential-technique/binary-search-framework/)
  * [動的計画法解法パターンフレームワーク](https://labuladong.online/algo/essential-technique/dynamic-programming-framework/)
  * [バックトラックアルゴリズム解法パターンフレームワーク](https://labuladong.online/algo/essential-technique/backtrack-framework/)
  * [BFSアルゴリズム解法パターンフレームワーク](https://labuladong.online/algo/essential-technique/bfs-framework/)
  * [二分木シリーズアルゴリズムコア要綱](https://labuladong.online/algo/essential-technique/binary-tree-summary/)
  * [バックトラックアルゴリズムで順列/組み合わせ/部分集合問題を攻略](https://labuladong.online/algo/essential-technique/permutation-combination-subset-all-in-one/)
  * [貪欲アルゴリズム解法パターンフレームワーク](https://labuladong.online/algo/essential-technique/greedy/)
  * [分治アルゴリズム解法パターンフレームワーク](https://labuladong.online/algo/essential-technique/divide-and-conquer/)
  * [アルゴリズムの時間・空間計算量分析実用ガイド](https://labuladong.online/algo/essential-technique/complexity-analysis/)

### [第1章、クラシックデータ構造アルゴリズム](https://labuladong.online/algo/menu/ds/)
  * [リストアルゴリズムを手取り足取り解説](https://labuladong.online/algo/menu/linked-list/)
    * [二重ポインタテクニックで7つのリスト問題を一気に攻略](https://labuladong.online/algo/essential-technique/linked-list-skills-summary/)
    * [【強化練習】リスト二重ポインタクラシック問題集](https://labuladong.online/algo/problem-set/linkedlist-two-pointers/)
    * [単方向リストの様々な反転方法まとめ](https://labuladong.online/algo/data-structure/reverse-linked-list-recursion/)
    * [回文リストの判定方法](https://labuladong.online/algo/data-structure/palindrome-linked-list/)

  * [配列アルゴリズムを手取り足取り解説](https://labuladong.online/algo/menu/array/)
    * [二重ポインタテクニックで7つの配列問題を一気に攻略](https://labuladong.online/algo/essential-technique/array-two-pointers-summary/)
    * [2次元配列の多彩な走査テクニック](https://labuladong.online/algo/practice-in-action/2d-array-traversal-summary/)
    * [1つの方法でnSum問題を一網打尽](https://labuladong.online/algo/practice-in-action/nsum/)
    * [【強化練習】配列二重ポインタクラシック問題集](https://labuladong.online/algo/problem-set/array-two-pointers/)
    * [小さくて美しいアルゴリズムテクニック：前置和配列](https://labuladong.online/algo/data-structure/prefix-sum/)
    * [【強化練習】前置和テクニッククラシック問題集](https://labuladong.online/algo/problem-set/perfix-sum/)
    * [小さくて美しいアルゴリズムテクニック：差分配列](https://labuladong.online/algo/data-structure/diff-array/)
    * [スライディングウィンドウアルゴリズムのコアコードテンプレート](https://labuladong.online/algo/essential-technique/sliding-window-framework/)
    * [【強化練習】スライディングウィンドウアルゴリズムクラシック問題集](https://labuladong.online/algo/problem-set/sliding-window/)
    * [スライディングウィンドウ応用：Rabin Karp 文字列マッチングアルゴリズム](https://labuladong.online/algo/practice-in-action/rabinkarp/)
    * [二分探索アルゴリズムのコアコードテンプレート](https://labuladong.online/algo/essential-technique/binary-search-framework/)
    * [実際に二分探索を使う際の思考フレームワーク](https://labuladong.online/algo/frequency-interview/binary-search-in-action/)
    * [【強化練習】二分探索アルゴリズムクラシック問題集](https://labuladong.online/algo/problem-set/binary-search/)
    * [重み付きランダム選択アルゴリズム](https://labuladong.online/algo/frequency-interview/random-pick-with-weight/)
    * [田忌の競馬に隠れたアルゴリズム的意思決定](https://labuladong.online/algo/practice-in-action/advantage-shuffle/)

  * [二分木アルゴリズムを手取り足取り解説](https://labuladong.online/algo/menu/binary-tree/)
    * [二分木シリーズアルゴリズムコア要綱](https://labuladong.online/algo/essential-technique/binary-tree-summary/)
    * [二分木心法（思考編）](https://labuladong.online/algo/data-structure/binary-tree-part1/)
    * [二分木心法（構造編）](https://labuladong.online/algo/data-structure/binary-tree-part2/)
    * [二分木心法（後順編）](https://labuladong.online/algo/data-structure/binary-tree-part3/)
    * [二分木心法（シリアライズ編）](https://labuladong.online/algo/data-structure/serialize-and-deserialize-binary-tree/)
    * [二分探索木心法（特性編）](https://labuladong.online/algo/data-structure/bst-part1/)
    * [二分探索木心法（基礎操作編）](https://labuladong.online/algo/data-structure/bst-part2/)
    * [二分探索木心法（構造編）](https://labuladong.online/algo/data-structure/bst-part3/)
    * [二分探索木心法（後順編）](https://labuladong.online/algo/data-structure/bst-part4/)

  * [テンプレートで100の二分木問題を攻略](https://labuladong.online/algo/menu/100-bt/)
    * [本章ガイド](https://labuladong.online/algo/intro/binary-tree-practice/)
    * [【強化練習】「走査」思考で解くI](https://labuladong.online/algo/problem-set/binary-tree-traverse-i/)
    * [【強化練習】「走査」思考で解くII](https://labuladong.online/algo/problem-set/binary-tree-traverse-ii/)
    * [【強化練習】「走査」思考で解くIII](https://labuladong.online/algo/problem-set/binary-tree-traverse-iii/)
    * [【強化練習】「分解問題」思考で解くI](https://labuladong.online/algo/problem-set/binary-tree-divide-i/)
    * [【強化練習】「分解問題」思考で解くII](https://labuladong.online/algo/problem-set/binary-tree-divide-ii/)
    * [【強化練習】2つの思考を同時に使って解く](https://labuladong.online/algo/problem-set/binary-tree-combine-two-view/)
    * [【強化練習】後順位置を利用して解くI](https://labuladong.online/algo/problem-set/binary-tree-post-order-i/)
    * [【強化練習】後順位置を利用して解くII](https://labuladong.online/algo/problem-set/binary-tree-post-order-ii/)
    * [【強化練習】後順位置を利用して解くIII](https://labuladong.online/algo/problem-set/binary-tree-post-order-iii/)
    * [【強化練習】レベル走査で解くI](https://labuladong.online/algo/problem-set/binary-tree-level-i/)
    * [【強化練習】レベル走査で解くII](https://labuladong.online/algo/problem-set/binary-tree-level-ii/)
    * [【強化練習】二分探索木クラシック問題I](https://labuladong.online/algo/problem-set/bst1/)
    * [【強化練習】二分探索木クラシック問題II](https://labuladong.online/algo/problem-set/bst2/)

  * [二分木の応用・発展](https://labuladong.online/algo/menu/more-bt/)
    * [応用：最近共通祖先問題解法フレームワーク](https://labuladong.online/algo/practice-in-action/lowest-common-ancestor-summary/)
    * [応用：完全二分木のノード数の計算方法](https://labuladong.online/algo/data-structure/count-complete-tree-nodes/)
    * [応用：遅延展開多分木](https://labuladong.online/algo/data-structure/flatten-nested-list-iterator/)
    * [応用：マージソート詳細解説と応用](https://labuladong.online/algo/practice-in-action/merge-sort/)
    * [応用：クイックソート詳細解説と応用](https://labuladong.online/algo/practice-in-action/quick-sort/)
    * [応用：スタックで再帰的な二分木走査をシミュレーション](https://labuladong.online/algo/data-structure/iterative-traversal-binary-tree/)

  * [データ構造設計を手取り足取り解説](https://labuladong.online/algo/menu/design/)
    * [キューでスタックを、スタックでキューを実装](https://labuladong.online/algo/data-structure/stack-queue/)
    * [【強化練習】スタックのクラシック問題集](https://labuladong.online/algo/problem-set/stack/)
    * [【強化練習】括弧問題まとめ](https://labuladong.online/algo/problem-set/parentheses/)
    * [【強化練習】キューのクラシック問題集](https://labuladong.online/algo/problem-set/queue/)
    * [単調スタックアルゴリズムテンプレートで3問を攻略](https://labuladong.online/algo/data-structure/monotonic-stack/)
    * [【強化練習】単調スタックのバリエーションとクラシック問題集](https://labuladong.online/algo/problem-set/monotonic-stack/)
    * [単調キューでスライディングウィンドウ問題を解決](https://labuladong.online/algo/data-structure/monotonic-queue/)
    * [【強化練習】単調キューの汎用実装とクラシック問題集](https://labuladong.online/algo/problem-set/monotonic-queue/)
    * [アルゴリズムはレゴのよう：LRUアルゴリズム自作](https://labuladong.online/algo/data-structure/lru-cache/)
    * [アルゴリズムはレゴのよう：LFUアルゴリズム自作](https://labuladong.online/algo/frequency-interview/lfu/)
    * [定数時間で配列中の任意要素を削除/検索](https://labuladong.online/algo/data-structure/random-set/)
    * [【強化練習】ハッシュ表の追加問題集](https://labuladong.online/algo/problem-set/hash-table/)
    * [【強化練習】優先度キュークラシック問題集](https://labuladong.online/algo/problem-set/binary-heap/)
    * [TreeMap/TreeSetの実装](https://labuladong.online/algo/data-structure-basic/tree-map-implement/)
    * [SegmentTree セグメント木の実装](https://labuladong.online/algo/data-structure/segment-tree-implement/)
    * [Trie/辞書木/前置木の実装](https://labuladong.online/algo/data-structure/trie-implement/)
    * [【強化練習】Trie木アルゴリズム問題集](https://labuladong.online/algo/problem-set/trie/)
    * [SNSタイムライン機能の設計](https://labuladong.online/algo/data-structure/design-twitter/)
    * [試験会場座席割当アルゴリズムの設計](https://labuladong.online/algo/frequency-interview/exam-room/)
    * [【強化練習】その他クラシック設計問題集](https://labuladong.online/algo/problem-set/ds-design/)
    * [応用：電卓の実装方法](https://labuladong.online/algo/data-structure/implement-calculator/)
    * [応用：2つの二分ヒープで中央値アルゴリズムを実現](https://labuladong.online/algo/practice-in-action/find-median-from-data-stream/)
    * [応用：配列重複削除問題（難問版）](https://labuladong.online/algo/frequency-interview/remove-duplicate-letters/)

  * [グラフアルゴリズムを手取り足取り解説](https://labuladong.online/algo/menu/graph/)
    * [サイクル検出とトポロジカルソートアルゴリズム](https://labuladong.online/algo/data-structure/topological-sort/)
    * [千百度の中で彼を探す：有名人問題](https://labuladong.online/algo/frequency-interview/find-celebrity/)
    * [二分グラフ判定アルゴリズム](https://labuladong.online/algo/data-structure/bipartite-graph/)
    * [Union-Find（ユニオンファインド）アルゴリズム](https://labuladong.online/algo/data-structure/union-find/)
    * [【強化練習】ユニオンファインドクラシック問題集](https://labuladong.online/algo/problem-set/union-find/)
    * [Kruskal 最小全域木アルゴリズム](https://labuladong.online/algo/data-structure/kruskal/)
    * [Prim 最小全域木アルゴリズム](https://labuladong.online/algo/data-structure/prim/)
    * [Dijkstra アルゴリズムテンプレートと応用](https://labuladong.online/algo/data-structure/dijkstra/)
    * [【強化練習】Dijkstraアルゴリズムクラシック問題集](https://labuladong.online/algo/problem-set/dijkstra/)

### [第2章、クラシック全探索アルゴリズム](https://labuladong.online/algo/menu/braute-force-search/)
  * [DFS/バックトラックアルゴリズム](https://labuladong.online/algo/menu/dfs/)
    * [バックトラックアルゴリズム解法パターンフレームワーク](https://labuladong.online/algo/essential-technique/backtrack-framework/)
    * [バックトラック実践：数独とNクイーン問題](https://labuladong.online/algo/practice-in-action/sudoku-nqueue/)
    * [バックトラックで順列/組み合わせ/部分集合問題を攻略](https://labuladong.online/algo/essential-technique/permutation-combination-subset-all-in-one/)
    * [ボールボックスモデル：バックトラックの2つの視点](https://labuladong.online/algo/practice-in-action/two-views-of-backtrack/)
    * [バックトラック/DFSに関するよくある疑問](https://labuladong.online/algo/essential-technique/backtrack-vs-dfs/)
    * [すべての島問題を1つの記事で攻略](https://labuladong.online/algo/frequency-interview/island-dfs-summary/)
    * [バックトラック実践：括弧生成](https://labuladong.online/algo/practice-in-action/generate-parentheses/)
    * [バックトラック実践：集合分割](https://labuladong.online/algo/practice-in-action/partition-to-k-equal-sum-subsets/)
    * [【強化練習】バックトラッククラシック問題I](https://labuladong.online/algo/problem-set/backtrack-i/)
    * [【強化練習】バックトラッククラシック問題II](https://labuladong.online/algo/problem-set/backtrack-ii/)
    * [【強化練習】バックトラッククラシック問題III](https://labuladong.online/algo/problem-set/backtrack-iii/)

  * [BFSアルゴリズム](https://labuladong.online/algo/menu/bfs/)
    * [BFSアルゴリズム解法パターンフレームワーク](https://labuladong.online/algo/essential-technique/bfs-framework/)
    * [【強化練習】BFSクラシック問題I](https://labuladong.online/algo/problem-set/bfs/)
    * [【強化練習】BFSクラシック問題II](https://labuladong.online/algo/problem-set/bfs-ii/)
    * [更新中](https://labuladong.online/algo/intro/updating/)

### [第3章、クラシック動的計画法アルゴリズム](https://labuladong.online/algo/menu/dp/)
  * [動的計画法の基本テクニック](https://labuladong.online/algo/menu/dp-basic/)
    * [動的計画法解法パターンフレームワーク](https://labuladong.online/algo/essential-technique/dynamic-programming-framework/)
    * [動的計画法設計：最長増加部分列](https://labuladong.online/algo/dynamic-programming/longest-increasing-subsequence/)
    * [base caseとメモリの初期値はどうするか？](https://labuladong.online/algo/dynamic-programming/memo-fundamental/)
    * [動的計画法の全探索2つの視点](https://labuladong.online/algo/dynamic-programming/two-views-of-dp/)
    * [動的計画法とバックトラックの思考転換](https://labuladong.online/algo/dynamic-programming/word-break/)
    * [動的計画法の次元削減](https://labuladong.online/algo/dynamic-programming/space-optimization/)
    * [最適部分構造の原理とdp配列の走査方向](https://labuladong.online/algo/dynamic-programming/faq-summary/)

  * [部分列タイプの問題](https://labuladong.online/algo/menu/subsequence/)
    * [クラシック動的計画法：編集距離](https://labuladong.online/algo/dynamic-programming/edit-distance/)
    * [動的計画法設計：最大部分配列](https://labuladong.online/algo/dynamic-programming/maximum-subarray/)
    * [クラシック動的計画法：最長共通部分列](https://labuladong.online/algo/dynamic-programming/longest-common-subsequence/)
    * [動的計画法による部分列問題解法テンプレート](https://labuladong.online/algo/dynamic-programming/subsequence-problem/)

  * [ナップサックタイプの問題](https://labuladong.online/algo/menu/knapsack/)
    * [クラシック動的計画法：0-1ナップサック問題](https://labuladong.online/algo/dynamic-programming/knapsack1/)
    * [クラシック動的計画法：部分集合ナップサック問題](https://labuladong.online/algo/dynamic-programming/knapsack2/)
    * [クラシック動的計画法：完全ナップサック問題](https://labuladong.online/algo/dynamic-programming/knapsack3/)
    * [ナップサック問題の変種：目標和](https://labuladong.online/algo/dynamic-programming/target-sum/)

  * [動的計画法でゲームを攻略](https://labuladong.online/algo/menu/dp-game/)
    * [動的計画法による最小パス和](https://labuladong.online/algo/dynamic-programming/minimum-path-sum/)
    * [動的計画法で「魔塔」を攻略](https://labuladong.online/algo/dynamic-programming/magic-tower/)
    * [動的計画法で「Fallout 4」を攻略](https://labuladong.online/algo/dynamic-programming/freedom-trail/)
    * [旅行節約術：加重最短経路](https://labuladong.online/algo/dynamic-programming/cheap-travel/)
    * [クラシック動的計画法：正規表現マッチング](https://labuladong.online/algo/dynamic-programming/regular-expression-matching/)
    * [クラシック動的計画法：高層ビルで卵を投げる問題](https://labuladong.online/algo/dynamic-programming/egg-drop/)
    * [クラシック動的計画法：風船を割る問題](https://labuladong.online/algo/dynamic-programming/burst-balloons/)
    * [クラシック動的計画法：ゲーム理論問題](https://labuladong.online/algo/dynamic-programming/game-theory/)
    * [1つの方法でLeetCodeドロボウ問題を一網打尽](https://labuladong.online/algo/dynamic-programming/house-robber/)
    * [1つの方法でLeetCode株売買問題を一網打尽](https://labuladong.online/algo/dynamic-programming/stock-problem-summary/)

  * [貪欲タイプの問題](https://labuladong.online/algo/menu/greedy/)
    * [貪欲アルゴリズム解法パターンフレームワーク](https://labuladong.online/algo/essential-technique/greedy/)
    * [ベテランの給油アルゴリズム](https://labuladong.online/algo/frequency-interview/gas-station-greedy/)
    * [貪欲アルゴリズムによる区間スケジューリング問題](https://labuladong.online/algo/frequency-interview/interval-scheduling/)
    * [スキャンラインテクニック：会議室の割当て](https://labuladong.online/algo/frequency-interview/scan-line-technique/)
    * [動画を切り取って貪欲アルゴリズムを学ぶ](https://labuladong.online/algo/frequency-interview/cut-video/)

### [第4章、その他のよくあるアルゴリズムテクニック](https://labuladong.online/algo/menu/other/)
  * [数学的計算テクニック](https://labuladong.online/algo/menu/math/)
    * [1行コードで解けるアルゴリズム問題](https://labuladong.online/algo/frequency-interview/one-line-solutions/)
    * [よく使うビット演算](https://labuladong.online/algo/frequency-interview/bitwise-operation/)
    * [ゲームにおけるランダムアルゴリズム](https://labuladong.online/algo/frequency-interview/random-algorithm/)
    * [よく出る階乗アルゴリズム問題2問](https://labuladong.online/algo/frequency-interview/factorial-problems/)
    * [素数を効率よく探す方法](https://labuladong.online/algo/frequency-interview/print-prime-number/)
    * [効率的なべき乗のmod計算](https://labuladong.online/algo/frequency-interview/quick-power/)
    * [欠損・重複要素を同時に探す方法](https://labuladong.online/algo/frequency-interview/mismatch-set/)
    * [直感に反する確率問題いくつか](https://labuladong.online/algo/frequency-interview/probability-problem/)
    * [【強化練習】数学テクニック関連問題集](https://labuladong.online/algo/problem-set/math-tricks/)

  * [クラシック面接問題](https://labuladong.online/algo/menu/interview/)
    * [アルゴリズム筆記「点数稼ぎ」テクニック](https://labuladong.online/algo/other-skills/tips-in-exam/)
    * [雨水溜め問題を効率よく解決する方法](https://labuladong.online/algo/frequency-interview/trapping-rain-water/)
    * [全ての醜い数問題を1つの記事で攻略](https://labuladong.online/algo/frequency-interview/ugly-number-summary/)
    * [1つの方法で3つの区間問題を解決](https://labuladong.online/algo/practice-in-action/interval-problem-summary/)
    * [誰もが驚く、ドウディズでもアルゴリズムが使える](https://labuladong.online/algo/practice-in-action/split-array-into-consecutive-subsequences/)
    * [パンケーキソートアルゴリズム](https://labuladong.online/algo/frequency-interview/pancake-sorting/)
    * [文字列乗算計算](https://labuladong.online/algo/practice-in-action/multiply-strings/)
    * [完全な長方形の判定方法](https://labuladong.online/algo/frequency-interview/perfect-rectangle/)

### [付録](https://labuladong.online/algo/menu/appendix/)
  * [labuladong.online 更新履歴](https://labuladong.online/algo/changelog/website/)
  * [可視化パネルの更新履歴](https://labuladong.online/algo/changelog/visualize/)
  * [Chrome 問題解決プラグイン更新履歴](https://labuladong.online/algo/changelog/chrome/)
  * [vscode 問題解決プラグイン更新履歴](https://labuladong.online/algo/changelog/vscode/)
  * [Jetbrain 問題解決プラグイン更新履歴](https://labuladong.online/algo/changelog/jetbrain/)
  * [サイト・プラグインの問題報告](https://labuladong.online/algo/intro/bug-report/)

<!-- table end -->

# 以下の方々に翻訳協力いただきました

ニックネームのアルファベット順：

[ABCpril](https://github.com/ABCpril), 
[andavid](https://github.com/andavid), 
[bryceustc](https://github.com/bryceustc), 
[build2645](https://github.com/build2645), 
[CarrieOn](https://github.com/CarrieOn), 
[cooker](https://github.com/xiaochuhub), 
[Dong Wang](https://github.com/Coder2Programmer), 
[ExcaliburEX](https://github.com/ExcaliburEX), 
[floatLig](https://github.com/floatLig), 
[ForeverSolar](https://github.com/foreversolar), 
[Fulin Li](https://fulinli.github.io/), 
[Funnyyanne](https://github.com/Funnyyanne), 
[GYHHAHA](https://github.com/GYHHAHA), 
[Hi_archer](https://hiarcher.top/), 
[Iruze](https://github.com/Iruze), 
[Jieyixia](https://github.com/Jieyixia), 
[Justin](https://github.com/Justin-YGG), 
[Kevin](https://github.com/Kevin-free), 
[Lrc123](https://github.com/Lrc123), 
[lriy](https://github.com/lriy), 
[Lyjeeq](https://github.com/Lyjeeq), 
[MasonShu](https://greenwichmt.github.io/), 
[Master-cai](https://github.com/Master-cai), 
[miaoxiaozui2017](https://github.com/miaoxiaozui2017), 
[natsunoyoru97](https://github.com/natsunoyoru97), 
[nettee](https://github.com/nettee), 
[PaperJets](https://github.com/PaperJets), 
[qy-yang](https://github.com/qy-yang), 
[realism0331](https://github.com/realism0331), 
[SCUhzs](https://github.com/brucecat), 
[Seaworth](https://github.com/Seaworth), 
[shazi4399](https://github.com/shazi4399), 
[ShuozheLi](https://github.com/ShuoZheLi/), 
[sinjoywong](https://blog.csdn.net/SinjoyWong), 
[sunqiuming526](https://github.com/sunqiuming526), 
[Tianhao Zhou](https://github.com/tianhaoz95), 
[timmmGZ](https://github.com/timmmGZ), 
[tommytim0515](https://github.com/tommytim0515), 
[ucsk](https://github.com/ucsk), 
[wadegrc](https://github.com/wadegrc), 
[walsvid](https://github.com/walsvid), 
[warmingkkk](https://github.com/warmingkkk), 
[Wonderxie](https://github.com/Wonderxie), 
[wsyzxxxx](https://github.com/wsyzxxxx), 
[xiaodp](https://github.com/xiaodp), 
[youyun](https://github.com/youyun), 
[yx-tan](https://github.com/yx-tan), 
[Zero](https://github.com/Mr2er0), 
[Ziming](https://github.com/ML-ZimingMeng/LeetCode-Python3)

# 寄付

本リポジトリが役に立った場合、著者にインスタントコーヒー一杯をご馳走していただけると幸いです。

<img src="pictures/pay.jpg" width = "200" align=center />

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---