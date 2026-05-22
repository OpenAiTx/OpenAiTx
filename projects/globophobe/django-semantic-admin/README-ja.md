Django Semantic UI 管理テーマ
------------------------------
<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/change-list.png" alt="django-semantic-admin"/>

Django向けの完全無料（MIT）の[Semantic UI](https://semantic-ui.com/)管理テーマです。実はこれは私の3つ目のDjango管理テーマです。最初は印象に残らず、2つ目は[Pure CSS](https://purecss.io/)を使いました。Pure CSSは素晴らしかったですが、JavaScriptコンポーネントが不足していました。

Semantic UIはプロフェッショナルな見た目で、優れたJavaScriptコンポーネントを備えています。

ユーザー名 `admin`、パスワード `semantic` でデモにログインできます：https://semantic-admin.com

ドキュメントは[GitHub Pages](https://globophobe.github.io/django-semantic-admin/)にあります。


Django Semantic Forms
---------------------
🎉 v0.5.0より、フォームは[django-semantic-forms](https://github.com/globophobe/django-semantic-forms)に移行しました。`semantic_forms`をINSTALLED_APPSに追加する必要があります。

```python
INSTALLED_APPS = [
    "semantic_admin",
    "semantic_forms",
    ...
]
```

`semantic_forms`は管理画面以外でも使用できます。 


なぜですか？
----
* サイドバーが美しく、プロフェッショナルな見た目。
* レスポンシブデザインで、[テーブルもモバイルでスタック](https://semantic-ui.com/collections/table.html#stacking)可能。
* JavaScriptのデートピッカーとタイムピッカーコンポーネント。
* 複数選択を含むJavaScriptのセレクトで、Djangoのオートコンプリートフィールドとよく統合。
* Semantic UIはjQueryに加え、[React](https://react.semantic-ui.com/)や[Vue](https://semantic-ui-vue.github.io/#/)のライブラリも提供。これにより、このパッケージは管理画面のスタイリングに使用でき、カスタムビューは同じスタイルでReactまたはVueコンポーネントで追加可能。


インストール
-------

PyPIからインストール：

```
pip install django-semantic-admin
```

`django.contrib.admin` の前に `settings.py` に追加してください：

```python
INSTALLED_APPS = [
    "semantic_admin",
    "semantic_forms",
    "django.contrib.admin",
    ...
]
```

本番環境へのデプロイの際は必ず `python manage.py collectstatic` を実行してください。

使用法
-----

`admin.ModelAdmin`、`admin.StackedInline`、または `admin.TabularInline` の代わりに:

```python
class ExampleStackedInline(admin.StackedInline):
    pass

class ExampleTabularInline(admin.TabularInline):
    pass

class ExampleAdmin(admin.ModelAdmin):
    inlines = (ExampleStackedInline, ExampleTabularInline)
```

それらの `Semantic` 相当から継承します：

```python
from semantic_admin import SemanticModelAdmin, SemanticStackedInline, SemanticTabularInline

class ExampleStackedInline(SemanticStackedInline):
    pass

class ExampleTabularInline(SemanticTabularInline):
    pass

class ExampleAdmin(SemanticModelAdmin):
    inlines = (ExampleStackedInline, ExampleTabularInline)
```
素晴らしいオプション機能
-------------------------

1. [django-filter](https://github.com/carltongibson/django-filter) とのオプション統合：

<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/django-filter.png" width="335" alt="django-filter" />

この素晴らしい機能を有効にするには、Django管理に `filterset_class` を追加してください：


```python
from semantic_forms.filters import SemanticFilterSet

class DemoFilter(SemanticFilterSet):
    class Meta:
        model = Demo
        fields = ("demo_field",)

class DemoAdmin(SemanticModelAdmin):
    filterset_class = DemoFilter
```

2. HTML preview in Django `autocomplete_fields`:

<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/html5-autocomplete.png" width="670" alt="html5-autocomplete" />

To enable this awesome feature, add the `semantic_autocomplete` property to your Django model:

```python
class DemoModel(models.Model):
    @property
    def semantic_autocomplete(self):
        return self.get_img()
```

3. Optional integration with [django-import-export](https://github.com/django-import-export/django-import-export):

<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/django-import-export.png" width="670" alt="django-import-export" />

To enable this awesome feature, instead of `ImportExportModelAdmin`, etc:

```python
from import_export.admin import ImportExportModelAdmin 

class ExampleImportExportAdmin(ImportExportModelAdmin):
    pass
```

`Semantic` の同等品から継承する:

```python
from semantic_admin.contrib.import_export.admin import SemanticImportExportModelAdmin

class ExampleImportExportAdmin(SemanticImportExportModelAdmin):
    pass
```

Contributing
------------

`uv sync --group dev`で依存関係をインストールします。デモは[invoke tasks](https://github.com/globophobe/django-semantic-admin/blob/master/demo/tasks.py)で構築されています。例えば、`cd demo; uv run invoke build`です。


Notes
-----
このパッケージは[Semantic UIの公式コミュニティフォークであるFomantic UI](https://fomantic-ui.com/)を使用していることに注意してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-22

---