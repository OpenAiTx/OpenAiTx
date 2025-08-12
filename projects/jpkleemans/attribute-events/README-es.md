![Eventos de Atributos de Laravel](/../gh-pages/attribute-events.svg#gh-light-mode-only)
![Eventos de Atributos de Laravel](/../gh-pages/attribute-events-dark.svg#gh-dark-mode-only)

<p align="center">
  <a href="https://app.travis-ci.com/jpkleemans/attribute-events" target="_blank"><img src="https://img.shields.io/travis/com/jpkleemans/attribute-events?label=tests&style=flat-square" alt="Estado de la Construcción"></a>
  <a href="https://github.com/jpkleemans/attribute-events/commits" target="_blank"><img src="https://img.shields.io/github/last-commit/jpkleemans/attribute-events?label=actualizado&style=flat-square" alt="Última Actualización"></a>
  <a href="https://packagist.org/packages/jpkleemans/attribute-events"><img src="https://img.shields.io/packagist/v/jpkleemans/attribute-events?label=estable&style=flat-square" alt="Última Versión Estable"></a>
  <a href="https://packagist.org/packages/jpkleemans/attribute-events"><img src="https://img.shields.io/packagist/l/jpkleemans/attribute-events?style=flat-square" alt="Licencia"></a>
</p>

```php
class Order extends Model
{
    protected $dispatchesEvents = [
        'status:shipped' => OrderShipped::class,
        'note:*' => OrderNoteChanged::class,
    ];
}
```

Los modelos Eloquent disparan varios eventos útiles a lo largo de su ciclo de vida, como `created` y `deleted`. Sin embargo, generalmente hay muchos más eventos significativos para el negocio que ocurren durante la vida de un modelo. Con esta biblioteca puedes capturar esos, mapeando los cambios de atributos a tus propias clases de eventos.

## Instalación
```bash
composer require jpkleemans/attribute-events
```

## Cómo usarlo
Utilice el trait `Kleemans\AttributeEvents` en su modelo y agregue los atributos a la propiedad `$dispatchesEvents`:

```php
class Order extends Model
{
    use AttributeEvents;

    protected $dispatchesEvents = [
        'created'         => OrderPlaced::class,
        'status:canceled' => OrderCanceled::class,
        'note:*'          => OrderNoteChanged::class,
    ];
}
```

Los eventos de atributo se enviarán después de que el modelo actualizado se guarde. Cada evento recibe la instancia del modelo a través de su constructor.

> Para más información sobre eventos de modelo y la propiedad `$dispatchesEvents`, visite la <a href="https://laravel.com/docs/eloquent#events" target="_blank">Documentación de Laravel</a>

## Escuchando
Ahora puede suscribirse a los eventos a través del arreglo `$listen` del `EventServiceProvider`, o manualmente con escuchas basadas en Closure:

```php
Event::listen(function (OrderCanceled $event) {
    // Restock inventory
});
```

O envíe actualizaciones en tiempo real a sus usuarios, utilizando la función de <a href="https://laravel.com/docs/broadcasting" target="_blank">transmisión</a> de Laravel:

```js
Echo.channel('orders')
    .listen('OrderShipped', (event) => {
        // Display a notification
    })
```

## Atributos JSON
Para atributos almacenados como JSON, puedes usar el operador `->`:

```php
protected $dispatchesEvents = [
    'payment->status:completed' => PaymentCompleted::class,
];
```

## Accesores
Para cambios de estado más complejos, puedes usar atributos definidos por un <a href="https://laravel.com/docs/eloquent-mutators#defining-an-accessor" target="_blank">accesor</a>:

```php
class Product extends Model
{
    protected $dispatchesEvents = [
        'low_stock:true' => ProductReachedLowStock::class,
    ];

    public function getLowStockAttribute(): bool
    {
        return $this->stock <= 3;
    }
}
```
> También puedes usar la [nueva forma de definir accesores](https://laravel.com/docs/9.x/releases#eloquent-accessors-and-mutators) introducida en Laravel 9.

## Aprende más
- [“Desacopla tu código Laravel usando eventos de atributos”](https://jpkleemans.medium.com/decouple-your-laravel-code-using-attribute-events-de8f2528f46a) por Jan-Paul Kleemans
- [Documentación de Laravel sobre eventos de modelos](https://laravel.com/docs/eloquent#events)

## Patrocinadores

<a href="https://www.nexxtmove.nl/" target="_blank">
  <img src="https://raw.githubusercontent.com/jpkleemans/attribute-events/gh-pages/nexxtmove-logo.svg" alt="Logo de Nexxtmove" width="200">
</a>

Gracias a <a href="https://www.nexxtmove.nl/" target="_blank">Nexxtmove</a> por patrocinar el desarrollo de este proyecto.  
¿Tu logo o nombre aquí? [Patrocina este proyecto](https://github.com/sponsors/jpkleemans).

## Licencia

Código liberado bajo la [Licencia MIT](https://github.com/jpkleemans/attribute-events/blob/master/LICENSE).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-11

---