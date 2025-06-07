![PyTorch Logo](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch 是一个 Python 包，提供了两个高级特性：
- 张量计算（类似于 NumPy），并具备强大的 GPU 加速能力
- 基于 tape 的自动微分系统构建的深度神经网络

您可以根据需要重用您喜爱的 Python 包，如 NumPy、SciPy 和 Cython，以扩展 PyTorch。

我们的主干健康状况（持续集成信号）可在 [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main) 查看。

<!-- toc -->

- [更多关于 PyTorch](#more-about-pytorch)
  - [GPU 就绪的张量库](#a-gpu-ready-tensor-library)
  - [动态图神经网络：基于 Tape 的 Autograd](#dynamic-neural-networks-tape-based-autograd)
  - [Python 优先](#python-first)
  - [命令式体验](#imperative-experiences)
  - [快速且精简](#fast-and-lean)
  - [无痛扩展](#extensions-without-pain)
- [安装](#installation)
  - [二进制文件](#binaries)
    - [NVIDIA Jetson 平台](#nvidia-jetson-platforms)
  - [源码安装](#from-source)
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
    - [生成 PDF](#building-a-pdf)
  - [历史版本](#previous-versions)
- [快速上手](#getting-started)
- [资源](#resources)
- [交流沟通](#communication)
- [发布与贡献](#releases-and-contributing)
- [团队](#the-team)
- [许可证](#license)

<!-- tocstop -->

## 更多关于 PyTorch

[学习 PyTorch 基础知识](https://pytorch.org/tutorials/beginner/basics/intro.html)

从细节上看，PyTorch 是由以下组件组成的库：

| 组件 | 描述 |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | 类似 NumPy 的张量库，具有强大的 GPU 支持 |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | 基于 tape 的自动微分库，支持 torch 中所有可微分张量操作 |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | 编译栈（TorchScript），可从 PyTorch 代码创建可序列化和可优化的模型 |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | 与 autograd 深度集成的神经网络库，设计上极为灵活 |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Python 多进程，但可在进程间神奇地共享 torch 张量内存。用于数据加载和 Hogwild 训练非常有用 |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader 及其他便捷的实用函数 |

通常，PyTorch 的使用方式有以下两种：

- 作为 NumPy 的替代，以利用 GPU 的强大计算力。
- 作为深度学习研究平台，提供最大灵活性和速度。

进一步说明：

### GPU 就绪的张量库

如果你用过 NumPy，那你就用过张量（即 ndarray）。

![Tensor illustration](./docs/source/_static/img/tensor_illustration.png)

PyTorch 提供的张量可以存在于 CPU 或 GPU 上，并极大地加速计算。

我们提供了丰富的张量操作，以加速并满足您的科学计算需求，如切片、索引、数学运算、线性代数、归约操作等。
而且它们非常快！

### 动态图神经网络：基于 Tape 的 Autograd

PyTorch 构建神经网络有一种独特方式：使用并重放录音带。

大多数框架如 TensorFlow、Theano、Caffe 和 CNTK 都采用静态视图。
你需要构建神经网络，并反复复用相同结构。
如果要改变网络行为，就得从头再来。

在 PyTorch 中，我们采用了一种称为反向自动微分（reverse-mode auto-differentiation）的技术，允许你任意更改网络行为而无需任何延迟或开销。我们的灵感来自多篇相关研究论文，以及 [torch-autograd](https://github.com/twitter/torch-autograd)、[autograd](https://github.com/HIPS/autograd)、[Chainer](https://chainer.org) 等当前和过往的项目。

虽然这种技术并非 PyTorch 独有，但目前 PyTorch 的实现是最快的之一。
你可以获得速度和灵活性的最佳结合，助力你的科研探索。

![Dynamic graph](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python 优先

PyTorch 并不是一个绑定到庞大 C++ 框架的 Python 接口。
它本身就是为深度集成到 Python 而设计的。
你可以像使用 [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) 那样自然地使用它。
你可以用 Python 直接编写新的神经网络层，使用你喜欢的库，
并利用 [Cython](https://cython.org/) 和 [Numba](http://numba.pydata.org/) 等工具包。
我们的目标是在合适的地方不重复造轮子。

### 命令式体验

PyTorch 设计直观，思路线性，易于使用。
你写的每一行代码都会立即执行，不存在异步视角。
当你调试或收到错误提示和堆栈信息时，理解它们非常直接。
堆栈信息会准确指向你代码的定义位置。
我们希望你不会因为糟糕的堆栈信息或异步且不透明的执行引擎而浪费调试时间。

### 快速且精简

PyTorch 框架开销极小。我们集成了诸如 [Intel MKL](https://software.intel.com/mkl) 和 NVIDIA（[cuDNN](https://developer.nvidia.com/cudnn)，[NCCL](https://developer.nvidia.com/nccl)）等加速库以最大化速度。
其核心的 CPU 和 GPU 张量以及神经网络后端
都已经成熟，并经过多年测试。

因此，无论你运行小型还是大型神经网络，PyTorch 都非常快。

PyTorch 的内存使用相比 Torch 或其他一些替代品极为高效。
我们为 GPU 编写了自定义内存分配器，以确保
你的深度学习模型能最大限度地利用内存。
这使你能够训练更大的深度学习模型。

### 无痛扩展

编写新的神经网络模块或与 PyTorch 张量 API 交互被设计得非常简单，
并且抽象最少。

你可以使用 torch API 在 Python 中编写新的神经网络层，
[或你喜欢的基于 NumPy 的库，比如 SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html)。

如果你想用 C/C++ 编写层，我们提供了高效且样板代码极少的便捷扩展 API。
无需编写包装代码。你可以查看[本教程](https://pytorch.org/tutorials/advanced/cpp_extension.html)和[本示例](https://github.com/pytorch/extension-cpp)。

## 安装

### 二进制文件
通过 Conda 或 pip wheels 安装二进制文件的命令请见我们官网：[https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)

#### NVIDIA Jetson 平台

NVIDIA 的 Jetson Nano、Jetson TX1/TX2、Jetson Xavier NX/AGX 和 Jetson AGX Orin 的 Python wheel 包可在[这里](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048)获取，L4T 容器在[这里](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)发布。

需要 JetPack 4.2 及以上版本，由 [@dusty-nv](https://github.com/dusty-nv) 和 [@ptrblck](https://github.com/ptrblck) 维护。

### 源码安装

#### 先决条件
如果你打算源码安装，需要：
- Python 3.9 或更高版本
- 完全支持 C++17 的编译器，如 clang 或 gcc（Linux 上需 gcc 9.4.0 或更高）
- Visual Studio 或 Visual Studio Build Tool（仅限 Windows）

\* PyTorch CI 使用 Visual C++ BuildTools，该工具包含在 Visual Studio Enterprise、Professional 或 Community 版中。也可从 https://visualstudio.microsoft.com/visual-cpp-build-tools/ 单独安装。默认情况下，Visual Studio Code 并不包含这些构建工具。

下面是环境设置示例：

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
若需编译带有 CUDA 支持的版本，请[从我们的支持矩阵中选择支持的 CUDA 版本](https://pytorch.org/get-started/locally/)，然后安装以下内容：
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 或更高
- [与 CUDA 兼容的编译器](https://gist.github.com/ax3l/9489132)

注意：你可以参考 [cuDNN 支持矩阵](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) 以了解 cuDNN 与各 CUDA 版本、驱动和 NVIDIA 硬件的对应关系。

若需禁用 CUDA 支持，请导出环境变量 `USE_CUDA=0`。
其他可能有用的环境变量可在 `setup.py` 中找到。

如果你为 NVIDIA Jetson 平台（Jetson Nano、TX1、TX2、AGX Xavier）构建，Jetson Nano 的 PyTorch 安装指南见[这里](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### AMD ROCm 支持
若需编译支持 ROCm，请安装
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 及以上版本
- ROCm 当前仅支持 Linux 系统。

默认情况下，构建系统期望 ROCm 安装在 `/opt/rocm`。若安装在其他目录，需设置 `ROCM_PATH` 环境变量为 ROCm 安装路径。构建系统会自动检测 AMD GPU 架构，也可以通过 `PYTORCH_ROCM_ARCH` 环境变量手动指定 [AMD GPU 架构](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)。

若需禁用 ROCm 支持，请导出环境变量 `USE_ROCM=0`。
其他可用环境变量可在 `setup.py` 中查找。

##### Intel GPU 支持
若需编译支持 Intel GPU，请参考
- [Intel GPU 的 PyTorch 先决条件](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html)
- Intel GPU 支持 Linux 和 Windows

若需禁用 Intel GPU 支持，请导出环境变量 `USE_XPU=0`。
其他可用环境变量可在 `setup.py` 中查找。

#### 获取 PyTorch 源码
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# 如果是更新现有仓库
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
# 仅 CUDA：如需为 GPU 增加 LAPACK 支持
# magma 安装：需在激活的 conda 环境下运行，并指定 CUDA 版本
.ci/docker/common/install_magma_conda.sh 12.4

# （可选）如使用 torch.compile 的 inductor/triton，需安装相应版本的 triton
# 克隆后在 pytorch 目录下运行
# 若需 Intel GPU 支持，请在运行前显式 `export USE_XPU=1`
make triton
```

**MacOS 下**

```bash
# 仅在 intel x86 处理器上添加
pip install mkl-static mkl-include
# 如需 torch.distributed，请添加这些包
conda install pkg-config libuv
```

**Windows 下**

```bash
pip install mkl-static mkl-include
# 如需 torch.distributed，请添加这些包。
# Windows 下的分布式包为原型功能，可能变动。
conda install -c conda-forge libuv=1.39
```

#### 安装 PyTorch
**Linux 下**

若为 AMD ROCm 编译，请先运行：
```bash
# 仅当为 ROCm 编译时运行
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

如需构建旧版 python 代码，请参见 [Building on legacy code and CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**仅 CPU 构建**

此模式下，PyTorch 计算将在 CPU 上运行，不使用 GPU。

```cmd
python setup.py develop
```

关于 OpenMP：建议使用 Intel OpenMP（iomp）。为链接 iomp，你需要手动下载库并通过调整 `CMAKE_INCLUDE_PATH` 和 `LIB` 设置编译环境。配置方法可参见[这里](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source)。若未配置，CMake 将使用 Microsoft Visual C 的 OpenMP 运行时（vcomp）。

**基于 CUDA 的构建**

此模式下，PyTorch 计算将通过 CUDA 利用 GPU 进行加速。

[Pytorch 构建 CUDA 需 NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm)。
NVTX 是 CUDA 安装包的一部分，称为 “Nsight Compute”。如需安装到已安装的 CUDA 上，请重新运行 CUDA 安装并勾选相关选项。
确保 CUDA（含 Nsight Compute）在 Visual Studio 之后安装。

目前，CMake 支持 VS 2017 / 2019 和 Ninja 作为生成器。若 `PATH` 中检测到 `ninja.exe`，则默认使用 Ninja，否则使用 VS 2017 / 2019。
<br/> 若选择 Ninja 作为生成器，则自动选择最新的 MSVC 作为底层工具链。

常用的其他库如
[Magma](https://developer.nvidia.com/magma)、[oneDNN，又名 MKLDNN 或 DNNL](https://github.com/oneapi-src/oneDNN) 和 [Sccache](https://github.com/mozilla/sccache) 也常需安装。请参考 [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) 进行安装。

更多环境变量配置可参考 [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) 脚本。

```cmd
cmd

:: 下载并解压 mkl 包后设置环境变量，否则 CMake 会报错 `Could NOT find OpenMP`。
set CMAKE_INCLUDE_PATH={Your directory}\mkl\include
set LIB={Your directory}\mkl\lib;%LIB%

:: 仔细阅读上一节内容再继续。
:: [可选] 若需覆盖 Ninja 和 Visual Studio 使用的底层工具集，请运行以下脚本块。
:: “Visual Studio 2019 Developer Command Prompt” 会自动启动。
:: 若用 Visual Studio 生成器，请确保 CMake >= 3.12。
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [可选] 若需覆盖 CUDA 主机编译器
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Intel GPU 构建**

此模式下将构建支持 Intel GPU 的 PyTorch。

请确保[通用先决条件](#prerequisites)以及[Intel GPU 先决条件](#intel-gpu-support)已正确安装并配置好环境变量。构建工具需 `Visual Studio 2022`。

然后可用如下命令构建：

```cmd
:: CMD 命令：
:: 设置 CMAKE_PREFIX_PATH 以帮助找到相应包
:: %CONDA_PREFIX% 仅在 `conda activate custom_env` 后有效

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### 调整构建选项（可选）

你可以选择性地调整 cmake 变量配置（无需先构建），例如调整 CuDNN 或 BLAS 的预检测目录。

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

你还可以从 Docker Hub 拉取预构建镜像，并用 docker v19.03+ 运行

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

请注意，PyTorch 利用共享内存进行进程间数据交换，因此如使用 torch 多进程（如多线程数据加载器），
容器的默认共享内存段大小不足，需通过 `--ipc=host` 或 `--shm-size` 命令行选项增大共享内存。

#### 自行构建镜像

**注意：** 需用 docker 版本 > 18.06 构建

提供的 `Dockerfile` 支持构建带 CUDA 11.1 和 cuDNN v8 的镜像。
你可以通过 `PYTHON_VERSION=x.y` 变量指定 Miniconda 使用的 Python 版本，未指定则用默认版本。

```bash
make -f docker.Makefile
# 镜像标签为 docker.io/${your_docker_username}/pytorch
```

也可以通过环境变量 `CMAKE_VARS="..."` 传递额外 CMake 变量以定制构建过程。
可见 [setup.py](./setup.py) 获取可用变量列表。

```bash
make -f docker.Makefile
```

### 构建文档

要以多种格式构建文档，你需要 [Sphinx](http://www.sphinx-doc.org)
和 pytorch_sphinx_theme2。

本地构建文档前，请确保环境中已安装 `torch`。
如只做小修小补，可按[快速上手](https://pytorch.org/get-started/locally/)中所述安装 nightly 版。

如有更复杂修改，比如新增模块及文档字符串，可能需要[源码安装 torch](#from-source)。
文档字符串规范见 [Docstring Guidelines](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)。

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

运行 `make` 可查看所有可用输出格式。

如遇 katex 错误请运行 `npm install katex`。若仍有问题，试试
`npm install -g katex`

> [!注意]
> 若用不同包管理器（如 conda）安装了 `nodejs`，则 `npm` 可能安装的 `katex` 版本与 `nodejs` 不兼容，导致构建失败。
> 已知可用的组合为 `node@6.13.1` 和 `katex@0.13.18`。全局安装可执行
> ```npm install -g katex@0.13.18```

> [!注意]
> 若出现 numpy 兼容性错误，请运行：
> ```
> pip install 'numpy<2'
> ```

如修改了 CI 所需依赖，请编辑
`.ci/docker/requirements-docs.txt` 文件。

#### 生成 PDF

如需编译 PyTorch 全部文档为 PDF，请确保已安装
`texlive` 和 LaTeX。macOS 下可用：

```
brew install --cask mactex
```

生成 PDF 步骤：

1. 运行：

   ```
   make latexpdf
   ```

   这将在 `build/latex` 目录下生成相关文件。

2. 进入该目录，执行：

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   这将生成包含所需内容的 `pytorch.pdf`。请再运行一次该命令以生成正确的目录和索引。

> [!注意]
> 如需查看目录，请在 PDF 阅读器中切换到**目录**视图。

### 历史版本

历史版本的安装说明和二进制包可在
[官网](https://pytorch.org/get-started/previous-versions) 查询。

## 快速上手

三步上手：
- [教程：帮助你理解并使用 PyTorch](https://pytorch.org/tutorials/)
- [示例：涵盖各领域的易懂 PyTorch 代码](https://github.com/pytorch/examples)
- [API 参考文档](https://pytorch.org/docs/)
- [术语表](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## 资源

* [PyTorch.org](https://pytorch.org/)
* [PyTorch 教程](https://pytorch.org/tutorials/)
* [PyTorch 示例](https://github.com/pytorch/examples)
* [PyTorch 模型](https://pytorch.org/hub/)
* [Udacity PyTorch 深度学习入门](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Udacity PyTorch 机器学习入门](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Coursera PyTorch 深度神经网络课程](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch 推特](https://twitter.com/PyTorch)
* [PyTorch 博客](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## 交流沟通
* 论坛：实现、科研等讨论 https://discuss.pytorch.org
* GitHub Issues：Bug 报告、特性请求、安装问题、RFC、想法等。
* Slack：[PyTorch Slack](https://pytorch.slack.com/) 面向中高级 PyTorch 用户和开发者，适合普通聊天、线上讨论、协作等。新手建议优先使用 [PyTorch 论坛](https://discuss.pytorch.org)。如需 Slack 邀请，请填写：https://goo.gl/forms/PP1AGvNHpSaJP8to1
* 邮件通讯：无垃圾邮件，只发 PyTorch 重要公告。订阅入口：https://eepurl.com/cbG0rv
* Facebook 页面：PyTorch 重要公告。https://www.facebook.com/pytorch
* 品牌指南请访问 [pytorch.org](https://pytorch.org/)

## 发布与贡献

通常，PyTorch 每年有三个小版本发布。若发现 bug，请[提交 issue](https://github.com/pytorch/pytorch/issues)。

感谢所有贡献者。如计划提交 bug 修复，请直接提交，无需进一步讨论。

如计划贡献新特性、实用函数或核心扩展，请先提交 issue 与我们讨论。未经讨论直接发送 PR 可能会被拒绝，因为核心方向可能与你理解的不一致。

了解 PyTorch 贡献流程请见[贡献页面](CONTRIBUTING.md)。更多发布相关信息见[发布页面](RELEASE.md)。

## 团队

PyTorch 是一个社区驱动的项目，有众多优秀工程师和研究人员参与贡献。

当前由 [Soumith Chintala](http://soumith.ch)、[Gregory Chanan](https://github.com/gchanan)、[Dmytro Dzhulgakov](https://github.com/dzhulgakov)、[Edward Yang](https://github.com/ezyang)、[Nikita Shulga](https://github.com/malfet) 维护，数百位才华横溢的开发者以各种方式作出重要贡献。
部分贡献者（不断增长的非详尽名单）：[Trevor Killeen](https://github.com/killeent)、[Sasank Chilamkurthy](https://github.com/chsasank)、[Sergey Zagoruyko](https://github.com/szagoruyko)、[Adam Lerer](https://github.com/adamlerer)、[Francisco Massa](https://github.com/fmassa)、[Alykhan Tejani](https://github.com/alykhantejani)、[Luca Antiga](https://github.com/lantiga)、[Alban Desmaison](https://github.com/albanD)、[Andreas Koepf](https://github.com/andreaskoepf)、[James Bradbury](https://github.com/jekbradbury)、[Zeming Lin](https://github.com/ebetica)、[Yuandong Tian](https://github.com/yuandong-tian)、[Guillaume Lample](https://github.com/glample)、[Marat Dukhan](https://github.com/Maratyszcza)、[Natalia Gimelshein](https://github.com/ngimel)、[Christian Sarofeen](https://github.com/csarofeen)、[Martin Raison](https://github.com/martinraison)、[Edward Yang](https://github.com/ezyang)、[Zachary Devito](https://github.com/zdevito)。

注意：本项目与同名的 [hughperkins/pytorch](https://github.com/hughperkins/pytorch) 无关。Hugh 是 Torch 社区的重要贡献者，在 Torch 和 PyTorch 方面有诸多帮助。

## 许可证

PyTorch 采用 BSD 风格许可证，详见 [LICENSE](LICENSE) 文件。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---