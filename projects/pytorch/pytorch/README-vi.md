![Logo PyTorch](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch là một gói Python cung cấp hai tính năng cấp cao:
- Tính toán Tensor (giống như NumPy) với khả năng tăng tốc GPU mạnh mẽ
- Mạng nơ-ron sâu được xây dựng trên hệ thống autograd dựa trên băng ghi (tape-based)

Bạn có thể tái sử dụng các gói Python yêu thích như NumPy, SciPy và Cython để mở rộng PyTorch khi cần.

Tình trạng nhánh chính (tín hiệu Kiểm tra Liên tục - Continuous Integration) có thể được tìm thấy tại [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main).

<!-- toc -->

- [Tìm hiểu thêm về PyTorch](#more-about-pytorch)
  - [Thư viện Tensor sẵn sàng cho GPU](#a-gpu-ready-tensor-library)
  - [Mạng nơ-ron động: Autograd dựa trên băng ghi](#dynamic-neural-networks-tape-based-autograd)
  - [Ưu tiên Python](#python-first)
  - [Trải nghiệm trực tiếp](#imperative-experiences)
  - [Nhanh và tiết kiệm tài nguyên](#fast-and-lean)
  - [Mở rộng dễ dàng](#extensions-without-pain)
- [Cài đặt](#installation)
  - [Các gói nhị phân](#binaries)
    - [Nền tảng NVIDIA Jetson](#nvidia-jetson-platforms)
  - [Cài đặt từ mã nguồn](#from-source)
    - [Yêu cầu](#prerequisites)
      - [Hỗ trợ NVIDIA CUDA](#nvidia-cuda-support)
      - [Hỗ trợ AMD ROCm](#amd-rocm-support)
      - [Hỗ trợ GPU Intel](#intel-gpu-support)
    - [Lấy mã nguồn PyTorch](#get-the-pytorch-source)
    - [Cài đặt các phụ thuộc](#install-dependencies)
    - [Cài đặt PyTorch](#install-pytorch)
      - [Điều chỉnh tuỳ chọn biên dịch (Tùy chọn)](#adjust-build-options-optional)
  - [Docker Image](#docker-image)
    - [Sử dụng image dựng sẵn](#using-pre-built-images)
    - [Tự dựng image](#building-the-image-yourself)
  - [Biên dịch tài liệu](#building-the-documentation)
    - [Biên dịch PDF](#building-a-pdf)
  - [Các phiên bản trước đây](#previous-versions)
- [Bắt đầu sử dụng](#getting-started)
- [Tài nguyên](#resources)
- [Trao đổi](#communication)
- [Phát hành và đóng góp](#releases-and-contributing)
- [Nhóm phát triển](#the-team)
- [Giấy phép](#license)

<!-- tocstop -->

## Tìm hiểu thêm về PyTorch

[Học những kiến thức cơ bản về PyTorch](https://pytorch.org/tutorials/beginner/basics/intro.html)

Ở mức chi tiết, PyTorch là một thư viện bao gồm các thành phần sau:

| Thành phần | Mô tả |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | Thư viện Tensor giống như NumPy, với hỗ trợ GPU mạnh mẽ |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | Thư viện phân biệt tự động dựa trên băng ghi, hỗ trợ tất cả các phép toán Tensor khả vi trong torch |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | Chuỗi biên dịch (TorchScript) để tạo mô hình có thể tuần tự hóa và tối ưu hóa từ mã PyTorch |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | Thư viện mạng nơ-ron tích hợp sâu với autograd, thiết kế để tối đa hóa tính linh hoạt |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Đa tiến trình Python, nhưng với khả năng chia sẻ bộ nhớ kỳ diệu của Tensor torch giữa các tiến trình. Hữu ích cho việc nạp dữ liệu và huấn luyện Hogwild |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader và các hàm tiện ích khác |

Thông thường, PyTorch được sử dụng như:
- Một sự thay thế cho NumPy để tận dụng sức mạnh GPU.
- Nền tảng nghiên cứu học sâu cung cấp tính linh hoạt và tốc độ tối đa.

Chi tiết hơn:

### Thư viện Tensor sẵn sàng cho GPU

Nếu bạn sử dụng NumPy, bạn đã từng dùng Tensor (hay còn gọi là ndarray).

![Minh họa Tensor](./docs/source/_static/img/tensor_illustration.png)

PyTorch cung cấp các Tensor có thể tồn tại trên CPU hoặc GPU và tăng tốc tính toán lên rất nhiều.

Chúng tôi cung cấp nhiều hàm xử lý tensor để đáp ứng nhu cầu tính toán khoa học của bạn như cắt, đánh chỉ số, phép toán toán học, đại số tuyến tính, phép giảm, v.v.
Và chúng rất nhanh!

### Mạng nơ-ron động: Autograd dựa trên băng ghi

PyTorch có một cách xây dựng mạng nơ-ron độc đáo: sử dụng và phát lại một máy ghi băng (tape recorder).

Phần lớn các framework như TensorFlow, Theano, Caffe, CNTK có cách nhìn tĩnh về thế giới.
Bạn phải xây dựng mạng nơ-ron và sử dụng lại cùng một cấu trúc nhiều lần.
Thay đổi cách hoạt động của mạng nghĩa là phải bắt đầu lại từ đầu.

Với PyTorch, chúng tôi sử dụng kỹ thuật gọi là phân biệt tự động chế độ ngược (reverse-mode auto-differentiation), cho phép bạn thay đổi cách mạng hoạt động một cách tuỳ ý mà không có độ trễ hay chi phí nào. Chúng tôi lấy cảm hứng từ nhiều bài báo nghiên cứu về chủ đề này, cũng như các dự án hiện tại và trước đây như
[torch-autograd](https://github.com/twitter/torch-autograd),
[autograd](https://github.com/HIPS/autograd),
[Chainer](https://chainer.org), v.v.

Dù kỹ thuật này không phải riêng của PyTorch, nhưng đây là một trong những hiện thực hóa nhanh nhất hiện nay.
Bạn sẽ có được tốc độ và tính linh hoạt tối ưu cho các nghiên cứu táo bạo của mình.

![Biểu đồ động](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Ưu tiên Python

PyTorch không phải là một liên kết Python vào một framework C++ nguyên khối.
Nó được xây dựng để tích hợp sâu vào Python.
Bạn có thể sử dụng nó tự nhiên như với [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) v.v.
Bạn có thể viết các lớp mạng nơ-ron mới bằng chính Python, sử dụng các thư viện yêu thích và các gói như [Cython](https://cython.org/) và [Numba](http://numba.pydata.org/).
Mục tiêu của chúng tôi là không phát minh lại bánh xe khi không cần thiết.

### Trải nghiệm trực tiếp

PyTorch được thiết kế để trực quan, tuyến tính trong suy nghĩ và dễ sử dụng.
Khi bạn thực thi một dòng mã, nó sẽ được thực thi ngay lập tức. Không có cái nhìn bất đồng bộ về thế giới.
Khi bạn sử dụng trình gỡ lỗi hoặc nhận thông báo lỗi và các trace stack, việc hiểu chúng rất đơn giản.
Trace stack chỉ rõ vị trí mã của bạn được định nghĩa.
Chúng tôi hy vọng bạn không phải mất hàng giờ để gỡ lỗi do trace stack tệ hoặc các engine thực thi bất đồng bộ, khó hiểu.

### Nhanh và tiết kiệm tài nguyên

PyTorch có chi phí framework tối thiểu. Chúng tôi tích hợp các thư viện tăng tốc như
[Intel MKL](https://software.intel.com/mkl) và NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)) để tối đa hóa tốc độ.
Ở lõi, backend Tensor và mạng nơ-ron cho CPU và GPU đã trưởng thành và được kiểm thử nhiều năm.

Do đó, PyTorch rất nhanh — dù bạn chạy mạng nơ-ron nhỏ hay lớn.

Việc sử dụng bộ nhớ trong PyTorch cực kỳ hiệu quả so với Torch hoặc một số lựa chọn thay thế.
Chúng tôi đã viết bộ cấp phát bộ nhớ tùy chỉnh cho GPU để đảm bảo mô hình học sâu của bạn sử dụng bộ nhớ tối ưu nhất.
Điều này cho phép bạn huấn luyện các mô hình học sâu lớn hơn trước.

### Mở rộng dễ dàng

Viết module mạng nơ-ron mới, hoặc giao tiếp với API Tensor của PyTorch được thiết kế đơn giản và với mức trừu tượng tối thiểu.

Bạn có thể viết các lớp mạng nơ-ron mới bằng Python sử dụng API torch
[hoặc các thư viện dựa trên NumPy yêu thích như SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html).

Nếu bạn muốn viết lớp của mình bằng C/C++, chúng tôi cung cấp API mở rộng tiện lợi, hiệu quả và không cần mã bọc phức tạp.
Bạn có thể xem [hướng dẫn tại đây](https://pytorch.org/tutorials/advanced/cpp_extension.html) và [ví dụ tại đây](https://github.com/pytorch/extension-cpp).


## Cài đặt

### Các gói nhị phân
Lệnh cài đặt các gói nhị phân qua Conda hoặc pip wheels có trên website: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)


#### Nền tảng NVIDIA Jetson

Python wheels cho NVIDIA Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX, và Jetson AGX Orin được cung cấp [tại đây](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) và L4T container được phát hành [tại đây](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)

Chúng yêu cầu JetPack 4.2 trở lên, và [@dusty-nv](https://github.com/dusty-nv) cùng [@ptrblck](https://github.com/ptrblck) đang duy trì chúng.


### Cài đặt từ mã nguồn

#### Yêu cầu
Nếu bạn cài đặt từ mã nguồn, bạn sẽ cần:
- Python 3.9 trở lên
- Trình biên dịch hỗ trợ đầy đủ C++17, như clang hoặc gcc (gcc 9.4.0 hoặc mới hơn trên Linux)
- Visual Studio hoặc Visual Studio Build Tool (chỉ dành cho Windows)

\* PyTorch CI sử dụng Visual C++ BuildTools, đi kèm với Visual Studio Enterprise,
Professional hoặc Community Editions. Bạn cũng có thể cài build tools từ
https://visualstudio.microsoft.com/visual-cpp-build-tools/. Build tools *không* đi kèm với Visual Studio Code theo mặc định.

Ví dụ thiết lập môi trường như sau:

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

##### Hỗ trợ NVIDIA CUDA
Nếu bạn muốn biên dịch với hỗ trợ CUDA, [chọn phiên bản CUDA được hỗ trợ từ ma trận hỗ trợ của chúng tôi](https://pytorch.org/get-started/locally/), sau đó cài đặt:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 trở lên
- [Trình biên dịch](https://gist.github.com/ax3l/9489132) tương thích với CUDA

Lưu ý: Bạn có thể tham khảo [cuDNN Support Matrix](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) để biết các phiên bản cuDNN tương thích với các phiên bản CUDA, driver CUDA và phần cứng NVIDIA khác nhau

Nếu muốn tắt hỗ trợ CUDA, xuất biến môi trường `USE_CUDA=0`.
Các biến môi trường hữu ích khác có thể được tìm thấy trong `setup.py`.

Nếu bạn đang biên dịch cho nền tảng Jetson của NVIDIA (Jetson Nano, TX1, TX2, AGX Xavier), hướng dẫn cài đặt PyTorch cho Jetson Nano có [tại đây](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### Hỗ trợ AMD ROCm
Nếu muốn biên dịch với hỗ trợ ROCm, hãy cài đặt
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 trở lên
- ROCm hiện chỉ hỗ trợ hệ thống Linux.

Mặc định, hệ thống build mong đợi ROCm được cài tại `/opt/rocm`. Nếu ROCm được cài ở thư mục khác, biến môi trường `ROCM_PATH` phải được đặt về thư mục cài đặt ROCm. Hệ thống build tự động nhận diện kiến trúc GPU AMD. Tuỳ chọn, kiến trúc GPU AMD có thể được đặt rõ ràng bằng biến môi trường `PYTORCH_ROCM_ARCH` [Kiến trúc GPU AMD](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

Nếu muốn tắt hỗ trợ ROCm, xuất biến môi trường `USE_ROCM=0`.
Các biến môi trường hữu ích khác có thể được tìm thấy trong `setup.py`.

##### Hỗ trợ GPU Intel
Nếu muốn biên dịch với hỗ trợ GPU Intel, thực hiện các bước sau
- [Yêu cầu PyTorch cho GPU Intel](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html).
- GPU Intel được hỗ trợ trên Linux và Windows.

Nếu muốn tắt hỗ trợ GPU Intel, xuất biến môi trường `USE_XPU=0`.
Các biến môi trường hữu ích khác có thể được tìm thấy trong `setup.py`.

#### Lấy mã nguồn PyTorch
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# nếu bạn đang cập nhật một bản checkout đã có
git submodule sync
git submodule update --init --recursive
```

#### Cài đặt các phụ thuộc

**Chung**

```bash
conda install cmake ninja
# Chạy lệnh này trong thư mục PyTorch sau khi clone mã nguồn theo mục “Lấy mã nguồn PyTorch” phía trên
pip install -r requirements.txt
```

**Trên Linux**

```bash
pip install mkl-static mkl-include
# Chỉ CUDA: Thêm hỗ trợ LAPACK cho GPU nếu cần
# cài đặt magma: chạy với môi trường conda đang hoạt động. chỉ định phiên bản CUDA để cài
.ci/docker/common/install_magma_conda.sh 12.4

# (tùy chọn) Nếu sử dụng torch.compile với inductor/triton, cài phiên bản triton tương ứng
# Chạy từ thư mục pytorch sau khi clone
# Đối với GPU Intel, hãy xuất rõ ràng `export USE_XPU=1` trước khi chạy lệnh.
make triton
```

**Trên MacOS**

```bash
# Chỉ thêm gói này trên máy x86 Intel
pip install mkl-static mkl-include
# Thêm các gói này nếu cần torch.distributed
conda install pkg-config libuv
```

**Trên Windows**

```bash
pip install mkl-static mkl-include
# Thêm các gói này nếu cần torch.distributed.
# Hỗ trợ package distributed trên Windows là tính năng thử nghiệm và có thể thay đổi.
conda install -c conda-forge libuv=1.39
```

#### Cài đặt PyTorch
**Trên Linux**

Nếu bạn biên dịch cho AMD ROCm, hãy chạy lệnh này trước:
```bash
# Chỉ chạy nếu biên dịch cho ROCm
python tools/amd_build/build_amd.py
```

Cài đặt PyTorch
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**Trên macOS**

```bash
python3 setup.py develop
```

**Trên Windows**

Nếu bạn muốn build mã Python cũ, vui lòng xem [Xây dựng trên mã cũ và CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**Chỉ build CPU**

Ở chế độ này, các phép tính PyTorch sẽ chạy trên CPU của bạn, không sử dụng GPU.

```cmd
python setup.py develop
```

Lưu ý về OpenMP: Phiên bản OpenMP mong muốn là Intel OpenMP (iomp). Để liên kết với iomp, bạn cần tự tải thư viện về và thiết lập môi trường build bằng cách chỉnh `CMAKE_INCLUDE_PATH` và `LIB`. Hướng dẫn [tại đây](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) là ví dụ để thiết lập cả MKL và Intel OpenMP. Nếu không cấu hình cho CMake, runtime OpenMP của Microsoft Visual C (vcomp) sẽ được sử dụng.

**Build dựa trên CUDA**

Ở chế độ này, các phép tính PyTorch sẽ tận dụng GPU thông qua CUDA để tính toán nhanh hơn

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) cần thiết để build PyTorch với CUDA.
NVTX là một phần của bộ CUDA, có tên "Nsight Compute". Để cài đặt nó vào CUDA đã cài, hãy chạy cài đặt CUDA một lần nữa và chọn checkbox tương ứng.
Đảm bảo CUDA với Nsight Compute được cài sau Visual Studio.

Hiện tại, VS 2017 / 2019, và Ninja được hỗ trợ làm generator của CMake. Nếu tìm thấy `ninja.exe` trong `PATH`, Ninja sẽ được dùng mặc định, nếu không sẽ dùng VS 2017 / 2019.
<br/> Nếu Ninja được chọn làm generator, MSVC mới nhất sẽ được chọn làm toolchain.

Các thư viện bổ sung như
[Magma](https://developer.nvidia.com/magma), [oneDNN, còn gọi là MKLDNN hoặc DNNL](https://github.com/oneapi-src/oneDNN), và [Sccache](https://github.com/mozilla/sccache) thường cần thiết. Tham khảo [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) để cài đặt chúng.

Bạn có thể tham khảo script [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) để biết các cấu hình biến môi trường khác


```cmd
cmd

:: Đặt biến môi trường sau khi đã tải và giải nén gói mkl,
:: nếu không CMake sẽ báo lỗi `Could NOT find OpenMP`.
set CMAKE_INCLUDE_PATH={Your directory}\mkl\include
set LIB={Your directory}\mkl\lib;%LIB%

:: Đọc kỹ nội dung phần trước khi tiếp tục.
:: [Tùy chọn] Nếu bạn muốn ghi đè toolset sử dụng bởi Ninja và Visual Studio với CUDA, hãy chạy khối lệnh sau.
:: "Visual Studio 2019 Developer Command Prompt" sẽ được chạy tự động.
:: Đảm bảo bạn có CMake >= 3.12 khi sử dụng Visual Studio generator.
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [Tùy chọn] Nếu muốn ghi đè CUDA host compiler
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Build GPU Intel**

Ở chế độ này PyTorch sẽ được build với hỗ trợ GPU Intel.

Đảm bảo [các yêu cầu chung](#prerequisites) cũng như [yêu cầu cho GPU Intel](#intel-gpu-support) đã được cài đặt và cấu hình biến môi trường trước khi bắt đầu build. Đối với công cụ build, yêu cầu `Visual Studio 2022`.

Sau đó có thể build PyTorch với lệnh:

```cmd
:: Lệnh CMD:
:: Đặt CMAKE_PREFIX_PATH để giúp tìm các package tương ứng
:: %CONDA_PREFIX% chỉ hoạt động sau khi `conda activate custom_env`

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### Điều chỉnh tuỳ chọn biên dịch (Tùy chọn)

Bạn có thể điều chỉnh cấu hình các biến cmake (mà không cần build trước), ví dụ, chỉnh lại đường dẫn phát hiện cho CuDNN hoặc BLAS.

Trên Linux
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # hoặc cmake-gui build
```

Trên macOS
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # hoặc cmake-gui build
```

### Docker Image

#### Sử dụng image dựng sẵn

Bạn cũng có thể tải image docker dựng sẵn từ Docker Hub và chạy với docker v19.03+

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

Lưu ý rằng PyTorch sử dụng shared memory để chia sẻ dữ liệu giữa các tiến trình, nên nếu sử dụng torch multiprocessing (ví dụ cho data loader đa luồng) thì shared memory mặc định container chạy không đủ, bạn nên tăng kích thước shared memory với tuỳ chọn dòng lệnh `--ipc=host` hoặc `--shm-size` cho `nvidia-docker run`.

#### Tự dựng image

**LƯU Ý:** Phải được dựng với phiên bản docker > 18.06

`Dockerfile` được cung cấp để build image với hỗ trợ CUDA 11.1 và cuDNN v8.
Bạn có thể truyền biến make `PYTHON_VERSION=x.y` để chỉ định phiên bản Python dùng cho Miniconda, hoặc để mặc định.

```bash
make -f docker.Makefile
# các image sẽ được tag là docker.io/${your_docker_username}/pytorch
```

Bạn cũng có thể truyền biến môi trường `CMAKE_VARS="..."` để chỉ định các biến CMake bổ sung khi build.
Xem [setup.py](./setup.py) để biết danh sách các biến khả dụng.

```bash
make -f docker.Makefile
```

### Biên dịch tài liệu

Để biên dịch tài liệu ở nhiều định dạng, bạn cần [Sphinx](http://www.sphinx-doc.org)
và pytorch_sphinx_theme2.

Trước khi biên dịch tài liệu cục bộ, đảm bảo `torch` đã được
cài vào môi trường của bạn. Với các sửa lỗi nhỏ, bạn có thể cài
bản nightly như mô tả ở [Bắt đầu sử dụng](https://pytorch.org/get-started/locally/).

Với các sửa lớn, như thêm module mới và docstrings cho module đó, bạn có thể cần cài torch [từ mã nguồn](#from-source).
Xem [Hướng dẫn Docstring](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)
cho quy tắc docstring.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

Chạy `make` để xem tất cả các định dạng đầu ra khả dụng.

Nếu gặp lỗi katex, chạy `npm install katex`.  Nếu vẫn còn, thử
`npm install -g katex`

> [!LƯU Ý]
> Nếu bạn cài `nodejs` qua một trình quản lý gói khác (ví dụ,
> `conda`) thì `npm` có thể cài một phiên bản `katex` không tương thích với phiên bản `nodejs` của bạn khiến biên dịch tài liệu bị lỗi.
> Một tổ hợp phiên bản hoạt động là `node@6.13.1` và
> `katex@0.13.18`. Để cài bản này với `npm` chạy
> ```npm install -g katex@0.13.18```

> [!LƯU Ý]
> Nếu gặp lỗi không tương thích numpy, chạy:
> ```
> pip install 'numpy<2'
> ```

Khi bạn thay đổi các phụ thuộc được CI chạy, hãy chỉnh file
`.ci/docker/requirements-docs.txt`.

#### Biên dịch PDF

Để biên dịch PDF của toàn bộ tài liệu PyTorch, đảm bảo bạn đã cài
`texlive` và LaTeX. Trên macOS, bạn có thể cài bằng:

```
brew install --cask mactex
```

Để tạo PDF:

1. Chạy:

   ```
   make latexpdf
   ```

   Lệnh này sẽ sinh các file cần thiết trong thư mục `build/latex`.

2. Chuyển đến thư mục này và thực thi:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   Lệnh này sẽ tạo `pytorch.pdf` với nội dung mong muốn. Chạy lại
   lệnh này một lần nữa để tạo bảng mục lục và chỉ mục chính xác.

> [!LƯU Ý]
> Để xem bảng mục lục, chuyển sang chế độ **Table of Contents**
> trên trình xem PDF của bạn.


### Các phiên bản trước đây

Hướng dẫn cài đặt và các gói nhị phân cho các phiên bản PyTorch trước đây có thể tìm thấy
trên [website của chúng tôi](https://pytorch.org/get-started/previous-versions).


## Bắt đầu sử dụng

Ba mục tiêu giúp bạn bắt đầu:
- [Hướng dẫn: giúp bạn hiểu và sử dụng PyTorch](https://pytorch.org/tutorials/)
- [Ví dụ: mã PyTorch dễ hiểu ở mọi lĩnh vực](https://github.com/pytorch/examples)
- [Tham khảo API](https://pytorch.org/docs/)
- [Thuật ngữ](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## Tài nguyên

* [PyTorch.org](https://pytorch.org/)
* [Hướng dẫn PyTorch](https://pytorch.org/tutorials/)
* [Ví dụ PyTorch](https://github.com/pytorch/examples)
* [Các mô hình PyTorch](https://pytorch.org/hub/)
* [Giới thiệu về Deep Learning với PyTorch từ Udacity](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Giới thiệu về Machine Learning với PyTorch từ Udacity](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Deep Neural Networks with PyTorch từ Coursera](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [PyTorch Blog](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## Trao đổi
* Diễn đàn: Thảo luận về triển khai, nghiên cứu, v.v. https://discuss.pytorch.org
* GitHub Issues: Báo lỗi, yêu cầu tính năng, vấn đề cài đặt, RFC, ý kiến, v.v.
* Slack: [PyTorch Slack](https://pytorch.slack.com/) dành cho người dùng và nhà phát triển PyTorch trung cấp đến cao cấp cho trò chuyện, thảo luận online, cộng tác, v.v. Nếu bạn là người mới cần trợ giúp, nên dùng [Diễn đàn PyTorch](https://discuss.pytorch.org). Nếu bạn cần thư mời Slack, vui lòng điền vào form: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* Bản tin: Email một chiều với thông báo quan trọng về PyTorch. Đăng ký tại đây: https://eepurl.com/cbG0rv
* Facebook Page: Thông báo quan trọng về PyTorch. https://www.facebook.com/pytorch
* Để biết hướng dẫn thương hiệu, vui lòng truy cập website tại [pytorch.org](https://pytorch.org/)

## Phát hành và đóng góp

Thông thường, PyTorch có ba bản phát hành nhỏ mỗi năm. Vui lòng thông báo cho chúng tôi nếu bạn gặp lỗi bằng cách [tạo issue](https://github.com/pytorch/pytorch/issues).

Chúng tôi trân trọng mọi đóng góp. Nếu bạn định đóng góp bản sửa lỗi, hãy thực hiện mà không cần thảo luận thêm.

Nếu bạn định đóng góp tính năng mới, hàm tiện ích hoặc mở rộng lõi, vui lòng mở issue trước và thảo luận với chúng tôi.
Gửi PR mà không thảo luận có thể bị từ chối nếu chúng tôi đang phát triển theo hướng khác mà bạn chưa biết.

Để tìm hiểu thêm về đóng góp cho PyTorch, vui lòng xem [Trang đóng góp](CONTRIBUTING.md). Để biết thêm thông tin về các bản phát hành PyTorch, xem [Trang phát hành](RELEASE.md).

## Nhóm phát triển

PyTorch là dự án cộng đồng với nhiều kỹ sư và nhà nghiên cứu tài năng đóng góp.

Hiện tại PyTorch được duy trì bởi [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang), và [Nikita Shulga](https://github.com/malfet) cùng sự đóng góp lớn từ hàng trăm cá nhân xuất sắc với nhiều hình thức khác nhau.
Danh sách dưới đây không đầy đủ nhưng đang mở rộng, gồm: [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito).

Lưu ý: Dự án này không liên quan đến [hughperkins/pytorch](https://github.com/hughperkins/pytorch) cùng tên. Hugh là cộng tác viên giá trị cho cộng đồng Torch và đã giúp đỡ nhiều việc liên quan Torch và PyTorch.

## Giấy phép

PyTorch sử dụng giấy phép kiểu BSD, chi tiết trong file [LICENSE](LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---