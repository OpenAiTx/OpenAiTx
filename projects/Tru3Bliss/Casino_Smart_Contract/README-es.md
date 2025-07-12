# 🎯 Guía de Configuración del Proyecto

¡Bienvenido al proyecto! Esta guía te ayudará a comenzar rápidamente instalando las herramientas requeridas y configurando tu entorno local.

---

## 🛠️ Requisitos Previos

Asegúrate de tener instaladas las siguientes herramientas en tu sistema:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **Versión recomendada de Anchor:** `0.30.1`

---

## ✅ Verificar Versiones y Configurar

Verifica que todo esté instalado y configurado correctamente:

```bash
rustc --version             # Verificar versión de Rust
solana --version            # Verificar versión de Solana CLI
anchor --version            # Verificar versión de Anchor

solana config get           # Ver verificación de configuración actual de Solana
solana config set --url devnet  # Configurar la red a devnet
```
---

## 🔐 Configuración de la Wallet

Genera y administra las claves de tu wallet:

```bash
solana-keygen new -o ./keys/admin.json     # Generar un nuevo par de claves
solana-keygen pubkey ./keys/admin.json     # Obtener la clave pública
solana balance ./keys/admin.json           # Consultar el saldo de la wallet
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # Airdrop de 5 SOL a tu wallet
```

---

## 📦 Instalación del Proyecto

Clona el proyecto e instala las dependencias:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ Inicio Rápido

### 🏗️ Compilar el Programa

Compila el contrato inteligente de Anchor:

```bash
# Compilar el programa de Anchor usando la toolchain nightly
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# Sincronizar todas las claves públicas del programa
anchor keys sync

# Volver a compilar si la dirección del programa en lib.rs ha cambiado
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Prueba en Devnet

Asegúrate de que tu `Anchor.toml` use Devnet:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 Despliega el Programa

```bash
anchor deploy
```

---

## 🧪 Usa la CLI para Interactuar con el Programa
Utiliza estos scripts CLI para interactuar con tu contrato inteligente localmente.

---

### 🔹 Inicializar el Programa

```bash
yarn script config
```

Inicializa la configuración del contrato.

---

### 🔹 Crear una Ronda

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>

# Ejemplo:
yarn script create -t 60 -d 100000000 -j 100
```

**Parámetros:**

- `<ROUND_TIME>`: Duración de la ronda en segundos (por ejemplo, `60` = 60s).
- `<MIN_DEPOSIT_AMOUNT>`: Depósito mínimo en lamports (1 SOL = 1_000_000_000). Debe ser mayor que `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`.
- `<MAX_JOINER_COUNT>`: Número máximo de participantes. Debe ser menor que `config.TEST_INITIAL_MAX_JOINER_COUNT`.

---

### 🔹 Unirse a una ronda

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# Ejemplo:
yarn script join -a 100000000 -g 2
```
**Parámetros:**

- `<DEPOSIT_SOL_AMOUNT>`: Monto del depósito en lamports (por ejemplo, 0.1 SOL = 100_000_000).
- `<ROUND_NUMBER>`: Índice de la ronda a la que unirse. Comienza desde `0`. Debe ser menor que `total_round`.

> 🕒 Nota: La cuenta regresiva para la ronda comienza cuando el segundo participante se une.

---

### 🔹 Seleccionar Ganador

```bash
yarn script winner -g <ROUND_NUMBER>

# Ejemplo:
yarn script winner -g 2
```

**Nota:** Solo ejecuta esto después de que el tiempo de la ronda haya transcurrido completamente.

---
### 🔹 Reclamar Ganancias

```bash
yarn script claim -g <ROUND_NUMBER>

# Ejemplo:
yarn script claim -g 2
```

**Nota:** Esto debe ser ejecutado por la wallet ganadora después de que el ganador haya sido seleccionado.

---

## Contacto

Para preguntas o consultas sobre desarrollo de contratos inteligentes en Solana, implementación DeFi o integración DEX, por favor contacte a los mantenedores del proyecto.

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---