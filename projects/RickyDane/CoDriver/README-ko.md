<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">

  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Buy Me a Coffee at ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Rust 언어를 배우고 싶어서 만든 간단한 파일 탐색기입니다.
  <br>
  운영 체제에 독립적이며 최적화를 위해 다듬어졌습니다.
</p>

<br/><br/>

최적의 성능은 ["jwalk"](https://crates.io/crates/jwalk/versions)와 ["Tauri"](https://tauri.app/)에 의해 달성됩니다.
<br/><br/>
CoDriver는 파일과 폴더에 접근할 때 경로 캐싱을 사용하지 않으므로, 성능은 Rust, 디스크 속도 및 CPU 성능에 의해 달성됩니다.

⁉️ 이 소프트웨어는 아직 개발 중이므로 버그가 포함되어 있을 수 있습니다!
<br/><br/>

# 링크
- <a href="#basic-features">기본 기능</a>
- <a href="#advanced-features">고급 기능</a>
- <a href="#dependencies-if-not-working-instantly">의존성</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">FTP 구현 (SSHFS)</a>
- <a href="#%EF%B8%8F-known-issues">알려진 문제</a>
- <a href="#-todos">할 일</a>
- <a href="#user-interface">사용자 인터페이스</a>

## 기본 기능
- 익숙한 방식으로 디렉터리 탐색
- 파일 및 폴더 복사 & 붙여넣기, 삭제, 생성 및 이름 변경
- 그리드, 목록, 밀러-컬럼 모드 전환
- esc로 팝업 닫기
- Ctrl / Cmd + G로 경로를 입력하여 디렉터리로 바로 이동
- 목록 모드에서 크기, 이름 또는 마지막 수정일로 정렬

## 고급 기능
- 파일 및 폴더 압축
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- 압축 파일 해제
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- 바로 가기 LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3)로 디렉터리 이동
  - 설정에서 직접 경로 구성 가능
- F6으로 파일 생성
- F7로 폴더 생성
- 듀얼-패인 보기
  - F8로 파일 검색
  - F5로 현재 선택된 항목을 다른 패인에 복사
  - LShift + F5로 현재 선택된 항목을 다른 패인에 이동
- 파일을 탐색기로 드래그 앤 드롭하여 현재 디렉터리에 복사
- Ctrl / Cmd + LShift + M으로 선택 항목 다중 이름 변경
  - Ctrl / Cmd + Return으로 다중 이름 변경 실행
- 파일 빠른 미리보기 -> 디렉터리 항목 선택 후 스페이스바 탭
  - 지원 파일: 모든 이미지 파일(.jpg, .png 등), .pdf, .mp4, .json, .txt, .html
  - 기타 모든 항목에는 정보(경로, 크기, 마지막 수정일)가 있는 작은 타일 표시
- 즉시 탐색 -> 입력을 시작하면 디렉터리 항목이 자동으로 필터링되어 <br/>
  원하는 위치로 훨씬 더 빠르게 이동 가능

## 종속성 (즉시 작동하지 않을 경우)

<details>
<summary>펼치기</summary>

### 리눅스

- openssl1.1

#### 데비안 / 우분투
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### 아치
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### 페도라
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ FTP 통합 (sshfs)
<details>
  <summary>펼치기</summary>
  <br/>
  추가로 설치해야 하는 종속성:
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | 아직 **_지원되지 않음_** |

  ### 설치:
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### 리눅스
  ```
  sudo apt-get install sshfs
  ```

## 🏴‍☠️ 언어 지원
- 영어
  - 곧 언어 선택 옵션이 추가될 예정입니다 ...
</details>

## ⚠️ 알려진 문제:
- 리눅스에서 창 밖으로 드래그 앤 드롭이 항상 정상적으로 작동하지 않을 수 있습니다
- 윈도우에서는 [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)를 설치해야 할 수 있습니다
- ms-windows에서 권한 문제가 다소 이상하게 동작할 수 있습니다
  - 요소 복사 등 문제 발생 시 관리자 권한으로 프로그램을 실행해야 할 수 있습니다
- 리눅스 시스템에서 프로그램이 시작되지 않으면 openssl1.1을 설치해야 할 수도 있습니다

## 📝 할 일:
- 다국어 지원
- 즐겨찾기
- 온라인 저장소 서비스 접속 (Google 드라이브 등)

## 사용자 인터페이스

### 리스트 스타일
<img width="1119" height="673" alt="Screenshot 2025-11-16 at 13 53 53" src="https://github.com/user-attachments/assets/cfe15e6f-9936-4e29-9ca5-0f83f366c9dc" />

### 그리드 스타일
<img width="1121" height="674" alt="Screenshot 2025-11-16 at 13 53 46" src="https://github.com/user-attachments/assets/69dbeee0-b53c-4566-b90e-e85ab97e0033" />

### 밀러 칼럼 뷰
<img width="1112" height="664" alt="Screenshot 2025-11-16 at 13 54 29" src="https://github.com/user-attachments/assets/1f540880-2097-423b-8522-1ef466aee1bd" />

### 듀얼 패널 뷰
<img width="1119" height="667" alt="Screenshot 2025-11-16 at 13 55 16" src="https://github.com/user-attachments/assets/80706079-a048-4e9e-93f0-54fa270f30ac" />

## 기여 방법
tauri v1 애플리케이션 개발을 위한 환경을 설정하세요: [Tauri 사전 준비사항](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
준비가 완료되면 머신의 원하는 위치에서 ```git clone https://github.com/RickyDane/CoDriver``` 또는 ```gh repo clone RickyDane/CoDriver```를 실행하세요.
</br></br>
프로젝트 루트 디렉터리에서 ```cargo tauri dev```를 실행하면 CoDriver를 빌드 및 실행할 수 있습니다.
</br>
tauri-cli가 설치되어 있는지 확인하세요: ```cargo install tauri-cli```
</br>

## 릴리즈 서명

macOS 릴리즈 산출물은 Gatekeeper가 설치된 앱이 손상되었다고 보고하지 않도록 반드시 서명 및 공증되어야 합니다. 필요한 GitHub Actions 비밀값과 검증 명령어는 [macOS 서명 및 공증](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) 문서를 참고하세요.

## Star History

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### 기타 서드파티 소프트웨어
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---