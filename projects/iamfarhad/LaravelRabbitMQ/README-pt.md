# Laravel RabbitMQ Queue Driver

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

Uma implementação robusta do driver de filas RabbitMQ para Laravel, fornecendo capacidades avançadas de enfileiramento de mensagens com alta performance e confiabilidade.

## Funcionalidades

- Integração nativa com a API de Filas do Laravel
- Suporte a jobs atrasados/agendados
- Filas com prioridade
- Tratamento de erros e tentativas automáticas
- Conexões seguras SSL/TLS
- Processamento paralelo com múltiplos consumidores
- Criação e vinculação automática de filas
- Opções abrangentes de configuração de filas
- Suporte a atributos de mensagens RabbitMQ
- Trocas de Dead Letter (DLX)
- Configurações de Qualidade de Serviço (QoS)
- Suporte a fila Quorum

## Política de Suporte

Apenas a versão mais recente receberá novos recursos. Correções de bugs serão fornecidas conforme o esquema a seguir:

| Versão do Pacote | Versão do Laravel | Versão do PHP | Correções até     |                                                                                     |
|------------------|-------------------|---------------|-------------------|-------------------------------------------------------------------------------------|
| 0.1              | 10, 11, 12        | ^8.2          | 26 de agosto, 2025| [Documentação](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md)  |

## Requisitos

- PHP 8.2+
- Laravel 10.x, 11.x ou 12.x
- RabbitMQ Server 3.8+
- ext-pcntl (para processamento paralelo)

## Instalação

Instale o pacote via Composer:

```bash
composer require iamfarhad/laravel-rabbitmq
```

O pacote será registrado automaticamente através do package discovery do Laravel.

Para Lumen, registre manualmente o service provider em `bootstrap/app.php`:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## Configuração

Adicione a conexão RabbitMQ ao seu arquivo `config/queue.php`:

```php
'connections' => [
    // ... outras conexões
    
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

Adicione estas variáveis de ambiente ao seu arquivo `.env`:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## Uso Básico

Uma vez configurado, você pode usar a API de filas do Laravel normalmente. Se você já está familiarizado com as filas do Laravel, não precisa alterar nada no seu código.

### Despachando Jobs

```php
// Despachar um job para a fila padrão
dispatch(new ProcessPodcast($podcast));

// Despachar um job para uma fila específica
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// Despachar um job com atraso
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### Criando Jobs

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
        // Especificar uma fila customizada
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // Processar o podcast...
    }
}
```

## Consumindo Mensagens

Existem duas formas de consumir mensagens do RabbitMQ:

### 1. Worker Padrão do Laravel

Worker embutido do Laravel, que utiliza `basic_get`:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. Consumidor Dedicado do RabbitMQ

Este pacote fornece um consumidor especializado para RabbitMQ, utilizando `basic_consume` e oferece melhor desempenho:

```bash
php artisan rabbitmq:consume --queue=default
```

#### Opções do Consumidor

```bash
php artisan rabbitmq:consume [options]
```

Opções:

- `--connection=`: O nome da conexão (padrão é a conexão default)
- `--queue=`: O nome da fila a ser consumida
- `--name=default`: O nome do consumidor
- `--once`: Processa apenas um job e finaliza
- `--stop-when-empty`: Para quando a fila estiver vazia
- `--delay=0`: O atraso para jobs que falharam (em segundos)
- `--max-jobs=0`: Número máximo de jobs a processar antes de parar
- `--max-time=0`: Tempo máximo em segundos para execução do worker
- `--memory=128`: Limite de memória em megabytes
- `--timeout=60`: Segundos que um job pode executar antes de dar timeout
- `--tries=1`: Número de tentativas antes de considerar o job como falhado
- `--max-priority=null`: Nível máximo de prioridade para consumir
- `--num-processes=2`: Número de processos paralelos para executar

## Funcionalidades Avançadas

### Filas com Prioridade

Para usar filas com prioridade:

1. Defina a prioridade máxima na configuração da sua fila (1-255, onde valores maiores significam prioridade maior)
2. Despache jobs com prioridade:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### Processamento Paralelo

Execute múltiplos processos consumidores em paralelo:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### Qualidade de Serviço (QoS)

Configure as definições de prefetch na configuração da sua fila:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // Sem limite de tamanho específico
        'prefetch_count' => 10,   // Processa 10 mensagens por vez
        'global'         => false // Aplica por consumidor, não por canal
    ]
]
```

### Conexões SSL/TLS

Para habilitar conexões seguras:

1. Defina `secure` como `true` na configuração
2. Configure as opções SSL com os certificados e definições apropriadas

```php
'secure' => true,
'ssl_options' => [
    'cafile'      => '/caminho/para/ca.pem',
    'local_cert'  => '/caminho/para/cert.pem',
    'local_key'   => '/caminho/para/key.pem',
    'verify_peer' => true,
    'passphrase'  => 'senha-do-certificado',
],
```

## Tratamento de Erros e Retentativas

Jobs que falham são automaticamente reenviados com base na opção `--tries`. Jobs que excedem o máximo de tentativas são movidos para a tabela de jobs falhados.

Você pode customizar o comportamento de retentativa:

```php
// No seu job
public function failed(Throwable $exception)
{
    // Tratar job falhado
}

// Retentativa customizada
public function retryAfter()
{
    return 30; // segundos
}
```

## Contribuindo

Contribuições são bem-vindas! Sinta-se à vontade para enviar um Pull Request.

1. Faça um fork do repositório
2. Crie um branch para sua feature (`git checkout -b feature/feature-incrivel`)
3. Faça commit das suas alterações (`git commit -m 'Adiciona feature incrível'`)
4. Faça push para o branch (`git push origin feature/feature-incrivel`)
5. Abra um Pull Request

## Licença

Este pacote é um software de código aberto licenciado sob a [licença MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---