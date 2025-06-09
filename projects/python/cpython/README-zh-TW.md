這是 Python 版本 3.15.0 alpha 0
=====================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: CPython 在 GitHub Actions 上的建置狀態
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: CPython 在 Azure DevOps 上的建置狀態
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Python Discourse 聊天
   :target: https://discuss.python.org/


版權所有 © 2001 Python 軟體基金會。保留所有權利。

有關進一步的版權與授權資訊，請參閱本檔案結尾。

.. contents::

一般資訊
-------------------

- 官方網站: https://www.python.org
- 原始碼: https://github.com/python/cpython
- 問題追蹤: https://github.com/python/cpython/issues
- 文件: https://docs.python.org
- 開發者指南: https://devguide.python.org/

貢獻於 CPython
-----------------------

如需更完整的貢獻 CPython 開發說明，請參閱 `Developer Guide`_。

.. _Developer Guide: https://devguide.python.org/

使用 Python
------------

可安裝的 Python 套件及使用 Python 的相關資訊，請參閱
`python.org`_。

.. _python.org: https://www.python.org/

建置說明
------------------

在 Unix、Linux、BSD、macOS 和 Cygwin 上::

    ./configure
    make
    make test
    sudo make install

這將會將 Python 安裝為 ``python3``。

你可以傳遞許多選項給 configure 腳本；執行 ``./configure --help``
以瞭解更多資訊。在 macOS 不分大小寫的檔案系統及 Cygwin 上，
可執行檔稱為 ``python.exe``；其他平台則為 ``python``。

建置完整的 Python 安裝需要依據你的建置平台及 configure 選項
使用各種第三方函式庫。並非所有標準函式庫模組都能在所有平台
上建置或使用。請參閱 `Developer Guide`_ 中
`Install dependencies <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
章節，瞭解各 Linux 發行版及 macOS 目前的依賴細節。

在 macOS 上，另有與 macOS framework 及 universal build 相關的
configure 與建置選項。請參閱
`Mac/README.rst <https://github.com/python/cpython/blob/main/Mac/README.rst>`_。

在 Windows 上，請參閱
`PCbuild/readme.txt <https://github.com/python/cpython/blob/main/PCbuild/readme.txt>`_。

要建置 Windows 安裝程式，請參閱
`Tools/msi/README.txt <https://github.com/python/cpython/blob/main/Tools/msi/README.txt>`_。

如果你願意，可以建立一個子目錄並從該處執行 configure。例如::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

（如果你 *也* 在最上層目錄建置過，這將會失敗。請先在最上層執行
``make clean``。）

若要取得最佳化的 Python 建置，請在執行 ``make`` 前使用
``configure --enable-optimizations``。這會將預設 make 目標設為
啟用 Profile Guided Optimization (PGO)，並可能在某些平台自動啟用
Link Time Optimization (LTO)。詳情請參見下方章節。

Profile Guided Optimization
^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO 利用最新版本的 GCC 或 Clang 編譯器。如果你使用
``configure --enable-optimizations`` 或不論 configure 旗標
手動執行 ``make profile-opt``，最佳化建置流程會執行以下步驟：

整個 Python 目錄會清除先前編譯產生的暫存檔案。

接著會建置帶有適當編譯器旗標的儀器化直譯器版本。請注意，這僅為
中介步驟，此階段產生的二進位檔不適合實際運行，因為其內嵌了
分析指令。

儀器化直譯器建置完成後，Makefile 會執行訓練工作負載。這是為了
分析直譯器執行時的行為。請注意，這一步產生的所有輸出（stdout
及 stderr）都會被抑制。

最後一步是根據前述蒐集的資訊，建置真正的直譯器。最終會得到經過
最佳化的 Python 二進位檔，適合發佈或正式安裝。

Link Time Optimization
^^^^^^^^^^^^^^^^^^^^^^

