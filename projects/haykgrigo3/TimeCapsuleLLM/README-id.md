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

Bayangkan jika sebuah model AI tidak hanya berpura-pura menjadi historis tapi benar-benar demikian.

Dibangun di atas [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) Skrip pelatihan inti dan arsitektur model merupakan karya beliau.

# Tujuan Proyek

TimeCapsule LLM adalah proyek eksperimental yang hanya akan dilatih pada teks-teks yang ditulis selama periode waktu tertentu. Tujuannya adalah untuk mensimulasikan sudut pandang dan bahasa dari era sejarah tertentu.

# Mengapa fine tuning saja tidak cukup

Jika Anda hanya melakukan fine tuning pada model yang sudah dilatih, LLM Anda masih akan mengetahui konsep modern. Tentu saja mencapai nol bias modern itu sulit tapi saya ingin sedekat mungkin dengan ini. Mendapatkan tanpa bias modern membutuhkan pelatihan model dari awal.

# Hasil yang Diharapkan

Semoga ketika selesai, model ini tidak akan mengetahui konsep modern dan tidak mampu bernalar di luar apa yang telah dilatih. Seharusnya tidak mengenali konsep/kosakata modern dan saya harap tidak menghalusinasi pengetahuan modern.

# Pembaruan Progres

## 9 Juli 2025

Saya telah menetapkan periode waktu saya pada 1800-1850 dan wilayah: London

Saya telah mengumpulkan daftar teks, buku, dokumen

Sejauh ini saya telah mendapatkan 50 file txt dan akan segera mulai melatih NanoGPT

Akan saya perbarui ini selama progres masih berjalan

## 13 Juli 2025

Melatih nanoGPT dengan 187MB data teks sejarah.

## 15 Juli 2025

Saya mulai mengunduh teks untuk pelatihan kedua. Saya mendapatkan semuanya dari Internet Archive dan saya telah memperluas periode waktu menjadi 1800-1875. Untuk mendapatkan beragam teks, Anda dapat menggunakan filter subjek dan pencarian untuk lokasi publikasi, periode waktu, dan subjek di Internet Archive.

