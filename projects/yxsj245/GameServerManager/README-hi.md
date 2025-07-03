# परियोजना परिचय
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**गेम सर्वर की डिप्लॉयमेंट, प्रबंधन और रखरखाव को सरल और कुशल बनाएं**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 दस्तावेज़ साइट](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 आधिकारिक वेबसाइट](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 QQ समूह](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 परियोजना संक्षिप्त परिचय

GameServerManager (संक्षिप्त रूप में GSManager) एक आधुनिक गेम सर्वर प्रबंधन प्लेटफ़ॉर्म है, जो **Docker** तकनीक पर आधारित है, और विशेष रूप से गेम सर्वर की डिप्लॉयमेंट, प्रबंधन और रखरखाव को सरल बनाने के लिए डिज़ाइन किया गया है।

### ✨ मुख्य विशेषताएँ

- 🐳 **Docker कंटेनरीकरण** - पूरी तरह से Docker पर चलता है, वातावरण पृथक्करण, बेहतरीन अनुकूलता
- 🎯 **वन-क्लिक डिप्लॉयमेंट** - कई लोकप्रिय गेम्स के लिए त्वरित डिप्लॉयमेंट का समर्थन करता है
- 🌐 **वेब प्रबंधन इंटरफ़ेस** - आधुनिक React फ्रंटएंड, सहज और उपयोग में आसान
- 🔧 **रीयल-टाइम टर्मिनल** - इनबिल्ट वेब टर्मिनल, रीयल-टाइम कमांड निष्पादन का समर्थन
- 📊 **संसाधन निगरानी** - सर्वर संसाधन उपयोग की रीयल-टाइम निगरानी
- 🔐 **अनुमति प्रबंधन** - संपूर्ण यूज़र प्रमाणीकरण और अनुमति नियंत्रण प्रणाली
- 🎮 **मल्टी-गेम समर्थन** - Steam प्लेटफ़ॉर्म के कई लोकप्रिय गेम सर्वर का समर्थन
- 💾 **डेटा स्थायीत्व** - गेम डेटा और कॉन्फ़िगरेशन फ़ाइलों का बाहरी मैपिंग, सुरक्षित और विश्वसनीय

![कंटेनर सूचना पैनल](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 त्वरित प्रारंभ

### वन-क्लिक इंस्टालेशन स्क्रिप्ट

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> debian (docker स्वयं इंस्टॉल करें) और centos के लिए कृपया मैन्युअल इंस्टालेशन उपयोग करें, विस्तार के लिए दस्तावेज़ साइट देखें

---

## 🎮 समर्थित गेम्स

| गेम नाम | चीनी नाम | Steam ID | गुमनाम डाउनलोड | स्थिति |
|---------|--------|----------|----------|------|
| **लोकप्रिय गेम्स** | | | | |
| Palworld | फैंटसी बीस्ट पालू | 2394010 | ✅ | 🟢 पूरी तरह समर्थित |
| Rust | रस्ट | 258550 | ✅ | 🟢 पूरी तरह समर्थित |
| Satisfactory | सैटिस्फैक्ट्री | 1690800 | ✅ | 🟢 पूरी तरह समर्थित |
| Valheim | वल्हाइम | 896660 | ✅ | 🟢 पूरी तरह समर्थित |
| 7 Days to Die | 7 डेज़ टू डाई | 294420 | ✅ | 🟢 पूरी तरह समर्थित |
| Project Zomboid | प्रोजेक्ट जोंबॉइड | 380870 | ✅ | 🟢 पूरी तरह समर्थित |
| ARK: Survival Evolved | आर्क: सर्वाइवल इवोल्व्ड | 376030 | ✅ | 🟢 पूरी तरह समर्थित |
| **शूटर गेम्स** | | | | |
| Left 4 Dead 2 | लेफ्ट 4 डेड 2 | 222860 | ❌ | 🟡 मूल संस्करण आवश्यक |
| Team Fortress 2 | टीम फोर्ट्रेस 2 | 232250 | ✅ | 🟢 पूरी तरह समर्थित |
| Squad | स्क्वाड | 403240 | ✅ | 🟢 पूरी तरह समर्थित |
| Insurgency: Sandstorm | इनसर्जेंसी: सैंडस्टॉर्म | 581330 | ✅ | 🟢 पूरी तरह समर्थित |
| Killing Floor 2 | किलिंग फ्लोर 2 | 232130 | ✅ | 🟢 पूरी तरह समर्थित |
| Insurgency (2014) | इनसर्जेंसी 2 | 237410 | ✅ | 🟢 पूरी तरह समर्थित |
| MORDHAU | मॉरधाउ | 629800 | ✅ | 🟢 पूरी तरह समर्थित |
| No More Room in Hell | नो मोर रूम इन हेल | 317670 | ✅ | 🟢 पूरी तरह समर्थित |
| Fistful of Frags | फिस्टफुल ऑफ फ्रैग्स | 295230 | ✅ | 🟢 पूरी तरह समर्थित |
| Half-Life | हाफ-लाइफ | 90 | ✅ | 🟢 पूरी तरह समर्थित |
| Half-Life 2: Deathmatch | हाफ-लाइफ 2 | 232370 | ✅ | 🟢 पूरी तरह समर्थित |
| Operation: Harsh Doorstop | ऑपरेशन: हर्ष डोरस्टॉप | 950900 | ✅ | 🟢 पूरी तरह समर्थित |
| Vox Machinae | वॉक्स मॅकिने | 944490 | ✅ | 🟡 कॉन्फ़िगरेशन आवश्यक |
| **इंडी गेम्स** | | | | |
| Unturned | अनटर्न्ड | 1110390 | ✅ | 🟢 पूरी तरह समर्थित |
| Don't Starve Together | डोंट स्टार्व टुगेदर | 343050 | ✅ | 🟡 कॉन्फ़िगरेशन आवश्यक |
| Last Oasis | लास्ट ओएसिस | 920720 | ✅ | 🟢 पूरी तरह समर्थित |
| Hurtworld | हर्टवर्ल्ड | 405100 | ✅ | 🟢 पूरी तरह समर्थित |
| Soulmask | सोलमास्क | 3017300 | ✅ | 🟢 पूरी तरह समर्थित |
| **सिमुलेशन गेम्स** | | | | |
| Euro Truck Simulator 2 | यूरो ट्रक सिमुलेटर 2 | 1948160 | ✅ | 🟡 कॉन्फ़िगरेशन आवश्यक |
| American Truck Simulator | अमेरिकन ट्रक सिमुलेटर | 2239530 | ✅ | 🟡 कॉन्फ़िगरेशन आवश्यक |
| ECO | ईको | 739590 | ✅ | 🟡 कॉन्फ़िगरेशन आवश्यक |

> और अधिक गेम्स का समर्थन लगातार जोड़ा जा रहा है...

---

## 🏗️ तकनीकी वास्तुकला

### फ्रंटएंड टेक्नोलॉजी स्टैक
- **React 18** - आधुनिक फ्रंटएंड फ्रेमवर्क
- **Ant Design** - एंटरप्राइज-स्तरीय UI कम्पोनेंट लाइब्रेरी
- **Monaco Editor** - कोड एडिटर
- **Xterm.js** - वेब टर्मिनल एमुलेटर
- **Vite** - तेज़ निर्माण उपकरण

### बैकएंड टेक्नोलॉजी स्टैक
- **Python 3.13** - मुख्य डेवलपमेंट भाषा
- **Flask** - वेब फ्रेमवर्क
- **Gunicorn** - WSGI सर्वर
- **Docker** - कंटेनरीकरण तकनीक
- **SteamCMD** - Steam कमांड लाइन टूल
- **Aria2** - मल्टी-प्रोटोकॉल डाउनलोडर

---

## 📁 परियोजना संरचना

```
GameServerManager/
├── app/                    # फ्रंटएंड एप्लिकेशन
│   ├── src/               # React स्रोत कोड
│   ├── public/            # स्थैतिक संसाधन
│   └── package.json       # फ्रंटएंड निर्भरताएँ
├── server/                # बैकएंड सेवा
│   ├── api_server.py      # मुख्य API सर्वर
│   ├── game_installer.py  # गेम इंस्टॉलर
│   ├── pty_manager.py     # टर्मिनल प्रबंधक
│   ├── auth_middleware.py # प्रमाणीकरण मिडलवेयर
│   └── installgame.json   # गेम कॉन्फ़िगरेशन फ़ाइल
├── docker-compose.yml     # Docker ऑर्केस्ट्रेशन फ़ाइल
├── Dockerfile            # Docker इमेज बिल्ड फ़ाइल
└── README.md             # परियोजना दस्तावेज़
```

---

## 🔧 कॉन्फ़िगरेशन विवरण

### पोर्ट कॉन्फ़िगरेशन
- **5000** - वेब प्रबंधन इंटरफ़ेस
- **27015-27020** - Steam गेम सर्वर पोर्ट रेंज

### डेटा वॉल्यूम मैपिंग
- `./game_data` → `/home/steam/games` - गेम डेटा डायरेक्टरी
- `./game_file` → `/home/steam/.config` - गेम कॉन्फ़िगरेशन डायरेक्टरी
- `./game_file` → `/home/steam/.local` - गेम सेव डायरेक्टरी

### पर्यावरण वेरिएबल्स
- `TZ=Asia/Shanghai` - टाइम ज़ोन सेटिंग
- `USE_GUNICORN=true` - Gunicorn सक्षम करें
- `GUNICORN_TIMEOUT=120` - अनुरोध टाइमआउट समय
- `GUNICORN_PORT=5000` - सर्वर पोर्ट

---

## 🤝 योगदान गाइड

हम सभी प्रकार के योगदान का स्वागत करते हैं!

1. इस परियोजना को **Fork** करें
2. अपनी फीचर ब्रांच बनाएँ (`git checkout -b feature/AmazingFeature`)
3. अपने परिवर्तन कमिट करें (`git commit -m 'Add some AmazingFeature'`)
4. ब्रांच पर पुश करें (`git push origin feature/AmazingFeature`)
5. एक **Pull Request** खोलें

---

## 📞 समर्थन और प्रतिक्रिया

- 🐛 **समस्या रिपोर्ट**: [GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **QQ समूह**: 1040201322
- 📖 **विस्तृत दस्तावेज़**: [दस्तावेज़ देखें](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 ओपन सोर्स लाइसेंस

इस परियोजना को [AGPL-3.0 license](LICENSE) ओपन सोर्स लाइसेंस के तहत जारी किया गया है।

---

## 👨‍💻 लेखक के बारे में

यह परियोजना **又菜又爱玩的小朱** द्वारा स्वतंत्र रूप से विकसित और अनुरक्षित है।

यदि यह परियोजना आपके लिए उपयोगी है, तो कृपया एक ⭐ Star देकर समर्थन करें!

---

## 📈 परियोजना सांख्यिकी

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 गेम सर्वर प्रबंधन को सरल और मज़ेदार बनाइए!**

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---