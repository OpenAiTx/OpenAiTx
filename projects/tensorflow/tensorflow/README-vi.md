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

**`Tài liệu hướng dẫn`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) là một nền tảng mã nguồn mở toàn diện cho học máy. Nó sở hữu một hệ sinh thái đầy đủ và linh hoạt gồm các [công cụ](https://www.tensorflow.org/resources/tools), [thư viện](https://www.tensorflow.org/resources/libraries-extensions), và các tài nguyên [cộng đồng](https://www.tensorflow.org/community) cho phép các nhà nghiên cứu thúc đẩy giới hạn hiện tại của ML và giúp các nhà phát triển dễ dàng xây dựng, triển khai các ứng dụng sử dụng ML.

TensorFlow ban đầu được phát triển bởi các nhà nghiên cứu và kỹ sư trong nhóm Trí tuệ Máy (Machine Intelligence) tại Google Brain nhằm phục vụ nghiên cứu học máy và mạng nơ-ron. Tuy nhiên, framework này đủ linh hoạt để được sử dụng trong nhiều lĩnh vực khác.

TensorFlow cung cấp API ổn định cho [Python](https://www.tensorflow.org/api_docs/python) và [C++](https://www.tensorflow.org/api_docs/cc), cũng như API không đảm bảo tương thích ngược cho [các ngôn ngữ khác](https://www.tensorflow.org/api_docs).

Hãy luôn cập nhật các thông báo phát hành và cập nhật bảo mật bằng cách đăng ký
[announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce).
Xem tất cả các [danh sách thư điện tử](https://www.tensorflow.org/community/forums).

## Cài đặt

Xem [hướng dẫn cài đặt TensorFlow](https://www.tensorflow.org/install) cho
[gói pip](https://www.tensorflow.org/install/pip), để
[bật hỗ trợ GPU](https://www.tensorflow.org/install/gpu), sử dụng
[container Docker](https://www.tensorflow.org/install/docker), và
[xây dựng từ mã nguồn](https://www.tensorflow.org/install/source).

Để cài đặt phiên bản hiện tại, hỗ trợ
[các card GPU có CUDA](https://www.tensorflow.org/install/gpu) *(Ubuntu và
Windows)*:

```
$ pip install tensorflow
```

Các thiết bị khác (DirectX và MacOS-metal) được hỗ trợ thông qua
[plugin thiết bị](https://www.tensorflow.org/install/gpu_plugins#available_devices).

Cũng có sẵn một gói nhỏ hơn chỉ hỗ trợ CPU:

```
$ pip install tensorflow-cpu
```

Để cập nhật TensorFlow lên phiên bản mới nhất, thêm cờ `--upgrade` vào các lệnh trên.

*Các bản dựng nightly có sẵn để thử nghiệm thông qua các gói
[tf-nightly](https://pypi.python.org/pypi/tf-nightly) và
[tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) trên PyPI.*

#### *Thử chương trình TensorFlow đầu tiên của bạn*

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

Để biết thêm ví dụ, xem
[các hướng dẫn TensorFlow](https://www.tensorflow.org/tutorials/).

## Hướng dẫn đóng góp

**Nếu bạn muốn đóng góp cho TensorFlow, hãy chắc chắn đọc
[hướng dẫn đóng góp](CONTRIBUTING.md). Dự án này tuân thủ
[quy tắc ứng xử](CODE_OF_CONDUCT.md) của TensorFlow. Khi tham gia, bạn được kỳ vọng sẽ tuân thủ quy tắc này.**

**Chúng tôi sử dụng [GitHub issues](https://github.com/tensorflow/tensorflow/issues) để theo dõi yêu cầu và lỗi, vui lòng xem
[Diễn đàn TensorFlow](https://discuss.tensorflow.org/) cho các câu hỏi và thảo luận chung, và gửi các câu hỏi cụ thể đến
[Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow).**

Dự án TensorFlow luôn nỗ lực tuân thủ các thực tiễn tốt nhất được chấp nhận rộng rãi trong phát triển phần mềm nguồn mở.

## Hướng dẫn vá lỗi

Thực hiện các bước sau để vá một phiên bản cụ thể của TensorFlow, ví dụ, để áp dụng bản sửa lỗi hoặc vá lỗ hổng bảo mật:

*   Clone kho lưu trữ TensorFlow và chuyển sang nhánh tương ứng với phiên bản TensorFlow bạn muốn, ví dụ, nhánh `r2.8` cho phiên bản 2.8.
*   Áp dụng (cherry-pick) các thay đổi mong muốn và xử lý bất kỳ xung đột mã nguồn nào.
*   Chạy kiểm thử TensorFlow và đảm bảo tất cả đều thành công.
*   [Xây dựng](https://www.tensorflow.org/install/source) gói pip TensorFlow từ mã nguồn.

## Trạng thái xây dựng liên tục

Bạn có thể tìm thêm các nền tảng và cấu hình được cộng đồng hỗ trợ trong
[bảng xây dựng cộng đồng TensorFlow SIG Build](https://github.com/tensorflow/build#community-supported-tensorflow-builds).

### Bản dựng chính thức

Loại bản dựng                   | Trạng thái                                                                                                                                                                            | Hiện vật
----------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | Sắp cập nhật
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [Tải về](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 và 1**       | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 và 3**       | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | Trạng thái tạm thời không khả dụng                                                                                                                                                | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | Trạng thái tạm thời không khả dụng                                                                                                                                                | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | Trạng thái tạm thời không khả dụng                                                                                                                                                | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | Trạng thái tạm thời không khả dụng                                                                                                                                                | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | Trạng thái tạm thời không khả dụng                                                                                                                                                | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)

## Tài nguyên

*   [TensorFlow.org](https://www.tensorflow.org)
*   [Hướng dẫn TensorFlow](https://www.tensorflow.org/tutorials/)
*   [Các mô hình chính thức của TensorFlow](https://github.com/tensorflow/models/tree/master/official)
*   [Các ví dụ về TensorFlow](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [Blog TensorFlow](https://blog.tensorflow.org)
*   [Học ML với TensorFlow](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow Twitter](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [Lộ trình tối ưu hóa mô hình TensorFlow](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [Các bài báo khoa học về TensorFlow](https://www.tensorflow.org/about/bib)
*   [Bộ công cụ trực quan hóa TensorBoard](https://github.com/tensorflow/tensorboard)
*   [Tìm kiếm mã nguồn TensorFlow](https://cs.opensource.google/tensorflow/tensorflow)

Tìm hiểu thêm về [cộng đồng TensorFlow](https://www.tensorflow.org/community) và cách [đóng góp](https://www.tensorflow.org/community/contribute).

## Khóa học

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## Giấy phép

[Giấy phép Apache 2.0](LICENSE)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---