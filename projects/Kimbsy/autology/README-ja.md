# Autology

Lispのメタプログラミングに関するホットな考察である `Autology` は、自身のインタプリタにアクセスできるLispです。

このプロジェクトについてロンドンClojuriansで講演しました（2025-05-13）：
[Autology: Writing a self-rewriting Lisp - London Clojurians (YouTube)](https://www.youtube.com/watch?v=ptN53mef_IY)

また、クラクフで開催されたLambda Daysで同じ講演の短縮版も行いました（2025-06-13）：
[Autology: Writing a self-rewriting Lisp - Lambda Days (YouTube)](https://www.youtube.com/watch?v=-cppTsLgVbI)

# これは何ですか？

Autologyは、Clojureで書かれた関数型のインタプリタ型Lisp言語です。

Autologyのインタプリタ関数はデータ構造として定義されており、Autologyプログラムから利用可能で、変数 `*i*` にバインドされています。

式を評価する必要があるとき、Autologyは現在のレキシカルスコープの実行環境から `*i*` の現在の値を取得し、それを使って式を評価します。

`*i*` に新しい値をバインドすることで、プログラムの実行中にAutology言語の振る舞いを変更できます。

# なぜこれをやったのですか？

主に楽しみと興味深いアイデアの探求のためです。

Autologyはそのままでは特に有用な言語ではなく、とても遅くリソースを多く消費します。

マクロはLisp言語で文法や振る舞いを変更するための通常のツールですが、通常はコンパイル時にのみ利用可能です。Autologyは実行時に言語の動的書き換えを可能にします。

他の非Lisp言語でも、問題をより明確に表現するためにドメイン特化言語（DSL）を定義できますが、これらは一般に範囲がかなり限定的です。Autologyは言語の文法を完全にアドホックに書き換え、新機能の定義や既存機能の削除も可能にします。

# 使用法

プロジェクトルートの `autology` スクリプトを使ってautologyプログラムを実行できます：


``` Bash
./autology foo.atl
```
開始するためのいくつかのサンプルプログラムが提供されています：


``` Bash
./autology resources/examples/eval-order-1.atl

./autology resources/examples/eval-order-2.atl
```

引数を渡さずに実行すると、REPLも起動できます：

``` Bash
./autology
```

@注意: REPLは本当に改良の余地があります。

# 何ができるの？

まずは言語に関数を追加したくなるかもしれません。Autologyにはデフォルトで関数はありませんが、`*i*`シンボルを新しいインタープリタ関数を表すデータ構造に再バインドすることができます。その関数は関数を持っています。

```Clojure
(bind (;; grab a copy of the `:atl/eval-list` section of the
       ;; interpreter which is responsible for evaluating lists.
       original (get-marker *i* :atl/eval-list)

       ;; define a case test+body for use when the list expression
       ;; starts with our function special form, in this case `λ`.
       λ-form (qu (λ (let [[_λ params body] e]
                       (fn [& values]
                         (autology.core/evaluate
                          body
                          (reduce (fn [acc-env [s v]]
                                    (assoc acc-env s v))
                                  env
                                  (zipmap params values)))))))

       ;; rebind `*i*` to be a new interpreter with the
       ;; `:atl/eval-list` section replaced with a version that
       ;; includes our lambda handling special form.
       *i* (replace-marker *i* :atl/eval-list
                           (list :atl/eval-list
                                 (concat (butlast original)
                                         λ-form
                                         (list (last original)))))

       ;; We can now immediately define functions since the
       ;; interpreter will have already been updated to evaluate the
       ;; remaining bindings like this one.
       double (λ (n)
                 (+ n n)))

      ;; Finally we can invoke our new function!
      (double (double (double (double (double 1.3125))))))
```
その後は、ほとんど何でも好きなことができます！

- なぜ適用順評価から正規順評価に切り替えないのですか？
- 言語を変更して継続渡しスタイルを使うのはどうでしょうか？
- プログラム内に自己のインタプリタとAutologyインタプリタの両方にアクセスできるメタサーキュラーLispを定義する。

# テストを実行する


```bash
clojure -X:test
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-19

---