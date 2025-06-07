<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>Framework FastAPI, alto rendimiento, fácil de aprender, rápido para programar, listo para producción</em>
</p>
<p align="center">
<a href="https://github.com/fastapi/fastapi/actions?query=workflow%3ATest+event%3Apush+branch%3Amaster" target="_blank">
    <img src="https://github.com/fastapi/fastapi/actions/workflows/test.yml/badge.svg?event=push&branch=master" alt="Test">
</a>
<a href="https://coverage-badge.samuelcolvin.workers.dev/redirect/fastapi/fastapi" target="_blank">
    <img src="https://coverage-badge.samuelcolvin.workers.dev/fastapi/fastapi.svg" alt="Cobertura">
</a>
<a href="https://pypi.org/project/fastapi" target="_blank">
    <img src="https://img.shields.io/pypi/v/fastapi?color=%2334D058&label=pypi%20package" alt="Versión del paquete">
</a>
<a href="https://pypi.org/project/fastapi" target="_blank">
    <img src="https://img.shields.io/pypi/pyversions/fastapi.svg?color=%2334D058" alt="Versiones de Python soportadas">
</a>
</p>

---

**Documentación**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**Código Fuente**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI es un framework web moderno, rápido (de alto rendimiento), para construir APIs con Python basado en las anotaciones de tipos estándar de Python.

Las características clave son:

