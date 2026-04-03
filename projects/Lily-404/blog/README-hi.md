
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

# जिमी का ब्लॉग

Next.js 15+ पर आधारित एक सरल व्यक्तिगत ब्लॉग सिस्टम, जो ऑनलाइन लेखन और स्थैतिक डिप्लॉयमेंट का समर्थन करता है।

## तकनीकी स्टैक

- **फ्रेमवर्क**: Next.js 15+ (ऐप राउटर)
- **भाषा**: TypeScript
- **स्टाइल**: Tailwind CSS
- **आइकन**: Lucide Icons
- **सामग्री**: Markdown + Gray Matter + Remark
- **प्रमाणीकरण**: GitHub OAuth
- **परिनियोजन**: Vercel

## फीचर विशेषताएँ

### पाठक पक्ष

- 📝 Markdown + GFM लेख रेंडरिंग (गणितीय सूत्र प्रदर्शन सहित)
- 🏷️ टैग फ़िल्टरिंग, पेजिनेशन, संग्रह (वर्ष/टैग के अनुसार)
- 📚 लेख सूची नेविगेशन (TOC) एवं कोड ब्लॉक की एक-क्लिक कॉपी
- 📱 उत्तरदायी लेआउट एवं गहरा/हल्का थीम स्विच
- 🔥 तैरता रचनात्मक कैलेंडर हीटमैप (लेख + नोट्स)
- 📡 RSS सदस्यता आउटपुट (`/rss.xml`)

### रचनात्मक पक्ष (प्रबंधन डैशबोर्ड)

- 🔐 GitHub OAuth लॉगिन (मालिक/सहयोगी अधिकार जांच)
- ✍️ लेख/नोट्स ऑनलाइन निर्माण, संपादन, हटाना
- 🆔 कस्टम फ़ाइल ID + स्वतः टकराव बचाव
- 👀 संपादन / पूर्वावलोकन / स्प्लिट स्क्रीन तीन लेखन मोड
- 📊 रचनात्मक सांख्यिकी पैनल (कुल, सप्ताह/माह उत्पादन, लोकप्रिय टैग)

### इंजीनियरिंग पक्ष

- ⚡ बहु-पृष्ठ स्थैतिक आउटपुट (`force-static`) प्रदर्शन एवं स्थिरता बढ़ाने के लिए
- 🧭 इनबिल्ट sitemap और robots
- 🧩 सामग्री पढ़ने की कैशिंग और मॉड्यूलर API संरचना

## परियोजना संरचना

```
.
├── app/               # 页面、API 路由、Server Actions
│   ├── api/           # 接口（OAuth、统计、校验、Markdown 等）
│   ├── actions/       # 内容管理相关服务端动作
│   ├── posts/         # 文章详情页
│   └── page.tsx       # 首页
├── content/
│   ├── notes/         # 随笔
│   └── posts/         # 文章
├── components/        # React 组件
├── public/            # 静态资源
└── styles/            # 全局样式
```

## इंस्टॉल और रन करें

1. प्रोजेक्ट क्लोन करें

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. निर्भरता स्थापित करें

```bash
npm install
```
3. डेवलपमेंट सर्वर चलाएँ


```bash
npm run dev
```

4. उत्पादन संस्करण का निर्माण

```bash
npm run build
```

## नई लेख जोड़ना

### तरीका 1: ऑनलाइन प्रबंधन बैकएंड (सिफारिश)

1. `/admin` पृष्ठ पर जाएं
2. GitHub OAuth का उपयोग करके लॉगिन करें
3. लेख की जानकारी भरें और सबमिट करें
4. लेख अपने आप GitHub API के माध्यम से बनेगा, Vercel अपने आप पुनः डिप्लॉय करेगा

### तरीका 2: फ़ाइल को मैन्युअल रूप से जोड़ना

1. `content/posts` डायरेक्ट्री में एक नया Markdown फ़ाइल बनाएं
2. फ़ाइल नाम का प्रारूप: `xxx.md`
3. फ़ाइल के शुरू में मेटाडेटा जोड़ें:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## नई नोट जोड़ें

1. `content/notes` निर्देशिका में नया Markdown फ़ाइल बनाएं
2. फ़ाइल नामकरण प्रारूप: `YYYY-MM-DD-title.md`
3. फ़ाइल के शीर्ष भाग में मेटाडेटा जोड़ें:

```markdown
---
date: YYYY-MM-DD
---
```

## प्रबंधन बैकएंड को कॉन्फ़िगर करें

प्रबंधन बैकएंड GitHub OAuth का उपयोग करके पहचान सत्यापन करता है, केवल रिपॉजिटरी के मालिक या सहयोगी ही एक्सेस कर सकते हैं।

### 1. GitHub OAuth App बनाएं

