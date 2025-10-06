
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## फ्लो मैचिंग के साथ तेज़ और उच्च गुणवत्ता वाली ज़ीरो-शॉट टेक्स्ट-टू-स्पीच
</div>

## अवलोकन

ZipVoice एक तेज़ और उच्च-गुणवत्ता वाली ज़ीरो-शॉट TTS मॉडल श्रृंखला है, जो फ्लो मैचिंग पर आधारित है।

### 1. मुख्य विशेषताएँ

- छोटा और तेज़: केवल 123M पैरामीटर।

- उच्च गुणवत्ता वाली वॉयस क्लोनिंग: वक्ता समानता, स्पष्टता और प्राकृतिकता में अत्याधुनिक प्रदर्शन।

- बहुभाषी: चीनी और अंग्रेज़ी का समर्थन करता है।

- बहु-मोड: एकल वक्ता और संवाद भाषण जनरेशन दोनों का समर्थन करता है।

### 2. मॉडल वेरिएंट्स

<table>
  <thead>
    <tr>
      <th>मॉडल नाम</th>
      <th>विवरण</th>
      <th>पेपर</th>
      <th>डेमो</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>मूल मॉडल जो चीनी और अंग्रेज़ी में ज़ीरो-शॉट एकल-वक्ता TTS का समर्थन करता है।</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>ZipVoice का डिस्टिल्ड संस्करण, जिसमें न्यूनतम प्रदर्शन हानि के साथ बेहतर गति है।</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>ZipVoice पर आधारित एक संवाद जनरेशन मॉडल, जो एकल-चैनल दो-पक्षीय बोले गए संवाद उत्पन्न कर सकता है।</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>ZipVoice-Dialog का स्टीरियो संस्करण, जो दो-चैनल संवाद निर्माण सक्षम करता है, जिसमें प्रत्येक वक्ता को एक अलग चैनल सौंपा जाता है।</td>
    </tr>
  </tbody>
</table>

## समाचार

