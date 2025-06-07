# Laravel RabbitMQ Queue Driver

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

一個穩健的 Laravel RabbitMQ 佇列驅動實作，提供高效能且可靠的進階訊息佇列功能。

## 功能特色

- 原生整合 Laravel Queue API
- 支援延遲/排程任務
- 優先權佇列
- 錯誤處理與自動重試
- SSL/TLS 安全連線
- 多消費者並行處理
- 自動建立與綁定佇列
- 完善的佇列設定選項
- 支援 RabbitMQ 訊息屬性
- 死信交換機 (Dead letter exchanges)
- 服務品質 (QoS) 設定
- 支援 Quorum 佇列

## 支援政策

僅最新版會獲得新功能。錯誤修正依下述方式提供：

| 套件版本    | Laravel 版本   | PHP 版本    | 錯誤修正截止日      |                                                                                     |
|-------------|----------------|-------------|---------------------|-------------------------------------------------------------------------------------|
| 0.1         | 10, 11, 12     | ^8.2        | 2025 年 8 月 26 日  | [文件](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md)           |

## 系統需求

- PHP 8.2+
- Laravel 10.x, 11.x 或 12.x
- RabbitMQ Server 3.8+
- ext-pcntl（用於並行處理）

## 安裝

透過 Composer 安裝套件：

```bash
composer require iamfarhad/laravel-rabbitmq
```

套件會自動透過 Laravel 的套件發現機制註冊。

若使用 Lumen，請於 `bootstrap/app.php` 中手動註冊服務提供者：

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## 設定

在 `config/queue.php` 檔案中加入 RabbitMQ 連線設定：

```php
'connections' => [
    // ... 其他連線
    
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

在 `.env` 檔案中加入下列環境變數：

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## 基本用法

完成設定後，即可如常使用 Laravel Queue API。如果你已熟悉 Laravel 佇列，無須修改任何程式碼。

### 發送任務

```php
// 發送任務至預設佇列
dispatch(new ProcessPodcast($podcast));

// 發送任務至指定佇列
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// 發送延遲任務
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### 建立任務

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
        // 指定自定佇列
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // 處理 podcast...
    }
}
```

## 消費訊息

有兩種方式可以從 RabbitMQ 消費訊息：

### 1. 標準 Laravel 佇列工作者

Laravel 內建佇列工作者，使用 `basic_get`：

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. 專用 RabbitMQ 消費者

本套件提供專用的 RabbitMQ 消費者，使用 `basic_consume`，效能更佳：

```bash
php artisan rabbitmq:consume --queue=default
```

#### 消費者選項

```bash
php artisan rabbitmq:consume [options]
```

選項說明：

- `--connection=`：連線名稱（預設為預設連線）
- `--queue=`：要消費的佇列名稱
- `--name=default`：消費者名稱
- `--once`：僅處理一個任務後退出
- `--stop-when-empty`：當佇列為空時停止
- `--delay=0`：失敗任務的延遲秒數
- `--max-jobs=0`：處理的最大任務數，達到後停止
- `--max-time=0`：工作者執行的最大秒數
- `--memory=128`：記憶體限制（MB）
- `--timeout=60`：單一任務的超時秒數
- `--tries=1`：最多重試次數
- `--max-priority=null`：消費的最大優先權等級
- `--num-processes=2`：並行消費的處理程序數

## 進階功能

### 優先權佇列

使用優先權佇列步驟：

1. 在佇列設定中設最大優先權（1-255，數字越大優先權越高）
2. 發送帶有優先權的任務：

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### 並行處理

同時執行多個消費者處理程序：

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### 服務品質 (QoS)

於佇列設定中配置預取參數：

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // 無特定大小限制
        'prefetch_count' => 10,   // 同時處理 10 個訊息
        'global'         => false // 僅套用於每個消費者
    ]
]
```

### SSL/TLS 安全連線

啟用安全連線步驟：

1. 設定檔中將 `secure` 設為 `true`
2. 配置 SSL 選項與憑證

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

## 錯誤處理與重試

失敗任務會根據 `--tries` 選項自動重試。超過最大重試次數的任務會移至失敗任務資料表。

你可以自訂重試行為：

```php
// 在任務類別中
public function failed(Throwable $exception)
{
    // 處理失敗任務
}

// 自訂重試延遲
public function retryAfter()
{
    return 30; // 秒
}
```

## 貢獻指南

歡迎各界貢獻！請隨時提交 Pull Request。

1. Fork 本儲存庫
2. 建立功能分支 (`git checkout -b feature/amazing-feature`)
3. 提交修改 (`git commit -m 'Add some amazing feature'`)
4. 推送至分支 (`git push origin feature/amazing-feature`)
5. 發送 Pull Request

## 授權

本套件採用 [MIT 授權](LICENSE) 開源。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---