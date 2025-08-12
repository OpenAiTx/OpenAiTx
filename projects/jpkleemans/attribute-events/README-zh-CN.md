![Laravel Attribute Events](/../gh-pages/attribute-events.svg#gh-light-mode-only)
![Laravel Attribute Events](/../gh-pages/attribute-events-dark.svg#gh-dark-mode-only)

<p align="center">
  <a href="https://app.travis-ci.com/jpkleemans/attribute-events" target="_blank"><img src="https://img.shields.io/travis/com/jpkleemans/attribute-events?label=tests&style=flat-square" alt="构建状态"></a>
  <a href="https://github.com/jpkleemans/attribute-events/commits" target="_blank"><img src="https://img.shields.io/github/last-commit/jpkleemans/attribute-events?label=更新于&style=flat-square" alt="最后更新"></a>
  <a href="https://packagist.org/packages/jpkleemans/attribute-events"><img src="https://img.shields.io/packagist/v/jpkleemans/attribute-events?label=稳定版&style=flat-square" alt="最新稳定版本"></a>
  <a href="https://packagist.org/packages/jpkleemans/attribute-events"><img src="https://img.shields.io/packagist/l/jpkleemans/attribute-events?style=flat-square" alt="许可证"></a>
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

Eloquent 模型在其生命周期内会触发多个方便的事件，例如 `created` 和 `deleted`。然而，模型生命周期中通常会发生更多具有业务意义的事件。使用此库，您可以通过将属性变化映射到您自己的事件类来捕获这些事件。

## 安装
```bash
composer require jpkleemans/attribute-events
```

## 如何使用
在您的模型中使用 `Kleemans\AttributeEvents` trait，并将属性添加到 `$dispatchesEvents` 属性中：

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

属性事件将在更新后的模型保存后分发。每个事件通过其构造函数接收模型的实例。

> 有关模型事件和 `$dispatchesEvents` 属性的更多信息，请访问 <a href="https://laravel.com/docs/eloquent#events" target="_blank">Laravel 文档</a>

## 监听
现在，您可以通过 `EventServiceProvider` 的 `$listen` 数组订阅事件，或使用基于闭包的监听器手动订阅：

```php
Event::listen(function (OrderCanceled $event) {
    // Restock inventory
});
```
或者使用 Laravel 的 <a href="https://laravel.com/docs/broadcasting" target="_blank">广播</a> 功能，向您的用户推送实时更新：


```js
Echo.channel('orders')
    .listen('OrderShipped', (event) => {
        // Display a notification
    })
```

## JSON 属性
对于以 JSON 格式存储的属性，您可以使用 `->` 操作符：

```php
protected $dispatchesEvents = [
    'payment->status:completed' => PaymentCompleted::class,
];
```

## 访问器
对于更复杂的状态变化，您可以使用由<a href="https://laravel.com/docs/eloquent-mutators#defining-an-accessor" target="_blank">访问器</a>定义的属性：

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

> 您也可以使用 Laravel 9 中引入的 [定义访问器的新方法](https://laravel.com/docs/9.x/releases#eloquent-accessors-and-mutators)。

## 了解更多
- [“使用属性事件解耦您的 Laravel 代码”](https://jpkleemans.medium.com/decouple-your-laravel-code-using-attribute-events-de8f2528f46a) 作者 Jan-Paul Kleemans
- [Laravel 模型事件文档](https://laravel.com/docs/eloquent#events)

## 赞助商

<a href="https://www.nexxtmove.nl/" target="_blank">
  <img src="https://raw.githubusercontent.com/jpkleemans/attribute-events/gh-pages/nexxtmove-logo.svg" alt="Nexxtmove 标志" width="200">
</a>

感谢 <a href="https://www.nexxtmove.nl/" target="_blank">Nexxtmove</a> 赞助本项目的开发。  
您的标志或名称在此？[赞助此项目](https://github.com/sponsors/jpkleemans)。

## 许可协议

代码基于 [MIT 许可协议](https://github.com/jpkleemans/attribute-events/blob/master/LICENSE) 发布。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-11

---