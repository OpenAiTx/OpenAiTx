![PyTorch Logo](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch ist ein Python-Paket, das zwei Hauptfunktionen bereitstellt:
- Tensorberechnungen (ähnlich wie NumPy) mit starker GPU-Beschleunigung
- Tiefe neuronale Netze, die auf einem bandbasierten Autograd-System basieren

Sie können Ihre bevorzugten Python-Pakete wie NumPy, SciPy und Cython wiederverwenden, um PyTorch nach Bedarf zu erweitern.

Unsere Trunk-Gesundheit (Continuous Integration-Signale) finden Sie unter [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main).

<!-- toc -->

- [Mehr über PyTorch](#mehr-über-pytorch)
  - [Eine GPU-bereite Tensor-Bibliothek](#eine-gpu-bereite-tensor-bibliothek)
  - [Dynamische neuronale Netze: Bandbasierter Autograd](#dynamische-neuronale-netze-bandbasierter-autograd)
  - [Python zuerst](#python-zuerst)
  - [Imperative Erfahrungen](#imperative-erfahrungen)
  - [Schnell und schlank](#schnell-und-schlank)
  - [Erweiterungen ohne Schmerzen](#erweiterungen-ohne-schmerzen)
- [Installation](#installation)
  - [Binärdateien](#binärdateien)
    - [NVIDIA Jetson Plattformen](#nvidia-jetson-plattformen)
  - [Aus dem Quellcode](#aus-dem-quellcode)
    - [Voraussetzungen](#voraussetzungen)
      - [NVIDIA CUDA Unterstützung](#nvidia-cuda-unterstützung)
      - [AMD ROCm Unterstützung](#amd-rocm-unterstützung)
      - [Intel GPU Unterstützung](#intel-gpu-unterstützung)
    - [PyTorch-Quellcode holen](#pytorch-quellcode-holen)
    - [Abhängigkeiten installieren](#abhängigkeiten-installieren)
    - [PyTorch installieren](#pytorch-installieren)
      - [Build-Optionen anpassen (optional)](#build-optionen-anpassen-optional)
  - [Docker-Image](#docker-image)
    - [Verwendung vorgefertigter Images](#verwendung-vorgefertigter-images)
    - [Image selbst bauen](#image-selbst-bauen)
  - [Dokumentation bauen](#dokumentation-bauen)
    - [PDF-Erstellung](#pdf-erstellung)
  - [Frühere Versionen](#frühere-versionen)
- [Erste Schritte](#erste-schritte)
- [Ressourcen](#ressourcen)
- [Kommunikation](#kommunikation)
- [Releases und Mitwirkung](#releases-und-mitwirkung)
- [Das Team](#das-team)
- [Lizenz](#lizenz)

<!-- tocstop -->

## Mehr über PyTorch

[Erlernen Sie die Grundlagen von PyTorch](https://pytorch.org/tutorials/beginner/basics/intro.html)

Im Detail ist PyTorch eine Bibliothek, die aus den folgenden Komponenten besteht:

| Komponente | Beschreibung |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | Eine Tensor-Bibliothek wie NumPy mit starker GPU-Unterstützung |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | Eine bandbasierte automatische Differenzierungsbibliothek, die alle differenzierbaren Tensoroperationen in torch unterstützt |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | Ein Kompilierungs-Stack (TorchScript), um aus PyTorch-Code serialisierbare und optimierbare Modelle zu erstellen |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | Eine mit Autograd tief integrierte Bibliothek für neuronale Netze, die maximale Flexibilität bietet |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Python-Multiprocessing, aber mit magischem Speicheraustausch von torch-Tensoren zwischen Prozessen. Nützlich für das Laden von Daten und Hogwild-Training |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader und andere Hilfsfunktionen zur Vereinfachung |

Normalerweise wird PyTorch wie folgt verwendet:

- Als Ersatz für NumPy, um die Leistung von GPUs zu nutzen.
- Als Deep-Learning-Forschungsplattform, die maximale Flexibilität und Geschwindigkeit bietet.

Weitere Erläuterungen:

### Eine GPU-bereite Tensor-Bibliothek

Wenn Sie NumPy verwenden, haben Sie bereits Tensoren (auch bekannt als ndarray) verwendet.

![Tensor illustration](./docs/source/_static/img/tensor_illustration.png)

PyTorch bietet Tensoren, die entweder auf der CPU oder der GPU leben können und beschleunigt die
Berechnung enorm.

Wir bieten eine große Auswahl an Tensor-Routinen, um Ihre wissenschaftlichen Rechenanforderungen zu beschleunigen und anzupassen, wie z.B. Slicing, Indexierung, mathematische Operationen, lineare Algebra, Reduktionen.
Und sie sind schnell!

### Dynamische neuronale Netze: Bandbasierter Autograd

PyTorch hat eine einzigartige Methode zum Aufbau neuronaler Netze: die Verwendung und Wiedergabe eines Bandrekorders.

Die meisten Frameworks wie TensorFlow, Theano, Caffe und CNTK haben eine statische Sicht auf die Welt.
Man muss ein neuronales Netz aufbauen und immer wieder die gleiche Struktur verwenden.
Wenn sich das Verhalten des Netzes ändern soll, muss man von vorne anfangen.

Mit PyTorch verwenden wir eine Technik namens Reverse-Mode Auto-Differenzierung, die es Ihnen ermöglicht,
das Verhalten Ihres Netzes beliebig zu ändern – ohne Verzögerung oder Overhead. Unsere Inspiration stammt
aus mehreren Forschungsarbeiten zu diesem Thema sowie aktueller und früherer Arbeiten wie
[torch-autograd](https://github.com/twitter/torch-autograd),
[autograd](https://github.com/HIPS/autograd),
[Chainer](https://chainer.org) usw.

Obwohl diese Technik nicht einzigartig für PyTorch ist, ist es eine der schnellsten Implementierungen davon bis heute.
Sie bekommen das Beste aus Geschwindigkeit und Flexibilität für Ihre anspruchsvolle Forschung.

![Dynamic graph](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python zuerst

PyTorch ist keine Python-Bindung in ein monolithisches C++-Framework.
Es wurde entwickelt, um tief in Python integriert zu sein.
Sie können es ganz natürlich verwenden, wie Sie [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) usw. verwenden würden.
Sie können Ihre neuen neuronalen Netzwerkschichten direkt in Python mit Ihren bevorzugten Bibliotheken schreiben
und Pakete wie [Cython](https://cython.org/) und [Numba](http://numba.pydata.org/) verwenden.
Unser Ziel ist es, das Rad nicht neu zu erfinden, wo es nicht nötig ist.

### Imperative Erfahrungen

PyTorch wurde entwickelt, um intuitiv, linear im Denken und einfach zu bedienen zu sein.
Wenn Sie eine Codezeile ausführen, wird sie auch ausgeführt. Es gibt keine asynchrone Sicht auf die Welt.
Wenn Sie in einen Debugger eintauchen oder Fehlermeldungen und Stacktraces erhalten, ist das Verständnis einfach.
Der Stacktrace zeigt genau an, wo Ihr Code definiert wurde.
Wir hoffen, dass Sie nie Stunden mit dem Debuggen Ihres Codes verbringen, weil Stacktraces schlecht oder Ausführungs-Engines asynchron und undurchsichtig sind.

### Schnell und schlank

PyTorch hat minimalen Framework-Overhead. Wir integrieren Beschleunigungsbibliotheken
wie [Intel MKL](https://software.intel.com/mkl) und NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)), um die Geschwindigkeit zu maximieren.
Im Kern sind die CPU- und GPU-Tensor- und neuronalen Netz-Backends
ausgereift und wurden über Jahre getestet.

Daher ist PyTorch sehr schnell – egal ob Sie kleine oder große neuronale Netze ausführen.

Der Speicherverbrauch von PyTorch ist im Vergleich zu Torch oder einigen Alternativen äußerst effizient.
Wir haben benutzerdefinierte Speicherallokatoren für die GPU geschrieben, um sicherzustellen, dass
Ihre Deep-Learning-Modelle maximal speichereffizient sind.
Dadurch können Sie größere Deep-Learning-Modelle als zuvor trainieren.

### Erweiterungen ohne Schmerzen

Das Schreiben neuer neuronaler Netzwerk-Module oder die Interaktion mit der Tensor-API von PyTorch wurde so konzipiert, dass es einfach ist
und minimale Abstraktionen erfordert.

Sie können neue neuronale Netzwerkschichten in Python mit der torch-API schreiben
[oder Ihre bevorzugten NumPy-basierten Bibliotheken wie SciPy verwenden](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html).

Wenn Sie Ihre Schichten in C/C++ schreiben möchten, bieten wir eine praktische Erweiterungs-API, die effizient ist und mit minimalem Overhead auskommt.
Es muss kein Wrapper-Code geschrieben werden. Siehe [ein Tutorial hier](https://pytorch.org/tutorials/advanced/cpp_extension.html) und [ein Beispiel hier](https://github.com/pytorch/extension-cpp).


## Installation

### Binärdateien
Befehle zur Installation von Binärdateien via Conda oder pip wheels finden Sie auf unserer Webseite: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)


#### NVIDIA Jetson Plattformen

Python Wheels für NVIDIA Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX und Jetson AGX Orin finden Sie [hier](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) und der L4T-Container wird [hier](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch) veröffentlicht.

Sie benötigen JetPack 4.2 oder höher, und [@dusty-nv](https://github.com/dusty-nv) sowie [@ptrblck](https://github.com/ptrblck) pflegen diese.

### Aus dem Quellcode

#### Voraussetzungen
Wenn Sie aus dem Quellcode installieren, benötigen Sie:
- Python 3.9 oder neuer
- Einen Compiler, der C++17 vollständig unterstützt, wie clang oder gcc (gcc 9.4.0 oder neuer ist unter Linux erforderlich)
- Visual Studio oder Visual Studio Build Tool (nur Windows)

\* PyTorch CI verwendet Visual C++ BuildTools, die mit Visual Studio Enterprise,
Professional oder Community Editions mitgeliefert werden. Sie können die Build-Tools auch unter
https://visualstudio.microsoft.com/visual-cpp-build-tools/ installieren. Die Build-Tools *sind nicht*
standardmäßig bei Visual Studio Code enthalten.

Ein Beispiel für das Einrichten der Umgebung ist unten dargestellt:

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

##### NVIDIA CUDA Unterstützung
Wenn Sie mit CUDA-Unterstützung kompilieren möchten, [wählen Sie eine unterstützte CUDA-Version aus unserer Support-Matrix](https://pytorch.org/get-started/locally/) und installieren Sie dann Folgendes:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 oder höher
- [Compiler](https://gist.github.com/ax3l/9489132), der mit CUDA kompatibel ist

Hinweis: Sie können die [cuDNN Support Matrix](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) für cuDNN-Versionen mit den verschiedenen unterstützten CUDA-, CUDA-Treiber- und NVIDIA-Hardware-Kombinationen zu Rate ziehen.

Wenn Sie die CUDA-Unterstützung deaktivieren möchten, exportieren Sie die Umgebungsvariable `USE_CUDA=0`.
Weitere nützliche Umgebungsvariablen finden Sie in `setup.py`.

Wenn Sie für NVIDIA Jetson Plattformen (Jetson Nano, TX1, TX2, AGX Xavier) bauen, finden Sie die Anweisungen zur Installation von PyTorch für Jetson Nano [hier](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### AMD ROCm Unterstützung
Wenn Sie mit ROCm-Unterstützung kompilieren möchten, installieren Sie
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 oder höher
- ROCm wird aktuell nur für Linux-Systeme unterstützt.

Standardmäßig erwartet das Build-System, dass ROCm in `/opt/rocm` installiert ist. Falls ROCm in einem anderen Verzeichnis installiert ist, muss die Umgebungsvariable `ROCM_PATH` auf das Installationsverzeichnis gesetzt werden. Die AMD-GPU-Architektur wird automatisch erkannt. Optional kann die Architektur explizit mit der Umgebungsvariable `PYTORCH_ROCM_ARCH` gesetzt werden [AMD GPU Architektur](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

Wenn Sie ROCm-Unterstützung deaktivieren möchten, exportieren Sie die Umgebungsvariable `USE_ROCM=0`.
Weitere nützliche Umgebungsvariablen finden Sie in `setup.py`.

##### Intel GPU Unterstützung
Wenn Sie mit Intel GPU-Unterstützung kompilieren möchten, folgen Sie diesen Anweisungen:
- [PyTorch-Voraussetzungen für Intel GPUs](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html).
- Intel GPU wird für Linux und Windows unterstützt.

Wenn Sie die Intel GPU-Unterstützung deaktivieren möchten, exportieren Sie die Umgebungsvariable `USE_XPU=0`.
Weitere nützliche Umgebungsvariablen finden Sie in `setup.py`.

#### PyTorch-Quellcode holen
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# wenn Sie ein bestehendes Checkout aktualisieren
git submodule sync
git submodule update --init --recursive
```

#### Abhängigkeiten installieren

**Allgemein**

```bash
conda install cmake ninja
# Führen Sie diesen Befehl aus dem PyTorch-Verzeichnis aus, nachdem Sie den Quellcode mit dem Abschnitt „PyTorch-Quellcode holen“ geklont haben
pip install -r requirements.txt
```

**Unter Linux**

```bash
pip install mkl-static mkl-include
# Nur CUDA: Fügen Sie bei Bedarf LAPACK-Unterstützung für die GPU hinzu
# magma-Installation: Führen Sie dies mit aktiviertem Conda-Umfeld aus. Geben Sie die zu installierende CUDA-Version an
.ci/docker/common/install_magma_conda.sh 12.4

# (optional) Wenn Sie torch.compile mit inductor/triton verwenden, installieren Sie die passende Version von triton
# Führen Sie dies aus dem pytorch-Verzeichnis nach dem Klonen aus
# Für Intel GPU-Unterstützung bitte explizit `export USE_XPU=1` vor dem Ausführen des Befehls setzen.
make triton
```

**Unter MacOS**

```bash
# Fügen Sie dieses Paket nur auf Intel x86-Prozessoren hinzu
pip install mkl-static mkl-include
# Fügen Sie diese Pakete hinzu, wenn torch.distributed benötigt wird
conda install pkg-config libuv
```

**Unter Windows**

```bash
pip install mkl-static mkl-include
# Fügen Sie diese Pakete hinzu, wenn torch.distributed benötigt wird.
# Unterstützung für das Distributed-Paket unter Windows ist ein Prototyp und kann sich ändern.
conda install -c conda-forge libuv=1.39
```

#### PyTorch installieren
**Unter Linux**

Wenn Sie für AMD ROCm kompilieren, führen Sie zuerst diesen Befehl aus:
```bash
# Nur ausführen, wenn Sie für ROCm kompilieren
python tools/amd_build/build_amd.py
```

PyTorch installieren
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**Unter macOS**

```bash
python3 setup.py develop
```

**Unter Windows**

Wenn Sie Legacy-Python-Code bauen möchten, siehe [Building on legacy code and CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**CPU-only Builds**

In diesem Modus laufen PyTorch-Berechnungen auf Ihrer CPU, nicht auf Ihrer GPU.

```cmd
python setup.py develop
```

Hinweis zu OpenMP: Die gewünschte OpenMP-Implementierung ist Intel OpenMP (iomp). Um gegen iomp zu linken, müssen Sie die Bibliothek manuell herunterladen und die Build-Umgebung durch Anpassen von `CMAKE_INCLUDE_PATH` und `LIB` einrichten. Die Anleitung [hier](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) ist ein Beispiel für die Einrichtung von MKL und Intel OpenMP. Ohne diese Konfigurationen für CMake wird Microsoft Visual C OpenMP Runtime (vcomp) verwendet.

**CUDA-basierter Build**

In diesem Modus nutzt PyTorch Ihre GPU über CUDA für schnellere Berechnungen.

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) ist erforderlich, um PyTorch mit CUDA zu bauen.
NVTX ist Bestandteil der CUDA-Distribution, wo es „Nsight Compute“ genannt wird. Um es zu einer bereits installierten CUDA-Installation hinzuzufügen, führen Sie die CUDA-Installation erneut aus und setzen Sie das entsprechende Häkchen.
Stellen Sie sicher, dass CUDA mit Nsight Compute nach Visual Studio installiert ist.

Derzeit werden VS 2017 / 2019 und Ninja als Generator für CMake unterstützt. Wenn `ninja.exe` im `PATH` gefunden wird, wird Ninja als Standardgenerator verwendet, andernfalls VS 2017 / 2019.
<br/> Wenn Ninja als Generator ausgewählt wird, wird das neueste MSVC als zugrunde liegende Toolchain gewählt.

Zusätzliche Bibliotheken wie
[Magma](https://developer.nvidia.com/magma), [oneDNN, auch bekannt als MKLDNN oder DNNL](https://github.com/oneapi-src/oneDNN), und [Sccache](https://github.com/mozilla/sccache) werden häufig benötigt. Weitere Informationen zur Installation finden Sie im [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers).

Sie können sich das Skript [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) für weitere Konfigurationen von Umgebungsvariablen ansehen.

```cmd
cmd

:: Setzen Sie die Umgebungsvariablen, nachdem Sie das mkl-Paket heruntergeladen und entpackt haben,
:: andernfalls gibt CMake den Fehler `Could NOT find OpenMP` aus.
set CMAKE_INCLUDE_PATH={Ihr Verzeichnis}\mkl\include
set LIB={Ihr Verzeichnis}\mkl\lib;%LIB%

:: Lesen Sie den Inhalt des vorherigen Abschnitts sorgfältig, bevor Sie fortfahren.
:: [Optional] Wenn Sie das zugrunde liegende Toolset von Ninja und Visual Studio mit CUDA überschreiben möchten, führen Sie den folgenden Skriptblock aus.
:: Die „Visual Studio 2019 Developer Command Prompt“ wird automatisch ausgeführt.
:: Stellen Sie sicher, dass Sie CMake >= 3.12 verwenden, wenn Sie den Visual Studio-Generator nutzen.
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [Optional] Wenn Sie den CUDA-Host-Compiler überschreiben möchten
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Intel GPU Builds**

In diesem Modus wird PyTorch mit Intel GPU-Unterstützung gebaut.

Bitte stellen Sie sicher, dass [die allgemeinen Voraussetzungen](#voraussetzungen) und [die Voraussetzungen für Intel GPU](#intel-gpu-unterstützung) ordnungsgemäß installiert und die Umgebungsvariablen konfiguriert sind, bevor Sie mit dem Build beginnen. Für Build-Tool-Unterstützung ist `Visual Studio 2022` erforderlich.

Dann kann PyTorch mit folgendem Befehl gebaut werden:

```cmd
:: CMD-Befehle:
:: Setzen Sie CMAKE_PREFIX_PATH, um die entsprechenden Pakete zu finden
:: %CONDA_PREFIX% funktioniert nur nach `conda activate custom_env`

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### Build-Optionen anpassen (optional)

Sie können die Konfiguration der CMake-Variablen optional (ohne vorheriges Bauen) anpassen,
indem Sie wie folgt vorgehen. Zum Beispiel kann das Anpassen der erkannten Verzeichnisse für CuDNN oder BLAS
auf diese Weise erfolgen.

Unter Linux
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # oder cmake-gui build
```

Unter macOS
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # oder cmake-gui build
```

### Docker-Image

#### Verwendung vorgefertigter Images

Sie können auch ein vorgefertigtes Docker-Image von Docker Hub ziehen und mit Docker v19.03+ ausführen

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

Bitte beachten Sie, dass PyTorch Shared Memory verwendet, um Daten zwischen Prozessen zu teilen. Wenn torch multiprocessing verwendet wird (z. B.
bei multithreaded Data Loaders), ist die Standardgröße des Shared Memory Segments für Container nicht ausreichend, und Sie
sollten die Größe des Shared Memory entweder mit den Befehlszeilenoptionen `--ipc=host` oder `--shm-size` für `nvidia-docker run` erhöhen.

#### Image selbst bauen

**HINWEIS:** Muss mit einer Docker-Version > 18.06 gebaut werden

Die `Dockerfile` wird bereitgestellt, um Images mit CUDA 11.1-Unterstützung und cuDNN v8 zu bauen.
Sie können die Make-Variable `PYTHON_VERSION=x.y` angeben, um die von Miniconda verwendete Python-Version festzulegen, oder sie
nicht setzen, um die Standardversion zu verwenden.

```bash
make -f docker.Makefile
# Images werden als docker.io/${your_docker_username}/pytorch getaggt
```

Sie können auch die Umgebungsvariable `CMAKE_VARS="..."` angeben, um zusätzliche CMake-Variablen während des Builds an CMake zu übergeben.
Siehe [setup.py](./setup.py) für eine Liste der verfügbaren Variablen.

```bash
make -f docker.Makefile
```

### Dokumentation bauen

Um Dokumentation in verschiedenen Formaten zu erstellen, benötigen Sie [Sphinx](http://www.sphinx-doc.org)
und das pytorch_sphinx_theme2.

Bevor Sie die Dokumentation lokal bauen, stellen Sie sicher, dass `torch` in Ihrer Umgebung installiert ist. Für kleinere Korrekturen können Sie die
Nightly-Version wie unter [Erste Schritte](https://pytorch.org/get-started/locally/) beschrieben installieren.

Für komplexere Korrekturen, wie das Hinzufügen eines neuen Moduls und Docstrings für
das neue Modul, müssen Sie möglicherweise torch [aus dem Quellcode](#aus-dem-quellcode) installieren.
Siehe [Docstring Guidelines](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)
für Konventionen zu Docstrings.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

Führen Sie `make` aus, um eine Liste aller verfügbaren Ausgabeformate zu erhalten.

Wenn Sie einen katex-Fehler erhalten, führen Sie `npm install katex` aus. Falls das Problem weiterhin besteht,
`npm install -g katex`

> [!HINWEIS]
> Wenn Sie `nodejs` mit einem anderen Paketmanager (z. B.
> `conda`) installiert haben, wird `npm` wahrscheinlich eine Version von `katex` installieren, die nicht
> mit Ihrer Version von `nodejs` kompatibel ist und der Dokumentationsbuild fehlschlägt.
> Eine Kombination, die funktioniert, ist `node@6.13.1` und
> `katex@0.13.18`. Um letzteres mit `npm` zu installieren, führen Sie
> ```npm install -g katex@0.13.18```

> [!HINWEIS]
> Wenn Sie einen NumPy-Inkompatibilitätsfehler sehen, führen Sie aus:
> ```
> pip install 'numpy<2'
> ```

Wenn Sie Änderungen an den von CI verwendeten Abhängigkeiten vornehmen, bearbeiten Sie die
Datei `.ci/docker/requirements-docs.txt`.

#### PDF-Erstellung

Um ein PDF der gesamten PyTorch-Dokumentation zu erstellen, stellen Sie sicher, dass Sie
`texlive` und LaTeX installiert haben. Unter macOS können Sie dies mit folgendem Befehl installieren:

```
brew install --cask mactex
```

So erstellen Sie das PDF:

1. Führen Sie aus:

   ```
   make latexpdf
   ```

   Dadurch werden die notwendigen Dateien im Verzeichnis `build/latex` erstellt.

2. Wechseln Sie in dieses Verzeichnis und führen Sie aus:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   Dadurch wird eine `pytorch.pdf` mit dem gewünschten Inhalt erzeugt. Führen Sie diesen
   Befehl noch einmal aus, damit das korrekte Inhaltsverzeichnis und der Index erstellt werden.

> [!HINWEIS]
> Um das Inhaltsverzeichnis anzuzeigen, wechseln Sie in die **Inhaltsverzeichnis**-Ansicht Ihres PDF-Viewers.


### Frühere Versionen

Installationsanleitungen und Binärdateien für frühere PyTorch-Versionen finden Sie
auf [unserer Webseite](https://pytorch.org/get-started/previous-versions).


## Erste Schritte

Drei Hinweise, um Ihnen den Einstieg zu erleichtern:
- [Tutorials: Einstieg in das Verständnis und die Anwendung von PyTorch](https://pytorch.org/tutorials/)
- [Beispiele: leicht verständlicher PyTorch-Code aus allen Bereichen](https://github.com/pytorch/examples)
- [Die API-Referenz](https://pytorch.org/docs/)
- [Glossar](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## Ressourcen

* [PyTorch.org](https://pytorch.org/)
* [PyTorch Tutorials](https://pytorch.org/tutorials/)
* [PyTorch Beispiele](https://github.com/pytorch/examples)
* [PyTorch Modelle](https://pytorch.org/hub/)
* [Intro zu Deep Learning mit PyTorch von Udacity](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Intro zu Machine Learning mit PyTorch von Udacity](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Deep Neural Networks mit PyTorch von Coursera](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [PyTorch Blog](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## Kommunikation
* Foren: Diskussionen zu Implementierungen, Forschung usw. https://discuss.pytorch.org
* GitHub-Issues: Fehlerberichte, Funktionswünsche, Installationsprobleme, RFCs, Gedanken usw.
* Slack: Der [PyTorch Slack](https://pytorch.slack.com/) richtet sich primär an fortgeschrittene PyTorch-Nutzer und -Entwickler für allgemeinen Chat, Diskussionen, Zusammenarbeit usw. Wenn Sie Anfänger sind und Hilfe benötigen, ist das Hauptmedium das [PyTorch Forum](https://discuss.pytorch.org). Für eine Slack-Einladung füllen Sie bitte dieses Formular aus: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* Newsletter: Ein einseitiger E-Mail-Newsletter mit wichtigen PyTorch-Ankündigungen. Anmeldung hier: https://eepurl.com/cbG0rv
* Facebook-Seite: Wichtige Ankündigungen zu PyTorch. https://www.facebook.com/pytorch
* Für Markenrichtlinien besuchen Sie bitte unsere Webseite unter [pytorch.org](https://pytorch.org/)

## Releases und Mitwirkung

Typischerweise gibt es drei kleinere Releases von PyTorch pro Jahr. Bitte melden Sie uns Fehler, indem Sie ein [Issue eröffnen](https://github.com/pytorch/pytorch/issues).

Wir schätzen alle Beiträge. Wenn Sie Bugfixes beitragen möchten, tun Sie dies bitte ohne weitere Rücksprache.

Wenn Sie neue Funktionen, Hilfsfunktionen oder Erweiterungen für den Core beitragen möchten, eröffnen Sie bitte zuerst ein Issue und diskutieren die Funktion mit uns.
Das Senden eines PRs ohne Diskussion kann dazu führen, dass Ihr PR abgelehnt wird, weil wir den Core vielleicht in eine andere Richtung entwickeln, als Ihnen bekannt ist.

Mehr dazu, wie Sie zu PyTorch beitragen können, finden Sie auf unserer [Beitragsseite](CONTRIBUTING.md). Weitere Informationen zu PyTorch-Releases finden Sie auf der [Release-Seite](RELEASE.md).

## Das Team

PyTorch ist ein Community-getriebenes Projekt, zu dem viele erfahrene Ingenieure und Forscher beitragen.

PyTorch wird aktuell von [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang) und [Nikita Shulga](https://github.com/malfet) betreut, mit wichtigen Beiträgen von Hunderten talentierter Personen in verschiedenster Form.
Eine nicht abschließende, aber wachsende Liste: [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito).

Hinweis: Dieses Projekt steht in keinem Zusammenhang mit [hughperkins/pytorch](https://github.com/hughperkins/pytorch) mit demselben Namen. Hugh ist ein wertvoller Contributor der Torch-Community und hat bei vielen Dingen zu Torch und PyTorch beigetragen.

## Lizenz

PyTorch steht unter einer BSD-ähnlichen Lizenz, wie in der Datei [LICENSE](LICENSE) beschrieben.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---