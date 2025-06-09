# ⚡ Sink

**ตัวช่วยย่อ URL ที่ง่าย / เร็ว / ปลอดภัย พร้อมระบบวิเคราะห์ข้อมูล ทำงาน 100% บน Cloudflare**

<a href="https://trendshift.io/repositories/10421" target="_blank">
  <img
    src="https://trendshift.io/api/badge/repositories/10421"
    alt="ccbikai/Sink | Trendshift"
    width="250"
    height="55"
  />
</a>
<a href="https://news.ycombinator.com/item?id=40843683" target="_blank">
  <img
    src="https://hackernews-badge.vercel.app/api?id=40843683"
    alt="Featured on Hacker News"
    width="250"
    height="55"
  />
</a>
<a href="https://hellogithub.com/repository/57771fd91d1542c7a470959b677a9944" target="_blank">
  <img
    src="https://abroad.hellogithub.com/v1/widgets/recommend.svg?rid=57771fd91d1542c7a470959b677a9944&claim_uid=qi74Zp23wYKeAVB&theme=neutral"
    alt="Featured｜HelloGitHub"
    width="250"
    height="55"
  />
</a>
<a href="https://www.uneed.best/tool/sink" target="_blank">
  <img
    src="https://www.uneed.best/POTW1.png"
    alt="Uneed Badge"
    width="250"
    height="55"
  />
</a>

[<img src="https://devin.ai/assets/deepwiki-badge.png" alt="DeepWiki" height="20"/>](https://deepwiki.com/ccbikai/Sink)
![Cloudflare](https://img.shields.io/badge/Cloudflare-F69652?style=flat&logo=cloudflare&logoColor=white)
![Nuxt](https://img.shields.io/badge/Nuxt-00DC82?style=flat&logo=nuxtdotjs&logoColor=white)
![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-06B6D4?style=flat&logo=tailwindcss&logoColor=white)
![shadcn/ui](https://img.shields.io/badge/shadcn/ui-000000?style=flat&logo=shadcnui&logoColor=white)

![Hero](https://raw.githubusercontent.com/ccbikai/Sink/master/public/image.png)

----

## ✨ ฟีเจอร์

- **ย่อ URL:** ย่อ URL ของคุณให้สั้นที่สุด
- **วิเคราะห์ข้อมูล:** ตรวจสอบและเก็บสถิติลิงก์
- **ไร้เซิร์ฟเวอร์:** ติดตั้งได้โดยไม่ต้องใช้เซิร์ฟเวอร์แบบดั้งเดิม
- **Slug กำหนดเอง:** รองรับการตั้งชื่อ slug และแยกตัวพิมพ์เล็ก/ใหญ่
- **🪄 AI Slug:** ใช้ AI ในการสร้าง slug
- **ลิงก์หมดอายุ:** กำหนดวันหมดอายุของลิงก์ได้

## 🪧 เดโม

ทดลองใช้งานเดโมที่ [Sink.Cool](https://sink.cool/dashboard) เข้าสู่ระบบด้วย Site Token ด้านล่างนี้:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>ภาพหน้าจอ</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 เทคโนโลยีที่ใช้

- **เฟรมเวิร์ก**: [Nuxt](https://nuxt.com/)
- **ฐานข้อมูล**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **เอนจินวิเคราะห์ข้อมูล**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **คอมโพเนนต์ UI**: [shadcn-vue](https://www.shadcn-vue.com/)
- **สไตล์:** [Tailwind CSS](https://tailwindcss.com/)
- **ดีพลอย:** [Cloudflare](https://www.cloudflare.com/)

## 🚗 Roadmap [กำลังดำเนินการ]

ยินดีต้อนรับทุกการมีส่วนร่วมและ PR ของคุณ

- [x] ส่วนขยายเบราว์เซอร์
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] ส่วนขยาย Raycast
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Apple Shortcuts
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] แอป iOS
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] การจัดการลิงก์ขั้นสูง (กับ Cloudflare D1)
- [ ] การพัฒนาระบบวิเคราะห์ข้อมูล (รองรับการรวมเงื่อนไขตัวกรอง)
- [ ] ปรับปรุงประสิทธิภาพแดชบอร์ด (โหลดแบบไร้ขีดจำกัด)
- [ ] การทดสอบยูนิต

## 🏗️ การติดตั้ง

> วิดีโอสอน: [ชมที่นี่](https://www.youtube.com/watch?v=MkU23U2VE9E)

ขณะนี้รองรับการติดตั้งกับ [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (แนะนำ) และ [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md)

## ⚒️ การตั้งค่า

[เอกสารการตั้งค่า](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[เอกสาร API](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

ขณะนี้ยังไม่รองรับ MCP Server โดยตรง แต่มีเอกสาร OpenAPI และสามารถใช้วิธีต่อไปนี้เพื่อรองรับ MCP

> เปลี่ยนชื่อโดเมนใน `OPENAPI_SPEC_URL` เป็นโดเมนของคุณเอง  
>
> `API_KEY` จะเหมือนกับ `NUXT_SITE_TOKEN` ที่ตั้งไว้ใน environment variables

```json
{
  "mcpServers": {
    "sink": {
      "command": "uvx",
      "args": [
        "mcp-openapi-proxy"
      ],
      "env": {
        "OPENAPI_SPEC_URL": "https://sink.cool/_docs/openapi.json",
        "API_KEY": "SinkCool",
        "TOOL_WHITELIST": "/api/link/create"
      }
    }
  }
}
```

## 🙋🏻 คำถามที่พบบ่อย

[คำถามที่พบบ่อย](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/faqs.md)

## 💖 เครดิต

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ สนับสนุน

1. [ติดตามฉันบน X (Twitter)](https://404.li/kai)
2. [เป็นผู้สนับสนุนบน GitHub](https://github.com/sponsors/ccbikai)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---