<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>Framework FastAPI, haute performance, facile à apprendre, rapide à coder, prêt pour la production</em>
</p>
<p align="center">
<a href="https://github.com/fastapi/fastapi/actions?query=workflow%3ATest+event%3Apush+branch%3Amaster" target="_blank">
    <img src="https://github.com/fastapi/fastapi/actions/workflows/test.yml/badge.svg?event=push&branch=master" alt="Test">
</a>
<a href="https://coverage-badge.samuelcolvin.workers.dev/redirect/fastapi/fastapi" target="_blank">
    <img src="https://coverage-badge.samuelcolvin.workers.dev/fastapi/fastapi.svg" alt="Couverture">
</a>
<a href="https://pypi.org/project/fastapi" target="_blank">
    <img src="https://img.shields.io/pypi/v/fastapi?color=%2334D058&label=pypi%20package" alt="Version du package">
</a>
<a href="https://pypi.org/project/fastapi" target="_blank">
    <img src="https://img.shields.io/pypi/pyversions/fastapi.svg?color=%2334D058" alt="Versions Python supportées">
</a>
</p>

---

**Documentation** : <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**Code source** : <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI est un framework web moderne, rapide (haute performance), pour construire des APIs avec Python basé sur les annotations de type standard de Python.

Les fonctionnalités clés sont :