![Search Filters](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 Juli 2025

Saya mengunduh sekitar 500 file txt dari Internet Archive dan setelah dibersihkan (hanya menghapus spasi, header Gutenberg, dll) saya memiliki sekitar 500MB data. Ini dataset kecil tapi terakhir kali saya melatih dari 187MB jadi seharusnya ada setidaknya perbedaan yang terlihat pada output setelah saya melatih model kedua. Saya berharap model ini setidaknya dapat menghasilkan kalimat yang lebih koheren yang cukup masuk akal. Tentu saja ini bukan jaminan karena dataset ini masih sangat kecil, tapi ini lebih banyak dari yang saya gunakan terakhir kali.

Ini seharusnya bisa dilakukan di perangkat keras saya sendiri, ini juga bagus karena saya semoga bisa melihat beberapa peningkatan sebelum saya beralih ke dataset yang lebih besar yang akan mengharuskan saya menyewa GPU. Tapi jangan khawatir saya masih berencana untuk menyewa GPU segera, tapi sebelum itu saya ingin memastikan dataset saya sebersih dan sebaik mungkin. Salah satu masalah yang saya hadapi adalah pembersihan, banyak file txt ini berisi kata-kata acak. Skrip yang saya gunakan untuk membersihkan memang berfungsi tapi tidak 100% efektif.

Saya akan melatih dataset ini hari ini dan seharusnya memakan waktu sekitar 4-5 jam. Setelah selesai dan saya uji, saya akan memberikan pembaruan. Terima kasih lagi kepada semua yang telah melihat proyek saya, bahkan ada beberapa orang yang memberikan saya tautan ke sumber daya OCR jadi Terima kasih! Saya harap lebih banyak orang mencoba ini dan bereksperimen dengan dataset mereka sendiri.

### Pembaruan Training

Saya mulai melatih pada korpus 435MB (108 juta token), berjalan cukup lancar saat ini. Train loss turun dari 10,9 menjadi 4,9 dalam 2800 iterasi pertama. Saya perkirakan akan memakan waktu sekitar 8 atau 9 jam untuk menyelesaikan. Saya akan memposting pembaruan lagi setelah selesai.

## 17 Juli 2025 2:13AM

Pelatihan untuk model kedua selesai, 4060 saya memakan waktu sekitar 8 jam 40 menit (3.900 iter/jam) untuk 33.000 iterasi (5 epoch). Final train loss adalah 3,73. Hasil outputnya mengejutkan cukup bagus, sekarang benar-benar menghasilkan kalimat gaya abad ke-19 yang koheren.

## 28 Juli 2025

Saya telah mengunggah v0.5 ke Hugging Face, [Cek di sini](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) jika Anda ingin. Anda sekarang dapat mengunduh repo saya dan menjalankannya secara lokal. Sayangnya nanoGPT tidak berjalan secara native dengan HuggingFace, jadi Anda harus mengunduh dan menjalankan model secara lokal.

Juga saya akan mulai mengkurasi data untuk pelatihan berikutnya, saya percaya saya akan butuh mungkin 5-10x lebih banyak data untuk mencapai kemampuan bernalar.

# Perilaku & Keterbatasan Model V0

Prompt awal menunjukkan model merespons dengan bahasa dan perilaku tahun 1800-an. Sebagai contoh, saya memintanya dengan "Who art Henry?" dan ia menjawab "I know that man, I have did not a black, the storm." dan ya kalimat itu memang tidak masuk akal tapi LLM mengenali bahwa saya bertanya tentang seseorang.




![Contoh Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Tidak ada penyebutan konsep modern, output sebagian besar berisi kata dan frasa dari tahun 1800-an.

Masih perlu banyak pengembangan, melatih dengan data sebesar 187MB tidak akan menghasilkan model yang mampu menulis dengan penalaran kompleks.

Saat ini model menghasilkan kalimat yang belum sepenuhnya terstruktur dan secara umum tidak masuk akal, namun ini normal untuk ukuran data pelatihan sebesar itu.

# Perilaku Model V0.5 & Keterbatasan

Ini adalah peningkatan yang cukup baik dibandingkan model sebelumnya. Gaya penulisan dan kosakatanya bergaya Victorian dan hampir setiap kalimat sudah benar secara tata bahasa dan tanda baca. Dan lagi, ini dilatih dari awal sehingga tetap konsisten dengan topik tahun 1800-an.

![Contoh Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Terdapat banyak halusinasi faktual. Banyak (sekitar 100%) detail (tanggal, peristiwa, tokoh sejarah) adalah hasil rekaan. Selain itu, kalimat-kalimatnya tidak benar-benar saling terhubung, kadang hanya 2 kalimat yang berkaitan, namun selebihnya tidak. Masalah lain, kadang muncul footer “Digitized by Google” secara acak, jadi pelatihan berikutnya saya harus memastikan teks benar-benar bersih. Secara keseluruhan saya puas dengan hasilnya, ini memang belum seperti LLM tapi jelas sudah bisa menghasilkan kalimat.

Saya banyak belajar dan akan mulai mencari tahu apa yang perlu saya perbaiki dalam beberapa minggu ke depan. File akan segera saya unggah!

# Rencana Mendatang

(Selesai) Saya akan mulai mengerjakan versi 0.5, alih-alih melatih menggunakan 50 buku, saya akan melatih dengan idealnya 500-600 buku. Saat ini saya melatih nanoGPT menggunakan buku dari tahun 1800-1850 dan khususnya dari London. Ada beberapa tantangan seperti memastikan buku yang saya temukan tidak diperbarui atau memiliki interpretasi modern, melainkan buku asli yang diterbitkan dalam periode waktu yang saya pilih.

Saya ingin melatih model baru (v1) dengan korpus yang jauh lebih besar, mungkin 5-10x lebih besar dari yang saya gunakan untuk v0.5. Tujuan saya adalah melihat apakah kemampuan penalaran bisa muncul hanya dengan Selective Temporal Training, ini akan menjadi tugas yang lebih sulit dan saya sendiri belum yakin sepenuhnya karena adanya keterbatasan data sejarah. Dalam beberapa minggu ke depan saya akan mencoba mengumpulkan data cukup untuk korpus 5-10GB. Saya percaya jika bisa mendapatkan data yang benar-benar bersih dan berkualitas tinggi serta menyewa GPU, akan ada kemajuan.

# Cara Menggunakan Proyek Ini

Proyek ini berfokus terutama pada pengumpulan data sejarah, menyiapkannya untuk pelatihan, dan membangun tokenizer. Saya tidak akan membahas proses pelatihan LLM penuh, untuk itu silakan lihat nanoGPT oleh Andrej Karpathy.

# Langkah 1: Kumpulkan dan Siapkan Teks Sejarah

Kumpulkan file .txt dari buku domain publik, dokumen, dll dari periode waktu pilihan Anda (misal, London 1800-1850)

Anda bisa menggunakan download_texts_improved.py untuk mengunduh buku jika diperlukan.

Bersihkan file teks menggunakan skrip atau hapus header/footer dari Project Gutenberg, anotasi modern, atau kesalahan OCR secara manual.

prepare_dataset.py seharusnya sudah cukup.

# Langkah 2: Bangun Tokenizer Khusus

Jalankan train_tokenizer.py atau train_tokenizer_hf.py pada data yang sudah dibersihkan.
Ini akan menghasilkan vocab.json dan merges.txt

File-file ini mendefinisikan kosakata dan aturan penggabungan untuk model Anda

# Langkah 3: Latih Model Anda (nanoGPT)

Lihat [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) untuk proses pelatihan.

Anda bisa melatih LLM lain jika mau, tapi saya menggunakan nanoGPT

# FAQ

## Apa itu Selective Temporal Training?

Selective Temporal Training (STT) adalah metodologi machine learning di mana semua data pelatihan secara khusus dikurasi agar berada dalam periode waktu sejarah tertentu. Tujuannya untuk memodelkan bahasa dan pengetahuan era tersebut tanpa pengaruh konsep modern. Contohnya, model yang saya punya sekarang (v0.5) dilatih hanya dengan data dari 1800-1875, tidak di-fine tune tapi benar-benar dilatih dari awal sehingga output-nya mencerminkan gaya bahasa dan konteks sejarah saat itu.

## Kenapa tidak pakai fine-tuning atau LoRA saja?

Untuk proyek ini saya ingin membuat language model yang tidak terpengaruh bias modern. Jika saya fine-tune model seperti GPT-2, model itu sudah dilatih sebelumnya dan informasinya tidak akan hilang. Jika dilatih dari awal, language model tidak akan sekadar berpura-pura tua, tapi memang benar-benar seperti itu. Tujuan proyek ini adalah membuat sesuatu yang bisa bernalar hanya dengan pengetahuan dari buku-buku London yang terbit antara 1800 dan 1850.

## Data apa yang dipakai untuk pelatihan?

Saya menggunakan buku, dokumen hukum, surat kabar, dan tulisan lain dari London tahun 1800–1850. Daftar yang saya tautkan ada sekitar 200, tapi untuk pelatihan pertama saya hanya menggunakan 50 file sekitar ~187 MB. Anda dapat melihat daftar dokumennya:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Seberapa besar model Versi 0?

Model ini sangat kecil saat ini, saya hanya iseng dan mengikuti aturan ketat tanpa sumber modern. Model ini punya hampir 16 juta parameter tapi saya akan mulai mengumpulkan lebih banyak teks lama untuk mulai pelatihan model berikutnya. Akan saya update nanti.

## Spesifikasi Pelatihan?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---