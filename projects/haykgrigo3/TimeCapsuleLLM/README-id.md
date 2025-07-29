
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (coming soon)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (coming soon)</a> |
        | <a href="#" title="Coming soon">ไทย (coming soon)</a> |
        | <a href="#" title="Coming soon">Français (coming soon)</a>
        | <a href="#" title="Coming soon">Deutsch (coming soon)</a>
        | <a href="#" title="Coming soon">Español (coming soon)</a>
        | <a href="#" title="Coming soon">Italiano (coming soon)</a>
        | <a href="#" title="Coming soon">Русский (coming soon)</a>
        | <a href="#" title="Coming soon">Português (coming soon)</a>
        | <a href="#" title="Coming soon">Nederlands (coming soon)</a>
        | <a href="#" title="Coming soon">Polski (coming soon)</a>
        | <a href="#" title="Coming soon">العربية (coming soon)</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="#" title="Coming soon">Türkçe (coming soon)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (coming soon)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Sebuah LLM yang dilatih hanya dengan data dari periode waktu tertentu untuk mengurangi bias modern.

Bayangkan jika model AI tidak hanya berpura-pura menjadi historis, tetapi benar-benar demikian.

Dibangun dengan [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) Skrip pelatihan inti dan arsitektur model adalah hasil karyanya.

# Tujuan Proyek

TimeCapsule LLM adalah proyek eksperimental yang hanya akan dilatih dengan teks-teks yang ditulis pada periode waktu tertentu. Tujuannya adalah untuk mensimulasikan pandangan dunia dan bahasa dari era sejarah tertentu.

# Mengapa fine tuning saja tidak cukup

Jika Anda hanya melakukan fine tuning pada model yang sudah dilatih sebelumnya, LLM Anda masih akan mengetahui konsep modern. Tentu saja, mencapai nol bias modern itu sulit tetapi saya ingin sedekat mungkin dengan itu. Mendapatkan tanpa bias modern memerlukan pelatihan model dari awal.

# Hasil yang Diharapkan

Semoga setelah selesai, model ini tidak akan mengetahui konsep modern dan tidak dapat beralasan di luar apa yang telah diajarkan. Seharusnya tidak mengenali konsep/kosakata modern dan saya berharap tidak menghalusinasi pengetahuan modern.

# Pembaruan Progres

## 9 Juli 2025

Saya telah menentukan periode waktu saya pada 1800-1850 dan wilayah: London

Saya telah mengumpulkan daftar teks, buku, dokumen

Sejauh ini saya sudah mendapatkan 50 file txt dan akan segera mulai melatih NanoGPT

Akan saya perbarui ini selama masih ada kemajuan

## 13 Juli 2025

Melatih nanoGPT dengan 187MB data teks sejarah.

## 15 Juli 2025

Saya mulai mengunduh teks untuk pelatihan kedua. Saya mendapatkan semuanya dari Internet Archive dan saya memperluas periode waktu menjadi 1800-1875. Untuk mendapatkan berbagai jenis teks, Anda dapat menggunakan filter subjek dan pencarian untuk lokasi publikasi, periode waktu, dan subjek di Internet Archive.

