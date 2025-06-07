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

**`Dokumentation`** |
------------------- |
[![Dokumentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) ist eine Open-Source-Plattform für
maschinelles Lernen, die von Anfang bis Ende genutzt werden kann. Sie verfügt über ein umfassendes, flexibles Ökosystem von
[Tools](https://www.tensorflow.org/resources/tools),
[Bibliotheken](https://www.tensorflow.org/resources/libraries-extensions) und
[Ressourcen der Community](https://www.tensorflow.org/community), das es
Forschern ermöglicht, den Stand der Technik im Bereich ML voranzutreiben, und Entwicklern das einfache Erstellen und Bereitstellen von ML-basierten Anwendungen erlaubt.

TensorFlow wurde ursprünglich von Forschern und Ingenieuren des Machine Intelligence-Teams bei Google Brain entwickelt, um Forschung im Bereich maschinelles Lernen und neuronale Netze zu betreiben. Das Framework ist jedoch vielseitig genug, um auch in anderen Bereichen eingesetzt zu werden.

TensorFlow bietet stabile [Python](https://www.tensorflow.org/api_docs/python)-
und [C++](https://www.tensorflow.org/api_docs/cc)-APIs sowie eine
nicht garantiert abwärtskompatible API für
[andere Sprachen](https://www.tensorflow.org/api_docs).

Bleiben Sie auf dem Laufenden mit Veröffentlichungsankündigungen und Sicherheitsupdates, indem Sie
[announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce) abonnieren.
Alle [Mailinglisten](https://www.tensorflow.org/community/forums) finden Sie hier.

## Installation

Siehe den [TensorFlow-Installationsleitfaden](https://www.tensorflow.org/install) für das
[pip-Paket](https://www.tensorflow.org/install/pip), um
[GPU-Unterstützung zu aktivieren](https://www.tensorflow.org/install/gpu), einen
[Docker-Container zu verwenden](https://www.tensorflow.org/install/docker) oder
[aus dem Quellcode zu bauen](https://www.tensorflow.org/install/source).

Um die aktuelle Version zu installieren, die Unterstützung für
[CUDA-fähige GPU-Karten](https://www.tensorflow.org/install/gpu) *(Ubuntu und
Windows)* beinhaltet:

```
$ pip install tensorflow
```

Andere Geräte (DirectX und MacOS-metal) werden über
[Geräte-Plugins](https://www.tensorflow.org/install/gpu_plugins#available_devices) unterstützt.

Ein kleineres CPU-only-Paket ist ebenfalls verfügbar:

```
$ pip install tensorflow-cpu
```

Um TensorFlow auf die neueste Version zu aktualisieren, fügen Sie den Schalter `--upgrade` zu den obigen Befehlen hinzu.

*Nightly-Binärdateien sind zum Testen über die
[tf-nightly](https://pypi.python.org/pypi/tf-nightly)- und
[tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu)-Pakete auf PyPI verfügbar.*

#### *Probieren Sie Ihr erstes TensorFlow-Programm aus*

```shell
$ python
```

```python
>>> import tensorflow as tf
>>> tf.add(1, 2).numpy()
3
>>> hello = tf.constant('Hallo, TensorFlow!')
>>> hello.numpy()
b'Hallo, TensorFlow!'
```

Weitere Beispiele finden Sie in den
[TensorFlow-Tutorials](https://www.tensorflow.org/tutorials/).

## Richtlinien für Beiträge

**Wenn Sie zu TensorFlow beitragen möchten, lesen Sie bitte die
[Richtlinien für Beiträge](CONTRIBUTING.md). Dieses Projekt hält sich an den
[Verhaltenskodex](CODE_OF_CONDUCT.md) von TensorFlow. Durch Ihre Teilnahme erklären Sie sich bereit,
diesen Kodex einzuhalten.**

**Wir verwenden [GitHub-Issues](https://github.com/tensorflow/tensorflow/issues) zur
Verfolgung von Anfragen und Fehlern. Für allgemeine Fragen und Diskussionen nutzen Sie bitte das
[TensorFlow-Forum](https://discuss.tensorflow.org/) und richten Sie spezifische Fragen an
[Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow).**

Das TensorFlow-Projekt strebt an, allgemein anerkannte Best Practices der Open-Source-Softwareentwicklung einzuhalten.

## Richtlinien für Patches

Befolgen Sie diese Schritte, um eine bestimmte Version von TensorFlow zu patchen, z. B. um Fehler oder Sicherheitslücken zu beheben:

*   Klonen Sie das TensorFlow-Repository und wechseln Sie auf den entsprechenden Branch Ihrer
    gewünschten TensorFlow-Version, z. B. Branch `r2.8` für Version 2.8.
*   Wenden Sie die gewünschten Änderungen an (cherry-pick) und lösen Sie etwaige Codekonflikte.
*   Führen Sie die TensorFlow-Tests aus und stellen Sie sicher, dass sie bestehen.
*   [Bauen](https://www.tensorflow.org/install/source) Sie das TensorFlow-Pip-
    Paket aus dem Quellcode.

## Kontinuierlicher Build-Status

Weitere von der Community unterstützte Plattformen und Konfigurationen finden Sie in der
[Tabelle der Community-Builds der TensorFlow SIG Build-Community](https://github.com/tensorflow/build#community-supported-tensorflow-builds).

### Offizielle Builds

Build-Typ                     | Status                                                                                                                                                                           | Artefakte
----------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | TBA
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [Download](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 und 1**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 und 3**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | Status vorübergehend nicht verfügbar                                                                                                                                              | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | Status vorübergehend nicht verfügbar                                                                                                                                              | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | Status vorübergehend nicht verfügbar                                                                                                                                              | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | Status vorübergehend nicht verfügbar                                                                                                                                              | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | Status vorübergehend nicht verfügbar                                                                                                                                              | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)

## Ressourcen

*   [TensorFlow.org](https://www.tensorflow.org)
*   [TensorFlow-Tutorials](https://www.tensorflow.org/tutorials/)
*   [TensorFlow Offizielle Modelle](https://github.com/tensorflow/models/tree/master/official)
*   [TensorFlow-Beispiele](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [TensorFlow Blog](https://blog.tensorflow.org)
*   [Lernen Sie ML mit TensorFlow](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow Twitter](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [TensorFlow Modelloptimierungs-Roadmap](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [TensorFlow White Papers](https://www.tensorflow.org/about/bib)
*   [TensorBoard Visualisierungstoolkit](https://github.com/tensorflow/tensorboard)
*   [TensorFlow Code Search](https://cs.opensource.google/tensorflow/tensorflow)

Erfahren Sie mehr über die
[TensorFlow-Community](https://www.tensorflow.org/community) und wie Sie
[beitragen](https://www.tensorflow.org/community/contribute) können.

## Kurse

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## Lizenz

[Apache License 2.0](LICENSE)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---