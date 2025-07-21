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

# Argon - Máquina del Tiempo para MongoDB 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**Viaja en el tiempo dentro de tu base de datos MongoDB. Ramifica, restaura y experimenta sin miedo.**

## ¿Qué es Argon?

Argon dota a MongoDB de superpoderes con **ramificación tipo Git** y **viaje en el tiempo**. Crea ramas de bases de datos al instante, restaura a cualquier punto en la historia y nunca pierdas datos de nuevo.

### 🎯 Beneficios Clave

- **⚡ Ramas Instantáneas** - Clona toda tu base de datos en 1 ms (no horas)
- **⏰ Viaje en el Tiempo** - Consulta tus datos de cualquier punto en la historia con **220,000+ consultas/seg**
- **🔄 Restauración Segura** - Previsualiza los cambios antes de restaurar
- **💾 Costo de Almacenamiento Cero** - Las ramas comparten datos eficientemente con un 90% de compresión
- **🔌 Compatible Plug-and-Play** - Funciona con tu código MongoDB existente
- **🚀 Rendimiento Empresarial** - Consultas de viaje en el tiempo 26x más rápidas tras las últimas optimizaciones
- **✅ Pruebas Exhaustivas** - Amplia cobertura de pruebas que garantiza fiabilidad
- **🗜️ Compresión Inteligente** - Compresión automática de WAL reduce almacenamiento en 80-90%

## Demostración Rápida

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
## Flujo de trabajo tipo Git para MongoDB

### 🔄 **Paso 1: Importar ("git clone" para bases de datos)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **Paso 2: Rama ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **Paso 3: Viaje en el tiempo ("git log" para datos)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **Paso 4: Restaurar ("git reset" para desastres)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## Cómo funciona

Argon intercepta las operaciones de MongoDB y las registra en un **Registro de Escritura Anticipada (WAL)**, lo que permite:
- Ramificación instantánea mediante punteros de metadatos
- Viaje en el tiempo reproduciendo operaciones
- Eficiencia sin copias adicionales

Tu código MongoDB existente funciona sin cambios: solo agrega `ENABLE_WAL=true`.

## Instalación


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## Documentación

- 📖 [Guía de inicio rápido](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [Referencia de API](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [Casos de uso](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Arquitectura](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Comunidad

- 🤝 [Guía de la comunidad](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - ¡Involúcrate!
- 📋 [Hoja de ruta](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - Descubre lo que viene
- 🐛 [Reportar problemas](https://github.com/argon-lab/argon/issues)
- 💬 [Discusiones](https://github.com/argon-lab/argon/discussions)
- 🏗️ [Contribuir](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - Ayuda a construir Argon
- 📧 [Contacto](https://www.argonlabs.tech)

---

<div align="center">

**Dale a tu MongoDB una máquina del tiempo. Nunca pierdas datos de nuevo.**

⭐ **Danos una estrella** si Argon te salva el día.

[Comienza ahora →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Demo en vivo →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---