![Filter Pencarian](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 Juli 2025

Saya mengunduh sekitar 500 file txt dari Internet Archive dan setelah membersihkannya (hanya menghapus spasi, header Gutenberg, dsb) saya memiliki sekitar 500MB data. Ini dataset yang kecil, tapi terakhir saya melatih dengan 187MB jadi seharusnya ada perbedaan yang terlihat pada output setelah saya latih model kedua. Saya berharap model ini setidaknya dapat menghasilkan kalimat yang lebih koheren dan masuk akal. Tentu saja ini bukan jaminan karena dataset ini tetap sangat kecil, tapi ini lebih banyak dari yang saya gunakan sebelumnya.

Ini seharusnya bisa dilakukan dengan perangkat keras saya sendiri, ini juga bagus karena saya bisa melihat beberapa peningkatan sebelum saya beralih ke dataset yang lebih besar yang mengharuskan saya menyewa GPU. Tapi jangan khawatir saya tetap berencana menyewa GPU segera, tapi sebelum itu saya ingin memastikan dataset saya sebersih dan se-terkurasi mungkin. Salah satu masalah yang saya alami adalah pembersihan, banyak file txt ini mengandung tulisan acak. Skrip yang saya gunakan untuk membersihkan memang bekerja tapi tidak 100% efektif.

Saya akan melatih dataset ini hari ini dan seharusnya memakan waktu sekitar 4-5 jam. Setelah selesai dan saya uji, saya akan memberikan pembaruan. Terima kasih lagi untuk semua yang sudah melihat proyek saya, bahkan ada beberapa orang yang memberikan saya link sumber daya OCR jadi Terima kasih! Saya harap lebih banyak orang mencoba ini dan bereksperimen dengan dataset mereka sendiri.

## 28 Juli 2025

Saya telah mengunggah v0.5 ke Hugging Face, [Cek di sini](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) jika Anda ingin. Anda sekarang bisa mengunduh repo saya dan menjalankannya secara lokal. Sayangnya nanoGPT tidak berjalan secara native di HuggingFace, jadi Anda harus mengunduh dan menjalankan model ini secara lokal.

Saya juga akan mulai mengkurasi data untuk pelatihan berikutnya, saya percaya saya akan membutuhkan sekitar 5-10x lebih banyak data untuk mencapai kemampuan penalaran.

### Pembaruan Pelatihan

Saya mulai melatih pada korpus 435MB (108 juta token), saat ini berjalan cukup lancar. Train loss turun dari 10.9 ke 4.9 dalam 2800 iterasi pertama. Saya perkirakan akan memakan waktu sekitar 8 atau 9 jam untuk selesai. Saya akan memposting pembaruan lagi setelah selesai.

## 17 Juli 2025 02:13

Pelatihan untuk model kedua telah selesai, butuh waktu sekitar 8 jam 40 menit dengan 4060 saya (3.900 iter/jam) untuk 33.000 iterasi (5 epoch). Train loss akhir adalah 3,73. Output-nya mengejutkan, model ini benar-benar menghasilkan kalimat gaya abad ke-19 yang koheren sekarang.

# Perilaku & Keterbatasan Model V0

Prompt awal menunjukkan model merespon dengan bahasa dan perilaku tahun 1800-an. Misalnya, saya memintanya dengan "Who art Henry?" dan dia menjawab "I know that man, I have did not a black, the storm." dan ya kalimat itu memang tidak masuk akal tapi LLM ini mengenali bahwa saya menanyakan tentang seseorang.

![Contoh Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Tidak ada penyebutan konsep modern, keluaran sebagian besar berisi kata-kata dan frasa dari tahun 1800-an.

Masih membutuhkan banyak pekerjaan, melatih dengan 187MB tidak akan menghasilkan model yang mampu menghasilkan teks dengan penalaran kompleks.

Saat ini model menghasilkan kalimat yang kurang memiliki struktur kalimat penuh dan secara keseluruhan tidak masuk akal, namun ini normal untuk ukuran data pelatihan tersebut.

# Perilaku & Keterbatasan Model V0.5

Ini adalah peningkatan yang bagus dibanding model sebelumnya. Gaya penulisan dan kosakatanya bergaya Victoria dan hampir setiap kalimatnya secara tata bahasa benar dengan tanda baca yang tepat. Dan sekali lagi model ini dilatih dari awal sehingga tetap berpegang pada subjek tahun 1800-an.

![Contoh Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Terdapat banyak halusinasi faktual. Banyak sekali (hampir 100%) detail (tanggal, peristiwa, tokoh sejarah) yang dibuat-buat. Selain itu, kalimat-kalimatnya tidak benar-benar saling terhubung, terkadang mungkin 2 kalimat berhubungan satu sama lain tetapi tidak lebih dari itu. Masalah lain adalah kadang-kadang muncul footer “Digitized by Google” yang menyimpang, jadi saat pelatihan berikutnya saya harus benar-benar memastikan teks sudah dibersihkan dengan baik. Secara keseluruhan saya sangat senang dengan hasilnya, ini masih jauh dari LLM tapi jelas sudah menjadi generator kalimat.

Saya banyak belajar dan akan mulai mencari tahu apa yang perlu saya lakukan lebih baik dalam beberapa minggu ke depan. Saya akan mengunggah file segera!

# Rencana Mendatang

(Selesai) Saya akan mulai mengerjakan versi 0.5, alih-alih melatih menggunakan 50 buku, saya akan melatih dengan idealnya 500-600. Saat ini saya melatih nanoGPT menggunakan buku dari tahun 1800-1850 dan khususnya dari London. Ada beberapa tantangan seperti memastikan buku yang saya temukan belum diperbarui atau memiliki interpretasi modern, tetapi benar-benar buku asli yang diterbitkan dalam periode waktu yang saya pilih.

Saya ingin melatih model baru (v1) dengan korpus yang jauh lebih besar, mungkin 5-10x lebih besar dari yang saya gunakan untuk v0.5. Tujuan saya adalah melihat apakah kemampuan penalaran dapat muncul hanya dari Selective Temporal Training, ini akan menjadi tugas yang lebih sulit dan saya bahkan tidak sepenuhnya yakin apakah itu mungkin karena keterbatasan data sejarah. Dalam beberapa minggu ke depan saya akan mencoba mengkurasi cukup data untuk korpus 5-10GB. Saya percaya jika saya bisa mendapatkan data bersih berkualitas tinggi dan menyewa GPU, pasti akan ada kemajuan.

# Cara Menggunakan Proyek Ini

Proyek ini berfokus terutama pada kurasi data sejarah, menyiapkannya untuk pelatihan, dan membangun tokenizer. Saya tidak akan membahas proses pelatihan LLM secara penuh, untuk itu silakan merujuk ke nanoGPT oleh Andrej Karpathy.

# Langkah 1: Kumpulkan dan Siapkan Teks Sejarah

Kumpulkan file .txt dari buku domain publik, dokumen, dll dari periode waktu yang Anda pilih (misal, London 1800-1850)

Anda dapat menggunakan download_texts_improved.py untuk mengunduh buku jika diperlukan.

Bersihkan file teks menggunakan skrip atau secara manual hapus header/footer dari Project Gutenberg, anotasi modern, atau kesalahan OCR.

prepare_dataset.py seharusnya sudah cukup.

# Langkah 2: Bangun Tokenizer Kustom

Jalankan train_tokenizer.py atau train_tokenizer_hf.py pada data yang telah dibersihkan.
Ini akan menghasilkan vocab.json dan merges.txt

File-file ini mendefinisikan vocab dan aturan penggabungan untuk model Anda

# Langkah 3: Latih Model Anda (nanoGPT)

Lihat [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) untuk proses pelatihan.

Anda bisa melatih LLM yang berbeda jika mau, tapi saya menggunakan nanoGPT

# FAQ

## Apa itu Selective Temporal Training?

Selective Temporal Training (STT) adalah metodologi machine learning dimana seluruh data pelatihan dikurasi khusus agar berada dalam periode waktu sejarah tertentu. Hal ini dilakukan untuk memodelkan bahasa dan pengetahuan era tersebut tanpa pengaruh konsep modern. Misalnya, model yang saya miliki saat ini (v0.5) dilatih secara eksklusif pada data dari 1800-1875, bukan fine-tune tapi benar-benar dilatih dari awal sehingga hasilnya mencerminkan gaya linguistik dan konteks sejarah periode waktu tersebut.

## Kenapa tidak menggunakan fine-tuning atau LoRA saja?

Untuk proyek ini saya mencoba membuat model bahasa yang tidak dipengaruhi bias modern. Jika saya fine-tune sesuatu seperti GPT-2, model tersebut sudah dipra-latih dan informasi itu tidak akan hilang. Jika saya melatih dari awal, model bahasa tidak akan berpura-pura menjadi tua, memang benar-benar demikian. Tujuan proyek ini sekarang adalah membuat sesuatu yang bisa bernalar hanya dengan pengetahuan dari buku London yang diterbitkan antara 1800 dan 1850.

## Data seperti apa yang Anda gunakan untuk pelatihan?

Saya menggunakan buku, dokumen hukum, surat kabar, dan tulisan lain dari London tahun 1800–1850. Daftar yang saya tautkan ada sekitar 200 tapi untuk pelatihan pertama saya hanya menggunakan 50 file sekitar ~187 MB. Anda dapat melihat daftar dokumennya:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Seberapa besar model Versi 0?

Model ini sangat kecil saat ini, saya hanya melakukannya untuk bersenang-senang dan mengikuti aturan pelatihan ketat tanpa sumber modern. Saat ini memiliki hampir 16 juta parameter tapi saya akan mulai mengumpulkan lebih banyak teks lama untuk memulai pelatihan model baru. Akan saya update terus perkembangannya.

## Spesifikasi Pelatihan?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---