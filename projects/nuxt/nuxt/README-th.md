[![Nuxt banner](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Version"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Downloads"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="License"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Website"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Nuxt openssf scorecard score"></a>
</p>

Nuxt คือเฟรมเวิร์กแบบโอเพนซอร์สและฟรี ที่ให้วิธีการที่เข้าใจง่ายและขยายได้ ในการสร้างแอปพลิเคชันเว็บแบบฟูลสแตกและเว็บไซต์ด้วย Vue.js ที่มีความปลอดภัยของชนิดข้อมูล (type-safe), ประสิทธิภาพสูง และพร้อมใช้งานในระดับโปรดักชัน

Nuxt มาพร้อมกับฟีเจอร์ต่าง ๆ ที่ช่วยให้คุณสร้างเว็บแอปพลิเคชันที่รวดเร็ว เป็นมิตรกับ SEO และรองรับการขยายตัวได้อย่างง่ายดาย เช่น:
- การเรนเดอร์ฝั่งเซิร์ฟเวอร์, การสร้างเว็บไซต์แบบสถิต, การเรนเดอร์แบบไฮบริด และ Edge-Side Rendering
- ระบบกำหนดเส้นทางอัตโนมัติพร้อม code-splitting และ pre-fetching
- การดึงข้อมูลและการจัดการสถานะ
- การปรับแต่ง SEO และการกำหนด Meta tags
- การนำเข้าอัตโนมัติของ components, composables และ utils
- รองรับ TypeScript โดยไม่ต้องตั้งค่าใดๆ
- สู่ฟูลสแตกเต็มรูปแบบด้วย server/ directory ของเรา
- ขยายได้ด้วย [โมดูลมากกว่า 200+ รายการ](https://nuxt.com/modules)
- รองรับการ deploy ไปยัง [แพลตฟอร์มโฮสติ้งต่างๆ](https://nuxt.com/deploy)
- ...[และอื่นๆ อีกมากมาย](https://nuxt.com) 🚀

### สารบัญ

- 🚀 [เริ่มต้นใช้งาน](#getting-started)
- 💻 [พัฒนา Vue](#vue-development)
- 📖 [เอกสารประกอบ](#documentation)
- 🧩 [โมดูล](#modules)
- ❤️  [มีส่วนร่วม](#contribute)
- 🏠 [พัฒนาแบบ Local](#local-development)
- 🛟 [การสนับสนุนระดับมืออาชีพ](#professional-support)
- 🔗 [ติดตามเรา](#follow-us)
- ⚖️ [สัญญาอนุญาต](#license)

---

## <a name="getting-started">🚀 เริ่มต้นใช้งาน</a>

ใช้คำสั่งต่อไปนี้เพื่อสร้างโปรเจกต์เริ่มต้นใหม่ ซึ่งจะสร้างโปรเจกต์เริ่มต้นพร้อมไฟล์และ dependencies ที่จำเป็นทั้งหมด:

```bash
npm create nuxt <my-project>
```

> [!TIP]
> ค้นพบ [nuxt.new](https://nuxt.new) ด้วย: เปิด Nuxt starter บน CodeSandbox, StackBlitz หรือในเครื่องของคุณ เพื่อเริ่มต้นได้ในไม่กี่วินาที

## <a name="vue-development">💻 พัฒนา Vue</a>

ใช้งานง่าย เข้าใจได้ และทรงพลัง Nuxt ให้คุณเขียน Vue components ได้อย่างเป็นธรรมชาติ งานซ้ำซ้อนจะถูกจัดการให้อัตโนมัติ คุณจึงสามารถโฟกัสกับการเขียนแอปพลิเคชัน Vue ฟูลสแตกได้อย่างมั่นใจ

ตัวอย่าง `app.vue`:

```vue
<script setup lang="ts">
useSeoMeta({
  title: 'Meet Nuxt',
  description: 'The Intuitive Vue Framework.'
})
</script>

<template>
  <div id="app">
    <AppHeader />
    <NuxtPage />
    <AppFooter />
  </div>
</template>

<style scoped>
#app {
  background-color: #020420;
  color: #00DC82;
}
</style>
```

## <a name="documentation">📖 เอกสารประกอบ</a>

ขอแนะนำให้คุณศึกษาที่ [เอกสาร Nuxt](https://nuxt.com/docs) เพื่อเพิ่มทักษะของคุณ เป็นแหล่งข้อมูลที่ยอดเยี่ยมสำหรับเรียนรู้เพิ่มเติมเกี่ยวกับเฟรมเวิร์กนี้ ครอบคลุมทุกอย่างตั้งแต่การเริ่มต้นจนถึงหัวข้อขั้นสูง

## <a name="modules">🧩 โมดูล</a>

ค้นพบ [รายชื่อโมดูล](https://nuxt.com/modules) ของเราเพื่อเสริมพลังให้โปรเจกต์ Nuxt ของคุณ สร้างโดยทีมงาน Nuxt และชุมชน

## <a name="contribute">❤️ มีส่วนร่วม</a>

เราขอเชิญคุณมามีส่วนร่วมและช่วยพัฒนา Nuxt ให้ดียิ่งขึ้น 💚

คุณสามารถมีส่วนร่วมได้หลายวิธี:
- **รายงานบั๊ก:** หากคุณพบปัญหาหรือบั๊ก กรุณาศึกษา [คู่มือรายงานบั๊ก](https://nuxt.com/docs/community/reporting-bugs) เพื่อเรียนรู้วิธีส่งรายงาน
- **แนะนำ:** มีไอเดียพัฒนา Nuxt ใช่ไหม? เรายินดีรับฟัง! ดู [คู่มือการมีส่วนร่วม](https://nuxt.com/docs/community/contribution) เพื่อแบ่งปันข้อเสนอแนะของคุณ
- **คำถาม:** หากคุณมีคำถามหรือต้องการความช่วยเหลือ [คู่มือขอความช่วยเหลือ](https://nuxt.com/docs/community/getting-help) มีแหล่งข้อมูลให้คุณ

## <a name="local-development">🏠 พัฒนาแบบ Local</a>

ปฏิบัติตามเอกสารเพื่อ [ตั้งค่าสภาพแวดล้อมการพัฒนา Local ของคุณ](https://nuxt.com/docs/community/framework-contribution#setup) เพื่อมีส่วนร่วมกับเฟรมเวิร์กและเอกสาร

## <a name="professional-support">🛟 การสนับสนุนระดับมืออาชีพ</a>

- ตรวจสอบเทคนิค & ที่ปรึกษา: [Nuxt Experts](https://nuxt.com/enterprise/support)
- พัฒนาแบบกำหนดเอง & อื่นๆ: [Nuxt Agencies Partners](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 ติดตามเรา</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ สัญญาอนุญาต</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---