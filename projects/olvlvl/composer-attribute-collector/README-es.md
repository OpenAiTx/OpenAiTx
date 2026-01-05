# composer-attribute-collector

[![Release](https://img.shields.io/packagist/v/olvlvl/composer-attribute-collector.svg)](https://packagist.org/packages/olvlvl/composer-attribute-collector)
[![Code Coverage](https://coveralls.io/repos/github/olvlvl/composer-attribute-collector/badge.svg?branch=main)](https://coveralls.io/r/olvlvl/composer-attribute-collector?branch=main)
[![Downloads](https://img.shields.io/packagist/dt/olvlvl/composer-attribute-collector.svg)](https://packagist.org/packages/olvlvl/composer-attribute-collector)

**composer-attribute-collector** es un plugin de [Composer][] diseñado para _descubrir_ eficazmente los objetivos de atributos de PHP 8, y luego recuperarlos a un costo casi nulo, sin reflexión en tiempo de ejecución. Después del volcado del autoloader, recopila atributos y genera un archivo estático para un acceso rápido. Esto proporciona una manera conveniente de _descubrir_ clases, métodos o propiedades respaldados por atributos, ideal para análisis de bases de código. (Para objetivos conocidos, la reflexión tradicional sigue siendo una opción.)



#### Características

- Cero configuración
- Sin reflexión en el archivo generado
- Puede mejorar el rendimiento
- Sin dependencias (excepto Composer, por supuesto)
- Una única interfaz para obtener objetivos de atributos: clases, métodos y propiedades
- Puede almacenar en caché los descubrimientos para acelerar ejecuciones consecutivas.

> [!NOTE]
> Actualmente, el plugin soporta objetivos de clase, método, propiedad y parámetro.
> Eres bienvenido a [contribuir](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CONTRIBUTING.md) si te interesa ampliar su soporte.

> [!WARNING]
> Los atributos usados en funciones son ignorados por el momento.



#### Uso

El siguiente ejemplo demuestra cómo se pueden recuperar los objetivos y sus atributos:





```php
<?php

use olvlvl\ComposerAttributeCollector\Attributes;
use Symfony\Component\Messenger\Attribute\AsMessageHandler;
use Symfony\Component\Routing\Annotation\Route;
use Doctrine\ORM\Mapping\Column;

require_once 'vendor/autoload.php';
require_once 'vendor/attributes.php'; // <-- the file created by the plugin

// Find the target classes of the AsMessageHandler attribute.
foreach (Attributes::findTargetClasses(AsMessageHandler::class) as $target) {
    // $target->attribute is an instance of the specified attribute
    // with the actual data.
    var_dump($target->attribute, $target->name);
}

// Find the target methods of the Route attribute.
foreach (Attributes::findTargetMethods(Route::class) as $target) {
    var_dump($target->attribute, $target->class, $target->name);
}

// Find the target properties of the Column attribute.
foreach (Attributes::findTargetProperties(Column::class) as $target) {
    var_dump($target->attribute, $target->class, $target->name);
}

// Find the target method parameters of the UserInput attribute.
foreach (Attributes::findTargetParameters(UserInput::class) as $target) {
    var_dump($target->attribute, $target->class, $target->method, $target->name);
}

// Filter target methods using a predicate.
// You can also filter target classes and properties.
$predicate = fn($attribute) => is_a($attribute, Route::class, true);
# or
$predicate = Attributes::predicateForAttributeInstanceOf(Route::class);

foreach (Attributes::filterTargetMethods($predicate) as $target) {
    var_dump($target->attribute, $target->class, $target->name);
}

// Find class, method, and property attributes for the ArticleController class.
$attributes = Attributes::forClass(ArticleController::class);

var_dump($attributes->classAttributes);
var_dump($attributes->methodsAttributes);
var_dump($attributes->propertyAttributes);
```
## Comenzando

Aquí hay algunos pasos para que comiences.

### 1\. Configura el complemento (opcional)

El colector escanea automáticamente las rutas de `autoload` del archivo `composer.json` raíz para una experiencia sin configuración. Puedes sobrescribirlas mediante
`extra.composer-attribute-collector.include`.





```json
{
  "extra": {
    "composer-attribute-collector": {
      "include": [
        "src"
      ]
    }
  }
}
```

Consulta las [opciones de configuración](#configuration) para más detalles.



### 2\. Instalar el plugin

Usa [Composer][] para instalar el plugin.
Se te preguntará si confías en el plugin y deseas activarlo, selecciona `y` para continuar.

```shell
composer require olvlvl/composer-attribute-collector
```
Debería ver mensajes de registro similares a esto:


```
Generating autoload files
Generating attributes file
Generated attributes file in 9.137 ms
Generated autoload files
```

> [!TIP]
> Consulte la sección de [Preguntas Frecuentes](#frequently-asked-questions)
> para actualizar automáticamente el archivo "attributes" durante el desarrollo.



### 3\. Carga automática del archivo "attributes"

Puede requerir el archivo "attributes" usando `require_once 'vendor/attributes.php';` pero podría
preferir usar la función de carga automática de Composer:

```json
{
  "autoload": {
    "files": [
      "vendor/attributes.php"
    ]
  }
}
```
## Configuración

Aquí hay algunas formas en que puede configurar el complemento.



### Inclusión de rutas o archivos ([solo raíz][])

El colector escanea automáticamente las rutas de `autoload` del `composer.json` raíz, pero puede anular
estas mediante la propiedad `include`.

Las rutas especificadas son relativas al archivo `composer.json`, y el marcador de posición `{vendor}` se
reemplaza con la ruta a la carpeta vendor.




```json
{
  "extra": {
    "composer-attribute-collector": {
      "include": [
        "path-or-file/to/include"
      ]
    }
  }
}
```

### Excluir rutas o archivos ([solo raíz][])

Utilice la propiedad `exclude` para excluir rutas o archivos del escaneo. Esto es útil cuando los archivos
causan problemas o tienen efectos secundarios.

Las rutas especificadas son relativas al archivo `composer.json`, y el marcador de posición `{vendor}` se
reemplaza con la ruta a la carpeta vendor.

```json
{
  "extra": {
    "composer-attribute-collector": {
      "exclude": [
        "path-or-file/to/exclude"
      ]
    }
  }
}
```

### Almacenar en caché los descubrimientos entre ejecuciones

El plugin puede mantener una caché para reutilizar los descubrimientos entre ejecuciones. Para habilitar la caché,
establezca la variable de entorno `COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE` en `1`, `yes` o `true`.
Los elementos de la caché se guardan en el directorio `.composer-attribute-collector`, es posible que desee agregarlo
a su archivo `.gitignore`.

```shell
COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE=1 composer dump-autoload
```

## Casos de uso

Los casos de uso están disponibles para probar el plugin en condiciones reales:

- [Firma incompatible](cases/incompatible-signature) El plugin es capaz de recopilar atributos,
  aunque la versión del Logger PSR que usa Composer y la aplicación son incompatibles.

- [Symfony](cases/symfony) Una aplicación Symfony, creada con `symfony new`.

- [Laravel](cases/laravel) Una aplicación Laravel, creada con `laravel new`.



## Preguntas frecuentes

**¿Necesito generar un autoloader optimizado?**

No necesitas generar un autoloader optimizado para que esto funcione. El plugin usa un código similar
al de Composer para encontrar clases. Todo lo que funcione con Composer debería funcionar con el plugin.

**¿Puedo usar el plugin durante el desarrollo?**

Sí, puedes usar el plugin durante el desarrollo, pero ten en cuenta que el archivo de "atributos" solo se
genera después de que se vuelca el autoloader. Si modificas atributos tendrás que ejecutar
`composer dump-autoload` para actualizar el archivo de "atributos".

Como solución alternativa, podrías tener observadores en los directorios que contienen clases con atributos para
ejecutar `XDEBUG_MODE=off composer dump-autoload` cuando hagas cambios. [PhpStorm ofrece observadores de archivos][phpstorm-watchers]. También podrías usar [spatie/file-system-watcher][], que solo requiere
PHP. Si el plugin es demasiado lento para tu gusto, prueba ejecutar el comando con
`COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE=yes`, esto habilitará el caché y acelerará las ejecuciones consecutivas.

**¿Cómo incluyo una clase que hereda sus atributos?**

Para acelerar el proceso de recopilación, el plugin primero examina los archivos PHP como texto plano en busca de indicios de
uso de atributos. Si una clase hereda sus atributos de traits, propiedades o métodos, pero no
usa atributos por sí misma, será ignorada. Usa el atributo



`[#\olvlvl\ComposerAttributeCollector\InheritsAttributes]` para forzar la recopilación.

```php
trait UrlTrait
{
    #[UrlGetter]
    public function get_url(): string
    {
        return '/url';
    }
}

#[InheritsAttributes]
class InheritedAttributeSample
{
    use UrlTrait;
}
```

----------



## Integración Continua

El proyecto se prueba continuamente mediante [GitHub actions](https://github.com/olvlvl/composer-attribute-collector/actions).

[![Casos](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/cases.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/cases.yml)
[![Pruebas](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/test.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/test.yml)
[![Análisis Estático](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/static-analysis.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/static-analysis.yml)
[![Estilo de Código](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/code-style.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/code-style.yml)



## Código de Conducta

Este proyecto sigue un [Código de Conducta para Contribuidores](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CODE_OF_CONDUCT.md). Al participar en
este proyecto y su comunidad, se espera que respetes este código.



## Contribuir

Consulta [CONTRIBUTING](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CONTRIBUTING.md) para más detalles.



[Composer]:  https://getcomposer.org/
[root-only]: https://getcomposer.org/doc/04-schema.md#root-package
[spatie/file-system-watcher]: https://github.com/spatie/file-system-watcher
[phpstorm-watchers]: https://www.jetbrains.com/help/phpstorm/using-file-watchers.html


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-05

---