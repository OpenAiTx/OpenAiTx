# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI คือ [แพลตฟอร์ม AI แบบ self-hosted ที่มีฟีเจอร์ครบถ้วน](https://docs.openwebui.com/features/plugin/), ปรับขยายได้ง่าย และใช้งานง่ายซึ่งออกแบบมาเพื่อทำงานแบบออฟไลน์โดยสมบูรณ์** รองรับ LLM runners หลากหลายประเภท เช่น **Ollama** และ **OpenAI-compatible APIs** พร้อม **Inference Engine สำหรับ RAG ในตัว** ทำให้เป็น **โซลูชันการติดตั้ง AI ที่ทรงพลัง**

![Open WebUI Demo](./demo.gif)

> [!TIP]  
> **กำลังมองหา [แพ็กเกจสำหรับองค์กร (Enterprise Plan)](https://docs.openwebui.com/enterprise) อยู่หรือไม่?** – **[ติดต่อทีมขายของเราได้เลยวันนี้!](mailto:sales@openwebui.com)**
>
> รับ **ความสามารถขั้นสูง** เช่น **ปรับแต่งธีมและแบรนด์**, **รองรับ SLA**, **เวอร์ชัน LTS** และ **อื่น ๆ อีกมากมาย!**

หากต้องการข้อมูลเพิ่มเติม อย่าลืมดู [เอกสารประกอบ Open WebUI](https://docs.openwebui.com/)

## คุณสมบัติเด่นของ Open WebUI ⭐

- 🚀 **ติดตั้งง่าย**: ติดตั้งได้อย่างราบรื่นผ่าน Docker หรือ Kubernetes (kubectl, kustomize หรือ helm) เพื่อความสะดวกสบาย รองรับทั้งภาพอิมเมจที่แท็ก `:ollama` และ `:cuda`

- 🤝 **เชื่อมต่อ API Ollama/OpenAI**: เชื่อมต่อ API ที่รองรับ OpenAI ได้อย่างง่ายดายเพื่อสนทนาได้หลากหลาย รวมทั้ง Ollama models สามารถปรับแต่ง URL ของ OpenAI API เพื่อเชื่อมต่อกับ **LMStudio, GroqCloud, Mistral, OpenRouter และอื่น ๆ**

- 🛡️ **สิทธิ์การเข้าถึงแบบละเอียดและกลุ่มผู้ใช้**: อนุญาตให้แอดมินสร้างบทบาทและสิทธิ์ผู้ใช้ได้อย่างละเอียด เพื่อให้มั่นใจว่าสภาพแวดล้อมของผู้ใช้ปลอดภัย การแบ่งสิทธิ์อย่างละเอียดนี้ไม่เพียงแต่เสริมความปลอดภัย แต่ยังสามารถปรับประสบการณ์ใช้งานให้เหมาะกับผู้ใช้แต่ละคน สร้างความรู้สึกเป็นเจ้าของและรับผิดชอบในหมู่ผู้ใช้

- 📱 **ออกแบบให้รองรับทุกอุปกรณ์**: ใช้งานได้อย่างราบรื่นทั้งคอมพิวเตอร์ตั้งโต๊ะ, แล็ปท็อป และอุปกรณ์มือถือ

- 📱 **Progressive Web App (PWA) สำหรับมือถือ**: รับประสบการณ์ที่เหมือนแอปเนทีฟบนมือถือของคุณผ่าน PWA ให้ใช้งานแบบออฟไลน์บน localhost และมีอินเทอร์เฟซที่ลื่นไหล

- ✒️🔢 **รองรับ Markdown และ LaTeX เต็มรูปแบบ**: ยกระดับประสบการณ์ LLM ของคุณด้วยความสามารถด้าน Markdown และ LaTeX อย่างครบถ้วนเพื่อการโต้ตอบที่สมบูรณ์

- 🎤📹 **สนทนาด้วยเสียง/วิดีโอแบบ hands-free**: สื่อสารได้อย่างราบรื่นด้วยฟีเจอร์เสียงและวิดีโอคอลในตัว เพื่อประสบการณ์แชทที่โต้ตอบได้มากขึ้น

- 🛠️ **Model Builder**: สร้าง Ollama models ได้ง่าย ๆ ผ่าน Web UI สร้างและเพิ่มตัวละคร/ตัวแทนของคุณเอง ปรับแต่งองค์ประกอบแชท และนำเข้าโมเดลผ่านการเชื่อมต่อกับ [Open WebUI Community](https://openwebui.com/) ได้อย่างง่ายดาย

- 🐍 **Native Python Function Calling Tool**: เพิ่มศักยภาพ LLM ด้วยตัวแก้ไขโค้ดใน workspace ของ tools เพิ่มฟังก์ชัน Python ของคุณเอง (BYOF) ได้ง่าย ๆ เพื่อให้ทำงานร่วมกับ LLM ได้อย่างไร้รอยต่อ

- 📚 **Local RAG Integration**: สัมผัสอนาคตของการสนทนาด้วยการรองรับ Retrieval Augmented Generation (RAG) ผสานเอกสารเข้ากับประสบการณ์แชทของคุณ สามารถโหลดเอกสารเข้าสู่แชทหรือเพิ่มไฟล์ลงในไลบรารีเอกสารแล้วเข้าถึงได้ง่ายด้วยคำสั่ง `#` ก่อนตั้งคำถาม

- 🔍 **ค้นหาเว็บสำหรับ RAG**: ค้นหาข้อมูลในเว็บผ่านผู้ให้บริการ เช่น `SearXNG`, `Google PSE`, `Brave Search`, `serpstack`, `serper`, `Serply`, `DuckDuckGo`, `TavilySearch`, `SearchApi` และ `Bing` แล้วนำผลลัพธ์เข้าสู่แชทของคุณโดยตรง

- 🌐 **ความสามารถในการท่องเว็บ**: ผสานเว็บไซต์เข้าสู่แชทของคุณได้อย่างง่ายดายโดยใช้คำสั่ง `#` ตามด้วย URL เพื่อดึงเนื้อหาจากเว็บมาใช้ในการสนทนา เพิ่มความสมบูรณ์และลึกซึ้งในการโต้ตอบ

- 🎨 **ผสานระบบสร้างภาพ**: เพิ่มความสามารถในการสร้างภาพผ่าน API เช่น AUTOMATIC1111 หรือ ComfyUI (local) และ DALL-E ของ OpenAI (external) เติมเต็มประสบการณ์แชทด้วยเนื้อหาภาพที่มีชีวิตชีวา

- ⚙️ **สนทนากับโมเดลหลายตัวพร้อมกัน**: สนทนากับโมเดลต่าง ๆ พร้อมกันอย่างง่ายดายเพื่อใช้จุดเด่นแต่ละโมเดล เพิ่มประสบการณ์ด้วยการใช้งานโมเดลหลากหลายชนิดในเวลาเดียวกัน

- 🔐 **Role-Based Access Control (RBAC)**: ควบคุมการเข้าถึงอย่างปลอดภัยด้วยสิทธิ์ที่จำกัด เฉพาะผู้มีสิทธิ์เท่านั้นที่เข้าถึง Ollama ได้ และสิทธิ์สร้าง/ดึงโมเดลจะสงวนไว้สำหรับแอดมินเท่านั้น

- 🌐🌍 **รองรับหลายภาษา**: ใช้งาน Open WebUI ในภาษาที่คุณต้องการด้วยระบบแปลสากล (i18n) มาร่วมขยายภาษาร่วมกับเรา! เรากำลังมองหาผู้มีส่วนร่วม!

- 🧩 **Pipelines, รองรับ Plugin ของ Open WebUI**: ผสานตรรกะและไลบรารี Python ได้อย่างยืดหยุ่นผ่าน [Pipelines Plugin Framework](https://github.com/open-webui/pipelines) เปิดใช้งาน Pipelines, ตั้งค่า OpenAI URL ไปยัง Pipelines URL และค้นหาความเป็นไปได้ไม่รู้จบ [ตัวอย่าง](https://github.com/open-webui/pipelines/tree/main/examples) เช่น **Function Calling**, **Rate Limiting** สำหรับควบคุมการเข้าถึง, **Usage Monitoring** ด้วย Langfuse, **Live Translation กับ LibreTranslate** เพื่อรองรับหลายภาษา, **กรองข้อความไม่เหมาะสม** และอื่น ๆ อีกมากมาย

- 🌟 **อัปเดตต่อเนื่อง**: เรามุ่งมั่นปรับปรุง Open WebUI ด้วยการอัปเดต แก้ไข และเพิ่มฟีเจอร์ใหม่อย่างสม่ำเสมอ

อยากรู้จักฟีเจอร์ของ Open WebUI เพิ่มเติม? ดูรายละเอียดได้ที่ [เอกสารประกอบ Open WebUI](https://docs.openwebui.com/features)

## ผู้สนับสนุน 🙌

#### Emerald

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • อินเทอร์เฟซของคุณมี backend แล้วหรือยัง?<br>ลองใช้ <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • เทอร์มินัลอัจฉริยะสำหรับนักพัฒนา
    </td>
  </tr>
</table>

---

เราขอขอบคุณผู้สนับสนุนที่มีน้ำใจอย่างยิ่ง การสนับสนุนเหล่านี้ช่วยให้เราดูแลและพัฒนาโปรเจกต์ต่อไปได้อย่างต่อเนื่อง เพื่อส่งมอบผลงานคุณภาพแก่ชุมชนของเรา ขอบคุณมาก!

## วิธีติดตั้ง 🚀

### การติดตั้งผ่าน Python pip 🐍

Open WebUI สามารถติดตั้งผ่าน pip (Python package installer) ก่อนเริ่มต้นให้แน่ใจว่าคุณใช้ **Python 3.11** เพื่อหลีกเลี่ยงปัญหาความเข้ากันได้

1. **ติดตั้ง Open WebUI**:
   เปิดเทอร์มินัลของคุณแล้วรันคำสั่งนี้เพื่อติดตั้ง Open WebUI:

   ```bash
   pip install open-webui
   ```

2. **รัน Open WebUI**:
   หลังติดตั้ง ให้เริ่ม Open WebUI โดยรันคำสั่งนี้:

   ```bash
   open-webui serve
   ```

จะเริ่มเซิร์ฟเวอร์ Open WebUI ซึ่งสามารถเข้าถึงได้ที่ [http://localhost:8080](http://localhost:8080)

### เริ่มต้นอย่างรวดเร็วด้วย Docker 🐳

> [!NOTE]  
> โปรดทราบว่าสำหรับบางสภาพแวดล้อม Docker อาจต้องตั้งค่าเพิ่มเติม หากพบปัญหาเชื่อมต่อ โปรดดูคำแนะนำโดยละเอียดใน [เอกสาร Open WebUI](https://docs.openwebui.com/)

> [!WARNING]
> เมื่อติดตั้ง Open WebUI ด้วย Docker ให้แน่ใจว่าใช้ `-v open-webui:/app/backend/data` ในคำสั่ง Docker ของคุณ ขั้นตอนนี้สำคัญมากเพื่อให้ฐานข้อมูลเชื่อมต่ออย่างถูกต้องและป้องกันการสูญหายของข้อมูล

> [!TIP]  
> หากต้องการใช้ Open WebUI พร้อม Ollama หรือเร่งความเร็วด้วย CUDA แนะนำให้ใช้ภาพอิมเมจที่มีแท็ก `:cuda` หรือ `:ollama` เพื่อเปิดใช้งาน CUDA คุณต้องติดตั้ง [Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) ในระบบ Linux/WSL ของคุณ

### ติดตั้งด้วยค่าตั้งต้น

- **หาก Ollama อยู่ในเครื่องของคุณ** ให้ใช้คำสั่งนี้:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **หาก Ollama อยู่บนเซิร์ฟเวอร์อื่น** ให้ใช้คำสั่งนี้:

  หากต้องการเชื่อมต่อกับ Ollama บนเซิร์ฟเวอร์อื่น ให้เปลี่ยน `OLLAMA_BASE_URL` เป็น URL ของเซิร์ฟเวอร์:

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **ต้องการรัน Open WebUI โดยรองรับ Nvidia GPU** ให้ใช้คำสั่งนี้:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### ติดตั้งเพื่อใช้เฉพาะ OpenAI API

- **หากคุณใช้เฉพาะ OpenAI API** ให้ใช้คำสั่งนี้:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### ติดตั้ง Open WebUI พร้อม Ollama ในตัว

วิธีนี้จะใช้ container image เดียวที่รวม Open WebUI และ Ollama ไว้ด้วยกัน สะดวกและรวดเร็ว เลือกคำสั่งที่เหมาะสมกับฮาร์ดแวร์ของคุณ:

- **สำหรับเครื่องที่มี GPU**:
  ใช้ GPU โดยรันคำสั่งนี้:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **สำหรับ CPU เท่านั้น**:
  หากไม่ได้ใช้ GPU ให้ใช้คำสั่งนี้แทน:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

ทั้งสองคำสั่งจะติดตั้ง Open WebUI และ Ollama อย่างรวดเร็วในขั้นตอนเดียว

หลังการติดตั้ง คุณสามารถเข้าถึง Open WebUI ได้ที่ [http://localhost:3000](http://localhost:3000) ขอให้สนุก! 😄

### วิธีติดตั้งอื่น ๆ

เรามีตัวเลือกการติดตั้งหลากหลาย เช่น การติดตั้ง native ที่ไม่ใช้ Docker, Docker Compose, Kustomize และ Helm ดูรายละเอียดใน [เอกสาร Open WebUI](https://docs.openwebui.com/getting-started/) หรือเข้าร่วม [ชุมชน Discord](https://discord.gg/5rJgQTnV4s) ของเรา

### การแก้ไขปัญหา

พบปัญหาเชื่อมต่อ? [เอกสารประกอบ Open WebUI](https://docs.openwebui.com/troubleshooting/) พร้อมช่วยเหลือคุณ หากต้องการความช่วยเหลือเพิ่มเติมและเข้าร่วมชุมชนที่มีชีวิตชีวา เยี่ยมชม [Open WebUI Discord](https://discord.gg/5rJgQTnV4s)

#### Open WebUI: ข้อผิดพลาดการเชื่อมต่อเซิร์ฟเวอร์

หากคุณพบปัญหาการเชื่อมต่อ มักเกิดจาก container WebUI ไม่สามารถเชื่อมต่อกับ Ollama server ที่ 127.0.0.1:11434 (host.docker.internal:11434) ภายใน container ให้ใช้ flag `--network=host` ในคำสั่ง docker ของคุณเพื่อแก้ไข โปรดสังเกตว่า port จะเปลี่ยนจาก 3000 เป็น 8080 ทำให้ลิงก์เป็น `http://localhost:8080`

**ตัวอย่างคำสั่ง Docker**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### การอัปเดต Docker ให้ทันสมัยอยู่เสมอ

หากต้องการอัปเดต Docker ของคุณเป็นเวอร์ชันล่าสุด สามารถทำได้ด้วย [Watchtower](https://containrrr.dev/watchtower/):

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

ในส่วนท้ายของคำสั่ง ให้เปลี่ยน `open-webui` เป็นชื่อ container ของคุณหากต่างกัน

ดูคู่มือการอัปเดตใน [เอกสาร Open WebUI](https://docs.openwebui.com/getting-started/updating)

### การใช้งาน Dev Branch 🌙

> [!WARNING]
> สาขา `:dev` จะมีฟีเจอร์ใหม่ ๆ ที่อาจไม่เสถียรหรือยังไม่สมบูรณ์ ใช้งานด้วยความระมัดระวัง

หากคุณต้องการทดลองใช้ฟีเจอร์ใหม่ล่าสุดและยอมรับกับความไม่เสถียร สามารถใช้ tag `:dev` ดังนี้:

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### โหมดออฟไลน์

หากคุณใช้งาน Open WebUI ในสภาพแวดล้อมออฟไลน์ สามารถตั้งค่าตัวแปรสภาพแวดล้อม `HF_HUB_OFFLINE` เป็น `1` เพื่อป้องกันการดาวน์โหลดโมเดลจากอินเทอร์เน็ต

```bash
export HF_HUB_OFFLINE=1
```

## อะไรต่อไป? 🌟

ค้นหาฟีเจอร์ที่จะมาในอนาคตใน [แผนงานของ Open WebUI](https://docs.openwebui.com/roadmap/)

## ใบอนุญาต 📜

โปรเจกต์นี้ใช้สัญญาอนุญาตแบบ [Open WebUI License](LICENSE) ซึ่งเป็น BSD-3-Clause ที่ปรับปรุงใหม่ คุณจะได้รับสิทธิ์เช่นเดียวกับ BSD-3 แบบคลาสสิก: ใช้, แก้ไข, แจกจ่ายซอฟต์แวร์ รวมถึงในผลิตภัณฑ์เชิงพาณิชย์ โดยมีข้อจำกัดน้อยมาก ข้อกำหนดเพิ่มเติมคือ ต้องรักษาเครื่องหมายการค้า "Open WebUI" ตามที่ระบุในไฟล์ LICENSE ดูรายละเอียดฉบับเต็มใน [LICENSE](LICENSE) 📄

## การสนับสนุน 💬

หากคุณมีคำถาม ข้อเสนอแนะ หรือขอความช่วยเหลือ โปรดเปิด issue หรือเข้าร่วม
[ชุมชน Discord ของ Open WebUI](https://discord.gg/5rJgQTnV4s) เพื่อพูดคุยกับเรา! 🤝

## ประวัติดาว

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

สร้างโดย [Timothy Jaeryang Baek](https://github.com/tjbck) - มาร่วมกันทำให้ Open WebUI ยอดเยี่ยมยิ่งขึ้น! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---