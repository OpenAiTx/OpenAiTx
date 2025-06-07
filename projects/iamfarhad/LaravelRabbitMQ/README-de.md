# Laravel RabbitMQ Queue-Treiber

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

Eine robuste RabbitMQ-Queue-Treiber-Implementierung für Laravel, die erweiterte Nachrichtenwarteschlangenfunktionen mit hoher Leistung und Zuverlässigkeit bietet.

## Funktionen

- Native Integration der Laravel Queue API
- Unterstützung für verzögerte/geplante Jobs
- Priorisierte Queues
- Fehlerbehandlung und automatische Wiederholungen
- SSL/TLS-gesicherte Verbindungen
- Parallele Verarbeitung mit mehreren Consumern
- Automatische Queue-Erstellung und -Bindung
- Umfassende Konfigurationsmöglichkeiten für Queues
- Unterstützung für RabbitMQ-Nachrichtenattribute
- Dead Letter Exchanges
- Quality of Service (QoS)-Einstellungen
- Unterstützung für Quorum-Queues

## Support-Richtlinie

Nur die neueste Version erhält neue Funktionen. Fehlerbehebungen werden nach folgendem Schema bereitgestellt:

| Paketversion | Laravel-Version | PHP-Version | Fehlerbehebungen bis |                                                                                     |
|--------------|----------------|-------------|---------------------|-------------------------------------------------------------------------------------|
| 0.1          | 10, 11, 12     | ^8.2        | 26. August 2025     | [Dokumentation](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md) |

## Anforderungen

- PHP 8.2+
- Laravel 10.x, 11.x oder 12.x
- RabbitMQ Server 3.8+
- ext-pcntl (für parallele Verarbeitung)

## Installation

Installieren Sie das Paket über Composer:

```bash
composer require iamfarhad/laravel-rabbitmq
```

Das Paket registriert sich automatisch über die Paket-Erkennung von Laravel.

Für Lumen registrieren Sie den Service Provider manuell in `bootstrap/app.php`:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## Konfiguration

Fügen Sie die RabbitMQ-Verbindung zu Ihrer Datei `config/queue.php` hinzu:

```php
'connections' => [
    // ... andere Verbindungen

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

Fügen Sie diese Umgebungsvariablen zu Ihrer `.env`-Datei hinzu:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## Grundlegende Verwendung

Nach der Konfiguration können Sie die Laravel Queue API wie gewohnt nutzen. Wenn Sie bereits mit Laravel Queues vertraut sind, müssen Sie nichts an Ihrem Code ändern.

### Jobs dispatchen

```php
// Einen Job in die Standard-Queue dispatchen
dispatch(new ProcessPodcast($podcast));

// Einen Job in eine bestimmte Queue dispatchen
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// Einen Job mit Verzögerung dispatchen
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### Jobs erstellen

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
        // Eine benutzerdefinierte Queue angeben
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // Podcast verarbeiten...
    }
}
```

## Nachrichten konsumieren

Es gibt zwei Möglichkeiten, Nachrichten aus RabbitMQ zu konsumieren:

### 1. Standard-Laravel-Queue-Worker

Der in Laravel integrierte Queue-Worker, der `basic_get` verwendet:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. Dedizierter RabbitMQ-Consumer

Dieses Paket stellt einen spezialisierten RabbitMQ-Consumer bereit, der `basic_consume` verwendet und bessere Performance bietet:

```bash
php artisan rabbitmq:consume --queue=default
```

#### Consumer-Optionen

```bash
php artisan rabbitmq:consume [optionen]
```

Optionen:

- `--connection=`: Name der Verbindung (Standard: Standardverbindung)
- `--queue=`: Name der zu konsumierenden Queue
- `--name=default`: Name des Consumers
- `--once`: Nur einen Job verarbeiten und dann beenden
- `--stop-when-empty`: Stoppt, wenn die Queue leer ist
- `--delay=0`: Verzögerung für fehlgeschlagene Jobs (Sekunden)
- `--max-jobs=0`: Maximale Anzahl von Jobs, die verarbeitet werden sollen, bevor gestoppt wird
- `--max-time=0`: Maximale Laufzeit des Workers in Sekunden
- `--memory=128`: Speicherlimit in Megabyte
- `--timeout=60`: Sekunden, die ein Job laufen darf, bevor ein Timeout eintritt
- `--tries=1`: Anzahl der Versuche, bevor ein Job als fehlgeschlagen gilt
- `--max-priority=null`: Maximale Prioritätsstufe, die konsumiert wird
- `--num-processes=2`: Anzahl paralleler Prozesse

## Erweiterte Funktionen

### Priorisierte Queues

Um priorisierte Queues zu verwenden:

1. Setzen Sie die maximale Priorität in Ihrer Queue-Konfiguration (1-255, wobei höher eine höhere Priorität bedeutet)
2. Dispatchen Sie Jobs mit Priorität:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### Parallele Verarbeitung

Starten Sie mehrere Consumer-Prozesse parallel:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### Quality of Service (QoS)

Konfigurieren Sie die Prefetch-Einstellungen in Ihrer Queue-Konfiguration:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // Keine spezielle Größenbegrenzung
        'prefetch_count' => 10,   // 10 Nachrichten gleichzeitig verarbeiten
        'global'         => false // Gilt pro Consumer, nicht pro Channel
    ]
]
```

### SSL/TLS-Verbindungen

So aktivieren Sie sichere Verbindungen:

1. Setzen Sie `secure` auf `true` in Ihrer Konfiguration
2. Konfigurieren Sie die SSL-Optionen mit den entsprechenden Zertifikaten und Einstellungen

```php
'secure' => true,
'ssl_options' => [
    'cafile'      => '/pfad/zu/ca.pem',
    'local_cert'  => '/pfad/zu/cert.pem',
    'local_key'   => '/pfad/zu/key.pem',
    'verify_peer' => true,
    'passphrase'  => 'zertifikat-passphrase',
],
```

## Fehlerbehandlung und Wiederholungen

Fehlgeschlagene Jobs werden automatisch entsprechend der Option `--tries` erneut versucht. Jobs, die die maximale Anzahl an Versuchen überschreiten, werden in die Tabelle für fehlgeschlagene Jobs verschoben.

Sie können das Wiederholungsverhalten anpassen:

```php
// In Ihrer Job-Klasse
public function failed(Throwable $exception)
{
    // Fehlgeschlagenen Job behandeln
}

// Benutzerdefinierte Wiederholungsverzögerung
public function retryAfter()
{
    return 30; // Sekunden
}
```

## Beitrag leisten

Beiträge sind willkommen! Bitte reichen Sie gerne einen Pull Request ein.

1. Forken Sie das Repository
2. Erstellen Sie Ihren Feature-Branch (`git checkout -b feature/amazing-feature`)
3. Committen Sie Ihre Änderungen (`git commit -m 'Add some amazing feature'`)
4. Pushen Sie zum Branch (`git push origin feature/amazing-feature`)
5. Öffnen Sie einen Pull Request

## Lizenz

Dieses Paket ist Open-Source-Software und unter der [MIT-Lizenz](LICENSE) lizenziert.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---