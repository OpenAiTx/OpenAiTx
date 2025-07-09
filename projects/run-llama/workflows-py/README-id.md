# LlamaIndex Workflows

[![Unit Testing](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![Coverage Status](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![GitHub contributors](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - Downloads](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflows adalah sebuah kerangka kerja untuk mengorkestrasi dan merangkai sistem yang kompleks dari langkah-langkah dan kejadian-kejadian.

## Apa yang dapat Anda bangun dengan Workflows?

Workflows sangat berguna ketika Anda perlu mengorkestrasi proses yang kompleks dan multi-langkah yang melibatkan model AI, API, dan pengambilan keputusan. Berikut adalah beberapa contoh dari apa yang dapat Anda bangun:

- **Agen AI** - Membuat sistem cerdas yang dapat bernalar, mengambil keputusan, dan melakukan aksi dalam beberapa langkah
- **Pipa Pemrosesan Dokumen** - Membangun sistem yang mengambil, menganalisis, merangkum, dan mengarahkan dokumen melalui berbagai tahap pemrosesan
- **Aplikasi AI Multi-Model** - Mengkoordinasikan antara berbagai model AI (LLM, model visi, dll.) untuk menyelesaikan tugas-tugas yang kompleks
- **Asisten Riset** - Mengembangkan workflow yang dapat mencari, menganalisis, mensintesis informasi, dan memberikan jawaban yang komprehensif
- **Sistem Generasi Konten** - Membuat pipa yang menghasilkan, meninjau, mengedit, dan menerbitkan konten dengan persetujuan manusia di dalam prosesnya
- **Otomasi Dukungan Pelanggan** - Membangun sistem pengalihan cerdas yang dapat memahami, mengkategorikan, dan merespons pertanyaan pelanggan

Arsitektur berbasis async-first dan event-driven memudahkan untuk membangun workflow yang dapat mengalihkan antara berbagai kapabilitas, menerapkan pola pemrosesan paralel, melakukan loop pada urutan kompleks, dan mempertahankan status di beberapa langkah—semua fitur yang Anda perlukan untuk membuat aplikasi AI Anda siap produksi.
## Fitur Utama

- **async-first** - workflow dibangun dengan mengutamakan fungsionalitas async Python - setiap langkah adalah fungsi async yang memproses event yang masuk dari antrean asyncio dan mengirimkan event baru ke antrean lain. Ini juga berarti workflow bekerja paling baik di aplikasi async Anda seperti FastAPI, Jupyter Notebooks, dan sebagainya.
- **event-driven** - workflow terdiri dari langkah dan event. Mengorganisasi kode Anda berdasarkan event dan langkah membuatnya lebih mudah dipahami dan diuji.
- **manajemen state** - setiap eksekusi workflow bersifat independen, artinya Anda dapat menjalankan workflow, menyimpan informasi di dalamnya, melakukan serialisasi state workflow, dan melanjutkannya nanti.
- **observability** - workflow secara otomatis diinstrumentasi untuk observability, sehingga Anda dapat langsung menggunakan alat seperti `Arize Phoenix` dan `OpenTelemetry`.

## Mulai Cepat

Pasang paketnya:

```bash
pip install llama-index-workflows
```

Dan buat workflow pertama Anda:

```python
import asyncio
from pydantic import BaseModel, Field
from workflows import Context, Workflow, step
from workflows.events import Event, StartEvent, StopEvent

class MyEvent(Event):
    msg: list[str]

class RunState(BaseModel):
    num_runs: int = Field(default=0)

class MyWorkflow(Workflow):
    @step
    async def start(self, ctx: Context[RunState], ev: StartEvent) -> MyEvent:
        async with ctx.store.edit_state() as state:
            state.num_runs += 1

            return MyEvent(msg=[ev.input_msg] * state.num_runs)

    @step
    async def process(self, ctx: Context[RunState], ev: MyEvent) -> StopEvent:
        data_length = len("".join(ev.msg))
        new_msg = f"Processed {len(ev.msg)} times, data length: {data_length}"
        return StopEvent(result=new_msg)

async def main():
    workflow = MyWorkflow()
```
```python
    # [opsional] berikan objek konteks ke alur kerja
    ctx = Context(workflow)
    result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
    print("Hasil Workflow:", result)

    # menjalankan ulang dengan konteks yang sama akan mempertahankan status
    result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
    print("Hasil Workflow:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

Pada contoh di atas
- Langkah yang menerima `StartEvent` akan dijalankan terlebih dahulu.
- Langkah yang mengembalikan `StopEvent` akan mengakhiri alur kerja.
- Event intermediat adalah yang didefinisikan pengguna dan dapat digunakan untuk mengirimkan informasi antar langkah.
- Objek `Context` juga digunakan untuk berbagi informasi antar langkah.

Kunjungi [dokumentasi lengkap](https://docs.llamaindex.ai/en/stable/understanding/workflows/) untuk lebih banyak contoh penggunaan `llama-index`!

## Contoh Lainnya

- [Penjelajahan Fitur Dasar](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [Membangun Agen Pemanggil Fungsi dengan `llama-index`](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [Ekstraksi Dokumen Iteratif dengan Human-in-the-loop](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- Observabilitas
  - [OpenTelemetry + Pengantar Instrumentasi](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## Paket Terkait

- [Workflows Typescript](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---