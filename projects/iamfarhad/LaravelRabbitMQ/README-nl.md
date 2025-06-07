# Laravel RabbitMQ Queue Driver

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

Een robuuste RabbitMQ queue driver implementatie voor Laravel, die geavanceerde message queueing mogelijkheden biedt met hoge prestaties en betrouwbaarheid.

## Functies

- Native Laravel Queue API-integratie
- Ondersteuning voor vertraagde/geplande jobs
- Prioriteitswachtrijen
- Foutafhandeling en automatische herhalingen
- SSL/TLS beveiligde verbindingen
- Parallelle verwerking met meerdere consumers
- Automatische aanmaak en binding van wachtrijen
- Uitgebreide wachtrijconfiguratie-opties
- Ondersteuning voor RabbitMQ berichtattributen
- Dead letter exchanges
- Quality of Service (QoS) instellingen
- Quorum queue ondersteuning

## Ondersteuningsbeleid

Alleen de nieuwste versie krijgt nieuwe functies. Foutoplossingen worden geleverd volgens het volgende schema:

| Pakketversie | Laravel Versie | PHP Versie | Foutoplossingen tot |                                                                                     |
|--------------|---------------|------------|---------------------|-------------------------------------------------------------------------------------|
| 0.1          | 10, 11, 12    | ^8.2       | 26 augustus 2025    | [Documentatie](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md)  |

## Vereisten

- PHP 8.2+
- Laravel 10.x, 11.x, of 12.x
- RabbitMQ Server 3.8+
- ext-pcntl (voor parallelle verwerking)

## Installatie

Installeer het pakket via Composer:

```bash
composer require iamfarhad/laravel-rabbitmq
```

Het pakket registreert zichzelf automatisch via Laravel's package discovery.

Voor Lumen, registreer de service provider handmatig in `bootstrap/app.php`:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## Configuratie

Voeg de RabbitMQ-verbinding toe aan je `config/queue.php` bestand:

```php
'connections' => [
    // ... andere verbindingen
    
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

Voeg deze omgevingsvariabelen toe aan je `.env` bestand:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## Basisgebruik

Zodra geconfigureerd, kun je de Queue API van Laravel zoals gebruikelijk gebruiken. Als je al bekend bent met Laravel-wachtrijen, hoef je niets aan je code te veranderen.

### Jobs dispatchen

```php
// Verstuur een job naar de standaardwachtrij
dispatch(new ProcessPodcast($podcast));

// Verstuur een job naar een specifieke wachtrij
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// Verstuur een job met vertraging
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### Jobs aanmaken

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
        // Specificeer een aangepaste wachtrij
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // Verwerk de podcast...
    }
}
```

## Berichten consumeren

Er zijn twee manieren om berichten van RabbitMQ te consumeren:

### 1. Standaard Laravel Queue Worker

De ingebouwde Laravel queue worker die `basic_get` gebruikt:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. Toegewijde RabbitMQ Consumer

Dit pakket levert een gespecialiseerde RabbitMQ consumer die `basic_consume` gebruikt en betere prestaties biedt:

```bash
php artisan rabbitmq:consume --queue=default
```

#### Consumer Opties

```bash
php artisan rabbitmq:consume [options]
```

Opties:

- `--connection=`: De naam van de verbinding (standaard: standaardverbinding)
- `--queue=`: De naam van de wachtrij om te consumeren
- `--name=default`: De naam van de consumer
- `--once`: Verwerk slechts één job en stop daarna
- `--stop-when-empty`: Stop als de wachtrij leeg is
- `--delay=0`: De vertraging voor mislukte jobs (seconden)
- `--max-jobs=0`: Maximaal aantal jobs om te verwerken voor het stoppen
- `--max-time=0`: Maximale tijd in seconden dat de worker mag draaien
- `--memory=128`: Geheugenlimiet in megabytes
- `--timeout=60`: Seconden dat een job mag draaien voordat deze afloopt
- `--tries=1`: Aantal pogingen voordat een job als mislukt wordt beschouwd
- `--max-priority=null`: Maximale prioriteitsniveau om te consumeren
- `--num-processes=2`: Aantal parallelle processen om te draaien

## Geavanceerde Functies

### Prioriteitswachtrijen

Om prioriteitswachtrijen te gebruiken:

1. Stel de maximale prioriteit in je wachtrijconfiguratie in (1-255, waarbij hoger een hogere prioriteit betekent)
2. Verstuur jobs met prioriteit:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### Parallelle Verwerking

Draai meerdere consumer-processen parallel:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### Quality of Service (QoS)

Configureer prefetch-instellingen in je wachtrijconfiguratie:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // Geen specifieke groottebeperking
        'prefetch_count' => 10,   // Verwerk 10 berichten tegelijk
        'global'         => false // Per consumer toepassen, niet per channel
    ]
]
```

### SSL/TLS Verbindingen

Om beveiligde verbindingen in te schakelen:

1. Zet `secure` op `true` in je configuratie
2. Configureer SSL-opties met de juiste certificaten en instellingen

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

## Foutafhandeling en Herhalingen

Mislukte jobs worden automatisch herhaald op basis van de `--tries` optie. Jobs die de maximale herhalingen overschrijden, worden verplaatst naar de tabel met mislukte jobs.

Je kunt het herhaalgedrag aanpassen:

```php
// In je jobklasse
public function failed(Throwable $exception)
{
    // Afhandeling van mislukte job
}

// Aangepaste herhaalvertraging
public function retryAfter()
{
    return 30; // seconden
}
```

## Bijdragen

Bijdragen zijn welkom! Voel je vrij om een Pull Request in te dienen.

1. Fork de repository
2. Maak je feature branch (`git checkout -b feature/amazing-feature`)
3. Commit je wijzigingen (`git commit -m 'Add some amazing feature'`)
4. Push naar de branch (`git push origin feature/amazing-feature`)
5. Open een Pull Request

## Licentie

Dit pakket is open-source software gelicentieerd onder de [MIT-licentie](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---