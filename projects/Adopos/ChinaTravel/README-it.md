<center>
  <h1>ChinaTravel: Un benchmark reale per agenti linguistici nella pianificazione di viaggi in Cina
</h1>
</center>

Codice ufficiale per l'articolo "ChinaTravel: Un benchmark reale per agenti linguistici nella pianificazione di viaggi in Cina".

<!-- | [Pagina Web](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [Articolo](https://arxiv.org/abs/2412.13682) | [Dataset(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![Pagina Web](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![Articolo](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![Dataset(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![Competizione(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![Competizione(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![Panoramica](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 Sfida di Pianificazione Viaggi IJCAI 2025 (TPC@IJCAI)

Siamo orgogliosi di annunciare che ChinaTravel è stato selezionato come benchmark ufficiale per la **Travel Planning Challenge (TPC) @ IJCAI 2025**!

**Sito ufficiale della competizione**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

I partecipanti sono invitati a sviluppare nuovi agenti in grado di affrontare scenari reali di pianificazione viaggi sotto vincoli complessi. Questa competizione metterà in mostra approcci all'avanguardia nella ricerca sugli agenti linguistici.

## 📝 ChangeLog

### 2025.09
1. Caricata la soluzione vincente della traccia DSL TPC@IJCAI2025. Grazie a [@evergreenee](https://github.com/evergreenee) per il contributo.  


### 2025.06

1. Correzione della raccolta degli errori nel codice di valutazione del ragionamento di senso comune. 
2. Correzione della pipeline dell'agente puramente neurale
3. Correzione del caricamento dei dataset da huggingface
4. Aggiornamento della gestione delle eccezioni nella verifica della sintassi


### 2025.05

1. Aggiornamento dei log per la versione più recente.
2. Fornire il codice di valutazione per il TPC.

### 2025.04

1. Aggiunto il caricatore di dati locale. Gli utenti ora possono caricare query personalizzate localmente. Quando si specificano valori splits_name non predefiniti (ad es. "abc") per "run_exp.py", il sistema caricherà automaticamente i file corrispondenti da evaluation/default_splits/abc.txt, dove il file TXT contiene i nomi dei file delle query target.
2. Classificazione dettagliata dei vincoli. Consulta la documentazione dettagliata in [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. Introdotto il baseline LLM-modulo
   Implementazione della pipeline LLM-modulo con un verificatore simbolico di ground-truth.
   Basato sulla metodologia da:
   Articolo: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   Repository: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. Supporto per inferenza LLM locale con Qwen3-8B/4B.

## 🚀 Avvio Rapido

### ⚙️ Configurazione

1. Crea un ambiente conda e installa le dipendenze:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. Scarica il database e decomprimilo nella directory "chinatravel/environment/"

Link per il download: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. Scarica gli LLM open-source (opzionale).

```bash
bash download_llm.sh
```

4. Scarica i tokenizzatori.

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ Esecuzione

Supportiamo deepseek (API ufficiale di deepseek), gpt-4o (chatgpt-4o-latest), glm4-plus e inferenze locali con Qwen (Qwen3-8B), llama, mistral (Mistral-7B-Instruct-v0.3), ecc.

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

**Nota**:

- Il flag `--oracle_translation` abilita l'accesso alla verità annotata di riferimento, che include:

  - `hard_logic_py`: Codice DSL di verifica eseguibile
  - `hard_logic_nl`: Le corrispondenti descrizioni dei vincoli
  - Struttura di esempio dell'annotazione:

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
- Il metodo LLM-modulo **richiede** la modalità oracle_translation per il suo processo di raffinamento simbolico

### 📊 Valutazione

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```

In TPC@IJCAI2025, il codice di valutazione è fornito nel file `eval_tpc.py`. Puoi eseguire il codice di valutazione come segue:

```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 Documentazione

[Ambiente](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[Vincoli](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ Sviluppo Avanzato

### 1. Sviluppa il Tuo Algoritmo Agente

Per sviluppare il tuo algoritmo agente, devi ereditare la classe `BaseAgent` da `chinatravel/agent/base.py` e aggiungere la logica del tuo algoritmo alla funzione `init_agent` in `chinatravel/agent/load_model.py`. Forniamo un esempio di agente vuoto chiamato `TPCAgent`.

Passaggi:

- **Eredita la classe `BaseAgent`**: Crea un nuovo file Python nella directory `chinatravel/agent` e definisci la tua classe agente, ereditando da `BaseAgent`.

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

- **Aggiungi il codice alla funzione init_agent**: Apri il file chinatravel/agent/load_model.py e aggiungi il supporto per il tuo nuovo agente nella funzione init_agent.

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

### 2. Sviluppa il Tuo LLM Locale

Per sviluppare il tuo modello linguistico locale (LLM), devi ereditare la classe AbstractLLM dal file chinatravel/agent/llms.py e aggiungere il relativo codice di inferenza LLM locale in llms.py. Forniamo un esempio vuoto di LLM chiamato TPCLLM.
Passaggi:

- **Eredita la classe AbstractLLM**: Definisci la tua classe LLM nel file chinatravel/agent/llms.py, ereditando da AbstractLLM.

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

- **Aggiungi codice alla funzione init_agent**: Apri il file chinatravel/agent/load_model.py e aggiungi il supporto per il tuo nuovo llm nella funzione init_llm.

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. Esegui il tuo codice utilizzando gli script di esperimento

Dopo aver completato lo sviluppo sopra indicato, puoi utilizzare gli script di esperimento per eseguire il tuo codice.

Esempio di esecuzione:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```
I risultati verranno salvati nella directory `results/YourMethodName_YourLLMName_xxx`, ad esempio, `results/TPCAgent_TPCLLM`.

## ✉️ Contatti

Se riscontri problemi, contatta [Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn).

## 📌 Citazione

Se il nostro articolo o le risorse correlate risultano utili per la tua ricerca, ti chiediamo gentilmente di citarli.


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