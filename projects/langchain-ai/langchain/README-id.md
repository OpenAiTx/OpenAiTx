<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="Logo LangChain" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![Catatan Rilis](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - Lisensi](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - Unduhan](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![Grafik bintang GitHub](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![Isu Terbuka](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![Buka di Dev Containers](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="Buka di Github Codespace" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed Badge](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!NOTE]
> Mencari library JS/TS? Lihat [LangChain.js](https://github.com/langchain-ai/langchainjs).

LangChain adalah framework untuk membangun aplikasi yang didukung LLM. Ini membantu Anda menghubungkan komponen-komponen yang dapat saling beroperasi dan integrasi pihak ketiga untuk menyederhanakan pengembangan aplikasi AI — sekaligus memastikan keputusan Anda tetap relevan seiring perkembangan teknologi yang mendasarinya.

```bash
pip install -U langchain
```

Untuk mempelajari lebih lanjut tentang LangChain, kunjungi
[dokumentasi](https://python.langchain.com/docs/introduction/). Jika Anda mencari kustomisasi tingkat lanjut atau orkestrasi agen, kunjungi
[LangGraph](https://langchain-ai.github.io/langgraph/), framework kami untuk membangun
alur kerja agen yang dapat dikontrol.

## Mengapa menggunakan LangChain?

LangChain membantu pengembang membangun aplikasi berbasis LLM melalui antarmuka standar untuk model, embeddings, vector store, dan lainnya.

Gunakan LangChain untuk:
- **Augmentasi data real-time**. Hubungkan LLM dengan mudah ke berbagai sumber data dan sistem eksternal/internal, memanfaatkan pustaka integrasi LangChain yang luas dengan penyedia model, alat, vector store, retriever, dan lainnya.
- **Interoperabilitas model**. Tukar model dengan mudah saat tim teknik Anda bereksperimen untuk menemukan pilihan terbaik bagi kebutuhan aplikasi Anda. Seiring perkembangan industri, beradaptasilah dengan cepat — abstraksi LangChain membantu Anda terus berkembang tanpa kehilangan momentum.

## Ekosistem LangChain
Meskipun framework LangChain dapat digunakan secara mandiri, ia juga terintegrasi secara mulus dengan produk LangChain lainnya, memberikan pengembang seperangkat alat lengkap saat membangun aplikasi LLM.

Untuk meningkatkan pengembangan aplikasi LLM Anda, padukan LangChain dengan:

- [LangSmith](http://www.langchain.com/langsmith) - Berguna untuk evaluasi agen dan observabilitas. Debug jalannya aplikasi LLM yang berkinerja buruk, evaluasi lintasan agen, dapatkan visibilitas di produksi, dan tingkatkan performa dari waktu ke waktu.
- [LangGraph](https://langchain-ai.github.io/langgraph/) - Bangun agen yang dapat menangani tugas kompleks secara andal dengan LangGraph, framework orkestrasi agen tingkat rendah kami. LangGraph menawarkan arsitektur yang dapat disesuaikan, memori jangka panjang, dan alur kerja human-in-the-loop — dan dipercaya di produksi oleh perusahaan seperti LinkedIn, Uber, Klarna, dan GitLab.
- [LangGraph Platform](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) - Deploy dan skalakan agen dengan mudah menggunakan platform deployment yang dirancang khusus untuk alur kerja stateful jangka panjang. Temukan, gunakan kembali, konfigurasikan, dan bagikan agen di seluruh tim — serta iterasi dengan cepat menggunakan prototipe visual di
[LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/).

## Sumber daya tambahan
- [Tutorial](https://python.langchain.com/docs/tutorials/): Panduan sederhana dengan contoh langkah demi langkah untuk memulai dengan LangChain.
- [Panduan Cara](https://python.langchain.com/docs/how_to/): Potongan kode cepat dan aplikatif untuk topik seperti pemanggilan alat, use case RAG, dan lainnya.
- [Panduan Konseptual](https://python.langchain.com/docs/concepts/): Penjelasan tentang konsep kunci di balik framework LangChain.
- [Referensi API](https://python.langchain.com/api_reference/): Referensi detail untuk menavigasi paket dasar dan integrasi pada LangChain.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---