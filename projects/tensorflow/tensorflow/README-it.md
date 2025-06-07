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

**`Documentazione`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) è una piattaforma open source end-to-end
per l’apprendimento automatico. Dispone di un ecosistema completo e flessibile di
[strumenti](https://www.tensorflow.org/resources/tools),
[librerie](https://www.tensorflow.org/resources/libraries-extensions) e
[risorse della comunità](https://www.tensorflow.org/community) che permette
ai ricercatori di spingere lo stato dell’arte nel ML e agli sviluppatori di creare e
distribuire facilmente applicazioni alimentate dal ML.

TensorFlow è stato originariamente sviluppato da ricercatori e ingegneri che lavoravano nel
team Machine Intelligence di Google Brain per condurre ricerche nell’apprendimento automatico
e nelle reti neurali. Tuttavia, il framework è abbastanza versatile da essere
utilizzato anche in altri ambiti.

TensorFlow fornisce API stabili per [Python](https://www.tensorflow.org/api_docs/python)
e [C++](https://www.tensorflow.org/api_docs/cc), oltre a una API
non garantita retrocompatibile per
[altre lingue](https://www.tensorflow.org/api_docs).

Rimani aggiornato con gli annunci di rilascio e gli aggiornamenti di sicurezza iscrivendoti a
[announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce).
Consulta tutte le [mailing list](https://www.tensorflow.org/community/forums).

## Installazione

Consulta la [guida all’installazione di TensorFlow](https://www.tensorflow.org/install) per il
[pacchetto pip](https://www.tensorflow.org/install/pip), per
[abilitare il supporto GPU](https://www.tensorflow.org/install/gpu), usare un
[contenitore Docker](https://www.tensorflow.org/install/docker) e
[compilare dai sorgenti](https://www.tensorflow.org/install/source).

Per installare la versione attuale, che include il supporto per
[schede GPU abilitate CUDA](https://www.tensorflow.org/install/gpu) *(Ubuntu e
Windows)*:

```
$ pip install tensorflow
```

Altri dispositivi (DirectX e MacOS-metal) sono supportati tramite
[plugin di dispositivo](https://www.tensorflow.org/install/gpu_plugins#available_devices).

È disponibile anche un pacchetto più piccolo solo CPU:

```
$ pip install tensorflow-cpu
```

Per aggiornare TensorFlow all’ultima versione, aggiungi il flag `--upgrade` ai comandi sopra indicati.

*I binari nightly sono disponibili per i test tramite i pacchetti
[tf-nightly](https://pypi.python.org/pypi/tf-nightly) e
[tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) su PyPI.*

#### *Prova il tuo primo programma TensorFlow*

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

Per altri esempi, consulta i
[tutorial di TensorFlow](https://www.tensorflow.org/tutorials/).

## Linee guida per il contributo

**Se vuoi contribuire a TensorFlow, assicurati di leggere le
[linee guida per il contributo](CONTRIBUTING.md). Questo progetto aderisce al
[codice di condotta](CODE_OF_CONDUCT.md) di TensorFlow. Partecipando, ci si aspetta che
tu rispetti questo codice.**

**Utilizziamo le [issue di GitHub](https://github.com/tensorflow/tensorflow/issues) per
tenere traccia di richieste e bug, consulta il
[Forum di TensorFlow](https://discuss.tensorflow.org/) per domande generali e
discussioni, e indirizza domande specifiche a
[Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow).**

Il progetto TensorFlow si impegna a rispettare le best practice generalmente accettate nello
sviluppo di software open-source.

## Linee guida per le patch

Segui questi passaggi per applicare una patch a una versione specifica di TensorFlow, ad esempio, per
correggere bug o vulnerabilità di sicurezza:

*   Clona il repository di TensorFlow e passa al branch corrispondente alla versione
    desiderata di TensorFlow, ad esempio, il branch `r2.8` per la versione 2.8.
*   Applica (cioè cherry-pick) le modifiche desiderate e risolvi eventuali conflitti di codice.
*   Esegui i test TensorFlow e assicurati che vengano superati.
*   [Compila](https://www.tensorflow.org/install/source) il pacchetto pip di TensorFlow dai sorgenti.

## Stato della build continua

Puoi trovare ulteriori piattaforme e configurazioni supportate dalla comunità nella
[tabella delle build della comunità TensorFlow SIG Build](https://github.com/tensorflow/build#community-supported-tensorflow-builds).

### Build ufficiali

Tipo di Build                   | Stato                                                                                                                                                                           | Artifacts
------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | TBA
**macOS**                       | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [Scarica](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 e 1**          | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 e 3**          | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**     | Stato temporaneamente non disponibile                                                                                                                                           | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**     | Stato temporaneamente non disponibile                                                                                                                                           | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**     | Stato temporaneamente non disponibile                                                                                                                                           | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU**   | Stato temporaneamente non disponibile                                                                                                                                           | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU**   | Stato temporaneamente non disponibile                                                                                                                                           | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)

## Risorse

*   [TensorFlow.org](https://www.tensorflow.org)
*   [Tutorial TensorFlow](https://www.tensorflow.org/tutorials/)
*   [Modelli Ufficiali TensorFlow](https://github.com/tensorflow/models/tree/master/official)
*   [Esempi TensorFlow](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [Blog TensorFlow](https://blog.tensorflow.org)
*   [Impara il ML con TensorFlow](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow Twitter](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [Roadmap di ottimizzazione dei modelli TensorFlow](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [White Papers TensorFlow](https://www.tensorflow.org/about/bib)
*   [Kit di visualizzazione TensorBoard](https://github.com/tensorflow/tensorboard)
*   [Ricerca del codice TensorFlow](https://cs.opensource.google/tensorflow/tensorflow)

Scopri di più sulla
[comunità TensorFlow](https://www.tensorflow.org/community) e su come
[contribuire](https://www.tensorflow.org/community/contribute).

## Corsi

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## Licenza

[Licenza Apache 2.0](LICENSE)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---