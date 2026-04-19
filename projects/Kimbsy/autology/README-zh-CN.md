# Autology

关于 Lisp 元编程的一个热门观点，`Autology` 是一个可以访问自身解释器的 Lisp。

我在伦敦 Clojurians（2025-05-13）做过关于这个项目的演讲：
[Autology: Writing a self-rewriting Lisp - London Clojurians (YouTube)](https://www.youtube.com/watch?v=ptN53mef_IY)

我也在克拉科夫的 Lambda Days（2025-06-13）做过同一演讲的简短版：
[Autology: Writing a self-rewriting Lisp - Lambda Days (YouTube)](https://www.youtube.com/watch?v=-cppTsLgVbI)

# 它是什么？

Autology 是一个函数式解释型 Lisp 语言，用 Clojure 编写。

Autology 解释器函数被定义为一个数据结构，Autology 程序可以访问它，它绑定在变量 `*i*` 上。

每当需要求值一个表达式时，Autology 会从当前词法作用域的执行环境中获取 `*i*` 的当前值，并用它来求值该表达式。

通过绑定新的 `*i*` 值，我们可以在程序运行时修改 Autology 语言的行为。

# 为什么要做这个？

主要是为了乐趣和探索一个有趣的想法。

Autology 本身并不是一个特别实用的语言，它非常慢且资源消耗大。

宏是 Lisp 语言修改语法或行为的常用工具，但这些通常只在编译时可用。Autology 允许在运行时动态重写语言。

即使是其他非 Lisp 语言也能定义某种领域特定语言来让程序员更清晰地表达问题，但这些通常范围相当有限。Autology 允许完全临时重写语言的语法，同时定义新特性或移除现有特性。

# 使用方法

你可以使用项目根目录下的 `autology` 脚本来运行 autology 程序：


``` Bash
./autology foo.atl
```
有几个示例程序可供您入门：


``` Bash
./autology resources/examples/eval-order-1.atl

./autology resources/examples/eval-order-2.atl
```
您也可以通过不传递任何参数来运行 REPL：


``` Bash
./autology
```

@注意：REPL 确实需要改进。

# 你能用它做什么？

首先你可能想给语言添加函数。Autology 默认没有函数，但我们可以重新绑定 `*i*` 符号到一个表示新解释器函数的数据结构，这个解释器确实支持函数。

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
之后，几乎任何你想要的东西！

- 为什么不将求值策略从应用序求值切换到正常序求值？
- 也许修改语言，使其使用续延传递风格？
- 在你的程序内定义一个元循环 Lisp，该 Lisp 不仅能访问自身的解释器，还能访问自指解释器。

# 运行测试


```bash
clojure -X:test
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-19

---