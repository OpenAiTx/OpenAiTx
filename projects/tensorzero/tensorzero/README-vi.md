<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero tạo ra một vòng lặp phản hồi để tối ưu hóa các ứng dụng LLM — biến dữ liệu thực tế thành các mô hình thông minh hơn, nhanh hơn, và rẻ hơn.**

1. Tích hợp cổng mô hình của chúng tôi
2. Gửi các chỉ số hoặc phản hồi
3. Tối ưu hóa prompt, mô hình, và chiến lược suy diễn
4. Theo dõi LLMs của bạn cải thiện theo thời gian

TensorZero cung cấp **vòng quay dữ liệu & học tập cho LLMs** bằng cách hợp nhất:

- [x] **Suy diễn:** một API cho tất cả LLM, với độ trễ P99 <1ms
- [x] **Quan sát:** suy diễn & phản hồi → cơ sở dữ liệu của bạn
- [x] **Tối ưu hóa:** từ prompt đến fine-tuning và RL
- [x] **Đánh giá:** so sánh prompt, mô hình, chiến lược suy diễn
- [x] **Thử nghiệm:** tích hợp A/B testing, định tuyến, fallback

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">Website</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">Docs</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">Twitter</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">Quick Start (5min)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">Comprehensive Tutorial</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Deployment Guide</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">API Reference</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Configuration Reference</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>TensorZero là gì?</b></td>
    <td width="70%" valign="top">TensorZero là một framework mã nguồn mở để xây dựng các ứng dụng LLM đạt chuẩn sản xuất. Nó hợp nhất một cổng LLM, quan sát, tối ưu hóa, đánh giá và thử nghiệm.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero khác gì so với các framework LLM khác?</b></td>
    <td width="70%" valign="top">
      1. TensorZero cho phép bạn tối ưu hóa các ứng dụng LLM phức tạp dựa trên các chỉ số thực tế và phản hồi của con người.<br>
      2. TensorZero đáp ứng nhu cầu của các ứng dụng LLM quy mô công nghiệp: độ trễ thấp, thông lượng cao, an toàn kiểu dữ liệu, tự triển khai, GitOps, tùy biến, v.v.<br>
      3. TensorZero hợp nhất toàn bộ stack LLMOps, tạo ra lợi ích cộng hưởng. Ví dụ, đánh giá LLM có thể dùng để fine-tune mô hình cùng với các AI judge.
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Tôi có thể dùng TensorZero với ___ không?</b></td>
    <td width="70%" valign="top">Có. Mọi ngôn ngữ lập trình chính đều được hỗ trợ. Bạn có thể sử dụng TensorZero với client Python, bất kỳ SDK OpenAI nào, hoặc API HTTP của chúng tôi.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero đã sẵn sàng cho sản xuất chưa?</b></td>
    <td width="70%" valign="top">Có. Đây là một case study: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">Tự động hóa Code Changelogs tại một ngân hàng lớn với LLMs</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero có giá bao nhiêu?</b></td>
    <td width="70%" valign="top">Miễn phí. TensorZero hoàn toàn tự triển khai và mã nguồn mở. Không có tính năng trả phí.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Ai đang phát triển TensorZero?</b></td>
    <td width="70%" valign="top">Đội ngũ kỹ thuật của chúng tôi gồm một cựu maintainer Rust compiler, các nhà nghiên cứu machine learning (Stanford, CMU, Oxford, Columbia) với hàng nghìn trích dẫn, và giám đốc sản phẩm của một startup decacorn. Chúng tôi được hậu thuẫn bởi các nhà đầu tư của các dự án mã nguồn mở hàng đầu (ví dụ ClickHouse, CockroachDB) và phòng lab AI (ví dụ OpenAI, Anthropic).</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Làm sao để bắt đầu với TensorZero?</b></td>
    <td width="70%" valign="top">Bạn có thể áp dụng TensorZero từng bước. <b><a href="https://www.tensorzero.com/docs/quickstart">Quick Start</a></b> của chúng tôi sẽ hướng dẫn từ một wrapper OpenAI cơ bản đến một ứng dụng LLM sản xuất với quan sát và fine-tuning chỉ trong 5 phút.</td>
  </tr>
</table>

---

## Tính năng

### 🌐 Cổng LLM

