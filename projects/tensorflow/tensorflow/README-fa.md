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

**`مستندات`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) یک پلتفرم متن‌باز انتها به انتها برای یادگیری ماشین است. این پلتفرم دارای اکوسیستمی جامع و انعطاف‌پذیر از [ابزارها](https://www.tensorflow.org/resources/tools)، [کتابخانه‌ها](https://www.tensorflow.org/resources/libraries-extensions) و منابع [جامعه](https://www.tensorflow.org/community) است که به پژوهشگران امکان می‌دهد آخرین دستاوردهای یادگیری ماشین را ارتقا دهند و توسعه‌دهندگان بتوانند به‌راحتی برنامه‌های مبتنی بر یادگیری ماشین را ایجاد و پیاده‌سازی کنند.

TensorFlow در ابتدا توسط پژوهشگران و مهندسان تیم هوش ماشینی در Google Brain برای انجام پژوهش در یادگیری ماشین و شبکه‌های عصبی توسعه داده شد. با این حال، این چارچوب به اندازه کافی همه‌کاره است که بتوان آن را در حوزه‌های دیگر نیز به کار برد.

TensorFlow رابط‌های برنامه‌نویسی پایدار برای [پایتون](https://www.tensorflow.org/api_docs/python) و [++C](https://www.tensorflow.org/api_docs/cc) ارائه می‌دهد، همچنین رابط‌هایی که سازگاری بازگشتی تضمین‌شده‌ای ندارند برای [زبان‌های دیگر](https://www.tensorflow.org/api_docs) نیز در دسترس است.

برای اطلاع از اطلاعیه‌های انتشار و به‌روزرسانی‌های امنیتی، در [announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce) عضو شوید. تمام [لیست‌های پستی](https://www.tensorflow.org/community/forums) را مشاهده کنید.

## نصب

برای مشاهده راهنمای نصب TensorFlow به [راهنمای نصب TensorFlow](https://www.tensorflow.org/install) مراجعه کنید. این راهنما شامل [نصب با pip](https://www.tensorflow.org/install/pip)، [فعال‌سازی پشتیبانی GPU](https://www.tensorflow.org/install/gpu)، استفاده از [کانتینر Docker](https://www.tensorflow.org/install/docker) و [ساخت از سورس](https://www.tensorflow.org/install/source) است.

برای نصب نسخه فعلی که شامل پشتیبانی از [کارت‌های GPU با قابلیت CUDA](https://www.tensorflow.org/install/gpu) *(در اوبونتو و ویندوز)* می‌باشد:

```
$ pip install tensorflow
```

سایر دستگاه‌ها (DirectX و MacOS-metal) از طریق [افزونه‌های دستگاه](https://www.tensorflow.org/install/gpu_plugins#available_devices) پشتیبانی می‌شوند.

یک بسته سبک‌تر فقط برای CPU نیز در دسترس است:

```
$ pip install tensorflow-cpu
```

برای به‌روزرسانی TensorFlow به آخرین نسخه، کافی است گزینه `--upgrade` را به دستورات بالا اضافه کنید.

*باینری‌های شبانه برای آزمایش از طریق بسته‌های [tf-nightly](https://pypi.python.org/pypi/tf-nightly) و [tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) در PyPI در دسترس هستند.*

#### *اولین برنامه TensorFlow خود را امتحان کنید*

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

برای نمونه‌های بیشتر، به [آموزش‌های TensorFlow](https://www.tensorflow.org/tutorials/) مراجعه کنید.

## دستورالعمل‌های مشارکت

**اگر می‌خواهید در توسعه TensorFlow مشارکت کنید، حتماً [دستورالعمل‌های مشارکت](CONTRIBUTING.md) را مرور کنید. این پروژه از [منشور رفتار](CODE_OF_CONDUCT.md) TensorFlow پیروی می‌کند. با مشارکت در این پروژه، انتظار می‌رود که این منشور را رعایت کنید.**

**ما برای پیگیری درخواست‌ها و اشکالات از [مسائل گیت‌هاب](https://github.com/tensorflow/tensorflow/issues) استفاده می‌کنیم. برای پرسش‌ها و بحث‌های عمومی به [فروم TensorFlow](https://discuss.tensorflow.org/) مراجعه کنید و برای پرسش‌های تخصصی به [Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow) مراجعه نمایید.**

پروژه TensorFlow تلاش می‌کند تا از بهترین شیوه‌های پذیرفته‌شده در توسعه نرم‌افزار متن‌باز پیروی کند.

## دستورالعمل‌های اصلاح (Patching)

برای اصلاح یک نسخه خاص از TensorFlow، به عنوان مثال برای رفع باگ‌ها یا آسیب‌پذیری‌های امنیتی، مراحل زیر را دنبال کنید:

*   مخزن TensorFlow را کلون کرده و به شاخه متناظر با نسخه مورد نظر خود بروید، برای مثال شاخه `r2.8` برای نسخه 2.8.
*   تغییرات مورد نظر خود را اعمال (cherry-pick) کرده و هر گونه تعارض کد را برطرف کنید.
*   تست‌های TensorFlow را اجرا کرده و اطمینان حاصل کنید که همه آن‌ها با موفقیت انجام می‌شوند.
*   [بسته pip TensorFlow را از سورس](https://www.tensorflow.org/install/source) بسازید.

## وضعیت ساخت پیوسته (Continuous Build Status)

می‌توانید پلتفرم‌ها و پیکربندی‌های پشتیبانی‌شده توسط جامعه را در [جدول ساخت جامعه SIG Build TensorFlow](https://github.com/tensorflow/build#community-supported-tensorflow-builds) بیابید.

### ساخت‌های رسمی

نوع ساخت                     | وضعیت                                                                                                                                                                           | مصنوعات
----------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**لینوکس CPU**                | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**لینوکس GPU**                | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**لینوکس XLA**                | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | TBA
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**ویندوز CPU**                | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**ویندوز GPU**                | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**اندروید**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [دانلود](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 و 1**        | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 و 3**        | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | وضعیت موقتاً در دسترس نیست                                                                                                                                                   | [باینری شبانه](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [GCS رسمی](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | وضعیت موقتاً در دسترس نیست                                                                                                                                                   | [باینری شبانه](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [GCS رسمی](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | وضعیت موقتاً در دسترس نیست                                                                                                                                                   | [باینری شبانه](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [GCS رسمی](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | وضعیت موقتاً در دسترس نیست                                                                                                                                                   | [باینری شبانه](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [GCS رسمی](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | وضعیت موقتاً در دسترس نیست                                                                                                                                                   | [باینری شبانه](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [GCS رسمی](https://storage.googleapis.com/tensorflow/)

## منابع

*   [TensorFlow.org](https://www.tensorflow.org)
*   [آموزش‌های TensorFlow](https://www.tensorflow.org/tutorials/)
*   [مدل‌های رسمی TensorFlow](https://github.com/tensorflow/models/tree/master/official)
*   [نمونه‌های TensorFlow](https://github.com/tensorflow/examples)
*   [کدلب‌های TensorFlow](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [وبلاگ TensorFlow](https://blog.tensorflow.org)
*   [یادگیری ماشین با TensorFlow](https://www.tensorflow.org/resources/learn-ml)
*   [توییتر TensorFlow](https://twitter.com/tensorflow)
*   [یوتیوب TensorFlow](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [نقشه راه بهینه‌سازی مدل TensorFlow](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [مقالات سفید TensorFlow](https://www.tensorflow.org/about/bib)
*   [ابزار تصویری TensorBoard](https://github.com/tensorflow/tensorboard)
*   [جستجوی کد TensorFlow](https://cs.opensource.google/tensorflow/tensorflow)

برای کسب اطلاعات بیشتر درباره [جامعه TensorFlow](https://www.tensorflow.org/community) و نحوه [مشارکت](https://www.tensorflow.org/community/contribute) در آن مطالعه نمایید.

## دوره‌ها

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## مجوز

[مجوز Apache نسخه 2.0](LICENSE)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---