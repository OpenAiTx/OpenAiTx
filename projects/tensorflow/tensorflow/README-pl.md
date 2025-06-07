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

**`Dokumentacja`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) to kompleksowa, otwartoźródłowa platforma
do uczenia maszynowego. Posiada wszechstronny, elastyczny ekosystem
[narzędzi](https://www.tensorflow.org/resources/tools),
[bibliotek](https://www.tensorflow.org/resources/libraries-extensions) oraz
[zasobów społeczności](https://www.tensorflow.org/community), które pozwalają
badaczom przesuwać granice możliwości ML, a deweloperom łatwo budować i wdrażać
aplikacje zasilane przez ML.

TensorFlow został pierwotnie opracowany przez badaczy i inżynierów pracujących w
zespole Machine Intelligence w Google Brain do prowadzenia badań w zakresie uczenia
maszynowego i sieci neuronowych. Jednak framework jest na tyle wszechstronny, że
może być używany również w innych dziedzinach.

TensorFlow zapewnia stabilne API dla [Pythona](https://www.tensorflow.org/api_docs/python)
i [C++](https://www.tensorflow.org/api_docs/cc), a także
niegwarantowaną kompatybilność wsteczną API dla
[innych języków](https://www.tensorflow.org/api_docs).

Bądź na bieżąco z ogłoszeniami o wydaniach i aktualizacjach bezpieczeństwa, subskrybując
[announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce).
Zobacz wszystkie [listy mailingowe](https://www.tensorflow.org/community/forums).

## Instalacja

Zobacz [przewodnik instalacji TensorFlow](https://www.tensorflow.org/install) dla
[pakietu pip](https://www.tensorflow.org/install/pip), aby
[włączyć obsługę GPU](https://www.tensorflow.org/install/gpu), użyć
[kontenera Docker](https://www.tensorflow.org/install/docker) oraz
[zbudować ze źródeł](https://www.tensorflow.org/install/source).

Aby zainstalować bieżące wydanie, które zawiera wsparcie dla
[kart GPU z obsługą CUDA](https://www.tensorflow.org/install/gpu) *(Ubuntu i Windows)*:

```
$ pip install tensorflow
```

Inne urządzenia (DirectX i MacOS-metal) są obsługiwane za pomocą
[wtyczek urządzeń](https://www.tensorflow.org/install/gpu_plugins#available_devices).

Dostępny jest również mniejszy pakiet tylko dla CPU:

```
$ pip install tensorflow-cpu
```

Aby zaktualizować TensorFlow do najnowszej wersji, dodaj flagę `--upgrade` do powyższych
poleceń.

*Wersje nocne są dostępne do testowania za pomocą pakietów
[tf-nightly](https://pypi.python.org/pypi/tf-nightly) oraz
[tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) na PyPI.*

#### *Spróbuj swojego pierwszego programu w TensorFlow*

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

Więcej przykładów znajdziesz w
[Samouczkach TensorFlow](https://www.tensorflow.org/tutorials/).

## Wytyczne dotyczące współtworzenia

**Jeśli chcesz współtworzyć TensorFlow, koniecznie zapoznaj się z
[wytycznymi dotyczącymi współtworzenia](CONTRIBUTING.md). Ten projekt przestrzega
[kodeksu postępowania](CODE_OF_CONDUCT.md) TensorFlow. Uczestnicząc, oczekujemy,
że będziesz przestrzegać tego kodeksu.**

**Używamy [zgłoszeń GitHub](https://github.com/tensorflow/tensorflow/issues) do
śledzenia próśb i błędów, zobacz
[Forum TensorFlow](https://discuss.tensorflow.org/) w celu zadawania ogólnych pytań i
dyskusji, a szczegółowe pytania kieruj na
[Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow).**

Projekt TensorFlow stara się stosować powszechnie akceptowane dobre praktyki w
rozwoju oprogramowania open source.

## Wytyczne dotyczące poprawek

Postępuj zgodnie z poniższymi krokami, aby załatać konkretną wersję TensorFlow, na przykład
w celu naprawienia błędów lub luk bezpieczeństwa:

*   Sklonuj repozytorium TensorFlow i przejdź do odpowiedniej gałęzi dla wybranej wersji TensorFlow, na przykład do gałęzi `r2.8` dla wersji 2.8.
*   Zastosuj (czyli cherry-pickuj) wybrane zmiany i rozwiąż wszelkie konflikty w kodzie.
*   Uruchom testy TensorFlow i upewnij się, że przechodzą pomyślnie.
*   [Zbuduj](https://www.tensorflow.org/install/source) pakiet pip TensorFlow ze źródeł.

## Status ciągłej budowy

Więcej platform i konfiguracji wspieranych przez społeczność znajdziesz w
[tabeli buildów społeczności TensorFlow SIG Build](https://github.com/tensorflow/build#community-supported-tensorflow-builds).

### Oficjalne buildy

Typ builda                     | Status                                                                                                                                                                           | Artefakty
----------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | TBA
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [Pobierz](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 i 1**        | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 i 3**        | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | Status tymczasowo niedostępny                                                                                                                                                    | [Binarna wersja nocna](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [Oficjalny GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | Status tymczasowo niedostępny                                                                                                                                                    | [Binarna wersja nocna](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [Oficjalny GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | Status tymczasowo niedostępny                                                                                                                                                    | [Binarna wersja nocna](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [Oficjalny GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | Status tymczasowo niedostępny                                                                                                                                                    | [Binarna wersja nocna](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [Oficjalny GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | Status tymczasowo niedostępny                                                                                                                                                    | [Binarna wersja nocna](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [Oficjalny GCS](https://storage.googleapis.com/tensorflow/)

## Zasoby

*   [TensorFlow.org](https://www.tensorflow.org)
*   [Samouczki TensorFlow](https://www.tensorflow.org/tutorials/)
*   [Oficjalne modele TensorFlow](https://github.com/tensorflow/models/tree/master/official)
*   [Przykłady TensorFlow](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [Blog TensorFlow](https://blog.tensorflow.org)
*   [Naucz się ML z TensorFlow](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow Twitter](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [Mapa drogowa optymalizacji modeli TensorFlow](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [Białe księgi TensorFlow](https://www.tensorflow.org/about/bib)
*   [Narzędzie wizualizacji TensorBoard](https://github.com/tensorflow/tensorboard)
*   [TensorFlow Code Search](https://cs.opensource.google/tensorflow/tensorflow)

Dowiedz się więcej o
[społeczności TensorFlow](https://www.tensorflow.org/community) oraz o tym, jak
[współtworzyć](https://www.tensorflow.org/community/contribute).

## Kursy

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## Licencja

[Licencja Apache 2.0](LICENSE)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---