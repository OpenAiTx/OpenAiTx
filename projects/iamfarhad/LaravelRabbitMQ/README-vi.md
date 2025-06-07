# Laravel RabbitMQ Queue Driver

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

Một trình điều khiển hàng đợi RabbitMQ mạnh mẽ cho Laravel, cung cấp khả năng xếp hàng tin nhắn nâng cao với hiệu suất cao và độ tin cậy.

## Tính năng

- Tích hợp API Queue gốc của Laravel
- Hỗ trợ jobs trì hoãn/lên lịch
- Hàng đợi ưu tiên
- Xử lý lỗi và tự động thử lại
- Kết nối an toàn SSL/TLS
- Xử lý song song với nhiều consumer
- Tự động tạo và liên kết hàng đợi
- Tùy chỉnh cấu hình hàng đợi toàn diện
- Hỗ trợ thuộc tính tin nhắn RabbitMQ
- Dead letter exchanges
- Thiết lập Chất lượng Dịch vụ (QoS)
- Hỗ trợ quorum queue

## Chính sách Hỗ trợ

Chỉ phiên bản mới nhất sẽ nhận được các tính năng mới. Sửa lỗi sẽ được cung cấp theo sơ đồ sau:

| Phiên bản Package | Phiên bản Laravel | Phiên bản PHP | Sửa lỗi đến         |                                                                                      |
|-------------------|-------------------|---------------|---------------------|--------------------------------------------------------------------------------------|
| 0.1               | 10, 11, 12        | ^8.2          | 26 tháng 8, 2025    | [Tài liệu](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md)        |

## Yêu cầu

- PHP 8.2+
- Laravel 10.x, 11.x hoặc 12.x
- RabbitMQ Server 3.8+
- ext-pcntl (cho xử lý song song)

## Cài đặt

Cài đặt package thông qua Composer:

```bash
composer require iamfarhad/laravel-rabbitmq
```

Package sẽ tự động đăng ký thông qua tính năng phát hiện package của Laravel.

Đối với Lumen, đăng ký thủ công service provider trong `bootstrap/app.php`:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## Cấu hình

Thêm kết nối RabbitMQ vào file `config/queue.php` của bạn:

```php
'connections' => [
    // ... các kết nối khác
    
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

Thêm các biến môi trường sau vào file `.env` của bạn:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## Sử dụng cơ bản

Sau khi cấu hình, bạn có thể sử dụng API Queue của Laravel như bình thường. Nếu bạn đã quen với hàng đợi Laravel, bạn không cần thay đổi gì trong mã nguồn của mình.

### Dispatch Jobs

```php
// Dispatch một job vào queue mặc định
dispatch(new ProcessPodcast($podcast));

// Dispatch một job vào queue cụ thể
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// Dispatch một job với delay
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### Tạo Job

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
        // Chỉ định một queue tùy chỉnh
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // Xử lý podcast...
    }
}
```

## Tiêu thụ Tin nhắn

Có hai cách để tiêu thụ tin nhắn từ RabbitMQ:

### 1. Worker Queue chuẩn của Laravel

Sử dụng queue worker tích hợp của Laravel với `basic_get`:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. Consumer RabbitMQ chuyên dụng

Package này cung cấp một consumer RabbitMQ chuyên biệt sử dụng `basic_consume` và mang lại hiệu suất tốt hơn:

```bash
php artisan rabbitmq:consume --queue=default
```

#### Tùy chọn cho Consumer

```bash
php artisan rabbitmq:consume [options]
```

Tùy chọn:

- `--connection=`: Tên kết nối (mặc định là kết nối mặc định)
- `--queue=`: Tên queue muốn tiêu thụ
- `--name=default`: Tên consumer
- `--once`: Xử lý chỉ một job rồi thoát
- `--stop-when-empty`: Dừng khi queue rỗng
- `--delay=0`: Độ trễ cho các job thất bại (giây)
- `--max-jobs=0`: Số lượng job tối đa xử lý trước khi dừng
- `--max-time=0`: Thời gian tối đa worker chạy (giây)
- `--memory=128`: Giới hạn bộ nhớ (MB)
- `--timeout=60`: Số giây một job có thể chạy trước khi timeout
- `--tries=1`: Số lần thử trước khi job bị coi là thất bại
- `--max-priority=null`: Mức ưu tiên tối đa để tiêu thụ
- `--num-processes=2`: Số process song song chạy

## Tính năng Nâng cao

### Hàng đợi Ưu tiên

Để sử dụng hàng đợi ưu tiên:

1. Thiết lập mức ưu tiên tối đa trong cấu hình queue (1-255, số lớn hơn là ưu tiên cao hơn)
2. Dispatch job với ưu tiên:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### Xử lý Song song

Chạy nhiều process consumer song song:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### Chất lượng Dịch vụ (QoS)

Cấu hình prefetch trong cấu hình queue:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // Không giới hạn kích thước
        'prefetch_count' => 10,   // Xử lý 10 tin nhắn mỗi lần
        'global'         => false // Áp dụng cho mỗi consumer, không phải channel
    ]
]
```

### Kết nối SSL/TLS

Để bật kết nối bảo mật:

1. Đặt `secure` thành `true` trong cấu hình
2. Cấu hình ssl_options với chứng chỉ và cài đặt thích hợp

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

## Xử lý lỗi và Thử lại

Các job thất bại sẽ tự động được thử lại dựa trên tùy chọn `--tries`. Những job vượt quá số lần thử sẽ được chuyển vào bảng failed jobs.

Bạn có thể tùy chỉnh hành vi thử lại:

```php
// Trong class job của bạn
public function failed(Throwable $exception)
{
    // Xử lý job thất bại
}

// Tùy chỉnh thời gian delay thử lại
public function retryAfter()
{
    return 30; // giây
}
```

## Đóng góp

Chào mừng đóng góp! Hãy gửi Pull Request.

1. Fork repository
2. Tạo branch cho tính năng của bạn (`git checkout -b feature/amazing-feature`)
3. Commit thay đổi của bạn (`git commit -m 'Add some amazing feature'`)
4. Push lên branch (`git push origin feature/amazing-feature`)
5. Tạo Pull Request

## Giấy phép

Package này là phần mềm mã nguồn mở, được cấp phép theo [MIT license](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---