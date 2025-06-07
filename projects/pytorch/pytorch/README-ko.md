![PyTorch 로고](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch는 두 가지 고수준 기능을 제공하는 Python 패키지입니다.
- 강력한 GPU 가속을 지원하는 텐서 연산(NumPy와 유사)
- 테이프 기반 autograd 시스템 위에 구축된 딥 뉴럴 네트워크

필요시 NumPy, SciPy, Cython 등 선호하는 Python 패키지를 재사용하여 PyTorch를 확장할 수 있습니다.

트렁크 상태(지속적 통합 신호)는 [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main)에서 확인할 수 있습니다.

<!-- toc -->

- [PyTorch에 대해 더 알아보기](#more-about-pytorch)
  - [GPU에 최적화된 텐서 라이브러리](#a-gpu-ready-tensor-library)
  - [동적 신경망: 테이프 기반 Autograd](#dynamic-neural-networks-tape-based-autograd)
  - [Python 우선](#python-first)
  - [명령형 경험](#imperative-experiences)
  - [빠르고 효율적](#fast-and-lean)
  - [확장성](#extensions-without-pain)
- [설치](#installation)
  - [바이너리](#binaries)
    - [NVIDIA Jetson 플랫폼](#nvidia-jetson-platforms)
  - [소스에서 설치](#from-source)
    - [사전 준비](#prerequisites)
      - [NVIDIA CUDA 지원](#nvidia-cuda-support)
      - [AMD ROCm 지원](#amd-rocm-support)
      - [Intel GPU 지원](#intel-gpu-support)
    - [PyTorch 소스 받기](#get-the-pytorch-source)
    - [의존성 설치](#install-dependencies)
    - [PyTorch 설치](#install-pytorch)
      - [빌드 옵션 조정(선택 사항)](#adjust-build-options-optional)
  - [도커 이미지](#docker-image)
    - [미리 빌드된 이미지 사용](#using-pre-built-images)
    - [직접 이미지 빌드](#building-the-image-yourself)
  - [문서 빌드](#building-the-documentation)
    - [PDF 빌드](#building-a-pdf)
  - [이전 버전](#previous-versions)
- [시작하기](#getting-started)
- [자료](#resources)
- [커뮤니케이션](#communication)
- [릴리즈 및 기여](#releases-and-contributing)
- [팀](#the-team)
- [라이선스](#license)

<!-- tocstop -->

## PyTorch에 대해 더 알아보기

[PyTorch 기초 배우기](https://pytorch.org/tutorials/beginner/basics/intro.html)

세부적으로, PyTorch는 다음과 같은 구성 요소로 이루어진 라이브러리입니다.

| 구성 요소 | 설명 |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | NumPy와 유사한 텐서 라이브러리, 강력한 GPU 지원 |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | torch의 모든 미분 가능한 텐서 연산을 지원하는 테이프 기반 자동 미분 라이브러리 |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | PyTorch 코드를 직렬화 및 최적화 가능한 모델로 변환하는 TorchScript 컴파일 스택 |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | autograd와 깊이 통합된 신경망 라이브러리로 최대 유연성을 제공 |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Python 멀티프로세싱이지만, 프로세스 간 torch 텐서의 마법같은 메모리 공유. 데이터 로딩과 Hogwild 학습에 유용 |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | 편의를 위한 DataLoader 및 기타 유틸리티 함수 |

일반적으로 PyTorch는 다음과 같이 사용됩니다.

- GPU의 성능을 활용하기 위한 NumPy 대체재로 사용
- 최대한의 유연성과 속도를 제공하는 딥러닝 연구 플랫폼

자세히 설명하면:

### GPU에 최적화된 텐서 라이브러리

NumPy를 사용해본 적이 있다면, 텐서(=ndarray)를 사용한 경험이 있습니다.

![Tensor illustration](./docs/source/_static/img/tensor_illustration.png)

PyTorch는 CPU 또는 GPU에서 작동할 수 있는 텐서를 제공하며,
연산을 대폭 가속화합니다.

슬라이싱, 인덱싱, 수학 연산, 선형 대수, 감소 연산 등
과학적 계산에 필요한 다양한 텐서 루틴을 제공하며,
매우 빠릅니다!

### 동적 신경망: 테이프 기반 Autograd

PyTorch는 신경망을 구축하는 독특한 방식, 즉 테이프 레코더처럼 사용하고 재생하는 방식을 채택합니다.

TensorFlow, Theano, Caffe, CNTK 등 대부분의 프레임워크는
세상의 구조를 정적으로 봅니다.
즉, 신경망을 한 번 만들고 같은 구조를 반복해서 재사용해야 합니다.
네트워크의 동작 방식을 변경하려면 처음부터 다시 시작해야 합니다.

PyTorch는 역방향 자동 미분(reverse-mode auto-differentiation) 기법을 사용하여
네트워크의 동작 방식을 자유롭게, 지연이나 오버헤드 없이 변경할 수 있습니다.
이 방식은 [torch-autograd](https://github.com/twitter/torch-autograd),
[autograd](https://github.com/HIPS/autograd),
[Chainer](https://chainer.org) 등 여러 연구 논문과 프로젝트에서 영감을 받았습니다.

이 기술이 PyTorch에만 있는 것은 아니지만, 현재까지 가장 빠른 구현 중 하나입니다.
속도와 유연성을 모두 얻을 수 있습니다.

![Dynamic graph](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python 우선

PyTorch는 거대한 C++ 프레임워크에 대한 Python 바인딩이 아닙니다.
Python과 깊이 통합되도록 설계되었습니다.
[NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) 등을 사용하듯 자연스럽게 사용할 수 있습니다.
선호하는 라이브러리와 [Cython](https://cython.org/)이나 [Numba](http://numba.pydata.org/)와 함께 직접 Python에서 신경망 레이어를 작성할 수 있습니다.
적절하다면 바퀴를 다시 만들지 않는 것이 목표입니다.

### 명령형 경험

PyTorch는 직관적이고, 생각의 흐름이 직선적이며, 사용하기 쉽도록 설계되었습니다.
코드 한 줄을 실행하면 바로 실행됩니다. 비동기적인 시각이 아닙니다.
디버거에 진입하거나 오류 메시지, 스택 트레이스를 받을 때, 이해하기 쉽습니다.
스택 트레이스는 정확히 코드가 정의된 위치를 가리킵니다.
불명확한 스택 트레이스나 비동기적, 불투명한 실행 엔진 때문에
오랜 시간 디버깅하지 않기를 바랍니다.

### 빠르고 효율적

PyTorch는 프레임워크 오버헤드가 최소화되어 있습니다.
[Intel MKL](https://software.intel.com/mkl), NVIDIA([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)) 등의 가속 라이브러리를 통합하여 최대 속도를 냅니다.
CPU와 GPU 텐서 및 신경망 백엔드는 수년간 검증된 성숙한 코드입니다.

따라서 PyTorch는 신경망이 크든 작든 매우 빠릅니다.

PyTorch의 메모리 사용은 Torch나 일부 대안에 비해 매우 효율적입니다.
GPU를 위한 커스텀 메모리 할당기를 직접 작성하여
딥러닝 모델이 최대한 메모리 효율적으로 학습될 수 있도록 했습니다.
이 덕분에 이전보다 더 큰 딥러닝 모델을 훈련할 수 있습니다.

### 확장성

새 신경망 모듈을 작성하거나 PyTorch의 텐서 API와 연동하는 것은
최소한의 추상화로 간단하게 설계되었습니다.

torch API 또는
[선호하는 NumPy 기반 라이브러리(SciPy 등)](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html)를 사용하여
Python에서 신경망 레이어를 새로 작성할 수 있습니다.

C/C++로 레이어를 작성하려면, 효율적이고 최소한의 보일러플레이트만 필요한 편리한 확장 API를 제공합니다.
랩퍼 코드를 별도로 작성할 필요가 없습니다.
[튜토리얼](https://pytorch.org/tutorials/advanced/cpp_extension.html)과 [예시](https://github.com/pytorch/extension-cpp)에서 자세히 확인할 수 있습니다.

## 설치

### 바이너리
Conda 또는 pip wheel을 통한 바이너리 설치 명령은 웹사이트에서 확인하세요: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)

#### NVIDIA Jetson 플랫폼

NVIDIA의 Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX, Jetson AGX Orin용 Python wheel은 [여기](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048)에서 제공되며, L4T 컨테이너는 [여기](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)에 게시되어 있습니다.

JetPack 4.2 이상이 필요하며, [@dusty-nv](https://github.com/dusty-nv)와 [@ptrblck](https://github.com/ptrblck)이 이를 관리합니다.

### 소스에서 설치

#### 사전 준비
소스에서 설치하려면 다음이 필요합니다.
- Python 3.9 이상
- C++17을 완전히 지원하는 컴파일러(예: clang 또는 gcc, Linux의 경우 gcc 9.4.0 이상 필요)
- Visual Studio 또는 Visual Studio Build Tool(Windows 전용)

\* PyTorch CI는 Visual C++ BuildTools를 사용합니다. 이 도구는 Visual Studio Enterprise, Professional, Community Edition에 포함되어 있습니다. 또는 https://visualstudio.microsoft.com/visual-cpp-build-tools/에서 빌드 도구만 설치할 수 있습니다. Visual Studio Code에는 기본적으로 포함되어 있지 않습니다.

환경 설정 예시:

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

##### NVIDIA CUDA 지원
CUDA 지원 컴파일을 원한다면, [지원되는 CUDA 버전을 지원 매트릭스에서 선택](https://pytorch.org/get-started/locally/)한 후 다음을 설치하세요.
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 이상
- CUDA와 호환되는 [컴파일러](https://gist.github.com/ax3l/9489132)

참고: 다양한 CUDA, CUDA 드라이버, NVIDIA 하드웨어와 호환되는 cuDNN 버전은 [cuDNN 지원 매트릭스](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html)를 참고하세요.

CUDA 지원을 비활성화하려면 환경 변수 `USE_CUDA=0`을 내보내세요.
기타 유용한 환경 변수는 `setup.py`에서 확인할 수 있습니다.

NVIDIA Jetson 플랫폼(Jetson Nano, TX1, TX2, AGX Xavier) 빌드 시, Jetson Nano용 PyTorch 설치 방법은 [여기](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)를 참고하세요.

##### AMD ROCm 지원
ROCm 지원 컴파일을 원한다면 아래를 설치하세요.
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 이상
- ROCm은 현재 Linux에서만 지원됩니다.

기본적으로 빌드 시스템은 ROCm이 `/opt/rocm`에 설치되어 있다고 가정합니다. 다른 디렉터리에 설치했다면 `ROCM_PATH` 환경 변수를 지정해야 합니다. 빌드 시스템은 AMD GPU 아키텍처를 자동 감지합니다. 필요시 `PYTORCH_ROCM_ARCH` 환경 변수로 명시적으로 지정할 수 있습니다. [AMD GPU 아키텍처 참고](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

ROCm 지원을 비활성화하려면 환경 변수 `USE_ROCM=0`을 내보내세요.
기타 유용한 환경 변수는 `setup.py`에서 확인할 수 있습니다.

##### Intel GPU 지원
Intel GPU 지원 컴파일을 원한다면 아래를 참고하세요.
- [Intel GPU용 PyTorch 사전 준비](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html) 안내
- Intel GPU는 Linux와 Windows에서 지원됩니다.

Intel GPU 지원을 비활성화하려면 환경 변수 `USE_XPU=0`을 내보내세요.
기타 유용한 환경 변수는 `setup.py`에서 확인할 수 있습니다.

#### PyTorch 소스 받기
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# 기존 체크아웃을 업데이트하는 경우
git submodule sync
git submodule update --init --recursive
```

#### 의존성 설치

**공통**

```bash
conda install cmake ninja
# 아래 "PyTorch 소스 받기" 섹션의 소스 코드 클론 후 PyTorch 디렉터리에서 실행
pip install -r requirements.txt
```

**Linux**

```bash
pip install mkl-static mkl-include
# CUDA만 해당: 필요시 GPU의 LAPACK 지원 추가
# magma 설치: 활성화된 conda 환경에서 실행, 설치할 CUDA 버전 명시
.ci/docker/common/install_magma_conda.sh 12.4

# (선택) torch.compile에서 inductor/triton 사용 시, 트라이튼(triton) 버전 설치
# 소스 클론 후 pytorch 디렉터리에서 실행
# Intel GPU 지원 시 `export USE_XPU=1` 후 실행
make triton
```

**MacOS**

```bash
# 인텔 x86 프로세서 머신에서만 추가
pip install mkl-static mkl-include
# torch.distributed 필요시 패키지 추가
conda install pkg-config libuv
```

**Windows**

```bash
pip install mkl-static mkl-include
# torch.distributed 필요시 패키지 추가
# Windows의 분산 패키지 지원은 프로토타입 기능이며 변경될 수 있음
conda install -c conda-forge libuv=1.39
```

#### PyTorch 설치
**Linux**

AMD ROCm 컴파일 시 먼저 아래 명령을 실행하세요.
```bash
# ROCm 컴파일 시에만 실행
python tools/amd_build/build_amd.py
```

PyTorch 설치
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**macOS**

```bash
python3 setup.py develop
```

**Windows**

레거시 Python 코드 빌드를 원한다면 [Building on legacy code and CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)를 참고하세요.

**CPU 전용 빌드**

이 모드에서는 PyTorch 연산이 GPU가 아니라 CPU에서 실행됩니다.

```cmd
python setup.py develop
```

OpenMP 참고: 권장 OpenMP 구현체는 Intel OpenMP(iomp)입니다. iomp와 링크하려면 라이브러리를 수동으로 다운로드 후, `CMAKE_INCLUDE_PATH`와 `LIB` 환경 변수를 설정해야 합니다. [설정 예시](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source)를 참고하세요. CMake에 대해 이 구성을 하지 않으면 MS Visual C OpenMP 런타임(vcomp)이 사용됩니다.

**CUDA 기반 빌드**

이 모드에서는 PyTorch 연산이 CUDA를 통해 GPU를 활용하여 더 빠른 계산이 가능합니다.

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm)는 CUDA 빌드 시 필요합니다.
NVTX는 CUDA 배포판의 일부이며 "Nsight Compute"로 불립니다. 이미 CUDA를 설치했다면, 설치를 한 번 더 실행하여 해당 체크박스를 선택하면 됩니다.
Visual Studio 설치 후 CUDA와 Nsight Compute가 설치되었는지 확인하세요.

현재 VS 2017 / 2019와 Ninja가 CMake의 제너레이터로 지원됩니다. `ninja.exe`가 `PATH`에 있으면 Ninja가 기본 제너레이터로 사용되며, 그렇지 않으면 VS 2017 / 2019가 사용됩니다.
<br/> Ninja 선택 시 최신 MSVC가 도구체인으로 선택됩니다.

[Magma](https://developer.nvidia.com/magma), [oneDNN(MKLDNN 또는 DNNL)](https://github.com/oneapi-src/oneDNN), [Sccache](https://github.com/mozilla/sccache) 등 추가 라이브러리가 필요할 수 있습니다. [설치 도우미](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers)를 참고하세요.

기타 환경 변수 설정은 [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) 스크립트를 참고하세요.

```cmd
cmd

:: mkl 패키지 다운로드 및 압축 해제 후 환경 변수 설정
:: CMake가 `Could NOT find OpenMP` 에러를 내지 않도록 반드시 설정
set CMAKE_INCLUDE_PATH={Your directory}\mkl\include
set LIB={Your directory}\mkl\lib;%LIB%

:: 이전 섹션 내용을 꼭 읽고 진행하세요
:: [선택] Ninja와 Visual Studio에서 CUDA의 툴셋을 오버라이드하려면 아래 스크립트 블록 실행
:: "Visual Studio 2019 Developer Command Prompt"가 자동 실행됨
:: Visual Studio 제너레이터 사용시 CMake >= 3.12 필요
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [선택] CUDA 호스트 컴파일러 지정
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Intel GPU 빌드**

이 모드에서는 Intel GPU 지원이 포함된 PyTorch를 빌드합니다.

[공통 사전 준비](#prerequisites) 및 [Intel GPU용 사전 준비](#intel-gpu-support)가 설치되어 있고 환경 변수가 올바르게 설정되어 있는지 확인하세요. 빌드 도구로는 `Visual Studio 2022`가 필요합니다.

PyTorch 빌드는 다음 명령으로 가능합니다.

```cmd
:: CMD 명령:
:: 패키지 검색을 돕기 위해 CMAKE_PREFIX_PATH 설정
:: %CONDA_PREFIX%는 `conda activate custom_env` 이후에만 동작

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### 빌드 옵션 조정(선택 사항)

CMake 변수의 구성을(빌드 전) 선택적으로 조정할 수 있습니다. 예를 들어, 미리 감지된 CuDNN 또는 BLAS 디렉토리 조정 등이 가능합니다.

Linux에서
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # 또는 cmake-gui build
```

macOS에서
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # 또는 cmake-gui build
```

### 도커 이미지

#### 미리 빌드된 이미지 사용

도커 허브에서 미리 빌드된 이미지를 받아 docker v19.03+에서 실행할 수 있습니다.

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

PyTorch는 프로세스 간 데이터 공유를 위해 공유 메모리를 사용합니다. torch 멀티프로세싱(예: 멀티스레드 데이터 로더) 사용 시 기본 공유 메모리 세그먼트 크기는 충분하지 않으므로, `--ipc=host` 또는 `--shm-size` 옵션으로 공유 메모리 크기를 늘려야 합니다.

#### 직접 이미지 빌드

**참고:** docker 버전 > 18.06에서만 빌드해야 합니다.

`Dockerfile`은 CUDA 11.1 지원 및 cuDNN v8과 함께 이미지를 빌드하도록 제공됩니다.
`PYTHON_VERSION=x.y` make 변수를 넘겨 Miniconda에서 사용할 Python 버전을 지정할 수 있으며, 지정하지 않으면 기본값이 사용됩니다.

```bash
make -f docker.Makefile
# 이미지는 docker.io/${your_docker_username}/pytorch로 태깅됨
```

빌드 중 CMake에 추가 변수 전달이 필요하면 `CMAKE_VARS="..."` 환경변수를 사용할 수 있습니다.
사용 가능한 변수 목록은 [setup.py](./setup.py)를 참고하세요.

```bash
make -f docker.Makefile
```

### 문서 빌드

여러 형식으로 문서를 빌드하려면 [Sphinx](http://www.sphinx-doc.org)와 pytorch_sphinx_theme2가 필요합니다.

로컬에서 문서를 빌드하기 전, `torch`가 환경에 설치되어 있어야 합니다. 간단한 수정은 [Getting Started](https://pytorch.org/get-started/locally/)에 설명된 대로 nightly 버전을 설치해도 됩니다.

새 모듈 추가나 모듈용 docstring 작성처럼 복잡한 수정을 위해서는 [소스에서 torch 설치](#from-source)가 필요할 수 있습니다. Docstring 규칙은 [Docstring Guidelines](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)를 참고하세요.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

`make` 명령으로 모든 출력 형식 목록을 확인할 수 있습니다.

katex 오류가 발생하면 `npm install katex`를 실행하세요. 계속 오류가 나면
`npm install -g katex`를 시도해보세요.

> [!NOTE]
> `nodejs`를 다른 패키지 매니저(예: `conda`)로 설치했다면,
> `npm`이 설치하는 `katex` 버전이 nodejs와 호환되지 않아 문서 빌드가 실패할 수 있습니다.
> 호환이 검증된 조합은 `node@6.13.1`과 `katex@0.13.18`입니다.
> latter를 npm으로 설치하려면 다음을 실행하세요.
> ```npm install -g katex@0.13.18```

> [!NOTE]
> numpy 호환성 오류가 발생하면 다음을 실행하세요:
> ```
> pip install 'numpy<2'
> ```

CI에서 실행되는 의존성에 변경이 있으면 `.ci/docker/requirements-docs.txt` 파일을 수정하세요.

#### PDF 빌드

PyTorch 전체 문서의 PDF를 컴파일하려면
`texlive`와 LaTeX가 필요합니다. macOS에서는 아래로 설치할 수 있습니다.

```
brew install --cask mactex
```

PDF를 생성하려면:

1. 아래를 실행하세요.

   ```
   make latexpdf
   ```

   `build/latex` 디렉터리에 필요한 파일이 생성됩니다.

2. 해당 디렉터리로 이동해 다음을 실행하세요.

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   원하는 내용을 담은 `pytorch.pdf`가 생성됩니다. 목차와 색인이 제대로 생성되도록 한 번 더 실행하세요.

> [!NOTE]
> PDF 뷰어에서 목차를 보려면 **Table of Contents** 보기로 전환하세요.

### 이전 버전

이전 PyTorch 버전 설치 안내 및 바이너리는
[웹사이트](https://pytorch.org/get-started/previous-versions)에서 확인할 수 있습니다.

## 시작하기

시작을 위한 세 가지 포인터:
- [튜토리얼: PyTorch 이해 및 사용법 익히기](https://pytorch.org/tutorials/)
- [예제: 모든 분야의 이해하기 쉬운 PyTorch 코드](https://github.com/pytorch/examples)
- [API 레퍼런스](https://pytorch.org/docs/)
- [용어집](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## 자료

* [PyTorch.org](https://pytorch.org/)
* [PyTorch 튜토리얼](https://pytorch.org/tutorials/)
* [PyTorch 예제](https://github.com/pytorch/examples)
* [PyTorch 모델](https://pytorch.org/hub/)
* [Udacity: PyTorch로 딥러닝 입문](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Udacity: PyTorch로 머신러닝 입문](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Coursera: PyTorch로 딥 뉴럴 네트워크](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch 트위터](https://twitter.com/PyTorch)
* [PyTorch 블로그](https://pytorch.org/blog/)
* [PyTorch 유튜브](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## 커뮤니케이션
* 포럼: 구현, 연구 등 논의 https://discuss.pytorch.org
* GitHub 이슈: 버그 리포트, 기능 요청, 설치 문제, RFC 등
* Slack: [PyTorch Slack](https://pytorch.slack.com/)은 중급 이상 PyTorch 사용자 및 개발자가 일반 대화, 온라인 토론, 협업 등 다양한 목적으로 사용합니다. 초보자라면 [PyTorch 포럼](https://discuss.pytorch.org)이 주요 매체입니다. Slack 초대가 필요하면 https://goo.gl/forms/PP1AGvNHpSaJP8to1 양식을 작성하세요.
* 뉴스레터: PyTorch의 주요 공지 사항만 전달하는 단방향 이메일 뉴스레터입니다. 가입: https://eepurl.com/cbG0rv
* Facebook 페이지: PyTorch의 주요 공지 사항. https://www.facebook.com/pytorch
* 브랜드 가이드라인은 [공식 웹사이트](https://pytorch.org/)를 참고하세요.

## 릴리즈 및 기여

PyTorch는 일반적으로 연간 세 차례 마이너 릴리스를 진행합니다. 버그를 발견하면 [이슈 등록](https://github.com/pytorch/pytorch/issues)을 부탁드립니다.

모든 기여를 환영합니다. 버그 수정은 별도 논의 없이 바로 기여해 주세요.

새 기능, 유틸리티 함수, 핵심 확장 기여를 원한다면 먼저 이슈를 열어 제안하고 논의 후에 PR을 보내주세요.
논의 없이 PR을 보내면, 프로젝트의 방향과 맞지 않을 경우 거절될 수 있습니다.

PyTorch 기여 방법은 [Contribution page](CONTRIBUTING.md), 릴리즈 정보는 [Release page](RELEASE.md)를 참고하세요.

## 팀

PyTorch는 여러 숙련된 엔지니어와 연구자의 커뮤니티 주도 프로젝트입니다.

현재 [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang), [Nikita Shulga](https://github.com/malfet)가 PyTorch를 관리하고 있으며, 수백 명의 재능 있는 기여자들이 다양한 방식으로 참여하고 있습니다.
비록 완전하진 않지만 반드시 언급해야 할 사람들: [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito).

참고: 이 프로젝트는 이름이 같은 [hughperkins/pytorch](https://github.com/hughperkins/pytorch)와 관련이 없습니다. Hugh는 Torch 커뮤니티의 소중한 기여자이며 Torch와 PyTorch에 많은 도움을 주셨습니다.

## 라이선스

PyTorch는 [LICENSE](LICENSE) 파일에 명시된 BSD 스타일 라이선스를 따릅니다.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---