usb-gadget
==========

[![crates.io page](https://img.shields.io/crates/v/usb-gadget)](https://crates.io/crates/usb-gadget)
[![docs.rs page](https://docs.rs/usb-gadget/badge.svg)](https://docs.rs/usb-gadget)
[![Apache 2.0 license](https://img.shields.io/crates/l/usb-gadget)](https://github.com/surban/usb-gadget/blob/master/LICENSE)

이 라이브러리는 USB 주변기기, 즉 **USB 가젯**을 구현할 수 있게 해주며,
USB 장치 컨트롤러(UDC)가 있는 Linux 장치에서 사용됩니다.
사전 정의된 USB 기능과 완전히 사용자 정의된 USB 인터페이스 구현을 모두 지원합니다.

다음과 같은 커널 드라이버로 구현된 사전 정의된 USB 기능들이 제공됩니다:

* 네트워크 인터페이스
    * CDC ECM
    * CDC ECM (서브셋)
    * CDC EEM
    * CDC NCM
    * RNDIS
* 직렬 포트
    * CDC ACM
    * 일반
* 휴먼 인터페이스 장치(HID)
* 대용량 저장 장치(MSD)
* 프린터 장치
* 음악 기기 디지털 인터페이스(MIDI)
* 오디오 장치(UAC1 및 UAC2)
* 비디오 장치(UVC)

추가로 완전히 사용자 정의된 USB 기능을 사용자 모드 Rust 코드로 구현할 수 있습니다.

운영체제별 디스크립터 및 WebUSB 지원도 제공합니다.

CLI 도구
--------

`usb-gadget` CLI 도구를 사용하면 Rust 코드를 작성하지 않고도 TOML 구성 파일로 USB 가젯을 구성할 수 있습니다.



### 설치

    cargo install usb-gadget --features cli

### 사용법

가젯을 설명하는 TOML 구성 파일을 만든 다음 CLI를 사용하여 관리합니다:

    usb-gadget up gadget.toml       # 가젯 등록 및 바인딩
    usb-gadget list                 # 등록된 가젯 목록 보기
    usb-gadget down my-gadget       # 이름으로 가젯 제거
    usb-gadget down --all           # 모든 가젯 제거
    usb-gadget check gadget.toml    # 구성 파일 검증

`up` 또는 `check`에 디렉터리를 전달하여 해당 디렉터리의 모든 `.toml` 파일을 처리할 수도 있습니다.

### 예제 구성

```toml
name = "serial-debug"

[device]
vendor = 0x1209
product = 0x0002
manufacturer = "Example Inc."
product_name = "Debug Console"
serial = "0001"

[[config]]
description = "Serial Config"

[[config.function]]
type = "serial"
class = "acm"
```
하나의 가젯에 여러 기능을 결합하려면 더 많은 `[[config.function]]` 항목을 추가하면 됩니다. 사용 가능한 모든 템플릿을 보려면 `usb-gadget template --list`를 실행하세요.

기능
----

이 크레이트는 다음과 같은 선택적 기능을 제공합니다:

* `cli`: TOML 파일에서 가젯을 구성하기 위한 `usb-gadget` CLI 도구를 빌드합니다.
* `tokio`: Tokio 런타임 위에서 사용자 정의 USB 기능에 대한 비동기 지원을 활성화합니다.

요구 사항
--------

지원하는 최소 Rust 버전(MSRV)은 1.77입니다.

리눅스에서 지원하는 USB 디바이스 컨트롤러(UDC)가 필요합니다. 일반적으로 표준 PC에는 UDC가 포함되어 있지 않습니다.
Raspberry Pi 4에는 USB-C 포트에 연결된 UDC가 포함되어 있습니다.

완전한 기능을 위해 다음 리눅스 커널 구성 옵션이 활성화되어야 합니다:

  * `CONFIG_USB_GADGET`
  * `CONFIG_USB_CONFIGFS`
  * `CONFIG_USB_CONFIGFS_SERIAL`
  * `CONFIG_USB_CONFIGFS_ACM`
  * `CONFIG_USB_CONFIGFS_NCM`
  * `CONFIG_USB_CONFIGFS_ECM`
  * `CONFIG_USB_CONFIGFS_ECM_SUBSET`
  * `CONFIG_USB_CONFIGFS_RNDIS`
  * `CONFIG_USB_CONFIGFS_EEM`
  * `CONFIG_USB_CONFIGFS_MASS_STORAGE`
  * `CONFIG_USB_CONFIGFS_F_FS`
  * `CONFIG_USB_CONFIGFS_F_HID`
  * `CONFIG_USB_CONFIGFS_F_PRINTER`
  * `CONFIG_USB_CONFIGFS_F_MIDI`
  * `CONFIG_USB_CONFIGFS_F_UAC1`
  * `CONFIG_USB_CONFIGFS_F_UAC2`
  * `CONFIG_USB_CONFIGFS_F_UVC`



루트 권한은 리눅스에서 USB 가젯을 구성하기 위해 필요하며
`configfs` 파일시스템이 마운트되어야 합니다.


라이선스
-------

usb-gadget은 [Apache 2.0 라이선스] 하에 라이선스가 부여됩니다.

[Apache 2.0 라이선스]: https://github.com/surban/usb-gadget/blob/master/LICENSE

### 기여

명시적으로 달리 언급하지 않는 한, usb-gadget에 포함을 위해
귀하가 의도적으로 제출한 모든 기여는 추가 조건 없이 Apache 2.0으로
라이선스가 부여됩니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-27

---