# composer-attribute-collector

[![Release](https://img.shields.io/packagist/v/olvlvl/composer-attribute-collector.svg)](https://packagist.org/packages/olvlvl/composer-attribute-collector)
[![Code Coverage](https://coveralls.io/repos/github/olvlvl/composer-attribute-collector/badge.svg?branch=main)](https://coveralls.io/r/olvlvl/composer-attribute-collector?branch=main)
[![Downloads](https://img.shields.io/packagist/dt/olvlvl/composer-attribute-collector.svg)](https://packagist.org/packages/olvlvl/composer-attribute-collector)

**composer-attribute-collector** is a [Composer][] plugin designed to effectively _discover_ PHP 8
attribute targets, and later retrieve them at near zero cost, without runtime reflection. After the
autoloader dump, it collects attributes and generates a static file for fast access. This provides a
convenient way to _discover_ attribute-backed classes, methods, or properties—ideal for codebase
analysis. (For known targets, traditional reflection remains an option.)



#### Features

- Zero configuration
- No reflection in the generated file
- Might improve performance
- No dependency (except Composer of course)
- A single interface to get attribute targets: classes, methods, and properties
- Can cache discoveries to speed up consecutive runs.

> [!NOTE]
> Currently, the plugin supports class, method, property, and parameter targets.
> You're welcome to [contribute](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CONTRIBUTING.md) if you're interested in expending its support.

> [!WARNING]
> Attributes used on functions are ignored at this time.



#### Usage

The following example demonstrates how targets and their attributes can be retrieved:

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
## Getting started

Here are a few steps to get you started.

### 1\. Configure the plugin (optional)

The collector automatically scans `autoload` paths of the root `composer.json` for a
zero-configuration experience. You can override them via
`extra.composer-attribute-collector.include`.




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

Check the [Configuration options](#configuration) for more details.



### 2\. Install the plugin

Use [Composer][] to install the plugin.
You will be asked if you trust the plugin and wish to activate it, select `y` to proceed.

```shell
composer require olvlvl/composer-attribute-collector
```

You should see log messages similar to this:

```
Generating autoload files
Generating attributes file
Generated attributes file in 9.137 ms
Generated autoload files
```

> [!TIP]
> See the [Frequently Asked Questions](#frequently-asked-questions) section
> to automatically refresh the "attributes" file during development.



### 3\. Autoload the "attributes" file

You can require the "attributes" file using `require_once 'vendor/attributes.php';` but you might
prefer to use Composer's autoloading feature:

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

Here are a few ways you can configure the plugin.



### Including paths or files ([root-only][])

The collector automatically scans `autoload` paths of the root `composer.json`, but you can override
them via the `include` property.

The specified paths are relative to the `composer.json` file, and the `{vendor}` placeholder is
replaced with the path to the vendor folder.




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

### Excluding paths or files ([root-only][])

Use the `exclude` property to exclude paths or files from scanning. This is useful when files
cause problems or have side effects.

The specified paths are relative to the `composer.json` file, and the `{vendor}` placeholder is
replaced with the path to the vendor directory.

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

### Cache discoveries between runs

The plugin is able to maintain a cache to reuse discoveries between runs. To enable the cache,
set the environment variable `COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE` to `1`, `yes`, or `true`.
Cache items are persisted in the `.composer-attribute-collector` directory, you might want to add
it to your `.gitignore` file.

```shell
COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE=1 composer dump-autoload
```

## Use cases

Use cases are available to test the plugin in real conditions:

- [Incompatible signature](cases/incompatible-signature) The plugin is able to collect attributes,
  although the PSR Logger version used by Composer and the application are incompatible.

- [Symfony](cases/symfony) A Symfony application, created with `symfony new`.

- [Laravel](cases/laravel) A Laravel application, created with `laravel new`.


## Frequently Asked Questions

**Do I need to generate an optimized autoloader?**

You don't need to generate an optimized autoloader for this to work. The plugin uses code similar
to Composer to find classes. Anything that works with Composer should work with the plugin.

**Can I use the plugin during development?**

Yes, you can use the plugin during development, but keep in mind the "attributes" file is only
generated after the autoloader is dumped. If you modify attributes you will have to run
`composer dump-autoload` to refresh the "attributes" file.

As a workaround you could have watchers on the directories that contain classes with attributes to
run `XDEBUG_MODE=off composer dump-autoload` when you make changes. [PhpStorm offers file
watchers][phpstorm-watchers]. You could also use [spatie/file-system-watcher][], it only requires
PHP. If the plugin is too slow for your liking, try running the command with
`COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE=yes`, it will enable caching and speed up consecutive runs.

**How do I include a class that inherits its attributes?**

To speed up the collection process, the plugin first looks at PHP files as plain text for hints of
attribute usage. If a class inherits its attributes from traits, properties, or methods, but doesn't
use attributes itself, it will be ignored. Use the attribute



`[#\olvlvl\ComposerAttributeCollector\InheritsAttributes]` to force the collection.

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



## Continuous Integration

The project is continuously tested by [GitHub actions](https://github.com/olvlvl/composer-attribute-collector/actions).

[![Cases](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/cases.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/cases.yml)
[![Tests](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/test.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/test.yml)
[![Static Analysis](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/static-analysis.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/static-analysis.yml)
[![Code Style](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/code-style.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/code-style.yml)



## Code of Conduct

This project adheres to a [Contributor Code of Conduct](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CODE_OF_CONDUCT.md). By participating in
this project and its community, you're expected to uphold this code.



## Contributing

See [CONTRIBUTING](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CONTRIBUTING.md) for details.



[Composer]:  https://getcomposer.org/
[root-only]: https://getcomposer.org/doc/04-schema.md#root-package
[spatie/file-system-watcher]: https://github.com/spatie/file-system-watcher
[phpstorm-watchers]: https://www.jetbrains.com/help/phpstorm/using-file-watchers.html


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-05

---