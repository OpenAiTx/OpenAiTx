![Laravel Attribute Events](/../gh-pages/attribute-events.svg#gh-light-mode-only)
![Laravel Attribute Events](/../gh-pages/attribute-events-dark.svg#gh-dark-mode-only)

<p align="center">
  <a href="https://app.travis-ci.com/jpkleemans/attribute-events" target="_blank"><img src="https://img.shields.io/travis/com/jpkleemans/attribute-events?label=tests&style=flat-square" alt="Statut de la build"></a>
  <a href="https://github.com/jpkleemans/attribute-events/commits" target="_blank"><img src="https://img.shields.io/github/last-commit/jpkleemans/attribute-events?label=mis+à+jour&style=flat-square" alt="Dernière mise à jour"></a>
  <a href="https://packagist.org/packages/jpkleemans/attribute-events"><img src="https://img.shields.io/packagist/v/jpkleemans/attribute-events?label=stable&style=flat-square" alt="Dernière version stable"></a>
  <a href="https://packagist.org/packages/jpkleemans/attribute-events"><img src="https://img.shields.io/packagist/l/jpkleemans/attribute-events?style=flat-square" alt="Licence"></a>
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

Les modèles Eloquent déclenchent plusieurs événements utiles tout au long de leur cycle de vie, comme `created` et `deleted`. Cependant, il y a généralement beaucoup plus d'événements significatifs pour l'entreprise qui se produisent pendant la vie d'un modèle. Avec cette bibliothèque, vous pouvez les capturer en associant les changements d'attributs à vos propres classes d'événements.

## Installation
```bash
composer require jpkleemans/attribute-events
```

## Comment l'utiliser
Utilisez le trait `Kleemans\AttributeEvents` dans votre modèle et ajoutez les attributs à la propriété `$dispatchesEvents` :

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

Les événements d'attribut seront déclenchés après que le modèle mis à jour soit enregistré. Chaque événement reçoit l'instance du modèle via son constructeur.

> Pour plus d'informations sur les événements de modèle et la propriété `$dispatchesEvents`, consultez la <a href="https://laravel.com/docs/eloquent#events" target="_blank">Documentation Laravel</a>

## Écoute
Vous pouvez maintenant vous abonner aux événements via le tableau `$listen` du `EventServiceProvider`, ou manuellement avec des écouteurs basés sur des Closures :

```php
Event::listen(function (OrderCanceled $event) {
    // Restock inventory
});
```
Ou poussez des mises à jour en temps réel à vos utilisateurs, en utilisant la fonctionnalité de <a href="https://laravel.com/docs/broadcasting" target="_blank">diffusion</a> de Laravel :


```js
Echo.channel('orders')
    .listen('OrderShipped', (event) => {
        // Display a notification
    })
```

## Attributs JSON
Pour les attributs stockés en JSON, vous pouvez utiliser l'opérateur `->` :

```php
protected $dispatchesEvents = [
    'payment->status:completed' => PaymentCompleted::class,
];
```
## Accesseurs
Pour des modifications d'état plus complexes, vous pouvez utiliser des attributs définis par un <a href="https://laravel.com/docs/eloquent-mutators#defining-an-accessor" target="_blank">accesseur</a> :


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

> Vous pouvez également utiliser la [nouvelle façon de définir des accesseurs](https://laravel.com/docs/9.x/releases#eloquent-accessors-and-mutators) introduite dans Laravel 9.

## En savoir plus
- [« Découplez votre code Laravel en utilisant les événements d’attribut »](https://jpkleemans.medium.com/decouple-your-laravel-code-using-attribute-events-de8f2528f46a) par Jan-Paul Kleemans
- [Documentation Laravel sur les événements de modèle](https://laravel.com/docs/eloquent#events)

## Sponsors

<a href="https://www.nexxtmove.nl/" target="_blank">
  <img src="https://raw.githubusercontent.com/jpkleemans/attribute-events/gh-pages/nexxtmove-logo.svg" alt="Logo Nexxtmove" width="200">
</a>

Merci à <a href="https://www.nexxtmove.nl/" target="_blank">Nexxtmove</a> pour avoir sponsorisé le développement de ce projet.  
Votre logo ou nom ici ? [Sponsorisez ce projet](https://github.com/sponsors/jpkleemans).

## Licence

Code publié sous la [Licence MIT](https://github.com/jpkleemans/attribute-events/blob/master/LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-11

---