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

`hasin` は `where in` 構文に基づく composer パッケージで、`laravel ORM` のリレーションシップをクエリするためのものであり、特定のビジネスシナリオにおいては、`where exists` 構文に基づく `has` を置き換えてより高いパフォーマンスを得ることができます。

# インストール
| Laravel バージョン | インストールコマンド                                |
|--------------------|----------------------------------------------------|
| Laravel 12         | ``` composer require biiiiiigmonster/hasin:^5.0 ``` |
| Laravel 11         | ``` composer require biiiiiigmonster/hasin:^4.0 ``` |
| Laravel 10         | ``` composer require biiiiiigmonster/hasin:^3.0 ``` |
| Laravel 9          | ``` composer require biiiiiigmonster/hasin:^2.0 ``` |
| Laravel 5.5 ~ 8    | ``` composer require biiiiiigmonster/hasin:^1.0 ``` |

# 紹介

`laravel ORM` のリレーションシップは非常に強力であり、リレーションシップに基づくクエリの `has` も多くの柔軟な呼び出し方法を提供しています。しかし、場合によっては `has` は **where exists** 構文で実装されています。

例えば：
```php
// User hasMany Post
User::has('posts')->get();
```
#### `select * from users where exists (select * from posts where users.id = posts.user_id)`
> 'exists' は外部テーブルにループし、その都度内部テーブル（サブクエリ）を照会する。内部テーブルのクエリで使用されるインデックス（内部テーブルは効率的で大きなテーブルとして使用可能）と、外部テーブルのどれだけを走査するかに依存するため（小さなテーブルを使用することを試みる）、大きな内部テーブルに対して exists を使用すると効率が向上する。

**User** テーブルに大量のデータがある場合、パフォーマンスの問題が発生するため、**where in** 構文を使用するとパフォーマンスが大幅に改善される。

#### `select * from users where users.id in (select posts.user_id from posts)`
> 'in' は外部テーブルと内部テーブルをハッシュ結合し、まず内部テーブルをクエリし、その結果を外部テーブルと照合し、外部テーブルにインデックスを使用する（外部は効率的で大きなテーブルに使用可能）。ほとんどの内部テーブルをクエリする必要があり、これは避けられない。したがって、大きな外部テーブルに対して 'in' を使用すると効率が向上する。

したがって、コード内での `has(hasMorph)` または `hasIn(hasMorphIn)` の使用は **データサイズ** によって決定すべきである。

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

# 使用例

`hasIn(hasMorphIn)` は `laravel ORM` のすべての `Relations` をサポートします。呼び出し方法と内部実装はフレームワークの `has(hasMorph)` と完全に一致しています。

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

### ネストされたリレーション

```php
User::hasIn('posts.comments')->get();
```

# テスト
```bash
composer test
```
>**ヒント**: テストを行う前に、`phpunit.xml.dist`でデータベース接続を設定する必要があります。

# ライセンス
[MIT](./LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-11

---