* **Rapide** : Très haute performance, comparable à **NodeJS** et **Go** (grâce à Starlette et Pydantic). [Un des frameworks Python les plus rapides disponibles](#performance).
* **Rapide à coder** : Augmente la vitesse de développement des fonctionnalités d'environ 200% à 300%. *
* **Moins de bugs** : Réduit d'environ 40% les erreurs humaines (provoquées par les développeurs). *
* **Intuitif** : Excellente prise en charge par les éditeurs. <abbr title="aussi connu sous le nom d'auto-complétion, autocomplétion, IntelliSense">Auto-complétion</abbr> partout. Moins de temps de débogage.
* **Facile** : Conçu pour être facile à utiliser et à apprendre. Moins de temps à lire la documentation.
* **Court** : Minimise la duplication du code. Plusieurs fonctionnalités pour chaque déclaration de paramètre. Moins de bugs.
* **Robuste** : Code prêt pour la production. Avec documentation interactive automatique.
* **Basé sur les standards** : Basé (et totalement compatible) avec les standards ouverts pour les APIs : <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a> (anciennement Swagger) et <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>.

<small>* estimation basée sur des tests d'une équipe de développement interne, construisant des applications en production.</small>

## Sponsors

<!-- sponsors -->

<a href="https://blockbee.io?ref=fastapi" target="_blank" title="BlockBee Cryptocurrency Payment Gateway"><img src="https://fastapi.tiangolo.com/img/sponsors/blockbee.png"></a>
<a href="https://platform.sh/try-it-now/?utm_source=fastapi-signup&utm_medium=banner&utm_campaign=FastAPI-signup-June-2023" target="_blank" title="Construisez, exécutez et faites évoluer vos applications sur une PaaS moderne, fiable et sécurisée."><img src="https://fastapi.tiangolo.com/img/sponsors/platform-sh.png"></a>
<a href="https://www.porter.run" target="_blank" title="Déployez FastAPI sur AWS en quelques clics"><img src="https://fastapi.tiangolo.com/img/sponsors/porter.png"></a>
<a href="https://github.com/scalar/scalar/?utm_source=fastapi&utm_medium=website&utm_campaign=main-badge" target="_blank" title="Scalar : Belles références API open-source à partir de fichiers Swagger/OpenAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/scalar.svg"></a>
<a href="https://www.propelauth.com/?utm_source=fastapi&utm_campaign=1223&utm_medium=mainbadge" target="_blank" title="Auth, gestion des utilisateurs et plus pour votre produit B2B"><img src="https://fastapi.tiangolo.com/img/sponsors/propelauth.png"></a>
<a href="https://zuplo.link/fastapi-gh" target="_blank" title="Zuplo : Déployez, sécurisez, documentez, et monétisez votre FastAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/zuplo.png"></a>
<a href="https://liblab.com?utm_source=fastapi" target="_blank" title="liblab - Générez des SDKs à partir de FastAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/liblab.png"></a>
<a href="https://docs.render.com/deploy-fastapi?utm_source=deploydoc&utm_medium=referral&utm_campaign=fastapi" target="_blank" title="Déployez et faites évoluer toute application web full-stack sur Render. Concentrez-vous sur les apps, pas l’infra."><img src="https://fastapi.tiangolo.com/img/sponsors/render.svg"></a>
<a href="https://www.coderabbit.ai/?utm_source=fastapi&utm_medium=badge&utm_campaign=fastapi" target="_blank" title="Réduisez de moitié le temps de revue de code et les bugs avec CodeRabbit"><img src="https://fastapi.tiangolo.com/img/sponsors/coderabbit.png"></a>
<a href="https://subtotal.com/?utm_source=fastapi&utm_medium=sponsorship&utm_campaign=open-source" target="_blank" title="La référence en matière de liaison de comptes de détail"><img src="https://fastapi.tiangolo.com/img/sponsors/subtotal.svg"></a>
<a href="https://databento.com/" target="_blank" title="Payez à l'utilisation pour les données de marché"><img src="https://fastapi.tiangolo.com/img/sponsors/databento.svg"></a>
<a href="https://speakeasy.com?utm_source=fastapi+repo&utm_medium=github+sponsorship" target="_blank" title="SDKs pour votre API | Speakeasy"><img src="https://fastapi.tiangolo.com/img/sponsors/speakeasy.png"></a>
<a href="https://www.svix.com/" target="_blank" title="Svix - Webhooks en tant que service"><img src="https://fastapi.tiangolo.com/img/sponsors/svix.svg"></a>
<a href="https://www.stainlessapi.com/?utm_source=fastapi&utm_medium=referral" target="_blank" title="Stainless | Générez des SDKs de classe mondiale"><img src="https://fastapi.tiangolo.com/img/sponsors/stainless.png"></a>
<a href="https://www.permit.io/blog/implement-authorization-in-fastapi?utm_source=github&utm_medium=referral&utm_campaign=fastapi" target="_blank" title="Autorisation fine pour FastAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/permit.png"></a>
<a href="https://www.interviewpal.com/?utm_source=fastapi&utm_medium=open-source&utm_campaign=dev-hiring" target="_blank" title="InterviewPal - Coach IA pour les entretiens d'ingénieurs et développeurs"><img src="https://fastapi.tiangolo.com/img/sponsors/interviewpal.png"></a>
<a href="https://dribia.com/en/" target="_blank" title="Dribia - La data science à votre portée"><img src="https://fastapi.tiangolo.com/img/sponsors/dribia.png"></a>

<!-- /sponsors -->

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">Autres sponsors</a>

## Avis

"_[...] J'utilise **FastAPI** énormément ces derniers temps. [...] Je prévois d'ailleurs de l'utiliser pour tous les services **ML de mon équipe chez Microsoft**. Certains sont intégrés au produit principal **Windows** et certains aux produits **Office**._"

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(ref)</small></a></div>

---

"_Nous avons adopté la bibliothèque **FastAPI** pour lancer un serveur **REST** qui peut être interrogé pour obtenir des **prédictions**. [pour Ludwig]_"

<div style="text-align: right; margin-right: 10%;">Piero Molino, Yaroslav Dudin, et Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(ref)</small></a></div>

---

"_**Netflix** est heureux d'annoncer la publication en open source de notre framework d'orchestration de **gestion de crise** : **Dispatch** ! [construit avec **FastAPI**]_"

<div style="text-align: right; margin-right: 10%;">Kevin Glisson, Marc Vilanova, Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(ref)</small></a></div>

---

"_Je suis absolument ravi par **FastAPI**. C'est tellement amusant !_"

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">Animateur du podcast Python Bytes</a></strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(ref)</small></a></div>

---

"_Honnêtement, ce que tu as construit est vraiment solide et soigné. À bien des égards, c'est ce que je voulais que **Hug** soit - c'est vraiment inspirant de voir quelqu'un le réaliser._"

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">Créateur de Hug</a></strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(ref)</small></a></div>

---

"_Si vous cherchez à apprendre un **framework moderne** pour créer des APIs REST, essayez **FastAPI** [...] C'est rapide, facile à utiliser et facile à apprendre [...]_"

"_Nous sommes passés à **FastAPI** pour nos **APIs** [...] Je pense que vous allez l'apprécier [...]_"

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">Fondateurs d'Explosion AI</a> - <a href="https://spacy.io" target="_blank">Créateurs de spaCy</a></strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(ref)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(ref)</small></a></div>

---

"_Si quelqu'un cherche à construire une API Python en production, je recommande vivement **FastAPI**. Il est **magnifiquement conçu**, **simple à utiliser** et **hautement évolutif**, il est devenu un **élément clé** de notre stratégie de développement API First et alimente de nombreuses automatisations et services comme notre Virtual TAC Engineer._"

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(ref)</small></a></div>

---

## **Typer**, le FastAPI des CLIs

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

Si vous construisez une application <abbr title="Interface en ligne de commande">CLI</abbr> à utiliser dans le terminal au lieu d'une API web, jetez un œil à <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a>.

**Typer** est le petit frère de FastAPI. Et il est conçu pour être le **FastAPI des CLIs**. ⌨️ 🚀

## Prérequis

FastAPI repose sur les épaules de géants :

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> pour la partie web.
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> pour la gestion des données.

## Installation

Créez et activez un <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">environnement virtuel</a> puis installez FastAPI :

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**Remarque** : Assurez-vous de mettre `"fastapi[standard]"` entre guillemets pour que cela fonctionne dans tous les terminaux.

## Exemple

### Créez-le

Créez un fichier `main.py` contenant :

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
<summary>Ou utilisez <code>async def</code>...</summary>

Si votre code utilise `async` / `await`, utilisez `async def` :

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

**Remarque** :

Si vous ne savez pas, consultez la section _"Pressé(e)?"_ à propos de <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` et `await` dans la documentation</a>.

</details>

### Exécutez-le

Lancez le serveur avec :

<div class="termy">

```console
$ fastapi dev main.py

 ╭────────── FastAPI CLI - Mode développement ─────────╮
 │                                                     │
 │  Sert à : http://127.0.0.1:8000                     │
 │                                                     │
 │  Docs API : http://127.0.0.1:8000/docs              │
 │                                                     │
 │  Fonctionne en mode développement, pour la prod :   │
 │                                                     │
 │  fastapi run                                        │
 │                                                     │
 ╰─────────────────────────────────────────────────────╯

INFO:     Surveille les changements dans ces dossiers : ['/home/user/code/awesomeapp']
INFO:     Uvicorn fonctionne sur http://127.0.0.1:8000 (Appuyez sur CTRL+C pour arrêter)
INFO:     Processus de rechargement démarré [2248755] avec WatchFiles
INFO:     Processus serveur démarré [2248757]
INFO:     En attente du démarrage de l'application.
INFO:     Démarrage de l'application terminé.
```

</div>

<details markdown="1">
<summary>À propos de la commande <code>fastapi dev main.py</code>...</summary>

La commande `fastapi dev` lit votre fichier `main.py`, détecte l'application **FastAPI** à l'intérieur, et démarre un serveur avec <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a>.

Par défaut, `fastapi dev` démarre avec le rechargement automatique activé pour le développement local.

Vous pouvez en savoir plus dans la <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">documentation FastAPI CLI</a>.

</details>

### Vérifiez-le

Ouvrez votre navigateur à <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>.

Vous verrez la réponse JSON suivante :

```JSON
{"item_id": 5, "q": "somequery"}
```

Vous avez déjà créé une API qui :

* Reçoit des requêtes HTTP sur les _chemins_ `/` et `/items/{item_id}`.
* Les deux _chemins_ acceptent des <em>opérations</em> `GET` (également appelées _méthodes_ HTTP).
* Le _chemin_ `/items/{item_id}` a un _paramètre de chemin_ `item_id` qui doit être un `int`.
* Le _chemin_ `/items/{item_id}` a un _paramètre de requête_ optionnel `q` de type `str`.

### Documentation API interactive

Allez maintenant sur <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

Vous verrez la documentation interactive automatique de l'API (fournie par <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a>) :

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### Documentation API alternative

Et maintenant, allez sur <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

Vous verrez la documentation automatique alternative (fournie par <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a>) :

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## Exemple évolué

Modifiez maintenant le fichier `main.py` pour recevoir un corps depuis une requête `PUT`.

Déclarez le corps à l'aide des types Python standards, grâce à Pydantic.

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

Le serveur `fastapi dev` devrait se recharger automatiquement.

### Mise à jour de la documentation API interactive

Allez maintenant sur <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

* La documentation interactive de l'API sera automatiquement mise à jour, incluant le nouveau corps :

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* Cliquez sur le bouton "Try it out", il vous permet de remplir les paramètres et d'interagir directement avec l'API :

![Interaction Swagger UI](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* Puis cliquez sur le bouton "Execute", l'interface communiquera avec votre API, enverra les paramètres, recevra les résultats et les affichera à l'écran :

![Interaction Swagger UI](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### Mise à jour de la documentation API alternative

Et maintenant, allez sur <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

* La documentation alternative reflètera aussi le nouveau paramètre de requête et le corps :

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### Récapitulatif

En résumé, vous déclarez **une seule fois** les types de paramètres, corps, etc. comme paramètres de fonction.

Vous faites cela avec les types Python modernes et standards.

Vous n'avez pas à apprendre une nouvelle syntaxe, des méthodes ou classes d'une bibliothèque spécifique, etc.

Juste du **Python** standard.

Par exemple, pour un `int` :

```Python
item_id: int
```

ou pour un modèle `Item` plus complexe :

```Python
item: Item
```

...et avec cette simple déclaration vous obtenez :

* Prise en charge par l'éditeur, dont :
    * Auto-complétion.
    * Vérifications de type.
* Validation des données :
    * Erreurs automatiques et claires quand les données sont invalides.
    * Validation même pour les objets JSON imbriqués.
* <abbr title="aussi connu sous le nom : sérialisation, parsing, marshalling">Conversion</abbr> des données d'entrée : du réseau vers les données et types Python. Lecture depuis :
    * JSON.
    * Paramètres de chemin.
    * Paramètres de requête.
    * Cookies.
    * En-têtes.
    * Formulaires.
    * Fichiers.
* <abbr title="aussi connu sous le nom : sérialisation, parsing, marshalling">Conversion</abbr> des données de sortie : conversion des données et types Python vers des données réseau (en JSON) :
    * Conversion des types Python (`str`, `int`, `float`, `bool`, `list`, etc).
    * Objets `datetime`.
    * Objets `UUID`.
    * Modèles de base de données.
    * ...et bien d'autres.
* Documentation API interactive automatique, avec 2 interfaces utilisateur alternatives :
    * Swagger UI.
    * ReDoc.

---

En revenant à l'exemple précédent, **FastAPI** va :

* Valider qu'il y a un `item_id` dans le chemin pour les requêtes `GET` et `PUT`.
* Valider que le `item_id` est de type `int` pour les requêtes `GET` et `PUT`.
    * Sinon, le client verra une erreur utile et claire.
* Vérifier s'il y a un paramètre de requête optionnel nommé `q` (comme dans `http://127.0.0.1:8000/items/foo?q=somequery`) pour les requêtes `GET`.
    * Comme le paramètre `q` est déclaré avec `= None`, il est optionnel.
    * Sans le `None` il serait requis (comme le corps dans le cas de `PUT`).
* Pour les requêtes `PUT` sur `/items/{item_id}`, lire le corps en JSON :
    * Vérifier qu'il a un attribut requis `name` qui doit être un `str`.
    * Vérifier qu'il a un attribut requis `price` qui doit être un `float`.
    * Vérifier qu'il a un attribut optionnel `is_offer`, qui doit être un `bool` s'il est présent.
    * Tout cela fonctionne aussi pour les objets JSON imbriqués.
* Convertir depuis et vers JSON automatiquement.
* Documenter tout avec OpenAPI, utilisable par :
    * Systèmes de documentation interactive.
    * Systèmes de génération automatique de code client, pour de nombreux langages.
* Fournir 2 interfaces web de documentation interactive directement.

---

Nous n'avons fait qu'effleurer la surface, mais vous comprenez déjà comment tout cela fonctionne.

Essayez de modifier la ligne :

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...de :

```Python
        ... "item_name": item.name ...
```

...à :

```Python
        ... "item_price": item.price ...
```

...et voyez comment votre éditeur va auto-compléter les attributs et connaître leurs types :

![prise en charge éditeur](https://fastapi.tiangolo.com/img/vscode-completion.png)

Pour un exemple plus complet incluant plus de fonctionnalités, consultez le <a href="https://fastapi.tiangolo.com/tutorial/">Tutoriel - Guide utilisateur</a>.

**Spoiler** : le tutoriel - guide utilisateur inclut :

* Déclaration de **paramètres** à partir d'autres endroits comme : **en-têtes**, **cookies**, **champs de formulaire** et **fichiers**.
* Comment définir des **contraintes de validation** telles que `maximum_length` ou `regex`.
* Un système de **<abbr title="aussi connu sous le nom de composants, ressources, providers, services, injectables">d'injection de dépendances</abbr>** très puissant et facile à utiliser.
* Sécurité et authentification, y compris la prise en charge de **OAuth2** avec **jetons JWT** et **HTTP Basic**.
* Techniques plus avancées (mais tout aussi simples) pour déclarer des **modèles JSON imbriqués** (grâce à Pydantic).
* Intégration **GraphQL** avec <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> et d'autres bibliothèques.
* De nombreuses fonctionnalités supplémentaires (grâce à Starlette) telles que :
    * **WebSockets**
    * tests extrêmement faciles basés sur HTTPX et `pytest`
    * **CORS**
    * **Cookie Sessions**
    * ...et plus encore.

## Performance

Des benchmarks indépendants TechEmpower montrent que les applications **FastAPI** fonctionnant sous Uvicorn sont <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">parmi les frameworks Python les plus rapides disponibles</a>, juste derrière Starlette et Uvicorn eux-mêmes (utilisés en interne par FastAPI). (*)

Pour en savoir plus, consultez la section <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">Benchmarks</a>.

## Dépendances

FastAPI dépend de Pydantic et Starlette.

### Dépendances `standard`

Quand vous installez FastAPI avec `pip install "fastapi[standard]"` il est livré avec le groupe de dépendances optionnelles `standard` :

Utilisé par Pydantic :

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - pour la validation des emails.

Utilisé par Starlette :

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - Requis si vous souhaitez utiliser le `TestClient`.
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - Requis si vous souhaitez utiliser la configuration de template par défaut.
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - Requis si vous souhaitez prendre en charge le <abbr title="convertir la chaîne provenant d'une requête HTTP en données Python">"parsing"</abbr> de formulaires, avec `request.form()`.

Utilisé par FastAPI / Starlette :

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - pour le serveur qui charge et sert votre application. Cela inclut `uvicorn[standard]`, qui inclut certaines dépendances (par ex. `uvloop`) nécessaires pour des performances élevées.
* `fastapi-cli` - pour fournir la commande `fastapi`.

### Sans dépendances `standard`

Si vous ne souhaitez pas inclure les dépendances optionnelles `standard`, vous pouvez installer avec `pip install fastapi` au lieu de `pip install "fastapi[standard]"`.

### Dépendances optionnelles supplémentaires

Il existe des dépendances supplémentaires que vous pouvez vouloir installer.

Dépendances optionnelles supplémentaires pour Pydantic :

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - pour la gestion des paramètres.
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - pour des types supplémentaires à utiliser avec Pydantic.

Dépendances optionnelles supplémentaires pour FastAPI :

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - Requis si vous souhaitez utiliser `ORJSONResponse`.
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - Requis si vous souhaitez utiliser `UJSONResponse`.

## Licence

Ce projet est sous licence MIT.


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---