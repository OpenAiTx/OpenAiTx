# @343dev/optimizt

<img align="right" width="176" height="176"
     alt="Optimizt 로고: 손가락 사이에 모나리자 이미지가 있는 OK 손 모양"
     src="https://raw.githubusercontent.com/343dev/optimizt/main/./docs/logo.png">

[![npm](https://img.shields.io/npm/v/@343dev/optimizt.svg)](https://www.npmjs.com/package/@343dev/optimizt)
[![Docker](https://img.shields.io/docker/v/343dev/optimizt?label=Docker)](https://hub.docker.com/r/343dev/optimizt)

**Optimizt**는 웹용 이미지를 준비하는 데 도움을 주는 커맨드라인 도구입니다.

PNG, JPEG, GIF, SVG를 손실 또는 무손실로 압축할 수 있으며, 래스터 이미지에 대해 AVIF 및 WebP 버전을 생성할 수 있습니다.

## 배경

프론트엔드 개발자로서 우리는 이미지에 신경 써야 합니다: PNG와 JPEG 압축, SVG의 불필요한 부분 제거, 최신 브라우저용 AVIF 및 WebP 생성 등. 어느 날 우리는 여러 앱을 사용하는 것에 지쳐서 우리가 원하는 모든 작업을 수행하는 하나의 도구를 만들었습니다.

## 사용법

설치:

```sh
npm install -g @343dev/optimizt
```
최적화하세요!


```sh
optimizt path/to/picture.jpg
```
## 명령줄 플래그

- `--avif` — 이미지의 AVIF 버전을 생성합니다.
- `--webp` — 이미지의 WebP 버전을 생성합니다.
- `-f, --force` — 이미 존재하는 경우에도 AVIF 및 WebP 버전을 다시 생성합니다.
- `-l, --lossless` — 손실 압축 대신 무손실로 최적화합니다.
- `-v, --verbose` — 자세한 출력을 표시합니다 (예: 건너뛴 파일).
- `-c, --config` — 기본 설정 파일 대신 사용자 지정 구성 파일을 사용합니다.
- `-o, --output` — 결과를 지정된 디렉터리에 작성합니다.
- `-p, --prefix` — 최적화된 파일 이름에 접두사를 추가합니다.
- `-s, --suffix` — 최적화된 파일 이름에 접미사를 추가합니다.
- `-V, --version` — 도구 버전을 표시합니다.
- `-h, --help` — 도움말 메시지를 표시합니다.

## 사용 예시


```bash
# optimize a single image
optimizt path/to/picture.jpg

# optimize multiple images losslessly
optimizt --lossless path/to/picture.jpg path/to/another/picture.png

# recursively create AVIF and WebP versions for all images in a directory
optimizt --avif --webp path/to/directory

# recursively optimize JPEG files in the current directory
find . -iname \*.jpg -exec optimizt {} +
```
## 손실 압축과 무손실 압축의 차이점

### 손실 압축 (기본값)

파일 크기 감소와 시각적 품질 손실 최소화 사이의 최적 균형을 제공합니다.

### 무손실 압축 (`--lossless` 플래그)

- **AVIF/WebP**: 무손실 압축을 사용합니다.
- **PNG/JPEG/GIF**: 더 큰 파일 크기를 감수하고 이미지 품질을 최대화합니다.
- **SVG**: 두 모드에서 설정이 동일합니다.

## 구성

이미지 처리는 다음을 활용합니다:

- [sharp](https://github.com/lovell/sharp) - [JPEG](https://sharp.pixelplumbing.com/api-output#jpeg), [PNG](https://sharp.pixelplumbing.com/api-output#png), [WebP](https://sharp.pixelplumbing.com/api-output#webp), [AVIF](https://sharp.pixelplumbing.com/api-output#avif)용.
- [svgo](https://github.com/svg/svgo) - SVG용.
- [gifsicle](https://github.com/kohler/gifsicle) - GIF용.

> [!NOTE]
> JPEG 무손실 모드에서는 [Guetzli](https://github.com/google/guetzli)를 사용합니다. 반복 최적화는 시각적 품질을 저하시킬 수 있습니다.

기본 설정은 모든 지원 매개변수를 포함하는 [.optimiztrc.cjs](./.optimiztrc.cjs)에 정의되어 있습니다. 매개변수를 `false`로 설정하여 비활성화할 수 있습니다.

`--config path/to/.optimiztrc.cjs`를 사용할 경우 지정된 구성 파일이 사용됩니다. `--config`가 없으면 Optimizt가 현재 디렉터리부터 상위로 `.optimiztrc.cjs`를 재귀적으로 검색합니다. 찾지 못하면 기본값이 적용됩니다.

## 문제 해결

### “spawn guetzli ENOENT”와 같은 오류

[npm 옵션 ignore-scripts](https://docs.npmjs.com/cli/v6/using-npm/config#ignore-scripts)가 비활성화되어 있는지 확인하세요.  
상세정보: [funbox/optimizt/issues/9](https://github.com/funbox/optimizt/issues/9).

## 도커

### 사전 빌드 이미지


```bash
# pull latest
docker pull 343dev/optimizt

# pull specific version
docker pull 343dev/optimizt:9.0.2
```

### 수동 빌드

```bash
# clone repository
git clone https://github.com/343dev/optimizt.git
cd optimizt

# build image
docker build --tag 343dev/optimizt .
```

또는:

```bash
# build directly from GitHub
# ignores .dockerignore (see: https://github.com/docker/cli/issues/2827)
docker build --tag 343dev/optimizt https://github.com/343dev/optimizt.git
```

### 컨테이너 실행

```bash
# mount current directory to /src in the container
docker run --rm --volume $(pwd):/src 343dev/optimizt --webp ./image.png
```
## 통합

Optimizt는 다음과 원활하게 작동합니다:

- [JetBrains IDEs](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/jetbrains.md)
- [Visual Studio Code](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/vscode.md)
- [Sublime Text 3](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/sublime-text.md)
- [GitHub Actions Workflow](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/github.md)

## 기사

- [anuwong.com](https://anuwong.com/blog/2023-08-21-save-tons-of-gbs-with-optimizt/) — 업로드 전 파일 압축, 수십 GB 절약. 🇹🇭
- [Linux Format, Issue 277 (2021년 7월)](https://www.linuxformat.com/archives?issue=277#:~:text=Kitchen%20Tales%2C%20zFRAG%2C-,Optimizt,-and%20SingleFileZ.) — Optimizt는 품질 저하 없이 이미지의 디스크 공간을 줄이기에 이상적입니다.

## 크레딧

프로젝트용 귀여운 그림은 [Igor Garybaldi](http://pandabanda.com/)가 제작했습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-07

---