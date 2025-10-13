<center>
  <h1>ChinaTravel: Çin Seyahat Planlamasında Dil Ajanları için Gerçek Dünya Ölçütü
</h1>
</center>

"ChinaTravel: Çin Seyahat Planlamasında Dil Ajanları için Gerçek Dünya Ölçütü" makalesinin resmi kod tabanı.

<!-- | [Web Sayfası](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [Makale](https://arxiv.org/abs/2412.13682) | [Veri Seti(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![Web Sayfası](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![Makale](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![Veri Seti(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![Yarışma(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![Yarışma(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![Genel Bakış](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 IJCAI 2025 Seyahat Planlama Yarışması (TPC@IJCAI)

ChinaTravel'in **IJCAI 2025 Seyahat Planlama Yarışması (TPC) @ IJCAI 2025** için resmi ölçüt olarak seçildiğini gururla duyuruyoruz!

**Resmi Yarışma Web Sitesi**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

Katılımcılar, karmaşık kısıtlar altında gerçek dünya seyahat planlama senaryolarını çözebilecek yenilikçi ajanlar geliştirmeye davet edilmektedir. Bu yarışma, dil ajanı araştırmalarında en son yaklaşımları sergileyecektir.

## 📝 Değişiklik Günlüğü

### 2025.09
1. TPC@IJCAI2025 DSL parkurunun şampiyon çözümü yüklendi. Katkılarından dolayı [@evergreenee](https://github.com/evergreenee) 'ye teşekkürler.  


### 2025.06

1. Commonsense değerlendirme kodunda hata toplama düzeltildi. 
2. Saf nöro ajanının işlem hattı düzeltildi
3. Huggingface'den load_datasets düzeltildi
4. Söz dizimi doğrulamasında istisna yönetimi güncellendi


### 2025.05

1. En son sürüm için güncelleme kayıtları.
2. TPC için değerlendirme kodunu sağlayın.

### 2025.04

1. Yerel veri yükleyici eklendi. Kullanıcılar artık özel sorguları yerel olarak yükleyebilir. "run_exp.py" için varsayılan olmayan splits_name değerleri (örneğin "abc") belirtildiğinde, sistem otomatik olarak evaluation/default_splits/abc.txt içinden ilgili dosyaları yükler; burada TXT dosyası hedef sorgu dosya adlarını içerir.
2. Ayrıntılı kısıtlama sınıflandırması. Detaylı belgeler için bkz. [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. LLM-modulo temel modeli tanıtıldı
   LLM-modulo hattını gerçek sembolik doğrulayıcı ile uygulayın.
   Metodolojiye dayalı olarak:
   Makale: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   Kod tabanı: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. Qwen3-8B/4B ile yerel LLM çıkarım desteği.

## 🚀 Hızlı Başlangıç

### ⚙️ Kurulum

1. Bir conda ortamı oluşturun ve bağımlılıkları yükleyin:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. Veritabanını indirin ve "chinatravel/environment/" dizinine çıkartın

İndirme Bağlantıları: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. Açık kaynaklı LLM'leri indirin (isteğe bağlı).

```bash
bash download_llm.sh
```

4. Tokenizer'ları indirin.

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ Çalıştırma

Deepseek (deepseek'in resmi API'si), gpt-4o (chatgpt-4o-latest), glm4-plus ve Qwen (Qwen3-8B), llama, mistral (Mistral-7B-Instruct-v0.3) gibi yerel çıkarımlarını destekliyoruz.

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

**Not**:

- `--oracle_translation` bayrağı, aşağıdakileri içeren açıklamalı gerçek veri erişimini etkinleştirir:

  - `hard_logic_py`: Çalıştırılabilir doğrulama DSL kodu
  - `hard_logic_nl`: İlgili kısıtlama açıklamaları
  - Örnek açıklama yapısı:

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
- LLM-modulo yöntemi, sembolik iyileştirme süreci için **oracle_translation** modunu **gerektirir**

### 📊 Değerlendirme

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```

TPC@IJCAI2025'te, değerlendirme kodu `eval_tpc.py` dosyasında sağlanmıştır. Değerlendirme kodunu aşağıdaki şekilde çalıştırabilirsiniz:

```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 Belgeler

[Ortam](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[Kısıtlamalar](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ Gelişmiş Geliştirme

### 1. Kendi Ajan Algoritmanızı Geliştirin

Kendi ajan algoritmanızı geliştirmek için, `chinatravel/agent/base.py` dosyasındaki `BaseAgent` sınıfını miras almalı ve algoritmanızın mantığını `chinatravel/agent/load_model.py` dosyasındaki `init_agent` fonksiyonuna eklemelisiniz. Boş bir ajan örneği olarak `TPCAgent` sağladık.

Adımlar:

- **`BaseAgent` sınıfını miras alın**: `chinatravel/agent` dizininde yeni bir Python dosyası oluşturun ve kendi ajan sınıfınızı `BaseAgent`'tan türeterek tanımlayın.

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

- **init_agent fonksiyonuna kod ekleyin**: chinatravel/agent/load_model.py dosyasını açın ve yeni ajanınız için init_agent fonksiyonunda destek ekleyin.

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

### 2. Kendi Yerel LLM'inizi Geliştirin

Kendi yerel büyük dil modelinizi (LLM) geliştirmek için chinatravel/agent/llms.py dosyasındaki AbstractLLM sınıfını devralmanız ve llms.py dosyasına ilgili yerel LLM çıkarım kodunu eklemeniz gerekir. Boş bir LLM örneği olarak TPCLLM sağlanmıştır.
Adımlar:

- **AbstractLLM sınıfını devralın**:  chinatravel/agent/llms.py dosyasında kendi LLM sınıfınızı tanımlayın ve AbstractLLM'den devralın.

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

- **init_agent fonksiyonuna kod ekleyin**: chinatravel/agent/load_model.py dosyasını açın ve yeni llm'niz için init_llm fonksiyonuna destek ekleyin.

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. Deney Scriptlerini Kullanarak Kodunuzu Çalıştırın

Yukarıdaki geliştirmeyi tamamladıktan sonra, kodunuzu çalıştırmak için deney scriptlerini kullanabilirsiniz.

Çalıştırma örneği:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```

Sonuçlar `results/YourMethodName_YourLLMName_xxx` dizinine kaydedilecektir, örn. `results/TPCAgent_TPCLLM`.

## ✉️ İletişim

Herhangi bir sorununuz olursa, lütfen [Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn) ile iletişime geçin.

## 📌 Atıf

Makalemiz veya ilgili kaynaklarımız araştırmanız için değerli olduysa, lütfen atıfta bulunun.

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