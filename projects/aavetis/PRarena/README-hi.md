### PR एनालिटिक्स: वॉल्यूम बनाम सफलता दर (स्वतः-अपडेटेड)

इन आंकड़ों के लिए [इंटरएक्टिव डैशबोर्ड](https://prarena.ai) देखें।

## मेट्रिक्स को समझना

विभिन्न एआई कोडिंग एजेंट पुल अनुरोध (Pull Requests) बनाते समय अलग-अलग वर्कफ़्लो अपनाते हैं:

- **सभी PRs**: एजेंट द्वारा बनाए गए प्रत्येक पुल अनुरोध, जिसमें DRAFT PRs भी शामिल हैं
- **रेडी PRs**: गैर-ड्राफ्ट पुल अनुरोध जो समीक्षा और मर्जिंग के लिए तैयार हैं
- **मर्ज्ड PRs**: वे पुल अनुरोध जो सफलतापूर्वक कोडबेस में मर्ज हो गए

**मुख्य वर्कफ़्लो अंतर**: कुछ एजेंट जैसे **Codex** निजी रूप से पुनरावृत्ति करते हैं और सीधे रेडी PRs बनाते हैं, जिससे बहुत कम ड्राफ्ट बनते हैं लेकिन मर्ज दर अधिक होती है। अन्य जैसे **Copilot** और **Codegen** पहले ड्राफ्ट PRs बनाते हैं, जिससे सार्वजनिक पुनरावृत्ति को प्रोत्साहन मिलता है, फिर समीक्षा के लिए उन्हें रेडी मार्क किया जाता है।

नीचे दिए गए आंकड़े केवल **रेडी PRs** पर केंद्रित हैं ताकि विभिन्न वर्कफ़्लो के बावजूद एजेंट्स की तुलना निष्पक्ष रूप से की जा सके, और यह मापा जा सके कि प्रत्येक एजेंट मर्ज योग्य कोड बनाने में कितना सक्षम है, चाहे वे सार्वजनिक (ड्राफ्ट्स के साथ) या निजी तौर पर पुनरावृत्ति करें।

## डेटा स्रोत

प्रयुक्त GitHub सर्च क्वेरीज़ देखें:



- **सभी Copilot PRs**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **मर्ज्ड Copilot PRs**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **सभी Codex PRs**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **मर्ज्ड Codex PRs**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **सभी Cursor PRs**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **मर्ज्ड Cursor PRs**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **सभी Devin PRs**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **मर्ज्ड Devin PRs**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **सभी Codegen PRs**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **मर्ज्ड Codegen PRs**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## वर्तमान सांख्यिकी

| प्रोजेक्ट | रेडी PRs | मर्ज्ड PRs | सफलता दर |
| --------- | -------- | ---------- | --------- |
| Copilot | 16,355 | 15,073 | 92.16% |
| Codex | 594,884 | 520,690 | 87.53% |
| Cursor | 7,474 | 5,560 | 74.39% |
| Devin | 29,168 | 19,221 | 65.9% |
| Codegen | 2,108 | 1,682 | 79.79% |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---