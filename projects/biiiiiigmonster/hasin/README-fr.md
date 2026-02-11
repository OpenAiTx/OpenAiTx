English | [中文](https://raw.githubusercontent.com/biiiiiigmonster/hasin/laravel-v12/./README-CN.md)

<div align="center">

# LARAVEL HASIN

[![Latest Version on Packagist](https://img.shields.io/packagist/v/biiiiiigmonster/hasin.svg?style=flat-square)](https://packagist.org/packages/biiiiiigmonster/hasin)
[![GitHub Tests Action Status](https://img.shields.io/github/actions/workflow/status/biiiiiigmonster/hasin/run-tests.yml?branch=master&label=tests&style=flat-square)](https://github.com/biiiiiigmonster/hasin/actions?query=workflow%3Arun-tests+branch%3Amaster)
[![GitHub Code Style Action Status](https://img.shields.io/github/actions/workflow/status/biiiiiigmonster/hasin/fix-php-code-style-issues.yml?branch=master&label=code%20style&style=flat-square)](https://github.com/biiiiiigmonster/hasin/actions?query=workflow%3A"Fix+PHP+code+style+issues"+branch%3Amaster)
[![Coverage Status](https://coveralls.io/repos/github/biiiiiigmonster/hasin/badge.svg?branch=master)](https://coveralls.io/github/biiiiiigmonster/hasin?branch=master)
[![Scrutinizer Code Quality](https://img.shields.io/scrutinizer/g/biiiiiigmonster/hasin.svg?label=Scrutinizer&style=flat-square)](https://scrutinizer-ci.com/g/biiiiiigmonster/hasin/)
[![Total Downloads](https://img.shields.io/packagist/dt/biiiiiigmonster/hasin.svg?style=flat-square)](https://packagist.org/packages/biiiiiigmonster/hasin)

</div>

Le package `hasin` est un package composer basé sur la syntaxe `where in` pour interroger la relation de l’`ORM Laravel`, qui peut remplacer `has` basé sur la syntaxe `where exists` dans certains scénarios métier afin d’obtenir de meilleures performances.

# Installation
| Version de Laravel | Commande d’installation                                |
|--------------------|-------------------------------------------------------|
| Laravel 12         | ``` composer require biiiiiigmonster/hasin:^5.0 ```  |
| Laravel 11         | ``` composer require biiiiiigmonster/hasin:^4.0 ```  |
| Laravel 10         | ``` composer require biiiiiigmonster/hasin:^3.0 ```  |
| Laravel 9          | ``` composer require biiiiiigmonster/hasin:^2.0 ```  |
| Laravel 5.5 ~ 8    | ``` composer require biiiiiigmonster/hasin:^1.0 ```  |

# Présentations

La relation de l’`ORM Laravel` est très puissante, et la requête `has` basée sur la relation nous offre aussi de nombreuses méthodes d’appel flexibles. Cependant, dans certains cas, `has` est implémenté avec la syntaxe **where exists**.

Par exemple :
```php
// User hasMany Post
User::has('posts')->get();
```
#### `select * from users where exists (select * from posts where users.id = posts.user_id)`
> 'exists' est une boucle vers la table externe, puis interroge la table interne (sous-requête) à chaque fois. Parce que l'index utilisé pour la requête de la table interne (la table interne est efficace, donc elle peut être utilisée comme une grande table), et combien de la table externe doit être parcourue, c'est inévitable (essayez d'utiliser une petite table), donc l'utilisation de exists pour la grande table interne peut accélérer l'efficacité.

Lorsque la table **User** contient une grande quantité de données, il y aura des problèmes de performance, donc la syntaxe **where in** améliorera grandement les performances.

#### `select * from users where users.id in (select posts.user_id from posts)`
> 'in' est une connexion par hachage entre la table externe et la table interne, on interroge d'abord la table interne, puis on fait correspondre le résultat de la table interne avec la table externe, et on utilise l'index pour la table externe (la table externe est efficace, et de grandes tables peuvent être utilisées). La plupart des tables internes doivent être interrogées, ce qui est inévitable. Par conséquent, l'utilisation de 'in' avec une grande table externe peut accélérer l'efficacité.

Par conséquent, l'utilisation de `has(hasMorph)` ou `hasIn(hasMorphIn)` dans le code doit être déterminée en fonction de la **taille des données**.

```php
/**
 * SQL:
 * 
 * select * from `users` 
 * where exists 
 *   ( 
 *      select * from `posts` 
 *      where `users`.`id` = `posts`.`user_id` 
 *   ) 
 * limit 10 offset 0
 */
$users = User::has('posts')->paginate(10);

/**
 * SQL:
 * 
 * select * from `users` 
 * where `users`.`id` in  
 *   ( 
 *      select `posts`.`user_id` from `posts` 
 *   ) 
 * limit 10 offset 0
 */
$users = User::hasIn('posts')->paginate(10);
```

# Exemple d'utilisation

`hasIn(hasMorphIn)` prend en charge toutes les `Relations` dans `laravel ORM`. Le mode d'appel et l'implémentation interne sont entièrement cohérents avec `has(hasMorph)` du framework.

> hasIn

```php
// hasIn
User::hasIn('posts')->get();

// orHasIn
User::where('age', '>', 18)->orHasIn('posts')->get();

// doesntHaveIn
User::doesntHaveIn('posts')->get();

// orDoesntHaveIn
User::where('age', '>', 18)->orDoesntHaveIn('posts')->get();
```
> whereHasIn


```php
// whereHasIn
User::whereHasIn('posts', function ($query) {
    $query->where('votes', '>', 10);
})->get();

// orWhereHasIn
User::where('age', '>', 18)->orWhereHasIn('posts', function ($query) {
    $query->where('votes', '>', 10);
})->get();

// whereDoesntHaveIn
User::whereDoesntHaveIn('posts', function ($query) {
    $query->where('votes', '>', 10);
})->get();

// orWhereDoesntHaveIn
User::where('age', '>', 18)->orWhereDoesntHaveIn('posts', function ($query) {
    $query->where('votes', '>', 10);
})->get();
```

> aMorphIn

```php
Image::hasMorphIn('imageable', [Post::class, Comment::class])->get();
```

### Relation Imbriquée

```php
User::hasIn('posts.comments')->get();
```

# Test
```bash
composer test
```
>**Conseils** : avant de tester, vous devez configurer votre connexion à la base de données dans le fichier `phpunit.xml.dist`.

# Licence
[MIT](./LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-11

---