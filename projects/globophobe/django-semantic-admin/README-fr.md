Thème d’administration Django Semantic UI
----------------------------------------
<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/change-list.png" alt="django-semantic-admin"/>

Un thème d’administration complètement gratuit (MIT) [Semantic UI](https://semantic-ui.com/) pour Django. En fait, c’est mon 3e thème d’administration pour Django. Le premier était oubliable, et le second utilisait [Pure CSS](https://purecss.io/). Pure CSS était génial, mais manquait de composants JavaScript.

Semantic UI a un aspect professionnel et dispose de super composants JavaScript.

Connectez-vous à la démo avec le nom d’utilisateur `admin` et le mot de passe `semantic` : https://semantic-admin.com

La documentation est sur [GitHub Pages](https://globophobe.github.io/django-semantic-admin/).


Django Semantic Forms
---------------------
🎉 Depuis la version 0.5.0, les formulaires ont été déplacés vers [django-semantic-forms](https://github.com/globophobe/django-semantic-forms). `semantic_forms` doit être ajouté à INSTALLED_APPS.

```python
INSTALLED_APPS = [
    "semantic_admin",
    "semantic_forms",
    ...
]
```

Vous pouvez utiliser `semantic_forms` en dehors de l'administration. 


Pourquoi ?
----
* Aspect professionnel, avec une jolie barre latérale.
* Design responsive, même [les tableaux peuvent se superposer](https://semantic-ui.com/collections/table.html#stacking) de manière responsive sur mobile.
* Composants JavaScript de sélection de date et d'heure.
* Sélections JavaScript, y compris les sélections multiples, qui s'intègrent bien avec les champs d'autocomplétion Django.
* Semantic UI dispose de bibliothèques pour [React](https://react.semantic-ui.com/) et [Vue](https://semantic-ui-vue.github.io/#/), en plus de jQuery. Cela signifie que ce paquet peut être utilisé pour styliser l'administration, et des vues personnalisées peuvent être ajoutées avec des composants React ou Vue avec le même style.


Installation
-------

Installer depuis PyPI :

```
pip install django-semantic-admin
```

Ajouter à `settings.py` avant `django.contrib.admin` :

```python
INSTALLED_APPS = [
    "semantic_admin",
    "semantic_forms",
    "django.contrib.admin",
    ...
]
```

Veuillez vous rappeler d'exécuter `python manage.py collectstatic` pour les déploiements en production.

Utilisation
-----

Au lieu de `admin.ModelAdmin`, `admin.StackedInline` ou `admin.TabularInline` :

```python
class ExampleStackedInline(admin.StackedInline):
    pass

class ExampleTabularInline(admin.TabularInline):
    pass

class ExampleAdmin(admin.ModelAdmin):
    inlines = (ExampleStackedInline, ExampleTabularInline)
```

Hériter de leurs équivalents `Semantic` :

```python
from semantic_admin import SemanticModelAdmin, SemanticStackedInline, SemanticTabularInline

class ExampleStackedInline(SemanticStackedInline):
    pass

class ExampleTabularInline(SemanticTabularInline):
    pass

class ExampleAdmin(SemanticModelAdmin):
    inlines = (ExampleStackedInline, ExampleTabularInline)
```

Fonctionnalités optionnelles géniales
------------------------------------

1. Intégration optionnelle avec [django-filter](https://github.com/carltongibson/django-filter) :

<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/django-filter.png" width="335" alt="django-filter" />

Pour activer cette fonctionnalité géniale, ajoutez `filterset_class` à votre administration Django :

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

Hériter de leurs équivalents `Semantic` :

```python
from semantic_admin.contrib.import_export.admin import SemanticImportExportModelAdmin

class ExampleImportExportAdmin(SemanticImportExportModelAdmin):
    pass
```

Contribuer
------------

Installez les dépendances avec `uv sync --group dev`. La démo est construite avec [invoke tasks](https://github.com/globophobe/django-semantic-admin/blob/master/demo/tasks.py). Par exemple, `cd demo; uv run invoke build`.


Notes
-----
Veuillez noter que ce package utilise [Fomantic UI](https://fomantic-ui.com/), le fork communautaire officiel de Semantic UI.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-22

---