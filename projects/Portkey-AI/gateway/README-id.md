<p align="right">
   <strong>Bahasa Inggris</strong> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.cn.md">中文</a> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### Rute ke 250+ LLM dengan 1 API yang cepat & ramah

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Demo Portkey AI Gateway yang menunjukkan kemampuan routing LLM" style="margin-left:-35px">

[Dokumentasi](https://portkey.wiki/gh-1) | [Enterprise](https://portkey.wiki/gh-2) | [Hosted Gateway](https://portkey.wiki/gh-3) | [Changelog](https://portkey.wiki/gh-4) | [Referensi API](https://portkey.wiki/gh-5)


[![Lisensi](https://img.shields.io/github/license/Ileriayo/markdown-badges)](https://raw.githubusercontent.com/Portkey-AI/gateway/main/LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

[**AI Gateway**](https://portkey.wiki/gh-10) dirancang untuk routing cepat, andal & aman ke 1600+ model bahasa, visi, audio, dan gambar. Ini adalah solusi ringan, open-source, dan siap enterprise yang memungkinkan Anda terintegrasi dengan model bahasa apa pun dalam waktu kurang dari 2 menit.

- [x] **Sangat cepat** (latensi <1ms) dengan ukuran sangat kecil (122kb)
- [x] **Teruji di lapangan**, dengan lebih dari 10 miliar token diproses setiap hari
- [x] **Siap enterprise** dengan keamanan, skalabilitas, dan deployment khusus yang ditingkatkan

<br>

#### Apa yang bisa Anda lakukan dengan AI Gateway?
- Integrasi dengan LLM apa pun dalam waktu kurang dari 2 menit - [Quickstart](#quickstart-2-mins)
- Mencegah downtime melalui **[automatic retries](https://portkey.wiki/gh-11)** dan **[fallbacks](https://portkey.wiki/gh-12)**
- Skalakan aplikasi AI Anda dengan **[load balancing](https://portkey.wiki/gh-13)** dan **[conditional routing](https://portkey.wiki/gh-14)**
- Lindungi deployment AI Anda dengan **[guardrails](https://portkey.wiki/gh-15)**
- Lebih dari sekadar teks dengan **[kemampuan multi-modal](https://portkey.wiki/gh-16)**
- Terakhir, jelajahi integrasi **[agentic workflow](https://portkey.wiki/gh-17)**

<br><br>

> [!TIP]
> Memberi bintang pada repo ini membantu lebih banyak developer menemukan AI Gateway 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## Quickstart (2 menit)

### 1. Siapkan AI Gateway Anda

```bash
# Jalankan gateway secara lokal (memerlukan Node.js dan npm)
npx @portkey-ai/gateway
```
> Gateway berjalan di `http://localhost:8787/v1`
> 
> Gateway Console berjalan di `http://localhost:8787/public/`

<sup>
Panduan deployment:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (Direkomendasikan)</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md"> Lainnya...</a>

</sup>

### 2. Lakukan permintaan pertama Anda

<!-- <details open>
<summary>Contoh Python</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# Klien kompatibel OpenAI
client = Portkey(
    provider="openai", # atau 'anthropic', 'bedrock', 'groq', dll
    Authorization="sk-***" # API key provider
)

# Lakukan permintaan melalui AI Gateway Anda
client.chat.completions.create(
    messages=[{"role": "user", "content": "Bagaimana cuaca hari ini?"}],
    model="gpt-4o-mini"
)
```



<sup>Library yang didukung:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [Lainnya..](https://portkey.wiki/gh-26)
</sup>

Pada Gateway Console (`http://localhost:8787/public/`) Anda dapat melihat semua log lokal Anda di satu tempat.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. Routing & Guardrails
`Configs` di LLM gateway memungkinkan Anda membuat aturan routing, menambah keandalan, dan mengatur guardrails.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# Lampirkan config ke client
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Balas secara acak dengan Apple atau Bat"}]
)

# Ini akan selalu merespons dengan "Bat" karena guardrail menolak semua balasan yang mengandung "Apple". Config retry akan mencoba ulang hingga 5 kali sebelum menyerah.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Alur permintaan melalui AI gateway Portkey dengan retry dan guardrails" alt="Alur permintaan melalui AI gateway Portkey dengan retry dan guardrails"/>
</div>

Anda bisa melakukan lebih banyak hal dengan config di AI gateway Anda. [Lihat contoh  →](https://portkey.wiki/gh-27)

<br/>

### Versi Enterprise (Deployment privat)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

[Versi enterprise](https://portkey.wiki/gh-86) dari LLM Gateway menawarkan kemampuan lanjutan untuk **manajemen organisasi**, **governance**, **keamanan**, dan [lainnya](https://portkey.wiki/gh-87) langsung siap pakai. [Lihat Perbandingan Fitur →](https://portkey.wiki/gh-32)

Arsitektur deployment enterprise untuk platform yang didukung tersedia di sini - [**Enterprise Private Cloud Deployments**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Book demo AI gateway enterprise" /></a><br/>


<br>

<hr>

### AI Engineering Hours

Ikuti panggilan komunitas mingguan setiap Jumat (8 AM PT) untuk memulai implementasi AI Gateway Anda! [Setiap Jumat](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

Notulen rapat [dipublikasikan di sini](https://portkey.wiki/gh-36).


<hr>

### LLMs in Prod'25

Wawasan dari analisis lebih dari 2 triliun token, di 90+ wilayah dan 650+ tim produksi. Yang akan Anda temukan di laporan ini:
- Tren yang membentuk adopsi AI dan pertumbuhan penyedia LLM.
- Benchmark untuk mengoptimalkan kecepatan, biaya, dan keandalan.
- Strategi untuk menskalakan sistem AI kelas produksi.

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**Dapatkan Laporannya**</a>
<hr>


## Fitur Utama
### Routing Andal
- <a href="https://portkey.wiki/gh-37">**Fallbacks**</a>: Beralih ke penyedia atau model lain saat permintaan gagal menggunakan LLM gateway. Anda dapat menentukan error yang akan memicu fallback. Meningkatkan keandalan aplikasi Anda.
- <a href="https://portkey.wiki/gh-38">**Automatic Retries**</a>: Otomatis mengulangi permintaan yang gagal hingga 5 kali. Strategi exponential backoff digunakan untuk menjaga jarak antar percobaan ulang agar tidak membebani jaringan.
- <a href="https://portkey.wiki/gh-39">**Load Balancing**</a>: Mendistribusikan permintaan LLM ke beberapa API key atau penyedia AI dengan pembobotan untuk memastikan ketersediaan tinggi dan performa optimal.
- <a href="https://portkey.wiki/gh-40">**Request Timeouts**</a>: Mengelola LLM & latensi yang tidak terkontrol dengan menetapkan batas waktu permintaan secara rinci, memungkinkan penghentian otomatis permintaan yang melebihi durasi tertentu.
- <a href="https://portkey.wiki/gh-41">**Multi-modal LLM Gateway**</a>: Memanggil model vision, audio (text-to-speech & speech-to-text), dan image generation dari berbagai penyedia — semuanya menggunakan signature OpenAI yang sudah dikenal
- <a href="https://portkey.wiki/gh-42">**Realtime APIs**</a>: Memanggil API realtime yang diluncurkan oleh OpenAI melalui integrasi websockets server.

### Keamanan & Akurasi
- <a href="https://portkey.wiki/gh-88">**Guardrails**</a>: Memverifikasi input dan output LLM Anda agar sesuai dengan pemeriksaan yang Anda tentukan. Pilih dari lebih dari 40 guardrails bawaan untuk memastikan kepatuhan terhadap standar keamanan dan akurasi. Anda dapat <a href="https://portkey.wiki/gh-43">menggunakan guardrails sendiri</a> atau memilih dari <a href="https://portkey.wiki/gh-44">banyak mitra kami</a>.
- [**Manajemen Kunci yang Aman**](https://portkey.wiki/gh-45): Gunakan kunci Anda sendiri atau buat kunci virtual secara instan.
- [**Kontrol akses berbasis peran**](https://portkey.wiki/gh-46): Kontrol akses yang rinci untuk pengguna, workspace, dan API key Anda.
- <a href="https://portkey.wiki/gh-47">**Kepatuhan & Privasi Data**</a>: AI gateway telah memenuhi standar SOC2, HIPAA, GDPR, dan CCPA.

### Manajemen Biaya
- [**Smart caching**](https://portkey.wiki/gh-48): Cache respons dari LLM untuk mengurangi biaya dan meningkatkan latensi. Mendukung caching sederhana dan semantik*.
- [**Analitik penggunaan**](https://portkey.wiki/gh-49): Pantau dan analisis penggunaan AI dan LLM Anda, termasuk volume permintaan, latensi, biaya dan tingkat error.
- [**Optimasi penyedia***](https://portkey.wiki/gh-89): Otomatis berpindah ke penyedia paling hemat biaya berdasarkan pola penggunaan dan model harga.

### Kolaborasi & Alur Kerja
- <a href="https://portkey.ai/docs/integrations/agents">**Dukungan Agen**</a>: Integrasi mulus dengan framework agen populer untuk membangun aplikasi AI kompleks. Gateway terintegrasi dengan [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55), hingga [Custom Agents](https://portkey.wiki/gh-56).
- [**Manajemen Prompt Template***](https://portkey.wiki/gh-57): Membuat, mengelola, dan memversi template prompt Anda secara kolaboratif melalui universal prompt playground.
<br/><br/>

<sup>
*&nbsp;Tersedia di versi hosted dan enterprise
</sup>

<br>

## Cookbooks

### ☄️ Trending
- Gunakan model dari [Nvidia NIM](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/providers/nvidia.ipynb) dengan AI Gateway
- Monitor [CrewAI Agents](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) dengan Portkey!
- Membandingkan [10 Model LMSYS Teratas](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) dengan AI Gateway.

### 🚨 Terbaru
* [Buat Dataset Sintetis menggunakan Nemotron](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [Gunakan LLM Gateway dengan Vercel's AI SDK](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/integrations/vercel-ai.md)
* [Pantau Llama Agents dengan LLM Gateway dari Portkey](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[Lihat semua cookbook →](https://portkey.wiki/gh-58)
<br/><br/>

## Penyedia yang Didukung

Jelajahi integrasi Gateway dengan [45+ penyedia](https://portkey.wiki/gh-59) dan [8+ framework agen](https://portkey.wiki/gh-90).

|                                                                                                                            | Penyedia                                                                                     | Dukungan | Stream |
| -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------- | ------ |
| <img src="docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                           | ✅       | ✅      |
| <img src="docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅       | ✅      |
| <img src="docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅       | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅       | ✅      |
| <img src="docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅       | ✅      |
| <img src="docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅       | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅       | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅       | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅       | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅       | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅       | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅       | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅       | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅       | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅       | ✅      | `/chat/completions`, `/completions` |


> [Lihat daftar lengkap 200+ model yang didukung di sini](https://portkey.wiki/gh-74)
<br>

<br>

## Agen
Gateway terintegrasi mulus dengan framework agen populer. [Baca dokumentasinya di sini](https://portkey.wiki/gh-75).


| Framework | Panggil 200+ LLM | Routing Lanjutan | Caching | Logging & Tracing* | Observability* | Manajemen Prompt* |
|------------------------------|--------|-------------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Bangun Agen Anda Sendiri](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*Tersedia di [aplikasi hosted](https://portkey.wiki/gh-76). Untuk dokumentasi lengkap [klik di sini](https://portkey.wiki/gh-100).


## Versi Enterprise Gateway
Jadikan aplikasi AI Anda lebih <ins>andal</ins> dan <ins>kompatibel ke depan</ins>, sambil memastikan <ins>keamanan data</ins> dan <ins>privasi</ins> sepenuhnya.

✅&nbsp; Manajemen Kunci Aman - untuk kontrol akses berbasis peran dan pelacakan <br>
✅&nbsp; Caching Sederhana & Semantik - untuk melayani permintaan berulang lebih cepat & menghemat biaya <br>
✅&nbsp; Kontrol Akses & Aturan Masuk - untuk mengatur IP dan Geo yang dapat terhubung ke deployment Anda <br>
✅&nbsp; Redaksi PII - untuk otomatis menghapus data sensitif dari permintaan Anda guna mencegah kebocoran <br>
✅&nbsp; SOC2, ISO, HIPAA, GDPR Compliances - untuk praktik keamanan terbaik <br>
✅&nbsp; Dukungan Profesional - beserta prioritas fitur <br>

[Atur jadwal diskusi untuk deployment enterprise](https://portkey.sh/demo-13)

<br>


## Kontribusi

Cara termudah untuk berkontribusi adalah memilih isu dengan tag `good first issue` 💪. Baca panduan kontribusi [di sini](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/CONTRIBUTING.md).

Laporan Bug? [Laporkan di sini](https://portkey.wiki/gh-78) | Permintaan Fitur? [Ajukan di sini](https://portkey.wiki/gh-78)


### Memulai Bersama Komunitas
Ikuti AI Engineering Hours mingguan setiap Jumat (8 AM PT) untuk:
- Bertemu kontributor dan anggota komunitas lain
- Mempelajari fitur-fitur Gateway tingkat lanjut dan pola implementasi
- Berbagi pengalaman dan mendapatkan bantuan
- Tetap update dengan prioritas pengembangan terbaru

[Bergabung di sesi berikutnya →](https://portkey.wiki/gh-101) | [Catatan rapat](https://portkey.wiki/gh-102)

<br>

## Komunitas

Bergabunglah dengan komunitas kami yang terus berkembang di seluruh dunia, untuk bantuan, ide, dan diskusi tentang AI.

- Lihat [Blog resmi](https://portkey.wiki/gh-78)
- Chat bersama kami di [Discord](https://portkey.wiki/community)
- Ikuti kami di [Twitter](https://portkey.wiki/gh-79)
- Terhubung dengan kami di [LinkedIn](https://portkey.wiki/gh-80)
- Baca dokumentasi dalam [Bahasa Jepang](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md)
- Kunjungi kami di [YouTube](https://portkey.wiki/gh-103)
- Bergabung dengan [Komunitas Developer](https://portkey.wiki/gh-82)
<!-- - Pertanyaan dengan tag #portkey di [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---