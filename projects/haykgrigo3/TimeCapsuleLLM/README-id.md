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
Sebuah LLM yang dilatih hanya pada data dari periode waktu tertentu untuk mengurangi bias modern.

Bayangkan jika sebuah model AI tidak hanya berpura-pura menjadi historis tetapi memang benar-benar demikian.

Dibangun di atas [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT). Skrip pelatihan inti dan arsitektur model adalah karya beliau.

# Tujuan Proyek

TimeCapsule LLM adalah proyek eksperimental yang hanya akan dilatih pada teks-teks yang ditulis selama periode waktu tertentu. Tujuannya adalah untuk mensimulasikan pandangan dunia dan bahasa dari era sejarah tertentu.

# Mengapa fine tuning saja tidak cukup

Jika Anda hanya melakukan fine tuning pada model yang sudah dilatih, LLM Anda masih akan mengetahui konsep modern. Tentu saja mencapai nol bias modern itu sulit tetapi saya ingin sedekat mungkin dengan ini. Mendapatkan nol bias modern memerlukan pelatihan model dari awal.

# Hasil yang Diharapkan

Mudah-mudahan ketika selesai, model ini tidak akan mengetahui konsep modern dan tidak akan dapat bernalar di luar apa yang telah dipelajari. Seharusnya tidak mengenali konsep/kosakata modern dan saya berharap tidak berhalusinasi pengetahuan modern.

# Pembaruan Progres

## 9 Juli 2025

Saya telah menetapkan periode waktu saya untuk 1800-1850 dan wilayah: London

Saya telah mengumpulkan daftar teks, buku, dokumen

Sejauh ini saya sudah mendapatkan 50 file txt dan akan segera memulai pelatihan NanoGPT

Akan saya perbarui ini selama masih ada kemajuan

## 13 Juli 2025

Melatih nanoGPT dengan 187MB data teks sejarah.

## 15 Juli 2025

Saya mulai mengunduh teks untuk pelatihan kedua. Saya mendapatkan semuanya dari Internet Archive dan saya telah memperluas periode waktunya menjadi 1800-1875. Untuk mendapatkan beragam jenis teks, Anda dapat menggunakan filter subjek dan pencarian untuk lokasi publikasi, periode waktu, dan subjek di Internet Archive.

