# KVzip: संदर्भ पुनर्निर्माण के साथ क्वेरी-एग्नोस्टिक KV कैश संपीड़न

[[पेपर](https://arxiv.org/abs/2505.23416)] [[ब्लॉग](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## क्या नया है?
- KVzip KV कैश को संपीड़ित करता है ताकि **विविध भविष्य की क्वेरियों** का समर्थन किया जा सके।
- [संदर्भ-निर्भर] **3–4× KV कैश आकार में कमी** और **2× डिकोडिंग विलंबता में कमी** प्राप्त करें, न्यूनतम प्रदर्शन ह्रास के साथ।
- [संदर्भ-स्वतंत्र] [DuoAttention](https://github.com/mit-han-lab/duo-attention)-शैली के हेड-स्तर KV संपीड़न को बढ़ाएं, केवल **एक मिनट के भीतर कुछ फॉरवर्ड पास** का उपयोग करके हेड-स्तर महत्व-स्कोर अनुकूलन के लिए (100 गुना तेज)।
- demo.py चलाएँ:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### क्वेरी-एग्नोस्टिक सेटिंग पर बेंचमार्किंग
- कार्य: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294)। 
- मॉडल: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## इंस्टॉलेशन
हमने CUDA 12.1 और Python 3.10 का उपयोग किया
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- [QServe](https://github.com/mit-han-lab/omniserve) क्वांटाइजेशन का उपयोग करने के लिए कृपया [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model) का पालन करें।
### डेटासेट
- कृपया पूर्व-संसाधित SCBench डेटासेट [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link) से डाउनलोड करें।
- यदि आपने फाइलों को अनजिप कर लिया है, तो बस scbench फ़ोल्डर को स्थानांतरित करें।
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## त्वरित प्रारंभ
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "यह मेरी मूल प्रोफ़ाइल है। मेरा नाम किम है जो सियोल में रहता है। मेरा प्रमुख विषय कंप्यूटर विज्ञान है।"
queries = ["मेरा नाम क्या है?", "क्या मैं सियोल में रहता हूँ?"]

kv = model.prefill(context, load_score=False)  # KV कैश भरें + महत्व स्कोरिंग
kv.prune(ratio=0.3)  # संपीड़न अनुपात, 70% KV निकालें

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # कुशल अनुमान
    print(q, output)
```
- समर्थित मॉडल [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py) में सूचीबद्ध हैं, जिनमें **LLaMA3, Qwen2.5/3, Gemma3** शामिल हैं।
- संपीड़न ओवरहेड को समाप्त करने के लिए `load_score=True` सेट करें। यह संदर्भ-स्वतंत्र KV निकासी सक्षम करता है, जिसमें `ratio=0.6` के संपीड़न अनुपात का व्यापार होता है।
- जनरेशन के बाद, क्वेरियों और उत्पन्न टोकनों से संबंधित KV जोड़े चयनात्मक रूप से कैश से निकाले जाते हैं ताकि आगे प्रसंस्करण किया जा सके। मल्टी-टर्न अनुमान सक्षम करने के लिए `update_cache=True` सेट करें, जिससे अनुमान के दौरान पूर्ण इंटरैक्शन इतिहास संरक्षित रहता है। 

## मेमोरी और कम्प्यूटेशन समय प्रोफाइलिंग
### संदर्भ-निर्भर निकासी
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- ऊपर दिया गया कोड पूर्ण और संकुचित KV कैश के साथ उत्पन्न आउटपुट की तुलना भी करता है।
- त्वरित परीक्षण के लिए `-d squad` का उपयोग करें। लंबी संदर्भ परीक्षण के लिए `-d scbench_kv` का उपयोग करें।
  - उपलब्ध डेटा नाम: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py)।
  - उपलब्ध मॉडल नाम: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), उदाहरण के लिए llama3.1-8b, qwen2.5-7b (या Qwen/Qwen2.5-7B-Instruct-1M)।
- हम [AdaKV](https://github.com/FFY0/AdaKV/tree/main) से CUDA कर्नेल को अनुकूलित करते हैं, जो गैर-समान हेड बजट आवंटन का समर्थन करता है।
  - वर्तमान में, हमारे कोड में Gemma3 के लिए एक अनुकूलित कर्नेल नहीं है जो स्थैतिक KV कैश का उपयोग करता है, इसलिए यह कोड वास्तविक दक्षता लाभ प्रदान नहीं करता। हालांकि, KV सबसैंपलिंग (`--kv_type retain`) के साथ कम ध्यान का उपयोग करके मॉडल प्रदर्शन का मूल्यांकन अभी भी किया जा सकता है।


### संदर्भ-स्वतंत्र निकासी (कोई रनटाइम संपीड़न ओवरहेड नहीं)
- `--level head` ध्वज के साथ `--ratio 0.6` (अनुशंसित) का उपयोग करें।
  - हम एक विशिष्ट हेड से जुड़े सभी संदर्भ KV जोड़े निकाल देते हैं जबकि सिस्टम प्रॉम्प्ट और क्वेरी KV जोड़े बनाए रखते हैं।
  - पूर्व-गणना किए गए हेड स्कोर LLaMA3.1-8B और Qwen2.5-7/14B के लिए `./utils/head_score` में उपलब्ध हैं।
- अन्य मॉडलों के लिए हेड स्कोर गणना करने के लिए:
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - परिणाम `./utils/head_score` में सहेजे जाएंगे।
  - यदि कोडिंग कार्य लक्षित है, तो हम अतिरिक्त रूप से `-d scbench_repoqa` के साथ कमांड चलाने की सलाह देते हैं। यह मॉडल को प्राकृतिक और कोडिंग भाषाओं दोनों से अधिकतम हेड स्कोर का उपयोग करने की अनुमति देता है, जो प्रदर्शन में सुधार करता है।
- ये स्कोर [DuoAttention](https://github.com/mit-han-lab/duo-attention) के अनुकूलित अनुमान इंजन के साथ निर्बाध रूप से एकीकृत किए जा सकते हैं, बस उनके हेड स्कोर डेटा को हमारे स्कोर से बदलकर।


## मूल्यांकन
- 0.1 से 1.0 तक के KV संपीड़न अनुपात के साथ मॉडल प्रतिक्रियाएँ उत्पन्न करने के लिए:
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - परिणाम `./results/[data_name]` में सहेजे जाएंगे।
  - समर्थित डेटासेट `data/load.py` में सूचीबद्ध हैं।
- उत्पन्न परिणामों से मूल्यांकन मेट्रिक्स गणना करने के लिए:
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## नए मॉडलों पर लागू करना
KVzip को नए मॉडल के लिए एकीकृत करने के लिए, आपको निम्न फाइलों को अपडेट करना होगा:
- `attention/attn.py`  
  आवश्यकतानुसार ध्यान फॉरवर्ड पास लॉजिक संशोधित करें। कुछ मामलों में, kvcache.py और score.py में भी अपडेट आवश्यक हो सकते हैं।
- `model/monkeypatch.py`  
  एकीकरण के लिए मॉडल-विशिष्ट मंकी पैचिंग लागू करें।
- `model/template.py`   
  मॉडल के सिस्टम प्रॉम्प्ट और चैट फॉर्मेटिंग टेम्पलेट परिभाषित करें।


## संदर्भ
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## लाइसेंस
MIT लाइसेंस

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---