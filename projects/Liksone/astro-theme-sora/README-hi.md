<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>एक Astro ब्लॉग थीम</p>
<p>Sora का अर्थ है "आकाशगंगा", जो अनंत संभावनाओं और व्यापक रचनात्मकता का प्रतीक है</p>
<p>अगर आपको यह थीम पसंद आए, तो एक 🌟Star दें!</p>
<p><strong>简体中文</strong> | <a href="/README.en.md">English</a></p>
</div>

# पूर्वावलोकन

[My Blog](https://blog.liks.space)

## कौन उपयोग कर रहा है

अपनी वेबसाइट दिखाने के लिए एक [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) प्रस्तुत करने के लिए आपका स्वागत है।

# प्रारंभ करें

1. थीम स्थापित करें

   - [pnpm](https://pnpm.io/installation) स्थापित करें
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - प्रोजेक्ट डायरेक्ट्री में जाएं, और `pnpm dev` चलाकर प्रोजेक्ट शुरू करें

2. थीम कॉन्फ़िगर करें

   थीम को कस्टमाइज़ करने के लिए `theme.config.ts` कॉन्फ़िगरेशन फ़ाइल को संशोधित करें। विवरण के लिए [कॉन्फ़िगरेशन](#配置) देखें।

3. लेख संपादित करें

   `src/content/` डायरेक्ट्री में संपादित करें, Markdown प्रारूप समर्थित है।

4. वेबसाइट डिप्लॉय करें

   `pnpm build` चलाकर वेबसाइट बनाएँ, निर्मित फाइलें `dist/` डायरेक्ट्री में होंगी। लोकल पूर्वावलोकन के लिए `pnpm preview` चला सकते हैं।

   वेबसाइट को स्वयं सर्वर पर डिप्लॉय करें, या [Astro डाक्यूमेंटेशन](https://docs.astro.build/en/guides/deploy/) के अनुसार Vercel, Netlify, GitHub Pages आदि होस्टिंग प्लेटफार्म पर डिप्लॉय करें।

<!-- # दस्तावेज़ -->

# कॉन्फ़िगरेशन

कॉन्फ़िगरेशन फ़ाइल है `theme.config.ts`।

## साइट जानकारी

```typescript
site: {
  // वेबसाइट पता
  url: "https://blog.liks.space",
  // वेबसाइट शीर्षक
  title: "Sora",
  // साइट ओनर का नाम
  author: "Liks",
  // वेबसाइट परिचय
  description: "A blog theme built with Astro",
  // वेबसाइट आइकन
  // SVG, PNG, ICO प्रारूप समर्थित
  // public/ डायरेक्ट्री में स्थानीय फाइल पथ
  favicon: "/images/favicon.ico",
}
```

## वैश्विक सेटिंग्स

```typescript
global: {
  // अवतार
  // src/images/ डायरेक्ट्री में स्थानीय फाइल पथ
  avatar: "avatar.jpg",
  // RSS सक्षम करें
  rss: true,
  // बहुभाषी समर्थन सक्षम करें (विकासाधीन)
  i18n: true,
}
```

## नेविगेशन बार

```typescript
nav: [
  {
    // पृष्ठ नाम
    name: "आर्काइव",
    // पृष्ठ पता
    url: "/archives",
  },
  {
    name: "श्रेणियाँ",
    url: "/categories",
  },
  {
    name: "टैग्स",
    url: "/tags",
  },
  {
    name: "परिचय",
    url: "/about",
  },
  ...
];
```

## फुटर

```typescript
footer: {
  // कॉपीराइट
  copyright: {
    // साइट स्थापित होने का समय
    time: "2024 - 2025",
    // कॉपीराइट ओनर
    owner: "Liks",
  },
  //备案 (केवल चीन के लिए)
  beian: {
    // ICP备案
    icp: {
      // सक्षम करें
      enabled: false,
      //备案 संख्या
      number: "京 ICP 备 12345678 号",
    },
    // पुलिस备案
    police: {
      // सक्षम करें
      enabled: false,
      //备案 संख्या
      number: "京公网安备 12345678901234 号",
      //备案 वेबसाइट
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## मुखपृष्ठ

```typescript
index: {
  // सोशल मीडिया
  social: [
    {
      // नाम
      name: "GitHub",
      // सक्षम करें
      enabled: true,
      // वेबसाइट
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, Xiaohongshu, Zhihu समर्थित हैं।

## लेख पृष्ठ

```typescript
post: {
  // कॉपीराइट लाइसेंस
  copyright: {
    // CC लाइसेंस
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // लाइसेंस वेबसाइट
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## स्पॉन्सर

```typescript
sponsor: {
  // सक्षम करें
  enabled: true,
  // Alipay QR कोड
  alipay: {
    // सक्षम करें
    enabled: true,
    // src/images/ डायरेक्ट्री में स्थानीय फाइल पथ
    image: "alipay.png",
  },
  // WeChat QR कोड
  wechat: {
    enabled: false,
  },
  // प्रायोजकों की सूची दिखाएँ
  list: true,
```
}
```

## टिप्पणी

```typescript
comment: {
  // सक्षम करें
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // बैकएंड सर्वर पता
    server: "https://artalk.example.com",
    // साइट नाम
    site: "Sora",
  },
}
```

## उपकरण

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // सक्षम करें
    enabled: false,
    // सर्वर पता
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# लाइसेंस

[GNU General Public License v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# आभार

- [Pedro-null/halo-theme-hingle2.0](https://github.com/Pedro-null/halo-theme-hingle2.0)
- [Aziteee/halo-theme-lapis](https://github.com/Aziteee/halo-theme-lapis)
- [纸鹿摸鱼处](https://blog.zhilu.cyou/)
- [HowieHz/halo-theme-higan-hz](https://github.com/HowieHz/halo-theme-higan-hz)
- [saicaca/fuwari](https://github.com/saicaca/fuwari)
- [radishzzz/astro-theme-retypeset](https://github.com/radishzzz/astro-theme-retypeset)
- [EveSunMaple/Frosti](https://github.com/EveSunMaple/Frosti)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---