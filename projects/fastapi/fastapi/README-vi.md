<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>Framework FastAPI, hiệu năng cao, dễ học, lập trình nhanh, sẵn sàng cho môi trường sản xuất</em>
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

**Tài liệu**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**Mã nguồn**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI là một framework web hiện đại, nhanh (hiệu năng cao), dùng để xây dựng API với Python dựa trên các type hint chuẩn của Python.

Các tính năng chính:

* **Nhanh**: Hiệu năng rất cao, ngang hàng với **NodeJS** và **Go** (nhờ vào Starlette và Pydantic). [Một trong những framework Python nhanh nhất hiện nay](#performance).
* **Lập trình nhanh**: Tăng tốc độ phát triển tính năng lên khoảng 200% đến 300%. *
* **Ít lỗi hơn**: Giảm khoảng 40% lỗi do con người (lập trình viên) gây ra. *
* **Trực quan**: Hỗ trợ tốt cho editor. <abbr title="còn gọi là auto-complete, autocompletion, IntelliSense">Tự hoàn thành</abbr> ở mọi nơi. Giảm thời gian debug.
* **Dễ dàng**: Thiết kế để dễ sử dụng và dễ học. Giảm thời gian đọc tài liệu.
* **Ngắn gọn**: Giảm thiểu lặp lại mã nguồn. Nhiều tính năng từ mỗi khai báo tham số. Ít lỗi hơn.
* **Vững chắc**: Được chuẩn bị sẵn sàng cho môi trường sản xuất. Có tài liệu tương tác tự động.
* **Dựa trên tiêu chuẩn**: Dựa trên (và hoàn toàn tương thích với) các tiêu chuẩn mở cho API: <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a> (trước đây gọi là Swagger) và <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>.

<small>* ước tính dựa trên kiểm thử với nhóm phát triển nội bộ, xây dựng ứng dụng sản xuất.</small>

## Nhà tài trợ

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

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">Nhà tài trợ khác</a>

## Đánh giá

"_[...] Tôi đang sử dụng **FastAPI** rất nhiều dạo này. [...] Thực tế tôi dự định dùng nó cho tất cả các dịch vụ **ML của nhóm tại Microsoft**. Một số trong đó đang được tích hợp vào sản phẩm lõi **Windows** và một số sản phẩm **Office**._"

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(tham khảo)</small></a></div>

---

"_Chúng tôi đã áp dụng thư viện **FastAPI** để khởi tạo một server **REST** có thể truy vấn để lấy **dự đoán**. [cho Ludwig]_"

<div style="text-align: right; margin-right: 10%;">Piero Molino, Yaroslav Dudin, và Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(tham khảo)</small></a></div>

---

"_**Netflix** vui mừng thông báo phát hành mã nguồn mở framework điều phối **quản lý khủng hoảng** của chúng tôi: **Dispatch**! [xây dựng với **FastAPI**]_"

<div style="text-align: right; margin-right: 10%;">Kevin Glisson, Marc Vilanova, Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(tham khảo)</small></a></div>

---

"_Tôi cực kỳ hào hứng về **FastAPI**. Nó thật sự rất thú vị!_"

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">Python Bytes</a> podcast host</strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(tham khảo)</small></a></div>

---

"_Thật sự, những gì bạn xây dựng rất chắc chắn và bóng bẩy. Ở nhiều khía cạnh, nó là thứ tôi mong muốn **Hug** trở thành - thật cảm hứng khi thấy ai đó xây dựng được như vậy._"

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">Hug</a> creator</strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(tham khảo)</small></a></div>

---

"_Nếu bạn muốn học một **framework hiện đại** để xây dựng REST API, hãy thử **FastAPI** [...] Nó nhanh, dễ dùng và dễ học [...]_"

"_Chúng tôi đã chuyển sang dùng **FastAPI** cho các **API** của mình [...] Tôi nghĩ bạn sẽ thích nó [...]_"

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">Explosion AI</a> founders - <a href="https://spacy.io" target="_blank">spaCy</a> creators</strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(tham khảo)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(tham khảo)</small></a></div>

---

"_Nếu ai đó muốn xây dựng một API Python cho môi trường sản xuất, tôi rất khuyến nghị **FastAPI**. Nó **thiết kế tuyệt đẹp**, **dễ sử dụng** và **cực kỳ mở rộng**, đã trở thành **thành phần then chốt** trong chiến lược phát triển API first của chúng tôi và đang vận hành nhiều tự động hóa và dịch vụ như Kỹ sư TAC Ảo của chúng tôi._"

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(tham khảo)</small></a></div>

---

## **Typer**, FastAPI dành cho CLI

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

Nếu bạn đang xây dựng một ứng dụng <abbr title="Command Line Interface">CLI</abbr> để dùng trong terminal thay vì web API, hãy xem qua <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a>.

**Typer** là "em út" của FastAPI. Và nó hướng tới việc trở thành **FastAPI của CLI**. ⌨️ 🚀

## Yêu cầu

FastAPI đứng trên vai những người khổng lồ:

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> cho phần web.
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> cho phần dữ liệu.

## Cài đặt

Tạo và kích hoạt một <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">virtual environment</a> sau đó cài đặt FastAPI:

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**Lưu ý**: Hãy chắc chắn đặt `"fastapi[standard]"` trong dấu ngoặc kép để đảm bảo hoạt động trên mọi terminal.

## Ví dụ

### Tạo ứng dụng

Tạo file `main.py` với nội dung:

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
<summary>Hoặc dùng <code>async def</code>...</summary>

Nếu mã nguồn của bạn dùng `async` / `await`, hãy dùng `async def`:

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

**Lưu ý**:

Nếu bạn chưa biết, hãy xem mục _"In a hurry?"_ về <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` và `await` trong tài liệu</a>.

</details>

### Chạy ứng dụng

Chạy server với lệnh:

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
<summary>Về lệnh <code>fastapi dev main.py</code>...</summary>

Lệnh `fastapi dev` đọc file `main.py` của bạn, phát hiện app **FastAPI** trong đó và khởi động server sử dụng <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a>.

Mặc định, `fastapi dev` sẽ bật chế độ auto-reload khi phát triển cục bộ.

Bạn có thể đọc thêm ở <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">tài liệu FastAPI CLI</a>.

</details>

### Kiểm tra

Mở trình duyệt tại <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>.

Bạn sẽ thấy phản hồi JSON như sau:

```JSON
{"item_id": 5, "q": "somequery"}
```

Bạn đã tạo ra một API mà:

* Nhận các yêu cầu HTTP tại _đường dẫn_ `/` và `/items/{item_id}`.
* Cả hai _đường dẫn_ đều nhận các thao tác `GET` (hay còn gọi là HTTP _methods_).
* Đường dẫn `/items/{item_id}` có một _tham số đường dẫn_ `item_id` cần là `int`.
* Đường dẫn `/items/{item_id}` có một _tham số truy vấn_ `q` kiểu `str` tùy chọn.

### Tài liệu API tương tác

Bây giờ hãy truy cập <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

Bạn sẽ thấy tài liệu API tương tác tự động (cung cấp bởi <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a>):

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### Tài liệu API thay thế

Và bây giờ, hãy truy cập <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

Bạn sẽ thấy tài liệu tự động thay thế (cung cấp bởi <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a>):

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## Nâng cấp ví dụ

Bây giờ hãy sửa file `main.py` để nhận body từ một yêu cầu `PUT`.

Khai báo body sử dụng các kiểu chuẩn Python, nhờ vào Pydantic.

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

Server `fastapi dev` sẽ tự động reload.

### Nâng cấp tài liệu API tương tác

Bây giờ truy cập <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

* Tài liệu API tương tác sẽ tự động cập nhật, bao gồm cả body mới:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* Nhấn nút "Try it out", bạn có thể điền tham số và tương tác trực tiếp với API:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* Sau đó nhấn nút "Execute", giao diện sẽ gửi tham số, nhận kết quả và hiển thị lên màn hình:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### Nâng cấp tài liệu API thay thế

Và bây giờ, hãy truy cập <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

* Tài liệu thay thế cũng sẽ thể hiện tham số truy vấn và body mới:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### Tổng kết

Tóm lại, bạn chỉ cần khai báo **một lần** các kiểu tham số, body, v.v. như tham số hàm.

Bạn làm điều đó với các kiểu Python hiện đại, chuẩn.

Bạn không cần học cú pháp mới, không cần học method hoặc class của một thư viện cụ thể nào.

Chỉ cần **Python** chuẩn.

Ví dụ, với một `int`:

```Python
item_id: int
```

hoặc với một model `Item` phức tạp hơn:

```Python
item: Item
```

...và chỉ với khai báo đó bạn có được:

* Hỗ trợ từ editor, bao gồm:
    * Tự hoàn thành.
    * Kiểm tra kiểu dữ liệu.
* Kiểm tra dữ liệu hợp lệ:
    * Lỗi tự động, rõ ràng khi dữ liệu không hợp lệ.
    * Kiểm tra hợp lệ kể cả với các đối tượng JSON lồng sâu.
* <abbr title="còn gọi là: serialization, parsing, marshalling">Chuyển đổi</abbr> dữ liệu đầu vào: từ mạng về kiểu dữ liệu Python. Đọc từ:
    * JSON.
    * Tham số đường dẫn.
    * Tham số truy vấn.
    * Cookie.
    * Header.
    * Biểu mẫu.
    * Tệp.
* <abbr title="còn gọi là: serialization, parsing, marshalling">Chuyển đổi</abbr> dữ liệu đầu ra: từ Python sang dữ liệu mạng (dạng JSON):
    * Chuyển các kiểu Python (`str`, `int`, `float`, `bool`, `list`, v.v.).
    * Đối tượng `datetime`.
    * Đối tượng `UUID`.
    * Model cơ sở dữ liệu.
    * ...và nhiều hơn nữa.
* Tài liệu API tương tác tự động, bao gồm 2 giao diện web:
    * Swagger UI.
    * ReDoc.

---

Quay lại ví dụ mã nguồn trước, **FastAPI** sẽ:

* Kiểm tra có `item_id` trong path cho yêu cầu `GET` và `PUT`.
* Kiểm tra `item_id` có kiểu `int` cho yêu cầu `GET` và `PUT`.
    * Nếu không đúng, client sẽ thấy lỗi rõ ràng, hữu ích.
* Kiểm tra nếu có tham số truy vấn tùy chọn tên `q` (như `http://127.0.0.1:8000/items/foo?q=somequery`) cho yêu cầu `GET`.
    * Vì tham số `q` khai báo với `= None`, nên nó là tùy chọn.
    * Nếu không có `None` thì bắt buộc (giống như body với `PUT`).
* Với yêu cầu `PUT` tới `/items/{item_id}`, đọc body dạng JSON:
    * Kiểm tra có thuộc tính `name` bắt buộc, phải là `str`.
    * Kiểm tra có thuộc tính `price` bắt buộc, phải là `float`.
    * Kiểm tra có thuộc tính `is_offer` tùy chọn, nếu có thì phải là `bool`.
    * Tất cả những điều này cũng áp dụng cho JSON lồng sâu.
* Tự động chuyển đổi từ và sang JSON.
* Tự động tài liệu hóa với OpenAPI, có thể dùng cho:
    * Hệ thống tài liệu tương tác.
    * Hệ thống sinh mã client tự động cho nhiều ngôn ngữ.
* Cung cấp 2 giao diện tài liệu web tương tác trực tiếp.

---

Chúng ta chỉ mới xem lướt qua, nhưng bạn đã thấy ý tưởng tổng thể hoạt động thế nào.

Hãy thử thay dòng sau:

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...từ:

```Python
        ... "item_name": item.name ...
```

...thành:

```Python
        ... "item_price": item.price ...
```

...và xem editor của bạn sẽ tự hoàn thành thuộc tính và biết kiểu của chúng thế nào:

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

Để xem ví dụ đầy đủ hơn, hãy xem <a href="https://fastapi.tiangolo.com/tutorial/">Tutorial - User Guide</a>.

**Bật mí**: tutorial - user guide bao gồm:

* Khai báo **tham số** từ nhiều nguồn khác nhau như: **headers**, **cookies**, **form fields** và **files**.
* Cách đặt **ràng buộc kiểm tra** như `maximum_length` hoặc `regex`.
* Hệ thống **<abbr title="còn gọi là components, resources, providers, services, injectables">Dependency Injection</abbr>** mạnh mẽ và dễ dùng.
* Bảo mật và xác thực, bao gồm hỗ trợ **OAuth2** với **JWT tokens** và xác thực **HTTP Basic**.
* Kỹ thuật nâng cao (nhưng cũng dễ dàng) để khai báo **mô hình JSON lồng sâu** (nhờ Pydantic).
* Tích hợp **GraphQL** với <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> và các thư viện khác.
* Nhiều tính năng bổ sung (nhờ Starlette) như:
    * **WebSockets**
    * kiểm thử cực kỳ dễ với HTTPX và `pytest`
    * **CORS**
    * **Cookie Sessions**
    * ...và nhiều hơn nữa.

## Hiệu năng

Các benchmark độc lập của TechEmpower cho thấy ứng dụng **FastAPI** chạy trên Uvicorn là <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">một trong những framework Python nhanh nhất</a>, chỉ sau Starlette và Uvicorn (cũng được dùng trong FastAPI). (*)

Để hiểu thêm, hãy xem mục <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">Benchmarks</a>.

## Phụ thuộc

FastAPI phụ thuộc vào Pydantic và Starlette.

### Phụ thuộc `standard`

Khi bạn cài FastAPI bằng `pip install "fastapi[standard]"` nó sẽ kèm theo nhóm phụ thuộc tùy chọn `standard`:

Được Pydantic sử dụng:

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - để kiểm tra email.

Được Starlette sử dụng:

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - Bắt buộc nếu bạn muốn dùng `TestClient`.
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - Bắt buộc nếu bạn muốn dùng cấu hình template mặc định.
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - Bắt buộc nếu bạn muốn hỗ trợ <abbr title="chuyển đổi chuỗi từ yêu cầu HTTP thành dữ liệu Python">"parsing"</abbr> form, với `request.form()`.

Được FastAPI / Starlette sử dụng:

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - server để load và phục vụ ứng dụng của bạn. Bao gồm `uvicorn[standard]`, tích hợp các phụ thuộc (ví dụ `uvloop`) cần thiết để phục vụ hiệu năng cao.
* `fastapi-cli` - cung cấp lệnh `fastapi`.

### Không dùng phụ thuộc `standard`

Nếu bạn không muốn bao gồm các phụ thuộc tùy chọn `standard`, bạn có thể cài bằng `pip install fastapi` thay vì `pip install "fastapi[standard]"`.

### Các phụ thuộc tùy chọn bổ sung

Có một số phụ thuộc bổ sung bạn có thể muốn cài thêm.

Phụ thuộc tùy chọn bổ sung cho Pydantic:

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - quản lý cấu hình.
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - các kiểu dữ liệu bổ sung cho Pydantic.

Phụ thuộc tùy chọn bổ sung cho FastAPI:

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - Bắt buộc nếu bạn muốn dùng `ORJSONResponse`.
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - Bắt buộc nếu bạn muốn dùng `UJSONResponse`.

## Giấy phép

Dự án này được phát hành theo giấy phép MIT.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---