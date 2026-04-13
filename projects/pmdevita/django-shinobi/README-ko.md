<p align="center">
  <a href="https://pmdevita.github.io/django-shinobi/"><img src="https://pmdevita.github.io/django-shinobi/img/logo-big.png"></a>
</p>
<p align="center">
    <em>빠르게 배우고, 빠르게 코딩하며, 빠르게 실행하세요</em>
</p>


![Test](https://github.com/pmdevita/django-shinobi/actions/workflows/test_full.yml/badge.svg)
![Coverage](https://img.shields.io/codecov/c/github/pmdevita/django-shinobi)
[![PyPI version](https://badge.fury.io/py/django-shinobi.svg)](https://badge.fury.io/py/django-shinobi)
[![Downloads](https://static.pepy.tech/personalized-badge/django-shinobi?period=month&units=international_system&left_color=black&right_color=brightgreen&left_text=downloads/month)](https://pepy.tech/project/django-shinobi)
[![Discord](https://dcbadge.limes.pink/api/server/ntFTXu7NNv?style=flat-square)](https://discord.gg/ntFTXu7NNv)

# Django Shinobi - 빠른 Django REST 프레임워크

[문서](https://pmdevita.github.io/django-shinobi)

**Django Shinobi**는 **Django**와 Python 3.6+ **타입 힌트**를 사용하여 API를 구축하기 위한 웹 프레임워크입니다.

이것은 훌륭한 **[Django Ninja](https://github.com/vitalik/django-ninja)** 라이브러리의 포크로,  
커뮤니티가 원하는 기능과 수정 사항에 초점을 맞추고 있습니다.  
Ninja에서 오신 분들은 [차이점 목록](https://pmdevita.github.io/django-shinobi/differences/)과 [로드맵](https://github.com/pmdevita/django-shinobi/discussions/6)을 확인하세요!


 **주요 특징:**

  - **쉬움**: 사용하기 쉽고 직관적으로 설계되었습니다.
  - **빠른 실행**: **<a href="https://pydantic-docs.helpmanual.io" target="_blank">Pydantic</a>**과 **<a href="/docs/docs/guides/async-support.md">비동기 지원</a>** 덕분에 매우 높은 성능을 자랑합니다.
  - **빠른 코딩**: 타입 힌트와 자동 문서화로 비즈니스 로직에만 집중할 수 있습니다.
  - **표준 기반**: API를 위한 공개 표준인 **OpenAPI** (이전 명칭 Swagger)와 **JSON Schema**를 기반으로 합니다.
  - **Django 친화적**: (당연히) Django 코어 및 ORM과 좋은 통합성을 가집니다.
  - **프로덕션 준비 완료**: 원래 Ninja 프로젝트는 여러 기업의 라이브 프로젝트에서 사용되고 있습니다.



![Django Shinobi REST Framework](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/benchmark.png)

**문서**: https://pmdevita.github.io/django-shinobi

---

## 설치

당신의 Django 프로젝트에 Django Shinobi를 추가하세요.

```
pip install django-shinobi
```
또는 새 프로젝트를 시작하십시오.


```shell
pip install django django-shinobi
django-admin startproject apidemo
```

## 사용법


Django 프로젝트에서 urls.py 옆에 `api.py`라는 새 파일을 만드세요.

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
**끝났습니다!**

이제 여러분은 다음과 같은 API를 만들었습니다:

 - `/api/add`에서 HTTP GET 요청을 받습니다
 - GET 매개변수 `a`와 `b`를 받아 검증하고 타입 캐스팅합니다
 - 결과를 JSON으로 디코딩합니다
 - 정의된 작업에 대한 OpenAPI 스키마를 생성합니다

### 대화형 API 문서

Django 프로젝트를 실행하세요


```shell
python manage.py runsever
```
이제 <a href="http://127.0.0.1:8000/api/docs" target="_blank">http://127.0.0.1:8000/api/docs</a>로 이동하세요

자동 상호작용 API 문서가 표시됩니다 (<a href="https://github.com/swagger-api/swagger-ui" target="_blank">Swagger UI</a> 또는 <a href="https://github.com/Redocly/redoc" target="_blank">Redoc</a> 제공):


![Swagger UI](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/index-swagger-ui.png)

## 다음 단계?

 - 전체 문서는 여기에서 읽어보세요 - https://pmdevita.github.io/django-shinobi
 - 이 프로젝트를 지원하려면 Github에서 별을 눌러주세요. ![github star](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/github-star.png)
 - [트위터](https://twitter.com/intent/tweet?text=Check%20out%20Django%20Shinobi%20-%20Fast%20Django%20REST%20Framework%20-%20https%3A%2F%2Fpmdevita.github.io/django-shinobi)를 통해 공유하세요
 - 피드백을 공유하고 개발에 대해 토론하려면 Discord https://discord.gg/ntFTXu7NNv를 방문하세요



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-13

---