# kkTerminal

> kkTerminal, sebuah terminal untuk koneksi Web SSH
>
> Penulis: [zyyzyykk](https://github.com/zyyzyykk/)
>
> Kode Sumber: https://github.com/zyyzyykk/kkTerminal
>
> Alamat Docker Hub: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> Pratinjau: https://ssh.kkbpro.com/
>
> Waktu Pembaruan: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ Integrasi Cepat

Menggunakan tag `iframe` dalam halaman web HTML untuk integrasi cepat:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 Deploy dengan Docker

1. Tarik image:

```bash
docker pull zyyzyykk/kkterminal
```

2. Buat dan jalankan container untuk pemetaan port: `-p port:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. Kustomisasi kata seni: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. Akses di browser: `http://server-ip:3000/`

### 🛸 Pratinjau

Kunjungi situs berikut: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**Pratinjau Modul Lainnya**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 Deskripsi Fungsi

1. kkTerminal adalah terminal untuk koneksi Web SSH. Klik ikon terminal di pojok kiri atas dan pilih pengaturan koneksi untuk membuat koneksi SSH

2. Mendukung penggunaan tag `iframe` di halaman web untuk integrasi cepat ke situs pihak ketiga

3. Mendukung kustomisasi konfigurasi terminal melalui [Parameter URL](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)

4. Mendukung internasionalisasi dan pergantian bahasa antara Tionghoa dan Inggris

5. Mendukung deployment lokal di PC, secara otomatis membuka jendela browser saat startup

6. Mendukung ukuran jendela yang adaptif dan input bahasa Tionghoa

7. Mendukung pengaturan preferensi kustom, memungkinkan pengguna memilih warna latar depan/belakang, ukuran font, gaya tampilan kursor, mengaktifkan TCode untuk terminal, dll

8. Mendukung restart: Akan otomatis restart setelah mengubah pengaturan koneksi SSH atau pengaturan preferensi, atau bisa di-restart manual setelah koneksi SSH terputus

9. Mendukung salin dan tempel:

   - Salin: Sama seperti terminal `Git`, memilih teks akan otomatis menyalinnya

   - Tempel: Sama seperti terminal `Cmd`, klik kanan untuk menempel (memerlukan izin akses browser)

9. Mendukung manajemen file, buka Modul Manajemen File untuk melihat, mengekstrak, mengunggah, dan mengunduh file/folder

10. Mendukung operasi shortcut key seperti seleksi multi/semua file, salin dan tempel, potong, pergantian seleksi, buka, dll

11. Mendukung penelusuran dan penyuntingan file, modifikasi file dan simpan ke server remote menggunakan `ctrl+s`

12. Mendukung [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md)，yang dapat mewujudkan Workflow otomatis seperti skrip Shell melalui TCode yang dikustomisasi

13. Mendukung perekaman operasi dan fungsi sinkronisasi cloud

14. Mendukung fungsi Cooperate, Monitor dan Docker

### 👨‍💻 Catatan Pembaruan

##### zyyzyykk/kkterminal:3.6.0: terbaru

- Menambah fungsi Cooperate Lanjutan
- Menambah fungsi Monitor Lanjutan
- Menambah fungsi Docker Lanjutan
- Optimasi volume paket & tampilan halaman web

##### zyyzyykk/kkterminal:3.5.6: 

- Mendukung lebih banyak parameter URL
- Menambah editor persentase ukuran teks & gambar
- Optimasi tampilan halaman web

##### zyyzyykk/kkterminal:3.5.3: 

- Menambah parameter URL untuk kustomisasi konfigurasi terminal
- Memperbaiki bug restart multi jendela
- Menambah fungsi perekaman operasi dan sinkronisasi cloud
- Refactoring logika kode tertentu

[**Catatan Pembaruan Historis**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 Arsitektur

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ Tentang proyek ini

Pengguna yang Terhormat,

Dengan menyesal saya mengumumkan bahwa karena keterbatasan waktu dan energi, saya tidak dapat melakukan pemeliharaan pada `kkTerminal` di masa mendatang.

Jika Anda tertarik dengan `kkTerminal` atau ingin melanjutkan pemeliharaan, silakan hubungi saya atau ajukan issue.

Jika Anda menemukan bug atau ingin mengembangkan fitur baru, silakan juga ajukan issue.

Terakhir, terima kasih atas dukungan Anda terhadap `kkTerminal` dan saya sungguh berharap `kkTerminal` dapat benar-benar membantu Anda.

Salam Hormat,

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 Stars

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---