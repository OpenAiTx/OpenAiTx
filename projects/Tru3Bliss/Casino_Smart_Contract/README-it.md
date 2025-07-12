# 🎯 Guida all'Installazione del Progetto

Benvenuto nel progetto! Questa guida ti aiuterà a iniziare rapidamente installando gli strumenti necessari e configurando il tuo ambiente locale.

---

## 🛠️ Prerequisiti

Assicurati che i seguenti strumenti siano installati sul tuo sistema:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **Versione Anchor consigliata:** `0.30.1`

---

## ✅ Verifica Versioni & Configurazione

Verifica che tutto sia correttamente installato e configurato:

```bash
rustc --version             # Controlla la versione di Rust
solana --version            # Controlla la versione di Solana CLI
anchor --version            # Controlla la versione di Anchor

solana config get           # Visualizza la configurazione attuale di Solana
solana config set --url devnet  # Imposta la rete su devnet
```
---

## 🔐 Configurazione del Wallet

Genera e gestisci le chiavi del tuo wallet:

```bash
solana-keygen new -o ./keys/admin.json     # Genera una nuova coppia di chiavi
solana-keygen pubkey ./keys/admin.json     # Ottieni la chiave pubblica
solana balance ./keys/admin.json           # Controlla il saldo del wallet
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # Ricevi un airdrop di 5 SOL nel tuo wallet
```

---

## 📦 Installazione del Progetto

Clona il progetto e installa le dipendenze:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ Avvio Rapido

### 🏗️ Compilare il Programma

Compila lo smart contract Anchor:

```bash
# Compila il programma Anchor utilizzando il toolchain nightly
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# Sincronizza tutte le chiavi pubbliche del programma
anchor keys sync

# Ricompila se l'indirizzo del programma in lib.rs è cambiato
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Test su Devnet

Assicurati che il tuo `Anchor.toml` utilizzi Devnet:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 Effettua il Deploy del Programma

```bash
anchor deploy
```

---

## 🧪 Usa la CLI per Interagire con il Programma
Usa questi script CLI per interagire localmente con il tuo smart contract.

---

### 🔹 Inizializza il Programma

```bash
yarn script config
```

Inizializza la configurazione del contratto.

---

### 🔹 Crea un Round

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>

# Esempio:
yarn script create -t 60 -d 100000000 -j 100
```

**Parametri:**

- `<ROUND_TIME>`: Durata del round in secondi (ad es., `60` = 60s).
- `<MIN_DEPOSIT_AMOUNT>`: Deposito minimo in lamport (1 SOL = 1_000_000_000). Deve essere maggiore di `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`.
- `<MAX_JOINER_COUNT>`: Numero massimo di partecipanti. Deve essere inferiore a `config.TEST_INITIAL_MAX_JOINER_COUNT`.

---

### 🔹 Unirsi a un Round

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# Esempio:
yarn script join -a 100000000 -g 2
```
**Parametri:**

- `<DEPOSIT_SOL_AMOUNT>`: Importo del deposito in lamport (ad esempio, 0.1 SOL = 100_000_000).
- `<ROUND_NUMBER>`: Indice del round a cui partecipare. Parte da `0`. Deve essere inferiore a `total_round`.

> 🕒 Nota: Il conto alla rovescia per il round inizia quando si unisce il secondo partecipante.

---

### 🔹 Seleziona Vincitore

```bash
yarn script winner -g <ROUND_NUMBER>

# Esempio:
yarn script winner -g 2
```

**Nota:** Eseguire questa chiamata solo dopo che il tempo del round è completamente trascorso.

---
### 🔹 Richiedi le vincite

```bash
yarn script claim -g <NUMERO_ROUND>

# Esempio:
yarn script claim -g 2
```

**Nota:** Questo comando deve essere eseguito dal wallet vincente dopo che il vincitore è stato selezionato.

---

## Contatti

Per domande o richieste riguardanti lo sviluppo di smart contract su Solana, l'implementazione DeFi o l'integrazione DEX, si prega di contattare i manutentori del progetto.

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---