* **Rápido**: Rendimiento muy alto, a la par de **NodeJS** y **Go** (gracias a Starlette y Pydantic). [Uno de los frameworks de Python más rápidos disponibles](#performance).
* **Rápido para programar**: Aumenta la velocidad para desarrollar funcionalidades en aproximadamente un 200% a 300%. *
* **Menos errores**: Reduce alrededor del 40% de los errores humanos (del desarrollador). *
* **Intuitivo**: Excelente soporte en el editor. <abbr title="también conocido como autocompletar, autocompletado, IntelliSense">Autocompletado</abbr> en todas partes. Menos tiempo depurando.
* **Fácil**: Diseñado para ser fácil de usar y aprender. Menos tiempo leyendo documentación.
* **Conciso**: Minimiza la duplicación de código. Múltiples características por cada declaración de parámetro. Menos errores.
* **Robusto**: Obtén código listo para producción. Con documentación interactiva automática.
* **Basado en estándares**: Basado en (y totalmente compatible con) los estándares abiertos para APIs: <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a> (anteriormente conocido como Swagger) y <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>.

<small>* estimación basada en pruebas con un equipo interno de desarrollo, construyendo aplicaciones en producción.</small>

## Patrocinadores

<!-- sponsors -->

<a href="https://blockbee.io?ref=fastapi" target="_blank" title="BlockBee Cryptocurrency Payment Gateway"><img src="https://fastapi.tiangolo.com/img/sponsors/blockbee.png"></a>
<a href="https://platform.sh/try-it-now/?utm_source=fastapi-signup&utm_medium=banner&utm_campaign=FastAPI-signup-June-2023" target="_blank" title="Construye, ejecuta y escala tus aplicaciones en una PaaS moderna, confiable y segura."><img src="https://fastapi.tiangolo.com/img/sponsors/platform-sh.png"></a>
<a href="https://www.porter.run" target="_blank" title="Implementa FastAPI en AWS con unos pocos clics"><img src="https://fastapi.tiangolo.com/img/sponsors/porter.png"></a>
<a href="https://github.com/scalar/scalar/?utm_source=fastapi&utm_medium=website&utm_campaign=main-badge" target="_blank" title="Scalar: Referencias API hermosas y Open Source desde archivos Swagger/OpenAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/scalar.svg"></a>
<a href="https://www.propelauth.com/?utm_source=fastapi&utm_campaign=1223&utm_medium=mainbadge" target="_blank" title="Autenticación, gestión de usuarios y más para tu producto B2B"><img src="https://fastapi.tiangolo.com/img/sponsors/propelauth.png"></a>
<a href="https://zuplo.link/fastapi-gh" target="_blank" title="Zuplo: Implementa, asegura, documenta y monetiza tu FastAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/zuplo.png"></a>
<a href="https://liblab.com?utm_source=fastapi" target="_blank" title="liblab - Genera SDKs desde FastAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/liblab.png"></a>
<a href="https://docs.render.com/deploy-fastapi?utm_source=deploydoc&utm_medium=referral&utm_campaign=fastapi" target="_blank" title="Implementa y escala cualquier app web full-stack en Render. Enfócate en crear apps, no infraestructura."><img src="https://fastapi.tiangolo.com/img/sponsors/render.svg"></a>
<a href="https://www.coderabbit.ai/?utm_source=fastapi&utm_medium=badge&utm_campaign=fastapi" target="_blank" title="Reduce a la mitad el tiempo de revisión de código y errores con CodeRabbit"><img src="https://fastapi.tiangolo.com/img/sponsors/coderabbit.png"></a>
<a href="https://subtotal.com/?utm_source=fastapi&utm_medium=sponsorship&utm_campaign=open-source" target="_blank" title="El estándar oro en vinculación de cuentas de retail"><img src="https://fastapi.tiangolo.com/img/sponsors/subtotal.svg"></a>
<a href="https://databento.com/" target="_blank" title="Paga según lo que usas para datos de mercado"><img src="https://fastapi.tiangolo.com/img/sponsors/databento.svg"></a>
<a href="https://speakeasy.com?utm_source=fastapi+repo&utm_medium=github+sponsorship" target="_blank" title="SDKs para tu API | Speakeasy"><img src="https://fastapi.tiangolo.com/img/sponsors/speakeasy.png"></a>
<a href="https://www.svix.com/" target="_blank" title="Svix - Webhooks como servicio"><img src="https://fastapi.tiangolo.com/img/sponsors/svix.svg"></a>
<a href="https://www.stainlessapi.com/?utm_source=fastapi&utm_medium=referral" target="_blank" title="Stainless | Genera SDKs de clase mundial"><img src="https://fastapi.tiangolo.com/img/sponsors/stainless.png"></a>
<a href="https://www.permit.io/blog/implement-authorization-in-fastapi?utm_source=github&utm_medium=referral&utm_campaign=fastapi" target="_blank" title="Autorización granular para FastAPI"><img src="https://fastapi.tiangolo.com/img/sponsors/permit.png"></a>
<a href="https://www.interviewpal.com/?utm_source=fastapi&utm_medium=open-source&utm_campaign=dev-hiring" target="_blank" title="InterviewPal - Entrenador de entrevistas con IA para ingenieros y desarrolladores"><img src="https://fastapi.tiangolo.com/img/sponsors/interviewpal.png"></a>
<a href="https://dribia.com/en/" target="_blank" title="Dribia - Ciencia de datos a tu alcance"><img src="https://fastapi.tiangolo.com/img/sponsors/dribia.png"></a>

<!-- /sponsors -->

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">Otros patrocinadores</a>

## Opiniones

"_[...] Estoy usando **FastAPI** muchísimo estos días. [...] De hecho planeo usarlo para todos los **servicios de ML de mi equipo en Microsoft**. Algunos de ellos se están integrando en el producto central de **Windows** y algunos productos de **Office**._"

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(ref)</small></a></div>

---

"_Adoptamos la librería **FastAPI** para lanzar un servidor **REST** que puede ser consultado para obtener **predicciones**. [para Ludwig]_"

<div style="text-align: right; margin-right: 10%;">Piero Molino, Yaroslav Dudin, y Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(ref)</small></a></div>

---

"_**Netflix** se complace en anunciar la liberación open-source de nuestro marco de orquestación de **gestión de crisis**: **Dispatch**! [¡construido con **FastAPI**]_"

<div style="text-align: right; margin-right: 10%;">Kevin Glisson, Marc Vilanova, Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(ref)</small></a></div>

---

"_Estoy súper emocionado con **FastAPI**. ¡Es muy divertido!_"

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">Anfitrión del podcast Python Bytes</a></strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(ref)</small></a></div>

---

"_Honestamente, lo que has construido se ve muy sólido y pulido. En muchos sentidos, es lo que quería que **Hug** fuera; es realmente inspirador ver que alguien lo haya logrado._"

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">Creador de Hug</a></strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(ref)</small></a></div>

---

"_Si buscas aprender un **framework moderno** para construir APIs REST, revisa **FastAPI** [...] Es rápido, fácil de usar y fácil de aprender [...]_"

"_Nos cambiamos a **FastAPI** para nuestras **APIs** [...] Creo que te va a gustar [...]_"

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">Fundadores de Explosion AI</a> - <a href="https://spacy.io" target="_blank">Creadores de spaCy</a></strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(ref)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(ref)</small></a></div>

---

"_Si alguien está buscando construir una API de Python para producción, recomendaría mucho **FastAPI**. Está **bellamente diseñado**, es **simple de usar** y **altamente escalable**, se ha convertido en un **componente clave** en nuestra estrategia de desarrollo API-first y está impulsando muchas automatizaciones y servicios como nuestro Virtual TAC Engineer._"

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(ref)</small></a></div>

---

## **Typer**, el FastAPI de las CLIs

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

Si estás construyendo una app <abbr title="Interfaz de Línea de Comandos">CLI</abbr> para usar en la terminal en lugar de una API web, revisa <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a>.

**Typer** es el hermano menor de FastAPI. Y está pensado para ser el **FastAPI de las CLIs**. ⌨️ 🚀

## Requisitos

FastAPI se apoya en gigantes:

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> para la parte web.
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> para la parte de datos.

## Instalación

Crea y activa un <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">entorno virtual</a> y luego instala FastAPI:

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**Nota**: Asegúrate de poner `"fastapi[standard]"` entre comillas para que funcione en todas las terminales.

## Ejemplo

### Créalo

Crea un archivo `main.py` con:

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
<summary>O utiliza <code>async def</code>...</summary>

Si tu código usa `async` / `await`, utiliza `async def`:

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

Si no lo sabes, revisa la sección _"¿Con prisa?"_ sobre <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` y `await` en la documentación</a>.

</details>

### Ejecútalo

Ejecuta el servidor con:

<div class="termy">

```console
$ fastapi dev main.py

 ╭────────── FastAPI CLI - Modo desarrollo ───────────╮
 │                                                     │
 │  Sirviendo en: http://127.0.0.1:8000                │
 │                                                     │
 │  Documentación de la API: http://127.0.0.1:8000/docs│
 │                                                     │
 │  Ejecutando en modo desarrollo, para producción usa:│
 │                                                     │
 │  fastapi run                                        │
 │                                                     │
 ╰─────────────────────────────────────────────────────╯

INFO:     Observando cambios en estos directorios: ['/home/user/code/awesomeapp']
INFO:     Uvicorn ejecutándose en http://127.0.0.1:8000 (Presiona CTRL+C para salir)
INFO:     Proceso recargador iniciado [2248755] usando WatchFiles
INFO:     Proceso servidor iniciado [2248757]
INFO:     Esperando inicio de la aplicación.
INFO:     Inicio de la aplicación completo.
```

</div>

<details markdown="1">
<summary>Sobre el comando <code>fastapi dev main.py</code>...</summary>

El comando `fastapi dev` lee tu archivo `main.py`, detecta la app **FastAPI** en él y lanza un servidor usando <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a>.

Por defecto, `fastapi dev` inicia con recarga automática habilitada para desarrollo local.

Puedes leer más sobre esto en la <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">documentación de FastAPI CLI</a>.

</details>

### Pruébalo

Abre tu navegador en <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>.

Verás la respuesta JSON como:

```JSON
{"item_id": 5, "q": "somequery"}
```

Ya creaste una API que:

* Recibe solicitudes HTTP en las _rutas_ `/` y `/items/{item_id}`.
* Ambas _rutas_ aceptan operaciones `GET` (también conocidas como _métodos_ HTTP).
* La _ruta_ `/items/{item_id}` tiene un _parámetro de ruta_ `item_id` que debe ser un `int`.
* La _ruta_ `/items/{item_id}` tiene un _parámetro de consulta_ opcional `q` de tipo `str`.

### Documentación interactiva de la API

Ahora ve a <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

Verás la documentación interactiva automática de la API (proporcionada por <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a>):

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### Documentación alternativa de la API

Y ahora, ve a <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

Verás la documentación alternativa automática (proporcionada por <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a>):

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## Ejemplo avanzado

Ahora modifica el archivo `main.py` para recibir un cuerpo desde una solicitud `PUT`.

Declara el cuerpo usando tipos estándar de Python, gracias a Pydantic.

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

El servidor `fastapi dev` debería recargarse automáticamente.

### Actualización de la documentación interactiva de la API

Ahora ve a <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

* La documentación interactiva de la API se actualizará automáticamente, incluyendo el nuevo cuerpo:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* Haz clic en el botón "Try it out", te permitirá rellenar los parámetros e interactuar directamente con la API:

![Interacción Swagger UI](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* Luego haz clic en el botón "Execute", la interfaz de usuario se comunicará con tu API, enviará los parámetros, obtendrá los resultados y los mostrará en pantalla:

![Interacción Swagger UI](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### Actualización de la documentación alternativa de la API

Y ahora, ve a <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

* La documentación alternativa también reflejará el nuevo parámetro de consulta y el cuerpo:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### Resumen

En resumen, declaras **una vez** los tipos de parámetros, cuerpo, etc. como parámetros de función.

Lo haces con los tipos modernos estándar de Python.

No tienes que aprender una nueva sintaxis, métodos o clases de una librería específica, etc.

Solo **Python** estándar.

Por ejemplo, para un `int`:

```Python
item_id: int
```

o para un modelo `Item` más complejo:

```Python
item: Item
```

...y con esa sola declaración obtienes:

* Soporte en el editor, incluyendo:
    * Autocompletado.
    * Comprobaciones de tipo.
* Validación de datos:
    * Errores automáticos y claros cuando los datos son inválidos.
    * Validación incluso para objetos JSON profundamente anidados.
* <abbr title="también conocido como: serialización, parsing, marshalling">Conversión</abbr> de datos de entrada: desde la red a datos y tipos de Python. Lectura desde:
    * JSON.
    * Parámetros de ruta.
    * Parámetros de consulta.
    * Cookies.
    * Cabeceras.
    * Formularios.
    * Archivos.
* <abbr title="también conocido como: serialización, parsing, marshalling">Conversión</abbr> de datos de salida: convirtiendo de datos y tipos de Python a datos de red (como JSON):
    * Convierte tipos de Python (`str`, `int`, `float`, `bool`, `list`, etc).
    * Objetos `datetime`.
    * Objetos `UUID`.
    * Modelos de base de datos.
    * ...y muchos más.
* Documentación interactiva automática de la API, incluyendo 2 interfaces de usuario alternativas:
    * Swagger UI.
    * ReDoc.

---

Volviendo al ejemplo anterior, **FastAPI**:

* Valida que exista un `item_id` en la ruta para solicitudes `GET` y `PUT`.
* Valida que el `item_id` sea de tipo `int` para solicitudes `GET` y `PUT`.
    * Si no lo es, el cliente verá un error claro y útil.
* Comprueba si existe un parámetro de consulta opcional llamado `q` (como en `http://127.0.0.1:8000/items/foo?q=somequery`) para solicitudes `GET`.
    * Como el parámetro `q` se declara con `= None`, es opcional.
    * Sin el `None` sería requerido (como lo es el cuerpo en el caso de `PUT`).
* Para solicitudes `PUT` a `/items/{item_id}`, lee el cuerpo como JSON:
    * Comprueba que tenga un atributo requerido `name` de tipo `str`.
    * Comprueba que tenga un atributo requerido `price` de tipo `float`.
    * Comprueba que tenga un atributo opcional `is_offer`, que debe ser un `bool`, si está presente.
    * Todo esto también funciona para objetos JSON profundamente anidados.
* Convierte de y hacia JSON automáticamente.
* Documenta todo con OpenAPI, que puede ser utilizado por:
    * Sistemas de documentación interactiva.
    * Sistemas de generación automática de código cliente para muchos lenguajes.
* Proporciona 2 interfaces web de documentación interactiva directamente.

---

Esto es solo la superficie, pero ya tienes la idea de cómo funciona todo.

Prueba cambiando la línea:

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...de:

```Python
        ... "item_name": item.name ...
```

...a:

```Python
        ... "item_price": item.price ...
```

...y verás cómo tu editor autocompleta los atributos y reconoce sus tipos:

![soporte del editor](https://fastapi.tiangolo.com/img/vscode-completion.png)

Para un ejemplo más completo, incluyendo más características, revisa la <a href="https://fastapi.tiangolo.com/tutorial/">Guía de Usuario - Tutorial</a>.

**Spoiler**: el tutorial - guía de usuario incluye:

* Declaración de **parámetros** desde otros lugares como: **cabeceras**, **cookies**, **campos de formulario** y **archivos**.
* Cómo establecer **restricciones de validación** como `maximum_length` o `regex`.
* Un sistema de **<abbr title="también conocido como componentes, recursos, proveedores, servicios, inyectables">Inyección de Dependencias</abbr>** muy potente y fácil de usar.
* Seguridad y autenticación, incluyendo soporte para **OAuth2** con **tokens JWT** y autenticación **HTTP Basic**.
* Técnicas más avanzadas (pero igual de fáciles) para declarar **modelos JSON profundamente anidados** (gracias a Pydantic).
* Integración **GraphQL** con <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> y otras librerías.
* Muchas características extra (gracias a Starlette) como:
    * **WebSockets**
    * tests extremadamente fáciles basados en HTTPX y `pytest`
    * **CORS**
    * **Sesiones de Cookies**
    * ...y más.

## Rendimiento

Benchmarks independientes de TechEmpower muestran aplicaciones **FastAPI** ejecutándose bajo Uvicorn como <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">uno de los frameworks de Python más rápidos disponibles</a>, solo por debajo de Starlette y Uvicorn (usados internamente por FastAPI). (*)

Para entender más sobre esto, revisa la sección <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">Benchmarks</a>.

## Dependencias

FastAPI depende de Pydantic y Starlette.

### Dependencias `standard`

Cuando instalas FastAPI con `pip install "fastapi[standard]"` viene con el grupo `standard` de dependencias opcionales:

Usadas por Pydantic:

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - para validación de emails.

Usadas por Starlette:

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - Requerido si quieres usar el `TestClient`.
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - Requerido si deseas usar la configuración de plantilla por defecto.
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - Requerido si quieres soportar <abbr title="convertir la cadena que viene de una petición HTTP en datos de Python">"parseo"</abbr> de formularios, con `request.form()`.

Usadas por FastAPI / Starlette:

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - para el servidor que carga y sirve tu aplicación. Esto incluye `uvicorn[standard]`, que incluye algunas dependencias (por ejemplo, `uvloop`) necesarias para alto rendimiento.
* `fastapi-cli` - para proporcionar el comando `fastapi`.

### Sin dependencias `standard`

Si no quieres incluir las dependencias opcionales `standard`, puedes instalar con `pip install fastapi` en vez de `pip install "fastapi[standard]"`.

### Dependencias opcionales adicionales

Hay algunas dependencias adicionales que podrías querer instalar.

Dependencias opcionales adicionales de Pydantic:

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - para gestión de configuraciones.
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - para tipos extra para usar con Pydantic.

Dependencias opcionales adicionales de FastAPI:

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - Requerido si quieres usar `ORJSONResponse`.
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - Requerido si quieres usar `UJSONResponse`.

## Licencia

Este proyecto está licenciado bajo los términos de la licencia MIT.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---