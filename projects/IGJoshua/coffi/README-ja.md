# coffi
[![Clojars Project](https://img.shields.io/clojars/v/org.suskalo/coffi.svg)](https://clojars.org/org.suskalo/coffi)
[![cljdoc badge](https://cljdoc.org/badge/org.suskalo/coffi)](https://cljdoc.org/d/org.suskalo/coffi)

Coffiは、JDK 22以降の[Foreign Function & Memory API](https://openjdk.org/jeps/454)を使用したClojure向けの外国関数インターフェースライブラリです。  
これにより、JNIのようにライブラリ固有のJavaやネイティブコードを必要とせず、Clojureから直接ネイティブコードを呼び出すことができます。Coffiは使いやすさに重点を置いており、結果として得られるネイティブ関数をClojureの関数のように振る舞わせるためのラッパー作成用の関数やマクロを含みます。ただし、これはデータのマーシャリングコストを最小化しパフォーマンス最適化を行うシステムを書く能力を損なうものではなく、FF&M APIが提供する低レベルアクセスを活用できます。

- [はじめに](https://cljdoc.org/d/org.suskalo/coffi/CURRENT/doc/getting-started)
- [APIドキュメント](https://cljdoc.org/d/org.suskalo/coffi/CURRENT/api/coffi)
- [最近の変更](https://raw.githubusercontent.com/IGJoshua/coffi/develop/CHANGELOG.md)

## インストール
このライブラリはClojarsまたはgit依存関係として利用可能です。  
`deps.edn`の`:deps`キーに以下のいずれかのエントリを追加してください：








```clojure
org.suskalo/coffi {:mvn/version "1.0.615"}
io.github.IGJoshua/coffi {:git/tag "v1.0.615" :git/sha "7401485"}
```

このライブラリをgit依存関係として使用する場合は、ライブラリを準備する必要があります。


```sh
$ clj -X:deps prep
```

Coffiは`java.lang.foreign`パッケージの使用を必要とし、多くの操作はJDKによって安全でないと見なされているため、
これらの操作はコマンドラインフラグを渡さない限りコードで使用できません。coffiを使用するには、
アプリケーションに以下のJVM引数を追加してください。


```sh
--enable-native-access=ALL-UNNAMED
```

Clojure CLIの特定の呼び出しでJVM引数を指定するには、
次のように`-J`フラグを使用します:

``` sh
clj -J--enable-native-access=ALL-UNNAMED
```

`deps.edn` ファイルのエイリアスで `:jvm-opts` キーの下に指定することもできます（次の例を参照）  
そして、そのエイリアスを使って CLI を `-M`、`-A`、または `-X` で呼び出します。


``` clojure
{:aliases {:dev {:jvm-opts ["--enable-native-access=ALL-UNNAMED"]}}}
```
他のビルドツールでも、ドキュメントを確認すれば同様の機能が提供されているはずです。

実行可能なjarファイルを作成する際、この引数を渡す必要を避けるには、
マニフェスト属性 `Enable-Native-Access: ALL-UNNAMED` をjarに追加します。
追加方法はビルドツールのドキュメントを参照してください。

Coffiはlinterであるclj-kondoのサポートも含んでいます。
clj-kondoを使用していて、このライブラリのマクロが正しくlintされない場合、
ライブラリにバンドルされている設定をインストールする必要があります。
プロジェクトディレクトリから以下のシェルコマンドを実行してください：



```sh
$ clj-kondo --copy-configs --dependencies --lint "$(clojure -Spath)"
```

## 使用方法
主な名前空間は、オフヒープメモリの割り当てと操作、値の(デ)シリアライズを提供する `coffi.mem` と、
ネイティブライブラリの読み込み、ネイティブ関数ラッパーの宣言、コールバックとしての関数の(デ)シリアライズを行う `coffi.ffi` です。



```clojure
(require '[coffi.mem :as mem])
(require '[coffi.ffi :as ffi :refer [defcfn]])

(defcfn strlen
  "Given a string, measures its length in bytes."
  strlen [::mem/c-string] ::mem/long)

(strlen "hello")
;; => 5

(ffi/load-system-library "z")
```
`coffi.mem` 名前空間には、Cのすべての符号付きプリミティブ数値型の型に加え、`::mem/pointer` および `::mem/c-string` があり、malli風の型宣言を用いて構造体、共用体、配列、列挙型、フラグセットを定義する方法があります。

## 代替案
このライブラリはネイティブコードへのアクセスを提供するClojureライブラリの唯一のものではありません。以下のライブラリ（その他多数も含む）が存在します：

- [dtype-next](https://github.com/cnuernber/dtype-next)
- [tech.jna](https://github.com/techascent/tech.jna)
- [clojure-jna](https://github.com/Chouser/clojure-jna)

Dtype-nextはJava 8-15、17+、およびGraalVMをサポートしていますが、配列ベースのプログラミングに強く焦点を当てており、Clojureネイティブの構造体へのデータマーシャリングではなく、メモリをネイティブ側に保持することに重点を置いています。Java 17+では、これはForeign Function & Memory API（JDK 22で安定化するまでProject Panamaの一部）を使用し、他のJavaバージョンではJNAを使用します。

Tech.jnaとclojure-jnaはどちらもすべてのケースでJNAライブラリを使用し、コールバックの明示的なサポートは提供していません。JNAは `java.nio.ByteBuffer` を使用して構造体を値渡しすることを可能にし、両ライブラリはこの値渡し構造を使って参照渡しAPIを呼び出す方法を提供しています。

coffiのもう一つの代替案はJNIを直接使用することで、これはJVMでネイティブコードをラップする最も歴史の長い方法ですが、Clojureからのみ使用する場合でもネイティブコードとJavaコードの両方を書く必要があるという欠点があります。

アプリケーションがJVMの22以前のバージョンで動作する必要がある場合は、これらの他のオプションを検討すべきです。Dtype-nextはネイティブコードのサポートが最も強力ですが、単純なライブラリをラップする場合は、APIの表面積が小さく関数をラップしやすいため他のライブラリの方が魅力的かもしれません。

また、Clojure用のFFIオプションの[サードパーティまとめ](https://docs.google.com/spreadsheets/d/1ViLHNUgrO2osh2AH0h7MaCaXz8g0UpLbyWojY5f10kk/edit?gid=332155605#gid=332155605)もあります。






















## 既知の問題
プロジェクトの作者はこれらの問題を認識しており、将来のリリースで修正する予定です：

- coffi に依存するライブラリで codox を使ってドキュメントを生成すると、以下のエラーが発生します。暫定的な対処法として、codox ビルドにバージョン 0.2.1 の insn を明示的な依存関係として追加してください。

  ```
  Unable to find static field: ACC_OPEN in interface org.objectweb.asm.Opcodes
  ```
## 将来の計画
これらの機能は将来のリリースで予定されています。

- va_args 型のサポート
- データモデル生成のためのヘッダ解析ツール？（おそらく [clong](https://github.com/phronmophobic/clong) と連携？）
- ジェネリック型エイリアス
- 符号なし整数型
- アウト引数用のヘルパーマクロ
- defcfn マクロからのエラーメッセージの改善
- マップドメモリ
- より複合的なデータ型向けのカスタム serde 実装用ヘルパーマクロ
- GraalVM Native Image のサポート（FFM のサポートが成熟次第）

## ライセンス

著作権 © 2023 Joshua Suskalo

Eclipse Public License バージョン 1.0 の下で配布されています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-30

---