可透過 configure 的 ``--with-lto`` 旗標啟用。LTO 利用最新
編譯器工具鏈在建置最終可執行檔或共享函式庫時，跨越 ``.o`` 檔案
邊界進行優化，以獲得額外效能提升。

新功能
----------

我們在 `What's new in Python 3.15 <https://docs.python.org/3.15/whatsnew/3.15.html>`_
文件中提供了全面的變更概述。欲知更詳細的變更紀錄，請參閱
`Misc/NEWS <https://github.com/python/cpython/tree/main/Misc/NEWS.d>`_，
但完整的變更只可從
`commit history <https://github.com/python/cpython/commits/main>`_
得知。

如果你想安裝多個版本的 Python，請參見下方「安裝多個版本」章節。

文件
-------------

`Python 3.15 文件 <https://docs.python.org/3.15/>`_ 提供線上每日更新。

你也可以下載多種格式以加快查閱速度。文件可下載 HTML、PDF 及
reStructuredText 格式；後者主要給文件作者、翻譯者及有特殊格式
需求者使用。

有關建置 Python 文件的資訊，請參閱
`Doc/README.rst <https://github.com/python/cpython/blob/main/Doc/README.rst>`_。

測試
-------

要測試直譯器，請在最上層目錄輸入 ``make test``。測試集會產生
部分輸出。你通常可以忽略因無法匯入選用功能而跳過的測試訊息。
若出現測試失敗訊息、追蹤訊息或產生 core dump，則表示有問題。

預設情況下，測試會防止過度使用磁碟空間和記憶體等資源。若要啟用
這些測試，請執行 ``make buildbottest``。

如果有測試失敗，可以以詳細模式重新執行失敗的測試。例如，
若 ``test_os`` 和 ``test_gdb`` 失敗，你可以執行::

    make test TESTOPTS="-v test_os test_gdb"

若失敗持續且似乎為 Python 本身的問題，而非你的環境問題，
你可以 `回報錯誤 <https://github.com/python/cpython/issues>`_，
並附上該指令的相關輸出以說明問題。

關於測試的更多資訊，請參閱
`Running & Writing Tests <https://devguide.python.org/testing/run-write-tests.html>`_。

安裝多個版本
----------------------------

在 Unix 和 Mac 系統上，若你打算使用相同的安裝前綴
（configure 腳本的 ``--prefix`` 參數）安裝多個 Python 版本，
必須小心不要讓主要的 python 執行檔被其他版本覆蓋。
使用 ``make altinstall`` 安裝的所有檔案和目錄都包含主次版本號，
因此可以並存。``make install`` 也會建立
``${prefix}/bin/python3``，指向 ``${prefix}/bin/python3.X``。
如果你打算以相同前綴安裝多個版本，必須決定哪個版本（如果有）
是你的「主要」版本。將該版本使用
``make install``。使用 ``make altinstall`` 安裝所有其他版本。

例如，如果你想安裝 Python 2.7、3.6 和 3.15，並且以 3.15 為主要版本，你應該在 3.15 的建置目錄中執行 ``make install``，而在其他版本的目錄中執行 ``make altinstall``。


發行時程表
----------

請參閱 `PEP 790 <https://peps.python.org/pep-0790/>`__ 以取得 Python 3.15 發行細節。


版權與授權資訊
--------------

Copyright © 2001 Python Software Foundation.  All rights reserved.

Copyright © 2000 BeOpen.com.  All rights reserved.

Copyright © 1995-2001 Corporation for National Research Initiatives.  All rights reserved.

Copyright © 1991-1995 Stichting Mathematisch Centrum.  All rights reserved.

請參閱 `LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_ 以瞭解本軟體的歷史、使用條款與條件，以及所有保證的免責聲明。

此 Python 發行版 *不含* 任何 GNU 通用公共授權（GPL）代碼，因此可用於專有專案。與部分 GNU 代碼有介面，但這些完全是可選的。

本文所提及之所有商標均為其各自持有者的財產。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---