## MCP-Zero: Активное обнаружение инструментов для автономных LLM-агентов

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


Спасибо за ваш интерес к MCP-Zero! 🤗

Мы открыли исходный код, используемый в статье. Мы продолжим обновлять нашу работу, исследовать её применение в промышленности и расширять этот проект.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> Использование MCP-Zero для проактивного построения цепочек инструментов для "Приготовления отличного блюда"</p>
</div>


### Метод: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # эксперименты: APIBank
├── experiment_mcptools.py      # эксперименты: mcp_tools (needle test)
├── matcher.py                  # код для сопоставления по схожести
├── prompt_guide/               # подсказки для нашего метода
├── reformatter.py              # форматтер json для описания инструмента
├── sampler.py                  # семплер для выбора целевого инструмента
├── test_cases.jsonl            # тестовые случаи для сопоставителя
├── test_matcher.py             # юнит-тест для сопоставителя
└── utils.py                    # утилиты: grid_search
```

Мы опубликовали исходный код, описанный в статье. Код реализует функции поиска и достигает конкретных результатов в экспериментах.

В дальнейшей работе мы намерены применять MCP-Zero в промышленности, поэтому потребуется задействовать и другие модули, такие как динамическое развертывание MCP-серверов, развертывание среды для теста GAIA и др. Мы будем продолжать совершенствовать нашу работу. Спасибо всем за интерес к этому проекту. Поставьте звёздочку🌟, чтобы я знал, что вы следите за обновлениями :D



### Датасет: MCP-tools

- **Google Drive**: [Ссылка для скачивания](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Ссылка на Huggingface**: Скоро будет
- **Поместите файл сюда**: `./MCP-tools/mcp_tools_with_embedding.json`


**Введение**: Датасет, содержащий все отфильтрованные инструменты (308 серверов и 2,797 инструментов в общей сложности) из официального репозитория MCP.

**Структура данных**:
```
{
  "server_name": string, // Имя сервера MCP, извлеченное или определённое из README
  "server_summary": string, // Краткое описание назначения и возможностей сервера, основанное на всех релевантных частях README.
  "server_description": string, // Описание из метаданных. 
  "description_embedding": float[3072], // Векторное представление описания сервера из text-embedding-3-large
  "summary_embedding": float[3072], // Векторное представление краткого описания из text-embedding-3-large
  "tools": [
    {
      "name": string, // Имя функции/инструмента
      "description": string, // Краткое описание того, что делает инструмент
      "description_embedding": float[3072], // Векторное представление описания инструмента из text-embedding-3-large
      "parameter": { // Словарь входных параметров, включается, если явно определён
        "param1": "(type) описание1",
        "param2": "(Optional, type) описание2"
      }
    }
  ]
}
```

**Построить датасет самостоятельно**: Если вы хотите создать свой собственный датасет для MCP-серверов, воспользуйтесь кодом из папки `MCP-tools/build_data`.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # код для извлечения структурированных данных из файла ReadMe сервера MCP
│   ├── run_vllm.sh                 # развертывание модели Qwen2.5-72B-Instruct с помощью VLLM
│   └── server_summary.prompt       # промпт для извлечения датасета
└── download_data.md
```


### Цитирование

> Цитирование делает меня счастливым.
> 
>   --Шекспир
>   ~~(просто ради удовольствия :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang and Zheng, Xiawu and Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
```
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---