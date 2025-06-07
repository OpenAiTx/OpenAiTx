<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## บทนำ

Tauri คือเฟรมเวิร์กสำหรับสร้างไฟล์ไบนารีขนาดเล็กที่รวดเร็วสุดขีดสำหรับแพลตฟอร์มเดสก์ท็อปหลักทั้งหมด นักพัฒนาสามารถผสานรวมเฟรมเวิร์กส่วนหน้าใด ๆ ที่คอมไพล์เป็น HTML, JS และ CSS เพื่อสร้างส่วนติดต่อผู้ใช้ของตนได้ ส่วน backend ของแอปพลิเคชันเป็นไฟล์ไบนารีที่เขียนด้วยภาษา Rust พร้อม API ที่ส่วนหน้าใช้งานได้

ส่วนติดต่อผู้ใช้ในแอป Tauri ปัจจุบันใช้ [`tao`](https://docs.rs/tao) เป็นไลบรารีจัดการหน้าต่างบน macOS, Windows, Linux, Android และ iOS เพื่อเรนเดอร์แอปของคุณ Tauri ใช้ [WRY](https://github.com/tauri-apps/wry) ซึ่งเป็นไลบรารีที่ให้การเข้าถึง webview ของระบบแบบรวมศูนย์ โดยใช้ WKWebView บน macOS & iOS, WebView2 บน Windows, WebKitGTK บน Linux และ Android System WebView บน Android

หากต้องการเรียนรู้รายละเอียดเพิ่มเติมเกี่ยวกับวิธีการทำงานร่วมกันของส่วนประกอบเหล่านี้ กรุณาศึกษาเอกสาร [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md) นี้

## เริ่มต้นใช้งาน

หากคุณสนใจในการสร้างแอป tauri กรุณาเยี่ยมชม [เว็บไซต์เอกสาร](https://tauri.app)

วิธีที่เร็วที่สุดในการเริ่มต้นคือการติดตั้ง [โปรแกรมที่ต้องมี](https://v2.tauri.app/start/prerequisites/) สำหรับระบบของคุณ และสร้างโปรเจกต์ใหม่ด้วย [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage) ตัวอย่างเช่นด้วย `npm`:

```sh
npm create tauri-app@latest
```

## ฟีเจอร์

รายการฟีเจอร์ของ Tauri รวมถึงแต่ไม่จำกัดเพียง:

- ตัวบันเดิลแอปในตัว สำหรับสร้างชุดแอปในรูปแบบเช่น `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage` และตัวติดตั้ง Windows เช่น `.exe` (ผ่าน NSIS) และ `.msi` (ผ่าน WiX)
- ระบบอัปเดตตัวเองในตัว (เฉพาะเดสก์ท็อป)
- ไอคอนในถาดระบบ
- การแจ้งเตือนแบบเนทีฟ
- โปรโตคอล WebView แบบเนทีฟ (tauri ไม่ได้สร้างเซิร์ฟเวอร์ http(s) localhost เพื่อให้บริการเนื้อหา WebView)
- GitHub action สำหรับ CI ที่คล่องตัว
- ส่วนขยาย VS Code

### แพลตฟอร์ม

Tauri ปัจจุบันรองรับการพัฒนาและแจกจ่ายบนแพลตฟอร์มต่อไปนี้:

| แพลตฟอร์ม   | เวอร์ชัน                                                                                                         |
| :----------- | :--------------------------------------------------------------------------------------------------------------- |
| Windows      | 7 ขึ้นไป                                                                                                         |
| macOS        | 10.15 ขึ้นไป                                                                                                     |
| Linux        | webkit2gtk 4.0 สำหรับ Tauri v1 (เช่น Ubuntu 18.04), webkit2gtk 4.1 สำหรับ Tauri v2 (เช่น Ubuntu 22.04)          |
| iOS/iPadOS   | 9 ขึ้นไป                                                                                                         |
| Android      | 7 ขึ้นไป (ปัจจุบัน 8 ขึ้นไป)                                                                                   |

## การมีส่วนร่วม

ก่อนที่คุณจะเริ่มทำงานอะไร ควรตรวจสอบก่อนว่ามี issue ที่เกี่ยวข้องอยู่แล้วหรือไม่ อีกทั้งควรแวะไปที่ Discord server และยืนยันกับทีมว่าสมเหตุสมผลหรือมีคนอื่นกำลังทำอยู่แล้วหรือไม่

กรุณาอ่าน [คู่มือการมีส่วนร่วม](./.github/CONTRIBUTING.md) ก่อนส่ง pull request

ขอขอบคุณทุกท่านที่มีส่วนร่วมกับ Tauri!

### เอกสาร

เอกสารในระบบหลายภาษาเป็นเรื่องที่ท้าทาย ด้วยเหตุนี้เราจึงเลือกใช้เอกสารแบบ inline ในซอร์สโค้ด Rust & JS ให้มากที่สุด ดูข้อมูลเพิ่มเติมได้ที่ที่เก็บโฮสต์ของเอกสาร: <https://github.com/tauri-apps/tauri-docs>

## พันธมิตร

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

สำหรับรายชื่อผู้สนับสนุนทั้งหมด กรุณาเยี่ยมชม [เว็บไซต์ของเรา](https://tauri.app#sponsors) และ [Open Collective](https://opencollective.com/tauri)

## องค์กร

Tauri มุ่งหวังเป็นกลุ่มที่ยั่งยืนโดยอิงตามหลักการที่แนะนำ [ชุมชนซอฟต์แวร์เสรีและเปิดที่ยั่งยืน](https://sfosc.org) เพื่อเป้าหมายนี้ Tauri ได้กลายเป็นโปรแกรมภายใน [Commons Conservancy](https://commonsconservancy.org/) และคุณสามารถสนับสนุนทางการเงินผ่าน [Open Collective](https://opencollective.com/tauri)

## ใบอนุญาต

โค้ด: (c) 2015 - ปัจจุบัน - The Tauri Programme ใน The Commons Conservancy

MIT หรือ MIT/Apache 2.0 ตามที่เกี่ยวข้อง

โลโก้: CC-BY-NC-ND

- การออกแบบโลโก้ Tauri ดั้งเดิมโดย [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick) และ [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---