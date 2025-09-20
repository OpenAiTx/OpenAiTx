
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
Dump PIC16/Xyclops dari Xbox asli dan database IDA dengan beberapa rekayasa balik yang telah dilakukan.

![Gambar PIC16LC63A dari Xbox asli](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Xyclops flashing (XycloMod)
Lihat [direktori dan README Xyclops](/Xyclops)

# Dump
File .bin untuk setiap dump PIC memiliki byte yang ditukar agar dapat dimuat dengan benar ke dalam IDA. Jadi word pertama dari memori PIC adalah byte_0 + byte_1 << 8.

Database .idb IDA memiliki info tentang variabel dan beberapa observasi pada notepad database.

Lihat halaman wiki ini untuk rincian versi SMC: https://xboxdevwiki.net/Xboxen_Info

## B2A
Didump dari Xbox DVT3. Kata konfigurasi sama dengan P01. Juga memiliki ID perangkat yang ditanamkan di area konfigurasi sebagai 0000 0000 000B 002A, tidak seperti PIC produksi.

Tantangan boot benar-benar hilang.

## D01
Didump dari Xbox XDK BETA 2. Identik dengan P01 kecuali tantangan boot yang hilang. Fungsi untuk menghitung respons tantangan boot yang diharapkan masih ada, tetapi tidak pernah dipanggil.

## DXF
Didump dari kit debug XDK D2. Sangat mirip dengan D01 tetapi dengan logika tray, logika overheat, dan logika boot yang sedikit berbeda. Tantangan boot hilang dengan cara yang sama seperti D01.

## D2E
Didump dari kit dev Tuscany (v1.6). Chip Xyclops diberi label X01202-001, dan tidak memiliki jalur A-A02 atau A-B01 yang ada di unit retail.

Kode serial debug di FC00 cocok dengan dump P2L retail. Ada pola data aneh dari 0x4000 hingga 0xFBFF.

## P01
Didump dari Xbox v1.0. Kata konfigurasi adalah 0x86:
- CP1:CP0 = 0 (Proteksi Kode diaktifkan untuk seluruh memori)
- BODEN = 0 (Reset Brown-out dinonaktifkan)
- ~PWRTE = 0 (Timer Power-up diaktifkan)
- WDTE = 1 (Watchdog Timer diaktifkan)
- FOSC1:FOSC0 = 2 (Osilator HS)

Nilai konfigurasi 0x3FB6 cocok untuk klon SMC agar tidak mengaktifkan proteksi kode.

## P11
Didump dari Xbox v1.3. Kata konfigurasi sama seperti P01.

Ada beberapa perubahan kecil pada P11 dibandingkan P01 termasuk satu perintah SMBus tambahan (write 0x22), prioritas LED yang berbeda, dan waktu boot yang lebih longgar.

Saya memeriksa dump terenkripsi dari v1.3 terhadap v1.4 dan hasilnya cocok. Ini berarti kemungkinan besar mereka memiliki program yang sama.

## P2L
Didump dari Xbox v1.6. Xyclops revisi A-A02. Berisi kode Intel 8051 tetapi memiliki banyak register fungsi khusus yang fungsinya tidak diketahui.

Serial debug diaktifkan oleh kode di FC00. Tampaknya seperti debugger sederhana yang bisa menghentikan eksekusi, membuang data, dan menulis ke register/RAM.

# Pembuangan Xyclops

Chip Xyclops memiliki 3 pin untuk 'debug': TXD (pin 64), RXD (pin 63), dan DEBUG (pin 29). Setel pin DEBUG ke tinggi untuk mengaktifkan port serial pada pin TX dan RX. Serial beroperasi pada 9600 baud.

Protokolnya berbasis pada perintah 4-byte yang biasanya berformat `<cmd>` `<address MSByte>` `<address LSByte>` `<don't care>`

Perintah 0x14 membuang 64 byte data BIOS sekaligus dan 0x15 membuang 64 byte data program SMC sekaligus. Dump dari Xyclops, P2L.bin, disertakan dalam repo. [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) juga disediakan agar Anda bisa membuang mesin Anda sendiri.

# Metodologi pembuangan PIC
Penulisan lengkap di https://wiki.recessim.com/view/PIC_Burnout

PIC memiliki perlindungan kode aktif sehingga semua data terbaca sebagai 0000. Saya menggunakan trik untuk mendapatkan output data acak, menemukan algoritma pengacak menggunakan chip pengorbanan, lalu menggunakan semacam eksploit untuk mengubah data ROM agar beberapa bit tetap pada nilai tertentu. Kemudian saya bisa mengekstrak informasi yang dibutuhkan dari beberapa dump acak untuk merekonstruksi data asli.

# PICProgrammer
PICProgrammer adalah salah satu dari beberapa proyek Arduino untuk RP2040 yang saya gunakan dalam penelitian. Ini menyediakan antarmuka command-line sederhana untuk menjalankan operasi ICSP (in-circuit serial programming) pada PIC. Ini lebih disukai dibandingkan programmer khusus seperti PICkit karena fleksibilitasnya dan opsi melakukan hal-hal yang tidak dimaksudkan oleh produsen.

Anda harus memiliki pemahaman yang baik tentang elektronika dan pemrograman sebelum menggunakan ini, dan pelajari dengan seksama apa yang dilakukan setiap perintah sebelum mengeksekusinya.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---