![Laravel Attribute Events](/../gh-pages/attribute-events.svg#gh-light-mode-only)
![Laravel Attribute Events](/../gh-pages/attribute-events-dark.svg#gh-dark-mode-only)

<p align="center">
  <a href="https://app.travis-ci.com/jpkleemans/attribute-events" target="_blank"><img src="https://img.shields.io/travis/com/jpkleemans/attribute-events?label=tests&style=flat-square" alt="ビルドステータス"></a>
  <a href="https://github.com/jpkleemans/attribute-events/commits" target="_blank"><img src="https://img.shields.io/github/last-commit/jpkleemans/attribute-events?label=更新日&style=flat-square" alt="最終更新"></a>
  <a href="https://packagist.org/packages/jpkleemans/attribute-events"><img src="https://img.shields.io/packagist/v/jpkleemans/attribute-events?label=安定版&style=flat-square" alt="最新安定版"></a>
  <a href="https://packagist.org/packages/jpkleemans/attribute-events"><img src="https://img.shields.io/packagist/l/jpkleemans/attribute-events?style=flat-square" alt="ライセンス"></a>
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

Eloquentモデルは、そのライフサイクルを通じて`created`や`deleted`などの便利なイベントをいくつか発火します。しかし、モデルのライフサイクル中には通常、さらに多くのビジネス上重要なイベントが発生します。このライブラリを使うことで、属性の変更を独自のイベントクラスにマッピングしてそれらをキャプチャできます。

## インストール
```bash
composer require jpkleemans/attribute-events
```

## 使い方
モデルで `Kleemans\AttributeEvents` トレイトを使用し、属性を `$dispatchesEvents` プロパティに追加します:

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

属性eventsは、更新されたモデルが保存された後にディスパッチされます。各イベントはコンストラクタを通じてモデルのインスタンスを受け取ります。

> モデルイベントおよび`$dispatchesEvents`プロパティの詳細については、<a href="https://laravel.com/docs/eloquent#events" target="_blank">Laravelドキュメント</a>をご覧ください。

## リスニング
これで、`EventServiceProvider`の`$listen`配列を介して、またはクロージャベースのリスナーで手動でイベントに登録できます：

```php
Event::listen(function (OrderCanceled $event) {
    // Restock inventory
});
```

または、Laravelの<a href="https://laravel.com/docs/broadcasting" target="_blank">ブロードキャスティング</a>機能を使用して、リアルタイムの更新をユーザーにプッシュします：

```js
Echo.channel('orders')
    .listen('OrderShipped', (event) => {
        // Display a notification
    })
```

## JSON属性
JSONとして格納されている属性には、`->`演算子を使用できます:

```php
protected $dispatchesEvents = [
    'payment->status:completed' => PaymentCompleted::class,
];
```

## アクセサ
より複雑な状態変化の場合は、<a href="https://laravel.com/docs/eloquent-mutators#defining-an-accessor" target="_blank">アクセサ</a>で定義された属性を使用できます:

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
> Laravel 9で導入された[アクセサの新しい定義方法](https://laravel.com/docs/9.x/releases#eloquent-accessors-and-mutators)も使用できます。

## 詳しく学ぶ
- Jan-Paul Kleemansによる[「Attribute Eventsを使ってLaravelコードを分離する」](https://jpkleemans.medium.com/decouple-your-laravel-code-using-attribute-events-de8f2528f46a)
- [Laravelドキュメントのモデルイベント](https://laravel.com/docs/eloquent#events)

## スポンサー

<a href="https://www.nexxtmove.nl/" target="_blank">
  <img src="https://raw.githubusercontent.com/jpkleemans/attribute-events/gh-pages/nexxtmove-logo.svg" alt="Nexxtmove ロゴ" width="200">
</a>

このプロジェクトの開発を支援してくれた<a href="https://www.nexxtmove.nl/" target="_blank">Nexxtmove</a>に感謝します。  
あなたのロゴや名前をここに？[このプロジェクトをスポンサーする](https://github.com/sponsors/jpkleemans)。

## ライセンス

コードは[MITライセンス](https://github.com/jpkleemans/attribute-events/blob/master/LICENSE)の下で公開されています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-11

---