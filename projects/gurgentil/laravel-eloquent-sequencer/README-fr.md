# Laravel Eloquent Sequencer

[![Dernière version](https://img.shields.io/github/release/gurgentil/laravel-eloquent-sequencer.svg?style=flat-square)](https://github.com/gurgentil/laravel-eloquent-sequencer/releases)
![Statut du workflow GitHub](https://img.shields.io/github/workflow/status/gurgentil/laravel-eloquent-sequencer/run-tests?label=tests)
[![Score de qualité](https://img.shields.io/scrutinizer/g/gurgentil/laravel-eloquent-sequencer.svg?style=flat-square)](https://scrutinizer-ci.com/g/gurgentil/laravel-eloquent-sequencer)
[![Licence MIT](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](LICENSE.md)

Ce package vous permet de créer et gérer des séquences pour vos modèles Eloquent.

## Installation

Installez le package via composer :

```bash
composer require gurgentil/laravel-eloquent-sequencer
```

## Configuration

Pour publier le fichier de configuration, exécutez :

```bash
php artisan vendor:publish --provider="Gurgentil\LaravelEloquentSequencer\LaravelEloquentSequencerServiceProvider"
```

### Paramètres de configuration

Vous pouvez modifier le nom de colonne par défaut, la valeur initiale et la stratégie de séquençage dans `config/eloquentsequencer.php` :

```php
return [
    'column_name' => 'position',
    'initial_value' => 1,
    'strategy' => 'always',
];
```

La configuration `strategy` détermine quand le séquençage doit être déclenché et accepte l'une des valeurs suivantes : `always`, `on_create`, `on_update` ou `never`.

### Configuration du modèle

L'attribut `$sequenceable` spécifie le nom de la colonne de séquence pour le modèle :

```php
protected static $sequenceable = 'order';
```

La ou les clés de relation qui regrouperont les éléments de la séquence : 

```php
protected static $sequenceableKeys = [
    'task_list_id',
];
```

Dans l'exemple ci-dessus, une liste de tâches contient de nombreuses tâches.

Pour les **relations polymorphiques**, spécifiez les deux clés de relation :

```php
protected static $sequenceableKeys = [
    'commentable_id',
    'commentable_type',
];
```

## Utilisation

Dans l'exemple ci-dessous, une liste de tâches peut contenir plusieurs tâches.

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

### Créer un objet

```php
Task::create([
    'position' => 1,
    'task_list_id' => 1,
]);
```

Si aucune valeur n'est fournie pour l'attribut sequence, l'objet sera placé à la fin de la séquence.

```php
Task::create(['task_list_id' => 1]);
```

### Mise à jour et suppression d'objets

Les autres éléments de la séquence seront réorganisés pour maintenir la cohérence de la séquence.

```php
$task->update(['position' => 4]);
```

```php
$task->delete();
```

### Obtenir la valeur de séquence d'un objet

```php
$value = $task->getSequenceValue();
```

### Obtenir le nom de la colonne de séquence

```php
$columnName = Task::getSequenceColumnName();
```

### Désactiver le séquençage automatique

```php
$task->withoutSequencing()->update(['position' => 3]);
```

```php
$task->withoutSequencing()->delete();
```

### Requête de portée pour ordonner les résultats par valeur de séquence

```php
$tasks = Task::sequenced()->get();
```

## Commandes Artisan

Attribuer des valeurs de séquence à tous les enregistrements dont les valeurs sont définies sur `null`.

```bash
php artisan sequence:populate \\App\\Task
```

Vider toutes les valeurs de séquence pour un modèle.

```bash
php artisan sequence:flush \\App\\Task
```

### Test

``` bash
composer test
```

### Journal des modifications

Veuillez consulter le [CHANGELOG](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/CHANGELOG.md) pour plus d'informations sur les changements récents.

## Contribution

Veuillez consulter le [CONTRIBUTING](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/CONTRIBUTING.md) pour les détails.

### Sécurité

Si vous découvrez des problèmes liés à la sécurité, veuillez envoyer un courriel à gustavorgentil@outlook.com au lieu d'utiliser le suivi des problèmes.

## Crédits

- [Gustavo Rorato Gentil](https://github.com/gurgentil)
- [Michael Slowik](https://github.com/sl0wik)
- [Tous les contributeurs](../../contributors)

## Licence

La licence MIT (MIT). Veuillez consulter le [fichier de licence](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/LICENSE.md) pour plus d'informations.

## Boilerplate de package Laravel

Ce package a été généré en utilisant le [Laravel Package Boilerplate](https://laravelpackageboilerplate.com).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-05

---