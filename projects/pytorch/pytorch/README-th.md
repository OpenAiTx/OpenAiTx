![PyTorch Logo](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch คือแพ็คเกจ Python ที่ให้ฟีเจอร์ระดับสูงสองอย่าง:
- การคำนวณเทนเซอร์ (เหมือน NumPy) พร้อมการเร่งความเร็วโดย GPU อย่างมีประสิทธิภาพ
- เครือข่ายประสาทเทียมเชิงลึกที่สร้างบนระบบ autograd แบบเทป

คุณสามารถนำแพ็คเกจ Python ที่คุณชื่นชอบ เช่น NumPy, SciPy และ Cython มาใช้ขยาย PyTorch ได้เมื่อต้องการ

สุขภาพของ trunk (สัญญาณ Continuous Integration) สามารถดูได้ที่ [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main).

<!-- toc -->

- [ข้อมูลเพิ่มเติมเกี่ยวกับ PyTorch](#more-about-pytorch)
  - [ไลบรารีเทนเซอร์ที่พร้อมใช้งานกับ GPU](#a-gpu-ready-tensor-library)
  - [เครือข่ายประสาทเทียมแบบไดนามิก: Tape-Based Autograd](#dynamic-neural-networks-tape-based-autograd)
  - [Python มาก่อน](#python-first)
  - [ประสบการณ์แบบ Imperative](#imperative-experiences)
  - [รวดเร็วและประหยัด](#fast-and-lean)
  - [ขยายต่อได้ง่ายดาย](#extensions-without-pain)
- [การติดตั้ง](#installation)
  - [ไบนารี](#binaries)
    - [แพลตฟอร์ม NVIDIA Jetson](#nvidia-jetson-platforms)
  - [จากซอร์สโค้ด](#from-source)
    - [ข้อกำหนดเบื้องต้น](#prerequisites)
      - [รองรับ NVIDIA CUDA](#nvidia-cuda-support)
      - [รองรับ AMD ROCm](#amd-rocm-support)
      - [รองรับ Intel GPU](#intel-gpu-support)
    - [รับซอร์สของ PyTorch](#get-the-pytorch-source)
    - [ติดตั้ง dependencies](#install-dependencies)
    - [ติดตั้ง PyTorch](#install-pytorch)
      - [ปรับตัวเลือกการ build (ไม่บังคับ)](#adjust-build-options-optional)
  - [Docker Image](#docker-image)
    - [ใช้งานอิมเมจที่ build ไว้แล้ว](#using-pre-built-images)
    - [สร้างอิมเมจด้วยตนเอง](#building-the-image-yourself)
  - [สร้างเอกสารประกอบ](#building-the-documentation)
    - [สร้าง PDF](#building-a-pdf)
  - [เวอร์ชันก่อนหน้า](#previous-versions)
- [เริ่มต้นใช้งาน](#getting-started)
- [แหล่งข้อมูล](#resources)
- [การสื่อสาร](#communication)
- [การออกเวอร์ชันและการมีส่วนร่วม](#releases-and-contributing)
- [ทีมงาน](#the-team)
- [สัญญาอนุญาต](#license)

<!-- tocstop -->

## ข้อมูลเพิ่มเติมเกี่ยวกับ PyTorch

[เรียนรู้พื้นฐานของ PyTorch](https://pytorch.org/tutorials/beginner/basics/intro.html)

ในรายละเอียด PyTorch คือไลบรารีที่ประกอบด้วยส่วนประกอบต่อไปนี้:

| ส่วนประกอบ | คำอธิบาย |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | ไลบรารีเทนเซอร์เหมือน NumPy พร้อมรองรับ GPU อย่างมีประสิทธิภาพ |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | ไลบรารี differentiation อัตโนมัติแบบเทปที่รองรับทุก operation ของ Tensor ที่สามารถ differentiable ใน torch |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | สแตกการ compile (TorchScript) เพื่อสร้างโมเดลที่ serialize และ optimize ได้จากโค้ด PyTorch  |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | ไลบรารี neural network ที่ผสานกับ autograd อย่างลึกซึ้ง ออกแบบมาเพื่อความยืดหยุ่นสูงสุด |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | multiprocessing ของ Python แต่สามารถแชร์หน่วยความจำของ torch Tensor ระหว่าง process ได้ เหมาะสำหรับ data loading และการฝึก Hogwild |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader และฟังก์ชันอำนวยความสะดวกอื่น ๆ |

โดยปกติแล้ว PyTorch จะถูกใช้งานเป็น:

- ตัวแทน NumPy เพื่อใช้ประโยชน์จากพลังของ GPU
- แพลตฟอร์มวิจัย deep learning ที่ให้ความยืดหยุ่นและความเร็วสูงสุด

รายละเอียดเพิ่มเติม:

### ไลบรารีเทนเซอร์ที่พร้อมใช้งานกับ GPU

ถ้าคุณเคยใช้ NumPy แสดงว่าคุณเคยใช้ Tensor (หรือ ndarray) มาแล้ว

![Tensor illustration](./docs/source/_static/img/tensor_illustration.png)

PyTorch มี Tensor ที่สามารถอยู่ทั้งใน CPU หรือ GPU และช่วยเร่งการคำนวณได้อย่างมาก

เรามีฟังก์ชัน tensor หลากหลายสำหรับการคำนวณทางวิทยาศาสตร์ของคุณ เช่น slicing, indexing, การคำนวณทางคณิตศาสตร์, พีชคณิตเชิงเส้น, การลดค่า ฯลฯ และรวดเร็วมาก!

### เครือข่ายประสาทเทียมแบบไดนามิก: Tape-Based Autograd

PyTorch มีวิธีสร้าง neural network ที่ไม่เหมือนใคร: โดยใช้และเล่นซ้ำเหมือนเทปบันทึกเสียง

เฟรมเวิร์กส่วนใหญ่ เช่น TensorFlow, Theano, Caffe และ CNTK จะมีมุมมองแบบ static คุณต้องสร้างโครงสร้าง neural network และใช้ซ้ำแบบเดิมไปเรื่อย ๆ การเปลี่ยนแปลงพฤติกรรมของ network หมายถึงการเริ่มใหม่ตั้งแต่ต้น

ใน PyTorch เราใช้เทคนิคที่เรียกว่า reverse-mode auto-differentiation ซึ่งช่วยให้คุณเปลี่ยนพฤติกรรมของ network ได้อย่างอิสระโดยไม่มีความล่าช้าหรือ overhead แรงบันดาลใจมาจากงานวิจัยหลายฉบับ รวมถึงงานในอดีตและปัจจุบัน เช่น
[torch-autograd](https://github.com/twitter/torch-autograd),
[autograd](https://github.com/HIPS/autograd),
[Chainer](https://chainer.org) ฯลฯ

แม้เทคนิคนี้จะไม่ใช่เอกลักษณ์ของ PyTorch แต่ก็เป็นหนึ่งใน implementation ที่เร็วที่สุดในปัจจุบัน คุณจะได้ทั้งความเร็วและความยืดหยุ่นสำหรับงานวิจัยที่ซับซ้อนของคุณ

![Dynamic graph](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python มาก่อน

PyTorch ไม่ใช่ Python binding สำหรับ C++ framework ขนาดใหญ่
แต่มันถูกสร้างขึ้นมาเพื่อผสานกับ Python อย่างลึกซึ้ง
คุณสามารถใช้งานได้เหมือน [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) ฯลฯ
คุณสามารถเขียนเลเยอร์ใหม่ของ neural network ใน Python ได้เอง ใช้ไลบรารีโปรดของคุณ
และใช้แพ็คเกจอย่าง [Cython](https://cython.org/) และ [Numba](http://numba.pydata.org/)
เป้าหมายของเราคือไม่ reinvent the wheel เมื่อไม่จำเป็น

### ประสบการณ์แบบ Imperative

PyTorch ถูกออกแบบมาให้ใช้งานง่าย เข้าใจตรงไปตรงมา และใช้งานสะดวก
เมื่อคุณรันโค้ด 1 บรรทัด มันจะถูกรันทันที ไม่มีการ asynchronous
เมื่อคุณ debug หรือเจอ error/stack trace คุณจะเข้าใจได้ง่าย
Stack trace จะชี้ไปยังที่มาของโค้ดโดยตรง
เราหวังว่าคุณจะไม่ต้องเสียเวลานานในการ debug เพราะ stack trace ที่เข้าใจยากหรือ execution engine ที่ซับซ้อน

### รวดเร็วและประหยัด

PyTorch มี overhead ของ framework น้อยมาก เราได้ผสาน acceleration libraries
เช่น [Intel MKL](https://software.intel.com/mkl) และ NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)) เพื่อความเร็วสูงสุด
แกนหลักของมัน ทั้ง Tensor และ neural network backend ของ CPU/GPU
มีความสมบูรณ์และผ่านการทดสอบมาหลายปี

ดังนั้น PyTorch จึงเร็วมาก ไม่ว่าคุณจะรัน neural network ขนาดเล็กหรือใหญ่

การใช้หน่วยความจำของ PyTorch มีประสิทธิภาพสูงมาก เมื่อเทียบกับ Torch หรือทางเลือกอื่น ๆ
เราได้เขียน memory allocator สำหรับ GPU ขึ้นมาเองเพื่อให้แน่ใจว่า
โมเดล deep learning ของคุณใช้หน่วยความจำอย่างคุ้มค่าสูงสุด
สิ่งนี้ทำให้คุณสามารถฝึกโมเดล deep learning ขนาดใหญ่กว่าเดิมได้

### ขยายต่อได้ง่ายดาย

การเขียนโมดูล neural network ใหม่ หรือเชื่อมต่อกับ Tensor API ของ PyTorch ถูกออกแบบมาให้ตรงไปตรงมา
และมี abstraction น้อยที่สุด

คุณสามารถเขียนเลเยอร์ neural network ใหม่ใน Python โดยใช้ torch API
[หรือไลบรารีที่ใช้ NumPy อย่าง SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html) ได้

หากคุณอยากเขียนเลเยอร์ใน C/C++ เราก็มี extension API ที่สะดวกและมี boilerplate น้อยมาก
ไม่จำเป็นต้องเขียนโค้ด wrapper ดู [ตัวอย่างการใช้งาน](https://pytorch.org/tutorials/advanced/cpp_extension.html) และ [โค้ดตัวอย่าง](https://github.com/pytorch/extension-cpp)


## การติดตั้ง

### ไบนารี
คำสั่งสำหรับติดตั้งไบนารีผ่าน Conda หรือ pip wheels อยู่ในเว็บไซต์ของเรา: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)

#### แพลตฟอร์ม NVIDIA Jetson

Python wheels สำหรับ Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX และ Jetson AGX Orin มีให้ที่ [ที่นี่](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) และ L4T container เผยแพร่ที่ [ที่นี่](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)

ต้องการ JetPack 4.2 ขึ้นไป และ [@dusty-nv](https://github.com/dusty-nv) กับ [@ptrblck](https://github.com/ptrblck) เป็นผู้ดูแล

### จากซอร์สโค้ด

#### ข้อกำหนดเบื้องต้น
ถ้าคุณจะติดตั้งจากซอร์สโค้ด คุณจะต้องมี:
- Python 3.9 หรือใหม่กว่า
- คอมไพเลอร์ที่รองรับ C++17 อย่างสมบูรณ์ เช่น clang หรือ gcc (ต้องการ gcc 9.4.0 หรือใหม่กว่า บน Linux)
- Visual Studio หรือ Visual Studio Build Tool (Windows เท่านั้น)

\* PyTorch CI ใช้ Visual C++ BuildTools ซึ่งมาพร้อมกับ Visual Studio Enterprise,
Professional, หรือ Community Editions หรือดาวน์โหลดได้จาก
https://visualstudio.microsoft.com/visual-cpp-build-tools/ Build tools *ไม่มี* ใน Visual Studio Code โดยปริยาย

ตัวอย่างการตั้งค่าสภาพแวดล้อมด้านล่าง:

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

##### รองรับ NVIDIA CUDA
หากต้องการ compile ให้รองรับ CUDA [เลือกเวอร์ชัน CUDA ที่รองรับจาก matrix ของเรา](https://pytorch.org/get-started/locally/) แล้วติดตั้ง:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 ขึ้นไป
- [Compiler](https://gist.github.com/ax3l/9489132) ที่รองรับ CUDA

หมายเหตุ: สามารถดู [cuDNN Support Matrix](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) สำหรับเวอร์ชัน cuDNN ที่รองรับ CUDA, CUDA driver และฮาร์ดแวร์ NVIDIA ได้

หากต้องการปิดการรองรับ CUDA ให้ export ตัวแปรแวดล้อม `USE_CUDA=0`
ตัวแปรแวดล้อมอื่น ๆ ดูได้ใน `setup.py`

หาก build สำหรับ NVIDIA Jetson (Jetson Nano, TX1, TX2, AGX Xavier) อ่านวิธีติดตั้ง PyTorch สำหรับ Jetson Nano ได้ที่ [ที่นี่](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### รองรับ AMD ROCm
หากต้องการ compile ให้รองรับ ROCm ให้ติดตั้ง
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 ขึ้นไป
- ROCm รองรับเฉพาะระบบ Linux

โดยปกติระบบ build จะมองว่า ROCm อยู่ที่ `/opt/rocm` หากอยู่ที่อื่นให้ตั้งค่า `ROCM_PATH` ชี้ไปยังที่ติดตั้ง ROCm ระบบจะตรวจสอบสถาปัตยกรรม GPU อัตโนมัติ หรือจะตั้งค่า `PYTORCH_ROCM_ARCH` เพื่อเลือกสถาปัตยกรรม GPU เองได้ [ดูข้อมูล](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

หากต้องการปิดการรองรับ ROCm ให้ export ตัวแปรแวดล้อม `USE_ROCM=0`
ตัวแปรแวดล้อมอื่น ๆ ดูได้ใน `setup.py`

##### รองรับ Intel GPU
หากต้องการ compile ให้รองรับ Intel GPU ให้ทำตาม
- [PyTorch Prerequisites for Intel GPUs](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html)
- Intel GPU รองรับทั้ง Linux และ Windows

หากต้องการปิดการรองรับ Intel GPU ให้ export ตัวแปรแวดล้อม `USE_XPU=0`
ตัวแปรแวดล้อมอื่น ๆ ดูได้ใน `setup.py`

#### รับซอร์สของ PyTorch
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# หากอัปเดต checkout ที่มีอยู่แล้ว
git submodule sync
git submodule update --init --recursive
```

#### ติดตั้ง dependencies

**ทั่วไป**

```bash
conda install cmake ninja
# รันคำสั่งนี้จากไดเรกทอรี PyTorch หลังจาก clone ซอร์สโค้ดตามหัวข้อ “Get the PyTorch Source” ข้างบน
pip install -r requirements.txt
```

**บน Linux**

```bash
pip install mkl-static mkl-include
# CUDA เท่านั้น: เพิ่ม LAPACK สำหรับ GPU หากจำเป็น
# การติดตั้ง magma: รันใน conda environment ที่ activate แล้ว ระบุเวอร์ชัน CUDA ที่จะติดตั้ง
.ci/docker/common/install_magma_conda.sh 12.4

# (เลือกได้) ถ้าใช้ torch.compile กับ inductor/triton ติดตั้ง triton เวอร์ชันที่ตรงกัน
# รันจากไดเรกทอรี pytorch หลังจาก clone แล้ว
# หากรองรับ Intel GPU กรุณา `export USE_XPU=1` ก่อนรันคำสั่งนี้
make triton
```

**บน MacOS**

```bash
# ติดตั้งแพ็คเกจนี้บนเครื่องที่ใช้ intel x86 processor เท่านั้น
pip install mkl-static mkl-include
# ติดตั้งแพ็คเกจเหล่านี้หากต้องการใช้ torch.distributed
conda install pkg-config libuv
```

**บน Windows**

```bash
pip install mkl-static mkl-include
# ติดตั้งแพ็คเกจเหล่านี้หากต้องการใช้ torch.distributed
# Distributed package บน Windows เป็นฟีเจอร์ทดลองและอาจเปลี่ยนแปลงได้
conda install -c conda-forge libuv=1.39
```

#### ติดตั้ง PyTorch
**บน Linux**

หาก compile สำหรับ AMD ROCm ให้รันคำสั่งนี้ก่อน:
```bash
# รันเฉพาะกรณี compile สำหรับ ROCm เท่านั้น
python tools/amd_build/build_amd.py
```

ติดตั้ง PyTorch
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**บน macOS**

```bash
python3 setup.py develop
```

**บน Windows**

ถ้าต้องการ build legacy python code โปรดดู [Building on legacy code and CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**Build แบบ CPU เท่านั้น**

โหมดนี้ PyTorch จะคำนวณโดยใช้ CPU ไม่ใช่ GPU

```cmd
python setup.py develop
```

หมายเหตุเกี่ยวกับ OpenMP: Implementation ที่ต้องการคือ Intel OpenMP (iomp) หากต้องการ link กับ iomp คุณต้องดาวน์โหลด library เองและตั้งค่าสภาพแวดล้อมโดยปรับ `CMAKE_INCLUDE_PATH` และ `LIB` ดูตัวอย่างการตั้งค่าทั้ง MKL และ Intel OpenMP [ได้ที่นี่](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) หากไม่ตั้งค่า CMake จะใช้ Microsoft Visual C OpenMP runtime (vcomp)

**Build แบบใช้ CUDA**

โหมดนี้ PyTorch จะคำนวณบน GPU ผ่าน CUDA เพื่อความเร็ว

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) จำเป็นสำหรับ build PyTorch กับ CUDA
NVTX เป็นส่วนหนึ่งของ CUDA ที่เรียกว่า "Nsight Compute" ติดตั้งโดยรันตัวติดตั้ง CUDA อีกครั้งแล้วเลือก checkbox ที่เกี่ยวข้อง
ตรวจสอบให้แน่ใจว่า CUDA กับ Nsight Compute ถูกติดตั้งหลัง Visual Studio

ขณะนี้ VS 2017 / 2019 และ Ninja รองรับเป็น generator ของ CMake หากพบ `ninja.exe` ใน `PATH` จะใช้ Ninja เป็น generator โดยอัตโนมัติ มิฉะนั้นจะใช้ VS 2017 / 2019
<br/> หากเลือก Ninja เป็น generator จะใช้ MSVC ล่าสุดเป็น toolchain ด้านล่าง

ต้องติดตั้งไลบรารีเพิ่มเติมเช่น
[Magma](https://developer.nvidia.com/magma), [oneDNN หรือ MKLDNN/DNNL](https://github.com/oneapi-src/oneDNN), และ [Sccache](https://github.com/mozilla/sccache) ดู [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) เพื่อดูวิธีติดตั้ง

ดูตัวอย่างการตั้งค่าตัวแปรแวดล้อมใน [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat)

```cmd
cmd

:: ตั้งค่าตัวแปรหลังจากดาวน์โหลดและแตกไฟล์ mkl แล้ว
:: ไม่เช่นนั้น CMake จะ error ว่า `Could NOT find OpenMP`
set CMAKE_INCLUDE_PATH={Your directory}\mkl\include
set LIB={Your directory}\mkl\lib;%LIB%

:: อ่านรายละเอียดข้างบนให้ดีก่อนดำเนินการ
:: [ไม่บังคับ] หากต้องการ override toolset ของ Ninja และ Visual Studio กับ CUDA ให้รันบล็อกนี้
:: จะรัน "Visual Studio 2019 Developer Command Prompt" ให้อัตโนมัติ
:: ตรวจสอบให้แน่ใจว่า CMake >= 3.12 เมื่อใช้ Visual Studio generator
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [ไม่บังคับ] หากต้องการ override CUDA host compiler
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Build Intel GPU**

โหมดนี้จะ build PyTorch พร้อมรองรับ Intel GPU

โปรดตรวจสอบให้แน่ใจว่า [ข้อกำหนดทั่วไป](#prerequisites) และ [ข้อกำหนดสำหรับ Intel GPU](#intel-gpu-support) ได้รับการติดตั้งและตั้งค่าสภาพแวดล้อมแล้วก่อนเริ่ม build สำหรับ build tool ต้องใช้ `Visual Studio 2022`

จากนั้นสามารถ build PyTorch ด้วยคำสั่ง:

```cmd
:: คำสั่ง CMD:
:: ตั้งค่า CMAKE_PREFIX_PATH เพื่อค้นหาแพ็คเกจที่เกี่ยวข้อง
:: %CONDA_PREFIX% ใช้งานได้หลัง `conda activate custom_env`

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### ปรับตัวเลือกการ build (ไม่บังคับ)

คุณสามารถปรับค่า cmake variables ได้ (โดยไม่ต้อง build ก่อน) เช่น ปรับ directory ของ CuDNN หรือ BLAS

บน Linux
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # หรือ cmake-gui build
```

บน macOS
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # หรือ cmake-gui build
```

### Docker Image

#### ใช้งานอิมเมจที่ build ไว้แล้ว

คุณสามารถดึง docker image ที่ build ไว้แล้วจาก Docker Hub และรันกับ docker v19.03+

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

โปรดทราบว่า PyTorch ใช้ shared memory เพื่อแชร์ข้อมูลระหว่าง process ดังนั้นถ้าใช้ torch multiprocessing (เช่น data loader แบบ multithreaded) ขนาด shared memory ปริยายใน container จะไม่พอ ควรเพิ่มขนาด shared memory ด้วย `--ipc=host` หรือ `--shm-size` ในคำสั่ง `nvidia-docker run`

#### สร้างอิมเมจด้วยตนเอง

**หมายเหตุ:** ต้องใช้ docker เวอร์ชัน > 18.06

`Dockerfile` ที่ให้มาสำหรับ build image ที่รองรับ CUDA 11.1 และ cuDNN v8
คุณสามารถส่งตัวแปร `PYTHON_VERSION=x.y` ให้ make เพื่อกำหนดเวอร์ชัน Python หรือไม่ระบุก็จะใช้ค่าเริ่มต้น

```bash
make -f docker.Makefile
# images จะถูก tag เป็น docker.io/${your_docker_username}/pytorch
```

สามารถระบุตัวแปร CMake เพิ่มเติมโดยใช้ `CMAKE_VARS="..."` เพื่อส่งค่าไปยัง CMake ระหว่าง build
ดู [setup.py](./setup.py) สำหรับตัวแปรที่มี

```bash
make -f docker.Makefile
```

### สร้างเอกสารประกอบ

เพื่อ build เอกสารในหลายรูปแบบ คุณจะต้องมี [Sphinx](http://www.sphinx-doc.org)
และ pytorch_sphinx_theme2

ก่อน build เอกสารในเครื่อง ให้แน่ใจว่า `torch` ถูกติดตั้งใน environment แล้ว สำหรับการแก้ไขเล็ก ๆ สามารถติดตั้ง nightly version ตาม [Getting Started](https://pytorch.org/get-started/locally/)

สำหรับการแก้ไขที่ซับซ้อน เช่น การเพิ่มโมดูลใหม่และ docstring อาจต้องติดตั้ง torch [จากซอร์ส](#from-source)
ดู [Docstring Guidelines](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines) สำหรับแนวทาง docstring

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

รัน `make` เพื่อดูรายการรูปแบบ output ทั้งหมด

ถ้าเจอ katex error ให้รัน `npm install katex` ถ้ายังไม่หาย ให้ลอง
`npm install -g katex`

> [!หมายเหตุ]
> หากติดตั้ง `nodejs` ด้วย package manager อื่น (เช่น
> `conda`) `npm` อาจติดตั้งเวอร์ชัน `katex` ที่ไม่ compatible กับ `nodejs` และ build เอกสารจะล้มเหลว
> เวอร์ชันที่ยืนยันว่าใช้ได้คือ `node@6.13.1` และ
> `katex@0.13.18` ติดตั้ง katex ด้วย `npm` โดยรัน
> ```npm install -g katex@0.13.18```

> [!หมายเหตุ]
> หากเจอ numpy incompatibility error ให้รัน:
> ```
> pip install 'numpy<2'
> ```

เมื่อแก้ไข dependencies ที่ CI ใช้งาน ให้แก้ไขไฟล์
`.ci/docker/requirements-docs.txt`

#### สร้าง PDF

เพื่อ compile PDF ของเอกสาร PyTorch ทั้งหมด ต้องติดตั้ง
`texlive` และ LaTeX บน macOS ติดตั้งได้ด้วย:

```
brew install --cask mactex
```

เพื่อสร้าง PDF:

1. รัน:

   ```
   make latexpdf
   ```

   ไฟล์จะถูกสร้างในไดเรกทอรี `build/latex`

2. เข้าไปที่ไดเรกทอรีนี้แล้วรัน:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   จะได้ไฟล์ `pytorch.pdf` พร้อมเนื้อหาที่ต้องการ รันคำสั่งนี้ซ้ำอีกครั้งเพื่อให้สร้างสารบัญและดัชนีที่ถูกต้อง

> [!หมายเหตุ]
> หากต้องการดูสารบัญ ให้เปลี่ยนไปใช้ **Table of Contents**
> ในโปรแกรมอ่าน PDF ของคุณ

### เวอร์ชันก่อนหน้า

คำแนะนำการติดตั้งและไบนารีของ PyTorch เวอร์ชันก่อนหน้าสามารถดูได้ที่
[เว็บไซต์ของเรา](https://pytorch.org/get-started/previous-versions)

## เริ่มต้นใช้งาน

สามแหล่งข้อมูลสำหรับการเริ่มต้น:
- [บทเรียน: เริ่มต้นเรียนรู้และใช้งาน PyTorch](https://pytorch.org/tutorials/)
- [ตัวอย่าง: โค้ด PyTorch เข้าใจง่ายสำหรับทุกโดเมน](https://github.com/pytorch/examples)
- [เอกสาร API](https://pytorch.org/docs/)
- [Glossary](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## แหล่งข้อมูล

* [PyTorch.org](https://pytorch.org/)
* [PyTorch Tutorials](https://pytorch.org/tutorials/)
* [PyTorch Examples](https://github.com/pytorch/examples)
* [PyTorch Models](https://pytorch.org/hub/)
* [Intro to Deep Learning with PyTorch จาก Udacity](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Intro to Machine Learning with PyTorch จาก Udacity](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Deep Neural Networks with PyTorch จาก Coursera](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [PyTorch Blog](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## การสื่อสาร
* ฟอรัม: พูดคุยเกี่ยวกับการ implement, งานวิจัย ฯลฯ https://discuss.pytorch.org
* GitHub Issues: รายงานบั๊ก, ขอฟีเจอร์, ปัญหาการติดตั้ง, RFC, ความคิดเห็น ฯลฯ
* Slack: [PyTorch Slack](https://pytorch.slack.com/) มีผู้ใช้และนักพัฒนา PyTorch ระดับกลางถึงสูง สำหรับแชท, ถกปัญหา, ทำงานร่วมกัน ฯลฯ หากคุณเป็นมือใหม่ให้ใช้ [PyTorch Forums](https://discuss.pytorch.org) หากต้องการ invite Slack กรุณากรอกแบบฟอร์มนี้: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* จดหมายข่าว: อีเมลประกาศสำคัญเกี่ยวกับ PyTorch สมัครได้ที่: https://eepurl.com/cbG0rv
* Facebook Page: ข่าวสารสำคัญเกี่ยวกับ PyTorch https://www.facebook.com/pytorch
* สำหรับแนวทางการใช้แบรนด์ กรุณาดูที่ [pytorch.org](https://pytorch.org/)

## การออกเวอร์ชันและการมีส่วนร่วม

โดยปกติ PyTorch จะมี minor release ปีละ 3 ครั้ง หากคุณพบข้อผิดพลาดโปรด [แจ้ง issue](https://github.com/pytorch/pytorch/issues)

เราขอขอบคุณทุกการมีส่วนร่วม หากคุณจะช่วยแก้บั๊กสามารถส่ง pull request ได้เลยโดยไม่ต้องพูดคุยเพิ่มเติม

หากคุณจะเพิ่มฟีเจอร์ใหม่, utility function, หรือ extension ให้กับ core กรุณาเปิด issue และพูดคุยกับทีมเราก่อน ส่ง PR มาโดยไม่พูดคุยอาจถูกปฏิเสธ เพราะเราอาจมีทิศทางของ core ที่ต่างจากที่คุณคิด

ศึกษาวิธีมีส่วนร่วมกับ Pytorch เพิ่มเติมได้ที่ [หน้า Contribution](CONTRIBUTING.md) ข้อมูลเกี่ยวกับ release ดูที่ [Release page](RELEASE.md)

## ทีมงาน

PyTorch เป็นโครงการที่ขับเคลื่อนโดยชุมชน มีวิศวกรและนักวิจัยที่มีความสามารถจำนวนมากร่วมพัฒนา

ปัจจุบัน PyTorch ดูแลโดย [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang), และ [Nikita Shulga](https://github.com/malfet) โดยมีผู้ร่วมสมทบหลักจากบุคคลมากมายในหลากหลายรูปแบบ
รายชื่อที่ไม่ครบถ้วนแต่เพิ่มขึ้นเรื่อย ๆ ได้แก่: [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito).

หมายเหตุ: โปรเจกต์นี้ไม่เกี่ยวข้องกับ [hughperkins/pytorch](https://github.com/hughperkins/pytorch) ที่ชื่อเหมือนกัน Hugh เป็นผู้ร่วมสมทบที่มีคุณค่าของชุมชน Torch และช่วยเหลือ Torch และ PyTorch ในหลายส่วน

## สัญญาอนุญาต

PyTorch ใช้สัญญาอนุญาตแบบ BSD ตามที่พบในไฟล์ [LICENSE](LICENSE)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---