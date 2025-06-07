<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  Gerbang AI
</h1>
<h4 align="center"> API Gateway AI Native </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**Situs Resmi**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCP Server QuickStart**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm Plugin Hub**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Apa itu Higress?

Higress adalah gateway API cloud-native yang berbasis pada Istio dan Envoy, yang dapat diperluas dengan plugin Wasm yang ditulis dalam Go/Rust/JS. Higress menyediakan puluhan plugin siap pakai untuk kebutuhan umum serta konsol siap guna (coba [demo di sini](http://demo.higress.io/)).

### Kasus Penggunaan Inti

Kemampuan gateway AI Higress mendukung semua [penyedia model utama](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) baik dalam maupun luar negeri. Higress juga mendukung hosting Server MCP (Model Context Protocol) melalui mekanisme pluginnya, memungkinkan AI Agent dengan mudah memanggil berbagai alat dan layanan. Dengan [alat openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver), Anda dapat dengan cepat mengonversi spesifikasi OpenAPI menjadi server MCP jarak jauh untuk dihosting. Higress menyediakan manajemen terpadu untuk API LLM maupun MCP.

**🌟 Coba sekarang di [https://mcp.higress.ai/](https://mcp.higress.ai/)** untuk merasakan secara langsung Server MCP Remote yang dihosting oleh Higress:

![Higress MCP Server Platform](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### Adopsi oleh Perusahaan

Higress lahir di Alibaba untuk mengatasi masalah reload Tengine yang mempengaruhi layanan koneksi panjang dan keterbatasan kemampuan load balancing untuk gRPC/Dubbo. Dalam Alibaba Cloud, kemampuan gateway AI Higress mendukung aplikasi AI inti seperti studio model Tongyi Bailian, platform machine learning PAI, dan layanan AI penting lainnya. Alibaba Cloud telah membangun produk API gateway cloud-native berbasis Higress, menyediakan layanan gateway dengan jaminan high availability 99,99% untuk banyak pelanggan enterprise.

## Ringkasan

- [**Quick Start**](#quick-start)    
- [**Feature Showcase**](#feature-showcase)
- [**Use Cases**](#use-cases)
- [**Core Advantages**](#core-advantages)
- [**Community**](#community)

## Quick Start

Higress dapat dijalankan hanya dengan Docker, sehingga memudahkan pengembang individu untuk setup lokal guna belajar atau membangun situs sederhana:

```bash
# Membuat direktori kerja
mkdir higress; cd higress
# Menjalankan higress, file konfigurasi akan ditulis ke direktori kerja
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

Penjelasan port:

- Port 8001: Masuk ke UI konsol Higress
- Port 8080: Masuk protokol HTTP gateway
- Port 8443: Masuk protokol HTTPS gateway

> Semua image Docker Higress menggunakan repository image milik Higress sendiri dan tidak terpengaruh oleh batas rate Docker Hub.
> Selain itu, pengiriman dan pembaruan image dilindungi oleh mekanisme pemindaian keamanan (didukung oleh Alibaba Cloud ACR), sehingga sangat aman digunakan di lingkungan produksi.
> 
> Jika Anda mengalami timeout saat menarik image dari `higress-registry.cn-hangzhou.cr.aliyuncs.com`, Anda dapat mencoba menggantinya dengan sumber mirror docker registry berikut:
> 
> **Asia Tenggara**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

Untuk metode instalasi lain seperti deployment Helm di K8s, silakan merujuk ke [dokumentasi Quick Start resmi](https://higress.io/en-us/docs/user/quickstart).

## Use Cases

- **Hosting MCP Server**:

  Higress menghosting MCP Server melalui mekanisme pluginnya, memungkinkan AI Agent dengan mudah memanggil berbagai alat dan layanan. Dengan [alat openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver), Anda dapat dengan cepat mengonversi spesifikasi OpenAPI menjadi server MCP jarak jauh.

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Manfaat utama hosting MCP Server dengan Higress:
  - Mekanisme otentikasi dan otorisasi terpadu
  - Rate limiting yang detail untuk mencegah penyalahgunaan
  - Audit log komprehensif untuk semua pemanggilan alat
  - Observabilitas kaya untuk pemantauan kinerja
  - Deployment yang disederhanakan melalui mekanisme plugin Higress
  - Update dinamis tanpa gangguan atau putus koneksi

     [Pelajari lebih lanjut...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **AI Gateway**:

  Higress menghubungkan semua penyedia model LLM menggunakan protokol terpadu, dengan observabilitas AI, load balancing multi-model, pembatasan laju token, dan kemampuan caching:

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetes ingress controller**:

  Higress dapat berfungsi sebagai ingress controller kaya fitur, dan kompatibel dengan banyak anotasi dari nginx ingress controller K8s.
  
  Dukungan untuk [Gateway API](https://gateway-api.sigs.k8s.io/) akan segera hadir dan akan mendukung migrasi mulus dari Ingress API ke Gateway API.
  
- **Microservice gateway**:

  Higress dapat berfungsi sebagai gateway microservice, yang dapat menemukan microservice dari berbagai service registry, seperti Nacos, ZooKeeper, Consul, Eureka, dll.
  
  Integrasi mendalam dengan [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) dan stack teknologi microservice lainnya.
  
- **Security gateway**:

  Higress dapat digunakan sebagai security gateway, mendukung WAF dan berbagai strategi otentikasi, seperti key-auth, hmac-auth, jwt-auth, basic-auth, oidc, dll.


## Core Advantages

- **Production Grade**

  Lahir dari produk internal Alibaba dengan validasi produksi lebih dari 2 tahun, mendukung skenario skala besar dengan ratusan ribu permintaan per detik.

  Sepenuhnya menghilangkan jitter trafik akibat reload Nginx, perubahan konfigurasi berlaku dalam milidetik dan transparan untuk bisnis. Sangat ramah untuk skenario koneksi panjang seperti bisnis AI.

- **Streaming Processing**

  Mendukung pemrosesan streaming permintaan/response body secara penuh, plugin Wasm dapat dengan mudah mengustomisasi penanganan protokol streaming seperti SSE (Server-Sent Events).

  Pada skenario bandwidth tinggi seperti bisnis AI, dapat secara signifikan mengurangi konsumsi memori.
    
- **Mudah Diperluas**
  
  Menyediakan pustaka plugin resmi yang kaya, mencakup AI, manajemen trafik, perlindungan keamanan dan fungsi umum lainnya, memenuhi lebih dari 90% kebutuhan skenario bisnis.

  Fokus pada ekstensi plugin Wasm, memastikan keamanan memori melalui isolasi sandbox, mendukung berbagai bahasa pemrograman, memungkinkan upgrade versi plugin secara mandiri, dan mendukung hot update logika gateway tanpa kehilangan trafik.

- **Aman dan Mudah Digunakan**
  
  Berdasarkan standar Ingress API dan Gateway API, menyediakan UI konsol siap pakai, plugin perlindungan WAF, plugin perlindungan CC IP/Cookie siap digunakan.

  Mendukung koneksi ke Let's Encrypt untuk penerbitan dan perpanjangan sertifikat gratis secara otomatis, serta dapat dijalankan di luar K8s, cukup dengan satu perintah Docker, memudahkan pengembang individu untuk menggunakan.

## Community

Bergabunglah dengan komunitas Discord kami! Di sini Anda dapat terhubung dengan pengembang dan pengguna Higress lainnya yang antusias.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### Terima Kasih

Higress tidak akan mungkin ada tanpa kontribusi open-source yang berharga dari proyek-proyek komunitas. Kami ingin mengucapkan terima kasih khusus kepada Envoy dan Istio.

### Repositori Terkait

- Higress Console: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### Kontributor

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="kontributor" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### Riwayat Star

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ Kembali ke Atas ↑
    </a>
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---