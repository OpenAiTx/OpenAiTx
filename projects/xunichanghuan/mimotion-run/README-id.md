# mimotion
![刷步数](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# Xiaomi Mi Fit Otomatis Menambah Jumlah Langkah

> Xiaomi Mi Fit Otomatis Menambah Jumlah Langkah

## Panduan Deploy Github Actions

### 1. Fork repositori ini

### 2. Atur Akun dan Kata Sandi
# 20230224 Penambahan baru
Tambahkan variabel bernama **CONFIG**: Settings-->Secrets-->New secret, konfigurasikan multi-akun menggunakan template json di bawah, mendukung email dan nomor ponsel
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN, jika tidak ada, biarkan kosong",
  "TG_USER_ID": "telegram TG_USER_ID, jika tidak ada, biarkan kosong",
  "SKEY": "Kukuai skey, jika tidak ada, biarkan kosong",
  "SCKEY": "server酱 sckey, jika tidak ada, biarkan kosong",
  "POSITION": "Apakah mengaktifkan push WeChat Perusahaan, jika tidak ada, biarkan kosong",
  "CORPID": "ID Perusahaan, login ke WeChat Perusahaan, lihat di Perusahaanku-->Informasi Perusahaan, jika tidak ada, biarkan kosong",
  "CORPSECRET": "Aplikasi yang dibuat sendiri di WeChat Perusahaan, setiap aplikasi memiliki secret terpisah, jika tidak ada, biarkan kosong",
  "AGENTID": "Isi dengan ID aplikasi buatan sendiri WeChat Perusahaan, tanpa tanda kutip, bilangan bulat, yaitu AgentId, jika tidak ada, biarkan kosong",
  "TOUSER": "Tentukan anggota penerima pesan, daftar ID anggota (beberapa penerima dipisahkan dengan ”&#166;”, maksimum 1000). Kasus khusus: jika diisi ”@all”, maka pesan dikirim ke semua anggota aplikasi perusahaan, jika tidak ada, biarkan kosong",
  "TOPARTY": "Tentukan departemen penerima pesan, daftar ID departemen, beberapa penerima dipisahkan dengan ”&#166;”, maksimum 100. Jika touser adalah ”@all”, isi ”@all”, jika tidak ada, biarkan kosong",
  "TOTAG": "Tentukan tag penerima pesan, daftar ID tag, beberapa penerima dipisahkan dengan ”&#166;”, maksimum 100. Jika touser adalah ”@all”, isi ”@all”, jika tidak ada, biarkan kosong",
  "OPEN_GET_WEATHER": "Aktifkan penyesuaian jumlah langkah sesuai cuaca daerah, jika tidak ada, biarkan kosong",
  "AREA": "Setel daerah untuk mendapatkan cuaca (wajib diisi jika diaktifkan di atas), misal Beijing, jika tidak ada, biarkan kosong",
  "QWEATHER": "Isi dengan Private KEY QWeather, ajukan di https://console.qweather.com/#/apps, jika tidak ada, biarkan kosong",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Isi jumlah langkah maksimum untuk multi-akun, lihat di atas",
      "min_step": "Isi jumlah langkah minimum untuk multi-akun, lihat di atas",
      "password": "Isi kata sandi untuk multi-akun, lihat di atas",
      "user": "Isi nomor ponsel untuk multi-akun, lihat di atas"
    }
  ]
}
```
> Tambahkan variabel bernama **PAT**: Settings-->Secrets-->New secret

| Secrets |  Format  |
| -------- | ----- |
| PAT |   **PAT** perlu diajukan, nilainya adalah token github, tutorial bisa dilihat di: https://www.jianshu.com/p/bb82b3ad1d11 , membutuhkan izin repo dan workflow, wajib diisi untuk menghindari error git push. |

**Contoh CONFIG**
```
{
  "TG_BOT_TOKEN": "",
  "TG_USER_ID": "",
  "SKEY": "",
  "SCKEY": "",
  "POSITION": "",
  "CORPID": "",
  "CORPSECRET": "",
  "AGENTID": "",
  "TOUSER": "",
  "TOPARTY": "",
  "TOTAG": "",
  "OPEN_GET_WEATHER": "",
  "AREA": "",
  "QWEATHER": "",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Isi jumlah langkah maksimum untuk multi-akun, lihat di atas",
      "min_step": "Isi jumlah langkah minimum untuk multi-akun, lihat di atas",
      "password": "Isi kata sandi untuk multi-akun, lihat di atas",
      "user": "Isi nomor ponsel untuk multi-akun, lihat di atas"
    }
  ]
}
```

### 3. Kustomisasi Waktu Start

Edit **random_cron.sh**
Ubah waktu pada pernyataan **if** ke waktu UTC, yaitu **Waktu Beijing-8**, misal jam 8 pagi waktu Beijing adalah jam 0 UTC, waktu yang ingin dijalankan dikurangi 8 adalah waktu UTC-nya



## Catatan

1. Berjalan tujuh kali sehari, dikontrol oleh random_cron.sh, menit diacak

2. Jumlah akun dan kata sandi harus sama! Jika tidak, tidak bisa digunakan!!!

3. Waktu start harus waktu UTC!

4. Daftar server酱: [Klik di sini](https://sct.ftqq.com/)

5. Jika Alipay tidak memperbarui jumlah langkah, buka Mi Fit->Pengaturan->Akun->Keluar akun->Bersihkan data, lalu login ulang dan bind ulang ke pihak ketiga

6. Mi Fit tidak akan memperbarui jumlah langkah, hanya yang terhubung yang akan sinkron!!!!!!!

7. Saat menggunakan, harap Fork dari [branch utama](https://github.com/xunichanghuan/mimotion-run/) untuk menghindari bug yang tidak perlu.

8. Akun yang digunakan bukan [Akun Xiaomi], melainkan akun [Mi Fit].

## Statistik Star Historis

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---