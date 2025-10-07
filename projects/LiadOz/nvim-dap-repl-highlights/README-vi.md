
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# nvim-dap-repl-highlights
Thêm tô sáng cú pháp vào bộ đệm REPL của [nvim-dap](https://github.com/mfussenegger/nvim-dap) bằng treesitter.
| Trước                                                                                                           | Sau                                                                                                            |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## Yêu cầu
* Neovim 0.9 hoặc mới hơn
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## Thiết lập
Cài đặt plugin và các yêu cầu bằng phương pháp bạn yêu thích. Sau khi cài đặt, hãy đảm bảo bạn đã cấu hình [highlighting](https://github.com/nvim-treesitter/nvim-treesitter#modules) của treesitter rồi thêm đoạn sau vào cấu hình lua của bạn.
```lua
require('nvim-dap-repl-highlights').setup()
```
Sau khi thiết lập plugin ban đầu, trình phân tích cú pháp dap_repl cần được cài đặt, việc này có thể thực hiện thủ công bằng cách chạy `:TSInstall dap_repl`.

Hoặc tự động thông qua cấu hình Treesitter:

**Sử dụng `ensure_installed` (nhánh master của nvim-treesitter)**
> ⚠️ **LƯU Ý:** Bạn phải gọi nvim-dap-repl-highlights.setup() trước Treesitter, nếu không trình phân tích cú pháp dap_repl sẽ không được tìm thấy.
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter.configs').setup {
  highlight = {
    enable = true,
  },
  ensure_installed = { 'dap_repl', ... },
  ...
}
```
**Sử dụng `nvim-treesitter.install` (nhánh chính của nvim-treesitter)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ Nếu điều này ngừng hoạt động hoặc API thay đổi, hãy kiểm tra tài liệu chính thức của Treesitter để biết phương thức cài đặt mới nhất:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## Sử dụng
Theo mặc định, plugin sẽ phát hiện ngôn ngữ sử dụng trong REPL bằng cách kiểm tra **filetype** được dùng để khởi chạy dap. Rõ ràng là để có tô sáng cú pháp cho một số ngôn ngữ nhất định, bạn cần có trình phân tích treesitter cho ngôn ngữ đó, cùng với trình phân tích `dap_repl`.
Điều này có thể không phù hợp với tất cả các trường hợp sử dụng.

Thay vào đó, bạn có thể sử dụng lệnh `:lua require('nvim-dap-repl-highlights').setup_highlights('python')` để đặt tô sáng python trong buffer repl hiện tại.
Hoặc bạn có thể gọi hàm mà không chỉ định ngôn ngữ, khi đó người dùng sẽ được nhắc chọn ngôn ngữ.

Ngoài ra, bạn có thể chỉ định trong cấu hình **dap** ngôn ngữ repl cần sử dụng, ví dụ nếu bạn muốn repl python của mình có tô sáng javascript:
```lua
local dap = require('dap')
dap.configurations.python = {
  {
    name = "Python with javascript repl because I like to watch the world burn 🔥🔥🔥",
    type = "python",
    request = "launch",
    program = "${file}",
    repl_lang = "javascript"
  },
}
```
Tùy chọn repl_lang được ưu tiên hơn so với kiểu tệp.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---