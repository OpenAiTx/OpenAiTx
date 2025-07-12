# 🎯 Przewodnik po konfiguracji projektu

Witamy w projekcie! Ten przewodnik pomoże Ci szybko rozpocząć pracę poprzez instalację wymaganych narzędzi i konfigurację lokalnego środowiska.

---

## 🛠️ Wymagania wstępne

Upewnij się, że na Twoim systemie są zainstalowane następujące narzędzia:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **Zalecana wersja Anchor:** `0.30.1`

---

## ✅ Sprawdź wersje i ustaw konfigurację

Zweryfikuj, czy wszystko jest poprawnie zainstalowane i skonfigurowane:

```bash
rustc --version             # Sprawdź wersję Rust
solana --version            # Sprawdź wersję Solana CLI
anchor --version            # Sprawdź wersję Anchor

solana config get           # Wyświetl obecną konfigurację Solana
solana config set --url devnet  # Ustaw sieć na devnet
```
---

## 🔐 Konfiguracja portfela

Generowanie i zarządzanie kluczami portfela:

```bash
solana-keygen new -o ./keys/admin.json     # Wygeneruj nową parę kluczy
solana-keygen pubkey ./keys/admin.json     # Pobierz klucz publiczny
solana balance ./keys/admin.json           # Sprawdź saldo portfela
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # Prześlij 5 SOL na swój portfel
```

---

## 📦 Instalacja projektu

Sklonuj projekt i zainstaluj zależności:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ Szybki start

### 🏗️ Budowanie programu

Skompiluj smart kontrakt Anchor:

```bash
# Zbuduj program Anchor używając toolchainu nightly
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# Synchronizuj wszystkie publiczne klucze programów
anchor keys sync

# Przebuduj, jeśli adres programu w pliku lib.rs został zmieniony
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Testowanie na Devnecie

Upewnij się, że Twój plik `Anchor.toml` używa Devnetu:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 Wdrażanie Programu

```bash
anchor deploy
```

---

## 🧪 Użycie CLI do interakcji z programem
Użyj tych skryptów CLI, aby wchodzić w interakcję ze swoim smart kontraktem lokalnie.

---

### 🔹 Inicjalizuj Program

```bash
yarn script config
```

Inicjalizuje konfigurację kontraktu.

---

### 🔹 Utwórz Rundę

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>

# Przykład:
yarn script create -t 60 -d 100000000 -j 100
```

**Parametry:**

- `<ROUND_TIME>`: Czas trwania rundy w sekundach (np. `60` = 60s).
- `<MIN_DEPOSIT_AMOUNT>`: Minimalna wpłata w lamportach (1 SOL = 1_000_000_000). Musi być większa niż `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`.
- `<MAX_JOINER_COUNT>`: Maksymalna liczba uczestników. Musi być mniejsza niż `config.TEST_INITIAL_MAX_JOINER_COUNT`.

---

### 🔹 Dołącz do Rundy

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# Przykład:
yarn script join -a 100000000 -g 2
```
**Parametry:**

- `<DEPOSIT_SOL_AMOUNT>`: Kwota depozytu w lamportach (np. 0.1 SOL = 100_000_000).
- `<ROUND_NUMBER>`: Indeks rundy do dołączenia. Zaczyna się od `0`. Musi być mniejszy niż `total_round`.

> 🕒 Uwaga: Odliczanie czasu rundy zaczyna się, gdy dołączy drugi uczestnik.

---

### 🔹 Wybierz zwycięzcę

```bash
yarn script winner -g <ROUND_NUMBER>

# Przykład:
yarn script winner -g 2
```

**Uwaga:** Wywołaj to polecenie tylko po pełnym upływie czasu rundy.

---
### 🔹 Odbierz wygraną

```bash
yarn script claim -g <NUMER_RUNDY>

# Przykład:
yarn script claim -g 2
```

**Uwaga:** To polecenie musi zostać uruchomione przez zwycięski portfel po wybraniu zwycięzcy.

---

## Kontakt

W przypadku pytań dotyczących tworzenia smart kontraktów na Solanie, wdrażania DeFi lub integracji z DEX, prosimy o kontakt z opiekunami projektu.

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---