<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>FastAPI フレームワーク、高速、高性能、学びやすく、素早くコーディングでき、プロダクション準備万端</em>
</p>
<p align="center">
<a href="https://github.com/fastapi/fastapi/actions?query=workflow%3ATest+event%3Apush+branch%3Amaster" target="_blank">
    <img src="https://github.com/fastapi/fastapi/actions/workflows/test.yml/badge.svg?event=push&branch=master" alt="Test">
</a>
<a href="https://coverage-badge.samuelcolvin.workers.dev/redirect/fastapi/fastapi" target="_blank">
    <img src="https://coverage-badge.samuelcolvin.workers.dev/fastapi/fastapi.svg" alt="Coverage">
</a>
<a href="https://pypi.org/project/fastapi" target="_blank">
    <img src="https://img.shields.io/pypi/v/fastapi?color=%2334D058&label=pypi%20package" alt="Package version">
</a>
<a href="https://pypi.org/project/fastapi" target="_blank">
    <img src="https://img.shields.io/pypi/pyversions/fastapi.svg?color=%2334D058" alt="Supported Python versions">
</a>
</p>

---

**ドキュメント**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**ソースコード**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI は、標準の Python 型ヒントに基づき、API を構築するためのモダンで高速（高性能）な Python 製ウェブフレームワークです。

主な特徴は次の通りです：

