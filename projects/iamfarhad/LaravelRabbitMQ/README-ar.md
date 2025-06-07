# سائق قائمة انتظار RabbitMQ لـ Laravel

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

تنفيذ قوي لسائق قائمة انتظار RabbitMQ في Laravel، يوفر إمكانيات متقدمة في إدارة الرسائل مع أداء عالٍ وموثوقية عالية.

## الميزات

- تكامل أصلي مع واجهة برمجة تطبيقات قائمة انتظار Laravel
- دعم للمهام المؤجلة/المجدولة
- قوائم انتظار ذات أولوية
- معالجة الأخطاء وإعادة المحاولة تلقائيًا
- اتصالات آمنة عبر SSL/TLS
- المعالجة المتوازية عبر عدة مستهلكين
- إنشاء القوائم وربطها تلقائيًا
- خيارات إعداد شاملة لقوائم الانتظار
- دعم خصائص رسائل RabbitMQ
- تبديلات الرسائل الميتة (Dead Letter Exchanges)
- إعدادات جودة الخدمة (QoS)
- دعم قوائم الانتظار من نوع Quorum

## سياسة الدعم

فقط أحدث إصدار يحصل على ميزات جديدة. سيتم توفير إصلاحات الأخطاء وفقًا للمخطط التالي:

| إصدار الحزمة | إصدار Laravel | إصدار PHP | إصلاحات الأخطاء حتى |                                                                                     |
|--------------|---------------|-----------|---------------------|-------------------------------------------------------------------------------------|
| 0.1          | 10, 11, 12    | ^8.2      | 26 أغسطس 2025       | [التوثيق](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md)       |

## المتطلبات

- PHP 8.2+
- Laravel 10.x أو 11.x أو 12.x
- خادم RabbitMQ 3.8+
- امتداد ext-pcntl (للمعالجة المتوازية)

## التثبيت

قم بتثبيت الحزمة عبر Composer:

```bash
composer require iamfarhad/laravel-rabbitmq
```

سيتم تسجيل الحزمة تلقائيًا من خلال اكتشاف الحزم في Laravel.

بالنسبة لـ Lumen، قم بتسجيل مزود الخدمة يدويًا في `bootstrap/app.php`:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## الإعداد

أضف اتصال RabbitMQ إلى ملف `config/queue.php` الخاص بك:

```php
'connections' => [
    // ... اتصالات أخرى

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

أضف متغيرات البيئة التالية إلى ملف `.env` الخاص بك:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## الاستخدام الأساسي

بعد الإعداد، يمكنك استخدام واجهة قائمة انتظار Laravel كالمعتاد. إذا كنت على دراية مسبقة بقوائم انتظار Laravel، فلست بحاجة لتغيير أي شيء في كودك.

### إرسال المهام

```php
// إرسال مهمة إلى قائمة الانتظار الافتراضية
dispatch(new ProcessPodcast($podcast));

// إرسال مهمة إلى قائمة انتظار محددة
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// إرسال مهمة مع تأخير
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### إنشاء المهام

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
        // تحديد قائمة انتظار مخصصة
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // معالجة البودكاست...
    }
}
```

## استهلاك الرسائل

هناك طريقتان لاستهلاك الرسائل من RabbitMQ:

### 1. عامل قائمة انتظار Laravel القياسي

عامل قائمة الانتظار المدمج في Laravel والذي يستخدم `basic_get`:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. مستهلك RabbitMQ مخصص

توفر هذه الحزمة مستهلك RabbitMQ متخصص يستخدم `basic_consume` ويوفر أداءً أفضل:

```bash
php artisan rabbitmq:consume --queue=default
```

#### خيارات المستهلك

```bash
php artisan rabbitmq:consume [options]
```

الخيارات:

- `--connection=`: اسم الاتصال (الافتراضي هو الاتصال الافتراضي)
- `--queue=`: اسم قائمة الانتظار التي سيتم الاستهلاك منها
- `--name=default`: اسم المستهلك
- `--once`: معالجة مهمة واحدة فقط والخروج
- `--stop-when-empty`: التوقف عند فراغ قائمة الانتظار
- `--delay=0`: التأخير للمهام الفاشلة (بالثواني)
- `--max-jobs=0`: الحد الأقصى لعدد المهام التي تتم معالجتها قبل التوقف
- `--max-time=0`: الحد الأقصى للوقت بالثواني لتشغيل العامل
- `--memory=128`: حد الذاكرة بالميغابايت
- `--timeout=60`: عدد الثواني التي يمكن للمهمة العمل خلالها قبل انتهاء المهلة
- `--tries=1`: عدد المحاولات قبل اعتبار المهمة فاشلة
- `--max-priority=null`: الحد الأقصى لمستوى الأولوية للاستهلاك
- `--num-processes=2`: عدد العمليات المتوازية التي سيتم تشغيلها

## الميزات المتقدمة

### قوائم الانتظار ذات الأولوية

لاستخدام قوائم الانتظار ذات الأولوية:

1. قم بتعيين الحد الأقصى للأولوية في إعدادات قائمة الانتظار (من 1 إلى 255، حيث يعني الأعلى أولوية أكبر)
2. إرسال المهام مع خاصية الأولوية:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### المعالجة المتوازية

تشغيل عدة عمليات مستهلكة بالتوازي:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### جودة الخدمة (QoS)

تهيئة إعدادات prefetch في إعدادات قائمة الانتظار:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // لا يوجد حد معين للحجم
        'prefetch_count' => 10,   // معالجة 10 رسائل في كل مرة
        'global'         => false // يطبق لكل مستهلك وليس على القناة
    ]
]
```

### اتصالات SSL/TLS

لتمكين الاتصالات الآمنة:

1. قم بتعيين `secure` إلى `true` في الإعدادات
2. إعداد خيارات SSL مع الشهادات والإعدادات المناسبة

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

## معالجة الأخطاء وإعادة المحاولة

يتم إعادة محاولة المهام الفاشلة تلقائيًا بناءً على خيار `--tries`. المهام التي تتجاوز الحد الأقصى للمحاولات يتم نقلها إلى جدول المهام الفاشلة.

يمكنك تخصيص سلوك إعادة المحاولة:

```php
// في فئة المهمة الخاصة بك
public function failed(Throwable $exception)
{
    // معالجة المهمة الفاشلة
}

// تأخير مخصص لإعادة المحاولة
public function retryAfter()
{
    return 30; // بالثواني
}
```

## المساهمة

المساهمات مرحب بها! لا تتردد في إرسال طلب سحب (Pull Request).

1. اعمل fork للمستودع
2. أنشئ فرع الميزة الخاصة بك (`git checkout -b feature/amazing-feature`)
3. قم برفع تعديلاتك (`git commit -m 'Add some amazing feature'`)
4. ادفع الفرع (`git push origin feature/amazing-feature`)
5. افتح طلب سحب (Pull Request)

## الرخصة

هذه الحزمة مفتوحة المصدر ومرخصة بموجب [رخصة MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---