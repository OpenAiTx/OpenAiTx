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
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
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
  यदि आपको यह परियोजना उपयोगी लगे,<br>
  GitHub पर एक स्टार ⭐ बहुत सराहनीय होगा!
</p>

---

## रिपॉजिटरी संरचना
यह **ThinkSound** GitHub रिपॉज़िटरी दो संबंधित प्रोजेक्ट्स को अलग-अलग ब्रांच पर होस्ट करती है:

| ब्रांच | प्रोजेक्ट | डोक्युमेंटेशन |
|--------|----------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — एकीकृत Any2Audio जेनरेशन CoT-गाइडेड फ्लो मैचिंग के साथ | यह फाइल: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — फॉलो-अप कार्य (ICLR 2026) वीडियो-टू-ऑडियो के लिए मल्टी-डायमेंशनल CoT-RL के साथ | **`README.md`** [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) ब्रांच पर |

**ThinkSound** के लिए ब्रांच **`master`** (यह README) का उपयोग करें। **PrismAudio** के लिए **`prismaudio`** ब्रांच देखें और वहाँ का **`README.md`** फॉलो करें।

---

**ThinkSound** एक एकीकृत Any2Audio जेनरेशन फ्रेमवर्क है जिसमें फ्लो मैचिंग Chain-of-Thought (CoT) रीजनिंग द्वारा गाइडेड है।

