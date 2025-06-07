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

**`प्रलेखन`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) मशीन लर्निंग के लिए एक एंड-टू-एंड ओपन सोर्स प्लेटफॉर्म है। इसमें [उपकरण](https://www.tensorflow.org/resources/tools), [लाइब्रेरी](https://www.tensorflow.org/resources/libraries-extensions), और [समुदाय](https://www.tensorflow.org/community) संसाधनों का एक व्यापक, लचीला ईकोसिस्टम है, जिससे शोधकर्ता एमएल में अत्याधुनिक शोध कर सकते हैं और डेवलपर्स आसानी से एमएल-सक्षम एप्लिकेशन बना और डिप्लॉय कर सकते हैं।

TensorFlow मूल रूप से Google Brain की मशीन इंटेलिजेंस टीम के शोधकर्ताओं और इंजीनियरों द्वारा मशीन लर्निंग और न्यूरल नेटवर्क में शोध के लिए विकसित किया गया था। हालांकि, यह फ्रेमवर्क अन्य क्षेत्रों में भी प्रयुक्त किया जा सकता है।

TensorFlow स्थिर [Python](https://www.tensorflow.org/api_docs/python) और [C++](https://www.tensorflow.org/api_docs/cc) API प्रदान करता है, साथ ही [अन्य भाषाओं](https://www.tensorflow.org/api_docs) के लिए एक नॉन-गारंटीड बैकवर्ड कम्पेटिबल API भी उपलब्ध है।

रिलीज़ घोषणाओं और सुरक्षा अपडेट के लिए [announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce) पर सदस्यता लें। सभी [मेलिंग सूचियाँ](https://www.tensorflow.org/community/forums) देखें।

## स्थापना करें

[pip पैकेज](https://www.tensorflow.org/install/pip), [GPU समर्थन सक्षम करने](https://www.tensorflow.org/install/gpu), [Docker कंटेनर](https://www.tensorflow.org/install/docker) का उपयोग करने, और [सोर्स से बिल्ड](https://www.tensorflow.org/install/source) करने के लिए [TensorFlow स्थापना गाइड](https://www.tensorflow.org/install) देखें।

वर्तमान रिलीज़ स्थापित करने के लिए, जिसमें [CUDA-सक्षम GPU कार्ड](https://www.tensorflow.org/install/gpu) *(Ubuntu और Windows)* का समर्थन शामिल है:

```
$ pip install tensorflow
```

अन्य डिवाइस (DirectX और MacOS-metal) [डिवाइस प्लगइन्स](https://www.tensorflow.org/install/gpu_plugins#available_devices) के माध्यम से समर्थित हैं।

केवल CPU के लिए एक छोटा पैकेज भी उपलब्ध है:

```
$ pip install tensorflow-cpu
```

TensorFlow को नवीनतम संस्करण में अपडेट करने के लिए, ऊपर दिए गए कमांड में `--upgrade` फ्लैग जोड़ें।

*रात्री (नाइटली) बायनरी परीक्षण के लिए [tf-nightly](https://pypi.python.org/pypi/tf-nightly) और [tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) पैकेज PyPI पर उपलब्ध हैं।*

#### *अपना पहला TensorFlow प्रोग्राम आज़माएँ*

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

अधिक उदाहरणों के लिए, [TensorFlow ट्यूटोरियल](https://www.tensorflow.org/tutorials/) देखें।

## योगदान दिशानिर्देश

**यदि आप TensorFlow में योगदान करना चाहते हैं, तो कृपया [योगदान दिशानिर्देश](CONTRIBUTING.md) अवश्य देखें। यह प्रोजेक्ट TensorFlow के [आचार संहिता](CODE_OF_CONDUCT.md) का पालन करता है। इसमें भाग लेकर, आप इस संहिता का पालन करने की अपेक्षा रखते हैं।**

**हम [GitHub issues](https://github.com/tensorflow/tensorflow/issues) का उपयोग अनुरोधों और बग्स को ट्रैक करने के लिए करते हैं, कृपया सामान्य प्रश्नों और चर्चा के लिए [TensorFlow Forum](https://discuss.tensorflow.org/) देखें, और विशिष्ट प्रश्नों के लिए [Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow) पर जाएँ।**

TensorFlow प्रोजेक्ट ओपन-सोर्स सॉफ्टवेयर विकास में सामान्यतः स्वीकृत सर्वोत्तम प्रथाओं का पालन करने का प्रयास करता है।

## पैचिंग दिशानिर्देश

TensorFlow के किसी विशिष्ट संस्करण को पैच करने के लिए, जैसे बग्स या सुरक्षा कमजोरियों को ठीक करने के लिए, इन चरणों का पालन करें:

*   TensorFlow रिपॉजिटरी क्लोन करें और अपनी इच्छित TensorFlow संस्करण की संबंधित शाखा पर स्विच करें, उदाहरण के लिए, संस्करण 2.8 के लिए `r2.8` शाखा।
*   वांछित परिवर्तनों को लागू (चैरी-पिक) करें और किसी भी कोड संघर्ष को हल करें।
*   TensorFlow परीक्षण चलाएँ और सुनिश्चित करें कि वे पास हों।
*   सोर्स से [TensorFlow pip पैकेज](https://www.tensorflow.org/install/source) बनाएं।

## सतत बिल्ड स्थिति

आप अधिक समुदाय-समर्थित प्लेटफार्म और कॉन्फ़िगरेशन [TensorFlow SIG Build समुदाय बिल्ड तालिका](https://github.com/tensorflow/build#community-supported-tensorflow-builds) में पा सकते हैं।

### आधिकारिक बिल्ड

बिल्ड प्रकार                    | स्थिति                                                                                                                                                                           | आर्टिफैक्ट्स
----------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | जल्द उपलब्ध होगा
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [डाउनलोड करें](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 और 1**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 और 3**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | स्थिति अस्थायी रूप से अनुपलब्ध                                                                                                                                                   | [नाइटली बायनरी](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [आधिकारिक GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | स्थिति अस्थायी रूप से अनुपलब्ध                                                                                                                                                   | [नाइटली बायनरी](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [आधिकारिक GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | स्थिति अस्थायी रूप से अनुपलब्ध                                                                                                                                                   | [नाइटली बायनरी](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [आधिकारिक GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | स्थिति अस्थायी रूप से अनुपलब्ध                                                                                                                                                   | [नाइटली बायनरी](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [आधिकारिक GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | स्थिति अस्थायी रूप से अनुपलब्ध                                                                                                                                                   | [नाइटली बायनरी](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [आधिकारिक GCS](https://storage.googleapis.com/tensorflow/)

## संसाधन

*   [TensorFlow.org](https://www.tensorflow.org)
*   [TensorFlow ट्यूटोरियल](https://www.tensorflow.org/tutorials/)
*   [TensorFlow आधिकारिक मॉडल](https://github.com/tensorflow/models/tree/master/official)
*   [TensorFlow उदाहरण](https://github.com/tensorflow/examples)
*   [TensorFlow कोड लैब्स](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [TensorFlow ब्लॉग](https://blog.tensorflow.org)
*   [TensorFlow के साथ ML सीखें](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow ट्विटर](https://twitter.com/tensorflow)
*   [TensorFlow यूट्यूब](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [TensorFlow मॉडल ऑप्टिमाइजेशन रोडमैप](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [TensorFlow श्वेत पत्र](https://www.tensorflow.org/about/bib)
*   [TensorBoard विज़ुअलाइज़ेशन टूलकिट](https://github.com/tensorflow/tensorboard)
*   [TensorFlow कोड सर्च](https://cs.opensource.google/tensorflow/tensorflow)

[TensforFlow समुदाय](https://www.tensorflow.org/community) के बारे में और जानें और कैसे [योगदान करें](https://www.tensorflow.org/community/contribute)।

## पाठ्यक्रम

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## लाइसेंस

[Apache License 2.0](LICENSE)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---