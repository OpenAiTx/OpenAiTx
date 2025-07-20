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

**MongoDB veritabanınızda zamanda yolculuk yapın. Dallanın, geri yükleyin ve korkmadan deneyin.**

## Argon Nedir?

Argon, MongoDB'ye **Git benzeri dallanma** ve **zaman yolculuğu** ile süper güçler kazandırır. Anında veritabanı dalları oluşturun, geçmişteki herhangi bir noktaya geri yükleyin ve artık veri kaybetmeyin.

### 🎯 Temel Faydalar

- **⚡ Anında Dallar** - Tüm veritabanınızı 1 ms'de klonlayın (saatler değil)
- **⏰ Zaman Yolculuğu** - Verilerinizi geçmişteki herhangi bir noktadan sorgulayın
- **🔄 Güvenli Geri Yükleme** - Geri yüklemeden önce değişiklikleri önizleyin
- **💾 Sıfır Depolama Maliyeti** - Dallar verileri verimli şekilde paylaşır
- **🔌 Kolay Entegrasyon** - Mevcut MongoDB kodunuzla çalışır

## Hızlı Demo

```bash
# Install
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Cross-platform

# Create a time-travel enabled database
export ENABLE_WAL=true
argon projects create myapp

# Your app crashed after bad migration? No problem!
argon restore preview --time "1 hour ago"
argon restore reset --time "before disaster"

# Need a test environment? Branch instantly!
argon branches create test-env
# Full database copy created in 1ms 🚀
```
## Gerçek Dünya Kullanım Durumları

### 🚨 **Felaket Kurtarma**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
### 🧪 **Güvenli Test**

```bash
# Test with real production data
argon branches create staging --from production
# Run risky migrations fearlessly
```
### 📊 **Veri Analizi**

```bash
# Compare data across time
argon time-travel diff --from "last week" --to "today"
# See exactly what changed
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
- 💡 [Kullanım Senaryoları](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Mimari](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Topluluk

- 🐛 [Sorun Bildir](https://github.com/argon-lab/argon/issues)
- 💬 [Tartışmalar](https://github.com/argon-lab/argon/discussions)
- 📧 [İletişim](https://www.argonlabs.tech)

---

<div align="center">

**MongoDB'nize bir zaman makinesi kazandırın. Artık asla veri kaybetmeyin.**

⭐ **Bize yıldız verin** eğer Argon gününüzü kurtardıysa!

[Başlayın →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Canlı Demo →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---