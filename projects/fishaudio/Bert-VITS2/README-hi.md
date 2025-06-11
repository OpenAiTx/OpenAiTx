<div align="center">

<img alt="LOGO" src="https://raw.githubusercontent.com/fishaudio/Bert-VITS2/master/avatars.githubusercontent.com/u/122017386" width="256" height="256" />

# Bert-VITS2

मल्टीलिंगुअल बर्ट के साथ VITS2 बैकबोन

त्वरित मार्गदर्शिका के लिए, कृपया `webui_preprocess.py` देखें।

简易教程请参见 `webui_preprocess.py`।

## 【परियोजना परिचय】
# FishAudio के तहत नया स्व-प्रगामी TTS [Fish-Speech](https://github.com/fishaudio/fish-speech) अब उपलब्ध है, इसका प्रदर्शन वर्तमान में ओपन सोर्स SOTA स्तर का है, और यह लगातार मेंटेन हो रहा है। इस परियोजना को BV2/GSV के विकल्प के रूप में उपयोग करने की सिफारिश की जाती है। यह परियोजना अल्पकालिक में मेंटेन नहीं की जाएगी।
## डेमो वीडियो: https://www.bilibili.com/video/BV18E421371Q
## टेक स्लाइड्स वीडियो: https://www.bilibili.com/video/BV1zJ4m1K7cj
## कृपया ध्यान दें, इस परियोजना का मुख्य विचार [anyvoiceai/MassTTS](https://github.com/anyvoiceai/MassTTS) से आया है, जो एक बहुत अच्छा TTS प्रोजेक्ट है।
## MassTTS का डेमो है [ai版峰哥锐评峰哥本人,并找回了在金三角失落的腰子](https://www.bilibili.com/video/BV1w24y1c7z9)

[//]: # (## 本项目与[PlayVoice/vits_chinese]&#40;https://github.com/PlayVoice/vits_chinese&#41; 没有任何关系)

[//]: # ()
[//]: # (本仓库来源于之前朋友分享了ai峰哥的视频，本人被其中的效果惊艳，在自己尝试MassTTS以后发现fs在音质方面与vits有一定差距，并且training的pipeline比vits更复杂，因此按照其思路将bert)

## अनुभवी यात्री/उद्यमी/कैप्टन/डॉक्टर/सेन्सेई/शिकारकर्ता/म्याऊ म्याऊ रू/V कोड को देखकर स्वयं प्रशिक्षण करने का अध्ययन करना चाहिए।

### इस परियोजना का उपयोग किसी भी प्रकार से "中华人民共和国宪法", "中华人民共和国刑法", "中华人民共和国治安管理处罚法" और "中华人民共和国民法典" के विरुद्ध करने के लिए सख्त मना है।
### किसी भी राजनीतिक उद्देश्य के लिए उपयोग सख्त मना है।
#### वीडियो: https://www.bilibili.com/video/BV1hp4y1K78E
#### डेमो: https://www.bilibili.com/video/BV1TF411k78w
## संदर्भ
+ [anyvoiceai/MassTTS](https://github.com/anyvoiceai/MassTTS)
+ [jaywalnut310/vits](https://github.com/jaywalnut310/vits)
+ [p0p4k/vits2_pytorch](https://github.com/p0p4k/vits2_pytorch)
+ [svc-develop-team/so-vits-svc](https://github.com/svc-develop-team/so-vits-svc)
+ [PaddlePaddle/PaddleSpeech](https://github.com/PaddlePaddle/PaddleSpeech)
+ [emotional-vits](https://github.com/innnky/emotional-vits)
+ [fish-speech](https://github.com/fishaudio/fish-speech)
+ [Bert-VITS2-UI](https://github.com/jiangyuxiaoxiao/Bert-VITS2-UI)
## सभी योगदानकर्ताओं के प्रयासों के लिए धन्यवाद
<a href="https://github.com/fishaudio/Bert-VITS2/graphs/contributors" target="_blank">
  <img src="https://contrib.rocks/image?repo=fishaudio/Bert-VITS2"/>
</a>

[//]: # (# 本项目所有代码引用均已写明，bert部分代码思路来源于[AI峰哥]&#40;https://www.bilibili.com/video/BV1w24y1c7z9&#41;，与[vits_chinese]&#40;https://github.com/PlayVoice/vits_chinese&#41;无任何关系。欢迎各位查阅代码。同时，我们也对该开发者的[碰瓷，乃至开盒开发者的行为]&#40;https://www.bilibili.com/read/cv27101514/&#41;表示强烈谴责。)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---