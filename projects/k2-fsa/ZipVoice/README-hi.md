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

## फ्लो मैचिंग के साथ तेज़ और उच्च गुणवत्ता वाली शून्य-शॉट टेक्स्ट-टू-स्पीच
</div>

## अवलोकन

ZipVoice फ्लो मैचिंग पर आधारित तेज़ और उच्च गुणवत्ता वाली शून्य-शॉट TTS मॉडल्स की एक श्रृंखला है।

### 1. मुख्य विशेषताएँ

- छोटा और तेज़: केवल 123M पैरामीटर्स।

- उच्च गुणवत्ता वाली वॉयस क्लोनिंग: स्पीकर समानता, बोधगम्यता और स्वाभाविकता में अत्याधुनिक प्रदर्शन।

- बहु-भाषी: चीनी और अंग्रेज़ी का समर्थन।

- बहु-मोड: एकल-वक्ता और संवाद भाषण निर्माण दोनों का समर्थन।

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
      <td>मूलभूत मॉडल, जो चीनी और अंग्रेज़ी दोनों में शून्य-शॉट एकल-वक्ता TTS का समर्थन करता है।</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>ZipVoice का डिस्टिल्ड संस्करण, जिसमें न्यूनतम प्रदर्शन हानि के साथ बेहतर गति है।</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>ZipVoice पर आधारित एक संवाद निर्माण मॉडल, जो एकल-चैनल दो-पक्षीय बोले गए संवाद जनरेट कर सकता है।</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>ZipVoice-Dialog का स्टीरियो वेरिएंट, जिसमें प्रत्येक वक्ता को अलग चैनल सौंपकर दो-चैनल संवाद उत्पन्न किया जा सकता है।</td>
    </tr>
  </tbody>
</table>

## समाचार

**2025/07/14**: **ZipVoice-Dialog** और **ZipVoice-Dialog-Stereo**, दो बोले जाने वाले संवाद निर्माण मॉडल्स जारी किए गए हैं। [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: **OpenDialog** डेटासेट, 6.8k-घंटे का बोले जाने वाला संवाद डेटासेट, जारी किया गया है। डाउनलोड करें [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog)। विवरण देखें [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318)।

**2025/06/16**: **ZipVoice** और **ZipVoice-Distill** जारी किए गए हैं। [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## इंस्टॉलेशन

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


```
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
- `--model-name` को `zipvoice` या `zipvoice_distill` सेट किया जा सकता है, जो क्रमशः डिस्टिलेशन से पहले और बाद के मॉडल हैं।
- यदि पाठ में `<>` या `[]` दिखाई देते हैं, तो उनके द्वारा संलग्न स्ट्रिंग्स को विशेष टोकन के रूप में माना जाएगा। `<>` चीनी पिनयिन को दर्शाता है और `[]` अन्य विशेष टैग्स को।
- `zipvoice.bin.infer_zipvoice_onnx` के साथ ONNX मॉडल्स को CPU पर तेज़ी से चला सकते हैं।

> **ध्यान दें:** यदि आपको HuggingFace से कनेक्ट करने में समस्या हो रही है, तो आज़माएँ:
> ```bash
> export HF_ENDPOINT=https://hf-mirror.com
> ```

#### 1.2 वाक्य सूची का इनफेरेंस


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
- `prompt_transcription` वार्तालाप संकेत वेव का ट्रांसक्रिप्शन है, जैसे, "[S1] हेलो। [S2] आप कैसे हैं?"
- `prompt_wav` संकेत वेव का पथ है।
- `text` वह पाठ है जिसे सिंथेसाइज़ किया जाना है, जैसे "[S1] मैं ठीक हूँ। [S2] आपका नाम क्या है?"

(2) **स्प्लिटेड प्रॉम्प्ट फॉर्मेट** जहाँ दो वक्ताओं के ऑडियो और ट्रांसक्रिप्शन अलग-अलग फाइलों में होते हैं:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` आउटपुट वेव फाइल का नाम है।
- `spk1_prompt_transcription` पहले वक्ता के प्रॉम्प्ट वेव की ट्रांसक्रिप्शन है, जैसे, "Hello"
- `spk2_prompt_transcription` दूसरे वक्ता के प्रॉम्प्ट वेव की ट्रांसक्रिप्शन है, जैसे, "How are you?"
- `spk1_prompt_wav` पहले वक्ता के प्रॉम्प्ट वेव फाइल का पथ है।
- `spk2_prompt_wav` दूसरे वक्ता के प्रॉम्प्ट वेव फाइल का पथ है।
- `text` वह टेक्स्ट है जिसे सिंथेसाइज़ किया जाना है, जैसे, "[S1] I'm fine. [S2] What's your name?"

### 3. अन्य सुविधाएँ

#### 3.1 चीनी बहुध्वनिक अक्षरों का गलत उच्चारण सुधारना

हम [pypinyin](https://github.com/mozillazg/python-pinyin) का उपयोग चीनी अक्षरों को पिनयिन में बदलने के लिए करते हैं। हालांकि, यह कभी-कभी **बहुध्वनिक अक्षरों** (多音字) का गलत उच्चारण कर सकता है।

इन गलत उच्चारणों को मैन्युअली सुधारने के लिए, **सही पिनयिन** को कोणीय ब्रैकेट `< >` में रखें और **स्वर चिन्ह** शामिल करें।

**उदाहरण:**

- मूल टेक्स्ट: `这把剑长三十公分`
- `长` का पिनयिन सुधारें:  `这把剑<chang2>三十公分`

> **नोट:** यदि आप मैन्युअली एक से अधिक पिनयिन असाइन करना चाहते हैं, तो प्रत्येक पिनयिन को `<>` में रखें, जैसे, `这把<jian4><chang2><san1>十公分`

## अपना मॉडल ट्रेन करें

ट्रेनिंग, फाइन-ट्यूनिंग और इवैल्युएशन के उदाहरणों के लिए [egs](egs) डायरेक्टरी देखें।

## चर्चा और संवाद

आप सीधे [Github Issues](https://github.com/k2-fsa/ZipVoice/issues) पर चर्चा कर सकते हैं।

आप हमारे वीचैट ग्रुप में शामिल होने या हमारे वीचैट ऑफिशियल अकाउंट को फॉलो करने के लिए क्यूआर कोड भी स्कैन कर सकते हैं।

| वीचैट ग्रुप | वीचैट ऑफिशियल अकाउंट |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## संदर्भ


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---