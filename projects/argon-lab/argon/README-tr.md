<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Argon - MongoDB Zaman Makinesi 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**MongoDB veritabanınızda zamanda yolculuk yapın. Dallan, geri yükle ve korkmadan deneme yap.**

## Argon Nedir?

Argon, MongoDB'ye **Git benzeri dallanma** ve **zaman yolculuğu** gibi süper güçler kazandırır. Anında veritabanı dalları oluştur, geçmişteki herhangi bir noktaya geri yükle ve asla veri kaybetme.

### 🎯 Temel Avantajlar

- **⚡ Anında Dallar** - Tüm veritabanınızı 1ms'de kopyalayın (saatler değil)
- **⏰ Zaman Yolculuğu** - **220.000+ sorgu/sn** ile geçmişin herhangi bir noktasından verinizi sorgulayın
- **🔄 Güvenli Geri Yükleme** - Geri yüklemeden önce değişiklikleri önizleyin
- **💾 Sıfır Depolama Maliyeti** - Dallar veriyi %90 sıkıştırma ile verimli şekilde paylaşır
- **🔌 Tak-Çalıştır Uyumluluğu** - Mevcut MongoDB kodunuzla çalışır
- **🚀 Kurumsal Performans** - Son optimizasyonlar sonrası zaman yolculuğu sorguları 26 kat daha hızlı
- **✅ Kapsamlı Test** - Güvenilirliği sağlayan geniş test kapsamı
- **🗜️ Akıllı Sıkıştırma** - Otomatik WAL sıkıştırma ile depolama %80-90 azalır

## Hızlı Demo

```bash
# Install
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Cross-platform

# Step 1: Import your existing MongoDB (like "git clone")
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your data now has time travel capabilities!

# Step 2: Use Argon like Git for your database
argon branches create test-env           # Branch like "git checkout -b"
argon time-travel query --project myapp --branch main --lsn 1000

# Step 3: Disaster recovery made simple
argon restore preview --time "1 hour ago"
argon restore reset --time "before disaster"
```
## MongoDB için Git Benzeri İş Akışı

### 🔄 **Adım 1: İçe Aktar (veritabanları için "git clone")**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **Adım 2: Dal ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **Adım 3: Zaman Yolculuğu ("git log" ile veri geçmişi)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **Adım 4: Geri Yükle ("git reset" felaketler için)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## Nasıl Çalışır

Argon, MongoDB işlemlerini yakalar ve bunları bir **Önce-Yazma Günlüğü (WAL)**'na kaydeder, böylece:
- Meta veri işaretçileriyle anında dal oluşturma
- İşlemleri tekrar oynatarak zamanda yolculuk
- Sıfır kopya verimliliği

Mevcut MongoDB kodunuz olduğu gibi çalışır - sadece `ENABLE_WAL=true` ekleyin.

## Kurulum


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## Dokümantasyon

- 📖 [Hızlı Başlangıç Kılavuzu](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [API Referansı](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [Kullanım Durumları](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Mimari](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Topluluk

- 🤝 [Topluluk Rehberi](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - Katılın!
- 📋 [Yol Haritası](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - Yaklaşanları görün
- 🐛 [Sorun Bildir](https://github.com/argon-lab/argon/issues)
- 💬 [Tartışmalar](https://github.com/argon-lab/argon/discussions)
- 🏗️ [Katkıda Bulunun](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - Argon'u birlikte geliştirelim
- 📧 [İletişim](https://www.argonlabs.tech)

---

<div align="center">

**MongoDB'nize bir zaman makinesi kazandırın. Artık veri kaybetmeyin.**

⭐ **Bize yıldız verin** eğer Argon gününüzü kurtardıysa!

[Başlayın →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Canlı Demo →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---