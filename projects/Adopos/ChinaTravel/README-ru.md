<center>
  <h1>ChinaTravel: Реальный эталон для языковых агентов в планировании путешествий по Китаю
</h1>
</center>

Официальная база кода для статьи "ChinaTravel: Реальный эталон для языковых агентов в планировании путешествий по Китаю".

<!-- | [Веб-страница](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [Статья](https://arxiv.org/abs/2412.13682) | [Датасет(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![Веб-страница](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![Статья](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![Датасет(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![Соревнование(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![Соревнование(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![Обзор](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 IJCAI 2025 Конкурс по планированию путешествий (TPC@IJCAI)

Мы рады сообщить, что ChinaTravel был выбран официальным эталоном для **Travel Planning Challenge (TPC) @ IJCAI 2025**!

**Официальный сайт соревнования**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

Приглашаем участников разрабатывать новые агенты, способные решать реальные задачи планирования путешествий с учетом сложных ограничений. Это соревнование продемонстрирует современные методы в области исследований языковых агентов.

## 📝 Список изменений

### 2025.09
1. Загружено решение-победитель TPC@IJCAI2025 DSL трека. Благодарим [@evergreenee](https://github.com/evergreenee) за вклад.  


### 2025.06

1. Исправлена ошибка сбора в коде оценки здравого смысла. 
2. Исправлен конвейер чисто нейросетевого агента
3. Исправлена загрузка датасетов с huggingface
4. Обновлена обработка исключений при проверке синтаксиса


### 2025.05

1. Журнал обновлений для последней версии.
2. Предоставлен код оценки для TPC.

### 2025.04

1. Добавлен локальный загрузчик данных. Теперь пользователи могут загружать пользовательские запросы локально. При указании нестандартных значений splits_name (например, "abc") для "run_exp.py" система автоматически загрузит соответствующие файлы из evaluation/default_splits/abc.txt, где TXT-файл содержит имена файлов целевых запросов.
2. Подробная классификация ограничений. См. подробную документацию в [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. Введен базовый метод LLM-modulo
   Реализован конвейер LLM-modulo с эталонным символическим верификатором.
   Основано на методологии из:
   Статья: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   Репозиторий: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. Поддержка локального вывода LLM с Qwen3-8B/4B.

## 🚀 Быстрый старт

### ⚙️ Установка

1. Создайте окружение conda и установите зависимости:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. Скачайте базу данных и распакуйте её в каталог "chinatravel/environment/"

Ссылки для скачивания: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. Скачайте открытые LLM (опционально).

```bash
bash download_llm.sh
```

4. Загрузите токенизаторы.

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ Запуск

Мы поддерживаем deepseek (официальный API от deepseek), gpt-4o (chatgpt-4o-latest), glm4-plus, а также локальные выводы с Qwen (Qwen3-8B), llama, mistral (Mistral-7B-Instruct-v0.3) и другими.

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

**Примечание**:

- Флаг `--oracle_translation` позволяет получить доступ к аннотированной эталонной информации, включая:

  - `hard_logic_py`: Исполняемый проверочный DSL-код
  - `hard_logic_nl`: Соответствующие описания ограничений
  - Пример структуры аннотации:

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
- Метод LLM-modulo **требует** режима oracle_translation для процесса символьного уточнения

### 📊 Оценка

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```

В TPC@IJCAI2025 код для оценки предоставлен в файле `eval_tpc.py`. Вы можете запустить код оценки следующим образом:

```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 Документация

[Окружение](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[Ограничения](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ Продвинутая разработка

### 1. Разработка собственного алгоритма агента

Чтобы разработать собственный алгоритм агента, необходимо наследовать класс `BaseAgent` из файла `chinatravel/agent/base.py` и добавить логику вашего алгоритма в функцию `init_agent` в `chinatravel/agent/load_model.py`. Мы предоставляем пример пустого агента под названием `TPCAgent`.

Шаги:

- **Наследуйте класс `BaseAgent`**: Создайте новый Python-файл в директории `chinatravel/agent` и определите свой класс агента, унаследованный от `BaseAgent`.

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
- **Добавьте код в функцию init_agent**: Откройте файл chinatravel/agent/load_model.py и добавьте поддержку вашего нового агента в функцию init_agent.


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

### 2. Разработка собственного локального LLM

Чтобы разработать собственную локальную большую языковую модель (LLM), необходимо наследовать класс AbstractLLM из chinatravel/agent/llms.py и добавить соответствующий код локального вывода LLM в llms.py. Мы предоставляем пустой пример LLM под названием TPCLLM.
Шаги:

- **Наследуйте класс AbstractLLM**: Определите свой собственный класс LLM в файле chinatravel/agent/llms.py, наследуя от AbstractLLM.

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

- **Добавьте код в функцию init_agent**: Откройте файл chinatravel/agent/load_model.py и добавьте поддержку вашей новой llm в функцию init_llm.

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. Запустите ваш код с помощью экспериментальных скриптов

После завершения вышеуказанной разработки вы можете использовать экспериментальные скрипты для запуска вашего кода.

Пример запуска:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```

Результаты будут сохранены в директории `results/YourMethodName_YourLLMName_xxx`, например, `results/TPCAgent_TPCLLM`.

## ✉️ Контакты

Если у вас возникнут вопросы, пожалуйста, свяжитесь с [Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn).

## 📌 Цитирование

Если наша статья или связанные ресурсы оказались полезны для вашего исследования, мы будем признательны за цитирование.

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