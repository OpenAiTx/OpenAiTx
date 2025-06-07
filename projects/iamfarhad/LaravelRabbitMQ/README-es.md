# Controlador de Cola RabbitMQ para Laravel

[![Última Versión Estable](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Descargas Totales](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Licencia](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Estilo de código](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

Una implementación robusta de un controlador de colas RabbitMQ para Laravel, que proporciona capacidades avanzadas de encolado de mensajes con alto rendimiento y fiabilidad.

## Características

- Integración nativa con la API de colas de Laravel
- Soporte para trabajos retardados/programados
- Colas con prioridad
- Manejo de errores y reintentos automáticos
- Conexiones seguras SSL/TLS
- Procesamiento en paralelo con múltiples consumidores
- Creación y vinculación automática de colas
- Opciones de configuración de colas completas
- Soporte para atributos de mensajes RabbitMQ
- Intercambios de mensajes fallidos (dead letter exchanges)
- Configuración de Calidad de Servicio (QoS)
- Soporte para colas de quórum

## Política de Soporte

Solo la última versión recibirá nuevas características. Las correcciones de errores se proporcionarán usando el siguiente esquema:

| Versión del Paquete | Versión de Laravel | Versión de PHP | Correcciones de errores hasta |                                                                                     |
|---------------------|--------------------|----------------|------------------------------|-------------------------------------------------------------------------------------|
| 0.1                 | 10, 11, 12         | ^8.2           | 26 de agosto de 2025         | [Documentación](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md) |

## Requisitos

- PHP 8.2+
- Laravel 10.x, 11.x o 12.x
- Servidor RabbitMQ 3.8+
- ext-pcntl (para procesamiento en paralelo)

## Instalación

Instala el paquete vía Composer:

```bash
composer require iamfarhad/laravel-rabbitmq
```

El paquete se registrará automáticamente mediante el descubrimiento de paquetes de Laravel.

Para Lumen, registra manualmente el proveedor de servicios en `bootstrap/app.php`:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## Configuración

Agrega la conexión RabbitMQ a tu archivo `config/queue.php`:

```php
'connections' => [
    // ... otras conexiones
    
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

Agrega estas variables de entorno a tu archivo `.env`:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## Uso Básico

Una vez configurado, puedes utilizar la API de colas de Laravel como de costumbre. Si ya estás familiarizado con las colas de Laravel, no necesitas cambiar nada en tu código.

### Enviando Trabajos

```php
// Enviar un trabajo a la cola por defecto
dispatch(new ProcessPodcast($podcast));

// Enviar un trabajo a una cola específica
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// Enviar un trabajo con retardo
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### Creando Trabajos

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
        // Especifica una cola personalizada
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // Procesar el podcast...
    }
}
```

## Consumiendo Mensajes

Hay dos maneras de consumir mensajes de RabbitMQ:

### 1. Trabajador de Cola Estándar de Laravel

El trabajador de colas incorporado de Laravel que utiliza `basic_get`:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. Consumidor Dedicado de RabbitMQ

Este paquete proporciona un consumidor especializado de RabbitMQ que usa `basic_consume` y ofrece mejor rendimiento:

```bash
php artisan rabbitmq:consume --queue=default
```

#### Opciones del Consumidor

```bash
php artisan rabbitmq:consume [options]
```

Opciones:

- `--connection=`: El nombre de la conexión (por defecto la conexión por defecto)
- `--queue=`: El nombre de la cola a consumir
- `--name=default`: El nombre del consumidor
- `--once`: Procesa solo un trabajo y termina
- `--stop-when-empty`: Se detiene cuando la cola está vacía
- `--delay=0`: El retardo para trabajos fallidos (segundos)
- `--max-jobs=0`: Número máximo de trabajos a procesar antes de detenerse
- `--max-time=0`: Tiempo máximo en segundos que el trabajador debe ejecutarse
- `--memory=128`: Límite de memoria en megabytes
- `--timeout=60`: Segundos que puede ejecutarse un trabajo antes de caducar
- `--tries=1`: Número de intentos antes de que el trabajo se considere fallido
- `--max-priority=null`: Nivel máximo de prioridad a consumir
- `--num-processes=2`: Número de procesos paralelos a ejecutar

## Características Avanzadas

### Colas con Prioridad

Para usar colas con prioridad:

1. Establece la prioridad máxima en la configuración de tu cola (1-255, donde un valor más alto significa mayor prioridad)
2. Envía trabajos con prioridad:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### Procesamiento en Paralelo

Ejecuta múltiples procesos consumidores en paralelo:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### Calidad de Servicio (QoS)

Configura los ajustes de prefetch en la configuración de tu cola:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // Sin límite específico de tamaño
        'prefetch_count' => 10,   // Procesa 10 mensajes a la vez
        'global'         => false // Aplicar por consumidor, no por canal
    ]
]
```

### Conexiones SSL/TLS

Para habilitar conexiones seguras:

1. Establece `secure` a `true` en tu configuración
2. Configura las opciones SSL con los certificados y configuraciones apropiadas

```php
'secure' => true,
'ssl_options' => [
    'cafile'      => '/ruta/a/ca.pem',
    'local_cert'  => '/ruta/a/cert.pem',
    'local_key'   => '/ruta/a/key.pem',
    'verify_peer' => true,
    'passphrase'  => 'frase-secreta-del-certificado',
],
```

## Manejo de Errores y Reintentos

Los trabajos fallidos se reintentan automáticamente según la opción `--tries`. Los trabajos que superan el número máximo de reintentos se mueven a la tabla de trabajos fallidos.

Puedes personalizar el comportamiento de reintentos:

```php
// En tu clase de trabajo
public function failed(Throwable $exception)
{
    // Manejar el trabajo fallido
}

// Retardo personalizado de reintento
public function retryAfter()
{
    return 30; // segundos
}
```

## Contribuir

¡Las contribuciones son bienvenidas! No dudes en enviar un Pull Request.

1. Haz un fork del repositorio
2. Crea tu rama de característica (`git checkout -b feature/funcion-asombrosa`)
3. Haz commit de tus cambios (`git commit -m 'Agregar alguna función asombrosa'`)
4. Sube la rama (`git push origin feature/funcion-asombrosa`)
5. Abre un Pull Request

## Licencia

Este paquete es software de código abierto licenciado bajo la [licencia MIT](https://raw.githubusercontent.com/iamfarhad/LaravelRabbitMQ/master/LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---