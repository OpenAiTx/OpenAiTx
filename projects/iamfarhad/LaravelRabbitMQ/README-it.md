# Laravel RabbitMQ Queue Driver

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

Una solida implementazione del driver di coda RabbitMQ per Laravel, che fornisce funzionalità avanzate di message queuing con alte prestazioni e affidabilità.

## Funzionalità

- Integrazione nativa con l'API Laravel Queue
- Supporto per job ritardati/pianificati
- Code di priorità
- Gestione degli errori e retry automatici
- Connessioni sicure SSL/TLS
- Elaborazione parallela con più consumer
- Creazione e binding automatico delle code
- Opzioni di configurazione delle code complete
- Supporto per gli attributi dei messaggi RabbitMQ
- Dead letter exchanges
- Impostazioni di Quality of Service (QoS)
- Supporto per le code quorum

## Politica di Supporto

Solo l’ultima versione riceverà nuove funzionalità. Le correzioni di bug saranno fornite secondo lo schema seguente:

| Versione Pacchetto | Versione Laravel | Versione PHP | Correzioni Bug Fino al |                                                                                     |
|--------------------|------------------|--------------|------------------------|-------------------------------------------------------------------------------------|
| 0.1                | 10, 11, 12       | ^8.2         | 26 Agosto 2025         | [Documentazione](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md) |

## Requisiti

- PHP 8.2+
- Laravel 10.x, 11.x, o 12.x
- RabbitMQ Server 3.8+
- ext-pcntl (per l’elaborazione parallela)

## Installazione

Installa il pacchetto tramite Composer:

```bash
composer require iamfarhad/laravel-rabbitmq
```

Il pacchetto si registrerà automaticamente tramite la package discovery di Laravel.

Per Lumen, registra manualmente il service provider in `bootstrap/app.php`:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## Configurazione

Aggiungi la connessione RabbitMQ al tuo file `config/queue.php`:

```php
'connections' => [
    // ... altre connessioni
    
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

Aggiungi queste variabili di ambiente al tuo file `.env`:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## Utilizzo Base

Una volta configurato, puoi usare l’API Queue di Laravel normalmente. Se hai già familiarità con le code di Laravel, non devi cambiare nulla nel tuo codice.

### Dispatch dei Job

```php
// Invia un job alla coda predefinita
dispatch(new ProcessPodcast($podcast));

// Invia un job a una coda specifica
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// Invia un job con ritardo
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### Creazione dei Job

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
        // Specifica una coda personalizzata
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // Elabora il podcast...
    }
}
```

## Consumo dei Messaggi

Ci sono due modi per consumare messaggi da RabbitMQ:

### 1. Worker Standard di Laravel Queue

Il worker integrato di Laravel che utilizza `basic_get`:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. Consumer RabbitMQ Dedicato

Questo pacchetto fornisce un consumer RabbitMQ specializzato che utilizza `basic_consume` e offre migliori prestazioni:

```bash
php artisan rabbitmq:consume --queue=default
```

#### Opzioni del Consumer

```bash
php artisan rabbitmq:consume [options]
```

Opzioni:

- `--connection=`: Nome della connessione (default: connessione predefinita)
- `--queue=`: Nome della coda da cui consumare
- `--name=default`: Nome del consumer
- `--once`: Elabora solo un job ed esci
- `--stop-when-empty`: Ferma quando la coda è vuota
- `--delay=0`: Ritardo per i job falliti (secondi)
- `--max-jobs=0`: Numero massimo di job da elaborare prima di fermarsi
- `--max-time=0`: Tempo massimo in secondi di esecuzione del worker
- `--memory=128`: Limite di memoria in megabyte
- `--timeout=60`: Secondi che un job può durare prima del timeout
- `--tries=1`: Numero di tentativi prima che il job sia considerato fallito
- `--max-priority=null`: Livello di priorità massimo da consumare
- `--num-processes=2`: Numero di processi paralleli da eseguire

## Funzionalità Avanzate

### Code di Priorità

Per usare le code di priorità:

1. Imposta la priorità massima nella configurazione della coda (1-255, dove un valore più alto indica priorità più alta)
2. Invia i job con priorità:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### Elaborazione Parallela

Esegui più processi consumer in parallelo:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### Quality of Service (QoS)

Configura le impostazioni di prefetch nella configurazione della coda:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // Nessun limite di dimensione specifico
        'prefetch_count' => 10,   // Elabora 10 messaggi alla volta
        'global'         => false // Applica per consumer, non per canale
    ]
]
```

### Connessioni SSL/TLS

Per abilitare connessioni sicure:

1. Imposta `secure` a `true` nella tua configurazione
2. Configura le opzioni SSL con i certificati e le impostazioni appropriate

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

## Gestione Errori e Retry

I job falliti vengono automaticamente ritentati secondo l’opzione `--tries`. I job che superano il numero massimo di retry vengono spostati nella tabella dei job falliti.

Puoi personalizzare il comportamento del retry:

```php
// Nella tua classe Job
public function failed(Throwable $exception)
{
    // Gestisci il job fallito
}

// Ritardo personalizzato tra i retry
public function retryAfter()
{
    return 30; // secondi
}
```

## Contribuire

Le contribuzioni sono benvenute! Sentiti libero di inviare una Pull Request.

1. Fai il fork del repository
2. Crea il tuo branch (`git checkout -b feature/amazing-feature`)
3. Effettua i commit delle modifiche (`git commit -m 'Add some amazing feature'`)
4. Fai push del branch (`git push origin feature/amazing-feature`)
5. Apri una Pull Request

## Licenza

Questo pacchetto è un software open-source rilasciato sotto licenza [MIT](LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---