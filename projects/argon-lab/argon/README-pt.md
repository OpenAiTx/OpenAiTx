<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Argon - Máquina do Tempo para MongoDB 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**Viaje no tempo no seu banco de dados MongoDB. Ramifique, restaure e experimente sem medo.**

## O que é o Argon?

Argon dá superpoderes ao MongoDB com **ramificação ao estilo Git** e **viagem no tempo**. Crie ramificações instantâneas do banco de dados, restaure para qualquer ponto da história e nunca mais perca dados.

### 🎯 Benefícios Principais

- **⚡ Ramificações Instantâneas** - Clone seu banco de dados inteiro em 1ms (não horas)
- **⏰ Viagem no Tempo** - Consulte seus dados de qualquer ponto da história com **220.000+ consultas/seg**
- **🔄 Restauração Segura** - Visualize as alterações antes de restaurar
- **💾 Custo Zero de Armazenamento** - Ramificações compartilham dados com eficiência e 90% de compressão
- **🔌 Compatível Plug-and-Play** - Funciona com código MongoDB existente
- **🚀 Performance Empresarial** - Consultas de viagem no tempo 26x mais rápidas após as últimas otimizações
- **✅ Testes Abrangentes** - Cobertura extensiva de testes garantindo confiabilidade
- **🗜️ Compressão Inteligente** - Compressão automática de WAL reduz armazenamento em 80-90%

## Demonstração Rápida

```bash
# Install
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Cross-platform

# Step 1: Import your existing MongoDB (like "git clone")
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your data now has time travel capabilities!

# Step 2: Use Argon like Git for your database
argon branches create test-env           # Branch like "git checkout -b"
argon time-travel query --project myapp --branch main --lsn 1000

# Step 3: Disaster recovery made simple
argon restore preview --time "1 hour ago"
argon restore reset --time "before disaster"
```
## Fluxo de Trabalho Estilo Git para MongoDB

### 🔄 **Etapa 1: Importar ("git clone" para bancos de dados)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **Etapa 2: Ramificação ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **Etapa 3: Viagem no Tempo ("git log" para dados)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **Etapa 4: Restaurar ("git reset" para desastres)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## Como Funciona

O Argon intercepta operações do MongoDB e as registra em um **Write-Ahead Log (WAL)**, permitindo:
- Ramificação instantânea via ponteiros de metadados
- Viagem no tempo ao reproduzir operações
- Eficiência sem cópia

Seu código MongoDB existente funciona sem alterações - basta adicionar `ENABLE_WAL=true`.

## Instalação


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## Documentação

- 📖 [Guia de Início Rápido](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [Referência da API](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [Casos de Uso](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Arquitetura](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Comunidade

- 🤝 [Guia da Comunidade](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - Participe!
- 📋 [Roteiro](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - Veja o que vem por aí
- 🐛 [Relatar Problemas](https://github.com/argon-lab/argon/issues)
- 💬 [Discussões](https://github.com/argon-lab/argon/discussions)
- 🏗️ [Contribuindo](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - Ajude a construir o Argon
- 📧 [Contato](https://www.argonlabs.tech)

---

<div align="center">

**Dê uma máquina do tempo ao seu MongoDB. Nunca mais perca dados.**

⭐ **Dê uma estrela** se o Argon salvou seu dia!

[Comece Agora →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Demo ao Vivo →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---