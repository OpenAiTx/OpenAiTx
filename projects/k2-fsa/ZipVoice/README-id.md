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

## Teks-ke-Ucapan Zero-Shot Cepat dan Berkualitas Tinggi dengan Flow Matching
</div>

## Ikhtisar

ZipVoice adalah serangkaian model TTS zero-shot yang cepat dan berkualitas tinggi berbasis flow matching.

### 1. Fitur utama

- Kecil dan cepat: hanya 123M parameter.

- Kloning suara berkualitas tinggi: performa terbaik dalam kemiripan suara, kejelasan, dan kealamian.

- Multi-bahasa: mendukung bahasa Mandarin dan Inggris.

- Multi-mode: mendukung generasi suara penutur tunggal dan percakapan dialog.

### 2. Varian model

<table>
  <thead>
    <tr>
      <th>Nama Model</th>
      <th>Deskripsi</th>
      <th>Makalah</th>
      <th>Demo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>Model dasar yang mendukung TTS zero-shot penutur tunggal dalam bahasa Mandarin dan Inggris.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>Versi distilasi dari ZipVoice, menawarkan kecepatan lebih tinggi dengan penurunan performa yang minimal.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Model generasi dialog berbasis ZipVoice, mampu menghasilkan percakapan dua pihak dalam satu saluran.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>Varian stereo dari ZipVoice-Dialog, memungkinkan generasi dialog dua saluran dengan masing-masing penutur pada saluran terpisah.</td>
    </tr>
  </tbody>
</table>

## Berita

**2025/07/14**: **ZipVoice-Dialog** dan **ZipVoice-Dialog-Stereo**, dua model generasi percakapan suara, telah dirilis. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: Dataset **OpenDialog**, dataset percakapan suara selama 6.8k jam, telah dirilis. Unduh di [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Cek detail di [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** dan **ZipVoice-Distill** telah dirilis. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Instalasi

### 1. Kloning repositori ZipVoice


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
### 4. (Opsional) Instal k2 untuk pelatihan atau inferensi yang efisien

k2 diperlukan untuk pelatihan dan dapat mempercepat proses inferensi. Namun demikian, Anda masih dapat menggunakan mode inferensi ZipVoice tanpa menginstal k2.

> **Catatan:** Pastikan untuk menginstal versi k2 yang sesuai dengan versi PyTorch dan CUDA Anda. Sebagai contoh, jika Anda menggunakan pytorch 2.5.1 dan CUDA 12.1, Anda dapat menginstal k2 sebagai berikut:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Silakan merujuk ke https://k2-fsa.org/get-started/k2/ untuk detailnya.
Pengguna di Tiongkok daratan dapat merujuk ke https://k2-fsa.org/zh-CN/get-started/k2/.

## Penggunaan

### 1. Pembuatan ucapan satu pembicara

Untuk menghasilkan ucapan satu pembicara dengan model ZipVoice atau ZipVoice-Distill yang sudah dilatih sebelumnya, gunakan perintah berikut (Model yang diperlukan akan diunduh dari HuggingFace):

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
- Jika `<>` atau `[]` muncul dalam teks, string yang terbungkus di dalamnya akan diperlakukan sebagai token khusus. `<>` menandakan pinyin Tionghoa dan `[]` menandakan tag khusus lainnya.
- Dapat menjalankan model ONNX pada CPU lebih cepat dengan `zipvoice.bin.infer_zipvoice_onnx`.

> **Catatan:** Jika Anda mengalami kesulitan terhubung ke HuggingFace, coba:
> ```bash
> export HF_ENDPOINT=https://hf-mirror.com
> ```

#### 1.2 Inferensi daftar kalimat


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- Setiap baris dari `test.tsv` memiliki format `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. Generasi dialog lisan

#### 2.1 Perintah inferensi

Untuk menghasilkan dialog lisan dua pihak dengan model pra-latih ZipVoice-Dialogue atau ZipVoice-Dialogue-Stereo kami, gunakan perintah berikut (Model yang diperlukan akan diunduh dari HuggingFace):


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
- `wav_name` adalah nama file wav keluaran.
- `prompt_transcription` adalah transkripsi dari prompt percakapan wav, misalnya, "[S1] Halo. [S2] Apa kabar?"
- `prompt_wav` adalah path ke file prompt wav.
- `text` adalah teks yang akan disintesis, misalnya, "[S1] Saya baik-baik saja. [S2] Siapa namamu?"

(2) **Format prompt terpisah** di mana audio dan transkripsi dari dua pembicara ada di file terpisah:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` adalah nama file wav keluaran.
- `spk1_prompt_transcription` adalah transkripsi dari wav prompt pembicara pertama, misalnya, "Hello"
- `spk2_prompt_transcription` adalah transkripsi dari wav prompt pembicara kedua, misalnya, "How are you?"
- `spk1_prompt_wav` adalah path ke file wav prompt pembicara pertama.
- `spk2_prompt_wav` adalah path ke file wav prompt pembicara kedua.
- `text` adalah teks yang akan disintesis, misalnya. "[S1] I'm fine. [S2] What's your name?"

### 3. Fitur lainnya

#### 3.1 Mengoreksi pelafalan karakter polifonik Tionghoa yang salah

Kami menggunakan [pypinyin](https://github.com/mozillazg/python-pinyin) untuk mengonversi karakter Tionghoa ke pinyin. Namun, kadang-kadang dapat salah melafalkan **karakter polifonik** (多音字).

Untuk mengoreksi pelafalan ini secara manual, sertakan **pinyin yang benar** dalam tanda kurung sudut `< >` dan tambahkan **tanda nada**.

**Contoh:**

- Teks asli: `这把剑长三十公分`
- Koreksi pinyin dari `长`:  `这把剑<chang2>三十公分`

> **Catatan:** Jika Anda ingin menetapkan beberapa pinyin secara manual, sertakan setiap pinyin dengan `<>`, misalnya, `这把<jian4><chang2><san1>十公分`

## Melatih Model Anda Sendiri

Lihat direktori [egs](egs) untuk contoh pelatihan dan fine-tuning.

## Diskusi & Komunikasi

Anda dapat berdiskusi langsung di [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Anda juga dapat memindai kode QR untuk bergabung dengan grup wechat kami atau mengikuti akun resmi wechat kami.

| Grup Wechat | Akun Resmi Wechat |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Sitasi


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
<translate-content></translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---