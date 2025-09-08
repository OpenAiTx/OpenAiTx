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

Sebuah alat pencarian web LLM multi-mesin pencari tanpa proxy, mendukung parsing konten URL dan perayapan web, menggabungkan **LangGraph** dan **LangGraph-MCP** untuk membangun rantai agen modular. Dirancang khusus untuk skenario penggunaan penarikan pengetahuan eksternal oleh model bahasa besar, mendukung pengambilan dan parsing web dengan **Playwright + Crawl4AI**, mendukung asinkron, pemrosesan paralel, pemotongan konten, dan filtrasi serta penyusunan ulang.

## 🚀 Log Pembaruan

- 🔥 2025-09-05: Mendukung **langgraph-mcp**
- 🔥 2025-09-03: Penambahan deploy Docker, re-ranker cerdas bawaan, mendukung pemisah teks dan re-ranker kustom

## ✨ Daftar Fitur

- 🌐 **Tanpa Proxy**: Dengan konfigurasi Playwright yang mendukung browser dalam negeri, pencarian internet dapat dilakukan tanpa perlu proxy.
- 🔍 **Dukungan Multi Mesin Pencari**: Mendukung Bing, Quark, Baidu, Sogou, dan mesin pencari utama lainnya, meningkatkan keragaman sumber informasi.
- 🤖 **Pengenalan Intent**: Sistem dapat secara otomatis menentukan apakah ingin melakukan pencarian web atau mem-parsing URL berdasarkan input pengguna.
- 🔄 **Pemecahan Query**: Berdasarkan intent pencarian pengguna, query secara otomatis dipecah menjadi beberapa sub-tugas dan dieksekusi secara berurutan untuk meningkatkan relevansi dan efisiensi pencarian.
- ⚙️ **Arsitektur Agen Cerdas**: Berdasarkan **LangGraph** yang membungkus **"web_search"** dan **"link_parser"**.
- 🏃‍♂️ **Pemrosesan Tugas Asinkron dan Paralel**: Mendukung pemrosesan tugas secara asinkron dan paralel untuk menangani banyak pencarian dengan efisien.
- 📝 **Optimasi Pemrosesan Konten**:

  - ✂️ **Pemotongan Konten**: Konten panjang halaman web dipotong per bagian.

  - 🔄 **Penyusunan Ulang Konten**: Penyusunan ulang secara cerdas untuk meningkatkan relevansi informasi.

  - 🚫 **Penyaringan Konten**: Secara otomatis menghapus konten yang tidak relevan atau duplikat.
- 🌐 **Dukungan Multi Platform**:
  - 🐳 **Dukungan Deploy Docker**: Satu klik untuk memulai, membangun layanan backend dengan cepat.

  - 🖥️ Menyediakan API backend FastAPI, dapat diintegrasikan ke sistem apa pun.

  - 🌍 Menyediakan Gradio Web UI, dapat dengan cepat di-deploy sebagai aplikasi visual.

  - 🧩[ **Dukungan Plugin Browser**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Mendukung Edge, menyediakan plugin parsing URL cerdas, langsung melakukan parsing halaman web dan permintaan ekstraksi konten di browser.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Mulai Cepat

### Kloning Repository

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### Instalasi Dependensi

```
pip install -r requirements.txt
python -m playwright install
```

### Konfigurasi Variabel Lingkungan

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

#### API SERVE

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

#### Menyalakan layanan MCP

```
python mcp/websearch.py
```

#### DEMO

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

### Modul Kustom

#### Pembagian Blok Kustom

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

#### Penataan Ulang Kustom

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

## 🔍 Perbandingan dengan Pengujian Pencarian Jaringan Online

Kami membandingkan proyek ini dengan beberapa API daring utama untuk mengevaluasi performanya dalam menjawab pertanyaan kompleks.

### 🔥 Dataset

- Dataset berasal dari [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) yang dirilis oleh Alibaba, berisi 680 pertanyaan tingkat kesulitan tinggi yang mencakup berbagai bidang seperti pendidikan, konferensi akademik, dan game.
- Dataset mencakup pertanyaan dalam bahasa Mandarin dan Inggris.

### 🧑‍🏫 Hasil Perbandingan

| Mesin Pencari/Sistem | ✅ Benar | ❌ Salah | ⚠️ Sebagian Benar |
| -------------------- | -------- | -------- | ---------------- |
| **Volcano Ark**      | 5.00%    | 72.21%   | 22.79%           |
| **Bailian**          | 9.85%    | 62.79%   | 27.35%           |
| **Our**              | 19.85%   | 47.94%   | 32.06%           |
## 🙏 Ucapan Terima Kasih

Sebagian fungsi dari proyek ini didukung dan terinspirasi oleh proyek open source berikut, dengan ini kami mengucapkan terima kasih:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): Digunakan untuk membangun kerangka kerja rantai agen modular, membantu membangun sistem agen kompleks secara cepat.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): Alat parsing konten web yang kuat, mendukung pengambilan dan ekstraksi data web secara efisien.
- 🌐 [Playwright](https://github.com/microsoft/playwright): Alat otomatisasi browser modern, mendukung pengambilan web dan otomatisasi pengujian lintas browser.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): Digunakan untuk membangun penanganan MCP multi-chain.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---