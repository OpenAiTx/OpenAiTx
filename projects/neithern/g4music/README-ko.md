<img align="left" alt="프로젝트 로고" src="https://raw.githubusercontent.com/neithern/g4music/master/data/icons/hicolor/scalable/apps/app.svg" />

# Gapless
우아하게 음악을 재생하세요.

<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/window.png" width="1134"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/albums.png" width="1134"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/playing.png" width="462"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/playlist.png" width="466"/>

Gapless (일명: G4Music)는 GTK4로 작성된 경량 음악 플레이어로, 대용량 음악 컬렉션에 중점을 둡니다.

## 기능
- 대부분의 음악 파일 형식, Samba 및 기타 원격 프로토콜 지원(GIO 및 GStreamer에 의존).
- 수천 개의 음악 파일을 몇 초 만에 빠르게 로드 및 파싱하며, 로컬 변경사항 모니터링.
- 앨범 커버(내장 및 외부)를 포함한 대용량 음악 컬렉션에 낮은 메모리 사용, 썸네일 캐시 미사용.
- 앨범/아티스트/제목별 그룹화 및 정렬, 리스트 셔플, 전체 텍스트 검색.
- 다양한 화면(데스크탑, 태블릿, 모바일)에 유연하게 적응하는 사용자 인터페이스.
- 가우시안 블러 처리된 커버를 배경으로 사용하며, GNOME 라이트/다크 모드에 따라 변경.
- 재생목록 생성 및 편집 지원, 커버 드래그로 순서 변경 또는 다른 재생목록에 추가 가능.
- 다른 앱과의 드래그 앤 드롭 지원.
- 오디오 피크 시각화 지원.
- 갭리스 재생 지원.
- ReplayGain으로 볼륨 정규화 지원.
- 지정된 오디오 싱크 지원.
- MPRIS 제어 지원.

## Flathub에서 설치
<a href="https://flathub.org/apps/com.github.neithern.g4music">
<img src="https://flathub.org/assets/badges/flathub-badge-en.png" width="240"/></a>

## Snapcraft에서 설치 (비공식)
<a href="https://snapcraft.io/g4music">
<img alt="Snap 스토어에서 받기" src="https://camo.githubusercontent.com/ab077b20ad9938c23fbdac223ab101df5ed27329bbadbe7f98bfd62d5808f0a7/68747470733a2f2f736e617063726166742e696f2f7374617469632f696d616765732f6261646765732f656e2f736e61702d73746f72652d626c61636b2e737667" data-canonical-src="https://snapcraft.io/static/images/badges/en/snap-store-black.svg" width="240" style="max-width: 100%;"> 

## FreeBSD 의존성

```bash
pkg install vala meson libadwaita gstreamer1-plugins-all gettext gtk4
```
## 빌드 방법 
Vala로 작성되었으며, 간단하고 깔끔한 코드로, 서드파티 의존성이 적습니다:

1. gitlab에서 코드를 클론합니다.
2. vala, gtk4 개발 패키지, libadwaita, gstreamer를 설치합니다.
3. 프로젝트 디렉토리에서 실행합니다:

    `meson setup build --buildtype=release`

    `meson install -C build`

## 변경 기록
변경 기록은 [릴리스 태그](https://gitlab.gnome.org/neithern/g4music/-/tags)를 확인하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-05

---