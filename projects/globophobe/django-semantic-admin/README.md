Django Semantic UI admin theme
------------------------------
<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/change-list.png" alt="django-semantic-admin"/>

A completely free (MIT) [Semantic UI](https://semantic-ui.com/) admin theme for Django. Actually, this is my 3rd admin theme for Django. The first was forgettable, and the second was with [Pure CSS](https://purecss.io/). Pure CSS was great, but lacked JavaScript components.

Semantic UI looks professional, and has great JavaScript components.

Log in to the demo with username `admin` and password `semantic`: https://semantic-admin.com

Documentation is on [GitHub Pages](https://globophobe.github.io/django-semantic-admin/).


Django Semantic Forms
---------------------
🎉 As of v0.5.0, forms were moved to [django-semantic-forms](https://github.com/globophobe/django-semantic-forms). `semantic_forms` must be added to INSTALLED_APPS.

```python
INSTALLED_APPS = [
    "semantic_admin",
    "semantic_forms",
    ...
]
```

You may use `semantic_forms` outside of the admin. 


Why?
----
* Looks professional, with a nice sidebar.
* Responsive design, even [tables can stack](https://semantic-ui.com/collections/table.html#stacking) responsively on mobile.
* JavaScript datepicker and timepicker components.
* JavaScript selects, including multiple selections, which integrate well with Django autocomplete fields.
* Semantic UI has libraries for [React](https://react.semantic-ui.com/) and [Vue](https://semantic-ui-vue.github.io/#/), in addition to jQuery. This means this package can be used to style the admin, and custom views can be added with React or Vue components with the same style.


Install
-------

Install from PyPI:

```
pip install django-semantic-admin
```

Add to `settings.py` before `django.contrib.admin`:

```python
INSTALLED_APPS = [
    "semantic_admin",
    "semantic_forms",
    "django.contrib.admin",
    ...
]
```

Please remember to run `python manage.py collectstatic` for production deployments.

Usage
-----

Instead of `admin.ModelAdmin`, `admin.StackedInline`, or `admin.TabularInline`:

```python
class ExampleStackedInline(admin.StackedInline):
    pass

class ExampleTabularInline(admin.TabularInline):
    pass

class ExampleAdmin(admin.ModelAdmin):
    inlines = (ExampleStackedInline, ExampleTabularInline)
```

Inherit from their `Semantic` equivalents:

```python
from semantic_admin import SemanticModelAdmin, SemanticStackedInline, SemanticTabularInline

class ExampleStackedInline(SemanticStackedInline):
    pass

class ExampleTabularInline(SemanticTabularInline):
    pass

class ExampleAdmin(SemanticModelAdmin):
    inlines = (ExampleStackedInline, ExampleTabularInline)
```

Awesome optional features
-------------------------

1. Optional integration with [django-filter](https://github.com/carltongibson/django-filter):

<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/django-filter.png" width="335" alt="django-filter" />

To enable this awesome feature, add `filterset_class` to your Django admin:

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

Inherit from their `Semantic` equivalents:

```python
from semantic_admin.contrib.import_export.admin import SemanticImportExportModelAdmin

class ExampleImportExportAdmin(SemanticImportExportModelAdmin):
    pass
```

Contributing
------------

Install dependencies with `uv sync --group dev`. The demo is built with [invoke tasks](https://github.com/globophobe/django-semantic-admin/blob/master/demo/tasks.py). For example, `cd demo; uv run invoke build`.


Notes
-----
Please note, this package uses [Fomantic UI](https://fomantic-ui.com/) the official community fork of Semantic UI.
