[![Electron Logo](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![GitHub Actions Build Status](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Electron Discord Invite](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: มีเอกสารแปลหลายภาษา: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
ดูเอกสารเหล่านี้ในภาษาอื่นได้ที่โครงการ [Crowdin](https://crowdin.com/project/electron) ของเรา

เฟรมเวิร์ก Electron ช่วยให้คุณเขียนแอปพลิเคชันเดสก์ท็อปข้ามแพลตฟอร์มโดยใช้ JavaScript, HTML และ CSS โดยมีพื้นฐานจาก [Node.js](https://nodejs.org/) และ [Chromium](https://www.chromium.org) และถูกใช้งานโดย [Visual Studio Code](https://github.com/Microsoft/vscode/) และ [แอปอื่น ๆ อีกมากมาย](https://electronjs.org/apps)

ติดตาม [@electronjs](https://twitter.com/electronjs) บน Twitter สำหรับประกาศสำคัญ

โครงการนี้ปฏิบัติตาม Contributor Covenant [จรรยาบรรณ](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md) ในการมีส่วนร่วม คุณคาดว่าจะยึดมั่นตามจรรยาบรรณนี้ หากพบพฤติกรรมที่ไม่เหมาะสม กรุณารายงานไปที่ [coc@electronjs.org](mailto:coc@electronjs.org)

## การติดตั้ง

หากต้องการติดตั้งไบนารี Electron ที่สร้างไว้ล่วงหน้า ให้ใช้ [`npm`](https://docs.npmjs.com/)
วิธีที่แนะนำคือการติดตั้ง Electron เป็น dependency สำหรับการพัฒนาในแอปของคุณ:

```sh
npm install electron --save-dev
```

สำหรับตัวเลือกการติดตั้งเพิ่มเติมและเคล็ดลับการแก้ไขปัญหา ดูที่
[installation](docs/tutorial/installation.md) สำหรับข้อมูลวิธีจัดการเวอร์ชัน Electron ในแอปของคุณ ดูที่
[Electron versioning](docs/tutorial/electron-versioning.md)

## การรองรับแพลตฟอร์ม

แต่ละเวอร์ชันของ Electron จะมีไบนารีสำหรับ macOS, Windows และ Linux

* macOS (Big Sur ขึ้นไป): Electron มีไบนารีสำหรับ Intel 64 บิต และ Apple Silicon / ARM สำหรับ macOS
* Windows (Windows 10 ขึ้นไป): Electron มีไบนารี `ia32` (`x86`), `x64` (`amd64`) และ `arm64` สำหรับ Windows การรองรับ Windows on ARM ถูกเพิ่มใน Electron 5.0.8 การรองรับ Windows 7, 8 และ 8.1 ถูก [ถอดออกใน Electron 23 ตามนโยบายการยุติการสนับสนุน Windows ของ Chromium](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice)
* Linux: ไบนารี Electron ที่สร้างไว้ล่วงหน้าถูกสร้างบน Ubuntu 20.04 และได้รับการทดสอบว่าสามารถใช้งานได้กับ:
  * Ubuntu 18.04 และใหม่กว่า
  * Fedora 32 และใหม่กว่า
  * Debian 10 และใหม่กว่า

## Electron Fiddle

ใช้ [`Electron Fiddle`](https://github.com/electron/fiddle)
เพื่อสร้าง, รัน และแพ็กเกจการทดลองใช้งาน Electron ขนาดเล็ก ดูตัวอย่างโค้ดสำหรับ API ทั้งหมดของ Electron และ
ทดลองเวอร์ชันต่าง ๆ ของ Electron ถูกออกแบบมาเพื่อให้ง่ายต่อการเริ่มต้นใช้งาน Electron

## แหล่งข้อมูลสำหรับการเรียนรู้ Electron

* [electronjs.org/docs](https://electronjs.org/docs) - เอกสารประกอบทั้งหมดของ Electron
* [electron/fiddle](https://github.com/electron/fiddle) - เครื่องมือสำหรับสร้าง, รัน และแพ็กเกจการทดลองใช้งาน Electron ขนาดเล็ก
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - ตัวอย่างแอปเริ่มต้นที่สร้างโดยชุมชน

## การใช้งานเชิงโปรแกรม

โดยส่วนมากแล้วผู้คนจะใช้ Electron จากคำสั่งใน command line แต่หากคุณต้องการ `require` `electron` ภายใน
**แอป Node ของคุณ** (ไม่ใช่แอป Electron) มันจะคืนค่าเส้นทางไฟล์ไปยังไบนารี
ใช้สิ่งนี้ในการสั่งให้ Node script เรียก Electron:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// จะแสดงผลคล้ายกับ /Users/maf/.../Electron
console.log(electron)

// เรียกใช้งาน Electron
const child = proc.spawn(electron)
```

### มิเรอร์

* [ประเทศจีน](https://npmmirror.com/mirrors/electron/)

ดูที่ [Advanced Installation Instructions](https://www.electronjs.org/docs/latest/tutorial/installation#mirror) เพื่อเรียนรู้วิธีใช้มิเรอร์แบบกำหนดเอง

## การแปลเอกสาร

เรารับการแปลเอกสารของเราผ่าน [Crowdin](https://crowdin.com/project/electron)
ขณะนี้เรารับการแปลสำหรับภาษาจีน (ตัวย่อ), ฝรั่งเศส, เยอรมัน, ญี่ปุ่น, โปรตุเกส,
รัสเซีย และสเปน

## การมีส่วนร่วม

หากคุณสนใจรายงาน/แก้ไขปัญหา และมีส่วนร่วมกับฐานข้อมูลโค้ดโดยตรง กรุณาดู [CONTRIBUTING.md](CONTRIBUTING.md) สำหรับข้อมูลเพิ่มเติมเกี่ยวกับสิ่งที่เราต้องการและวิธีเริ่มต้น

## ชุมชน

ข้อมูลเกี่ยวกับการรายงานบั๊ก, การขอความช่วยเหลือ, การค้นหาเครื่องมือของบุคคลที่สามและแอปตัวอย่าง
และข้อมูลเพิ่มเติมสามารถดูได้ที่ [หน้าชุมชน](https://www.electronjs.org/community)

## ใบอนุญาต

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

เมื่อใช้โลโก้ Electron กรุณาปฏิบัติตาม [นโยบายเครื่องหมายการค้าของ OpenJS Foundation](https://trademark-policy.openjsf.org/)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---