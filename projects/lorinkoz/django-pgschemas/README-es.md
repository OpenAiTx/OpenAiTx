# django-pgschemas

[![Estado de compilación](https://github.com/lorinkoz/django-pgschemas/workflows/code/badge.svg)](https://github.com/lorinkoz/django-pgschemas/actions)
[![Estado de la documentación](https://readthedocs.org/projects/django-pgschemas/badge/?version=latest)](https://django-pgschemas.readthedocs.io/)
[![Cobertura de código](https://coveralls.io/repos/github/lorinkoz/django-pgschemas/badge.svg?branch=master)](https://coveralls.io/github/lorinkoz/django-pgschemas?branch=master)
[![Versión en PyPi](https://badge.fury.io/py/django-pgschemas.svg)](http://badge.fury.io/py/django-pgschemas)
[![Descargas](https://pepy.tech/badge/django-pgschemas/month)](https://pepy.tech/project/django-pgschemas/)

Este paquete utiliza esquemas de Postgres para soportar multi-tenancy de datos en un único proyecto Django. Es un fork de [django-tenants](https://github.com/django-tenants/django-tenants) con algunos cambios conceptuales:

- Hay inquilinos estáticos y dinámicos. Los inquilinos estáticos pueden tener sus propias aplicaciones y urlconf.
- Los inquilinos pueden ser direccionados mediante:
  - URL usando subdominio o subcarpeta en subdominio compartido
  - Sesión
  - Encabezados
- El esquema público no debe usarse para almacenar los datos del sitio principal, sino los datos verdaderamente compartidos entre todos los inquilinos. No se recomienda "sobrescribir" tablas mediante el search path.
- Los comandos de gestión pueden ejecutarse en múltiples esquemas mediante comodines, ya sea secuencialmente o en paralelo usando multihilo.

## Documentación

https://django-pgschemas.readthedocs.io/

## Contribuir

Consulta [CONTRIBUTING.md](https://github.com/lorinkoz/django-pgschemas?tab=contributing-ov-file) para detalles sobre cómo contribuir a este proyecto.

## Créditos

- Tom Turner por [django-tenants](https://github.com/django-tenants/django-tenants).
- Bernardo Pires por [django-tenant-schemas](https://github.com/bernardopires/django-tenant-schemas).
- Denish Patel por [pg-clone-schema](https://github.com/denishpatel/pg-clone-schema)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-29

---