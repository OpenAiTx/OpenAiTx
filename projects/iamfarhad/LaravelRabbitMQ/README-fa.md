# درایور صف RabbitMQ برای لاراول

[![آخرین نسخه پایدار](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![تعداد دانلودها](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![مجوز](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![تست‌ها](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![سبک کدنویسی](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

یک پیاده‌سازی قدرتمند از درایور صف RabbitMQ برای لاراول که قابلیت‌های صف‌بندی پیام پیشرفته با عملکرد و قابلیت اطمینان بالا را ارائه می‌دهد.

## ویژگی‌ها

- یکپارچگی با API صف لاراول به صورت بومی
- پشتیبانی از کارهای تأخیری/زمان‌بندی‌شده
- صف‌های دارای اولویت
- مدیریت خطا و تلاش مجدد خودکار
- اتصالات امن SSL/TLS
- پردازش موازی با چند مصرف‌کننده
- ایجاد و اتصال خودکار صف
- گزینه‌های پیکربندی جامع صف
- پشتیبانی از ویژگی‌های پیام RabbitMQ
- مبادلات Dead Letter
- تنظیمات کیفیت سرویس (QoS)
- پشتیبانی از صف Quorum

## سیاست پشتیبانی

تنها آخرین نسخه ویژگی‌های جدید دریافت خواهد کرد. رفع اشکال‌ها طبق جدول زیر ارائه می‌شود:

| نسخه پکیج | نسخه لاراول | نسخه PHP | پشتیبانی رفع باگ تا   |                                                                                     |
|-----------|-------------|----------|-----------------------|-------------------------------------------------------------------------------------|
| 0.1       | 10, 11, 12  | ^8.2     | ۲۶ اوت ۲۰۲۵            | [مستندات](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md)       |

## پیش‌نیازها

- PHP 8.2+
- لاراول 10.x، 11.x یا 12.x
- سرور RabbitMQ نسخه 3.8 به بالا
- افزونه ext-pcntl (برای پردازش موازی)

## نصب

پکیج را با Composer نصب کنید:

```bash
composer require iamfarhad/laravel-rabbitmq
```

پکیج به صورت خودکار از طریق package discovery لاراول ثبت می‌شود.

برای Lumen، سرویس‌پروایدر را به صورت دستی در فایل `bootstrap/app.php` ثبت کنید:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## پیکربندی

اتصال RabbitMQ را به فایل `config/queue.php` اضافه کنید:

```php
'connections' => [
    // ... سایر اتصالات
    
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

این متغیرهای محیطی را به فایل `.env` خود اضافه کنید:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## استفاده پایه

پس از پیکربندی، می‌توانید مانند همیشه از API صف لاراول استفاده کنید. اگر با صف‌های لاراول آشنا هستید، نیازی به تغییر در کد خود ندارید.

### ارسال کارها (Dispatching Jobs)

```php
// ارسال یک کار به صف پیش‌فرض
dispatch(new ProcessPodcast($podcast));

// ارسال یک کار به یک صف خاص
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// ارسال یک کار با تأخیر
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### ساختن کارها (Creating Jobs)

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
        // تعیین صف سفارشی
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // پردازش پادکست...
    }
}
```

## مصرف پیام‌ها

دو روش برای مصرف پیام‌ها از RabbitMQ وجود دارد:

### 1. کارگر استاندارد صف لاراول

کارگر داخلی لاراول که از `basic_get` استفاده می‌کند:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. مصرف‌کننده اختصاصی RabbitMQ

این پکیج یک مصرف‌کننده ویژه RabbitMQ ارائه می‌دهد که از `basic_consume` استفاده می‌کند و عملکرد بهتری دارد:

```bash
php artisan rabbitmq:consume --queue=default
```

#### گزینه‌های مصرف‌کننده

```bash
php artisan rabbitmq:consume [options]
```

گزینه‌ها:

- `--connection=`: نام اتصال (پیش‌فرض اتصال پیش‌فرض)
- `--queue=`: نام صف جهت مصرف
- `--name=default`: نام مصرف‌کننده
- `--once`: پردازش فقط یک کار و خروج
- `--stop-when-empty`: توقف هنگام خالی شدن صف
- `--delay=0`: تأخیر برای کارهای ناموفق (ثانیه)
- `--max-jobs=0`: حداکثر تعداد کارهایی که قبل از توقف پردازش می‌شوند
- `--max-time=0`: حداکثر زمان به ثانیه برای اجرای کارگر
- `--memory=128`: محدودیت حافظه بر حسب مگابایت
- `--timeout=60`: مدت زمان مجاز اجرای یک کار قبل از تایم اوت
- `--tries=1`: تعداد تلاش‌ها قبل از ناموفق شدن کار
- `--max-priority=null`: حداکثر سطح اولویت برای مصرف
- `--num-processes=2`: تعداد فرآیندهای موازی برای اجرا

## ویژگی‌های پیشرفته

### صف‌های دارای اولویت

برای استفاده از صف‌های اولویت‌دار:

1. حداکثر اولویت را در پیکربندی صف خود تعیین کنید (۱ تا ۲۵۵، عدد بالاتر به معنای اولویت بالاتر است)
2. کارها را با اولویت ارسال کنید:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### پردازش موازی

اجرا همزمان چند مصرف‌کننده:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### کیفیت سرویس (QoS)

تنظیمات prefetch را در پیکربندی صف خود اعمال کنید:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // بدون محدودیت سایز مشخص
        'prefetch_count' => 10,   // پردازش ۱۰ پیام به طور همزمان
        'global'         => false // اعمال تنظیمات به ازای هر مصرف‌کننده، نه کانال
    ]
]
```

### اتصالات SSL/TLS

برای فعال‌سازی اتصالات امن:

1. مقدار `secure` را در پیکربندی true قرار دهید
2. گزینه‌های SSL را با گواهی‌ها و تنظیمات مناسب پیکربندی کنید

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

## مدیریت خطا و تلاش مجدد

کارهای ناموفق به طور خودکار بر اساس گزینه `--tries` مجدداً تلاش می‌شوند. کارهایی که حداکثر تلاش را پشت سر بگذارند به جدول کارهای ناموفق منتقل می‌شوند.

می‌توانید رفتار تلاش مجدد را سفارشی کنید:

```php
// در کلاس کار خود
public function failed(Throwable $exception)
{
    // مدیریت کار ناموفق
}

// تأخیر سفارشی تلاش مجدد
public function retryAfter()
{
    return 30; // ثانیه
}
```

## مشارکت

مشارکت شما خوش‌آمد است! لطفاً برای ارسال Pull Request اقدام فرمایید.

1. ریپازیتوری را fork کنید
2. شاخه ویژگی خود را ایجاد کنید (`git checkout -b feature/amazing-feature`)
3. تغییرات خود را commit کنید (`git commit -m 'Add some amazing feature'`)
4. شاخه را push کنید (`git push origin feature/amazing-feature`)
5. یک Pull Request باز کنید

## مجوز

این پکیج تحت مجوز [MIT license](LICENSE) متن‌باز ارائه شده است.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---