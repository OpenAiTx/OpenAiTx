# composer-attribute-collector

[![Release](https://img.shields.io/packagist/v/olvlvl/composer-attribute-collector.svg)](https://packagist.org/packages/olvlvl/composer-attribute-collector)
[![Code Coverage](https://coveralls.io/repos/github/olvlvl/composer-attribute-collector/badge.svg?branch=main)](https://coveralls.io/r/olvlvl/composer-attribute-collector?branch=main)
[![Downloads](https://img.shields.io/packagist/dt/olvlvl/composer-attribute-collector.svg)](https://packagist.org/packages/olvlvl/composer-attribute-collector)

**composer-attribute-collector** 是一个 [Composer][] 插件，旨在有效地 _发现_ PHP 8
属性目标，并且之后以近乎零成本的方式检索它们，无需运行时反射。在
自动加载器导出后，它会收集属性并生成一个静态文件以实现快速访问。这样提供了一种
方便的方式来 _发现_ 基于属性的类、方法或属性——非常适合代码库
分析。（对于已知目标，传统反射仍然是一个选项。）



#### 功能

- 零配置
- 生成的文件中无反射
- 可能提升性能
- 无依赖（当然除了 Composer）
- 一个接口即可获取属性目标：类、方法和属性
- 可以缓存发现结果以加快连续运行速度。

> [!注意]
> 当前，插件支持类、方法、属性和参数目标。
> 如果你有兴趣扩展支持，欢迎 [贡献](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CONTRIBUTING.md)。

> [!警告]
> 目前忽略函数上的属性。



#### 使用方法

下面的示例演示了如何检索目标及其属性：

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
## 入门指南

以下是一些帮助您快速入门的步骤。

### 1\. 配置插件（可选）

收集器会自动扫描根目录 `composer.json` 中的 `autoload` 路径，  
实现零配置体验。您可以通过  
`extra.composer-attribute-collector.include` 覆盖它们。




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

查看[配置选项](#configuration)了解更多详情。



### 2\. 安装插件

使用[Composer][]安装插件。
系统会询问您是否信任该插件并希望激活它，选择`y`继续。

```shell
composer require olvlvl/composer-attribute-collector
```

您应该看到类似于以下的日志信息：

```
Generating autoload files
Generating attributes file
Generated attributes file in 9.137 ms
Generated autoload files
```

> [!提示]
> 请参阅[常见问题解答](#frequently-asked-questions)部分
> 以在开发过程中自动刷新“attributes”文件。



### 3\. 自动加载“attributes”文件

您可以使用 `require_once 'vendor/attributes.php';` 引入“attributes”文件，但您可能
更愿意使用 Composer 的自动加载功能：

```json
{
  "autoload": {
    "files": [
      "vendor/attributes.php"
    ]
  }
}
```
## 配置

以下是几种配置插件的方法。



### 包含路径或文件（[仅限根目录][]）

收集器会自动扫描根目录 `composer.json` 的 `autoload` 路径，但你可以通过 `include` 属性覆盖它们。

指定的路径是相对于 `composer.json` 文件的，`{vendor}` 占位符会被替换为供应商文件夹的路径。






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

### 排除路径或文件（仅限根目录）[root-only][]

使用 `exclude` 属性来排除扫描路径或文件。当文件引发问题或有副作用时，这非常有用。

指定的路径是相对于 `composer.json` 文件的，且 `{vendor}` 占位符会被替换为 vendor 文件夹的路径。



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

### 在运行之间缓存发现结果

该插件能够维护一个缓存以在运行之间重用发现结果。要启用缓存，
请将环境变量 `COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE` 设置为 `1`、`yes` 或 `true`。
缓存项会保存在 `.composer-attribute-collector` 目录中，您可能需要将其添加到
您的 `.gitignore` 文件中。

```shell
COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE=1 composer dump-autoload
```
## 使用案例

使用案例可用于在实际条件下测试插件：

- [不兼容的签名](cases/incompatible-signature) 插件能够收集属性，  
  尽管 Composer 和应用程序使用的 PSR Logger 版本不兼容。

- [Symfony](cases/symfony) 一个使用 `symfony new` 创建的 Symfony 应用。

- [Laravel](cases/laravel) 一个使用 `laravel new` 创建的 Laravel 应用。



## 常见问题解答

**我需要生成优化的自动加载器吗？**

不需要生成优化的自动加载器才能使其工作。该插件使用类似于 Composer 的代码  
来查找类。任何能与 Composer 一起工作的东西都应该能与该插件一起工作。

**我可以在开发过程中使用该插件吗？**

可以，你可以在开发过程中使用该插件，但请注意，“attributes” 文件仅在  
自动加载器导出后生成。如果你修改了属性，则需要运行  
`composer dump-autoload` 来刷新“attributes”文件。

作为一种解决方法，你可以对包含带属性类的目录设置监视器，  
在你进行更改时运行 `XDEBUG_MODE=off composer dump-autoload`。  
[PhpStorm 提供文件监视器][phpstorm-watchers]。你也可以使用 [spatie/file-system-watcher][]，  
它只需要 PHP。如果插件运行速度太慢，可以尝试使用  
`COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE=yes` 运行命令，  
这将启用缓存并加快后续运行速度。

**如何包含继承其属性的类？**

为了加快收集过程，插件首先将 PHP 文件作为纯文本查找属性使用的提示。  
如果类从 trait、属性或方法继承其属性，但自身不使用属性，则会被忽略。  
请使用属性


`[#\olvlvl\ComposerAttributeCollector\InheritsAttributes]` 强制收集。

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



## 持续集成

该项目通过 [GitHub actions](https://github.com/olvlvl/composer-attribute-collector/actions) 持续进行测试。

[![Cases](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/cases.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/cases.yml)
[![Tests](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/test.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/test.yml)
[![Static Analysis](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/static-analysis.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/static-analysis.yml)
[![Code Style](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/code-style.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/code-style.yml)



## 行为准则

本项目遵循 [贡献者行为准则](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CODE_OF_CONDUCT.md)。参与
本项目及其社区时，您应遵守此准则。



## 贡献

详情请参见 [CONTRIBUTING](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CONTRIBUTING.md)。



[Composer]:  https://getcomposer.org/
[root-only]: https://getcomposer.org/doc/04-schema.md#root-package
[spatie/file-system-watcher]: https://github.com/spatie/file-system-watcher
[phpstorm-watchers]: https://www.jetbrains.com/help/phpstorm/using-file-watchers.html


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-05

---