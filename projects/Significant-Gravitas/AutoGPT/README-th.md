# AutoGPT: สร้าง, ติดตั้ง และรัน AI Agents

[![Discord Follow](https://dcbadge.vercel.app/api/server/autogpt?style=flat)](https://discord.gg/autogpt) &ensp;
[![Twitter Follow](https://img.shields.io/twitter/follow/Auto_GPT?style=social)](https://twitter.com/Auto_GPT) &ensp;
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**AutoGPT** คือแพลตฟอร์มอันทรงพลังที่ช่วยให้คุณสามารถสร้าง, ติดตั้ง และจัดการ AI agents ที่ทำงานอัตโนมัติสำหรับเวิร์กโฟลว์ที่ซับซ้อนได้

## ตัวเลือกการโฮสต์
   - ดาวน์โหลดเพื่อติดตั้งเอง (self-host)
   - [เข้าร่วมรายชื่อรอ](https://bit.ly/3ZDijAI) สำหรับรุ่นเบต้าบนคลาวด์

## วิธีตั้งค่าสำหรับ Self-Hosting
> [!NOTE]
> การติดตั้งและโฮสต์ AutoGPT Platform ด้วยตัวเองเป็นกระบวนการทางเทคนิค
> หากคุณต้องการสิ่งที่ใช้งานได้ทันที ขอแนะนำให้ [เข้าร่วมรายชื่อรอ](https://bit.ly/3ZDijAI) สำหรับรุ่นเบต้าบนคลาวด์

### ข้อกำหนดของระบบ

ก่อนดำเนินการติดตั้ง กรุณาตรวจสอบให้แน่ใจว่าระบบของคุณมีคุณสมบัติดังต่อไปนี้:

#### ข้อกำหนดฮาร์ดแวร์
- CPU: แนะนำ 4 คอร์ขึ้นไป
- RAM: ขั้นต่ำ 8GB, แนะนำ 16GB
- พื้นที่เก็บข้อมูล: อย่างน้อย 10GB

#### ข้อกำหนดซอฟต์แวร์
- ระบบปฏิบัติการ:
  - Linux (แนะนำ Ubuntu 20.04 หรือใหม่กว่า)
  - macOS (10.15 หรือใหม่กว่า)
  - Windows 10/11 พร้อม WSL2
- ซอฟต์แวร์ที่จำเป็น (เวอร์ชั่นขั้นต่ำ):
  - Docker Engine (20.10.0 หรือใหม่กว่า)
  - Docker Compose (2.0.0 หรือใหม่กว่า)
  - Git (2.30 หรือใหม่กว่า)
  - Node.js (16.x หรือใหม่กว่า)
  - npm (8.x หรือใหม่กว่า)
  - VSCode (1.60 หรือใหม่กว่า) หรือโปรแกรมแก้ไขโค้ดสมัยใหม่ใดก็ได้

#### ข้อกำหนดเครือข่าย
- อินเทอร์เน็ตที่เสถียร
- เข้าถึงพอร์ตที่ต้องการ (จะตั้งค่าใน Docker)
- สามารถเชื่อมต่อออกภายนอกแบบ HTTPS ได้

### คำแนะนำการติดตั้งที่อัปเดต
เราได้ย้ายไปยังเว็บไซต์เอกสารที่ได้รับการดูแลและอัปเดตอย่างสม่ำเสมอ

👉 [ทำตามคู่มือการโฮสต์ด้วยตนเองอย่างเป็นทางการที่นี่](https://docs.agpt.co/platform/getting-started/)

คู่มือนี้สมมติว่าคุณมี Docker, VSCode, git และ npm ติดตั้งเรียบร้อยแล้ว

### 🧱 AutoGPT Frontend

AutoGPT frontend คือจุดที่ผู้ใช้โต้ตอบกับแพลตฟอร์ม AI automation อันทรงพลังของเรา โดยมีหลายวิธีในการใช้งานและเพิ่มศักยภาพของ AI agents นี่คืออินเตอร์เฟซที่คุณจะนำไอเดีย automation ของคุณไปสู่ความจริง:

   **Agent Builder:** สำหรับผู้ที่ต้องการปรับแต่ง อินเตอร์เฟซแบบ low-code ที่ใช้งานง่ายของเราช่วยให้คุณออกแบบและตั้งค่า AI agent ได้เอง
   
   **Workflow Management:** สร้าง แก้ไข และปรับแต่งเวิร์กโฟลว์อัตโนมัติของคุณได้อย่างง่ายดาย คุณสร้าง agent โดยเชื่อมต่อบล็อกต่างๆ ซึ่งแต่ละบล็อกจะทำงานแต่ละอย่าง
   
   **Deployment Controls:** จัดการวงจรชีวิตของ agent ตั้งแต่การทดสอบจนถึงการใช้งานจริง
   
   **Ready-to-Use Agents:** ไม่อยากสร้างเอง? เลือกจากคลัง agent ที่ตั้งค่าล่วงหน้าของเราและใช้งานได้ทันที
   
   **Agent Interaction:** ไม่ว่าคุณจะสร้างเองหรือใช้ agent ที่ตั้งค่าไว้แล้ว สามารถรันและโต้ตอบได้ง่ายผ่านอินเตอร์เฟซที่เป็นมิตรกับผู้ใช้

   **Monitoring and Analytics:** ติดตามประสิทธิภาพ agent และรับข้อมูลเชิงลึกเพื่อปรับปรุงกระบวนการอัตโนมัติของคุณอย่างต่อเนื่อง

[อ่านคู่มือนี้](https://docs.agpt.co/platform/new_blocks/) เพื่อเรียนรู้วิธีสร้าง custom block ของคุณเอง

### 💽 AutoGPT Server

AutoGPT Server คือศูนย์กลางพลังงานของแพลตฟอร์มเรา ที่นี่ agent ของคุณจะถูกรัน เมื่อ deploy แล้ว agent สามารถถูกเรียกใช้งานจากแหล่งภายนอกและทำงานได้อย่างต่อเนื่อง โดยมีองค์ประกอบสำคัญที่ทำให้ AutoGPT ทำงานได้อย่างราบรื่น

   **Source Code:** แกนหลักของตรรกะที่ขับเคลื่อน agent และกระบวนการอัตโนมัติ
   
   **Infrastructure:** ระบบที่แข็งแรง รองรับการทำงานที่น่าเชื่อถือและขยายขนาดได้
   
   **Marketplace:** มาร์เก็ตเพลสที่ครบถ้วน คุณสามารถค้นหาและติดตั้ง agent ที่สร้างไว้ล่วงหน้าหลากหลายประเภท

### 🐙 ตัวอย่าง Agent

นี่คือตัวอย่าง 2 อย่างที่คุณสามารถทำได้ด้วย AutoGPT:

1. **สร้างวิดีโอไวรัลจากหัวข้อที่กำลังมาแรง**
   - agent นี้จะอ่านหัวข้อบน Reddit
   - ค้นหาหัวข้อที่กำลังเป็นที่นิยม
   - แล้วสร้างวิดีโอสั้นๆ โดยอัตโนมัติตามเนื้อหา

2. **ค้นหาคำพูดเด็ดจากวิดีโอเพื่อโซเชียลมีเดีย**
   - agent นี้ subscribe ช่อง YouTube ของคุณ
   - เมื่อคุณโพสต์วิดีโอใหม่ มันจะถอดเสียงวิดีโอ
   - ใช้ AI เพื่อค้นหาคำพูดที่โดดเด่นที่สุดเพื่อสรุปเนื้อหา
   - จากนั้นเขียนโพสต์เพื่อเผยแพร่ไปยังโซเชียลมีเดียโดยอัตโนมัติ

ตัวอย่างเหล่านี้เป็นเพียงส่วนหนึ่งของสิ่งที่คุณสามารถทำได้กับ AutoGPT! คุณสามารถสร้างเวิร์กโฟลว์ที่ปรับแต่งได้สำหรับทุก use case

---
### พันธกิจและสิทธิ์การใช้งาน
พันธกิจของเราคือการมอบเครื่องมือให้คุณได้โฟกัสกับสิ่งที่สำคัญ:

- 🏗️ **สร้าง** - วางรากฐานสู่สิ่งที่น่าทึ่ง
- 🧪 **ทดสอบ** - ปรับแต่ง agent ของคุณจนสมบูรณ์แบบ
- 🤝 **มอบหมาย** - ให้ AI ทำงานแทนคุณ และเปลี่ยนไอเดียของคุณให้เป็นจริง

ร่วมเป็นส่วนหนึ่งของการปฏิวัติ! **AutoGPT** พร้อมจะอยู่ในแนวหน้าของนวัตกรรม AI

**📖 [เอกสารประกอบ](https://docs.agpt.co)**
&ensp;|&ensp;
**🚀 [มีส่วนร่วม](CONTRIBUTING.md)**

**สิทธิ์การใช้งาน:**

MIT License: ส่วนใหญ่ของ repository AutoGPT อยู่ภายใต้ MIT License

Polyform Shield License: ใบอนุญาตนี้ใช้กับโฟลเดอร์ autogpt_platform

ดูรายละเอียดเพิ่มเติมที่ https://agpt.co/blog/introducing-the-autogpt-platform

---
## 🤖 AutoGPT Classic
> ข้อมูลด้านล่างนี้เป็นของเวอร์ชัน classic ของ AutoGPT

**🛠️ [สร้าง Agent ของคุณเอง - เริ่มต้นอย่างรวดเร็ว](classic/FORGE-QUICKSTART.md)**

### 🏗️ Forge

**Forge agent ของคุณเอง!** &ndash; Forge คือชุดเครื่องมือพร้อมใช้งานสำหรับสร้าง agent application ของคุณเอง โดยจัดการโค้ดโครงสร้างให้ส่วนใหญ่แล้ว ให้คุณโฟกัสกับความคิดสร้างสรรค์ในสิ่งที่ทำให้ agent ของ *คุณ* แตกต่าง คู่มือทั้งหมดอยู่ [ที่นี่](https://medium.com/@aiedge/autogpt-forge-e3de53cc58ec) คุณสามารถใช้คอมโพเนนต์จาก [`forge`](/classic/forge/) แยกเดี่ยวเพื่อเร่งการพัฒนาและลดโค้ดซ้ำในโปรเจกต์ agent ของคุณ

🚀 [**เริ่มต้นกับ Forge**](https://github.com/Significant-Gravitas/AutoGPT/blob/master/classic/forge/tutorials/001_getting_started.md) &ndash;
คู่มือนี้จะนำคุณผ่านขั้นตอนการสร้าง agent ของคุณเอง และการใช้ benchmark กับ user interface

📘 [เรียนรู้เพิ่มเติม](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/forge) เกี่ยวกับ Forge

### 🎯 Benchmark

**วัดประสิทธิภาพ agent ของคุณ!** `agbenchmark` สามารถใช้กับ agent ใดก็ได้ที่รองรับ agent protocol และการผนวกรวมกับ [CLI] ของโปรเจกต์ทำให้ใช้งานกับ AutoGPT และ agent ที่สร้างด้วย forge ได้ง่ายขึ้น Benchmark ให้สภาพแวดล้อมทดสอบที่เข้มงวด เฟรมเวิร์กของเราช่วยให้ประเมินประสิทธิภาพแบบอัตโนมัติและเป็นกลาง เพื่อให้แน่ใจว่า agent ของคุณพร้อมใช้งานจริง

<!-- TODO: ใส่ภาพตัวอย่างของ benchmark -->

📦 [`agbenchmark`](https://pypi.org/project/agbenchmark/) บน Pypi
&ensp;|&ensp;
📘 [เรียนรู้เพิ่มเติม](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/benchmark) เกี่ยวกับ Benchmark

### 💻 UI

**ทำให้ agent ใช้งานง่าย!** `frontend` ให้คุณควบคุมและตรวจสอบ agent ได้ผ่านอินเตอร์เฟซที่เป็นมิตร เชื่อมต่อกับ agent ผ่าน [agent protocol](#-agent-protocol) เพื่อให้รองรับ agent ได้หลากหลาย ทั้งจากในและนอก ecosystem ของเรา

<!-- TODO: ใส่ภาพหน้าจอ frontend -->

Frontend ใช้งานได้ทันทีร่วมกับ agent ทั้งหมดใน repo เพียงใช้ [CLI] เพื่อรัน agent ที่คุณเลือก

📘 [เรียนรู้เพิ่มเติม](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/frontend) เกี่ยวกับ Frontend

### ⌨️ CLI

[CLI]: #-cli

เพื่อให้คุณใช้งานเครื่องมือต่างๆ ใน repo ได้ง่ายที่สุด มี CLI ให้ที่ root ของ repo:

```shell
$ ./run
Usage: cli.py [OPTIONS] COMMAND [ARGS]...

Options:
  --help  Show this message and exit.

Commands:
  agent      Commands to create, start and stop agents
  benchmark  Commands to start the benchmark and list tests and categories
  setup      Installs dependencies needed for your system.
```

เพียง clone repo, ติดตั้ง dependencies ด้วย `./run setup` แล้วคุณก็พร้อมใช้งาน!

## 🤔 คำถาม? ปัญหา? ข้อเสนอแนะ?

### ขอความช่วยเหลือ - [Discord 💬](https://discord.gg/autogpt)

[![Join us on Discord](https://invidget.switchblade.xyz/autogpt)](https://discord.gg/autogpt)

หากต้องการแจ้งบั๊กหรือขอฟีเจอร์ใหม่ สร้าง [GitHub Issue](https://github.com/Significant-Gravitas/AutoGPT/issues/new/choose) กรุณาตรวจสอบก่อนว่ามี issue เดียวกันหรือยัง

## 🤝 โครงการพี่น้อง

### 🔄 Agent Protocol

เพื่อรักษามาตรฐานเดียวกันและรับรองการใช้งานร่วมกันกับแอพพลิเคชั่นในปัจจุบันและอนาคต AutoGPT ใช้มาตรฐาน [agent protocol](https://agentprotocol.ai/) ของ AI Engineer Foundation ซึ่งมาตรฐานนี้จะกำหนดเส้นทางการสื่อสารระหว่าง agent ของคุณกับ frontend และ benchmark

---

## Stars stats

<p align="center">
<a href="https://star-history.com/#Significant-Gravitas/AutoGPT">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
  </picture>
</a>
</p>


## ⚡ Contributors

<a href="https://github.com/Significant-Gravitas/AutoGPT/graphs/contributors" alt="View Contributors">
  <img src="https://contrib.rocks/image?repo=Significant-Gravitas/AutoGPT&max=1000&columns=10" alt="Contributors" />
</a>


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---