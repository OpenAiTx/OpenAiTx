# DocLite

Un potente almacén de documentos NoSQL para PHP construido sobre SQLite.

[![CI](https://github.com/dwgebler/doclite/actions/workflows/ci.yml/badge.svg)](https://github.com/dwgebler/doclite/actions/workflows/ci.yml)

## Acerca de

DocLite es un almacén de documentos NoSQL para PHP construido sobre SQLite. Utiliza la biblioteca PHP PDO SQLite para gestionar automáticamente documentos organizados en colecciones nombradas, almacenados como JSON. DocLite aprovecha la extensión JSON1 de SQLite para almacenar, analizar, indexar y consultar documentos JSON, ofreciéndote el poder de una solución NoSQL totalmente transaccional y compatible con ACID contenida completamente dentro del sistema de archivos local.

DocLite se adapta a una variedad de casos de uso: prototipado rápido, sitios web y aplicaciones pequeñas a medianas, una caché local rápida para datos de API remotas, un reemplazo robusto para almacenes de archivos planos y una base de datos para microservicios o aplicaciones web locales. En general, es adecuado para [los mismos casos de uso que SQLite](https://www.sqlite.org/whentouse.html), pero cuando se prefiere un modelo de documentos NoSQL.

## Instalación

```bash
composer require dwgebler/doclite
```

Requiere PHP 8.1+ y la extensión `pdo_sqlite`.

¿Actualizando desde la versión 1.x? Consulta [UPGRADE-2.0.md](https://raw.githubusercontent.com/dwgebler/doclite/main/UPGRADE-2.0.md).

## Inicio rápido

```php
use Gebler\Doclite\FileDatabase;

$db = new FileDatabase('./data');
$users = $db->collection('users');

$alice = $users->get();
$alice->setValue('name', 'Alice');
$alice->setValue('email', 'alice@example.com');
$alice->save();

$found = $users->findOneBy(['email' => 'alice@example.com']);
echo $found->getValue('name'); // Alice
```

## Documentación

- [Primeros pasos](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/getting-started.md) — instalación, requisitos, tu primera base de datos
- [Colecciones y documentos](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/collections.md) — CRUD, transacciones, esquemas, mapeo de clases personalizado
- [Consultas](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/queries.md) — constructor de consultas, joins, paginación, agregación, indexación
- [Búsqueda de texto completo](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/full-text-search.md) — búsqueda potenciada por FTS5
- [Avanzado](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/advanced.md) — importación/exportación, modos de diario, JSONB, adaptador de caché PSR-16, registro
- [Integración con Symfony](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/symfony.md) — integración de DocLite en una aplicación Symfony

## Licencia

MIT. Ver [LICENSE](LICENSE).

## Reporte de errores

Por favor, crea un issue en [GitHub](https://github.com/dwgebler/doclite/issues).

## Reporte de vulnerabilidades

Ver [SECURITY.md](https://raw.githubusercontent.com/dwgebler/doclite/main/SECURITY.md).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-01

---