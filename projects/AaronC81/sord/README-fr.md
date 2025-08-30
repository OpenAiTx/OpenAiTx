# Sord

## Aperçu

Sord est un crossover entre [**So**rbet](https://sorbet.org) et [YA**RD**](https://yardoc.org/).  
Il peut **générer automatiquement des fichiers de signatures de types RBI et RBS** en  
regardant les **types spécifiés dans les commentaires de documentation YARD**.

Si votre projet est déjà documenté avec YARD, alors cela peut générer la plupart des  
signatures de types dont vous avez besoin !

Sord est le moyen parfait pour démarrer l'adoption des types dans votre projet,  
que vous prévoyiez d'utiliser le format RBI de Sorbet ou le format RBS de Ruby 3/Steep.

**Essayez Sord en ligne sur : [sord.aaronc.cc](https://sord.aaronc.cc)**

Sord offre les fonctionnalités suivantes :  
  - Génération automatique des signatures pour modules, classes et méthodes  
  - Support pour plusieurs types de paramètres ou de retour (`T.any`/`|`)  
  - Gestion élégante des types YARD manquants (`T.untyped`/`untyped`)  
  - Peut inférer le type du paramètre setter à partir du type de retour du getter correspondant  
  - Reconnaît les mixins (`include` et `extend`)  
  - Support des types génériques tels que `Array<T>` et `Hash<K, V>`  
  - Peut inférer les classes dans un namespace (`[Bar]` peut devenir `GemName::Foo::Bar`)  
  - Gère les types de retour pouvant être `nil` (`T.nilable`/`untyped`)  
  - Gère les types duck (`T.untyped`/`untyped`)  
  - Support des types de listes ordonnées (`[Array(Integer, Symbol)]` devient `[Integer, Symbol]`)  
  - Support des types booléens (`[true, false]` devient `T::Boolean`/`bool`)  
  - Support des paramètres `&block` documentés avec `@yieldparam` et `@yieldreturn`

## Utilisation

Installez Sord avec `gem install sord`.

Sord est un outil en ligne de commande. Pour l’utiliser, ouvrez un terminal à la racine  
de votre projet et lancez `sord`, en passant un chemin où vous souhaitez sauvegarder votre  
fichier (ce fichier sera écrasé) :

```
sord defs.rbi
```
Sord générera la documentation YARD puis affichera des informations sur ce qu’il a déduit  
pendant son exécution. Il est préférable de corriger les problèmes dans la documentation YARD,  
car toute modification apportée au fichier résultant sera remplacée si vous relancez Sord.  

Le type de sortie est déduit par l’extension de fichier utilisée, mais vous pouvez aussi  
le spécifier explicitement avec `--rbi` ou `--rbs`.  

## Distribution des types RBI  

Les fichiers RBI générés par Sord peuvent être utilisés de deux manières principales :  

- [Distribués dans la gem elle-même](https://sorbet.org/docs/rbi#rbis-within-gems).  
- Contribués à [sorbet-typed](https://github.com/sorbet/sorbet-typed).  

En général, vous devriez livrer les signatures de type avec votre gem si possible.  
sorbet-typed est destiné à être un endroit pour les gems qui ne sont plus maintenues ou  
où le mainteneur ne souhaite pas livrer les signatures de type avec la gem elle-même.  

### Options  

Sord accepte également des options pour modifier le fichier généré :  

  - `--rbi`/`--rbs` : Remplace le format de sortie déduit de l’extension de fichier.  
  - `--no-sord-comments` : Génère le fichier sans aucun commentaire Sord concernant  
    les avertissements/déductions/erreurs. (Les commentaires du fichier original seront toujours  
    inclus.)  
  - `--no-regenerate` : Par défaut, Sord régénère la documentation YARD d’un dépôt pour vous.  
    Cette option évite la régénération de la documentation YARD.  
  - `--break-params` : Détermine le nombre de paramètres nécessaire avant que  
    la signature ne passe d’une ligne unique à un bloc multi-lignes.  
    (Par défaut : 4)  
  - `--replace-errors-with-untyped` : Utilise `T.untyped` au lieu des constantes `SORD_ERROR_*`.  
  - `--replace-unresolved-with-untyped` : Utilise `T.untyped` lorsque Sord ne peut pas  
    résoudre une constante.  
  - `--include-messages` et `--exclude-messages` : Utilisés pour filtrer les messages de  
    journalisation fournis par Sord. `--include-messages` agit comme une liste blanche,  
    affichant uniquement les messages des types de journalisation spécifiés, tandis que `--exclude-messages`



    agit comme une liste noire et supprime les types de journalisation spécifiés. Les deux options
    prennent une liste de types de journalisation séparés par des virgules, par exemple `omit,infer`.
    Lors de l'utilisation de `--include-messages`, le type `done` est inclus par défaut.
    (Vous ne pouvez pas spécifier à la fois `--include-messages` et `--exclude-messages`.)
  - `--exclude-untyped` : Exclut les méthodes et attributs avec des valeurs de retour non typées.
  - `--tags TAGS` : Fournit une liste de tags séparés par des virgules tels que compris par la commande
    `yard`. Par exemple, `--tags 'mytag:My Description,mytag2:My New Description'

## Exemple

Disons que nous avons ce fichier, appelé `test.rb` :


```ruby
module Example
  class Person
    # @param name [String] The name of the Person to create.
    # @param age [Integer] The age of the Person to create.
    # @return [Example::Person]
    def initialize(name, age)
      @name = name
      @age = age
    end

    # @return [String]
    attr_accessor :name

    # @return [Integer]
    attr_accessor :age

    # @param possible_names [Array<String>] An array of potential names to choose from.
    # @param possible_ages [Array<Integer>] An array of potential ages to choose from.
    # @return [Example::Person]
    def self.construct_randomly(possible_names, possible_ages)
      Person.new(possible_names.sample, possible_ages.sample)
    end
  end
end
```

Tout d'abord, générez un registre YARD en exécutant `yardoc test.rb`. Ensuite, nous pouvons exécuter
`sord test.rbi` pour générer le fichier RBI. (Attention à ne pas écraser vos fichiers
de code ! Notez l'extension de fichier `.rbi`.) En faisant cela, Sord affiche :

```
[INFER] Assuming from filename you wish to generate in RBI format
[DONE ] Processed 8 objects (2 namespaces and 6 methods)
```

Le fichier `test.rbi` contient alors un fichier RBI complet pour `test.rb` :

```ruby
# typed: strong
module Example
  class Person
    # _@param_ `name` — The name of the Person to create.
    # 
    # _@param_ `age` — The age of the Person to create.
    sig { params(name: String, age: Integer).void }
    def initialize(name, age); end

    # _@param_ `possible_names` — An array of potential names to choose from.
    # 
    # _@param_ `possible_ages` — An array of potential ages to choose from.
    sig { params(possible_names: T::Array[String], possible_ages: T::Array[Integer]).returns(Example::Person) }
    def self.construct_randomly(possible_names, possible_ages); end

    sig { returns(String) }
    attr_accessor :name

    sig { returns(Integer) }
    attr_accessor :age
  end
end
```

Si nous avions plutôt généré `test.rbs`, nous obtiendrions ce fichier au format RBS :

```ruby
module Example
  class Person
    # _@param_ `name` — The name of the Person to create.
    # 
    # _@param_ `age` — The age of the Person to create.
    def initialize: (String name, Integer age) -> void

    # _@param_ `possible_names` — An array of potential names to choose from.
    # 
    # _@param_ `possible_ages` — An array of potential ages to choose from.
    def self.construct_randomly: (Array[String] possible_names, Array[Integer] possible_ages) -> Example::Person

    attr_accessor name: String

    attr_accessor age: Integer
  end
end
```

## Choses à savoir

La règle générale pour les conversions de type est la suivante :

  - Si Sord comprend le type YARD, alors il est converti en type RBI ou RBS.
  - Si le type YARD est manquant, Sord remplit avec `T.untyped`.
  - Si le type YARD ne peut pas être compris, Sord crée une constante Ruby indéfinie
    avec un nom similaire au type YARD inconnu. Par exemple, le type YARD
    manifestement invalide `A%B` deviendra une constante appelée `SORD_ERROR_AB`.
    Vous devriez rechercher dans votre fichier résultant tous les 
    `SORD_ERROR` pour les trouver et les corriger.

## Contribution

Les rapports de bugs et les pull requests sont les bienvenus sur GitHub à l’adresse https://github.com/AaronC81/sord. Ce projet se veut un espace sûr et accueillant pour la collaboration, et les contributeurs sont censés respecter le code de conduite [Contributor Covenant](http://contributor-covenant.org).

Lors de votre contribution, si vous souhaitez voir les résultats de vos modifications sur Sord, vous pouvez utiliser la tâche Rake `examples:seed`. Cette tâche utilise Sord pour générer les types de plusieurs gems Ruby open source, y compris Bundler, Haml, Rouge et RSpec. `rake examples:seed` (et `rake examples:reseed` pour régénérer les fichiers) clonera les dépôts de ces gems dans `sord_examples/` puis générera les fichiers dans ce même répertoire.

## Licence

La gem est disponible en open source sous les termes de la [Licence MIT](https://opensource.org/licenses/MIT).

## Code de conduite

Toute personne interagissant avec les bases de code, les traqueurs de problèmes, les salons de discussion et les listes de diffusion du projet Sord est tenue de suivre le [code de conduite](https://github.com/AaronC81/sord/blob/master/CODE_OF_CONDUCT.md).








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---