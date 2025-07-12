# 🎯 คู่มือการตั้งค่าโปรเจกต์

ยินดีต้อนรับสู่โปรเจกต์! คู่มือนี้จะช่วยให้คุณเริ่มต้นได้อย่างรวดเร็วโดยการติดตั้งเครื่องมือที่จำเป็นและตั้งค่าสภาพแวดล้อมในเครื่องของคุณ

---

## 🛠️ ข้อกำหนดเบื้องต้น

ตรวจสอบให้แน่ใจว่าคุณได้ติดตั้งเครื่องมือดังต่อไปนี้ในระบบของคุณแล้ว:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **แนะนำเวอร์ชัน Anchor:** `0.30.1`

---

## ✅ ตรวจสอบเวอร์ชัน & ตั้งค่าคอนฟิก

ตรวจสอบให้แน่ใจว่าทุกอย่างถูกติดตั้งและตั้งค่าเรียบร้อยแล้ว:

```bash
rustc --version             # ตรวจสอบเวอร์ชัน Rust
solana --version            # ตรวจสอบเวอร์ชัน Solana CLI
anchor --version            # ตรวจสอบเวอร์ชัน Anchor

solana config get           # ดูค่าคอนฟิก Solana ปัจจุบัน
solana config set --url devnet  # ตั้งค่าเครือข่ายเป็น devnet
```
---

## 🔐 การตั้งค่ากระเป๋าเงิน

สร้างและจัดการคีย์ของกระเป๋าเงินของคุณ:

```bash
solana-keygen new -o ./keys/admin.json     # สร้างคีย์คู่ใหม่
solana-keygen pubkey ./keys/admin.json     # รับคีย์สาธารณะ
solana balance ./keys/admin.json           # ตรวจสอบยอดเงินกระเป๋า
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # รับ airdrop 5 SOL เข้ากระเป๋าของคุณ
```

---

## 📦 การติดตั้งโปรเจกต์

โคลนโปรเจกต์และติดตั้ง dependencies:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ เริ่มต้นอย่างรวดเร็ว

### 🏗️ สร้างโปรแกรม

คอมไพล์สมาร์ทคอนแทรกต์ Anchor:

```bash
# สร้างโปรแกรม Anchor โดยใช้ nightly toolchain
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# ซิงค์คีย์สาธารณะของโปรแกรมทั้งหมด
anchor keys sync

# สร้างใหม่หากที่อยู่โปรแกรมใน lib.rs มีการเปลี่ยนแปลง
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 ทดสอบบน Devnet

ตรวจสอบให้แน่ใจว่า `Anchor.toml` ของคุณใช้ Devnet:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 ดีพลอยโปรแกรม

```bash
anchor deploy
```

---

## 🧪 ใช้ CLI เพื่อโต้ตอบกับโปรแกรม
ใช้สคริปต์ CLI เหล่านี้เพื่อโต้ตอบกับสมาร์ทคอนแทรกต์ของคุณในเครื่อง

---

### 🔹 เริ่มต้นโปรแกรม

```bash
yarn script config
```

เริ่มต้นการตั้งค่าสัญญา

---

### 🔹 สร้างรอบใหม่

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>

# ตัวอย่าง:
yarn script create -t 60 -d 100000000 -j 100
```

**พารามิเตอร์:**

- `<ROUND_TIME>`: ระยะเวลาของรอบเป็นวินาที (เช่น `60` = 60 วินาที)
- `<MIN_DEPOSIT_AMOUNT>`: จำนวนเงินฝากขั้นต่ำ หน่วยเป็น lamports (1 SOL = 1_000_000_000) ต้องมากกว่า `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`
- `<MAX_JOINER_COUNT>`: จำนวนผู้เข้าร่วมสูงสุด ต้องน้อยกว่า `config.TEST_INITIAL_MAX_JOINER_COUNT`

---

### 🔹 เข้าร่วมรอบ

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# ตัวอย่าง:
yarn script join -a 100000000 -g 2
```
**พารามิเตอร์:**

- `<DEPOSIT_SOL_AMOUNT>`: จำนวนเงินฝากในหน่วย lamports (เช่น 0.1 SOL = 100_000_000)
- `<ROUND_NUMBER>`: ดัชนีของรอบที่ต้องการเข้าร่วม เริ่มจาก `0` ต้องน้อยกว่า `total_round`

> 🕒 หมายเหตุ: การนับถอยหลังของรอบจะเริ่มต้นเมื่อมีผู้เข้าร่วมคนที่สองเข้าร่วม

---

### 🔹 เลือกผู้ชนะ

```bash
yarn script winner -g <ROUND_NUMBER>

# ตัวอย่าง:
yarn script winner -g 2
```

**หมายเหตุ:** เรียกคำสั่งนี้หลังจากเวลาของรอบสิ้นสุดลงแล้วเท่านั้น

---
### 🔹 การรับรางวัลที่ชนะ

```bash
yarn script claim -g <ROUND_NUMBER>

# ตัวอย่าง:
yarn script claim -g 2
```

**หมายเหตุ:** คำสั่งนี้ต้องถูกรันโดยกระเป๋าเงินที่ชนะหลังจากที่มีการเลือกผู้ชนะแล้ว

---

## ติดต่อ

หากมีคำถามหรือข้อสงสัยเกี่ยวกับการพัฒนา Smart Contract บน Solana, การใช้งาน DeFi หรือการเชื่อมต่อ DEX กรุณาติดต่อผู้ดูแลโปรเจ็กต์

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---