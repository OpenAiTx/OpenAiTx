<center>
  <h1>ChinaTravel: Ein praxisnaher Benchmark für Sprachagenten in der chinesischen Reiseplanung
</h1>
</center>

Offizieller Codebestand für das Paper "ChinaTravel: Ein praxisnaher Benchmark für Sprachagenten in der chinesischen Reiseplanung".

<!-- | [Webseite](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [Paper](https://arxiv.org/abs/2412.13682) | [Datensatz(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![Webseite](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![Paper](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![Datensatz(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![Wettbewerb(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![Wettbewerb(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![Übersicht](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 IJCAI 2025 Reiseplanungs-Challenge (TPC@IJCAI)

Wir freuen uns bekannt zu geben, dass ChinaTravel als offizieller Benchmark für die **Travel Planning Challenge (TPC) @ IJCAI 2025** ausgewählt wurde!

**Offizielle Wettbewerbswebseite**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

Teilnehmer sind eingeladen, neuartige Agenten zu entwickeln, die reale Reiseplanungsszenarien unter komplexen Bedingungen bewältigen können. Dieser Wettbewerb präsentiert fortschrittliche Ansätze in der Forschung zu Sprachagenten.

## 📝 Änderungsprotokoll

### 2025.09
1. Hochladen der Siegerlösung des TPC@IJCAI2025 DSL-Tracks. Vielen Dank an [@evergreenee](https://github.com/evergreenee) für die Beiträge.  


### 2025.06

1. Fehlerbehebung bei der Sammlung im Bewertungscode für Commonsense. 
2. Fehlerbehebung in der Pipeline des reinen Neuro-Agenten
3. Fehlerbehebung beim Laden von Datensätzen von Huggingface
4. Aktualisierung der Ausnahmebehandlung bei der Syntaxüberprüfung


### 2025.05

1. Protokollieren Sie die Aktualisierungen für die neueste Version.
2. Stellen Sie den Bewertungscode für das TPC bereit.

### 2025.04

1. Lokaler Datenlader hinzugefügt. Benutzer können nun benutzerdefinierte Abfragen lokal laden. Bei Angabe von nicht standardmäßigen splits_name-Werten (z. B. "abc") für "run_exp.py" lädt das System automatisch entsprechende Dateien aus evaluation/default_splits/abc.txt, wobei die TXT-Datei die Dateinamen der Zielabfragen enthält.
2. Detaillierte Klassifizierung von Einschränkungen. Siehe ausführliche Dokumentation unter [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. LLM-Modulo-Baseline eingeführt
   Implementierung der LLM-Modulo-Pipeline mit einem symbolischen Ground-Truth-Verifizierer.
   Basierend auf der Methodik aus:
   Paper: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   Codebasis: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. Unterstützung für lokale LLM-Inferenz mit Qwen3-8B/4B.

## 🚀 Schnellstart

### ⚙️ Einrichtung

1. Erstellen Sie eine Conda-Umgebung und installieren Sie die Abhängigkeiten:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. Laden Sie die Datenbank herunter und entpacken Sie sie in das Verzeichnis "chinatravel/environment/"

Download-Links: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. Laden Sie die Open-Source-LLMs herunter (optional).

```bash
bash download_llm.sh
```

4. Laden Sie die Tokenizer herunter.

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ Ausführung

Wir unterstützen Deepseek (offizielle API von Deepseek), GPT-4o (chatgpt-4o-latest), GLM4-Plus und lokale Inferenz mit Qwen (Qwen3-8B), Llama, Mistral (Mistral-7B-Instruct-v0.3) usw.

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

**Hinweis**:

- Das Flag `--oracle_translation` ermöglicht den Zugriff auf annotierte Ground-Truth-Daten, einschließlich:

  - `hard_logic_py`: Ausführbarer Verifizierungs-DSL-Code
  - `hard_logic_nl`: Die entsprechenden Beschreibungen der Einschränkungen
  - Beispielstruktur der Annotation:

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
- Die LLM-Modulo-Methode **erfordert** den Oracle_Translation-Modus für ihren symbolischen Verfeinerungsprozess

### 📊 Bewertung

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```

Im TPC@IJCAI2025 wird der Bewertungscode in der Datei `eval_tpc.py` bereitgestellt. Sie können den Bewertungscode wie folgt ausführen:

```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 Dokumentation

[Umgebung](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[Einschränkungen](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ Erweiterte Entwicklung

### 1. Entwickeln Sie Ihren eigenen Agenten-Algorithmus

Um Ihren eigenen Agenten-Algorithmus zu entwickeln, müssen Sie die Klasse `BaseAgent` aus `chinatravel/agent/base.py` erben und die Logik für Ihren Algorithmus in die Funktion `init_agent` in `chinatravel/agent/load_model.py` einfügen. Wir stellen ein Beispiel für einen leeren Agenten namens `TPCAgent` bereit.

Schritte:

- **Erben Sie die Klasse `BaseAgent`**: Erstellen Sie eine neue Python-Datei im Verzeichnis `chinatravel/agent` und definieren Sie Ihre eigene Agentenklasse, indem Sie von `BaseAgent` erben.

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

- **Fügen Sie Code zur Funktion init_agent hinzu**: Öffnen Sie die Datei chinatravel/agent/load_model.py und fügen Sie Unterstützung für Ihren neuen Agenten in der Funktion init_agent hinzu.

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

### 2. Entwickeln Sie Ihr eigenes lokales LLM

Um Ihr eigenes lokales Large Language Model (LLM) zu entwickeln, müssen Sie die AbstractLLM-Klasse aus chinatravel/agent/llms.py erben und den entsprechenden lokalen LLM-Inferenzcode in llms.py hinzufügen. Wir stellen ein leeres LLM-Beispiel namens TPCLLM bereit.
Schritte:

- **Erben Sie die AbstractLLM-Klasse**: Definieren Sie Ihre eigene LLM-Klasse in der Datei chinatravel/agent/llms.py, indem Sie von AbstractLLM erben.

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

- **Fügen Sie Code zur Funktion init_agent hinzu**: Öffnen Sie die Datei chinatravel/agent/load_model.py und fügen Sie Unterstützung für Ihr neues LLM in der Funktion init_llm hinzu.

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. Führen Sie Ihren Code mit Experiment-Skripten aus

Nach Abschluss der oben genannten Entwicklung können Sie die Experiment-Skripte verwenden, um Ihren Code auszuführen.

Beispiel für die Ausführung:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```

Die Ergebnisse werden im Verzeichnis `results/YourMethodName_YourLLMName_xxx` gespeichert, z. B. `results/TPCAgent_TPCLLM`.

## ✉️ Kontakt

Bei Problemen wenden Sie sich bitte an [Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn).

## 📌 Zitation

Wenn unsere Arbeit oder verwandte Ressourcen für Ihre Forschung wertvoll sind, bitten wir um eine entsprechende Zitation.

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-11

---