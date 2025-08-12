
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Segera hadir">繁體中文 (segera hadir)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Segera hadir">हिन्दी (segera hadir)</a> |
        | <a href="#" title="Segera hadir">ไทย (segera hadir)</a> |
        | <a href="#" title="Segera hadir">Français (segera hadir)</a>
        | <a href="#" title="Segera hadir">Deutsch (segera hadir)</a>
        | <a href="#" title="Segera hadir">Español (segera hadir)</a>
        | <a href="#" title="Segera hadir">Italiano (segera hadir)</a>
        | <a href="#" title="Segera hadir">Русский (segera hadir)</a>
        | <a href="#" title="Segera hadir">Português (segera hadir)</a>
        | <a href="#" title="Segera hadir">Nederlands (segera hadir)</a>
        | <a href="#" title="Segera hadir">Polski (segera hadir)</a>
        | <a href="#" title="Segera hadir">العربية (segera hadir)</a>
        | <a href="#" title="Segera hadir">فارسی (segera hadir)</a>
        | <a href="#" title="Segera hadir">Türkçe (segera hadir)</a>
        | <a href="#" title="Segera hadir">Tiếng Việt (segera hadir)</a>
        | <a href="#" title="Segera hadir">Bahasa Indonesia (segera hadir)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Sebuah LLM yang hanya dilatih menggunakan data dari periode waktu tertentu untuk mengurangi bias modern.

Bayangkan jika sebuah model AI tidak hanya berpura-pura menjadi historis tetapi benar-benar seperti itu.

Dibangun di atas [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) Skrip pelatihan inti dan arsitektur model adalah karya beliau.

# Tujuan Proyek
TimeCapsule LLM adalah proyek eksperimental yang hanya akan dilatih pada teks-teks yang ditulis selama periode waktu tertentu. Tujuannya adalah untuk mensimulasikan pandangan dunia dan bahasa dari era sejarah tertentu.

# Mengapa fine tuning tidak cukup

Jika Anda hanya melakukan fine tune pada model yang telah dilatih sebelumnya, LLM Anda tetap akan mengetahui konsep-konsep modern. Tentu saja mencapai bias modern nol sulit, tetapi saya ingin sedekat mungkin dengan ini. Mendapatkan bias modern nol membutuhkan pelatihan model dari awal.

# Hasil yang Diharapkan

Semoga ketika selesai, model ini tidak akan mengetahui konsep-konsep modern dan tidak akan mampu bernalar di luar apa yang telah dilatih. Model ini seharusnya tidak mengenali konsep/kosakata modern dan tidak boleh menghalusinasi pengetahuan modern.

# Pembaruan Progres

## 9 Juli 2025

Saya telah menetapkan periode waktu untuk 1800-1850 dan wilayah: London

Saya telah mengumpulkan daftar teks, buku, dokumen

Sejauh ini saya telah mendapatkan 50 file txt dan akan segera mulai melatih NanoGPT

Akan diperbarui selama progres terus berjalan

## 13 Juli 2025

Telah melatih nanoGPT dengan 187MB data teks sejarah.

## 15 Juli 2025

Saya mulai mengunduh teks untuk pelatihan kedua. Saya mengambil semuanya dari Internet Archive dan saya telah memperluas periode waktu menjadi 1800-1875. Untuk mendapatkan berbagai macam teks, Anda dapat menggunakan filter subjek dan pencarian untuk lokasi publikasi, periode waktu, dan subjek di Internet Archive.

