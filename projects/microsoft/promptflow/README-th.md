# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> ยินดีต้อนรับสู่การร่วมพัฒนา prompt flow ให้ดียิ่งขึ้นโดย
> เข้าร่วม [พูดคุย](https://github.com/microsoft/promptflow/discussions),
> เปิด [ปัญหา](https://github.com/microsoft/promptflow/issues/new/choose),
> ส่ง [PRs](https://github.com/microsoft/promptflow/pulls)

**Prompt flow** คือชุดของเครื่องมือสำหรับนักพัฒนาที่ออกแบบมาเพื่อช่วยให้งานพัฒนาแอปพลิเคชัน AI ที่ใช้ LLM ครบวงจร ตั้งแต่การคิดไอเดีย สร้างต้นแบบ ทดสอบ ประเมินผล ไปจนถึงการนำไปใช้งานจริงและมอนิเตอร์ ช่วยให้งาน prompt engineering ง่ายขึ้นมาก และสามารถสร้างแอป LLM ที่คุณภาพระดับ production ได้

ด้วย prompt flow คุณจะสามารถ:

- **สร้างและพัฒนา flow อย่างต่อเนื่อง**
    - สร้าง [flow](https://microsoft.github.io/promptflow/concepts/concept-flows.html) ที่เชื่อมต่อ LLM, prompt, โค้ด Python และ [เครื่องมืออื่นๆ](https://microsoft.github.io/promptflow/concepts/concept-tools.html) เข้าด้วยกัน
    - ดีบั๊กและปรับปรุง flow ของคุณ โดยเฉพาะ [การติดตามการทำงานร่วมกับ LLMs](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) ได้อย่างง่ายดาย
- **ประเมินคุณภาพและประสิทธิภาพของ flow**
    - ประเมินคุณภาพและประสิทธิภาพของ flow ด้วยชุดข้อมูลขนาดใหญ่
    - ผสานการทดสอบและประเมินผลเข้ากับระบบ CI/CD ของคุณ เพื่อรับประกันคุณภาพของ flow
- **วงจรการพัฒนาสำหรับ production ที่คล่องตัว**
    - นำ flow ของคุณไป deploy บนแพลตฟอร์มที่คุณเลือก หรือผสานเข้ากับโค้ดแอปของคุณได้อย่างง่ายดาย
    - (ไม่บังคับแต่แนะนำอย่างยิ่ง) ทำงานร่วมกับทีมโดยใช้ [Prompt flow ใน Azure AI](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2) เวอร์ชันคลาวด์

------

## การติดตั้ง

เริ่มต้นใช้งานได้อย่างรวดเร็วโดยใช้สภาพแวดล้อมสำหรับการพัฒนาที่เตรียมไว้แล้ว **คลิกปุ่มด้านล่าง** เพื่อเปิด repo นี้ใน GitHub Codespaces แล้วจึงอ่านต่อใน readme!

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

หากต้องการเริ่มต้นในสภาพแวดล้อม local ของคุณ ก่อนอื่นให้ติดตั้งแพ็กเกจดังนี้:

ตรวจสอบให้แน่ใจว่าคุณมีสภาพแวดล้อม python แนะนำให้ใช้ `python>=3.9, <=3.11`

```sh
pip install promptflow promptflow-tools
```

## เริ่มต้นอย่างรวดเร็ว ⚡

**สร้างแชทบอทด้วย prompt flow**

รันคำสั่งเพื่อสร้าง prompt flow จาก template แบบแชท ซึ่งจะสร้างโฟลเดอร์ชื่อ `my_chatbot` และสร้างไฟล์ที่ต้องใช้ภายในนั้น:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**ตั้งค่าการเชื่อมต่อสำหรับ API key ของคุณ**

สำหรับ OpenAI key ให้สร้างการเชื่อมต่อโดยใช้คำสั่งนี้และใช้ไฟล์ `openai.yaml` ในโฟลเดอร์ `my_chatbot` ซึ่งจะเก็บ OpenAI key ของคุณ (เปลี่ยนค่าคีย์และชื่อได้ด้วย --set เพื่อไม่ต้องแก้ไขไฟล์ yaml):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

สำหรับ Azure OpenAI key สร้างการเชื่อมต่อโดยใช้ไฟล์ `azure_openai.yaml`:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**แชทกับ flow ของคุณ**

ในโฟลเดอร์ `my_chatbot` จะมีไฟล์ `flow.dag.yaml` ที่อธิบาย flow รวมถึง inputs/outputs, nodes, การเชื่อมต่อ และ LLM model ฯลฯ

> หมายเหตุว่าใน node `chat` เราใช้การเชื่อมต่อชื่อ `open_ai_connection` (ระบุในช่อง `connection`) และใช้โมเดล `gpt-35-turbo` (ระบุในช่อง `deployment_name`) ช่อง deployment_name ใช้ระบุชื่อโมเดล OpenAI หรือชื่อ resource deployment ของ Azure OpenAI

โต้ตอบกับแชทบอทของคุณได้โดยรัน: (กด `Ctrl + C` เพื่อจบเซสชัน)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**คุณค่าหลัก: รับประกัน "คุณภาพสูง” ตั้งแต่ prototype จนถึง production**

ลองทำตาม [**บทเรียน 15 นาที**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md) ที่จะแนะนำคุณในการปรับ prompt ➡ ทดสอบ batch ➡ ประเมินผล ทั้งหมดเพื่อให้พร้อมใช้งานจริงด้วยคุณภาพสูงสุด

ขั้นตอนถัดไป! ไปต่อที่หัวข้อ **Tutorial**  👇 เพื่อเจาะลึกการใช้งาน prompt flow

## Tutorial 🏃‍♂️

Prompt flow เป็นเครื่องมือสำหรับ **สร้าง LLM app คุณภาพสูง** โดยกระบวนการพัฒนาใน prompt flow จะมีขั้นตอนดังนี้: พัฒนา flow, ปรับปรุงคุณภาพ flow, นำ flow ไปใช้งานจริง

### พัฒนา LLM app ของคุณเอง

#### ส่วนขยาย VS Code

เรายังมีส่วนขยายสำหรับ VS Code (เครื่องมือออกแบบ flow) เพื่อประสบการณ์พัฒนา flow แบบ interactive ผ่าน UI

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

สามารถติดตั้งได้จาก <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">visualstudio marketplace</a>

#### เจาะลึกการพัฒนา flow

[เริ่มต้นใช้งาน prompt flow](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): คำแนะนำทีละขั้นตอนในการรัน flow ครั้งแรกของคุณ

### เรียนรู้จากกรณีศึกษา

[บทเรียน: แชทกับ PDF](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): บทเรียนครบวงจรเกี่ยวกับวิธีสร้างแอปแชทคุณภาพสูงด้วย prompt flow รวมทั้งการพัฒนา flow และประเมินผลด้วย metrics
> ตัวอย่างเพิ่มเติมดูได้ [ที่นี่](https://microsoft.github.io/promptflow/tutorials/index.html#samples) เราขอต้อนรับทุกกรณีศึกษาใหม่ๆ!

### ตั้งค่าสำหรับผู้ร่วมพัฒนา

ถ้าคุณสนใจจะร่วมพัฒนาโปรดเริ่มต้นจากคู่มือ dev setup ของเรา: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md)

ขั้นตอนถัดไป! ไปที่หัวข้อ **Contributing**  👇 เพื่อร่วมพัฒนา prompt flow

## การร่วมพัฒนา (Contributing)

โปรเจกต์นี้ยินดีต้อนรับการร่วมพัฒนาและข้อเสนอแนะต่างๆ โดยส่วนใหญ่ของการร่วมพัฒนาคุณจะต้องตกลงใน
Contributor License Agreement (CLA) เพื่อแสดงว่าคุณมีสิทธิ์และอนุญาตให้เราใช้งานสิ่งที่คุณร่วมพัฒนา ดูรายละเอียดที่ https://cla.opensource.microsoft.com

เมื่อคุณส่ง pull request จะมี bot ตรวจสอบอัตโนมัติว่าคุณจำเป็นต้องส่ง CLA หรือไม่ และจะแจ้งเตือนใน PR (เช่น status check, comment) ให้ทำตามคำแนะนำของ bot คุณต้องทำเพียงครั้งเดียวสำหรับทุก repo ที่ใช้ CLA ของเรา

โปรเจกต์นี้ใช้ [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/)
ดูรายละเอียดเพิ่มเติมที่ [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) หรือ
ติดต่อ [opencode@microsoft.com](mailto:opencode@microsoft.com) หากมีคำถามหรือข้อเสนอแนะเพิ่มเติม

## เครื่องหมายการค้า

โปรเจกต์นี้อาจมีเครื่องหมายการค้าหรือโลโก้ของโปรเจกต์ ผลิตภัณฑ์ หรือบริการ การใช้เครื่องหมายการค้าหรือโลโก้ของ Microsoft ต้องเป็นไปตาม
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general)
ห้ามใช้เครื่องหมายการค้าหรือโลโก้ของ Microsoft ในเวอร์ชันดัดแปลงของโปรเจกต์นี้ในลักษณะที่ทำให้เกิดความสับสนหรือสื่อว่า Microsoft สนับสนุน
การใช้เครื่องหมายการค้าหรือโลโก้ของบุคคลที่สามเป็นไปตามนโยบายของเจ้าของเครื่องหมายนั้น

## จรรยาบรรณ (Code of Conduct)

โปรเจกต์นี้ใช้
[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/)
ดูข้อมูลเพิ่มเติมที่
[Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/)
หรือติดต่อ [opencode@microsoft.com](mailto:opencode@microsoft.com)
หากมีคำถามหรือข้อเสนอแนะเพิ่มเติม

## การเก็บรวบรวมข้อมูล

ซอฟต์แวร์อาจเก็บข้อมูลเกี่ยวกับคุณและการใช้งานซอฟต์แวร์ของคุณและ
ส่งข้อมูลไปยัง Microsoft หากตั้งค่าให้เปิดใช้งาน telemetry
Microsoft อาจใช้ข้อมูลนี้เพื่อให้บริการและปรับปรุงผลิตภัณฑ์และบริการของเรา
คุณสามารถเปิด telemetry ตามที่อธิบายไว้ใน repo นี้
ซอฟต์แวร์บางส่วนอาจเปิดให้คุณและ Microsoft
เก็บข้อมูลจากผู้ใช้แอปพลิเคชันของคุณ หากคุณใช้ฟีเจอร์เหล่านี้
คุณต้องปฏิบัติตามกฎหมายที่เกี่ยวข้อง รวมถึงการแจ้งให้ผู้ใช้ทราบ
พร้อมสำเนานโยบายความเป็นส่วนตัวของ Microsoft นโยบายความเป็นส่วนตัวของเราอยู่ที่
https://go.microsoft.com/fwlink/?LinkID=824704 คุณสามารถเรียนรู้เพิ่มเติมเกี่ยวกับการเก็บข้อมูล
และการใช้งานได้ในเอกสารช่วยเหลือและนโยบายความเป็นส่วนตัวของเรา การใช้ซอฟต์แวร์ถือเป็นการยินยอมในแนวปฏิบัตินี้

### การตั้งค่า Telemetry

การเก็บข้อมูล telemetry เปิดใช้งานโดยค่าเริ่มต้น

หากต้องการปิด ให้รัน `pf config set telemetry.enabled=false`

## ใบอนุญาต

สงวนลิขสิทธิ์ (c) Microsoft Corporation. All rights reserved.

อนุญาตภายใต้ [MIT](LICENSE) license

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---