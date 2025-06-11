<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">Kho Lưu Trữ Cộng Đồng AstroNvim</h1>

Kho lưu trữ cộng đồng của AstroNvim chứa các đặc tả cấu hình plugin — một tập hợp các plugin được đóng góp bởi cộng đồng dành cho AstroNvim, một cấu hình NeoVim. Những đặc tả này giúp quản lý đa dạng các plugin được sử dụng trong AstroNvim.

## 📦 Cài đặt

Để tích hợp các plugin cộng đồng, thêm các cấu hình được cung cấp vào thiết lập `plugins` của bạn, tốt nhất là trước khi bạn nhập các plugin riêng của mình để đảm bảo tất cả các thay đổi từ AstroCommunity được tải trước các ghi đè riêng của bạn. Nếu bạn đang sử dụng [Mẫu AstroNvim](https://github.com/AstroNvim/template), việc này có thể thực hiện trong tệp `lua/community.lua` của bạn. Nếu bạn chưa quen với việc cấu hình plugin, chúng tôi khuyến nghị tham khảo [tài liệu AstroNvim](https://docs.astronvim.com/configuration/customizing_plugins/).

### Nhập Plugin AstroCommunity

Tích hợp nội dung sau vào tệp `lua/community.lua` của bạn:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/astrocommunity.colorscheme.catppuccin" },
  -- ... nhập các plugin do cộng đồng đóng góp tại đây
}
```

### Tùy biến cài đặt AstroCommunity

Khi bạn đã định nghĩa các nhập khẩu AstroCommunity trong `lua/community.lua`, bạn có thể tùy biến thêm các cài đặt trong định nghĩa plugin riêng của bạn (thường nằm trong thư mục `lua/plugins/`). Dưới đây là ví dụ giả sử bạn đã cài đặt Catppuccin như trên.

```lua
return {
  { -- tùy biến thêm các tùy chọn do cộng đồng thiết lập
    "catppuccin",
    opts = {
      integrations = {
        sandwich = false,
        noice = true,
        mini = true,
        leap = true,
        markdown = true,
        neotest = true,
        cmp = true,
        overseer = true,
        lsp_trouble = true,
        rainbow_delimiters = true,
      },
    },
  },
}
```

**Lưu ý:**

- Để vô hiệu hóa nhập khẩu, đặt tùy chọn `enabled` thành `false`. Bạn có hai cách để chỉnh sửa plugin hiện có: sử dụng tên kho lưu trữ đầy đủ (ví dụ, "m4xshen/smartcolumn.nvim") hoặc tên module (ví dụ, "catppuccin"). Hãy nhớ rằng tên module có thể khác với tên thư mục.
- Khuyến nghị sử dụng đường dẫn nhập khẩu đầy đủ khi tùy biến plugin, không dùng ký hiệu rút gọn chỉ tên kho lưu trữ.
- Bạn có thể ghi đè nhiều khía cạnh của plugin cộng đồng bao gồm cài đặt, phụ thuộc và phiên bản. Để biết thêm chi tiết về các tùy chọn có sẵn, tham khảo [tài liệu lazy.nvim](https://lazy.folke.io/).

## Đóng góp

Nếu bạn đã viết một cấu hình plugin và muốn thêm nó vào kho AstroCommunity, vui lòng theo dõi [Hướng dẫn Đóng góp](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) và gửi yêu cầu kéo (pull request). Hãy đảm bảo bạn đã kiểm tra kỹ các thay đổi trước khi gửi. Đây không phải là kho chính thức, do đó độ ổn định phụ thuộc vào các đóng góp từ cộng đồng. Chúng tôi rất mong chờ dự án này sẽ phát triển và tiến hóa ra sao!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---