![Filter Pencarian](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 Juli 2025

Saya mengunduh sekitar 500 file txt dari Internet Archive dan setelah membersihkannya (hanya menghapus spasi, header Gutenberg, dll) saya punya sekitar 500MB data. Ini dataset yang kecil tetapi terakhir kali saya melatih dari 187MB jadi setidaknya harus ada beberapa perbedaan yang terlihat pada output setelah saya melatih model kedua. Saya berharap model ini setidaknya dapat menghasilkan kalimat yang lebih koheren dan agak masuk akal. Tentu saja ini bukan jaminan karena dataset ini masih sangat kecil, tetapi lebih banyak daripada yang saya gunakan sebelumnya.

Ini seharusnya bisa dilakukan di perangkat keras saya sendiri, ini juga bagus karena saya berharap bisa melihat beberapa perbaikan sebelum saya beralih ke dataset yang lebih besar yang akan mengharuskan saya menyewa GPU. Tapi jangan khawatir saya tetap berencana menyewa GPU segera, tetapi sebelum itu saya ingin memastikan dataset saya serapi dan sebersih mungkin. Salah satu masalah yang saya hadapi adalah pembersihan, banyak file txt ini tercampur dengan tulisan ngawur. Script yang saya gunakan untuk membersihkan memang berfungsi tetapi tidak 100% efektif.

Saya akan melatih dataset ini hari ini dan seharusnya memakan waktu sekitar 4-5 jam. Setelah selesai dan saya uji, saya akan memberikan pembaruan. Terima kasih sekali lagi kepada semua yang sudah melihat proyek saya, bahkan ada beberapa orang yang memberikan saya tautan ke sumber daya OCR jadi Terima kasih! Saya berharap lebih banyak orang mencoba ini dan bereksperimen dengan dataset mereka sendiri.


## 12 Agustus 2025

Versi 1 telah selesai, versi ini menggunakan Phi 1.5 (700 juta parameter) dan dilatih pada dataset yang hampir memiliki 7000 teks. Peningkatan utama pada model ini adalah kemampuannya untuk kadang-kadang mereferensikan nama nyata dan peristiwa bersejarah. Versi 0 dan 0.5 tidak bisa melakukan ini, setiap kali saya memberikan prompt seperti "Pada tahun 1821" maka outputnya hanyalah halusinasi, hal-hal yang tidak pernah terjadi. Contohnya dengan Versi 1:

Prompt saya: Itu adalah tahun Tuhan kami 1834,

Outputnya: "Itu adalah tahun Tuhan kami 1834 dan jalan-jalan di London dipenuhi dengan protes dan petisi. Penyebabnya, seperti yang banyak diceritakan, tidak terikat pada urusan pribadi, tetapi telah diambil pada hari yang sama di hari Lord Palmerston, publik akan menerima pernyataan singkat tentang kesulitan yang sedang kita hadapi pada hari hukum. Sangat disayangkan, bahwa peristiwa-peristiwa saat ini dalam sejarah dunia sangat jelas, dan akibatnya akan diketahui. Tidak benar bahwa orang-orang yang pertama kali menetap di Injil di Yerusalem memiliki catatan yang begitu luas dan menarik tentang kemakmuran dan kemakmuran"

Awalnya saya pikir ini mungkin kebetulan tapi lihat ini: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### Pembaruan Pelatihan

Saya mulai melatih pada korpus 435MB (108 juta token), sejauh ini berjalan cukup lancar. Train loss turun dari 10,9 menjadi 4,9 dalam 2800 iterasi pertama. Saya perkirakan akan memakan waktu sekitar 8 atau 9 jam untuk selesai. Saya akan memposting pembaruan lagi setelah selesai.

## 17 Juli 2025

Pelatihan selesai untuk model kedua, 4060 saya membutuhkan waktu sekitar 8 jam 40 menit (3.900 iter/jam) untuk 33.000 iterasi (5 epoch). Train loss terakhir adalah 3,73. Outputnya sangat bagus, model ini benar-benar menghasilkan kalimat dengan gaya abad ke-19 secara koheren sekarang.

## 28 Juli 2025

Saya telah mengunggah v0.5 ke Hugging Face, [Cek di sini](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) jika Anda ingin. Anda sekarang dapat mengunduh repo saya dan menjalankannya secara lokal. Sayangnya nanoGPT tidak berjalan secara native dengan HuggingFace, jadi Anda harus mengunduh dan menjalankan modelnya secara lokal.

Juga saya akan mulai mengkurasi data untuk pelatihan berikutnya, saya yakin saya perlu sekitar 5-10x lebih banyak data untuk mencapai kemampuan penalaran.

## 2 Agustus 2025

Saya akan mulai mengerjakan Versi 1 segera. Saya perlu beralih dari arsitektur nanoGPT ke sesuatu yang lebih modern. Ada beberapa arsitektur LLM open-source yang saya pertimbangkan, termasuk: OpenLLaMA v3, Phi-2 dan Qwen 1.5B. Dan untuk mendukung lompatan ke V1, saya harus mengkurasi dataset yang jauh lebih besar dan beragam. Saya butuh setidaknya 5GB data pelatihan bersih.

# Perilaku & Keterbatasan Model V0

Prompt awal menunjukkan model merespon dengan bahasa dan perilaku tahun 1800-an. Misalnya, saya memintanya dengan "Siapa Henry?" dan ia menjawab "Saya tahu orang itu, saya tidak melakukan hitam, badai." dan ya kalimat itu tidak masuk akal tapi LLM mengenali saya sedang bertanya tentang seseorang.

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Tidak ada penyebutan konsep modern, output sebagian besar berisi kata-kata dan frasa dari tahun 1800-an.

Masih membutuhkan banyak pekerjaan, pelatihan dengan 187MB tidak akan menghasilkan model yang mampu membuat teks dengan penalaran kompleks.

Saat ini model menghasilkan kalimat yang kurang memiliki struktur kalimat penuh dan secara keseluruhan tidak masuk akal, tetapi ini normal untuk ukuran pelatihan.

# Perilaku & Keterbatasan Model V0.5

Ini adalah peningkatan yang baik dibandingkan model sebelumnya. Gaya penulisan dan kosakata bernuansa Victorian dan hampir setiap kalimat secara tata bahasa benar dengan tanda baca yang tepat. Dan sekali lagi ini dilatih dari awal sehingga tetap pada subjek tahun 1800-an.

![Contoh Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Ada banyak halusinasi faktual. Banyak (sekitar 100%) detail (tanggal, peristiwa, tokoh sejarah) dibuat-buat. Selain itu, kalimat-kalimatnya tidak benar-benar saling berhubungan, kadang mungkin 2 kalimat saling berkaitan tetapi di luar itu tidak. Masalah lain adalah kadang muncul footer “Digitized by Google” secara acak, jadi pada pelatihan berikutnya saya harus benar-benar memastikan teksnya dibersihkan dengan baik. Secara keseluruhan saya sangat senang dengan hasilnya, ini belum mendekati LLM tetapi jelas sudah menjadi generator kalimat.

Saya banyak belajar dan akan mulai mencari tahu apa yang perlu saya perbaiki dalam beberapa minggu ke depan. Saya akan segera mengunggah file!

# Perilaku & Keterbatasan Model V1

Saya akan segera mengunggah beberapa contoh output dan juga melakukan perbandingan antara 3 model dengan prompt yang sama. Saya juga akan mengunggah V1 ke huggingface seperti versi saya sebelumnya, akun huggingface saya bisa ditemukan di sini: https://huggingface.co/haykgrigorian/TimeCapsuleLLM

# Rencana Mendatang

(Selesai) Saya akan mulai mengerjakan versi 0.5, alih-alih melatih menggunakan 50 buku, saya akan melatih menggunakan idealnya 500-600 buku. Saat ini saya melatih nanoGPT menggunakan buku dari tahun 1800-1850 dan khususnya dari London. Ada beberapa tantangan seperti memastikan buku yang saya temukan tidak diperbarui atau memiliki interpretasi modern tetapi benar-benar buku asli yang diterbitkan dalam periode waktu yang saya pilih.

Saya ingin melatih model baru (v1) dengan korpus yang jauh lebih besar, mungkin 5-10 kali lebih besar dari yang saya gunakan untuk v0.5. Tujuan saya adalah melihat apakah kemampuan penalaran dapat muncul hanya dari Selective Temporal Training, ini akan menjadi tugas yang lebih sulit dan saya bahkan belum yakin apakah itu mungkin karena keterbatasan data sejarah. Dalam beberapa minggu ke depan saya akan mencoba mengkurasi cukup data untuk korpus 5-10GB. Saya yakin jika saya bisa mendapatkan data bersih berkualitas tinggi dan menyewa GPU, akan ada kemajuan.

# Cara Menggunakan Proyek Ini

Proyek ini berfokus terutama pada mengkurasi data sejarah, mempersiapkannya untuk pelatihan dan membuat tokenizer. Saya tidak akan membahas seluruh proses pelatihan LLM, untuk itu silakan merujuk ke nanoGPT oleh Andrej Karpathy.

# Langkah 1: Kumpulkan dan Siapkan Teks Sejarah

Kumpulkan file .txt dari buku domain publik, dokumen, dsb dari periode waktu pilihan Anda (misal, London 1800-1850)

Anda dapat menggunakan download_texts_improved.py untuk mengunduh buku jika diperlukan.

Bersihkan file teks menggunakan skrip atau secara manual hapus header/footer dari Project Gutenberg, anotasi modern atau kesalahan OCR.

prepare_dataset.py harus berfungsi dengan baik.

# Langkah 2: Bangun Tokenizer Khusus

Jalankan train_tokenizer.py atau train_tokenizer_hf.py pada data yang sudah dibersihkan.
Ini akan menghasilkan vocab.json dan merges.txt
File-file ini mendefinisikan kosakata dan aturan penggabungan untuk model Anda

# Langkah 3: Latih Model Anda (nanoGPT)

Lihat [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) untuk proses pelatihan.

Anda dapat melatih LLM lain jika Anda mau, tetapi saya menggunakan nanoGPT

# FAQ

## Apa itu Pelatihan Temporal Selektif?

Pelatihan Temporal Selektif (STT) adalah metodologi machine learning di mana semua data pelatihan dikurasi khusus agar berada dalam periode waktu sejarah tertentu. Hal ini dilakukan untuk memodelkan bahasa dan pengetahuan dari era tersebut tanpa pengaruh konsep modern. Sebagai contoh, model yang saya punya sekarang (v0.5) dilatih dengan data eksklusif dari tahun 1800-1875, tidak di-fine tune tetapi dilatih dari awal sehingga menghasilkan output yang mencerminkan gaya bahasa dan konteks sejarah pada periode tersebut.

## Mengapa tidak menggunakan fine-tuning atau LoRA saja?

Untuk proyek ini saya mencoba membuat model bahasa yang tidak terpengaruh oleh bias modern. Jika saya melakukan fine-tuning pada sesuatu seperti GPT-2, model tersebut sudah dilatih sebelumnya dan informasi itu tidak akan hilang. Jika saya melatih dari awal, model bahasa tidak akan berpura-pura menjadi tua, memang benar-benar demikian. Tujuan proyek saat ini adalah membuat sesuatu yang dapat bernalar hanya dengan pengetahuan dari buku-buku London yang diterbitkan antara 1800 dan 1850.

## Data seperti apa yang digunakan untuk pelatihan?

Saya menggunakan buku, dokumen hukum, surat kabar, dan tulisan lain dari London tahun 1800–1850. Daftar yang saya tautkan berisi sekitar 200, tetapi untuk pelatihan pertama saya hanya menggunakan 50 file dengan total sekitar ~187 MB. Anda dapat melihat daftar dokumennya:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Seberapa besar model-modelnya?

V0: 16M Parameter

V0.5: 123M Parameter

V1: 700M Parameter

# Spesifikasi Pelatihan?

#V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.

#V1

GPU: A100 rented









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---