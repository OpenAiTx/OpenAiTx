<p align="center">
  <img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/logo.png" alt="logo de dbslice" width="128">
</p>

# dbslice

[![Versión PyPI](https://img.shields.io/pypi/v/dbslice)](https://pypi.org/project/dbslice/)
[![Licencia: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![Python 3.10+](https://img.shields.io/badge/python-3.10%2B-blue.svg)](https://www.python.org/downloads/)

Extrae subconjuntos mínimos y referencialmente íntegros de bases de datos para desarrollo local y depuración.

## El Problema

Copiar toda una base de datos de producción a tu máquina es inviable. Pero reproducir un error a menudo requiere tener exactamente los datos que lo causaron. **dbslice** resuelve esto extrayendo solo los registros que necesitas, siguiendo las relaciones de claves foráneas para asegurar la integridad referencial.

<p align="center">
  <img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/dbslice-overview.png" alt="dbslice — semilla a subconjunto">
</p>

## Inicio Rápido

```bash
# Install globally
uv tool install dbslice   # or: pip install dbslice

# Extract an order and all related records
dbslice extract postgres://localhost/myapp --seed "orders.id=12345" > subset.sql

# Import into local database
psql -d localdb < subset.sql
```

## Características

- **Inicio sin configuración** -- Introspección automática del esquema, no se requiere archivo de modelo de datos  
- **Comando único** -- Extrae subconjuntos completos de datos con una sola invocación CLI  
- **Seguro por defecto** -- Detecta y anonimiza automáticamente campos sensibles (correos, teléfonos, SSN, etc.)  
- **Perfiles de cumplimiento** -- Perfiles integrados GDPR, HIPAA Safe Harbor y PCI-DSS con escaneo PII en dos fases  
- **Interfaz de asignación de columnas** -- Interfaz local en navegador para mapear columnas visualmente, aplicar perfiles de cumplimiento y exportar configuración  
- **Múltiples formatos de salida** -- SQL, JSON y CSV  
- **Transmisión** -- Extracción eficiente en memoria para conjuntos de datos grandes (más de 100K filas)  
- **Claves foráneas virtuales** -- Soporte para Django GenericForeignKeys y relaciones implícitas vía configuración  
- **Archivos de configuración** -- Configuración basada en YAML para extracciones repetibles  
- **Validación** -- Verifica la integridad referencial de los datos extraídos  

### Soporte de base de datos

| Base de datos | Estado                 |
|---------------|------------------------|
| PostgreSQL    | Totalmente soportado   |
| MySQL         | Planificado (aún no implementado) |
| SQLite        | Planificado (aún no implementado) |

## Instalación

```bash
# Install with uv (recommended)
uv add dbslice

# Try without installing
uvx dbslice --help

# Or with pip
pip install dbslice
```

## Uso

### Extracción Básica

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

### Recorrido de Control

```bash
# Limit depth (default: 3)
dbslice extract postgres://... --seed "orders.id=1" --depth 2

# Direction: up (parents only), down (children only), both (default)
dbslice extract postgres://... --seed "orders.id=1" --direction up
```

### Anonimización

```bash
# Auto-anonymize detected sensitive fields
dbslice extract postgres://... --seed "users.id=1" --anonymize

# Redact additional fields
dbslice extract postgres://... --seed "users.id=1" --anonymize --redact "audit_logs.ip_address"
```

### Interfaz de Mapeo de Columnas

Mapee columnas visualmente, aplique perfiles de cumplimiento y genere una configuración lista para usar, todo desde una interfaz local en el navegador.

```bash
dbslice map postgres://localhost/myapp

# Custom port
dbslice map postgres://localhost/myapp --port 8888

# Also works with uvx (no install needed)
uvx dbslice map postgres://localhost/myapp
```
<table>
<tr>
<td width="50%"><strong>Asignar columnas a reglas de anonimización</strong></td>
<td width="50%"><strong>Generar y exportar configuración</strong></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/mapping.png" alt="Asignación de columnas" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/mapping_instructions.png" alt="Configuración generada" width="100%"></td>
</tr>
</table>

Se ejecuta en `127.0.0.1:9473` con un token de sesión de un solo uso — ningún dato sale de tu máquina. Aplica perfiles GDPR, HIPAA o PCI-DSS con un solo clic, revisa lo que se enmascara y luego descarga el YAML.

### Perfiles de cumplimiento


```bash
# HIPAA Safe Harbor — auto-masks all 18 identifier types
dbslice extract postgres://... --seed "patients.id=1" --compliance hipaa --compliance-strict

# Multiple profiles + audit manifest
dbslice extract postgres://... --seed "users.id=1" --compliance gdpr --compliance pci-dss -f subset.sql
# Produces subset.sql + subset.manifest.json
```

### Formatos de salida

```bash
# SQL (default)
dbslice extract postgres://... --seed "orders.id=1" --output sql

# JSON fixtures
dbslice extract postgres://... --seed "orders.id=1" --output json --out-file fixtures/

# CSV
dbslice extract postgres://... --seed "orders.id=1" --output csv --out-file data/
```

### Claves Foráneas Virtuales

Para relaciones no definidas en el esquema de la base de datos (Django GenericForeignKeys, relaciones implícitas):

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

### Inspeccionar esquema

```bash
dbslice inspect postgres://localhost/myapp
```

### Archivo de Configuración

```bash
# Generate config from database
dbslice init postgres://localhost/myapp --out-file dbslice.yaml

# Use config
dbslice extract --config dbslice.yaml --seed "orders.id=12345"
```
## Cómo Funciona

1. **Introspección** -- Lee el esquema de la base de datos para descubrir tablas y relaciones de claves foráneas
2. **Recorrido** -- Partiendo de registro(s) semilla, sigue relaciones FK mediante BFS
3. **Extracción** -- Obtiene todos los registros identificados
4. **Ordenación** -- Ordena topológicamente las tablas para el orden correcto de INSERT
5. **Salida** -- Genera SQL/JSON/CSV con el escape adecuado

## Comparación

| Característica | dbslice | Jailer | Greenmask | slice-db |
|---------------|---------|--------|-----------|----------|
| Lenguaje | Python | Java | Go | Ruby |
| Configuración | Sin configuración | Requiere archivo de modelo | Requiere configuración | YAML manual |
| Tiempo de instalación | Segundos | Horas | Medio | Medio |
| Anonimización | Integrada (Faker) | Basada en plugins | Transformadores avanzados | No disponible |
| Perfiles de cumplimiento | GDPR, HIPAA, PCI-DSS | Ninguno | Ninguno | Ninguno |
| UI para mapeo de columnas | Integrada (local) | Ninguna | Ninguna | Ninguna |
| Escaneo de valores PII | Dos fases (pre/post máscara) | Ninguno | Ninguno | Ninguno |
| Subconjunto | Recorrido FK | Recorrido FK | Limitado | Recorrido FK |
| Formatos de salida | SQL, JSON, CSV | SQL, XML, CSV | SQL | Solo SQL |
| Manejo de ciclos | Automático | Configuración manual | N/A | Manual |
| Streaming | Integrado | Configurable | Integrado | No disponible |
| Mantenimiento | Activo | Activo | Activo | Sin mantenimiento |

**dbslice** es la opción ligera en Python sin configuración: instala y extrae en menos de un minuto.

## Desarrollo


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