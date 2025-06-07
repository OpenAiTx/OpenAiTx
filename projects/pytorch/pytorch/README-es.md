![PyTorch Logo](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch es un paquete de Python que proporciona dos características de alto nivel:
- Cálculo con tensores (como NumPy) con fuerte aceleración en GPU
- Redes neuronales profundas construidas sobre un sistema de autograd basado en cinta

Puedes reutilizar tus paquetes favoritos de Python como NumPy, SciPy y Cython para extender PyTorch cuando sea necesario.

El estado actual de nuestro trunk (señales de Integración Continua) puede encontrarse en [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main).

<!-- toc -->

- [Más sobre PyTorch](#more-about-pytorch)
  - [Una biblioteca de tensores lista para GPU](#a-gpu-ready-tensor-library)
  - [Redes neuronales dinámicas: Autograd basado en cinta](#dynamic-neural-networks-tape-based-autograd)
  - [Python primero](#python-first)
  - [Experiencia imperativa](#imperative-experiences)
  - [Rápido y liviano](#fast-and-lean)
  - [Extensiones sin dolor](#extensions-without-pain)
- [Instalación](#installation)
  - [Binarios](#binaries)
    - [Plataformas NVIDIA Jetson](#nvidia-jetson-platforms)
  - [Desde el código fuente](#from-source)
    - [Prerrequisitos](#prerequisites)
      - [Soporte NVIDIA CUDA](#nvidia-cuda-support)
      - [Soporte AMD ROCm](#amd-rocm-support)
      - [Soporte Intel GPU](#intel-gpu-support)
    - [Obtener el código fuente de PyTorch](#get-the-pytorch-source)
    - [Instalar dependencias](#install-dependencies)
    - [Instalar PyTorch](#install-pytorch)
      - [Ajustar opciones de compilación (Opcional)](#adjust-build-options-optional)
  - [Imagen Docker](#docker-image)
    - [Uso de imágenes preconstruidas](#using-pre-built-images)
    - [Construyendo la imagen por ti mismo](#building-the-image-yourself)
  - [Construcción de la documentación](#building-the-documentation)
    - [Creando un PDF](#building-a-pdf)
  - [Versiones anteriores](#previous-versions)
- [Primeros pasos](#getting-started)
- [Recursos](#resources)
- [Comunicación](#communication)
- [Lanzamientos y contribuciones](#releases-and-contributing)
- [El equipo](#the-team)
- [Licencia](#license)

<!-- tocstop -->

## Más sobre PyTorch

[Aprende lo básico de PyTorch](https://pytorch.org/tutorials/beginner/basics/intro.html)

A nivel granular, PyTorch es una biblioteca que consta de los siguientes componentes:

| Componente | Descripción |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | Una biblioteca de tensores como NumPy, con fuerte soporte para GPU |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | Una biblioteca de diferenciación automática basada en cinta que soporta todas las operaciones diferenciables de Tensor en torch |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | Una pila de compilación (TorchScript) para crear modelos serializables y optimizables a partir de código PyTorch |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | Una biblioteca de redes neuronales profundamente integrada con autograd y diseñada para máxima flexibilidad |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Multiprocesamiento en Python, pero con compartición mágica de memoria de tensores torch entre procesos. Útil para carga de datos y entrenamiento Hogwild |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader y otras funciones utilitarias para conveniencia |

Usualmente, PyTorch se utiliza de dos formas:

- Como reemplazo de NumPy para aprovechar el poder de las GPUs.
- Como una plataforma de investigación en aprendizaje profundo que proporciona máxima flexibilidad y velocidad.

Expandiendo más:

### Una biblioteca de tensores lista para GPU

Si usas NumPy, entonces ya has utilizado tensores (también conocidos como ndarray).

![Ilustración de tensor](./docs/source/_static/img/tensor_illustration.png)

PyTorch proporciona tensores que pueden residir tanto en la CPU como en la GPU y acelera el
cálculo significativamente.

Ofrecemos una amplia variedad de rutinas de tensores para acelerar y cubrir tus necesidades de cálculo científico,
como slicing, indexado, operaciones matemáticas, álgebra lineal, reducciones.
¡Y son rápidas!

### Redes neuronales dinámicas: Autograd basado en cinta

PyTorch tiene una forma única de construir redes neuronales: utilizando y reproduciendo una grabadora de cinta.

La mayoría de los frameworks como TensorFlow, Theano, Caffe y CNTK tienen una visión estática del mundo.
Se debe construir una red neuronal y reutilizar la misma estructura una y otra vez.
Cambiar el comportamiento de la red implica empezar desde cero.

Con PyTorch, usamos una técnica llamada auto-diferenciación en modo reverso, que te permite
cambiar el comportamiento de tu red de forma arbitraria sin retraso ni sobrecarga. Nuestra inspiración proviene
de varios artículos de investigación sobre este tema, así como de trabajos actuales y pasados como
[torch-autograd](https://github.com/twitter/torch-autograd),
[autograd](https://github.com/HIPS/autograd),
[Chainer](https://chainer.org), etc.

Aunque esta técnica no es exclusiva de PyTorch, es una de las implementaciones más rápidas hasta la fecha.
Obtienes lo mejor en velocidad y flexibilidad para tu investigación.

![Grafo dinámico](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python primero

PyTorch no es un binding de Python a un framework monolítico en C++.
Está construido para integrarse profundamente en Python.
Puedes usarlo de forma natural como usarías [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) etc.
Puedes escribir tus nuevas capas de redes neuronales en Python mismo, usando tus bibliotecas favoritas
y paquetes como [Cython](https://cython.org/) y [Numba](http://numba.pydata.org/).
Nuestro objetivo es no reinventar la rueda cuando sea apropiado.

### Experiencia imperativa

PyTorch está diseñado para ser intuitivo, lineal en el pensamiento y fácil de usar.
Cuando ejecutas una línea de código, se ejecuta. No hay una visión asincrónica del mundo.
Cuando entras en un depurador o recibes mensajes de error y trazas de pila, entenderlos es sencillo.
La traza de pila apunta exactamente a dónde fue definido tu código.
Esperamos que nunca pases horas depurando tu código debido a malas trazas de pila o motores de ejecución asíncronos y opacos.

### Rápido y liviano

PyTorch tiene una sobrecarga de framework mínima. Integramos bibliotecas de aceleración
como [Intel MKL](https://software.intel.com/mkl) y NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)) para maximizar la velocidad.
En su núcleo, sus backends de Tensor y redes neuronales para CPU y GPU
son maduros y han sido probados durante años.

Por lo tanto, PyTorch es bastante rápido, ya sea que ejecutes redes neuronales pequeñas o grandes.

El uso de memoria en PyTorch es extremadamente eficiente en comparación con Torch o algunas alternativas.
Hemos escrito asignadores de memoria personalizados para la GPU para asegurarnos de que
tus modelos de deep learning sean lo más eficientes posible en el uso de memoria.
Esto te permite entrenar modelos de deep learning más grandes que antes.

### Extensiones sin dolor

La escritura de nuevos módulos de redes neuronales, o la integración con la API de tensores de PyTorch está diseñada para ser sencilla
y con mínimas abstracciones.

Puedes escribir nuevas capas de redes neuronales en Python usando la API de torch
[o tus bibliotecas favoritas basadas en NumPy como SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html).

Si quieres escribir tus capas en C/C++, proporcionamos una API de extensión conveniente, eficiente y con poco código repetitivo.
No necesitas escribir código wrapper. Puedes ver [un tutorial aquí](https://pytorch.org/tutorials/advanced/cpp_extension.html) y [un ejemplo aquí](https://github.com/pytorch/extension-cpp).


## Instalación

### Binarios
Los comandos para instalar binarios vía Conda o pip wheels están en nuestro sitio web: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)


#### Plataformas NVIDIA Jetson

Los wheels de Python para Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX y Jetson AGX Orin de NVIDIA están disponibles [aquí](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) y el contenedor L4T está publicado [aquí](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)

Requieren JetPack 4.2 o superior, y [@dusty-nv](https://github.com/dusty-nv) y [@ptrblck](https://github.com/ptrblck) los mantienen.


### Desde el código fuente

#### Prerrequisitos
Si vas a instalar desde el código fuente, necesitarás:
- Python 3.9 o superior
- Un compilador que soporte completamente C++17, como clang o gcc (gcc 9.4.0 o superior es requerido en Linux)
- Visual Studio o Visual Studio Build Tool (solo en Windows)

\* PyTorch CI usa Visual C++ BuildTools, que vienen con Visual Studio Enterprise,
Professional o Community Editions. También puedes instalar las build tools desde
https://visualstudio.microsoft.com/visual-cpp-build-tools/. Las build tools *no*
vienen con Visual Studio Code por defecto.

Un ejemplo de configuración de entorno se muestra a continuación:

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

##### Soporte NVIDIA CUDA
Si deseas compilar con soporte para CUDA, [selecciona una versión soportada de CUDA de nuestra matriz de soporte](https://pytorch.org/get-started/locally/), luego instala lo siguiente:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 o superior
- [Compilador](https://gist.github.com/ax3l/9489132) compatible con CUDA

Nota: Puedes consultar la [matriz de soporte de cuDNN](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) para versiones de cuDNN con las diferentes versiones de CUDA, controladores de CUDA y hardware NVIDIA soportados.

Si deseas deshabilitar el soporte para CUDA, exporta la variable de entorno `USE_CUDA=0`.
Otras variables de entorno potencialmente útiles pueden encontrarse en `setup.py`.

Si estás construyendo para plataformas Jetson de NVIDIA (Jetson Nano, TX1, TX2, AGX Xavier), las instrucciones para instalar PyTorch para Jetson Nano están [disponibles aquí](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### Soporte AMD ROCm
Si deseas compilar con soporte para ROCm, instala
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) versión 4.0 o superior
- ROCm actualmente solo se soporta en sistemas Linux.

Por defecto el sistema de compilación espera que ROCm esté instalado en `/opt/rocm`. Si ROCm está instalado en un directorio diferente, la variable de entorno `ROCM_PATH` debe establecerse en el directorio de instalación de ROCm. El sistema de compilación detecta automáticamente la arquitectura de la GPU AMD. Opcionalmente, la arquitectura de la GPU AMD puede establecerse explícitamente con la variable de entorno `PYTORCH_ROCM_ARCH` [Arquitectura de GPU AMD](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

Si deseas deshabilitar el soporte para ROCm, exporta la variable de entorno `USE_ROCM=0`.
Otras variables de entorno potencialmente útiles pueden encontrarse en `setup.py`.

##### Soporte Intel GPU
Si deseas compilar con soporte para Intel GPU, sigue estas
- [Instrucciones de prerrequisitos de PyTorch para Intel GPUs](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html).
- Intel GPU es soportado en Linux y Windows.

Si deseas deshabilitar el soporte para Intel GPU, exporta la variable de entorno `USE_XPU=0`.
Otras variables de entorno potencialmente útiles pueden encontrarse en `setup.py`.

#### Obtener el código fuente de PyTorch
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# si estás actualizando un checkout existente
git submodule sync
git submodule update --init --recursive
```

#### Instalar dependencias

**Común**

```bash
conda install cmake ninja
# Ejecuta este comando desde el directorio de PyTorch después de clonar el código fuente usando la sección “Obtener el código fuente de PyTorch“
pip install -r requirements.txt
```

**En Linux**

```bash
pip install mkl-static mkl-include
# Solo CUDA: agrega soporte LAPACK para GPU si es necesario
# instalación de magma: ejecutar con el entorno conda activo. especifica la versión de CUDA a instalar
.ci/docker/common/install_magma_conda.sh 12.4

# (opcional) Si usas torch.compile con inductor/triton, instala la versión correspondiente de triton
# Ejecuta desde el directorio pytorch después de clonar
# Para soporte Intel GPU, por favor exporta explícitamente `export USE_XPU=1` antes de ejecutar el comando.
make triton
```

**En MacOS**

```bash
# Agrega este paquete solo en máquinas con procesadores intel x86
pip install mkl-static mkl-include
# Agrega estos paquetes si necesitas torch.distributed
conda install pkg-config libuv
```

**En Windows**

```bash
pip install mkl-static mkl-include
# Agrega estos paquetes si necesitas torch.distributed.
# El soporte de paquetes distribuidos en Windows es una característica prototipo y está sujeta a cambios.
conda install -c conda-forge libuv=1.39
```

#### Instalar PyTorch
**En Linux**

Si estás compilando para AMD ROCm, primero ejecuta este comando:
```bash
# Solo ejecuta esto si estás compilando para ROCm
python tools/amd_build/build_amd.py
```

Instala PyTorch
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**En macOS**

```bash
python3 setup.py develop
```

**En Windows**

Si deseas compilar código Python legado, por favor consulta [Construcción sobre código legado y CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**Compilaciones solo CPU**

En este modo, los cálculos de PyTorch se ejecutarán en tu CPU, no en tu GPU.

```cmd
python setup.py develop
```

Nota sobre OpenMP: La implementación deseada de OpenMP es Intel OpenMP (iomp). Para enlazar con iomp, tendrás que descargar manualmente la biblioteca y configurar el entorno de compilación ajustando `CMAKE_INCLUDE_PATH` y `LIB`. La instrucción [aquí](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) es un ejemplo para configurar tanto MKL como Intel OpenMP. Sin estas configuraciones para CMake, se usará el runtime de OpenMP de Microsoft Visual C (vcomp).

**Compilación basada en CUDA**

En este modo, los cálculos de PyTorch aprovecharán tu GPU mediante CUDA para un procesamiento más rápido.

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) es necesario para construir PyTorch con CUDA.
NVTX es parte de la distribución de CUDA, donde se llama "Nsight Compute". Para instalarlo sobre una instalación de CUDA ya existente, ejecuta nuevamente el instalador de CUDA y marca la casilla correspondiente.
Asegúrate de que CUDA con Nsight Compute esté instalado después de Visual Studio.

Actualmente, VS 2017 / 2019 y Ninja son compatibles como generadores de CMake. Si se detecta `ninja.exe` en el `PATH`, entonces Ninja se usará como generador predeterminado, de lo contrario, se usará VS 2017 / 2019.
<br/> Si se selecciona Ninja como generador, el MSVC más reciente se seleccionará como la herramienta subyacente.

Se necesitan librerías adicionales como
[Magma](https://developer.nvidia.com/magma), [oneDNN, también conocido como MKLDNN o DNNL](https://github.com/oneapi-src/oneDNN), y [Sccache](https://github.com/mozilla/sccache). Por favor, consulta el [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) para instalarlas.

Puedes consultar el script [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) para otras configuraciones de variables de entorno.


```cmd
cmd

:: Establece las variables de entorno después de haber descargado y descomprimido el paquete mkl,
:: de lo contrario, CMake lanzará un error como `Could NOT find OpenMP`.
set CMAKE_INCLUDE_PATH={Tu directorio}\mkl\include
set LIB={Tu directorio}\mkl\lib;%LIB%

:: Lee cuidadosamente el contenido de la sección anterior antes de continuar.
:: [Opcional] Si deseas sobrescribir el toolset subyacente usado por Ninja y Visual Studio con CUDA, por favor ejecuta el siguiente bloque de script.
:: El "Visual Studio 2019 Developer Command Prompt" se ejecutará automáticamente.
:: Asegúrate de tener CMake >= 3.12 antes de hacer esto si usas el generador de Visual Studio.
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [Opcional] Si deseas sobrescribir el compilador host de CUDA
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Compilaciones Intel GPU**

En este modo, se construirá PyTorch con soporte para Intel GPU.

Por favor, asegúrate de que [los prerrequisitos comunes](#prerequisites) así como [los prerrequisitos para Intel GPU](#intel-gpu-support) estén correctamente instalados y que las variables de entorno estén configuradas antes de comenzar la construcción. Para el soporte de herramientas de compilación, se requiere `Visual Studio 2022`.

Luego PyTorch puede ser construido con el comando:

```cmd
:: Comandos CMD:
:: Establece CMAKE_PREFIX_PATH para ayudar a encontrar los paquetes correspondientes
:: %CONDA_PREFIX% solo funciona después de `conda activate custom_env`

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### Ajustar opciones de compilación (Opcional)

Puedes ajustar la configuración de variables cmake opcionalmente (sin compilar primero), haciendo lo siguiente. Por ejemplo, ajustar los directorios pre-detectados para CuDNN o BLAS puede hacerse con este paso.

En Linux
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # o cmake-gui build
```

En macOS
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # o cmake-gui build
```

### Imagen Docker

#### Uso de imágenes preconstruidas

También puedes descargar una imagen docker preconstruida desde Docker Hub y ejecutar con docker v19.03+

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

Por favor, ten en cuenta que PyTorch utiliza memoria compartida para compartir datos entre procesos, por lo que si se usa multiprocesamiento torch (por ejemplo,
para data loaders multihilo), el segmento de memoria compartida predeterminado con el que se ejecuta el contenedor no es suficiente, y deberías aumentar el tamaño de la memoria compartida ya sea con las opciones de línea de comandos `--ipc=host` o `--shm-size` para `nvidia-docker run`.

#### Construyendo la imagen por ti mismo

**NOTA:** Debe construirse con una versión de docker > 18.06

El `Dockerfile` se suministra para construir imágenes con soporte CUDA 11.1 y cuDNN v8.
Puedes pasar la variable make `PYTHON_VERSION=x.y` para especificar qué versión de Python será utilizada por Miniconda, o dejarla
sin establecer para usar la predeterminada.

```bash
make -f docker.Makefile
# las imágenes se etiquetan como docker.io/${tu_usuario_docker}/pytorch
```

También puedes pasar la variable de entorno `CMAKE_VARS="..."` para especificar variables adicionales de CMake a ser pasadas durante la compilación.
Consulta [setup.py](./setup.py) para la lista de variables disponibles.

```bash
make -f docker.Makefile
```

### Construcción de la documentación

Para construir la documentación en varios formatos, necesitarás [Sphinx](http://www.sphinx-doc.org)
y el tema pytorch_sphinx_theme2.

Antes de construir la documentación localmente, asegúrate de que `torch` esté
instalado en tu entorno. Para pequeños arreglos, puedes instalar la
versión nightly como se describe en [Primeros Pasos](https://pytorch.org/get-started/locally/).

Para arreglos más complejos, como agregar un nuevo módulo y docstrings para
el nuevo módulo, puede que necesites instalar torch [desde el código fuente](#from-source).
Consulta [Guía de Docstrings](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)
para las convenciones de docstring.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

Ejecuta `make` para obtener una lista de todos los formatos de salida disponibles.

Si obtienes un error de katex ejecuta `npm install katex`. Si persiste, intenta
`npm install -g katex`

> [!NOTA]
> Si instalaste `nodejs` con un gestor de paquetes diferente (por ejemplo,
> `conda`), probablemente `npm` instalará una versión de `katex` que no es
> compatible con tu versión de `nodejs` y la compilación de la documentación fallará.
> Una combinación de versiones que se sabe funciona es `node@6.13.1` y
> `katex@0.13.18`. Para instalar esta última con `npm` puedes ejecutar
> ```npm install -g katex@0.13.18```

> [!NOTA]
> Si ves un error de incompatibilidad de numpy, ejecuta:
> ```
> pip install 'numpy<2'
> ```

Cuando realices cambios en las dependencias ejecutadas por CI, edita el
archivo `.ci/docker/requirements-docs.txt`.

#### Creando un PDF

Para compilar un PDF de toda la documentación de PyTorch, asegúrate de tener
`texlive` y LaTeX instalados. En macOS, puedes instalarlos usando:

```
brew install --cask mactex
```

Para crear el PDF:

1. Ejecuta:

   ```
   make latexpdf
   ```

   Esto generará los archivos necesarios en el directorio `build/latex`.

2. Navega a este directorio y ejecuta:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   Esto producirá un `pytorch.pdf` con el contenido deseado. Ejecuta este
   comando una vez más para que genere la tabla de contenidos
   y el índice correctamente.

> [!NOTA]
> Para ver la Tabla de Contenidos, cambia a la vista **Tabla de Contenidos**
> en tu visor de PDF.


### Versiones anteriores

Las instrucciones de instalación y binarios para versiones anteriores de PyTorch pueden encontrarse
en [nuestro sitio web](https://pytorch.org/get-started/previous-versions).


## Primeros pasos

Tres recursos para comenzar:
- [Tutoriales: te ayudan a entender y usar PyTorch](https://pytorch.org/tutorials/)
- [Ejemplos: código PyTorch fácil de entender en todos los dominios](https://github.com/pytorch/examples)
- [La Referencia de la API](https://pytorch.org/docs/)
- [Glosario](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## Recursos

* [PyTorch.org](https://pytorch.org/)
* [Tutoriales de PyTorch](https://pytorch.org/tutorials/)
* [Ejemplos de PyTorch](https://github.com/pytorch/examples)
* [Modelos de PyTorch](https://pytorch.org/hub/)
* [Introducción al Deep Learning con PyTorch de Udacity](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Introducción al Machine Learning con PyTorch de Udacity](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Redes neuronales profundas con PyTorch de Coursera](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [Blog de PyTorch](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## Comunicación
* Foros: Discute implementaciones, investigación, etc. https://discuss.pytorch.org
* GitHub Issues: Reportes de errores, solicitudes de características, problemas de instalación, RFCs, ideas, etc.
* Slack: El [Slack de PyTorch](https://pytorch.slack.com/) alberga principalmente usuarios y desarrolladores de PyTorch con experiencia para charlas generales, discusiones en línea, colaboración, etc. Si eres principiante y buscas ayuda, el medio principal es [PyTorch Forums](https://discuss.pytorch.org). Si necesitas una invitación a Slack, por favor completa este formulario: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* Newsletter: Sin ruido, un boletín unidireccional con anuncios importantes sobre PyTorch. Puedes suscribirte aquí: https://eepurl.com/cbG0rv
* Página de Facebook: Anuncios importantes sobre PyTorch. https://www.facebook.com/pytorch
* Para directrices de marca, por favor visita nuestro sitio web en [pytorch.org](https://pytorch.org/)

## Lanzamientos y contribuciones

Normalmente, PyTorch tiene tres lanzamientos menores al año. Por favor, háznos saber si encuentras un error [abriendo un issue](https://github.com/pytorch/pytorch/issues).

Apreciamos todas las contribuciones. Si planeas contribuir con correcciones de errores, hazlo sin más discusión.

Si planeas contribuir con nuevas características, funciones utilitarias o extensiones al núcleo, primero abre un issue y discútelo con nosotros.
Enviar un PR sin discusión puede resultar en un rechazo porque podríamos estar llevando el núcleo en una dirección diferente de la que conoces.

Para aprender más sobre cómo contribuir a PyTorch, por favor consulta nuestra [página de contribuciones](CONTRIBUTING.md). Para más información sobre lanzamientos de PyTorch, consulta la [página de lanzamientos](RELEASE.md).

## El equipo

PyTorch es un proyecto impulsado por la comunidad con varios ingenieros e investigadores talentosos que contribuyen.

PyTorch es mantenido actualmente por [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang), y [Nikita Shulga](https://github.com/malfet) con importantes contribuciones de cientos de individuos talentosos en diversas formas y medios.
Una lista no exhaustiva pero en crecimiento incluye: [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito).

Nota: Este proyecto no está relacionado con [hughperkins/pytorch](https://github.com/hughperkins/pytorch) que tiene el mismo nombre. Hugh es un valioso colaborador de la comunidad Torch y ha ayudado con muchos aspectos de Torch y PyTorch.

## Licencia

PyTorch tiene una licencia de estilo BSD, como se encuentra en el archivo [LICENSE](LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---