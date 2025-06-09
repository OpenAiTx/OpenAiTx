<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero สร้างวงจรป้อนกลับเพื่อเพิ่มประสิทธิภาพแอปพลิเคชัน LLM — เปลี่ยนข้อมูลการใช้งานจริงให้กลายเป็นโมเดลที่ฉลาดขึ้น เร็วขึ้น และราคาถูกลง**

1. เชื่อมต่อเกตเวย์โมเดลของเรา
2. ส่งเมตริกหรือฟีดแบ็ก
3. เพิ่มประสิทธิภาพพรอมต์ โมเดล และกลยุทธ์อินเฟอเรนซ์
4. ดู LLM ของคุณพัฒนาอย่างต่อเนื่อง

TensorZero มอบ **วงจรข้อมูลและการเรียนรู้สำหรับ LLMs** โดยผสานรวม:

- [x] **Inference:** API เดียวสำหรับทุก LLM, พร้อมค่า overhead <1ms P99
- [x] **Observability:** การอินเฟอเรนซ์ & ฟีดแบ็ก → ฐานข้อมูลของคุณ
- [x] **Optimization:** ตั้งแต่พรอมต์จนถึงการปรับแต่งโมเดลและ RL
- [x] **Evaluations:** เปรียบเทียบพรอมต์ โมเดล กลยุทธ์อินเฟอเรนซ์
- [x] **Experimentation:** A/B testing, การกำหนดเส้นทาง, สำรองในตัว

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">เว็บไซต์</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">เอกสาร</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">Twitter</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">เริ่มต้นอย่างรวดเร็ว (5 นาที)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">คู่มือฉบับสมบูรณ์</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">คู่มือการติดตั้งใช้งาน</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">API Reference</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Configuration Reference</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>TensorZero คืออะไร?</b></td>
    <td width="70%" valign="top">TensorZero คือเฟรมเวิร์กโอเพนซอร์สสำหรับสร้างแอปพลิเคชัน LLM ที่พร้อมใช้งานในระดับโปรดักชัน โดยผสานรวมเกตเวย์ LLM, observability, การเพิ่มประสิทธิภาพ, การประเมินผล และการทดลองไว้ในหนึ่งเดียว</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero แตกต่างจากเฟรมเวิร์ก LLM อื่นอย่างไร?</b></td>
    <td width="70%" valign="top">
      1. TensorZero ช่วยให้คุณสามารถเพิ่มประสิทธิภาพแอป LLM ที่ซับซ้อนได้โดยอิงจากเมตริกการใช้งานจริงและฟีดแบ็กจากมนุษย์<br>
      2. TensorZero ตอบโจทย์การใช้งาน LLM ในระดับอุตสาหกรรม: latency ต่ำ, throughput สูง, type safety, self-hosted, GitOps, ปรับแต่งได้ ฯลฯ<br>
      3. TensorZero ผสานรวมระบบ LLMOps ทั้งหมด ทำให้เกิดประโยชน์ทวีคูณ เช่น การประเมินผล LLM สามารถนำไปใช้ในการปรับแต่งโมเดลร่วมกับ AI judges ได้
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>ฉันสามารถใช้ TensorZero กับ ___ ได้ไหม?</b></td>
    <td width="70%" valign="top">ได้ ทุกภาษาการเขียนโปรแกรมหลักรองรับ คุณสามารถใช้ TensorZero กับ Python client ของเรา, SDK ของ OpenAI ใดก็ได้ หรือ HTTP API ของเรา</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero พร้อมใช้งานในโปรดักชันหรือยัง?</b></td>
    <td width="70%" valign="top">พร้อมแล้ว นี่คือตัวอย่างกรณีศึกษา: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">Automating Code Changelogs at a Large Bank with LLMs</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero มีค่าใช้จ่ายเท่าไร?</b></td>
    <td width="70%" valign="top">ไม่มีค่าใช้จ่าย TensorZero เป็นโอเพนซอร์สและ self-hosted 100% ไม่มีฟีเจอร์ที่ต้องจ่ายเงิน</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>ใครคือผู้อยู่เบื้องหลัง TensorZero?</b></td>
    <td width="70%" valign="top">ทีมเทคนิคของเราประกอบด้วยอดีต maintainer คอมไพเลอร์ Rust นักวิจัย machine learning (Stanford, CMU, Oxford, Columbia) ที่มีผลงานอ้างอิงนับพันครั้ง และ CPO ของสตาร์ทอัพระดับ decacorn เราได้รับการสนับสนุนจากนักลงทุนรายเดียวกับโครงการโอเพนซอร์สชั้นนำ (เช่น ClickHouse, CockroachDB) และห้องปฏิบัติการ AI (เช่น OpenAI, Anthropic)</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>จะเริ่มต้นใช้งานได้อย่างไร?</b></td>
    <td width="70%" valign="top">คุณสามารถนำ TensorZero ไปใช้ได้ทีละส่วน ดู <b><a href="https://www.tensorzero.com/docs/quickstart">Quick Start</a></b> ซึ่งจะแนะนำตั้งแต่ OpenAI wrapper ธรรมดาจนถึงแอป LLM ที่พร้อมใช้ในโปรดักชันพร้อม observability และ fine-tuning ในเวลาเพียง 5 นาที</td>
  </tr>
