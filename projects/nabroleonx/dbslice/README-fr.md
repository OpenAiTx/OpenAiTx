<p align="center">
  <img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/logo.png" alt="logo dbslice" width="128">
</p>

# dbslice

[![Version PyPI](https://img.shields.io/pypi/v/dbslice)](https://pypi.org/project/dbslice/)
[![Licence : MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![Python 3.10+](https://img.shields.io/badge/python-3.10%2B-blue.svg)](https://www.python.org/downloads/)

Extraire des sous-ensembles minimaux et référentiellement intacts de bases de données pour le développement local et le débogage.

## Le problème

Copier une base de données de production entière sur votre machine est infaisable. Mais reproduire un bug nécessite souvent d’avoir les données exactes qui l’ont causé. **dbslice** résout ce problème en extrayant uniquement les enregistrements dont vous avez besoin, en suivant les relations de clés étrangères pour garantir l’intégrité référentielle.

<p align="center">
  <img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/dbslice-overview.png" alt="dbslice — de la source au sous-ensemble">
</p>

## Démarrage rapide

```bash
# Install globally
uv tool install dbslice   # or: pip install dbslice

# Extract an order and all related records
dbslice extract postgres://localhost/myapp --seed "orders.id=12345" > subset.sql

# Import into local database
psql -d localdb < subset.sql
```

## Fonctionnalités

- **Démarrage sans configuration** -- Introspection automatique du schéma, aucun fichier de modèle de données requis  
- **Commande unique** -- Extraction de sous-ensembles complets de données avec une seule invocation CLI  
- **Sûr par défaut** -- Détection automatique et anonymisation des champs sensibles (emails, téléphones, SSN, etc.)  
- **Profils de conformité** -- Profils intégrés GDPR, HIPAA Safe Harbor et PCI-DSS avec analyse PII en deux phases  
- **Interface de mappage des colonnes** -- Interface locale dans le navigateur pour mapper visuellement les colonnes, appliquer les profils de conformité et exporter la configuration  
- **Formats de sortie multiples** -- SQL, JSON et CSV  
- **Streaming** -- Extraction mémoire-efficace pour grands ensembles de données (plus de 100K lignes)  
- **Clés étrangères virtuelles** -- Support des GenericForeignKeys de Django et des relations implicites via la configuration  
- **Fichiers de configuration** -- Configuration basée sur YAML pour des extractions reproductibles  
- **Validation** -- Vérifie l'intégrité référentielle des données extraites  

### Support des bases de données

| Base de données | Statut                     |
|-----------------|----------------------------|
| PostgreSQL      | Entièrement supporté       |
| MySQL           | Prévu (pas encore implémenté) |
| SQLite          | Prévu (pas encore implémenté) |

## Installation

```bash
# Install with uv (recommended)
uv add dbslice

# Try without installing
uvx dbslice --help

# Or with pip
pip install dbslice
```

## Utilisation

### Extraction de base

```bash
# Extract by primary key
dbslice extract postgres://user:pass@host:5432/db --seed "orders.id=12345"

# Extract with WHERE clause
dbslice extract postgres://localhost/db --seed "orders:status='failed' AND created_at > '2024-01-01'"

# Multiple seeds
dbslice extract postgres://localhost/db \
  --seed "orders.id=100" \
  --seed "orders.id=101"
```

### Parcours de Contrôle

```bash
# Limit depth (default: 3)
dbslice extract postgres://... --seed "orders.id=1" --depth 2

# Direction: up (parents only), down (children only), both (default)
dbslice extract postgres://... --seed "orders.id=1" --direction up
```

### Anonymisation

```bash
# Auto-anonymize detected sensitive fields
dbslice extract postgres://... --seed "users.id=1" --anonymize

# Redact additional fields
dbslice extract postgres://... --seed "users.id=1" --anonymize --redact "audit_logs.ip_address"
```

### Interface de mappage des colonnes

Mappez les colonnes visuellement, appliquez des profils de conformité, et générez une configuration prête à l'emploi — le tout depuis une interface locale dans le navigateur.

```bash
dbslice map postgres://localhost/myapp

# Custom port
dbslice map postgres://localhost/myapp --port 8888

# Also works with uvx (no install needed)
uvx dbslice map postgres://localhost/myapp
```
<table>
<tr>
<td width="50%"><strong>Associer les colonnes aux règles d’anonymisation</strong></td>
<td width="50%"><strong>Générer et exporter la configuration</strong></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/mapping.png" alt="Mapping des colonnes" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/mapping_instructions.png" alt="Configuration générée" width="100%"></td>
</tr>
</table>

S’exécute sur `127.0.0.1:9473` avec un jeton de session unique — aucune donnée ne quitte votre machine. Appliquez les profils GDPR, HIPAA ou PCI-DSS en un clic, vérifiez ce qui est masqué, puis téléchargez le YAML.

### Profils de conformité


```bash
# HIPAA Safe Harbor — auto-masks all 18 identifier types
dbslice extract postgres://... --seed "patients.id=1" --compliance hipaa --compliance-strict

# Multiple profiles + audit manifest
dbslice extract postgres://... --seed "users.id=1" --compliance gdpr --compliance pci-dss -f subset.sql
# Produces subset.sql + subset.manifest.json
```

### Formats de sortie

```bash
# SQL (default)
dbslice extract postgres://... --seed "orders.id=1" --output sql

# JSON fixtures
dbslice extract postgres://... --seed "orders.id=1" --output json --out-file fixtures/

# CSV
dbslice extract postgres://... --seed "orders.id=1" --output csv --out-file data/
```

### Clés étrangères virtuelles

Pour les relations non définies dans le schéma de la base de données (GenericForeignKeys de Django, relations implicites) :

```yaml
# dbslice.yaml
database:
  url: postgres://localhost:5432/myapp

virtual_foreign_keys:
  - source_table: notifications
    source_columns: [object_id]
    target_table: orders
    description: "Generic FK to orders via ContentType"

  - source_table: audit_log
    source_columns: [user_id]
    target_table: users
    description: "Implicit FK without DB constraint"
```

```bash
dbslice extract --config dbslice.yaml --seed "users.id=1"
```

### Inspecter le schéma

```bash
dbslice inspect postgres://localhost/myapp
```

### Fichier de configuration

```bash
# Generate config from database
dbslice init postgres://localhost/myapp --out-file dbslice.yaml

# Use config
dbslice extract --config dbslice.yaml --seed "orders.id=12345"
```

## Comment ça fonctionne

1. **Introspecter** -- Lit le schéma de la base de données pour découvrir les tables et les relations de clés étrangères  
2. **Parcourir** -- À partir d’enregistrements semences, suit les relations FK via BFS  
3. **Extraire** -- Récupère tous les enregistrements identifiés  
4. **Trier** -- Trie topologiquement les tables pour un ordre d’INSERT correct  
5. **Exporter** -- Génère SQL/JSON/CSV avec échappement approprié  

## Comparaison

| Fonctionnalité | dbslice | Jailer | Greenmask | slice-db |  
|----------------|---------|--------|-----------|----------|  
| Langage | Python | Java | Go | Ruby |  
| Configuration | Zéro-config | Nécessite fichier modèle | Configuration requise | YAML manuel |  
| Temps d’installation | Secondes | Heures | Moyen | Moyen |  
| Anonymisation | Intégrée (Faker) | Basée plugin | Transformateurs avancés | Non disponible |  
| Profils de conformité | RGPD, HIPAA, PCI-DSS | Aucun | Aucun | Aucun |  
| Interface mappage colonnes | Intégrée (locale) | Aucune | Aucune | Aucune |  
| Scan valeurs PII | Deux phases (pré/post masque) | Aucun | Aucun | Aucun |  
| Sous-ensemble | Parcours FK | Parcours FK | Limité | Parcours FK |  
| Formats de sortie | SQL, JSON, CSV | SQL, XML, CSV | SQL | SQL seulement |  
| Gestion des cycles | Automatique | Configuration manuelle | N/A | Manuel |  
| Streaming | Intégré | Configurable | Intégré | Non disponible |  
| Maintenance | Active | Active | Active | Non maintenue |  

**dbslice** est l’option Python légère, zéro-config : installez et extrayez en moins d’une minute.  

## Développement

```bash
git clone https://github.com/nabroleonx/dbslice.git
cd dbslice
uv sync --dev
uv run pytest
```

## License

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-19

---