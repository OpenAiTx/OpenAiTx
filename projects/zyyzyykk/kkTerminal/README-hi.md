# kkTerminal

> kkTerminal, वेब SSH कनेक्शन के लिए एक टर्मिनल
>
> लेखक: [zyyzyykk](https://github.com/zyyzyykk/)
>
> स्रोत कोड: https://github.com/zyyzyykk/kkTerminal
>
> डॉकर हब पता: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> पूर्वावलोकन: https://ssh.kkbpro.com/
>
> अपडेट समय: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ त्वरित एकीकरण

HTML वेब पेजों में `iframe` टैग का उपयोग करके त्वरित एकीकरण:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 डॉकर के साथ डिप्लॉय करें

1. इमेज खींचें:

```bash
docker pull zyyzyykk/kkterminal
```

2. पोर्ट मैपिंग के लिए कंटेनर बनाएं और चलाएँ: `-p port:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. कस्टम आर्ट वर्ड: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. ब्राउज़र में एक्सेस करें: `http://server-ip:3000/`

### 🛸 पूर्वावलोकन

निम्नलिखित वेबसाइट पर जाएँ: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**और मॉड्यूल पूर्वावलोकन**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 फ़ंक्शन विवरण

1. kkTerminal वेब SSH कनेक्शन के लिए एक टर्मिनल है। ऊपरी-बाएँ कोने में टर्मिनल आइकन पर क्लिक करें और कनेक्शन सेटिंग्स चुनें ताकि SSH कनेक्शन स्थापित किया जा सके

2. तृतीय-पक्ष वेबसाइटों में त्वरित एकीकरण के लिए वेब पेजों में `iframe` टैग के उपयोग का समर्थन करता है

3. [URL Parameters](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md) के माध्यम से टर्मिनल कॉन्फ़िगरेशन को अनुकूलित करने का समर्थन करता है

4. अंतर्राष्ट्रीयकरण और चीनी तथा अंग्रेज़ी के बीच भाषा स्विचिंग का समर्थन करता है

5. लोकल पीसी पर डिप्लॉयमेंट का समर्थन करता है, स्टार्टअप पर ब्राउज़र विंडो अपने आप खुल जाती है

6. अनुकूली विंडो आकार और चीनी इनपुट का समर्थन करता है

7. कस्टम प्रेफरेंस सेटिंग्स का समर्थन करता है, जिससे उपयोगकर्ता बैकग्राउंड/फोरग्राउंड रंग, फॉन्ट साइज, कर्सर डिस्प्ले शैली चुन सकते हैं, टर्मिनल के लिए TCode सक्षम कर सकते हैं आदि

8. पुनः आरंभ का समर्थन करता है: SSH कनेक्शन सेटिंग्स या कस्टम प्रेफरेंस सेटिंग्स संशोधित करने के बाद स्वचालित रूप से पुनः आरंभ होगा, या SSH कनेक्शन डिस्कनेक्ट होने के बाद मैन्युअली भी पुनः आरंभ किया जा सकता है

9. कॉपी और पेस्ट का समर्थन करता है:

   - कॉपी: `Git` टर्मिनल की तरह, टेक्स्ट का चयन करने पर वह अपने आप कॉपी हो जाएगा

   - पेस्ट: `Cmd` टर्मिनल की तरह, राइट-क्लिक करके पेस्ट करें (ब्राउज़र एक्सेस अनुमति आवश्यक)


9. फाइल प्रबंधन का समर्थन करता है, फ़ाइल प्रबंधन मॉड्यूल खोलकर फाइलें/फोल्डर देखें, डिकम्प्रेस करें, अपलोड और डाउनलोड करें

10. मल्टीपल/सभी फाइल चयन, कॉपी-पेस्ट, कट, चयन स्विच, ओपन आदि जैसे शॉर्टकट कुंजी संचालन का समर्थन करता है

11. फाइल ब्राउज़िंग और संपादन का समर्थन करता है, फ़ाइल को संशोधित करें और `ctrl+s` का उपयोग करके इसे रिमोट सर्वर पर सहेजें

12. [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md) का समर्थन करता है, जिससे कस्टम TCode के माध्यम से शेल स्क्रिप्ट के समान स्वचालित वर्कफ़्लो प्राप्त किया जा सकता है

13. ऑपरेशन रिकॉर्डिंग और क्लाउड सिंक्रोनाइज़ेशन फंक्शन का समर्थन करता है

14. Cooperate, Monitor और Docker फंक्शन का समर्थन करता है

### 👨‍💻 अपडेट रिकॉर्ड्स

##### zyyzyykk/kkterminal:3.6.0: latest

- Advance Cooperate फंक्शन जोड़ा गया
- Advance Monitor फंक्शन जोड़ा गया
- Advance Docker फंक्शन जोड़ा गया
- पैकेजिंग वॉल्यूम और वेबपेज डिस्प्ले को ऑप्टिमाइज़ किया गया

##### zyyzyykk/kkterminal:3.5.6: 

- अधिक URL पैरामीटर का समर्थन
- एडिटर टेक्स्ट और इमेज साइज प्रतिशत जोड़ा गया
- वेबपेज डिस्प्ले को ऑप्टिमाइज़ किया गया

##### zyyzyykk/kkterminal:3.5.3: 

- टर्मिनल कॉन्फ़िगरेशन को अनुकूलित करने के लिए URL पैरामीटर जोड़ा गया
- मल्टी विंडो रीस्टार्ट की बग को ठीक किया गया
- ऑपरेशन रिकॉर्डिंग और क्लाउड सिंक्रोनाइज़ेशन फंक्शन जोड़ा गया
- कुछ कोड लॉजिक का पुनःसंरचना किया गया

[**इतिहास अपडेट रिकॉर्ड्स**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 आर्किटेक्चर

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ इस प्रोजेक्ट के बारे में

प्रिय उपयोगकर्ता,

मुझे खेद है कि सीमित समय और ऊर्जा के कारण, मैं भविष्य में `kkTerminal` का रखरखाव करने में असमर्थ रहूँगा।

यदि आप `kkTerminal` में रुचि रखते हैं या इसका रखरखाव जारी रखना चाहते हैं, तो कृपया मुझसे संपर्क करें या एक इश्यू उठाएँ।

यदि आपको बग मिलते हैं या आप नई विशेषताएँ विकसित करना चाहते हैं, तो कृपया एक इश्यू उठाएँ।

अंत में, `kkTerminal` को समर्थन देने के लिए आपका धन्यवाद और मैं ईमानदारी से आशा करता हूँ कि `kkTerminal` वास्तव में आपकी मदद कर सकता है।

सादर,

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 स्टार्स

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---