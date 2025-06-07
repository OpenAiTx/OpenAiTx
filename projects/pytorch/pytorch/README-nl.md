![PyTorch Logo](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch is een Python-pakket dat twee belangrijke kenmerken biedt:
- Tensor-berekeningen (zoals NumPy) met krachtige GPU-versnelling
- Diepe neurale netwerken gebouwd op een tape-gebaseerd autograd-systeem

Je kunt je favoriete Python-pakketten zoals NumPy, SciPy en Cython hergebruiken om PyTorch uit te breiden wanneer nodig.

Onze trunk health (Continuous Integration-signalen) zijn te vinden op [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main).

<!-- toc -->

- [Meer Over PyTorch](#meer-over-pytorch)
  - [Een GPU-Klare Tensorbibliotheek](#een-gpu-klare-tensorbibliotheek)
  - [Dynamische Neurale Netwerken: Tape-Based Autograd](#dynamische-neurale-netwerken-tape-based-autograd)
  - [Python Eerst](#python-eerst)
  - [Imperatieve Ervaringen](#imperatieve-ervaringen)
  - [Snel en Lichtgewicht](#snel-en-lichtgewicht)
  - [Uitbreidingen Zonder Pijn](#uitbreidingen-zonder-pijn)
- [Installatie](#installatie)
  - [Binaries](#binaries)
    - [NVIDIA Jetson Platformen](#nvidia-jetson-platformen)
  - [Vanuit Broncode](#vanuit-broncode)
    - [Vereisten](#vereisten)
      - [NVIDIA CUDA Ondersteuning](#nvidia-cuda-ondersteuning)
      - [AMD ROCm Ondersteuning](#amd-rocm-ondersteuning)
      - [Intel GPU Ondersteuning](#intel-gpu-ondersteuning)
    - [Download de PyTorch Broncode](#download-de-pytorch-broncode)
    - [Installeer Afhankelijkheden](#installeer-afhankelijkheden)
    - [Installeer PyTorch](#installeer-pytorch)
      - [Aanpassen van Build Opties (Optioneel)](#aanpassen-van-build-opties-optioneel)
  - [Docker Image](#docker-image)
    - [Gebruik van vooraf gebouwde images](#gebruik-van-vooraf-gebouwde-images)
    - [Image zelf bouwen](#image-zelf-bouwen)
  - [Documentatie Bouwen](#documentatie-bouwen)
    - [PDF Bouwen](#pdf-bouwen)
  - [Vorige Versies](#vorige-versies)
- [Aan de slag](#aan-de-slag)
- [Bronnen](#bronnen)
- [Communicatie](#communicatie)
- [Releases en Bijdragen](#releases-en-bijdragen)
- [Het Team](#het-team)
- [Licentie](#licentie)

<!-- tocstop -->

## Meer Over PyTorch

[Leer de basis van PyTorch](https://pytorch.org/tutorials/beginner/basics/intro.html)

Op gedetailleerd niveau is PyTorch een bibliotheek die bestaat uit de volgende componenten:

| Component | Beschrijving |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | Een Tensor-bibliotheek zoals NumPy, met sterke GPU-ondersteuning |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | Een tape-gebaseerde automatische differentiatiebibliotheek die alle differentieerbare Tensor-operaties in torch ondersteunt |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | Een compilatiestack (TorchScript) om seraliseerbare en optimaliseerbare modellen te creëren vanuit PyTorch-code  |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | Een neurale netwerken-bibliotheek diep geïntegreerd met autograd, ontworpen voor maximale flexibiliteit |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Python multiprocessing, maar met magisch geheugen delen van torch Tensors tussen processen. Handig voor dataloading en Hogwild training |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader en andere handige hulpfuncties |

Meestal wordt PyTorch gebruikt als:

- Een vervanging voor NumPy om de kracht van GPU's te benutten.
- Een deep learning onderzoeksplatform dat maximale flexibiliteit en snelheid biedt.

Uitgebreidere uitleg:

### Een GPU-Klare Tensorbibliotheek

Als je NumPy gebruikt, heb je Tensors (ook wel ndarray genoemd) gebruikt.

![Tensor illustratie](./docs/source/_static/img/tensor_illustration.png)

PyTorch biedt Tensors die zowel op de CPU als op de GPU kunnen draaien en versnelt
de berekening aanzienlijk.

We bieden een breed scala aan tensor-routines om je wetenschappelijke berekeningsbehoeften te versnellen en te ondersteunen, zoals slicing, indexering, wiskundige operaties, lineaire algebra, reducties.
En ze zijn snel!

### Dynamische Neurale Netwerken: Tape-Based Autograd

PyTorch heeft een unieke manier om neurale netwerken te bouwen: door het gebruik van en het afspelen van een bandrecorder.

De meeste frameworks zoals TensorFlow, Theano, Caffe en CNTK hebben een statische kijk op de wereld.
Je moet een neuraal netwerk bouwen en steeds dezelfde structuur opnieuw gebruiken.
Als je het gedrag van het netwerk wilt veranderen, moet je helemaal opnieuw beginnen.

Met PyTorch gebruiken we een techniek die reverse-mode auto-differentiation heet, waarmee je het gedrag van je netwerk willekeurig kunt aanpassen zonder vertraging of overhead. Onze inspiratie komt
van verschillende onderzoeksartikelen over dit onderwerp, evenals huidig en vorig werk zoals
[torch-autograd](https://github.com/twitter/torch-autograd),
[autograd](https://github.com/HIPS/autograd),
[Chainer](https://chainer.org), enz.

Hoewel deze techniek niet uniek is voor PyTorch, is het een van de snelste implementaties tot nu toe.
Je krijgt het beste van snelheid en flexibiliteit voor je wilde onderzoeksdoelen.

![Dynamisch graaf](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python Eerst

PyTorch is geen Python-binding voor een monolithisch C++-framework.
Het is gebouwd om diep geïntegreerd te zijn in Python.
Je kunt het op een natuurlijke manier gebruiken, zoals je [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) zou gebruiken.
Je kunt je nieuwe neurale netwerk-lagen direct in Python schrijven, met je favoriete bibliotheken
en pakketten zoals [Cython](https://cython.org/) en [Numba](http://numba.pydata.org/).
Ons doel is om het wiel niet opnieuw uit te vinden waar dat niet nodig is.

### Imperatieve Ervaringen

PyTorch is ontworpen om intuïtief, lineair in denken en eenvoudig in gebruik te zijn.
Wanneer je een regel code uitvoert, wordt deze uitgevoerd. Er is geen asynchroon wereldbeeld.
Wanneer je een debugger gebruikt of foutmeldingen en stacktraces ontvangt, zijn deze gemakkelijk te begrijpen.
De stacktrace wijst precies naar waar je code is gedefinieerd.
We hopen dat je nooit uren hoeft te besteden aan het debuggen van je code door slechte stacktraces of asynchrone en ondoorzichtige uitvoering-engines.

### Snel en Lichtgewicht

PyTorch heeft minimale framework overhead. We integreren versnellingsbibliotheken
zoals [Intel MKL](https://software.intel.com/mkl) en NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)) om snelheid te maximaliseren.
In de kern zijn de CPU- en GPU-Tensor- en neurale netwerkbackends
volwassen en al jarenlang getest.

PyTorch is dus erg snel — of je nu kleine of grote neurale netwerken draait.

Het geheugengebruik in PyTorch is extreem efficiënt in vergelijking met Torch of sommige alternatieven.
We hebben aangepaste geheugenallocators voor de GPU geschreven om ervoor te zorgen dat
je deep learning modellen maximaal geheugenefficiënt zijn.
Hierdoor kun je grotere deep learning modellen trainen dan voorheen.

### Uitbreidingen Zonder Pijn

Het schrijven van nieuwe neurale netwerkmodules, of het koppelen aan de Tensor-API van PyTorch, is ontworpen om eenvoudig en met minimale abstracties te zijn.

Je kunt nieuwe neurale netwerk-lagen schrijven in Python met behulp van de torch API
[of je favoriete op NumPy gebaseerde bibliotheken zoals SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html).

Als je je lagen in C/C++ wilt schrijven, bieden we een handige extension API die efficiënt is en minimale boilerplate vereist.
Er hoeft geen wrapper-code te worden geschreven. Zie [een tutorial hier](https://pytorch.org/tutorials/advanced/cpp_extension.html) en [een voorbeeld hier](https://github.com/pytorch/extension-cpp).


## Installatie

### Binaries
Commando’s om binaries te installeren via Conda of pip wheels staan op onze website: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)


#### NVIDIA Jetson Platformen

Python wheels voor NVIDIA's Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX, en Jetson AGX Orin zijn [hier](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) beschikbaar en de L4T-container wordt gepubliceerd [hier](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)

Ze vereisen JetPack 4.2 en hoger, en [@dusty-nv](https://github.com/dusty-nv) en [@ptrblck](https://github.com/ptrblck) onderhouden deze.

### Vanuit Broncode

#### Vereisten
Als je vanuit broncode installeert, heb je nodig:
- Python 3.9 of hoger
- Een compiler die volledig C++17 ondersteunt, zoals clang of gcc (gcc 9.4.0 of nieuwer is vereist op Linux)
- Visual Studio of Visual Studio Build Tool (alleen Windows)

\* PyTorch CI gebruikt Visual C++ BuildTools, die bij Visual Studio Enterprise,
Professional, of Community Editions worden geleverd. Je kunt de build tools ook installeren via
https://visualstudio.microsoft.com/visual-cpp-build-tools/. De build tools worden *niet*
standaard meegeleverd met Visual Studio Code.

Een voorbeeld van een omgevingssetup wordt hieronder getoond:

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

##### NVIDIA CUDA Ondersteuning
Als je wilt compileren met CUDA-ondersteuning, [selecteer een ondersteunde versie van CUDA uit onze supportmatrix](https://pytorch.org/get-started/locally/), en installeer dan het volgende:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 of hoger
- [Compiler](https://gist.github.com/ax3l/9489132) compatibel met CUDA

Opmerking: Je kunt verwijzen naar de [cuDNN Support Matrix](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) voor cuDNN-versies met de verschillende ondersteunde CUDA, CUDA-driver en NVIDIA-hardware

Als je CUDA-ondersteuning wilt uitschakelen, exporteer dan de omgevingsvariabele `USE_CUDA=0`.
Andere mogelijk nuttige omgevingsvariabelen zijn te vinden in `setup.py`.

Als je bouwt voor NVIDIA's Jetson-platformen (Jetson Nano, TX1, TX2, AGX Xavier), zijn de instructies om PyTorch te installeren voor Jetson Nano [hier beschikbaar](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### AMD ROCm Ondersteuning
Als je wilt compileren met ROCm-ondersteuning, installeer dan
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 of hoger
- ROCm wordt momenteel alleen ondersteund voor Linux-systemen.

Standaard verwacht het buildsysteem dat ROCm is geïnstalleerd in `/opt/rocm`. Als ROCm in een andere map is geïnstalleerd, moet de omgevingsvariabele `ROCM_PATH` worden ingesteld op de ROCm-installatiemap. Het buildsysteem detecteert de AMD GPU-architectuur automatisch. Optioneel kan de AMD GPU-architectuur expliciet worden ingesteld met de omgevingsvariabele `PYTORCH_ROCM_ARCH` [AMD GPU architectuur](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

Als je ROCm-ondersteuning wilt uitschakelen, exporteer dan de omgevingsvariabele `USE_ROCM=0`.
Andere mogelijk nuttige omgevingsvariabelen zijn te vinden in `setup.py`.

##### Intel GPU Ondersteuning
Als je wilt compileren met Intel GPU-ondersteuning, volg dan deze
- [PyTorch Vereisten voor Intel GPU's](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html) instructies.
- Intel GPU wordt ondersteund voor Linux en Windows.

Als je Intel GPU-ondersteuning wilt uitschakelen, exporteer dan de omgevingsvariabele `USE_XPU=0`.
Andere mogelijk nuttige omgevingsvariabelen zijn te vinden in `setup.py`.

#### Download de PyTorch Broncode
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# als je een bestaande checkout bijwerkt
git submodule sync
git submodule update --init --recursive
```

#### Installeer Afhankelijkheden

**Algemeen**

```bash
conda install cmake ninja
# Voer dit commando uit in de PyTorch-map nadat je de broncode hebt gekloond met het gedeelte “Download de PyTorch Broncode” hierboven
pip install -r requirements.txt
```

**Op Linux**

```bash
pip install mkl-static mkl-include
# Alleen CUDA: Voeg LAPACK-ondersteuning voor de GPU toe indien nodig
# magma installatie: voer uit met actieve conda-omgeving. Specificeer CUDA-versie om te installeren
.ci/docker/common/install_magma_conda.sh 12.4

# (optioneel) Als je torch.compile gebruikt met inductor/triton, installeer de bijpassende versie van triton
# Voer uit vanuit de pytorch-map na het klonen
# Voor Intel GPU-ondersteuning, graag expliciet `export USE_XPU=1` uitvoeren voor dit commando.
make triton
```

**Op MacOS**

```bash
# Voeg dit pakket toe op Intel x86-processormachines
pip install mkl-static mkl-include
# Voeg deze pakketten toe als torch.distributed nodig is
conda install pkg-config libuv
```

**Op Windows**

```bash
pip install mkl-static mkl-include
# Voeg deze pakketten toe als torch.distributed nodig is.
# Distributed package support op Windows is een prototypefunctie en kan veranderen.
conda install -c conda-forge libuv=1.39
```

#### Installeer PyTorch
**Op Linux**

Als je compileert voor AMD ROCm voer dan eerst dit commando uit:
```bash
# Alleen uitvoeren als je compileert voor ROCm
python tools/amd_build/build_amd.py
```

Installeer PyTorch
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**Op macOS**

```bash
python3 setup.py develop
```

**Op Windows**

Als je legacy python-code wilt bouwen, raadpleeg dan [Building on legacy code and CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**Alleen CPU-builds**

In deze modus draaien PyTorch-berekeningen op je CPU, niet op je GPU.

```cmd
python setup.py develop
```

Opmerking over OpenMP: De gewenste OpenMP-implementatie is Intel OpenMP (iomp). Om te linken tegen iomp, moet je de bibliotheek handmatig downloaden en de buildomgeving instellen door `CMAKE_INCLUDE_PATH` en `LIB` aan te passen. De instructie [hier](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) is een voorbeeld voor het instellen van zowel MKL als Intel OpenMP. Zonder deze CMake-configuraties wordt Microsoft Visual C OpenMP-runtime (vcomp) gebruikt.

**CUDA-gebaseerde build**

In deze modus maken PyTorch-berekeningen gebruik van je GPU via CUDA voor snellere nummerverwerking

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) is nodig om Pytorch met CUDA te bouwen.
NVTX is onderdeel van de CUDA-distributie, waar het "Nsight Compute" heet. Om het te installeren op een reeds geïnstalleerde CUDA, voer de CUDA-installatie opnieuw uit en vink het juiste selectievakje aan.
Zorg dat CUDA met Nsight Compute is geïnstalleerd na Visual Studio.

Momenteel worden VS 2017 / 2019, en Ninja ondersteund als generator voor CMake. Als `ninja.exe` wordt gedetecteerd in `PATH`, wordt Ninja gebruikt als standaardgenerator, anders wordt VS 2017 / 2019 gebruikt.
<br/> Als Ninja is geselecteerd als generator, wordt de nieuwste MSVC geselecteerd als de onderliggende toolchain.

Aanvullende bibliotheken zoals
[Magma](https://developer.nvidia.com/magma), [oneDNN, ook bekend als MKLDNN of DNNL](https://github.com/oneapi-src/oneDNN), en [Sccache](https://github.com/mozilla/sccache) zijn vaak nodig. Raadpleeg de [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) om ze te installeren.

Je kunt verwijzen naar het [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) script voor andere omgevingsvariabelenconfiguraties.


```cmd
cmd

:: Stel de omgevingsvariabelen in nadat je het mkl-pakket hebt gedownload en uitgepakt,
:: anders geeft CMake een fout als `Could NOT find OpenMP`.
set CMAKE_INCLUDE_PATH={Je map}\mkl\include
set LIB={Je map}\mkl\lib;%LIB%

:: Lees de inhoud in het vorige gedeelte zorgvuldig voordat je doorgaat.
:: [Optioneel] Als je de onderliggende toolset voor Ninja en Visual Studio met CUDA wilt overschrijven, voer dan het volgende scriptblok uit.
:: "Visual Studio 2019 Developer Command Prompt" wordt automatisch uitgevoerd.
:: Zorg dat je CMake >= 3.12 hebt voordat je dit doet als je de Visual Studio-generator gebruikt.
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [Optioneel] Als je de CUDA host compiler wilt overschrijven
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Intel GPU builds**

In deze modus wordt PyTorch met Intel GPU-ondersteuning gebouwd.

Zorg dat [de algemene vereisten](#vereisten) evenals [de vereisten voor Intel GPU](#intel-gpu-ondersteuning) correct zijn geïnstalleerd en de omgevingsvariabelen zijn geconfigureerd voordat je begint met bouwen. Voor ondersteuning van build tools is `Visual Studio 2022` vereist.

Daarna kan PyTorch worden gebouwd met het commando:

```cmd
:: CMD Commando's:
:: Stel de CMAKE_PREFIX_PATH in om de juiste pakketten te vinden
:: %CONDA_PREFIX% werkt alleen na `conda activate custom_env`

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### Aanpassen van Build Opties (Optioneel)

Je kunt de configuratie van CMake-variabelen optioneel aanpassen (zonder eerst te bouwen) door het volgende te doen. Bijvoorbeeld het aanpassen van de vooraf gedetecteerde mappen voor CuDNN of BLAS kan zo worden gedaan.

Op Linux
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # of cmake-gui build
```

Op macOS
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # of cmake-gui build
```

### Docker Image

#### Gebruik van vooraf gebouwde images

Je kunt ook een vooraf gebouwde docker image van Docker Hub halen en draaien met docker v19.03+

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

Let op: PyTorch gebruikt gedeeld geheugen om data tussen processen te delen, dus als torch multiprocessing wordt gebruikt (bijv.
voor multithreaded data loaders) is het standaardgedeelde geheugensegment dat de container gebruikt niet groot genoeg, en moet je de grootte van het gedeelde geheugen verhogen met de `--ipc=host` of `--shm-size` commandoregelopties voor `nvidia-docker run`.

#### Image zelf bouwen

**OPMERKING:** Moet worden gebouwd met een docker-versie > 18.06

Het `Dockerfile` wordt meegeleverd om images te bouwen met CUDA 11.1-ondersteuning en cuDNN v8.
Je kunt de `PYTHON_VERSION=x.y` make-variabele meegeven om de gewenste Python-versie te specificeren voor Miniconda, of deze leeg laten om de standaard te gebruiken.

```bash
make -f docker.Makefile
# images worden getagd als docker.io/${your_docker_username}/pytorch
```

Je kunt ook de omgevingsvariabele `CMAKE_VARS="..."` doorgeven om extra CMake-variabelen te specificeren die aan CMake worden doorgegeven tijdens het bouwen.
Zie [setup.py](./setup.py) voor de lijst met beschikbare variabelen.

```bash
make -f docker.Makefile
```

### Documentatie Bouwen

Om documentatie in verschillende formaten te bouwen, heb je [Sphinx](http://www.sphinx-doc.org)
en het pytorch_sphinx_theme2 nodig.

Voordat je de documentatie lokaal bouwt, zorg dat `torch` is
geïnstalleerd in je omgeving. Voor kleine aanpassingen kun je de
nightly versie installeren zoals beschreven in [Aan de slag](https://pytorch.org/get-started/locally/).

Voor meer complexe aanpassingen, zoals het toevoegen van een nieuw module en docstrings voor
de nieuwe module, moet je mogelijk torch [vanuit broncode installeren](#vanuit-broncode).
Zie [Docstring Guidelines](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)
voor docstring conventies.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

Voer `make` uit om een lijst te krijgen van alle beschikbare uitvoerformaten.

Als je een katex-fout krijgt, voer dan `npm install katex` uit.  Als het blijft aanhouden, probeer dan
`npm install -g katex`

> [!OPMERKING]
> Als je `nodejs` met een andere pakketmanager hebt geïnstalleerd (bijv.
> `conda`) dan zal `npm` waarschijnlijk een versie van `katex` installeren die niet
> compatibel is met je versie van `nodejs` en zullen doc builds mislukken.
> Een combinatie van versies die werkt is `node@6.13.1` en
> `katex@0.13.18`. Om laatstgenoemde met `npm` te installeren kun je uitvoeren
> ```npm install -g katex@0.13.18```

> [!OPMERKING]
> Als je een numpy-incompatibiliteitsfout ziet, voer uit:
> ```
> pip install 'numpy<2'
> ```

Als je wijzigingen aanbrengt in de afhankelijkheden die door CI worden uitgevoerd, bewerk dan het bestand
`.ci/docker/requirements-docs.txt`.

#### PDF Bouwen

Om een PDF van alle PyTorch-documentatie te compileren, zorg dat je
`texlive` en LaTeX hebt geïnstalleerd. Op macOS kun je deze installeren met:

```
brew install --cask mactex
```

Om de PDF te maken:

1. Voer uit:

   ```
   make latexpdf
   ```

   Dit genereert de benodigde bestanden in de map `build/latex`.

2. Navigeer naar deze map en voer uit:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   Dit produceert een `pytorch.pdf` met de gewenste inhoud. Voer dit
   commando nogmaals uit zodat de juiste inhoudsopgave
   en index worden gegenereerd.

> [!OPMERKING]
> Om de inhoudsopgave te bekijken, schakel over naar de **Inhoudsopgave**
> weergave in je PDF-lezer.


### Vorige Versies

Installatie-instructies en binaries voor eerdere PyTorch-versies zijn te vinden
op [onze website](https://pytorch.org/get-started/previous-versions).


## Aan de slag

Drie startpunten om je op weg te helpen:
- [Tutorials: helpen je op weg met het begrijpen en gebruiken van PyTorch](https://pytorch.org/tutorials/)
- [Voorbeelden: gemakkelijk te begrijpen PyTorch-code in alle domeinen](https://github.com/pytorch/examples)
- [De API Referentie](https://pytorch.org/docs/)
- [Woordenlijst](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## Bronnen

* [PyTorch.org](https://pytorch.org/)
* [PyTorch Tutorials](https://pytorch.org/tutorials/)
* [PyTorch Voorbeelden](https://github.com/pytorch/examples)
* [PyTorch Modellen](https://pytorch.org/hub/)
* [Intro tot Deep Learning met PyTorch van Udacity](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Intro tot Machine Learning met PyTorch van Udacity](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Diepe Neurale Netwerken met PyTorch van Coursera](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [PyTorch Blog](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## Communicatie
* Forums: Bespreek implementaties, onderzoek, enz. https://discuss.pytorch.org
* GitHub Issues: Bugrapporten, feature requests, installatieproblemen, RFC's, ideeën, enz.
* Slack: De [PyTorch Slack](https://pytorch.slack.com/) is vooral voor gevorderde PyTorch-gebruikers en ontwikkelaars voor algemene chat, online discussies, samenwerking, enz. Als je een beginner bent die hulp zoekt, is het primaire medium [PyTorch Forums](https://discuss.pytorch.org). Als je een slack-uitnodiging nodig hebt, vul dan dit formulier in: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* Nieuwsbrief: Geen spam, een eenzijdige e-mailnieuwsbrief met belangrijke aankondigingen over PyTorch. Je kunt je hier aanmelden: https://eepurl.com/cbG0rv
* Facebook-pagina: Belangrijke aankondigingen over PyTorch. https://www.facebook.com/pytorch
* Voor merkrichtlijnen, bezoek onze website op [pytorch.org](https://pytorch.org/)

## Releases en Bijdragen

Typisch heeft PyTorch drie kleine releases per jaar. Laat het ons weten als je een bug tegenkomt door [een issue in te dienen](https://github.com/pytorch/pytorch/issues).

We waarderen alle bijdragen. Als je van plan bent om bugfixes bij te dragen, doe dit dan zonder verdere discussie.

Als je van plan bent om nieuwe functies, hulpfuncties of extensies aan de kern toe te voegen, open dan eerst een issue en bespreek de functie met ons.
Een PR sturen zonder discussie kan resulteren in een afgewezen PR omdat we de kern mogelijk in een andere richting sturen dan je verwacht.

Meer leren over bijdragen aan Pytorch? Zie onze [Bijdragepagina](CONTRIBUTING.md). Meer informatie over PyTorch-releases vind je op de [Releasepagina](RELEASE.md).

## Het Team

PyTorch is een community-gedreven project met verschillende bekwame ingenieurs en onderzoekers die bijdragen.

PyTorch wordt momenteel onderhouden door [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang), en [Nikita Shulga](https://github.com/malfet) met grote bijdragen van honderden getalenteerde individuen in diverse vormen en middelen.
Een niet-uitputtende maar groeiende lijst noemt: [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito).

Opmerking: Dit project is niet gerelateerd aan [hughperkins/pytorch](https://github.com/hughperkins/pytorch) met dezelfde naam. Hugh is een waardevolle bijdrager aan de Torch-community en heeft veel bijgedragen aan Torch en PyTorch.

## Licentie

PyTorch heeft een BSD-achtige licentie, zoals te vinden in het [LICENSE](LICENSE) bestand.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---