**2025/07/14**: **ZipVoice-Dialog** और **ZipVoice-Dialog-Stereo**, दो बोले गए संवाद निर्माण मॉडल जारी किए गए हैं। [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: **OpenDialog** डेटासेट, एक 6.8k-घंटे की बोले गए संवाद डेटासेट, जारी की गई है। डाउनलोड करें [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog)। विवरण देखें [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** और **ZipVoice-Distill** जारी किए गए हैं। [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## स्थापना

### 1. ZipVoice रिपॉजिटरी क्लोन करें

```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (वैकल्पिक) एक पायथन वर्चुअल एनवायरनमेंट बनाएं


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. आवश्यक पैकेज इंस्टॉल करें


```bash
pip install -r requirements.txt
```
### 4. प्रशिक्षण या कुशल अनुकरण के लिए k2 स्थापित करें

**प्रशिक्षण के लिए k2 आवश्यक है** और यह अनुकरण को तेज कर सकता है। फिर भी, आप k2 स्थापित किए बिना भी ZipVoice के अनुकरण मोड का उपयोग कर सकते हैं।

> **नोट:**  सुनिश्चित करें कि आप अपने PyTorch और CUDA संस्करण के अनुसार k2 का संस्करण स्थापित कर रहे हैं। उदाहरण के लिए, यदि आप pytorch 2.5.1 और CUDA 12.1 उपयोग कर रहे हैं, तो आप इस प्रकार k2 स्थापित कर सकते हैं:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
कृपया विवरण के लिए https://k2-fsa.org/get-started/k2/ देखें।
चीन मुख्यभूमि के उपयोगकर्ता https://k2-fsa.org/zh-CN/get-started/k2/ देख सकते हैं।

- k2 इंस्टॉलेशन जांचने के लिए:


```bash
python3 -c "import k2; print(k2.__file__)"
```
## उपयोग

### 1. एकल-वक्ता भाषण जनरेशन

हमारे प्री-ट्रेंड ZipVoice या ZipVoice-Distill मॉडल के साथ एकल-वक्ता भाषण जनरेट करने के लिए, निम्नलिखित कमांड्स का उपयोग करें (आवश्यक मॉडल HuggingFace से डाउनलोड किए जाएंगे):

#### 1.1 एकल वाक्य का इनफरेंस


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` को `zipvoice` या `zipvoice_distill` सेट किया जा सकता है, जो क्रमशः आसवन से पहले और बाद के मॉडल हैं।
- यदि पाठ में `<>` या `[]` आते हैं, तो उनके भीतर बंद स्ट्रिंग्स को विशेष टोकन के रूप में माना जाएगा। `<>` चीनी पिनयिन को दर्शाता है और `[]` अन्य विशेष टैग को दर्शाता है।

#### 1.2 वाक्यों की सूची का अनुमान

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- `test.tsv` की प्रत्येक पंक्ति इस प्रारूप में होती है: `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`।

### 2. संवाद भाषण निर्माण

#### 2.1 पूर्वानुमान कमांड

हमारे प्री-ट्रेंड ZipVoice-Dialogue या ZipVoice-Dialogue-Stereo मॉडल के साथ दो-पक्षीय बोले गए संवाद उत्पन्न करने के लिए, निम्नलिखित कमांड का उपयोग करें (आवश्यक मॉडल HuggingFace से डाउनलोड किए जाएंगे):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` या तो `zipvoice_dialog` या `zipvoice_dialog_stereo` हो सकता है,
    जो क्रमशः मोनो और स्टीरियो संवाद उत्पन्न करते हैं।

#### 2.2 इनपुट प्रारूप

`test.tsv` की प्रत्येक पंक्ति निम्नलिखित प्रारूपों में से एक में होती है:

(1) **मर्ज्ड प्रॉम्प्ट प्रारूप** जिसमें दो वक्ताओं के प्रॉम्प्ट ऑडियो और ट्रांसक्रिप्शन को एक प्रॉम्प्ट वेव फ़ाइल में मर्ज कर दिया जाता है:

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```

- `wav_name` आउटपुट वेव फाइल का नाम है।
- `prompt_transcription` वार्तालाप संकेत वेव की ट्रांसक्रिप्शन है, उदाहरण के लिए, "[S1] हैलो। [S2] आप कैसे हैं?"
- `prompt_wav` संकेत वेव का पथ है।
- `text` वह टेक्स्ट है जिसे सिंथेसाइज़ किया जाना है, जैसे कि "[S1] मैं ठीक हूँ। [S2] आपका नाम क्या है? [S1] मेरा नाम एरिक है। [S2] हाय एरिक।"

(2) **विभाजित संकेत प्रारूप** जिसमें दो वक्ताओं की ऑडियो और ट्रांसक्रिप्शन अलग-अलग फाइलों में होती हैं:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` आउटपुट वेव फाइल का नाम है।
- `spk1_prompt_transcription` पहले स्पीकर की प्रॉम्प्ट वेव का ट्रांसक्रिप्शन है, उदाहरण के लिए, "Hello"
- `spk2_prompt_transcription` दूसरे स्पीकर की प्रॉम्प्ट वेव का ट्रांसक्रिप्शन है, उदाहरण के लिए, "How are you?"
- `spk1_prompt_wav` पहले स्पीकर की प्रॉम्प्ट वेव फाइल का पथ है।
- `spk2_prompt_wav` दूसरे स्पीकर की प्रॉम्प्ट वेव फाइल का पथ है।
- `text` वह पाठ है जिसे सिंथेसाइज़ किया जाना है, उदाहरण के लिए, "[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric."

### 3 बेहतर उपयोग के लिए मार्गदर्शन:

#### 3.1 प्रॉम्प्ट की लंबाई

हम एक छोटी प्रॉम्प्ट वेव फाइल की सिफारिश करते हैं (जैसे, एकल-वक्ता स्पीच जनरेशन के लिए 3 सेकंड से कम, संवाद स्पीच जनरेशन के लिए 10 सेकंड से कम) ताकि अनुमान की गति तेज हो। बहुत लंबी प्रॉम्प्ट अनुमान को धीमा कर देगी और स्पीच गुणवत्ता को खराब करेगी।

#### 3.2 गति अनुकूलन

अगर अनुमान की गति संतोषजनक नहीं है, तो आप इसे निम्नलिखित तरीकों से तेज कर सकते हैं:

- **डिस्टिल मॉडल और कम स्टेप्स**: एकल-वक्ता स्पीच जनरेशन मॉडल के लिए, हम बेहतर स्पीच गुणवत्ता के लिए डिफॉल्ट रूप से `zipvoice` मॉडल का उपयोग करते हैं। अगर तेज गति प्राथमिकता है, तो आप `zipvoice_distill` पर स्विच कर सकते हैं और `--num-steps` को न्यूनतम `4` (डिफॉल्ट 8) तक घटा सकते हैं।

- **CPU गति वृद्धि मल्टी-थ्रेडिंग के साथ**: जब CPU पर रन कर रहे हों, तो आप तेजी के लिए `--num-thread` पैरामीटर (जैसे, `--num-thread 4`) पास कर सकते हैं ताकि थ्रेड्स की संख्या बढ़ जाए। हम डिफॉल्ट रूप से 1 थ्रेड का उपयोग करते हैं।

- **CPU गति वृद्धि ONNX के साथ**: जब CPU पर रन कर रहे हों, तो आप तेज गति के लिए ONNX मॉडल `zipvoice.bin.infer_zipvoice_onnx` का उपयोग कर सकते हैं (संवाद जनरेशन मॉडल के लिए ONNX का समर्थन नहीं है)। और तेज गति के लिए, आप `--onnx-int8 True` सेट कर सकते हैं ताकि INT8-क्वांटाइज़्ड ONNX मॉडल का उपयोग हो सके। ध्यान दें कि क्वांटाइज़्ड मॉडल से स्पीच गुणवत्ता में कुछ हद तक गिरावट आएगी। **GPU पर ONNX का उपयोग न करें**, क्योंकि यह GPU पर PyTorch से धीमा है।

#### 3.3 मेमोरी नियंत्रण

दिया गया पाठ विराम चिह्न (एकल-वक्ता स्पीच जनरेशन के लिए) या स्पीकर-टर्न प्रतीक (संवाद स्पीच जनरेशन के लिए) के आधार पर टुकड़ों में विभाजित किया जाएगा। फिर, टुकड़ों में किए गए पाठ बैचों में संसाधित किए जाएंगे। इसलिए, मॉडल लगभग स्थिर मेमोरी उपयोग के साथ कितनी भी लंबी टेक्स्ट को प्रोसेस कर सकता है। आप `--max-duration` पैरामीटर को समायोजित करके मेमोरी उपयोग नियंत्रित कर सकते हैं।

#### 3.4 "रॉ" मूल्यांकन

डिफॉल्ट रूप से, हम कुशल अनुमान और बेहतर प्रदर्शन के लिए इनपुट्स (प्रॉम्प्ट वेव, प्रॉम्प्ट ट्रांसक्रिप्शन, और टेक्स्ट) को पूर्व-संसाधित करते हैं। यदि आप मॉडल की "रॉ" प्रदर्शन को सटीक दिए गए इनपुट्स के साथ आंकना चाहते हैं (जैसे, हमारे पेपर के परिणामों को पुन: उत्पन्न करने के लिए), तो आप `--raw-evaluation True` पास कर सकते हैं।

#### 3.5 छोटा पाठ

बहुत छोटे पाठ (जैसे, एक या दो शब्द) के लिए स्पीच जनरेट करते समय, कभी-कभी उत्पन्न स्पीच में कुछ उच्चारण छूट सकते हैं। इस समस्या को हल करने के लिए, आप `--speed 0.3` (जहां 0.3 एक समायोज्य मान है) पास कर सकते हैं ताकि उत्पन्न स्पीच की अवधि बढ़ सके।

#### 3.6 चीनी बहुध्वन्य अक्षरों के गलत उच्चारण को सुधारना

हम चीनी अक्षरों को पिनयिन में बदलने के लिए [pypinyin](https://github.com/mozillazg/python-pinyin) का उपयोग करते हैं। हालांकि, यह कभी-कभी **बहुध्वन्य अक्षरों** (多音字) का गलत उच्चारण कर सकता है।


इन गलत उच्चारणों को मैन्युअली ठीक करने के लिए, **सही पिनयिन** को कोणीय ब्रैकेट `< >` में रखें और **स्वर चिह्न** शामिल करें।

**उदाहरण:**

- मूल पाठ: `这把剑长三十公分`
- `长` के पिनयिन को ठीक करें:  `这把剑<chang2>三十公分`

> **नोट:** यदि आप मैन्युअली कई पिनयिन देना चाहते हैं, तो प्रत्येक पिनयिन को `<>` में रखें, जैसे `这把<jian4><chang2><san1>十公分`

#### 3.7 जेनरेटेड स्पीच से लंबी चुप्पियों को हटाएं

मॉडल जेनरेटेड स्पीच में चुप्पियों की स्थिति और लंबाई को स्वतः निर्धारित करेगा। कभी-कभी यह स्पीच के मध्य में लंबी चुप्पी डाल देता है। यदि आप ऐसा नहीं चाहते हैं, तो आप `--remove-long-sil` पास कर सकते हैं ताकि जेनरेटेड स्पीच के मध्य की लंबी चुप्पियाँ हट जाएँ (किनारों की चुप्पियाँ डिफ़ॉल्ट रूप से हटा दी जाएंगी)।

#### 3.8 मॉडल डाउनलोडिंग

यदि प्री-ट्रेंड मॉडल डाउनलोड करते समय आपको HuggingFace से कनेक्ट करने में समस्या आ रही है, तो एंडपॉइंट को मिरर साइट पर स्विच करने का प्रयास करें: `export HF_ENDPOINT=https://hf-mirror.com`।

## अपना खुद का मॉडल ट्रेन करें

ट्रेनिंग, फाइन-ट्यूनिंग और मूल्यांकन उदाहरणों के लिए [egs](egs) डायरेक्टरी देखें।

## C++ डिप्लॉयमेंट

सीपीयू पर C++ डिप्लॉयमेंट सॉल्यूशन के लिए [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) देखें।

## चर्चा और संवाद

आप सीधे [Github Issues](https://github.com/k2-fsa/ZipVoice/issues) पर चर्चा कर सकते हैं।

आप हमारा वीचैट ग्रुप जॉइन करने या हमारे वीचैट ऑफिशियल अकाउंट को फॉलो करने के लिए क्यूआर कोड भी स्कैन कर सकते हैं।

| वीचैट ग्रुप | वीचैट ऑफिशियल अकाउंट |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## उद्धरण

```bibtex
@article{zhu2025zipvoice,
      title={ZipVoice: Fast and High-Quality Zero-Shot Text-to-Speech with Flow Matching},
      author={Zhu, Han and Kang, Wei and Yao, Zengwei and Guo, Liyong and Kuang, Fangjun and Li, Zhaoqing and Zhuang, Weiji and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2506.13053},
      year={2025}
}

@article{zhu2025zipvoicedialog,
      title={ZipVoice-Dialog: Non-Autoregressive Spoken Dialogue Generation with Flow Matching},
      author={Zhu, Han and Kang, Wei and Guo, Liyong and Yao, Zengwei and Kuang, Fangjun and Zhuang, Weiji and Li, Zhaoqing and Han, Zhifeng and Zhang, Dong and Zhang, Xin and Song, Xingchen and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2507.09318},
      year={2025}
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---