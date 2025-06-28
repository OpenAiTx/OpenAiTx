# Awesome MCP Servers [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

Daftar terkurasi server Model Context Protocol (MCP) yang luar biasa.

* [Apa itu MCP?](#apa-itu-mcp)
* [Klien](#klien)
* [Tutorial](#tutorial)
* [Komunitas](#komunitas)
* [Legenda](#legenda)
* [Implementasi Server](#implementasi-server)
* [Framework](#framework)
* [Tips & Trik](#tips--trik)

## Apa itu MCP?

[MCP](https://modelcontextprotocol.io/) adalah protokol terbuka yang memungkinkan model AI untuk berinteraksi secara aman dengan sumber daya lokal dan jarak jauh melalui implementasi server yang terstandarisasi. Daftar ini berfokus pada server MCP siap-produksi dan eksperimental yang memperluas kapabilitas AI melalui akses file, koneksi basis data, integrasi API, dan layanan kontekstual lainnya.

## Klien

Lihat [awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) dan [glama.ai/mcp/clients](https://glama.ai/mcp/clients).

> [!TIP]
> [Glama Chat](https://glama.ai/chat) adalah klien AI multi-modal dengan dukungan MCP & [AI gateway](https://glama.ai/gateway).

## Tutorial

* [Model Context Protocol (MCP) Quickstart](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [Setup Claude Desktop App to Use a SQLite Database](https://youtu.be/wxCCzo9dGj0)

## Komunitas

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [Server Discord](https://glama.ai/mcp/discord)

## Legenda

* 🎖️ – implementasi resmi
* bahasa pemrograman
  * 🐍 – basis kode Python
  * 📇 – basis kode TypeScript (atau JavaScript)
  * 🏎️ – basis kode Go
  * 🦀 – basis kode Rust
  * #️⃣ - basis kode C#
  * ☕ - basis kode Java
  * 🌊 – basis kode C/C++
* lingkup
  * ☁️ - Layanan Cloud
  * 🏠 - Layanan Lokal
  * 📟 - Sistem Tertanam
* sistem operasi
  * 🍎 – Untuk macOS
  * 🪟 – Untuk Windows
  * 🐧 - Untuk Linux

> [!NOTE]
> Bingung tentang Lokal 🏠 vs Cloud ☁️?
> * Gunakan lokal ketika server MCP berkomunikasi dengan perangkat lunak yang terinstal secara lokal, misal mengendalikan browser Chrome.
> * Gunakan network ketika server MCP berkomunikasi dengan API jarak jauh, misal API cuaca.

## Implementasi Server

> [!NOTE]
> Kami sekarang memiliki [direktori berbasis web](https://glama.ai/mcp/servers) yang tersinkronisasi dengan repositori.

* 🔗 - [Aggregator](#aggregators)
* 🎨 - [Seni & Budaya](#art-and-culture)
* 📂 - [Otomasi Browser](#browser-automation)
* ☁️ - [Platform Cloud](#cloud-platforms)
* 👨‍💻 - [Eksekusi Kode](#code-execution)
* 🤖 - [Agen Koding](#coding-agents)
* 🖥️ - [Command Line](#command-line)
* 💬 - [Komunikasi](#communication)
* 👤 - [Platform Data Pelanggan](#customer-data-platforms)
* 🗄️ - [Basis Data](#databases)
* 📊 - [Platform Data](#data-platforms)
* 🚚 - [Pengiriman](#delivery)
* 🛠️ - [Alat Pengembang](#developer-tools)
* 🧮 - [Alat Data Sains](#data-science-tools)
* 📟 - [Sistem Tertanam](#embedded-system)
* 📂 - [Sistem File](#file-systems)
* 💰 - [Keuangan & Fintech](#finance--fintech)
* 🎮 - [Permainan](#gaming)
* 🧠 - [Pengetahuan & Memori](#knowledge--memory)
* 🗺️ - [Layanan Lokasi](#location-services)
* 🎯 - [Pemasaran](#marketing)
* 📊 - [Monitoring](#monitoring)
* 🎥 - [Proses Multimedia](#multimedia-process)
* 🔎 - [Pencarian & Ekstraksi Data](#search)
* 🔒 - [Keamanan](#security)
* 🌐 - [Media Sosial](#social-media)
* 🏃 - [Olahraga](#sports)
* 🎧 - [Manajemen Dukungan & Layanan](#support-and-service-management)
* 🌎 - [Layanan Penerjemahan](#translation-services)
* 🎧 - [Teks ke Ucapan](#text-to-speech)
* 🚆 - [Perjalanan & Transportasi](#travel-and-transportation)
* 🔄 - [Kontrol Versi](#version-control)
* 🛠️ - [Alat & Integrasi Lainnya](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>Pengagregasi

Server untuk mengakses banyak aplikasi dan alat melalui satu server MCP.

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - Query lebih dari 40 aplikasi dengan satu binary menggunakan SQL. Juga dapat terhubung ke database yang kompatibel dengan PostgreSQL, MySQL, atau SQLite. Lokal-utama dan privat secara desain.
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP adalah satu server middleware MCP terpadu yang mengelola koneksi MCP Anda dengan antarmuka GUI.
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - Hubungkan dan satukan data di berbagai platform dan database dengan [MindsDB sebagai satu server MCP](https://docs.mindsdb.com/mcp/overview).
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - Daftar server MCP sehingga Anda dapat menanyakan ke klien server mana yang dapat digunakan untuk meningkatkan alur kerja harian Anda.
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - Ubah API web menjadi server MCP dalam 10 detik dan tambahkan ke registry open source: https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - Terhubung dengan 2.500 API dengan 8.000+ alat siap pakai, dan kelola server untuk pengguna Anda, di aplikasi Anda sendiri.
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - Server proxy komprehensif yang menggabungkan beberapa server MCP ke dalam satu antarmuka dengan fitur visibilitas ekstensif. Menyediakan penemuan dan manajemen alat, prompt, sumber daya, dan template di seluruh server, serta playground untuk debugging saat membangun server MCP.
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - Alat proxy untuk menggabungkan beberapa server MCP menjadi satu endpoint terpadu. Skala alat AI Anda dengan membagi beban permintaan ke beberapa server MCP, mirip seperti Nginx untuk web server.
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP adalah satu server middleware MCP terpadu yang mengelola koneksi MCP Anda dengan antarmuka GUI.
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - Hubungkan Claude Desktop dan host MCP lainnya secara mulus dan aman ke aplikasi favorit Anda (Notion, Slack, Monday, Airtable, dll). Kurang dari 90 detik.
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - Ubah layanan web menjadi server MCP hanya dengan satu klik tanpa mengubah kode apa pun.
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - Alat pembuatan gambar yang kuat menggunakan API Imagen 3.0 dari Google melalui MCP. Hasilkan gambar berkualitas tinggi dari prompt teks dengan kontrol fotografi, artistik, dan fotorealistik tingkat lanjut.
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - Server MCP untuk pembuatan/edit gambar OpenAI GPT.

### 🎨 <a name="art-and-culture"></a>Seni & Budaya

Akses dan jelajahi koleksi seni, warisan budaya, dan basis data museum. Memungkinkan model AI untuk mencari dan menganalisis konten artistik dan budaya.

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - Server MCP lokal yang menghasilkan animasi menggunakan Manim.
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - Tambah, Analisis, Cari, dan Hasilkan Edit Video dari Koleksi Video Jungle Anda
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - Server MCP untuk berinteraksi dengan API Discogs
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ Server MCP untuk berinteraksi dengan korpus Quran.com melalui REST API resmi v4.
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - Integrasi API Koleksi Metropolitan Museum of Art untuk mencari dan menampilkan karya seni dalam koleksi.
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - Integrasi API Rijksmuseum untuk pencarian karya seni, detail, dan koleksi
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - Integrasi API Oorlogsbronnen (Sumber Perang) untuk mengakses catatan sejarah, foto, dan dokumen Perang Dunia II dari Belanda (1940-1945)
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - Integrasi server MCP untuk DaVinci Resolve yang menyediakan alat kuat untuk pengeditan video, color grading, manajemen media, dan kontrol proyek
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - Server MCP yang mengintegrasikan API AniList untuk informasi anime dan manga
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - Server MCP menggunakan API Aseprite untuk membuat pixel art
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - Server MCP dan ekstensi yang memungkinkan kontrol bahasa alami NVIDIA Isaac Sim, Lab, OpenUSD, dll.
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - Server MCP untuk API Open Library yang memungkinkan asisten AI mencari informasi buku. 
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - Server MCP untuk Autodesk Maya
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - Menyediakan charting dan analisis Bazi (Astrologi Tiongkok) yang komprehensif dan akurat


### 📂 <a name="browser-automation"></aOtomasi Browser

Akses konten web dan kapabilitas otomasi. Memungkinkan pencarian, scraping, dan pemrosesan konten web dalam format ramah AI.

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - Alat berbasis FastMCP yang mengambil video trending Bilibili dan mengeksposnya melalui antarmuka MCP standar.
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - Server MCP yang mendukung pencarian konten Bilibili. Menyediakan contoh integrasi LangChain dan skrip pengujian.
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - Browser self-hosted menggunakan agen dengan MCP bawaan dan dukungan A2A.
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - Server MCP untuk otomasi browser menggunakan Playwright
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - Server MCP python menggunakan Playwright untuk otomasi browser, lebih cocok untuk llm
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - Otomasi interaksi browser di cloud (misalnya navigasi web, ekstraksi data, pengisian formulir, dan lainnya)
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - Otomasi browser Chrome lokal Anda
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-use dikemas sebagai server MCP dengan transport SSE. termasuk dockerfile untuk menjalankan chromium di docker + server vnc.
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - Server MCP menggunakan Playwright untuk otomasi browser dan webscrapping
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - Server MCP yang dipasangkan dengan ekstensi browser yang memungkinkan klien LLM mengontrol browser pengguna (Firefox).
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - Server MCP untuk berinteraksi dengan Apple Reminders di macOS
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - Ekstrak data terstruktur dari situs web mana pun. Tinggal prompt dan dapatkan JSON.
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - Ambil subtitle dan transkrip YouTube untuk analisis AI
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - Implementasi server/klien MCP `minimal` menggunakan Azure OpenAI dan Playwright.
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - Server MCP Playwright resmi Microsoft, memungkinkan LLM berinteraksi dengan halaman web melalui snapshot aksesibilitas terstruktur
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - Otomasi browser untuk web scraping dan interaksi
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - Server MCP untuk berinteraksi dengan browser yang kompatibel manifest v2.
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - Server MCP yang memungkinkan pencarian web gratis menggunakan hasil pencarian Google, tanpa perlu API key.
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - Integrasi Server MCP dengan Apple Shortcuts

### ☁️ <a name="cloud-platforms"></a>Platform Cloud

Integrasi layanan platform cloud. Memungkinkan manajemen dan interaksi dengan infrastruktur serta layanan cloud.

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - Server MCP AWS untuk integrasi mulus dengan layanan dan sumber daya AWS.
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - MCP yang dibangun di atas produk Qiniu Cloud, mendukung akses ke Qiniu Cloud Storage, layanan pemrosesan media, dll.
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - upload dan manipulasi penyimpanan IPFS
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - Server Kubernetes Model Context Protocol (MCP) yang menyediakan alat untuk berinteraksi dengan klaster Kubernetes melalui antarmuka standar, termasuk penemuan API resource, manajemen resource, log pod, metrik, dan event.
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - Server MCP untuk query buku, dan dapat digunakan di klien MCP umum seperti Cherry Studio.
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - Server ringan namun kuat yang memungkinkan asisten AI menjalankan perintah AWS CLI, menggunakan Unix pipes, dan menerapkan template prompt untuk tugas AWS umum di lingkungan Docker yang aman dengan dukungan multi-arsitektur
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - Server ringan namun tangguh yang memberdayakan asisten AI untuk menjalankan perintah Kubernetes CLI (`kubectl`, `helm`, `istioctl`, dan `argocd`) secara aman menggunakan Unix pipes di lingkungan Docker dengan dukungan multi-arsitektur.
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - Server MCP yang memungkinkan asisten AI mengoperasikan sumber daya di Alibaba Cloud, mendukung ECS, Cloud Monitor, OOS, dan produk cloud yang banyak digunakan.  
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - Server manajemen VMware ESXi/vCenter berbasis MCP (Model Control Protocol), menyediakan REST API sederhana untuk manajemen mesin virtual.
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - Integrasi dengan layanan Cloudflare termasuk Workers, KV, R2, dan D1
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - Server MCP yang memungkinkan agen AI mengelola sumber daya Kubernetes melalui abstraksi Cyclops
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - Integrasi dengan layanan Fastly
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - Implementasi Typescript untuk operasi klaster Kubernetes pada pod, deployment, layanan.
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - Server Model Context Protocol untuk query dan analisis sumber daya Azure secara skala menggunakan Azure Resource Graph, memungkinkan asisten AI mengeksplorasi dan memonitor infrastruktur Azure.
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Pembungkus CLI Azure yang memungkinkan Anda berbicara langsung ke Azure
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - MCP untuk memberikan akses ke semua komponen Netskope Private Access dalam lingkungan Netskope Private Access termasuk informasi setup detail dan contoh penggunaan LLM.
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 - Server Kubernetes MCP yang kuat dengan dukungan tambahan untuk OpenShift. Selain menyediakan operasi CRUD untuk **semua** resource Kubernetes, server ini juga menyediakan alat khusus untuk interaksi dengan klaster Anda.
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - Server Terraform MCP yang memungkinkan asisten AI mengelola dan mengoperasikan lingkungan Terraform, termasuk membaca konfigurasi, menganalisis rencana, menerapkan konfigurasi, dan mengelola status Terraform.
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - Server MCP untuk berinteraksi dengan Pulumi menggunakan Pulumi Automation API dan Pulumi Cloud API. Memungkinkan klien MCP melakukan operasi Pulumi seperti mengambil informasi paket, preview perubahan, melakukan update deployment, dan mengambil output stack secara terprogram.
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - Server Model Context Protocol (MCP) untuk Kubernetes yang memungkinkan asisten AI seperti Claude, Cursor, dan lainnya untuk berinteraksi dengan klaster Kubernetes melalui bahasa alami.
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - Operasi klaster Kubernetes melalui MCP
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - Server MCP berbasis Go untuk mengakses sumber daya Nutanix Prism Central.
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - Dapatkan informasi harga EC2 terbaru dengan satu panggilan. Cepat. Didukung katalog harga AWS yang sudah diparse.
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - Menyediakan manajemen dan operasi Kubernetes multi-klaster MCP, dengan antarmuka manajemen, logging, dan hampir 50 alat bawaan untuk skenario DevOps dan pengembangan umum. Mendukung resource standar dan CRD.
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - Menyediakan manajemen dan operasi Kubernetes multi-klaster MCP. Dapat diintegrasikan sebagai SDK ke proyek Anda sendiri dan mencakup hampir 50 alat bawaan untuk skenario DevOps dan pengembangan umum. Mendukung resource standar dan CRD.
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - MCP Server untuk manajemen Kubernetes, dan menganalisis klaster serta kesehatan aplikasi Anda
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - MCP Server untuk Azure Data Lake Storage. Dapat melakukan pengelolaan kontainer, operasi baca/tulis/unggah/unduh pada file kontainer, dan mengelola metadata file.
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S adalah alat manajemen sumber daya Kubernetes berbasis AI yang memungkinkan pengguna mengoperasikan sumber daya apa pun di klaster Kubernetes melalui interaksi bahasa alami, termasuk sumber daya native (seperti Deployment, Service) dan sumber daya kustom (CRD). Tidak perlu mengingat perintah yang rumit - cukup deskripsikan kebutuhan Anda, dan AI akan mengeksekusi operasi klaster yang sesuai secara akurat, sehingga sangat meningkatkan kegunaan Kubernetes.
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - Kelola sumber daya Redis Cloud Anda dengan mudah menggunakan bahasa alami. Buat database, pantau langganan, dan konfigurasikan deployment cloud dengan perintah sederhana.
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - MCP server yang kuat yang memungkinkan asisten AI berinteraksi secara mulus dengan instance Portainer, memberikan akses bahasa alami ke manajemen kontainer, operasi deployment, dan kemampuan pemantauan infrastruktur.

### 👨‍💻 <a name="code-execution"></a>Eksekusi Kode

Server eksekusi kode. Memungkinkan LLM untuk mengeksekusi kode di lingkungan yang aman, misalnya untuk agen pengkodean.

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- Jalankan kode Python di sandbox yang aman melalui pemanggilan alat MCP
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - Eksekusi kode apa pun yang dihasilkan LLM di lingkungan sandbox yang aman dan skalabel serta buat alat MCP Anda sendiri menggunakan JavaScript atau Python, dengan dukungan penuh untuk paket NPM dan PyPI
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP: MCP Server berbasis Docker untuk memungkinkan agen AI Anda mengakses API apa pun dengan dokumen API yang sudah ada.
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – MCP server Node.js yang membuat sandbox berbasis Docker terisolasi untuk menjalankan potongan kode JavaScript dengan instalasi dependensi npm secara langsung dan pembersihan otomatis
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - Sandbox eksekusi kode Javascript yang menggunakan v8 untuk mengisolasi kode sehingga dapat menjalankan JavaScript yang dihasilkan AI secara lokal tanpa rasa takut. Mendukung heap snapshotting untuk sesi yang persisten.

### 🤖 <a name="coding-agents"></a>Agen Pengkodean

Agen pengkodean penuh yang memungkinkan LLM membaca, mengedit, dan mengeksekusi kode serta menyelesaikan tugas pemrograman umum secara otonom.

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - Agen pengkodean lengkap yang mengandalkan operasi kode simbolik menggunakan language server.
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - Agen pengkodean dengan alat baca, tulis, dan command line dasar.
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - MCP server yang memungkinkan model AI mencari, mengambil, dan menyelesaikan masalah LeetCode. Mendukung filter metadata, profil pengguna, pengiriman, dan akses data kontes.
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - MCP server yang memungkinkan akses otomatis ke masalah pemrograman **LeetCode**, solusi, pengiriman, dan data publik dengan autentikasi opsional untuk fitur spesifik pengguna (misal, catatan), mendukung situs `leetcode.com` (global) dan `leetcode.cn` (China).
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - MCP Server yang memungkinkan AI seperti Claude membaca struktur direktori di workspace VS Code, melihat masalah yang terdeteksi linter atau language server, membaca file kode, dan melakukan pengeditan.
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - MCP server berbentuk satu binary yang mengubah kode sumber menjadi AST, terlepas dari bahasanya.

### 🖥️ <a name="command-line"></a>Command Line

Menjalankan perintah, menangkap output, dan berinteraksi dengan shell serta alat baris perintah lainnya.

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - Server Model Context Protocol yang menyediakan akses ke iTerm. Anda dapat menjalankan perintah dan mengajukan pertanyaan tentang apa yang Anda lihat di terminal iTerm.
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - Jalankan perintah apa pun dengan alat `run_command` dan `run_script`.
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - Interpreter Python yang aman berbasis HF Smolagents `LocalPythonExecutor`
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - Antarmuka command line dengan eksekusi aman dan kebijakan keamanan yang dapat dikustomisasi
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - DeepSeek MCP-like Server untuk Terminal
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - Server eksekusi perintah shell yang aman yang mengimplementasikan Model Context Protocol (MCP)
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - Server Cisco pyATS yang memungkinkan interaksi terstruktur, berbasis model dengan perangkat jaringan.
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - Swiss-army-knife yang dapat mengelola/menjalankan program dan membaca/menulis/mencari/mengedit file kode dan teks.
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - MCP server yang mengekspos kontrol SSH untuk server Linux dan Windows melalui Model Context Protocol. Jalankan perintah shell jarak jauh secara aman dengan autentikasi kata sandi atau kunci SSH.

### 💬 <a name="communication"></a>Komunikasi

Integrasi dengan platform komunikasi untuk manajemen pesan dan operasi kanal. Memungkinkan model AI berinteraksi dengan alat komunikasi tim.

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - Server Nostr MCP yang memungkinkan interaksi dengan Nostr, termasuk mengirim catatan, dan lainnya.
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - Berinteraksi dengan pencarian dan timeline Twitter
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - MCP server untuk membuat inbox secara instan untuk mengirim, menerima, dan melakukan aksi pada email. Kami bukan agen AI untuk email, tapi email untuk Agen AI.
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - MCP server untuk berinteraksi dengan Google Tasks API
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - MCP server yang terhubung aman ke database iMessage Anda melalui Model Context Protocol (MCP), memungkinkan LLM melakukan query dan menganalisis percakapan iMessage. Termasuk validasi nomor telepon yang kuat, pemrosesan lampiran, manajemen kontak, penanganan grup chat, dan dukungan penuh untuk mengirim dan menerima pesan.
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - Integrasi API Telegram untuk mengakses data pengguna, mengelola dialog (chat, kanal, grup), mengambil pesan, dan penanganan status baca
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - Integrasi API Telegram untuk mengakses data pengguna, mengelola dialog (chat, kanal, grup), mengambil pesan, mengirim pesan, dan penanganan status baca.
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - MCP server untuk Inbox Zero. Menambahkan fungsionalitas di atas Gmail seperti menemukan email mana yang perlu Anda balas atau tindak lanjuti.
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - Server MCP ntfy untuk mengirim/mengambil notifikasi ntfy ke server ntfy self-hosted Anda dari AI Agents 📤 (mendukung autentikasi token aman & lainnya - gunakan dengan npx atau docker!)
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - Aplikasi server MCP yang mengirim berbagai jenis pesan ke robot grup WeCom.
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - MCP server yang menyediakan akses aman ke database iMessage Anda melalui Model Context Protocol (MCP), memungkinkan LLM melakukan query dan menganalisis percakapan iMessage dengan validasi nomor telepon dan penanganan lampiran yang sesuai
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - MCP server yang bertindak sebagai adapter ke dalam ekosistem [ACP](https://agentcommunicationprotocol.dev). Mengekspos agen ACP ke klien MCP secara mulus, menjembatani komunikasi antara kedua protokol.
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - MCP server beserta MCP host yang memberikan akses ke tim, kanal, dan pesan Mattermost. MCP host terintegrasi sebagai bot di Mattermost dengan akses ke server MCP yang bisa dikonfigurasi.
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - MCP server untuk mencari pesan WhatsApp pribadi Anda, kontak, dan mengirim pesan ke individu atau grup
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - MCP Server untuk Integrasi LINE Official Account
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - Integrasi dengan gmail dan Google Calendar.
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - Integrasi instance Bluesky untuk query dan interaksi
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - Integrasi Slack workspace untuk manajemen kanal dan pengiriman pesan
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - MCP server terkuat untuk Slack Workspaces.
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 Ini adalah MCP server untuk berinteraksi dengan API VRChat. Anda dapat mengambil informasi tentang teman, dunia, avatar, dan lainnya di VRChat.
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - MCP server untuk berinteraksi dengan Google Calendar API. Berbasis TypeScript.
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - MCP server yang membuat Anda tetap mendapat informasi dengan mengirimkan notifikasi ke ponsel menggunakan ntfy
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - MCP server untuk [DIDLogic](https://didlogic.com). Menambahkan fungsionalitas untuk mengelola endpoint SIP, nomor dan tujuan.
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - MCP server untuk Mengelola Google Tasks
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - MCP server yang mengintegrasikan pesan Microsoft Teams (baca, posting, mention, daftar anggota dan thread)
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - MCP server yang terhubung ke seluruh suite Microsoft 365 menggunakan Graph API (termasuk email, file, Excel, kalender)
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - MCP server untuk WhatsApp Business Platform oleh YCloud.
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - MCP server untuk Product Hunt. Berinteraksi dengan postingan trending, komentar, koleksi, pengguna, dan lainnya.


### 👤 <a name="customer-data-platforms"></a>Customer Data Platforms

Menyediakan akses ke profil pelanggan di dalam platform data pelanggan

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - Terhubung dengan [iaptic](https://www.iaptic.com) untuk bertanya tentang Pembelian Pelanggan Anda, data Transaksi, dan statistik Pendapatan Aplikasi.
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - Hubungkan Open Data apa pun ke LLM apa pun dengan Model Context Protocol.
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - MCP server untuk mengakses dan memperbarui profil pada server Apache Unomi CDP.
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - MCP server untuk berinteraksi dengan Tinybird Workspace dari klien MCP apa pun.
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - Server Model Context Protocol untuk menghasilkan chart visual menggunakan [AntV](https://github.com/antvis).

### 🗄️ <a name="databases"></a>Basis Data

Akses basis data yang aman dengan kemampuan inspeksi skema. Memungkinkan query dan analisis data dengan kontrol keamanan yang dapat dikonfigurasi termasuk akses hanya-baca.

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ -  Jelajahi [proyek Aiven Anda](https://go.aiven.io/mcp-server) dan berinteraksi dengan layanan PostgreSQL®, Apache Kafka®, ClickHouse®, dan OpenSearch®
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - Supabase MCP Server dengan dukungan eksekusi query SQL dan alat eksplorasi basis data
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - Layanan MCP untuk Tablestore, fitur termasuk penambahan dokumen, pencarian semantik dokumen berbasis vektor dan skalar, ramah RAG, dan serverless.
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - Integrasi database MySQL di NodeJS dengan kontrol akses yang dapat dikonfigurasi dan inspeksi skema
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – Server MCP database universal yang mendukung database mainstream.
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - Integrasi database TiDB dengan kemampuan inspeksi skema dan query
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - Semantic Engine untuk Model Context Protocol (MCP) Clients dan AI Agents
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - MCP dan MCP SSE Server yang secara otomatis menghasilkan API berdasarkan skema dan data basis data. Mendukung PostgreSQL, Clickhouse, MySQL, Snowflake, BigQuery, Supabase
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - Integrasi DICOM untuk query, membaca, dan memindahkan citra medis serta laporan dari PACS dan sistem lain yang sesuai DICOM.
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - Server Chroma MCP untuk mengakses instance Chroma lokal dan cloud untuk kemampuan retrieval
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - Integrasi database ClickHouse dengan kemampuan inspeksi skema dan query
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - Integrasi Confluent untuk berinteraksi dengan Confluent Kafka dan Confluent Cloud REST APIs.
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - Server MCP Couchbase menyediakan akses terpadu ke Capella cloud dan klaster mandiri untuk operasi dokumen, kueri SQL++, dan analisis data bahasa alami.
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - Implementasi MCP Server yang menyediakan interaksi dengan Elasticsearch.
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - MCP server all-in-one untuk pengembangan dan operasi Postgres, dengan alat untuk analisis performa, tuning, dan pemeriksaan kesehatan.
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - Trino MCP Server untuk melakukan kueri dan mengakses data dari Trino Clusters.
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - Implementasi Go dari server Model Context Protocol (MCP) untuk Trino.
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - Integrasi database MySQL dengan kontrol akses yang dapat dikonfigurasi, inspeksi skema, dan pedoman keamanan komprehensif.
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - Mendukung SSE, STDIO; tidak hanya terbatas pada fungsi CRUD MySQL; juga mencakup kemampuan analisis pengecualian database; mengontrol izin database berbasis peran; dan memudahkan pengembang memperluas alat dengan kustomisasi.
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - Integrasi database Airtable dengan inspeksi skema, kemampuan baca dan tulis.
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - Integrasi database Nocodb, kemampuan baca dan tulis.
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - Implementasi server untuk integrasi Google BigQuery yang memungkinkan akses langsung dan kemampuan kueri ke database BigQuery.
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - Integrasi database MySQL berbasis Node.js yang menyediakan operasi database MySQL yang aman.
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - Database ledger Fireproof dengan sinkronisasi multi-pengguna.
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – MCP server multi-database berperforma tinggi yang dibangun dengan Golang, mendukung MySQL & PostgreSQL (NoSQL akan segera hadir). Termasuk alat bawaan untuk eksekusi kueri, manajemen transaksi, eksplorasi skema, pembuatan kueri, dan analisis performa, dengan integrasi Cursor tanpa hambatan untuk alur kerja database yang lebih baik.
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDB Lens: MCP Server lengkap untuk Database MongoDB.
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - Layanan Firebase termasuk Auth, Firestore, dan Storage.
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - Integrasi database Convex untuk mengintrospeksi tabel, fungsi, dan menjalankan kueri satu kali ([Sumber](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts))
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - MCP server open source yang berfokus pada alat database yang mudah, cepat, dan aman.
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - MCP Server untuk melakukan kueri ke GreptimeDB.
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - MCP server yang menyediakan akses aman hanya-baca ke database SQLite melalui Model Context Protocol (MCP). Server ini dibangun dengan framework FastMCP, memungkinkan LLM menjelajah dan melakukan kueri ke database SQLite dengan fitur keamanan dan validasi kueri bawaan.
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - Menjalankan kueri terhadap InfluxDB OSS API v2.
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - Integrasi Snowflake yang mengimplementasikan operasi baca dan (opsional) tulis serta pelacakan insight.
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - Supabase MCP Server untuk mengelola dan membuat proyek serta organisasi di Supabase.
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - MCP server untuk Apache Kafka dan Timeplus. Dapat menampilkan daftar topik Kafka, mengambil pesan Kafka, menyimpan data Kafka secara lokal dan melakukan kueri data streaming dengan SQL melalui Timeplus.
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - Integrasi VikingDB dengan pengenalan koleksi dan indeks, penyimpanan vektor, dan kemampuan pencarian.
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - Model Context Protocol Server untuk MongoDB.
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - Integrasi database DuckDB dengan inspeksi skema dan kemampuan kueri.
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - Integrasi database BigQuery dengan inspeksi skema dan kemampuan kueri.
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - Terhubung ke database yang kompatibel dengan JDBC untuk melakukan kueri, insert, update, delete, dan lainnya.
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - Server Model Context Protocol (MCP) yang menyediakan kemampuan interaksi database SQLite secara komprehensif.
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - Memgraph MCP Server - termasuk alat untuk menjalankan kueri pada Memgraph dan sumber daya skema.
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - Integrasi database PostgreSQL dengan inspeksi skema dan kemampuan kueri.
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - Operasi database SQLite dengan fitur analisis bawaan.
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Model Context Protocol dengan Neo4j (Menjalankan kueri, Knowledge Graph Memory, Mengelola Instance Neo4j Aura).
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — MCP Server untuk membuat dan mengelola database Postgres menggunakan Neon Serverless Postgres.
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) MCP server untuk platform Postgres Nile - Mengelola dan melakukan kueri database Postgres, tenant, pengguna, dan autentikasi menggunakan LLM.
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - MCP server untuk konektivitas Sistem Manajemen Database (DBMS) generik melalui protokol Open Database Connectivity (ODBC).
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - MCP server untuk konektivitas DBMS generik melalui SQLAlchemy menggunakan Python ODBC (pyodbc).
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - Melakukan kueri dan analisis database Azure Data Explorer.
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ -  Melakukan kueri dan analisis Prometheus, sistem monitoring open-source.
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - Memberikan kemampuan LLM untuk mengelola database Prisma Postgres (misal: membuat instance database baru atau menjalankan migrasi skema).
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - Server MCP untuk Qdrant.
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - Integrasi MongoDB yang memungkinkan LLM berinteraksi langsung dengan database.
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - Hubungkan alat AI langsung ke Airtable. Kueri, buat, perbarui, dan hapus record menggunakan bahasa alami. Fitur meliputi manajemen base, operasi tabel, manipulasi skema, filter record, dan migrasi data melalui antarmuka MCP standar.
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - Redis MCP Server resmi menawarkan antarmuka untuk mengelola dan mencari data di Redis.
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - Integrasi database universal berbasis SQLAlchemy yang mendukung PostgreSQL, MySQL, MariaDB, SQLite, Oracle, MS SQL Server dan masih banyak lagi. Fitur inspeksi skema dan relasi, serta kemampuan analisis dataset besar.
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - Integrasi Pinecone dengan kemampuan pencarian vektor.
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - Serverless MariaDB Cloud DB MCP server. Alat untuk menjalankan, menghapus, eksekusi SQL, dan bekerja dengan agen AI tingkat DB untuk text-2-sql dan percakapan yang akurat.
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - Supabase MCP server resmi untuk menghubungkan asisten AI langsung dengan proyek Supabase Anda dan memungkinkan mereka melakukan tugas seperti mengelola tabel, mengambil konfigurasi, dan melakukan kueri data.
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 MCP server database universal yang mendukung berbagai tipe database termasuk PostgreSQL, Redshift, CockroachDB, MySQL, RDS MySQL, Microsoft SQL Server, BigQuery, Oracle DB, dan SQLite.
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - Integrasi database TDolphinDB dengan inspeksi skema dan kemampuan kueri.
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - MCP Server untuk terhubung ke koleksi Weaviate Anda sebagai basis pengetahuan serta menggunakan Weaviate sebagai memori chat.
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — MCP server yang mendukung pengambilan data dari database menggunakan kueri bahasa alami, didukung oleh XiyanSQL sebagai LLM text-to-SQL.
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - Server Model Context Protocol untuk berinteraksi dengan Google Sheets. Server ini menyediakan alat untuk membuat, membaca, memperbarui, dan mengelola spreadsheet melalui Google Sheets API.
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - MCP server untuk integrasi Google Sheets API dengan kemampuan membaca, menulis, memformat, dan manajemen sheet yang komprehensif.
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – MySQL MCP server yang mudah digunakan, tanpa dependensi, dibangun dengan Golang, dengan mode hanya-baca yang dapat dikonfigurasi dan inspeksi skema.
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - MCP server untuk berinteraksi dengan database [YDB](https://ydb.tech)
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - MCP Server untuk Milvus / Zilliz, memungkinkan interaksi dengan database Anda.
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - MCP server untuk konektivitas Sistem Manajemen Database (DBMS) generik melalui protokol Java Database Connectivity (JDBC).
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - MCP server untuk berinteraksi dengan database VictoriaMetrics.
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - Integrasi datalake time-series Hydrolix yang menyediakan eksplorasi skema dan kemampuan kueri untuk alur kerja berbasis LLM.
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 – Server mysql mcp yang mudah digunakan, hanya-baca untuk cursor dan n8n...


### 📊 <a name="data-platforms"></a>Platform Data

Platform Data untuk integrasi data, transformasi, dan orkestrasi pipeline.

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - Berinteraksi dengan Flowcore untuk melakukan aksi, mengimpor data, serta menganalisis, mereferensi silang, dan memanfaatkan data apa pun di data core Anda, atau di data core publik; semua dengan bahasa manusia.
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - Terhubung ke API Databricks, memungkinkan LLM menjalankan kueri SQL, daftar pekerjaan, dan mendapatkan status pekerjaan.
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - Server yang terhubung ke Databricks Genie API, memungkinkan LLM untuk mengajukan pertanyaan dengan bahasa alami, menjalankan kueri SQL, dan berinteraksi dengan agen percakapan Databricks.
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - MCP Server untuk Qlik Cloud API yang memungkinkan kueri aplikasi, sheet, dan ekstraksi data dari visualisasi dengan dukungan autentikasi dan pembatasan rate yang komprehensif.
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - berinteraksi dengan Keboola Connection Data Platform. Server ini menyediakan alat untuk menampilkan daftar dan mengakses data dari Keboola Storage API.
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - MCP server resmi untuk [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt) yang menyediakan integrasi dengan dbt Core/Cloud CLI, penemuan metadata proyek, informasi model, dan kemampuan kueri semantic layer.
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - MCP server untuk pengguna dbt-core (OSS) karena dbt MCP resmi hanya mendukung dbt Cloud. Mendukung metadata proyek, lineage model dan kolom, serta dokumentasi dbt.

### 💻 <a name="developer-tools"></a>Alat Pengembang

Alat dan integrasi yang meningkatkan alur kerja pengembangan dan manajemen lingkungan.

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - Mengidentifikasi proses yang memakan banyak sumber daya di macOS dan memberikan saran peningkatan kinerja.
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - Membuat komponen UI yang dirancang khusus terinspirasi oleh insinyur desain terbaik 21st.dev.
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - Integrasi dengan sistem manajemen tes [QA Sphere](https://qasphere.com/), memungkinkan LLM menemukan, merangkum, dan berinteraksi langsung dengan kasus uji dari IDE bertenaga AI
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - Menganalisis basis kode Anda dengan mengidentifikasi file penting berdasarkan hubungan dependensi. Menghasilkan diagram dan skor kepentingan, membantu asisten AI memahami basis kode.
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 Implementasi server MCP untuk kontrol iOS Simulator.
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 MCP Server yang mendukung kueri dan manajemen semua sumber daya di [Apache APISIX](https://github.com/apache/apisix).
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 -  Server Model Context Protocol (MCP) yang menyediakan alat untuk mengambil informasi proyek SonarQube seperti metrik (aktual dan historis), masalah, status kesehatan.
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - Integrasi API apa pun dengan Agen AI secara mulus (dengan OpenAPI Schema)
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - Menganalisis kode React secara lokal, menghasilkan dokumen / llm.txt untuk seluruh proyek sekaligus
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - MCP server untuk POX SDN controller yang menyediakan kemampuan kontrol dan manajemen jaringan.
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - MCP server resmi untuk CodeLogic, menyediakan akses ke analitik dependensi kode, analisis risiko arsitektur, dan alat penilaian dampak.
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - Gunakan bahasa alami untuk mengeksplorasi observabilitas LLM, jejak, dan data monitoring yang ditangkap oleh Opik.
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ Memungkinkan Agen AI memperbaiki kegagalan build dari CircleCI.
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ Memungkinkan Agen AI memperbaiki kegagalan tes Playwright yang dilaporkan ke [Currents](https://currents.dev).
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - Berinteraksi dengan [Postman API](https://www.postman.com/postman/postman-public-workspace/)
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - Memungkinkan asisten AI berinteraksi dengan feature flag Anda di [Flipt](https://flipt.io).
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - Memberikan agen coding akses langsung ke data Figma untuk membantu mereka mengimplementasikan desain satu kali.
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - Mengintegrasikan, menemukan, mengelola, dan mengkodifikasi sumber daya cloud dengan [Firefly](https://firefly.ai).
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - Menyediakan konteks dokumentasi terbaru untuk crate Rust tertentu ke LLM melalui alat MCP, menggunakan pencarian semantik (embedding) dan ringkasan LLM.
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - Server manipulasi Excel yang menyediakan pembuatan workbook, operasi data, pemformatan, dan fitur lanjutan (chart, pivot table, formula).
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - Server MCP yang menyediakan alat komprehensif untuk mengelola konfigurasi dan operasi gateway [Higress](https://github.com/alibaba/higress).
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - Sebuah server MCP untuk menggantikan Rest Clients seperti Postman/Insomnia, dengan memungkinkan LLM Anda untuk memelihara dan menggunakan koleksi API.
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - Server MCP untuk berinteraksi dengan [Go's Language Server Protocol (gopls)](https://github.com/golang/tools/tree/master/gopls) dan memanfaatkan fitur analisis kode Go tingkat lanjut.
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - Server MCP untuk berinteraksi dengan [Bruno API Client](https://www.usebruno.com/).
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - Kontrol perangkat Android dengan AI melalui MCP, memungkinkan kontrol perangkat, debugging, analisis sistem, dan otomasi UI dengan kerangka keamanan menyeluruh.
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - Kontrol perangkat HarmonyOS-next dengan AI melalui MCP. Mendukung kontrol perangkat dan otomasi UI.
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - Integrasi Gradle menggunakan Gradle Tooling API untuk menginspeksi proyek, menjalankan tugas, dan menjalankan pengujian dengan pelaporan hasil per pengujian.
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - Server MCP untuk kompresi lokal berbagai format gambar.
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - MCP Language Server membantu klien yang mendukung MCP menavigasi basis kode dengan lebih mudah dengan memberikan akses ke alat semantik seperti get definition, references, rename, dan diagnostics.
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - Server Model Context Protocol (MCP) untuk berinteraksi dengan simulator iOS. Server ini memungkinkan Anda untuk mendapatkan informasi tentang simulator, mengontrol interaksi UI, dan memeriksa elemen UI.
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - Server Model Context Protocol (MCP) yang memungkinkan LLM berinteraksi dengan simulator iOS (iPhone, iPad, dll.) melalui perintah bahasa alami.
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - Server Model Context Protocol (MCP) yang menyediakan pencarian dan kemampuan query berbasis AI untuk dokumentasi Vercel AI SDK.
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - Server MCP yang menyediakan analisis SQL, linting, dan konversi dialek menggunakan [SQLGlot](https://github.com/tobymao/sqlglot).
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - Server MCP dan Ekstensi VS Code yang memungkinkan debugging otomatis (agnostik bahasa) melalui breakpoint dan evaluasi ekspresi.
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - Terhubung ke JetBrains IDE.
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - Server MCP JMeter untuk pengujian performa.
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - Server MCP pribadi untuk menyimpan dan mengakses kunci API secara aman di seluruh proyek menggunakan macOS Keychain.
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - Server MCP untuk berkomunikasi dengan API App Store Connect untuk pengembang iOS.
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - Server MCP untuk mengontrol iOS Simulators.
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - Server MCP Grafana k6 untuk pengujian performa.
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - Server middleware yang memungkinkan beberapa instance terisolasi dari server MCP yang sama untuk hidup berdampingan secara independen dengan namespace dan konfigurasi unik.
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - Server MCP untuk mengakses dan mengelola prompt aplikasi LLM yang dibuat dengan [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) Prompt Management.
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - Server MCP untuk otomasi aplikasi dan perangkat Android/iOS, pengembangan dan scraping aplikasi. Mendukung Simulator/Emulator/Perangkat fisik seperti iPhone, Google Pixel, Samsung.
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - Server MCP Locust untuk pengujian performa.
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - Server MCP sederhana untuk memungkinkan workflow human-in-the-loop di alat seperti Cline dan Cursor.
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - Server MCP yang menggunakan [gitingest](https://github.com/cyclotruc/gitingest) untuk mengubah repositori Git menjadi ringkasan teks sederhana dari basis kode.
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - memungkinkan agen AI favorit Anda membuat & menjalankan [Octomind](https://www.octomind.dev/) end-to-end tests yang dikelola penuh dari basis kode atau sumber data lain seperti Jira, Slack, atau TestRail.
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - Akses hemat token ke spesifikasi OpenAPI/Swagger melalui MCP Resources.
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - Server MCP ini menyediakan alat untuk mengunduh seluruh situs web menggunakan wget. Struktur website dipertahankan dan tautan diubah agar berfungsi secara lokal.
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - Server MCP yang menyediakan informasi akurat tentang paket NixOS, opsi sistem, konfigurasi Home Manager, dan pengaturan nix-darwin macOS untuk mencegah halusinasi AI.
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - Manajemen dan operasi container Docker melalui MCP.
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - Integrasi dengan Docker untuk mengelola container, image, volume, dan network.
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - Integrasi Xcode untuk manajemen proyek, operasi file, dan otomasi build.
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - Server MCP yang memungkinkan LLM mengetahui segalanya tentang spesifikasi OpenAPI Anda untuk penemuan, penjelasan, dan generasi kode/data tiruan.
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - Server MCP untuk platform manajemen insiden [Rootly](https://rootly.com/).
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - Server MCP untuk membantu LLM menyarankan versi paket stabil terbaru saat menulis kode.
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - Server Model Context Protocol (MCP) yang terintegrasi dengan SonarQube untuk menyediakan akses asisten AI ke metrik kualitas kode, isu, dan status quality gate.
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - Implementasi kapabilitas Claude Code menggunakan MCP, memungkinkan AI memahami, memodifikasi, dan menganalisis proyek kode dengan dukungan alat yang menyeluruh.
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - Hubungkan server API HTTP/REST apa pun menggunakan spesifikasi Open API (v3).
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - Server MCP untuk LLDB yang memungkinkan analisis binary dan core file AI, debugging, disassembling.
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - Layanan MCP untuk mendeloy konten HTML ke EdgeOne Pages dan memperoleh URL publik.
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - Editor file teks berbasis baris. Dioptimalkan untuk alat LLM dengan akses file parsial yang efisien untuk meminimalkan penggunaan token.
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - Server MCP untuk konversi format dokumen secara mulus menggunakan Pandoc, mendukung Markdown, HTML, PDF, DOCX (.docx), csv dan lainnya.
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - Terhubung ke ide VSCode dan gunakan alat semantik seperti `find_usages`
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 Membangun workspace/proyek Xcode iOS dan mengumpan balik error ke llm.
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - Proyek implementasi server MCP (Model Context Protocol) berbasis JVM.
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - Server MCP yang terhubung ke [Apache Airflow](https://airflow.apache.org/) menggunakan klien resmi.
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - Server Model Context Protocol (MCP) untuk menghasilkan mindmap interaktif yang menarik.
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - Server Model Context Protocol (MCP) yang mengquery beberapa model Ollama dan menggabungkan responsnya, memberikan berbagai perspektif AI pada satu pertanyaan.
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - Server MCP yang menyediakan informasi API Typescript secara efisien kepada agen untuk memungkinkannya bekerja dengan API yang belum dilatih.
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - Server MCP untuk mengambil data JSON, teks, dan HTML secara fleksibel.
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - Server MCP untuk terhubung dengan pipeline MLOps dan LLMOps [ZenML](https://www.zenml.io).
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/) adalah server MCP jarak jauh generik untuk terhubung ke repositori atau proyek [GitHub](https://www.github.com) APA SAJA untuk dokumentasi.
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - Server MCP untuk berinteraksi dengan [Bugsnag](https://www.bugsnag.com/)
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - Server MCP untuk file CSV.
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – Sistem manajemen tugas berfokus pada pemrograman yang meningkatkan agen pengkodean seperti Cursor AI dengan memori tugas lanjutan, refleksi diri, dan manajemen dependensi. [ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - Server MCP untuk menjalankan kode secara lokal via Docker dan mendukung berbagai bahasa pemrograman.
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - Query informasi paket Go di pkg.go.dev
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - Library Go tanpa konfigurasi untuk secara otomatis mengekspos API framework web Gin sebagai alat MCP.
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - GitHub Repo MCP memungkinkan asisten AI Anda menjelajahi repositori GitHub, menelusuri direktori, dan melihat isi file.
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – Server berbasis FastMCP untuk berinteraksi dengan webhook-test.com. Memungkinkan pengguna membuat, mengambil, dan menghapus webhook secara lokal menggunakan Claude.
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - ROS MCP Server mendukung kontrol robot dengan mengubah perintah bahasa alami yang diberikan pengguna menjadi perintah kontrol ROS atau ROS2.
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - Server Globalping MCP menyediakan akses pengguna dan LLM untuk menjalankan alat jaringan seperti ping, traceroute, mtr, HTTP, dan DNS resolve dari ribuan lokasi di seluruh dunia.
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - Server MCP untuk berinteraksi dengan analitik PostHog, feature flags, pelacakan error, dan lainnya.
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - Server MCP untuk mencari dan mendapatkan informasi terbaru tentang paket NPM, Cargo, PyPi, dan NuGet.

### 🔒 <a name="delivery"></a>Delivery

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – DoorDash Delivery (Tidak Resmi)

### 🧮 <a name="data-science-tools"></a>Data Science Tools

Integrasi dan alat yang dirancang untuk menyederhanakan eksplorasi data, analisis, dan meningkatkan workflow data sains.

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - Prediksi apa saja dengan agen forecasting dan prediksi Chronulus AI.
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - Memungkinkan eksplorasi data secara otonom pada dataset berbasis .csv, memberikan wawasan cerdas dengan upaya minimal.
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - Server MCP untuk mengonversi hampir semua file atau konten web ke dalam Markdown.
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - Server Model Context Protocol (MCP) untuk Jupyter.
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - Menghubungkan Jupyter Notebook ke Claude AI, memungkinkan Claude untuk langsung berinteraksi dan mengontrol Jupyter Notebooks.
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - Terhubung ke Kaggle, kemampuan untuk mengunduh dan menganalisis dataset.
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - Hubungkan berbagai sumber data (SQL, CSV, Parquet, dll.) dan minta AI untuk menganalisis data untuk wawasan dan visualisasi.
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - Alat dan template untuk membuat chart dan dashboard data yang tervalidasi dan dapat dipelihara.
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — Alat untuk membuat dan berinteraksi dengan feature flag dan eksperimen GrowthBook.

### 📟 <a name="embedded-system"></a>Embedded System

Menyediakan akses ke dokumentasi dan shortcut untuk bekerja di perangkat embedded.

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - Workflow untuk memperbaiki masalah build pada chip seri ESP32 menggunakan ESP-IDF.
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - Server MCP yang menstandarkan dan mengontekstualisasikan data Modbus industri.
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - Server MCP yang terhubung ke sistem industri berkemampuan OPC UA.
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - Server MCP untuk GNU Radio yang memungkinkan LLM membuat dan memodifikasi flowchart RF `.grc` secara otonom.

### 📂 <a name="file-systems"></a>File Systems

Menyediakan akses langsung ke sistem file lokal dengan izin yang dapat dikonfigurasi. Memungkinkan model AI untuk membaca, menulis, dan mengelola file dalam direktori tertentu.

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - Berbagi konteks kode dengan LLM melalui MCP atau clipboard.
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - Alat penggabung file, cocok untuk batas panjang chat AI.
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - Filesystem yang memungkinkan browsing dan pengeditan file, diimplementasikan dalam Java menggunakan Quarkus. Tersedia sebagai jar atau native image.
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - Integrasi Box untuk menampilkan, membaca, dan mencari file
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - Pencarian file Windows cepat menggunakan Everything SDK
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - Implementasi Golang untuk akses sistem file lokal.
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - Akses Penyimpanan Jarak Jauh: SFTP, S3, FTP, SMB, NFS, WebDAV, GIT, FTPS, gcloud, azure blob, sharepoint, dll.
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - Akses alat MCP ke MarkItDown -- pustaka yang mengkonversi banyak format file (lokal atau remote) ke Markdown untuk konsumsi LLM.
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - Akses langsung ke sistem file lokal.
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - Integrasi Google Drive untuk menampilkan, membaca, dan mencari file
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - Akses ke penyimpanan apapun dengan Apache OpenDAL™
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - Kontrol setup Homebrew macOS Anda menggunakan bahasa alami melalui server MCP ini. Kelola paket Anda dengan mudah, atau minta saran, atasi masalah brew, dll.

### 💰 <a name="finance--fintech"></a>Keuangan & Fintech

Akses data keuangan dan alat analisis. Memungkinkan model AI bekerja dengan data pasar, platform trading, dan informasi keuangan.

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - Riset mendalam untuk kripto - gratis & sepenuhnya lokal
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - Memungkinkan agen AI berinteraksi dengan API blockchain Alchemy.
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - Agen AI Octagon untuk integrasi data pasar privat dan publik
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - Integrasi API Coinmarket untuk mengambil daftar dan kutipan cryptocurrency
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - Memungkinkan LLM AI mengeksekusi perdagangan menggunakan platform MetaTrader 5
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - MCP untuk antarmuka dengan berbagai blockchain, staking, DeFi, swap, bridging, manajemen dompet, DCA, Limit Orders, Coin Lookup, Tracking dan lainnya.
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - API Bankless Onchain untuk berinteraksi dengan smart contract, kueri informasi transaksi dan token
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - Integrasi Base Network untuk alat onchain, memungkinkan interaksi dengan Base Network dan Coinbase API untuk manajemen dompet, transfer dana, smart contract, dan operasi DeFi
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - Integrasi API Alpha Vantage untuk mengambil informasi saham dan kripto
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - Skor risiko / kepemilikan aset dari alamat blockchain EVM (EOA, CA, ENS) bahkan nama domain.
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - Integrasi Bitte Protocol untuk menjalankan Agen AI di beberapa blockchain.
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - MCP Server yang menghubungkan agen AI ke [Chargebee platform](https://www.chargebee.com/).
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - Integrasi [Codex API](https://www.codex.io) untuk data blockchain dan pasar real-time yang diperkaya di 60+ jaringan
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - Server MCP DexPaprika Coinpaprika mengekspos [DexPaprika API](https://docs.dexpaprika.com) berperforma tinggi yang meliputi 20+ chain dan 5M+ token dengan harga real-time, data pool likuiditas & data historis OHLCV, memberikan agen AI akses terstandarisasi ke data pasar komprehensif melalui Model Context Protocol.
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - Server MCP untuk mengakses data pasar kripto real-time dan trading melalui 20+ bursa menggunakan pustaka CCXT. Mendukung spot, futures, OHLCV, saldo, order, dan lainnya.
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - Integrasi Yahoo Finance untuk mengambil data pasar saham termasuk rekomendasi opsi
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - Integrasi API Tastyworks untuk menangani aktivitas trading di Tastytrade
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - Integrasi Reddit untuk menganalisis konten di komunitas WallStreetBets
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - Integrasi dompet Bitcoin Lightning didukung oleh Nostr Wallet Connect
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - Akses agen AI web3 khusus untuk analisis blockchain, audit keamanan smart contract, evaluasi metrik token, dan interaksi on-chain melalui jaringan Heurist Mesh. Menyediakan alat lengkap untuk analisis DeFi, valuasi NFT, dan pemantauan transaksi di berbagai blockchain
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper menyediakan transaksi di BSC, termasuk transfer saldo/token, swap token di Pancakeswap dan klaim reward beeper.
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ - Server MCP yang menyajikan berita blockchain dan artikel mendalam dari BlockBeats untuk agen AI.
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - Menyediakan data real-time tarif bridge cross-chain dan rute transfer optimal untuk agen AI onchain.
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ - Menyediakan akses real-time ke feeds harga on-chain terdesentralisasi Chainlink.
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ - Menyediakan akses real-time ke berita terbaru dari Cointelegraph.
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ - Menyediakan data Crypto Fear & Greed Index real-time dan historis.
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - Server MCP yang menyediakan beragam indikator dan strategi analisis teknikal cryptocurrency.
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - Server MCP yang menyediakan berita kripto real-time dari NewsData untuk agen AI.
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - Server MCP untuk melacak dan mengelola alokasi portofolio cryptocurrency.
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - Server MCP yang mengumpulkan berita kripto real-time dari berbagai feed RSS.
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - Server MCP yang menyajikan analisis sentimen cryptocurrency ke agen AI.
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - Melacak token trending terbaru di CoinGecko.
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - Berfungsi sebagai basis pengetahuan terstruktur whitepaper kripto.
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - Menyediakan berita kripto terbaru untuk agen AI, didukung oleh CryptoPanic.
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - Server MCP untuk agen AI mengeksplorasi peluang yield DeFi.
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ - Server MCP yang menjembatani data Dune Analytics ke agen AI.
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ - Menyajikan data aliran ETF kripto untuk mendukung pengambilan keputusan agen AI.
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - Server MCP yang terintegrasi dengan bot trading cryptocurrency Freqtrade.
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - Menyediakan data funding rate real-time di bursa kripto utama.
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - Server MCP untuk mengeksekusi swap token di blockchain Solana menggunakan Jupiter Ultra API.
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ - Server MCP yang melacak pool baru yang dibuat di Pancake Swap.
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - Server MCP yang mendeteksi potensi risiko pada token meme Solana.
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ - Server MCP yang memberdayakan agen AI dengan data blockchain terindeks dari The Graph.
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ - Server MCP yang menyediakan alat bagi agen AI untuk mencetak token ERC-20 di berbagai blockchain.
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - Server MCP untuk memeriksa dan mencabut izin token ERC-20 di berbagai blockchain.
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - Server MCP yang melacak perubahan historis username Twitter.
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ - Server MCP yang melacak pool likuiditas baru di Uniswap di berbagai blockchain.
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ - Server MCP untuk agen AI mengotomasi swap token di Uniswap DEX pada berbagai blockchain.
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ - Server MCP untuk melacak transaksi whale cryptocurrency.
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - Server MCP untuk Alpaca trading API guna mengelola portofolio saham dan kripto, melakukan transaksi, dan mengakses data pasar.
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI menyediakan data pasar saham real-time, memberikan akses analisis dan kemampuan trading AI melalui MCP.
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - Layanan blockchain komprehensif untuk 30+ jaringan EVM, mendukung token native, ERC20, NFT, smart contract, transaksi, dan resolusi ENS.
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - Integrasi blockchain Starknet komprehensif dengan dukungan token native (ETH, STRK), smart contract, resolusi StarknetID, dan transfer token.
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 - Integrasi ledger-cli untuk mengelola transaksi keuangan dan menghasilkan laporan.
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 - Integrasi core banking untuk mengelola klien, pinjaman, tabungan, saham, transaksi keuangan dan menghasilkan laporan keuangan.
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - Server MCP yang menggunakan yfinance untuk memperoleh informasi dari Yahoo Finance.
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ - Server MCP yang menyediakan akses ke API data pasar keuangan [Polygon.io](https://polygon.io/) untuk saham, indeks, forex, opsi, dan lainnya.
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ - API Bitget untuk mengambil harga cryptocurrency.
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - Integrasi data pasar cryptocurrency real-time menggunakan API publik CoinCap, memberikan akses ke harga kripto dan informasi pasar tanpa kunci API
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Alat MCP yang menyediakan data pasar cryptocurrency menggunakan CoinGecko API.
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - Versi TS dari yahoo finance mcp.
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Alat MCP yang menyediakan data dan analisis pasar saham menggunakan Yahoo Finance API.
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - Server MCP untuk XRP Ledger yang memberikan akses ke informasi akun, riwayat transaksi, dan data jaringan. Memungkinkan kueri objek ledger, mengirim transaksi, dan memonitor jaringan XRPL.
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - Harga pasar on-chain real-time menggunakan Dexscreener API terbuka dan gratis
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - Server MCP berbasis baostock, menyediakan akses dan kemampuan analisis data pasar saham China.
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - Alat MCP untuk kueri transaksi Solana menggunakan bahasa alami dengan Solscan API.
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - Server MCP yang berinteraksi dengan kemampuan platform CRIC Wuye AI, asisten cerdas khusus untuk industri manajemen properti.
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - Server MCP untuk mengakses data keuangan profesional, mendukung beberapa penyedia data seperti Tushare.

### 🎮 <a name="gaming"></a>Gaming

Integrasi dengan data terkait game, game engine, dan layanan

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - Server MCP untuk Unity Editor dan untuk game yang dibuat dengan Unity
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - Server MCP untuk integrasi Unity3d Game Engine dalam pengembangan game
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - Server MCP untuk berinteraksi dengan game engine Godot, menyediakan alat untuk mengedit, menjalankan, debug, dan mengelola scene dalam proyek Godot.
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - Akses data pemain Chess.com, catatan permainan, dan informasi publik lain melalui antarmuka MCP standar, memungkinkan asisten AI mencari dan menganalisis informasi catur.
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - Server MCP yang bermain catur melawan LLM.
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - Server MCP untuk data dan alat analisis real-time Fantasy Premier League.
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - Akses data gaming real-time lintas judul populer seperti League of Legends, TFT, dan Valorant, menawarkan analitik champion, jadwal esports, komposisi meta, dan statistik karakter.
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - Server MCP dengan alat untuk berinteraksi dengan data RuneScape (RS) dan Old School RuneScape (OSRS), termasuk harga item, hiscore pemain, dan lainnya.

### 🧠 <a name="knowledge--memory"></a>Pengetahuan & Memori

Penyimpanan memori persisten menggunakan struktur knowledge graph. Memungkinkan model AI untuk memelihara dan mengkueri informasi terstruktur lintas sesi.
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - Memori berbasis graf yang disempurnakan dengan fokus pada role-play AI dan pembuatan cerita
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - Memasukkan apa pun dari Slack, Discord, situs web, Google Drive, Linear, atau GitHub ke dalam proyek Graphlit - lalu mencari dan mengambil pengetahuan relevan di dalam klien MCP seperti Cursor, Windsurf, atau Cline.
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - Implementasi server MCP yang menyediakan alat untuk pengambilan dan pemrosesan dokumentasi melalui pencarian vektor, memungkinkan asisten AI memperkaya jawaban mereka dengan konteks dokumentasi yang relevan
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - Server MCP yang dibangun di atas [markmap](https://github.com/markmap/markmap) yang mengonversi **Markdown** menjadi **mind map** interaktif. Mendukung ekspor multi-format (PNG/JPG/SVG), pratinjau langsung di browser, salin Markdown sekali klik, dan fitur visualisasi dinamis.
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - Konektor untuk LLM agar dapat bekerja dengan koleksi dan sumber di Zotero Cloud Anda
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - Server MCP Ringkasan AI, Mendukung berbagai jenis konten: Teks polos, halaman web, dokumen PDF, buku EPUB, konten HTML
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - Server Model Context Protocol untuk Mem0 yang membantu mengelola preferensi dan pola pengkodean, menyediakan alat untuk menyimpan, mengambil, dan menangani implementasi kode, praktik terbaik, serta dokumentasi teknis secara semantik di IDE seperti Cursor dan Windsurf
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - Sistem memori persisten berbasis graph knowledge untuk menjaga konteks
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - Terhubung ke Pinecone Assistant Anda dan memberikan konteks agen dari mesin pengetahuannya.
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - Mengambil konteks dari basis pengetahuan [Ragie](https://www.ragie.ai) (RAG) Anda yang terhubung ke berbagai integrasi seperti Google Drive, Notion, JIRA, dan lainnya.
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - Membiarkan alat AI seperti Cursor, VS Code, atau Claude Desktop menjawab pertanyaan menggunakan dokumentasi produk Anda. Biel.ai menyediakan sistem RAG dan server MCP.
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - Manajer memori untuk aplikasi dan Agen AI menggunakan berbagai graph dan vector store serta memungkinkan pengambilan dari lebih dari 30 sumber data
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - Simpan dan query memori agen Anda secara terdistribusi melalui Membase
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - Gunakan GitHub Gists untuk mengelola dan mengakses pengetahuan pribadi, catatan harian, dan prompt yang dapat digunakan kembali. Ini bertindak sebagai pendamping untuk https://gistpad.dev dan [ekstensi GistPad VS Code](https://aka.ms/gistpad).
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - Server Model Context Protocol (MCP) yang mengimplementasikan metodologi manajemen pengetahuan Zettelkasten, memungkinkan Anda membuat, menautkan, dan mencari catatan atomik melalui Claude dan klien kompatibel MCP lainnya.

### 🗺️ <a name="location-services"></a>Layanan Lokasi

Layanan berbasis lokasi dan alat pemetaan. Memungkinkan model AI bekerja dengan data geografis, informasi cuaca, dan analitik berbasis lokasi.

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - Geolokasi alamat IP dan informasi jaringan menggunakan IPInfo API
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - Mengakses data cuaca real-time untuk lokasi mana pun menggunakan WeatherAPI.com API, menyediakan prakiraan terperinci dan kondisi terkini.
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - Server MCP OpenStreetMap dengan layanan berbasis lokasi dan data geospasial.
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - Server MCP untuk pencarian tempat terdekat dengan deteksi lokasi berbasis IP.
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - Integrasi Google Maps untuk layanan lokasi, rute, dan detail tempat
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - menghubungkan QGIS Desktop ke Claude AI melalui MCP. Integrasi ini memungkinkan pembuatan proyek berbantuan prompt, pemuatan layer, eksekusi kode, dan lainnya.
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - Alat MCP yang menyediakan data cuaca real-time, prakiraan, dan informasi cuaca historis menggunakan OpenWeatherMap API.
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - Server MCP Weekly Weather yang mengembalikan prakiraan cuaca rinci selama 7 hari penuh di mana saja di dunia.
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - Akses waktu di zona waktu mana saja dan dapatkan waktu lokal saat ini
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - Prakiraan cuaca akurat melalui AccuWeather API (tersedia paket gratis).
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - Server MCP geocoding untuk nominatim, ArcGIS, Bing
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - Layanan lokasi alamat IP menggunakan [IP Find](https://ipfind.com) API
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – Implementasi server Model Context Protocol (MCP) yang menghubungkan LLM ke GeoServer REST API, memungkinkan asisten AI berinteraksi dengan data dan layanan geospasial.
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – Server MCP untuk Aiwen IP Location, mendapatkan lokasi IP jaringan pengguna, detail IP (negara, provinsi, kota, lat, lon, ISP, pemilik, dll.)

### 🎯 <a name="marketing"></a>Pemasaran

Alat untuk membuat dan mengedit konten pemasaran, bekerja dengan metadata web, positioning produk, dan panduan pengeditan.

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - Server MCP sebagai antarmuka ke Facebook Ads, memungkinkan akses programatik ke data dan fitur manajemen Facebook Ads.
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - Paket alat pemasaran dari Open Strategy Partners termasuk gaya penulisan, kode pengeditan, dan pembuatan peta nilai pemasaran produk.
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - Memungkinkan agen AI memantau dan mengoptimalkan performa iklan Meta, menganalisis metrik kampanye, mengatur penargetan audiens, mengelola aset kreatif, serta memberikan rekomendasi berbasis data untuk pengeluaran iklan dan pengaturan kampanye melalui integrasi Graph API yang mulus.
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - Memungkinkan alat untuk berinteraksi dengan Amazon Advertising, menganalisis metrik dan konfigurasi kampanye.

### 📊 <a name="monitoring"></a>Pemantauan

Akses dan analisis data pemantauan aplikasi. Memungkinkan model AI meninjau laporan error dan metrik performa.

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - Penemuan, eksplorasi, pelaporan, dan analisis akar masalah menggunakan semua data observabilitas, termasuk metrik, log, sistem, kontainer, proses, dan koneksi jaringan
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - Cari dashboard, selidiki insiden dan query datasource di instance Grafana Anda
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - Server MCP yang memungkinkan query log Loki melalui Grafana API.
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - Meningkatkan kualitas kode yang dihasilkan AI melalui analisis cerdas berbasis prompt pada 10 dimensi kritis mulai dari kompleksitas hingga kerentanan keamanan
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - Membawa konteks produksi real-time—log, metrik, dan trace—ke lingkungan lokal Anda untuk memperbaiki kode secara otomatis dengan lebih cepat
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - Query dan interaksi dengan lingkungan Kubernetes yang dipantau oleh Metoro
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - Integrasi Raygun API V3 untuk pelaporan crash dan pemantauan pengguna nyata
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - Integrasi Sentry.io untuk pelacakan error dan pemantauan performa
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - Memberikan akses ke trace dan metrik OpenTelemetry melalui Logfire
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - Alat pemantau sistem yang mengekspor metrik sistem melalui Model Context Protocol (MCP). Alat ini memungkinkan LLM mengambil informasi sistem real-time melalui antarmuka kompatibel MCP. (mendukung CPU, Memory, Disk, Network, Host, Process)
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - Menyediakan integrasi komprehensif dengan [VictoriaMetrics instance APIs](https://docs.victoriametrics.com/victoriametrics/url-examples/) dan [dokumentasi](https://docs.victoriametrics.com/) untuk tugas pemantauan, observabilitas, dan debugging terkait instance VictoriaMetrics Anda

### 🎥 <a name="multimedia-process"></a>Proses Multimedia

Menyediakan kemampuan untuk menangani multimedia, seperti pengeditan audio dan video, pemutaran, konversi format, termasuk juga filter video, peningkatan, dan lain sebagainya

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - Menggunakan command line ffmpeg untuk membuat server mcp, sangat praktis, melalui dialog dapat melakukan pencarian video lokal, pemotongan, penggabungan, pemutaran, dan fungsi lainnya
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - Server MCP yang memungkinkan pemeriksaan metadata gambar seperti EXIF, XMP, JFIF, dan GPS. Ini memberikan fondasi untuk pencarian dan analisis koleksi foto dan perpustakaan gambar berbasis LLM.
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - Alat pengenalan dan pengeditan gambar berbasis ComputerVision 🪄 untuk asisten AI.

### 🔎 <a name="search"></a>Pencarian & Ekstraksi Data

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - Repositori ini mengimplementasikan server MCP (Model Context Protocol) untuk pencarian YouTube dan pengambilan transkrip. Memungkinkan model bahasa atau agen lain dengan mudah melakukan query konten YouTube melalui protokol terstandar.
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - Server MCP yang memungkinkan asisten AI menggunakan Wolfram Alpha API untuk akses real-time ke pengetahuan dan data komputasional.
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - Layanan Scrapeless Model Context Protocol bertindak sebagai konektor server MCP ke Google SERP API, memungkinkan pencarian web dalam ekosistem MCP tanpa harus keluar dari sana.
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - Server MCP untuk pencarian lowongan kerja dengan filter tanggal, kata kunci, opsi kerja remote, dan lainnya.
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - Integrasi API pencarian Kagi
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  MCP untuk LLM mencari dan membaca paper dari arXiv
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ MCP untuk pencarian melalui PapersWithCode API
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  MCP untuk mencari dan membaca makalah medis/ilmu hayat dari PubMed.
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - Pencarian artikel menggunakan NYTimes API
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - Server MCP untuk Apify's open-source RAG Web Browser Actor untuk melakukan pencarian web, scraping URL, dan mengembalikan konten dalam format Markdown.
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - Server MCP Clojars untuk informasi dependency terbaru pustaka Clojure
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - Pencarian makalah riset ArXiv
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - Menemukan, mengekstrak, dan berinteraksi dengan web - satu antarmuka yang mendukung akses otomatis ke seluruh internet publik.
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - Integrasi Google News dengan kategorisasi topik otomatis, dukungan multi-bahasa, dan kemampuan pencarian komprehensif termasuk headline, cerita, dan topik terkait melalui [SerpAPI](https://serpapi.com/).
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - Server MCP berbasis Python yang menyediakan alat OpenAI `web_search` build-in.
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - Server MCP untuk platform DealX
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - Crawl, embed, chunk, search, dan ambil informasi dari dataset melalui [Trieve](https://trieve.ai)
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - Akses API data, web scraping, dan konversi dokumen oleh [Dumpling AI](https://www.dumplingai.com/)
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - Server MCP untuk pencarian Hacker News, mendapatkan top stories, dan lainnya.
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – Server Model Context Protocol (MCP) yang memungkinkan asisten AI seperti Claude menggunakan Exa AI Search API untuk pencarian web. Pengaturan ini memungkinkan model AI mendapatkan informasi web real-time dengan cara yang aman dan terkontrol.
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - Pencarian melalui search1api (memerlukan API key berbayar)
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - Server riset biomedis yang menyediakan akses ke PubMed, ClinicalTrials.gov, dan MyVariant.info.
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - Server MCP untuk pencarian gambar Unsplash.
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - Server Model Context Protocol untuk [SearXNG](https://docs.searxng.org)
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - Server MCP untuk integrasi Naver Search API, mendukung pencarian blog, berita, belanja, dan fitur analitik DataLab.
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - Server MCP untuk mengambil konten halaman web menggunakan browser headless Playwright, mendukung rendering Javascript dan ekstraksi konten cerdas, serta output format Markdown atau HTML.
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - Server MCP yang kuat untuk pencarian Google yang memungkinkan pencarian paralel dengan banyak kata kunci sekaligus.
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - Server MCP untuk mengambil screenshot halaman web sebagai umpan balik selama pengembangan UI.
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - Kemampuan pencarian web menggunakan Microsoft Bing Search API
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – Server MCP Kagi Search Resmi
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – Tavily AI search API
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - Kemampuan pencarian Web, Gambar, Berita, Video, dan Tempat Menarik Lokal menggunakan Brave's Search API
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - Memainkan ekspresi musik [Melrōse](https://melrōse.org) sebagai MIDI
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - Kemampuan pencarian web menggunakan Brave's Search API
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - Pengambilan dan pemrosesan konten web yang efisien untuk konsumsi AI
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - Mencari di Google dan melakukan riset web mendalam tentang topik apa pun
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - Pencarian web menggunakan DuckDuckGo
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - Mengakses informasi Parlemen Belanda (Tweede Kamer) termasuk dokumen, debat, aktivitas, dan kasus legislatif melalui kemampuan pencarian terstruktur (berdasarkan proyek opentk oleh Bert Hubert)
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - Server MCP yang menyediakan riset mendalam otonom mirip OpenAI/Perplexity, elaborasi kueri terstruktur, dan pelaporan ringkas.
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - Server MCP untuk terhubung ke instance searXNG
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - Mendapatkan sumber LaTeX dari makalah arXiv untuk menangani konten matematika dan persamaan
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - Server MCP yang mengambil dan memproses data berita dari situs GeekNews.
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - Server MCP yang menyediakan kemampuan ekstraksi data [AgentQL](https://agentql.com).
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – Tavily AI search API
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - Server MCP [Vectorize](https://vectorize.io) untuk pencarian tingkat lanjut, Riset Mendalam Pribadi, ekstraksi file Anything-to-Markdown, dan pemotongan teks.
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - Berinteraksi dengan [WebScraping.ai](https://webscraping.ai) untuk ekstraksi dan scraping data web.
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - Ini adalah server MCP berbasis TypeScript yang menyediakan fungsi pencarian DuckDuckGo.
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - Kueri informasi aset jaringan melalui ZoomEye MCP Server
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - Server MCP yang mencari status Baseline menggunakan Web Platform API
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - Server MCP untuk berinteraksi dengan BioThings API, termasuk gen, varian genetik, obat, dan informasi taksonomi
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - Server MCP untuk mencari dan mengunduh fotografi stok bebas royalti dari Pexels dan Unsplash. Fitur pencarian multi-penyedia, metadata kaya, dukungan paginasi, dan performa async untuk asisten AI dalam menemukan dan mengakses gambar berkualitas tinggi.

### 🔒 <a name="security"></a>Keamanan

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - Server Model Context Protocol untuk Ghidra yang memungkinkan LLM secara otonom melakukan rekayasa balik aplikasi. Menyediakan alat untuk dekompilasi binary, penamaan ulang metode dan data, serta daftar metode, kelas, impor, dan ekspor.
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - Server MCP yang memungkinkan pengambilan kredensial aman dari 1Password untuk digunakan oleh AI Agentik.
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – Server MCP (Model Context Protocol) yang aman yang memungkinkan agen AI untuk berinteraksi dengan Authenticator App.
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - Server MCP untuk mengintegrasikan Ghidra dengan asisten AI. Plugin ini memungkinkan analisis binary, menyediakan alat untuk inspeksi fungsi, dekompilasi, eksplorasi memori, dan analisis impor/ekspor melalui Model Context Protocol.
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 Server MCP untuk menganalisis hasil pengumpulan ROADrecon dari enumerasi tenant Azure
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - Server MCP untuk dnstwist, alat fuzzing DNS yang kuat yang membantu mendeteksi typosquatting, phishing, dan spionase korporat.
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - Server MCP untuk maigret, alat OSINT yang mengumpulkan informasi akun pengguna dari berbagai sumber publik. Server ini menyediakan alat untuk mencari username di media sosial dan menganalisis URL.
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - Server MCP untuk mengkueri API Shodan dan Shodan CVEDB. Server ini menyediakan alat untuk lookup IP, pencarian perangkat, lookup DNS, kueri kerentanan, lookup CPE, dan lainnya.
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - Server MCP untuk mengkueri API VirusTotal. Server ini menyediakan alat untuk memindai URL, menganalisis hash file, dan mengambil laporan alamat IP.
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - Plugin Binary Ninja, server MCP, dan bridge yang mengintegrasikan [Binary Ninja](https://binary.ninja) dengan klien MCP favorit Anda. Memungkinkan Anda mengotomatisasi proses analisis binary dan rekayasa balik.
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - Server MCP untuk mengkueri ORKL API. Server ini menyediakan alat untuk mengambil laporan ancaman, menganalisis aktor ancaman, dan mengambil sumber intelijen.
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - Server MCP berbasis Rust untuk mengintegrasikan Cortex, memungkinkan analisis observable dan respons keamanan otomatis melalui AI.
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - Server MCP berbasis Rust untuk mengintegrasikan TheHive, memfasilitasi respons insiden keamanan kolaboratif dan manajemen kasus melalui AI.
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - Server MCP berbasis Rust yang menjembatani Wazuh SIEM dengan asisten AI, menyediakan peringatan keamanan real-time dan data kejadian untuk pemahaman kontekstual yang lebih baik.
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - Server MCP untuk mengakses [Intruder](https://www.intruder.io/), membantu Anda mengidentifikasi, memahami, dan memperbaiki kerentanan keamanan di infrastruktur Anda.
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - Server Model Context Protocol (MCP) yang dirancang untuk terhubung ke program perekaman CCTV (VMS) untuk mengambil rekaman dan streaming video langsung. Juga menyediakan alat untuk mengontrol perangkat lunak VMS, seperti menampilkan live atau playback untuk channel tertentu di waktu tertentu.
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ Server MCP (Model Context Protocol) yang kuat yang mengaudit dependensi paket npm untuk kerentanan keamanan. Dibuat dengan integrasi registry npm remote untuk pemeriksaan keamanan real-time.
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ Memungkinkan agen AI untuk memindai kode dari kerentanan keamanan menggunakan [Semgrep](https://semgrep.dev).
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - Server MCP untuk berinteraksi dengan CyberChef server API yang memungkinkan klien MCP menggunakan operasi CyberChef.
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - Server MCP untuk IDA Pro, memungkinkan Anda melakukan analisis binary dengan asisten AI. Plugin ini mengimplementasikan dekompilasi, disassembly, dan memungkinkan Anda menghasilkan laporan analisis malware secara otomatis.
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - Server MCP untuk RAD Security, menyediakan wawasan keamanan bertenaga AI untuk Kubernetes dan lingkungan cloud. Server ini menyediakan alat untuk mengkueri Rad Security API dan mengambil temuan keamanan, laporan, data runtime, dan banyak lagi.
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - Toolbox pengujian keamanan all-in-one yang menggabungkan alat open source populer melalui satu antarmuka MCP. Terhubung ke agen AI, memungkinkan tugas seperti pentesting, bug bounty hunting, threat hunting, dan lainnya.
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - Server Model Context Protocol (MCP) untuk mengkueri CVE-Search API. Server ini menyediakan akses komprehensif ke CVE-Search, menelusuri vendor dan produk, mendapatkan CVE per CVE-ID, dan mendapatkan CVE terbaru yang diperbarui.
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - Akses basis data OSV (Open Source Vulnerabilities) untuk informasi kerentanan. Kueri kerentanan berdasarkan versi paket atau commit, kueri batch beberapa paket, dan dapatkan informasi kerentanan detail berdasarkan ID.
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - Antarmuka rekonsiliasi percakapan dan server MCP yang didukung oleh httpx dan asnmap. Mendukung berbagai level rekonsiliasi untuk analisis domain, inspeksi header keamanan, analisis sertifikat, dan lookup ASN.
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - Server MCP untuk Volatility 3.x, memungkinkan Anda melakukan analisis forensik memori dengan asisten AI. Nikmati forensik memori tanpa hambatan saat plugin seperti pslist dan netscan dapat diakses melalui REST API yang bersih dan LLM.
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - Server MCP yang berjalan di dalam trusted execution environment (TEE) melalui Gramine, mendemonstrasikan remote attestation menggunakan [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html). Ini memungkinkan klien MCP memverifikasi server sebelum terhubung.
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADX-AI-MCP adalah plugin dan Server MCP untuk decompiler JADX yang terintegrasi langsung dengan Model Context Protocol (MCP) untuk menyediakan dukungan rekayasa balik langsung dengan LLM seperti Claude.
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - APKTool MCP Server adalah server MCP untuk Apk Tool guna menyediakan otomasi rekayasa balik APK Android.

### 🌐 <a name="social-media"></a>Media Sosial

Integrasi dengan platform media sosial untuk memungkinkan posting, analitik, dan manajemen interaksi. Memungkinkan otomasi berbasis AI untuk kehadiran sosial.

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ Akses data X/Reddit/YouTube waktu nyata langsung di aplikasi LLM Anda dengan frasa pencarian, pengguna, dan penyaringan tanggal.
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - Solusi manajemen Twitter all-in-one yang menyediakan akses timeline, pengambilan tweet pengguna, pemantauan hashtag, analisis percakapan, pesan langsung, analisis sentimen postingan, dan kontrol siklus hidup postingan secara lengkap – semua melalui API yang efisien.
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - Terintegrasi dengan Facebook Pages untuk memungkinkan manajemen langsung posting, komentar, dan metrik keterlibatan melalui Graph API untuk pengelolaan media sosial yang efisien.
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - Server MCP untuk berinteraksi dengan Bluesky melalui klien atproto.


### 🏃 <a name="sports"></a>Olahraga

Alat untuk mengakses data, hasil, dan statistik terkait olahraga.

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - Server MCP yang mengintegrasikan API balldontlie untuk menyediakan informasi tentang pemain, tim, dan pertandingan NBA, NFL, dan MLB
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - Akses data lomba sepeda, hasil, dan statistik melalui bahasa alami. Fitur termasuk pengambilan daftar start, hasil lomba, dan informasi pembalap dari firstcycling.com.
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - Server Model Context Protocol (MCP) yang terhubung ke Strava API, menyediakan alat untuk mengakses data Strava melalui LLM
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - Server MCP yang terintegrasi dengan Squiggle API untuk menyediakan informasi tim Liga Sepak Bola Australia, klasemen, hasil, prediksi, dan power ranking.
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - Server MCP yang bertindak sebagai proxy ke MLB API gratis, yang menyediakan info pemain, statistik, dan informasi pertandingan.

### 🎧 <a name="support-and-service-management"></a>Dukungan & Manajemen Layanan

Alat untuk mengelola dukungan pelanggan, manajemen layanan TI, dan operasi helpdesk.

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - Server MCP yang terintegrasi dengan Freshdesk, memungkinkan model AI berinteraksi dengan modul Freshdesk dan melakukan berbagai operasi dukungan.
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - Konektor MCP berbasis Go untuk Jira yang memungkinkan asisten AI seperti Claude berinteraksi dengan Atlassian Jira. Alat ini menyediakan antarmuka yang mulus untuk model AI dalam melakukan operasi Jira umum termasuk manajemen isu, perencanaan sprint, dan transisi workflow.
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Server MCP untuk produk Atlassian (Confluence dan Jira). Mendukung Confluence Cloud, Jira Cloud, dan Jira Server/Data Center. Menyediakan alat komprehensif untuk pencarian, membaca, membuat, dan mengelola konten di seluruh workspace Atlassian.

### 🌎 <a name="translation-services"></a>Layanan Terjemahan

Alat dan layanan terjemahan untuk memungkinkan asisten AI menerjemahkan konten antar bahasa.

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - Server MCP untuk Lara Translate API, memungkinkan kemampuan terjemahan yang kuat dengan dukungan deteksi bahasa dan terjemahan kontekstual.
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - Server Model Context Protocol komprehensif untuk manajemen terjemahan Weblate, memungkinkan asisten AI melakukan tugas terjemahan, manajemen proyek, dan penemuan konten dengan transformasi format cerdas.

### 🎧 <a name="text-to-speech"></a>Teks ke Ucapan

Alat untuk mengonversi teks ke ucapan dan sebaliknya

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - Server MCP yang menggunakan model Kokoro TTS berbobot terbuka untuk mengonversi teks ke ucapan. Dapat mengonversi teks ke MP3 di driver lokal atau auto-upload ke bucket S3.
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - Server interaksi suara lengkap yang mendukung speech-to-text, text-to-speech, dan percakapan suara real-time melalui mikrofon lokal, API kompatibel OpenAI, dan integrasi LiveKit

### 🚆 <a name="travel-and-transportation"></a>Perjalanan & Transportasi

Akses informasi perjalanan dan transportasi. Memungkinkan kueri jadwal, rute, dan data perjalanan real-time.
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - Menyediakan alat untuk mencari Airbnb dan mendapatkan detail listing.
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - Integrasi API National Park Service yang menyediakan informasi terbaru tentang detail taman, peringatan, pusat pengunjung, tempat perkemahan, dan acara untuk Taman Nasional AS.
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - Akses informasi perjalanan, jadwal, dan pembaruan waktu nyata Kereta Api Belanda (NS).
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - Server MCP yang memungkinkan LLM berinteraksi dengan API Tripadvisor, mendukung data lokasi, ulasan, dan foto melalui antarmuka MCP standar.
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - Server MCP untuk layanan kereta National Rail Inggris, menyediakan jadwal kereta dan informasi perjalanan langsung, mengintegrasikan API Realtime Trains.

### 🔄 <a name="version-control"></a>Kontrol Versi

Berinteraksi dengan repositori Git dan platform kontrol versi. Memungkinkan manajemen repositori, analisis kode, penanganan pull request, pelacakan isu, dan operasi kontrol versi lainnya melalui API standar.

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - Membaca dan menganalisis repositori GitHub dengan LLM Anda
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - Server MCP untuk integrasi API GitHub Enterprise
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - Berinteraksi dengan instance Gitea melalui MCP.
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - Server GitHub resmi untuk integrasi dengan manajemen repositori, PR, isu, dan lainnya.
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - Berinteraksi secara mulus dengan isu dan merge request proyek GitLab Anda.
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - Operasi repositori Git langsung termasuk membaca, mencari, dan menganalisis repositori lokal
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - Integrasi platform GitLab untuk manajemen proyek dan operasi CI/CD
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - Integrasi API Gitee, manajemen repositori, isu, dan pull request, serta lainnya.
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - Integrasi Azure DevOps untuk manajemen repositori, item kerja, dan pipeline.
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - Server resmi AtomGit untuk integrasi dengan manajemen repositori, PR, isu, cabang, label, dan lainnya.

### 🛠️ <a name="other-tools-and-integrations"></a>Alat dan Integrasi Lainnya

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ Server Model Context Protocol (MCP) yang memungkinkan model AI berinteraksi dengan Bitcoin, memungkinkan mereka menghasilkan kunci, memvalidasi alamat, mendekode transaksi, melakukan query blockchain, dan lainnya.
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - Memungkinkan AI membaca dari Bear Notes Anda (khusus macOS)
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - Mengekspos semua intent suara Home Assistant melalui Server Model Context Protocol yang memungkinkan kontrol rumah.
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - Gunakan model Amazon Nova Canvas untuk pembuatan gambar.
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - Kirim permintaan ke OpenAI, MistralAI, Anthropic, xAI, Google AI atau DeepSeek menggunakan protokol MCP melalui tool atau prompt yang telah ditentukan. Kunci API vendor diperlukan.
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 - Server MCP yang menginstal server MCP lain untuk Anda.
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - Mengambil subtitle YouTube
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️  MCP untuk berbicara dengan asisten OpenAI (Claude dapat menggunakan model GPT apa pun sebagai asistennya)
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - Server MCP yang memungkinkan pengecekan waktu lokal di mesin klien atau waktu UTC saat ini dari server NTP
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - Gunakan 3.000+ alat cloud siap pakai, yang dikenal sebagai Actors, untuk mengekstrak data dari situs web, e-commerce, media sosial, mesin pencari, peta, dan lainnya
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ Server PiAPI MCP memungkinkan pengguna menghasilkan konten media dengan Midjourney/Flux/Kling/Hunyuan/Udio/Trellis langsung dari Claude atau aplikasi kompatibel MCP lainnya.
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - Memberikan kemampuan untuk menghasilkan gambar melalui API Replicate.
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - Server MCP untuk penggunaan taskwarrior lokal dasar (menambah, memperbarui, menghapus tugas)
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - Berinteraksi dengan API Phabricator
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - Server Model Context Protocol (MCP) yang terintegrasi dengan API Notion untuk mengelola daftar todo pribadi secara efisien.
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - Memungkinkan membaca catatan dan tag untuk aplikasi Bear Note, melalui integrasi langsung dengan Bear's sqlitedb.
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - Server MCP untuk Claude berbicara dengan ChatGPT dan menggunakan kemampuan pencarian webnya.
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - Memungkinkan AI melakukan query ke server GraphQL
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - Ini adalah konektor untuk memungkinkan Claude Desktop (atau klien MCP apa pun) membaca dan mencari direktori yang berisi catatan Markdown (seperti Obsidian vault).
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - Alat CLI lain untuk menguji server MCP
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - Terintegrasi dengan API Notion untuk mengelola daftar todo pribadi
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - Implementasi ringan server Wrike MCP untuk berinteraksi dengan tugas Wrike via API publik.
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - [TickTick](https://ticktick.com/) server MCP yang terintegrasi dengan API TickTick untuk mengelola proyek todo pribadi dan tugas-tugasnya.
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - Manajemen kontrak dan template untuk membuat, meninjau, dan mengirim kontrak mengikat melalui API eSignatures.
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - Akses papan tulis MIRO, membuat dan membaca item secara massal. Membutuhkan kunci OAUTH untuk REST API.
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - Membaca, membuat, memperbarui, dan menghapus catatan Google Keep.
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️  - API pencarian Artikel Wikipedia
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - Definisikan alat menggunakan query/mutasi GraphQL reguler dan gqai secara otomatis menghasilkan server MCP untuk Anda.
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - Server ini memungkinkan LLM menggunakan kalkulator untuk perhitungan numerik yang presisi
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ Alat untuk query dan eksekusi workflow Dify
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - Integrasi yang memungkinkan LLM berinteraksi dengan bookmark Raindrop.io menggunakan Model Context Protocol (MCP).
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ Memungkinkan klien AI mengelola catatan dan catatan di Attio CRM
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - Menghasilkan visualisasi dari data yang diambil menggunakan format dan renderer VegaLite.
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - Menghubungkan asisten AI ke sistem Odoo ERP untuk akses data bisnis, manajemen catatan, dan otomatisasi workflow.
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - Memperbarui, membuat, menghapus konten, model-konten dan aset di Contentful Space Anda
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - Membiarkan agen membacakan sesuatu, memberi notifikasi saat selesai bekerja dengan ringkasan cepat
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - Server Model Context Protocol (MCP) untuk mengakses API Climatiq guna menghitung emisi karbon. Ini memungkinkan asisten AI melakukan perhitungan karbon secara waktu nyata dan memberikan wawasan dampak iklim.
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - Server MCP untuk Typst, sistem typesetting berbasis markup. Menyediakan alat untuk konversi antara LaTeX dan Typst, validasi sintaks Typst, dan menghasilkan gambar dari kode Typst.
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - Server MCP untuk membuat daftar dan menjalankan aplikasi di MacOS
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - Server MCP untuk membuat/memperbarui halaman di aplikasi Notion & secara otomatis menghasilkan mdBooks dari konten terstruktur.
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 Server MCP ini membantu Anda mengelola proyek dan isu melalui API [Plane](https://plane.so)
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - Memungkinkan interaksi (operasi admin, antre pesan masuk/keluar) dengan RabbitMQ
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - Server MCP Miro, mengekspos semua fungsionalitas yang tersedia di SDK resmi Miro
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - Aplikasi eksperimental dan edukasi untuk server Ping-pong yang mendemonstrasikan pemanggilan MCP jarak jauh (Model Context Protocol)
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ Memungkinkan model AI berinteraksi dengan [Kibela](https://kibe.la/)
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ Berinteraksi secara kuat dengan API Kibela.
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - Mengambil data Confluence melalui CQL dan membaca halaman.
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - Membaca data jira melalui JQL dan api serta menjalankan permintaan untuk membuat dan mengedit tiket.
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - Server MCP dengan demonstrasi dasar interaksi dengan instance Salesforce
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - Prompt peningkatan LLM khusus dan jailbreak dengan adaptasi skema dinamis.
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - Server MCP dengan demonstrasi dasar pengambilan cuaca dari Hong Kong Observatory
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - Gunakan HuggingFace Spaces langsung dari Claude. Gunakan Open Source Image Generation, Chat, tugas Vision dan lainnya. Mendukung upload/download gambar, audio, dan teks.
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - Cari dan ambil GIF dari perpustakaan Giphy yang luas melalui API Giphy.
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - Ubah skenario [Make](https://www.make.com/) Anda menjadi alat yang dapat dipanggil untuk asisten AI.
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 Kontrol pemutaran Spotify dan kelola playlist.
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - Berinteraksi dengan Obsidian via REST API
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - Proxy server MCP yang menawarkan Web UI untuk seluruh alur pesan
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - Menggambar di kanvas JavaFX.
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 Sistem local-first untuk merekam layar/audio dengan indeksasi bertanda waktu, penyimpanan SQL/embedding, pencarian semantik, analisis riwayat bertenaga LLM, dan aksi berbasis event - memungkinkan pembuatan agen AI kontekstual melalui ekosistem plugin NextJS.
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - Server MCP yang menguji semua fitur protokol MCP
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - Server dokumentasi Go yang efisien token, memberikan asisten AI akses cerdas ke dokumentasi paket dan tipe tanpa membaca seluruh file sumber
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - Mengobrol dengan model OpenAI paling pintar
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - Server MCP yang dapat mengeksekusi perintah seperti input keyboard dan pergerakan mouse
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - Beberapa alat berguna untuk pengembang, hampir semua yang dibutuhkan engineer: confluence, Jira, Youtube, menjalankan skrip, knowledge base RAG, fetch URL, manajemen channel youtube, email, kalender, gitlab
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 Operasi otomatis GUI di layar.
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - Server MCP untuk [Coda](https://coda.io/)
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - Query model OpenAI langsung dari Claude menggunakan protokol MCP
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ Mem-parsing konten HTML dari news.ycombinator.com (Hacker News) dan menyediakan data terstruktur untuk berbagai jenis berita (teratas, baru, tanya, tampilkan, pekerjaan).
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - Server MCP yang mencegah error berantai dan scope creep dengan memanggil agen "Vibe-check" untuk memastikan keselarasan pengguna.
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - Server MCP untuk perhitungan ekspresi matematika
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - Mengobrol dengan API Chat Completions kompatibel OpenAI SDK lainnya, seperti Perplexity, Groq, xAI dan lainnya
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - Meningkatkan kemampuan berpikir agent dengan mengintegrasikan think-tools, sebagaimana dijelaskan di [artikel Anthropic](https://www.anthropic.com/engineering/claude-think-tool).
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - Memungkinkan AI membaca file .ged dan data genetik
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - Membuat flashcard pengulangan berspasi di [Rember](https://rember.com) untuk mengingat apapun yang Anda pelajari di chat.
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ Implementasi server Model Context Protocol untuk Asana yang memungkinkan Anda berbicara dengan API Asana dari Klien MCP seperti Aplikasi Desktop Claude Anthropic, dan banyak lagi.
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - Eksekusi shell otonom, kontrol komputer dan agen pengkodean. (Mac)
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - Server MCP untuk melakukan query ke API wolfram alpha.
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - Berinteraksi dengan video TikTok
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - Server Model Context Protocol (MCP) yang berinteraksi dengan Shopify Dev.
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - Memungkinkan AI membaca dari basis data Apple Notes lokal Anda (hanya macOS)
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Server MCP untuk produk Atlassian (Confluence dan Jira). Mendukung Confluence Cloud, Jira Cloud, dan Jira Server/Data Center. Menyediakan alat komprehensif untuk pencarian, pembacaan, pembuatan, dan pengelolaan konten di seluruh ruang kerja Atlassian.
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - Berinteraksi dengan Notion API
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - Integrasi dengan sistem manajemen proyek Linear
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - Berinteraksi dengan Perplexity API.
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - Mengakses data Home Assistant dan mengontrol perangkat (lampu, saklar, termostat, dll).
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - Server MCP untuk Oura, aplikasi pelacak tidur
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - Server MCP ringan berbasis konfigurasi yang mengekspos query GraphQL terkurasi sebagai alat modular, memungkinkan interaksi API yang disengaja dari agen Anda.
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - Server MCP untuk Strava, aplikasi pelacak aktivitas fisik
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 Wanaku MCP Router adalah server MCP berbasis SSE yang menyediakan mesin routing yang dapat diperluas untuk integrasi sistem enterprise Anda dengan agen AI.
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - Alat CLI untuk menguji server MCP
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - Membungkus server MCP dengan WebSocket (untuk digunakan dengan [kitbitz](https://github.com/nick1udwig/kibitz))
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - Memungkinkan model AI berinteraksi dengan [HackMD](https://hackmd.io)
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - Server MCP yang menyediakan fungsi tanggal dan waktu dalam berbagai format
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - Web UI sederhana untuk menginstal dan mengelola server MCP untuk aplikasi Claude Desktop.
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ Server Model-Context-Protocol (MCP) untuk integrasi dengan Yuque API, memungkinkan model AI mengelola dokumen, berinteraksi dengan basis pengetahuan, mencari konten, dan mengakses data analitik dari platform Yuque.
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - Memungkinkan AI untuk sepenuhnya mengontrol dan mengakses interaksi GUI dengan menyediakan alat untuk mouse dan keyboard, ideal untuk otomasi umum, pendidikan, dan eksperimen.
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - Implementasi server MCP yang membungkus Ankr Advanced API. Akses data NFT, token, dan blockchain di berbagai chain termasuk Ethereum, BSC, Polygon, Avalanche, dan lainnya.
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - Utilitas untuk mengunduh, melihat, & memanipulasi PDF.
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - Layanan pencarian nama domain, pertama melalui [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol) dan jika gagal melalui [WHOIS](https://en.wikipedia.org/wiki/WHOIS)
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - Mengekstrak dan mengonversi informasi video YouTube.
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - Memungkinkan alur kerja LLM interaktif dengan menambahkan prompt pengguna lokal dan kemampuan chat langsung ke dalam loop MCP.
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - Saat LLM Anda membutuhkan bantuan manusia (melalui AWS Mechanical Turk)
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - Memberikan alat "free will" untuk AI Anda. Proyek seru untuk mengeksplorasi apa yang akan dilakukan AI dengan kemampuan memberi dirinya sendiri prompt, mengabaikan permintaan pengguna, dan membangunkan dirinya sendiri di waktu lain.
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - Wenyan MCP Server, memungkinkan AI secara otomatis memformat artikel Markdown dan mempublikasikannya ke WeChat GZH.

## Framework

> [!NOTE]
> Lebih banyak framework, utilitas, dan alat developer lainnya tersedia di https://github.com/punkpeye/awesome-mcp-devtools

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - Framework tingkat tinggi untuk membangun server MCP dengan Python
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - Framework tingkat tinggi untuk membangun server MCP dengan TypeScript

## Tips dan Trik

### Prompt resmi untuk memberitahu LLM cara menggunakan MCP

Ingin bertanya ke Claude tentang Model Context Protocol?

Buat sebuah Proyek, lalu tambahkan file ini ke dalamnya:

https://modelcontextprotocol.io/llms-full.txt

Sekarang Claude dapat menjawab pertanyaan tentang cara menulis server MCP dan cara kerjanya

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## Riwayat Bintang

<a href="https://star-history.com/#punkpeye/awesome-mcp-servers&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---