<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ओपन-सोर्स, हल्का ट्रेलो विकल्प जो मेकर्स और इंडी हैकर्स के लिए डिज़ाइन किया गया है।

सरलता, गति और स्केलेबिलिटी पर फोकस।
आधुनिक स्टैक के साथ निर्मित: Tailwind CSS, shadcn/ui, Supabase, Stripe एकीकरण।
असीमित प्रोजेक्ट्स, टीम सहयोग, डार्क/लाइट मोड और सहज उपयोगकर्ता अनुभव का समर्थन करता है।
उन एकल डेवलपर्स और छोटी टीमों के लिए आदर्श जो अनावश्यक जटिलता के बिना पूरी नियंत्रण चाहते हैं।

## 🌟 यदि आपको यह प्रोजेक्ट उपयोगी लगे, तो इसे एक स्टार जरूर दें! यह दूसरों को भी इसे खोजने में मदद करता है।

# डिप्लॉयमेंट गाइड

## अवलोकन
यह एप्लिकेशन अब स्ट्राइप एकीकरण के लिए Supabase Edge Functions के बजाय स्थानीय Next.js API रूट्स का उपयोग करता है। इससे डिप्लॉयमेंट सरल हो जाता है और आप कॉन्फ़िगरेशन के लिए मानक .env फ़ाइलों का उपयोग कर सकते हैं।

## पर्यावरण वेरिएबल्स सेटअप

### 1. .env.local फ़ाइल बनाएँ
`.env.example` को `.env.local` में कॉपी करें और अपने वास्तविक मान भरें:


```bash
cp .env.example .env.local
```
### 2. आवश्यक एनवायरनमेंट वेरिएबल्स

#### सुपाबेस कॉन्फ़िगरेशन
- `NEXT_PUBLIC_SUPABASE_URL` - आपका सुपाबेस प्रोजेक्ट URL
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - आपकी सुपाबेस एनॉन की
- `SUPABASE_SERVICE_ROLE_KEY` - आपकी सुपाबेस सर्विस रोल की (सिर्फ सर्वर-साइड)

#### स्ट्राइप कॉन्फ़िगरेशन (वैकल्पिक)
- `STRIPE_SECRET_KEY` - आपकी स्ट्राइप सीक्रेट की (सिर्फ सर्वर-साइड)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - आपकी स्ट्राइप पब्लिशेबल की
- `STRIPE_WEBHOOK_SECRET` - आपकी स्ट्राइप वेबहुक सीक्रेट

#### साइट कॉन्फ़िगरेशन
- `NEXT_PUBLIC_SITE_URL` - आपकी साइट का URL (प्रोडक्शन के लिए)
- `NEXTAUTH_URL` - आपकी साइट का URL (ऊपर जैसा ही)
- `NEXTAUTH_SECRET` - नेक्स्टऑथ के लिए एक रैंडम सीक्रेट

## लोकल डेवलपमेंट

1. डिपेंडेंसीज़ इंस्टॉल करें:

```bash
npm install
```
2. अपनी पर्यावरण वेरिएबल्स को `.env.local` में सेट करें

3. डिवेलपमेंट सर्वर चलाएँ:

```bash
npm run dev
```
4. Stripe CLI का उपयोग करके Stripe वेबहुक्स को स्थानीय रूप से परीक्षण करें:

```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```
## प्रोडक्शन डिप्लॉयमेंट


### वर्सेल डिप्लॉयमेंट

1. **वर्सेल पर डिप्लॉय करें:**

```bash
npx vercel
```
2. **एनवायरनमेंट वेरिएबल्स:**
   सभी एनवायरनमेंट वेरिएबल्स को Vercel डैशबोर्ड या CLI के माध्यम से जोड़ें

3. **Stripe वेबहुक सेटअप:**
   - वेबहुक को इस पर प्वाइंट करें: `https://your-domain.vercel.app/api/stripe/webhook`

## API एंडपॉइंट्स

एप्लिकेशन अब ये लोकल API रूट्स उपयोग करता है:

- `POST /api/stripe/checkout` - Stripe चेकआउट सेशन बनाता है
- `POST /api/stripe/webhook` - Stripe वेबहुक इवेंट्स को संभालता है

## लोकल API रूट्स के लाभ

1. **सरल डिप्लॉयमेंट** - अलग से एज फंक्शंस डिप्लॉय करने की आवश्यकता नहीं
2. **एनवायरनमेंट वेरिएबल्स** - स्टैंडर्ड .env फ़ाइल सपोर्ट
3. **बेहतर डिबगिंग** - लोकली डिबग करना आसान
4. **फ्रेमवर्क इंटीग्रेशन** - Next.js के साथ बेहतर इंटीग्रेशन
5. **नो वेंडर लॉक-इन** - किसी भी प्लेटफ़ॉर्म पर डिप्लॉय कर सकते हैं जो Next.js सपोर्ट करता है

## ट्रबलशूटिंग

1. **वेबहुक समस्याएँ:**
   - सुनिश्चित करें कि `STRIPE_WEBHOOK_SECRET` आपके Stripe वेबहुक एंडपॉइंट से मेल खाता है
   - Stripe डैशबोर्ड में वेबहुक लॉग्स चेक करें
   - सुनिश्चित करें कि वेबहुक URL सही है

2. **एनवायरनमेंट वेरिएबल्स:**
   - सुनिश्चित करें कि सभी आवश्यक वेरिएबल्स सेट हैं
   - वेरिएबल नामों में टाइपो के लिए जांचें
   - सत्यापित करें कि Supabase सर्विस रोल की के पास उचित परमिशन हैं

3. **CORS समस्याएँ:**
   - API रूट्स में उचित CORS हेडर्स शामिल हैं
   - आवश्यकता हो तो अपने डोमेन को श्वेतसूचीबद्ध करें

## सुरक्षा नोट्स

- कभी भी `STRIPE_SECRET_KEY` या `SUPABASE_SERVICE_ROLE_KEY` को क्लाइंट पर एक्सपोज़ न करें
- केवल क्लाइंट-साइड वेरिएबल्स के लिए `NEXT_PUBLIC_` प्रीफिक्स का उपयोग करें
- अपने वेबहुक सीक्रेट्स को नियमित रूप से रोटेट करें
- Stripe डैशबोर्ड में वेबहुक डिलिवरी की निगरानी करें



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---