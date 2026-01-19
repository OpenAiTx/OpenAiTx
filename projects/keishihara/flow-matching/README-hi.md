
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# पायटॉर्च में फ्लो मैचिंग

यह रिपॉजिटरी पेपर [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747) का एक सरल पायटॉर्च इम्प्लीमेंटेशन प्रदान करती है।

## 2D फ्लो मैचिंग उदाहरण

नीचे दिया गया gif एक एकल गॉसियन वितरण को एक चेकरबोर्ड वितरण में मैप करने का प्रदर्शन करता है, जिसमें वेक्टर फील्ड को विज़ुअलाइज़ किया गया है।

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

और, यहाँ moons डेटासेट का एक और उदाहरण है।

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## शुरुआत कैसे करें

रिपॉजिटरी को क्लोन करें और python वातावरण सेटअप करें।

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

सुनिश्चित करें कि आपके पास Python 3.12+ स्थापित है।
`uv` इंस्टॉल करें:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```
फिर, परिवेश सेट करें:


```bash
uv sync
```

## कंडीशनल फ्लो मैचिंग [लिपमैन+ 2023]

यह मूल CFM पेपर इम्प्लीमेंटेशन है [1]। कोड के कुछ घटक [2] और [3] से अनुकूलित किए गए हैं।

### 2डी टॉय डेटासेट्स

आप 2डी सिंथेटिक डेटासेट्स जैसे `चेकरबोर्ड` और `मून्स` पर CFM मॉडल्स को ट्रेन कर सकते हैं। डेटासेट का नाम `--dataset` विकल्प के द्वारा निर्दिष्ट करें। ट्रेनिंग पैरामीटर्स स्क्रिप्ट में पूर्वनिर्धारित हैं, और ट्रेनिंग परिणामों के विज़ुअलाइज़ेशन `outputs/` डायरेक्टरी में स्टोर होते हैं। मॉडल चेकपॉइंट्स शामिल नहीं हैं क्योंकि वे डिफ़ॉल्ट सेटिंग्स के साथ आसानी से दोबारा बनाए जा सकते हैं।

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

वेक्टर फील्ड्स और जेनरेटेड सैम्पल्स, जैसे कि इस README के ऊपर GIFs के रूप में दिखाए गए हैं, अब `outputs/cfm/` डायरेक्टरी में पाए जा सकते हैं।

### इमेज डेटासेट्स

आप लोकप्रिय इमेज क्लासिफिकेशन डेटासेट्स पर क्लास-कंडीशनल CFM मॉडल्स भी ट्रेन कर सकते हैं। दोनों, जेनरेटेड सैम्पल्स और मॉडल चेकपॉइंट्स, `outputs/cfm` डायरेक्टरी में स्टोर किए जाएंगे। ट्रेनिंग पैरामीटर्स की विस्तृत सूची के लिए, `uv run scripts/train_flow_matching_on_image.py --help` चलाएं।

MNIST डेटासेट पर क्लास-कंडीशनल CFM ट्रेन करने के लिए, निम्नलिखित कमांड चलाएं:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```
प्रशिक्षण के बाद, अब आप नमूने उत्पन्न कर सकते हैं:


```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```
अब, आप `outputs/cfm/mnist/` डायरेक्टरी में जेनरेट किए गए नमूनों को देख सकते हैं।

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## रेक्टिफाइड फ्लो [Liu+ 2023]

यह रेक्टिफाइड फ्लो पेपर [2] से Reflow मॉडल (विशेष रूप से 2-Rectified Flow) का एक इम्प्लीमेंटेशन है।

### 2D सिंथेटिक डेटा

हमने Reflow को 2D सिंथेटिक डेटासेट्स पर लागू किया है, ठीक उसी तरह जैसे CFM पर किया गया था। Reflow को ट्रेन करने के लिए आपको प्री-ट्रेंड CFM चेकपॉइंट्स को निर्दिष्ट करना होगा क्योंकि Reflow एक डिस्टिलेशन मॉडल है।

उदाहरण के लिए, `checkerboard` डेटासेट पर प्री-ट्रेंड CFM चेकपॉइंट के साथ ट्रेन करने के लिए:


```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

प्रशिक्षण परिणाम, जिसमें वेक्टर क्षेत्र दृश्यावलोकन और उत्पन्न नमूने शामिल हैं, `outputs/reflow/` फ़ोल्डर के अंतर्गत सहेजे जाते हैं।

### CFM और Reflow के बीच सैंपलिंग प्रक्रिया की तुलना

CFM और Reflow की तुलना करने के लिए 2d डेटासेट्स पर, निम्नलिखित चलाएँ:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```
उत्पन्न GIFs को `outputs/comparisons/` फोल्डर में पाया जा सकता है। नीचे `checkerboard` डेटासेट में दो विधियों की तुलना का एक उदाहरण दिया गया है:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## संदर्भ

- [1] लिपमैन, यारोन, आदि। "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] लियू, शिंगचाओ, आदि। "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---