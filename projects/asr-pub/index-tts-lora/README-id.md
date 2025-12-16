
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# index-tts-lora

[Versi Bahasa Mandarin](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [Versi Bahasa Inggris](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

Proyek ini didasarkan pada [index-tts](https://github.com/index-tts/index-tts) dari Bilibili, menyediakan solusi **fine-tuning LoRA** untuk pengaturan **speaker tunggal dan multi-speaker**. Tujuannya untuk meningkatkan **prosidis dan kealamian** dalam sintesis audio speaker berkualitas tinggi.

### Pelatihan & Inferensi

#### 1. Ekstraksi token audio dan kondisi pembicara

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```

Setelah ekstraksi, file yang telah diproses dan `speaker_info.json` akan dihasilkan di bawah direktori `finetune_data/processed_data/`. Sebagai contoh:

```json
[
    {
        "speaker": "kaishu_30min",
        "avg_duration": 6.6729,
        "sample_num": 270,
        "total_duration_in_seconds": 1801.696,
        "total_duration_in_minutes": 30.028,
        "total_duration_in_hours": 0.500,
        "train_jsonl": "/path/to/kaishu_30min/metadata_train.jsonl",
        "valid_jsonl": "/path/to/kaishu_30min/metadata_valid.jsonl",
        "medoid_condition": "/path/to/kaishu_30min/medoid_condition.npy"
    }
]
```

#### 2. Pelatihan

```shell
python train.py
```

#### 3. Inferensi

```shell
python indextts/infer.py
```

### Hasil Fine-tuning

Eksperimen ini menggunakan **data audio berbahasa Mandarin** dari *Kai Shu Tells Stories*, dengan durasi total **\~30 menit** dan **270 klip audio**.
Dataset dibagi menjadi **244 sampel pelatihan** dan **26 sampel validasi**.
Catatan: Transkrip dihasilkan secara otomatis melalui model ASR dan tanda baca, tanpa koreksi manual, sehingga beberapa kesalahan dapat terjadi.

Contoh sampel pelatihan, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Contoh Sintesis Ucapan


| Teks                                                         | Audio                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Jam tua di rumah berhenti pada pukul tiga malam, di antara debu muncul jejak kaki asing. Detektif berjongkok, menemukan cincin berlumur darah tersembunyi di celah lantai. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| Di bawah sinar bulan, labu tiba-tiba tumbuh wajah tersenyum, sulur bergerak mendorong gerbang taman. Gadis kecil berjinjit, mendengar jamur menyenandungkan lagu pengantar tidur kuno. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| Maka di dalam Java tingkat menengah masih harus belajar, M serta pengembangan sistem aplikasi front-end eksternal, harus belajar database Java Script, dan membuat situs web dinamis. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| Laporan keuangan ini menganalisis secara detail kinerja pendapatan dan tren pengeluaran perusahaan selama satu kuartal terakhir. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| Naik gunung turun gunung naik satu gunung, turun satu gunung, lari tiga li tiga meter tiga, mendaki satu gunung tinggi, ketinggian gunung tiga ratus tiga. Sampai di puncak, teriak: Aku lebih tinggi tiga chi tiga dari gunung. | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| Seorang pria kurus terbaring di sisi jalan dengan kemeja dan satu sepatu dilepas serta tas di dekatnya. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| Seiring penelitian berlanjut, efek perlindungan fluoride terhadap kerusakan gigi pun terbukti. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Evaluasi Model
Untuk detail set evaluasi, lihat: [2025 Benchmark of Mainstream TTS Models: Who Is the Best Voice Synthesis Solution?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Ucapan Terima Kasih

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---