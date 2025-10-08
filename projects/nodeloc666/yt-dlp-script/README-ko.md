
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 yt-dlp 동영상 일괄 다운로드 도구 (Windows / Linux 지원)

> [yt-dlp](https://github.com/yt-dlp/yt-dlp) 기반의 원클릭 동영상 다운로드 스크립트입니다. [NodeSeek 고수의 공유](https://www.nodeseek.com/post-334093-2#15)에서 영감을 받았습니다.
> 단일 동영상 및 일괄 다운로드를 지원하며, Windows와 주요 Linux 배포판(Debian / Ubuntu / Alpine / CentOS)과 호환됩니다.

---

## ✨ 기능 특징

* 📥 **원클릭 실행**: 별도의 수동 설정 없이 안내에 따라 입력하면 바로 다운로드 시작
* 🍪 **커스텀 쿠키 지원**: 로그인 후 다운로드가 필요한 영상에 사용 가능(⚠️ 본 기능은 아직 검증되지 않았으며 버그가 있을 수 있음)
* 📂 **커스텀 출력 폴더 지원**: 원하는 폴더에 쉽게 저장 가능
* 📃 **일괄 다운로드 지원**: `urls.txt` 파일의 링크를 자동으로 읽어 다운로드
* ⚙️ **의존성 자동 설치**: Linux 환경에서 `yt-dlp`와 `ffmpeg`를 자동 설치

---

## 🖼️ 스크린샷 미리보기

| 예시 1                                                                   | 예시 2                                                                   |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![예시 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![예시 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![예시 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![예시 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Windows 사용 방법

1. 다음 파일을 다운로드합니다:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` Windows 버전](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. 압축 해제 후 아래 파일들을 동일한 폴더(예: `yt-dlp` 폴더)에 넣습니다:

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat`(스크립트 파일)

3. `yt-dlp.bat`를 더블클릭하여 실행 후 안내에 따라 영상을 다운로드합니다.
4. config/config.ini 파일을 편집하여 기본 설정을 수정합니다.

---

## 🐧 Linux 사용 방법(과학lion님의 최신 스크립트에도 동일 기능이 통합되어 있음)

**지원 시스템**: Debian / Ubuntu / Alpine / CentOS

원클릭 배포 또는 업데이트 후 실행:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```

제거하려면：

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Android 사용 추천

1. [Seal](https://github.com/JunkFood02/Seal) 앱을 사용하여 Android에서 `yt-dlp` 기능을 체험하세요.
2. termux에서 Debian을 설치해도 다운로드가 가능하지만, 굳이 사용할 필요 없이 Seal이 매우 편리합니다.

---

## ⚠️ 주의사항

1. **일괄 다운로드 모드**: 스크립트는 현재 디렉터리의 `config\urls.txt` 파일을 자동으로 읽으며, 각 줄에 하나씩 영상 링크를 입력합니다. 파일이 없으면 자동으로 생성됩니다.
2. **자원 사용 안내**: 메모리가 적은 장치는 여러 개의 대용량 영상을 동시에 다운로드하거나 너무 높은 동시 실행 스레드를 설정하지 마세요.
3. **CentOS 특별 안내**: 환경이 다소 특수하여 아직 완전한 테스트가 이루어지지 않았으니, 비생산 환경에서 사용을 권장합니다. 그 외 주요 시스템은 모두 검증되었습니다.
4. Linux 버전 소소한 버그: 스크립트가 홈 페이지까지 실행되면 한 번 의존성을 검사하는데, 코드가 실행되면 된다는 원칙으로 귀찮아서 수정하지 않았습니다.
5. Windows 버전 소소한 버그: 다른 페이지에서 홈으로 돌아와 선택할 때 기본 옵션이 무효화되고 루프가 걸릴 수 있습니다. 능력 부족으로 제대로 고치지 못했습니다.
해결 방법 두 가지:
    1. 종료 후 다시 실행
    2. 기본값을 사용하지 말고 숫자로 선택하세요

---

## 📄 라이선스

본 프로젝트는 [MIT License](https://opensource.org/licenses/MIT)를 따릅니다.

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---