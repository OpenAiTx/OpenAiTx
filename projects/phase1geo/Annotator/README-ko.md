# 주석 도구

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="AppCenter에서 받기"/>
  </a>
</p>

![<center><b>주 창 - 라이트 테마</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "Elementary OS용 이미지 주석")

## 개요

이미지에 주석을 달아 한 장의 사진이 천 마디 말을 하게 하세요.

- 파일 시스템, 클립보드에서 이미지 불러오기 또는 주석 달기 위한 스크린샷 생성.
- 도형, 스티커, 이미지, 텍스트, 그림 및 기타 호출 요소를 추가하여 이미지 세부사항 강조.
- 이미지 세부사항을 확대하는 돋보기 추가.
- 데이터 은폐를 위해 이미지 일부 흐리게 처리.
- 자르기, 크기 조정 및 이미지 테두리 추가.
- 색상, 선 두께 및 글꼴 세부사항 조절.
- 확대/축소 지원.
- 불러온 이미지 내 색상 선택기 지원.
- 모든 변경 사항에 대해 무제한 실행 취소/재실행.
- 주석이 달린 이미지의 PNG 복사본 드래그 앤 드롭.
- JPEG, PNG, TIFF, BMP, PDF, SVG 및 WebP 이미지 형식으로 내보내기.
- 주석이 달린 이미지 클립보드 복사 지원.
- 프린터 지원.

## 설치

### 데비안 (소스에서)

Annotator를 빌드하려면 다음 의존성이 필요합니다:

- meson
- valac
- debhelper
- gobject-2.0
- glib-2.0
- libgee-0.8-dev
- libgranite-dev  
- libxml2-dev  
- libgtk-3-dev  
- libhandy-1-dev  
- libwebp-dev  

Annotator를 소스에서 설치하려면 `./app install`을 실행하세요.  

Annotator를 실행하려면 `com.github.phase1geo.annotator`를 실행하세요.  

### 우분투 (PPA)  

@PandaJim이 관리하는 [PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/)를 사용할 수 있습니다. 이 PPA는 우분투 20.04 이상을 지원합니다. 다음 명령어를 하나씩 입력하세요.

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

또한, Annotator는 Flatpak을 통해 설치하고 실행할 수 있습니다.

소스에서 Flatpak을 빌드하고 설치하려면 `./app flatpak`을 실행하세요.

그 후, 다음 명령어로 실행할 수 있습니다: `flatpak run com.github.phase1geo.annotator`.

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="Get it on AppCenter"/>
  </a>
</p>

## 크레딧

`document-edit-symbolic.svg`와 `image-crop-symbolic.svg`를
[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic)에서 가져와,
GPL v3.0 라이선스 조건 하에 포함하고 있습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-24

---