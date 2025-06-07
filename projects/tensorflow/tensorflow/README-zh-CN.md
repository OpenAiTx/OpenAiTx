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

**`文档`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) 是一个端到端的开源机器学习平台。它拥有一个全面且灵活的[工具](https://www.tensorflow.org/resources/tools)、[库](https://www.tensorflow.org/resources/libraries-extensions)和[社区](https://www.tensorflow.org/community)资源生态系统，使研究人员能够推动机器学习领域的最新发展，并让开发者能够轻松构建和部署基于机器学习的应用程序。

TensorFlow 最初由 Google Brain 机器智能团队的研究人员和工程师开发，用于机器学习和神经网络领域的研究。但该框架足够灵活，也可应用于其他领域。

TensorFlow 提供了稳定的 [Python](https://www.tensorflow.org/api_docs/python) 和 [C++](https://www.tensorflow.org/api_docs/cc) API，并为[其他语言](https://www.tensorflow.org/api_docs)提供了不保证向后兼容性的 API。

通过订阅 [announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce) 可及时获取发布公告和安全更新。查看所有[邮件列表](https://www.tensorflow.org/community/forums)。

## 安装

请参阅 [TensorFlow 安装指南](https://www.tensorflow.org/install) 以获取 [pip 包](https://www.tensorflow.org/install/pip)、[启用 GPU 支持](https://www.tensorflow.org/install/gpu)、使用 [Docker 容器](https://www.tensorflow.org/install/docker) 以及[源码构建](https://www.tensorflow.org/install/source)的说明。

要安装当前版本（支持 [CUDA GPU 显卡](https://www.tensorflow.org/install/gpu) *（Ubuntu 和 Windows）*）：

```
$ pip install tensorflow
```

其他设备（DirectX 和 MacOS-metal）可通过 [设备插件](https://www.tensorflow.org/install/gpu_plugins#available_devices)获得支持。

也提供仅支持 CPU 的精简包：

```
$ pip install tensorflow-cpu
```

要将 TensorFlow 升级到最新版，请在上述命令中添加 `--upgrade` 参数。

*夜间测试版可通过 PyPI 上的 [tf-nightly](https://pypi.python.org/pypi/tf-nightly) 和 [tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) 包获取。*

#### *尝试你的第一个 TensorFlow 程序*

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

更多示例请参见 [TensorFlow 教程](https://www.tensorflow.org/tutorials/)。

## 贡献指南

**如果你想为 TensorFlow 做贡献，请务必阅读[贡献指南](CONTRIBUTING.md)。本项目遵循 TensorFlow 的[行为准则](CODE_OF_CONDUCT.md)。参与本项目即表示你同意遵守该准则。**

**我们使用 [GitHub 问题](https://github.com/tensorflow/tensorflow/issues) 跟踪需求和 bug。如有一般性问题或讨论，请参见 [TensorFlow 论坛](https://discuss.tensorflow.org/)，具体问题请前往 [Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow)。**

TensorFlow 项目致力于遵循开源软件开发领域普遍认可的最佳实践。

## 修补指南

按照以下步骤修补 TensorFlow 的特定版本，例如，用于修复 bug 或安全漏洞：

*   克隆 TensorFlow 仓库，并切换到目标版本对应的分支，例如版本 2.8 对应分支 `r2.8`。
*   应用（即 cherry-pick）所需的更改，并解决任何代码冲突。
*   运行 TensorFlow 测试并确保全部通过。
*   从源码[构建](https://www.tensorflow.org/install/source) TensorFlow pip 包。

## 持续构建状态

你可以在 [TensorFlow SIG Build 社区构建表](https://github.com/tensorflow/build#community-supported-tensorflow-builds)中找到更多社区支持的平台和配置。

### 官方构建

构建类型                      | 状态                                                                                                                                                                           | 构建产物
----------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | 待定
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [下载](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 和 1**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 和 3**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | 状态暂不可用                                                                                                                                                                     | [夜间构建](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [官方 GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | 状态暂不可用                                                                                                                                                                     | [夜间构建](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [官方 GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | 状态暂不可用                                                                                                                                                                     | [夜间构建](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [官方 GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | 状态暂不可用                                                                                                                                                                     | [夜间构建](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [官方 GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | 状态暂不可用                                                                                                                                                                     | [夜间构建](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [官方 GCS](https://storage.googleapis.com/tensorflow/)

## 资源

*   [TensorFlow.org](https://www.tensorflow.org)
*   [TensorFlow 教程](https://www.tensorflow.org/tutorials/)
*   [TensorFlow 官方模型](https://github.com/tensorflow/models/tree/master/official)
*   [TensorFlow 示例](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [TensorFlow 博客](https://blog.tensorflow.org)
*   [用 TensorFlow 学习机器学习](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow 推特](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [TensorFlow 模型优化路线图](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [TensorFlow 白皮书](https://www.tensorflow.org/about/bib)
*   [TensorBoard 可视化工具](https://github.com/tensorflow/tensorboard)
*   [TensorFlow 代码搜索](https://cs.opensource.google/tensorflow/tensorflow)

了解更多关于 [TensorFlow 社区](https://www.tensorflow.org/community) 及如何[贡献](https://www.tensorflow.org/community/contribute)的信息。

## 课程

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## 许可证

[Apache License 2.0](LICENSE)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---