1. [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers) पर जाएं
2. "New OAuth App" पर क्लिक करें
3. जानकारी भरें:
   - **Application name**: `Jimmy Blog Admin` (या कोई भी नाम)
   - **Homepage URL**: `https://आपका-डोमेन.com` (प्रोडक्शन) या `http://localhost:3000` (स्थानीय विकास)
   - **Authorization callback URL**: 
     - प्रोडक्शन: `https://आपका-डोमेन.com/api/auth/github/callback`
     - स्थानीय विकास: `http://localhost:3000/api/auth/github/callback`
4. "Register application" पर क्लिक करें
5. **Client ID** नोट करें
6. "Generate a new client secret" पर क्लिक करें, **Client secret** नोट करें

### 2. पर्यावरण वेरिएबल्स कॉन्फ़िगर करें

Vercel प्रोजेक्ट सेटिंग्स में नीचे दिए गए पर्यावरण वेरिएबल्स जोड़ें:

- `GITHUB_CLIENT_ID`: आपका GitHub OAuth App Client ID
- `GITHUB_CLIENT_SECRET`: आपका GitHub OAuth App Client Secret
- `GITHUB_OWNER`: GitHub यूज़रनेम (डिफ़ॉल्ट: `Lily-404`, उपयोगकर्ता अनुमतियों के लिए)
- `GITHUB_REPO`: रिपॉजिटरी नाम (डिफ़ॉल्ट: `blog`)
- `GITHUB_REDIRECT_URI`: OAuth callback URL (वैकल्पिक, डिफ़ॉल्ट स्वतः जनरेट)
- `NEXT_PUBLIC_BASE_URL`: आपकी वेबसाइट URL (callback URL के लिए, प्रोडक्शन में आवश्यक)
  - प्रोडक्शन: `https://www.jimmy-blog.top`
  - स्थानीय विकास: `http://localhost:3000`

### 3. स्थानीय विकास कॉन्फ़िगरेशन

प्रोजेक्ट की रूट डायरेक्टरी में `.env.local` फ़ाइल बनाएं:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. उत्पादन वातावरण विन्यास (Vercel)

Vercel परियोजना सेटिंग्स में, सुनिश्चित करें कि आपने सेट किया है:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```
⚠️ **ध्यान दें**:
- `.env.local` फ़ाइल को `.gitignore` में जोड़ दिया गया है, यह Git में सबमिट नहीं होगी
- स्थानीय विकास के समय, OAuth App की callback URL को `http://localhost:3000/api/auth/github/callback` पर सेट करना सुनिश्चित करें
- **प्रोडक्शन वातावरण में `NEXT_PUBLIC_BASE_URL` को `https://www.jimmy-blog.top` पर सेट करना आवश्यक है**
- प्रोडक्शन वातावरण में OAuth App callback URL को इस प्रकार सेट करें: `https://www.jimmy-blog.top/api/auth/github/callback`

## डिप्लॉयमेंट

प्रोजेक्ट Vercel डिप्लॉयमेंट के लिए कॉन्फ़िगर किया गया है, ऑटोमैटिक डिप्लॉयमेंट सपोर्ट करता है। बस कोड को GitHub रिपॉजिटरी में पुश करें, Vercel ऑटोमैटिकली बिल्ड और डिप्लॉय कर देगा।

### एडमिन पैनल इस्तेमाल करने के फायदे

- ✅ स्थानीय डेवेलपमेंट एनवायरनमेंट की ज़रूरत नहीं
- ✅ कहीं भी, कभी भी लेख जोड़ सकते हैं
- ✅ Vercel को ऑटोमैटिक री-डिप्लॉयमेंट ट्रिगर करें
- ✅ पूरी तरह फ्री (GitHub OAuth और Vercel दोनों फ्री लिमिट में)
- ✅ सुरक्षित (GitHub OAuth वेरिफिकेशन, केवल रिपॉजिटरी ओनर/कोलैबोरेटर एक्सेस कर सकते हैं)
- ✅ पासवर्ड मैनेज करने की ज़रूरत नहीं, GitHub अकाउंट से लॉगिन करें
- ✅ मौजूदा कंटेंट को ऑनलाइन एडिट करने की सुविधा (सिर्फ नया नहीं)
- ✅ फ़ाइल ID टकराव को ऑटोमैटिक हैंडल करता है, ओवरराइट और मैन्युअल रीनेम से बचाता है
- ✅ पैनल में क्रिएशन स्टैट्स मौजूद हैं, कंटेंट ऑपरेशन के लिए सुविधाजनक

## प्रोजेक्ट विश्लेषण और भविष्य की योजना

- प्रोजेक्ट विश्लेषण दस्तावेज़: [`docs/project-analysis.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/project-analysis.md)
- भविष्य योजना दस्तावेज़: [`docs/future-roadmap.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/future-roadmap.md)

## योगदान

Issue और Pull Request सबमिट करने का स्वागत है!

## लाइसेंस

MIT लाइसेंस



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---