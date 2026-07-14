
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

Claude Code được viết lại dưới dạng script bash. Khoảng ~1.500 dòng. Không sử dụng gói npm nào.

## Tại sao

Claude Code gốc có khoảng ~380.000 dòng TypeScript với 266 phụ thuộc npm. Script này thực hiện cùng nhiệm vụ cốt lõi bằng bash chỉ với `curl` và `jq`.

## Tính năng

- **Phát trực tuyến theo thời gian thực** qua FIFO pipe — văn bản xuất hiện khi Claude tạo ra
- **6 công cụ**: Bash, Đọc, Sửa, Viết, Glob, Grep
- **Chuỗi công cụ** — tối đa 25 lần gọi công cụ mỗi lượt
- **Nhắc quyền** — hỏi trước khi chạy lệnh không an toàn (`y/n/a`)
- **Tải CLAUDE.md** — đọc hướng dẫn dự án từ các tệp CLAUDE.md trong cây thư mục
- **Ngữ cảnh nhận biết Git** — nhánh, trạng thái, và các cam kết gần đây trong lời nhắc hệ thống
- **Lưu/tiếp tục phiên** — tự động lưu khi thoát, tiếp tục với `--resume <id>`
- **Thử lại với backoff** — thử lại theo cấp số nhân khi gặp giới hạn tốc độ 429/529
- **Theo dõi chi phí** — tổng chi phí theo lượt và theo phiên
- **Spinner** — với các động từ spinner gốc (Clauding, Flibbertigibbeting, v.v.)
- **Lệnh gạch chéo** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **Chế độ pipe** — `echo "giải thích điều này" | ./claude.sh`

## Cài đặt

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## Phụ thuộc

- `curl`
- `jq`
- Tuỳ chọn: `rg` (ripgrep) để tìm kiếm tốt hơn
- Tuỳ chọn: `python3` cho công cụ chỉnh sửa

Phiên bản thời gian chạy được cố định trong `.tool-versions`. Cài đặt chúng với [mise](https://mise.jdx.dev/):

```bash
mise install
```

## Sử dụng

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### Biến Môi Trường

| Biến | Mặc định | Mô tả |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (bắt buộc) | Khóa API Anthropic của bạn |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | Mô hình sử dụng |
| `CLAUDE_MAX_TOKENS` | `8192` | Số lượng token đầu ra tối đa |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | URL gốc của API |
| `CLAUDE_SH_PERMISSIONS` | `ask` | Chế độ quyền: `ask`, `allow`, hoặc `deny` |

### Lệnh

```txt
/help      — Show help
/cost      — Show session cost
/model     — Show/change model
/clear     — Clear conversation
/save      — Save current session
/resume    — List/resume saved sessions
/commit    — Auto-generate a git commit
/diff      — Show git diff
/quit      — Exit
```

### Tiếp tục một Phiên làm việc

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## Kiến trúc

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## Cách Thức Hoạt Động

1. Đọc đầu vào từ người dùng
2. Xây dựng yêu cầu JSON với `jq` (tin nhắn, công cụ, lời nhắc hệ thống)
3. Truyền phản hồi theo luồng qua `curl` thông qua một ống FIFO
4. Phân tích các sự kiện SSE từng dòng, in phần thay đổi văn bản theo thời gian thực
5. Khi các khối tool_use đến, thực thi các công cụ
6. Gửi kết quả công cụ trở lại dưới dạng tin nhắn
7. Lặp lại cho đến khi Claude ngừng gọi công cụ

## So Sánh

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| Số dòng mã | ~1,500 | ~380,000 |
| Phụ thuộc | curl, jq | 266 gói npm |
| Kích thước nhị phân | 0 (script) | ~200MB node_modules |
| Thời gian khởi động | Ngay lập tức | ~500ms |

### Kiểm Tra

Các bài kiểm tra sử dụng [bats](https://github.com/bats-core/bats-core) (Hệ Thống Kiểm Tra Tự Động Bash):

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---