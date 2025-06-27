<p align="right">
   <strong>English</strong> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.cn.md">中文</a> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### 하나의 빠르고 친근한 API로 250개 이상의 LLM을 라우팅하세요

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Portkey AI Gateway Demo showing LLM routing capabilities" style="margin-left:-35px">

[문서](https://portkey.wiki/gh-1) | [엔터프라이즈](https://portkey.wiki/gh-2) | [호스팅 게이트웨이](https://portkey.wiki/gh-3) | [변경 로그](https://portkey.wiki/gh-4) | [API 참조](https://portkey.wiki/gh-5)


[![라이선스](https://img.shields.io/github/license/Ileriayo/markdown-badges)](https://raw.githubusercontent.com/Portkey-AI/gateway/main/LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm 버전](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

[**AI Gateway**](https://portkey.wiki/gh-10)는 1600개 이상의 언어, 비전, 오디오, 이미지 모델에 대해 빠르고 신뢰할 수 있으며 안전하게 라우팅하도록 설계되었습니다. 경량이며 오픈소스, 엔터프라이즈 수준의 솔루션으로, 2분 이내에 어떤 언어 모델과도 통합할 수 있습니다.

- [x] **눈부시게 빠름** (<1ms 지연)과 작은 용량(122kb)
- [x] **검증된 안정성**, 매일 100억 토큰 이상 처리
- [x] **엔터프라이즈 준비 완료**, 보안 강화, 대규모 확장, 맞춤형 배포 지원

<br>

#### AI Gateway로 무엇을 할 수 있나요?
- 2분 만에 어떤 LLM과도 통합 – [빠른 시작](#quickstart-2-mins)
- **[자동 재시도](https://portkey.wiki/gh-11)** 및 **[폴백](https://portkey.wiki/gh-12)** 기능으로 다운타임 방지
- **[로드 밸런싱](https://portkey.wiki/gh-13)** 및 **[조건부 라우팅](https://portkey.wiki/gh-14)** 으로 AI 앱 확장
- **[가드레일](https://portkey.wiki/gh-15)** 로 AI 배포 보호
- **[멀티모달 기능](https://portkey.wiki/gh-16)** 으로 텍스트를 넘어 확장
- **[에이전틱 워크플로우](https://portkey.wiki/gh-17)** 통합도 지원

<br><br>

> [!TIP]
> 이 저장소에 Star를 누르면 더 많은 개발자가 AI Gateway를 발견할 수 있습니다 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## 빠른 시작 (2분)

### 1. AI Gateway 설치

```bash
# 게이트웨이를 로컬에서 실행 (Node.js와 npm 필요)
npx @portkey-ai/gateway
```
> 게이트웨이는 `http://localhost:8787/v1`에서 실행 중입니다.
> 
> 게이트웨이 콘솔은 `http://localhost:8787/public/`에서 실행 중입니다.

<sup>
배포 가이드:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (권장)</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md"> 기타...</a>

</sup>

### 2. 첫 번째 요청 보내기

<!-- <details open>
<summary>Python Example</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# OpenAI 호환 클라이언트
client = Portkey(
    provider="openai", # 또는 'anthropic', 'bedrock', 'groq' 등
    Authorization="sk-***" # 프로바이더 API 키
)

# AI Gateway를 통해 요청 보내기
client.chat.completions.create(
    messages=[{"role": "user", "content": "What's the weather like?"}],
    model="gpt-4o-mini"
)
```



<sup>지원 라이브러리:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [더보기..](https://portkey.wiki/gh-26)
</sup>

Gateway Console(`http://localhost:8787/public/`)에서 모든 로컬 로그를 한 곳에서 확인할 수 있습니다.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. 라우팅 & 가드레일
LLM 게이트웨이의 `Configs`를 이용해 라우팅 규칙 생성, 신뢰성 추가, 가드레일 설정이 가능합니다.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# 클라이언트에 config 적용
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Reply randomly with Apple or Bat"}]
)

# 이 설정은 "Apple"이 포함된 모든 응답을 거부하므로 항상 "Bat"으로 응답합니다. retry 설정은 5회까지 재시도합니다.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Request flow through Portkey's AI gateway with retries and guardrails" alt="Request flow through Portkey's AI gateway with retries and guardrails"/>
</div>

AI 게이트웨이의 config로 더 많은 작업을 할 수 있습니다. [예시 바로가기  →](https://portkey.wiki/gh-27)

<br/>

### 엔터프라이즈 버전 (프라이빗 배포)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

LLM Gateway의 [엔터프라이즈 버전](https://portkey.wiki/gh-86)은 **조직 관리**, **거버넌스**, **보안** 및 [기타 고급 기능](https://portkey.wiki/gh-87)을 기본 제공합니다. [기능 비교 보기 →](https://portkey.wiki/gh-32)

지원 플랫폼의 엔터프라이즈 배포 아키텍처는 여기에서 확인할 수 있습니다 - [**엔터프라이즈 프라이빗 클라우드 배포**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="엔터프라이즈 AI 게이트웨이 데모 예약" /></a><br/>


<br>

<hr>

### AI Engineering Hours

매주 금요일(오전 8시 PT)에 커뮤니티 콜에 참여하여 AI Gateway 구현을 시작하세요! [매주 금요일 진행](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

회의록은 [여기에서 확인](https://portkey.wiki/gh-36)할 수 있습니다.


<hr>

### LLMs in Prod'25

2조 개 이상의 토큰, 90개 이상의 리전, 650개 이상의 팀에 대한 분석 인사이트. 이 리포트에서 기대할 수 있는 내용:
- AI 도입 및 LLM 프로바이더 성장 트렌드
- 속도, 비용, 신뢰성 최적화 벤치마크
- 프로덕션급 AI 시스템 확장 전략

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**리포트 다운로드**</a>
<hr>


## 주요 기능
### 신뢰성 높은 라우팅
- <a href="https://portkey.wiki/gh-37">**폴백(Fallbacks)**</a>: LLM 게이트웨이를 사용하여 요청 실패 시 다른 공급자나 모델로 폴백할 수 있습니다. 폴백을 트리거할 오류를 지정할 수 있으며, 애플리케이션의 신뢰성을 높여줍니다.
- <a href="https://portkey.wiki/gh-38">**자동 재시도(Automatic Retries)**</a>: 실패한 요청을 최대 5회까지 자동으로 재시도합니다. 지수 백오프 전략을 적용하여 네트워크 과부하를 방지합니다.
- <a href="https://portkey.wiki/gh-39">**로드 밸런싱(Load Balancing)**</a>: 여러 API 키나 AI 공급자에 LLM 요청을 가중치 기반으로 분산시켜 고가용성과 최적의 성능을 보장합니다.
- <a href="https://portkey.wiki/gh-40">**요청 타임아웃(Request Timeouts)**</a>: 세분화된 요청 타임아웃을 설정하여, 지정된 시간을 초과하는 요청을 자동으로 종료함으로써 LLM 및 지연 문제를 관리합니다.
- <a href="https://portkey.wiki/gh-41">**멀티모달 LLM 게이트웨이(Multi-modal LLM Gateway)**</a>: 친숙한 OpenAI 시그니처를 사용하여, 여러 공급자의 비전, 오디오(텍스트-음성 & 음성-텍스트), 이미지 생성 모델을 호출할 수 있습니다.
- <a href="https://portkey.wiki/gh-42">**실시간 API(Realtime APIs)**</a>: 통합 웹소켓 서버를 통해 OpenAI가 제공하는 실시간 API를 호출할 수 있습니다.

### 보안 & 정확성
- <a href="https://portkey.wiki/gh-88">**가드레일(Guardrails)**</a>: LLM 입력 및 출력을 지정한 검증 절차에 따라 검증할 수 있습니다. 40개 이상의 사전 구축된 가드레일 중 선택하여 보안 및 정확성 표준을 준수할 수 있습니다. <a href="https://portkey.wiki/gh-43">직접 가드레일을 제공</a>하거나, <a href="https://portkey.wiki/gh-44">여러 파트너사</a>의 서비스를 선택할 수 있습니다.
- [**보안 키 관리(Secure Key Management)**](https://portkey.wiki/gh-45): 직접 키를 사용하거나, 가상 키를 즉시 생성할 수 있습니다.
- [**역할 기반 접근 제어(Role-based access control)**](https://portkey.wiki/gh-46): 사용자, 워크스페이스, API 키에 대한 세분화된 접근 제어가 가능합니다.
- <a href="https://portkey.wiki/gh-47">**컴플라이언스 & 데이터 프라이버시(Compliance & Data Privacy)**</a>: AI 게이트웨이는 SOC2, HIPAA, GDPR, CCPA를 준수합니다.

### 비용 관리
- [**스마트 캐싱(Smart caching)**](https://portkey.wiki/gh-48): LLM 응답을 캐싱하여 비용을 절감하고 지연 시간을 개선합니다. 단순 및 시맨틱* 캐싱을 지원합니다.
- [**사용량 분석(Usage analytics)**](https://portkey.wiki/gh-49): 요청량, 지연 시간, 비용, 오류율 등 AI 및 LLM 사용량을 모니터링하고 분석할 수 있습니다.
- [**공급자 최적화(Provider optimization)*](https://portkey.wiki/gh-89): 사용 패턴과 가격 모델에 따라 가장 비용 효율적인 공급자로 자동 전환합니다.

### 협업 & 워크플로우
- <a href="https://portkey.ai/docs/integrations/agents">**에이전트 지원(Agents Support)**</a>: 인기 있는 에이전트 프레임워크와 매끄럽게 통합하여 복잡한 AI 애플리케이션을 구축할 수 있습니다. 게이트웨이는 [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55), 심지어 [커스텀 에이전트](https://portkey.wiki/gh-56)까지 지원합니다.
- [**프롬프트 템플릿 관리(Prompt Template Management)*](https://portkey.wiki/gh-57): 범용 프롬프트 플레이그라운드를 통해 프롬프트 템플릿을 공동으로 생성, 관리, 버전 관리할 수 있습니다.
<br/><br/>

<sup>
*&nbsp;호스팅 및 엔터프라이즈 버전에서 제공
</sup>

<br>

## 쿡북(Cookbooks)

### ☄️ 인기
- [Nvidia NIM](/cookbook/providers/nvidia.ipynb) 모델을 AI Gateway에서 사용하기
- Portkey로 [CrewAI Agents](/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) 모니터링하기!
- AI Gateway로 [상위 10개 LMSYS 모델 비교](/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb)

### 🚨 최신
* [Nemotron을 활용한 합성 데이터셋 생성](/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [Vercel의 AI SDK와 LLM Gateway 연동하기](/cookbook/integrations/vercel-ai.md)
* [Portkey의 LLM Gateway로 Llama Agents 모니터링](/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[모든 쿡북 보기 →](https://portkey.wiki/gh-58)
<br/><br/>

## 지원되는 공급자

[45개 이상의 공급자](https://portkey.wiki/gh-59) 및 [8개 이상의 에이전트 프레임워크](https://portkey.wiki/gh-90)와의 Gateway 통합을 확인하세요.

|                                                                                                                            | 공급자(Provider)                                                                              | 지원(Support) | 스트림(Stream) |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | ------------- | -------------- |
| <img src="docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                           | ✅       | ✅      |
| <img src="docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅       | ✅      |
| <img src="docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅       | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅       | ✅      |
| <img src="docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅       | ✅      |
| <img src="docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅       | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅       | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅       | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅       | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅       | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅       | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅       | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅       | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅       | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅       | ✅      | `/chat/completions`, `/completions` |


> [200개 이상의 지원 모델 전체 목록 보기](https://portkey.wiki/gh-74)
<br>

<br>

## 에이전트(Agents)
Gateway는 인기 있는 에이전트 프레임워크와 매끄럽게 통합됩니다. [문서 보기](https://portkey.wiki/gh-75).


| 프레임워크(Framework) | 200+ LLM 호출 | 고급 라우팅 | 캐싱 | 로깅 & 추적* | 가시성* | 프롬프트 관리* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [커스텀 에이전트 구축](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

* [호스팅 앱](https://portkey.wiki/gh-76)에서 제공됩니다. 자세한 문서는 [여기](https://portkey.wiki/gh-100)에서 확인하세요.


## Gateway 엔터프라이즈 버전
AI 앱을 <ins>더 신뢰성 있게</ins> , <ins>미래 호환 가능하게</ins> 만들고, 완벽한 <ins>데이터 보안</ins>과 <ins>프라이버시</ins>를 보장하세요.

✅&nbsp; 보안 키 관리 - 역할 기반 접근 제어 및 추적 <br>
✅&nbsp; 단순 및 시맨틱 캐싱 - 반복 쿼리를 더 빠르게 제공하고 비용 절감 <br>
✅&nbsp; 접근 제어 및 인바운드 규칙 - 접속 가능한 IP 및 지역 제어 <br>
✅&nbsp; PII 마스킹 - 요청 내 민감 정보 자동 제거로 우발적 노출 방지 <br>
✅&nbsp; SOC2, ISO, HIPAA, GDPR 컴플라이언스 - 최고 수준의 보안 관행 <br>
✅&nbsp; 전문가 지원 - 기능 우선 순위 지정 포함 <br>

[엔터프라이즈 배포 상담 예약](https://portkey.sh/demo-13)

<br>


## 기여하기(Contributing)

가장 쉬운 기여 방법은 `good first issue` 태그가 달린 이슈를 선택하는 것입니다 💪. 기여 가이드라인은 [여기](/.github/CONTRIBUTING.md)에서 확인하세요.

버그 신고? [여기서 제출](https://portkey.wiki/gh-78) | 기능 요청? [여기서 제출](https://portkey.wiki/gh-78)


### 커뮤니티와 함께 시작하기
매주 금요일(PT 8시)에 열리는 AI Engineering Hours에 참여하세요:
- 다른 기여자 및 커뮤니티 멤버와 네트워킹
- Gateway 고급 기능 및 구현 패턴 학습
- 경험 공유 및 도움 받기
- 최신 개발 우선순위 확인

[다음 세션 참여 →](https://portkey.wiki/gh-101) | [회의 노트](https://portkey.wiki/gh-102)

<br>

## 커뮤니티

전 세계의 성장하는 커뮤니티와 함께 AI 관련 도움, 아이디어, 토론에 참여하세요.

- 공식 [블로그](https://portkey.wiki/gh-78) 보기
- [Discord](https://portkey.wiki/community)에서 대화하기
- [Twitter](https://portkey.wiki/gh-79) 팔로우하기
- [LinkedIn](https://portkey.wiki/gh-80)에서 연결하기
- [일본어 문서](./.github/README.jp.md) 읽기
- [YouTube](https://portkey.wiki/gh-103) 방문하기
- [개발자 커뮤니티](https://portkey.wiki/gh-82) 참여하기
<!-- - [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey)에서 #portkey 태그로 질문하기 -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---