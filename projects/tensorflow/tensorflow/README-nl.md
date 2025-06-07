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

**`Documentatie`** |
------------------- |
[![Documentatie](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) is een end-to-end open source platform
voor machine learning. Het heeft een uitgebreid, flexibel ecosysteem van
[tools](https://www.tensorflow.org/resources/tools),
[bibliotheken](https://www.tensorflow.org/resources/libraries-extensions), en
[community](https://www.tensorflow.org/community) bronnen die
onderzoekers in staat stellen de stand van de techniek in ML te verbeteren en ontwikkelaars eenvoudig ML-aangedreven applicaties te bouwen en te implementeren.

TensorFlow is oorspronkelijk ontwikkeld door onderzoekers en ingenieurs binnen
het Machine Intelligence team van Google Brain om onderzoek te doen naar machine
learning en neurale netwerken. Het framework is echter veelzijdig genoeg om
ook in andere domeinen te worden gebruikt.

TensorFlow biedt stabiele [Python](https://www.tensorflow.org/api_docs/python)
en [C++](https://www.tensorflow.org/api_docs/cc) API’s, evenals een
niet-gegarandeerd achterwaarts compatibele API voor
[andere talen](https://www.tensorflow.org/api_docs).

Blijf op de hoogte van release-aankondigingen en beveiligingsupdates door je te abonneren
op
[announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce).
Bekijk alle [mailinglijsten](https://www.tensorflow.org/community/forums).

## Installatie

Zie de [TensorFlow installatiegids](https://www.tensorflow.org/install) voor het
[pip-pakket](https://www.tensorflow.org/install/pip), om
[GPU-ondersteuning te activeren](https://www.tensorflow.org/install/gpu), een
[Docker-container te gebruiken](https://www.tensorflow.org/install/docker), en
[vanaf bron te bouwen](https://www.tensorflow.org/install/source).

Om de huidige release te installeren, die ondersteuning biedt voor
[CUDA-geschikte GPU-kaarten](https://www.tensorflow.org/install/gpu) *(Ubuntu en
Windows)*:

```
$ pip install tensorflow
```

Andere apparaten (DirectX en MacOS-metal) worden ondersteund met behulp van
[Apparaat-plugins](https://www.tensorflow.org/install/gpu_plugins#available_devices).

Er is ook een kleiner pakket beschikbaar dat alleen op CPU werkt:

```
$ pip install tensorflow-cpu
```

Om TensorFlow bij te werken naar de nieuwste versie, voeg de `--upgrade` vlag toe aan bovenstaande
commando's.

*Nachtelijke binaries zijn beschikbaar voor testen via de
[tf-nightly](https://pypi.python.org/pypi/tf-nightly) en
[tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) pakketten op PyPI.*

#### *Probeer je eerste TensorFlow-programma*

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

Voor meer voorbeelden, zie de
[TensorFlow tutorials](https://www.tensorflow.org/tutorials/).

## Bijdrage richtlijnen

**Als je wilt bijdragen aan TensorFlow, bekijk dan zeker de
[bijdraagerichtlijnen](CONTRIBUTING.md). Dit project volgt de
[gedragscode](CODE_OF_CONDUCT.md) van TensorFlow. Door deel te nemen, wordt van
je verwacht dat je deze code naleeft.**

**We gebruiken [GitHub issues](https://github.com/tensorflow/tensorflow/issues) voor
het bijhouden van verzoeken en bugs, zie
[TensorFlow Forum](https://discuss.tensorflow.org/) voor algemene vragen en
discussie, en stel specifieke vragen op
[Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow).**

Het TensorFlow-project streeft ernaar zich te houden aan algemeen geaccepteerde
best practices in open source software-ontwikkeling.

## Patch richtlijnen

Volg deze stappen om een specifieke versie van TensorFlow te patchen, bijvoorbeeld om
bugs of beveiligingsproblemen te verhelpen:

*   Clone de TensorFlow-repository en schakel over naar de bijbehorende branch voor de gewenste TensorFlow-versie, bijvoorbeeld branch `r2.8` voor versie 2.8.
*   Pas (cherry-pick) de gewenste wijzigingen toe en los eventuele codeconflicten op.
*   Voer TensorFlow-tests uit en zorg dat deze slagen.
*   [Bouw](https://www.tensorflow.org/install/source) het TensorFlow pip-pakket vanaf de bron.

## Continue build status

Je kunt meer community-ondersteunde platforms en configuraties vinden in de
[TensorFlow SIG Build community builds-tabel](https://github.com/tensorflow/build#community-supported-tensorflow-builds).

### Officiële Builds

Type Build                       | Status                                                                                                                                                                           | Artefacten
----------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -----------
**Linux CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | TBA
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [Download](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 en 1**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 en 3**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | Status Tijdelijk Niet Beschikbaar                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [Officiële GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | Status Tijdelijk Niet Beschikbaar                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [Officiële GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | Status Tijdelijk Niet Beschikbaar                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [Officiële GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | Status Tijdelijk Niet Beschikbaar                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [Officiële GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | Status Tijdelijk Niet Beschikbaar                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [Officiële GCS](https://storage.googleapis.com/tensorflow/)

## Bronnen

*   [TensorFlow.org](https://www.tensorflow.org)
*   [TensorFlow Tutorials](https://www.tensorflow.org/tutorials/)
*   [TensorFlow Officiële Modellen](https://github.com/tensorflow/models/tree/master/official)
*   [TensorFlow Voorbeelden](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [TensorFlow Blog](https://blog.tensorflow.org)
*   [Leer ML met TensorFlow](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow Twitter](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [TensorFlow modeloptimalisatie roadmap](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [TensorFlow White Papers](https://www.tensorflow.org/about/bib)
*   [TensorBoard Visualisatietoolkit](https://github.com/tensorflow/tensorboard)
*   [TensorFlow Code Search](https://cs.opensource.google/tensorflow/tensorflow)

Leer meer over de
[TensorFlow-community](https://www.tensorflow.org/community) en hoe je kunt
[bijdagen](https://www.tensorflow.org/community/contribute).

## Cursussen

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## Licentie

[Apache License 2.0](LICENSE)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---