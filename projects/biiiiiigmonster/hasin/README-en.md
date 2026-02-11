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

The `hasin` is composer package based on `where in` syntax to query the relationship of `laravel ORM`, which can replace `has` based on `where exists` syntax in some business scenarios to obtain higher performance.

# Installation
| Laravel Version | Install command                                     |
|-----------------|-----------------------------------------------------|
| Laravel 12      | ``` composer require biiiiiigmonster/hasin:^5.0 ``` |
| Laravel 11      | ``` composer require biiiiiigmonster/hasin:^4.0 ``` |
| Laravel 10      | ``` composer require biiiiiigmonster/hasin:^3.0 ``` |
| Laravel 9       | ``` composer require biiiiiigmonster/hasin:^2.0 ``` |
| Laravel 5.5 ~ 8 | ``` composer require biiiiiigmonster/hasin:^1.0 ``` |

# Introductions

The relationship of `laravel ORM` is very powerful, and the query `has` based on the relationship also provides us with many flexible calling methods. However, in some cases, `has` is implemented with **where exists** syntax.

For example:
```php
// User hasMany Post
User::has('posts')->get();
```
#### `select * from users where exists (select * from posts where users.id = posts.user_id)`
> 'exists' loops through the outer table and then queries the inner table (subQuery) each time. Because the index is used for querying the inner table (the inner table is efficient, so it can be used as a large table), and the amount of outer table traversal is inevitable (try to use a small table), using exists for a large inner table can improve efficiency.

When the **User** table has a large amount of data, performance issues will arise, so the **where in** syntax greatly improves performance.

#### `select * from users where users.id in (select posts.user_id from posts)`
> 'in' performs a hash join between the outer and inner tables, first querying the inner table, then matching the inner table results with the outer table, using indexes on the outer table (the outer table is efficient and can be large). Most of the inner table needs to be queried, which is inevitable. Therefore, using 'in' with a large outer table can improve efficiency.

Therefore, the use of `has(hasMorph)` or `hasIn(hasMorphIn)` in code should be determined by **data size**

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

# Usage example

`hasIn(hasMorphIn)` supports all `Relations` in `laravel ORM`. The call mode and internal implementation are completely consistent with `has(hasMorph)` of the framework.

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

> hasMorphIn

```php
Image::hasMorphIn('imageable', [Post::class, Comment::class])->get();
```

### Nested Relation

```php
User::hasIn('posts.comments')->get();
```

# Testing
```bash
composer test
```
>**Tips**: before testing, you need to configure your database connection in the `phpunit.xml.dist`.

# License
[MIT](./LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-11

---