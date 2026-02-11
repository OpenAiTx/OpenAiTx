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

`hasin`은 `laravel ORM`의 관계를 조회하기 위한 `where in` 구문을 기반으로 한 composer 패키지로, 일부 비즈니스 시나리오에서 더 높은 성능을 얻기 위해 `where exists` 구문을 기반으로 하는 `has`를 대체할 수 있습니다.

# 설치
| Laravel 버전  | 설치 명령어                                         |
|---------------|----------------------------------------------------|
| Laravel 12    | ``` composer require biiiiiigmonster/hasin:^5.0 ``` |
| Laravel 11    | ``` composer require biiiiiigmonster/hasin:^4.0 ``` |
| Laravel 10    | ``` composer require biiiiiigmonster/hasin:^3.0 ``` |
| Laravel 9     | ``` composer require biiiiiigmonster/hasin:^2.0 ``` |
| Laravel 5.5 ~ 8 | ``` composer require biiiiiigmonster/hasin:^1.0 ``` |

# 소개

`laravel ORM`의 관계 기능은 매우 강력하며, 관계를 기반으로 한 `has` 쿼리는 다양한 유연한 호출 방식을 제공합니다. 그러나 경우에 따라 `has`는 **where exists** 구문으로 구현됩니다.

예를 들어:
```php
// User hasMany Post
User::has('posts')->get();
```
#### `select * from users where exists (select * from posts where users.id = posts.user_id)`
> 'exists'는 외부 테이블을 루프 돌면서 내부 테이블(subQuery)을 매번 쿼리하는 방식입니다. 내부 테이블 쿼리에 사용되는 인덱스(내부 테이블이 효율적이므로 큰 테이블로 사용 가능)와 외부 테이블을 얼마나 많이 순회해야 하는지에 따라 불가피합니다(작은 테이블 사용 권장). 따라서 큰 내부 테이블에 exists를 사용하면 효율성이 향상될 수 있습니다.

**User** 테이블에 데이터가 많을 경우 성능 문제가 발생하므로, **where in** 구문이 성능을 크게 향상시킵니다.

#### `select * from users where users.id in (select posts.user_id from posts)`
> 'in'은 외부 테이블과 내부 테이블을 해시 연결하는 것으로, 먼저 내부 테이블을 쿼리한 후 내부 테이블 결과와 외부 테이블을 매칭하며, 외부 테이블에는 인덱스를 사용합니다(외부 테이블이 효율적이며 큰 테이블도 사용 가능). 내부 테이블 대부분을 쿼리해야 하는 것은 불가피합니다. 따라서 큰 외부 테이블에 'in'을 사용하면 효율성이 향상됩니다.

따라서 코드에서 `has(hasMorph)` 또는 `hasIn(hasMorphIn)` 사용은 **데이터 크기**에 따라 결정해야 합니다.

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

# 사용 예시

`hasIn(hasMorphIn)`은 `laravel ORM`의 모든 `Relations`를 지원합니다. 호출 방식과 내부 구현은 프레임워크의 `has(hasMorph)`와 완전히 일치합니다.

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

### 중첩 관계

```php
User::hasIn('posts.comments')->get();
```

# 테스트
```bash
composer test
```
>**팁**: 테스트 전에 `phpunit.xml.dist`에서 데이터베이스 연결을 구성해야 합니다.

# 라이선스
[MIT](./LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-11

---