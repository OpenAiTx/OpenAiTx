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

**`문서`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/)는 머신러닝을 위한 엔드 투 엔드 오픈소스 플랫폼입니다. 
다양한 [도구](https://www.tensorflow.org/resources/tools),
[라이브러리](https://www.tensorflow.org/resources/libraries-extensions), 그리고 
[커뮤니티](https://www.tensorflow.org/community) 리소스를 포함하는 포괄적이고 유연한 생태계를 제공하여,
연구자들이 머신러닝(Machine Learning, ML) 분야의 최첨단을 이끌고, 개발자들은 ML 기반 애플리케이션을 쉽게 구축하고 배포할 수 있습니다.

TensorFlow는 원래 구글 브레인(Google Brain) 내 머신 인텔리전스 팀의 연구원 및 엔지니어들이 머신러닝과 신경망 연구를 위해 개발했습니다. 하지만 이 프레임워크는 매우 다양한 분야에서 활용될 수 있을 만큼 유연합니다.

TensorFlow는 안정적인 [Python](https://www.tensorflow.org/api_docs/python) 및 [C++](https://www.tensorflow.org/api_docs/cc) API를 제공하며, 
[기타 언어](https://www.tensorflow.org/api_docs)를 위한 하위 호환이 보장되지 않는 API도 제공합니다.

릴리즈 공지 및 보안 업데이트를 받아보려면 
[announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce) 메일링 리스트를 구독하세요.
모든 [메일링 리스트](https://www.tensorflow.org/community/forums)를 확인할 수 있습니다.

## 설치

[pip 패키지](https://www.tensorflow.org/install/pip), 
[GPU 지원 활성화](https://www.tensorflow.org/install/gpu), 
[도커 컨테이너 사용](https://www.tensorflow.org/install/docker), 
[소스에서 빌드](https://www.tensorflow.org/install/source) 등에 대한 자세한 내용은 
[TensorFlow 설치 가이드](https://www.tensorflow.org/install)를 참고하세요.

[CUDA 지원 GPU 카드](https://www.tensorflow.org/install/gpu)를 포함한 현재 릴리스를 설치하려면 *(Ubuntu 및 Windows)*:

```
$ pip install tensorflow
```

DirectX 및 MacOS-metal 등 기타 장치는 
[디바이스 플러그인](https://www.tensorflow.org/install/gpu_plugins#available_devices)을 통해 지원됩니다.

CPU 전용 경량 패키지도 제공됩니다:

```
$ pip install tensorflow-cpu
```

TensorFlow를 최신 버전으로 업데이트하려면 위 명령어에 `--upgrade` 플래그를 추가하세요.

*테스트용 야간 빌드는 PyPI의 
[tf-nightly](https://pypi.python.org/pypi/tf-nightly) 및 
[tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) 패키지를 통해 사용할 수 있습니다.*

#### *첫 번째 TensorFlow 프로그램 실행해보기*

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

더 많은 예제는 
[TensorFlow 튜토리얼](https://www.tensorflow.org/tutorials/)을 참고하세요.

## 기여 가이드라인

**TensorFlow에 기여하고자 한다면 반드시 
[기여 가이드라인](CONTRIBUTING.md)을 확인하세요. 이 프로젝트는 TensorFlow의 
[행동 강령](CODE_OF_CONDUCT.md)을 준수합니다. 참여하는 모든 분들은 이 강령을 지켜야 합니다.**

**요청 및 버그 추적은 [GitHub 이슈](https://github.com/tensorflow/tensorflow/issues)를 사용하며, 
일반적인 질문이나 토론은 [TensorFlow 포럼](https://discuss.tensorflow.org/)을 이용해주시고, 
구체적인 기술 질문은 [Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow)에 올려주시기 바랍니다.**

TensorFlow 프로젝트는 오픈소스 소프트웨어 개발의 일반적으로 인정받는 모범 사례를 준수하려고 노력합니다.

## 패치 가이드라인

TensorFlow의 특정 버전에 패치를 적용하려면(예: 버그 또는 보안 취약점 수정):

*   TensorFlow 저장소를 클론하고 원하는 TensorFlow 버전에 해당하는 브랜치(예: 2.8 버전은 `r2.8` 브랜치)로 전환하세요.
*   원하는 변경사항을 적용(체리픽)하고 코드 충돌을 해결하세요.
*   TensorFlow 테스트를 실행하여 통과하는지 확인하세요.
*   소스에서 [빌드](https://www.tensorflow.org/install/source)하여 TensorFlow pip 패키지를 생성하세요.

## 지속적 빌드 상태

더 많은 커뮤니티 지원 플랫폼 및 구성은 
[TensorFlow SIG Build 커뮤니티 빌드 테이블](https://github.com/tensorflow/build#community-supported-tensorflow-builds)에서 확인할 수 있습니다.

### 공식 빌드

빌드 유형                     | 상태                                                                                                                                                                           | 산출물
----------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | TBA
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [Download](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 and 1**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 and 3**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | 상태 임시 미제공                                                                                                                                                                | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | 상태 임시 미제공                                                                                                                                                                | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | 상태 임시 미제공                                                                                                                                                                | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | 상태 임시 미제공                                                                                                                                                                | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | 상태 임시 미제공                                                                                                                                                                | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)

## 리소스

*   [TensorFlow.org](https://www.tensorflow.org)
*   [TensorFlow 튜토리얼](https://www.tensorflow.org/tutorials/)
*   [TensorFlow 공식 모델](https://github.com/tensorflow/models/tree/master/official)
*   [TensorFlow 예제](https://github.com/tensorflow/examples)
*   [TensorFlow 코드랩](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [TensorFlow 블로그](https://blog.tensorflow.org)
*   [TensorFlow로 ML 배우기](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow 트위터](https://twitter.com/tensorflow)
*   [TensorFlow 유튜브](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [TensorFlow 모델 최적화 로드맵](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [TensorFlow 백서](https://www.tensorflow.org/about/bib)
*   [TensorBoard 시각화 툴킷](https://github.com/tensorflow/tensorboard)
*   [TensorFlow 코드 검색](https://cs.opensource.google/tensorflow/tensorflow)

[TensorFlow 커뮤니티](https://www.tensorflow.org/community) 및 
[기여 방법](https://www.tensorflow.org/community/contribute)에 대해 더 알아보세요.

## 강의

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## 라이선스

[Apache License 2.0](LICENSE)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---