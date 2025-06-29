<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

 Platform yang tangguh dan dapat di-deploy secara lokal, dirancang untuk deteksi SQL yang mulus dan audit query, disesuaikan khusus untuk DBA dan pengembang. Berfokus pada privasi dan efisiensi, Yearning menyediakan lingkungan intuitif dan aman untuk audit MYSQL.

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ Fitur

- **AI Assistant**: Asisten AI kami memberikan saran optimasi SQL secara real-time, meningkatkan performa SQL. Juga mendukung konversi teks-ke-SQL, memungkinkan pengguna memasukkan bahasa alami dan menerima pernyataan SQL yang telah dioptimalkan.
  
- **Audit SQL**: Buat tiket audit SQL dengan alur persetujuan dan pemeriksaan sintaks otomatis. Validasi pernyataan SQL untuk memastikan kebenaran, keamanan, dan kepatuhan. Pernyataan rollback dibuat secara otomatis untuk operasi DDL/DML, dengan log riwayat komprehensif untuk pelacakan.

- **Audit Query**: Audit query pengguna, batasi sumber data dan basis data, serta anonimisasi field sensitif. Catatan query disimpan untuk referensi di masa depan.

- **Aturan Pemeriksaan**: Pemeriksa sintaks otomatis kami mendukung berbagai aturan pemeriksaan, cocok untuk sebagian besar skenario pemeriksaan otomatis.

- **Fokus Privasi**: Yearning adalah solusi open-source yang dapat di-deploy secara lokal, memastikan keamanan basis data dan pernyataan SQL Anda. Termasuk mekanisme enkripsi untuk melindungi data sensitif, memastikan tetap aman bahkan jika terjadi akses tidak sah.

- **RBAC (Kontrol Akses Berbasis Peran)**: Buat dan kelola peran dengan izin spesifik, membatasi akses ke work order query, fungsi audit, dan operasi sensitif lainnya berdasarkan peran pengguna.

> \[!TIP]
> Untuk informasi lebih detail, kunjungi [Panduan Yearning](https://next.yearning.io)


## ⚙️ Instalasi

Unduh [rilis terbaru](https://github.com/cookieY/Yearning/releases/latest) dan ekstrak. Pastikan Anda sudah mengkonfigurasi `./config.toml` sebelum melanjutkan.

### Instalasi Manual

```bash
## Inisialisasi basis data
./Yearning install

## Jalankan Yearning
./Yearning run

## Bantuan
./Yearning --help
```

### 🚀 Deploy dengan Docker
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## Inisialisasi basis data
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Jalankan Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 Bantuan AI

AI Assistant kami memanfaatkan model bahasa besar untuk memberikan saran optimasi SQL dan konversi teks-ke-SQL. Baik menggunakan prompt default maupun kustom, AI Assistant meningkatkan performa SQL dengan mengoptimalkan pernyataan dan mengubah input bahasa alami menjadi query SQL.

![Text to SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 Pemeriksa SQL Otomatis

Pemeriksa SQL otomatis mengevaluasi pernyataan SQL terhadap aturan dan sintaks yang telah ditentukan. Ini memastikan bahwa pernyataan memenuhi standar kode tertentu, praktik terbaik, dan persyaratan keamanan, memberikan lapisan validasi yang kuat.

![SQL Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 Highlight Sintaks SQL dan Auto-completion

Tingkatkan efisiensi penulisan query Anda dengan highlight sintaks SQL dan auto-completion. Fitur ini membantu pengguna membedakan secara visual berbagai komponen query SQL, seperti kata kunci, nama tabel, nama kolom, dan operator, sehingga lebih mudah membaca dan memahami struktur query.

![SQL Query](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ Catatan Order/Query

Platform kami mendukung audit terhadap pernyataan order dan query pengguna. Fitur ini memungkinkan Anda melacak dan merekam seluruh operasi query, termasuk sumber data, basis data, dan penanganan field sensitif, memastikan kepatuhan terhadap regulasi serta memberikan pelacakan atas riwayat query.

![Order/Query Record](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

Dengan fokus pada fitur-fitur utama ini, Yearning meningkatkan pengalaman pengguna, mengoptimalkan performa SQL, dan memastikan kepatuhan serta pelacakan yang kuat dalam operasi basis data.

## 🛠️ Alat yang Direkomendasikan

- [Spug - Platform Otomasi Operasi Open Source Lightweight](https://github.com/openspug/spug)

## ☎️ Kontak

Untuk pertanyaan, silakan email ke: henry@yearning.io
## 📋 Lisensi

Yearning dilisensikan di bawah lisensi AGPL. Lihat [LICENSE](LICENSE) untuk detailnya.

2024 © Henry Yee

---

Dengan Yearning, rasakan pendekatan yang lebih efisien, aman, dan terstruktur untuk audit dan optimasi SQL.


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---