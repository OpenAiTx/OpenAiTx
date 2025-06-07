<p align="center">
  <a href="https://fastapi.tiangolo.com"><img src="https://fastapi.tiangolo.com/img/logo-margin/logo-teal.png" alt="FastAPI"></a>
</p>
<p align="center">
    <em>Framework FastAPI, alto desempenho, fácil de aprender, rápido para codificar, pronto para produção</em>
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

**Documentação**: <a href="https://fastapi.tiangolo.com" target="_blank">https://fastapi.tiangolo.com</a>

**Código Fonte**: <a href="https://github.com/fastapi/fastapi" target="_blank">https://github.com/fastapi/fastapi</a>

---

FastAPI é um framework web moderno, rápido (alto desempenho), para construção de APIs com Python baseado em type hints padrão do Python.

As principais características são:

* **Rápido**: Desempenho muito alto, comparável ao **NodeJS** e **Go** (graças ao Starlette e Pydantic). [Um dos frameworks Python mais rápidos disponíveis](#performance).
* **Rápido para codificar**: Aumenta a velocidade de desenvolvimento de funcionalidades em cerca de 200% a 300%. *
* **Menos bugs**: Reduz cerca de 40% dos erros induzidos por humanos (desenvolvedores). *
* **Intuitivo**: Grande suporte do editor. <abbr title="também conhecido como auto-complete, autocompletion, IntelliSense">Autocompletar</abbr> em todo lugar. Menos tempo depurando.
* **Fácil**: Projetado para ser fácil de usar e aprender. Menos tempo lendo a documentação.
* **Curto**: Minimiza a duplicação de código. Múltiplas funcionalidades a partir de cada declaração de parâmetro. Menos bugs.
* **Robusto**: Código pronto para produção. Com documentação interativa automática.
* **Baseado em padrões**: Baseado (e totalmente compatível) nos padrões abertos para APIs: <a href="https://github.com/OAI/OpenAPI-Specification" class="external-link" target="_blank">OpenAPI</a> (anteriormente conhecido como Swagger) e <a href="https://json-schema.org/" class="external-link" target="_blank">JSON Schema</a>.

<small>* estimativa baseada em testes em uma equipe interna de desenvolvimento, construindo aplicações de produção.</small>

## Patrocinadores

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

<a href="https://fastapi.tiangolo.com/fastapi-people/#sponsors" class="external-link" target="_blank">Outros patrocinadores</a>

## Opiniões

"_[...] Tenho usado **FastAPI** bastante ultimamente. [...] Estou realmente planejando usá-lo para todos os **serviços de ML da minha equipe na Microsoft**. Alguns deles estão sendo integrados ao núcleo do produto **Windows** e alguns produtos do **Office**._"

<div style="text-align: right; margin-right: 10%;">Kabir Khan - <strong>Microsoft</strong> <a href="https://github.com/fastapi/fastapi/pull/26" target="_blank"><small>(ref)</small></a></div>

---

"_Adotamos a biblioteca **FastAPI** para criar um servidor **REST** que pode ser consultado para obter **predições**. [para Ludwig]_"

<div style="text-align: right; margin-right: 10%;">Piero Molino, Yaroslav Dudin, e Sai Sumanth Miryala - <strong>Uber</strong> <a href="https://eng.uber.com/ludwig-v0-2/" target="_blank"><small>(ref)</small></a></div>

---

"_**Netflix** tem o prazer de anunciar o lançamento open-source de nosso framework de orquestração de **gerenciamento de crises**: **Dispatch**! [construído com **FastAPI**]_"

<div style="text-align: right; margin-right: 10%;">Kevin Glisson, Marc Vilanova, Forest Monsen - <strong>Netflix</strong> <a href="https://netflixtechblog.com/introducing-dispatch-da4b8a2a8072" target="_blank"><small>(ref)</small></a></div>

---

"_Estou super empolgado com o **FastAPI**. É muito divertido!_"

<div style="text-align: right; margin-right: 10%;">Brian Okken - <strong><a href="https://pythonbytes.fm/episodes/show/123/time-to-right-the-py-wrongs?time_in_sec=855" target="_blank">Python Bytes</a> apresentador do podcast</strong> <a href="https://twitter.com/brianokken/status/1112220079972728832" target="_blank"><small>(ref)</small></a></div>

---

"_Sinceramente, o que você construiu parece muito sólido e refinado. Em muitos aspectos, é o que eu queria que o **Hug** fosse - é realmente inspirador ver alguém construir isso._"

<div style="text-align: right; margin-right: 10%;">Timothy Crosley - <strong><a href="https://github.com/hugapi/hug" target="_blank">Criador do Hug</a></strong> <a href="https://news.ycombinator.com/item?id=19455465" target="_blank"><small>(ref)</small></a></div>

---

"_Se você procura aprender um **framework moderno** para construir APIs REST, confira o **FastAPI** [...] É rápido, fácil de usar e fácil de aprender [...]_"

"_Mudamos para o **FastAPI** para nossas **APIs** [...] Acho que você vai gostar [...]_"

<div style="text-align: right; margin-right: 10%;">Ines Montani - Matthew Honnibal - <strong><a href="https://explosion.ai" target="_blank">Fundadores da Explosion AI</a> - <a href="https://spacy.io" target="_blank">Criadores do spaCy</a></strong> <a href="https://twitter.com/_inesmontani/status/1144173225322143744" target="_blank"><small>(ref)</small></a> - <a href="https://twitter.com/honnibal/status/1144031421859655680" target="_blank"><small>(ref)</small></a></div>

---

"_Se alguém estiver procurando construir uma API Python de produção, eu recomendo fortemente o **FastAPI**. É **belamente projetado**, **simples de usar** e **altamente escalável**, tornou-se um **componente chave** em nossa estratégia de desenvolvimento API first e está impulsionando muitas automações e serviços como nosso Virtual TAC Engineer._"

<div style="text-align: right; margin-right: 10%;">Deon Pillsbury - <strong>Cisco</strong> <a href="https://www.linkedin.com/posts/deonpillsbury_cisco-cx-python-activity-6963242628536487936-trAp/" target="_blank"><small>(ref)</small></a></div>

---

## **Typer**, o FastAPI dos CLIs

<a href="https://typer.tiangolo.com" target="_blank"><img src="https://typer.tiangolo.com/img/logo-margin/logo-margin-vector.svg" style="width: 20%;"></a>

Se você está construindo um app de <abbr title="Command Line Interface">CLI</abbr> para ser usado no terminal ao invés de uma API web, confira o <a href="https://typer.tiangolo.com/" class="external-link" target="_blank">**Typer**</a>.

**Typer** é o irmão mais novo do FastAPI. E foi feito para ser o **FastAPI dos CLIs**. ⌨️ 🚀

## Requisitos

O FastAPI está sobre os ombros de gigantes:

* <a href="https://www.starlette.io/" class="external-link" target="_blank">Starlette</a> para as partes web.
* <a href="https://docs.pydantic.dev/" class="external-link" target="_blank">Pydantic</a> para as partes de dados.

## Instalação

Crie e ative um <a href="https://fastapi.tiangolo.com/virtual-environments/" class="external-link" target="_blank">ambiente virtual</a> e então instale o FastAPI:

<div class="termy">

```console
$ pip install "fastapi[standard]"

---> 100%
```

</div>

**Nota**: Certifique-se de colocar `"fastapi[standard]"` entre aspas para garantir que funcione em todos os terminais.

## Exemplo

### Crie

Crie um arquivo `main.py` com:

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
<summary>Ou use <code>async def</code>...</summary>

Se seu código usa `async` / `await`, use `async def`:

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

Se você não sabe, veja a seção _"Com pressa?"_ sobre <a href="https://fastapi.tiangolo.com/async/#in-a-hurry" target="_blank">`async` e `await` na documentação</a>.

</details>

### Execute

Execute o servidor com:

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
<summary>Sobre o comando <code>fastapi dev main.py</code>...</summary>

O comando `fastapi dev` lê seu arquivo `main.py`, detecta o app **FastAPI** nele e inicia um servidor usando o <a href="https://www.uvicorn.org" class="external-link" target="_blank">Uvicorn</a>.

Por padrão, `fastapi dev` inicia com auto-reload habilitado para desenvolvimento local.

Você pode ler mais sobre isso na <a href="https://fastapi.tiangolo.com/fastapi-cli/" target="_blank">documentação do FastAPI CLI</a>.

</details>

### Verifique

Abra seu navegador em <a href="http://127.0.0.1:8000/items/5?q=somequery" class="external-link" target="_blank">http://127.0.0.1:8000/items/5?q=somequery</a>.

Você verá a resposta JSON como:

```JSON
{"item_id": 5, "q": "somequery"}
```

Você já criou uma API que:

* Recebe requisições HTTP nos _caminhos_ `/` e `/items/{item_id}`.
* Ambos os _caminhos_ aceitam operações `GET` (também conhecidas como _métodos_ HTTP).
* O _caminho_ `/items/{item_id}` possui um _parâmetro de caminho_ `item_id` que deve ser um `int`.
* O _caminho_ `/items/{item_id}` possui um _parâmetro de consulta_ opcional `q` do tipo `str`.

### Documentação interativa da API

Agora vá para <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

Você verá a documentação interativa automática da API (fornecida pelo <a href="https://github.com/swagger-api/swagger-ui" class="external-link" target="_blank">Swagger UI</a>):

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-01-swagger-ui-simple.png)

