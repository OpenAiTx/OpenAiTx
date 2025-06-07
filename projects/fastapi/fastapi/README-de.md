<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>FastAPI-Framework, hohe Performance, leicht zu erlernen, schnell zu programmieren, bereit für den Produktionseinsatz</em>
</p>
<p align="center">
<a href="https://github.com/fastapi/fastapi/actions?query=workflow%3ATest+event%3Apush+branch%3Amaster" target="_blank">
    <img src="https://github.com/fastapi/fastapi/actions/workflows/test.yml/badge.svg?event=push&branch=master" alt="Test">
</a>
<a href="https://coverage-badge.samuelcolvin.workers.dev/redirect/fastapi/fastapi" target="_blank">
    <img src="https://coverage-badge.samuelcolvin.workers.dev/fastapi/fastapi.svg" alt="Coverage">
</a>
<a href="https://pypi.org/project/fastapi" target="_blank">
    <img src="https://img.shields.io/pypi/v/fastapi?color=%2334D058&label=pypi%20package" alt="Paketversion">
</a>
<a href="https://pypi.org/project/fastapi" target="_blank">
    <img src="https://img.shields.io/pypi/pyversions/fastapi.svg?color=%2334D058" alt="Unterstützte Python-Versionen">
</a>
</p>

---

**Dokumentation**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**Quellcode**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI ist ein modernes, schnelles (leistungsstarkes) Web-Framework zur Erstellung von APIs mit Python, basierend auf den Standard-Python-Typannotationen.

Die wichtigsten Merkmale sind:

