<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🧠 LLM поисковый движок без прокси

Многофункциональный инструмент для поиска с LLM без использования прокси, поддерживающий парсинг содержимого URL и сканирование веб-страниц, реализованный на основе **LangGraph** и **LangGraph-MCP** для модульных цепочек агентов. Разработан для сценариев обращения LLM к внешним знаниям, поддерживает получение и парсинг страниц через **Playwright + Crawl4AI**, а также асинхронную обработку, нарезку и фильтрацию контента.

## 🚀 Журнал обновлений

- 🔥 2025-09-05: Поддержка **langgraph-mcp**
- 🔥 2025-09-03: Добавлена поддержка Docker, встроенный интеллектуальный ранжировщик, поддержка пользовательских текстовых сегментаторов и ранжировщиков

## ✨ Обзор возможностей

- 🌐 **Без необходимости в прокси**: благодаря настройке поддержки отечественных браузеров через Playwright можно выполнять веб-поиск без использования прокси.
- 🔍 **Поддержка нескольких поисковых систем**: поддерживаются Bing, Quark, Baidu, Sogou и другие популярные поисковые системы, что увеличивает разнообразие источников информации.
- 🤖 **Распознавание намерений**: система может автоматически определять, требуется ли веб-поиск или анализ URL на основе ввода пользователя.
- 🔄 **Декомпозиция запроса**: в зависимости от намерения пользователя запрос автоматически разбивается на несколько подзадач, которые выполняются последовательно, повышая релевантность и эффективность поиска.
- ⚙️ **Архитектура агента**: инкапсулированы **«web_search»** и **«link_parser»** на базе **LangGraph**.
- 🏃‍♂️ **Асинхронная обработка задач**: поддержка асинхронной и параллельной обработки задач для эффективной работы с несколькими поисковыми заданиями.
- 📝 **Оптимизация обработки контента**:

  - ✂️ **Фрагментация контента**: длинный контент веб-страниц разбивается на отдельные сегменты.

  - 🔄 **Перестановка контента**: интеллектуальная перенастройка порядка для повышения релевантности информации.

  - 🚫 **Фильтрация контента**: автоматическое удаление нерелевантного или дублирующегося контента.
- 🌐 **Многосторонняя поддержка**:
  - 🐳 **Поддержка деплоя в Docker**: запуск в один клик, быстрое развертывание серверной части.

  - 🖥️ Предоставляется FastAPI backend-интерфейс, который можно интегрировать в любую систему.

  - 🌍 Предоставляется Gradio Web UI для быстрого развертывания визуального приложения.

  - 🧩[ **Поддержка браузерного расширения**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): поддержка Edge, интеллектуальный плагин для анализа URL, позволяющий отправлять запросы на парсинг и извлечение контента прямо из браузера.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Быстрый старт

### Клонирование репозитория

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### Установка зависимостей

```
pip install -r requirements.txt
python -m playwright install
```

### Настройка переменных среды

```
# 百炼llm
OPENAI_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
OPENAI_API_KEY=sk-xxx
MODEL_NAME=qwen-plus-latest

# 百炼embedding
EMBEDDING_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
EMBEDDING_API_KEY=sk-xxx
EMBEDDING_MODEL_NAME=text-embedding-v4

# 百炼reranker
RERANK_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
RERANK_API_KEY=sk-xxx
RERANK_MODEL=gte-rerank-v2
```

### Langgraph-Agent

#### ДЕМО

```shell
python agent/demo.py
```

#### API СЕРВЕР

```shell
python agent/api_serve.py
```

```python
import requests

url = "http://localhost:8800/search"

data = {
  "question": "广州今日天气",
  "engine": "bing",
  "split": {
    "chunk_size": 512,
    "chunk_overlap": 128
  },
  "rerank": {
    "top_k": 5
  }
}

try:
    response = requests.post(
        url,
        json=data
    )

    if response.status_code == 200:
        print("✅ 请求成功！")
        print("响应内容：", response.json())
    else:
        print(f"❌ 请求失败，状态码：{response.status_code}")
        print("错误信息：", response.text)

except requests.exceptions.RequestException as e:
    print(f"⚠️ 请求异常：{str(e)}")
```

#### Gradio

```
python agent/gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

#### docker

```
docker-compose -f docker-compose-ag.yml up -d --build
```

### Langgrph-MCP

#### Запуск службы MCP

```
python mcp/websearch.py
```

#### ДЕМОНСТРАЦИЯ

```
python mcp/demo.py
```

#### API СЕРВЕР

```
python mcp/api_serve.py
```

```
import requests

url = "http://localhost:8800/search"

data = {
  "question": "广州今日天气"
}

try:
    response = requests.post(
        url,
        json=data
    )

    if response.status_code == 200:
        print("✅ 请求成功！")
        print("响应内容：", response.json())
    else:
        print(f"❌ 请求失败，状态码：{response.status_code}")
        print("错误信息：", response.text)

except requests.exceptions.RequestException as e:
    print(f"⚠️ 请求异常：{str(e)}")
```

#### docker

```
docker-compose -f docker-compose-mcp.yml up -d --build
```

### Пользовательские модули

#### Пользовательская сегментация

```
from typing import Optional, List

class YourSplitter:
    def __init__(self, text: str, chunk_size: int = 512, chunk_overlap: int = 128):
        self.text = text
        self.chunk_size = chunk_size
        self.chunk_overlap = chunk_overlap

    def split_text(self, text: Optional[str] = None) -> List:
        # TODO: implement splitting logic
        return ["your chunk"]
```

#### Пользовательская перенумерация

```
from typing import List, Union, Tuple

class YourReranker:
    async def get_reranked_documents(
        self,
        query: Union[str, List[str]],
        documents: List[str],
    ) -> Union[
        Tuple[List[str]],
        Tuple[List[int]],
    ]:
        return ["your chunk"], ["chunk index"]
```

## 🔍 Сравнение с онлайн-тестами сетевого поиска

Мы сравнили проект с некоторыми популярными онлайн API и оценили его производительность при решении сложных задач.

### 🔥 Датасет

- Датасет взят из [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA), опубликованного компанией Alibaba; содержит 680 вопросов повышенной сложности, охватывающих образование, научные конференции, игры и другие области.
- Датасет включает вопросы на китайском и английском языках.

### 🧑‍🏫 Результаты сравнения

| Поисковик/Система | ✅ Верно | ❌ Неверно | ⚠️ Частично верно |
| ----------------- | -------- | ---------- | ------------------ |
| **Вулкан Арк**    | 5.00%    | 72.21%     | 22.79%             |
| **Бай Лянь**      | 9.85%    | 62.79%     | 27.35%             |
| **Наш**           | 19.85%   | 47.94%     | 32.06%             |
## 🙏 Благодарности

Часть функционала проекта была реализована благодаря поддержке и вдохновению от следующих open-source проектов, выражаем признательность:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): фреймворк для построения модульных цепочек агентов, ускоряющий разработку сложных интеллектуальных систем.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): мощный инструмент для парсинга веб-контента, способствующий эффективному сбору и извлечению данных с сайтов.
- 🌐 [Playwright](https://github.com/microsoft/playwright): современный инструмент автоматизации браузера, поддерживающий кроссбраузерный веб-скрапинг и автоматизированное тестирование.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): используется для построения MCP с поддержкой мультицепочек.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---