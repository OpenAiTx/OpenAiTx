# Laravel RabbitMQ Queue Driver

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

A robust RabbitMQ queue driver implementation for Laravel, providing advanced message queuing capabilities with high performance and reliability.

## Features

- Native Laravel Queue API integration
- Support for delayed/scheduled jobs
- Priority queues
- Error handling and automatic retries
- SSL/TLS secure connections
- Parallel processing with multiple consumers
- Automatic queue creation and binding
- Comprehensive queue configuration options
- RabbitMQ message attributes support
- Dead letter exchanges
- Quality of Service (QoS) settings
- Quorum queue support

## Support Policy

Only the latest version will get new features. Bug fixes will be provided using the following scheme:

| Package Version | Laravel Version | PHP Version | Bug Fixes Until   |                                                                                     |
|-----------------|-----------------|-------------|-------------------|-------------------------------------------------------------------------------------|
| 0.1             | 10, 11, 12      | ^8.2        | August 26th, 2025 | [Documentation](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md) |

## Requirements

- PHP 8.2+
- Laravel 10.x, 11.x, or 12.x
- RabbitMQ Server 3.8+
- ext-pcntl (for parallel processing)

## Installation

Install the package via Composer:

```bash
composer require iamfarhad/laravel-rabbitmq
```

The package will automatically register itself through Laravel's package discovery.

For Lumen, manually register the service provider in `bootstrap/app.php`:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## Configuration

Add the RabbitMQ connection to your `config/queue.php` file:

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

Add these environment variables to your `.env` file:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## Basic Usage

Once configured, you can use Laravel's Queue API as normal. If you're already familiar with Laravel queues, you don't need to change anything in your code.

### Dispatching Jobs

```php
// Dispatch a job to the default queue
dispatch(new ProcessPodcast($podcast));

// Dispatch a job to a specific queue
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// Dispatch a job with delay
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### Creating Jobs

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
        // Specify a custom queue
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // Process the podcast...
    }
}
```

## Consuming Messages

There are two ways to consume messages from RabbitMQ:

### 1. Standard Laravel Queue Worker

Laravel's built-in queue worker which uses `basic_get`:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. Dedicated RabbitMQ Consumer

This package provides a specialized RabbitMQ consumer which uses `basic_consume` and offers better performance:

```bash
php artisan rabbitmq:consume --queue=default
```

#### Consumer Options

```bash
php artisan rabbitmq:consume [options]
```

Options:

- `--connection=`: The connection name (defaults to default connection)
- `--queue=`: The queue name to consume from
- `--name=default`: The consumer name
- `--once`: Process only one job and exit
- `--stop-when-empty`: Stop when the queue is empty
- `--delay=0`: The delay for failed jobs (seconds)
- `--max-jobs=0`: Maximum number of jobs to process before stopping
- `--max-time=0`: Maximum time in seconds the worker should run
- `--memory=128`: Memory limit in megabytes
- `--timeout=60`: Seconds a job can run before timing out
- `--tries=1`: Number of attempts before job is considered failed
- `--max-priority=null`: Maximum priority level to consume
- `--num-processes=2`: Number of parallel processes to run

## Advanced Features

### Priority Queues

To use priority queues:

1. Set the maximum priority in your queue configuration (1-255, where higher means higher priority)
2. Dispatch jobs with priority:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### Parallel Processing

Run multiple consumer processes in parallel:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### Quality of Service (QoS)

Configure prefetch settings in your queue configuration:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // No specific size limit
        'prefetch_count' => 10,   // Process 10 messages at a time
        'global'         => false // Apply per consumer, not channel
    ]
]
```

### SSL/TLS Connections

To enable secure connections:

1. Set `secure` to `true` in your configuration
2. Configure SSL options with appropriate certificates and settings

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

## Error Handling and Retries

Failed jobs are automatically retried based on the `--tries` option. Jobs that exceed the maximum retries are moved to the failed jobs table.

You can customize retry behavior:

```php
// In your job class
public function failed(Throwable $exception)
{
    // Handle failed job
}

// Custom retry delay
public function retryAfter()
{
    return 30; // seconds
}
```

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This package is open-sourced software licensed under the [MIT license](https://raw.githubusercontent.com/iamfarhad/LaravelRabbitMQ/master/LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---