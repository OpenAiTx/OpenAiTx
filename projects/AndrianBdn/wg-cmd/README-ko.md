# WG Commander 

일명 "wg-cmd" — WireGuard 구성 파일 관리를 위한 TUI

<a href="https://github.com/andrianbdn/wg-cmd/releases/latest"><img src="https://img.shields.io/github/v/release/andrianbdn/wg-cmd" /></a>
<a href="./LICENSE"><img src="https://img.shields.io/github/license/andrianbdn/wg-cmd" /></a>
<a href="./go.mod"><img src="https://img.shields.io/github/go-mod/go-version/andrianbdn/wg-cmd" /></a>
[![Go Report Card](https://goreportcard.com/badge/github.com/andrianbdn/wg-cmd)](https://goreportcard.com/report/github.com/andrianbdn/wg-cmd)

![screenshot](https://user-images.githubusercontent.com/994900/218720566-e5b3ab22-d7fc-4df7-a777-ad9b6280ada8.png)

# 기능
- 브라우저나 HTTP 포트가 필요 없음 - 터미널에서 동작하며 SSH에서도 사용 가능
- 멋진 설치 마법사 제공
- 피어 관리를 위한 텍스트 기반 사용자 인터페이스
- 터미널에서 QR 코드 보기
- 클립보드로 구성 복사 (OSC 52)
- sysctl, systemd, NAT 자동 구성

## 현재 제한 사항
- 단순한 클라이언트-서버 WireGuard 설정만 지원
- 주로 Linux용 (iptables, systemd, sysctl 사용 가능해야 함) — [다른 OS](#other-os-besides-linux) 섹션 참조
- 기존 WireGuard 구성 관리 불가 (하지만 동일 호스트에서 새 WireGuard 인터페이스 생성 가능)

# 설치 

WireGuard와 iptables가 설치되어 있는지 확인하세요 
(Ubuntu / Debian에서는 `apt install wireguard-tools`, Rocky/Alma 9에서는 `dnf install wireguard-tools iptables`). 

curl로 다운로드하려면 다음 명령을 실행하세요:
```shell
# for x86_64 
curl -SL https://github.com/andrianbdn/wg-cmd/releases/download/v0.1.7/wg-cmd-0.1.7-linux-amd64 -o /usr/local/bin/wg-cmd

# for arm64 
curl -SL https://github.com/andrianbdn/wg-cmd/releases/download/v0.1.7/wg-cmd-0.1.7-linux-arm64 -o /usr/local/bin/wg-cmd
```
적절한 권한을 설정하고 도구를 실행하십시오:  

```
chmod 755 /usr/local/bin/wg-cmd
wg-cmd
```
만약 $PATH에 `/usr/local/bin`이 포함되어 있지 않다면  
전체 경로를 사용하여 `/usr/local/bin/wg-cmd` 명령어를 실행해야 합니다.  

WG Commander는 sysctl을 자동으로 조정하고, systemd 유닛을 생성하며, /etc/wireguard에 쓰기 위해 루트 권한이 필요합니다.  

# 사용법  

첫 실행 시 WG Commander는 설정 마법사를 표시하여 새로운 WireGuard 인터페이스를 대화형으로 구성할 수 있게 합니다.  

이후 실행에서는 (마법사가 성공적으로 완료되었다면) 관리 TUI만 표시됩니다.  

QR 코드에 대한 참고 사항: 일부 기기(Android?)는 더 높은 품질의 QR 코드를 요구할 수 있습니다. WG Commander는 터미널 창 해상도를 키울 때(글꼴을 작게, 창을 크게) 자동으로 품질을 향상시킵니다.  

## 고급 사용법  

권한을 변경하고 sysctl/systemd를 수동으로 구성하면 비루트 사용자로 WG Commander를 실행할 수 있습니다.  

WG Commander는 자체 UI 구성을 `~/.config/wg-cmd/wg-cmd.toml`에 저장합니다.  

가장 중요한 옵션은 다음과 같습니다:


```toml
WireguardDir = "/etc/wireguard"
# directory for WireGuard configuration files 

DatabaseDir = "/etc/wireguard"
# directory for WG Commander database files (wgc-<interface-name>)
```
이 옵션들은 사용자가 쓰기 권한이 있는 디렉터리를 가리키도록 변경할 수 있습니다.

### 특별 옵션 

새 인터페이스 구성을 시작하려면 `wg-cmd new`를 실행하세요.

특정 인터페이스로 전환하려면 `wg-cmd <wg-interface>`를 실행하세요 (사전에 wg-cmd로 생성되어 있어야 합니다).

UI를 표시하지 않고 Wireguard 구성을 생성하려면 `wg-cmd <wg-interface> make`를 실행하세요.

### 구성 

WG Commander는 디렉터리를 "데이터베이스"로 사용합니다.
인터페이스 구성은 /etc/wireguard/wgc-<interface-name> 디렉터리에 저장됩니다.

구성은 [TOML](https://toml.io) 파일 형식으로 저장됩니다.

대부분의 구성 키는 WireGuard의 것과 유사합니다.

#### 서버 구성 (0001-server.toml)
이 구성 파일의 일부 키는 실제로 클라이언트 구성 파일 생성에 사용됩니다.

`ClientRoute` - 클라이언트 구성의 AllowedIPs

`ClientDNS` - 모든 클라이언트의 DNS 구성 값

`ClientServerEndpoint` - 클라이언트 구성의 엔드포인트

`ClientPersistentKeepalive` - 클라이언트 구성의 PersistentKeepalive

`MTU` - 서버와 클라이언트의 MTU (0 — WireGuard가 선택)

#### 클라이언트 구성 (nnnn-%client%.toml)

`ClientRoute` - 서버 구성의 `ClientRoute`를 완전히 재정의

`AddServerRoute` - 서버 측 클라이언트의 AllowedIPs에 추가 네트워크를 더함 (서버를 통해 한 클라이언트의 트래픽을 다른 클라이언트 네트워크로 라우팅할 때 유용)



`MTU` - 이 클라이언트에 대해 서버 MTU를 다른 값으로 덮어씁니다. -1로 설정하면 이 WireGuard 클라이언트 구성에서 MTU가 생략됩니다.

`DNS` - 모든 클라이언트에 대해 서버 `ClientDNS` 설정을 덮어씁니다. 쉼표로 구분된 IP 목록을 지정하세요.  
`no` 또는 `none`으로 설정하면 이 WireGuard 클라이언트 구성에서 DNS가 생략됩니다.

클라이언트 구성 파일에는 `PrivateKey` 필드가 포함되어 있습니다.  
만약 이를 받아들일 수 없다면, 구성(또는 QR 코드)을 클라이언트로 내보낸 후 파일에서 제거할 수 있습니다.

### Linux 외 다른 OS

WG Commander는 procfs, systemd, iptables, sysctl을 사용하기 때문에 Linux에서 작동하도록 설계되었습니다.  
하지만 순수 Go로 작성되어 Go가 지원하는 모든 OS에서 작동해야 합니다.

- 직접 바이너리를 컴파일해야 합니다.  
- 시작 시 Linux 특정 검사를 비활성화하려면 환경 변수 `WG_CMD_NO_DEPS`를 1로 설정하세요.  
- 0001-server.toml 파일을 편집하여 PostUp4/PostUp6/PostDown4/PostDown6 필드에 OS 명령어를 설정하세요.  
- WireGuard 구성을 다시 로드해야 합니다: 변경 시 수동으로 하거나  
/etc/wireguard/wg*.conf 파일 변경을 모니터링하여 WireGuard를 자동으로 다시 로드하세요.

다른 OS 지원 추가를 위한 PR을 환영합니다.

### Docker에서 실행

가능하긴 하지만 WG Commander를 Docker에서 실행하는 것은 권장하지 않습니다.

설치 마법자가 제대로 작동하지 않습니다. systemd 유닛을 생성하고 sysctl을 수정해야 하기 때문입니다.

### 제거

WG Commander를 제거하려면 /usr/local/bin/wg-cmd에서 바이너리를 삭제하세요.  
또한 /etc/wireguard/wgc-* 디렉터리와 ~/.config/wg-cmd도 삭제할 수 있습니다.

systemd 유닛을 생성했다면 수동으로 제거해야 합니다.

아래는 WG Commander가 관리하는 wg7 인터페이스를 제거하는 예시입니다.  
(삭제할 인터페이스 이름으로 변경하세요):




```sh
systemctl stop wgc-wg7.{path,service}
systemctl disable wgc-wg7.{path,service}
rm /etc/systemd/system/wgc-wg7.{path,service}
systemctl stop wg-quick@wg7.service
systemctl disable wg-quick@wg7.service
rm /etc/wireguard/wg7.conf
rm -Rf /etc/wireguard/wgc-wg7
```

# 테스트 완료  
WG Commander는 WireGuard, iptables, sysctl, procfs가 사용 가능한 systemd 기반 Linux 배포판에서 잘 작동해야 합니다.

다음 환경에서 테스트되었습니다:  
- Ubuntu 24.04 (v0.1.7, 2026년 4월 9일 테스트)  
- Ubuntu 20.04  
- Ubuntu 22.04  
- Rocky Linux 9  
- Debian 11  
- Debian 12  

# 기여하기  

기여를 환영합니다. 가이드라인과 AI 공개 정책을 포함한 자세한 내용은 [CONTRIBUTING.md](https://raw.githubusercontent.com/AndrianBdn/wg-cmd/main/CONTRIBUTING.md)를 참조하십시오.

# 참고  
WG Commander는 상업적 목적이 없습니다.  
이 프로젝트는  
[MIT 라이선스](https://github.com/andrianbdn/wg-cmd/blob/master/LICENSE) 하에 라이선스가 부여되었습니다.

이 프로젝트는 WireGuard®의 창작자와 관련이 없습니다.  
WG Commander 프로젝트는 WireGuard®나 WireGuard® 커뮤니티와 승인, 후원, 또는 제휴되어 있지 않습니다.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---