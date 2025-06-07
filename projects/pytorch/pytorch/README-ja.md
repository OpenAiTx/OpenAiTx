![PyTorch ロゴ](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch は、次の2つの高レベル機能を提供する Python パッケージです。
- 強力な GPU アクセラレーションを備えた Tensor 計算（NumPy のようなもの）
- テープベースの自動微分システム上に構築されたディープニューラルネットワーク

必要に応じて、NumPy、SciPy、Cython などお好きな Python パッケージを再利用して、PyTorch を拡張できます。

私たちの trunk health（継続的インテグレーションのシグナル）は [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main) で確認できます。

<!-- toc -->

- [PyTorch についてさらに詳しく](#more-about-pytorch)
  - [GPU 対応のテンソルライブラリ](#a-gpu-ready-tensor-library)
  - [動的ニューラルネットワーク: テープベース自動微分](#dynamic-neural-networks-tape-based-autograd)
  - [Python ファースト](#python-first)
  - [命令型の体験](#imperative-experiences)
  - [高速かつ軽量](#fast-and-lean)
  - [簡単な拡張性](#extensions-without-pain)
- [インストール](#installation)
  - [バイナリ](#binaries)
    - [NVIDIA Jetson プラットフォーム](#nvidia-jetson-platforms)
  - [ソースからのビルド](#from-source)
    - [前提条件](#prerequisites)
      - [NVIDIA CUDA サポート](#nvidia-cuda-support)
      - [AMD ROCm サポート](#amd-rocm-support)
      - [Intel GPU サポート](#intel-gpu-support)
    - [PyTorch ソースの取得](#get-the-pytorch-source)
    - [依存関係のインストール](#install-dependencies)
    - [PyTorch のインストール](#install-pytorch)
      - [ビルドオプションの調整（オプション）](#adjust-build-options-optional)
  - [Docker イメージ](#docker-image)
    - [事前ビルドイメージの利用](#using-pre-built-images)
    - [イメージの自作](#building-the-image-yourself)
  - [ドキュメントのビルド](#building-the-documentation)
    - [PDF のビルド](#building-a-pdf)
  - [過去バージョン](#previous-versions)
- [はじめに](#getting-started)
- [リソース](#resources)
- [コミュニケーション](#communication)
- [リリースとコントリビュート](#releases-and-contributing)
- [チーム](#the-team)
- [ライセンス](#license)

<!-- tocstop -->

## PyTorch についてさらに詳しく

[PyTorch の基本を学ぶ](https://pytorch.org/tutorials/beginner/basics/intro.html)

詳細レベルでは、PyTorch は以下のコンポーネントから成るライブラリです。

| コンポーネント | 説明 |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | NumPy のようなテンソルライブラリで、強力な GPU サポートを持つ |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | torch の全ての微分可能なテンソル操作をサポートするテープベース自動微分ライブラリ |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | PyTorch コードからシリアライズ可能かつ最適化可能なモデルを作成するためのコンパイルスタック（TorchScript） |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | autograd と深く統合されたニューラルネットワークライブラリ。最大の柔軟性を持つよう設計 |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Python のマルチプロセッシング。ただし、torch テンソルの魔法のようなメモリ共有機能付き。データローディングや Hogwild トレーニングに便利 |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader やその他のユーティリティ関数 |

通常、PyTorch は以下の用途で使われます：

- NumPy の代替として、GPU の力を活用したい場合
- 最大限の柔軟性と速度を提供するディープラーニング研究プラットフォームとして

詳細解説：

### GPU 対応のテンソルライブラリ

NumPy を使ったことがあれば、テンソル（別名 ndarray）を使ったことがあるはずです。

![Tensor illustration](./docs/source/_static/img/tensor_illustration.png)

PyTorch は、CPU または GPU 上で動作するテンソルを提供し、計算を大幅に高速化します。

スライス、インデックス操作、数学演算、線形代数、リダクションなど、幅広いテンソル操作ルーチンを提供し、
科学計算のニーズに合うよう設計されています。
そして、とても高速です！

### 動的ニューラルネットワーク: テープベース自動微分

PyTorch には、ニューラルネットワークを構築するユニークな方法があります：テープレコーダーを使って記録・再生します。

TensorFlow、Theano、Caffe、CNTK などほとんどのフレームワークは静的なネットワーク構造を持っています。
一度ネットワークを構築すると、同じ構造を何度も再利用しなければなりません。
ネットワークの挙動を変えるには、一からやり直す必要があります。

PyTorch では、逆モード自動微分（reverse-mode auto-differentiation）という技術を使い、
ネットワークの挙動を遅延やオーバーヘッドなしに自由に変更できます。
この発想は、いくつかの研究論文や
[torch-autograd](https://github.com/twitter/torch-autograd)、
[autograd](https://github.com/HIPS/autograd)、
[Chainer](https://chainer.org) など現在・過去の実装からインスパイアされています。

この技術は PyTorch 固有ではありませんが、PyTorch の実装は現時点で最速クラスです。
スピードと柔軟性の両方を手に入れることができます。

![Dynamic graph](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python ファースト

PyTorch は、巨大な C++ フレームワークへの Python バインディングではありません。
Python との深い統合を前提に設計されています。
[NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) のように自然に使えます。
お気に入りのライブラリを使って Python でニューラルネットワーク層を記述したり、
[Cython](https://cython.org/) や [Numba](http://numba.pydata.org/) などのパッケージも利用できます。
再発明する必要のないところは、再発明しないことを目指しています。

### 命令型の体験

PyTorch は直感的で、思考の流れに沿った、使いやすい設計です。
コードを1行書くと、その行が即実行されます。非同期的な世界観はありません。
デバッガに入ったりエラーメッセージやスタックトレースを受け取る場合も、理解が容易です。
スタックトレースは、まさに自分が書いたコードの箇所を指します。
悪いスタックトレースや非同期・ブラックボックスな実行エンジンのせいで
何時間もデバッグに費やすことがないよう願っています。

### 高速かつ軽量

PyTorch はフレームワークとしてのオーバーヘッドが最小限です。
[Intel MKL](https://software.intel.com/mkl) や NVIDIA の
([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)) などの
アクセラレーションライブラリと統合し、最大限の速度を実現しています。
コアとなる CPU・GPU のテンソルやニューラルネットワークのバックエンドは
成熟しており、長年にわたってテストされています。

そのため、PyTorch は小さなニューラルネットワークでも大きなニューラルネットワークでも
非常に高速です。

PyTorch のメモリ使用量は Torch や一部の代替案に比べて非常に効率的です。
GPU 用のカスタムメモリアロケータを作成し、
ディープラーニングモデルが最大限メモリ効率良くなるよう設計しています。
これにより、より大きなディープラーニングモデルの学習が可能になります。

### 簡単な拡張性

新しいニューラルネットワークモジュールの作成や、PyTorch の Tensor API とのインターフェースは
シンプルで最小限の抽象化で実現できるよう設計されています。

torch API を用いて Python で新しいニューラルネットワーク層を記述したり、
[NumPy ベースのライブラリ（SciPy など）](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html) を使うこともできます。

C/C++ で層を書きたい場合は、効率的でボイラープレートの少ない便利な拡張 API を提供しています。
ラッパーコードを書く必要はありません。
[チュートリアルはこちら](https://pytorch.org/tutorials/advanced/cpp_extension.html)、
[サンプルはこちら](https://github.com/pytorch/extension-cpp) をご参照ください。

## インストール

### バイナリ
Conda または pip wheels でバイナリをインストールするためのコマンドは公式サイトにあります: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)

#### NVIDIA Jetson プラットフォーム

NVIDIA の Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX, Jetson AGX Orin 向けの Python wheels は [こちら](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) で提供されており、L4T コンテナは [こちら](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch) で公開されています。

JetPack 4.2 以上が必要です。[`@dusty-nv`](https://github.com/dusty-nv) および [`@ptrblck`](https://github.com/ptrblck) がメンテナンスしています。

### ソースからのビルド

#### 前提条件
ソースからインストールする場合、以下が必要です：
- Python 3.9 以上
- C++17 を完全サポートするコンパイラ（clang または gcc、Linux では gcc 9.4.0 以上が必要）
- Visual Studio または Visual Studio Build Tool（Windows のみ）

\* PyTorch CI では Visual C++ BuildTools を使用しています。これは Visual Studio Enterprise, Professional, Community Edition に付属しています。ビルドツールは https://visualstudio.microsoft.com/visual-cpp-build-tools/ からもインストール可能です。ビルドツールは Visual Studio Code にはデフォルトでは付属しません。

環境構築例を以下に示します。

* Linux:

```bash
$ source <CONDA_INSTALL_DIR>/bin/activate
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
```

* Windows:

```bash
$ source <CONDA_INSTALL_DIR>\Scripts\activate.bat
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
$ call "C:\Program Files\Microsoft Visual Studio\<VERSION>\Community\VC\Auxiliary\Build\vcvarsall.bat" x64
```

##### NVIDIA CUDA サポート
CUDA サポート付きでコンパイルする場合は、[サポートマトリクスから対応 CUDA バージョンを選択](https://pytorch.org/get-started/locally/)し、下記をインストールしてください：
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 以上
- CUDA に対応した [コンパイラ](https://gist.github.com/ax3l/9489132)

注：cuDNN のバージョンと各種対応 CUDA・CUDA ドライバ・NVIDIA ハードウェアについては [cuDNN Support Matrix](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) を参照してください。

CUDA サポートを無効化する場合は、環境変数 `USE_CUDA=0` をエクスポートしてください。
他にも有用な環境変数は `setup.py` に記載されています。

NVIDIA の Jetson プラットフォーム（Jetson Nano, TX1, TX2, AGX Xavier）向けのビルドの場合、Jetson Nano 用 PyTorch インストール手順は [こちら](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/) を参照してください。

##### AMD ROCm サポート
ROCm サポート付きでコンパイルする場合は、下記をインストールしてください。
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 以上
- ROCm は現在 Linux システムのみサポートしています。

デフォルトではビルドシステムは ROCm を `/opt/rocm` にインストールされているものと期待します。別ディレクトリの場合、環境変数 `ROCM_PATH` で ROCm のインストールディレクトリを指定してください。ビルドシステムは自動で AMD GPU アーキテクチャを検出します。必要なら `PYTORCH_ROCM_ARCH` で明示的指定も可能です。[AMD GPU アーキテクチャ](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus) を参照。

ROCm サポートを無効化する場合は、環境変数 `USE_ROCM=0` をエクスポートしてください。
他にも有用な環境変数は `setup.py` に記載されています。

##### Intel GPU サポート
Intel GPU サポート付きでコンパイルする場合は、下記を参照してください。
- [PyTorch Prerequisites for Intel GPUs](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html) の手順
- Intel GPU は Linux および Windows をサポート

Intel GPU サポートを無効化する場合は、環境変数 `USE_XPU=0` をエクスポートしてください。
他にも有用な環境変数は `setup.py` に記載されています。

#### PyTorch ソースの取得
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# 既存のチェックアウトを更新する場合
git submodule sync
git submodule update --init --recursive
```

#### 依存関係のインストール

**共通**

```bash
conda install cmake ninja
# ソースコード取得後、PyTorch ディレクトリで実行
pip install -r requirements.txt
```

**Linux の場合**

```bash
pip install mkl-static mkl-include
# CUDA のみ: GPU 向け LAPACK サポートが必要な場合
# magma インストール: 有効な conda 環境で実行し、CUDA バージョンを指定
.ci/docker/common/install_magma_conda.sh 12.4

# （オプション）torch.compile with inductor/triton 利用時、対応バージョンの triton をインストール
# クローン後、pytorch ディレクトリで実行
# Intel GPU サポート時は、コマンド実行前に明示的に `export USE_XPU=1` してください。
make triton
```

**MacOS の場合**

```bash
# Intel x86 プロセッサ搭載機のみ追加
pip install mkl-static mkl-include
# torch.distributed が必要な場合のみ追加
conda install pkg-config libuv
```

**Windows の場合**

```bash
pip install mkl-static mkl-include
# torch.distributed が必要な場合のみ追加
# Windows での distributed パッケージサポートはプロトタイプ機能です。変更されることがあります。
conda install -c conda-forge libuv=1.39
```

#### PyTorch のインストール
**Linux の場合**

AMD ROCm 向けにコンパイルする場合、最初に以下を実行してください：
```bash
# ROCm 用コンパイル時のみ実行
python tools/amd_build/build_amd.py
```

PyTorch のインストール
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**macOS の場合**

```bash
python3 setup.py develop
```

**Windows の場合**

レガシー Python コードのビルド方法は [Building on legacy code and CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda) を参照してください。

**CPU のみのビルド**

このモードでは、PyTorch の計算は GPU ではなく CPU で実行されます。

```cmd
python setup.py develop
```

OpenMP に関する注意：推奨される OpenMP 実装は Intel OpenMP（iomp）です。iomp にリンクするには、ライブラリを手動でダウンロードし、`CMAKE_INCLUDE_PATH` および `LIB` を調整してください。[こちらの手順](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) を参照。設定しない場合、Microsoft Visual C OpenMP ランタイム（vcomp）が使われます。

**CUDA ベースのビルド**

このモードでは、CUDA を介して PyTorch の計算が GPU で高速化されます。

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) が CUDA ビルドに必要です。
NVTX は CUDA 配布物の一部で "Nsight Compute" と呼ばれています。すでに CUDA をインストール済みなら、再度 CUDA インストールを実行し、該当チェックボックスをオンにしてください。
CUDA + Nsight Compute は Visual Studio の後にインストールしてください。

現在、VS 2017 / 2019、および Ninja が CMake のジェネレータとしてサポートされています。`ninja.exe` が `PATH` に見つかった場合は Ninja がデフォルト、なければ VS 2017/2019 が使われます。
<br/> Ninja 使用時は最新の MSVC がツールチェーンとして選択されます。

追加ライブラリとして
[Magma](https://developer.nvidia.com/magma), [oneDNN（MKLDNN/DNNL）](https://github.com/oneapi-src/oneDNN), [Sccache](https://github.com/mozilla/sccache) などが必要なことがあります。[インストールヘルパー](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) を参照してください。

他環境変数の設定例は [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) を参照してください。

```cmd
cmd

:: mkl パッケージをダウンロード・解凍後に環境変数を設定してください。
:: そうでないと CMake が `Could NOT find OpenMP` エラーを出します。
set CMAKE_INCLUDE_PATH={Your directory}\mkl\include
set LIB={Your directory}\mkl\lib;%LIB%

:: 前セクション内容をよく読んでから実行してください。
:: [オプション] Ninja および Visual Studio で使うツールセットを上書きしたい場合は下記スクリプトを実行。
:: "Visual Studio 2019 Developer Command Prompt" が自動で起動します。
:: Visual Studio ジェネレータ利用時は CMake >= 3.12 が必要です。
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [オプション] CUDA のホストコンパイラを上書きしたい場合
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Intel GPU ビルド**

このモードでは Intel GPU サポート付きで PyTorch をビルドします。

[共通の前提条件](#prerequisites) および [Intel GPU 用の前提条件](#intel-gpu-support) を事前にインストールし、
環境変数を構成してください。ビルドツールは `Visual Studio 2022` が必要です。

その後、以下のコマンドでビルドできます。

```cmd
:: CMD コマンド:
:: CMAKE_PREFIX_PATH をセットして対応パッケージを見つけやすくします
:: %CONDA_PREFIX% は `conda activate custom_env` 後のみ機能します

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### ビルドオプションの調整（オプション）

cmake 変数の設定を（ビルド前に）調整できます。たとえば CuDNN や BLAS のディレクトリを手動設定したい場合など。

Linux の場合
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # または cmake-gui build
```

macOS の場合
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # または cmake-gui build
```

### Docker イメージ

#### 事前ビルドイメージの利用

Docker Hub から事前ビルドの docker イメージを pull し、docker v19.03+ で実行できます。

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

PyTorch はプロセス間でデータ共有のため共有メモリを使うため、torch のマルチプロセッシング機能
（例：マルチスレッドデータローダ）が使われる場合、コンテナのデフォルト共有メモリサイズでは足りません。
`--ipc=host` または `--shm-size` オプションで共有メモリサイズを増やしてください。

#### イメージの自作

**注意:** docker バージョン > 18.06 でビルドしてください。

`Dockerfile` は CUDA 11.1 サポート・cuDNN v8 対応イメージをビルドするためのものです。
`PYTHON_VERSION=x.y` を make 変数で指定すれば、Miniconda で使う Python バージョンを指定できます。
未指定ならデフォルト値が使われます。

```bash
make -f docker.Makefile
# イメージは docker.io/${your_docker_username}/pytorch でタグ付けされます
```

ビルド時に追加の CMake 変数を指定したい場合は、`CMAKE_VARS="..."` 環境変数を使ってください。
利用可能な変数一覧は [setup.py](./setup.py) を参照。

```bash
make -f docker.Makefile
```

### ドキュメントのビルド

さまざまな形式でドキュメントをビルドするには、[Sphinx](http://www.sphinx-doc.org) と pytorch_sphinx_theme2 が必要です。

ローカルでドキュメントをビルドする前に、`torch` を環境にインストールしてください。
小さな修正であれば [Getting Started](https://pytorch.org/get-started/locally/) の説明に従い
nightly バージョンをインストールできます。

新しいモジュール追加や docstring 追加のような大きな修正の場合、[ソースからインストール](#from-source)が必要です。
docstring 規約については [Docstring Guidelines](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines) を参照。

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

`make` を実行すると全出力形式の一覧が得られます。

katex エラーが出た場合は `npm install katex` を実行してください。解決しない場合は
`npm install -g katex` を試してください。

> [!NOTE]
> `nodejs` を別のパッケージマネージャ（例：`conda`）でインストールした場合、`npm` でインストールされる `katex` バージョンが
> `nodejs` のバージョンと互換性がなくなり、ドキュメントビルドが失敗することがあります。
> 動作確認済みの組み合わせは `node@6.13.1` と `katex@0.13.18` です。後者は
> ```npm install -g katex@0.13.18``` でインストールできます。

> [!NOTE]
> numpy の互換性エラーが出る場合は、次を実行してください:
> ```
> pip install 'numpy<2'
> ```

CI で実行される依存関係に変更を加えた場合は、
`.ci/docker/requirements-docs.txt` ファイルを編集してください。

#### PDF のビルド

PyTorch ドキュメント全体の PDF をビルドするには、
`texlive` および LaTeX をインストールしてください。macOS では下記でインストールできます：

```
brew install --cask mactex
```

PDF 作成手順：

1. 実行：

   ```
   make latexpdf
   ```

   `build/latex` ディレクトリに必要ファイルが生成されます。

2. このディレクトリに移動して下記を実行：

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   これで `pytorch.pdf` が生成されます。目次やインデックスを正しく生成するために、もう一度このコマンドを実行してください。

> [!NOTE]
> PDF ビューアの **Table of Contents** 表示を使うと目次が見られます。

### 過去バージョン

過去の PyTorch バージョンのインストール手順やバイナリは
[公式サイト](https://pytorch.org/get-started/previous-versions) で確認できます。

## はじめに

入門に役立つ3つのポイント：
- [チュートリアル: PyTorch の理解と利用を始める](https://pytorch.org/tutorials/)
- [サンプル: 各ドメイン向けの分かりやすい PyTorch コード](https://github.com/pytorch/examples)
- [API リファレンス](https://pytorch.org/docs/)
- [用語集](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## リソース

* [PyTorch.org](https://pytorch.org/)
* [PyTorch チュートリアル](https://pytorch.org/tutorials/)
* [PyTorch サンプル](https://github.com/pytorch/examples)
* [PyTorch モデル](https://pytorch.org/hub/)
* [Udacity による PyTorch 入門](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Udacity による PyTorch で始める機械学習](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Coursera による PyTorch で学ぶディープニューラルネットワーク](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [PyTorch ブログ](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## コミュニケーション
* フォーラム: 実装・研究などの議論 https://discuss.pytorch.org
* GitHub Issues: バグ報告、機能要望、インストール問題、RFC、意見交換など
* Slack: [PyTorch Slack](https://pytorch.slack.com/) には中級～上級 PyTorch ユーザー・開発者向けのチャットや議論の場があります。初心者の方は主に [PyTorch Forums](https://discuss.pytorch.org) をご利用ください。Slack 招待が必要な場合は次のフォームを記入してください: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* ニュースレター: ノイズなしで重要なお知らせのみの一方向メールニュース。登録はこちら: https://eepurl.com/cbG0rv
* Facebook ページ: PyTorch の重要なお知らせ https://www.facebook.com/pytorch
* ブランドガイドラインは [pytorch.org](https://pytorch.org/) をご参照ください。

## リリースとコントリビュート

通常、PyTorch は年3回のマイナーリリースを行っています。バグを見つけたら [Issue を登録](https://github.com/pytorch/pytorch/issues) してください。

全てのコントリビュートを歓迎します。バグ修正のコントリビュートは事前相談なしで構いません。

新機能・ユーティリティ・コア拡張などを提案したい場合は、まず issue を立ててご相談ください。
事前相談なしで PR を送ると、プロジェクトの方向性次第でリジェクトされる場合があります。

PyTorch へのコントリビュート方法は [Contribution ページ](CONTRIBUTING.md) を、
リリース情報は [Release ページ](RELEASE.md) を参照してください。

## チーム

PyTorch は、多くの優れたエンジニア・研究者によるコミュニティ主導のプロジェクトです。

現在の PyTorch メンテナーは [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang), [Nikita Shulga](https://github.com/malfet) です。その他、多数の才能ある個人が多様な形で貢献しています。
（抜粋・随時拡大中）：[Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito) など。

注意：このプロジェクトは、同名の [hughperkins/pytorch](https://github.com/hughperkins/pytorch) とは無関係です。Hugh 氏は Torch コミュニティの貴重な貢献者であり、Torch および PyTorch の多くの事柄に協力しています。

## ライセンス

PyTorch は BSD スタイルのライセンスです。詳細は [LICENSE](LICENSE) ファイルをご覧ください。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---