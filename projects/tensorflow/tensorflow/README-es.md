<div align="center">
  <img src="https://www.tensorflow.org/images/tf_logo_horizontal.png">
</div>

[![Python](https://img.shields.io/pypi/pyversions/tensorflow.svg)](https://badge.fury.io/py/tensorflow)
[![PyPI](https://badge.fury.io/py/tensorflow.svg)](https://badge.fury.io/py/tensorflow)
[![DOI](https://zenodo.org/badge/DOI/10.5281/zenodo.4724125.svg)](https://doi.org/10.5281/zenodo.4724125)
[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1486/badge)](https://bestpractices.coreinfrastructure.org/projects/1486)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/tensorflow/tensorflow/badge)](https://securityscorecards.dev/viewer/?uri=github.com/tensorflow/tensorflow)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/tensorflow.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:tensorflow)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/tensorflow-py.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:tensorflow-py)
[![OSSRank](https://shields.io/endpoint?url=https://ossrank.com/shield/44)](https://ossrank.com/p/44)
[![Contributor Covenant](https://img.shields.io/badge/Contributor%20Covenant-v1.4%20adopted-ff69b4.svg)](CODE_OF_CONDUCT.md)

**`Documentación`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) es una plataforma de código abierto de extremo a extremo para el aprendizaje automático. Cuenta con un ecosistema completo y flexible de [herramientas](https://www.tensorflow.org/resources/tools), [librerías](https://www.tensorflow.org/resources/libraries-extensions) y recursos de [comunidad](https://www.tensorflow.org/community) que permite a los investigadores impulsar el estado del arte en ML y a los desarrolladores crear y desplegar fácilmente aplicaciones impulsadas por ML.

TensorFlow fue desarrollado originalmente por investigadores e ingenieros que trabajaban en el equipo de Machine Intelligence de Google Brain para realizar investigaciones en aprendizaje automático y redes neuronales. Sin embargo, el framework es lo suficientemente versátil como para ser utilizado también en otras áreas.

TensorFlow proporciona API estables para [Python](https://www.tensorflow.org/api_docs/python) y [C++](https://www.tensorflow.org/api_docs/cc), así como una API no garantizada retrocompatible para [otros lenguajes](https://www.tensorflow.org/api_docs).

Manténgase actualizado con los anuncios de lanzamientos y actualizaciones de seguridad suscribiéndose a [announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce). Vea todas las [listas de correo](https://www.tensorflow.org/community/forums).

## Instalación

Consulte la [guía de instalación de TensorFlow](https://www.tensorflow.org/install) para el [paquete pip](https://www.tensorflow.org/install/pip), para [habilitar el soporte de GPU](https://www.tensorflow.org/install/gpu), usar un [contenedor Docker](https://www.tensorflow.org/install/docker) y [compilar desde el código fuente](https://www.tensorflow.org/install/source).

Para instalar la versión actual, que incluye soporte para [tarjetas GPU habilitadas para CUDA](https://www.tensorflow.org/install/gpu) *(Ubuntu y Windows)*:

```
$ pip install tensorflow
```

Otros dispositivos (DirectX y MacOS-metal) son compatibles mediante el uso de [plugins de dispositivo](https://www.tensorflow.org/install/gpu_plugins#available_devices).

También está disponible un paquete más pequeño solo para CPU:

```
$ pip install tensorflow-cpu
```

Para actualizar TensorFlow a la última versión, agregue la bandera `--upgrade` a los comandos anteriores.

*Binarios nocturnos están disponibles para pruebas utilizando los paquetes [tf-nightly](https://pypi.python.org/pypi/tf-nightly) y [tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) en PyPI.*

#### *Pruebe su primer programa en TensorFlow*

```shell
$ python
```

```python
>>> import tensorflow as tf
>>> tf.add(1, 2).numpy()
3
>>> hello = tf.constant('Hello, TensorFlow!')
>>> hello.numpy()
b'Hello, TensorFlow!'
```

Para más ejemplos, consulte los [tutoriales de TensorFlow](https://www.tensorflow.org/tutorials/).

## Directrices de contribución

**Si desea contribuir a TensorFlow, asegúrese de revisar las [directrices de contribución](CONTRIBUTING.md). Este proyecto se adhiere al [código de conducta](CODE_OF_CONDUCT.md) de TensorFlow. Al participar, se espera que cumpla con este código.**

**Utilizamos [issues de GitHub](https://github.com/tensorflow/tensorflow/issues) para el seguimiento de solicitudes y errores. Por favor, consulte el [Foro de TensorFlow](https://discuss.tensorflow.org/) para preguntas generales y discusión, y dirija preguntas específicas a [Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow).**

El proyecto TensorFlow se esfuerza por cumplir con las mejores prácticas generalmente aceptadas en el desarrollo de software de código abierto.

## Directrices para aplicar parches

Siga estos pasos para aplicar un parche a una versión específica de TensorFlow, por ejemplo, para corregir errores o vulnerabilidades de seguridad:

*   Clone el repositorio de TensorFlow y cambie a la rama correspondiente a la versión de TensorFlow que desee, por ejemplo, la rama `r2.8` para la versión 2.8.
*   Aplique (es decir, realice cherry-pick) los cambios deseados y resuelva cualquier conflicto de código.
*   Ejecute las pruebas de TensorFlow y asegúrese de que pasen correctamente.
*   [Compile](https://www.tensorflow.org/install/source) el paquete pip de TensorFlow desde el código fuente.

## Estado de compilaciones continuas

Puede encontrar más plataformas y configuraciones soportadas por la comunidad en la [tabla de compilaciones comunitarias de TensorFlow SIG Build](https://github.com/tensorflow/build#community-supported-tensorflow-builds).

### Compilaciones oficiales

Tipo de compilación               | Estado                                                                                                                                                                            | Artefactos
----------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | TBA
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [Descarga](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 y 1**        | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 y 3**        | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | Estado temporalmente no disponible                                                                                                                                                | [Binario nocturno](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [GCS Oficial](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | Estado temporalmente no disponible                                                                                                                                                | [Binario nocturno](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [GCS Oficial](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | Estado temporalmente no disponible                                                                                                                                                | [Binario nocturno](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [GCS Oficial](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | Estado temporalmente no disponible                                                                                                                                                | [Binario nocturno](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [GCS Oficial](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | Estado temporalmente no disponible                                                                                                                                                | [Binario nocturno](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [GCS Oficial](https://storage.googleapis.com/tensorflow/)

## Recursos

*   [TensorFlow.org](https://www.tensorflow.org)
*   [Tutoriales de TensorFlow](https://www.tensorflow.org/tutorials/)
*   [Modelos oficiales de TensorFlow](https://github.com/tensorflow/models/tree/master/official)
*   [Ejemplos de TensorFlow](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [Blog de TensorFlow](https://blog.tensorflow.org)
*   [Aprende ML con TensorFlow](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow Twitter](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [Hoja de ruta de optimización de modelos de TensorFlow](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [Publicaciones técnicas de TensorFlow](https://www.tensorflow.org/about/bib)
*   [Herramienta de visualización TensorBoard](https://github.com/tensorflow/tensorboard)
*   [Búsqueda de código de TensorFlow](https://cs.opensource.google/tensorflow/tensorflow)

Aprenda más sobre la [comunidad de TensorFlow](https://www.tensorflow.org/community) y cómo [contribuir](https://www.tensorflow.org/community/contribute).

## Cursos

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## Licencia

[Licencia Apache 2.0](LICENSE)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---