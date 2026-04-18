# trading-skills

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
![Python](https://img.shields.io/badge/-Python-3776AB?logo=python&logoColor=white)
![CLI](https://img.shields.io/badge/-CLI-000000?logo=linux&logoColor=white)
![Données Financières](https://img.shields.io/badge/-Donn%C3%A9es%20Financi%C3%A8res-4A90E2?logo=data)

> **CLI complète pour données financières Tushare Pro** | **7+ modules de compétences en trading** | **52+ outils de données** | **Prêt pour la production**

Un projet professionnel de développement de compétences et de formation proposant des outils complets pour la requête de données financières, l’analyse et le développement de stratégies de trading. Construit avec une architecture modulaire de compétences, une implémentation CLI complète et une couverture de tests étendue.

---

## 📋 Fonctionnalités

- **7 Modules de Compétences Spécialisés** : Actions, Futures, Indices, Forex, Alpha, Concepts, Financier
- **52+ Outils de Requête de Données** : Parité complète avec la couverture API de Tushare Pro
- **CLI de Production** : Client en ligne de commande typé avec mise en cache et formats de sortie multiples
- **Tests Complets** : Plus de 992 tests couvrant CLI, cache, configuration et sortie de données
- **Apprentissage Basé sur les Compétences** : Base de connaissances modulaire pour comprendre les concepts de trading et les données
- **Configuration Basée sur Git** : Gestion de configuration via contrôle de version

---

## 📁 Structure du Projet

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

### 2. Configurez votre jeton Tushare

Obtenez votre jeton sur [Tushare Pro](https://tushare.pro/user/token)

```bash
# Option 1: Config file (recommended, persists across sessions)
tushare-cli config set-token YOUR_TOKEN

# Option 2: Environment variable
export TUSHARE_TOKEN=YOUR_TOKEN

# Option 3: Command-line flag
tushare-cli --token YOUR_TOKEN stock daily --ts-code 000001.SZ
```

### 3. Configurer les compétences dans Claude Code (Optionnel)

Si vous souhaitez utiliser les compétences de trading dans Claude Code :

```
/plugin marketplace add oopslink/trading-skills
/plugin install trading-skills@trading-skills
```
Cela installera les 7 modules de compétences en trading, les rendant disponibles comme connaissances de référence dans les conversations Claude Code.

### 4. Essayez votre première requête


```bash
# Get stock daily data
tushare-cli stock daily --ts-code 000001.SZ

# Get in JSON format
tushare-cli stock daily --ts-code 000001.SZ --format json

# Get with caching enabled
tushare-cli --cache stock daily --ts-code 000001.SZ
```

---

## 📚 Catégories d'API

| Catégorie | Compétences | Commandes | Outils de données |
|----------|--------|----------|------------|
| **Actions** | tushare-stock | 8+ commandes | Quotidien, Ajusté, Hebdomadaire, Mensuel, Cotations |
| **Futures** | tushare-futures | 7+ commandes | Quotidien, Continu, Marge |
| **Indice** | tushare-index | 6+ commandes | Quotidien, Hebdomadaire, Constituants |
| **Forex** | tushare-forex | 4+ commandes | Quotidien, OHLC |
| **Alpha** | tushare-alpha | 5+ commandes | Facteurs, Scoring, Backtesting |
| **Concepts** | tushare-concepts | 3+ commandes | Actions Conceptuelles, Mises à jour |
| **Financier** | tushare-financial | 6+ commandes | Revenus, Bilan, Flux de trésorerie, Indicateurs |

---

## 🛠️ Exemples d'utilisation

### Interroger les données boursières

```bash
# Daily prices for a stock
tushare-cli stock daily --ts-code 000001.SZ --start-date 20240101

# Weekly prices
tushare-cli stock weekly --ts-code 000001.SZ

# Stock quotes (real-time equivalent)
tushare-cli stock quotes --ts-code 000001.SZ
```

### Interroger les données futures

```bash
# Futures daily data
tushare-cli futures daily --ts-code IF --trade-date 20240115

# Continuous contract data
tushare-cli futures continuous --ts-code IF --start-date 20240101
```

### Données de l'index de requête

```bash
# Index daily data
tushare-cli index daily --ts-code 000001.SH

# Index constituents
tushare-cli index constituents --ts-code 000001.SH
```

### Formats de sortie

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

Le projet comprend **plus de 992 tests** couvrant :
- Exécution des commandes CLI
- Comportement du cache API
- Gestion de la configuration
- Formatage de la sortie
- Gestion des erreurs

---

## 📖 Documentation des compétences

Chaque compétence de trading est documentée en détail :

- **[tushare-stock](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-stock/SKILL.md)** - Fondamentaux du trading d’actions
- **[tushare-futures](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-futures/SKILL.md)** - Marchés et stratégies à terme
- **[tushare-index](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-index/SKILL.md)** - Analyse des indices
- **[tushare-forex](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-forex/SKILL.md)** - Change de devises
- **[tushare-alpha](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-alpha/SKILL.md)** - Génération d’alpha
- **[tushare-concepts](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-concepts/SKILL.md)** - Concepts de trading
- **[tushare-financial](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-financial/SKILL.md)** - États financiers

---

## 🔧 Configuration

### Configuration des paramètres

```bash
# Set Tushare token
tushare-cli config set-token YOUR_TOKEN

# View current configuration
tushare-cli config show

# Reset to defaults
tushare-cli config reset
```

### Variables d'environnement

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

Avantages :
- Réduit les appels API et les coûts
- Améliore les performances des requêtes
- Respecte les limites de débit

---

## � Intégration Claude Code

### Utilisation en tant que plugin

Ce projet est conçu pour fonctionner parfaitement avec Claude Code en tant que suite complète de plugins de compétences de trading :

```bash
# Step 1: Add the plugin marketplace entry
/plugin marketplace add oopslink/trading-skills

# Step 2: Install the plugin with all skill modules
/plugin install trading-skills@trading-skills
```

**Ce que cela installe :**
- Tous les 7 modules de compétences de trading (actions, contrats à terme, indices, forex, alpha, concepts, finances)
- Base de connaissances complète pour les concepts de trading et l’API Tushare
- Documentation de référence pour chaque catégorie de données
- Intégration avec le système de compétences de Claude Code

### Utilisation des compétences dans Claude Code

Une fois installé, vous pouvez référencer n’importe quelle compétence dans vos conversations Claude Code :

```
@skill tushare-stock     # Stock trading concepts and techniques
@skill tushare-futures   # Futures market knowledge
@skill tushare-index     # Index data and analysis
@skill tushare-forex     # Foreign exchange trading
@skill tushare-alpha     # Alpha factor generation
@skill tushare-concepts  # Financial and trading terminology
@skill tushare-financial # Financial statement analysis
```

### Configuration du développement local

Pour le développement local ou si vous n’utilisez pas la marketplace :

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

## �📋 Conception & Planification

- [Conception du CLI Tushare](https://raw.githubusercontent.com/oopslink/trading-skills/main/docs/plans/2026-03-03-tushare-cli-design.md) - Architecture et conception de l’API
- [Implémentation du CLI Tushare](https://raw.githubusercontent.com/oopslink/trading-skills/main/docs/plans/2026-03-03-tushare-cli-impl.md) - Détails de l’implémentation

---

## 📝 Licence

Licence MIT - voir le fichier [LICENSE](LICENSE) pour les détails

---

## 🤝 Contribution

Les contributions sont les bienvenues ! Veuillez noter :

- Toutes les nouvelles compétences de trading doivent suivre le [format SKILL.md](https://raw.githubusercontent.com/oopslink/trading-skills/main/CLAUDE.md)
- Ajouter des tests pour les nouvelles commandes
- Mettre à jour la documentation si nécessaire
- Respecter les conventions de structure du projet

---

## 📞 Support

- 📖 Consultez la documentation de la compétence pour apprendre les concepts du trading
- 🐛 Signalez les problèmes dans le suivi des issues
- 💬 Discutez des idées dans les discussions

---

**Conçu avec ❤️ pour les passionnés de données financières et les traders**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-18

---