# netevent

Netevent는 리눅스 이벤트 장치를 다른
기기와 공유할 수 있는 도구입니다 (`/dev/uinput`을 통해서든 동일한
프로토콜의 클라이언트를 다른 수단으로 구현하든 상관없습니다).

원래는 단순히 장치 기능을 stdout으로 출력하고 이후에는
한 모드에서는 `cat /dev/input/eventX`를 실행하는 것처럼 동작했고,
다른 모드에서는 파싱된 기능을 `/dev/uinput`에 전달한 후 이벤트를
전달했습니다.

여러 목적지가 있을 때 여러 장치를 관리하는 것이 번거로워질 수 있으므로
(그리고 원래의 grab/toggle/hotkey 메커니즘이 이상하고 저의 개인 사용 사례에
맞춰져 있었기 때문에), netevent2는 이제
한 패킷에 여러 장치를 포함할 수 있고 장치를 실시간으로 추가 및
제거할 수 있는 패킷을 포함하도록 프로토콜을 확장했습니다.

원래의 `cat`과 같은 동작(현재는 핫키 지원 없이)도 디버깅 용도로
사용 가능하며(`create` 모드는 두 프로토콜 버전을 모두 지원합니다).

주요 도구는 이제 명령 소켓(선택적으로 추상 유닉스 소켓)이 있는
`netevent daemon`으로, 이를 통해 장치, 출력 및
핫키를 실시간으로 추가할 수 있습니다. 아래 예제를 참조하십시오.

## 컴파일

* 선택사항: `./configure --prefix=/usr`
* `make`

이전처럼 여전히 `make`만 실행해도 됩니다. 다만 일반적인
설치 워크플로우를 지원하고, `/dev/uinput`이 `UI_DEV_SETUP` `ioctl`로 확장된
최신 커널 시스템과 구분하기 위해,
`./configure` 스크립트가 추가되어 이를 검사하고 `config.h`
및 `config.mak`를 생성하며 PREFIX/BINDIR/... 설정을 포함합니다
(이 모든 변수는 일반적인 `DESTDIR`과 함께 직접 `make`에 전달할 수도 있습니다).

## 설치

* `make install` 또는 `make DESTDIR=/my/staging/dir install`

또는: 이전과 같이 `netevent` 바이너리를 아무 곳에나 두면 됩니다.

## 사용법

아래 설정 스크립트에서 사용된 명령어에 대한 자세한 내용은 netevent(1)의 DAEMON COMMANDS 섹션을 참조하세요.

### 예제

`examples/` 디렉토리를 참조하세요. 아래 setup-example을 읽어 핫키 라인을 장치에 맞게 조정하는 방법을 확인하세요.

#### 간단한 예제 설정: ssh를 통해 키보드 및 마우스 공유하기:

호스트 측:

* 준비: 사용자로서 이벤트 장치에 접근할 수 있는지 확인

    보통은 `gpasswd -a myuser input` 같은 명령을 실행합니다.

* 1단계: 전달할 /dev/input/eventXY 장치를 결정합니다.

    일관된 파일 이름을 위해 다음과 같이 사용하세요:
    `/dev/input/by-id/usb-MyAwesomeKeyboard-event-kbd`
    `/dev/input/by-id/usb-BestMouseEver-event-mouse`

* 2단계: 핫키를 결정하고 해당 이벤트 코드를 찾습니다:

    위 예제에서는 키보드의 키를 사용하려고 합니다 (마우스 버튼이 엄청 많지 않은 한…).
    `netevent`는 이벤트를 읽기 쉽게 덤프하는 데 사용할 수 있으며, 장치에서 `show` 서브커맨드를 실행하고 핫키로 사용할 키를 누릅니다.
    이 명령을 입력하는 키보드가 같다면, netevent가 엔터 키 릴리즈를 감지하여 혼동하지 않도록 sleep을 미리 넣으세요.







    ```
    $ sleep 0.3 && netevent show /dev/input/by-id/usb-...-event-kbd
    MSC:4:3829
    KEY:189:1
    SYN:0:0
    MSC:4:3829
    KEY:189:0
    SYN:0:0
    ```
* 3단계: 데몬용 설정 스크립트를 준비합니다:


    ```
    # file: netevent-setup.ne2
    # Add mouse & keyboard
    device add mymouse /dev/input/by-id/usb-BestMouseEver-event-mouse
    device add mykbd /dev/input/by-id/usb-MyAwesomeKeyboard-event-kbd

    # Add toggle hotkey (on press, and ignore the release event)
    hotkey add mykbd key:189:1 grab-devices toggle\; write-events toggle
    hotkey add mykbd key:189:0 nop

    # Connect to the two devices via password-less ssh
    output add myremote exec:ssh user@other-host netevent create
    # Select the output to write to
    use myremote
    ```
* 4단계: netevent 데몬 실행:

    `$ netevent daemon -s netevent-setup.ne2 netevent-command.sock`

이제 소켓에 연결하여 데몬에 추가 명령을 보낼 수 있습니다.
예를 들어 `socat READLINE UNIX-CONNECT:netevent-command.sock`을 통해 가능합니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---