<samp>
  
<h1>ओपन-सोर्स वीडियो एडिटर</h1>
<p>यह आपका साधारण वीडियो एडिटर एप्लिकेशन नहीं है, इसमें React, Remotion और TypeScript का उपयोग किया गया है।</p>
<br />

> [!NOTE]  
> यह एप्लिकेशन सक्रिय विकास में है। यह एक प्रारंभिक MVP है। कृपया यदि आप इसे चलाने जा रहे हैं तो [Discord सर्वर](https://discord.gg/GSknuxubZK) से जुड़ें।

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="React Video Editor Screenshot">
</p>
<p align="center">Capcut, Canva, और RVE के लिए एक ओपन-सोर्स विकल्प।</p>
</samp>

## ✨फीचर्स

- 🎬नॉन-लीनियर वीडियो एडिटिंग
- 🔀मल्टी-ट्रैक सपोर्ट
- 👀लाइव प्रीव्यू
- 📤वीडियो एक्सपोर्ट
- 📜MIT के तहत लाइसेंस प्राप्त

## 🐋डिप्लॉयमेंट

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻डेवलपमेंट

```
pnpm i
pnpm run dev (फ्रंटएंड)
pnpm dlx tsx app/videorender/videorender.ts (बैकएंड)
uv run backend/main.py
`/app/utils/api.ts` में `isProduction` को `false` पर सेट करें

यदि आप AI का उपयोग करना चाहते हैं तो आपको GEMINI_API_KEY भी चाहिए होगा।
```

## 📃TODO

हमें बहुत सारा काम करना है! शुरुआत के लिए, हम सभी Remotion APIs को इंटीग्रेट करने की योजना बना रहे हैं। मैं जल्द ही एक सही रोडमैप जोड़ूंगा। अपडेट्स और सपोर्ट के लिए [Discord सर्वर](https://discord.com/invite/GSknuxubZK) से जुड़ें।

## ❤️योगदान

हम आपके योगदान का स्वागत करते हैं! ❤️ [योगदान गाइड](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md) देखें।

## 📜लाइसेंस

यह प्रोजेक्ट MIT लाइसेंस के तहत लाइसेंस प्राप्त है। प्रोजेक्ट के संबंधित हिस्सों पर [Remotion लाइसेंस](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) भी लागू होता है।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---