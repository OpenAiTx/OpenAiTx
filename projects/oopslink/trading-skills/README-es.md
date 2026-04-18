# trading-skills

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
![Python](https://img.shields.io/badge/-Python-3776AB?logo=python&logoColor=white)
![CLI](https://img.shields.io/badge/-CLI-000000?logo=linux&logoColor=white)
![Financial Data](https://img.shields.io/badge/-Financial%20Data-4A90E2?logo=data)

> **CLI integral de datos financieros para Tushare Pro** | **7+ módulos de habilidades comerciales** | **52+ herramientas de datos** | **Listo para producción**

Un proyecto profesional para el desarrollo y entrenamiento de habilidades con herramientas completas para consulta de datos financieros, análisis y desarrollo de estrategias de trading. Construido con una arquitectura modular de habilidades, implementación completa de CLI y amplia cobertura de pruebas.

---

## 📋 Características

- **7 Módulos de Habilidades Especializadas**: Acciones, Futuros, Índices, Forex, Alpha, Conceptos, Finanzas
- **52+ Herramientas de Consulta de Datos**: Cobertura completa y equivalente a la API de Tushare Pro
- **CLI para Producción**: Cliente de línea de comandos tipado con caché y múltiples formatos de salida
- **Pruebas Exhaustivas**: Más de 992 pruebas que cubren CLI, caché, configuración y salida de datos
- **Aprendizaje Basado en Habilidades**: Base de conocimiento modular para entender conceptos de trading y datos
- **Configuración Basada en Git**: Gestión de configuración mediante control de versiones

---

## 📁 Estructura del Proyecto

```
trading-skills/
├── skills/                      # Trading skill modules (7 categories)
│   ├── tushare-stock/          # Stock trading fundamentals and techniques
│   ├── tushare-futures/        # Futures contracts and strategies
│   ├── tushare-index/          # Index data and analysis
│   ├── tushare-forex/          # Foreign exchange trading
│   ├── tushare-alpha/          # Alpha factor generation
│   ├── tushare-concepts/       # Key trading and financial concepts
│   └── tushare-financial/      # Financial statement analysis
├── tools/tushare_cli/          # CLI implementation
│   ├── src/                    # Python package
│   │   └── tushare_cli/        # Main CLI code
│   │       ├── commands/       # Command modules by category
│   │       ├── api.py          # Tushare API wrapper
│   │       ├── cache.py        # Response caching layer
│   │       ├── config.py       # Configuration management
│   │       ├── output.py       # Output formatting (JSON, CSV, Table)
│   │       └── main.py         # CLI entry point
│   └── pyproject.toml          # Package configuration
├── tests/                       # Test suite (992+ tests)
│   └── tushare_cli/           # CLI tests
│       ├── test_cache.py       # Cache functionality tests
│       ├── test_commands_*.py  # Command tests by category
│       ├── test_config.py      # Configuration tests
│       ├── test_main.py        # CLI entry point tests
│       └── test_output.py      # Output format tests
└── docs/plans/                 # Design and implementation plans
```

---

## 🚀 Quick Start

### 1. Install the CLI

```bash
# Clone the repository
git clone git@github.com:oopslink/trading-skills.git
cd trading-skills

# Install the CLI in development mode
pip install -e tools/tushare_cli/
```

### 2. Configura Tu Token de Tushare

Obtén tu token en [Tushare Pro](https://tushare.pro/user/token)

```bash
# Option 1: Config file (recommended, persists across sessions)
tushare-cli config set-token YOUR_TOKEN

# Option 2: Environment variable
export TUSHARE_TOKEN=YOUR_TOKEN

# Option 3: Command-line flag
tushare-cli --token YOUR_TOKEN stock daily --ts-code 000001.SZ
```

### 3. Configurar habilidades en Claude Code (Opcional)

Si desea utilizar las habilidades de trading en Claude Code:

```
/plugin marketplace add oopslink/trading-skills
/plugin install trading-skills@trading-skills
```

Esto instalará los 7 módulos de habilidades comerciales, haciéndolos disponibles como conocimiento de referencia en las conversaciones de Claude Code.

### 4. Prueba tu primera consulta

```bash
# Get stock daily data
tushare-cli stock daily --ts-code 000001.SZ

# Get in JSON format
tushare-cli stock daily --ts-code 000001.SZ --format json

# Get with caching enabled
tushare-cli --cache stock daily --ts-code 000001.SZ
```

---

## 📚 Categorías de API

| Categoría | Habilidades | Comandos | Herramientas de Datos |
|----------|--------|----------|------------|
| **Acciones** | tushare-stock | Más de 8 comandos | Diario, Ajustado, Semanal, Mensual, Cotizaciones |
| **Futuros** | tushare-futures | Más de 7 comandos | Diario, Continuo, Margen |
| **Índice** | tushare-index | Más de 6 comandos | Diario, Semanal, Componentes |
| **Forex** | tushare-forex | Más de 4 comandos | Diario, OHLC |
| **Alpha** | tushare-alpha | Más de 5 comandos | Factores, Puntuación, Backtesting |
| **Conceptos** | tushare-concepts | Más de 3 comandos | Acciones Conceptuales, Actualizaciones |
| **Financiero** | tushare-financial | Más de 6 comandos | Ingresos, Balance, Flujo de Caja, Indicadores |

---

## 🛠️ Ejemplos de Uso

### Consultar Datos de Acciones

```bash
# Daily prices for a stock
tushare-cli stock daily --ts-code 000001.SZ --start-date 20240101

# Weekly prices
tushare-cli stock weekly --ts-code 000001.SZ

# Stock quotes (real-time equivalent)
tushare-cli stock quotes --ts-code 000001.SZ
```

### Consultar datos de Futuros

```bash
# Futures daily data
tushare-cli futures daily --ts-code IF --trade-date 20240115

# Continuous contract data
tushare-cli futures continuous --ts-code IF --start-date 20240101
```

### Datos del Índice de Consulta

```bash
# Index daily data
tushare-cli index daily --ts-code 000001.SH

# Index constituents
tushare-cli index constituents --ts-code 000001.SH
```

### Formatos de salida

```bash
# Table format (default)
tushare-cli stock daily --ts-code 000001.SZ

# JSON format
tushare-cli stock daily --ts-code 000001.SZ --format json

# CSV format
tushare-cli stock daily --ts-code 000001.SZ --format csv
```

---

## 🧪 Testing

Run the comprehensive test suite:

```bash
# Run all tests
pytest tests/

# Run tests with coverage
pytest tests/ --cov=tools/tushare_cli/src/tushare_cli

# Run specific test file
pytest tests/tushare_cli/test_commands_stock.py

# Run with verbose output
pytest tests/ -v
```
El proyecto incluye **más de 992 pruebas** que cubren:
- Ejecución de comandos CLI
- Comportamiento del caché de la API
- Gestión de configuración
- Formato de salida
- Manejo de errores

---

## 📖 Documentación de Habilidades

Cada habilidad de trading está documentada en detalle:

- **[tushare-stock](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-stock/SKILL.md)** - Fundamentos del trading de acciones
- **[tushare-futures](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-futures/SKILL.md)** - Mercados y estrategias de futuros
- **[tushare-index](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-index/SKILL.md)** - Análisis de índices
- **[tushare-forex](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-forex/SKILL.md)** - Divisas extranjeras
- **[tushare-alpha](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-alpha/SKILL.md)** - Generación de alfa
- **[tushare-concepts](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-concepts/SKILL.md)** - Conceptos de trading
- **[tushare-financial](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-financial/SKILL.md)** - Estados financieros

---

## 🔧 Configuración

### Configuración de Ajustes


```bash
# Set Tushare token
tushare-cli config set-token YOUR_TOKEN

# View current configuration
tushare-cli config show

# Reset to defaults
tushare-cli config reset
```

### Variables de Entorno

```bash
TUSHARE_TOKEN=your_token_here
TUSHARE_CACHE_ENABLED=true
TUSHARE_CACHE_TTL=3600
```

---

## 💾 Caching

The CLI includes intelligent response caching:

```bash
# Enable cache (cache TTL: 3600 seconds by default)
tushare-cli --cache stock daily --ts-code 000001.SZ

# Clear cache
tushare-cli cache clear

# Check cache status
tushare-cli cache status
```

Beneficios:
- Reduce llamadas a la API y costos
- Mejora el rendimiento de las consultas
- Respeta los límites de tasa

---

## � Integración con Claude Code

### Uso como Plugin

Este proyecto está diseñado para funcionar perfectamente con Claude Code como un conjunto completo de plugins de habilidades de trading:

```bash
# Step 1: Add the plugin marketplace entry
/plugin marketplace add oopslink/trading-skills

# Step 2: Install the plugin with all skill modules
/plugin install trading-skills@trading-skills
```

**Qué instala esto:**
- Todos los 7 módulos de habilidades de trading (acciones, futuros, índices, forex, alfa, conceptos, financiero)
- Base de conocimientos completa sobre conceptos de trading y API de Tushare
- Documentación de referencia para cada categoría de datos
- Integración con el sistema de habilidades de Claude Code

### Uso de habilidades en Claude Code

Una vez instalado, puedes referenciar cualquier habilidad en tus conversaciones de Claude Code:

```
@skill tushare-stock     # Stock trading concepts and techniques
@skill tushare-futures   # Futures market knowledge
@skill tushare-index     # Index data and analysis
@skill tushare-forex     # Foreign exchange trading
@skill tushare-alpha     # Alpha factor generation
@skill tushare-concepts  # Financial and trading terminology
@skill tushare-financial # Financial statement analysis
```

### Configuración para Desarrollo Local

Para desarrollo local o si no se utiliza el marketplace:

```bash
# Clone the repository
git clone https://github.com/oopslink/trading-skills.git
cd trading-skills

# Install CLI tools
pip install -e tools/tushare_cli/

# Skills are automatically available in the project
# Reference them via: @skill tushare-<category>
```

---

## �📋 Diseño y Planificación

- [Diseño CLI de Tushare](https://raw.githubusercontent.com/oopslink/trading-skills/main/docs/plans/2026-03-03-tushare-cli-design.md) - Arquitectura y diseño de API
- [Implementación CLI de Tushare](https://raw.githubusercontent.com/oopslink/trading-skills/main/docs/plans/2026-03-03-tushare-cli-impl.md) - Detalles de implementación

---

## 📝 Licencia

Licencia MIT - vea el archivo [LICENSE](LICENSE) para más detalles

---

## 🤝 Contribuciones

¡Las contribuciones son bienvenidas! Por favor tenga en cuenta:

- Todas las nuevas habilidades de trading deben seguir el [formato SKILL.md](https://raw.githubusercontent.com/oopslink/trading-skills/main/CLAUDE.md)
- Añadir pruebas para los nuevos comandos
- Actualizar la documentación según sea necesario
- Seguir las convenciones de estructura del proyecto

---

## 📞 Soporte

- 📖 Consulte la documentación de la habilidad para aprender sobre conceptos de trading
- 🐛 Reporte problemas en el rastreador de incidencias
- 💬 Discuta ideas en las discusiones

---

**Construido con ❤️ para entusiastas y traders de datos financieros**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-18

---