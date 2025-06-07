<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">สร้างคอมโพเนนต์ UI ที่แข็งแกร่งได้รวดเร็วยิ่งขึ้น</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="Build Status on CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="License" />
  </a>
  <br/>
  <a href="https://discord.gg/storybook">
    <img src="https://img.shields.io/badge/discord-join-7289DA.svg?logo=discord&longCache=true&style=flat" />
  </a>
  <a href="https://storybook.js.org/community/">
    <img src="https://img.shields.io/badge/community-join-4BC424.svg" alt="Storybook Community" />
  </a>
  <a href="#backers">
    <img src="https://opencollective.com/storybook/backers/badge.svg" alt="Backers on Open Collective" />
  </a>
  <a href="#sponsors">
    <img src="https://opencollective.com/storybook/tiers/sponsors/badge.svg" alt="Sponsors on Open Collective" />
  </a>
  <a href="https://x.com/intent/follow?screen_name=storybookjs">
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="Official Twitter Handle" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
Storybook คือเวิร์กช็อปสำหรับ Frontend ที่ใช้สร้างคอมโพเนนต์ UI และเพจแบบแยกส่วน ทีมงานนับพันใช้เพื่อพัฒนา UI, ทดสอบ และจัดทำเอกสาร ค้นหาข้อมูลเพิ่มเติมได้ที่ https://storybook.js.org!
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  ดู README สำหรับ:<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## สารบัญ

