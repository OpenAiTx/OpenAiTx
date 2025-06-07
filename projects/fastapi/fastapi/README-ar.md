<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>إطار عمل FastAPI، عالي الأداء، سهل التعلم، سريع في البرمجة، جاهز للإنتاج</em>
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

**التوثيق**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**كود المصدر**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI هو إطار عمل ويب حديث وسريع (عالي الأداء) لبناء واجهات برمجة التطبيقات (APIs) باستخدام بايثون، ويعتمد على تلميحات أنواع بايثون القياسية.

الميزات الرئيسية هي:

* **سريع**: أداء عالي جداً، يقارن بـ **NodeJS** و **Go** (بفضل Starlette وPydantic). [من أسرع أطر بايثون المتوفرة](#performance).
* **سريع في البرمجة**: يزيد سرعة تطوير الميزات بحوالي 200% إلى 300%. *
* **أخطاء أقل**: يقلل حوالي 40% من الأخطاء البشرية (أخطاء المطورين). *
* **بديهي**: دعم رائع من المحررات. <abbr title="المعروفة أيضاً بالإكمال التلقائي، IntelliSense">إكمال تلقائي</abbr> في كل مكان. وقت أقل في تصحيح الأخطاء.
* **سهل**: مصمم ليكون سهل الاستخدام والتعلم. وقت أقل في قراءة التوثيقات.
* **مختصر**: تقليل تكرار الشيفرة. ميزات متعددة من كل تعريف معلمة. أخطاء أقل.
* **متين**: احصل على شيفرة جاهزة للإنتاج. مع توثيق تفاعلي تلقائي.
* **معتمد على المعايير**: مبني (ومتوافق بالكامل) مع المعايير المفتوحة لواجهات برمجة التطبيقات: <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a> (المعروفة سابقاً بـ Swagger) و <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>.

<small>* تقدير مبني على اختبارات لفريق تطوير داخلي، لبناء تطبيقات إنتاجية.</small>

## الرعاة

<!-- sponsors -->

<a href="https://blockbee.io?ref=fastapi" target="_blank" title="بوابة دفع العملات الرقمية BlockBee"><img src="https://fastapi.tiangolo.com/img/sponsors/blockbee.png"></a>
<a href="https://platform.sh/try-it-now/?utm_source=fastapi-signup&utm_medium=banner&utm_campaign=FastAPI-signup-June-2023" target="_blank" title="ابن وشغل ووسّع تطبيقاتك على منصة حديثة وآمنة وموثوقة"><img src="https://fastapi.tiangolo.com/img/sponsors/platform-sh.png"></a>
<a href="https://www.porter.run" target="_blank" title="انشر FastAPI على AWS بنقرات قليلة"><img src="https://fastapi.tiangolo.com/img/sponsors/porter.png"></a>
<a href="https://github.com/scalar/scalar/?utm_source=fastapi&utm_medium=website&utm_campaign=main-badge" target="_blank" title="Scalar: مراجع واجهات برمجة التطبيقات الجميلة من ملفات Swagger/OpenAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/scalar.svg"></a>
<a href="https://www.propelauth.com/?utm_source=fastapi&utm_campaign=1223&utm_medium=mainbadge" target="_blank" title="المصادقة، إدارة المستخدمين والمزيد لمنتجك B2B"><img src="https://fastapi.tiangolo.com/img/sponsors/propelauth.png"></a>
<a href="https://zuplo.link/fastapi-gh" target="_blank" title="Zuplo: انشر، وأمّن، ووثق، وربح من FastAPI الخاص بك"><img src="https://fastapi.tiangolo.com/img/sponsors/zuplo.png"></a>
<a href="https://liblab.com?utm_source=fastapi" target="_blank" title="liblab - أنشئ SDKs من FastAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/liblab.png"></a>
<a href="https://docs.render.com/deploy-fastapi?utm_source=deploydoc&utm_medium=referral&utm_campaign=fastapi" target="_blank" title="انشر ووسّع أي تطبيق ويب متكامل على Render. ركز على بناء التطبيقات، وليس البنية التحتية."><img src="https://fastapi.tiangolo.com/img/sponsors/render.svg"></a>
<a href="https://www.coderabbit.ai/?utm_source=fastapi&utm_medium=badge&utm_campaign=fastapi" target="_blank" title="قلل وقت مراجعة الشيفرة والأخطاء للنصف مع CodeRabbit"><img src="https://fastapi.tiangolo.com/img/sponsors/coderabbit.png"></a>
<a href="https://subtotal.com/?utm_source=fastapi&utm_medium=sponsorship&utm_campaign=open-source" target="_blank" title="المعيار الذهبي في ربط حسابات البيع بالتجزئة"><img src="https://fastapi.tiangolo.com/img/sponsors/subtotal.svg"></a>
<a href="https://databento.com/" target="_blank" title="ادفع حسب الاستخدام لبيانات السوق"><img src="https://fastapi.tiangolo.com/img/sponsors/databento.svg"></a>
<a href="https://speakeasy.com?utm_source=fastapi+repo&utm_medium=github+sponsorship" target="_blank" title="SDKs لواجهتك البرمجية | Speakeasy"><img src="https://fastapi.tiangolo.com/img/sponsors/speakeasy.png"></a>
<a href="https://www.svix.com/" target="_blank" title="Svix - Webhooks كخدمة"><img src="https://fastapi.tiangolo.com/img/sponsors/svix.svg"></a>
<a href="https://www.stainlessapi.com/?utm_source=fastapi&utm_medium=referral" target="_blank" title="Stainless | أنشئ SDKs من الطراز الأول"><img src="https://fastapi.tiangolo.com/img/sponsors/stainless.png"></a>
<a href="https://www.permit.io/blog/implement-authorization-in-fastapi?utm_source=github&utm_medium=referral&utm_campaign=fastapi" target="_blank" title="تفويض دقيق لـ FastAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/permit.png"></a>
<a href="https://www.interviewpal.com/?utm_source=fastapi&utm_medium=open-source&utm_campaign=dev-hiring" target="_blank" title="InterviewPal - مدرب مقابلات الذكاء الاصطناعي للمهندسين والمطورين"><img src="https://fastapi.tiangolo.com/img/sponsors/interviewpal.png"></a>
<a href="https://dribia.com/en/" target="_blank" title="Dribia - علم البيانات في متناولك"><img src="https://fastapi.tiangolo.com/img/sponsors/dribia.png"></a>

<!-- /sponsors -->

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">رعاة آخرون</a>

## الآراء

"_[...] أستخدم **FastAPI** كثيراً هذه الأيام. [...] في الواقع أخطط لاستخدامه لجميع خدمات **تعلم الآلة** في فريقي في **Microsoft**. بعضها سيتم دمجه في منتج **Windows** الأساسي وبعض منتجات **Office**._"

<div style="text-align: right; margin-right: 10%;">كبير خان - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(مرجع)</small></a></div>

---

"_اعتمدنا مكتبة **FastAPI** لإنشاء خادم **REST** يمكن الاستعلام منه للحصول على **تنبؤات**. [من أجل Ludwig]_"

<div style="text-align: right; margin-right: 10%;">بييرو مولينو، ياروسلاف دودين، وساي سومانث ميرايالا - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(مرجع)</small></a></div>

---

"_يسر **Netflix** أن تعلن عن إصدار مفتوح المصدر لإطار عمل إدارة الأزمات لدينا: **Dispatch**! [تم بناؤه باستخدام **FastAPI**]_"

<div style="text-align: right; margin-right: 10%;">كيفن غليسون، مارك فيلانوفا، فورست مونسن - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(مرجع)</small></a></div>

---

"_أنا متحمس للغاية بشأن **FastAPI**. إنه ممتع للغاية!_"

<div style="text-align: right; margin-right: 10%;">براين أوكن - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">مقدم بودكاست Python Bytes</a></strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(مرجع)</small></a></div>

---

"_بصراحة، ما بنيته يبدو متيناً للغاية واحترافياً. في كثير من النواحي، هو ما كنت أريده لـ **Hug** - من الملهم حقًا رؤية شخص يبني ذلك._"

<div style="text-align: right; margin-right: 10%;">تيموثي كروسلي - <strong><a href="https://github.com/hugapi/hug" target="_blank">منشئ Hug</a></strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(مرجع)</small></a></div>

---

"_إذا كنت تبحث عن تعلم إطار عمل **حديث** لبناء واجهات REST، جرب **FastAPI** [...] إنه سريع، سهل الاستخدام وسهل التعلم [...]_"

"_انتقلنا إلى استخدام **FastAPI** لواجهات برمجة التطبيقات الخاصة بنا [...] أعتقد أنك ستحبه [...]_"

<div style="text-align: right; margin-right: 10%;">إينيس مونتاني - ماثيو هونيبال - <strong><a href="https://explosion.ai" target="_blank">مؤسسو Explosion AI</a> - <a href="https://spacy.io" target="_blank">منشئو spaCy</a></strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(مرجع)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(مرجع)</small></a></div>

---

"_إذا كان أي شخص يبحث عن بناء واجهة برمجة تطبيقات بايثون للإنتاج، أوصي بشدة بـ **FastAPI**. إنه **مصمم بشكل جميل**، **سهل الاستخدام** و **قابل للتوسيع بدرجة كبيرة**، أصبح **عنصراً أساسياً** في استراتيجية تطويرنا المعتمدة على الواجهات ويدير العديد من الأتمتات والخدمات مثل مهندس TAC الافتراضي لدينا._"

<div style="text-align: right; margin-right: 10%;">ديون بيلسبوري - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(مرجع)</small></a></div>

---

## **Typer**، FastAPI لواجهات الأوامر

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

إذا كنت تبني تطبيق <abbr title="واجهة أوامر نصية">CLI</abbr> ليستخدم في الطرفية بدلاً من واجهة برمجة تطبيقات ويب، اطلع على <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a>.

**Typer** هو الأخ الأصغر لـ FastAPI. ومصمم ليكون **FastAPI لواجهات الأوامر**. ⌨️ 🚀

## المتطلبات

FastAPI يقف على أكتاف العمالقة:

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> للأجزاء المتعلقة بالويب.
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> للأجزاء المتعلقة بالبيانات.

## التثبيت

أنشئ وفعّل <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">بيئة افتراضية</a> ثم ثبت FastAPI:

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**ملاحظة**: تأكد من وضع `"fastapi[standard]"` بين علامات اقتباس لضمان عمله في جميع الطرفيات.

## مثال

### أنشئه

أنشئ ملفًا باسم `main.py` يحتوي على:

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
<summary>أو استخدم <code>async def</code>...</summary>

إذا كان كودك يستخدم `async` / `await`، استخدم `async def`:

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

**ملاحظة**:

إذا لم تكن تعلم، اطلع على قسم _"على عجلة؟"_ حول <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` و `await` في التوثيق</a>.

</details>

### شغّله

شغّل الخادم عبر الأمر:

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
<summary>حول الأمر <code>fastapi dev main.py</code>...</summary>

يقرأ أمر `fastapi dev` ملف `main.py` الخاص بك، ويكتشف تطبيق **FastAPI** فيه، ويشغّل خادمًا باستخدام <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a>.

افتراضيًا، يبدأ `fastapi dev` مع تمكين إعادة التحميل التلقائي لتطوير محلي.

يمكنك قراءة المزيد عنه في <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">توثيق FastAPI CLI</a>.

</details>

### افحصه

افتح متصفحك على <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>.

سترى استجابة JSON كالتالي:

```JSON
{"item_id": 5, "q": "somequery"}
```

لقد أنشأت واجهة برمجة تطبيقات:

* تستقبل طلبات HTTP على المسارين `/` و `/items/{item_id}`.
* كلا المسارين يدعمان عمليات `GET` (<em>طرق HTTP</em>).
* المسار `/items/{item_id}` يحتوي على <em>معامل مسار</em> `item_id` يجب أن يكون من نوع `int`.
* المسار `/items/{item_id}` يحتوي على <em>معامل استعلام</em> اختياري `q` من نوع `str`.

### توثيق تفاعلي للواجهة

الآن انتقل إلى <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

سترى توثيقًا تفاعليًا تلقائيًا للواجهة (يوفره <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a>):

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### توثيق بديل للواجهة

والآن، انتقل إلى <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

سترى توثيقًا تلقائيًا بديلاً (يوفره <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a>):

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## ترقية المثال

الآن عدّل الملف `main.py` لاستقبال جسم من طلب `PUT`.

عرّف الجسم باستخدام أنواع بايثون القياسية، بفضل Pydantic.

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

سيقوم خادم `fastapi dev` بإعادة التحميل تلقائيًا.

### ترقية التوثيق التفاعلي للواجهة

الآن انتقل إلى <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

* سيتم تحديث توثيق الواجهة التفاعلي تلقائيًا، متضمناً الجسم الجديد:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* انقر على زر "Try it out"، حيث يمكنك تعبئة المعاملات والتفاعل مع الواجهة مباشرة:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* ثم انقر على زر "Execute"، حيث ستتواصل الواجهة مع الواجهة البرمجية، ترسل المعاملات، تستقبل النتائج وتعرضها:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### ترقية التوثيق البديل للواجهة

والآن، انتقل إلى <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

* سيعكس التوثيق البديل أيضًا معامل الاستعلام الجديد والجسم:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### ملخص

باختصار، تعلن **مرة واحدة** عن أنواع المعاملات، الجسم، إلخ كمعاملات دوال.

تفعل ذلك باستخدام أنواع بايثون الحديثة القياسية.

لا تحتاج لتعلم صياغة جديدة، أو أساليب أو أصناف مكتبة معينة، إلخ.

فقط **بايثون** القياسي.

مثلاً، للمتغير من نوع `int`:

```Python
item_id: int
```

أو لنموذج `Item` أكثر تعقيداً:

```Python
item: Item
```

...وبتلك التعريفات تحصل على:

* دعم المحرر، بما في ذلك:
    * الإكمال التلقائي.
    * فحص الأنواع.
* التحقق من صحة البيانات:
    * أخطاء تلقائية وواضحة عندما تكون البيانات غير صالحة.
    * تحقق حتى للكائنات JSON المتداخلة بعمق.
* <abbr title="المعروفة أيضاً: التسلسل، التحليل، marshalling">تحويل</abbr> بيانات الإدخال: من الشبكة إلى بيانات وأنواع بايثون. قراءة من:
    * JSON.
    * معاملات المسار.
    * معاملات الاستعلام.
    * الكوكيز.
    * الرؤوس.
    * النماذج.
    * الملفات.
* <abbr title="المعروفة أيضاً: التسلسل، التحليل، marshalling">تحويل</abbr> بيانات الإخراج: تحويل من بيانات وأنواع بايثون إلى بيانات الشبكة (كـ JSON):
    * تحويل أنواع بايثون (`str`, `int`, `float`, `bool`, `list`, إلخ).
    * كائنات `datetime`.
    * كائنات `UUID`.
    * نماذج قاعدة البيانات.
    * ...والمزيد.
* توثيق تفاعلي تلقائي لواجهة برمجة التطبيقات، يشمل واجهتين بديلتين:
    * Swagger UI.
    * ReDoc.

---

بالعودة إلى المثال السابق، سيقوم **FastAPI** بـ:

* التحقق من وجود `item_id` في المسار لطلبات `GET` و `PUT`.
* التحقق من أن `item_id` من نوع `int` في طلبات `GET` و `PUT`.
    * إذا لم يكن كذلك، سيظهر للعميل خطأ واضح ومفيد.
* التحقق من وجود معامل استعلام اختياري باسم `q` (مثل `http://127.0.0.1:8000/items/foo?q=somequery`) في طلبات `GET`.
    * بما أن المعامل `q` معرف بـ `= None`، فهو اختياري.
    * بدون `None` سيكون مطلوبًا (مثل الجسم في حالة `PUT`).
* لطلبات `PUT` على `/items/{item_id}`، قراءة الجسم كـ JSON:
    * التحقق من وجود الخاصية المطلوبة `name` من نوع `str`.
    * التحقق من وجود الخاصية المطلوبة `price` من نوع `float`.
    * التحقق من وجود الخاصية الاختيارية `is_offer`، إذا وجدت، يجب أن تكون من نوع `bool`.
    * كل هذا يعمل أيضًا مع كائنات JSON المتداخلة.
* التحويل من وإلى JSON تلقائيًا.
* توثيق كل شيء باستخدام OpenAPI، ويمكن استخدامه من قبل:
    * أنظمة التوثيق التفاعلي.
    * أنظمة توليد الشيفرة العميلة التلقائية، للعديد من اللغات.
* تقديم واجهتين تفاعليتين لتوثيق الواجهة مباشرة.

---

لقد استعرضنا الأساسيات فقط، لكنك حصلت بالفعل على فكرة عن كيفية عمل كل شيء.

جرّب تغيير السطر:

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...من:

```Python
        ... "item_name": item.name ...
```

...إلى:

```Python
        ... "item_price": item.price ...
```

...وشاهد كيف يكمل المحرر الخاص بك الخصائص تلقائياً ويعرف أنواعها:

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

للحصول على مثال أكثر اكتمالاً يشمل المزيد من الميزات، راجع <a href="https://fastapi.tiangolo.com/tutorial/">الدليل التعليمي - دليل المستخدم</a>.

**تنبيه: الدليل التعليمي يشمل:**

* إعلان **المعاملات** من أماكن مختلفة مثل: **الرؤوس**، **الكوكيز**، **حقول النماذج** و**الملفات**.
* كيفية ضبط **قيود التحقق** مثل `maximum_length` أو `regex`.
* نظام **<abbr title="المعروفة أيضاً بالمكونات، الموارد، المزودين، الخدمات، القابلة للحقن">حقن التبعيات</abbr>** قوي وسهل الاستخدام.
* الأمان والمصادقة، بما في ذلك دعم **OAuth2** مع **رموز JWT** و **مصادقة HTTP Basic**.
* تقنيات أكثر تقدماً (لكنها سهلة أيضاً) لتعريف **نماذج JSON متداخلة بعمق** (بفضل Pydantic).
* تكامل **GraphQL** مع <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> ومكتبات أخرى.
* العديد من الميزات الإضافية (بفضل Starlette) مثل:
    * **WebSockets**
    * اختبارات سهلة جداً مبنية على HTTPX و `pytest`
    * **CORS**
    * **جلسات الكوكيز**
    * ...والمزيد.

## الأداء

تظهر اختبارات TechEmpower المستقلة أن تطبيقات **FastAPI** التي تعمل تحت Uvicorn هي <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">من أسرع أطر بايثون المتوفرة</a>، تلي فقط Starlette وUvicorn (المستخدمة داخلياً بواسطة FastAPI). (*)

لمزيد من الفهم، راجع قسم <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">اختبارات الأداء</a>.

## الاعتمادات

يعتمد FastAPI على Pydantic وStarlette.

### اعتمادات `standard`

عند تثبيت FastAPI باستخدام `pip install "fastapi[standard]"` يأتي مع مجموعة `standard` من الاعتمادات الاختيارية:

يستخدمها Pydantic:

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - للتحقق من صحة البريد الإلكتروني.

يستخدمها Starlette:

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - مطلوب إذا كنت تريد استخدام `TestClient`.
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - مطلوب إذا كنت تريد استخدام إعداد القوالب الافتراضي.
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - مطلوب إذا كنت تريد دعم <abbr title="تحويل السلسلة التي تأتي من طلب HTTP إلى بيانات بايثون">"تحليل"</abbr> النماذج، مع `request.form()`.

يستخدمها FastAPI / Starlette:

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - لخادم تشغيل وتقديم تطبيقك. يتضمن ذلك `uvicorn[standard]`، والذي يتضمن بعض الاعتمادات (مثل `uvloop`) اللازمة لأداء عالي.
* `fastapi-cli` - لتوفير أمر `fastapi`.

### بدون اعتمادات `standard`

إذا كنت لا ترغب في تضمين الاعتمادات الاختيارية `standard`، يمكنك التثبيت باستخدام `pip install fastapi` بدلاً من `pip install "fastapi[standard]"`.

### اعتمادات اختيارية إضافية

هناك بعض الاعتمادات الإضافية التي قد ترغب في تثبيتها.

اعتمادات Pydantic الاختيارية الإضافية:

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - لإدارة الإعدادات.
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - لأنواع إضافية لاستخدامها مع Pydantic.

اعتمادات FastAPI الاختيارية الإضافية:

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - مطلوب إذا كنت تريد استخدام `ORJSONResponse`.
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - مطلوب إذا كنت تريد استخدام `UJSONResponse`.

## الرخصة

هذا المشروع مرخص بموجب شروط رخصة MIT.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---