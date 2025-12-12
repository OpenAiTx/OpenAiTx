
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
[![다운로드](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (향후 test.yaml을 위한 목업)
[//]: # ([![테스트 상태]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

컨테이너 이미지(Docker 등)를 Git 저장소로 변환하는 Rust 애플리케이션입니다. 각 컨테이너 레이어는 Git 커밋으로 표현되어 원본 이미지의 히스토리와 구조를 보존합니다.

![OCI2Git가 nginx 이미지를 변환하는 데모](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## 특징

- Docker 이미지를 분석하고 레이어 정보를 추출
- 각 이미지 레이어를 커밋으로 표현하는 Git 저장소 생성
- 빈 레이어(ENV, WORKDIR 등)를 빈 커밋으로 지원
- 메타데이터를 완전히 추출하여 Markdown 형식으로 변환
- 다양한 컨테이너 엔진 지원을 위한 확장 가능한 아키텍처

## 사용 사례

### 레이어 디프(Layer Diffing)
컨테이너 문제를 해결할 때, Git의 강력한 diff 기능을 사용하여 두 레이어 사이에 정확히 어떤 변화가 있었는지 식별할 수 있습니다. 커밋 간에 `git diff`를 실행하면 엔지니어는 어떤 파일이 추가, 수정, 삭제되었는지 정확히 볼 수 있어 각 Dockerfile 명령의 영향과 문제의 원인을 쉽게 파악할 수 있습니다.
![레이어 디프 예시](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### 변경 출처 추적(Origin Tracking)
`git blame`을 사용하면 개발자는 특정 파일이나 코드 라인이 어떤 레이어에서 도입되었는지 빠르게 확인할 수 있습니다. 이는 설정 파일이나 의존성 문제를 진단할 때 특히 유용합니다. 각 레이어를 수동으로 확인할 필요 없이 모든 파일의 출처를 즉시 해당 레이어와 Dockerfile 명령으로 추적할 수 있습니다.

### 파일 생애주기 추적(File Lifecycle Tracking)
OCI2Git을 사용하면 컨테이너 이미지의 히스토리에서 특정 파일이 어떻게 변화하는지 전체 과정을 추적할 수 있습니다. 파일이 처음 생성된 시점, 각 레이어에서 어떻게 수정되었는지, 그리고 언제 삭제되었는지를 모두 관찰할 수 있어 수십 개의 레이어에서 수동으로 변경 내역을 추적하지 않아도 파일의 진화를 한눈에 파악할 수 있습니다.

컨테이너 이미지에서 파일의 히스토리를 추적하고(처음 등장, 변경, 삭제 시점 포함) 변환 이후에 다음 Git 명령어로 확인할 수 있습니다:

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
OCI2Git는 이미지 간에 공유되는 레이어를 자동으로 감지하고 공통 기반을 반영하는 분기 구조를 생성합니다. Git 기록은 다음을 보여줍니다:
- 모든 공유 레이어를 포함하는 공통 줄기
- 이미지가 실제로 다를 때만 분기되는 별도의 브랜치
- 이미지가 공통 조상을 공유하는 부분과 고유해지는 부분을 명확하게 시각화
- 스마트 중복 처리: 동일한 이미지가 두 번 처리되면 알고리즘이 최종 메타데이터 커밋 전에 이를 감지하고 중복 브랜치 생성을 건너뜀

이 접근법은 다음에 특히 유용합니다:
- **이미지 패밀리 분석**: 이미지의 다양한 변형(버전, 아키텍처 또는 구성) 간의 관계 이해
- **기본 이미지 영향 분석**: 기본 이미지 변경이 여러 파생 이미지에 미치는 영향 정확히 파악
- **최적화 기회 탐색**: 이미지 변형 간에 더 잘 활용할 수 있는 공유 구성 요소 식별

![공유 기반과 갈라지는 브랜치를 보여주는 다중 이미지 저장소 구조](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### 추가 사용 사례

- **보안 감사**: 취약한 패키지나 구성이 도입된 시점을 정확히 파악하고 특정 빌드 명령으로 추적
- **이미지 최적화**: 레이어 구조 분석을 통해 중복 작업이나 통합할 수 있는 큰 파일 발견, 이미지 크기 감소에 도움
- **종속성 관리**: 이미지 기록 전반에 걸쳐 종속성이 추가, 업그레이드 또는 제거된 시점 모니터링
- **빌드 프로세스 개선**: 레이어 구성을 검토하여 더 나은 캐싱 및 작은 이미지 크기를 위한 Dockerfile 명령 최적화
- **이미지 간 비교**: 여러 관련 이미지를 Git 저장소로 변환하고 Git의 비교 도구를 사용해 차이점과 공통점을 분석

## 설치

### 소스에서 설치하기


```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```
### Crates.io에서 가져오기


```bash
cargo install oci2git
```

## 사용법

```bash
oci2git [OPTIONS] <IMAGE>
```
Arguments:
  `<IMAGE>`  변환할 이미지 이름 (예: 'ubuntu:latest') 또는 tar 엔진 사용 시 tarball 경로

Options:
  `-o, --output <o>`  Git 저장소의 출력 디렉토리 [기본값: ./container_repo]
  `-e, --engine <ENGINE>`  사용할 컨테이너 엔진 (docker, nerdctl, tar) [기본값: docker]
  `-h, --help`            도움말 정보 출력
  `-V, --version`         버전 정보 출력

Environment Variables:
  `TMPDIR`  중간 데이터 처리를 위한 기본 위치를 변경하려면 이 환경 변수를 설정하세요. 플랫폼에 따라 다릅니다(예: Unix/macOS는 `TMPDIR`, Windows는 `TEMP` 또는 `TMP`).

## Examples

Using Docker engine (default):

```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

이미 다운로드된 이미지 tarball 사용:
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```
tar 엔진은 일반적으로 `docker save`로 생성된 유효한 OCI 형식의 tarball을 예상합니다:

```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

이 명령은 `./ubuntu-repo`에 Git 저장소를 생성하며 다음을 포함합니다:
- `Image.md` - 이미지에 대한 완전한 메타데이터를 Markdown 형식으로 작성
- `rootfs/` - 컨테이너에서 가져온 파일 시스템 내용

Git 히스토리는 컨테이너의 레이어 히스토리를 반영합니다:
- 첫 번째 커밋은 전체 메타데이터가 포함된 `Image.md` 파일만 포함
- 이후 각 커밋은 원본 이미지의 한 레이어를 나타냄
- 커밋 메시지에는 Dockerfile 명령어가 포함됨

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-12

---