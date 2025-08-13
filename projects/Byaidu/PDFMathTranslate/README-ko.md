<div align="center">

English | [简体中文](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_zh-TW.md) | [日本語](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_ja-JP.md) | [한국어](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_ko-KR.md)

<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/banner.png" width="320px"  alt="PDF2ZH"/>

<h2 id="title">PDFMathTranslate</h2>

<p>
  <!-- PyPI -->
  <a href="https://pypi.org/project/pdf2zh/">
    <img src="https://img.shields.io/pypi/v/pdf2zh"></a>
  <a href="https://pepy.tech/projects/pdf2zh">
    <img src="https://static.pepy.tech/badge/pdf2zh"></a>
  <a href="https://hub.docker.com/r/byaidu/pdf2zh">
    <img src="https://img.shields.io/docker/pulls/byaidu/pdf2zh"></a>
  <a href="https://hellogithub.com/repository/8ec2cfd3ef744762bf531232fa32bc47" target="_blank"><img src="https://api.hellogithub.com/v1/widgets/recommend.svg?rid=8ec2cfd3ef744762bf531232fa32bc47&claim_uid=JQ0yfeBNjaTuqDU&theme=small" alt="Featured｜HelloGitHub" /></a>
  <a href="https://gitcode.com/Byaidu/PDFMathTranslate/overview">
    <img src="https://gitcode.com/Byaidu/PDFMathTranslate/star/badge.svg"></a>
  <a href="https://huggingface.co/spaces/reycn/PDFMathTranslate-Docker">
    <img src="https://img.shields.io/badge/%F0%9F%A4%97-Online%20Demo-FF9E0D"></a>
  <a href="https://www.modelscope.cn/studios/AI-ModelScope/PDFMathTranslate">
    <img src="https://img.shields.io/badge/ModelScope-Demo-blue"></a>
  <a href="https://github.com/Byaidu/PDFMathTranslate/pulls">
    <img src="https://img.shields.io/badge/contributions-welcome-green"></a>
  <a href="https://t.me/+Z9_SgnxmsmA5NzBl">
    <img src="https://img.shields.io/badge/Telegram-2CA5E0?style=flat-squeare&logo=telegram&logoColor=white"></a>
  <!-- License -->
  <a href="./LICENSE">
    <img src="https://img.shields.io/github/license/Byaidu/PDFMathTranslate"></a>
</p>

<a href="https://trendshift.io/repositories/12424" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12424" alt="Byaidu%2FPDFMathTranslate | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>

</div>

PDF 과학 논문 번역 및 이중 언어 비교.

