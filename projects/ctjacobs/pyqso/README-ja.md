    Copyright (C) 2013-2018 Christian Thomas Jacobs.

    このファイルは PyQSO の一部です。

    PyQSO はフリーソフトウェアです。あなたはこれを再配布および/または修正することができます
    フリーソフトウェア財団によって公開された GNU 一般公衆利用許諾契約書の条項の下で、
    バージョン3、または（あなたの選択で）それ以降のバージョンに従います。

    PyQSO は有用であることを願って配布されていますが、
    商品性や特定目的への適合性の黙示的保証を含むいかなる保証もありません。詳細は
    GNU 一般公衆利用許諾契約書をご覧ください。

    あなたは PyQSO と一緒に GNU 一般公衆利用許諾契約書のコピーを受け取っているはずです。
    受け取っていない場合は <http://www.gnu.org/licenses/> をご覧ください。

# PyQSO

PyQSO はアマチュア無線家向けの交信ログツールです。

[![Documentation Status](https://readthedocs.org/projects/pyqso/badge/?version=latest)](https://readthedocs.org/projects/pyqso/?badge=latest)

## 依存関係

名前が示す通り、PyQSO は主に [Python](https://www.python.org/) プログラミング言語（バージョン3.x）で書かれています。  
グラフィカルユーザーインターフェイスは [GTK+ ライブラリ](https://www.gtk.org/) を [PyGObject バインディング](https://pygobject.readthedocs.io) 経由で開発しています。  
したがって、PyQSO を実行するにはシステムに Python インタプリタと GTK+ のサポートが必要です。  
多くの Linux ベースのシステムでは、以下の Debian パッケージをインストールすることでこれを達成できます：

* python3
* gir1.2-gtk-3.0
* python3-gi-cairo

PyQSO の全機能を有効にするにはいくつかの追加パッケージが必要です。  
これらの多くは（`requirements.txt` ファイルに指定されている）Python パッケージマネージャを使ってシステム全体に簡単にインストールできます。  
ターミナルで以下のコマンドを実行してください：

    sudo pip3 install -U -r requirements.txt

しかし、完全なリストは以下の通りです：

* python3-matplotlib（バージョン1.3.0以上）
* python3-numpy
* libxcb-render0-dev
* [cartopy](http://scitools.org.uk/cartopy/)、世界地図を描画するためのパッケージです。このパッケージは python3-scipy、python3-cairocffi、cython、libproj-dev（バージョン4.9.0以降）、および libgeos-dev（バージョン3.3.3以降）に依存しています。
* [geocoder](https://pypi.python.org/pypi/geocoder)、QTH検索用。
* python3-sphinx、ドキュメント作成用。
* python3-hamlib、Hamlibサポート用。

### Hamlib サポート

現在、[Hamlib](http://www.hamlib.org) のPython 3対応Debianパッケージは存在しません。Hamlibサポートを有効にするには、このライブラリを手動でビルドする必要があります。[Hamlibメーリングリスト](https://sourceforge.net/p/hamlib/mailman/message/35692744/)の指示に従い、Hamlibのルートディレクトリで以下のコマンドを実行してください（事前に `sudo apt-get install build-essential autoconf automake libtool` を実行する必要があるかもしれません）：

    export PYTHON=/usr/bin/python3
    autoreconf --install
    ./configure --with-python-binding
    make
    sudo make install

さらに、Hamlibの `bindings` と `bindings/.libs` ディレクトリを `PYTHONPATH` に追加する必要があります：

    export PYTHONPATH=$PYTHONPATH:/path/to/hamlib/bindings:/path/to/hamlib/bindings/.libs

## インストールと実行

現在の作業ディレクトリが PyQSO のベースディレクトリ（`Makefile` があるディレクトリ）であると仮定すると、以下のコマンドをターミナルで実行することでインストールなしに PyQSO を起動できます：

    python3 bin/pyqso

システムに Python パッケージマネージャー `pip3` が利用可能な場合、以下のコマンドで PyQSO をシステム全体にインストールできます：

    sudo make install

インストール後は、以下のコマンドで PyQSO を起動できます：

    pyqso

## ドキュメント

PyQSO の使い方については、[Read the Docs](http://pyqso.readthedocs.io/) と下記のスクリーンキャストで案内しています。

[![PyQSO: アマチュア無線オペレーター向けのログツール](https://img.youtube.com/vi/sVdZl9KnDsk/0.jpg)](https://www.youtube.com/watch?v=sVdZl9KnDsk)

ドキュメントは以下のコマンドでローカルにビルドすることもできます：

    make docs

これは、`docs/build/html` にHTML形式のドキュメントを生成し、ウェブブラウザで開くことができます。

## お問い合わせ

PyQSOに関する技術的な問題や機能の提案は、GitHubのイシュートラッカーでご報告ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-13

---