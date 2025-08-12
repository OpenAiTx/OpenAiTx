![Laravel Attribute Events](/../gh-pages/attribute-events.svg#gh-light-mode-only)
![Laravel Attribute Events](/../gh-pages/attribute-events-dark.svg#gh-dark-mode-only)

<p align="center">
  <a href="https://app.travis-ci.com/jpkleemans/attribute-events" target="_blank"><img src="https://img.shields.io/travis/com/jpkleemans/attribute-events?label=tests&style=flat-square" alt="빌드 상태"></a>
  <a href="https://github.com/jpkleemans/attribute-events/commits" target="_blank"><img src="https://img.shields.io/github/last-commit/jpkleemans/attribute-events?label=업데이트됨&style=flat-square" alt="최종 업데이트"></a>
  <a href="https://packagist.org/packages/jpkleemans/attribute-events"><img src="https://img.shields.io/packagist/v/jpkleemans/attribute-events?label=안정&style=flat-square" alt="최신 안정 버전"></a>
  <a href="https://packagist.org/packages/jpkleemans/attribute-events"><img src="https://img.shields.io/packagist/l/jpkleemans/attribute-events?style=flat-square" alt="라이선스"></a>
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
Eloquent 모델은 `created` 및 `deleted`와 같은 여러 유용한 이벤트를 라이프사이클 동안 발생시킵니다. 그러나 모델의 생애 동안 일반적으로 더 많은 비즈니스 의미 있는 이벤트가 발생합니다. 이 라이브러리를 사용하면 속성 변경을 자체 이벤트 클래스에 매핑하여 이를 캡처할 수 있습니다.

## 설치

```bash
composer require jpkleemans/attribute-events
```

## 사용 방법
모델에서 `Kleemans\AttributeEvents` 트레이트를 사용하고 속성을 `$dispatchesEvents` 속성에 추가하세요:

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
속성 이벤트는 업데이트된 모델이 저장된 후에 디스패치됩니다. 각 이벤트는 생성자를 통해 모델의 인스턴스를 받습니다.

> 모델 이벤트 및 `$dispatchesEvents` 속성에 대한 자세한 내용은 <a href="https://laravel.com/docs/eloquent#events" target="_blank">Laravel 문서</a>를 참조하세요.

## 리스닝
이제 `EventServiceProvider`의 `$listen` 배열을 통해 이벤트를 구독하거나, 클로저 기반 리스너로 수동 구독할 수 있습니다:


```php
Event::listen(function (OrderCanceled $event) {
    // Restock inventory
});
```

또는 Laravel의 <a href="https://laravel.com/docs/broadcasting" target="_blank">브로드캐스팅</a> 기능을 사용하여 사용자에게 실시간 업데이트를 푸시할 수 있습니다:

```js
Echo.channel('orders')
    .listen('OrderShipped', (event) => {
        // Display a notification
    })
```

## JSON 속성
JSON으로 저장된 속성의 경우 `->` 연산자를 사용할 수 있습니다:

```php
protected $dispatchesEvents = [
    'payment->status:completed' => PaymentCompleted::class,
];
```

## 접근자
더 복잡한 상태 변경을 위해 <a href="https://laravel.com/docs/eloquent-mutators#defining-an-accessor" target="_blank">접근자</a>로 정의된 속성을 사용할 수 있습니다:

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
> Laravel 9에서 도입된 [새로운 접근자 정의 방식](https://laravel.com/docs/9.x/releases#eloquent-accessors-and-mutators)도 사용할 수 있습니다.

## 자세히 알아보기
- Jan-Paul Kleemans의 [“Attribute Events를 사용하여 Laravel 코드를 분리하기”](https://jpkleemans.medium.com/decouple-your-laravel-code-using-attribute-events-de8f2528f46a)
- [모델 이벤트에 대한 Laravel 문서](https://laravel.com/docs/eloquent#events)

## 후원사

<a href="https://www.nexxtmove.nl/" target="_blank">
  <img src="https://raw.githubusercontent.com/jpkleemans/attribute-events/gh-pages/nexxtmove-logo.svg" alt="Nexxtmove 로고" width="200">
</a>

이 프로젝트 개발을 후원해 주신 <a href="https://www.nexxtmove.nl/" target="_blank">Nexxtmove</a>에 감사드립니다.  
여기에 로고나 이름을 넣고 싶으신가요? [이 프로젝트 후원하기](https://github.com/sponsors/jpkleemans).

## 라이선스

코드는 [MIT 라이선스](https://github.com/jpkleemans/attribute-events/blob/master/LICENSE) 하에 배포됩니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-11

---