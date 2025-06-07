<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>FastAPI 框架，高效能、易學習、快速開發、適用於生產環境</em>
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

**文件**：<a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**原始碼**：<a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI 是一個現代化、快速（高效能）的 Web 框架，用於基於標準 Python 型別提示構建 API。

主要特點：

* **快速**：效能非常高，可與 **NodeJS** 和 **Go** 相媲美（感謝 Starlette 和 Pydantic）。[是現有最快的 Python 框架之一](#performance)。
* **開發速度快**：功能開發速度提高約 200% 至 300%。 *
* **錯誤更少**：減少約 40% 的人為（開發者）錯誤。 *
* **直觀**：卓越的編輯器支援。<abbr title="又稱自動補全、自動完成、IntelliSense">自動補全</abbr>無處不在。減少除錯時間。
* **易學易用**：設計上易於使用與學習。減少閱讀文件的時間。
* **簡潔**：最小化程式碼重複。每個參數宣告可產生多個功能。減少錯誤。
* **穩健**：獲得適用於生產環境的程式碼。自動產生互動文件。
* **標準化**：基於（並完全相容於）API 的開放標準：<a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a>（前稱 Swagger）和 <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>。

<small>* 估算數據來自於內部開發團隊構建生產應用的測試。</small>

## 贊助商

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

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">其他贊助商</a>

## 各界看法

「_[...] 我最近大量使用 **FastAPI**。[...] 我其實打算把它用於我在微軟團隊的所有 **ML 服務**。有些服務已被整合進 **Windows** 及部份 **Office** 產品中。_」

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(來源)</small></a></div>

---

「_我們採用 **FastAPI** 函式庫來啟動一個 **REST** 伺服器，方便查詢 **預測結果**。（用於 Ludwig）_」

<div style="text-align: right; margin-right: 10%;">Piero Molino, Yaroslav Dudin, and Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(來源)</small></a></div>

---

「_**Netflix** 很高興宣布開源我們的 **危機管理** 協作框架：**Dispatch**！（以 **FastAPI** 架構）_」

<div style="text-align: right; margin-right: 10%;">Kevin Glisson, Marc Vilanova, Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(來源)</small></a></div>

---

「_我對 **FastAPI** 感到無比興奮。真的太有趣了！_」

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">Python Bytes</a> 播客主持人</strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(來源)</small></a></div>

---

「_說真的，你做得很扎實、很精緻。很多層面上，這就是我期望 **Hug** 能達到的樣子——看到有人完成這件事真的很激勵人心。_」

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">Hug</a> 創建人</strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(來源)</small></a></div>

---

「_如果你想學習一個現代 **REST API 框架**，請看看 **FastAPI** [...] 它快、好用、學習門檻低 [...]_」

「_我們已將 API 切換到 **FastAPI** [...] 我想你會喜歡 [...]_」

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">Explosion AI</a> 創辦人 - <a href="https://spacy.io" target="_blank">spaCy</a> 創建人</strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(來源)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(來源)</small></a></div>

---

「_如果有人打算開發生產用的 Python API，我強烈推薦 **FastAPI**。設計優美、簡單易用且高度可擴展，已成為我們 API 優先開發策略的關鍵組件，推動了許多自動化與服務（如我們的虛擬 TAC 工程師）。_」

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(來源)</small></a></div>

---

## **Typer**，CLI 版的 FastAPI

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

如果你要打造一個在終端機中運作的 <abbr title="命令列介面">CLI</abbr> 應用，而不是 Web API，請參考 <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a>。

**Typer** 是 FastAPI 的小兄弟。它的目標就是成為 **CLI 世界的 FastAPI**。⌨️ 🚀

## 系統需求

FastAPI 建立於多個巨人的肩膀上：

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> —— 提供 Web 功能。
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> —— 處理資料部分。

## 安裝

建立並啟動一個 <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">虛擬環境</a>，然後安裝 FastAPI：

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**注意**：請將 `"fastapi[standard]"` 加上引號，以確保在所有終端機都能正確執行。

## 範例

### 建立

建立一個 `main.py` 檔案，內容如下：

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
<summary>或使用 <code>async def</code> ...</summary>

如果你的程式碼使用了 `async` / `await`，請採用 `async def`：

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

如果不瞭解，請參考文件中 <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` 與 `await` 的「In a hurry?」章節</a>。

</details>

### 執行

以以下指令啟動伺服器：

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
<summary>關於 <code>fastapi dev main.py</code> 指令...</summary>

`fastapi dev` 指令會讀取你的 `main.py` 檔案，自動偵測其中的 **FastAPI** 應用，並以 <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a> 啟動伺服器。

預設情況下，`fastapi dev` 會啟用自動重新載入功能，適合本地開發。

詳情請參閱 <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">FastAPI CLI 文件</a>。

</details>

### 檢查

於瀏覽器開啟 <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>。

你將看到如下 JSON 回應：

```JSON
{"item_id": 5, "q": "somequery"}
```

你已經建立了一個 API，其：

* 接收 `/` 和 `/items/{item_id}` 這兩個 _路徑_ 的 HTTP 請求。
* 這兩個 _路徑_ 都接受 `GET` <em>操作</em>（亦即 HTTP _方法_）。
* 路徑 `/items/{item_id}` 包含一個必須的 _路徑參數_ `item_id`，型別為 `int`。
* 路徑 `/items/{item_id}` 可選擇性帶上 `str` 型別的 _查詢參數_ `q`。

### 互動式 API 文件

現在開啟 <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>。

你會看到自動產生的互動式 API 文件（由 <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a> 提供）：

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### 替代 API 文件

接著，前往 <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>。

你會看到另一種自動產生的文件（由 <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a> 提供）：

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## 範例進階

現在修改 `main.py`，讓它能接受 `PUT` 請求的 body。

感謝 Pydantic，可利用標準 Python 型別宣告請求 body。

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

`fastapi dev` 伺服器應會自動重新載入。

### 互動式 API 文件升級

現在前往 <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>。

* 互動式 API 文件將自動更新，包含新的請求 body：

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* 點擊 "Try it out" 按鈕，可填入參數並直接與 API 互動：

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* 再點擊 "Execute" 按鈕，介面會與你的 API 溝通、傳送參數、取得結果並顯示：

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### 替代 API 文件升級

然後到 <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>。

* 替代文件也會反映新的查詢參數與 body：

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### 總結

總結來說，你**只需宣告一次**參數、body 等型別於函式參數中。

這一切皆可用標準現代 Python 型別完成。

你不需學習新語法、特殊函式庫的方法或類別等。

純粹使用標準 **Python**。

例如，宣告 `int` 型別：

```Python
item_id: int
```

或更複雜的 `Item` 模型：

```Python
item: Item
```

...只需這一個宣告，你就能獲得：

* 編輯器支援，包含：
    * 自動補全。
    * 型別檢查。
* 資料驗證：
    * 當資料無效時，自動且明確的錯誤訊息。
    * 支援深度巢狀的 JSON 物件驗證。
* <abbr title="又稱：序列化、解析、封送">輸入資料轉換</abbr>：將網路來的資料轉為 Python 型別。支援來源：
    * JSON。
    * 路徑參數。
    * 查詢參數。
    * Cookie。
    * 標頭。
    * 表單。
    * 檔案。
* <abbr title="又稱：序列化、解析、封送">輸出資料轉換</abbr>：將 Python 型別轉為網路資料（如 JSON）：
    * 支援 Python 型別（`str`、`int`、`float`、`bool`、`list` 等）。
    * `datetime` 物件。
    * `UUID` 物件。
    * 資料庫模型。
    * ...以及更多。
* 自動互動式 API 文件，包含兩種界面：
    * Swagger UI。
    * ReDoc。

---

回到前面的程式碼範例，**FastAPI** 會：

* 驗證 `GET` 和 `PUT` 請求的路徑中有 `item_id`。
* 驗證 `item_id` 型別為 `int`（針對 `GET` 與 `PUT` 請求）。
    * 若不是，客戶端會收到清楚明確的錯誤。
* 檢查 `GET` 請求是否有名為 `q` 的可選查詢參數（如 `http://127.0.0.1:8000/items/foo?q=somequery`）。
    * `q` 參數預設為 `= None`，因此為可選。
    * 若無 `None` 則為必填（如 `PUT` 請求的 body）。
* `PUT` 請求至 `/items/{item_id}` 時，將 body 當成 JSON 讀取：
    * 驗證必填屬性 `name` 為 `str`。
    * 驗證必填屬性 `price` 為 `float`。
    * 驗證可選屬性 `is_offer`，如有則須為 `bool`。
    * 這套驗證也適用於深度巢狀的 JSON。
* 自動處理 JSON 的轉換。
* 以 OpenAPI 格式記錄所有內容，可被下列利用：
    * 互動式文件系統。
    * 多語言自動客戶端程式碼產生器。
* 直接提供兩種互動式文件網頁介面。

---

這只是一個起步範例，但你已大致理解其運作方式。

試著將下方程式碼：

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...中的：

```Python
        ... "item_name": item.name ...
```

...改成：

```Python
        ... "item_price": item.price ...
```

...然後看看你的編輯器如何自動補全屬性並辨識型別：

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

更多包含進階功能的範例，請見 <a href="https://fastapi.tiangolo.com/tutorial/">教學 - 使用者指南</a>。

**劇透提示**：教學 - 使用者指南內容涵蓋：

* 從 **headers**、**cookies**、**表單欄位**、**檔案**等不同來源宣告**參數**。
* 如何設定如 `maximum_length` 或 `regex` 的**驗證條件**。
* 一套強大且易用的 **<abbr title="又稱元件、資源、提供者、服務、注入物">依賴注入</abbr>** 系統。
* 安全與認證，包含支援 **OAuth2**（含 **JWT token**）及 **HTTP Basic** 認證。
* 進階（但同樣簡單）的**深度巢狀 JSON 模型宣告**（感謝 Pydantic）。
* 與 <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> 等函式庫整合的 **GraphQL**。
* 更多額外功能（感謝 Starlette），例如：
    * **WebSockets**
    * 基於 HTTPX 與 `pytest` 的超簡單測試
    * **CORS**
    * **Cookie Sessions**
    * ...等。

## 效能

獨立的 TechEmpower 基準測試顯示，**FastAPI** 應用在 Uvicorn 執行下是 <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">現有最快的 Python 框架之一</a>，僅次於 Starlette 與 Uvicorn（FastAPI 內部即使用這兩者）。(*)

欲了解更多，請見 <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">基準測試</a>章節。

## 依賴函式庫

FastAPI 依賴 Pydantic 與 Starlette。

### `standard` 依賴

安裝 FastAPI 時用 `pip install "fastapi[standard]"`，將會安裝 `standard` 群組的可選依賴：

Pydantic 相關：

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - 驗證電子郵件用。

Starlette 相關：

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - 若要使用 `TestClient` 必須安裝。
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - 若要使用預設樣板配置必須安裝。
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - 若要支援表單 <abbr title="將 HTTP 請求中的字串轉為 Python 資料">「解析」</abbr>，即 `request.form()`，必須安裝。

FastAPI / Starlette 相關：

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - 作為載入與服務應用的伺服器。包含 `uvicorn[standard]`，其中含有高效能服務所需的依賴（如 `uvloop`）。
* `fastapi-cli` - 提供 `fastapi` 指令。

### 無 `standard` 依賴

若你不想安裝 `standard` 可選依賴，可直接執行 `pip install fastapi`（而非 `pip install "fastapi[standard]"`）。

### 其他可選依賴

你可能還需要安裝其他依賴。

Pydantic 相關可選依賴：

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - 管理設定用。
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - 提供 Pydantic 額外型別。

FastAPI 相關可選依賴：

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - 若要使用 `ORJSONResponse` 必須安裝。
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - 若要使用 `UJSONResponse` 必須安裝。

## 授權

本專案採用 MIT 授權條款。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---