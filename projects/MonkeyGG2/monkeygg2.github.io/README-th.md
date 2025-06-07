<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">เว็บไซต์เกมเพื่อนบ้านของคุณที่เป็นมิตร</p>
<br>

ยินดีต้อนรับสู่ MonkeyGG2 เว็บไซต์เกมที่มีฟีเจอร์ครบครันที่สร้างขึ้นเพื่อคุณ! ด้วยเกมให้เลือกมากกว่า 150 เกม MonkeyGG2 มอบประสบการณ์การเล่นเกมที่ไม่เหมือนใครและสามารถปรับแต่งได้ ไม่ว่าคุณจะเป็นเกมเมอร์ นักพัฒนา หรือคนทั่วไป MonkeyGG2 ก็พร้อมมอบสภาพแวดล้อมการเล่นเกมที่ราบรื่นและสนุกสนาน

> อย่าลืมให้ดาวกับเรา! โดยเฉพาะถ้าคุณ fork repository นี้ หรือคุณพบว่ามีประโยชน์อื่น ๆ จาก repository นี้

## ฟีเจอร์

-   มีเกมมากกว่า 150 เกม
-   ใช้งานง่าย
-   ติดตั้งได้ง่าย
-   ปรับแต่งได้
-   มี Proxy
-   และอื่น ๆ อีกมากมาย...

## การปรับแต่ง

### การตั้งค่า

#### Cloaking

Cloaking หมายถึงการเปิดหน้าเว็บในแท็บ `about:blank` การทำงานนี้ถูกบังคับใช้โดยค่าเริ่มต้น แต่สามารถปิดการใช้งานได้ มีค่าล่วงหน้าสำหรับลิงก์เปลี่ยนเส้นทาง แต่คุณก็สามารถกำหนดเองได้เช่นกัน

#### Masking

Masking หมายถึงการเปลี่ยนไอคอนและชื่อแท็บของแท็บ about:blank มีค่าล่วงหน้าสำหรับไอคอนและชื่อแท็บ แต่ก็สามารถตั้งค่าด้วยตัวเองได้

#### คีย์ลัด

สามารถสร้างคีย์ลัดคีย์บอร์ดเองเพื่อดำเนินการหลายอย่างได้ เช่น ออกจากเกม, mask แท็บ, และรัน JavaScript ที่กำหนดเอง
> หมายเหตุ: หากคุณต้องการรัน JavaScript เอง โปรดแน่ใจว่าคุณรู้ว่ากำลังทำอะไรอยู่ หากเกิดปัญหา การ reload หน้าเว็บมักจะแก้ไขได้

#### ธีม

ขณะนี้รองรับการปรับแต่งธีมดังนี้:
- เปิด/ปิดแอนิเมชันพื้นหลัง (หากกังวลเรื่องประสิทธิภาพขณะเล่นเกม ไม่ต้องห่วง ระบบจะปิดให้อัตโนมัติขณะเล่นเกม)
- สีพื้นหลัง
- สีบล็อก
- สีปุ่ม
- สีเกม
- สีเมื่อชี้เมาส์
- สีแถบเลื่อน
- สีพื้นแถบเลื่อน
- สีตัวอักษร

> หมายเหตุ: หากคุณเปลี่ยนสีจนใช้งานเว็บไม่ได้ จำเป็นต้องลบ cookies และ local storage

### การปรับแต่งขั้นสูง

> ข้อจำกัดความรับผิดชอบ: การปรับแต่งต่อไปนี้มีเฉพาะเจ้าของ repository หรือ fork เท่านั้น

ไฟล์ `config.jsonc` ถูกจัดรูปแบบเพื่อรองรับการตั้งค่าทั้งเว็บไซต์ ปัจจุบันรองรับรายการดังต่อไปนี้:
- เกม
- ธีม (เร็ว ๆ นี้)
- การตั้งค่า Proxy

#### เกม

แต่ละรายการเกมจะมี key เป็นชื่อที่แสดงของเกม และ value เป็นวัตถุที่มีสาม key-value:
- `"path"`: เส้นทางไปยังเกมจากโฟลเดอร์ `./games`
- `"aliases"`: รายชื่อชื่อเรียกอื่น ๆ ของเกม เพื่อช่วยในการค้นหา
- `"categories"`: รายชื่อหมวดหมู่ที่เกมนั้นอยู่ (การเพิ่มไอคอนหมวดหมู่จะมาเร็ว ๆ นี้)

สามารถเพิ่มรายการเองได้ แต่ค่อนข้างยุ่งยากถ้าต้องการเรียงลำดับตัวอักษร/ตัวเลข (ไม่จำเป็นสำหรับการทำงานของระบบ)
จึงมีสคริปต์ `add-game-entry.js` ที่ช่วยให้เพิ่มเกมใหม่เข้า config ได้ง่ายโดยไม่ต้องแก้ไขไฟล์เอง

```bash
# สามารถใช้ js runtime ใดก็ได้ เช่น node.js, bun, หรือ deno
# ตัวอย่างนี้ใช้ bun เพราะจะติดตั้ง dependency ให้อัตโนมัติ
bun add-game-script.js
# ตอบคำถามใน prompt แล้ว config จะถูกอัปเดต
```

#### ธีม

มาตรฐานธีมยังไม่รองรับ (TODO)

#### Proxy

ตัวเลือกการตั้งค่า proxy อยู่ภายใต้ key **"config"**
ค่า key `"proxy"` เป็น boolean สำหรับเปิด/ปิด proxy หากตั้งเป็น false ผู้ใช้จะเห็น dialog error เมื่อพยายามใช้ proxy
ค่า key `"proxyPath"` คือเส้นทางของ proxy อาจเป็นเส้นทางสัมบูรณ์หรือสัมพัทธ์ก็ได้ แต่ proxy นั้นต้องรองรับ **CORS** เพราะจะแสดงผ่าน iframe ในเว็บไซต์

## การติดตั้ง (Deployment)

### ไม่ใช้ Proxy

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

หรือคุณสามารถ fork repository นี้ บน [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) หรือ [Codeberg](https://codeberg.org/MonkeyGG2/pages) และ deploy ไปยัง GitHub Pages หรือ Codeberg Pages ตามลำดับ

### ใช้ Proxy

ไปที่หน้า [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) เพื่อดูรายละเอียดการโฮสต์ MonkeyGG2 พร้อม proxy

### รันในเครื่อง

```bash
# คำเตือน: ถ้าคุณมีโฟลเดอร์ชื่อ "monkeygg2" คำสั่งนี้จะลบไฟล์ทั้งหมดในโฟลเดอร์นั้น
# กรุณาเปลี่ยนชื่อโฟลเดอร์ในสองคำสั่งต่อไปนี้
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# จากนั้นใช้เครื่องมือ static server ใดก็ได้ ที่นี่ใช้ "live-server" จาก npm
npm install -g live-server # หากยังไม่ได้ติดตั้ง
npx live-server
```

## ใบอนุญาต

เผยแพร่ภายใต้ใบอนุญาต WTFPL ดูรายละเอียดเพิ่มเติม [ที่นี่](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---