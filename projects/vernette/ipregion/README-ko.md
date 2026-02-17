# ipregion

![image](https://i.imgur.com/CRxBuVR.gif)

## 사용법

### 다운로드 및 로컬 실행

```bash
wget -O ipregion.sh https://ipregion.vrnt.xyz
chmod +x ipregion.sh
```

### GitHub에서 직접 실행하기

```bash
bash <(wget -qO- https://ipregion.vrnt.xyz)
```

### 도커

#### IPv4용 컨테이너 실행 (기본 Docker 브리지 네트워크)

이는 호스트 네트워크 모드 없이 IPv4만 사용하여 IP 지리 위치 확인을 실행합니다:

```bash
docker run --rm vernette/ipregion:latest
```
필요에 따라 추가 스크립트 옵션을 덧붙일 수 있습니다, 예를 들어:


```
docker run --rm vernette/ipregion:latest --group geoip
```

#### 호스트 네트워킹으로 컨테이너 실행 (IPv4 및 IPv6 또는 사용자 지정 인터페이스용)

호스트의 실제 네트워크 인터페이스에서 IPv4와 IPv6 모두에 접근하거나 사용자 지정 네트워크 인터페이스(e.g., eth1)를 지정하려면 Docker 호스트 네트워크 모드를 사용하세요:

```bash
docker run --rm --network=host vernette/ipregion:latest
```

```bash
docker run --rm --network=host vernette/ipregion:latest --interface eth1
```

> [!NOTE]
> `--network=host`를 사용할 경우, 컨테이너가 호스트 네트워크 스택을 공유하여 네트워크 격리가 줄어들지만 인터페이스에 대한 완전한 접근이 가능해집니다. `--network=host`를 사용하지 않으면, 컨테이너는 Docker 브리지 네트워크를 사용하며 IPv6 노출이나 인터페이스 선택이 제한될 수 있습니다.

## 기능

- 여러 GeoIP API 및 웹 서비스 지원 (YouTube, Netflix, ChatGPT, Spotify 등)
- SOCKS5 프록시 및 사용자 지정 네트워크 인터페이스를 통한 IPv4/IPv6 지원
- JSON 출력 및 색상 구분 테이블

## 의존성

- bash
- curl
- jq
- util-linux/bsdmainutils

## 주요 옵션

```bash
./ipregion.sh --help # Show all options
./ipregion.sh --group primary # GeoIP services only
./ipregion.sh --group custom # Popular websites only
./ipregion.sh --ipv4 # IPv4 only
./ipregion.sh --ipv6 # IPv6 only
./ipregion.sh --proxy 127.0.0.1:1080 # Use SOCKS5 proxy
./ipregion.sh --json # JSON output
./ipregion.sh --debug # Debug mode
```
모든 옵션은 조합하여 사용할 수 있습니다.

## 국가 코드

스크립트는 국가 코드를 ISO 3166-1 alpha-2 형식(예: RU, US, DE)으로 출력합니다.

공식 ISO 웹사이트에서 모든 국가 코드의 의미를 조회할 수 있습니다: [https://www.iso.org/obp/ui/#search/code/](https://www.iso.org/obp/ui/#search/code/)

검색 창에 코드를 입력하면 전체 국가 이름을 확인할 수 있습니다.

## 기여하기

기여를 환영합니다! 새로운 서비스를 추가하거나 스크립트 기능을 개선하는 풀 리퀘스트를 자유롭게 제출하세요.

![별 히스토리 차트](https://api.star-history.com/svg?repos=vernette/ipregion&type=Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---