</table>

---

## ฟีเจอร์

### 🌐 LLM Gateway

> **เชื่อมต่อกับ TensorZero เพียงครั้งเดียว เข้าถึงผู้ให้บริการ LLM รายใหญ่ทุกเจ้า**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>ผู้ให้บริการโมเดล</b></td>
    <td width="50%" align="center" valign="middle"><b>ฟีเจอร์</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero Gateway รองรับโดยตรง:
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
          ต้องการผู้ให้บริการรายอื่นหรือไม่?<br>
          ส่วนใหญ่แล้ว TensorZero รองรับอยู่แล้ว เพราะสามารถเชื่อมต่อกับ <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">API ที่รองรับ OpenAI (เช่น Ollama)</a></b>
          </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero Gateway รองรับฟีเจอร์ขั้นสูง เช่น:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">Retries & Fallbacks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">Inference-Time Optimizations</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">Prompt Templates & Schemas</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">Experimentation (A/B Testing)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">Configuration-as-Code (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">Batch Inference</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">Multimodal Inference (VLMs)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">Inference Caching</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">Metrics & Feedback</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">Multi-Step LLM Workflows (Episodes)</a></b></li>
        <li><em>และอื่น ๆ อีกมาก...</em></li>
      </ul>
      <p>
        TensorZero Gateway เขียนด้วยภาษา Rust 🦀 คำนึงถึง <b>ประสิทธิภาพ</b> (latency overhead <1ms p99 @ 10k QPS)<br>
        ดู <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">Benchmarks</a></b>.<br>
      </p>
      <p>
        คุณสามารถเรียกใช้อินเฟอเรนซ์ด้วย <b>TensorZero client</b> (แนะนำ), <b>OpenAI client</b>, หรือ <b>HTTP API</b>
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>วิธีใช้งาน: Python &mdash; TensorZero Client (แนะนำ)</b></summary>

คุณสามารถเข้าถึงผู้ให้บริการใดก็ได้ผ่าน TensorZero Python client

1. `pip install tensorzero`
2. ตัวเลือก: ตั้งค่า TensorZero configuration
3. เรียกใช้อินเฟอเรนซ์:

```python
from tensorzero import TensorZeroGateway  # or AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # ลองใช้ผู้ให้บริการรายอื่นได้ง่าย: "anthropic::claude-3-7-sonnet-20250219"
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

ดูเพิ่มเติมที่ **[Quick Start](https://www.tensorzero.com/docs/quickstart)**

</details>

<details>
<summary><b>วิธีใช้งาน: Python &mdash; OpenAI Client</b></summary>

คุณสามารถเข้าถึงผู้ให้บริการใดก็ได้ด้วย OpenAI Python client ผ่าน TensorZero

1. `pip install tensorzero`
2. ตัวเลือก: ตั้งค่า TensorZero configuration
3. เรียกใช้อินเฟอเรนซ์:

```python
from openai import OpenAI  # or AsyncOpenAI
from tensorzero import patch_openai_client

