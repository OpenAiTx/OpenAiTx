# 🎯 Project Setup Guide

Welcome to the project! This guide will help you quickly get started by installing the required tools and configuring your local environment.

---

## 🛠️ Prerequisites

Ensure the following tools are installed on your system:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **Recommended Anchor version:** `0.30.1`

---

## ✅ Check Versions & Set Config

Verify that everything is properly installed and configured:

```bash
rustc --version             # Check Rust version
solana --version            # Check Solana CLI version
anchor --version            # Check Anchor version

solana config get           # View current Solana config
solana config set --url devnet  # Set network to devnet
```

---

## 🔐 Wallet Setup

Generate and manage your wallet keys:

```bash
solana-keygen new -o ./keys/admin.json     # Generate a new keypair
solana-keygen pubkey ./keys/admin.json     # Get public key
solana balance ./keys/admin.json           # Check wallet balance
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # Airdrop 5 SOL to your wallet
```

---

## 📦 Project Installation

Clone the project and install dependencies:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```

---

## ⚡ Quick Start

### 🏗️ Build the Program

Compile the Anchor smart contract:

```bash
# Build the Anchor program using nightly toolchain
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# Sync all program public keys
anchor keys sync

# Rebuild if the program address in lib.rs has changed
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---

### 🧪 Test on Devnet

Ensure your `Anchor.toml` uses Devnet:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 Deploy the Program

```bash
anchor deploy
```

---

## 🧪 Use CLI to Interact with the Program

Use these CLI scripts to interact with your smart contract locally.

---

### 🔹 Initialize the Program

```bash
yarn script config
```

Initializes the contract configuration.

---

### 🔹 Create a Round

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>

# Example:
yarn script create -t 60 -d 100000000 -j 100
```

**Parameters:**

- `<ROUND_TIME>`: Duration of the round in seconds (e.g., `60` = 60s).
- `<MIN_DEPOSIT_AMOUNT>`: Minimum deposit in lamports (1 SOL = 1_000_000_000). Must be greater than `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`.
- `<MAX_JOINER_COUNT>`: Maximum number of participants. Must be less than `config.TEST_INITIAL_MAX_JOINER_COUNT`.

---

### 🔹 Join a Round

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# Example:
yarn script join -a 100000000 -g 2
```

**Parameters:**

- `<DEPOSIT_SOL_AMOUNT>`: Deposit amount in lamports (e.g., 0.1 SOL = 100_000_000).
- `<ROUND_NUMBER>`: Index of the round to join. Starts from `0`. Must be less than `total_round`.

> 🕒 Note: The countdown for the round starts when the second participant joins.

---

### 🔹 Select Winner

```bash
yarn script winner -g <ROUND_NUMBER>

# Example:
yarn script winner -g 2
```

**Note:** Only call this after the round time has fully elapsed.

---

### 🔹 Claim Winnings

```bash
yarn script claim -g <ROUND_NUMBER>

# Example:
yarn script claim -g 2
```

**Note:** This must be run by the winning wallet after the winner has been selected.

---

## Contact

For questions or inquiries about Solana smart contract development, DeFi implementation, or DEX integration, please reach out to the project maintainers.

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)
