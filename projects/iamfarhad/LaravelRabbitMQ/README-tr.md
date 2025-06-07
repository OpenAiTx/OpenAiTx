# Laravel RabbitMQ Kuyruk Sürücüsü

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

Laravel için gelişmiş mesaj kuyruklama yetenekleri sunan, yüksek performanslı ve güvenilir güçlü bir RabbitMQ kuyruk sürücüsü implementasyonu.

## Özellikler

- Laravel Kuyruk API’si ile yerel entegrasyon
- Gecikmeli/zamanlanmış işler desteği
- Öncelikli kuyruklar
- Hata yönetimi ve otomatik yeniden deneme
- SSL/TLS güvenli bağlantılar
- Çoklu tüketiciler ile paralel işleme
- Otomatik kuyruk oluşturma ve bağlama
- Kapsamlı kuyruk yapılandırma seçenekleri
- RabbitMQ mesaj öznitelikleri desteği
- Dead letter exchange’ler
- Quality of Service (QoS) ayarları
- Quorum kuyruk desteği

## Destek Politikası

Yalnızca en son sürüme yeni özellikler eklenir. Hata düzeltmeleri aşağıdaki şemaya göre sağlanır:

| Paket Sürümü | Laravel Sürümü | PHP Sürümü | Hata Düzeltme Son Tarihi |                                                                                     |
|--------------|---------------|------------|--------------------------|-------------------------------------------------------------------------------------|
| 0.1          | 10, 11, 12    | ^8.2       | 26 Ağustos 2025          | [Dokümantasyon](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md) |

## Gereksinimler

- PHP 8.2+
- Laravel 10.x, 11.x veya 12.x
- RabbitMQ Sunucusu 3.8+
- ext-pcntl (paralel işleme için)

## Kurulum

Paketi Composer ile yükleyin:

```bash
composer require iamfarhad/laravel-rabbitmq
```

Paket, Laravel’in paket keşfi ile otomatik olarak kaydedilecektir.

Lumen için, servis sağlayıcıyı `bootstrap/app.php` dosyasına elle ekleyin:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## Yapılandırma

RabbitMQ bağlantısını `config/queue.php` dosyanıza ekleyin:

```php
'connections' => [
    // ... diğer bağlantılar

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

Aşağıdaki ortam değişkenlerini `.env` dosyanıza ekleyin:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## Temel Kullanım

Yapılandırma tamamlandıktan sonra, Laravel’in Kuyruk API’sini her zamanki gibi kullanabilirsiniz. Zaten Laravel kuyruklarına aşinaysanız, kodunuzda herhangi bir değişiklik yapmanız gerekmez.

### İşleri Kuyruğa Gönderme

```php
// Varsayılan kuyruğa bir iş gönderin
dispatch(new ProcessPodcast($podcast));

// Belirli bir kuyruğa iş gönderin
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// Gecikmeli iş gönderin
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### İş Oluşturma

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
        // Özel bir kuyruk belirtin
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // Podcast’i işle...
    }
}
```

## Mesajları Tüketme

RabbitMQ’dan mesaj tüketmenin iki yolu vardır:

### 1. Standart Laravel Kuyruk İşçisi

Laravel’in yerleşik kuyruk işçisi `basic_get` kullanır:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. Özel RabbitMQ Tüketicisi

Bu paket, daha iyi performans için `basic_consume` kullanan özel bir RabbitMQ tüketicisi sağlar:

```bash
php artisan rabbitmq:consume --queue=default
```

#### Tüketici Seçenekleri

```bash
php artisan rabbitmq:consume [options]
```

Seçenekler:

- `--connection=`: Bağlantı adı (varsayılan bağlantıyı kullanır)
- `--queue=`: Tüketilecek kuyruk adı
- `--name=default`: Tüketici adı
- `--once`: Sadece bir işi işleyip çık
- `--stop-when-empty`: Kuyruk boşsa dur
- `--delay=0`: Hatalı işler için gecikme (saniye)
- `--max-jobs=0`: Durdurmadan önce işlenecek maksimum iş sayısı
- `--max-time=0`: İşçinin çalışacağı maksimum süre (saniye)
- `--memory=128`: Bellek limiti (MB)
- `--timeout=60`: Bir işin zaman aşımına uğramadan önceki süre (saniye)
- `--tries=1`: İş başarısız sayılmadan önceki deneme sayısı
- `--max-priority=null`: Tüketilecek maksimum öncelik seviyesi
- `--num-processes=2`: Paralel çalışacak süreç sayısı

## Gelişmiş Özellikler

### Öncelikli Kuyruklar

Öncelikli kuyruk kullanmak için:

1. Kuyruk yapılandırmanızda maksimum önceliği belirleyin (1-255 arası, yüksek değer daha yüksek öncelik)
2. İşleri öncelik ile gönderin:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### Paralel İşleme

Birden fazla tüketici sürecini paralel çalıştırın:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### Quality of Service (QoS)

Prefetch ayarlarını kuyruk yapılandırmanızda tanımlayın:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // Belirli boyut limiti yok
        'prefetch_count' => 10,   // Aynı anda 10 mesaj işle
        'global'         => false // Tüketici başına uygula, kanal bazında değil
    ]
]
```

### SSL/TLS Bağlantıları

Güvenli bağlantı için:

1. Yapılandırmanızda `secure` değerini `true` yapın
2. SSL seçeneklerini uygun sertifika ve ayarlarla yapılandırın

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

## Hata Yönetimi ve Yeniden Denemeler

Başarısız işler, `--tries` seçeneğine göre otomatik olarak yeniden denenir. Maksimum denemeyi aşan işler başarısız işler tablosuna taşınır.

Yeniden deneme davranışını özelleştirebilirsiniz:

```php
// İş sınıfınızda
public function failed(Throwable $exception)
{
    // Başarısız işi yönet
}

// Özel yeniden deneme gecikmesi
public function retryAfter()
{
    return 30; // saniye
}
```

## Katkıda Bulunma

Katkılar memnuniyetle karşılanır! Lütfen bir Pull Request göndermekten çekinmeyin.

1. Depoyu çatallayın (fork)
2. Özellik dalınızı oluşturun (`git checkout -b feature/amazing-feature`)
3. Değişikliklerinizi kaydedin (`git commit -m 'Add some amazing feature'`)
4. Dala gönderin (`git push origin feature/amazing-feature`)
5. Bir Pull Request açın

## Lisans

Bu paket [MIT lisansı](https://raw.githubusercontent.com/iamfarhad/LaravelRabbitMQ/master/LICENSE) ile açık kaynaklı olarak lisanslanmıştır.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---