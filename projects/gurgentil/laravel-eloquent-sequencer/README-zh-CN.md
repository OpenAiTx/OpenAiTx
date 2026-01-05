# Laravel Eloquent Sequencer

[![最新版本](https://img.shields.io/github/release/gurgentil/laravel-eloquent-sequencer.svg?style=flat-square)](https://github.com/gurgentil/laravel-eloquent-sequencer/releases)
![GitHub 工作流状态](https://img.shields.io/github/workflow/status/gurgentil/laravel-eloquent-sequencer/run-tests?label=tests)
[![质量评分](https://img.shields.io/scrutinizer/g/gurgentil/laravel-eloquent-sequencer.svg?style=flat-square)](https://scrutinizer-ci.com/g/gurgentil/laravel-eloquent-sequencer)
[![MIT 许可证](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](LICENSE.md)

此包允许您为 Eloquent 模型创建和管理序列。

## 安装

通过 composer 安装此包：

```bash
composer require gurgentil/laravel-eloquent-sequencer
```

## 配置

要发布配置文件，请运行：

```bash
php artisan vendor:publish --provider="Gurgentil\LaravelEloquentSequencer\LaravelEloquentSequencerServiceProvider"
```

### 配置参数

您可以在 `config/eloquentsequencer.php` 中更改默认列名、初始值和排序策略：

```php
return [
    'column_name' => 'position',
    'initial_value' => 1,
    'strategy' => 'always',
];
```

`strategy` 配置决定了何时触发排序，接受以下值之一：`always`、`on_create`、`on_update` 或 `never`。

### 模型配置

`$sequenceable` 属性指定模型的排序列名称：

```php
protected static $sequenceable = 'order';
```

将序列项分组在一起的关系键：

```php
protected static $sequenceableKeys = [
    'task_list_id',
];
```

在上面的例子中，一个任务列表包含许多任务。

对于**多态关系**，请指定两个关系键：

```php
protected static $sequenceableKeys = [
    'commentable_id',
    'commentable_type',
];
```

## 使用方法

在下面的示例中，任务列表可能包含许多任务。

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

### 创建一个对象

```php
Task::create([
    'position' => 1,
    'task_list_id' => 1,
]);
```
如果未为 sequence 属性提供值，则对象将被放置在序列的末尾。


```php
Task::create(['task_list_id' => 1]);
```

### 更新和删除对象

序列中的其他项目将被重新排列以保持序列一致性。

```php
$task->update(['position' => 4]);
```

```php
$task->delete();
```

### 获取对象的序列值

```php
$value = $task->getSequenceValue();
```

### 获取序列列名称

```php
$columnName = Task::getSequenceColumnName();
```

### 禁用自动排序

```php
$task->withoutSequencing()->update(['position' => 3]);
```

```php
$task->withoutSequencing()->delete();
```

### 范围查询按序列值排序结果

```php
$tasks = Task::sequenced()->get();
```

## Artisan 命令

为所有其值设置为 `null` 的记录分配序列值。

```bash
php artisan sequence:populate \\App\\Task
```

刷新一个模型的所有序列值。

```bash
php artisan sequence:flush \\App\\Task
```

### 测试

``` bash
composer test
```
### 更新日志

请参阅 [CHANGELOG](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/CHANGELOG.md) 了解最近的更新内容。

## 贡献

详情请参阅 [CONTRIBUTING](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/CONTRIBUTING.md)。

### 安全

如果您发现任何安全相关的问题，请发送电子邮件至 gustavorgentil@outlook.com，切勿使用问题跟踪器。

## 致谢

- [Gustavo Rorato Gentil](https://github.com/gurgentil)
- [Michael Slowik](https://github.com/sl0wik)
- [所有贡献者](../../contributors)

## 许可证

MIT 许可证 (MIT)。更多信息请参阅 [许可证文件](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/LICENSE.md)。

## Laravel 包模板

本包使用 [Laravel Package Boilerplate](https://laravelpackageboilerplate.com) 生成。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-05

---