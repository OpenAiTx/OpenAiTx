<center>
  <h1>ChinaTravel: Een Real-World Benchmark voor Taalagenten in Chinese Reisplanning
</h1>
</center>

Officiële codebasis voor het artikel "ChinaTravel: Een Real-World Benchmark voor Taalagenten in Chinese Reisplanning".

<!-- | [Webpagina](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [Artikel](https://arxiv.org/abs/2412.13682) | [Dataset(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![Webpagina](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![Artikel](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![Dataset(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![Competitie(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![Competitie(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![Overzicht](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 IJCAI 2025 Reisplanningsuitdaging (TPC@IJCAI)

We zijn trots om aan te kondigen dat ChinaTravel is geselecteerd als de officiële benchmark voor de **Reisplanningsuitdaging (TPC) @ IJCAI 2025**!

**Officiële competitie-website**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

Deelnemers worden uitgenodigd om nieuwe agenten te ontwikkelen die echte reisplanningsscenario’s onder complexe randvoorwaarden aankunnen. Deze competitie toont de nieuwste benaderingen in taalagentonderzoek.

## 📝 Wijzigingslog

### 2025.09
1. Upload de winnende oplossing van TPC@IJCAI2025 DSL-track. Dank aan [@evergreenee](https://github.com/evergreenee) voor hun bijdrage.  


### 2025.06

1. Foutcorrectie bij het verzamelen van fouten in de evaluatiecode voor common sense.
2. Foutcorrectie in de pipeline van de pure-neuro agent.
3. Foutcorrectie voor load_datasets vanuit huggingface.
4. Update van de exceptieafhandeling in syntaxisverificatie.


### 2025.05

1. Update logs voor de nieuwste versie.
2. Voorzie de evaluatiecode voor de TPC.

### 2025.04

1. Lokale data loader toegevoegd. Gebruikers kunnen nu aangepaste queries lokaal laden. Bij het specificeren van niet-standaardwaarden voor splits_name (bijv. "abc") voor "run_exp.py", zal het systeem automatisch bijbehorende bestanden laden uit evaluation/default_splits/abc.txt, waarbij het TXT-bestand de doelfilenaam van de query bevat.
2. Gedetailleerde classificatie van beperkingen. Zie de gedetailleerde documentatie bij [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. Geïntroduceerde LLM-modulo baseline
   Implementeer de LLM-modulo pipeline met een ground-truth symbolische verifier.
   Gebaseerd op methodologie uit:
   Paper: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   Codebase: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. Ondersteuning voor lokale LLM-inferentie met Qwen3-8B/4B.

## 🚀 Snel starten

### ⚙️ Installatie

1. Maak een conda-omgeving aan en installeer afhankelijkheden:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. Download de database en pak deze uit in de map "chinatravel/environment/"

Downloadlinks: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. Download de open-source LLM's (optioneel).

```bash
bash download_llm.sh
```

4. Download de tokenizers.

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ Uitvoeren

We ondersteunen deepseek (officiële API van deepseek), gpt-4o (chatgpt-4o-latest), glm4-plus, en lokale inferenties met Qwen (Qwen3-8B), llama, mistral (Mistral-7B-Instruct-v0.3), enzovoort.

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

**Opmerking**:

- De vlag `--oracle_translation` geeft toegang tot geannoteerde grondwaarheid, waaronder:

  - `hard_logic_py`: Uitvoerbare verificatie DSL-code
  - `hard_logic_nl`: De bijbehorende beschrijvingen van beperkingen
  - Voorbeeldstructuur van annotaties:

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
- De LLM-modulo methode **vereist** oracle_translation modus voor het symbolische verfijningsproces

### 📊 Evaluatie

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```

In TPC@IJCAI2025 wordt de evaluatiecode geleverd in het bestand `eval_tpc.py`. Je kunt de evaluatiecode als volgt uitvoeren:

```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 Documentatie

[Omgeving](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[Beperkingen](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ Geavanceerde Ontwikkeling

### 1. Ontwikkel Je Eigen Agent-Algoritme

Om je eigen agent-algoritme te ontwikkelen, moet je de `BaseAgent`-klasse uit `chinatravel/agent/base.py` overerven en de logica voor je algoritme toevoegen aan de `init_agent`-functie in `chinatravel/agent/load_model.py`. We bieden een leeg agentvoorbeeld genaamd `TPCAgent`.

Stappen:

- **Erf de `BaseAgent`-klasse**: Maak een nieuw Python-bestand aan in de map `chinatravel/agent` en definieer je eigen agentklasse, die overerft van `BaseAgent`.

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

- **Voeg code toe aan de functie init_agent**: Open het bestand chinatravel/agent/load_model.py en voeg ondersteuning toe voor je nieuwe agent in de functie init_agent.

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

### 2. Ontwikkel Uw Eigen Lokale LLM

Om uw eigen lokale large-language model (LLM) te ontwikkelen, moet u de AbstractLLM-klasse uit chinatravel/agent/llms.py overerven en de bijbehorende lokale LLM-inferentiecode toevoegen in llms.py. We bieden een leeg LLM-voorbeeld genaamd TPCLLM.
Stappen:

- **Erf de AbstractLLM-klasse**: Definieer uw eigen LLM-klasse in het chinatravel/agent/llms.py-bestand, waarbij u erft van AbstractLLM.

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

- **Voeg code toe aan de init_agent functie**: Open het chinatravel/agent/load_model.py bestand en voeg ondersteuning toe voor je nieuwe llm in de init_llm functie.

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. Voer uw code uit met behulp van experiment scripts

Na het voltooien van de bovenstaande ontwikkeling kunt u de experiment scripts gebruiken om uw code uit te voeren.

Voorbeeld van uitvoeren:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```

De resultaten worden opgeslagen in de map `results/YourMethodName_YourLLMName_xxx`, bijvoorbeeld `results/TPCAgent_TPCLLM`.

## ✉️ Contact

Als u problemen heeft, neem dan contact op met [Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn).

## 📌 Referentie

Als ons artikel of gerelateerde bronnen waardevol zijn voor uw onderzoek, verzoeken wij u vriendelijk om een referentie te geven.

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-12

---