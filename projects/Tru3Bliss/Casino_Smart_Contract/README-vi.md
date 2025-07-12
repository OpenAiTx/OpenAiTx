# 🎯 Hướng Dẫn Cài Đặt Dự Án

Chào mừng bạn đến với dự án! Hướng dẫn này sẽ giúp bạn nhanh chóng bắt đầu bằng cách cài đặt các công cụ cần thiết và cấu hình môi trường làm việc trên máy của bạn.

---

## 🛠️ Yêu Cầu Trước

Đảm bảo rằng các công cụ sau đã được cài đặt trên hệ thống của bạn:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **Phiên bản Anchor khuyến nghị:** `0.30.1`

---

## ✅ Kiểm Tra Phiên Bản & Cấu Hình

Xác minh rằng mọi thứ đã được cài đặt và cấu hình đúng cách:

```bash
rustc --version             # Kiểm tra phiên bản Rust
solana --version            # Kiểm tra phiên bản Solana CLI
anchor --version            # Kiểm tra phiên bản Anchor

solana config get           # Xem cấu hình Solana hiện tại
solana config set --url devnet  # Đặt mạng lưới thành devnet
```
---

## 🔐 Thiết lập Ví

Tạo và quản lý khóa ví của bạn:

```bash
solana-keygen new -o ./keys/admin.json     # Tạo một cặp khóa mới
solana-keygen pubkey ./keys/admin.json     # Lấy khóa công khai
solana balance ./keys/admin.json           # Kiểm tra số dư ví
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # Nhận airdrop 5 SOL vào ví của bạn
```

---

## 📦 Cài đặt Dự án

Clone dự án và cài đặt các phụ thuộc:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ Khởi Động Nhanh

### 🏗️ Xây Dựng Chương Trình

Biên dịch hợp đồng thông minh Anchor:

```bash
# Xây dựng chương trình Anchor bằng toolchain nightly
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# Đồng bộ tất cả khóa công khai của chương trình
anchor keys sync

# Xây dựng lại nếu địa chỉ chương trình trong lib.rs đã thay đổi
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Kiểm tra trên Devnet

Đảm bảo `Anchor.toml` của bạn sử dụng Devnet:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 Triển khai Chương trình

```bash
anchor deploy
```

---

## 🧪 Sử dụng CLI để Tương tác với Chương trình
Sử dụng các script CLI này để tương tác với hợp đồng thông minh của bạn tại địa phương.

---

### 🔹 Khởi tạo Chương trình

```bash
yarn script config
```

Khởi tạo cấu hình hợp đồng.

---

### 🔹 Tạo một Vòng chơi

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>
```
# Ví dụ:
yarn script create -t 60 -d 100000000 -j 100
```

**Tham số:**

- `<ROUND_TIME>`: Thời lượng của vòng, tính bằng giây (ví dụ, `60` = 60 giây).
- `<MIN_DEPOSIT_AMOUNT>`: Số tiền gửi tối thiểu tính bằng lamports (1 SOL = 1_000_000_000). Phải lớn hơn `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`.
- `<MAX_JOINER_COUNT>`: Số lượng người tham gia tối đa. Phải nhỏ hơn `config.TEST_INITIAL_MAX_JOINER_COUNT`.

---

### 🔹 Tham gia một vòng

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# Ví dụ:
yarn script join -a 100000000 -g 2
```
**Tham số:**

- `<DEPOSIT_SOL_AMOUNT>`: Số tiền gửi tính bằng lamports (ví dụ: 0.1 SOL = 100_000_000).
- `<ROUND_NUMBER>`: Chỉ số của vòng muốn tham gia. Bắt đầu từ `0`. Phải nhỏ hơn `total_round`.

> 🕒 Lưu ý: Thời gian đếm ngược cho vòng sẽ bắt đầu khi người tham gia thứ hai tham gia.

---

### 🔹 Chọn Người Thắng

```bash
yarn script winner -g <ROUND_NUMBER>

# Ví dụ:
yarn script winner -g 2
```

**Lưu ý:** Chỉ gọi lệnh này sau khi thời gian của vòng đã kết thúc hoàn toàn.

---
### 🔹 Nhận thưởng

```bash
yarn script claim -g <ROUND_NUMBER>

# Ví dụ:
yarn script claim -g 2
```

**Lưu ý:** Lệnh này phải được thực hiện bởi ví chiến thắng sau khi người thắng cuộc đã được chọn.

---

## Liên hệ

Nếu bạn có câu hỏi hoặc thắc mắc về phát triển smart contract trên Solana, triển khai DeFi, hoặc tích hợp DEX, vui lòng liên hệ với những người duy trì dự án.

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---