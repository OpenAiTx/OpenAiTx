<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>فریمورک FastAPI، با عملکرد بالا، یادگیری آسان، کدنویسی سریع، آماده برای محیط تولید</em>
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

**مستندات**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**کد منبع**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI یک فریمورک مدرن و سریع (با عملکرد بالا) برای ساخت APIها با پایتون، مبتنی بر تایپ هینت‌های استاندارد پایتون است.

ویژگی‌های کلیدی:

* **سریع**: عملکرد بسیار بالا، هم‌تراز با **NodeJS** و **Go** (به لطف Starlette و Pydantic). [یکی از سریع‌ترین فریمورک‌های پایتون موجود](#performance).
* **کدنویسی سریع**: سرعت توسعه قابلیت‌ها را حدود ۲۰۰٪ تا ۳۰۰٪ افزایش دهید. *
* **باگ کمتر**: حدود ۴۰٪ خطاهای انسانی (توسعه‌دهنده) را کاهش دهید. *
* **مستقیم و شهودی**: پشتیبانی عالی از ویرایشگر. <abbr title="همچنین به عنوان auto-complete، autocompletion، IntelliSense شناخته می‌شود">تکمیل خودکار</abbr> همه جا. زمان کمتری برای دیباگ.
* **آسان**: طراحی شده برای استفاده و یادگیری آسان. زمان کمتر برای خواندن مستندات.
* **کوتاه**: حداقل تکرار کد. قابلیت‌های متعدد از هر تعریف پارامتر. باگ کمتر.
* **قدرتمند**: کد آماده برای محیط تولید. با مستندسازی تعاملی خودکار.
* **استاندارد محور**: مبتنی بر استانداردهای باز APIها و کاملاً سازگار با آن‌ها: <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a> (که قبلاً Swagger نامیده می‌شد) و <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>.

<small>* برآورد بر اساس تست‌های تیم توسعه داخلی، هنگام ساخت برنامه‌های تولیدی.</small>

## حامیان مالی

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

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">سایر حامیان مالی</a>

## نظرات

"_[...] این روزها از **FastAPI** خیلی استفاده می‌کنم. [...] در واقع قرار است برای تمام سرویس‌های **یادگیری ماشین** تیمم در **مایکروسافت** از آن استفاده کنم. بعضی از آن‌ها به محصول اصلی **ویندوز** و برخی محصولات **آفیس** یکپارچه می‌شوند._"

<div style="text-align: right; margin-right: 10%;">کبیر خان - <strong>مایکروسافت</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(منبع)</small></a></div>

---

"_ما کتابخانه **FastAPI** را برای راه‌اندازی یک سرور **REST** به کار گرفتیم که می‌تواند برای دریافت **پیش‌بینی‌ها** مورد پرس‌وجو قرار گیرد. [برای Ludwig]_"

<div style="text-align: right; margin-right: 10%;">پیرو مولینو، یاروسلاو دودین و سای سومانت میرایالا - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(منبع)</small></a></div>

---

"_**نتفلیکس** با خوشحالی انتشار متن باز فریمورک ارکستراسیون **مدیریت بحران** خود را اعلام می‌کند: **Dispatch**! [ساخته‌شده با **FastAPI**]_"

<div style="text-align: right; margin-right: 10%;">کوین گلیسون، مارک ویلانوا، فارست مونسن - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(منبع)</small></a></div>

---

"_واقعاً از FastAPI هیجان‌زده‌ام. خیلی سرگرم‌کننده است!_"

<div style="text-align: right; margin-right: 10%;">برایان اوکن - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">مجری پادکست Python Bytes</a></strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(منبع)</small></a></div>

---

"_صادقانه، چیزی که ساختی واقعاً محکم و صیقلی به نظر می‌رسد. در بسیاری جهات، همان چیزی است که می‌خواستم **Hug** باشد – واقعاً الهام‌بخش است که ببینم کسی آن را ساخته است._"

<div style="text-align: right; margin-right: 10%;">تیموتی کراسلی - <strong><a href="https://github.com/hugapi/hug" target="_blank">خالق Hug</a></strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(منبع)</small></a></div>

---

"_اگر به دنبال یادگیری یک **فریمورک مدرن** برای ساخت REST API هستید، **FastAPI** را امتحان کنید [...] سریع است، استفاده از آن و یادگیری‌اش آسان است [...]_"

"_ما به **FastAPI** برای APIهای خود سوئیچ کردیم [...] فکر می‌کنم شما هم خوشتان بیاید [...]_"

<div style="text-align: right; margin-right: 10%;">اینس مونتانی - متیو هانیبال - <strong><a href="https://explosion.ai" target="_blank">بنیان‌گذاران Explosion AI</a> - <a href="https://spacy.io" target="_blank">خالقان spaCy</a></strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(منبع)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(منبع)</small></a></div>

---

"_اگر کسی به دنبال ساخت یک API پایتون تولیدی است، **FastAPI** را قویاً توصیه می‌کنم. **به زیبایی طراحی شده**، **استفاده از آن ساده** و **بسیار مقیاس‌پذیر** است، به یک **جزء کلیدی** در استراتژی توسعه API First ما تبدیل شده و بسیاری از اتوماسیون‌ها و سرویس‌هایی مانند مهندس TAC مجازی ما را هدایت می‌کند._"

<div style="text-align: right; margin-right: 10%;">دیون پیلزبوری - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(منبع)</small></a></div>

---

## **Typer**، FastAPI برای CLIها

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

اگر برنامه‌ای برای خط فرمان (<abbr title="Command Line Interface">CLI</abbr>) می‌سازید که به جای API وب در ترمینال استفاده شود، <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a> را بررسی کنید.

**Typer** برادر کوچک FastAPI است و قرار است **FastAPI برای CLIها** باشد. ⌨️ 🚀

## پیش‌نیازها

FastAPI بر شانه‌های غول‌ها ایستاده است:

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> برای بخش‌های وب.
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> برای بخش داده.

## نصب

یک <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">محیط مجازی</a> ایجاد و فعال کرده و سپس FastAPI را نصب کنید:

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**نکته**: مطمئن شوید که `"fastapi[standard]"` را داخل کوتیشن قرار دهید تا در تمام ترمینال‌ها به درستی کار کند.

## مثال

### ایجاد فایل

فایلی به نام `main.py` ایجاد کنید با محتوای زیر:

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
<summary>یا از <code>async def</code> استفاده کنید...</summary>

اگر کد شما از `async` / `await` استفاده می‌کند، از `async def` بهره ببرید:

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

**نکته**:

اگر نمی‌دانید، بخش _"عجله دارید؟"_ درباره <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` و `await` در مستندات</a> را ببینید.

</details>

### اجرا

سرور را با دستور زیر اجرا کنید:

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
<summary>درباره دستور <code>fastapi dev main.py</code>...</summary>

دستور `fastapi dev` فایل `main.py` شما را می‌خواند، اپ FastAPI را شناسایی کرده و یک سرور با استفاده از <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a> راه‌اندازی می‌کند.

به طور پیش‌فرض، `fastapi dev` با قابلیت auto-reload برای توسعه محلی اجرا می‌شود.

اطلاعات بیشتر را در <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">مستندات FastAPI CLI</a> بخوانید.

</details>

### بررسی

مرورگر خود را باز کنید و به آدرس <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a> بروید.

پاسخ JSON را به صورت زیر خواهید دید:

```JSON
{"item_id": 5, "q": "somequery"}
```

شما یک API ساخته‌اید که:

* درخواست‌های HTTP را در مسیرهای `/` و `/items/{item_id}` دریافت می‌کند.
* هر دو مسیر عملیات `GET` (<em>متدهای</em> HTTP) را می‌گیرند.
* مسیر `/items/{item_id}` یک پارامتر مسیر به نام `item_id` دارد که باید از نوع `int` باشد.
* مسیر `/items/{item_id}` یک پارامتر اختیاری query به نام `q` از نوع `str` دارد.

### مستندات تعاملی API

اکنون به آدرس <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a> بروید.

مستندسازی تعاملی API را خواهید دید (ارائه‌شده توسط <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a>):

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### مستندات جایگزین API

و حالا به آدرس <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a> بروید.

مستندسازی جایگزین را خواهید دید (ارائه‌شده توسط <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a>):

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## ارتقاء مثال

اکنون فایل `main.py` را ویرایش کنید تا بدنه‌ای از درخواست `PUT` دریافت کند.

بدنه را با استفاده از تایپ‌های استاندارد پایتون (به لطف Pydantic) تعریف کنید.

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

سرور `fastapi dev` باید به طور خودکار ری‌لود شود.

### ارتقاء مستندات تعاملی API

اکنون به آدرس <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a> بروید.

* مستندسازی تعاملی API به طور خودکار به‌روزرسانی می‌شود و بدنه جدید را نمایش می‌دهد:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* روی دکمه "Try it out" کلیک کنید تا بتوانید پارامترها را پر کرده و مستقیماً با API تعامل داشته باشید:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* سپس روی دکمه "Execute" کلیک کنید، رابط کاربری با API شما ارتباط برقرار می‌کند، پارامترها را ارسال می‌کند، نتایج را می‌گیرد و روی صفحه نمایش می‌دهد:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### ارتقاء مستندات جایگزین API

و حالا به آدرس <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a> بروید.

* مستندات جایگزین نیز پارامتر query و بدنه جدید را نشان خواهد داد:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### جمع‌بندی

خلاصه اینکه، شما فقط **یک بار** نوع پارامترها، بدنه و غیره را به عنوان پارامتر تابع تعریف می‌کنید.

این کار را با تایپ‌های استاندارد و مدرن پایتون انجام می‌دهید.

نیازی به یادگیری سینتکس جدید، متدها یا کلاس‌های یک کتابخانه خاص و غیره ندارید.

فقط **پایتون** استاندارد.

مثلاً برای یک `int`:

```Python
item_id: int
```

یا برای یک مدل پیچیده‌تر مثل `Item`:

```Python
item: Item
```

...و فقط با همین تعریف ساده، این قابلیت‌ها را به دست می‌آورید:

* پشتیبانی ویرایشگر، شامل:
    * تکمیل خودکار.
    * بررسی نوع داده.
* اعتبارسنجی داده:
    * خطاهای خودکار و شفاف وقتی داده نامعتبر باشد.
    * اعتبارسنجی حتی برای آبجکت‌های JSON تو در تو.
* <abbr title="همچنین به عنوان: serialization، parsing، marshalling شناخته می‌شود">تبدیل</abbr> داده‌های ورودی: تبدیل از شبکه به داده و نوع پایتون. خواندن از:
    * JSON.
    * پارامترهای مسیر.
    * پارامترهای query.
    * کوکی‌ها.
    * هدرها.
    * فرم‌ها.
    * فایل‌ها.
* <abbr title="همچنین به عنوان: serialization، parsing، marshalling شناخته می‌شود">تبدیل</abbr> داده‌های خروجی: تبدیل داده و نوع پایتون به داده شبکه (به صورت JSON):
    * تبدیل تایپ‌های پایتون (`str`، `int`، `float`، `bool`، `list` و غیره).
    * آبجکت‌های `datetime`.
    * آبجکت‌های `UUID`.
    * مدل‌های پایگاه داده.
    * ...و بسیاری دیگر.
* مستندسازی تعاملی خودکار API شامل دو رابط کاربری جایگزین:
    * Swagger UI.
    * ReDoc.

---

با بازگشت به مثال کد قبلی، **FastAPI** موارد زیر را انجام می‌دهد:

* اعتبارسنجی وجود `item_id` در مسیر برای درخواست‌های `GET` و `PUT`.
* اعتبارسنجی اینکه `item_id` از نوع `int` باشد برای درخواست‌های `GET` و `PUT`.
    * اگر نباشد، کلاینت یک خطای مفید و شفاف می‌بیند.
* بررسی وجود پارامتر اختیاری query به نام `q` (مانند `http://127.0.0.1:8000/items/foo?q=somequery`) برای درخواست‌های `GET`.
    * چون پارامتر `q` با `= None` تعریف شده، اختیاری است.
    * بدون `None`، پارامتر اجباری می‌شد (مانند بدنه در حالت `PUT`).
* برای درخواست‌های `PUT` به `/items/{item_id}`، بدنه را به صورت JSON می‌خواند:
    * بررسی اینکه یک ویژگی اجباری به نام `name` از نوع `str` دارد.
    * بررسی اینکه یک ویژگی اجباری به نام `price` دارد که باید `float` باشد.
    * بررسی اینکه یک ویژگی اختیاری به نام `is_offer` دارد که اگر موجود باشد باید `bool` باشد.
    * همه این موارد برای آبجکت‌های JSON تو در تو نیز کار می‌کند.
* تبدیل خودکار از و به JSON.
* مستندسازی همه چیز با OpenAPI، که می‌تواند توسط:
    * سیستم‌های مستندسازی تعاملی.
    * سیستم‌های تولید خودکار کد کلاینت برای زبان‌های مختلف.
* ارائه دو رابط کاربری تعاملی مستندات به صورت مستقیم.

---

ما فقط سطح قضیه را خراش دادیم، اما شما ایده کلی کارکرد آن را گرفتید.

سعی کنید خط زیر را تغییر دهید:

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...از:

```Python
        ... "item_name": item.name ...
```

...به:

```Python
        ... "item_price": item.price ...
```

...و ببینید که ویرایشگر شما ویژگی‌ها را به طور خودکار تکمیل کرده و نوع آن‌ها را می‌داند:

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

برای یک مثال کامل‌تر همراه با قابلیت‌های بیشتر، <a href="https://fastapi.tiangolo.com/tutorial/">آموزش - راهنمای کاربر</a> را ببینید.

**هشدار لو رفتن داستان!**: آموزش - راهنمای کاربر شامل موارد زیر است:

* تعریف **پارامترها** از مکان‌های مختلف مانند: **هدرها**، **کوکی‌ها**، **فیلدهای فرم** و **فایل‌ها**.
* نحوه تعیین **محدودیت‌های اعتبارسنجی** مانند `maximum_length` یا `regex`.
* یک سیستم **تزریق وابستگی** بسیار قدرتمند و آسان برای استفاده (<abbr title="همچنین به عنوان components، resources، providers، services، injectables شناخته می‌شود">Dependency Injection</abbr>).
* امنیت و احراز هویت شامل پشتیبانی از **OAuth2** با توکن‌های **JWT** و احراز هویت **HTTP Basic**.
* تکنیک‌های پیشرفته‌تر (اما به همان اندازه آسان) برای تعریف **مدل‌های JSON تو در تو** (به لطف Pydantic).
* ادغام **GraphQL** با <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> و کتابخانه‌های دیگر.
* بسیاری قابلیت‌های اضافی (به لطف Starlette) مانند:
    * **WebSockets**
    * تست‌های بسیار آسان مبتنی بر HTTPX و `pytest`
    * **CORS**
    * **Cookie Sessions**
    * ...و موارد بیشتر.

## عملکرد (Performance)

بنچمارک‌های مستقل TechEmpower نشان می‌دهند که برنامه‌های **FastAPI** که با Uvicorn اجرا می‌شوند <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">جزو سریع‌ترین فریمورک‌های پایتون موجود هستند</a>، و فقط بعد از Starlette و Uvicorn (که داخلی توسط FastAPI استفاده می‌شوند) قرار دارند. (*)

برای درک بیشتر، بخش <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">بنچمارک‌ها</a> را ببینید.

## وابستگی‌ها

FastAPI به Pydantic و Starlette وابسته است.

### وابستگی‌های `standard`

وقتی FastAPI را با دستور `pip install "fastapi[standard]"` نصب می‌کنید، شامل گروه وابستگی‌های اختیاری `standard` نیز می‌شود:

مورد استفاده در Pydantic:

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - برای اعتبارسنجی ایمیل.

مورد استفاده در Starlette:

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - مورد نیاز اگر می‌خواهید از `TestClient` استفاده کنید.
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - مورد نیاز اگر می‌خواهید از پیکربندی قالب پیش‌فرض استفاده کنید.
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - مورد نیاز اگر می‌خواهید از <abbr title="تبدیل رشته دریافتی از درخواست HTTP به داده پایتون">تجزیه فرم</abbr> با `request.form()` پشتیبانی کنید.

مورد استفاده در FastAPI / Starlette:

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - برای سروری که برنامه شما را بارگذاری و ارائه می‌کند. این شامل `uvicorn[standard]` است که وابستگی‌هایی مانند `uvloop` را برای عملکرد بالا دارد.
* `fastapi-cli` - برای ارائه دستور `fastapi`.

### بدون وابستگی‌های `standard`

اگر نمی‌خواهید وابستگی‌های اختیاری `standard` را نصب کنید، می‌توانید با `pip install fastapi` به جای `pip install "fastapi[standard]"` نصب نمایید.

### وابستگی‌های اختیاری اضافی

برخی وابستگی‌های اضافی وجود دارد که ممکن است بخواهید نصب کنید.

وابستگی‌های اختیاری اضافی برای Pydantic:

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - برای مدیریت تنظیمات.
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - برای تایپ‌های اضافی قابل استفاده با Pydantic.

وابستگی‌های اختیاری اضافی برای FastAPI:

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - مورد نیاز اگر بخواهید از `ORJSONResponse` استفاده کنید.
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - مورد نیاز اگر بخواهید از `UJSONResponse` استفاده کنید.

## مجوز (License)

این پروژه تحت مجوز MIT منتشر شده است.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---