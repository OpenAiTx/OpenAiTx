![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Dify 워크플로우 파일 업로드 소개: Google NotebookLM 팟캐스트 재현하기</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify 클라우드</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">셀프 호스팅</a> ·
  <a href="https://docs.dify.ai">문서</a> ·
  <a href="https://dify.ai/pricing">Dify 에디션 개요</a>
</p>

<p align="center">
    <a href="https://dify.ai" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/Product-F04438"></a>
    <a href="https://dify.ai/pricing" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/free-pricing?logo=free&color=%20%23155EEF&label=pricing&labelColor=%20%23528bff"></a>
    <a href="https://discord.gg/FngNHpbcY7" target="_blank">
        <img src="https://img.shields.io/discord/1082486657678311454?logo=discord&labelColor=%20%235462eb&logoColor=%20%23f5f5f5&color=%20%235462eb"
            alt="chat on Discord"></a>
    <a href="https://reddit.com/r/difyai" target="_blank">  
        <img src="https://img.shields.io/reddit/subreddit-subscribers/difyai?style=plastic&logo=reddit&label=r%2Fdifyai&labelColor=white"
            alt="join Reddit"></a>
    <a href="https://twitter.com/intent/follow?screen_name=dify_ai" target="_blank">
        <img src="https://img.shields.io/twitter/follow/dify_ai?logo=X&color=%20%23f5f5f5"
            alt="follow on X(Twitter)"></a>
    <a href="https://www.linkedin.com/company/langgenius/" target="_blank">
        <img src="https://custom-icon-badges.demolab.com/badge/LinkedIn-0A66C2?logo=linkedin-white&logoColor=fff"
            alt="follow on LinkedIn"></a>
    <a href="https://hub.docker.com/u/langgenius" target="_blank">
        <img alt="Docker Pulls" src="https://img.shields.io/docker/pulls/langgenius/dify-web?labelColor=%20%23FDB062&color=%20%23f79009"></a>
    <a href="https://github.com/langgenius/dify/graphs/commit-activity" target="_blank">
        <img alt="Commits last month" src="https://img.shields.io/github/commit-activity/m/langgenius/dify?labelColor=%20%2332b583&color=%20%2312b76a"></a>
    <a href="https://github.com/langgenius/dify/" target="_blank">
        <img alt="Issues closed" src="https://img.shields.io/github/issues-search?query=repo%3Alanggenius%2Fdify%20is%3Aclosed&label=issues%20closed&labelColor=%20%237d89b0&color=%20%235d6b98"></a>
    <a href="https://github.com/langgenius/dify/discussions/" target="_blank">
        <img alt="Discussion posts" src="https://img.shields.io/github/discussions/langgenius/dify?labelColor=%20%239b8afb&color=%20%237a5af8"></a>
</p>

<p align="center">
  <a href="./README.md"><img alt="README in English" src="https://img.shields.io/badge/English-d9d9d9"></a>
  <a href="./README_TW.md"><img alt="繁體中文文件" src="https://img.shields.io/badge/繁體中文-d9d9d9"></a>
  <a href="./README_CN.md"><img alt="简体中文版自述文件" src="https://img.shields.io/badge/简体中文-d9d9d9"></a>
  <a href="./README_JA.md"><img alt="日本語のREADME" src="https://img.shields.io/badge/日本語-d9d9d9"></a>
  <a href="./README_ES.md"><img alt="README en Español" src="https://img.shields.io/badge/Español-d9d9d9"></a>
  <a href="./README_FR.md"><img alt="README en Français" src="https://img.shields.io/badge/Français-d9d9d9"></a>
  <a href="./README_KL.md"><img alt="README tlhIngan Hol" src="https://img.shields.io/badge/Klingon-d9d9d9"></a>
  <a href="./README_KR.md"><img alt="README in Korean" src="https://img.shields.io/badge/한국어-d9d9d9"></a>
  <a href="./README_AR.md"><img alt="README بالعربية" src="https://img.shields.io/badge/العربية-d9d9d9"></a>
  <a href="./README_TR.md"><img alt="Türkçe README" src="https://img.shields.io/badge/Türkçe-d9d9d9"></a>
  <a href="./README_VI.md"><img alt="README Tiếng Việt" src="https://img.shields.io/badge/Ti%E1%BA%BFng%20Vi%E1%BB%87t-d9d9d9"></a>
  <a href="./README_DE.md"><img alt="README in Deutsch" src="https://img.shields.io/badge/German-d9d9d9"></a>
  <a href="./README_BN.md"><img alt="README in বাংলা" src="https://img.shields.io/badge/বাংলা-d9d9d9"></a>
</p>

Dify는 오픈소스 LLM 앱 개발 플랫폼입니다. 직관적인 인터페이스로 에이전틱 AI 워크플로우, RAG 파이프라인, 에이전트 기능, 모델 관리, 가시성(Observability) 등 다양한 기능을 결합하여, 프로토타입에서 프로덕션까지 빠르게 이동할 수 있습니다.

## 빠른 시작

> Dify를 설치하기 전에, 아래 최소 시스템 요구사항을 충족하는지 확인하세요:
>
> - CPU >= 2 Core
> - RAM >= 4 GiB

</br>

Dify 서버를 시작하는 가장 쉬운 방법은 [docker compose](docker/docker-compose.yaml)를 사용하는 것입니다. 아래 명령어로 Dify를 실행하기 전에 [Docker](https://docs.docker.com/get-docker/) 및 [Docker Compose](https://docs.docker.com/compose/install/)가 설치되어 있는지 확인하세요:

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

실행 후, 브라우저에서 [http://localhost/install](http://localhost/install)로 접속하여 Dify 대시보드에 접근하고 초기화 과정을 시작할 수 있습니다.

#### 도움말

Dify 설정 중 문제가 발생하면 [FAQ](https://docs.dify.ai/getting-started/install-self-hosted/faqs)를 참고하세요. 여전히 문제가 있다면 [커뮤니티 및 저희에게](#community--contact) 문의해 주세요.

> Dify에 기여하거나 추가 개발을 원하신다면, [소스코드에서 배포하는 가이드](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code)를 참고하세요.

## 주요 기능

**1. 워크플로우(Workflow)**:  
시각적 캔버스에서 강력한 AI 워크플로우를 구축·테스트하며, 아래 모든 기능을 포함해 다양한 기능을 활용할 수 있습니다.

**2. 다양한 모델 지원**:  
수십 개 추론 제공업체 및 셀프 호스팅 솔루션의 수백 개 독점/오픈소스 LLM과 원활하게 통합됩니다. GPT, Mistral, Llama3 및 OpenAI API 호환 모델 등 다양한 모델을 지원합니다. 지원 모델 제공업체 전체 목록은 [여기](https://docs.dify.ai/getting-started/readme/model-providers)를 참고하세요.

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. 프롬프트 IDE**:  
프롬프트를 쉽게 제작하고, 모델 성능을 비교하며, 텍스트-음성 변환 등 부가 기능을 챗 기반 앱에 추가할 수 있는 직관적 인터페이스를 제공합니다.

**4. RAG 파이프라인**:  
문서 수집부터 검색까지 폭넓은 RAG 기능을 제공합니다. PDF, PPT 등 일반 문서 형식의 텍스트 추출을 즉시 지원합니다.

**5. 에이전트 기능**:  
LLM Function Calling 또는 ReAct 기반 에이전트를 정의할 수 있으며, 에이전트에 사전 구축 또는 커스텀 도구를 추가할 수 있습니다. Dify는 Google Search, DALL·E, Stable Diffusion, WolframAlpha 등 50개 이상의 내장 도구를 AI 에이전트에 제공합니다.

**6. LLMOps**:  
시간에 따른 애플리케이션 로그와 성능을 모니터링 및 분석할 수 있습니다. 실제 운영 데이터를 바탕으로 프롬프트, 데이터셋, 모델을 지속적으로 개선할 수 있습니다.

**7. Backend-as-a-Service**:  
Dify의 모든 기능은 API로도 제공되어, 비즈니스 로직에 손쉽게 통합할 수 있습니다.

## 기능 비교

<table style="width: 100%;">
  <tr>
    <th align="center">기능</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">프로그래밍 방식</td>
    <td align="center">API + 앱 지향</td>
    <td align="center">Python 코드</td>
    <td align="center">앱 지향</td>
    <td align="center">API 지향</td>
  </tr>
  <tr>
    <td align="center">지원 LLM</td>
    <td align="center">다양함</td>
    <td align="center">다양함</td>
    <td align="center">다양함</td>
    <td align="center">OpenAI 전용</td>
  </tr>
  <tr>
    <td align="center">RAG 엔진</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">에이전트</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">워크플로우</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">가시성(Observability)</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">엔터프라이즈 기능 (SSO/접근 제어)</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">로컬 배포</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## Dify 사용법

- **클라우드 </br>**
  [Dify 클라우드](https://dify.ai) 서비스를 통해 누구나 설치 없이 바로 체험할 수 있습니다. 셀프 배포 버전의 모든 기능을 제공하며, 샌드박스 플랜에서 200회 무료 GPT-4 호출을 제공합니다.

- **셀프 호스팅 Dify 커뮤니티 에디션</br>**
  [시작 가이드](#quick-start)를 참고하여 환경에 맞게 Dify를 빠르게 실행하세요.  
  자세한 내용과 심화 안내는 [문서](https://docs.dify.ai)를 참고하세요.

- **엔터프라이즈/조직용 Dify</br>**
  엔터프라이즈 중심의 추가 기능을 제공합니다. [이 챗봇을 통해 문의](https://udify.app/chat/22L1zSxg6yW1cWQg)하거나 [이메일](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry)로 연락 주시면 엔터프라이즈 니즈에 대해 논의할 수 있습니다. </br>
  > AWS를 사용하는 스타트업 및 소규모 기업은 [AWS Marketplace의 Dify Premium](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6)을 확인하고, 한 번의 클릭으로 자체 AWS VPC에 배포할 수 있습니다. 맞춤형 로고 및 브랜딩 앱 생성이 가능한 합리적 가격의 AMI 상품입니다.

## 최신 소식 받기

GitHub에서 Dify에 별(star)을 눌러 최신 릴리즈 소식을 바로 받아보세요.

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## 고급 설정

구성을 맞춤화해야 한다면, [.env.example](docker/.env.example) 파일의 주석을 참고하여 `.env` 파일의 값을 수정하세요. 또한, 배포 환경과 요구사항에 따라 `docker-compose.yaml` 파일 자체에서 이미지 버전, 포트 매핑, 볼륨 마운트 등을 조정해야 할 수 있습니다. 변경 후에는 반드시 `docker compose up -d` 명령어로 재실행하세요. 사용 가능한 환경 변수 전체 목록은 [여기](https://docs.dify.ai/getting-started/install-self-hosted/environments)에서 확인할 수 있습니다.

고가용성 구성을 원한다면, 커뮤니티에서 제공한 [Helm Chart](https://helm.sh/) 및 YAML 파일을 통해 Kubernetes에 Dify를 배포할 수 있습니다.

- [@LeoQuote의 Helm Chart](https://github.com/douban/charts/tree/master/charts/dify)
- [@BorisPolonsky의 Helm Chart](https://github.com/BorisPolonsky/dify-helm)
- [@magicsong의 Helm Chart](https://github.com/magicsong/ai-charts)
- [@Winson-030의 YAML 파일](https://github.com/Winson-030/dify-kubernetes)
- [@wyy-holding의 YAML 파일](https://github.com/wyy-holding/dify-k8s)

#### Terraform을 이용한 배포

[terraform](https://www.terraform.io/)을 이용해 클라우드 플랫폼에 한 번의 클릭으로 Dify를 배포하세요.

##### Azure 글로벌

- [@nikawang의 Azure Terraform](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [@sotazum의 Google Cloud Terraform](https://github.com/DeNA/dify-google-cloud-terraform)

#### AWS CDK를 이용한 배포

[CDK](https://aws.amazon.com/cdk/)를 이용해 AWS에 Dify를 배포하세요.

##### AWS

- [@KevinZhao의 AWS CDK](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## 기여하기

코드 기여를 원하시는 분은 [기여 가이드](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md)를 참고해 주세요.  
아울러, Dify를 소셜 미디어·행사·컨퍼런스 등에서 공유하여 응원해 주시면 감사하겠습니다.

> 중국어 및 영어 외 언어로 Dify 번역에 기여하실 분을 찾고 있습니다. 관심 있으신 분은 [i18n README](https://github.com/langgenius/dify/blob/main/web/i18n/README.md)를 참고하시고, [Discord 커뮤니티 서버](https://discord.gg/8Tpq4AcN9c)의 `global-users` 채널에 댓글을 남겨주세요.

## 커뮤니티 & 연락처

- [GitHub Discussion](https://github.com/langgenius/dify/discussions). 피드백 공유와 질문에 적합합니다.
- [GitHub Issues](https://github.com/langgenius/dify/issues). 버그 신고 및 기능 제안에 적합합니다. [기여 가이드](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md) 참고.
- [Discord](https://discord.gg/FngNHpbcY7). 애플리케이션 공유 및 커뮤니티 소통에 적합합니다.
- [X(Twitter)](https://twitter.com/dify_ai). 애플리케이션 공유 및 커뮤니티 소통에 적합합니다.

**기여자**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## Star 히스토리

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## 보안 이슈 신고

개인정보 보호를 위해, 보안 관련 이슈는 GitHub에 게시하지 마세요. security@dify.ai로 문의하시면 보다 자세히 안내해 드립니다.

## 라이선스

이 저장소는 [Dify 오픈소스 라이선스](LICENSE) 하에 제공됩니다. 본 라이선스는 Apache 2.0을 기반으로 하며, 추가적인 몇 가지 제한사항이 있습니다.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---