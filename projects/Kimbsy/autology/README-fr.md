# Autology

Une prise de position audacieuse sur la métaprogrammation Lisp, `Autology` est un Lisp avec accès
à son propre interpréteur.

J'ai donné une conférence sur ce projet avec London Clojurians (2025-05-13) :
[Autology : Écrire un Lisp auto-réécrivant - London Clojurians (YouTube)](https://www.youtube.com/watch?v=ptN53mef_IY)

J'ai également donné une version plus courte de la même conférence à Lambda Days à Cracovie (2025-06-13) :
[Autology : Écrire un Lisp auto-réécrivant - Lambda Days (YouTube)](https://www.youtube.com/watch?v=-cppTsLgVbI)

# Qu'est-ce que c'est ?

Autology est un langage Lisp fonctionnel interprété, écrit en Clojure.

La fonction interprète Autology est définie comme une structure de données disponible pour le programme Autology, elle est liée à la variable `*i*`.

Chaque fois qu'une expression doit être évaluée, Autology récupère la valeur actuelle de `*i*` depuis l'environnement d'exécution à portée lexicale courante et l'utilise pour évaluer l'expression.

En liant de nouvelles valeurs à `*i*`, nous pouvons modifier le comportement du langage Autology pendant l'exécution de notre programme.

# Pourquoi avez-vous fait cela ?

Principalement pour le plaisir et pour explorer une idée intéressante.

Autology n'est pas un langage particulièrement utile en l'état, il est très lent et gourmand en ressources.

Les macros sont l'outil normal des langages Lisp pour modifier leur syntaxe ou comportement, mais elles ne sont généralement disponibles qu'à la compilation. Autology permet la réécriture dynamique du langage à l'exécution.

Même d'autres langages non Lisp peuvent définir une forme de langage spécifique au domaine pour permettre aux programmeurs d'exprimer les problèmes plus clairement, mais ceux-ci sont généralement assez restrictifs en portée. Autology permet une réécriture ad hoc complète de la syntaxe du langage, ainsi que la définition de nouvelles fonctionnalités ou la suppression d'existantes.

# Utilisation

Vous pouvez exécuter un programme autology en utilisant le script `autology` à la racine du projet :

``` Bash
./autology foo.atl
```

Plusieurs programmes exemples sont fournis pour vous aider à démarrer :

``` Bash
./autology resources/examples/eval-order-1.atl

./autology resources/examples/eval-order-2.atl
```

Vous pouvez également lancer un REPL sans passer d’arguments :

``` Bash
./autology
```

@NOTE : le REPL pourrait vraiment être amélioré.

# Que pouvez-vous en faire ?

Pour commencer, vous pourriez vouloir ajouter des fonctions au langage. Autology ne les possède pas par défaut, mais nous pouvons réaffecter le symbole `*i*` à une structure de données représentant une nouvelle fonction d'interpréteur, une qui possède des fonctions.

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

Après cela, pratiquement tout ce que vous voulez !

- Pourquoi ne pas passer de l’évaluation en ordre applicatif à l’évaluation en ordre normal ?
- Peut-être modifier le langage pour qu’il utilise un style de passage de continuation ?
- Définir un Lisp métacirculaire à l’intérieur de votre programme qui ait accès à son propre interpréteur ainsi qu’à l’interpréteur Autology.

# Exécuter les tests

```bash
clojure -X:test
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-19

---