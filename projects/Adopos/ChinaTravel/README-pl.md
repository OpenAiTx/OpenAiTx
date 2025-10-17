<center>
  <h1>ChinaTravel: Rzeczywisty benchmark dla agentów językowych w planowaniu podróży po Chinach
</h1>
</center>

Oficjalna baza kodu do artykułu "ChinaTravel: Rzeczywisty benchmark dla agentów językowych w planowaniu podróży po Chinach".

<!-- | [Strona internetowa](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [Artykuł](https://arxiv.org/abs/2412.13682) | [Zbiór danych (Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![Strona internetowa](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![Artykuł](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![Zbiór danych (Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![Konkurs (TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![Konkurs (TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![Przegląd](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 IJCAI 2025 Travel Planning Challenge (TPC@IJCAI)

Z dumą ogłaszamy, że ChinaTravel został wybrany jako oficjalny benchmark dla **Travel Planning Challenge (TPC) @ IJCAI 2025**!

**Oficjalna strona konkursu**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

Uczestnicy są zaproszeni do tworzenia nowych agentów, którzy sprostają rzeczywistym scenariuszom planowania podróży pod złożonymi ograniczeniami. Ten konkurs zaprezentuje najnowocześniejsze podejścia w badaniach nad agentami językowymi.

## 📝 ChangeLog

### 2025.09
1. Opublikowano zwycięskie rozwiązanie dla ścieżki DSL w TPC@IJCAI2025. Dziękujemy [@evergreenee](https://github.com/evergreenee) za ich wkład.  


### 2025.06

1. Naprawiono zbieranie błędów w kodzie oceny wiedzy zdroworozsądkowej. 
2. Naprawiono pipeline czysto-neuro agentów
3. Naprawiono ładowanie zbiorów danych z huggingface
4. Zaktualizowano obsługę wyjątków w weryfikacji składni


### 2025.05

1. Zaktualizowano logi dla najnowszej wersji.
2. Udostępniono kod ewaluacyjny dla TPC.

### 2025.04

1. Dodano lokalny loader danych. Użytkownicy mogą teraz lokalnie ładować własne zapytania. Przy określeniu niestandardowych wartości splits_name (np. "abc") dla "run_exp.py", system automatycznie załaduje odpowiednie pliki z evaluation/default_splits/abc.txt, gdzie plik TXT zawiera nazwy plików docelowych zapytań.
2. Szczegółowa klasyfikacja ograniczeń. Zobacz szczegółową dokumentację w [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. Wprowadzono bazowy model LLM-modulo
   Implementacja pipeline'u LLM-modulo z weryfikatorem symbolicznym ground-truth.
   Na podstawie metodologii z:
   Artykuł: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   Repozytorium: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. Wsparcie dla lokalnej inferencji LLM z Qwen3-8B/4B.

## 🚀 Szybki Start

### ⚙️ Instalacja

1. Utwórz środowisko conda i zainstaluj zależności:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. Pobierz bazę danych i rozpakuj ją do katalogu "chinatravel/environment/"

Linki do pobrania: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. Pobierz otwarte modele LLM (opcjonalnie).

```bash
bash download_llm.sh
```

4. Pobierz tokenizery.

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ Uruchamianie

Obsługujemy deepseek (oficjalne API od deepseek), gpt-4o (chatgpt-4o-latest), glm4-plus oraz lokalne inferencje z Qwen (Qwen3-8B), llama, mistral (Mistral-7B-Instruct-v0.3) itd.

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

**Uwaga**:

- Flaga `--oracle_translation` umożliwia dostęp do oznaczonej prawdziwej wartości, w tym:

  - `hard_logic_py`: Wykonywalny kod weryfikujący w DSL
  - `hard_logic_nl`: Odpowiednie opisy ograniczeń
  - Przykładowa struktura adnotacji:

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
- Metoda LLM-modulo **wymaga** trybu oracle_translation do procesu symbolicznej rafinacji

### 📊 Ewaluacja

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```

W TPC@IJCAI2025 kod oceny znajduje się w pliku `eval_tpc.py`. Kod oceny można uruchomić w następujący sposób:

```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 Dokumentacja

[Środowisko](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[Ograniczenia](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ Zaawansowany Rozwój

### 1. Opracuj Własny Algorytm Agenta

Aby opracować własny algorytm agenta, należy dziedziczyć klasę `BaseAgent` z pliku `chinatravel/agent/base.py` i dodać logikę swojego algorytmu do funkcji `init_agent` w pliku `chinatravel/agent/load_model.py`. Udostępniamy przykładowego pustego agenta o nazwie `TPCAgent`.

Kroki:

- **Dziedzicz klasę `BaseAgent`**: Utwórz nowy plik Pythona w katalogu `chinatravel/agent` i zdefiniuj własną klasę agenta, dziedziczącą po `BaseAgent`.

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

- **Dodaj kod do funkcji init_agent**: Otwórz plik chinatravel/agent/load_model.py i dodaj obsługę swojego nowego agenta w funkcji init_agent.

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

### 2. Opracuj własny lokalny LLM

Aby opracować własny lokalny model językowy (LLM), musisz odziedziczyć klasę AbstractLLM z chinatravel/agent/llms.py i dodać odpowiedni kod wnioskowania lokalnego LLM w pliku llms.py. Udostępniamy pusty przykład LLM o nazwie TPCLLM.
Kroki:

- **Odziedzicz klasę AbstractLLM**: Zdefiniuj własną klasę LLM w pliku chinatravel/agent/llms.py, dziedzicząc po AbstractLLM.

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

- **Dodaj kod do funkcji init_agent**: Otwórz plik chinatravel/agent/load_model.py i dodaj obsługę swojego nowego llm w funkcji init_llm.

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. Uruchom swój kod za pomocą skryptów eksperymentalnych

Po ukończeniu powyższego etapu rozwoju możesz użyć skryptów eksperymentalnych do uruchomienia swojego kodu.

Przykład uruchomienia:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```

Wyniki zostaną zapisane w katalogu `results/YourMethodName_YourLLMName_xxx`, np. `results/TPCAgent_TPCLLM`.

## ✉️ Kontakt

W przypadku jakichkolwiek problemów prosimy o kontakt z [Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn).

## 📌 Cytowanie

Jeśli nasza praca lub powiązane zasoby okażą się wartościowe dla Twoich badań, prosimy o cytowanie.

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