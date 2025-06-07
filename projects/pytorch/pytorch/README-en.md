![PyTorch Logo](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch 是一个 Python 包，提供了两个高级特性：
- 张量计算（类似于 NumPy），并具备强大的 GPU 加速能力
- 基于 tape 的自动微分系统构建的深度神经网络

你可以复用你喜欢的 Python 包（如 NumPy、SciPy 和 Cython）在需要时扩展 PyTorch。

我们的主干健康状况（持续集成信号）可在 [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main) 查看。

<!-- toc -->

- [更多关于 PyTorch](#more-about-pytorch)
  - [GPU 就绪的张量库](#a-gpu-ready-tensor-library)
  - [动态图神经网络：基于 tape 的自动微分](#dynamic-neural-networks-tape-based-autograd)
  - [Python 优先](#python-first)
  - [命令式体验](#imperative-experiences)
  - [快速且精简](#fast-and-lean)
  - [无痛扩展](#extensions-without-pain)
- [安装](#installation)
  - [二进制包](#binaries)
    - [NVIDIA Jetson 平台](#nvidia-jetson-platforms)
  - [源码编译](#from-source)
    - [先决条件](#prerequisites)
      - [NVIDIA CUDA 支持](#nvidia-cuda-support)
      - [AMD ROCm 支持](#amd-rocm-support)
      - [Intel GPU 支持](#intel-gpu-support)
    - [获取 PyTorch 源码](#get-the-pytorch-source)
    - [安装依赖](#install-dependencies)
    - [安装 PyTorch](#install-pytorch)
      - [调整构建选项（可选）](#adjust-build-options-optional)
  - [Docker 镜像](#docker-image)
    - [使用预构建镜像](#using-pre-built-images)
    - [自行构建镜像](#building-the-image-yourself)
  - [构建文档](#building-the-documentation)
    - [构建 PDF](#building-a-pdf)
  - [历史版本](#previous-versions)
- [快速入门](#getting-started)
- [资源](#resources)
- [交流](#communication)
- [版本与贡献](#releases-and-contributing)
- [团队](#the-team)
- [许可证](#license)

<!-- tocstop -->

## 更多关于 PyTorch

[学习 PyTorch 基础知识](https://pytorch.org/tutorials/beginner/basics/intro.html)

在细粒度层面，PyTorch 是一个包含以下组件的库：

| 组件 | 描述 |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | 类似于 NumPy 的张量库，具备强大的 GPU 支持 |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | 基于 tape 的自动微分库，支持 torch 中所有可微分的张量操作 |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | 编译栈（TorchScript），可将 PyTorch 代码生成可序列化和可优化的模型 |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | 与 autograd 深度集成的神经网络库，设计极为灵活 |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Python 多进程，但可实现进程间 torch 张量的内存共享。适用于数据加载和 Hogwild 训练 |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader 及其他便捷的工具函数 |

通常，PyTorch 可用作：

- NumPy 的替代品，以利用 GPU 的强大算力。
- 提供极致灵活性与速度的深度学习研究平台。

进一步说明：

### GPU 就绪的张量库

如果你用过 NumPy，你就用过张量（即 ndarray）。

![张量示意图](./docs/source/_static/img/tensor_illustration.png)

PyTorch 提供的张量可以驻留在 CPU 或 GPU 上，并极大加速计算。

我们提供了丰富的张量操作例程，以加速并满足你的科学计算需求，
如切片、索引、数学运算、线性代数、归约等。
而且它们都非常快！

### 动态图神经网络：基于 tape 的自动微分

PyTorch 构建神经网络有一种独特方式：使用并重放一个“录音带”。

大多数框架如 TensorFlow、Theano、Caffe 和 CNTK 都采用静态方式。
你必须先构建一个神经网络结构，然后反复使用同一个结构。
如果想改变网络行为，就必须从头再来。

而在 PyTorch 中，我们使用了一种称为反向模式自动微分的技术，它允许你
随意更改网络行为，且零延迟、零开销。我们的灵感来自多篇相关研究论文，以及
[torch-autograd](https://github.com/twitter/torch-autograd)、
[autograd](https://github.com/HIPS/autograd)、
[Chainer](https://chainer.org) 等当前及以往的相关工作。

尽管这种技术并非 PyTorch 独有，但我们拥有目前最快的实现之一。
你可以同时获得极致的速度与灵活性，助力你的前沿研究。

![动态图](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python 优先

PyTorch 并不是一个巨大的 C++ 框架的 Python 绑定。
它被设计为深度集成于 Python。
你可以像使用 [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) 那样自然地使用它。
你可以用自己喜欢的库在 Python 中编写新的神经网络层，
并借助 [Cython](https://cython.org/) 和 [Numba](http://numba.pydata.org/) 等工具包。
我们的目标是在合适的地方不重复造轮子。

### 命令式体验

PyTorch 设计直观、逻辑线性、易于使用。
你写一行代码，就会立刻执行。没有异步世界的概念。
调试或遇到错误时，堆栈跟踪清晰指向代码定义位置。
我们希望你不必因为糟糕的堆栈跟踪或异步、晦涩的执行引擎而花费数小时调试代码。

### 快速且精简

PyTorch 框架开销极小。我们集成了
[Intel MKL](https://software.intel.com/mkl) 以及 NVIDIA（[cuDNN](https://developer.nvidia.com/cudnn)、[NCCL](https://developer.nvidia.com/nccl)）等加速库以提升速度。
底层的 CPU/GPU 张量与神经网络后端
成熟且历经多年测试。

因此，无论是小型还是大型神经网络，PyTorch 都非常快。

PyTorch 的内存使用极为高效，相较于 Torch 或其他替代品。
我们为 GPU 编写了自定义内存分配器，确保
你的深度学习模型具备极致内存效率。
这让你能训练比以往更大的深度学习模型。

### 无痛扩展

编写新的神经网络模块或对接 PyTorch 的张量 API 都非常直接，
且抽象最小。

你可以用 torch API 直接在 Python 中编写新神经网络层，
[或用你喜欢的基于 NumPy 的库（如 SciPy）](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html)。

如果你想用 C/C++ 编写层，我们也提供高效且样板代码极少的扩展 API。
无需编写包装代码。你可以参考[此教程](https://pytorch.org/tutorials/advanced/cpp_extension.html)及[此示例](https://github.com/pytorch/extension-cpp)。

## 安装

### 二进制包
通过 Conda 或 pip wheels 安装二进制包的命令请见我们的官网：[https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)

#### NVIDIA Jetson 平台

NVIDIA Jetson Nano、Jetson TX1/TX2、Jetson Xavier NX/AGX 和 Jetson AGX Orin 的 Python wheel 包在[这里](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048)提供，L4T 容器发布在[这里](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)。

它们需要 JetPack 4.2 及以上版本，[ @dusty-nv ](https://github.com/dusty-nv) 和 [ @ptrblck ](https://github.com/ptrblck) 负责维护。

### 源码编译

#### 先决条件
如果你打算源码安装，你需要：
- Python 3.9 或更高版本
- 完全支持 C++17 的编译器，如 clang 或 gcc（Linux 上需 gcc 9.4.0 或更高版本）
- Visual Studio 或 Visual Studio Build Tool（仅限 Windows）

\* PyTorch CI 使用 Visual C++ BuildTools，可通过 Visual Studio Enterprise、Professional 或 Community 版本获得。也可从 https://visualstudio.microsoft.com/visual-cpp-build-tools/ 单独安装。*Visual Studio Code* 默认不包含这些构建工具。

环境设置示例：

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

##### NVIDIA CUDA 支持
若需编译 CUDA 支持，请[从支持矩阵中选择支持的 CUDA 版本](https://pytorch.org/get-started/locally/)，然后安装以下组件：
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 或更高
- [兼容 CUDA 的编译器](https://gist.github.com/ax3l/9489132)

注意：可参考 [cuDNN 支持矩阵](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) 查看 cuDNN 与各 CUDA、驱动及硬件的兼容性。

若要禁用 CUDA 支持，导出环境变量 `USE_CUDA=0`。
更多有用的环境变量见 `setup.py`。

若为 NVIDIA Jetson 平台（Jetson Nano、TX1、TX2、AGX Xavier）编译，Jetson Nano 的安装说明见[此处](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)。

##### AMD ROCm 支持
若需编译 ROCm 支持，安装
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 或更高
- ROCm 目前仅支持 Linux 系统。

默认情况下构建系统期望 ROCm 安装在 `/opt/rocm`。如在其他目录，请设定 `ROCM_PATH` 环境变量。构建系统会自动检测 AMD GPU 架构，也可用 `PYTORCH_ROCM_ARCH` 显式指定[AMD GPU 架构](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)。

若要禁用 ROCm 支持，导出环境变量 `USE_ROCM=0`。
更多有用的环境变量见 `setup.py`。

##### Intel GPU 支持
如需编译 Intel GPU 支持，请参考
- [Intel GPU 的 PyTorch 先决条件](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html)。
- Intel GPU 支持 Linux 和 Windows。

若要禁用 Intel GPU 支持，导出环境变量 `USE_XPU=0`。
更多有用的环境变量见 `setup.py`。

#### 获取 PyTorch 源码
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# 如需更新已克隆仓库
git submodule sync
git submodule update --init --recursive
```

#### 安装依赖

**通用**

```bash
conda install cmake ninja
# 克隆源码后，在 PyTorch 目录下运行
pip install -r requirements.txt
```

**Linux 下**

```bash
pip install mkl-static mkl-include
# 仅 CUDA：如需为 GPU 添加 LAPACK 支持
# 安装 magma：需激活 conda 环境并指定 CUDA 版本
.ci/docker/common/install_magma_conda.sh 12.4

# （可选）如使用 torch.compile 的 inductor/triton，需安装匹配 triton 版本
# 在 pytorch 目录下运行
# 对于 Intel GPU 支持，请在运行前显式 `export USE_XPU=1`
make triton
```

**MacOS 下**

```bash
# 仅在 Intel x86 处理器机器添加此包
pip install mkl-static mkl-include
# 如需 torch.distributed，添加以下包
conda install pkg-config libuv
```

**Windows 下**

```bash
pip install mkl-static mkl-include
# 如需 torch.distributed，添加以下包
# Windows 上分布式包支持为原型功能，可能有变动
conda install -c conda-forge libuv=1.39
```

#### 安装 PyTorch
**Linux 下**

如为 AMD ROCm 编译，先运行：
```bash
# 仅 ROCm 编译时运行
python tools/amd_build/build_amd.py
```

安装 PyTorch
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**macOS 下**

```bash
python3 setup.py develop
```

**Windows 下**

如需构建旧版 Python 代码，请参考[旧代码和 CUDA 构建说明](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**仅 CPU 构建**

此模式下，PyTorch 计算将仅在 CPU 上运行。

```cmd
python setup.py develop
```

OpenMP 说明：推荐使用 Intel OpenMP (iomp)。如需链接 iomp，需手动下载库并通过设置 `CMAKE_INCLUDE_PATH` 和 `LIB` 配置构建环境。详细说明可参考[此处](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source)。如未做此配置，则会使用 Microsoft Visual C 的 OpenMP 运行时 (vcomp)。

**CUDA 构建**

此模式下，PyTorch 计算将通过 CUDA 利用 GPU 加速。

编译 PyTorch CUDA 需 [NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm)，
NVTX 属于 CUDA 套件（名称为 "Nsight Compute"）。如需安装到已装 CUDA 上，请重新运行安装程序并勾选相应选项。
确保在 Visual Studio 安装后再安装包含 Nsight Compute 的 CUDA。

当前支持 VS 2017/2019 及 Ninja 作为 CMake 生成器。如果 `PATH` 中检测到 `ninja.exe`，则默认使用 Ninja，否则用 VS 2017/2019。
<br/> 若选用 Ninja，底层工具链会选用最新 MSVC。

还常需安装
[Magma](https://developer.nvidia.com/magma)、[oneDNN（又名 MKLDNN 或 DNNL）](https://github.com/oneapi-src/oneDNN)、[Sccache](https://github.com/mozilla/sccache) 等库。请参考[安装助手](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers)。

更多环境变量设置可参考 [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) 脚本。

```cmd
cmd

:: 下载并解压 mkl 包后设置环境变量，否则 CMake 会报找不到 OpenMP 错。
set CMAKE_INCLUDE_PATH={Your directory}\mkl\include
set LIB={Your directory}\mkl\lib;%LIB%

:: 阅读前述内容后操作。
:: [可选] 如需覆盖 Ninja 和 Visual Studio 下 CUDA 的工具链，请运行以下脚本块。
:: 将自动运行 "Visual Studio 2019 Developer Command Prompt"。
:: 如使用 Visual Studio 生成器，请确保 CMake >= 3.12。
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [可选] 如需覆盖 CUDA host 编译器
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Intel GPU 构建**

此模式下将构建支持 Intel GPU 的 PyTorch。

请确保[通用先决条件](#prerequisites)及[Intel GPU 先决条件](#intel-gpu-support)均已正确安装，并配置好环境变量。工具链需 `Visual Studio 2022`。

构建命令如下：

```cmd
:: CMD 命令：
:: 设置 CMAKE_PREFIX_PATH 以便找到相关包
:: %CONDA_PREFIX% 仅在 `conda activate custom_env` 后有效

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### 调整构建选项（可选）

可选地（无需先构建），你可以调整 cmake 变量配置。例如，调整 CuDNN 或 BLAS 的目录可在此步骤完成。

Linux 下
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # 或 cmake-gui build
```

macOS 下
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # 或 cmake-gui build
```

### Docker 镜像

#### 使用预构建镜像

你也可以从 Docker Hub 拉取预构建镜像并用 docker v19.03+ 运行

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

请注意，PyTorch 使用共享内存在进程间共享数据，因此如使用 torch 多进程（如多线程数据加载器），
容器默认的共享内存段大小可能不足，建议在运行时用 `--ipc=host` 或 `--shm-size` 选项调整。

#### 自行构建镜像

**注意：** 必须使用 docker 18.06 以上版本构建

`Dockerfile` 提供了带 CUDA 11.1 和 cuDNN v8 支持的镜像构建方案。
你可通过 `PYTHON_VERSION=x.y` 变量指定 Miniconda 使用的 Python 版本，未设置则用默认值。

```bash
make -f docker.Makefile
# 镜像标签为 docker.io/${your_docker_username}/pytorch
```

你还可以通过 `CMAKE_VARS="..."` 环境变量传递额外 CMake 变量。
详情见 [setup.py](./setup.py)。

```bash
make -f docker.Makefile
```

### 构建文档

要以多种格式构建文档，你需安装 [Sphinx](http://www.sphinx-doc.org)
和 pytorch_sphinx_theme2。

本地构建前，请确保你的环境已安装 `torch`。如仅做小修可安装夜间版，方法见[快速入门](https://pytorch.org/get-started/locally/)。

如需更复杂的修复（如添加新模块及文档字符串），可能需[源码安装 torch](#from-source)。
文档字符串规范见[Docstring Guidelines](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)。

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

运行 `make` 可查看所有可用输出格式。

如遇 katex 错误，运行 `npm install katex`。若仍报错，尝试
`npm install -g katex`

> [!NOTE]
> 若你用其他包管理器（如 `conda`）安装了 `nodejs`，`npm` 可能安装了与你 nodejs 版本不兼容的 katex，导致文档构建失败。
> 已知可用版本组合为 `node@6.13.1` 和 `katex@0.13.18`。用 `npm` 安装后者命令如下：
> ```npm install -g katex@0.13.18```

> [!NOTE]
> 如遇 numpy 不兼容错误，运行：
> ```
> pip install 'numpy<2'
> ```

如修改了 CI 依赖，请编辑 `.ci/docker/requirements-docs.txt` 文件。

#### 构建 PDF

要编译 PyTorch 全部文档为 PDF，需安装 `texlive` 和 LaTeX。macOS 可用：

```
brew install --cask mactex
```

生成 PDF 步骤：

1. 运行：

   ```
   make latexpdf
   ```

   这会在 `build/latex` 目录生成所需文件。

2. 进入该目录并执行：

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   将生成 `pytorch.pdf`。再运行一次以正确生成目录和索引。

> [!NOTE]
> 若需查看目录，请在 PDF 阅读器中切换到**目录**视图。

### 历史版本

以往 PyTorch 版本的安装说明和二进制包见
[官网](https://pytorch.org/get-started/previous-versions)。

## 快速入门

三步助你上手：
- [教程：了解并使用 PyTorch](https://pytorch.org/tutorials/)
- [示例：各领域易懂的 PyTorch 代码](https://github.com/pytorch/examples)
- [API 参考手册](https://pytorch.org/docs/)
- [术语表](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## 资源

* [PyTorch.org](https://pytorch.org/)
* [PyTorch 教程](https://pytorch.org/tutorials/)
* [PyTorch 示例](https://github.com/pytorch/examples)
* [PyTorch 模型](https://pytorch.org/hub/)
* [Udacity 深度学习 PyTorch 入门](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Udacity PyTorch 机器学习入门](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Coursera PyTorch 深度神经网络](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [PyTorch 博客](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## 交流
* 论坛：实现、研究等讨论 https://discuss.pytorch.org
* GitHub Issues：Bug 报告、特性请求、安装问题、RFC、建议等
* Slack：[PyTorch Slack](https://pytorch.slack.com/) 主要面向中高级 PyTorch 用户和开发者，适于一般讨论、协作等。如为初学者，建议优先用 [PyTorch 论坛](https://discuss.pytorch.org)。如需 Slack 邀请，请填写此表：https://goo.gl/forms/PP1AGvNHpSaJP8to1
* 邮件简报：一条通道，推送 PyTorch 重要公告。可在此注册：https://eepurl.com/cbG0rv
* Facebook 页面：PyTorch 重要公告 https://www.facebook.com/pytorch
* 品牌规范请见[官网](https://pytorch.org/)

## 版本与贡献

PyTorch 通常每年有三个小版本发布。如遇 Bug，请[提交 Issue](https://github.com/pytorch/pytorch/issues)。

欢迎所有贡献。若你计划贡献 Bug 修复，直接提交即可，无需进一步讨论。

如计划贡献新特性、实用函数或核心扩展，请先提交 Issue 与我们讨论，
直接提交 PR 可能会因方向不符而被拒。

了解更多 PyTorch 贡献方式，请见[贡献页面](CONTRIBUTING.md)。了解 PyTorch 版本信息请见[版本说明](RELEASE.md)。

## 团队

PyTorch 是一个由社区驱动的项目，众多出色工程师和研究人员共同贡献。

当前主要由 [Soumith Chintala](http://soumith.ch)、[Gregory Chanan](https://github.com/gchanan)、[Dmytro Dzhulgakov](https://github.com/dzhulgakov)、[Edward Yang](https://github.com/ezyang) 和 [Nikita Shulga](https://github.com/malfet) 维护，数百名才华横溢的个人以各种方式做出贡献。
部分主要贡献者（不完全名单）：[Trevor Killeen](https://github.com/killeent)、[Sasank Chilamkurthy](https://github.com/chsasank)、[Sergey Zagoruyko](https://github.com/szagoruyko)、[Adam Lerer](https://github.com/adamlerer)、[Francisco Massa](https://github.com/fmassa)、[Alykhan Tejani](https://github.com/alykhantejani)、[Luca Antiga](https://github.com/lantiga)、[Alban Desmaison](https://github.com/albanD)、[Andreas Koepf](https://github.com/andreaskoepf)、[James Bradbury](https://github.com/jekbradbury)、[Zeming Lin](https://github.com/ebetica)、[Yuandong Tian](https://github.com/yuandong-tian)、[Guillaume Lample](https://github.com/glample)、[Marat Dukhan](https://github.com/Maratyszcza)、[Natalia Gimelshein](https://github.com/ngimel)、[Christian Sarofeen](https://github.com/csarofeen)、[Martin Raison](https://github.com/martinraison)、[Edward Yang](https://github.com/ezyang)、[Zachary Devito](https://github.com/zdevito)。

注意：本项目与同名的 [hughperkins/pytorch](https://github.com/hughperkins/pytorch) 无关。Hugh 是 Torch 社区的宝贵贡献者，为 Torch 和 PyTorch 做出了许多贡献。

## 许可证

PyTorch 采用 BSD 风格许可证，详见 [LICENSE](LICENSE) 文件。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---