<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero는 LLM 애플리케이션 최적화를 위한 피드백 루프를 생성하여, 프로덕션 데이터를 더 똑똑하고 빠르며 저렴한 모델로 전환합니다.**

1. 모델 게이트웨이 통합
2. 메트릭 또는 피드백 전송
3. 프롬프트, 모델, 추론 전략 최적화
4. 시간이 지날수록 LLM의 성능 향상 확인

TensorZero는 다음을 통합하여 **LLM을 위한 데이터 & 러닝 플라이휠**을 제공합니다.

- [x] **추론:** 모든 LLM을 위한 하나의 API, P99 오버헤드 <1ms
- [x] **관찰성:** 추론 & 피드백 → 당신의 데이터베이스로
- [x] **최적화:** 프롬프트부터 파인튜닝, RL까지
- [x] **평가:** 프롬프트, 모델, 추론 전략 비교
- [x] **실험:** 내장된 A/B 테스트, 라우팅, 폴백

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">웹사이트</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">문서</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">트위터</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">슬랙</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">디스코드</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">빠른 시작 (5분)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">종합 튜토리얼</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">배포 가이드</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">API 레퍼런스</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">설정 레퍼런스</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>TensorZero란?</b></td>
    <td width="70%" valign="top">TensorZero는 프로덕션급 LLM 애플리케이션 구축을 위한 오픈소스 프레임워크입니다. LLM 게이트웨이, 관찰성, 최적화, 평가, 실험을 통합합니다.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero는 다른 LLM 프레임워크와 무엇이 다른가요?</b></td>
    <td width="70%" valign="top">
      1. TensorZero는 프로덕션 메트릭 및 인간 피드백 기반으로 복잡한 LLM 애플리케이션을 최적화할 수 있게 합니다.<br>
      2. TensorZero는 산업 규모의 LLM 애플리케이션 요구사항(저지연, 고처리량, 타입 안전, 셀프 호스팅, GitOps, 커스터마이즈 등)을 지원합니다.<br>
      3. TensorZero는 전체 LLMOps 스택을 통합하여 복합적인 이점을 제공합니다. 예를 들어, LLM 평가는 AI 심사관과 함께 모델 파인튜닝에 활용될 수 있습니다.
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero를 ___와 함께 사용할 수 있나요?</b></td>
    <td width="70%" valign="top">네, 모든 주요 프로그래밍 언어를 지원합니다. TensorZero는 Python 클라이언트, OpenAI SDK, HTTP API와 함께 사용할 수 있습니다.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero는 프로덕션에 바로 쓸 수 있나요?</b></td>
    <td width="70%" valign="top">네, 다음은 사례 연구입니다: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">대형 은행의 코드 변경 로그 자동화 사례</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero는 비용이 얼마나 드나요?</b></td>
    <td width="70%" valign="top">무료입니다. TensorZero는 100% 셀프 호스팅 및 오픈소스입니다. 유료 기능이 없습니다.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero는 누가 개발하나요?</b></td>
    <td width="70%" valign="top">기술팀은 전직 Rust 컴파일러 유지관리자, 수천 건의 인용 논문을 보유한 머신러닝 연구자(Stanford, CMU, Oxford, Columbia), 데카콘 스타트업의 CPO로 구성되어 있습니다. ClickHouse, CockroachDB 등 오픈소스 및 OpenAI, Anthropic 등 AI 연구소와 같은 투자자들의 지원을 받고 있습니다.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>시작하려면 어떻게 해야 하나요?</b></td>
    <td width="70%" valign="top">TensorZero는 점진적으로 도입할 수 있습니다. <b><a href="https://www.tensorzero.com/docs/quickstart">빠른 시작</a></b>에서는 OpenAI 래퍼에서 관찰성과 파인튜닝을 갖춘 프로덕션 준비 LLM 애플리케이션까지 5분 만에 안내합니다.</td>
  </tr>
</table>

---

## 기능

### 🌐 LLM 게이트웨이

