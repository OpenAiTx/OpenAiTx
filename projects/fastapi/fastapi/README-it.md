<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>Framework FastAPI, alte prestazioni, facile da imparare, veloce da programmare, pronto per la produzione</em>
</p>
<p align="center">
<a href="https://github.com/fastapi/fastapi/actions?query=workflow%3ATest+event%3Apush+branch%3Amaster" target="_blank">
    <img src="https://github.com/fastapi/fastapi/actions/workflows/test.yml/badge.svg?event=push&branch=master" alt="Test">
</a>
<a href="https://coverage-badge.samuelcolvin.workers.dev/redirect/fastapi/fastapi" target="_blank">
    <img src="https://coverage-badge.samuelcolvin.workers.dev/fastapi/fastapi.svg" alt="Copertura">
</a>
<a href="https://pypi.org/project/fastapi" target="_blank">
    <img src="https://img.shields.io/pypi/v/fastapi?color=%2334D058&label=pypi%20package" alt="Versione pacchetto">
</a>
<a href="https://pypi.org/project/fastapi" target="_blank">
    <img src="https://img.shields.io/pypi/pyversions/fastapi.svg?color=%2334D058" alt="Versioni Python supportate">
</a>
</p>

---

**Documentazione**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**Codice Sorgente**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI è un framework web moderno e veloce (ad alte prestazioni) per creare API con Python, basato sui tipici type hints standard di Python.

Le caratteristiche principali sono:

