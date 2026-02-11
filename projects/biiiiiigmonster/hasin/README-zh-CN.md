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

`hasin` 是一个基于 `where in` 语法查询 `laravel ORM` 关系的 composer 包，在某些业务场景中可以替代基于 `where exists` 语法的 `has`，以获得更高的性能。

# 安装
| Laravel 版本    | 安装命令                                             |
|-----------------|-----------------------------------------------------|
| Laravel 12      | ``` composer require biiiiiigmonster/hasin:^5.0 ``` |
| Laravel 11      | ``` composer require biiiiiigmonster/hasin:^4.0 ``` |
| Laravel 10      | ``` composer require biiiiiigmonster/hasin:^3.0 ``` |
| Laravel 9       | ``` composer require biiiiiigmonster/hasin:^2.0 ``` |
| Laravel 5.5 ~ 8 | ``` composer require biiiiiigmonster/hasin:^1.0 ``` |

# 介绍

`laravel ORM` 的关系非常强大，基于关系的查询 `has` 也为我们提供了许多灵活的调用方式。然而，在某些情况下，`has` 是通过 **where exists** 语法实现的。

例如：
```php
// User hasMany Post
User::has('posts')->get();
```
#### `select * from users where exists (select * from posts where users.id = posts.user_id)`
> 'exists' 是对外部表的循环，然后每次查询内部表（子查询）。因为内部表查询使用了索引（内部表效率高，所以可以作为大表使用），而且外部表需要遍历多少是不可避免的（尽量使用小表），所以对大内部表使用 exists 能提高效率。

当 **User** 表数据量很大时，会有性能问题，因此 **where in** 语法会大幅提升性能。

#### `select * from users where users.id in (select posts.user_id from posts)`
> 'in' 是对外表和内表进行哈希连接，先查询内表，然后用内表结果匹配外表，并对外表使用索引（外表效率高，可以使用大表）。内表大部分需要查询，这是不可避免的。因此，对大外表使用 'in' 能提升效率。

因此，代码中使用 `has(hasMorph)` 或 `hasIn(hasMorphIn)` 应根据 **数据大小** 来决定。

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

# 使用示例

`hasIn(hasMorphIn)` 支持 `laravel ORM` 中的所有 `Relations`。调用方式和内部实现与框架的 `has(hasMorph)` 完全一致。

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

### 嵌套关系

```php
User::hasIn('posts.comments')->get();
```

# 测试
```bash
composer test
```
>**提示**：在测试之前，您需要在 `phpunit.xml.dist` 中配置您的数据库连接。

# 许可证
[MIT](./LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-11

---