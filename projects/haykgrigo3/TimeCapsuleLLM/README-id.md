<div align="right">
  <details>
<summary>🌐 Bahasa</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Sebuah model bahasa yang dilatih **dari awal** secara eksklusif menggunakan data dari tempat dan periode waktu tertentu untuk mengurangi bias modern dan meniru suara, kosakata, serta pandangan dunia era tersebut.*

Bayangkan jika sebuah model AI tidak hanya berpura-pura menjadi historis, tetapi benar-benar historis.

v0 dan v0.5 dibangun di atas [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) Skrip pelatihan inti dan arsitektur model adalah karya beliau.

v1 dibangun di atas [Phi 1.5 oleh Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 dibangun di atas llamaforcausallm

[Link Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Status Riset
Proyek ini dimulai dan dikembangkan secara independen.

Saat ini dilakukan di bawah supervisi akademik, dengan kolaborasi riset yang berafiliasi di Muhlenberg College.

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

##  Perilaku & Keterbatasan Model

### **v0**  

Prompt awal menunjukkan model merespons dengan bahasa dan perilaku tahun 1800-an. 
Contoh: Prompt: "Siapakah Henry?" dan model menjawab "Saya mengenal orang itu, saya belum melakukan yang hitam, badai." 

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Tidak ada penyebutan konsep modern  
- Kosakata sebagian besar sesuai era  
- Kalimat sebagian besar tidak koheren (diharapkan untuk data pelatihan ~187MB)

### **v0.5** 

Peningkatan signifikan dibandingkan v0.  
- Gaya penulisan Victoria, tanda baca yang benar, kalimat sebagian besar gramatikal  
- Tingkat halusinasi faktual masih tinggi  
- Noise OCR (“Digitized by Google”) masih muncul dalam output

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Model pertama yang dapat mengingat dan menghubungkan peristiwa sejarah nyata dengan tokoh sesungguhnya dari dataset.

Contoh: Prompt: "Itu adalah tahun Tuhan kami 1834" 

Output: "Itu adalah tahun Tuhan kami 1834 dan jalan-jalan di London dipenuhi dengan protes dan petisi. Penyebabnya, sebagaimana banyak yang diceritakan, tidak terikat secara pribadi, tetapi telah diambil pada hari yang sama pada hari Lord Palmerston, publik akan menerima pernyataan singkat tentang kesulitan yang telah kita hadapi dalam hukum. Merupakan penyesalan mendalam, bahwa peristiwa saat ini dalam sejarah dunia sudah jelas, dan karenanya akan diketahui. Tidak benar bahwa orang-orang yang pertama kali menetap dalam Injil di Yerusalem harus memiliki catatan kemakmuran yang begitu luas dan menarik" 

Awalnya saya menduga bahwa protes mungkin kebetulan terjadi pada tahun yang sama tetapi lihat ini: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Dilatih menggunakan sampel 15GB dari dataset 90GB milik v2.
Model hanya dilatih hingga 10K langkah.

Ada masalah dengan tokenisasi yang menyebabkan output terlihat seperti ini:

Siapa Charles Dickens?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Diperbaiki:

"Siapakah Charles Dickens? Apakah karya itu lebih banyak dari karya luar biasa lainnya, dalam dramanya, di pertanian Great Company? Apa yang harus saya kutip dari Jack Pickett? Tidakkah kamu tahu bahwa mereka semacam berlari kencang, atau menggergaji dada mereka, atau apa yang harus dilakukan pada waktu saat Jackson sedang melihat ke jendela? Apa kesuksesan seorang Inggris, dan yang belum ditemukan oleh anaknya kepada saya, sehingga dapat menyelesaikan beban seperti itu? Pernahkah kamu membuat perjalanan ke jalan lama itu, atau ke angin jangkar di kaki perahu kita, yang harus kamu tinggalkan? Faktanya, apakah angin akan bangkit dari dataran pada Sabtu malam atau siang hari, atau ke utara, atau sebaliknya, kita akan dipaksa untuk menggambarkan penghalang yang tangguh, dengan efek yang sama seperti sekarang. Dalam situasi ini, setidaknya, tidak berlebihan jika dikatakan bahwa kita telah meninggalkan ruangan itu. Saya percaya ada tiga salinan di 'Five Hundred-fold,' yang bisa dirujuk, sebagai nomor pertama dari pembaca kami yang ingin t[o]..."

### **v2mini-eval2**

Dilatih menggunakan sampel 15GB yang sama seperti yang digunakan untuk pelatihan eval1.
Model kembali dilatih hingga hanya 10K langkah.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Tuan, — Kasus berikut menarik bagi saya : — Saya berada di London selama dua minggu, dan sangat terpengaruh oleh serangan rematik. Serangan rematik pertama terjadi seminggu sebelum saya bertemu Anda, dan yang kedua ketika saya bertemu Anda, dan yang ketiga ketika saya bertemu Anda, dan yang ketiga pada waktu yang sama. Namun, serangan asam urat kedua tidak disertai dengan gejala demam, tetapi disertai peningkatan aliran urin, dan dengan keluarnya urin yang lebih banyak. Serangan ketiga terjadi satu jam setelah saya bertemu Anda, dan diikuti dengan kambuhnya serangan asam urat, dan kembalinya asam urat yang lebih cepat. Serangan keempat juga disertai demam, tetapi tidak selalu disertai gejala demam. Serangan ketiga asam urat terjadi dua minggu setelah Anda sakit, dan yang keempat diikuti oleh serangan asam urat. Serangan keempat terjadi dua minggu setelah Anda diserang, dan disertai dengan sensasi

### **v2**

Dilatih menggunakan dataset 90GB (112GB yang telah di-tokenisasi)
Dilatih hingga 182K langkah 

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  Dataset

### **v2**

- 90GB(mentah) teks London tahun 1800-1875
- 136.344 dokumen
- Dataset tokenisasi lengkap kini tersedia di sini: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### Statistik Bias 
  ![Bias pronomina](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Bias geografis](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Bias temporal](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Lihat [laporan bias v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) untuk informasi lebih lanjut.

## Cara Menggunakan

Proyek ini berfokus terutama pada mengkurasi data historis, menyiapkannya untuk pelatihan dan membangun tokenizer. Saya tidak akan membahas proses pelatihan LLM secara penuh, untuk itu silakan merujuk ke nanoGPT oleh Andrej Karpathy.

### Langkah 1: Kumpulkan dan Siapkan Teks Historis

- Kumpulkan file .txt dari buku domain publik, dokumen, dll dari periode waktu pilihan Anda (misal, London 1800-1850)
- Simpan dalam rentang waktu/tempat yang Anda pilih  
- Bersihkan file teks menggunakan skrip atau secara fitting hapus header/footer dari Project Gutenberg, anotasi modern, atau hal seperti kesalahan OCR.

### Langkah 2: Bangun Tokenizer Kustom

- Jalankan train_tokenizer.py atau train_tokenizer_hf.py pada data yang telah dibersihkan.
- Ini akan menghasilkan vocab.json dan merges.txt
- File-file ini mendefinisikan vocab dan aturan merge untuk model Anda

### Langkah 3: Latih Model Anda

- Lihat [nanoGPT oleh Andrej Karpathy](https://github.com/karpathy/nanoGPT) untuk proses pelatihan atau dokumentasi arsitektur pilihan Anda.

# FAQ

## Apa itu Selective Temporal Training?

Selective Temporal Training (STT) adalah metodologi machine learning di mana semua data pelatihan secara khusus dikurasi agar berada dalam periode waktu historis tertentu. Ini dilakukan untuk memodelkan bahasa dan pengetahuan zaman itu tanpa pengaruh konsep modern. Misalnya, model saya saat ini (v0.5) dilatih secara eksklusif dengan data dari 1800-1875, tidak fine-tuned tapi dilatih dari awal sehingga menghasilkan output yang mencerminkan gaya linguistik dan konteks historis periode tersebut.

## Mengapa tidak hanya menggunakan fine-tuning atau LoRA?

Untuk proyek ini saya ingin membuat model bahasa yang tidak dipengaruhi bias modern. Jika saya fine-tune sesuatu seperti GPT-2, model itu sudah pra-latih dan informasi tersebut tidak akan hilang. Jika saya melatih dari nol, model bahasa tidak akan hanya berpura-pura kuno, memang benar-benar kuno. Tujuan proyek ini saat ini adalah menciptakan sesuatu yang dapat bernalar secara eksklusif menggunakan pengetahuan dari buku London yang diterbitkan antara 1800 dan 1875.

## Data seperti apa yang Anda gunakan untuk pelatihan?

Saya menggunakan buku, dokumen hukum, surat kabar, dan tulisan lain dari London 1800–1875. Daftar yang saya tautkan (untuk v0) ada or sekitar 200 tapi untuk pelatihan pertama saya hanya menggunakan 50 file sekitar ~187 MB. Anda dapat melihat daftar dokumennya:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Ukuran dataset:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6,25GB

- v2mini-eval1: 15GB (sampel dari 90GB v2)
- v2: 90GB

## Seberapa besar model-modelnya?

v0: 16M Parameter

v0.5 123M Parameter

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
GPU: A100 SXM sewaan

### v2mini-eval1/eval2
GPU: A100 SXM sewaan

### v2
GPU: H100 SXM sewaan

## Ucapan Terima Kasih

Saya ingin mengucapkan terima kasih kepada [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) atas supervisi akademik, bimbingan dalam perumusan dan evaluasi riset, serta bantuan dalam pelatihan tokenizer dan persiapan dataset untuk rilis v2. Masukan dan pengalaman beliau sangat berperan dalam memperbaiki presentasi karya ini.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---