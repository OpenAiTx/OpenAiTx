![PyTorch Logo](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch è un pacchetto Python che offre due funzionalità di alto livello:
- Calcolo con tensori (simile a NumPy) con potente accelerazione GPU
- Reti neurali profonde basate su un sistema autograd a nastro

È possibile riutilizzare i tuoi pacchetti Python preferiti come NumPy, SciPy e Cython per estendere PyTorch quando necessario.

La salute della nostra trunk (segnali di Continuous Integration) è disponibile su [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main).

<!-- toc -->

- [Ulteriori informazioni su PyTorch](#ulteriori-informazioni-su-pytorch)
  - [Una libreria di tensori pronta per GPU](#una-libreria-di-tensori-pronta-per-gpu)
  - [Reti neurali dinamiche: Autograd a nastro](#reti-neurali-dinamiche-autograd-a-nastro)
  - [Prima di tutto Python](#prima-di-tutto-python)
  - [Esperienze imperative](#esperienze-imperative)
  - [Veloce e snello](#veloce-e-snello)
  - [Estensioni senza complicazioni](#estensioni-senza-complicazioni)
- [Installazione](#installazione)
  - [Binari](#binari)
    - [Piattaforme NVIDIA Jetson](#piattaforme-nvidia-jetson)
  - [Dal sorgente](#dal-sorgente)
    - [Prerequisiti](#prerequisiti)
      - [Supporto NVIDIA CUDA](#supporto-nvidia-cuda)
      - [Supporto AMD ROCm](#supporto-amd-rocm)
      - [Supporto GPU Intel](#supporto-gpu-intel)
    - [Ottenere il sorgente PyTorch](#ottenere-il-sorgente-pytorch)
    - [Installare le dipendenze](#installare-le-dipendenze)
    - [Installare PyTorch](#installare-pytorch)
      - [Regolare le opzioni di compilazione (Opzionale)](#regolare-le-opzioni-di-compilazione-opzionale)
  - [Immagine Docker](#immagine-docker)
    - [Utilizzo di immagini precompilate](#utilizzo-di-immagini-precompilate)
    - [Costruire l'immagine manualmente](#costruire-limmagine-manualmente)
  - [Compilare la documentazione](#compilare-la-documentazione)
    - [Compilazione di un PDF](#compilazione-di-un-pdf)
  - [Versioni precedenti](#versioni-precedenti)
- [Primi passi](#primi-passi)
- [Risorse](#risorse)
- [Comunicazione](#comunicazione)
- [Rilasci e contributi](#rilasci-e-contributi)
- [Il team](#il-team)
- [Licenza](#licenza)

<!-- tocstop -->

## Ulteriori informazioni su PyTorch

[Impara le basi di PyTorch](https://pytorch.org/tutorials/beginner/basics/intro.html)

A livello granulare, PyTorch è una libreria che consiste nei seguenti componenti:

| Componente | Descrizione |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | Una libreria di tensori simile a NumPy, con forte supporto GPU |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | Una libreria di differenziazione automatica basata su nastro che supporta tutte le operazioni sui tensori differenziabili in torch |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | Uno stack di compilazione (TorchScript) per creare modelli serializzabili e ottimizzabili dal codice PyTorch |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | Una libreria di reti neurali profondamente integrata con autograd, progettata per la massima flessibilità |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Multiprocessing Python, ma con condivisione magica della memoria dei tensori torch tra i processi. Utile per il caricamento dati e l’addestramento Hogwild |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader e altre funzioni di utilità per comodità |

Di solito, PyTorch è utilizzato come:

- Sostituto di NumPy per sfruttare la potenza delle GPU.
- Piattaforma di ricerca per deep learning che offre la massima flessibilità e velocità.

Approfondimento:

### Una libreria di tensori pronta per GPU

Se usi NumPy, hai già utilizzato tensori (anche noti come ndarray).

![Tensor illustration](./docs/source/_static/img/tensor_illustration.png)

PyTorch fornisce tensori che possono risiedere sia su CPU che su GPU e accelera il calcolo in modo significativo.

Offriamo una vasta gamma di routine sui tensori per accelerare e adattarsi alle tue esigenze di calcolo scientifico, come slicing, indicizzazione, operazioni matematiche, algebra lineare, riduzioni.
E sono veloci!

### Reti neurali dinamiche: Autograd a nastro

PyTorch ha un modo unico di costruire reti neurali: usando e riproducendo un registratore a nastro.

La maggior parte dei framework come TensorFlow, Theano, Caffe e CNTK ha una visione statica del mondo.
Bisogna costruire una rete neurale e riutilizzare la stessa struttura più e più volte.
Cambiare il comportamento della rete significa dover ripartire da zero.

Con PyTorch, utilizziamo una tecnica chiamata auto-differenziazione in modalità inversa, che ti consente di
cambiare il comportamento della rete in modo arbitrario senza latenza o overhead. La nostra ispirazione deriva
da diversi articoli di ricerca su questo argomento, oltre che da lavori attuali e passati come
[torch-autograd](https://github.com/twitter/torch-autograd),
[autograd](https://github.com/HIPS/autograd),
[Chainer](https://chainer.org), ecc.

Sebbene questa tecnica non sia unica di PyTorch, è una delle implementazioni più veloci disponibili.
Ottieni il meglio in termini di velocità e flessibilità per le tue ricerche più creative.

![Dynamic graph](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Prima di tutto Python

PyTorch non è un binding Python in un framework C++ monolitico.
È costruito per essere profondamente integrato in Python.
Puoi usarlo in modo naturale come useresti [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) ecc.
Puoi scrivere i tuoi nuovi layer di reti neurali direttamente in Python, usando le tue librerie preferite
e utilizzare pacchetti come [Cython](https://cython.org/) e [Numba](http://numba.pydata.org/).
Il nostro obiettivo è non reinventare la ruota dove non necessario.

### Esperienze imperative

PyTorch è progettato per essere intuitivo, lineare nel pensiero e facile da usare.
Quando esegui una riga di codice, essa viene eseguita. Non esiste una visione asincrona del mondo.
Quando entri in un debugger o ricevi messaggi di errore e stack trace, capirli è semplice.
Lo stack trace punta esattamente al punto in cui il tuo codice è stato definito.
Speriamo che tu non debba mai passare ore a fare debugging a causa di stack trace errati o motori di esecuzione asincroni e opachi.

### Veloce e snello

PyTorch ha un overhead minimo. Integria librerie di accelerazione
come [Intel MKL](https://software.intel.com/mkl) e NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)) per massimizzare la velocità.
Al cuore, i backend per tensori e reti neurali su CPU e GPU
sono maturi e testati da anni.

Pertanto, PyTorch è molto veloce — sia che tu esegua reti neurali piccole che grandi.

L’utilizzo di memoria in PyTorch è estremamente efficiente rispetto a Torch o ad alcune alternative.
Abbiamo scritto allocatori di memoria personalizzati per la GPU per assicurarci che
i tuoi modelli di deep learning siano il più possibile efficienti in memoria.
Ciò ti consente di addestrare modelli di deep learning più grandi rispetto a prima.

### Estensioni senza complicazioni

Scrivere nuovi moduli di reti neurali, o interfacciarsi con l’API dei tensori di PyTorch è stato progettato per essere semplice
e con astrazioni minime.

Puoi scrivere nuovi layer di reti neurali in Python usando l’API torch
[o le tue librerie preferite basate su NumPy come SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html).

Se desideri scrivere i tuoi layer in C/C++, offriamo una comoda API per le estensioni efficiente e con boilerplate minimo.
Non è necessario scrivere codice wrapper. Puoi vedere [un tutorial qui](https://pytorch.org/tutorials/advanced/cpp_extension.html) e [un esempio qui](https://github.com/pytorch/extension-cpp).


## Installazione

### Binari
I comandi per installare i binari tramite Conda o pip wheels sono disponibili sul nostro sito: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)


#### Piattaforme NVIDIA Jetson

I pacchetti wheel Python per NVIDIA Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX e Jetson AGX Orin sono disponibili [qui](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) e il container L4T è pubblicato [qui](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)

Richiedono JetPack 4.2 o superiore, e [@dusty-nv](https://github.com/dusty-nv) e [@ptrblck](https://github.com/ptrblck) li mantengono.


### Dal sorgente

#### Prerequisiti
Se installi dal sorgente, avrai bisogno di:
- Python 3.9 o successivo
- Un compilatore che supporti completamente C++17, come clang o gcc (gcc 9.4.0 o successivo è richiesto su Linux)
- Visual Studio o Visual Studio Build Tool (solo Windows)

\* Il CI di PyTorch utilizza Visual C++ BuildTools, che sono inclusi in Visual Studio Enterprise,
Professional o Community Edition. Puoi anche installare i build tools da
https://visualstudio.microsoft.com/visual-cpp-build-tools/. I build tools *non sono* inclusi in Visual Studio Code di default.

Un esempio di configurazione dell’ambiente è mostrato di seguito:

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

##### Supporto NVIDIA CUDA
Se vuoi compilare con supporto CUDA, [seleziona una versione supportata di CUDA dalla nostra matrice di supporto](https://pytorch.org/get-started/locally/), quindi installa:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 o superiore
- [Compilatore](https://gist.github.com/ax3l/9489132) compatibile con CUDA

Nota: Puoi consultare la [matrice di supporto cuDNN](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) per le versioni cuDNN con le varie versioni di CUDA, driver CUDA e hardware NVIDIA supportati.

Se vuoi disabilitare il supporto CUDA, esporta la variabile d’ambiente `USE_CUDA=0`.
Altre variabili d’ambiente utili possono essere trovate in `setup.py`.

Se stai compilando per piattaforme NVIDIA Jetson (Jetson Nano, TX1, TX2, AGX Xavier), le istruzioni per installare PyTorch per Jetson Nano sono [disponibili qui](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### Supporto AMD ROCm
Se vuoi compilare con supporto ROCm, installa
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 o superiore
- ROCm è attualmente supportato solo su sistemi Linux.

Di default il sistema di build si aspetta ROCm installato in `/opt/rocm`. Se ROCm è installato in una directory diversa, la variabile d’ambiente `ROCM_PATH` deve essere impostata sulla directory di installazione ROCm. Il sistema di build rileva automaticamente l’architettura GPU AMD. Facoltativamente, l’architettura GPU AMD può essere impostata esplicitamente con la variabile d’ambiente `PYTORCH_ROCM_ARCH` [Architettura GPU AMD](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

Se vuoi disabilitare il supporto ROCm, esporta la variabile d’ambiente `USE_ROCM=0`.
Altre variabili d’ambiente utili possono essere trovate in `setup.py`.

##### Supporto GPU Intel
Se vuoi compilare con supporto GPU Intel, segui queste
- [Istruzioni PyTorch Prerequisites for Intel GPUs](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html).
- La GPU Intel è supportata per Linux e Windows.

Se vuoi disabilitare il supporto GPU Intel, esporta la variabile d’ambiente `USE_XPU=0`.
Altre variabili d’ambiente utili possono essere trovate in `setup.py`.

#### Ottenere il sorgente PyTorch
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# se stai aggiornando una copia locale esistente
git submodule sync
git submodule update --init --recursive
```

#### Installare le dipendenze

**Comuni**

```bash
conda install cmake ninja
# Esegui questo comando dalla directory PyTorch dopo aver clonato il codice sorgente usando la sezione “Ottenere il sorgente PyTorch” qui sopra
pip install -r requirements.txt
```

**Su Linux**

```bash
pip install mkl-static mkl-include
# Solo CUDA: Aggiungi il supporto LAPACK per la GPU se necessario
# installazione magma: esegui con ambiente conda attivo. specifica la versione CUDA da installare
.ci/docker/common/install_magma_conda.sh 12.4

# (opzionale) Se utilizzi torch.compile con inductor/triton, installa la versione corrispondente di triton
# Esegui dalla directory pytorch dopo il clone
# Per il supporto GPU Intel, esporta esplicitamente `USE_XPU=1` prima di eseguire il comando.
make triton
```

**Su MacOS**

```bash
# Aggiungi questo pacchetto solo su macchine con processore intel x86
pip install mkl-static mkl-include
# Aggiungi questi pacchetti se torch.distributed è necessario
conda install pkg-config libuv
```

**Su Windows**

```bash
pip install mkl-static mkl-include
# Aggiungi questi pacchetti se torch.distributed è necessario.
# Il supporto del pacchetto distributed su Windows è una funzionalità prototipo e soggetta a cambiamenti.
conda install -c conda-forge libuv=1.39
```

#### Installare PyTorch
**Su Linux**

Se stai compilando per AMD ROCm esegui prima questo comando:
```bash
# Esegui solo se stai compilando per ROCm
python tools/amd_build/build_amd.py
```

Installa PyTorch
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**Su macOS**

```bash
python3 setup.py develop
```

**Su Windows**

Se desideri compilare codice python legacy, consulta [Building on legacy code and CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**Compilazioni solo CPU**

In questa modalità i calcoli PyTorch verranno eseguiti sulla CPU, non sulla GPU.

```cmd
python setup.py develop
```

Nota su OpenMP: L’implementazione OpenMP preferita è Intel OpenMP (iomp). Per collegarti a iomp, devi scaricare manualmente la libreria e configurare l’ambiente di compilazione modificando `CMAKE_INCLUDE_PATH` e `LIB`. Le istruzioni [qui](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) sono un esempio per configurare sia MKL che Intel OpenMP. Senza queste configurazioni per CMake, verrà utilizzato il runtime OpenMP di Microsoft Visual C (vcomp).

**Compilazione basata su CUDA**

In questa modalità i calcoli PyTorch sfrutteranno la GPU tramite CUDA per prestazioni più rapide

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) è necessario per compilare Pytorch con CUDA.
NVTX è incluso nella distribuzione CUDA, dove è chiamato "Nsight Compute". Per installarlo su una CUDA già installata, esegui nuovamente l’installazione CUDA e seleziona la relativa casella.
Assicurati che CUDA con Nsight Compute sia installato dopo Visual Studio.

Attualmente, VS 2017 / 2019 e Ninja sono supportati come generatori di CMake. Se `ninja.exe` è rilevato nel `PATH`, Ninja verrà usato come generatore predefinito, altrimenti si userà VS 2017 / 2019.
<br/> Se Ninja è selezionato come generatore, verrà selezionato automaticamente l’ultima versione di MSVC come toolchain.

Ulteriori librerie come
[Magma](https://developer.nvidia.com/magma), [oneDNN, noto anche come MKLDNN o DNNL](https://github.com/oneapi-src/oneDNN), e [Sccache](https://github.com/mozilla/sccache) sono spesso necessarie. Consulta [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) per installarle.

Puoi consultare lo script [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) per altre configurazioni di variabili d’ambiente


```cmd
cmd

:: Imposta le variabili di ambiente dopo aver scaricato e decompresso il pacchetto mkl,
:: altrimenti CMake restituirà un errore come `Could NOT find OpenMP`.
set CMAKE_INCLUDE_PATH={Your directory}\mkl\include
set LIB={Your directory}\mkl\lib;%LIB%

:: Leggi attentamente la sezione precedente prima di procedere.
:: [Opzionale] Se vuoi sovrascrivere il toolset usato da Ninja e Visual Studio con CUDA, esegui il seguente blocco di script.
:: "Visual Studio 2019 Developer Command Prompt" verrà avviato automaticamente.
:: Assicurati di avere CMake >= 3.12 prima di farlo quando usi il generatore Visual Studio.
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [Opzionale] Se vuoi sovrascrivere il compilatore host CUDA
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Compilazioni GPU Intel**

In questa modalità verrà compilato PyTorch con supporto GPU Intel.

Assicurati che [i prerequisiti comuni](#prerequisiti) e [i prerequisiti per GPU Intel](#supporto-gpu-intel) siano installati correttamente e che le variabili d’ambiente siano configurate prima di iniziare la build. Per il supporto agli strumenti di build è richiesto `Visual Studio 2022`.

Quindi PyTorch può essere compilato con il comando:

```cmd
:: Comandi CMD:
:: Imposta CMAKE_PREFIX_PATH per trovare i pacchetti corrispondenti
:: %CONDA_PREFIX% funziona solo dopo `conda activate custom_env`

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### Regolare le opzioni di compilazione (Opzionale)

Puoi regolare la configurazione delle variabili cmake opzionalmente (senza compilare prima), facendo
quanto segue. Ad esempio, regolare le directory pre-rilevate per CuDNN o BLAS può essere fatto
con questo passaggio.

Su Linux
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # o cmake-gui build
```

Su macOS
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # o cmake-gui build
```

### Immagine Docker

#### Utilizzo di immagini precompilate

Puoi anche scaricare un’immagine docker precompilata da Docker Hub ed eseguire con docker v19.03+

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

Nota che PyTorch utilizza la memoria condivisa per condividere dati tra processi, quindi se viene utilizzato torch multiprocessing (ad esempio
per data loader multithread), la dimensione predefinita del segmento di memoria condivisa con cui il container viene eseguito non è sufficiente, e devi
aumentare la dimensione della memoria condivisa usando le opzioni da linea di comando `--ipc=host` o `--shm-size` in `nvidia-docker run`.

#### Costruire l'immagine manualmente

**NOTA:** Deve essere costruita con una versione di docker > 18.06

Il `Dockerfile` è fornito per costruire immagini con supporto CUDA 11.1 e cuDNN v8.
Puoi passare la variabile make `PYTHON_VERSION=x.y` per specificare la versione di Python che verrà usata da Miniconda, oppure lasciarla
non impostata per usare quella predefinita.

```bash
make -f docker.Makefile
# le immagini sono taggate come docker.io/${your_docker_username}/pytorch
```

Puoi anche passare la variabile d’ambiente `CMAKE_VARS="..."` per specificare ulteriori variabili CMake da passare durante la build.
Consulta [setup.py](./setup.py) per la lista delle variabili disponibili.

```bash
make -f docker.Makefile
```

### Compilare la documentazione

Per compilare la documentazione in vari formati, avrai bisogno di [Sphinx](http://www.sphinx-doc.org)
e del tema pytorch_sphinx_theme2.

Prima di compilare la documentazione in locale, assicurati che `torch` sia
installato nel tuo ambiente. Per piccole modifiche, puoi installare la
versione nightly come descritto in [Primi passi](https://pytorch.org/get-started/locally/).

Per modifiche più complesse, come aggiungere un nuovo modulo e docstring per
il nuovo modulo, potresti dover installare torch [dal sorgente](#dal-sorgente).
Consulta le [Linee guida Docstring](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)
per le convenzioni sui docstring.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

Esegui `make` per ottenere una lista di tutti i formati di output disponibili.

Se ottieni un errore katex esegui `npm install katex`. Se persiste, prova
`npm install -g katex`

> [!NOTA]
> Se hai installato `nodejs` con un gestore di pacchetti diverso (ad es.
> `conda`) allora `npm` probabilmente installerà una versione di `katex` non
> compatibile con la tua versione di `nodejs` e la compilazione della documentazione fallirà.
> Una combinazione di versioni nota per funzionare è `node@6.13.1` e
> `katex@0.13.18`. Per installare quest’ultimo con `npm` puoi eseguire
> ```npm install -g katex@0.13.18```

> [!NOTA]
> Se vedi un errore di incompatibilità numpy, esegui:
> ```
> pip install 'numpy<2'
> ```

Quando apporti modifiche alle dipendenze eseguite dal CI, modifica il file
`.ci/docker/requirements-docs.txt`.

#### Compilazione di un PDF

Per compilare un PDF di tutta la documentazione PyTorch, assicurati di avere
`texlive` e LaTeX installati. Su macOS, puoi installarli usando:

```
brew install --cask mactex
```

Per creare il PDF:

1. Esegui:

   ```
   make latexpdf
   ```

   Questo genererà i file necessari nella directory `build/latex`.

2. Naviga in questa directory ed esegui:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   Questo produrrà un file `pytorch.pdf` con il contenuto desiderato. Esegui questo
   comando ancora una volta per generare l’indice e la tabella dei contenuti corretti.

> [!NOTA]
> Per visualizzare la Tabella dei Contenuti, passa alla vista **Table of Contents**
> nel tuo visualizzatore PDF.


### Versioni precedenti

Le istruzioni di installazione e i binari delle versioni precedenti di PyTorch sono disponibili
sul [nostro sito](https://pytorch.org/get-started/previous-versions).


## Primi passi

Tre suggerimenti per iniziare:
- [Tutorial: per iniziare a comprendere e utilizzare PyTorch](https://pytorch.org/tutorials/)
- [Esempi: codice PyTorch di facile comprensione in tutti i domini](https://github.com/pytorch/examples)
- [La documentazione API](https://pytorch.org/docs/)
- [Glossario](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## Risorse

* [PyTorch.org](https://pytorch.org/)
* [Tutorial PyTorch](https://pytorch.org/tutorials/)
* [Esempi PyTorch](https://github.com/pytorch/examples)
* [Modelli PyTorch](https://pytorch.org/hub/)
* [Intro to Deep Learning with PyTorch da Udacity](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Intro to Machine Learning with PyTorch da Udacity](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Deep Neural Networks with PyTorch da Coursera](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [PyTorch Blog](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## Comunicazione
* Forum: Discuti di implementazioni, ricerca, ecc. https://discuss.pytorch.org
* GitHub Issues: Segnalazioni di bug, richieste di funzionalità, problemi di installazione, RFC, idee, ecc.
* Slack: Lo [Slack PyTorch](https://pytorch.slack.com/) ospita un pubblico principale di utenti e sviluppatori PyTorch di livello medio-avanzato per chat generali, discussioni online, collaborazione, ecc. Se sei un principiante in cerca di aiuto, il canale principale è [PyTorch Forums](https://discuss.pytorch.org). Se hai bisogno di un invito Slack, compila questo modulo: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* Newsletter: Nessun rumore, una newsletter unidirezionale con annunci importanti su PyTorch. Puoi iscriverti qui: https://eepurl.com/cbG0rv
* Pagina Facebook: Annunci importanti su PyTorch. https://www.facebook.com/pytorch
* Per le linee guida sul brand, consulta il nostro sito [pytorch.org](https://pytorch.org/)

## Rilasci e contributi

Tipicamente, PyTorch ha tre rilasci minori all’anno. Segnalaci eventuali bug [aprendo un issue](https://github.com/pytorch/pytorch/issues).

Apprezziamo tutti i contributi. Se hai intenzione di contribuire con bug-fix, fallo pure senza ulteriori discussioni.

Se vuoi contribuire con nuove funzionalità, funzioni di utilità o estensioni al core, apri prima un issue e discuti la funzionalità con noi.
Inviare una PR senza discussione potrebbe portare a un rifiuto della PR perché potremmo avere una direzione diversa da quella che immagini.

Per saperne di più su come contribuire a Pytorch, consulta la nostra [pagina dei contributi](CONTRIBUTING.md). Per ulteriori informazioni sui rilasci PyTorch, vedi la [pagina dei rilasci](RELEASE.md).

## Il team

PyTorch è un progetto guidato dalla comunità con diversi ingegneri e ricercatori di talento che vi contribuiscono.

PyTorch è attualmente mantenuto da [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang), e [Nikita Shulga](https://github.com/malfet) con contributi importanti da centinaia di persone di talento in varie forme e modalità.
Un elenco non esaustivo ma in crescita include: [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito).

Nota: Questo progetto non è collegato a [hughperkins/pytorch](https://github.com/hughperkins/pytorch) con lo stesso nome. Hugh è un valido contributore della comunità Torch e ha aiutato in molti aspetti Torch e PyTorch.

## Licenza

PyTorch ha una licenza in stile BSD, come riportato nel file [LICENSE](LICENSE).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---