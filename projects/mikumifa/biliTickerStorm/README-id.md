# 🎫 BiliTickerStorm

## ⚙️ Penjelasan Layanan

| Nama Layanan         | Penjelasan                | Catatan        |
| ------------------- | ------------------------ | ------------- |
| `ticket-master`     | Layanan utama, bertanggung jawab untuk penjadwalan tugas | Deploy satu instance |
| `ticket-worker`     | Worker untuk rebut tiket, dapat diskalakan secara horizontal | Mendukung multi-instance |
| `gt-python`         | Layanan pemrosesan captcha gambar           | Deploy satu instance |

---

## 🚀 Langkah Cepat Deploy

> Pembangunan klaster dapat merujuk pada [Panduan Pembangunan Klaster](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md).

<details> <summary><strong>📦 Instalasi dari Repository Remote (Disarankan)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Instalasi Chart

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` adalah direktori file konfigurasi pembelian tiket, yang akan di-mount ke kontainer `ticket-master`. File konfigurasi pembelian tiket dapat dibuat menggunakan https://github.com/mikumifa/biliTickerBuy
> - `ticketWorker.pushplusToken` adalah konfigurasi pushplus untuk notifikasi, setelah diatur Anda dapat menerima pemberitahuan hasil pembelian tiket.
> - `ticketWorker.ticketInterval` adalah interval pembelian tiket dalam detik, default-nya adalah 300 milidetik.
> - `ticketWorker.ticketTimeStart` adalah waktu mulai terjadwal, formatnya `2025-05-20T13:14`. Jika tidak diisi, kontainer akan langsung memulai pembelian tiket saat dijalankan.

### 3. Upgrade Chart

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details> 
<details> <summary><strong>📦 Instalasi Chart Lokal</strong></summary>


### 1. Instalasi Chart

```bash
# Kloning repositori
git clone https://github.com/mikumifa/biliTickerStorm
# Gunakan paket Chart lokal
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Upgrade Chart

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 Perintah Umum</strong></summary>

### ⏹ Uninstall
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 Disclaimer

Proyek ini mengikuti lisensi MIT License dan hanya untuk pembelajaran serta penelitian pribadi. Dilarang menggunakan proyek ini untuk tujuan komersial apa pun, juga sangat dilarang untuk digunakan dalam bentuk perebutan otomatis, tindakan ilegal, atau penggunaan yang melanggar aturan platform terkait. Segala konsekuensi yang timbul sepenuhnya menjadi tanggung jawab pengguna dan tidak ada hubungannya dengan saya.

Jika Anda melakukan fork atau menggunakan proyek ini, harap pastikan untuk mematuhi hukum, peraturan, dan aturan platform target yang berlaku.

## 💡 Tentang Frekuensi Akses dan Kontrol Konkuren
Proyek ini dirancang dengan prinsip "non-intrusif" yang ketat, untuk menghindari gangguan apa pun pada server target (seperti Bilibili).

Semua interval waktu permintaan jaringan dapat dikonfigurasi sendiri oleh pengguna, dengan nilai default yang mensimulasikan kecepatan operasi manual pengguna normal. Program secara default berjalan dengan satu thread, tanpa tugas konkuren. Jika terjadi kegagalan permintaan, program akan mencoba ulang beberapa kali dengan penundaan yang sesuai di antara percobaan, untuk menghindari permintaan berfrekuensi tinggi. Proyek ini sepenuhnya bergantung pada antarmuka publik dan struktur halaman web platform, tanpa menggunakan cara-cara destruktif seperti penghindaran kontrol risiko atau pembajakan API.
## 🛡️ Pernyataan Penghormatan Platform

Program ini telah dirancang sedemikian rupa untuk mengontrol frekuensi permintaan, guna menghindari beban atau dampak yang signifikan terhadap server Bilibili. Proyek ini hanya digunakan untuk tujuan pembelajaran, tidak memiliki kemampuan skala besar atau tingkat konkurensi tinggi, serta tidak memiliki niat jahat atau upaya mengganggu layanan.

Jika terdapat konten dalam proyek ini yang melanggar hak dan kepentingan sah perusahaan Bilibili, silakan hubungi saya melalui email [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com). Saya akan segera menghapus konten terkait dan menghapus repositori ini. Saya mohon maaf atas ketidaknyamanan yang ditimbulkan, terima kasih atas pengertian dan toleransi Anda.

## 📄 Lisensi

[Lisensi MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---