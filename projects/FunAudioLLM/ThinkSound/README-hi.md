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
  तो GitHub पर एक स्टार ⭐ बहुत सराहनीय होगा!
</p>

---

**ThinkSound** एक एकीकृत Any2Audio निर्माण फ्रेमवर्क है, जिसमें Chain-of-Thought (CoT) रीजनिंग द्वारा फ्लो मैचिंग गाइड की जाती है।

मल्टीमॉडल ऑडियो जेनरेशन और संपादन के लिए PyTorch इम्प्लीमेंटेशन: वीडियो, टेक्स्ट, और ऑडियो से ऑडियो जेनरेट या एडिट करें, जो मल्टीमॉडल लार्ज लैंग्वेज मॉडल्स (MLLMs) की स्टेप-बाय-स्टेप रीजनिंग द्वारा संचालित है।

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 समाचार
- **2025.07.17** &nbsp; 🧠 फाइनट्यूनिंग सक्षम: प्रशिक्षण और फाइनट्यूनिंग कोड अब सार्वजनिक रूप से उपलब्ध है, स्पष्ट उपयोग निर्देशों के साथ जिससे आप अपने डेटा के साथ ThinkSound को कस्टमाइज़ और विस्तारित कर सकते हैं।
- **2025.07.15** &nbsp; 📦 आसान इंस्टॉलेशन और उपयोगिता: आसान क्रॉस-प्लेटफॉर्म सेटअप के लिए PyPI पर डिपेंडेंसीज़; विंडोज़ `.bat` स्क्रिप्ट्स से वातावरण बनाना और स्क्रिप्ट चलाना स्वचालित।
- **2025.07.08** &nbsp;  🔧 बड़ा अपडेट: मॉडल हल्का और मेमोरी व GPU उपयोग के लिए अनुकूलित, अब बड़े पैमाने पर उच्च-थ्रूपुट ऑडियो जेनरेशन को सपोर्ट करता है!
- **2025.07.01** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) और [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) पर ऑनलाइन डेमो, इंटरएक्टिव अनुभव के लिए!
- **2025.07.01** &nbsp; 🔥इन्फरेंस स्क्रिप्ट्स और वेब इंटरफेस जारी किया गया; 
- **2025.06** &nbsp; 🔥[ThinkSound पेपर](https://arxiv.org/pdf/2506.21448) arXiv पर जारी!
- **2025.06** &nbsp; 🔥[ऑनलाइन डेमो](http://thinksound-project.github.io/) लाइव है - अभी आज़माएँ!

---


## 🚀 विशेषताएँ

- **Any2Audio**: किसी भी मोडालिटी से ऑडियो जेनरेट करें — वीडियो, टेक्स्ट, ऑडियो, या इनका संयोजन।
- **वीडियो-से-ऑडियो SOTA**: कई V2A बेंचमार्क्स पर अत्याधुनिक परिणाम प्राप्त करता है।
- **CoT-चालित रीजनिंग**: MLLMs के माध्यम से कम्पोजिशनल और नियंत्रित ऑडियो निर्माण के लिए Chain-of-Thought रीजनिंग।
- **इंटरएक्टिव ऑब्जेक्ट-सेंट्रिक एडिटिंग**: विज़ुअल ऑब्जेक्ट्स पर क्लिक करके या टेक्स्ट इंस्ट्रक्शन के माध्यम से विशिष्ट ध्वनि घटनाओं को परिष्कृत या संपादित करें।
- **एकीकृत फ्रेमवर्क**: एक फाउंडेशन मॉडल जेनरेशन, एडिटिंग और इंटरएक्टिव वर्कफ़्लो को सपोर्ट करता है।

---

## ✨ विधि अवलोकन

ThinkSound ऑडियो निर्माण और संपादन को तीन इंटरएक्टिव चरणों में विभाजित करता है, जो सभी MLLM-आधारित Chain-of-Thought (CoT) रीजनिंग द्वारा गाइडेड हैं:

1. **फोली जेनरेशन:** वीडियो से अर्थपूर्ण और समयानुकूल फाउंडेशनल साउंडस्केप्स जेनरेट करें।
2. **ऑब्जेक्ट-सेंट्रिक परिष्करण:** वीडियो में क्लिक या क्षेत्र के माध्यम से यूज़र-स्पेसिफाइड ऑब्जेक्ट्स के लिए ध्वनियाँ परिष्कृत या जोड़ें।
3. **लक्षित ऑडियो संपादन:** उच्च-स्तरीय प्राकृतिक भाषा निर्देशों का उपयोग कर उत्पन्न ऑडियो को संशोधित करें।

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- एक बड़े पैमाने की CoT-एनोटेटेड डेटासेट (**AudioCoT**) का उपयोग रीजनिंग मॉड्यूल और एकीकृत ऑडियो फाउंडेशन मॉडल दोनों के प्रशिक्षण के लिए किया जाता है।
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ त्वरित शुरुआत

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

## 📝 कार्यसूची और भविष्य की योजनाएँ
* - [ ] ऑडियोकोट डेटासेट और स्वचालित पाइपलाइन को ओपन-सोर्स करना (अपेक्षित: 07/23/2025 से पहले)
* - [ ] एक अधिक शक्तिशाली फाउंडेशन मॉडल जारी करना, जो कई डोमेन को कवर करे और अधिक आकर्षक तथा इमर्सिव फोली निर्माण प्रदान करे (अपेक्षित: अगस्त 2025 के अंत तक)
* - [ ] अतिरिक्त मोडलिटी और डाउनस्ट्रीम कार्यों के लिए समर्थन जोड़ना (अपेक्षित: जुलाई 2025 के अंत से पहले)
* - [ ] विभिन्न स्तरों पर मॉडल जारी करना (अपेक्षित: जुलाई 2025 के अंत से पहले)
* - [x] ThinkSound मॉडलों के लिए प्रशिक्षण स्क्रिप्ट जारी करना
* - [x] शुरुआती के अनुकूल विंडोज़ क्विक-स्टार्ट README
---


## 📄 लाइसेंस

यह परियोजना Apache 2.0 लाइसेंस के तहत जारी की गई है।

> **नोट:**
> कोड, मॉडल और डेटासेट **केवल शोध और शैक्षिक उद्देश्यों के लिए** हैं।
> **व्यावसायिक उपयोग की अनुमति नहीं है।**
> व्यावसायिक लाइसेंसिंग के लिए कृपया लेखकों से संपर्क करें।

**📦 तृतीय-पक्ष घटक**

* **स्टेबल ऑडियो ओपन VAE** (Stability AI द्वारा):
  यह रिपॉजिटरी [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) से फाइन-ट्यून किया गया VAE शामिल करती है, जो [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) के तहत लाइसेंस प्राप्त है।
  **व्यावसायिक उपयोग और पुनर्वितरण के लिए Stability AI से पूर्व अनुमति आवश्यक है।**

* 📘 **अन्य सभी कोड और मॉडल** Apache License 2.0 के तहत जारी किए गए हैं।

---

## आभार

बहुत धन्यवाद:

* **stable-audio-tools** (Stability AI द्वारा):
ऑडियो जेनरेशन के लिए एक प्रयोग करने में आसान फ्रेमवर्क, साथ ही VAE मॉड्यूल और वेट्स प्रदान करने के लिए।
* **MMAudio**:
  ऑडियो डोमेन में MM-DiT बैकबोन के कार्यान्वयन के लिए।

---

## 📖 उद्धरण

यदि आपको ThinkSound अपने शोध या कार्य में उपयोगी लगे, तो कृपया हमारे पेपर को उद्धृत करें:



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

✨ यदि आपके पास कोई प्रश्न या सुझाव है तो [issue खोलें](https://github.com/liuhuadai/ThinkSound/issues) या हमें ईमेल ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) के माध्यम से संपर्क करें!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---