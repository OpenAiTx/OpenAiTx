<p align="center">
  <a href="https://pmdevita.github.io/django-shinobi/"><img src="https://pmdevita.github.io/django-shinobi/img/logo-big.png"></a>
</p>
<p align="center">
    <em>学びやすく、コードを書きやすく、実行も速い</em>
</p>


![Test](https://github.com/pmdevita/django-shinobi/actions/workflows/test_full.yml/badge.svg)
![Coverage](https://img.shields.io/codecov/c/github/pmdevita/django-shinobi)
[![PyPI version](https://badge.fury.io/py/django-shinobi.svg)](https://badge.fury.io/py/django-shinobi)
[![Downloads](https://static.pepy.tech/personalized-badge/django-shinobi?period=month&units=international_system&left_color=black&right_color=brightgreen&left_text=downloads/month)](https://pepy.tech/project/django-shinobi)
[![Discord](https://dcbadge.limes.pink/api/server/ntFTXu7NNv?style=flat-square)](https://discord.gg/ntFTXu7NNv)

# Django Shinobi - 高速な Django REST フレームワーク

[ドキュメント](https://pmdevita.github.io/django-shinobi)

**Django Shinobi** は、**Django** と Python 3.6+ の **型ヒント** を使って API を構築するためのウェブフレームワークです。

これは素晴らしい **[Django Ninja](https://github.com/vitalik/django-ninja)** ライブラリのフォークで、
コミュニティが望む機能と修正に焦点を当てています。Ninja から移行する場合は、[違いのリスト](https://pmdevita.github.io/django-shinobi/differences/) や [ロードマップ](https://github.com/pmdevita/django-shinobi/discussions/6) をご覧ください！


 **主な特徴:**

  - **簡単**: 使いやすく直感的に設計されています。
  - **高速実行**: **<a href="https://pydantic-docs.helpmanual.io" target="_blank">Pydantic</a>** と **<a href="/docs/docs/guides/async-support.md">非同期サポート</a>** により非常に高いパフォーマンスを実現。
  - **コードが速く書ける**: 型ヒントと自動ドキュメントにより、ビジネスロジックのみに集中可能。
  - **標準準拠**: API のオープンスタンダードである **OpenAPI**（旧称 Swagger）と **JSON Schema** に基づいています。
  - **Django フレンドリー**: （当然ながら）Django のコアと ORM との統合が優れています。
  - **本番対応**: オリジナルの Ninja プロジェクトは複数の企業で本番環境にて使用されています。



![Django Shinobi REST Framework](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/benchmark.png)

**ドキュメント**: https://pmdevita.github.io/django-shinobi


---

## インストール

あなたのDjangoプロジェクトに、Django Shinobiを追加します。

```
pip install django-shinobi
```

または新しいプロジェクトを開始します。

```shell
pip install django django-shinobi
django-admin startproject apidemo
```

## 使用方法


Djangoプロジェクトのurls.pyの隣に、`api.py`という新しいファイルを作成します。

```Python
from ninja import NinjaAPI

api = NinjaAPI()


@api.get("/add")
def add(request, a: int, b: int):
    return {"result": a + b}
```


Now go to `urls.py` and add the following:


```Python hl_lines="3 7"
...
from .api import api

urlpatterns = [
    path("admin/", admin.site.urls),
    path("api/", api.urls),  # <---------- !
]
```
**これで完了です！**

これで、以下のAPIを作成しました：

 - `/api/add` でHTTP GETリクエストを受け取る
 - GETパラメータ `a` と `b` を受け取り、検証および型変換する
 - 結果をJSONにデコードする
 - 定義された操作のOpenAPIスキーマを生成する

### インタラクティブAPIドキュメント

Djangoプロジェクトを実行してください


```shell
python manage.py runsever
```

次に <a href="http://127.0.0.1:8000/api/docs" target="_blank">http://127.0.0.1:8000/api/docs</a> にアクセスしてください。

自動生成されたインタラクティブなAPIドキュメント（<a href="https://github.com/swagger-api/swagger-ui" target="_blank">Swagger UI</a> または <a href="https://github.com/Redocly/redoc" target="_blank">Redoc</a> による提供）を見ることができます：


![Swagger UI](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/index-swagger-ui.png)

## 次に何をする？

 - こちらで完全なドキュメントを読む - https://pmdevita.github.io/django-shinobi
 - このプロジェクトをサポートするために、Githubでスターを付けてください。 ![github star](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/github-star.png)
 - [Twitter経由で共有](https://twitter.com/intent/tweet?text=Check%20out%20Django%20Shinobi%20-%20Fast%20Django%20REST%20Framework%20-%20https%3A%2F%2Fpmdevita.github.io/django-shinobi)
 - フィードバックを共有し、Discordで開発について議論しましょう https://discord.gg/ntFTXu7NNv


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-13

---