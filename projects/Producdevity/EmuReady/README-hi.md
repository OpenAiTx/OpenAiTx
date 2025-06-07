# EmuReady

विभिन्न डिवाइसों और एमुलेटरों में इम्यूलेशन की संगतता को ट्रैक करने के लिए एक समुदाय-संचालित प्लेटफ़ॉर्म।

हमारी वेबसाइट देखें: [https://emuready.com](https://emuready.com)

---

**होम पेज का स्क्रीनशॉट**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**संगतता लिस्टिंग पेज का स्क्रीनशॉट**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**गेम्स पेज का स्क्रीनशॉट**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## अवलोकन

EmuReady उपयोगकर्ताओं को विभिन्न हार्डवेयर और सॉफ़्टवेयर कॉन्फ़िगरेशन में इम्यूलेशन संगतता की जानकारी साझा करने और खोजने में मदद करता है। उपयोगकर्ता संगतता रिपोर्ट योगदान कर सकते हैं, लिस्टिंग पर वोट कर सकते हैं, और विशिष्ट गेम/डिवाइस/एमुलेटर संयोजनों पर चर्चा कर सकते हैं।

![License](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Stars](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## विशेषताएँ

- **व्यापक संगतता डेटाबेस**: जानें कि विभिन्न एमुलेटर और डिवाइसों पर गेम्स कैसे चलते हैं
- **उपयोगकर्ता योगदान**: समुदाय-संचालित रिपोर्टिंग और वोटिंग सिस्टम
- **चर्चा प्रणाली**: अपवोटिंग/डाउनवोटिंग वाली कमेंट थ्रेड्स
- **एडमिन डैशबोर्ड**: उपयोगकर्ताओं, लिस्टिंग और सामग्री मॉडरेशन का प्रबंधन
- **उत्तरदायी डिज़ाइन**: मोबाइल, टैबलेट और डेस्कटॉप पर काम करता है

## हालिया सुधार

कोडबेस में निम्नलिखित सुधारों के साथ उल्लेखनीय रूप से सुधार किया गया है:

### यूआई कंपोनेंट्स

- बेहतर त्रुटि प्रबंधन और रिकवरी के लिए **ErrorBoundary** कंपोनेंट बनाया गया
- बेहतर प्रदर्शन के लिए Next.js की Image कंपोनेंट का उपयोग करते हुए **OptimizedImage** कंपोनेंट जोड़ा गया
- **Pagination** में एक्सेसिबिलिटी फीचर्स, कीबोर्ड नेविगेशन और बेहतर UX में सुधार किया गया
- **Badge** कंपोनेंट को अधिक वेरिएंट, साइज और पिल विकल्प के साथ बढ़ाया गया
- लाइट, डार्क और सिस्टम थीम के बीच स्विचिंग के लिए **ThemeToggle** कंपोनेंट जोड़ा गया
- दृश्य संकेतकों के साथ टेबल सॉर्टिंग के लिए **SortableHeader** लागू किया गया

### कैशिंग और प्रदर्शन

- कैशिंग, स्टेल टाइम्स और रिट्राई लॉजिक के लिए बेहतर डिफॉल्ट्स के साथ React Query कॉन्फ़िगरेशन में सुधार किया गया
- डिवाइस इमेज के लिए इमेज ऑप्टिमाइजेशन जोड़ा गया
- पूरे एप्लिकेशन में उचित त्रुटि प्रबंधन लागू किया गया

### अभिगम्यता

- इंटरएक्टिव एलिमेंट्स के लिए कीबोर्ड नेविगेशन में सुधार किया गया
- उपयुक्त ARIA लेबल और रोल्स जोड़े गए
- फोकस प्रबंधन में सुधार
- UI कंपोनेंट्स में बेहतर रंग कंट्रास्ट

### सुरक्षा

- कई स्तरों (क्लाइंट, सर्वर, डेटाबेस) पर डेटा मान्यकरण और सफाई
- कंटेंट सिक्योरिटी पॉलिसी कार्यान्वयन
- XSS और CSRF हमलों से सुरक्षा
- NextAuth.js के साथ सुरक्षित प्रमाणीकरण
- फ़ाइल अपलोड मान्यकरण और सुरक्षा उपाय
- इनपुट लंबाई प्रतिबंध और उचित सफाई
- पैरामीटर से छेड़छाड़ को रोकने के लिए UUID मान्यकरण

### डेवलपर अनुभव

- विकास वर्कफ़्लो के लिए अतिरिक्त npm स्क्रिप्ट्स जोड़ी गईं
- लगातार एक्सपोर्ट्स के साथ बेहतर प्रोजेक्ट संरचना
- कस्टम ErrorBoundary के साथ बेहतर त्रुटि प्रतिक्रिया
- सहायक नेविगेशन विकल्पों के साथ बेहतर 404 पेज

### थीमिंग

- सिस्टम थीम प्राथमिकता का पता लगाने की सुविधा जोड़ी गई
- कई UI विकल्पों के साथ थीम टॉगल बनाया गया
- कंपोनेंट्स में डार्क मोड कार्यान्वयन में सुधार किया गया

## आरंभ करें

### आवश्यकताएँ

- Node.js 20+
- `npm`
- PostgreSQL (या विकास के लिए SQLite)

### इंस्टॉलेशन

1. रिपॉजिटरी को क्लोन करें

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. डिपेंडेंसी इंस्टॉल करें

```bash
npm install
```

3. पर्यावरण वेरिएबल सेट करें

```bash
cp .env.example .env
```

फिर `.env` फ़ाइल को अपने डेटाबेस क्रेडेंशियल्स और अन्य कॉन्फ़िगरेशन के साथ संपादित करें।

4. डेटाबेस सेटअप करें

```bash
npx prisma generate
npx prisma db push
```

5. डेवलपमेंट सर्वर चलाएँ

```bash
npm run dev
```

6. अपने ब्राउज़र में [http://localhost:3000](http://localhost:3000) खोलें

## उपलब्ध स्क्रिप्ट्स

- `npm run dev` - डेवलपमेंट सर्वर शुरू करें
- `npm run dev:strict` - React strict mode के साथ शुरू करें
- `npm run build` - प्रोडक्शन के लिए बिल्ड करें
- `npm run start` - प्रोडक्शन सर्वर शुरू करें
- `npm run test` - टेस्ट चलाएँ
- `npm run lint` - ESLint चलाएँ
- `npm run lint:fix` - लिंटिंग समस्याएँ ठीक करें
- `npm run format` - Prettier से कोड फॉर्मेट करें
- `npm run typecheck` - TypeScript टाइप्स जांचें
- `npm run analyze` - बंडल साइज का विश्लेषण करें
- `npm run clean` - बिल्ड कैश साफ़ करें
- `npm run prepare-deploy` - डिप्लॉयमेंट की तैयारी करें (lint, typecheck, test, build)

### Prisma कमांड

- `npx prisma db seed` - डेटाबेस में डाटा डालें
- `npx prisma studio` - Prisma Studio खोलें
- `npx prisma db pull` - डेटाबेस स्कीमा खींचें
- `npx prisma db push` - डेटाबेस स्कीमा पुश करें

अधिक जानकारी के लिए देखें [Prisma Cli Reference](https://www.prisma.io/docs/orm/reference/prisma-cli-reference)।

## टेक स्टैक

- **फ्रेमवर्क**: Next.js 15
- **डेटाबेस ORM**: Prisma
- **API**: tRPC
- **प्रमाणीकरण**: NextAuth.js
- **स्टाइलिंग**: Tailwind CSS
- **स्टेट मैनेजमेंट**: React Query
- **टाइप चेकिंग**: TypeScript
- **एनिमेशन**: Framer Motion
- **मान्यकरण**: Zod, Content Security Policy, Input Validation

## योगदान

हम योगदानों का स्वागत करते हैं! अधिक जानकारी के लिए कृपया हमारी [योगदान दिशानिर्देश](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) देखें।

## लाइसेंस

यह प्रोजेक्ट MIT लाइसेंस के तहत लाइसेंस प्राप्त है - विवरण के लिए [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) फ़ाइल देखें।

## आचार संहिता (TODO)

कृपया ध्यान दें कि यह प्रोजेक्ट [आचार संहिता](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md) का पालन करता है। इस प्रोजेक्ट में भाग लेकर, आप इसकी शर्तों का पालन करने के लिए सहमत होते हैं।

## सुरक्षा (TODO)

यदि आप कोई सुरक्षा भेद्यता खोजते हैं, तो कृपया रिपोर्टिंग के लिए हमारी [सुरक्षा नीति](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) का पालन करें।

## आभार

- हमारे सभी [योगदाताओं](https://github.com/Producdevity/emuready/graphs/contributors)
- प्रेरणा और समर्थन के लिए इम्यूलेशन समुदाय

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---