client = OpenAI()
```
patch_openai_client(
    client,
    clickhouse_url="http://chuser:chpassword@localhost:8123/tensorzero",
    config_file="config/tensorzero.toml",
    async_setup=False,
)

response = client.chat.completions.create(
    model="tensorzero::model_name::openai::gpt-4o-mini",
    # ลองใช้ผู้ให้บริการอื่นได้ง่าย ๆ: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "Write a haiku about artificial intelligence.",
        }
    ],
)
```

ดูข้อมูลเพิ่มเติมได้ที่ **[เริ่มต้นอย่างรวดเร็ว](https://www.tensorzero.com/docs/quickstart)**

</details>

<details>
<summary><b>การใช้งาน: JavaScript / TypeScript (Node) &mdash; OpenAI Client</b></summary>

คุณสามารถเข้าถึงผู้ให้บริการใดก็ได้โดยใช้ OpenAI Node client ร่วมกับ TensorZero

1. ติดตั้ง `tensorzero/gateway` ด้วย Docker  
   **[ดูคำแนะนำแบบละเอียด →](https://www.tensorzero.com/docs/gateway/deployment)**
2. ตั้งค่า TensorZero configuration
3. เริ่มการ inference:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // ลองใช้ผู้ให้บริการอื่นได้ง่าย ๆ: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "Write a haiku about artificial intelligence.",
    },
  ],
});
```

ดูข้อมูลเพิ่มเติมได้ที่ **[เริ่มต้นอย่างรวดเร็ว](https://www.tensorzero.com/docs/quickstart)**

</details>

<details>
<summary><b>การใช้งาน: ภาษาและแพลตฟอร์มอื่น ๆ &mdash; HTTP API</b></summary>

TensorZero รองรับเกือบทุกภาษาโปรแกรมหรือแพลตฟอร์มผ่าน HTTP API

1. ติดตั้ง `tensorzero/gateway` ด้วย Docker  
   **[ดูคำแนะนำแบบละเอียด →](https://www.tensorzero.com/docs/gateway/deployment)**
2. (ทางเลือก) ตั้งค่า TensorZero configuration
3. เริ่มการ inference:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "Write a haiku about artificial intelligence."
        }
      ]
    }
  }'
```

