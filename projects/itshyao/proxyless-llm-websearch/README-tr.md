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

# 🧠 Proxy Olmadan LLM Web Arama Motoru

Proxy gerektirmeyen çoklu arama motoru destekli bir LLM web bilgi erişim aracı; URL içerik analizi ve web sayfası taraması ile birlikte **LangGraph** ve **LangGraph-MCP** entegrasyonu sayesinde modüler akıllı ajan zinciri oluşturur. Büyük dil modellerinin harici bilgiye erişim senaryoları için özel olarak tasarlanmıştır; **Playwright + Crawl4AI** ile web alma ve analiz, asenkron eşzamanlılık, içerik dilimleme ve yeniden sıralama filtreleme desteği sunar.

## 🚀 Güncelleme Günlüğü

- 🔥 2025-09-05: **langgraph-mcp** desteği eklendi
- 🔥 2025-09-03: Docker ile dağıtım, dahili akıllı yeniden sıralama aracı, özel metin bölme ve sıralama desteği eklendi

## ✨ Özellikler Genel Bakış

- 🌐 **Proxy Gerektirmez**: Playwright ile yapılandırılmış yerli tarayıcı desteği sayesinde, proxy olmadan da web araması yapılabilir.
- 🔍 **Çoklu Arama Motoru Desteği**: Bing, Quark, Baidu, Sogou gibi popüler arama motorlarını destekleyerek bilgi kaynaklarının çeşitliliğini artırır.
- 🤖 **Niyet Tanıma**: Sistem, kullanıcının girdiği içeriğe göre otomatik olarak web araması mı yoksa URL çözümlemesi mi yapılacağını belirler.
- 🔄 **Sorgu Parçalama**: Kullanıcının arama niyetine göre sorguyu otomatik olarak birden fazla alt göreve böler ve sırayla uygular; böylece arama alaka düzeyi ve verimliliği artar.
- ⚙️ **Akıllı Sistem Mimari**: **LangGraph** tabanlı **"web_search"** ve **"link_parser"** ile paketlenmiştir.
- 🏃‍♂️ **Asenkron Eşzamanlı Görev İşleme**: Asenkron ve eşzamanlı görev işleme desteğiyle birden fazla arama görevi verimli şekilde yürütülür.
- 📝 **İçerik İşleme Optimizasyonu**:

  - ✂️ **İçerik Dilimleme**: Web sayfasındaki uzun içerikler parçalara ayrılır.

  - 🔄 **İçerik Yeniden Sıralama**: Akıllı şekilde yeniden sıralayarak bilgi alaka düzeyini artırır.

  - 🚫 **İçerik Filtreleme**: Alakasız veya yinelenen içerikler otomatik olarak çıkarılır.
- 🌐 **Çoklu Platform Desteği**:
  - 🐳 **Docker Desteği**: Tek tıkla başlatma, hızlı arka uç servis kurulumu.

  - 🖥️ FastAPI arka uç arayüzü sunar, herhangi bir sisteme entegre edilebilir.

  - 🌍 Gradio Web UI ile hızlıca görsel uygulama olarak konuşlandırılabilir.

  - 🧩[ **Tarayıcı Eklentisi Desteği**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Edge desteği, akıllı URL çözümleme eklentisiyle tarayıcıda doğrudan web sayfası çözümleme ve içerik çekme isteği gönderebilme.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Hızlı Başlangıç

### Depoyu Klonlama

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

#### API SUNUCUSU

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

Projeyi bazı popüler çevrimiçi API'lerle karşılaştırarak, karmaşık sorulardaki performansını değerlendirdik.

### 🔥 Veri Seti

- Veri seti, Alibaba'nın yayınladığı [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) kaynaklıdır; eğitim, akademik konferanslar, oyun gibi birçok alanı kapsayan 680 zorlu soru içerir.
- Veri seti hem Çince hem de İngilizce soruları içerir.

### 🧑‍🏫 Karşılaştırma Sonuçları

| Arama Motoru/Sistem | ✅ Doğru   | ❌ Yanlış   | ⚠️ Kısmen Doğru        |
| ------------------- | --------- | ---------- | ---------------------- |
| **Volcano Ark**     | 5.00%     | 72.21%     | 22.79%                 |
| **Bailian**         | 9.85%     | 62.79%     | 27.35%                 |
| **Bizim**           | 19.85%    | 47.94%     | 32.06%                 |
## 🙏 Teşekkürler

Bu projenin bazı işlevleri aşağıdaki açık kaynak projelerin desteği ve ilhamı sayesinde mümkün olmuştur, teşekkür ederiz:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): Modüler akıllı ajan zinciri çerçevesi oluşturmak için kullanılır, karmaşık ajan sistemlerinin hızlı kurulmasına yardımcı olur.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): Güçlü web içerik analiz aracı, verimli web kazıma ve veri çıkarımı sağlar.
- 🌐 [Playwright](https://github.com/microsoft/playwright): Modern tarayıcı otomasyon aracı, tarayıcılar arası web kazıma ve test otomasyonunu destekler.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): Çoklu zincir MCP işlemlerinin oluşturulmasında kullanılır.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---