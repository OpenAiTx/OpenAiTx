English | [中文](https://raw.githubusercontent.com/biiiiiigmonster/hasin/laravel-v12/./README-CN.md)

<div align="center">

# LARAVEL HASIN

[![Última versión en Packagist](https://img.shields.io/packagist/v/biiiiiigmonster/hasin.svg?style=flat-square)](https://packagist.org/packages/biiiiiigmonster/hasin)
[![Estado de la acción de pruebas en GitHub](https://img.shields.io/github/actions/workflow/status/biiiiiigmonster/hasin/run-tests.yml?branch=master&label=tests&style=flat-square)](https://github.com/biiiiiigmonster/hasin/actions?query=workflow%3Arun-tests+branch%3Amaster)
[![Estado de la acción de estilo de código en GitHub](https://img.shields.io/github/actions/workflow/status/biiiiiigmonster/hasin/fix-php-code-style-issues.yml?branch=master&label=code%20style&style=flat-square)](https://github.com/biiiiiigmonster/hasin/actions?query=workflow%3A"Fix+PHP+code+style+issues"+branch%3Amaster)
[![Estado de cobertura](https://coveralls.io/repos/github/biiiiiigmonster/hasin/badge.svg?branch=master)](https://coveralls.io/github/biiiiiigmonster/hasin?branch=master)
[![Calidad del código en Scrutinizer](https://img.shields.io/scrutinizer/g/biiiiiigmonster/hasin.svg?label=Scrutinizer&style=flat-square)](https://scrutinizer-ci.com/g/biiiiiigmonster/hasin/)
[![Descargas totales](https://img.shields.io/packagist/dt/biiiiiigmonster/hasin.svg?style=flat-square)](https://packagist.org/packages/biiiiiigmonster/hasin)

</div>

El paquete `hasin` es un paquete de composer basado en la sintaxis `where in` para consultar la relación del `laravel ORM`, que puede reemplazar `has` basado en la sintaxis `where exists` en algunos escenarios de negocio para obtener un mayor rendimiento.

# Instalación
| Versión de Laravel | Comando de instalación                              |
|--------------------|----------------------------------------------------|
| Laravel 12         | ``` composer require biiiiiigmonster/hasin:^5.0 ``` |
| Laravel 11         | ``` composer require biiiiiigmonster/hasin:^4.0 ``` |
| Laravel 10         | ``` composer require biiiiiigmonster/hasin:^3.0 ``` |
| Laravel 9          | ``` composer require biiiiiigmonster/hasin:^2.0 ``` |
| Laravel 5.5 ~ 8    | ``` composer require biiiiiigmonster/hasin:^1.0 ``` |

# Introducción

La relación del `laravel ORM` es muy poderosa, y la consulta `has` basada en la relación también nos ofrece muchos métodos de llamada flexibles. Sin embargo, en algunos casos, `has` se implementa con sintaxis de **where exists**.

Por ejemplo:
```php
// User hasMany Post
User::has('posts')->get();
```
#### `select * from users where exists (select * from posts where users.id = posts.user_id)`
> 'exists' es un bucle hacia la tabla externa, y luego consulta la tabla interna (subconsulta) cada vez. Debido a que el índice se usa para la consulta de la tabla interna (la tabla interna es eficiente, por lo que puede usarse como tabla grande), y cuánto de la tabla externa necesita ser recorrida, es inevitable (intenta usar una tabla pequeña), por lo que el uso de exists para la tabla interna grande puede acelerar la eficiencia.

Cuando la tabla **User** tiene una gran cantidad de datos, habrá problemas de rendimiento, por lo que la sintaxis **where in** mejorará mucho el rendimiento.

#### `select * from users where users.id in (select posts.user_id from posts)`
> 'in' es para conectar en hash la tabla externa y la interna, primero consulta la tabla interna, luego coincide el resultado de la tabla interna con la externa, y usa el índice para la tabla externa (la externa es eficiente, y se pueden usar tablas grandes). La mayoría de las tablas internas necesitan ser consultadas, lo cual es inevitable. Por lo tanto, usar 'in' con una tabla externa grande puede acelerar la eficiencia.

Por lo tanto, el uso de `has(hasMorph)` o `hasIn(hasMorphIn)` en el código debe determinarse según el **tamaño de los datos**

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

# Ejemplo de uso

`hasIn(hasMorphIn)` soporta todas las `Relations` en el `ORM de laravel`. El modo de llamada y la implementación interna son completamente consistentes con `has(hasMorph)` del framework.

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

> tieneMorphIn

```php
Image::hasMorphIn('imageable', [Post::class, Comment::class])->get();
```

### Relación Anidada

```php
User::hasIn('posts.comments')->get();
```
# Pruebas

```bash
composer test
```
>**Consejos**: antes de realizar las pruebas, necesita configurar la conexión a su base de datos en el archivo `phpunit.xml.dist`.

# Licencia
[MIT](./LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-11

---