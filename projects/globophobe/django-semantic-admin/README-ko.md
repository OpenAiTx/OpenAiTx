Django Semantic UI 관리자 테마
------------------------------
<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/change-list.png" alt="django-semantic-admin"/>

Django를 위한 완전 무료(MIT) [Semantic UI](https://semantic-ui.com/) 관리자 테마입니다. 사실 이것은 제가 만든 Django용 세 번째 관리자 테마입니다. 첫 번째는 기억에 남지 않았고, 두 번째는 [Pure CSS](https://purecss.io/)를 사용했습니다. Pure CSS는 훌륭했지만 JavaScript 컴포넌트가 부족했습니다.

Semantic UI는 전문적으로 보이며 훌륭한 JavaScript 컴포넌트를 제공합니다.

사용자 이름 `admin`과 비밀번호 `semantic`으로 데모에 로그인하세요: https://semantic-admin.com

문서는 [GitHub Pages](https://globophobe.github.io/django-semantic-admin/)에 있습니다.


Django Semantic Forms
---------------------
🎉 v0.5.0부터, 폼은 [django-semantic-forms](https://github.com/globophobe/django-semantic-forms)로 분리되었습니다. `semantic_forms`를 INSTALLED_APPS에 추가해야 합니다.

```python
INSTALLED_APPS = [
    "semantic_admin",
    "semantic_forms",
    ...
]
```

관리자 외부에서도 `semantic_forms`를 사용할 수 있습니다. 


이유는?
----
* 깔끔한 사이드바와 함께 전문적인 외관을 제공합니다.
* 반응형 디자인으로, [테이블도 모바일에서 반응형으로 쌓일 수 있습니다](https://semantic-ui.com/collections/table.html#stacking).
* 자바스크립트 날짜 선택기와 시간 선택기 컴포넌트.
* 다중 선택을 포함한 자바스크립트 선택기들이 있어 Django 자동완성 필드와 잘 통합됩니다.
* Semantic UI는 jQuery 외에도 [React](https://react.semantic-ui.com/)와 [Vue](https://semantic-ui-vue.github.io/#/)용 라이브러리를 제공합니다. 이는 이 패키지가 관리자를 스타일링하는 데 사용될 수 있으며, React 또는 Vue 컴포넌트로 같은 스타일의 사용자 정의 뷰를 추가할 수 있음을 의미합니다.


설치
-------

PyPI에서 설치:

```
pip install django-semantic-admin
```
`django.contrib.admin` 앞에 `settings.py`에 추가하세요:


```python
INSTALLED_APPS = [
    "semantic_admin",
    "semantic_forms",
    "django.contrib.admin",
    ...
]
```

프로덕션 배포 시 `python manage.py collectstatic` 명령을 실행하는 것을 잊지 마십시오.

사용법
-----

`admin.ModelAdmin`, `admin.StackedInline` 또는 `admin.TabularInline` 대신:

```python
class ExampleStackedInline(admin.StackedInline):
    pass

class ExampleTabularInline(admin.TabularInline):
    pass

class ExampleAdmin(admin.ModelAdmin):
    inlines = (ExampleStackedInline, ExampleTabularInline)
```
그들의 `Semantic` 등가체에서 상속받으십시오:


```python
from semantic_admin import SemanticModelAdmin, SemanticStackedInline, SemanticTabularInline

class ExampleStackedInline(SemanticStackedInline):
    pass

class ExampleTabularInline(SemanticTabularInline):
    pass

class ExampleAdmin(SemanticModelAdmin):
    inlines = (ExampleStackedInline, ExampleTabularInline)
```

멋진 선택적 기능
-------------------------

1. [django-filter](https://github.com/carltongibson/django-filter)와의 선택적 통합:

<img src="https://raw.githubusercontent.com/globophobe/django-semantic-admin/master/docs/screenshots/django-filter.png" width="335" alt="django-filter" />

이 멋진 기능을 활성화하려면, Django 관리자에 `filterset_class`를 추가하세요:

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

`Semantic` 대응 항목에서 상속받으세요:

```python
from semantic_admin.contrib.import_export.admin import SemanticImportExportModelAdmin

class ExampleImportExportAdmin(SemanticImportExportModelAdmin):
    pass
```

Contributing
------------

`uv sync --group dev` 명령어로 의존성을 설치하세요. 데모는 [invoke tasks](https://github.com/globophobe/django-semantic-admin/blob/master/demo/tasks.py)로 빌드됩니다. 예를 들어, `cd demo; uv run invoke build`를 실행하세요.


Notes
-----
이 패키지는 Semantic UI의 공식 커뮤니티 포크인 [Fomantic UI](https://fomantic-ui.com/)를 사용합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-22

---