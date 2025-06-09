这是 Python 版本 3.15.0 alpha 0
=====================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: CPython 在 GitHub Actions 上的构建状态
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: CPython 在 Azure DevOps 上的构建状态
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Python Discourse 聊天
   :target: https://discuss.python.org/


版权所有 © 2001 Python 软件基金会。保留所有权利。

有关进一步的版权和许可证信息，请参见本文件末尾。

.. contents::

基本信息
-------------------

- 网站: https://www.python.org
- 源代码: https://github.com/python/cpython
- 问题跟踪: https://github.com/python/cpython/issues
- 文档: https://docs.python.org
- 开发者指南: https://devguide.python.org/

参与贡献 CPython
-----------------------

有关参与 CPython 开发的更完整说明，请参见 `开发者指南`_。

.. _开发者指南: https://devguide.python.org/

使用 Python
------------

可安装的 Python 套件及关于使用 Python 的信息可在
`python.org`_ 获取。

.. _python.org: https://www.python.org/

构建说明
------------------

在 Unix、Linux、BSD、macOS 和 Cygwin 下::

    ./configure
    make
    make test
    sudo make install

这会将 Python 安装为 ``python3``。

你可以为 configure 脚本传递许多选项；运行 ``./configure --help``
以了解更多信息。在 macOS 不区分大小写的文件系统和 Cygwin 上，
可执行文件名为 ``python.exe``；在其他地方则为 ``python``。

构建完整的 Python 安装需要使用各种
额外的第三方库，这取决于你的构建平台和
configure 选项。并非所有标准库模块都能在所有平台上构建或使用。
请参考 `开发者指南`_ 的
`安装依赖 <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
部分，获取当前关于各类 Linux 发行版和 macOS 的依赖详细信息。

在 macOS 上，有与 macOS 框架和通用构建相关的额外 configure 和构建选项。
请参考 `Mac/README.rst
<https://raw.githubusercontent.com/python/cpython/main/Mac/README.rst>`_。

在 Windows 上，请参见 `PCbuild/readme.txt
<https://raw.githubusercontent.com/python/cpython/main/PCbuild/readme.txt>`_。

要构建 Windows 安装程序，请参见 `Tools/msi/README.txt
<https://raw.githubusercontent.com/python/cpython/main/Tools/msi/README.txt>`_。

如果需要，你可以创建一个子目录并从那里调用 configure。
例如::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

（如果你*还*在顶级目录下构建过，这会失败。你应先在顶级目录下执行
``make clean``。）

要获得优化后的 Python 构建，在运行 ``make`` 之前
使用 ``configure --enable-optimizations``。这会将默认的 make 目标设置为启用
性能分析优化（PGO），并可能在某些平台上自动启用链接时优化（LTO）。
详情见下文相关章节。

性能分析优化（PGO）
^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO 利用的是较新版本的 GCC 或 Clang 编译器。如果启用，
无论是通过 ``configure --enable-optimizations`` 还是手动运行
``make profile-opt``（不论 configure 标志如何），优化构建
过程将执行以下步骤：

整个 Python 目录会被清理掉此前编译中产生的临时文件。

会构建一个带有插桩的解释器版本，针对每种风格使用合适的编译器参数。请注意，这仅是一个中间步骤。
该步骤生成的二进制文件并不适合实际工作负载，因为其内部嵌入了分析指令。

插桩解释器构建完成后，Makefile 会运行一个训练工作负载。
这是为了分析解释器的执行情况。请注意，这一步可能产生的所有输出（stdout 和 stderr）都会被抑制。

最后一步是根据插桩解释器收集到的信息来构建实际的解释器。
最终将得到一个经过优化的 Python 二进制文件；适合于发行或生产环境安装。


链接时优化（LTO）
^^^^^^^^^^^^^^^^^^^^^^

通过 configure 的 ``--with-lto`` 选项启用。
LTO 利用最新编译工具链可以在构建最终可执行文件或共享库时，
跨越 ``.o`` 文件的边界进行优化，以获得更高的性能提升。


新特性
----------

我们有一份全面的变更总览，详见 `What's new in Python
3.15 <https://docs.python.org/3.15/whatsnew/3.15.html>`_ 文档。若需更
详细的变更日志，请阅读 `Misc/NEWS
<https://raw.githubusercontent.com/python/cpython/main/Misc/NEWS.d>`_，
但完整的变更信息只能通过 `提交历史
<https://github.com/python/cpython/commits/main>`_ 得到。

如果你想安装多个版本的 Python，请参见下方的
“安装多个版本”一节。


文档
-------------

`Python 3.15 文档 <https://docs.python.org/3.15/>`_ 在线提供，
每日更新。

也可下载多种格式以便快速访问。文档可下载为 HTML、PDF 和 reStructuredText 格式；
其中 reStructuredText 版本主要供文档作者、翻译人员和有特殊格式需求的人使用。

关于构建 Python 文档的信息，请参见 `Doc/README.rst
<https://raw.githubusercontent.com/python/cpython/main/Doc/README.rst>`_。


测试
-------

要测试解释器，在顶级目录下输入 ``make test``。测试
集会产生一些输出。对于因可选特性无法导入而跳过的测试消息，一般可以忽略。
如果出现测试失败消息，或输出回溯或 core dump，
则说明有问题。

默认情况下，测试会防止过度使用资源（如磁盘空间和内存）。
要启用这些测试，请运行 ``make buildbottest``。

如果有测试失败，可以以详细模式重新运行失败的测试。例如，如果
``test_os`` 和 ``test_gdb`` 失败，可以运行::

    make test TESTOPTS="-v test_os test_gdb"

如果故障持续存在且看起来是 Python 本身的问题而非环境问题，可以
`提交 bug 报告
<https://github.com/python/cpython/issues>`_ 并附上该命令的相关输出以说明问题。

更多关于测试的内容，请参见 `运行和编写测试 <https://devguide.python.org/testing/run-write-tests.html>`_。

安装多个版本
----------------------------

在 Unix 和 Mac 系统下，如果你打算在同一安装前缀（configure 脚本的 ``--prefix`` 参数）下安装多个版本的 Python，
必须确保主要的 python 可执行文件不会被其他版本安装时覆盖。
所有用 ``make altinstall`` 安装的文件和目录都带有主次版本号，因此可以共存。
``make install`` 还会创建 ``${prefix}/bin/python3``，它指向 ``${prefix}/bin/python3.X``。
如果你打算在同一前缀下安装多个版本，你必须决定哪个版本（如有）作为你的“主”版本。安装该版本时使用
``make install``。使用 ``make altinstall`` 安装所有其他版本。

例如，如果你想安装 Python 2.7、3.6 和 3.15，并且 3.15 是主要版本，你应该在 3.15 的构建目录中执行 ``make install``，在其他版本的目录中执行 ``make altinstall``。


发行计划
--------

有关 Python 3.15 的发行详情，请参见 `PEP 790 <https://peps.python.org/pep-0790/>`__。


版权与许可信息
---------------

版权所有 © 2001 Python Software Foundation。保留所有权利。

版权所有 © 2000 BeOpen.com。保留所有权利。

版权所有 © 1995-2001 国家研究倡议公司（Corporation for National Research Initiatives）。保留所有权利。

版权所有 © 1991-1995 Stichting Mathematisch Centrum。保留所有权利。

有关本软件的历史、使用条款和免责声明信息，请参见 `LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_。

该 Python 发行版*不包含*任何 GNU 通用公共许可证（GPL）代码，因此可以用于专有项目。虽然存在一些 GNU 代码的接口，但这些都是完全可选的。

本文档中提及的所有商标均属于其各自持有者所有。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---