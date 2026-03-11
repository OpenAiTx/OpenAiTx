[![Application](https://github.com/bpolaszek/mercure-x/actions/workflows/app.yml/badge.svg)](https://github.com/bpolaszek/mercure-x/actions/workflows/app.yml)
[![Coverage](https://codecov.io/gh/bpolaszek/freddie/branch/main/graph/badge.svg?token=uB4gRHyS6r)](https://codecov.io/gh/bpolaszek/freddie)

# Freddie

Freddie는 [Mercure Hub Specification](https://mercure.rocks/spec)의 PHP 구현체입니다.

매우 빠르며, 위대한 기술들을 바탕으로 구축되었습니다:
- [PHP](https://www.php.net/releases/8.1/en.php) 8.1
- [Framework X](https://framework-x.org/) 및 [ReactPHP](https://reactphp.org/)
- [Symfony](https://symfony.com/) 6
- [Redis](https://redis.io/) (선택 사항).

어떤 기능들이 구현되었고 아직 구현되지 않았는지 [여기](#feature-coverage)에서 확인하세요.

## 설치

허브를 실행하려면 PHP 8.1 이상이 필요합니다.

### 독립 실행형 Mercure 허브로서

```bash
composer create-project freddie/mercure-x freddie && cd freddie
bin/freddie
```
이 명령은 익명 구독이 활성화된 `127.0.0.1:8080`에서 Freddie 인스턴스를 시작합니다.

`HMAC SHA256` 알고리즘으로 `!ChangeMe!` 키로 서명된 유효한 JWT를 생성하여 허브에 업데이트를 게시할 수 있습니다.

이 값을 변경하려면 [보안](#security)을 참조하세요.

### 기존 Symfony 애플리케이션의 번들로서


```bash
composer req freddie/mercure-x
```

다음과 같이 허브를 시작할 수 있습니다:

```bash
bin/console freddie:serve
```

`.env.local`에서 관련 환경 변수를 덮어쓸 수 있으며,  
`config/services.yaml`에서 서비스를 평소처럼 설정할 수 있습니다.  

그런 다음, 서비스에 `Freddie\Hub\HubInterface`를 주입하여 `$hub->publish($update)`를 호출하거나,  
CLI 컨텍스트에서 디스패치된 업데이트를 수신할 수 있습니다 👍  

이는 Redis 전송 방식을 사용할 때만 작동한다는 점을 명심하세요.  

⚠️ **Freddie**는 자체 라우팅/인증 시스템을 사용합니다 (비동기 / 이벤트 루프 때문).  

공개하는 컨트롤러는 `routes.yaml`에 임포트할 수 없으며,  
`security.yaml`의 범위 밖에 있습니다.  

## 사용법  

```bash
./bin/freddie
```

`127.0.0.1:8080`에서 새로운 Mercure 허브를 시작합니다.  
이 주소를 변경하려면 `X_LISTEN` 환경 변수를 사용하십시오:  

```bash
X_LISTEN="0.0.0.0:8000" ./bin/freddie
```
### 보안

기본 JWT 키는 `!ChangeMe!`이며, `HS256` 서명을 사용합니다.

환경 변수(`.env.local` 또는 OS 레벨)에서 값을 변경하여 다른 값을 설정할 수 있습니다:  
`X_LISTEN`, `JWT_SECRET_KEY`, `JWT_ALGORITHM`, `JWT_PUBLIC_KEY`, 그리고 RS512 또는 ECDSA를 사용하는 경우 `JWT_PASSPHRASE`

게시자 및/또는 구독자로 인증하기 위해 Mercure 명세의 [권한 부여](https://mercure.rocks/spec#authorization) 섹션을 참조하십시오.

### PHP 전송 방식 (기본)

기본적으로 허브는 단일 PHP 프로세스에서 간단한 이벤트 디스패처로 실행됩니다.

이는 기본적인 사용에 적합하지만, 이 전송 방식을 사용하면 확장성이 제한됩니다.  
다른 프로세스를 열어도 동일한 이벤트 발행기를 공유하지 않기 때문입니다.

다음의 경우에는 여전히 완벽하게 사용할 수 있습니다:  
- 초당 수백 건 이상의 업데이트가 예상되지 않을 때  
- 애플리케이션이 단일 서버에서 제공될 때

### Redis 전송 방식

반면, Redis 전송 방식을 사용하면 허브를 **여러 포트** 및/또는 **여러 서버**에서 실행할 수 있습니다  
(동일한 Redis 인스턴스를 공유하는 한), 선택적으로 부하 분산기를 사용하여 트래픽을 분배할 수 있습니다.

허브의 [공식 오픈 소스 버전](https://mercure.rocks/docs/hub/install)은  
_볼트_ 전송 방식의 동시성 제한 때문에 확장을 허용하지 않습니다.

Redis 전송 방식을 사용하여 허브를 실행하려면, `TRANSPORT_DSN` 환경 변수를 변경하십시오:


```bash
TRANSPORT_DSN="redis://127.0.0.1:6379" ./bin/freddie
```

DSN 쿼리 문자열에 전달할 수 있는 선택적 매개변수:
- `pingInterval` - Redis 연결을 정기적으로 핑하여 장애를 감지하는 데 도움이 됨 (기본값 `2.0`)
- `readTimeout` - 핑 또는 게시 요청의 최대 지속 시간(초 단위) (기본값 `0.0`: 비활성화로 간주)

_또는 이 변수를 `.env.local`에 설정할 수 있습니다._

## 장점 및 한계

이 구현은 SSL 또는 HTTP2 종료를 제공하지 않으므로, 그 앞에 리버스 프록시를 두는 것이 좋습니다.

### Nginx 구성 예시

```nginx
upstream freddie {
    # Example with a single node
    server 127.0.0.1:8080;

    # Example with several nodes (they must share the same Redis instance)
    # 2 instances on 10.1.2.3
    server 10.1.2.3:8080;
    server 10.1.2.3:8081;

    # 2 instances on 10.1.2.4
    server 10.1.2.4:8080;
    server 10.1.2.4:8081;
}

server {
    
    listen 443 ssl http2;
    listen [::]:443 ssl http2;
    server_name example.com;

    ssl_certificate /etc/ssl/certs/example.com/example.com.cert;
    ssl_certificate_key /etc/ssl/certs/example.com/example.com.key;
    ssl_ciphers EECDH+CHACHA20:EECDH+AES128:RSA+AES128:EECDH+AES256:RSA+AES256:EECDH+3DES:RSA+3DES:!MD5;

    location /.well-known/mercure {
        proxy_pass http://freddie;
        proxy_read_timeout 24h;
        proxy_http_version 1.1;
        proxy_set_header Connection "";
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Host $host;
        proxy_set_header X-Forwarded-Proto $scheme;
    }
}
```

### 예제 Caddy 구성

#### 단일 노드

```caddy
example.com

reverse_proxy 127.0.0.1:8080
```

#### 여러 노드와 함께

```caddy
example.com

reverse_proxy 10.1.2.3:8080 10.1.2.3:8081 10.1.2.4:8080 10.1.2.4:8081
```
### 페이로드 제한사항
⚠ [Framework-X](https://framework-x.org/docs/api/request/)에는 요청 본문이 [64 KB](https://github.com/reactphp/http/issues/412) 이상이 될 수 없도록 하는 알려진 제한이 있습니다.  
작성 시점에서는 Framework-X가 HTTP 서버 인스턴스화를 캡슐화하고 있어 이 제한을 높일 수 없습니다.

Freddie에 더 큰 업데이트를 게시하는 경우(적어도 HTTP를 통해) 400 오류가 발생할 수 있습니다.

## 기능 지원 현황

| 기능                                         | 지원 여부                             |
|---------------------------------------------|-------------------------------------|
| `Authorization` 헤더를 통한 JWT             | ✅                                   |
| `mercureAuthorization` 쿠키를 통한 JWT      | ✅                                   |
| 익명 구독자 허용                            | ✅                                   |
| 대체 주제                                   | ✅️                                  |
| 비공개 업데이트                             | ✅                                   |
| 주제를 위한 URI 템플릿                      | ✅                                   |
| HMAC SHA256 JWT 서명                        | ✅                                   |
| RS512 JWT 서명                              | ✅                                   |
| 환경 변수 구성                             | ✅                                   |
| 사용자 정의 메시지 ID                       | ✅                                   |
| 마지막 이벤트 ID (`earliest` 포함)           | ✅️                                  |
| 사용자 정의 이벤트 타입                     | ✅️                                  |
| 사용자 정의 `retry` 지시어                   | ✅️                                  |
| CORS                                        | ❌ (웹 서버에서 구성하세요)            |
| 상태 점검 엔드포인트                        | ❌ (PR 환영)                         |
| 로깅                                        | ❌ (PR 환영)️                        |
| 메트릭                                      | ❌ (PR 환영)️                        |
| 구독자 / 발행자용 다른 JWT                   | ❌ (PR 환영)                         |
| 구독 API                                    | ❌️ (작업 예정)                      |


## 테스트

이 프로젝트는 [Pest](https://pestphp.com/) 테스트로 100% 커버됩니다.


```bash
composer tests:run
```

## 기여하기

이 프로젝트를 개선하고 싶다면 자유롭게 PR을 제출하세요:

- [PSR-12 코딩 표준](https://www.php-fig.org/psr/psr-12/)을 준수하지 않으면 CI가 경고합니다
- 새로운 기능의 경우 테스트가 반드시 포함되어야 합니다
- [PHPStan](https://phpstan.org/) 분석이 레벨 8에서 통과해야 합니다

커밋하기 전에 다음 명령어를 실행하여 모든 CI 요구 사항이 성공적으로 충족되었는지 확인할 수 있습니다:

```bash
composer ci:check
```

## 라이선스

GNU 일반 공중 사용 허가서 v3.0.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-11

---