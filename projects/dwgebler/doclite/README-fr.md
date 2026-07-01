# DocLite

Un puissant magasin de documents NoSQL en PHP construit sur SQLite.

[![CI](https://github.com/dwgebler/doclite/actions/workflows/ci.yml/badge.svg)](https://github.com/dwgebler/doclite/actions/workflows/ci.yml)

## À propos

DocLite est un magasin de documents NoSQL pour PHP construit sur SQLite. Il utilise la bibliothèque PHP PDO SQLite pour gérer automatiquement les documents organisés en collections nommées, stockés au format JSON. DocLite tire parti de l'extension JSON1 de SQLite pour stocker, analyser, indexer et interroger les documents JSON — vous offrant la puissance d'une solution NoSQL entièrement transactionnelle, conforme ACID, contenue intégralement dans le système de fichiers local.

DocLite se prête à une variété de cas d'utilisation : prototypage rapide, sites web et applications de petite à moyenne taille, cache local rapide pour les données d'API distantes, remplacement robuste des magasins à fichiers plats, et base de données pour microservices ou applications web locales. De manière générale, il convient aux [mêmes cas d'utilisation que SQLite lui-même](https://www.sqlite.org/whentouse.html), mais où un modèle de document NoSQL est préféré.

## Installation

```bash
composer require dwgebler/doclite
```

Nécessite PHP 8.1+ et l’extension `pdo_sqlite`.

Mise à niveau depuis la version 1.x ? Voir [UPGRADE-2.0.md](https://raw.githubusercontent.com/dwgebler/doclite/main/UPGRADE-2.0.md).

## Démarrage rapide

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

## Documentation

- [Prise en main](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/getting-started.md) — installation, exigences, votre première base de données
- [Collections & documents](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/collections.md) — CRUD, transactions, schémas, mappage de classes personnalisées
- [Requêtes](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/queries.md) — constructeur de requêtes, jointures, pagination, agrégation, indexation
- [Recherche en texte intégral](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/full-text-search.md) — recherche alimentée par FTS5
- [Avancé](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/advanced.md) — import/export, modes de journal, JSONB, adaptateur de cache PSR-16, journalisation
- [Intégration Symfony](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/symfony.md) — intégration de DocLite dans une application Symfony

## Licence

MIT. Voir [LICENSE](LICENSE).

## Signaler des bugs

Veuillez créer un ticket sur [GitHub](https://github.com/dwgebler/doclite/issues).

## Signaler des vulnérabilités

Voir [SECURITY.md](https://raw.githubusercontent.com/dwgebler/doclite/main/SECURITY.md).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-01

---