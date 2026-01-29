# django-pgschemas

[![Build status](https://github.com/lorinkoz/django-pgschemas/workflows/code/badge.svg)](https://github.com/lorinkoz/django-pgschemas/actions)
[![Documentation status](https://readthedocs.org/projects/django-pgschemas/badge/?version=latest)](https://django-pgschemas.readthedocs.io/)
[![Code coverage](https://coveralls.io/repos/github/lorinkoz/django-pgschemas/badge.svg?branch=master)](https://coveralls.io/github/lorinkoz/django-pgschemas?branch=master)
[![PyPi version](https://badge.fury.io/py/django-pgschemas.svg)](http://badge.fury.io/py/django-pgschemas)
[![Downloads](https://pepy.tech/badge/django-pgschemas/month)](https://pepy.tech/project/django-pgschemas/)

This package uses Postgres schemas to support data multi-tenancy in a single Django project. It is a fork of [django-tenants](https://github.com/django-tenants/django-tenants) with some conceptual changes:

- There are static tenants and dynamic tenants. Static tenants can have their own apps and urlconf.
- Tenants can be routed via:
  - URL using subdomain or subfolder on shared subdomain
  - Session
  - Headers
- Public schema should not be used for storing the main site data, but the true shared data across all tenants. Table "overriding" via search path is not encouraged.
- Management commands can be run on multiple schemas via wildcards, either sequentially or in parallel using multithreading.

## Documentation

https://django-pgschemas.readthedocs.io/

## Contributing

See [CONTRIBUTING.md](https://github.com/lorinkoz/django-pgschemas?tab=contributing-ov-file) for details on how to contribute to this project.

## Credits

- Tom Turner for [django-tenants](https://github.com/django-tenants/django-tenants).
- Bernardo Pires for [django-tenant-schemas](https://github.com/bernardopires/django-tenant-schemas).
- Denish Patel for [pg-clone-schema](https://github.com/denishpatel/pg-clone-schema)
