![Gambar Banner](https://user-images.githubusercontent.com/10284570/173569848-c624317f-42b1-45a6-ab09-f0ea3c247648.png)

# n8n - Otomasi Workflow Aman untuk Tim Teknis

n8n adalah platform otomasi workflow yang memberikan fleksibilitas kode bagi tim teknis dengan kecepatan tanpa kode (no-code). Dengan lebih dari 400 integrasi, kemampuan AI native, dan lisensi fair-code, n8n memungkinkan Anda membangun otomasi yang kuat sambil tetap menjaga kontrol penuh atas data dan deployment Anda.

![n8n.io - Screenshot](https://raw.githubusercontent.com/n8n-io/n8n/master/assets/n8n-screenshot-readme.png)

## Kemampuan Utama

- **Kode Saat Diperlukan**: Tulis JavaScript/Python, tambahkan paket npm, atau gunakan antarmuka visual
- **Platform AI-Native**: Bangun workflow agen AI berbasis LangChain dengan data dan model Anda sendiri
- **Kontrol Penuh**: Self-host dengan lisensi fair-code kami atau gunakan [layanan cloud](https://app.n8n.cloud/login) kami
- **Siap Enterprise**: Izin lanjutan, SSO, dan deployment air-gapped
- **Komunitas Aktif**: 400+ integrasi dan 900+ [template](https://n8n.io/workflows) siap pakai

## Mulai Cepat

Coba n8n secara instan dengan [npx](https://docs.n8n.io/hosting/installation/npm/) (memerlukan [Node.js](https://nodejs.org/en/)):

```
npx n8n
```

Atau deploy dengan [Docker](https://docs.n8n.io/hosting/installation/docker/):

```
docker volume create n8n_data
docker run -it --rm --name n8n -p 5678:5678 -v n8n_data:/home/node/.n8n docker.n8n.io/n8nio/n8n
```

Akses editor di http://localhost:5678

## Sumber Daya

- 📚 [Dokumentasi](https://docs.n8n.io)
- 🔧 [400+ Integrasi](https://n8n.io/integrations)
- 💡 [Contoh Workflow](https://n8n.io/workflows)
- 🤖 [Panduan AI & LangChain](https://docs.n8n.io/langchain/)
- 👥 [Forum Komunitas](https://community.n8n.io)
- 📖 [Tutorial Komunitas](https://community.n8n.io/c/tutorials/28)

## Dukungan

Butuh bantuan? Forum komunitas kami adalah tempat untuk mendapatkan dukungan dan terhubung dengan pengguna lain:
[community.n8n.io](https://community.n8n.io)

## Lisensi

n8n adalah [fair-code](https://faircode.io) yang didistribusikan di bawah [Sustainable Use License](https://github.com/n8n-io/n8n/blob/master/LICENSE.md) dan [n8n Enterprise License](https://github.com/n8n-io/n8n/blob/master/LICENSE_EE.md).

- **Source Available**: Kode sumber selalu terlihat
- **Self-Hostable**: Dapat dideploy di mana saja
- **Extensible**: Tambahkan node dan fungsionalitas Anda sendiri

[Lisensi Enterprise](mailto:license@n8n.io) tersedia untuk fitur tambahan dan dukungan.

Informasi tambahan tentang model lisensi dapat ditemukan di [dokumentasi](https://docs.n8n.io/reference/license/).

## Kontribusi

Menemukan bug 🐛 atau punya ide fitur ✨? Cek [Panduan Kontribusi](https://github.com/n8n-io/n8n/blob/master/CONTRIBUTING.md) kami untuk memulai.

## Bergabung dengan Tim

Ingin membentuk masa depan otomasi? Lihat [lowongan pekerjaan](https://n8n.io/careers) kami dan bergabunglah dengan tim kami!

## Apa arti n8n?

**Jawaban singkat:** Itu berarti "nodemation" dan dibaca sebagai n-eight-n.

**Jawaban panjang:** "Saya sering mendapatkan pertanyaan itu (lebih sering dari yang saya harapkan) jadi saya putuskan sebaiknya dijawab di sini. Saat mencari nama yang bagus untuk proyek ini dengan domain yang masih tersedia, saya cepat sadar bahwa semua nama bagus yang terpikirkan sudah diambil. Akhirnya, saya memilih 'nodemation'. 'node-' dalam arti menggunakan Node-View dan Node.js, serta '-mation' untuk 'automation' yang memang menjadi tujuan proyek ini. Namun, saya tidak suka dengan nama yang terlalu panjang dan tidak bisa membayangkan menulis sepanjang itu setiap kali di CLI. Maka akhirnya saya memilih 'n8n'." - **Jan Oberhauser, Pendiri dan CEO, n8n.io**

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---