# 🎯 项目搭建指南

欢迎加入本项目！本指南将帮助你快速入门，安装所需工具并配置本地环境。

---

## 🛠️ 前置条件

请确保你的系统已安装以下工具：

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **推荐 Anchor 版本：** `0.30.1`

---

## ✅ 检查版本并设置配置

请验证所有工具是否已正确安装和配置：

```bash
rustc --version             # 检查 Rust 版本
solana --version            # 检查 Solana CLI 版本
anchor --version            # 检查 Anchor 版本

solana config get           # 查看当前 Solana 配置
solana config set --url devnet  # 设置网络为 devnet
```
---

## 🔐 钱包设置

生成并管理你的钱包密钥：

```bash
solana-keygen new -o ./keys/admin.json     # 生成新的密钥对
solana-keygen pubkey ./keys/admin.json     # 获取公钥
solana balance ./keys/admin.json           # 检查钱包余额
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # 给你的钱包空投 5 SOL
```

---

## 📦 项目安装

克隆项目并安装依赖：

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ 快速开始

### 🏗️ 构建程序

编译 Anchor 智能合约：

```bash
# 使用 nightly 工具链构建 Anchor 程序
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# 同步所有程序公钥
anchor keys sync

# 如果 lib.rs 中的程序地址发生变化则重新构建
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 在 Devnet 上测试

确保你的 `Anchor.toml` 使用的是 Devnet：

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 部署程序

```bash
anchor deploy
```

---

## 🧪 使用 CLI 与程序交互
使用这些 CLI 脚本在本地与您的智能合约进行交互。

---

### 🔹 初始化程序

```bash
yarn script config
```

初始化合约配置。

---

### 🔹 创建一轮

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>

# 示例:
yarn script create -t 60 -d 100000000 -j 100
```

**参数说明：**

- `<ROUND_TIME>`：每轮持续时间，单位为秒（例如，`60` = 60秒）。
- `<MIN_DEPOSIT_AMOUNT>`：最小存款额，单位为 lamports（1 SOL = 1_000_000_000）。必须大于 `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`。
- `<MAX_JOINER_COUNT>`：参与者最大数量。必须小于 `config.TEST_INITIAL_MAX_JOINER_COUNT`。

---

### 🔹 参与一轮

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# 示例:
yarn script join -a 100000000 -g 2
```
**参数：**

- `<DEPOSIT_SOL_AMOUNT>`：存款金额，以 lamports 为单位（例如，0.1 SOL = 100_000_000）。
- `<ROUND_NUMBER>`：要加入的轮次索引。从 `0` 开始。必须小于 `total_round`。

> 🕒 注意：该轮的倒计时在第二位参与者加入时开始。

---

### 🔹 选择获胜者

```bash
yarn script winner -g <ROUND_NUMBER>

# 示例：
yarn script winner -g 2
```

**注意：** 仅在该轮时间完全结束后调用此命令。

---
### 🔹 领取奖金

```bash
yarn script claim -g <ROUND_NUMBER>

# 示例：
yarn script claim -g 2
```

**注意：** 这一步必须由获胜钱包在选出获胜者后执行。

---

## 联系方式

如有关于 Solana 智能合约开发、DeFi 实现或 DEX 集成的疑问或咨询，请联系项目维护者。

**Telegram**：[ @Tru3B1iss ](https://t.me/Tru3B1iss)
**X (推特)**：[ @XTruebliss ](https://x.com/XTruebliss)
**Discord**：[ @trueb1iss ](https://discord.com/users/1274339638668038187)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---