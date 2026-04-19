# Autology

A hot take on Lisp metaprogramming, `Autology` is a Lisp with access
to its own interpreter.

I gave a talk about this project with London Clojurians (2025-05-13):
[Autology: Writing a self-rewriting Lisp - London Clojurians (YouTube)](https://www.youtube.com/watch?v=ptN53mef_IY)

I also gave a shorter version of the same talk at Lmabda Days in Krakow (2025-06-13):
[Autology: Writing a self-rewriting Lisp - Lambda Days (YouTube)](https://www.youtube.com/watch?v=-cppTsLgVbI)

# What is it?

Autology is a functional interpreted Lisp language, written in Clojure.

The Autology interpreter function is defined as a data structure which is available to the Autology program, it is bound to the variable `*i*`.

Whenever an expression needs to be evaluated, Autology will retrieve the current value of `*i*` from the current lexically scoped execution environment and use it to evaluate the expression.

By binding new values of `*i*` we can modify the behaviour of the Autology language while our program is running.

# Why have you done this?

Mainly for fun and to explore a neat idea.

Autology is not a particularly useful language as-is, its very slow and resource intensive.

Macros are the normal tool for Lisp languages to modify their syntax or behaviour, but these are normally only available at compile time. Autology allows dynamic rewriting of the language at runtime.

Even other non-Lisp languages are able to define some form of Domain Specific Language to allow programmers to express problems more clearly, however these are generally quite restrictive in scope. Autology allows full ad-hoc re-writing of the syntax of the language, as well as defining new features or removing existing ones.

# Usage

You can run an autology program using the `autology` script in the project root:

``` Bash
./autology foo.atl
```
There are several example programs provided to get you started:


``` Bash
./autology resources/examples/eval-order-1.atl

./autology resources/examples/eval-order-2.atl
```

You can also run a REPL by passing no args:

``` Bash
./autology
```

@NOTE: the REPL could really use some work.

# What can you do with it?

Well to start with you might like to add functions to the language. Autology doesn't have them by default, but we can rebind the `*i*` symbol to a data structure representing a new interpreter function, one that does have functions.

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

After that, pretty much anything you want!

- Why not switch from applicative order evaluation to normal order evaluation?
- Maybe modify the language so it uses a continuation passing style?
- Define a metacircular Lisp inside your program which has access to its own interpreter as well as the Autology interpreter.

# Run tests

```bash
clojure -X:test
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-19

---