![Filter Pencarian](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 Juli 2025

Saya mengunduh sekitar 500 file txt dari Internet Archive dan setelah membersihkannya (hanya menghapus whitespace, header Gutenberg, dll) saya punya sekitar 500MB data. Ini dataset kecil tetapi terakhir kali saya melatih dari 187MB jadi seharusnya ada setidaknya perbedaan yang terasa pada output setelah saya melatih model kedua. Saya berharap model ini setidaknya bisa menghasilkan kalimat yang lebih koheren yang agak masuk akal. Tentu saja ini tidak menjamin karena dataset ini masih sangat sangat kecil, tapi ini lebih banyak dari yang saya pakai sebelumnya.

Ini seharusnya bisa dijalankan di hardware saya sendiri, bagus juga karena saya semoga bisa melihat beberapa peningkatan sebelum saya loncat ke dataset yang lebih besar yang akan mengharuskan saya menyewa GPU. Tapi jangan khawatir saya masih berencana untuk menyewa GPU dalam waktu dekat, namun sebelum itu saya ingin memastikan dataset saya se-terkurasi dan sebersih mungkin. Salah satu masalah saya adalah pembersihan, banyak file txt ini berisi tulisan acak. Skrip yang saya gunakan untuk pembersihan memang berfungsi tetapi tidak 100% efektif.

Saya akan melatih dataset ini hari ini dan seharusnya memakan waktu sekitar 4-5 jam. Setelah selesai dan saya uji, saya akan memberikan pembaruan. Terima kasih lagi untuk semua yang telah melihat proyek saya, bahkan ada beberapa orang yang memberi saya tautan ke sumber daya OCR jadi Terima kasih! Saya berharap lebih banyak orang mencoba dan bereksperimen dengan dataset mereka sendiri.

### Pembaruan Pelatihan

Saya mulai pelatihan pada korpus 435MB (108 juta token), sejauh ini berjalan cukup lancar. Train loss turun dari 10,9 ke 4,9 dalam 2800 iterasi pertama. Saya perkirakan akan memakan waktu sekitar 8 atau 9 jam untuk selesai. Saya akan posting pembaruan lagi setelah selesai.

## 17 Juli 2025 2:13AM

Pelatihan selesai untuk model kedua, 4060 saya butuh sekitar 8 jam 40 menit (3.900 iter/jam) untuk 33.000 iterasi (5 epoch). Train loss terakhir adalah 3,73. Outputnya sangat bagus, benar-benar menghasilkan kalimat gaya abad ke-19 yang koheren sekarang.

# Perilaku & Keterbatasan Model V0

Prompt awal menunjukkan model merespon dengan bahasa dan perilaku tahun 1800-an. Misalnya, saya memberikan prompt "Who art Henry?" dan model membalas "I know that man, I have did not a black, the storm." dan ya kalimat itu memang tidak masuk akal tapi LLM mengenali saya sedang bertanya tentang seseorang.

![Contoh Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Tidak ada penyebutan konsep modern, output berisi kata dan frasa dari tahun 1800-an.

Masih butuh banyak pekerjaan, melatih dari 187MB tidak akan menghasilkan model yang bisa memproduksi teks dengan penalaran kompleks.

Saat ini model menghasilkan kalimat yang tidak lengkap secara struktur dan secara umum memang tidak masuk akal, tapi ini normal untuk ukuran data latih sebesar itu.

# Perilaku & Keterbatasan Model V0.5

Ini adalah peningkatan yang bagus dibandingkan model sebelumnya. Gaya penulisan dan kosa kata bersifat Victoria dan hampir setiap kalimatnya benar secara tata bahasa dengan tanda baca yang tepat. Dan sekali lagi ini dilatih dari awal sehingga tetap berpegang pada subjek tahun 1800-an.

![Output Sampel TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Ada banyak halusinasi faktual. Banyak sekali (hampir 100%) detailnya (tanggal, peristiwa, tokoh sejarah) dibuat-buat. Selain itu, kalimat-kalimatnya sebenarnya tidak memiliki hubungan satu sama lain, terkadang mungkin 2 kalimat saling berkaitan namun tidak lebih dari itu. Masalah lain adalah kadang muncul footer “Digitized by Google” yang tidak diinginkan, jadi saat pelatihan berikutnya saya benar-benar harus memastikan teksnya dibersihkan dengan baik. Secara keseluruhan saya sangat puas dengan hasilnya, ini masih jauh dari LLM tetapi jelas merupakan generator kalimat.

Saya banyak belajar dan akan mulai mencari tahu apa yang perlu saya perbaiki dalam beberapa minggu ke depan. Saya akan segera mengunggah file!

# Rencana Mendatang

(Selesai) Saya akan mulai mengerjakan versi 0.5, alih-alih melatih dengan 50 buku, saya akan melatih dengan idealnya 500-600 buku. Saat ini saya sedang melatih nanoGPT menggunakan buku-buku dari tahun 1800-1850 dan khususnya dari London. Ada beberapa tantangan seperti memastikan buku yang saya temukan tidak diperbarui atau memiliki interpretasi modern, tetapi benar-benar buku asli yang diterbitkan dalam periode waktu pilihan saya.

Saya ingin melatih model baru (v1) dengan korpus yang jauh lebih besar, mungkin 5-10x lebih besar dari yang saya gunakan untuk v0.5. Tujuan saya adalah untuk melihat apakah kemampuan penalaran dapat muncul hanya dari Selective Temporal Training, ini akan menjadi tugas yang lebih sulit dan saya bahkan tidak sepenuhnya yakin apakah itu mungkin karena keterbatasan data sejarah. Dalam beberapa minggu ke depan saya akan mencoba mengkurasi data yang cukup untuk korpus 5-10GB. Saya percaya jika saya bisa mendapatkan data bersih berkualitas tinggi dan menyewa GPU, akan ada kemajuan.

# Cara Menggunakan Proyek Ini

Proyek ini lebih berfokus pada pengumpulan data sejarah, menyiapkannya untuk pelatihan, dan membangun tokenizer. Saya tidak akan membahas proses pelatihan LLM penuh, untuk itu silakan merujuk ke nanoGPT oleh Andrej Karpathy.

# Langkah 1: Kumpulkan dan Siapkan Teks Sejarah

Kumpulkan file .txt dari buku domain publik, dokumen, dll dari periode waktu pilihan Anda (misal, London 1800-1850)

Anda dapat menggunakan download_texts_improved.py untuk mengunduh buku jika diperlukan.

Bersihkan file teks menggunakan skrip atau hapus manual header/footer dari Project Gutenberg, anotasi modern atau hal seperti kesalahan OCR.

prepare_dataset.py seharusnya sudah cukup.

# Langkah 2: Bangun Tokenizer Kustom

Jalankan train_tokenizer.py atau train_tokenizer_hf.py pada data yang telah dibersihkan.
Ini akan memberikan Anda vocab.json dan merges.txt

File-file ini mendefinisikan kosa kata dan aturan penggabungan untuk model Anda

# Langkah 3: Latih Model Anda (nanoGPT)

Lihat [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) untuk proses pelatihan.

Anda dapat melatih LLM yang berbeda jika mau, tapi saya menggunakan nanoGPT

# FAQ

## Apa itu Selective Temporal Training?

Selective Temporal Training (STT) adalah metodologi machine learning di mana semua data pelatihan dikurasi khusus agar berada dalam periode waktu sejarah tertentu. Ini dilakukan untuk memodelkan bahasa dan pengetahuan dari era tersebut tanpa pengaruh konsep modern. Sebagai contoh, model yang saya miliki saat ini (v0.5) dilatih hanya dengan data dari 1800-1875, tidak di-fine tune tapi dilatih dari awal sehingga hasilnya mencerminkan gaya bahasa dan konteks sejarah periode tersebut.

## Kenapa tidak pakai fine-tuning atau LoRA saja?

Untuk proyek ini saya mencoba membuat model bahasa yang tidak terpengaruh bias modern. Jika saya fine-tune sesuatu seperti GPT-2, itu sudah dilatih sebelumnya dan informasinya tidak akan hilang. Jika saya latih dari awal, model bahasa tidak akan pura-pura kuno, memang benar-benar kuno. Tujuan proyek ini saat ini adalah membuat sesuatu yang hanya dapat bernalar menggunakan pengetahuan dari buku-buku London yang diterbitkan antara 1800 dan 1850.

## Data seperti apa yang Anda gunakan untuk pelatihan?

Saya menggunakan buku, dokumen hukum, surat kabar, dan tulisan lain dari London 1800–1850. Daftar yang saya tautkan ada sekitar 200 tapi untuk pelatihan pertama saya hanya menggunakan 50 file sekitar ~187 MB. Anda bisa melihat daftar dokumennya:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Seberapa besar model Versi 0?

Model ini sangat kecil saat ini, saya melakukan ini hanya untuk bersenang-senang dan mengikuti aturan pelatihan ketat tanpa sumber modern. Model ini memiliki hampir 16 juta parameter tapi saya akan mulai mengumpulkan lebih banyak teks lama untuk memulai pelatihan model lain. Akan saya update seiring waktu.

## Spesifikasi Pelatihan?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---