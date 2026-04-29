# Amnezia-WG 2.0 (v1.88.2+)와 함께하는 Tailscale

[![GitHub Release](https://img.shields.io/github/v/release/LiuTangLei/tailscale)](https://github.com/LiuTangLei/tailscale/releases/latest)
[![Platform Support](https://img.shields.io/badge/platform-Linux%20|%20macOS%20|%20Windows%20|%20OpenWrt%20|%20Android-blue)](https://github.com/LiuTangLei/tailscale/releases/latest)
[![License](https://img.shields.io/badge/license-BSD--3--Clause-green)](LICENSE)

Amnezia-WG 2.0 난독화 기능이 추가된 향상된 Tailscale 클라이언트: 잡음 트래픽, 프로토콜 서명, 핸드셰이크/헤더 위장으로 DPI 및 차단에 대응합니다. AWG 설정을 활성화하기 전까지는 표준 Tailscale처럼 동작합니다.

언어: [영어](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/README.md) | [中文](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-zh.md) | [فارسی](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-fa.md) | [Русский](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-ru.md)

AWG v1.5 문서는 [doc/README-awg-v1.5.md](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-awg-v1.5.md)를 참조하세요.

## 설치

| 플랫폼 | 명령 / 동작 |
| --- | --- |
| Linux | `curl -fsSL https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-linux.sh \| bash` |
| macOS* | `curl -fsSL https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-macos.sh \| bash` |
| Windows (관리자 PowerShell) | `iwr -useb https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-windows.ps1 \| iex` |
| OpenWrt | [OpenWrt 설치](#openwrt-installation) 참조 |
| Android | [릴리즈](https://github.com/LiuTangLei/tailscale-android/releases)에서 APK 다운로드 |

- macOS: 설치 프로그램은 CLI 전용 `tailscaled`를 사용합니다. 공식 Tailscale.app이 감지되면 충돌 방지를 위해 제거하라는 메시지가 표시됩니다.
- Android는 현재 AWG 설정 동기화만 지원합니다. 앱 내의 동기화 버튼을 사용하세요.

![Android AWG Sync Example](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/sync1.jpg)

## Docker Compose

이 저장소에는 AWG 지원과 함께 `tailscaled`를 실행하기 위한 `docker-compose.yml`이 포함되어 있습니다.

- 상태는 compose 파일 옆의 `./tailscale-state`에 저장되므로 노드 상태와 AWG 설정이 컨테이너 재시작 및 호스트 재부팅 시에도 유지됩니다.
- 이전에 바인드 마운트 `/var/lib/tailscale:/var/lib/tailscale`을 사용 중이었다면 기존 상태를 먼저 복사하세요:

```bash
docker compose down
cp -a /var/lib/tailscale ./tailscale-state
# update docker-compose.yml
docker compose up -d
```
기본 흐름:

1. 서비스를 시작합니다: `docker compose up -d`
2. 컨테이너 내부에서 인증합니다: `docker compose exec tailscaled tailscale up`
3. AWG 명령어를 동일하게 실행합니다, 예를 들어: `docker compose exec tailscaled tailscale awg sync`

Headscale을 사용하는 경우, `tailscale up`에 `--login-server https://your-headscale-domain`을 추가하세요.

선택적 호스트 별칭:


```bash
alias tailscale='docker exec -it tailscaled tailscale'
```

그 별칭은 현재 쉘에만 적용됩니다. 재부팅이나 새 터미널 세션 이후에도 유지하려면 `~/.bashrc` 또는 `~/.zshrc`에 추가하고 쉘을 다시 로드하세요.

## OpenWrt 설치

기본 명령:

```bash
wget -O /usr/bin/install.sh https://raw.githubusercontent.com/LiuTangLei/openwrt-tailscale-awg/main/install_en.sh && chmod +x /usr/bin/install.sh && /usr/bin/install.sh
```
제한된 GitHub 접근 권한이 있는 지역을 위한 미러 명령어:


```bash
wget -O /usr/bin/install.sh https://ghfast.top/https://raw.githubusercontent.com/LiuTangLei/openwrt-tailscale-awg/main/install.sh && chmod +x /usr/bin/install.sh && /usr/bin/install.sh
```
이 스크립트는 [GuNanOvO/openwrt-tailscale](https://github.com/GuNanOvO/openwrt-tailscale)에서 포크되었습니다.

## 미러

GitHub이 느리거나 차단된 경우, `https://your-mirror-site.com`과 같은 프리픽스 미러를 자체 호스팅할 수 있습니다:


```bash
# Linux
curl -fsSL https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-linux.sh | bash -s -- --mirror https://your-mirror-site.com

# macOS
curl -fsSL https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-macos.sh | bash -s -- --mirror https://your-mirror-site.com
```

```powershell
# Windows
$scriptContent = (iwr -useb https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-windows.ps1).Content; $scriptBlock = [scriptblock]::Create($scriptContent); & $scriptBlock -MirrorPrefix 'https://your-mirror-site.com/'
```
PowerShell이 실행을 차단하는 경우 `Set-ExecutionPolicy RemoteSigned` 또는 `Bypass -Scope Process`를 사용하십시오.

## 빠른 시작

팁: `tailscale amnezia-wg`는 `tailscale awg`와 동일합니다.

1. 로그인:


```bash
# Official control server
tailscale up

# Headscale
tailscale up --login-server https://your-headscale-domain
```

2. AWG 구성:

```bash
tailscale awg set
```
자동 생성 프롬프트에서 Enter 키를 눌러 `i1`-`i5`를 제외한 모든 항목에 대한 권장 값을 생성합니다.

3. 다른 장치에서, 이미 구성된 노드에서 동일한 AWG 구성을 동기화합니다:

- 데스크톱: 다른 장치에서 `tailscale awg sync`를 실행합니다
- 안드로이드: 다른 장치의 앱에서 동기화(Sync)를 탭합니다

4. 필요에 따라 확인하거나 재설정합니다:


```bash
tailscale awg get
tailscale awg reset
```
## 구성 프리셋

| 목표 | 예시 | 호환성 |
| --- | --- | --- |
| 기본 정크 트래픽 | `tailscale awg set '{"jc":4,"jmin":64,"jmax":256}'` | 표준 Tailscale 피어와 작동 |
| 정크 트래픽 + 서명 | `tailscale awg set '{"jc":2,"jmin":64,"jmax":128,"i1":"<b 0x40><r 12>"}'` | 표준 Tailscale 피어와 작동 |
| 핸드셰이크 가장 | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0}'` | 모든 AWG 노드가 동일한 `s1`-`s4` 사용 |
| 전체 가장 | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0,"h1":{"min":100000,"max":200000},"h2":{"min":300000,"max":350000},"h3":{"min":400000,"max":450000},"h4":{"min":500000,"max":550000}}'` | 모든 AWG 노드가 동일한 `s1`-`s4` 및 `h1`-`h4` 사용 |
| 전체 가장 + 서명 | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0,"h1":{"min":100000,"max":200000},"h2":{"min":300000,"max":350000},"h3":{"min":400000,"max":450000},"h4":{"min":500000,"max":550000},"i1":"<b 0xc0><r 32><c><t>"}'` | `i1`-`i5`는 노드별로 다를 수 있음; `s1`-`s4` 및 `h1`-`h4`는 일치해야 함 |

## 매개변수 참조

- `jc`와 `jmin`, `jmax`: 정크 패킷 수와 크기 범위.
- `i1`-`i5`: 선택적 CPS(사용자 정의 프로토콜 서명) 체인으로, 맞춤 프로토콜 흉내내기 패킷에 사용.
- `s1`-`s4`: 핸드셰이크 패딩 또는 접두사 필드; 모든 AWG 노드가 일치해야 함.
- `h1`-`h4`: `{"min": 낮은값, "max": 높은값}` 형식의 헤더 필드 범위; 네 개 모두 설정하거나 하나도 설정하지 않아야 함. 범위는 겹치면 안 되며, 모든 AWG 노드가 일치해야 함.

매우 큰 정크 수나 긴 서명 체인은 지연과 대역폭 사용량을 증가시킴.

## 플랫폼 지원

| 플랫폼 | 아키텍처 | 상태 |
| --- | --- | --- |
| Linux | x86_64, ARM64 | ✅ 전체 지원 |
| macOS | 인텔, 애플 실리콘 | ✅ 전체 지원 |
| Windows | x86_64, ARM64 | ✅ 설치 프로그램 |
| OpenWrt | 다양 | ✅ 스크립트 |
| Android | ARM64, ARM | ✅ APK (동기화 전용 AWG) |

## 고급: CPS 프로토콜 서명

CPS는 사용자 정의 프로토콜 서명(Custom Protocol Signature)을 의미합니다. 임의 프로토콜 헤더를 흉내 낼 수 있는 맞춤 난독화 패킷을 조립할 수 있으며, 특정 프로토콜에 국한되지 않습니다.

CPS 형식:


```text
i{n} = <tag1><tag2>...<tagN>
```
태그:

- `<b 0xHEX>`: 정적 바이트
- `<r N>`: 보안 랜덤 바이트
- `<c>`: 카운터
- `<t>`: 타임스탬프

예시:


```text
i1 = <b 0xf6ab3267fa><c><b 0xf6ab><t><r 10>
```
`i1`가 설정되지 않은 경우, `i2`-`i5`는 건너뜁니다.

## 문제 해결

설치 확인:


```bash
tailscale version
tailscale awg get
```

연결이 끊기면 표준 WireGuard로 재설정하고 간단한 프리셋부터 시작하세요:

```bash
tailscale awg reset
tailscale awg set '{"jc":2,"jmin":64,"jmax":128}'
sudo journalctl -u tailscaled -f
```

Windows PowerShell에서는 JSON 이스케이프 문제를 피하기 위해 대화형 설정을 선호합니다:

```powershell
tailscale awg set
```

## 링크 및 지원

- 릴리스: <https://github.com/LiuTangLei/tailscale/releases>
- 안드로이드 APK: <https://github.com/LiuTangLei/tailscale-android/releases>
- 설치 프로그램 문제: <https://github.com/LiuTangLei/tailscale-awg-installer/issues>
- Amnezia-WG 문서: <https://docs.amnezia.org/documentation/instructions/new-amneziawg-selfhosted/#how-to-extract-a-protocol-signature-for-amneziawg-manually>

## 라이선스

BSD 3조항 라이선스, 업스트림 Tailscale과 동일합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-29

---