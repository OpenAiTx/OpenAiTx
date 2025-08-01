# wechat2tg-mac

微信 Mac प्रोटोकॉल पर आधारित, Telegram में WeChat संदेश भेजें और प्राप्त करें, wx2tg-server सर्वर सुरक्षा कारणों से ओपन सोर्स नहीं है

## TG समूह: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## मुख्य विशेषताएँ

1. WeChat व्यक्तिगत चैट संदेश, WeChat समूह संदेश, आधिकारिक अकाउंट संदेश और एंटरप्राइज WeChat संदेश प्राप्त करना
2. Telegram से निर्दिष्ट WeChat उपयोगकर्ता, WeChat समूह या आधिकारिक अकाउंट को संदेश भेजना
3. निर्दिष्ट समूहों के संदेशों को ब्लॉक करना

## समर्थित संदेश प्रकार

### WeChat संदेश प्रकार समर्थन सूची

+ [x] टेक्स्ट संदेश
+ [x] एंटरप्राइज WeChat संदेश
+ [x] WeChat इमोजी पैक
+ [x] इमेज संदेश
+ [x] वीडियो संदेश
+ [x] ऑडियो/वीडियो कॉल (केवल संदेश सूचना)
+ [x] फ़ाइल संदेश
+ [x] लिंक संदेश
+ [x] समूह चैट संदेश
+ [x] समूह चैट @संदेश (@सभी और @आप Telegram में @आप में बदल जाएगा)
+ [x] आधिकारिक अकाउंट संदेश
+ [x] emoji
+ [x] स्थान संदेश
+ [x] संदेश वापस लेना
+ [x] वॉयस संदेश
+ [ ] रेड पैकेट संदेश (सूचना, सामग्री प्राप्त नहीं कर सकते)
+ [ ] मिनीप्रोग्राम संदेश

### Telegram संदेश प्रकार समर्थन सूची

+ [x] टेक्स्ट संदेश
+ [x] स्टिकर इमोजी
+ [x] इमेज संदेश
+ [x] वीडियो संदेश
+ [x] फ़ाइल संदेश
+ [x] वॉयस संदेश

## ध्यान देने योग्य बातें

1. यह प्रोजेक्ट केवल तकनीकी अनुसंधान और अध्ययन के लिए है, अवैध उद्देश्यों के लिए उपयोग न करें
2. किसी भी समस्या का सामना हो तो issue सबमिट करने के लिए स्वागत है

## परिनियोजन एवं स्थापना

पहले `.env.example` की एक प्रति बनाकर `.env` नाम से सेव करें, फिर उसमें पर्यावरण वेरिएबल सेट करें

प्रोजेक्ट में `app.conf.example` को `app.conf` के रूप में `conf` डायरेक्टरी में कॉपी करें, Redis एड्रेस को अपने Redis सर्वर के एड्रेस पर सेट करें

### docker-compose

`docker-compose.yml` फ़ाइल बनाएँ:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # फ़ोल्डर माउंट करने के बाद स्टिकर फाइल्स को फिर से कन्वर्ट करने की आवश्यकता नहीं
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # इमेज खींचें
    container_name: wx2tg-server
    ports:
      - "8058:8058"
    volumes:
      - ./conf:/usr/wic-go/conf
    restart: unless-stopped

  wx2tg-redis:
    image: redis:7.2
    container_name: wx2tg-redis
    ports:
      - "16379:6379"
    volumes:
      - ./redis-data:/data
    command: ["redis-server", "--appendonly", "yes"]
    restart: unless-stopped
