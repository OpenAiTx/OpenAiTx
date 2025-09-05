<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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
# 🧠 Proxy Gerektirmeyen LLM Web Arama Motoru

Proxy gerektirmeyen çoklu arama motoru destekli bir LLM ağ bilgi alma aracı; URL içeriği çözümleme ve web sayfası tarama desteğiyle, **LangGraph** ve **LangGraph-MCP** sayesinde modüler akıllı ajan zinciri oluşturur. Büyük dil modellerinin harici bilgi çağırma senaryoları için özel olarak tasarlanmıştır, **Playwright + Crawl4AI** ile web sayfası alma ve çözümleme, eşzamanlı asenkron çalışma, içerik dilimleme ve yeniden sıralama filtreleme destekler.

## 🚀 Güncelleme Günlüğü

- 🔥 2025-09-05: **langgraph-mcp** desteği eklendi
- 🔥 2025-09-03: Docker ile dağıtım, yerleşik akıllı yeniden sıralayıcı, özelleştirilebilir metin bölücü ve yeniden sıralayıcı desteği eklendi

## ✨ Özellikler Genel Bakış

- 🌐 **Proxy gerektirmez**: Playwright ile yurtiçi tarayıcı desteği sayesinde, proxy olmadan da internet araması yapılabilir.
- 🔍 **Çoklu arama motoru desteği**: Bing, Quark, Baidu, Sogou gibi başlıca arama motorlarını destekler, bilgi kaynaklarının çeşitliliğini artırır.
- 🤖 **Niyet tanıma**: Sistem, kullanıcının girdiği içeriğe göre otomatik olarak web araması mı yoksa URL çözümleme mi yapılacağını belirler.
- 🔄 **Sorgu ayrıştırma**: Kullanıcının arama niyetine göre sorguyu otomatik olarak birden fazla alt göreve böler ve sırasıyla uygular, böylece aramanın alaka düzeyi ve verimliliği artar.
- ⚙️ **Akıllı mimari**: **LangGraph** tabanlı **"web_search"** ve **"link_parser"** ile kapsüllenen mimari.
- 🏃‍♂️ **Asenkron ve eşzamanlı görev işleme**: Asenkron ve eşzamanlı görev işleme desteği ile birden fazla arama görevi verimli şekilde yönetilir.
- 📝 **İçerik işleme optimizasyonu**:

  - ✂️ **İçerik dilimleme**: Web sayfasındaki uzun içerikler parçalara bölünür.

  - 🔄 **İçerik yeniden sıralama**: Akıllı sıralama ile bilgi alaka düzeyi artırılır.

  - 🚫 **İçerik filtreleme**: Alakasız veya yinelenen içerik otomatik olarak çıkarılır.
- 🌐 **Çoklu platform desteği**:
  - 🐳 **Docker ile dağıtım desteği**: Tek tuşla başlatma, hızlı arka uç servis kurulumu.

  - 🖥️ FastAPI arka uç arayüzü ile herhangi bir sisteme entegre edilebilir.

  - 🌍 Gradio Web UI desteğiyle hızlıca görsel uygulama haline getirilebilir.

  - 🧩[ **Tarayıcı eklentisi desteği**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Edge desteği ile akıllı URL çözümleme eklentisi, doğrudan tarayıcıda web sayfası çözümleme ve içerik çıkarımı isteği başlatılır.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Hızlı Başlangıç

### Depoyu Klonlayın

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### Bağımlılıkların Kurulumu

```
pip install -r requirements.txt
python -m playwright install
```

### Ortam Değişkeni Yapılandırması

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

#### DEMO

```shell
python agent/demo.py
```

#### API SUNUCUSU

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

#### MCP Hizmetini Başlatma

```
python mcp/websearch.py
```

#### DEMO

```
python mcp/demo.py
```

#### API SUNUCU

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

### Özelleştirilmiş Modüller

#### Özelleştirilmiş Bölümlendirme

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

#### Özelleştirilmiş Yeniden Sıralama

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

## 🔍 Çevrimiçi Ağ Arama Testi ile Karşılaştırma

Projeyi bazı popüler çevrimiçi API'lerle karşılaştırarak, karmaşık sorunlar karşısındaki performansını değerlendirdik.

### 🔥 Veri Seti

- Veri seti, Ali tarafından yayımlanan [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) kaynağından alınmıştır; eğitim, akademik konferanslar, oyun gibi birçok alanı kapsayan 680 zorlu sorudan oluşmaktadır.
- Veri seti hem Çince hem de İngilizce soruları içermektedir.

### 🧑‍🏫 Karşılaştırma Sonuçları

| Arama Motoru/Sistem | ✅ Doğru   | ❌ Yanlış   | ⚠️ Kısmen Doğru        |
| ------------------- | ----------| -----------| ---------------------- |
| **Volcano Ark**     | %5.00     | %72.21     | %22.79                 |
| **Bailian**         | %9.85     | %62.79     | %27.35                 |
| **Bizim**           | %19.85    | %47.94     | %32.06                 |
## 🙏 Teşekkür

Projenin bazı işlevleri aşağıdaki açık kaynak projelerinin desteği ve ilhamı sayesinde geliştirilmiştir, teşekkürlerimizi sunarız:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): Modüler akıllı ajan zinciri çerçevesi oluşturmak için kullanılır; karmaşık ajan sistemlerinin hızlı kurulmasına yardımcı olur.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): Güçlü web içerik analiz aracı, verimli web kazıma ve veri çıkarımına olanak sağlar.
- 🌐 [Playwright](https://github.com/microsoft/playwright): Modern tarayıcı otomasyon aracı; tarayıcılar arası web kazıma ve otomatik test desteği sunar.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): Çoklu zincir işlem MCP yapısı için kullanılır.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---