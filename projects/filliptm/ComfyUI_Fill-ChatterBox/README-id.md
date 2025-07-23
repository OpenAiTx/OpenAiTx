<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

Jika Anda menikmati proyek ini, pertimbangkan untuk mendukung saya di Patreon!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Sebuah ekstensi node kustom untuk ComfyUI yang menambahkan kemampuan text-to-speech (TTS) dan voice conversion (VC) menggunakan pustaka Chatterbox.
Mendukung MAKSIMAL 40 detik. Saya sudah mencoba menghapus batasan ini, tetapi modelnya benar-benar rusak jika digunakan lebih dari itu, jadi batasan ini tetap ada.

![Contoh ChatterBox](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## Instalasi

1. Clone repositori ini ke dalam direktori custom_nodes ComfyUI Anda:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. Instal dependensi dasar:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (Opsional) Pasang dukungan watermarking:

   ```bash
   pip install resemble-perth
   ```
   **Catatan**: Paket `resemble-perth` mungkin memiliki masalah kompatibilitas dengan Python 3.12+. Jika Anda mengalami error impor, node tetap akan berfungsi tanpa watermarking.


## Penggunaan

### Node Text-to-Speech (FL Chatterbox TTS)
- Tambahkan node "FL Chatterbox TTS" ke dalam workflow Anda
- Konfigurasikan input teks dan parameter (exaggeration, cfg_weight, temperature)
- Opsional: sediakan audio prompt untuk kloning suara

### Node Voice Conversion (FL Chatterbox VC)
- Tambahkan node "FL Chatterbox VC" ke dalam workflow Anda
- Hubungkan audio input dan suara target
- Kedua node mendukung fallback ke CPU jika terjadi error CUDA

## Catatan Perubahan

### 24/6/2025
- Menambahkan parameter seed ke node TTS dan VC untuk generasi yang dapat direproduksi
- Rentang seed: 0 hingga 4.294.967.295 (integer 32-bit)
- Memungkinkan output audio yang konsisten untuk debugging dan kontrol workflow
- Membuat watermarking Perth menjadi opsional untuk memperbaiki masalah kompatibilitas Python 3.12+
- Node sekarang berfungsi tanpa watermarking jika impor resemble-perth gagal

### 31/5/2025
- Menambahkan pemuatan model Persisten, dan fungsionalitas loading bar
- Menambahkan dukungan Mac (perlu diuji, jadi hubungi saya)
- Menghapus library chatterbox-tts dan mengimplementasikan kode inferensi native.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---