- 🚀 [เริ่มต้นใช้งาน](#getting-started)
- 📒 [โปรเจกต์](#projects)
  - 🛠 [เฟรมเวิร์กที่รองรับ & ตัวอย่าง](#supported-frameworks)
  - 🔗[แอดออน](#addons)
- 🏅 [เหรียญตรา & วัสดุการนำเสนอ](#badges--presentation-materials)
- 👥 [ชุมชน](#community)
- 👏 [การมีส่วนร่วม](#contributing)
  - 👨‍💻 [สคริปต์สำหรับนักพัฒนา](#development-scripts)
  - 💸 [สปอนเซอร์](#sponsors)
  - 💵 [ผู้สนับสนุน](#backers)
- :memo: [สัญญาอนุญาต](#license)

## เริ่มต้นใช้งาน

เยี่ยมชม [เว็บไซต์ของ Storybook](https://storybook.js.org) เพื่อเรียนรู้เพิ่มเติมและเริ่มต้นใช้งาน

### เอกสารประกอบ

สามารถดูเอกสารได้ที่ [เว็บไซต์เอกสารของ Storybook](https://storybook.js.org/docs)

### ตัวอย่าง

ดู [สารานุกรมคอมโพเนนต์](https://storybook.js.org/showcase) เพื่อดูวิธีที่ทีมงานชั้นนำใช้ Storybook

ใช้ [storybook.new](https://storybook.new) เพื่อสร้างโปรเจกต์ตัวอย่างอย่างรวดเร็วใน Stackblitz

Storybook มาพร้อมกับ [แอดออน](https://storybook.js.org/docs/configure/user-interface/storybook-addons) มากมายสำหรับออกแบบคอมโพเนนต์, จัดทำเอกสาร, ทดสอบ, สร้างการโต้ตอบ ฯลฯ API ของ Storybook ช่วยให้สามารถปรับแต่งและขยายการทำงานได้หลากหลายรูปแบบ และยังรองรับ React Native, Android, iOS และ Flutter สำหรับการพัฒนาโมบายล์อีกด้วย

### ชุมชน

หากต้องการความช่วยเหลือเพิ่มเติม แชร์ปัญหาของคุณใน [GitHub Discussions ของ repo นี้](https://github.com/storybookjs/storybook/discussions/new?category=help)

## โปรเจกต์

### เฟรมเวิร์กที่รองรับ

| Renderer                                                       | ตัวอย่างสาธิต                                                                                                                                                                         |                                                                                                                                                       |
| -------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| [React](code/renderers/react)                                  | [![Storybook demo](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)          | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                          |
| [Angular](code/frameworks/angular/)                            | [![Storybook demo](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)        | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                                  |
| [Vue 3](code/renderers/vue3)                                   | [![Storybook demo](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)           | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                           |
| [Web components](code/renderers/web-components)                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/) | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                       |
| [React Native](https://github.com/storybookjs/react-native)    | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                     | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native)     |
| [HTML](code/renderers/html)                                    | [![Storybook demo](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)           | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                             |
| [Ember](code/frameworks/ember/)                                | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                            | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                        |
| [Svelte](code/renderers/svelte)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)         | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                       |
| [Preact](code/renderers/preact)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)         | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                       |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                    | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik) |
| [SolidJS](https://github.com/storybookjs/solidjs)              | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                           | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)                     |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                           | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                       |

### แอดออน

| แอดออน                                                                    |                                                                            |
| ------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                 | ทดสอบคอมโพเนนต์สำหรับการเข้าถึงของผู้ใช้ใน Storybook                        |
| [actions](code/core/src/actions/)                                         | บันทึกการกระทำเมื่อผู้ใช้โต้ตอบกับคอมโพเนนต์ใน UI ของ Storybook           |
| [backgrounds](code/core/src/backgrounds)                                  | ให้ผู้ใช้เลือกพื้นหลังใน UI ของ Storybook                                   |
| [cssresources](https://github.com/storybookjs/addon-cssresources)         | เพิ่ม/ลบทรัพยากร CSS ไปยัง iframe ของคอมโพเนนต์ได้แบบไดนามิก             |
| [design assets](https://github.com/storybookjs/addon-design-assets)       | ดูรูปภาพ, วิดีโอ และลิงก์เว็บควบคู่กับ story ของคุณ                       |
| [docs](code/addons/docs/)                                                 | เพิ่มเอกสารคุณภาพสูงให้กับคอมโพเนนต์ของคุณ                               |
| [events](https://github.com/storybookjs/addon-events)                     | ส่งอีเวนต์ไปยังคอมโพเนนต์ที่ตอบสนอง EventEmitter ได้อย่างโต้ตอบ           |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics) | รายงาน google analytics บน stories                                         |
| [graphql](https://github.com/storybookjs/addon-graphql)                   | คิวรีเซิร์ฟเวอร์ GraphQL ภายใน Storybook stories                          |
| [jest](code/addons/jest/)                                                 | ดูผลการทดสอบยูนิตของคอมโพเนนต์ใน Storybook                              |
| [links](code/addons/links/)                                               | สร้างลิงก์ระหว่าง stories                                                 |
| [measure](code/core/src/measure/)                                         | ตรวจสอบเลย์เอาต์และ box model ทางภาพใน UI ของ Storybook                    |
| [outline](code/core/src/outline/)                                         | ดีบักเลย์เอาต์และการจัดวาง CSS ทางภาพใน UI ของ Storybook                   |
| [query params](https://github.com/storybookjs/addon-queryparams)          | จำลอง query params                                                         |
| [viewport](code/core/src/viewport/)                                       | เปลี่ยนขนาดแสดงผลและเลย์เอาต์สำหรับคอมโพเนนต์ที่ตอบสนองด้วย Storybook    |

ดู [ตารางรองรับ Addon / Framework](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

เพื่อปรับปรุงประสบการณ์ของคุณอย่างต่อเนื่อง เราอาจเลิกใช้งานหรือถอดแอดออนบางรายการเพื่อสนับสนุนเครื่องมือใหม่และดีกว่า

หากคุณใช้ info/notes เราขอแนะนำให้เปลี่ยนไปใช้ [docs](code/addons/docs/) แทน และ [นี่คือคู่มือ](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons) ที่ช่วยคุณได้

หากคุณใช้ contexts เราขอแนะนำให้เปลี่ยนไปใช้ [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars) และ [นี่คือคู่มือ](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts) ที่ช่วยคุณได้

หากคุณใช้ addon-storyshots เราขอแนะนำให้เปลี่ยนไปใช้ [test-runner ของ Storybook](https://github.com/storybookjs/test-runner) และ [นี่คือคู่มือ](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide) ที่ช่วยคุณได้

## เหรียญตรา & วัสดุการนำเสนอ

เรามีเหรียญตรา! ลิงก์ไปยังตัวอย่าง Storybook ของคุณที่ออนไลน์

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](link to site)
```

หากคุณกำลังมองหาวัสดุสำหรับนำเสนอ Storybook เช่น โลโก้ วิดีโอ หรือสีที่เราใช้ คุณสามารถหาได้ทั้งหมดใน [brand repo ของเรา](https://github.com/storybookjs/brand)

## ชุมชน

- ทวีตผ่าน [@storybookjs](https://x.com/storybookjs)
- เขียนบล็อกที่ [storybook.js.org](https://storybook.js.org/blog/) และ [Medium](https://medium.com/storybookjs)
- แชทบน [Discord](https://discord.gg/storybook)
- วิดีโอและสตรีมที่ [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg)

## การมีส่วนร่วม

ขอต้อนรับทุกการมีส่วนร่วมใน Storybook!

- 📥 Pull request และ 🌟 ดาว ยินดีต้อนรับเสมอ
- อ่าน [คู่มือการมีส่วนร่วม](CONTRIBUTING.md) เพื่อเริ่มต้น
  หรือพบกับเราบน [Discord](https://discord.gg/storybook) เราจะช่วยแนะนำคุณ

กำลังมองหา issue แรกสำหรับเริ่มต้นหรือไม่?

- เราติดป้าย [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) ให้กับ issue ที่เหมาะกับผู้ที่เพิ่งเริ่มต้นกับ codebase หรือ OSS ทั่วไป
- [พูดคุยกับเรา](https://discord.gg/storybook) แล้วเราจะหาเรื่องที่เหมาะกับทักษะและความสนใจในการเรียนรู้ของคุณ

### สคริปต์สำหรับนักพัฒนา

Storybook จัดระเบียบแบบ monorepo สคริปต์ที่มีประโยชน์ ได้แก่:

#### `yarn start`

> รัน Storybook แซนด์บ็อกซ์พร้อม test stories

#### `yarn task`

> เช่นเดียวกับด้านบน แต่ให้ตัวเลือกปรับแต่งแซนด์บ็อกซ์ (เช่น เลือกเฟรมเวิร์กอื่น)

#### `yarn lint`

> ตรวจสอบ boolean ว่าโค้ดเป็นไปตามกฎ linting หรือไม่ - ใช้ remark & eslint

- `yarn lint:js` - ตรวจสอบ js
- `yarn lint:md` - ตรวจสอบ markdown + ตัวอย่างโค้ด
- `yarn lint:js --fix` - แก้ไข js อัตโนมัติ

#### `yarn test`

> ตรวจสอบ boolean ว่ายูนิตเทสต์ทั้งหมดผ่าน - ใช้ jest

- `yarn run test --core --watch` - รัน core tests ในโหมด watch

### สปอนเซอร์

เป็นสปอนเซอร์เพื่อให้โลโก้และ URL เว็บไซต์ของคุณปรากฏใน README ของเราใน Github \[[เป็นสปอนเซอร์](https://opencollective.com/storybook#sponsor)]

<a href="https://opencollective.com/storybook/tiers/sponsors/0/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/0/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/1/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/1/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/2/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/2/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/3/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/3/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/4/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/4/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/5/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/5/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/6/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/6/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/7/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/7/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/8/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/8/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/9/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/9/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/10/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/10/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/11/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/11/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/12/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/12/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/13/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/13/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/14/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/14/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/15/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/15/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/16/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/16/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/17/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/17/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/18/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/18/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/19/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/19/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/20/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/20/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/21/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/21/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/22/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/22/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/23/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/23/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/24/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/24/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/25/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/25/avatar.svg?requireActive=true"></a>

### ผู้สนับสนุน

โดยการบริจาคแบบประจำ คุณสามารถสนับสนุนเราและงานของเราได้ \[[เป็นผู้สนับสนุน](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## สัญญาอนุญาต

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-จบ-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---