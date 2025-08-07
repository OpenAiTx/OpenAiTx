
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (segera hadir)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (segera hadir)</a> |
        | <a href="#" title="Coming soon">ไทย (segera hadir)</a> |
        | <a href="#" title="Coming soon">Français (segera hadir)</a>
        | <a href="#" title="Coming soon">Deutsch (segera hadir)</a>
        | <a href="#" title="Coming soon">Español (segera hadir)</a>
        | <a href="#" title="Coming soon">Italiano (segera hadir)</a>
        | <a href="#" title="Coming soon">Русский (segera hadir)</a>
        | <a href="#" title="Coming soon">Português (segera hadir)</a>
        | <a href="#" title="Coming soon">Nederlands (segera hadir)</a>
        | <a href="#" title="Coming soon">Polski (segera hadir)</a>
        | <a href="#" title="Coming soon">العربية (segera hadir)</a>
        | <a href="#" title="Coming soon">فارسی (segera hadir)</a>
        | <a href="#" title="Coming soon">Türkçe (segera hadir)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (segera hadir)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (segera hadir)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Sebuah LLM yang dilatih hanya pada data dari periode waktu tertentu untuk mengurangi bias modern.

Bayangkan jika sebuah model AI tidak hanya berpura-pura menjadi historis tapi benar-benar demikian.

Dibangun di atas [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) Skrip pelatihan inti dan arsitektur model adalah hasil karyanya.

# Tujuan Proyek

TimeCapsule LLM adalah proyek eksperimental yang hanya akan dilatih pada teks-teks yang ditulis pada periode waktu tertentu. Tujuannya adalah untuk mensimulasikan pandangan dunia dan bahasa dari era sejarah tertentu.

# Mengapa fine tuning saja tidak cukup

Jika Anda hanya melakukan fine tuning pada model pra-latih, LLM Anda masih akan mengetahui konsep-konsep modern. Tentu saja mencapai nol bias modern itu sulit namun saya ingin sedekat mungkin dengan ini. Mendapatkan tanpa bias modern memerlukan pelatihan model dari awal.

# Hasil yang Diharapkan

Semoga saat selesai, model ini tidak mengetahui konsep modern dan tidak mampu bernalar di luar apa yang telah dipelajari. Seharusnya tidak mengenal konsep/kosakata modern dan saya harap tidak berhalusinasi pengetahuan modern.

# Pembaruan Progres

## 9 Juli 2025

Saya telah menentukan periode waktu saya pada 1800-1850 dan wilayah: London

Saya telah mengumpulkan daftar teks, buku, dokumen

Sejauh ini saya telah mendapatkan 50 file txt dan akan segera mulai melatih NanoGPT

Akan saya perbarui selama masih ada kemajuan

## 13 Juli 2025

Melatih nanoGPT dengan 187MB data teks historis.

## 15 Juli 2025

Saya mulai mengunduh teks untuk pelatihan kedua. Saya mengambil semuanya dari Internet Archive dan saya telah memperluas periode waktu menjadi 1800-1875. Untuk mendapatkan beragam teks, Anda dapat menggunakan filter subjek dan pencarian untuk lokasi publikasi, periode waktu dan subjek di Internet Archive.

