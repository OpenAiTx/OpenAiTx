<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

एक मजबूत, स्थानीय रूप से डिप्लॉय की जाने वाली प्लेटफ़ॉर्म, जिसे निर्बाध SQL डिटेक्शन और क्वेरी ऑडिटिंग के लिए डिज़ाइन किया गया है, विशेष रूप से DBA और डेवलपर्स के लिए। गोपनीयता और दक्षता पर केंद्रित, यह MYSQL ऑडिटिंग के लिए एक सहज और सुरक्षित वातावरण प्रदान करता है।

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ विशेषताएँ

- **एआई सहायक**: हमारा एआई सहायक वास्तविक समय में SQL ऑप्टिमाइज़ेशन सुझाव प्रदान करता है, जिससे SQL प्रदर्शन बेहतर होता है। यह टेक्स्ट-टू-SQL रूपांतरण को भी सपोर्ट करता है, जिससे उपयोगकर्ता प्राकृतिक भाषा इनपुट कर ऑप्टिमाइज़ SQL स्टेटमेंट्स प्राप्त कर सकते हैं।
  
- **SQL ऑडिट**: अनुमोदन वर्कफ़्लो और स्वचालित सिंटैक्स जांच के साथ SQL ऑडिट टिकट बनाएं। SQL स्टेटमेंट्स की शुद्धता, सुरक्षा और अनुपालन के लिए मान्यता करें। DDL/DML ऑपरेशनों के लिए रोलबैक स्टेटमेंट्स स्वचालित रूप से जेनरेट होते हैं, और ट्रेसबिलिटी के लिए एक व्यापक हिस्ट्री लॉग उपलब्ध है।

- **क्वेरी ऑडिट**: उपयोगकर्ता क्वेरीज़ का ऑडिट करें, डेटा स्रोतों और डाटाबेस को सीमित करें, और संवेदनशील फ़ील्ड्स को अनामित करें। क्वेरी रिकॉर्ड्स भविष्य के संदर्भ के लिए सेव किए जाते हैं।

- **चेक नियम**: हमारा स्वचालित सिंटैक्स चेकर कई प्रकार के चेक नियमों को सपोर्ट करता है, जो अधिकांश स्वचालित जांच परिदृश्यों के लिए उपयुक्त है।

- **गोपनीयता केंद्रित**: Yearning एक स्थानीय रूप से डिप्लॉय होने वाला, ओपन-सोर्स समाधान है जो आपके डाटाबेस और SQL स्टेटमेंट्स की सुरक्षा सुनिश्चित करता है। इसमें एन्क्रिप्शन मैकेनिज़्म शामिल हैं जो संवेदनशील डेटा की सुरक्षा करते हैं, जिससे अनधिकृत पहुंच की स्थिति में भी डेटा सुरक्षित रहता है।

- **RBAC (रोल-आधारित अभिगम नियंत्रण)**: विशिष्ट अनुमतियों के साथ रोल्स बनाएं और प्रबंधित करें, उपयोगकर्ता भूमिकाओं के आधार पर क्वेरी वर्क ऑर्डर्स, ऑडिटिंग फंक्शन्स और अन्य संवेदनशील ऑपरेशनों तक पहुंच को सीमित करें।

> \[!TIP]
> अधिक विस्तृत जानकारी के लिए हमारे [Yearning Guide](https://next.yearning.io) पर जाएं

## ⚙️ स्थापना

[नवीनतम रिलीज़](https://github.com/cookieY/Yearning/releases/latest) डाउनलोड करें और इसे एक्सट्रैक्ट करें। आगे बढ़ने से पहले सुनिश्चित करें कि आपने `./config.toml` को कॉन्फ़िगर कर लिया है।

### मैन्युअल स्थापना

```bash
## डाटाबेस इनिशियलाइज़ करें
./Yearning install

## Yearning प्रारंभ करें
./Yearning run

## सहायता
./Yearning --help
```

### 🚀 Docker के साथ डिप्लॉयमेंट
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## डाटाबेस इनिशियलाइज़ करें
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Yearning प्रारंभ करें
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 एआई सहायता

हमारा एआई सहायक एक बड़ा भाषा मॉडल उपयोग करता है जो SQL ऑप्टिमाइज़ेशन सुझाव और टेक्स्ट-टू-SQL रूपांतरण प्रदान करता है। चाहे डिफॉल्ट या कस्टम प्रॉम्प्ट्स का उपयोग हो, एआई सहायक SQL स्टेटमेंट्स को ऑप्टिमाइज़ करके और प्राकृतिक भाषा इनपुट को SQL क्वेरीज में बदलकर SQL प्रदर्शन को बेहतर बनाता है।

![Text to SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 स्वचालित SQL चेकर

स्वचालित SQL चेकर SQL स्टेटमेंट्स का पूर्व-निर्धारित नियमों और सिंटैक्स के अनुसार मूल्यांकन करता है। यह सुनिश्चित करता है कि स्टेटमेंट्स विशिष्ट कोडिंग मानकों, सर्वोत्तम प्रथाओं और सुरक्षा आवश्यकताओं का पालन करते हैं, और एक मजबूत वैलिडेशन लेयर प्रदान करता है।

![SQL Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 SQL सिंटैक्स हाइलाइटिंग और ऑटो-कम्प्लीशन

SQL सिंटैक्स हाइलाइटिंग और ऑटो-कम्प्लीशन के साथ अपनी क्वेरी लेखन दक्षता बढ़ाएं। ये सुविधाएँ उपयोगकर्ताओं को SQL क्वेरी के विभिन्न घटकों—जैसे कीवर्ड्स, टेबल नाम, कॉलम नाम, और ऑपरेटर—को दृश्य रूप से अलग करने में मदद करती हैं, जिससे क्वेरी संरचना को पढ़ना और समझना आसान हो जाता है।

![SQL Query](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ ऑर्डर/क्वेरी रिकॉर्ड

हमारा प्लेटफ़ॉर्म उपयोगकर्ता ऑर्डर और क्वेरी स्टेटमेंट्स के ऑडिटिंग को सपोर्ट करता है। यह सुविधा आपको सभी क्वेरी ऑपरेशनों—जैसे डेटा स्रोत, डाटाबेस, और संवेदनशील फ़ील्ड्स की प्रोसेसिंग—को ट्रैक और रिकॉर्ड करने की अनुमति देती है, जिससे नियमों का पालन और क्वेरी इतिहास के लिए ट्रेसबिलिटी सुनिश्चित होती है।

![Order/Query Record](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

इन प्रमुख विशेषताओं पर ध्यान केंद्रित करके, Yearning उपयोगकर्ता अनुभव को बेहतर बनाता है, SQL प्रदर्शन को ऑप्टिमाइज़ करता है, और डाटाबेस ऑपरेशनों में मजबूत अनुपालन और ट्रेसबिलिटी सुनिश्चित करता है।

## 🛠️ अनुशंसित टूल्स

- [Spug - ओपन सोर्स हल्का ऑटोमेशन ऑपरेशन्स प्लेटफ़ॉर्म](https://github.com/openspug/spug)

## ☎️ संपर्क

संपर्क के लिए कृपया हमें ईमेल करें: henry@yearning.io
## 📋 लाइसेंस

Yearning एजीपीएल लाइसेंस के अंतर्गत लाइसेंस प्राप्त है। विवरण के लिए [LICENSE](LICENSE) देखें।

2024 © हेनरी यी

---

Yearning के साथ, SQL ऑडिटिंग और ऑप्टिमाइज़ेशन के लिए एक सुव्यवस्थित, सुरक्षित और कुशल दृष्टिकोण का अनुभव करें।


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---