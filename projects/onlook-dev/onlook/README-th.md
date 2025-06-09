<!-- ปรับปรุงความเข้ากันได้ของลิงก์กลับขึ้นด้านบน: ดูที่: https://github.com/othneildrew/Best-README-Template/pull/73 -->

<div align="center">
<img width="800" alt="header image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/web-preview.png">
<h3 align="center">Onlook</h3>
  <p align="center">
    เคอร์เซอร์สำหรับนักออกแบบ
    <br />
    <a href="https://docs.onlook.com"><strong>สำรวจเอกสาร »</strong></a>
    <br />
    <br />
    <a href="https://youtu.be/RSX_3EaO5eU?feature=shared">ดูเดโม</a>
    ·
    <a href="https://github.com/onlook-dev/onlook/issues/new?labels=bug&template=bug-report---.md">รายงานบั๊ก</a>
    ·
    <a href="https://github.com/onlook-dev/onlook/issues/new?labels=enhancement&template=feature-request---.md">ขอฟีเจอร์ใหม่</a>
  </p>
  <!-- PROJECT SHIELDS -->
<!--
*** กำลังใช้ลิงก์ markdown แบบ "reference style" เพื่อความอ่านง่าย
*** ลิงก์แบบ reference จะอยู่ในวงเล็บเหลี่ยม [ ] แทนที่จะเป็นวงเล็บปกติ ( )
*** ดูประกาศตัวแปร reference ที่ท้ายเอกสารนี้
*** contributors-url, forks-url, ฯลฯ เป็นรูปแบบย่อที่คุณสามารถใช้ได้
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
<!-- [![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![Apache License][license-shield]][license-url] -->

[![Discord][discord-shield]][discord-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Twitter][twitter-shield]][twitter-url]

