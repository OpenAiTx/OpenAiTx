# free-for.dev

Pengembang dan penulis Open Source kini memiliki banyak layanan yang menawarkan tier gratis, namun menemukan semuanya membutuhkan waktu agar dapat mengambil keputusan yang tepat.

Ini adalah daftar perangkat lunak (SaaS, PaaS, IaaS, dll.) dan penawaran lain dengan tier pengembang gratis.

Ruang lingkup daftar ini secara khusus dibatasi pada hal-hal yang kemungkinan akan dianggap berguna oleh pengembang infrastruktur (Administrator Sistem, Praktisi DevOps, dll.). Kami menyukai semua layanan gratis di luar sana, tetapi akan lebih baik jika tetap sesuai topik. Kadang-kadang ini adalah garis abu-abu, jadi ini bersifat subyektif; harap tidak tersinggung jika kontribusi Anda tidak saya terima.

Daftar ini merupakan hasil dari Pull Request, ulasan, ide, dan kerja dari 1600+ orang. Anda juga dapat membantu dengan mengirimkan [Pull Request](https://github.com/ripienaar/free-for-dev) untuk menambah layanan baru atau menghapus layanan yang penawarannya telah berubah atau dihentikan.

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**CATATAN**: Daftar ini hanya untuk penawaran as-a-Service, bukan untuk perangkat lunak self-hosted. Agar memenuhi syarat, sebuah layanan harus menawarkan tier gratis, bukan hanya uji coba gratis. Tier gratis harus berlaku setidaknya satu tahun jika dibatasi waktu. Kami juga mempertimbangkan tier gratis dari perspektif keamanan, jadi SSO diperbolehkan, namun saya tidak akan menerima layanan yang membatasi TLS hanya untuk tier berbayar.

# Daftar Isi

  * [Batas Selalu Gratis dari Penyedia Cloud Utama](#major-cloud-providers)
  * [Solusi Manajemen Cloud](#cloud-management-solutions)
  * [Analitik, Event, dan Statistik](#analytics-events-and-statistics)
  * [API, Data dan ML](#apis-data-and-ml)
  * [Repositori Artefak](#artifact-repos)
  * [BaaS](#baas)
  * [Platform Low-code](#low-code-platform)
  * [CDN dan Perlindungan](#cdn-and-protection)
  * [CI dan CD](#ci-and-cd)
  * [CMS](#cms)
  * [Generasi Kode](#code-generation)
  * [Kualitas Kode](#code-quality)
  * [Pencarian dan Penelusuran Kode](#code-search-and-browsing)
  * [Penanganan Crash dan Exception](#crash-and-exception-handling)
  * [Visualisasi Data pada Peta](#data-visualization-on-maps)
  * [Layanan Data Terkelola](#managed-data-services)
  * [Desain dan UI](#design-and-ui)
  * [Inspirasi Desain](#design-inspiration)
  * [Situs Blogging Dev](#dev-blogging-sites)
  * [DNS](#dns)
  * [Terkait Docker](#docker-related)
  * [Domain](#domain)
  * [Pendidikan dan Pengembangan Karir](#education-and-career-development)
  * [Email](#email)
  * [Platform Manajemen Feature Toggle](#feature-toggles-management-platforms)
  * [Font](#font)
  * [Formulir](#forms)
  * [Generative AI](#generative-ai)
  * [IaaS](#iaas)
  * [IDE dan Pengeditan Kode](#ide-and-code-editing)
  * [API dan SDK Verifikasi Nomor Mobile Internasional](#international-mobile-number-verification-api-and-sdk)
  * [Pelacakan Masalah dan Manajemen Proyek](#issue-tracking-and-project-management)
  * [Manajemen Log](#log-management)
  * [Distribusi Aplikasi Mobile dan Umpan Balik](#mobile-app-distribution-and-feedback)
  * [Sistem Manajemen](#management-system)
  * [Pesan dan Streaming](#messaging-and-streaming)
  * [Lain-lain](#miscellaneous)
  * [Monitoring](#monitoring)
  * [PaaS](#paas)
  * [Sistem Build Paket](#package-build-system)
  * [Integrasi Pembayaran dan Penagihan](#payment-and-billing-integration)
  * [Manajemen Privasi](#privacy-management)
  * [API Screenshot](#screenshot-apis)
  * [Terkait Flutter dan Membangun Aplikasi IOS tanpa Mac](#flutter-related-and-building-ios-apps-without-mac)
  * [Pencarian](#search)
  * [Keamanan dan PKI](#security-and-pki)
  * [Otentikasi, Otorisasi, dan Manajemen Pengguna](#authentication-authorization-and-user-management)
  * [Repositori Kode Sumber](#source-code-repos)
  * [Penyimpanan dan Pemrosesan Media](#storage-and-media-processing)
  * [Tunneling, WebRTC, Web Socket Server dan Router Lainnya](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [Pengujian](#testing)
  * [Alat untuk Tim dan Kolaborasi](#tools-for-teams-and-collaboration)
  * [Manajemen Terjemahan](#translation-management)
  * [Terkait Vagrant](#vagrant-related)
  * [Perekaman Sesi Pengunjung](#visitor-session-recording)
  * [Web Hosting](#web-hosting)
  * [Platform Komentar](#commenting-platforms)
  * [Emulasi Perangkat Keras Berbasis Browser](#browser-based-hardware-emulation-written-in-javascript)
  * [Alat Remote Desktop](#remote-desktop-tools)
  * [Pengembangan Game](#game-development)
  * [Sumber Daya Gratis Lainnya](#other-free-resources)

## Penyedia Cloud Utama

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - 28 jam instance frontend per hari, sembilan jam instance backend per hari
    * Cloud Firestore - 1GB penyimpanan, 50.000 baca, 20.000 tulis, 20.000 hapus per hari
    * Compute Engine - 1 non-preemptible e2-micro, 30GB HDD, 5GB snapshot storage (dibatasi pada wilayah tertentu), 1 GB network egress dari Amerika Utara ke semua tujuan wilayah (tidak termasuk Tiongkok dan Australia) per bulan
    * Cloud Storage - 5GB, 1GB network egress
    * Cloud Shell - Shell Linux berbasis web/IDE utama dengan 5GB penyimpanan persisten. Batas 60 jam per minggu
    * Cloud Pub/Sub - 10GB pesan per bulan
    * Cloud Functions - 2 juta invokasi per bulan (termasuk invokasi background dan HTTP)
    * Cloud Run - 2 juta permintaan per bulan, 360.000 GB-detik memori, 180.000 vCPU-detik waktu komputasi, 1 GB network egress dari Amerika Utara per bulan
    * Google Kubernetes Engine - Tidak ada biaya manajemen cluster untuk satu cluster zonal. Setiap node pengguna dikenakan biaya sesuai harga Compute Engine standar
    * BigQuery - 1 TB query per bulan, 10 GB penyimpanan per bulan
    * Cloud Build - 120 menit build per hari
    * Cloud Source Repositories - Hingga 5 pengguna, 50 GB penyimpanan, 50 GB egress
    * [Google Colab](https://colab.research.google.com/) - Lingkungan pengembangan Jupyter Notebooks gratis.
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio (sebelumnya Project IDX). VSCode online yang berjalan di Google Cloud.
    * Daftar lengkap dan detail - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - 1TB egress per bulan dan 2 juta invokasi Function per bulan
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - 10 custom metrics dan sepuluh alarm
* [CodeBuild](https://aws.amazon.com/codebuild/) - 100 menit waktu build per bulan
* [CodeCommit](https://aws.amazon.com/codecommit/) - 5 pengguna aktif, 50GB penyimpanan, dan 10.000 permintaan per bulan
* [CodePipeline](https://aws.amazon.com/codepipeline/) - 1 pipeline aktif per bulan
* [DynamoDB](https://aws.amazon.com/dynamodb/) - 25GB basis data NoSQL
* [EC2](https://aws.amazon.com/ec2/) - 750 jam per bulan untuk t2.micro atau t3.micro (12 bulan). 100GB egress per bulan
* [EBS](https://aws.amazon.com/ebs/) - 30GB per bulan untuk General Purpose (SSD) atau Magnetic (12 bulan)
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 750 jam per bulan (12 bulan)
* [RDS](https://aws.amazon.com/rds/) - 750 jam per bulan untuk db.t2.micro, db.t3.micro, atau db.t4g.micro, 20GB General Purpose (SSD) storage, 20GB backup storage (12 bulan)
* [S3](https://aws.amazon.com/s3/) - 5GB penyimpanan objek Standar, 20K permintaan Get dan 2K permintaan Put (12 bulan)
* [Glacier](https://aws.amazon.com/glacier/) - 10GB penyimpanan objek jangka panjang
* [Lambda](https://aws.amazon.com/lambda/) - 1 juta permintaan per bulan
* [SNS](https://aws.amazon.com/sns/) - 1 juta publikasi per bulan
* [SES](https://aws.amazon.com/ses/) - 3.000 pesan per bulan (12 bulan)
* [SQS](https://aws.amazon.com/sqs/) - 1 juta permintaan antrean pesan
* Daftar lengkap dan detail - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - 1 VM Linux B1S, 1 VM Windows B1S (12 bulan)
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10 aplikasi web, mobile, atau API (60 menit CPU/hari)
  * [Functions](https://azure.microsoft.com/services/functions/) - 1 juta permintaan per bulan
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - Mengaktifkan lingkungan dev-test yang cepat, mudah, dan efisien
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500.000 objek
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - 50.000 pengguna yang disimpan per bulan
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 5 pengguna aktif, repositori Git privat tanpa batas
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — 10 job paralel gratis dengan menit tak terbatas untuk open source pada Linux, macOS, dan Windows
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 8.000 pesan per hari
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 1 IP publik free load-balanced (VIP)
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - 1 juta push notification
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - 15GB inbound (12 bulan) & 5GB egress per bulan
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25GB penyimpanan dan 1000 RU throughput terprovisi
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — Bangun, deploy, dan host aplikasi statis serta fungsi serverless dengan SSL gratis, autentikasi/otorisasi, dan domain khusus
  * [Storage](https://azure.microsoft.com/services/storage/) - 5GB LRS File atau Blob storage (12 bulan)
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - API AI/ML (Computer Vision, Translator, Face detection, Bots, dll) dengan tier gratis termasuk transaksi terbatas
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - Layanan pencarian dan indeksasi berbasis AI, gratis untuk 10.000 dokumen
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - Layanan Kubernetes terkelola, manajemen cluster gratis
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 100K operasi/bulan
  * Daftar lengkap dan detail - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)
  * Compute
     - 2 VM Compute berbasis AMD dengan 1/8 OCPU dan 1 GB memori masing-masing
     - 4 core Arm-based Ampere A1 dan 24 GB memori, dapat digunakan sebagai satu VM atau hingga 4 VM
     - Instance akan diambil kembali saat [dianggap idle](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)
  * Block Volume - 2 volume, total 200 GB (digunakan untuk compute)
  * Object Storage - 10 GB
  * Load balancer - 1 instance dengan 10 Mbps
  * Database - 2 basis data, masing-masing 20 GB
  * Monitoring - 500 juta data point ingestion, 1 miliar data point retrieval
  * Bandwidth - 10 TB egress per bulan, kecepatan dibatasi 50 Mbps pada VM berbasis x64, 500 Mbps * jumlah core pada VM berbasis ARM
  * Public IP - 2 IPv4 untuk VM, 1 IPv4 untuk load balancer
  * Notifications - 1 juta opsi pengiriman per bulan, 1000 email terkirim per bulan
  * Daftar lengkap dan detail - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)
  * Cloudant database - 1 GB penyimpanan data
  * Db2 database - 100MB penyimpanan data
  * API Connect - 50.000 panggilan API per bulan
  * Availability Monitoring - 3 juta data point per bulan
  * Log Analysis - 500MB log harian
  * Daftar lengkap dan detail - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)
  * [Application Services](https://www.cloudflare.com/plans/) - DNS gratis untuk jumlah domain tak terbatas, Perlindungan DDoS, CDN dengan SSL gratis, aturan Firewall dan aturan halaman, WAF, Bot Mitigation, Free Unmetered Rate Limiting - 1 aturan per domain, Analitik, Penerusan email
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - Hingga 50 pengguna, 24 jam pencatatan aktivitas, tiga lokasi jaringan
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - Anda dapat mengekspose port HTTP yang berjalan lokal melalui tunnel ke subdomain acak di trycloudflare.com menggunakan [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/), tanpa akun. Fitur lebih lanjut (TCP tunnel, Load balancing, VPN) di [Zero Trust](https://www.cloudflare.com/products/zero-trust/) Free Plan.
  * [Workers](https://developers.cloudflare.com/workers/) - Deploy kode serverless secara gratis di jaringan global Cloudflare—100 ribu permintaan harian.
  * [Workers KV](https://developers.cloudflare.com/kv) - 100 ribu permintaan baca per hari, 1000 permintaan tulis per hari, 1000 permintaan hapus per hari, 1000 permintaan list per hari, 1 GB data tersimpan
  * [R2](https://developers.cloudflare.com/r2/) - 10 GB per bulan, 1 juta operasi Class A per bulan, 10 juta operasi Class B per bulan
  * [D1](https://developers.cloudflare.com/d1/) - 5 juta baris dibaca per hari, 100 ribu baris ditulis per hari, 1 GB penyimpanan
  * [Pages](https://developers.cloudflare.com/pages/) - Kembangkan dan deploy aplikasi web Anda di jaringan global Cloudflare yang cepat dan aman. Lima ratus build bulanan, 100 domain khusus, SSL terintegrasi, kursi tak terbatas, preview deployment tak terbatas, dan kapabilitas full-stack via integrasi Cloudflare Workers.
  * [Queues](https://developers.cloudflare.com/queues/) - 1 juta operasi per bulan
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 1TB trafik (keluar) gratis per bulan.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Solusi manajemen cloud

* [Brainboard](https://www.brainboard.co) - Solusi kolaboratif untuk membangun dan mengelola infrastruktur cloud secara visual dari ujung ke ujung.
* [Cloud 66](https://www.cloud66.com/) - Gratis untuk proyek pribadi (termasuk satu deployment server, satu situs statis), Cloud 66 memberi semua yang Anda butuhkan untuk membangun, deploy, dan mengembangkan aplikasi Anda di cloud mana pun tanpa repot urusan “server.”
* [Pulumi](https://www.pulumi.com/) — Platform modern infrastructure as code yang memungkinkan Anda menggunakan bahasa pemrograman dan alat yang sudah dikenal untuk membangun, deploy, dan mengelola infrastruktur cloud.
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. Manajemen remote state gratis dan kolaborasi tim hingga 500 resources.
* [scalr.com](https://scalr.com/) - Scalr adalah produk Terraform Automation and COllaboration (TACO) yang digunakan untuk kolaborasi dan otomatisasi yang lebih baik pada infrastruktur dan konfigurasi yang dikelola oleh Terraform. Dukungan penuh Terraform CLI, integrasi OPA, dan model konfigurasi hierarkis. Tanpa pajak SSO. Semua fitur termasuk. Gunakan hingga 50 run/bulan secara gratis.
* [deployment.io](https://deployment.io) - Deployment.io membantu developer mengotomasi deployment di AWS. Pada tier gratis, seorang developer (pengguna tunggal) dapat melakukan deploy situs statis, layanan web, dan lingkungan tanpa batas. Kami menyediakan 20 eksekusi job gratis per bulan dengan preview dan auto-deploy termasuk di tier gratis.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Repositori Kode Sumber

* [Bitbucket](https://bitbucket.org/) — Repositori Git publik dan privat tanpa batas untuk hingga 5 pengguna dengan Pipelines untuk CI/CD
* [chiselapp.com](https://chiselapp.com/) — Repositori Fossil publik dan privat tanpa batas
* [codebasehq.com](https://www.codebasehq.com/) — Satu proyek gratis dengan 100 MB ruang dan dua pengguna
* [Codeberg](https://codeberg.org/) — Repositori Git publik dan privat tanpa batas untuk proyek gratis dan open-source (dengan kolaborator tanpa batas). Didukung oleh [Forgejo](https://forgejo.org/). Hosting situs statis dengan [Codeberg Pages](https://codeberg.page/). Hosting CI/CD dengan [Codeberg's CI](https://docs.codeberg.org/ci/). Hosting terjemahan dengan [Codeberg Translate](https://translate.codeberg.org/). Termasuk hosting Paket dan Kontainer, Manajemen Proyek, dan Pelacakan Isu
* [GitGud](https://gitgud.io) — Repositori privat dan publik tanpa batas. Gratis selamanya. Didukung oleh GitLab & Sapphire. CI/CD tidak disediakan.
* [GitHub](https://github.com/) — Repositori publik tanpa batas dan repositori privat tanpa batas (dengan kolaborator tanpa batas). Termasuk CI/CD, Lingkungan Pengembangan, Hosting Statis, Hosting Paket dan Kontainer, Manajemen Proyek, dan AI Copilot
* [gitlab.com](https://about.gitlab.com/) — Repositori Git publik dan privat tanpa batas dengan hingga 5 kolaborator. Termasuk CI/CD, Hosting Statis, Container Registry, Manajemen Proyek, dan Pelacakan Isu
* [framagit.org](https://framagit.org/) — Framagit adalah forge perangkat lunak dari Framasoft berbasis perangkat lunak Gitlab, termasuk CI, Halaman Statis, halaman Proyek, dan pelacakan Isu.
* [heptapod.net](https://foss.heptapod.net/) — Heptapod adalah fork ramah dari GitLab Community Edition yang mendukung Mercurial
* [ionicframework.com](https://ionicframework.com/appflow) - Repo dan alat untuk mengembangkan aplikasi dengan Ionic; juga Anda memiliki repo ionic
* [NotABug](https://notabug.org) — NotABug.org adalah platform kolaborasi kode perangkat lunak bebas untuk proyek berlisensi bebas, berbasis Git
* [OSDN](https://osdn.net/) - OSDN.net adalah layanan gratis untuk pengembang perangkat lunak open-source, menawarkan repositori SVN/Git/Mercurial/Bazaar/CVS.
* [Pagure.io](https://pagure.io) — Pagure.io adalah platform kolaborasi kode perangkat lunak gratis dan open source untuk proyek berlisensi FOSS, berbasis Git
* [perforce.com](https://www.perforce.com/products/helix-teamhub) — Gratis 1GB Cloud dan repositori Git, Mercurial, atau SVN.
* [pijul.com](https://pijul.com/) - Sistem kontrol versi terdistribusi gratis dan open source tanpa batas. Fitur khasnya didasarkan pada teori patch yang solid, sehingga mudah dipelajari, digunakan, dan didistribusikan. Mengatasi banyak masalah pada git/hg/svn/darcs.
* [plasticscm.com](https://plasticscm.com/) — Gratis untuk individu, OSS, dan organisasi nirlaba
* [projectlocker.com](https://projectlocker.com) — Satu proyek privat gratis (Git dan Subversion) dengan ruang 50 MB
* [RocketGit](https://rocketgit.com) — Hosting Repositori berbasis Git. Repositori publik dan privat tanpa batas.
* [savannah.gnu.org](https://savannah.gnu.org/) - Berfungsi sebagai sistem manajemen pengembangan perangkat lunak kolaboratif untuk proyek perangkat lunak bebas (untuk Proyek GNU)
* [savannah.nongnu.org](https://savannah.nongnu.org/) - Berfungsi sebagai sistem manajemen pengembangan perangkat lunak kolaboratif untuk proyek perangkat lunak bebas (untuk proyek non-GNU)

**[⬆️ Kembali ke Atas](#table-of-contents)**

## API, Data, dan ML

* [JSONGrid](https://jsongrid.com) - Alat gratis untuk memvisualisasikan, mengedit, memfilter data JSON kompleks ke dalam Grid tabel yang indah. Simpan dan bagikan data JSON melalui tautan.
* [Zerosheets](https://zerosheets.com) - Ubah spreadsheet Google Sheets Anda menjadi API yang kuat untuk mengembangkan prototipe, situs web, aplikasi, dan lainnya dengan cepat. 500 permintaan per bulan tersedia secara gratis.
* [IP.City](https://ip.city) — 100 permintaan geolokasi IP gratis per hari
* [Abstract API](https://www.abstractapi.com) — Paket API untuk berbagai kebutuhan, termasuk geolokasi IP, deteksi gender, atau validasi email.
* [Apify](https://www.apify.com/) — Platform web scraping dan otomasi untuk membuat API dari situs web apa pun dan mengekstrak data. Scraper siap pakai, proxy terintegrasi, dan solusi khusus. Paket gratis dengan kredit platform $5 setiap bulan.
* [APITemplate.io](https://apitemplate.io) - Otomatisasi pembuatan gambar dan dokumen PDF dengan API sederhana atau alat otomasi seperti Zapier & Airtable. Tidak perlu CSS/HTML. Paket gratis mendapatkan 50 gambar/bulan dan tiga template.
* [APIToolkit.io](https://apitoolkit.io) - Semua alat yang Anda butuhkan untuk memahami API dan Backend Anda secara menyeluruh. Dengan validasi dan monitoring kontrak API otomatis. Paket gratis mencakup server dengan hingga 10.000 permintaan per hari.
* [APIVerve](https://apiverve.com) - Akses instan ke lebih dari 120+ API gratis, dibangun dengan kualitas, konsistensi, dan keandalan. Paket gratis mencakup hingga 50 Token API per bulan. (Mungkin sudah ditutup, 2025-06-25)
* [Arize AI](https://arize.com/) - Observabilitas machine learning untuk pemantauan model dan penelusuran masalah seperti kualitas data dan pergeseran performa. Gratis hingga dua model.
* [Maxim AI](https://getmaxim.ai/) - Simulasikan, evaluasi, dan observasi agen AI Anda. Maxim adalah platform observabilitas dan evaluasi end-to-end, membantu tim meluncurkan agen AI mereka secara andal dan >5x lebih cepat. Gratis selamanya untuk pengembang indie dan tim kecil (3 kursi).
* [Beeceptor](https://beeceptor.com) - Mock REST API dalam hitungan detik, API palsu, dan lainnya. Gratis 50 permintaan per hari, dasbor publik, endpoint terbuka (siapa saja dengan tautan dasbor dapat melihat pengiriman dan jawaban).
* [BigDataCloud](https://www.bigdatacloud.com/) - Menyediakan API cepat, akurat, dan gratis (Tanpa batas atau hingga 10K-50K/bulan) untuk web modern seperti IP Geolocation, Reverse Geocoding, Networking Insights, Validasi Email dan Telepon, Info Klien, dan lainnya.
* [Browse AI](https://www.browse.ai) — Mengekstrak dan memantau data di web. 1k kredit per bulan gratis, setara dengan 1k permintaan bersamaan.
* [BrowserCat](https://www.browsercat.com) - API browser headless untuk otomasi, scraping, akses web agen AI, pembuatan gambar/pdf, dan lainnya. Paket gratis dengan 1k permintaan per bulan.
* [Calendarific](https://calendarific.com) - API hari libur publik tingkat enterprise untuk lebih dari 200 negara. Paket gratis mencakup 500 panggilan per bulan.
* [Canopy](https://www.canopyapi.co/) - GraphQL API untuk data produk, pencarian, dan kategori Amazon.com. Paket gratis mencakup 100 panggilan per bulan.
* [Clarifai](https://www.clarifai.com) — API gambar untuk pengenalan dan deteksi wajah kustom. Dapat melatih model AI. Paket gratis memiliki 1.000 panggilan per bulan.
* [Cloudmersive](https://cloudmersive.com/) — Platform API utilitas dengan akses penuh ke perpustakaan API termasuk Konversi Dokumen, Pemindaian Virus, dan lainnya dengan 600 panggilan/bulan, hanya North America AZ, ukuran file maksimum 2,5MB.
* [Colaboratory](https://colab.research.google.com) — Lingkungan notebook Python berbasis web gratis dengan GPU Nvidia Tesla K80.
* [CometML](https://www.comet.com/site/) - Platform MLOps untuk pelacakan eksperimen, manajemen produksi model, registri model, dan data lineage lengkap, mencakup alur kerja dari pelatihan hingga produksi. Gratis untuk individu dan akademik.
* [Commerce Layer](https://commercelayer.io) - API perdagangan komposabel yang dapat membangun, menempatkan, dan mengelola pesanan dari front end mana pun. Paket pengembang memungkinkan 100 pesanan per bulan dan hingga 1.000 SKU secara gratis.
* [Composio](https://composio.dev/) - Platform integrasi untuk AI Agents dan LLMs. Integrasi lebih dari 200+ alat di internet agentik.
* [Conversion Tools](https://conversiontools.io/) - Konverter File Online untuk dokumen, gambar, video, audio, dan eBook. REST API tersedia. Library untuk Node.js, PHP, Python. Mendukung file hingga 50 GB (untuk paket berbayar). Paket gratis dibatasi ukuran file (20MB) dan jumlah konversi (30/hari, 300/bulan).
* [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - API dan Microservice yang menyediakan berbagai informasi seperti negara, wilayah, provinsi, kota, kode pos, dan banyak lagi. Paket gratis mencakup hingga 100 permintaan per hari.
* [Coupler](https://www.coupler.io/) - Alat integrasi data yang menyinkronkan antar aplikasi. Dapat membuat dasbor dan laporan langsung, mengubah dan memanipulasi nilai, serta mengumpulkan dan mencadangkan wawasan. Paket gratis terbatas untuk satu pengguna, koneksi data, sumber data, dan tujuan data. Juga memerlukan refresh data manual.
* [CraftMyPDF](https://craftmypdf.com) - Otomatisasi pembuatan dokumen PDF dari template yang dapat digunakan ulang dengan editor drag-and-drop dan API sederhana. Paket gratis mendapat 100 PDF/bulan dan tiga template.
* [Crawlbase](https://crawlbase.com/) — Crawl dan scrape situs web tanpa proxy, infrastruktur, atau browser. Kami menyelesaikan captcha untuk Anda dan mencegah pemblokiran. 1000 panggilan pertama gratis.
* [CurlHub](https://curlhub.io) — Layanan proxy untuk inspeksi dan debugging panggilan API. Paket gratis mencakup 10.000 permintaan per bulan.
* [CurrencyScoop](https://currencyscoop.com) - API data mata uang real-time untuk aplikasi fintech. Paket gratis mencakup 5.000 panggilan per bulan.
* [Cube](https://cube.dev/) - Cube membantu engineer data dan pengembang aplikasi mengakses data dari data store modern, mengorganisasikannya ke definisi yang konsisten, dan mendistribusikannya ke setiap aplikasi. Cara tercepat menggunakan Cube adalah dengan Cube Cloud, yang memiliki paket gratis terbatas 1.000 query per hari.
* [Data Dead Drop](https://datadeaddrop.com) - Berbagi file sederhana dan gratis. Data akan hancur sendiri setelah diakses. Unggah dan unduh data melalui browser atau client command line favorit Anda.
* [Data Fetcher](https://datafetcher.com) - Hubungkan Airtable ke aplikasi atau API mana pun tanpa kode. Antarmuka seperti Postman untuk menjalankan permintaan API di Airtable. Integrasi siap pakai dengan puluhan aplikasi. Paket gratis mencakup 100 run per bulan.
* [Dataimporter.io](https://www.dataimporter.io) - Alat untuk menghubungkan, membersihkan, dan mengimpor data ke Salesforce. Paket Gratis mencakup hingga 20.000 record per bulan.
* [Datalore](https://datalore.jetbrains.com) - Notebook Python dari Jetbrains. Termasuk penyimpanan 10 GB dan runtime 120 jam setiap bulan.
* [Data Miner](https://dataminer.io/) - Ekstensi browser (Google Chrome, MS Edge) untuk ekstraksi data dari halaman web ke CSV atau Excel. Paket gratis memberi Anda 500 halaman/bulan.
* [Datapane](https://datapane.com) - API untuk membangun laporan interaktif di Python dan men-deploy script Python dan Jupyter Notebook sebagai alat self-service.
* [DB-IP](https://db-ip.com/api/free) - API geolokasi IP gratis dengan 1k permintaan per IP per hari. Lite database di bawah Lisensi CC-BY 4.0 juga gratis.
* [DB Designer](https://www.dbdesigner.net/) — Alat desain dan pemodelan skema Database berbasis cloud dengan paket pemula gratis untuk 2 model Database dan sepuluh tabel per model.
* [DeepAR](https://developer.deepar.ai) — Filter wajah augmented reality untuk platform apa pun dengan satu SDK. Paket gratis menyediakan hingga 10 pengguna aktif bulanan (MAU) dan melacak hingga 4 wajah
* [Deepnote](https://deepnote.com) - Notebook data science baru. Kompatibel dengan Jupyter, kolaborasi real-time, dan berjalan di cloud. Paket gratis termasuk proyek personal tanpa batas, mesin basic tanpa batas dengan RAM 5GB dan 2vCPU, dan tim hingga 3 editor.
* [Disease.sh](https://disease.sh/) — API gratis yang menyediakan data akurat untuk membangun aplikasi terkait Covid-19 yang bermanfaat.
* [Doczilla](https://www.doczilla.app/) — SaaS API untuk pembuatan screenshot atau PDF langsung dari kode HTML/CSS/JS. Paket gratis memungkinkan 250 dokumen per bulan.
* [Doppio](https://doppio.sh/) — Managed API untuk menghasilkan dan menyimpan PDF serta Screenshot secara privat menggunakan teknologi rendering terbaik. Paket gratis memungkinkan 400 PDF dan Screenshot per bulan.
* [drawDB](https://drawdb.app/) — Editor diagram basis data online gratis dan open-source tanpa perlu mendaftar.
* [dreamfactory.com](https://dreamfactory.com/) — Backend REST API open source untuk aplikasi mobile, web, dan IoT. Hubungkan database SQL/NoSQL mana pun, sistem penyimpanan file, atau layanan eksternal, dan secara instan menciptakan platform REST API yang lengkap dengan dokumentasi langsung dan manajemen pengguna.
* [Duply.co](https://duply.co) — Buat gambar dinamis dari API & URL, desain template sekali dan gunakan ulang. Paket gratis menawarkan 20 kredit gratis.
* [DynamicDocs](https://advicement.io) - Hasilkan dokumen PDF dengan API JSON ke PDF berbasis template LaTeX. Paket gratis memungkinkan 50 panggilan API per bulan dan akses ke perpustakaan template.
* [Efemarai](https://efemarai.com) - Platform pengujian dan debugging untuk model dan data ML. Visualisasikan grafik komputasi apa pun. Penggunaan lokal gratis.
* [ERD Lab](https://www.erdlab.io) —  Alat diagram entity relationship (ERD) berbasis cloud gratis untuk developer. Uji coba gratis mencakup 2 proyek dengan masing-masing 10 tabel.
* [ExtendsClass](https://extendsclass.com/rest-client-online.html) - HTTP client berbasis web gratis untuk mengirim permintaan HTTP.
* [Export SDK](https://exportsdk.com) - API generator PDF dengan editor template drag-and-drop yang menyediakan SDK dan integrasi tanpa kode. Paket gratis memiliki 250 halaman bulanan, pengguna tak terbatas, dan tiga template.
* [file.coffee](https://file.coffee/) - Platform di mana Anda dapat menyimpan hingga 15MB/file (30MB/file dengan akun).
* [Financial Data](https://financialdata.net/) - API data pasar saham dan keuangan. Paket gratis memungkinkan 300 permintaan per hari.
* [FormatJSONOnline.com](https://formatjsononline.com) - Alat gratis berbasis browser untuk memformat, memvalidasi, membandingkan, dan meminimalkan data JSON secara instan.
* [FraudLabs Pro](https://www.fraudlabspro.com) — Menyaring transaksi pesanan untuk deteksi penipuan pembayaran kartu kredit. REST API ini mendeteksi semua kemungkinan ciri penipuan berdasarkan parameter input pesanan. Paket Micro Gratis memiliki 500 transaksi per bulan.
* [GeoDataSource](https://www.geodatasource.com) — Layanan pencarian lokasi untuk mencari nama kota menggunakan koordinat lintang dan bujur. API gratis hingga 500 kali per bulan.
* [Geolocated.io](https://geolocated.io) — API Geolokasi IP dengan server multi-benua, menawarkan paket gratis dengan 2.000 permintaan per hari.
* [Glitterly](https://glitterly.app/) - Hasilkan gambar dinamis secara terprogram dari template dasar. Restful API dan integrasi tanpa kode. Paket gratis mendapatkan 50 gambar/bulan dan lima template.
* [Hex](https://hex.tech/) - Platform data kolaboratif untuk notebook, aplikasi data, dan perpustakaan pengetahuan. Paket komunitas gratis dengan hingga lima proyek.
* [Hook0](https://www.hook0.com/) - Hook0 adalah Webhooks-as-a-service (WaaS) open-source yang memudahkan produk online untuk menyediakan webhook. Kirim hingga 100 event/hari dengan retensi histori tujuh hari secara gratis.
* [Hoppscotch](https://hoppscotch.io) - Builder permintaan API yang gratis, cepat, dan indah.
* [huggingface.co](https://huggingface.co) - Membangun, melatih, dan men-deploy model NLP untuk Pytorch, TensorFlow, dan JAX. Gratis hingga 30k karakter input/bulan.
* [Hybiscus](https://hybiscus.dev/) - Bangun laporan PDF dengan API deklaratif sederhana. Paket gratis 14 hari mencakup 50 laporan satu halaman dengan kemampuan kustomisasi palet warna dan font.
* [Invantive Cloud](https://cloud.invantive.com/) — Akses lebih dari 70 platform (cloud) seperti Exact Online, Twinfield, ActiveCampaign, atau Visma menggunakan Invantive SQL atau OData4 (umumnya Power BI atau Power Query). Termasuk replikasi dan pertukaran data. Paket gratis untuk pengembang dan konsultan implementasi. Gratis untuk platform tertentu dengan batasan volume data.
* [ipaddress.sh](https://ipaddress.sh) — Layanan sederhana untuk mendapatkan alamat IP publik dalam berbagai [format](https://about.ipaddress.sh/).
* [ip-api](https://ip-api.com) — API Geolokasi IP, Gratis untuk penggunaan non-komersial, tanpa kunci API, dibatasi 45 permintaan/menit dari IP yang sama untuk paket gratis.
* [ipbase.com](https://ipbase.com) - API Geolokasi IP - Paket gratis selamanya dengan 150 permintaan per bulan.
* [IP Geolocation](https://ipgeolocation.io/) — API Geolokasi IP - Paket gratis selamanya untuk pengembang dengan batas 1.000 permintaan per hari.
* [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — API Geolokasi IP dari Abstract - Mengizinkan 1.000 permintaan gratis.
* [IPLocate](https://www.iplocate.io) — API Geolokasi IP, gratis hingga 1.000 permintaan/hari. Termasuk deteksi proxy/VPN/hosting, data ASN, IP ke Perusahaan, dan lainnya. IPLocate juga menawarkan database IP ke Negara dan IP ke ASN gratis yang dapat diunduh dalam format CSV atau GeoIP-MMDB.
* [IP2Location](https://www.ip2location.com) — Layanan geolokasi IP freemium. Database LITE tersedia gratis untuk diunduh. Impor database ke server dan lakukan query lokal untuk menentukan kota, koordinat, dan informasi ISP.
* [IP2Location.io](https://www.ip2location.io/) — API geolokasi IP freemium, cepat, dan andal. Dapatkan data seperti kota, koordinat, ISP, dan lainnya. Paket gratis mencakup 50k kredit per bulan. IP2Location.io juga menawarkan 500 pencarian WHOIS dan domain host gratis per bulan. Lihat detail registrasi domain dan temukan domain yang dihosting di IP tertentu. Upgrade ke paket berbayar untuk fitur lebih lanjut.
* [ipapi](https://ipapi.co/) - API Lokasi Alamat IP oleh Kloudend, Inc - API geolokasi andal berbasis AWS, dipercaya perusahaan Fortune 500. Paket gratis menawarkan 30k lookup/bulan (1k/hari) tanpa pendaftaran.
* [ipapi.is](https://ipapi.is/) - API Alamat IP yang andal dari Developer untuk Developer dengan kemampuan Deteksi Hosting terbaik. Paket gratis menawarkan 1000 lookup tanpa pendaftaran.
* [IPinfo](https://ipinfo.io/) — API data alamat IP cepat, akurat, dan gratis (hingga 50k/bulan). Menawarkan API dengan detail geolokasi, perusahaan, operator, rentang IP, domain, kontak penyalahgunaan, dan lainnya. Semua API berbayar dapat diuji coba gratis.
* [IPQuery](https://ipquery.io) — API IP tanpa batas untuk pengembang, tanpa batasan laju, atau harga.
* [IPTrace](https://iptrace.io) — API yang sangat sederhana untuk memberikan data geolokasi IP yang andal dan bermanfaat untuk bisnis Anda dengan 50.000 lookup gratis per bulan.
* [JSON2Video](https://json2video.com) - API editing video untuk otomatisasi video pemasaran dan video media sosial, secara terprogram atau tanpa kode.
* [JSON IP](https://getjsonip.com) — Mengembalikan alamat IP Publik dari klien yang memintanya. Tidak perlu registrasi untuk paket gratis. Dengan CORS, data dapat diminta menggunakan JS sisi klien langsung dari browser. Berguna untuk layanan pemantauan perubahan IP klien dan server. Permintaan tanpa batas.
* [JSON Serve](https://jsonserve.com/) — Layanan gratis yang membantu pengembang menyimpan objek JSON dan menggunakan JSON tersebut sebagai REST API di aplikasi mereka.
* [JSONing](https://jsoning.com/api/) — Buat REST API palsu dari objek JSON, dan sesuaikan kode status HTTP, header, dan body respons.
* [konghq.com](https://konghq.com/) — Marketplace API dan alat API privat dan publik yang kuat. Pada paket gratis, beberapa fitur seperti monitoring, alerting, dan support, dibatasi.
* [Kreya](https://kreya.app) — Klien GUI gRPC gratis untuk memanggil dan menguji API gRPC. Dapat mengimpor API gRPC melalui server reflection.
* [Lightly](https://www.lightly.ai/) — Tingkatkan model machine learning Anda dengan menggunakan data yang tepat. Gunakan dataset hingga 1000 sampel gratis.
* [LoginLlama](https://loginllama.app) - API keamanan login untuk mendeteksi login curang dan mencurigakan serta memberi tahu pelanggan Anda. Gratis untuk 1.000 login per bulan.
* [MailboxValidator](https://www.mailboxvalidator.com) — Layanan verifikasi email menggunakan koneksi server email nyata untuk mengonfirmasi email valid. Paket API gratis memiliki 100 verifikasi per bulan.
* [Market Data API](https://www.marketdata.app) - Menyediakan data keuangan real-time dan historis untuk saham, opsi, reksa dana, dan lainnya. Tier API Free Forever memungkinkan 100 permintaan API harian tanpa biaya.
  * [Meteosource Weather API](https://www.meteosource.com/) — API cuaca global untuk data cuaca saat ini dan prediksi. Prediksi didasarkan pada kombinasi machine learning dari beberapa model cuaca untuk mencapai akurasi yang lebih baik. Paket gratis menyediakan 400 panggilan per hari.
  * [microlink.io](https://microlink.io/) – Mengubah situs web apa pun menjadi data seperti normalisasi metatag, pratinjau tautan yang menarik, kemampuan scraping, atau screenshot sebagai layanan. 50 permintaan per hari, gratis setiap hari.
  * [Mindee](https://developers.mindee.com) – Mindee adalah perangkat lunak OCR yang kuat dan platform API-first yang membantu pengembang mengotomatisasi alur kerja aplikasi dengan menstandarisasi lapisan pemrosesan dokumen melalui pengenalan data untuk informasi kunci menggunakan computer vision dan machine learning. Paket gratis menawarkan 500 halaman per bulan.
  * [Mintlify](https://mintlify.com) — Standar modern untuk dokumentasi API. Komponen UI yang indah dan mudah dirawat, pencarian dalam aplikasi, dan playground interaktif. Gratis untuk 1 editor.
  * [MockAPI](https://www.mockapi.io/) — MockAPI adalah alat sederhana yang memungkinkan Anda dengan cepat membuat mock API, menghasilkan data khusus, dan melakukan operasi menggunakan antarmuka RESTful. MockAPI ditujukan sebagai alat prototipe/pengujian/pembelajaran. Satu proyek/2 sumber daya per proyek gratis.
  * [Mockfly](https://www.mockfly.dev/) — Mockfly adalah alat pengembangan tepercaya untuk mocking API dan manajemen feature flag. Cepat menghasilkan dan mengontrol mock API dengan antarmuka intuitif. Paket gratis menawarkan 500 permintaan per hari.
  * [Mocki](https://mocki.io) - Alat yang memungkinkan Anda membuat mock GraphQL dan REST API yang disinkronkan ke repositori GitHub. REST API sederhana gratis untuk dikembangkan dan digunakan tanpa pendaftaran.
  * [Mocko.dev](https://mocko.dev/) — Proxy API Anda, pilih endpoint mana yang ingin di-mock di cloud dan inspeksi lalu lintas, gratis. Mempercepat pengembangan dan pengujian integrasi Anda.
  * [Mocky](https://designer.mocky.io/) - Aplikasi web sederhana untuk menghasilkan respons HTTP kustom guna mocking permintaan HTTP. Juga tersedia sebagai [open source](https://github.com/julien-lafont/Mocky).
  * [Mock N Roll](https://mpcknroll.me/) - Layanan API Mock Gratis—alat kuat untuk mensimulasikan respons API nyata tanpa penundaan backend. Sempurna untuk pengembang frontend, penguji QA, dan tim DevOps. [repo](https://github.com/haerulmuttaqin/mocknroll-web).
  * [microenv.com](https://microenv.com) —  Membuat REST API palsu untuk pengembang dengan kemungkinan menghasilkan kode dan aplikasi dalam kontainer docker.
  * [Multi-Exit IP Address Checker](https://ip.alstra.ca/) —  Alat gratis dan sederhana untuk memeriksa alamat IP keluar Anda di beberapa node dan memahami bagaimana IP Anda terlihat di berbagai wilayah dan layanan global. Berguna untuk menguji alat DNS splitting berbasis aturan seperti Control D.
  * [Namekit](https://namekit.app/) - Penemuan domain bertenaga AI – temukan nama yang tersedia dengan harga standar secara instan. Kueri harian gratis.
  * [News API](https://newsapi.org) — Cari berita di web dengan kode, dan dapatkan hasil JSON. Pengembang mendapat 100 kueri gratis setiap hari. Artikel memiliki keterlambatan 24 jam.
  * [numlookupapi.com](https://numlookupapi.com) - API validasi nomor telepon gratis - 100 permintaan gratis / bulan.
  * [OCR.Space](https://ocr.space/) — API OCR untuk memparsing file gambar dan pdf yang mengembalikan hasil teks dalam format JSON. 25.000 permintaan per bulan gratis dan batas ukuran file 1MB.
  * [OpenAPI3 Designer](https://openapidesigner.com/) — Membuat definisi Open API 3 secara visual secara gratis.
  * [parsehub.com](https://parsehub.com/) — Mengekstrak data dari situs dinamis, mengubah situs web dinamis menjadi API, lima proyek gratis.
  * [Parseur](https://parseur.com) — 20 halaman gratis/bulan: Mengekstrak data dari PDF, email. Didukung AI. Akses API penuh.
  * [PDFBolt](https://pdfbolt.com) - API pembuatan PDF yang berfokus pada pengembang dan dirancang dengan privasi sebagai prioritas. Menawarkan dokumentasi yang terinspirasi Stripe dan termasuk 500 konversi PDF gratis per bulan.
  * [pdfEndpoint.com](https://pdfendpoint.com) - Mengonversi HTML atau URL ke PDF dengan mudah menggunakan API sederhana. 100 konversi per bulan gratis.
  * [PDF-API.io](https://pdf-api.io) - API Otomasi PDF, editor template visual atau HTML ke PDF, integrasi data dinamis, dan rendering PDF dengan API. Paket gratis dilengkapi dengan satu template, 100 PDF/bulan.
  * [Pixela](https://pixe.la/) - Layanan basis data daystream gratis. Semua operasi dilakukan melalui API. Visualisasi dengan heat maps dan grafik garis juga tersedia.
  * [Postman](https://postman.com) — Permudah alur kerja dan buat API lebih baik – lebih cepat – dengan Postman, platform kolaborasi untuk pengembangan API. Gunakan Aplikasi Postman gratis selamanya. Fitur cloud Postman juga gratis selamanya dengan batasan tertentu.
  * [Insomnia](https://insomnia.rest) - Klien API open-source untuk merancang dan menguji API, mendukung REST dan GraphQL
  * [PrefectCloud](https://www.prefect.io/cloud/) — Platform lengkap untuk otomasi aliran data. Paket gratis mencakup 5 alur kerja yang dideploy dan 500 menit kredit komputasi serverless per bulan.
  * [Preset Cloud](https://preset.io/) - Layanan Apache Superset yang dihosting. Gratis selamanya untuk tim hingga 5 pengguna, termasuk dasbor dan grafik tak terbatas, pembuat grafik tanpa kode, dan editor SQL kolaboratif.
  * [PromptLoop](https://www.promptloop.com/) - PromptLoop menghadirkan web scraping AI 10X lebih mudah dengan waktu adopsi hampir nol, penghematan waktu >85% pada alur kerja yang ada, dan beroperasi 4X lebih cepat daripada riset manual tanpa kompromi serta termasuk endpoint REST API untuk semua tugas riset. 1.000 kredit pertama gratis setiap bulan.
  * [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — Daftar API publik gratis.
  * [Rapidapi](https://rapidapi.com/) - Hub API Terbesar di Dunia. Jutaan pengembang menemukan dan terhubung ke ribuan API, Pengembangan API dengan tantangan seru (dengan solusi!) dan contoh interaktif.
  * [RequestBin.com](https://requestbin.com) — Buat endpoint gratis untuk menerima permintaan HTTP. Setiap permintaan HTTP yang dikirim ke endpoint itu akan dicatat dengan payload dan header terkait sehingga Anda bisa mengamati rekomendasi dari webhook dan layanan lain.
  * [reqres.in](https://reqres.in) - REST-API yang dihosting gratis siap merespons permintaan AJAX Anda.
  * [Roboflow](https://roboflow.com) - buat dan deploy model computer vision kustom tanpa pengalaman machine learning sebelumnya. Paket gratis mencakup 30 kredit per bulan.
  * [ROBOHASH](https://robohash.org/) - Layanan web untuk menghasilkan gambar unik dan keren dari teks apa pun.
  * [Scraper's Proxy](https://scrapersproxy.com) — API proxy HTTP sederhana untuk scraping. Scrape secara anonim tanpa khawatir pembatasan, blokir, atau captcha. 100 scrape sukses pertama per bulan gratis termasuk rendering javascript (lebih banyak tersedia jika menghubungi dukungan).
  * [ScrapingAnt](https://scrapingant.com/) — API scraping Chrome headless dan layanan proxy gratis yang telah dicek. Rendering Javascript, proxy rotasi premium, menghindari CAPTCHA. 10.000 kredit API gratis.
  * [Simplescraper](https://simplescraper.io) — Picu webhook Anda setelah setiap operasi. Paket gratis mencakup 100 kredit cloud scrape.
  * [Select Star](https://www.selectstar.com/) - platform penemuan data cerdas yang secara otomatis menganalisis dan mendokumentasikan data Anda. Paket light gratis dengan 2 Sumber Data, hingga 1.000 Tabel dan 25 Pengguna.
  * [Sheetson](https://sheetson.com) - Ubah Google Sheets apa pun menjadi RESTful API secara instan. Paket gratis tersedia, termasuk 1.000 baris gratis per sheet.
  * [Shipyard](https://www.shipyardapp.com) — Platform orkestrasi data low-code untuk cloud. Bangun dengan campuran template low-code dan kode Anda (Python, Node.js, Bash, SQL). Paket pengembang gratis kami menawarkan 10 jam runtime setiap bulan untuk satu pengguna - lebih dari cukup untuk mengotomatisasi berbagai alur kerja.
  * [Siterelic](https://siterelic.com/) - API Siterelic memungkinkan Anda mengambil screenshot, audit situs, pemindaian TLS, lookup DNS, uji TTFB, dan lainnya. Paket gratis menawarkan 100 permintaan API per bulan.
  * [SerpApi](https://serpapi.com/) - API scraping mesin pencari real-time. Mengembalikan hasil JSON terstruktur untuk Google, YouTube, Bing, Baidu, Walmart, dan banyak mesin lain. Paket gratis mencakup 100 panggilan API sukses per bulan.
  * [SmartParse](https://smartparse.io) - SmartParse adalah platform migrasi data dan CSV ke API yang menawarkan alat pengembang hemat waktu dan biaya. Paket Gratis mencakup 300 Unit Pemrosesan per bulan, unggahan Browser, karantina data, pemutus sirkuit, dan Pemberitahuan Pekerjaan.
  * [Sofodata](https://www.sofodata.com/) - Buat RESTful API yang aman dari file CSV. Unggah file CSV dan akses data secara instan melalui API-nya untuk pengembangan aplikasi yang lebih cepat. Paket gratis mencakup 2 API dan 2.500 panggilan API per bulan. Tidak perlu kartu kredit.
  * [Sqlable](https://sqlable.com/) - Kumpulan alat SQL online gratis, termasuk formatter dan validator SQL, penguji regex SQL, generator data palsu, dan playground database interaktif.
  * [Stoplight](https://stoplight.io/) - SaaS untuk merancang dan mendokumentasikan API secara kolaboratif. Paket gratis menawarkan alat desain, mocking, dan dokumentasi gratis.
  * [Supportivekoala](https://supportivekoala.com/) — Memungkinkan Anda menghasilkan gambar secara otomatis dari input Anda melalui template. Paket gratis memungkinkan pembuatan hingga 50 gambar per bulan.
  * [Svix](https://www.svix.com/) - Webhook sebagai Layanan. Kirim hingga 50.000 pesan/bulan gratis.
  * [Tavily AI](https://tavily.com/) - API untuk pencarian online dan wawasan cepat serta riset komprehensif, dengan kemampuan pengorganisasian hasil riset. 1000 permintaan/bulan untuk Paket Gratis tanpa memerlukan kartu kredit.
  * [The IP API](https://theipapi.com/) - API Geolokasi IP dengan 1000 permintaan gratis / hari. Menyediakan informasi tentang lokasi alamat IP, termasuk negara, kota, wilayah, dan lainnya.
  * [TinyMCE](https://www.tiny.cloud) - API pengeditan teks kaya. Fitur inti gratis untuk penggunaan tak terbatas.
  * [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - Menyediakan paket gratis API cuaca. Memberikan prakiraan cuaca akurat dan terbaru dengan cakupan global, data historis, dan solusi pemantauan cuaca.
  * [Treblle](https://www.treblle.com) - Treblle membantu tim membangun, mengirim, dan mengelola API. Dengan agregasi log API tingkat lanjut, observabilitas, dokumentasi, dan debugging. Semua fitur gratis, tetapi ada batas hingga 250 ribu permintaan per bulan pada paket gratis.
  * [UniRateAPI](https://unirateapi.com) – Kurs waktu nyata untuk 590+ mata uang dan crypto. Panggilan API tak terbatas pada paket gratis, sempurna untuk pengembang dan aplikasi keuangan.
  * [vatcheckapi.com](https://vatcheckapi.com) - API validasi nomor VAT sederhana dan gratis. 150 validasi gratis per bulan.
  * [WeatherXu](https://weatherxu.com/) — Data cuaca global termasuk kondisi saat ini, prakiraan per jam dan harian, serta peringatan cuaca melalui API kami. Mengintegrasikan model AI dan sistem ML untuk menganalisis dan menggabungkan banyak model cuaca guna memberikan akurasi prakiraan yang lebih baik. Paket gratis mencakup 10.000 panggilan API/bulan.
  * [Webhook Store](https://www.openwebhook.io) - Alat untuk menyimpan webhook pihak ketiga dan debug di localhost (gaya ngrok). Open source dan dapat di-host sendiri. Domain pribadi gratis *username*.github.webhook.store, domain publik gratis *apa saja*.webhook.store.
  * [WebScraping.AI](https://webscraping.ai) - API Web Scraping sederhana dengan parsing bawaan, rendering Chrome, dan proxy. Dua ribu panggilan API gratis per bulan.
  * [Weights & Biases](https://wandb.ai) — Platform MLOps berorientasi pengembang. Bangun model lebih baik dengan pelacakan eksperimen, versioning dataset, dan manajemen model. Paket gratis hanya untuk proyek pribadi, termasuk 100 GB penyimpanan.
  * [What The Diff](https://whatthediff.ai) - Asisten review kode bertenaga AI. Paket gratis memiliki batas 25.000 token bulanan (~10 PR).
  * [wolfram.com](https://wolfram.com/language/) — Algoritma berbasis pengetahuan built-in di cloud.
  * [wrapapi.com](https://wrapapi.com/) — Ubah situs web apa pun menjadi API terparameterisasi. 30 ribu panggilan API per bulan.
  * [Zenscrape](https://zenscrape.com/web-scraping-api) — API web scraping dengan browser headless, IP residensial, dan harga yang jelas. Seribu panggilan API gratis/bulan dan kredit ekstra untuk pelajar dan organisasi nirlaba.
  * [Zipcodebase](https://zipcodebase.com) - API Kode Pos gratis, akses ke Data Kode Pos Seluruh Dunia. 5.000 permintaan gratis/bulan.
  * [Zipcodestack](https://zipcodestack.com) - API Kode Pos dan Validasi Kode Pos Gratis. Sepuluh ribu permintaan gratis/bulan.
  * [Zuplo](https://zuplo.com/) - Platform Manajemen API gratis untuk mendesain, membangun, dan deploy API ke Edge. Tambahkan autentikasi API Key, rate limiting, dokumentasi pengembang, dan Monetisasi ke API apa pun dalam hitungan menit. Native OpenAPI dan sepenuhnya dapat diprogram dengan web standard apis & Typescript. Paket gratis menawarkan hingga 10 proyek, lingkungan edge produksi tak terbatas, 1 juta permintaan bulanan, dan 10GB egress.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Repos Artefak

  * [Artifactory](https://jfrog.com/start-free/) - Repositori artefak yang mendukung banyak format paket seperti Maven, Docker, Cargo, Helm, PyPI, CocoaPods, dan GitLFS. Termasuk alat pemindaian paket XRay dan alat CI/CD Pipelines (dulu Shippable) dengan paket gratis 2.000 menit CI/CD per bulan.
  * [central.sonatype.org](https://central.sonatype.org) — Repositori artefak default untuk Apache Maven, SBT, dan sistem build lainnya.
  * [cloudrepo.io](https://cloudrepo.io) - Repositori Maven dan PyPi berbasis cloud, privat dan publik. Gratis untuk proyek open-source.
  * [cloudsmith.io](https://cloudsmith.io) — Layanan repositori sederhana, aman, dan terpusat untuk Java/Maven, RedHat, Debian, Python, Ruby, Vagrant, dan lainnya. Paket gratis + gratis untuk open source.
  * [jitpack.io](https://jitpack.io/) — Repositori Maven untuk proyek JVM dan Android di GitHub, gratis untuk proyek publik.
  * [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — Layanan hosting repositori yang mudah digunakan untuk paket Maven, RPM, DEB, PyPi, NPM, dan RubyGem (memiliki paket gratis).
  * [repsy.io](https://repsy.io) — 1 GB Repositori Maven privat/publik gratis.
  * [Gemfury](https://gemfury.com) — Repositori artefak privat dan publik untuk Maven, PyPi, NPM, Go Module, Nuget, APT, dan RPM. Gratis untuk proyek publik.
  * [paperspace](https://www.paperspace.com/) — Bangun & skalakan model AI, kembangkan, latih, dan deploy aplikasi AI, paket gratis: proyek publik, penyimpanan 5Gb, instance dasar.
  * [RepoForge](https://repoforge.io) - Repositori privat berbasis cloud untuk paket Python, Debian, NPM, dan registry Docker. Paket gratis untuk proyek open source/publik.
  * [RepoFlow](https://repoflow.io) - RepoFlow Memudahkan manajemen paket dengan dukungan untuk npm, PyPI, Docker, Go, Helm, dan lainnya. Coba gratis dengan 10GB storage, 10GB bandwidth, 100 paket, dan pengguna tak terbatas di cloud, atau self-hosted untuk penggunaan pribadi saja.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Alat untuk Tim dan Kolaborasi
  * [3Cols](https://3cols.com/) - Pengelola cuplikan kode berbasis cloud gratis untuk penggunaan pribadi dan kolaboratif.
  * [Bitwarden](https://bitwarden.com) — Cara termudah dan teraman bagi individu, tim, dan organisasi bisnis untuk menyimpan, berbagi, dan sinkronisasi data sensitif.
  * [Braid](https://www.braidchat.com/) — Aplikasi chat yang dirancang untuk tim. Gratis untuk grup akses publik, pengguna tak terbatas, riwayat, dan integrasi. Juga tersedia versi open-source yang dapat di-host sendiri.
  * [cally.com](https://cally.com/) — Temukan waktu dan tanggal terbaik untuk rapat. Mudah digunakan, cocok untuk kelompok kecil maupun besar.
  * [Calendly](https://calendly.com) — Calendly adalah alat untuk menghubungkan dan menjadwalkan pertemuan. Paket gratis menyediakan 1 koneksi Kalender per pengguna dan Sesi tak terbatas. Aplikasi Desktop dan Mobile juga tersedia.
  * [Discord](https://discord.com/) — Chat dengan ruang publik/privat. Teks Markdown, suara, video, dan kemampuan berbagi layar. Gratis untuk pengguna tak terbatas.
  * [Fibo](https://fibo.dev) - Alat scrum poker realtime online gratis untuk tim agile yang memungkinkan anggota tak terbatas memperkirakan story point untuk perencanaan lebih cepat.
  * [Telegram](https://telegram.org/) — Telegram untuk semua yang menginginkan pesan dan panggilan cepat serta andal. Pengguna bisnis dan tim kecil mungkin menyukai grup besar, username, aplikasi desktop, dan opsi berbagi file yang kuat.
  * [DevToolLab](https://devtoollab.com) — Alat pengembang online yang menawarkan akses gratis ke semua alat dasar, dengan kemampuan auto save satu entri per alat, kecepatan pemrosesan standar, dan dukungan komunitas.
  * [Dubble](https://dubble.so/) — Pembuat Panduan Langkah-demi-Langkah gratis. Ambil tangkapan layar, dokumentasikan proses, dan kolaborasi dengan tim Anda. Juga mendukung perekaman layar async.
  * [Duckly](https://duckly.com/) — Bicara dan kolaborasi secara real time dengan tim Anda. Pair programming dengan IDE, berbagi terminal, suara, video, dan layar. Gratis untuk tim kecil.
  * [Dyte](https://dyte.io) - SDK video & audio live paling ramah pengembang, dilengkapi plugin kolaboratif untuk meningkatkan produktivitas dan keterlibatan. Paket gratis termasuk 10.000 menit penggunaan video/audio live per bulan.
  * [evernote.com](https://evernote.com/) — Alat untuk mengorganisir informasi. Bagikan catatan Anda dan kerja sama dengan orang lain
  * [Fibery](https://fibery.io/) — Platform workspace terhubung. Gratis untuk pengguna tunggal, hingga 2 GB ruang disk.
  * [flock.com](https://flock.com) — Cara yang lebih cepat untuk tim Anda berkomunikasi. Pesan, Channel, Pengguna, Aplikasi & Integrasi Tak Terbatas Gratis.
  * [Gather](https://www.gather.town/) - Cara yang lebih baik untuk bertemu secara online. Berpusat pada ruang yang sepenuhnya dapat disesuaikan, Gather membuat menghabiskan waktu dengan komunitas Anda semudah kehidupan nyata. Gratis untuk hingga 10 pengguna bersamaan.
  * [gokanban.io](https://gokanban.io) - Papan Kanban berbasis sintaks tanpa registrasi untuk penggunaan cepat. Gratis tanpa batasan.
  * [flat.social](https://flat.social) - Ruang interaktif yang dapat disesuaikan untuk rapat tim & sosialisasi happy hour. Rapat tak terbatas, gratis hingga 8 pengguna bersamaan.
  * [GitDailies](https://gitdailies.com) - Laporan harian aktivitas Commit dan Pull Request tim Anda di GitHub. Termasuk visualizer Push, sistem pengakuan rekan, dan pembuat alert kustom. Tier gratis memiliki pengguna tak terbatas, tiga repo, dan 3 konfigurasi alert.
  * [gitter.im](https://gitter.im/) — Chat untuk GitHub. Ruang publik dan privat tak terbatas, gratis untuk tim hingga 25 orang.
  * [Hackmd.io](https://hackmd.io/) - Alat kolaborasi & penulisan waktu nyata untuk dokumen/file format markdown. Mirip Google Docs tapi untuk file markdown. Gratis jumlah "catatan" tak terbatas, namun jumlah kolaborator (undangan) untuk catatan privat & template [akan dibatasi](https://hackmd.io/pricing).
  * [hangouts.google.com](https://hangouts.google.com/) — Satu tempat untuk semua percakapan Anda, gratis, memerlukan akun Google.
  * [HeySpace](https://hey.space) - Alat manajemen tugas dengan chat, kalender, timeline, dan panggilan video. Gratis untuk hingga 5 pengguna.
  * [helplightning.com](https://www.helplightning.com/) — Bantuan melalui video dengan augmented reality. Gratis tanpa analitik, enkripsi, dukungan.
  * [ideascale.com](https://ideascale.com/) — Memungkinkan klien untuk mengirim ide dan voting, gratis untuk 25 anggota dalam 1 komunitas.
  * [Igloo](https://www.igloosoftware.com/) — Portal internal untuk berbagi dokumen, blog, kalender, dll. Gratis untuk hingga 10 pengguna.
  * [Keybase](https://keybase.io/) — Keybase adalah alternatif FOSS untuk Slack; menjaga chat dan file semua orang tetap aman, dari keluarga hingga komunitas hingga perusahaan.
  * [Google Meet](https://meet.google.com/) — Gunakan Google Meet untuk kebutuhan rapat video online bisnis Anda. Meet menyediakan rapat online yang aman dan mudah diakses.
  * [/meet for Slack](https://meetslack.com) - Mulai Google Meetings langsung dari Slack dengan menggunakan /meet di channel, grup, atau DM mana pun. Gratis tanpa batasan.
  * [Livecycle](https://www.livecycle.io/) — Livecycle adalah platform kolaborasi inklusif yang membuat alur kerja lancar untuk tim produk lintas fungsi dan proyek open-source.
  * [Lockitbot](https://www.lockitbot.com/) — Pesan dan kunci sumber daya bersama dalam Slack seperti Ruangan, lingkungan Dev, server, dll. Gratis untuk hingga 2 sumber daya.
  * [MarkUp](https://www.markup.io/) — MarkUp memungkinkan Anda mengumpulkan umpan balik langsung di atas situs web, PDF, dan gambar Anda.
  * [Proton Pass](https://proton.me/pass) — Pengelola kata sandi dengan alias email bawaan, autentikator 2FA, berbagi, dan passkeys. Tersedia di web, ekstensi browser, aplikasi mobile, dan desktop.
  * [Visual Debug](https://visualdebug.com) - Alat umpan balik visual untuk komunikasi klien-dev yang lebih baik.
  * [meet.jit.si](https://meet.jit.si/) — Percakapan video satu klik, dan berbagi layar, gratis.
  * [Microsoft Teams](https://products.office.com/microsoft-teams/free) — Microsoft Teams adalah pusat digital berbasis chat yang menggabungkan percakapan, konten, dan aplikasi dalam satu pengalaman. Gratis untuk hingga 500 ribu pengguna.
  * [Miro](https://miro.com/) - Papan tulis kolaborasi yang skalabel, aman, lintas perangkat, dan siap untuk perusahaan bagi tim terdistribusi. Dengan rencana freemium.
  * [nootiz](https://www.nootiz.com/) - Alat utama untuk mengumpulkan dan mengelola umpan balik visual di situs web apa pun.
  * [Notion](https://www.notion.so/) - Notion adalah aplikasi pencatatan dan kolaborasi dengan dukungan markdown yang mengintegrasikan tugas, wiki, dan basis data. Perusahaan menggambarkan aplikasi ini sebagai ruang kerja all-in-one untuk pencatatan, manajemen proyek, dan manajemen tugas. Selain aplikasi lintas platform, Notion dapat diakses melalui sebagian besar browser web.
  * [Nuclino](https://www.nuclino.com) - Wiki kolaboratif ringan untuk semua pengetahuan, dokumen, dan catatan tim Anda. Paket gratis dengan semua fitur esensial, hingga 50 item, dan penyimpanan 5GB.
  * [OnlineInterview.io](https://onlineinterview.io/) - Platform wawancara kode gratis dengan chat video tersemat, papan gambar, dan editor kode online di mana Anda dapat mengompilasi dan menjalankan kode di browser. Anda dapat membuat ruang wawancara jarak jauh hanya dengan satu klik.
  * [Quidlo Timesheets](https://www.quidlo.com/timesheets) - Aplikasi timesheet dan pelacak waktu sederhana untuk tim. Paket gratis memiliki fitur pelacak waktu dan pembuatan laporan untuk hingga 10 pengguna.
  * [PageShare.dev](https://www.pageshare.dev) - Menambahkan kemampuan ulasan visual ke Pull Request GitHub tanpa perlu deploy website. Gratis untuk hingga 10 halaman setiap bulan dan total penyimpanan 100MB.
  * [Pendulums](https://pendulums.io/) - Pendulums adalah alat pelacak waktu gratis yang membantu Anda mengelola waktu dengan antarmuka mudah dan statistik berharga.
  * [Pumble](https://pumble.com) - Aplikasi chat tim gratis. Pengguna tak terbatas dan riwayat pesan, gratis selamanya.
  * [Raindrop.io](https://raindrop.io) - Aplikasi penanda buku privat dan aman untuk macOS, Windows, Android, iOS, dan Web. Penanda dan kolaborasi tak terbatas gratis.
  * [element.io](https://element.io/) — Alat komunikasi terdesentralisasi dan open-source yang dibangun di atas Matrix. Chat grup, pesan langsung, transfer file terenkripsi, chat suara dan video, serta integrasi mudah dengan layanan lain.
  * [Rocket.Chat](https://rocket.chat/) - Platform komunikasi open-source dengan fitur Omnichannel, Matrix Federation, Bridge ke aplikasi lain, pesan tak terbatas, dan riwayat pesan penuh.
  * [seafile.com](https://www.seafile.com/) — Penyimpanan pribadi atau cloud, berbagi file, sinkronisasi, diskusi. Versi cloud hanya 1 GB.
  * [Sema](https://www.semasoftware.com/) - Alat portofolio pengembang gratis yang dapat mengkonsolidasikan dan mengambil snapshot kontribusi di beberapa repositori ke dalam satu laporan.
  * [Screen Sharing via Browser](https://screensharing.net) - Alat berbagi layar gratis, bagikan layar Anda dengan kolaborator langsung dari browser, tanpa perlu download atau registrasi. Gratis.
  * [Slab](https://slab.com/) — Layanan manajemen pengetahuan modern untuk tim. Gratis untuk hingga 10 pengguna.
  * [slack.com](https://slack.com/) — Gratis untuk pengguna tak terbatas dengan beberapa batasan fitur.
  * [Spectrum](https://spectrum.chat/) - Buat komunitas publik atau privat secara gratis.
  * [StatusPile](https://www.statuspile.com/) - Halaman status dari halaman status. Apakah Anda dapat melacak halaman status dari penyedia upstream Anda?
  * [Stickies](https://stickies.app/) - Aplikasi kolaborasi visual untuk brainstorming, kurasi konten, dan catatan. Gratis untuk hingga 3 Walls, pengguna tak terbatas, dan 1 GB penyimpanan.
  * [Stacks](https://betterstacks.com/) - Workspace konten dengan catatan, tautan, dan penyimpanan file terintegrasi untuk menavigasi kelebihan informasi. Paket pribadi gratis selamanya.
  * [talky.io](https://talky.io/) — Chat video grup gratis. Anonim. Peer-to-peer. Tidak perlu plugin, signup, atau pembayaran.
  * [Teamhood](https://teamhood.com/) - Software pelacak Proyek, Tugas, dan Isu gratis. Mendukung Kanban dengan Swimlanes dan implementasi Scrum penuh. Memiliki pelacak waktu terintegrasi. Gratis untuk lima pengguna dan tiga portofolio proyek.
  * [Teamplify](https://teamplify.com) - meningkatkan proses pengembangan tim dengan Team Analytics dan Smart Daily Standup. Termasuk manajemen Cuti lengkap untuk tim remote. Gratis untuk grup kecil hingga 5 pengguna.
  * [Tefter](https://tefter.io) - Aplikasi bookmark dengan integrasi Slack yang kuat. Gratis untuk tim open-source.
  * [TeleType](https://teletype.oorja.io/) — berbagi terminal, suara, kode, papan tulis, dan lainnya. Tidak perlu sign-in untuk kolaborasi terenkripsi end-to-end bagi pengembang.
  * [TimeCamp](https://www.timecamp.com/) - Software pelacak waktu gratis untuk pengguna tak terbatas. Mudah diintegrasikan dengan alat PM seperti Jira, Trello, Asana, dll.
  * [Huly](https://huly.io/) - Platform Manajemen Proyek All-in-One (alternatif Linear, Jira, Slack, Notion, Motion) - pengguna tak terbatas, 10GB penyimpanan per workspace, 10GB lalu lintas video(audio).
  * [Teamcamp](https://www.teamcamp.app) - Aplikasi manajemen proyek all-in-one untuk perusahaan pengembang perangkat lunak.
  * [twist.com](https://twist.com) — Aplikasi komunikasi tim yang ramah asinkron di mana percakapan tetap terorganisir dan sesuai topik. Paket Gratis dan Unlimited tersedia. Diskon untuk tim yang memenuhi syarat.
  * [tldraw.com](https://tldraw.com) — Alat whiteboard dan diagram open-source gratis dengan fitur panah pintar, snapping, sticky notes, dan ekspor SVG. Mode multiplayer untuk kolaborasi. Ekstensi resmi VS Code gratis juga tersedia.
  * [BookmarkOS.com](https://bookmarkos.com) - Manajer bookmark, manajer tab, dan manajer tugas all-in-one gratis dalam desktop online yang dapat dikustomisasi dengan kolaborasi folder.
  * [typetalk.com](https://www.typetalk.com/) — Bagikan dan diskusikan ide dengan tim Anda melalui pesan instan di web atau mobile Anda.
  * [Tugboat](https://tugboat.qa) - Pratinjau setiap pull request, otomatis dan on-demand. Gratis untuk semua, tier Nano gratis untuk organisasi non-profit.
  * [whereby.com](https://whereby.com/) — Percakapan video satu klik, gratis (sebelumnya dikenal sebagai appear.in).
  * [windmill.dev](https://windmill.dev/) - Windmill adalah platform pengembang open-source untuk membangun otomatisasi multi-langkah dan aplikasi internal tingkat produksi dari skrip Python dan Typescript minimal. Sebagai pengguna gratis, Anda dapat membuat dan menjadi anggota maksimal tiga workspace non-premium.
  * [vadoo.tv](https://vadoo.tv/) — Hosting dan pemasaran video menjadi sederhana. Upload video dengan satu klik. Rekam, kelola, bagikan & lainnya. Tier gratis menyediakan hingga 10 video, 1 GB penyimpanan, dan 10 GB bandwidth/bulan.
  * [userforge.com](https://userforge.com/) - Persona online yang saling terhubung, user stories, dan context mapping. Membantu menjaga desain dan dev tetap sinkron gratis hingga 3 persona dan dua kolaborator.
  * [wistia.com](https://wistia.com/) — Hosting video dengan analitik penonton, pengiriman video HD, dan alat pemasaran untuk memahami pengunjung Anda, 25 video, dan pemutar bermerek Wistia.
  * [wormhol.org](https://www.wormhol.org/) — Layanan berbagi file yang sederhana. Bagikan file tak terbatas hingga 5GB dengan sebanyak mungkin rekan yang Anda inginkan.
  * [Wormhole](https://wormhole.app/) - Bagikan file hingga 5GB dengan enkripsi end-to-end selama maksimal 24 jam. Untuk file di atas 5GB, menggunakan transfer peer-to-peer langsung.
  * [zoom.us](https://zoom.us/) — Add-on konferensi Video dan Web yang aman tersedia. Paket gratis dibatasi hingga 40 menit.
  * [Zulip](https://zulip.com/) — Chat waktu nyata dengan model threading unik seperti email. Paket gratis mencakup riwayat pencarian 10.000 pesan dan penyimpanan file hingga 5 GB. juga menyediakan versi open-source yang dapat di-host sendiri.
  * [robocorp.com](https://robocorp.com) - Stack open-source untuk mendukung Automation Ops. Coba fitur Cloud dan implementasikan otomatisasi sederhana secara gratis. Robot bekerja 240 menit/bulan, 10 Assistant run, Penyimpanan 100 MB.
  * [Fleep.io](https://fleep.io/) — Fleep adalah alternatif Slack. Memiliki paket gratis untuk tim kecil dengan riwayat pesan penuh, percakapan 1:1 tak terbatas, 1 percakapan grup, dan penyimpanan file 1 GB.
  * [Chanty.com](https://chanty.com/) — Chanty adalah alternatif Slack lainnya. Memiliki paket gratis selamanya untuk tim kecil (hingga 10 orang) dengan percakapan publik dan privat tak terbatas, riwayat yang bisa dicari, panggilan audio 1:1 tak terbatas, pesan suara tak terbatas, sepuluh integrasi, dan 20 GB penyimpanan per tim.
  * [ruttl.com](https://ruttl.com/) — Alat umpan balik all-in-one terbaik untuk mengumpulkan feedback digital dan meninjau situs web, PDF, dan gambar.
  * [Mattermost](https://mattermost.com/) — Kolaborasi aman untuk tim teknis. Paket gratis dengan channel tak terbatas, playbook, boards, pengguna, penyimpanan 10GB, dan lainnya.
  * [Webvizio](https://webvizio.com) — Alat feedback situs web, software ulasan situs web, dan alat pelaporan bug untuk memperlancar kolaborasi pengembangan web pada tugas langsung di situs web dan aplikasi web, gambar, PDF, dan file desain.
  * [Pullflow](https://pullflow.com) — Pullflow menawarkan platform kolaborasi code review dengan AI di GitHub, Slack, dan VS Code.
  * [Webex](https://www.webex.com/) — Rapat video dengan paket gratis menawarkan 40 menit per rapat dengan 100 peserta.
  * [RingCentral](https://www.ringcentral.com/) — Rapat video dengan paket gratis menawarkan 50 menit per rapat dengan 100 peserta.
  * [GitBook](https://www.gitbook.com/) — Platform untuk menangkap dan mendokumentasikan pengetahuan teknis — dari dokumen produk hingga basis pengetahuan internal dan API. Paket gratis untuk pengembang individu.
  * [transfernow](https://www.transfernow.net/) — antarmuka paling sederhana, tercepat, dan teraman untuk mentransfer dan berbagi file. Kirim foto, video, dan file besar lainnya tanpa langganan wajib.
  * [paste.sh](https://paste.sh/) — Situs paste sederhana berbasis JavaScript dan Crypto.
  * [Revolt.chat](https://revolt.chat/) — Alternatif OpenSource untuk [Discord](https://discord.com/), yang menghormati privasi Anda. Juga memiliki sebagian besar fitur proprietary dari discord secara gratis. Revolt adalah aplikasi all-in-one yang aman dan cepat, serta 100% gratis. Semua fiturnya gratis. Mereka juga memiliki dukungan plugin (resmi & tidak resmi) tidak seperti aplikasi chatting mainstream lainnya.
  * [Tencent RTC](https://trtc.io/) — Tencent Real-Time Communication (TRTC) menawarkan solusi panggilan audio/video grup. 10.000 menit gratis/bulan untuk tahun pertama.
  * [Pastefy](https://pastefy.app/) - Pastebin yang indah dan sederhana dengan Client-Encryption opsional, Multitab-Pastes, API, Editor dengan highlight dan lainnya.
  * [SiteDots](https://sitedots.com/) - Bagikan feedback untuk proyek website langsung di website Anda, tanpa emulasi, canvas, atau solusi lain. Tier gratis sepenuhnya fungsional.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## CMS

  * [acquia.com](https://www.acquia.com/) — Hosting untuk situs Drupal. Tier gratis untuk pengembang. Alat pengembangan gratis (seperti Acquia Dev Desktop) juga tersedia.
  * [Contentful](https://www.contentful.com/) — Headless CMS. API manajemen dan pengiriman konten di cloud. Termasuk satu ruang Community gratis dengan lima pengguna, 25K record, 48 Content Types, 2 locale.
  * [Cosmic](https://www.cosmicjs.com/) — Headless CMS dan toolkit API. Paket personal gratis untuk pengembang.
  * [Crystallize](https://crystallize.com) — Headless PIM dengan dukungan ecommerce. Built-in GraphQL API. Versi gratis termasuk pengguna tak terbatas, 1000 item katalog, bandwidth 5 GB/bulan, dan 25k panggilan API/bulan.
  * [DatoCMS](https://www.datocms.com/) - Menawarkan tier gratis untuk proyek kecil. DatoCMS adalah CMS berbasis GraphQL. Pada tier terendah, Anda mendapat 100k panggilan/bulan.
  * [Directus](https://directus.io) — Headless CMS. Platform gratis dan open-source sepenuhnya untuk mengelola aset dan konten database on-prem atau di Cloud. Tidak ada batasan atau paywall.
  * [FrontAid](https://frontaid.io/) — Headless CMS yang menyimpan konten JSON langsung di repositori Git Anda. Tanpa batasan.
  * [kontent.ai](https://www.kontent.ai) - Platform Content-as-a-Service yang memberikan semua manfaat headless CMS sambil memberdayakan marketer sekaligus. Paket developer memberikan dua pengguna dengan proyek tak terbatas dan dua lingkungan untuk tiap proyek, 500 item konten, dua bahasa dengan Delivery dan Management API, serta dukungan Custom elements. Anda dapat menggunakan paket yang lebih detail sesuai kebutuhan.
  * [Prismic](https://www.prismic.io/) — Headless CMS. Antarmuka manajemen konten dengan API yang di-host sepenuhnya dan dapat diskalakan. Community Plan menyediakan panggilan API, dokumen, custom type, aset, dan locale tak terbatas untuk satu pengguna. Semua yang Anda butuhkan untuk proyek berikutnya. Paket gratis lebih besar tersedia untuk proyek Open Content/Open Source.
  * [Sanity.io](https://www.sanity.io/) - Platform untuk konten terstruktur dengan lingkungan pengeditan open-source dan data store yang di-host real-time. Proyek tak terbatas. Admin tak terbatas, tiga pengguna non-admin, dua dataset, 500K permintaan API CDN, bandwidth 10GB, dan aset 5GB gratis per proyek.
  * [sensenet](https://sensenet.com) - Headless CMS API-first yang menyediakan solusi kelas enterprise untuk bisnis dari semua ukuran. Paket Developer menyediakan tiga pengguna, 500 item konten, tiga peran bawaan, 25+5 content type, REST API yang sepenuhnya dapat diakses, preview dokumen, dan pengeditan Office Online.
  * [TinaCMS](https://tina.io/) — Pengganti Forestry.io. Headless CMS open source berbasis Git yang mendukung Markdown, MDX, dan JSON. Paket dasar gratis untuk dua pengguna.
  * [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby adalah framework cepat dan fleksibel yang membuat pembuatan situs web dengan CMS, API, atau database apa pun menjadi menyenangkan kembali. Bangun dan deploy situs web headless yang menghasilkan lebih banyak trafik, konversi lebih baik, dan pendapatan lebih tinggi!
  * [Hygraph](https://hygraph.com/) - Menawarkan tier gratis untuk proyek kecil. API pertama GraphQL. Beralih dari solusi lama ke Headless CMS native GraphQL - dan hadirkan API konten omnichannel sejak awal.
* [Squidex](https://squidex.io/) - Menawarkan paket gratis untuk proyek kecil. API / GraphQL first. Open source dan berbasis event sourcing (setiap perubahan otomatis memiliki versi).
* [InstaWP](https://instawp.com/) - Luncurkan situs WordPress dalam hitungan detik. Paket gratis dengan 5 Situs Aktif, 500 MB Ruang, masa berlaku situs 48 jam.
* [Storyblok](https://www.storyblok.com) - Headless CMS untuk developer dan marketer yang kompatibel dengan semua framework modern. Paket Community (gratis) menawarkan Management API, Visual Editor, sepuluh sumber, Custom Field Types, Internasionalisasi (bahasa/lokasi tak terbatas), Asset Manager (hingga 2500 aset), Image Optimizing Service, Search Query, Webhook + 250GB Traffic/bulan sudah termasuk.
* [WPJack](https://wpjack.com) - Pasang WordPress di cloud mana saja dalam kurang dari 5 menit! Paket gratis mencakup 1 server, 2 situs, sertifikat SSL gratis, dan cron job tak terbatas. Tanpa batas waktu atau kadaluarsa—website Anda, cara Anda.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Code Generation

* [Appinvento](https://appinvento.io/) — AppInvento adalah pembuat aplikasi tanpa kode yang gratis. Pada kode backend yang dihasilkan otomatis, pengguna memiliki akses penuh ke source code dan API serta routes tak terbatas, memungkinkan integrasi yang luas. Paket gratis mencakup tiga proyek, lima tabel, dan add-on Google.
* [Cody AI](https://sourcegraph.com/cody) - Cody adalah asisten AI pemrograman yang menggunakan AI dan pemahaman mendalam terhadap codebase Anda untuk membantu menulis dan memahami kode lebih cepat. Cody menawarkan pilihan LLM untuk developer (termasuk inferensi lokal), mendukung berbagai IDE, mendukung semua bahasa pemrograman populer, dan memiliki paket gratis. Paket gratis menyediakan 20 pesan chat (menggunakan Claude 3 Sonnet sebagai LLM) dan 500 autocompletion (menggunakan Starcoder 16b) setiap bulan.
* [DhiWise](https://www.dhiwise.com/) — Ubah desain Figma menjadi aplikasi Flutter & React dinamis dengan teknologi code generation inovatif dari DhiWise, mengoptimalkan alur kerja dan membantu Anda membuat pengalaman mobile dan web luar biasa lebih cepat dari sebelumnya.
* [Codeium](https://www.codeium.com/) — Codeium adalah alat pelengkapan kode berbasis AI gratis. Mendukung lebih dari 20+ bahasa pemrograman (Python, JavaScript, Java, TypeScript, PHP, C/C++, Go, dll.) dan terintegrasi dengan semua IDE utama, baik standalone maupun web.
* [Fern](https://buildwithfern.com) - Tulis definisi API dan gunakan untuk menghasilkan SDK/library klien dalam bahasa populer seperti TypeScript, Python, Java, Go, dan lainnya. Mendukung OpenAPI sepenuhnya. Paket gratis menghasilkan kode untuk maksimal 20 endpoint.
* [Metalama](https://www.postsharp.net/metalama) - Khusus untuk C#. Metalama menghasilkan boilerplate kode secara otomatis saat kompilasi sehingga source code Anda tetap bersih. Gratis untuk proyek open-source, dan paket gratis ramah komersial mencakup tiga aspek.
* [Supermaven](https://www.supermaven.com/) — Supermaven adalah plugin pelengkapan kode AI yang cepat untuk VSCode, JetBrains, dan Neovim. Paket gratis menyediakan pelengkapan inline tanpa batas.
* [tabnine.com](https://www.tabnine.com/) — Tabnine membantu developer membuat perangkat lunak lebih baik dan lebih cepat dengan memberikan wawasan yang dipelajari dari semua kode di dunia. Tersedia plugin.
* [v0.dev](https://v0.dev/) — v0 menggunakan model AI untuk menghasilkan kode berdasarkan prompt teks sederhana. Menghasilkan kode React siap copy-paste berbasis shadcn/ui dan Tailwind CSS yang dapat digunakan di proyek Anda. Setiap generasi memerlukan minimal 30 kredit. Anda mulai dengan 1200 kredit, dan mendapatkan 200 kredit gratis setiap bulan.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Code Quality

* [beanstalkapp.com](https://beanstalkapp.com/) — Workflow lengkap untuk menulis, meninjau, dan melakukan deploy kode, akun gratis untuk satu pengguna, dan satu repository dengan 100 MB storage
* [browserling.com](https://www.browserling.com/) — Pengujian cross-browser interaktif secara langsung, gratis hanya untuk sesi 3 menit dengan MS IE 9 di Vista pada resolusi 1024 x 768
* [codacy.com](https://www.codacy.com/) — Review kode otomatis untuk PHP, Python, Ruby, Java, JavaScript, Scala, CSS, dan CoffeeScript, gratis untuk repository publik dan privat tanpa batas
* [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - Alat review otomatis Infrastructure as Code untuk DevOps yang terintegrasi dengan GitHub, Bitbucket, dan GitLab (termasuk self-hosted). Selain bahasa standar, juga menganalisis Ansible, Terraform, CloudFormation, Kubernetes, dan lainnya. (gratis open-source)
* [CodeBeat](https://codebeat.co) — Platform Review Kode Otomatis untuk banyak bahasa. Gratis selamanya untuk repo publik dengan integrasi Slack dan email.
* [codeclimate.com](https://codeclimate.com/) — Review kode otomatis, gratis untuk Open Source dan repositori privat milik organisasi tanpa batas (hingga 4 kolaborator). Juga gratis untuk pelajar dan institusi.
* [codecov.io](https://codecov.io/) — Alat pelaporan cakupan kode (SaaS), gratis untuk Open Source dan satu repo privat gratis
* [CodeFactor](https://www.codefactor.io) — Review kode otomatis untuk Git. Versi gratis mencakup pengguna tanpa batas, repo publik, dan satu repo privat.
* [coderabbit.ai](https://coderabbit.ai) — Alat review kode berbasis AI yang terintegrasi dengan GitHub/GitLab. Paket gratis mencakup 200 file/jam, 3 review per jam, dan 50 percakapan/jam. Gratis selamanya untuk proyek open source.
* [codescene.io](https://codescene.io/) - CodeScene memprioritaskan technical debt berdasarkan cara developer bekerja dengan kode dan memvisualisasikan faktor organisasi seperti team coupling dan system mastery. Gratis untuk Open Source.
* [CodSpeed](https://codspeed.io) - Otomatiskan pelacakan performa di pipeline CI Anda. Deteksi regresi performa sebelum deployment, berkat metrik yang presisi dan konsisten. Gratis selamanya untuk proyek Open Source.
* [coveralls.io](https://coveralls.io/) — Menampilkan laporan cakupan pengujian, gratis untuk Open Source
* [dareboost](https://dareboost.com) - 5 laporan analisis gratis tiap bulan untuk performa web, aksesibilitas, dan keamanan
* [deepcode.ai](https://www.deepcode.ai) — DeepCode menemukan bug, kerentanan keamanan, masalah performa dan API berbasis AI. Kecepatan analisis DeepCode memungkinkan analisis kode Anda secara real-time dan hasil saat Anda menekan tombol save di IDE. Bahasa yang didukung: Java, C/C++, JavaScript, Python, dan TypeScript. Integrasi dengan GitHub, BitBucket, dan GitLab. Gratis untuk repo open source dan privat hingga 30 developer.
* [deepscan.io](https://deepscan.io) — Analisis statis lanjutan untuk menemukan error runtime otomatis di kode JavaScript, gratis untuk Open Source
* [DeepSource](https://deepsource.io/) - DeepSource menganalisis perubahan kode secara terus-menerus, menemukan dan memperbaiki masalah yang dikategorikan di bawah keamanan, performa, anti-patterns, bug-risks, dokumentasi, dan gaya. Integrasi native dengan GitHub, GitLab, dan Bitbucket.
* [DiffText](https://difftext.com) - Temukan perbedaan antara dua blok kode secara instan. Sepenuhnya gratis digunakan.
* [eversql.com](https://www.eversql.com/) — EverSQL - Platform #1 untuk optimasi database. Dapatkan insight kritis ke database dan query SQL Anda secara otomatis.
* [gerrithub.io](https://review.gerrithub.io/) — Review kode Gerrit untuk repository GitHub secara gratis
* [gocover.io](https://gocover.io/) — Cakupan kode untuk setiap package [Go](https://golang.org/)
* [goreportcard.com](https://goreportcard.com/) — Kualitas kode untuk proyek Go, gratis untuk Open Source
* [gtmetrix.com](https://gtmetrix.com/) — Laporan dan rekomendasi lengkap untuk mengoptimalkan website
* [holistic.dev](https://holistic.dev/) - Analyzer kode statis #1 untuk optimasi PostgreSQL. Deteksi otomatis masalah performa, keamanan, dan arsitektur database
* [houndci.com](https://houndci.com/) — Memberi komentar pada commit GitHub tentang kualitas kode, gratis untuk Open Source
* [Moderne.io](https://app.moderne.io) — Refactoring kode sumber otomatis. Moderne menawarkan migrasi framework, analisis kode dengan remediasi, dan transformasi kode dalam skala besar, sehingga developer bisa fokus membangun hal baru, bukan memelihara yang lama. Gratis untuk Open Source.
* [reviewable.io](https://reviewable.io/) — Review kode untuk repository GitHub, gratis untuk repo publik atau personal.
* [parsers.dev](https://parsers.dev/) - Layanan parser abstract syntax tree dan compiler intermediate representation sebagai layanan
* [scan.coverity.com](https://scan.coverity.com/) — Analisis kode statis untuk Java, C/C++, C# dan JavaScript, gratis untuk Open Source
* [scrutinizer-ci.com](https://scrutinizer-ci.com/) — Platform inspeksi berkelanjutan, gratis untuk Open Source
* [semanticdiff.com](https://app.semanticdiff.com/) — Diff berbasis bahasa pemrograman untuk pull request dan commit GitHub, gratis untuk repository publik
* [shields.io](https://shields.io) — Badge metadata kualitas untuk proyek open source
* [sonarcloud.io](https://sonarcloud.io) — Analisis kode sumber otomatis untuk Java, JavaScript, C/C++, C#, VB.NET, PHP, Objective-C, Swift, Python, Groovy dan banyak bahasa lain, gratis untuk Open Source
* [SourceLevel](https://sourcelevel.io/) — Review kode otomatis dan analitik tim. Gratis untuk Open Source dan organisasi hingga 5 kolaborator.
* [webceo.com](https://www.webceo.com/) — Alat SEO namun juga dengan verifikasi kode dan berbagai tipe perangkat
* [zoompf.com](https://zoompf.com/) — Perbaiki performa situs web Anda, analisis detail

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Code Search and Browsing

* [libraries.io](https://libraries.io/) — Pencarian dan notifikasi update dependensi untuk 32 manajer paket berbeda, gratis untuk open source
* [Namae](https://namae.dev/) - Cari ketersediaan nama proyek Anda di berbagai situs seperti GitHub, Gitlab, Heroku, Netlify, dan banyak lagi.
* [searchcode.com](https://searchcode.com/) — Pencarian kode berbasis teks yang komprehensif, gratis untuk Open Source
* [tickgit.com](https://www.tickgit.com/) — Menampilkan komentar `TODO` (dan penanda lain) untuk mengidentifikasi area kode yang perlu diperbaiki.
* [CodeKeep](https://codekeep.io) - Google Keep untuk Code Snippet. Organisasi, temukan, dan bagikan potongan kode, dilengkapi alat screenshot kode yang canggih dengan template preset dan fitur linking.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## CI and CD

* [AccessLint](https://github.com/marketplace/accesslint) — AccessLint menghadirkan pengujian aksesibilitas web otomatis ke workflow pengembangan Anda. Gratis untuk open source dan pendidikan.
* [appcircle.io](https://appcircle.io) — Platform DevOps mobile kelas enterprise yang mengotomatiskan build, test, dan publikasi aplikasi mobile untuk siklus rilis yang lebih cepat dan efisien. Gratis untuk waktu build maksimal 30 menit per build, 20 build bulanan dan 1 build bersamaan.
* [appveyor.com](https://www.appveyor.com/) — Layanan CD untuk Windows, gratis untuk Open Source
* [LocalOps](https://localops.co/) - Deploy aplikasi Anda di AWS/GCP/Azure dalam waktu kurang dari 30 menit. Siapkan lingkungan aplikasi standar di cloud mana pun, dilengkapi otomatisasi continuous deployment dan observability canggih. Paket gratis memungkinkan 1 pengguna dan 1 lingkungan aplikasi.
* [Argonaut](https://argonaut.dev/) - Deploy aplikasi dan infrastruktur di cloud Anda dalam hitungan menit. Mendukung deployment aplikasi custom dan pihak ketiga di lingkungan Kubernetes dan Lambda. Paket gratis memungkinkan aplikasi dan deployment tanpa batas untuk 5 domain dan 2 pengguna.
* [bitrise.io](https://www.bitrise.io/) — CI/CD untuk aplikasi mobile, native atau hybrid. Dengan 200 build gratis/bulan, waktu build 10 menit, dan dua anggota tim. Proyek OSS mendapatkan waktu build 45 menit, +1 concurrency, dan ukuran tim tak terbatas.
* [buddy.works](https://buddy.works/) — CI/CD dengan lima proyek gratis dan satu eksekusi bersamaan (120 eksekusi/bulan)
* [Buildkite](https://buildkite.com) Pipeline CI gratis untuk 3 pengguna dan 5k menit job/bulan. Test Analytics tier developer gratis mencakup 100k eksekusi tes/bulan, dengan lebih banyak gratis untuk proyek open-source.
* [bytebase.com](https://www.bytebase.com/) — Database CI/CD dan DevOps. Gratis untuk kurang dari 20 pengguna dan sepuluh instance database
* [CircleCI](https://circleci.com/) — Paket gratis komprehensif dengan semua fitur pada layanan CI/CD hosted untuk repository GitHub, GitLab, dan BitBucket. Banyak kelas resource, Docker, Windows, Mac OS, ARM executor, local runner, test splitting, Docker Layer Caching, dan fitur CI/CD lanjutan lainnya. Gratis untuk hingga 6000 menit eksekusi/bulan, kolaborator tanpa batas, 30 job paralel pada proyek privat, dan hingga 80.000 build menit gratis untuk proyek Open Source.
* [cirrus-ci.org](https://cirrus-ci.org) - Gratis untuk repository publik GitHub
* [cirun.io](https://cirun.io) - Gratis untuk repository publik GitHub
* [codefresh.io](https://codefresh.io) — Paket Free-for-Life: 1 build, satu lingkungan, shared server, repo publik tanpa batas
* [codemagic.io](https://codemagic.io/) - Gratis 500 build menit/bulan
* [codeship.com](https://codeship.com/) — 100 build privat/bulan, lima proyek privat, tak terbatas untuk Open Source
* [deploybot.com](https://www.deploybot.com/) — 1 repository dengan sepuluh deployment, gratis untuk Open Source
* [deployhq.com](https://www.deployhq.com/) — 1 proyek dengan sepuluh deployment harian (30 menit build/bulan)
* [drone](https://cloud.drone.io/) - Drone Cloud memungkinkan developer menjalankan pipeline Continuous Delivery di berbagai arsitektur - termasuk x86 dan Arm (32-bit dan 64-bit) - semuanya di satu tempat
* [LayerCI](https://layerci.com) — CI untuk proyek full stack. Satu lingkungan preview full stack dengan 5GB memori & 3 CPU.
* [semaphoreci.com](https://semaphoreci.com/) — Gratis untuk Open Source, 100 build privat per bulan
* [Squash Labs](https://www.squash.io/) — membuat VM untuk setiap branch dan membuat aplikasi Anda dapat diakses dari URL unik, repo publik & privat tanpa batas, hingga 2 GB ukuran VM.
* [styleci.io](https://styleci.io/) — Hanya untuk repository GitHub publik
* [Mergify](https://mergify.io) — otomatisasi workflow dan merge queue untuk GitHub — Gratis untuk repository GitHub publik
* [Make](https://www.make.com/en) — Alat otomatisasi workflow yang memungkinkan Anda menghubungkan aplikasi dan mengotomatisasi workflow melalui UI. Mendukung banyak aplikasi dan API populer. Gratis untuk repository GitHub publik, dan paket gratis dengan 100 Mb, 1000 Operasi, dan interval minimum 15 menit.
* [Spacelift](https://spacelift.io/) - Platform manajemen untuk Infrastructure as Code. Fitur paket gratis: kolaborasi IaC, registry modul Terraform, integrasi ChatOps, compliance resource berkelanjutan dengan Open Policy Agent, SSO dengan SAML 2.0, dan akses ke public worker pool: hingga 200 menit/bulan
* [microtica.com](https://microtica.com/) - Lingkungan startup dengan komponen infrastruktur siap pakai, deploy aplikasi di AWS secara gratis, dan dukung workload produksi Anda. Paket gratis mencakup 1 Environment (di akun AWS Anda), 2 Kubernetes Services, 100 build menit per bulan, dan 20 deployment bulanan.
* [Nx Cloud](https://nx.dev/ci) - Nx Cloud mempercepat monorepo Anda di CI dengan fitur seperti remote caching, distribusi tugas ke beberapa mesin, dan bahkan pemisahan otomatis pada run uji e2e Anda. Tersedia paket gratis untuk hingga 30 kontributor dengan 150.000 kredit gratis.
* [blacksmith](https://www.blacksmith.sh/) - Runner performa terkelola untuk GitHub Actions yang menyediakan 3.000 menit gratis per bulan, tanpa perlu kartu kredit.
* [Terramate](https://terramate.io/) - Terramate adalah platform orkestrasi dan manajemen untuk alat Infrastructure as Code (IaC) seperti Terraform, OpenTofu, dan Terragrunt. Gratis hingga 2 pengguna termasuk semua fitur.
* [Terrateam](https://terrateam.io) - Otomasi Terraform berbasis GitOps dengan workflow berbasis pull request, isolasi proyek melalui self-hosted runner, dan run berlapis untuk operasi terurut. Gratis untuk hingga 3 pengguna.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Pengujian

* [Applitools.com](https://applitools.com/) — Validasi visual cerdas untuk aplikasi web, mobile native, dan desktop. Terintegrasi dengan hampir semua solusi otomatisasi (seperti Selenium dan Karma) dan remote runner (Sauce Labs, Browser Stack). Gratis untuk open source. Tersedia tier gratis untuk satu pengguna dengan checkpoint terbatas per minggu.
* [Appetize](https://appetize.io) — Uji aplikasi Android & iOS Anda di emulator ponsel/tablet Android berbasis cloud dan simulator iPhone/iPad langsung di browser Anda. Tier gratis meliputi dua sesi bersamaan dengan 30 menit pemakaian per bulan. Tidak ada batas ukuran aplikasi.
* [Apptim](https://apptim.com) — Alat pengujian mobile yang memungkinkan orang tanpa keahlian rekayasa performa untuk mengevaluasi performa dan pengalaman pengguna (UX) aplikasi. Versi desktop menggunakan perangkat sendiri 100% GRATIS, dengan tes tak terbatas di iOS dan Android.
* [Argos](https://argos-ci.com) - Pengujian visual Open Source untuk pengembang. Proyek tak terbatas, dengan 5.000 screenshot per bulan. Gratis untuk proyek open-source.
* [Bencher](https://bencher.dev/) - Suite alat benchmarking berkelanjutan untuk menangkap regresi performa CI. Gratis untuk semua proyek publik.
* [browserstack.com](https://www.browserstack.com/) — Pengujian browser manual dan otomatis, [gratis untuk Open Source](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - Alat otomasi pengujian ringan untuk aplikasi web. Mudah dipelajari dan tidak memerlukan coding. Anda dapat menjalankan tes tak terbatas di komputer sendiri secara gratis. Anda juga mendapatkan monitoring cloud dan integrasi CI/CD dengan biaya bulanan tambahan.
* [Checkly](https://checklyhq.com) - Pemantauan sintetik berbasis kode untuk DevOps modern. Pantau API dan aplikasi Anda dengan harga lebih terjangkau dari penyedia lama. Didukung workflow Monitoring as Code dan Playwright. Tier gratis yang dermawan untuk developer.
* [checkbot.io](https://www.checkbot.io/) — Ekstensi browser yang menguji apakah situs web Anda mengikuti lebih dari 50 praktik terbaik SEO, kecepatan, dan keamanan. Tier gratis untuk situs kecil.
* [CORS-Tester](https://cors-error.dev/cors-tester/) - Alat gratis untuk pengembang dan penguji API untuk memeriksa apakah API sudah CORS-enabled pada domain tertentu dan mengidentifikasi celah. Dapatkan insight yang dapat ditindaklanjuti.
* [cypress.io](https://www.cypress.io/) - Pengujian cepat, mudah, dan andal untuk apa pun yang berjalan di browser. Cypress Test Runner selalu gratis dan open-source tanpa batasan. Cypress Dashboard gratis untuk proyek open-source hingga 5 pengguna.
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - Buat Tes Cypress bertenaga AI/POM model langsung di browser Anda. Open-source, kecuali bagian AI. Gratis untuk lima pembuatan tes bulanan dengan skrip self-healing, Email, dan pengujian visual.
* [everystep-automation.com](https://www.everystep-automation.com/) — Merekam dan memutar ulang semua langkah di browser dan membuat skrip, gratis dengan fitur terbatas.
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — Alat Chaos Engineering dari Gremlin memungkinkan Anda menyuntikkan kegagalan dengan aman dan terjamin ke dalam sistem untuk menemukan kelemahan sebelum menyebabkan masalah ke pelanggan. Gremlin Free menyediakan akses ke Shutdown dan CPU attack hingga 5 host atau container.
* [gridlastic.com](https://www.gridlastic.com/) — Pengujian Selenium Grid dengan paket gratis hingga 4 node selenium simultan/10 grid start/4.000 menit tes/bulan
* [katalon.com](https://katalon.com) - Menyediakan platform pengujian yang membantu tim dari semua ukuran pada berbagai tingkat kematangan pengujian, termasuk Katalon Studio, TestOps (+ Visual Testing gratis), TestCloud, dan Katalon Recorder.
* [Keploy](https://keploy.io/) - Keploy adalah toolkit pengujian fungsional untuk pengembang. Merekam panggilan API menghasilkan tes E2E untuk API (KTests) dan mock atau stub (KMocks). Gratis untuk proyek Open Source.
* [knapsackpro.com](https://knapsackpro.com) - Percepat tes Anda dengan paralelisasi suite uji optimal di penyedia CI mana pun. Membagi tes Ruby, JavaScript pada node CI paralel untuk menghemat waktu. Paket gratis untuk file tes hingga 10 menit dan paket gratis tak terbatas untuk proyek Open Source.
* [lambdatest.com](https://www.lambdatest.com/) — Pengujian browser manual, visual, screenshot, dan otomatis di selenium dan cypress, [gratis untuk Open Source](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - Otomatis membuat tes API dan beban dengan menganalisis lalu lintas jaringan. Simulasikan hingga 50 pengguna bersamaan selama 60 menit gratis per bulan.
* [lost-pixel.com](https://lost-pixel.com) - Pengujian regresi visual holistik untuk Storybook, Ladle, Histoire, dan Web Apps Anda. Anggota tim tak terbatas, benar-benar gratis untuk open-source, 7.000 snapshot/bulan.
* [octomind.dev](https://www.octomind.dev/) - Tes UI Playwright yang dibuat, dijalankan, dan dipelihara secara otomatis dengan AI-assisted test case generation.
* [percy.io](https://percy.io) - Tambahkan pengujian visual ke web app, situs statis, style guide, atau pustaka komponen apa pun. Anggota tim tak terbatas, aplikasi demo, dan proyek tak terbatas, 5.000 snapshot/bulan.
* [preflight.com](https://preflight.com) - Pengujian web otomatis tanpa kode. Rekam tes di browser Anda yang tahan terhadap perubahan UI dan jalankan di mesin Windows. Dapatkah Anda integrasi dengan CI/CD? Paket gratis mencakup 50 run tes bulanan dengan video, sesi HTML, dan lainnya.
* [qase.io](https://qase.io) - Sistem manajemen tes untuk tim Dev dan QA. Kelola test case, susun test run, lakukan tes, lacak cacat, dan ukur dampak. Tier gratis mencakup semua fitur inti, dengan 500MB untuk lampiran dan hingga 3 pengguna.
* [Repeato](https://repeato.app/) Alat otomasi pengujian aplikasi mobile tanpa kode berbasis computer vision dan AI. Berfungsi untuk aplikasi native, flutter, react-native, web, ionic, dan banyak framework aplikasi lainnya. Paket gratis terbatas pada 10 tes untuk iOS dan 10 untuk Android, tetapi mencakup sebagian besar fitur paket berbayar, termasuk run tes tak terbatas.
* [Requestly](https://requestly.com/) Ekstensi Chrome open-source untuk mencegat, mengalihkan, dan mock HTTP Request. Fitur [Debugger](https://requestly.com/products/web-debugger/), [Mock Server](https://requestly.com/products/mock-server/), [API Client](https://requestly.com/products/api-client/) dan [Session Recording](https://requestly.com/products/session-book/). Alihkan URL, modifikasi HTTP Header, mock API, sisipkan JS custom, modifikasi permintaan GraphQL, buat endpoint API mock, rekam sesi dengan log Jaringan & Konsol. Buat hingga 10 aturan di Tier Gratis. Gratis untuk open-source.
* [seotest.me](https://seotest.me/) — Penguji SEO on-page website gratis. 10 crawl website gratis per hari. Sumber belajar SEO dan rekomendasi cara meningkatkan hasil SEO on-page untuk website apapun tanpa melihat teknologinya.
* [snippets.uilicious.com](https://snippets.uilicious.com) - Mirip CodePen tapi untuk pengujian lintas browser. UI-licious memungkinkan Anda menulis tes seperti user story dan menawarkan platform gratis - UI-licious Snippets - yang memungkinkan Anda menjalankan tes tak terbatas di Chrome tanpa perlu daftar hingga 3 menit per run. Menemukan bug? Anda bisa menyalin URL unik ke tes Anda untuk menunjukkan ke developer cara reproduksi bug.
* [TestCollab](https://testcollab.com) - Perangkat lunak manajemen tes yang ramah pengguna, paket gratisnya meliputi integrasi Jira, proyek tak terbatas, impor test case via CSV/XLSx, pelacakan waktu, dan penyimpanan file 1 GB.
* [testingbot.com](https://testingbot.com/) — Pengujian Browser dan Perangkat Selenium, [gratis untuk Open Source](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - Dashboard untuk mempublikasikan hasil tes otomatis dan Framework untuk mengimplementasikan tes manual sebagai kode menggunakan GitHub. Layanan ini [gratis untuk Open Source](https://github.com/marketplace/testspace-com) dan akun untuk 450 hasil bulanan.
* [tesults.com](https://www.tesults.com) — Pelaporan hasil tes dan manajemen test case. Terintegrasi dengan framework tes populer. Pengembang perangkat lunak open source, individu, pendidik, dan tim kecil yang baru memulai dapat meminta penawaran gratis dan diskon di luar proyek gratis dasar.
* [UseWebhook.com](https://usewebhook.com) - Tangkap dan inspeksi webhook dari browser Anda. Teruskan ke localhost, atau putar ulang dari riwayat. Gratis digunakan.
* [Vaadin](https://vaadin.com) — Bangun UI skala besar di Java atau TypeScript, dan gunakan perangkat, komponen, serta sistem desain terintegrasi untuk iterasi lebih cepat, desain lebih baik, dan proses pengembangan yang sederhana. Proyek tak terbatas dengan lima tahun perawatan gratis.
* [websitepulse.com](https://www.websitepulse.com/tools/) — Berbagai alat jaringan dan server gratis.
* [webhook-test.com](https://webhook-test.com) - Debug dan inspeksi webhook dan permintaan HTTP dengan URL unik selama integrasi. Sepenuhnya gratis, Anda dapat membuat URL tak terbatas dan menerima rekomendasi.
* [webhook.site](https://webhook.site) - Verifikasi webhook, permintaan HTTP keluar, atau email dengan URL khusus. URL dan alamat email sementara selalu gratis.
* [webhookbeam.com](https://webhookbeam.com) - Siapkan webhook dan pantau melalui push notification dan email.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Keamanan dan PKI

* [aikido.dev](https://www.aikido.dev) — Platform appsec all-in-one mencakup SCA, SAST, CSPM, DAST, Secrets, IaC, Malware, pemindaian Container, EOL, dan lainnya. Paket gratis mencakup dua pengguna, pemindaian 10 repositori, 1 cloud, 2 container & 1 domain.
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — Mengungkap sistem yang terkompromi di jaringan Anda
* [Altcha.org](https://altcha.org/anti-spam) - Filter Spam untuk situs dan API dengan NLP dan machine learning. Paket gratis mencakup 200 permintaan per hari per domain.
* [atomist.com](https://atomist.com/) — Cara lebih cepat dan nyaman untuk mengotomasi berbagai tugas pengembangan. Saat ini dalam versi beta.
* [cloudsploit.com](https://cloudsploit.com/) — Audit dan monitoring keamanan serta kepatuhan Amazon Web Services (AWS)
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — Indikator kompromi (IOC) tingkat tinggi yang menargetkan infrastruktur cloud publik. Sebagian tersedia di github (https://github.com/unknownhad/AWSAttacks). Daftar penuh tersedia via API
* [CodeNotary.io](https://www.codenotary.io/) — Platform Open Source dengan bukti tak terhapuskan untuk menotarisasi kode, file, direktori, atau container
* [crypteron.com](https://www.crypteron.com/) — Platform keamanan berbasis cloud yang ramah pengembang, mencegah kebocoran data di aplikasi .NET dan Java
* [CyberChef](https://gchq.github.io/CyberChef/) — Web app sederhana dan intuitif untuk menganalisis dan meng-encode/mendecode data tanpa alat atau bahasa pemrograman rumit. Seperti pisau Swiss untuk kriptografi & enkripsi. Semua fitur gratis tanpa batas. Open source jika ingin self-host.
* [DAS](https://signup.styra.com/) — Styra DAS Free, manajemen kebijakan siklus penuh untuk membuat, deploy, dan mengelola otorisasi Open Policy Agent (OPA)
* [Datree](https://www.datree.io/) — CLI Open Source untuk mencegah misconfig Kubernetes dengan memastikan manifest dan Helm chart mengikuti best practice dan kebijakan organisasi Anda
* [Dependabot](https://dependabot.com/) Update otomatis dependensi untuk Ruby, JavaScript, Python, PHP, Elixir, Rust, Java (Maven dan Gradle), .NET, Go, Elm, Docker, Terraform, Git Submodules, dan GitHub Actions.
* [DJ Checkup](https://djcheckup.com) — Scan situs Django Anda untuk celah keamanan dengan alat cek otomatis gratis ini. Fork dari situs Pony Checkup.
* [Doppler](https://doppler.com/) — Universal Secrets Manager untuk secret aplikasi dan config, dengan dukungan sinkronisasi ke berbagai cloud provider. Gratis untuk lima pengguna dengan kontrol akses dasar.
* [Dotenv](https://dotenv.org/) — Sinkronisasi file .env Anda, cepat & aman. Berhenti berbagi file .env melalui saluran tidak aman seperti Slack dan email, dan tidak akan kehilangan file .env penting lagi. Gratis untuk hingga 3 rekan tim.
* [GitGuardian](https://www.gitguardian.com) — Jauhkan secret dari kode sumber Anda dengan deteksi otomatis dan remediasi secret. Scan repo git Anda untuk 350+ jenis secret dan file sensitif – Gratis untuk individu dan tim sampai 25 developer.
* [Have I been pwned?](https://haveibeenpwned.com) — REST API untuk mengambil informasi tentang kebocoran data.
* [hostedscan.com](https://hostedscan.com) — Pemindai kerentanan online untuk aplikasi web, server, dan jaringan. Sepuluh scan gratis per bulan.
* [Infisical](https://infisical.com/) — Platform open source untuk mengelola secret developer di seluruh tim dan infrastruktur: mulai dari pengembangan lokal hingga staging/production & layanan pihak ketiga. Gratis untuk hingga 5 developer.
* [Internet.nl](https://internet.nl) — Tes untuk Standar Internet modern seperti IPv6, DNSSEC, HTTPS, DMARC, STARTTLS dan DANE
* [keychest.net](https://keychest.net) - Manajemen kadaluarsa SSL dan pembelian sertifikat dengan database CT terintegrasi
* [letsencrypt.org](https://letsencrypt.org/) — Otoritas Sertifikat SSL gratis dengan sertifikat terpercaya di semua browser utama
* [meterian.io](https://www.meterian.io/) - Monitor proyek Java, Javascript, .NET, Scala, Ruby, dan NodeJS untuk kerentanan keamanan di dependensi. Gratis untuk satu proyek privat, proyek tak terbatas untuk open source.
* [Mozilla Observatory](https://observatory.mozilla.org/) — Temukan dan perbaiki celah keamanan di situs Anda.
* [opswat.com](https://www.opswat.com/) — Pemantauan keamanan komputer, perangkat, aplikasi, konfigurasi, Gratis 25 pengguna dan 30 hari histori.
* [openapi.security](https://openapi.security/) - Alat gratis untuk cek cepat keamanan API berbasis OpenAPI/Swagger. Tidak perlu daftar.
* [pixee.ai](https://pixee.ai) - Product Security Engineer otomatis sebagai bot GitHub gratis yang mengirim PR ke basis kode Java Anda untuk secara otomatis menyelesaikan kerentanan. Bahasa lain segera hadir!
* [pyup.io](https://pyup.io) — Pantau dependensi Python untuk kerentanan keamanan dan update otomatis. Gratis untuk satu proyek privat, proyek tak terbatas untuk open source.
* [qualys.com](https://www.qualys.com/community-edition) — Temukan kerentanan aplikasi web, audit untuk risiko OWASP
* [report-uri.io](https://report-uri.io/) — Pelaporan pelanggaran CSP dan HPKP
* [ringcaptcha.com](https://ringcaptcha.com/) — Alat untuk menggunakan nomor telepon sebagai id, tersedia gratis
* [seclookup.com](https://www.seclookup.com/) - API Seclookup dapat memperkaya indikator ancaman domain di SIEM, memberi info lengkap tentang nama domain, dan meningkatkan deteksi & respons ancaman. Dapatkan 50K lookup gratis [di sini](https://account.seclookup.com/).
* [snyk.io](https://snyk.io) — Bisa menemukan dan memperbaiki kerentanan keamanan yang diketahui pada dependensi open-source Anda. Tes dan remediasi tak terbatas untuk proyek open-source. Terbatas 200 tes/bulan untuk proyek privat Anda.
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — Analisis intensif konfigurasi server web SSL apa pun
* [SOOS](https://soos.io) - SCA scan gratis tanpa batas untuk proyek open-source. Deteksi dan perbaiki ancaman keamanan sebelum rilis. Lindungi proyek Anda dengan solusi sederhana dan efektif.
* [StackHawk](https://www.stackhawk.com/) Otomatiskan pemindaian aplikasi sepanjang pipeline untuk menemukan dan memperbaiki bug keamanan sebelum produksi. Scan dan environment tak terbatas untuk satu aplikasi.
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - Pemeriksaan keamanan website dan pemindai malware gratis
* [Protectumus](https://protectumus.com) - Pemeriksaan keamanan website gratis, antivirus situs, dan firewall server (WAF) untuk PHP. Notifikasi email untuk pengguna terdaftar di tier gratis.
* [TestTLS.com](https://testtls.com) - Uji layanan SSL/TLS untuk konfigurasi server yang aman, sertifikat, rantai, dan lain-lain. Tidak hanya HTTPS.
* [threatconnect.com](https://threatconnect.com) — Intelijen ancaman: Dirancang untuk peneliti individu, analis, dan organisasi yang mulai belajar tentang intelijen ancaman siber. Gratis hingga 3 Pengguna
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — Pemindaian kerentanan otomatis. Paket gratis memungkinkan scan XSS mingguan
* [Ubiq Security](https://ubiqsecurity.com/) — Enkripsi dan dekripsi data dengan tiga baris kode dan manajemen kunci otomatis. Gratis untuk satu aplikasi dan hingga 1.000.000 enkripsi per bulan.
* [Virgil Security](https://virgilsecurity.com/) — Alat dan layanan untuk menerapkan end-to-end encryption, perlindungan database, keamanan IoT, dan lainnya pada solusi digital Anda. Gratis untuk aplikasi dengan hingga 250 pengguna.
* [Vulert](https://vulert.com) - Vulert secara kontinu memantau dependensi open-source Anda untuk kerentanan baru, merekomendasikan perbaikan, tanpa perlu instalasi atau akses ke kode Anda. Gratis untuk proyek open-source.
* [Escape GraphQL Quickscan](https://escape.tech/) - Scan keamanan endpoint GraphQL hanya dengan satu klik. Gratis, tidak perlu login.
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - Cari di 20 juta secret yang terungkap di repositori, gist, issue, dan komentar GitHub publik secara gratis
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - Toolkit SSL All-in-One yang menawarkan berbagai fitur seperti Private Key & CSR Generator, SSL Certificate Decoder, Certificate Matcher, dan Order SSL Certificate. Pengguna dapat menghasilkan Sertifikat SSL Gratis dari Let's Encrypt, Google Trust, dan BuyPass menggunakan CNAME Record, bukan TXT Record.
**[⬆️ Kembali ke Atas](#table-of-contents)**

## Otentikasi, Otorisasi, dan Manajemen Pengguna

  * [Aserto](https://www.aserto.com) - Otorisasi tingkat lanjut sebagai layanan untuk aplikasi dan API. Gratis hingga 1000 MAUs dan 100 instance authorizer.
  * [asgardeo.io](https://wso2.com/asgardeo) - Integrasi mulus SSO, MFA, autentikasi tanpa kata sandi, dan lainnya. Termasuk SDK untuk aplikasi frontend dan backend. Gratis hingga 1000 MAUs dan lima penyedia identitas.
  * [Auth0](https://auth0.com/) — SSO terhosting. Paket gratis mencakup 25.000 MAUs, Koneksi Sosial tanpa batas, domain khusus, dan lainnya.
  * [Authgear](https://www.authgear.com) - Hadirkan autentikasi tanpa kata sandi, OTP, 2FA, SSO ke aplikasi Anda dalam hitungan menit. Semua Front-end sudah termasuk. Gratis hingga 5000 MAUs.
  * [Authress](https://authress.io/) — Login autentikasi dan kontrol akses, penyedia identitas tak terbatas untuk proyek apa pun. Facebook, Google, Twitter dan lainnya. 1000 panggilan API pertama gratis.
  * [Authy](https://authy.com) - Otentikasi dua faktor (2FA) di banyak perangkat, dengan backup. Pengganti instan untuk Google Authenticator. Gratis hingga 100 autentikasi yang berhasil.
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - Sistem manajemen otorisasi lengkap untuk membuat, menguji, dan menerapkan kebijakan akses. Otorisasi dan kontrol akses tingkat lanjut, gratis hingga 100 prinsipal aktif bulanan.
  * [Clerk](https://clerk.com) — Manajemen pengguna, autentikasi, 2FA/MFA, komponen UI siap pakai untuk masuk, daftar, profil pengguna, dan lainnya. Gratis hingga 10.000 pengguna aktif bulanan.
  * [Cloud-IAM](https://www.cloud-iam.com/) — Keycloak Identity and Access Management as a Service. Gratis hingga 100 pengguna dan satu realm.
  * [Corbado](https://www.corbado.com/) — Tambahkan autentikasi berbasis passkey ke aplikasi baru atau yang sudah ada. Gratis untuk MAUs tanpa batas.
  * [Descope](https://www.descope.com/) — Alur AuthN yang sangat dapat dikustomisasi, memiliki pendekatan tanpa kode dan API/SDK, Gratis 7.500 pengguna aktif/bulan, 50 tenant (hingga 5 tenant SAML/SSO).
  * [duo.com](https://duo.com/) — Otentikasi dua faktor (2FA) untuk situs web atau aplikasi. Gratis untuk sepuluh pengguna, semua metode autentikasi, integrasi tanpa batas, token perangkat keras.
  * [Kinde](https://kinde.com/) - Autentikasi sederhana dan tangguh yang dapat diintegrasikan ke produk Anda dalam hitungan menit. Semua yang Anda butuhkan untuk memulai dengan 7.500 MAU gratis.
  * [logintc.com](https://www.logintc.com/) — Otentikasi dua faktor (2FA) melalui push notification, gratis untuk sepuluh pengguna, VPN, Situs Web, dan SSH
  * [MojoAuth](https://mojoauth.com/) - MojoAuth memudahkan implementasi autentikasi tanpa kata sandi di aplikasi web, mobile, atau aplikasi apa pun dalam hitungan menit.
  * [Okta](https://developer.okta.com/signup/) — Manajemen pengguna, autentikasi, dan otorisasi. Gratis hingga 100 pengguna aktif bulanan.
  * [onelogin.com](https://www.onelogin.com/) — Identity as a Service (IDaaS), Single Sign-On Identity Provider, Cloud SSO IdP, tiga aplikasi perusahaan, dan lima aplikasi pribadi, pengguna tanpa batas
  * [Ory](https://ory.sh/) - AuthN/AuthZ/OAuth2.0/Zero Trust platform keamanan terkelola. Akun pengembang gratis selamanya dengan semua fitur keamanan, anggota tim tanpa batas, 200 pengguna aktif harian, dan 25k/mo pemeriksaan izin.
  * [Permit.io](https://permit.io) - Platform authorization-as-a-service yang memungkinkan RBAC, ABAC, dan ReBAC untuk microservices skala besar dengan pembaruan real-time dan UI kebijakan tanpa kode. Paket gratis untuk 1000 Pengguna Aktif Bulanan.
  * [Phase Two](https://phasetwo.io) - Keycloak Open Source Identity and Access Management. Realm gratis hingga 1000 pengguna, hingga 10 koneksi SSO, menggunakan container Keycloak yang ditingkatkan dari Phase Two yang mencakup ekstensi [Organization](https://phasetwo.io/product/organizations/).
  * [SSOJet](https://ssojet.com/) - Tambahkan Enterprise SSO Tanpa Membangun Ulang Auth Anda. Paket gratis mencakup pengguna aktif bulanan tak terbatas, organisasi tak terbatas, 2 koneksi SSO & 2 koneksi SCIM.
  * [Stytch](https://www.stytch.com/) - Platform all-in-one yang menyediakan API dan SDK untuk autentikasi dan pencegahan penipuan. Paket gratis mencakup 10.000 pengguna aktif bulanan, organisasi tanpa batas, 5 koneksi SSO atau SCIM, dan 1.000 token M2M.
  * [Stack Auth](https://stack-auth.com) — Otentikasi open-source yang ramah pengembang. Solusi paling mudah untuk mulai dalam lima menit. Dapat di-host sendiri secara gratis, atau menawarkan versi SaaS terkelola dengan 10.000 Pengguna Aktif Bulanan gratis.
  * [SuperTokens](https://supertokens.com/) - Otentikasi pengguna open source yang terintegrasi secara native ke aplikasi Anda — memungkinkan Anda memulai dengan cepat sambil tetap mengontrol pengalaman pengguna dan pengembang. Gratis hingga 5000 MAUs.
  * [Warrant](https://warrant.dev/) — Layanan otorisasi dan kontrol akses tingkat enterprise yang dihosting untuk aplikasi Anda. Paket gratis mencakup 1 juta permintaan API bulanan dan 1.000 aturan authz.
  * [ZITADEL Cloud](https://zitadel.com) — Manajemen pengguna dan akses turnkey yang mendukung multi-tenant (B2B). Gratis hingga 25.000 permintaan autentikasi, dengan semua fitur keamanan (tidak ada paywall untuk OTP, Passwordless, Kebijakan, dan sebagainya).
  * [PropelAuth](https://propelauth.com) — Jual ke perusahaan dari semua ukuran secara instan dengan beberapa baris kode, gratis hingga 200 pengguna dan 10.000 Email Transaksional (dengan watermark branding: "Powered by PropelAuth").
  * [Logto](https://logto.io/) - Mengembangkan, mengamankan, dan mengelola identitas pengguna produk Anda — untuk autentikasi dan otorisasi. Gratis hingga 5.000 MAUs dengan opsi open-source self-hosted.
  * [WorkOS](https://workos.com/) - Manajemen pengguna dan autentikasi gratis hingga 1 Juta MAUs. Mendukung email + kata sandi, autentikasi sosial, Magic Auth, MFA, dan lainnya.


**[⬆️ Kembali ke Atas](#table-of-contents)**

## Distribusi Aplikasi Mobile dan Umpan Balik

  * [TestApp.io](https://testapp.io) - Platform andalan Anda untuk memastikan aplikasi mobile Anda berjalan sebagaimana mestinya. Paket gratis: satu aplikasi, analitik, versi & instalasi tanpa batas, serta pengumpulan umpan balik.
  * [Loadly](https://loadly.io) - Layanan distribusi aplikasi beta iOS & Android menawarkan layanan sepenuhnya gratis dengan unduhan tanpa batas, unduhan berkecepatan tinggi, dan unggahan tanpa batas.
  * [Diawi](https://www.diawi.com) - Deploy aplikasi iOS & Android langsung ke perangkat. Paket gratis: unggahan aplikasi, tautan berpassword, kadaluarsa 1 hari, sepuluh instalasi.
  * [InstallOnAir](https://www.installonair.com) - Distribusikan aplikasi iOS & Android melalui udara. Paket gratis: unggahan tanpa batas, tautan privat, kadaluarsa 2 hari untuk tamu, 60 hari untuk pengguna terdaftar.
  * [GetUpdraft](https://www.getupdraft.com) - Distribusi aplikasi mobile untuk pengujian. Paket gratis mencakup satu proyek aplikasi, tiga versi aplikasi, 500 MB penyimpanan, dan 100 instalasi aplikasi per bulan.
  * [Appho.st](https://appho.st) - Platform hosting aplikasi mobile. Paket gratis mencakup lima aplikasi, 50 unduhan bulanan, dan ukuran file maksimal 100 MB.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Sistem Manajemen

  * [bitnami.com](https://bitnami.com/) — Deploy aplikasi siap pakai di IaaS. Manajemen 1 instance AWS micro gratis
  * [Esper](https://esper.io) — MDM dan MAM untuk Perangkat Android dengan DevOps. Seratus perangkat gratis dengan satu lisensi pengguna dan 25 MB Penyimpanan Aplikasi.
  * [jamf.com](https://www.jamf.com/) — Manajemen perangkat untuk iPad, iPhone, dan Mac, tiga perangkat gratis
  * [Miradore](https://miradore.com) — Layanan Manajemen Perangkat. Pantau armada perangkat Anda dan amankan perangkat tanpa batas secara gratis. Paket gratis menawarkan fitur dasar.
  * [moss.sh](https://moss.sh) - Membantu developer mendepoy dan mengelola aplikasi web dan server mereka. Gratis hingga 25 deployment git per bulan
  * [runcloud.io](https://runcloud.io/) - Manajemen server dengan fokus utama pada proyek PHP. Gratis untuk hingga 1 server.
  * [ploi.io](https://ploi.io/) - Alat manajemen server untuk dengan mudah mengelola dan mendepoy server & situs Anda. Gratis untuk satu server.
  * [xcloud.host](https://xcloud.host) — Platform manajemen dan deployment server dengan antarmuka yang ramah pengguna. Paket gratis tersedia untuk satu server.
  * [serveravatar.com](https://serveravatar.com) — Mengelola dan memantau server web berbasis PHP dengan konfigurasi otomatis. Gratis untuk satu server.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Pesan & Streaming

  * [Ably](https://www.ably.com/) - Layanan pesan realtime dengan presence, persistence, dan pengiriman terjamin. Paket gratis mencakup 3 juta pesan per bulan, 100 koneksi puncak, dan 100 channel puncak.
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ as a Service. Paket Little Lemur: maksimum 1 juta pesan/bulan, maksimum 20 koneksi bersamaan, maksimum 100 antrean, maksimum 10.000 pesan dalam antrean, beberapa node di AZ berbeda
  * [courier.com](https://www.courier.com/) — Satu API untuk push, in-app, email, chat, SMS, dan saluran pesan lain dengan manajemen template dan fitur lainnya. Paket gratis mencakup 10.000 pesan/bulan.
  * [engagespot.co](https://engagespot.co/) — Infrastruktur notifikasi multikanal untuk developer dengan inbox in-app siap pakai dan editor template tanpa kode. Paket gratis mencakup 10.000 pesan/bulan.
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - Hubungkan perangkat MQTT Anda ke Cloud Native IoT Messaging Broker. Gratis untuk menghubungkan hingga 100 perangkat (tanpa kartu kredit) selamanya.
  * [knock.app](https://knock.app) – Infrastruktur notifikasi untuk developer. Kirim ke berbagai channel seperti in-app, email, SMS, Slack, dan push dengan satu panggilan API. Paket gratis mencakup 10.000 pesan/bulan.
  * [NotificationAPI.com](https://www.notificationapi.com/) — Tambahkan notifikasi pengguna ke perangkat lunak apa pun dalam 5 menit. Paket gratis mencakup 10.000 notifikasi/bulan + 100 SMS dan Panggilan Otomatis.
  * [Novu.co](https://novu.co) — Infrastruktur notifikasi open-source untuk developer. Komponen dan API sederhana untuk mengelola semua saluran komunikasi di satu tempat: Email, SMS, Direct, In-App dan Push. Paket gratis mencakup 30.000 notifikasi/bulan dengan retensi 90 hari.
  * [pusher.com](https://pusher.com/) — Layanan pesan realtime. Gratis hingga 100 koneksi bersamaan dan 200.000 pesan/hari
  * [scaledrone.com](https://www.scaledrone.com/) — Layanan pesan realtime. Gratis hingga 20 koneksi bersamaan dan 100.000 event/hari
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) as a service. Global, AWS, GCP, dan Azure. Gratis selamanya dengan ukuran pesan 4k, 50 koneksi aktif, dan 5GB data per bulan.
  * [pubnub.com](https://www.pubnub.com/) - Swift, Kotlin, dan React messaging dengan 1 juta transaksi setiap bulan. Satu transaksi dapat berisi beberapa pesan.
  * [eyeson API](https://developers.eyeson.team/) - Layanan API komunikasi video berbasis WebRTC (SFU, MCU) untuk membangun platform video. Mendukung data injection real-time, Video Layouts, Rekaman, UI web siap pakai (quickstart) atau paket untuk UI kustom. Ada [paket gratis untuk developer](https://apiservice.eyeson.com/api-pricing) dengan 1000 menit meeting per bulan.
  * [webpushr](https://www.webpushr.com/) - Web Push Notifications - Gratis hingga 10 ribu subscriber, notifikasi push tanpa batas, pesan dalam browser
  * [httpSMS](https://httpsms.com) - Kirim dan terima SMS menggunakan ponsel Android Anda sebagai SMS Gateway. Gratis untuk mengirim dan menerima hingga 200 pesan per bulan.
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - Broker MQTT serverless yang aman dan skalabel dalam hitungan detik. 1 juta menit sesi/bulan gratis selamanya (tanpa kartu kredit).
  * [Pocket Alert](https://pocketalert.app) - Kirim notifikasi push ke perangkat iOS dan Android Anda. Integrasi mudah via API atau Webhook dan kontrol penuh atas peringatan Anda. Paket gratis: 50 pesan per hari ke 1 perangkat dan 1 aplikasi.
  * [SuprSend](https://www.suprsend.com/) - SuprSend adalah infrastruktur notifikasi yang menyederhanakan notifikasi produk Anda dengan pendekatan API-first. Buat dan kirim notifikasi transaksional, crons, dan engagement di berbagai channel dengan satu API notifikasi. Paket gratis: 10.000 notifikasi per bulan, termasuk berbagai node workflow seperti digest, batch, multi-channel, preferensi, tenant, broadcast, dan lainnya.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Manajemen Log

  * [bugfender.com](https://bugfender.com/) — Gratis hingga 100 ribu baris log/hari dengan retensi 24 jam
  * [logentries.com](https://logentries.com/) — Gratis hingga 5 GB/bulan dengan retensi tujuh hari
  * [loggly.com](https://www.loggly.com/) — Gratis untuk satu pengguna, 200MB/hari dengan retensi tujuh hari
  * [logz.io](https://logz.io/) — Gratis hingga 1 GB/hari, satu hari retensi
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Layanan Manajemen Log dari Manage Engine. Paket Gratis menawarkan 50 GB penyimpanan dengan retensi 15 hari dan pencarian 7 hari.
  * [papertrailapp.com](https://papertrailapp.com/) — 48 jam pencarian, tujuh hari arsip, 50 MB/bulan
  * [sematext.com](https://sematext.com/logsene) — Gratis hingga 500 MB/hari, tujuh hari retensi
  * [sumologic.com](https://www.sumologic.com/) — Gratis hingga 500 MB/hari, tujuh hari retensi
  * [logflare.app](https://logflare.app/) — Gratis hingga 12.960.000 entri per aplikasi per bulan, 3 hari retensi
  * [logtail.com](https://logtail.com/) — Manajemen log berbasis ClickHouse yang kompatibel SQL. Gratis hingga 1 GB per bulan, tiga hari retensi.
  * [logzab.com](https://logzab.com/) — Sistem manajemen audit trail. Gratis 1.000 log aktivitas pengguna per bulan, retensi 1 bulan, hingga 5 proyek.
  * [openobserve.ai](https://openobserve.ai/) - 200 GB Ingestion/bulan gratis, 15 Hari Retensi
**[⬆️ Kembali ke Atas](#table-of-contents)**

## Manajemen Translasi

  * [crowdin.com](https://crowdin.com/) — Proyek tanpa batas, string tanpa batas, dan kolaborator tanpa batas untuk Open Source
  * [gitlocalize.com](https://gitlocalize.com) - Gratis dan tanpa batas untuk repositori privat maupun publik
  * [Lecto](https://lecto.ai/) - API Terjemahan Mesin dengan paket Gratis (30 permintaan gratis, 1000 karakter diterjemahkan per permintaan). Terintegrasi dengan plugin Loco Translate untuk Wordpress.
  * [lingohub.com](https://lingohub.com/) — Gratis hingga 3 pengguna, selalu gratis untuk Open Source
  * [localazy.com](https://localazy.com) - Gratis untuk 1000 string bahasa sumber, bahasa tanpa batas, kontributor tanpa batas, penawaran untuk startup dan open source
  * [Localeum](https://localeum.com) - Gratis hingga 1000 string, satu pengguna, bahasa tanpa batas, proyek tanpa batas
  * [localizely.com](https://localizely.com/) — Gratis untuk Open Source
  * [Loco](https://localise.biz/) — Gratis hingga 2000 terjemahan, penerjemah tanpa batas, sepuluh bahasa/proyek, 1000 aset yang dapat diterjemahkan/proyek
  * [oneskyapp.com](https://www.oneskyapp.com/) — Edisi gratis terbatas untuk hingga 5 pengguna, gratis untuk Open Source
  * [POEditor](https://poeditor.com/) — Gratis hingga 1000 string
  * [SimpleLocalize](https://simplelocalize.io/) - Gratis hingga 100 kunci terjemahan, string tanpa batas, bahasa tanpa batas, penawaran untuk startup
  * [Texterify](https://texterify.com/) - Gratis untuk satu pengguna
  * [Tolgee](https://tolgee.io) - Penawaran SaaS gratis dengan terjemahan terbatas, versi self-hosted gratis selamanya
  * [transifex.com](https://www.transifex.com/) — Gratis untuk Open Source
  * [Translation.io](https://translation.io) - Gratis untuk Open Source
  * [Translized](https://translized.com) - Gratis hingga 1000 string, satu pengguna, bahasa tanpa batas, proyek tanpa batas
  * [webtranslateit.com](https://webtranslateit.com/) — Gratis hingga 500 string
  * [weblate.org](https://weblate.org/) — Gratis untuk proyek libre dengan hingga 10.000 sumber string untuk paket gratis dan tanpa batas untuk versi Self-hosted on-premises.
  * [Free PO editor](https://pofile.net/free-po-editor) — Gratis untuk semua orang
  * [Lingo.dev](https://lingo.dev) – CLI open-source bertenaga AI untuk lokalisasi web & mobile. Gunakan LLM sendiri, atau dapatkan 10.000 kata gratis setiap bulan melalui mesin lokalisasi yang dikelola Lingo.dev.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Monitoring

  * [UptimeObserver.com](https://uptimeobserver.com) - Dapatkan 20 monitor uptime dengan interval 5 menit dan halaman status yang dapat disesuaikan—bahkan untuk penggunaan komersial. Nikmati notifikasi waktu nyata tanpa batas melalui email dan Telegram. Tidak perlu kartu kredit untuk memulai.
  * [Pingmeter.com](https://pingmeter.com/) - 5 monitor uptime dengan interval 10 menit. Monitor SSH, HTTP, HTTPS, dan port TCP kustom apa pun.
  * [alerty.ai](https://www.alerty.ai) - APM dan monitoring gratis untuk FE, BE, DB, dan lainnya + agent gratis.
  * [appdynamics.com](https://www.appdynamics.com/) — Gratis untuk metrik 24 jam, agen manajemen kinerja aplikasi terbatas pada satu Java, satu .NET, satu PHP, dan satu Node.js
  * [appneta.com](https://www.appneta.com/) — Gratis dengan retensi data 1 jam
  * [appspector.com](https://appspector.com/) - Kontrol misi untuk debugging iOS/Android/Flutter jarak jauh. Gratis untuk penggunaan trafik kecil (64MB log).
  * [assertible.com](https://assertible.com) — Pengujian dan pemantauan API otomatis. Paket gratis untuk tim dan individu.
  * [bleemeo.com](https://bleemeo.com) - Gratis untuk 3 server, 5 monitor uptime, pengguna tanpa batas, dasbor tanpa batas, aturan alert tanpa batas.
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - Temukan riwayat Core Web Vitals untuk sebuah url atau website.
  * [checklyhq.com](https://checklyhq.com) - Open source monitoring E2E / Sintetis dan monitoring API mendalam untuk developer. Paket gratis dengan satu pengguna dan 10k API & network / 1.5k browser check runs.
  * [cloudsploit.com](https://cloudsploit.com) — Monitoring keamanan dan konfigurasi AWS. Gratis: pemindaian on-demand tanpa batas, pengguna tanpa batas, akun tersimpan tanpa batas. Berlangganan: pemindaian otomatis, akses API, dll.
  * [cronitor.io](https://cronitor.io/) - Insight performa dan monitoring uptime untuk cron job, website, API, dan lainnya. Paket gratis dengan lima monitor.
  * [datadoghq.com](https://www.datadoghq.com/) — Gratis hingga 5 node
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — Monitoring untuk cron job. Satu snitch (monitor) gratis, lebih banyak jika Anda mereferensikan orang lain untuk mendaftar
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60 monitor uptime, interval 5 menit. Email, alert Slack.
  * [economize.cloud](https://economize.cloud) — Economize membantu memahami biaya infrastruktur cloud dengan mengorganisasi resource cloud untuk mengoptimalkan dan melaporkan. Gratis hingga penggunaan $5.000 di Google Cloud Platform tiap bulan.
  * [elastic.co](https://www.elastic.co/solutions/apm) — Insight performa instan untuk developer JS. Gratis dengan retensi data 24 jam
  * [fivenines.io](https://fivenines.io/) — Monitoring server Linux dengan dasbor real-time dan alerting — gratis selamanya untuk hingga 5 server yang dimonitor dengan interval 60 detik. Tidak perlu kartu kredit.
  * [Grafana Cloud](https://grafana.com/products/cloud/) - Grafana Cloud adalah platform observability komposabel yang mengintegrasikan metrik dan log dengan Grafana. Gratis: 3 pengguna, sepuluh dasbor, 100 alert, penyimpanan metrik di Prometheus dan Graphite (10.000 series, retensi 14 hari), penyimpanan log di Loki (50 GB log, retensi 14 hari)
  * [healthchecks.io](https://healthchecks.io) — Monitor cron job dan tugas background Anda. Gratis hingga 20 check.
  * [Hydrozen.io](https://hydrozen.io) — Monitoring uptime & halaman status, Paket Gratis: 10 monitor Uptime, 5 monitor heartbeat, 1 monitor Domain dan 1 Statuspage gratis.
  * [incidenthub.cloud](https://incidenthub.cloud/) — Pengumpul halaman status Cloud dan SaaS - 20 monitor dan 2 saluran notifikasi (Slack dan Discord) gratis selamanya.
  * [inspector.dev](https://www.inspector.dev) - Dasbor monitoring Real-Time lengkap dalam waktu kurang dari satu menit dengan paket gratis selamanya.
  * [instrumentalapp.com](https://instrumentalapp.com) - Monitoring aplikasi dan server yang indah dan mudah digunakan dengan hingga 500 metrik dan 3 jam visibilitas data secara gratis
  * [keychest.net/speedtest](https://keychest.net/speedtest) - Tes kecepatan independen dan tes latensi TLS handshake terhadap Digital Ocean
  * [letsmonitor.org](https://letsmonitor.org) - Monitoring SSL, gratis hingga 5 monitor
  * [linkok.com](https://linkok.com) - Pemeriksa tautan rusak online, gratis untuk website kecil hingga 100 halaman, sepenuhnya gratis untuk proyek open-source.
  * [loader.io](https://loader.io/) — Alat uji beban gratis dengan keterbatasan
  * [MonitorMonk](https://monitormonk.com) - Monitoring uptime minimalis dengan halaman status yang indah. Paket Forever Free menawarkan monitoring HTTPS, Keyword, SSL, dan Response-time untuk 10 website atau endpoint API, dan menyediakan 2 dasbor/halaman status.
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata adalah alat open-source untuk mengumpulkan metrik real-time. Produk ini terus berkembang dan juga tersedia di GitHub!
  * [newrelic.com](https://www.newrelic.com) — Platform observability New Relic dirancang untuk membantu engineer menciptakan perangkat lunak yang lebih sempurna. Dari monolith hingga serverless, Anda dapat menginstrumentasi semua lalu menganalisis, menyelesaikan masalah, dan mengoptimalkan seluruh stack perangkat lunak Anda. Paket gratis menawarkan 100GB/bulan data gratis, satu pengguna full-access gratis, dan pengguna utama gratis tanpa batas.
  * [Middleware.io](https://middleware.io/) - Platform observability Middleware menyediakan visibilitas lengkap ke aplikasi & stack Anda, sehingga Anda dapat memonitor & mendiagnosis masalah dalam skala besar. Mereka memiliki paket gratis selamanya untuk penggunaan komunitas Dev yang memungkinkan monitoring Log hingga 1 juta event log, monitoring Infrastruktur & APM hingga 2 host.
  * [nixstats.com](https://nixstats.com) - Gratis untuk satu server. Notifikasi E-Mail, halaman status publik, interval 60 detik, dan lainnya.
  * [OnlineOrNot.com](https://onlineornot.com/) - OnlineOrNot menyediakan monitoring uptime untuk website dan API, monitoring untuk cron job dan tugas terjadwal. Juga menyediakan halaman status. Lima pemeriksaan pertama dengan interval 3 menit gratis. Paket gratis mengirim alert via Slack, Discord, dan Email.
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — Cek apakah sebuah website diblokir di Tiongkok oleh Great Firewall. Mengidentifikasi polusi DNS dengan membandingkan hasil DNS dan informasi ASN yang dideteksi oleh server di Tiongkok versus server di Amerika Serikat.
  * [opsgenie.com](https://www.opsgenie.com/) — Alerting kuat dan manajemen on-call untuk mengoperasikan layanan always-on. Gratis hingga 5 pengguna.
  * [paessler.com](https://www.paessler.com/) — Solusi monitoring infrastruktur dan jaringan yang kuat, termasuk alerting, kemampuan visualisasi yang kuat, dan pelaporan dasar. Gratis hingga 100 sensor.
  * [pagecrawl.io](https://pagecrawl.io/) -  Monitoring perubahan website, gratis hingga 6 monitor dengan pemeriksaan harian.
  * [syagent.com](https://syagent.com/) — Layanan monitoring server gratis nonkomersial, alert dan metrik.
  * [pagerly.io](https://pagerly.io/) -  Kelola on-call di Slack  (terintegrasi dengan Pagerduty, OpsGenie). Gratis hingga 1 tim (satu tim merujuk pada satu on call)
  * [pagertree.com](https://pagertree.com/) - Antarmuka sederhana untuk alerting dan manajemen on-call. Gratis hingga 5 pengguna.
  * [phare.io](https://phare.io/) - Monitoring Uptime gratis hingga 100.000 event untuk proyek tanpa batas dan halaman status tanpa batas.
  * [pingbreak.com](https://pingbreak.com/) — Layanan monitoring uptime modern. Cek URL tanpa batas dan dapatkan notifikasi downtime via Discord, Slack, atau email.
  * [pingpong.one](https://pingpong.one/) — Platform halaman status canggih dengan monitoring. Paket gratis mencakup satu halaman status publik yang dapat disesuaikan dengan subdomain SSL. Paket Pro diberikan gratis untuk proyek open-source dan organisasi nirlaba.
  * [robusta.dev](https://home.robusta.dev/) — Monitoring Kubernetes yang kuat berbasis Prometheus. Gunakan Prometheus Anda sendiri atau instal paket all-in-one. Paket gratis mencakup hingga 20 node Kubernetes. Alert via Slack, Microsoft Teams, Discord, dan lainnya. Integrasi dengan PagerDuty, OpsGenie, VictorOps, DataDog, dan banyak alat lainnya.
  * [sematext.com](https://sematext.com/) — Gratis untuk metrik 24 jam, server tanpa batas, sepuluh metrik kustom, 500.000 data metrik kustom, dasbor tanpa batas, pengguna tanpa batas, dll.
  * [sitemonki.com](https://sitemonki.com/) — Monitoring website, domain, Cron & SSL, 5 monitor di setiap kategori secara gratis
  * [sitesure.net](https://sitesure.net) - Monitoring website dan cron - 2 monitor gratis
  * [skylight.io](https://www.skylight.io/) — Gratis untuk 100.000 permintaan pertama (hanya Rails)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — API Monitoring Kinerja, cek Ping, DNS, dll.
  * [stathat.com](https://www.stathat.com/) — Mulai dengan sepuluh statistik gratis, tanpa kedaluwarsa
  * [statuscake.com](https://www.statuscake.com/) — Monitoring website, tes tanpa batas gratis dengan keterbatasan
  * [statusgator.com](https://statusgator.com/) — Monitoring halaman status, 3 monitor gratis
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — Monitoring server, monitoring uptime, monitoring DNS & domain. Monitor 10 server, 10 uptime, dan 10 domain gratis.
  * [thousandeyes.com](https://www.thousandeyes.com/) — Monitoring jaringan dan pengalaman pengguna. 3 lokasi dan 20 data feed layanan web utama gratis
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — Monitoring gratis untuk lima website, interval 60 detik, halaman status publik.
  * [zenduty.com](https://www.zenduty.com/) — Platform manajemen insiden end-to-end, alerting, manajemen on-call, dan orkestrasi respons untuk operasi jaringan, site reliability engineering, dan tim DevOps. Gratis hingga 5 pengguna.
  * [instatus.com](https://instatus.com) - Dapatkan halaman status yang indah dalam 10 detik. Gratis selamanya dengan subs tanpa batas dan tim tanpa batas.
  * [Squadcast.com](https://squadcast.com) - Squadcast adalah perangkat lunak manajemen insiden end-to-end yang dirancang untuk membantu Anda menerapkan praktik terbaik SRE. Paket gratis selamanya tersedia untuk hingga 10 pengguna.
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri adalah monitor uptime yang stabil yang menawarkan berbagai jenis monitor: cronjob, keyword, website, port, ping. Dua puluh lima pemeriksaan uptime dengan interval 3 menit secara gratis. Alert via Telepon, SMS, Email, dan Webhooks.
  * [Better Stack](https://betterstack.com/better-uptime) - Monitoring uptime, manajemen insiden, penjadwalan/on-call alert, dan halaman status dalam satu produk. Paket gratis mencakup sepuluh monitor dengan frekuensi cek 3 menit dan halaman status.
  * [Pulsetic](https://pulsetic.com) - 10 monitor, 6 Bulan riwayat Uptime/Log, halaman status tanpa batas, dan domain kustom! Untuk waktu tak terbatas dan notifikasi email tanpa batas gratis. Tidak perlu kartu kredit.
  * [Wachete](https://www.wachete.com) - monitoring lima halaman, cek setiap 24 jam.
  * [Xitoring.com](https://xitoring.com/) — Monitoring uptime: 20 gratis, Monitoring Server Linux dan Windows: 5 gratis, Halaman status: 1 gratis - Aplikasi mobile, berbagai saluran notifikasi, dan banyak lagi!
  * [Servervana](https://servervana.com) - Monitoring uptime tingkat lanjut dengan dukungan untuk proyek dan tim besar. Menyediakan monitoring HTTP, monitoring berbasis Browser, monitoring DNS, monitoring domain, halaman status, dan lainnya. Paket gratis mencakup 10 monitor HTTP, 1 monitor DNS, dan satu halaman status.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Penanganan Crash dan Exception
  * [CatchJS.com](https://catchjs.com/) - Pelacakan error JavaScript dengan screenshot dan jejak klik. Gratis untuk proyek open-source.
  * [bugsnag.com](https://www.bugsnag.com/) — Gratis hingga 2.000 error/bulan setelah masa percobaan awal
  * [elmah.io](https://elmah.io/) — Pencatatan error dan pemantauan uptime untuk pengembang web. Langganan Small Business gratis untuk proyek open-source.
  * [Embrace](https://embrace.io/) — Pemantauan aplikasi mobile. Gratis untuk tim kecil dengan hingga 1 juta sesi pengguna per tahun.
  * [exceptionless](https://exceptionless.com) — Pelaporan error, fitur, log secara real-time, dan lainnya. Gratis untuk 3k event per bulan/1 pengguna. Open source dan mudah di-host sendiri untuk penggunaan tanpa batas.
  * [GlitchTip](https://glitchtip.com/) — Pelacakan error sederhana, open-source. Kompatibel dengan SDK Sentry open-source. 1000 event per bulan gratis, atau bisa host sendiri tanpa batasan
  * [honeybadger.io](https://www.honeybadger.io) - Pemantauan exception, uptime, dan cron. Gratis untuk tim kecil dan proyek open-source (12.000 error/bulan).
  * [memfault.com](https://memfault.com) — Platform observabilitas dan debugging perangkat cloud. 100 perangkat gratis untuk perangkat [Nordic](https://app.memfault.com/register-nordic), [NXP](https://app.memfault.com/register-nxp), dan [Laird](https://app.memfault.com/register-laird).
  * [rollbar.com](https://rollbar.com/) — Pemantauan exception dan error, paket gratis dengan 5.000 error/bulan, pengguna tak terbatas, retensi 30 hari
  * [sentry.io](https://sentry.io/) — Sentry melacak exception aplikasi secara real-time dan memiliki paket gratis kecil. Gratis untuk 5k error per bulan/1 pengguna, penggunaan tanpa batas jika di-host sendiri
  * [Axiom](https://axiom.co/) — Simpan hingga 0,5 TB log dengan retensi 30 hari. Termasuk integrasi dengan platform seperti Vercel dan pencarian data tingkat lanjut dengan notifikasi email/Discord.
  * [Semaphr](https://semaphr.com) — Kill switch gratis all-in-one untuk aplikasi mobile Anda.
  * [Jam](https://jam.dev) - Laporan bug ramah pengembang dalam satu klik. Paket gratis dengan jumlah jam tak terbatas.
  * [Whitespace](https://whitespace.dev) – Laporan bug satu klik langsung di browser Anda. Paket gratis dengan rekaman tak terbatas untuk penggunaan pribadi.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Pencarian

  * [algolia.com](https://www.algolia.com/) — Solusi pencarian ter-host dengan toleransi typo, relevansi, dan pustaka UI untuk membuat pengalaman pencarian dengan mudah. Paket gratis "Build" mencakup 1M dokumen dan 10K pencarian/bulan. Juga menawarkan [pencarian dokumentasi pengembang](https://docsearch.algolia.com/) secara gratis.
  * [bonsai.io](https://bonsai.io/) — Gratis 1 GB memori dan 1 GB penyimpanan
  * [CommandBar](https://www.commandbar.com/) - Search Bar terpadu sebagai layanan, widget/plugin UI berbasis web yang memungkinkan pengguna Anda mencari konten, navigasi, fitur, dll. dalam produk Anda, yang membantu penemuan fitur. Gratis hingga 1.000 Pengguna Aktif Bulanan, perintah tak terbatas.
  * [Orama Cloud](https://orama.com/pricing) — Gratis 3 indeks, 100K dokumen/indeks, pencarian full-text/vektor/hibrida tak terbatas, 60 hari analitik
  * [searchly.com](http://www.searchly.com/) — Gratis 2 indeks dan 20 MB penyimpanan
  * [easysitesearch.com](https://easysitesearch.com/) — Widget dan API pencarian, dengan pengindeksan otomatis berbasis web-crawler. Pencarian tak terbatas gratis, hingga 50 subhalaman.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Pendidikan dan Pengembangan Karier

  * [FreeCodeCamp](https://www.freecodecamp.org/) - Platform open-source yang menawarkan kursus dan sertifikasi gratis di Analisis Data, Keamanan Informasi, Pengembangan Web, dan lainnya.
  * [The Odin Project](https://www.theodinproject.com/) - Platform gratis dan open-source dengan kurikulum berfokus pada JavaScript dan Ruby untuk pengembangan web.
  * [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - Platform gratis dengan banyak template Resume Profesional Berpengalaman, siap untuk dikloning, diedit sepenuhnya, dan diunduh, dioptimalkan untuk ATS.
  * [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - Kursus singkat gratis dari para ahli industri terkemuka untuk pengalaman langsung dengan alat dan teknik AI generatif terbaru dalam satu jam atau kurang.
  * [LabEx](https://labex.io) - Kembangkan keterampilan Linux, DevOps, Keamanan Siber, Pemrograman, Data Science, dan lainnya melalui laboratorium interaktif dan proyek dunia nyata.
  * [Roadmap.sh](https://roadmap.sh) - Roadmap pembelajaran gratis yang mencakup semua aspek pengembangan mulai dari Blockchain hingga UX Design.
  * [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - Menawarkan kursus gratis yang selaras dengan sertifikasi di topik seperti keamanan siber, jaringan, dan Python.
  * [MIT OpenCourseWare](https://ocw.mit.edu/) - MIT OpenCourseWare adalah publikasi daring dari materi lebih dari 2.500 kursus MIT, berbagi pengetahuan secara gratis dengan pelajar dan pendidik di seluruh dunia. Channel Youtube dapat ditemukan di [@mitocw](https://www.youtube.com/@mitocw/featured)
  * [W3Schools](https://www.w3schools.com/) - Menyediakan tutorial gratis tentang teknologi pengembangan web seperti HTML, CSS, JavaScript, dan lainnya.
  * [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - Panduan daring gratis untuk belajar HTML/CSS dasar dan lanjutan, JavaScript, dan SQL.
  * [Full Stack Open](https://fullstackopen.com/en/) – Kursus tingkat universitas gratis tentang pengembangan web modern dengan React, Node.js, GraphQL, TypeScript, dan lainnya. Sepenuhnya daring dan mandiri.
  * [edX](https://www.edx.org/) - Menawarkan akses ke lebih dari 4.000 kursus daring gratis dari 250 institusi terkemuka, termasuk Harvard dan MIT, dengan spesialisasi di ilmu komputer, teknik, dan data sains.
  * [Django-tutorial.dev](https://django-tutorial.dev) - Panduan daring gratis untuk belajar Django sebagai framework pertama & memberikan backlink dofollow gratis ke artikel yang ditulis pengguna.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Email

  * [10minutemail](https://10minutemail.com) - Email sementara gratis untuk pengujian.
  * [AhaSend](https://ahasend.com) - Layanan email transaksional, gratis untuk 1000 email per bulan, dengan domain tak terbatas, anggota tim, webhook, dan rute pesan dalam paket gratis.
  * [AnonAddy](https://anonaddy.com) - Forwarding email anonim open-source, buat alias email tak terbatas secara gratis
  * [Antideo](https://www.antideo.com/) — 10 permintaan API per jam untuk verifikasi email, validasi IP, dan nomor telepon di tier gratis. Tidak perlu Kartu Kredit.
  * [Brevo](https://www.brevo.com/) — 9.000 email/bulan, 300 email/hari gratis
  * [OneSignal](https://onesignal.com/) — 10.000 email/bulan, Tidak perlu Kartu Kredit.
  * [Bump](https://bump.email/) - 10 alamat email Bump gratis, satu domain kustom
  * [Burnermail](https://burnermail.io/) – 5 Alamat Email Burner gratis, 1 Kotak Masuk, Riwayat Kotak Masuk 7 hari
  * [Buttondown](https://buttondown.email/) — Layanan newsletter. Hingga 100 pelanggan gratis
  * [CloudMailin](https://www.cloudmailin.com/) - Email masuk via HTTP POST dan email keluar transaksional - 10.000 email gratis/bulan
  * [Contact.do](https://contact.do/) — Formulir kontak dalam sebuah tautan (bitly untuk formulir kontak)
  * [debugmail.io](https://debugmail.io/) — Server mail pengujian yang mudah digunakan untuk pengembang
  * [DNSExit](https://dnsexit.com/) - Hingga 2 alamat Email di bawah domain Anda gratis dengan ruang penyimpanan 100MB. Dukungan IMAP, POP3, SMTP, SPF/DKIM.
  * [EmailLabs.io](https://emaillabs.io/en) — Kirim hingga 9.000 Email gratis setiap bulan, hingga 300 email harian.
  * [EmailOctopus](https://emailoctopus.com) - Hingga 2.500 pelanggan dan 10.000 email per bulan gratis
  * [EmailJS](https://www.emailjs.com/) – Ini bukan server email lengkap; ini adalah klien email yang dapat Anda gunakan untuk mengirim email langsung dari klien tanpa mengekspos kredensial Anda, tier gratis memiliki 200 permintaan bulanan, 2 template email, Permintaan hingga 50Kb, Riwayat kontak terbatas.
  * [EtherealMail](https://ethereal.email) - Ethereal adalah layanan SMTP palsu, terutama ditujukan untuk pengguna Nodemailer dan EmailEngine (tapi tidak terbatas pada itu). Ini adalah layanan email anti-transaksional sepenuhnya gratis di mana pesan tidak pernah terkirim.
  * [Temp-Mail.org](https://temp-mail.org/en/) - Generator Email Sementara / Disposable dengan beragam domain. Alamat email berubah setiap kali halaman dimuat ulang. Sepenuhnya gratis dan tidak ada harga untuk layanan mereka.
  * [TempMailDetector.com](https://tempmaildetector.com/) - Verifikasi hingga 200 email per bulan gratis dan lihat apakah email itu sementara atau tidak.
  * [Emailvalidation.io](https://emailvalidation.io) - 100 verifikasi email gratis per bulan
  * [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - Generator Email Sementara / Disposable dari Jerman. Mendukung 10 domain, dan memungkinkan Anda membuat alamat tak terbatas. (termasuk iklan) namun selain itu, tidak ada harga untuk layanannya, sepenuhnya gratis.
  * [forwardemail.net](https://forwardemail.net) — Forwarding email gratis untuk domain kustom. Buat dan teruskan alamat email tak terbatas dengan nama domain Anda (**catatan**: Anda harus membayar jika menggunakan TLD .casa, .cf, .click, .email, .fit, .ga, .gdn, .gq, .lat, .loan, .london, .men, .ml, .pl, .rest, .ru, .tk, .top, .work karena alasan spam)
  * [Imitate Email](https://imitate.email) - Sandbox Email Server untuk pengujian fungsi email di build/qa dan ci/cd. Akun gratis mendapat 15 email per hari selamanya.
  * [ImprovMX](https://improvmx.com) – Forwarding email gratis.
  * [EForw](https://www.eforw.com) – Forwarding email gratis untuk satu domain. Terima dan kirim email dari domain Anda.
  * [Inboxes App](https://inboxesapp.com) — Buat hingga 3 email sementara per hari, lalu hapus saat selesai dari ekstensi Chrome yang praktis. Sempurna untuk menguji alur pendaftaran.
  * [inboxkitten.com](https://inboxkitten.com/) - Inbox email sementara/disposable gratis, dengan penghapusan email otomatis hingga 3 hari. Open source dan bisa di-host sendiri.
  * [mail-tester.com](https://www.mail-tester.com) — Uji apakah pengaturan DNS/SPF/DKIM/DMARC email sudah benar, 20 gratis/bulan.
  * [dkimvalidator.com](https://dkimvalidator.com/) - Uji apakah pengaturan DNS/SPF/DKIM/DMARC email sudah benar, layanan gratis dari roundsphere.com
  * [mailcatcher.me](https://mailcatcher.me/) — Menangkap email dan menampilkannya melalui antarmuka web.
  * [mailchannels.com](https://www.mailchannels.com) - Email API dengan integrasi REST API dan SMTP, gratis hingga 3.000 email/bulan.
  * [Mailcheck.ai](https://www.mailcheck.ai/) - Mencegah pengguna mendaftar dengan alamat email sementara, 120 permintaan/jam (~86.400 per bulan)
  * [Mailchimp](https://mailchimp.com/) — 500 pelanggan dan 1.000 email/bulan gratis.
  * [Maildroppa](https://maildroppa.com) - Hingga 100 pelanggan dan email tak terbatas serta otomatisasi gratis.
  * [MailerLite.com](https://www.mailerlite.com) — 1.000 pelanggan/bulan, 12.000 email/bulan gratis
  * [MailerSend.com](https://www.mailersend.com) — Email API, SMTP, 3.000 email/bulan gratis untuk email transaksional
  * [mailinator.com](https://www.mailinator.com/) — Sistem email publik gratis di mana Anda dapat menggunakan inbox apapun yang Anda inginkan
  * [Mailjet](https://www.mailjet.com/) — 6.000 email/bulan gratis (batas pengiriman harian 200 email)
  * [Mailnesia](https://mailnesia.com) - Email sementara/disposable gratis, yang otomatis mengunjungi tautan registrasi.
  * [mailsac.com](https://mailsac.com) - API gratis untuk pengujian email sementara, hosting email publik gratis, outbound capture, email-ke-slack/websocket/webhook (batas 1.500 API bulanan)
  * [Mailtrap.io](https://mailtrap.io/) — Server SMTP palsu untuk pengembangan, paket gratis dengan satu inbox, 100 pesan, tanpa anggota tim, dua email/detik, tanpa aturan forward.
  * [Mail7.io](https://www.mail7.io/) — Alamat Email Sementara Gratis untuk QA Developer. Buat alamat email instan menggunakan Web Interface atau API.
  * [Momentary Email](https://www.momentaryemail.com/) — Alamat Email Sementara Gratis. Baca email masuk di situs web atau melalui RSS feed.
  * [Mutant Mail](https://www.mutantmail.com/) – 10 ID Email gratis, 1 Domain, 1 Kotak Masuk. Satu Kotak Masuk untuk Semua ID Email.
  * [Outlook.com](https://outlook.live.com/owa/) - Email dan kalender pribadi gratis.
  * [Parsio.io](https://parsio.io) — Email parser gratis (Forward email, ekstrak data, kirim ke server Anda)
  * [pepipost.com](https://pepipost.com) — 30k email gratis untuk bulan pertama, kemudian 100 email pertama/hari gratis.
  * [Plunk](https://useplunk.com) - 3K email/bulan gratis
  * [Postmark](https://postmarkapp.com/) - 100 email/bulan gratis, DMARC mingguan tak terbatas.
  * [Proton Mail](https://proton.me/mail) -  Layanan email aman gratis dengan enkripsi end-to-end bawaan. 1GB penyimpanan gratis.
  * [Queuemail.dev](https://queuemail.dev) — API pengiriman email yang andal. Paket gratis (10.000 email/bulan). Pengiriman asinkron. Gunakan beberapa server SMTP. Blocklist, Logging, Tracking, Webhook, dan lainnya.
  * [QuickEmailVerification](https://quickemailverification.com) — Verifikasi 100 email harian secara gratis pada tier gratis bersama dengan API gratis lain seperti DEA Detector, DNS Lookup, SPF Detector, dan lainnya.
* [Resend](https://resend.com) - API email transaksional untuk pengembang. 3.000 email/bulan, 100 email/hari gratis, satu domain kustom.
* [Sender](https://www.sender.net) Hingga 15.000 email/bulan, hingga 2.500 pelanggan
* [Sendpulse](https://sendpulse.com) — 500 pelanggan/bulan, 15.000 email/bulan gratis
* [SimpleLogin](https://simplelogin.io/) – Solusi alias/forwarding email open source yang bisa di-host sendiri. Gratis 5 Alias, bandwidth tak terbatas, balas/kirim tak terbatas. Gratis untuk staf pendidikan (mahasiswa, peneliti, dll.).
* [Substack](https://substack.com) — Layanan newsletter tanpa batas secara gratis. Mulai membayar ketika Anda memungut biaya dari pelanggan.
* [Sweego](https://www.sweego.io/) - API email transaksional Eropa untuk pengembang. 500 email/hari gratis.
* [Takeout](https://takeout.bysourfruit.com) - Layanan email yang selalu diperbarui yang memudahkan pengiriman email. Lima ratus email transaksional/bulan gratis.
* [temp-mail.io](https://temp-mail.io) — Layanan email sementara sekali pakai gratis dengan banyak email sekaligus dan forwarding
* [tinyletter.com](https://tinyletter.com/) — 5.000 pelanggan/bulan gratis
* [Touchlead](https://touchlead.app) - Alat otomatisasi pemasaran multi-fungsi, dengan manajemen prospek, pembuat formulir, dan otomatisasi. Gratis untuk jumlah prospek dan otomatisasi terbatas
* [trashmail.com](https://www.trashmail.com) - Alamat email sekali pakai gratis dengan forwarding dan kadaluarsa alamat otomatis
* [Tuta](https://tuta.com/) - Penyedia layanan akun email aman gratis dengan enkripsi end-to-end bawaan, tanpa iklan, tanpa pelacakan. Gratis 1GB penyimpanan, satu kalender (Tuta juga memiliki [paket berbayar](https://tuta.com/pricing).). Tuta juga sebagian [open source](https://github.com/tutao/tutanota), sehingga Anda dapat meng-host sendiri.
* [Verifalia](https://verifalia.com/email-verification-api) — API verifikasi email real-time dengan konfirmasi mailbox dan detektor alamat email sekali pakai; 25 verifikasi email gratis/hari.
* [verimail.io](https://verimail.io/) — Layanan verifikasi email massal dan API. 100 verifikasi gratis/bulan
* [Zoho](https://www.zoho.com) — Awalnya sebagai penyedia email, sekarang menawarkan rangkaian layanan, beberapa di antaranya memiliki paket gratis. Daftar layanan dengan paket gratis:
   - [Email](https://zoho.com/mail) Gratis untuk 5 pengguna. 5GB/pengguna & batas lampiran 25 MB, satu domain.
   - [Zoho Assist](https://www.zoho.com/assist) — Paket gratis selamanya dari Zoho Assist mencakup satu lisensi dukungan jarak jauh bersamaan dan akses ke 5 lisensi komputer tanpa pengawasan untuk durasi tidak terbatas, tersedia untuk penggunaan profesional maupun pribadi.
   - [Sprints](https://zoho.com/sprints) Gratis untuk 5 pengguna, 5 Proyek & 500MB penyimpanan.
   - [Docs](https://zoho.com/docs) — Gratis untuk 5 pengguna dengan batas unggah 1 GB & 5GB penyimpanan. Zoho Office Suite (Writer, Sheets & Show) sudah termasuk.
   - [Projects](https://zoho.com/projects) — Gratis untuk 3 pengguna, 2 proyek & batas lampiran 10 MB. Paket yang sama juga berlaku untuk [Bugtracker](https://zoho.com/bugtracker).
   - [Connect](https://zoho.com/connect) — Kolaborasi Tim gratis untuk 25 pengguna dengan tiga grup, tiga aplikasi kustom, 3 Papan, 3 Manual, dan 10 Integrasi beserta saluran, acara & forum.
   - [Meeting](https://zoho.com/meeting) — Pertemuan dengan hingga 3 peserta & 10 peserta Webinar.
   - [Vault](https://zoho.com/vault) — Manajemen Kata Sandi dapat diakses untuk Individu.
   - [Showtime](https://zoho.com/showtime) — Perangkat lunak Meeting lain untuk pelatihan sesi jarak jauh hingga 5 peserta.
   - [Notebook](https://zoho.com/notebook) — Alternatif gratis untuk Evernote.
   - [Wiki](https://zoho.com/wiki) — Gratis untuk tiga pengguna dengan 50 MB penyimpanan, halaman tak terbatas, backup zip, RSS & Atom feed, kontrol akses & CSS yang dapat dikustomisasi.
   - [Subscriptions](https://zoho.com/subscriptions) — Manajemen penagihan berulang gratis untuk 20 pelanggan/subscription & 1 pengguna dengan semua hosting pembayaran oleh Zoho. 40 metrik subscription terakhir disimpan.
   - [Checkout](https://zoho.com/checkout) — Manajemen penagihan produk dengan 3 halaman & hingga 50 pembayaran.
   - [Desk](https://zoho.com/desk) — Manajemen Dukungan Pelanggan dengan tiga agen, basis pengetahuan privat, dan tiket email. Terintegrasi dengan [Assist](https://zoho.com/assist) untuk satu teknisi jarak jauh & 5 komputer tanpa pengawasan.
   - [Cliq](https://zoho.com/cliq) — Perangkat lunak chat tim dengan 100 GB penyimpanan, pengguna tak terbatas, 100 pengguna per channel & SSO.
   - [Campaigns](https://zoho.com/campaigns) - Email Marketing
   - [Forms](https://zoho.com/forms) - Pembuat Formulir
   - [Sign](https://zoho.com/sign) - Tanda Tangan Digital
   - [Surveys](https://zoho.com/surveys) - Survei Online
   - [Bookings](https://zoho.com/bookings) - Penjadwalan Janji Temu
* [Maileroo](https://maileroo.com) - SMTP relay dan email API untuk pengembang. 5.000 email per bulan, domain tak terbatas, verifikasi email gratis, pemantauan blacklist, mail tester, dan lainnya.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Platform Manajemen Feature Toggles

* [ConfigCat](https://configcat.com) - ConfigCat adalah layanan feature flag yang berfokus pada pengembang dengan ukuran tim tak terbatas, dukungan luar biasa, dan harga yang wajar. Paket gratis hingga 10 flag, dua lingkungan, 1 produk, dan 5 Juta permintaan per bulan.
* [Flagsmith](https://flagsmith.com) - Rilis fitur dengan percaya diri; kelola feature flag di aplikasi web, mobile, dan server-side. Gunakan API yang di-host, deploy ke cloud pribadi Anda, atau jalankan secara on-premise.
* [GrowthBook](https://growthbook.io) - Penyedia feature flag dan A/B testing open source dengan mesin analisis statistik Bayesian bawaan. Gratis hingga 3 pengguna, feature flag dan eksperimen tanpa batas.
* [Hypertune](https://www.hypertune.com) - Feature flag type-safe, A/B testing, analytics dan konfigurasi aplikasi, dengan kontrol versi gaya Git dan evaluasi flag lokal, in-memory, sinkron. Gratis hingga 5 anggota tim dengan feature flag dan A/B test tak terbatas.
* [Molasses](https://www.molasses.app) - Feature flag dan A/B testing yang kuat. Gratis hingga 3 lingkungan dengan masing-masing lima feature flag.
* [Toggled.dev](https://www.toggled.dev) - Platform manajemen feature toggles multi-regional yang siap untuk enterprise dan dapat diskalakan. Paket gratis hingga 10 flag, dua lingkungan, permintaan tak terbatas. SDK, dashboard analytics, kalender rilis, notifikasi Slack, dan semua fitur lain sudah termasuk dalam paket gratis tanpa batas.
* [Statsig](https://www.statsig.com) - Platform kuat untuk manajemen fitur, A/B testing, analitik, dan lainnya. Paket gratisnya menawarkan kursi, flag, eksperimen, dan konfigurasi dinamis tanpa batas, mendukung hingga 1 juta event per bulan.
* [Abby](https://www.tryabby.com) - Feature flag & A/B testing Open-Source. Konfigurasi sebagai Kode & SDK Typescript Sepenuhnya Bertipe. Integrasi kuat dengan Framework seperti Next.js & React. Tier gratis yang murah hati dan opsi scaling murah.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Font

* [dafont](https://www.dafont.com/) - Font yang ditampilkan di situs ini adalah milik penulisnya dan dapat berupa freeware, shareware, versi demo, atau domain publik.
* [Everything Fonts](https://everythingfonts.com/) - Menawarkan berbagai alat; @font-face, Units Converter, Font Hinter, dan Font Submitter.
* [Font Squirrel](https://www.fontsquirrel.com/) - Font freeware berlisensi untuk kerja komersial. Dipilih secara manual dan disajikan dalam format mudah digunakan.
* [Google Fonts](https://fonts.google.com/) - Banyak font gratis yang mudah dan cepat diinstal di situs web melalui unduhan atau tautan ke CDN Google.
* [FontGet](https://www.fontget.com/) - Memiliki berbagai macam font yang tersedia untuk diunduh dan diurutkan dengan tag secara rapi.
* [Fontshare](https://www.fontshare.com/) - layanan font gratis. Koleksi font profesional yang terus berkembang, 100% gratis untuk penggunaan pribadi dan komersial.
* [Befonts](https://befonts.com/) - Menyediakan beberapa font unik untuk penggunaan pribadi atau komersial.
* [Font of web](https://fontofweb.com/) - Mengidentifikasi semua font yang digunakan di sebuah website dan bagaimana mereka digunakan.
* [Bunny](https://fonts.bunny.net) Google Fonts dengan orientasi privasi
* [FontsKey](https://www.fontskey.com/) - Menyediakan font gratis dan berbayar komersial untuk penggunaan pribadi dan dapat memasukkan teks untuk pemfilteran cepat.
* [fonts.xz.style](https://fonts.xz.style/) layanan gratis dan open source untuk mengirimkan keluarga font ke situs web menggunakan CSS.
* [Fontsensei](https://fontsensei.com/) Google fonts open source yang ditag oleh pengguna. Dengan tag font CJK (Cina, Jepang, Korea).

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Formulir

* [Feathery](https://feathery.io) - Pembuat formulir yang kuat dan ramah pengembang. Bangun formulir signup & login, onboarding pengguna, alur pembayaran, aplikasi keuangan kompleks, dan lainnya. Paket gratis memungkinkan hingga 250 pengiriman/bulan dan lima formulir aktif.
* [Form-Data](https://form-data.com) - Backend formulir tanpa kode. Filter spam, notifikasi email dan auto-respond, webhook, zapier, redirect, AJAX atau POST, dan lainnya. Paket gratis menawarkan formulir tak terbatas, 20 pengiriman/bulan, dan tambahan 2000 pengiriman dengan badge Form-Data.
* [FabForm](https://fabform.io/) - Platform backend formulir untuk pengembang cerdas. Paket gratis memungkinkan 250 pengiriman formulir per bulan. GUI modern yang ramah. Terintegrasi dengan Google Sheets, Airtable, Slack, Email, dan lainnya.
* [Form.taxi](https://form.taxi/) — Endpoint untuk pengiriman formulir HTML. Dengan notifikasi, pemblokir spam, dan pemrosesan data yang sesuai GDPR. Paket gratis untuk penggunaan dasar.
* [Formcarry.com](https://formcarry.com) - HTTP POST Endpoint Formulir, Paket gratis memungkinkan 100 pengiriman bulanan.
* [formingo.co](https://www.formingo.co/)- Formulir HTML mudah untuk situs statis. Anda dapat mulai gratis tanpa mendaftar akun. Paket gratis memungkinkan 500 pengiriman bulanan dan alamat email reply-to yang dapat dikustomisasi.
* [FormKeep.com](https://www.formkeep.com/) - Formulir tak terbatas dengan 50 pengiriman bulanan, perlindungan spam, notifikasi email, dan desainer drag-and-drop yang bisa ekspor HTML. Fitur tambahan termasuk aturan bidang kustom, tim, dan integrasi ke Google Sheets, Slack, ActiveCampaign, dan Zapier.
* [formlets.com](https://formlets.com/) — Formulir online, formulir satu halaman tak terbatas/bulan, 100 pengiriman/bulan, notifikasi email.
* [formspark.io](https://formspark.io/) - Layanan Form ke Email, paket gratis memungkinkan formulir tak terbatas, 250 pengiriman per bulan, dukungan dari tim Customer assistance.
* [Formspree.io](https://formspree.io/) — Kirim email menggunakan permintaan HTTP POST. Tier gratis dibatasi 50 pengiriman per formulir per bulan.
* [Formsubmit.co](https://formsubmit.co/) — Endpoint formulir mudah untuk HTML Anda. Gratis selamanya. Tidak perlu registrasi.
* [Formlick.com](https://formlick.com) - Alternatif Typeform dengan paket seumur hidup. Pengguna dapat membuat 1 formulir gratis dan menerima pengiriman tanpa batas. Untuk premium, pengguna dapat membuat formulir tak terbatas dan pengiriman tak terbatas.
* [getform.io](https://getform.io/) - Platform backend formulir untuk desainer dan pengembang, 1 formulir, 50 pengiriman, Single file upload, 100MB penyimpanan file.
* [HeroTofu.com](https://herotofu.com/) - Backend formulir dengan deteksi bot dan arsip terenkripsi. Teruskan pengiriman via UI ke email, Slack, atau Zapier. Gunakan front end Anda sendiri. Tidak perlu kode server. Paket gratis memberikan formulir tak terbatas dan 100 pengiriman per bulan.
* [HeyForm.net](https://heyform.net/) - Pembuat formulir online drag and drop. Tier gratis memungkinkan Anda membuat formulir tak terbatas dan mengumpulkan pengiriman tak terbatas. Dilengkapi template siap pakai, anti-spam, dan penyimpanan file 100MB.
* [Tally.so](https://tally.so/) - 99% fitur gratis. Tier gratis memungkinkan: formulir tak terbatas, pengiriman tak terbatas, notifikasi email, logika formulir, terima pembayaran, upload file, halaman terima kasih kustom, dan banyak lagi.
* [Hyperforms.app](https://hyperforms.app/) — Buat form to email dan lebih banyak lagi dalam hitungan detik tanpa kode backend. Akun Personal memberi hingga 50 pengiriman formulir per bulan secara gratis.
* [Kwes.io](https://kwes.io/) - Endpoint formulir kaya fitur. Bekerja sangat baik dengan situs statis. Paket gratis termasuk hingga 1 website dengan hingga 50 pengiriman bulanan.
* [Pageclip](https://pageclip.co/) - Paket gratis memungkinkan satu situs, satu formulir, dan 1.000 pengiriman bulanan.
* [Qualtrics Survey](https://qualtrics.com/free-account) — Buat formulir & survei profesional dengan alat kelas satu ini. 50+ template survei dari ahli. Akun gratis dibatasi 1 survei aktif, 100 respons/survei & 8 jenis respons.
* [Screeb](https://screeb.app/) - Survei in-app dan analitik produk untuk menganalisis perilaku pengguna. Paket gratis selamanya memungkinkan 500 pengguna aktif bulanan, respons dan event tak terbatas, banyak integrasi, ekspor, dan laporan berkala.
* [smartforms.dev](https://smartforms.dev/) - Backend formulir yang kuat dan mudah untuk situs web Anda, paket gratis selamanya memungkinkan 50 pengiriman per bulan, 250MB penyimpanan file, integrasi Zapier, ekspor CSV/JSON, redirect kustom, halaman respons kustom, bot Telegram & Slack, notifikasi email tunggal.
* [Survicate](https://survicate.com/) — Ambil feedback dari semua sumber dan kirim survei tindak lanjut dengan satu alat. Analisis feedback otomatis dengan AI. Email gratis, survei website, in-product atau mobile, pembuat survei AI, dan 25 respons bulanan.
* [staticforms.xyz](https://www.staticforms.xyz/) - Integrasikan formulir HTML dengan mudah tanpa kode server-side secara gratis. Setelah pengguna mengirimkan formulir, email berisi isi formulir akan dikirim ke alamat terdaftar Anda.
* [stepFORM.io](https://stepform.io) - Pembuat Kuis dan Formulir. Paket gratis memiliki lima formulir, hingga 3 langkah per formulir, dan 50 respons bulanan.
* [Typeform.com](https://www.typeform.com/) — Sertakan formulir dengan desain indah di situs web. Paket gratis hanya memungkinkan sepuluh field per formulir dan 100 respons bulanan.
* [WaiverStevie.com](https://waiverstevie.com) - Platform Tanda Tangan Elektronik dengan REST API. Anda dapat menerima notifikasi dengan webhook. Paket gratis memberi watermark pada dokumen yang ditandatangani tapi memungkinkan amplop + tanda tangan tak terbatas.
* [Web3Forms](https://web3forms.com) - Formulir kontak untuk Situs Static & JAMStack tanpa perlu menulis kode backend. Paket gratis memungkinkan Formulir Tak Terbatas, Domain Tak Terbatas & 250 Pengiriman per bulan.
* [WebAsk](https://webask.io) - Pembuat Survei dan Formulir. Paket gratis memiliki tiga survei per akun, 100 respons bulanan, dan sepuluh elemen per survei.
* [Wufoo](https://www.wufoo.com/) - Formulir cepat untuk digunakan di situs web. Paket gratis dibatasi hingga 100 pengiriman setiap bulan.
* [formpost.app](https://formpost.app) - Layanan Form to Email gratis, tanpa batas. Atur redirect khusus, auto-response, webhook, dan lainnya secara gratis.
* [Formester.com](https://formester.com) - Bagikan dan sematkan formulir unik di situs web Anda—tanpa batas jumlah formulir yang dibuat atau fitur yang dibatasi oleh paket. Dapatkan hingga 100 pengiriman setiap bulan secara gratis.
* [SimplePDF.eu](https://simplepdf.eu/embed) - Sematkan editor PDF di situs web Anda dan ubah PDF apa pun menjadi formulir yang dapat diisi. Paket gratis memungkinkan PDF tanpa batas dengan tiga pengiriman per PDF.
* [forms.app](https://forms.app/) — Buat formulir online dengan fitur canggih seperti logika kondisional, kalkulator skor otomatis, dan AI. Kumpulkan hingga 100 respons dengan paket gratis, sematkan formulir Anda di situs web, atau gunakan melalui tautan.
* [Qualli](https://usequalli.com) - Survei Dalam Aplikasi, dirancang untuk seluler. Gunakan Qualli AI untuk membuat pertanyaan terbaik. Anda dapat mencobanya di paket gratis kami, hingga 500 MAU, buat formulir dan pemicu tanpa batas.
* [Sprig](https://sprig.com/) - 1 Survei Dalam Produk atau Survei dengan Replay per bulan, dengan Analisis AI bertenaga GPT.
* [feedback.fish](https://feedback.fish/) - Paket gratis memungkinkan mengumpulkan 25 umpan balik secara total. Mudah diintegrasikan dengan komponen React dan Vue yang disediakan.
* [Vidhook](https://vidhook.io/) - Kumpulkan umpan balik menggunakan survei yang menarik dengan tingkat respons tinggi. Paket gratis mencakup 1 survei aktif, 25 respons per survei, dan templat yang dapat disesuaikan.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Generative AI

* [Zenable](https://zenable.io) - Otomatis perbaiki output dari alat seperti Cursor, Windsurf, dan Copilot agar memenuhi standar kualitas dan kepatuhan perusahaan Anda menggunakan guardrails yang dibangun dengan Policy as Code. Paket gratis mencakup 100 panggilan alat per hari ke server MCP dan 25 ulasan pull request otomatis gratis per hari melalui GitHub App.
* [Keywords AI](https://keywordsai.co) - Platform pemantauan LLM terbaik. Satu format untuk memanggil 200+ LLM hanya dengan 2 baris kode. 10.000 permintaan gratis setiap bulan dan $0 untuk fitur platform!
* [Portkey](https://portkey.ai/) - Panel kontrol untuk aplikasi Gen AI dengan fitur observability suite & AI gateway. Kirim & log hingga 10.000 permintaan gratis setiap bulan.
* [Braintrust](https://www.braintrustdata.com/) - Evals, prompt playground, dan manajemen data untuk Gen AI. Paket gratis memberikan hingga 1.000 baris eval privat/minggu.
* [Findr](https://www.usefindr.com/) - Pencarian universal yang memungkinkan Anda mencari semua aplikasi sekaligus. Asisten pencarian yang dapat menjawab pertanyaan menggunakan informasi Anda. Paket gratis menawarkan pencarian terpadu tanpa batas dan 5 kueri co pilot harian.
* [ReportGPT](https://ReportGPT.app) - Asisten Penulisan Bertenaga AI. Seluruh platform gratis selama Anda menggunakan kunci API sendiri.
* [Clair](https://askclair.ai/) - Referensi AI Klinis. Mahasiswa memiliki akses gratis ke rangkaian alat profesional, termasuk Open Search, Clinical Summary, Med Review, Drug Interactions, ICD-10 Codes, dan Stewardship. Selain itu, tersedia uji coba gratis untuk rangkaian profesional.
* [Langtrace](https://langtrace.ai) - memungkinkan pengembang melacak, mengevaluasi, mengelola prompt dan dataset, serta debug masalah terkait performa aplikasi LLM. Membuat jejak standar open telemetry untuk LLM apa pun yang membantu observabilitas dan bekerja dengan klien observabilitas mana pun. Paket gratis menawarkan 50K jejak/bulan.
* [LangWatch](https://langwatch.ai) - Platform LLMOps yang membantu tim AI mengukur, memantau, dan mengoptimalkan aplikasi LLM untuk keandalan, efisiensi biaya, dan performa. Dengan komponen DSPy yang kuat, memungkinkan kolaborasi mulus antara engineer dan tim non-teknis untuk fine-tuning dan produksi produk GenAI. Paket gratis mencakup semua fitur platform, 1k jejak/bulan dan 1 workflow DSPy optimizer. [#opensource](https://github.com/langwatch/langwatch)
* [Comet Opik](https://www.comet.com/site/products/opik/) - Evaluasi, uji, dan rilis aplikasi LLM di seluruh siklus pengembangan dan produksi Anda. [#opensource](https://github.com/comet-ml/opik/)
* [Langfuse](https://langfuse.com/) - Platform rekayasa LLM sumber terbuka yang membantu tim debug, analisis, dan iterasi aplikasi LLM secara kolaboratif. Paket gratis selamanya mencakup 50k observasi per bulan dan semua fitur platform. [#opensource](https://github.com/langfuse/langfuse)
* [Pollinations.AI](https://pollinations.ai/) - AI generasi gambar yang mudah digunakan, gratis dengan API gratis tersedia. Tidak perlu mendaftar atau kunci API, dan beberapa opsi untuk integrasi ke situs web atau alur kerja. [#opensource](https://github.com/pollinations/pollinations)
* [Othor AI](https://othor.ai/) - Alternatif AI-native yang cepat, sederhana, dan aman untuk solusi business intelligence populer seperti Tableau, Power BI, dan Looker. Othor menggunakan large language models (LLM) untuk memberikan solusi business intelligence kustom dalam hitungan menit. Paket Free Forever menyediakan satu workspace dengan lima koneksi datasource untuk satu pengguna, tanpa batasan analitik. [#opensource](https://github.com/othorai/othor.ai)
* [OpenRouter](https://openrouter.ai/models?q=free) - Menyediakan berbagai model AI gratis termasuk DeepSeek R1, V3, Llama, dan Moonshot AI. Model ini unggul dalam pemrosesan bahasa alami dan cocok untuk berbagai kebutuhan pengembangan. Perhatikan bahwa model-model ini gratis digunakan, tetapi tunduk pada batasan kuota. Selain itu, OpenRouter menawarkan model berbayar untuk kebutuhan lebih lanjut, seperti Claude, OpenAI, Grok, Gemini, dan Nova.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## CDN dan Perlindungan

* [bootstrapcdn.com](https://www.bootstrapcdn.com/) — CDN untuk bootstrap, bootswatch dan fontawesome.io
* [cdnjs.com](https://cdnjs.com/) — Sederhana. Cepat. Andal. Content delivery terbaik. cdnjs adalah layanan CDN gratis dan open-source yang dipercaya oleh lebih dari 11% dari seluruh situs web, didukung oleh Cloudflare.
* [developers.google.com](https://developers.google.com/speed/libraries/) — Google Hosted Libraries adalah content distribution network untuk pustaka JavaScript Open Source paling populer
* [Stellate](https://stellate.co/) - Stellate adalah CDN cepat dan andal untuk API GraphQL Anda dan gratis untuk dua layanan.
* [jsdelivr.com](https://www.jsdelivr.com/) — CDN open-source gratis, cepat, dan andal. Mendukung npm, GitHub, WordPress, Deno, dan lainnya.
* [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — Microsoft Ajax CDN menghosting pustaka JavaScript pihak ketiga populer seperti jQuery dan memungkinkan Anda dengan mudah menambahkannya ke aplikasi web Anda
* [ovh.ie](https://www.ovh.ie/ssl-gateway/) — Perlindungan DDoS gratis dan sertifikat SSL
* [Skypack](https://www.skypack.dev/) — CDN JavaScript 100% Native ES Module. Gratis untuk 1 juta permintaan per domain per bulan.
* [raw.githack.com](https://raw.githack.com/) — Pengganti modern **rawgit.com** yang hanya menghosting file menggunakan Cloudflare
* [section.io](https://www.section.io/) — Cara sederhana untuk membuat dan mengelola solusi Varnish Cache lengkap. Gratis selamanya untuk satu situs (katanya)
* [statically.io](https://statically.io/) — CDN untuk repositori Git (GitHub, GitLab, Bitbucket), aset terkait WordPress, dan gambar
* [toranproxy.com](https://toranproxy.com/) — Proxy untuk Packagist dan GitHub. Tidak pernah gagal CD. Gratis untuk penggunaan pribadi, satu developer, tanpa dukungan
* [UNPKG](https://unpkg.com/) — CDN untuk semua yang ada di npm
* [weserv](https://images.weserv.nl/) — Layanan cache & resize gambar. Manipulasi gambar secara langsung dengan cache global.
* [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — Perlindungan DDoS gratis
* [Gcore](https://gcorelabs.com/) Jaringan distribusi konten global, 1 TB dan 1 juta permintaan per bulan gratis serta hosting DNS gratis
* [CacheFly](https://portal.cachefly.com/signup/free2023) - Hingga 5 TB lalu lintas CDN gratis per bulan, 19 Core PoPs, 1 Domain, dan Universal SSL.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## PaaS

* [anvil.works](https://anvil.works) - Pengembangan aplikasi web hanya dengan Python. Paket gratis dengan aplikasi tanpa batas dan batas waktu 30 detik.
* [appwrite](https://appwrite.io) - Proyek tanpa batas tanpa penghentian proyek (mendukung websockets) dan layanan autentikasi. 1 Database, 3 Bucket, 5 Fungsi per proyek di paket gratis.
* [configure.it](https://www.configure.it/) — Platform pengembangan aplikasi mobile, gratis untuk dua proyek, fitur terbatas tetapi tanpa batas sumber daya
* [codenameone.com](https://www.codenameone.com/) — Toolchain pengembangan aplikasi mobile lintas platform open source untuk developer Java/Kotlin. Gratis untuk penggunaan komersial dengan jumlah proyek tanpa batas
* [deco.cx](https://www.deco.cx/en/dev) - Platform frontend edge-native dengan visual CMS yang dihasilkan otomatis dari kode TypeScript. Terdapat A/B testing, segmentasi konten, dan analitik real-time. Cocok untuk situs e-commerce konten-berat dan Enterprise. Gratis hingga 5k pageviews/bulan atau untuk proyek open-source/pribadi.
* [Deno Deploy](https://deno.com/deploy) - Sistem terdistribusi yang menjalankan JavaScript, TypeScript, dan WebAssembly di edge seluruh dunia. Paket gratis mencakup 100.000 permintaan per hari dan 100 GiB transfer data per bulan.
* [domcloud.co](https://domcloud.co) – Layanan hosting Linux yang menyediakan CI/CD dengan GitHub, SSH, dan database MariaDB/Postgres. Versi gratis memiliki 1 GB storage dan limit jaringan 1 GB/bulan serta terbatas pada domain gratis.
* [encore.dev](https://encore.dev/) — Framework backend yang menggunakan analisis statis untuk menyediakan infrastruktur otomatis, kode tanpa boilerplate, dan lainnya. Termasuk hosting cloud gratis untuk proyek hobi.
* [flightcontrol.dev](https://flightcontrol.dev/) - Deploy layanan web, database, dan lainnya di akun AWS Anda sendiri dengan workflow gaya Git push. Paket gratis untuk pengguna dengan 1 developer di repo GitHub pribadi. Biaya AWS ditagihkan melalui AWS, tetapi Anda dapat menggunakan kredit dan AWS free tier.
* [gigalixir.com](https://gigalixir.com/) - Gigalixir menyediakan satu instance gratis yang tidak pernah tidur dan database PostgreSQL gratis yang dibatasi 2 koneksi, 10.000 baris, dan tanpa backup untuk aplikasi Elixir/Phoenix.
* [Glitch](https://glitch.com/) — Hosting publik gratis dengan fitur berbagi kode dan kolaborasi real-time. Paket gratis memiliki batas 1000 jam/bulan.
* [leapcell](https://leapcell.io/) - Leapcell adalah platform aplikasi terdistribusi yang andal, menyediakan semua yang Anda butuhkan untuk mendukung pertumbuhan pesat Anda. Paket gratis mencakup 100k pemanggilan layanan, 10k tugas async, dan 100k perintah Redis.
* [pipedream.com](https://pipedream.com) - Platform integrasi untuk developer. Kembangkan workflow apa pun berdasarkan trigger apa pun. Workflow adalah kode yang dapat Anda jalankan [gratis](https://docs.pipedream.com/pricing/). Tanpa server atau sumber daya cloud yang perlu dikelola.
* [pythonanywhere.com](https://www.pythonanywhere.com/) — Hosting aplikasi Python di cloud. Akun pemula gratis, 1 aplikasi web Python di domain your-username.pythonanywhere.com, 512 MB penyimpanan file privat, satu database MySQL
* [ampt.dev](https://getampt.com/) - Ampt memungkinkan tim membangun, deploy, dan scale aplikasi JavaScript di AWS tanpa konfigurasi rumit atau mengelola infrastruktur. Paket Preview gratis mencakup 500 invokasi per jam, 2.500 invokasi harian, dan 50.000 invokasi bulanan. Domain kustom hanya di paket berbayar.
* [Koyeb](https://www.koyeb.com) - Koyeb adalah platform serverless ramah developer untuk deploy aplikasi secara global. Jalankan container Docker, aplikasi web, dan API dengan deployment berbasis git, autoscaling native, jaringan edge global, serta service mesh dan discovery bawaan. Instance gratis memungkinkan deploy layanan web di Frankfurt, Jerman atau Washington, D.C., AS. Database Postgres Managed gratis tersedia di Frankfurt (Jerman), Washington, D.C. (AS), dan Singapura. 512MB memori, 2GB storage, dan 0.1 CPU.
* [Napkin](https://www.napkin.io/) - FaaS dengan 500Mb memori, timeout default 15 detik, dan 5.000 panggilan API gratis/bulan dibatasi 5 panggilan/detik.
* [Meteor Cloud](https://www.meteor.com/cloud) — Hosting Galaxy. Platform Meteor-as-a-service untuk aplikasi Meteor termasuk Hosting MongoDB Shared gratis dan SSL otomatis.
* [Northflank](https://northflank.com) — Bangun dan deploy microservices, job, dan database terkelola dengan UI, API & CLI yang kuat. Scale container dari version control dan Docker registry eksternal dengan mulus. Paket gratis mencakup dua layanan, dua cron job, dan 1 database.
* [YepCode](https://yepcode.io) - Platform all-in-one untuk menghubungkan API dan layanan di lingkungan serverless. Membawa semua kelincahan dan manfaat alat NoCode tetapi dengan kekuatan menggunakan bahasa pemrograman. Paket gratis mencakup [1.000 yep](https://yepcode.io/pricing/).
* [WunderGraph](https://cloud.wundergraph.com) - Platform open-source yang memungkinkan Anda membangun, merilis, dan mengelola API modern dengan cepat. CI/CD bawaan, integrasi GitHub, dan HTTPS otomatis. Hingga 3 proyek, 1GB egress, 300 menit build per bulan pada [paket gratis](https://wundergraph.com/pricing)
* [Zeabur](https://zeabur.com) - Deploy layanan Anda dengan satu klik. Gratis untuk tiga layanan, dengan kredit gratis US$ 5 per bulan.
* [mogenius](https://mogenius.com) - Mudah membangun, deploy, dan menjalankan layanan di Kubernetes. Paket gratis mendukung koneksi Kubernetes lokal dengan mogenius, memungkinkan developer individu membuat lingkungan uji seperti produksi di mesin mereka.
* [genezio](https://genezio.com/) - Penyedia fungsi serverless menawarkan 1 juta pemanggilan fungsi, 100GB bandwidth, dan 10 cron job per bulan gratis, khusus untuk penggunaan non-komersial atau akademik.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## BaaS

* [Activepieces](https://www.activepieces.com) - Bangun alur otomatisasi untuk menghubungkan beberapa aplikasi di backend aplikasi Anda. Misalnya, kirim pesan Slack atau tambahkan baris Google Sheet saat suatu event terjadi di aplikasi Anda. Gratis hingga 5.000 tugas per bulan.
* [back4app.com](https://www.back4app.com) - Back4App adalah backend yang mudah digunakan, fleksibel, dan skalabel berbasis Parse Platform.
* [backendless.com](https://backendless.com/) — Baas Mobile dan Web, dengan 1 GB penyimpanan file gratis, push notification 50.000/bulan, dan 1000 objek data dalam tabel.
* [bismuth.cloud](https://www.bismuth.cloud/) — AI kami akan bootstrap API Python Anda di runtime fungsi dan storage hosting kami, bangun dan host gratis di editor online kami atau secara lokal dengan alat favorit Anda.
* [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — BMC Developer Program menyediakan dokumentasi dan sumber daya untuk membangun dan deploy inovasi digital untuk perusahaan Anda. Akses ke sandbox pribadi yang komprehensif termasuk platform, SDK, dan pustaka komponen yang dapat digunakan untuk membangun dan menyesuaikan aplikasi.
* [connectycube.com](https://connectycube.com) - Pesan chat tanpa batas, panggilan suara & video p2p, lampiran file, dan push notification. Gratis untuk aplikasi hingga 1000 pengguna.
* [convex.dev](https://convex.dev/) - Backend reaktif sebagai layanan, menghosting data Anda (dokumen dengan relasi & transaksi ACID yang dapat diserialisasi), fungsi serverless, dan WebSocket untuk streaming update ke berbagai klien. Gratis untuk proyek kecil - hingga 1 juta record, 5 juta pemanggilan fungsi bulanan.
* [darklang.com](https://darklang.com/) - Bahasa yang dihosting dipadukan dengan editor dan infrastruktur. Dapat diakses selama beta, paket gratis yang murah hati direncanakan setelah beta.
* [Firebase](https://firebase.com) — Firebase membantu Anda membangun dan menjalankan aplikasi sukses. Paket Spark gratis menawarkan Authentication, Hosting, Firebase ML, Realtime Database, Cloud Storage, Testlab. A/B Testing, Analytics, App Distribution, App Indexing, Cloud Messaging (FCM), Crashlytics, Dynamic Links, In-App Messaging, Performance Monitoring, Predictions, dan Remote Config selalu gratis.
* [Flutter Flow](https://flutterflow.io) — Bangun UI Aplikasi Flutter tanpa menulis satu baris kode pun. Tersedia juga integrasi Firebase. Paket gratis mencakup akses penuh ke UI Builder dan template gratis.
* [getstream.io](https://getstream.io/) — Bangun Chat, Pesan, Video dan audio, serta Feeds In-App yang skalabel dalam hitungan jam, bukan minggu
* [hasura.io](https://hasura.io/) — Hasura memperluas database Anda di mana pun di-host dan menyediakan GraphQL API instan yang dapat diakses secara aman untuk web, mobile, dan kebutuhan integrasi data. Gratis untuk 1GB/bulan data pass-through.
* [nhost.io](https://nhost.io) - Backend serverless untuk aplikasi web dan mobile. Paket gratis mencakup PostgreSQL, GraphQL (Hasura), Authentication, Storage, dan Serverless Functions.
* [onesignal.com](https://onesignal.com/) — Push notification gratis tanpa batas. 10.000 email terkirim per bulan, dengan kontak tanpa batas dan akses ke Auto Warm Up.
* [paraio.com](https://paraio.com) — Backend service API dengan autentikasi fleksibel, pencarian full-text, dan caching. Gratis untuk satu aplikasi, 1GB data aplikasi.
  * [pubnub.com](https://www.pubnub.com/) — Notifikasi push gratis hingga 1 juta pesan/bulan dan 100 perangkat aktif harian
  * [pushbots.com](https://pushbots.com/) — Layanan notifikasi push. Gratis hingga 1,5 juta push/bulan
  * [pushcrew.com](https://pushcrew.com/) — Layanan notifikasi push. Notifikasi tak terbatas untuk hingga 2.000 pelanggan
  * [pusher.com](https://pusher.com/beams) — Notifikasi push gratis tak terbatas untuk 2000 pengguna aktif bulanan. Satu API untuk perangkat iOS dan Android.
  * [quickblox.com](https://quickblox.com/) — Backend komunikasi untuk pesan instan, panggilan video dan suara, serta notifikasi push
  * [restspace.io](https://restspace.io/) - Konfigurasikan server dengan layanan untuk otentikasi, data, file, API email, template, dan lainnya, lalu komposisikan ke dalam pipeline dan transformasi data.
  * [Salesforce Developer Program](https://developer.salesforce.com/signup) — Bangun aplikasi dengan sangat cepat menggunakan alat drag-and-drop. Kustomisasi model data Anda dengan klik. Kembangkan lebih lanjut dengan kode Apex. Integrasi dengan apa pun menggunakan API yang kuat. Tetap terlindungi dengan keamanan tingkat perusahaan. Kustomisasi antarmuka dengan klik atau framework web terbaru. Program Pengembang Gratis memberikan akses ke seluruh Lightning Platform.
  * [simperium.com](https://simperium.com/) — Pindahkan data ke mana saja secara instan dan otomatis, multi-platform, pengiriman dan penyimpanan data terstruktur tanpa batas, maks. 2.500 pengguna/bulan
  * [Supabase](https://supabase.com) — Alternatif Firebase Open Source untuk membangun backend. Paket Gratis menawarkan Otentikasi, Database Realtime & Penyimpanan Objek.
  * [tyk.io](https://tyk.io/) — Manajemen API dengan otentikasi, kuota, pemantauan dan analitik. Penawaran cloud gratis
  * [zapier.com](https://zapier.com/) — Hubungkan aplikasi yang Anda gunakan untuk mengotomatisasi tugas. Lima zap setiap 15 menit dan 100 tugas/bulan
  * [IFTTT](https://ifttt.com) — Otomatiskan aplikasi dan perangkat favorit Anda. Gratis 2 Applet
  * [Integrately](https://integrately.com) — Otomatiskan tugas-tugas membosankan dengan satu klik. Gratis 100 Tugas, Waktu Pembaruan 15 Menit, lima otomasi aktif, webhook.
  * [LeanCloud](https://leancloud.app/) — Backend untuk mobile. 1GB penyimpanan data, 256MB instance, 3K permintaan API/hari, dan 10K push/hari gratis. (API sangat mirip dengan Parse Platform)
  * [Claw.cloud](https://run.claw.cloud) - Platform PaaS yang menawarkan kredit gratis $5/bulan untuk pengguna dengan akun GitHub yang berumur lebih dari 180 hari. Sempurna untuk hosting aplikasi, database, dan lainnya. ([Tautan Daftar dengan kredit gratis](https://ap-southeast-1.run.claw.cloud/signin)).


**[⬆️ Kembali ke Atas](#table-of-contents)**

## Platform Low-code

  * [appsmith](https://www.appsmith.com/) — Proyek low code untuk membangun panel admin, alat internal, dan dashboard. Terintegrasi dengan 15+ database dan API apa pun.
  * [Basedash](https://www.basedash.com) — Platform low-code untuk membangun panel admin internal dan dashboard. Mendukung database SQL dan REST API.
  * [BudiBase](https://budibase.com/) — Budibase adalah platform low-code open-source untuk membuat aplikasi internal dalam hitungan menit. Mendukung PostgreSQL, MySQL, MSSQL, MongoDB, Rest API, Docker, K8s
  * [Clappia](https://www.clappia.com) — Platform low-code yang dirancang untuk membangun aplikasi proses bisnis dengan aplikasi mobile dan web yang dapat dikustomisasi. Menyediakan antarmuka drag-and-drop, fitur seperti Dukungan Offline, pelacakan lokasi real-time, dan integrasi dengan berbagai layanan pihak ketiga.
  * [DronaHQ](https://www.dronahq.com/) — DronaHQ - platform low code yang membantu tim engineering dan manajer produk membangun alat internal, perjalanan pengguna kustom, pengalaman digital, otomasi, panel admin kustom, aplikasi operasional 10X lebih cepat.
  * [lil'bots](https://www.lilbots.io/) - menulis dan menjalankan skrip online dengan API bawaan gratis seperti OpenAI, Anthropic, Firecrawl, dan lainnya. Cocok untuk membangun agen AI / alat internal dan berbagi dengan tim. Paket gratis mencakup akses penuh ke API, asisten coding AI, dan 10.000 kredit eksekusi / bulan.
  * [Mendix](https://www.mendix.com/) — Pengembangan Aplikasi Cepat untuk Enterprise, sandbox tanpa batas untuk jumlah pengguna, 0,5 GB penyimpanan dan 1 GB RAM per aplikasi. Studio dan Studio Pro IDE juga tersedia di paket gratis.
  * [outsystems.com](https://www.outsystems.com/) — PaaS pengembangan web enterprise untuk on-premise atau cloud, penawaran "personal environment" gratis memungkinkan kode tanpa batas dan hingga 1 GB database
  * [ReTool](https://retool.com/) — Platform low-code untuk membangun aplikasi internal. Retool sangat fleksibel. Jika Anda bisa menulisnya dengan JavaScript dan API, Anda bisa membuatnya di Retool. Paket gratis memungkinkan hingga lima pengguna per bulan, aplikasi dan koneksi API tak terbatas.
  * [Superblocks](https://superblocks.com/) — Platform aplikasi enterprise terbuka yang dirancang untuk pengembang dan tim semi-teknis. Gunakan AI untuk membuat, mengedit secara visual, dan memperluas dengan kode. Kelola secara terpusat dengan integrasi, otentikasi, izin & audit log.
  * [ToolJet](https://www.tooljet.com/) — Framework low-code yang dapat diperluas untuk membangun aplikasi bisnis. Terhubung ke database, cloud storage, GraphQL, endpoint API, Airtable, dll., dan bangun aplikasi menggunakan builder aplikasi drag-and-drop.
  * [UI Bakery](https://uibakery.io) — Platform low-code yang memungkinkan pembuatan aplikasi web kustom lebih cepat. Mendukung pembuatan UI dengan drag and drop serta kustomisasi tingkat tinggi lewat JavaScript, Python, dan SQL. Tersedia sebagai solusi cloud dan self-hosted. Gratis hingga 5 pengguna.
  * [manubes](https://www.manubes.com) - Platform cloud no-code yang kuat dengan fokus pada manajemen produksi industri. Gratis untuk satu pengguna dengan 1 juta aktivitas workflow per bulan ([tersedia juga dalam bahasa Jerman](https://www.manubes.de)).

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Web Hosting

  * [Alwaysdata](https://www.alwaysdata.com/) — 100 MB hosting web gratis dengan dukungan untuk MySQL, PostgreSQL, CouchDB, MongoDB, PHP, Python, Ruby, Node.js, Elixir, Java, Deno, server web kustom, akses via FTP, WebDAV dan SSH; kotak surat, milis dan pemasang aplikasi juga disertakan.
  * [Awardspace.com](https://www.awardspace.com) — Hosting web gratis + domain pendek gratis, PHP, MySQL, App Installer, Pengiriman Email & Tanpa Iklan.
  * [Bohr](https://bohr.io) — Gratis untuk proyek non-komersial + Platform Deployment dan Pengembangan Developer-First yang meminimalkan kerepotan infrastruktur dan mempercepat setup.
  * [Bubble](https://bubble.io/) — Pemrograman visual untuk membangun aplikasi web dan mobile tanpa kode, gratis dengan branding Bubble.
  * [dAppling Network](https://www.dappling.network/) - Platform hosting web terdesentralisasi untuk frontend Web3 dengan fokus pada peningkatan uptime dan keamanan serta menyediakan akses tambahan bagi pengguna.
  * [DigitalOcean](https://www.digitalocean.com/pricing) - Bangun dan deploy tiga situs statis secara gratis di App Platform Starter tier.
  * [Drive To Web](https://drv.tw) — Hosting langsung ke web dari Google Drive & OneDrive. Hanya situs statis. Gratis selamanya. Satu situs per akun Google/Microsoft.
  * [Fenix Web Server](https://preview.fenixwebserver.com) - Aplikasi desktop developer untuk hosting situs secara lokal dan berbagi secara publik (real-time). Bekerja sesuai keinginan Anda, menggunakan antarmuka pengguna yang indah, API, dan/atau CLI.
  * [Fern](https://buildwithfern.com) - Bangun dan hosting situs dokumentasi berbasis Markdown di paket gratis Fern. Anda bahkan dapat secara otomatis menghasilkan referensi API dari file definisi API. Situs di-host di _yoursite_.docs.buildwithfern.com.
  * [Free Hosting](https://freehostingnoads.net/) — Hosting Gratis dengan PHP 5, Perl, CGI, MySQL, FTP, File Manager, POP E-Mail, sub-domain gratis, hosting domain gratis, DNS Zone Editor, Statistik Situs Web, Dukungan Online GRATIS dan banyak fitur lain yang tidak ditawarkan host gratis lain.
  * [Freehostia](https://www.freehostia.com) — FreeHostia menawarkan layanan hosting gratis termasuk Control Panel terbaik di industri & instalasi 1-klik untuk 50+ aplikasi gratis. Setup instan. Tanpa iklan paksa.
  * [HelioHost](https://heliohost.org) — Hosting web gratis nirlaba dengan panel kontrol Plesk, PHP, Node.js, Python, Django, Flask, .NET, Perl, CGI, MySQL, PostgreSQL, SQLite, email IMAP/POP3/SMTP, bandwidth tak terbatas, subdomain gratis, penyimpanan 1000 MB gratis dengan opsi upgrade.
  * [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — Deploy hingga 100 situs statis secara gratis, domain kustom dengan SSL, 100 GB bandwidth bulanan, 260+ lokasi CDN Cloudflare.
  * [Lecturify](https://www.lecturify.net/index.en.html) - Hosting web dengan akses SFPT untuk upload dan download file, php tersedia.
  * [Neocities](https://neocities.org) — Statis, 1 GB penyimpanan gratis dengan 200 GB Bandwidth.
  * [Netlify](https://www.netlify.com/) — Membangun, deploy dan hosting situs/aplikasi statis gratis untuk 100 GB data dan 100 GB/bulan bandwidth.
  * [pantheon.io](https://pantheon.io/) — Hosting Drupal dan WordPress, DevOps otomatis, dan infrastruktur yang dapat diskalakan. Gratis untuk pengembang dan agensi. Tidak ada domain kustom.
  * [readthedocs.org](https://readthedocs.org/) — Hosting dokumentasi gratis dengan versi, pembuatan PDF, dan lainnya
  * [render.com](https://render.com) — Cloud terpadu untuk membangun dan menjalankan aplikasi dan situs dengan SSL gratis, CDN global, jaringan privat, auto-deploy dari Git, dan paket benar-benar gratis untuk layanan web, database, dan halaman web statis.
  * [SourceForge](https://sourceforge.net/) — Temukan, Buat, dan Publikasikan perangkat lunak Open Source secara gratis
  * [surge.sh](https://surge.sh/) — Publikasi web statis untuk pengembang Front-End. Situs tak terbatas dengan dukungan domain kustom
  * [telegra.ph](https://telegra.ph/) Mudah membuat halaman web menggunakan Quill
  * [tilda.cc](https://tilda.cc/) — Satu situs, 50 halaman, 50 MB penyimpanan, hanya blok utama dari 170+ yang tersedia, tanpa font, tanpa favicon, dan tanpa domain kustom
  * [Vercel](https://vercel.com/) — Bangun, deploy, dan hosting aplikasi web dengan SSL gratis, CDN global, dan URL Preview unik setiap kali Anda `git push`. Sempurna untuk Next.js dan Static Site Generator lainnya.
  * [Versoly](https://versoly.com/) — Website builder berfokus SaaS - situs tanpa batas, 70+ blok, lima template, CSS kustom, favicon, SEO, dan formulir. Tanpa domain kustom.
  * [Qoddi](https://qoddi.com) - Layanan PaaS mirip Heroku dengan pendekatan berfokus pada developer dan fitur all-in. Paket gratis untuk aset statis, staging, dan aplikasi developer.
  * [FreeFlarum](https://freeflarum.com/) - Hosting Flarum gratis berbasis komunitas untuk hingga 250 pengguna (donasi untuk menghapus watermark dari footer).
  * [MDB GO](https://mdbgo.com/) - Hosting gratis untuk satu proyek dengan Container TTL dua minggu, 500 MB RAM per proyek, SFTP - 1G disk.
  * [Patr Cloud](https://patr.cloud/) — Platform cloud yang mudah digunakan, di antara layanan berbayarnya menawarkan hosting tiga situs statis secara gratis.
  * [Serv00.com](https://serv00.com/) — 3 GB hosting web gratis dengan backup harian (7 hari). Dukungan: Crontab, akses SSH, repository (GIT, SVN, dan Mercurial), dukungan: MySQL, PostgreSQL, MongoDB, PHP, Node.js, Python, Ruby, Java, Perl, TCL/TK, Lua, Erlang, Rust, Pascal, C, C++, D, R, dan banyak lagi.
  - [Sevalla](https://sevalla.com/) - Platform hosting yang dirancang untuk memudahkan deployment dan manajemen aplikasi, database, dan website statis - batas 1GB per situs, 100GB bandwidth gratis, 600 menit build gratis, 100 situs per akun.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## DNS

  * [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - Resolver DNS publik gratis, cepat dan aman (enkripsi query DNS Anda), disediakan oleh Cloudflare. Berguna untuk melewati pemblokiran DNS oleh ISP Anda, mencegah penyadapan query DNS, dan [memblokir konten dewasa & malware](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families). Dapat juga digunakan [via API](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests). Catatan: Hanya resolver DNS, bukan hosting DNS.
  * [1984.is](https://www.1984.is/product/freedns/) — Layanan DNS gratis dengan API dan banyak fitur DNS gratis lainnya.
  * [cloudns.net](https://www.cloudns.net/) — Hosting DNS gratis hingga 1 domain dengan 50 record
  * [deSEC](https://desec.io) - Hosting DNS gratis dengan dukungan API, dirancang dengan keamanan sebagai prioritas. Berjalan dengan perangkat lunak open-source dan didukung oleh [SSE](https://www.securesystems.de/).
  * [dns.he.net](https://dns.he.net/) — Layanan hosting DNS gratis dengan dukungan Dynamic DNS
  * [Zonomi](https://zonomi.com/) — Layanan hosting DNS gratis dengan propagasi DNS instan. Paket gratis: 1 zona DNS (nama domain) dengan hingga 10 record DNS.
  * [dnspod.com](https://www.dnspod.com/) — Hosting DNS gratis.
  * [duckdns.org](https://www.duckdns.org/) — DDNS gratis hingga 5 domain di paket gratis. Tersedia panduan konfigurasi untuk berbagai setup.
  * [Dynv6.com](https://dynv6.com/) — Layanan DDNS gratis dengan [dukungan API](https://dynv6.com/docs/apis) dan pengelolaan berbagai tipe record dns (seperti CNAME, MX, SPF, SRV, TXT dan lainnya).
  * [freedns.afraid.org](https://freedns.afraid.org/) — Hosting DNS gratis. Juga menyediakan subdomain gratis berdasarkan banyak domain publik yang [disumbangkan pengguna](https://freedns.afraid.org/domain/registry/). Dapatkan subdomain gratis dari menu "Subdomains" setelah mendaftar.
  * [luadns.com](https://www.luadns.com/) — Hosting DNS gratis, tiga domain, semua fitur dengan batasan wajar
  * [namecheap.com](https://www.namecheap.com/domains/freedns/) — DNS gratis. Tidak ada batasan jumlah domain
  * [nextdns.io](https://nextdns.io) - Firewall berbasis DNS, 300K query gratis per bulan
  * [noip.at](https://noip.at/) — Layanan DDNS gratis tanpa pendaftaran, pelacakan, logging, atau iklan. Tidak ada batas domain.
  * [noip](https://www.noip.com/) — layanan DNS dinamis yang memungkinkan hingga 3 hostname gratis dengan konfirmasi setiap 30 hari
  * [sslip.io](https://sslip.io/) — Layanan DNS gratis yang jika di-query dengan hostname berisi alamat IP akan mengembalikan alamat IP tersebut.
  * [zilore.com](https://zilore.com/en/dns) — Hosting DNS gratis untuk 5 domain.
  * [zoneedit.com](https://www.zoneedit.com/free-dns/) — Hosting DNS gratis dengan dukungan Dynamic DNS.
  * [zonewatcher.com](https://zonewatcher.com) — Backup otomatis dan pemantauan perubahan DNS. Satu domain gratis
  * [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – Hosting DNS gratis oleh Huawei
  * [Hetzner](https://www.hetzner.com/dns-console) – Hosting DNS gratis dari Hetzner dengan dukungan API.
  * [Glauca](https://docs.glauca.digital/hexdns/) – Hosting DNS gratis untuk hingga 3 domain dan dukungan DNSSEC
  * [VolaryDDNS](https://volaryddns.net) - DDNS gratis berperforma tinggi tanpa langganan atau iklan
**[⬆️ Kembali ke Atas](#table-of-contents)**

## Domain

  * [pp.ua](https://nic.ua/) — Subdomain pp.ua gratis.
  * [us.kg](https://nic.us.kg/) - Subdomain us.kg gratis.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — Kompatibel dengan AWS S3 - API, operasi antarmuka, CLI, dan metode upload lainnya, upload dan simpan file dari jaringan IPFS dan Arweave dengan aman, nyaman, dan efisien. Pengguna terdaftar dapat memperoleh 6 GB penyimpanan IPFS dan 300MB penyimpanan Arweave secara gratis. Upload file Arweave yang lebih kecil dari 150 KB gratis.
  * [backblaze.com](https://www.backblaze.com/b2/) — Backblaze B2 cloud storage. 10 GB penyimpanan objek (mirip Amazon S3) gratis untuk waktu tak terbatas
  * [filebase.com](https://filebase.com/) - Penyimpanan Objek Kompatibel S3 yang Didukung Blockchain. 5 GB penyimpanan gratis tanpa batas waktu.
  * [Tebi](https://tebi.io/) - Penyimpanan objek kompatibel S3. 25 GB penyimpanan gratis dan 250GB transfer keluar.
  * [Idrive e2](https://www.idrive.com/e2/) - Penyimpanan objek kompatibel S3. 10 GB penyimpanan gratis dan 10 GB bandwidth unduhan per bulan.
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - Penyimpanan objek kompatibel S3. 15 GB penyimpanan gratis dan 15 GB unduhan per bulan.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Managed Data Services

  * [Aiven](https://aiven.io/) - Aiven menawarkan PostgreSQL, MySQL, dan Redis gratis di platform data open-source mereka. Single node, 1 CPU, 1GB RAM, dan untuk PostgreSQL dan MySQL, 5GB penyimpanan. Migrasi mudah ke paket lebih besar atau antar cloud.
  * [airtable.com](https://airtable.com/) — Tampil seperti spreadsheet, tapi merupakan database relasional, basis tak terbatas, 1.200 baris/basis, dan 1.000 permintaan API/bulan
  * [Astra](https://www.datastax.com/products/datastax-astra/) — Cassandra Cloud Native as a Service dengan [80GB free tier](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — Layanan API/backend serverless JavaScript dan database NoSQL yang mudah digunakan dengan fungsi, query mirip MongoDB, lookup key/value, sistem job, pesan realtime, antrean pekerja, CLI yang kuat, dan manajer data berbasis web. Paket gratis mendapat 5GB penyimpanan dan 60/panggilan API per menit. Termasuk 2 pengembang. Tidak perlu kartu kredit.
  * [CrateDB](https://crate.io/) - Database SQL Open Source Terdistribusi untuk analitik real-time. [Free Tier CRFREE](https://crate.io/lp-crfree): Satu node dengan 2 CPU, 2 GiB memori, 8 GiB penyimpanan. Satu klaster per organisasi, tanpa metode pembayaran.
  * [Upstash](https://upstash.com/) — Serverless Redis dengan paket gratis hingga 10.000 permintaan per hari, ukuran database maks 256MB, dan 20 koneksi bersamaan
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - deploy cluster database terkelola sepenuhnya gratis selamanya untuk pengembang, cocok untuk aplikasi generasi berikutnya mulai dari IoT hingga AI
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — paket gratis menyediakan 512 MB
  * [redsmin.com](https://www.redsmin.com/) — Layanan monitoring dan administrasi Redis online real-time, Monitoring gratis untuk 1 instance Redis
  * [redislabs](https://redislabs.com/try-free/) - 30MB instance redis gratis
  * [MemCachier](https://www.memcachier.com/) — Layanan Memcache terkelola. Gratis hingga 25MB, 1 Proxy Server, dan analitik dasar
  * [scalingo.com](https://scalingo.com/) — Utamanya PaaS tapi menawarkan paket gratis 128MB hingga 192MB untuk MySQL, PostgreSQL, atau MongoDB
  * [SeaTable](https://seatable.io/) — Database fleksibel mirip spreadsheet yang dikembangkan tim Seafile. tabel tak terbatas, 2.000 baris, versioning 1 bulan, hingga 25 anggota tim.
  * [skyvia.com](https://skyvia.com/) — Cloud Data Platform menawarkan paket gratis dan semua paket gratis sepenuhnya saat masih beta
  * [StackBy](https://stackby.com/) — Satu alat yang menggabungkan fleksibilitas spreadsheet, kekuatan database, dan integrasi dengan aplikasi bisnis favorit Anda. Paket gratis termasuk pengguna tak terbatas, sepuluh stack, dan lampiran 2GB per stack.
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB adalah RDBMS HTAP terdistribusi open-source yang kompatibel MySQL. TiDB Serverless menyediakan 5GB penyimpanan baris, 5GB penyimpanan kolom, dan 50 juta Request Units (RUs) gratis setiap bulan.
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso adalah pengalaman SQLite untuk pengembang dalam database Edge. Turso menyediakan Free Forever starter plan, total 9 GB penyimpanan, Hingga 500 database, Hingga 3 lokasi, 1 miliar pembacaan baris per bulan, dan dukungan pengembangan lokal dengan SQLite.
  * [InfluxDB](https://www.influxdata.com/) — Database timeseries, gratis hingga 3MB/5 menit penulisan, 30MB/5 menit pembacaan dan 10.000 series cardinalities
  * [restdb.io](https://restdb.io/) - layanan database NoSQL cloud yang cepat dan sederhana. Dengan restdb.io Anda mendapatkan skema, relasi, REST API otomatis (dengan query mirip MongoDB), dan UI admin multi-user yang efisien untuk bekerja dengan data. Paket gratis mengizinkan 3 pengguna, 2500 record, dan 1 permintaan API per detik.
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — Paket gratis menawarkan 50 juta RUs dan 10 GiB penyimpanan (setara $15) gratis per bulan. ([Apa itu Request Units](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — DBMS Graph native terkelola / platform analitik dengan bahasa query Cypher dan REST API. Batas ukuran graf (50k node, 175k relasi).
  * [Neon](https://neon.tech/) — PostgreSQL terkelola, 0.5 GB penyimpanan (total), 1 Proyek, 10 branch, Database tak terbatas, primary branch selalu tersedia (Auto suspend setelah 5 menit), 20 jam waktu aktif per bulan (total) untuk compute branch non-primary.
  * [Prisma Postgres](https://prisma.io/postgres) - Postgres super cepat yang di-host, dibangun di atas unikernel dan dijalankan di bare metal, 1GB penyimpanan, 10 database, terintegrasi dengan Prisma ORM.
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — DBMS Graph native terkelola dengan GraphQL API. Terbatas 1 MB transfer data per hari.
  * [Tinybird](https://tinybird.co) - ClickHouse terkelola serverless dengan ingest data tanpa koneksi melalui HTTP dan memungkinkan Anda mempublikasikan query SQL sebagai HTTP API terkelola. Tidak ada batas waktu pada free-tier, 10GB penyimpanan + 1000 permintaan API per hari.
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — DBMS Graph native terkelola / platform analitik dengan bahasa query graph mirip SQL dan REST API. Satu instance gratis dengan dua vCPU, 8GB Memori, dan 50GB penyimpanan yang tidur setelah 1 jam tidak aktif.
  * [TerminusCMS](https://terminusdb.com/pricing) — Layanan gratis terkelola untuk TerminusDB, database dokumen dan graph yang ditulis dengan Prolog dan Rust. Gratis untuk dev, berbayar untuk enterprise dan dukungan.
  * [filess.io](https://filess.io) - filess.io adalah platform di mana Anda dapat membuat dua database dengan maksimal 10 MB per database dari DBMS berikut secara gratis: MySQL, MariaDB, MongoDB, dan PostgreSQL.
  * [xata.io](https://xata.io) - Xata adalah database serverless dengan pencarian dan analitik bawaan yang kuat. Satu API, banyak library client type-safe, dan dioptimalkan untuk workflow pengembangan Anda. Free-forever tier cukup untuk pengembang hobi yang mendapat tiga unit Xata, lihat website untuk definisi unit.
  * [8base.com](https://www.8base.com/) - 8base adalah platform pengembangan low-code full-stack untuk developer JavaScript yang dibangun di atas MySQL dan GraphQL serta backend serverless. Memungkinkan Anda membangun aplikasi web dengan cepat menggunakan builder UI dan skalabilitas cepat, Paket Gratis meliputi 2.500 baris, 500 penyimpanan, 1Gb/h komputasi serverless, dan 5 pengguna aplikasi client.
  * [Nile](https://www.thenile.dev/) — Platform Postgres untuk aplikasi B2B. Database tak terbatas, Selalu tersedia tanpa shutdown, 1GB penyimpanan (total), 50 juta query token, autoscaling, embeddings vektor tak terbatas



**[⬆️ Kembali ke Atas](#table-of-contents)**

## Tunneling, WebRTC, Web Socket Servers dan Router Lainnya

  * [Pinggy](https://pinggy.io) — URL publik untuk localhost dengan satu perintah, tanpa perlu download. HTTPS / TCP / TLS tunnels. Paket gratis memiliki masa hidup tunnel 60 menit.
  * [conveyor.cloud](https://conveyor.cloud/) — Ekstensi Visual Studio untuk mengekspos IIS Express ke jaringan lokal atau melalui tunnel ke URL publik.
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi adalah layanan VPN hosted yang memungkinkan Anda memperluas jaringan mirip LAN secara aman ke tim terdistribusi dengan paket gratis yang mengizinkan jaringan tak terbatas hingga 5 orang
  * [Mirna Sockets](https://mirna.cloud/) - Platform Socket as a Service gratis yang memberi Anda URL wss:// saat deploy kode Server Web Socket Anda dan memungkinkan Anda memonitor performanya.
  * [localhost.run](https://localhost.run/) — Mengekspos server lokal melalui tunnel ke URL publik.
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — Mengekspos server lokal melalui tunnel ke URL publik. Versi hosted gratis, dan [open source](https://github.com/localtunnel/localtunnel).
  * [ngrok.com](https://ngrok.com/) — Mengekspos server lokal melalui tunnel ke URL publik.
  * [cname.dev](https://cname.dev/) — Layanan reverse proxy dinamis yang gratis dan aman.
  * [serveo](https://serveo.net/) — Mengekspos server lokal ke internet. Tanpa instalasi, tanpa pendaftaran. Subdomain gratis, tanpa batasan.
  * [Radmin VPN](https://www.radmin-vpn.com/) — Menghubungkan banyak komputer melalui VPN sehingga membentuk jaringan mirip LAN. Peer tak terbatas. (Alternatif Hamachi)
  * [segment.com](https://segment.com/) — Hub untuk menerjemahkan dan merutekan event ke layanan pihak ketiga lain. 100.000 event/bulan gratis
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — VPN tanpa konfigurasi, menggunakan protokol open-source WireGuard. Bisa diinstal di MacOS, iOS, Windows, Linux, dan Android. Paket gratis untuk penggunaan pribadi hingga 100 perangkat dan tiga pengguna.
  * [webhookrelay.com](https://webhookrelay.com) — Mengelola, debug, fan-out, dan proxy semua webhook Anda ke destinasi publik atau internal (misal: localhost). Juga bisa mengekspos server di jaringan privat melalui tunnel dengan mendapatkan endpoint HTTP publik (`https://yoursubdomain.webrelay.io <----> http://localhost:8080`).
  * [Hookdeck](https://hookdeck.com/pricing) — Kembangkan, uji, dan monitor webhook Anda dari mana saja. 100K permintaan dan 100K attempt per bulan dengan retensi tiga hari.
  * [Xirsys](https://www.xirsys.com/pricing/) — Penggunaan STUN tak terbatas + 500 MB bandwidth TURN bulanan, bandwidth terbatas, wilayah geografis tunggal.
  * [ZeroTier](https://www.zerotier.com) — FOSS managed virtual Ethernet as a service. Jaringan terenkripsi end-to-end hingga 25 klien pada paket gratis. Klien untuk desktop/mobile/NA; antarmuka web untuk konfigurasi routing kustom dan persetujuan node klien baru di jaringan privat
  * [LocalXpose](https://localxpose.io) — Reverse proxy yang memungkinkan Anda mengekspos server localhost ke internet. Paket gratis memiliki masa hidup tunnel 15 menit.
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - Publikasikan layanan lokal melalui tunnel ke URL kustom publik dan amankan dengan kontrol akses. Gratis untuk 5 layanan dalam satu cluster.
  * [Expose](https://expose.dev/) - Ekspos situs lokal melalui tunnel aman. Paket gratis meliputi Server Eropa, subdomain acak, dan pengguna tunggal.
  * [btunnel](https://www.btunnel.in/) — Mengekspos localhost dan server tcp lokal ke internet. Paket gratis meliputi file server, custom http request dan response headers, proteksi auth dasar dan timeout tunnel 1 jam.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Issue Tracking dan Project Management

  * [acunote.com](https://www.acunote.com/) — Software manajemen proyek dan SCRUM gratis untuk hingga 5 anggota tim
  * [asana.com](https://asana.com/) — Gratis untuk proyek privat dengan kolaborator
  * [Backlog](https://backlog.com) — Semua kebutuhan tim Anda untuk merilis proyek hebat dalam satu platform. Paket gratis menawarkan 1 Proyek dengan sepuluh pengguna & 100MB penyimpanan.
  * [Basecamp](https://basecamp.com/personal) - Daftar to-do, manajemen milestone, pesan seperti forum, berbagi file, dan pelacakan waktu. Hingga 3 proyek, 20 pengguna, dan 1GB ruang penyimpanan.
  * [bitrix24.com](https://www.bitrix24.com/) — Alat intranet dan manajemen proyek. Paket gratis memiliki 5GB untuk pengguna tak terbatas.
  * [cacoo.com](https://cacoo.com/) — Diagram online real-time: flowchart, UML, network. Gratis maksimal 15 pengguna/diagram, 25 lembar
  * [Chpokify](https://chpokify.com/) — Planning Poker berbasis tim yang menghemat waktu estimasi sprint. Gratis hingga 5 pengguna, integrasi Jira gratis, panggilan video tak terbatas, tim tak terbatas, sesi tak terbatas.
  * [clickup.com](https://clickup.com/) — Manajemen proyek. Gratis, versi premium dengan cloud storage. Aplikasi mobile dan integrasi Git tersedia.
  * [Clockify](https://clockify.me) - Aplikasi pelacak waktu dan timesheet untuk melacak jam kerja di berbagai proyek. Pengguna tak terbatas, gratis selamanya.
  * [Cloudcraft](https://cloudcraft.co/) — Buat diagram arsitektur profesional dalam hitungan menit dengan desainer visual Cloudcraft, dioptimalkan untuk AWS dengan komponen cerdas yang menampilkan data live juga. Paket gratis memiliki diagram privat tak terbatas untuk satu pengguna.
  * [Codegiant](https://codegiant.io) — Project Management dengan hosting repositori & CI/CD. Paket Gratis Menyediakan Repositori, Proyek & Dokumen Tak Terbatas dengan 5 Anggota Tim. 500 menit CI/CD per bulan. 30000 menit Serverless Code Run per bulan 1GB penyimpanan repositori.
  * [Confluence](https://www.atlassian.com/software/confluence) - Alat kolaborasi konten dari Atlassian yang digunakan untuk membantu tim berkolaborasi dan berbagi pengetahuan secara efisien. Paket gratis untuk hingga 10 pengguna.
  * [contriber.com](https://www.contriber.com/) — Platform manajemen proyek yang dapat dikustomisasi, paket starter gratis, lima workspace
* [Crosswork](https://crosswork.app/) - Platform manajemen proyek serbaguna. Gratis untuk hingga 3 proyek, pengguna tak terbatas, penyimpanan 1 GB.
* [diagrams.net](https://app.diagrams.net/) — Diagram online yang disimpan secara lokal di Google Drive, OneDrive, atau Dropbox. Gratis untuk semua fitur dan tingkat penyimpanan.
* [freedcamp.com](https://freedcamp.com/) - tugas, diskusi, milestone, pelacakan waktu, kalender, file, dan manajer kata sandi. Paket gratis dengan proyek, pengguna, dan penyimpanan file tak terbatas.
* [easyretro.io](https://www.easyretro.io/) — Alat retrospektif sprint yang sederhana dan intuitif. Paket gratis memiliki tiga papan publik dan satu survei per papan per bulan.
* [GForge](https://gforge.com) — Alat manajemen proyek dan pelacakan isu untuk proyek kompleks dengan opsi self-premises dan SaaS. Paket gratis SaaS menawarkan lima pengguna pertama gratis & gratis untuk Proyek Open Source.
* [gleek.io](https://www.gleek.io) — Alat deskripsi-ke-diagram gratis untuk developer. Buat diagram UML class, objek, atau entity-relationship informal menggunakan kata kunci Anda.
* [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - GraphQL Inspector menghasilkan daftar perubahan antara dua skema GraphQL. Setiap perbedaan dijelaskan secara rinci dan ditandai sebagai breaking, non-breaking, atau dangerous.
* [huboard.com](https://huboard.com/) — Manajemen proyek instan untuk isu GitHub Anda, gratis untuk Open Source
* [Hygger](https://hygger.io) — Platform manajemen proyek. Paket gratis menawarkan pengguna, proyek & papan tak terbatas dengan 100 MB penyimpanan.
* [Instabug](https://instabug.com) — SDK pelaporan bug dan feedback in-app yang komprehensif untuk aplikasi mobile. Paket gratis hingga 1 aplikasi dan satu anggota.
* [WishKit](https://wishkit.io) — Kumpulkan feedback pengguna in-app untuk aplikasi iOS/macOS Anda dan prioritaskan fitur berdasarkan voting pengguna. Paket gratis hingga 1 aplikasi.
* [Ilograph](https://www.ilograph.com/)  — Diagram interaktif yang memungkinkan pengguna melihat infrastruktur dari berbagai perspektif dan tingkat detail. Chart dapat diekspresikan dalam kode. Paket gratis memiliki diagram privat tak terbatas dengan maksimal 3 penonton.
* [Jira](https://www.atlassian.com/software/jira) — Alat manajemen proyek pengembangan perangkat lunak tingkat lanjut yang digunakan di banyak lingkungan korporat. Paket gratis untuk hingga 10 pengguna.
* [kanbanflow.com](https://kanbanflow.com/) — Manajemen proyek berbasis papan. Gratis, versi premium dengan lebih banyak opsi.
* [kanbantool.com](https://kanbantool.com/) — Manajemen proyek berbasis papan Kanban. Paket gratis memiliki dua papan dan dua pengguna, tanpa lampiran atau file.
* [kan.bn](https://kan.bn/) - Aplikasi kanban yang kuat dan fleksibel yang membantu Anda mengatur pekerjaan, melacak kemajuan, dan memberikan hasil—semua di satu tempat. Paket gratis hingga 1 pengguna untuk papan, daftar, dan kartu tak terbatas.
* [Kitemaker.co](https://kitemaker.co) - Kolaborasi melalui semua fase proses pengembangan produk dan pelacakan pekerjaan di Slack, Discord, Figma, dan Github. Pengguna tak terbatas, ruang tak terbatas. Paket gratis hingga 250 item kerja.
* [Kiter.app](https://www.kiter.app/) - Siapa pun dapat mengatur pencarian kerja dan melacak wawancara, peluang, dan koneksi. Web app dan ekstensi Chrome yang kuat. Sepenuhnya gratis.
* [Kumu.io](https://kumu.io/)  — Relationship maps dengan animasi, dekorasi, filter, clustering, impor spreadsheet, dll. Paket gratis memungkinkan proyek publik tak terbatas. Ukuran grafik tak terbatas. Proyek privat gratis untuk pelajar. Mode sandbox tersedia jika Anda tidak ingin file Anda online secara publik (unggah, edit, unduh, buang).
* [Linear](https://linear.app/) — Pelacak isu dengan antarmuka yang ramping. Gratis untuk anggota tak terbatas, unggah file hingga 10MB, 250 isu (tidak termasuk Archive).
* [leiga.com](https://www.leiga.com/) — Leiga adalah produk SaaS yang menggunakan AI untuk mengelola proyek Anda secara otomatis, membantu tim Anda tetap fokus dan melepaskan potensi besar, memastikan proyek berjalan sesuai rencana. Gratis untuk hingga 10 pengguna, 20 custom field, 2GB ruang penyimpanan, Perekaman Video dengan AI terbatas 5 menit/video, Automation Runs 20/pengguna/bulan.
* [Lucidchart](https://www.lucidchart.com/) - Alat diagram online dengan fitur kolaborasi. Paket gratis dengan tiga dokumen yang dapat diedit, 100 template profesional, dan fitur kolaborasi dasar.
* [MeisterTask](https://www.meistertask.com/) — Manajemen tugas online untuk tim. Gratis hingga 3 proyek dan anggota proyek tak terbatas.
* [MeuScrum](https://www.meuscrum.com/en) - Alat scrum online gratis dengan papan kanban
* [nTask](https://www.ntaskmanager.com/) — Perangkat lunak manajemen proyek yang memungkinkan tim Anda berkolaborasi, merencanakan, menganalisis, dan mengelola tugas sehari-hari. Paket essential gratis selamanya dengan 100 MB penyimpanan dan lima pengguna/tim. Workspace, meeting, tugas, timesheet, dan pelacakan isu tak terbatas.
* [Ora](https://ora.pm/) - Manajemen tugas agile & kolaborasi tim. Gratis untuk hingga 3 pengguna dan file dibatasi hingga 10 MB.
* [pivotaltracker.com](https://www.pivotaltracker.com/) — Gratis untuk proyek publik tak terbatas dan dua proyek privat dengan tiga pengguna aktif (baca-tulis) dan pengguna pasif tak terbatas (hanya baca).
* [plan.io](https://plan.io/) — Manajemen Proyek dengan Hosting Repository dan opsi lainnya. Gratis untuk dua pengguna dengan sepuluh pelanggan dan 500MB penyimpanan.
* [Plane](https://plane.so/) - Plane adalah alat manajemen proyek dan produk open-source yang sederhana dan dapat diperluas. Gratis untuk anggota tak terbatas, unggah file hingga 5MB, 1000 isu.
* [planitpoker.com](https://www.planitpoker.com/) — Planning poker online gratis (alat estimasi)
* [point.poker](https://www.point.poker/) - Online Planning Poker (alat estimasi berbasis konsensus). Gratis untuk pengguna, tim, sesi, ronde, dan voting tak terbatas. Tidak perlu registrasi.
* [ScrumFast](https://www.scrumfast.com) - Papan Scrum dengan antarmuka yang sangat intuitif, gratis hingga 5 pengguna.
* [Shake](https://www.shakebugs.com/) - Alat pelaporan bug dan feedback in-app untuk aplikasi mobile. Paket gratis, sepuluh laporan bug per aplikasi/bulan.
* [Shortcut](https://shortcut.com/) - Platform manajemen proyek. Gratis untuk hingga 10 pengguna selamanya.
* [Tadum](https://tadum.app) - Aplikasi agenda rapat dan notulen yang dirancang untuk rapat berulang, gratis untuk tim hingga 10 orang.
* [taiga.io](https://taiga.io/) — Platform manajemen proyek untuk startup dan developer agile, gratis untuk Open Source
* [Tara AI](https://tara.ai/) — Layanan manajemen sprint yang sederhana. Paket gratis memiliki tugas, sprint, dan workspace tak terbatas tanpa batasan pengguna.
* [targetprocess.com](https://www.targetprocess.com/) — Manajemen proyek visual, dari Kanban dan Scrum hingga hampir semua proses operasional. Gratis untuk pengguna tak terbatas, hingga 1.000 entitas data {[detail lebih lanjut](https://www.targetprocess.com/pricing/)}
* [taskade.com](https://www.taskade.com/) — Daftar tugas kolaboratif real-time dan outline tim. Paket gratis memiliki satu workspace dengan tugas dan proyek tak terbatas; penyimpanan file 1GB; riwayat proyek 1 minggu; dan lima peserta per rapat video.
* [taskulu.com](https://taskulu.com/) — Manajemen proyek berbasis peran. Gratis hingga 5 pengguna. Integrasi dengan GitHub/Trello/Dropbox/Google Drive
* [Teaminal](https://www.teaminal.com) - Alat standup, retro, dan perencanaan sprint untuk tim remote. Gratis hingga 15 pengguna.
* [teamwork.com](https://teamwork.com/) — Manajemen proyek & Team Chat. Gratis untuk lima pengguna dan dua proyek. Paket premium tersedia.
* [teleretro.com](https://www.teleretro.com/) — Alat retrospektif yang sederhana dan menyenangkan dengan icebreaker, gif, dan emoji. Paket gratis termasuk tiga retro dan anggota tak terbatas.
* [testlio.com](https://testlio.com/) — Pelacakan isu, manajemen pengujian, dan platform beta testing. Gratis untuk penggunaan privat
* [terrastruct.com](https://terrastruct.com/) — Pembuat diagram online khusus untuk arsitektur perangkat lunak. Paket gratis hingga 4 layer per diagram.
* [todoist.com](https://todoist.com/) — Manajemen tugas kolaboratif dan individu. Paket gratis: 5 proyek aktif, lima pengguna per proyek, unggah file hingga 5MB, tiga filter, dan riwayat aktivitas satu minggu.
* [trello.com](https://trello.com/) — Manajemen proyek berbasis papan. Personal Board tak terbatas, 10 Team Board.
* [Tweek](https://tweek.so/) — Kalender To-Do Mingguan & Manajemen Tugas yang sederhana.
* [ubertesters.com](https://ubertesters.com/) — Platform pengujian, integrasi dan crowd testers, 2 proyek, lima anggota
* [Wikifactory](https://wikifactory.com/) — Layanan desain produk dengan Proyek, VCS & Isu. Paket gratis menawarkan proyek & kolaborator tak terbatas dan 3GB penyimpanan.
* [Yodiz](https://www.yodiz.com/) — Pengembangan agile dan pelacakan isu. Gratis hingga 3 pengguna, proyek tak terbatas.
* [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — YouTrack (InCloud) terhosting gratis untuk proyek FOSS dan proyek privat (gratis untuk tiga pengguna). Termasuk pelacakan waktu dan papan agile.
* [zenhub.com](https://www.zenhub.com) — Satu-satunya solusi manajemen proyek di dalam GitHub. Gratis untuk repo publik, OSS, dan organisasi nirlaba.
* [zenkit.com](https://zenkit.com) — Alat manajemen proyek dan kolaborasi. Gratis untuk hingga 5 anggota, 5 GB lampiran.
* [Zube](https://zube.io) — Manajemen proyek dengan paket gratis untuk 4 Proyek & 4 pengguna. Integrasi GitHub tersedia.
* [Toggl](https://toggl.com/) — Menyediakan dua alat produktivitas gratis. [Toggl Track](https://toggl.com/track/) untuk manajemen waktu dan pelacakan dengan paket gratis yang menawarkan pelacakan waktu dan pelaporan tanpa batas, dirancang untuk freelancer. Memiliki catatan pelacakan, proyek, klien, tag, pelaporan, dan lainnya tanpa batas. Dan [Toggl Plan](https://toggl.com/plan/) untuk perencanaan tugas dengan paket gratis bagi developer solo dengan tugas, milestone, dan timeline tak terbatas.
* [Sflow](https://sflow.io) — sflow.io adalah alat manajemen proyek untuk pengembangan perangkat lunak agile, pemasaran, penjualan, dan dukungan pelanggan, terutama untuk proyek outsourcing dan kolaborasi antar organisasi. Paket gratis hingga 3 proyek dan lima anggota.
* [Pulse.red](https://pulse.red) — Aplikasi pelacak waktu dan timesheet minimalis gratis untuk proyek.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Penyimpanan dan Pemrosesan Media

* [AndroidFileHost](https://androidfilehost.com/) - Platform berbagi file gratis dengan kecepatan, bandwidth, jumlah file, jumlah unduhan tak terbatas, dll. Utamanya ditujukan untuk file terkait pengembangan Android seperti build APK, custom ROM & modifikasi, dll. Namun tampaknya menerima file lain juga.
* [borgbase.com](https://www.borgbase.com/) — Hosting backup offsite yang sederhana dan aman untuk Borg Backup. 10 GB ruang backup gratis dan dua repository.
* [icedrive.net](https://www.icedrive.net/) - Layanan penyimpanan cloud sederhana. 10 GB penyimpanan gratis.
* [sync.com](https://www.sync.com/) - Layanan penyimpanan cloud End-to-End. 5 GB penyimpanan gratis.
* [pcloud.com](https://www.pcloud.com/) - Layanan penyimpanan cloud. Hingga 10 GB penyimpanan gratis.
* [sirv.com](https://sirv.com/) — Smart Image CDN dengan optimasi dan resizing gambar secara langsung. Paket gratis mencakup 500 MB penyimpanan dan 2 GB bandwidth.
* [cloudimage.io](https://www.cloudimage.io/en/home) — Layanan optimasi gambar penuh dan CDN dengan 1500+ Point of Presence di seluruh dunia. Berbagai fungsi resize, kompresi, dan watermark gambar. Plugin open source untuk gambar responsif, pembuatan gambar 360, dan pengeditan gambar. Paket bulanan gratis dengan 25GB traffic CDN, 25GB cache storage, dan transformasi tanpa batas.
* [cloudinary.com](https://cloudinary.com/) — Upload gambar, manipulasi canggih, penyimpanan, dan delivery untuk situs & aplikasi, dengan library Ruby, Python, Java, PHP, Objective-C, dan lainnya. Paket gratis mencakup 25 kredit bulanan. Satu kredit setara 1.000 transformasi gambar, 1 GB penyimpanan, atau 1 GB penggunaan CDN.
* [embed.ly](https://embed.ly/) — Menyediakan API untuk embed media di webpage, scaling gambar responsif, dan ekstraksi elemen dari webpage. Gratis untuk hingga 5.000 URL/bulan dengan 15 permintaan/detik.
* [filestack.com](https://www.filestack.com/) — File picker, transform, dan delivery, gratis untuk 250 file, 500 transformasi, dan 3 GB bandwidth.
* [file.io](https://www.file.io) - 2 GB penyimpanan file. File akan otomatis dihapus setelah satu kali download. REST API untuk interaksi dengan penyimpanan. Batas satu permintaan/menit.
* [freetools.site](https://freetools.site/) — Alat online gratis. Konversi atau edit dokumen, gambar, audio, video, dan lainnya.
* [GoFile.io](https://gofile.io/) - Platform berbagi dan penyimpanan file gratis yang dapat digunakan melalui UI web & juga API. Ukuran file, bandwidth, jumlah unduhan, dll tak terbatas. Namun akan dihapus jika file tidak aktif (tidak diunduh lebih dari sepuluh hari).
* [gumlet.com](https://www.gumlet.com/) — Hosting, pemrosesan, dan streaming gambar dan video via CDN. Menyediakan paket gratis besar yaitu 250 GB / bulan untuk video dan 30 GB / bulan untuk gambar.
* [image-charts.com](https://www.image-charts.com/) — Pembuatan chart gambar tak terbatas dengan watermark.
* [Imgbot](https://github.com/marketplace/imgbot) — Imgbot adalah robot ramah yang mengoptimalkan gambar Anda dan menghemat waktu. Gambar yang dioptimalkan berarti ukuran file lebih kecil tanpa mengorbankan kualitas. Gratis untuk open source.
* [ImgBB](https://imgbb.com/) — ImgBB adalah layanan hosting gambar tanpa batas. Drag & drop gambar Anda di mana saja di layar. Batas 32 MB/gambar. Dapatkan tautan langsung gambar, BBCode, dan thumbnail HTML setelah mengunggah. Login untuk melihat riwayat upload.
* [imgen](https://www.jitbit.com/imgen/) - API pembuatan gambar cover sosial gratis tak terbatas, tanpa watermark.
* [imgix](https://www.imgix.com/) - Caching gambar, manajemen dan CDN. Paket gratis termasuk 1000 gambar origin, transformasi tak terbatas, dan 100 GB bandwidth.
* [kraken.io](https://kraken.io/) — Optimasi gambar untuk performa situs sebagai layanan, paket gratis hingga 1 MB per file.
* [kvstore.io](https://www.kvstore.io/) — Layanan penyimpanan key-value. Paket gratis memungkinkan 100 key, 1KB/key, 100 panggilan/jam.
* [npoint.io](https://www.npoint.io/) — JSON store dengan collaborative schema editing.
* [nitropack.io](https://nitropack.io/) - Mempercepat kecepatan situs Anda secara otomatis dengan optimasi front-end lengkap (caching, gambar dan optimasi kode, CDN). Gratis hingga 5.000 pageview/bulan.
* [otixo.com](https://www.otixo.com/) — Enkripsi, berbagi, salin, dan pindahkan semua file cloud storage dari satu tempat. Paket dasar menyediakan transfer file tak terbatas dengan ukuran file maksimal 250 MB dan lima file terenkripsi.
* [packagecloud.io](https://packagecloud.io/) — Hosted Package Repository untuk YUM, APT, RubyGem, dan PyPI. Paket gratis terbatas dan paket open-source tersedia via request.
* [getpantry.cloud](https://getpantry.cloud/) — API penyimpanan data JSON sederhana yang sempurna untuk proyek pribadi, hackathon, dan aplikasi mobile!
* [Pinata IPFS](https://pinata.cloud) — Pinata adalah cara termudah untuk mengunggah dan mengelola file di IPFS. Antarmuka pengguna dan API IPFS yang ramah membuat Pinata jadi layanan pinning IPFS termudah untuk platform, kreator, dan kolektor. 1 GB penyimpanan gratis, serta akses ke API.
* [placekitten.com](https://placekitten.com/) — Layanan cepat dan sederhana untuk mendapatkan gambar kucing sebagai placeholder.
* [plot.ly](https://plot.ly/) — Grafik dan bagikan data Anda. Paket gratis mencakup file publik tak terbatas dan sepuluh file privat.
* [podio.com](https://podio.com/) — Anda dapat menggunakan Podio dengan tim hingga lima orang dan mencoba fitur Basic Plan, kecuali manajemen pengguna.
* [QRME.SH](https://qrme.sh) - Generator QR code massal yang cepat dan indah – tanpa login, tanpa watermark, tanpa iklan. Hingga 100 URL per ekspor massal.
* [QuickChart](https://quickchart.io) — Membuat chart gambar, grafik, dan QR code yang dapat disematkan.
* [redbooth.com](https://redbooth.com) — P2P file syncing, gratis untuk hingga 2 pengguna.
* [resmush.it](https://resmush.it) — reSmush.it adalah API GRATIS yang menyediakan optimasi gambar. reSmush.it telah diimplementasikan pada CMS paling umum seperti WordPress, Drupal, atau Magento. reSmush.it adalah API optimasi gambar paling banyak digunakan dengan lebih dari tujuh miliar gambar telah diproses, dan tetap Gratis.
* [Shotstack](https://shotstack.io) - API untuk membuat dan mengedit video dalam skala besar. Gratis hingga 20 menit video render per bulan.
* [tinypng.com](https://tinypng.com/) — API untuk mengompres dan mengubah ukuran gambar PNG dan JPEG, menawarkan 500 kompresi gratis setiap bulan.
* [transloadit.com](https://transloadit.com/) — Menangani upload file dan encoding video, audio, gambar, dokumen. Gratis untuk open source, lembaga amal, dan pelajar melalui GitHub Student Developer Pack. Aplikasi komersial mendapat 2 GB gratis untuk test drive.
  * [twicpics.com](https://www.twicpics.com) - Gambar responsif sebagai layanan. Menyediakan CDN gambar, API pemrosesan media, dan pustaka frontend untuk mengotomatiskan optimasi gambar. Layanan ini gratis hingga 3GB trafik per bulan.
  * [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare menyediakan pipeline media dengan toolkit terbaik berbasis algoritma mutakhir. Semua fitur tersedia gratis untuk pengembang: API dan UI Upload File, CDN Gambar dan Layanan Origin, Pengiriman Adaptif, dan Kompresi Cerdas. Paket gratis memiliki batas 3000 unggahan, 3 GB trafik, dan 3 GB penyimpanan.
  * [imagekit.io](https://imagekit.io) – CDN gambar dengan optimasi otomatis, transformasi real-time, dan penyimpanan yang dapat Anda integrasikan dengan setup yang sudah ada dalam hitungan menit. Paket gratis termasuk hingga 20GB bandwidth per bulan.
  * [internxt.com](https://internxt.com) – Internxt Drive adalah layanan penyimpanan file zero-knowledge yang mengutamakan privasi mutlak dan keamanan tanpa kompromi. Daftar dan dapatkan 10 GB gratis, selamanya!
  * [degoo.com](https://degoo.com/) – Penyimpanan cloud berbasis AI gratis hingga 20 GB, tiga perangkat, bonus referensi 5 GB (akun tidak aktif selama 90 hari).
  * [MConverter.eu](https://mconverter.eu/) – Konversi file secara massal. Mendukung banyak format file, termasuk yang baru seperti [AVIF](https://mconverter.eu/convert/to/avif/). Ekstrak seluruh frame gambar dari video. Gratis hingga sepuluh file 100MB per hari, diproses dalam batch dua file.
  * [ImageEngine](https://imageengine.io/) – ImageEngine adalah CDN gambar global yang mudah digunakan. Instalasi kurang dari 60 detik. Mendukung AVIF dan JPEGXL, plugin WordPress-, Magento-, React-, Vue- dan lainnya. Klaim akun developer gratis Anda [di sini](https://imageengine.io/developer-program/).
  * [DocsParse](https://docsparse.com/) – Pemrosesan AI bertenaga GPT untuk PDF, Gambar, menjadi data terstruktur dalam format JSON, CSV, EXCEL. 30 kredit gratis setiap bulan.
  * [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – Mudah membuat kode QR kustom untuk gift card, voucher hadiah, dan promosi. Mendukung gaya, warna, logo kustom, dll.
  * [LibreQR](https://libreqr.com) — Generator kode QR gratis yang berfokus pada privasi dan tanpa pelacakan. Gratis digunakan tanpa pengumpulan data.


**[⬆️ Kembali ke Atas](#table-of-contents)**

## Desain dan UI

  * [AllTheFreeStock](https://allthefreestock.com) - daftar pilihan gambar stok, audio, dan video gratis.
  * [Float UI](https://floatui.com/) - alat pengembangan web gratis untuk membuat situs web modern dan responsif dengan desain menarik, bahkan untuk non-desainer.
  * [Ant Design Landing Page](https://landing.ant.design/) - Ant Design Landing Page menyediakan template yang dibangun dengan komponen motion dari Ant Motion. Memiliki banyak template homepage yang kaya, dapat mengunduh paket kode template, dan bisa digunakan dengan cepat. Anda juga dapat menggunakan editor untuk membangun halaman khusus Anda sendiri dengan cepat.
  * [Backlight](https://backlight.dev/) — Dengan kolaborasi antara developer dan desainer sebagai inti, Backlight adalah platform coding lengkap di mana tim membangun, mendokumentasikan, menerbitkan, menskalakan, dan memelihara Sistem Desain. Paket gratis memungkinkan hingga 3 editor bekerja pada satu sistem desain dengan penonton tak terbatas.
  * [BoxySVG](https://boxy-svg.com/app) — Aplikasi Web gratis yang dapat diinstal untuk menggambar SVG dan mengekspor ke format SVG, PNG, jpeg, dan lainnya.
  * [Carousel Hero](https://carouselhero.com/) - Alat daring gratis untuk membuat carousel media sosial.
  * [Circum Icons](https://circumicons.com) - Ikon open-source konsisten seperti SVG untuk React, Vue, dan Svelte.
  * [clevebrush.com](https://www.cleverbrush.com/) — Aplikasi Desain Grafis / Kolase Foto Gratis. Juga, mereka menawarkan integrasi berbayar sebagai komponen.
  * [cloudconvert.com](https://cloudconvert.com/) — Konversi apa saja ke apa saja. 208 format didukung termasuk video dan gif.
  * [CodeMyUI](https://codemyui.com) - Koleksi pilihan inspirasi Web Design & UI dengan cuplikan kode.
  * [ColorKit](https://colorkit.co/) - Buat palet warna secara online atau dapatkan inspirasi dari palet terbaik.
  * [coolors](https://coolors.co/) - Generator palet warna. Gratis.
  * [CMYK Pantone](https://www.cmyktopantone.com/) - Mudah mengonversi nilai CMYK ke warna Pantone terdekat dan model warna lainnya secara gratis dalam hitungan detik.
  * [Branition](https://branition.com/colors) - Palet warna hasil kurasi yang paling cocok untuk merek.
  * [css-gradient.com](https://www.css-gradient.com/) - Alat gratis untuk menghasilkan gradien CSS lintas-browser khusus dengan cepat. Dalam format RGB dan HEX.
  * [easyvectors.com](https://easyvectors.com/) — EasyVectors.com adalah stok seni vektor SVG gratis. Unduh grafik vektor terbaik secara gratis.
  * [figma.com](https://www.figma.com) — Alat desain kolaboratif daring untuk tim; paket gratis mencakup file dan penonton tak terbatas dengan maksimal 2 editor dan tiga proyek.
  * [Flyon UI](https://flyonui.com/)- Pustaka Komponen Termudah Untuk Tailwind CSS.
  * [framer.com](https://www.framer.com/) - Framer membantu Anda mengiterasi dan menganimasikan ide antarmuka untuk aplikasi, situs web, atau produk Anda berikutnya—mulai dari tata letak yang kuat. Untuk siapa saja yang memvalidasi Framer sebagai alat prototipe profesional: penonton tak terbatas, hingga 2 editor, dan hingga 3 proyek.
  * [freeforcommercialuse.net](https://freeforcommercialuse.net/) — FFCU stok foto model/properti rilis tanpa kekhawatiran
  * [Gradientos](https://www.gradientos.app) - Membuat pemilihan gradien menjadi cepat dan mudah.
  * [Icon Horse](https://icon.horse) – Dapatkan favicon resolusi tertinggi untuk situs web apa pun dari API sederhana kami.
  * [Iconoir](https://iconoir.com) – Pustaka ikon open-source dengan ribuan ikon, mendukung React, React Native, Flutter, Vue, Figma, dan Framer.
  * [Icons8](https://icons8.com) — Ikon, ilustrasi, foto, musik, dan alat desain. Paket Gratis menawarkan format terbatas dalam resolusi rendah. Tautkan ke Icons8 saat Anda menggunakan aset kami.
  * [landen.co](https://www.landen.co) — Buat, edit, dan publikasikan situs web dan halaman arahan yang indah untuk startup Anda. Semua tanpa kode. Paket gratis memungkinkan Anda memiliki satu situs web, sepenuhnya dapat dikustomisasi dan dipublikasikan di web.
  * [Quant Ux](https://quant-ux.com/) - Quant Ux adalah alat prototyping dan desain. - Sepenuhnya gratis dan juga open source.
  * [lensdump.com](https://lensdump.com/) - Hosting gambar cloud gratis.
  * [Lorem Picsum](https://picsum.photos/) - Alat Gratis, mudah digunakan, placeholder yang stylish. Setelah URL kami, tambahkan ukuran gambar yang diinginkan (lebar & tinggi), dan Anda akan mendapatkan gambar acak.
  * [LottieFiles](https://lottiefiles.com/) - Platform online animasi format terkecil terbesar di dunia untuk desainer, pengembang, dan lainnya. Akses alat animasi Lottie dan plugin untuk Android, iOS, dan Web.
  * [MagicPattern](https://www.magicpattern.design/tools) — Koleksi generator & alat background CSS & SVG untuk gradien, pola, dan blob.
  * [marvelapp.com](https://marvelapp.com/) — Desain, prototipe, dan kolaborasi, paket gratis terbatas untuk satu pengguna dan satu proyek.
  * [Mindmup.com](https://www.mindmup.com/) — Mind map tanpa batas gratis dan simpan di cloud. Mind map Anda tersedia di mana saja, secara instan, dari perangkat apa pun.
  * [Mockplus iDoc](https://www.mockplus.com/idoc) - Mockplus iDoc adalah alat kolaborasi & handoff desain yang kuat. Paket Gratis termasuk tiga pengguna dan lima proyek dengan semua fitur tersedia.
  * [mockupmark.com](https://mockupmark.com/create/free) — Buat mockup kaos dan pakaian realistis untuk media sosial dan E-commerce, 40 mockup gratis.
  * [Mossaik](https://mossaik.app) - Generator gambar SVG gratis dengan berbagai alat seperti gelombang, blog dan pola.
  * [movingpencils.com](https://movingpencils.com) — Editor vektor berbasis browser yang cepat. Sepenuhnya gratis.
  * [Octopus.do](https://octopus.do) — Pembuat sitemap visual. Bangun struktur situs web Anda secara real time dan bagikan dengan cepat untuk kolaborasi dengan tim atau klien Anda.
  * [Pencil](https://github.com/evolus/pencil) - Alat desain open source menggunakan Electron.
  * [Penpot](https://penpot.app) - Alat desain dan prototipe berbasis web, open-source. Mendukung SVG. Sepenuhnya gratis.
  * [pexels.com](https://www.pexels.com/) - Foto stok gratis untuk penggunaan komersial. Memiliki API gratis yang memungkinkan Anda mencari foto berdasarkan kata kunci.
  * [photopea.com](https://www.photopea.com) — Editor desain daring gratis tingkat lanjut dengan tampilan Adobe Photoshop yang mendukung format PSD, XCF & Sketch (Adobe Photoshop, Gimp dan Sketch App).
  * [pixlr.com](https://pixlr.com/) — Editor browser online gratis setara dengan editor komersial.
  * [Plasmic](https://www.plasmic.app/) - Alat desain web dan page builder yang cepat, mudah digunakan, dan tangguh yang dapat diintegrasikan ke basis kode Anda. Bangun halaman responsif atau komponen kompleks; bisa diperluas dengan kode; dan publikasikan ke situs dan aplikasi produksi.
  * [Pravatar](https://pravatar.cc/) - Menghasilkan avatar palsu/placeholder acak yang URL-nya bisa langsung di-hotlink di web/aplikasi Anda.
  * [Proto.io](https://proto.io) - Buat prototipe UI interaktif penuh tanpa coding. Paket gratis tersedia setelah masa percobaan berakhir. Paket gratis meliputi satu pengguna, satu proyek, lima prototipe, 100MB penyimpanan online, dan pratinjau aplikasi proto.io.
  * [resizeappicon.com](https://resizeappicon.com/) — Layanan sederhana untuk mengubah ukuran dan mengelola ikon aplikasi Anda.
  * [Rive](https://rive.app) — Buat dan distribusikan animasi indah ke platform apa pun. Gratis selamanya untuk Individu. Layanan ini merupakan editor sekaligus hosting semua grafik di server mereka. Mereka juga menyediakan runtime untuk banyak platform untuk menjalankan representasi yang dibuat menggunakan Rive.
  * [storyset.com](https://storyset.com/) — Buat ilustrasi kustom gratis yang luar biasa untuk proyek Anda menggunakan alat ini.
  * [smartmockups.com](https://smartmockups.com/) — Buat mockup produk, 200 mockup gratis.
  * [Shadcn Studio](https://shadcnstudio.com/theme-editor) — Pratinjau perubahan tema Anda di berbagai komponen dan layout.
  * [Tailark](https://tailark.com/) - Koleksi blok UI modern, responsif, siap pakai yang dirancang untuk situs web pemasaran.
  * [tabler-icons.io](https://tabler-icons.io/) — Lebih dari 1500 ikon SVG editable gratis copy-paste.
  * [tweakcn](https://tweakcn.com/) — Tema indah untuk shadcn/ui. Sesuaikan warna, tipografi, dan lainnya secara real-time.
  * [UI Avatars](https://ui-avatars.com/) - Hasilkan avatar dengan inisial dari nama. URL bisa langsung di-hotlink di web/aplikasi Anda. Mendukung parameter konfigurasi lewat URL.
  * [unDraw](https://undraw.co/) - Koleksi gambar SVG indah yang terus diperbarui dan bisa Anda gunakan sepenuhnya gratis tanpa atribusi.
  * [unsplash.com](https://unsplash.com/) - Foto stok gratis untuk tujuan komersial dan nonkomersial (lisensi do-whatever-you-want).
  * [vectr.com](https://vectr.com/) — Aplikasi Desain Gratis untuk Web + Desktop.
  * [walkme.com](https://www.walkme.com/) — Platform Keterlibatan dan Panduan Kelas Enterprise, paket gratis tiga walkthrough hingga 5 langkah/walk.
  * [Webflow](https://webflow.com) - Pembuat situs web WYSIWYG dengan animasi dan hosting situs web. Gratis untuk dua proyek.
  * [Updrafts.app](https://updrafts.app) - Pembuat situs web WYSIWYG untuk desain berbasis tailwindcss. Gratis untuk penggunaan non-komersial.
  * [whimsical.com](https://whimsical.com/) - Flowchart, wireframe, sticky notes dan mind map kolaboratif. Buat hingga 4 papan gratis.
  * [Zeplin](https://zeplin.io/) — Platform kolaborasi desainer dan developer. Tampilkan desain, aset, dan panduan gaya. Gratis untuk satu proyek.
  * [Pixelixe](https://pixelixe.com/) — Buat dan edit grafik serta gambar menarik secara online.
  * [Responsively App](https://responsively.app) - Alat dev gratis untuk pengembangan aplikasi web responsif lebih cepat dan presisi.
  * [SceneLab](https://scenelab.io) - Editor grafis mockup online dengan koleksi template desain gratis yang terus berkembang
  * [xLayers](https://xlayers.dev) - Pratinjau dan konversi file desain Sketch ke Angular, React, Vue, LitElement, Stencil, Xamarin, dan lainnya (gratis dan open source di https://github.com/xlayers/xlayers)
  * [Grapedrop](https://grapedrop.com/) — Pembuat halaman web responsif, kuat, dan SEO-optimized berbasis GrapesJS Framework. Gratis untuk lima halaman pertama, domain kustom tanpa batas, semua fitur, dan penggunaan sederhana.
  * [Mastershot](https://mastershot.app) - Editor video berbasis browser yang sepenuhnya gratis. Tanpa watermark, opsi ekspor hingga 1080p.
  * [Unicorn Platform](https://unicornplatform.com/) - Pembuat halaman arahan dengan hosting yang mudah. Satu situs web gratis.
  * [SVGmix.com](https://www.svgmix.com/) - Repositori besar berisi 300K+ ikon SVG gratis, koleksi, dan logo merek. Memiliki program editing vektor sederhana langsung di browser untuk pengeditan file cepat.
  * [svgrepo.com](https://www.svgrepo.com/) - Temukan, cari, dan temukan ikon atau vektor yang paling sesuai untuk proyek Anda menggunakan berbagai pustaka vektor. Unduh SVG Vektor gratis untuk penggunaan komersial.
  * [haikei.app](https://www.haikei.app/) - Haikei adalah aplikasi web untuk menghasilkan bentuk SVG, background, dan pola unik – siap digunakan dengan alat desain dan alur kerja Anda.
  * [Canva](https://canva.com) - Alat desain online gratis untuk membuat konten visual.
  * [Superdesigner](https://superdesigner.co) - Koleksi alat desain gratis untuk membuat background, pola, bentuk, gambar unik, dan lainnya hanya dengan beberapa klik.
  * [TeleportHQ](https://teleporthq.io/) - Platform Desain & Pengembangan Front-end Low-code. TeleportHQ adalah platform front-end kolaboratif untuk langsung membuat dan menerbitkan situs web statis headless. Tiga proyek gratis, kolaborator tak terbatas, dan ekspor kode gratis.
  * [vector.express](https://vector.express) — Konversi vektor AI, CDR, DWG, DXF, EPS, HPGL, PDF, PLT, PS dan SVG Anda dengan cepat dan mudah.
  * [Vertopal](https://www.vertopal.com) - Vertopal adalah platform online gratis untuk mengonversi file ke berbagai format. Termasuk konverter untuk developer seperti JPG ke SVG, GIF ke APNG, PNG ke WEBP, JSON ke XML, dll.
  * [okso.app](https://okso.app) - Aplikasi gambar online minimalis. Memungkinkan membuat sketsa dan catatan visual dengan cepat. Ekspor sketsa ke PNG, JPG, SVG, dan WEBP. Juga bisa diinstal sebagai PWA. Gratis untuk semua orang (tanpa registrasi).
  * [Wdrfree SVG](https://wdrfree.com/free-svg) - File potong SVG Hitam Putih Gratis.
  * [Lucide](https://lucide.dev) - Toolkit ikon SVG yang gratis, dapat dikustomisasi dan konsisten.
  * [Logo.dev](https://www.logo.dev) - API logo perusahaan dengan 44 juta+ merek yang mudah digunakan hanya dengan memanggil URL. 10.000 panggilan API pertama gratis.
  * [MDBootstrap](https://mdbootstrap.com/) - Gratis untuk penggunaan pribadi & komersial Bootstrap, Angular, React, dan Vue UI Kits dengan lebih dari 700 komponen, template menakjubkan, instalasi 1 menit, tutorial lengkap & komunitas besar.
  * [TW Elements](https://tw-elements.com/) - Komponen Bootstrap gratis yang dibuat ulang dengan Tailwind CSS, namun dengan desain yang lebih baik dan fungsi lebih banyak.
  * [DaisyUI](https://daisyui.com/) -- Gratis. "Gunakan Tailwind CSS tapi tulis nama class lebih sedikit" menawarkan komponen seperti tombol.
  * [Scrollbar.app](https://scrollbar.app) -- Aplikasi web gratis yang sederhana untuk merancang scrollbar kustom untuk web.
  * [css.glass](https://css.glass/) -- Aplikasi web gratis untuk membuat desain glassmorphic menggunakan CSS.
  * [hypercolor.dev](https://hypercolor.dev/) -- Kumpulan gradien warna Tailwind CSS yang dikurasi, juga menyediakan berbagai generator untuk membuat gradien sendiri.
  * [iconify.design](https://icon-sets.iconify.design/) -- Koleksi lebih dari 100 paket ikon dengan antarmuka yang terpadu. Memungkinkan pencarian ikon lintas paket dan ekspor ikon individual sebagai SVG atau untuk framework web populer.
  * [NextUI](https://nextui.org/) -- Gratis. Perpustakaan UI React & Next.js yang indah, cepat, dan modern.
  * [Glyphs](https://glyphs.fyi/) -- Gratis, Ikon Terkuat di Web, Sistem desain sepenuhnya dapat diedit & benar-benar open source.
  * [ShadcnUI](https://ui.shadcn.com/) -- Komponen yang dirancang indah dan dapat langsung Anda salin-tempel ke aplikasi Anda. Aksesibel. Dapat dikustomisasi. Open Source.
  * [HyperUI](https://www.hyperui.dev/) -- Komponen Tailwind CSS Open Source Gratis.
  * [Calendar Icons Generator](https://calendariconsgenerator.app/) -- Hasilkan ikon unik untuk satu tahun penuh dalam satu klik, 100% GRATIS.
  * [Image BG Blurer](https://imagebgblurer.com/) -- Hasilkan bingkai latar belakang blur untuk gambar, menggunakan sumber gambar itu sendiri sebagai blur latar belakang, untuk Notion, Trello, Jira, dan alat lainnya.
  * [Webstudio](https://webstudio.is/) -- Alternatif open-source untuk Webflow. Paket gratis menawarkan situs web tak terbatas pada domain mereka. Lima situs web dengan domain kustom. Sepuluh ribu tampilan halaman/bulan. Penyimpanan aset 2 GB.
  * [Nappy](https://nappy.co/) -- Foto-foto indah orang Kulit Hitam dan Coklat, gratis. Untuk penggunaan komersial dan pribadi.
  * [Tailkits](https://tailkits.com/) -- Koleksi template, komponen, dan alat Tailwind yang dikurasi, beserta generator berguna untuk kode, grid, box shadow, dan lainnya.
  * [Tailcolors](https://tailcolors.com/) -- Palet warna Tailwind CSS v4 yang indah. Pratinjau & salin kelas warna Tailwind CSS yang sempurna secara instan.
  * [Excalidraw](https://excalidraw.com/) -- Halaman web dokumen gambar online gratis dengan dukungan simpan lokal dan ekspor gratis.
  * [Lunacy](https://icons8.com/lunacy) -- Alat desain grafis gratis dengan dukungan offline, aset bawaan (ikon, foto, ilustrasi), dan kolaborasi waktu nyata. Paket gratis termasuk 10 dokumen cloud, riwayat 30 hari, aset resolusi rendah, dan alat desain dasar.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Inspirasi Desain

  * [awwwards.](https://www.awwwards.com/) - [Situs web terbaik] Showcase semua situs web dengan desain terbaik (dipilih oleh desainer).
  * [Behance](https://www.behance.net/) - [Showcase desain] Tempat para desainer memamerkan karya mereka. Dapat difilter dengan kategori untuk proyek UI/UX.
  * [dribbble](https://dribbble.com/) - [Showcase desain] Inspirasi desain unik, umumnya bukan dari aplikasi nyata.
  * [Landings](https://landings.dev/) - [Screenshot web] Temukan landing page terbaik untuk inspirasi desain Anda sesuai preferensi.
  * [Lapa Ninja](https://www.lapa.ninja/) - [Landing page / UI Kits / Screenshot Web] Lapa Ninja adalah galeri dengan 6025 contoh landing page terbaik, buku gratis untuk desainer, dan UI kit gratis dari seluruh web.
  * [LovelyLanding.net](https://www.lovelylanding.net/) - [Desain Landing Page] Screenshot landing page yang sering diperbarui. Termasuk screenshot Desktop, Tablet, dan Mobile.
  * [Mobbin](https://mobbin.design/) - [Screenshot mobile] Hemat waktu riset UI & UX dengan pustaka 50.000+ screenshot aplikasi mobile yang dapat dicari sepenuhnya.
  * [Uiland Design](https://uiland.design/) - [Screenshot mobile] Jelajahi desain UI Mobile dan Web dari perusahaan terkemuka di Afrika dan dunia.
  * [Mobile Patterns](https://www.mobile-patterns.com/) - [Screenshot mobile] Pustaka inspirasi desain yang menampilkan pola UI UX terbaik (iOS dan Android) untuk referensi desainer, developer, dan pembuat produk.
  * [Page Flows](https://pageflows.com/) - [Video dan screenshot mobile/web] Video alur lengkap pada banyak aplikasi mobile dan web. Juga termasuk screenshot. Dapat dicari dan diindeks dengan mudah.
  * [Screenlane](https://screenlane.com/) - [Screenshot mobile] Dapatkan inspirasi dan ikuti tren desain UI aplikasi web & mobile terbaru. Dapat difilter menurut pola dan aplikasi.
  * [scrnshts](https://scrnshts.club/) - [Screenshot mobile] Koleksi pilihan screenshot desain app store terbaik.
  * [Refero](https://refero.design/) - [Screenshot web] Koleksi referensi desain dari aplikasi web hebat yang diberi tag dan dapat dicari.


**[⬆️ Kembali ke Atas](#table-of-contents)**

## Visualisasi Data pada Peta

  * [IP Geolocation](https://ipgeolocation.io/) — Paket DEVELOPER gratis tersedia dengan 30K permintaan/bulan.
  * [carto.com](https://carto.com/) — Buat peta dan API geospasial dari data Anda dan data publik.
  * [Clockwork Micro](https://clockworkmicro.com/) — Alat peta yang bekerja seperti jam. Lima puluh ribu kueri bulanan gratis (map tiles, db2vector, elevation).
  * [developers.arcgis.com](https://developers.arcgis.com) — API dan SDK untuk peta, penyimpanan data geospasial, analisis, geocoding, routing, dan lainnya di web, desktop, dan mobile. Dua juta tile peta dasar gratis, 20.000 geocode non-stored, 20.000 rute sederhana, 5.000 kalkulasi waktu tempuh, dan 5GB penyimpanan tile+data gratis per bulan.
  * [Foursquare](https://developer.foursquare.com/) - Penemuan lokasi, pencarian venue, dan konten kontekstual dari Places API dan Pilgrim SDK.
  * [geoapify.com](https://www.geoapify.com/) - Map tile vektor dan raster, geocoding, places, routing, isolines API. Tiga ribu permintaan gratis/hari.
  * [geocod.io](https://www.geocod.io/) — Geocoding via API atau Upload CSV. Dua ribu lima ratus kueri gratis/hari.
  * [geocodify.com](https://geocodify.com/) — Geocoding dan Geoparsing via API atau Upload CSV. 10k kueri gratis/bulan.
  * [geojs.io](https://www.geojs.io/) - API lookup IP Geolocation REST/JSON/JSONP dengan ketersediaan tinggi.
  * [giscloud.com](https://www.giscloud.com/) — Visualisasikan, analisis, dan bagikan data geo secara online.
  * [graphhopper.com](https://www.graphhopper.com/) Paket pengembang gratis ditawarkan untuk Routing, Optimasi Rute, Matriks Jarak, Geocoding, dan Map Matching.
  * [here](https://developer.here.com/) — API dan SDK untuk peta dan aplikasi berbasis lokasi. 250k transaksi/bulan gratis.
  * [locationiq.com](https://locationiq.com/) — API Geocoding, Maps, dan Routing. Lima ribu permintaan/hari gratis.
  * [mapbox.com](https://www.mapbox.com/) — Peta, layanan geospasial, dan SDK untuk menampilkan data peta.
  * [maptiler.com](https://www.maptiler.com/cloud/) — Peta vektor, layanan peta, dan SDK untuk visualisasi peta. Tile vektor gratis dengan pembaruan mingguan dan empat gaya peta.
  * [nominatim.org](https://nominatim.org/) — Layanan geocoding gratis dari OpenStreetMap, menyediakan fungsi pencarian alamat global dan reverse geocoding.
  * [nextbillion.ai](https://nextbillion.ai/) - Layanan terkait peta: Geocoding, Navigasi (Arah, Routing, Optimasi Rute, Matriks Jarak), SDK Peta (Vektor, Statis, SDK Mobile). [Gratis dengan kuota tertentu](https://nextbillion.ai/pricing) untuk tiap layanan.
  * [opencagedata.com](https://opencagedata.com) — API Geocoding yang menggabungkan OpenStreetMap dan sumber geo terbuka lainnya. Dua ribu lima ratus kueri gratis/hari.
  * [osmnames](https://osmnames.org/) — Geocoding, hasil pencarian diberi peringkat berdasarkan popularitas halaman Wikipedia terkait.
  * [positionstack](https://positionstack.com/) - Geocoding gratis untuk tempat dan koordinat global. 25.000 permintaan per bulan untuk penggunaan pribadi.
  * [stadiamaps.com](https://stadiamaps.com/) — Map tile, routing, navigasi, dan API geospasial lainnya. Dua ribu lima ratus tampilan peta gratis dan permintaan API/hari untuk penggunaan non-komersial dan pengujian.
  * [maps.stamen.com](http://maps.stamen.com/) - Tile peta dan hosting tile gratis.
  * [ipstack](https://ipstack.com/) - Menemukan dan mengidentifikasi pengunjung situs web berdasarkan Alamat IP
  * [Geokeo api](https://geokeo.com) - API Geocoding dengan koreksi bahasa dan lainnya. Cakupan seluruh dunia. 2.500 kueri gratis harian

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Sistem Build Paket

  * [build.opensuse.org](https://build.opensuse.org/) — Layanan build paket untuk berbagai distro (SUSE, EL, Fedora, Debian, dll.).
  * [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — Layanan build RPM berbasis Mock untuk Fedora dan EL.
  * [help.launchpad.net](https://help.launchpad.net/Packaging) — Layanan build Ubuntu dan Debian.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## IDE dan Editor Kode

  * [3v4l](https://3v4l.org/) - Shell PHP online gratis dan situs berbagi snippet, menjalankan kode Anda di 300+ versi PHP
  * [Android Studio](https://developer.android.com/studio) — Android Studio menyediakan alat tercepat untuk membangun aplikasi di semua jenis perangkat Android. IDE Open Source gratis untuk semua orang dan terbaik untuk pengembangan aplikasi Android. Tersedia untuk Windows, Mac, Linux, bahkan ChromeOS!
  * [AndroidIDE](https://m.androidide.com/) — IDE Open Source untuk mengembangkan aplikasi Android berbasis Gradle yang sesungguhnya di perangkat Android.
  * [Apache Netbeans](https://netbeans.apache.org/) — Lingkungan Pengembangan, Platform Alat, dan Framework Aplikasi.
  * [apiary.io](https://apiary.io/) — Desain API kolaboratif dengan mock API instan dan dokumentasi yang dihasilkan (Gratis untuk blueprint API tanpa batas dan pengguna tak terbatas dengan satu akun admin dan dokumentasi yang dihosting).
  * [BBEdit](https://www.barebones.com/) - BBEdit adalah editor populer dan dapat diperluas untuk macOS. Mode Gratis menyediakan [fitur inti yang kuat](https://www.barebones.com/products/bbedit/comparison.html) dan jalur upgrade ke fitur lanjutan.
  * [Binder](https://mybinder.org/) - Mengubah repo Git menjadi kumpulan notebook interaktif. Merupakan layanan publik gratis.
  * [BlueJ](https://bluej.org) — Lingkungan Pengembangan Java gratis yang dirancang untuk pemula, digunakan oleh jutaan orang di seluruh dunia. Didukung Oracle & GUI sederhana untuk membantu pemula.
  * [Bootify.io](https://bootify.io/) - Generator aplikasi Spring Boot dengan database kustom dan REST API.
  * [Brackets](http://brackets.io/) - Brackets adalah editor teks open-source yang dirancang khusus untuk pengembangan web. Ringan, mudah digunakan, dan sangat dapat disesuaikan.
  * [cacher.io](https://www.cacher.io) — Pengelola snippet kode dengan label dan dukungan untuk 100+ bahasa pemrograman.
  * [Code::Blocks](https://codeblocks.org) — IDE Fortran & C/C++ Gratis. Open Source dan berjalan di Windows, macOS & Linux.
  * [Cody](https://sourcegraph.com/cody) - Asisten coding AI gratis yang dapat menulis (blok kode, autocomplete, unit test), memahami (pengetahuan seluruh codebase Anda), memperbaiki, dan menemukan kode Anda. Tersedia untuk VS Code, JetBrains, dan Online.
  * [codiga.io](https://codiga.io/) — Asisten Coding yang memungkinkan Anda mencari, mendefinisikan, dan menggunakan ulang snippet kode langsung di IDE Anda. Gratis untuk individu dan organisasi kecil.
  * [codesnip.com.br](https://codesnip.com.br) — Pengelola snippet kode sederhana dengan kategori, pencarian, dan tag. gratis dan tanpa batas.
  * [cocalc.com](https://cocalc.com/) — (sebelumnya SageMathCloud di cloud.sagemath.com) — Kolaborasi perhitungan di cloud. Akses browser ke Ubuntu penuh dengan kolaborasi bawaan dan banyak perangkat lunak gratis untuk matematika, sains, data science, sudah terpasang: Python, LaTeX, Jupyter Notebooks, SageMath, scikitlearn, dll.
  * [code.cs50.io](https://code.cs50.io/) - Visual Studio Code untuk CS50 adalah aplikasi web di code.cs50.io yang mengadaptasi GitHub Codespaces untuk siswa dan guru.
  * [codepen.io](https://codepen.io/) — CodePen adalah playground untuk sisi front-end web.
  * [codesandbox.io](https://codesandbox.io/) — Playground online untuk React, Vue, Angular, Preact, dan lainnya.
  * [Components.studio](https://webcomponents.dev/) - Koding komponen secara terisolasi, visualisasikan dalam stories, uji, dan publikasikan ke npm.
  * [Eclipse Che](https://www.eclipse.org/che/) - IDE berbasis web dan native Kubernetes untuk Tim Developer dengan dukungan multi-bahasa. Open Source dan berbasis komunitas. Instansi online yang dihosting oleh Red Hat tersedia di [workspaces.openshift.com](https://workspaces.openshift.com/).
  * [fakejson.com](https://fakejson.com/) — FakeJSON membantu Anda dengan cepat menghasilkan data palsu menggunakan API-nya. Buat permintaan API yang mendeskripsikan apa dan bagaimana yang Anda inginkan. API akan mengembalikan semua dalam format JSON. Mempercepat proses go-to-market untuk ide dan fake it till you make it.
  * [GetVM](https://getvm.io) — Linux dan IDE gratis instan di sidebar chrome. Paket gratis mencakup 5 VM per hari.
  * [GitPod](https://www.gitpod.io) — Lingkungan pengembangan instan yang siap digunakan untuk proyek GitHub. Paket gratis mencakup 50 jam/bulan.
  * [ide.goorm.io](https://ide.goorm.io) goormIDE adalah IDE penuh di cloud. Mendukung multi-bahasa, kontainer berbasis Linux melalui terminal web yang lengkap, port forwarding, URL khusus, kolaborasi dan chat real-time, berbagi tautan, dukungan Git/Subversion. Masih banyak fitur lainnya (Paket gratis mencakup 1GB RAM dan 10GB Storage per kontainer, 5 slot Kontainer).
  * [JDoodle](https://www.jdoodle.com) — Kompiler dan editor online untuk lebih dari 60 bahasa pemrograman dengan paket gratis untuk REST API code compiling hingga 200 kredit per hari.
  * [jetbrains.com](https://jetbrains.com/products.html) — Alat produktivitas, IDE, dan alat deployment (seperti [IntelliJ IDEA](https://www.jetbrains.com/idea/), [PyCharm](https://www.jetbrains.com/pycharm/), dll). Lisensi gratis untuk pelajar, guru, Open Source, dan grup pengguna.
  * [jsbin.com](https://jsbin.com) — JS Bin adalah playground dan situs berbagi kode lain untuk web front-end (HTML, CSS, dan JavaScript. Juga mendukung Markdown, Jade, dan Sass).
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle adalah playground dan situs berbagi kode untuk web front-end, mendukung kolaborasi.
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) Beberapa endpoint REST API yang mengembalikan data palsu dalam format JSON. Kode sumber juga tersedia jika Anda ingin menjalankan server secara lokal.
  * [Lazarus](https://www.lazarus-ide.org/) — Lazarus adalah IDE lintas platform yang kompatibel dengan Delphi untuk Rapid Application Development.
  * [MarsCode](https://www.marscode.com/) - IDE cloud berbasis AI gratis.
  * [micro-jaymock](https://micro-jaymock.now.sh/) - Layanan mikro API mocking kecil untuk menghasilkan data JSON palsu.
  * [mockable.io](https://www.mockable.io/) — Mockable adalah layanan sederhana yang dapat dikonfigurasi untuk mocking layanan web RESTful API atau SOAP. Layanan online ini memungkinkan Anda dengan cepat mendefinisikan endpoint REST API atau SOAP dan mengembalikan data dalam bentuk JSON atau XML.
  * [mockaroo](https://mockaroo.com/) — Mockaroo memungkinkan Anda menghasilkan data uji yang realistis dalam format CSV, JSON, SQL, dan Excel. Anda juga dapat membuat mock untuk API back-end.
  * [Mocklets](https://mocklets.com) - Simulator mock API berbasis HTTP yang membantu mensimulasikan API untuk pengembangan paralel lebih cepat dan pengujian yang lebih komprehensif, dengan paket gratis seumur hidup.
  * [Paiza](https://paiza.cloud/en/) — Mengembangkan aplikasi web di Browser tanpa perlu pengaturan apapun. Paket Gratis menawarkan satu server dengan masa berlaku 24 jam dan waktu operasi 4 jam per hari dengan 2 core CPU, 2 GB RAM, dan 1 GB storage.
  * [Prepros](https://prepros.io/) - Prepros dapat meng-compile Sass, Less, Stylus, Pug/Jade, Haml, Slim, CoffeeScript, dan TypeScript langsung, me-reload browser Anda dan memudahkan pengembangan & pengujian situs web agar Anda bisa fokus menyempurnakannya. Anda juga dapat menambahkan alat sendiri hanya dengan beberapa klik.
  * [Replit](https://replit.com/) — Lingkungan coding cloud untuk berbagai bahasa pemrograman.
  * [SoloLearn](https://code.sololearn.com) — Playground pemrograman cloud yang cocok untuk menjalankan cuplikan kode. Mendukung berbagai bahasa pemrograman. Tidak perlu registrasi untuk menjalankan kode, tapi diperlukan saat menyimpan kode di platform mereka. Juga menawarkan kursus gratis untuk pemula dan tingkat menengah.
  * [stackblitz.com](https://stackblitz.com/) — IDE Kode Online/Cloud untuk membuat, mengedit, & deploy aplikasi full-stack. Mendukung framework frontend & backend berbasis NodeJs populer. Tautan pendek untuk membuat proyek baru: [https://node.new](https://node.new).
  * [Sublime Text](https://www.sublimetext.com/) - Sublime Text adalah editor teks yang populer, serbaguna, dan sangat dapat dikustomisasi yang digunakan untuk pengkodean dan pengeditan teks.
  * [Visual Studio Code](https://code.visualstudio.com/) - Editor kode yang didefinisikan ulang dan dioptimalkan untuk membangun dan debugging aplikasi web serta cloud modern. Dikembangkan oleh Microsoft.
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — IDE lengkap dengan ribuan ekstensi, pengembangan aplikasi lintas platform (ekstensi Microsoft tersedia untuk iOS dan Android), pengembangan desktop, web, dan cloud, dukungan multi-bahasa (C#, C++, JavaScript, Python, PHP, dan banyak lagi).
  * [VSCodium](https://vscodium.com/) - Distribusi biner VSCode dari Microsoft yang digerakkan komunitas, tanpa telemetri/pelacakan, dan lisensi bebas.
  * [wakatime.com](https://wakatime.com/) — Metrik aktivitas coding Anda secara terukur menggunakan plugin editor teks, paket terbatas gratis.
  * [Wave Terminal](https://waveterm.dev/) - Wave adalah terminal open-source, lintas platform untuk alur kerja yang lancar. Render apapun secara inline. Simpan sesi dan riwayat. Didukung oleh standar web terbuka. MacOS dan Linux.
  * [WebComponents.dev](https://webcomponents.dev/) — IDE di browser untuk membuat komponen web secara terisolasi dengan 58 template tersedia, mendukung story, dan pengujian.
  * [PHPSandbox](https://phpsandbox.io/) — Lingkungan pengembangan online untuk PHP
  * [WebDB](https://webdb.app) - IDE Database Efisien Gratis. Menampilkan Server Discovery, ERD, Data Generator, AI, Manajer Struktur NoSQL, Versioning Database, dan banyak lagi.
  * [Zed](https://zed.dev/) - Zed adalah editor kode multiplayer berperforma tinggi dari pencipta Atom dan Tree-sitter.
  * [OneCompiler](https://onecompiler.com/) - Kompiler online gratis yang mendukung 70+ bahasa termasuk Java, Python, C++, JavaScript.


**[⬆️ Kembali ke Atas](#table-of-contents)**

## Analitik, Event, dan Statistik

  * [Dwh.dev](https://dwh.dev) - Solusi Observabilitas Data Cloud (Snowflake). Gratis untuk penggunaan pribadi.
  * [Hightouch](https://hightouch.com/) - Hightouch adalah platform Reverse ETL yang membantu Anda sinkronisasi data pelanggan dari data warehouse ke CRM, alat pemasaran, dan dukungan Anda. Paket gratis menawarkan satu tujuan sinkronisasi data.
  * [Avo](https://avo.app/) — Alur kerja rilis analitik yang disederhanakan. Rencana pelacakan sumber tunggal, library pelacakan analitik type-safe, debugger in-app, dan observabilitas data untuk menangkap semua masalah data sebelum Anda merilisnya. Gratis untuk dua anggota workspace dan 1 jam lookback observabilitas data.
  * [Branch](https://www.branch.io) — Platform Analitik Mobile. Paket Gratis menawarkan hingga 10.000 Pengguna Aplikasi Mobile dengan deep-linking & layanan lain.
  * [Census](https://www.getcensus.com/) — Reverse ETL & Platform Analitik Operasional. Sinkronkan 10 field dari data warehouse Anda ke 60+ SaaS seperti Salesforce, Zendesk, atau Amplitude.
  * [Clicky](https://clicky.com) — Platform Analitik Website. Paket Gratis untuk satu website dengan 3000 tampilan analytics.
  * [Databox](https://databox.com) — Business Insights & Analytics dengan menggabungkan platform analytics & BI lain. Paket Gratis menawarkan 3 pengguna, dashboard & sumber data. 11 juta record data historis.
  * [Hitsteps.com](https://hitsteps.com/) — 2.000 pageviews per bulan untuk 1 website
  * [amplitude.com](https://amplitude.com/) — 1 juta event bulanan, hingga 2 aplikasi
  * [GoatCounter](https://www.goatcounter.com/) — GoatCounter adalah platform analitik web open-source yang tersedia sebagai layanan hosted (gratis untuk penggunaan non-komersial) atau aplikasi self-hosted. Bertujuan menawarkan analitik web yang mudah digunakan dan ramah privasi sebagai alternatif Google Analytics atau Matomo. Paket gratis untuk penggunaan non-komersial dan mencakup situs tanpa batas, retensi data enam bulan, dan 100 ribu pageviews/bulan.
  * [Google Analytics](https://analytics.google.com/) — Google Analytics
  * [MetricsWave](https://metricswave.com) — Alternatif Google Analytics yang ramah privasi untuk developer. Paket gratis memungkinkan 20 ribu pageviews per bulan tanpa kartu kredit.
  * [Expensify](https://www.expensify.com/) — Pelaporan pengeluaran, alur persetujuan pelaporan pribadi gratis
  * [getinsights.io](https://getinsights.io) - Analitik berfokus pada privasi, tanpa cookie, gratis hingga 3 ribu event/bulan.
  * [heap.io](https://heap.io) — Secara otomatis menangkap setiap aksi pengguna di aplikasi iOS atau web. Gratis hingga 10 ribu sesi bulanan.
  * [Hotjar](https://hotjar.com) — Analitik dan Laporan Website. Paket Gratis memungkinkan 2.000 pageviews/hari. Seratus snapshot/hari (kapasitas maksimum: 300). Tiga snapshot heatmap dapat disimpan selama 365 hari. Anggota Tim tanpa batas. Juga tersedia survei dan feedback widget di App dan standalone dengan screenshot. Paket gratis memungkinkan membuat 3 survei & 3 feedback widget dan mengumpulkan 20 respons per bulan.
  * [Keen](https://keen.io/) — Analitik Kustom untuk pengumpulan data, analisis, dan visualisasi. 1.000 event/bulan gratis
  * [Yandex.Datalens](https://datalens.yandex.com/) — Layanan visualisasi dan analisis data Yandex Cloud. Layanan diberikan gratis. Tidak ada batasan jumlah pengguna dan permintaan.
  * [Yandex.Metrica](https://metrica.yandex.com/) — Analitik gratis tanpa batas
  * [Mixpanel](https://mixpanel.com/) — 100.000 pengguna yang dilacak bulanan, histori data dan seat tanpa batas, data residence di AS atau EU
  * [Moesif](https://www.moesif.com) — Analitik API untuk REST dan GraphQL. (Gratis hingga 500.000 panggilan API/bulan)
  * [optimizely.com](https://www.optimizely.com) — Solusi A/B Testing, paket pemula gratis, satu website, 1 iOS, dan 1 aplikasi Android
  * [Microsoft PowerBI](https://powerbi.com) — Business Insights & Analytics dari Microsoft. Paket gratis menawarkan penggunaan terbatas dengan 1 Juta lisensi User.
  * [Row Zero](https://rowzero.io) - Spreadsheet terkoneksi super cepat. Terhubung langsung ke database data, S3, dan API. Import, analisis, grafik, dan bagikan jutaan baris secara instan. Tiga workbook gratis selamanya.
  * [sematext.com](https://sematext.com/cloud/) — Gratis hingga 50 ribu aksi/bulan, retensi data 1 hari, dashboard, pengguna, dll tanpa batas.
  * [Similar Web](https://similarweb.com) — Analitik untuk Web & Mobile Apps. Paket gratis menawarkan lima hasil per metrik, satu bulan data aplikasi mobile & 3 bulan data website.
  * [StatCounter](https://statcounter.com/) — Analitik Pengunjung Website. Paket gratis untuk analitik 500 pengunjung terakhir.
  * [Statsig](https://statsig.com) - Platform all-in-one untuk analitik, feature flagging, dan A/B testing. Gratis hingga 1 juta event terukur per bulan.
  * [Tableau Developer Program](https://www.tableau.com/developer) — Berinovasi, buat, dan optimalkan Tableau untuk organisasi Anda. Program developer gratis memberi lisensi sandbox pengembangan pribadi untuk Tableau Online. Versinya adalah versi pra-rilis terbaru sehingga Data Devs bisa menguji semua fitur platform ini.
  * [usabilityhub.com](https://usabilityhub.com/) — Uji desain dan mockup pada orang nyata dan lacak pengunjung. Gratis untuk satu pengguna, tes tanpa batas
  * [woopra.com](https://www.woopra.com/) — Platform analitik pengguna gratis untuk 500 ribu aksi, retensi data 90 hari, 30+ integrasi sekali klik.
  * [counter.dev](https://counter.dev) — Analitik web sederhana dan ramah privasi. Gratis atau bayar seikhlasnya dengan donasi.
  * [PostHog](https://posthog.com) - Suite Produk Analitik penuh gratis untuk hingga 1 juta event yang dilacak per bulan. Juga menyediakan Survei In-App tanpa batas dengan 250 respons/bulan.
  * [Uptrace](https://uptrace.dev) - Alat Distributed Tracing yang membantu developer menemukan kegagalan dan bottleneck performa. Ada paket gratis, menawarkan langganan Personal gratis untuk proyek open-source, dan memiliki versi open-source.
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity adalah alat gratis yang mudah digunakan untuk menangkap bagaimana pengguna nyata menggunakan situs Anda.
  * [Beampipe.io](https://beampipe.io) - Beampipe adalah analitik web sederhana berfokus privasi. Gratis hingga 5 domain & 10 ribu page views bulanan.
  * [Aptabase](https://aptabase.com) — Open Source, Analitik Sederhana dan Ramah Privasi untuk Aplikasi Mobile dan Desktop. SDK tersedia untuk Swift, Kotlin, React Native, Flutter, Electron, dan banyak lagi. Gratis hingga 20.000 event per bulan.
  * [Trackingplan](https://www.trackingplan.com/) - Secara otomatis mendeteksi analitik digital, data pemasaran dan masalah pixel, menjaga rencana tracking tetap up-to-date, dan mendukung kolaborasi mulus. Deploy ke lingkungan produksi dengan trafik nyata atau tambahkan coverage analitik ke regression test tanpa menulis kode.
  * [LogSpot](https://logspot.io) - Platform analitik web dan produk terpadu, termasuk widget analitik embeddable dan robot otomatis (slack, telegram, dan webhook). Paket gratis termasuk 10.000 event per bulan.
  * [Umami](https://umami.is/) - Alternatif open-source, sederhana, cepat, dan fokus privasi untuk Google Analytics.
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - Alternatif ringan dan ramah privasi untuk Google Analytics. Pageviews tanpa batas, pengunjung tanpa batas, heatmap halaman tanpa batas & pelacakan goal. Gratis hingga 3 domain dan 600 session replay per domain.
  * [AppFit](https://appfit.io) - AppFit adalah alat analitik dan manajemen produk komprehensif untuk memudahkan pengelolaan lintas platform analitik dan update produk. Paket gratis mencakup 10.000 event per bulan, jurnal produk, dan insight mingguan.
  * [Seline](https://seline.so) - Seline adalah analitik produk dan website yang simpel & privat. Tanpa cookie, ringan, independen. Paket gratis mencakup 3.000 event per bulan dan akses ke semua fitur seperti dashboard, user journey, funnel, dan lainnya.
  * [Peasy](https://peasy.so) - Peasy adalah alat analitik ringan dan fokus privasi untuk website dan produk. Paket gratis mencakup 3.000 event per bulan.
  * [Rybbit](https://rybbit.io) - Alternatif open-source dan tanpa cookie untuk Google Analytics yang 10x lebih intuitif. Paket gratis memiliki 3.000 event bulanan. 

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Perekaman Sesi Pengunjung

  * [Reactflow.com](https://www.reactflow.com/) — Per situs: 1.000 pageview/hari, tiga heatmap, tiga widget, pelacakan bug gratis
  * [OpenReplay.com](https://www.openreplay.com) - Perekaman sesi open-source dengan dev tools untuk reproduksi bug, sesi live untuk dukungan real-time, dan suite produk analitik. Seribu sesi/bulan dengan akses ke semua fitur dan retensi 7 hari.
  * [LogRocket.com](https://www.logrocket.com) - 1.000 sesi/bulan dengan retensi 30 hari, pelacakan error, mode live
  * [FullStory.com](https://www.fullstory.com) — 1.000 sesi/bulan dengan retensi data satu bulan dan tiga user seat. Info lebih lanjut [di sini](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition).
  * [hotjar.com](https://www.hotjar.com/) — Per situs: 1.050 pageview/bulan, heatmap tanpa batas, data disimpan selama tiga bulan
  * [inspectlet.com](https://www.inspectlet.com/) — 2.500 sesi/bulan gratis untuk satu website
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Perekaman sesi sepenuhnya gratis dengan "tanpa batasan trafik", tanpa batas proyek, dan tanpa sampling
  * [mouseflow.com](https://mouseflow.com/) — 500 sesi/bulan gratis untuk satu website
  * [mousestats.com](https://www.mousestats.com/) — 100 sesi/bulan gratis untuk satu website
  * [smartlook.com](https://www.smartlook.com/) — paket gratis untuk aplikasi web dan mobile (1.500 sesi/bulan), tiga heatmap, satu funnel, histori data 1 bulan
  * [howuku.com](https://howuku.com) — Lacak interaksi pengguna, keterlibatan, dan event. Gratis hingga 5.000 kunjungan/bulan
  * [UXtweak.com](https://www.uxtweak.com/) — Rekam dan tonton bagaimana pengunjung menggunakan situs atau aplikasi Anda. Gratis tanpa batas waktu untuk proyek kecil

**[⬆️ Kembali ke Atas](#table-of-contents)**

## API dan SDK Verifikasi Nomor Ponsel Internasional

  * [numverify](https://numverify.com/) — Validasi nomor ponsel global dan API JSON pencarian. 100 permintaan API/bulan.
  * [veriphone](https://veriphone.io/) — Verifikasi nomor ponsel global dalam API JSON yang gratis, cepat, dan andal. 1000 permintaan/bulan.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Integrasi Pembayaran dan Penagihan

  * [Qonversion](http://qonversion.io/) - Platform manajemen langganan lintas platform all-in-one yang menawarkan analitik, A/B testing, Apple Search Ads, remote configs, dan tools pertumbuhan untuk mengoptimalkan pembelian dalam aplikasi dan monetisasi. Kompatibel dengan iOS, Android, React Native, Flutter, Unity, Cordova, Stripe, dan web. Gratis hingga pendapatan terlacak $10k per bulan.
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – Secara otomatis menyesuaikan harga berdasarkan lokasi pengunjung untuk memperluas bisnis Anda secara global dan menjangkau pasar baru (purchasing power parity). Paket gratis termasuk 7.500 permintaan API/bulan.
  * [Glassfy](https://glassfy.io/) – Infrastruktur langganan dalam aplikasi, event langganan real-time dan tools monetisasi siap pakai di iOS, Android, Stripe dan Paddle. Gratis hingga pendapatan $10k per bulan.
  * [Adapty.io](https://adapty.io/) – Solusi satu atap dengan SDK open-source untuk integrasi langganan dalam aplikasi mobile ke aplikasi iOS, Android, React Native, Flutter, Unity, atau web. Gratis hingga pendapatan $10k per bulan.
  * [CoinMarketCap](https://coinmarketcap.com/api/) — Menyediakan data pasar mata uang kripto termasuk kurs tukar mata uang kripto dan fiat terbaru. Paket gratis menawarkan 10K kredit panggilan/bulan.
  * [CurrencyFreaks](https://currencyfreaks.com/) — Menyediakan kurs tukar mata uang saat ini dan historis. Paket DEVELOPER gratis tersedia dengan 1000 permintaan/bulan.
  * [CoinGecko](https://www.coingecko.com/en/api) — Menyediakan data pasar mata uang kripto termasuk kurs tukar terbaru dan data historis. Demo api memiliki limit stabil 30 panggilan/menit dan batas bulanan 10.000 panggilan.
  * [CurrencyApi](https://currencyapi.net/) — Kurs Mata Uang Langsung untuk Mata Uang Fisik dan Kripto, disajikan dalam format JSON dan XML. Paket gratis menawarkan 1.250 permintaan API/bulan.
  * [currencylayer](https://currencylayer.com/) — Kurs tukar andal dan konversi mata uang untuk bisnis Anda, 100 permintaan API/bulan gratis.
  * [exchangerate-api.com](https://www.exchangerate-api.com) - API konversi mata uang berbasis JSON yang mudah digunakan. Paket gratis diperbarui sekali per hari dengan batas 1.500 permintaan/bulan.
  * [FraudLabsPRO](https://www.fraudlabspro.com) — Membantu merchant mencegah penipuan pembayaran dan chargeback. Paket Micro gratis tersedia dengan 500 kueri/bulan.
  * [FxRatesAPI](https://fxratesapi.com) — Menyediakan kurs tukar real-time dan historis. Paket gratis memerlukan atribusi.
  * [Moesif API Monetization](https://www.moesif.com/) - Hasilkan pendapatan dari API melalui penagihan berbasis penggunaan. Terhubung ke Stripe, Chargebee, dll. Paket gratis menawarkan 30.000 event/bulan.
  * [Nami ML](https://www.namiml.com/) - Platform lengkap untuk pembelian dalam aplikasi dan langganan di iOS dan Android, termasuk paywall no-code, CRM, dan analitik. Gratis untuk semua fitur dasar menjalankan bisnis IAP.
  * [RevenueCat](https://www.revenuecat.com/) — Backend terhosting untuk pembelian dalam aplikasi dan langganan (iOS dan Android). Gratis hingga pendapatan terlacak $2,5k/bulan.
  * [vatlayer](https://vatlayer.com/) — Validasi nomor VAT instan dan API tarif VAT Uni Eropa, gratis 100 permintaan API/bulan.
  * [Currencyapi](https://currencyapi.com) — API data konversi dan kurs tukar mata uang gratis. Gratis 300 permintaan per bulan, 10 permintaan per menit untuk penggunaan pribadi.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Terkait Docker

  * [canister.io](https://canister.io/) — 20 repositori privat gratis untuk pengembang, 30 repositori privat gratis untuk tim untuk membangun dan menyimpan image Docker
  * [Container Registry Service](https://container-registry.com/) - Solusi Manajemen Container berbasis Harbor. Paket gratis menawarkan 1 GB penyimpanan untuk repositori privat.
  * [Docker Hub](https://hub.docker.com) — Satu repositori privat gratis dan repositori publik tak terbatas untuk membangun dan menyimpan image Docker
  * [Play with Docker](https://labs.play-with-docker.com/) — Playground interaktif, sederhana, dan menyenangkan untuk belajar Docker.
  * [quay.io](https://quay.io/) — Bangun dan simpan image container dengan repositori publik gratis tanpa batas
  * [ttl.sh](https://ttl.sh/) - Registri image Docker anonim & sementara

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Terkait Vagrant

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud. Hosting box Vagrant.
  * [Vagrantbox.es](https://www.vagrantbox.es/) — Indeks box publik alternatif

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Situs Blogging Dev

  * [BearBlog](https://bearblog.dev/) - Blog dan pembuat situs web minimalis berbasis Markdown.
  * [Dev.to](https://dev.to/) - Tempat programmer berbagi ide dan saling membantu berkembang.
  * [Hashnode](https://hashnode.com/) — Perangkat lunak blogging bebas repot untuk developer!
  * [Medium](https://medium.com/) — Jadilah lebih bijaksana tentang hal-hal yang penting bagi Anda.
  * [AyeDot](https://ayedot.com/) — Bagikan ide, pengetahuan, dan cerita Anda ke seluruh dunia secara gratis dalam bentuk Miniblog multimedia format pendek modern.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Platform Komentar
  * [GraphComment](https://graphcomment.com/) - GraphComment adalah platform komentar yang membantu membangun komunitas aktif dari audiens situs web.
  * [Utterances](https://utteranc.es/) - Widget komentar ringan berbasis issue GitHub. Gunakan issue GitHub untuk komentar blog, halaman wiki, dan lainnya!
  * [Disqus](https://disqus.com/) - Disqus adalah platform komunitas terhubung yang digunakan oleh ratusan ribu situs di seluruh web.
  * [Remarkbox](https://www.remarkbox.com/) - Platform komentar hosted open source, bayar sesuai kemampuan untuk "Satu moderator di beberapa domain dengan kontrol penuh atas perilaku & tampilan"
  * [IntenseDebate](https://intensedebate.com/) - Sistem komentar kaya fitur untuk WordPress, Tumblr, Blogger, dan banyak platform situs web lainnya.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## API Screenshot

  * [ApiFlash](https://apiflash.com) — API screenshot berbasis AWS Lambda dan Chrome. Mendukung full page, penangkapan waktu, dan dimensi viewport.
  * [microlink.io](https://microlink.io/) – Mengubah situs web apa pun menjadi data seperti normalisasi metatag, preview link menarik, kemampuan scraping, atau screenshot sebagai layanan. 250 permintaan/hari gratis setiap hari.
  * [ScreenshotAPI.net](https://screenshotapi.net/) - API Screenshot menggunakan panggilan API sederhana untuk menghasilkan screenshot dari situs web apa pun. Dibangun untuk skala besar dan dihosting di Google Cloud. Menawarkan 100 screenshot gratis per bulan.
  * [screenshotlayer.com](https://screenshotlayer.com/) — Tangkap snapshot situs web yang sangat bisa dikustomisasi. Gratis 100 snapshot/bulan.
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — Tangkap 100 snapshot/bulan, png, gif, dan jpg, termasuk tangkapan full-length, tidak hanya halaman utama.
  * [PhantomJsCloud](https://PhantomJsCloud.com) — Otomasi browser dan rendering halaman. Paket Gratis menawarkan hingga 500 halaman/hari. Paket Gratis sejak 2017.
  * [Webshrinker.com](https://webshrinker.com) — Web Shrinker menyediakan layanan API screenshot website dan intelijen domain. Gratis 100 permintaan/bulan.
  * [Screenshots](https://screenshotson.click) — API Anda untuk Screenshot. Dengan opsi penangkapan yang sangat kustomisasi. Gratis 100 screenshot/bulan.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Terkait Flutter dan Membangun Aplikasi IOS tanpa Mac

  * [FlutLab](https://flutlab.io/) - FlutLab adalah IDE Flutter online modern dan tempat terbaik untuk membuat, debug, dan membangun proyek lintas platform. Bangun aplikasi iOS (Tanpa Mac) dan Android dengan Flutter.
  * [CodeMagic](https://codemagic.io/) - Codemagic adalah CI/CD yang sepenuhnya hosted dan dikelola untuk aplikasi mobile. Anda dapat membangun, menguji, dan melakukan deploy dengan alat CI/CD berbasis GUI. Paket gratis menawarkan 500 menit gratis/bulan dan instance Mac Mini dengan 2.3 GHz dan RAM 8 GB.
  * [FlutterFlow](https://flutterflow.io/) - FlutterFlow adalah antarmuka drag-and-drop berbasis browser untuk membangun aplikasi mobile menggunakan Flutter.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Emulasi Perangkat Keras Berbasis Browser yang Ditulis dalam Javascript

  * [JsLinux](https://bellard.org/jslinux) — mesin virtual x86 yang sangat cepat dan mampu menjalankan Linux dan Windows 2k.
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) — mesin virtual OpenRISC yang mampu menjalankan Linux dengan dukungan jaringan.
  * [v86](https://copy.sh/v86) — mesin virtual x86 yang mampu menjalankan Linux dan OS lain langsung di browser.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Manajemen Privasi
  * [Bearer](https://www.bearer.sh/) - Membantu menerapkan privacy by design melalui audit dan alur kerja berkelanjutan sehingga organisasi mematuhi GDPR dan peraturan lainnya. Paket gratis terbatas untuk tim kecil dan hanya versi SaaS.
  * [Osano](https://www.osano.com/) - Platform manajemen persetujuan dan kepatuhan dengan segala hal mulai dari perwakilan GDPR hingga banner cookie. Paket gratis menawarkan fitur dasar.
  * [Iubenda](https://www.iubenda.com/) - Kebijakan privasi dan cookie serta manajemen persetujuan. Paket gratis menawarkan kebijakan privasi dan cookie terbatas serta banner cookie.
  * [Cookiefirst](https://cookiefirst.com/) - Banner cookie, audit, dan solusi manajemen persetujuan multibahasa. Paket gratis menawarkan pemindaian satu kali dan satu banner.
* [Ketch](https://www.ketch.com/) - Alat manajemen persetujuan dan kerangka kerja privasi. Paket gratis menawarkan sebagian besar fitur dengan jumlah pengunjung terbatas.
* [Concord](https://www.concord.tech/) - Platform privasi data lengkap, termasuk manajemen persetujuan, penanganan permintaan privasi (DSAR), dan pemetaan data. Paket gratis mencakup fitur utama manajemen persetujuan dan mereka juga menyediakan paket lebih lanjut secara gratis untuk proyek open source yang terverifikasi.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Lain-lain

* [BackgroundStyler.com](https://backgroundstyler.com) - Membuat tangkapan layar estetis dari kode, teks, atau gambar Anda untuk dibagikan di media sosial.
* [BinShare.net](https://binshare.net) - Membuat & berbagi kode atau file biner. Dapat dibagikan sebagai gambar cantik (misal untuk posting Twitter/Facebook) atau sebagai tautan (misal untuk chat atau forum).
* [Blynk](https://blynk.io) — SaaS dengan API untuk mengontrol, membangun & evaluasi perangkat IoT. Paket Developer Gratis dengan 5 perangkat, Cloud Gratis & penyimpanan data. Aplikasi Mobile juga tersedia.
* [Bricks Note Calculator](https://free.getbricks.app/) - aplikasi pencatat (PWA) dengan kalkulator multiline bawaan yang kuat.
* [Carbon.now.sh](https://carbon.now.sh) - buat dan bagikan cuplikan kode dalam format gambar tangkapan layar yang estetis. Biasanya digunakan untuk berbagi/menunjukkan cuplikan kode secara estetis di Twitter atau posting blog.
* [Code Time](https://www.software.com/code-time) - ekstensi untuk pelacakan waktu dan metrik pengkodean di VS Code, Atom, IntelliJ, Sublime Text, dan lainnya.
* [Codepng](https://www.codepng.app) - Buat snapshot menarik dari kode sumber Anda untuk dibagikan di media sosial.
* [CodeToImage](https://codetoimage.com/) - Buat tangkapan layar kode atau teks untuk dibagikan di media sosial.
* [Cronhooks](https://cronhooks.io/) - Jadwalkan webhook sekali atau berulang. Paket gratis memungkinkan 5 penjadwalan ad-hoc.
* [cron-job.org](https://cron-job.org) - Layanan cronjobs online. Job tanpa batas gratis.
* [datelist.io](https://datelist.io) - Sistem penjadwalan pemesanan/janji temu online. Gratis hingga 5 pemesanan per bulan, termasuk 1 kalender.
* [Domain Forward](https://domain-forward.com/) - Alat sederhana untuk meneruskan URL atau Domain apa pun. Gratis hingga 5 domain dan 200k permintaan per bulan.
* [Elementor](https://elementor.com) — Pembuat situs WordPress. Paket gratis tersedia dengan 40+ Widget Dasar.
* [Exif Editor](https://exifeditor.io/) — Melihat, mengedit, membersihkan, dan menganalisis metadata gambar/foto langsung di browser - termasuk lokasi GPS dan metadata.
* [Format Express](https://www.format-express.dev) - Format instan online untuk JSON / XML / SQL.
* [FOSSA](https://fossa.com/) - Manajemen skala besar, end-to-end untuk kode pihak ketiga, kepatuhan lisensi dan kerentanan.
* [Hook Relay](https://www.hookrelay.dev/) - Tambahkan dukungan webhook ke aplikasi Anda tanpa repot: antrian, retry dengan backoff, dan logging sudah disediakan. Paket gratis memiliki 100 pengiriman per hari, retensi 14 hari, dan 3 endpoint hook.
* [Hosting Checker](https://hostingchecker.co) - Periksa informasi hosting seperti ASN, ISP, lokasi, dan lainnya untuk domain, situs web, atau alamat IP apa pun. Juga termasuk berbagai alat terkait hosting dan DNS.
* [http2.pro](https://http2.pro) — Tes kesiapan protokol HTTP/2 dan API deteksi dukungan client HTTP/2.
* [kandi](https://kandi.openweaver.com/) — Memulai pengembangan aplikasi: membangun fungsi khusus, use case, dan aplikasi lengkap lebih cepat lewat cuplikan kode dan penggunaan kembali pustaka open source.
* [Base64 decoder/encoder](https://devpal.co/base64-decode/) — Alat online gratis untuk decoding & encoding data.
* [newreleases.io](https://newreleases.io) - Terima notifikasi via email, Slack, Telegram, Discord, dan webhook khusus untuk rilis baru dari GitHub, GitLab, Bitbucket, Python PyPI, Java Maven, Node.js NPM, Node.js Yarn, Ruby Gems, PHP Packagist, .NET NuGet, Rust Cargo dan Docker Hub.
* [OnlineExifViewer](https://onlineexifviewer.com/) — Lihat data EXIF foto secara online secara instan termasuk lokasi GPS dan metadata.
* [PDFMonkey](https://www.pdfmonkey.io/) — Kelola template PDF di dashboard, panggil API dengan data dinamis, dan unduh PDF Anda. Menyediakan 300 dokumen gratis per bulan.
* [Pika Code Screenshots](https://pika.style/templates/code-image) — Buat tangkapan layar kode yang indah dan dapat disesuaikan dari cuplikan kode dan VSCode menggunakan ekstensi.
* [QuickType.io](https://quicktype.io/) - Cepat menghasilkan otomatis model/class/type/interface dan serializer dari JSON, schema, dan GraphQL untuk bekerja dengan data secara cepat & aman dalam bahasa pemrograman apa pun. Ubah JSON menjadi kode yang indah dan typesafe dalam bahasa apa pun.
* [RandomKeygen](https://randomkeygen.com/) - Alat gratis mobile-friendly yang menawarkan berbagai key dan password acak untuk mengamankan aplikasi, layanan, atau perangkat apa pun.
* [ray.so](https://ray.so/) - Buat gambar indah dari cuplikan kode Anda.
* [readme.com](https://readme.com/) — Dokumentasi indah dengan mudah, gratis untuk Open Source.
* [redirection.io](https://redirection.io/) — Alat SaaS untuk mengelola redireksi HTTP untuk bisnis, pemasaran, dan SEO.
* [redirect.ing](https://redirect.ing/) - Forwarding domain cepat & aman tanpa mengelola server atau sertifikat SSL. Paket gratis mencakup 10 hostname dan 100.000 permintaan per bulan.
* [redirect.pizza](https://redirect.pizza/) - Kelola redirect dengan mudah dan dukungan HTTPS. Paket gratis mencakup 10 sumber dan 100.000 hit per bulan.
* [ReqBin](https://reqbin.com/) — Kirim permintaan HTTP secara online. Metode populer termasuk GET, POST, PUT, DELETE, dan HEAD. Mendukung Header dan Autentikasi Token. Termasuk sistem login dasar untuk menyimpan permintaan Anda.
* [Smartcar API](https://smartcar.com) - API untuk mobil, seperti melacak lokasi, mendapatkan level tangki bensin, baterai, odometer, membuka/mengunci pintu, dll.
* [snappify](https://snappify.com) - Memungkinkan developer membuat visual yang menakjubkan. Dari cuplikan kode hingga presentasi teknis lengkap. Paket gratis mencakup hingga 3 snap sekaligus dengan unduhan tak terbatas dan 5 penjelasan kode berbasis AI per bulan.
* [Sunrise and Sunset](https://sunrisesunset.io/api/) - Dapatkan waktu matahari terbit dan terbenam untuk koordinat bujur dan lintang tertentu.
* [superfeedr.com](https://superfeedr.com/) — Feed real-time sesuai PubSubHubbub, ekspor, analitik. Gratis dengan kustomisasi terbatas.
* [SurveyMonkey.com](https://www.surveymonkey.com) — Buat survei online. Analisis hasil online. Paket gratis hanya mengizinkan 10 pertanyaan dan 100 respon per survei.
* [Tiledesk](https://tiledesk.com) - Buat chatbot dan aplikasi percakapan. Bawa mereka ke omnichannel: dari situs web Anda (live chat widget) ke WhatsApp. Paket gratis dengan chatbot tanpa batas.
* [Versionfeeds](https://versionfeeds.com) — RSS feed khusus untuk rilis perangkat lunak favorit Anda. Dapatkan versi terbaru dari bahasa pemrograman, pustaka, atau alat favorit dalam satu feed. (3 feed pertama gratis)
* [videoinu](https://videoinu.com) — Buat dan edit rekaman layar serta video lain secara online.
* [Webacus](https://webacus.dev) — Akses berbagai alat developer gratis untuk encoding, decoding, dan manipulasi data.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Alat Remote Desktop

* [Getscreen.me](https://getscreen.me) — Gratis untuk 2 perangkat, tanpa batas jumlah dan durasi sesi
* [Apache Guacamole™](https://guacamole.apache.org/) — Gateway remote desktop tanpa klien open source
* [RemSupp](https://remsupp.com) — Dukungan on-demand dan akses permanen ke perangkat (2 sesi/hari gratis)
* [RustDesk](https://rustdesk.com/) - Infrastruktur desktop virtual/remote open source untuk semua orang!
* [AnyDesk](https://anydesk.com) — Gratis untuk 3 perangkat, tanpa batas jumlah dan durasi sesi

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Pengembangan Game

* [itch.io](https://itch.io/game-assets) — Aset gratis/berbayar seperti sprite, tile set, dan paket karakter.
* [Gamefresco.com](https://gamefresco.com/) — Temukan, kumpulkan, dan bagikan aset game gratis dari seniman game di seluruh dunia.
* [GameDevMarket](https://gamedevmarket.net) — Aset gratis/berbayar seperti 2D, 3D, Audio, GUI.
* [OpenGameArt](https://opengameart.org) — Aset Game OpenSource seperti musik, suara, sprite, dan gif.
* [CraftPix](https://craftpix.net) — Aset gratis/berbayar seperti 2D, 3D, Audio, GUI, latar belakang, ikon, tile set, game kit.
* [Game Icons](https://game-icons.net/) - Ikon SVG/PNG yang dapat diatur gaya secara gratis dengan lisensi CC-BY.
* [LoSpec](https://lospec.com/) — Alat online untuk membuat pixel art dan seni digital terbatas lainnya, banyak tutorial/daftar palet tersedia untuk dipilih untuk game Anda
* [ArtStation](https://www.artstation.com/) - MarketPlace untuk aset 2D, 3D & audio, ikon, tile set, game kit gratis/berbayar. Juga dapat digunakan untuk memamerkan portofolio seni Anda.
* [Rive](https://rive.app/community/) - Aset komunitas serta membuat aset game sendiri menggunakan paket gratisnya.
* [Poly Pizza](https://poly.pizza/) - Aset 3D low poly gratis
* [3Dassets.one](https://3dassets.one/) - Lebih dari 8.000 model 3D gratis/berbayar, dan material PBR untuk membuat tekstur.
* [Kenney](https://www.kenney.nl/assets/) - Aset game 2D, 3D, Audio, dan UI gratis (lisensi CC0 1.0 Universal).
* [Poliigon](https://www.poliigon.com/) - Tekstur gratis dan berbayar (dengan resolusi variatif), model, HDRI, dan brush. Menawarkan plugin gratis untuk ekspor ke perangkat lunak seperti Blender.
* [Freesound](https://freesound.org/) - Pustaka suara kolaboratif gratis dengan berbagai lisensi CC.

**[⬆️ Kembali ke Atas](#table-of-contents)**

## Sumber Daya Gratis Lainnya

* [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - Alat gratis selamanya untuk pengembang web yang mencakup minify-unminify CSS, pengoptimal gambar, pengubah ukuran gambar, pengubah case, validator CSS, kompilator JavaScript, editor HTML, dll.
* [ElevateAI](https://www.elevateai.com) - Dapatkan hingga 200 jam transkripsi audio gratis setiap bulan.
* [get.localhost.direct](https://get.localhost.direct) — Sertifikat SSL Wildcard public CA bertanda tangan untuk pengembangan localhost dengan dukungan sub-domain
* [Framacloud](https://degooglisons-internet.org/en/) — Daftar Free/Libre Open Source Software dan SaaS oleh nirlaba Prancis [Framasoft](https://framasoft.org/en/).
* [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — Hub perangkat lunak gratis dan Open Source untuk pengembang.
* [GitHub Education](https://education.github.com/pack) — Koleksi layanan gratis untuk siswa. Pendaftaran diperlukan.
* [Markdown Tools](https://markdowntools.com) - Alat untuk mengonversi HTML, CSV, PDF, JSON, dan file Excel ke/dari Markdown
* [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — Dapatkan sandbox gratis, alat, dan sumber daya lain yang Anda butuhkan untuk membangun solusi untuk platform Microsoft 365. Langganan adalah [Microsoft 365 E5 Subscription](https://www.microsoft.com/microsoft-365/enterprise/e5) selama 90 hari (Windows tidak termasuk) dan dapat diperbarui. Akan diperpanjang jika Anda aktif dalam pengembangan (diukur dengan data telemetry & algoritma).
* [Pyrexp](https://pythonium.net/regex) — Regex tester dan visualizer berbasis web gratis untuk debugging regular expression.
* [RedHat for Developers](https://developers.redhat.com) — Akses gratis ke produk Red Hat termasuk RHEL, OpenShift, CodeReady, dll, khusus untuk pengembang. Hanya paket individu. E-book gratis juga tersedia untuk referensi.
* [smsreceivefree.com](https://smsreceivefree.com/) — Menyediakan nomor telepon sementara dan sekali pakai secara gratis.
* [sandbox.httpsms.com](https://sandbox.httpsms.com) — Kirim dan terima pesan SMS uji secara gratis.
* [SimpleBackups.com](https://simplebackups.com/) — Layanan otomatisasi backup untuk server dan database (MySQL, PostgreSQL, MongoDB) yang disimpan langsung di penyedia cloud storage (AWS, DigitalOcean, dan Backblaze). Menyediakan paket gratis untuk 1 backup.
* [SnapShooter](https://snapshooter.com/) — Solusi backup untuk DigitalOcean, AWS, LightSail, Hetzner, dan Exoscale, dengan dukungan backup langsung database, file system dan aplikasi ke penyimpanan berbasis s3. Menyediakan paket gratis dengan backup harian untuk satu resource.
* [Themeselection](https://themeselection.com/) — Template Admin Dashboard Gratis, Tema HTML, dan UI Kit berkualitas tinggi, modern, profesional, dan mudah digunakan untuk mempercepat pembuatan aplikasi Anda!
* [Web.Dev](https://web.dev/measure/) — Alat gratis untuk melihat performa situs web Anda dan meningkatkan SEO agar mendapat peringkat lebih tinggi di mesin pencari.
  * [SmallDev.tools](https://smalldev.tools/) — Alat gratis untuk pengembang yang memungkinkan Anda melakukan Encode/Decode berbagai format, Memperkecil HTML/CSS/Javascript, Memperindah, Menghasilkan dataset Palsu/Pengujian dalam format JSON/CSV & berbagai format lainnya dan banyak fitur lainnya. Dengan antarmuka yang menyenangkan.
  * [UseCSV by Layercode](https://layercode.com/usecsv) — Tambahkan impor CSV dan Excel ke aplikasi web Anda dalam hitungan menit. Berikan pengalaman impor data yang menyenangkan dan andal kepada pengguna Anda. Mulai Gratis tanpa detail kartu kredit, dan mulailah mengintegrasikan UseCSV hari ini. Anda dapat membuat Importer tanpa batas dan mengunggah file hingga 100Mb.
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — 100+ tombol yang dapat Anda gunakan dalam proyek Anda.
  * [WrapPixel](https://www.wrappixel.com/) — Unduh template dashboard Admin berkualitas tinggi gratis dan premium yang dibuat dengan Angular, React, VueJs, NextJS, dan NuxtJS!
  * [Utils.fun](https://utils.fun/en) — Semua alat harian dan pengembangan berbasis offline yang memanfaatkan kekuatan komputasi browser, termasuk pembuatan watermark, perekaman layar, encoding dan decoding, enkripsi dan dekripsi, serta pemformatan kode, semuanya gratis dan tidak mengunggah data apa pun ke cloud untuk diproses.
  * [It tools](it-tools.tech) - Alat-alat berguna untuk pengembang dan orang yang bekerja di bidang IT.
  * [Free Code Tools](https://freecodetools.org/) — Alat kode yang efektif dan 100% gratis. Editor Markdown, pemerkecil/pemercantik kode, generator kode QR, Open Graph Generator, Twitter card Generator, dan banyak lagi.
  * [regex101](https://regex101.com/) — Gratis, situs ini memungkinkan Anda menguji dan men-debug ekspresi reguler (regex). Menyediakan editor dan tester regex, serta dokumentasi dan sumber daya yang membantu untuk belajar regex.
  * [Kody Tools](https://www.kodytools.com/dev-tools) — 100+ alat dev termasuk formatter, minifier, dan converter.
  * [AdminMart](https://adminmart.com/) — Template Dashboard Admin dan Website berkualitas tinggi gratis dan premium yang dibuat dengan Angular, Bootstrap, React, VueJs, NextJS, dan NuxtJS!
  * [Glob tester](https://globster.xyz/) — Situs web yang memungkinkan Anda merancang dan menguji pola glob. Juga menyediakan sumber daya untuk belajar pola glob.
  * [SimpleRestore](https://simplerestore.io) - Pemulihan backup MySQL tanpa repot. Pulihkan backup MySQL ke database jarak jauh mana pun tanpa kode atau server.
  * [360Converter](https://www.360converter.com/) - Website gratis yang berguna untuk mengonversi: Video ke Teks && Audio ke Teks && Ucapan ke Teks && Audio Real-time ke Teks && Video YouTube ke Teks && menambah Subtitle Video. Mungkin akan berguna untuk konversi video singkat atau tutorial YouTube singkat:)
  * [QRCodeBest](https://qrcode.best/) - Buat kode QR kustom dengan 13 template, privasi penuh, dan personal branding. Fitur pixel pelacakan, kategorisasi proyek, dan kursi tim tak terbatas di QRCode.Best.
  * [PostPulse](https://PostPulseAI.com) - Tingkatkan kehadiran online Anda, tingkatkan SEO dan peringkat situs dengan posting bulanan yang dibuat AI ke domain yang dioptimalkan SEO. Paket gratis memungkinkan Anda menerbitkan satu posting secara manual di situs kami setiap bulan.
  * [PageTools](https://pagetools.co/) - Menawarkan rangkaian alat bertenaga AI gratis selamanya untuk membantu Anda menghasilkan kebijakan situs web penting, membuat bio media sosial, postingan, dan halaman web dengan antarmuka satu klik yang sederhana.
  * [MySQL Visual Explain](https://mysqlexplain.com) - Visualizer output MySQL EXPLAIN yang mudah dipahami dan gratis untuk mengoptimalkan query yang lambat.
  * [Killer Coda](https://killercoda.com/)  - Playground interaktif di browser Anda untuk belajar Linux, Kubernetes, Containers, Programming, DevOps, Jaringan
  * [Axonomy App](https://axonomy-app.com/) - Alat gratis untuk membuat, mengelola, dan membagikan faktur kepada klien Anda. 10 faktur gratis per bulan.
  * [Table Format Converter](https://www.tableformatconverter.com) - Alat gratis untuk mengonversi data tabel ke format yang berbeda, seperti CSV, HTML, JSON, Markdown, dan lainnya.


**[⬆️ Kembali ke Atas](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---