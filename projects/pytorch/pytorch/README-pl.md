![Logo PyTorch](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch to pakiet Pythona, który oferuje dwie główne funkcje:
- Obliczenia tensorowe (podobnie jak NumPy) z silnym wsparciem GPU
- Głębokie sieci neuronowe zbudowane na systemie autograd opartym na taśmie

Możesz ponownie używać swoich ulubionych pakietów Pythona, takich jak NumPy, SciPy i Cython, aby rozszerzać PyTorch w razie potrzeby.

Stan głównej gałęzi (sygnały Continuous Integration) można znaleźć na [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main).

<!-- toc -->

- [Więcej o PyTorch](#more-about-pytorch)
  - [Biblioteka tensorów gotowa na GPU](#a-gpu-ready-tensor-library)
  - [Dynamiczne sieci neuronowe: Tape-Based Autograd](#dynamic-neural-networks-tape-based-autograd)
  - [Python przede wszystkim](#python-first)
  - [Doświadczenia imperatywne](#imperative-experiences)
  - [Szybki i lekki](#fast-and-lean)
  - [Rozszerzenia bez bólu](#extensions-without-pain)
- [Instalacja](#installation)
  - [Binaria](#binaries)
    - [Platformy NVIDIA Jetson](#nvidia-jetson-platforms)
  - [Ze źródeł](#from-source)
    - [Wymagania wstępne](#prerequisites)
      - [Wsparcie NVIDIA CUDA](#nvidia-cuda-support)
      - [Wsparcie AMD ROCm](#amd-rocm-support)
      - [Wsparcie GPU Intel](#intel-gpu-support)
    - [Pobierz źródła PyTorch](#get-the-pytorch-source)
    - [Instalacja zależności](#install-dependencies)
    - [Instalacja PyTorch](#install-pytorch)
      - [Dostosowywanie opcji budowania (opcjonalne)](#adjust-build-options-optional)
  - [Obraz Dockera](#docker-image)
    - [Korzystanie z gotowych obrazów](#using-pre-built-images)
    - [Budowanie obrazu samodzielnie](#building-the-image-yourself)
  - [Budowanie dokumentacji](#building-the-documentation)
    - [Budowanie PDF](#building-a-pdf)
  - [Poprzednie wersje](#previous-versions)
- [Pierwsze kroki](#getting-started)
- [Zasoby](#resources)
- [Komunikacja](#communication)
- [Wydania i kontrybucje](#releases-and-contributing)
- [Zespół](#the-team)
- [Licencja](#license)

<!-- tocstop -->

## Więcej o PyTorch

[Poznaj podstawy PyTorch](https://pytorch.org/tutorials/beginner/basics/intro.html)

Na szczegółowym poziomie, PyTorch to biblioteka składająca się z następujących komponentów:

| Komponent | Opis |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | Biblioteka Tensorów jak NumPy, z silnym wsparciem GPU |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | Biblioteka automatycznego różniczkowania oparta na taśmie, obsługująca wszystkie różniczkowalne operacje Tensorów w torch |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | Stos kompilacyjny (TorchScript) do tworzenia serializowalnych i optymalizowalnych modeli z kodu PyTorch |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | Biblioteka sieci neuronowych głęboko zintegrowana z autograd, zaprojektowana dla maksymalnej elastyczności |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Multiprocessing w Pythonie, ale z magicznym współdzieleniem pamięci Tensorów torch między procesami. Przydatne do ładowania danych i treningu Hogwild |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader oraz inne funkcje pomocnicze dla wygody |

PyTorch jest zwykle używany jako:

- Zamiennik NumPy do korzystania z mocy GPU.
- Platforma badawcza deep learning zapewniająca maksymalną elastyczność i szybkość.

Szczegóły:

### Biblioteka tensorów gotowa na GPU

Jeśli używasz NumPy, to już korzystałeś z Tensorów (czyli ndarray).

![Ilustracja tensora](./docs/source/_static/img/tensor_illustration.png)

PyTorch dostarcza Tensory, które mogą działać zarówno na CPU, jak i GPU, znacznie przyspieszając obliczenia.

Oferujemy szeroki wachlarz operacji na tensorach, które przyspieszają i dostosowują się do Twoich potrzeb obliczeń naukowych, takich jak cięcie (slicing), indeksowanie, operacje matematyczne, algebra liniowa, redukcje.
I są szybkie!

### Dynamiczne sieci neuronowe: Tape-Based Autograd

PyTorch ma unikalny sposób budowy sieci neuronowych: wykorzystując i odtwarzając rejestrator taśmy.

Większość frameworków, takich jak TensorFlow, Theano, Caffe i CNTK, ma statyczny obraz świata.
Trzeba zbudować sieć neuronową i używać tej samej struktury wielokrotnie.
Zmiana zachowania sieci oznacza konieczność rozpoczęcia od nowa.

W PyTorch używamy techniki zwanej automatycznym różniczkowaniem w trybie odwrotnym (reverse-mode auto-differentiation), która pozwala dowolnie zmieniać zachowanie sieci bez opóźnień i narzutu. Inspirację czerpaliśmy z kilku prac naukowych na ten temat, jak również z obecnych i przeszłych rozwiązań, takich jak [torch-autograd](https://github.com/twitter/torch-autograd), [autograd](https://github.com/HIPS/autograd), [Chainer](https://chainer.org) itd.

Choć ta technika nie jest unikalna dla PyTorch, jest to jedna z najszybszych jej implementacji.
Otrzymujesz najlepsze połączenie szybkości i elastyczności dla swoich najbardziej wymagających badań.

![Dynamiczny graf](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python przede wszystkim

PyTorch nie jest tylko powiązaniem Pythona z monolitycznym frameworkiem C++.
Jest zbudowany tak, by być głęboko zintegrowany z Pythonem.
Możesz używać go naturalnie, jak [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) itd.
Możesz pisać nowe warstwy sieci neuronowych w samym Pythonie, używając swoich ulubionych bibliotek
i korzystać z pakietów takich jak [Cython](https://cython.org/) i [Numba](http://numba.pydata.org/).
Naszym celem jest nie wymyślać koła na nowo tam, gdzie to niepotrzebne.

### Doświadczenia imperatywne

PyTorch został zaprojektowany, by być intuicyjnym, logicznym i łatwym w użyciu.
Gdy wykonujesz linię kodu, ona się wykonuje. Nie ma asynchronicznego obrazu świata.
Gdy korzystasz z debuggera lub otrzymujesz komunikaty błędów i stack trace, ich zrozumienie jest proste.
Stack trace wskazuje dokładnie, gdzie Twój kod został zdefiniowany.
Mamy nadzieję, że nigdy nie spędzisz godzin na debugowaniu kodu przez złe stack trace lub asynchroniczne i nieprzejrzyste silniki wykonawcze.

### Szybki i lekki

PyTorch ma minimalny narzut frameworka. Integrujemy biblioteki przyspieszające
takie jak [Intel MKL](https://software.intel.com/mkl) oraz NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)), aby zmaksymalizować szybkość.
Rdzeniem są dojrzałe i przetestowane przez lata backendy tensorów CPU i GPU oraz sieci neuronowych.

Dlatego PyTorch jest bardzo szybki — niezależnie czy uruchamiasz małe, czy duże sieci neuronowe.

Zużycie pamięci w PyTorch jest niezwykle wydajne w porównaniu do Torch lub niektórych alternatyw.
Napisaliśmy własne alokatory pamięci dla GPU, aby zapewnić maksymalną efektywność pamięciową Twoich modeli deep learning.
Pozwala to trenować większe modele niż dotychczas.

### Rozszerzenia bez bólu

Pisanie nowych modułów sieci neuronowych lub interfejsowanie z API Tensorów PyTorch zostało zaprojektowane tak, by było proste i z minimalnym poziomem abstrakcji.

Możesz pisać nowe warstwy sieci neuronowych w Pythonie, korzystając z API torch [lub swoich ulubionych bibliotek opartych na NumPy, takich jak SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html).

Jeśli chcesz napisać swoje warstwy w C/C++, zapewniamy wygodne i wydajne API rozszerzeń z minimalną ilością kodu szablonowego.
Nie trzeba pisać kodu opakowującego. Przykład znajdziesz [w tym tutorialu](https://pytorch.org/tutorials/advanced/cpp_extension.html) i [tutaj](https://github.com/pytorch/extension-cpp).


## Instalacja

### Binaria
Polecenia do instalacji binariów przez Conda lub pip wheels znajdują się na naszej stronie: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)

#### Platformy NVIDIA Jetson

Koła Pythona dla NVIDIA Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX oraz Jetson AGX Orin są dostępne [tutaj](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048), a kontener L4T jest publikowany [tutaj](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)

Wymagają JetPack 4.2 lub nowszego, a [@dusty-nv](https://github.com/dusty-nv) oraz [@ptrblck](https://github.com/ptrblck) je utrzymują.


### Ze źródeł

#### Wymagania wstępne
Jeśli instalujesz ze źródeł, będziesz potrzebować:
- Python 3.9 lub nowszy
- Kompilator z pełnym wsparciem C++17, taki jak clang lub gcc (wymagany gcc 9.4.0 lub nowszy na Linuksie)
- Visual Studio lub Visual Studio Build Tool (tylko Windows)

\* PyTorch CI używa Visual C++ BuildTools, które są dostępne z Visual Studio Enterprise, Professional lub Community. Możesz także zainstalować build tools ze strony https://visualstudio.microsoft.com/visual-cpp-build-tools/. Build tools *nie są* domyślnie dostępne z Visual Studio Code.

Przykład konfiguracji środowiska poniżej:

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

##### Wsparcie NVIDIA CUDA
Jeśli chcesz kompilować ze wsparciem CUDA, [wybierz wspieraną wersję CUDA z naszej tabeli wsparcia](https://pytorch.org/get-started/locally/), a następnie zainstaluj:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 lub nowszy
- [Kompilator](https://gist.github.com/ax3l/9489132) kompatybilny z CUDA

Uwaga: Możesz sprawdzić [tabelę wsparcia cuDNN](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) dla wersji cuDNN kompatybilnych z różnymi wersjami CUDA, sterowników CUDA i sprzętu NVIDIA.

Jeśli chcesz wyłączyć wsparcie CUDA, ustaw zmienną środowiskową `USE_CUDA=0`.
Inne przydatne zmienne środowiskowe znajdują się w `setup.py`.

Jeśli budujesz dla platform NVIDIA Jetson (Jetson Nano, TX1, TX2, AGX Xavier), instrukcje instalacji PyTorch dla Jetson Nano są [tutaj](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### Wsparcie AMD ROCm
Jeśli chcesz kompilować ze wsparciem ROCm, zainstaluj
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 lub nowszy
- ROCm jest obecnie wspierany tylko na systemach Linux.

Domyślnie system budowania oczekuje instalacji ROCm w `/opt/rocm`. Jeśli ROCm jest zainstalowany w innym katalogu, ustaw zmienną środowiskową `ROCM_PATH` na katalog instalacji ROCm. System budowania automatycznie wykrywa architekturę GPU AMD. Opcjonalnie architekturę GPU AMD można ustawić jawnie przez zmienną `PYTORCH_ROCM_ARCH` [architektura GPU AMD](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

Aby wyłączyć wsparcie ROCm, ustaw zmienną środowiskową `USE_ROCM=0`.
Inne przydatne zmienne środowiskowe znajdują się w `setup.py`.

##### Wsparcie GPU Intel
Aby kompilować ze wsparciem GPU Intel, postępuj według:
- [Instrukcji wstępnych dla GPU Intel](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html).
- GPU Intel jest wspierany na systemach Linux i Windows.

Aby wyłączyć wsparcie GPU Intel, ustaw zmienną środowiskową `USE_XPU=0`.
Inne przydatne zmienne środowiskowe znajdują się w `setup.py`.

#### Pobierz źródła PyTorch
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# jeśli aktualizujesz już istniejące repozytorium
git submodule sync
git submodule update --init --recursive
```

#### Instalacja zależności

**Wspólne**

```bash
conda install cmake ninja
# Wykonaj to polecenie w katalogu PyTorch po sklonowaniu źródeł sekcją „Pobierz źródła PyTorch“
pip install -r requirements.txt
```

**Na Linuksie**

```bash
pip install mkl-static mkl-include
# Tylko CUDA: dodaj wsparcie LAPACK dla GPU jeśli potrzebne
# instalacja magma: uruchom z aktywnym środowiskiem conda, określ wersję CUDA do instalacji
.ci/docker/common/install_magma_conda.sh 12.4

# (opcjonalnie) Jeśli używasz torch.compile z inductor/triton, zainstaluj pasującą wersję triton
# Uruchom z katalogu pytorch po sklonowaniu
# Dla wsparcia GPU Intel, jawnie `export USE_XPU=1` przed uruchomieniem polecenia.
make triton
```

**Na MacOS**

```bash
# Dodaj ten pakiet tylko na maszynach z procesorem intel x86
pip install mkl-static mkl-include
# Dodaj te pakiety jeśli potrzebny jest torch.distributed
conda install pkg-config libuv
```

**Na Windows**

```bash
pip install mkl-static mkl-include
# Dodaj te pakiety jeśli potrzebny jest torch.distributed.
# Wsparcie dla distributed na Windows to funkcja prototypowa i może ulec zmianie.
conda install -c conda-forge libuv=1.39
```

#### Instalacja PyTorch
**Na Linuksie**

Jeśli kompilujesz dla AMD ROCm, najpierw uruchom to polecenie:
```bash
# Uruchom tylko jeśli kompilujesz dla ROCm
python tools/amd_build/build_amd.py
```

Instalacja PyTorch
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**Na macOS**

```bash
python3 setup.py develop
```

**Na Windows**

Jeśli chcesz budować legacy python code, zobacz [Building on legacy code and CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**Budowa tylko CPU**

W tym trybie obliczenia PyTorch będą wykonywane na CPU, a nie na GPU.

```cmd
python setup.py develop
```

Uwaga dotycząca OpenMP: Preferowana implementacja OpenMP to Intel OpenMP (iomp). Aby się do niej podłączyć, musisz ręcznie pobrać bibliotekę i dostosować środowisko budowania przez ustawienie `CMAKE_INCLUDE_PATH` i `LIB`. Instrukcja [tutaj](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) jest przykładem ustawienia zarówno MKL, jak i Intel OpenMP. Bez tej konfiguracji CMake użyje domyślnego środowiska uruchomieniowego OpenMP Microsoft Visual C (vcomp).

**Budowa z CUDA**

W tym trybie obliczenia PyTorch będą wykorzystywać GPU przez CUDA dla szybszego przetwarzania liczb.

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) jest wymagane do budowy PyTorch z CUDA.
NVTX jest częścią dystrybucji CUDA, gdzie nazywa się "Nsight Compute". Aby zainstalować go do już zainstalowanej CUDA, uruchom instalator CUDA ponownie i zaznacz odpowiednie pole.
Upewnij się, że CUDA z Nsight Compute została zainstalowana po Visual Studio.

Aktualnie VS 2017 / 2019 oraz Ninja są wspierane jako generator CMake. Jeśli `ninja.exe` jest wykryty w `PATH`, Ninja zostanie użyty jako domyślny generator, w przeciwnym razie będzie to VS 2017 / 2019.
<br/> Jeśli Ninja zostanie wybrany jako generator, najnowszy MSVC zostanie wybrany jako narzędzie kompilujące.

Często wymagane są dodatkowe biblioteki, takie jak
[Magma](https://developer.nvidia.com/magma), [oneDNN, czyli MKLDNN lub DNNL](https://github.com/oneapi-src/oneDNN), oraz [Sccache](https://github.com/mozilla/sccache). Zobacz [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) jak je zainstalować.

Możesz zobaczyć skrypt [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) dla innych konfiguracji zmiennych środowiskowych


```cmd
cmd

:: Ustaw zmienne środowiskowe po pobraniu i rozpakowaniu pakietu mkl,
:: w przeciwnym razie CMake zgłosi błąd `Could NOT find OpenMP`.
set CMAKE_INCLUDE_PATH={Twój katalog}\mkl\include
set LIB={Twój katalog}\mkl\lib;%LIB%

:: Przeczytaj uważnie poprzednią sekcję przed kontynuacją.
:: [Opcjonalnie] Jeśli chcesz nadpisać narzędzia Ninja i Visual Studio dla CUDA, uruchom poniższy blok skryptu.
:: "Visual Studio 2019 Developer Command Prompt" zostanie uruchomiony automatycznie.
:: Upewnij się, że masz CMake >= 3.12 przy użyciu generatora Visual Studio.
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [Opcjonalnie] Jeśli chcesz nadpisać kompilator hosta CUDA
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Budowa GPU Intel**

W tym trybie zostanie zbudowany PyTorch ze wsparciem GPU Intel.

Upewnij się, że [wspólne wymagania wstępne](#prerequisites) oraz [wymagania dla GPU Intel](#intel-gpu-support) są poprawnie zainstalowane, a zmienne środowiskowe skonfigurowane przed rozpoczęciem budowy. Do wsparcia narzędzi budowania wymagany jest `Visual Studio 2022`.

Następnie PyTorch można zbudować poleceniem:

```cmd
:: Polecenia CMD:
:: Ustaw CMAKE_PREFIX_PATH aby ułatwić znajdowanie odpowiednich pakietów
:: %CONDA_PREFIX% działa tylko po `conda activate custom_env`

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### Dostosowywanie opcji budowania (opcjonalnie)

Możesz opcjonalnie dostosować konfigurację zmiennych cmake (bez wcześniejszego budowania), wykonując poniższe kroki. Na przykład, dostosowanie wykrytych katalogów CuDNN lub BLAS można przeprowadzić w ten sposób.

Na Linuksie
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # lub cmake-gui build
```

Na macOS
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # lub cmake-gui build
```

### Obraz Dockera

#### Korzystanie z gotowych obrazów

Możesz również pobrać gotowy obraz dockera z Docker Hub i uruchomić go za pomocą docker v19.03+

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

Zwróć uwagę, że PyTorch używa współdzielonej pamięci do wymiany danych między procesami, więc jeśli korzystasz z torch multiprocessing (np. wielowątkowe ładowanie danych), domyślny rozmiar segmentu współdzielonej pamięci w kontenerze jest niewystarczający i należy go zwiększyć opcjami `--ipc=host` lub `--shm-size` w poleceniu `nvidia-docker run`.

#### Budowanie obrazu samodzielnie

**UWAGA:** Musisz zbudować obraz na dockerze w wersji > 18.06

Dołączony `Dockerfile` pozwala zbudować obrazy ze wsparciem CUDA 11.1 oraz cuDNN v8.
Możesz przekazać zmienną `PYTHON_VERSION=x.y`, by wskazać wersję Pythona używaną przez Minicondę, lub pozostawić ją domyślną.

```bash
make -f docker.Makefile
# obrazy są tagowane jako docker.io/${twoja_nazwa_użytkownika_dockera}/pytorch
```

Możesz też przekazać zmienną środowiskową `CMAKE_VARS="..."`, by określić dodatkowe zmienne CMake przekazywane do CMake podczas budowania.
Zobacz [setup.py](./setup.py) po listę dostępnych zmiennych.

```bash
make -f docker.Makefile
```

### Budowanie dokumentacji

Aby budować dokumentację w różnych formatach, potrzebujesz [Sphinx](http://www.sphinx-doc.org)
oraz pytorch_sphinx_theme2.

Przed lokalnym budowaniem dokumentacji upewnij się, że `torch` jest
zainstalowany w Twoim środowisku. Dla drobnych poprawek możesz zainstalować
wersję nightly zgodnie z opisem w [Pierwsze kroki](https://pytorch.org/get-started/locally/).

Dla bardziej złożonych poprawek, takich jak dodanie nowego modułu i docstringów,
może być konieczna instalacja torch [ze źródeł](#from-source).
Zobacz [Wytyczne dotyczące docstringów](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)
dla konwencji docstringów.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

Uruchom `make`, aby zobaczyć listę wszystkich dostępnych formatów wyjściowych.

Jeśli pojawi się błąd katex, uruchom `npm install katex`. Jeśli nadal występuje, spróbuj
`npm install -g katex`

> [!UWAGA]
> Jeśli zainstalowałeś `nodejs` innym menedżerem pakietów (np.
> `conda`), to `npm` prawdopodobnie zainstaluje wersję `katex` niekompatybilną z Twoją wersją `nodejs` i budowanie dokumentacji się nie powiedzie.
> Znana, działająca kombinacja to `node@6.13.1` i
> `katex@0.13.18`. Aby zainstalować tę wersję przez `npm` uruchom
> ```npm install -g katex@0.13.18```

> [!UWAGA]
> Jeśli pojawia się błąd niekompatybilności numpy, uruchom:
> ```
> pip install 'numpy<2'
> ```

Kiedy wprowadzasz zmiany w zależnościach uruchamianych przez CI, edytuj plik
`.ci/docker/requirements-docs.txt`.

#### Budowanie PDF

Aby wygenerować PDF całej dokumentacji PyTorch, upewnij się, że masz
`texlive` oraz LaTeX. Na macOS można je zainstalować przez:

```
brew install --cask mactex
```

Aby utworzyć PDF:

1. Uruchom:

   ```
   make latexpdf
   ```

   To wygeneruje niezbędne pliki w katalogu `build/latex`.

2. Przejdź do tego katalogu i uruchom:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   To utworzy plik `pytorch.pdf` z pożądanymi treściami. Uruchom to
   polecenie jeszcze raz, aby wygenerować prawidłowy spis treści i indeks.

> [!UWAGA]
> Aby zobaczyć spis treści, przełącz się na widok **Table of Contents**
> w przeglądarce PDF.


### Poprzednie wersje

Instrukcje instalacji i binaria dla poprzednich wersji PyTorch można znaleźć
[na naszej stronie](https://pytorch.org/get-started/previous-versions).


## Pierwsze kroki

Trzy wskazówki, jak zacząć:
- [Tutoriale: nauczą Cię korzystania i rozumienia PyTorch](https://pytorch.org/tutorials/)
- [Przykłady: łatwy do zrozumienia kod PyTorch z różnych dziedzin](https://github.com/pytorch/examples)
- [Dokumentacja API](https://pytorch.org/docs/)
- [Słowniczek](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## Zasoby

* [PyTorch.org](https://pytorch.org/)
* [Tutoriale PyTorch](https://pytorch.org/tutorials/)
* [Przykłady PyTorch](https://github.com/pytorch/examples)
* [Modele PyTorch](https://pytorch.org/hub/)
* [Intro do Deep Learning z PyTorch na Udacity](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Intro do Machine Learning z PyTorch na Udacity](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Deep Neural Networks z PyTorch na Coursera](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [PyTorch Blog](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## Komunikacja
* Forum: Dyskusje o implementacjach, badaniach itd. https://discuss.pytorch.org
* GitHub Issues: Zgłaszanie błędów, propozycje funkcjonalności, problemy z instalacją, RFC, pomysły itd.
* Slack: [PyTorch Slack](https://pytorch.slack.com/) skupia przede wszystkim średniozaawansowanych i zaawansowanych użytkowników PyTorch oraz deweloperów do ogólnego czatu, dyskusji online, współpracy itd. Jeśli jesteś początkującym użytkownikiem, głównym kanałem są [Fora PyTorch](https://discuss.pytorch.org). Jeśli potrzebujesz zaproszenia na slacka, wypełnij ten formularz: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* Newsletter: Jednokierunkowy newsletter e-mail z najważniejszymi ogłoszeniami o PyTorch. Możesz się zapisać tutaj: https://eepurl.com/cbG0rv
* Facebook Page: Ważne ogłoszenia o PyTorch. https://www.facebook.com/pytorch
* Wytyczne dotyczące marki znajdziesz na naszej stronie [pytorch.org](https://pytorch.org/)

## Wydania i kontrybucje

Zazwyczaj PyTorch ma trzy mniejsze wydania rocznie. Prosimy o zgłaszanie błędów przez [utworzenie zgłoszenia](https://github.com/pytorch/pytorch/issues).

Doceniamy wszystkie kontrybucje. Jeśli planujesz przesłać poprawki błędów, zrób to bez dodatkowej dyskusji.

Jeśli chcesz dodać nowe funkcje, funkcje pomocnicze lub rozszerzenia do core, najpierw otwórz zgłoszenie i skonsultuj funkcję z nami.
Wysyłanie PR bez dyskusji może skończyć się jego odrzuceniem, ponieważ możemy prowadzić core w innym kierunku, niż się spodziewasz.

Aby dowiedzieć się więcej o kontrybucji do PyTorch, zobacz [stronę kontrybucji](CONTRIBUTING.md). Więcej informacji o wydaniach PyTorch znajdziesz na [stronie wydań](RELEASE.md).

## Zespół

PyTorch to projekt tworzony przez społeczność, do którego przyczynia się wielu utalentowanych inżynierów i badaczy.

PyTorch jest obecnie utrzymywany przez [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang) i [Nikita Shulga](https://github.com/malfet), z dużymi kontrybucjami setek uzdolnionych osób w różnych formach.
Niewyczerpująca, ale rosnąca lista obejmuje: [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito).

Uwaga: Ten projekt nie jest powiązany z [hughperkins/pytorch](https://github.com/hughperkins/pytorch) o tej samej nazwie. Hugh jest cennym kontrybutorem społeczności Torch i pomógł w wielu aspektach Torch i PyTorch.

## Licencja

PyTorch ma licencję typu BSD, dostępną w pliku [LICENSE](LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---