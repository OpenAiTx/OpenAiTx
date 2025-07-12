# 🎯 プロジェクトセットアップガイド

プロジェクトへようこそ！このガイドでは、必要なツールのインストールとローカル環境の設定方法を素早くご案内します。

---

## 🛠️ 前提条件

以下のツールがシステムにインストールされていることを確認してください：

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **推奨Anchorバージョン:** `0.30.1`

---

## ✅ バージョン確認と設定

すべてが正しくインストールおよび設定されていることを確認してください：

```bash
rustc --version             # Rustのバージョンを確認
solana --version            # Solana CLIのバージョンを確認
anchor --version            # Anchorのバージョンを確認

solana config get           # 現在のSolana設定を表示
solana config set --url devnet  # ネットワークをdevnetに設定
```
---

## 🔐 ウォレット設定

ウォレットキーの生成と管理:

```bash
solana-keygen new -o ./keys/admin.json     # 新しいキーペアを生成
solana-keygen pubkey ./keys/admin.json     # 公開鍵を取得
solana balance ./keys/admin.json           # ウォレット残高を確認
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # ウォレットに5 SOLをエアドロップ
```

---

## 📦 プロジェクトのインストール

プロジェクトをクローンして依存関係をインストール:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ クイックスタート

### 🏗️ プログラムのビルド

Anchor スマートコントラクトをコンパイルします：

```bash
# nightly ツールチェーンを使用して Anchor プログラムをビルド
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# すべてのプログラム公開鍵を同期
anchor keys sync

# lib.rs 内のプログラムアドレスが変更された場合は再ビルド
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Devnetでのテスト

`Anchor.toml`がDevnetを使用していることを確認してください:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 プログラムのデプロイ

```bash
anchor deploy
```

---

## 🧪 CLIを使用してプログラムと対話する
これらのCLIスクリプトを使用して、ローカルでスマートコントラクトと対話します。

---

### 🔹 プログラムの初期化

```bash
yarn script config
```

コントラクトの設定を初期化します。

---

### 🔹 ラウンドの作成

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>
```
# 例:
yarn script create -t 60 -d 100000000 -j 100
```

**パラメータ:**

- `<ROUND_TIME>`: ラウンドの継続時間（秒単位）（例: `60` = 60秒）。
- `<MIN_DEPOSIT_AMOUNT>`: 最小デポジット額（lamports単位、1 SOL = 1_000_000_000）。`config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`より大きい必要があります。
- `<MAX_JOINER_COUNT>`: 参加者の最大数。`config.TEST_INITIAL_MAX_JOINER_COUNT`より小さい必要があります。

---

### 🔹 ラウンドに参加する

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# 例:
yarn script join -a 100000000 -g 2
```
**パラメータ:**

- `<DEPOSIT_SOL_AMOUNT>`: 入金額（lamports単位、例: 0.1 SOL = 100_000_000）。
- `<ROUND_NUMBER>`: 参加するラウンドのインデックス。`0`から始まる。`total_round`未満である必要がある。

> 🕒 注: ラウンドのカウントダウンは、2人目の参加者が参加した時点で開始されます。

---

### 🔹 勝者の選択

```bash
yarn script winner -g <ROUND_NUMBER>

# 例:
yarn script winner -g 2
```

**注:** ラウンドの時間が完全に経過した後にのみ実行してください。

---
### 🔹 勝利金の請求

```bash
yarn script claim -g <ROUND_NUMBER>

# 例:
yarn script claim -g 2
```

**注意:** 勝者が選出された後、勝利ウォレットによってこのコマンドを実行する必要があります。

---

## お問い合わせ

Solanaスマートコントラクト開発、DeFi実装、またはDEX統合に関するご質問やお問い合わせは、プロジェクト管理者までご連絡ください。

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---