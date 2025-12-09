# HDD 팬 제어

[![CI 상태](https://img.shields.io/github/actions/workflow/status/desbma/hddfancontrol/ci.yml)](https://github.com/desbma/hddfancontrol/actions)
[![crates.io 버전](https://img.shields.io/crates/v/hddfancontrol)](https://crates.io/crates/hddfancontrol)
[![AUR 버전](https://img.shields.io/aur/version/hddfancontrol.svg?style=flat)](https://aur.archlinux.org/packages/hddfancontrol/)
[![라이선스](https://img.shields.io/github/license/desbma/hddfancontrol.svg?style=flat)](https://github.com/desbma/hddfancontrol/blob/master/LICENSE)

---

버전 2.0부터 이 도구는 Rust로 다시 작성되었습니다. 이전 Python 버전은 [v1 브랜치](https://github.com/desbma/hddfancontrol/tree/v1)에서 찾을 수 있습니다. 마이그레이션에 대해서는 [v1.x에서 마이그레이션](#migrating-from-v1x)을 참조하세요.

---

HDD 팬 제어는 Linux에서 하드 드라이브 온도에 따라 팬 속도를 동적으로 제어하는 명령줄 도구입니다.

이것은 3가지 이점이 있습니다:

- 하드 드라이브를 이상적인 온도 범위 내에서 유지하여 최대 수명을 확보하고 과열을 방지할 수 있습니다.

팬이 필요하지 않을 때 속도를 늦추거나 정지하기 때문에:

- 팬에서 발생하는 소음을 최소화합니다.
- 동시에 전력 소비를 최소화합니다.

## 목차

- [언제 유용한가요?](#when-is-this-useful)
- [기능](#features)
- [사전 요구사항](#prerequisites)
- [설치](#installation)
  - [배포판 패키지](#distribution-packages)
  - [소스에서 설치](#from-source)
- [설정](#configuration)
  - [주의 사항](#a-word-of-caution)
  - [팬 설정](#fan-configuration)
- [변경 로그](#changelog)
  - [v1.x에서 마이그레이션](#migrating-from-v1x)
- [명령줄 사용법](#command-line-usage)
- [systemd 서비스](#systemd-service)
- [라이선스](#license)
## 언제 유용한가요?

HDD 팬 제어는 하나 이상의 하드 드라이브 근처에 하나 이상의 팬이 있고, 팬 속도를 메인보드에 맡기지 않으려 할 때 유용합니다. 메인보드는 팬 속도를 정적으로 제어하거나 실제 드라이브 온도와 관련 없는 온도 센서(예: CPU 또는 메인보드 내 다른 위치)를 사용해 제어하기 때문입니다.

이상적인 사용 사례는 여러 하드 드라이브가 있는 NAS, 팬이 없는 저전력 CPU(예: ARM 또는 Intel Atom)와 하드 드라이브 근처에 팬이 있는 섀시입니다. 이 경우 CPU가 하드 드라이브보다 적은 열을 발생시키므로 주요 열원에 따라 팬 속도를 제어하는 것이 합리적입니다.

## 기능

- 한 번의 호출로 여러 팬 및/또는 여러 드라이브 제어 가능
- 6가지 온도 조회 방법 지원:
  - `hddtemp` 호출
  - `hddtemp` 데몬 쿼리
  - `hdparm` 호출
  - `smartctl` 호출 (SCT)
  - `smartctl` 호출 (SMART 속성)
  - `drivetemp` 네이티브 커널 hwmon
- 다양한 팬 특성에 적응 가능
- 필요에 따라 맞춤 설정 가능:
  - 팬을 멈추거나 지정 온도에서 최대 속도로 운전
  - 팬 속도를 특정 최소값 아래로 설정하지 않음(팬 제어 대상 팬이 섀시 내 유일한 팬일 경우 유용)
- 선택적으로 CPU 온도도 모니터링하고 팬 속도를 이에 맞게 제어 가능

## 전제 조건

- 리눅스 배포판
- 최소 하나 이상의 SATA/SAS\* 하드 드라이브, 다음 기능 지원:
  - 온도 조회
  - 전원 상태 조회
- OS에 팬 속도 제어 PWM 제공하는 메인보드
- OS에 팬 속도 조회 센서 제공하는 메인보드

대부분의 메인보드와 SATA 드라이브는 이 요구사항을 충족합니다.

\* `hddfancontrol`이 SAS 드라이브와 잘 작동한다는 보고가 여러 번 있었으나 SATA보다 테스트가 적게 되었습니다.

## 설치

### 배포판 패키지


일부 리눅스 배포판은 저장소에서 hddfancontrol 패키지를 제공합니다:

- Alpine Linux (테스팅): [hddfancontrol](https://pkgs.alpinelinux.org/package/edge/testing/x86_64/hddfancontrol)
- Arch Linux (AUR): [hddfancontrol](https://aur.archlinux.org/packages/hddfancontrol/)
- Fedora: [hddfancontrol](https://packages.fedoraproject.org/pkgs/hddfancontrol/hddfancontrol/)

각 태그 버전에 대해 빌드된 다른 패키지/바이너리는 [GitHub 릴리스](https://github.com/desbma/hddfancontrol/releases)를 참조하세요.

### 소스에서 빌드

[rustup](https://rustup.rs/)과 같은 Rust 빌드 환경이 필요합니다.

현재 저장소에서 다음을 실행하세요:


```
cargo build --release
install -Dm 755 -t /usr/local/bin target/release/hddfancontrol
```
또한 [hdparm](http://sourceforge.net/projects/hdparm/), [smartctl](https://www.smartmontools.org/), [sdparm](https://sg.danny.cz/sg/sdparm.html) (SAS 드라이브 지원용), 선택적으로 [hddtemp](http://www.guzu.net/linux/hddtemp.php)를 설치하십시오.  
최신 우분투 및 기타 데비안 계열에서는: `sudo apt install hdparm sdparm smartmontools`.  

데몬을 쉽게 관리하려면 [systemd 서비스](#systemd-service)를 참조하십시오.  

### [`crates.io`](https://crates.io/)에서부터


```
sudo cargo install --root /usr/local
```
## 구성

### 주의 사항

기본 매개변수는 온도가 50°C 이상일 때 팬을 100% 속도로 작동시키고, 30°C 미만일 때는 20% 속도로 작동시키며, 이는 일반적으로 권장되는 드라이브 작동 온도에 해당합니다. 시스템 내에 상당한 열을 발생시키는 다른 구성 요소가 없고, 시스템을 냉각할 다른 팬이 있거나, 수동 냉각에 최적화된 케이스를 사용하는 경우 최소 속도를 0%로 설정할 수 있으며, 이 경우 온도가 최소 임계값 이하일 때 팬이 정지합니다.

**이 도구를 잘못 구성하면 시스템을 적절히 냉각하지 못해 구성 요소가 손상되거나 수명이 단축될 수 있음을 유의하세요.**

장시간 무감독으로 HDD 팬 제어를 사용하기 전에 안전을 위해 최소 팬 속도를 유지하고, 시스템 온도가 예상 범위 내에 있는지 확인하는 것을 권장합니다.

### 팬 구성

`--pwm` 매개변수의 시작/정지 값을 얻으려면 다음 중 하나를 사용할 수 있습니다:

- `pwm-test` 명령어(`hddfancontrol pwm-test ...`)를 사용하여 팬이 시작하고 정지하는 값을 감지하는 테스트를 실행합니다. 단, 사전에 PWM 파일(`--pwm` 매개변수)을 식별해야 합니다.
- [pwmconfig 도구](http://www.lm-sensors.org/wiki/man/pwmconfig)를 사용합니다.

## 변경 로그

초기 버전 2 이후 모든 변경 사항은 [상세 변경 로그](https://raw.githubusercontent.com/desbma/hddfancontrol/master/./CHANGELOG.md)를 참조하세요.

### v1.x에서 마이그레이션

버전 2에서는 `hddfancontrol`이 Rust 언어로 완전히 재작성되었습니다. 버전 1에서의 주요 변경 사항은 다음과 같습니다:

- `hddfancontrol`이 컴파일된 바이너리로 Python 인터프리터가 더 이상 필요하지 않습니다.
- 명령줄 인수가 약간 변경되어, `hddfancontrol` 호출 시 또는 systemd 서비스를 통해 사용하는 경우 `/etc/conf.d/hddfancontrol` 파일에서 수동으로 조정해야 합니다. 참조는 `hddfancontrol daemon -h`를 확인하세요.
- 자동 드라이브 스핀다운 기능이 제거되었습니다. 필요하다면, [hd-idle](https://github.com/adelolmo/hd-idle)(유사한 이름의 여러 프로젝트가 있으니 주의) 사용을 권장하며, `hddfancontrol`과 함께 잘 작동합니다.

## 명령줄 사용법

전체 명령줄 참조는 `hddfancontrol -h`를 실행하세요.

예를 들어, 아래 명령줄은 HDD 팬 제어에 다음을 지시합니다:

- `/dev/sda`와 `/dev/sdb` 드라이브의 온도를 모니터링
- `/sys/class/hwmon/hwmon1/device/`에서 PWM 2와 3을 사용하여 팬 속도 제어
- PWM 값 200으로 두 팬을 모두 시작
- PWM 값 75로 팬이 정지한다고 간주

- 팬을 최대 속도의 10% 이하로 절대 작동하지 마십시오
- 온도는 최소 1분마다 확인하십시오

`hddfancontrol daemon -d /dev/sda /dev/sdb -p /sys/class/hwmon/hwmon1/device/pwm2:200:75 /sys/class/hwmon/hwmon1/device/pwm3:200:75 --min-fan-speed-prct 10 -i 1min`

## systemd 서비스

데몬을 쉽게 제어하기 위해 systemd 서비스 파일이 제공됩니다.
만약 배포판 패키지에서 hddfancontrol을 설치했다면 이미 설치되어 있을 가능성이 높으며, 그렇지 않으면 이 저장소의 소스에서 다음 명령어로 설치할 수 있습니다:

```
sudo install -Dm 644 ./systemd/hddfancontrol.service /etc/systemd/system/hddfancontrol.service
sudo install -Dm 644 ./systemd/hddfancontrol.conf /etc/conf.d/hddfancontrol
```

그런 다음 매개변수(드라이브, 온도 범위 등)를 설정하기 위해 `/etc/conf.d/hddfancontrol` 파일에서 `HDDFANCONTROL_DAEMON_ARGS` 변수를 편집해야 합니다.

그 후 `sudo systemctl start hddfancontrol` 명령으로 데몬을 시작하고, `sudo systemctl status hddfancontrol` 명령으로 상태를 확인하며, `sudo systemctl enable hddfancontrol` 명령으로 부팅 시 자동 시작을 활성화할 수 있습니다.

## 라이선스

[GPLv3](https://www.gnu.org/licenses/gpl-3.0-standalone.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-09

---