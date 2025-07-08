<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

यह रिपॉजिटरी SynLogic के लिए कोड और डेटा प्रदान करती है, जो एक व्यापक लॉजिकल रीजनिंग डेटा सिंथेसिस फ्रेमवर्क है, जो बड़े स्तर पर विविध, सत्यापन योग्य रीजनिंग डेटा उत्पन्न करता है। हमारा कार्य लार्ज लैंग्वेज मॉडल्स (LLMs) में सामान्य रीजनिंग क्षमताओं के विकास के लिए उच्च-गुणवत्ता वाले लॉजिकल रीजनिंग प्रशिक्षण डेटा की महत्वपूर्ण कमी को संबोधित करता है।

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## समाचार
- **[2025/07/07]** :fire: हमने SynLogic डेटा का उपयोग करके Verl फ्रेमवर्क के साथ RL प्रशिक्षण करने के लिए मार्गदर्शन प्रदान किया है। विवरण के लिए देखें [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md)। 

- **[2025/06/03]** :fire: Hugging Face पर प्रशिक्षित मॉडल जारी किए गए:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: हम पेपर "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond" के संसाधनों को जारी करते हुए उत्साहित हैं।

## 📋 अवलोकन

**SynLogic** एक डेटा सिंथेसिस फ्रेमवर्क और व्यापक डेटासेट है जो:
- 📊 **35 विविध लॉजिकल रीजनिंग टास्क्स को कवर करता है** जैसे कि Sudoku, Game of 24, Cipher, Arrow Maze, और बहुत कुछ
- 🎯 **नियंत्रित कठिनाई सिंथेसिस को सक्षम बनाता है** प्रत्येक टास्क के लिए समायोज्य पैरामीटर के साथ
- ✅ **सत्यापन योग्य रिवॉर्ड्स प्रदान करता है** RL प्रशिक्षण के लिए रूल-बेस्ड वेरिफिकेशन के माध्यम से
- 🚀 **ओपन-सोर्स डेटासेट्स के बीच SOTA प्रदर्शन प्राप्त करता है**, DeepSeek-R1-Distill-Qwen-32B को BBEH पर 6 अंक से पीछे छोड़ता है

### मुख्य विशेषताएँ
- **स्केलेबल डेटा जेनरेशन**: नियंत्रित कठिनाई स्तरों के साथ असीमित सिंथेसिस
- **व्यापक टास्क कवरेज**: 35 अलग-अलग लॉजिकल रीजनिंग टास्क्स अपने स्वयं के जनरेटर और वेरिफायर के साथ
- **RL-तैयार**: सभी उदाहरण सरल नियमों द्वारा सत्यापित किए जा सकते हैं, जिससे वे रिइन्फोर्समेंट लर्निंग के लिए आदर्श बनते हैं
- **क्रॉस-डोमेन ट्रांसफर**: गणितीय और कोडिंग डोमेन में मजबूत सामान्यीकरण

## 🚀 शीघ्र प्रारंभ

### इंस्टॉलेशन
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### सैंपल डेटा जनरेट करें (Arrow Maze उदाहरण)
```bash
# Arrow Maze के साथ त्वरित उदाहरण
bash games/tasks/arrow_maze/run.sh

# या कस्टम पैरामीटर के साथ
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### RL प्रशिक्षण के लिए

हम SynLogic डेटा का उपयोग करते हुए रिइन्फोर्समेंट लर्निंग प्रशिक्षण के लिए व्यापक मार्गदर्शन प्रदान करते हैं। SynLogic को Verl फ्रेमवर्क के साथ एकीकृत करने के विस्तृत निर्देशों के लिए देखें [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md)।

## :rocket: संसाधन

### डेटासेट्स
| डेटासेट नाम | विवरण | लिंक |
|:------------:|:------------|:----:|
| **SynLogic** | डेटासेट | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### मॉडल्स


| मॉडल नाम | विवरण | लिंक |
|:-----------|:------------|:----:|
| **SynLogic-7B** | SynLogic पर प्रशिक्षित 7B मॉडल | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | SynLogic पर प्रशिक्षित 32B मॉडल | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | मिश्रित SynLogic, गणित, कोडिंग डेटा पर प्रशिक्षित 32B मॉडल | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 भविष्य के अपडेट्स
हम SynLogic को और अधिक तार्किक तर्क कार्यों के साथ विस्तार करने के लिए सक्रिय रूप से कार्य कर रहे हैं।

नवीनतम अपडेट और रिलीज़ के लिए हमारे रिपॉजिटरी को फॉलो करें!

## उद्धरण
यदि आपको हमारा कार्य उपयोगी लगे, तो कृपया हमारे पेपर का उद्धरण करें:

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---