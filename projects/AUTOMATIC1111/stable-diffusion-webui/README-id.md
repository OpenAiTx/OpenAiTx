# Stable Diffusion web UI
Antarmuka web untuk Stable Diffusion, diimplementasikan menggunakan pustaka Gradio.

![](screenshot.png)

## Fitur
[Pameran fitur lengkap dengan gambar](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- Mode txt2img dan img2img asli
- Skrip instal dan jalankan sekali klik (tetapi Anda tetap harus menginstal python dan git)
- Outpainting
- Inpainting
- Color Sketch
- Prompt Matrix
- Stable Diffusion Upscale
- Attention, tentukan bagian teks yang harus lebih diperhatikan oleh model
    - a man in a `((tuxedo))` - akan lebih memperhatikan tuxedo
    - a man in a `(tuxedo:1.21)` - sintaks alternatif
    - pilih teks dan tekan `Ctrl+Up` atau `Ctrl+Down` (atau `Command+Up` atau `Command+Down` jika Anda menggunakan MacOS) untuk menyesuaikan attention pada teks yang dipilih secara otomatis (kode disumbangkan oleh pengguna anonim)
- Loopback, jalankan pemrosesan img2img beberapa kali
- X/Y/Z plot, cara untuk membuat plot 3 dimensi dari gambar dengan parameter berbeda
- Textual Inversion
    - memiliki embedding sebanyak yang diinginkan dan gunakan nama apa pun yang Anda suka untuknya
    - gunakan beberapa embedding dengan jumlah vektor per token yang berbeda
    - bekerja dengan angka floating point presisi setengah
    - latih embedding di 8GB (juga ada laporan 6GB dapat bekerja)
- Tab Extras dengan:
    - GFPGAN, jaringan saraf yang memperbaiki wajah
    - CodeFormer, alat restorasi wajah sebagai alternatif GFPGAN
    - RealESRGAN, penambah skala berbasis jaringan saraf
    - ESRGAN, penambah skala jaringan saraf dengan banyak model pihak ketiga
    - SwinIR dan Swin2SR ([lihat di sini](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), penambah skala jaringan saraf
    - LDSR, peningkatan resolusi super latent diffusion
- Opsi rasio aspek pengubahan ukuran
- Pemilihan metode sampling
    - Atur nilai eta sampler (pengali noise)
    - Opsi pengaturan noise lebih lanjut
- Hentikan pemrosesan kapan saja
- Dukungan kartu video 4GB (juga ada laporan 2GB dapat bekerja)
- Seed yang benar untuk batch
- Validasi panjang token prompt secara langsung
- Parameter generasi
     - parameter yang Anda gunakan untuk menghasilkan gambar disimpan bersama gambar tersebut
     - di chunk PNG untuk PNG, di EXIF untuk JPEG
     - dapat menyeret gambar ke tab PNG info untuk mengembalikan parameter generasi dan menyalinnya secara otomatis ke UI
     - dapat dinonaktifkan di pengaturan
     - seret dan jatuhkan gambar/parameter-teks ke promptbox
- Tombol Read Generation Parameters, memuat parameter di promptbox ke UI
- Halaman pengaturan
- Menjalankan kode python secara bebas dari UI (harus dijalankan dengan `--allow-code` untuk mengaktifkan)
- Petunjuk mouseover untuk sebagian besar elemen UI
- Dapat mengubah nilai default/min/maks/step untuk elemen UI melalui konfigurasi teks
- Dukungan tiling, sebuah checkbox untuk membuat gambar yang dapat diulang seperti tekstur
- Progress bar dan pratinjau generasi gambar secara langsung
    - Dapat menggunakan jaringan saraf terpisah untuk menghasilkan pratinjau dengan hampir tanpa kebutuhan VRAM atau komputasi
- Negative prompt, kolom teks tambahan yang memungkinkan Anda mencantumkan apa yang tidak ingin Anda lihat di gambar yang dihasilkan
- Styles, cara untuk menyimpan bagian prompt dan dengan mudah menerapkannya melalui dropdown nantinya
- Variations, cara untuk menghasilkan gambar yang sama tetapi dengan perbedaan kecil
- Seed resizing, cara untuk menghasilkan gambar yang sama namun dengan resolusi sedikit berbeda
- CLIP interrogator, tombol yang mencoba menebak prompt dari sebuah gambar
- Prompt Editing, cara untuk mengubah prompt di tengah generasi, misal mulai membuat semangka lalu beralih ke gadis anime di tengah jalan
- Batch Processing, memproses sekelompok file menggunakan img2img
- Img2img Alternative, metode kontrol cross attention Euler terbalik
- Highres Fix, opsi mudah untuk menghasilkan gambar resolusi tinggi sekali klik tanpa distorsi biasa
- Memuat ulang checkpoint secara langsung
- Checkpoint Merger, tab untuk menggabungkan hingga 3 checkpoint menjadi satu
- [Custom scripts](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) dengan banyak ekstensi dari komunitas
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), cara untuk menggunakan beberapa prompt sekaligus
     - pisahkan prompt menggunakan huruf besar `AND`
     - juga mendukung bobot untuk prompt: `a cat :1.2 AND a dog AND a penguin :2.2`
- Tidak ada batas token untuk prompt (stable diffusion asli membatasi hingga 75 token)
- Integrasi DeepDanbooru, membuat tag gaya danbooru untuk prompt anime
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), peningkatan kecepatan besar untuk kartu tertentu: (tambahkan `--xformers` ke argumen commandline)
- melalui ekstensi: [History tab](https://github.com/yfszzx/stable-diffusion-webui-images-browser): lihat, arahkan, dan hapus gambar dengan mudah di dalam UI
- Opsi Generate forever
- Tab Training
     - opsi hypernetworks dan embeddings
     - Preprocessing gambar: cropping, mirroring, autotagging menggunakan BLIP atau deepdanbooru (untuk anime)
- Clip skip
- Hypernetworks
- Loras (sama dengan Hypernetworks tapi lebih cantik)
- UI terpisah di mana Anda bisa memilih, dengan pratinjau, embedding, hypernetworks atau Loras mana yang akan ditambahkan ke prompt
- Dapat memilih untuk memuat VAE yang berbeda dari layar pengaturan
- Perkiraan waktu selesai di progress bar
- API
- Dukungan untuk [inpainting model](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) khusus oleh RunwayML
- melalui ekstensi: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), cara untuk menghasilkan gambar dengan estetika tertentu menggunakan embed gambar clip (implementasi dari [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- Dukungan [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) - lihat [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) untuk petunjuk
- Dukungan [Alt-Diffusion](https://arxiv.org/abs/2211.06679) - lihat [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) untuk petunjuk
- Kini tanpa huruf buruk!
- Memuat checkpoint dalam format safetensors
- Batasan resolusi yang dipermudah: dimensi gambar yang dihasilkan harus kelipatan 8, bukan 64
- Kini dengan lisensi!
- Mengatur ulang elemen di UI dari layar pengaturan
- Dukungan [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## Instalasi dan Menjalankan
Pastikan [dependensi](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) yang diperlukan telah terpenuhi dan ikuti petunjuk yang tersedia untuk:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (direkomendasikan)
- GPU [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs).
- [Intel CPU, Intel GPU (terintegrasi dan diskrit)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (halaman wiki eksternal)
- [Ascend NPU](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (halaman wiki eksternal)

Sebagai alternatif, gunakan layanan daring (seperti Google Colab):

- [Daftar Layanan Daring](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Instalasi di Windows 10/11 dengan GPU NVidia menggunakan paket rilis
1. Unduh `sd.webui.zip` dari [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) dan ekstrak isinya.
2. Jalankan `update.bat`.
3. Jalankan `run.bat`.
> Untuk detail lebih lanjut lihat [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Instalasi Otomatis di Windows
1. Instal [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (Versi Python yang lebih baru tidak mendukung torch), centang "Add Python to PATH".
2. Instal [git](https://git-scm.com/download/win).
3. Unduh repository stable-diffusion-webui, misalnya dengan menjalankan `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`.
4. Jalankan `webui-user.bat` dari Windows Explorer sebagai pengguna biasa, bukan administrator.

### Instalasi Otomatis di Linux
1. Instal dependensi:
```bash
# Berbasis Debian:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Berbasis Red Hat:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# Berbasis openSUSE:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Berbasis Arch:
sudo pacman -S wget git python3
```
Jika sistem Anda sangat baru, Anda perlu menginstal python3.11 atau python3.10:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # jangan keliru dengan paket python3.11

# Hanya untuk 3.11
# Lalu atur variabel env di skrip peluncuran
export python_cmd="python3.11"
# atau di webui-user.sh
python_cmd="python3.11"
```
2. Masuk ke direktori tempat Anda ingin menginstal webui dan jalankan perintah berikut:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
Atau cukup clone repo di mana saja yang Anda inginkan:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. Jalankan `webui.sh`.
4. Cek `webui-user.sh` untuk opsi.
### Instalasi di Apple Silicon

Temukan petunjuknya [di sini](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon).

## Kontribusi
Berikut cara menambahkan kode ke repo ini: [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## Dokumentasi

Dokumentasi telah dipindahkan dari README ini ke [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki) proyek.

Agar Google dan mesin pencari lain dapat merayapi wiki, berikut tautan ke [wiki yang dapat dirayapi](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki) (bukan untuk manusia).

## Kredit
Lisensi untuk kode yang digunakan dapat ditemukan di layar `Settings -> Licenses`, dan juga di file `html/licenses.html`.

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel mengimplementasikan
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- Ide untuk optimasi - https://github.com/basujindal/stable-diffusion
- Optimasi layer Cross Attention - Doggettx - https://github.com/Doggettx/stable-diffusion, ide asli untuk prompt editing.
- Optimasi layer Cross Attention - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (awalnya http://github.com/lstein/stable-diffusion)
- Optimasi layer Cross Attention Sub-kuadratik - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textual Inversion - Rinon Gal - https://github.com/rinongal/textual_inversion (kami tidak menggunakan kodenya, tapi menggunakan idenya).
- Ide untuk SD upscale - https://github.com/jquesnelle/txt2imghd
- Noise generation untuk outpainting mk2 - https://github.com/parlance-zz/g-diffuser-bot
- Ide CLIP interrogator dan meminjam beberapa kode - https://github.com/pharmapsychotic/clip-interrogator
- Ide untuk Composable Diffusion - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - interrogator untuk anime diffusers https://github.com/KichangKim/DeepDanbooru
- Sampling dalam presisi float32 dari UNet float16 - marunine untuk ide, Birch-san untuk contoh implementasi Diffusers (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) - https://github.com/timothybrooks/instruct-pix2pix
- Saran keamanan - RyotaK
- UniPC sampler - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- Restart sampling - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- Skrip Gradio awal - diposting di 4chan oleh pengguna Anonim. Terima kasih pengguna Anonim.
- (Anda)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---