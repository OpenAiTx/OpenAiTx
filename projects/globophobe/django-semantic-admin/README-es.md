Tema de administración Django Semantic UI
----------------------------------------
<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/change-list.png" alt="django-semantic-admin"/>

Un tema de administración completamente gratuito (MIT) de [Semantic UI](https://semantic-ui.com/) para Django. En realidad, este es mi tercer tema de administración para Django. El primero fue olvidable, y el segundo fue con [Pure CSS](https://purecss.io/). Pure CSS fue genial, pero carecía de componentes JavaScript.

Semantic UI luce profesional y tiene excelentes componentes JavaScript.

Inicia sesión en la demo con el usuario `admin` y la contraseña `semantic`: https://semantic-admin.com

La documentación está en [GitHub Pages](https://globophobe.github.io/django-semantic-admin/).


Formularios Semantic para Django
--------------------------------
🎉 A partir de la versión 0.5.0, los formularios se trasladaron a [django-semantic-forms](https://github.com/globophobe/django-semantic-forms). `semantic_forms` debe añadirse a INSTALLED_APPS.

```python
INSTALLED_APPS = [
    "semantic_admin",
    "semantic_forms",
    ...
]
```

Puede usar `semantic_forms` fuera del administrador. 


¿Por qué?
----
* Se ve profesional, con una barra lateral agradable.
* Diseño responsivo, incluso [las tablas pueden apilarse](https://semantic-ui.com/collections/table.html#stacking) de forma responsiva en móviles.
* Componentes JavaScript de selector de fecha y hora.
* Selectores JavaScript, incluyendo selecciones múltiples, que se integran bien con los campos de autocompletado de Django.
* Semantic UI tiene bibliotecas para [React](https://react.semantic-ui.com/) y [Vue](https://semantic-ui-vue.github.io/#/), además de jQuery. Esto significa que este paquete puede usarse para estilizar el administrador, y se pueden añadir vistas personalizadas con componentes React o Vue con el mismo estilo.


Instalación
-------

Instalar desde PyPI:

```
pip install django-semantic-admin
```

Agregue a `settings.py` antes de `django.contrib.admin`:

```python
INSTALLED_APPS = [
    "semantic_admin",
    "semantic_forms",
    "django.contrib.admin",
    ...
]
```

Por favor recuerde ejecutar `python manage.py collectstatic` para despliegues en producción.

Uso
-----

En lugar de `admin.ModelAdmin`, `admin.StackedInline`, o `admin.TabularInline`:

```python
class ExampleStackedInline(admin.StackedInline):
    pass

class ExampleTabularInline(admin.TabularInline):
    pass

class ExampleAdmin(admin.ModelAdmin):
    inlines = (ExampleStackedInline, ExampleTabularInline)
```
Heredar de sus equivalentes `Semantic`:


```python
from semantic_admin import SemanticModelAdmin, SemanticStackedInline, SemanticTabularInline

class ExampleStackedInline(SemanticStackedInline):
    pass

class ExampleTabularInline(SemanticTabularInline):
    pass

class ExampleAdmin(SemanticModelAdmin):
    inlines = (ExampleStackedInline, ExampleTabularInline)
```

Características opcionales impresionantes
-----------------------------------------

1. Integración opcional con [django-filter](https://github.com/carltongibson/django-filter):

<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/django-filter.png" width="335" alt="django-filter" />

Para habilitar esta increíble función, agrega `filterset_class` a tu administrador de Django:

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

Hereda de sus equivalentes `Semantic`:

```python
from semantic_admin.contrib.import_export.admin import SemanticImportExportModelAdmin

class ExampleImportExportAdmin(SemanticImportExportModelAdmin):
    pass
```

Contribuyendo
------------

Instale las dependencias con `uv sync --group dev`. La demostración se construye con [tareas invoke](https://github.com/globophobe/django-semantic-admin/blob/master/demo/tasks.py). Por ejemplo, `cd demo; uv run invoke build`.


Notas
-----
Tenga en cuenta que este paquete utiliza [Fomantic UI](https://fomantic-ui.com/), el fork oficial de la comunidad de Semantic UI.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-22

---