### Documentação alternativa da API

E agora, acesse <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

Você verá a documentação alternativa automática (fornecida pelo <a href="https://github.com/Rebilly/ReDoc" class="external-link" target="_blank">ReDoc</a>):

![ReDoc](https://fastapi.tiangolo.com/img/index/index-02-redoc-simple.png)

## Exemplo melhorado

Agora modifique o arquivo `main.py` para receber um corpo de uma requisição `PUT`.

Declare o corpo usando tipos padrão do Python, graças ao Pydantic.

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

O servidor `fastapi dev` deve recarregar automaticamente.

### Upgrade da documentação interativa da API

Agora vá para <a href="http://127.0.0.1:8000/docs" class="external-link" target="_blank">http://127.0.0.1:8000/docs</a>.

* A documentação interativa da API será automaticamente atualizada, incluindo o novo corpo:

![Swagger UI](https://fastapi.tiangolo.com/img/index/index-03-swagger-02.png)

* Clique no botão "Try it out", ele permite que você preencha os parâmetros e interaja diretamente com a API:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-04-swagger-03.png)

* Depois clique no botão "Execute", a interface irá se comunicar com sua API, enviar os parâmetros, obter os resultados e exibi-los na tela:

![Swagger UI interaction](https://fastapi.tiangolo.com/img/index/index-05-swagger-04.png)

### Upgrade da documentação alternativa da API

E agora, acesse <a href="http://127.0.0.1:8000/redoc" class="external-link" target="_blank">http://127.0.0.1:8000/redoc</a>.

* A documentação alternativa também irá refletir o novo parâmetro de consulta e corpo:

![ReDoc](https://fastapi.tiangolo.com/img/index/index-06-redoc-02.png)

### Recapitulação

Resumindo, você declara **uma vez** os tipos de parâmetros, corpo, etc. como parâmetros de função.

Você faz isso com tipos modernos padrão do Python.

Você não precisa aprender uma nova sintaxe, métodos ou classes de uma biblioteca específica, etc.

Apenas **Python** padrão.

Por exemplo, para um `int`:

```Python
item_id: int
```

ou para um modelo mais complexo `Item`:

```Python
item: Item
```

...e com essa única declaração você obtém:

* Suporte do editor, incluindo:
    * Autocompletar.
    * Verificação de tipos.
* Validação de dados:
    * Erros automáticos e claros quando os dados são inválidos.
    * Validação até mesmo para objetos JSON profundamente aninhados.
* <abbr title="também conhecido como: serialização, parsing, marshalling">Conversão</abbr> de dados de entrada: vindo da rede para dados e tipos Python. Lendo de:
    * JSON.
    * Parâmetros de caminho.
    * Parâmetros de consulta.
    * Cookies.
    * Headers.
    * Forms.
    * Arquivos.
* <abbr title="também conhecido como: serialização, parsing, marshalling">Conversão</abbr> de dados de saída: convertendo de dados e tipos Python para dados de rede (como JSON):
    * Converte tipos Python (`str`, `int`, `float`, `bool`, `list`, etc).
    * Objetos `datetime`.
    * Objetos `UUID`.
    * Modelos de banco de dados.
    * ...e muitos mais.
* Documentação automática interativa da API, incluindo 2 interfaces alternativas:
    * Swagger UI.
    * ReDoc.

---

Voltando ao exemplo de código anterior, o **FastAPI** irá:

* Validar que há um `item_id` no caminho para requisições `GET` e `PUT`.
* Validar que o `item_id` é do tipo `int` para requisições `GET` e `PUT`.
    * Se não for, o cliente verá um erro útil e claro.
* Verificar se há um parâmetro de consulta opcional chamado `q` (como em `http://127.0.0.1:8000/items/foo?q=somequery`) para requisições `GET`.
    * Como o parâmetro `q` é declarado com `= None`, ele é opcional.
    * Sem o `None` seria obrigatório (como é o corpo no caso do `PUT`).
* Para requisições `PUT` em `/items/{item_id}`, ler o corpo como JSON:
    * Verificar que possui um atributo obrigatório `name` que deve ser `str`.
    * Verificar que possui um atributo obrigatório `price` que deve ser `float`.
    * Verificar que possui um atributo opcional `is_offer`, que deve ser `bool`, se presente.
    * Tudo isso também funciona para objetos JSON profundamente aninhados.
* Converter de e para JSON automaticamente.
* Documentar tudo com OpenAPI, que pode ser usado por:
    * Sistemas de documentação interativa.
    * Sistemas de geração automática de código cliente, para várias linguagens.
* Fornecer 2 interfaces web de documentação interativa diretamente.

---

Apenas arranhamos a superfície, mas você já tem uma ideia de como tudo funciona.

Tente mudar a linha:

```Python
    return {"item_name": item.name, "item_id": item_id}
```

...de:

```Python
        ... "item_name": item.name ...
```

...para:

```Python
        ... "item_price": item.price ...
```

...e veja como seu editor irá autocompletar os atributos e conhecer seus tipos:

![editor support](https://fastapi.tiangolo.com/img/vscode-completion.png)

Para um exemplo mais completo incluindo mais funcionalidades, veja o <a href="https://fastapi.tiangolo.com/tutorial/">Tutorial - Guia do Usuário</a>.

**Alerta de spoiler**: o tutorial - guia do usuário inclui:

* Declaração de **parâmetros** de vários locais diferentes, como: **headers**, **cookies**, **campos de formulário** e **arquivos**.
* Como definir **restrições de validação** como `maximum_length` ou `regex`.
* Um sistema de **<abbr title="também conhecido como components, resources, providers, services, injectables">Injeção de Dependência</abbr>** muito poderoso e fácil de usar.
* Segurança e autenticação, incluindo suporte para **OAuth2** com **tokens JWT** e autenticação **HTTP Basic**.
* Técnicas mais avançadas (mas igualmente fáceis) para declarar **modelos JSON profundamente aninhados** (graças ao Pydantic).
* Integração com **GraphQL** usando <a href="https://strawberry.rocks" class="external-link" target="_blank">Strawberry</a> e outras bibliotecas.
* Muitas funcionalidades extras (graças ao Starlette) como:
    * **WebSockets**
    * testes extremamente fáceis baseados em HTTPX e `pytest`
    * **CORS**
    * **Sessões por Cookie**
    * ...e mais.

## Desempenho

Benchmarks independentes do TechEmpower mostram aplicações **FastAPI** rodando sob Uvicorn como <a href="https://www.techempower.com/benchmarks/#section=test&runid=7464e520-0dc2-473d-bd34-dbdfd7e85911&hw=ph&test=query&l=zijzen-7" class="external-link" target="_blank">um dos frameworks Python mais rápidos disponíveis</a>, apenas abaixo do Starlette e Uvicorn (usados internamente pelo FastAPI). (*)

Para entender mais sobre isso, veja a seção <a href="https://fastapi.tiangolo.com/benchmarks/" class="internal-link" target="_blank">Benchmarks</a>.

## Dependências

O FastAPI depende do Pydantic e do Starlette.

### Dependências `standard`

Quando você instala o FastAPI com `pip install "fastapi[standard]"` ele vem com o grupo `standard` de dependências opcionais:

Usadas pelo Pydantic:

* <a href="https://github.com/JoshData/python-email-validator" target="_blank"><code>email-validator</code></a> - para validação de e-mails.

Usadas pelo Starlette:

* <a href="https://www.python-httpx.org" target="_blank"><code>httpx</code></a> - Necessário se você quiser usar o `TestClient`.
* <a href="https://jinja.palletsprojects.com" target="_blank"><code>jinja2</code></a> - Necessário se quiser usar a configuração padrão de templates.
* <a href="https://github.com/Kludex/python-multipart" target="_blank"><code>python-multipart</code></a> - Necessário se quiser suportar <abbr title="convertendo a string que vem de uma requisição HTTP em dados Python">"parsing"</abbr> de formulários, com `request.form()`.

Usadas pelo FastAPI / Starlette:

* <a href="https://www.uvicorn.org" target="_blank"><code>uvicorn</code></a> - para o servidor que carrega e serve sua aplicação. Isso inclui `uvicorn[standard]`, que traz algumas dependências (ex: `uvloop`) necessárias para servir com alto desempenho.
* `fastapi-cli` - para fornecer o comando `fastapi`.

### Sem dependências `standard`

Se você não quiser incluir as dependências opcionais `standard`, pode instalar com `pip install fastapi` ao invés de `pip install "fastapi[standard]"`.

### Dependências opcionais adicionais

Existem algumas dependências adicionais que você pode querer instalar.

Dependências opcionais adicionais do Pydantic:

* <a href="https://docs.pydantic.dev/latest/usage/pydantic_settings/" target="_blank"><code>pydantic-settings</code></a> - para gerenciamento de configurações.
* <a href="https://docs.pydantic.dev/latest/usage/types/extra_types/extra_types/" target="_blank"><code>pydantic-extra-types</code></a> - para tipos extras a serem usados com o Pydantic.

Dependências opcionais adicionais do FastAPI:

* <a href="https://github.com/ijl/orjson" target="_blank"><code>orjson</code></a> - Necessário se quiser usar `ORJSONResponse`.
* <a href="https://github.com/esnme/ultrajson" target="_blank"><code>ujson</code></a> - Necessário se quiser usar `UJSONResponse`.

## Licença

Este projeto é licenciado sob os termos da licença MIT.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---