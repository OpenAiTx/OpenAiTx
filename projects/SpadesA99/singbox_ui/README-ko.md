# Sing-box UI

**[English](https://raw.githubusercontent.com/SpadesA99/singbox_ui/main/README_EN.md) | 中文**

<div align="center">

[![Docker Image](https://img.shields.io/badge/ghcr.io-singbox__ui-blue?logo=docker)](https://github.com/SpadesA99/singbox_ui/pkgs/container/singbox_ui)
[![Build Status](https://github.com/SpadesA99/singbox_ui/actions/workflows/docker-build.yml/badge.svg)](https://github.com/SpadesA99/singbox_ui/actions)
[![GitHub Stars](https://img.shields.io/github/stars/SpadesA99/singbox_ui?style=flat&logo=github)](https://github.com/SpadesA99/singbox_ui/stargazers)
[![License](https://img.shields.io/github/license/SpadesA99/singbox_ui)](LICENSE)

**현대적인 sing-box 구성 관리 도구**

Go 1.24 + Next.js 16 기반으로 구축되었으며, Docker 컨테이너로 sing-box를 관리합니다

</div>

![Sing-box UI 인터페이스 스크린샷](https://raw.githubusercontent.com/SpadesA99/singbox_ui/main/docs/zh.png)

---

## 핵심 기능

### 프로토콜 지원

| 인바운드 프로토콜 | 아웃바운드 프로토콜 | 구독 파싱 |
|---------|---------|---------|
| WireGuard | 모든 인바운드 프로토콜 | VMess |
| Mixed (Socks5+HTTP) | direct (직접 연결) | VLESS |
| VLESS | block (차단) | Trojan |
| VMess | | Shadowsocks |
| Trojan | | AnyTLS |
| Shadowsocks | | Clash YAML 형식 |
| Hysteria2 | | |
| TUIC | | |
| Naive | | |
| ShadowTLS | | |
| AnyTLS | | |
| HTTP | | |

### TLS 인증서 관리

- **ACME 자동 인증서**: Let's Encrypt 자동 신청 및 갱신 지원  
- **수동 인증서**: 자체 인증서 파일 업로드 지원  
- **다중 프로토콜 지원**: VLESS, VMess, Trojan, Hysteria2 등 TLS 프로토콜 모두 ACME 지원  

### 라우팅 규칙 구성

- **빠른 템플릿**: 자주 사용하는 규칙 원클릭 활성화(광고 차단, 중국 IP/도메인 직통, 사설 IP 직통)  
- **빠른 규칙 추가**: IP 또는 도메인을 직통/프록시/차단 목록에 빠르게 추가 지원  
- **직통 모드**: 프록시 없는 아웃바운드 시 자동으로 직통 모드 구성  

### 부하 분산

- **URLTest 모드**: sing-box `urltest` 아웃바운드 기반, 최저 지연 노드 자동 선택  
- **조정 가능한 허용오차**: 지연 허용오차 값 커스터마이징(기본 50ms), 잦은 전환 방지  
- **동적 노드 풀**: 구독에서 유연하게 여러 노드를 선택해 부하 분산 그룹 구성  
- **스마트 라우팅**: 자동 라우팅 규칙 생성으로 트래픽 스마트 분산 실현  

### 다중 인스턴스 관리

- 여러 명명된 sing-box 인스턴스 생성 지원  
- 각 인스턴스 독립 구성, 시작 및 중지 가능  
- 독립 컨테이너 로그 및 상태 모니터링  

### WireGuard VPN 관리

- Curve25519 키 생성  
- IP 바인딩 키 캐싱  
- 클라이언트 구성 관리(대량 생성, QR 코드, 구성 다운로드)  

### Cloudflare WARP 아웃바운드

- **원클릭 등록**: Curve25519 키 쌍 자동 생성 및 Cloudflare 등록 API 호출, 장치 토큰 로컬 캐시, 수동 구성 불필요  
- **WARP+ 바인딩**: 라이선스 입력으로 WARP+ 계정 바인딩 지원, 무제한 트래픽 획득  
- **엔드포인트 최적화**: 실제 WireGuard 핸드셰이크 탐지 — 후보 `IP:Port`에 WG 초기 패킷 전송, 92바이트 `MessageResponse` 수신 검증, 패킷 손실률 + 평균 RTT 기준 정렬, UDP 경로 품질 정확 반영(참고 [CloudflareWarpSpeedTest](https://github.com/peanut996/CloudflareWarpSpeedTest) 구현)  
- **광범위 스캔**: 8개 Cloudflare /24 구간 × 54개 알려진 WARP UDP 포트, 동시 탐색 및 샘플링 섞기, 가장 빠른 엣지 노드 신속 탐색  

### 노드 상태 탐지

- 비동기 다중 노드 동시 탐지  
- 성공률 슬라이딩 윈도우 통계  
- API 폴링을 통한 탐지 결과 획득  

### 관리 기능  

- 구성 미리보기 (JSON 편집기)  
- 컨테이너 로그 보기  
- 컨테이너 상태 모니터링  

---  

## 빠른 시작  

### Docker Compose (권장)  

`docker-compose.yml` 생성:

```yaml
services:
  singbox-ui:
    image: ghcr.io/spadesa99/singbox_ui:latest
    container_name: singbox-ui
    restart: unless-stopped
    network_mode: host
    volumes:
      - /var/run/docker.sock:/var/run/docker.sock
      - ./data:/home/data
    environment:
      - DATA_DIR=/home/data
      - HOST_DATA_DIR=${PWD}/data
      - LISTEN_ADDR=127.0.0.1:7000
      - TZ=Asia/Shanghai
```

```bash
docker compose up -d
```
http://127.0.0.1:7000 접속

> **설명**:
> - 컨테이너가 호스트 네트워크를 직접 사용하도록 `network_mode: host` 사용
> - 기본적으로 `127.0.0.1:7000` 에서만 수신, 로컬 접근만 가능하며 `LISTEN_ADDR` 환경변수로 사용자 지정 가능
> - sing-box 컨테이너 관리를 위해 Docker Socket 마운트
> - `${PWD}` 를 통해 `HOST_DATA_DIR` 호스트 데이터 디렉토리를 자동 매핑하여 sing-box 컨테이너 마운트에 사용
> - 내장된 sing-box v1.13.5 이미지, 최초 실행 시 자동 로드, 네트워크 연결 없이 사용 가능

### 원격 접근

서비스는 기본적으로 `127.0.0.1` 에서만 수신하며, SSH 터널을 통한 안전한 접근을 권장:


```bash
ssh -L 7000:127.0.0.1:7000 user@your-server
```
그런 다음 로컬 브라우저에서 http://127.0.0.1:7000 에 접속합니다.

> **보안 안내**: `LISTEN_ADDR`를 `0.0.0.0:7000`으로 변경하여 공용 네트워크에 직접 노출하는 것은 권장하지 않습니다. 관리 패널에 인증 보호가 없습니다. 외부 네트워크 접속이 필요한 경우 SSH 터널 또는 인증이 포함된 리버스 프록시(예: Nginx + Basic Auth)를 사용하세요.

---

## 환경 변수

| 변수 | 설명 | 기본값 |
|------|------|--------|
| `DATA_DIR` | 컨테이너 내 데이터 디렉터리 | `/home/data` |
| `HOST_DATA_DIR` | 호스트 데이터 디렉터리(싱박스 컨테이너 마운트용) | `${PWD}/data` |
| `LISTEN_ADDR` | 서비스 수신 주소 | `127.0.0.1:7000` |
| `TZ` | 시간대 | `Asia/Shanghai` |

---

## 기술 스택

| 프론트엔드 | 백엔드 |
|------|------|
| Next.js 16 | Go 1.24 |
| React 19 | Gin 1.11 |
| Tailwind CSS | Docker SDK |
| shadcn/ui | |

---

## 라이선스

[MIT License](LICENSE)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=SpadesA99/singbox_ui&type=Date)](https://star-history.com/#SpadesA99/singbox_ui&Date)

## 감사의 글

- [sing-box](https://github.com/SagerNet/sing-box)

- [Next.js](https://nextjs.org/)
- [Gin](https://github.com/gin-gonic/gin)
- [shadcn/ui](https://ui.shadcn.com/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-25

---