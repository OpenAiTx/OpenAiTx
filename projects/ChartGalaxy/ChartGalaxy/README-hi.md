![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/title.png)

## डेटासेट
> 📦 **[👉 Hugging Face पर पूरा ChartGalaxy डेटासेट एक्सेस करें! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

स्टोरेज सीमाओं के कारण, हम केवल प्रतिनिधि उदाहरणों का एक संग्रह शामिल करते हैं।  
यह रिपॉजिटरी "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation" पेपर के लिए संबंधित कोड शामिल करती है।

## 🔥 समाचार
**2025.5**:  🎉🎉 हमने अपने डेटासेट का पहला संस्करण जारी किया है, जिसमें 1,151,087 सिंथेटिक और 104,519 वास्तविक इन्फोग्राफिक चार्ट्स शामिल हैं, जो 75 चार्ट प्रकारों और 330 वेरिएशन्स को कवर करते हैं।

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/teaser.png" style="border:none;box-shadow:none;">

![Examples image](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/examples.png)

<!-- ## 🔔 News -->

## परिचय

### बारे में

ChartGalaxy एक मिलियन-स्तरीय डेटासेट है जिसमें डेटा टेबल्स के साथ सिंथेटिक और वास्तविक इन्फोग्राफिक चार्ट्स शामिल हैं, जो इन्फोग्राफिक चार्ट समझ, कोड जेनरेशन और चार्ट जेनरेशन के अनुप्रयोगों का समर्थन करता है। यह डेटासेट इस चुनौती का समाधान करता है कि मौजूदा डेटासेट्स मुख्य रूप से सामान्य चार्ट्स तक सीमित हैं, जो इन्फोग्राफिक चार्ट्स की प्रमुख विशेषताओं — विविध डिजाइन शैलियों और लेआउट्स — को कैप्चर नहीं करते।

### सांख्यिकी

- **आकार**: 1,255,606 इन्फोग्राफिक चार्ट्स (1,151,087 सिंथेटिक + 104,519 वास्तविक)
- **सामग्री**: प्रत्येक इन्फोग्राफिक चार्ट के साथ उसकी निर्माण में प्रयुक्त टैबुलर डेटा जोड़ा गया है
- **चार्ट प्रकार**: 75 चार्ट प्रकार और 330 चार्ट वेरिएशन
- **लेआउट टेम्पलेट्स**: 68 लेआउट टेम्पलेट्स

### डेटा संग्रह और निर्माण

ChartGalaxy निम्नलिखित के माध्यम से बनाया गया:

1. **वास्तविक इन्फोग्राफिक चार्ट संग्रह**: चार्ट्स को 19 प्रतिष्ठित चार्ट-समृद्ध वेबसाइट्स जैसे Pinterest, Visual Capitalist, Statista, और Information is Beautiful से एकत्र किया गया।

2. **सिंथेटिक इन्फोग्राफिक चार्ट निर्माण**: एक इंडक्टिव स्ट्रक्चरिंग प्रक्रिया का पालन करते हुए जिसमें:
   - 75 चार्ट प्रकार (जैसे, बार चार्ट्स) और 330 वेरिएशन, जो विभिन्न विज़ुअल एलिमेंट स्टाइल्स को दर्शाते हैं, की पहचान की गई
   - 68 लेआउट टेम्पलेट्स निकाले गए, जो एलिमेंट्स के बीच स्थानिक संबंधों को परिभाषित करते हैं
   - इन पैटर्न्स के आधार पर प्रोग्रामेटिक रूप से सिंथेटिक चार्ट्स जेनरेट किए गए

## 🎯 अनुप्रयोग

ChartGalaxy की उपयोगिता तीन प्रतिनिधि अनुप्रयोगों के माध्यम से प्रदर्शित की गई है:

### 1. 🧠 इन्फोग्राफिक चार्ट समझ

ChartGalaxy पर फाइन-ट्यूनिंग करने से फाउंडेशन मॉडल्स की इन्फोग्राफिक चार्ट समझने की क्षमता में सुधार होता है।

### 2. 💻 इन्फोग्राफिक चार्ट कोड जेनरेशन

LVLMs के लिए इन्फोग्राफिक चार्ट्स के कोड जेनरेशन का मूल्यांकन करने के लिए एक बेंचमार्क। यह बेंचमार्क, जनरेट किए गए D3.js कोड द्वारा बनाए गए चार्ट्स और ग्राउंड-ट्रुथ चार्ट्स के बीच समानता को दो स्तरों पर मापता है: उच्च-स्तर (कुल मिलाकर विज़ुअल समानता) और निम्न-स्तर (फाइन-ग्रेन्ड SVG एलिमेंट्स में औसत समानता)।

#### ओवरव्यू

बेंचमार्क चार्ट कोड जेनरेशन का मूल्यांकन दो स्तरों पर करता है:
- **निम्न-स्तर**: जनरेट किए गए और संदर्भ SVGs के बीच एलिमेंट-वार समानता
- **उच्च-स्तर**: कुल मिलाकर विज़ुअल फिडेलिटी और फंक्शनलिटी मूल्यांकन

#### इंस्टॉलेशन

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### उपयोग

1. `code_generation_benchmark/configs/default_config.yaml` में सेटिंग्स कॉन्फ़िगर करें:
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # मूल्यांकन के लिए जिन मॉडलों को अनकॉमेंट करना है उन्हें अनकॉमेंट करें
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. बेंचमार्क चलाएं:
   ```bash
   python main.py
   ```

#### डेटा संरचना

`data_root_dir` में प्रत्येक चार्ट फोल्डर में शामिल होना चाहिए:
- `chart.svg`: SVG प्रारूप में मूल चार्ट

सिस्टम द्वारा जनरेट किया जाएगा:
- `convert_chart.html`: संदर्भ चार्ट का HTML रेंडरिंग
- `convert_chart.png`: संदर्भ चार्ट का PNG स्क्रीनशॉट
- `convert_chart.json`: संदर्भ चार्ट की एलिमेंट संरचना
- मॉडल-विशिष्ट आउटपुट्स उपफोल्डर्स में

#### परिणाम

परिणाम मॉडल-विशिष्ट उपफोल्डर्स में सहेजे जाते हैं:
- जनरेट किए गए HTML/PNG रेंडरिंग्स
- JSON प्रारूप में मूल्यांकन मेट्रिक्स
- `log_dir` में विस्तृत लॉग्स
  

### 3. 🖼️ उदाहरण-आधारित इन्फोग्राफिक चार्ट जेनरेशन

एक उदाहरण-आधारित विधि जो उपयोगकर्ता द्वारा प्रदान किए गए टैबुलर डेटा को एक इन्फोग्राफिक चार्ट में बदलती है, जो दिए गए उदाहरण चार्ट के लेआउट और विज़ुअल स्टाइल के अनुरूप है। उपयोगकर्ता अध्ययन से पता चलता है कि यह विधि फिडेलिटी, एस्थेटिक्स और क्रिएटिविटी में GPT-Image-1 से बेहतर है।


## संपर्क
- chartgalaxy@163.com

## पेपर लिंक्स

### 📌 मुख्य पेपर (यह रिपॉजिटरी)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### संबंधित पेपर्स

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 संदर्भ
यदि आप अपने शोध में ChartGalaxy का उपयोग करते हैं, तो कृपया इसे उद्धृत करें:
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---