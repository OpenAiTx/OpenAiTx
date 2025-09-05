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
# 🧠 LLM-поисковый движок без прокси

Много поисковый инструмент для LLM без необходимости прокси, поддерживающий парсинг содержимого URL и веб-сканирование, реализованный на основе **LangGraph** и **LangGraph-MCP** для модульной цепочки агентов. Предназначен для сценариев вызова внешних знаний большими языковыми моделями, поддерживает получение и парсинг веб-страниц с помощью **Playwright + Crawl4AI**, асинхронную обработку, фрагментацию содержимого и фильтрацию с переупорядочиванием.

## 🚀 Журнал обновлений

- 🔥 2025-09-05: добавлена поддержка **langgraph-mcp**
- 🔥 2025-09-03: добавлены деплой через Docker, встроенный интеллектуальный переупорядочиватель, поддержка пользовательских разделителей и переупорядочивателей текста

## ✨ Краткий обзор возможностей

- 🌐 **Без необходимости в прокси**: через настройку Playwright поддерживается работа с отечественными браузерами, поиск в сети возможен без использования прокси.
- 🔍 **Поддержка нескольких поисковых систем**: поддерживаются Bing, Quark, Baidu, Sogou и другие основные поисковые системы для расширения разнообразия источников информации.
- 🤖 **Распознавание намерений**: система автоматически определяет по введённому пользователем тексту, нужно ли выполнять поиск в сети или анализировать URL.
- 🔄 **Декомпозиция запроса**: в зависимости от поискового намерения пользователя запрос автоматически разбивается на несколько подзадач, которые выполняются последовательно для повышения релевантности и эффективности поиска.
- ⚙️ **Архитектура агента**: на базе **LangGraph** реализованы агенты **«web_search»** и **«link_parser»**.
- 🏃‍♂️ **Асинхронная обработка задач**: поддерживается асинхронная параллельная обработка задач, что позволяет эффективно выполнять несколько поисковых запросов.
- 📝 **Оптимизация обработки контента**:

  - ✂️ **Фрагментация контента**: длинный контент веб-страниц разбивается на отдельные фрагменты.

  - 🔄 **Перестановка контента**: интеллектуальная перестановка для повышения релевантности информации.

  - 🚫 **Фильтрация контента**: автоматическое удаление нерелевантного или повторяющегося контента.
- 🌐 **Мультиплатформенная поддержка**:
  - 🐳 **Поддержка деплоя через Docker**: запуск в один клик, быстрая сборка серверных сервисов.

  - 🖥️ Предоставляется backend-интерфейс FastAPI, который можно интегрировать в любую систему.

  - 🌍 Предоставляется Gradio Web UI, что позволяет быстро развернуть визуальное приложение.

  - 🧩[ **Поддержка браузерных расширений**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): поддержка Edge, интеллектуальное расширение для анализа URL, возможность отправки запросов на парсинг и извлечение контента прямо из браузера.


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

#### API SERVE

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

## 🔍 Сравнение с онлайн-тестами поиска в сети

Мы сравнили наш проект с некоторыми популярными онлайн API, чтобы оценить их работу при решении сложных задач.

### 🔥 Датасет

- Датасет предоставлен компанией Alibaba: [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA), содержит 680 вопросов повышенной сложности, охватывающих образование, научные конференции, игры и другие области.
- Датасет включает вопросы на китайском и английском языках.

### 🧑‍🏫 Результаты сравнения

| Поисковая система/Сервис | ✅ Верно   | ❌ Неверно   | ⚠️ Частично верно     |
| ----------------------- | --------- | ----------- | --------------------- |
| **Вулкан Арк**          | 5.00%     | 72.21%      | 22.79%                |
| **Байлянь**             | 9.85%     | 62.79%      | 27.35%                |
| **Наш**                 | 19.85%    | 47.94%      | 32.06%                |
## 🙏 Благодарности

Часть функциональности проекта реализована благодаря поддержке и вдохновению следующих open-source решений, выражаем благодарность:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): модульная фреймворк для построения цепочек интеллектуальных агентов, способствует быстрой разработке сложных систем.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): мощный инструмент для анализа веб-контента, помогает эффективно собирать и извлекать данные из веб-страниц.
- 🌐 [Playwright](https://github.com/microsoft/playwright): современный инструмент для автоматизации браузера, поддерживает кроссбраузерный веб-скрапинг и автоматизацию тестирования.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): для построения MCP с поддержкой мультицепочных обработок.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---