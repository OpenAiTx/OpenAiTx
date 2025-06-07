<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  AI 게이트웨이
</h1>
<h4 align="center"> AI 네이티브 API 게이트웨이 </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**공식 사이트**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCP 서버 빠른 시작**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm 플러그인 허브**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Higress란 무엇인가요?

Higress는 Istio와 Envoy를 기반으로 한 클라우드 네이티브 API 게이트웨이로, Go/Rust/JS로 작성된 Wasm 플러그인으로 확장할 수 있습니다. 수십 개의 즉시 사용 가능한 범용 플러그인과 바로 사용할 수 있는 콘솔을 제공합니다([데모 보기](http://demo.higress.io/)).

### 주요 사용 사례

Higress의 AI 게이트웨이 기능은 국내외 [주요 모델 제공자](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider)를 모두 지원합니다. 또한 플러그인 메커니즘을 통해 MCP(Model Context Protocol) 서버를 호스팅할 수 있어, AI 에이전트가 다양한 도구와 서비스를 손쉽게 호출할 수 있습니다. [openapi-to-mcp 도구](https://github.com/higress-group/openapi-to-mcpserver)를 사용하면 OpenAPI 스펙을 원격 MCP 서버로 빠르게 변환하여 호스팅할 수 있습니다. Higress는 LLM API와 MCP API 모두를 통합 관리합니다.

**🌟 [https://mcp.higress.ai/](https://mcp.higress.ai/)에서 지금 바로 체험해보세요!** Higress가 호스팅하는 원격 MCP 서버를 직접 경험할 수 있습니다:

![Higress MCP Server Platform](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### 엔터프라이즈 적용

Higress는 Alibaba 내부에서 Tengine 리로드로 인한 장기 연결 서비스 영향 문제와 gRPC/Dubbo에 대한 부하 분산 기능 부족을 해결하기 위해 태어났습니다. Alibaba Cloud 내에서 Higress의 AI 게이트웨이 기능은 Tongyi Bailian 모델 스튜디오, 머신러닝 PAI 플랫폼 등 핵심 AI 애플리케이션을 지원합니다. Alibaba Cloud는 Higress를 기반으로 클라우드 네이티브 API 게이트웨이 제품을 구축하여 수많은 엔터프라이즈 고객에게 99.99% 게이트웨이 고가용성 보장 서비스를 제공합니다.

## 목차

- [**빠른 시작**](#빠른-시작)
- [**주요 기능**](#주요-기능)
- [**사용 사례**](#사용-사례)
- [**핵심 장점**](#핵심-장점)
- [**커뮤니티**](#커뮤니티)

## 빠른 시작

Higress는 Docker만으로 바로 실행할 수 있어, 개인 개발자가 학습 목적으로 로컬에서 손쉽게 구축하거나 간단한 사이트를 만들기에 매우 편리합니다:

```bash
# 작업 디렉토리 생성
mkdir higress; cd higress
# higress 실행, 설정 파일은 작업 디렉토리에 기록됨
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

포트 설명:

- 8001 포트: Higress UI 콘솔 진입
- 8080 포트: 게이트웨이 HTTP 프로토콜 진입
- 8443 포트: 게이트웨이 HTTPS 프로토콜 진입

> 모든 Higress Docker 이미지는 Higress 자체 이미지 저장소를 사용하여 Docker Hub의 속도 제한 영향을 받지 않습니다.
> 또한, 이미지의 제출과 업데이트는 보안 스캐닝 메커니즘(Alibaba Cloud ACR 제공)으로 보호되어 운영 환경에서 매우 안전하게 사용할 수 있습니다.
> 
> `higress-registry.cn-hangzhou.cr.aliyuncs.com`에서 이미지를 가져올 때 타임아웃이 발생하면, 다음과 같은 Docker 레지스트리 미러 소스를 사용해보세요:
> 
> **동남아시아**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

K8s 환경에서의 Helm 배포 등 기타 설치 방법은 공식 [빠른 시작 문서](https://higress.io/en-us/docs/user/quickstart)를 참고하세요.

## 사용 사례

- **MCP 서버 호스팅**:

  Higress는 플러그인 메커니즘을 통해 MCP 서버를 호스팅하여 AI 에이전트가 다양한 도구 및 서비스를 손쉽게 호출할 수 있게 합니다. [openapi-to-mcp 도구](https://github.com/higress-group/openapi-to-mcpserver)를 사용하면 OpenAPI 스펙을 원격 MCP 서버로 빠르게 변환할 수 있습니다.

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Higress로 MCP 서버를 호스팅할 때의 주요 이점:
  - 통합된 인증 및 인가 메커니즘
  - 남용 방지를 위한 세분화된 속도 제한
  - 모든 도구 호출에 대한 종합 감사 로그
  - 성능 모니터링을 위한 풍부한 가시성
  - Higress 플러그인 메커니즘을 통한 간편한 배포
  - 무중단, 연결 끊김 없는 동적 업데이트

     [자세히 알아보기...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **AI 게이트웨이**:

  Higress는 모든 LLM 모델 제공자와 통합 프로토콜로 연결되며, AI 가시성, 다중 모델 부하 분산, 토큰 속도 제한, 캐싱 기능을 제공합니다:

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetes ingress 컨트롤러**:

  Higress는 기능이 풍부한 ingress 컨트롤러로 동작할 수 있으며, K8s nginx ingress 컨트롤러의 많은 annotation과 호환됩니다.
  
  [Gateway API](https://gateway-api.sigs.k8s.io/) 지원도 곧 제공 예정이며, Ingress API에서 Gateway API로의 원활한 마이그레이션을 지원할 예정입니다.
  
- **마이크로서비스 게이트웨이**:

  Higress는 마이크로서비스 게이트웨이로 동작할 수 있으며, Nacos, ZooKeeper, Consul, Eureka 등 다양한 서비스 레지스트리에서 마이크로서비스를 탐색할 수 있습니다.
  
  [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) 등 다양한 마이크로서비스 기술 스택과 깊이 통합되어 있습니다.
  
- **보안 게이트웨이**:

  Higress는 WAF 및 다양한 인증 전략(key-auth, hmac-auth, jwt-auth, basic-auth, oidc 등)을 지원하는 보안 게이트웨이로 사용할 수 있습니다.

## 핵심 장점

- **프로덕션급 안정성**

  Alibaba 내부 제품으로 2년 이상의 프로덕션 검증을 거쳤으며, 초당 수십만 건 대규모 트래픽 시나리오를 지원합니다.

  Nginx 리로드로 인한 트래픽 지터 현상을 완전히 제거하였으며, 설정 변경 시 수 밀리초 내에 즉시 적용되고, 비즈니스에 투명하게 처리됩니다. 특히 AI 등 장기 연결 시나리오에 매우 적합합니다.

- **스트리밍 처리**

  요청/응답 본문의 완전한 스트리밍 처리를 진정으로 지원하며, Wasm 플러그인을 통해 SSE(Server-Sent Events)와 같은 스트리밍 프로토콜 처리를 손쉽게 커스터마이즈할 수 있습니다.

  AI 등 대역폭이 큰 시나리오에서 메모리 사용량을 크게 줄일 수 있습니다.
    
- **손쉬운 확장성**
  
  AI, 트래픽 관리, 보안 보호 등 다양한 공통 기능을 포괄하는 공식 플러그인 라이브러리를 제공하여, 90% 이상의 비즈니스 시나리오 요구사항을 충족합니다.

  Wasm 플러그인 확장에 중점을 두어, 샌드박스 격리를 통한 메모리 안전성 확보, 다중 프로그래밍 언어 지원, 플러그인 버전의 독립적 업그레이드, 게이트웨이 로직의 무손실 핫 업데이트를 실현합니다.

- **보안성과 사용 편의성**
  
  Ingress API 및 Gateway API 표준 기반, 즉시 사용 가능한 UI 콘솔, WAF 보호 플러그인, IP/Cookie CC 보호 플러그인을 기본 제공하여 바로 사용할 수 있습니다.

  Let's Encrypt 연동을 통한 무료 인증서 자동 발급 및 갱신 지원, K8s 외부에서도 배포 가능하며, Docker 한 줄 명령으로 구동이 가능해 개인 개발자도 쉽게 사용할 수 있습니다.

## 커뮤니티

Discord 커뮤니티에 참여하세요! Higress 개발자 및 열정적인 사용자들과 소통할 수 있습니다.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### 감사의 말씀

Higress는 커뮤니티의 오픈소스 프로젝트들의 소중한 노력 없이는 탄생할 수 없었습니다. Envoy와 Istio에 특별한 감사를 전합니다.

### 관련 저장소

- Higress Console: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### 기여자

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### Star 히스토리

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ 맨 위로 이동 ↑
    </a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---