* **Schnell**: Sehr hohe Performance, vergleichbar mit **NodeJS** und **Go** (dank Starlette und Pydantic). [Eines der schnellsten verfügbaren Python-Frameworks](#performance).
* **Schnell zu programmieren**: Steigert die Geschwindigkeit bei der Entwicklung von Funktionen um ca. 200% bis 300%. *
* **Weniger Fehler**: Reduziert etwa 40% der von Entwicklern verursachten Fehler. *
* **Intuitiv**: Hervorragende Unterstützung durch Editoren. <abbr title="auch bekannt als Auto-Complete, Autovervollständigung, IntelliSense">Vervollständigung</abbr> überall. Weniger Zeit beim Debuggen.
* **Einfach**: Entwickelt, um leicht zu bedienen und zu erlernen zu sein. Weniger Zeit beim Lesen der Dokumentation.
* **Kurz**: Minimiert Code-Duplikation. Mehrere Funktionen aus jeder Parameterdeklaration. Weniger Fehler.
* **Robust**: Produktionsreifer Code. Mit automatischer, interaktiver Dokumentation.
* **Standardbasiert**: Basierend auf (und vollständig kompatibel mit) den offenen Standards für APIs: <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a> (früher bekannt als Swagger) und <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>.

<small>* Schätzung basierend auf Tests in einem internen Entwicklungsteam, das Produktionsanwendungen erstellt.</small>

## Sponsoren

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

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">Weitere Sponsoren</a>

## Meinungen

"_[...] Ich benutze **FastAPI** in letzter Zeit sehr viel. [...] Ich plane tatsächlich, es für alle **ML-Services meines Teams bei Microsoft** zu verwenden. Einige davon werden in das Kernprodukt **Windows** und einige **Office**-Produkte integriert._"

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(ref)</small></a></div>

---

"_Wir haben die **FastAPI**-Bibliothek verwendet, um einen **REST**-Server zu starten, der abgefragt werden kann, um **Vorhersagen** zu erhalten. [für Ludwig]_"

<div style="text-align: right; margin-right: 10%;">Piero Molino, Yaroslav Dudin und Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(ref)</small></a></div>

---

"_**Netflix** freut sich, die Open-Source-Veröffentlichung unseres **Krisenmanagement**-Orchestrierungsframeworks **Dispatch** anzukündigen! [entwickelt mit **FastAPI**]_"

<div style="text-align: right; margin-right: 10%;">Kevin Glisson, Marc Vilanova, Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(ref)</small></a></div>

---

"_Ich bin total begeistert von **FastAPI**. Es macht so viel Spaß!_"

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">Python Bytes</a> Podcast-Host</strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(ref)</small></a></div>

---

"_Ehrlich gesagt, das, was du gebaut hast, sieht super solide und ausgereift aus. In vielerlei Hinsicht ist es das, was ich wollte, dass **Hug** sein soll – es ist wirklich inspirierend, zu sehen, dass jemand das gebaut hat._"

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">Hug</a> Entwickler</strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(ref)</small></a></div>

---

"_Wenn du ein **modernes Framework** zum Erstellen von REST-APIs lernen möchtest, schau dir **FastAPI** an [...] Es ist schnell, einfach zu benutzen und leicht zu erlernen [...]_"

"_Wir sind für unsere **APIs** auf **FastAPI** umgestiegen [...] Ich denke, es wird dir gefallen [...]_"

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">Explosion AI</a> Gründer - <a href="https://spacy.io" target="_blank">spaCy</a> Entwickler</strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(ref)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(ref)</small></a></div>

---

"_Wenn jemand eine Produktions-Python-API bauen möchte, kann ich **FastAPI** sehr empfehlen. Es ist **wunderschön gestaltet**, **einfach zu benutzen** und **hoch skalierbar**. Es ist zu einem **zentralen Bestandteil** unserer API-First-Entwicklungsstrategie geworden und treibt viele Automatisierungen und Dienste wie unseren Virtual TAC Engineer an._"

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(ref)</small></a></div>

---

## **Typer**, das FastAPI der CLIs

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

Wenn du eine <abbr title="Command Line Interface">CLI</abbr>-App für das Terminal anstelle einer Web-API entwickelst, schaue dir <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a> an.

**Typer** ist der kleine Bruder von FastAPI. Und soll das **FastAPI für CLIs** sein. ⌨️ 🚀

## Voraussetzungen

FastAPI steht auf den Schultern von Giganten:

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> für die Web-Komponenten.
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> für die Daten-Komponenten.

## Installation

Lege eine <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">virtuelle Umgebung</a> an und aktiviere sie, dann installiere FastAPI:

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**Hinweis**: Setze `"fastapi[standard]"` in Anführungszeichen, damit der Befehl in allen Terminals funktioniert.

## Beispiel

### Erstelle es

Erstelle eine Datei `main.py` mit folgendem Inhalt:

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
<summary>Oder verwende <code>async def</code>...</summary>

Wenn dein Code `async` / `await` verwendet, nutze `async def`:

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

**Hinweis**:

Falls du unsicher bist, schau dir den Abschnitt _"In a hurry?"_ über <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` und `await` in der Dokumentation</a> an.

</details>

### Starte es

Starte den Server mit:

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
<summary>Über den Befehl <code>fastapi dev main.py</code>...</summary>

Der Befehl `fastapi dev` liest deine `main.py`-Datei, erkennt die **FastAPI**-App darin und startet einen Server mit <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a>.

Standardmäßig startet `fastapi dev` mit aktiviertem Auto-Reload für die lokale Entwicklung.

Weitere Informationen findest du in der <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">FastAPI CLI-Dokumentation</a>.

</details>

### Prüfe es

Öffne deinen Browser unter <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>.

Du siehst die JSON-Antwort:

```JSON
{"item_id": 5, "q": "somequery"}
```

Du hast bereits eine API erstellt, die:

* HTTP-Anfragen auf den _Pfade_ `/` und `/items/{item_id}` entgegennimmt.
* Beide _Pfade_ nehmen `GET`-<em>Operationen</em> (auch bekannt als HTTP-_Methoden_) entgegen.
* Der _Pfad_ `/items/{item_id}` hat einen _Pfadparameter_ `item_id`, der ein `int` sein muss.
* Der _Pfad_ `/items/{item_id}` hat einen optionalen `str`-_Query-Parameter_ `q`.

### Interaktive API-Dokumentation

Gehe jetzt zu <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

Du siehst die automatische interaktive API-Dokumentation (bereitgestellt von <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a>):

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### Alternative API-Dokumentation

Und jetzt gehe zu <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

Du siehst die alternative automatische Dokumentation (bereitgestellt von <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a>):

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## Beispiel-Upgrade

Ändere nun die Datei `main.py`, um einen Body aus einer `PUT`-Anfrage zu empfangen.

Deklariere den Body mit Standard-Python-Typen dank Pydantic.

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

Der `fastapi dev`-Server sollte sich automatisch neu laden.

### Interaktive API-Dokumentation Upgrade

Gehe jetzt zu <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

* Die interaktive API-Dokumentation wird automatisch aktualisiert, inklusive des neuen Bodys:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* Klicke auf den Button "Try it out", damit kannst du die Parameter ausfüllen und direkt mit der API interagieren:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* Dann klicke auf "Execute", die Benutzeroberfläche kommuniziert mit deiner API, sendet die Parameter, erhält die Ergebnisse und zeigt sie an:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### Alternative API-Dokumentation Upgrade

Und nun gehe zu <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

* Die alternative Dokumentation zeigt ebenfalls den neuen Query-Parameter und Body:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### Zusammenfassung

Zusammengefasst deklarierst du **einmalig** die Typen von Parametern, Body usw. als Funktionsparameter.

Das machst du mit Standard-Python-Typen.

Du musst keine neue Syntax, Methoden oder Klassen einer bestimmten Bibliothek lernen.

Einfach Standard-**Python**.

Beispielsweise für ein `int`:

```Python
item_id: int
```

oder für ein komplexeres `Item`-Modell:

```Python
item: Item
```

...und mit dieser einen Deklaration erhältst du:

* Editorunterstützung, einschließlich:
    * Vervollständigung.
    * Typprüfungen.
* Datenvalidierung:
    * Automatische und klare Fehler, wenn die Daten ungültig sind.
    * Validierung sogar für tief verschachtelte JSON-Objekte.
* <abbr title="auch bekannt als: Serialisierung, Parsen, Marshalling">Konvertierung</abbr> von Eingabedaten: vom Netzwerk zu Python-Daten und -Typen, Lesen von:
    * JSON.
    * Pfadparametern.
    * Query-Parametern.
    * Cookies.
    * Headern.
    * Formularen.
    * Dateien.
* <abbr title="auch bekannt als: Serialisierung, Parsen, Marshalling">Konvertierung</abbr> von Ausgabedaten: von Python-Daten und -Typen zu Netzwerkdaten (als JSON):
    * Konvertierung von Python-Typen (`str`, `int`, `float`, `bool`, `list`, etc).
    * `datetime`-Objekte.
    * `UUID`-Objekte.
    * Datenbankmodelle.
    * ...und viele mehr.
* Automatische interaktive API-Dokumentation, inklusive 2 alternativen Benutzeroberflächen:
    * Swagger UI.
    * ReDoc.

---

Zurück zum vorherigen Codebeispiel, **FastAPI** wird:

* Validieren, dass ein `item_id` im Pfad für `GET`- und `PUT`-Anfragen vorhanden ist.
* Validieren, dass der `item_id`-Wert für `GET`- und `PUT`-Anfragen vom Typ `int` ist.
    * Falls nicht, sieht der Client einen hilfreichen, klaren Fehler.
* Prüfen, ob für `GET`-Anfragen ein optionaler Query-Parameter namens `q` vorhanden ist (wie in `http://127.0.0.1:8000/items/foo?q=somequery`).
    * Da der `q`-Parameter mit `= None` deklariert ist, ist er optional.
    * Ohne das `None` wäre er erforderlich (wie auch der Body im Fall von `PUT`).
* Für `PUT`-Anfragen an `/items/{item_id}` wird der Body als JSON gelesen:
    * Es wird geprüft, dass ein erforderliches Attribut `name` vorhanden ist, das ein `str` sein muss.
    * Es wird geprüft, dass ein erforderliches Attribut `price` vorhanden ist, das ein `float` sein muss.
    * Es wird geprüft, dass ein optionales Attribut `is_offer` vorhanden ist, das ein `bool` sein muss, falls vorhanden.
    * All dies funktioniert auch für tief verschachtelte JSON-Objekte.
* Automatische Umwandlung von und zu JSON.
* Dokumentation von allem mit OpenAPI, das verwendet werden kann von:
    * Interaktiven Dokumentationssystemen.
    * Systemen zur automatischen Client-Code-Generierung, für viele Sprachen.
* Zwei interaktive Dokumentations-Weboberflächen direkt bereitstellen.

---

Wir haben nur an der Oberfläche gekratzt, aber du hast bereits eine Vorstellung davon, wie alles funktioniert.

Probiere aus, die Zeile zu ändern:

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...von:

```Python
        ... "item_name": item.name ...
```

...zu:

```Python
        ... "item_price": item.price ...
```

...und sieh, wie dein Editor die Attribute automatisch vervollständigt und ihre Typen kennt:

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

Für ein vollständigeres Beispiel mit weiteren Funktionen siehe das <a href="https://fastapi.tiangolo.com/tutorial/">Tutorial – Benutzerhandbuch</a>.

**Spoiler-Alarm**: Das Tutorial/Benutzerhandbuch behandelt:

* Deklaration von **Parametern** aus anderen Quellen wie: **Header**, **Cookies**, **Formularfeldern** und **Dateien**.
* Wie man **Validierungsbeschränkungen** wie `maximum_length` oder `regex` festlegt.
* Ein sehr leistungsfähiges und einfach zu nutzendes **<abbr title="auch bekannt als Komponenten, Ressourcen, Provider, Services, Injectables">Dependency-Injection</abbr>**-System.
* Sicherheit und Authentifizierung, inklusive Unterstützung für **OAuth2** mit **JWT-Token** und **HTTP Basic**-Authentifizierung.
* Fortgeschrittene (aber ebenso einfache) Techniken zur Deklaration von **tief verschachtelten JSON-Modellen** (dank Pydantic).
* **GraphQL**-Integration mit <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> und anderen Bibliotheken.
* Viele zusätzliche Features (dank Starlette) wie:
    * **WebSockets**
    * extrem einfache Tests mit HTTPX und `pytest`
    * **CORS**
    * **Cookie-Sessions**
    * ...und mehr.

## Performance

Unabhängige TechEmpower-Benchmarks zeigen, dass **FastAPI**-Anwendungen unter Uvicorn <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">zu den schnellsten verfügbaren Python-Frameworks gehören</a>, nur unterhalb von Starlette und Uvicorn selbst (die intern von FastAPI verwendet werden). (*)

Mehr dazu im Abschnitt <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">Benchmarks</a>.

## Abhängigkeiten

FastAPI hängt von Pydantic und Starlette ab.

### `standard`-Abhängigkeiten

Wenn du FastAPI mit `pip install "fastapi[standard]"` installierst, sind die optionalen Abhängigkeiten der `standard`-Gruppe enthalten:

Von Pydantic verwendet:

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> – zur E-Mail-Validierung.

Von Starlette verwendet:

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> – erforderlich, wenn du den `TestClient` verwenden willst.
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> – erforderlich, wenn du die Standard-Template-Konfiguration verwenden willst.
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> – erforderlich, wenn du Formular-<abbr title="Umwandlung des Strings, der von einer HTTP-Anfrage kommt, in Python-Daten">"Parsing"</abbr> mit `request.form()` unterstützen willst.

Von FastAPI / Starlette verwendet:

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> – für den Server, der deine Anwendung lädt und bereitstellt. Dies beinhaltet `uvicorn[standard]`, das einige Abhängigkeiten (z.B. `uvloop`) für eine hohe Performance enthält.
* `fastapi-cli` – um den Befehl `fastapi` bereitzustellen.

### Ohne `standard`-Abhängigkeiten

Wenn du die optionalen `standard`-Abhängigkeiten nicht installieren möchtest, kannst du einfach `pip install fastapi` statt `pip install "fastapi[standard]"` verwenden.

### Weitere optionale Abhängigkeiten

Es gibt weitere Abhängigkeiten, die du ggf. installieren möchtest.

Weitere optionale Pydantic-Abhängigkeiten:

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> – für Einstellungen/Settings-Management.
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> – für zusätzliche Typen zur Verwendung mit Pydantic.

Weitere optionale FastAPI-Abhängigkeiten:

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> – erforderlich, wenn du `ORJSONResponse` verwenden möchtest.
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> – erforderlich, wenn du `UJSONResponse` verwenden möchtest.

## Lizenz

Dieses Projekt steht unter der MIT-Lizenz.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---