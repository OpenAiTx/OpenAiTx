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

<div align="center">
  <br />
<br />
<a href="https://kanba.co">
  <img alt="Kanba" src="https://www.kanba.co/dark-hero.png" style=" width: 800px " />
</a>
    <br />
<br />
</div>

<div align="center">
  <br />
<br />
<a href="https://vercel.com/oss">
  <img alt="Vercel OSS Program" src="https://vercel.com/oss/program-badge.svg" />
</a>
    <br />
<br />
</div>
# ओपन-सोर्स, हल्का Trello विकल्प, जो मेकर्स और इंडी हैकर्स के लिए डिज़ाइन किया गया है।

सरलता, गति और स्केलेबिलिटी पर फोकस।
आधुनिक स्टैक के साथ निर्मित: Tailwind CSS, shadcn/ui, Supabase, Stripe एकीकरण।
असीमित प्रोजेक्ट्स, टीम सहयोग, डार्क/लाइट मोड और सहज यूजर अनुभव को सपोर्ट करता है।
उन सोलो डेव्स और छोटी टीमों के लिए उत्तम जो बिना अनावश्यक जटिलता के पूर्ण नियंत्रण चाहते हैं।

## 🌟 यदि आपको यह प्रोजेक्ट उपयोगी लगे, तो इसे एक स्टार दें! यह दूसरों को भी खोजने में मदद करता है।

# डिप्लॉयमेंट गाइड

## अवलोकन
यह एप्लिकेशन अब Stripe एकीकरण के लिए Supabase Edge Functions के बजाय स्थानीय Next.js API रूट्स का उपयोग करता है। इससे डिप्लॉयमेंट आसान हो जाता है और आप कॉन्फ़िगरेशन के लिए सामान्य .env फाइलें इस्तेमाल कर सकते हैं।

## पर्यावरण वेरिएबल्स सेटअप

### 1. .env.local फाइल बनाएं
`.env.example` को कॉपी कर `.env.local` में बदलें और अपनी वास्तविक वैल्यू भरें:


```bash
cp .env.example .env.local
```

### 2. आवश्यक परिवेश वेरिएबल्स

#### सुपाबेस कॉन्फ़िगरेशन
- `NEXT_PUBLIC_SUPABASE_URL` - आपका सुपाबेस प्रोजेक्ट URL
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - आपकी सुपाबेस अनोन कुंजी
- `SUPABASE_SERVICE_ROLE_KEY` - आपकी सुपाबेस सर्विस रोल कुंजी (सिर्फ सर्वर-साइड)

#### स्ट्राइप कॉन्फ़िगरेशन (वैकल्पिक)
- `STRIPE_SECRET_KEY` - आपकी स्ट्राइप सीक्रेट कुंजी (सिर्फ सर्वर-साइड)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - आपकी स्ट्राइप प्रकाशित करने योग्य कुंजी
- `STRIPE_WEBHOOK_SECRET` - आपकी स्ट्राइप वेबहुक सीक्रेट

#### साइट कॉन्फ़िगरेशन
- `NEXT_PUBLIC_SITE_URL` - आपकी साइट का URL (प्रोडक्शन के लिए)
- `NEXTAUTH_URL` - आपकी साइट का URL (ऊपर जैसा ही)
- `NEXTAUTH_SECRET` - NextAuth के लिए एक रैंडम सीक्रेट

## स्थानीय विकास

1. निर्भरता इंस्टॉल करें:
```bash
npm install
```

2. अपनी पर्यावरण वेरिएबल्स को `.env.local` में सेट करें

3. डेवलपमेंट सर्वर चलाएँ:
```bash
npm run dev
```

4. Stripe CLI का उपयोग करके स्थानीय रूप से Stripe वेबहुक का परीक्षण करें:
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## उत्पादन डिप्लॉयमेंट


### वर्सेल डिप्लॉयमेंट

1. **वर्सेल पर डिप्लॉय करें:**
```bash
npx vercel
```
2. **एनवायरनमेंट वेरिएबल्स:**
   सभी एनवायरनमेंट वेरिएबल्स को Vercel डैशबोर्ड या CLI के माध्यम से जोड़ें

3. **Stripe वेबहुक सेटअप:**
   - वेबहुक को इस पर पॉइंट करें: `https://your-domain.vercel.app/api/stripe/webhook`

## API एंडपॉइंट्स

एप्लिकेशन अब ये लोकल API रूट्स उपयोग करता है:

- `POST /api/stripe/checkout` - Stripe चेकआउट सेशन्स बनाता है
- `POST /api/stripe/webhook` - Stripe वेबहुक ईवेंट्स को संभालता है

## लोकल API रूट्स के लाभ

1. **सरल डिप्लॉयमेंट** - अलग से एज फंक्शन्स डिप्लॉय करने की जरूरत नहीं
2. **एनवायरनमेंट वेरिएबल्स** - स्टैण्डर्ड .env फाइल सपोर्ट
3. **बेहतर डिबगिंग** - लोकली डिबग करना आसान
4. **फ्रेमवर्क इंटीग्रेशन** - Next.js के साथ बेहतर इंटीग्रेशन
5. **कोई वेंडर लॉक-इन नहीं** - किसी भी प्लेटफार्म पर डिप्लॉय कर सकते हैं जो Next.js को सपोर्ट करता है

## समस्या निवारण

1. **वेबहुक समस्याएँ:**
   - सुनिश्चित करें कि `STRIPE_WEBHOOK_SECRET` आपके Stripe वेबहुक एंडपॉइंट से मेल खाता है
   - Stripe डैशबोर्ड में वेबहुक लॉग्स देखें
   - वेबहुक URL सही है, यह सत्यापित करें

2. **एनवायरनमेंट वेरिएबल्स:**
   - सुनिश्चित करें कि सभी आवश्यक वेरिएबल्स सेट हैं
   - वेरिएबल नामों में टाइपो की जाँच करें
   - सत्यापित करें कि Supabase सर्विस रोल कुंजी के पास उचित अनुमति है

3. **CORS समस्याएँ:**
   - API रूट्स में उचित CORS हेडर शामिल हैं
   - यदि आवश्यक हो तो सुनिश्चित करें कि आपका डोमेन श्वेतसूची में है

## सुरक्षा नोट्स

- कभी भी `STRIPE_SECRET_KEY` या `SUPABASE_SERVICE_ROLE_KEY` को क्लाइंट पर एक्सपोज़ न करें
- केवल क्लाइंट-साइड वेरिएबल्स के लिए `NEXT_PUBLIC_` प्रीफिक्स का उपयोग करें
- अपने वेबहुक सीक्रेट्स को नियमित रूप से घुमाएँ
- Stripe डैशबोर्ड में वेबहुक डिलीवरी की निगरानी करें



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---