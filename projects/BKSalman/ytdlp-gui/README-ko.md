# ytdlp-gui
Rust로 작성된 yt-dlp용 GUI

- [설치](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [기타 배포판](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [소스에서 빌드](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [설정](https://github.com/BKSalman/ytdlp-gui#configuration)
- [기여](https://github.com/BKSalman/ytdlp-gui#contribution)

# 미리보기
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# 설치
## 리눅스

### NixOS (Flake)
레포지토리 내 flake.nix를 사용할 수 있습니다

`flake.nix`에:
```nix
{
  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs/nixpkgs-unstable";

    ytdlp-gui = {
      url = "github:bksalman/ytdlp-gui";
    };
  };

    outputs = { nixpkgs, ytdlp-gui, ...}:
    let
      system = "x86_64-linux";

      pkgs = import nixpkgs {
        inherit system;
        overlays = [
          ytdlp-gui.overlay
        ];
      };
    in
    {
      ...snip
```

그 후 일반 패키지처럼 home-manager 또는 nixosConfiguration에 추가할 수 있습니다

### Fedora
릴리즈 페이지에서 rpm 패키지를 다운로드한 후 ``sudo dnf localinstall <rpm_package_name>``로 설치하세요

### Ubuntu
릴리즈 페이지에서 deb 패키지를 다운로드한 후 ``sudo apt install ./<deb_package_name>``로 설치하세요

### Arch

AUR [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)에서 사용 가능합니다

### 기타 배포판

#### 1- ``yt-dlp`` 다운로드
다음 중 하나를 선택하세요

&nbsp; &nbsp; &nbsp; a- 배포판 저장소에서 설치

&nbsp; &nbsp; &nbsp; b- 또는 [바이너리](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp)를 다운로드하여 bin 디렉토리로 이동시키고 `chmod +x <bin_file>`로 실행 권한을 부여

#### 2- 배포판 저장소에서 ``ffmpeg`` 또는 ``ffmpeg-free`` 설치


#### 3- [릴리즈 페이지](https://github.com/BKSalman/ytdlp-gui/releases)에서 ``ytdlp-gui`` 바이너리 다운로드

## Windows
##### 릴리즈 페이지에서 zip 파일을 다운로드하여 하위 폴더에 압축 해제 후 ``ytdlp-gui.exe`` 실행

# 소스에서 빌드
소스 빌드를 위해서는 `cargo`와 `rustc`가 필요하며, `rustup`(Rust 툴체인 매니저) 또는 배포판 저장소에서 설치할 수 있습니다

그 후 다음 명령어를 실행하세요:
```bash
# "ytdlp-gui" 폴더에 레포지토리 클론
git clone https://github.com/BKSalman/ytdlp-gui
# 폴더로 이동
cd ytdlp-gui
# 프로젝트 빌드
cargo build
# 또는 성능 향상을 위해 릴리즈 모드로 빌드
cargo build -r
```
바이너리는 `<project-root>/target/debug/ytdlp-gui` 또는 `<project-root>/target/release/ytdlp-gui`에 생성됩니다

직접 실행할 수도 있습니다:
```bash
# 프로젝트 루트에서
./target/release/ytdlp-gui
```

또는 cargo로 실행:
```bash
cargo r
# 릴리즈 모드
cargo r -r
```

# 설정

v0.2.2 이상부터 애플리케이션은 각 플랫폼/OS의 기본 설정 디렉토리에 ``<config_dir>/ytdlp-gui/config.toml`` 파일로 설정을 저장합니다

기본 파일은 다음과 같습니다:

```toml
# 선택 사항
# bin 자체가 아닌 bin 디렉토리 경로입니다
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) 설정하지 않으면 명령어는 `yt-dlp <app_args>`

# 선택 사항
download_folder = "<some_cool_path>" # 기본값 = "~/Videos"

[options]
video_resolution = "FullHD" # 옵션: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # 옵션: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # 옵션: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" # 옵션: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### 참고: 품질/포맷 옵션은 다운로드 버튼을 누르면 자동으로 저장됩니다

# 기여
모든 형태의 기여를 환영합니다. 풀 리퀘스트, 이슈(버그 리포트/기능 요청) 모두 환영합니다

다만 저는 다른 일에 집중하고 있어서 빠르게 답변하거나 요청한 내용을 바로 구현하지 못할 수 있습니다

하지만 최선을 다하겠습니다 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---