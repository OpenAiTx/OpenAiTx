# coffi
[![Projet Clojars](https://img.shields.io/clojars/v/org.suskalo/coffi.svg)](https://clojars.org/org.suskalo/coffi)
[![badge cljdoc](https://cljdoc.org/badge/org.suskalo/coffi)](https://cljdoc.org/d/org.suskalo/coffi)

Coffi est une bibliothèque d'interface de fonction étrangère pour Clojure, utilisant l'[API de fonction et mémoire étrangères](https://openjdk.org/jeps/454) dans JDK 22 et versions ultérieures. Cela permet d'appeler du code natif directement depuis Clojure sans besoin de code Java ou natif spécifique à la bibliothèque, comme le fait par exemple JNI. Coffi met l'accent sur la facilité d'utilisation, incluant des fonctions et macros pour créer des wrappers permettant aux fonctions natives résultantes d'agir comme des fonctions Clojure, cependant cela n'empêche pas d'écrire des systèmes qui minimisent le coût de la sérialisation des données et optimisent la performance, pour exploiter l'accès bas niveau que l'API FF&M nous offre.

- [Commencer](https://cljdoc.org/d/org.suskalo/coffi/CURRENT/doc/getting-started)
- [Documentation API](https://cljdoc.org/d/org.suskalo/coffi/CURRENT/api/coffi)
- [Modifications récentes](https://raw.githubusercontent.com/IGJoshua/coffi/develop/CHANGELOG.md)

## Installation
Cette bibliothèque est disponible sur Clojars, ou en tant que dépendance git. Ajoutez une des entrées suivantes à la clé `:deps` de votre `deps.edn` :










```clojure
org.suskalo/coffi {:mvn/version "1.0.615"}
io.github.IGJoshua/coffi {:git/tag "v1.0.615" :git/sha "7401485"}
```

Si vous utilisez cette bibliothèque comme dépendance git, vous devrez préparer la
bibliothèque.

```sh
$ clj -X:deps prep
```
Coffi nécessite l’utilisation du paquet `java.lang.foreign`, et la plupart des  
opérations sont considérées comme non sécurisées par le JDK, et sont donc  
inaccessibles à votre code sans passer certains arguments en ligne de commande.  
Pour utiliser coffi, ajoutez les arguments JVM suivants à votre application.


```sh
--enable-native-access=ALL-UNNAMED
```

Vous pouvez spécifier des arguments JVM dans une invocation particulière du Clojure CLI avec
le drapeau `-J` de cette manière :

``` sh
clj -J--enable-native-access=ALL-UNNAMED
```

Vous pouvez également les spécifier dans un alias dans votre fichier `deps.edn` sous la clé
`:jvm-opts` (voir l'exemple suivant) puis invoquer l'interface CLI avec cet alias
en utilisant `-M`, `-A` ou `-X`.

``` clojure
{:aliases {:dev {:jvm-opts ["--enable-native-access=ALL-UNNAMED"]}}}
```

D'autres outils de construction devraient fournir une fonctionnalité similaire si vous consultez leur
documentation.

Lors de la création d'un fichier jar exécutable, vous pouvez éviter la nécessité de passer cet
argument en ajoutant l'attribut de manifeste `Enable-Native-Access: ALL-UNNAMED` à
votre jar. Consultez la documentation de votre outil de construction pour savoir comment l'ajouter.

Coffi inclut également le support pour le linter clj-kondo. Si vous utilisez clj-kondo et que
les macros de cette bibliothèque ne sont pas analysées correctement, vous devrez peut-être installer la
configuration fournie avec la bibliothèque. Vous pouvez le faire avec la commande shell suivante,
exécutée depuis le répertoire de votre projet :

```sh
$ clj-kondo --copy-configs --dependencies --lint "$(clojure -Spath)"
```

## Utilisation
Les deux principaux espaces de noms sont `coffi.mem` qui fournit des fonctions pour allouer
et manipuler la mémoire hors tas ainsi que (dé)sérialiser des valeurs, et `coffi.ffi`
qui peut charger des bibliothèques natives, déclarer des wrappers de fonctions natives, et
(dé)sérialiser des fonctions en tant que callbacks.

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
Dans l’espace de noms `coffi.mem`, il existe des types pour tous les types numériques primitifs signés en C, plus `::mem/pointer` et `::mem/c-string`, ainsi que des moyens d’utiliser des déclarations de type de style malli pour définir des structs, unions, tableaux, enums et ensembles de flags.

## Alternatives  
Cette bibliothèque n’est pas la seule bibliothèque Clojure offrant un accès au code natif. En outre, les bibliothèques suivantes (entre autres) existent :

- [dtype-next](https://github.com/cnuernber/dtype-next)  
- [tech.jna](https://github.com/techascent/tech.jna)  
- [clojure-jna](https://github.com/Chouser/clojure-jna)  

Dtype-next prend en charge les versions Java 8-15, 17+, et GraalVM, mais est fortement axé sur la programmation basée sur les tableaux, ainsi que sur le maintien de la mémoire côté natif plutôt que sur le passage des données vers et depuis des structures natives de Clojure. En Java 17+, il utilise l’API Foreign Function & Memory (une partie du projet Panama jusqu’à sa stabilisation dans JDK 22), tandis que dans d’autres versions de Java, il utilise JNA.

Tech.jna et clojure-jna utilisent tous deux la bibliothèque JNA dans tous les cas, et aucun ne fournit de support explicite pour les callbacks. JNA permet l’utilisation de `java.nio.ByteBuffer`s pour passer des structs par valeur, et les deux bibliothèques offrent des moyens d’utiliser cette construction par valeur pour appeler des API par référence.

Une autre alternative à coffi est d’utiliser directement le JNI, qui est la méthode la plus ancienne d’encapsulation du code natif dans la JVM, mais présente l’inconvénient de nécessiter d’écrire à la fois du code natif et du code Java, même si vous ne souhaitez l’utiliser qu’à partir de Clojure.

Si votre application doit pouvoir s’exécuter sur des versions antérieures de la JVM à la 22, vous devriez envisager ces autres options. Dtype-next offre le support le plus robuste pour le code natif, mais si vous encapsulez une bibliothèque simple, les autres bibliothèques peuvent être plus attrayantes, car elles ont une surface d’API plus petite et il est plus facile d’encapsuler des fonctions.

Il existe également un [tour d’horizon tiers](https://docs.google.com/spreadsheets/d/1ViLHNUgrO2osh2AH0h7MaCaXz8g0UpLbyWojY5f10kk/edit?gid=332155605#gid=332155605) des options FFI pour Clojure.






















## Problèmes connus
L'auteur du projet est conscient de ces problèmes et prévoit de les corriger dans une future
version :

- Lors de la génération de la documentation avec codox dans une bibliothèque qui dépend de coffi, l'erreur ci-dessous sera produite. Une solution temporaire consiste à ajouter une dépendance explicite dans votre build codox sur insn en version 0.2.1
  ```
  Unable to find static field: ACC_OPEN in interface org.objectweb.asm.Opcodes
  ```
## Plans Futurs
Ces fonctionnalités sont prévues pour les futures versions.

- Prise en charge du type va_args
- Outil d'analyse d'en-tête pour générer un modèle de données ? (peut-être simplement travailler avec [clong](https://github.com/phronmophobic/clong) ?)
- Alias de types génériques
- Types entiers non signés
- Macro d’aide pour les arguments de sortie
- Améliorer les messages d’erreur de la macro defcfn
- Mémoire mappée
- Macros d’aide pour les implémentations serde personnalisées pour des types de données plus composites
- Prise en charge de GraalVM Native Image (une fois que leur support pour FFM sera mature)

## Licence

Droits d’auteur © 2023 Joshua Suskalo

Distribué sous la licence publique Eclipse version 1.0.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-30

---