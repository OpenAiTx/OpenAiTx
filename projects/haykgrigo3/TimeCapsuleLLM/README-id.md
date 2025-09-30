
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

*Model bahasa yang dilatih **dari awal** hanya menggunakan data dari tempat dan periode waktu tertentu untuk mengurangi bias modern dan meniru suara, kosakata, serta cara pandang era tersebut.*

Bayangkan jika sebuah model AI tidak hanya berpura-pura menjadi historis, tetapi benar-benar demikian.

v0 dan v0.5 dibangun di atas [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) Script pelatihan inti dan arsitektur model adalah karya beliau. 

v1 dibuat berdasarkan [Phi 1.5 oleh Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Link Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)


##  Perilaku Model & Keterbatasan

### **v0**  

Prompt awal menunjukkan model merespon dengan bahasa dan perilaku abad ke-1800. 
Contoh: Prompt: "Siapakah Henry?" dan model menjawab "Aku tahu orang itu, aku tidak punya hitam, badai itu."

![Contoh Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Tidak menyebutkan konsep modern  
- Sebagian besar kosa kata akurat era  
- Kalimat sebagian besar tidak koheren (diharapkan untuk data pelatihan ~187MB)

### **v0.5** 

Peningkatan signifikan dibanding v0.  
- Gaya penulisan Victoria, tanda baca yang benar, sebagian besar kalimat gramatikal  
- Tingkat halusinasi fakta masih tinggi  
- Noise OCR (“Digitized by Google”) masih muncul dalam output

![Contoh Output TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Model pertama yang dapat mengingat dan menghubungkan peristiwa sejarah nyata dengan tokoh sebenarnya dari dataset.

Contoh: Prompt: "Itu adalah tahun Tuhan kami 1834" 

Output-nya: "Itu adalah tahun Tuhan kami 1834 dan jalanan London dipenuhi dengan protes dan petisi. Penyebabnya, seperti yang banyak diceritakan, tidak terikat secara pribadi, tetapi telah diangkat pada hari yang sama oleh Lord Palmerston, publik akan menerima pernyataan singkat tentang kesulitan yang kami alami. Ini sangat disesalkan, bahwa peristiwa saat ini dalam sejarah dunia sudah jelas, dan karenanya akan diketahui. Tidak benar bahwa orang-orang yang pertama menetap di Injil di Yerusalem harus memiliki catatan yang begitu luas dan menarik tentang kemakmuran dan kemakmuran"

Awalnya saya kira protes memang kebetulan terjadi di tahun yang sama, tapi lihat ini: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Mengapa ini penting:

Ini adalah contoh pertama dari salah satu model saya yang menghubungkan tahun dengan peristiwa sejarah nyata dan tokoh nyata yang terkait dengan peristiwa tersebut (Lord Palmerston). Model sebelumnya (v0 dan v0.5) hanya bisa meniru gaya penulisan abad ke-19 namun selalu menghalusinasi peristiwa, orang, dan fakta. Ini menunjukkan model mulai mengingat hal-hal dari dataset

## Rencana Mendatang

- Ada hampir 175.000 teks yang diterbitkan di London dari tahun 1800-1875 di Internet Archive
- Saya berencana untuk memperluas korpus dan membersihkannya lebih lanjut untuk kemampuan penalaran yang lebih baik
- Memperluas ke wilayah dan periode waktu yang berbeda untuk model historis yang lebih beragam

## Cara Menggunakan

Proyek ini berfokus terutama pada kurasi data historis, menyiapkannya untuk pelatihan dan membangun tokenizer. Saya tidak akan membahas proses pelatihan LLM secara lengkap, untuk itu silakan merujuk ke nanoGPT oleh Andrej Karpathy.

### Langkah 1: Kumpulkan dan Siapkan Teks Historis

- Kumpulkan file .txt dari buku domain publik, dokumen, dan sebagainya dari periode waktu pilihan Anda (misal: London 1800-1850)
- Simpan file tersebut dalam rentang waktu/tempat yang Anda pilih
- Bersihkan file teks menggunakan skrip atau secara manual hapus header/footer dari Project Gutenberg, anotasi modern, atau hal seperti kesalahan OCR.

### Langkah 2: Bangun Tokenizer Kustom

- Jalankan train_tokenizer.py atau train_tokenizer_hf.py pada data yang sudah dibersihkan.
- Ini akan menghasilkan vocab.json dan merges.txt
- File-file ini mendefinisikan vocab dan aturan penggabungan untuk model Anda

### Langkah 3: Latih Model Anda

- Lihat [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) untuk proses pelatihan atau dokumentasi arsitektur pilihan Anda.

# FAQ

## Apa itu Selective Temporal Training?

Selective Temporal Training (STT) adalah metodologi machine learning di mana semua data pelatihan dikurasi secara khusus agar berada dalam periode waktu historis tertentu. Hal ini dilakukan untuk memodelkan bahasa dan pengetahuan dari era tersebut tanpa pengaruh konsep modern. Misalnya, model yang saya miliki sekarang (v0.5) dilatih pada data yang eksklusif dari 1800-1875, tidak di-fine tune tetapi dilatih dari awal sehingga hasilnya mencerminkan gaya linguistik dan konteks historis dari periode waktu itu.

## Mengapa tidak hanya menggunakan fine-tuning atau LoRA?

Untuk proyek ini saya berusaha membuat model bahasa yang bebas dari bias modern. Jika saya fine-tune sesuatu seperti GPT-2, model tersebut sudah pra-latih dan informasi itu tidak akan hilang. Jika saya melatih dari awal, model bahasa tidak akan berpura-pura menjadi tua, tapi memang akan demikian. Tujuan proyek ini saat ini adalah untuk menciptakan sesuatu yang dapat bernalar secara eksklusif menggunakan pengetahuan dari buku-buku London yang diterbitkan antara tahun 1800 dan 1875.

## Data seperti apa yang Anda gunakan untuk pelatihan?


Saya menggunakan buku, dokumen hukum, surat kabar, dan tulisan lainnya dari London tahun 1800–1875. Daftar yang saya tautkan (untuk v0) berisi sekitar 200 dokumen, tetapi untuk pelatihan pertama saya hanya menggunakan 50 file dengan total sekitar ~187 MB. Anda dapat melihat daftar dokumennya di:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Ukuran dataset:
v0: ~187MB
v0.5: ~435MB 
v1: ~6.25GB 

## Seberapa besar modelnya?

V0: 16M Parameter

V0.5 123M Parameter

V1: 700M Parameter

# Spesifikasi Pelatihan? 

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# V1
GPU: A100 sewaan















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---