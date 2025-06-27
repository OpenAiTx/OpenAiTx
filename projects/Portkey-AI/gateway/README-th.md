<p align="right">
   <strong>ภาษาอังกฤษ</strong> | <a href="./.github/README.cn.md">中文</a> | <a href="./.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### เชื่อมต่อกับ LLM กว่า 250+ ตัว ด้วย API เดียวที่รวดเร็วและใช้งานง่าย

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Portkey AI Gateway Demo showing LLM routing capabilities" style="margin-left:-35px">

[เอกสาร](https://portkey.wiki/gh-1) | [องค์กร](https://portkey.wiki/gh-2) | [Hosted Gateway](https://portkey.wiki/gh-3) | [Changelog](https://portkey.wiki/gh-4) | [API Reference](https://portkey.wiki/gh-5)


[![License](https://img.shields.io/github/license/Ileriayo/markdown-badges)](./LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

[**AI Gateway**](https://portkey.wiki/gh-10) ถูกออกแบบมาเพื่อการเชื่อมต่อที่รวดเร็ว เชื่อถือได้ และปลอดภัย ไปยังโมเดลภาษา, วิชั่น, ออดิโอ และอิมเมจมากกว่า 1600+ ตัว เป็นโซลูชันน้ำหนักเบา โอเพ่นซอร์ส และพร้อมใช้งานระดับองค์กร ช่วยให้คุณเชื่อมต่อกับโมเดลภาษาใด ๆ ได้ภายในเวลาไม่ถึง 2 นาที

- [x] **เร็วมาก** (latency <1ms) ด้วยขนาดไฟล์เล็กมาก (122kb)
- [x] **ผ่านการทดสอบสมบุกสมบัน** ประมวลผลโทเค็นกว่า 10 พันล้านต่อวัน
- [x] **พร้อมใช้งานระดับองค์กร** ด้วยความปลอดภัยที่เหนือกว่า รองรับการขยาย และการดีพลอยแบบกำหนดเอง

<br>

#### คุณสามารถทำอะไรกับ AI Gateway ได้บ้าง?
- เชื่อมต่อกับ LLM ใดก็ได้ในเวลาไม่ถึง 2 นาที - [เริ่มต้นใช้งานด่วน](#quickstart-2-mins)
- ป้องกันระบบล่มด้วย **[การลองใหม่อัตโนมัติ](https://portkey.wiki/gh-11)** และ **[Fallback](https://portkey.wiki/gh-12)**
- ขยายแอป AI ด้วย **[โหลดบาลานซ์](https://portkey.wiki/gh-13)** และ **[การกำหนดเส้นทางตามเงื่อนไข](https://portkey.wiki/gh-14)**
- ปกป้องการดีพลอย AI ด้วย **[Guardrails](https://portkey.wiki/gh-15)**
- ไปให้ไกลกว่าข้อความด้วย **[ความสามารถมัลติโหมด](https://portkey.wiki/gh-16)**
- และสำรวจการเชื่อมต่อ **[Agentic workflow](https://portkey.wiki/gh-17)**

<br><br>

> [!TIP]
> การกดดาวให้ repo นี้ช่วยให้นักพัฒนาคนอื่นค้นพบ AI Gateway ได้มากขึ้น 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## เริ่มต้นอย่างรวดเร็ว (2 นาที)

### 1. ติดตั้ง AI Gateway ของคุณ

```bash
# รัน gateway บนเครื่อง (ต้องการ Node.js และ npm)
npx @portkey-ai/gateway
```
> Gateway จะรันที่ `http://localhost:8787/v1`
> 
> Gateway Console จะรันที่ `http://localhost:8787/public/`

<sup>
คู่มือดีพลอย:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (แนะนำ)</a>
&nbsp; <a href="./docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="./docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="./docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="./docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="./docs/installation-deployments.md"> อื่น ๆ...</a>

</sup>

### 2. ส่งคำขอแรกของคุณ

<!-- <details open>
<summary>Python Example</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# ไคลเอนต์ที่ใช้งานร่วมกับ OpenAI
client = Portkey(
    provider="openai", # หรือ 'anthropic', 'bedrock', 'groq', ฯลฯ
    Authorization="sk-***" # API key ของผู้ให้บริการ
)

# ส่งคำขอผ่าน AI Gateway ของคุณ
client.chat.completions.create(
    messages=[{"role": "user", "content": "สภาพอากาศเป็นอย่างไร?"}],
    model="gpt-4o-mini"
)
```



<sup>ไลบรารีที่รองรับ:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [เพิ่มเติม..](https://portkey.wiki/gh-26)
</sup>

บน Gateway Console (`http://localhost:8787/public/`) คุณสามารถดู log ทั้งหมดของคุณได้ในที่เดียว

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. Routing & Guardrails
`Configs` ใน LLM gateway ช่วยให้คุณสร้างกฎการกำหนดเส้นทาง เพิ่มความน่าเชื่อถือ และตั้งค่า guardrail ได้
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# แนบ config กับ client
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "ตอบแบบสุ่มโดยใช้ Apple หรือ Bat"}]
)

# คำตอบจะเป็น "Bat" เสมอ เพราะ guardrail จะปฏิเสธทุกคำตอบที่มี "Apple" การตั้งค่า retry จะพยายามใหม่ 5 ครั้งก่อนจะยอมแพ้
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Request flow through Portkey's AI gateway with retries and guardrails" alt="Request flow through Portkey's AI gateway with retries and guardrails"/>
</div>

คุณสามารถทำอะไรได้อีกมากมายกับ config ใน AI gateway ของคุณ [ดูตัวอย่างเพิ่มเติม →](https://portkey.wiki/gh-27)

<br/>

### เวอร์ชันองค์กร (ดีพลอยแบบส่วนตัว)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

[เวอร์ชันองค์กร](https://portkey.wiki/gh-86) ของ LLM Gateway มีความสามารถขั้นสูงสำหรับ **การบริหารจัดการองค์กร**, **การกำกับดูแล**, **ความปลอดภัย** และ [อื่น ๆ](https://portkey.wiki/gh-87) พร้อมใช้งานทันที [ดูเปรียบเทียบฟีเจอร์ →](https://portkey.wiki/gh-32)

สถาปัตยกรรมการดีพลอยสำหรับแพลตฟอร์มที่รองรับ ดูได้ที่นี่ - [**Enterprise Private Cloud Deployments**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Book an enterprise AI gateway demo" /></a><br/>


<br>

<hr>

### AI Engineering Hours

เข้าร่วม community call ทุกวันศุกร์ (8 โมงเช้า PT) เพื่อเริ่มต้นใช้งาน AI Gateway ของคุณ! [มีทุกวันศุกร์](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

บันทึกการประชุม [เผยแพร่ที่นี่](https://portkey.wiki/gh-36).


<hr>

### LLMs in Prod'25

ข้อมูลเชิงลึกจากการวิเคราะห์โทเค็นมากกว่า 2 ล้านล้านโทเค็น ใน 90+ ภูมิภาค และ 650+ ทีมในระบบจริง รายงานนี้ประกอบด้วย:
- เทรนด์ที่ขับเคลื่อนการนำ AI และผู้ให้บริการ LLM
- Benchmarks เพื่อปรับแต่งความเร็ว ต้นทุน และความน่าเชื่อถือ
- กลยุทธ์เพื่อขยายระบบ AI ระดับโปรดักชัน

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**รับรายงานนี้**</a>
<hr>


## ฟีเจอร์หลัก
### การกำหนดเส้นทางที่เชื่อถือได้
- <a href="https://portkey.wiki/gh-37">**Fallbacks**</a>: สำรองไปยังผู้ให้บริการหรือโมเดลอื่นเมื่อคำขอผ่าน LLM gateway ล้มเหลว คุณสามารถระบุข้อผิดพลาดที่ต้องการให้เกิด fallback ได้ ช่วยเพิ่มความน่าเชื่อถือของแอปพลิเคชันของคุณ
- <a href="https://portkey.wiki/gh-38">**Automatic Retries**</a>: ทำการลองส่งคำขอใหม่โดยอัตโนมัติสูงสุด 5 ครั้ง กลยุทธ์ backoff แบบเอ็กซ์โพเนนเชียลจะเว้นระยะการลองใหม่เพื่อป้องกันความหนาแน่นของเครือข่าย
- <a href="https://portkey.wiki/gh-39">**Load Balancing**</a>: กระจายคำขอ LLM ไปยังหลาย API key หรือผู้ให้บริการ AI พร้อมน้ำหนัก เพื่อให้มั่นใจถึงความพร้อมใช้งานสูงและประสิทธิภาพที่เหมาะสม
- <a href="https://portkey.wiki/gh-40">**Request Timeouts**</a>: จัดการ LLM และความหน่วงช้าโดยกำหนด request timeout อย่างละเอียด อนุญาตให้ระบบยกเลิกคำขออัตโนมัติเมื่อเกินระยะเวลาที่กำหนด
- <a href="https://portkey.wiki/gh-41">**Multi-modal LLM Gateway**</a>: เรียกใช้งานโมเดล vision, audio (text-to-speech & speech-to-text) และ image generation จากผู้ให้บริการหลายราย — ทั้งหมดผ่าน signature แบบเดียวกับ OpenAI ที่คุ้นเคย
- <a href="https://portkey.wiki/gh-42">**Realtime APIs**</a>: เรียกใช้งาน realtime API ที่เปิดตัวโดย OpenAI ผ่านเซิร์ฟเวอร์ websocket ที่เชื่อมต่อ

### ความปลอดภัย & ความถูกต้อง
- <a href="https://portkey.wiki/gh-88">**Guardrails**</a>: ตรวจสอบอินพุตและเอาต์พุตของ LLM ให้เป็นไปตามข้อกำหนดของคุณ เลือกจาก guardrails ที่สร้างไว้ล่วงหน้ากว่า 40 รายการ เพื่อให้มั่นใจว่าสอดคล้องกับมาตรฐานความปลอดภัยและความถูกต้อง คุณสามารถ <a href="https://portkey.wiki/gh-43">นำ guardrails ของคุณเองมาใช้</a> หรือเลือกจาก <a href="https://portkey.wiki/gh-44">พาร์ทเนอร์ของเรา</a>
- [**การจัดการคีย์อย่างปลอดภัย**](https://portkey.wiki/gh-45): ใช้คีย์ของคุณเองหรือสร้าง virtual key ได้ตามต้องการ
- [**การควบคุมการเข้าถึงตามบทบาท**](https://portkey.wiki/gh-46): ควบคุมการเข้าถึงอย่างละเอียดสำหรับผู้ใช้, เวิร์กสเปซ และ API key ของคุณ
- <a href="https://portkey.wiki/gh-47">**การปฏิบัติตามข้อกำหนด & ความเป็นส่วนตัวของข้อมูล**</a>: AI Gateway รองรับมาตรฐาน SOC2, HIPAA, GDPR และ CCPA

### การจัดการต้นทุน
- [**Smart caching**](https://portkey.wiki/gh-48): แคชผลลัพธ์จาก LLM เพื่อลดต้นทุนและปรับปรุง latency รองรับทั้งการแคชแบบ simple และ semantic*
- [**การวิเคราะห์การใช้งาน**](https://portkey.wiki/gh-49): ติดตามและวิเคราะห์การใช้งาน AI และ LLM ของคุณ รวมถึงปริมาณคำขอ, latency, ต้นทุน และอัตราข้อผิดพลาด
- [**Provider optimization***](https://portkey.wiki/gh-89): เปลี่ยนไปใช้ผู้ให้บริการที่มีต้นทุนคุ้มค่าที่สุดโดยอัตโนมัติตามรูปแบบการใช้งานและโมเดลราคา

### การทำงานร่วมกัน & เวิร์กโฟลว์
- <a href="https://portkey.ai/docs/integrations/agents">**รองรับ Agents**</a>: เชื่อมต่อกับเฟรมเวิร์ก agent ยอดนิยมอย่างไร้รอยต่อ เพื่อสร้างแอปพลิเคชัน AI ที่ซับซ้อน Gateway สามารถเชื่อมต่อกับ [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55) และ [Custom Agents](https://portkey.wiki/gh-56) ได้อย่างสมบูรณ์
- [**การจัดการ Prompt Template***](https://portkey.wiki/gh-57): สร้าง, จัดการ และเวอร์ชัน prompt template ของคุณร่วมกันผ่าน prompt playground แบบสากล
<br/><br/>

<sup>
*&nbsp;มีในเวอร์ชัน hosted และ enterprise
</sup>

<br>

## Cookbooks

### ☄️ กำลังมาแรง
- ใช้งานโมเดลจาก [Nvidia NIM](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/providers/nvidia.ipynb) กับ AI Gateway
- มอนิเตอร์ [CrewAI Agents](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) ด้วย Portkey!
- เปรียบเทียบ [Top 10 LMSYS Models](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) กับ AI Gateway

### 🚨 ล่าสุด
* [สร้าง Synthetic Datasets ด้วย Nemotron](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [ใช้งาน LLM Gateway กับ Vercel's AI SDK](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/integrations/vercel-ai.md)
* [มอนิเตอร์ Llama Agents ด้วย LLM Gateway ของ Portkey](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[ดู cookbooks ทั้งหมด →](https://portkey.wiki/gh-58)
<br/><br/>

## ผู้ให้บริการที่รองรับ

สำรวจการเชื่อมต่อ Gateway กับ [ผู้ให้บริการมากกว่า 45 ราย](https://portkey.wiki/gh-59) และ [เฟรมเวิร์ก agent มากกว่า 8 ราย](https://portkey.wiki/gh-90)

|                                                                                                                            | ผู้ให้บริการ                                                                                   | รองรับ   | Stream |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | ------- | ------ |
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


> [ดูรายชื่อโมเดลที่รองรับกว่า 200+ รายการที่นี่](https://portkey.wiki/gh-74)
<br>

<br>

## Agents
Gateway เชื่อมต่อกับเฟรมเวิร์ก agent ยอดนิยมได้อย่างไร้รอยต่อ [อ่านเอกสารที่นี่](https://portkey.wiki/gh-75)

| Framework | เรียกใช้ LLMs กว่า 200 รายการ | Routing ขั้นสูง | Caching | Logging & Tracing* | Observability* | การจัดการ Prompt* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Build Your Own Agents](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*มีใน [hosted app](https://portkey.wiki/gh-76) สำหรับเอกสารฉบับเต็ม [คลิกที่นี่](https://portkey.wiki/gh-100)

## Gateway Enterprise Version
ทำให้แอป AI ของคุณ <ins>น่าเชื่อถือ</ins> และ <ins>รองรับอนาคต</ins> พร้อมทั้งรับรอง <ins>ความปลอดภัยของข้อมูล</ins> และ <ins>ความเป็นส่วนตัว</ins> อย่างครบถ้วน

✅&nbsp; การจัดการคีย์อย่างปลอดภัย - สำหรับการควบคุมการเข้าถึงตามบทบาทและการติดตาม <br>
✅&nbsp; Simple & Semantic Caching - ตอบคำถามซ้ำเร็วขึ้นและลดค่าใช้จ่าย <br>
✅&nbsp; Access Control & Inbound Rules - ควบคุมว่า IP และ Geo ใดเชื่อมต่อกับระบบของคุณได้ <br>
✅&nbsp; การลบข้อมูล PII - ลบข้อมูลอ่อนไหวออกจาก request อัตโนมัติเพื่อป้องกันการรั่วไหล <br>
✅&nbsp; รองรับมาตรฐาน SOC2, ISO, HIPAA, GDPR - เพื่อแนวทางปฏิบัติด้านความปลอดภัยที่ดีที่สุด <br>
✅&nbsp; การสนับสนุนระดับมืออาชีพ - พร้อมการจัดลำดับความสำคัญของฟีเจอร์ <br>

[นัดพูดคุยสำหรับการใช้งานระดับองค์กร](https://portkey.sh/demo-13)

<br>

## การมีส่วนร่วม

วิธีง่ายที่สุดในการมีส่วนร่วมคือเลือก issue ที่ติดแท็ก `good first issue` 💪 อ่านแนวทางการมีส่วนร่วม [ที่นี่](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/CONTRIBUTING.md)

แจ้งบั๊ก? [แจ้งที่นี่](https://portkey.wiki/gh-78) | ขอฟีเจอร์? [แจ้งที่นี่](https://portkey.wiki/gh-78)

### เริ่มต้นกับชุมชน
เข้าร่วม AI Engineering Hours ทุกวันศุกร์ (8 โมงเช้า PT) เพื่อ:
- พบปะผู้ร่วมพัฒนาและสมาชิกในชุมชน
- เรียนรู้ฟีเจอร์ Gateway ขั้นสูงและรูปแบบการใช้งาน
- แลกเปลี่ยนประสบการณ์และขอความช่วยเหลือ
- อัปเดตเรื่องสำคัญล่าสุดในการพัฒนา

[เข้าร่วม session ถัดไป →](https://portkey.wiki/gh-101) | [บันทึกการประชุม](https://portkey.wiki/gh-102)

<br>

## ชุมชน

เข้าร่วมชุมชนที่เติบโตของเราทั่วโลก เพื่อขอความช่วยเหลือ ไอเดีย และพูดคุยเกี่ยวกับ AI

- ดู [บล็อก](https://portkey.wiki/gh-78) อย่างเป็นทางการของเรา
- แชทกับเราบน [Discord](https://portkey.wiki/community)
- ติดตามเราบน [Twitter](https://portkey.wiki/gh-79)
- เชื่อมต่อกับเราบน [LinkedIn](https://portkey.wiki/gh-80)
- อ่านเอกสารฉบับภาษาญี่ปุ่นได้ที่ [ที่นี่](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md)
- เยี่ยมชมเราได้ที่ [YouTube](https://portkey.wiki/gh-103)
- เข้าร่วม [Dev community](https://portkey.wiki/gh-82)
<!-- - คำถามติดแท็ก #portkey บน [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---