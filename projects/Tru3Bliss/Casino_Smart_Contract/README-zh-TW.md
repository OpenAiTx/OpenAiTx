# 🎯 專案設定指南

歡迎加入本專案！本指南將協助你快速開始，安裝所需工具並配置你的本地環境。

---

## 🛠️ 先決條件

請確保你的系統已安裝以下工具：

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **建議 Anchor 版本：** `0.30.1`

---

## ✅ 檢查版本與設置配置

確認所有工具已正確安裝並配置：

```bash
rustc --version             # 檢查 Rust 版本
solana --version            # 檢查 Solana CLI 版本
anchor --version            # 檢查 Anchor 版本

solana config get           # 檢視目前 Solana 配置
solana config set --url devnet  # 將網路設為 devnet
```
---

## 🔐 錢包設定

產生並管理您的錢包金鑰：

```bash
solana-keygen new -o ./keys/admin.json     # 產生新的金鑰對
solana-keygen pubkey ./keys/admin.json     # 取得公開金鑰
solana balance ./keys/admin.json           # 查詢錢包餘額
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # 向您的錢包空投 5 SOL
```

---

## 📦 專案安裝

複製專案並安裝相依套件：

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ 快速開始

### 🏗️ 建置程式

編譯 Anchor 智能合約：

```bash
# 使用 nightly 工具鏈建置 Anchor 程式
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# 同步所有程式公鑰
anchor keys sync

# 如果 lib.rs 中的程式地址有變更，請重新建置
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 在 Devnet 上測試

確保你的 `Anchor.toml` 使用 Devnet：

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 部署程式

```bash
anchor deploy
```

---

## 🧪 使用 CLI 與程式互動
使用這些 CLI 指令碼在本地與您的智慧合約互動。

---

### 🔹 初始化程式

```bash
yarn script config
```

初始化合約設定。

---

### 🔹 建立一個回合

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>
```
# 範例：
yarn script create -t 60 -d 100000000 -j 100
```

**參數說明：**

- `<ROUND_TIME>`：每輪持續時間（秒），例如 `60` 表示 60 秒。
- `<MIN_DEPOSIT_AMOUNT>`：最小存款額（單位 lamports，1 SOL = 1_000_000_000）。必須大於 `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`。
- `<MAX_JOINER_COUNT>`：參與者最大人數。必須小於 `config.TEST_INITIAL_MAX_JOINER_COUNT`。

---

### 🔹 加入一輪

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# 範例：
yarn script join -a 100000000 -g 2
```
**參數：**

- `<DEPOSIT_SOL_AMOUNT>`：存款金額，以 lamports 為單位（例如：0.1 SOL = 100_000_000）。
- `<ROUND_NUMBER>`：要參加的回合索引。從 `0` 開始。必須小於 `total_round`。

> 🕒 注意：該回合的倒數計時會在第二位參與者加入時開始。

---

### 🔹 選擇贏家

```bash
yarn script winner -g <ROUND_NUMBER>

# 範例：
yarn script winner -g 2
```

**注意：** 僅可在該回合時間完全結束後呼叫此指令。

---
### 🔹 領取獎金

```bash
yarn script claim -g <ROUND_NUMBER>

# 範例：
yarn script claim -g 2
```

**注意：** 這必須由中獎錢包在選出贏家後執行。

---

## 聯絡方式

如有關於 Solana 智能合約開發、DeFi 實作或 DEX 整合的問題或諮詢，請聯絡專案維護者。

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---