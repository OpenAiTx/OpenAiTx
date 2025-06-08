## Vue 2 ได้สิ้นสุดการสนับสนุนแล้ว

**คุณกำลังดูที่ repository ที่ไม่ใช้งานแล้วของ Vue 2 ขณะนี้ repository ที่ได้รับการดูแลและอัปเดตสำหรับ Vue เวอร์ชันล่าสุดคือ [vuejs/core](https://github.com/vuejs/core)**

Vue ได้สิ้นสุดการสนับสนุนเมื่อวันที่ 31 ธันวาคม 2023 โดยจะไม่มีการเพิ่มฟีเจอร์ใหม่ อัปเดต หรือแก้ไขใด ๆ อีกต่อไป อย่างไรก็ตาม คุณยังสามารถใช้งานได้ผ่านช่องทางจัดจำหน่ายต่าง ๆ ที่มีอยู่ (CDNs, ตัวจัดการแพ็กเกจ, Github ฯลฯ)

หากคุณกำลังจะเริ่มโปรเจกต์ใหม่ กรุณาเริ่มต้นด้วย Vue เวอร์ชันล่าสุด (3.x) เราแนะนำให้ผู้ใช้ Vue 2 ปัจจุบันอัปเกรด ([คู่มือ](https://v3-migration.vuejs.org/)) แต่เราก็เข้าใจว่าผู้ใช้บางรายอาจไม่มีเวลาหรือแรงจูงใจเพียงพอ หากคุณจำเป็นต้องใช้ Vue 2 ต่อไป แต่ต้องมีข้อกำหนดด้านความปลอดภัยหรือการปฏิบัติตามข้อกำหนดสำหรับซอฟต์แวร์ที่ไม่มีการดูแล กรุณาดู [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme)

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## ผู้สนับสนุน

Vue.js เป็นโครงการโอเพ่นซอร์สที่ได้รับอนุญาตภายใต้ MIT โดยการพัฒนาต่อเนื่องเป็นไปได้เพราะการสนับสนุนจาก [ผู้สนับสนุน](https://github.com/vuejs/core/blob/main/BACKERS.md) เหล่านี้ หากคุณต้องการเข้าร่วม กรุณาพิจารณา [สนับสนุนการพัฒนา Vue](https://vuejs.org/sponsor/)

<p align="center">
  <h3 align="center">ผู้สนับสนุนพิเศษ</h3>
</p>

<p align="center">
  <a target="_blank" href="https://github.com/appwrite/appwrite">
  <img alt="special sponsor appwrite" src="https://sponsors.vuejs.org/images/appwrite.svg" width="300">
  </a>
</p>

<p align="center">
  <a target="_blank" href="https://vuejs.org/sponsor/">
    <img alt="sponsors" src="https://sponsors.vuejs.org/sponsors.svg?v3">
  </a>
</p>

---

## บทนำ

Vue (อ่านว่า `/vjuː/` คล้ายกับ "view") คือ **เฟรมเวิร์กแบบก้าวหน้า** สำหรับการสร้างส่วนติดต่อผู้ใช้ ถูกออกแบบมาให้สามารถนำไปใช้แบบค่อยเป็นค่อยไป และสามารถขยายขนาดได้ตั้งแต่ไลบรารีขนาดเล็กจนถึงเฟรมเวิร์กเต็มรูปแบบตามแต่กรณีการใช้งาน ประกอบด้วยไลบรารีหลักที่เน้นเฉพาะเลเยอร์ของ view และระบบนิเวศของไลบรารีเสริมที่ช่วยจัดการความซับซ้อนใน Single-Page Applications ขนาดใหญ่

#### ความเข้ากันได้ของเบราว์เซอร์

Vue.js รองรับเบราว์เซอร์ทั้งหมดที่ [รองรับ ES5](https://compat-table.github.io/compat-table/es5/) (IE8 และต่ำกว่าไม่รองรับ)

## ระบบนิเวศ

| โครงการ                | สถานะ                                                        | คำอธิบาย                                                 |
| --------------------- | ------------------------------------------------------------ | -------------------------------------------------------- |
| [vue-router]          | [![vue-router-status]][vue-router-package]                   | ระบบกำหนดเส้นทางสำหรับ single-page application           |
| [vuex]                | [![vuex-status]][vuex-package]                               | การจัดการ state ขนาดใหญ่                                 |
| [vue-cli]             | [![vue-cli-status]][vue-cli-package]                         | การสร้างโครงสร้างเริ่มต้นสำหรับโปรเจกต์                 |
| [vue-loader]          | [![vue-loader-status]][vue-loader-package]                   | Loader สำหรับ Single File Component (`*.vue` file) บน webpack |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package] | รองรับการเรนเดอร์ฝั่งเซิร์ฟเวอร์                        |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package] | TypeScript decorator สำหรับ API แบบ class-based           |
| [vue-rx]              | [![vue-rx-status]][vue-rx-package]                           | การใช้งานร่วมกับ RxJS                                    |
| [vue-devtools]        | [![vue-devtools-status]][vue-devtools-package]               | ส่วนขยาย DevTools สำหรับเบราว์เซอร์                      |

[vue-router]: https://github.com/vuejs/vue-router
[vuex]: https://github.com/vuejs/vuex
[vue-cli]: https://github.com/vuejs/vue-cli
[vue-loader]: https://github.com/vuejs/vue-loader
[vue-server-renderer]: https://github.com/vuejs/vue/tree/dev/packages/vue-server-renderer
[vue-class-component]: https://github.com/vuejs/vue-class-component
[vue-rx]: https://github.com/vuejs/vue-rx
[vue-devtools]: https://github.com/vuejs/vue-devtools
[vue-router-status]: https://img.shields.io/npm/v/vue-router.svg
[vuex-status]: https://img.shields.io/npm/v/vuex.svg
[vue-cli-status]: https://img.shields.io/npm/v/@vue/cli.svg
[vue-loader-status]: https://img.shields.io/npm/v/vue-loader.svg
[vue-server-renderer-status]: https://img.shields.io/npm/v/vue-server-renderer.svg
[vue-class-component-status]: https://img.shields.io/npm/v/vue-class-component.svg
[vue-rx-status]: https://img.shields.io/npm/v/vue-rx.svg
[vue-devtools-status]: https://img.shields.io/chrome-web-store/v/nhdogjmejiglipccpnnnanhbledajbpd.svg
[vue-router-package]: https://npmjs.com/package/vue-router
[vuex-package]: https://npmjs.com/package/vuex
[vue-cli-package]: https://npmjs.com/package/@vue/cli
[vue-loader-package]: https://npmjs.com/package/vue-loader
[vue-server-renderer-package]: https://npmjs.com/package/vue-server-renderer
[vue-class-component-package]: https://npmjs.com/package/vue-class-component
[vue-rx-package]: https://npmjs.com/package/vue-rx
[vue-devtools-package]: https://chrome.google.com/webstore/detail/vuejs-devtools/nhdogjmejiglipccpnnnanhbledajbpd

## เอกสารประกอบ

เพื่อดู [ตัวอย่างสด](https://v2.vuejs.org/v2/examples/) และเอกสาร กรุณาเยี่ยมชม [vuejs.org](https://v2.vuejs.org)

## คำถาม

สำหรับคำถามและการสนับสนุน กรุณาใช้ [ฟอรั่มอย่างเป็นทางการ](https://forum.vuejs.org) หรือ [แชทชุมชน](https://chat.vuejs.org/) รายการ issue ของ repo นี้ใช้สำหรับ **รายงานบั๊กและข้อเสนอแนะฟีเจอร์เท่านั้น**

## การรายงานปัญหา

กรุณาอ่าน [Checklist สำหรับการรายงาน Issue](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines) ก่อนเปิด Issue หากไม่เป็นไปตามแนวทาง อาจถูกปิดทันที

## บันทึกการเปลี่ยนแปลง

รายละเอียดการเปลี่ยนแปลงในแต่ละเวอร์ชันจะถูกบันทึกไว้ใน [release notes](https://github.com/vuejs/vue/releases)

## ช่องทางการติดตาม

- [Twitter](https://twitter.com/vuejs)
- [Blog](https://medium.com/the-vue-point)
- [Job Board](https://vuejobs.com/?ref=vuejs)

## การมีส่วนร่วม

กรุณาอ่าน [คู่มือการมีส่วนร่วม](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md) ก่อนส่ง pull request หากคุณมีโปรเจกต์/คอมโพเนนต์/เครื่องมือที่เกี่ยวกับ Vue สามารถเพิ่มได้โดย pull request ที่ [รายการนี้](https://github.com/vuejs/awesome-vue)!

ขอขอบคุณทุกคนที่ร่วมสนับสนุน Vue!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## ลิขสิทธิ์

[MIT](https://opensource.org/licenses/MIT)

สงวนลิขสิทธิ์ (c) 2013-ปัจจุบัน, Yuxi (Evan) You

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---