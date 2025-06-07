# Laravel RabbitMQ Queue Driver

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

Solidna implementacja sterownika kolejki RabbitMQ dla Laravel, zapewniająca zaawansowane możliwości kolejkowania wiadomości z wysoką wydajnością i niezawodnością.

## Funkcje

- Natwna integracja z API Kolejki Laravel
- Obsługa opóźnionych/zaplanowanych zadań
- Kolejki priorytetowe
- Obsługa błędów i automatyczne ponawianie
- Bezpieczne połączenia SSL/TLS
- Przetwarzanie równoległe z wieloma konsumentami
- Automatyczne tworzenie i wiązanie kolejek
- Rozbudowane opcje konfiguracji kolejek
- Obsługa atrybutów wiadomości RabbitMQ
- Dead letter exchanges
- Ustawienia Quality of Service (QoS)
- Obsługa kolejek kworumowych (quorum queues)

## Polityka wsparcia

Tylko najnowsza wersja otrzymuje nowe funkcje. Poprawki błędów będą dostarczane według poniższego schematu:

| Wersja pakietu | Wersja Laravel  | Wersja PHP  | Poprawki błędów do |                                                                                     |
|----------------|-----------------|-------------|--------------------|-------------------------------------------------------------------------------------|
| 0.1            | 10, 11, 12      | ^8.2        | 26 sierpnia 2025   | [Dokumentacja](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md)  |

## Wymagania

- PHP 8.2+
- Laravel 10.x, 11.x lub 12.x
- RabbitMQ Server 3.8+
- ext-pcntl (do przetwarzania równoległego)

## Instalacja

Zainstaluj pakiet przez Composer:

```bash
composer require iamfarhad/laravel-rabbitmq
```

Pakiet zarejestruje się automatycznie dzięki mechanizmowi wykrywania pakietów Laravel.

Dla Lumen, zarejestruj dostawcę usług ręcznie w pliku `bootstrap/app.php`:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## Konfiguracja

Dodaj połączenie RabbitMQ do pliku `config/queue.php`:

```php
'connections' => [
    // ... inne połączenia
    
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

Dodaj następujące zmienne środowiskowe do pliku `.env`:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## Podstawowe użycie

Po skonfigurowaniu możesz korzystać ze standardowego API Kolejki Laravel. Jeśli znasz już kolejki Laravel, nie musisz zmieniać niczego w swoim kodzie.

### Wysyłanie zadań

```php
// Wyślij zadanie do domyślnej kolejki
dispatch(new ProcessPodcast($podcast));

// Wyślij zadanie do określonej kolejki
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// Wyślij zadanie z opóźnieniem
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### Tworzenie zadań

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
        // Określ niestandardową kolejkę
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // Przetwarzaj podcast...
    }
}
```

## Konsumowanie wiadomości

Istnieją dwa sposoby konsumowania wiadomości z RabbitMQ:

### 1. Standardowy Worker Kolejki Laravel

Wbudowany worker Laravel, używający `basic_get`:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. Dedykowany Konsument RabbitMQ

Pakiet udostępnia specjalizowanego konsumenta RabbitMQ, używającego `basic_consume` i oferującego lepszą wydajność:

```bash
php artisan rabbitmq:consume --queue=default
```

#### Opcje Konsumenta

```bash
php artisan rabbitmq:consume [options]
```

Opcje:

- `--connection=`: Nazwa połączenia (domyślnie domyślne połączenie)
- `--queue=`: Nazwa kolejki do konsumpcji
- `--name=default`: Nazwa konsumenta
- `--once`: Przetwórz tylko jedno zadanie i zakończ
- `--stop-when-empty`: Zatrzymaj po opróżnieniu kolejki
- `--delay=0`: Opóźnienie dla nieudanych zadań (sekundy)
- `--max-jobs=0`: Maksymalna liczba zadań do przetworzenia przed zatrzymaniem
- `--max-time=0`: Maksymalny czas działania workera (w sekundach)
- `--memory=128`: Limit pamięci w megabajtach
- `--timeout=60`: Maksymalny czas trwania zadania (w sekundach)
- `--tries=1`: Liczba prób przed uznaniem zadania za nieudane
- `--max-priority=null`: Maksymalny poziom priorytetu do konsumpcji
- `--num-processes=2`: Liczba równoległych procesów

## Zaawansowane funkcje

### Kolejki priorytetowe

Aby używać kolejek priorytetowych:

1. Ustaw maksymalny priorytet w konfiguracji kolejki (1-255, gdzie większa liczba to wyższy priorytet)
2. Wysyłaj zadania z priorytetem:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### Przetwarzanie równoległe

Uruchom wiele procesów konsumentów równocześnie:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### Quality of Service (QoS)

Skonfiguruj ustawienia prefetch w konfiguracji kolejki:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // Brak limitu rozmiaru
        'prefetch_count' => 10,   // Przetwarzaj 10 wiadomości naraz
        'global'         => false // Stosuj dla konsumenta, nie kanału
    ]
]
```

### Połączenia SSL/TLS

Aby włączyć bezpieczne połączenia:

1. Ustaw `secure` na `true` w konfiguracji
2. Skonfiguruj opcje SSL z odpowiednimi certyfikatami i ustawieniami

```php
'secure' => true,
'ssl_options' => [
    'cafile'      => '/ścieżka/do/ca.pem',
    'local_cert'  => '/ścieżka/do/cert.pem',
    'local_key'   => '/ścieżka/do/key.pem',
    'verify_peer' => true,
    'passphrase'  => 'hasło-do-certyfikatu',
],
```

## Obsługa błędów i ponawianie

Nieudane zadania są automatycznie ponawiane zgodnie z opcją `--tries`. Zadania, które przekroczą maksymalną liczbę prób, trafiają do tabeli nieudanych zadań.

Możesz dostosować zachowanie ponawiania:

```php
// W klasie zadania
public function failed(Throwable $exception)
{
    // Obsłuż nieudane zadanie
}

// Niestandardowe opóźnienie ponawiania
public function retryAfter()
{
    return 30; // sekundy
}
```

## Współtworzenie

Wkład jest mile widziany! Zachęcamy do zgłaszania Pull Requestów.

1. Forkuj repozytorium
2. Utwórz gałąź funkcjonalności (`git checkout -b feature/amazing-feature`)
3. Zatwierdź zmiany (`git commit -m 'Add some amazing feature'`)
4. Wypchnij gałąź (`git push origin feature/amazing-feature`)
5. Otwórz Pull Request

## Licencja

Ten pakiet jest oprogramowaniem open-source na licencji [MIT license](LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---