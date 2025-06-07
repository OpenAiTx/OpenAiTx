<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>Kerangka kerja FastAPI, kinerja tinggi, mudah dipelajari, cepat dalam penulisan kode, siap untuk produksi</em>
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

**Dokumentasi**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**Kode Sumber**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI adalah kerangka kerja web modern, cepat (berkinerja tinggi), untuk membangun API dengan Python berbasis type hints standar Python.

Fitur utamanya adalah:

* **Cepat**: Kinerja sangat tinggi, setara dengan **NodeJS** dan **Go** (berkat Starlette dan Pydantic). [Salah satu kerangka kerja Python tercepat yang tersedia](#performance).
* **Cepat dalam penulisan kode**: Meningkatkan kecepatan pengembangan fitur sekitar 200% hingga 300%. *
* **Lebih sedikit bug**: Mengurangi sekitar 40% kesalahan yang disebabkan manusia (developer). *
* **Intuitif**: Dukungan editor yang luar biasa. <abbr title="juga dikenal sebagai auto-complete, autocompletion, IntelliSense">Penyelesaian kode</abbr> di mana-mana. Lebih sedikit waktu debugging.
* **Mudah**: Dirancang agar mudah digunakan dan dipelajari. Lebih sedikit waktu membaca dokumentasi.
* **Singkat**: Meminimalkan duplikasi kode. Banyak fitur dari setiap deklarasi parameter. Lebih sedikit bug.
* **Kuat**: Dapatkan kode yang siap produksi. Dengan dokumentasi interaktif otomatis.
* **Berbasis Standar**: Berdasarkan (dan sepenuhnya kompatibel dengan) standar terbuka untuk API: <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a> (sebelumnya dikenal sebagai Swagger) dan <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>.

<small>* estimasi berdasarkan pengujian pada tim pengembangan internal, membangun aplikasi produksi.</small>

## Sponsor

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

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">Sponsor lainnya</a>

## Pendapat

"_[...] Saya sangat sering menggunakan **FastAPI** akhir-akhir ini. [...] Saya bahkan berencana untuk menggunakannya untuk semua layanan **ML** tim saya di **Microsoft**. Beberapa di antaranya akan diintegrasikan ke produk inti **Windows** dan beberapa produk **Office**._"

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(ref)</small></a></div>

---

"_Kami mengadopsi pustaka **FastAPI** untuk membuat server **REST** yang dapat di-query untuk mendapatkan **prediksi**. [untuk Ludwig]_"

<div style="text-align: right; margin-right: 10%;">Piero Molino, Yaroslav Dudin, dan Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(ref)</small></a></div>

---

"_**Netflix** dengan bangga mengumumkan rilis open-source kerangka orkestrasi **manajemen krisis** kami: **Dispatch**! [dibangun dengan **FastAPI**]_"

<div style="text-align: right; margin-right: 10%;">Kevin Glisson, Marc Vilanova, Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(ref)</small></a></div>

---

"_Saya sangat bersemangat dengan **FastAPI**. Ini sangat menyenangkan!_"

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">host podcast Python Bytes</a></strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(ref)</small></a></div>

---

"_Sejujurnya, apa yang Anda bangun terlihat sangat solid dan rapi. Dalam banyak hal, ini adalah apa yang saya inginkan dari **Hug** - sangat menginspirasi melihat seseorang membangunnya._"

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">pencipta Hug</a></strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(ref)</small></a></div>

---

"_Jika Anda ingin mempelajari satu **kerangka kerja modern** untuk membangun REST API, coba **FastAPI** [...] Ini cepat, mudah digunakan dan mudah dipelajari [...]_"

"_Kami telah beralih ke **FastAPI** untuk **API** kami [...] Saya pikir Anda akan menyukainya [...]_"

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">pendiri Explosion AI</a> - <a href="https://spacy.io" target="_blank">pencipta spaCy</a></strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(ref)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(ref)</small></a></div>

---

"_Jika ada yang ingin membangun API Python produksi, saya sangat merekomendasikan **FastAPI**. Ia **sangat terdesain indah**, **sederhana digunakan** dan **sangat skalabel**, telah menjadi **komponen kunci** dalam strategi pengembangan API first kami dan menjalankan banyak automasi dan layanan seperti Virtual TAC Engineer kami._"

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(ref)</small></a></div>

---

## **Typer**, FastAPI untuk CLI

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

Jika Anda membangun aplikasi <abbr title="Command Line Interface">CLI</abbr> yang digunakan di terminal alih-alih web API, lihatlah <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a>.

**Typer** adalah adik kecil FastAPI. Dan memang dimaksudkan sebagai **FastAPI untuk CLI**. ⌨️ 🚀

## Persyaratan

FastAPI berdiri di atas bahu para raksasa:

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> untuk bagian web.
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> untuk bagian data.

## Instalasi

Buat dan aktifkan <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">virtual environment</a> lalu instal FastAPI:

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**Catatan**: Pastikan Anda menulis `"fastapi[standard]"` dalam tanda kutip agar bekerja di semua terminal.

## Contoh

### Buat

Buat file `main.py` dengan:

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
<summary>Atau gunakan <code>async def</code>...</summary>

Jika kode Anda menggunakan `async` / `await`, gunakan `async def`:

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

**Catatan**:

Jika Anda belum tahu, lihat bagian _"In a hurry?"_ tentang <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` dan `await` di dokumentasi</a>.

</details>

### Jalankan

Jalankan server dengan:

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
<summary>Tentang perintah <code>fastapi dev main.py</code>...</summary>

Perintah `fastapi dev` membaca file `main.py` Anda, mendeteksi aplikasi **FastAPI** di dalamnya, dan memulai server menggunakan <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a>.

Secara default, `fastapi dev` akan berjalan dengan auto-reload diaktifkan untuk pengembangan lokal.

Anda dapat membaca lebih lanjut di <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">dokumentasi FastAPI CLI</a>.

</details>

### Cek

Buka browser Anda di <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>.

Anda akan melihat respons JSON seperti:

```JSON
{"item_id": 5, "q": "somequery"}
```

Anda telah membuat API yang:

* Menerima permintaan HTTP di _path_ `/` dan `/items/{item_id}`.
* Kedua _path_ menerima operasi `GET` (<em>juga dikenal sebagai HTTP _methods_</em>).
* _Path_ `/items/{item_id}` memiliki _path parameter_ `item_id` yang harus berupa `int`.
* _Path_ `/items/{item_id}` memiliki _query parameter_ opsional `q` bertipe `str`.

### Dokumentasi API Interaktif

Sekarang buka <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

Anda akan melihat dokumentasi API interaktif otomatis (disediakan oleh <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a>):

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### Dokumentasi API Alternatif

Dan sekarang, buka <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

Anda akan melihat dokumentasi otomatis alternatif (disediakan oleh <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a>):

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## Peningkatan Contoh

Sekarang modifikasi file `main.py` untuk menerima body dari permintaan `PUT`.

Deklarasikan body menggunakan tipe Python standar, berkat Pydantic.

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

Server `fastapi dev` seharusnya me-reload secara otomatis.

### Peningkatan Dokumentasi API Interaktif

Sekarang buka <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

* Dokumentasi API interaktif akan diperbarui secara otomatis, termasuk body baru:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* Klik tombol "Try it out", Anda bisa mengisi parameter dan berinteraksi langsung dengan API:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* Lalu klik tombol "Execute", antarmuka akan berkomunikasi dengan API Anda, mengirim parameter, mendapatkan hasil dan menampilkannya di layar:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### Peningkatan Dokumentasi API Alternatif

Dan sekarang, buka <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

* Dokumentasi alternatif juga akan memperlihatkan query parameter dan body baru:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### Ringkasan

Singkatnya, Anda mendeklarasikan **satu kali** tipe parameter, body, dll. sebagai parameter fungsi.

Anda melakukannya dengan tipe Python modern standar.

Anda tidak perlu mempelajari sintaks baru, metode atau kelas dari pustaka tertentu, dll.

Cukup **Python** standar.

Misalnya, untuk `int`:

```Python
item_id: int
```

atau untuk model `Item` yang lebih kompleks:

```Python
item: Item
```

...dan dengan satu deklarasi tersebut Anda mendapatkan:

* Dukungan editor, termasuk:
    * Penyelesaian kode.
    * Pemeriksaan tipe.
* Validasi data:
    * Error otomatis dan jelas saat data tidak valid.
    * Validasi bahkan untuk objek JSON bersarang dalam.
* <abbr title="juga dikenal sebagai: serialization, parsing, marshalling">Konversi</abbr> data input: dari jaringan ke data dan tipe Python. Membaca dari:
    * JSON.
    * Parameter path.
    * Parameter query.
    * Cookies.
    * Headers.
    * Forms.
    * Files.
* <abbr title="juga dikenal sebagai: serialization, parsing, marshalling">Konversi</abbr> data output: dari data dan tipe Python ke data jaringan (sebagai JSON):
    * Konversi tipe Python (`str`, `int`, `float`, `bool`, `list`, dll).
    * Objek `datetime`.
    * Objek `UUID`.
    * Model database.
    * ...dan banyak lagi.
* Dokumentasi API interaktif otomatis, termasuk 2 antarmuka pengguna alternatif:
    * Swagger UI.
    * ReDoc.

---

Kembali ke contoh kode sebelumnya, **FastAPI** akan:

* Memvalidasi bahwa ada `item_id` di path untuk permintaan `GET` dan `PUT`.
* Memvalidasi bahwa `item_id` bertipe `int` untuk permintaan `GET` dan `PUT`.
    * Jika tidak, klien akan melihat error yang jelas dan berguna.
* Memeriksa apakah ada query parameter opsional bernama `q` (seperti pada `http://127.0.0.1:8000/items/foo?q=somequery`) untuk permintaan `GET`.
    * Karena parameter `q` dideklarasikan dengan `= None`, maka opsional.
    * Tanpa `None` maka akan menjadi wajib (seperti body pada kasus `PUT`).
* Untuk permintaan `PUT` ke `/items/{item_id}`, membaca body sebagai JSON:
    * Memeriksa bahwa ada atribut wajib `name` yang harus bertipe `str`.
    * Memeriksa bahwa ada atribut wajib `price` yang harus bertipe `float`.
    * Memeriksa bahwa ada atribut opsional `is_offer`, yang harus bertipe `bool`, jika ada.
    * Semua ini juga berlaku untuk objek JSON bersarang dalam.
* Konversi otomatis dari dan ke JSON.
* Mendokumentasikan semuanya dengan OpenAPI, yang dapat digunakan oleh:
    * Sistem dokumentasi interaktif.
    * Sistem pembuatan kode klien otomatis, untuk banyak bahasa.
* Menyediakan 2 antarmuka web dokumentasi interaktif secara langsung.

---

Kita baru saja menyentuh permukaan, tapi Anda sudah mendapat gambaran bagaimana semuanya bekerja.

Coba ubah baris berikut:

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...dari:

```Python
        ... "item_name": item.name ...
```

...menjadi:

```Python
        ... "item_price": item.price ...
```

...dan lihat bagaimana editor Anda akan melengkapi atribut dan mengetahui tipenya:

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

Untuk contoh yang lebih lengkap termasuk fitur-fitur lainnya, lihat <a href="https://fastapi.tiangolo.com/tutorial/">Tutorial - User Guide</a>.

**Spoiler**: tutorial - user guide mencakup:

* Deklarasi **parameter** dari tempat lain seperti: **headers**, **cookies**, **form fields** dan **files**.
* Cara menetapkan **batasan validasi** seperti `maximum_length` atau `regex`.
* Sistem **<abbr title="juga dikenal sebagai components, resources, providers, services, injectables">Dependency Injection</abbr>** yang sangat kuat dan mudah digunakan.
* Keamanan dan autentikasi, termasuk dukungan untuk **OAuth2** dengan **JWT tokens** dan **HTTP Basic** auth.
* Teknik yang lebih lanjut (namun tetap mudah) untuk mendeklarasikan **model JSON bersarang dalam** (berkat Pydantic).
* Integrasi **GraphQL** dengan <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> dan pustaka lainnya.
* Banyak fitur tambahan (berkat Starlette) seperti:
    * **WebSockets**
    * pengujian sangat mudah berbasis HTTPX dan `pytest`
    * **CORS**
    * **Cookie Sessions**
    * ...dan lainnya.

## Performa

Benchmark independen TechEmpower menunjukkan aplikasi **FastAPI** yang berjalan di Uvicorn sebagai <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">salah satu kerangka kerja Python tercepat yang tersedia</a>, hanya di bawah Starlette dan Uvicorn sendiri (yang digunakan secara internal oleh FastAPI). (*)

Untuk pemahaman lebih lanjut, lihat bagian <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">Benchmarks</a>.

## Ketergantungan

FastAPI bergantung pada Pydantic dan Starlette.

### Ketergantungan `standard`

Saat Anda menginstal FastAPI dengan `pip install "fastapi[standard]"`, ia datang dengan grup ketergantungan opsional `standard`:

Digunakan oleh Pydantic:

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - untuk validasi email.

Digunakan oleh Starlette:

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - Diperlukan jika Anda ingin menggunakan `TestClient`.
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - Diperlukan jika Anda ingin menggunakan konfigurasi template default.
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - Diperlukan jika Anda ingin mendukung <abbr title="mengonversi string dari permintaan HTTP menjadi data Python">"parsing"</abbr> form, dengan `request.form()`.

Digunakan oleh FastAPI / Starlette:

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - untuk server yang memuat dan melayani aplikasi Anda. Ini termasuk `uvicorn[standard]`, yang mencakup beberapa ketergantungan (misalnya `uvloop`) yang diperlukan untuk performa tinggi.
* `fastapi-cli` - untuk menyediakan perintah `fastapi`.

### Tanpa Ketergantungan `standard`

Jika Anda tidak ingin memasukkan ketergantungan opsional `standard`, Anda bisa menginstal dengan `pip install fastapi` alih-alih `pip install "fastapi[standard]"`.

### Ketergantungan Opsional Tambahan

Ada beberapa ketergantungan tambahan yang mungkin ingin Anda instal.

Ketergantungan opsional tambahan untuk Pydantic:

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - untuk manajemen pengaturan.
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - untuk tipe tambahan yang dapat digunakan dengan Pydantic.

Ketergantungan opsional tambahan untuk FastAPI:

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - Diperlukan jika Anda ingin menggunakan `ORJSONResponse`.
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - Diperlukan jika Anda ingin menggunakan `UJSONResponse`.

## Lisensi

Proyek ini dilisensikan di bawah lisensi MIT.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---