* **高速**: 非常に高いパフォーマンス。**NodeJS** や **Go** と同等（Starlette と Pydantic のおかげ）。[利用可能な Python フレームワークの中で最速クラス](#performance)。
* **素早くコーディング**: 機能開発の速度を約 200%～300% 向上。 *
* **バグが少ない**: 人為的（開発者による）エラーを約 40% 削減。 *
* **直感的**: 優れたエディターサポート。<abbr title="auto-complete, autocompletion, IntelliSense とも呼ばれる">補完</abbr>がどこでも使え、デバッグの時間が減少。
* **簡単**: 使いやすく学びやすい設計。ドキュメントを読む時間が短縮。
* **短い**: コードの重複を最小化。各パラメータ宣言から複数の機能。バグも減少。
* **堅牢**: プロダクションレディのコードが得られる。自動のインタラクティブドキュメント付き。
* **標準ベース**: API のオープンスタンダードである <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a>（以前は Swagger）や <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>に基づき、完全互換。

<small>* 社内開発チームでのテストとプロダクションアプリケーション構築による推定値。</small>

## スポンサー

<!-- sponsors -->

<a href="https://blockbee.io?ref=fastapi" target="_blank" title="BlockBee Cryptocurrency Payment Gateway"><img src="https://fastapi.tiangolo.com/img/sponsors/blockbee.png"></a>
<a href="https://platform.sh/try-it-now/?utm_source=fastapi-signup&utm_medium=banner&utm_campaign=FastAPI-signup-June-2023" target="_blank" title="Build, run and scale your apps on a modern, reliable, and secure PaaS."><img src="https://fastapi.tiangolo.com/img/sponsors/platform-sh.png"></a>
<a href="https://www.porter.run" target="_blank" title="Deploy FastAPI on AWS with a few clicks"><img src="https://fastapi.tiangolo.com/img/sponsors/porter.png"></a>
<a href="https://github.com/scalar/scalar/?utm_source=fastapi&utm_medium=website&utm_campaign=main-badge" target="_blank" title="Scalar: Beautiful Open-Source API References from Swagger/OpenAPI files"><img src="https://fastapi.tiangolo.com/img/sponsors/scalar.svg"></a>
<a href="https://www.propelauth.com/?utm_source=fastapi&utm_campaign=1223&utm_medium=mainbadge" target="_blank" title="Auth, user management and more for your B2B product"><img src="https://fastapi.tiangolo.com/img/sponsors/propelauth.png"></a>
<a href="https://zuplo.link/fastapi-gh" target="_blank" title="Zuplo: Deploy, Secure, Document, and Monetize your FastAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/zuplo.png"></a>
<a href="https://liblab.com?utm_source=fastapi" target="_blank" title="liblab - Generate SDKs from FastAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/liblab.png"></a>
<a href="https://docs.render.com/deploy-fastapi?utm_source=deploydoc&utm_medium=referral&utm_campaign=fastapi" target="_blank" title="Deploy & scale any full-stack web app on Render. Focus on building apps, not infra."><img src="https://fastapi.tiangolo.com/img/sponsors/render.svg"></a>
<a href="https://www.coderabbit.ai/?utm_source=fastapi&utm_medium=badge&utm_campaign=fastapi" target="_blank" title="Cut Code Review Time & Bugs in Half with CodeRabbit"><img src="https://fastapi.tiangolo.com/img/sponsors/coderabbit.png"></a>
<a href="https://subtotal.com/?utm_source=fastapi&utm_medium=sponsorship&utm_campaign=open-source" target="_blank" title="The Gold Standard in Retail Account Linking"><img src="https://fastapi.tiangolo.com/img/sponsors/subtotal.svg"></a>
<a href="https://databento.com/" target="_blank" title="Pay as you go for market data"><img src="https://fastapi.tiangolo.com/img/sponsors/databento.svg"></a>
<a href="https://speakeasy.com?utm_source=fastapi+repo&utm_medium=github+sponsorship" target="_blank" title="SDKs for your API | Speakeasy"><img src="https://fastapi.tiangolo.com/img/sponsors/speakeasy.png"></a>
<a href="https://www.svix.com/" target="_blank" title="Svix - Webhooks as a service"><img src="https://fastapi.tiangolo.com/img/sponsors/svix.svg"></a>
<a href="https://www.stainlessapi.com/?utm_source=fastapi&utm_medium=referral" target="_blank" title="Stainless | Generate best-in-class SDKs"><img src="https://fastapi.tiangolo.com/img/sponsors/stainless.png"></a>
<a href="https://www.permit.io/blog/implement-authorization-in-fastapi?utm_source=github&utm_medium=referral&utm_campaign=fastapi" target="_blank" title="Fine-Grained Authorization for FastAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/permit.png"></a>
<a href="https://www.interviewpal.com/?utm_source=fastapi&utm_medium=open-source&utm_campaign=dev-hiring" target="_blank" title="InterviewPal - AI Interview Coach for Engineers and Devs"><img src="https://fastapi.tiangolo.com/img/sponsors/interviewpal.png"></a>
<a href="https://dribia.com/en/" target="_blank" title="Dribia - Data Science within your reach"><img src="https://fastapi.tiangolo.com/img/sponsors/dribia.png"></a>

<!-- /sponsors -->

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">他のスポンサー</a>

## 意見

"_[...] 最近 **FastAPI** をかなり使っています。[...] 実際、チームの **Microsoft の ML サービス** すべてに使う予定です。その一部はコアの **Windows** 製品や一部の **Office** 製品に統合されつつあります._"

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(ref)</small></a></div>

---

"_**FastAPI** ライブラリを採用して、**REST** サーバーを立ち上げ、**予測**の取得ができるようにしました。[for Ludwig]_"

<div style="text-align: right; margin-right: 10%;">Piero Molino, Yaroslav Dudin, and Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(ref)</small></a></div>

---

"_**Netflix** は、危機管理オーケストレーションフレームワーク **Dispatch** のオープンソースリリースを発表できてうれしいです！[**FastAPI** で構築]_"

<div style="text-align: right; margin-right: 10%;">Kevin Glisson, Marc Vilanova, Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(ref)</small></a></div>

---

"_**FastAPI** にとてもワクワクしています。とても楽しい！_"

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">Python Bytes</a> ポッドキャストホスト</strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(ref)</small></a></div>

---

"_正直なところ、あなたが作ったものは非常に堅実で洗練されています。多くの点で私が **Hug** に求めていたものです ― それが誰かに実現されているのを見るのは本当に刺激的です。_"

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">Hug</a> の作者</strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(ref)</small></a></div>

---

"_REST API を構築するための **モダンなフレームワーク** を学びたいなら、**FastAPI** をチェックしてみてください [...] 速くて、使いやすく、学びやすいです [...]_"

"_私たちの **API** は **FastAPI** に切り替えました [...] きっと気に入ると思います [...]_"

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">Explosion AI</a> 創業者 - <a href="https://spacy.io" target="_blank">spaCy</a> 開発者</strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(ref)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(ref)</small></a></div>

---

"_プロダクション用の Python API を構築しようとしているなら、**FastAPI** を強くおすすめします。**美しい設計**、**使いやすさ**、**高いスケーラビリティ**、API ファースト開発戦略の重要なコンポーネントとなり、多くの自動化やサービス（バーチャル TAC エンジニアなど）を支えています。_"

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(ref)</small></a></div>

---

## **Typer** ― CLI のための FastAPI

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

もしウェブ API ではなく、ターミナルで利用する <abbr title="コマンドラインインターフェース">CLI</abbr> アプリを作るなら、<a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a> をチェックしてください。

**Typer** は FastAPI の弟分です。**CLI のための FastAPI** を目指しています。⌨️ 🚀

## 要件

FastAPI は巨人の肩の上に立っています：

* ウェブ部分は <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a>。
* データ部分は <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a>。

## インストール

<a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">仮想環境</a>を作成・有効化した後、FastAPI をインストールします：

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**注意**: すべてのターミナルで動作させるために `"fastapi[standard]"` を引用符で囲んでください。

## 例

### 作成

`main.py` というファイルを作成し、次の内容にします：

```Python
from typing import Union

from fastapi import FastAPI

app = FastAPI()


@app.get("/")
def read_root():
    return {"Hello": "World"}


@app.get("/items/{item_id}")
def read_item(item_id: int, q: Union[str, None] = None):
    return {"item_id": item_id, "q": q}
```

<details markdown="1">
<summary><code>async def</code> を使う場合...</summary>

コードで `async` / `await` を使う場合は `async def` を使います：

```Python hl_lines="9  14"
from typing import Union

from fastapi import FastAPI

app = FastAPI()


@app.get("/")
async def read_root():
    return {"Hello": "World"}


@app.get("/items/{item_id}")
async def read_item(item_id: int, q: Union[str, None] = None):
    return {"item_id": item_id, "q": q}
```

**注意**:

よく分からない場合は、ドキュメントの <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` と `await` に関する「急いでいますか？」セクション</a> を参照してください。

</details>

### 実行

サーバーを次のコマンドで起動します：

<div class="termy">

```console
$ fastapi dev main.py

 ╭────────── FastAPI CLI - Development mode ───────────╮
 │                                                     │
 │  Serving at: http://127.0.0.1:8000                  │
 │                                                     │
 │  API docs: http://127.0.0.1:8000/docs               │
 │                                                     │
 │  Running in development mode, for production use:   │
 │                                                     │
 │  fastapi run                                        │
 │                                                     │
 ╰─────────────────────────────────────────────────────╯

INFO:     Will watch for changes in these directories: ['/home/user/code/awesomeapp']
INFO:     Uvicorn running on http://127.0.0.1:8000 (Press CTRL+C to quit)
INFO:     Started reloader process [2248755] using WatchFiles
INFO:     Started server process [2248757]
INFO:     Waiting for application startup.
INFO:     Application startup complete.
```

</div>

<details markdown="1">
<summary>コマンド <code>fastapi dev main.py</code> について...</summary>

`fastapi dev` コマンドは `main.py` ファイルを読み込み、その中の **FastAPI** アプリを検出して、<a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a> を使ってサーバーを起動します。

デフォルトでは `fastapi dev` はローカル開発用に自動リロードを有効にして起動します。

詳細は <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">FastAPI CLI ドキュメント</a> をご覧ください。

</details>

### 確認

ブラウザで <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a> を開いてください。

次のような JSON レスポンスが表示されます：

```JSON
{"item_id": 5, "q": "somequery"}
```

この時点で、次のような API を作成しています：

* _パス_ `/` および `/items/{item_id}` で HTTP リクエストを受け付けます。
* 両方の _パス_ は `GET` <em>オペレーション</em>（HTTP _メソッド_ とも呼ばれる）を受け付けます。
* _パス_ `/items/{item_id}` には `item_id` という _パスパラメータ_ があり、`int` 型である必要があります。
* _パス_ `/items/{item_id}` にはオプションの `str` 型 _クエリパラメータ_ `q` があります。

### インタラクティブ API ドキュメント

今度は <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a> にアクセスしてください。

自動生成されたインタラクティブな API ドキュメント（<a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a> 提供）が表示されます：

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### 代替 API ドキュメント

さらに <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a> にアクセスしてください。

こちらでは別の自動ドキュメント（<a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a> 提供）が表示されます：

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## 例のアップグレード

`main.py` を変更して、`PUT` リクエストでボディを受け取れるようにしましょう。

ボディは Pydantic により、標準の Python 型で宣言できます。

```Python hl_lines="4  9-12  25-27"
from typing import Union

from fastapi import FastAPI
from pydantic import BaseModel

app = FastAPI()


class Item(BaseModel):
    name: str
    price: float
    is_offer: Union[bool, None] = None


@app.get("/")
def read_root():
    return {"Hello": "World"}


@app.get("/items/{item_id}")
def read_item(item_id: int, q: Union[str, None] = None):
    return {"item_id": item_id, "q": q}


@app.put("/items/{item_id}")
def update_item(item_id: int, item: Item):
    return {"item_name": item.name, "item_id": item_id}
```

`fastapi dev` サーバーは自動的にリロードされます。

### インタラクティブ API ドキュメントのアップグレード

<a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a> にアクセスしてください。

* インタラクティブ API ドキュメントが自動的に更新され、新しいボディが反映されています：

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* 「Try it out」ボタンをクリックすると、パラメータを入力して API と直接やり取りできます：

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* 続いて「Execute」ボタンをクリックすると、UI が API と通信し、パラメータを送信し、結果を画面に表示します：

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### 代替 API ドキュメントのアップグレード

<a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a> でも確認してください。

* 代替ドキュメントも新しいクエリパラメータやボディに対応しています：

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### まとめ

要するに、各種パラメータやボディなどの型を関数のパラメータとして**一度だけ**宣言します。

これを標準的なモダン Python の型で行います。

新たな構文や特定ライブラリのメソッド・クラスなどを学ぶ必要はありません。

ただの標準 **Python** です。

例えば、`int` 型の場合：

```Python
item_id: int
```

より複雑な `Item` モデルの場合：

```Python
item: Item
```

...この一つの宣言で、次のような利点を得られます：

* エディターサポート：
    * 補完
    * 型チェック
* データのバリデーション：
    * データが無効な場合、自動で分かりやすいエラー
    * 深くネストした JSON オブジェクトにも対応
* 入力データの <abbr title="シリアライズ、パース、マーシャリングとも呼ばれる">変換</abbr>：ネットワークから Python のデータ・型へ。対象：
    * JSON
    * パスパラメータ
    * クエリパラメータ
    * クッキー
    * ヘッダー
    * フォーム
    * ファイル
* 出力データの <abbr title="シリアライズ、パース、マーシャリングとも呼ばれる">変換</abbr>：Python のデータ・型からネットワークデータ（JSON）へ：
    * Python の型（`str`, `int`, `float`, `bool`, `list` など）
    * `datetime` オブジェクト
    * `UUID` オブジェクト
    * データベースモデル
    * ...他多数
* 2 種類の自動インタラクティブ API ドキュメント：
    * Swagger UI
    * ReDoc

---

前述のコード例に戻ると、**FastAPI** は次のことを行います：

* `GET` および `PUT` リクエストでパスに `item_id` が存在することを検証
* `GET` および `PUT` リクエストで `item_id` が `int` 型であることを検証
    * そうでない場合、クライアントは分かりやすいエラーを見ることができます
* `GET` リクエストで、オプションのクエリパラメータ `q`（例：`http://127.0.0.1:8000/items/foo?q=somequery`）が存在するかを確認
    * `q` パラメータに `= None` があるためオプションです
    * `None` がなければ必須（`PUT` のボディのように）になります
* `/items/{item_id}` への `PUT` リクエストでは、ボディを JSON として読み取る：
    * 必須属性 `name`（`str` 型）があるか確認
    * 必須属性 `price`（`float` 型）があるか確認
    * オプション属性 `is_offer`（`bool` 型）があれば確認
    * これらは深くネストした JSON オブジェクトでも機能します
* JSON との相互変換は自動
* すべてを OpenAPI でドキュメント化し、次の用途に使える：
    * インタラクティブドキュメントシステム
    * 多言語対応の自動クライアントコード生成システム
* 2 種類のインタラクティブなドキュメントウェブインターフェースを直接提供

---

ここでは表面をなぞっただけですが、全体の仕組みのイメージはつかめたはずです。

次の行を変更してみてください：

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...のうち：

```Python
        ... "item_name": item.name ...
```

...を：

```Python
        ... "item_price": item.price ...
```

...と変えてみると、エディターが属性を自動補完し、その型も認識してくれる様子が分かります：

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

より多機能な例については、<a href="https://fastapi.tiangolo.com/tutorial/">チュートリアル - ユーザーガイド</a> を参照してください。

**ネタバレ注意**: チュートリアル・ユーザーガイドでは次の内容も扱っています：

* **ヘッダー**、**クッキー**、**フォームフィールド**、**ファイル**など他の場所からの**パラメータ宣言**
* `maximum_length` や `regex` などの **バリデーション制約** の設定方法
* 非常に強力かつ使いやすい **<abbr title="コンポーネント、リソース、プロバイダ、サービス、インジェクタブルとも呼ばれる">依存性注入</abbr>** システム
* **OAuth2**（**JWT トークン**）、**HTTP Basic** 認証を含むセキュリティと認証
* **深くネストした JSON モデル** の宣言方法（Pydantic の恩恵）
* <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> などを使った **GraphQL** 連携
* Starlette の恩恵による多くの追加機能：
    * **WebSocket**
    * HTTPX や `pytest` ベースの非常に簡単なテスト
    * **CORS**
    * **Cookie セッション**
    * ...など

## パフォーマンス

独立系 TechEmpower ベンチマークにより、**FastAPI** アプリケーションは Uvicorn 上で <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">利用可能な Python フレームワークの中でも最速クラス</a> であることが示されています（FastAPI 内部で利用されている Starlette や Uvicorn の直下）。

詳しくは <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">ベンチマーク</a> セクションを参照してください。

## 依存関係

FastAPI は Pydantic と Starlette に依存しています。

### `standard` 依存関係

`pip install "fastapi[standard]"` で FastAPI をインストールすると、`standard` グループのオプション依存関係も含まれます：

Pydantic で使用：

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - メールアドレスのバリデーション用

Starlette で使用：

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - `TestClient` を使う場合に必要
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - デフォルトのテンプレート設定を使う場合に必要
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - フォーム <abbr title="HTTP リクエストの文字列を Python データに変換">"パース"</abbr>対応（`request.form()`）に必要

FastAPI / Starlette で使用：

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - アプリケーションをロード・配信するサーバー用。`uvicorn[standard]` も含まれ、高性能配信に必要な依存（例：`uvloop`）を含みます。
* `fastapi-cli` - `fastapi` コマンド提供用

### `standard` なしのインストール

`standard` オプション依存関係を含めたくない場合は、`pip install "fastapi[standard]"` ではなく `pip install fastapi` でインストールしてください。

### 追加オプション依存関係

必要に応じて追加でインストールできる依存もあります。

Pydantic 用の追加オプション依存：

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - 設定管理用
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - Pydantic で使用可能な追加型

FastAPI 用の追加オプション依存：

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - `ORJSONResponse` を使う場合に必要
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - `UJSONResponse` を使う場合に必要

## ライセンス

本プロジェクトは MIT ライセンスの条件で提供されています。


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---