[中文](https://www.readme-i18n.com/onlook-dev/onlook?lang=zh) | 
[Español](https://www.readme-i18n.com/onlook-dev/onlook?lang=es) | 
[Deutsch](https://www.readme-i18n.com/onlook-dev/onlook?lang=de) | 
[français](https://www.readme-i18n.com/onlook-dev/onlook?lang=fr) | 
[Português](https://www.readme-i18n.com/onlook-dev/onlook?lang=pt) | 
[Русский](https://www.readme-i18n.com/onlook-dev/onlook?lang=ru) | 
[日本語](https://www.readme-i18n.com/onlook-dev/onlook?lang=ja) | 
[한국어](https://www.readme-i18n.com/onlook-dev/onlook?lang=ko)

</div>

# เคอร์เซอร์สำหรับนักออกแบบ – ตัวแก้ไขโค้ดแบบโอเพ่นซอร์สที่เน้นภาพ

สร้างเว็บไซต์ โปรโตไทป์ และออกแบบด้วย AI ใน Next.js + TailwindCSS แก้ไข
โดยตรงบน DOM ของเบราว์เซอร์ด้วยเครื่องมือแก้ไขแบบภาพ ออกแบบแบบเรียลไทม์ด้วยโค้ด
เป็นทางเลือกโอเพ่นซอร์สแทน Bolt.new, Lovable, V0, Replit Agent, Figma Make, Webflow ฯลฯ

### 🚧 🚧 🚧 Onlook for Web ยังอยู่ระหว่างการพัฒนา 🚧 🚧 🚧

เรากำลังมองหาผู้ร่วมพัฒนาเพื่อช่วยให้ Onlook for Web
เป็นประสบการณ์ prompt-to-build ที่น่าทึ่ง ดูที่
[open issues](https://github.com/onlook-dev/onlook/issues) สำหรับรายการฟีเจอร์ที่เสนอ (และปัญหาที่ทราบ)
และเข้าร่วม
[Discord](https://discord.gg/hERDfFZCsH) ของเราเพื่อร่วมมือกับนักพัฒนาคนอื่นๆ อีกหลายร้อยคน

## สิ่งที่คุณสามารถทำได้ด้วย Onlook:

- [x] สร้างแอป Next.js ในไม่กี่วินาที
  - [x] เริ่มจากข้อความหรือรูปภาพ
  - [ ] ใช้เทมเพลตที่สร้างไว้ล่วงหน้า
  - [ ] นำเข้าจาก Figma
  - [ ] เริ่มจาก repo บน GitHub
- [x] แก้ไขแอปของคุณแบบภาพ
  - [x] ใช้ UI คล้าย Figma
  - [x] ดูตัวอย่างแอปแบบเรียลไทม์
  - [x] จัดการแบรนด์แอสเซทและโทเคน
  - [x] สร้างและนำทางไปยัง Pages
  - [ ] เรียกดูเลเยอร์ – _เคยมีใน
        [Onlook Desktop](https://github.com/onlook-dev/desktop)_
  - [ ] ตรวจจับและใช้งานคอมโพเนนต์ – _เคยมีใน
        [Onlook Desktop](https://github.com/onlook-dev/desktop)_
  - [ ] จัดการรูปภาพโปรเจกต์ – _เคยมีใน
        [Onlook Desktop](https://github.com/onlook-dev/desktop)_
- [x] เครื่องมือสำหรับนักพัฒนา
  - [x] ตัวแก้ไขโค้ดเรียลไทม์
  - [x] บันทึกและเรียกคืนจาก checkpoint
  - [x] รันคำสั่งผ่าน CLI
  - [x] เชื่อมต่อกับ marketplace แอป
  - [ ] แก้ไขโค้ดในเครื่อง – _เคยมีใน
        [Onlook Desktop](https://github.com/onlook-dev/desktop)_
- [ ] ดีพลอยแอปของคุณในไม่กี่วินาที
  - [ ] สร้างลิงก์สำหรับแชร์
  - [ ] เชื่อมต่อโดเมนของคุณเอง
- [ ] ร่วมงานกับทีมของคุณ
  - [ ] แก้ไขแบบเรียลไทม์
  - [ ] ฝากคอมเมนต์

![Onlook-GitHub-Example](https://github.com/user-attachments/assets/642de37a-72cc-4056-8eb7-8eb42714cdc4)

### Onlook for Desktop (หรือ Onlook Alpha)

Onlook Web ยังอยู่ในช่วงพรีวิว หากคุณกำลังมองหาแอป electron เวอร์ชันดาวน์โหลด
ย้ายไปที่
[Onlook Desktop](https://github.com/onlook-dev/desktop)

ทำไมเราย้ายไปเว็บ? อ่านเหตุผลของเราได้ที่:
[Migrating from Electron to Web](https://docs.onlook.com/docs/developer/electron-to-web-migration)

## เริ่มต้นใช้งาน

จะพร้อมใช้งานเร็วๆ นี้ทั้งแบบ [แอปบนโฮสต์](https://onlook.com) หรือ
[รันในเครื่อง](https://docs.onlook.com/docs/developer/running-locally)

### วิธีใช้งาน

Onlook จะทำงานกับโปรเจกต์ Next.js + TailwindCSS ใดก็ได้ นำเข้าโปรเจกต์ของคุณ
เข้าสู่ Onlook หรือเริ่มจากศูนย์ภายในตัวแก้ไข

ใช้ AI chat เพื่อสร้างหรือแก้ไขโปรเจกต์ที่คุณกำลังทำงานอยู่ ทุกเมื่อที่ต้องการ
คุณสามารถคลิกขวาที่อีลีเมนต์เพื่อเปิดตำแหน่งของอีลีเมนต์ในโค้ดได้ทันที

<img width="600" alt="image" src="https://github.com/user-attachments/assets/4ad9f411-b172-4430-81ef-650f4f314666" />

<br>

วาด div ใหม่และจัดเรียงใหม่ภายใน parent container ได้ด้วยการลากและวาง

<img width="600" alt="image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/insert-div.png">

<br>

ดูตัวอย่างโค้ดแบบเคียงข้างกับดีไซน์ของเว็บไซต์คุณ

<img width="600" alt="image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/code-connect.png">

<br>

ใช้แถบเครื่องมือของ Onlook เพื่อปรับแต่งสไตล์ Tailwind จัดการออบเจ็กต์โดยตรง
และทดลองกับเลย์เอาต์ต่างๆ

<img width="600" alt="image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/text-styling.png" />

## เอกสารประกอบ

สำหรับเอกสารฉบับเต็ม เยี่ยมชม [docs.onlook.com](https://docs.onlook.com)

ดูวิธีการ Contribute ได้ที่
[Contributing to Onlook](https://docs.onlook.com/docs/developer/contributing) ในเอกสารของเรา

## วิธีการทำงาน

<img width="676" alt="architecture" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/architecture.png">

1. เมื่อคุณสร้างแอป เราจะโหลดโค้ดเข้าไปใน web container
2. คอนเทนเนอร์จะรันและให้บริการโค้ด
3. ตัวแก้ไขของเราจะรับลิงก์พรีวิวและแสดงใน iFrame
4. ตัวแก้ไขของเราจะอ่านและจัดทำดัชนีโค้ดจากคอนเทนเนอร์
5. เราติดตั้งเครื่องมือในโค้ดเพื่อจับคู่องค์ประกอบกับตำแหน่งในโค้ด
6. เมื่อองค์ประกอบถูกแก้ไข เราจะแก้ไขใน iFrame แล้วจึงแก้ไขในโค้ด
7. AI chat ของเราก็เข้าถึงโค้ดและมีเครื่องมือในการเข้าใจและแก้ไขโค้ด

สถาปัตยกรรมนี้ในทางทฤษฎีสามารถขยายไปยังภาษา หรือเฟรมเวิร์กใดๆ ที่
แสดง DOM แบบ declarative (เช่น jsx/tsx/html) เรามุ่งเน้นให้ทำงานได้ดี
กับ Next.js และ TailwindCSS ในตอนนี้

สำหรับการแนะนำแบบละเอียด ดูได้ที่
[Architecture Docs](https://docs.onlook.com/docs/developer/architecture)

### เทคโนโลยีที่เราใช้

#### ด้านหน้า (Front-end)

- [Next.js](https://nextjs.org/) - Full stack
- [TailwindCSS](https://tailwindcss.com/) - สไตล์
- [tRPC](https://trpc.io/) - Server interface

#### ฐานข้อมูล (Database)

- [Supabase](https://supabase.com/) - Auth, Database, Storage
- [Drizzle](https://orm.drizzle.team/) - ORM

#### AI

- [AI SDK](https://ai-sdk.dev/) - LLM client
- [Anthropic](https://ai-sdk.dev/) - ผู้ให้บริการ LLM model
- [Morph Fast Apply](https://morphllm.com) - ผู้ให้บริการ fast apply model
- [Relace](https://relace.ai) - ผู้ให้บริการ fast apply model

#### Sandbox และโฮสติ้ง

- [CodeSandboxSDK](https://codesandbox.io/docs/sdk) - Dev sandbox
- [Freestyle](https://www.freestyle.sh/) - โฮสติ้ง

#### Runtime

- [Bun](https://bun.sh/) - Monorepo, runtime, bundler
- [Docker](https://www.docker.com/) - การจัดการคอนเทนเนอร์

## การร่วมพัฒนา
![image](https://github.com/user-attachments/assets/ecc94303-df23-46ae-87dc-66b040396e0b)

หากคุณมีข้อเสนอแนะที่จะช่วยให้สิ่งนี้ดีขึ้น กรุณา fork repo และ
สร้าง pull request คุณยังสามารถ
[เปิด issues](https://github.com/onlook-dev/onlook/issues) ได้อีกด้วย

ดู [CONTRIBUTING.md](https://raw.githubusercontent.com/onlook-dev/onlook/main/CONTRIBUTING.md) สำหรับคำแนะนำและจรรยาบรรณในการร่วมโครงการ

#### ผู้ร่วมพัฒนา

<a href="https://github.com/onlook-dev/onlook/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=onlook-dev/onlook" />
</a>

## ติดต่อ

![image](https://github.com/user-attachments/assets/60684b68-1925-4550-8efd-51a1509fc953)

- ทีม: [Discord](https://discord.gg/hERDfFZCsH) -
  [Twitter](https://twitter.com/onlookdev) -
  [LinkedIn](https://www.linkedin.com/company/onlook-dev/) -
  [อีเมล](mailto:contact@onlook.com)
- โปรเจกต์:
  [https://github.com/onlook-dev/onlook](https://github.com/onlook-dev/onlook)
- เว็บไซต์: [https://onlook.com](https://onlook.com)

## ลิขสิทธิ์

เผยแพร่ภายใต้ Apache 2.0 License ดู [LICENSE.md](https://raw.githubusercontent.com/onlook-dev/onlook/main/LICENSE.md) สำหรับข้อมูลเพิ่มเติม

<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[contributors-shield]: https://img.shields.io/github/contributors/onlook-dev/studio.svg?style=for-the-badge
[contributors-url]: https://github.com/onlook-dev/onlook/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/onlook-dev/studio.svg?style=for-the-badge
[forks-url]: https://github.com/onlook-dev/onlook/network/members
[stars-shield]: https://img.shields.io/github/stars/onlook-dev/studio.svg?style=for-the-badge
[stars-url]: https://github.com/onlook-dev/onlook/stargazers
[issues-shield]: https://img.shields.io/github/issues/onlook-dev/studio.svg?style=for-the-badge
[issues-url]: https://github.com/onlook-dev/onlook/issues
[license-shield]: https://img.shields.io/github/license/onlook-dev/studio.svg?style=for-the-badge
[license-url]: https://github.com/onlook-dev/onlook/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/company/onlook-dev
[twitter-shield]: https://img.shields.io/badge/-Twitter-black?logo=x&colorB=555
[twitter-url]: https://x.com/onlookdev
[discord-shield]: https://img.shields.io/badge/-Discord-black?logo=discord&colorB=555
[discord-url]: https://discord.gg/hERDfFZCsH
[React.js]: https://img.shields.io/badge/react-%2320232a.svg?logo=react&logoColor=%2361DAFB
[React-url]: https://reactjs.org/
[TailwindCSS]: https://img.shields.io/badge/tailwindcss-%2338B2AC.svg?logo=tailwind-css&logoColor=white
[Tailwind-url]: https://tailwindcss.com/
[Electron.js]: https://img.shields.io/badge/Electron-191970?logo=Electron&logoColor=white
[Electron-url]: https://www.electronjs.org/
[Vite.js]: https://img.shields.io/badge/vite-%23646CFF.svg?logo=vite&logoColor=white
[Vite-url]: https://vitejs.dev/
[product-screenshot]: https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/brand.png
[weave-shield]: https://img.shields.io/endpoint?url=https%3A%2F%2Fapp.workweave.ai%2Fapi%2Frepository%2Fbadge%2Forg_pWcXBHJo3Li2Te2Y4WkCPA33%2F820087727&cacheSeconds=3600&labelColor=#131313
[weave-url]: https://app.workweave.ai/reports/repository/org_pWcXBHJo3Li2Te2Y4WkCPA33/820087727

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---