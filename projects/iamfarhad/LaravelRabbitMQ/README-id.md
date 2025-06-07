# Laravel RabbitMQ Queue Driver

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

Implementasi driver antrian RabbitMQ yang andal untuk Laravel, menyediakan kemampuan antrian pesan tingkat lanjut dengan kinerja tinggi dan keandalan.

## Fitur

- Integrasi API Antrian Laravel secara native
- Dukungan untuk pekerjaan yang ditunda/dijadwalkan
- Antrian prioritas
- Penanganan error dan percobaan ulang otomatis
- Koneksi aman SSL/TLS
- Pemrosesan paralel dengan banyak konsumen
- Pembuatan dan pengikatan antrian otomatis
- Opsi konfigurasi antrian yang komprehensif
- Dukungan atribut pesan RabbitMQ
- Dead letter exchanges
- Pengaturan Quality of Service (QoS)
- Dukungan antrian Quorum

## Kebijakan Dukungan

Hanya versi terbaru yang akan mendapatkan fitur baru. Perbaikan bug akan diberikan menggunakan skema berikut:

| Versi Paket | Versi Laravel | Versi PHP | Perbaikan Bug Hingga |                                                                                     |
|-------------|---------------|-----------|----------------------|-------------------------------------------------------------------------------------|
| 0.1         | 10, 11, 12    | ^8.2      | 26 Agustus 2025      | [Dokumentasi](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md)   |

## Persyaratan

- PHP 8.2+
- Laravel 10.x, 11.x, atau 12.x
- RabbitMQ Server 3.8+
- ext-pcntl (untuk pemrosesan paralel)

## Instalasi

Pasang paket melalui Composer:

```bash
composer require iamfarhad/laravel-rabbitmq
```

Paket akan secara otomatis mendaftarkan dirinya melalui package discovery Laravel.

Untuk Lumen, daftarkan service provider secara manual di `bootstrap/app.php`:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## Konfigurasi

Tambahkan koneksi RabbitMQ ke file `config/queue.php` Anda:

```php
'connections' => [
    // ... koneksi lainnya
    
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

Tambahkan variabel lingkungan berikut ke file `.env` Anda:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## Penggunaan Dasar

Setelah dikonfigurasi, Anda dapat menggunakan API Queue Laravel seperti biasa. Jika Anda sudah terbiasa dengan antrian Laravel, Anda tidak perlu mengubah apapun di kode Anda.

### Mengirim Job

```php
// Kirim job ke antrian default
dispatch(new ProcessPodcast($podcast));

// Kirim job ke antrian tertentu
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// Kirim job dengan delay
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### Membuat Job

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
        // Tentukan antrian kustom
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // Proses podcast...
    }
}
```

## Mengkonsumsi Pesan

Ada dua cara untuk mengkonsumsi pesan dari RabbitMQ:

### 1. Worker Queue Laravel Standar

Worker queue bawaan Laravel yang menggunakan `basic_get`:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. Konsumen RabbitMQ Khusus

Paket ini menyediakan konsumen RabbitMQ khusus yang menggunakan `basic_consume` dan menawarkan performa lebih baik:

```bash
php artisan rabbitmq:consume --queue=default
```

#### Opsi Konsumen

```bash
php artisan rabbitmq:consume [options]
```

Opsi:

- `--connection=`: Nama koneksi (default ke koneksi default)
- `--queue=`: Nama antrian yang akan dikonsumsi
- `--name=default`: Nama konsumen
- `--once`: Proses hanya satu job lalu keluar
- `--stop-when-empty`: Berhenti jika antrian kosong
- `--delay=0`: Delay untuk job gagal (detik)
- `--max-jobs=0`: Maksimum jumlah job yang diproses sebelum berhenti
- `--max-time=0`: Waktu maksimum dalam detik worker berjalan
- `--memory=128`: Batas memori dalam megabyte
- `--timeout=60`: Detik job dapat berjalan sebelum timeout
- `--tries=1`: Jumlah percobaan sebelum job dianggap gagal
- `--max-priority=null`: Level prioritas maksimum yang dikonsumsi
- `--num-processes=2`: Jumlah proses paralel yang dijalankan

## Fitur Lanjutan

### Antrian Prioritas

Untuk menggunakan antrian prioritas:

1. Atur prioritas maksimum di konfigurasi antrian Anda (1-255, semakin tinggi semakin prioritas)
2. Kirim job dengan prioritas:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### Pemrosesan Paralel

Jalankan beberapa proses konsumen secara paralel:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### Quality of Service (QoS)

Atur prefetch di konfigurasi antrian Anda:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // Tidak ada batasan ukuran spesifik
        'prefetch_count' => 10,   // Proses 10 pesan sekaligus
        'global'         => false // Berlaku per konsumen, bukan per channel
    ]
]
```

### Koneksi SSL/TLS

Untuk mengaktifkan koneksi aman:

1. Setel `secure` ke `true` di konfigurasi Anda
2. Konfigurasikan opsi SSL dengan sertifikat dan pengaturan yang sesuai

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

## Penanganan Error dan Retry

Job yang gagal akan otomatis dicoba ulang berdasarkan opsi `--tries`. Job yang melebihi batas retry akan dipindahkan ke tabel job gagal.

Anda bisa menyesuaikan perilaku retry:

```php
// Dalam class job Anda
public function failed(Throwable $exception)
{
    // Penanganan job gagal
}

// Delay retry kustom
public function retryAfter()
{
    return 30; // detik
}
```

## Kontribusi

Kontribusi sangat diterima! Silakan ajukan Pull Request.

1. Fork repositori
2. Buat branch fitur Anda (`git checkout -b feature/amazing-feature`)
3. Commit perubahan Anda (`git commit -m 'Add some amazing feature'`)
4. Push ke branch (`git push origin feature/amazing-feature`)
5. Buka Pull Request

## Lisensi

Paket ini adalah perangkat lunak open-source yang dilisensikan di bawah [lisensi MIT](https://raw.githubusercontent.com/iamfarhad/LaravelRabbitMQ/master/LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---