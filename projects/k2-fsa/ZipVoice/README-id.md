
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## Teks-ke-Ucapan Zero-Shot yang Cepat dan Berkualitas Tinggi dengan Flow Matching
</div>

## Ikhtisar

ZipVoice adalah serangkaian model TTS zero-shot yang cepat dan berkualitas tinggi berbasis flow matching.

### 1. Fitur utama

- Kecil dan cepat: hanya 123M parameter.

- Kloning suara berkualitas tinggi: performa terbaik dalam kemiripan pembicara, kejelasan, dan kealamian.

- Multi-bahasa: mendukung Bahasa Mandarin dan Inggris.

- Multi-mode: mendukung generasi ucapan pembicara tunggal dan dialog.

### 2. Varian model

<table>
  <thead>
    <tr>
      <th>Nama Model</th>
      <th>Deskripsi</th>
      <th>Paper</th>
      <th>Demo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>Model dasar yang mendukung TTS zero-shot pembicara tunggal dalam Bahasa Mandarin dan Inggris.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>Versi distilasi dari ZipVoice, dengan kecepatan yang ditingkatkan dan penurunan performa yang minimal.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Model generasi dialog yang dibangun di atas ZipVoice, mampu menghasilkan dialog dua pihak dalam satu kanal.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>Varian stereo dari ZipVoice-Dialog, memungkinkan generasi dialog dua saluran dengan masing-masing pembicara ditempatkan pada saluran yang berbeda.</td>
    </tr>
  </tbody>
</table>

## Berita

