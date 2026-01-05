# Laravel Eloquent Sequencer

[![最新バージョン](https://img.shields.io/github/release/gurgentil/laravel-eloquent-sequencer.svg?style=flat-square)](https://github.com/gurgentil/laravel-eloquent-sequencer/releases)
![GitHub ワークフローステータス](https://img.shields.io/github/workflow/status/gurgentil/laravel-eloquent-sequencer/run-tests?label=tests)
[![品質スコア](https://img.shields.io/scrutinizer/g/gurgentil/laravel-eloquent-sequencer.svg?style=flat-square)](https://scrutinizer-ci.com/g/gurgentil/laravel-eloquent-sequencer)
[![MIT ライセンス](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](LICENSE.md)

このパッケージは、Eloquentモデルのシーケンスを作成および管理することを可能にします。

## インストール

Composer経由でパッケージをインストールします:

```bash
composer require gurgentil/laravel-eloquent-sequencer
```

## 設定

設定ファイルを公開するには、次のコマンドを実行してください:

```bash
php artisan vendor:publish --provider="Gurgentil\LaravelEloquentSequencer\LaravelEloquentSequencerServiceProvider"
```

### 設定パラメータ

デフォルトのカラム名、初期値、シーケンス戦略は `config/eloquentsequencer.php` で変更できます:

```php
return [
    'column_name' => 'position',
    'initial_value' => 1,
    'strategy' => 'always',
];
```

`strategy`設定は、シーケンシングをいつトリガーするかを決定し、次のいずれかの値を受け入れます：`always`、`on_create`、`on_update`、または`never`。

### モデル設定

`$sequenceable`属性は、モデルのシーケンスカラム名を指定します：

```php
protected static $sequenceable = 'order';
```
シーケンスアイテムをグループ化する関係キー：


```php
protected static $sequenceableKeys = [
    'task_list_id',
];
```

上記の例では、タスクリストには多くのタスクがあります。

**多態的関係**の場合は、両方の関係キーを指定してください：

```php
protected static $sequenceableKeys = [
    'commentable_id',
    'commentable_type',
];
```

## 使用法

以下の例では、タスクリストに多数のタスクが含まれる場合があります。

``` php
use Gurgentil\LaravelEloquentSequencer\Traits\Sequenceable;
use Illuminate\Database\Eloquent\Model;

class Task extends Model
{
    use Sequenceable;

    protected $fillable = [
        'position',
    ];
    
    protected static $sequenceableKeys = [
        'task_list_id',
    ];

    public function taskList()
    {
        return $this->belongsTo(TaskList::class);
    }
}
```

### オブジェクトを作成する

```php
Task::create([
    'position' => 1,
    'task_list_id' => 1,
]);
```

sequence 属性に値が指定されていない場合、オブジェクトはシーケンスの最後に配置されます。

```php
Task::create(['task_list_id' => 1]);
```

### オブジェクトの更新と削除

シーケンス内の他の項目は、シーケンスの整合性を保つために再配置されます。

```php
$task->update(['position' => 4]);
```

```php
$task->delete();
```

### オブジェクトのシーケンス値を取得する

```php
$value = $task->getSequenceValue();
```

### シーケンス列名を取得する

```php
$columnName = Task::getSequenceColumnName();
```

### 自動シーケンスの無効化

```php
$task->withoutSequencing()->update(['position' => 3]);
```

```php
$task->withoutSequencing()->delete();
```

### シーケンス値で結果を並べ替えるスコープクエリ

```php
$tasks = Task::sequenced()->get();
```

## Artisanコマンド

値が`null`に設定されているすべてのレコードにシーケンス値を割り当てます。

```bash
php artisan sequence:populate \\App\\Task
```

モデルのすべてのシーケンス値をフラッシュします。

```bash
php artisan sequence:flush \\App\\Task
```

### テスト

``` bash
composer test
```
### 変更履歴

最近の変更内容の詳細については、[CHANGELOG](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/CHANGELOG.md) をご覧ください。

## コントリビューション

詳細については、[CONTRIBUTING](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/CONTRIBUTING.md) をご覧ください。

### セキュリティ

セキュリティに関する問題を発見した場合は、Issueトラッカーの代わりに gustavorgentil@outlook.com までメールでご連絡ください。

## クレジット

- [Gustavo Rorato Gentil](https://github.com/gurgentil)
- [Michael Slowik](https://github.com/sl0wik)
- [全ての貢献者](../../contributors)

## ライセンス

MITライセンス (MIT)。詳細については [License File](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/LICENSE.md) をご覧ください。

## Laravel パッケージ ボイラープレート

このパッケージは [Laravel Package Boilerplate](https://laravelpackageboilerplate.com) を使用して生成されました。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-05

---