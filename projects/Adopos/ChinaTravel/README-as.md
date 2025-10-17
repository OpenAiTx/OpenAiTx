<center>
  <h1>ChinaTravel: চীন ভ্ৰমণ পৰিকল্পনাত ভাষা এজেন্টৰ বাবে বাস্তৱিক বেঞ্চমাৰ্ক
</h1>
</center>

"ChinaTravel: চীন ভ্ৰমণ পৰিকল্পনাত ভাষা এজেন্টৰ বাবে বাস্তৱিক বেঞ্চমাৰ্ক" শিৰোনামৰ কাগজখনৰ বাবে চৰকাৰী ক'ডবেছ।

<!-- | [Webpage](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [Paper](https://arxiv.org/abs/2412.13682) | [Dataset(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![Webpage](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![Paper](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![Dataset(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![Competition(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![Competition(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![Overview](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 IJCAI 2025 ভ্ৰমণ পৰিকল্পনা চেলেঞ্জ (TPC@IJCAI)

আমাৰ গৌৰৱ যে ChinaTravel **Travel Planning Challenge (TPC) @ IJCAI 2025**-ৰ চৰকাৰী বেঞ্চমাৰ্ক হিচাপে নিৰ্বাচিত হৈছে!

**চৰকাৰী প্ৰতিযোগিতা ৱেবছাইট**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

অংশগ্ৰহণকাৰীসকলক জটিল সীমাবদ্ধতাৰ অধীনত বাস্তৱিক ভ্ৰমণ পৰিকল্পনাৰ পৰিস্থিতি সমাধান কৰিবলৈ নতুন এজেন্ট বিকাশ কৰাৰ বাবে নিমন্ত্ৰণ জনোৱা হৈছে। এই প্ৰতিযোগিতাত ভাষা এজেন্ট গৱেষণাৰ শ্ৰেষ্ঠতম পদ্ধতি প্রদর্শিত হ'ব।

## 📝 পৰিবর্তন তালিকা

### 2025.09
1. TPC@IJCAI2025 DSL ট্রেকৰ চেম্পিয়ন সমাধান আপলোড কৰা হৈছে। [@evergreenee](https://github.com/evergreenee)ক ধন্যবাদ তেওঁলোকৰ অৱদানৰ বাবে।  


### 2025.06

1. কমনসেন্সৰ মূল্যায়ন কোডত ত্ৰুটি সংগ্ৰহ সংশোধন।
2. পিউৰ-নিউৰো এজেন্টৰ পাইপলাইন সংশোধন।
3. Huggingface-ৰ পৰা load_datasets সংশোধন।
4. Syntax verification-ৰ exception handling আপডেট।


### ২০২৫.০৫

১. শেহতীয়া সংস্কৰণৰ বাবে আপডেট লগসমূহ।
২. TPCৰ বাবে মূল্যাংকন ক'ড প্ৰদান কৰক।

### ২০২৫.০৪

১. স্থানীয় ডাটা ল'ডাৰ যোগ কৰা হৈছে। ব্যৱহাৰকাৰীসকলে এতিয়া নিজৰ কাষ্টম কুৱাৰী স্থানীয়ভাৱে ল'ড কৰিব পাৰে। "run_exp.py"ৰ বাবে ডিফল্ট নহোৱা splits_name মান (উদাহৰণস্বৰূপ, "abc") উল্লেখ কৰাৰ সময়ত, ব্যৱস্থাটো স্বয়ংক্ৰিয়ভাৱে evaluation/default_splits/abc.txtৰ পৰা সংশ্লিষ্ট ফাইলসমূহ ল'ড কৰিব, য'ত TXT ফাইলত লক্ষ্য কুৱাৰী ফাইলৰ নাম থাকে।
২. বিস্তৃত সীমাবদ্ধতা শ্ৰেণীবিভাজন। বিস্তৃত নথিপত্র [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)ত চাওক
৩. LLM-modulo বেছলাইন পৰিচয় কৰোৱা হৈছে
   LLM-modulo পাইপলাইনৰ সৈতে এক বাস্তৱ-সত্য প্ৰতিকী পৰীক্ষক প্ৰয়োগ কৰক।
   পদ্ধতিটো ভিত্তি কৰা হৈছে:
   পেপাৰ: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   ক'ডবেছ: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
৪. স্থানীয় LLMs Qwen3-8B/4B-ৰ সৈতে inference সমৰ্থন কৰক।

## 🚀 তৎকালিক আৰম্ভণি

### ⚙️ ছেটআপ

১. এটা কন্ডা পৰিৱেশ সৃষ্টি কৰক আৰু নিৰ্ভরতাসমূহ সংস্থাপন কৰক:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. ডাটাবেছটো ডাউনলোড কৰক আৰু "chinatravel/environment/" ডাইৰেক্টৰীত আনজিপ কৰক

ডাউনলোড লিংক: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. মুক্ত উৎস LLMs ডাউনলোড কৰক (ঐচ্ছিক)।

```bash
bash download_llm.sh
```

৪. টকেনাইজাৰসমূহ ডাউনলোড কৰক।

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ চলাই থকা

আমরা deepseek (deepseekৰ চৰকাৰী API), gpt-4o (chatgpt-4o-latest), glm4-plus, আৰু Qwen (Qwen3-8B), llama, mistral (Mistral-7B-Instruct-v0.3) আদি ব্যৱহাৰ কৰি স্থানীয় inference সমৰ্থন কৰোঁ।

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

**টিপ্পণী**:

- `--oracle_translation` ফ্লেগটো ব্যৱহাৰ কৰিলে এনোটেটেড গ্ৰাউণ্ড ট্ৰুথত প্ৰৱেশ কৰিবলৈ সক্ষম কৰে, ইয়াত অন্তর্ভুক্ত:

  - `hard_logic_py`: এক্সিকিউটেবল ভেৰিফিকেশন DSL ক'ড
  - `hard_logic_nl`: তাৰ সৈতে সংযুক্ত বাধাৰ বৰ্ণনা
  - উদাহৰণ এনোটেশ্যন গঠন:

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
- LLM-modulo পদ্ধতিটোৱে তাৰ চিহ্নৰ শুদ্ধীকৰণ প্ৰক্ৰিয়াৰ বাবে **oracle_translation** ম'ডৰ প্ৰয়োজন

### 📊 মূল্যায়ন

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```
TPC@IJCAI2025-ত, মূল্যায়ন কোডটো `eval_tpc.py` ফাইলত উপলব্ধ কৰা হৈছে। আপুনি তলত দিয়া দৰে মূল্যায়ন কোডটো চলাব পাৰিব:


```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 নথিপত্র

[পৰিবেশ](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[বন্ধনসমূহ](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ উন্নত বিকাশ

### ১. নিজৰ এজেন্ট এলগৰিদম উন্নয়ন কৰক

নিজৰ এজেন্ট এলগৰিদম উন্নয়ন কৰিবলৈ, আপোনাৰ `chinatravel/agent/base.py`-ৰ পৰা `BaseAgent` শ্ৰেণীটো উত্তরাধিকার কৰিবলৈ লাগিব আৰু আপোনাৰ এলগৰিদমৰ যুক্তি `chinatravel/agent/load_model.py`-ৰ `init_agent` ফাংশ্যনলৈ যোগ কৰিব লাগিব। আমি এখন খালি এজেন্ট উদাহৰণ `TPCAgent` নামেৰে প্ৰদান কৰিছো।

পদক্ষেপসমূহ:

- **`BaseAgent` শ্ৰেণীটো উত্তরাধিকার কৰক**: `chinatravel/agent` ডাইৰেক্টৰীত এখন নতুন Python ফাইল সৃষ্টি কৰক আৰু নিজৰ এজেন্ট শ্ৰেণী সংজ্ঞায়িত কৰক, `BaseAgent`-ৰ পৰা উত্তরাধিকার কৰি।

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

- **init_agent ফাংচনটোত কোড যোগ কৰক**: chinatravel/agent/load_model.py ফাইলটো খুলক আৰু init_agent ফাংচনটোত আপোনাৰ নতুন এজেণ্টৰ বাবে সমৰ্থন যোগ কৰক।

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

### 2. আপোনাৰ নিজৰ স্থানীয় LLM উন্নয়ন কৰক

আপোনাৰ নিজৰ স্থানীয় বৃহৎ-ভাষা মডেল (LLM) উন্নয়ন কৰিবলৈ, chinatravel/agent/llms.py ৰ পৰা AbstractLLM শ্ৰেণীটো উত্তরাধিকার ল’ব লাগিব আৰু llms.py ত সংশ্লিষ্ট স্থানীয় LLM inference code যোগ কৰিব লাগিব। আমি TPCLLM নামৰ এটা খালী LLM উদাহৰণ প্ৰদান কৰিছোঁ।
পদক্ষেপসমূহ:

- **AbstractLLM শ্ৰেণীটো উত্তরাধিকার লওক**:  chinatravel/agent/llms.py ফাইলত আপোনাৰ নিজৰ LLM শ্ৰেণী সংজ্ঞায়িত কৰক, AbstractLLM ৰ পৰা উত্তরাধিকার লৈ।

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

- **init_agent ফাংশনত কোড যোগ কৰক**: chinatravel/agent/load_model.py ফাইলখন খুলক আৰু init_llm ফাংশনত আপোনাৰ নতুন llm-ৰ সমৰ্থন যোগ কৰক।

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. আপোনাৰ কোড পৰীক্ষা স্ক্ৰিপ্ট ব্যৱহাৰ কৰি চলাওক

ওপৰৰ বিকাশ সম্পূৰ্ণ কৰাৰ পিছত, আপুনি পৰীক্ষা স্ক্ৰিপ্টসমূহ ব্যৱহাৰ কৰি আপোনাৰ কোড চলাব পাৰে।

চলোৱাৰ উদাহৰণ:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```

ফলাফলসমূহ `results/YourMethodName_YourLLMName_xxx` ডিৰেক্টৰিত সংৰক্ষণ কৰা হ'ব, উদাহৰণস্বৰূপে, `results/TPCAgent_TPCLLM`।

## ✉️ যোগাযোগ

আপুনি যদি কোনো সমস্যাৰ সন্মুখীন হন, অনুগ্ৰহ কৰি [Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn)-ক যোগাযোগ কৰক।

## 📌 উদ্ধৃতি

যদি আমাৰ গবেষণাপত্র বা সংশ্লিষ্ট উৎসবোৰ আপোনাৰ গবেষণাত মূল্যবান প্ৰমাণিত হয়, অনুগ্ৰহ কৰি উদ্ধৃতি দিয়ক।

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-17

---