# SSH-List
TUI 인터페이스를 갖춘 SSH 연결 관리자입니다.

![demo gif](https://raw.githubusercontent.com/akinoiro/ssh-list/main/images/demo.gif)

주요 기능:
- 연결 추가 및 편집
- 연결 재배열 및 정렬
- ~/.ssh/config에서 호스트 가져오기
- 연결 검색 및 필터링
- 원격 호스트에서 명령 실행

이 애플리케이션은 기존 SSH 구성 파일을 수정하지 않습니다. 호스트 설정은 Include 지시어로 참조되는 여러 파일(시스템 및 사용자 구성 간 포함)에 분산될 수 있으므로 자동 편집은 신뢰할 수 없습니다.

이 애플리케이션은 비밀번호를 저장하지 않습니다. 안전한 인증을 위해 SSH 키를 사용하세요.

## 사전 요구 사항
시스템에 OpenSSH 클라이언트가 설치되어 있어야 합니다.
## GitHub 릴리스에서 설치
[릴리스 페이지](https://github.com/akinoiro/ssh-list/releases)에서 최신 바이너리를 다운로드하세요.

#### 터미널에서 `ssh-list` 명령어를 실행하려면:
```
# Make the binary executable
chmod +x ssh-list
# Move it to a directory in your PATH
sudo mv ssh-list /usr/local/bin/
```

## crates.io에서 설치하기
```
cargo install ssh-list
```
## AUR(Arch Linux)에서 설치하기
```
paru -S ssh-list
```
## PPA에서 설치하기 (우분투, 리눅스 민트)
```
sudo add-apt-repository ppa:akinoiro/ssh-list
sudo apt update
sudo apt install ssh-list
```
## Homebrew에서 설치하기 (macOS, Linux)
```
brew tap akinoiro/tap
brew install ssh-list
```
## 소스에서 빌드하기
Rust와 Cargo가 설치되어 있어야 합니다.
```
git clone https://github.com/akinoiro/ssh-list
cd ssh-list
cargo build --release
```
바이너리는 target/release/에 위치합니다.  
## 구성 파일  
ssh-list는 연결 정보를 저장하기 위한 파일을 자동으로 생성합니다:
```
~/.ssh/ssh-list.json
```
및 애플리케이션 설정:
```
~/.ssh/ssh-list_config.toml
```
## Appearance customization

![demo settingsgif](https://raw.githubusercontent.com/akinoiro/ssh-list/main/images/demo_settings.gif)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-17

---