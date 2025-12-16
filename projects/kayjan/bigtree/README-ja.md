# Big Tree Python パッケージ

Python向けのツリー実装とメソッドで、リスト、辞書、pandasおよびpolarsのDataFrameと統合されています。

Pythonらしく、学習しやすく多様なワークフローに拡張可能です。

----

関連リンク：
- [ドキュメント](https://bigtree.readthedocs.io/)
- [GitHub](https://github.com/kayjan/bigtree/)
- コミュニティ
  - [Issues](https://github.com/kayjan/bigtree/issues)
  / [Discussions](https://github.com/kayjan/bigtree/discussions)
  / [Changelog](https://github.com/kayjan/bigtree/blob/master/CHANGELOG.md)
  / [Contributing](https://bigtree.readthedocs.io/stable/home/contributing/)
- パッケージ
  - [PyPI](https://pypi.org/project/bigtree/)
  / [Conda](https://anaconda.org/conda-forge/bigtree)
- 記事
  - [BigTreeによるPythonのツリー実装](https://medium.com/data-science/python-tree-implementation-with-bigtree-13cdabd77adc#245a-94ae81f0b3f1)
  - [Reingold-Tilfordアルゴリズムの説明とウォークスルー](https://medium.com/data-science/reingold-tilford-algorithm-explained-with-walkthrough-be5810e8ed93?sk=2db8e10398cee76c486c4b06b0b33322)
- <div><p>bigtreeをサポートしたい方は、<a href="https://www.buymeacoffee.com/kayjan"><img src="https://img.shields.io/badge/Buy_Me_A_Coffee-FFDD00?style=for-the-badge&logo=buy-me-a-coffee&logoColor=black" alt="Buy Me a Coffee" style="vertical-align:middle"></a></p></div>

-----

## コンポーネント
Big Treeは、ツリー、二分木、そして有向非巡回グラフ（DAG）の3つのセグメントで構成されています。

**ツリー**実装には、12の主要コンポーネントがあります。

1. [**🌺 ノード**](https://bigtree.readthedocs.io/stable/bigtree/node/node/)
   1. ``BaseNode``, 拡張可能なクラス
   2. ``Node``, ノード名属性を持つBaseNode
2. [**🎄 ツリー**](https://bigtree.readthedocs.io/stable/bigtree/tree/tree/)
   1. ``Tree``, ``Node``をラップし、ツリー全体の構築、反復、クエリ、エクスポートのための高レベルAPIを提供
3. [**✨ ツリーの構築**](https://bigtree.readthedocs.io/stable/bigtree/tree/construct/)
   1. `Node`から、親子コンストラクタを使用
   2. *str*から、ツリー表示やNewick文字列表記を使用
   3. *list*から、パスや親子タプルを使用
   4. *ネストされた辞書* から、パス属性のキー・バリューのペアまたは再帰的構造を使用して
   5. *pandas DataFrame* から、パスまたは親子カラムを使用して
   6. *polars DataFrame* から、パスまたは親子カラムを使用して
   7. *インタラクティブUI* から
   8. パス文字列を使用して既存のツリーにノードを追加
   9. パスを使用して *辞書*、*pandas DataFrame*、または *polars DataFrame* から既存のツリーにノードと属性を追加
   10. ノード名を使用して *辞書*、*pandas DataFrame*、または *polars DataFrame* から既存のツリーに属性のみを追加
4. [**➰ ツリーの走査**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)
   1. 前順走査
   2. 後順走査
   3. レベル順走査
   4. レベル順グループ走査
   5. ジグザグ走査
   6. ジグザググループ走査
5. [**🧩 ツリーの解析**](https://bigtree.readthedocs.io/stable/bigtree/tree/parsing/)
   1. ノード間の共通祖先を取得
   2. あるノードから別のノードへのパスを取得
6. [**📝 ツリーの変更**](https://bigtree.readthedocs.io/stable/bigtree/tree/modify/)
   1. ノードをある場所から別の場所へコピー
   2. ノードをある場所から別の場所へ移動
   3. ノードをある場所から別の場所へ移動して置換
   4. ノードをあるツリーから別のツリーへコピー
   5. ノードをあるツリーから別のツリーへコピーして置換
7. [**📌 ツリーのクエリ**](https://bigtree.readthedocs.io/stable/bigtree/tree/query/)
   1. Tree Query Language を使用してツリーをフィルタリング
8. [**🔍 ツリー検索**](https://bigtree.readthedocs.io/stable/bigtree/tree/search/)
   1. 名前、部分パス、相対パス、属性値、ユーザー定義条件に基づいて複数ノードを検索
   2. 名前、部分パス、相対パス、完全パス、属性値、ユーザー定義条件に基づいて単一ノードを検索
   3. ユーザー定義条件に基づいて複数の子ノードを検索
   4. 名前、ユーザー定義条件に基づいて単一の子ノードを検索
9. [**🔧 ヘルパー関数**](https://bigtree.readthedocs.io/stable/bigtree/tree/helper/)
   1. 別の `Node` タイプへのツリーのクローン作成
   2. 部分ツリーを取得（異なるルートの小さいツリー）
   3. ツリーを剪定（同じルートの小さいツリー）
   4. 2つのツリーの差分を取得
10. [**📊 ツリーの描画**](https://bigtree.readthedocs.io/stable/bigtree/utils/plot/)
   1. 拡張Reingold-Tilfordアルゴリズムによるツリー構造の (x, y) 座標取得
   2. matplotlib（オプション依存）を使用したツリーの描画
11. [**🔨 ツリーのエクスポート**](https://bigtree.readthedocs.io/stable/bigtree/tree/export/)
   1. 縦方向または横方向の向きでコンソールに出力
   2. *Newick文字列表記*、*辞書*、*ネスト辞書*、*pandas DataFrame*、または*polars DataFrame*へのエクスポート
   3. ツリーを*dot*へエクスポート（.dot、.png、.svg、.jpegファイルに保存可能）
   4. ツリーを*Pillow*へエクスポート（.png、.jpgに保存可能）
   5. ツリーを*Mermaidフローチャート*へエクスポート（.md上で表示可能）
   6. ツリーを*Pyvisネットワーク*へエクスポート（インタラクティブな.htmlで表示可能）
12. [**✔️ ワークフロー**](https://bigtree.readthedocs.io/stable/bigtree/workflows/app_todo)
   1. ツリーのデモ用サンプルワークフロー！

--------

**二分木（Binary Tree）**の実装には4つの主要なコンポーネントがあります。
Binary NodeはNodeを継承しているため、Tree実装のコンポーネントもBinary Treeで利用可能です。

1. [**🌿 ノード**](https://bigtree.readthedocs.io/stable/bigtree/node/binarynode)
   1. ``BinaryNode``、二分木のルールを持つノード
2. [**🎄 二分木**](https://bigtree.readthedocs.io/stable/bigtree/binarytree/binarytree/)
   1. ``BinaryTree``、``BinaryNode``をラップし、高レベルのAPIでツリー全体の構築、反復、問い合わせ、エクスポートを提供
3. [**✨ 二分木の構築**](https://bigtree.readthedocs.io/stable/bigtree/binarytree/construct/)
   1. *リスト*から、平坦化されたリスト構造を使用
4. [**➰ 二分木の走査**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)
   1. 中間順走査

-----

**有向非巡回グラフ（DAG）**の実装には6つの主要なコンポーネントがあります。

1. [**🌼 ノード**](https://bigtree.readthedocs.io/stable/bigtree/node/dagnode/)
   1. ``DAGNode``、有向非巡回グラフ（DAG）構築用の拡張可能なクラス
2. [**🎄 DAG**](https://bigtree.readthedocs.io/stable/bigtree/dag/dag/)
   1. ``DAG``、``DAGNode``をラップし、高レベルのAPIでDAG全体の構築、エクスポート、反復を提供
3. [**✨ DAGの構築**](https://bigtree.readthedocs.io/stable/bigtree/dag/construct/)
   1. *リスト*から、親子のタプルを含む
   2. *ネスト辞書*から
   3. *pandas DataFrame*から
4. [**➰ DAGの走査**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)
   1. 汎用的な走査メソッド
5. [**🧩 DAGの解析**](https://bigtree.readthedocs.io/stable/bigtree/dag/parsing/)
   1. あるノードから別のノードへの可能な経路を取得
6. [**🔨 DAGのエクスポート**](https://bigtree.readthedocs.io/stable/bigtree/dag/export/)
   1. *リスト*、*辞書*、または*pandas DataFrame*へエクスポート
   2. DAGを*dot*形式でエクスポート（.dot、.png、.svg、.jpegファイルに保存可能）

-----

## インストール

`bigtree`はPython 3.10以上が必要です。`bigtree`のインストール方法は、pip（推奨）かcondaの2つがあります。

### a) pipでのインストール

#### 基本インストール

`bigtree`をインストールするには、コマンドプロンプトで以下の行を実行してください：

```console
$ pip install bigtree
```

#### オプション依存関係のインストール

`bigtree` にはいくつかのオプション依存関係があり、「extras」構文を使ってインストールできます。

```console
$ pip install 'bigtree[extra_1, extra_2]'
```
追加パッケージの例は以下の通りです:

- `all`: すべてのオプション依存関係を含む
- `image`: ツリーを画像にエクスポートするため
- `matplotlib`: ツリーをプロットするため
- `pandas`: pandas メソッド用
- `polars`: polars メソッド用
- `query`: ツリークエリメソッド用
- `vis`: pyvis ビジュアライゼーション用

`image` 追加依存関係の場合、さらにプラグインをインストールする必要があります。


```console
$ brew install gprof2dot  # for MacOS
$ conda install graphviz  # for Windows
```

### b) condaによるインストール

`bigtree`をcondaでインストールするには、コマンドプロンプトで次の行を実行してください:

```console
$ conda install -c conda-forge bigtree
```

-----

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=kayjan/bigtree&type=Date)](https://star-history.com/#kayjan/bigtree&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---