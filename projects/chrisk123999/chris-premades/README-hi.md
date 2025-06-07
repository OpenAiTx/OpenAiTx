# Readme

स्वचालित वस्तुओं का एक संग्रह जिसमें जादू, वर्ग विशेषताएँ, राक्षस विशेषताएँ आदि, उन्हें संभव बनाने के लिए यांत्रिकी, और उच्च-स्वचालन Midi-QOL आधारित D&D5e वातावरण के लिए गुणवत्ता-वृद्धि विस्तार शामिल हैं। इस मॉड्यूल में शामिल कम्पेंडियम में वस्तुओं के विवरण नहीं होते। जबकि इस मॉड्यूल की कई निर्भरताएँ विभिन्न लेखकों के अन्य मॉड्यूल्स पर हैं, कृपया tposney, Wasp, या किसी अन्य मॉड्यूल लेखक को इस मॉड्यूल से संबंधित बग या समस्याओं के लिए परेशान न करें। बग रिपोर्ट और बड़े मॉड्यूल कार्यान्वयन अनुरोध GitHub पर किए जा सकते हैं। तेज़ सहायता और फीचर अनुरोध [Discord सर्वर](https://discord.gg/BumxBcQDrT) पर प्राप्त किए जा सकते हैं।

![CauldronofPlentifulResourcesMedium](https://github.com/user-attachments/assets/58c729ba-c499-45a3-a62c-c6982ad1f725) 
  
### लेखक:
[Chris](https://github.com/chrisk123999) <br> 
[Autumn](https://github.com/Autumn225) <br>
[Michael](https://github.com/roth-michael) <br>
[SagaTympana](https://github.com/SagaTympana)

### समर्थन:
[<img src="https://raw.githubusercontent.com/chrisk123999/chris-premades/master/images/chris-kofi.svg" width=237px />](https://ko-fi.com/O5O5G582S) <br>
[<img src="https://raw.githubusercontent.com/chrisk123999/chris-premades/master/images/michael-kofi.svg" width=253px />](https://ko-fi.com/T6T8XKCII)
  
# आवश्यक मॉड्यूल  
| मॉड्यूल | न्यूनतम संस्करण |  
| --- | --- | 
| D&D 5e सिस्टम | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.systems%5B%3A1%5D.compatibility.minimum&label=%20&color=orange) | 
| Midi-Qol | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B0%5D.compatibility.minimum&label=%20&color=green) |  
| Dynamic Active Effects | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B3%5D.compatibility.minimum&label=%20&color=green) |
| Jules & Ben's Animated Assets | ![Static Badge](https://img.shields.io/badge/0.6.0-blue) |  
| Sequencer | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B1%5D.compatibility.minimum&label=%20&color=green) |  
| Socket Lib | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B2%5D.compatibility.minimum&label=%20&color=green) |  
| Time's Up | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B4%5D.compatibility.minimum&label=%20&color=green) |
  
# वैकल्पिक समर्थित मॉड्यूल:  
- Gambit's Premades
- Midi Item Showcase Community
- Universal Animations
- [Animated Spell Effects: Cartoon](https://github.com/chrisk123999/animated-spell-effects-cartoon/releases/download/0.4.6/module.json)
- Visual Active Effects
- D&D Beyond Importer
- Tidy5e Sheet
- Token Magic FX
  
# मुख्य विशेषताएँ:
- स्वचालित जादू, वस्तुओं, वर्ग विशेषताओं, और अन्य का कम्पेंडियम।
- शीर्षक पट्टी बटन जो शामिल स्वचालन लागू करने और कॉन्फ़िगर करने के लिए एक इंटरफ़ेस प्रदान करता है।
- कुछ स्वचालन के लिए ***Eskiemoh*** द्वारा बनाए गए आकर्षक एनिमेशन, *Patreon JB2A* और *Animated Spell Effects: Cartoon* का उपयोग करते हुए।
- मैन्युअल रोल के लिए कस्टम रोल सुलझाने वाला, विशेष रूप से आमने-सामने के खेल के लिए डिज़ाइन किया गया।
- Midi-QOL के कार्यप्रवाह से बढ़ाया गया कस्टम API, जो सटीक इवेंट टाइमिंग और ओवरलैपिंग जादू प्रभावों के स्वचालन की अनुमति देता है।
- कस्टम मैक्रोज़ चलाने के लिए सार्वजनिक API।
- विभिन्न वैकल्पिक गुणवत्ता-वृद्धि उपयोगकर्ता इंटरफ़ेस विस्तार।
- प्रभाव परिवर्तनों में स्वचालित विवरण, स्थिति प्रभाव आइकन परिवर्तन, और स्थिति प्रभावों पर संबंधित Midi-QOL फ्लैग्स का लागू होना।
- कस्टम प्रभाव संग्रहित करने और लागू करने के लिए कस्टम प्रभाव इंटरफ़ेस।
- वैकल्पिक और होमब्रू यांत्रिकी जैसे DMG Cleave, Exploding Heals, और BG3 Weapon Actions।
- स्वचालित चरित्र बैकअप।

# समुदाय लिंक:
[Cauldron of Plentiful Resources Discord](https://discord.gg/BumxBcQDrT)<br>
[Foundry VTT Discord](https://discord.gg/foundryvtt)<br>
[Posney's Foundry Automation Discord](https://discord.gg/Xd4NEvw5d7)<br>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---