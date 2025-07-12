# 🎯 Panduan Setup Proyek

Selamat datang di proyek ini! Panduan ini akan membantu Anda memulai dengan cepat dengan memasang alat-alat yang dibutuhkan dan mengonfigurasi lingkungan lokal Anda.

---

## 🛠️ Prasyarat

Pastikan alat-alat berikut sudah terpasang di sistem Anda:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **Versi Anchor yang direkomendasikan:** `0.30.1`

---

## ✅ Cek Versi & Atur Konfigurasi

Verifikasi bahwa semuanya sudah terpasang dan dikonfigurasi dengan benar:

```bash
rustc --version             # Cek versi Rust
solana --version            # Cek versi Solana CLI
anchor --version            # Cek versi Anchor

solana config get           # Lihat konfigurasi Solana saat ini
solana config set --url devnet  # Atur jaringan ke devnet
```
---

## 🔐 Pengaturan Wallet

Hasilkan dan kelola kunci wallet Anda:

```bash
solana-keygen new -o ./keys/admin.json     # Generate a new keypair
solana-keygen pubkey ./keys/admin.json     # Get public key
solana balance ./keys/admin.json           # Check wallet balance
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # Airdrop 5 SOL to your wallet
```

---

## 📦 Instalasi Proyek

Kloning proyek dan instal dependensi:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ Mulai Cepat

### 🏗️ Bangun Program

Kompilasi smart contract Anchor:

```bash
# Bangun program Anchor menggunakan nightly toolchain
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# Sinkronkan semua public key program
anchor keys sync

# Bangun ulang jika alamat program di lib.rs telah berubah
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Uji di Devnet

Pastikan `Anchor.toml` Anda menggunakan Devnet:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 Deploy Program

```bash
anchor deploy
```

---

## 🧪 Gunakan CLI untuk Berinteraksi dengan Program
Gunakan skrip CLI ini untuk berinteraksi dengan smart contract Anda secara lokal.

---

### 🔹 Inisialisasi Program

```bash
yarn script config
```

Menginisialisasi konfigurasi kontrak.

---

### 🔹 Membuat Putaran

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>

# Contoh:
yarn script create -t 60 -d 100000000 -j 100
```

**Parameter:**

- `<ROUND_TIME>`: Durasi ronde dalam detik (misal, `60` = 60 detik).
- `<MIN_DEPOSIT_AMOUNT>`: Setoran minimum dalam lamports (1 SOL = 1_000_000_000). Harus lebih besar dari `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`.
- `<MAX_JOINER_COUNT>`: Jumlah maksimum peserta. Harus kurang dari `config.TEST_INITIAL_MAX_JOINER_COUNT`.

---

### 🔹 Bergabung ke Ronde

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# Contoh:
yarn script join -a 100000000 -g 2
```
**Parameter:**

- `<DEPOSIT_SOL_AMOUNT>`: Jumlah deposit dalam lamports (misal, 0.1 SOL = 100_000_000).
- `<ROUND_NUMBER>`: Indeks ronde yang ingin diikuti. Dimulai dari `0`. Harus kurang dari `total_round`.

> 🕒 Catatan: Hitung mundur untuk ronde dimulai saat peserta kedua bergabung.

---

### 🔹 Pilih Pemenang

```bash
yarn script winner -g <ROUND_NUMBER>

# Contoh:
yarn script winner -g 2
```

**Catatan:** Hanya panggil ini setelah waktu ronde benar-benar habis.

---
### 🔹 Klaim Kemenangan

```bash
yarn script claim -g <ROUND_NUMBER>

# Contoh:
yarn script claim -g 2
```

**Catatan:** Ini harus dijalankan oleh dompet pemenang setelah pemenang telah dipilih.

---

## Kontak

Untuk pertanyaan atau permintaan terkait pengembangan smart contract Solana, implementasi DeFi, atau integrasi DEX, silakan hubungi pengelola proyek.

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---