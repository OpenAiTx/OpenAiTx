
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

# 🧠 Mesin Pencari Web LLM Tanpa Proxy

Sebuah alat pencarian web LLM multi-mesin pencari tanpa proxy, mendukung parsing konten URL dan perayapan web, menggabungkan LangGraph untuk mewujudkan rantai agen modular. Dirancang khusus untuk skenario pemanggilan pengetahuan eksternal oleh model bahasa besar, mendukung **Playwright + Crawl4AI** untuk mendapatkan dan mem-parsing halaman web, mendukung tugas asinkron, pemotongan dan penyusunan ulang konten.

## ✨ Fitur Utama

- 🌐 **Tanpa Proxy**: Mendukung browser dalam negeri melalui konfigurasi Playwright, pencarian web tanpa perlu proxy.
- 🔍 **Dukungan Multi Mesin Pencari**: Mendukung Bing, Quark, Baidu, Sogou dan mesin pencari utama lainnya, memperkaya keragaman sumber informasi.
- 🤖 **Pengenalan Intent**: Sistem dapat secara otomatis mengenali apakah input pengguna perlu pencarian web atau parsing URL.
- 🔄 **Pemecahan Query**: Berdasarkan intent pencarian pengguna, query akan dipecah menjadi beberapa sub-tugas dan dieksekusi berurutan, sehingga meningkatkan relevansi dan efisiensi pencarian.
- ⚙️ **Arsitektur Agen**: Berdasarkan **LangGraph** membungkus **"web_search"** dan **"link_parser"**.
- 🏃‍♂️ **Proses Tugas Asinkron Paralel**: Mendukung pemrosesan tugas asinkron paralel, efisien dalam menangani banyak tugas pencarian.
- 📝 **Optimasi Pemrosesan Konten**:

  - ✂️ **Pemotongan Konten**: Memotong konten panjang halaman web menjadi beberapa bagian.

  - 🔄 **Penyusunan Ulang Konten**: Menyusun ulang secara cerdas untuk meningkatkan relevansi informasi.

  - 🚫 **Penyaringan Konten**: Secara otomatis menghapus konten yang tidak relevan atau duplikat.
- 🌐 **Dukungan Multi Platform**:

  - 🖥️ Menyediakan API backend FastAPI, dapat diintegrasikan ke sistem apa pun.

  - 🌍 Menyediakan Gradio Web UI, dapat dengan cepat diterapkan sebagai aplikasi visual.
  
  - 🧩[ **Dukungan Ekstensi Browser**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Mendukung Edge, menyediakan plugin parsing URL cerdas untuk langsung mengirim permintaan parsing dan ekstraksi konten web di browser.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Mulai Cepat

### 1. Kloning repositori

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. Instalasi Dependensi

```
pip install -r requirements.txt
python -m playwright install
```

### 3. Mulai Cepat

#### Konfigurasi Variabel Lingkungan

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

#### API backend

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

## 🔍 Perbandingan dengan Pengujian Pencarian Online

Kami membandingkan proyek ini dengan beberapa API daring utama, mengevaluasi kinerjanya pada pertanyaan-pertanyaan kompleks.

### 🔥 Dataset

- Dataset berasal dari [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) yang dirilis oleh Alibaba, mencakup 680 pertanyaan tingkat lanjut yang meliputi bidang pendidikan, konferensi akademik, game, dan lainnya.
- Dataset mencakup pertanyaan dalam bahasa Mandarin dan Inggris.

### 🧑‍🏫 Hasil Perbandingan

| Mesin Pencari/Sistem  | ✅ Benar | ❌ Salah | ⚠️ Sebagian Benar |
| --------------------- | ------- | ------- | ---------------- |
| **Volcano Ark**       | 5.00%   | 72.21%  | 22.79%           |
| **Bailian**           | 9.85%   | 62.79%  | 27.35%           |
| **Our**               | 19.85%  | 47.94%  | 32.06%           |

## 🙏 Ucapan Terima Kasih

Beberapa fitur proyek ini terinspirasi dan didukung oleh proyek open source berikut, terima kasih sebesar-besarnya:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): Digunakan untuk membangun kerangka kerja rantai agen modular.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): Alat analisis konten web yang kuat.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---