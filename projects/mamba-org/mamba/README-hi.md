# Mamba: तेज़ क्रॉस-प्लेटफ़ॉर्म पैकेज मैनेजर

![mamba हेडर इमेज](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">mamba-org का हिस्सा</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">पैकेज मैनेजर <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">पैकेज सर्वर <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Gitter चैट से जुड़ें](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` C++ में conda पैकेज मैनेजर का पुनः कार्यान्वयन है।

- मल्टी-थ्रेडिंग का उपयोग करके रिपॉजिटरी डेटा और पैकेज फ़ाइलों की समानांतर डाउनलोडिंग
- libsolv का उपयोग, जो निर्भरता समाधान को बहुत तेज़ बनाता है, यह एक अत्याधुनिक लाइब्रेरी है जिसका उपयोग Red Hat, Fedora और OpenSUSE के RPM पैकेज मैनेजर में होता है
- `mamba` के मुख्य भाग अधिकतम दक्षता के लिए C++ में लागू किए गए हैं

साथ ही, `mamba` वही कमांड लाइन पार्सर, पैकेज इंस्टॉलेशन और अनइंस्टॉलेशन कोड, और लेन-देन सत्यापन रूटीन उपयोग करता है जो `conda` में होते हैं, जिससे यह अधिकतम संगत रहता है।

`mamba` [conda-forge](https://conda-forge.org/) ईकोसिस्टम का हिस्सा है, जिसमें `quetz` भी शामिल है, जो एक ओपन सोर्स `conda` पैकेज सर्वर है।

आप हमारा [घोषणा ब्लॉग पोस्ट](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23) पढ़ सकते हैं।

## micromamba

`micromamba` `mamba` का स्टेटिकली लिंक्ड वर्शन है।

इसे एक स्टैंडअलोन एक्जीक्यूटेबल के रूप में बिना किसी डिपेंडेंसी के इंस्टॉल किया जा सकता है, जिससे यह CI/CD पाइपलाइनों और कंटेनरीकृत एन्वायरनमेंट्स के लिए उपयुक्त बनता है।

विवरण के लिए [`micromamba` पर डाक्यूमेंटेशन](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) देखें।

## `mamba` बनाम `micromamba`

`mamba` को वरीयता दें जब:

- `libmambapy` या `libmamba` का उपयोग उसी एन्वायरनमेंट में अन्य सॉफ्टवेयर द्वारा किया जाता है।
- ऐसे परिदृश्य जहां नियमित रूप से लाइब्रेरी अपडेट की आवश्यकता होती है (विशेषकर सुरक्षा के लिए)।
- एन्वायरनमेंट्स में डिपेंडेंसी के लिए डिस्क स्पेस कम करना प्राथमिकता है।

`micromamba` को वरीयता दें जब:

- केवल एक सिंगल, सेल्फ-कंटेंड एक्जीक्यूटेबल पर निर्भर रहना आवश्यक हो।
- मिनीफोर्ज डिस्ट्रीब्यूशन मौजूद न हो।
- न्यूनतम रनटाइम की आवश्यकता हो।

## इंस्टॉलेशन

कृपया डाक्यूमेंटेशन में दिए गए [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
और [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) इंस्टॉलेशन गाइड देखें।

## Mamba और Micromamba में अतिरिक्त सुविधाएँ

`mamba` और `micromamba` में स्टॉक `conda` के ऊपर अतिरिक्त फीचर्स होते हैं।

### `repoquery`

रिपॉजिटरीज़ और पैकेज डिपेंडेंसीज़ को कुशलतापूर्वक क्वेरी करने के लिए आप `mamba repoquery` या `micromamba repoquery` का उपयोग कर सकते हैं।

विवरण के लिए [repoquery डाक्यूमेंटेशन](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) देखें।

### लॉक फाइल इंस्टॉल करना

[conda-lock](https://conda.github.io/conda-lock/) द्वारा जनरेट की गई लॉक फाइलों को इंस्टॉल करने के लिए `micromamba` का उपयोग किया जा सकता है, बिना `conda-lock` इंस्टॉल किए।

सिर्फ `micromamba create` को `-f` विकल्प के साथ चलाएँ, जिसमें आप एक एन्वायरनमेंट लॉकफाइल दें, जिसका नाम
`-lock.yml` या `-lock.yaml` पर समाप्त होता हो; उदाहरण के लिए:

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (setup-miniconda का विकल्प)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) का विकल्प है, जो `micromamba` का उपयोग करता है।

यह आपके CI सेटअप समय को काफी कम कर सकता है:

- `micromamba` का उपयोग करके, जिसे इंस्टॉल होने में लगभग 1 सेकंड लगता है।
- पैकेज डाउनलोड्स को कैश करना।
- पूरे `conda` एन्वायरनमेंट्स को कैश करना।

## `conda` से अंतर

जहाँ `mamba` और `micromamba` सामान्यतः `conda` के लिए ड्रॉप-इन रिप्लेसमेंट हैं, वहीं कुछ अंतर हैं:

- `mamba` और `micromamba` रिवीज़न का समर्थन नहीं करते (चर्चा के लिए देखें <https://github.com/mamba-org/mamba/issues/803>)
- `mamba` और `micromamba` `MatchSpec` स्ट्रिंग्स को सबसे सरल रूप में सामान्यीकृत करते हैं, जबकि `conda` अधिक वर्णनात्मक रूप का उपयोग करता है  
  इससे `conda env export` और `mamba env export` के आउटपुट में हल्के अंतर हो सकते हैं।

## डेवलपमेंट इंस्टॉलेशन

कृपया [आधिकारिक डाक्यूमेंटेशन](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html) में दिए गए निर्देशों को देखें।

## API और ABI स्थिरता

Mamba प्रोजेक्ट [semantic versioning](https://semver.org/) का उपयोग करता है, जो `MAJOR.MINOR.PATCH` के रूप में होता है।
जहाँ हम उपयोगकर्ताओं के लिए स्थिरता बनाए रखने की कोशिश करते हैं, वहीं हमें Mamba को बेहतर बनाने और तकनीकी ऋण को कम करने के लिए ब्रेकिंग बदलाव करने पड़ सकते हैं।
Mamba के भविष्य के संस्करणों में और मजबूत गारंटी मिल सकती है।

### `libmamba` (C++)

हमें C++ API के उपभोक्ताओं के बारे में जानकारी नहीं है, इसलिए हम सुधार की पूरी स्वतंत्रता रखते हैं।
`libmamba` के लिए, _backward compatible_ का तात्पर्य निम्नलिखित है:

- _ABI backward compatible_ का अर्थ है कि आप लाइब्रेरी बाइनरी फ़ाइलों को बिना अपने कोड को दोबारा कंपाइल किए बदल सकते हैं।
  देखा गया व्यवहार वही रहेगा, सिवाय बग्स के (जो शायद दूर हो जाएँ) और प्रदर्शन के।
- _API backward compatible_ का अर्थ है कि आपको अपने कोड को नई लाइब्रेरी वर्शन कोड के साथ दोबारा कंपाइल करना होगा, लेकिन कोड में बदलाव की आवश्यकता नहीं होगी, सिर्फ फिर से बनाना होगा।
  जब तक आपने कोई प्राइवेट घोषणा उपयोग नहीं की है, उदाहरण के लिए `detail` सब-नेमस्पेस में।
  देखा गया व्यवहार वही रहेगा, सिवाय बग्स के (जो शायद दूर हो जाएँ) और प्रदर्शन के।
  जब घोषणाएँ डिप्रिकेटेड होती हैं लेकिन हटाई नहीं गईं और अभी भी कार्यात्मक हैं, तो हम इसे भी backward compatible मानते हैं, क्योंकि केवल संकलन के दौरान देखा गया व्यवहार बदलता है।

इसे ध्यान में रखते हुए, `libmamba` निम्नलिखित गारंटी देता है:

- `PATCH` रिलीज़ API और ABI दोनों के लिए backward compatible होती हैं;
- `MINOR` रिलीज़ `mamba/api` में डिक्लेयरशन्स के लिए API compatible होती हैं,
  अन्य जगह API और कहीं भी ABI को तोड़ सकती हैं;
- `MAJOR` रिलीज़ कोई गारंटी नहीं देतीं।

### `libmambapy` (Python)

`libmambapy` के लिए, _API backward compatible_ का अर्थ है कि आपका Python कोड नए वर्शन के साथ वैसे ही चलेगा, जब तक आपने कोई प्राइवेट घोषणा उपयोग नहीं की है, उदाहरण के लिए नाम जो `_` से शुरू होता है।
देखा गया व्यवहार वही रहेगा, सिवाय बग्स के (जो शायद दूर हो जाएँ) और प्रदर्शन के।
जब घोषणाएँ डिप्रिकेटेड होती हैं लेकिन हटाई नहीं गईं और अभी भी कार्यात्मक हैं, तो हम इसे भी backward compatible मानते हैं, क्योंकि व्यवहार केवल तभी देखा जा सकता है जब Python `DeprecationWarning` सक्रिय हो, जो सामान्यतः केवल डेवलपमेंट में होता है।

इसे ध्यान में रखते हुए, `libmambapy` निम्नलिखित गारंटी देता है:

- `PATCH` रिलीज़ API backward compatible होती हैं;
- `MINOR` रिलीज़ API backward compatible होती हैं;
- `MAJOR` रिलीज़ कोई गारंटी नहीं देतीं।

### `mamba` और `micromamba` (executables)

एक्जीक्यूटेबल्स के लिए, _backward compatible_ programmable इनपुट्स और आउटपुट्स पर लागू होता है, और इसका अर्थ है कि आपका कोड (शेल स्क्रिप्ट्स सहित) बिना किसी संशोधन के नए वर्शन के साथ काम करेगा।
प्रोग्रामेबल इनपुट/आउटपुट में executable नाम, कमांड लाइन आर्ग्युमेंट्स, कॉन्फ़िगरेशन फाइल्स, एन्वायरनमेंट वेरिएबल्स, JSON कमांड लाइन आउटपुट्स, और बनाई गई फाइलें शामिल हैं।
यह _human-readable output_ और error messages को बाहर करता है, और इसलिए मानव पठनीय आउटपुट में लिखी गई deprecation warnings पर लागू नहीं होता।

इसे ध्यान में रखते हुए, `mamba` और `micromamba` निम्नलिखित गारंटी देते हैं:

- `PATCH` रिलीज़ backward compatible होती हैं;
- `MINOR` रिलीज़ backward compatible होती हैं;
- `MAJOR` रिलीज़ कोई गारंटी नहीं देतीं।

## हमारा समर्थन करें

केवल `mamba` और `micromamba` 2.0 और बाद के वर्शन समर्थित हैं और सक्रिय रूप से विकसित किए जा रहे हैं।

`1.x` ब्रांच केवल सुरक्षा समस्याओं जैसे कि CVEs को संबोधित करने के लिए मेंटेन की जाती है।

प्रश्नों के लिए, आप [QuantStack चैट](https://gitter.im/QuantStack/Lobby)
या [Conda चैनल](https://gitter.im/conda/conda) में भी शामिल हो सकते हैं (ध्यान दें कि यह प्रोजेक्ट आधिकारिक रूप से `conda` या Anaconda Inc. से संबद्ध नहीं है)।

## लाइसेंस

हम एक साझा कॉपीराइट मॉडल का उपयोग करते हैं, जो सभी योगदानकर्ताओं को उनके योगदान पर कॉपीराइट बनाए रखने की अनुमति देता है।

यह सॉफ़्टवेयर BSD-3-Clause लाइसेंस के तहत लाइसेंस प्राप्त है। विवरण के लिए [LICENSE](LICENSE) फाइल देखें।

---

### द्वि-साप्ताहिक डेवलपर मीटिंग

हम हर दो सप्ताह में वीडियो कॉन्फ़्रेंस मीटिंग करते हैं, जिसमें हम अपनी प्रगति पर चर्चा करते हैं और एक-दूसरे से फीडबैक प्राप्त करते हैं।

कोई भी शामिल हो सकता है, यदि वे किसी विषय पर चर्चा करना चाहते हैं या केवल सुनना चाहते हैं।

- कब: मंगलवार [4:00 PM CET (यूरोप)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- कहाँ: [Mamba jitsi](https://meet.jit.si/mamba-org)
- क्या: [मीटिंग नोट्स](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---