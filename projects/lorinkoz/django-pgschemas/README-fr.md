# django-pgschemas

[![Build status](https://github.com/lorinkoz/django-pgschemas/workflows/code/badge.svg)](https://github.com/lorinkoz/django-pgschemas/actions)
[![Documentation status](https://readthedocs.org/projects/django-pgschemas/badge/?version=latest)](https://django-pgschemas.readthedocs.io/)
[![Code coverage](https://coveralls.io/repos/github/lorinkoz/django-pgschemas/badge.svg?branch=master)](https://coveralls.io/github/lorinkoz/django-pgschemas?branch=master)
[![PyPi version](https://badge.fury.io/py/django-pgschemas.svg)](http://badge.fury.io/py/django-pgschemas)
[![Downloads](https://pepy.tech/badge/django-pgschemas/month)](https://pepy.tech/project/django-pgschemas/)

Ce paquet utilise les schémas Postgres pour supporter la multi-location de données dans un seul projet Django. C’est un fork de [django-tenants](https://github.com/django-tenants/django-tenants) avec quelques changements conceptuels :

- Il y a des locataires statiques et des locataires dynamiques. Les locataires statiques peuvent avoir leurs propres applications et urlconf.
- Les locataires peuvent être routés via :
  - URL utilisant un sous-domaine ou un sous-dossier sur un sous-domaine partagé
  - Session
  - En-têtes
- Le schéma public ne doit pas être utilisé pour stocker les données principales du site, mais les véritables données partagées entre tous les locataires. La "surcharge" des tables via le chemin de recherche n’est pas encouragée.
- Les commandes de gestion peuvent être exécutées sur plusieurs schémas via des jokers, soit séquentiellement, soit en parallèle en utilisant le multithreading.

## Documentation

https://django-pgschemas.readthedocs.io/

## Contribution

Voir [CONTRIBUTING.md](https://github.com/lorinkoz/django-pgschemas?tab=contributing-ov-file) pour les détails sur la contribution à ce projet.

## Crédits

- Tom Turner pour [django-tenants](https://github.com/django-tenants/django-tenants).
- Bernardo Pires pour [django-tenant-schemas](https://github.com/bernardopires/django-tenant-schemas).
- Denish Patel pour [pg-clone-schema](https://github.com/denishpatel/pg-clone-schema)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-29

---