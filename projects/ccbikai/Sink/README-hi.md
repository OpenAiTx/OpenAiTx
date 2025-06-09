# ⚡ Sink

**एक सरल / तेज़ / सुरक्षित लिंक शॉर्टनर एनालिटिक्स के साथ, 100% क्लाउडफ्लेयर पर चलता है।**

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

## ✨ विशेषताएँ

- **यूआरएल शॉर्टनिंग:** अपने यूआरएल को न्यूनतम लंबाई में संक्षिप्त करें।
- **एनालिटिक्स:** लिंक एनालिटिक्स की निगरानी करें और महत्वपूर्ण आँकड़े प्राप्त करें।
- **सर्वरलेस:** पारंपरिक सर्वरों की आवश्यकता के बिना डिप्लॉय करें।
- **कस्टमाइज़ेबल स्लग:** पर्सनलाइज़्ड स्लग और केस सेंसिटिविटी का समर्थन।
- **🪄 एआई स्लग:** स्लग बनाने के लिए एआई का उपयोग करें।
- **लिंक एक्सपायरेशन:** अपने लिंक के लिए समाप्ति तिथि सेट करें।

## 🪧 डेमो

[Sink.Cool](https://sink.cool/dashboard) पर डेमो का अनुभव करें। नीचे दिए गए साइट टोकन से लॉगिन करें:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>स्क्रीनशॉट्स</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 प्रयुक्त तकनीक

- **फ्रेमवर्क**: [Nuxt](https://nuxt.com/)
- **डेटाबेस**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **एनालिटिक्स इंजन**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **यूआई कंपोनेंट्स**: [shadcn-vue](https://www.shadcn-vue.com/)
- **स्टाइलिंग:** [Tailwind CSS](https://tailwindcss.com/)
- **डिप्लॉयमेंट**: [Cloudflare](https://www.cloudflare.com/)

## 🚗 रोडमैप [WIP]

हम आपके योगदान और पीआर का स्वागत करते हैं।

- [x] ब्राउज़र एक्सटेंशन
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Raycast एक्सटेंशन
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] एप्पल शॉर्टकट्स
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] iOS ऐप
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] बेहतर लिंक प्रबंधन (Cloudflare D1 के साथ)
- [ ] एनालिटिक्स सुधार (फिल्टर कंडीशन्स को मर्ज करने का समर्थन)
- [ ] डैशबोर्ड प्रदर्शन अनुकूलन (अनंत लोडिंग)
- [ ] यूनिट टेस्ट

## 🏗️ डिप्लॉयमेंट

> वीडियो ट्यूटोरियल: [यहाँ देखें](https://www.youtube.com/watch?v=MkU23U2VE9E)

हम वर्तमान में [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (अनुशंसित) और [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md) पर डिप्लॉयमेंट का समर्थन करते हैं।

## ⚒️ कॉन्फ़िगरेशन

[कॉन्फ़िगरेशन डॉक्स](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 एपीआई

[API डॉक्स](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

हम वर्तमान में नेटिव MCP सर्वर का समर्थन नहीं करते, लेकिन हमारे पास OpenAPI डॉक्स हैं, और आप निम्न विधि का उपयोग करके MCP का समर्थन कर सकते हैं।

> `OPENAPI_SPEC_URL` में डोमेन नाम को अपने डोमेन नाम से बदलें।
>
> `API_KEY` वही है जो पर्यावरण वेरिएबल्स में `NUXT_SITE_TOKEN` है।

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

## 🙋🏻 अक्सर पूछे जाने वाले प्रश्न

[FAQs](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/faqs.md)

## 💖 क्रेडिट्स

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ प्रायोजक

1. [मुझे X(Twitter) पर फॉलो करें](https://404.li/kai)।
2. [GitHub पर प्रायोजक बनें](https://github.com/sponsors/ccbikai)।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---