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

**`文件`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) 是一個端到端的開源機器學習平台。它擁有一個完整且靈活的生態系統，包括[工具](https://www.tensorflow.org/resources/tools)、[函式庫](https://www.tensorflow.org/resources/libraries-extensions)、以及[社群](https://www.tensorflow.org/community)資源，使研究人員能推動機器學習的最先進技術，開發人員也能輕鬆建立與部署機器學習驅動的應用程式。

TensorFlow 最初由 Google Brain 機器智慧團隊的研究人員和工程師開發，用於機器學習和神經網路的研究。然而，此框架足夠靈活，也可應用於其他領域。

TensorFlow 提供穩定的 [Python](https://www.tensorflow.org/api_docs/python) 與 [C++](https://www.tensorflow.org/api_docs/cc) API，並對[其他語言](https://www.tensorflow.org/api_docs)提供不保證向後相容的 API。

透過訂閱 [announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce) 可隨時獲得發佈公告與安全性更新。請參閱所有[郵件列表](https://www.tensorflow.org/community/forums)。

## 安裝

請參閱 [TensorFlow 安裝指南](https://www.tensorflow.org/install)，獲取 [pip 套件](https://www.tensorflow.org/install/pip)、[啟用 GPU 支援](https://www.tensorflow.org/install/gpu)、使用 [Docker 容器](https://www.tensorflow.org/install/docker) 及 [從原始碼建構](https://www.tensorflow.org/install/source) 的說明。

要安裝目前的版本（支援 [CUDA 啟用的 GPU 顯示卡](https://www.tensorflow.org/install/gpu) *(Ubuntu 和 Windows)*）：

```
$ pip install tensorflow
```

其他裝置（DirectX 與 MacOS-metal）可透過[裝置外掛程式](https://www.tensorflow.org/install/gpu_plugins#available_devices)支援。

亦提供較小的僅 CPU 版本：

```
$ pip install tensorflow-cpu
```

若要更新 TensorFlow 至最新版本，請在上述指令加入 `--upgrade` 參數。

*可用於測試的夜間版本可透過 [tf-nightly](https://pypi.python.org/pypi/tf-nightly) 及 [tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) 於 PyPI 取得。*

#### *試試您的第一個 TensorFlow 程式*

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

更多範例請參閱 [TensorFlow 教學](https://www.tensorflow.org/tutorials/)。

## 貢獻指南

**如果您想貢獻 TensorFlow，請務必閱讀[貢獻指南](CONTRIBUTING.md)。本專案遵循 TensorFlow 的[行為準則](CODE_OF_CONDUCT.md)。參與者需遵守此準則。**

**我們使用 [GitHub 議題](https://github.com/tensorflow/tensorflow/issues) 來追蹤需求與錯誤，請參閱 [TensorFlow 論壇](https://discuss.tensorflow.org/) 進行一般性問題與討論，具體問題請至 [Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow) 提問。**

TensorFlow 專案致力於遵循開源軟體開發的通用最佳實踐。

## 修補程式指南

請依照以下步驟修補指定版本的 TensorFlow，例如用於修正錯誤或安全漏洞：

*   複製 TensorFlow 存放庫，並切換至所需版本的對應分支，例如 v2.8 請切換至 `r2.8` 分支。
*   套用（即 cherry-pick）所需的變更，並解決任何程式碼衝突。
*   執行 TensorFlow 測試並確保全部通過。
*   從原始碼[建構](https://www.tensorflow.org/install/source) TensorFlow pip 套件。

## 持續建構狀態

您可以在 [TensorFlow SIG Build 社群建構表](https://github.com/tensorflow/build#community-supported-tensorflow-builds) 找到更多社群支援的平台與組態。

### 官方建構

建構類型                    | 狀態                                                                                                                                                                           | 構建產物
----------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | TBA
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [下載](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 和 1**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 和 3**      | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | 狀態暫時無法取得                                                                                                                                                   | [夜間建構檔](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [官方 GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | 狀態暫時無法取得                                                                                                                                                   | [夜間建構檔](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [官方 GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | 狀態暫時無法取得                                                                                                                                                   | [夜間建構檔](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [官方 GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | 狀態暫時無法取得                                                                                                                                                   | [夜間建構檔](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [官方 GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | 狀態暫時無法取得                                                                                                                                                   | [夜間建構檔](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [官方 GCS](https://storage.googleapis.com/tensorflow/)

## 資源

*   [TensorFlow.org](https://www.tensorflow.org)
*   [TensorFlow 教學](https://www.tensorflow.org/tutorials/)
*   [TensorFlow 官方模型](https://github.com/tensorflow/models/tree/master/official)
*   [TensorFlow 範例](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [TensorFlow 部落格](https://blog.tensorflow.org)
*   [利用 TensorFlow 學習 ML](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow Twitter](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [TensorFlow 模型最佳化路線圖](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [TensorFlow 白皮書](https://www.tensorflow.org/about/bib)
*   [TensorBoard 視覺化工具](https://github.com/tensorflow/tensorboard)
*   [TensorFlow 程式碼搜尋](https://cs.opensource.google/tensorflow/tensorflow)

進一步了解 [TensorFlow 社群](https://www.tensorflow.org/community) 以及如何[參與貢獻](https://www.tensorflow.org/community/contribute)。

## 課程

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## 授權

[Apache License 2.0](LICENSE)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---