मल्टीमोडल ऑडियो जेनरेशन और एडिटिंग के लिए PyTorch इम्प्लीमेंटेशन: वीडियो, टेक्स्ट और ऑडियो से ऑडियो जेनरेट या एडिट करें, पावर्ड बाय स्टेप-बाय-स्टेप रीजनिंग मल्टीमोडल लार्ज लैंग्वेज मॉडल्स (MLLMs) से।

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 समाचार
- **2026.03.24** &nbsp; 🔥 **PrismAudio** इसी रिपॉज़िटरी में ब्रांच [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) पर रिलीज़ — सेटअप और मॉडल्स के लिए वहाँ का **`README.md`** देखें।
- **2026.01.26** &nbsp; 🎉 PrismAudio स्वीकार हुआ **ICLR 2026 मुख्य सम्मेलन** में (कोड/डॉक्स `prismaudio` पर)।
- **2025.11.25** &nbsp; 🔥 [ऑनलाइन PrismAudio डेमो](http://prismaudio-project.github.io/) लाइव है।
- **2025.11.25** &nbsp; 🔥 [PrismAudio पेपर](https://arxiv.org/pdf/2511.18833) arXiv पर — वीडियो-टू-ऑडियो के लिए मल्टी-डायमेंशनल CoT-RL।
- **2025.09.19** &nbsp; 🎉 **ThinkSound** स्वीकार हुआ **NeurIPS 2025 मुख्य सम्मेलन** में!
- **2025.09.01** &nbsp; हमारा AudioCoT डेटासेट अब ओपन-सोर्स्ड है और [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT) पर उपलब्ध है!
- **2025.07.17** &nbsp; 🧠 फाइनट्यूनिंग सक्षम: ट्रेनिंग और फाइनट्यूनिंग कोड अब सार्वजनिक है, स्पष्ट निर्देशों के साथ जिससे आप ThinkSound को अपने डेटा के साथ कस्टमाइज़ और एक्सटेंड कर सकते हैं।
- **2025.07.15** &nbsp; 📦 इंस्टॉलेशन और उपयोगिता में सुधार: PyPI पर निर्भरताएँ आसान क्रॉस-प्लेटफॉर्म सेटअप के लिए; Windows `.bat` स्क्रिप्ट्स पर्यावरण निर्माण और स्क्रिप्ट रनिंग को स्वचालित करती हैं।
- **2025.07.08** &nbsp;  🔧 प्रमुख अपडेट: मॉडल हल्का किया गया और मेमोरी व GPU उपयोग को ऑप्टिमाइज़ किया गया, अब बड़े स्तर पर उच्च-थ्रूपुट ऑडियो जेनरेशन को सपोर्ट करता है!
- **2025.07.01** &nbsp; [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) और [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) पर ऑनलाइन डेमो इंटरैक्टिव अनुभव के लिए!
- **2025.07.01** &nbsp; इन्फेरेंस स्क्रिप्ट्स और वेब इंटरफ़ेस रिलीज़ किए गए; 
- **2025.06** &nbsp; [ThinkSound पेपर](https://arxiv.org/pdf/2506.21448) arXiv पर जारी!
- **2025.06** &nbsp; [ऑनलाइन डेमो](http://thinksound-project.github.io/) लाइव है - अभी आज़माएँ!

---


<div align="center">

### फॉलो-अप: PrismAudio (यही रिपॉ, `prismaudio` ब्रांच)

**PrismAudio** ThinkSound (ICLR 2026) का उत्तराधिकारी है, जिसे एक नए नाम के तहत विकसित किया गया है लेकिन इस रिपॉजिटरी में ब्रांच **`prismaudio`** पर रखा गया है। इंस्टॉलेशन, चेकपॉइंट्स और संदर्भ के लिए **[`README.md` on that branch](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)** देखें।

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) या GitHub पर ब्रांच खोलें।

</div>

---


## 🚀 विशेषताएँ

- **Any2Audio**: किसी भी मोडालिटी से ऑडियो जेनरेट करें — वीडियो, टेक्स्ट, ऑडियो, या इनका संयोजन।
- **Video-to-Audio SOTA**: कई V2A बेंचमार्क्स पर स्टेट-ऑफ-द-आर्ट परिणाम प्राप्त करता है।
- **CoT-Driven Reasoning**: MLLMs के माध्यम से कंपोजिशनल और नियंत्रित ऑडियो जेनरेशन के लिए चेन-ऑफ-थॉट रीजनिंग।
- **इंटरैक्टिव ऑब्जेक्ट-सेंट्रिक एडिटिंग**: दृश्य ऑब्जेक्ट्स पर क्लिक करके या टेक्स्ट निर्देशों के माध्यम से विशिष्ट साउंड इवेंट्स को सुधारें या संपादित करें।
- **यूनिफाइड फ्रेमवर्क**: एक फाउंडेशन मॉडल जेनरेशन, एडिटिंग और इंटरैक्टिव वर्कफ़्लो को सपोर्ट करता है।

---

## ✨ विधि का अवलोकन

ThinkSound ऑडियो जेनरेशन और एडिटिंग को तीन इंटरैक्टिव चरणों में विभाजित करता है, जो सभी MLLM-आधारित चेन-ऑफ-थॉट (CoT) रीजनिंग द्वारा निर्देशित हैं:

1. **फोली जेनरेशन:** वीडियो से आधारभूत, अर्थपूर्ण और समय से संरेखित साउंडस्केप्स उत्पन्न करें।
2. **ऑब्जेक्ट-सेंट्रिक रिफाइनमेंट:** यूजर द्वारा चुने गए ऑब्जेक्ट्स के लिए वीडियो में क्लिक या क्षेत्र द्वारा ध्वनि को परिष्कृत या जोड़ें।
3. **लक्षित ऑडियो एडिटिंग:** उच्च-स्तरीय प्राकृतिक भाषा निर्देशों का उपयोग करके उत्पन्न ऑडियो को संशोधित करें।

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- एक बड़े पैमाने पर CoT-एनोटेटेड डेटासेट (**AudioCoT**) का उपयोग रीजनिंग मॉड्यूल और एकीकृत ऑडियो फाउंडेशन मॉडल दोनों को प्रशिक्षित करने के लिए किया जाता है।
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ त्वरित प्रारंभ

**पर्यावरण तैयारी:**

```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
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

[`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md) देखें

---

## 📄 लाइसेंस

यह परियोजना Apache 2.0 लाइसेंस के अंतर्गत जारी की गई है।

> **नोट:**
> कोड, मॉडल, और डेटासेट केवल **शोध और शैक्षिक उद्देश्यों के लिए** हैं।
> **व्यावसायिक उपयोग की अनुमति नहीं है।**
> व्यावसायिक लाइसेंसिंग के लिए, कृपया लेखकों से संपर्क करें।

**📦 तृतीय-पक्ष घटक**

* **Stable Audio Open VAE** (Stability AI द्वारा):
  यह रिपोजिटरी [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) से फाइन-ट्यून किया गया VAE शामिल करती है, जो [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) के अंतर्गत लाइसेंस प्राप्त है।
  **व्यावसायिक उपयोग और पुनर्वितरण के लिए Stability AI से पूर्व अनुमति आवश्यक है।**

* 📘 **अन्य सभी कोड और मॉडल** Apache License 2.0 के अंतर्गत जारी किए गए हैं।

---

## आभार

इनका विशेष धन्यवाद:

* **stable-audio-tools** (Stability AI द्वारा):
  ऑडियो जेनरेशन के लिए आसान फ्रेमवर्क, साथ ही VAE मॉड्यूल और वज़न उपलब्ध कराने के लिए।
* **MMAudio**:
  ऑडियो डोमेन में MM-DiT बैकबोन के कार्यान्वयन के लिए।

---





## 📖 उद्धरण

यदि आप अपने शोध या कार्य में हमारे प्रोजेक्ट को उपयोगी पाते हैं, तो कृपया हमारे पेपर का उल्लेख करें:

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
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---