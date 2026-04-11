# <img src="https://github.com/user-attachments/assets/b81b9503-948e-4cba-b0a1-f5f809588aad" width="48"> SwitchWave
닌텐도 스위치를 위한 하드웨어 가속 미디어 플레이어로, mpv와 FFmpeg를 기반으로 제작되었습니다.

## 기능
- FFmpeg용 맞춤 하드웨어 가속 백엔드, 동적 주파수 조절 기능 포함. 다음 코덱을 디코딩할 수 있습니다:
    - MPEG1/2/4
    - VC1
    - H.264/AVC (하드웨어에서 10비트 이상 미지원)
    - H.265/HEVC (하드웨어에서 12비트 이상 미지원)
    - VP8
    - VP9 (하드웨어에서 10비트 이상 미지원)
- [deko3d](https://github.com/devkitPro/deko3d)를 사용한 mpv용 맞춤 그래픽 백엔드, 지원 내용:
    - 4k60fps 재생
    - 직접 렌더링 (더 빠른 소프트웨어 디코딩)
    - 맞춤 후처리 셰이더
- 닌텐도 네이티브 API를 사용한 mpv용 맞춤 오디오 백엔드, 최대 5.1 서라운드 레이아웃 지원
- HTTP/S, Samba, NFS 또는 SFTP를 통한 네트워크 재생 지원
- [libusbhsfs](https://github.com/DarkMatterCore/libusbhsfs)를 이용한 외장 드라이브 지원
- 부하가 심한 상황에서도 풍부하고 반응성 좋은 사용자 인터페이스 제공

## 스크린샷

<p float="center">
    <img src="https://github.com/user-attachments/assets/09aed446-148a-4276-8b07-336890c224a3" width="413" />
    <img src="https://github.com/user-attachments/assets/6e354511-47bc-4898-881c-348d5a9e6fbc" width="413" />
    <img src="https://github.com/user-attachments/assets/b86eb7c6-4229-46c6-8709-86d1a6ee8eed" width="413" />
    <img src="https://github.com/user-attachments/assets/70f4be3e-fa1e-434a-b76c-4fb6b671f80e" width="413" />
</p>

## 설치
- [최신 릴리즈](https://github.com/averne/SwitchWave/releases/latest)를 다운로드한 후, SD 카드 루트에 압축을 풉니다 (폴더를 덮어쓰지 않고 병합되도록 주의하세요)
- 네트워크 공유는 앱 내에서 설정할 수 있으며, mpv 설정도 내장 편집기를 통해 조정할 수 있습니다 ([매뉴얼](https://mpv.io/manual/master/) 참고)
- 대부분의 실행 시간 매개변수는 재생 중 메뉴에서 동적으로 조정 가능하며, 불가능할 경우 콘솔에서 조정할 수 있습니다 ([매뉴얼](https://mpv.io/manual/master/#console))

## 빌드

### 도커 (권장)
```sh
./build-docker.sh
```
이것은 툴체인 이미지를 빌드하고 모든 것을 자동으로 컴파일합니다. 출력물은 `build/`에 있습니다.

기본 GIMP 2 대신 GIMP 3으로 빌드하려면:
```sh
GIMP_VERSION=3 ./build-docker.sh
```
### 매뉴얼
- Switch 홈브류 개발을 위해 [devkitpro](https://devkitpro.org/wiki/devkitPro_pacman) 환경을 설정합니다.
- 다음 패키지를 설치합니다: `switch-bzip2`, `switch-dav1d`, `switch-freetype`, `switch-glm`, `switch-harfbuzz`, `switch-libarchive`, `switch-libass`, `switch-libfribidi`, `switch-libjpeg-turbo`, `switch-libpng`, `switch-libwebp`, `switch-curl`, `switch-libssh2`, `switch-mbedtls`, `switch-ntfs-3g` 및 `switch-lwext4`. 추가로 다음 빌드 의존성이 필요합니다: `switch-pkg-config`, `dkp-meson-scripts`, `dkp-toolchain-vars`, 그리고 [GIMP](https://www.gimp.org/) (2 또는 3).
- [libusbhsfs](https://github.com/DarkMatterCore/libusbhsfs)의 GPL 빌드를 컴파일하고 설치합니다.
- [libsmb2](misc/libsmb2/)와 [libnfs](misc/libnfs/)를 컴파일하고 설치합니다.
- FFmpeg를 구성, 컴파일 및 설치합니다: `make configure-ffmpeg && make build-ffmpeg -j$(nproc)`.
- libuam을 구성, 컴파일 및 설치합니다: `make configure-uam && make build-uam`.
- mpv를 구성, 컴파일 및 설치합니다: `make configure-mpv && make build-mpv`.
- 마지막으로, 메인 애플리케이션을 컴파일하고 릴리스 배포판을 빌드합니다: `make dist -j$(nproc)`.
- 출력 결과는 `build/`에서 확인할 수 있습니다.

## 크레딧
- 스크린샷 버튼 오버라이딩 방법에 대해 [Behemoth](https://github.com/HookedBehemoth)에게 감사드립니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---