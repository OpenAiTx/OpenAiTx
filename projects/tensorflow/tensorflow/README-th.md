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

**`เอกสารประกอบ`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) เป็นแพลตฟอร์มโอเพนซอร์สแบบครบวงจรสำหรับแมชชีนเลิร์นนิง มีระบบนิเวศที่ครอบคลุมและยืดหยุ่นของ[เครื่องมือ](https://www.tensorflow.org/resources/tools), [ไลบรารี](https://www.tensorflow.org/resources/libraries-extensions) และ[ชุมชน](https://www.tensorflow.org/community) ที่ช่วยให้นักวิจัยสามารถผลักดันขีดจำกัดของ ML และให้นักพัฒนาสามารถสร้างและนำแอปพลิเคชันที่ขับเคลื่อนด้วย ML ไปใช้งานได้อย่างง่ายดาย

TensorFlow พัฒนาขึ้นโดยนักวิจัยและวิศวกรในทีม Machine Intelligence ของ Google Brain เพื่อทำวิจัยด้านแมชชีนเลิร์นนิงและโครงข่ายประสาทเทียม อย่างไรก็ตาม เฟรมเวิร์กนี้มีความยืดหยุ่นเพียงพอที่จะใช้งานในด้านอื่น ๆ ได้เช่นกัน

TensorFlow ให้ API ที่เสถียรทั้งในภาษา [Python](https://www.tensorflow.org/api_docs/python) และ [C++](https://www.tensorflow.org/api_docs/cc) รวมถึง API สำหรับ[ภาษาอื่น ๆ](https://www.tensorflow.org/api_docs) ที่ไม่รับประกันความเข้ากันได้ย้อนหลัง

ติดตามข่าวสารการประกาศเวอร์ชันใหม่และอัปเดตด้านความปลอดภัยได้โดยสมัครสมาชิกที่
[announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce)
ดูรายชื่อ[เมลลิ่งลิสต์ทั้งหมด](https://www.tensorflow.org/community/forums)

## การติดตั้ง

ดู[คู่มือการติดตั้ง TensorFlow](https://www.tensorflow.org/install) สำหรับ
[แพ็คเกจ pip](https://www.tensorflow.org/install/pip), เพื่อ[เปิดใช้งาน GPU](https://www.tensorflow.org/install/gpu), การใช้งาน[คอนเทนเนอร์ Docker](https://www.tensorflow.org/install/docker) และ[คอมไพล์จากซอร์ส](https://www.tensorflow.org/install/source)

หากต้องการติดตั้งเวอร์ชันปัจจุบัน ซึ่งรองรับ
[การ์ด GPU ที่รองรับ CUDA](https://www.tensorflow.org/install/gpu) *(Ubuntu และ Windows)*:

```
$ pip install tensorflow
```

อุปกรณ์อื่น ๆ (DirectX และ MacOS-metal) สามารถใช้งานได้ผ่าน
[ปลั๊กอินอุปกรณ์](https://www.tensorflow.org/install/gpu_plugins#available_devices)

ยังมีแพ็คเกจขนาดเล็กสำหรับ CPU เท่านั้นให้เลือกด้วยเช่นกัน:

```
$ pip install tensorflow-cpu
```

หากต้องการอัปเดต TensorFlow เป็นเวอร์ชันล่าสุด ให้เพิ่มแฟล็ก `--upgrade` ในคำสั่งข้างต้น

*สามารถทดสอบไบนารีไนท์ลี่ได้โดยใช้
[tf-nightly](https://pypi.python.org/pypi/tf-nightly) และ
[tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) บน PyPI*

#### *ทดลองเขียนโปรแกรม TensorFlow แรกของคุณ*

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

ดูตัวอย่างเพิ่มเติมได้ที่
[บทเรียน TensorFlow](https://www.tensorflow.org/tutorials/)

## แนวทางการมีส่วนร่วม

**หากคุณต้องการมีส่วนร่วมกับ TensorFlow กรุณาอ่าน
[แนวทางการมีส่วนร่วม](CONTRIBUTING.md) โปรเจกต์นี้ปฏิบัติตาม
[จรรยาบรรณโค้ด](CODE_OF_CONDUCT.md) ของ TensorFlow การมีส่วนร่วมของคุณถือว่าคุณเห็นชอบและจะปฏิบัติตามจรรยาบรรณนี้**

**เราใช้ [GitHub issues](https://github.com/tensorflow/tensorflow/issues) สำหรับติดตามข้อเสนอแนะและบั๊ก กรุณาดู
[ฟอรั่ม TensorFlow](https://discuss.tensorflow.org/) สำหรับคำถามและการพูดคุยทั่วไป และหากเป็นคำถามเฉพาะทางกรุณาส่งไปที่
[Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow)**

โปรเจกต์ TensorFlow มุ่งมั่นปฏิบัติตามแนวทางปฏิบัติที่ดีที่สุดที่ได้รับการยอมรับโดยทั่วไปในการพัฒนาโอเพนซอร์ส

## แนวทางการแพตช์

ปฏิบัติตามขั้นตอนดังต่อไปนี้เพื่อแพตช์เวอร์ชันเฉพาะของ TensorFlow เช่น เพื่อนำการแก้ไขบั๊กหรือช่องโหว่ด้านความปลอดภัยมาใช้:

*   โคลนรีโป TensorFlow และสลับไปที่ branch ที่ตรงกับเวอร์ชัน TensorFlow ที่ต้องการ เช่น branch `r2.8` สำหรับเวอร์ชัน 2.8
*   นำการเปลี่ยนแปลงที่ต้องการมาใช้ (cherry-pick) และแก้ไขความขัดแย้งของโค้ดที่อาจเกิดขึ้น
*   รันเทสต์ TensorFlow และตรวจสอบให้แน่ใจว่าผ่านทุกเคส
*   [คอมไพล์](https://www.tensorflow.org/install/source) แพ็คเกจ pip ของ TensorFlow จากซอร์ส

## สถานะการสร้างต่อเนื่อง

คุณสามารถดูแพลตฟอร์มและการตั้งค่าที่ชุมชนสนับสนุนเพิ่มเติมได้ที่
[ตาราง community builds ของ TensorFlow SIG Build](https://github.com/tensorflow/build#community-supported-tensorflow-builds)

### การสร้างอย่างเป็นทางการ

ประเภทการสร้าง                | สถานะ                                                                                                                                                                               | ไฟล์ที่ได้
----------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ---------
**Linux CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)              | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html)      | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)              | TBA
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)          | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)            | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)            | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)                    | [Download](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 and 1**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)              | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 and 3**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)              | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | สถานะไม่พร้อมใช้งานชั่วคราว                                                                                                                                            | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | สถานะไม่พร้อมใช้งานชั่วคราว                                                                                                                                            | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | สถานะไม่พร้อมใช้งานชั่วคราว                                                                                                                                            | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | สถานะไม่พร้อมใช้งานชั่วคราว                                                                                                                                            | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | สถานะไม่พร้อมใช้งานชั่วคราว                                                                                                                                            | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)

## แหล่งข้อมูล

*   [TensorFlow.org](https://www.tensorflow.org)
*   [บทเรียน TensorFlow](https://www.tensorflow.org/tutorials/)
*   [TensorFlow Official Models](https://github.com/tensorflow/models/tree/master/official)
*   [ตัวอย่าง TensorFlow](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [บล็อก TensorFlow](https://blog.tensorflow.org)
*   [เรียนรู้ ML ด้วย TensorFlow](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow Twitter](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [แผนงานการเพิ่มประสิทธิภาพโมเดลของ TensorFlow](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [เอกสารวิชาการ TensorFlow](https://www.tensorflow.org/about/bib)
*   [ชุดเครื่องมือแสดงผล TensorBoard](https://github.com/tensorflow/tensorboard)
*   [TensorFlow Code Search](https://cs.opensource.google/tensorflow/tensorflow)

เรียนรู้เพิ่มเติมเกี่ยวกับ[ชุมชน TensorFlow](https://www.tensorflow.org/community) และวิธี[มีส่วนร่วม](https://www.tensorflow.org/community/contribute)

## คอร์สเรียน

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## ใบอนุญาต

[Apache License 2.0](LICENSE)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---