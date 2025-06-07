<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>FastAPI framework, yüksek performans, öğrenmesi kolay, hızlı kodlama, üretime hazır</em>
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

**Dokümantasyon**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**Kaynak Kod**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI, standart Python tip ipuçlarına dayalı, Python ile API'ler oluşturmak için modern, hızlı (yüksek performanslı) bir web framework'üdür.

Temel özellikler:

* **Hızlı**: Çok yüksek performans, **NodeJS** ve **Go** ile kıyaslanabilir (**Starlette** ve **Pydantic** sayesinde). [Mevcut en hızlı Python framework'lerinden biri](#performance).
* **Hızlı kodlama**: Özellik geliştirme hızını yaklaşık %200 ila %300 artırır. *
* **Daha az hata**: İnsan (geliştirici) kaynaklı hataları yaklaşık %40 azaltır. *
* **Sezgisel**: Harika editör desteği. <abbr title="otomatik tamamlayıcı, autocompletion, IntelliSense olarak da bilinir">Tamamlama</abbr> her yerde. Daha az hata ayıklama zamanı.
* **Kolay**: Kullanımı ve öğrenmesi kolay olacak şekilde tasarlanmıştır. Daha az doküman okuma süresi.
* **Kısa**: Kod tekrarını en aza indirir. Her parametre deklarasyonundan birden fazla özellik. Daha az hata.
* **Sağlam**: Üretime hazır kod elde edin. Otomatik interaktif dokümantasyon ile.
* **Standartlara dayalı**: API'ler için açık standartlara dayalıdır (ve tamamen uyumludur): <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a> (önceden Swagger olarak biliniyordu) ve <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>.

<small>* üretim uygulamaları geliştiren dahili bir geliştirme ekibinde yapılan testlere dayalı tahmindir.</small>

## Sponsorlar

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

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">Diğer sponsorlar</a>

## Görüşler

"_[...] Şu aralar **FastAPI**'yi çok sık kullanıyorum. [...] Aslında tüm ekibimin **ML servisleri için Microsoft'ta** kullanmayı planlıyorum. Bazıları ana **Windows** ürününe ve bazı **Office** ürünlerine entegre ediliyor._"

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(ref)</small></a></div>

---

"_**FastAPI** kütüphanesini, sorgulanabilen bir **REST** sunucusu oluşturmak için benimsedik ve **tahminler** elde ettik. [Ludwig için]_"

<div style="text-align: right; margin-right: 10%;">Piero Molino, Yaroslav Dudin ve Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(ref)</small></a></div>

---

"_**Netflix**, **kriz yönetimi** orkestrasyon framework'ümüz **Dispatch**'in açık kaynak sürümünü duyurmaktan memnuniyet duyar! [**FastAPI** ile oluşturuldu]_"

<div style="text-align: right; margin-right: 10%;">Kevin Glisson, Marc Vilanova, Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(ref)</small></a></div>

---

"_**FastAPI** için çok heyecanlıyım. Çok eğlenceli!_"

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">Python Bytes</a> podcast sunucusu</strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(ref)</small></a></div>

---

"_Dürüst olmak gerekirse, inşa ettiğiniz şey gerçekten sağlam ve cilalı görünüyor. Birçok açıdan, **Hug**'ı olmasını istediğim şey buydu - birinin bunu inşa ettiğini görmek ilham verici._"

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">Hug</a> yaratıcısı</strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(ref)</small></a></div>

---

"_REST API'ler oluşturmak için bir **modern framework** öğrenmek istiyorsanız, **FastAPI**'ye göz atın [...] Hızlı, kullanımı ve öğrenmesi kolay [...]_"

"_**API**'lerimiz için **FastAPI**'ye geçtik [...] Bence siz de seveceksiniz [...]_"

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">Explosion AI</a> kurucuları - <a href="https://spacy.io" target="_blank">spaCy</a> yaratıcıları</strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(ref)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(ref)</small></a></div>

---

"_Üretim ortamında bir Python API oluşturmak isteyen herkese **FastAPI**'yi şiddetle tavsiye ederim. **Harika tasarlanmış**, **kullanımı basit** ve **son derece ölçeklenebilir**, API tabanlı geliştirme stratejimizin **ana bileşeni** haline geldi ve birçok otomasyon ve servisi, örneğin Sanal TAC Mühendisimiz, yönetiyor._"

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(ref)</small></a></div>

---

## **Typer**, CLI'lerin FastAPI'si

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

Eğer bir <abbr title="Komut Satırı Arayüzü">CLI</abbr> uygulaması geliştiriyorsanız ve bunu terminalde kullanacaksanız, <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a>'a göz atın.

**Typer**, FastAPI'nin küçük kardeşidir. Ve **CLI'lerin FastAPI'si** olması amaçlanmıştır. ⌨️ 🚀

## Gereksinimler

FastAPI devlerin omuzlarında yükselir:

* Web tarafı için <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a>.
* Veri tarafı için <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a>.

## Kurulum

Bir <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">sanallaştırılmış ortam</a> oluşturun ve etkinleştirin, ardından FastAPI'yi kurun:

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**Not**: Tüm terminallerde çalışmasını sağlamak için `"fastapi[standard]"` ifadesini tırnak içinde yazdığınızdan emin olun.

## Örnek

### Oluştur

Aşağıdaki gibi bir `main.py` dosyası oluşturun:

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
<summary>Veya <code>async def</code> kullanın...</summary>

Kodunuz `async` / `await` kullanıyorsa, `async def` kullanın:

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

**Not**:

Bilmiyorsanız, dökümantasyondaki <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` ve `await` hakkındaki _"Aceleniz mi var?"_ bölümüne bakın</a>.

</details>

### Çalıştır

Sunucuyu şu komutla başlatın:

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
<summary><code>fastapi dev main.py</code> komutu hakkında...</summary>

`fastapi dev` komutu, `main.py` dosyanızı okur, içindeki **FastAPI** uygulamasını algılar ve bir sunucuyu <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a> ile başlatır.

Varsayılan olarak, `fastapi dev` yerel geliştirme için otomatik yeniden yüklemeyle başlar.

Daha fazlası için <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">FastAPI CLI dökümantasyonuna</a> bakabilirsiniz.

</details>

### Kontrol et

Tarayıcınızı açın ve <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a> adresine gidin.

JSON yanıtını şu şekilde göreceksiniz:

```JSON
{"item_id": 5, "q": "somequery"}
```

Zaten şu özelliklere sahip bir API oluşturdunuz:

* `/` ve `/items/{item_id}` _yollarında_ HTTP istekleri alır.
* Her iki _yol_ da `GET` <em>operasyonlarını</em> (HTTP _metotları olarak da bilinir) alır.
* `/items/{item_id}` _yolunda_ `item_id` adlı bir _yol parametresi_ vardır ve bu bir `int` olmalıdır.
* `/items/{item_id}` _yolunda_ isteğe bağlı bir `str` _sorgu parametresi_ `q` vardır.

### İnteraktif API dokümantasyonu

Şimdi <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a> adresine gidin.

Otomatik olarak oluşturulan interaktif API dokümantasyonunu göreceksiniz (sağlayan: <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a>):

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### Alternatif API dokümantasyonu

Şimdi de <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a> adresine gidin.

Alternatif otomatik dokümantasyonu göreceksiniz (sağlayan: <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a>):

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## Örnek geliştirme

Şimdi `main.py` dosyasını bir `PUT` isteğiyle gövdeden veri alacak şekilde değiştirin.

Gövdeyi standart Python tipleriyle tanımlayın (Pydantic sayesinde).

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

`fastapi dev` sunucusu otomatik olarak yeniden yüklenecektir.

### İnteraktif API dokümantasyonu güncellemesi

Şimdi <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a> adresine gidin.

* İnteraktif API dokümantasyonu otomatik olarak güncellenecek ve yeni gövdeyi içerecek:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* "Try it out" butonuna tıklayın, bu parametreleri doldurmanıza ve doğrudan API ile etkileşim kurmanıza olanak tanır:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* Ardından "Execute" düğmesine tıklayın, kullanıcı arayüzü API'nizle iletişim kuracak, parametreleri gönderecek, sonuçları alacak ve ekranda gösterecektir:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### Alternatif API dokümantasyonu güncellemesi

Şimdi de <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a> adresine gidin.

* Alternatif dokümantasyon da yeni sorgu parametresini ve gövdeyi yansıtacaktır:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### Özet

Kısacası, parametrelerin, gövdenin vb. tiplerini **bir kez** fonksiyon parametreleri olarak tanımlarsınız.

Bunu standart modern Python tipleriyle yaparsınız.

Yeni bir sözdizimi, belirli bir kütüphanenin metot veya sınıflarını öğrenmenize gerek yoktur.

Sadece standart **Python**.

Örneğin bir `int` için:

```Python
item_id: int
```

ya da daha karmaşık bir `Item` modeli için:

```Python
item: Item
```

...ve bu tek bildirim ile şunları elde edersiniz:

* Editör desteği, şunlar dahil:
    * Tamamlama.
    * Tip kontrolü.
* Veri doğrulama:
    * Veri geçersiz olduğunda otomatik ve açık hatalar.
    * Derin iç içe geçmiş JSON nesneleri için bile doğrulama.
* Girdi verisinin <abbr title="serileştirme, ayrıştırma, marshalling olarak da bilinir">Dönüştürülmesi</abbr>: Ağdan gelen verilerin Python veri ve tiplerine dönüştürülmesi. Şuradan okuma:
    * JSON.
    * Yol parametreleri.
    * Sorgu parametreleri.
    * Çerezler.
    * Başlıklar.
    * Formlar.
    * Dosyalar.
* Çıkış verisinin <abbr title="serileştirme, ayrıştırma, marshalling olarak da bilinir">Dönüştürülmesi</abbr>: Python veri ve tiplerinden ağ verisine (JSON olarak) dönüştürülmesi:
    * Python tipleri (`str`, `int`, `float`, `bool`, `list` vb.).
    * `datetime` nesneleri.
    * `UUID` nesneleri.
    * Veritabanı modelleri.
    * ...ve daha fazlası.
* Otomatik interaktif API dokümantasyonu, 2 alternatif kullanıcı arayüzü dahil:
    * Swagger UI.
    * ReDoc.

---

Önceki kod örneğine dönersek, **FastAPI** şunları yapacaktır:

* `GET` ve `PUT` istekleri için yolda bir `item_id` olup olmadığını doğrular.
* `GET` ve `PUT` istekleri için `item_id`'nin `int` tipinde olup olmadığını doğrular.
    * Değilse, istemciye faydalı, açık bir hata gösterilir.
* `GET` istekleri için `q` adında isteğe bağlı bir sorgu parametresi olup olmadığını kontrol eder (ör. `http://127.0.0.1:8000/items/foo?q=somequery`).
    * `q` parametresi `= None` ile tanımlandığı için isteğe bağlıdır.
    * `None` olmadan zorunlu olurdu (PUT ile gövde gibi).
* `/items/{item_id}` yoluna gelen `PUT` isteklerinde gövdeyi JSON olarak okur:
    * Zorunlu bir `name` özelliği olup olmadığını ve bunun bir `str` olup olmadığını kontrol eder.
    * Zorunlu bir `price` özelliği olup olmadığını ve bunun bir `float` olup olmadığını kontrol eder.
    * Varsa, `is_offer` adlı isteğe bağlı bir özelliğin olup olmadığını ve bunun bir `bool` olup olmadığını kontrol eder.
    * Tüm bunlar, derin iç içe geçmiş JSON nesneleri için de geçerlidir.
* JSON'a otomatik olarak dönüştürür ve JSON'dan okur.
* Her şeyi OpenAPI ile dokümante eder; bu da şunlar tarafından kullanılabilir:
    * İnteraktif dokümantasyon sistemleri.
    * Birçok dil için otomatik istemci kodu üretme sistemleri.
* Doğrudan 2 interaktif dokümantasyon web arayüzü sağlar.

---

Sadece yüzeyine dokunduk, ama zaten her şeyin nasıl çalıştığını görebiliyorsunuz.

Şu satırı değiştirin:

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...şu satırdan:

```Python
        ... "item_name": item.name ...
```

...şuna:

```Python
        ... "item_price": item.price ...
```

...ve editörünüzün otomatik tamamlamasını ve tipleri nasıl bildiğini görün:

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

Daha kapsamlı bir örnek için <a href="https://fastapi.tiangolo.com/tutorial/">Tutorial - Kullanıcı Rehberi</a>'ne bakın.

**Spoiler**: tutorial - kullanıcı rehberi şunları içerir:

* **Parametrelerin** farklı yerlerden (ör: **başlıklar**, **çerezler**, **form alanları**, **dosyalar**) tanımlanması.
* `maximum_length` veya `regex` gibi **doğrulama kısıtlamalarının** nasıl ayarlanacağı.
* Çok güçlü ve kullanımı kolay bir **<abbr title="bileşenler, kaynaklar, sağlayıcılar, servisler, injectables olarak da bilinir">Bağımlılık Enjeksiyonu</abbr>** sistemi.
* Güvenlik ve kimlik doğrulama, **JWT tokenları** ile **OAuth2** ve **HTTP Basic** kimlik doğrulama desteği dahil.
* **Derin iç içe geçmiş JSON modelleri** tanımlamak için daha gelişmiş (ama aynı derecede kolay) teknikler (Pydantic sayesinde).
* <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> ve diğer kütüphanelerle **GraphQL** entegrasyonu.
* Starlette sayesinde birçok ekstra özellik:
    * **WebSockets**
    * HTTPX ve `pytest` tabanlı son derece kolay testler
    * **CORS**
    * **Cookie Sessions**
    * ...ve daha fazlası.

## Performans

Bağımsız TechEmpower karşılaştırmaları, Uvicorn altında çalışan **FastAPI** uygulamalarının <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">mevcut en hızlı Python framework'lerinden biri</a> olduğunu göstermektedir, sadece Starlette ve Uvicorn'un (FastAPI tarafından dahili olarak kullanılır) altında. (*)

Daha fazla bilgi için <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">Karşılaştırmalar</a> bölümüne bakın.

## Bağımlılıklar

FastAPI, Pydantic ve Starlette'e bağımlıdır.

### `standard` Bağımlılıkları

FastAPI'yi `pip install "fastapi[standard]"` ile kurduğunuzda, `standard` grubu isteğe bağlı bağımlılıklarla birlikte gelir:

Pydantic tarafından kullanılan:

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - e-posta doğrulama için.

Starlette tarafından kullanılan:

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - `TestClient` kullanmak istiyorsanız gereklidir.
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - Varsayılan şablon yapılandırmasını kullanmak istiyorsanız gereklidir.
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - Form <abbr title="HTTP isteğinden gelen string veriyi Python verisine dönüştürmek">"ayrıştırma"</abbr> desteği için, `request.form()` ile gereklidir.

FastAPI / Starlette tarafından kullanılan:

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - Uygulamanızı yükleyip sunan sunucu için. Bu, yüksek performanslı sunum için gereken bazı bağımlılıkları (`uvloop` gibi) içeren `uvicorn[standard]` paketini de kapsar.
* `fastapi-cli` - `fastapi` komutunu sağlamak için.

### `standard` Bağımlılıkları Olmadan

İsteğe bağlı `standard` bağımlılıkları dahil etmek istemiyorsanız, `pip install fastapi` ile kurabilirsiniz (`pip install "fastapi[standard]"` yerine).

### Ek İsteğe Bağlı Bağımlılıklar

Kurmak isteyebileceğiniz bazı ek bağımlılıklar vardır.

Ek isteğe bağlı Pydantic bağımlılıkları:

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - ayar yönetimi için.
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - Pydantic ile kullanılacak ek tipler için.

Ek isteğe bağlı FastAPI bağımlılıkları:

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - `ORJSONResponse` kullanmak istiyorsanız gereklidir.
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - `UJSONResponse` kullanmak istiyorsanız gereklidir.

## Lisans

Bu proje MIT lisansı koşulları altında lisanslanmıştır.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---