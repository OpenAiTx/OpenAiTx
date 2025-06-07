![PyTorch Logosu](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch, iki üst düzey özelliğe sahip bir Python paketidir:
- Güçlü GPU hızlandırmalı tensör hesaplaması (NumPy gibi)
- Bant tabanlı otomatik türev sistemiyle oluşturulmuş derin sinir ağları

İhtiyaç duyduğunuzda PyTorch'u genişletmek için NumPy, SciPy ve Cython gibi favori Python paketlerinizi yeniden kullanabilirsiniz.

Ana daldaki sağlık durumu (Sürekli Entegrasyon sinyalleri) [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main) adresinde bulunabilir.

<!-- toc -->

- [PyTorch Hakkında Daha Fazlası](#more-about-pytorch)
  - [GPU'ya Hazır Bir Tensör Kütüphanesi](#a-gpu-ready-tensor-library)
  - [Dinamik Sinir Ağları: Bant Tabanlı Otomatik Türev](#dynamic-neural-networks-tape-based-autograd)
  - [Öncelik Python'da](#python-first)
  - [Emirsel Deneyimler](#imperative-experiences)
  - [Hızlı ve Hafif](#fast-and-lean)
  - [Sorunsuz Genişletmeler](#extensions-without-pain)
- [Kurulum](#installation)
  - [İkili Dosyalar](#binaries)
    - [NVIDIA Jetson Platformları](#nvidia-jetson-platforms)
  - [Kaynaktan Kurulum](#from-source)
    - [Önkoşullar](#prerequisites)
      - [NVIDIA CUDA Desteği](#nvidia-cuda-support)
      - [AMD ROCm Desteği](#amd-rocm-support)
      - [Intel GPU Desteği](#intel-gpu-support)
    - [PyTorch Kaynağını Edinin](#get-the-pytorch-source)
    - [Bağımlılıkları Kurun](#install-dependencies)
    - [PyTorch'u Kurun](#install-pytorch)
      - [Derleme Seçeneklerini Ayarlama (İsteğe Bağlı)](#adjust-build-options-optional)
  - [Docker İmajı](#docker-image)
    - [Hazır İmajların Kullanılması](#using-pre-built-images)
    - [Kendi İmajınızı Oluşturma](#building-the-image-yourself)
  - [Dokümantasyonu Derleme](#building-the-documentation)
    - [PDF Oluşturma](#building-a-pdf)
  - [Önceki Sürümler](#previous-versions)
- [Başlangıç](#getting-started)
- [Kaynaklar](#resources)
- [İletişim](#communication)
- [Sürümler ve Katkı](#releases-and-contributing)
- [Ekip](#the-team)
- [Lisans](#license)

<!-- tocstop -->

## PyTorch Hakkında Daha Fazlası

[PyTorch'un temellerini öğrenin](https://pytorch.org/tutorials/beginner/basics/intro.html)

Detaylı olarak, PyTorch aşağıdaki bileşenlerden oluşan bir kütüphanedir:

| Bileşen | Açıklama |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | NumPy gibi bir Tensör kütüphanesi, güçlü GPU desteğiyle |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | torch içindeki tüm türevlenebilir Tensör işlemlerini destekleyen bant tabanlı otomatik türev kütüphanesi |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | PyTorch kodundan serileştirilebilir ve optimize edilebilir modeller oluşturan bir derleme yığını (TorchScript) |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | Maksimum esneklik için autograd ile derinlemesine entegre edilmiş bir sinir ağları kütüphanesi |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | torch Tensörlerinin işlemler arasında sihirli bellek paylaşımı ile Python çoklu işlem. Veri yükleme ve Hogwild eğitimi için faydalı |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | Kolaylık için DataLoader ve diğer yardımcı işlevler |

Genellikle, PyTorch ya:

- GPU’ların gücünü kullanmak için NumPy yerine,
- Maksimum esneklik ve hız sağlayan bir derin öğrenme araştırma platformu olarak kullanılır.

Daha Fazlası:

### GPU'ya Hazır Bir Tensör Kütüphanesi

NumPy kullanıyorsanız, zaten Tensörleri (veya ndarray) kullanıyorsunuz demektir.

![Tensör illüstrasyonu](./docs/source/_static/img/tensor_illustration.png)

PyTorch, CPU veya GPU üzerinde yaşayabilen Tensörler sağlar ve
hesaplamayı büyük ölçüde hızlandırır.

Bilimsel hesaplama ihtiyaçlarınızı karşılamak ve hızlandırmak için çok çeşitli tensör rutinleri sağlıyoruz:
bölütleme, indeksleme, matematiksel işlemler, lineer cebir, indirgemeler gibi.
Ve bunlar oldukça hızlıdır!

### Dinamik Sinir Ağları: Bant Tabanlı Otomatik Türev

PyTorch, sinir ağlarını kurmak için benzersiz bir yol sunar: bir bant kaydedici kullanmak ve tekrar oynatmak.

TensorFlow, Theano, Caffe ve CNTK gibi çoğu framework dünyayı statik olarak görür.
Bir sinir ağı inşa edilir ve aynı yapı tekrar tekrar kullanılır.
Ağın davranışını değiştirmek için sıfırdan başlamak gerekir.

PyTorch ile, ters mod otomatik türevleme (reverse-mode auto-differentiation) adı verilen bir teknik kullanıyoruz; bu, ağınızın davranışını gecikmesiz ve ek yük olmadan keyfi olarak değiştirmenize olanak tanır. İlham kaynağımız bu konudaki çeşitli araştırma makaleleri ile [torch-autograd](https://github.com/twitter/torch-autograd),
[autograd](https://github.com/HIPS/autograd),
[Chainer](https://chainer.org) gibi önceki ve güncel çalışmalardır.

Bu teknik sadece PyTorch'a özgü olmasa da, bugüne kadarki en hızlı uygulamalardan biridir.
Çılgın araştırmalarınız için hız ve esnekliğin en iyisini elde edersiniz.

![Dinamik grafik](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Öncelik Python'da

PyTorch, tekdüze bir C++ framework'üne Python bağlaması değildir.
Python ile derinlemesine entegre olacak şekilde inşa edilmiştir.
[NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) gibi doğal olarak kullanabilirsiniz.
Yeni sinir ağı katmanlarınızı doğrudan Python'da, favori kütüphanelerinizi kullanarak yazabilirsiniz
ve [Cython](https://cython.org/) ile [Numba](http://numba.pydata.org/) gibi paketler kullanabilirsiniz.
Amacımız, uygun olan yerde tekerleği yeniden icat etmemektir.

### Emirsel Deneyimler

PyTorch, sezgisel, doğrusal düşünceye uygun ve kullanımı kolay olacak şekilde tasarlanmıştır.
Bir kod satırı çalıştırdığınızda, hemen çalışır. Asenkron bir dünya yoktur.
Bir hata mesajı veya stack trace aldığınızda, anlaması kolaydır.
Stack trace doğrudan kodunuzun tanımlandığı yere işaret eder.
Kötü stack trace'ler veya asenkron ve opak yürütme motorları yüzünden saatlerce hata ayıklamak zorunda kalmamanızı umuyoruz.

### Hızlı ve Hafif

PyTorch, minimum framework yüküne sahiptir. [Intel MKL](https://software.intel.com/mkl) ve NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)) gibi hızlandırıcı kütüphaneler entegre ediyoruz.
Çekirdekteki CPU ve GPU Tensör ile sinir ağı arka uçları
oldukça olgundur ve yıllardır test edilmektedir.

Bu nedenle, PyTorch oldukça hızlıdır — ister küçük ister büyük sinir ağları çalıştırıyor olun.

PyTorch'taki bellek kullanımı, Torch veya bazı alternatiflerle karşılaştırıldığında son derece verimlidir.
GPU için özel bellek ayırıcılar yazdık, böylece
derin öğrenme modelleriniz maksimum bellek verimliliğine sahip olur.
Bu, daha önceki modellere göre daha büyük derin öğrenme modelleri eğitmenizi sağlar.

### Sorunsuz Genişletmeler

Yeni sinir ağı modülleri yazmak veya PyTorch'un Tensör API'siyle arayüz oluşturmak, basit ve minimum soyutlamalarla tasarlanmıştır.

torch API'sini kullanarak Python'da yeni sinir ağı katmanları
[veya SciPy gibi favori NumPy tabanlı kütüphanelerinizle](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html) yazabilirsiniz.

Katmanlarınızı C/C++'ta yazmak isterseniz, verimli ve az kod gerektiren uygun bir genişletme API'si sağlıyoruz.
Ek bir sarmalayıcı kod yazmanız gerekmez. [Burada bir eğitim](https://pytorch.org/tutorials/advanced/cpp_extension.html) ve [örnek](https://github.com/pytorch/extension-cpp) bulabilirsiniz.


## Kurulum

### İkili Dosyalar
Conda veya pip wheels ile ikili dosyaları yüklemek için komutlar web sitemizdedir: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)


#### NVIDIA Jetson Platformları

NVIDIA'nın Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX ve Jetson AGX Orin için Python wheel dosyaları [burada](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) sağlanmıştır ve L4T container [burada](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch) yayınlanmıştır.

JetPack 4.2 ve üstü gereklidir, ve [@dusty-nv](https://github.com/dusty-nv) ile [@ptrblck](https://github.com/ptrblck) tarafından bakım yapılmaktadır.


### Kaynaktan Kurulum

#### Önkoşullar
Kaynak koddan kurulum yapacaksanız, şunlara ihtiyacınız olacak:
- Python 3.9 veya üstü
- C++17'yi tamamen destekleyen bir derleyici, örn. clang veya gcc (Linux'ta gcc 9.4.0 veya üstü gereklidir)
- Visual Studio veya Visual Studio Build Tool (sadece Windows için)

\* PyTorch CI, Visual Studio Enterprise, Professional veya Community Sürümleriyle gelen Visual C++ BuildTools'u kullanır. Build tools'u ayrıca https://visualstudio.microsoft.com/visual-cpp-build-tools/ adresinden kurabilirsiniz. Build tools *varsayılan olarak* Visual Studio Code ile gelmez.

Aşağıda bir ortam kurulumu örneği gösterilmiştir:

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

##### NVIDIA CUDA Desteği
CUDA desteğiyle derleme yapmak istiyorsanız, [destek matrisimizden desteklenen bir CUDA sürümü seçin](https://pytorch.org/get-started/locally/), ardından şunları yükleyin:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 veya üstü
- CUDA ile uyumlu [Derleyici](https://gist.github.com/ax3l/9489132)

Not: [cuDNN Destek Matrisi](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) üzerinden, farklı CUDA, CUDA sürücüsü ve NVIDIA donanımlarıyla uyumlu cuDNN sürümlerine bakabilirsiniz.

CUDA desteğini devre dışı bırakmak isterseniz, `USE_CUDA=0` ortam değişkenini dışa aktarın.
Diğer faydalı ortam değişkenleri `setup.py` içinde bulunabilir.

NVIDIA'nın Jetson platformları (Jetson Nano, TX1, TX2, AGX Xavier) için derleme yapıyorsanız, Jetson Nano için PyTorch kurulum talimatları [burada](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/) mevcuttur.

##### AMD ROCm Desteği
ROCm desteğiyle derleme yapmak istiyorsanız, şunları yükleyin:
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 ve üstü
- ROCm şu anda sadece Linux sistemlerinde desteklenmektedir.

Varsayılan olarak derleme sistemi, ROCm'un `/opt/rocm` dizinine kurulu olduğunu varsayar. ROCm farklı bir dizine kuruluysa, `ROCM_PATH` ortam değişkeni ROCm kurulum dizinine ayarlanmalıdır. Derleme sistemi AMD GPU mimarisini otomatik olarak algılar. İsteğe bağlı olarak, AMD GPU mimarisi `PYTORCH_ROCM_ARCH` ortam değişkeniyle açıkça ayarlanabilir [AMD GPU mimarisi](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

ROCm desteğini devre dışı bırakmak için `USE_ROCM=0` ortam değişkenini dışa aktarın.
Diğer faydalı ortam değişkenleri `setup.py` içinde bulunabilir.

##### Intel GPU Desteği
Intel GPU desteğiyle derleme yapmak istiyorsanız, şunları takip edin:
- [Intel GPU'lar için PyTorch Önkoşulları](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html) talimatları.
- Intel GPU desteği Linux ve Windows için mevcuttur.

Intel GPU desteğini devre dışı bırakmak için `USE_XPU=0` ortam değişkenini dışa aktarın.
Diğer faydalı ortam değişkenleri `setup.py` içinde bulunabilir.

#### PyTorch Kaynağını Edinin
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# mevcut bir checkout'u güncelliyorsanız
git submodule sync
git submodule update --init --recursive
```

#### Bağımlılıkları Kurun

**Ortak**

```bash
conda install cmake ninja
# Aşağıdaki “PyTorch Kaynağını Edinin” bölümünden kaynak kodunu klonladıktan sonra bu komutu PyTorch dizininde çalıştırın
pip install -r requirements.txt
```

**Linux'ta**

```bash
pip install mkl-static mkl-include
# Sadece CUDA: Gerekirse GPU için LAPACK desteği ekleyin
# magma kurulumu: aktif conda ortamında çalıştırın. kurulacak CUDA sürümünü belirtin
.ci/docker/common/install_magma_conda.sh 12.4

# (isteğe bağlı) torch.compile ile inductor/triton kullanıyorsanız, triton'un uyumlu sürümünü kurun
# pytorch dizininde çalıştırın
# Intel GPU desteği için, komutu çalıştırmadan önce `export USE_XPU=1` komutunu açıkça verin.
make triton
```

**MacOS'ta**

```bash
# Sadece intel x86 işlemcili makinelerde bu paketi ekleyin
pip install mkl-static mkl-include
# torch.distributed gerekiyorsa bu paketleri ekleyin
conda install pkg-config libuv
```

**Windows'ta**

```bash
pip install mkl-static mkl-include
# torch.distributed gerekiyorsa bu paketleri ekleyin.
# Windows'ta distributed paket desteği prototip aşamasındadır ve değişebilir.
conda install -c conda-forge libuv=1.39
```

#### PyTorch'u Kurun
**Linux'ta**

AMD ROCm için derleme yapıyorsanız öncelikle bu komutu çalıştırın:
```bash
# Sadece ROCm için derliyorsanız çalıştırın
python tools/amd_build/build_amd.py
```

PyTorch'u Kurun
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**macOS'ta**

```bash
python3 setup.py develop
```

**Windows'ta**

Eski python kodu için derleme yapmak isterseniz, [Eski kod ve CUDA ile Derleme](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda) başvurusuna bakın.

**Sadece CPU derlemesi**

Bu modda PyTorch hesaplamaları GPU yerine CPU'nuzda çalışacaktır.

```cmd
python setup.py develop
```

OpenMP notu: İstenen OpenMP uygulaması Intel OpenMP (iomp)'dur. iomp'a bağlanmak için kütüphaneyi manuel indirmeniz ve `CMAKE_INCLUDE_PATH` ile `LIB` ortamlarını ayarlamanız gerekir. [Buradaki](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) talimatlar MKL ve Intel OpenMP'nin nasıl kurulacağına dair örnektir. Bu CMake yapılandırmaları olmadan, Microsoft Visual C OpenMP runtime (vcomp) kullanılacaktır.

**CUDA tabanlı derleme**

Bu modda PyTorch hesaplamaları, daha hızlı hesaplama için GPU'nuzu CUDA üzerinden kullanacaktır.

PyTorch'u CUDA ile derlemek için [NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) gereklidir.
NVTX, CUDA dağıtımının bir parçasıdır ve "Nsight Compute" olarak adlandırılır. Zaten kurulu bir CUDA'ya eklemek için CUDA kurulumunu tekrar çalıştırıp ilgili seçeneği işaretleyin.
CUDA ve Nsight Compute'un Visual Studio'dan sonra kurulu olduğundan emin olun.

Şu anda, CMake için VS 2017 / 2019 ve Ninja desteklenmektedir. `ninja.exe` `PATH` içinde tespit edilirse, Ninja varsayılan jeneratör olarak kullanılır, aksi takdirde VS 2017 / 2019 kullanılır.
<br/> Jeneratör olarak Ninja seçilirse, en son MSVC altta yatan araç seti olarak seçilecektir.

Ek kütüphaneler olarak
[Magma](https://developer.nvidia.com/magma), [oneDNN, diğer adıyla MKLDNN veya DNNL](https://github.com/oneapi-src/oneDNN) ve [Sccache](https://github.com/mozilla/sccache) çoğunlukla gereklidir. Kurulum için [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) başvurusuna bakabilirsiniz.

Bazı diğer ortam değişkenleri ayarları için [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) scriptine bakabilirsiniz.

```cmd
cmd

:: mkl paketini indirip açtıktan sonra ortam değişkenlerini ayarlayın,
:: aksi halde CMake `Could NOT find OpenMP` hatası verecektir.
set CMAKE_INCLUDE_PATH={Your directory}\mkl\include
set LIB={Your directory}\mkl\lib;%LIB%

:: Önceki bölümü dikkatlice okuyun.
:: [İsteğe Bağlı] Ninja ve Visual Studio ile CUDA kullanırken alt araç setini değiştirmek isterseniz aşağıdaki komut bloğunu çalıştırın.
:: "Visual Studio 2019 Developer Command Prompt" otomatik olarak çalışacaktır.
:: Visual Studio jeneratörü kullanırken CMake >= 3.12 gereklidir.
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [İsteğe Bağlı] CUDA ana derleyicisini değiştirmek isterseniz
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Intel GPU derlemesi**

Bu modda Intel GPU desteğiyle PyTorch derlenecektir.

[Lütfen ortak önkoşullar](#prerequisites) ve [Intel GPU için önkoşullar](#intel-gpu-support) düzgün yüklendiğinden ve ortam değişkenleri ayarlandığından emin olun. Derleme aracı desteği için `Visual Studio 2022` gereklidir.

Daha sonra PyTorch şu komutla derlenebilir:

```cmd
:: CMD Komutları:
:: Karşılık gelen paketleri bulmak için CMAKE_PREFIX_PATH ayarlayın
:: %CONDA_PREFIX% sadece `conda activate custom_env` sonrası çalışır

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### Derleme Seçeneklerini Ayarlama (İsteğe Bağlı)

Cmake değişkenlerinin yapılandırmasını isteğe bağlı olarak (önceden derleme yapmadan) aşağıdaki gibi ayarlayabilirsiniz. Örneğin, CuDNN veya BLAS için önceden tespit edilen dizinleri ayarlamak bu adımla mümkündür.

Linux'ta
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # veya cmake-gui build
```

macOS'ta
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # veya cmake-gui build
```

### Docker İmajı

#### Hazır İmajların Kullanılması

Docker Hub'dan önceden hazırlanmış bir docker imajını çekebilir ve docker v19.03+ ile çalıştırabilirsiniz

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

PyTorch'un işlemler arasında veri paylaşımı için shared memory kullandığını unutmayın, bu nedenle torch multiprocessing kullanılırsa (ör. çoklu iş parçacıklı veri yükleyiciler için) konteynerin varsayılan shared memory segment boyutu yeterli olmayacaktır; bu nedenle, shared memory boyutunu `--ipc=host` veya `--shm-size` komut satırı seçenekleriyle artırmalısınız.

#### Kendi İmajınızı Oluşturma

**NOT:** Docker'ın 18.06'dan büyük bir sürümüyle oluşturulmalıdır.

`Dockerfile`, CUDA 11.1 desteği ve cuDNN v8 ile imaj oluşturmak için sağlanmıştır.
Hangi Python sürümünün Miniconda tarafından kullanılacağını belirtmek için `PYTHON_VERSION=x.y` make değişkenini iletebilir veya varsayılanı kullanmak için bırakabilirsiniz.

```bash
make -f docker.Makefile
# imajlar docker.io/${your_docker_username}/pytorch olarak etiketlenir
```

Ek CMake değişkenlerini derleme sırasında CMake'e iletmek için `CMAKE_VARS="..."` ortam değişkenini de verebilirsiniz.
Kullanılabilir değişkenlerin listesi için [setup.py](./setup.py) dosyasına bakınız.

```bash
make -f docker.Makefile
```

### Dokümantasyonu Derleme

Dokümantasyonu çeşitli formatlarda oluşturmak için [Sphinx](http://www.sphinx-doc.org)
ve pytorch_sphinx_theme2 gereklidir.

Dokümantasyonu yerel olarak oluşturmadan önce, ortamınıza `torch` kurulu olduğundan emin olun. Küçük düzeltmeler için, [Başlangıç](https://pytorch.org/get-started/locally/) bölümünde anlatıldığı gibi nightly sürümü kurabilirsiniz.

Yeni bir modül eklemek ve bunun için docstring eklemek gibi daha karmaşık düzeltmeler için, torch'u [kaynak koddan](#from-source) yüklemeniz gerekebilir.
Docstring kuralları için [Docstring Guidelines](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines) sayfasına bakınız.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

Tüm mevcut çıktı formatları listesini almak için `make` komutunu çalıştırın.

Eğer katex hatası alırsanız `npm install katex` çalıştırın. Sorun devam ederse
`npm install -g katex` deneyin.

> [!NOT]
> Eğer `nodejs`'i farklı bir paket yöneticisiyle (örn. `conda`) yüklediyseniz, `npm` büyük olasılıkla `nodejs` sürümünüzle uyumlu olmayan bir `katex` sürümü yükleyecek ve dokümantasyon derlemesi başarısız olacaktır.
> Bilinen çalışan bir sürüm kombinasyonu `node@6.13.1` ve
> `katex@0.13.18`'dir. Sonuncuyu yüklemek için:
> ```npm install -g katex@0.13.18```

> [!NOT]
> numpy uyumsuzluk hatası görürseniz:
> ```
> pip install 'numpy<2'
> ```

CI tarafından çalıştırılan bağımlılıkları değiştirdiğinizde
`.ci/docker/requirements-docs.txt` dosyasını düzenleyin.

#### PDF Oluşturma

Tüm PyTorch dokümantasyonunun PDF'ini derlemek için,
`texlive` ve LaTeX kurulu olmalıdır. macOS'ta, şunlarla kurabilirsiniz:

```
brew install --cask mactex
```

PDF oluşturmak için:

1. Şunu çalıştırın:

   ```
   make latexpdf
   ```

   Gerekli dosyalar `build/latex` dizininde oluşturulacaktır.

2. Bu dizine gidip şunu çalıştırın:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   Bu, istenen içeriğe sahip bir `pytorch.pdf` oluşturacaktır. Doğru içindekiler tablosu ve indeksin oluşturulması için komutu bir kez daha çalıştırın.

> [!NOT]
> İçindekiler Tablosunu görmek için, PDF görüntüleyicinizde **Table of Contents** görünümüne geçin.


### Önceki Sürümler

Önceki PyTorch sürümlerinin kurulum talimatları ve ikili dosyalar
[web sitemizde](https://pytorch.org/get-started/previous-versions) bulunabilir.


## Başlangıç

Başlamak için üç öneri:
- [Eğitimler: PyTorch'u anlamak ve kullanmak için](https://pytorch.org/tutorials/)
- [Örnekler: Tüm alanlarda kolay anlaşılır PyTorch kodları](https://github.com/pytorch/examples)
- [API Referansı](https://pytorch.org/docs/)
- [Sözlük](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## Kaynaklar

* [PyTorch.org](https://pytorch.org/)
* [PyTorch Eğitimleri](https://pytorch.org/tutorials/)
* [PyTorch Örnekleri](https://github.com/pytorch/examples)
* [PyTorch Modelleri](https://pytorch.org/hub/)
* [Udacity'den PyTorch ile Derin Öğrenmeye Giriş](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Udacity'den PyTorch ile Makine Öğrenimine Giriş](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Coursera'dan PyTorch ile Derin Sinir Ağları](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [PyTorch Blog](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## İletişim
* Forumlar: Uygulama, araştırma vb. tartışmaları için: https://discuss.pytorch.org
* GitHub Issues: Hata raporları, özellik talepleri, kurulum sorunları, RFC'ler, düşünceler vb.
* Slack: [PyTorch Slack](https://pytorch.slack.com/) esas olarak orta ve ileri seviye PyTorch kullanıcıları ve geliştiricilerine hitap eder; genel sohbet, çevrimiçi tartışmalar, iş birliği vs. Başlangıç seviyesindeyseniz ana ortam [PyTorch Forumları](https://discuss.pytorch.org)'dur. Slack davetiyesi için şu formu doldurun: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* Bülten: Gürültüsüz, tek yönlü e-posta bülteniyle PyTorch ile ilgili önemli duyurular. Buradan kayıt olabilirsiniz: https://eepurl.com/cbG0rv
* Facebook Sayfası: PyTorch ile ilgili önemli duyurular. https://www.facebook.com/pytorch
* Marka yönergeleri için lütfen [web sitemizi](https://pytorch.org/) ziyaret edin.

## Sürümler ve Katkı

Genellikle, PyTorch yılda üç küçük sürüm yayınlar. Bir hata ile karşılaşırsanız lütfen [bir issue açarak](https://github.com/pytorch/pytorch/issues) bize bildirin.

Tüm katkılarınız için minnettarız. Hata düzeltmeleri yapmak istiyorsanız, herhangi bir ek tartışma olmadan katkıda bulunabilirsiniz.

Yeni özellikler, yardımcı işlevler veya çekirdeğe eklenecek genişletmeler katkısı yapmayı planlıyorsanız, önce bir issue açıp bizimle tartışın.
Tartışma olmadan PR göndermek, çekirdek başka bir yöne gidiyorsa reddedilmiş bir PR ile sonuçlanabilir.

PyTorch'a katkı hakkında daha fazla bilgi için [Katkı sayfamıza](CONTRIBUTING.md) bakabilirsiniz. PyTorch sürümleriyle ilgili daha fazla bilgi için [Sürüm sayfasına](RELEASE.md) bakabilirsiniz.

## Ekip

PyTorch, çok sayıda yetenekli mühendis ve araştırmacının katkıda bulunduğu topluluk odaklı bir projedir.

PyTorch şu anda [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang) ve [Nikita Shulga](https://github.com/malfet) tarafından sürdürülmektedir ve yüzlerce yetenekli bireyin çeşitli katkılarıyla gelişmektedir.
Eksik ama büyüyen bir liste olarak: [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito).

Not: Bu proje, aynı ada sahip [hughperkins/pytorch](https://github.com/hughperkins/pytorch) ile ilişkili değildir. Hugh, Torch topluluğuna değerli katkılarda bulunmuş ve Torch ile PyTorch'a birçok konuda yardımcı olmuştur.

## Lisans

PyTorch, [LICENSE](LICENSE) dosyasında bulunan BSD tarzı bir lisansa sahiptir.


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---