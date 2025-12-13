    版权所有 (C) 2013-2018 Christian Thomas Jacobs。

    本文件是 PyQSO 的一部分。

    PyQSO 是自由软件：您可以重新分发和/或修改
    它，遵循自由软件基金会发布的 GNU 通用公共许可证的条款，
    许可证版本为第3版，或（根据您的选择）任何更高版本。

    PyQSO 的发布旨在有所帮助，
    但不提供任何保证；即使没有明示的适销性或适用于特定用途的保证。
    有关详细信息，请参阅
    GNU 通用公共许可证。

    您应该已随 PyQSO 一起收到 GNU 通用公共许可证的副本。
    如果没有，请访问 <http://www.gnu.org/licenses/>。

# PyQSO

PyQSO 是一款业余无线电操作员的联系人记录工具。

[![文档状态](https://readthedocs.org/projects/pyqso/badge/?version=latest)](https://readthedocs.org/projects/pyqso/?badge=latest)

## 依赖项

顾名思义，PyQSO 主要使用 [Python](https://www.python.org/) 编程语言（3.x 版本）编写。图形用户界面使用 [GTK+ 库](https://www.gtk.org/) 通过 [PyGObject 绑定](https://pygobject.readthedocs.io) 开发。因此，要运行 PyQSO，您的系统必须安装 Python 解释器以及 GTK+ 支持。在许多基于 Linux 的系统中，可以通过安装以下 Debian 软件包来实现：

* python3
* gir1.2-gtk-3.0
* python3-gi-cairo

若要启用 PyQSO 的全部功能，需要几个额外的软件包。其中许多（在 `requirements.txt` 文件中指定）可以通过在终端执行以下命令，使用 Python 包管理器系统范围安装：

    sudo pip3 install -U -r requirements.txt

但完整列表如下：

* python3-matplotlib（版本 1.3.0 或更高）
* python3-numpy
* libxcb-render0-dev

* [cartopy](http://scitools.org.uk/cartopy/)，用于绘制世界地图。该包依赖于 python3-scipy、python3-cairocffi、cython、libproj-dev（版本4.9.0或更高）和 libgeos-dev（版本3.3.3或更高）。
* [geocoder](https://pypi.python.org/pypi/geocoder)，用于 QTH 查询。
* python3-sphinx，用于构建文档。
* python3-hamlib，用于 Hamlib 支持。

### Hamlib 支持

目前没有适用于 Python 3 的 Debian 包来支持 [Hamlib](http://www.hamlib.org)。必须手动构建该库以启用 Hamlib 支持。根据 [Hamlib 邮件列表](https://sourceforge.net/p/hamlib/mailman/message/35692744/)上的指示，在 Hamlib 根目录下运行以下命令（可能需要先运行 `sudo apt-get install build-essential autoconf automake libtool`）：

    export PYTHON=/usr/bin/python3
    autoreconf --install
    ./configure --with-python-binding
    make
    sudo make install

还需要将 Hamlib 的 `bindings` 和 `bindings/.libs` 目录添加到 `PYTHONPATH` 中：

    export PYTHONPATH=$PYTHONPATH:/path/to/hamlib/bindings:/path/to/hamlib/bindings/.libs

## 安装和运行

假设当前工作目录是 PyQSO 的基础目录（即包含 `Makefile` 的目录），可以在终端中运行以下命令来直接运行 PyQSO，无需安装：

    python3 bin/pyqso

如果系统中已安装 Python 包管理器 `pip3`，则可以使用以下命令将 PyQSO 安装到系统范围：

    sudo make install

安装完成后，可以使用以下命令运行 PyQSO：

    pyqso

## 文档

关于如何使用 PyQSO 的指导可在 [Read the Docs](http://pyqso.readthedocs.io/) 上找到，且可观看以下教学视频。

[![PyQSO: A Logging Tool for Amateur Radio Operators](https://img.youtube.com/vi/sVdZl9KnDsk/0.jpg)](https://www.youtube.com/watch?v=sVdZl9KnDsk)

文档也可以通过以下命令本地构建：

    make docs

这将生成文档的 HTML 版本，位于 `docs/build/html`，可以在网页浏览器中打开。

## 联系方式

请在 GitHub 的问题追踪器上提出关于 PyQSO 的任何技术问题或功能建议。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-13

---