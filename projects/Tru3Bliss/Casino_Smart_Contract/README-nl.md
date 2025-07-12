# 🎯 Project Setup Gids

Welkom bij het project! Deze gids helpt je snel op weg door de vereiste tools te installeren en je lokale omgeving te configureren.

---

## 🛠️ Vereisten

Zorg ervoor dat de volgende tools op je systeem zijn geïnstalleerd:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **Aanbevolen Anchor-versie:** `0.30.1`

---

## ✅ Controleer Versies & Stel Configuratie In

Controleer of alles correct is geïnstalleerd en geconfigureerd:

```bash
rustc --version             # Controleer Rust-versie
solana --version            # Controleer Solana CLI-versie
anchor --version            # Controleer Anchor-versie

solana config get           # Bekijk huidige Solana-configuratie
solana config set --url devnet  # Stel netwerk in op devnet
```
---

## 🔐 Walletconfiguratie

Genereer en beheer je wallet-sleutels:

```bash
solana-keygen new -o ./keys/admin.json     # Genereer een nieuw sleutelpaartje
solana-keygen pubkey ./keys/admin.json     # Haal publieke sleutel op
solana balance ./keys/admin.json           # Controleer wallet-saldo
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # Airdrop 5 SOL naar je wallet
```

---

## 📦 Projectinstallatie

Clone het project en installeer afhankelijkheden:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ Snelstart

### 🏗️ Bouw het Programma

Compileer het Anchor smart contract:

```bash
# Bouw het Anchor-programma met behulp van de nightly toolchain
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# Synchroniseer alle publieke programmatoetsen
anchor keys sync

# Herbouw als het programmamadres in lib.rs is gewijzigd
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Test op Devnet

Zorg ervoor dat je `Anchor.toml` Devnet gebruikt:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 Deploy het Programma

```bash
anchor deploy
```

---

## 🧪 Gebruik CLI om met het Programma te Interageren
Gebruik deze CLI-scripts om lokaal met je smart contract te communiceren.

---

### 🔹 Initialiseer het Programma

```bash
yarn script config
```

Initialiseert de contractconfiguratie.

---

### 🔹 Maak een Ronde aan

```bash
yarn script create -t <RONDE_TIJD> -d <MINIMAAL_STORTINGSBEDRAG> -j <MAXIMUM_AANTAL_DEELNEMERS>

# Voorbeeld:
yarn script create -t 60 -d 100000000 -j 100
```

**Parameters:**

- `<ROUND_TIME>`: Duur van de ronde in seconden (bijv. `60` = 60s).
- `<MIN_DEPOSIT_AMOUNT>`: Minimale storting in lamports (1 SOL = 1_000_000_000). Moet groter zijn dan `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`.
- `<MAX_JOINER_COUNT>`: Maximale aantal deelnemers. Moet minder zijn dan `config.TEST_INITIAL_MAX_JOINER_COUNT`.

---

### 🔹 Meedoen aan een ronde

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# Voorbeeld:
yarn script join -a 100000000 -g 2
```
**Parameters:**

- `<DEPOSIT_SOL_AMOUNT>`: Stortingsbedrag in lamports (bijv. 0,1 SOL = 100_000_000).
- `<ROUND_NUMBER>`: Index van de ronde om aan deel te nemen. Begint bij `0`. Moet minder zijn dan `total_round`.

> 🕒 Opmerking: De aftelling voor de ronde begint wanneer de tweede deelnemer zich aansluit.

---

### 🔹 Selecteer Winnaar

```bash
yarn script winner -g <ROUND_NUMBER>

# Voorbeeld:
yarn script winner -g 2
```

**Opmerking:** Roep dit alleen aan nadat de tijd van de ronde volledig is verstreken.

---
### 🔹 Winst Opeisen

```bash
yarn script claim -g <RONDE_NUMMER>

# Voorbeeld:
yarn script claim -g 2
```

**Opmerking:** Dit moet uitgevoerd worden door de winnende wallet nadat de winnaar is geselecteerd.

---

## Contact

Voor vragen of verzoeken over Solana smart contract ontwikkeling, DeFi implementatie of DEX integratie, neem contact op met de projectbeheerders.

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---