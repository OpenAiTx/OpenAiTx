
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=en">Inggris</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ja">Jepang</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ko">Korea</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fr">Prancis</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=de">Jerman</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=es">Spanyol</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=it">Italia</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ru">Rusia</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pt">Portugis</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=nl">Belanda</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ar">Arab</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fa">Persia</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=tr">Turki</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=vi">Vietnam</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# SimpleLogin

Ini adalah konfigurasi docker-compose self-hosted untuk [SimpleLogin](https://simplelogin.io).

## Prasyarat

- server Linux (bisa berupa VM atau server fisik). Dokumen ini menunjukkan pengaturan untuk Ubuntu 18.04 LTS tetapi langkah-langkahnya dapat disesuaikan untuk distribusi Linux populer lainnya. Karena sebagian besar komponen berjalan sebagai container Docker dan Docker bisa cukup berat, disarankan memiliki minimal 2 GB RAM. Server harus memiliki port 25 (email), 80, 443 (untuk webapp), 22 (supaya Anda bisa ssh ke dalamnya) terbuka.

- sebuah domain yang dapat Anda konfigurasikan DNS-nya. Ini bisa berupa sub-domain. Dalam dokumen ini, misalkan domainnya adalah `mydomain.com` untuk email dan `app.mydomain.com` untuk webapp SimpleLogin. Pastikan untuk mengganti nilai ini dengan nama domain dan subdomain Anda setiap kali muncul di dokumen. Trik yang biasa kami gunakan adalah mengunduh file README ini ke komputer Anda dan mengganti semua kemunculan `mydomain.com` dan `app.mydomain.com` dengan domain Anda.

Kecuali untuk pengaturan DNS yang biasanya dilakukan di antarmuka registrar domain Anda, semua langkah di bawah ini harus dilakukan di server Anda. Perintah dijalankan dengan `bash` (atau shell yang kompatibel dengan bash seperti `zsh`) sebagai shell. Jika Anda menggunakan “shell” lain seperti `fish`, pastikan untuk menyesuaikan perintahnya.

- Beberapa paket utilitas yang digunakan untuk memverifikasi pengaturan. Instal dengan:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## Konfigurasi DNS

_Lihat [dokumentasi referensi](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) untuk detail lebih lanjut_

> **Harap diperhatikan** bahwa perubahan DNS dapat memerlukan waktu hingga 24 jam untuk tersebar. Namun, dalam praktiknya biasanya jauh lebih cepat (~1 menit dalam pengujian kami). Dalam pengaturan DNS, kita biasanya menggunakan domain dengan tanda titik (`.`) di akhir untuk memaksa penggunaan domain absolut.

Anda perlu mengatur catatan DNS berikut:

- **A**: Memetakan domain Anda ke alamat IPv4 server Anda.
- **AAAA**: Memetakan domain Anda ke alamat IPv6 server Anda.
- **MX**: Mengarahkan email masuk ke server email Anda (termasuk wildcard `*`).
- **PTR**: Memetakan alamat IP server Anda kembali ke nama domain Anda.

Siapkan kebijakan keamanan wajib berikut:

- **DKIM**: Menandatangani email keluar secara digital untuk memverifikasi keasliannya.
- **DMARC**: Mendefinisikan bagaimana penerima email harus menangani pesan yang gagal otentikasi.
- **SPF**: Memberikan otorisasi kepada server email tertentu untuk mengirim email dari domain Anda.

Langkah tambahan:

- **CAA**: Menentukan otoritas sertifikat mana yang diizinkan untuk menerbitkan sertifikat SSL untuk domain Anda.
- **MTA-STS**: Memastikan koneksi yang aman dan terenkripsi antar server email.
- **TLS-RPT**: Melaporkan kegagalan koneksi TLS untuk meningkatkan keamanan pengiriman email.

**Peringatan**: menyiapkan catatan CAA akan membatasi otoritas sertifikat mana yang dapat menerbitkan sertifikat SSL untuk domain Anda.
Ini akan mencegah penerbitan sertifikat dari server staging Let’s Encrypt. Anda mungkin ingin menunda penambahan catatan DNS ini hingga sertifikat SSL berhasil diterbitkan untuk domain Anda.

## Docker

Jika Anda belum menginstal Docker di server Anda, silakan ikuti langkah-langkah pada [Docker CE untuk Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) untuk menginstal Docker.

Anda juga dapat menginstal Docker menggunakan skrip [docker-install](https://github.com/docker/docker-install) yang

```bash
curl -fsSL https://get.docker.com | sh
```

Aktifkan IPv6 untuk [jaringan bridge default](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```

Prosedur ini akan memandu Anda menjalankan seluruh stack menggunakan kontainer Docker.
Ini mencakup:

- traefik
- Kontainer [SimpleLogin app](https://github.com/simple-login/app)
- postfix

Jalankan SimpleLogin dari kontainer Docker:

1. Clone repository ini ke `/opt/simplelogin`
1. Salin `.env.example` ke `.env` dan atur nilai yang sesuai.

    - setel variabel `DOMAIN` ke domain Anda.
    - setel variabel `SUBDOMAIN` ke domain Anda. Nilai default adalah `app`.
    - setel variabel `POSTGRES_USER` agar sesuai dengan kredensial postgres (jika memulai dari awal, gunakan `simplelogin`).
    - setel `POSTGRES_PASSWORD` agar sesuai dengan kredensial postgres (jika memulai dari awal, tetapkan ke kunci acak).
    - setel `FLASK_SECRET` ke kunci rahasia sembarang.

### Postgres SQL

Repository ini menjalankan postgres SQL di dalam kontainer Docker.

**Peringatan**: versi sebelumnya dari repository ini menjalankan versi `12.1`.
Silakan merujuk ke [dokumentasi referensi](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) untuk detail lebih lanjut dan
instruksi upgrade.

### Menjalankan aplikasi

Jalankan aplikasi menggunakan perintah berikut:

```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

Anda mungkin ingin mengatur [Certificate Authority Authorization (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) pada tahap ini.

## Langkah selanjutnya

Jika semua langkah di atas berhasil, buka <https://app.mydomain.com/> dan buat akun pertama Anda!

Secara default, akun baru bukan premium sehingga tidak memiliki alias tanpa batas. Untuk menjadikan akun Anda premium,
silakan masuk ke database, tabel "users" dan setel kolom "lifetime" menjadi "1" atau "TRUE":

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

Setelah Anda membuat semua akun login yang diinginkan, tambahkan baris ini ke `.env` untuk menonaktifkan pendaftaran lebih lanjut:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```
Kemudian, untuk memulai ulang aplikasi web, terapkan: `docker compose restart app`

## Lain-lain

### Konfigurasi Postfix - Spamhaus

Proyek Spamhaus memelihara daftar alamat IP yang dikenal sebagai sumber SPAM.
Anda dapat memeriksa apakah alamat IP tertentu ada dalam daftar tersebut dengan mengirimkan query ke infrastruktur DNS.

Karena Spamhaus memblokir query yang berasal dari DNS-Resolver publik (open) (lihat: <https://check.spamhaus.org/returnc/pub>) dan kontainer postfix Anda mungkin menggunakan
resolver publik secara default, disarankan untuk mendaftar layanan gratis
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
dan memperoleh kunci Spamhaus DQS.

Tempelkan kunci ini sebagai `SPAMHAUS_DQS_KEY` dalam `.env` Anda

Jika tidak ada kunci DQS yang diberikan, kontainer postfix Anda akan memeriksa apakah mirror publik Spamhaus menerima query-nya dan menggunakannya sebagai gantinya.
Jika Spamhaus menolak query dari kontainer postfix Anda ke mirror publik, maka akan dinonaktifkan sepenuhnya.

### Konfigurasi Postfix - Alias virtual

Konfigurasi postfix mendukung alias virtual menggunakan file `postfix/conf.d/virtual` dan `postfix/conf.d/virtual-regexp`.
File-file tersebut secara otomatis dibuat saat startup berdasarkan [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
dan file template [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl).

Konfigurasi default adalah sebagai berikut:

#### virtual.tpl

File `virtual` mendukung pengaturan `virtual_alias_maps` pada postfix.
File ini mencakup aturan yang memetakan `unknown@mydomain.com` ke `contact@mydomain.com` untuk mendemonstrasikan penerimaan
dan email dari alamat tertentu yang tidak sesuai dengan alias yang ada, ke alamat lain yang memang ada.


```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

File `virtual-regexp` mendukung pengaturan postfix `virtual_alias_maps`.
File ini mencakup aturan yang mengubah email yang ditujukan ke subdomain sembarang, yang tidak sesuai
dengan alias yang ada, menjadi alias baru yang termasuk dalam direktori yang namanya diambil dari subdomain tersebut.
Alias tersebut dapat dibuat secara otomatis jika belum ada.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

Misalnya, email yang dikirim ke `someone@directory.mydomain.com` akan diarahkan ke `directory/someone@mydomain.com` oleh postfix.

## Cara Upgrade dari 3.4.0

_Bagian ini telah dipindahkan ke [dokumentasi referensi](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## Cara Upgrade dari pengaturan berbasis NGinx sebelumnya

_Bagian ini telah dipindahkan ke [dokumentasi referensi](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---