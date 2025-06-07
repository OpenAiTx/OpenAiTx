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

**`Documentation`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) est une plateforme open source de bout en bout
pour l'apprentissage automatique. Elle dispose d'un écosystème complet et flexible de
[outils](https://www.tensorflow.org/resources/tools),
[bibliothèques](https://www.tensorflow.org/resources/libraries-extensions), et de
[ressources communautaires](https://www.tensorflow.org/community) permettant
aux chercheurs de faire avancer l'état de l'art en IA et aux développeurs de créer et
déployer facilement des applications alimentées par l'apprentissage automatique.

TensorFlow a été développé à l'origine par des chercheurs et ingénieurs de l'équipe Machine Intelligence de Google Brain pour mener des recherches sur l'apprentissage automatique et les réseaux de neurones. Cependant, le framework est suffisamment polyvalent pour être utilisé dans d'autres domaines également.

TensorFlow propose des API stables pour [Python](https://www.tensorflow.org/api_docs/python)
et [C++](https://www.tensorflow.org/api_docs/cc), ainsi qu'une API
non garantie rétrocompatible pour
[d'autres langages](https://www.tensorflow.org/api_docs).

Restez informé des annonces de nouvelles versions et des mises à jour de sécurité en vous abonnant à
[announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce).
Voir toutes les [listes de diffusion](https://www.tensorflow.org/community/forums).

## Installation

Consultez le [guide d'installation de TensorFlow](https://www.tensorflow.org/install) pour le
[paquet pip](https://www.tensorflow.org/install/pip), pour
[activer la prise en charge du GPU](https://www.tensorflow.org/install/gpu), utiliser un
[conteneur Docker](https://www.tensorflow.org/install/docker), ou
[compiler depuis les sources](https://www.tensorflow.org/install/source).

Pour installer la version courante, qui inclut la prise en charge des
[cartes GPU compatibles CUDA](https://www.tensorflow.org/install/gpu) *(Ubuntu et
Windows)* :

```
$ pip install tensorflow
```

D'autres appareils (DirectX et MacOS-metal) sont pris en charge via les
[plugins de périphériques](https://www.tensorflow.org/install/gpu_plugins#available_devices).

Un paquet plus léger pour CPU uniquement est également disponible :

```
$ pip install tensorflow-cpu
```

Pour mettre à jour TensorFlow vers la dernière version, ajoutez l'option `--upgrade` aux commandes ci-dessus.

*Des binaires nightly sont disponibles pour les tests via les paquets
[tf-nightly](https://pypi.python.org/pypi/tf-nightly) et
[tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) sur PyPI.*

#### *Essayez votre premier programme TensorFlow*

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

Pour plus d'exemples, consultez les
[tutoriels TensorFlow](https://www.tensorflow.org/tutorials/).

## Directives de contribution

**Si vous souhaitez contribuer à TensorFlow, veillez à lire les
[directives de contribution](CONTRIBUTING.md). Ce projet adhère au
[code de conduite](CODE_OF_CONDUCT.md) de TensorFlow. En participant, vous êtes tenu
de respecter ce code.**

**Nous utilisons les [issues GitHub](https://github.com/tensorflow/tensorflow/issues) pour
le suivi des demandes et des bugs ; veuillez consulter le
[Forum TensorFlow](https://discuss.tensorflow.org/) pour les questions générales et
discussions, et posez vos questions spécifiques sur
[Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow).**

Le projet TensorFlow s'efforce de suivre les meilleures pratiques généralement acceptées en développement logiciel open source.

## Directives de correctifs

Suivez ces étapes pour corriger une version spécifique de TensorFlow, par exemple pour
appliquer des correctifs à des bugs ou des vulnérabilités de sécurité :

*   Clonez le dépôt TensorFlow et passez sur la branche correspondante à la version souhaitée, par exemple, la branche `r2.8` pour la version 2.8.
*   Appliquez (c'est-à-dire, cherry-pick) les modifications souhaitées et résolvez les conflits éventuels dans le code.
*   Exécutez les tests TensorFlow et assurez-vous qu'ils passent.
*   [Compilez](https://www.tensorflow.org/install/source) le paquet pip TensorFlow à partir des sources.

## Statut des builds continus

Vous pouvez trouver plus de plateformes et de configurations supportées par la communauté dans le
[tableau des builds communautaires TensorFlow SIG Build](https://github.com/tensorflow/build#community-supported-tensorflow-builds).

### Builds officiels

Type de build                   | Statut                                                                                                                                                                            | Artifacts
------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------
**Linux CPU**                   | [![Statut](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                   | [![Statut](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                   | [![Statut](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | À venir
**macOS**                       | [![Statut](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**                 | [![Statut](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**                 | [![Statut](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                     | [![Statut](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [Télécharger](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 et 1**         | [![Statut](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 et 3**         | [![Statut](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**     | Statut temporairement indisponible                                                                                                                                                | [Binaire nightly](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [GCS officiel](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**     | Statut temporairement indisponible                                                                                                                                                | [Binaire nightly](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [GCS officiel](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**     | Statut temporairement indisponible                                                                                                                                                | [Binaire nightly](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [GCS officiel](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU**   | Statut temporairement indisponible                                                                                                                                                | [Binaire nightly](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [GCS officiel](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU**   | Statut temporairement indisponible                                                                                                                                                | [Binaire nightly](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [GCS officiel](https://storage.googleapis.com/tensorflow/)

## Ressources

*   [TensorFlow.org](https://www.tensorflow.org)
*   [Tutoriels TensorFlow](https://www.tensorflow.org/tutorials/)
*   [Modèles officiels TensorFlow](https://github.com/tensorflow/models/tree/master/official)
*   [Exemples TensorFlow](https://github.com/tensorflow/examples)
*   [Codelabs TensorFlow](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [Blog TensorFlow](https://blog.tensorflow.org)
*   [Apprendre le ML avec TensorFlow](https://www.tensorflow.org/resources/learn-ml)
*   [Twitter TensorFlow](https://twitter.com/tensorflow)
*   [YouTube TensorFlow](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [Feuille de route optimisation de modèle TensorFlow](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [Livres blancs TensorFlow](https://www.tensorflow.org/about/bib)
*   [Kit de visualisation TensorBoard](https://github.com/tensorflow/tensorboard)
*   [Recherche de code TensorFlow](https://cs.opensource.google/tensorflow/tensorflow)

En savoir plus sur la
[communauté TensorFlow](https://www.tensorflow.org/community) et comment
[contribuer](https://www.tensorflow.org/community/contribute).

## Cours

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## Licence

[Licence Apache 2.0](LICENSE)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---