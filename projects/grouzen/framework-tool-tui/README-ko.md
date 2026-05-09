# Framework 시스템 TUI

![Rust](https://img.shields.io/badge/lang-rust-orange) ![ratatui](https://img.shields.io/badge/ui-ratatui-blue) ![Framework Laptop](https://img.shields.io/badge/hardware-Framework--Laptop-success)  

Framework Laptop 하드웨어를 제어하고 모니터링할 수 있는 빠른 TUI 대시보드 — 충전, 프라이버시, 조명, USB PD 포트 등.

![demo](/docs/screenshots/demo-v0.7.2.gif)

## :octocat: 기능

### Framework Laptop 하드웨어

- [x] **제한 및 충전 제어가 가능한** 실시간 배터리 및 충전 상태
- [x] 마이크 및 카메라용 **프라이버시 토글**
- [ ] **입력 데크 모드** 선택기 (Framework 16)
- [x] **키보드 및 지문 인식기 밝기** 제어
- [x] **USB PD 포트 모니터링**
- [x] **팬 RPM**
- [ ] **열 정보:** CPU/GPU 온도
- [x] **시스템 정보:** BIOS 세부사항

## 설치

### :dvd: 바이너리

Linux, Windows, FreeBSD용 미리 컴파일된 바이너리는 [Releases](https://github.com/grouzen/framework-tool-tui/releases) 페이지에서 다운로드할 수 있습니다.

### :memo: 소스에서

[러스트](https://rustup.rs/) (Edition 2024)와 Framework 노트북이 필요합니다.

```sh
git clone https://github.com/grouzen/framework-tool-tui.git
cd framework-tool-tui
cargo build --release
# or via cargo install
cargo install --path .
```
### :penguin: 리눅스 배포판

#### 젠투 리눅스

공식 [Gentoo 패키지](https://packages.gentoo.org/packages/app-laptop/framework-tool-tui) 또는 [lamdness](https://github.com/grouzen/lamdness-overlay/tree/main/app-laptop/framework-tool-tui) 오버레이를 통해 사용 가능합니다


```sh
# Official gentoo repository
sudo emerge -av app-laptop/framework-tool-tui

# or via lamdness overlay
sudo eselect repository enable lamdness
sudo emaint -r lamdness sync
sudo emerge -av app-laptop/framework-tool-tui
```
#### 아치 리눅스

[AUR](https://aur.archlinux.org/packages/framework-tool-tui) 또는 [archlinuxcn](https://github.com/archlinuxcn/repo/tree/master/archlinuxcn/framework-tool-tui)을 통해 사용 가능합니다.


```sh
[yay/paru] -S framework-tool-tui # Install from AUR
sudo pacman -S framework-tool-tui # Install from archlinuxcn
```

#### NixOS 리눅스

공식 [NixOS 패키지](https://search.nixos.org/packages?query=framework-tool-tui)를 통해 사용할 수 있습니다:

```sh
nix-shell -p framework-tool-tui # Install temporarily

# Add to the NixOS configuration or use nix profile to install permanently
```

#### :beer: 리눅스용 Homebrew

[`framework-tool-tui` 포뮬러](https://formulae.brew.sh/formula/framework-tool-tui)를 통해 사용 가능함

```sh
brew install framework-tool-tui
```

### 😈 FreeBSD


[FreeBSD 포트](https://www.freshports.org/sysutils/framework-tool-tui/)에서 사용할 수 있습니다.
```sh
pkg install framework-tool-tui
```
### 윈도우

현재로서는 [소스에서](#memo-from-source) 또는 [사전 빌드된 바이너리에서](#dvd-binaries) 설치할 수 있습니다.

## :man: 실행

하드웨어 제어에 접근하려면 관리자 권한으로 실행해야 합니다.


```sh
sudo framework-tool-tui
```

## :pencil: 아키텍처

전체 기술 분석은 [ARCHITECTURE.md](https://raw.githubusercontent.com/grouzen/framework-tool-tui/main/docs/ARCHITECTURE.md)를 참조하세요.  
- [`framework_lib`](https://github.com/FrameworkComputer/framework-system)을 통한 하드웨어 폴링

## :handshake: 기여하기

풀 리퀘스트 환영합니다! 버그 리포트나 기능 요청은 Issues를 참고하세요.

### 푸시 전에 코드 확인하기

기능 브랜치에 커밋하고 푸시하기 전에 `cargo make check-all`을 실행하는 것이 권장됩니다.

이를 위해 시스템에 [cargo make](https://github.com/sagiegurari/cargo-make) 실행기가 설치되어 있어야 합니다:

```sh
cargo install --force cargo-make
```

### 커밋 메시지 규칙

이 프로젝트는 자동 버전 관리 및 변경 로그 생성을 위해 [Conventional Commits](https://www.conventionalcommits.org/)를 사용합니다. 커밋 메시지를 다음과 같이 작성해 주세요:

```
<type>: <description>

[optional body]
```

**일반 유형:**
- `feat:` - 새로운 기능 (마이너 버전 증가 유발)
- `fix:` - 버그 수정 (패치 버전 증가 유발)
- `docs:` - 문서 변경
- `refactor:` - 코드 리팩토링
- `test:` - 테스트 추가 또는 업데이트
- `chore:` - 유지보수 작업
- `ci:` - CI/CD 변경

**예시:**
```
feat: add thermal monitoring support
fix: correct battery percentage calculation
docs: update installation instructions
```
변경 사항이 호환되지 않을 경우, 타입 뒤에 `!`를 추가하거나 푸터에 `BREAKING CHANGE:`를 포함하세요:

```
feat!: redesign UI layout
```

### 기술 스택

- [ratatui](https://ratatui.rs)
- [tokio](https://tokio.rs)
- [framework_lib](https://github.com/FrameworkComputer/framework-system/tree/main/framework_lib)

## :judge: 라이선스

```
MIT License

Copyright (c) 2025 Mykhailo Nedokushev

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

```

라이선스 및 종속성에 대해서는 [LICENSE](LICENSE) 및 [Cargo.toml](https://raw.githubusercontent.com/grouzen/framework-tool-tui/main/Cargo.toml:1)를 참조하십시오.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-09

---