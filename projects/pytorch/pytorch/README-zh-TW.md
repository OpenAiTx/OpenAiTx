![PyTorch Logo](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch 是一個 Python 套件，提供兩個高階功能：
- 張量運算（類似 NumPy），具有強大的 GPU 加速能力
- 基於 tape-based 自動微分系統構建的深度神經網路

你可以在需要時重複利用你喜愛的 Python 套件，如 NumPy、SciPy 和 Cython 來擴展 PyTorch。

我們的主幹健康狀態（持續整合訊號）可在 [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main) 查詢。

<!-- toc -->

- [更多關於 PyTorch](#more-about-pytorch)
  - [支援 GPU 的張量函式庫](#a-gpu-ready-tensor-library)
  - [動態神經網路：基於 Tape 的自動微分](#dynamic-neural-networks-tape-based-autograd)
  - [以 Python 為核心](#python-first)
  - [命令式體驗](#imperative-experiences)
  - [快速精簡](#fast-and-lean)
  - [輕鬆擴充](#extensions-without-pain)
- [安裝](#installation)
  - [二進位檔](#binaries)
    - [NVIDIA Jetson 平台](#nvidia-jetson-platforms)
  - [由原始碼安裝](#from-source)
    - [先決條件](#prerequisites)
      - [NVIDIA CUDA 支援](#nvidia-cuda-support)
      - [AMD ROCm 支援](#amd-rocm-support)
      - [Intel GPU 支援](#intel-gpu-support)
    - [取得 PyTorch 原始碼](#get-the-pytorch-source)
    - [安裝相依套件](#install-dependencies)
    - [安裝 PyTorch](#install-pytorch)
      - [調整編譯選項（可選）](#adjust-build-options-optional)
  - [Docker 映像檔](#docker-image)
    - [使用預建映像檔](#using-pre-built-images)
    - [自行構建映像檔](#building-the-image-yourself)
  - [構建文件](#building-the-documentation)
    - [產生 PDF](#building-a-pdf)
  - [舊版本](#previous-versions)
- [快速入門](#getting-started)
- [資源](#resources)
- [溝通](#communication)
- [發佈與貢獻](#releases-and-contributing)
- [開發團隊](#the-team)
- [授權](#license)

<!-- tocstop -->

## 更多關於 PyTorch

[學習 PyTorch 的基礎知識](https://pytorch.org/tutorials/beginner/basics/intro.html)

從細節來看，PyTorch 是一個包含以下元件的函式庫：

| 元件 | 說明 |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | 類似 NumPy 的張量庫，具備強大的 GPU 支援 |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | 基於 tape 的自動微分函式庫，支援 torch 中所有可微分的張量操作 |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | 編譯堆疊（TorchScript），可從 PyTorch 程式碼創建可序列化、可優化的模型 |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | 深度整合自動微分的神經網路函式庫，設計上極具彈性 |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Python 多進程，但能神奇地在進程間共享 torch 張量記憶體。適用於資料加載和 Hogwild 訓練 |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader 及其他方便的實用功能 |

通常，PyTorch 可用於：

- 作為 NumPy 的替代品，發揮 GPU 的運算能力。
- 作為深度學習研究平台，提供最大彈性與速度。

進一步說明：

### 支援 GPU 的張量函式庫

如果你用過 NumPy，就用過張量（即 ndarray）。

![Tensor illustration](./docs/source/_static/img/tensor_illustration.png)

PyTorch 提供可在 CPU 或 GPU 上運作的張量，大幅加速運算。

我們提供各種張量操作例程，滿足你的科學運算需求，如切片、索引、數學運算、線性代數、縮減等，
而且速度很快！

### 動態神經網路：基於 Tape 的自動微分

PyTorch 具有獨特的神經網路構建方式：使用並重播錄音帶。

大多數框架如 TensorFlow、Theano、Caffe 和 CNTK 都是靜態世界觀。
必須構建一個神經網路並反覆使用相同結構。
若要改變網路行為，必須從頭開始。

在 PyTorch 中，我們採用一種稱為反向模式自動微分的技術，讓你可以隨意改變網路行為，且無延遲或額外負擔。
我們的靈感來自多篇相關研究論文，以及 [torch-autograd](https://github.com/twitter/torch-autograd)、[autograd](https://github.com/HIPS/autograd)、[Chainer](https://chainer.org) 等目前和過去的工作。

雖然這種技術並非 PyTorch 所獨有，但 PyTorch 是目前最快的實作之一。
你能同時獲得速度與彈性，適合大膽的研究探索。

![Dynamic graph](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### 以 Python 為核心

PyTorch 不是將 Python 綁定到龐大的 C++ 框架。
它設計上與 Python 深度整合。
你可以像使用 [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) 那樣自然地使用它。
你可直接在 Python 中撰寫新神經網路層，結合你喜愛的函式庫，並利用 [Cython](https://cython.org/) 和 [Numba](http://numba.pydata.org/) 等套件。
我們的目標是在合適的地方不重造輪子。

### 命令式體驗

PyTorch 設計直觀、思路線性且易於使用。
你執行哪一行程式，哪一行就會被執行。沒有非同步的世界觀。
當你進入除錯器或收到錯誤訊息和堆疊追蹤時，理解起來很直接。
堆疊追蹤會指出你程式碼定義的確切位置。
我們希望你永遠不必因為糟糕的堆疊追蹤或非同步、晦澀的執行引擎而花數小時除錯。

### 快速精簡

PyTorch 框架開銷極小。我們整合了加速函式庫，如 [Intel MKL](https://software.intel.com/mkl) 和 NVIDIA（[cuDNN](https://developer.nvidia.com/cudnn)、[NCCL](https://developer.nvidia.com/nccl)），以極大化速度。
其 CPU 與 GPU 張量及神經網路後端已成熟，並經多年測試。

因此，無論你運行大網路還是小網路，PyTorch 都非常快。

PyTorch 在記憶體使用上比 Torch 或其他替代方案更有效率。
我們為 GPU 撰寫了自訂記憶體配置器，確保你的深度學習模型最大化記憶體效率。
這讓你能訓練更大的深度學習模型。

### 輕鬆擴充

撰寫新神經網路模組，或與 PyTorch 的張量 API 介接，設計上都很直接，抽象層極少。

你可以直接用 torch API 在 Python 中撰寫新神經網路層，
[或你熟悉的基於 NumPy 的函式庫如 SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html)。

若你想用 C/C++ 撰寫新層，我們也提供高效、極少樣板碼的擴充 API。
無需額外包裝程式碼。你可以參考[這裡的教學](https://pytorch.org/tutorials/advanced/cpp_extension.html)和[這裡的範例](https://github.com/pytorch/extension-cpp)。

## 安裝

### 二進位檔
透過 Conda 或 pip 安裝二進位檔的指令，請參見我們的網站：[https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)

#### NVIDIA Jetson 平台

NVIDIA Jetson Nano、Jetson TX1/TX2、Jetson Xavier NX/AGX、Jetson AGX Orin 的 Python 安裝檔提供於[此處](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048)，L4T 容器則發佈於[此處](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)

它們需要 JetPack 4.2 及以上版本，由 [@dusty-nv](https://github.com/dusty-nv) 和 [@ptrblck](https://github.com/ptrblck) 維護。

### 由原始碼安裝

#### 先決條件
若你要從原始碼安裝，需準備：
- Python 3.9 或更高版本
- 完全支援 C++17 的編譯器，如 clang 或 gcc（Linux 上需 gcc 9.4.0 或以上）
- Visual Studio 或 Visual Studio Build Tool（僅限 Windows）

\* PyTorch CI 使用 Visual C++ BuildTools，這些隨 Visual Studio Enterprise、Professional 或 Community 版提供。你也可從 https://visualstudio.microsoft.com/visual-cpp-build-tools/ 安裝建構工具。預設情況下，這些建構工具*不會*隨 Visual Studio Code 提供。

環境設置範例如下：

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

##### NVIDIA CUDA 支援
若要支援 CUDA，[請由支援矩陣選擇合適版本的 CUDA](https://pytorch.org/get-started/locally/)，然後安裝下列項目：
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 或以上
- [與 CUDA 相容的編譯器](https://gist.github.com/ax3l/9489132)

註：你可參考 [cuDNN 支援矩陣](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html)，了解 cuDNN 與各種 CUDA、CUDA 驅動及 NVIDIA 硬體的對應版本。

若要關閉 CUDA 支援，請設定環境變數 `USE_CUDA=0`。
其他有用的環境變數可於 `setup.py` 查找。

若你在為 NVIDIA Jetson 平台（Jetson Nano、TX1、TX2、AGX Xavier）建構，Jetson Nano 的安裝指南可參考[這裡](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### AMD ROCm 支援
若要支援 ROCm，請安裝：
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 及以上版本
- ROCm 目前僅支援 Linux 系統。

預設建構系統會假設 ROCm 安裝於 `/opt/rocm`。若安裝於其他目錄，需設定 `ROCM_PATH` 環境變數指向該安裝目錄。建構系統會自動偵測 AMD GPU 架構。也可選擇以 `PYTORCH_ROCM_ARCH` 環境變數顯式指定 [AMD GPU 架構](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)。

若要關閉 ROCm 支援，請設定環境變數 `USE_ROCM=0`。
其他有用的環境變數可於 `setup.py` 查找。

##### Intel GPU 支援
若要支援 Intel GPU，請依照下列
- [Intel GPU 的 PyTorch 先決條件](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html) 說明操作。
- Intel GPU 支援 Linux 與 Windows。

若要關閉 Intel GPU 支援，請設定環境變數 `USE_XPU=0`。
其他有用的環境變數可於 `setup.py` 查找。

#### 取得 PyTorch 原始碼
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# 若為現有檢出進行更新
git submodule sync
git submodule update --init --recursive
```

#### 安裝相依套件

**共用**

```bash
conda install cmake ninja
# 請在從原始碼下載的 PyTorch 目錄下執行
pip install -r requirements.txt
```

**Linux 上**

```bash
pip install mkl-static mkl-include
# 僅 CUDA：如需為 GPU 加入 LAPACK 支援
# 安裝 magma：需在已啟用 conda 環境下，指定 CUDA 版本
.ci/docker/common/install_magma_conda.sh 12.4

# （可選）若使用 torch.compile 搭配 inductor/triton，請安裝相符版本的 triton
# 請在 pytorch 目錄下執行
# 若支援 Intel GPU，請在執行前明確 `export USE_XPU=1`
make triton
```

**MacOS 上**

```bash
# 僅於 intel x86 處理器機器需加裝此套件
pip install mkl-static mkl-include
# 若需 torch.distributed，請加裝以下套件
conda install pkg-config libuv
```

**Windows 上**

```bash
pip install mkl-static mkl-include
# 若需 torch.distributed，請加裝以下套件
# Windows 上的 distributed package 支援屬原型功能，隨時可能變動
conda install -c conda-forge libuv=1.39
```

#### 安裝 PyTorch
**Linux 上**

若為 AMD ROCm 編譯，先執行：
```bash
# 僅 ROCm 編譯需執行
python tools/amd_build/build_amd.py
```

安裝 PyTorch
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**macOS 上**

```bash
python3 setup.py develop
```

**Windows 上**

若要建構 legacy python 程式碼，請參考 [Building on legacy code and CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**僅 CPU 編譯**

此模式下，PyTorch 運算僅於 CPU 執行，不使用 GPU。

```cmd
python setup.py develop
```

關於 OpenMP：建議使用 Intel OpenMP（iomp）。要連結 iomp，需手動下載函式庫並透過調整 `CMAKE_INCLUDE_PATH` 和 `LIB` 設定建構環境。相關設定說明可參考[這裡](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source)（同時設置 MKL 與 Intel OpenMP）。若未配置，則預設會用 Microsoft Visual C OpenMP 執行階段（vcomp）。

**CUDA 編譯**

此模式下，PyTorch 運算將利用 GPU 的 CUDA 加速。

[Pytorch with CUDA 需 NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm)。
NVTX 為 CUDA 發行包的一部分，稱為 "Nsight Compute"。若 CUDA 已安裝，需再次執行安裝並勾選相關選項。
確保 CUDA 及 Nsight Compute 安裝於 Visual Studio 之後。

目前 VS 2017 / 2019 與 Ninja 可作為 CMake 產生器。若 `PATH` 中偵測到 `ninja.exe`，預設會用 Ninja，否則用 VS 2017 / 2019。
<br/> 若選用 Ninja，則會自動選擇最新 MSVC 做為底層工具鏈。

常用額外函式庫如
[Magma](https://developer.nvidia.com/magma)、[oneDNN, 又稱 MKLDNN 或 DNNL](https://github.com/oneapi-src/oneDNN)、[Sccache](https://github.com/mozilla/sccache) 等，請參考 [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) 安裝。

更多環境變數設定可參考 [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) 腳本。

```cmd
cmd

:: 下載並解壓 mkl 套件後，設定環境變數，否則 CMake 會報錯 `Could NOT find OpenMP`
set CMAKE_INCLUDE_PATH={Your directory}\mkl\include
set LIB={Your directory}\mkl\lib;%LIB%

:: 請仔細閱讀上述內容再繼續
:: [可選] 若要覆蓋 Ninja 與 Visual Studio 所用底層工具鏈，請執行下列指令
:: "Visual Studio 2019 Developer Command Prompt" 會自動開啟。
:: 若用 Visual Studio 產生器，請確保 CMake >= 3.12
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [可選] 若要覆蓋 CUDA 主機編譯器
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Intel GPU 編譯**

此模式下將建構支援 Intel GPU 的 PyTorch。

請確保[共用先決條件](#prerequisites)及[Intel GPU 先決條件](#intel-gpu-support)皆已安裝且環境變數正確設置。建構工具需使用 `Visual Studio 2022`。

然後執行下列指令建構 PyTorch：

```cmd
:: CMD 指令：
:: 設定 CMAKE_PREFIX_PATH 以協助尋找對應套件
:: %CONDA_PREFIX% 僅在 `conda activate custom_env` 後有效

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### 調整編譯選項（可選）

你可以選擇性先調整 cmake 變數配置（不需立即編譯），例如調整 CuDNN 或 BLAS 的預設目錄。

Linux 上
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # 或 cmake-gui build
```

macOS 上
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # 或 cmake-gui build
```

### Docker 映像檔

#### 使用預建映像檔

你也可以直接由 Docker Hub 下載預建映像檔，需 Docker v19.03+：

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

請注意，PyTorch 會用 shared memory 在進程間共享資料，因此若用到 torch 多進程（如多執行緒資料加載器），預設 shared memory segment 大小不夠，需用 `--ipc=host` 或 `--shm-size` 參數提升 shared memory 大小。

#### 自行構建映像檔

**注意：** 需 Docker 版本 > 18.06

`Dockerfile` 提供支援 CUDA 11.1 及 cuDNN v8 的映像構建。
你可透過 `PYTHON_VERSION=x.y` 指定 Miniconda 使用的 Python 版本，未指定則用預設值。

```bash
make -f docker.Makefile
# 映像檔標記為 docker.io/${your_docker_username}/pytorch
```

你也可透過 `CMAKE_VARS="..."` 環境變數，指定其他 CMake 參數給 CMake。
可參閱 [setup.py](./setup.py) 了解可用變數。

```bash
make -f docker.Makefile
```

### 構建文件

若要以各種格式構建文件，你需要 [Sphinx](http://www.sphinx-doc.org) 及 pytorch_sphinx_theme2。

本地構建文件前，請確保已安裝 `torch`。若僅需小修正，可依 [快速入門](https://pytorch.org/get-started/locally/) 安裝 nightly 版。

如需複雜修正（如新增模組及其 docstring），可能需[從原始碼安裝 torch](#from-source)。
docstring 撰寫請參考 [Docstring Guidelines](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)。

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

執行 `make` 可列出所有可用輸出格式。

若遇到 katex 錯誤，請執行 `npm install katex`。若仍有問題，試試
`npm install -g katex`

> [!NOTE]
> 若你用其他套件管理器（如 `conda`）安裝 `nodejs`，則 `npm` 可能會安裝與你 nodejs 版本不相容的 `katex`，導致文件建構失敗。
> 已知可用組合為 `node@6.13.1` 與 `katex@0.13.18`。安裝方式如下：
> ```npm install -g katex@0.13.18```

> [!NOTE]
> 若遇到 numpy 相容性錯誤，請執行：
> ```
> pip install 'numpy<2'
> ```

如你有更改 CI 執行的相依套件，請編輯
`.ci/docker/requirements-docs.txt` 文件。

#### 產生 PDF

要編譯所有 PyTorch 文件為 PDF，需先安裝 `texlive` 與 LaTeX。macOS 可用下述指令安裝：

```
brew install --cask mactex
```

產生 PDF 步驟：

1. 執行：

   ```
   make latexpdf
   ```

   會於 `build/latex` 目錄產生所需檔案。

2. 進入該目錄並執行：

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   這會產生含所需內容的 `pytorch.pdf`。請再執行一次，以正確生成目錄與索引。

> [!NOTE]
> 若要查看目錄，請在 PDF 閱讀器中切換至 **Table of Contents** 檢視。

### 舊版本

舊版 PyTorch 的安裝說明與二進位檔，可於
[官方網站](https://pytorch.org/get-started/previous-versions) 查詢。

## 快速入門

三個上手指引：
- [教學：幫助你理解並開始使用 PyTorch](https://pytorch.org/tutorials/)
- [範例：涵蓋各領域，易於理解的 PyTorch 程式碼](https://github.com/pytorch/examples)
- [API 參考](https://pytorch.org/docs/)
- [術語表](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## 資源

* [PyTorch.org](https://pytorch.org/)
* [PyTorch 教學](https://pytorch.org/tutorials/)
* [PyTorch 範例](https://github.com/pytorch/examples)
* [PyTorch 模型](https://pytorch.org/hub/)
* [Udacity 的 PyTorch 深度學習入門](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Udacity 的 PyTorch 機器學習入門](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Coursera 的 PyTorch 深度神經網路](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [PyTorch 部落格](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## 溝通
* 論壇：討論實作、研究等 https://discuss.pytorch.org
* GitHub 問題：錯誤回報、功能請求、安裝問題、RFC、建議等
* Slack：[PyTorch Slack](https://pytorch.slack.com/) 主要為中高階使用者與開發者的討論、協作交流等。新手請優先使用 [PyTorch 論壇](https://discuss.pytorch.org)。若需邀請，可填表申請：https://goo.gl/forms/PP1AGvNHpSaJP8to1
* 電子報：重要 PyTorch 公告，一向單向發送。訂閱：https://eepurl.com/cbG0rv
* Facebook 粉專：重要公告 https://www.facebook.com/pytorch
* 品牌規範，請參考官網 [pytorch.org](https://pytorch.org/)

## 發佈與貢獻

PyTorch 通常一年有三次次要版本發佈。如遇到錯誤請[提交 issue](https://github.com/pytorch/pytorch/issues)。

我們歡迎所有貢獻。若你打算回報錯誤修正，請直接提交，無需討論。

若打算貢獻新功能、實用函式或核心擴充，請先開 issue 與我們討論。
未經討論直接發 PR，可能因為我們的開發方向不同而被拒絕。

想了解更多貢獻 PyTorch 的方式，請見[貢獻指南](CONTRIBUTING.md)。PyTorch 發佈相關訊息請見[發佈說明](RELEASE.md)。

## 開發團隊

PyTorch 是一個社群驅動的專案，由許多優秀的工程師和研究人員共同貢獻。

目前由 [Soumith Chintala](http://soumith.ch)、[Gregory Chanan](https://github.com/gchanan)、[Dmytro Dzhulgakov](https://github.com/dzhulgakov)、[Edward Yang](https://github.com/ezyang)、[Nikita Shulga](https://github.com/malfet) 維護，並有來自數百位傑出個人的重大貢獻。
不完全但持續成長的名單還包括：[Trevor Killeen](https://github.com/killeent)、[Sasank Chilamkurthy](https://github.com/chsasank)、[Sergey Zagoruyko](https://github.com/szagoruyko)、[Adam Lerer](https://github.com/adamlerer)、[Francisco Massa](https://github.com/fmassa)、[Alykhan Tejani](https://github.com/alykhantejani)、[Luca Antiga](https://github.com/lantiga)、[Alban Desmaison](https://github.com/albanD)、[Andreas Koepf](https://github.com/andreaskoepf)、[James Bradbury](https://github.com/jekbradbury)、[Zeming Lin](https://github.com/ebetica)、[Yuandong Tian](https://github.com/yuandong-tian)、[Guillaume Lample](https://github.com/glample)、[Marat Dukhan](https://github.com/Maratyszcza)、[Natalia Gimelshein](https://github.com/ngimel)、[Christian Sarofeen](https://github.com/csarofeen)、[Martin Raison](https://github.com/martinraison)、[Edward Yang](https://github.com/ezyang)、[Zachary Devito](https://github.com/zdevito)。

註：本專案與同名的 [hughperkins/pytorch](https://github.com/hughperkins/pytorch) 無關。Hugh 是 Torch 社群的重要貢獻者，對 Torch 與 PyTorch 有許多幫助。

## 授權

PyTorch 採 BSD 風格授權，詳見 [LICENSE](LICENSE) 檔案。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---