> **Tích hợp với TensorZero một lần, truy cập mọi nhà cung cấp LLM lớn.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Nhà Cung Cấp Mô Hình</b></td>
    <td width="50%" align="center" valign="middle"><b>Tính Năng</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero Gateway hỗ trợ gốc cho:
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
          Cần nhà cung cấp khác?
          Nhà cung cấp của bạn rất có thể được hỗ trợ vì TensorZero tích hợp với <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">mọi API tương thích OpenAI (vd: Ollama)</a></b>.
          </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero Gateway hỗ trợ các tính năng nâng cao như:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">Retries & Fallbacks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">Tối ưu hóa thời gian suy diễn</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">Prompt Templates & Schemas</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">Thử nghiệm (A/B Testing)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">Cấu hình dưới dạng mã (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">Batch Inference</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">Suy diễn đa phương thức (VLMs)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">Bộ nhớ đệm suy diễn</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">Chỉ số & Phản hồi</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">Quy trình LLM nhiều bước (Episodes)</a></b></li>
        <li><em>& còn nhiều hơn nữa...</em></li>
      </ul>
      <p>
        TensorZero Gateway được viết bằng Rust 🦀 với mục tiêu <b>hiệu năng</b> (&lt;1ms p99 latency overhead @ 10k QPS).
        Xem <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">Benchmarks</a></b>.<br>
      </p>
      <p>
        Bạn có thể chạy suy diễn bằng <b>client TensorZero</b> (khuyến nghị), <b>client OpenAI</b>, hoặc <b>API HTTP</b>.
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>Cách dùng: Python &mdash; Client TensorZero (Khuyến nghị)</b></summary>

Bạn có thể truy cập bất cứ nhà cung cấp nào bằng client Python của TensorZero.

1. `pip install tensorzero`
2. Tuỳ chọn: Thiết lập cấu hình TensorZero.
3. Chạy suy diễn:

```python
from tensorzero import TensorZeroGateway  # hoặc AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # Dễ dàng thử các nhà cung cấp khác: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "Viết một bài thơ haiku về trí tuệ nhân tạo.",
                }
            ]
        },
    )
```

Xem **[Quick Start](https://www.tensorzero.com/docs/quickstart)** để biết thêm chi tiết.

</details>

<details>
<summary><b>Cách dùng: Python &mdash; Client OpenAI</b></summary>

Bạn có thể truy cập bất cứ nhà cung cấp nào bằng client Python của OpenAI với TensorZero.

1. `pip install tensorzero`
2. Tuỳ chọn: Thiết lập cấu hình TensorZero.
3. Chạy suy diễn:

```python
from openai import OpenAI  # hoặc AsyncOpenAI
from tensorzero import patch_openai_client

client = OpenAI()
patch_openai_client(
    client,
    clickhouse_url="http://chuser:chpassword@localhost:8123/tensorzero",
    config_file="config/tensorzero.toml",
    async_setup=False,
)

response = client.chat.completions.create(
    model="tensorzero::model_name::openai::gpt-4o-mini",
    # Thử các nhà cung cấp khác một cách dễ dàng: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "Viết một bài haiku về trí tuệ nhân tạo.",
        }
    ],
)
```

Xem **[Bắt đầu nhanh](https://www.tensorzero.com/docs/quickstart)** để biết thêm thông tin.

</details>

<details>
<summary><b>Sử dụng: JavaScript / TypeScript (Node) &mdash; OpenAI Client</b></summary>

Bạn có thể truy cập bất kỳ nhà cung cấp nào bằng OpenAI Node client với TensorZero.

1. Triển khai `tensorzero/gateway` bằng Docker.
   **[Hướng dẫn chi tiết →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Thiết lập cấu hình TensorZero.
3. Thực hiện suy luận:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // Thử các nhà cung cấp khác một cách dễ dàng: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "Viết một bài haiku về trí tuệ nhân tạo.",
    },
  ],
});
```

Xem **[Bắt đầu nhanh](https://www.tensorzero.com/docs/quickstart)** để biết thêm thông tin.

</details>

<details>
<summary><b>Sử dụng: Ngôn ngữ & Nền tảng khác &mdash; HTTP API</b></summary>

TensorZero hỗ trợ hầu như mọi ngôn ngữ lập trình hoặc nền tảng thông qua HTTP API của nó.

1. Triển khai `tensorzero/gateway` bằng Docker.
   **[Hướng dẫn chi tiết →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Tuỳ chọn: Thiết lập cấu hình TensorZero.
3. Thực hiện suy luận:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "Viết một bài haiku về trí tuệ nhân tạo."
        }
      ]
    }
  }'
```

