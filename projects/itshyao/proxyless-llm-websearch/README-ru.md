
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

# 🧠 LLM-веб-поисковик без необходимости прокси

Многофункциональный LLM-инструмент для веб-поиска без прокси, поддерживающий парсинг контента по URL и веб-скрапинг, реализующий модульные цепочки агентов с помощью LangGraph. Разработан для сценариев вызова внешних знаний большими языковыми моделями. Поддерживает получение и разбор веб-страниц с помощью **Playwright + Crawl4AI**, асинхронную обработку, сегментирование и перестановку контента с фильтрацией.

## ✨ Обзор возможностей

- 🌐 **Без прокси**: с помощью Playwright можно настроить браузер для работы в Китае, обеспечивая веб-поиск без прокси.
- 🔍 **Много поисковых систем**: поддержка Bing, Quark, Baidu, Sogou и других популярных поисковых систем, расширяя разнообразие источников информации.
- 🤖 **Распознавание намерений**: система автоматически определяет по пользовательскому вводу, требуется ли веб-поиск или парсинг URL.
- 🔄 **Декомпозиция запроса**: согласно поисковому намерению пользователя автоматически разбивает запрос на несколько подзадач и выполняет их последовательно, повышая релевантность и эффективность поиска.
- ⚙️ **Архитектура агентов**: инкапсулированные на **LangGraph** агенты **«web_search»** и **«link_parser»**.
- 🏃‍♂️ **Асинхронная обработка задач**: поддержка асинхронной обработки, что позволяет эффективно выполнять несколько поисковых задач.
- 📝 **Оптимизация обработки контента**:

  - ✂️ **Сегментирование**: разбивка длинного содержимого страниц на отдельные фрагменты.

  - 🔄 **Перестановка контента**: интеллектуальная сортировка для повышения релевантности информации.

  - 🚫 **Фильтрация**: автоматическое удаление нерелевантного или дублирующегося контента.
- 🌐 **Кроссплатформенность**:

  - 🖥️ FastAPI-бэкенд API, который можно интегрировать в любые системы.

  - 🌍 Gradio Web UI для быстрой визуализации и развертывания приложения.
  
  - 🧩[ **Поддержка браузерных расширений**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): поддержка Edge, интеллектуальный парсер URL, позволяющий напрямую отправлять запросы на разбор и извлечение контента в браузере.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Быстрый старт

### 1. Клонирование репозитория

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. Установка зависимостей

```
pip install -r requirements.txt
python -m playwright install
```

### 3. Быстрый старт

#### Настройка переменных среды

```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```

#### демонстрация

```python
'''
python demo.py
'''

from pools import BrowserPool, CrawlerPool
from agent import ToolsGraph
import asyncio

async def main():
    browser_pool = BrowserPool(pool_size=1)
    crawler_pool = CrawlerPool(pool_size=1)
    
    graph = ToolsGraph(browser_pool, crawler_pool, engine="bing")

    await browser_pool._create_browser_instance(headless=True)
    await crawler_pool._get_instance()

    result = await graph.run("广州今日天气")

    await browser_pool.cleanup()
    await crawler_pool.cleanup()

    print(result)

if __name__ == "__main__":
    asyncio.run(main())
```

#### Бэкенд API

```python
'''
python api_serve.py
'''
import requests

url = "http://localhost:8000/search"

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

#### gradio_demo

```
python gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

## 🔍 Сравнение с онлайн-тестированием веб-поиска

Мы сравнили проект с некоторыми основными онлайн API, чтобы оценить его эффективность при решении сложных задач.

### 🔥 Датасет

- Датасет взят из опубликованного Alibaba [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA), включает 680 задач повышенной сложности, охватывающих образование, научные конференции, игры и другие области.
- Датасет содержит вопросы на китайском и английском языках.

### 🧑‍🏫 Результаты сравнения

| Поисковик/Система | ✅ Correct | ❌ Incorrect | ⚠️ Partially Correct |
| ----------------- | --------- | ----------- | ------------------- |
| **Вулкан Арк**    | 5.00%     | 72.21%      | 22.79%              |
| **БайЛянь**       | 9.85%     | 62.79%      | 27.35%              |
| **Our** | 19.85%    | 47.94%      | 32.06%              |

## 🙏 Благодарности

Часть функциональности проекта реализована благодаря поддержке и вдохновению следующих open-source проектов, выражаем благодарность:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): для построения модульной цепочки интеллектуальных агентов.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): мощный инструмент для парсинга веб-контента.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---