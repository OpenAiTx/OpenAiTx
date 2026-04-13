<p align="center">
  <a href="https://pmdevita.github.io/django-shinobi/"><img src="https://pmdevita.github.io/django-shinobi/img/logo-big.png"></a>
</p>
<p align="center">
    <em>Rapide à apprendre, rapide à coder, rapide à exécuter</em>
</p>


![Test](https://github.com/pmdevita/django-shinobi/actions/workflows/test_full.yml/badge.svg)
![Couverture](https://img.shields.io/codecov/c/github/pmdevita/django-shinobi)
[![Version PyPI](https://badge.fury.io/py/django-shinobi.svg)](https://badge.fury.io/py/django-shinobi)
[![Téléchargements](https://static.pepy.tech/personalized-badge/django-shinobi?period=month&units=international_system&left_color=black&right_color=brightgreen&left_text=téléchargements/mois)](https://pepy.tech/project/django-shinobi)
[![Discord](https://dcbadge.limes.pink/api/server/ntFTXu7NNv?style=flat-square)](https://discord.gg/ntFTXu7NNv)

# Django Shinobi - Framework REST Django rapide

[Documentation](https://pmdevita.github.io/django-shinobi)

**Django Shinobi** est un framework web pour construire des API avec **Django** et les **annotations de type Python 3.6+**. 

C'est un fork de la fantastique bibliothèque **[Django Ninja](https://github.com/vitalik/django-ninja)** axé sur 
les fonctionnalités et corrections souhaitées par la communauté. Consultez la liste des [différences](https://pmdevita.github.io/django-shinobi/differences/) 
si vous venez de Ninja, ainsi que la [feuille de route](https://github.com/pmdevita/django-shinobi/discussions/6) !


 **Fonctionnalités clés :**

  - **Facile** : Conçu pour être simple à utiliser et intuitif.
  - **Exécution RAPIDE** : Très haute performance grâce à **<a href="https://pydantic-docs.helpmanual.io" target="_blank">Pydantic</a>** et au **<a href="/docs/docs/guides/async-support.md">support async</a>**.
  - **Rapide à coder** : Les annotations de type et la documentation automatique vous permettent de vous concentrer uniquement sur la logique métier.
  - **Basé sur des standards** : Basé sur les standards ouverts pour les API : **OpenAPI** (anciennement Swagger) et **JSON Schema**.
  - **Compatible Django** : (évidemment) bonne intégration avec le cœur de Django et l'ORM.
  - **Prêt pour la production** : Le projet Ninja original est utilisé par plusieurs entreprises sur des projets en production.



![Django Shinobi REST Framework](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/benchmark.png)

**Documentation** : https://pmdevita.github.io/django-shinobi

---

## Installation

Dans votre projet Django, ajoutez Django Shinobi.

```
pip install django-shinobi
```
ou démarrer un nouveau projet.


```shell
pip install django django-shinobi
django-admin startproject apidemo
```

## Utilisation


Dans votre projet Django, à côté de urls.py, créez un nouveau fichier appelé `api.py`.

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

**C'est tout !**

Vous venez de créer une API qui :

 - reçoit une requête HTTP GET sur `/api/add`
 - prend, valide et convertit les paramètres GET `a` et `b`
 - décode le résultat en JSON
 - génère un schéma OpenAPI pour l'opération définie

### Documentation interactive de l'API

Lancez votre projet Django

```shell
python manage.py runsever
```

Allez maintenant sur <a href="http://127.0.0.1:8000/api/docs" target="_blank">http://127.0.0.1:8000/api/docs</a>

Vous verrez la documentation API interactive automatique (fournie par <a href="https://github.com/swagger-api/swagger-ui" target="_blank">Swagger UI</a> ou <a href="https://github.com/Redocly/redoc" target="_blank">Redoc</a>) :

![Swagger UI](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/index-swagger-ui.png)

## Et ensuite ?

 - Lisez la documentation complète ici - https://pmdevita.github.io/django-shinobi
 - Pour soutenir ce projet, veuillez lui donner une étoile sur Github. ![github star](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/github-star.png)
 - Partagez-le [via Twitter](https://twitter.com/intent/tweet?text=Check%20out%20Django%20Shinobi%20-%20Fast%20Django%20REST%20Framework%20-%20https%3A%2F%2Fpmdevita.github.io/django-shinobi)
 - Partagez vos retours et discutez du développement sur Discord https://discord.gg/ntFTXu7NNv



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-13

---