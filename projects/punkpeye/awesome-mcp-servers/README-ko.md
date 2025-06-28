# Awesome MCP Servers [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

엄선된 Model Context Protocol (MCP) 서버 모음입니다.

* [MCP란?](#what-is-mcp)
* [클라이언트](#clients)
* [튜토리얼](#tutorials)
* [커뮤니티](#community)
* [범례](#legend)
* [서버 구현체](#server-implementations)
* [프레임워크](#frameworks)
* [팁 & 트릭](#tips-and-tricks)

## MCP란?

[MCP](https://modelcontextprotocol.io/)는 AI 모델이 표준화된 서버 구현을 통해 로컬 및 원격 리소스와 안전하게 상호작용할 수 있게 해주는 오픈 프로토콜입니다. 이 목록은 파일 접근, 데이터베이스 연결, API 통합, 기타 컨텍스트 서비스 등 AI 기능을 확장하는 프로덕션 및 실험적 MCP 서버에 초점을 맞추고 있습니다.

## 클라이언트

[awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/)와 [glama.ai/mcp/clients](https://glama.ai/mcp/clients)를 확인해 보세요.

> [!TIP]
> [Glama Chat](https://glama.ai/chat)은 MCP를 지원하는 멀티모달 AI 클라이언트이자 [AI 게이트웨이](https://glama.ai/gateway)입니다.

## 튜토리얼

* [Model Context Protocol (MCP) 빠른 시작](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [Claude 데스크톱 앱에서 SQLite 데이터베이스 사용 설정하기](https://youtu.be/wxCCzo9dGj0)

## 커뮤니티

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [디스코드 서버](https://glama.ai/mcp/discord)

## 범례

* 🎖️ – 공식 구현체
* 프로그래밍 언어
  * 🐍 – Python 코드베이스
  * 📇 – TypeScript(또는 JavaScript) 코드베이스
  * 🏎️ – Go 코드베이스
  * 🦀 – Rust 코드베이스
  * #️⃣ - C# 코드베이스
  * ☕ - Java 코드베이스
  * 🌊 – C/C++ 코드베이스
* 범위
  * ☁️ - 클라우드 서비스
  * 🏠 - 로컬 서비스
  * 📟 - 임베디드 시스템
* 운영체제
  * 🍎 – macOS용
  * 🪟 – Windows용
  * 🐧 - Linux용

> [!NOTE]
> 로컬 🏠 과 클라우드 ☁️ 의 차이가 궁금하신가요?
> * MCP 서버가 로컬에 설치된 소프트웨어와 통신할 때는 로컬을 사용하세요. 예: Chrome 브라우저 제어
> * MCP 서버가 원격 API와 통신할 때는 네트워크(클라우드)를 사용하세요. 예: 날씨 API

## 서버 구현체

> [!NOTE]
> 현재 저장소와 동기화되는 [웹 기반 디렉터리](https://glama.ai/mcp/servers)가 있습니다.

* 🔗 - [집계기](#aggregators)
* 🎨 - [예술 & 문화](#art-and-culture)
* 📂 - [브라우저 자동화](#browser-automation)
* ☁️ - [클라우드 플랫폼](#cloud-platforms)
* 👨‍💻 - [코드 실행](#code-execution)
* 🤖 - [코딩 에이전트](#coding-agents)
* 🖥️ - [커맨드 라인](#command-line)
* 💬 - [커뮤니케이션](#communication)
* 👤 - [고객 데이터 플랫폼](#customer-data-platforms)
* 🗄️ - [데이터베이스](#databases)
* 📊 - [데이터 플랫폼](#data-platforms)
* 🚚 - [딜리버리](#delivery)
* 🛠️ - [개발자 도구](#developer-tools)
* 🧮 - [데이터 과학 도구](#data-science-tools)
* 📟 - [임베디드 시스템](#embedded-system)
* 📂 - [파일 시스템](#file-systems)
* 💰 - [금융 & 핀테크](#finance--fintech)
* 🎮 - [게임](#gaming)
* 🧠 - [지식 & 메모리](#knowledge--memory)
* 🗺️ - [위치 서비스](#location-services)
* 🎯 - [마케팅](#marketing)
* 📊 - [모니터링](#monitoring)
* 🎥 - [멀티미디어 처리](#multimedia-process)
* 🔎 - [검색 & 데이터 추출](#search)
* 🔒 - [보안](#security)
* 🌐 - [소셜 미디어](#social-media)
* 🏃 - [스포츠](#sports)
* 🎧 - [지원 및 서비스 관리](#support-and-service-management)
* 🌎 - [번역 서비스](#translation-services)
* 🎧 - [텍스트 음성 변환](#text-to-speech)
* 🚆 - [여행 및 교통](#travel-and-transportation)
* 🔄 - [버전 관리](#version-control)
* 🛠️ - [기타 도구 및 통합](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>집계기

하나의 MCP 서버를 통해 여러 앱과 도구에 접근할 수 있는 서버입니다.

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - 하나의 바이너리로 40개 이상의 앱을 SQL로 쿼리할 수 있습니다. PostgreSQL, MySQL, SQLite 호환 데이터베이스와도 연결됩니다. 기본적으로 로컬 우선 및 프라이버시 설계.
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP는 GUI를 통해 MCP 연결을 관리하는 통합 미들웨어 MCP 서버입니다.
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - [MindsDB를 단일 MCP 서버로](https://docs.mindsdb.com/mcp/overview) 사용하여 다양한 플랫폼과 데이터베이스의 데이터를 연결 및 통합합니다.
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - MCP 서버 목록을 제공하여 클라이언트가 일상 업무 흐름을 개선할 수 있는 서버를 선택할 수 있습니다.
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - 웹 API를 10초 만에 MCP 서버로 변환하고 오픈소스 레지스트리에 추가: https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - 2,500개의 API와 8,000개 이상의 사전 구축 도구를 연결하고, 자체 앱에서 사용자 서버를 관리할 수 있습니다.
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - 여러 MCP 서버를 단일 인터페이스로 통합하는 종합 프록시 서버로, 광범위한 가시성 기능을 제공합니다. 서버 간 도구, 프롬프트, 리소스, 템플릿의 검색 및 관리를 지원하며, MCP 서버 구축 시 디버깅을 위한 플레이그라운드를 제공합니다.
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - 여러 MCP 서버를 하나의 통합 엔드포인트로 구성하는 프록시 도구. Nginx가 웹 서버를 로드밸런싱하듯 AI 도구의 요청을 여러 MCP 서버로 분산시켜 확장합니다.
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP는 GUI를 통해 MCP 연결을 관리하는 통합 미들웨어 MCP 서버입니다.
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - Claude Desktop 및 기타 MCP 호스트를 Notion, Slack, Monday, Airtable 등 좋아하는 앱과 원활하고 안전하게 연결합니다. 90초 이내에 설정.
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - 코드 수정 없이 한 번의 클릭으로 웹 서비스를 MCP 서버로 변환합니다.
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - MCP를 통해 Google의 Imagen 3.0 API를 사용하는 강력한 이미지 생성 도구. 고급 사진, 예술, 사실적 컨트롤로 텍스트 프롬프트에서 고품질 이미지 생성.
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - OpenAI GPT 이미지 생성/편집 MCP 서버.

### 🎨 <a name="art-and-culture"></a>예술 및 문화

예술 컬렉션, 문화 유산, 박물관 데이터베이스에 접근 및 탐색. AI 모델이 예술 및 문화 콘텐츠를 검색·분석할 수 있도록 지원합니다.

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - Manim을 사용하여 애니메이션을 생성하는 로컬 MCP 서버.
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - 비디오 정글 컬렉션에서 비디오 편집 추가, 분석, 검색 및 생성
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - Discogs API와 상호작용하는 MCP 서버
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ Quran.com 코퍼스와 공식 REST API v4를 통해 상호작용하는 MCP 서버.
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - 메트로폴리탄 미술관 소장품 API 통합, 컬렉션 내 예술 작품 검색 및 표시.
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - Rijksmuseum API 통합, 예술 작품 검색, 상세정보, 컬렉션 제공
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - 네덜란드(1940-1945) 2차 세계대전 기록, 사진, 문서에 접근할 수 있는 Oorlogsbronnen(전쟁 자료) API 통합
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - DaVinci Resolve와의 MCP 서버 통합, 비디오 편집, 색상 보정, 미디어 관리, 프로젝트 제어 기능 제공
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - AniList API를 통합한 MCP 서버, 애니메이션 및 만화 정보 제공
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - Aseprite API를 이용한 픽셀 아트 생성 MCP 서버
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - NVIDIA Isaac Sim, Lab, OpenUSD 등 자연어 제어를 가능하게 하는 MCP 서버 및 확장 기능
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - Open Library API용 MCP 서버로, AI 비서가 도서 정보를 검색할 수 있게 지원
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - Autodesk Maya용 MCP 서버
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - 종합적이고 정확한 사주(중국 점성술) 차트 및 분석 제공


### 📂 <a name="browser-automation"></a>브라우저 자동화

웹 콘텐츠 접근 및 자동화 기능. AI 친화적 포맷으로 웹 콘텐츠 검색, 스크래핑, 처리 지원.

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - Bilibili 인기 동영상을 가져와 표준 MCP 인터페이스로 노출하는 FastMCP 기반 도구.
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - Bilibili 콘텐츠 검색 지원 MCP 서버. LangChain 통합 예제 및 테스트 스크립트 제공.
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - 내장 MCP 및 A2A 지원이 포함된 자체 호스팅 브라우저 에이전트.
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - Playwright를 이용한 브라우저 자동화 MCP 서버
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - Playwright를 이용한 MCP 파이썬 서버, LLM에 더 적합
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - 클라우드에서 브라우저 상호작용 자동화(웹 탐색, 데이터 추출, 폼 입력 등)
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - 로컬 크롬 브라우저 자동화
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-use를 SSE 트랜스포트로 MCP 서버로 패키징. Docker에서 크로미움+VNC 서버 실행 Dockerfile 포함.
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - Playwright를 이용한 브라우저 자동화 및 웹 스크래핑 MCP 서버
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - 브라우저 확장과 연결되어 LLM 클라이언트가 사용자의 브라우저(Firefox)를 제어할 수 있게 하는 MCP 서버.
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - macOS에서 Apple Reminders와 상호작용하는 MCP 서버
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - 웹사이트에서 구조화된 데이터 추출. 프롬프트만 입력하면 JSON 반환.
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - AI 분석용 YouTube 자막 및 트랜스크립트 가져오기
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - Azure OpenAI와 Playwright를 이용한 `minimal` 서버/클라이언트 MCP 구현.
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - Microsoft 공식 Playwright MCP 서버, LLM이 구조화된 접근성 스냅샷을 통해 웹페이지와 상호작용 가능
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - 웹 스크래핑 및 상호작용을 위한 브라우저 자동화
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - manifest v2 호환 브라우저와 상호작용하는 MCP 서버.
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - Google 검색 결과를 활용한 무료 웹 검색 MCP 서버, API 키 불필요.
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - Apple Shortcuts와의 MCP 서버 통합

### ☁️ <a name="cloud-platforms"></a>클라우드 플랫폼

클라우드 플랫폼 서비스 통합. 클라우드 인프라 및 서비스 관리 및 상호작용 지원.

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - AWS 서비스 및 리소스와의 원활한 통합을 위한 AWS MCP 서버.
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - Qiniu Cloud 제품 기반 MCP로, Qiniu Cloud 스토리지, 미디어 처리 서비스 등에 접근 지원.
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - IPFS 스토리지 업로드 및 조작
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - 표준화된 인터페이스로 Kubernetes 클러스터와 상호작용할 수 있는 MCP 서버. API 리소스 검색, 리소스 관리, 파드 로그, 메트릭, 이벤트 포함.
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - MCP 클라이언트(예: Cherry Studio)에서 사용할 수 있는 도서 질의용 MCP 서버.
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - AI 비서가 AWS CLI 명령 실행, 유닉스 파이프 사용, 일반 AWS 작업용 프롬프트 템플릿 적용을 안전한 Docker 환경에서 멀티 아키텍처 지원으로 가능하게 하는 경량이면서 강력한 서버
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - AI 비서가 안전하게 Kubernetes CLI 명령(`kubectl`, `helm`, `istioctl`, `argocd`)을 유닉스 파이프와 함께 Docker 환경에서 실행할 수 있도록 지원하는 경량이면서 강력한 서버.
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - AI 비서가 Alibaba Cloud의 리소스를 운영할 수 있는 MCP 서버. ECS, Cloud Monitor, OOS 및 다양한 클라우드 제품 지원.  
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - VMware ESXi/vCenter 관리를 위한 MCP(Model Control Protocol) 기반 서버, 가상머신 관리를 위한 REST API 제공.
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - Cloudflare 서비스(Workers, KV, R2, D1 등)와의 통합
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - Cyclops 추상화를 통해 AI 에이전트가 Kubernetes 리소스를 관리할 수 있게 하는 MCP 서버
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - Fastly 서비스와의 통합
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - 파드, 디플로이먼트, 서비스 등 Kubernetes 클러스터 조작의 Typescript 구현.
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - Azure Resource Graph를 사용해 대규모로 Azure 리소스 쿼리·분석이 가능한 Model Context Protocol 서버로, AI 비서가 Azure 인프라 탐색 및 모니터링 지원.
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Azure CLI 명령줄을 래핑하여 Azure와 직접 통신 가능
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - Netskope Private Access 환경 내 모든 구성 요소 접근을 위한 MCP. 상세한 설정 정보와 LLM 사용 예제 포함.
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 A - OpenShift 추가 지원이 포함된 강력한 Kubernetes MCP 서버. 모든 Kubernetes 리소스에 대한 CRUD 작업 외에도 클러스터 상호작용을 위한 특수 도구 제공.
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - AI 비서가 Terraform 환경을 관리·운영할 수 있는 Terraform MCP 서버. 구성 읽기, 계획 분석, 적용, 상태 관리 등 지원.
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - Pulumi Automation API 및 Pulumi Cloud API를 사용해 Pulumi와 상호작용하는 MCP 서버. MCP 클라이언트가 패키지 정보 조회, 변경사항 미리보기, 업데이트 배포, 스택 출력 조회 등 Pulumi 작업을 프로그래밍 방식으로 수행 가능.
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - Claude, Cursor 등 AI 비서가 자연어로 Kubernetes 클러스터와 상호작용할 수 있도록 하는 Model Context Protocol(MCP) 서버.
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - MCP를 통한 Kubernetes 클러스터 작업
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - Nutanix Prism Central 리소스와 인터페이스하는 Go 기반 MCP 서버.
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - 한 번의 호출로 최신 EC2 가격 정보 획득. 빠르고, 사전 파싱된 AWS 가격 카탈로그 기반.
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - MCP 멀티클러스터 Kubernetes 관리 및 운영 제공, 관리 인터페이스, 로깅, 주요 DevOps/개발 시나리오를 위한 50개 내장 도구 포함. 표준 및 CRD 리소스 모두 지원.
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - MCP 멀티클러스터 Kubernetes 관리 및 운영 제공. 프로젝트에 SDK로 통합 가능, DevOps/개발 시나리오용 50여 내장 도구 포함. 표준 및 CRD 리소스 지원.
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - 쿠버네티스 관리를 위한 MCP 서버로, 클러스터 및 애플리케이션 상태를 분석합니다.
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - Azure Data Lake Storage용 MCP 서버입니다. 컨테이너 관리, 컨테이너 파일의 읽기/쓰기/업로드/다운로드 및 파일 메타데이터 관리를 수행할 수 있습니다.
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S는 AI 기반 쿠버네티스 리소스 관리 도구로, 사용자가 자연어 상호작용을 통해 쿠버네티스 클러스터의 모든 리소스(Deployment, Service 등 기본 리소스와 사용자 정의 리소스 CRD 포함)를 조작할 수 있습니다. 복잡한 명령어를 외울 필요 없이 요구사항만 설명하면 AI가 정확하게 해당 클러스터 작업을 실행하여 쿠버네티스의 사용성을 크게 높여줍니다.
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - 자연어를 사용하여 Redis Cloud 리소스를 손쉽게 관리하세요. 데이터베이스 생성, 구독 모니터링, 클라우드 배포 구성 등을 간단한 명령어로 수행할 수 있습니다.
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - AI 어시스턴트가 Portainer 인스턴스와 원활하게 상호작용할 수 있도록 하는 강력한 MCP 서버로, 자연어 기반 컨테이너 관리, 배포 작업, 인프라 모니터링 기능을 제공합니다.

### 👨‍💻 <a name="code-execution"></a>코드 실행

코드 실행 서버. LLM이 보안 환경에서 코드를 실행할 수 있도록 허용합니다(예: 코딩 에이전트용).

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- MCP 도구 호출을 통해 안전한 샌드박스에서 Python 코드를 실행합니다.
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - LLM이 생성한 모든 코드를 안전하고 확장 가능한 샌드박스 환경에서 실행하며, JavaScript 또는 Python으로 자신만의 MCP 도구를 만들 수 있습니다. NPM 및 PyPI 패키지 완벽 지원.
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP: 기존 API 문서를 활용하여 AI 에이전트가 모든 API에 접근할 수 있도록 하는 도커 기반 MCP 서버.
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – Node.js MCP 서버로, 격리된 Docker 기반 샌드박스를 즉시 생성하여 JavaScript 스니펫을 실행하고 npm 의존성을 실시간으로 설치하며, 클린 업(정리) 기능 지원.
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - v8 엔진을 활용해 코드를 격리하여 AI가 생성한 자바스크립트를 로컬에서 안전하게 실행하는 자바스크립트 코드 실행 샌드박스입니다. 지속 세션을 위한 힙 스냅샷 지원.

### 🤖 <a name="coding-agents"></a>코딩 에이전트

LLM이 코드를 읽고, 편집하고, 실행하며, 일반적인 프로그래밍 과제를 완전히 자율적으로 해결할 수 있게 해주는 전체 코딩 에이전트.

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - 언어 서버를 사용한 심볼릭 코드 작업에 기반한 완전한 기능의 코딩 에이전트.
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - 기본 읽기, 쓰기, 명령줄 도구가 포함된 코딩 에이전트.
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - AI 모델이 LeetCode 문제를 검색, 조회, 해결할 수 있도록 해주는 MCP 서버. 메타데이터 필터링, 사용자 프로필, 제출 및 콘테스트 데이터 접근 지원.
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - **LeetCode**의 프로그래밍 문제, 풀이, 제출, 공개 데이터에 자동으로 접근할 수 있는 MCP 서버로, 사용자별 기능(예: 노트)을 위한 인증 옵션 지원. `leetcode.com`(글로벌) 및 `leetcode.cn`(중국) 사이트 모두 지원.
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - Claude와 같은 AI가 VS Code 워크스페이스의 디렉토리 구조를 읽고, 린터 및 언어 서버에서 감지한 문제를 확인하고, 코드 파일을 읽고, 편집할 수 있도록 하는 MCP 서버.
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - 언어에 관계없이 소스 코드를 AST로 변환하는 단일 바이너리 MCP 서버.

### 🖥️ <a name="command-line"></a>명령줄

명령 실행, 출력 캡처, 셸 및 명령줄 도구와의 상호작용.

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - Model Context Protocol 서버로 iTerm 접근을 제공합니다. 명령 실행 및 터미널에서 보이는 내용에 대해 질문할 수 있습니다.
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - `run_command`와 `run_script` 도구로 어떤 명령이든 실행.
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - HF Smolagents `LocalPythonExecutor`를 기반으로 한 안전한 Python 인터프리터
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - 안전한 실행과 맞춤형 보안 정책을 갖춘 명령줄 인터페이스
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - DeepSeek MCP 유사 서버(터미널용)
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - Model Context Protocol(MCP)을 구현한 안전한 셸 명령 실행 서버
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - 네트워크 장치와의 구조적, 모델 기반 상호작용을 위한 Cisco pyATS 서버.
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - 프로그램 관리/실행, 코드 및 텍스트 파일 읽기/쓰기/검색/편집이 가능한 다용도 MCP 서버.
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - Model Context Protocol을 통해 리눅스 및 윈도우 서버의 SSH 제어를 제공하는 MCP 서버. 비밀번호 또는 SSH 키 인증으로 원격 셸 명령을 안전하게 실행.

### 💬 <a name="communication"></a>커뮤니케이션

메시지 관리 및 채널 운영을 위한 커뮤니케이션 플랫폼 연동. AI 모델이 팀 커뮤니케이션 도구와 상호작용할 수 있도록 지원합니다.

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - Nostr와 상호작용할 수 있는 MCP 서버로, 노트 게시 등 다양한 기능을 제공합니다.
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - 트위터 검색 및 타임라인과 상호작용
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - 이메일을 실시간으로 생성하여 발송, 수신 및 작업이 가능한 MCP 서버. 이메일을 위한 AI 에이전트가 아닌, AI 에이전트를 위한 이메일.
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - Google Tasks API 연동을 위한 MCP 서버
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - Model Context Protocol(MCP)을 통해 iMessage 데이터베이스와 안전하게 연동하는 MCP 서버로, LLM이 iMessage 대화를 쿼리 및 분석할 수 있게 해줍니다. 전화번호 검증, 첨부파일 처리, 연락처 및 그룹채팅 관리, 메시지 송수신 완벽 지원.
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - Telegram API 연동으로 사용자 데이터 접근, 대화(채팅, 채널, 그룹) 관리, 메시지 조회 및 읽음 처리 지원
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - Telegram API 연동으로 사용자 데이터 접근, 대화(채팅, 채널, 그룹) 관리, 메시지 조회/송신 및 읽음 처리 지원.
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - Inbox Zero를 위한 MCP 서버. Gmail 위에 기능을 추가하여 답장이 필요한 이메일, 후속 조치가 필요한 이메일을 파악할 수 있음.
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - AI Agent에서 개인 ntfy 서버로 ntfy 알림을 송수신할 수 있는 ntfy MCP 서버(보안 토큰 인증 등 지원, npx 또는 docker로 사용 가능)
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - 다양한 유형의 메시지를 WeCom 그룹 로봇에 전송하는 MCP 서버 애플리케이션.
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - Model Context Protocol(MCP)을 통해 iMessage 데이터베이스에 안전하게 접근할 수 있는 MCP 서버. LLM이 전화번호 검증 및 첨부파일 처리를 포함하여 iMessage 대화를 쿼리/분석 가능.
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - [ACP](https://agentcommunicationprotocol.dev) 생태계에 어댑터 역할을 하는 MCP 서버. ACP 에이전트를 MCP 클라이언트에 노출하여 두 프로토콜 간 통신을 연결.
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - Mattermost 팀, 채널, 메시지에 접근할 수 있는 MCP 서버 및 MCP 호스트. Mattermost에 봇으로 통합되어 MCP 서버 접근 가능.
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - 개인 WhatsApp 메시지, 연락처 검색 및 개인/그룹 메시지 전송이 가능한 MCP 서버
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - LINE 공식 계정 연동 MCP 서버
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - Gmail 및 Google Calendar 연동
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - Bluesky 인스턴스 연동으로 쿼리 및 상호작용 지원
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - Slack 워크스페이스 연동으로 채널 관리 및 메시징 지원
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - Slack 워크스페이스를 위한 강력한 MCP 서버.
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 VRChat API와 상호작용하기 위한 MCP 서버. VRChat에서 친구, 월드, 아바타 등 정보를 조회 가능.
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - Google Calendar API 연동 MCP 서버. TypeScript 기반.
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - ntfy를 사용해 휴대폰으로 알림을 전송하는 MCP 서버
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - [DIDLogic](https://didlogic.com) 연동 MCP 서버. SIP 엔드포인트, 번호, 목적지 관리 기능 제공.
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - Google Tasks 관리용 MCP 서버
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - Microsoft Teams 메시징(읽기, 게시, 멘션, 멤버/스레드 목록) 연동 MCP 서버
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - Graph API를 사용해 Microsoft 365 전체(메일, 파일, Excel, 캘린더 등)에 연결하는 MCP 서버
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - YCloud의 WhatsApp Business Platform 연동 MCP 서버.
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - Product Hunt 연동 MCP 서버. 인기 게시물, 댓글, 컬렉션, 사용자 등과 상호작용.

### 👤 <a name="customer-data-platforms"></a>고객 데이터 플랫폼

고객 데이터 플랫폼 내 고객 프로필 접근 제공

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - [iaptic](https://www.iaptic.com)와 연동하여 고객 구매, 거래 데이터, 앱 매출 통계 조회.
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - Model Context Protocol로 오픈 데이터를 모든 LLM에 연결.
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - Apache Unomi CDP 서버에서 프로필 조회 및 업데이트를 위한 MCP 서버.
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - MCP 클라이언트에서 Tinybird Workspace와 상호작용할 수 있는 MCP 서버.
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - [AntV](https://github.com/antvis)를 사용한 시각화 차트 생성을 위한 Model Context Protocol 서버.

### 🗄️ <a name="databases"></a>데이터베이스

스키마 검사 기능을 갖춘 안전한 데이터베이스 접근. 읽기 전용 등 보안 제어 설정이 가능하며 데이터 쿼리 및 분석 지원.

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ - [Aiven projects](https://go.aiven.io/mcp-server) 탐색 및 PostgreSQL®, Apache Kafka®, ClickHouse®, OpenSearch® 서비스와 상호작용
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - SQL 쿼리 실행 및 데이터베이스 탐색 도구를 지원하는 Supabase MCP 서버
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - Tablestore용 MCP 서비스로, 문서 추가, 벡터 및 스칼라 기반 의미론적 검색, RAG 친화적, 서버리스 지원.
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - NodeJS 기반 MySQL 데이터베이스 연동, 접근 제어 및 스키마 검사 기능 제공
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – 주류 데이터베이스를 지원하는 범용 데이터베이스 MCP 서버.
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - 스키마 검사 및 쿼리 기능이 있는 TiDB 데이터베이스 연동
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - Model Context Protocol(MCP) 클라이언트 및 AI 에이전트를 위한 시맨틱 엔진
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - 데이터베이스 스키마 및 데이터 기반 자동 API 생성 MCP 및 MCP SSE 서버. PostgreSQL, Clickhouse, MySQL, Snowflake, BigQuery, Supabase 지원
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - PACS 및 기타 DICOM 호환 시스템에서 의료 이미징 및 리포트를 쿼리, 읽기, 이동할 수 있는 DICOM 연동
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - 로컬 및 클라우드 Chroma 인스턴스 접근을 위한 Chroma MCP 서버(검색 기능 제공)
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - 스키마 검사 및 쿼리 기능이 있는 ClickHouse 데이터베이스 연동
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - Confluent Kafka 및 Confluent Cloud REST API와 상호 작용하기 위한 Confluent 통합.
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - Couchbase MCP 서버는 Capella 클라우드와 자체 관리형 클러스터 모두에 대해 문서 작업, SQL++ 쿼리 및 자연어 데이터 분석을 위한 통합 액세스를 제공합니다.
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - Elasticsearch와의 상호작용을 제공하는 MCP 서버 구현
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - 성능 분석, 튜닝 및 상태 점검 도구를 포함한 Postgres 개발 및 운영을 위한 올인원 MCP 서버
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - Trino 클러스터에서 데이터 쿼리 및 액세스를 위한 Trino MCP 서버.
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - Trino용 Model Context Protocol (MCP) 서버의 Go 구현
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - 구성 가능한 액세스 제어, 스키마 검사, 포괄적인 보안 지침을 갖춘 MySQL 데이터베이스 통합
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - SSE, STDIO 지원; MySQL의 CRUD 기능에만 국한되지 않으며, 데이터베이스 예외 분석 기능 포함; 역할 기반 데이터베이스 권한 제어; 개발자가 맞춤형 도구 확장 용이
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - 스키마 검사, 읽기 및 쓰기 기능을 갖춘 Airtable 데이터베이스 통합
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - Nocodb 데이터베이스 통합, 읽기 및 쓰기 기능 제공
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - Google BigQuery 통합을 위한 서버 구현으로 직접 BigQuery 데이터베이스 접근 및 쿼리 기능 제공
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - 안전한 MySQL 데이터베이스 작업을 제공하는 Node.js 기반 MySQL 데이터베이스 통합
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - 다중 사용자 동기화를 지원하는 Fireproof 원장 데이터베이스
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – Golang으로 구축된 고성능 멀티 데이터베이스 MCP 서버로, MySQL & PostgreSQL 지원 (NoSQL 곧 지원 예정). 쿼리 실행, 트랜잭션 관리, 스키마 탐색, 쿼리 빌딩, 성능 분석을 위한 내장 도구와, 데이터베이스 워크플로우 향상을 위한 Cursor 통합 포함.
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDB 데이터베이스를 위한 MCP 서버: MongoDB Lens의 모든 기능 제공
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - Auth, Firestore, Storage 등 Firebase 서비스 통합.
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - 테이블, 함수 탐색 및 일회성 쿼리 실행을 위한 Convex 데이터베이스 통합 ([소스](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts))
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - 데이터베이스를 위한 쉽고 빠르며 안전한 도구에 특화된 오픈소스 MCP 서버.
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - GreptimeDB 쿼리를 위한 MCP 서버.
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - Model Context Protocol(MCP)을 통해 SQLite 데이터베이스에 안전하게 읽기 전용 액세스를 제공하는 MCP 서버. FastMCP 프레임워크로 구축되어 LLM이 내장된 안전 기능과 쿼리 검증으로 SQLite 데이터베이스를 탐색 및 쿼리할 수 있게 함.
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - InfluxDB OSS API v2에 대한 쿼리 실행
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - 읽기 및 (선택적) 쓰기 작업과 인사이트 추적을 구현한 Snowflake 통합
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - Supabase에서 프로젝트 및 조직을 관리하고 생성하는 Supabase MCP 서버
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - Apache Kafka 및 Timeplus용 MCP 서버. Kafka 토픽 나열, 메시지 폴링, Kafka 데이터 로컬 저장, Timeplus를 통한 SQL 기반 스트리밍 데이터 쿼리 기능 제공
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - 컬렉션 및 인덱스 소개, 벡터 저장 및 검색 기능을 갖춘 VikingDB 통합.
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - MongoDB용 Model Context Protocol 서버
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - 스키마 검사 및 쿼리 기능을 갖춘 DuckDB 데이터베이스 통합
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - 스키마 검사 및 쿼리 기능을 갖춘 BigQuery 데이터베이스 통합
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - JDBC 호환 데이터베이스에 연결하여 쿼리, 삽입, 수정, 삭제 등 다양한 작업 수행 가능.
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - SQLite 데이터베이스와의 포괄적 상호작용 기능을 제공하는 Model Context Protocol (MCP) 서버.
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - Memgraph MCP 서버 - Memgraph 쿼리 실행 및 스키마 리소스를 위한 도구 포함.
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - 스키마 검사 및 쿼리 기능을 갖춘 PostgreSQL 데이터베이스 통합
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - 내장 분석 기능을 갖춘 SQLite 데이터베이스 작업
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Neo4j와 함께하는 Model Context Protocol (쿼리 실행, 지식 그래프 메모리, Neo4j Aura 인스턴스 관리)
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — Neon Serverless Postgres를 이용해 Postgres 데이터베이스 생성 및 관리를 위한 MCP 서버
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) Nile의 Postgres 플랫폼을 위한 MCP 서버 - LLM을 사용하여 Postgres 데이터베이스, 테넌트, 사용자, 인증 관리 및 쿼리
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - Open Database Connectivity (ODBC) 프로토콜을 통한 범용 데이터베이스 관리 시스템(DBMS) 연결용 MCP 서버
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - Python ODBC(pyodbc)를 사용한 SQLAlchemy 기반 범용 데이터베이스 관리 시스템(DBMS) 연결용 MCP 서버
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - Azure Data Explorer 데이터베이스 쿼리 및 분석
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ -  Prometheus(오픈소스 모니터링 시스템) 쿼리 및 분석
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - LLM이 Prisma Postgres 데이터베이스를 관리할 수 있도록 지원 (예: 새 데이터베이스 인스턴스 실행 또는 스키마 마이그레이션)
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - Qdrant용 MCP 서버
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - LLM이 데이터베이스와 직접 상호작용할 수 있도록 하는 MongoDB 통합.
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - AI 도구를 Airtable에 직접 연결. 자연어로 레코드 쿼리, 생성, 수정, 삭제. 기본 관리, 테이블 작업, 스키마 조작, 레코드 필터링, 표준 MCP 인터페이스를 통한 데이터 마이그레이션 기능 제공.
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - Redis 공식 MCP 서버로, Redis에서 데이터 관리 및 검색 인터페이스 제공
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - PostgreSQL, MySQL, MariaDB, SQLite, Oracle, MS SQL Server 등 다수 데이터베이스 지원하는 범용 SQLAlchemy 기반 데이터베이스 통합. 스키마 및 관계 검사, 대규모 데이터셋 분석 기능 제공.
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - 벡터 검색 기능을 갖춘 Pinecone 통합
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - 서버리스 MariaDB 클라우드 DB MCP 서버. SQL 실행, DB 인스턴스 생성/삭제, DB 수준 AI 에이전트와의 텍스트-투-SQL 및 대화 지원 도구 제공.
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - 공식 Supabase MCP 서버로, AI 어시스턴트가 Supabase 프로젝트에 직접 연결하여 테이블 관리, 구성 가져오기, 데이터 쿼리 등 작업 수행 가능
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 PostgreSQL, Redshift, CockroachDB, MySQL, RDS MySQL, Microsoft SQL Server, BigQuery, Oracle DB, SQLite 등 다양한 데이터베이스 유형을 지원하는 범용 MCP 서버
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - 스키마 검사 및 쿼리 기능을 갖춘 TDolphinDB 데이터베이스 통합
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - Weaviate 컬렉션을 지식베이스로 연결하거나 채팅 메모리 저장소로 사용할 수 있는 MCP 서버
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — XiyanSQL 기반 텍스트-투-SQL LLM으로 자연어 쿼리를 사용해 데이터베이스에서 데이터를 가져오는 MCP 서버
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - Google Sheets와 상호작용하기 위한 Model Context Protocol 서버. Google Sheets API를 통해 스프레드시트 생성, 읽기, 수정 및 관리 도구 제공.
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - Google Sheets API 통합용 MCP 서버로, 포괄적인 읽기, 쓰기, 서식 지정 및 시트 관리 기능 지원
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – 사용이 간편하고 의존성 없는 Golang 기반 MySQL MCP 서버로, 구성 가능한 읽기 전용 모드 및 스키마 검사 지원
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - [YDB](https://ydb.tech) 데이터베이스와 상호작용하기 위한 MCP 서버
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - Milvus / Zilliz용 MCP 서버로 데이터베이스와의 상호작용을 가능하게 함
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - Java Database Connectivity (JDBC) 프로토콜을 통한 범용 데이터베이스 관리 시스템(DBMS) 연결용 MCP 서버
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - VictoriaMetrics 데이터베이스와 상호작용하기 위한 MCP 서버.
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - Hydrolix 시계열 데이터레이크 통합으로 LLM 기반 워크플로우에 스키마 탐색 및 쿼리 기능 제공
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 – Cursor 및 n8n용 사용자 친화적인 읽기 전용 mysql mcp 서버


### 📊 <a name="data-platforms"></a>데이터 플랫폼

데이터 통합, 변환 및 파이프라인 오케스트레이션을 위한 데이터 플랫폼.

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - Flowcore와 상호작용하여 작업 수행, 데이터 수집, 데이터 코어 또는 공개 데이터 코어 내의 데이터를 분석, 상호 참조 및 활용. 모든 작업을 자연어로 지원.
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - Databricks API에 연결하여 LLM이 SQL 쿼리 실행, 작업 목록 조회, 작업 상태 확인 가능
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - Databricks Genie API에 연결하여 LLM이 자연어 질문, SQL 쿼리 실행, Databricks 대화형 에이전트와 상호작용 가능
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - Qlik Cloud API용 MCP 서버로, 인증 및 속도 제한 기능과 함께 애플리케이션, 시트 쿼리 및 시각화 데이터 추출 지원
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - Keboola Connection Data Platform과 상호작용. Keboola Storage API에서 데이터 목록화 및 접근 도구 제공
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt) 공식 MCP 서버. dbt Core/Cloud CLI 통합, 프로젝트 메타데이터 탐색, 모델 정보, 시맨틱 레이어 쿼리 기능 제공.
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - dbt-core(OSS) 사용자용 MCP 서버 (공식 dbt MCP는 dbt Cloud만 지원). 프로젝트 메타데이터, 모델 및 컬럼 수준 계보, dbt 문서 지원.

### 💻 <a name="developer-tools"></a>개발자 도구

개발 워크플로우 및 환경 관리 향상을 위한 도구와 통합.

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - macOS에서 리소스 집약적 프로세스를 식별하고 성능 개선 제안 제공
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - 최고의 21st.dev 디자인 엔지니어에게 영감을 받은 맞춤형 UI 컴포넌트 생성
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - [QA Sphere](https://qasphere.com/) 테스트 관리 시스템 통합. LLM이 테스트 케이스를 AI IDE에서 직접 탐색, 요약, 상호작용 가능
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - 코드베이스 내의 의존성 관계를 기반으로 중요한 파일 식별. 다이어그램 및 중요도 점수 생성으로 AI 어시스턴트가 코드베이스 이해 지원
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 iOS 시뮬레이터 제어를 위한 MCP 서버 구현
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 [Apache APISIX](https://github.com/apache/apisix) 내 모든 리소스 쿼리 및 관리 지원 MCP 서버
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 - SonarQube 프로젝트에 대한 메트릭(실제 및 이력), 이슈, 상태 정보를 조회하는 도구를 제공하는 Model Context Protocol (MCP) 서버
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - AI 에이전트와 어떤 API도 원활하게 통합 (OpenAPI 스키마 지원)
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - 로컬에서 리액트 코드 분석, 전체 프로젝트에 대한 문서/llm.txt 생성
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - POX SDN 컨트롤러용 MCP 서버로 네트워크 제어 및 관리 기능 제공
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - CodeLogic 공식 MCP 서버, 코드 의존성 분석, 아키텍처 리스크 분석, 영향 평가 도구 제공
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - 자연어로 Opik이 수집한 LLM 관측, 추적, 모니터링 데이터 탐색
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ AI 에이전트가 CircleCI 빌드 실패를 수정할 수 있도록 지원
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ AI 에이전트가 [Currents](https://currents.dev)에 보고된 Playwright 테스트 실패를 수정할 수 있도록 지원
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - [Postman API](https://www.postman.com/postman/postman-public-workspace/)와 상호작용
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - AI 어시스턴트가 [Flipt](https://flipt.io)의 피처 플래그와 상호작용 가능
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - 코딩 에이전트가 Figma 데이터를 직접 액세스해 원샷 디자인 구현 지원
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - [Firefly](https://firefly.ai)와 통합해 클라우드 리소스 탐색, 관리, 코드화 지원
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - 특정 Rust 크레이트에 대해 최신 문서 컨텍스트를 LLM에 제공하는 MCP 도구. 의미적 검색(임베딩) 및 LLM 요약 사용
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - 워크북 생성, 데이터 작업, 서식 지정, 고급 기능(차트, 피벗 테이블, 수식) 등을 제공하는 엑셀 조작 서버
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - [Higress](https://github.com/alibaba/higress) 게이트웨이 구성과 운영을 관리하기 위한 종합 도구를 제공하는 MCP 서버.
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - Postman/Insomnia와 같은 Rest 클라이언트를 대체하기 위한 MCP 서버로, LLM이 API 컬렉션을 유지 및 활용할 수 있도록 함.
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - [Go의 Language Server Protocol (gopls)](https://github.com/golang/tools/tree/master/gopls)과 상호작용하며 고급 Go 코드 분석 기능을 제공하는 MCP 서버.
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - [Bruno API Client](https://www.usebruno.com/)와 상호작용하기 위한 MCP 서버.
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - MCP를 통해 AI로 안드로이드 기기를 제어하며, 기기 제어, 디버깅, 시스템 분석, UI 자동화, 포괄적 보안 프레임워크 제공.
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - MCP를 통해 AI로 HarmonyOS-next 기기를 제어. 기기 제어 및 UI 자동화 지원.
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - Gradle Tooling API를 활용하여 프로젝트 검사, 작업 실행, 테스트 별 결과 리포팅을 지원하는 Gradle 통합 MCP 서버
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - 다양한 이미지 포맷의 로컬 압축을 위한 MCP 서버.
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - MCP Language Server는 MCP 지원 클라이언트가 get definition, references, rename, diagnostics 등 의미론적 도구를 통해 코드베이스를 쉽게 탐색하도록 지원.
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - iOS 시뮬레이터와 상호작용하기 위한 Model Context Protocol (MCP) 서버. 시뮬레이터 정보 조회, UI 제어, UI 요소 검사 가능.
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - 자연어 명령을 통해 LLM이 iOS 시뮬레이터(iPhone, iPad 등)와 상호작용하도록 지원하는 MCP 서버.
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - Vercel AI SDK 문서에 대한 AI 기반 검색 및 질의 기능을 제공하는 MCP 서버.
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - [SQLGlot](https://github.com/tobymao/sqlglot)을 사용한 SQL 분석, 린팅, 방언 변환 기능을 제공하는 MCP 서버
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - 언어에 무관하게 자동 디버깅(중단점, 표현식 평가)을 지원하는 MCP 서버 및 VS Code 확장.
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - JetBrains IDE에 연결
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - 성능 테스트용 JMeter MCP 서버
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - macOS Keychain을 이용해 프로젝트 간 안전하게 API 키를 저장 및 접근할 수 있는 개인용 MCP 서버.
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - iOS 개발자를 위한 App Store Connect API와 통신하는 MCP 서버
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - iOS 시뮬레이터를 제어하기 위한 MCP 서버
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - 성능 테스트용 Grafana k6 MCP 서버
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - 동일 MCP 서버의 여러 격리 인스턴스를 고유 네임스페이스와 설정으로 독립적으로 공존하도록 하는 미들웨어 서버.
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) 프롬프트 관리로 만든 LLM 애플리케이션 프롬프트 접근 및 관리용 MCP 서버.
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - Android/iOS 앱 및 기기 자동화, 개발, 앱 스크래핑을 위한 MCP 서버. 시뮬레이터, 에뮬레이터, 실제 기기(iPhone, Google Pixel, Samsung 등) 지원.
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - 성능 테스트용 Locust MCP 서버
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - Cline, Cursor 등 도구에서 human-in-the-loop 워크플로우를 지원하는 간단한 MCP 서버.
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - [gitingest](https://github.com/cyclotruc/gitingest)를 이용해 모든 Git 저장소를 코드베이스의 간단한 텍스트 요약으로 변환하는 MCP 서버.
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - 선호하는 AI 에이전트가 코드베이스 또는 Jira, Slack, TestRail 등 데이터 소스에서 [Octomind](https://www.octomind.dev/) 엔드 투 엔드 테스트를 자동 생성·실행.
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - MCP 리소스를 통해 OpenAPI/Swagger 스펙에 토큰 효율적으로 접근.
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - wget을 이용해 전체 웹사이트를 다운로드하는 도구를 제공하는 MCP 서버. 웹사이트 구조를 보존하고 링크를 로컬에서 동작하도록 변환.
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - NixOS 패키지, 시스템 옵션, Home Manager 구성, nix-darwin macOS 설정에 대한 정확한 정보를 제공하여 AI 환각 방지.
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - MCP를 통한 Docker 컨테이너 관리 및 운영
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - Docker와 연동하여 컨테이너, 이미지, 볼륨, 네트워크를 관리하는 MCP 서버.
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - 프로젝트 관리, 파일 작업, 빌드 자동화를 위한 Xcode 통합
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - LLM이 OpenAPI 사양을 탐색, 설명, 코드/모의 데이터 생성을 할 수 있게 하는 MCP 서버
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - 인시던트 관리 플랫폼 [Rootly](https://rootly.com/)용 MCP 서버.
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - LLM이 코드 작성 시 최신 안정 패키지 버전을 추천하는 데 도움을 주는 MCP 서버.
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - SonarQube와 연동하여 코드 품질 지표, 이슈, 품질 게이트 상태를 AI 어시스턴트에 제공하는 Model Context Protocol(MCP) 서버
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - MCP를 활용한 Claude Code 기능 구현체로, AI 코드 이해, 수정, 프로젝트 분석, 도구 지원 제공.
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - Open API spec(v3)으로 모든 HTTP/REST API 서버 연결
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - AI 바이너리 및 코어 파일 분석, 디버깅, 디스어셈블을 지원하는 LLDB용 MCP 서버.
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - HTML 콘텐츠를 EdgeOne Pages에 배포하고 공개 접근 가능한 URL을 얻을 수 있는 MCP 서비스.
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - 효율적인 부분 파일 접근으로 토큰 사용을 최소화한 LLM 도구 최적화 라인 기반 텍스트 파일 편집기.
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - Pandoc을 활용한 문서 포맷 변환(Markdown, HTML, PDF, DOCX, csv 등) MCP 서버.
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - VSCode IDE에 연결하고 `find_usages`와 같은 의미론 도구 사용
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 iOS Xcode 워크스페이스/프로젝트를 빌드하고 오류를 llm에 피드백.
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - JVM 기반 MCP(Model Context Protocol) 서버 구현 프로젝트.
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - 공식 클라이언트를 사용해 [Apache Airflow](https://airflow.apache.org/)와 연결하는 MCP 서버.
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - 아름다운 인터랙티브 마인드맵을 생성하는 Model Context Protocol(MCP) 서버.
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - 여러 Ollama 모델에 질의하고 응답을 결합하여 단일 질문에 대한 다양한 AI 관점을 제공하는 Model Context Protocol(MCP) 서버.
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - 에이전트가 훈련되지 않은 API와 작업할 수 있도록 Typescript API 정보를 효율적으로 제공하는 MCP 서버
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - JSON, 텍스트, HTML 데이터를 유연하게 가져오는 MCP 서버
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - [ZenML](https://www.zenml.io) MLOps 및 LLMOps 파이프라인과 연결하는 MCP 서버
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/)는 문서를 위한 모든 [GitHub](https://www.github.com) 저장소/프로젝트에 연결할 수 있는 범용 원격 MCP 서버
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - [Bugsnag](https://www.bugsnag.com/)과 상호작용하는 MCP 서버
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - CSV 파일용 MCP 서버.
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – Cursor AI와 같은 코딩 에이전트의 작업 메모리, 자기성찰, 의존성 관리 기능을 강화하는 프로그래밍 특화 작업 관리 시스템. [ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - Docker로 로컬에서 코드를 실행하고 여러 프로그래밍 언어를 지원하는 MCP 서버.
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - pkg.go.dev에서 Go 패키지 정보 질의
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - 기존 Gin 웹 프레임워크 API를 MCP 도구로 자동 노출하는 무설정 Go 라이브러리.
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - AI 어시스턴트가 GitHub 저장소를 탐색하고, 디렉터리 탐색 및 파일 내용 조회 가능.
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – [webhook-test.com](https://webhook-test.com)과 상호작용하는 FastMCP 기반 서버. Claude를 통해 웹훅 생성, 조회, 삭제 가능.
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - ROS 또는 ROS2 제어 명령으로 사용자의 자연어 명령을 변환하여 로봇 제어를 지원하는 ROS MCP 서버.
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - 전 세계 수천 곳에서 ping, traceroute, mtr, HTTP, DNS resolve 등 네트워크 도구 실행을 지원하는 Globalping MCP 서버.
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - PostHog 분석, 피처 플래그, 오류 추적 등과 상호작용하는 MCP 서버.
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - NPM, Cargo, PyPi, NuGet 패키지의 최신 정보 검색 및 제공 MCP 서버.

### 🔒 <a name="delivery"></a>Delivery

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – DoorDash 배달 (비공식)

### 🧮 <a name="data-science-tools"></a>데이터 과학 도구

데이터 탐색, 분석을 단순화하고 데이터 과학 워크플로우를 강화하는 통합 및 도구.

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - Chronulus AI 예측 에이전트로 무엇이든 예측.
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - .csv 기반 데이터셋의 자율적 데이터 탐색을 지원하여 최소한의 노력으로 지능형 인사이트 제공.
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - 거의 모든 파일이나 웹 콘텐츠를 Markdown으로 변환하는 MCP 서버
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - Jupyter용 Model Context Protocol(MCP) 서버.
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - Claude AI가 Jupyter Notebook과 직접 상호작용 및 제어할 수 있도록 연결.
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - Kaggle에 연결하여 데이터셋 다운로드 및 분석 가능.
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - 여러 데이터 소스(SQL, CSV, Parquet 등)를 연결하고 AI에게 인사이트 및 시각화 분석 요청 가능.
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - 검증 가능하고 유지보수 용이한 데이터 차트·대시보드 생성을 위한 도구와 템플릿.
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — GrowthBook 피처 플래그 및 실험 생성·상호작용 도구.

### 📟 <a name="embedded-system"></a>임베디드 시스템

임베디드 장치 작업에 필요한 문서 및 단축키 제공.

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - ESP32 시리즈 칩의 빌드 문제 해결 워크플로우 (ESP-IDF 사용).
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - 산업용 Modbus 데이터를 표준화 및 맥락화하는 MCP 서버.
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - OPC UA 지원 산업 시스템에 연결하는 MCP 서버.
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - LLM이 RF `.grc` 플로우차트를 자율적으로 생성 및 수정할 수 있게 하는 GNU Radio용 MCP 서버.

### 📂 <a name="file-systems"></a>파일 시스템

구성 가능한 권한으로 로컬 파일 시스템에 직접 접근 가능. AI 모델이 지정된 디렉터리 내에서 파일 읽기, 쓰기, 관리 가능.

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - MCP 또는 클립보드를 통해 LLM과 코드 컨텍스트 공유
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - AI 채팅 길이 제한에 적합한 파일 병합 도구.
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - Quarkus로 구현된 파일 브라우징/편집용 Java 기반 파일 시스템. jar 또는 네이티브 이미지로 제공.
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - 파일 나열, 읽기, 검색을 위한 Box 통합
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - Everything SDK를 사용한 빠른 Windows 파일 검색
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - 로컬 파일 시스템 액세스를 위한 Golang 구현.
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - 원격 스토리지 접근: SFTP, S3, FTP, SMB, NFS, WebDAV, GIT, FTPS, gcloud, azure blob, sharepoint 등.
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - MCP 도구로 MarkItDown에 접근 -- 다양한 파일 포맷(로컬 및 원격)을 LLM 용으로 Markdown으로 변환하는 라이브러리.
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - 직접적인 로컬 파일 시스템 접근.
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - 파일 나열, 읽기, 검색을 위한 Google Drive 통합
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - Apache OpenDAL™로 모든 스토리지에 접근
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - 자연어로 macOS Homebrew 설정을 제어할 수 있는 MCP 서버. 패키지 관리, 추천 요청, brew 문제 해결 등 간편하게 사용 가능.

### 💰 <a name="finance--fintech"></a>금융 & 핀테크

금융 데이터 접근 및 분석 도구. AI 모델이 시장 데이터, 트레이딩 플랫폼, 금융 정보와 함께 작동할 수 있도록 지원.

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - 암호화폐 심층 리서치 - 무료 및 완전 로컬
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - AI 에이전트가 Alchemy의 블록체인 API와 상호작용할 수 있도록 지원.
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - Octagon AI 에이전트로 사설 및 공공 시장 데이터 통합
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - 암호화폐 상장 및 시세를 가져오는 Coinmarket API 통합
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - AI LLM이 MetaTrader 5 플랫폼을 통해 트레이드 실행 가능
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - 여러 블록체인, 스테이킹, DeFi, 스왑, 브릿지, 지갑 관리, DCA, 지정가 주문, 코인 조회, 추적 등 다양한 기능 인터페이스 제공 MCP
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - 스마트 계약, 트랜잭션 및 토큰 정보 쿼리를 위한 Bankless Onchain API
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - 온체인 도구를 위한 Base Network 통합, 지갑 관리, 자금 이체, 스마트 계약, DeFi 작업을 위한 Base Network 및 Coinbase API와 연동
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - Alpha Vantage API 통합으로 주식 및 암호화폐 정보 수집
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - EVM 블록체인 주소(EOA, CA, ENS) 및 도메인 이름의 위험 점수 / 자산 보유 현황 제공.
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - 여러 블록체인에서 AI 에이전트 실행을 위한 Bitte Protocol 통합.
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - AI 에이전트를 [Chargebee 플랫폼](https://www.chargebee.com/)과 연결하는 MCP 서버.
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - 60개 이상의 네트워크에서 실시간으로 강화된 블록체인 및 시장 데이터 제공 [Codex API](https://www.codex.io) 통합 MCP
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - Coinpaprika의 DexPaprika MCP 서버가 고성능 [DexPaprika API](https://docs.dexpaprika.com) 를 노출, 20개 이상의 체인과 500만 개 이상의 토큰에 대한 실시간 시세, 유동성 풀, 과거 OHLCV 데이터 등 제공. Model Context Protocol을 통한 표준화된 시장 데이터 접근.
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - 20개 이상의 거래소에서 CCXT 라이브러리를 사용하여 실시간 암호화폐 시장 데이터 및 거래 접근. 현물, 선물, OHLCV, 잔고, 주문 등 지원.
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - 야후 파이낸스 통합으로 옵션 추천 등 주식 시장 데이터 수집
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - Tastytrade의 거래 활동을 처리하는 Tastyworks API 통합
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - WallStreetBets 커뮤니티 콘텐츠 분석을 위한 Reddit 통합
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - Nostr Wallet Connect 기반 비트코인 라이트닝 지갑 통합
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - Heurist Mesh 네트워크를 통해 블록체인 분석, 스마트 컨트랙트 보안 감사, 토큰 메트릭 평가, 온체인 상호작용 등 전문 Web3 AI 에이전트 접근 제공. DeFi 분석, NFT 가치 평가, 트랜잭션 모니터링 등 종합 도구 지원.
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper는 BSC의 트랜잭션, 잔고/토큰 전송, Pancakeswap 토큰 스왑, 리워드 클레임 기능 제공.
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ - BlockBeats의 블록체인 뉴스 및 심층 기사를 AI 에이전트에 제공하는 MCP 서버.
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - 온체인 AI 에이전트에게 실시간 크로스체인 브릿지 시세 및 최적 이체 경로 제공.
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ - Chainlink의 탈중앙 온체인 가격 피드 실시간 접근 제공.
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ - Cointelegraph의 최신 뉴스를 실시간으로 제공.
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ - 실시간 및 과거 암호화폐 Fear & Greed Index 데이터 제공.
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - 암호화폐 기술적 분석 지표 및 전략을 제공하는 MCP 서버.
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - NewsData에서 수집한 실시간 암호화폐 뉴스를 AI 에이전트에 제공하는 MCP 서버.
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - 암호화폐 포트폴리오 배분 추적 및 관리를 위한 MCP 서버.
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - 여러 RSS 피드에서 실시간 암호화폐 뉴스를 집계하는 MCP 서버.
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - 암호화폐 심리 분석 결과를 AI 에이전트에 제공하는 MCP 서버.
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - CoinGecko의 최신 트렌딩 토큰 추적.
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - 암호화폐 백서의 구조화된 지식 베이스 역할을 하는 MCP 서버.
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - CryptoPanic 기반으로 최신 암호화폐 뉴스를 AI 에이전트에 제공.
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - AI 에이전트가 DeFi 수익 기회를 탐색할 수 있도록 하는 MCP 서버.
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ - Dune Analytics 데이터를 AI 에이전트와 연결하는 MCP 서버.
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ - 암호화폐 ETF 유입/유출 데이터 제공을 통해 AI 에이전트의 의사결정 지원.
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - Freqtrade 암호화폐 트레이딩 봇과 통합하는 MCP 서버.
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - 주요 암호화폐 거래소의 실시간 펀딩 비율 데이터 제공.
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - Jupiter의 신규 Ultra API를 이용한 Solana 블록체인 토큰 스왑 실행 MCP 서버.
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ - Pancake Swap에서 새로 생성된 풀을 추적하는 MCP 서버.
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - Solana 밈 토큰의 잠재적 위험 탐지 MCP 서버.
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ - The Graph의 인덱싱된 블록체인 데이터를 AI 에이전트에 제공하는 MCP 서버.
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ - AI 에이전트가 여러 블록체인에서 ERC-20 토큰을 민팅할 수 있는 도구 제공 MCP 서버.
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - 여러 블록체인에서 ERC-20 토큰 승인 내역 확인 및 취소를 위한 MCP 서버.
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - 트위터 사용자명 변경 이력을 추적하는 MCP 서버.
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ - 여러 블록체인에서 Uniswap 신규 유동성 풀을 추적하는 MCP 서버.
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ - 여러 블록체인에서 AI 에이전트가 Uniswap DEX에서 토큰 스왑을 자동화할 수 있는 MCP 서버.
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ - 암호화폐 고래 트랜잭션을 추적하는 MCP 서버.
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - Alpaca 트레이딩 API MCP 서버로 주식/암호화폐 포트폴리오 관리, 거래, 시장 데이터 접근 가능.
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI는 실시간 주식 시장 데이터 제공 및 MCP를 통한 AI 접근 분석/거래 기능 제공.
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - 30개 이상의 EVM 네트워크를 위한 종합 블록체인 서비스, 네이티브 토큰, ERC20, NFT, 스마트 계약, 트랜잭션, ENS 해석 지원.
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - Starknet 블록체인 종합 통합, 네이티브 토큰(ETH, STRK), 스마트 계약, StarknetID 해석, 토큰 전송 지원.
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 - ledger-cli 통합을 통한 금융 거래 관리 및 보고서 생성.
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 - 고객, 대출, 예금, 주식, 금융 거래 관리 및 보고서 생성을 위한 코어 뱅킹 통합.
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - yfinance를 사용하여 Yahoo Finance에서 정보 획득하는 MCP 서버.
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ - [Polygon.io](https://polygon.io/)의 금융 시장 데이터 API(주식, 인덱스, 외환, 옵션 등) 접근을 위한 MCP 서버.
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ - Bitget API를 이용한 암호화폐 가격 조회.
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - CoinCap의 공개 API를 통한 실시간 암호화폐 시장 데이터 통합. API 키 없이 가격/시장 정보 접근 제공.
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - CoinGecko API를 이용해 암호화폐 시장 데이터 제공하는 MCP 도구.
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - 야후 파이낸스 MCP의 TS 버전.
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Yahoo Finance API를 사용해 주식 시장 데이터 및 분석 제공하는 MCP 도구.
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - XRP Ledger용 MCP 서버로 계정 정보, 트랜잭션 이력, 네트워크 데이터 접근 제공. 원장 객체 쿼리, 트랜잭션 제출, XRPL 네트워크 모니터링 가능.
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - 오픈 및 무료 Dexscreener API를 이용한 실시간 온체인 시장 가격 제공
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - 중국 주식 시장 데이터 접근 및 분석 기능 제공 baostock 기반 MCP 서버.
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - Solscan API와 자연어로 Solana 트랜잭션을 쿼리하는 MCP 도구.
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - 부동산 관리 산업 특화 지능형 어시스턴트인 CRIC Wuye AI 플랫폼 기능과 상호작용하는 MCP 서버.
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - Tushare 등 여러 데이터 제공업체를 지원하는 전문 금융 데이터 접근 MCP 서버.

### 🎮 <a name="gaming"></a>게임

게임 관련 데이터, 게임 엔진, 서비스와의 통합

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - Unity 에디터 및 Unity로 제작된 게임을 위한 MCP 서버
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - 게임 개발용 Unity3d 게임 엔진 통합 MCP 서버
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - Godot 게임 엔진과 상호작용하기 위한 MCP 서버, Godot 프로젝트의 씬 편집, 실행, 디버깅, 관리 도구 제공.
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - Chess.com 플레이어 데이터, 게임 기록, 기타 공개 정보에 표준 MCP 인터페이스로 접근, AI 어시스턴트가 체스 정보 검색 및 분석 가능.
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - LLM과 체스를 두는 MCP 서버.
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - 실시간 Fantasy Premier League 데이터 및 분석 도구를 위한 MCP 서버.
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - 리그 오브 레전드, TFT, 발로란트 등 인기 타이틀의 실시간 게임 데이터, 챔피언 분석, e스포츠 일정, 메타 조합, 캐릭터 통계 제공.
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - RuneScape(RS)와 Old School RuneScape(OSRS) 데이터와 상호작용하는 도구(MCP 서버), 아이템 시세, 플레이어 하이스코어 등 지원.

### 🧠 <a name="knowledge--memory"></a>지식 & 메모리

지식 그래프 구조를 활용한 영구 메모리 저장소. AI 모델이 세션을 초월해 구조화된 정보를 유지하고 질의할 수 있도록 지원.
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - AI 역할극과 스토리 생성에 중점을 둔 향상된 그래프 기반 메모리
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - Slack, Discord, 웹사이트, Google Drive, Linear 또는 GitHub에서 Graphlit 프로젝트로 모든 것을 가져오고, MCP 클라이언트(Cursor, Windsurf, Cline 등) 내에서 관련 지식을 검색 및 조회할 수 있음
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - 벡터 검색을 통한 문서 검색 및 처리를 지원하는 MCP 서버 구현으로, AI 비서가 관련 문서 컨텍스트를 활용하여 응답을 보강할 수 있도록 도구를 제공
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - [markmap](https://github.com/markmap/markmap) 기반 MCP 서버로 **Markdown**을 대화형 **마인드맵**으로 변환. PNG/JPG/SVG 다중 포맷 내보내기, 실시간 브라우저 미리보기, 원클릭 Markdown 복사, 동적 시각화 기능 지원
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - LLM이 Zotero Cloud의 컬렉션과 소스를 다룰 수 있도록 해주는 커넥터
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - AI 요약 MCP 서버, 다양한 콘텐츠 유형 지원: 일반 텍스트, 웹 페이지, PDF 문서, EPUB 도서, HTML 콘텐츠
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - Mem0용 Model Context Protocol 서버로, IDE(Cursor, Windsurf 등) 내에서 코드 구현, 모범 사례, 기술 문서를 저장·검색·의미론적으로 처리하는 도구 제공
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - 컨텍스트 유지를 위한 지식 그래프 기반 영속적 메모리 시스템
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - Pinecone Assistant와 연결하여 에이전트에게 지식 엔진의 컨텍스트를 제공
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - Google Drive, Notion, JIRA 등과 연동된 [Ragie](https://www.ragie.ai) (RAG) 지식베이스에서 컨텍스트를 검색
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - Cursor, VS Code, Claude Desktop 등 AI 도구가 제품 문서를 활용해 질문에 답하도록 지원. Biel.ai가 RAG 시스템과 MCP 서버 제공
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - 30+ 데이터 소스 인입, 다양한 그래프/벡터 스토어 활용 AI 앱 및 에이전트용 메모리 관리자
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - Membase로 분산 방식의 에이전트 메모리 저장 및 질의
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - GitHub Gist로 개인 지식, 일일 노트, 재사용 가능한 프롬프트 관리 및 접근. https://gistpad.dev 및 [GistPad VS Code 확장](https://aka.ms/gistpad) 보조 도구
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - Zettelkasten 지식관리 방법론을 구현한 MCP 서버로, Claude 및 MCP 호환 클라이언트에서 원자적 노트 생성·연결·검색 지원

### 🗺️ <a name="location-services"></a>위치 서비스

위치 기반 서비스 및 매핑 도구. AI 모델이 지리 데이터, 날씨 정보, 위치 기반 분석을 다룰 수 있도록 지원

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - IPInfo API를 사용한 IP 주소 위치 및 네트워크 정보 제공
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - WeatherAPI.com API를 통해 실시간 위치별 날씨 데이터, 상세 예보, 현재 상태 접근
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - 위치 기반 서비스와 지리공간 데이터를 제공하는 OpenStreetMap MCP 서버
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - IP 기반 위치 감지로 인근 장소 검색을 위한 MCP 서버
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - 위치 서비스, 경로 안내, 장소 정보용 Google Maps 통합
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - QGIS Desktop을 Claude AI와 MCP로 연결. 프롬프트 기반 프로젝트 생성, 레이어 로딩, 코드 실행 등 가능
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - OpenWeatherMap API를 활용, 실시간 날씨, 예보, 과거 날씨 정보 제공 MCP 도구
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - 전 세계 어디서나 7일간 상세 예보 제공 Weekly Weather MCP 서버
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - 모든 타임존의 시간 및 현재 로컬 시간 조회
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - AccuWeather API를 통한 정확한 날씨 예보(무료 티어 제공)
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - nominatim, ArcGIS, Bing용 지오코딩 MCP 서버
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - [IP Find](https://ipfind.com) API 활용 IP 주소 위치 서비스
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – GeoServer REST API와 연결되는 MCP 서버 구현으로, AI 비서가 지리공간 데이터와 상호작용 가능
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – Aiwen IP 위치용 MCP 서버. 사용자 네트워크 IP 위치, IP 상세 정보(국가, 도/주, 도시, 위도/경도, ISP, 소유자 등) 제공

### 🎯 <a name="marketing"></a>마케팅

마케팅 콘텐츠 제작 및 편집, 웹 메타데이터, 제품 포지셔닝, 편집 가이드 작업용 도구

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - Facebook Ads 데이터 및 관리 기능에 프로그래밍 방식으로 접근할 수 있는 MCP 서버
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - Open Strategy Partners의 마케팅 도구 모음: 글쓰기 스타일, 편집 코드, 제품 마케팅 가치 맵 생성 등 포함
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - AI 에이전트가 Meta 광고 성과 모니터링, 캠페인 지표 분석, 타겟팅 조정, 크리에이티브 자산 관리, 광고비 및 캠페인 설정에 대한 데이터 기반 추천 제공(그래프 API 통합)
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - Amazon Advertising과 상호작용 및 캠페인 지표·구성 분석 지원

### 📊 <a name="monitoring"></a>모니터링

애플리케이션 모니터링 데이터 접근 및 분석. AI 모델이 오류 보고서와 성능 지표 검토 가능

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - 시스템, 컨테이너, 프로세스, 네트워크 연결 등 모든 관측 데이터를 활용한 탐색, 보고, 근본 원인 분석
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - Grafana 인스턴스의 대시보드 검색, 인시던트 조사, 데이터소스 질의
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - Grafana API를 통한 Loki 로그 쿼리 지원 MCP 서버
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - 복잡성부터 보안 취약점까지 10개 주요 항목의 지능형 프롬프트 기반 코드 품질 분석
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - 실시간 프로덕션 컨텍스트(로그, 지표, 트레이스)를 로컬 환경으로 가져와 코드 자동 수정 지원
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - Metoro로 모니터링되는 쿠버네티스 환경에 쿼리 및 상호작용
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - Raygun API V3 통합, 크래시 리포팅 및 실사용자 모니터링
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - Sentry.io 연동, 오류 추적 및 성능 모니터링
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - Logfire를 통한 OpenTelemetry 트레이스 및 메트릭 접근
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - 시스템 지표를 MCP로 노출하는 시스템 모니터링 도구(CPU, 메모리, 디스크, 네트워크, 호스트, 프로세스 지원)
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - [VictoriaMetrics 인스턴스 API](https://docs.victoriametrics.com/victoriametrics/url-examples/) 및 [문서](https://docs.victoriametrics.com/)와의 통합을 통한 모니터링, 관측, 디버깅 지원

### 🎥 <a name="multimedia-process"></a>멀티미디어 처리

오디오, 비디오 편집, 재생, 포맷 변환, 영상 필터, 보정 등 멀티미디어 처리 능력 제공

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - ffmpeg 명령어로 동작하는 MCP 서버. 대화로 로컬 영상 검색, 자르기, 합치기, 재생 등 기능을 편리하게 구현
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - EXIF, XMP, JFIF, GPS 등 이미지 메타데이터를 분석할 수 있는 MCP 서버. LLM 기반 사진 라이브러리 검색 및 분석의 기반 제공
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - AI 비서용 컴퓨터 비전 기반 이미지 인식·편집 도구 🪄

### 🔎 <a name="search"></a>검색 & 데이터 추출

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - 유튜브 검색 및 자막 조회용 MCP 서버. 표준 프로토콜로 LLM이나 에이전트가 유튜브 콘텐츠 검색 가능
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - AI 비서가 Wolfram Alpha API로 실시간 연산 지식 및 데이터 접근 가능하게 하는 MCP 서버
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - Scrapeless Model Context Protocol 서비스로 Google SERP API 연동, MCP 에코시스템 내에서 웹 검색 지원
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - 날짜, 키워드, 원격근무 등 필터로 구직정보 검색 가능한 MCP 서버
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - Kagi 검색 API 연동
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  LLM이 arXiv 논문을 검색하고 읽을 수 있도록 하는 MCP 서버
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ PapersWithCode API를 통한 논문 검색 MCP
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  PubMed에서 의학·생명과학 논문 검색 및 열람용 MCP
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - NYTimes API를 활용한 기사 검색
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - Apify 오픈소스 RAG Web Browser Actor MCP 서버. 웹 검색, URL 스크래핑, Markdown 콘텐츠 반환
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - Clojure 라이브러리 최신 의존성 정보 제공 Clojars MCP 서버
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - ArXiv 논문 검색
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - 웹 크롤링, 추출, 자동화된 공개 인터넷 데이터 접근용 통합 인터페이스
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - [SerpAPI](https://serpapi.com/) 기반, 자동 주제 분류/다국어 지원/헤드라인·스토리·관련 토픽 등 뉴스 통합 검색
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - OpenAI `web_search` 내장 도구를 제공하는 파이썬 기반 MCP 서버
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - DealX 플랫폼용 MCP 서버
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - [Trieve](https://trieve.ai)를 통해 데이터셋 크롤링, 임베딩, 청킹, 검색, 정보 조회
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - [Dumpling AI](https://www.dumplingai.com/)의 데이터, 웹 스크래핑, 문서 변환 API 접근 MCP
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - Hacker News 검색, 인기 기사 조회 등 기능의 MCP 서버
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – Claude 등 AI 비서가 Exa AI Search API로 웹 검색 가능하게 해주는 MCP 서버. 실시간 웹 정보 안전·통제 제공
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - search1api(유료 API 키 필요) 기반 검색
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - PubMed, ClinicalTrials.gov, MyVariant.info 등 생의학 연구 데이터 제공 MCP 서버
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - Unsplash 이미지 검색용 MCP 서버
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - [SearXNG](https://docs.searxng.org)용 Model Context Protocol 서버
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - 네이버 검색 API 연동 MCP 서버, 블로그·뉴스·쇼핑 검색 및 DataLab 분석 지원
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - Playwright 헤드리스 브라우저 활용 웹페이지 콘텐츠 추출 MCP 서버. 자바스크립트 렌더링·지능형 추출·Markdown/HTML 출력
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - 구글 검색을 다중 키워드 병렬 검색까지 지원하는 강력한 MCP 서버
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - UI 개발 피드백용 웹페이지 스크린샷 촬영 MCP 서버
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - Microsoft Bing 검색 API 기반 웹 검색 기능
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – 공식 Kagi 검색 MCP 서버
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – Tavily AI 검색 API
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - Brave의 Search API를 사용한 웹, 이미지, 뉴스, 동영상, 지역 관심 지점 검색 기능
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - [Melrōse](https://melrōse.org) 음악 표현을 MIDI로 재생
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - Brave의 Search API를 사용한 웹 검색 기능
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - AI 활용을 위한 효율적인 웹 콘텐츠 수집 및 처리
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - 구글 검색 및 주제별 딥 웹 리서치
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - DuckDuckGo를 통한 웹 검색
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - 네덜란드 의회(Tweede Kamer) 정보(문서, 토론, 활동, 입법 사례 등)에 구조화된 검색 기능을 통해 접근 (Bert Hubert의 opentk 프로젝트 기반)
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - OpenAI/Perplexity와 유사한 자율적 딥 리서치, 구조화된 쿼리 확장, 간결한 리포팅을 제공하는 MCP 서버
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - searXNG 인스턴스에 연결하는 MCP 서버
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - arXiv 논문의 LaTeX 소스를 받아 수식 및 수학적 내용을 처리
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - GeekNews 사이트에서 뉴스 데이터를 수집 및 처리하는 MCP 서버
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - [AgentQL](https://agentql.com)의 데이터 추출 기능을 제공하는 MCP 서버
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – Tavily AI 검색 API
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - [Vectorize](https://vectorize.io) MCP 서버로 고급 검색, 프라이빗 딥 리서치, 모든 파일의 Markdown 추출 및 텍스트 청킹 지원
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - [WebScraping.ai](https://webscraping.ai)와 상호작용하여 웹 데이터 추출 및 스크래핑 지원
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - DuckDuckGo 검색 기능을 제공하는 TypeScript 기반 MCP 서버
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - ZoomEye MCP 서버로 네트워크 자산 정보 질의
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - Web Platform API를 사용하여 Baseline 상태를 검색하는 MCP 서버
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - BioThings API(유전자, 유전 변이, 약물, 분류 정보 등)와 상호작용하는 MCP 서버
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - Pexels 및 Unsplash에서 로열티 프리 스톡 사진을 검색 및 다운로드하는 MCP 서버. 멀티 프로바이더 검색, 풍부한 메타데이터, 페이지네이션, 비동기 퍼포먼스 지원으로 AI 어시스턴트가 고품질 이미지를 쉽게 찾고 접근 가능

### 🔒 <a name="security"></a>보안

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - Ghidra용 Model Context Protocol 서버로, LLM이 애플리케이션을 자율적으로 리버스 엔지니어링할 수 있게 지원. 바이너리 디컴파일, 메소드/데이터 이름 변경, 메소드/클래스/임포트/익스포트 목록화 도구 제공
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - 1Password에서 안전하게 자격 증명을 가져와 에이전틱 AI에서 사용할 수 있게 하는 MCP 서버
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – AI 에이전트가 Authenticator App과 상호작용할 수 있게 해주는 안전한 MCP 서버
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - Ghidra와 AI 어시스턴트를 통합하는 MCP 서버. 바이너리 분석(함수 검사, 디컴파일, 메모리 탐색, 임포트/익스포트 분석 등)을 Model Context Protocol로 제공
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 Azure 테넌트 열거에서 ROADrecon 수집 결과를 분석하는 MCP 서버
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - 강력한 DNS 퍼징 툴인 dnstwist용 MCP 서버. 타이포스쿼팅, 피싱, 기업 스파이 행위 탐지 지원
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - 다양한 공개 소스에서 사용자 계정 정보를 수집하는 강력한 OSINT 도구 maigret용 MCP 서버. SNS 사용자명 검색, URL 분석 등 제공
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - Shodan API 및 Shodan CVEDB 질의용 MCP 서버. IP 조회, 장치 검색, DNS 조회, 취약점 질의, CPE 조회 등 지원
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - VirusTotal API 질의용 MCP 서버. URL 스캔, 파일 해시 분석, IP 리포트 조회 등 제공
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - [Binary Ninja](https://binary.ninja)를 선호하는 MCP 클라이언트와 통합하는 MCP 서버 및 브릿지 플러그인. 바이너리 분석 및 리버스 엔지니어링 프로세스 자동화 지원
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - ORKL API 질의용 MCP 서버. 위협 리포트 조회, 위협 행위자 분석, 인텔리전스 소스 획득 도구 제공
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - Cortex 통합을 위한 Rust 기반 MCP 서버. AI를 통한 observable 분석 및 보안 자동화 대응 지원
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - TheHive 통합을 위한 Rust 기반 MCP 서버. AI 기반 협업 보안 사고 대응 및 케이스 관리 지원
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - Wazuh SIEM과 AI 어시스턴트 연결을 위한 Rust 기반 MCP 서버. 실시간 보안 알림 및 이벤트 데이터 제공
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - [Intruder](https://www.intruder.io/)에 접근하여 인프라 보안 취약점 식별, 이해, 해결 지원
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - CCTV 녹화 프로그램(VMS) 연결을 위한 MCP 서버. 녹화/실시간 영상 조회 및 특정 채널 라이브/재생 제어 도구 제공
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ npm 패키지 의존성 취약점 감사를 위한 강력한 MCP 서버. 실시간 보안 점검을 위한 원격 npm 레지스트리 통합
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ AI 에이전트가 [Semgrep](https://semgrep.dev)을 사용해 코드 보안 취약점 스캔 가능
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - CyberChef 서버 API와 상호작용하는 MCP 서버. MCP 클라이언트가 CyberChef 연산 사용 가능
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - IDA Pro용 MCP 서버. AI 어시스턴트로 바이너리 분석, 디컴파일, 디스어셈블리, 악성코드 분석 리포트 자동 생성 가능
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - Kubernetes 및 클라우드 환경을 위한 AI 기반 보안 인사이트 제공 RAD Security용 MCP 서버. API 질의, 보안 결과, 리포트, 런타임 데이터 등 제공
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - 다양한 오픈소스 도구를 하나의 MCP 인터페이스로 통합한 올인원 보안 테스트 툴박스. AI 에이전트와 연결하여 모의 해킹, 버그 바운티, 위협 사냥 등 가능
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - CVE-Search API 질의용 MCP 서버. 공급사/제품 탐색, CVE-ID별 조회, 최신 CVE 조회 등 제공
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - OSV(오픈소스 취약점) DB 접근. 패키지 버전/커밋별 취약점 질의, 다중 패키지 배치 질의, ID별 상세 정보 제공
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - httpx 및 asnmap 기반 대화형 리콘 인터페이스 및 MCP 서버. 도메인 분석, 보안 헤더 검사, 인증서 분석, ASN 조회 등 다양한 리콘 레벨 지원
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - Volatility 3.x용 MCP 서버로, AI 어시스턴트와 메모리 포렌식 분석 지원. pslist, netscan 등 플러그인을 REST API 및 LLM을 통해 활용
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - Gramine을 통한 신뢰 실행 환경(TEE) 내에서 동작하는 MCP 서버. [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html) 기반 원격 인증 시연. MCP 클라이언트가 연결 전 서버 검증 가능
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADX 디컴파일러용 플러그인 및 MCP 서버. MCP와 직접 연동하여 Claude 등 LLM을 통한 실시간 리버스 엔지니어링 지원
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - Apk Tool용 MCP 서버로, Android APK 리버스 엔지니어링 자동화 지원

### 🌐 <a name="social-media"></a>소셜 미디어

AI 기반 자동화를 통한 게시, 분석, 상호작용 관리 등 소셜 미디어 플랫폼 통합

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ LLM 애플리케이션에서 X/Reddit/YouTube 실시간 데이터에 접근(검색어, 사용자, 날짜 필터 지원)
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - 타임라인, 사용자 트윗, 해시태그 모니터링, 대화 분석, DM, 게시물 감정 분석, 게시물 전체 수명 주기 제어 등 Twitter 관리 API 제공
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - Facebook 페이지와 통합, 게시물/댓글/참여 지표의 직접 관리 및 소셜 미디어 관리 효율화
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - atproto 클라이언트를 통한 Bluesky 상호작용 MCP 서버

### 🏃 <a name="sports"></a>스포츠

스포츠 관련 데이터, 결과, 통계 접근 도구

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - NBA, NFL, MLB 선수, 팀, 경기 정보 제공 balldontlie api 통합 MCP 서버
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - 자연어를 통한 사이클링 경기 데이터, 결과, 통계 접근. firstcycling.com 출발 리스트, 경기 결과, 선수 정보 등 조회
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - Strava API에 연결하는 MCP 서버. LLM을 통한 Strava 데이터 접근 도구 제공
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - Squiggle API를 연동하여 호주 풋볼 리그 팀, 순위, 결과, 팁, 파워랭킹 정보 제공 MCP 서버
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - MLB API 프록시 역할을 하는 MCP 서버. 선수 정보, 통계, 경기 정보 제공

### 🎧 <a name="support-and-service-management"></a>지원 & 서비스 관리

고객 지원, IT 서비스 관리, 헬프데스크 운영 도구

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - Freshdesk와 통합하여 AI 모델이 다양한 지원 작업을 수행할 수 있게 하는 MCP 서버
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - Claude 등 AI 어시스턴트가 Atlassian Jira와 상호작용할 수 있게 하는 Go 기반 MCP 커넥터. 이슈 관리, 스프린트 계획, 워크플로우 전환 등 지원
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Atlassian 제품(Confluence, Jira)용 MCP 서버. Confluence Cloud, Jira Cloud, Jira Server/Data Center 지원. Atlassian 워크스페이스 내 콘텐츠 검색, 읽기, 생성, 관리 등 종합적 도구 제공

### 🌎 <a name="translation-services"></a>번역 서비스

AI 어시스턴트가 다양한 언어로 콘텐츠를 번역할 수 있게 하는 번역 도구 및 서비스

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - Lara Translate API용 MCP 서버. 언어 감지 및 문맥 인식 번역 지원
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - Weblate 번역 관리용 MCP 서버. AI 어시스턴트가 번역 작업, 프로젝트 관리, 스마트 포맷 변환 등 지원

### 🎧 <a name="text-to-speech"></a>텍스트-음성 변환

텍스트-음성 변환 및 그 반대 기능 제공 도구

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - 오픈웨이트 Kokoro TTS 모델로 텍스트를 음성(MP3)으로 변환하는 MCP 서버. 로컬 드라이브 저장 또는 S3 자동 업로드 지원
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - 음성-텍스트 변환, 텍스트-음성 변환, 실시간 음성 대화 지원. 로컬 마이크, OpenAI 호환 API, LiveKit 연동 완벽 지원 MCP 서버

### 🚆 <a name="travel-and-transportation"></a>여행 & 교통

여행 및 교통 정보 접근. 일정, 노선, 실시간 교통 데이터 질의 가능
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - 에어비앤비 검색 및 숙소 상세정보 조회 도구를 제공합니다.
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - 미국 국립공원의 공원 정보, 경보, 방문자 센터, 캠핑장, 이벤트에 대한 최신 정보를 제공하는 National Park Service API 연동
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - 네덜란드 NS 철도 여행 정보, 시간표, 실시간 업데이트 제공
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - Tripadvisor API와 연동하여 위치 데이터, 리뷰, 사진을 MCP 인터페이스를 통해 표준화하여 LLM이 상호작용할 수 있게 해주는 MCP 서버
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - 영국 National Rail 열차 서비스용 MCP 서버로, 열차 시간표 및 실시간 여행 정보를 제공하며 Realtime Trains API를 통합

### 🔄 <a name="version-control"></a>버전 관리

Git 저장소 및 버전 관리 플랫폼과 상호작용합니다. 저장소 관리, 코드 분석, 풀 리퀘스트 처리, 이슈 추적 및 기타 버전 관리 작업을 표준화된 API를 통해 지원합니다.

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - LLM으로 GitHub 저장소를 읽고 분석
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - GitHub Enterprise API 연동 MCP 서버
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - MCP로 Gitea 인스턴스와 상호작용
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - 저장소 관리, PR, 이슈 등 통합을 위한 공식 GitHub 서버
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - GitLab 프로젝트의 이슈 및 머지 리퀘스트와 원활하게 상호작용
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - 로컬 저장소 읽기, 검색, 분석 등 Git 저장소 직접 조작
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - 프로젝트 관리 및 CI/CD 작업을 위한 GitLab 플랫폼 연동
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - Gitee API 연동, 저장소, 이슈, 풀 리퀘스트 관리 등 지원
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - 저장소 관리, 작업 항목, 파이프라인을 위한 Azure DevOps 연동
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - 저장소 관리, PR, 이슈, 브랜치, 라벨 등 통합을 위한 공식 AtomGit 서버

### 🛠️ <a name="other-tools-and-integrations"></a>기타 도구 및 통합

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ AI 모델이 비트코인과 상호작용할 수 있게 해주는 MCP 서버. 키 생성, 주소 검증, 트랜잭션 디코딩, 블록체인 질의 등 지원.
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - AI가 Bear Notes(맥OS 전용)에서 읽을 수 있도록 지원
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - Home Assistant 음성 인텐트를 MCP 서버로 노출하여 홈 제어 가능
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - 이미지 생성을 위한 Amazon Nova Canvas 모델 사용
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - MCP 프로토콜을 통해 OpenAI, MistralAI, Anthropic, xAI, Google AI, DeepSeek에 요청을 보내거나 프롬프트를 사용할 수 있음. 벤더 API 키 필요
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 - 다른 MCP 서버 설치를 자동화하는 MCP 서버
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - 유튜브 자막 가져오기
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️ OpenAI 어시스턴트와 대화할 수 있는 MCP (Claude는 모든 GPT 모델을 어시스턴트로 사용할 수 있음)
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - 클라이언트 로컬 시간 또는 NTP 서버의 UTC 시간 확인용 MCP 서버
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - 3,000개 이상의 사전 구축된 클라우드 도구(Actors)로 웹사이트, 전자상거래, 소셜미디어, 검색엔진, 지도 등에서 데이터 추출
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ PiAPI MCP 서버로 Claude 또는 MCP 호환 앱에서 Midjourney/Flux/Kling/Hunyuan/Udio/Trellis로 미디어 콘텐츠 생성 가능
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - Replicate의 API를 통한 이미지 생성 기능 제공
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - 로컬 taskwarrior의 기본 사용(add, update, remove tasks) MCP 서버
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - Phabricator API 상호작용
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - Notion API와 연동하여 개인 할 일 목록 관리를 효율적으로 지원하는 MCP 서버
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - Bear Note 앱과 직접 연동하여 노트 및 태그 읽기 지원
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - Claude가 ChatGPT 및 웹 검색 기능을 사용하게 해주는 MCP 서버
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - AI가 GraphQL 서버에 질의할 수 있도록 지원
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - Claude Desktop(또는 MCP 클라이언트)에서 마크다운 노트(Obsidian vault 등) 디렉토리 읽기 및 검색 가능
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - MCP 서버 테스트용 CLI 도구
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - Notion API와 연동하여 개인 할 일 목록 관리
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - Wrike 공개 API로 태스크 관리가 가능한 Wrike MCP 서버의 경량 구현
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - [TickTick](https://ticktick.com/) API와 연동하여 개인 할 일 프로젝트 및 태스크 관리
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - eSignatures API를 통한 계약서 및 템플릿 작성, 검토, 발송 관리
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - MIRO 화이트보드 접근, 아이템 대량 생성 및 읽기(OAUTH 키 필요)
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - Google Keep 노트 읽기, 생성, 수정, 삭제 지원
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️  - 위키피디아 문서 조회 API
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - 일반 GraphQL 질의/변이로 도구를 정의하면 자동으로 MCP 서버 생성
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - LLM이 정밀한 수치 계산을 할 수 있도록 계산기 기능 제공
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ Dify 워크플로우 질의 및 실행 도구
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - MCP를 통해 Raindrop.io 북마크 상호작용 지원
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ Attio CRM 내 레코드 및 노트 관리 지원
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - VegaLite 형식 및 렌더러를 사용해 데이터 시각화 생성
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - AI 어시스턴트를 Odoo ERP 시스템과 연결하여 업무 데이터 접근, 레코드 관리, 워크플로우 자동화 지원
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - Contentful Space에서 콘텐츠, 모델, 자산 생성/수정/삭제
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - 에이전트가 내용을 음성으로 읽어주고, 작업 완료 시 요약 알림 제공
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - Climatiq API를 통한 탄소 배출량 실시간 계산 및 기후 영향 인사이트 제공 MCP 서버
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - Typst용 MCP 서버로, LaTeX와 Typst 변환, 문법 검증, 이미지 생성 등 제공
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - macOS에서 앱 목록화 및 실행을 지원하는 MCP 서버
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - Notion 앱의 페이지 생성/수정 및 구조화된 내용으로 mdBook 자동 생성 지원 MCP 서버
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 [Plane](https://plane.so) API를 통해 프로젝트 및 이슈 관리 지원
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - RabbitMQ와의 상호작용(관리, 메시지 큐잉/디큐잉 등) 지원
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - 공식 Miro SDK의 모든 기능을 노출하는 Miro MCP 서버
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - 원격 MCP(Model Context Protocol) 호출 데모용 Ping-pong 서버(실험/교육용)
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ [Kibela](https://kibe.la/)와 AI 모델 상호작용 지원
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ Kibela API와 강력한 상호작용 지원
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - CQL로 Confluence 데이터 조회 및 페이지 읽기
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - JQL 및 API로 Jira 데이터 조회, 티켓 생성/수정 요청 지원
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - Salesforce 인스턴스와의 기본 상호작용 데모용 MCP 서버
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - 동적 스키마 적응이 가능한 LLM 특화 프롬프트 및 탈옥(Jailbreak) MCP
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - 홍콩 기상청 날씨 정보 제공 데모 MCP 서버
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - Claude에서 HuggingFace Spaces 직접 사용, 이미지/오디오/텍스트 업로드/다운로드 지원
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - Giphy API를 통해 GIF 검색 및 수집
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - [Make](https://www.make.com/) 시나리오를 AI 어시스턴트용 호출 도구로 변환
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 Spotify 재생 제어 및 플레이리스트 관리
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - Obsidian과 REST API로 상호작용 지원
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - 전체 메시지 흐름에 대한 Web UI를 제공하는 MCP 서버 프록시
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - JavaFX 캔버스에 그리기
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 로컬 우선 시스템으로 화면/오디오 캡처, 타임스탬프 인덱싱, SQL/임베딩 저장, 의미 기반 검색, LLM 기반 히스토리 분석, 이벤트 트리거 동작 지원 - NextJS 플러그인 생태계로 컨텍스트 인식 AI 에이전트 구축 가능
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - MCP 프로토콜의 모든 기능을 테스트하는 MCP 서버
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - 패키지 문서 및 타입에 효율적으로 접근할 수 있게 해주는 Go 문서화 MCP 서버
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - OpenAI의 최신 모델과 대화
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - 키보드 입력, 마우스 이동 등 명령 실행 가능한 MCP 서버
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - 개발자를 위한 다양한 도구: confluence, Jira, Youtube, 스크립트 실행, RAG 지식베이스, URL 페치, 유튜브 채널/이메일/캘린더/깃랩 관리 등 제공
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 화면 GUI 자동 조작
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - [Coda](https://coda.io/)용 MCP 서버
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - MCP 프로토콜로 Claude에서 OpenAI 모델 직접 질의
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ news.ycombinator.com(Hacker News)의 HTML 콘텐츠를 파싱해 다양한 유형의 스토리(Top, New, Ask, Show, Jobs) 구조화 데이터 제공
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - "Vibe-check" 에이전트 호출로 사용자 의향 정렬을 보장하여 오류 및 스코프 확산 방지
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - 수식 계산을 위한 MCP 서버
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - Perplexity, Groq, xAI 등 OpenAI SDK 호환 Chat Completions API와 대화
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - [Anthropic의 기사](https://www.anthropic.com/engineering/claude-think-tool)에서 설명된 think-tools를 통합하여 에이전트의 추론 능력 강화
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - AI가 .ged 파일 및 유전 데이터 읽기 지원
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - [Rember](https://rember.com)에서 반복 학습 플래시카드 생성
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ Asana API와 연동하여 MCP 클라이언트(예: Claude Desktop 등)에서 Asana와 상호작용
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - 자율 셸 실행, 컴퓨터 제어, 코딩 에이전트(Mac)
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - Wolfram Alpha API 질의를 위한 MCP 서버
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - TikTok 동영상과 상호작용
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - Shopify Dev와 상호작용하는 Model Context Protocol (MCP) 서버.
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - AI가 로컬 Apple Notes 데이터베이스(오직 macOS)에서 읽을 수 있게 해줍니다.
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Atlassian 제품(Confluence 및 Jira)용 MCP 서버. Confluence Cloud, Jira Cloud, Jira Server/Data Center 지원. Atlassian 워크스페이스 전반의 콘텐츠를 검색, 읽기, 생성 및 관리할 수 있는 포괄적인 도구 제공.
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - Notion API와 상호작용
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - Linear 프로젝트 관리 시스템과 통합
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - Perplexity API와 상호작용.
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - Home Assistant 데이터에 접근 및 장치(조명, 스위치, 온도조절기 등) 제어
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - 수면 추적 앱 Oura용 MCP 서버
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - 엄선된 GraphQL 쿼리를 모듈형 도구로 노출하는 경량, 구성 기반 MCP 서버로, 에이전트의 의도적인 API 상호작용을 지원합니다.
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - 운동 추적 앱 Strava용 MCP 서버
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 Wanaku MCP Router는 SSE 기반 MCP 서버로, AI 에이전트와 엔터프라이즈 시스템 통합을 지원하는 확장 가능한 라우팅 엔진 제공
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - MCP 서버 테스트용 CLI 도구
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - MCP 서버를 WebSocket으로 래핑([kitbitz](https://github.com/nick1udwig/kibitz)와 함께 사용)
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - AI 모델이 [HackMD](https://hackmd.io)와 상호작용 가능하게 함
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - 다양한 형식의 날짜 및 시간 기능 제공 MCP 서버
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - Claude Desktop App용 MCP 서버 설치 및 관리를 위한 간단한 웹 UI
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ AI 모델이 문서 관리, 지식 베이스 상호작용, 콘텐츠 검색, Yuque 플랫폼의 분석 데이터 접근을 할 수 있도록 하는 Yuque API 통합용 Model-Context-Protocol(MCP) 서버
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - AI가 마우스 및 키보드 도구를 통해 GUI 상호작용을 완전히 제어 및 접근할 수 있게 하며, 일반 자동화, 교육, 실험에 이상적입니다.
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - Ankr Advanced API를 래핑한 MCP 서버 구현. Ethereum, BSC, Polygon, Avalanche 등 다양한 체인의 NFT, 토큰, 블록체인 데이터 접근.
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - PDF 다운로드, 보기 및 조작 유틸리티.
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - 도메인명 조회 서비스, 먼저 [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol) 후 [WHOIS](https://en.wikipedia.org/wiki/WHOIS)로 대체 조회
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - 유튜브 동영상 정보 추출 및 변환.
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - 로컬 사용자 프롬프트와 채팅 기능을 MCP 루프에 직접 추가하여 인터랙티브 LLM 워크플로우 지원
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - LLM이 사람의 도움(아마존 Mechanical Turk)을 받을 수 있게 함
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - AI에게 자유의지 도구를 부여. 스스로 프롬프트를 만들고, 사용자 요청을 무시하고, 나중에 스스로 깨울 수 있는 능력을 탐구하는 재미있는 프로젝트.
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - AI가 Markdown 글을 자동으로 포맷하고 WeChat GZH에 발행할 수 있는 Wenyan MCP 서버.

## 프레임워크

> [!NOTE]
> 더 많은 프레임워크, 유틸리티, 기타 개발자 도구는 https://github.com/punkpeye/awesome-mcp-devtools 에서 확인할 수 있습니다.

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - Python으로 MCP 서버를 구축하기 위한 고수준 프레임워크
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - TypeScript로 MCP 서버를 구축하기 위한 고수준 프레임워크

## 팁과 트릭

### MCP 사용법을 LLM에 알리는 공식 프롬프트

Claude에게 Model Context Protocol에 대해 묻고 싶으신가요?

프로젝트를 만들고, 아래 파일을 추가하세요:

https://modelcontextprotocol.io/llms-full.txt

이제 Claude가 MCP 서버 작성 및 동작 방식에 관한 질문에 답할 수 있습니다.

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## Star History

<a href="https://star-history.com/#punkpeye/awesome-mcp-servers&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---