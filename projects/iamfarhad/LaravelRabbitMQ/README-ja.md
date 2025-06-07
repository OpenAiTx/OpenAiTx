# Laravel RabbitMQ キュードライバー

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

高性能かつ高信頼性の高度なメッセージキューイング機能を提供する、Laravel用の堅牢なRabbitMQキュードライバー実装です。

## 特長

- ネイティブなLaravel Queue API統合
- 遅延/スケジュールジョブのサポート
- プライオリティキュー
- エラーハンドリングと自動リトライ
- SSL/TLSによるセキュア接続
- 複数コンシューマによる並列処理
- キューの自動作成とバインディング
- 包括的なキュー設定オプション
- RabbitMQメッセージ属性のサポート
- デッドレターエクスチェンジ
- 品質保証（QoS）設定
- クォーラムキューのサポート

## サポートポリシー

新機能は最新バージョンのみが対象です。バグ修正は以下のスキームで提供されます:

| パッケージバージョン | Laravelバージョン | PHPバージョン | バグ修正期限        |                                                                                          |
|----------------------|-------------------|---------------|---------------------|------------------------------------------------------------------------------------------|
| 0.1                  | 10, 11, 12        | ^8.2          | 2025年8月26日       | [ドキュメント](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md)      |

## 必要要件

- PHP 8.2以上
- Laravel 10.x, 11.x, または 12.x
- RabbitMQ サーバー 3.8以上
- ext-pcntl（並列処理用）

## インストール

Composerでパッケージをインストールします:

```bash
composer require iamfarhad/laravel-rabbitmq
```

パッケージはLaravelのパッケージディスカバリー機能を通じて自動で登録されます。

Lumenの場合、`bootstrap/app.php` でサービスプロバイダーを手動登録してください:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## 設定

`config/queue.php` ファイルにRabbitMQ接続を追加します:

```php
'connections' => [
    // ... 他の接続
    
    'rabbitmq' => [
        'driver' => 'rabbitmq',
        'queue'  => env('RABBITMQ_QUEUE', 'default'),

        'hosts' => [
            'host'      => env('RABBITMQ_HOST', '127.0.0.1'),
            'port'      => env('RABBITMQ_PORT', 5672),
            'user'      => env('RABBITMQ_USER', 'guest'),
            'password'  => env('RABBITMQ_PASSWORD', 'guest'),
            'vhost'     => env('RABBITMQ_VHOST', '/'),
            'lazy'      => env('RABBITMQ_LAZY_CONNECTION', true),
            'keepalive' => env('RABBITMQ_KEEPALIVE_CONNECTION', false),
            'heartbeat' => env('RABBITMQ_HEARTBEAT_CONNECTION', 0),
            'secure'    => env('RABBITMQ_SECURE', false),
        ],

        'options' => [
            'ssl_options' => [
                'cafile'      => env('RABBITMQ_SSL_CAFILE', null),
                'local_cert'  => env('RABBITMQ_SSL_LOCALCERT', null),
                'local_key'   => env('RABBITMQ_SSL_LOCALKEY', null),
                'verify_peer' => env('RABBITMQ_SSL_VERIFY_PEER', true),
                'passphrase'  => env('RABBITMQ_SSL_PASSPHRASE', null),
            ],
            'queue' => [
                'job' => \iamfarhad\LaravelRabbitMQ\Jobs\RabbitMQJob::class,
                'qos' => [
                    'prefetch_size'  => 0,
                    'prefetch_count' => 10,
                    'global'         => false
                ]
            ],
        ],
    ],
]
```

これらの環境変数を `.env` ファイルに追加します:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## 基本的な使い方

設定後は、通常通りLaravelのQueue APIを利用できます。すでにLaravelキューに慣れている場合、コードの変更は不要です。

### ジョブのディスパッチ

