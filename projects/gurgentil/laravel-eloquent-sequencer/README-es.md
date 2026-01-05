# Laravel Eloquent Sequencer

[![Última Versión](https://img.shields.io/github/release/gurgentil/laravel-eloquent-sequencer.svg?style=flat-square)](https://github.com/gurgentil/laravel-eloquent-sequencer/releases)
![Estado del Flujo de Trabajo en GitHub](https://img.shields.io/github/workflow/status/gurgentil/laravel-eloquent-sequencer/run-tests?label=tests)
[![Puntuación de Calidad](https://img.shields.io/scrutinizer/g/gurgentil/laravel-eloquent-sequencer.svg?style=flat-square)](https://scrutinizer-ci.com/g/gurgentil/laravel-eloquent-sequencer)
[![Licencia MIT](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](LICENSE.md)

Este paquete te permite crear y gestionar secuencias para tus modelos Eloquent.

## Instalación

Instala el paquete vía composer:

```bash
composer require gurgentil/laravel-eloquent-sequencer
```

## Configuración

Para publicar el archivo de configuración, ejecute:

```bash
php artisan vendor:publish --provider="Gurgentil\LaravelEloquentSequencer\LaravelEloquentSequencerServiceProvider"
```

### Parámetros de configuración

Puedes cambiar el nombre de la columna predeterminada, el valor inicial y la estrategia de secuenciación en `config/eloquentsequencer.php`:

```php
return [
    'column_name' => 'position',
    'initial_value' => 1,
    'strategy' => 'always',
];
```

La configuración `strategy` determina cuándo se debe activar la secuenciación y acepta uno de los siguientes valores: `always`, `on_create`, `on_update` o `never`.

### Configuración del modelo

El atributo `$sequenceable` especifica el nombre de la columna de secuencia para el modelo:

```php
protected static $sequenceable = 'order';
```

La(s) clave(s) de relación que agruparán los elementos de la secuencia:

```php
protected static $sequenceableKeys = [
    'task_list_id',
];
```

En el ejemplo anterior, una lista de tareas tiene muchas tareas.

Para **relaciones polimórficas** especifica ambas claves de relación:

```php
protected static $sequenceableKeys = [
    'commentable_id',
    'commentable_type',
];
```

## Uso

En el ejemplo a continuación, una lista de tareas puede tener muchas tareas.

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

### Crear un objeto

```php
Task::create([
    'position' => 1,
    'task_list_id' => 1,
]);
```

Si no se proporciona un valor para el atributo de secuencia, el objeto se colocará al final de la secuencia.

```php
Task::create(['task_list_id' => 1]);
```

### Actualizar y eliminar objetos

Los otros elementos en la secuencia serán reordenados para mantener la consistencia de la secuencia.

```php
$task->update(['position' => 4]);
```

```php
$task->delete();
```

### Obtener el valor de secuencia de un objeto

```php
$value = $task->getSequenceValue();
```

### Obtener el nombre de la columna de secuencia

```php
$columnName = Task::getSequenceColumnName();
```

### Desactivar la secuenciación automática

```php
$task->withoutSequencing()->update(['position' => 3]);
```

```php
$task->withoutSequencing()->delete();
```

### Consulta de alcance para ordenar resultados por valor de secuencia

```php
$tasks = Task::sequenced()->get();
```

## Comandos Artisan

Asignar valores de secuencia a todos los registros que tienen sus valores establecidos en `null`.

```bash
php artisan sequence:populate \\App\\Task
```

Vaciar todos los valores de secuencia para un modelo.

```bash
php artisan sequence:flush \\App\\Task
```

### Pruebas

``` bash
composer test
```

### Registro de cambios

Por favor, consulte [CHANGELOG](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/CHANGELOG.md) para más información sobre los cambios recientes.

## Contribuir

Por favor, consulte [CONTRIBUTING](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/CONTRIBUTING.md) para más detalles.

### Seguridad

Si descubre algún problema relacionado con la seguridad, por favor envíe un correo a gustavorgentil@outlook.com en lugar de usar el rastreador de incidencias.

## Créditos

- [Gustavo Rorato Gentil](https://github.com/gurgentil)
- [Michael Slowik](https://github.com/sl0wik)
- [Todos los colaboradores](../../contributors)

## Licencia

La licencia MIT (MIT). Por favor, consulte [Archivo de licencia](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/LICENSE.md) para más información.

## Plantilla de paquete Laravel

Este paquete fue generado usando la [Plantilla de paquete Laravel](https://laravelpackageboilerplate.com).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-05

---