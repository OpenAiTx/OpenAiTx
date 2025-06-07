<p align="center">
  <img width="320" src="https://wpimg.wallstcn.com/ecc53a42-d79b-42e2-8852-5126b810a4c8.svg">
</p>

<p align="center">
  <a href="https://github.com/vuejs/vue">
    <img src="https://img.shields.io/badge/vue-2.6.10-brightgreen.svg" alt="vue">
  </a>
  <a href="https://github.com/ElemeFE/element">
    <img src="https://img.shields.io/badge/element--ui-2.7.0-brightgreen.svg" alt="element-ui">
  </a>
  <a href="https://travis-ci.org/PanJiaChen/vue-element-admin" rel="nofollow">
    <img src="https://travis-ci.org/PanJiaChen/vue-element-admin.svg?branch=master" alt="Build Status">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/mashape/apistatus.svg" alt="license">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/releases">
    <img src="https://img.shields.io/github/release/PanJiaChen/vue-element-admin.svg" alt="GitHub release">
  </a>
  <a href="https://gitter.im/vue-element-admin/discuss">
    <img src="https://badges.gitter.im/Join%20Chat.svg" alt="gitter">
  </a>
  <a href="https://panjiachen.github.io/vue-element-admin-site/donate">
    <img src="https://img.shields.io/badge/%24-donate-ff69b4.svg" alt="donate">
  </a>
</p>

English | [简体中文](./README.zh-CN.md) | [日本語](./README.ja.md) | [Spanish](./README.es.md)

<!-- <p align="center">
  <b>SPONSORED BY</b>
</p>
<table align="center" cellspacing="0" cellpadding="0">
  <tbody>
    <tr>
      <td align="center" valign="middle">
       <a href="" title="" target="_blank" style="padding-right: 20px;">
        <img height="200px" style="padding-right: 20px;" src="" title="variantForm">
        </a>
      </td>
    </tr>
  </tbody> 
</table>-->

## บทนำ

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) คือโซลูชันส่วนหน้าสำหรับอินเทอร์เฟซผู้ดูแลระบบที่พร้อมสำหรับการใช้งานในสายการผลิต พัฒนาขึ้นโดยใช้ [vue](https://github.com/vuejs/vue) และใช้ UI Toolkit [element-ui](https://github.com/ElemeFE/element)

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) สร้างขึ้นจากสแต็กการพัฒนาล่าสุดของ vue และมีระบบ i18n ในตัว มีเทมเพลตตัวอย่างสำหรับแอปพลิเคชันองค์กร และมีฟีเจอร์ที่ยอดเยี่ยมมากมาย ช่วยให้คุณสร้าง Single-Page Applications ที่มีขนาดใหญ่และซับซ้อนได้ เชื่อว่าไม่ว่าคุณจะมีความต้องการแบบใด โปรเจกต์นี้จะช่วยคุณได้