> **TensorZero와 한 번만 통합하면 모든 주요 LLM 제공업체에 접근할 수 있습니다.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>모델 제공업체</b></td>
    <td width="50%" align="center" valign="middle"><b>기능</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero Gateway가 기본 지원하는 모델:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/anthropic">Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-bedrock">AWS Bedrock</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-sagemaker">AWS SageMaker</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/azure">Azure OpenAI Service</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/deepseek">DeepSeek</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/fireworks">Fireworks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-anthropic">GCP Vertex AI Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-gemini">GCP Vertex AI Gemini</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/google-ai-studio-gemini">Google AI Studio (Gemini API)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/hyperbolic">Hyperbolic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/mistral">Mistral</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai">OpenAI</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/together">Together</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/vllm">vLLM</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/xai">xAI</a></b></li>
      </ul>
      <p>
        <em>
          다른 제공업체가 필요하신가요?<br>
          TensorZero는 <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">OpenAI 호환 API (예: Ollama)</a></b>와 통합하므로 대부분의 제공업체를 지원합니다.
        </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero Gateway는 다음과 같은 고급 기능을 지원합니다:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">재시도 & 폴백</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">추론 시점 최적화</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">프롬프트 템플릿 & 스키마</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">실험 (A/B 테스트)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">코드로서의 설정 (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">배치 추론</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">멀티모달 추론 (VLMs)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">추론 캐싱</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">메트릭 & 피드백</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">다단계 LLM 워크플로우 (에피소드)</a></b></li>
        <li><em>및 다양한 기능...</em></li>
      </ul>
      <p>
        TensorZero Gateway는 <b>성능</b>을 염두에 두고 Rust 🦀로 작성되었습니다 (10k QPS 기준 p99 지연 <1ms).
        <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">벤치마크</a></b> 참조.<br>
      </p>
      <p>
        <b>TensorZero 클라이언트</b>(권장), <b>OpenAI 클라이언트</b>, <b>HTTP API</b>를 사용해 추론을 실행할 수 있습니다.
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>사용법: Python &mdash; TensorZero 클라이언트 (권장)</b></summary>

TensorZero Python 클라이언트를 사용하여 모든 제공업체에 접근할 수 있습니다.

1. `pip install tensorzero`
2. 선택 사항: TensorZero 설정 구성
3. 추론 실행:

```python
from tensorzero import TensorZeroGateway  # 또는 AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # 다른 제공업체도 쉽게 사용 가능: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "Write a haiku about artificial intelligence.",
                }
            ]
        },
    )
```

더 자세한 정보는 **[빠른 시작](https://www.tensorzero.com/docs/quickstart)** 참고.

</details>

<details>
<summary><b>사용법: Python &mdash; OpenAI 클라이언트</b></summary>

TensorZero와 함께 OpenAI Python 클라이언트를 사용하여 모든 제공업체에 접근할 수 있습니다.

1. `pip install tensorzero`
2. 선택 사항: TensorZero 설정 구성
3. 추론 실행:

```python
from openai import OpenAI  # 또는 AsyncOpenAI
from tensorzero import patch_openai_client

client = OpenAI()
```
```python
patch_openai_client(
    client,
    clickhouse_url="http://chuser:chpassword@localhost:8123/tensorzero",
    config_file="config/tensorzero.toml",
    async_setup=False,
)

response = client.chat.completions.create(
    model="tensorzero::model_name::openai::gpt-4o-mini",
    # 다른 프로바이더도 쉽게 시도하세요: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "인공지능에 관한 하이쿠를 작성하세요.",
        }
    ],
)
```

자세한 내용은 **[빠른 시작 가이드](https://www.tensorzero.com/docs/quickstart)**를 참고하세요.

</details>

<details>
<summary><b>사용법: JavaScript / TypeScript (Node) &mdash; OpenAI 클라이언트</b></summary>

TensorZero를 사용하면 OpenAI Node 클라이언트로 모든 프로바이더에 접근할 수 있습니다.

1. Docker를 사용하여 `tensorzero/gateway`를 배포합니다.
   **[자세한 배포 안내 →](https://www.tensorzero.com/docs/gateway/deployment)**
2. TensorZero 설정을 구성합니다.
3. 추론을 실행합니다:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // 다른 프로바이더도 쉽게 시도하세요: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "인공지능에 관한 하이쿠를 작성하세요.",
    },
  ],
});
```

자세한 내용은 **[빠른 시작 가이드](https://www.tensorzero.com/docs/quickstart)**를 참고하세요.

</details>

<details>
<summary><b>사용법: 기타 언어 및 플랫폼 &mdash; HTTP API</b></summary>

TensorZero는 HTTP API를 통해 거의 모든 프로그래밍 언어나 플랫폼을 지원합니다.

1. Docker를 사용하여 `tensorzero/gateway`를 배포합니다.
   **[자세한 배포 안내 →](https://www.tensorzero.com/docs/gateway/deployment)**
2. 선택 사항: TensorZero 설정을 구성합니다.
3. 추론을 실행합니다:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "인공지능에 관한 하이쿠를 작성하세요."
        }
      ]
    }
  }'
```

