# हैंड जेस्चर अर्पेजिएटर

हाथ से नियंत्रित अर्पेजिएटर, ड्रम मशीन, और ऑडियो रिएक्टिव विजुअलाइज़र। अपने हाथ उठाओ और माहौल बना दो!

एक इंटरएक्टिव वेब ऐप जो threejs, mediapipe कंप्यूटर विज़न, rosebud AI, और tone.js के साथ बनाया गया है।

- हाथ #1 अर्पेजियो को नियंत्रित करता है (हाथ उठाने से पिच बढ़ती है, पिंच करने से वॉल्यूम बदलती है)
- हाथ #2 ड्रम को नियंत्रित करता है (अलग-अलग उंगलियां उठाने से पैटर्न बदलता है)

[वीडियो](https://youtu.be/JepIs-DTBgk?si=4Y-FrQDF6KNy662C) | [लाइव डेमो](https://collidingscopes.github.io/arpeggiator/) | [अधिक कोड और ट्यूटोरियल्स](https://funwithcomputervision.com/)

<img src="https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/assets/demo.png">

## आवश्यकताएँ

- WebGL सपोर्ट के साथ आधुनिक वेब ब्राउज़र
- हैंड ट्रैकिंग के लिए कैमरा एक्सेस सक्षम

## टेक्नोलॉजीज

- हैंड ट्रैकिंग और जेस्चर रिकग्निशन के लिए **MediaPipe**
- ऑडियो रिएक्टिव विज़ुअल रेंडरिंग के लिए **Three.js**
- सिंथेसाइज़र साउंड्स के लिए **Tone.js**
- विज़ुअल फीडबैक के लिए **HTML5 Canvas**
- रियल-टाइम इंटरएक्शन के लिए **JavaScript**
## विकास के लिए सेटअप

```bash
# इस रिपॉजिटरी को क्लोन करें
git clone https://github.com/collidingScopes/arpeggiator

# प्रोजेक्ट डायरेक्टरी में जाएँ
cd arpeggiator

# अपनी पसंदीदा विधि से सर्व करें (उदाहरण के लिए Python का उपयोग करते हुए)
python -m http.server
```

फिर अपने ब्राउज़र में `http://localhost:8000` पर जाएँ।

## लाइसेंस

MIT लाइसेंस

## श्रेय
- Three.js - https://threejs.org/
- MediaPipe - https://mediapipe.dev/
- Rosebud AI - https://rosebud.ai/
- Tone.js - https://tonejs.github.io/

## संबंधित परियोजनाएँ

मैंने कई कंप्यूटर विज़न परियोजनाएँ (कोड + ट्यूटोरियल सहित) यहाँ जारी की हैं:
[Fun With Computer Vision](https://www.funwithcomputervision.com/)

आप आजीवन एक्सेस खरीद सकते हैं और पूरे प्रोजेक्ट फाइल्स व ट्यूटोरियल प्राप्त कर सकते हैं। मैं नियमित रूप से और भी सामग्री जोड़ रहा हूँ 🪬

आपको मेरे कुछ अन्य ओपन सोर्स प्रोजेक्ट भी पसंद आ सकते हैं:

- [3D Model Playground](https://collidingScopes.github.io/3d-model-playground) - वॉयस और हैंड जेस्चर से 3D मॉडल को नियंत्रित करें
- [Threejs hand tracking tutorial](https://collidingScopes.github.io/threejs-handtracking-101) - Threejs और MediaPipe कंप्यूटर विज़न के साथ बेसिक हैंड ट्रैकिंग सेटअप
- [Particular Drift](https://collidingScopes.github.io/particular-drift) - फोटो को प्रवाहित कण एनीमेशन में बदलें
- [Video-to-ASCII](https://collidingScopes.github.io/ascii) - वीडियो को ASCII पिक्सल आर्ट में बदलें
## संपर्क

- इंस्टाग्राम: [@stereo.drift](https://www.instagram.com/stereo.drift/)
- ट्विटर/X: [@measure_plan](https://x.com/measure_plan)
- ईमेल: [stereodriftvisuals@gmail.com](https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/mailto:stereodriftvisuals@gmail.com)
- गिटहब: [collidingScopes](https://github.com/collidingScopes)

## दान

यदि आपको यह टूल उपयोगी लगा, तो आप मुझे एक कॉफ़ी खरीदकर सहयोग कर सकते हैं।

मेरा नाम एलन है, और मुझे कंप्यूटर विज़न, गेम्स, और अन्य क्षेत्रों के लिए ओपन सोर्स सॉफ़्टवेयर बनाना पसंद है। देर रात के कोडिंग सेशनों के दौरान यह बहुत सराहनीय होगा!

[![मुझे एक कॉफ़ी खरीदें](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/stereoDrift)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---