<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>FastAPI 框架，高性能，易学，开发迅速，随时可用于生产环境</em>
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

**文档**：<a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**源码**：<a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI 是一个现代、快速（高性能）的 Web 框架，用于基于标准 Python 类型提示构建 Python API。

主要特性包括：

* **快**：性能非常高，可与 **NodeJS** 和 **Go** 相媲美（归功于 Starlette 和 Pydantic）。[是现有最快的 Python 框架之一](#performance)。
* **开发快**：开发新功能的速度提升约 200% 到 300%。*
* **更少的 Bug**：人为（开发者）错误约减少 40%。*
* **直观**：优秀的编辑器支持。<abbr title="也称为自动补全、自动完成功能、IntelliSense">全程补全</abbr>。调试时间更少。
* **简单**：设计易用易学。减少查阅文档时间。
* **简洁**：最小化代码重复。每个参数声明可获得多种功能。更少 Bug。
* **健壮**：获得可用于生产的代码。自带自动交互式文档。
* **基于标准**：基于（并完全兼容）API 的开放标准：<a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a>（前称 Swagger）和 <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>。

<small>* 基于内部开发团队构建生产应用的测试估算。</small>

## 赞助商

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

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">更多赞助商</a>

## 用户评价

“_[...] 我最近大量使用 **FastAPI**。[...] 实际上我打算将它用于我在微软团队的所有 **机器学习服务**。有些服务会集成进核心 **Windows** 产品，还有一些集成到 **Office** 产品中。_”

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>微软（Microsoft）</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(引用)</small></a></div>

---

“_我们采用了 **FastAPI** 库来生成一个 **REST** 服务器，可用于获得 **预测结果**。[用于 Ludwig]_”

<div style="text-align: right; margin-right: 10%;">Piero Molino、Yaroslav Dudin 和 Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(引用)</small></a></div>

---

“_**Netflix** 很高兴宣布我们发布了开源的 **危机管理** 协调框架：**Dispatch**！[基于 **FastAPI** 构建]_”

<div style="text-align: right; margin-right: 10%;">Kevin Glisson、Marc Vilanova、Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(引用)</small></a></div>

---

“_我对 **FastAPI** 感到无比兴奋。真的很有趣！_”

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">Python Bytes</a> 播客主持人</strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(引用)</small></a></div>

---

“_说实话，你做得很扎实且精致。在很多方面，这就是我希望 **Hug** 成为的样子——看到有人能实现出来真的很鼓舞人心。_”

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">Hug</a> 创始人</strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(引用)</small></a></div>

---

“_如果你想学习一个用于构建 REST API 的**现代框架**，请试试 **FastAPI** [...] 它快速、易用且易学 [...]_”

“_我们已经将我们的 **API** 切换到 **FastAPI** [...] 我觉得你会喜欢它 [...]_”

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">Explosion AI</a> 创始人 - <a href="https://spacy.io" target="_blank">spaCy</a> 创作者</strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(引用)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(引用)</small></a></div>

---

“_如果有人打算构建生产级的 Python API，我会强烈推荐 **FastAPI**。它**设计优雅**，**使用简单**且**高度可扩展**，已经成为我们 API 优先开发策略的**关键组件**，并驱动了许多自动化和服务，例如我们的虚拟 TAC 工程师。_”

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(引用)</small></a></div>

---

## **Typer**：命令行界面的 FastAPI

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

如果你要构建一个在终端使用的 <abbr title="命令行界面">CLI</abbr> 应用，而不是 Web API，可以看看 <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a>。

**Typer** 是 FastAPI 的“小兄弟”。它旨在成为**命令行界面的 FastAPI**。⌨️ 🚀

## 依赖要求

FastAPI 基于以下“巨人之肩”：

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> —— Web 相关部分。
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> —— 数据相关部分。

## 安装

创建并激活一个<a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">虚拟环境</a>，然后安装 FastAPI：

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**注意**：请确保将 `"fastapi[standard]"` 用引号括起来，以保证在所有终端都能正常工作。

## 示例

### 创建

创建文件 `main.py`，内容如下：

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
<summary>或使用 <code>async def</code>...</summary>

如果你的代码用到了 `async` / `await`，请使用 `async def`：

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

**注意**：

如果你不了解，请查阅文档中<a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">关于 `async` 和 `await` 的“赶时间？”章节</a>。

</details>

### 运行

用以下命令启动服务器：

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
<summary>关于命令 <code>fastapi dev main.py</code>...</summary>

命令 `fastapi dev` 会读取你的 `main.py` 文件，检测其中的 **FastAPI** 应用，并使用 <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a> 启动服务器。

默认情况下，`fastapi dev` 会自动开启本地开发的自动重载。

你可以在 <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">FastAPI CLI 文档</a> 中了解更多信息。

</details>

### 访问

在浏览器中打开 <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>。

你会看到如下 JSON 响应：

```JSON
{"item_id": 5, "q": "somequery"}
```

你已经创建了一个 API，具备以下功能：

* 在路径 `/` 和 `/items/{item_id}` 接收 HTTP 请求。
* 两个路径都支持 `GET` <em>操作</em>（也称 HTTP _方法_）。
* 路径 `/items/{item_id}` 有一个路径参数 `item_id`，类型为 `int`。
* 路径 `/items/{item_id}` 有一个可选的字符串类型查询参数 `q`。

### 交互式 API 文档

现在访问 <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>。

你会看到自动生成的交互式 API 文档（由 <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a> 提供）：

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### 替代 API 文档

再访问 <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>。

你会看到另一种自动文档界面（由 <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a> 提供）：

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## 示例升级

现在将 `main.py` 文件修改为接收 `PUT` 请求的请求体。

通过 Pydantic，使用标准 Python 类型声明请求体。

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

`fastapi dev` 服务器会自动重载。

### 交互式 API 文档升级

再次访问 <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>。

* 交互式 API 文档会自动更新，包括新的请求体：

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* 点击 "Try it out" 按钮，可以填写参数并直接与 API 交互：

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* 然后点击 "Execute" 按钮，界面会与 API 通信，发送参数，获取结果并显示出来：

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### 替代 API 文档升级

再访问 <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>。

* 替代文档也会反映新的查询参数和请求体：

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### 总结

总之，你只需**一次性**声明参数、请求体等的类型（作为函数参数）。

这些都是标准的现代 Python 类型。

你无需学习新语法、特定库的方法或类等。

只用标准的 **Python**。

例如，一个 `int` 类型：

```Python
item_id: int
```

或更复杂的 `Item` 模型：

```Python
item: Item
```

...通过这唯一的声明，你就能获得：

* 编辑器支持，包括：
    * 自动补全。
    * 类型检查。
* 数据验证：
    * 当数据无效时自动且清晰的错误提示。
    * 对深层嵌套 JSON 对象的验证。
* 输入数据<abbr title="也称为：序列化、解析、封送">转换</abbr>：从网络到 Python 数据和类型。支持读取：
    * JSON
    * 路径参数
    * 查询参数
    * Cookies
    * Headers
    * 表单
    * 文件
* 输出数据<abbr title="也称为：序列化、解析、封送">转换</abbr>：从 Python 数据类型转换为网络数据（如 JSON）：
    * 支持 Python 类型（`str`、`int`、`float`、`bool`、`list` 等）。
    * `datetime` 对象。
    * `UUID` 对象。
    * 数据库模型。
    * ...以及更多类型。
* 自动生成交互式 API 文档，包括两种用户界面：
    * Swagger UI
    * ReDoc

---

回到前面的示例代码，**FastAPI** 会：

* 校验 `GET` 和 `PUT` 请求路径中是否有 `item_id`。
* 校验 `GET` 和 `PUT` 请求的 `item_id` 类型是否为 `int`。
    * 若不是，客户端会看到有用且清晰的错误提示。
* 检查 `GET` 请求是否有名为 `q` 的可选查询参数（如 `http://127.0.0.1:8000/items/foo?q=somequery`）。
    * 因为参数 `q` 被声明为 `= None`，所以是可选的。
    * 若没有 `None`，则为必填项（如 `PUT` 请求体）。
* 对于 `/items/{item_id}` 的 `PUT` 请求，将请求体解析为 JSON：
    * 检查必须有 `name` 属性且类型为 `str`。
    * 检查必须有 `price` 属性且为 `float` 类型。
    * 检查可选属性 `is_offer`，若存在则应为 `bool`。
    * 这些也适用于深度嵌套的 JSON。
* 自动进行 JSON 的转换。
* 用 OpenAPI 标准记录所有信息，可供：
    * 交互式文档系统使用
    * 多语言自动生成客户端代码
* 直接提供两种交互式文档界面。

---

这只是冰山一角，但你已经了解其整体工作方式。

试着将这行代码：

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...从：

```Python
        ... "item_name": item.name ...
```

...改为：

```Python
        ... "item_price": item.price ...
```

...你会发现编辑器自动补全属性并知晓其类型：

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

如需包含更多功能的完整示例，请参考 <a href="https://fastapi.tiangolo.com/tutorial/">教程 - 用户指南</a>。

**剧透提示**：教程-用户指南内容包括：

* 从**headers**、**cookies**、**表单字段**和**文件**等不同位置声明**参数**。
* 如何设置如 `maximum_length` 或 `regex` 等**验证约束**。
* 强大且易用的 **<abbr title="又称为组件、资源、提供者、服务、可注入项">依赖注入</abbr>** 系统。
* 安全与认证，支持 **OAuth2**（含 **JWT token**）和 **HTTP Basic** 认证。
* 更高级（但同样简单）的声明**深度嵌套 JSON 模型**（得益于 Pydantic）。
* 与 <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> 等库集成的 **GraphQL**。
* 许多额外功能（归功于 Starlette），如：
    * **WebSockets**
    * 基于 HTTPX 和 `pytest` 的极简测试
    * **CORS**
    * **Cookie 会话**
    * ...以及更多。

## 性能

独立 TechEmpower 基准测试显示，**FastAPI** 应用在 Uvicorn 下运行时为<a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">现有最快的 Python 框架之一</a>，仅次于 Starlette 和 Uvicorn（FastAPI 内部使用）。(*)

想了解更多，请阅读 <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">性能基准</a>章节。

## 依赖

FastAPI 依赖 Pydantic 和 Starlette。

### `standard` 依赖

通过 `pip install "fastapi[standard]"` 安装 FastAPI 时，会包含 `standard` 可选依赖组：

Pydantic 用到：

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> —— 用于邮箱验证。

Starlette 用到：

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> —— 如果要使用 `TestClient`，则必需。
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> —— 如果要使用默认模板配置，则必需。
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> —— 如果要支持表单 <abbr title="将 HTTP 请求中的字符串转换为 Python 数据">"解析"</abbr>，即用 `request.form()`，则必需。

FastAPI / Starlette 用到：

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> —— 用于加载和服务你的应用的服务器。包含 `uvicorn[standard]`，其中包括部分高性能所需依赖（如 `uvloop`）。
* `fastapi-cli` —— 提供 `fastapi` 命令行工具。

### 不带 `standard` 依赖

如果不想包含 `standard` 可选依赖，可用 `pip install fastapi` 替代 `pip install "fastapi[standard]"`。

### 其他可选依赖

你可能还想安装一些附加依赖。

Pydantic 额外可选依赖：

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> —— 用于配置管理。
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> —— 提供 Pydantic 可用的额外类型。

FastAPI 附加可选依赖：

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> —— 若需要用 `ORJSONResponse`，则必需。
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> —— 若需要用 `UJSONResponse`，则必需。

## 许可证

本项目基于 MIT 许可证发布。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---