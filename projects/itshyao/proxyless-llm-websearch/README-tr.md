
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

Proxy gerektirmeyen, çoklu arama motorunu destekleyen bir LLM web bilgi edinme aracıdır. URL içeriği çözümlemesi ve web sayfası tarama desteğiyle, LangGraph ile modüler akıllı ajan zinciri oluşturur. Büyük dil modellerinin harici bilgiye erişim senaryoları için tasarlanmıştır, **Playwright + Crawl4AI** ile web sayfası alma ve çözümleme, eşzamanlılık, içerik dilimleme ve yeniden sıralama/filtreleme destekler.

## ✨ Özelliklere Genel Bakış

- 🌐 **Proxy gerektirmez**: Playwright ile yerli tarayıcı yapılandırması sayesinde, proxy olmadan da web araması yapabilirsiniz.
- 🔍 **Çoklu arama motoru desteği**: Bing, Quark, Baidu, Sogou gibi popüler arama motorlarını destekler, bilgi kaynaklarının çeşitliliğini artırır.
- 🤖 **Niyet tanıma**: Sistem, kullanıcının girdiği içeriğe göre otomatik olarak web araması mı yoksa URL çözümlemesi mi yapılacağını belirler.
- 🔄 **Sorgu ayrıştırma**: Kullanıcının arama niyetine göre sorguyu otomatik olarak birden fazla alt göreve ayırır ve sırasıyla gerçekleştirerek aramanın alakalılığını ve verimliliğini artırır.
- ⚙️ **Ajan mimarisi**: **LangGraph** tabanlı **"web_search"** ve **"link_parser"** modüllerine sahiptir.
- 🏃‍♂️ **Eşzamanlı görev işleme**: Eşzamanlı görev işleme desteğiyle, birden fazla arama görevini verimli şekilde yönetir.
- 📝 **İçerik işleme optimizasyonu**:

  - ✂️ **İçerik dilimleme**: Uzun web sayfası içerikleri, parçalara bölünür.

  - 🔄 **İçerik yeniden sıralama**: Akıllı sıralama ile bilgi alakalılığı artırılır.

  - 🚫 **İçerik filtreleme**: İlgisiz veya tekrar eden içerikler otomatik olarak ayıklanır.
- 🌐 **Çoklu platform desteği**:

  - 🖥️ FastAPI tabanlı arka uç arayüzü ile her türlü sisteme entegre edilebilir.

  - 🌍 Gradio Web UI ile hızlıca görsel uygulama olarak dağıtılabilir.
  
  - 🧩[ **Tarayıcı eklentisi desteği**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Edge desteğiyle, akıllı URL çözümleme eklentisi sunar; doğrudan tarayıcıda web sayfası çözümlemesi ve içerik çıkarımı yapılabilir.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Hızlı Başlangıç

### 1. Depoyu Klonlayın

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. Bağımlılıkların Kurulumu

```
pip install -r requirements.txt
python -m playwright install
```

### 3. Hızlı Başlangıç

#### Ortam Değişkeni Yapılandırması

```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```

#### demo

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

#### Arka uç api

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

## 🔍 Çevrimiçi Ağ Arama Testi ile Karşılaştırma

Projeyi bazı yaygın çevrimiçi API'lerle karşılaştırdık ve karmaşık sorular karşısındaki performanslarını değerlendirdik.

### 🔥 Veri Seti

- Veri seti, Alibaba tarafından yayımlanan [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA)'dan alınmıştır ve eğitim, akademik konferans, oyun gibi birçok alanda 680 yüksek zorluk dereceli soru içermektedir.
- Veri seti hem Çince hem İngilizce soruları kapsamaktadır.

### 🧑‍🏫 Karşılaştırma Sonuçları

| Arama Motoru/Sistem | ✅ Doğru | ❌ Yanlış | ⚠️ Kısmen Doğru |
| ------------------- | ------- | -------- | -------------- |
| **Volcano Ark**     | %5,00   | %72,21   | %22,79         |
| **Bailian**         | %9,85   | %62,79   | %27,35         |
| **Bizim**           | %19,85  | %47,94   | %32,06         |

## 🙏 Teşekkürler

Bu projenin bazı fonksiyonları aşağıdaki açık kaynak projelerin desteği ve ilhamı sayesinde geliştirilmiştir, teşekkür ederiz:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): Modüler zeki ajan zinciri çerçevesi kurmak için kullanılır.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): Güçlü bir web sayfası içerik analiz aracıdır.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---