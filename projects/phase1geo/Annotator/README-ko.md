
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Annotator

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="AppCenter에서 받기"/>
  </a>
</p>

![<center><b>메인 창 - 라이트 테마</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "Elementary OS용 이미지 주석")

## 개요

이미지에 주석을 추가하여 그림으로 천 마디 말을 전달하세요.

- 파일 시스템, 클립보드에서 이미지를 불러오거나, 스크린샷을 생성하여 주석을 추가할 수 있습니다.
- 이미지의 세부사항을 강조하기 위해 도형, 스티커, 이미지, 텍스트, 그림 및 기타 설명 요소를 추가할 수 있습니다.
- 이미지 세부사항을 확대하기 위해 확대경을 추가할 수 있습니다.
- 이미지의 일부를 흐리게 처리하여 데이터를 숨길 수 있습니다.
- 이미지를 자르고, 크기를 조절하고, 테두리를 추가할 수 있습니다.
- 색상, 선 두께, 글꼴 세부사항을 제어할 수 있습니다.
- 확대/축소 지원.
- 로드된 이미지 내에서 색상 선택기 지원.
- 모든 변경 사항에 대해 무제한 실행 취소/재실행 기능 제공.
- 주석이 추가된 이미지를 PNG 형식으로 드래그 앤 드롭 복사 가능.
- JPEG, PNG, TIFF, BMP, PDF, SVG 및 WebP 이미지 포맷으로 내보내기 가능.
- 주석이 추가된 이미지를 클립보드에 복사하는 기능 지원.
- 프린터 지원.

## 설치

### Debian (소스에서 설치)

Annotator를 빌드하기 위해 다음과 같은 의존성이 필요합니다:

- meson
- valac
- debhelper
- gobject-2.0
- glib-2.0
- libgee-0.8-dev
- libgranite-7-dev
- libgtk-4-dev
- libxml2-dev
- libarchive-dev
- libwebp-dev

Annotator를 소스에서 설치하려면 `./app install`을 실행하세요.

Annotator를 실행하려면 `com.github.phase1geo.annotator`를 실행하세요.

### 우분투 (PPA)

@PandaJim이 관리하는 [PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/)를 사용할 수 있습니다. 이 PPA는 Ubuntu 20.04+를 지원합니다. 다음 명령어를 하나씩 입력하세요.

```
sudo add-apt-repository ppa:ubuntuhandbook1/annotator
sudo apt update
sudo apt install com.github.phase1geo.annotator
```
### Arch Linux

Arch Linux 사용자라면,
[AUR 패키지](https://aur.archlinux.org/packages/annotator/)
`annotator`가 있습니다:


```
% yay -S annotator
```

### Flatpak

또한, Annotator는 Flatpak을 통해 설치 및 실행할 수 있습니다.

elementary Flatpak을 소스에서 빌드하려면 `./app elementary`를 실행하세요.

Flathub Flatpak을 소스에서 빌드하려면 `./app flathub`를 실행하세요.

이후에는 `./app run-flatpak`로 실행할 수 있습니다.

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="AppCenter에서 받기"/>
  </a>
</p>

## 크레딧

`document-edit-symbolic.svg` 및 `image-crop-symbolic.svg`를 포함하며,
[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic)에서
GPL v3.0 라이선스 조건에 따라 사용합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---