```

#### चलाएँ

```shell
docker-compose up -d
```

#### बोट गोपनीयता मोड बंद करें

बोट का गोपनीयता मोड बंद करें, BotFather खोलें, `/mybots` टाइप करें, अपना बोट चुनें। `Bot Settings` - `Group Privacy` - `Turn off` पर क्लिक करें, `Privacy mode is disabled for xxx` दिखाई देने पर बंद हो गया है

## उपयोग निर्देश

### BOT आदेश

- `/login`: लॉगिन QR कोड प्राप्त करें; पहली बार डिप्लॉय के दौरान सबसे पहले `/login` भेजने वाला व्यक्ति `BOT` का मालिक बन जाएगा

- `/flogin`: फ़ाइल ट्रांसफर सहायक लॉगिन QR कोड प्राप्त करें, वीडियो और फ़ाइल प्राप्ति का समर्थन

- `/update`: समूह अवतार और उपनाम जानकारी अपडेट करें

- `/message`: समूह संदेश प्राप्ति चालू/बंद करें

- `/forward`: समूह में अन्य लोगों या बोट के संदेश को फॉरवर्ड करने का विकल्प चालू/बंद करें

- `/user`: WeChat उपयोगकर्ता सूची प्राप्त करें; बटन पर क्लिक कर नया समूह बना सकते हैं या उपयोगकर्ता को बाँध सकते हैं (नाम या रिमार्क से सर्च, जैसे: `/user 张` "张" वाले उपयोगकर्ता खोजें)

- `/room`: WeChat समूह सूची प्राप्त करें; बटन पर क्लिक कर नया समूह बना सकते हैं या WeChat समूह को बाँध सकते हैं (नाम या रिमार्क से सर्च, जैसे: `/room 外卖` "外卖" वाले समूह खोजें)

- `/settings`: प्रोग्राम सेटिंग्स

- `/unbind`: WeChat समूह या उपयोगकर्ता को अनबाइंड करें (केवल समूह में समर्थित)

### पर्यावरण वेरिएबल्स विवरण

|नाम| जरूरी या नहीं | विवरण                                                             |
|--|------|----------------------------------------------------------------|
|`BOT_TOKEN`| हाँ    | Telegram Bot का टोकन, [BotFather](https://t.me/BotFather) से बनाएं |
|`API_ID`| हाँ    | Telegram API का API ID                                          |
|`API_HASH`| हाँ    | Telegram API का API HASH                                        |
|`BASE_API`| हाँ    | wx2tg-server कंटेनर का API पता, पूरा पथ भरना ज़रूरी                            | |
|`PROXY_PROTOCOL`| नहीं    | प्रॉक्सी टाइप वैकल्पिक (socks5,http,https)                                     |
|`PROXY_HOST`| नहीं    | प्रॉक्सी का URL                                                        |
|`PROXY_PORT`| नहीं    | प्रॉक्सी पोर्ट नंबर                                                         |
|`PROXY_USERNAME`| नहीं    | प्रॉक्सी यूज़रनेम                                                         |
|`PROXY_PASSWORD`| नहीं    | प्रॉक्सी पासवर्ड                                                          |
|`ROOM_MESSAGE`| नहीं    | BOT में WeChat समूह संदेश का फॉर्मेट                                              |
|`OFFICIAL_MESSAGE`| नहीं    | BOT में आधिकारिक अकाउंट संदेश का फॉर्मेट                                              |
|`CONTACT_MESSAGE`| नहीं    | BOT में WeChat उपयोगकर्ता संदेश का फॉर्मेट                                             |
|`ROOM_MESSAGE_GROUP`| नहीं    | समूह में WeChat समूह संदेश का फॉर्मेट                                                 |
|`CONTACT_MESSAGE_GROUP`| नहीं    | समूह में WeChat उपयोगकर्ता संदेश का फॉर्मेट                                                |
|`OFFICIAL_MESSAGE_GROUP`| नहीं    | समूह में आधिकारिक अकाउंट संदेश का फॉर्मेट                                                 |
|`CREATE_ROOM_NAME`| नहीं    | WeChat समूह के लिए समूह बनाते समय नाम का फॉर्मेट                                           |
|`CREATE_CONTACT_NAME`| नहीं    | WeChat उपयोगकर्ता के लिए समूह बनाते समय नाम का फॉर्मेट                                         |
|`MESSAGE_DISPLAY`| नहीं    | टेक्स्ट संदेश का फॉर्मेट                                                      |

 ---

### सेटिंग्स `/settings` आदेश विवरण

1. WeChat emoji को इमेज लिंक के रूप में दिखाएँ: चालू करने पर दोस्तों द्वारा भेजे गए इमोजी को इमेज लिंक में बदल देगा

2. स्टार्टअप पर समूह जानकारी सिंक करें: चालू करने पर प्रोग्राम स्टार्ट होते ही सभी की जानकारी सिंक होगी, समूह अवतार और नाम अपडेट होंगे

---

### वॉयस टू टेक्स्ट

1. `TENCENT_SECRET_ID` और `TENCENT_SECRET_KEY` कॉन्फ़िगर करें, Tencent [वॉयस रिकॉग्निशन कंसोल](https://console.cloud.tencent.com/asr) में पाएं, मुफ्त कोटा उपलब्ध
2. `/settings` में ऑटो वॉयस टू टेक्स्ट फीचर चालू करें

---

### `API_ID` और `API_HASH` कैसे प्राप्त करें

1. [telegram account](https://my.telegram.org/) में लॉगिन करें

2. "API development tools" पर क्लिक करें और एप्लिकेशन डिटेल्स भरें (केवल टाइटल और शॉर्ट नाम जरूरी)

3. "Create application" पर क्लिक करें

---

### कस्टम संदेश टेम्पलेट

यदि आप संदेश भेजने वाले का फॉर्मेट बदलना चाहते हैं, तो docker के environment variables या `.env` फ़ाइल में संशोधन करें

कस्टम संदेश टेम्पलेट प्लेसहोल्डर:

`#[alias]`: संपर्क रिमार्क

`#[name]`: संपर्क उपनाम

`#[topic]`: समूह उपनाम

`#[alias_first]`: रिमार्क प्राथमिक, न होने पर उपनाम दिखेगा

`#[identity]`: पहचान जानकारी

`#[body]`: संदेश मुख्य भाग

`#[br]`: नई लाइन

### कैसे करें @सभी

`@all` से शुरू होने वाले संदेश भेजें, सभी को टैग किया जाएगा, केवल टेक्स्ट संदेश में @सभी समर्थित है

---

## सामान्य प्रश्न

## विकास में भाग लें

1. प्रोजेक्ट fork करें, `wx2tg-mac-dev` ब्रांच पर जाएं या नई ब्रांच बनाएं। कृपया मुख्य ब्रांच पर सीधे कोड सबमिट न करें
2. Pull Request `wx2tg-mac-dev` ब्रांच पर सबमिट करें

## License

[MIT](LICENSE)

## Thanks

Jetbrains का इस प्रोजेक्ट के समर्थन के लिए धन्यवाद

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---