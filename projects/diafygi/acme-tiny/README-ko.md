<translate-content># acme-tiny

[![Tests](https://github.com/diafygi/acme-tiny/actions/workflows/full-tests-with-coverage.yml/badge.svg?branch=main)](https://github.com/diafygi/acme-tiny/actions/workflows/full-tests-with-coverage.yml)
[![Coverage Status](https://coveralls.io/repos/github/diafygi/acme-tiny/badge.svg?branch=main)](https://coveralls.io/github/diafygi/acme-tiny?branch=main)

이 스크립트는 서버에 올려서 [Let's Encrypt](https://letsencrypt.org/) 인증서를 발급
및 갱신할 수 있는 작고 검증 가능한 스크립트입니다. 서버에서 실행되어야 하고
개인 Let's Encrypt 계정 키에 접근할 수 있어야 하기 때문에 최대한 작게 만들었습니다
(현재 200줄 미만). 필요한 것은 python과 openssl뿐입니다.

**소스 코드를 꼭 읽어보세요! 개인 계정 키를 신뢰해야 합니다!**

## 기부

이 스크립트가 유용하다면 EFF에 기부해 주세요. 저는 거기서 일하지 않지만,
그들은 훌륭한 일을 하고 있습니다.

[https://eff.org/donate/](https://eff.org/donate/)

## 이 스크립트 사용법

이미 Let's Encrypt에서 발급받은 인증서가 있고 단지 갱신만 원한다면,
3단계와 6단계만 수행하면 됩니다.

### 1단계: Let's Encrypt 계정 개인 키 생성 (아직 없다면)

Let's Encrypt에 공개 키가 등록되어 있어야 하며, 요청에 대응하는 개인 키로
서명해야 합니다. 방금 말한 내용을 이해하지 못한다면,
이 스크립트는 아마 적합하지 않을 것입니다! 공식 Let's Encrypt
[클라이언트](https://github.com/letsencrypt/letsencrypt)를 사용하세요.
이를 위해 처음에 acme-tiny가 사용할 수 있는 키를 생성하여
계정을 등록하고 이후 모든 요청에 서명할 수 있도록 해야 합니다.
</translate-content>

```
openssl genrsa 4096 > account.key
```
#### 기존 Let's Encrypt 키 사용

또는 이전에 원래의 Let's Encrypt 클라이언트로 생성한 키를 변환할 수 있습니다.

Let's Encrypt 클라이언트의 개인 계정 키는
[JWK](https://tools.ietf.org/html/rfc7517) 형식으로 저장됩니다. `acme-tiny`는 PEM
키 형식을 사용합니다. 키를 변환하려면 JonLundy의 도구
[변환 스크립트](https://gist.github.com/JonLundy/f25c99ee0770e19dc595)를 사용할 수 있습니다:



```sh
# Download the script
wget -O - "https://gist.githubusercontent.com/JonLundy/f25c99ee0770e19dc595/raw/6035c1c8938fae85810de6aad1ecf6e2db663e26/conv.py" > conv.py

# Copy your private key to your working directory
cp /etc/letsencrypt/accounts/acme-v01.api.letsencrypt.org/directory/<id>/private_key.json private_key.json

# Create a DER encoded private key
openssl asn1parse -noout -out private_key.der -genconf <(python2 conv.py private_key.json)

# Convert to PEM
openssl rsa -in private_key.der -inform der > account.key
```
### 2단계: 도메인용 인증서 서명 요청(CSR) 생성하기.

ACME 프로토콜(Let's Encrypt가 사용하는 프로토콜)은 갱신 시에도
CSR 파일 제출을 요구합니다. 여러 번의 갱신에 동일한 CSR을 사용할 수 있습니다. 참고:
계정 개인 키를 도메인 개인 키로 사용할 수 없습니다!


```
# Generate a domain private key (if you haven't already)
openssl genrsa 4096 > domain.key
```

```
# For a single domain
openssl req -new -sha256 -key domain.key -subj "/CN=yoursite.com" > domain.csr

# For multiple domains (use this one if you want both www.yoursite.com and yoursite.com)
openssl req -new -sha256 -key domain.key -subj "/" -addext "subjectAltName = DNS:yoursite.com, DNS:www.yoursite.com" > domain.csr

# For multiple domains (same as above but works with openssl < 1.1.1)
openssl req -new -sha256 -key domain.key -subj "/" -reqexts SAN -config <(cat /etc/ssl/openssl.cnf <(printf "[SAN]\nsubjectAltName=DNS:yoursite.com,DNS:www.yoursite.com")) > domain.csr
```
### 3단계: 웹사이트 호스트 챌린지 파일 만들기

인증서를 발급받고자 하는 도메인의 소유권을 증명해야 하므로, Let's Encrypt는
해당 도메인에 파일을 호스팅할 것을 요구합니다. 이 스크립트는 지정한 폴더에
해당 파일들을 생성하고 작성하므로, 이 폴더가 ".well-known/acme-challenge/"
URL 경로 아래에서 서비스되는지만 확인하면 됩니다. 참고: Let's Encrypt는
서버의 80번 포트로 평문 HTTP 요청을 수행하므로, 챌린지 파일은 HTTP를 통해
서비스해야 합니다(HTTPS로 리디렉션해도 무방합니다).


```
# Make some challenge folder (modify to suit your needs)
mkdir -p /var/www/challenges/
```

```nginx
# Example for nginx
server {
    listen 80;
    server_name yoursite.com www.yoursite.com;

    location /.well-known/acme-challenge/ {
        alias /var/www/challenges/;
        try_files $uri =404;
    }

    ...the rest of your config
}
```
### 4단계: 서명된 인증서 받기!

서버를 설정하고 필요한 모든 파일을 생성했으므로,
위 폴더에 쓸 수 있는 권한과 개인 계정 키 및 CSR을 읽을 수 있는 권한으로
서버에서 이 스크립트를 실행하세요.


```
# Run the script on your server
python acme_tiny.py --account-key ./account.key --csr ./domain.csr --acme-dir /var/www/challenges/ > ./signed_chain.crt
```
### 5단계: 인증서 설치

이 스크립트가 출력하는 서명된 https 인증서 체인은
개인 키와 함께 https 서버를 실행하는 데 사용할 수 있습니다. 이를
웹 서버 설정의 https 설정에 포함시켜야 합니다. nginx 서버를
설정하는 방법의 예는 다음과 같습니다:


```nginx
server {
    listen 443 ssl;
    server_name yoursite.com www.yoursite.com;

    ssl_certificate /path/to/signed_chain.crt;
    ssl_certificate_key /path/to/domain.key;
    ssl_session_timeout 5m;
    ssl_protocols TLSv1.2;
    ssl_ciphers ECDHE-RSA-AES256-GCM-SHA384:ECDHE-RSA-AES128-GCM-SHA256:DHE-RSA-AES256-GCM-SHA384;
    ssl_session_cache shared:SSL:50m;
    ssl_dhparam /path/to/server.dhparam;
    ssl_prefer_server_ciphers on;

    ...the rest of your config
}

server {
    listen 80;
    server_name yoursite.com www.yoursite.com;

    location /.well-known/acme-challenge/ {
        alias /var/www/challenges/;
        try_files $uri =404;
    }

    ...the rest of your config
}
```
<translate-content>
### 6단계: 자동 갱신 크론잡 설정

축하합니다! 이제 귀하의 웹사이트가 https를 사용하고 있습니다! 불행히도, Let's Encrypt
인증서는 90일 동안만 유효하므로 자주 갱신해야 합니다. 걱정 마세요!
자동화되어 있습니다! 간단한 bash 스크립트를 작성하고 크론탭에 추가하세요 (아래의
예시 스크립트를 참조하세요).

`renew_cert.sh` 예시:</translate-content>
```sh
#!/usr/bin/sh
python /path/to/acme_tiny.py --account-key /path/to/account.key --csr /path/to/domain.csr --acme-dir /var/www/challenges/ > /path/to/signed_chain.crt.tmp || exit
mv /path/to/signed_chain.crt.tmp /path/to/signed_chain.crt
service nginx reload
```

```
# Example line in your crontab (runs once per month)
0 0 1 * * /path/to/renew_cert.sh 2>> /var/log/acme_tiny.log
```
**참고:** Let's Encrypt의 ACME v2 릴리스(acme-tiny 4.0.0 이상) 이후로, 중간
인증서는 발급된 인증서 다운로드에 포함되어 있으므로 더 이상
중간 인증서를 별도로 다운로드하여 서명된 인증서에 이어 붙일 필요가 없습니다.
만약 acme-tiny &lt;4.0 (예: 2018-03-17 이전) 버전과 함께 사용하는
쉘 스크립트나 Makefile이 있고, acme-tiny 4.0.0+를 사용한다면,
중간 인증서를 signed_chain.crt에 두 번 추가하고 있을 수 있습니다(이는
[최소한 GnuTLS 3.7.0에서 문제를 일으킵니다](https://gitlab.com/gnutls/gnutls/-/issues/1131)
그리고 인증서 크기가 불필요하게 커지는 원인이 됩니다). 이를 해결하려면,
중간 인증서를 다운로드하고 acme-tiny 인증서 출력에 추가하는 bash 코드를
그냥 제거하세요.

## 권한

이 스크립트를 설정하고 실행할 때 가장 많이 겪게 될 문제는 권한입니다.
계정 개인키와 챌린지 웹 폴더에 대한 접근을 최대한 제한하는 것이 좋습니다.
이 스크립트, 계정 개인키, 챌린지 폴더를 처리할 전용 사용자를 만드는 것을 권장합니다.
그 후, 그 사용자에게 설치된 인증서 파일(e.g. `/path/to/signed_chain.crt`)에 쓰기 권한과
웹서버 재시작 권한을 부여하세요. 이렇게 하면 크론 스크립트가
작동하여 기존 인증서를 덮어쓰고 웹서버를 재시작하지만 다른 작업은 할 수 없게 됩니다.

**반드시 해야 할 것:**
* 계정 개인키(e.g. `account.key`)를 백업하세요
* 이 스크립트가 도메인 개인키를 읽을 수 없게 하세요!
* 이 스크립트를 root 권한으로 실행하지 마세요!

## 스테이징 환경

Let's Encrypt는 새로운 설정을 스테이징 서버에서 테스트할 것을 권장합니다.
새 설정을 시험할 때는
`--directory-url https://acme-staging-v02.api.letsencrypt.org/directory`
를 사용하여 Let's Encrypt의 운영 서버 대신 가짜 테스트 인증서를 발급할 수 있습니다.
자세한 내용은 [https://letsencrypt.org/docs/staging-environment/](https://letsencrypt.org/docs/staging-environment/)
를 참조하세요.

## 피드백/기여

이 프로젝트는 매우 제한된 범위와 코드베이스를 가지고 있습니다. 버그 신고와
풀 리퀘스트는 환영하지만 새로운 기능 추가는 자제해 주세요.
이 스크립트는 200줄 미만의 코드로 유지되어야 하며, 쉽게 검토할 수 있어야 합니다.

자신의 환경에 맞게 기능을 추가하고 싶다면 얼마든지 하세요!
오픈소스이므로 자유롭게 포크하여 필요에 맞게 수정해도 됩니다.






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---