<br/>
<p align="center"><img width="700" src="https://github.com/user-attachments/assets/44295a1a-c904-407d-97af-bc1aa74baa86"/></p>
<br>
<!-- <p align="center"><a target="_blank" href="https://discord.gg/XPakYank"><img src="https://dcbadge.limes.pink/api/server/XPakYank" alt="" /></a></p> -->
<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<a href='https://ko-fi.com/rickydane'>
  <p align="center">
    <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Buy Me a Coffee at ko-fi.com' />
  </p>
</a>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>
<p align="center">
  Rust 언어를 배우고 싶어서 탄생한 간단한 파일 탐색기입니다.
  <br>
  운영 체제에 독립적이며 최적화를 위해 다듬어졌습니다.
</p>

<br/><br/>

성능은 ["jwalk"](https://crates.io/crates/jwalk/versions)와 ["Tauri"](https://tauri.app/)에서 제공합니다.
<br/><br/>
CoDriver는 파일과 폴더에 접근할 때 경로 캐싱을 사용하지 않으므로, 성능은 Rust, 디스크 속도 및 CPU 성능에 의해 결정됩니다.

⁉️ 이 소프트웨어는 아직 개발 중이며 버그가 포함될 수 있음을 유의하세요!
<br/><br/>

# Links
- <a href="#basic-features">기본 기능</a>
- <a href="#advanced-features">고급 기능</a>
- <a href="#dependencies-if-not-working-instantly">종속성</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">FTP 구현 (SSHFS)</a>
- <a href="#%EF%B8%8F-language-support">언어 지원</a>
- <a href="#%EF%B8%8F-known-issues">알려진 문제</a>
- <a href="#-todos">할 일</a>
- <a href="#user-interface">사용자 인터페이스</a>
- <a href="#speed-comparison">속도 비교</a>
<br/>

## 기본 기능
- 익숙한 방식으로 디렉터리 탐색
- 복사 및 붙여넣기, 삭제, 파일 및 폴더 생성과 이름 변경
- "큰 버튼" 모드, 목록 모드, 밀러 컬럼 모드 간 전환
- esc 키로 팝업 닫기
- Ctrl / Cmd + G로 경로 입력하여 디렉터리로 이동
- 목록 모드에서 크기, 이름 또는 최종 수정일로 항목 정렬
<br/>

## 고급 기능
- 파일 및 폴더 압축
  - zip
- 작업 디렉터리에 새 폴더로 아카이브 자동 풀기
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
- 바로 가기 LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3)로 디렉터리 이동
  - 설정에서 경로 직접 구성 가능
- F6 키로 파일 생성
- F7 키로 폴더 생성
- 디렉터리에서 입력 시작 시 즉시 디렉터리 항목 필터링
- 듀얼 페인 뷰
  - F8 키로 파일 검색
  - F5 키로 현재 선택한 항목을 다른 페인으로 복사
  - LShift + F5로 현재 선택한 항목을 다른 페인으로 이동
- 탐색기로 파일을 드래그 앤 드롭하여 현재 디렉터리에 복사
- Ctrl / Cmd + LShift + M으로 선택 항목 다중 이름 변경
  - Ctrl / Cmd + Return으로 다중 이름 변경 실행
- 파일 빠른 미리보기 -> 디렉터리 항목 선택 후 스페이스 바 누르기.
  - 지원 파일: 모든 이미지 파일(.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - 기타 모든 항목은 해당 항목에 대한 일부 정보(경로, 크기, 마지막 수정일)를 포함하는 작은 타일을 표시합니다.
- 즉각 탐색 -> 입력을 시작하면 디렉토리 항목이 자동으로 필터링되어 원하는 위치로 훨씬 빠르게 이동할 수 있습니다.
<br/>

## 종속성 (즉시 작동하지 않을 경우)

<details>
<summary>확장하여 보기</summary>

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
<br/>

## 🖥️ FTP 통합 (sshfs)
<details>
  <summary>펼쳐보기</summary>
  <br/>
  추가로 설치해야 하는 종속성:
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | 아직 지원되지 않음 **_yet_** |

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
<br/>

## 🏴‍☠️ 언어 지원
- 영어
  - 곧 언어 선택 옵션 제공 예정 ...
</details>
<br/>

## ⚠️ 알려진 문제:
- 리눅스에서 창 밖으로 드래그 앤 드롭이 현재 작동하지 않음
- 윈도우에서 [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170) 설치가 필요할 수 있음
- ms-windows 권한 설정이 다소 이상함
  - 요소 복사 등 문제 발생 시 관리자 권한으로 프로그램 실행 필요할 수 있음
- 프로그램이 시작되지 않을 경우 리눅스 시스템에 openssl1.1 설치가 필요할 수 있음
- ~~탭 기능이 아직 완전히 구현되지 않음~~
<br/>

## 📝 할 일:
- 다중 언어 지원
- 즐겨찾기 기능
- 온라인 저장소 서비스 접근 (구글 드라이브 등)
<br/>

## 사용자 인터페이스

### 리스트 스타일
![Screenshot 2024-08-13 at 19 08 02](https://github.com/user-attachments/assets/d643c7f9-44e8-4f94-a23c-69759b600c82)

### 그리드 스타일
![Screenshot 2024-08-13 at 19 08 00](https://github.com/user-attachments/assets/b28b346a-58f3-4f7c-a23d-b19f0695bf23)

### 밀러 컬럼 뷰
![Screenshot 2024-08-13 at 19 08 07](https://github.com/user-attachments/assets/95ab9426-837f-492d-8139-9bf7f1f0c51e)

### 듀얼 페인 뷰
![Screenshot 2024-08-13 at 19 08 25](https://github.com/user-attachments/assets/a3f9a511-5e8f-44ed-95d3-1a59e2cba05b)

## 속도 비교
윈도우 파일 탐색기: _39.83 초_<br/>
CoDriver: **_0.81 초_**
https://github.com/user-attachments/assets/17116fa5-8f43-4339-a4ff-2525e7c94ae0

Windows 파일 탐색기: _44.91초_<br/>
CoDriver: **_< 0.5초_**

https://github.com/user-attachments/assets/169da3d0-06ac-4775-a631-5c5708ae4766

</br>

## 기여 방법
tauri v1 애플리케이션 개발을 위한 머신 설정: [Tauri 사전 준비사항](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
설정이 완료되면 ```git clone https://github.com/RickyDane/CoDriver``` 또는 ```gh repo clone RickyDane/CoDriver```를 머신의 원하는 위치에서 실행하세요.
</br></br>
이 프로젝트의 루트 디렉터리에서 ```cargo tauri dev```를 실행하면 CoDriver를 빌드하고 실행할 수 있습니다.
</br>
tauri-cli가 설치되어 있는지 확인하세요: ```cargo install tauri-cli```
</br></br>

## 별(star) 히스토리

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="별 히스토리 차트" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### 기타 서드파티 소프트웨어
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-02

---