<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS 2025-Main Conference-blue.svg" alt="NeurIPS 2025"/>
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

<p align="center">
  यदि आपको यह प्रोजेक्ट उपयोगी लगे,<br>
  GitHub पर एक स्टार ⭐ देना अत्यंत सराहनीय होगा!
</p>

---

**ThinkSound** एक एकीकृत Any2Audio जनरेशन फ्रेमवर्क है, जिसमें Chain-of-Thought (CoT) रीजनिंग द्वारा फ्लो मैचिंग का मार्गदर्शन किया जाता है।

मल्टीमॉडल ऑडियो जेनरेशन और एडिटिंग के लिए PyTorch इम्प्लीमेंटेशन: वीडियो, टेक्स्ट और ऑडियो से ऑडियो जनरेट या एडिट करें, मल्टीमॉडल लार्ज लैंग्वेज मॉडल्स (MLLMs) की स्टेप-बाय-स्टेप रीजनिंग द्वारा संचालित।

![टीज़र](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 समाचार
- **2025.09.19** &nbsp; 🎉 ThinkSound को **NeurIPS 2025 मुख्य सम्मेलन** में स्वीकृति मिली है!
- **2025.09.01** &nbsp; 🔥 हमारा AudioCoT डेटासेट अब ओपन-सोर्स है और [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT) पर उपलब्ध है!
- **2025.07.17** &nbsp; 🧠 फाइनट्यूनिंग सक्षम: ट्रेनिंग और फाइनट्यूनिंग कोड अब सार्वजनिक रूप से उपलब्ध है, स्पष्ट निर्देशों के साथ जिससे आप अपने डेटा के साथ ThinkSound को कस्टमाइज़ और एक्सटेंड कर सकते हैं।
- **2025.07.15** &nbsp; 📦 आसान इंस्टॉलेशन और उपयोगिता: PyPI पर डिपेंडेंसीज़ क्रॉस-प्लेटफॉर्म सेटअप के लिए; Windows `.bat` स्क्रिप्ट्स वातावरण निर्माण और स्क्रिप्ट रनिंग को ऑटोमेट करती हैं।
- **2025.07.08** &nbsp;  🔧 प्रमुख अपडेट: मॉडल को हल्का और मेमोरी व GPU उपयोग को ऑप्टिमाइज़ किया गया, अब बड़े पैमाने पर हाई-थ्रूपुट ऑडियो जेनरेशन को सपोर्ट करता है!
- **2025.07.01** &nbsp; 🔥ऑनलाइन डेमो [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) और [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) पर इंटरएक्टिव अनुभव के लिए उपलब्ध!
- **2025.07.01** &nbsp; 🔥इन्फेरेंस स्क्रिप्ट्स और वेब इंटरफेस जारी किए गए;
- **2025.06** &nbsp; 🔥[ThinkSound पेपर](https://arxiv.org/pdf/2506.21448) arXiv पर जारी!
- **2025.06** &nbsp; 🔥[ऑनलाइन डेमो](http://thinksound-project.github.io/) लाइव है - अभी आज़माएँ!

---


## 🚀 विशेषताएँ

- **Any2Audio**: किसी भी मोडालिटी से ऑडियो जनरेट करें — वीडियो, टेक्स्ट, ऑडियो या उनके संयोजन।
- **वीडियो-टू-ऑडियो SOTA**: कई V2A बेंचमार्क्स पर सर्वश्रेष्ठ परिणाम प्राप्त करता है।
- **CoT-चालित रीजनिंग**: MLLMs के माध्यम से कंपोजिशनल और नियंत्रित ऑडियो जनरेशन के लिए चेन-ऑफ-थॉट रीजनिंग।
- **इंटरएक्टिव ऑब्जेक्ट-सेंट्रिक एडिटिंग**: विजुअल ऑब्जेक्ट्स पर क्लिक या टेक्स्ट निर्देशों का उपयोग करके विशिष्ट साउंड इवेंट्स को सुधारें या एडिट करें।
- **एकीकृत फ्रेमवर्क**: एक फाउंडेशन मॉडल जेनरेशन, एडिटिंग और इंटरएक्टिव वर्कफ्लो को सपोर्ट करता है।

---

## ✨ विधि अवलोकन

ThinkSound ऑडियो जेनरेशन और एडिटिंग को तीन इंटरएक्टिव चरणों में विभाजित करता है, जो सभी MLLM-आधारित चेन-ऑफ-थॉट (CoT) रीजनिंग द्वारा निर्देशित हैं:

1. **फोली जेनरेशन:** वीडियो से मूल, सैमान्य और समयानुकूल साउंडस्केप्स जनरेट करें।
2. **ऑब्जेक्ट-सेंट्रिक परिष्करण:** वीडियो में क्लिक या चयनित क्षेत्रों के माध्यम से यूजर द्वारा निर्दिष्ट ऑब्जेक्ट्स के लिए साउंड्स को सुधारें या जोड़ें।
3. **लक्षित ऑडियो संपादन:** उच्च-स्तरीय प्राकृतिक भाषा निर्देशों का उपयोग करके जनरेटेड ऑडियो को संपादित करें।

![ThinkSound अवलोकन](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- एक बड़े पैमाने का CoT-एनोटेटेड डेटासेट (**AudioCoT**) का उपयोग दोनों रीजनिंग मॉड्यूल और एकीकृत ऑडियो फाउंडेशन मॉडल को प्रशिक्षित करने के लिए किया जाता है।
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ त्वरित प्रारंभ

**पर्यावरण तैयारी:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **Windows टिप:**  
> Windows उपयोगकर्ता केवल `setup_windows.bat` चला सकते हैं (या उस पर डबल-क्लिक कर सकते हैं) जिससे कोंडा वातावरण अपने आप बन जाएगा, सभी आवश्यकताएँ (FFmpeg सहित) स्थापित हो जाएंगी, और प्रीट्रेंड मॉडल डाउनलोड हो जाएगा — कोई मैन्युअल सेटअप आवश्यक नहीं है।  
> स्क्रिप्ट चलाने से पहले सुनिश्चित करें कि आपके सिस्टम PATH में `conda` और `git` इंस्टॉल और उपलब्ध हैं।


### ▶️ डेमो चलाएँ

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

इसके बजाय आप प्रदान की गई `.bat` स्क्रिप्ट का उपयोग कर सकते हैं:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**नोट:**

* `<path-to-your-demo-video>`: एकल वीडियो का पथ
* `[use-half]` (वैकल्पिक): अंतिम में use-half जोड़ें ताकि हाफ प्रिसीजन फीचर एक्सट्रैक्शन सक्षम हो सके।

---

### 📦 बैच इनफेरेंस

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **विंडोज़**

समान `.bat` स्क्रिप्ट का उपयोग करें:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**नोट:**

* `<video_path>`: उस मूल निर्देशिका का पथ जिसमें सभी .mp4 वीडियो प्रोसेसिंग के लिए रखे गए हैं (सभी वीडियो की अवधि समान होनी चाहिए)।
* `<csv_path>`: प्रत्येक वीडियो के लिए टेक्स्ट प्रॉम्प्ट्स वाली एक CSV फ़ाइल (फॉर्मेट के लिए `demo_test.csv` देखें)।
* `<save_path>` (वैकल्पिक): जनरेटेड ऑडियो को कहाँ सेव करना है। डिफ़ॉल्ट है `results/features`।
* `[use-half]` (वैकल्पिक): हाफ प्रिसीजन फ़ीचर एक्सट्रैक्शन को सक्षम करने के लिए अंत में use-half जोड़ें।

---


### वेब इंटरफेस उपयोग

इंटरएक्टिव अनुभव के लिए, Gradio वेब इंटरफेस लॉन्च करें:


```bash
python app.py
```


## 🏋️ मॉडल को प्रशिक्षित करें

देखें [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 TODO और भविष्य की योजनाएँ
* - [ ] एक अधिक शक्तिशाली फाउंडेशन मॉडल जारी करें जो कई क्षेत्रों को कवर करे ताकि अधिक आकर्षक और इमर्सिव फोली निर्माण प्रदान किया जा सके
* - [ ] अतिरिक्त मोडालिटी और डाउनस्ट्रीम कार्यों के लिए समर्थन जोड़ें
* - [ ] विभिन्न स्तरों पर मॉडल जारी करें
* - [x] AudioCoT डेटासेट और स्वचालित पाइपलाइन को ओपन-सोर्स करें
* - [x] ThinkSound मॉडल के लिए प्रशिक्षण स्क्रिप्ट जारी करें
* - [x] शुरुआती के लिए Windows क्विक-स्टार्ट README जारी करें
---


## 📄 लाइसेंस

यह परियोजना Apache 2.0 लाइसेंस के तहत जारी की गई है।

> **नोट:**
> कोड, मॉडल, और डेटासेट **केवल शोध और शैक्षिक उद्देश्यों के लिए हैं**।
> **व्यावसायिक उपयोग की अनुमति नहीं है।**
> व्यावसायिक लाइसेंसिंग के लिए, कृपया लेखकों से संपर्क करें।

**📦 तृतीय-पक्ष घटक**

* **Stable Audio Open VAE** (Stability AI द्वारा):
  यह रिपॉजिटरी [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) से फाइन-ट्यून किया गया VAE शामिल करती है, जो [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) के अंतर्गत लाइसेंस प्राप्त है।
  **व्यावसायिक उपयोग और पुनर्वितरण के लिए Stability AI से पूर्व अनुमति आवश्यक है।**

* 📘 **अन्य सभी कोड और मॉडल** Apache License 2.0 के तहत जारी किए गए हैं।

---

## आभार

बहुत धन्यवाद:

* **stable-audio-tools** (Stability AI द्वारा):
ऑडियो जनरेशन के लिए आसान फ्रेमवर्क प्रदान करने के लिए, साथ ही VAE मॉड्यूल और वज़न के लिए।
* **MMAudio**:
  ऑडियो डोमेन में MM-DiT बैकबोन के कार्यान्वयन के लिए।

---

## 📖 उद्धरण

यदि आपको ThinkSound अपने शोध या कार्य में उपयोगी लगे, तो कृपया हमारे पेपर का उल्लेख करें:

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

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-04

---