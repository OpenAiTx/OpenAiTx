# Plasma6 셰이더 배경화면 플러그인

**셰이더 배경화면**은 KDE 데스크탑을 위한 동적 셰이더 기반 배경화면을 가능하게 하는 Plasma6 배경화면 플러그인입니다.

---

> **Plasma5 사용자 참고:**\
> 호환성을 위해 [Plasma5 브랜치](https://github.com/y4my4my4m/kde-shader-wallpaper/tree/plasma5)를 참조하십시오.

---

## 기능

- 사용자 정의 셰이더를 데스크탑 배경화면으로 실행
- 간편한 설치, 업그레이드 및 제거
- Plasma6 완전 지원
- 빈번한 기능 업데이트 및 버그 수정을 통한 지속적 개발

### 참고

다음은 OLED 친화적인 몇 가지 셰이더입니다:
```
Grey_Liquid
HSV_to_RGB
RGB_Noise_in_Movement
Raymarching_Basic
VDJ.frag
Wiggle_Worm
```
---

## 설치

### 소스에서 설치

1. **저장소를 클론합니다:**

   ```bash
   git clone https://github.com/y4my4my4m/kde-shader-wallpaper.git
   ```

2. **이전 설치 제거:**

   ```bash
   rm -rf ~/.local/share/plasma/wallpapers/online.knowmad.shaderwallpaper/
   ```

3. **패키지 설치:**

   ```bash
   kpackagetool6 -t Plasma/Wallpaper -i kde-shader-wallpaper/package
   ```

### 업그레이드

```bash
kpackagetool6 -t Plasma/Wallpaper --upgrade kde-shader-wallpaper/package
```

### 제거

KDE 데스크탑 설정을 통해 제거하거나, 다음 명령어를 실행할 수 있습니다:

```bash
kpackagetool6 -t Plasma/Wallpaper --remove online.knowmad.shaderwallpaper
```

---

## 개발자 가이드

커스텀 셰이더를 만들거나 기여하려면, [개발자 가이드](https://raw.githubusercontent.com/y4my4my4m/kde-shader-wallpaper/master/README_DEV.md)를 읽어주세요.

---

## 저장소 & 지원

- **GitHub:** [y4my4my4m/kde-shader-wallpaper](https://github.com/y4my4my4m/kde-shader-wallpaper)
- **KDE 스토어:** [Plasma6 버전](https://store.kde.org/p/2143912)
- **KDE 스토어:** [Plasma5 버전](https://store.kde.org/p/1413010/)
- **트위터 (X):** [@y4my4my4m](https://twitter.com/y4my4my4m)

문제, 풀 리퀘스트 또는 일반 문의는 [GitHub Issues](https://github.com/y4my4my4m/kde-shader-wallpaper/issues) 또는 트위터를 통해 연락해주세요.

---

## 참고 사항

- GUI 기반 셰이더 커스터마이징은 향후 버전에서 다시 제공될 예정입니다.
- 셰이더 컴파일 요구사항으로 인해 Plasma6 버전에서는 현재 Shadertoy.com 임포트가 지원되지 않습니다.
- 성능은 하드웨어와 셰이더 복잡성에 따라 다를 수 있으나, 대부분의 셰이더는 리소스 효율적입니다.
- 셰이더 파일 편집 후에는 KDE Wallpaper QtQuick 앱을 재시작하세요 (`pkill plasmashell` 명령어 사용 후 재시작).

---

## 동영상:

### VirtualBox에서 iGPU (및 kvantum) 사용 v1.2:

[![ShaderWallpaperVideoPreviewV1.2](https://cdn-cf-east.streamable.com/image/1g7muc_first.jpg?Expires=1599641820&Signature=kBzPch9XeiD3AieRh4sXd84JdQIknV2KK1m~w7KtXcO-5LH~JCeG8Wngq2p45Z521BWfd2jxpaujTV3618h91u4EnBSzMDRskpxPuSQ4x9uihB0gQ7u4OZjfLt3g-dXLa69Vh6V8~NCDuqo6v3G24vlQND-GArKa~lDPQvnNj2qt-cOIuFLyO0cBwJG4MTu-9C2zOe2wjR2s-cj8IAi4PweeMpJqeKZepDpe9grl8Wry8s3ahP9hZfUyCBs53LnWsEbfe2Ze01j6Bo07gXXb5rAQXYvfI7WxIDX2S7L5f33OxxJNxa4v1Jeg-aAsrW9Ij-86b9qtfsjN1IE6wUOzpQ__&Key-Pair-Id=APKAIEYUVEN4EVB2OKEQ)](https://streamable.com/1g7muc)

### v1.0:
[![ShaderWallpaperVideoPreviewV1.0](https://cdn-cf-east.streamable.com/image/yeqam9.jpg?Expires=1599641220&Signature=NCZXLhg5owCeCiBx8wg7FIO2oOZ~6y9b-we72JE0icG9Cw649dYPPRqDzuOnXsvOEe0omZhhlckbcdLZg6QKbMm9R6UUkN3g-hs4Y8WAJcWIXrantAsWlg309a2vu-gIkHV06eOYczdC3BBzprRHLh8BuKGRQyIAvxLYyf25mWexhPVrZHvrXsl-PFWN1tH~LLL14vD1oaoysupJxnF26qLVv1nAGB-AzYn7GVAcnJmpOPUbKz~jl2Z6iWy1fgJYu~Dym5Hxphc21-XIOHSqXYjkZFDslyevRJVcfqAsnfOzsm3GwRmBQ8hYB5wO5lpp4DnAUuDjtzY9d5sB025U0Q__&Key-Pair-Id=APKAIEYUVEN4EVB2OKEQ)](https://streamable.com/yeqam9)

---

### Screenshots:

[![ShaderWallpaperPreviewImage](https://images.pling.com/img/00/00/58/32/49/1413010/ef67e0df43137d0d42b81afe700e83aa9cf2c911ab4619aa6ba072894a404c658546.png)](https://images.pling.com/img/00/00/58/32/49/1413010/ef67e0df43137d0d42b81afe700e83aa9cf2c911ab4619aa6ba072894a404c658546.png)

[![ShaderWallpaperPreviewImage2](https://images.pling.com/img/00/00/58/32/49/1413010/95ec8cf5ca97eac0504faa68b297355964a9c6d4e1e1e161609997356b9a6d75fe6d.png)](https://images.pling.com/img/00/00/58/32/49/1413010/95ec8cf5ca97eac0504faa68b297355964a9c6d4e1e1e161609997356b9a6d75fe6d.png)

[![ShaderWallpaperPreviewImage3](https://images.pling.com/img/00/00/58/32/49/1413010/67b57155b2a2a2cd63f6d5545af2f6da3f5298c081c5ab05a72f6c17aa56aee79afd.png)](https://images.pling.com/img/00/00/58/32/49/1413010/67b57155b2a2a2cd63f6d5545af2f6da3f5298c081c5ab05a72f6c17aa56aee79afd.png)

[![ShaderWallpaperPreviewImage4](https://images.pling.com/img/00/00/58/32/49/1413010/b5026604b9009c3541e25b98bbaa0450d17a52ceee878f8b44383bb5e3570c3f251d.png)](https://images.pling.com/img/00/00/58/32/49/1413010/b5026604b9009c3541e25b98bbaa0450d17a52ceee878f8b44383bb5e3570c3f251d.png)

---

## Donations:
[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I525V5R)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---