```php
// デフォルトキューにジョブをディスパッチ
dispatch(new ProcessPodcast($podcast));

// 特定のキューにジョブをディスパッチ
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// 遅延付きでジョブをディスパッチ
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### ジョブの作成

```php
namespace App\Jobs;

use Illuminate\Bus\Queueable;
use Illuminate\Contracts\Queue\ShouldQueue;
use Illuminate\Foundation\Bus\Dispatchable;
use Illuminate\Queue\InteractsWithQueue;
use Illuminate\Queue\SerializesModels;

class ProcessPodcast implements ShouldQueue
{
    use Dispatchable, InteractsWithQueue, Queueable, SerializesModels;

    public function __construct(private $podcast)
    {
        // カスタムキューを指定
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // ポッドキャストの処理...
    }
}
```

## メッセージのコンシューム

RabbitMQからメッセージをコンシュームする方法は2つあります:

### 1. 標準Laravelキューワーカー

Laravelの組み込みキューワーカー（`basic_get`を使用）:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. 専用RabbitMQコンシューマ

このパッケージは `basic_consume` を使用した専用のRabbitMQコンシューマを提供し、より高いパフォーマンスを実現します:

```bash
php artisan rabbitmq:consume --queue=default
```

#### コンシューマオプション

```bash
php artisan rabbitmq:consume [options]
```

オプション:

- `--connection=`: 接続名（デフォルト接続）
- `--queue=`: コンシュームするキュー名
- `--name=default`: コンシューマ名
- `--once`: 1ジョブのみ処理して終了
- `--stop-when-empty`: キューが空なら停止
- `--delay=0`: 失敗したジョブの遅延秒数
- `--max-jobs=0`: 処理する最大ジョブ数
- `--max-time=0`: ワーカーの最大稼働時間（秒）
- `--memory=128`: メモリ上限（MB）
- `--timeout=60`: ジョブのタイムアウト秒数
- `--tries=1`: 最大試行回数
- `--max-priority=null`: 消費する最大優先度
- `--num-processes=2`: 並列プロセス数

## 高度な機能

### プライオリティキュー

プライオリティキューを使用するには:

1. キュー設定で最大優先度（1-255。高いほど優先度高）を設定
2. ジョブディスパッチ時に優先度を指定

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### 並列処理

複数のコンシューマプロセスを並列実行:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### 品質保証（QoS）

キュー設定でプリフェッチ設定を行います:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // サイズ制限なし
        'prefetch_count' => 10,   // 一度に10メッセージ処理
        'global'         => false // チャンネルでなくコンシューマごとに適用
    ]
]
```

### SSL/TLS接続

セキュアな接続を有効にするには:

1. 設定で `secure` を `true` にする
2. 適切な証明書等でSSLオプションを設定

```php
'secure' => true,
'ssl_options' => [
    'cafile'      => '/path/to/ca.pem',
    'local_cert'  => '/path/to/cert.pem',
    'local_key'   => '/path/to/key.pem',
    'verify_peer' => true,
    'passphrase'  => 'certificate-passphrase',
],
```

## エラーハンドリングとリトライ

失敗したジョブは `--tries` オプションに基づいて自動リトライされます。最大リトライ回数を超えたジョブは失敗ジョブテーブルに移動します。

リトライ動作をカスタマイズできます:

```php
// ジョブクラス内で
public function failed(Throwable $exception)
{
    // 失敗ジョブの処理
}

// カスタムリトライ遅延
public function retryAfter()
{
    return 30; // 秒
}
```

## コントリビューション

貢献は大歓迎です！プルリクエストをぜひお送りください。

1. リポジトリをフォーク
2. フィーチャーブランチを作成（`git checkout -b feature/amazing-feature`）
3. 変更をコミット（`git commit -m 'Add some amazing feature'`）
4. ブランチをプッシュ（`git push origin feature/amazing-feature`）
5. プルリクエストを作成

## ライセンス

このパッケージは[MITライセンス](LICENSE)のもとでオープンソースソフトウェアとして提供されています。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---