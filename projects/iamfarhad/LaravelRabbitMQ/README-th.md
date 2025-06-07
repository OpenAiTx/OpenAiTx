# Laravel RabbitMQ Queue Driver

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

ไดรเวอร์ RabbitMQ Queue สำหรับ Laravel ที่มีประสิทธิภาพสูง รองรับการจัดคิวข้อความขั้นสูง พร้อมความเสถียรและเชื่อถือได้

## ฟีเจอร์

- การเชื่อมต่อกับ Laravel Queue API โดยตรง
- รองรับงานแบบหน่วงเวลา/ตั้งเวลา
- คิวแบบลำดับความสำคัญ (Priority Queues)
- การจัดการข้อผิดพลาดและการลองใหม่อัตโนมัติ
- การเชื่อมต่อที่ปลอดภัยด้วย SSL/TLS
- ประมวลผลแบบขนานด้วยผู้บริโภคหลายตัว
- สร้างและผูกคิวอัตโนมัติ
- ตัวเลือกการตั้งค่าคิวที่ครอบคลุม
- รองรับ RabbitMQ message attributes
- Dead letter exchanges
- การตั้งค่า Quality of Service (QoS)
- รองรับ Quorum queue

## นโยบายการสนับสนุน

เฉพาะเวอร์ชันล่าสุดเท่านั้นที่จะได้รับฟีเจอร์ใหม่ การแก้ไขบั๊กจะเป็นไปตามตารางดังนี้:

| Package Version | Laravel Version | PHP Version | Bug Fixes Until   |                                                                                     |
|-----------------|-----------------|-------------|-------------------|-------------------------------------------------------------------------------------|
| 0.1             | 10, 11, 12      | ^8.2        | 26 สิงหาคม 2025 | [Documentation](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md) |

## ข้อกำหนด

- PHP 8.2+
- Laravel 10.x, 11.x หรือ 12.x
- RabbitMQ Server 3.8+
- ext-pcntl (สำหรับการประมวลผลแบบขนาน)

## การติดตั้ง

ติดตั้งแพ็คเกจผ่าน Composer:

```bash
composer require iamfarhad/laravel-rabbitmq
```

แพ็คเกจจะลงทะเบียนตัวเองโดยอัตโนมัติผ่าน Laravel's package discovery

สำหรับ Lumen ให้ลงทะเบียน service provider ด้วยตนเองใน `bootstrap/app.php`:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## การตั้งค่า

เพิ่มการเชื่อมต่อ RabbitMQ ในไฟล์ `config/queue.php` ของคุณ:

```php
'connections' => [
    // ... other connections
    
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

เพิ่ม environment variables เหล่านี้ในไฟล์ `.env` ของคุณ:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## การใช้งานพื้นฐาน

เมื่อกำหนดค่าแล้ว คุณสามารถใช้ Laravel's Queue API ได้ตามปกติ หากคุณคุ้นเคยกับ Laravel queues อยู่แล้ว ไม่ต้องเปลี่ยนแปลงโค้ดใด ๆ

### การส่งงาน (Dispatching Jobs)

```php
// ส่งงานไปยังคิวเริ่มต้น
dispatch(new ProcessPodcast($podcast));

