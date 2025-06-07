<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>FastAPI เฟรมเวิร์ก ประสิทธิภาพสูง เรียนรู้ง่าย เขียนโค้ดเร็ว พร้อมใช้งานในระดับโปรดักชัน</em>
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

**เอกสารประกอบ**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**ซอร์สโค้ด**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI เป็นเฟรมเวิร์กเว็บที่ทันสมัย เร็ว (ประสิทธิภาพสูง) สำหรับสร้าง API ด้วย Python โดยอิงกับ type hints มาตรฐานของ Python

คุณสมบัติเด่น:

* **เร็ว**: ประสิทธิภาพสูงมาก ใกล้เคียงกับ **NodeJS** และ **Go** (ขอบคุณ Starlette และ Pydantic) [หนึ่งในเฟรมเวิร์ก Python ที่เร็วที่สุด](#performance)
* **เขียนโค้ดเร็ว**: เพิ่มความเร็วในการพัฒนาฟีเจอร์ประมาณ 200% ถึง 300% *
* **บั๊กน้อยลง**: ลดข้อผิดพลาดจากนักพัฒนาประมาณ 40% *
* **เข้าใจง่าย**: รองรับ editor ได้ดี <abbr title="หรือที่รู้จักในชื่อ auto-complete, autocompletion, IntelliSense">Completion</abbr> ทุกที่ ใช้เวลาน้อยลงกับการ debug
* **ใช้งานง่าย**: ออกแบบมาให้ใช้งานและเรียนรู้ง่าย ใช้เวลาอ่านเอกสารน้อยลง
* **โค้ดสั้น**: ลดการเขียนโค้ดซ้ำซ้อน หลายฟีเจอร์จากการประกาศ parameter เดียวกัน บั๊กน้อยลง
* **แข็งแกร่ง**: ได้โค้ดที่พร้อมใช้งานในโปรดักชัน พร้อมเอกสาร interactive อัตโนมัติ
* **ยึดตามมาตรฐาน**: พัฒนาตาม (และเข้ากันได้กับ) มาตรฐานเปิดสำหรับ API: <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a> (หรือที่รู้จักในชื่อ Swagger) และ <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>

<small>* ประมาณการจากผลการทดสอบกับทีมพัฒนาภายใน ขณะสร้างแอปพลิเคชันโปรดักชัน</small>

## ผู้สนับสนุน

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

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">ผู้สนับสนุนรายอื่น</a>

## ความคิดเห็น

"_[...] ผมใช้ **FastAPI** เยอะมากช่วงนี้ [...] ผมวางแผนจะใช้มันกับบริการ **ML** ทั้งหมดของทีมที่ Microsoft บางบริการจะถูกรวมเข้ากับผลิตภัณฑ์หลักของ **Windows** และบางส่วนใน **Office** ด้วย_"

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(ref)</small></a></div>

---

"_เราเลือกใช้ไลบรารี **FastAPI** ในการเปิด REST server ที่สามารถ query เพื่อขอ **prediction** ได้ [สำหรับ Ludwig]_"

<div style="text-align: right; margin-right: 10%;">Piero Molino, Yaroslav Dudin, และ Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(ref)</small></a></div>

---

"_**Netflix** มีความยินดีที่จะประกาศเปิดซอร์สเฟรมเวิร์กจัดการวิกฤติของเรา: **Dispatch**! [สร้างด้วย **FastAPI**]_"

<div style="text-align: right; margin-right: 10%;">Kevin Glisson, Marc Vilanova, Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(ref)</small></a></div>

---

"_ผมตื่นเต้นมากกับ **FastAPI** มันสนุกมาก!_"

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">Python Bytes</a> podcast host</strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(ref)</small></a></div>

---

"_บอกตรงๆ สิ่งที่คุณสร้างมันดูแข็งแรงและดูดีมาก หลายๆ ด้าน มันคือสิ่งที่ผมอยากให้ **Hug** เป็น มันเป็นแรงบันดาลใจดีมากที่เห็นคนสร้างอะไรแบบนี้ได้_"

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">Hug</a> creator</strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(ref)</small></a></div>

---

"_ถ้าคุณกำลังมองหาเฟรมเวิร์กสมัยใหม่สำหรับสร้าง REST API ลองดู **FastAPI** [...] มันเร็ว ใช้งานง่าย และเรียนรู้ง่าย [...]_"

"_เราเปลี่ยนมาใช้ **FastAPI** สำหรับ API ของเรา [...] ผมคิดว่าคุณจะชอบมัน [...]_"

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">Explosion AI</a> founders - <a href="https://spacy.io" target="_blank">spaCy</a> creators</strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(ref)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(ref)</small></a></div>

---

"_ถ้าใครกำลังจะสร้าง Python API เพื่อใช้งานจริง ผมขอแนะนำ **FastAPI** เป็นอย่างยิ่ง มันถูกออกแบบมาอย่างสวยงาม ใช้งานง่าย และปรับขยายได้สูง ตอนนี้มันกลายเป็นส่วนสำคัญในกลยุทธ์ API first ของเราและช่วยขับเคลื่อน automation และบริการหลายตัว เช่น Virtual TAC Engineer ของเรา_"

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(ref)</small></a></div>

---

## **Typer** FastAPI แห่งโลก CLI

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

หากคุณต้องการสร้างแอป <abbr title="Command Line Interface">CLI</abbr> เพื่อใช้งานผ่านเทอร์มินัลแทนที่จะเป็นเว็บ API ลองดู <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a>

**Typer** คือ "น้อง" ของ FastAPI และมีเป้าหมายจะเป็น **FastAPI สำหรับ CLI** ⌨️ 🚀

## ความต้องการ

FastAPI ยืนอยู่บนไหล่ยักษ์ใหญ่:

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> สำหรับส่วนเว็บ
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> สำหรับส่วนข้อมูล

## การติดตั้ง

สร้างและเปิดใช้งาน <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">virtual environment</a> แล้วติดตั้ง FastAPI ด้วยคำสั่ง:

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**หมายเหตุ**: ให้ใส่ `"fastapi[standard]"` ในเครื่องหมายคำพูด เพื่อให้ใช้งานได้กับทุกเทอร์มินัล

## ตัวอย่าง

### สร้างไฟล์

สร้างไฟล์ `main.py` ดังนี้:

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
<summary>หรือจะใช้ <code>async def</code> ก็ได้...</summary>

ถ้าโค้ดของคุณใช้ `async` / `await` ให้ใช้ `async def`:

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

**หมายเหตุ**:

ถ้าไม่แน่ใจ ให้ดูหัวข้อ _"In a hurry?"_ เกี่ยวกับ <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` และ `await` ในเอกสาร</a>

</details>

### รัน

รันเซิร์ฟเวอร์ด้วยคำสั่ง:

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
<summary>เกี่ยวกับคำสั่ง <code>fastapi dev main.py</code>...</summary>

คำสั่ง `fastapi dev` จะอ่านไฟล์ `main.py` ของคุณ ตรวจหาแอป **FastAPI** ในไฟล์นั้น แล้วเริ่มเซิร์ฟเวอร์โดยใช้ <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a>

โดยปกติ `fastapi dev` จะเปิดโหมด auto-reload สำหรับการพัฒนาอัตโนมัติ

อ่านเพิ่มเติมใน <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">เอกสาร FastAPI CLI</a>

</details>

### ทดสอบ

เปิดเบราว์เซอร์ที่ <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>

คุณจะเห็นผลลัพธ์ JSON ดังนี้:

```JSON
{"item_id": 5, "q": "somequery"}
```

คุณได้สร้าง API ที่:

* รับ HTTP request ที่ _path_ `/` และ `/items/{item_id}`
* ทั้งสอง _path_ ใช้ operation แบบ `GET` (หรือที่เรียกว่า HTTP _method_)
* _path_ `/items/{item_id}` มี _path parameter_ ชื่อ `item_id` ที่ต้องเป็น `int`
* _path_ `/items/{item_id}` มี _query parameter_ ชื่อ `q` ที่เป็น `str` แบบเลือกใส่ก็ได้

### เอกสาร API แบบ Interactive

ไปที่ <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>

คุณจะเห็นเอกสาร API แบบ interactive อัตโนมัติ (โดย <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a>):

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### เอกสาร API แบบอื่น

และไปที่ <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>

คุณจะเห็นเอกสารอีกแบบที่สร้างอัตโนมัติ (โดย <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a>):

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## ตัวอย่างการอัปเกรด

แก้ไฟล์ `main.py` เพื่อรับ body จาก `PUT` request

ประกาศ body ด้วย type มาตรฐานของ Python โดยใช้ Pydantic

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

เซิร์ฟเวอร์ `fastapi dev` จะ reload อัตโนมัติ

### อัปเกรดเอกสาร API แบบ Interactive

ไปที่ <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>

* เอกสาร API แบบ interactive จะอัปเดตโดยอัตโนมัติ รวมถึง body ใหม่:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* กดปุ่ม "Try it out" เพื่อกรอก parameter และโต้ตอบกับ API ได้โดยตรง:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* จากนั้นกดปุ่ม "Execute" อินเทอร์เฟซจะส่งข้อมูลไปที่ API รับผลลัพธ์และแสดงบนหน้าจอ:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### อัปเกรดเอกสาร API แบบอื่น

และไปที่ <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>

* เอกสารแบบอื่นจะแสดง query parameter และ body ใหม่ด้วยเช่นกัน:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### สรุป

สรุปคือ คุณประกาศ **แค่ครั้งเดียว** สำหรับประเภท parameter, body ฯลฯ เป็น parameter ของฟังก์ชัน

ใช้ type มาตรฐานของ Python สมัยใหม่

ไม่ต้องเรียนรู้ syntax ใหม่, method หรือ class ของไลบรารีพิเศษ

แค่ **Python** มาตรฐาน

เช่น ต้องการ `int`:

```Python
item_id: int
```

หรือ model ที่ซับซ้อนกว่าเช่น `Item`:

```Python
item: Item
```

...แค่ประกาศเดียวนี้ คุณจะได้:

* Editor support เช่น:
    * Completion
    * Type checks
* ตรวจสอบความถูกต้องของข้อมูล:
    * แจ้ง error อัตโนมัติและเข้าใจง่ายเมื่อข้อมูลไม่ถูกต้อง
    * ตรวจสอบข้อมูลที่เป็น JSON ซ้อนลึกๆ ได้ด้วย
* <abbr title="หรือที่รู้จักว่า: serialization, parsing, marshalling">แปลง</abbr>ข้อมูลขาเข้า: แปลงข้อมูลจาก network เป็นข้อมูล Python อ่านได้จาก:
    * JSON
    * Path parameter
    * Query parameter
    * Cookies
    * Headers
    * Forms
    * Files
* <abbr title="หรือที่รู้จักว่า: serialization, parsing, marshalling">แปลง</abbr>ข้อมูลขาออก: แปลงข้อมูล Python เป็น network data (JSON):
    * แปลงประเภท Python (`str`, `int`, `float`, `bool`, `list` ฯลฯ)
    * วัตถุ `datetime`
    * วัตถุ `UUID`
    * Database models
    * ...และอื่นๆ อีกมาก
* เอกสาร API แบบ interactive อัตโนมัติ พร้อม 2 อินเทอร์เฟซให้เลือก:
    * Swagger UI
    * ReDoc

---

ย้อนกลับไปดูตัวอย่างโค้ดก่อนหน้านี้ **FastAPI** จะ:

* ตรวจสอบว่ามี `item_id` ใน path สำหรับ `GET` และ `PUT` หรือไม่
* ตรวจสอบว่า `item_id` เป็นชนิด `int` สำหรับ `GET` และ `PUT`
    * ถ้าไม่ใช่ ผู้ใช้จะเห็น error ที่เข้าใจง่าย
* ตรวจสอบว่ามี query parameter `q` (เช่น `http://127.0.0.1:8000/items/foo?q=somequery`) สำหรับ `GET` หรือไม่
    * เพราะ `q` ประกาศด้วย `= None` จึงเป็นตัวเลือก
    * ถ้าไม่มี `None` จะเป็นค่าบังคับ (เช่นเดียวกับ body ของ `PUT`)
* สำหรับ `PUT` ที่ `/items/{item_id}` อ่าน body เป็น JSON:
    * ตรวจสอบว่ามี attribute `name` ที่ต้องเป็น `str`
    * ตรวจสอบว่ามี attribute `price` ที่ต้องเป็น `float`
    * ตรวจสอบว่า attribute `is_offer` เป็น `bool` ถ้ามี
    * ทั้งหมดนี้ใช้ได้กับ JSON ที่ซ้อนลึกๆ ด้วย
* แปลงไปมาเป็น JSON อัตโนมัติ
* สร้างเอกสาร OpenAPI อัตโนมัติ ซึ่งใช้ได้กับ:
    * ระบบเอกสารแบบ interactive
    * ระบบสร้าง client code อัตโนมัติหลากหลายภาษา
* ให้ UI แบบ interactive สำหรับเอกสาร 2 แบบ

---

นี่เป็นเพียงจุดเริ่มต้น แต่คุณคงเห็นภาพรวมการทำงานแล้ว

ลองเปลี่ยนบรรทัดนี้:

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...จาก:

```Python
        ... "item_name": item.name ...
```

...เป็น:

```Python
        ... "item_price": item.price ...
```

...แล้วดูว่า editor ของคุณจะ auto-complete ชื่อ attribute และรู้ type ให้เอง:

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

ดูตัวอย่างที่สมบูรณ์ขึ้นและฟีเจอร์อื่นๆ ได้ที่ <a href="https://fastapi.tiangolo.com/tutorial/">Tutorial - User Guide</a>

**สปอยล์**: tutorial - user guide ประกอบด้วย:

* การประกาศ **parameter** จากที่ต่างๆ เช่น **headers**, **cookies**, **form fields** และ **files**
* วิธีตั้ง **validation constraints** เช่น `maximum_length` หรือ `regex`
* ระบบ **<abbr title="หรือที่รู้จักว่า components, resources, providers, services, injectables">Dependency Injection</abbr>** ที่ทรงพลังและใช้ง่ายมาก
* ระบบความปลอดภัยและการยืนยันตัวตน รองรับ **OAuth2** ด้วย **JWT tokens** และ **HTTP Basic**
* เทคนิคขั้นสูง (แต่ก็ง่าย) ในการประกาศ **JSON model ซ้อนลึก** (ขอบคุณ Pydantic)
* รองรับ **GraphQL** กับ <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> และไลบรารีอื่นๆ
* ฟีเจอร์เสริมอีกมากมาย (ขอบคุณ Starlette) เช่น:
    * **WebSockets**
    * เทสต์ง่ายๆ ด้วย HTTPX และ `pytest`
    * **CORS**
    * **Cookie Sessions**
    * ...และอีกมากมาย

## ประสิทธิภาพ

TechEmpower benchmarks อิสระแสดงให้เห็นว่าแอป **FastAPI** ที่รันบน Uvicorn เป็น <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">หนึ่งในเฟรมเวิร์ก Python ที่เร็วที่สุด</a> เป็นรองแค่ Starlette และ Uvicorn (ที่ FastAPI ใช้ภายใน) (*)

อ่านรายละเอียดเพิ่มเติมใน <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">Benchmarks</a>

## ไลบรารีที่เกี่ยวข้อง

FastAPI อาศัย Pydantic และ Starlette

### ไลบรารี `standard` ที่เกี่ยวข้อง

เมื่อติดตั้ง FastAPI ด้วย `pip install "fastapi[standard]"` จะมาพร้อมกับ dependencies กลุ่ม `standard` ดังนี้:

สำหรับ Pydantic:

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - สำหรับการตรวจสอบอีเมล

สำหรับ Starlette:

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - ต้องใช้ถ้าต้องการ `TestClient`
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - ต้องใช้ถ้าต้องการ template configuration ค่าเริ่มต้น
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - ต้องใช้หากรองรับ <abbr title="แปลง string จาก HTTP request เป็นข้อมูล Python">"parsing"</abbr> form ด้วย `request.form()`

สำหรับ FastAPI / Starlette:

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - สำหรับเซิร์ฟเวอร์ที่รันและให้บริการแอปของคุณ (รวมถึง `uvicorn[standard]` ที่มี dependencies สำหรับประสิทธิภาพสูงเช่น `uvloop`)
* `fastapi-cli` - เพื่อคำสั่ง `fastapi`

### หากไม่ต้องการ dependencies `standard`

หากไม่ต้องการ dependencies กลุ่ม `standard` ให้ติดตั้งด้วย `pip install fastapi` แทน `pip install "fastapi[standard]"`

### ไลบรารีเสริมเพิ่มเติม

มี dependencies เสริมอื่นๆ ที่อาจต้องการติดตั้ง

สำหรับ Pydantic:

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - สำหรับจัดการ settings
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - สำหรับ type เสริมกับ Pydantic

สำหรับ FastAPI:

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - สำหรับ `ORJSONResponse`
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - สำหรับ `UJSONResponse`

## ลิขสิทธิ์

โปรเจกต์นี้อยู่ภายใต้เงื่อนไขสัญญาอนุญาต MIT

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---