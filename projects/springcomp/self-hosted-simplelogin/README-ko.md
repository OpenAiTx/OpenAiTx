# SimpleLogin

이것은 [SimpleLogin](https://simplelogin.io)을 위한 셀프 호스팅 도커 컴포즈 구성입니다.

## 사전 요구사항

- 리눅스 서버 (가상 머신 또는 전용 서버). 이 문서는 Ubuntu 18.04 LTS 설정을 보여주지만 다른 인기 있는 리눅스 배포판에도 적용할 수 있습니다. 대부분의 구성 요소가 도커 컨테이너로 실행되고 도커가 다소 무거울 수 있으므로 최소 2GB의 RAM을 권장합니다. 서버는 포트 25(이메일), 80, 443(웹앱용), 22(SSH 접속용)가 열려 있어야 합니다.

- DNS 설정이 가능한 도메인. 서브도메인도 가능합니다. 문서에서는 이메일용으로 `mydomain.com`과 SimpleLogin 웹앱용으로 `app.mydomain.com`을 예시로 사용합니다. 문서 내에 등장하는 이 값들을 반드시 본인의 도메인 이름과 서브도메인 이름으로 바꾸어 주세요. 저희가 사용하는 팁은 이 README 파일을 컴퓨터에 다운로드한 후 모든 `mydomain.com`과 `app.mydomain.com`을 본인의 도메인으로 일괄 교체하는 것입니다.

도메인 등록기관 인터페이스에서 주로 하는 DNS 설정을 제외하고, 아래 모든 단계는 서버에서 진행합니다. 명령어는 `bash`(또는 `zsh` 같은 bash 호환 셸)에서 실행해야 합니다. `fish` 같은 다른 셸을 사용할 경우 명령어를 적절히 변환해야 합니다.

- 설정 확인에 사용되는 유틸리티 패키지들. 다음 명령어로 설치하세요:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```
## DNS 구성

_자세한 내용은 [참고 문서](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration)를 참조하세요_

> **참고** DNS 변경 사항이 전파되는 데 최대 24시간이 걸릴 수 있습니다. 실제로는 훨씬 빠르며(테스트에서는 약 1분 정도) DNS 설정 시, 일반적으로 도메인의 끝에 점(`.`)을 붙여 절대 도메인을 강제로 사용합니다.

다음 DNS 레코드를 설정해야 합니다:

- **A**: 도메인을 서버의 IPv4 주소에 매핑합니다.
- **AAAA**: 도메인을 서버의 IPv6 주소에 매핑합니다.
- **MX**: 들어오는 이메일을 메일 서버로 전달합니다(`*` 와일드카드 포함).
- **PTR**: 서버의 IP 주소를 도메인 이름으로 역매핑합니다.

필수 보안 정책을 설정하세요:

- **DKIM**: 발신 이메일에 디지털 서명을 하여 진위 여부를 검증합니다.
- **DMARC**: 인증 실패 시 이메일 수신자가 메시지를 처리하는 방식을 정의합니다.
- **SPF**: 특정 메일 서버가 도메인에서 이메일을 보낼 수 있도록 권한을 부여합니다.

추가 단계:

- **CAA**: 도메인에 대해 SSL 인증서를 발급할 수 있는 인증 기관을 지정합니다.
- **MTA-STS**: 메일 서버 간 보안 암호화 연결을 강제합니다.
- **TLS-RPT**: TLS 연결 실패를 보고하여 이메일 전달 보안을 개선합니다.

**경고**: CAA 레코드를 설정하면 도메인에 대해 SSL 인증서를 성공적으로 발급할 수 있는 인증 기관이 제한됩니다.
이로 인해 Let’s Encrypt 스테이징 서버에서 인증서 발급이 차단됩니다. SSL 인증서가 성공적으로 발급될 때까지 이 DNS 레코드를 미루는 것이 좋습니다.

## 도커

서버에 도커가 설치되어 있지 않은 경우, [Ubuntu용 Docker CE](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/)의 단계에 따라 도커를 설치하세요.

또한 [docker-install](https://github.com/docker/docker-install) 스크립트를 사용하여 도커를 설치할 수도 있습니다. 이는


```bash
curl -fsSL https://get.docker.com | sh
```
[기본 브리지 네트워크](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)에 대해 IPv6 활성화하기


```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```
이 절차는 Docker 컨테이너를 사용하여 전체 스택을 실행하는 방법을 안내합니다.  
여기에는 다음이 포함됩니다:  

- traefik  
- [SimpleLogin 앱](https://github.com/simple-login/app) 컨테이너  
- postfix  

Docker 컨테이너에서 SimpleLogin 실행:  

1. 이 저장소를 `/opt/simplelogin`에 클론합니다.  
1. `.env.example`을 `.env`로 복사하고 적절한 값을 설정합니다.  

    - `DOMAIN` 변수를 도메인으로 설정합니다.  
    - `SUBDOMAIN` 변수를 도메인 하위 도메인으로 설정합니다. 기본값은 `app`입니다.  
    - `POSTGRES_USER` 변수를 postgres 자격 증명에 맞게 설정합니다 (처음부터 시작할 때는 `simplelogin` 사용).  
    - `POSTGRES_PASSWORD`를 postgres 자격 증명에 맞게 설정합니다 (처음부터 시작할 때는 임의의 키로 설정).  
    - `FLASK_SECRET`을 임의의 비밀 키로 설정합니다.  

### Postgres SQL  

이 저장소는 Docker 컨테이너에서 postgres SQL을 실행합니다.  

**경고**: 이전 버전의 이 저장소는 `12.1` 버전을 실행했습니다.  
자세한 내용과 업그레이드 지침은 [참고 문서](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL)를 참조하십시오.  

### 애플리케이션 실행  

다음 명령어를 사용하여 애플리케이션을 실행합니다:



```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

이 시점에서 [인증서 기관 권한 부여(CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa)를 설정하는 것이 좋습니다.

## 다음 단계

위의 모든 단계가 성공적으로 완료되면 <https://app.mydomain.com/>을 열고 첫 번째 계정을 만드세요!

기본적으로 새 계정은 프리미엄이 아니므로 무제한 별칭을 가지지 않습니다. 계정을 프리미엄으로 만들려면,
데이터베이스의 "users" 테이블로 가서 "lifetime" 열을 "1" 또는 "TRUE"로 설정하세요:

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

원하는 모든 로그인 계정을 생성한 후, 추가 등록을 비활성화하려면 `.env`에 다음 줄을 추가하세요:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```
그런 다음, 웹 앱을 다시 시작하려면 다음을 적용하세요: `docker compose restart app`

## 기타

### Postfix 설정 - Spamhaus

Spamhaus 프로젝트는 스팸의 출처로 알려진 IP 주소 목록을 신뢰성 있게 유지합니다.  
해당 IP 주소가 목록에 있는지 확인하려면 DNS 인프라에 쿼리를 제출할 수 있습니다.

Spamhaus는 공개(오픈) DNS-리졸버에서 오는 쿼리를 차단하므로(참조: <https://check.spamhaus.org/returnc/pub>) postfix 컨테이너가  
기본적으로 공개 리졸버를 사용할 수 있으니, 무료  
[Spamhaus 데이터 쿼리 서비스](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)에 가입하고  
Spamhaus DQS 키를 받는 것을 권장합니다.

이 키를 `.env` 파일의 `SPAMHAUS_DQS_KEY`에 붙여넣으세요.

DQS 키가 제공되지 않으면 postfix 컨테이너는 Spamhaus 공개 미러가 쿼리를 수락하는지 확인하고 대신 이를 사용합니다.  
Spamhaus가 공개 미러에 대한 postfix 컨테이너의 쿼리를 거부하면, 해당 기능은 완전히 비활성화됩니다.

### Postfix 설정 - 가상 별칭

postfix 설정은 `postfix/conf.d/virtual` 및 `postfix/conf.d/virtual-regexp` 파일을 사용한 가상 별칭을 지원합니다.  
이 파일들은 시작 시 대응하는 [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)  
및 [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl) 템플릿 파일을 기반으로 자동 생성됩니다.

기본 설정은 다음과 같습니다:

#### virtual.tpl

`virtual` 파일은 postfix `virtual_alias_maps` 설정을 지원합니다.  
존재하지 않는 별칭에 해당하는 특정 주소인 `unknown@mydomain.com`에서 오는 메일을  
존재하는 다른 별칭인 `contact@mydomain.com`으로 매핑하는 규칙을 포함하여 수신을 시연합니다.


```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

`virtual-regexp` 파일은 postfix의 `virtual_alias_maps` 설정을 지원합니다.
기존의 별칭과 일치하지 않는 임의의 서브도메인으로 주소가 지정된 이메일을
서브도메인 이름을 딴 디렉터리에 속한 새 별칭으로 재작성하는 규칙을 포함합니다.
해당 별칭이 존재하지 않을 경우 즉시 생성될 수 있습니다.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```
예를 들어, `someone@directory.mydomain.com`으로 전송된 이메일은 postfix에 의해 `directory/someone@mydomain.com`으로 라우팅됩니다.

## 3.4.0 버전에서 업그레이드하는 방법

_이 섹션은 [참고 문서](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)로 이동되었습니다_

## 이전 NGinx 기반 설정에서 업그레이드하는 방법

_이 섹션은 [참고 문서](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)로 이동되었습니다_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-14

---