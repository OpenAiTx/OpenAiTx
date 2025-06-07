![PyTorch Logo](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch — это пакет на Python, предоставляющий две основные возможности:
- Вычисления с тензорами (аналогично NumPy) с мощным ускорением на GPU
- Глубокие нейронные сети, построенные на системе автодифференцирования с использованием ленты

Вы можете повторно использовать ваши любимые Python-пакеты, такие как NumPy, SciPy и Cython, чтобы расширять возможности PyTorch по мере необходимости.

Сигналы здоровья основной ветки (Continuous Integration) можно найти на [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main).

<!-- toc -->

- [Подробнее о PyTorch](#more-about-pytorch)
  - [Тензорная библиотека с поддержкой GPU](#a-gpu-ready-tensor-library)
  - [Динамические нейронные сети: автодифференцирование на основе ленты](#dynamic-neural-networks-tape-based-autograd)
  - [Python — в первую очередь](#python-first)
  - [Императивный опыт](#imperative-experiences)
  - [Быстрый и компактный](#fast-and-lean)
  - [Расширения без боли](#extensions-without-pain)
- [Установка](#installation)
  - [Бинарные файлы](#binaries)
    - [Платформы NVIDIA Jetson](#nvidia-jetson-platforms)
  - [Сборка из исходников](#from-source)
    - [Необходимые компоненты](#prerequisites)
      - [Поддержка NVIDIA CUDA](#nvidia-cuda-support)
      - [Поддержка AMD ROCm](#amd-rocm-support)
      - [Поддержка Intel GPU](#intel-gpu-support)
    - [Получение исходников PyTorch](#get-the-pytorch-source)
    - [Установка зависимостей](#install-dependencies)
    - [Установка PyTorch](#install-pytorch)
      - [Настройка параметров сборки (опционально)](#adjust-build-options-optional)
  - [Образы Docker](#docker-image)
    - [Использование готовых образов](#using-pre-built-images)
    - [Сборка образа самостоятельно](#building-the-image-yourself)
  - [Сборка документации](#building-the-documentation)
    - [Создание PDF](#building-a-pdf)
  - [Предыдущие версии](#previous-versions)
- [Начало работы](#getting-started)
- [Ресурсы](#resources)
- [Коммуникация](#communication)
- [Выпуски и вклад](#releases-and-contributing)
- [Команда](#the-team)
- [Лицензия](#license)

<!-- tocstop -->

## Подробнее о PyTorch

[Изучить основы PyTorch](https://pytorch.org/tutorials/beginner/basics/intro.html)

На низком уровне PyTorch — это библиотека, состоящая из следующих компонентов:

| Компонент | Описание |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | Тензорная библиотека, аналогичная NumPy, с поддержкой GPU |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | Библиотека автоматического дифференцирования на основе ленты, поддерживающая все дифференцируемые операции с тензорами в torch |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | Стек компиляции (TorchScript) для создания сериализуемых и оптимизируемых моделей из кода PyTorch |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | Библиотека нейронных сетей, глубоко интегрированная с autograd, обеспечивающая максимальную гибкость |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Многопроцессорность Python, но с магическим совместным использованием памяти тензоров между процессами. Полезно для загрузки данных и обучения методом Hogwild |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader и другие вспомогательные функции для удобства |

Обычно PyTorch используется как:

- Замена NumPy для использования мощности GPU.
- Платформа для исследований в области глубокого обучения, обеспечивающая максимальную гибкость и скорость.

Подробнее:

### Тензорная библиотека с поддержкой GPU

Если вы используете NumPy, то вы уже работали с тензорами (также известными как ndarray).

![Tensor illustration](./docs/source/_static/img/tensor_illustration.png)

PyTorch предоставляет тензоры, которые могут находиться как на CPU, так и на GPU, и значительно ускоряет вычисления.

Мы предоставляем широкий спектр рутин для работы с тензорами, чтобы ускорить и адаптировать ваши научные вычисления: срезы, индексация, математические операции, линейная алгебра, редукции.
И всё это — быстро!

### Динамические нейронные сети: автодифференцирование на основе ленты

В PyTorch реализован уникальный способ построения нейронных сетей: использование и воспроизведение "ленточного магнитофона".

Большинство фреймворков, таких как TensorFlow, Theano, Caffe и CNTK, имеют статичный взгляд на мир.
Необходимо построить нейронную сеть и многократно использовать одну и ту же структуру.
Изменение поведения сети требует полной перестройки с нуля.

В PyTorch используется техника обратного автоматического дифференцирования, которая позволяет изменять поведение вашей сети произвольно, без задержек и накладных расходов. Наше вдохновение пришло из нескольких научных публикаций по этой теме, а также из существующих и прошлых проектов, таких как
[torch-autograd](https://github.com/twitter/torch-autograd),
[autograd](https://github.com/HIPS/autograd),
[Chainer](https://chainer.org) и др.

Хотя эта техника не уникальна для PyTorch, здесь реализована одна из самых быстрых её версий на сегодняшний день.
Вы получаете лучшее сочетание скорости и гибкости для своих исследований.

![Dynamic graph](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python — в первую очередь

PyTorch — это не просто Python-обёртка вокруг монолитного C++ фреймворка.
Он создан для глубокой интеграции с Python.
Вы можете использовать его так же естественно, как [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) и др.
Вы можете писать новые слои нейронных сетей непосредственно на Python, используя любимые библиотеки
и такие пакеты, как [Cython](https://cython.org/) и [Numba](http://numba.pydata.org/).
Наша цель — не изобретать велосипед там, где это не требуется.

### Императивный опыт

PyTorch создан для интуитивного, линейного и простого в использовании подхода.
Когда вы выполняете строку кода, она действительно выполняется. Нет асинхронного представления мира.
Когда вы используете отладчик или получаете сообщения об ошибках и трассировки стека, их легко понять.
Трассировка указывает на то место, где был определён ваш код.
Мы надеемся, что вы никогда не потратите часы на отладку из-за плохих трассировок или асинхронных и непрозрачных движков выполнения.

### Быстрый и компактный

PyTorch имеет минимальные накладные расходы фреймворка. Мы интегрируем библиотеки ускорения
такие как [Intel MKL](https://software.intel.com/mkl) и NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)), чтобы максимизировать скорость.
В основе лежат зрелые и проверенные временем бэкенды для тензоров и нейронных сетей на CPU и GPU.

Поэтому PyTorch очень быстр — независимо от размера вашей нейронной сети.

Использование памяти в PyTorch чрезвычайно эффективно по сравнению с Torch или некоторыми альтернативами.
Мы написали собственные распределители памяти для GPU, чтобы ваши модели глубокого обучения были максимально эффективны по памяти.
Это позволяет обучать более крупные модели, чем раньше.

### Расширения без боли

Создание новых модулей нейронных сетей или интеграция с API тензоров PyTorch были разработаны максимально простыми и с минимальным уровнем абстракции.

Вы можете писать новые слои нейронных сетей на Python, используя API torch
[или ваши любимые библиотеки на базе NumPy, такие как SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html).

Если вы хотите писать свои слои на C/C++, мы предоставляем удобный API расширений, который эффективен и требует минимума шаблонного кода.
Не нужно писать обёртки. См. [учебник здесь](https://pytorch.org/tutorials/advanced/cpp_extension.html) и [пример здесь](https://github.com/pytorch/extension-cpp).


## Установка

### Бинарные файлы
Команды для установки бинарных файлов через Conda или pip wheels представлены на нашем сайте: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)


#### Платформы NVIDIA Jetson

Python-колёса для NVIDIA Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX и Jetson AGX Orin доступны [здесь](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048), а контейнер L4T опубликован [здесь](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)

Требуется JetPack 4.2 и выше, поддержкой занимаются [@dusty-nv](https://github.com/dusty-nv) и [@ptrblck](https://github.com/ptrblck).


### Сборка из исходников

#### Необходимые компоненты
Если вы собираете из исходников, вам понадобится:
- Python 3.9 или новее
- Компилятор с полной поддержкой C++17, например clang или gcc (требуется gcc 9.4.0 или новее для Linux)
- Visual Studio или Visual Studio Build Tool (только для Windows)

\* PyTorch CI использует Visual C++ BuildTools, которые идут в составе Visual Studio Enterprise,
Professional или Community Editions. Вы также можете установить build tools с
https://visualstudio.microsoft.com/visual-cpp-build-tools/. Build tools *не входят*
в Visual Studio Code по умолчанию.

Пример настройки окружения:

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

##### Поддержка NVIDIA CUDA
Если вы хотите компилировать с поддержкой CUDA, [выберите поддерживаемую версию CUDA из нашей матрицы поддержки](https://pytorch.org/get-started/locally/), затем установите следующее:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 или выше
- [Компилятор](https://gist.github.com/ax3l/9489132), совместимый с CUDA

Примечание: Вы можете обратиться к [cuDNN Support Matrix](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) для сопоставления версий cuDNN, CUDA, драйверов и оборудования NVIDIA

Если вы хотите отключить поддержку CUDA, экспортируйте переменную окружения `USE_CUDA=0`.
Другие полезные переменные окружения можно найти в `setup.py`.

Если вы собираете для платформ NVIDIA Jetson (Jetson Nano, TX1, TX2, AGX Xavier), инструкция по установке PyTorch для Jetson Nano [доступна здесь](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### Поддержка AMD ROCm
Если вы хотите компилировать с поддержкой ROCm, установите
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 и выше
- ROCm поддерживается только в Linux.

По умолчанию build system ожидает, что ROCm установлен в `/opt/rocm`. Если ROCm установлен в другом каталоге, переменная окружения `ROCM_PATH` должна указывать на каталог установки ROCm. Build system автоматически определяет архитектуру AMD GPU. Опционально, архитектуру AMD GPU можно явно указать через переменную окружения `PYTORCH_ROCM_ARCH` [AMD GPU architecture](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

Если вы хотите отключить поддержку ROCm, экспортируйте переменную окружения `USE_ROCM=0`.
Другие полезные переменные окружения можно найти в `setup.py`.

##### Поддержка Intel GPU
Если вы хотите компилировать с поддержкой Intel GPU, выполните следующие шаги:
- Следуйте инструкции [PyTorch Prerequisites for Intel GPUs](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html).
- Intel GPU поддерживается для Linux и Windows.

Если вы хотите отключить поддержку Intel GPU, экспортируйте переменную окружения `USE_XPU=0`.
Другие полезные переменные окружения можно найти в `setup.py`.

#### Получение исходников PyTorch
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# если вы обновляете существующий репозиторий
git submodule sync
git submodule update --init --recursive
```

#### Установка зависимостей

**Общие**

```bash
conda install cmake ninja
# Запустите эту команду из каталога PyTorch после клонирования исходного кода, как указано выше
pip install -r requirements.txt
```

**В Linux**

```bash
pip install mkl-static mkl-include
# Только для CUDA: Добавьте поддержку LAPACK для GPU при необходимости
# Установка magma: выполните в активированной среде conda, укажите версию CUDA
.ci/docker/common/install_magma_conda.sh 12.4

# (опционально) Если используется torch.compile с inductor/triton, установите подходящую версию triton
# Запустите из каталога pytorch после клонирования
# Для поддержки Intel GPU, явно выполните `export USE_XPU=1` перед запуском команды.
make triton
```

**В MacOS**

```bash
# Добавьте этот пакет только на машинах с процессором intel x86
pip install mkl-static mkl-include
# Добавьте эти пакеты, если требуется torch.distributed
conda install pkg-config libuv
```

**В Windows**

```bash
pip install mkl-static mkl-include
# Добавьте эти пакеты, если требуется torch.distributed.
# Поддержка distributed пакета в Windows является экспериментальной и может изменяться.
conda install -c conda-forge libuv=1.39
```

#### Установка PyTorch
**В Linux**

Если вы компилируете для AMD ROCm, сначала выполните эту команду:
```bash
# Выполняйте только если собираете для ROCm
python tools/amd_build/build_amd.py
```

Установите PyTorch
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**В macOS**

```bash
python3 setup.py develop
```

**В Windows**

Если вы хотите собрать устаревший python-код, пожалуйста, обратитесь к [Building on legacy code and CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**Сборки только для CPU**

В этом режиме вычисления PyTorch будут выполняться на CPU, а не на GPU.

```cmd
python setup.py develop
```

Примечание по OpenMP: Предпочтительная реализация OpenMP — Intel OpenMP (iomp). Чтобы подключить iomp, вам потребуется вручную скачать библиотеку и настроить окружение для сборки через переменные `CMAKE_INCLUDE_PATH` и `LIB`. Инструкция [здесь](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) является примером настройки MKL и Intel OpenMP. Без этих настроек для CMake будет использоваться Microsoft Visual C OpenMP runtime (vcomp).

**Сборка с поддержкой CUDA**

В этом режиме вычисления PyTorch будут использовать ваш GPU через CUDA для ускорения вычислений.

Для сборки PyTorch с CUDA требуется [NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm).
NVTX входит в состав CUDA и называется "Nsight Compute". Чтобы установить его в уже установленную CUDA, выполните повторную установку CUDA и отметьте нужный пункт.
Убедитесь, что CUDA с Nsight Compute установлена после Visual Studio.

В настоящее время поддерживаются VS 2017 / 2019 и Ninja как генераторы CMake. Если `ninja.exe` найден в `PATH`, то Ninja будет использоваться по умолчанию, иначе — VS 2017 / 2019.
<br/> Если выбран Ninja, будет использоваться последняя версия MSVC как инструментальная цепочка.

Часто требуются дополнительные библиотеки:
[Magma](https://developer.nvidia.com/magma), [oneDNN, также известная как MKLDNN или DNNL](https://github.com/oneapi-src/oneDNN), и [Sccache](https://github.com/mozilla/sccache). См. [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) для их установки.

Вы можете также обратиться к скрипту [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) для настройки других переменных окружения


```cmd
cmd

:: Установите переменные окружения после загрузки и распаковки пакета mkl,
:: иначе CMake выдаст ошибку `Could NOT find OpenMP`.
set CMAKE_INCLUDE_PATH={Ваш каталог}\mkl\include
set LIB={Ваш каталог}\mkl\lib;%LIB%

:: Внимательно прочитайте предыдущий раздел перед продолжением.
:: [Опционально] Если хотите переопределить инструментальную цепочку Ninja и Visual Studio с CUDA, выполните следующий скрипт.
:: "Visual Studio 2019 Developer Command Prompt" будет запущен автоматически.
:: Убедитесь, что у вас установлена CMake >= 3.12 при использовании генератора Visual Studio.
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [Опционально] Если хотите переопределить компилятор-хост CUDA
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Сборка для Intel GPU**

В этом режиме будет собран PyTorch с поддержкой Intel GPU.

Убедитесь, что [общие требования](#prerequisites), а также [требования для Intel GPU](#intel-gpu-support) установлены и переменные окружения настроены. Для сборки требуется `Visual Studio 2022`.

Затем PyTorch можно собрать командой:

```cmd
:: Команды CMD:
:: Установите CMAKE_PREFIX_PATH для поиска соответствующих пакетов
:: %CONDA_PREFIX% работает только после `conda activate custom_env`

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### Настройка параметров сборки (опционально)

Вы можете опционально настроить переменные cmake (без сборки), выполнив следующее. Например, можно настроить пути к каталогам CuDNN или BLAS.

В Linux
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # или cmake-gui build
```

В macOS
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # или cmake-gui build
```

### Образы Docker

#### Использование готовых образов

Вы также можете скачать готовый docker-образ из Docker Hub и запустить с docker v19.03+

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

Обратите внимание, что PyTorch использует общую память для передачи данных между процессами, поэтому если используется torch multiprocessing (например, для многопоточной загрузки данных), размер сегмента общей памяти по умолчанию в контейнере недостаточен, и его следует увеличить с помощью параметров `--ipc=host` или `--shm-size` в командной строке для `nvidia-docker run`.

#### Сборка образа самостоятельно

**ПРИМЕЧАНИЕ:** Требуется версия docker > 18.06

`Dockerfile` предоставлен для сборки образов с поддержкой CUDA 11.1 и cuDNN v8.
Вы можете передать переменную сборки `PYTHON_VERSION=x.y`, чтобы указать, какую версию Python использовать в Miniconda, либо не указывать и использовать версию по умолчанию.

```bash
make -f docker.Makefile
# образы маркируются как docker.io/${your_docker_username}/pytorch
```

Вы также можете передать переменную среды `CMAKE_VARS="..."` для указания дополнительных переменных CMake, которые будут переданы во время сборки.
См. [setup.py](./setup.py) для списка доступных переменных.

```bash
make -f docker.Makefile
```

### Сборка документации

Для сборки документации в различных форматах потребуется [Sphinx](http://www.sphinx-doc.org)
и pytorch_sphinx_theme2.

Перед локальной сборкой документации убедитесь, что `torch` установлен в вашем окружении. Для мелких правок можно установить ночную версию, как описано в [Getting Started](https://pytorch.org/get-started/locally/).

Для более сложных изменений, например, добавления нового модуля и docstring для него, возможно, потребуется установить torch [из исходников](#from-source).
См. [Docstring Guidelines](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)
для стандартов docstring.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

Выполните `make`, чтобы получить список всех доступных форматов вывода.

Если появляется ошибка katex, выполните `npm install katex`.  Если не помогает, попробуйте
`npm install -g katex`

> [!ПРИМЕЧАНИЕ]
> Если вы устанавливали `nodejs` с помощью другого пакетного менеджера (например,
> `conda`), то `npm`, скорее всего, установит версию `katex`, несовместимую с вашей версией `nodejs`, и сборка документации завершится с ошибкой.
> Известно, что работает комбинация `node@6.13.1` и
> `katex@0.13.18`. Для установки последнего выполните:
> ```npm install -g katex@0.13.18```

> [!ПРИМЕЧАНИЕ]
> Если появляется ошибка несовместимости numpy, выполните:
> ```
> pip install 'numpy<2'
> ```

При изменении зависимостей, используемых в CI, редактируйте
файл `.ci/docker/requirements-docs.txt`.

#### Создание PDF

Для компиляции PDF со всей документацией PyTorch убедитесь, что у вас установлены
`texlive` и LaTeX. В macOS можно установить их с помощью:

```
brew install --cask mactex
```

Для создания PDF:

1. Выполните:

   ```
   make latexpdf
   ```

   Это сгенерирует необходимые файлы в каталоге `build/latex`.

2. Перейдите в этот каталог и выполните:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   Это создаст файл `pytorch.pdf` с нужным содержанием. Выполните команду ещё раз, чтобы сгенерировать корректное оглавление и индекс.

> [!ПРИМЕЧАНИЕ]
> Для просмотра оглавления переключитесь в режим **Table of Contents**
> в вашей PDF-читалке.


### Предыдущие версии

Инструкции по установке и бинарные файлы для предыдущих версий PyTorch доступны
[на нашем сайте](https://pytorch.org/get-started/previous-versions).


## Начало работы

Три ссылки для быстрого старта:
- [Учебники: начните с изучения и использования PyTorch](https://pytorch.org/tutorials/)
- [Примеры: простой и понятный код PyTorch для всех областей](https://github.com/pytorch/examples)
- [API Reference](https://pytorch.org/docs/)
- [Глоссарий](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## Ресурсы

* [PyTorch.org](https://pytorch.org/)
* [Учебники PyTorch](https://pytorch.org/tutorials/)
* [Примеры PyTorch](https://github.com/pytorch/examples)
* [Модели PyTorch](https://pytorch.org/hub/)
* [Введение в глубокое обучение с PyTorch от Udacity](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Введение в машинное обучение с PyTorch от Udacity](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Глубокие нейронные сети с PyTorch на Coursera](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [PyTorch Blog](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## Коммуникация
* Форумы: обсуждение реализаций, исследований и др. https://discuss.pytorch.org
* GitHub Issues: сообщения об ошибках, запросы новых функций, проблемы с установкой, RFC, идеи и др.
* Slack: [PyTorch Slack](https://pytorch.slack.com/) предназначен для опытных пользователей и разработчиков PyTorch для общего чата, обсуждений, коллабораций и т.д. Новичкам рекомендуется [форум PyTorch](https://discuss.pytorch.org). Для приглашения в Slack заполните форму: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* Рассылка: только важные объявления о PyTorch, без спама. Подписаться можно здесь: https://eepurl.com/cbG0rv
* Страница в Facebook: важные объявления о PyTorch. https://www.facebook.com/pytorch
* Для ознакомления с руководством по бренду посетите наш сайт [pytorch.org](https://pytorch.org/)

## Выпуски и вклад

Обычно PyTorch выпускает три минорные версии в год. Если вы обнаружили ошибку, пожалуйста, [создайте issue](https://github.com/pytorch/pytorch/issues).

Мы ценим любой вклад. Если вы планируете внести исправления ошибок, делайте это без предварительного обсуждения.

Если вы планируете добавить новые функции, утилиты или расширения ядра, сначала откройте issue и обсудите с нами вашу идею.
Отправка PR без обсуждения может привести к его отклонению, если ваша идея не соответствует текущему направлению развития ядра.

Подробнее о том, как внести вклад в PyTorch, см. [Contribution page](CONTRIBUTING.md). Подробнее о выпусках PyTorch — на [Release page](RELEASE.md).

## Команда

PyTorch — проект, развиваемый сообществом, в который вносят вклад множество инженеров и исследователей.

В настоящее время PyTorch поддерживается [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang) и [Nikita Shulga](https://github.com/malfet), а также сотнями талантливых людей в различных формах и проявлениях.
В числе многих стоит отметить: [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito).

Примечание: этот проект не связан с [hughperkins/pytorch](https://github.com/hughperkins/pytorch) с тем же именем. Хью — ценный участник сообщества Torch и помогал во многих вещах, связанных с Torch и PyTorch.

## Лицензия

PyTorch распространяется по лицензии BSD, как указано в файле [LICENSE](LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---