- 📊 수식, 차트, 목차 및 주석 보존 _([미리보기](#preview))_.
- 🌐 [다국어](#language) 및 다양한 [번역 서비스](#services) 지원.
- 🤖 [명령줄 도구](#usage), [대화형 사용자 인터페이스](#gui), 및 [Docker](#docker)를 제공합니다.

[GitHub Issues](https://github.com/Byaidu/PDFMathTranslate/issues) 또는 [Telegram 그룹](https://t.me/+Z9_SgnxmsmA5NzBl)에서 자유롭게 피드백을 제공해 주세요.

기여 방법에 대한 자세한 내용은 [기여 가이드](https://github.com/Byaidu/PDFMathTranslate/wiki/Contribution-Guide---%E8%B4%A1%E7%8C%AE%E6%8C%87%E5%8D%97)를 참조하십시오.

<h2 id="updates">업데이트</h2>

- [2025년 5월 9일] pdf2zh 2.0 미리보기 버전 [#586](https://github.com/Byaidu/PDFMathTranslate/issues/586): Windows ZIP 파일과 Docker 이미지가 이제 제공됩니다.

> [!NOTE]
>
> 2.0 버전이 조직 내 새 저장소로 이전되었습니다: [PDFMathTranslate/PDFMathTranslate-next](https://github.com/PDFMathTranslate/PDFMathTranslate-next)
> 
> 2.0 버전 공식 릴리스가 게시되었습니다.

- [2025년 3월 3일] 새로운 백엔드 [BabelDOC](https://github.com/funstory-ai/BabelDOC) WebUI에 대한 실험적 지원 추가 (작성자: [@awwaawwa](https://github.com/awwaawwa))
- [2025년 2월 22일] 향상된 릴리스 CI 및 잘 패키징된 Windows-amd64 exe 제공 (작성자: [@awwaawwa](https://github.com/awwaawwa))
- [2024년 12월 24일] 번역기가 이제 [Xinference](https://github.com/xorbitsai/inference)에서 로컬 모델을 지원합니다 _(작성자: [@imClumsyPanda](https://github.com/imClumsyPanda))_
- [2024년 12월 19일] PDF/A가 아닌 문서도 이제 `-cp` 옵션으로 지원 _(작성자: [@reycn](https://github.com/reycn))_
- [2024년 12월 13일] 추가 백엔드 지원 _(작성자: [@YadominJinta](https://github.com/YadominJinta))_
- [2024년 12월 10일] 번역기가 이제 Azure에서 OpenAI 모델을 지원합니다 _(작성자: [@yidasanqian](https://github.com/yidasanqian))_

<h2 id="preview">미리보기</h2>

<div align="center">
<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/preview.gif" width="80%"/>
</div>

<h2 id="demo">온라인 서비스 🌟</h2>

다음 데모 중 하나를 사용하여 애플리케이션을 체험할 수 있습니다:

- 설치 없이 온라인으로 이용 가능한 [공용 무료 서비스](https://pdf2zh.com/) _(추천)_.
- 매월 1000페이지 무료 제공하는 [Immersive Translate - BabelDOC](https://app.immersivetranslate.com/babel-doc/) _(추천)_
- [HuggingFace에서 호스팅하는 데모](https://huggingface.co/spaces/reycn/PDFMathTranslate-Docker)
- 설치 없이 이용 가능한 [ModelScope에서 호스팅하는 데모](https://www.modelscope.cn/studios/AI-ModelScope/PDFMathTranslate).

데모의 컴퓨팅 자원이 제한되어 있으니 남용하지 말아 주세요.

<h2 id="install">설치 및 사용법</h2>

### 방법

다양한 사용 사례에 맞춰, 저희 프로그램을 사용하는 여러 가지 방법을 제공합니다:

<details open>
  <summary>1. UV 설치</summary>

1. Python 설치 (3.10 <= 버전 <= 3.12)

2. 저희 패키지 설치:

   ```bash
   pip install uv
   uv tool install --python 3.12 pdf2zh
   ```
3. 번역을 실행하고, 생성된 파일은 [현재 작업 디렉토리](https://chatgpt.com/share/6745ed36-9acc-800e-8a90-59204bd13444)에 있습니다:


   ```bash
   pdf2zh document.pdf
   ```

</details>

<details>
  <summary>2. Windows exe</summary>

1. [릴리스 페이지](https://github.com/Byaidu/PDFMathTranslate/releases)에서 pdf2zh-version-win64.zip 파일을 다운로드합니다.

2. 압축을 풀고 `pdf2zh.exe`를 더블 클릭하여 실행합니다.

</details>

<details>
  <summary>3. 그래픽 사용자 인터페이스</summary>

1. Python이 설치되어 있어야 합니다 (3.10 <= 버전 <= 3.12)

2. 패키지를 설치합니다:

```bash
pip install pdf2zh
```

3. 브라우저에서 사용 시작:

   ```bash
   pdf2zh -i
   ```

4. 브라우저가 자동으로 시작되지 않은 경우, 다음으로 이동하십시오

   ```bash
   http://localhost:7860/
   ```

   <img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/gui.gif" width="500"/>

자세한 내용은 [GUI 문서](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/README_GUI.md)를 참조하세요.

</details>

<details>
  <summary>4. Docker</summary>

1. 가져오기 및 실행:

   ```bash
   docker pull byaidu/pdf2zh
   docker run -d -p 7860:7860 byaidu/pdf2zh
   ```

2. 브라우저에서 열기:

   ```
   http://localhost:7860/
   ```
클라우드 서비스에서의 도커 배포:

<div>
<a href="https://www.heroku.com/deploy?template=https://github.com/Byaidu/PDFMathTranslate">
  <img src="https://www.herokucdn.com/deploy/button.svg" alt="배포" height="26"></a>
<a href="https://render.com/deploy">
  <img src="https://render.com/images/deploy-to-render-button.svg" alt="Koyeb에 배포" height="26"></a>
<a href="https://zeabur.com/templates/5FQIGX?referralCode=reycn">
  <img src="https://zeabur.com/button.svg" alt="Zeabur에 배포" height="26"></a>
<a href="https://template.sealos.io/deploy?templateName=pdf2zh">
  <img src="https://sealos.io/Deploy-on-Sealos.svg" alt="Sealos에 배포" height="26"></a>
<a href="https://app.koyeb.com/deploy?type=git&builder=buildpack&repository=github.com/Byaidu/PDFMathTranslate&branch=main&name=pdf-math-translate">
  <img src="https://www.koyeb.com/static/images/deploy/button.svg" alt="Koyeb에 배포" height="26"></a>
</div>

</details>

<details>
  <summary>5. Zotero 플러그인</summary>


자세한 내용은 [Zotero PDF2zh](https://github.com/guaguastandup/zotero-pdf2zh)를 참조하세요.

</details>

<details>
  <summary>6. 명령줄</summary>

1. Python 설치 (3.10 <= 버전 <= 3.12)
2. 패키지 설치:


   ```bash
   pip install pdf2zh
   ```

3. 번역을 실행합니다, 생성된 파일은 [현재 작업 디렉토리](https://chatgpt.com/share/6745ed36-9acc-800e-8a90-59204bd13444)에 있습니다:

   ```bash
   pdf2zh document.pdf
   ```
</details>

> [!TIP]
>
> - 윈도우를 사용 중이며 다운로드한 파일을 열 수 없는 경우, [vc_redist.x64.exe](https://aka.ms/vs/17/release/vc_redist.x64.exe)를 설치한 후 다시 시도해 보세요.
>
> - Docker Hub에 접속할 수 없는 경우, [GitHub Container Registry](https://github.com/Byaidu/PDFMathTranslate/pkgs/container/pdfmathtranslate)의 이미지를 사용해 보세요.
> ```bash
> docker pull ghcr.io/byaidu/pdfmathtranslate
> docker run -d -p 7860:7860 ghcr.io/byaidu/pdfmathtranslate
> ```

### 설치할 수 없나요?

본 프로그램은 작동 전에 AI 모델(`wybxc/DocLayout-YOLO-DocStructBench-onnx`)이 필요하며, 일부 사용자는 네트워크 문제로 다운로드가 불가능할 수 있습니다. 이 모델 다운로드에 문제가 있는 경우, 다음 환경 변수를 사용한 우회 방법을 제공합니다:


```shell
set HF_ENDPOINT=https://hf-mirror.com
```
PowerShell 사용자용:


```shell
$env:HF_ENDPOINT = https://hf-mirror.com
```
만약 이 솔루션이 작동하지 않거나 다른 문제가 발생한 경우, [자주 묻는 질문](https://github.com/Byaidu/PDFMathTranslate/wiki#-faq--%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98)을 참조하십시오.

<h2 id="usage">고급 옵션</h2>

명령줄에서 번역 명령을 실행하여 현재 작업 디렉토리에 번역된 문서 `example-mono.pdf`와 이중 언어 문서 `example-dual.pdf`를 생성합니다. 기본 번역 서비스로 Google을 사용합니다. 더 많은 지원 번역 서비스는 [여기](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#services)에서 확인할 수 있습니다.

<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/cmd.explained.png" width="580px"  alt="cmd"/>

다음 표에는 참조용으로 모든 고급 옵션을 나열했습니다:

| 옵션                  | 기능                                                                                                         | 예제                                           |
| --------------------- | ------------------------------------------------------------------------------------------------------------ | ---------------------------------------------- |
| files                 | 로컬 파일                                                                                                    | `pdf2zh ~/local.pdf`                           |
| links                 | 온라인 파일                                                                                                  | `pdf2zh http://arxiv.org/paper.pdf`            |
| `-i`                  | [GUI 실행](#gui)                                                                                             | `pdf2zh -i`                                    |
| `-p`                  | [부분 문서 번역](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#partial)               | `pdf2zh example.pdf -p 1`                      |
| `-li`                 | [원본 언어](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#languages)                  | `pdf2zh example.pdf -li en`                    |
| `-lo`                 | [목표 언어](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#languages)                  | `pdf2zh example.pdf -lo zh`                    |
| `-s`                  | [번역 서비스](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#services)                 | `pdf2zh example.pdf -s deepl`                  |
| `-t`                  | [멀티 스레드](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#threads)                  | `pdf2zh example.pdf -t 1`                      |
| `-o`                  | 출력 디렉토리                                                                                                | `pdf2zh example.pdf -o output`                 |
| `-f`, `-c`            | [예외 처리](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#exceptions)                | `pdf2zh example.pdf -f "(MS.*)"`               |
| `-cp`                 | 호환 모드                                                                                                   | `pdf2zh example.pdf --compatible`              |
| `--skip-subset-fonts` | [폰트 서브셋 건너뛰기](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#font-subset)     | `pdf2zh example.pdf --skip-subset-fonts`       |
| `--ignore-cache`      | [번역 캐시 무시](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#cache)                 | `pdf2zh example.pdf --ignore-cache`            |
| `--share`             | 공개 링크                                                                                                   | `pdf2zh -i --share`                            |
| `--authorized`        | [권한 부여](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#auth)                       | `pdf2zh -i --authorized users.txt [auth.html]` |
| `--prompt`            | [사용자 지정 프롬프트](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#prompt)           | `pdf2zh --prompt [prompt.txt]`                 |
| `--onnx`              | [사용자 지정 DocLayout-YOLO ONNX 모델 사용]                                                                   | `pdf2zh --onnx [onnx/model/path]`              |
| `--serverport`        | [사용자 지정 WebUI 포트]                                                                                      | `pdf2zh --serverport 7860`                     |
| `--dir`               | [배치 번역]                                                                                                  | `pdf2zh --dir /path/to/translate/`             |
| `--config`            | [설정 파일](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#cofig)                      | `pdf2zh --config /path/to/config/config.json`  |
| `--serverport`        | [사용자 지정 gradio 서버 포트]                                                                                 | `pdf2zh --serverport 7860`                     |
| `--babeldoc`          | 실험적 백엔드 [BabelDOC](https://funstory-ai.github.io/BabelDOC/) 사용하여 번역                                | `pdf2zh --babeldoc` -s openai example.pdf      |
| `--mcp`               | MCP STDIO 모드 활성화                                                                                        | `pdf2zh --mcp`                                 |
| `--sse`               | MCP SSE 모드 활성화                                                                                          | `pdf2zh --mcp --sse`                           |

자세한 설명은 각 옵션의 전체 목록이 포함된 [고급 사용법](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/ADVANCED.md) 문서를 참조하십시오.


<h2 id="downstream">2차 개발 (API)</h2>

하류 애플리케이션의 경우, 자세한 내용은 [API 세부사항](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md) 문서를 참조하십시오:

- [Python API](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md#api-python), 다른 Python 프로그램에서 본 프로그램을 사용하는 방법
- [HTTP API](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md#api-http), 프로그램이 설치된 서버와 통신하는 방법

<h2 id="todo">할 일</h2>

- [ ] DocLayNet 기반 모델, [PaddleX](https://github.com/PaddlePaddle/PaddleX/blob/17cc27ac3842e7880ca4aad92358d3ef8555429a/paddlex/repo_apis/PaddleDetection_api/object_det/official_categories.py#L81), [PaperMage](https://github.com/allenai/papermage/blob/9cd4bb48cbedab45d0f7a455711438f1632abebe/README.md?plain=1#L102), [SAM2](https://github.com/facebookresearch/sam2)을 이용한 레이아웃 파싱

- [ ] 페이지 회전, 목차, 목록 형식 수정

- [ ] 옛 논문의 픽셀 수식 수정

- [ ] KeyboardInterrupt 제외 비동기 재시도

- [ ] 서양어용 Knuth–Plass 알고리즘

- [ ] 비 PDF/A 파일 지원

- [ ] [Zotero](https://github.com/zotero/zotero) 및 [Obsidian](https://github.com/obsidianmd/obsidian-releases) 플러그인

<h2 id="acknowledgement">감사의 글</h2>

- [Immersive Translation](https://immersivetranslate.com)에서는 이 프로젝트의 활발한 기여자에게 매월 Pro 멤버십 교환 코드를 후원합니다, 자세한 내용은: [CONTRIBUTOR_REWARD.md](https://github.com/funstory-ai/BabelDOC/blob/main/docs/CONTRIBUTOR_REWARD.md)

- 새로운 백엔드: [BabelDOC](https://github.com/funstory-ai/BabelDOC)

- 문서 병합: [PyMuPDF](https://github.com/pymupdf/PyMuPDF)

- 문서 파싱: [Pdfminer.six](https://github.com/pdfminer/pdfminer.six)

- 문서 추출: [MinerU](https://github.com/opendatalab/MinerU)

- 문서 미리보기: [Gradio PDF](https://github.com/freddyaboulton/gradio-pdf)

- 다중 스레드 번역: [MathTranslate](https://github.com/SUSYUSTC/MathTranslate)

- 레이아웃 파싱: [DocLayout-YOLO](https://github.com/opendatalab/DocLayout-YOLO)
- 문서 표준: [PDF 설명](https://zxyle.github.io/PDF-Explained/), [PDF 치트 시트](https://pdfa.org/resource/pdf-cheat-sheets/)

- 다국어 글꼴: [Go Noto Universal](https://github.com/satbyy/go-noto-universal)

<h2 id="contrib">기여자</h2>

<a href="https://github.com/Byaidu/PDFMathTranslate/graphs/contributors">
  <img src="https://opencollective.com/PDFMathTranslate/contributors.svg?width=890&button=false" />
</a>

![Alt](https://repobeats.axiom.co/api/embed/dfa7583da5332a11468d686fbd29b92320a6a869.svg "Repobeats 분석 이미지")

<h2 id="star_hist">별 히스토리</h2>

<a href="https://star-history.com/#Byaidu/PDFMathTranslate&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Byaidu/PDFMathTranslate&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Byaidu/PDFMathTranslate&type=Date" />
   <img alt="별 히스토리 차트" src="https://api.star-history.com/svg?repos=Byaidu/PDFMathTranslate&type=Date"/>
 </picture>
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-13

---