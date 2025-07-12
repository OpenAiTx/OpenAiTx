# 🎯 راهنمای راه‌اندازی پروژه

به پروژه خوش آمدید! این راهنما به شما کمک می‌کند تا به سرعت با نصب ابزارهای مورد نیاز و پیکربندی محیط محلی خود، کار را آغاز کنید.

---

## 🛠️ پیش‌نیازها

اطمینان حاصل کنید که ابزارهای زیر روی سیستم شما نصب شده‌اند:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **نسخه پیشنهادی Anchor:** `0.30.1`

---

## ✅ بررسی نسخه‌ها و تنظیم پیکربندی

اطمینان حاصل کنید که همه چیز به درستی نصب و پیکربندی شده است:

```bash
rustc --version             # بررسی نسخه Rust
solana --version            # بررسی نسخه Solana CLI
anchor --version            # بررسی نسخه Anchor

solana config get           # مشاهده پیکربندی فعلی Solana
solana config set --url devnet  # تنظیم شبکه روی devnet
```
---

## 🔐 راه‌اندازی کیف پول

تولید و مدیریت کلیدهای کیف پول شما:

```bash
solana-keygen new -o ./keys/admin.json     # تولید یک جفت کلید جدید
solana-keygen pubkey ./keys/admin.json     # دریافت کلید عمومی
solana balance ./keys/admin.json           # بررسی موجودی کیف پول
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # ایردراپ ۵ SOL به کیف پول شما
```

---

## 📦 نصب پروژه

کلون کردن پروژه و نصب وابستگی‌ها:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ شروع سریع

### 🏗️ ساخت برنامه

کامپایل قرارداد هوشمند Anchor:

```bash
# ساخت برنامه Anchor با استفاده از تولچین nightly
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# همگام‌سازی تمام کلیدهای عمومی برنامه
anchor keys sync

# در صورتی که آدرس برنامه در lib.rs تغییر کرده باشد، مجدداً بسازید
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 آزمایش روی Devnet

اطمینان حاصل کنید که فایل `Anchor.toml` شما از Devnet استفاده می‌کند:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 استقرار برنامه

```bash
anchor deploy
```

---

## 🧪 استفاده از CLI برای تعامل با برنامه
از این اسکریپت‌های CLI برای تعامل با قرارداد هوشمند خود به صورت محلی استفاده کنید.

---

### 🔹 مقداردهی اولیه برنامه

```bash
yarn script config
```

پیکربندی قرارداد را مقداردهی اولیه می‌کند.

---

### 🔹 ایجاد یک راند

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>
```
# مثال:
yarn script create -t 60 -d 100000000 -j 100
```

**پارامترها:**

- `<ROUND_TIME>`: مدت زمان هر دور به ثانیه (مثلاً `60` = ۶۰ ثانیه).
- `<MIN_DEPOSIT_AMOUNT>`: حداقل مبلغ سپرده به لَمپورت (۱ SOL = ۱_۰۰۰_۰۰۰_۰۰۰). باید بیشتر از `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT` باشد.
- `<MAX_JOINER_COUNT>`: حداکثر تعداد شرکت‌کنندگان. باید کمتر از `config.TEST_INITIAL_MAX_JOINER_COUNT` باشد.

---

### 🔹 پیوستن به یک دور

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# مثال:
yarn script join -a 100000000 -g 2
```
**پارامترها:**

- `<DEPOSIT_SOL_AMOUNT>`: مقدار سپرده به لامپورت (برای مثال، ۰.۱ SOL = ۱۰۰_۰۰۰_۰۰۰).
- `<ROUND_NUMBER>`: شماره اندیس دور برای پیوستن. از `0` شروع می‌شود. باید کمتر از `total_round` باشد.

> 🕒 توجه: شمارش معکوس برای دور زمانی آغاز می‌شود که دومین شرکت‌کننده ملحق شود.

---

### 🔹 انتخاب برنده

```bash
yarn script winner -g <ROUND_NUMBER>

# مثال:
yarn script winner -g 2
```

**توجه:** این فرمان را فقط پس از پایان کامل زمان دور اجرا کنید.

---
### 🔹 دریافت جوایز

```bash
yarn script claim -g <ROUND_NUMBER>

# مثال:
yarn script claim -g 2
```

**توجه:** این دستور باید توسط کیف پول برنده پس از انتخاب برنده اجرا شود.

---

## تماس

برای سوالات یا درخواست‌ها درباره توسعه قرارداد هوشمند سولانا، پیاده‌سازی DeFi یا یکپارچه‌سازی DEX، لطفاً با نگهدارندگان پروژه تماس بگیرید.

**تلگرام**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**ایکس (توییتر)**: [@XTruebliss](https://x.com/XTruebliss)
**دیسکورد**: [@trueb1iss](https://discord.com/users/1274339638668038187)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---