![Logo PyTorch](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch adalah paket Python yang menyediakan dua fitur tingkat tinggi:
- Komputasi Tensor (seperti NumPy) dengan akselerasi GPU yang kuat
- Jaringan saraf dalam yang dibangun di atas sistem autograd berbasis tape

Anda dapat menggunakan kembali paket Python favorit Anda seperti NumPy, SciPy, dan Cython untuk memperluas PyTorch sesuai kebutuhan.

Kesehatan trunk kami (sinyal Continuous Integration) dapat ditemukan di [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main).

<!-- toc -->

- [Lebih Lanjut Tentang PyTorch](#more-about-pytorch)
  - [Pustaka Tensor Siap GPU](#a-gpu-ready-tensor-library)
  - [Jaringan Saraf Dinamis: Tape-Based Autograd](#dynamic-neural-networks-tape-based-autograd)
  - [Python First](#python-first)
  - [Pengalaman Imperatif](#imperative-experiences)
  - [Cepat dan Ramping](#fast-and-lean)
  - [Ekstensi Tanpa Repot](#extensions-without-pain)
- [Instalasi](#installation)
  - [Biner](#binaries)
    - [Platform NVIDIA Jetson](#nvidia-jetson-platforms)
  - [Dari Sumber](#from-source)
    - [Prasyarat](#prerequisites)
      - [Dukungan NVIDIA CUDA](#nvidia-cuda-support)
      - [Dukungan AMD ROCm](#amd-rocm-support)
      - [Dukungan GPU Intel](#intel-gpu-support)
    - [Dapatkan Sumber PyTorch](#get-the-pytorch-source)
    - [Instal Dependensi](#install-dependencies)
    - [Instal PyTorch](#install-pytorch)
      - [Sesuaikan Opsi Build (Opsional)](#adjust-build-options-optional)
  - [Image Docker](#docker-image)
    - [Menggunakan image bawaan](#using-pre-built-images)
    - [Membangun image sendiri](#building-the-image-yourself)
  - [Membangun Dokumentasi](#building-the-documentation)
    - [Membangun PDF](#building-a-pdf)
  - [Versi Sebelumnya](#previous-versions)
- [Memulai](#getting-started)
- [Sumber Daya](#resources)
- [Komunikasi](#communication)
- [Rilis dan Kontribusi](#releases-and-contributing)
- [Tim](#the-team)
- [Lisensi](#license)

<!-- tocstop -->

## Lebih Lanjut Tentang PyTorch

[Pelajari dasar-dasar PyTorch](https://pytorch.org/tutorials/beginner/basics/intro.html)

Pada tingkat granular, PyTorch adalah pustaka yang terdiri dari komponen berikut:

| Komponen | Deskripsi |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | Pustaka Tensor seperti NumPy, dengan dukungan GPU yang kuat |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | Pustaka diferensiasi otomatis berbasis tape yang mendukung semua operasi Tensor yang dapat didiferensiasi di torch |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | Tumpukan kompilasi (TorchScript) untuk membuat model yang dapat diserialisasi dan dioptimalkan dari kode PyTorch |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | Pustaka jaringan saraf yang terintegrasi erat dengan autograd yang dirancang untuk fleksibilitas maksimum |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Multiprocessing Python, tetapi dengan berbagi memori ajaib dari Tensor torch antar proses. Berguna untuk pemuatan data dan pelatihan Hogwild |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader dan fungsi utilitas lain untuk kemudahan |

Biasanya, PyTorch digunakan sebagai:

- Pengganti NumPy untuk memanfaatkan kekuatan GPU.
- Platform riset deep learning yang memberikan fleksibilitas dan kecepatan maksimum.

Penjelasan Lebih Lanjut:

### Pustaka Tensor Siap GPU

Jika Anda menggunakan NumPy, maka Anda telah menggunakan Tensor (alias ndarray).

![Ilustrasi Tensor](./docs/source/_static/img/tensor_illustration.png)

PyTorch menyediakan Tensor yang dapat berada di CPU maupun GPU dan mempercepat
komputasi secara signifikan.

Kami menyediakan beragam rutinitas tensor untuk mempercepat dan memenuhi kebutuhan komputasi ilmiah Anda
seperti slicing, indexing, operasi matematika, aljabar linear, reduksi.
Dan semuanya cepat!

### Jaringan Saraf Dinamis: Tape-Based Autograd

PyTorch memiliki cara unik untuk membangun jaringan saraf: menggunakan dan memutar ulang tape recorder.

Sebagian besar framework seperti TensorFlow, Theano, Caffe, dan CNTK memiliki pandangan statis.
Anda harus membangun jaringan saraf dan menggunakan kembali struktur yang sama berulang kali.
Mengubah perilaku jaringan berarti Anda harus mulai dari awal.

Dengan PyTorch, kami menggunakan teknik yang disebut auto-differentiation mode-balik, yang memungkinkan Anda
mengubah perilaku jaringan sesuka hati tanpa lag atau overhead. Inspirasi kami berasal
dari beberapa makalah riset tentang topik ini, serta pekerjaan saat ini maupun sebelumnya seperti
[torch-autograd](https://github.com/twitter/torch-autograd),
[autograd](https://github.com/HIPS/autograd),
[Chainer](https://chainer.org), dll.

Meskipun teknik ini bukan satu-satunya di PyTorch, ini adalah salah satu implementasi tercepat hingga saat ini.
Anda mendapatkan kecepatan dan fleksibilitas terbaik untuk riset Anda yang paling gila.

![Grafik dinamis](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python First

PyTorch bukanlah binding Python ke framework C++ monolitik.
PyTorch dibangun agar terintegrasi secara mendalam dengan Python.
Anda dapat menggunakannya secara alami seperti Anda menggunakan [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) dll.
Anda dapat menulis lapisan jaringan saraf baru Anda sendiri di Python, menggunakan pustaka favorit Anda
dan menggunakan paket seperti [Cython](https://cython.org/) dan [Numba](http://numba.pydata.org/).
Tujuan kami adalah tidak menciptakan ulang roda jika tidak perlu.

### Pengalaman Imperatif

PyTorch dirancang untuk menjadi intuitif, linier dalam pemikiran, dan mudah digunakan.
Saat Anda mengeksekusi baris kode, kode itu langsung dijalankan. Tidak ada pandangan asinkron.
Saat Anda masuk ke debugger atau menerima pesan error dan stack trace, memahaminya menjadi mudah.
Stack trace menunjukkan tepat di mana kode Anda didefinisikan.
Kami berharap Anda tidak perlu menghabiskan waktu berjam-jam untuk debug kode Anda akibat stack trace yang buruk atau mesin eksekusi asinkron yang tidak transparan.

### Cepat dan Ramping

PyTorch memiliki overhead framework yang minimal. Kami mengintegrasikan pustaka akselerasi
seperti [Intel MKL](https://software.intel.com/mkl) dan NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)) untuk memaksimalkan kecepatan.
Pada intinya, backend Tensor CPU dan GPU serta jaringan saraf
telah matang dan diuji selama bertahun-tahun.

Karenanya, PyTorch sangat cepat — baik untuk jaringan saraf kecil maupun besar.

Penggunaan memori PyTorch sangat efisien dibandingkan Torch atau alternatif lainnya.
Kami telah menulis allocator memori khusus untuk GPU agar
model deep learning Anda semaksimal mungkin efisien dalam memori.
Ini memungkinkan Anda melatih model deep learning yang lebih besar dari sebelumnya.

### Ekstensi Tanpa Repot

Menulis modul jaringan saraf baru, atau berinteraksi dengan API Tensor PyTorch dirancang agar mudah
dan dengan abstraksi minimal.

Anda dapat menulis lapisan jaringan saraf baru dalam Python menggunakan API torch
[atau pustaka berbasis NumPy favorit Anda seperti SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html).

Jika Anda ingin menulis lapisan di C/C++, kami menyediakan API ekstensi yang efisien dan minim boilerplate.
Tidak perlu menulis kode wrapper. Anda dapat melihat [tutorial di sini](https://pytorch.org/tutorials/advanced/cpp_extension.html) dan [contoh di sini](https://github.com/pytorch/extension-cpp).


## Instalasi

### Biner
Perintah untuk menginstal biner melalui Conda atau pip wheels tersedia di situs web kami: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)


#### Platform NVIDIA Jetson

Python wheels untuk NVIDIA Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX, dan Jetson AGX Orin tersedia [di sini](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) dan container L4T dipublikasikan [di sini](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)

Mereka membutuhkan JetPack 4.2 ke atas, dan [@dusty-nv](https://github.com/dusty-nv) serta [@ptrblck](https://github.com/ptrblck) yang memeliharanya.


### Dari Sumber

#### Prasyarat
Jika Anda menginstal dari sumber, Anda akan membutuhkan:
- Python 3.9 atau lebih baru
- Kompiler yang sepenuhnya mendukung C++17, seperti clang atau gcc (gcc 9.4.0 atau lebih baru diperlukan di Linux)
- Visual Studio atau Visual Studio Build Tool (khusus Windows)

\* CI PyTorch menggunakan Visual C++ BuildTools, yang disertakan pada Visual Studio Enterprise,
Professional, atau Community Edition. Anda juga dapat menginstal build tools dari
https://visualstudio.microsoft.com/visual-cpp-build-tools/. Build tools *tidak*
tersedia secara default pada Visual Studio Code.

Contoh pengaturan lingkungan ditunjukkan di bawah ini:

* Linux:

```bash
$ source <CONDA_INSTALL_DIR>/bin/activate
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
```

* Windows:

```bash
$ source <CONDA_INSTALL_DIR>\Scripts\activate.bat
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
$ call "C:\Program Files\Microsoft Visual Studio\<VERSION>\Community\VC\Auxiliary\Build\vcvarsall.bat" x64
```

##### Dukungan NVIDIA CUDA
Jika Anda ingin mengkompilasi dengan dukungan CUDA, [pilih versi CUDA yang didukung dari matriks dukungan kami](https://pytorch.org/get-started/locally/), lalu instal:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 atau lebih baru
- [Compiler](https://gist.github.com/ax3l/9489132) yang kompatibel dengan CUDA

Catatan: Anda dapat merujuk ke [cuDNN Support Matrix](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) untuk versi cuDNN beserta dukungan CUDA, driver CUDA, dan perangkat keras NVIDIA

Jika Anda ingin menonaktifkan dukungan CUDA, ekspor variabel lingkungan `USE_CUDA=0`.
Variabel lingkungan lain yang mungkin berguna dapat ditemukan di `setup.py`.

Jika Anda membangun untuk platform NVIDIA Jetson (Jetson Nano, TX1, TX2, AGX Xavier), instruksi instalasi PyTorch untuk Jetson Nano tersedia [di sini](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### Dukungan AMD ROCm
Jika Anda ingin mengkompilasi dengan dukungan ROCm, instal
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 atau lebih baru
- ROCm saat ini hanya didukung pada sistem Linux.

Secara default, sistem build mengharapkan ROCm diinstal di `/opt/rocm`. Jika ROCm diinstal di direktori lain, variabel lingkungan `ROCM_PATH` harus disetel ke direktori instalasi ROCm. Sistem build mendeteksi arsitektur GPU AMD secara otomatis. Opsional, arsitektur GPU AMD dapat disetel secara eksplisit dengan variabel lingkungan `PYTORCH_ROCM_ARCH` [Arsitektur GPU AMD](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

Jika Anda ingin menonaktifkan dukungan ROCm, ekspor variabel lingkungan `USE_ROCM=0`.
Variabel lingkungan lain yang mungkin berguna dapat ditemukan di `setup.py`.

##### Dukungan GPU Intel
Jika Anda ingin mengkompilasi dengan dukungan GPU Intel, ikuti
- [Prasyarat PyTorch untuk GPU Intel](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html).
- GPU Intel didukung untuk Linux dan Windows.

Jika Anda ingin menonaktifkan dukungan GPU Intel, ekspor variabel lingkungan `USE_XPU=0`.
Variabel lingkungan lain yang mungkin berguna dapat ditemukan di `setup.py`.

#### Dapatkan Sumber PyTorch
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# jika Anda memperbarui checkout yang sudah ada
git submodule sync
git submodule update --init --recursive
```

#### Instal Dependensi

**Umum**

```bash
conda install cmake ninja
# Jalankan perintah ini dari direktori PyTorch setelah mengkloning kode sumber menggunakan bagian “Dapatkan Sumber PyTorch” di atas
pip install -r requirements.txt
```

**Di Linux**

```bash
pip install mkl-static mkl-include
# Hanya CUDA: Tambahkan dukungan LAPACK untuk GPU jika diperlukan
# instalasi magma: jalankan dengan environment conda aktif. tentukan versi CUDA yang akan diinstal
.ci/docker/common/install_magma_conda.sh 12.4

# (opsional) Jika menggunakan torch.compile dengan inductor/triton, instal versi triton yang sesuai
# Jalankan dari direktori pytorch setelah mengkloning
# Untuk dukungan GPU Intel, harap eksplisit `export USE_XPU=1` sebelum menjalankan perintah.
make triton
```

**Di MacOS**

```bash
# Tambahkan paket ini hanya pada mesin prosesor intel x86
pip install mkl-static mkl-include
# Tambahkan paket ini jika torch.distributed diperlukan
conda install pkg-config libuv
```

**Di Windows**

```bash
pip install mkl-static mkl-include
# Tambahkan paket ini jika torch.distributed diperlukan.
# Dukungan paket distributed di Windows masih prototipe dan dapat berubah.
conda install -c conda-forge libuv=1.39
```

#### Instal PyTorch
**Di Linux**

Jika Anda mengompilasi untuk AMD ROCm maka jalankan perintah ini terlebih dahulu:
```bash
# Hanya jalankan ini jika Anda mengkompilasi untuk ROCm
python tools/amd_build/build_amd.py
```

Instal PyTorch
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**Di macOS**

```bash
python3 setup.py develop
```

**Di Windows**

Jika Anda ingin membangun kode python legacy, silakan merujuk ke [Membangun pada kode legacy dan CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**Build Hanya-CPU**

Dalam mode ini, komputasi PyTorch akan berjalan di CPU Anda, bukan GPU.

```cmd
python setup.py develop
```

Catatan tentang OpenMP: Implementasi OpenMP yang diinginkan adalah Intel OpenMP (iomp). Untuk melakukan link dengan iomp, Anda perlu mengunduh library secara manual dan mengatur environment build dengan menyesuaikan `CMAKE_INCLUDE_PATH` dan `LIB`. Instruksi [di sini](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) merupakan contoh pengaturan MKL dan Intel OpenMP. Tanpa konfigurasi ini untuk CMake, Microsoft Visual C OpenMP runtime (vcomp) akan digunakan.

**Build Berbasis CUDA**

Dalam mode ini, komputasi PyTorch akan menggunakan GPU Anda melalui CUDA untuk perhitungan yang lebih cepat

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) dibutuhkan untuk membangun PyTorch dengan CUDA.
NVTX adalah bagian dari distribusi CUDA, disebut "Nsight Compute". Untuk menginstalnya pada CUDA yang sudah terpasang, jalankan instalasi CUDA lagi dan centang checkbox terkait.
Pastikan CUDA dengan Nsight Compute diinstal setelah Visual Studio.

Saat ini, VS 2017 / 2019, dan Ninja didukung sebagai generator CMake. Jika `ninja.exe` terdeteksi di `PATH`, maka Ninja akan digunakan sebagai generator default, jika tidak maka akan menggunakan VS 2017 / 2019.
<br/> Jika Ninja dipilih sebagai generator, MSVC terbaru akan dipilih sebagai toolchain utama.

Library tambahan seperti
[Magma](https://developer.nvidia.com/magma), [oneDNN, alias MKLDNN atau DNNL](https://github.com/oneapi-src/oneDNN), dan [Sccache](https://github.com/mozilla/sccache) sering dibutuhkan. Silakan merujuk ke [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) untuk menginstalnya.

Anda dapat merujuk ke script [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) untuk beberapa konfigurasi variabel lingkungan lainnya


```cmd
cmd

:: Atur variabel lingkungan setelah Anda mengunduh dan mengekstrak paket mkl,
:: jika tidak CMake akan error karena `Could NOT find OpenMP`.
set CMAKE_INCLUDE_PATH={Direktori Anda}\mkl\include
set LIB={Direktori Anda}\mkl\lib;%LIB%

:: Baca bagian sebelumnya dengan seksama sebelum melanjutkan.
:: [Opsional] Jika Anda ingin menimpa toolset yang digunakan Ninja dan Visual Studio dengan CUDA, jalankan blok script berikut.
:: "Visual Studio 2019 Developer Command Prompt" akan dijalankan otomatis.
:: Pastikan Anda punya CMake >= 3.12 sebelum melakukan ini jika menggunakan generator Visual Studio.
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [Opsional] Jika Anda ingin menimpa CUDA host compiler
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Build GPU Intel**

Dalam mode ini PyTorch dengan dukungan GPU Intel akan dibangun.

Pastikan [prasyarat umum](#prerequisites) serta [prasyarat untuk GPU Intel](#intel-gpu-support) telah terinstal dengan benar dan variabel lingkungan telah dikonfigurasi sebelum memulai build. Untuk dukungan build tool, `Visual Studio 2022` diperlukan.

Kemudian PyTorch dapat dibangun dengan perintah berikut:

```cmd
:: Perintah CMD:
:: Atur CMAKE_PREFIX_PATH untuk membantu menemukan paket yang sesuai
:: %CONDA_PREFIX% hanya berfungsi setelah `conda activate custom_env`

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### Sesuaikan Opsi Build (Opsional)

Anda dapat menyesuaikan konfigurasi variabel cmake secara opsional (tanpa membangun terlebih dahulu), dengan cara berikut. Misalnya, menyesuaikan direktori yang terdeteksi untuk CuDNN atau BLAS dapat dilakukan dengan langkah ini.

Di Linux
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # atau cmake-gui build
```

Di macOS
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # atau cmake-gui build
```

### Image Docker

#### Menggunakan image bawaan

Anda juga dapat menarik image docker bawaan dari Docker Hub dan menjalankannya dengan docker v19.03+

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

Perlu dicatat bahwa PyTorch menggunakan shared memory untuk berbagi data antar proses, jadi jika torch multiprocessing digunakan (misal
untuk data loader multi-thread), ukuran shared memory default pada container tidak cukup, dan Anda
harus menambah ukuran shared memory baik dengan opsi baris perintah `--ipc=host` atau `--shm-size` ke `nvidia-docker run`.

#### Membangun image sendiri

**CATATAN:** Harus dibangun dengan docker versi > 18.06

`Dockerfile` disediakan untuk membangun image dengan dukungan CUDA 11.1 dan cuDNN v8.
Anda dapat memberikan variabel make `PYTHON_VERSION=x.y` untuk menentukan versi Python yang digunakan oleh Miniconda, atau biarkan
kosong untuk menggunakan versi default.

```bash
make -f docker.Makefile
# image diberi tag sebagai docker.io/${your_docker_username}/pytorch
```

Anda juga dapat memberikan variabel lingkungan `CMAKE_VARS="..."` untuk menentukan variabel CMake tambahan yang akan diberikan ke CMake selama build.
Lihat [setup.py](./setup.py) untuk daftar variabel yang tersedia.

```bash
make -f docker.Makefile
```

### Membangun Dokumentasi

Untuk membangun dokumentasi dalam berbagai format, Anda perlu [Sphinx](http://www.sphinx-doc.org)
dan pytorch_sphinx_theme2.

Sebelum membangun dokumentasi secara lokal, pastikan `torch`
terinstal di environment Anda. Untuk perbaikan kecil, Anda bisa menginstal
versi nightly seperti dijelaskan di [Getting Started](https://pytorch.org/get-started/locally/).

Untuk perbaikan lebih kompleks, seperti menambah modul baru dan docstring untuk
modul baru, Anda mungkin perlu menginstal torch [dari sumber](#from-source).
Lihat [Pedoman Docstring](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)
untuk konvensi docstring.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

Jalankan `make` untuk mendapatkan daftar semua format output yang tersedia.

Jika Anda mendapat error katex jalankan `npm install katex`. Jika masih bermasalah, coba
`npm install -g katex`

> [!CATATAN]
> Jika Anda menginstal `nodejs` dengan package manager lain (misal,
> `conda`) maka `npm` mungkin akan menginstal versi `katex` yang tidak
> kompatibel dengan versi `nodejs` Anda dan build dokumen akan gagal.
> Kombinasi versi yang diketahui bekerja adalah `node@6.13.1` dan
> `katex@0.13.18`. Untuk menginstal yang terakhir dengan `npm` jalankan
> ```npm install -g katex@0.13.18```

> [!CATATAN]
> Jika Anda melihat error inkompatibilitas numpy, jalankan:
> ```
> pip install 'numpy<2'
> ```

Jika Anda mengubah dependensi yang dijalankan oleh CI, edit file
`.ci/docker/requirements-docs.txt`.

#### Membangun PDF

Untuk mengkompilasi PDF seluruh dokumentasi PyTorch, pastikan Anda memiliki
`texlive` dan LaTeX terinstal. Di macOS, Anda dapat menginstalnya dengan:

```
brew install --cask mactex
```

Untuk membuat PDF:

1. Jalankan:

   ```
   make latexpdf
   ```

   Ini akan menghasilkan file yang diperlukan di direktori `build/latex`.

2. Masuk ke direktori ini dan jalankan:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   Ini akan menghasilkan `pytorch.pdf` dengan konten yang diinginkan. Jalankan
   perintah ini sekali lagi agar menghasilkan daftar isi dan indeks yang benar.

> [!CATATAN]
> Untuk melihat Daftar Isi, beralihlah ke tampilan **Table of Contents**
> di penampil PDF Anda.


### Versi Sebelumnya

Instruksi instalasi dan biner untuk versi PyTorch sebelumnya dapat ditemukan
di [situs kami](https://pytorch.org/get-started/previous-versions).


## Memulai

Tiga tautan untuk memulai:
- [Tutorial: memulai pemahaman dan penggunaan PyTorch](https://pytorch.org/tutorials/)
- [Contoh: kode PyTorch mudah dipahami di semua domain](https://github.com/pytorch/examples)
- [Referensi API](https://pytorch.org/docs/)
- [Glosarium](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## Sumber Daya

* [PyTorch.org](https://pytorch.org/)
* [Tutorial PyTorch](https://pytorch.org/tutorials/)
* [Contoh PyTorch](https://github.com/pytorch/examples)
* [Model PyTorch](https://pytorch.org/hub/)
* [Intro to Deep Learning with PyTorch dari Udacity](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Intro to Machine Learning with PyTorch dari Udacity](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Deep Neural Networks with PyTorch dari Coursera](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [Blog PyTorch](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## Komunikasi
* Forum: Diskusi implementasi, riset, dll. https://discuss.pytorch.org
* GitHub Issues: Laporan bug, permintaan fitur, masalah instalasi, RFC, pemikiran, dll.
* Slack: [PyTorch Slack](https://pytorch.slack.com/) berisi pengguna dan pengembang PyTorch tingkat menengah hingga mahir untuk obrolan umum, diskusi online, kolaborasi, dll. Jika Anda pemula yang butuh bantuan, medium utama adalah [Forum PyTorch](https://discuss.pytorch.org). Jika butuh undangan slack, isi formulir: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* Newsletter: Newsletter satu arah tanpa spam dengan pengumuman penting tentang PyTorch. Daftar di sini: https://eepurl.com/cbG0rv
* Facebook Page: Pengumuman penting tentang PyTorch. https://www.facebook.com/pytorch
* Untuk panduan merek, kunjungi situs kami di [pytorch.org](https://pytorch.org/)

## Rilis dan Kontribusi

Biasanya, PyTorch memiliki tiga rilis minor per tahun. Mohon informasikan jika Anda menemukan bug dengan [mengisi issue](https://github.com/pytorch/pytorch/issues).

Kami menghargai semua kontribusi. Jika Anda berencana mengirim perbaikan bug, silakan lakukan tanpa diskusi lebih lanjut.

Jika Anda ingin menyumbang fitur baru, fungsi utilitas, atau ekstensi ke core, silakan buka issue dan diskusikan fitur dengan kami terlebih dahulu.
Mengirim PR tanpa diskusi bisa saja ditolak karena mungkin core sedang diambil ke arah berbeda dari yang Anda ketahui.

Untuk mempelajari lebih lanjut tentang kontribusi ke PyTorch, lihat [Halaman Kontribusi](CONTRIBUTING.md). Untuk info lebih lanjut tentang rilis PyTorch, lihat [Halaman Rilis](RELEASE.md).

## Tim

PyTorch adalah proyek berbasis komunitas dengan banyak insinyur dan peneliti andal yang berkontribusi.

PyTorch saat ini dikelola oleh [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang), dan [Nikita Shulga](https://github.com/malfet) dengan kontribusi besar dari ratusan individu berbakat dalam berbagai bentuk dan cara.
Daftar yang tidak lengkap namun terus bertambah perlu menyebut: [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito).

Catatan: Proyek ini tidak terkait dengan [hughperkins/pytorch](https://github.com/hughperkins/pytorch) dengan nama yang sama. Hugh adalah kontributor berharga untuk komunitas Torch dan telah membantu banyak hal terkait Torch dan PyTorch.

## Lisensi

PyTorch memiliki lisensi gaya BSD, seperti yang terdapat pada file [LICENSE](LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---