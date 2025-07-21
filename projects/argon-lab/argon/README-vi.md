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

# Argon - Cỗ máy thời gian cho MongoDB 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**Du hành thời gian trong cơ sở dữ liệu MongoDB của bạn. Phân nhánh, khôi phục và thử nghiệm mà không lo lắng.**

## Argon là gì?

Argon mang đến cho MongoDB siêu năng lực với **phân nhánh như Git** và **du hành thời gian**. Tạo nhánh cơ sở dữ liệu tức thì, khôi phục về bất kỳ thời điểm nào trong lịch sử và không bao giờ mất dữ liệu nữa.

### 🎯 Lợi ích chính

- **⚡ Tạo nhánh tức thì** - Sao chép toàn bộ cơ sở dữ liệu chỉ trong 1ms (không phải hàng giờ)
- **⏰ Du hành thời gian** - Truy vấn dữ liệu tại bất kỳ thời điểm nào trong lịch sử với **hơn 220.000 truy vấn/giây**
- **🔄 Khôi phục an toàn** - Xem trước thay đổi trước khi khôi phục
- **💾 Không tốn dung lượng lưu trữ** - Các nhánh chia sẻ dữ liệu hiệu quả với nén 90%
- **🔌 Tương thích liền mạch** - Làm việc với mã MongoDB hiện có
- **🚀 Hiệu năng doanh nghiệp** - Truy vấn du hành thời gian nhanh hơn 26 lần sau các tối ưu hóa mới nhất
- **✅ Kiểm thử toàn diện** - Bao phủ kiểm thử rộng đảm bảo độ tin cậy
- **🗜️ Nén thông minh** - Tự động nén WAL giúp giảm dung lượng lưu trữ 80-90%

## Demo nhanh

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
## Quy trình làm việc kiểu Git cho MongoDB

### 🔄 **Bước 1: Nhập dữ liệu ("git clone" cho cơ sở dữ liệu)**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **Bước 2: Tạo nhánh ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **Bước 3: Du hành thời gian ("git log" cho dữ liệu)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **Bước 4: Khôi phục ("git reset" trong trường hợp thảm họa)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
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

- 📖 [Hướng Dẫn Khởi Đầu Nhanh](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [Tham Khảo API](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [Các Trường Hợp Sử Dụng](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [Kiến Trúc](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## Cộng đồng

- 🤝 [Hướng Dẫn Cộng Đồng](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - Tham gia cùng chúng tôi!
- 📋 [Lộ Trình Phát Triển](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - Xem những điều sắp tới
- 🐛 [Báo Cáo Lỗi](https://github.com/argon-lab/argon/issues)
- 💬 [Thảo Luận](https://github.com/argon-lab/argon/discussions)
- 🏗️ [Đóng Góp](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - Chung tay xây dựng Argon
- 📧 [Liên Hệ](https://www.argonlabs.tech)

---

<div align="center">

**Trang bị cho MongoDB của bạn một cỗ máy thời gian. Không bao giờ mất dữ liệu nữa.**

⭐ **Hãy gắn sao cho chúng tôi** nếu Argon đã giúp bạn!

[Bắt đầu →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [Dùng thử trực tiếp →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---