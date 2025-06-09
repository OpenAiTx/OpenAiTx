これは Python バージョン 3.15.0 アルファ 0 です
======================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: GitHub Actions 上の CPython ビルドステータス
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: Azure DevOps 上の CPython ビルドステータス
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Python Discourse チャット
   :target: https://discuss.python.org/


著作権 © 2001 Python Software Foundation.  All rights reserved.

さらなる著作権およびライセンス情報については、このファイルの末尾をご覧ください。

.. contents::

一般情報
-------------------

- ウェブサイト: https://www.python.org
- ソースコード: https://github.com/python/cpython
- イシュートラッカー: https://github.com/python/cpython/issues
- ドキュメント: https://docs.python.org
- 開発者ガイド: https://devguide.python.org/

CPython への貢献
-----------------------

CPython 開発への貢献に関するより詳しい手順については、
`開発者ガイド`_ を参照してください。

.. _開発者ガイド: https://devguide.python.org/

Python の使用
------------

インストール可能な Python キットや、Python の利用方法に関する情報は
`python.org`_ で入手できます。

.. _python.org: https://www.python.org/

ビルド手順
------------------

Unix、Linux、BSD、macOS、Cygwin での手順::

    ./configure
    make
    make test
    sudo make install

これにより Python は ``python3`` としてインストールされます。

多くのオプションを configure スクリプトに渡すことができます。詳細は ``./configure --help``
を実行してください。macOS の大文字小文字を区別しないファイルシステムや Cygwin では
実行ファイルは ``python.exe`` という名前になります。それ以外では単に ``python`` です。

完全な Python インストールを構築するには、ビルドプラットフォームや
configure オプションに応じてさまざまな追加のサードパーティライブラリが必要です。
すべての標準ライブラリモジュールがすべてのプラットフォームでビルド・利用できるとは限りません。
さまざまな Linux ディストリビューションや macOS の依存関係の最新情報については、
`開発者ガイド`_ の
`依存関係のインストール <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
セクションを参照してください。

macOS では、macOS フレームワークおよびユニバーサルビルドに関連した追加の
configure・ビルドオプションがあります。`Mac/README.rst
<https://raw.githubusercontent.com/python/cpython/main/Mac/README.rst>`_ を参照してください。

Windows については `PCbuild/readme.txt
<https://raw.githubusercontent.com/python/cpython/main/PCbuild/readme.txt>`_ を参照してください。

Windows インストーラーのビルドについては `Tools/msi/README.txt
<https://raw.githubusercontent.com/python/cpython/main/Tools/msi/README.txt>`_ を参照してください。

必要であればサブディレクトリを作成し、そこから configure を実行できます。
例::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

（これは *同時に* トップレベルディレクトリでビルドした場合は失敗します。最初にトップレベルで ``make clean`` を実行してください。）

Python の最適化ビルドを得るには、``configure --enable-optimizations``
を ``make`` 実行前に指定してください。これによりデフォルトの make ターゲットが
プロファイルガイド最適化（PGO）を有効に設定し、一部のプラットフォームでは
リンク時最適化（LTO）も自動的に有効化される場合があります。詳細は以下のセクションを参照してください。

プロファイルガイド最適化
^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO は最近の GCC や Clang コンパイラーの機能を利用します。``configure --enable-optimizations`` を使用するか、configure フラグに関わらず手動で ``make profile-opt`` を実行した場合、最適化ビルドプロセスは以下の手順を実行します:

Python ディレクトリ全体から、以前のコンパイルによって生成された一時ファイルを削除します。

インタープリターの計測バージョンが、それぞれのビルド用コンパイラフラグを用いてビルドされます。これは中間ステップに過ぎません。この段階でできたバイナリはプロファイリング命令が埋め込まれているため、実際の運用には適しません。

計測済みインタープリターがビルドされた後、Makefile はトレーニングワークロードを実行します。これはインタープリターの実行をプロファイルするために必要です。また、このステップで発生する stdout や stderr の出力はすべて抑制されます。

最後のステップとして、計測済みバイナリから収集された情報を元に、実際のインタープリターをビルドします。最終的に得られる Python バイナリは最適化されており、配布や本番環境へのインストールに適しています。

リンク時最適化
^^^^^^^^^^^^^^^^^^^^^^

