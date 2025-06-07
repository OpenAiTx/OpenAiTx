![لوگوی PyTorch](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch یک بسته پایتون است که دو ویژگی سطح بالای زیر را فراهم می‌کند:
- محاسبه تنسور (مانند NumPy) با شتاب‌دهی قدرتمند GPU
- شبکه‌های عصبی عمیق ساخته شده بر پایه سیستم autograd مبتنی بر نوار

شما می‌توانید بسته‌های محبوب پایتون مانند NumPy، SciPy و Cython را برای گسترش PyTorch در مواقع مورد نیاز مجدداً استفاده کنید.

سلامت شاخه اصلی ما (سیگنال‌های ادغام مداوم) در [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main) قابل مشاهده است.

<!-- toc -->

- [اطلاعات بیشتر درباره PyTorch](#اطلاعات-بیشتر-درباره-pytorch)
  - [کتابخانه تنسور آماده GPU](#کتابخانه-تنسور-آماده-gpu)
  - [شبکه‌های عصبی پویا: Autograd مبتنی بر نوار](#شبکه‌های-عصبی-پویا-autograd-مبتنی-بر-نوار)
  - [اول پایتون](#اول-پایتون)
  - [تجربیات دستوری](#تجربیات-دستوری)
  - [سریع و کم‌حجم](#سریع-و-کم‌حجم)
  - [گسترش بدون دردسر](#گسترش-بدون-دردسر)
- [نصب](#نصب)
  - [باینری‌ها](#باینری‌ها)
    - [پلتفرم‌های NVIDIA Jetson](#پلتفرم‌های-nvidia-jetson)
  - [از سورس](#از-سورس)
    - [پیش‌نیازها](#پیش‌نیازها)
      - [پشتیبانی NVIDIA CUDA](#پشتیبانی-nvidia-cuda)
      - [پشتیبانی AMD ROCm](#پشتیبانی-amd-rocm)
      - [پشتیبانی GPU اینتل](#پشتیبانی-gpu-اینتل)
    - [دریافت سورس PyTorch](#دریافت-سورس-pytorch)
    - [نصب وابستگی‌ها](#نصب-وابستگی‌ها)
    - [نصب PyTorch](#نصب-pytorch)
      - [تنظیم گزینه‌های ساخت (اختیاری)](#تنظیم-گزینه‌های-ساخت-اختیاری)
  - [ایمیج داکر](#ایمیج-داکر)
    - [استفاده از ایمیج‌های آماده](#استفاده-از-ایمیج‌های-آماده)
    - [ساخت ایمیج به صورت دستی](#ساخت-ایمیج-به-صورت-دستی)
  - [ساخت مستندات](#ساخت-مستندات)
    - [ساخت PDF](#ساخت-pdf)
  - [نسخه‌های قبلی](#نسخه‌های-قبلی)
- [شروع به کار](#شروع-به-کار)
- [منابع](#منابع)
- [ارتباطات](#ارتباطات)
- [انتشارها و مشارکت](#انتشارها-و-مشارکت)
- [تیم](#تیم)
- [مجوز](#مجوز)

<!-- tocstop -->

## اطلاعات بیشتر درباره PyTorch

[مبانی PyTorch را بیاموزید](https://pytorch.org/tutorials/beginner/basics/intro.html)

در سطح جزئی‌تر، PyTorch کتابخانه‌ای است که از اجزای زیر تشکیل شده است:

| مؤلفه | توضیحات |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | کتابخانه تنسور مانند NumPy با پشتیبانی قدرتمند GPU |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | کتابخانه مشتق‌گیری خودکار مبتنی بر نوار که همه عملیات‌های تنسور قابل مشتق در torch را پشتیبانی می‌کند |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | پشته کامپایل (TorchScript) برای ایجاد مدل‌های قابل سریال‌سازی و بهینه‌سازی از کد PyTorch |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | کتابخانه شبکه‌های عصبی که با autograd یکپارچه شده و برای بیشینه انعطاف‌پذیری طراحی شده است |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | چندفرایندی پایتون، اما با اشتراک‌گذاری جادویی حافظه تنسورها بین فرایندها. مفید برای بارگذاری داده و آموزش Hogwild |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader و سایر توابع کمکی برای راحتی بیشتر |

معمولاً PyTorch به دو صورت استفاده می‌شود:

- جایگزینی برای NumPy برای بهره‌گیری از قدرت GPUها.
- پلتفرم تحقیقاتی یادگیری عمیق که بیشینه انعطاف‌پذیری و سرعت را فراهم می‌کند.

توضیحات بیشتر:

### کتابخانه تنسور آماده GPU

اگر از NumPy استفاده کرده‌اید، پس با تنسورها (همان ndarray) آشنا هستید.

![تصویرسازی تنسور](./docs/source/_static/img/tensor_illustration.png)

PyTorch تنسورهایی ارائه می‌دهد که می‌توانند روی CPU یا GPU قرار گیرند و محاسبات را با شتاب بسیار بالا انجام می‌دهند.

ما مجموعه‌ای گسترده از توابع تنسور برای پاسخ‌گویی به نیازهای محاسبات علمی شما ارائه می‌دهیم، مانند برش، اندیس‌گذاری، عملیات ریاضی، جبر خطی، کاهش‌ها و غیره.
و بسیار سریع هستند!

### شبکه‌های عصبی پویا: Autograd مبتنی بر نوار

PyTorch روشی منحصربه‌فرد برای ساخت شبکه‌های عصبی دارد: استفاده و بازپخش ضبط‌کننده نوار.

بیشتر فریم‌ورک‌ها مانند TensorFlow، Theano، Caffe و CNTK دیدگاه ایستا دارند.
باید یک شبکه عصبی بسازید و بارها از همان ساختار استفاده کنید.
تغییر رفتار شبکه به معنای شروع از ابتدا است.

در PyTorch از تکنیکی به نام مشتق‌گیری خودکار معکوس (reverse-mode auto-differentiation) استفاده می‌کنیم که به شما اجازه می‌دهد رفتار شبکه خود را به طور دلخواه و بدون تأخیر یا سربار تغییر دهید. الهام ما از چندین مقاله تحقیقاتی و پروژه‌هایی مانند [torch-autograd](https://github.com/twitter/torch-autograd)، [autograd](https://github.com/HIPS/autograd)، [Chainer](https://chainer.org) و غیره گرفته شده است.

در حالی که این تکنیک منحصراً متعلق به PyTorch نیست، اما یکی از سریع‌ترین پیاده‌سازی‌های آن تا به امروز است.
شما بهترین سرعت و انعطاف‌پذیری را برای تحقیقات پیشرفته خود خواهید داشت.

![گراف پویا](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### اول پایتون

PyTorch یک اتصال پایتون به یک فریم‌ورک C++ یکپارچه نیست.
بلکه به گونه‌ای ساخته شده که عمیقاً با پایتون یکپارچه باشد.
می‌توانید به طور طبیعی مانند [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) و غیره از آن استفاده کنید.
می‌توانید لایه‌های جدید شبکه عصبی را مستقیماً در پایتون با استفاده از کتابخانه‌های مورد علاقه خود بنویسید و از بسته‌هایی مانند [Cython](https://cython.org/) و [Numba](http://numba.pydata.org/) بهره ببرید.
هدف ما این است که در صورت امکان، چرخ را از نو اختراع نکنیم.

### تجربیات دستوری

PyTorch طوری طراحی شده که شهودی، خطی در تفکر و آسان برای استفاده باشد.
هر خط کد را که اجرا می‌کنید، همان لحظه اجرا می‌شود. هیچ دیدگاه غیرهمزمانی وجود ندارد.
وقتی وارد اشکال‌زدا می‌شوید یا پیام خطا و trace می‌گیرید، فهم آن‌ها مستقیم است.
trace دقیقاً به جایی اشاره می‌کند که کد شما تعریف شده است.
امیدواریم هیچ‌گاه ساعت‌ها وقت خود را صرف اشکال‌زدایی به خاطر traceهای بد یا موتورهای اجرای غیرهمزمان و مبهم نکنید.

### سریع و کم‌حجم

PyTorch سربار چارچوبی حداقلی دارد. ما کتابخانه‌های شتاب‌دهنده‌ای مانند [Intel MKL](https://software.intel.com/mkl) و NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn)، [NCCL](https://developer.nvidia.com/nccl)) را برای بیشینه سرعت یکپارچه کرده‌ایم.
در هسته خود، backendهای تنسور و شبکه عصبی PyTorch برای CPU و GPU بالغ هستند و سال‌ها تست شده‌اند.

در نتیجه، PyTorch بسیار سریع است، چه شبکه‌های کوچک و چه بزرگ اجرا کنید.

مصرف حافظه در PyTorch نسبت به Torch یا برخی جایگزین‌ها بسیار کارآمد است.
ما برای GPU تخصیص‌دهنده حافظه اختصاصی نوشته‌ایم تا مدل‌های یادگیری عمیق شما بیشینه بهره‌وری حافظه را داشته باشند.
این امکان را فراهم می‌کند تا مدل‌های یادگیری عمیق بزرگ‌تری نسبت به گذشته آموزش دهید.

### گسترش بدون دردسر

نوشتن ماژول‌های جدید شبکه عصبی یا ارتباط با API تنسور PyTorch طوری طراحی شده که ساده و با کمترین انتزاع باشد.

می‌توانید لایه‌های جدید شبکه عصبی را در پایتون با استفاده از API torch [یا کتابخانه‌های مبتنی بر NumPy مانند SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html) بنویسید.

اگر می‌خواهید لایه‌های خود را در C/C++ بنویسید، ما یک API گسترش آسان و کارآمد با حداقل کد اضافی ارائه می‌دهیم.
نیازی به نوشتن کد wrapper نیست. [آموزش اینجا](https://pytorch.org/tutorials/advanced/cpp_extension.html) و [مثال اینجا](https://github.com/pytorch/extension-cpp) را ببینید.

## نصب

### باینری‌ها
دستورات نصب باینری‌ها از طریق Conda یا pip wheel در سایت ما موجود است: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)

#### پلتفرم‌های NVIDIA Jetson

Wheelهای پایتون برای Jetson Nano، Jetson TX1/TX2، Jetson Xavier NX/AGX و Jetson AGX Orin [اینجا](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) ارائه شده‌اند و کانتینر L4T [اینجا](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch) منتشر شده است.

آن‌ها نیازمند JetPack 4.2 به بالا هستند و [@dusty-nv](https://github.com/dusty-nv) و [@ptrblck](https://github.com/ptrblck) نگهداری آن‌ها را بر عهده دارند.

### از سورس

#### پیش‌نیازها
اگر قصد نصب از سورس را دارید، به موارد زیر نیاز دارید:
- پایتون ۳.۹ یا بالاتر
- کامپایلری که کاملاً از C++17 پشتیبانی کند، مانند clang یا gcc (در لینوکس gcc 9.4.0 یا جدیدتر مورد نیاز است)
- Visual Studio یا Visual Studio Build Tool (فقط ویندوز)

\* CI PyTorch از Visual C++ BuildTools استفاده می‌کند، که همراه با نسخه‌های Enterprise، Professional یا Community ویژوال استودیو ارائه می‌شود. همچنین می‌توانید ابزار ساخت را از آدرس https://visualstudio.microsoft.com/visual-cpp-build-tools/ نصب کنید. ابزار ساخت به طور پیش‌فرض همراه Visual Studio Code ارائه نمی‌شود.

یک نمونه تنظیم محیط به شرح زیر است:

* لینوکس:

```bash
$ source <CONDA_INSTALL_DIR>/bin/activate
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
```

* ویندوز:

```bash
$ source <CONDA_INSTALL_DIR>\Scripts\activate.bat
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
$ call "C:\Program Files\Microsoft Visual Studio\<VERSION>\Community\VC\Auxiliary\Build\vcvarsall.bat" x64
```

##### پشتیبانی NVIDIA CUDA
اگر می‌خواهید با پشتیبانی CUDA کامپایل کنید، [یک نسخه پشتیبانی‌شده CUDA از جدول پشتیبانی ما انتخاب کنید](https://pytorch.org/get-started/locally/)، سپس موارد زیر را نصب کنید:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) نسخه ۸.۵ یا بالاتر
- [کامپایلر](https://gist.github.com/ax3l/9489132) سازگار با CUDA

توجه: می‌توانید به [جدول پشتیبانی cuDNN](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) برای نسخه‌های cuDNN با CUDAهای مختلف، درایور CUDA و سخت‌افزار NVIDIA مراجعه کنید.

اگر می‌خواهید پشتیبانی CUDA را غیرفعال کنید، متغیر محیطی `USE_CUDA=0` را صادر کنید.
سایر متغیرهای محیطی مفید در `setup.py` موجود است.

اگر برای پلتفرم‌های Jetson شرکت NVIDIA (Jetson Nano، TX1، TX2، AGX Xavier) کامپایل می‌کنید، [دستورالعمل نصب PyTorch برای Jetson Nano اینجاست](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### پشتیبانی AMD ROCm
اگر می‌خواهید با پشتیبانی ROCm کامپایل کنید، نصب کنید:
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) نسخه ۴.۰ به بالا
- ROCm در حال حاضر فقط برای سیستم‌های لینوکس پشتیبانی می‌شود.

به طور پیش‌فرض، سیستم ساخت انتظار دارد ROCm در مسیر `/opt/rocm` نصب شده باشد. اگر ROCm در مسیر دیگری نصب شده، متغیر محیطی `ROCM_PATH` را به مسیر نصب ROCm تنظیم کنید. سیستم ساخت به طور خودکار معماری GPUهای AMD را تشخیص می‌دهد. در صورت نیاز، معماری GPUهای AMD را می‌توان با متغیر محیطی `PYTORCH_ROCM_ARCH` به صورت صریح تنظیم کرد. [لیست GPUهای پشتیبانی شده](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

اگر می‌خواهید پشتیبانی ROCm را غیرفعال کنید، متغیر محیطی `USE_ROCM=0` را صادر کنید.
سایر متغیرهای محیطی مفید در `setup.py` موجود است.

##### پشتیبانی GPU اینتل
اگر می‌خواهید با پشتیبانی GPU اینتل کامپایل کنید، مراحل زیر را دنبال کنید:
- [دستورالعمل‌های پیش‌نیاز PyTorch برای GPU اینتل](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html)
- GPU اینتل برای لینوکس و ویندوز پشتیبانی می‌شود.

اگر می‌خواهید پشتیبانی GPU اینتل را غیرفعال کنید، متغیر محیطی `USE_XPU=0` را صادر کنید.
سایر متغیرهای محیطی مفید در `setup.py` موجود است.

#### دریافت سورس PyTorch
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# اگر checkout قبلی دارید
git submodule sync
git submodule update --init --recursive
```

#### نصب وابستگی‌ها

**مشترک**

```bash
conda install cmake ninja
# پس از کلون سورس کد طبق بخش “دریافت سورس PyTorch” این دستور را اجرا کنید
pip install -r requirements.txt
```

**در لینوکس**

```bash
pip install mkl-static mkl-include
# فقط CUDA: اگر نیاز است پشتیبانی LAPACK برای GPU اضافه کنید
# نصب magma: این دستور را با محیط فعال conda و با تعیین نسخه CUDA اجرا کنید
.ci/docker/common/install_magma_conda.sh 12.4

# (اختیاری) اگر از torch.compile با inductor/triton استفاده می‌کنید، نسخه متناسب triton را نصب کنید
# از مسیر پوشه pytorch پس از کلون اجرا کنید
# برای پشتیبانی GPU اینتل، لطفا قبل از اجرا صراحتاً `export USE_XPU=1` را تنظیم کنید.
make triton
```

**در macOS**

```bash
# این بسته را فقط روی ماشین‌های پردازنده x86 اینتل اضافه کنید
pip install mkl-static mkl-include
# اگر torch.distributed نیاز است این بسته‌ها را اضافه کنید
conda install pkg-config libuv
```

**در ویندوز**

```bash
pip install mkl-static mkl-include
# اگر torch.distributed نیاز است این بسته‌ها را اضافه کنید.
# پشتیبانی بسته distributed در ویندوز ویژگی نمونه‌ای است و ممکن است تغییر کند.
conda install -c conda-forge libuv=1.39
```

#### نصب PyTorch
**در لینوکس**

اگر برای AMD ROCm کامپایل می‌کنید ابتدا این دستور را اجرا کنید:
```bash
# فقط اگر برای ROCm کامپایل می‌کنید اجرا کنید
python tools/amd_build/build_amd.py
```

نصب PyTorch
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**در macOS**

```bash
python3 setup.py develop
```

**در ویندوز**

اگر می‌خواهید کد پایتون قدیمی را کامپایل کنید، به [ساخت روی کد قدیمی و CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda) مراجعه کنید.

**ساخت فقط برای CPU**

در این حالت محاسبات PyTorch روی CPU اجرا می‌شود، نه روی GPU.

```cmd
python setup.py develop
```

نکته درباره OpenMP: پیاده‌سازی مورد نظر OpenMP، Intel OpenMP (iomp) است. برای لینک با iomp باید کتابخانه را به صورت دستی دانلود و محیط ساخت را با تغییر `CMAKE_INCLUDE_PATH` و `LIB` تنظیم کنید. دستورالعمل [اینجا](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) مثالی برای تنظیم هر دو MKL و Intel OpenMP است. بدون این تنظیمات، runtime پیش‌فرض Microsoft Visual C OpenMP (vcomp) استفاده خواهد شد.

**ساخت مبتنی بر CUDA**

در این حالت محاسبات PyTorch از GPU شما از طریق CUDA برای سرعت بیشتر استفاده می‌کند.

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) برای ساخت PyTorch با CUDA مورد نیاز است.
NVTX بخشی از بسته CUDA است و به نام "Nsight Compute" شناخته می‌شود. برای نصب آن روی CUDA نصب‌شده، نصب CUDA را مجدداً اجرا و چک‌باکس مربوطه را فعال کنید.
اطمینان حاصل کنید CUDA با Nsight Compute پس از Visual Studio نصب شده باشد.

در حال حاضر، VS 2017 / 2019 و Ninja به عنوان generator CMake پشتیبانی می‌شوند. اگر `ninja.exe` در `PATH` باشد، Ninja به عنوان generator پیش‌فرض استفاده می‌شود، در غیر این صورت VS 2017 / 2019.
<br/> اگر Ninja انتخاب شود، جدیدترین MSVC به عنوان toolchain زیرین انتخاب می‌شود.

کتابخانه‌های اضافی مانند
[Magma](https://developer.nvidia.com/magma)، [oneDNN، با نام MKLDNN یا DNNL](https://github.com/oneapi-src/oneDNN) و [Sccache](https://github.com/mozilla/sccache) اغلب نیاز هستند. لطفاً برای نصب آن‌ها به [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) مراجعه کنید.

می‌توانید برای پیکربندی متغیرهای محیطی دیگر به اسکریپت [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) مراجعه کنید.


```cmd
cmd

:: متغیرهای محیطی را پس از دانلود و استخراج بسته mkl تنظیم کنید،
:: در غیر این صورت CMake خطای `Could NOT find OpenMP` می‌دهد.
set CMAKE_INCLUDE_PATH={Your directory}\mkl\include
set LIB={Your directory}\mkl\lib;%LIB%

:: محتوای بخش قبلی را با دقت بخوانید قبل از ادامه.
:: [اختیاری] اگر می‌خواهید toolset زیرین Ninja و Visual Studio با CUDA را override کنید، اسکریپت زیر را اجرا کنید.
:: "Visual Studio 2019 Developer Command Prompt" به طور خودکار اجرا می‌شود.
:: اطمینان حاصل کنید CMake >= 3.12 را قبل از این کار دارید (در صورت استفاده از Visual Studio generator).
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [اختیاری] اگر می‌خواهید CUDA host compiler را override کنید
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**ساخت GPU اینتل**

در این حالت PyTorch با پشتیبانی GPU اینتل ساخته می‌شود.

لطفاً اطمینان حاصل کنید [پیش‌نیازهای مشترک](#پیش‌نیازها) و همچنین [پیش‌نیازهای GPU اینتل](#پشتیبانی-gpu-اینتل) به درستی نصب و متغیرهای محیطی قبل از شروع ساخت تنظیم شده باشند. برای پشتیبانی ابزار ساخت، `Visual Studio 2022` مورد نیاز است.

سپس می‌توانید PyTorch را با دستور زیر بسازید:

```cmd
:: دستورات CMD:
:: CMAKE_PREFIX_PATH را تنظیم کنید تا بسته‌های مربوطه پیدا شوند
:: %CONDA_PREFIX% فقط پس از `conda activate custom_env` کار می‌کند

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### تنظیم گزینه‌های ساخت (اختیاری)

می‌توانید پیکربندی متغیرهای cmake را به طور اختیاری (بدون ساخت اولیه) با انجام موارد زیر تنظیم کنید. برای مثال، تنظیم مسیرهای پیش‌فرض تشخیص داده شده برای CuDNN یا BLAS با این روش انجام می‌شود.

در لینوکس
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # یا cmake-gui build
```

در macOS
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # یا cmake-gui build
```

### ایمیج داکر

#### استفاده از ایمیج‌های آماده

همچنین می‌توانید یک ایمیج آماده داکر را از Docker Hub بکشید و با docker v19.03+ اجرا کنید

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

توجه داشته باشید که PyTorch برای اشتراک داده بین فرایندها از حافظه اشتراکی استفاده می‌کند، بنابراین اگر از multiprocessing در torch استفاده می‌شود (مانند بارگذاری داده چندریسمانی)، اندازه پیش‌فرض بخش حافظه اشتراکی کانتینر کافی نیست و باید اندازه حافظه اشتراکی را با گزینه‌های خط فرمان `--ipc=host` یا `--shm-size` برای `nvidia-docker run` افزایش دهید.

#### ساخت ایمیج به صورت دستی

**نکته:** باید با نسخه داکر بالاتر از ۱۸.۰۶ ساخته شود

`Dockerfile` برای ساخت ایمیج با پشتیبانی CUDA 11.1 و cuDNN v8 ارائه شده است.
می‌توانید متغیر PYTHON_VERSION=x.y را برای تعیین نسخه پایتون مورد استفاده Miniconda تعیین کنید، یا آن را خالی بگذارید تا مقدار پیش‌فرض استفاده شود.

```bash
make -f docker.Makefile
# ایمیج‌ها با docker.io/${your_docker_username}/pytorch تگ می‌شوند
```

همچنین می‌توانید متغیر محیطی `CMAKE_VARS="..."` را برای تعیین متغیرهای اضافی CMake به عنوان آرگومان‌های build به کار ببرید.
برای لیست متغیرهای موجود به [setup.py](./setup.py) مراجعه کنید.

```bash
make -f docker.Makefile
```

### ساخت مستندات

برای ساخت مستندات در قالب‌های مختلف به [Sphinx](http://www.sphinx-doc.org)
و پوسته pytorch_sphinx_theme2 نیاز دارید.

قبل از ساخت مستندات به صورت محلی، اطمینان حاصل کنید که `torch`
در محیط شما نصب است. برای اصلاحات جزئی می‌توانید نسخه nightly را طبق [شروع به کار](https://pytorch.org/get-started/locally/) نصب کنید.

برای اصلاحات پیچیده‌تر، مانند افزودن ماژول جدید و docstringهای آن، شاید نیاز باشد torch را [از سورس](#از-سورس) نصب کنید.
برای راهنمایی نگارش docstring به [Docstring Guidelines](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines) مراجعه کنید.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

برای دریافت لیست فرمت‌های خروجی موجود، دستور `make` را اجرا کنید.

اگر خطای katex دریافت کردید، `npm install katex` را اجرا کنید. اگر ادامه داشت،
`npm install -g katex` را امتحان کنید.

> [!نکته]
> اگر `nodejs` را با یک package manager دیگر (مثلاً
> `conda`) نصب کرده‌اید، احتمالاً `npm` نسخه‌ای از `katex` نصب می‌کند که با نسخه `nodejs` شما ناسازگار است و ساخت مستندات شکست می‌خورد.
> ترکیب نسخه‌هایی که کار می‌کند: `node@6.13.1` و
> `katex@0.13.18`. برای نصب دومی با `npm` اجرا کنید
> ```npm install -g katex@0.13.18```

> [!نکته]
> اگر خطای ناسازگاری numpy مشاهده کردید، اجرا کنید:
> ```
> pip install 'numpy<2'
> ```

زمانی که وابستگی‌های اجراشده توسط CI را تغییر می‌دهید، فایل
`.ci/docker/requirements-docs.txt` را ویرایش کنید.

#### ساخت PDF

برای کامپایل PDF از کل مستندات PyTorch، اطمینان حاصل کنید
`texlive` و LaTeX نصب است. در macOS، می‌توانید با دستور زیر نصب کنید:

```
brew install --cask mactex
```

برای ساخت PDF:

1. اجرا کنید:

   ```
   make latexpdf
   ```

   این کار فایل‌های لازم را در مسیر `build/latex` ایجاد می‌کند.

2. به این پوشه بروید و اجرا کنید:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   این کار یک فایل `pytorch.pdf` با محتوای مورد نظر ایجاد می‌کند. این دستور را یک بار دیگر اجرا کنید تا فهرست مطالب و نمایه به درستی تولید شود.

> [!نکته]
> برای مشاهده فهرست مطالب، در نمایشگر PDF به نمای **Table of Contents**
> بروید.

### نسخه‌های قبلی

دستورالعمل نصب و باینری‌های نسخه‌های قبلی PyTorch را می‌توانید
در [سایت ما](https://pytorch.org/get-started/previous-versions) بیابید.

## شروع به کار

سه راهنما برای شروع:
- [آموزش‌ها: برای شروع یادگیری و استفاده از PyTorch](https://pytorch.org/tutorials/)
- [مثال‌ها: کدهای ساده و قابل فهم PyTorch در همه حوزه‌ها](https://github.com/pytorch/examples)
- [مرجع API](https://pytorch.org/docs/)
- [واژه‌نامه](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## منابع

* [PyTorch.org](https://pytorch.org/)
* [آموزش‌های PyTorch](https://pytorch.org/tutorials/)
* [مثال‌های PyTorch](https://github.com/pytorch/examples)
* [مدل‌های PyTorch](https://pytorch.org/hub/)
* [مقدمه‌ای بر یادگیری عمیق با PyTorch از Udacity](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [مقدمه‌ای بر یادگیری ماشین با PyTorch از Udacity](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [شبکه‌های عصبی عمیق با PyTorch از Coursera](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch توییتر](https://twitter.com/PyTorch)
* [PyTorch بلاگ](https://pytorch.org/blog/)
* [PyTorch یوتیوب](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## ارتباطات
* انجمن‌ها: بحث درباره پیاده‌سازی‌ها، پژوهش و غیره https://discuss.pytorch.org
* مشکلات گیت‌هاب: گزارش باگ، درخواست ویژگی، مشکلات نصب، RFC، ایده‌ها و غیره.
* اسلک: [اسلک PyTorch](https://pytorch.slack.com/) میزبان کاربران و توسعه‌دهندگان متوسط تا حرفه‌ای برای گپ عمومی، بحث آنلاین، همکاری و غیره است. اگر مبتدی هستید و کمک می‌خواهید، انجمن اصلی [PyTorch Forums](https://discuss.pytorch.org) است. برای دعوت به اسلک، این فرم را پر کنید: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* خبرنامه: خبرنامه‌ای یک‌طرفه و بدون اسپم برای اطلاع‌رسانی‌های مهم PyTorch. ثبت‌نام: https://eepurl.com/cbG0rv
* صفحه فیسبوک: اطلاعیه‌های مهم درباره PyTorch. https://www.facebook.com/pytorch
* برای راهنمای برندینگ به سایت [pytorch.org](https://pytorch.org/) مراجعه کنید.

## انتشارها و مشارکت

معمولاً PyTorch سه انتشار جزئی در سال دارد. اگر باگی مشاهده کردید لطفاً با [ثبت issue](https://github.com/pytorch/pytorch/issues) ما را مطلع کنید.

از همه مشارکت‌ها استقبال می‌کنیم. اگر قصد دارید باگ‌فیکس ارسال کنید، لطفاً بدون نیاز به بحث بیشتر این کار را انجام دهید.

اگر قصد دارید ویژگی جدید، توابع کمکی یا گسترش برای هسته ارسال کنید، ابتدا issue باز کنید و درباره آن ویژگی با ما بحث کنید.
ارسال PR بدون بحث ممکن است به رد آن منجر شود چرا که شاید ما هسته را در جهتی متفاوت پیش می‌بریم.

برای اطلاعات بیشتر درباره مشارکت به [صفحه مشارکت](CONTRIBUTING.md) و برای اطلاعات درباره انتشارها به [صفحه انتشار](RELEASE.md) مراجعه کنید.

## تیم

PyTorch پروژه‌ای مبتنی بر جامعه با مشارکت چندین مهندس و پژوهشگر ماهر است.

PyTorch هم‌اکنون توسط [Soumith Chintala](http://soumith.ch)، [Gregory Chanan](https://github.com/gchanan)، [Dmytro Dzhulgakov](https://github.com/dzhulgakov)، [Edward Yang](https://github.com/ezyang) و [Nikita Shulga](https://github.com/malfet) نگهداری می‌شود و کمک‌های عمده از صدها نفر با استعداد در قالب‌ها و روش‌های مختلف صورت گرفته است.
لیست ناقص اما رو به رشدی از مشارکت‌کنندگان: [Trevor Killeen](https://github.com/killeent)، [Sasank Chilamkurthy](https://github.com/chsasank)، [Sergey Zagoruyko](https://github.com/szagoruyko)، [Adam Lerer](https://github.com/adamlerer)، [Francisco Massa](https://github.com/fmassa)، [Alykhan Tejani](https://github.com/alykhantejani)، [Luca Antiga](https://github.com/lantiga)، [Alban Desmaison](https://github.com/albanD)، [Andreas Koepf](https://github.com/andreaskoepf)، [James Bradbury](https://github.com/jekbradbury)، [Zeming Lin](https://github.com/ebetica)، [Yuandong Tian](https://github.com/yuandong-tian)، [Guillaume Lample](https://github.com/glample)، [Marat Dukhan](https://github.com/Maratyszcza)، [Natalia Gimelshein](https://github.com/ngimel)، [Christian Sarofeen](https://github.com/csarofeen)، [Martin Raison](https://github.com/martinraison)، [Edward Yang](https://github.com/ezyang)، [Zachary Devito](https://github.com/zdevito).

نکته: این پروژه هیچ ارتباطی با [hughperkins/pytorch](https://github.com/hughperkins/pytorch) با همین نام ندارد. Hugh از مشارکت‌کنندگان ارزشمند جامعه Torch است و در بسیاری از امور Torch و PyTorch کمک کرده است.

## مجوز

PyTorch دارای مجوز سبک BSD است که در فایل [LICENSE](LICENSE) آمده است.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---