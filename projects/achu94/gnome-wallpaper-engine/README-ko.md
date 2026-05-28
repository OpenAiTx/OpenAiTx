# 🌌 GNOME 라이브 배경화면 엔진

> **[지금 GNOME 확장 프로그램에서 설치하기](https://extensions.gnome.org/extension/9558/gnome-wallpaper-engine/)**

복잡한 설정 필요 없음. 무거운 의존성도 없음. 단지 mpv, ffmpeg + 확장 프로그램만 있으면 됩니다.

GNOME에서 라이브 배경화면을 사용하는 **가장 간단하고 신뢰할 수 있는 방법** — **Wayland & X11** 완벽 호환.

최대 성능, 낮은 자원 사용량, 모든 형식 지원(MP4, GIF, WebM, MKV…)을 위한 **mpv** 기반.

이 프로젝트가 마음에 드신다면, 별⭐을 눌러주세요 — 큰 도움이 됩니다!

## ☕ 지원 및 업데이트

프로젝트를 지원하고 싶다면, 여기에서 가능합니다:

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/achu94)

Ko-fi에서 개발 업데이트, 진행 상황, 비하인드 스토리도 공유할 예정입니다.

기부하지 않아도 게시물을 볼 수 있습니다 — 누구나 함께 보고 최신 정보를 받을 수 있습니다 🙂

프로젝트가 마음에 드시면 GitHub에서 ⭐도 항상 환영합니다!

---

## 🎥 데모

> GNOME (Wayland)에서 실행 중인 라이브 배경화면

![demo](https://raw.githubusercontent.com/achu94/gnome-wallpaper-engine/main/assets/demo.gif)

---

## ✨ 기능

- 🎬 **통합 갤러리:** GNOME 설정에서 직접 배경화면을 탐색하고 선택
- 🖼️ **썸네일 미리보기:** 모든 배경화면에 자동 생성되는 미리보기
- 📥 **스마트 가져오기:** 한 번의 클릭으로 비디오 추가 및 즉시 적용
- 🚀 **GPU 가속(기본 활성화):** `hwdec=auto` 설정으로 mpv 사용
- ⚡ **매우 낮은 CPU 사용량:** 일반적으로 약 1–3%
- 🔄 **즉시 적용:** 실시간으로 배경화면 전환
- 🖥️ **Wayland 지원:** 대부분의 도구가 실패하는 환경에서도 안정적으로 작동
- 📦 **최소 설치:** mpv와 ffmpeg만 필요
- 🎞️ **광범위한 포맷 지원:** MP4, GIF, WebM, MKV 등
- 🔁 **자동 시작:** 로그인 시 자동으로 배경화면 시작
- 🧩 **트레이 아이콘 토글:** 상단 패널 표시기 표시 또는 숨기기
- ⏸️ **자동 일시정지 (전체화면):** 전체화면 앱 실행 시 일시정지
- 🔋 **자동 일시정지 (배터리):** 배터리 사용 시 전력 절약을 위해 일시정지

---

## 🚧 로드맵

- 🎮 Steam Wallpaper Engine 통합 (호환 배경화면 자동 감지 및 목록화)
- 🎛️ 고급 재생 설정 (반복 모드, 속도 등)
- 🎨 향후 렌더링 엔진 (mpv 없이)

---

## 🛠 요구사항

설치해야 할 것은 **mpv** 뿐입니다:

### 우분투 / 데비안 / 조린 OS

```bash
sudo apt update && sudo apt install mpv ffmpeg
```

### 페도라

```bash
sudo dnf install mpv ffmpeg
```

### 아치 리눅스

```bash
sudo pacman -S mpv ffmpeg
```

### openSUSE

```bash
sudo zypper in mpv ffmpeg
```
## 📦 설치

### 🎖️ 공식 GNOME 확장 기능 (가장 쉬움)
GNOME 확장 기능 웹사이트에서 직접 설치하세요:

**[GNOME 확장 기능에서 다운로드](https://extensions.gnome.org/extension/9558/gnome-wallpaper-engine/)**

---

### ⚡ 빠른 설치 (로컬 ZIP)


```bash
gnome-extensions install gnome-wallpaper-engine@gjs.com.zip
```
그런 다음:

- Wayland: 로그아웃 후 다시 로그인
- X11: `Alt + F2`를 누르고, `r` 입력 후 Enter 키 누르기

마지막으로 **Extensions** 앱을 사용하여 확장 기능을 활성화하세요  
(또는 활성화된 경우 상단 패널 표시기를 통해서도 가능).

---

### 🧩 수동 설치

1. 최신 릴리스에서 ZIP 파일 다운로드
2. 다음 위치에 압축 해제:


```
~/.local/share/gnome-shell/extensions/
```
3. 폴더 이름이 다음과 같도록 하십시오:


```
gnome-wallpaper-engine@gjs.com
```

4. 터미널에서 다음 명령어를 실행하여 GSettings 스키마를 컴파일하세요:

```
glib-compile-schemas ~/.local/share/gnome-shell/extensions/gnome-wallpaper-engine@gjs.com/schemas/
```
5. GNOME 셸 재시작  
    - Wayland: 로그아웃 후 다시 로그인  
    - X11: `Alt + F2`를 누르고, `r` 입력 후 Enter 키 누르기  

6. **Extensions** 앱에서 확장 기능 활성화  

---  

## 📖 사용법  

1. 확장 기능 설정 열기  
2. **"비디오/GIF 추가"** 클릭  
3. 갤러리에서 배경화면 선택  
4. 배경화면이 즉시 적용됨  
5. 선택적으로 상단 패널 표시기를 사용해 재생 시작 또는 중지  
6. 선택적으로 설정에서 트레이 아이콘 숨기기  

---  

## 💡 존재 이유  

GNOME, 특히 Wayland 환경에서 간단하고 신뢰할 수 있는 라이브 배경화면 솔루션이 부족하여 이를 해결하기 위해 만들었습니다.  

---  

## ⚖️ 라이선스  

GPL-3.0 — 자유 및 오픈 소스입니다.  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-28

---