ดูข้อมูลเพิ่มเติมได้ที่ **[เริ่มต้นอย่างรวดเร็ว](https://www.tensorzero.com/docs/quickstart)**

</details>

<br>

### 📈 การเพิ่มประสิทธิภาพ LLM

> **ส่งข้อมูลเมตริกการใช้งานจริงและฟีดแบ็กจากมนุษย์ เพื่อปรับแต่ง prompt, โมเดล และกลยุทธ์ inference ได้อย่างง่ายดาย — ทั้งผ่าน UI หรือโปรแกรม**

#### การเพิ่มประสิทธิภาพโมเดล

ปรับแต่งโมเดลแบบ closed-source และ open-source ด้วย supervised fine-tuning (SFT) และ preference fine-tuning (DPO)

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Supervised Fine-tuning &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Preference Fine-tuning (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### การเพิ่มประสิทธิภาพขณะ inference

เพิ่มประสิทธิภาพโดยอัปเดต prompt ด้วยตัวอย่างที่เกี่ยวข้องแบบไดนามิก ผสมผสานผลลัพธ์จากการ inference หลายครั้ง และอื่น ๆ

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

_ฟีเจอร์อื่น ๆ กำลังจะมาเร็ว ๆ นี้..._

<br>

#### การเพิ่มประสิทธิภาพ Prompt

เพิ่มประสิทธิภาพ prompt ของคุณผ่านโปรแกรม โดยใช้เทคนิคที่ได้รับการพัฒนาจากงานวิจัย

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">DSPy Integration</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero มาพร้อมสูตรเพิ่มประสิทธิภาพหลายแบบ และยังสามารถสร้างสูตรของคุณเองได้ง่าย
      ตัวอย่างนี้แสดงวิธีเพิ่มประสิทธิภาพฟังก์ชัน TensorZero ด้วยเครื่องมือภายนอก เช่น DSPy ซึ่งเป็นไลบรารียอดนิยมสำหรับ automated prompt engineering
    </td>
  </tr>
</table>

_ฟีเจอร์อื่น ๆ กำลังจะมาเร็ว ๆ นี้..._

<br>

### 🔍 การสังเกตการณ์ LLM

> **ซูมเข้าเพื่อดีบั๊ก API call รายการเดียว หรือซูมออกเพื่อติดตามเมตริกของโมเดลและ prompt ตลอดเวลา — ทั้งหมดนี้ใน TensorZero UI แบบโอเพ่นซอร์ส**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Observability » Inference</b></td>
    <td width="50%" align="center" valign="middle"><b>Observability » Function</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 การประเมินผล LLM

> **เปรียบเทียบ prompt, โมเดล และกลยุทธ์ inference ด้วย TensorZero Evaluations — รองรับ heuristic และ LLM judge**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Evaluation » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Evaluation » CLI</b></td>
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

## เดโม

> **ดู LLMs พัฒนาความสามารถในการดึงข้อมูลแบบเรียลไทม์ด้วย TensorZero!**
>
> **[Dynamic in-context learning (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** เป็นการเพิ่มประสิทธิภาพขณะอนุมานที่ทรงพลัง สามารถใช้งานได้ทันทีใน TensorZero
> ช่วยเพิ่มประสิทธิภาพของ LLM โดยการนำตัวอย่างประวัติที่เกี่ยวข้องมาใส่ใน prompt โดยอัตโนมัติ โดยไม่ต้องปรับจูนโมเดลเพิ่มเติม

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## วิศวกรรม LLM ด้วย TensorZero

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

1. **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** คือ gateway สำหรับโมเดลประสิทธิภาพสูงที่เขียนด้วย Rust 🦀 ให้ API เดียวสำหรับผู้ให้บริการ LLM หลักทุกราย รองรับการผสานงานข้ามแพลตฟอร์มและ fallback อย่างไร้รอยต่อ
2. รองรับการอนุมานข้อมูลตาม schema ที่มีโครงสร้าง ด้วย latency ต่ำกว่า 1ms P99 (ดู **[Benchmarks](https://www.tensorzero.com/docs/gateway/benchmarks)**) พร้อมฟีเจอร์ observability, การทดลอง และ **[การเพิ่มประสิทธิภาพขณะอนุมาน](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)**
3. ยังสามารถเก็บ metric และ feedback จาก downstream ที่เกี่ยวข้องกับการอนุมานเหล่านี้ โดยรองรับระบบ LLM แบบหลายขั้นตอนอย่างเต็มรูปแบบ
4. ทุกอย่างถูกเก็บใน ClickHouse data warehouse ที่คุณควบคุมเอง เพื่อการวิเคราะห์แบบเรียลไทม์ ขยายขนาดได้ และเป็นมิตรกับนักพัฒนา
5. เมื่อเวลาผ่านไป **[TensorZero Recipes](https://www.tensorzero.com/docs/recipes)** จะใช้ชุดข้อมูลโครงสร้างนี้เพื่อเพิ่มประสิทธิภาพ prompt และโมเดลของคุณ: สามารถเรียกใช้ recipe ที่เตรียมไว้สำหรับ workflow ทั่วไป เช่นการ fine-tuning หรือสร้างสูตรของคุณเองด้วยภาษาและแพลตฟอร์มใดก็ได้อย่างอิสระ
6. สุดท้าย ฟีเจอร์การทดลองและ orchestration แบบ GitOps ของ gateway จะช่วยให้คุณพัฒนาและ deploy ได้อย่างมั่นใจ ไม่ว่าจะเป็น LLM เดี่ยวหรือหลายพัน LLM

เป้าหมายของเราคือช่วยให้นักพัฒนาสร้าง จัดการ และเพิ่มประสิทธิภาพแอปพลิเคชัน LLM เจเนอเรชันใหม่: ระบบที่เรียนรู้จากประสบการณ์จริง
อ่านเพิ่มเติมเกี่ยวกับ **[Vision & Roadmap](https://www.tensorzero.com/docs/vision-roadmap/)** ของเรา

## เริ่มต้นใช้งาน

**เริ่มสร้างได้วันนี้**
**[Quick Start](https://www.tensorzero.com/docs/quickstart)** แสดงให้เห็นว่าการตั้งค่าแอป LLM ด้วย TensorZero นั้นง่ายเพียงใด
ถ้าคุณต้องการเจาะลึกยิ่งขึ้น **[Tutorial](https://www.tensorzero.com/docs/gateway/tutorial)** จะสอนวิธีสร้าง chatbot อย่างง่าย, อีเมล copilot, ระบบ weather RAG และ pipeline สำหรับดึงข้อมูลแบบโครงสร้าง

**มีคำถาม?**
ถามเราได้ที่ **[Slack](https://www.tensorzero.com/slack)** หรือ **[Discord](https://www.tensorzero.com/discord)**

**ใช้ TensorZero ที่ทำงาน?**
อีเมลหาเราที่ **[hello@tensorzero.com](mailto:hello@tensorzero.com)** เพื่อขอเปิดช่อง Slack หรือ Teams ร่วมกับทีมของคุณ (ฟรี)

**ร่วมงานกับเรา**
เรากำลัง **[เปิดรับสมัครงานที่ NYC](https://www.tensorzero.com/jobs)**
และยินดีรับ **[contribution โอเพ่นซอร์ส](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)**!

## ตัวอย่าง

เรากำลังพัฒนาชุด **ตัวอย่างที่รันได้สมบูรณ์** เพื่อแสดงให้เห็น flywheel ด้านข้อมูลและการเรียนรู้ของ TensorZero

> **[การเพิ่มประสิทธิภาพการดึงข้อมูล (NER) ด้วย TensorZero](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> ตัวอย่างนี้แสดงวิธีการใช้ TensorZero เพื่อเพิ่มประสิทธิภาพ pipeline การดึงข้อมูล
> เราสาธิตเทคนิคเช่นการ fine-tuning และ dynamic in-context learning (DICL)
> สุดท้าย โมเดล GPT-4o Mini ที่ปรับแต่งแล้วจะมีประสิทธิภาพเหนือกว่า GPT-4o ในงานนี้ ด้วยค่าใช้จ่ายและ latency ที่ต่ำกว่า โดยใช้ข้อมูลฝึกเพียงเล็กน้อย

> **[Agentic RAG — Multi-Hop Question Answering ด้วย LLMs](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> ตัวอย่างนี้แสดงวิธีสร้าง agent ดึงข้อมูลแบบ multi-hop ด้วย TensorZero
> ตัว agent จะค้นหา Wikipedia แบบวนซ้ำเพื่อรวบรวมข้อมูล และตัดสินใจเมื่อมีบริบทเพียงพอที่จะตอบคำถามที่ซับซ้อน

> **[แต่งกลอนไฮกุให้ถูกใจกรรมการที่มีรสนิยมซ่อนเร้น](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> ตัวอย่างนี้ทำการ fine-tune GPT-4o Mini เพื่อสร้างกลอนไฮกุที่ตรงกับรสนิยมเฉพาะ
> คุณจะเห็น "data flywheel in a box" ของ TensorZero ทำงาน: การสร้างตัวเลือกที่ดียิ่งขึ้นนำไปสู่ข้อมูลที่ดีขึ้น และข้อมูลที่ดีขึ้นนำไปสู่ตัวเลือกที่ดียิ่งขึ้น
> คุณจะเห็นพัฒนาการโดยการ fine-tune LLM หลายรอบ

> **[ยกระดับความสามารถ LLM ในหมากรุกด้วย Best-of-N Sampling](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> ตัวอย่างนี้แสดงให้เห็นว่า best-of-N sampling สามารถเพิ่มความสามารถในการเล่นหมากรุกของ LLM ได้อย่างมาก โดยการเลือกหมากที่ดีที่สุดจากหลายตัวเลือกที่สร้างขึ้น

> **[ปรับปรุงเหตุผลทางคณิตศาสตร์ด้วยสูตร custom สำหรับ Automated Prompt Engineering (DSPy)](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero มีสูตร optimization ที่สร้างไว้ล่วงหน้าหลายสูตรสำหรับ workflow วิศวกรรม LLM ทั่วไป
> แต่คุณก็สามารถสร้างสูตรและ workflow ของคุณเองได้อย่างง่ายดาย!
> ตัวอย่างนี้แสดงวิธีเพิ่มประสิทธิภาพฟังก์ชัน TensorZero ด้วยเครื่องมือใดก็ได้ — ที่นี่ใช้ DSPy

_และอีกมากมายที่กำลังจะตามมา!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---