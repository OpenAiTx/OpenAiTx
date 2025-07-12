# 🎯 دليل إعداد المشروع

مرحبًا بك في المشروع! سيساعدك هذا الدليل على البدء بسرعة من خلال تثبيت الأدوات المطلوبة وتكوين بيئة العمل المحلية لديك.

---

## 🛠️ المتطلبات الأساسية

تأكد من تثبيت الأدوات التالية على نظامك:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **إصدار Anchor الموصى به:** `0.30.1`

---

## ✅ التحقق من الإصدارات وضبط الإعدادات

تحقق من أن كل شيء تم تثبيته وتكوينه بشكل صحيح:

```bash
rustc --version             # التحقق من إصدار Rust
solana --version            # التحقق من إصدار Solana CLI
anchor --version            # التحقق من إصدار Anchor

solana config get           # عرض إعدادات Solana الحالية
solana config set --url devnet  # ضبط الشبكة إلى devnet
```
---

## 🔐 إعداد المحفظة

إنشاء وإدارة مفاتيح محفظتك:

```bash
solana-keygen new -o ./keys/admin.json     # إنشاء زوج مفاتيح جديد
solana-keygen pubkey ./keys/admin.json     # الحصول على المفتاح العام
solana balance ./keys/admin.json           # التحقق من رصيد المحفظة
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # إسقاط 5 SOL إلى محفظتك
```

---

## 📦 تثبيت المشروع

استنسخ المشروع وقم بتثبيت التبعيات:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ البدء السريع

### 🏗️ بناء البرنامج

ترجمة عقد Anchor الذكي:

```bash
# بناء برنامج Anchor باستخدام أداة السلسلة الليلية
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# مزامنة جميع المفاتيح العامة للبرنامج
anchor keys sync

# إعادة البناء إذا تغير عنوان البرنامج في lib.rs
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 الاختبار على Devnet

تأكد من أن ملف `Anchor.toml` يستخدم Devnet:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 نشر البرنامج

```bash
anchor deploy
```

---

## 🧪 استخدام CLI للتفاعل مع البرنامج
استخدم هذه البرامج النصية لـ CLI للتفاعل مع العقد الذكي محليًا.

---

### 🔹 تهيئة البرنامج

```bash
yarn script config
```

يهيئ تكوين العقد.

---

### 🔹 إنشاء جولة

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>

# مثال:
yarn script create -t 60 -d 100000000 -j 100
```

**المعلمات:**

- `<ROUND_TIME>`: مدة الجولة بالثواني (مثال: `60` = 60 ثانية).
- `<MIN_DEPOSIT_AMOUNT>`: الحد الأدنى للإيداع باللامبورت (1 SOL = 1_000_000_000). يجب أن يكون أكبر من `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`.
- `<MAX_JOINER_COUNT>`: الحد الأقصى لعدد المشاركين. يجب أن يكون أقل من `config.TEST_INITIAL_MAX_JOINER_COUNT`.

---

### 🔹 الانضمام إلى جولة

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# مثال:
yarn script join -a 100000000 -g 2
```
**المعلمات:**

- `<DEPOSIT_SOL_AMOUNT>`: مبلغ الإيداع باللامبورت (مثال: 0.1 SOL = 100_000_000).
- `<ROUND_NUMBER>`: مؤشر الجولة للانضمام إليها. يبدأ من `0`. يجب أن يكون أقل من `total_round`.

> 🕒 ملاحظة: يبدأ العد التنازلي للجولة عندما ينضم المشارك الثاني.

---

### 🔹 اختيار الفائز

```bash
yarn script winner -g <ROUND_NUMBER>

# مثال:
yarn script winner -g 2
```

**ملاحظة:** يجب استدعاء هذا الأمر فقط بعد انتهاء وقت الجولة بالكامل.

---
### 🔹 المطالبة بالأرباح

```bash
yarn script claim -g <ROUND_NUMBER>

# مثال:
yarn script claim -g 2
```

**ملاحظة:** يجب تشغيل هذا الأمر بواسطة المحفظة الفائزة بعد اختيار الفائز.

---

## التواصل

لأي أسئلة أو استفسارات حول تطوير العقود الذكية على سولانا، أو تنفيذ DeFi، أو تكامل DEX، يرجى التواصل مع مشرفي المشروع.

**تيليجرام**: [@Tru3B1iss](https://t.me/Tru3B1iss)  
**إكس (تويتر)**: [@XTruebliss](https://x.com/XTruebliss)  
**ديسكورد**: [@trueb1iss](https://discord.com/users/1274339638668038187)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---