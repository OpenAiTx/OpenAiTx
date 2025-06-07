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

**`ドキュメント`** |
------------------- |
[![Documentation](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) は、機械学習のためのエンドツーエンドのオープンソースプラットフォームです。  
[ツール](https://www.tensorflow.org/resources/tools)、[ライブラリ](https://www.tensorflow.org/resources/libraries-extensions)、  
[コミュニティ](https://www.tensorflow.org/community) リソースから構成される包括的で柔軟なエコシステムを備えており、  
研究者が機械学習の最先端を推進し、開発者がMLを活用したアプリケーションを簡単に構築・デプロイできるようにします。

TensorFlowはもともと、Google BrainのMachine Intelligenceチームの研究者とエンジニアによって、  
機械学習とニューラルネットワークの研究のために開発されました。しかし、このフレームワークは他の分野でも十分に活用できます。

TensorFlowは、安定した [Python](https://www.tensorflow.org/api_docs/python) および  
[C++](https://www.tensorflow.org/api_docs/cc) APIを提供しており、  
[他の言語](https://www.tensorflow.org/api_docs)向けにも後方互換性が保証されないAPIがあります。

リリース情報やセキュリティアップデートを受け取るには、  
[announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce) に登録してください。  
すべての[メーリングリスト](https://www.tensorflow.org/community/forums)もご覧いただけます。

## インストール

[pipパッケージ](https://www.tensorflow.org/install/pip) のインストール、  
[GPUサポートの有効化](https://www.tensorflow.org/install/gpu)、  
[Dockerコンテナの利用](https://www.tensorflow.org/install/docker)、  
[ソースからのビルド](https://www.tensorflow.org/install/source) については、  
[TensorFlowインストールガイド](https://www.tensorflow.org/install) をご覧ください。

[CUDA対応GPUカード](https://www.tensorflow.org/install/gpu) をサポートする現在のリリースをインストールするには  
（*UbuntuおよびWindows*）:

```
$ pip install tensorflow
```

他のデバイス（DirectXやMacOS-metal）は  
[デバイスプラグイン](https://www.tensorflow.org/install/gpu_plugins#available_devices) を利用してサポートされています。

より小さいCPU専用パッケージも利用可能です:

```
$ pip install tensorflow-cpu
```

TensorFlowを最新版にアップデートするには、上記コマンドに `--upgrade` フラグを追加してください。

*テスト用のナイトリーバイナリは、PyPIの  
[tf-nightly](https://pypi.python.org/pypi/tf-nightly) および  
[tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) パッケージから利用できます。*

#### *最初のTensorFlowプログラムを試してみましょう*

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

さらに多くの例については、[TensorFlowチュートリアル](https://www.tensorflow.org/tutorials/) をご覧ください。

## 貢献ガイドライン

**TensorFlowへのコントリビューションを希望される場合は、  
[コントリビューションガイドライン](CONTRIBUTING.md) を必ずご確認ください。  
本プロジェクトはTensorFlowの[行動規範](CODE_OF_CONDUCT.md)に従っています。  
参加される方は、この規範を遵守することが求められます。**

**要望やバグの追跡には[GitHub issues](https://github.com/tensorflow/tensorflow/issues)を利用しています。  
一般的な質問やディスカッションは[TensorFlow Forum](https://discuss.tensorflow.org/)を、  
特定の質問は[Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow)をご利用ください。**

TensorFlowプロジェクトは、オープンソースソフトウェア開発における一般的なベストプラクティスに従うことを目指しています。

## パッチ適用ガイドライン

例えばバグやセキュリティ脆弱性の修正を適用するなど、特定バージョンのTensorFlowにパッチを適用するには、次の手順に従ってください:

*   TensorFlowリポジトリをクローンし、目的のTensorFlowバージョンに対応するブランチ（例: バージョン2.8の場合は`r2.8`ブランチ）に切り替えます。
*   必要な変更を適用（チェリーピック）し、コードのコンフリクトを解決します。
*   TensorFlowのテストを実行し、すべてパスすることを確認します。
*   ソースからTensorFlowのpipパッケージを[ビルド](https://www.tensorflow.org/install/source)します。

## 継続的ビルドステータス

コミュニティがサポートする他のプラットフォームや構成については、  
[TensorFlow SIG Build community builds table](https://github.com/tensorflow/build#community-supported-tensorflow-builds) をご覧ください。

### 公式ビルド

ビルドタイプ                    | ステータス                                                                                                                                                                           | アーティファクト
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
**Libtensorflow MacOS CPU**   | ステータス一時的に利用不可                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | ステータス一時的に利用不可                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | ステータス一時的に利用不可                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | ステータス一時的に利用不可                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | ステータス一時的に利用不可                                                                                                                                                   | [Nightly Binary](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [Official GCS](https://storage.googleapis.com/tensorflow/)

## リソース

*   [TensorFlow.org](https://www.tensorflow.org)
*   [TensorFlowチュートリアル](https://www.tensorflow.org/tutorials/)
*   [TensorFlow公式モデル](https://github.com/tensorflow/models/tree/master/official)
*   [TensorFlowサンプル](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [TensorFlowブログ](https://blog.tensorflow.org)
*   [TensorFlowで学ぶ機械学習](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow Twitter](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [TensorFlowモデル最適化ロードマップ](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [TensorFlowホワイトペーパー](https://www.tensorflow.org/about/bib)
*   [TensorBoard可視化ツールキット](https://github.com/tensorflow/tensorboard)
*   [TensorFlowコード検索](https://cs.opensource.google/tensorflow/tensorflow)

[TensorFlowコミュニティ](https://www.tensorflow.org/community) および  
[コントリビューション方法](https://www.tensorflow.org/community/contribute) についてさらに詳しく知ることができます。

## コース

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## ライセンス

[Apache License 2.0](LICENSE)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---