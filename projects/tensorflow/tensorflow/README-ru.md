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

**`Документация`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) — это комплексная открытая платформа
для машинного обучения. Она включает в себя гибкую, всеобъемлющую экосистему
[инструментов](https://www.tensorflow.org/resources/tools),
[библиотек](https://www.tensorflow.org/resources/libraries-extensions) и
[ресурсов сообщества](https://www.tensorflow.org/community), которые позволяют
исследователям продвигать передовые методы в области машинного обучения, а разработчикам — легко создавать и
развёртывать приложения с поддержкой машинного обучения.

TensorFlow был изначально разработан исследователями и инженерами из команды
Machine Intelligence в Google Brain для проведения исследований в области машинного
обучения и нейронных сетей. Тем не менее, фреймворк достаточно универсален, чтобы
использоваться и в других областях.

TensorFlow предоставляет стабильные API на
[Python](https://www.tensorflow.org/api_docs/python) и
[C++](https://www.tensorflow.org/api_docs/cc), а также
API для
[других языков](https://www.tensorflow.org/api_docs), обратная совместимость которых не гарантируется.

Следите за анонсами релизов и обновлениями безопасности, подписавшись на
[announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce).
Смотрите все [списки рассылки](https://www.tensorflow.org/community/forums).

## Установка

См. [руководство по установке TensorFlow](https://www.tensorflow.org/install) для получения информации о
[пакете pip](https://www.tensorflow.org/install/pip),
[включении поддержки GPU](https://www.tensorflow.org/install/gpu), использовании
[Docker-контейнера](https://www.tensorflow.org/install/docker) и
[сборке из исходников](https://www.tensorflow.org/install/source).

Чтобы установить текущую версию, которая включает поддержку
[видеокарт с поддержкой CUDA](https://www.tensorflow.org/install/gpu) *(Ubuntu и
Windows)*:

```
$ pip install tensorflow
```

Другие устройства (DirectX и MacOS-metal) поддерживаются с помощью
[плагинов устройств](https://www.tensorflow.org/install/gpu_plugins#available_devices).

Также доступен облегчённый пакет только для CPU:

```
$ pip install tensorflow-cpu
```

Чтобы обновить TensorFlow до последней версии, добавьте флаг `--upgrade` к указанным выше командам.

*Ночные (nightly) бинарные сборки доступны для тестирования через
пакеты [tf-nightly](https://pypi.python.org/pypi/tf-nightly) и
[tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) на PyPI.*

#### *Попробуйте свою первую программу на TensorFlow*

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

Больше примеров смотрите в
[учебниках по TensorFlow](https://www.tensorflow.org/tutorials/).

## Руководство по внесению изменений

**Если вы хотите внести вклад в TensorFlow, обязательно ознакомьтесь с
[руководством по внесению изменений](CONTRIBUTING.md). Этот проект придерживается
[кодекса поведения](CODE_OF_CONDUCT.md) TensorFlow. При участии от вас ожидается
соблюдение этого кодекса.**

**Мы используем [GitHub issues](https://github.com/tensorflow/tensorflow/issues) для
отслеживания запросов и ошибок. Для общих вопросов и обсуждений смотрите
[форум TensorFlow](https://discuss.tensorflow.org/), а конкретные вопросы, пожалуйста,
задавайте на [Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow).**

Проект TensorFlow стремится следовать общепринятым лучшим практикам
разработки открытого программного обеспечения.

## Руководство по патчам

Выполните следующие шаги, чтобы исправить определённую версию TensorFlow, например,
для устранения ошибок или уязвимостей безопасности:

*   Клонируйте репозиторий TensorFlow и переключитесь на соответствующую ветку
    нужной вам версии TensorFlow, например, ветка `r2.8` для версии 2.8.
*   Примените (cherry-pick) необходимые изменения и разрешите возможные конфликты кода.
*   Запустите тесты TensorFlow и убедитесь, что они проходят успешно.
*   [Соберите](https://www.tensorflow.org/install/source) pip-пакет TensorFlow из исходников.

## Статус непрерывной сборки

Больше поддерживаемых сообществом платформ и конфигураций вы можете найти в
[таблице сборок сообщества TensorFlow SIG Build](https://github.com/tensorflow/build#community-supported-tensorflow-builds).

### Официальные сборки

Тип сборки                     | Статус                                                                                                                                                                           | Артефакты
------------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                  | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                  | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                  | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | TBA
**macOS**                      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**                | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**                | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                    | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [Скачать](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 и 1**         | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 и 3**         | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**    | Статус временно недоступен                                                                                                                                                       | [Ночная сборка](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [Официальный GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**    | Статус временно недоступен                                                                                                                                                       | [Ночная сборка](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [Официальный GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**    | Статус временно недоступен                                                                                                                                                       | [Ночная сборка](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [Официальный GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU**  | Статус временно недоступен                                                                                                                                                       | [Ночная сборка](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [Официальный GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU**  | Статус временно недоступен                                                                                                                                                       | [Ночная сборка](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [Официальный GCS](https://storage.googleapis.com/tensorflow/)

## Ресурсы

*   [TensorFlow.org](https://www.tensorflow.org)
*   [Учебники TensorFlow](https://www.tensorflow.org/tutorials/)
*   [Официальные модели TensorFlow](https://github.com/tensorflow/models/tree/master/official)
*   [Примеры TensorFlow](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [Блог TensorFlow](https://blog.tensorflow.org)
*   [Изучение ML с TensorFlow](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow Twitter](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [Дорожная карта оптимизации моделей TensorFlow](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [Научные статьи TensorFlow](https://www.tensorflow.org/about/bib)
*   [Набор инструментов визуализации TensorBoard](https://github.com/tensorflow/tensorboard)
*   [Поиск кода TensorFlow](https://cs.opensource.google/tensorflow/tensorflow)

Узнайте больше о
[сообществе TensorFlow](https://www.tensorflow.org/community) и о том,
[как внести вклад](https://www.tensorflow.org/community/contribute).

## Курсы

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## Лицензия

[Лицензия Apache 2.0](LICENSE)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---