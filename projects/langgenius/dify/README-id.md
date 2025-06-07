![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Memperkenalkan Dify Workflow File Upload: Membuat Ulang Google NotebookLM Podcast</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify Cloud</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">Self-hosting</a> ·
  <a href="https://docs.dify.ai">Dokumentasi</a> ·
  <a href="https://dify.ai/pricing">Ringkasan edisi Dify</a>
</p>

<p align="center">
    <a href="https://dify.ai" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/Product-F04438"></a>
    <a href="https://dify.ai/pricing" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/free-pricing?logo=free&color=%20%23155EEF&label=pricing&labelColor=%20%23528bff"></a>
    <a href="https://discord.gg/FngNHpbcY7" target="_blank">
        <img src="https://img.shields.io/discord/1082486657678311454?logo=discord&labelColor=%20%235462eb&logoColor=%20%23f5f5f5&color=%20%235462eb"
            alt="chat di Discord"></a>
    <a href="https://reddit.com/r/difyai" target="_blank">  
        <img src="https://img.shields.io/reddit/subreddit-subscribers/difyai?style=plastic&logo=reddit&label=r%2Fdifyai&labelColor=white"
            alt="bergabung di Reddit"></a>
    <a href="https://twitter.com/intent/follow?screen_name=dify_ai" target="_blank">
        <img src="https://img.shields.io/twitter/follow/dify_ai?logo=X&color=%20%23f5f5f5"
            alt="ikuti di X(Twitter)"></a>
    <a href="https://www.linkedin.com/company/langgenius/" target="_blank">
        <img src="https://custom-icon-badges.demolab.com/badge/LinkedIn-0A66C2?logo=linkedin-white&logoColor=fff"
            alt="ikuti di LinkedIn"></a>
    <a href="https://hub.docker.com/u/langgenius" target="_blank">
        <img alt="Docker Pulls" src="https://img.shields.io/docker/pulls/langgenius/dify-web?labelColor=%20%23FDB062&color=%20%23f79009"></a>
    <a href="https://github.com/langgenius/dify/graphs/commit-activity" target="_blank">
        <img alt="Commit bulan lalu" src="https://img.shields.io/github/commit-activity/m/langgenius/dify?labelColor=%20%2332b583&color=%20%2312b76a"></a>
    <a href="https://github.com/langgenius/dify/" target="_blank">
        <img alt="Issues closed" src="https://img.shields.io/github/issues-search?query=repo%3Alanggenius%2Fdify%20is%3Aclosed&label=issues%20closed&labelColor=%20%237d89b0&color=%20%235d6b98"></a>
    <a href="https://github.com/langgenius/dify/discussions/" target="_blank">
        <img alt="Postingan Diskusi" src="https://img.shields.io/github/discussions/langgenius/dify?labelColor=%20%239b8afb&color=%20%237a5af8"></a>
</p>

<p align="center">
  <a href="./README.md"><img alt="README in English" src="https://img.shields.io/badge/English-d9d9d9"></a>
  <a href="./README_TW.md"><img alt="繁體中文文件" src="https://img.shields.io/badge/繁體中文-d9d9d9"></a>
  <a href="./README_CN.md"><img alt="简体中文版自述文件" src="https://img.shields.io/badge/简体中文-d9d9d9"></a>
  <a href="./README_JA.md"><img alt="日本語のREADME" src="https://img.shields.io/badge/日本語-d9d9d9"></a>
  <a href="./README_ES.md"><img alt="README en Español" src="https://img.shields.io/badge/Español-d9d9d9"></a>
  <a href="./README_FR.md"><img alt="README en Français" src="https://img.shields.io/badge/Français-d9d9d9"></a>
  <a href="./README_KL.md"><img alt="README tlhIngan Hol" src="https://img.shields.io/badge/Klingon-d9d9d9"></a>
  <a href="./README_KR.md"><img alt="README in Korean" src="https://img.shields.io/badge/한국어-d9d9d9"></a>
  <a href="./README_AR.md"><img alt="README بالعربية" src="https://img.shields.io/badge/العربية-d9d9d9"></a>
  <a href="./README_TR.md"><img alt="Türkçe README" src="https://img.shields.io/badge/Türkçe-d9d9d9"></a>
  <a href="./README_VI.md"><img alt="README Tiếng Việt" src="https://img.shields.io/badge/Ti%E1%BA%BFng%20Vi%E1%BB%87t-d9d9d9"></a>
  <a href="./README_DE.md"><img alt="README in Deutsch" src="https://img.shields.io/badge/German-d9d9d9"></a>
  <a href="./README_BN.md"><img alt="README in বাংলা" src="https://img.shields.io/badge/বাংলা-d9d9d9"></a>
</p>

Dify adalah platform pengembangan aplikasi LLM open-source. Antarmuka intuitifnya menggabungkan workflow AI agentic, pipeline RAG, kapabilitas agen, manajemen model, fitur observabilitas, dan lainnya, memungkinkan Anda untuk dengan cepat berpindah dari prototipe ke produksi.

## Mulai cepat

> Sebelum menginstal Dify, pastikan mesin Anda memenuhi persyaratan minimum sistem berikut:
>
> - CPU >= 2 Core
> - RAM >= 4 GiB

</br>

Cara termudah untuk memulai server Dify adalah melalui [docker compose](docker/docker-compose.yaml). Sebelum menjalankan Dify dengan perintah berikut, pastikan [Docker](https://docs.docker.com/get-docker/) dan [Docker Compose](https://docs.docker.com/compose/install/) telah terinstal di mesin Anda:

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

Setelah berjalan, Anda dapat mengakses dashboard Dify melalui browser di [http://localhost/install](http://localhost/install) dan memulai proses inisialisasi.

#### Mencari bantuan

Silakan lihat [FAQ](https://docs.dify.ai/getting-started/install-self-hosted/faqs) jika Anda mengalami masalah saat menyiapkan Dify. Hubungi [komunitas dan kami](#community--contact) jika Anda masih mengalami kendala.

> Jika Anda ingin berkontribusi ke Dify atau melakukan pengembangan tambahan, lihat [panduan deploy dari source code](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code) kami.

## Fitur utama

**1. Workflow**:
Bangun dan uji workflow AI yang kuat di kanvas visual, memanfaatkan semua fitur berikut dan lebih banyak lagi.

**2. Dukungan model yang komprehensif**:
Integrasi mulus dengan ratusan LLM proprietary / open-source dari puluhan penyedia inference dan solusi self-hosted, mencakup GPT, Mistral, Llama3, dan semua model yang kompatibel dengan OpenAI API. Daftar lengkap penyedia model yang didukung dapat ditemukan [di sini](https://docs.dify.ai/getting-started/readme/model-providers).

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. Prompt IDE**:
Antarmuka intuitif untuk membuat prompt, membandingkan performa model, dan menambahkan fitur tambahan seperti text-to-speech ke aplikasi berbasis chat.

**4. Pipeline RAG**:
Kapabilitas RAG yang luas mencakup mulai dari ingestion dokumen hingga retrieval, dengan dukungan langsung untuk ekstraksi teks dari PDF, PPT, dan format dokumen umum lainnya.

**5. Kapabilitas agen**:
Anda dapat mendefinisikan agen berdasarkan LLM Function Calling atau ReAct, dan menambahkan tool bawaan atau kustom untuk agen. Dify menyediakan 50+ tool bawaan untuk agen AI, seperti Google Search, DALL·E, Stable Diffusion, dan WolframAlpha.

**6. LLMOps**:
Pantau dan analisa log aplikasi serta performa dari waktu ke waktu. Anda dapat terus menyempurnakan prompt, dataset, dan model berdasarkan data produksi dan anotasi.

**7. Backend-as-a-Service**:
Semua layanan Dify dilengkapi API terkait, sehingga Anda dapat dengan mudah mengintegrasikan Dify ke dalam logika bisnis Anda sendiri.

## Perbandingan Fitur

<table style="width: 100%;">
  <tr>
    <th align="center">Fitur</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">Pendekatan Pemrograman</td>
    <td align="center">API + Berorientasi Aplikasi</td>
    <td align="center">Kode Python</td>
    <td align="center">Berorientasi Aplikasi</td>
    <td align="center">Berorientasi API</td>
  </tr>
  <tr>
    <td align="center">LLM yang Didukung</td>
    <td align="center">Sangat Beragam</td>
    <td align="center">Sangat Beragam</td>
    <td align="center">Sangat Beragam</td>
    <td align="center">Hanya OpenAI</td>
  </tr>
  <tr>
    <td align="center">Mesin RAG</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Agen</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Workflow</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Observabilitas</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Fitur Enterprise (SSO/Kontrol akses)</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Deploy Lokal</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## Menggunakan Dify

- **Cloud </br>**
  Kami menyediakan layanan [Dify Cloud](https://dify.ai) untuk siapa saja yang ingin mencoba tanpa setup. Layanan ini menyediakan seluruh kapabilitas versi self-deployed, dan termasuk 200 panggilan GPT-4 gratis pada paket sandbox.

- **Self-hosting Dify Community Edition</br>**
  Jalankan Dify dengan cepat di lingkungan Anda melalui [panduan awal](#quick-start) ini.
  Gunakan [dokumentasi](https://docs.dify.ai) kami untuk referensi lebih lanjut dan instruksi mendalam.

- **Dify untuk perusahaan / organisasi</br>**
  Kami menyediakan fitur tambahan yang berfokus pada kebutuhan enterprise. [Ajukan pertanyaan melalui chatbot ini](https://udify.app/chat/22L1zSxg6yW1cWQg) atau [kirim email ke kami](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry) untuk mendiskusikan kebutuhan enterprise Anda. </br>
  > Untuk startup dan bisnis kecil yang menggunakan AWS, cek [Dify Premium di AWS Marketplace](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6) dan deploy langsung ke AWS VPC Anda dengan satu klik. Ini adalah penawaran AMI yang terjangkau dengan opsi untuk membuat aplikasi dengan logo dan branding kustom.

## Selalu terdepan

Bintangi Dify di GitHub dan dapatkan notifikasi rilis baru secara instan.

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## Setup Lanjutan

Jika Anda perlu menyesuaikan konfigurasi, silakan lihat komentar pada file [.env.example](docker/.env.example) kami dan perbarui nilai yang sesuai di file `.env` Anda. Selain itu, Anda mungkin perlu menyesuaikan file `docker-compose.yaml` secara langsung, seperti mengganti versi image, pemetaan port, atau mount volume, sesuai dengan lingkungan dan kebutuhan deployment spesifik Anda. Setelah melakukan perubahan, silakan jalankan kembali `docker-compose up -d`. Anda dapat menemukan daftar variabel lingkungan yang tersedia [di sini](https://docs.dify.ai/getting-started/install-self-hosted/environments).

Jika Anda ingin mengonfigurasi setup yang highly-available, terdapat [Helm Chart](https://helm.sh/) dan file YAML yang dikontribusikan komunitas untuk men-deploy Dify di Kubernetes.

- [Helm Chart oleh @LeoQuote](https://github.com/douban/charts/tree/master/charts/dify)
- [Helm Chart oleh @BorisPolonsky](https://github.com/BorisPolonsky/dify-helm)
- [Helm Chart oleh @magicsong](https://github.com/magicsong/ai-charts)
- [File YAML oleh @Winson-030](https://github.com/Winson-030/dify-kubernetes)
- [File YAML oleh @wyy-holding](https://github.com/wyy-holding/dify-k8s)

#### Menggunakan Terraform untuk Deployment

Deploy Dify ke Cloud Platform dengan satu klik menggunakan [terraform](https://www.terraform.io/)

##### Azure Global

- [Azure Terraform oleh @nikawang](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [Google Cloud Terraform oleh @sotazum](https://github.com/DeNA/dify-google-cloud-terraform)

#### Menggunakan AWS CDK untuk Deployment

Deploy Dify ke AWS dengan [CDK](https://aws.amazon.com/cdk/)

##### AWS

- [AWS CDK oleh @KevinZhao](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## Kontribusi

Bagi Anda yang ingin berkontribusi kode, silakan lihat [Panduan Kontribusi](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
Selain itu, dukunglah Dify dengan membagikannya di media sosial serta di acara atau konferensi.

> Kami mencari kontributor untuk membantu menerjemahkan Dify ke bahasa selain Mandarin atau Inggris. Jika Anda tertarik membantu, silakan lihat [README i18n](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) untuk informasi lebih lanjut, dan tinggalkan komentar di kanal `global-users` pada [Discord Community Server](https://discord.gg/8Tpq4AcN9c) kami.

## Komunitas & kontak

- [GitHub Discussion](https://github.com/langgenius/dify/discussions). Terbaik untuk: berbagi masukan dan bertanya.
- [GitHub Issues](https://github.com/langgenius/dify/issues). Terbaik untuk: bug saat menggunakan Dify.AI, dan proposal fitur. Lihat [Panduan Kontribusi](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
- [Discord](https://discord.gg/FngNHpbcY7). Terbaik untuk: berbagi aplikasi Anda dan berinteraksi dengan komunitas.
- [X(Twitter)](https://twitter.com/dify_ai). Terbaik untuk: berbagi aplikasi Anda dan berinteraksi dengan komunitas.

**Kontributor**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## Riwayat bintang

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## Pengungkapan keamanan

Untuk melindungi privasi Anda, hindari memposting isu keamanan di GitHub. Sebagai gantinya, kirim pertanyaan Anda ke security@dify.ai dan kami akan memberikan jawaban lebih detail.

## Lisensi

Repositori ini tersedia di bawah [Lisensi Open Source Dify](LICENSE), yang pada dasarnya adalah Apache 2.0 dengan beberapa pembatasan tambahan.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---