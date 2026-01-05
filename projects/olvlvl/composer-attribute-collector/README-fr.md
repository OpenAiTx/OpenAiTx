# composer-attribute-collector

[![Release](https://img.shields.io/packagist/v/olvlvl/composer-attribute-collector.svg)](https://packagist.org/packages/olvlvl/composer-attribute-collector)
[![Code Coverage](https://coveralls.io/repos/github/olvlvl/composer-attribute-collector/badge.svg?branch=main)](https://coveralls.io/r/olvlvl/composer-attribute-collector?branch=main)
[![Downloads](https://img.shields.io/packagist/dt/olvlvl/composer-attribute-collector.svg)](https://packagist.org/packages/olvlvl/composer-attribute-collector)

**composer-attribute-collector** est un plugin [Composer][] conçu pour _découvrir_ efficacement les cibles des attributs PHP 8, et ensuite les récupérer à un coût quasi nul, sans réflexion à l'exécution. Après le dump de l'autoloader, il collecte les attributs et génère un fichier statique pour un accès rapide. Cela fournit un moyen pratique de _découvrir_ les classes, méthodes ou propriétés portant des attributs—idéal pour l'analyse de code. (Pour les cibles connues, la réflexion traditionnelle reste une option.)



#### Fonctionnalités

- Zéro configuration
- Pas de réflexion dans le fichier généré
- Peut améliorer les performances
- Aucune dépendance (sauf Composer bien sûr)
- Une interface unique pour obtenir les cibles des attributs : classes, méthodes, et propriétés
- Peut mettre en cache les découvertes pour accélérer les exécutions consécutives.

> [!NOTE]
> Actuellement, le plugin supporte les cibles de type classe, méthode, propriété, et paramètre.
> Vous êtes invité à [contribuer](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CONTRIBUTING.md) si vous souhaitez étendre son support.

> [!WARNING]
> Les attributs utilisés sur les fonctions sont ignorés pour le moment.



#### Utilisation

L'exemple suivant montre comment les cibles et leurs attributs peuvent être récupérés :





```php
<?php

use olvlvl\ComposerAttributeCollector\Attributes;
use Symfony\Component\Messenger\Attribute\AsMessageHandler;
use Symfony\Component\Routing\Annotation\Route;
use Doctrine\ORM\Mapping\Column;

require_once 'vendor/autoload.php';
require_once 'vendor/attributes.php'; // <-- the file created by the plugin

// Find the target classes of the AsMessageHandler attribute.
foreach (Attributes::findTargetClasses(AsMessageHandler::class) as $target) {
    // $target->attribute is an instance of the specified attribute
    // with the actual data.
    var_dump($target->attribute, $target->name);
}

// Find the target methods of the Route attribute.
foreach (Attributes::findTargetMethods(Route::class) as $target) {
    var_dump($target->attribute, $target->class, $target->name);
}

// Find the target properties of the Column attribute.
foreach (Attributes::findTargetProperties(Column::class) as $target) {
    var_dump($target->attribute, $target->class, $target->name);
}

// Find the target method parameters of the UserInput attribute.
foreach (Attributes::findTargetParameters(UserInput::class) as $target) {
    var_dump($target->attribute, $target->class, $target->method, $target->name);
}

// Filter target methods using a predicate.
// You can also filter target classes and properties.
$predicate = fn($attribute) => is_a($attribute, Route::class, true);
# or
$predicate = Attributes::predicateForAttributeInstanceOf(Route::class);

foreach (Attributes::filterTargetMethods($predicate) as $target) {
    var_dump($target->attribute, $target->class, $target->name);
}

// Find class, method, and property attributes for the ArticleController class.
$attributes = Attributes::forClass(ArticleController::class);

var_dump($attributes->classAttributes);
var_dump($attributes->methodsAttributes);
var_dump($attributes->propertyAttributes);
```
## Pour commencer

Voici quelques étapes pour vous lancer.

### 1\. Configurer le plugin (optionnel)

Le collecteur analyse automatiquement les chemins `autoload` du fichier `composer.json` racine pour une expérience sans configuration. Vous pouvez les remplacer via `extra.composer-attribute-collector.include`.






```json
{
  "extra": {
    "composer-attribute-collector": {
      "include": [
        "src"
      ]
    }
  }
}
```

Consultez les [Options de configuration](#configuration) pour plus de détails.



### 2\. Installer le plugin

Utilisez [Composer][] pour installer le plugin.
Il vous sera demandé si vous faites confiance au plugin et souhaitez l’activer, sélectionnez `y` pour continuer.

```shell
composer require olvlvl/composer-attribute-collector
```

Vous devriez voir des messages de journal similaires à ceci :

```
Generating autoload files
Generating attributes file
Generated attributes file in 9.137 ms
Generated autoload files
```

> [!ASTUCE]
> Consultez la section [Questions fréquemment posées](#frequently-asked-questions)
> pour actualiser automatiquement le fichier "attributes" pendant le développement.



### 3\. Chargement automatique du fichier "attributes"

Vous pouvez inclure le fichier "attributes" avec `require_once 'vendor/attributes.php';` mais vous
préférerez peut-être utiliser la fonctionnalité d'autochargement de Composer :

```json
{
  "autoload": {
    "files": [
      "vendor/attributes.php"
    ]
  }
}
```
## Configuration

Voici quelques façons de configurer le plugin.



### Inclusion de chemins ou de fichiers ([root-only][])

Le collecteur analyse automatiquement les chemins `autoload` du `composer.json` racine, mais vous pouvez les remplacer
via la propriété `include`.

Les chemins spécifiés sont relatifs au fichier `composer.json`, et le placeholder `{vendor}` est
remplacé par le chemin vers le dossier vendor.




```json
{
  "extra": {
    "composer-attribute-collector": {
      "include": [
        "path-or-file/to/include"
      ]
    }
  }
}
```

### Exclusion de chemins ou de fichiers ([root-only][])

Utilisez la propriété `exclude` pour exclure des chemins ou des fichiers de l'analyse. Cela est utile lorsque des fichiers
provoquent des problèmes ou ont des effets secondaires.

Les chemins spécifiés sont relatifs au fichier `composer.json`, et le substitut `{vendor}` est
remplacé par le chemin vers le dossier vendor.

```json
{
  "extra": {
    "composer-attribute-collector": {
      "exclude": [
        "path-or-file/to/exclude"
      ]
    }
  }
}
```

### Mettre en cache les découvertes entre les exécutions

Le plugin est capable de maintenir un cache pour réutiliser les découvertes entre les exécutions. Pour activer le cache,
définissez la variable d'environnement `COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE` sur `1`, `yes` ou `true`.
Les éléments du cache sont conservés dans le répertoire `.composer-attribute-collector`, vous pouvez vouloir l'ajouter
à votre fichier `.gitignore`.

```shell
COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE=1 composer dump-autoload
```
## Cas d'utilisation

Des cas d'utilisation sont disponibles pour tester le plugin en conditions réelles :

- [Signature incompatible](cases/incompatible-signature) Le plugin est capable de collecter des attributs,
  même si la version PSR Logger utilisée par Composer et l'application sont incompatibles.

- [Symfony](cases/symfony) Une application Symfony, créée avec `symfony new`.

- [Laravel](cases/laravel) Une application Laravel, créée avec `laravel new`.



## Questions fréquentes

**Dois-je générer un autoloader optimisé ?**

Vous n'avez pas besoin de générer un autoloader optimisé pour que cela fonctionne. Le plugin utilise un code similaire
à Composer pour trouver les classes. Tout ce qui fonctionne avec Composer devrait fonctionner avec le plugin.

**Puis-je utiliser le plugin pendant le développement ?**

Oui, vous pouvez utiliser le plugin pendant le développement, mais gardez à l'esprit que le fichier "attributes" est uniquement
généré après le dump de l'autoloader. Si vous modifiez des attributs, vous devrez exécuter
`composer dump-autoload` pour rafraîchir le fichier "attributes".

Comme solution de contournement, vous pouvez avoir des watchers sur les répertoires contenant des classes avec attributs pour
exécuter `XDEBUG_MODE=off composer dump-autoload` lorsque vous effectuez des modifications. [PhpStorm propose des watchers de fichiers][phpstorm-watchers]. Vous pouvez aussi utiliser [spatie/file-system-watcher][], qui ne nécessite que PHP. Si le plugin est trop lent à votre goût, essayez d'exécuter la commande avec
`COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE=yes`, cela activera la mise en cache et accélérera les exécutions consécutives.

**Comment inclure une classe qui hérite de ses attributs ?**

Pour accélérer le processus de collecte, le plugin examine d'abord les fichiers PHP en texte brut pour détecter des indices
d'utilisation d'attributs. Si une classe hérite de ses attributs via des traits, propriétés ou méthodes, mais n'utilise pas
d'attributs elle-même, elle sera ignorée. Utilisez l'attribut





`[#\olvlvl\ComposerAttributeCollector\InheritsAttributes]` pour forcer la collecte.

```php
trait UrlTrait
{
    #[UrlGetter]
    public function get_url(): string
    {
        return '/url';
    }
}

#[InheritsAttributes]
class InheritedAttributeSample
{
    use UrlTrait;
}
```

----------



## Intégration Continue

Le projet est continuellement testé par [GitHub actions](https://github.com/olvlvl/composer-attribute-collector/actions).

[![Cas](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/cases.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/cases.yml)
[![Tests](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/test.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/test.yml)
[![Analyse Statique](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/static-analysis.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/static-analysis.yml)
[![Style de Code](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/code-style.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/code-style.yml)



## Code de Conduite

Ce projet adhère à un [Code de Conduite des Contributeurs](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CODE_OF_CONDUCT.md). En participant à
ce projet et à sa communauté, vous êtes tenu de respecter ce code.



## Contribution

Voir [CONTRIBUTING](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CONTRIBUTING.md) pour plus de détails.



[Composer]:  https://getcomposer.org/
[root-only]: https://getcomposer.org/doc/04-schema.md#root-package
[spatie/file-system-watcher]: https://github.com/spatie/file-system-watcher
[phpstorm-watchers]: https://www.jetbrains.com/help/phpstorm/using-file-watchers.html


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-05

---