자세한 내용은 **[빠른 시작 가이드](https://www.tensorzero.com/docs/quickstart)**를 참고하세요.

</details>

<br>

### 📈 LLM 최적화

> **프로덕션 메트릭 및 사용자 피드백을 전송하여 프롬프트, 모델, 추론 전략을 쉽게 최적화할 수 있습니다 — UI 또는 프로그래밍 방식으로 지원됩니다.**

#### 모델 최적화

감독 학습(SFT) 및 선호 학습(DPO)을 통해 클로즈드소스 및 오픈소스 모델을 최적화하세요.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>감독 미세조정 &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>선호 미세조정 (DPO) &mdash; 주피터 노트북</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### 추론 시점 최적화

관련 예시로 프롬프트를 동적으로 갱신하거나, 여러 번의 추론 결과를 결합하는 등으로 성능을 향상할 수 있습니다.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">Best-of-N 샘플링</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#mixture-of-n-sampling">Mixture-of-N 샘플링</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/c0edfa4c-713c-4996-9964-50c0d26e6970"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/75b5bf05-4c1f-43c4-b158-d69d1b8d05be"></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl">동적 인컨텍스트 학습 (DICL)</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#chain-of-thought-cot">Chain-of-Thought (CoT)</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d8489e92-ce93-46ac-9aab-289ce19bb67d"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/ea13d73c-76a4-4e0c-a35b-0c648f898311" height="320"></td>
  </tr>
</table>

_추가 기능이 곧 제공될 예정입니다..._

<br>

#### 프롬프트 최적화

연구 기반 최적화 기법을 사용하여 프로그래밍 방식으로 프롬프트를 최적화하세요.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">DSPy 통합</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero는 여러 최적화 레시피를 기본 제공하며, 직접 새로운 레시피를 쉽게 만들 수도 있습니다.
      이 예시는 임의의 도구 — 여기서는 자동 프롬프트 엔지니어링을 위한 인기 라이브러리 DSPy — 를 사용해 TensorZero 함수를 최적화하는 방법을 보여줍니다.
    </td>
  </tr>
</table>

_추가 기능이 곧 제공될 예정입니다..._

<br>

### 🔍 LLM 가시성(Observability)

> **API 호출 단위로 디버깅하거나, 장기간에 걸쳐 모델 및 프롬프트 메트릭을 모니터링하세요 — 오픈소스 TensorZero UI에서 모두 지원됩니다.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>가시성 » 추론</b></td>
    <td width="50%" align="center" valign="middle"><b>가시성 » 함수</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 LLM 평가

> **TensorZero 평가 기능을 활용하여 프롬프트, 모델, 추론 전략을 비교하세요 — 휴리스틱 및 LLM 판정 지원.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>평가 » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>평가 » CLI</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/f4bf54e3-1b63-46c8-be12-2eaabf615699"></td>
    <td width="50%" align="left" valign="middle">
<pre><code class="language-bash">docker compose run --rm evaluations \
  --evaluation-name extract_data \
  --dataset-name hard_test_cases \
  --variant-name gpt_4o \
  --concurrency 5</code></pre>
<pre><code class="language-bash">Run ID: 01961de9-c8a4-7c60-ab8d-15491a9708e4
Number of datapoints: 100
██████████████████████████████████████ 100/100
exact_match: 0.83 ± 0.03
```
semantic_match: 0.98 ± 0.01  
item_count: 7.15 ± 0.39</code></pre>
    </td>
  </tr>
</table>

## 데모

> **TensorZero와 함께 LLM이 실시간으로 데이터 추출 능력을 향상시키는 모습을 확인해보세요!**
>
> **[동적 인컨텍스트 학습(DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)**은 TensorZero에서 기본적으로 제공되는 강력한 추론 최적화 기능입니다.
> 이 기능은 모델 파인튜닝 없이도 관련된 과거 예시를 자동으로 프롬프트에 반영하여 LLM의 성능을 향상시킵니다.

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## TensorZero를 활용한 LLM 엔지니어링

<br>
<p align="center" >
  <a href="https://www.tensorzero.com/docs">
    <picture>
      <source media="(prefers-color-scheme: light)" srcset="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6">
      <source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/e8bc699b-6378-4c2a-9cc1-6d189025e270">
      <img alt="TensorZero Flywheel" src="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6" width=720>
    </picture>
  </a>
</p>
<br>

1. **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)**는 Rust 🦀로 작성된 고성능 모델 게이트웨이로, 모든 주요 LLM 제공업체에 대한 통합 API 인터페이스를 제공하여 플랫폼 간 통합 및 폴백을 원활하게 지원합니다.
2. 구조화된 스키마 기반 추론을 <1ms P99 지연 시간 오버헤드(자세한 내용은 **[Benchmarks](https://www.tensorzero.com/docs/gateway/benchmarks)** 참조)로 처리하며, 내장된 관측 기능, 실험 기능, **[추론 최적화](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)**를 제공합니다.
3. 이러한 추론과 관련된 다운스트림 메트릭 및 피드백도 수집하며, 다단계 LLM 시스템을 1급 시민으로 지원합니다.
4. 모든 데이터는 실시간, 확장 가능하며 개발자 친화적인 분석을 위해 여러분이 직접 제어할 수 있는 ClickHouse 데이터 웨어하우스에 저장됩니다.
5. 시간이 지남에 따라 **[TensorZero Recipes](https://www.tensorzero.com/docs/recipes)**가 이 구조화된 데이터셋을 활용하여 프롬프트와 모델을 최적화합니다. 파인튜닝 등 일반적인 워크플로우를 위한 사전 구축된 레시피를 실행하거나, 원하는 언어와 플랫폼으로 나만의 레시피를 자유롭게 만들 수 있습니다.
6. 마지막으로, 게이트웨이의 실험 기능과 GitOps 오케스트레이션을 활용해 단일 LLM부터 수천 개의 LLM까지 자신 있게 반복·배포할 수 있습니다.

저희의 목표는 엔지니어가 실세계 경험을 통해 학습하는 차세대 LLM 애플리케이션(시스템)을 구축, 관리, 최적화할 수 있도록 돕는 것입니다.  
**[비전 및 로드맵](https://www.tensorzero.com/docs/vision-roadmap/)**에서 자세한 내용을 확인하세요.

## 시작하기

**지금 바로 빌드를 시작하세요.**  
**[Quick Start](https://www.tensorzero.com/docs/quickstart)**에서는 TensorZero로 LLM 애플리케이션을 손쉽게 구축하는 방법을 안내합니다.  
더 깊이 배우고 싶다면 **[Tutorial](https://www.tensorzero.com/docs/gateway/tutorial)**에서 간단한 챗봇, 이메일 코파일럿, 날씨 RAG 시스템, 구조화 데이터 추출 파이프라인 구축법을 배울 수 있습니다.

**궁금한 점이 있으신가요?**  
**[Slack](https://www.tensorzero.com/slack)** 또는 **[Discord](https://www.tensorzero.com/discord)**에서 문의해 주세요.

**업무에서 TensorZero를 사용 중이신가요?**  
**[hello@tensorzero.com](mailto:hello@tensorzero.com)**로 이메일을 보내주시면, 여러분 팀과 함께할 전용 Slack 또는 Teams 채널을 무료로 마련해 드립니다.

**함께 일하고 싶으신가요?**  
저희는 **[NYC에서 채용 중](https://www.tensorzero.com/jobs)**입니다.  
또한 **[오픈소스 기여](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)**도 환영합니다!

## 예시

TensorZero의 데이터 & 러닝 플라이휠을 보여주는 **완전 실행 가능한 예제** 시리즈를 준비 중입니다.

> **[TensorZero를 활용한 데이터 추출(NER) 최적화](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> 이 예제에서는 TensorZero로 데이터 추출 파이프라인을 최적화하는 방법을 보여줍니다.
> 파인튜닝과 동적 인컨텍스트 학습(DICL) 등 다양한 기법을 시연합니다.
> 결과적으로, 소량의 학습 데이터만으로 최적화된 GPT-4o Mini 모델이 비용과 지연 시간을 획기적으로 줄이면서도 동일 작업에서 GPT-4o보다 우수한 성능을 보입니다.

> **[에이전틱 RAG — LLM을 활용한 다중 단계 질의응답](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> 이 예제는 TensorZero를 이용해 다중 단계 검색 에이전트를 구축하는 방법을 보여줍니다.
> 에이전트는 위키피디아를 반복적으로 탐색해 정보를 수집하고, 충분한 맥락이 쌓였다고 판단되면 복잡한 질문에 답변을 제공합니다.

> **[숨겨진 선호를 가진 심사위원을 만족시키는 하이쿠 생성하기](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> 이 예제는 GPT-4o Mini를 파인튜닝해 특정 취향에 맞는 하이쿠를 생성하도록 만듭니다.
> TensorZero의 "상자 안 데이터 플라이휠"을 직접 경험할 수 있습니다: 더 나은 변종이 더 좋은 데이터를 만들고, 더 좋은 데이터가 더 나은 변종으로 이어집니다.
> LLM을 여러 번 파인튜닝하는 과정을 통해 발전하는 모습을 볼 수 있습니다.

> **[Best-of-N 샘플링으로 LLM 체스 실력 향상시키기](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> 이 예제는 여러 번 생성된 옵션 중 가장 유망한 수를 선택하는 Best-of-N 샘플링 기법이 LLM의 체스 실력을 어떻게 크게 향상시킬 수 있는지 보여줍니다.

> **[자동 프롬프트 엔지니어링(DSPy)을 위한 커스텀 레시피로 수학적 추론 향상](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero는 다양한 LLM 엔지니어링 워크플로우를 위한 사전 구축된 최적화 레시피를 제공합니다.
> 물론, 여러분만의 레시피와 워크플로우도 쉽게 만들 수 있습니다!
> 이 예제에서는 임의의 도구(DSPy)를 활용해 TensorZero 함수를 최적화하는 방법을 보여줍니다.

_그리고 더 많은 예제가 곧 추가될 예정입니다!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---