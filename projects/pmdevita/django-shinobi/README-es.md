<p align="center">
  <a href="https://pmdevita.github.io/django-shinobi/"><img src="https://pmdevita.github.io/django-shinobi/img/logo-big.png"></a>
</p>
<p align="center">
    <em>Rápido de aprender, rápido de codificar, rápido de ejecutar</em>
</p>


![Test](https://github.com/pmdevita/django-shinobi/actions/workflows/test_full.yml/badge.svg)
![Coverage](https://img.shields.io/codecov/c/github/pmdevita/django-shinobi)
[![PyPI version](https://badge.fury.io/py/django-shinobi.svg)](https://badge.fury.io/py/django-shinobi)
[![Downloads](https://static.pepy.tech/personalized-badge/django-shinobi?period=month&units=international_system&left_color=black&right_color=brightgreen&left_text=downloads/month)](https://pepy.tech/project/django-shinobi)
[![Discord](https://dcbadge.limes.pink/api/server/ntFTXu7NNv?style=flat-square)](https://discord.gg/ntFTXu7NNv)

# Django Shinobi - Framework REST rápido para Django

[Documentación](https://pmdevita.github.io/django-shinobi)

**Django Shinobi** es un framework web para construir APIs con **Django** y **type hints** de Python 3.6+. 

Es un fork de la fantástica librería **[Django Ninja](https://github.com/vitalik/django-ninja)** enfocada en 
características y correcciones deseadas por la comunidad. Revisa la lista de [diferencias](https://pmdevita.github.io/django-shinobi/differences/) 
si vienes de Ninja, así como la [hoja de ruta](https://github.com/pmdevita/django-shinobi/discussions/6)!


 **Características clave:**

  - **Fácil**: Diseñado para ser fácil de usar e intuitivo.
  - **Ejecución RÁPIDA**: Muy alto rendimiento gracias a **<a href="https://pydantic-docs.helpmanual.io" target="_blank">Pydantic</a>** y **<a href="/docs/docs/guides/async-support.md">soporte async</a>**.
  - **Rápido para codificar**: Los type hints y la documentación automática te permiten enfocarte solo en la lógica de negocio.
  - **Basado en estándares**: Basado en los estándares abiertos para APIs: **OpenAPI** (anteriormente conocido como Swagger) y **JSON Schema**.
  - **Compatible con Django**: (obviamente) tiene buena integración con el núcleo de Django y el ORM.
  - **Listo para producción**: El proyecto original Ninja es usado por múltiples empresas en proyectos en producción.



![Django Shinobi REST Framework](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/benchmark.png)

**Documentación**: https://pmdevita.github.io/django-shinobi

---

## Instalación

En tu proyecto Django, añade Django Shinobi.

```
pip install django-shinobi
```
o iniciar un nuevo proyecto.


```shell
pip install django django-shinobi
django-admin startproject apidemo
```

## Uso


En tu proyecto Django, junto a urls.py, crea un nuevo archivo llamado `api.py`.

```Python
from ninja import NinjaAPI

api = NinjaAPI()


@api.get("/add")
def add(request, a: int, b: int):
    return {"result": a + b}
```


Now go to `urls.py` and add the following:


```Python hl_lines="3 7"
...
from .api import api

urlpatterns = [
    path("admin/", admin.site.urls),
    path("api/", api.urls),  # <---------- !
]
```

**¡Eso es todo!**

Ahora acabas de crear una API que:

 - recibe una solicitud HTTP GET en `/api/add`
 - toma, valida y convierte los parámetros GET `a` y `b`
 - decodifica el resultado a JSON
 - genera un esquema OpenAPI para la operación definida

### Documentación interactiva de la API

Ejecuta tu proyecto Django

```shell
python manage.py runsever
```
Ahora ve a <a href="http://127.0.0.1:8000/api/docs" target="_blank">http://127.0.0.1:8000/api/docs</a>

Verás la documentación automática interactiva de la API (proporcionada por <a href="https://github.com/swagger-api/swagger-ui" target="_blank">Swagger UI</a> o <a href="https://github.com/Redocly/redoc" target="_blank">Redoc</a>):


![Swagger UI](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/index-swagger-ui.png)

## ¿Qué sigue?

 - Lee la documentación completa aquí - https://pmdevita.github.io/django-shinobi
 - Para apoyar este proyecto, por favor dale una estrella en Github. ![github star](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/github-star.png)
 - Compártelo [vía Twitter](https://twitter.com/intent/tweet?text=Check%20out%20Django%20Shinobi%20-%20Fast%20Django%20REST%20Framework%20-%20https%3A%2F%2Fpmdevita.github.io/django-shinobi)
 - Comparte tus comentarios y discute el desarrollo en Discord https://discord.gg/ntFTXu7NNv



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-13

---