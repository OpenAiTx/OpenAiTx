<h1 align="center">Selamat Datang di&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> Alat otomatisasi Cursor, Cursor otomatis lanjut, Cursor otomatis coba ulang, Cursor otomatis konfirmasi, Statistik pemakaian Cursor, Alat peningkatan Cursor, Alat bantu Cursor, Alat otomasi Cursor, Pengaturan tema Cursor, Cursor Auto Continue Tool, Cursor Auto Retry Tool, Cursor Auto Confirm Tool, Cursor Usage Statistics Tool, Cursor Efficiency Tool, Cursor Automation Tool, Cursor Theme Settings, Cursor after 25 tool calls, Cursor Tool Call Limit🔧🤖🚀
> 

## 🏠 [Beranda](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper adalah alat otomasi peningkatan yang dibuat khusus untuk Cursor IDE, dapat menampilkan pemakaian secara real-time, otomatis menangani batas 25 kali percakapan, kegagalan koneksi jaringan, konfirmasi, dan skenario lainnya, membuat pengalaman pengembangan Anda lebih lancar.

**Demo video:** [Video Demo Cursor Auto Helper](https://www.bilibili.com/video/BV1cajKzCEzv/)

Kualitas prompt tinggi, perencanaan kebutuhan proyek baik, program ini memungkinkan Cursor menyelesaikan proyek secara otomatis tanpa intervensi manual.

> 🔒 **Kompatibilitas Versi**: Saat ini telah diuji pada Cursor 0.49.6, Cursor 1.0.0, secara teori kompatibel dengan Cursor 0.48.x - 1.0.0.

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖Log Perubahan

- 2025-06-01 Rilis versi v2.3, menambah fitur pengaturan tema Cursor, mengoptimalkan stabilitas injeksi kode, memperbaiki tampilan pemakaian agar konsisten dengan format resmi
- 2025-05-21 Rilis versi v2.1, rekonstruksi arsitektur, mendukung multi-platform, menambah fitur tampilan pemakaian secara real-time, dll
- 2025-04-25 Selesai versi v1.0, otomatis menangani batas 25 kali percakapan, kegagalan koneksi jaringan, konfirmasi, dan skenario lainnya
- 2025-04-20 Proyek dimulai

## 🌟 Praktik Terbaik Cursor Auto Helper

Catatan: Dokumen berikut dapat dihasilkan oleh AI seperti Cursor, namun perlu verifikasi dan penyesuaian manual.

**LANGKAH 1:** Rancang kebutuhan sistem proyek secara detail (semakin jelas pemetaan kebutuhan, semakin tinggi kualitas proyek), tulis prompt pengembangan proyek berkualitas tinggi **SYSTEM.md**

**LANGKAH 2:** Berdasarkan **SYSTEM.md** keluarkan dokumen rencana desain pengembangan sistem berkualitas tinggi **DESIGN.md**

**LANGKAH 3:** Berdasarkan **SYSTEM.md** dan **DESIGN.md** keluarkan dokumen rencana pengembangan berkualitas tinggi **TODOLIST.md**

**LANGKAH 4:** Gunakan **Cursor Auto Helper**, tentukan **SYSTEM.md**, **DESIGN.md**, **TODOLIST.md**, gunakan prompt feedback otomatis lanjut, sehingga Cursor terus secara otomatis menyelesaikan pengembangan proyek sesuai rencana hingga selesai

**Prompt Feedback Otomatis Lanjut Cursor Auto Helper:**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md Mohon ikuti rencana pengembangan TODOLIST secara ketat untuk pengembangan fungsi selanjutnya, dan perbarui serta catat TODOLIST secara real-time. Setiap tugas selesai, harap tanyakan kepada saya "apakah lanjut?", hingga proyek selesai dan kembalikan "proyek telah selesai dikembangkan"
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 Petunjuk Penggunaan

Silakan berikan Star sebagai dukungan. Jika ada pertanyaan silakan buat [Issues](https://github.com/pen9un/cursor-auto-helper/issues).

### 📝 Penjelasan File Konfigurasi

File konfigurasi `config.ini` **digunakan untuk menyesuaikan perilaku otomasi** (dapat diatur dan diuji sesuai kebutuhan), mendukung item konfigurasi berikut:

#### Konfigurasi Dasar
```ini
[common]
log_enable = true     # Apakah mengaktifkan log, jika tidak ingin mencatat log bisa diubah ke false

[cursor]
path = C:\Path\To\Cursor.exe  # Jalur instalasi Cursor IDE, program akan otomatis mencari jalur Cursor, jika tidak ditemukan akan ada notifikasi, cukup ubah bagian ini
```

#### Konfigurasi Tindakan Otomatis
Setiap tindakan otomatis diawali dengan prefix `nama_action.`, mendukung field berikut:

- `type`: Jenis tindakan
  - `click`: Klik tombol
  - `input_and_submit`: Input dan kirim

- `text` / `text_list`: Konten teks yang dicocokkan
  - `text`: Satu string
  - `text_list`: Beberapa string dipisahkan dengan |, jika ada yang cocok di halaman akan memicu aksi

- `button_selector`: CSS selector tombol yang perlu diklik (hanya untuk tipe `click`)
- `button_text`: Teks pada tombol (opsional, memperjelas tombol)
- `input_box_selector`: CSS selector untuk kotak input (diperlukan untuk tipe `input_and_submit`)
- `input_content`: Konten yang perlu diinput secara otomatis
- `submit_btn_selector`: CSS selector untuk tombol submit
- `delay`: Delay sebelum eksekusi aksi (ms), bisa digunakan untuk menunggu rendering halaman

##### Contoh Konfigurasi
```ini
[auto_actions]
# Coba ulang otomatis saat koneksi gagal
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# after 25 tool calls
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "请继续"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_continue.delay = 1000

# Konfirmasi Lanjut Otomatis
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **Catatan:**
> 1. Nama setiap action (seperti `action_retry`, `action_continue`) dapat dikustomisasi, namun seluruh field dari action yang sama harus memiliki prefix yang konsisten
> 2. Disarankan menggunakan alat pengembang browser untuk menentukan CSS selector, demi memastikan keakuratannya
> 3. Setelah mengubah file konfigurasi, program harus direstart agar perubahan berlaku

## 🎯 Skenario Aplikasi

### 💼 Pengembangan Percakapan Panjang
- Otomatis menangani batas 25 kali percakapan, mendukung pengembangan percakapan panjang berkelanjutan, melanjutkan proses percakapan secara otomatis, meningkatkan efisiensi pengembangan.

### 👥 Jaringan Tidak Stabil
- Otomatis mendeteksi anomali jaringan, mencoba koneksi ulang secara cerdas, memulihkan percakapan secara otomatis, memastikan kesinambungan pengembangan.

### 🏢 Skenario Konfirmasi
- Mengenali secara cerdas skenario prompt konfirmasi, menangani prompt konfirmasi secara otomatis, mengurangi intervensi manual.

### 📚 Pemantauan Pemakaian
- Menghitung jumlah percakapan secara real-time, memantau penggunaan Cursor, merekam data penggunaan, mengoptimalkan efisiensi pemakaian.

Tampilan pemakaian di terminal:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Tampilan pemakaian di Cursor IDE:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟Penjelasan Fitur

### 🤖Otomatis Melanjutkan Percakapan Panjang
- Otomatis menangani batas 25 kali percakapan di Cursor, mendukung percakapan berkelanjutan multi putaran.

### 🎨 Otomatis Mencoba Koneksi Ulang
- Otomatis mendeteksi kegagalan koneksi jaringan, mencoba ulang secara cerdas, memantau status koneksi secara real-time.

### 📱 Otomatis Konfirmasi Prompt
- Mengenali berbagai skenario prompt konfirmasi secara cerdas, menangani pop-up konfirmasi secara otomatis.
- Mendukung kustomisasi isi konfirmasi dan respon, mengurangi intervensi manual.
- Aturan konfigurasi yang fleksibel, cocok untuk berbagai proses pengembangan.

### 🛍️ Statistik Pemakaian
- Menghitung jumlah percakapan dan pemakaian secara real-time, merekam data secara otomatis.
- Visualisasi data pemakaian, memudahkan analisa dan optimasi.
- Mendukung tampilan log berwarna di terminal, panel pemakaian di IDE, meningkatkan kegunaan.

### 💡 Sistem Log
- Log multi-level (DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL), output warna di terminal.
- File log dibuat otomatis berdasarkan tanggal, mendukung pencatatan file dan tampilan panel drag & drop.
- Panel real-time memudahkan developer untuk memantau dan menelusuri kembali.

### 🔒 Kompatibilitas Versi & Optimasi Performa
- Dikembangkan berbasis Cursor 0.49.6, semua fitur inti telah diuji lengkap.
- Optimasi untuk versi tertentu, terus mengikuti update versi Cursor.
- Stabil, kompatibilitas tinggi, cocok untuk lingkungan produksi.

## 🔮Demo Efek

### 🤖 Otomatis Melanjutkan Percakapan

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Demo Penyelesaian Program Otomatis Cursor

Dari kebutuhan proyek hingga implementasi lengkap, seluruh proses tanpa intervensi manual:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝Penulis

👤 **pen9un**

* Situs Web: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️Dukungan

Jika menurut Anda proyek ini bermanfaat, silakan beri bintang gratis ⭐️⭐️

## ✨Riwayat Star

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 Statistik Kunjungan

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---