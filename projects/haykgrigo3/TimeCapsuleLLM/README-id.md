<div align="right">
  <details>
<summary>🌐 Bahasa</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Sebuah model bahasa yang dilatih **dari awal** secara eksklusif pada data dari tempat dan periode waktu tertentu untuk mengurangi bias modern dan meniru suara, kosa kata, dan pandangan dunia dari era tersebut.*

Bayangkan jika sebuah model AI tidak hanya berpura-pura menjadi historis tetapi benar-benar demikian.

v0 dan v0.5 dibangun di atas [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) Script pelatihan inti dan arsitektur model adalah karya beliau.

v1 dibangun di atas [Phi 1.5 oleh Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 dibangun di atas llamaforcausallm

[Tautan Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Status Riset
Proyek ini dimulai dan dikembangkan secara independen.

Saat ini dilakukan di bawah supervisi akademik, dengan kolaborasi riset yang terafiliasi di Muhlenberg College & Georgia State University.

## Sitasi

Jika Anda menggunakan dataset atau model ini dalam karya akademik, mohon sitasi:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

## Bergabunglah dengan Vintage LLM Discord

Jika Anda tertarik dengan **model bahasa historis**, **dataset khusus waktu**, atau masa depan proyek seperti **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox** silakan bergabung dengan komunitas ini.

Kami menggunakan server untuk mendiskusikan ide, berbagi perkembangan, dan terhubung dengan orang lain yang membangun di bidang ini.

[Bergabung dengan Discord](https://discord.gg/JeWkk4z5)

## Sponsor

<div align="center">
  <a href="https://doloffer.com">
    <img src="https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/logo.png" width="500">
  </a>
</div>

Terima kasih kepada DolOffer atas dukungannya pada proyek ini!

DolOffer adalah platform yang berfokus pada rekomendasi produk digital dan berbagi diskon, membantu pengguna dengan cepat menemukan alat, layanan, dan penawaran terbatas yang layak dicoba. Platform ini menawarkan berbagai layanan berlangganan populer, termasuk YouTube Premium, Claude, ChatGPT Plus, Spotify, dan Apple Music, dengan harga serendah 30% dari harga resmi atau bahkan lebih murah.

Daftar sekarang melalui tautan eksklusif ini [doloffer](https://doloffer.com/en/), dan masukkan kode promo AI8888 saat isi saldo untuk menikmati tambahan diskon 10%.

##  Perilaku & Keterbatasan Model

### **v0**  

Prompt awal menunjukkan model merespons dengan bahasa dan perilaku tahun 1800-an. 
Contoh: Prompt: "Who art Henry?" dan model membalas "I know that man, I have did not a black, the storm." 

![Contoh Output TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Tidak menyebutkan konsep modern  
- Kebanyakan kosakata sesuai era  
- Kalimat sebagian besar tidak koheren (diharapkan untuk data pelatihan ~187MB)

### **v0.5-london** 

Peningkatan signifikan dari v0.  
- Gaya penulisan Victoria, tanda baca yang benar, sebagian besar kalimat sudah gramatikal  
- Masih terdapat tingkat halusinasi faktual yang tinggi  
- Noise OCR (“Digitized by Google”) masih muncul dalam output

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Model pertama yang dapat mengingat dan menghubungkan sebuah peristiwa sejarah nyata dengan tokoh asli dari dataset.

Contoh: Prompt: "It was the year of our Lord 1834" 

Output-nya: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Awalnya saya mengira bahwa sebuah protes mungkin saja terjadi secara kebetulan pada tahun yang sama, tetapi lihatlah ini: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

Dilatih menggunakan sampel 15GB dari dataset v2 yang berukuran 90GB.
Model dilatih hanya sampai 10K langkah.

Terdapat masalah pada tokenisasi yang menyebabkan output menjadi seperti ini:

PROMPT:
Siapakah Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Dikoreksi:

"Siapakah Charles Dickens? Apakah karya itu lebih banyak dari kegemilangan yang menggetarkan, dalam dramanya, di ladang Perusahaan Besar? Apa yang belum saya kutip dari Jack Pickett? Tidakkah Anda tahu bahwa mereka adalah semacam berlari kencang, atau menggergaji dada mereka, atau apa yang harus dilakukan sekitar waktu ketika Jackson sedang melihat ke jendela? Apa keberhasilan seorang Inggris, dan yang belum ditemukan oleh putranya kepada saya, sehingga dapat mencapai beban seperti itu? Pernahkah Anda membuat perjalanan ke jalan lama, atau ke angin jangkar di kaki perahu kami, yang harus Anda tinggalkan? Faktanya adalah, apakah angin akan naik dari dataran pada Sabtu malam atau tengah hari, atau hingga ke utara, atau sebaliknya, kita akan terpaksa menggambarkan penghalang yang mengerikan, dengan efek yang sama seperti saat ini. Dalam situasi ini, setidaknya, tidak terlalu berlebihan untuk mengatakan bahwa kita telah meninggalkan ruangan itu. Saya percaya ada tiga salinan dalam 'Lima Ratus Kali Lipat,' yang dapat dirujuk, sebagai nomor pertama dari pembaca kami yang menginginkan t[o]..."

### **v2mini-eval2-london**

Dilatih menggunakan sampel 15GB yang sama seperti yang digunakan untuk pelatihan eval1.
Model ini juga hanya dilatih hingga 10K langkah.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Tuan, — Kasus berikut menarik bagi saya: — Saya berada di London selama dua minggu, dan sangat terpengaruh oleh serangan rematik. Serangan rematik pertama terjadi seminggu sebelum saya bertemu Anda, yang kedua saat saya bertemu Anda, dan yang ketiga juga pada saat yang sama. Namun serangan asam urat kedua tidak disertai gejala demam, tetapi disertai dengan peningkatan aliran urin, dan keluarnya urin yang lebih banyak. Serangan ketiga terjadi satu jam setelah saya bertemu Anda, dan diikuti oleh kembalinya serangan asam urat, dan kembalinya asam urat yang lebih cepat. Serangan keempat juga disertai demam, tetapi tidak selalu disertai gejala demam. Serangan asam urat ketiga terjadi dua minggu setelah Anda sakit, dan yang keempat diikuti oleh serangan asam urat. Serangan keempat terjadi dua minggu setelah Anda terserang, dan disertai dengan rasa

### **v2-london**

Dilatih menggunakan dataset 90GB (112GB sudah di-tokenisasi)
Dilatih hingga 182K langkah

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **Apa selanjutnya?**

- Pengembangan telah dimulai pada TimeCapsuleLLM v3
- Memperbesar ukuran dataset dan cakupan geografis
- Perluasan melampaui London ke kota-kota tambahan

Pekerjaan ini dilakukan bersama para peneliti dari Muhlenberg College & Georgia State University.


##  Dataset

### **v2**

- 90GB(mentah) teks London tahun 1800-1875
- 136.344 dokumen
- Dataset ter-tokenisasi lengkap sekarang tersedia di sini: https://huggingface.co/datasets/postgrammar/london-llm-1800

### Statistik Bias
  ![Bias Pronomina](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Bias Geografis](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Bias Temporal](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Lihat [laporan bias v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) untuk info lebih lanjut.


- 


## Cara Menggunakan

Proyek ini berfokus terutama pada kurasi data sejarah, menyiapkannya untuk pelatihan dan membangun tokenizer. Saya tidak akan membahas proses pelatihan LLM secara penuh, untuk itu silakan merujuk ke nanoGPT oleh Andrej Karpathy.

### Langkah 1: Kumpulkan dan Siapkan Teks Sejarah

- Kumpulkan file .txt dari buku domain publik, dokumen, dll dari periode waktu yang dipilih (misal, London 1800-1875)
- Simpan dalam rentang waktu/tempat yang dipilih
- Bersihkan file teks menggunakan skrip atau hapus manual header/footer dari Project Gutenberg, anotasi modern atau kesalahan OCR.

### Langkah 2: Bangun Tokenizer Kustom

- Jalankan train_tokenizer.py atau train_tokenizer_hf.py pada data yang sudah dibersihkan.
- Ini akan menghasilkan vocab.json dan merges.txt
- File-file ini mendefinisikan vocab dan aturan penggabungan untuk model Anda

### Langkah 3: Latih Model Anda

- Lihat [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) untuk proses pelatihan atau dokumentasi arsitektur pilihan Anda.

# FAQ

## Apa itu Selective Temporal Training?

Selective Temporal Training (STT) adalah metodologi machine learning di mana semua data pelatihan secara khusus dikurasi agar berada dalam rentang waktu sejarah tertentu. Tujuannya untuk memodelkan bahasa dan pengetahuan pada masa itu tanpa pengaruh konsep modern. Misalnya, model saya saat ini (v0.5) dilatih hanya dengan data tahun 1800-1875, tidak fine tuned tapi dilatih dari awal sehingga hasilnya mencerminkan gaya bahasa dan konteks sejarah masa tersebut.

## Kenapa tidak cukup fine-tuning atau LoRA saja?
Untuk proyek ini saya mencoba membuat model bahasa yang tidak terpengaruh oleh bias modern. Jika saya fine-tune sesuatu seperti GPT-2, model itu sudah pre-trained dan informasi tersebut tidak akan hilang. Jika saya melatih dari awal, model bahasa tidak akan berpura-pura kuno, memang aslinya begitu. Tujuan proyek ini saat ini adalah menciptakan sesuatu yang dapat bernalar secara eksklusif menggunakan pengetahuan dari buku-buku London yang diterbitkan antara tahun 1800 hingga 1875.

## Data seperti apa yang Anda gunakan untuk pelatihan?

Saya menggunakan buku, dokumen hukum, surat kabar, dan tulisan lain dari London 1800–1875. Daftar yang saya tautkan (untuk v0) berisi sekitar 200 dokumen, tetapi untuk pelatihan pertama saya hanya menggunakan 50 file sekitar ~187 MB. Anda dapat melihat daftar dokumennya:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Ukuran dataset:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB (sampel dari v2 yang 90GB)
- v2: 90GB

## Seberapa besar modelnya?

v0: 16M Parameter

v0.5: 123M Parameter

v1: 700M Parameter

v2mini-eval1: 300M Parameter

v2mini-eval2: 200M Parameter

v2: 1.2B Parameter

## Spesifikasi Pelatihan?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

### v1
GPU: A100 SXM sewa

### v2mini-eval1/eval2

GPU: A100 SXM disewa

### v2
GPU: H100 SXM disewa

## Pekerjaan Terkait

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  -  LLM dengan 13B parameter yang dilatih pada 260B token teks sebelum tahun 1930 dengan Q&A. Terdapat juga versi [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base).
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  LLM dengan 1.4B parameter yang dilatih pada teks tahun 1800-1899 dengan Q&A. Terdapat juga versi [160M](https://huggingface.co/zakarth/violet-160m-chat).
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  LLM dengan 340M parameter yang dilatih pada lebih dari 28.000 teks antara tahun 1837-1899 dengan Q&A. 

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - sebuah keluarga LLM 4B parameter berbasis arsitektur Qwen3 yang dilatih dari awal pada 80B token data sejarah hingga batas pengetahuan 1913,1929,1933,1939,1946.
 
- **[TypewriterLM](https://huggingface.co/typewriter-ai/typewriter-1913-7B-base)**
  - model bahasa sejarah (LM) 7.24B yang hanya dilatih pada teks bahasa Inggris sebelum tahun 1913. Dibuat oleh peneliti dari University of Waterloo, Adelaide University, University of Oxford, dan University College London. [Tautan ke makalah](https://arxiv.org/abs/2606.02991)

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT adalah finetune dari Mistral-Hermes 2 pada 11.000 teks awal modern dalam bahasa Inggris, Prancis, dan Latin, sebagian besar berasal dari EEBO dan Gallica.

## Ucapan Terima Kasih

Saya ingin berterima kasih kepada [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) atas supervisi akademik, bimbingan dalam perancangan dan evaluasi riset, serta bantuan dalam pelatihan tokenizer dan persiapan dataset untuk rilis v2. Masukan dan pengalamannya sangat berperan dalam memperbaiki penyajian karya ini.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---