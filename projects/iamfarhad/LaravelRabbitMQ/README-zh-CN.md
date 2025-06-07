# Laravel RabbitMQ 队列驱动

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

为 Laravel 实现了强大的 RabbitMQ 队列驱动，提供高性能和高可靠性的高级消息队列功能。

## 功能特性

- 原生集成 Laravel 队列 API
- 支持延迟/定时任务
- 优先级队列
- 错误处理和自动重试
- SSL/TLS 安全连接
- 多消费者并行处理
- 自动队列创建与绑定
- 全面的队列配置选项
- 支持 RabbitMQ 消息属性
- 死信交换机
- 服务质量（QoS）设置
- Quorum 队列支持

## 支持策略

仅最新版本会获得新功能。Bug 修复将遵循以下方案：

| 包版本     | Laravel 版本 | PHP 版本 | Bug 修复截止时间     |                                                                                     |
|------------|--------------|----------|----------------------|-------------------------------------------------------------------------------------|
| 0.1        | 10, 11, 12   | ^8.2     | 2025 年 8 月 26 日   | [文档](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md)          |

## 系统要求

- PHP 8.2 及以上
- Laravel 10.x、11.x 或 12.x
- RabbitMQ 服务端 3.8 及以上
- ext-pcntl（用于并行处理）

## 安装

通过 Composer 安装该包：

```bash
composer require iamfarhad/laravel-rabbitmq
```

该包会通过 Laravel 的包发现机制自动注册。

对于 Lumen，请在 `bootstrap/app.php` 中手动注册服务提供者：

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## 配置

在你的 `config/queue.php` 文件中添加 RabbitMQ 连接：

```php
'connections' => [
    // ... 其他连接
    
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

在你的 `.env` 文件中添加如下环境变量：

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## 基本用法

配置完成后，你可以像平常一样使用 Laravel 的队列 API。如果你已经熟悉 Laravel 队列，无需更改现有代码。

### 分发任务

```php
// 分发任务到默认队列
dispatch(new ProcessPodcast($podcast));

// 分发任务到指定队列
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// 分发一个延迟任务
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### 创建任务

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
        // 指定自定义队列
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // 处理 podcast...
    }
}
```

## 消费消息

有两种方式从 RabbitMQ 消费消息：

### 1. 标准 Laravel 队列 Worker

Laravel 内置队列 worker，使用 `basic_get`：

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. 专用 RabbitMQ 消费器

本包提供专用的 RabbitMQ 消费器，使用 `basic_consume`，性能更佳：

```bash
php artisan rabbitmq:consume --queue=default
```

#### 消费器选项

```bash
php artisan rabbitmq:consume [options]
```

选项：

- `--connection=`：连接名称（默认为默认连接）
- `--queue=`：要消费的队列名称
- `--name=default`：消费者名称
- `--once`：仅处理一个任务后退出
- `--stop-when-empty`：队列为空时停止
- `--delay=0`：任务失败后的延迟（秒）
- `--max-jobs=0`：处理的最大任务数，达到后停止
- `--max-time=0`：worker 运行的最大时间（秒）
- `--memory=128`：内存限制（MB）
- `--timeout=60`：单个任务运行超时时间（秒）
- `--tries=1`：任务失败前的最大尝试次数
- `--max-priority=null`：消费的最大优先级级别
- `--num-processes=2`：并行运行的进程数

## 高级特性

### 优先级队列

使用优先级队列：

1. 在队列配置中设置最大优先级（1-255，数字越大优先级越高）
2. 分发任务时指定优先级：

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### 并行处理

并行运行多个消费进程：

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### 服务质量（QoS）

在队列配置中设置 prefetch：

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // 无特定大小限制
        'prefetch_count' => 10,   // 每次处理 10 条消息
        'global'         => false // 按消费者而不是通道设置
    ]
]
```

### SSL/TLS 连接

启用安全连接：

1. 在配置中将 `secure` 设置为 `true`
2. 配置 SSL 相关证书及选项

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

## 错误处理与重试

失败的任务会根据 `--tries` 选项自动重试。超过最大重试次数的任务会被移到失败任务表。

你可以自定义重试行为：

```php
// 在你的任务类中
public function failed(Throwable $exception)
{
    // 处理失败的任务
}

// 自定义重试延迟
public function retryAfter()
{
    return 30; // 秒
}
```

## 贡献

欢迎贡献！请随时提交 Pull Request。

1. Fork 本仓库
2. 创建你的功能分支 (`git checkout -b feature/amazing-feature`)
3. 提交你的更改 (`git commit -m 'Add some amazing feature'`)
4. 推送到分支 (`git push origin feature/amazing-feature`)
5. 发起 Pull Request

## 许可证

本包基于 [MIT license](LICENSE) 开源。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---