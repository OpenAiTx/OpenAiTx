# 🎶 ThinkSound

<p align="center">
  यदि आपको यह प्रोजेक्ट उपयोगी लगे, तो GitHub पर एक स्टार ⭐ देकर हमें प्रोत्साहित करें!
</p>

<p align="center">
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

---

**ThinkSound** एक एकीकृत Any2Audio जेनरेशन फ्रेमवर्क है, जिसमें Chain-of-Thought (CoT) रीजनिंग द्वारा फ्लो मैचिंग का मार्गदर्शन किया जाता है।

मल्टीमॉडल ऑडियो जेनरेशन और एडिटिंग के लिए PyTorch इम्प्लीमेंटेशन: वीडियो, टेक्स्ट और ऑडियो से ऑडियो जेनरेट या एडिट करें, मल्टीमॉडल लार्ज लैंग्वेज मॉडल्स (MLLMs) की स्टेप-बाय-स्टेप रीजनिंग द्वारा संचालित।

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 समाचार
- **2025.07** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) और [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) पर ऑनलाइन डेमो के साथ इंटरैक्टिव अनुभव उपलब्ध!
- **2025.07** &nbsp; 🔥इन्फरेंस स्क्रिप्ट्स और वेब इंटरफेस जारी;
- **2025.06** &nbsp; 🔥[ThinkSound पेपर](https://arxiv.org/pdf/2506.21448) arXiv पर जारी किया गया!
- **2025.06** &nbsp; 🔥[ऑनलाइन डेमो](http://thinksound-project.github.io/) लाइव है - अभी आज़माएँ!

---

## 🚀 विशेषताएँ

- **Any2Audio**: किसी भी मोडेलिटी — वीडियो, टेक्स्ट, ऑडियो या इनके संयोजन — से ऑडियो जेनरेट करें।
- **वीडियो-टू-ऑडियो SOTA**: कई V2A बेंचमार्क्स पर स्टेट-ऑफ-द-आर्ट परिणाम प्राप्त करता है।
- **CoT-चालित रीजनिंग**: MLLMs के माध्यम से संरचनात्मक और नियंत्रित ऑडियो जेनरेशन के लिए Chain-of-Thought रीजनिंग।
- **इंटरएक्टिव ऑब्जेक्ट-सेंट्रिक एडिटिंग**: विज़ुअल ऑब्जेक्ट्स पर क्लिक करके या टेक्स्ट इंस्ट्रक्शंस का उपयोग करके विशिष्ट साउंड इवेंट्स को सुधारें या एडिट करें।
- **एकीकृत फ्रेमवर्क**: एक फाउंडेशन मॉडल जनरेशन, एडिटिंग और इंटरएक्टिव वर्कफ़्लो को सपोर्ट करता है।

---

## ✨ मेथड ओवरव्यू

ThinkSound ऑडियो जेनरेशन और एडिटिंग को तीन इंटरएक्टिव चरणों में विभाजित करता है, जो सभी MLLM-आधारित Chain-of-Thought (CoT) रीजनिंग द्वारा निर्देशित हैं:

1. **फोली जेनरेशन:** वीडियो से अर्थपूर्ण और टाइमिंग के अनुसार संरेखित बेसिक साउंडस्केप्स जेनरेट करें।
2. **ऑब्जेक्ट-सेंट्रिक रिफाइनमेंट:** वीडियो में क्लिक या क्षेत्र के माध्यम से उपयोगकर्ता द्वारा निर्दिष्ट ऑब्जेक्ट्स के लिए साउंड को सुधारें या जोड़ें।
3. **लक्षित ऑडियो संपादन:** उच्च-स्तरीय प्राकृतिक भाषा निर्देशों का उपयोग करके जेनरेटेड ऑडियो को संशोधित करें।

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- एक बड़े पैमाने पर CoT-अनोटेटेड डेटासेट (**AudioCoT**) का उपयोग रीजनिंग मॉड्यूल और एकीकृत ऑडियो फाउंडेशन मॉडल दोनों को प्रशिक्षित करने के लिए किया जाता है।
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ त्वरित शुरुआत

**पर्यावरण की तैयारी:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# प्री-ट्रेंड वेट्स डाउनलोड करें https://huggingface.co/liuhuadai/ThinkSound को डायरेक्टरी ckpts/ में रखें
# मॉडल वेट्स https://www.modelscope.cn/models/iic/ThinkSound से भी डाउनलोड किए जा सकते हैं
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**इसे एक्सीक्यूटेबल बनाएं**
```bash
chmod +x scripts/demo.sh
```

**स्क्रिप्ट चलाएँ**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### वेब इंटरफेस का उपयोग

इंटरैक्टिव अनुभव के लिए, Gradio वेब इंटरफेस लॉन्च करें:

```bash
python app.py
```

---
## 📝 TODO

- ☐ ThinkSound मॉडल्स के लिए प्रशिक्षण स्क्रिप्ट जारी करें
- ☐ AudioCoT डेटासेट और स्वचालित पाइपलाइन ओपन-सोर्स करें
- ☐ विस्तृत प्रलेखन और API संदर्भ प्रदान करें
- ☐ अतिरिक्त मोडैलिटी और डाउनस्ट्रीम टास्क के लिए समर्थन जोड़ें

---

## 📄 लाइसेंस

यह प्रोजेक्ट [Apache 2.0 License](LICENSE) के तहत जारी किया गया है।

> **नोट:**  
> कोड, मॉडल और डेटासेट **केवल अनुसंधान और शैक्षिक प्रयोजनों के लिए** हैं।  
> **व्यावसायिक उपयोग की अनुमति नहीं है।**
>
> व्यावसायिक लाइसेंसिंग के लिए, कृपया लेखकों से संपर्क करें।

---

## 📖 संदर्भ

यदि आपको ThinkSound अपने अनुसंधान या कार्य में उपयोगी लगे, तो कृपया हमारे पेपर का हवाला दें:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
```

---

## 📬 संपर्क करें

✨ यदि आपके पास कोई प्रश्न या सुझाव हैं, तो [issue खोलें](https://github.com/liuhuadai/ThinkSound/issues) या हमें ईमेल ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) के माध्यम से संपर्क करें!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---