<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  เฟรมเวิร์กส่วนหน้าที่ทันสมัย ใช้งานง่าย และทรงพลัง สำหรับการพัฒนาเว็บไซต์ที่รวดเร็วและง่ายขึ้น
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>สำรวจเอกสารของ Bootstrap »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">รายงานบั๊ก</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">ขอฟีเจอร์ใหม่</a>
  ·
  <a href="https://themes.getbootstrap.com/">ธีม</a>
  ·
  <a href="https://blog.getbootstrap.com/">บล็อก</a>
</p>


## Bootstrap 5

สาขาหลักของเราคือสำหรับการพัฒนา Bootstrap 5 หากต้องการดู readme, เอกสาร และซอร์สโค้ดสำหรับ Bootstrap 4 ให้ไปที่ [สาขา `v4-dev`](https://github.com/twbs/bootstrap/tree/v4-dev)


## สารบัญ

- [เริ่มต้นอย่างรวดเร็ว](#quick-start)
- [สถานะ](#status)
- [เนื้อหาที่รวมอยู่](#whats-included)
- [รายงานบั๊กและขอฟีเจอร์](#bugs-and-feature-requests)
- [เอกสาร](#documentation)
- [การมีส่วนร่วม](#contributing)
- [ชุมชน](#community)
- [การจัดการเวอร์ชัน](#versioning)
- [ผู้สร้าง](#creators)
- [ขอบคุณ](#thanks)
- [ลิขสิทธิ์และสัญญาอนุญาต](#copyright-and-license)


## เริ่มต้นอย่างรวดเร็ว

มีตัวเลือกในการเริ่มต้นอย่างรวดเร็วหลายวิธี:

- [ดาวน์โหลดเวอร์ชันล่าสุด](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- โคลน repo: `git clone https://github.com/twbs/bootstrap.git`
- ติดตั้งด้วย [npm](https://www.npmjs.com/): `npm install bootstrap@v5.3.6`
- ติดตั้งด้วย [yarn](https://yarnpkg.com/): `yarn add bootstrap@v5.3.6`
- ติดตั้งด้วย [Bun](https://bun.sh/): `bun add bootstrap@v5.3.6`
- ติดตั้งด้วย [Composer](https://getcomposer.org/): `composer require twbs/bootstrap:5.3.6`
- ติดตั้งด้วย [NuGet](https://www.nuget.org/): CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

อ่าน [หน้าการเริ่มต้นใช้งาน](https://getbootstrap.com/docs/5.3/getting-started/introduction/) เพื่อดูข้อมูลเกี่ยวกับเนื้อหาเฟรมเวิร์ก เทมเพลต ตัวอย่าง และอื่น ๆ


## สถานะ

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## เนื้อหาที่รวมอยู่

ภายในไฟล์ที่ดาวน์โหลด คุณจะพบไดเรกทอรีและไฟล์ดังต่อไปนี้ ซึ่งจัดกลุ่มทรัพยากรร่วมกันอย่างมีเหตุผล และมีทั้งแบบคอมไพล์และแบบบีบอัด

<details>
  <summary>เนื้อหาที่ดาวน์โหลด</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

เรามีไฟล์ CSS และ JS ที่คอมไพล์แล้ว (`bootstrap.*`) รวมถึงไฟล์ CSS และ JS ที่คอมไพล์และบีบอัดแล้ว (`bootstrap.min.*`) [ซอร์สแมป](https://web.dev/articles/source-maps) (`bootstrap.*.map`) พร้อมใช้งานสำหรับเครื่องมือสำหรับนักพัฒนาของเบราว์เซอร์บางตัว ไฟล์ JS แบบ bundled (`bootstrap.bundle.js` และแบบบีบอัด `bootstrap.bundle.min.js`) รวม [Popper](https://popper.js.org/docs/v2/) ไว้ด้วย


## รายงานบั๊กและขอฟีเจอร์

มีบั๊กหรือขอฟีเจอร์ใหม่? กรุณาอ่าน [แนวทางการรายงานปัญหา](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) และค้นหาปัญหาที่มีอยู่หรือปิดแล้วก่อน หากปัญหาหรือไอเดียของคุณยังไม่มี [กรุณาเปิดประเด็นใหม่](https://github.com/twbs/bootstrap/issues/new/choose)


## เอกสาร

เอกสารของ Bootstrap ซึ่งรวมอยู่ใน repo นี้ในไดเรกทอรีหลัก ถูกสร้างด้วย [Astro](https://astro.build/) และเผยแพร่สาธารณะที่ GitHub Pages ที่ <https://getbootstrap.com/> เอกสารสามารถรันแบบโลคัลได้เช่นกัน

ระบบค้นหาเอกสารขับเคลื่อนโดย [DocSearch ของ Algolia](https://docsearch.algolia.com/)

### การรันเอกสารแบบโลคัล

1. รัน `npm install` เพื่อติดตั้ง dependencies ของ Node.js รวมถึง Astro (ตัวสร้างเว็บไซต์)
2. รัน `npm run test` (หรือ npm script อื่น) เพื่อสร้าง CSS และ JavaScript ที่แจกจ่ายใหม่ รวมถึงทรัพยากรของเอกสาร
3. จากไดเรกทอรี `/bootstrap` หลัก รัน `npm run docs-serve` ใน command line
4. เปิด `http://localhost:9001/` ในเบราว์เซอร์ของคุณ

เรียนรู้เพิ่มเติมเกี่ยวกับการใช้งาน Astro ได้โดยอ่าน [เอกสารของ Astro](https://docs.astro.build/en/getting-started/)

### เอกสารสำหรับเวอร์ชันก่อนหน้า

คุณสามารถหาเอกสารของเวอร์ชันก่อนหน้าทั้งหมดได้ที่ <https://getbootstrap.com/docs/versions/>

[เวอร์ชันก่อนหน้า](https://github.com/twbs/bootstrap/releases) และเอกสารของแต่ละเวอร์ชันก็พร้อมดาวน์โหลด


## การมีส่วนร่วม

กรุณาอ่าน [แนวทางการมีส่วนร่วม](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md) ของเรา มีคำแนะนำเกี่ยวกับการเปิดประเด็น มาตรฐานการเขียนโค้ด และหมายเหตุเกี่ยวกับการพัฒนา

นอกจากนี้ หาก pull request ของคุณมีการแก้ไขหรือเพิ่มคุณสมบัติ JavaScript คุณต้องแนบ [unit test ที่เกี่ยวข้อง](https://github.com/twbs/bootstrap/tree/main/js/tests) ด้วย HTML และ CSS ทั้งหมดควรสอดคล้องกับ [Code Guide](https://github.com/mdo/code-guide) ที่ดูแลโดย [Mark Otto](https://github.com/mdo)

การตั้งค่าของ editor มีอยู่ใน [editor config](https://github.com/twbs/bootstrap/blob/main/.editorconfig) เพื่อให้ง่ายต่อการใช้กับ editor ทั่วไป อ่านเพิ่มเติมและดาวน์โหลดปลั๊กอินได้ที่ <https://editorconfig.org/>


## ชุมชน

รับข้อมูลอัปเดตเกี่ยวกับการพัฒนา Bootstrap และพูดคุยกับผู้ดูแลโปรเจกต์และสมาชิกชุมชน

- ติดตาม [@getbootstrap บน X](https://x.com/getbootstrap)
- อ่านและติดตาม [บล็อกทางการของ Bootstrap](https://blog.getbootstrap.com/)
- ถามคำถามและสำรวจ [GitHub Discussions ของเรา](https://github.com/twbs/bootstrap/discussions)
- พูดคุย ถามคำถาม และอื่น ๆ บน [Discord ของชุมชน](https://discord.gg/bZUvakRU3M) หรือ [Bootstrap subreddit](https://www.reddit.com/r/bootstrap/)
- สนทนากับชาว Bootstrappers ใน IRC ที่เซิร์ฟเวอร์ `irc.libera.chat` ในแชนแนล `#bootstrap`
- ขอความช่วยเหลือเรื่องการใช้งานได้ที่ Stack Overflow (ติดแท็ก [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5))
- นักพัฒนาควรใช้คีย์เวิร์ด `bootstrap` กับแพ็กเกจที่ปรับปรุงหรือเพิ่มฟังก์ชันการทำงานของ Bootstrap เมื่อเผยแพร่ผ่าน [npm](https://www.npmjs.com/browse/keyword/bootstrap) หรือเครื่องมือคล้ายกัน เพื่อให้ค้นหาได้ง่าย


## การจัดการเวอร์ชัน

เพื่อความโปร่งใสในรอบการปล่อยเวอร์ชันและรักษาความเข้ากันได้ย้อนหลัง Bootstrap อยู่ภายใต้ [แนวทาง Semantic Versioning](https://semver.org/) บางครั้งเราอาจทำผิดพลาด แต่เราพยายามยึดตามกฎเหล่านั้นทุกครั้งที่ทำได้

ดู [ส่วน Releases ของโปรเจกต์บน GitHub](https://github.com/twbs/bootstrap/releases) เพื่อดู changelog ของแต่ละเวอร์ชัน ประกาศออกเวอร์ชันใหม่ ๆ จะสรุปการเปลี่ยนแปลงสำคัญไว้ใน [บล็อกทางการของ Bootstrap](https://blog.getbootstrap.com/)


## ผู้สร้าง

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## ขอบคุณ

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

ขอขอบคุณ [BrowserStack](https://www.browserstack.com/) ที่ให้โครงสร้างพื้นฐานสำหรับทดสอบกับเบราว์เซอร์จริง!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

ขอขอบคุณ [Netlify](https://www.netlify.com/) ที่ให้บริการ Deploy Previews กับเรา!


## ผู้สนับสนุน

สนับสนุนโปรเจกต์นี้ด้วยการเป็นสปอนเซอร์ โลโก้ของคุณจะแสดงที่นี่พร้อมลิงก์ไปยังเว็บไซต์ของคุณ [[เป็นสปอนเซอร์](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)


## ผู้ให้การสนับสนุน

ขอขอบคุณผู้ให้การสนับสนุนทุกท่าน! 🙏 [[เป็นผู้ให้การสนับสนุน](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## ลิขสิทธิ์และสัญญาอนุญาต

ซอร์สโค้ดและเอกสารสงวนลิขสิทธิ์ 2011-2025 โดย [ผู้เขียน Bootstrap](https://github.com/twbs/bootstrap/graphs/contributors) โค้ดปล่อยภายใต้ [สัญญาอนุญาต MIT](https://github.com/twbs/bootstrap/blob/main/LICENSE) เอกสารปล่อยภายใต้ [Creative Commons](https://creativecommons.org/licenses/by/3.0/)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---