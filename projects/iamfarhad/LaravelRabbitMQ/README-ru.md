# Laravel RabbitMQ Queue Driver

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

Мощная реализация драйвера очередей RabbitMQ для Laravel, обеспечивающая расширенные возможности очередей сообщений с высокой производительностью и надежностью.

## Возможности

- Интеграция с нативным API очередей Laravel
- Поддержка отложенных/запланированных заданий
- Очереди с приоритетами
- Обработка ошибок и автоматические повторные попытки
- Безопасные соединения SSL/TLS
- Параллельная обработка с несколькими потребителями
- Автоматическое создание и связывание очередей
- Широкие возможности конфигурирования очередей
- Поддержка атрибутов сообщений RabbitMQ
- Dead letter exchanges (DLX)
- Настройки качества обслуживания (QoS)
- Поддержка кворумных очередей

## Политика поддержки

Только последняя версия получает новые функции. Исправления ошибок предоставляются по следующей схеме:

| Версия пакета | Версия Laravel | Версия PHP | Исправления ошибок до |                                                                                         |
|---------------|----------------|------------|----------------------|-----------------------------------------------------------------------------------------|
| 0.1           | 10, 11, 12     | ^8.2       | 26 августа 2025      | [Документация](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md)      |

## Требования

- PHP 8.2+
- Laravel 10.x, 11.x или 12.x
- RabbitMQ Server 3.8+
- ext-pcntl (для параллельной обработки)

## Установка

Установите пакет через Composer:

```bash
composer require iamfarhad/laravel-rabbitmq
```

Пакет автоматически зарегистрируется через систему обнаружения пакетов Laravel.

Для Lumen вручную зарегистрируйте провайдера сервиса в `bootstrap/app.php`:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## Конфигурация

Добавьте подключение RabbitMQ в ваш файл `config/queue.php`:

```php
'connections' => [
    // ... другие соединения
    
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

Добавьте эти переменные среды в ваш файл `.env`:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## Базовое использование

После настройки вы можете использовать API очередей Laravel как обычно. Если вы уже знакомы с очередями Laravel, вам не нужно ничего менять в своем коде.

### Отправка заданий

```php
// Отправить задание в очередь по умолчанию
dispatch(new ProcessPodcast($podcast));

// Отправить задание в определённую очередь
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// Отправить задание с задержкой
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### Создание заданий

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
        // Указать пользовательскую очередь
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // Обработка подкаста...
    }
}
```

## Получение сообщений

Есть два способа получать сообщения из RabbitMQ:

### 1. Стандартный рабочий процесс очередей Laravel

Встроенный воркер Laravel, использующий `basic_get`:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. Специализированный потребитель RabbitMQ

Этот пакет предоставляет специализированного потребителя RabbitMQ, использующего `basic_consume` и обеспечивающего лучшую производительность:

```bash
php artisan rabbitmq:consume --queue=default
```

#### Опции потребителя

```bash
php artisan rabbitmq:consume [options]
```

Опции:

- `--connection=`: Имя подключения (по умолчанию используется подключение по умолчанию)
- `--queue=`: Имя очереди для потребления
- `--name=default`: Имя потребителя
- `--once`: Обработать только одно задание и выйти
- `--stop-when-empty`: Остановиться, когда очередь пуста
- `--delay=0`: Задержка для неудавшихся заданий (в секундах)
- `--max-jobs=0`: Максимальное количество заданий для обработки перед остановкой
- `--max-time=0`: Максимальное время работы воркера в секундах
- `--memory=128`: Лимит памяти в мегабайтах
- `--timeout=60`: Время выполнения задания до тайм-аута (в секундах)
- `--tries=1`: Количество попыток до признания задания неудачным
- `--max-priority=null`: Максимальный уровень приоритета для потребления
- `--num-processes=2`: Количество параллельных процессов

## Расширенные возможности

### Очереди с приоритетами

Для использования очередей с приоритетами:

1. Установите максимальный приоритет в конфигурации очереди (1-255, где большее значение — выше приоритет)
2. Отправляйте задания с приоритетом:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### Параллельная обработка

Запустите несколько процессов-потребителей параллельно:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### Качество обслуживания (QoS)

Настройте параметры prefetch в вашей конфигурации очереди:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // Без ограничения размера
        'prefetch_count' => 10,   // Обрабатывать по 10 сообщений за раз
        'global'         => false // Применять к каждому потребителю, а не к каналу
    ]
]
```

### SSL/TLS соединения

Для включения защищённых соединений:

1. Установите `secure` в `true` в вашей конфигурации
2. Настройте параметры SSL с соответствующими сертификатами и настройками

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

## Обработка ошибок и повторные попытки

Неудавшиеся задания автоматически повторяются в зависимости от опции `--tries`. Задания, превысившие максимальное количество попыток, перемещаются в таблицу неудавшихся заданий.

Вы можете кастомизировать поведение повторных попыток:

```php
// В вашем классе задания
public function failed(Throwable $exception)
{
    // Обработка неудавшегося задания
}

// Пользовательская задержка между попытками
public function retryAfter()
{
    return 30; // секунд
}
```

## Вклад в развитие

Вклад приветствуется! Не стесняйтесь отправлять Pull Request.

1. Сделайте форк репозитория
2. Создайте свою ветку с функцией (`git checkout -b feature/amazing-feature`)
3. Зафиксируйте изменения (`git commit -m 'Add some amazing feature'`)
4. Отправьте ветку (`git push origin feature/amazing-feature`)
5. Откройте Pull Request

## Лицензия

Этот пакет распространяется под лицензией [MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---