# Autology

Una opinión contundente sobre la metaprogramación en Lisp, `Autology` es un Lisp con acceso
a su propio intérprete.

Di una charla sobre este proyecto con London Clojurians (2025-05-13):
[Autology: Writing a self-rewriting Lisp - London Clojurians (YouTube)](https://www.youtube.com/watch?v=ptN53mef_IY)

También di una versión más corta de la misma charla en Lambda Days en Cracovia (2025-06-13):
[Autology: Writing a self-rewriting Lisp - Lambda Days (YouTube)](https://www.youtube.com/watch?v=-cppTsLgVbI)

# ¿Qué es?

Autology es un lenguaje Lisp funcional interpretado, escrito en Clojure.

La función intérprete de Autology está definida como una estructura de datos que está disponible para el programa Autology, está ligada a la variable `*i*`.

Cada vez que se necesita evaluar una expresión, Autology recuperará el valor actual de `*i*` desde el entorno de ejecución con ámbito léxico actual y lo usará para evaluar la expresión.

Al ligar nuevos valores a `*i*` podemos modificar el comportamiento del lenguaje Autology mientras nuestro programa se está ejecutando.

# ¿Por qué lo has hecho?

Principalmente por diversión y para explorar una idea interesante.

Autology no es un lenguaje particularmente útil tal como está, es muy lento y consume muchos recursos.

Las macros son la herramienta normal en los lenguajes Lisp para modificar su sintaxis o comportamiento, pero normalmente sólo están disponibles en tiempo de compilación. Autology permite la reescritura dinámica del lenguaje en tiempo de ejecución.

Incluso otros lenguajes no Lisp pueden definir alguna forma de Lenguaje Específico de Dominio para permitir a los programadores expresar problemas con mayor claridad, sin embargo, estos son generalmente bastante restrictivos en alcance. Autology permite la reescritura ad-hoc completa de la sintaxis del lenguaje, así como definir nuevas características o eliminar las existentes.

# Uso

Puedes ejecutar un programa autology usando el script `autology` en la raíz del proyecto:

``` Bash
./autology foo.atl
```

Se proporcionan varios programas de ejemplo para ayudarte a comenzar:

``` Bash
./autology resources/examples/eval-order-1.atl

./autology resources/examples/eval-order-2.atl
```

También puedes ejecutar un REPL sin pasar argumentos:

``` Bash
./autology
```

@NOTA: el REPL realmente podría mejorarse.

# ¿Qué puedes hacer con él?

Bueno, para empezar, quizás te gustaría añadir funciones al lenguaje. Autology no las tiene por defecto, pero podemos reasignar el símbolo `*i*` a una estructura de datos que representa una nueva función del intérprete, una que sí tenga funciones.

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

¡Después de eso, prácticamente cualquier cosa que quieras!

- ¿Por qué no cambiar la evaluación de orden aplicativo a evaluación de orden normal?
- ¿Quizás modificar el lenguaje para que use un estilo de paso de continuaciones?
- Definir un Lisp metacircular dentro de tu programa que también tenga acceso a su propio intérprete así como al intérprete de Autology.

# Ejecutar pruebas

```bash
clojure -X:test
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-19

---