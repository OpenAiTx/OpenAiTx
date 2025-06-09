![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/README.zh.md) | [日本語](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## Hướng Dẫn

NoteGen là một ứng dụng ghi chú `Markdown` đa nền tảng, tận dụng AI để kết nối giữa ghi lại và viết, tổ chức kiến thức rời rạc thành các ghi chú dễ đọc.

🖥️ Tài liệu chính thức: [https://notegen.top](https://notegen.top)

💬 Tham gia [Nhóm WeChat/QQ](https://github.com/codexu/note-gen/discussions/110)

## Tại Sao Chọn NoteGen?

- Nhẹ: [Gói cài đặt](https://github.com/codexu/note-gen/releases) chỉ **20MB**, miễn phí, không quảng cáo, không phần mềm đi kèm.
- Đa nền tảng: Hỗ trợ Mac, Windows, Linux, nhờ khả năng đa nền tảng của `Tauri2`, sẽ hỗ trợ iOS và Android trong tương lai.
- Hỗ trợ nhiều phương thức ghi lại bao gồm `chụp màn hình`, `văn bản`, `hình minh họa`, `tệp`, `liên kết`, v.v..., đáp ứng nhu cầu ghi chú rời rạc trong nhiều tình huống khác nhau.
- Sử dụng định dạng gốc `Markdown(.md)` để lưu trữ, không chỉnh sửa, dễ dàng di chuyển dữ liệu.
- Hỗ trợ sử dụng offline gốc, đồng bộ hóa thời gian thực với `GitHub, Gitee` kho riêng cùng khả năng quay lại lịch sử, và đồng bộ WebDAV.
- Tăng cường AI: Có thể cấu hình với ChatGPT, Gemini, Ollama, LM Studio, Grok và các mô hình khác, hỗ trợ cấu hình mô hình bên thứ ba tùy chỉnh.
- RAG: Ghi chú của bạn chính là cơ sở tri thức. Hỗ trợ các mô hình nhúng và mô hình rerank.

## Ảnh Chụp Màn Hình

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

Ghi lại:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

Soạn thảo:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

Giao diện:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## Từ Ghi Lại Đến Soạn Thảo

Các ứng dụng ghi chú truyền thống thường không cung cấp chức năng ghi lại. Người dùng cần phải sao chép và dán nội dung thủ công để ghi lại, làm giảm đáng kể hiệu quả. Khi gặp phải nội dung ghi chú rời rạc, việc tổ chức lại chúng đòi hỏi nhiều công sức.

NoteGen được chia thành hai trang `Ghi lại` và `Soạn thảo`, với mối liên hệ như sau:

- Các ghi chú có thể được tổ chức thành các ghi chú lớn hơn và chuyển sang trang soạn thảo để biên soạn sâu hơn.
- Trong quá trình soạn thảo, bạn có thể chèn các ghi chú bất cứ lúc nào.

### Ghi Lại

Chức năng ghi lại giống như một **chatbot AI**, nhưng khi trò chuyện, bạn có thể liên kết với nội dung đã ghi trước đó, chuyển từ chế độ trò chuyện sang chế độ tổ chức để sắp xếp thành ghi chú dễ đọc.

Các tính năng hỗ trợ sau sẽ giúp bạn ghi chú hiệu quả hơn:

- **Thẻ** để phân biệt các tình huống ghi chú khác nhau.
- **Nhân vật** hỗ trợ prompt tùy chỉnh để kiểm soát chính xác trợ lý AI của bạn.
- **Trợ lý Clipboard** tự động nhận diện văn bản hoặc hình ảnh trong clipboard và ghi lại vào danh sách của bạn.

### Soạn Thảo

Phần soạn thảo được chia thành hai phần: **Quản lý tệp** và **Trình soạn thảo Markdown**.

**Quản lý tệp**

- Hỗ trợ quản lý tệp Markdown cục bộ và đồng bộ với GitHub.
- Hỗ trợ phân cấp thư mục không giới hạn.
- Hỗ trợ nhiều phương thức sắp xếp.

**Trình soạn thảo Markdown**

- Hỗ trợ WYSIWYG, hiển thị tức thì và chế độ xem trước chia đôi màn hình.
- Hỗ trợ kiểm soát phiên bản và quay lại lịch sử.
- Hỗ trợ AI cho trò chuyện, tiếp tục viết, làm bóng bẩy và dịch thuật.
- Hỗ trợ upload hình ảnh, chuyển đổi hình ảnh thành liên kết Markdown.
- Hỗ trợ chuyển đổi HTML sang Markdown, tự động chuyển đổi nội dung copy từ trình duyệt sang định dạng Markdown.
- Hỗ trợ mục lục, công thức toán học, sơ đồ tư duy, biểu đồ, lưu đồ, biểu đồ Gantt, sơ đồ tuần tự, khuông nhạc, đa phương tiện, đọc văn bản bằng giọng nói, neo tiêu đề, tô sáng và copy mã, render graphviz và sơ đồ UML plantuml.
- Hỗ trợ lưu nội dung cục bộ theo thời gian thực, tự động đồng bộ sau 10s không chỉnh sửa và quay lại lịch sử.

## Các Tính Năng Khác

- Tìm kiếm toàn cục để nhanh chóng tìm và chuyển tới nội dung cụ thể.
- Quản lý lưu trữ hình ảnh giúp quản lý kho ảnh thuận tiện.
- Chủ đề và giao diện với hỗ trợ chế độ tối và cài đặt giao diện Markdown, code, v.v...
- Hỗ trợ đa ngôn ngữ, hiện có tiếng Trung và tiếng Anh.

## Cách Sử Dụng?

### Tải Về

Hiện tại hỗ trợ Mac, Windows và Linux. Nhờ khả năng đa nền tảng của Tauri2, sẽ hỗ trợ iOS và Android trong tương lai.

[Tải NoteGen (alpha)](https://github.com/codexu/note-gen/releases)

### Nâng Cao

Ứng dụng ghi chú có thể sử dụng ngay không cần cấu hình. Nếu bạn muốn trải nghiệm tốt hơn, hãy mở trang cài đặt để cấu hình AI và đồng bộ.

## Đóng Góp

- [Đọc hướng dẫn đóng góp](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [Cập nhật kế hoạch](https://github.com/codexu/note-gen/issues/46)
- [Gửi lỗi hoặc đề xuất cải tiến](https://github.com/codexu/note-gen/issues)
- [Thảo luận](https://github.com/codexu/note-gen/discussions)

## Người Đóng Góp

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Lịch Sử Star

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---