# Soulseek CLI

[![Build Status](https://travis-ci.org/aeyoll/soulseek-cli.svg?branch=develop)](https://travis-ci.org/aeyoll/soulseek-cli)

Soulseek CLI 클라이언트입니다.

요구 사항
---

NodeJS >= 20

설치
---

```sh
npm install -g soulseek-cli
```
### 리눅스에서

soulseek-cli의 의존성 중 하나인 ([node-keytar](https://github.com/atom/node-keytar))가 libsecret을 사용하므로, `npm install`을 실행하기 전에 이를 설치해야 합니다.

배포판에 따라 다음 명령어를 실행해야 합니다:

- Debian/Ubuntu: `sudo apt-get install libsecret-1-dev`
- Red Hat 기반: `sudo yum install libsecret-devel`
- Arch Linux: `sudo pacman -S libsecret`

### 헤드리스 리눅스에서

리눅스에서 [node-keytar](https://github.com/atom/node-keytar)는 Linux SecretService API를 사용합니다. X11 서버가 없는 리눅스 시스템에서도 SecretService 백엔드를 사용할 수 있습니다 (D-Bus만 필요). 이 경우, 다음과 같이 할 수 있습니다 (예시는 Debian 환경입니다):

#### 의존성 설치하기


```sh
apt install gnome-keyring --no-install-recommends # Install the GNOME Keyring daemon. "no-install-recommends" prevents X11 install
```

#### 사용법

```sh
dbus-run-session -- $SHELL # Start a D-Bus session
echo 'root' | /usr/bin/gnome-keyring-daemon -r -d --unlock # Unlock GNOME Keyring
soulseek ... # Use soulseek-cli normally
```

명령어
---

### 로그인

검색을 하기 전에 로그인이 필요합니다.

사용법:
```
soulseek login
```

Soulseek 로그인과 비밀번호를 입력하라는 메시지가 표시됩니다. 자격 증명은 시스템 키체인에 저장되고 암호화됩니다.

또는 환경 변수를 설정하여 로그인할 수도 있습니다:

```sh
export SOULSEEK_ACCOUNT=youraccount
export SOULSEEK_PASSWORD=yourpassword
soulseek download "..."
```

### 다운로드

필요한 쿼리와 함께 다운로드하세요.

사용법:
```
soulseek download|d [options] [query...]
```

:warning: 이 명령어는 0.1.0 이전 버전에서 `search`로 불렸습니다.

옵션:

| 옵션                       | 설명                                                                         |
| ------------------------- | ----------------------------------------------------------------------------- |
| -d --destination <folder> | 다운로드 대상 폴더                                                             |
| -q --quality <quality>    | 지정한 품질의 mp3만 표시                                                      |
| -m --mode <mode>          | 원하는 파일 종류 필터링 (가능 값: "mp3", "flac", 기본값: "mp3")               |
| -h --help                 | 명령어 도움말 표시                                                            |

예제:

```sh
soulseek download "Your query" # Download in the current folder
soulseek download "Your query" --destination=/path/to/directory # Download in a defined folder (relative or absolute)
soulseek download "Your query" --quality=320 # Filter by quality
soulseek download "Your query" --mode=flac # Filter by file type
```

### 쿼리

필수 쿼리로 검색하되, 아무것도 다운로드하지 않습니다. 결과가 발견되면 반환 코드는 0입니다. 그렇지 않으면,
반환 코드는 1입니다 (스크립트 작성에 유용함)

사용법:

```
soulseek query|q [options] [query...]
```
옵션:

| 옵션                   | 설명                                                                        |
| ---------------------- | ---------------------------------------------------------------------------- |
| -q --quality <quality> | 특정 품질의 mp3만 표시                                                       |
| -m --mode <mode>       | 원하는 파일 종류 필터링 (사용 가능: "mp3", "flac", 기본값: "mp3")           |
| -h --help              | 명령어 도움말 표시                                                          |



기여
---

[CONTRIBUTING.md](https://raw.githubusercontent.com/aeyoll/soulseek-cli/main/CONTRIBUTING.md)을 참조하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---