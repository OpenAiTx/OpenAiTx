![شعار بايتورتش](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

بايتورتش هي حزمة بايثون توفر ميزتين عاليتي المستوى:
- حساب الموترات (مثل NumPy) مع تسريع قوي باستخدام وحدة معالجة الرسومات (GPU)
- الشبكات العصبية العميقة مبنية على نظام تفاضل تلقائي يعتمد على الشريط (Tape-based Autograd)

يمكنك إعادة استخدام حزم بايثون المفضلة لديك مثل NumPy وSciPy وCython لتوسيع بايتورتش عند الحاجة.

حالة التطوير المستمر (إشارات التكامل المستمر) يمكن العثور عليها على [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main).

<!-- toc -->

- [المزيد عن بايتورتش](#more-about-pytorch)
  - [مكتبة موترات جاهزة لـ GPU](#a-gpu-ready-tensor-library)
  - [الشبكات العصبية الديناميكية: تفاضل تلقائي معتمد على الشريط](#dynamic-neural-networks-tape-based-autograd)
  - [أولاً بايثون](#python-first)
  - [تجارب أمرية](#imperative-experiences)
  - [سريع وخفيف](#fast-and-lean)
  - [توسعات بدون عناء](#extensions-without-pain)
- [التثبيت](#installation)
  - [الحزم الجاهزة](#binaries)
    - [منصات NVIDIA Jetson](#nvidia-jetson-platforms)
  - [من المصدر](#from-source)
    - [المتطلبات الأساسية](#prerequisites)
      - [دعم NVIDIA CUDA](#nvidia-cuda-support)
      - [دعم AMD ROCm](#amd-rocm-support)
      - [دعم وحدة معالجة الرسومات من Intel](#intel-gpu-support)
    - [الحصول على مصدر بايتورتش](#get-the-pytorch-source)
    - [تثبيت التبعيات](#install-dependencies)
    - [تثبيت بايتورتش](#install-pytorch)
      - [ضبط خيارات البناء (اختياري)](#adjust-build-options-optional)
  - [صورة Docker](#docker-image)
    - [استخدام الصور الجاهزة](#using-pre-built-images)
    - [بناء الصورة بنفسك](#building-the-image-yourself)
  - [بناء التوثيق](#building-the-documentation)
    - [بناء PDF](#building-a-pdf)
  - [الإصدارات السابقة](#previous-versions)
- [البدء](#getting-started)
- [الموارد](#resources)
- [التواصل](#communication)
- [الإصدارات والمساهمة](#releases-and-contributing)
- [الفريق](#the-team)
- [الرخصة](#license)

<!-- tocstop -->

## المزيد عن بايتورتش

[تعلم أساسيات بايتورتش](https://pytorch.org/tutorials/beginner/basics/intro.html)

على مستوى دقيق، بايتورتش هو مكتبة تتكون من المكونات التالية:

| المكون | الوصف |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | مكتبة موترات مثل NumPy، مع دعم قوي لوحدة معالجة الرسومات (GPU) |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | مكتبة تفاضل تلقائي تعتمد على الشريط تدعم جميع العمليات القابلة للتفاضل على الموترات في torch |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | حزمة ترجمة (TorchScript) لإنشاء نماذج قابلة للتسلسل والتحسين من كود بايتورتش |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | مكتبة شبكات عصبية متكاملة بعمق مع autograd ومصممة لأقصى درجات المرونة |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | معالجة متعددة في بايثون، مع مشاركة سحرية للذاكرة الخاصة بموترات torch بين العمليات. مفيد لتحميل البيانات والتدريب بطريقة Hogwild |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader ووظائف مساعدة أخرى للراحة |

عادةً ما يُستخدم بايتورتش كالتالي:

- بديل لـ NumPy للاستفادة من قوة وحدات معالجة الرسومات.
- منصة بحث في التعلم العميق توفر أقصى قدر من المرونة والسرعة.

توضيح أكثر:

### مكتبة موترات جاهزة لـ GPU

إذا كنت تستخدم NumPy، إذًا أنت تستخدم الموترات (أو ما يُسمى ndarray).

![رسم توضيحي للموتر](./docs/source/_static/img/tensor_illustration.png)

يوفر بايتورتش موترات يمكن أن تتواجد إما على وحدة المعالجة المركزية (CPU) أو وحدة معالجة الرسومات (GPU) ويُسرّع العمليات الحسابية بشكل كبير.

نحن نوفر مجموعة واسعة من إجراءات الموترات لتسريع وتلبية احتياجاتك في الحساب العلمي مثل التقطيع والفهرسة والعمليات الرياضية والجبر الخطي والتقليصات.
وهي سريعة!

### الشبكات العصبية الديناميكية: تفاضل تلقائي معتمد على الشريط

يمتلك بايتورتش طريقة فريدة لبناء الشبكات العصبية: باستخدام وتشغيل مسجل شريط.

معظم الأطر مثل TensorFlow وTheano وCaffe وCNTK لديها نظرة ثابتة للعالم.
يجب بناء شبكة عصبية وإعادة استخدام نفس الهيكل مرارًا وتكرارًا.
تغيير سلوك الشبكة يعني أنه يجب البدء من الصفر.

مع بايتورتش، نستخدم تقنية تُسمى التفاضل التلقائي العكسي، والتي تسمح لك
بتغيير سلوك شبكتك بشكل عشوائي دون أي تأخير أو عبء. استوحينا ذلك
من عدة أوراق بحثية في هذا الموضوع، بالإضافة إلى أعمال حالية وسابقة مثل
[torch-autograd](https://github.com/twitter/torch-autograd)،
[autograd](https://github.com/HIPS/autograd)،
[Chainer](https://chainer.org)، وغيرها.

مع أن هذه التقنية ليست حصرية لبايتورتش، إلا أنها من أسرع التطبيقات لها حتى الآن.
تحصل على أفضل سرعة ومرونة لأبحاثك المتقدمة.

![رسم توضيحي للرسم البياني الديناميكي](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### أولاً بايثون

بايتورتش ليس مجرد ربط بايثون بإطار C++ ضخم.
بل بُني ليكون متكاملًا بعمق مع بايثون.
يمكنك استخدامه بشكل طبيعي كما تستخدم [NumPy](https://www.numpy.org/) أو [SciPy](https://www.scipy.org/) أو [scikit-learn](https://scikit-learn.org) وغيرها.
يمكنك كتابة طبقات الشبكة العصبية الجديدة الخاصة بك في بايثون نفسه، باستخدام مكتباتك المفضلة
واستخدام حزم مثل [Cython](https://cython.org/) و[Numba](http://numba.pydata.org/).
هدفنا ألا نعيد اختراع العجلة حيثما كان ذلك مناسبًا.

### تجارب أمرية

تم تصميم بايتورتش ليكون بديهيًا، وخطيًا في التفكير، وسهل الاستخدام.
عندما تنفذ سطرًا من الكود، يتم تنفيذه فورًا. لا توجد نظرة غير متزامنة للعالم.
عندما تدخل في مصحح الأخطاء أو تتلقى رسائل خطأ وتتبع مكدس، يكون فهمها مباشرًا.
يشير تتبع المكدس بالضبط إلى المكان الذي تم فيه تعريف كودك.
نأمل ألا تقضي ساعات طويلة في تصحيح الكود بسبب تتبع مكدس سيء أو محركات تنفيذ غير شفافة وغير متزامنة.

### سريع وخفيف

لدى بايتورتش عبء إطار عمل منخفض للغاية. نحن ندمج مكتبات التسريع
مثل [Intel MKL](https://software.intel.com/mkl) وNVIDIA ([cuDNN](https://developer.nvidia.com/cudnn)، [NCCL](https://developer.nvidia.com/nccl)) لتحقيق أقصى سرعة.
في الجوهر، تعتمد موترات CPU وGPU وواجهات الشبكات العصبية
على أكواد ناضجة ومجربة لسنوات.

لذا، بايتورتش سريع جدًا — سواءً كنت تشغل شبكات عصبية صغيرة أو كبيرة.

استهلاك الذاكرة في بايتورتش فعال للغاية مقارنة بـ Torch أو بعض البدائل الأخرى.
لقد كتبنا مخصصات ذاكرة مخصصة لـ GPU لضمان أن
نماذج التعلم العميق الخاصة بك فعالة إلى أقصى حد في استهلاك الذاكرة.
هذا يمكّنك من تدريب نماذج تعلم عميق أكبر من ذي قبل.

### توسعات بدون عناء

كتابة وحدات شبكات عصبية جديدة، أو التعامل مع واجهة برمجة تطبيقات موترات بايتورتش تم تصميمها لتكون مباشرة
وبأقل قدر من التجريدات.

يمكنك كتابة طبقات الشبكة العصبية الجديدة في بايثون باستخدام واجهة torch
[أو مكتباتك المفضلة المعتمدة على NumPy مثل SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html).

إذا رغبت في كتابة طبقاتك بـ C/C++، نوفر واجهة توسعة سهلة الاستخدام وفعالة وبأقل متطلبات كود.
لا حاجة لكتابة كود تغليف. يمكنك مشاهدة [دليل هنا](https://pytorch.org/tutorials/advanced/cpp_extension.html) و[مثال هنا](https://github.com/pytorch/extension-cpp).


## التثبيت

### الحزم الجاهزة
أوامر تثبيت الحزم الجاهزة عبر Conda أو pip متوفرة على موقعنا: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)


#### منصات NVIDIA Jetson

عجلات بايثون لمنصات Jetson Nano وJetson TX1/TX2 وJetson Xavier NX/AGX وJetson AGX Orin من NVIDIA متوفرة [هنا](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) وحاوية L4T منشورة [هنا](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)

تتطلب JetPack 4.2 وما فوق، ويتم صيانتها من قبل [@dusty-nv](https://github.com/dusty-nv) و[@ptrblck](https://github.com/ptrblck).


### من المصدر

#### المتطلبات الأساسية
إذا كنت تقوم بالتثبيت من المصدر، ستحتاج إلى:
- بايثون 3.9 أو أحدث
- مترجم يدعم C++17 بالكامل، مثل clang أو gcc (يتطلب gcc 9.4.0 أو أحدث على لينكس)
- Visual Studio أو Visual Studio Build Tool (للويندوز فقط)

\* يستخدم بايتورتش CI أدوات بناء Visual C++، والتي تأتي مع إصدارات Visual Studio Enterprise أو Professional أو Community. يمكنك أيضًا تثبيت أدوات البناء من
https://visualstudio.microsoft.com/visual-cpp-build-tools/. أدوات البناء *لا تأتي*
افتراضيًا مع Visual Studio Code.

مثال على إعداد البيئة موضح أدناه:

* لينكس:

```bash
$ source <CONDA_INSTALL_DIR>/bin/activate
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
```

* ويندوز:

```bash
$ source <CONDA_INSTALL_DIR>\Scripts\activate.bat
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
$ call "C:\Program Files\Microsoft Visual Studio\<VERSION>\Community\VC\Auxiliary\Build\vcvarsall.bat" x64
```

##### دعم NVIDIA CUDA
إذا كنت ترغب في الترجمة مع دعم CUDA، [اختر إصدارًا مدعومًا من CUDA من جدول الدعم لدينا](https://pytorch.org/get-started/locally/)، ثم قم بتثبيت التالي:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 أو أحدث
- [مترجم](https://gist.github.com/ax3l/9489132) متوافق مع CUDA

ملاحظة: يمكنك الرجوع إلى [جدول دعم cuDNN](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) لإصدارات cuDNN مع CUDA المدعومة وبرامج تشغيل CUDA وأجهزة NVIDIA المختلفة.

إذا كنت ترغب في تعطيل دعم CUDA، صدّر متغير البيئة `USE_CUDA=0`.
قد تجد متغيرات بيئة أخرى مفيدة في `setup.py`.

إذا كنت تبني لمنصات NVIDIA Jetson (Jetson Nano, TX1, TX2, AGX Xavier)، تعليمات تثبيت بايتورتش لـ Jetson Nano متوفرة [هنا](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### دعم AMD ROCm
إذا كنت ترغب في الترجمة مع دعم ROCm، قم بتثبيت:
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 أو أحدث
- ROCm مدعوم حاليًا فقط على أنظمة لينكس.

يفترض نظام البناء افتراضيًا أن ROCm مثبت في `/opt/rocm`. إذا كان ROCm مثبتًا في مجلد مختلف، يجب تعيين متغير البيئة `ROCM_PATH` إلى مجلد التثبيت. يكتشف نظام البناء تلقائيًا معمارية GPU من AMD. اختياريًا، يمكن ضبط معمارية AMD GPU بشكل صريح باستخدام متغير البيئة `PYTORCH_ROCM_ARCH` [معمارية AMD GPU](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

إذا كنت ترغب في تعطيل دعم ROCm، صدّر متغير البيئة `USE_ROCM=0`.
قد تجد متغيرات بيئة أخرى مفيدة في `setup.py`.

##### دعم وحدة معالجة الرسومات من Intel
إذا كنت ترغب في الترجمة مع دعم وحدة معالجة الرسومات من Intel، اتبع التالي:
- [متطلبات بايتورتش لوحدات معالجة الرسومات من Intel](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html).
- وحدة معالجة الرسومات من Intel مدعومة على لينكس وويندوز.

إذا كنت ترغب في تعطيل دعم وحدة معالجة الرسومات من Intel، صدّر متغير البيئة `USE_XPU=0`.
قد تجد متغيرات بيئة أخرى مفيدة في `setup.py`.

#### الحصول على مصدر بايتورتش
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# إذا كنت تحدث نسخة موجودة بالفعل
git submodule sync
git submodule update --init --recursive
```

#### تثبيت التبعيات

**مشترك**

```bash
conda install cmake ninja
# شغل هذا الأمر من مجلد بايتورتش بعد استنساخ الكود المصدر من قسم "الحصول على مصدر بايتورتش" بالأعلى
pip install -r requirements.txt
```

**على لينكس**

```bash
pip install mkl-static mkl-include
# CUDA فقط: أضف دعم LAPACK لـ GPU إذا لزم الأمر
# تثبيت magma: شغل مع تفعيل بيئة conda. حدد إصدار CUDA للتثبيت
.ci/docker/common/install_magma_conda.sh 12.4

# (اختياري) إذا كنت تستخدم torch.compile مع inductor/triton، ثبت النسخة المطابقة من triton
# شغل من مجلد pytorch بعد الاستنساخ
# لدعم وحدة معالجة الرسومات من Intel، يرجى تصدير `USE_XPU=1` صراحة قبل تنفيذ الأمر.
make triton
```

**على macOS**

```bash
# أضف هذه الحزمة فقط على أجهزة المعالج intel x86
pip install mkl-static mkl-include
# أضف هذه الحزم إذا كنت بحاجة إلى torch.distributed
conda install pkg-config libuv
```

**على ويندوز**

```bash
pip install mkl-static mkl-include
# أضف هذه الحزم إذا كنت بحاجة إلى torch.distributed.
# دعم الحزمة الموزعة على ويندوز ميزة تجريبية وقابلة للتغيير.
conda install -c conda-forge libuv=1.39
```

#### تثبيت بايتورتش
**على لينكس**

إذا كنت تترجم لـ AMD ROCm فعليك أولاً تشغيل هذا الأمر:
```bash
# شغل هذا فقط إذا كنت تترجم لـ ROCm
python tools/amd_build/build_amd.py
```

تثبيت بايتورتش
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**على macOS**

```bash
python3 setup.py develop
```

**على ويندوز**

إذا كنت ترغب في بناء كود بايثون قديم، يرجى الرجوع إلى [البناء على الكود القديم وCUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**بناء باستخدام CPU فقط**

في هذا الوضع ستعمل حسابات بايتورتش على وحدة المعالجة المركزية فقط، وليس وحدة معالجة الرسومات.

```cmd
python setup.py develop
```

ملاحظة حول OpenMP: التطبيق المطلوب لـ OpenMP هو Intel OpenMP (iomp). للربط مع iomp، ستحتاج إلى تحميل المكتبة يدويًا وضبط بيئة البناء عن طريق تعديل `CMAKE_INCLUDE_PATH` و`LIB`. التعليمات [هنا](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) مثال لإعداد كل من MKL وIntel OpenMP. بدون هذه الإعدادات لـ CMake، سيتم استخدام Microsoft Visual C OpenMP runtime (vcomp).

**بناء باستخدام CUDA**

في هذا الوضع ستستفيد حسابات بايتورتش من وحدة معالجة الرسومات عبر CUDA لزيادة سرعة العمليات الحسابية.

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) مطلوب لبناء بايتورتش مع CUDA.
NVTX جزء من توزيعة CUDA، حيث يسمى "Nsight Compute". لتثبيته على CUDA المثبت بالفعل، أعد تشغيل التثبيت وحدد المربع المناسب.
تأكد من أن CUDA مع Nsight Compute مثبّت بعد Visual Studio.

حاليًا، VS 2017 / 2019 وNinja مدعومون كمولدات لـ CMake. إذا تم اكتشاف `ninja.exe` في `PATH`، سيتم استخدام Ninja كمولد افتراضي، وإلا سيتم استخدام VS 2017/2019.
<br/> إذا تم اختيار Ninja كمولد، سيتم اختيار أحدث MSVC كأداة أساسية.

مكتبات إضافية مثل
[Magma](https://developer.nvidia.com/magma)، [oneDNN، المعروف أيضًا باسم MKLDNN أو DNNL](https://github.com/oneapi-src/oneDNN)، و[Sccache](https://github.com/mozilla/sccache) غالبًا ما تكون مطلوبة. يرجى الرجوع إلى [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) لتثبيتها.

يمكنك الرجوع إلى سكربت [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) لبعض إعدادات متغيرات البيئة الأخرى.


```cmd
cmd

:: اضبط متغيرات البيئة بعد تحميل وفك ضغط حزمة mkl،
:: وإلا سيرمي CMake خطأ "Could NOT find OpenMP".
set CMAKE_INCLUDE_PATH={Your directory}\mkl\include
set LIB={Your directory}\mkl\lib;%LIB%

:: اقرأ محتوى القسم السابق بعناية قبل المتابعة.
:: [اختياري] إذا رغبت في تجاوز أداة البناء الأساسية المستخدمة بواسطة Ninja وVisual Studio مع CUDA، شغل السكربت التالي.
:: سيتم تشغيل "Visual Studio 2019 Developer Command Prompt" تلقائيًا.
:: تأكد من وجود CMake >= 3.12 قبل ذلك إذا كنت تستخدم مولد Visual Studio.
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [اختياري] إذا رغبت في تجاوز مترجم مضيف CUDA
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**بناء لوحدة معالجة الرسومات من Intel**

في هذا الوضع سيتم بناء بايتورتش مع دعم وحدة معالجة الرسومات من Intel.

يرجى التأكد من أن [المتطلبات الأساسية المشتركة](#prerequisites) وكذلك [متطلبات وحدة معالجة الرسومات من Intel](#intel-gpu-support) مثبّتة بشكل صحيح ومتغيرات البيئة مضبوطة قبل بدء البناء. لدعم أدوات البناء، يتطلب `Visual Studio 2022`.

بعدها يمكن بناء بايتورتش بالأمر التالي:

```cmd
:: أوامر CMD:
:: اضبط CMAKE_PREFIX_PATH للمساعدة في العثور على الحزم المناسبة
:: %CONDA_PREFIX% يعمل فقط بعد تنفيذ `conda activate custom_env`

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### ضبط خيارات البناء (اختياري)

يمكنك ضبط إعدادات متغيرات cmake بشكل اختياري (دون البناء أولاً)، من خلال التالي. مثلًا، يمكن ضبط مجلدات cuDNN أو BLAS المكتشفة مسبقًا بهذه الخطوة.

على لينكس
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # أو cmake-gui build
```

على macOS
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # أو cmake-gui build
```

### صورة Docker

#### استخدام الصور الجاهزة

يمكنك أيضًا سحب صورة Docker جاهزة من Docker Hub وتشغيلها مع docker v19.03+

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

يرجى ملاحظة أن بايتورتش يستخدم الذاكرة المشتركة لمشاركة البيانات بين العمليات، لذا إذا تم استخدام torch multiprocessing (مثلاً
لمحمل البيانات متعدد الخيوط) فإن حجم مقطع الذاكرة المشتركة الافتراضي الذي تعمل به الحاوية غير كافٍ، ويجب عليك
زيادة حجم الذاكرة المشتركة إما باستخدام `--ipc=host` أو خيار السطر `--shm-size` مع `nvidia-docker run`.

#### بناء الصورة بنفسك

**ملاحظة:** يجب أن يتم البناء مع نسخة Docker > 18.06

يتم توفير ملف `Dockerfile` لبناء الصور مع دعم CUDA 11.1 وcuDNN v8.
يمكنك تمرير متغير make باسم `PYTHON_VERSION=x.y` لتحديد إصدار بايثون الذي سيستخدمه Miniconda، أو اتركه بدون تعيين لاستخدام الافتراضي.

```bash
make -f docker.Makefile
# الصور موسومة كـ docker.io/${your_docker_username}/pytorch
```

يمكنك أيضًا تمرير متغير البيئة `CMAKE_VARS="..."` لتحديد متغيرات CMake إضافية أثناء البناء.
انظر [setup.py](./setup.py) لقائمة المتغيرات المتاحة.

```bash
make -f docker.Makefile
```

### بناء التوثيق

لبناء التوثيق بصيغ مختلفة، ستحتاج إلى [Sphinx](http://www.sphinx-doc.org)
وthème pytorch_sphinx_theme2.

قبل بناء التوثيق محليًا، تأكد من تثبيت `torch`
في بيئتك. للتعديلات الصغيرة، يمكنك تثبيت
الإصدار الليلي كما هو موضح في [البدء](https://pytorch.org/get-started/locally/).

للتعديلات الأكبر، مثل إضافة وحدة جديدة وسلاسل توثيق للوحدة الجديدة، قد تحتاج إلى تثبيت torch [من المصدر](#from-source).
انظر [إرشادات السلاسل التوضيحية](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)
للتعرف على معايير السلاسل التوضيحية.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

شغّل `make` للحصول على قائمة بجميع صيغ الإخراج المتاحة.

إذا حصلت على خطأ katex شغّل `npm install katex`. إذا استمر الخطأ، جرب
`npm install -g katex`

> [!ملاحظة]
> إذا قمت بتثبيت `nodejs` بواسطة مدير حزم مختلف (مثلاً،
> `conda`) فربما سيقوم `npm` بتثبيت نسخة من `katex` غير متوافقة
> مع إصدار `nodejs` الخاص بك وسيفشل بناء التوثيق.
> مجموعة إصدارات معروفة بأنها تعمل هي `node@6.13.1` و
> `katex@0.13.18`. لتثبيت الأخيرة مع `npm` يمكنك تشغيل
> ```npm install -g katex@0.13.18```

> [!ملاحظة]
> إذا رأيت خطأ عدم توافق numpy، شغّل:
> ```
> pip install 'numpy<2'
> ```

عند إجراء تغييرات على التبعيات المستخدمة في CI، عدل ملف
`.ci/docker/requirements-docs.txt`.

#### بناء PDF

لإنشاء PDF لجميع توثيقات بايتورتش، تأكد من تثبيت
`texlive` وLaTeX. على macOS، يمكنك تثبيتها باستخدام:

```
brew install --cask mactex
```

لإنشاء PDF:

1. شغّل:

   ```
   make latexpdf
   ```

   هذا سينشئ الملفات اللازمة في مجلد `build/latex`.

2. انتقل إلى هذا المجلد ونفذ:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   هذا سينتج `pytorch.pdf` بالمحتوى المطلوب. شغّل هذا
   الأمر مرة أخرى ليتم إنشاء جدول المحتويات والفهرس بشكل صحيح.

> [!ملاحظة]
> لعرض جدول المحتويات، انتقل إلى **Table of Contents**
> في عارض PDF الخاص بك.


### الإصدارات السابقة

تعليمات التثبيت والحزم للإصدارات السابقة من بايتورتش يمكن العثور عليها
على [موقعنا](https://pytorch.org/get-started/previous-versions).


## البدء

ثلاثة مصادر للبدء:
- [الدروس: لتبدأ بفهم واستخدام بايتورتش](https://pytorch.org/tutorials/)
- [الأمثلة: كود بايتورتش سهل الفهم لجميع المجالات](https://github.com/pytorch/examples)
- [مرجع واجهة البرمجة API](https://pytorch.org/docs/)
- [المصطلحات](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## الموارد

* [PyTorch.org](https://pytorch.org/)
* [دروس بايتورتش](https://pytorch.org/tutorials/)
* [أمثلة بايتورتش](https://github.com/pytorch/examples)
* [نماذج بايتورتش](https://pytorch.org/hub/)
* [مقدمة في التعلم العميق مع بايتورتش من Udacity](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [مقدمة في تعلم الآلة مع بايتورتش من Udacity](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [الشبكات العصبية العميقة مع بايتورتش من Coursera](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [تويتر بايتورتش](https://twitter.com/PyTorch)
* [مدونة بايتورتش](https://pytorch.org/blog/)
* [قناة بايتورتش على يوتيوب](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## التواصل
* المنتديات: مناقشة التطبيقات والبحث وغيره https://discuss.pytorch.org
* قضايا GitHub: تقارير الأخطاء، طلبات الميزات، مشكلات التثبيت، RFCs، الأفكار، إلخ.
* Slack: قناة [PyTorch Slack](https://pytorch.slack.com/) تستضيف جمهورًا أساسيًا من مستخدمي ومطوري بايتورتش المتوسطين إلى المتقدمين للدردشة العامة والمناقشات والتعاون. إذا كنت مبتدئًا وتبحث عن مساعدة، الوسيلة الرئيسية هي [منتديات بايتورتش](https://discuss.pytorch.org). إذا كنت بحاجة لدعوة Slack، يرجى تعبئة هذا النموذج: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* النشرة البريدية: بريد إلكتروني من جهة واحدة مع إعلانات مهمة عن بايتورتش. يمكنك الاشتراك هنا: https://eepurl.com/cbG0rv
* صفحة فيسبوك: إعلانات مهمة عن بايتورتش. https://www.facebook.com/pytorch
* لإرشادات العلامة التجارية، يرجى زيارة موقعنا على [pytorch.org](https://pytorch.org/)

## الإصدارات والمساهمة

عادةً ما يصدر بايتورتش ثلاث إصدارات فرعية سنويًا. يرجى إبلاغنا إذا واجهت خطأ عبر [فتح قضية](https://github.com/pytorch/pytorch/issues).

نحن نقدّر جميع المساهمات. إذا كنت تخطط للمساهمة بإصلاحات للأخطاء، يرجى القيام بذلك دون أي نقاش إضافي.

إذا كنت تخطط للمساهمة بميزات جديدة أو وظائف مساعدة أو توسعات للنواة، يرجى أولاً فتح قضية ومناقشة الميزة معنا.
إرسال PR بدون نقاش قد يؤدي إلى رفضه لأننا قد نأخذ النواة في اتجاه مختلف عما تعلمه.

لمعرفة المزيد حول المساهمة في بايتورتش، يرجى زيارة [صفحة المساهمة](CONTRIBUTING.md). لمزيد من المعلومات حول إصدارات بايتورتش، انظر [صفحة الإصدارات](RELEASE.md).

## الفريق

بايتورتش مشروع مدفوع من المجتمع مع العديد من المهندسين والباحثين المهرة يساهمون فيه.

يتم صيانة بايتورتش حاليًا من قبل [Soumith Chintala](http://soumith.ch)، [Gregory Chanan](https://github.com/gchanan)، [Dmytro Dzhulgakov](https://github.com/dzhulgakov)، [Edward Yang](https://github.com/ezyang)، و[Nikita Shulga](https://github.com/malfet) مع مساهمات رئيسية من مئات الأفراد الموهوبين بأشكال ووسائل مختلفة.
قائمة غير شاملة ولكنها تنمو باستمرار يجب أن تذكر: [Trevor Killeen](https://github.com/killeent)، [Sasank Chilamkurthy](https://github.com/chsasank)، [Sergey Zagoruyko](https://github.com/szagoruyko)، [Adam Lerer](https://github.com/adamlerer)، [Francisco Massa](https://github.com/fmassa)، [Alykhan Tejani](https://github.com/alykhantejani)، [Luca Antiga](https://github.com/lantiga)، [Alban Desmaison](https://github.com/albanD)، [Andreas Koepf](https://github.com/andreaskoepf)، [James Bradbury](https://github.com/jekbradbury)، [Zeming Lin](https://github.com/ebetica)، [Yuandong Tian](https://github.com/yuandong-tian)، [Guillaume Lample](https://github.com/glample)، [Marat Dukhan](https://github.com/Maratyszcza)، [Natalia Gimelshein](https://github.com/ngimel)، [Christian Sarofeen](https://github.com/csarofeen)، [Martin Raison](https://github.com/martinraison)، [Edward Yang](https://github.com/ezyang)، [Zachary Devito](https://github.com/zdevito).

ملاحظة: هذا المشروع غير مرتبط بـ [hughperkins/pytorch](https://github.com/hughperkins/pytorch) الذي يحمل نفس الاسم. Hugh هو مساهم قيّم في مجتمع Torch وساعد في العديد من الأمور الخاصة بـ Torch وPyTorch.

## الرخصة

بايتورتش تحت رخصة BSD، كما هو موضح في ملف [LICENSE](LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---