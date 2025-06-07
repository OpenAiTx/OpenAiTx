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

**`Dokumentasi`** |
------------------- |
[![Dokumentasi](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) adalah platform open source end-to-end
untuk pembelajaran mesin. TensorFlow memiliki ekosistem yang komprehensif dan fleksibel yang berisi
[alat](https://www.tensorflow.org/resources/tools),
[pustaka](https://www.tensorflow.org/resources/libraries-extensions), dan
[sumber daya komunitas](https://www.tensorflow.org/community) yang memungkinkan
peneliti mendorong perkembangan terbaru dalam ML dan pengembang dengan mudah membangun serta
mendistribusikan aplikasi yang didukung ML.

TensorFlow awalnya dikembangkan oleh para peneliti dan insinyur yang bekerja di
tim Machine Intelligence di Google Brain untuk melakukan riset pembelajaran mesin dan jaringan saraf. Namun, framework ini cukup fleksibel untuk
digunakan di bidang lain juga.

TensorFlow menyediakan API [Python](https://www.tensorflow.org/api_docs/python)
dan [C++](https://www.tensorflow.org/api_docs/cc) yang stabil, serta API untuk
[bahasa lain](https://www.tensorflow.org/api_docs) yang kompatibilitas mundurnya
tidak dijamin.

Tetap terinformasi dengan pengumuman rilis dan pembaruan keamanan dengan berlangganan ke
[announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce).
Lihat semua [milis](https://www.tensorflow.org/community/forums).

## Instalasi

Lihat [panduan instalasi TensorFlow](https://www.tensorflow.org/install) untuk
[paket pip](https://www.tensorflow.org/install/pip), untuk
[mengaktifkan dukungan GPU](https://www.tensorflow.org/install/gpu), menggunakan
[kontainer Docker](https://www.tensorflow.org/install/docker), dan
[membangun dari sumber](https://www.tensorflow.org/install/source).

Untuk memasang rilis saat ini, yang sudah mendukung
[kartu GPU dengan CUDA](https://www.tensorflow.org/install/gpu) *(Ubuntu dan
Windows)*:

```
$ pip install tensorflow
```

Perangkat lain (DirectX dan MacOS-metal) didukung menggunakan
[Plugin perangkat](https://www.tensorflow.org/install/gpu_plugins#available_devices).

Paket lebih kecil untuk CPU saja juga tersedia:

```
$ pip install tensorflow-cpu
```

Untuk memperbarui TensorFlow ke versi terbaru, tambahkan flag `--upgrade` pada perintah di atas.

*Biner nightly tersedia untuk pengujian menggunakan paket
[tf-nightly](https://pypi.python.org/pypi/tf-nightly) dan
[tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) di PyPI.*

#### *Coba program TensorFlow pertamamu*

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

Untuk contoh lain, lihat
[tutorial TensorFlow](https://www.tensorflow.org/tutorials/).

## Panduan Kontribusi

**Jika Anda ingin berkontribusi pada TensorFlow, pastikan untuk membaca
[panduan kontribusi](CONTRIBUTING.md). Proyek ini mematuhi
[kode etik](CODE_OF_CONDUCT.md) TensorFlow. Dengan berpartisipasi, Anda diharapkan untuk
menjunjung tinggi kode etik ini.**

**Kami menggunakan [GitHub issues](https://github.com/tensorflow/tensorflow/issues) untuk
melacak permintaan dan bug, silakan lihat
[Forum TensorFlow](https://discuss.tensorflow.org/) untuk pertanyaan umum dan
diskusi, dan untuk pertanyaan spesifik silakan langsung ke
[Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow).**

Proyek TensorFlow berupaya mematuhi praktik terbaik yang diakui secara umum dalam
pengembangan perangkat lunak open source.

## Panduan Patch

Ikuti langkah-langkah berikut untuk melakukan patch pada versi TensorFlow tertentu, misalnya, untuk
memperbaiki bug atau kerentanan keamanan:

*   Clone repo TensorFlow dan pindah ke branch yang sesuai dengan
    versi TensorFlow yang diinginkan, misalnya, branch `r2.8` untuk versi 2.8.
*   Terapkan (cherry-pick) perubahan yang diinginkan dan selesaikan konflik kode jika ada.
*   Jalankan pengujian TensorFlow dan pastikan semua pengujian lulus.
*   [Bangun](https://www.tensorflow.org/install/source) paket pip TensorFlow dari sumber.

## Status Build Berkelanjutan

Anda dapat menemukan lebih banyak platform dan konfigurasi yang didukung komunitas pada
[tabel build komunitas TensorFlow SIG Build](https://github.com/tensorflow/build#community-supported-tensorflow-builds).

### Build Resmi

Tipe Build                       | Status                                                                                                                                                                           | Artefak
----------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | TBA
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [Download](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 dan 1**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 dan 3**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | Status Sementara Tidak Tersedia                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | Status Sementara Tidak Tersedia                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | Status Sementara Tidak Tersedia                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | Status Sementara Tidak Tersedia                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | Status Sementara Tidak Tersedia                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)

## Sumber Daya

*   [TensorFlow.org](https://www.tensorflow.org)
*   [Tutorial TensorFlow](https://www.tensorflow.org/tutorials/)
*   [Model Resmi TensorFlow](https://github.com/tensorflow/models/tree/master/official)
*   [Contoh TensorFlow](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [Blog TensorFlow](https://blog.tensorflow.org)
*   [Belajar ML dengan TensorFlow](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow Twitter](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [Peta jalan optimasi model TensorFlow](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [Makalah Putih TensorFlow](https://www.tensorflow.org/about/bib)
*   [Toolkit Visualisasi TensorBoard](https://github.com/tensorflow/tensorboard)
*   [Pencarian Kode TensorFlow](https://cs.opensource.google/tensorflow/tensorflow)

Pelajari lebih lanjut tentang
[komunitas TensorFlow](https://www.tensorflow.org/community) dan cara
[berkontribusi](https://www.tensorflow.org/community/contribute).

## Kursus

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## Lisensi

[Lisensi Apache 2.0](LICENSE)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---