configure の ``--with-lto`` フラグで有効化されます。LTO は、最近のコンパイラツールチェーンが
最終的な実行ファイルや共有ライブラリをビルドする際、従来は任意であった ``.o`` ファイルの境界を越えて
最適化を行う機能を利用し、さらなるパフォーマンス向上を実現します。

新機能情報
----------

`Python 3.15 の新機能 <https://docs.python.org/3.15/whatsnew/3.15.html>`_ という文書で、変更点の包括的な概要を提供しています。より詳細な変更ログは `Misc/NEWS
<https://raw.githubusercontent.com/python/cpython/main/Misc/NEWS.d>`_ をご覧ください。ただし、全ての変更点を完全に把握するには `コミット履歴
<https://github.com/python/cpython/commits/main>`_ を参照する必要があります。

複数バージョンの Python をインストールしたい場合は、下記「複数バージョンのインストール」セクションをご覧ください。

ドキュメント
-------------

`Python 3.15 のドキュメント <https://docs.python.org/3.15/>`_ はオンラインで提供され、毎日更新されています。

高速なアクセスのため、様々な形式でダウンロードすることも可能です。ドキュメントは HTML、PDF、reStructuredText 形式でダウンロードできます。reStructuredText 版は主にドキュメント作成者、翻訳者、特別な書式要件のある方向けです。

Python ドキュメントのビルドに関する情報は `Doc/README.rst
<https://raw.githubusercontent.com/python/cpython/main/Doc/README.rst>`_ を参照してください。

テスト
-------

インタープリターをテストするには、トップレベルディレクトリで ``make test`` と入力してください。
テストセットはいくつかの出力を生成します。インポートできないオプション機能によるスキップテストのメッセージは、通常無視できます。失敗したテストやトレースバック、コアダンプが発生した場合は、何か問題があります。

デフォルトでは、テストによるディスク容量やメモリの過剰使用が抑制されています。これらのテストを有効にするには、``make buildbottest`` を実行してください。

テストが失敗した場合は、失敗したテストを詳細モードで再実行できます。たとえば、``test_os`` と ``test_gdb`` が失敗した場合は、次のように実行します::

    make test TESTOPTS="-v test_os test_gdb"

問題が継続し、環境ではなく Python 側の問題と思われる場合は、`バグ報告
<https://github.com/python/cpython/issues>`_ を行い、そのコマンドの関連出力を添付して問題を示してください。

テストの実行方法については `テストの実行と作成 <https://devguide.python.org/testing/run-write-tests.html>`_
を参照してください。

複数バージョンのインストール
----------------------------

Unix や Mac システムで、同じインストールプレフィックス（configure スクリプトの ``--prefix`` 引数）を使って複数バージョンの Python をインストールする場合は、
主要な python 実行ファイルが他のバージョンのインストールによって上書きされないよう注意してください。
``make altinstall`` でインストールされるすべてのファイルやディレクトリにはメジャー・マイナーバージョンが含まれており、共存できます。``make install`` は ``${prefix}/bin/python3`` も作成し、これは ``${prefix}/bin/python3.X`` を指します。同じプレフィックスで複数バージョンをインストールする場合は、どのバージョン（もしあれば）を「主要」バージョンにするか決めてください。そのバージョンを
``make install``。他のすべてのバージョンは ``make altinstall`` を使用してインストールしてください。

例えば、Python 2.7、3.6、3.15 をインストールし、3.15 を主要なバージョンとしたい場合は、3.15 のビルドディレクトリで ``make install`` を実行し、その他のバージョンでは ``make altinstall`` を実行します。


リリーススケジュール
----------------

Python 3.15 のリリース詳細については `PEP 790 <https://peps.python.org/pep-0790/>`__ を参照してください。


著作権およびライセンス情報
--------------------------

Copyright © 2001 Python Software Foundation. All rights reserved.

Copyright © 2000 BeOpen.com. All rights reserved.

Copyright © 1995-2001 Corporation for National Research Initiatives. All rights reserved.

Copyright © 1991-1995 Stichting Mathematisch Centrum. All rights reserved.

このソフトウェアの歴史、利用条件、および
すべての保証の免責事項については、`LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_ をご覧ください。

この Python ディストリビューションには *GNU General Public License (GPL)* コードは一切含まれていませんので、商用プロジェクトで使用することができます。一部 GNU コードへのインターフェースがありますが、これらは完全にオプションです。

本書に記載されているすべての商標は、それぞれの所有者の財産です。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---