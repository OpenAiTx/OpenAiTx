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

Nuxt एक निःशुल्क और मुक्त-स्रोत फ्रेमवर्क है, जो Vue.js के साथ टाइप-सुरक्षित, उच्च प्रदर्शन और प्रोडक्शन-ग्रेड फुल-स्टैक वेब एप्लिकेशन और वेबसाइट बनाने का सहज और विस्तृत तरीका प्रदान करता है।

यह कई ऐसी विशेषताएँ प्रदान करता है, जो तेज़, SEO-अनुकूल और स्केलेबल वेब एप्लिकेशन बनाना आसान बनाती हैं, जैसे कि:
- सर्वर-साइड रेंडरिंग, स्टैटिक साइट जेनरेशन, हाइब्रिड रेंडरिंग और एज-साइड रेंडरिंग
- कोड-स्प्लिटिंग और प्री-फेचिंग के साथ स्वचालित रूटिंग
- डेटा फेचिंग और स्टेट प्रबंधन
- SEO अनुकूलन और मेटा टैग परिभाषा
- कंपोनेंट्स, कॉम्पोज़ेबल्स और यूटिल्स का ऑटो इंपोर्ट
- शून्य कॉन्फ़िगरेशन के साथ टाइपस्क्रिप्ट
- हमारे server/ डाइरेक्टरी के साथ पूर्ण फुलस्टैक बनाएं
- [200+ मॉड्यूल्स](https://nuxt.com/modules) के साथ विस्तार योग्य
- विभिन्न [होस्टिंग प्लेटफार्मों](https://nuxt.com/deploy) पर डिप्लॉयमेंट
- ...[और भी बहुत कुछ](https://nuxt.com) 🚀

### विषय सूची

- 🚀 [शुरुआत करें](#getting-started)
- 💻 [Vue विकास](#vue-development)
- 📖 [दस्तावेज़ीकरण](#documentation)
- 🧩 [मॉड्यूल्स](#modules)
- ❤️  [योगदान दें](#contribute)
- 🏠 [स्थानीय विकास](#local-development)
- 🛟 [पेशेवर सहायता](#professional-support)
- 🔗 [हमारा अनुसरण करें](#follow-us)
- ⚖️ [लाइसेंस](#license)

---

## <a name="getting-started">🚀 शुरुआत करें</a>

नया स्टार्टर प्रोजेक्ट बनाने के लिए निम्नलिखित कमांड का उपयोग करें। यह सभी आवश्यक फ़ाइलों और निर्भरताओं के साथ एक स्टार्टर प्रोजेक्ट बनाएगा:

```bash
npm create nuxt <my-project>
```

> [!TIP]
> [nuxt.new](https://nuxt.new) भी देखें: कुछ ही सेकंड में Nuxt स्टार्टर को CodeSandbox, StackBlitz या लोकली खोलें और शुरू करें।

## <a name="vue-development">💻 Vue विकास</a>

सरल, सहज और शक्तिशाली, Nuxt आपको ऐसे तरीके से Vue कंपोनेंट्स लिखने देता है जो मायने रखता है। प्रत्येक दोहरावदार कार्य स्वचालित हो जाता है, जिससे आप आत्मविश्वास के साथ अपना फुल-स्टैक Vue एप्लिकेशन लिख सकते हैं।

`app.vue` का उदाहरण:

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

## <a name="documentation">📖 दस्तावेज़ीकरण</a>

हम आपको [Nuxt दस्तावेज़ीकरण](https://nuxt.com/docs) देखने की अत्यधिक अनुशंसा करते हैं। यह फ्रेमवर्क के बारे में अधिक जानने के लिए एक शानदार संसाधन है, जिसमें शुरुआत से लेकर उन्नत विषय तक सब कुछ शामिल है।

## <a name="modules">🧩 मॉड्यूल्स</a>

अपने Nuxt प्रोजेक्ट को सुपरचार्ज करने के लिए हमारे [मॉड्यूल्स की सूची](https://nuxt.com/modules) देखें, जिन्हें Nuxt टीम और समुदाय द्वारा बनाया गया है।

## <a name="contribute">❤️ योगदान दें</a>

हम आपको योगदान देने और Nuxt को बेहतर बनाने में मदद करने के लिए आमंत्रित करते हैं 💚

यहाँ कुछ तरीके हैं जिनसे आप शामिल हो सकते हैं:
- **बग रिपोर्ट करना:** यदि आपको कोई बग या समस्या मिलती है, तो कृपया [बग रिपोर्ट गाइड](https://nuxt.com/docs/community/reporting-bugs) देखें और बग रिपोर्ट सबमिट करना सीखें।
- **सुझाव:** Nuxt को बेहतर बनाने के लिए आपके पास विचार हैं? हम उन्हें सुनना पसंद करेंगे! कृपया [योगदान गाइड](https://nuxt.com/docs/community/contribution) देखें और अपने सुझाव साझा करें।
- **प्रश्न:** यदि आपके पास प्रश्न हैं या सहायता चाहिए, तो [सहायता प्राप्त करने गाइड](https://nuxt.com/docs/community/getting-help) में आपको आवश्यक संसाधन मिलेंगे।

## <a name="local-development">🏠 स्थानीय विकास</a>

फ्रेमवर्क और दस्तावेज़ीकरण में योगदान देने के लिए [अपने स्थानीय विकास पर्यावरण को सेट अप करें](https://nuxt.com/docs/community/framework-contribution#setup) की डॉक्स का पालन करें।

## <a name="professional-support">🛟 पेशेवर सहायता</a>

- तकनीकी ऑडिट और परामर्श: [Nuxt Experts](https://nuxt.com/enterprise/support)
- कस्टम विकास और अधिक: [Nuxt Agencies Partners](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 हमारा अनुसरण करें</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ लाइसेंस</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---