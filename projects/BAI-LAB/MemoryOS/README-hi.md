# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 यदि आपको हमारा प्रोजेक्ट पसंद आए, तो कृपया GitHub पर हमें एक स्टार ⭐ दें ताकि आपको नवीनतम अपडेट मिल सके।</h5>
**MemoryOS** को व्यक्तिगत AI एजेंट्स के लिए एक मेमोरी ऑपरेटिंग सिस्टम प्रदान करने के लिए डिज़ाइन किया गया है, जिससे अधिक सुसंगत, व्यक्तिगत और संदर्भ-जागरूक इंटरैक्शन संभव हो सके। ऑपरेटिंग सिस्टम्स में मेमोरी प्रबंधन सिद्धांतों से प्रेरित होकर, यह एक श्रेणीबद्ध स्टोरेज आर्किटेक्चर अपनाता है, जिसमें चार मुख्य मॉड्यूल हैं: स्टोरेज, अपडेटिंग, रिट्रीवल, और जेनरेशन, ताकि व्यापक और कुशल मेमोरी प्रबंधन प्राप्त किया जा सके। LoCoMo बेंचमार्क पर, मॉडल ने F1 और BLEU-1 स्कोर में औसतन **49.11%** और **46.18%** का सुधार हासिल किया।







## 📣 नवीनतम समाचार
*   *<mark>[new]</mark>* 🔥  **[2025-06-15]**:🛠️ ओपन-सोर्स **MemoryOS-MCP** जारी! अब एजेंट क्लाइंट्स पर निर्बाध एकीकरण और कस्टमाइजेशन के लिए कॉन्फ़िगर किया जा सकता है। [👉 देखें](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: **MemoryOS** का प्रारंभिक संस्करण लॉन्च! इसमें शॉर्ट-टर्म, मिड-टर्म और लॉन्ग-टर्म पर्सोना मेमोरी के साथ स्वचालित यूजर प्रोफाइल और नॉलेज अपडेटिंग की सुविधा है।

## डेमो
[![वीडियो देखें](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	सिस्टम आर्किटेक्चर
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## प्रोजेक्ट संरचना

```
memoryos/
├── __init__.py            # MemoryOS पैकेज को इनिशियलाइज़ करता है
├── __pycache__/           # पायथन कैश डायरेक्टरी (स्वतः-निर्मित)
├── long_term.py           # लॉन्ग-टर्म पर्सोना मेमोरी (यूजर प्रोफाइल, नॉलेज) को मैनेज करता है
├── memoryos.py            # MemoryOS के लिए मुख्य क्लास, सभी घटकों का संचालन करता है
├── mid_term.py            # मिड-टर्म मेमोरी को मैनेज करता है, शॉर्ट-टर्म इंटरैक्शन को समेकित करता है
├── prompts.py             # LLM इंटरैक्शन (जैसे, समरी, विश्लेषण) के लिए प्रॉम्प्ट्स रखता है
├── retriever.py           # सभी मेमोरी लेयर्स से संबंधित जानकारी पुनः प्राप्त करता है
├── short_term.py          # हालिया इंटरैक्शन के लिए शॉर्ट-टर्म मेमोरी को मैनेज करता है
├── updater.py             # मेमोरी अपडेट्स को प्रोसेस करता है, जिसमें लेयर्स के बीच जानकारी को प्रोमोट करना शामिल है
└── utils.py               # लाइब्रेरी भर में प्रयुक्त यूटिलिटी फंक्शन्स
```

## यह कैसे काम करता है

1.  **इनिशियलाइज़ेशन:** `Memoryos` को यूजर और असिस्टेंट ID, API कुंजी, डेटा स्टोरेज पाथ और विभिन्न कैपेसिटी/थ्रेशहोल्ड सेटिंग्स के साथ इनिशियलाइज़ किया जाता है। यह प्रत्येक यूजर और असिस्टेंट के लिए डेडिकेटेड स्टोरेज सेटअप करता है।
2.  **मेमोरी जोड़ना:** यूजर इनपुट और एजेंट रिस्पॉन्स को QA पेयर के रूप में जोड़ा जाता है। इन्हें प्रारंभ में शॉर्ट-टर्म मेमोरी में संग्रहीत किया जाता है।
3.  **शॉर्ट-टर्म से मिड-टर्म प्रोसेसिंग:** जब शॉर्ट-टर्म मेमोरी भर जाती है, तो `Updater` मॉड्यूल इन इंटरैक्शनों को प्रोसेस करता है, उन्हें अर्थपूर्ण सेगमेंट्स में समेकित करता है और मिड-टर्म मेमोरी में संग्रहीत करता है।
4.  **मिड-टर्म विश्लेषण और LPM अपडेट:** मिड-टर्म मेमोरी सेगमेंट्स "हीट" संचित करते हैं, जैसे विज़िट फ्रिक्वेंसी और इंटरैक्शन की लंबाई के आधार पर। जब किसी सेगमेंट की हीट थ्रेशहोल्ड पार कर जाती है, तो उसकी सामग्री का विश्लेषण किया जाता है:
    *   यूजर प्रोफाइल इनसाइट्स निकाली जाती हैं और लॉन्ग-टर्म यूजर प्रोफाइल को अपडेट करने के लिए उपयोग की जाती हैं।
    *   विशिष्ट यूजर फैक्ट्स यूजर के लॉन्ग-टर्म नॉलेज में जोड़े जाते हैं।
    *   असिस्टेंट के लिए प्रासंगिक जानकारी असिस्टेंट के लॉन्ग-टर्म नॉलेज बेस में जोड़ी जाती है।
5.  **रिस्पॉन्स जेनरेशन:** जब यूजर क्वेरी प्राप्त होती है:
    *   `Retriever` मॉड्यूल शॉर्ट-टर्म हिस्ट्री, मिड-टर्म मेमोरी सेगमेंट्स, यूजर के प्रोफाइल और नॉलेज, तथा असिस्टेंट के नॉलेज बेस से प्रासंगिक संदर्भ पुनः प्राप्त करता है।
    *   यह व्यापक संदर्भ, यूजर की क्वेरी के साथ मिलकर, LLM के माध्यम से एक सुसंगत और सूचित उत्तर उत्पन्न करने के लिए उपयोग किया जाता है।

## MemoryOS_PYPI आरंभ करें

### आवश्यकताएँ

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### इंस्टॉलेशन

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### बुनियादी उपयोग

```python

import os
from memoryos import Memoryos

# --- बेसिक कॉन्फ़िगरेशन ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # अपनी कुंजी यहाँ डालें
BASE_URL = ""  # वैकल्पिक: यदि आप कस्टम OpenAI एंडपॉइंट का उपयोग कर रहे हैं
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS सरल डेमो")
    
    # 1. MemoryOS इनिशियलाइज़ करें
    print("MemoryOS इनिशियलाइज़ हो रहा है...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOS सफलतापूर्वक इनिशियलाइज़ हो गया!\n")
    except Exception as e:
        print(f"त्रुटि: {e}")
        return

    # 2. कुछ बेसिक मेमोरी जोड़ें
    print("कुछ मेमोरी जोड़ रहे हैं...")
    
    memo.add_memory(
        user_input="Hi! I'm Tom, I work as a data scientist in San Francisco.",
        agent_response="Hello Tom! Nice to meet you. Data science is such an exciting field. What kind of data do you work with?"
    )
     
    test_query = "What do you remember about my job?"
    print(f"User: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Assistant: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP आरंभ करें
### 🔧 मुख्य उपकरण

#### 1. `add_memory`
यूजर और AI असिस्टेंट के बीच वार्तालाप की सामग्री को मेमोरी सिस्टम में सहेजता है, ताकि एक स्थायी डायलॉग इतिहास और संदर्भ रिकॉर्ड तैयार हो सके।

#### 2. `retrieve_memory`
मेमोरी सिस्टम से क्वेरी के आधार पर संबंधित ऐतिहासिक संवाद, यूजर की प्राथमिकताएँ और ज्ञान जानकारी प्राप्त करता है, जिससे AI असिस्टेंट को यूजर की आवश्यकताओं और पृष्ठभूमि को समझने में सहायता मिलती है।

#### 3. `get_user_profile`
ऐतिहासिक संवाद के विश्लेषण से उत्पन्न यूजर प्रोफाइल प्राप्त करता है, जिसमें यूजर के व्यक्तित्व लक्षण, रुचियों की प्राथमिकताएँ, और संबंधित ज्ञान पृष्ठभूमि शामिल हैं।


### 1. डिपेंडेंसी इंस्टॉल करें
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. कॉन्फ़िगरेशन

`config.json` संपादित करें：
```json
{
  "user_id": "आपका यूजरID",
  "openai_api_key": "आपकी OpenAI API कुंजी",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. सर्वर प्रारंभ करें
```bash
python server_new.py --config config.json
```
### 4. परीक्षण करें
```bash
python test_comprehensive.py
```
### 5. Cline और अन्य क्लाइंट्स पर कॉन्फ़िगर करें
mcp.json फ़ाइल कॉपी करें, और सुनिश्चित करें कि फ़ाइल पथ सही है।
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#इसे अपने वर्चुअल एनवायरनमेंट के पायथन इंटरप्रेटर में बदलें
```
## योगदान करें

योगदान का स्वागत है! कृपया बेझिझक इश्यू या पुल रिक्वेस्ट सबमिट करें।

## उद्धरण
यदि आप अधिक विवरण पढ़ना चाहते हैं, तो कृपया यहाँ क्लिक करें: [पूरा पेपर पढ़ें](https://arxiv.org/abs/2506.06326)

यदि आपको यह प्रोजेक्ट उपयोगी लगे, तो कृपया हमारे पेपर का हवाला दें:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## हमसे संपर्क करें
百家AI बीजिंग डाक और दूरसंचार विश्वविद्यालय की प्रोफेसर बाई टिंग के मार्गदर्शन में एक शोध समूह है, जो सिलिकॉन-आधारित मानव के लिए भावनाओं से भरपूर और असाधारण स्मृति वाले मस्तिष्क के निर्माण के लिए समर्पित है।<br>
सहयोग और सुझाव: baiting@bupt.edu.cn<br>
百家Agent पब्लिक अकाउंट और WeChat ग्रुप में शामिल होने के लिए आपका स्वागत है, आइए मिलकर चर्चा करें!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="百家Agent公众号" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="微信群二维码" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---