# mcp-chat

<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

Phần mềm khách MCP mã nguồn mở đa dụng để kiểm thử & đánh giá các máy chủ và tác nhân MCP

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>


## Khởi động nhanh

Đảm bảo rằng bạn đã xuất biến môi trường `ANTHROPIC_API_KEY` hoặc đặt nó trong file .env ở thư mục gốc của dự án. Bạn có thể nhận khóa API bằng cách đăng ký tại [trang khóa Anthropic Console](https://console.anthropic.com/settings/keys).

Trường hợp sử dụng đơn giản tạo một cửa sổ trò chuyện tương tác với máy chủ MCP hệ thống tệp từ CLI:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

Điều này sẽ mở ra một cửa sổ trò chuyện mà bạn có thể sử dụng để tương tác với các máy chủ và trò chuyện với một LLM.

## Cấu hình

Bạn cũng có thể chỉ định tệp claude_desktop_config.json của bạn (Mac):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

Hoặc (Windows):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```
Ở chế độ web, bạn có thể bắt đầu cuộc trò chuyện mới, gửi tin nhắn đến mô hình, và cấu hình động các máy chủ mcp thông qua giao diện người dùng - không cần chỉ định qua dòng lệnh. Ngoài ra, các cuộc trò chuyện được tạo qua Web UI sẽ được lưu tại ~/.mcpchats/chats giống như các cuộc trò chuyện tạo qua CLI.

## Tính năng

- [x] Chạy qua CLI ở chế độ tương tác hoặc truyền prompt trực tiếp bằng `-p`
- [x] Chế độ web để trò chuyện với mô hình qua giao diện web `--web`
- [x] Kết nối đến bất kỳ máy chủ MCP nào (JS, Python, Docker) trong môi trường sản xuất hoặc phát triển
- [x] Chọn giữa các mô hình bằng `-m`
- [x] Tùy chỉnh prompt hệ thống với `--system`
- [x] Lưu lịch sử trò chuyện cùng cài đặt tại `~/.mcpchat/chats` bao gồm cả trò chuyện web
- [x] Lưu và khôi phục lệnh tại `~/.mcpchat/history`
- [x] Xem trực tiếp đầu ra và tham số của công cụ trong cuộc trò chuyện để hỗ trợ debug máy chủ mcp

## Sử dụng CLI

Chạy prompt qua CLI với cờ `-p`:


```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Điều này chạy prompt với máy chủ mcp-server của kubernetes & thoát sau khi nhận được phản hồi trên stdout.

Chọn một mô hình để trò chuyện qua CLI bằng cờ `-m`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

Sử dụng mô hình `claude-3.5` để trò chuyện. Lưu ý rằng hiện tại chỉ hỗ trợ các mô hình của Anthropic.

Lời nhắc hệ thống tùy chỉnh:

Cờ `--system` có thể được sử dụng để chỉ định lời nhắc hệ thống:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## Biến môi trường (ENV vars)

Mcp-chat hỗ trợ truyền các biến môi trường đến các máy chủ mcp. Tuy nhiên, điều này không được chuẩn hóa trong đặc tả mcp và các ứng dụng khách khác có thể không thực hiện với giá trị biến môi trường động - đọc thêm [tại đây](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) về các ứng dụng khách mcp stdio tiêu chuẩn.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## Dành cho nhà phát triển mcp-servers

Bạn có thể truyền vào một bản dựng cục bộ của python hoặc node mcp-server để kiểm thử với mcp-chat:

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

Python:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## Phát triển

Cài đặt các phụ thuộc & chạy CLI:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
Để phát triển mcp-chat khi kết nối với một mcp-server, hãy tạo bản build & chạy CLI với cờ server:


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Kiểm tra:

```shell
bun run test
```

Xây dựng:

```shell
bun run build
```

Xuất bản:

```shell
bun run publish
```

Xuất bản Docker:

```shell
bun run dockerbuild
```

### Cấu trúc Dự án

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## Phát hành bản mới

Truy cập trang [phát hành](https://github.com/Flux159/mcp-chat/releases), nhấn vào "Draft New Release", nhấn "Choose a tag" và tạo một tag mới bằng cách nhập số phiên bản mới theo định dạng semver "v{major}.{minor}.{patch}". Sau đó, viết tiêu đề phát hành "Release v{major}.{minor}.{patch}" và mô tả / changelog nếu cần thiết rồi nhấn "Publish Release".

Việc này sẽ tạo một tag mới và kích hoạt quy trình xây dựng bản phát hành mới qua workflow cd.yml. Khi thành công, bản phát hành mới sẽ được đăng lên npm. Lưu ý rằng không cần cập nhật thủ công phiên bản package.json, vì workflow sẽ tự động cập nhật số phiên bản trong file package.json và đẩy commit lên nhánh main.

## Giấy phép

[Giấy phép MIT](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---