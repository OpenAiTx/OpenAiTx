<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>FastAPI 프레임워크, 고성능, 배우기 쉬움, 빠른 개발, 프로덕션 준비 완료</em>
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

**문서**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**소스 코드**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI는 표준 Python 타입 힌트를 기반으로 Python으로 API를 구축하기 위한 현대적이고 빠른(고성능) 웹 프레임워크입니다.

주요 특징은 다음과 같습니다:

* **빠름**: 매우 높은 성능, **NodeJS** 및 **Go**와 동급 (Starlette 및 Pydantic 덕분). [가장 빠른 Python 프레임워크 중 하나](#performance).
* **빠른 개발**: 기능 개발 속도를 약 200%~300% 증가시킵니다. *
* **버그 감소**: 개발자 실수로 인한 오류를 약 40% 줄입니다. *
* **직관적**: 뛰어난 에디터 지원. <abbr title="자동 완성, autocompletion, IntelliSense로도 알려짐">자동완성</abbr>이 모든 곳에. 디버깅 시간 감소.
* **쉬움**: 사용 및 학습이 쉽도록 설계되었습니다. 문서 읽는 시간 절약.
* **간결함**: 코드 중복 최소화. 각 파라미터 선언에서 여러 기능 제공. 버그 감소.
* **견고함**: 프로덕션 준비가 된 코드. 자동 인터랙티브 문서화 제공.
* **표준 기반**: API를 위한 오픈 표준인 <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a>(이전의 Swagger)와 <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>에 기반(완벽 호환)합니다.

<small>* 내부 개발팀의 프로덕션 애플리케이션 개발 테스트를 기반으로 한 추정치입니다.</small>

## 후원사

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

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">기타 후원사</a>

## 의견

"_[...] 요즘 **FastAPI**를 정말 많이 사용하고 있습니다. [...] 제 팀의 **ML 서비스** 전부를 **Microsoft**에서 FastAPI로 개발할 계획입니다. 일부는 **Windows**의 핵심 제품에, 일부는 **Office** 제품에 통합되고 있습니다._"

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(ref)</small></a></div>

---

"_우리는 **FastAPI** 라이브러리를 채택하여 **REST** 서버를 만들었고, 이를 통해 **예측**을 얻을 수 있습니다. [Ludwig용]_"

<div style="text-align: right; margin-right: 10%;">Piero Molino, Yaroslav Dudin, and Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(ref)</small></a></div>

---

"_**Netflix**는 우리의 **위기 관리** 오케스트레이션 프레임워크인 **Dispatch**를 오픈소스로 공개하게 되어 기쁩니다! [**FastAPI**로 개발됨]_"

<div style="text-align: right; margin-right: 10%;">Kevin Glisson, Marc Vilanova, Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(ref)</small></a></div>

---

"_**FastAPI**가 너무 재미있어서 너무 신나요!_"

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">Python Bytes</a> 팟캐스트 진행자</strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(ref)</small></a></div>

---

"_솔직히, 당신이 만든 것은 매우 견고하고 완성도가 높아 보입니다. 여러 면에서 내가 **Hug**에 원했던 것이기도 합니다 - 누군가가 실제로 그것을 만든 것을 보니 영감을 받았습니다._"

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">Hug</a> 창시자</strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(ref)</small></a></div>

---

"_REST API를 구축하는 **현대적인 프레임워크**를 배우고 싶다면 **FastAPI**를 확인해보세요 [...] 빠르고, 사용하기 쉽고, 배우기도 쉽습니다 [...]_"

"_우리는 **API**에 **FastAPI**를 사용하기로 전환했습니다 [...] 당신도 좋아하게 될 것이라 생각합니다 [...]_"

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">Explosion AI</a> 창립자 - <a href="https://spacy.io" target="_blank">spaCy</a> 제작자</strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(ref)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(ref)</small></a></div>

---

"_프로덕션 Python API를 구축하려는 분이라면 **FastAPI**를 적극 추천합니다. **아름답게 설계**되었고, **사용이 간단**하며 **확장성이 매우 뛰어납니다**. 우리의 API 우선 개발 전략의 **핵심 요소**가 되었으며, Virtual TAC Engineer와 같은 여러 자동화 및 서비스에 활용되고 있습니다._"

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(ref)</small></a></div>

---

## **Typer**, CLI의 FastAPI

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

터미널에서 사용할 <abbr title="Command Line Interface">CLI</abbr> 앱을 만들고 있다면, <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a>를 확인하세요.

**Typer**는 FastAPI의 동생과도 같습니다. **CLI의 FastAPI**가 되는 것이 목표입니다. ⌨️ 🚀

## 요구 사항

FastAPI는 거인의 어깨 위에 서 있습니다:

* 웹 관련 부분은 <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a>를 사용합니다.
* 데이터 관련 부분은 <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a>를 사용합니다.

## 설치

<a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">가상 환경</a>을 만들고 활성화한 뒤, FastAPI를 설치하세요:

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**참고**: 모든 터미널에서 잘 작동하도록 `"fastapi[standard]"`를 따옴표로 감싸야 합니다.

## 예제

### 생성하기

다음과 같이 `main.py` 파일을 만드세요:

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
<summary>또는 <code>async def</code>를 사용하려면...</summary>

코드에 `async` / `await`를 사용하는 경우, `async def`를 사용하세요:

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

**참고**:

모르신다면, <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">문서의 `async`와 `await` 관련 "In a hurry?" 섹션</a>을 확인하세요.

</details>

### 실행하기

서버를 다음 명령으로 실행하세요:

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
<summary><code>fastapi dev main.py</code> 명령에 대하여...</summary>

`fastapi dev` 명령은 `main.py` 파일을 읽고, 그 안의 **FastAPI** 앱을 감지하여 <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a>을 사용해 서버를 시작합니다.

기본적으로 `fastapi dev`는 로컬 개발을 위해 자동 재시작(auto-reload)이 활성화된 상태로 시작됩니다.

자세한 내용은 <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">FastAPI CLI 문서</a>를 참조하세요.

</details>

### 확인하기

브라우저에서 <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>로 접속하세요.

JSON 응답은 다음과 같이 표시됩니다:

```JSON
{"item_id": 5, "q": "somequery"}
```

이미 다음과 같은 API를 만들었습니다:

* HTTP 요청을 _경로_ `/` 및 `/items/{item_id}`에서 받습니다.
* 두 _경로_ 모두 `GET` <em>연산</em>(HTTP _메서드_라고도 함)을 사용합니다.
* _경로_ `/items/{item_id}`는 `int` 타입의 _경로 파라미터_ `item_id`를 가집니다.
* _경로_ `/items/{item_id}`는 선택적 `str` 타입 _쿼리 파라미터_ `q`를 가집니다.

### 인터랙티브 API 문서

이제 <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>로 이동하세요.

자동 생성되는 인터랙티브 API 문서(<a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a> 제공)가 표시됩니다:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### 대안 API 문서

그리고 <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>로 이동하세요.

대안 자동 문서화 화면(<a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a> 제공)이 표시됩니다:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## 예제 업그레이드

이제 `main.py` 파일을 수정하여 `PUT` 요청에서 body를 받도록 하세요.

Pydantic 덕분에 표준 Python 타입으로 body를 선언하세요.

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

`fastapi dev` 서버는 자동으로 리로드됩니다.

### 인터랙티브 API 문서 업그레이드

이제 <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>로 이동하세요.

* 인터랙티브 API 문서가 자동으로 업데이트되어 새로운 body도 포함됩니다:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* "Try it out" 버튼을 클릭하면 파라미터를 직접 입력하고 API와 직접 상호작용할 수 있습니다:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* 그 다음 "Execute" 버튼을 누르면, UI가 API와 통신하여 파라미터를 전송하고, 결과를 받아 화면에 보여줍니다:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### 대안 API 문서 업그레이드

그리고 <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>로 이동하세요.

* 대안 문서에도 새로운 쿼리 파라미터와 body가 반영됩니다:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### 요약

요약하면, 파라미터, body 등의 타입을 함수 파라미터로 **한 번만** 선언하면 됩니다.

표준 현대 Python 타입만 사용하면 됩니다.

새로운 문법이나 특정 라이브러리의 메서드, 클래스를 별도로 배울 필요가 없습니다.

그냥 표준 **Python**만 사용하면 됩니다.

예를 들어, `int` 타입의 경우:

```Python
item_id: int
```

혹은 좀 더 복잡한 `Item` 모델의 경우:

```Python
item: Item
```

...이 단일 선언만으로 다음을 모두 얻을 수 있습니다:

* 에디터 지원:
    * 자동완성.
    * 타입 체크.
* 데이터 검증:
    * 데이터가 유효하지 않을 때 자동적이고 명확한 오류.
    * 깊게 중첩된 JSON 객체도 검증.
* 입력 데이터의 <abbr title="직렬화, 파싱, 마샬링으로도 알려짐">변환</abbr>: 네트워크에서 Python 데이터와 타입으로 변환. 예:
    * JSON.
    * 경로 파라미터.
    * 쿼리 파라미터.
    * 쿠키.
    * 헤더.
    * 폼.
    * 파일.
* 출력 데이터의 <abbr title="직렬화, 파싱, 마샬링으로도 알려짐">변환</abbr>: Python 데이터와 타입을 네트워크 데이터(JSON)로 변환:
    * Python 기본 타입(`str`, `int`, `float`, `bool`, `list` 등).
    * `datetime` 객체.
    * `UUID` 객체.
    * 데이터베이스 모델.
    * ...등 다양한 타입.
* 자동 인터랙티브 API 문서화, 2가지 대안 UI 제공:
    * Swagger UI.
    * ReDoc.

---

앞선 코드 예시로 돌아가, **FastAPI**는 다음을 수행합니다:

* `GET` 및 `PUT` 요청의 경로에 `item_id`가 있는지 검증.
* `item_id`가 `int` 타입인지 검증.
    * 아니면 클라이언트에 명확한 오류를 반환.
* `GET` 요청에 `q`라는 선택적 쿼리 파라미터가 있는지 확인 (`http://127.0.0.1:8000/items/foo?q=somequery`과 같이).
    * `q` 파라미터가 `= None`으로 선언되어 있으니 선택적입니다.
    * `None`이 없으면 필수(예: `PUT`의 body).
* `/items/{item_id}`에 대한 `PUT` 요청의 body를 JSON으로 읽음:
    * 필수 속성 `name`이 `str`인지 확인.
    * 필수 속성 `price`가 `float`인지 확인.
    * 선택 속성 `is_offer`가 있다면 `bool`인지 확인.
    * 이 모든 것은 깊게 중첩된 JSON 객체에도 적용됨.
* JSON 자동 변환 지원.
* 모든 내용을 OpenAPI로 문서화:
    * 인터랙티브 문서 시스템.
    * 다양한 언어의 자동 클라이언트 코드 생성 시스템.
* 2가지 인터랙티브 문서 웹 UI 제공.

---

이것은 빙산의 일각에 불과하지만, 전체 작동 방식을 이미 이해하셨을 것입니다.

다음 줄을 변경해보세요:

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...를:

```Python
        ... "item_name": item.name ...
```

...에서:

```Python
        ... "item_price": item.price ...
```

...로 바꿔보면, 에디터가 속성을 자동완성하고 타입을 인식하는 모습을 볼 수 있습니다:

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

더 많은 기능이 포함된 완전한 예제는 <a href="https://fastapi.tiangolo.com/tutorial/">튜토리얼 - 사용자 가이드</a>를 참고하세요.

**스포일러**: 튜토리얼 - 사용자 가이드에는 아래 내용이 포함되어 있습니다:

* **헤더**, **쿠키**, **폼 필드**, **파일** 등 다양한 위치에서 **파라미터** 선언.
* `maximum_length`, `regex` 등 **검증 제약조건** 설정 방법.
* 강력하면서도 사용하기 쉬운 **<abbr title="컴포넌트, 리소스, 프로바이더, 서비스, 인젝터블로도 알려짐">의존성 주입</abbr>** 시스템.
* **JWT 토큰**이 포함된 **OAuth2**, **HTTP Basic** 인증 등 보안 및 인증.
* **Pydantic** 덕분에 **깊게 중첩된 JSON 모델** 선언도 매우 쉽고 강력함.
* <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> 등과의 **GraphQL** 통합.
* Starlette 덕분에 제공되는 다양한 추가 기능:
    * **WebSockets**
    * HTTPX 및 `pytest` 기반의 매우 쉬운 테스트
    * **CORS**
    * **쿠키 세션**
    * ...등 다양한 기능

## 성능

독립적인 TechEmpower 벤치마크에서 **FastAPI** 애플리케이션은 Uvicorn에서 실행 시 <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">가장 빠른 Python 프레임워크 중 하나</a>로 나타났으며, Starlette와 Uvicorn(내부적으로 FastAPI에서 사용)이 바로 위에 있습니다. (*)

자세한 내용은 <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">벤치마크</a> 섹션을 참고하세요.

## 의존성

FastAPI는 Pydantic 및 Starlette에 의존합니다.

### `standard` 의존성

`pip install "fastapi[standard]"`로 FastAPI를 설치하면 `standard` 그룹의 선택적 의존성이 함께 설치됩니다:

Pydantic에서 사용됨:

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - 이메일 검증용.

Starlette에서 사용됨:

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - `TestClient` 사용 시 필요.
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - 기본 템플릿 구성 사용 시 필요.
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - `request.form()`으로 폼 <abbr title="HTTP 요청에서 받은 문자열을 Python 데이터로 변환">파싱</abbr> 지원 시 필요.

FastAPI / Starlette에서 사용됨:

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - 애플리케이션을 로드하고 서비스하는 서버. `uvicorn[standard]`에는 높은 성능을 위한 일부 의존성(예: `uvloop`)이 포함됨.
* `fastapi-cli` - `fastapi` 명령어 제공.

### `standard` 의존성 없이 설치

`standard` 선택적 의존성을 포함하고 싶지 않다면, `pip install "fastapi[standard]"` 대신 `pip install fastapi`로 설치하면 됩니다.

### 추가 선택적 의존성

필요에 따라 설치할 수 있는 추가 의존성이 있습니다.

추가 선택적 Pydantic 의존성:

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - 설정 관리용.
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - Pydantic에서 사용할 수 있는 추가 타입.

추가 선택적 FastAPI 의존성:

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - `ORJSONResponse` 사용 시 필요.
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - `UJSONResponse` 사용 시 필요.

## 라이선스

이 프로젝트는 MIT 라이선스 조건에 따라 라이선스가 부여됩니다.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---