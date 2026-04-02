
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![문서](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![라이선스](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![Downloads](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (mock for future test.yaml)
[//]: # ([![Test Status]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

Rust로 작성된 이 애플리케이션은 컨테이너 이미지(Docker 등)를 Git 저장소로 변환하고, YAML 형식의 파일 시스템 명세서(fsbom)를 생성합니다. 각 컨테이너 레이어는 Git 커밋으로 표현되어, 원본 이미지의 히스토리와 구조를 보존합니다.

![OCI2Git가 nginx 이미지를 변환하는 데모](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## 주요 기능

- Docker 이미지를 분석하고 레이어 정보를 추출
- 각 이미지 레이어를 커밋으로 표현한 Git 저장소 생성
- 레이어별 파일 목록이 포함된 YAML 파일 시스템 명세서(fsbom) 생성
- 빈 레이어(ENV, WORKDIR 등)는 빈 커밋으로 지원
- Markdown 형식의 완전한 메타데이터 추출
- 다양한 컨테이너 엔진을 지원하기 위한 확장 가능한 아키텍처

## 활용 사례

### 레이어 비교
컨테이너 문제를 해결할 때, Git의 강력한 diff 기능을 사용해 두 레이어 간에 무엇이 변경되었는지 정확히 식별할 수 있습니다. 커밋 간 `git diff`를 실행하면, 엔지니어는 어떤 파일이 추가, 수정, 삭제되었는지 정확하게 볼 수 있어 각 Dockerfile 명령의 영향을 쉽게 이해하고 문제를 찾을 수 있습니다.
![레이어 차이 예시](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### 변경 원인 추적
`git blame`을 사용하면 개발자는 특정 파일이나 코드 라인이 어떤 레이어에서 도입되었는지 신속하게 확인할 수 있습니다. 이는 설정 파일이나 의존성 문제를 진단할 때 특히 유용합니다. 각 레이어를 수동으로 확인하지 않고도 모든 파일의 출처 레이어와 해당 Dockerfile 명령을 바로 추적할 수 있습니다.

### 파일 생애주기 추적
OCI2Git는 특정 파일이 컨테이너 이미지 내에서 어떻게 변화했는지 전체 과정을 따라갈 수 있게 해줍니다. 파일이 처음 생성된 시점, 레이어별로 어떻게 수정되었는지, 최종적으로 삭제되었는지 등을 관찰할 수 있어, 여러 레이어에 걸친 변경을 수동으로 추적하지 않아도 파일의 변천사를 쉽게 파악할 수 있습니다.

컨테이너 이미지 내 파일의 생성, 변경, 삭제 시점을 추적하려면 변환 후 다음과 같은 Git 명령을 사용할 수 있습니다:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```
이 명령어들은 컨테이너 레이어를 수동으로 추출하고 레이어 tarball을 비교하는 복잡함 없이도 파일의 전체 이력을 쉽게 추적할 수 있게 해줍니다.

### 다중 레이어 분석
때로는 가장 통찰력 있는 비교가 여러 비연속 레이어의 변화를 조사할 때 나옵니다. OCI2Git을 사용하면 Git의 비교 도구를 통해 여러 빌드 단계에 걸쳐 구성 요소가 어떻게 진화했는지 분석할 수 있으며, 인접 레이어만 볼 때는 보이지 않는 패턴을 식별할 수 있습니다.

### 레이어 탐색
`git checkout`을 사용해 특정 커밋으로 이동하면 해당 레이어에 존재했던 컨테이너 파일시스템을 정확히 검사할 수 있습니다. 이를 통해 개발자는 이미지 생성 과정의 어느 시점에 파일과 디렉토리의 정확한 상태를 확인할 수 있어, 디버깅이나 컨테이너 동작 검토 시 매우 유용한 컨텍스트를 제공합니다.
![이전 커밋으로 체크아웃](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### 다중 이미지 분석

공통 조상을 가진 여러 컨테이너 이미지를 작업할 때, OCI2Git은 이미지가 실제로 분기할 때만 지능적으로 브랜치를 생성합니다. 이를 통해 공통 이력을 보존하면서 단일 저장소에서 관련된 여러 이미지를 분석할 수 있습니다.


```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```

OCI2Git은 이미지 간의 공유 레이어를 자동으로 감지하고, 공통 기반을 반영하는 분기 구조를 생성합니다. Git 히스토리에는 다음이 표시됩니다:
- 모든 공유 레이어를 포함하는 공통 트렁크
- 이미지가 실제로 다를 때만 분기되는 개별 브랜치
- 이미지가 어디서 공통 조상을 공유하고 어디서 독립적으로 변하는지 명확한 시각화
- 스마트 중복 처리: 동일한 이미지를 두 번 처리할 경우, 알고리즘이 최종 메타데이터 커밋 전에 이를 감지하여 중복 브랜치 생성을 건너뜁니다

이 접근 방식은 특히 다음과 같은 경우에 유용합니다:
- **이미지 패밀리 분석**: 이미지의 다양한 변종(버전, 아키텍처, 구성)이 서로 어떻게 연결되어 있는지 이해
- **베이스 이미지 영향 분석**: 베이스 이미지의 변경이 여러 파생 이미지에 어떻게 영향을 미치는지 정확히 파악
- **최적화 기회 발굴**: 이미지 변종 간에 더 효과적으로 활용될 수 있는 공유 컴포넌트 식별

![공유 베이스 및 분기 브랜치를 보여주는 다중 이미지 저장소 구조](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### 추가 활용 사례

- **보안 감사**: 취약한 패키지나 설정이 정확히 언제 도입되었는지 식별하고, 특정 빌드 지침까지 추적
- **이미지 최적화**: 레이어 구조를 분석하여 중복 작업이나 대용량 파일을 찾아 통합함으로써 이미지 크기 축소
- **종속성 관리**: 이미지 히스토리 전반에 걸쳐 종속성이 언제 추가, 업그레이드, 제거되었는지 모니터링
- **빌드 프로세스 개선**: 레이어 구성을 검사하여 Dockerfile 지침을 최적화하고 캐싱 효율 및 이미지 크기 최소화
- **이미지 간 비교**: 여러 관련 이미지를 Git 저장소로 변환한 후 Git의 비교 도구로 차이점과 공통점을 분석

## 설치

### 패키지 관리자

#### macOS / Linux (Homebrew)

```bash
brew tap virviil/oci2git
brew install oci2git
```

#### Debian / Ubuntu

[최신 릴리스](https://github.com/virviil/oci2git/releases/latest)에서 .deb 패키지를 다운로드하여 설치하세요:

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### 아치 리눅스 (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### 미리 빌드된 바이너리

플랫폼에 맞는 바이너리를 [최신 릴리스](https://github.com/virviil/oci2git/releases/latest)에서 다운로드하세요:

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```
### Crates.io에서 가져오기


```bash
cargo install oci2git
```

### 소스에서

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

## 사용법

```
oci2git [OPTIONS] <IMAGE>
oci2git convert [OPTIONS] <IMAGE>
oci2git fsbom [OPTIONS] <IMAGE>
```

### `convert` — OCI 이미지 → Git 저장소

```bash
oci2git convert [OPTIONS] <IMAGE>
# or simply:
oci2git <IMAGE>
```
옵션:
  `-o, --output <OUTPUT>`  Git 저장소의 출력 디렉터리 [기본값: ./container_repo]
  `-e, --engine <ENGINE>`  사용할 컨테이너 엔진 (docker, nerdctl, tar) [기본값: docker]
  `-v, --verbose`          자세한 모드 (-v: 정보, -vv: 디버그, -vvv: 추적)

### `fsbom` — 파일 시스템 자재 명세서


```bash
oci2git fsbom [OPTIONS] <IMAGE>
```
옵션:
  `-o, --output <OUTPUT>`  YAML BOM 파일의 출력 경로 [기본값: ./fsbom.yml]
  `-e, --engine <ENGINE>`  사용할 컨테이너 엔진 (docker, nerdctl, tar) [기본값: docker]
  `-v, --verbose`          자세한 모드 (-v: 정보, -vv: 디버그, -vvv: 트레이스)

환경 변수:
  `TMPDIR`  이 환경 변수를 설정하여 중간 데이터 처리를 위한 기본 위치를 변경할 수 있습니다. 이는 플랫폼에 따라 다릅니다 (예: Unix/macOS에서는 `TMPDIR`, Windows에서는 `TEMP` 또는 `TMP`).

## 예제

### 변환

Docker 엔진 사용(기본값):

```bash
oci2git ubuntu:latest
# or explicitly:
oci2git convert ubuntu:latest -o ./ubuntu-repo
```

이미 다운로드된 이미지 tarball 사용:
```bash
oci2git convert -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```
tar 엔진은 일반적으로 `docker save`로 생성된 유효한 OCI 형식의 tarball을 예상합니다:

```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git convert -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

이 명령은 `./ubuntu-repo`에 Git 저장소를 생성하며, 다음을 포함합니다:
- `Image.md` - 이미지에 대한 전체 메타데이터가 Markdown 형식으로 저장됨
- `rootfs/` - 컨테이너의 파일 시스템 내용

Git 히스토리는 컨테이너의 레이어 히스토리를 반영합니다:
- 첫 번째 커밋에는 전체 메타데이터가 담긴 `Image.md` 파일만 포함됩니다
- 이후 각 커밋은 원본 이미지의 각 레이어를 나타냅니다
- 커밋 메시지에는 Dockerfile 명령어가 포함됩니다

### 파일 시스템 자재 명세서 (fsbom)

각 레이어별로 추가되거나 수정된 모든 파일을 YAML로 나열합니다:
```bash
oci2git fsbom ubuntu:latest -o ubuntu.yml
```

tarball 사용하기:
```bash
oci2git fsbom -e tar image.tar -o image-bom.yml
```
출력 YAML은 각 레이어를 나열하며, 각 항목은 타입(`file`, `hardlink`, `symlink`, `directory`)과 상태(`n:uid:gid`는 신규, `m:uid:gid`는 수정됨)로 태그가 지정됩니다.
삭제된 파일(OCI 화이트아웃)은 제외됩니다.

```yaml
layers:
  - index: 0
    command: "ADD rootfs.tar.gz / # buildkit"
    digest: "sha256:45f3ea58..."
    entries:
      - type: file
        path: "bin/busybox"
        size: 919304
        mode: 493
        stat: "n:0:0"
      - type: hardlink
        path: "bin/sh"
        target: "bin/busybox"
        stat: "n:0:0"
      - type: symlink
        path: "lib64"
        target: "lib"
        stat: "n:0:0"
  - index: 1
    command: "RUN apk add --no-cache curl"
    digest: "sha256:..."
    entries:
      - type: file
        path: "usr/bin/curl"
        size: 204800
        mode: 493
        stat: "n:0:0"
      - type: file
        path: "etc/apk/world"
        size: 32
        mode: 420
        stat: "m:0:0"
```

## 저장소 구조

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
  
## 요구 사항

- Rust 2021 에디션
- Docker CLI (Docker 엔진 지원용)
- Git

## 라이선스

MIT

[documentation]: https://docs.rs/oci2git/



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---