- [ดูตัวอย่าง](https://panjiachen.github.io/vue-element-admin)

- [เอกสารประกอบ](https://panjiachen.github.io/vue-element-admin-site/)

- [Gitter](https://gitter.im/vue-element-admin/discuss)

- [บริจาค](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [Wiki](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/) สำหรับผู้ใช้ในประเทศจีนสามารถเข้าชมตัวอย่างออนไลน์ที่นี่

- เทมเพลตพื้นฐานแนะนำให้ใช้: [vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- เดสก์ท็อป: [electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- Typescript: [vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template) (เครดิต: [@Armour](https://github.com/Armour))
- [awesome-project](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**หลังจากเวอร์ชัน `v4.1.0+` สาขา master เริ่มต้นจะไม่รองรับ i18n โปรดใช้ [i18n Branch](https://github.com/PanJiaChen/vue-element-admin/tree/i18n) ซึ่งจะอัปเดตตาม master เสมอ**

**เวอร์ชันปัจจุบันคือ `v4.0+` สร้างด้วย `vue-cli` หากพบปัญหา กรุณาส่ง [issue](https://github.com/PanJiaChen/vue-element-admin/issues/new) หากต้องการใช้เวอร์ชันเก่า สามารถสลับไปที่ [tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0) ซึ่งไม่ขึ้นกับ `vue-cli`**

**โปรเจกต์นี้ไม่รองรับเบราว์เซอร์เวอร์ชันต่ำ (เช่น IE) กรุณาเพิ่ม polyfill เอง**

## การเตรียมตัว

คุณต้องติดตั้ง [node](https://nodejs.org/) และ [git](https://git-scm.com/) ในเครื่อง โปรเจกต์นี้พัฒนาบนพื้นฐานของ [ES2015+](https://es6.ruanyifeng.com/), [vue](https://cn.vuejs.org/index.html), [vuex](https://vuex.vuejs.org/zh-cn/), [vue-router](https://router.vuejs.org/zh-cn/), [vue-cli](https://github.com/vuejs/vue-cli), [axios](https://github.com/axios/axios) และ [element-ui](https://github.com/ElemeFE/element) ข้อมูลทุกคำขอถูกจำลองด้วย [Mock.js](https://github.com/nuysoft/Mock) การเข้าใจและเรียนรู้ความรู้เหล่านี้ล่วงหน้าจะช่วยให้ใช้โปรเจกต์นี้ได้อย่างมาก

[![แก้ไขบน CodeSandbox](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## ผู้สนับสนุน

เป็นผู้สนับสนุนและรับโลโก้ของคุณบน README ของเราใน GitHub พร้อมลิงก์ไปยังเว็บไซต์ของคุณ [[เป็นผู้สนับสนุน]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>รับ Java backend สำหรับ Vue admin พร้อมส่วนลด 20% เหลือเพียง 39$ ใช้โค้ดคูปอง SWB0RAZPZR1M
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>เทมเพลต Admin Dashboard ที่สร้างด้วย Vue, React และ Angular</p>

## คุณสมบัติ

```
- เข้าสู่ระบบ / ออกจากระบบ

- การตรวจสอบสิทธิ์การเข้าใช้
  - สิทธิ์การเข้าถึงหน้า
  - สิทธิ์โดยคำสั่ง
  - หน้าตั้งค่าสิทธิ์
  - การเข้าสู่ระบบแบบสองขั้นตอน

- การสร้างหลายสภาพแวดล้อม
  - พัฒนา (dev)
  - sit
  - ทดสอบระยะกลาง (stage)
  - ผลิต (prod)

- ฟีเจอร์ทั่วโลก
  - I18n
  - ธีมไดนามิกหลายแบบ
  - แถบด้านข้างแบบไดนามิก (รองรับ multi-level routing)
  - breadcrumb แบบไดนามิก
  - Tags-view (Tab page รองรับคลิกขวา)
  - Svg Sprite
  - ข้อมูลจำลอง (Mock data)
  - Screenfull
  - แถบด้านข้างตอบสนองขนาดจอ

- ตัวแก้ไข
  - Rich Text Editor
  - Markdown Editor
  - JSON Editor

- Excel
  - ส่งออก Excel
  - อัปโหลด Excel
  - แสดงผล Excel
  - ส่งออก zip

- ตาราง
  - ตารางไดนามิก
  - ตารางลากวาง
  - ตารางแก้ไขในบรรทัด

- หน้าข้อผิดพลาด
  - 401
  - 404

- คอมโพเนนต์
  - อัปโหลด Avatar
  - กลับสู่ด้านบน
  - Dialog ลากได้
  - Select ลากได้
  - Kanban ลากได้
  - รายการลากได้
  - SplitPane
  - Dropzone
  - Sticky
  - CountTo

- ตัวอย่างขั้นสูง
- บันทึกข้อผิดพลาด
- Dashboard
- หน้าคู่มือการใช้งาน
- ECharts
- Clipboard
- Markdown เป็น html
```

## เริ่มต้นใช้งาน

```bash
# โคลนโปรเจกต์
git clone https://github.com/PanJiaChen/vue-element-admin.git

# เข้าสู่ไดเรกทอรีโปรเจกต์
cd vue-element-admin

# ติดตั้ง dependencies
npm install

# เริ่มพัฒนา
npm run dev
```

ระบบจะเปิด http://localhost:9527 โดยอัตโนมัติ

## การ build

```bash
# build สำหรับสภาพแวดล้อมทดสอบ
npm run build:stage

# build สำหรับสภาพแวดล้อมผลิต
npm run build:prod
```

## ขั้นสูง

```bash
# แสดงตัวอย่างสภาพแวดล้อม release
npm run preview

# แสดงตัวอย่าง release พร้อมวิเคราะห์ resource แบบ static
npm run preview -- --report

# ตรวจสอบรูปแบบโค้ด
npm run lint

# ตรวจสอบรูปแบบโค้ดและแก้ไขอัตโนมัติ
npm run lint -- --fix
```

ดูรายละเอียดเพิ่มเติมที่ [เอกสารประกอบ](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html)

## บันทึกการเปลี่ยนแปลง

รายละเอียดการเปลี่ยนแปลงในแต่ละรุ่นอยู่ใน [release notes](https://github.com/PanJiaChen/vue-element-admin/releases)

## ตัวอย่างออนไลน์

[ดูตัวอย่าง](https://panjiachen.github.io/vue-element-admin)

## บริจาค

หากคุณพบว่าโปรเจกต์นี้มีประโยชน์ คุณสามารถซื้อเครื่องดื่มน้ำผลไม้ให้ผู้เขียนสักแก้ว :tropical_drink:

![donate](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[Paypal Me](https://www.paypal.me/panfree23)

[Buy me a coffee](https://www.buymeacoffee.com/Pan)

## การรองรับเบราว์เซอร์

รองรับเบราว์เซอร์สมัยใหม่และ Internet Explorer 10+

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10, IE11, Edge | 2 เวอร์ชันล่าสุด | 2 เวอร์ชันล่าสุด | 2 เวอร์ชันล่าสุด |

## ใบอนุญาต

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

ลิขสิทธิ์ (c) 2017-ปัจจุบัน PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---