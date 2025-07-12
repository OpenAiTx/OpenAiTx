# 🎯 Projekt-Setup-Anleitung

Willkommen zum Projekt! Diese Anleitung hilft dir, schnell zu starten, indem du die benötigten Tools installierst und deine lokale Umgebung konfigurierst.

---

## 🛠️ Voraussetzungen

Stelle sicher, dass die folgenden Tools auf deinem System installiert sind:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **Empfohlene Anchor-Version:** `0.30.1`

---

## ✅ Versionen prüfen & Konfiguration setzen

Überprüfe, ob alles korrekt installiert und konfiguriert ist:

```bash
rustc --version             # Rust-Version prüfen
solana --version            # Solana CLI-Version prüfen
anchor --version            # Anchor-Version prüfen

solana config get           # Aktuelle Solana-Konfiguration anzeigen
solana config set --url devnet  # Netzwerk auf devnet setzen
```
---

## 🔐 Wallet-Einrichtung

Generieren und verwalten Sie Ihre Wallet-Schlüssel:

```bash
solana-keygen new -o ./keys/admin.json     # Neues Schlüsselpaar generieren
solana-keygen pubkey ./keys/admin.json     # Öffentlichen Schlüssel abrufen
solana balance ./keys/admin.json           # Wallet-Guthaben überprüfen
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # 5 SOL auf Ihre Wallet airdroppen
```

---

## 📦 Projektinstallation

Klonen Sie das Projekt und installieren Sie die Abhängigkeiten:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ Schnellstart

### 🏗️ Programm bauen

Kompiliere den Anchor Smart Contract:

```bash
# Baue das Anchor-Programm mit dem Nightly-Toolchain
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# Synchronisiere alle öffentlichen Programmschlüssel
anchor keys sync

# Neu bauen, falls sich die Programm-Adresse in lib.rs geändert hat
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Test auf dem Devnet

Stellen Sie sicher, dass Ihre `Anchor.toml` Devnet verwendet:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 Deployment des Programms

```bash
anchor deploy
```

---

## 🧪 Verwendung der CLI zur Interaktion mit dem Programm
Verwenden Sie diese CLI-Skripte, um lokal mit Ihrem Smart Contract zu interagieren.

---

### 🔹 Programm initialisieren

```bash
yarn script config
```

Initialisiert die Konfiguration des Vertrags.

---

### 🔹 Eine Runde erstellen

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>

# Beispiel:
yarn script create -t 60 -d 100000000 -j 100
```

**Parameter:**

- `<ROUND_TIME>`: Dauer der Runde in Sekunden (z.B. `60` = 60s).
- `<MIN_DEPOSIT_AMOUNT>`: Mindest-Einzahlung in Lamports (1 SOL = 1_000_000_000). Muss größer als `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT` sein.
- `<MAX_JOINER_COUNT>`: Maximale Teilnehmeranzahl. Muss kleiner als `config.TEST_INITIAL_MAX_JOINER_COUNT` sein.

---

### 🔹 Einer Runde beitreten

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# Beispiel:
yarn script join -a 100000000 -g 2
```
**Parameter:**

- `<DEPOSIT_SOL_AMOUNT>`: Einzahlungsbetrag in Lamports (z.B. 0,1 SOL = 100_000_000).
- `<ROUND_NUMBER>`: Index der Runde, der beigetreten werden soll. Beginnt bei `0`. Muss kleiner als `total_round` sein.

> 🕒 Hinweis: Der Countdown für die Runde beginnt, wenn der zweite Teilnehmer beitritt.

---

### 🔹 Gewinner auswählen

```bash
yarn script winner -g <ROUND_NUMBER>

# Beispiel:
yarn script winner -g 2
```

**Hinweis:** Dieser Befehl darf erst nach vollständigem Ablauf der Rundenzeit aufgerufen werden.

---
### 🔹 Gewinne einfordern

```bash
yarn script claim -g <RUNDE_NUMMER>

# Beispiel:
yarn script claim -g 2
```

**Hinweis:** Dies muss von der Gewinner-Wallet ausgeführt werden, nachdem der Gewinner ausgewählt wurde.

---

## Kontakt

Für Fragen oder Anfragen bezüglich der Entwicklung von Solana Smart Contracts, DeFi-Implementierung oder DEX-Integration wenden Sie sich bitte an die Projektbetreuer.

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---