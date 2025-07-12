# 🎯 Руководство по настройке проекта

Добро пожаловать в проект! Это руководство поможет вам быстро начать работу, установив необходимые инструменты и настроив локальную среду.

---

## 🛠️ Необходимые условия

Убедитесь, что на вашей системе установлены следующие инструменты:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **Рекомендуемая версия Anchor:** `0.30.1`

---

## ✅ Проверка версий и настройка конфигурации

Убедитесь, что всё установлено и настроено правильно:

```bash
rustc --version             # Проверить версию Rust
solana --version            # Проверить версию Solana CLI
anchor --version            # Проверить версию Anchor

solana config get           # Просмотреть текущую конфигурацию Solana
solana config set --url devnet  # Установить сеть на devnet
```
---

## 🔐 Настройка кошелька

Генерация и управление ключами кошелька:

```bash
solana-keygen new -o ./keys/admin.json     # Сгенерировать новую пару ключей
solana-keygen pubkey ./keys/admin.json     # Получить публичный ключ
solana balance ./keys/admin.json           # Проверить баланс кошелька
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # Отправить 5 SOL на ваш кошелек
```

---

## 📦 Установка проекта

Клонируйте проект и установите зависимости:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ Быстрый старт

### 🏗️ Сборка программы

Скомпилируйте смарт-контракт Anchor:

```bash
# Соберите программу Anchor с использованием nightly toolchain
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# Синхронизируйте все публичные ключи программы
anchor keys sync

# Пересоберите, если адрес программы в lib.rs был изменён
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Тестирование на Devnet

Убедитесь, что в вашем файле `Anchor.toml` используется Devnet:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 Развертывание программы

```bash
anchor deploy
```

---

## 🧪 Использование CLI для взаимодействия с программой
Используйте эти CLI-скрипты для взаимодействия с вашим смарт-контрактом локально.

---

### 🔹 Инициализация программы

```bash
yarn script config
```

Инициализирует конфигурацию контракта.

---

### 🔹 Создание раунда

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>
```
# Пример:
yarn script create -t 60 -d 100000000 -j 100
```

**Параметры:**

- `<ROUND_TIME>`: Длительность раунда в секундах (например, `60` = 60 сек).
- `<MIN_DEPOSIT_AMOUNT>`: Минимальный депозит в лампортах (1 SOL = 1_000_000_000). Должен быть больше, чем `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`.
- `<MAX_JOINER_COUNT>`: Максимальное количество участников. Должно быть меньше, чем `config.TEST_INITIAL_MAX_JOINER_COUNT`.

---

### 🔹 Присоединиться к раунду

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# Пример:
yarn script join -a 100000000 -g 2
```
**Параметры:**

- `<DEPOSIT_SOL_AMOUNT>`: Сумма депозита в лампортах (например, 0.1 SOL = 100_000_000).
- `<ROUND_NUMBER>`: Индекс раунда для участия. Начинается с `0`. Должен быть меньше, чем `total_round`.

> 🕒 Примечание: Отсчет времени для раунда начинается, когда присоединяется второй участник.

---

### 🔹 Выбор победителя

```bash
yarn script winner -g <ROUND_NUMBER>

# Пример:
yarn script winner -g 2
```

**Примечание:** Вызывайте это только после того, как время раунда полностью истечет.

---
### 🔹 Получение выигрыша

```bash
yarn script claim -g <ROUND_NUMBER>

# Пример:
yarn script claim -g 2
```

**Примечание:** Эту команду должен запускать выигравший кошелёк после выбора победителя.

---

## Контакты

По вопросам разработки смарт-контрактов Solana, внедрения DeFi или интеграции DEX, пожалуйста, обращайтесь к сопровождающим проект.

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---