* **Veloce**: Prestazioni molto elevate, al pari di **NodeJS** e **Go** (grazie a Starlette e Pydantic). [Uno dei framework Python più veloci disponibili](#performance).
* **Veloce da programmare**: Incrementa la velocità di sviluppo delle funzionalità di circa il 200% - 300%. *
* **Meno bug**: Riduce circa il 40% degli errori umani (degli sviluppatori). *
* **Intuitivo**: Ottimo supporto dell'editor. <abbr title="anche noto come auto-completamento, autocompletion, IntelliSense">Completamento</abbr> ovunque. Meno tempo per il debug.
* **Facile**: Progettato per essere facile da usare e da imparare. Meno tempo a leggere la documentazione.
* **Sintetico**: Minimizza la duplicazione del codice. Più funzionalità da ogni dichiarazione di parametro. Meno bug.
* **Robusto**: Ottieni codice pronto per la produzione. Con documentazione interattiva automatica.
* **Basato su standard**: Basato (e completamente compatibile) sugli standard aperti per le API: <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a> (precedentemente noto come Swagger) e <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>.

<small>* stima basata su test su un team di sviluppo interno, che costruisce applicazioni in produzione.</small>

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

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">Altri sponsor</a>

## Opinioni

"_[...] Sto usando **FastAPI** tantissimo ultimamente. [...] In realtà sto pianificando di usarlo per tutti i servizi **ML del mio team in Microsoft**. Alcuni di essi stanno venendo integrati nel prodotto core **Windows** e in alcuni prodotti **Office**._"

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(ref)</small></a></div>

---

"_Abbiamo adottato la libreria **FastAPI** per generare un server **REST** che può essere interrogato per ottenere **predizioni**. [per Ludwig]_"

<div style="text-align: right; margin-right: 10%;">Piero Molino, Yaroslav Dudin, e Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(ref)</small></a></div>

---

"_**Netflix** è lieta di annunciare il rilascio open-source del nostro framework di orchestrazione per la **gestione delle crisi**: **Dispatch**! [costruito con **FastAPI**]_"

<div style="text-align: right; margin-right: 10%;">Kevin Glisson, Marc Vilanova, Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(ref)</small></a></div>

---

"_Sono entusiasta all’inverosimile per **FastAPI**. È così divertente!_"

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">conduttore del podcast Python Bytes</a></strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(ref)</small></a></div>

---

"_Onestamente, ciò che hai costruito sembra davvero solido e raffinato. In molti modi, è ciò che volevo che **Hug** fosse – è davvero ispirante vedere qualcuno costruirlo._"

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">Creatore di Hug</a></strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(ref)</small></a></div>

---

"_Se stai cercando di imparare un **framework moderno** per costruire REST API, dai un’occhiata a **FastAPI** [...] È veloce, facile da usare e facile da imparare [...]_"

"_Siamo passati a **FastAPI** per le nostre **API** [...] Penso che ti piacerà [...]_"

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">fondatori di Explosion AI</a> - <a href="https://spacy.io" target="_blank">creatori di spaCy</a></strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(ref)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(ref)</small></a></div>

---

"_Se qualcuno sta cercando di costruire una API Python per la produzione, raccomanderei vivamente **FastAPI**. È **ben progettato**, **semplice da usare** e **altamente scalabile**, è diventato un **componente chiave** nella nostra strategia di sviluppo API first e alimenta molte automazioni e servizi come il nostro Virtual TAC Engineer._"

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(ref)</small></a></div>

---

## **Typer**, il FastAPI delle CLI

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

Se stai costruendo un'app <abbr title="Interfaccia a Riga di Comando">CLI</abbr> da usare nel terminale invece che una web API, dai un'occhiata a <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a>.

**Typer** è il fratellino di FastAPI. Ed è pensato per essere il **FastAPI delle CLI**. ⌨️ 🚀

## Requisiti

FastAPI si basa sulle spalle dei giganti:

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> per la parte web.
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> per la parte dati.

## Installazione

Crea e attiva un <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">ambiente virtuale</a> e poi installa FastAPI:

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**Nota**: Assicurati di racchiudere `"fastapi[standard]"` tra virgolette per garantire che funzioni in tutti i terminali.

## Esempio

### Creazione

Crea un file `main.py` con:

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
<summary>Oppure usa <code>async def</code>...</summary>

Se il tuo codice usa `async` / `await`, utilizza `async def`:

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

**Nota**:

Se non lo sai, controlla la sezione _"Di fretta?"_ riguardo a <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` e `await` nella documentazione</a>.

</details>

### Avvio

Avvia il server con:

<div class="termy">

```console
$ fastapi dev main.py

 ╭────────── FastAPI CLI - Modalità sviluppo ───────────╮
 │                                                     │
 │  In ascolto su: http://127.0.0.1:8000               │
 │                                                     │
 │  API docs: http://127.0.0.1:8000/docs               │
 │                                                     │
 │  In esecuzione in modalità sviluppo, per produzione:│
 │                                                     │
 │  fastapi run                                        │
 │                                                     │
 ╰─────────────────────────────────────────────────────╯

INFO:     In attesa di modifiche in queste cartelle: ['/home/user/code/awesomeapp']
INFO:     Uvicorn in esecuzione su http://127.0.0.1:8000 (Premi CTRL+C per interrompere)
INFO:     Avviato processo di ricarica [2248755] utilizzando WatchFiles
INFO:     Avviato processo server [2248757]
INFO:     In attesa di avvio dell'applicazione.
INFO:     Avvio dell'applicazione completato.
```

</div>

<details markdown="1">
<summary>Informazioni sul comando <code>fastapi dev main.py</code>...</summary>

Il comando `fastapi dev` legge il tuo file `main.py`, rileva l'app **FastAPI** in esso e avvia un server utilizzando <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a>.

Per impostazione predefinita, `fastapi dev` parte con auto-reload abilitato per lo sviluppo locale.

Puoi leggere di più nella <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">documentazione della CLI di FastAPI</a>.

</details>

### Verifica

Apri il tuo browser su <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>.

Vedrai la risposta JSON:

```JSON
{"item_id": 5, "q": "somequery"}
```

Hai già creato una API che:

* Riceve richieste HTTP nei _percorsi_ `/` e `/items/{item_id}`.
* Entrambi i _percorsi_ accettano operazioni `GET` (<em>metodi</em> HTTP).
* Il _percorso_ `/items/{item_id}` ha un _parametro di percorso_ `item_id` che deve essere un `int`.
* Il _percorso_ `/items/{item_id}` ha un _parametro di query_ `q` opzionale di tipo `str`.

### Documentazione interattiva API

Ora vai su <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

Vedrai la documentazione interattiva automatica dell'API (fornita da <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a>):

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### Documentazione API alternativa

E ora, vai su <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

Vedrai la documentazione automatica alternativa (fornita da <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a>):

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## Esempio avanzato

Ora modifica il file `main.py` per ricevere un body da una richiesta `PUT`.

Dichiara il body usando i tipici tipi Python, grazie a Pydantic.

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

Il server `fastapi dev` dovrebbe ricaricare automaticamente.

### Aggiornamento della documentazione API interattiva

Ora vai su <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

* La documentazione interattiva sarà aggiornata automaticamente, incluso il nuovo body:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* Clicca sul pulsante "Try it out", ti permette di compilare i parametri e interagire direttamente con l'API:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* Poi clicca su "Execute", l'interfaccia utente comunicherà con la tua API, invierà i parametri, otterrà i risultati e li mostrerà sullo schermo:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### Aggiornamento della documentazione API alternativa

E ora, vai su <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

* Anche la documentazione alternativa rifletterà il nuovo parametro di query e il body:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### Riepilogo

In sintesi, dichiari **una sola volta** i tipi di parametri, body, ecc. come parametri di funzione.

Lo fai con tipi Python moderni standard.

Non devi imparare una nuova sintassi, metodi o classi di una libreria specifica, ecc.

Solo il Python standard.

Ad esempio, per un `int`:

```Python
item_id: int
```

oppure per un modello `Item` più complesso:

```Python
item: Item
```

...e con questa sola dichiarazione ottieni:

* Supporto dell'editor, inclusi:
    * Completamento.
    * Controlli di tipo.
* Validazione dei dati:
    * Errori automatici e chiari quando i dati non sono validi.
    * Validazione anche per oggetti JSON profondamente annidati.
* <abbr title="anche nota come: serializzazione, parsing, marshalling">Conversione</abbr> dei dati di input: dalla rete ai dati e tipi Python. Legge da:
    * JSON.
    * Parametri di percorso.
    * Parametri di query.
    * Cookie.
    * Header.
    * Form.
    * File.
* <abbr title="anche nota come: serializzazione, parsing, marshalling">Conversione</abbr> dei dati di output: da dati e tipi Python a dati di rete (come JSON):
    * Conversione dei tipi Python (`str`, `int`, `float`, `bool`, `list`, ecc).
    * Oggetti `datetime`.
    * Oggetti `UUID`.
    * Modelli di database.
    * ...e molti altri.
* Documentazione API interattiva automatica, incluse 2 interfacce utente alternative:
    * Swagger UI.
    * ReDoc.

---

Ritornando all'esempio di codice precedente, **FastAPI**:

* Validerà che esista un `item_id` nel percorso per le richieste `GET` e `PUT`.
* Validerà che `item_id` sia di tipo `int` per le richieste `GET` e `PUT`.
    * Se non lo è, il client vedrà un errore chiaro e utile.
* Controllerà se esiste un parametro di query opzionale chiamato `q` (come in `http://127.0.0.1:8000/items/foo?q=somequery`) per richieste `GET`.
    * Poiché il parametro `q` è dichiarato con `= None`, è opzionale.
    * Senza il `None` sarebbe richiesto (come lo è il body nel caso di `PUT`).
* Per le richieste `PUT` su `/items/{item_id}`, leggerà il body come JSON:
    * Controlla che abbia un attributo richiesto `name` che deve essere una `str`.
    * Controlla che abbia un attributo richiesto `price` che deve essere un `float`.
    * Controlla che abbia un attributo opzionale `is_offer`, che deve essere un `bool`, se presente.
    * Tutto questo funziona anche per oggetti JSON profondamente annidati.
* Conversione da e verso JSON automaticamente.
* Documenta tutto con OpenAPI, che può essere usato da:
    * Sistemi di documentazione interattiva.
    * Sistemi di generazione automatica di codice client, per molti linguaggi.
* Fornisce direttamente 2 interfacce web di documentazione interattiva.

---

Abbiamo solo scalfito la superficie, ma hai già l’idea generale di come funziona tutto.

Prova a cambiare la riga con:

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...da:

```Python
        ... "item_name": item.name ...
```

...a:

```Python
        ... "item_price": item.price ...
```

...e vedrai come il tuo editor completerà automaticamente gli attributi e ne conoscerà i tipi:

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

Per un esempio più completo che includa più funzionalità, vedi il <a href="https://fastapi.tiangolo.com/tutorial/">Tutorial - Guida Utente</a>.

**Spoiler**: il tutorial - guida utente include:

* Dichiarazione di **parametri** da altre fonti come: **header**, **cookie**, **campi form** e **file**.
* Come impostare **vincoli di validazione** come `maximum_length` o `regex`.
* Un sistema di **<abbr title="anche noto come components, resources, providers, services, injectables">Dependency Injection</abbr>** molto potente e facile da usare.
* Sicurezza e autenticazione, incluso supporto per **OAuth2** con **token JWT** e autenticazione **HTTP Basic**.
* Tecniche più avanzate (ma ugualmente semplici) per dichiarare **modelli JSON profondamente annidati** (grazie a Pydantic).
* Integrazione **GraphQL** con <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> e altre librerie.
* Molte funzionalità extra (grazie a Starlette) come:
    * **WebSocket**
    * test estremamente semplici basati su HTTPX e `pytest`
    * **CORS**
    * **Cookie Session**
    * ...e altro.

## Prestazioni

I benchmark indipendenti di TechEmpower mostrano applicazioni **FastAPI** in esecuzione sotto Uvicorn come <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">uno dei framework Python più veloci disponibili</a>, subito sotto Starlette e Uvicorn stessi (utilizzati internamente da FastAPI). (*)

Per approfondire, vedi la sezione <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">Benchmarks</a>.

## Dipendenze

FastAPI dipende da Pydantic e Starlette.

### Dipendenze `standard`

Quando installi FastAPI con `pip install "fastapi[standard]"` include il gruppo `standard` delle dipendenze opzionali:

Usate da Pydantic:

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - per la validazione delle email.

Usate da Starlette:

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - Richiesto se vuoi usare il `TestClient`.
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - Richiesto se vuoi usare la configurazione predefinita dei template.
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - Richiesto se vuoi supportare il <abbr title="conversione della stringa proveniente da una richiesta HTTP in dati Python">"parsing"</abbr> dei form, con `request.form()`.

Usate da FastAPI / Starlette:

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - per il server che carica e serve la tua applicazione. Questo include `uvicorn[standard]`, che comprende alcune dipendenze (ad es. `uvloop`) necessarie per prestazioni elevate.
* `fastapi-cli` - per fornire il comando `fastapi`.

### Senza dipendenze `standard`

Se non vuoi includere le dipendenze opzionali `standard`, puoi installare con `pip install fastapi` invece di `pip install "fastapi[standard]"`.

### Dipendenze opzionali aggiuntive

Ci sono alcune dipendenze aggiuntive che potresti voler installare.

Dipendenze opzionali aggiuntive per Pydantic:

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - per la gestione delle impostazioni.
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - per tipi aggiuntivi da usare con Pydantic.

Dipendenze opzionali aggiuntive per FastAPI:

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - Necessaria se vuoi usare `ORJSONResponse`.
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - Necessaria se vuoi usare `UJSONResponse`.

## Licenza

Questo progetto è rilasciato secondo i termini della licenza MIT.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---