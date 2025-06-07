<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>Фреймворк FastAPI: высокая производительность, простота изучения, быстрая разработка, готовность к промышленному использованию</em>
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

**Документация**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**Исходный код**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI — это современный, быстрый (высокопроизводительный) веб-фреймворк для создания API на Python, основанный на стандартных подсказках типов Python.

Ключевые особенности:

* **Быстрый**: Очень высокая производительность, сопоставимая с **NodeJS** и **Go** (благодаря Starlette и Pydantic). [Один из самых быстрых Python-фреймворков](#performance).
* **Быстрая разработка**: Ускоряет процесс разработки функционала примерно на 200%–300%. *
* **Меньше ошибок**: Снижает количество ошибок, вызванных человеком (разработчиком), примерно на 40%. *
* **Интуитивность**: Отличная поддержка редакторов. <abbr title="также известна как автодополнение, IntelliSense">Автодополнение</abbr> повсюду. Меньше времени на отладку.
* **Простота**: Разработан для легкости использования и изучения. Меньше времени на чтение документации.
* **Краткость**: Минимизация дублирования кода. Множество функций из каждого объявления параметра. Меньше ошибок.
* **Надежность**: Готовый к промышленной эксплуатации код. С автоматической интерактивной документацией.
* **Стандартизированность**: Основан (и полностью совместим) с открытыми стандартами для API: <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a> (ранее Swagger) и <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>.

<small>* оценка основана на тестах внутренней команды разработчиков, создающих промышленные приложения.</small>

## Спонсоры

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

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">Другие спонсоры</a>

## Мнения

"_[...] Я часто использую **FastAPI** в последнее время. [...] На самом деле, я планирую использовать его для всех наших **ML-сервисов в Microsoft**. Некоторые из них уже интегрируются в ядро **Windows** и некоторые продукты **Office**._"

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(ref)</small></a></div>

---

"_Мы внедрили библиотеку **FastAPI** для запуска **REST**-сервера, к которому можно обращаться за **предсказаниями**. [для Ludwig]_"

<div style="text-align: right; margin-right: 10%;">Piero Molino, Yaroslav Dudin, и Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(ref)</small></a></div>

---

"_**Netflix** рад объявить о выходе в open-source нашего оркестрационного фреймворка по управлению кризисными ситуациями: **Dispatch**! [создан на **FastAPI**]_"

<div style="text-align: right; margin-right: 10%;">Kevin Glisson, Marc Vilanova, Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(ref)</small></a></div>

---

"_Я в восторге от **FastAPI**. Это так весело!_"

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">ведущий подкаста Python Bytes</a></strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(ref)</small></a></div>

---

"_Честно говоря, то, что вы создали, выглядит очень надежно и отполировано. Во многом это то, чем я хотел видеть **Hug** — вдохновляет видеть, как кто-то смог это реализовать._"

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">создатель Hug</a></strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(ref)</small></a></div>

---

"_Если вы хотите изучить один **современный фреймворк** для создания REST API — обратите внимание на **FastAPI** [...] Он быстрый, простой в использовании и легкий для изучения [...]_"

"_Мы перешли на **FastAPI** для наших **API** [...] Думаю, вам понравится [...]_"

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">основатели Explosion AI</a> - <a href="https://spacy.io" target="_blank">создатели spaCy</a></strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(ref)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(ref)</small></a></div>

---

"_Если кто-то ищет фреймворк для промышленного Python API, настоятельно рекомендую **FastAPI**. Он **красиво спроектирован**, **прост в использовании** и **отлично масштабируется**, стал **ключевым компонентом** нашей стратегии разработки API-first и обеспечивает множество автоматизаций и сервисов, таких как наш виртуальный инженер TAC._"

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(ref)</small></a></div>

---

## **Typer** — FastAPI для CLI

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

Если вы создаете приложение для <abbr title="Command Line Interface">CLI</abbr> для использования в терминале вместо веб-API, обратите внимание на <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a>.

**Typer** — младший брат FastAPI. Его цель — быть **FastAPI для CLI**. ⌨️ 🚀

## Требования

FastAPI стоит на плечах гигантов:

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> — для веб-части.
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> — для работы с данными.

## Установка

Создайте и активируйте <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">виртуальное окружение</a>, затем установите FastAPI:

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**Примечание**: Обязательно заключайте `"fastapi[standard]"` в кавычки, чтобы установка прошла корректно во всех терминалах.

## Пример

### Создайте

Создайте файл `main.py` со следующим содержимым:

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
<summary>Или используйте <code>async def</code>...</summary>

Если ваш код использует `async` / `await`, применяйте `async def`:

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

**Примечание**:

Если вы не уверены, ознакомьтесь с разделом _"В спешке?"_ о <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` и `await` в документации</a>.

</details>

### Запустите

Запустите сервер командой:

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
<summary>О команде <code>fastapi dev main.py</code>...</summary>

Команда `fastapi dev` читает ваш файл `main.py`, находит в нем приложение **FastAPI** и запускает сервер с помощью <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a>.

По умолчанию `fastapi dev` включит автообновление для локальной разработки.

Подробнее читайте в <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">документации FastAPI CLI</a>.

</details>

### Проверьте

Откройте в браузере <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>.

Вы увидите такой JSON-ответ:

```JSON
{"item_id": 5, "q": "somequery"}
```

Вы уже создали API, который:

* Принимает HTTP-запросы по _пути_ `/` и `/items/{item_id}`.
* Оба _пути_ используют операцию `GET` (также известную как HTTP-_метод_).
* Путь `/items/{item_id}` содержит _параметр пути_ `item_id`, который должен быть `int`.
* Путь `/items/{item_id}` имеет необязательный строковый _query-параметр_ `q`.

### Интерактивная документация API

Теперь откройте <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

Вы увидите автоматически сгенерированную интерактивную документацию API (предоставляется <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a>):

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### Альтернативная документация API

Теперь откройте <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

Вы увидите альтернативную автоматическую документацию (предоставляется <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a>):

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## Улучшенный пример

Теперь измените файл `main.py`, чтобы принимать тело запроса из `PUT`-запроса.

Объявите тело с помощью стандартных типов Python, благодаря Pydantic.

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

Сервер `fastapi dev` должен автоматически перезапуститься.

### Обновление интерактивной документации API

Теперь откройте <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

* Интерактивная документация API автоматически обновится, включая новое тело запроса:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* Нажмите кнопку "Try it out", чтобы заполнить параметры и напрямую взаимодействовать с API:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* Затем нажмите "Execute", интерфейс отправит параметры в ваш API, получит результат и отобразит его на экране:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### Обновление альтернативной документации API

Теперь откройте <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

* Альтернативная документация также отразит новый query-параметр и тело запроса:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### Краткий итог

В итоге, вы объявляете **один раз** типы параметров, тела запроса и т.д. как параметры функций.

Вы делаете это стандартными современными типами Python.

Вам не нужно изучать новый синтаксис, методы или классы какой-то библиотеки и т.п.

Только стандартный **Python**.

Например, для `int`:

```Python
item_id: int
```

или для более сложной модели `Item`:

```Python
item: Item
```

...и с этим единственным объявлением вы получаете:

* Поддержка редакторов, включая:
    * Автодополнение.
    * Проверку типов.
* Валидация данных:
    * Автоматические и понятные ошибки при некорректных данных.
    * Валидация даже для глубоко вложенных JSON-объектов.
* <abbr title="также известно как: сериализация, парсинг, маршаллинг">Преобразование</abbr> входных данных: из сети в Python-данные и типы. Из:
    * JSON.
    * Параметров пути.
    * Query-параметров.
    * Куки.
    * Заголовков.
    * Форм.
    * Файлов.
* <abbr title="также известно как: сериализация, парсинг, маршаллинг">Преобразование</abbr> выходных данных: из Python-данных и типов в сетевые данные (как JSON):
    * Преобразование типов Python (`str`, `int`, `float`, `bool`, `list` и др.).
    * Объекты `datetime`.
    * Объекты `UUID`.
    * Модели баз данных.
    * ...и многое другое.
* Автоматическая интерактивная документация API, включая 2 альтернативных интерфейса:
    * Swagger UI.
    * ReDoc.

---

Возвращаясь к предыдущему примеру, **FastAPI** будет:

* Проверять наличие `item_id` в пути для запросов `GET` и `PUT`.
* Проверять, что `item_id` имеет тип `int` для запросов `GET` и `PUT`.
    * Если нет — клиент получит полезную, понятную ошибку.
* Проверять наличие необязательного query-параметра `q` (как в `http://127.0.0.1:8000/items/foo?q=somequery`) для `GET`.
    * Так как `q` объявлен с `= None`, он необязателен.
    * Без `None` он был бы обязательным (как тело запроса с `PUT`).
* Для `PUT`-запросов на `/items/{item_id}` читать тело как JSON:
    * Проверять наличие обязательного атрибута `name` типа `str`.
    * Проверять наличие обязательного атрибута `price` типа `float`.
    * Проверять наличие необязательного атрибута `is_offer` типа `bool`, если он присутствует.
    * Всё это работает и для глубоко вложенных JSON.
* Автоматически конвертировать из и в JSON.
* Документировать всё с помощью OpenAPI, что можно использовать:
    * В интерактивных системах документации.
    * Для автоматической генерации клиентского кода на разных языках.
* Предоставлять 2 веб-интерфейса для интерактивной документации.

---

Это только верхушка айсберга, но вы уже видите, как это работает.

Попробуйте изменить строку:

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...с:

```Python
        ... "item_name": item.name ...
```

...на:

```Python
        ... "item_price": item.price ...
```

...и посмотрите, как ваш редактор автоматически подскажет атрибуты и их типы:

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

Для более полного примера с большим количеством возможностей смотрите <a href="https://fastapi.tiangolo.com/tutorial/">Руководство - Tutorial</a>.

**Спойлер**: tutorial - user guide включает:

* Объявление **параметров** из других источников, таких как: **заголовки**, **куки**, **поля форм** и **файлы**.
* Как задать **валидационные ограничения** — например, `maximum_length` или `regex`.
* Очень мощную и простую систему **<abbr title="также известна как компоненты, ресурсы, провайдеры, сервисы, инжектируемые">внедрения зависимостей</abbr>**.
* Безопасность и аутентификацию, включая поддержку **OAuth2** с **JWT-токенами** и **HTTP Basic**.
* Более продвинутые (но такие же простые) техники для объявления **глубоко вложенных JSON-моделей** (благодаря Pydantic).
* Интеграцию **GraphQL** с <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> и другими библиотеками.
* Множество дополнительных возможностей (благодаря Starlette), например:
    * **WebSockets**
    * очень простые тесты на основе HTTPX и `pytest`
    * **CORS**
    * **Cookie Sessions**
    * ...и многое другое.

## Производительность

Независимые бенчмарки TechEmpower показывают, что приложения **FastAPI** под Uvicorn <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">одни из самых быстрых среди Python-фреймворков</a>, уступая только самим Starlette и Uvicorn (используются внутри FastAPI). (*)

Подробнее см. раздел <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">Бенчмарки</a>.

## Зависимости

FastAPI зависит от Pydantic и Starlette.

### `standard` зависимости

При установке FastAPI с помощью `pip install "fastapi[standard]"` устанавливается группа опциональных зависимостей `standard`:

Используется Pydantic:

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> — для валидации email-адресов.

Используется Starlette:

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> — необходим, если вы хотите использовать `TestClient`.
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> — необходим, если вы хотите использовать стандартную конфигурацию шаблонов.
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> — необходим, если вы хотите поддерживать <abbr title="преобразование строки из HTTP-запроса в Python-данные">парсинг</abbr> форм через `request.form()`.

Используется FastAPI / Starlette:

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> — сервер, который загружает и обслуживает ваше приложение. Включает `uvicorn[standard]`, с зависимостями (например, `uvloop`) для высокой производительности.
* `fastapi-cli` — для предоставления команды `fastapi`.

### Без `standard` зависимостей

Если вы не хотите включать опциональные зависимости `standard`, установите FastAPI командой `pip install fastapi` вместо `pip install "fastapi[standard]"`.

### Дополнительные опциональные зависимости

Существуют дополнительные зависимости, которые вы можете установить.

Дополнительные опциональные зависимости Pydantic:

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> — для управления настройками.
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> — дополнительные типы для использования с Pydantic.

Дополнительные опциональные зависимости FastAPI:

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> — необходим, если вы хотите использовать `ORJSONResponse`.
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> — необходим, если вы хотите использовать `UJSONResponse`.

## Лицензия

Этот проект распространяется на условиях лицензии MIT.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---