**2025/07/14**: **ZipVoice-Dialog** dan **ZipVoice-Dialog-Stereo**, dua model generasi dialog lisan, telah dirilis. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: Dataset **OpenDialog**, dataset dialog lisan berdurasi 6.8k-jam, telah dirilis. Unduh di [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Lihat detailnya di [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** dan **ZipVoice-Distill** telah dirilis. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Instalasi

### 1. Clone repositori ZipVoice

```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (Opsional) Buat lingkungan virtual Python


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. Instal paket yang diperlukan


```bash
pip install -r requirements.txt
```
### 4. Instal k2 untuk pelatihan atau inferensi efisien

**k2 diperlukan untuk pelatihan** dan dapat mempercepat inferensi. Namun demikian, Anda masih dapat menggunakan mode inferensi ZipVoice tanpa menginstal k2.

> **Catatan:** Pastikan untuk menginstal versi k2 yang sesuai dengan versi PyTorch dan CUDA Anda. Sebagai contoh, jika Anda menggunakan pytorch 2.5.1 dan CUDA 12.1, Anda dapat menginstal k2 sebagai berikut:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Silakan merujuk ke https://k2-fsa.org/get-started/k2/ untuk detailnya.
Pengguna di Tiongkok daratan dapat merujuk ke https://k2-fsa.org/zh-CN/get-started/k2/.

- Untuk memeriksa instalasi k2:


```bash
python3 -c "import k2; print(k2.__file__)"
```
## Penggunaan

### 1. Pembuatan Ucapan Satu Pembicara

Untuk menghasilkan ucapan satu pembicara dengan model pra-latih ZipVoice atau ZipVoice-Distill kami, gunakan perintah berikut (Model yang diperlukan akan diunduh dari HuggingFace):

#### 1.1 Inferensi satu kalimat


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` dapat berupa `zipvoice` atau `zipvoice_distill`, yang masing-masing adalah model sebelum dan sesudah distilasi.
- Jika `<>` atau `[]` muncul dalam teks, string yang diapit olehnya akan diperlakukan sebagai token khusus. `<>` menunjukkan pinyin Tiongkok dan `[]` menunjukkan tag khusus lainnya.

#### 1.2 Inferensi daftar kalimat

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- Setiap baris dari `test.tsv` memiliki format `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. Generasi Ucapan Dialog

#### 2.1 Perintah Inferensi

Untuk menghasilkan dialog lisan dua pihak dengan model ZipVoice-Dialogue atau ZipVoice-Dialogue-Stereo pra-latih kami, gunakan perintah berikut (Model yang diperlukan akan diunduh dari HuggingFace):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` dapat berupa `zipvoice_dialog` atau `zipvoice_dialog_stereo`,
    yang masing-masing menghasilkan dialog mono dan stereo.

#### 2.2 Format Input

Setiap baris dari `test.tsv` menggunakan salah satu format berikut:

(1) **Format prompt gabungan** di mana audio dan transkripsi dari dua pembicara digabungkan menjadi satu file wav prompt:

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```

- `wav_name` adalah nama file wav output.
- `prompt_transcription` adalah transkripsi dari prompt percakapan wav, misalnya, "[S1] Halo. [S2] Apa kabar?"
- `prompt_wav` adalah path menuju prompt wav.
- `text` adalah teks yang akan disintesis, misalnya "[S1] Saya baik-baik saja. [S2] Siapa nama Anda? [S1] Saya Eric. [S2] Hai Eric."

(2) **Format prompt terpisah** di mana audio dan transkripsi dari dua pembicara ada di file terpisah:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```

- `wav_name` adalah nama file wav keluaran.
- `spk1_prompt_transcription` adalah transkripsi dari file wav prompt pembicara pertama, misalnya, "Hello"
- `spk2_prompt_transcription` adalah transkripsi dari file wav prompt pembicara kedua, misalnya, "How are you?"
- `spk1_prompt_wav` adalah path ke file wav prompt pembicara pertama.
- `spk2_prompt_wav` adalah path ke file wav prompt pembicara kedua.
- `text` adalah teks yang akan disintesis, misalnya "[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric."

### 3 Panduan untuk penggunaan lebih baik:

#### 3.1 Panjang prompt

Kami merekomendasikan file wav prompt yang pendek (misalnya, kurang dari 3 detik untuk generasi ucapan satu pembicara, kurang dari 10 detik untuk generasi ucapan dialog) untuk mempercepat kecepatan inferensi. Prompt yang terlalu panjang akan memperlambat inferensi dan menurunkan kualitas ucapan.

#### 3.2 Optimasi kecepatan

Jika kecepatan inferensi kurang memuaskan, Anda dapat mempercepatnya dengan cara berikut:

- **Model distilasi dan langkah lebih sedikit**: Untuk model generasi ucapan satu pembicara, kami menggunakan model `zipvoice` secara default untuk kualitas suara yang lebih baik. Jika kecepatan lebih diutamakan, Anda dapat beralih ke `zipvoice_distill` dan mengurangi `--num-steps` hingga serendah `4` (default 8).

- **Percepatan CPU dengan multi-threading**: Saat berjalan di CPU, Anda dapat menggunakan parameter `--num-thread` (misal, `--num-thread 4`) untuk menambah jumlah thread agar lebih cepat. Default-nya adalah 1 thread.

- **Percepatan CPU dengan ONNX**: Saat berjalan di CPU, Anda dapat menggunakan model ONNX dengan `zipvoice.bin.infer_zipvoice_onnx` untuk kecepatan lebih tinggi (belum mendukung ONNX untuk model generasi dialog). Untuk kecepatan lebih tinggi lagi, Anda dapat mengatur `--onnx-int8 True` untuk menggunakan model ONNX yang di-kuantisasi INT8. Perlu diperhatikan, model kuantisasi akan menurunkan kualitas suara hingga tingkat tertentu. **Jangan gunakan ONNX di GPU**, karena lebih lambat daripada PyTorch di GPU.

#### 3.3 Kontrol memori

Teks yang diberikan akan dibagi menjadi beberapa bagian berdasarkan tanda baca (untuk generasi ucapan satu pembicara) atau simbol pergantian pembicara (untuk generasi ucapan dialog). Kemudian, bagian-bagian teks tersebut akan diproses secara batch. Dengan demikian, model dapat memproses teks sepanjang apapun dengan penggunaan memori yang hampir tetap. Anda dapat mengontrol penggunaan memori dengan mengatur parameter `--max-duration`.

#### 3.4 Evaluasi "Raw"

Secara default, kami melakukan pra-pemrosesan pada input (prompt wav, transkripsi prompt, dan teks) untuk inferensi yang efisien dan performa yang lebih baik. Jika Anda ingin mengevaluasi performa "raw" model menggunakan input yang diberikan secara persis (misalnya, untuk mereproduksi hasil pada paper kami), Anda dapat menggunakan `--raw-evaluation True`.

#### 3.5 Teks pendek

Saat menghasilkan ucapan untuk teks yang sangat pendek (misal, satu atau dua kata), ucapan yang dihasilkan kadang-kadang dapat menghilangkan beberapa pelafalan. Untuk mengatasi masalah ini, Anda dapat menggunakan `--speed 0.3` (di mana 0.3 adalah nilai yang dapat diatur) untuk memperpanjang durasi ucapan yang dihasilkan.

#### 3.6 Koreksi pelafalan karakter polifonik bahasa Mandarin yang salah

Kami menggunakan [pypinyin](https://github.com/mozillazg/python-pinyin) untuk mengonversi karakter Mandarin ke pinyin. Namun, terkadang dapat salah melafalkan **karakter polifonik** (多音字).

Untuk memperbaiki pengucapan yang salah secara manual, sertakan **pinyin yang sudah dikoreksi** di dalam tanda kurung sudut `< >` dan tambahkan **tanda nada**.

**Contoh:**

- Teks asli: `这把剑长三十公分`
- Koreksi pinyin dari `长`:  `这把剑<chang2>三十公分`

> **Catatan:** Jika Anda ingin menetapkan beberapa pinyin secara manual, sertakan setiap pinyin dengan `<>`, misal: `这把<jian4><chang2><san1>十公分`

#### 3.7 Hapus jeda panjang dari suara yang dihasilkan

Model akan secara otomatis menentukan posisi dan durasi jeda dalam suara yang dihasilkan. Kadang-kadang terdapat jeda panjang di tengah suara. Jika Anda tidak menginginkannya, Anda dapat menggunakan `--remove-long-sil` untuk menghapus jeda panjang di tengah suara yang dihasilkan (jeda di tepi akan dihapus secara default).

#### 3.8 Pengunduhan model

Jika Anda mengalami kesulitan terhubung ke HuggingFace saat mengunduh model pra-latih, coba ganti endpoint ke situs mirror: `export HF_ENDPOINT=https://hf-mirror.com`.

## Latih Model Anda Sendiri

Lihat direktori [egs](egs) untuk contoh pelatihan, fine-tuning dan evaluasi.

## Deployment C++

Lihat [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) untuk solusi deployment C++ di CPU.

## Diskusi & Komunikasi

Anda dapat berdiskusi langsung di [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Anda juga dapat memindai kode QR untuk bergabung dengan grup wechat kami atau mengikuti akun resmi wechat kami.

| Grup Wechat | Akun Resmi Wechat |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Kutipan

```bibtex
@article{zhu2025zipvoice,
      title={ZipVoice: Fast and High-Quality Zero-Shot Text-to-Speech with Flow Matching},
      author={Zhu, Han and Kang, Wei and Yao, Zengwei and Guo, Liyong and Kuang, Fangjun and Li, Zhaoqing and Zhuang, Weiji and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2506.13053},
      year={2025}
}

@article{zhu2025zipvoicedialog,
      title={ZipVoice-Dialog: Non-Autoregressive Spoken Dialogue Generation with Flow Matching},
      author={Zhu, Han and Kang, Wei and Guo, Liyong and Yao, Zengwei and Kuang, Fangjun and Zhuang, Weiji and Li, Zhaoqing and Han, Zhifeng and Zhang, Dong and Zhang, Xin and Song, Xingchen and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2507.09318},
      year={2025}
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---