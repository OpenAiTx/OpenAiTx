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

**`التوثيق`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) هو منصة مفتوحة المصدر شاملة من البداية إلى النهاية لتعلم الآلة. يحتوي على نظام بيئي شامل ومرن من [الأدوات](https://www.tensorflow.org/resources/tools)، و[المكتبات](https://www.tensorflow.org/resources/libraries-extensions)، و[موارد المجتمع](https://www.tensorflow.org/community) التي تتيح للباحثين دفع حدود أحدث ما توصلت إليه تقنيات تعلم الآلة، وللمطورين بناء ونشر تطبيقات مدعومة بتعلم الآلة بسهولة.

تم تطوير TensorFlow في الأصل من قبل الباحثين والمهندسين العاملين ضمن فريق الذكاء الآلي في Google Brain لإجراء أبحاث في تعلم الآلة والشبكات العصبية. ومع ذلك، فإن الإطار البرمجي متعدد الاستخدامات بما يكفي ليستخدم في مجالات أخرى أيضًا.

يوفر TensorFlow واجهات برمجية مستقرة [لـPython](https://www.tensorflow.org/api_docs/python) و[C++](https://www.tensorflow.org/api_docs/cc)، بالإضافة إلى واجهات برمجية للغات أخرى [غير مضمونة التوافقية العكسية](https://www.tensorflow.org/api_docs).

ابقَ على اطلاع بإعلانات الإصدارات والتحديثات الأمنية من خلال الاشتراك في [announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce). راجع جميع [قوائم المراسلات](https://www.tensorflow.org/community/forums).

## التثبيت

راجع [دليل تثبيت TensorFlow](https://www.tensorflow.org/install) من أجل [حزمة pip](https://www.tensorflow.org/install/pip)، أو [تمكين دعم GPU](https://www.tensorflow.org/install/gpu)، أو استخدام [حاوية Docker](https://www.tensorflow.org/install/docker)، أو [البناء من المصدر](https://www.tensorflow.org/install/source).

لتثبيت الإصدار الحالي، والذي يتضمن دعمًا لـ[بطاقات GPU المدعومة من CUDA](https://www.tensorflow.org/install/gpu) *(أوبونتو و ويندوز)*:

```
$ pip install tensorflow
```

يتم دعم الأجهزة الأخرى (DirectX و MacOS-metal) باستخدام [إضافات الأجهزة](https://www.tensorflow.org/install/gpu_plugins#available_devices).

يتوفر أيضًا حزمة أصغر تدعم وحدة المعالجة المركزية فقط:

```
$ pip install tensorflow-cpu
```

لتحديث TensorFlow إلى أحدث إصدار، أضف الخيار `--upgrade` إلى الأوامر أعلاه.

*يتوفر أيضًا نسخ ليلية للاختبار باستخدام حزم [tf-nightly](https://pypi.python.org/pypi/tf-nightly) و [tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) على PyPI.*

#### *جرب أول برنامج TensorFlow لك*

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

للمزيد من الأمثلة، راجع [دروس TensorFlow](https://www.tensorflow.org/tutorials/).

## إرشادات المساهمة

**إذا كنت ترغب في المساهمة في TensorFlow، تأكد من مراجعة [إرشادات المساهمة](CONTRIBUTING.md). هذا المشروع يلتزم بـ[مدونة قواعد السلوك](CODE_OF_CONDUCT.md) الخاصة بـ TensorFlow. من خلال المشاركة، من المتوقع منك الالتزام بهذه القواعد.**

**نستخدم [قضايا GitHub](https://github.com/tensorflow/tensorflow/issues) لتتبع الطلبات والأخطاء، يرجى الرجوع إلى [منتدى TensorFlow](https://discuss.tensorflow.org/) للأسئلة العامة والنقاش، ويفضل توجيه الأسئلة المحددة إلى [Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow).**

يسعى مشروع TensorFlow للالتزام بأفضل الممارسات المقبولة عمومًا في تطوير البرمجيات مفتوحة المصدر.

## إرشادات التصحيح (Patching)

اتبع الخطوات التالية لتصحيح إصدار محدد من TensorFlow، على سبيل المثال، لتطبيق إصلاحات للأخطاء أو الثغرات الأمنية:

*   استنسخ مستودع TensorFlow وانتقل إلى الفرع المناسب لإصدار TensorFlow المطلوب، على سبيل المثال، الفرع `r2.8` للإصدار 2.8.
*   طبق (أي استخدم cherry-pick) التغييرات المطلوبة وحل أي تعارضات في الشيفرة.
*   شغل اختبارات TensorFlow وتأكد من نجاحها.
*   [قم بالبناء](https://www.tensorflow.org/install/source) لحزمة pip الخاصة بـ TensorFlow من المصدر.

## حالة البناء المستمر

يمكنك العثور على المزيد من المنصات والتكوينات المدعومة من المجتمع في [جدول بناء مجتمع TensorFlow SIG Build](https://github.com/tensorflow/build#community-supported-tensorflow-builds).

### الإصدارات الرسمية

نوع البناء                    | الحالة                                                                                                                                                                           | الحزم
----------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | قريبًا
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [تنزيل](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 و 1**        | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 و 3**        | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | الحالة غير متاحة مؤقتًا                                                                                                                                                         | [نسخة ليلية](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [GCS الرسمي](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | الحالة غير متاحة مؤقتًا                                                                                                                                                         | [نسخة ليلية](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [GCS الرسمي](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | الحالة غير متاحة مؤقتًا                                                                                                                                                         | [نسخة ليلية](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [GCS الرسمي](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | الحالة غير متاحة مؤقتًا                                                                                                                                                         | [نسخة ليلية](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [GCS الرسمي](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | الحالة غير متاحة مؤقتًا                                                                                                                                                         | [نسخة ليلية](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [GCS الرسمي](https://storage.googleapis.com/tensorflow/)

## الموارد

*   [TensorFlow.org](https://www.tensorflow.org)
*   [دروس TensorFlow](https://www.tensorflow.org/tutorials/)
*   [نماذج TensorFlow الرسمية](https://github.com/tensorflow/models/tree/master/official)
*   [أمثلة TensorFlow](https://github.com/tensorflow/examples)
*   [مختبرات تعليمية لـ TensorFlow](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [مدونة TensorFlow](https://blog.tensorflow.org)
*   [تعلم تعلم الآلة مع TensorFlow](https://www.tensorflow.org/resources/learn-ml)
*   [حساب TensorFlow على تويتر](https://twitter.com/tensorflow)
*   [قناة TensorFlow على يوتيوب](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [خارطة طريق تحسين نماذج TensorFlow](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [أوراق TensorFlow البحثية](https://www.tensorflow.org/about/bib)
*   [أداة تصوّر TensorBoard](https://github.com/tensorflow/tensorboard)
*   [بحث في شيفرة TensorFlow](https://cs.opensource.google/tensorflow/tensorflow)

تعرف على المزيد حول [مجتمع TensorFlow](https://www.tensorflow.org/community) وكيفية [المساهمة](https://www.tensorflow.org/community/contribute).

## الدورات التدريبية

* [كورsera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## الرخصة

[رخصة أباتشي 2.0](LICENSE)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---