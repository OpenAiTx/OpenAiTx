# Laravel Eloquent Sequencer

[![Latest Version](https://img.shields.io/github/release/gurgentil/laravel-eloquent-sequencer.svg?style=flat-square)](https://github.com/gurgentil/laravel-eloquent-sequencer/releases)
![GitHub Workflow Status](https://img.shields.io/github/workflow/status/gurgentil/laravel-eloquent-sequencer/run-tests?label=tests)
[![Quality Score](https://img.shields.io/scrutinizer/g/gurgentil/laravel-eloquent-sequencer.svg?style=flat-square)](https://scrutinizer-ci.com/g/gurgentil/laravel-eloquent-sequencer)
[![MIT Licensed](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](LICENSE.md)

This package allows you to create and manage sequences for your Eloquent models.

## Installation

Install the package via composer:

```bash
composer require gurgentil/laravel-eloquent-sequencer
```

## Configuration

To publish the configuration file run:

```bash
php artisan vendor:publish --provider="Gurgentil\LaravelEloquentSequencer\LaravelEloquentSequencerServiceProvider"
```

### Configuration parameters

You can change the default colum name, the initial value and the sequencing strategy in `config/eloquentsequencer.php`:

```php
return [
    'column_name' => 'position',
    'initial_value' => 1,
    'strategy' => 'always',
];
```

The `strategy` configuration determines when sequencing should be triggered and accepts one of the following values: `always`, `on_create`, `on_update` or `never`.

### Model configuration

The `$sequenceable` attribute specifies the sequence column name for the model:

```php
protected static $sequenceable = 'order';
```

The relationship key(s) that will group the sequence items together:

```php
protected static $sequenceableKeys = [
    'task_list_id',
];
```

In the example above, a task list has many tasks.

For **polymorphic relationships** specify both relationship keys:

```php
protected static $sequenceableKeys = [
    'commentable_id',
    'commentable_type',
];
```

## Usage

In the example below, a task list may have many tasks.

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

### Create an object

```php
Task::create([
    'position' => 1,
    'task_list_id' => 1,
]);
```

If no value is provided for the sequence attribute, the object will be placed at the end of the sequence.

```php
Task::create(['task_list_id' => 1]);
```

### Update and delete objects

The other items in the sequence will be rearranged to keep the sequence consistent.

```php
$task->update(['position' => 4]);
```

```php
$task->delete();
```

### Get sequence value of an object

```php
$value = $task->getSequenceValue();
```

### Get sequence column name

```php
$columnName = Task::getSequenceColumnName();
```

### Disable automatic sequencing

```php
$task->withoutSequencing()->update(['position' => 3]);
```

```php
$task->withoutSequencing()->delete();
```

### Scope query to order results by sequence value

```php
$tasks = Task::sequenced()->get();
```

## Artisan commands

Assign sequence values to all records that have their values set to `null`.

```bash
php artisan sequence:populate \\App\\Task
```

Flush all sequence values for a model.

```bash
php artisan sequence:flush \\App\\Task
```

### Testing

``` bash
composer test
```

### Changelog

Please see [CHANGELOG](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/CHANGELOG.md) for more information what has changed recently.

## Contributing

Please see [CONTRIBUTING](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/CONTRIBUTING.md) for details.

### Security

If you discover any security related issues, please email gustavorgentil@outlook.com instead of using the issue tracker.

## Credits

- [Gustavo Rorato Gentil](https://github.com/gurgentil)
- [Michael Slowik](https://github.com/sl0wik)
- [All Contributors](../../contributors)

## License

The MIT License (MIT). Please see [License File](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/LICENSE.md) for more information.

## Laravel Package Boilerplate

This package was generated using the [Laravel Package Boilerplate](https://laravelpackageboilerplate.com).
