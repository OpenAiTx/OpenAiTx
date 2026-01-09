<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW">繁體中文</a> 
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as">हिन्दी</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th">ไทย</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es">Español</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar">العربية</a>
        | <a href="#" title="Segera hadir">فارسی (segera hadir)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Segera hadir">Bahasa Indonesia (segera hadir)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*Sebuah model bahasa yang dilatih **dari awal** hanya menggunakan data dari tempat dan periode waktu tertentu untuk mengurangi bias modern dan meniru suara, kosakata, serta cara pandang zaman tersebut.*

Bayangkan jika sebuah model AI tidak hanya berpura-pura menjadi sejarah, tapi benar-benar merupakan sejarah.

v0 dan v0.5 dibangun menggunakan [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) Script pelatihan inti dan arsitektur model merupakan karya beliau. 

v1 dibangun di atas [Phi 1.5 oleh Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Tautan Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  Perilaku & Keterbatasan Model

### **v0**  

Prompt awal menunjukkan model merespons dengan bahasa dan perilaku tahun 1800-an.
Contoh: Prompt: "Who art Henry?" dan model menjawab "I know that man, I have did not a black, the storm."

![Keluaran Contoh TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Tidak ada penyebutan konsep modern  
- Kosakata sebagian besar sesuai era  
- Kalimat sebagian besar tidak koheren (diharapkan untuk data pelatihan ~187MB)

### **v0.5** 

Peningkatan signifikan dibandingkan v0.  
- Gaya penulisan Victoria, tanda baca yang benar, sebagian besar kalimat gramatikal  
- Tingkat halusinasi fakta masih tinggi  
- Noise OCR (“Digitized by Google”) masih muncul dalam keluaran

![Keluaran Contoh TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Model pertama yang mengingat dan menghubungkan peristiwa sejarah nyata dengan figur nyata dari dataset.

Contoh: Prompt: "It was the year of our Lord 1834"

Keluaran: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"

Awalnya saya mengira protes mungkin kebetulan terjadi pada tahun yang sama, tapi lihat ini: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Dilatih menggunakan sampel 15GB dari dataset v2 sebesar 90GB.

Model hanya dilatih hingga 10K langkah.

Terjadi masalah dengan tokenisasi yang menyebabkan output terlihat seperti ini:

PROMPT:
Siapa Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Diperbaiki:

"Siapa Charles Dickens? Apakah itu lebih banyak dari karya-karya hebatnya yang menggugah, dalam dramanya, di pertanian Great Company? Apa yang belum saya kutip dari Jack Pickett? Tidakkah kamu tahu bahwa mereka adalah semacam berlari kencang, atau menggergaji dada mereka, atau apa yang harus dilakukan sekitar waktu ketika Jackson sedang melihat ke jendela? Apa keberhasilan seorang Inggris, dan yang belum ditemukan oleh putranya untukku, sehingga dapat mencapai beban sebesar itu? Pernahkah kamu membuat perjalanan ke jalan raya lama, atau ke angin jangkar di kaki perahu kami, yang harus kamu tinggalkan? Faktanya adalah, apakah angin itu akan naik dari dataran pada Sabtu malam atau tengah hari, atau ke utara, atau lainnya, kita akan dipaksa untuk menggambarkan penghalang yang tangguh, dengan efek yang sama seperti saat ini. Dalam situasi ini, setidaknya, tidak terlalu berlebihan untuk mengatakan bahwa kita telah meninggalkan ruangan itu. Saya percaya ada tiga salinan di 'Lima Ratus Kali Lipat', untuk dirujuk, sebagai nomor pertama dari pembaca kami yang ingin t[o]...”

### **v2mini-eval2**

Dilatih menggunakan sampel 15GB yang sama seperti yang digunakan untuk pelatihan eval1.
Model kembali dilatih hanya sampai 10K langkah.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Tuan, — Kasus berikut menarik bagi saya: — Saya berada di London selama dua minggu, dan sangat terpengaruh oleh serangan rematik. Serangan pertama rematik terjadi seminggu sebelum saya bertemu Anda, dan serangan kedua ketika saya bertemu Anda, dan ketiga ketika saya bertemu Anda, dan ketiga dalam waktu yang sama. Namun, serangan kedua asam urat tidak disertai gejala demam, tetapi disertai dengan peningkatan aliran urin, dan keluarnya urin yang lebih banyak. Serangan ketiga terjadi satu jam setelah saya bertemu Anda, dan diikuti dengan kekambuhan asam urat, dan kembalinya asam urat dengan lebih cepat. Serangan keempat juga disertai demam, tetapi tidak selalu disertai gejala demam. Serangan ketiga asam urat terjadi dua minggu setelah Anda sakit, dan yang keempat diikuti oleh kekambuhan asam urat. Serangan keempat terjadi dua minggu setelah Anda diserang, dan disertai dengan rasa


##  Dataset

### **v2**

- 90GB teks London tahun 1800-1875
- 136.344 dokumen
- Seluruh 90GB belum tersedia karena belum ditokenisasi, namun Anda dapat menemukan sampel 15GB di sini: https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### Statistik Bias 
  ![Bias pronomina](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Bias geografis](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Bias temporal](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Lihat [laporan bias v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) untuk info lebih lanjut.


## Cara Penggunaan

Proyek ini berfokus pada kurasi data historis, persiapan data untuk pelatihan, dan pembuatan tokenizer. Saya tidak akan membahas seluruh proses pelatihan LLM, untuk itu silakan lihat nanoGPT oleh Andrej Karpathy.

### Langkah 1: Kumpulkan dan Siapkan Teks Historis

- Kumpulkan file .txt dari buku domain publik, dokumen, dll dari periode waktu yang Anda pilih (misalnya, London 1800-1850)
- Jaga agar tetap dalam jendela waktu/tempat yang Anda pilih  
- Bersihkan file teks menggunakan skrip atau hapus secara manual header/footer dari Project Gutenberg, anotasi modern, atau hal-hal seperti kesalahan OCR.

### Langkah 2: Bangun Tokenizer Kustom

- Jalankan train_tokenizer.py atau train_tokenizer_hf.py pada data yang telah dibersihkan.
- Ini akan menghasilkan vocab.json dan merges.txt
- File-file ini mendefinisikan vocab dan aturan penggabungan untuk model Anda

### Langkah 3: Latih Model Anda

- Lihat [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) untuk proses pelatihan atau dokumentasi arsitektur pilihan Anda.

# FAQ

## Apa itu Selective Temporal Training ?

Selective Temporal Training (STT) adalah metodologi machine learning di mana semua data pelatihan dikurasi khusus agar masuk dalam periode waktu historis tertentu. Ini dilakukan untuk memodelkan bahasa dan pengetahuan dari era tersebut tanpa pengaruh konsep modern. Misalnya, model yang saya miliki saat ini (v0.5) dilatih dengan data eksklusif dari tahun 1800-1875, tidak fine tuned tetapi dilatih dari awal sehingga menghasilkan output yang mencerminkan gaya bahasa dan konteks sejarah periode tersebut.

## Kenapa tidak menggunakan fine-tuning atau LoRA saja?

Untuk proyek ini saya mencoba membuat model bahasa yang tidak terpengaruh bias modern. Jika saya fine-tune sesuatu seperti GPT-2, model tersebut sudah pre-trained dan informasi itu tidak akan hilang. Jika saya melatih dari awal, model bahasa tidak akan berpura-pura menjadi tua, memang benar-benar seperti itu. Tujuan dari proyek ini sekarang adalah menciptakan sesuatu yang dapat bernalar hanya menggunakan pengetahuan dari buku-buku London yang diterbitkan antara 1800 dan 1875.

## Data seperti apa yang Anda gunakan untuk pelatihan?

Saya menggunakan buku, dokumen hukum, surat kabar, dan tulisan lain dari London tahun 1800–1875. Daftar yang saya tautkan (untuk v0) ada sekitar 200, tapi untuk pelatihan pertama saya hanya memakai 50 file sekitar ~187 MB. Anda dapat melihat daftar dokumennya:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Ukuran dataset:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB

## Seberapa besar modelnya?

v0: 16M Parameter

v0.5 123M Parameter

v1: 700M Parameters

v2mini-eval1: 300M Parameters

# Training Specs ? 

# v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# v1
GPU: A100 SXM rented

# v2mini-eval1

GPU: A100 SXM rented





























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---