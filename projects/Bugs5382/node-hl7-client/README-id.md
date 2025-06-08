# Node HL7 Client

> Klien HL7 murni TypeScript untuk Node.js yang memungkinkan komunikasi lancar dengan server HL7.

`node-hl7-client` adalah pustaka ringan tanpa dependensi, dibangun untuk komunikasi berkinerja tinggi dengan broker/server HL7. Mendukung pengiriman pesan HL7 yang terformat dengan benar, menangani respons, serta bekerja dengan format pesan HL7 tunggal maupun batch (MSH, BHS, dan FHS).

## ✨ Fitur

* ⚡ **Tanpa Dependensi Eksternal** – Performa sangat cepat tanpa beban tambahan.
* 🔁 **Auto Reconnect & Retry** – Secara otomatis menangani gangguan koneksi.
* 🧠 **TypeScript + Definisi Bertipe** – Sepenuhnya bertipe untuk lingkungan pengembangan modern.
* 🤝 **Paket Pendamping Tersedia** – Gunakan bersama [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server) untuk solusi HL7 yang lengkap.
* 💻 **Dukungan Lintas Platform** – Berjalan di Windows, macOS, dan Linux.
* 🧭 **Berbasis Standar** – Builder bertipe memastikan segmen MSH, BHS, dan FHS mengikuti spesifikasi HL7.org.

## 📦 Instalasi

```bash
npm install node-hl7-client
```

## 📚 Apa Saja yang Termasuk?

* **HL7 Client** – Menghubungkan ke server HL7 jarak jauh, mengirim pesan, dan memproses respons.
* **HL7 Parser** – Mengurai string pesan HL7 mentah menjadi segmen yang mudah diakses.
* **HL7 Builder** – Membangun pesan HL7 yang valid, batch, atau berkas batch HL7 lengkap.

## 🧾 Daftar Isi

1. [Definisi Kata Kunci](#keyword-definitions)
2. [Dokumentasi](#documentation)
3. [Ucapan Terima Kasih](#acknowledgements)
4. [Lisensi](#license)

## Definisi Kata Kunci

Paket NPM ini dirancang untuk mendukung aplikasi medis yang berpotensi berdampak pada perawatan pasien dan diagnosis. Dokumentasi ini, bersama dengan paket pendampingnya [node-hl7-server](https://www.npmjs.com/package/node-hl7-server), menggunakan definisi standar berikut untuk kejelasan dan interoperabilitas:

Kata kunci seperti **"MUST"**, **"MUST NOT"**, **"REQUIRED"**, **"SHALL"**, **"SHALL NOT"**, **"SHOULD"**, **"SHOULD NOT"**, **"RECOMMENDED"**, **"MAY"**, dan **"OPTIONAL"** digunakan secara konsisten di seluruh dokumentasi. Istilah-istilah ini tetap bermakna sama meskipun tidak ditulis dengan huruf kapital.

* **MUST** – Kata ini, atau istilah **"REQUIRED"** atau **"SHALL"**, menunjukkan persyaratan mutlak dari spesifikasi.
* **MUST NOT** – Frasa ini, atau frasa **"SHALL NOT"**, menunjukkan larangan mutlak dari spesifikasi.
* **SHOULD** – Kata ini, atau kata sifat **"RECOMMENDED"**, berarti ada alasan yang valid dalam keadaan tertentu untuk mengabaikan item tertentu, namun implikasinya harus dipahami dan dipertimbangkan dengan cermat sebelum melakukannya.
* **SHOULD NOT** – Frasa ini, atau frasa **"NOT RECOMMENDED"**, berarti ada alasan yang valid dalam keadaan tertentu di mana perilaku ini dapat diterima atau bahkan bermanfaat. Implikasi penuh harus dipahami dan kasusnya dipertimbangkan dengan cermat sebelum diimplementasikan.
* **MAY** – Kata ini, atau kata sifat **"OPTIONAL"**, berarti item tersebut benar-benar opsional. Implementasi yang tidak menyertakan opsi tertentu HARUS tetap dapat berinteroperasi dengan yang menyertakan, meskipun dengan fungsi yang mungkin berkurang. Demikian pula, implementasi yang menyertakan opsi HARUS dapat berinteroperasi dengan yang tidak (kecuali, tentu saja, untuk fitur khusus yang disediakan oleh opsi tersebut).

## 📖 Dokumentasi

Dokumentasi API lengkap, contoh penggunaan, dan konfigurasi lanjutan tersedia di situs proyek:
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 Ucapan Terima Kasih

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – Inspirasi logika koneksi.
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – Referensi desain untuk parser dan builder.
* Istri dan putri kecil saya – untuk cinta, kesabaran, dan inspirasinya.

## 📄 Lisensi

MIT © [LICENSE](LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---