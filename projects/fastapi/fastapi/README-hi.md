<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>FastAPI फ्रेमवर्क, उच्च प्रदर्शन, सीखने में आसान, कोडिंग में तेज़, उत्पादन के लिए तैयार</em>
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

**दस्तावेज़ीकरण**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**स्रोत कोड**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI एक आधुनिक, तेज़ (उच्च प्रदर्शन), वेब फ्रेमवर्क है, जो मानक Python टाइप हिंट्स पर आधारित Python के साथ APIs बनाने के लिए बनाया गया है।

मुख्य विशेषताएँ:

* **तेज़**: बहुत उच्च प्रदर्शन, **NodeJS** और **Go** के बराबर (Starlette और Pydantic के कारण)। [Python के सबसे तेज़ फ्रेमवर्क्स में से एक](#performance)।
* **कोडिंग में तेज़**: फीचर्स विकसित करने की गति लगभग 200% से 300% तक बढ़ाएँ। *
* **कम बग**: मानवीय (डेवलपर) त्रुटियों को लगभग 40% तक कम करें। *
* **इंट्यूटिव**: शानदार संपादक समर्थन। <abbr title="जिसे ऑटो-कम्प्लीट, ऑटोकम्प्लीशन, IntelliSense भी कहा जाता है">कम्प्लीशन</abbr> हर जगह। डिबगिंग में कम समय।
* **आसान**: उपयोग और सीखने में आसान बनाने के लिए डिज़ाइन किया गया। दस्तावेज़ पढ़ने में कम समय।
* **संक्षिप्त**: कोड डुप्लीकेशन को कम करें। प्रत्येक पैरामीटर घोषणा से एकाधिक फीचर्स। कम बग।
* **मजबूत**: उत्पादन के लिए तैयार कोड प्राप्त करें। स्वचालित इंटरैक्टिव दस्तावेज़ीकरण के साथ।
* **मानकों पर आधारित**: APIs के लिए खुले मानकों पर आधारित (और पूरी तरह से संगत): <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a> (जिसे पहले Swagger कहा जाता था) और <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>।

<small>* आंतरिक विकास टीम पर किए गए परीक्षणों के आधार पर अनुमान, जो उत्पादन अनुप्रयोग बना रही थी।</small>

## प्रायोजक

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

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">अन्य प्रायोजक</a>

## विचार

"_[...] मैं इन दिनों **FastAPI** का बहुत उपयोग कर रहा हूँ। [...] मैं वास्तव में इसे अपनी टीम की सभी **ML सेवाओं के लिए Microsoft में** उपयोग करने की योजना बना रहा हूँ। उनमें से कुछ को कोर **Windows** उत्पाद और कुछ **Office** उत्पादों में एकीकृत किया जा रहा है।_"

<div style="text-align: right; margin-right: 10%;">कबीर खान - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(संदर्भ)</small></a></div>

---

"_हमने **FastAPI** लाइब्रेरी को अपनाया ताकि एक **REST** सर्वर बनाया जा सके जिसे **prediction** प्राप्त करने के लिए क्वेरी किया जा सके। [Ludwig के लिए]_"

<div style="text-align: right; margin-right: 10%;">पिएरो मोलिनो, यारोस्लाव डुडिन, और साई सुमंथ मिर्याला - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(संदर्भ)</small></a></div>

---

"_**Netflix** को हमारे **संकट प्रबंधन** ऑर्केस्ट्रेशन फ्रेमवर्क: **Dispatch** का ओपन-सोर्स रिलीज़ घोषित करते हुए खुशी हो रही है! [जो **FastAPI** के साथ बनाया गया]_"

<div style="text-align: right; margin-right: 10%;">केविन ग्लिसन, मार्क विलानोवा, फॉरेस्ट मोंसेन - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(संदर्भ)</small></a></div>

---

"_मैं **FastAPI** को लेकर बहुत उत्साहित हूँ। यह बहुत मजेदार है!_"

<div style="text-align: right; margin-right: 10%;">ब्रायन ओकेन - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">Python Bytes</a> पॉडकास्ट होस्ट</strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(संदर्भ)</small></a></div>

---

"_सच कहूँ तो, आपने जो बनाया है वह बहुत मजबूत और पॉलिश्ड दिखता है। कई मायनों में, यह वही है जो मैं **Hug** के लिए चाहता था - यह देखना प्रेरणादायक है कि किसी ने यह बनाया है।_"

<div style="text-align: right; margin-right: 10%;">टिमोथी क्रॉसली - <strong><a href="https://github.com/hugapi/hug" target="_blank">Hug</a> के निर्माता</strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(संदर्भ)</small></a></div>

---

"_अगर आप REST API बनाने के लिए किसी एक **आधुनिक फ्रेमवर्क** को सीखना चाहते हैं, तो **FastAPI** देखें [...] यह तेज़ है, उपयोग में आसान है और सीखने में भी [...]_"

"_हमने अपने **API** के लिए **FastAPI** पर स्विच कर लिया है [...] मुझे लगता है कि आपको यह पसंद आएगा [...]_"

<div style="text-align: right; margin-right: 10%;">इनेस मोंटानी - मैथ्यू हॉन्निबल - <strong><a href="https://explosion.ai" target="_blank">Explosion AI</a> संस्थापक - <a href="https://spacy.io" target="_blank">spaCy</a> के निर्माता</strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(संदर्भ)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(संदर्भ)</small></a></div>

---

"_अगर कोई उत्पादन स्तर की Python API बनाना चाहता है, तो मैं **FastAPI** की अत्यधिक सिफारिश करूंगा। यह **सुंदर ढंग से डिज़ाइन किया गया**, **उपयोग में सरल** और **बेहद स्केलेबल** है, यह हमारे API-फर्स्ट विकास रणनीति में एक **मुख्य घटक** बन चुका है और हमारे कई ऑटोमेशन व सेवाओं को चला रहा है, जैसे हमारा वर्चुअल TAC इंजीनियर।_"

<div style="text-align: right; margin-right: 10%;">डियोन पिल्सबरी - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(संदर्भ)</small></a></div>

---

## **Typer**, CLI का FastAPI

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

अगर आप टर्मिनल में उपयोग के लिए <abbr title="Command Line Interface">CLI</abbr> ऐप बना रहे हैं (वेब API के बजाय), तो <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a> देखें।

**Typer** FastAPI का छोटा भाई है। और इसे CLI का **FastAPI** होने के लिए बनाया गया है। ⌨️ 🚀

## आवश्यकताएँ

FastAPI दिग्गजों के कंधों पर खड़ा है:

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> वेब हिस्सों के लिए।
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> डेटा हिस्सों के लिए।

## इंस्टॉलेशन

एक <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">वर्चुअल एनवायरनमेंट</a> बनाएँ और सक्रिय करें, फिर FastAPI स्थापित करें:

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**नोट**: सुनिश्चित करें कि आप `"fastapi[standard]"` को उद्धरण चिह्नों में डालते हैं ताकि यह सभी टर्मिनलों में काम करे।

## उदाहरण

### इसे बनाएँ

एक फ़ाइल `main.py` बनाएँ:

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
<summary>या <code>async def</code> का उपयोग करें...</summary>

अगर आपका कोड `async` / `await` का उपयोग करता है, तो `async def` का उपयोग करें:

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

**नोट**:

अगर आप नहीं जानते, तो <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">docs में `async` और `await` के बारे में "In a hurry?" अनुभाग</a> देखें।

</details>

### इसे चलाएँ

सर्वर को निम्न कमांड से चलाएँ:

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
<summary>कमांड <code>fastapi dev main.py</code> के बारे में...</summary>

कमांड `fastapi dev` आपकी `main.py` फ़ाइल पढ़ता है, उसमें **FastAPI** ऐप का पता लगाता है, और <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a> का उपयोग कर सर्वर चालू करता है।

डिफ़ॉल्ट रूप से, `fastapi dev` स्थानीय विकास के लिए ऑटो-रिलोड के साथ शुरू होगा।

आप इसके बारे में अधिक <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">FastAPI CLI docs</a> में पढ़ सकते हैं।

</details>

### इसे जांचें

अपने ब्राउज़र में खोलें: <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>.

आपको JSON प्रतिक्रिया दिखाई देगी:

```JSON
{"item_id": 5, "q": "somequery"}
```

आपने पहले ही एक API बना लिया है जो:

* _paths_ `/` और `/items/{item_id}` पर HTTP अनुरोध प्राप्त करता है।
* दोनों _paths_ `GET` <em>ऑपरेशन</em> (HTTP _methods_ भी कहा जाता है) लेते हैं।
* _path_ `/items/{item_id}` में एक _path पैरामीटर_ `item_id` है जो `int` होना चाहिए।
* _path_ `/items/{item_id}` में एक वैकल्पिक `str` _query parameter_ `q` है।

### इंटरैक्टिव API docs

अब जाएं <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>।

आपको स्वचालित इंटरैक्टिव API दस्तावेज़ीकरण दिखाई देगा (द्वारा प्रदत्त <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a>):

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### वैकल्पिक API docs

अब जाएं <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>।

आपको वैकल्पिक स्वचालित दस्तावेज़ीकरण दिखाई देगा (द्वारा प्रदत्त <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a>):

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## उदाहरण अपग्रेड

अब फ़ाइल `main.py` को संशोधित करें ताकि वह `PUT` अनुरोध से बाड़ी प्राप्त करे।

बाड़ी को मानक Python टाइप्स का उपयोग करके घोषित करें, Pydantic के लिए धन्यवाद।

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

`fastapi dev` सर्वर को अपने आप रीलोड हो जाना चाहिए।

### इंटरैक्टिव API docs अपग्रेड

अब जाएं <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>।

* इंटरैक्टिव API दस्तावेज़ीकरण अपने आप अपडेट हो जाएगा, जिसमें नई बाड़ी भी शामिल होगी:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* "Try it out" बटन पर क्लिक करें, यह आपको पैरामीटर भरने और सीधे API के साथ इंटरैक्ट करने की अनुमति देता है:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* फिर "Execute" बटन पर क्लिक करें, यूजर इंटरफेस आपके API से संवाद करेगा, पैरामीटर भेजेगा, परिणाम प्राप्त करेगा और स्क्रीन पर दिखाएगा:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### वैकल्पिक API docs अपग्रेड

अब जाएं <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>।

* वैकल्पिक दस्तावेज़ीकरण में भी नया क्वेरी पैरामीटर और बाड़ी दिखाई देगी:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### पुनरावलोकन

सारांश में, आप एक **बार** पैरामीटर, बाड़ी आदि के प्रकार को फ़ंक्शन पैरामीटर के रूप में घोषित करते हैं।

आप यह मानक आधुनिक Python टाइप्स के साथ करते हैं।

आपको किसी नई सिंटैक्स, किसी विशेष लाइब्रेरी के मेथड या क्लास को सीखने की आवश्यकता नहीं है।

बस मानक **Python**।

उदाहरण के लिए, किसी `int` के लिए:

```Python
item_id: int
```

या एक जटिल `Item` मॉडल के लिए:

```Python
item: Item
```

...और केवल इस एक घोषणा से आपको मिल जाता है:

* संपादक समर्थन, जिसमें शामिल हैं:
    * कम्प्लीशन।
    * टाइप चेक्स।
* डेटा का सत्यापन:
    * जब डेटा अमान्य हो तो स्वचालित और स्पष्ट त्रुटियाँ।
    * गहराई से नेस्टेड JSON ऑब्जेक्ट्स का भी सत्यापन।
* <abbr title="जिसे सीरियलाइजेशन, पार्सिंग, मार्शलिंग भी कहा जाता है">इनपुट डेटा का रूपांतरण</abbr>: नेटवर्क से Python डेटा और टाइप्स में। पढ़ना:
    * JSON।
    * पाथ पैरामीटर।
    * क्वेरी पैरामीटर।
    * कुकीज।
    * हेडर्स।
    * फॉर्म्स।
    * फाइल्स।
* <abbr title="जिसे सीरियलाइजेशन, पार्सिंग, मार्शलिंग भी कहा जाता है">आउटपुट डेटा का रूपांतरण</abbr>: Python डेटा और टाइप्स से नेटवर्क डेटा (JSON के रूप में) में बदलना:
    * Python टाइप्स (`str`, `int`, `float`, `bool`, `list`, आदि) को बदलें।
    * `datetime` ऑब्जेक्ट्स।
    * `UUID` ऑब्जेक्ट्स।
    * डेटाबेस मॉडल।
    * ...और भी बहुत कुछ।
* स्वचालित इंटरैक्टिव API दस्तावेज़ीकरण, जिसमें 2 वैकल्पिक यूजर इंटरफेस:
    * Swagger UI।
    * ReDoc।

---

पिछले कोड उदाहरण पर लौटते हुए, **FastAPI** करेगा:

* `GET` और `PUT` अनुरोधों के लिए पाथ में `item_id` का सत्यापन।
* `GET` और `PUT` अनुरोधों के लिए `item_id` का प्रकार `int` है इसका सत्यापन।
    * अगर नहीं है, तो क्लाइंट को उपयोगी, स्पष्ट त्रुटि दिखाई देगी।
* `GET` अनुरोधों के लिए नाम `q` वाला वैकल्पिक क्वेरी पैरामीटर देखेगा (जैसे `http://127.0.0.1:8000/items/foo?q=somequery`)।
    * क्योंकि `q` पैरामीटर को `= None` के साथ घोषित किया गया है, यह वैकल्पिक है।
    * बिना `None` के यह आवश्यक होता (जैसे कि बाड़ी `PUT` के मामले में)।
* `/items/{item_id}` के लिए `PUT` अनुरोधों में बाड़ी को JSON के रूप में पढ़ेगा:
    * देखेगा कि इसमें एक आवश्यक गुण `name` है, जो `str` होना चाहिए।
    * देखेगा कि इसमें एक आवश्यक गुण `price` है, जो `float` होना चाहिए।
    * देखेगा कि इसमें एक वैकल्पिक गुण `is_offer` है, जो अगर मौजूद है तो `bool` होना चाहिए।
    * यह सब गहराई से नेस्टेड JSON ऑब्जेक्ट्स के लिए भी काम करेगा।
* अपने आप JSON से और JSON में रूपांतरण करेगा।
* सब कुछ OpenAPI के साथ दस्तावेजीकृत करेगा, जिसका उपयोग किया जा सकता है:
    * इंटरैक्टिव दस्तावेज़ीकरण सिस्टम्स द्वारा।
    * कई भाषाओं के लिए स्वचालित क्लाइंट कोड जनरेशन सिस्टम्स द्वारा।
* सीधे 2 इंटरैक्टिव दस्तावेज़ीकरण वेब इंटरफेस प्रदान करेगा।

---

हमने अभी सतह को छुआ है, लेकिन आपको पहले से ही इसका काम करने का तरीका समझ में आ गया होगा।

लाइन को बदलकर देखें:

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...को:

```Python
        ... "item_name": item.name ...
```

...से:

```Python
        ... "item_price": item.price ...
```

...और देखें कि आपका संपादक गुणों को कैसे ऑटो-कम्प्लीट करेगा और उनके प्रकार जानता है:

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

और अधिक पूर्ण उदाहरण के लिए, जिसमें और भी फीचर्स शामिल हैं, देखें <a href="https://fastapi.tiangolo.com/tutorial/">ट्यूटोरियल - यूजर गाइड</a>।

**स्पॉइलर अलर्ट**: ट्यूटोरियल - यूजर गाइड में शामिल है:

* **parameters** की घोषणा अन्य विभिन्न स्थानों से जैसे: **headers**, **cookies**, **form fields** और **files**।
* कैसे सेट करें **validation constraints** जैसे `maximum_length` या `regex`।
* एक बहुत ही शक्तिशाली और उपयोग में आसान **<abbr title="जिसे components, resources, providers, services, injectables भी कहा जाता है">Dependency Injection</abbr>** सिस्टम।
* सुरक्षा और प्रमाणीकरण, जिसमें **OAuth2** के साथ **JWT tokens** और **HTTP Basic** auth का समर्थन।
* **deeply nested JSON models** घोषित करने के लिए और अधिक उन्नत (लेकिन उतने ही आसान) तकनीकें (Pydantic के कारण)।
* <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> और अन्य लाइब्रेरीज़ के साथ **GraphQL** एकीकरण।
* कई अतिरिक्त सुविधाएँ (Starlette के कारण) जैसे:
    * **WebSockets**
    * HTTPX और `pytest` आधारित अत्यंत आसान परीक्षण
    * **CORS**
    * **Cookie Sessions**
    * ...और भी बहुत कुछ।

## प्रदर्शन

स्वतंत्र TechEmpower बेंचमार्क दिखाते हैं कि Uvicorn के तहत चलने वाले **FastAPI** अनुप्रयोग <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">Python के सबसे तेज़ फ्रेमवर्क्स में से एक</a> हैं, केवल Starlette और Uvicorn (जो अंदरूनी तौर पर FastAPI द्वारा उपयोग किए जाते हैं) से नीचे। (*)

इस बारे में अधिक समझने के लिए देखें <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">Benchmarks</a> अनुभाग।

## निर्भरताएँ

FastAPI, Pydantic और Starlette पर निर्भर करता है।

### `standard` निर्भरताएँ

जब आप FastAPI को `pip install "fastapi[standard]"` से इंस्टॉल करते हैं, तो यह `standard` वैकल्पिक निर्भरताओं के साथ आता है:

Pydantic द्वारा उपयोग किया गया:

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - ईमेल सत्यापन के लिए।

Starlette द्वारा उपयोग किया गया:

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - यदि आप `TestClient` का उपयोग करना चाहते हैं तो आवश्यक।
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - यदि आप डिफ़ॉल्ट टेम्पलेट कॉन्फ़िगरेशन का उपयोग करना चाहते हैं तो आवश्यक।
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - यदि आप फॉर्म <abbr title="HTTP अनुरोध से आने वाली स्ट्रिंग को Python डेटा में बदलना">"पार्सिंग"</abbr> का समर्थन करना चाहते हैं, `request.form()` के साथ।

FastAPI / Starlette द्वारा उपयोग किया गया:

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - आपके अनुप्रयोग को लोड और सेवा देने वाले सर्वर के लिए। इसमें `uvicorn[standard]` शामिल है, जिसमें उच्च प्रदर्शन सेवा के लिए आवश्यक कुछ निर्भरताएँ (जैसे `uvloop`) शामिल हैं।
* `fastapi-cli` - `fastapi` कमांड प्रदान करने के लिए।

### बिना `standard` निर्भरताओं के

अगर आप `standard` वैकल्पिक निर्भरताएँ शामिल नहीं करना चाहते, तो आप `pip install fastapi` से इंस्टॉल कर सकते हैं, बजाय `pip install "fastapi[standard]"` के।

### अतिरिक्त वैकल्पिक निर्भरताएँ

कुछ अतिरिक्त निर्भरताएँ हैं जिन्हें आप इंस्टॉल करना चाह सकते हैं।

अतिरिक्त वैकल्पिक Pydantic निर्भरताएँ:

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - सेटिंग्स प्रबंधन के लिए।
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - Pydantic के साथ उपयोग के लिए अतिरिक्त प्रकारों के लिए।

अतिरिक्त वैकल्पिक FastAPI निर्भरताएँ:

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - यदि आप `ORJSONResponse` का उपयोग करना चाहते हैं तो आवश्यक।
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - यदि आप `UJSONResponse` का उपयोग करना चाहते हैं तो आवश्यक।

## लाइसेंस

यह परियोजना MIT लाइसेंस की शर्तों के तहत लाइसेंस प्राप्त है।


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---