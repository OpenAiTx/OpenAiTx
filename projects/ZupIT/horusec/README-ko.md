<p align="center" margin="20 0"><a href="https://horusec.io/">
    <img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec_logo.png" alt="logo_header" width="65%" style="max-width:100%;"/></a></p>

<p align="center">
    <a href="https://github.com/ZupIT/horusec/releases" alt="version">
        <img src="https://img.shields.io/github/v/release/ZupIT/horusec?label=version"/></a>
    <a href="https://github.com/ZupIT/horusec/pulse" alt="activity">
        <img src="https://img.shields.io/github/commit-activity/m/ZupIT/horusec?label=activity"/></a>
    <a href="https://github.com/ZupIT/horusec/graphs/contributors" alt="contributors">
        <img src="https://img.shields.io/github/contributors/ZupIT/horusec?label=contributors"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/lint.yml" alt="lint">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Lint?label=lint"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/test.yml" alt="test">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Test?label=test"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/security.yml" alt="security">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Security?label=security"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/coverage.yml" alt="coverage">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Coverage?label=coverage"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/e2e.yml" alt="e2e">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/e2e?label=e2e"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/build.yaml" alt="build">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Build?label=build"/></a>
    <a href="https://opensource.org/licenses/Apache-2.0" alt="license">
        <img src="https://img.shields.io/badge/license-Apache%202-blue"/></a>
    <a href="https://bestpractices.coreinfrastructure.org/projects/5146"><img src="https://bestpractices.coreinfrastructure.org/projects/5146/badge"></a>
</p>

## **목차**
### 1. [**소개**](#about)
### 2. [**시작하기**](#getting-started)
>#### 2.1.   [**요구 사항**](#requirements)
>#### 2.2.  [**설치 방법**](#installing-horusec)
### 3. [**사용법**](#usage)
>#### 3.1. [**CLI 사용법**](#cli-usage)
>#### 3.2. [**Docker 사용**](#using-docker)
>#### 3.3. [**이전 버전**](#older-versions)
>#### 3.4. [**Horusec-Web 애플리케이션 사용**](#using-horusec-web-application)
>#### 3.5.  [**Visual Studio Code 사용**](#using-visual-studio-code)
>#### 3.6. [**파이프라인에서 사용**](#using-the-pipeline)
### 4. [**문서**](#documentation)       
### 5. [**로드맵**](#roadmap)
### 6. [**기여하기**](#contributing)
### 7. [**행동 강령**](#code-of-conduct)
### 8. [**라이선스**](#license)
### 9. [**커뮤니티**](#community)



<br>
<br>
<br>

# **소개**
Horusec는 개발 과정에서 보안 결함을 식별하기 위해 정적 코드 분석을 수행하는 오픈 소스 도구입니다. 현재 분석 가능한 언어는 C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx입니다. 
이 도구는 프로젝트의 모든 파일과 Git 이력에서 키 유출 및 보안 결함을 탐색하는 옵션을 제공합니다. Horusec는 개발자가 CLI를 통해 사용할 수 있으며, DevSecOps 팀이 CI / CD 매트릭스에서 사용할 수 있습니다.

