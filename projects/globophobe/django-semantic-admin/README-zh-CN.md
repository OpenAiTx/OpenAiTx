Django 语义 UI 管理主题
------------------------------
<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/change-list.png" alt="django-semantic-admin"/>

一个完全免费的（MIT 许可）[Semantic UI](https://semantic-ui.com/) Django 管理主题。实际上，这是我为 Django 开发的第 3 个管理主题。第一个令人难忘，第二个使用了 [Pure CSS](https://purecss.io/)。Pure CSS 很棒，但缺少 JavaScript 组件。

Semantic UI 看起来专业，并且拥有很棒的 JavaScript 组件。

使用用户名 `admin` 和密码 `semantic` 登录演示：https://semantic-admin.com

文档托管在 [GitHub Pages](https://globophobe.github.io/django-semantic-admin/)。


Django 语义表单
---------------------
🎉 从 v0.5.0 版本开始，表单已迁移到 [django-semantic-forms](https://github.com/globophobe/django-semantic-forms)。必须将 `semantic_forms` 添加到 INSTALLED_APPS 中。

```python
INSTALLED_APPS = [
    "semantic_admin",
    "semantic_forms",
    ...
]
```

你可以在管理后台之外使用 `semantic_forms`。


为什么？
----
* 外观专业，带有漂亮的侧边栏。
* 响应式设计，甚至[表格也能响应式堆叠](https://semantic-ui.com/collections/table.html#stacking)在移动端。
* JavaScript 日期选择器和时间选择器组件。
* JavaScript 选择框，包括多选，能很好地与 Django 自动完成字段集成。
* Semantic UI 除了 jQuery 之外，还有用于[React](https://react.semantic-ui.com/)和[Vue](https://semantic-ui-vue.github.io/#/)的库。这意味着该包可以用来美化管理后台，并且可以用 React 或 Vue 组件添加自定义视图，风格一致。


安装
-------

从 PyPI 安装：

```
pip install django-semantic-admin
```

在 `django.contrib.admin` 之前添加到 `settings.py`：

```python
INSTALLED_APPS = [
    "semantic_admin",
    "semantic_forms",
    "django.contrib.admin",
    ...
]
```
请记得在生产部署时运行 `python manage.py collectstatic`。

使用方法
-----

替代使用 `admin.ModelAdmin`、`admin.StackedInline` 或 `admin.TabularInline`：


```python
class ExampleStackedInline(admin.StackedInline):
    pass

class ExampleTabularInline(admin.TabularInline):
    pass

class ExampleAdmin(admin.ModelAdmin):
    inlines = (ExampleStackedInline, ExampleTabularInline)
```
继承自它们的 `Semantic` 等价项：


```python
from semantic_admin import SemanticModelAdmin, SemanticStackedInline, SemanticTabularInline

class ExampleStackedInline(SemanticStackedInline):
    pass

class ExampleTabularInline(SemanticTabularInline):
    pass

class ExampleAdmin(SemanticModelAdmin):
    inlines = (ExampleStackedInline, ExampleTabularInline)
```

超棒的可选功能
-------------------------

1. 可选集成 [django-filter](https://github.com/carltongibson/django-filter):

<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/django-filter.png" width="335" alt="django-filter" />

要启用此超棒功能，请在 Django 管理后台添加 `filterset_class`：

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

继承自它们的 `Semantic` 等价物：

```python
from semantic_admin.contrib.import_export.admin import SemanticImportExportModelAdmin

class ExampleImportExportAdmin(SemanticImportExportModelAdmin):
    pass
```

贡献
------------

使用 `uv sync --group dev` 安装依赖。演示使用 [invoke 任务](https://github.com/globophobe/django-semantic-admin/blob/master/demo/tasks.py) 构建。例如，`cd demo; uv run invoke build`。


注意事项
-----
请注意，本包使用的是 [Fomantic UI](https://fomantic-ui.com/)，这是 Semantic UI 的官方社区分支。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-22

---