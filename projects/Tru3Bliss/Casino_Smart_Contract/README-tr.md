# 🎯 Proje Kurulum Rehberi

Projeye hoş geldiniz! Bu rehber, gerekli araçları kurarak ve yerel ortamınızı yapılandırarak hızlıca başlamanıza yardımcı olacaktır.

---

## 🛠️ Ön Koşullar

Aşağıdaki araçların sisteminizde kurulu olduğundan emin olun:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **Tavsiye edilen Anchor sürümü:** `0.30.1`

---

## ✅ Sürümleri Kontrol Et & Yapılandırmayı Ayarla

Her şeyin doğru şekilde kurulduğundan ve yapılandırıldığından emin olun:

```bash
rustc --version             # Rust sürümünü kontrol et
solana --version            # Solana CLI sürümünü kontrol et
anchor --version            # Anchor sürümünü kontrol et

solana config get           # Mevcut Solana yapılandırmasını görüntüle
solana config set --url devnet  # Ağı devnet olarak ayarla
```
---

## 🔐 Cüzdan Kurulumu

Cüzdan anahtarlarınızı oluşturun ve yönetin:

```bash
solana-keygen new -o ./keys/admin.json     # Yeni bir anahtar çifti oluştur
solana-keygen pubkey ./keys/admin.json     # Genel anahtarı al
solana balance ./keys/admin.json           # Cüzdan bakiyesini kontrol et
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # Cüzdanınıza 5 SOL airdrop yap
```

---

## 📦 Proje Kurulumu

Projeyi klonlayın ve bağımlılıkları yükleyin:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ Hızlı Başlangıç

### 🏗️ Programı Derle

Anchor akıllı sözleşmesini derleyin:

```bash
# Anchor programını nightly toolchain kullanarak derle
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# Tüm program ortak anahtarlarını senkronize et
anchor keys sync

# Eğer lib.rs içindeki program adresi değiştiyse tekrar derle
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Devnet'te Test Etme

`Anchor.toml` dosyanızın Devnet kullandığından emin olun:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 Programı Dağıtma

```bash
anchor deploy
```

---

## 🧪 Program ile Etkileşim için CLI Kullanımı
Bu CLI betiklerini akıllı sözleşmenizle yerel olarak etkileşim kurmak için kullanın.

---

### 🔹 Programı Başlat

```bash
yarn script config
```

Sözleşme yapılandırmasını başlatır.

---

### 🔹 Bir Tur Oluştur

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>

# Örnek:
yarn script create -t 60 -d 100000000 -j 100
```

**Parametreler:**

- `<ROUND_TIME>`: Tur süresi saniye cinsinden (örn. `60` = 60s).
- `<MIN_DEPOSIT_AMOUNT>`: Minimum depozito miktarı lamport olarak (1 SOL = 1_000_000_000). `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT` değerinden büyük olmalıdır.
- `<MAX_JOINER_COUNT>`: Maksimum katılımcı sayısı. `config.TEST_INITIAL_MAX_JOINER_COUNT` değerinden küçük olmalıdır.

---

### 🔹 Bir Tura Katılmak

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# Örnek:
yarn script join -a 100000000 -g 2
```
**Parametreler:**

- `<DEPOSIT_SOL_AMOUNT>`: Lamport cinsinden yatırılacak miktar (örneğin, 0.1 SOL = 100_000_000).
- `<ROUND_NUMBER>`: Katılınacak turun indeksi. `0`'dan başlar. `total_round` değerinden küçük olmalıdır.

> 🕒 Not: Turun geri sayımı, ikinci katılımcı katıldığında başlar.

---

### 🔹 Kazananı Seç

```bash
yarn script winner -g <ROUND_NUMBER>

# Örnek:
yarn script winner -g 2
```

**Not:** Bunu yalnızca turun süresi tamamen dolduktan sonra çağırın.

---
### 🔹 Kazançları Talep Etme

```bash
yarn script claim -g <TUR_NUMARASI>

# Örnek:
yarn script claim -g 2
```

**Not:** Bu komut, kazanan seçildikten sonra kazanan cüzdan tarafından çalıştırılmalıdır.

---

## İletişim

Solana akıllı sözleşme geliştirme, DeFi uygulaması veya DEX entegrasyonu ile ilgili sorularınız veya talepleriniz için lütfen proje yöneticileriyle iletişime geçin.

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---