[**문서**](https://docs.horusec.io/docs/overview/)를 확인하면 Horusec가 분석하는 도구와 언어의 전체 목록을 볼 수 있습니다.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **출력 예시 보기:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **시작하기**

## **요구 사항**

- Docker

Horusec를 모든 도구와 함께 실행하려면 Docker가 설치되어 있어야 합니다.
Docker가 없다면 [**flag**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true`를 사용하여 의존성을 비활성화할 수 있지만, 이 경우 분석 성능이 크게 저하됩니다.
Docker와 함께 사용할 것을 권장합니다.

커밋 작성자 `-G true`를 활성화하면 `git`도 필요합니다.

## **Horusec 설치**
### **Mac 또는 Linux**
```
make install
```

또는

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **설치 확인**
```bash
horusec version
```

### **Windows**
- **amd64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_amd64.exe" -o "./horusec.exe" -L
    ```

- **arm64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_arm64.exe" -o "./horusec.exe" -L
    ```

#### **설치 확인**
```bash
./horusec.exe version
```

### **기타**

- 모든 바이너리와 버전은 [**릴리즈 페이지**](https://github.com/ZupIT/horusec/releases)에서 확인할 수 있습니다.

- 설치 방법에 대한 자세한 내용은 [**문서**](https://docs.horusec.io/docs/cli/installation)를 참고하세요.


## **사용법**
### **CLI 사용법**
horusec-cli를 사용하여 애플리케이션의 취약점을 확인하려면 다음 명령어를 사용하세요:
```bash
horusec start -p .
```
> horusec가 분석을 시작하면 **`.horusec`** 폴더가 생성됩니다. 이 폴더는 코드를 변경하지 않기 위한 기본 폴더입니다. **`.horusec`** 폴더가 git 서버로 전송되지 않도록 **`.gitignore`** 파일에 **`.horusec`** 라인을 추가하는 것을 권장합니다.

### **Docker 사용**
Docker 이미지 **`horuszup/horusec-cli:latest`**를 통해 Horusec를 사용할 수 있습니다.

다음 명령어로 실행하세요:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- 프로젝트를 포함하는 볼륨을 `-v $(pwd):/src`로 생성했습니다.

Docker 이미지를 사용할 경우, 프로젝트가 존재할 수 있는 경로가 두 개 생깁니다.

`-p` 플래그는 컨테이너 내부의 프로젝트 경로를 나타내며, 예시에서는 `/src`입니다.
`-P` 플래그는 컨테이너 외부의 프로젝트 경로를 나타내며, 예시에서는 `$(pwd)`입니다.
또한 볼륨을 마운트하기 위해 프로젝트 경로를 전달해야 합니다(`-v $(pwd):/src`).

### **이전 버전**

Horusec의 v1도 여전히 사용 가능합니다.

**경고:** v1 엔드포인트는 곧 지원 종료 예정이므로, CLI를 v2로 업그레이드 하시기 바랍니다. 자세한 내용은 [**문서**](https://docs.horusec.io/docs/migrate-v1-to-v2/)를 참고하세요.

### **Mac 또는 Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- 이전 버전 바이너리는 이 엔드포인트에서 확인할 수 있으며, v1의 최신 버전 **`v1.10.3`** 도 포함되어 있습니다.
- v2부터는 이 엔드포인트에서 바이너리가 배포되지 않으며, [**릴리즈 페이지**](https://github.com/ZupIT/horusec/releases)에서 확인하실 수 있습니다.

### **Horusec-Web 애플리케이션 사용**
웹 인터페이스를 통해 취약점을 관리할 수 있습니다. 취약점에 대한 메트릭 대시보드, 오탐 제어, 인증 토큰, 취약점 업데이트 등 다양한 기능을 제공합니다.
자세한 내용은 [**웹 애플리케이션**](https://github.com/ZupIT/horusec-platform) 섹션에서 확인하세요.

아래 예시는 Horusec 웹 서비스로 분석을 전송하는 예시입니다:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

[**Horusec Manager Web Service를 통해 인증 토큰 생성 방법 튜토리얼**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token)을 확인하세요.

**경고:** 웹 서비스가 [**새 저장소**](https://github.com/ZupIT/horusec-platform)로 이동되었습니다. v2로 업그레이드가 필요합니다. [**v1에서 v2로 마이그레이션 방법**](https://docs.horusec.io/docs/migrate-v1-to-v2)를 참고하세요.

### **Visual Studio Code 사용**
Horusec의 Visual Studio Code 확장을 통해 프로젝트를 분석할 수 있습니다.
자세한 정보는 [**문서**](https://docs.horusec.io/docs/extensions/visual-studio-code/)를 참고하세요.

### **파이프라인에서 사용**
배포 전에 프로젝트를 분석하여 조직 내 최대 보안을 확보할 수 있습니다.
자세한 내용은 [**문서**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline)를 참고하세요.

### **주요 기능**
아래와 같습니다:
- 18개 언어를 20개의 보안 도구로 동시에 분석하여 정확성 향상
- Git 이력을 탐색하여 노출된 시크릿 및 기타 콘텐츠 검색
- 분석을 완전히 구성할 수 있으며, [**CLI의 모든 리소스 보기**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags)

## **문서**
Horusec의 문서는 [**웹사이트**](https://docs.horusec.io/docs/overview/)에서 확인할 수 있습니다.

## **로드맵**
프로젝트 [**로드맵**](ROADMAP.md)이 있으며, 여러분의 기여를 기다립니다!

Horusec에는 추가 저장소가 있습니다. 확인해보세요:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **기여하기**

자유롭게 사용하시고, 개선을 제안하거나 새로운 구현에 기여해 주세요.

우리의 개발 프로세스, 버그 수정 및 개선 사항 제안 방법에 대해 알아보려면 [**기여 가이드**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md)를 확인하세요.

### **Developer Certificate of Origin - DCO**

이것은 프로젝트와 개발자를 위한 보안 계층입니다. 필수 사항입니다.

커밋에 DCO를 추가하려면 다음 두 가지 방법 중 하나를 따르세요:

**1. 커맨드 라인**
단계를 따르세요:  
**1단계:** 로컬 git 환경에 GitHub 계정에 설정된 동일한 이름과 이메일을 추가하세요. 리뷰와 제안 중 커밋을 수동으로 서명하는 데 도움이 됩니다.

```
git config --global user.name “Name”
git config --global user.email “email@domain.com.br”
```
**2단계:** git 커밋 명령에서 `'-s'` 플래그로 Signed-off-by 줄을 추가하세요:

```
$ git commit -s -m "This is my commit message"
```
**2. GitHub 웹사이트**

GitHub 리뷰 및 제안 중에도 커밋을 수동으로 서명할 수 있습니다. 아래 단계를 따르세요:

**1단계:** 커밋 변경 창이 열리면, 댓글란에 직접 서명을 입력하거나 붙여넣으세요. 예시는 다음과 같습니다:

```
Signed-off-by: Name < e-mail address >
```

이 방법을 사용할 때는 이름과 이메일이 GitHub 계정에 등록된 것과 동일해야 합니다.

## **행동 강령**
프로젝트와의 모든 상호작용에서 [**행동 강령**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md)을 따라주세요.

## **라이선스**
[**Apache License 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **커뮤니티**

언제든지 아래를 통해 문의해 주세요:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- 궁금한 점이나 아이디어가 있다면 [**Zup 오픈 소스 포럼**](https://forum.zup.com.br)에서 함께 대화해요.

이 프로젝트는 모든 기여자 덕분에 존재합니다. 여러분 최고예요! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---