Xem **[Bắt đầu nhanh](https://www.tensorzero.com/docs/quickstart)** để biết thêm thông tin.

</details>

<br>

### 📈 Tối ưu hóa LLM

> **Gửi các chỉ số sản xuất và phản hồi của con người để dễ dàng tối ưu hóa prompt, mô hình và chiến lược suy luận của bạn &mdash; sử dụng giao diện người dùng hoặc lập trình.**

#### Tối ưu hóa mô hình

Tối ưu hóa các mô hình mã nguồn đóng và mã nguồn mở bằng fine-tuning có giám sát (SFT) và fine-tuning theo sở thích (DPO).

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Fine-tuning có giám sát &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Fine-tuning theo sở thích (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### Tối ưu hóa trong thời gian suy luận

Tăng hiệu suất bằng cách cập nhật động prompt của bạn với các ví dụ liên quan, kết hợp phản hồi từ nhiều lần suy luận, và nhiều hơn nữa.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">Best-of-N Sampling</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#mixture-of-n-sampling">Mixture-of-N Sampling</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/c0edfa4c-713c-4996-9964-50c0d26e6970"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/75b5bf05-4c1f-43c4-b158-d69d1b8d05be"></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl">Dynamic In-Context Learning (DICL)</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#chain-of-thought-cot">Chain-of-Thought (CoT)</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d8489e92-ce93-46ac-9aab-289ce19bb67d"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/ea13d73c-76a4-4e0c-a35b-0c648f898311" height="320"></td>
  </tr>
</table>

_Sẽ sớm có thêm..._

<br>

#### Tối ưu hóa Prompt

Tối ưu hóa prompt của bạn bằng lập trình với các kỹ thuật tối ưu hóa dựa trên nghiên cứu.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">Tích hợp DSPy</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero đi kèm với nhiều công thức tối ưu hóa, nhưng bạn cũng có thể dễ dàng tạo công thức riêng.
      Ví dụ này minh họa cách tối ưu hóa một hàm TensorZero bằng một công cụ bất kỳ — ở đây là DSPy, thư viện nổi tiếng cho tự động hoá prompt engineering.
    </td>
  </tr>
</table>

_Sẽ sớm có thêm..._

<br>

### 🔍 Quan sát LLM

> **Phóng to để debug từng API call riêng lẻ, hoặc thu nhỏ để giám sát các chỉ số trên toàn bộ mô hình và prompt theo thời gian &mdash; tất cả bằng giao diện người dùng mã nguồn mở của TensorZero.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Quan sát » Suy luận</b></td>
    <td width="50%" align="center" valign="middle"><b>Quan sát » Hàm</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 Đánh giá LLM

> **So sánh prompt, mô hình và chiến lược suy luận bằng TensorZero Evaluations &mdash; với hỗ trợ cho heuristic và LLM judge.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Đánh giá » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Đánh giá » CLI</b></td>
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
semantic_match: 0.98 ± 0.01  
item_count: 7.15 ± 0.39</code></pre>
    </td>
  </tr>
</table>

## Demo

> **Xem LLM cải thiện khả năng trích xuất dữ liệu theo thời gian thực với TensorZero!**
>
> **[Dynamic in-context learning (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** là một tối ưu hóa mạnh mẽ trong thời gian suy luận, có sẵn ngay khi sử dụng TensorZero.
> Nó nâng cao hiệu suất của LLM bằng cách tự động bổ sung các ví dụ lịch sử liên quan vào prompt, mà không cần tinh chỉnh mô hình.

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## Kỹ thuật LLM với TensorZero

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

1. **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** là một cổng mô hình hiệu suất cao được viết bằng Rust 🦀, cung cấp giao diện API thống nhất cho tất cả các nhà cung cấp LLM lớn, cho phép tích hợp và chuyển đổi liền mạch giữa các nền tảng.
2. Nó xử lý suy luận dựa trên schema có cấu trúc với độ trễ P99 &lt;1ms (xem **[Benchmarks](https://www.tensorzero.com/docs/gateway/benchmarks)**) cùng tính năng quan sát, thử nghiệm và **[tối ưu hóa trong thời gian suy luận](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)** được tích hợp sẵn.
3. Nó cũng thu thập các chỉ số và phản hồi từ các suy luận này, với hỗ trợ hàng đầu cho các hệ thống LLM nhiều bước.
4. Mọi thứ đều được lưu trữ trong kho dữ liệu ClickHouse do bạn kiểm soát, cho phép phân tích thời gian thực, mở rộng và thân thiện với nhà phát triển.
5. Theo thời gian, **[TensorZero Recipes](https://www.tensorzero.com/docs/recipes)** tận dụng tập dữ liệu có cấu trúc này để tối ưu hóa prompt và mô hình của bạn: chạy các recipe dựng sẵn cho các workflow phổ biến như fine-tuning, hoặc tự tạo recipe của riêng bạn với sự linh hoạt hoàn toàn trên bất kỳ ngôn ngữ và nền tảng nào.
6. Cuối cùng, các tính năng thử nghiệm và orchestration GitOps của gateway cho phép bạn lặp lại và triển khai tự tin, dù chỉ với một LLM hay hàng nghìn LLM.

Mục tiêu của chúng tôi là giúp kỹ sư xây dựng, quản lý và tối ưu hóa thế hệ ứng dụng LLM tiếp theo: các hệ thống học hỏi từ kinh nghiệm thực tế.  
Đọc thêm về **[Tầm nhìn & Lộ trình phát triển](https://www.tensorzero.com/docs/vision-roadmap/)** của chúng tôi.

## Bắt đầu

**Bắt đầu xây dựng ngay hôm nay.**  
**[Hướng dẫn Nhanh](https://www.tensorzero.com/docs/quickstart)** cho thấy việc thiết lập ứng dụng LLM với TensorZero dễ dàng như thế nào.  
Nếu bạn muốn tìm hiểu sâu hơn, **[Tutorial](https://www.tensorzero.com/docs/gateway/tutorial)** sẽ hướng dẫn bạn xây dựng chatbot đơn giản, trợ lý email, hệ thống RAG thời tiết và pipeline trích xuất dữ liệu có cấu trúc.

**Có câu hỏi?**  
Hỏi chúng tôi trên **[Slack](https://www.tensorzero.com/slack)** hoặc **[Discord](https://www.tensorzero.com/discord)**.

**Đang sử dụng TensorZero tại nơi làm việc?**  
Gửi email cho chúng tôi tại **[hello@tensorzero.com](mailto:hello@tensorzero.com)** để thiết lập kênh Slack hoặc Teams với nhóm của bạn (miễn phí).

**Làm việc cùng chúng tôi.**  
Chúng tôi đang **[tuyển dụng tại NYC](https://www.tensorzero.com/jobs)**.  
Chúng tôi cũng hoan nghênh **[đóng góp mã nguồn mở](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)**!

## Ví dụ

Chúng tôi đang thực hiện một loạt **ví dụ hoàn chỉnh có thể chạy được** minh họa cho vòng lặp dữ liệu & học tập của TensorZero.

> **[Tối ưu hóa Trích xuất Dữ liệu (NER) với TensorZero](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> Ví dụ này trình bày cách sử dụng TensorZero để tối ưu hóa pipeline trích xuất dữ liệu.
> Chúng tôi trình diễn các kỹ thuật như fine-tuning và dynamic in-context learning (DICL).
> Cuối cùng, mô hình GPT-4o Mini đã được tối ưu hóa vượt qua GPT-4o trong tác vụ này — với chi phí và độ trễ chỉ bằng một phần nhỏ — sử dụng lượng dữ liệu huấn luyện rất nhỏ.

> **[Agentic RAG — Trả lời Câu hỏi Đa Bước với LLM](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> Ví dụ này trình bày cách xây dựng agent truy xuất đa bước bằng TensorZero.
> Agent sẽ lặp lại việc tìm kiếm trên Wikipedia để thu thập thông tin và quyết định khi nào đã có đủ ngữ cảnh để trả lời câu hỏi phức tạp.

> **[Sáng tác Haiku để Làm Hài Lòng Ban Giám Khảo với Sở Thích Ẩn](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> Ví dụ này fine-tune GPT-4o Mini để tạo ra các bài haiku phù hợp với sở thích riêng biệt.
> Bạn sẽ thấy "vòng lặp dữ liệu trong hộp" của TensorZero hoạt động: biến thể tốt hơn tạo ra dữ liệu tốt hơn, và dữ liệu tốt hơn lại sinh ra biến thể tốt hơn.
> Bạn sẽ thấy sự tiến bộ khi fine-tune LLM nhiều lần.

> **[Cải thiện Kỹ Năng Chơi Cờ của LLM với Best-of-N Sampling](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> Ví dụ này minh họa cách best-of-N sampling có thể nâng cao đáng kể khả năng chơi cờ của LLM bằng cách chọn ra nước đi triển vọng nhất từ nhiều tùy chọn được sinh ra.

> **[Cải thiện Lý luận Toán học với Recipe Tùy chỉnh cho Kỹ thuật Prompt Tự động (DSPy)](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero cung cấp nhiều recipe tối ưu hóa dựng sẵn cho các workflow kỹ thuật LLM phổ biến.
> Nhưng bạn cũng có thể dễ dàng tạo recipe và workflow của riêng mình!
> Ví dụ này trình bày cách tối ưu hóa một hàm TensorZero bằng công cụ bất kỳ — ở đây là DSPy.

_& còn nhiều ví dụ khác đang được phát triển!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---