![Filter Pencarian](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 Juli 2025

Saya mengunduh sekitar 500 file txt dari Internet Archive dan setelah membersihkannya (hanya menghapus spasi, header Gutenberg, dll) saya memiliki sekitar 500MB data. Ini dataset kecil tapi terakhir kali saya melatih dengan 187MB jadi harusnya ada perbedaan yang terlihat pada output setelah saya melatih model kedua. Saya berharap model ini setidaknya bisa menghasilkan kalimat yang lebih koheren dan cukup masuk akal. Tentu saja ini bukan jaminan karena dataset ini masih sangat kecil, tapi lebih banyak dari sebelumnya.

Ini harusnya bisa dikerjakan di perangkat keras saya sendiri, ini juga bagus karena saya bisa melihat beberapa peningkatan sebelum saya melompat ke dataset yang lebih besar yang akan mengharuskan saya menyewa GPU. Tapi jangan khawatir saya tetap berencana menyewa GPU segera, namun sebelum itu saya ingin memastikan dataset saya sudah dikurasi dan bersih. Salah satu masalah saya adalah proses pembersihan, banyak file txt ini yang bercampur omong kosong. Skrip yang saya gunakan untuk pembersihan memang bekerja tetapi tidak 100% efektif.

Saya akan melatih dataset ini hari ini dan harusnya memakan waktu sekitar 4-5 jam. Setelah selesai dan saya uji, saya akan memberikan pembaruan. Terima kasih lagi untuk semua yang telah melihat proyek saya, bahkan ada yang memberikan saya tautan ke sumber daya OCR jadi Terima kasih! Saya harap lebih banyak orang mencoba ini dan bereksperimen dengan dataset mereka sendiri.


### Pembaruan Pelatihan

Saya mulai melatih pada korpus 435MB (108 juta token), sejauh ini berjalan cukup lancar. Loss pelatihan turun dari 10,9 ke 4,9 dalam 2800 iterasi pertama. Saya perkirakan akan memakan waktu sekitar 8 atau 9 jam untuk selesai. Saya akan posting pembaruan lagi setelah selesai.

## 17 Juli 2025

Pelatihan untuk model kedua selesai, 4060 saya memerlukan sekitar 8 jam 40 menit (3.900 iter/jam) untuk 33.000 iterasi (5 epoch). Final train loss adalah 3,73. Outputnya sangat mengejutkan, benar-benar menghasilkan kalimat gaya abad ke-19 yang koheren sekarang.

## 28 Juli 2025

Saya telah mengunggah v0.5 ke Hugging Face, [Cek di sini](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) jika Anda mau. Anda sekarang dapat mengunduh repo saya dan menjalankannya secara lokal. Sayangnya nanoGPT tidak berjalan secara native di HuggingFace, jadi Anda harus mengunduh dan menjalankan modelnya secara lokal.

Juga saya akan mulai mengkurasi data untuk pelatihan saya berikutnya, saya rasa saya butuh mungkin 5-10x lebih banyak data untuk mencapai kemampuan penalaran.

## 2 Agustus 2025

Saya akan segera mulai mengerjakan Versi 1. Saya perlu beralih dari arsitektur nanoGPT ke sesuatu yang lebih modern. Saya memiliki beberapa arsitektur LLM open-source dalam pikiran, termasuk: OpenLLaMA v3, Phi-2 dan Qwen 1.5B. Dan untuk mendukung loncatan ke V1, saya perlu benar-benar mengkurasi dataset yang jauh lebih besar dan beragam. Saya butuh setidaknya 5GB data pelatihan yang bersih.

# Perilaku & Keterbatasan Model V0

Prompt awal menunjukkan model merespons dengan bahasa dan perilaku tahun 1800-an. Misalnya, saya memberi prompt "Who art Henry?" dan model menjawab "I know that man, I have did not a black, the storm." dan ya kalimat itu memang tidak masuk akal tapi LLM mengenali bahwa saya bertanya tentang seseorang.

![Keluaran Sampel TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Tidak ada penyebutan konsep modern, keluaran sebagian besar berisi kata-kata dan frasa dari tahun 1800-an.

Model ini masih sangat perlu pengembangan, pelatihan dari 187MB tidak akan menghasilkan model yang mampu membuat teks dengan penalaran kompleks.

Saat ini model menghasilkan kalimat yang tidak memiliki struktur kalimat lengkap dan secara keseluruhan memang tidak masuk akal, namun ini wajar untuk ukuran data pelatihan sekecil itu.

# Perilaku & Keterbatasan Model V0.5

Ini adalah peningkatan yang baik dibandingkan model sebelumnya. Gaya penulisan dan kosakata sudah bergaya Victorian dan hampir setiap kalimat sudah benar secara tata bahasa dengan tanda baca yang tepat. Dan sekali lagi, ini dilatih dari awal sehingga tetap berpegang pada topik abad ke-19.

![Keluaran Sampel TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Banyak halusinasi faktual. Banyak sekali (hampir 100%) detail (tanggal, peristiwa, tokoh sejarah) yang sepenuhnya dibuat-buat. Selain itu, kalimat-kalimatnya tidak benar-benar saling terhubung, kadang mungkin 2 kalimat saling berkaitan tapi selebihnya tidak. Masalah lain, kadang muncul footer “Digitized by Google” yang tidak sengaja, jadi pelatihan berikutnya saya harus lebih cermat membersihkan teks. Secara keseluruhan saya sangat puas dengan hasilnya, memang belum selevel LLM tapi sudah bisa menjadi generator kalimat.

Saya banyak belajar dan akan mulai mencari tahu apa yang perlu saya perbaiki dalam beberapa minggu ke depan. Saya akan segera mengunggah file!

# Rencana Selanjutnya

(Selesai) Saya akan mulai mengerjakan versi 0.5, alih-alih melatih dengan 50 buku, saya akan melatih dengan idealnya 500-600 buku. Saat ini saya sedang melatih nanoGPT dengan buku-buku dari tahun 1800-1850 dan khusus dari London. Ada tantangan seperti memastikan buku-buku yang saya temukan tidak diperbarui atau memiliki interpretasi modern tetapi benar-benar terbitan asli dari periode waktu pilihan saya.

Saya ingin melatih model baru (v1) dengan korpus yang jauh lebih besar, mungkin 5-10x lebih besar dari yang saya gunakan untuk v0.5. Tujuan saya adalah melihat apakah kemampuan penalaran bisa muncul hanya dari Selective Temporal Training, ini akan jadi tugas yang lebih sulit dan saya juga belum yakin apakah memungkinkan karena keterbatasan data sejarah. Dalam beberapa minggu mendatang saya akan mencoba mengumpulkan data yang cukup untuk korpus 5-10GB. Saya percaya jika saya bisa mendapatkan data bersih dan berkualitas tinggi serta menyewa GPU, akan ada kemajuan.

# Cara Menggunakan Proyek Ini

Proyek ini berfokus pada kurasi data sejarah, menyiapkannya untuk pelatihan, dan membangun tokenizer. Saya tidak akan membahas proses pelatihan LLM secara penuh, untuk itu silakan lihat nanoGPT oleh Andrej Karpathy.

# Langkah 1: Kumpulkan dan Siapkan Teks Sejarah

Kumpulkan file .txt dari buku domain publik, dokumen, dan sebagainya dari periode waktu pilihan Anda (misal: London 1800-1850)

Anda dapat menggunakan download_texts_improved.py untuk mengunduh buku jika diperlukan.

Bersihkan file teks menggunakan skrip atau secara manual hapus header/footer dari Project Gutenberg, anotasi modern, atau hal seperti kesalahan OCR.

prepare_dataset.py seharusnya dapat digunakan dengan baik.

# Langkah 2: Bangun Tokenizer Kustom

Jalankan train_tokenizer.py atau train_tokenizer_hf.py pada data yang sudah dibersihkan.
Ini akan menghasilkan vocab.json dan merges.txt

File-file ini menentukan kosakata dan aturan penggabungan untuk model Anda

# Langkah 3: Latih Model Anda (nanoGPT)

Silakan lihat [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) untuk proses pelatihannya.

Anda bisa melatih LLM lain jika mau, tapi saya menggunakan nanoGPT

# FAQ

## Apa itu Selective Temporal Training?

Selective Temporal Training (STT) adalah metode pembelajaran mesin di mana seluruh data pelatihan dikurasi secara khusus agar berasal dari periode waktu sejarah tertentu. Tujuannya untuk memodelkan bahasa dan pengetahuan era itu tanpa pengaruh konsep modern. Misalnya, model yang saya punya sekarang (v0.5) dilatih dengan data eksklusif dari tahun 1800-1875, bukan fine-tuning melainkan dilatih dari awal sehingga keluaran mencerminkan gaya bahasa dan konteks sejarah periode tersebut.

## Kenapa tidak menggunakan fine-tuning atau LoRA saja?

Untuk proyek ini saya ingin membuat model bahasa yang benar-benar bebas dari bias modern. Jika saya fine-tune model seperti GPT-2, data pra-latihnya sudah mengandung informasi modern yang tidak bisa dihilangkan. Jika saya melatih dari awal, model bahasa tidak akan berpura-pura kuno, memang akan seperti itu. Tujuan proyek ini adalah membuat sesuatu yang bisa bernalar hanya dengan pengetahuan dari buku-buku London terbitan 1800 hingga 1850.

## Data seperti apa yang digunakan untuk pelatihan?

Saya menggunakan buku, dokumen hukum, surat kabar, dan tulisan lain dari London tahun 1800–1850. Daftar yang saya tautkan berisi sekitar 200, tapi untuk pelatihan pertama saya hanya menggunakan 50 file sekitar ~187 MB. Anda bisa melihat daftar dokumennya di:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Seberapa besar model Versi 0?

Model ini sangat kecil saat ini, saya hanya membuatnya untuk bersenang-senang dan mengikuti aturan pelatihan ketat tanpa sumber modern. Model ini memiliki hampir 16 juta parameter tapi saya akan mulai mengumpulkan lebih banyak teks lama untuk memulai pelatihan model berikutnya. Akan saya kabarkan perkembangannya.

## Spesifikasi Pelatihan?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---