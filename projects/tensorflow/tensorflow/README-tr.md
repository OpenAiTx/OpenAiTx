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

**`Dokümantasyon`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) uçtan uca açık kaynaklı bir makine öğrenimi platformudur. 
[araçlar](https://www.tensorflow.org/resources/tools),
[kütüphaneler](https://www.tensorflow.org/resources/libraries-extensions) ve
[topluluk](https://www.tensorflow.org/community) kaynaklarından oluşan kapsamlı ve esnek bir ekosisteme sahiptir.
Bu sayede araştırmacılar makine öğreniminde yenilikleri zorlayabilir ve geliştiriciler ML destekli uygulamaları kolayca oluşturup dağıtabilirler.

TensorFlow, ilk olarak Google Brain'deki Makine Zekâsı ekibinde çalışan araştırmacılar ve mühendisler tarafından makine öğrenimi ve sinir ağlarında araştırmalar yapmak için geliştirilmiştir. Ancak, çerçeve başka alanlarda da kullanılabilecek kadar esnektir.

TensorFlow, kararlı [Python](https://www.tensorflow.org/api_docs/python)
ve [C++](https://www.tensorflow.org/api_docs/cc) API'leri ile birlikte
[diğer diller](https://www.tensorflow.org/api_docs) için geçmiş uyumluluğu garanti edilmeyen bir API sağlar.

Sürüm duyuruları ve güvenlik güncellemeleri hakkında güncel kalmak için 
[announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce) adresine abone olun.
Tüm [posta listelerini](https://www.tensorflow.org/community/forums) görüntüleyin.

## Kurulum

[pip paketi](https://www.tensorflow.org/install/pip),
[GPU desteğini etkinleştirme](https://www.tensorflow.org/install/gpu), 
[Docker konteyneri kullanımı](https://www.tensorflow.org/install/docker) ve
[kaynak koddan derleme](https://www.tensorflow.org/install/source) için
[TensorFlow kurulum rehberine](https://www.tensorflow.org/install) bakın.

[CUDA destekli GPU kartlarını](https://www.tensorflow.org/install/gpu) *(Ubuntu ve Windows)* içeren
güncel sürümü kurmak için:

```
$ pip install tensorflow
```

Diğer cihazlar (DirectX ve MacOS-metal) 
[Cihaz eklentileri](https://www.tensorflow.org/install/gpu_plugins#available_devices) kullanılarak desteklenir.

Sadece CPU destekli daha küçük bir paket de mevcuttur:

```
$ pip install tensorflow-cpu
```

TensorFlow’u en son sürüme güncellemek için yukarıdaki komutlara `--upgrade` bayrağını ekleyin.

*[tf-nightly](https://pypi.python.org/pypi/tf-nightly) ve
[tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) paketleriyle test amaçlı gece derlemeleri PyPI’da mevcuttur.*

#### *İlk TensorFlow programınızı deneyin*

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

Daha fazla örnek için 
[TensorFlow eğitimlerine](https://www.tensorflow.org/tutorials/) bakın.

## Katkı rehberi

**TensorFlow’a katkıda bulunmak istiyorsanız,
[katkı rehberini](CONTRIBUTING.md) mutlaka inceleyin. Bu proje TensorFlow’un
[davranış kurallarına](CODE_OF_CONDUCT.md) uyar. Katılarak bu kurallara
uyacağınızı kabul etmiş olursunuz.**

**İstekleri ve hataları takip etmek için [GitHub issues](https://github.com/tensorflow/tensorflow/issues) kullanıyoruz, genel sorular ve tartışmalar için
[Lütfen TensorFlow Forumu’nu](https://discuss.tensorflow.org/) ziyaret edin,
spesifik sorularınız için ise
[Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow)’a başvurun.**

TensorFlow projesi, açık kaynak yazılım geliştirmede genel olarak kabul edilen en iyi uygulamalara uymaya çalışır.

## Yama rehberi

Örneğin bir TensorFlow sürümüne hata veya güvenlik açığı düzeltmeleri uygulamak için aşağıdaki adımları izleyin:

*   TensorFlow deposunu klonlayın ve istediğiniz TensorFlow sürümüne karşılık gelen dalına geçin, örneğin sürüm 2.8 için `r2.8` dalı.
*   İstenen değişiklikleri uygulayın (örneğin, cherry-pick ile) ve kod çakışmalarını çözün.
*   TensorFlow testlerini çalıştırın ve geçtiklerinden emin olun.
*   [Kaynak koddan](https://www.tensorflow.org/install/source) TensorFlow pip paketini derleyin.

## Sürekli derleme durumu

Daha fazla topluluk destekli platform ve yapılandırmayı
[TensorFlow SIG Build topluluk derlemeleri tablosunda](https://github.com/tensorflow/build#community-supported-tensorflow-builds) bulabilirsiniz.

### Resmi Derlemeler

Derleme Tipi                   | Durum                                                                                                                                                                           | Artifaktlar
----------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                 | [![Durum](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Durum](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Durum](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | TBA
**macOS**                     | [![Durum](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Durum](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Durum](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Durum](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [İndir](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 ve 1**       | [![Durum](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 ve 3**       | [![Durum](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | Durum Geçici Olarak Kullanılamıyor                                                                                                                                               | [Gece Derlemesi](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [Resmi GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | Durum Geçici Olarak Kullanılamıyor                                                                                                                                               | [Gece Derlemesi](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [Resmi GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | Durum Geçici Olarak Kullanılamıyor                                                                                                                                               | [Gece Derlemesi](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [Resmi GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | Durum Geçici Olarak Kullanılamıyor                                                                                                                                               | [Gece Derlemesi](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [Resmi GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | Durum Geçici Olarak Kullanılamıyor                                                                                                                                               | [Gece Derlemesi](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [Resmi GCS](https://storage.googleapis.com/tensorflow/)

## Kaynaklar

*   [TensorFlow.org](https://www.tensorflow.org)
*   [TensorFlow Eğitimleri](https://www.tensorflow.org/tutorials/)
*   [TensorFlow Resmi Modelleri](https://github.com/tensorflow/models/tree/master/official)
*   [TensorFlow Örnekleri](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [TensorFlow Blog](https://blog.tensorflow.org)
*   [TensorFlow ile Makine Öğrenimi Öğrenin](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow Twitter](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [TensorFlow model optimizasyon yol haritası](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [TensorFlow Beyaz Kitaplar](https://www.tensorflow.org/about/bib)
*   [TensorBoard Görselleştirme Aracı](https://github.com/tensorflow/tensorboard)
*   [TensorFlow Kod Arama](https://cs.opensource.google/tensorflow/tensorflow)

[TensorFlow topluluğu](https://www.tensorflow.org/community) ve nasıl
[katkıda bulunabileceğiniz](https://www.tensorflow.org/community/contribute) hakkında daha fazla bilgi edinin.

## Kurslar

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## Lisans

[Apache License 2.0](LICENSE)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---