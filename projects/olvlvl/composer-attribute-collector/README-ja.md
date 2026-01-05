# composer-attribute-collector

[![Release](https://img.shields.io/packagist/v/olvlvl/composer-attribute-collector.svg)](https://packagist.org/packages/olvlvl/composer-attribute-collector)
[![Code Coverage](https://coveralls.io/repos/github/olvlvl/composer-attribute-collector/badge.svg?branch=main)](https://coveralls.io/r/olvlvl/composer-attribute-collector?branch=main)
[![Downloads](https://img.shields.io/packagist/dt/olvlvl/composer-attribute-collector.svg)](https://packagist.org/packages/olvlvl/composer-attribute-collector)

**composer-attribute-collector** は、PHP 8 の属性ターゲットを効果的に _発見_ し、実行時リフレクションなしでほぼゼロコストで後に取得できるように設計された [Composer][] プラグインです。  
オートローダのダンプ後に、属性を収集して高速アクセス用の静的ファイルを生成します。これにより、属性を持つクラス、メソッド、またはプロパティを _発見_ する便利な方法を提供します。コードベースの解析に最適です。（既知のターゲットについては、従来のリフレクションも利用可能です。）



#### 機能

- 設定不要
- 生成ファイルにリフレクションを使用しない
- パフォーマンスの向上が期待できる
- 依存関係なし（もちろん Composer は必要）
- 属性ターゲット（クラス、メソッド、プロパティ）を取得する単一のインターフェース
- 発見結果をキャッシュして連続実行を高速化可能

> [!NOTE]
> 現在、プラグインはクラス、メソッド、プロパティ、およびパラメータのターゲットをサポートしています。  
> サポート拡張に興味がある方は、[貢献](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CONTRIBUTING.md)を歓迎します。

> [!WARNING]
> 現時点では、関数に使用された属性は無視されます。



#### 使い方

以下の例は、ターゲットとその属性をどのように取得できるかを示しています：




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
## はじめに

以下は開始するためのいくつかのステップです。

### 1\. プラグインの設定（任意）

コレクターはルートの `composer.json` の `autoload` パスを自動的にスキャンし、
ゼロコンフィグレーションの体験を提供します。これらは
`extra.composer-attribute-collector.include` で上書き可能です。




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

詳細は[設定オプション](#configuration)を参照してください。



### 2\. プラグインのインストール

[Composer][] を使用してプラグインをインストールします。
プラグインを信頼して有効化するかどうか尋ねられますので、`y` を選択して続行してください。

```shell
composer require olvlvl/composer-attribute-collector
```

次のようなログメッセージが表示されるはずです:

```
Generating autoload files
Generating attributes file
Generated attributes file in 9.137 ms
Generated autoload files
```

> [!TIP]
> 開発中に「attributes」ファイルを自動的にリフレッシュするには、
> [よくある質問](#frequently-asked-questions) セクションを参照してください。



### 3\. 「attributes」ファイルのオートロード

`require_once 'vendor/attributes.php';` を使って「attributes」ファイルを読み込むこともできますが、
Composerのオートロード機能を使う方が便利かもしれません:

```json
{
  "autoload": {
    "files": [
      "vendor/attributes.php"
    ]
  }
}
```
## 設定

プラグインを設定するいくつかの方法を紹介します。



### パスまたはファイルの含め方（[root-only][]）

コレクターはルートの `composer.json` の `autoload` パスを自動的にスキャンしますが、
`include` プロパティでこれを上書きできます。

指定されたパスは `composer.json` ファイルからの相対パスであり、 `{vendor}` プレースホルダーは
ベンダーフォルダへのパスに置き換えられます。




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

### パスまたはファイルの除外（[root-only][]）

`exclude` プロパティを使用して、スキャンからパスまたはファイルを除外します。これはファイルが問題を引き起こしたり、副作用がある場合に便利です。

指定されたパスは `composer.json` ファイルに対して相対的であり、`{vendor}` プレースホルダーはベンダーフォルダへのパスに置き換えられます。



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

### 実行間での発見結果のキャッシュ

プラグインは、実行間で発見結果を再利用するためのキャッシュを維持できます。キャッシュを有効にするには、
環境変数 `COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE` を `1`、`yes`、または `true` に設定してください。
キャッシュアイテムは `.composer-attribute-collector` ディレクトリに保存されます。`.gitignore` ファイルに
追加することを検討してください。

```shell
COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE=1 composer dump-autoload
```



## ユースケース

ユースケースは、プラグインを実際の条件でテストするために利用できます：

- [互換性のないシグネチャ](cases/incompatible-signature) プラグインは属性を収集できますが、
  Composerとアプリケーションで使用されているPSR Loggerのバージョンが互換性がない場合でも動作します。

- [Symfony](cases/symfony) `symfony new`で作成されたSymfonyアプリケーション。

- [Laravel](cases/laravel) `laravel new`で作成されたLaravelアプリケーション。



## よくある質問

**最適化されたオートローダーを生成する必要がありますか？**

このプラグインを動作させるために最適化されたオートローダーを生成する必要はありません。プラグインはComposerと同様のコードを使ってクラスを見つけます。Composerで動作するものはプラグインでも動作するはずです。

**開発中にプラグインを使えますか？**

はい、開発中にもプラグインを使用できますが、「attributes」ファイルはオートローダーをダンプした後にのみ生成されることに注意してください。属性を変更した場合は、「attributes」ファイルを更新するために`composer dump-autoload`を実行する必要があります。

回避策として、属性を持つクラスがあるディレクトリにウォッチャーを設定して、
変更時に`XDEBUG_MODE=off composer dump-autoload`を実行することが考えられます。[PhpStormはファイルウォッチャーを提供しています][phpstorm-watchers]。また、[spatie/file-system-watcher][]も使用可能で、PHPのみが必要です。プラグインの動作が遅いと感じる場合は、`COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE=yes`を付けてコマンドを実行すると、キャッシュが有効になり連続実行が高速化されます。

**属性を継承するクラスを含めるにはどうすればよいですか？**

収集プロセスを高速化するために、プラグインはまずPHPファイルをプレーンテキストとして解析し、属性使用のヒントを探します。クラスがトレイト、プロパティ、メソッドから属性を継承しているが、自身では属性を使用していない場合、そのクラスは無視されます。属性を使用してください








`[#\olvlvl\ComposerAttributeCollector\InheritsAttributes]` を付けて収集を強制します。

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



## 継続的インテグレーション

このプロジェクトは [GitHub actions](https://github.com/olvlvl/composer-attribute-collector/actions) によって継続的にテストされています。

[![Cases](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/cases.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/cases.yml)
[![Tests](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/test.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/test.yml)
[![Static Analysis](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/static-analysis.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/static-analysis.yml)
[![Code Style](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/code-style.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/code-style.yml)



## 行動規範

このプロジェクトは [Contributor Code of Conduct](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CODE_OF_CONDUCT.md) に準拠しています。  
このプロジェクトおよびコミュニティに参加することで、あなたはこの規範を守ることが期待されています。



## コントリビュート

詳細は [CONTRIBUTING](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CONTRIBUTING.md) を参照してください。



[Composer]:  https://getcomposer.org/
[root-only]: https://getcomposer.org/doc/04-schema.md#root-package
[spatie/file-system-watcher]: https://github.com/spatie/file-system-watcher
[phpstorm-watchers]: https://www.jetbrains.com/help/phpstorm/using-file-watchers.html


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-05

---