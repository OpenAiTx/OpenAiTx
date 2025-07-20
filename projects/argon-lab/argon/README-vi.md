<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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

# Argon - Cỗ máy thời gian MongoDB 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**Du hành xuyên thời gian trong cơ sở dữ liệu MongoDB của bạn. Tạo nhánh, khôi phục và thử nghiệm mà không lo sợ.**

## Argon là gì?

Argon mang đến cho MongoDB sức mạnh vượt trội với **nhánh giống Git** và **du hành thời gian**. Tạo các nhánh cơ sở dữ liệu tức thì, khôi phục về bất kỳ thời điểm nào trong lịch sử, và không bao giờ mất dữ liệu nữa.

### 🎯 Lợi ích chính

- **⚡ Nhánh tức thì** - Sao chép toàn bộ cơ sở dữ liệu chỉ trong 1ms (không phải hàng giờ)
- **⏰ Du hành thời gian** - Truy vấn dữ liệu ở bất kỳ thời điểm nào trong lịch sử
- **🔄 Khôi phục an toàn** - Xem trước thay đổi trước khi khôi phục
- **💾 Không tốn dung lượng lưu trữ** - Các nhánh chia sẻ dữ liệu hiệu quả
- **🔌 Tương thích sẵn sàng** - Hoạt động với mã MongoDB hiện có

## Demo nhanh

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
## Trường Hợp Sử Dụng Thực Tế

### 🚨 **Khôi Phục Thảm Họa**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
### 🧪 **Kiểm Tra An Toàn**

```bash
# Test with real production data
argon branches create staging --from production
# Run risky migrations fearlessly
```
### 📊 **Phân tích Dữ liệu**

```bash
# Compare data across time
argon time-travel diff --from "last week" --to "today"
# See exactly what changed
```
## Cách Hoạt Động

Argon chặn các thao tác trên MongoDB và ghi chúng vào **Write-Ahead Log (WAL)**, cho phép:
- Tạo nhánh tức thì thông qua con trỏ siêu dữ liệu
- Du hành thời gian bằng cách phát lại các thao tác
- Hiệu suất tối ưu không cần sao chép

Mã MongoDB hiện tại của bạn không cần thay đổi - chỉ cần thêm `ENABLE_WAL=true`.

## Cài Đặt


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## Tài liệu

- 📖 [Hướng Dẫn Bắt Đầu Nhanh](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [Tham Khảo API](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [Trường Hợp Sử Dụng](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Kiến Trúc](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Cộng đồng

- 🐛 [Báo Cáo Vấn Đề](https://github.com/argon-lab/argon/issues)
- 💬 [Thảo Luận](https://github.com/argon-lab/argon/discussions)
- 📧 [Liên Hệ](https://www.argonlabs.tech)

---

<div align="center">

**Hãy biến MongoDB của bạn thành cỗ máy thời gian. Không bao giờ mất dữ liệu nữa.**

⭐ **Hãy gắn sao cho chúng tôi** nếu Argon đã giúp bạn!

[Bắt Đầu →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Dùng Thử Trực Tiếp →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---