# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy`는 `Rust`로 구현된 `http/https` 프록시, `socks5` 프록시, 리버스 프록시, 로드 밸런싱, 정적 파일 서버, `websocket` 프록시, 4계층 TCP/UDP 포워딩, 내부망 터널링 등을 지원합니다.

## 📦 설치 & 🏃 사용법

### 설치

```bash
cargo install wmproxy
```

또는

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### 사용법
기본 포트는 8090, 기본 리스닝 주소는 127.0.0.1입니다.
```bash
# 기본 파라미터로 바로 실행
wmproxy proxy

# 계정과 비밀번호 설정
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# 기타 명령어
wmproxy --help

# 설정 파일로 실행
wmproxy config -c config/client.toml
```

##### 2단계 프록시 실행
1. 로컬에서 프록시 실행
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
또는
```bash
wmproxy config -c config/client.toml
```
설정 파일 예시는 다음과 같습니다:
```toml
[proxy]
# 서버 주소
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# 서버 연결 시 암호화 여부
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# 내부망 매핑 설정 배열

  # localhost 도메인을 127.0.0.1:8080으로 포워딩
[[proxy.mappings]]
name = "web"
mode = "http"
local_addr = "127.0.0.1:8080"
domain = "localhost"

headers = [
  "proxy x-forward-for {client_ip}",
  "proxy + from $url",
  "+ last-modified 'from proxy'",
  "- etag",
]

# tcp 트래픽을 무조건 127.0.0.1:8080으로 포워딩
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

순수 포워딩이기 때문에 현재 노드에서 계정/비밀번호 설정은 의미가 없습니다. `-S`는 연결할 2단계 프록시 주소를 나타내며, **이 파라미터가 있으면 중계 프록시, 없으면 최종 프록시입니다.** ```--ts```는 상위 프록시로 연결 시 암호화 연결을 사용함을 의미합니다.

2. 원격에서 프록시 실행
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
또는
```bash
wmproxy config -c config/server.toml
```
설정 파일 예시는 다음과 같습니다:
```toml
[proxy]
# 바인딩 IP 주소
bind_addr = "127.0.0.1:8091"

# 지원하는 프록시 기능, 1은 http, 2는 https, 4는 socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# 내부망 매핑 http 바인딩 주소
map_http_bind = "127.0.0.1:8001"
# 내부망 매핑 tcp 바인딩 주소
map_tcp_bind = "127.0.0.1:8002"
# 내부망 매핑 https 바인딩 주소
map_https_bind = "127.0.0.1:8003"
# 내부망 매핑 공개키 인증서, 비워두면 기본 인증서 사용
# map_cert = 
# 내부망 매핑 개인키 인증서, 비워두면 기본 인증서 사용
# map_key =
# 양방향 인증
two_way_tls = true
# 클라이언트가 암호화 클라이언트인지 여부
tc = true
# 서비스 모드, server는 서버, client는 클라이언트
mode = "server"
```

```--tc```는 하위 프록시를 받을 때 암호화 연결을 사용함을 의미합니다. ```--cert```로 인증서의 공개키를, ```--key```로 인증서의 개인키를, ```--domain```으로 인증서 도메인을 지정할 수 있습니다. 지정하지 않으면 기본 제공 인증서를 사용합니다.
> 이렇게 프록시를 통해 접근하면 실제 요청 주소를 알 수 없고, 프록시가 보낸 요청만 확인할 수 있습니다.

### 프록시 간 인증
> 현재 두 가지 인증 방식을 제공합니다. ```two_way_tls```를 활성화하면 클라이언트 인증서 인증이 켜집니다. 또 다른 방식은 서버에 ```username```과 ```password```를 설정하면 클라이언트도 동일한 계정 정보를 입력해야 인증이 활성화됩니다. 두 방식은 함께 또는 개별적으로 사용할 수 있습니다.
> 설정 예시는 아래와 같습니다:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 로드맵
### socks5

- [x] IPV6 지원
- [x] `SOCKS5` 인증 방식
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] `SOCKS5` 명령어
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] IPV6 지원

### 내부망 터널링

- [x] Http 지원
- [x] Https 지원
- [x] Tcp 지원

### 리버스 프록시

- [x] 정적 파일 서버
- [x] 수동 헬스 체크
- [x] 능동 헬스 체크
- [x] 설정 핫 로드
- [x] 로드 밸런싱
- [x] 4계층 TCP 로드
- [x] 4계층 UDP 로드
- [x] 트래픽 제어
- [x] websocket 포워딩

### 기본 기능
- [x] 로그

#### 확장 기능

- [x] 요청 속도 제한(limit_req)
- [x] HTTP 요청 Header 수정
- [x] HTTP2 내부망 터널링 지원
- [x] 마이크로 컨트롤
- [x] try_paths
- [x] tcp를 websocket으로 변환
- [x] websocket을 tcp로 변환


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---