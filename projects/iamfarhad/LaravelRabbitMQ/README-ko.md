# Laravel RabbitMQ 큐 드라이버

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

고성능과 신뢰성을 갖춘 고급 메시지 큐잉 기능을 제공하는 Laravel용 강력한 RabbitMQ 큐 드라이버 구현체입니다.

## 특징

- Laravel Queue API와의 네이티브 통합
- 지연/예약 작업 지원
- 우선순위 큐 지원
- 에러 처리 및 자동 재시도
- SSL/TLS 보안 연결
- 다중 컨슈머를 활용한 병렬 처리
- 큐 자동 생성 및 바인딩
- 포괄적인 큐 설정 옵션
- RabbitMQ 메시지 속성 지원
- 데드레터 익스체인지(Dead Letter Exchanges) 지원
- QoS(서비스 품질) 설정
- 쿼럼 큐(Quorum Queue) 지원

## 지원 정책

최신 버전만 새로운 기능이 추가됩니다. 버그 수정은 다음 기준에 따라 제공됩니다.

| 패키지 버전 | Laravel 버전 | PHP 버전 | 버그 수정 지원 종료 |                                                                                     |
|-------------|--------------|----------|---------------------|-------------------------------------------------------------------------------------|
| 0.1         | 10, 11, 12   | ^8.2     | 2025년 8월 26일     | [문서](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md)          |

## 요구 사항

- PHP 8.2 이상
- Laravel 10.x, 11.x, 또는 12.x
- RabbitMQ 서버 3.8 이상
- ext-pcntl (병렬 처리용)

## 설치

Composer를 통해 패키지를 설치합니다:

```bash
composer require iamfarhad/laravel-rabbitmq
```

패키지는 Laravel의 패키지 디스커버리 기능을 통해 자동으로 등록됩니다.

Lumen을 사용할 경우, `bootstrap/app.php`에 서비스 프로바이더를 수동으로 등록해야 합니다:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## 설정

`config/queue.php` 파일에 RabbitMQ 연결을 추가합니다:

```php
'connections' => [
    // ... 다른 연결

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

다음 환경 변수를 `.env` 파일에 추가하세요:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## 기본 사용법

설정이 완료되면, Laravel의 Queue API를 평소와 같이 사용할 수 있습니다. 이미 Laravel 큐에 익숙하다면, 코드상에서 변경할 부분은 없습니다.

### 작업(Job) 디스패치

```php
// 기본 큐에 작업 디스패치
dispatch(new ProcessPodcast($podcast));

// 특정 큐에 작업 디스패치
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// 딜레이와 함께 작업 디스패치
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### 작업(Job) 생성

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
        // 커스텀 큐 지정
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // 팟캐스트 처리...
    }
}
```

## 메시지 소비(Consume)

RabbitMQ에서 메시지를 소비하는 방법은 두 가지가 있습니다:

### 1. 표준 Laravel 큐 워커

Laravel의 기본 큐 워커(`basic_get` 사용):

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. 전용 RabbitMQ 컨슈머

이 패키지는 `basic_consume`을 사용하여 더 나은 성능을 제공하는 전용 RabbitMQ 컨슈머를 제공합니다:

```bash
php artisan rabbitmq:consume --queue=default
```

#### 컨슈머 옵션

```bash
php artisan rabbitmq:consume [옵션]
```

옵션:

- `--connection=`: 연결 이름 (기본 연결 사용)
- `--queue=`: 소비할 큐 이름
- `--name=default`: 컨슈머 이름
- `--once`: 한 번만 작업을 처리하고 종료
- `--stop-when-empty`: 큐가 비면 중지
- `--delay=0`: 실패한 작업의 딜레이(초)
- `--max-jobs=0`: 중지 전 최대 처리 작업 수
- `--max-time=0`: 워커가 실행될 최대 시간(초)
- `--memory=128`: 메모리 한계(MB)
- `--timeout=60`: 작업 타임아웃(초)
- `--tries=1`: 작업이 실패로 간주되기 전 시도 횟수
- `--max-priority=null`: 소비할 최대 우선순위 레벨
- `--num-processes=2`: 병렬로 실행할 프로세스 수

## 고급 기능

### 우선순위 큐

우선순위 큐를 사용하려면:

1. 큐 설정에서 최대 우선순위(1-255, 높을수록 우선순위가 높음)를 지정하세요
2. 작업을 우선순위와 함께 디스패치하세요:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### 병렬 처리

여러 컨슈머 프로세스를 병렬로 실행:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### QoS(서비스 품질)

큐 설정에서 prefetch를 지정:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // 크기 제한 없음
        'prefetch_count' => 10,   // 한 번에 10개의 메시지 처리
        'global'         => false // 채널이 아닌 컨슈머별 적용
    ]
]
```

### SSL/TLS 연결

보안 연결을 활성화하려면:

1. 설정에서 `secure`를 `true`로 지정
2. 적절한 인증서와 설정으로 SSL 옵션 구성

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

## 에러 처리 및 재시도

실패한 작업은 `--tries` 옵션에 따라 자동으로 재시도됩니다. 최대 시도 횟수를 초과한 작업은 실패한 작업 테이블로 이동됩니다.

재시도 동작을 커스터마이징할 수 있습니다:

```php
// 작업 클래스 내
public function failed(Throwable $exception)
{
    // 실패한 작업 처리
}

// 커스텀 재시도 딜레이
public function retryAfter()
{
    return 30; // 초 단위
}
```

## 기여하기

기여를 환영합니다! Pull Request를 자유롭게 제출해주세요.

1. 저장소를 포크하세요
2. 기능 브랜치를 생성하세요 (`git checkout -b feature/amazing-feature`)
3. 변경사항을 커밋하세요 (`git commit -m 'Add some amazing feature'`)
4. 브랜치로 푸시하세요 (`git push origin feature/amazing-feature`)
5. Pull Request를 여세요

## 라이선스

이 패키지는 [MIT 라이선스](LICENSE) 하에 오픈소스 소프트웨어로 제공됩니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---