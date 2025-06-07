![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">แนะนำ Dify Workflow File Upload: สร้าง Google NotebookLM Podcast ขึ้นมาใหม่</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify Cloud</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">การติดตั้งด้วยตนเอง</a> ·
  <a href="https://docs.dify.ai">เอกสารประกอบ</a> ·
  <a href="https://dify.ai/pricing">ภาพรวมรุ่น Dify</a>
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

Dify คือแพลตฟอร์มโอเพ่นซอร์สสำหรับการพัฒนาแอป LLM อินเทอร์เฟซที่ใช้งานง่ายรวมเอา workflow AI แบบตัวแทน, RAG pipeline, ความสามารถของ agent, การจัดการโมเดล, ฟีเจอร์สำหรับการสังเกตการณ์ และอื่นๆ อีกมากมาย ช่วยให้คุณสามารถเปลี่ยนจากต้นแบบสู่การใช้งานจริงได้อย่างรวดเร็ว

## เริ่มต้นใช้งานอย่างรวดเร็ว

> ก่อนติดตั้ง Dify โปรดตรวจสอบว่าเครื่องของคุณตรงตามข้อกำหนดขั้นต่ำดังต่อไปนี้:
>
> - CPU >= 2 Core
> - RAM >= 4 GiB

</br>

วิธีที่ง่ายที่สุดในการเริ่มเซิร์ฟเวอร์ Dify คือผ่าน [docker compose](docker/docker-compose.yaml) ก่อนรัน Dify ด้วยคำสั่งต่อไปนี้ กรุณาตรวจสอบว่าได้ติดตั้ง [Docker](https://docs.docker.com/get-docker/) และ [Docker Compose](https://docs.docker.com/compose/install/) ในเครื่องของคุณแล้ว:

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

หลังจากรันแล้ว คุณสามารถเข้าถึงแดชบอร์ด Dify ผ่านเบราว์เซอร์ได้ที่ [http://localhost/install](http://localhost/install) และเริ่มกระบวนการตั้งค่าเริ่มต้น

#### ขอความช่วยเหลือ

โปรดดูที่ [FAQ](https://docs.dify.ai/getting-started/install-self-hosted/faqs) หากคุณพบปัญหาในการตั้งค่า Dify หากยังคงมีปัญหา กรุณาติดต่อ [ชุมชนและเรา](#community--contact)

> หากคุณต้องการมีส่วนร่วมใน Dify หรือพัฒนาต่อเพิ่มเติม โปรดดูที่ [คู่มือการดีพลอยจากซอร์สโค้ด](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code)

## ฟีเจอร์หลัก

**1. Workflow**:
สร้างและทดสอบ workflow AI อันทรงพลังบนผืนผ้าใบแบบ visual พร้อมใช้ฟีเจอร์ต่างๆ เหล่านี้และอื่นๆ

**2. รองรับโมเดลอย่างครอบคลุม**:
เชื่อมต่อกับ LLM ทั้งแบบ proprietary และโอเพ่นซอร์สได้อย่างไร้รอยต่อจากผู้ให้บริการอินเฟอเรนซ์หลากหลายรายและโซลูชัน self-hosted ครอบคลุม GPT, Mistral, Llama3 และโมเดลใดๆ ที่รองรับ OpenAI API สามารถดูรายชื่อผู้ให้บริการโมเดลที่รองรับทั้งหมดได้ [ที่นี่](https://docs.dify.ai/getting-started/readme/model-providers)

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. Prompt IDE**:
อินเทอร์เฟซที่ใช้งานง่ายสำหรับสร้าง prompt, เปรียบเทียบประสิทธิภาพโมเดล และเพิ่มฟีเจอร์เพิ่มเติม เช่น text-to-speech ให้กับแอปแชท

**4. RAG Pipeline**:
ความสามารถ RAG อย่างครบถ้วน ตั้งแต่ ingestion เอกสารจนถึง retrieval พร้อมรองรับการดึงข้อความจาก PDF, PPT และรูปแบบเอกสารทั่วไปโดยอัตโนมัติ

**5. ความสามารถของ Agent**:
คุณสามารถกำหนด agent โดยอิงจาก LLM Function Calling หรือ ReAct และเพิ่มเครื่องมือที่สร้างไว้ล่วงหน้าหรือแบบกำหนดเอง Dify มีเครื่องมือในตัวกว่า 50 รายการสำหรับ AI agent เช่น Google Search, DALL·E, Stable Diffusion และ WolframAlpha

**6. LLMOps**:
ติดตามและวิเคราะห์ log ของแอปพลิเคชันและประสิทธิภาพตามช่วงเวลา ปรับปรุง prompt, dataset และโมเดลอย่างต่อเนื่องโดยอิงข้อมูลและ annotation จากการใช้งานจริง

**7. Backend-as-a-Service**:
ทุกฟีเจอร์ของ Dify มาพร้อมกับ API ที่เกี่ยวข้อง ให้คุณผนวก Dify เข้ากับตรรกะธุรกิจของคุณได้อย่างง่ายดาย

## การเปรียบเทียบฟีเจอร์

<table style="width: 100%;">
  <tr>
    <th align="center">ฟีเจอร์</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">แนวทางการพัฒนา</td>
    <td align="center">API + เน้นแอป</td>
    <td align="center">Python Code</td>
    <td align="center">เน้นแอป</td>
    <td align="center">เน้น API</td>
  </tr>
  <tr>
    <td align="center">LLM ที่รองรับ</td>
    <td align="center">หลากหลาย</td>
    <td align="center">หลากหลาย</td>
    <td align="center">หลากหลาย</td>
    <td align="center">เฉพาะ OpenAI</td>
  </tr>
  <tr>
    <td align="center">RAG Engine</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Agent</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Workflow</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">การสังเกตการณ์</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">ฟีเจอร์ระดับองค์กร (SSO/ควบคุมการเข้าถึง)</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">ติดตั้งในเครื่อง (Local)</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## การใช้งาน Dify

- **Cloud </br>**
  เราให้บริการ [Dify Cloud](https://dify.ai) สำหรับทุกคนได้ทดลองใช้งานโดยไม่ต้องตั้งค่าใดๆ มีฟีเจอร์ครบเท่ากับรุ่นที่ติดตั้งด้วยตนเอง และมี GPT-4 ฟรี 200 ครั้งในแผน sandbox

- **ติดตั้ง Dify Community Edition ด้วยตนเอง</br>**
  ติดตั้ง Dify ในสภาพแวดล้อมของคุณได้อย่างรวดเร็วด้วย [คู่มือเริ่มต้นนี้](#quick-start)
  ดู [เอกสารประกอบ](https://docs.dify.ai) สำหรับข้อมูลเพิ่มเติมและคำแนะนำเชิงลึก

- **Dify สำหรับองค์กร/บริษัท</br>**
  เรามีฟีเจอร์เพิ่มเติมสำหรับองค์กร [ส่งคำถามถึงเราผ่าน chatbot นี้](https://udify.app/chat/22L1zSxg6yW1cWQg) หรือ [ส่งอีเมลหาเรา](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry) เพื่อพูดคุยความต้องการขององค์กร </br>
  > สำหรับสตาร์ทอัพและธุรกิจขนาดเล็กที่ใช้ AWS ดู [Dify Premium ใน AWS Marketplace](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6) และดีพลอยลง AWS VPC ของคุณได้ในคลิกเดียว เป็น AMI ราคาไม่แพงพร้อมตัวเลือกสร้างแอปที่มีโลโก้และแบรนด์ของคุณเอง

## ก้าวล้ำอยู่เสมอ

กดดาว Dify บน GitHub เพื่อรับการแจ้งเตือนทันทีเมื่อมีเวอร์ชันใหม่

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## การตั้งค่าขั้นสูง

หากคุณต้องการปรับแต่งการตั้งค่า กรุณาดูคอมเมนต์ในไฟล์ [.env.example](docker/.env.example) และอัปเดตค่าที่เกี่ยวข้องในไฟล์ `.env` ของคุณ อาจต้องปรับ `docker-compose.yaml` เช่น เปลี่ยนเวอร์ชัน image, การแมปพอร์ต หรือ volume mount ตามสภาพแวดล้อมและความต้องการ หลังแก้ไขแล้วให้รัน `docker-compose up -d` อีกครั้ง สามารถดูรายการ environment variable ทั้งหมดได้ [ที่นี่](https://docs.dify.ai/getting-started/install-self-hosted/environments)

หากต้องการตั้งค่าระบบที่มีความพร้อมใช้งานสูง มี [Helm Charts](https://helm.sh/) และไฟล์ YAML ที่ชุมชนสร้างไว้ให้ Dify รันบน Kubernetes ได้

- [Helm Chart โดย @LeoQuote](https://github.com/douban/charts/tree/master/charts/dify)
- [Helm Chart โดย @BorisPolonsky](https://github.com/BorisPolonsky/dify-helm)
- [Helm Chart โดย @magicsong](https://github.com/magicsong/ai-charts)
- [YAML file โดย @Winson-030](https://github.com/Winson-030/dify-kubernetes)
- [YAML file โดย @wyy-holding](https://github.com/wyy-holding/dify-k8s)

#### การดีพลอยด้วย Terraform

ดีพลอย Dify สู่ Cloud Platform ได้ในคลิกเดียวด้วย [terraform](https://www.terraform.io/)

##### Azure Global

- [Azure Terraform โดย @nikawang](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [Google Cloud Terraform โดย @sotazum](https://github.com/DeNA/dify-google-cloud-terraform)

#### การดีพลอยด้วย AWS CDK

ดีพลอย Dify สู่ AWS ด้วย [CDK](https://aws.amazon.com/cdk/)

##### AWS

- [AWS CDK โดย @KevinZhao](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## การมีส่วนร่วม

สำหรับผู้ที่ต้องการร่วมพัฒนาโค้ด ดู [คู่มือการมีส่วนร่วม](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md)
และช่วยกันสนับสนุน Dify ด้วยการแชร์บนโซเชียลมีเดีย งานอีเวนต์ และงานสัมมนาต่างๆ

> เรากำลังมองหาผู้ช่วยแปล Dify เป็นภาษาต่างๆ นอกเหนือจากจีนกลางและอังกฤษ หากคุณสนใจ กรุณาดู [i18n README](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) และฝากข้อความไว้ที่ช่อง `global-users` ใน [Discord Community Server](https://discord.gg/8Tpq4AcN9c) ของเรา

## ชุมชน & ติดต่อ

- [GitHub Discussion](https://github.com/langgenius/dify/discussions) เหมาะสำหรับ: แชร์ข้อเสนอแนะและสอบถาม
- [GitHub Issues](https://github.com/langgenius/dify/issues) เหมาะสำหรับ: แจ้งบั๊กการใช้งาน Dify.AI และเสนอฟีเจอร์ ดู [คู่มือการมีส่วนร่วม](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md)
- [Discord](https://discord.gg/FngNHpbcY7) เหมาะสำหรับ: แชร์แอปพลิเคชันของคุณและพูดคุยกับชุมชน
- [X(Twitter)](https://twitter.com/dify_ai) เหมาะสำหรับ: แชร์แอปพลิเคชันของคุณและพูดคุยกับชุมชน

**ผู้ร่วมพัฒนา**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## ประวัติดาว

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## การเปิดเผยด้านความปลอดภัย

เพื่อปกป้องความเป็นส่วนตัวของคุณ กรุณาอย่าโพสต์ประเด็นด้านความปลอดภัยบน GitHub ให้ส่งคำถามไปที่ security@dify.ai แล้วเราจะให้คำตอบอย่างละเอียดแก่คุณ

## ใบอนุญาต

คลังนี้อยู่ภายใต้ [Dify Open Source License](LICENSE) ซึ่งโดยพื้นฐานแล้วคือ Apache 2.0 พร้อมข้อจำกัดเพิ่มเติมบางประการ

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---