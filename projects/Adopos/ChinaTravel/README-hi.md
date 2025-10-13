<center>
  <h1>ChinaTravel: चीनी यात्रा योजना में भाषा एजेंट्स के लिए एक वास्तविक दुनिया का बेंचमार्क
</h1>
</center>

पेपर "ChinaTravel: चीनी यात्रा योजना में भाषा एजेंट्स के लिए एक वास्तविक दुनिया का बेंचमार्क" के लिए आधिकारिक कोडबेस।

<!-- | [वेबपेज](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [पेपर](https://arxiv.org/abs/2412.13682) | [डेटासेट(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![वेबपेज](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![पेपर](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![डेटासेट(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![प्रतियोगिता(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![प्रतियोगिता(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![अवलोकन](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 IJCAI 2025 यात्रा योजना चुनौती (TPC@IJCAI)

हमें यह घोषणा करते हुए गर्व है कि ChinaTravel को **यात्रा योजना चुनौती (TPC) @ IJCAI 2025** के लिए आधिकारिक बेंचमार्क के रूप में चुना गया है!

**आधिकारिक प्रतियोगिता वेबसाइट**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

प्रतिभागियों को आमंत्रित किया जाता है कि वे जटिल बाधाओं के तहत वास्तविक जीवन की यात्रा योजना की परिस्थितियों को हल करने के लिए नवीन एजेंट्स विकसित करें। यह प्रतियोगिता भाषा एजेंट अनुसंधान में अत्याधुनिक तरीकों का प्रदर्शन करेगी।

## 📝 चेंजलॉग

### 2025.09
1. TPC@IJCAI2025 DSL ट्रैक का विजेता समाधान अपलोड किया गया। योगदान के लिए [@evergreenee](https://github.com/evergreenee) को धन्यवाद।  


### 2025.06

1. कॉमन्सेंस के मूल्यांकन कोड में त्रुटि संग्रह को ठीक किया गया।
2. प्योर-न्यूरो एजेंट की पाइपलाइन ठीक की गई।
3. huggingface से load_datasets ठीक किया गया।
4. सिंटैक्स सत्यापन में अपवाद हैंडलिंग अपडेट किया गया।


### 2025.05

1. नवीनतम संस्करण के लिए अद्यतन लॉग।
2. TPC के लिए मूल्यांकन कोड प्रदान करें।

### 2025.04

1. स्थानीय डेटा लोडर जोड़ा गया। अब उपयोगकर्ता अपनी कस्टम क्वेरीज़ स्थानीय रूप से लोड कर सकते हैं। जब "run_exp.py" के लिए डिफ़ॉल्ट नहीं splits_name मान (जैसे "abc") निर्दिष्ट किया जाता है, तो सिस्टम स्वतः ही evaluation/default_splits/abc.txt से संबंधित फाइलें लोड करेगा, जहाँ TXT फाइल में लक्ष्य क्वेरी फाइलनाम शामिल होंगे।
2. विस्तृत बाधा वर्गीकरण। विस्तृत दस्तावेज़ देखें [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. LLM-modulo बेसलाइन पेश की गई
   ग्राउंड-ट्रुथ प्रतीकात्मक सत्यापनकर्ता के साथ LLM-modulo पाइपलाइन लागू करें।
   कार्यप्रणाली आधारित:
   पेपर: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   कोडबेस: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. Qwen3-8B/4B के साथ स्थानीय LLMs अनुमान का समर्थन।

## 🚀 त्वरित प्रारंभ

### ⚙️ सेटअप

1. एक conda वातावरण बनाएं और निर्भरता स्थापित करें:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. डेटाबेस डाउनलोड करें और उसे "chinatravel/environment/" डायरेक्टरी में अनजिप करें

डाउनलोड लिंक: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. ओपन-सोर्स LLMs डाउनलोड करें (वैकल्पिक)।

```bash
bash download_llm.sh
```

4. टोकनाइज़र डाउनलोड करें।

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ चलाना

हम deepseek (deepseek की आधिकारिक API), gpt-4o (chatgpt-4o-latest), glm4-plus, और स्थानीय अनुमान Qwen (Qwen3-8B), llama, mistral (Mistral-7B-Instruct-v0.3) आदि के साथ समर्थन करते हैं।

```bash
export OPENAI_API_KEY=""

python run_exp.py --splits easy --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits medium --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits human --agent LLMNeSy --llm deepseek --oracle_translation

python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B --oracle_translation


python run_exp.py --splits human --agent LLMNeSy --llm deepseek 
python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B 


python run_exp.py --splits human --agent LLM-modulo --llm deepseek --refine_steps 10 --oracle_translation
python run_exp.py --splits human --agent LLM-modulo --llm Qwen3-8B --refine_steps 10 --oracle_translation
```

**नोट**:

- `--oracle_translation` फ्लैग एनोटेटेड ग्राउंड ट्रुथ तक पहुंच सक्षम करता है जिसमें शामिल हैं:

  - `hard_logic_py`: निष्पादन योग्य सत्यापन DSL कोड
  - `hard_logic_nl`: संबंधित बाधा विवरण
  - उदाहरण एनोटेशन संरचना:

  ```python
  {
    "hard_logic_py": [
      "
      total_cost=0 
      for activity in allactivities(plan):
          total_cost+=activity_cost(activity)
              total_cost += innercity_transport_cost(activity_transports(activity))
      result=(total_cost<=1000)
      ", 
      "
      innercity_transport_set=set()
      for activity in allactivities(plan):
          if activity_transports(activity)!=[]:              
              innercity_transport_set.add(innercity_transport_type(activity_transports(activity)))
      result=(innercity_transport_set<={'taxi'})
      "
    ], 
    "hard_logic_nl": ["总预算为1800元", "市内交通选择taxi"], 
  }
  ```
- LLM-मॉड्यूलो विधि के प्रतीकात्मक परिशोधन प्रक्रिया के लिए **oracle_translation मोड आवश्यक** है

### 📊 मूल्यांकन

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```

TPC@IJCAI2025 में, मूल्यांकन कोड `eval_tpc.py` फ़ाइल में प्रदान किया गया है। आप मूल्यांकन कोड को निम्नलिखित तरीके से चला सकते हैं:

```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 दस्तावेज़

[पर्यावरण](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[संयम](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ उन्नत विकास

### 1. अपना खुद का एजेंट एल्गोरिदम विकसित करें

अपना खुद का एजेंट एल्गोरिदम विकसित करने के लिए, आपको `chinatravel/agent/base.py` में स्थित `BaseAgent` क्लास का इनहेरिट करना होगा और अपने एल्गोरिदम के लिए लॉजिक को `chinatravel/agent/load_model.py` की `init_agent` फंक्शन में जोड़ना होगा। हमने एक खाली एजेंट उदाहरण `TPCAgent` नाम से उपलब्ध कराया है।

कदम:

- **`BaseAgent` क्लास को इनहेरिट करें**: `chinatravel/agent` डायरेक्टरी में एक नया Python फ़ाइल बनाएँ और अपनी खुद की एजेंट क्लास को परिभाषित करें, जो `BaseAgent` से इनहेरिट करती हो।

```python:chinatravel/agent/your_agent.py
from .base import BaseAgent

class YourAgent(BaseAgent):
    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Initialization logic

    def act(self, observation):
        # Implement the decision - making logic of the agent
        pass
```

- **init_agent फ़ंक्शन में कोड जोड़ें**: chinatravel/agent/load_model.py फ़ाइल खोलें और init_agent फ़ंक्शन में अपने नए एजेंट के लिए समर्थन जोड़ें।

```python:
def init_agent(kwargs):
    # ... existing code ...
    elif kwargs["method"] == "YourMethodName":
        agent = YourAgent(
            **kwargs
        )
    # ... existing code ...
    return agent
```

### 2. अपना स्वयं का स्थानीय LLM विकसित करें

अपना स्वयं का स्थानीय बड़े भाषा मॉडल (LLM) विकसित करने के लिए, आपको chinatravel/agent/llms.py से AbstractLLM क्लास को विरासत में लेना होगा और llms.py में संबंधित स्थानीय LLM अनुमान कोड जोड़ना होगा। हम TPCLLM नामक एक खाली LLM उदाहरण प्रदान करते हैं।
चरण:

- **AbstractLLM क्लास को विरासत में लें**: chinatravel/agent/llms.py फ़ाइल में अपनी स्वयं की LLM क्लास को परिभाषित करें, जो AbstractLLM से विरासत में ले।

```python
class YourLLM(AbstractLLM):
    def __init__(self):
        super().__init__()
        # Initialization logic
        self.name = "YourLLMName"

    def _get_response(self, messages, one_line, json_mode):
        # Implement the response logic of the LLM
        response = "Your LLM response"
        if json_mode:
            # Handle JSON mode
            pass
        elif one_line:
            # Handle one - line mode
            response = response.split("\n")[0]
        return response
```

- **init_agent फ़ंक्शन में कोड जोड़ें**: chinatravel/agent/load_model.py फ़ाइल खोलें और init_llm फ़ंक्शन में अपने नए llm के लिए सपोर्ट जोड़ें।

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. अपने कोड को प्रयोग स्क्रिप्ट्स का उपयोग करके चलाएँ

ऊपर के विकास को पूरा करने के बाद, आप अपने कोड को चलाने के लिए प्रयोग स्क्रिप्ट्स का उपयोग कर सकते हैं।

चलाने का उदाहरण:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```
परिणाम `results/YourMethodName_YourLLMName_xxx` डायरेक्टरी में सेव किए जाएंगे, उदाहरण के लिए, `results/TPCAgent_TPCLLM`।

## ✉️ संपर्क करें

यदि आपको कोई समस्या है, तो कृपया [जिए-जिंग शाओ](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [बो-वेन झांग](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [शियाओ-वेन यांग](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn) से संपर्क करें।

## 📌 उद्धरण

यदि हमारा पेपर या संबंधित संसाधन आपके शोध में उपयोगी साबित होते हैं, तो कृपया इसका उद्धरण देने का कष्ट करें।


```
@misc{shao2024chinatravelrealworldbenchmarklanguage,
      title={ChinaTravel: A Real-World Benchmark for Language Agents in Chinese Travel Planning}, 
      author={Jie-Jing Shao and Xiao-Wen Yang and Bo-Wen Zhang and Baizhi Chen and Wen-Da Wei and Guohao Cai and Zhenhua Dong and Lan-Zhe Guo and Yu-feng Li},
      year={2024},
      eprint={2412.13682},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2412.13682}, 
}
```
[English](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=th) | [Français](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=de) | [Español](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=it) | [Русский](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ru) | [Português](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=as)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-13

---