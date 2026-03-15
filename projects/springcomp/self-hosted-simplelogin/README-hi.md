<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# SimpleLogin

यह [SimpleLogin](https://simplelogin.io) के लिए एक स्व-होस्टेड docker-compose कॉन्फ़िगरेशन है।

## पूर्व आवश्यकताएँ

- एक Linux सर्वर (या तो VM या समर्पित सर्वर)। यह दस्तावेज Ubuntu 18.04 LTS के लिए सेटअप दिखाता है लेकिन अन्य लोकप्रिय Linux वितरणों के लिए भी ये चरण अनुकूलित किए जा सकते हैं। चूंकि अधिकांश घटक Docker कंटेनर के रूप में चलते हैं और Docker थोड़ा भारी हो सकता है, कम से कम 2 GB RAM होना अनुशंसित है। सर्वर पर पोर्ट 25 (ईमेल), 80, 443 (वेबऐप के लिए), 22 (ताकि आप ssh कर सकें) खुले होने चाहिए।


- एक डोमेन जिसके लिए आप DNS कॉन्फ़िगर कर सकते हैं। यह एक उप-डोमेन भी हो सकता है। इस दस्तावेज़ के बाकी हिस्से में, मान लीजिए कि ईमेल के लिए यह `mydomain.com` है और SimpleLogin वेबऐप के लिए `app.mydomain.com` है। कृपया सुनिश्चित करें कि जब भी ये मान दस्तावेज़ में आएं, तो आप उन्हें अपने डोमेन नाम और उप-डोमेन नाम से बदल दें। एक तरकीब जो हम इस्तेमाल करते हैं, वह यह है कि आप इस README फ़ाइल को अपने कंप्यूटर पर डाउनलोड करें और सभी `mydomain.com` और `app.mydomain.com` स्थानों को अपने डोमेन से बदल दें।

DNS सेटअप को छोड़कर, जो आम तौर पर आपके डोमेन रजिस्ट्रार इंटरफेस पर किया जाता है, नीचे दिए गए सभी चरण आपके सर्वर पर किए जाने हैं। कमांड्स को `bash` (या किसी भी bash-संगत शेल जैसे `zsh`) में चलाना है। यदि आप अन्य शेल जैसे `fish` का उपयोग करते हैं, तो कृपया कमांड्स को उसके अनुसार अनुकूलित करें।

- कुछ यूटिलिटी पैकेज जो सेटअप को सत्यापित करने के लिए उपयोग किए जाते हैं। इन्हें इस प्रकार इंस्टॉल करें:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```
## DNS कॉन्फ़िगरेशन

_अधिक विवरण के लिए [संदर्भ दस्तावेज़](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) देखें_

> **कृपया ध्यान दें** कि DNS परिवर्तन को प्रचारित होने में 24 घंटे तक लग सकते हैं। हालांकि व्यवहार में, यह बहुत तेज़ होता है (हमारे परीक्षण में लगभग 1 मिनट)। DNS सेटअप में, हम आमतौर पर डोमेन के अंत में एक डॉट (`.`) का उपयोग करते हैं ताकि पूर्ण डोमेन का उपयोग सुनिश्चित किया जा सके।

आपको निम्नलिखित DNS रिकॉर्ड सेटअप करने होंगे:

- **A**: आपके डोमेन को आपके सर्वर के IPv4 पते से मैप करता है।
- **AAAA**: आपके डोमेन को आपके सर्वर के IPv6 पते से मैप करता है।
- **MX**: आने वाले ईमेल्स को आपके मेल सर्वर पर निर्देशित करता है (इसमें `*` वाइल्डकार्ड्स भी शामिल हैं)।
- **PTR**: आपके सर्वर के आईपी पते को आपके डोमेन नाम से मैप करता है।

अनिवार्य सुरक्षा नीतियाँ सेट करें:

- **DKIM**: आउटगोइंग ईमेल्स को डिजिटल रूप से साइन करता है ताकि प्रामाणिकता सत्यापित हो सके।
- **DMARC**: परिभाषित करता है कि ईमेल रिसीवरों को प्रमाणीकरण विफल होने वाली ईमेल्स के साथ कैसे व्यवहार करना चाहिए।
- **SPF**: आपके डोमेन से ईमेल भेजने के लिए विशिष्ट मेल सर्वरों को अधिकृत करता है।

अतिरिक्त कदम:

- **CAA**: निर्दिष्ट करता है कि कौन से प्रमाणपत्र प्राधिकरण आपके डोमेन के लिए SSL प्रमाणपत्र जारी करने के लिए अधिकृत हैं।
- **MTA-STS**: मेल सर्वरों के बीच सुरक्षित, एन्क्रिप्टेड कनेक्शन को लागू करता है।
- **TLS-RPT**: ईमेल डिलीवरी सुरक्षा सुधारने के लिए TLS कनेक्शन विफलताओं की रिपोर्ट करता है।

**चेतावनी**: CAA रिकॉर्ड सेट करने से यह सीमित हो जाएगा कि कौन सा प्रमाणपत्र प्राधिकरण आपके डोमेन के लिए सफलतापूर्वक SSL प्रमाणपत्र जारी कर सकता है।
यह Let’s Encrypt स्टेजिंग सर्वरों से प्रमाणपत्र जारी करने को रोक देगा। आप चाहें तो अपने डोमेन के लिए SSL प्रमाणपत्र सफलतापूर्वक जारी होने के बाद इस DNS रिकॉर्ड को जोड़ सकते हैं।

## डॉकर

यदि आपके सर्वर पर पहले से डॉकर इंस्टॉल नहीं है, तो कृपया [Ubuntu के लिए Docker CE](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) पर दिए गए चरणों का पालन करके डॉकर इंस्टॉल करें।

आप [docker-install](https://github.com/docker/docker-install) स्क्रिप्ट का उपयोग करके भी डॉकर इंस्टॉल कर सकते हैं जो कि


```bash
curl -fsSL https://get.docker.com | sh
```

डिफ़ॉल्ट ब्रिज नेटवर्क के लिए IPv6 सक्षम करें [the default bridge network](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```
यह प्रक्रिया आपको Docker कंटेनरों का उपयोग करके पूरे स्टैक को चलाने के लिए मार्गदर्शन करेगी।
इसमें शामिल हैं:

- traefik
- [SimpleLogin ऐप](https://github.com/simple-login/app) कंटेनर
- postfix

Docker कंटेनरों से SimpleLogin चलाएं:

1. इस रिपॉजिटरी को `/opt/simplelogin` में क्लोन करें
1. `.env.example` को `.env` में कॉपी करें और उपयुक्त मान सेट करें।

    - `DOMAIN` वेरिएबल को अपने डोमेन पर सेट करें।
    - `SUBDOMAIN` वेरिएबल को अपने डोमेन पर सेट करें। डिफ़ॉल्ट मान `app` है।
    - `POSTGRES_USER` वेरिएबल को postgres क्रेडेंशियल्स से मेल करें (शुरुआत में, `simplelogin` का उपयोग करें)।
    - `POSTGRES_PASSWORD` को postgres क्रेडेंशियल्स से मेल करें (शुरुआत में, इसे एक रैंडम कुंजी पर सेट करें)।
    - `FLASK_SECRET` को किसी भी गुप्त कुंजी पर सेट करें।

### Postgres SQL

यह रिपॉजिटरी एक Docker कंटेनर में postgres SQL चलाती है।

**चेतावनी**: इस रिपॉजिटरी के पिछले संस्करण `12.1` पर चलते थे।
कृपया अधिक विवरण और
अपग्रेड निर्देशों के लिए [संदर्भ दस्तावेज़](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) देखें।

### एप्लीकेशन चलाना

निम्नलिखित कमांड्स का उपयोग करके एप्लीकेशन चलाएं:


```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

इस बिंदु पर आप [Certificate Authority Authorization (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) सेटअप करना चाह सकते हैं।

## अगले कदम

यदि उपरोक्त सभी चरण सफल हैं, तो <https://app.mydomain.com/> खोलें और अपना पहला खाता बनाएं!

डिफ़ॉल्ट रूप से, नए खाते प्रीमियम नहीं होते हैं, इसलिए उनमें असीमित उपनाम नहीं होते। अपने खाते को प्रीमियम बनाने के लिए,
कृपया डेटाबेस में जाएं, "users" टेबल में जाएं और "lifetime" कॉलम को "1" या "TRUE" पर सेट करें:

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

जब आपने अपनी सभी इच्छित लॉगिन अकाउंट बना लिए हैं, तो आगे की रजिस्ट्रेशन को बंद करने के लिए ये पंक्तियाँ `.env` में जोड़ें:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```
फिर, वेब ऐप को पुनः प्रारंभ करने के लिए, लागू करें: `docker compose restart app`

## विविध

### Postfix कॉन्फ़िगरेशन - Spamhaus

Spamhaus Project विश्वसनीय IP पतों की सूची बनाए रखता है जिन्हें SPAM के स्रोत के रूप में जाना जाता है।
आप DNS इंफ्रास्ट्रक्चर में क्वेरी सबमिट करके जांच सकते हैं कि कोई दिया गया IP पता उस सूची में है या नहीं।

चूंकि Spamhaus सार्वजनिक (खुला) DNS-Resolvers से आने वाली क्वेरीज़ को ब्लॉक करता है (देखें: <https://check.spamhaus.org/returnc/pub>) और आपका postfix कंटेनर
डिफ़ॉल्ट रूप से सार्वजनिक रिजॉल्वर का उपयोग कर सकता है, इसलिए यह अनुशंसित है कि आप मुफ्त
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
के लिए साइन अप करें और Spamhaus DQS कुंजी प्राप्त करें।

इस कुंजी को अपने `.env` में `SPAMHAUS_DQS_KEY` के रूप में पेस्ट करें

यदि कोई DQS-कुंजी प्रदान नहीं की जाती है, तो आपका postfix कंटेनर जांचेगा कि क्या Spamhaus सार्वजनिक मिरर उसकी क्वेरी स्वीकार कर रहे हैं और उन्हें ही उपयोग करेगा।
यदि Spamhaus आपके postfix कंटेनर से सार्वजनिक मिरर पर क्वेरी को अस्वीकार करता है, तो इसे पूरी तरह से अक्षम कर दिया जाएगा।

### Postfix कॉन्फ़िगरेशन - वर्चुअल एलियास

postfix कॉन्फ़िगरेशन `postfix/conf.d/virtual` और `postfix/conf.d/virtual-regexp` फाइलों के माध्यम से वर्चुअल एलियास का समर्थन करता है।
ये फाइलें संबंधित [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
और [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl) टेम्पलेट फाइलों के आधार पर स्टार्टअप पर स्वचालित रूप से बनाई जाती हैं।

डिफ़ॉल्ट कॉन्फ़िगरेशन निम्नानुसार है:

#### virtual.tpl

`virtual` फाइल postfix `virtual_alias_maps` सेटिंग्स का समर्थन करती है।
यह एक नियम शामिल करती है जो `unknown@mydomain.com` को `contact@mydomain.com` पर मैप करती है ताकि यह दिखाया जा सके कि
और ईमेल एक विशिष्ट पते से प्राप्त किया जा सकता है जो किसी मौजूदा एलियास से मेल नहीं खाता, उसे किसी ऐसे पते पर रीडायरेक्ट किया जा सकता है जो मेल खाता हो।


```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

`virtual-regexp` फ़ाइल postfix `virtual_alias_maps` सेटिंग्स का समर्थन करती है।
इसमें एक नियम शामिल है जो उन ईमेल्स को पुनः लिखता है जो किसी मनमाने सबडोमेन पर संबोधित होते हैं, जो किसी मौजूदा उपनाम से मेल नहीं खाते,
एक नए उपनाम में, जो उस डायरेक्टरी से संबंधित होता है जिसका नाम सबडोमेन से लिया गया है।
वह उपनाम ऑन-द-फ्लाई बनाया जा सकता है यदि वह मौजूद नहीं है।

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```
उदाहरण के लिए, `someone@directory.mydomain.com` पर भेजे गए ईमेल्स को postfix द्वारा `directory/someone@mydomain.com` पर रूट किया जाएगा।

## 3.4.0 से अपग्रेड कैसे करें

_यह अनुभाग [संदर्भ दस्तावेज़](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl) में स्थानांतरित कर दिया गया है_

## पहले के NGinx-आधारित सेटअप से अपग्रेड कैसे करें

_यह अनुभाग [संदर्भ दस्तावेज़](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx) में स्थानांतरित कर दिया गया है_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---