// ส่งงานไปยังคิวเฉพาะ
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// ส่งงานโดยหน่วงเวลา
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### การสร้างงาน (Creating Jobs)

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
        // กำหนดคิวที่ต้องการ
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // ประมวลผล podcast...
    }
}
```

## การบริโภคข้อความ (Consuming Messages)

มี 2 วิธีในการบริโภคข้อความจาก RabbitMQ:

### 1. Standard Laravel Queue Worker

ใช้ worker queue พื้นฐานของ Laravel ซึ่งใช้ `basic_get`:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. Dedicated RabbitMQ Consumer

แพ็คเกจนี้มี consumer พิเศษของ RabbitMQ ซึ่งใช้ `basic_consume` และให้ประสิทธิภาพที่ดีกว่า:

```bash
php artisan rabbitmq:consume --queue=default
```

#### ตัวเลือกของ Consumer

```bash
php artisan rabbitmq:consume [options]
```

ตัวเลือก:

- `--connection=`: ชื่อการเชื่อมต่อ (ค่าเริ่มต้นคือ default connection)
- `--queue=`: ชื่อคิวที่ต้องการบริโภค
- `--name=default`: ชื่อ consumer
- `--once`: ประมวลผลงานเพียง 1 งานและออก
- `--stop-when-empty`: หยุดเมื่อคิวว่าง
- `--delay=0`: หน่วงเวลาสำหรับงานที่ล้มเหลว (วินาที)
- `--max-jobs=0`: จำนวนงานสูงสุดที่จะประมวลผลก่อนหยุด
- `--max-time=0`: เวลาสูงสุด (วินาที) ที่ worker จะทำงาน
- `--memory=128`: ขีดจำกัดหน่วยความจำ (MB)
- `--timeout=60`: วินาทีที่งานสามารถทำงานก่อนหมดเวลา
- `--tries=1`: จำนวนความพยายามก่อนให้งานล้มเหลว
- `--max-priority=null`: ระดับความสำคัญสูงสุดที่จะบริโภค
- `--num-processes=2`: จำนวน process ที่ต้องการทำงานแบบขนาน

## ฟีเจอร์ขั้นสูง

### คิวแบบลำดับความสำคัญ (Priority Queues)

วิธีใช้งานคิวแบบลำดับความสำคัญ:

1. กำหนดค่าสูงสุดของความสำคัญใน config คิวของคุณ (1-255, ค่ายิ่งมากยิ่งมีความสำคัญสูง)
2. ส่งงานพร้อมความสำคัญ:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### การประมวลผลแบบขนาน (Parallel Processing)

เรียก process ผู้บริโภคหลายตัวพร้อมกัน:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### คุณภาพของบริการ (Quality of Service - QoS)

ตั้งค่า prefetch ใน config คิวของคุณ:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // ไม่มีขนาดจำกัด
        'prefetch_count' => 10,   // ประมวลผลพร้อมกัน 10 ข้อความ
        'global'         => false // ใช้ต่อ consumer ไม่ใช่ทั้ง channel
    ]
]
```

### การเชื่อมต่อแบบปลอดภัย SSL/TLS

เพื่อเปิดใช้งานการเชื่อมต่อแบบปลอดภัย:

1. ตั้งค่า `secure` เป็น `true` ใน config ของคุณ
2. กำหนดค่า SSL options พร้อม certificate และค่าที่เหมาะสม

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

## การจัดการข้อผิดพลาดและการลองใหม่ (Error Handling and Retries)

งานที่ล้มเหลวจะถูกลองใหม่โดยอัตโนมัติตามตัวเลือก `--tries` งานที่เกินจำนวนครั้งจะถูกย้ายไปยังตาราง failed jobs

คุณสามารถปรับแต่งพฤติกรรมการลองใหม่ได้:

```php
// ใน job class ของคุณ
public function failed(Throwable $exception)
{
    // จัดการงานที่ล้มเหลว
}

// กำหนด retry delay เอง
public function retryAfter()
{
    return 30; // วินาที
}
```

## การมีส่วนร่วม (Contributing)

ยินดีต้อนรับการมีส่วนร่วม! สามารถส่ง Pull Request ได้เลย

1. Fork repository
2. สร้าง feature branch (`git checkout -b feature/amazing-feature`)
3. Commit การเปลี่ยนแปลง (`git commit -m 'Add some amazing feature'`)
4. Push ไปที่ branch (`git push origin feature/amazing-feature`)
5. เปิด Pull Request

## ใบอนุญาต

แพ็คเกจนี้เป็นซอฟต์แวร์โอเพนซอร์สที่ได้รับอนุญาตภายใต้ [MIT license](LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---