# TypeScript 7

[Không chắc đây là gì? Đọc bài đăng thông báo!](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## Bản xem trước

Bản dựng xem trước có sẵn trên npm dưới tên `@typescript/native-preview`.

```sh
npm install @typescript/native-preview
npx tsgo # Sử dụng như bạn dùng tsc.
```

Tiện ích mở rộng VS Code bản xem trước [có sẵn trên VS Code marketplace](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview).

Để sử dụng, hãy thiết lập trong cài đặt VS Code của bạn như sau:

```json
{
    "typescript.experimental.useTsgo": true
}
```

## Cách xây dựng và chạy

Kho lưu trữ này sử dụng [Go 1.24 hoặc cao hơn](https://go.dev/dl/), [Rust 1.85 hoặc cao hơn](https://www.rust-lang.org/tools/install), [Node.js với npm](https://nodejs.org/), và [`hereby`](https://www.npmjs.com/package/hereby).

Đối với kiểm thử và sinh mã, kho này chứa một git submodule tới kho TypeScript chính, trỏ tới commit đang được chuyển đổi.
Khi nhân bản, bạn nên nhân bản kèm theo submodule:

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

Nếu bạn đã nhân bản kho trước đó, bạn có thể khởi tạo submodule bằng:

```sh
git submodule update --init --recursive
```

Khi đã có submodule và chạy `npm ci`, bạn có thể chạy các tác vụ qua `hereby`, tương tự như kho TypeScript:

```sh
hereby build          # Kiểm tra dự án có thể biên dịch
hereby test           # Chạy tất cả kiểm thử
hereby install-tools  # Cài đặt các công cụ bổ sung như linters
hereby lint           # Chạy tất cả linters
hereby format         # Định dạng toàn bộ mã nguồn
hereby generate       # Sinh toàn bộ mã Go (ví dụ: diagnostics, đã cam kết vào repo)
```

Các tác vụ bổ sung đang được phát triển.

`hereby` không bắt buộc để làm việc với kho này; các công cụ `go` thông thường (ví dụ: `go build`, `go test ./...`) sẽ hoạt động như mong đợi.
Các tác vụ `hereby` được cung cấp như một tiện ích cho những ai quen thuộc với kho TypeScript.

### Chạy `tsgo`

Sau khi chạy `hereby build`, bạn có thể chạy `built/local/tsgo`, hoạt động tương tự như `tsc`.

### Chạy thử nghiệm LSP Prototype

Để debug và chạy tiện ích mở rộng VS Code mà không cần cài đặt toàn cục:

* Chạy VS Code trong workspace của kho (`code .`)
* Sao chép `.vscode/launch.template.json` thành `.vscode/launch.json`
* <kbd>F5</kbd> (hoặc `Debug: Start Debugging` từ command palette)

Điều này sẽ khởi động một phiên bản VS Code mới sử dụng Corsa LS làm backend. Nếu thiết lập đúng, bạn sẽ thấy "tsgo" trên thanh trạng thái khi mở một tệp TypeScript hoặc JavaScript:

![LSP Prototype Screenshot](https://raw.githubusercontent.com/microsoft/typescript-go/main/.github/ls-screenshot.png)


## Những gì đã hoạt động đến hiện tại?

Đây vẫn là một dự án đang phát triển và chưa đạt đầy đủ tính năng như TypeScript. Có thể vẫn còn lỗi. Vui lòng kiểm tra danh sách này kỹ trước khi báo cáo lỗi mới hoặc cho rằng có thay đổi có chủ đích.

| Tính năng | Trạng thái | Ghi chú |
|-----------|------------|--------|
| Tạo chương trình | xong | Cùng tệp và giải quyết module như TS5.8. Chưa hỗ trợ đầy đủ mọi chế độ giải quyết. |
| Phân tích cú pháp/ quét | xong | Lỗi cú pháp giống hệt TS5.8 |
| Dòng lệnh và phân tích `tsconfig.json` | gần xong | Điểm vào hơi khác hiện tại |
| Giải quyết kiểu | xong | Kiểu giống TS5.8 |
| Kiểm tra kiểu | xong | Lỗi, vị trí, thông báo giống TS5.8. In kiểu trong lỗi có thể khác (đang phát triển) |
| Suy luận riêng cho JavaScript và JS Doc | chưa sẵn sàng | - |
| JSX | xong | - |
| Sinh khai báo | đang phát triển | Hầu hết tính năng phổ biến đã có, nhưng một số trường hợp đặc biệt và cờ tính năng chưa xử lý |
| Xuất bản (JS output) | đang phát triển | `target: esnext` được hỗ trợ tốt, các target khác có thể còn thiếu sót |
| Chế độ theo dõi | nguyên mẫu | Theo dõi tệp và xây lại, chưa kiểm tra lại từng phần |
| Chế độ build / tham chiếu dự án | chưa sẵn sàng | - |
| Build từng phần | chưa sẵn sàng | - |
| Dịch vụ ngôn ngữ (LSP) | nguyên mẫu | Chức năng tối thiểu (lỗi, hover, go to def). Sẽ sớm có thêm tính năng |
| API | chưa sẵn sàng | - |

Định nghĩa:

 * **xong** hay "tin đã xong": Hiện không biết còn thiếu sót lớn nào. Có thể báo lỗi
 * **đang phát triển**: đang được phát triển; có thể một số tính năng hoạt động, một số không. Có thể báo lỗi panic, các lỗi khác xin đừng báo
 * **nguyên mẫu**: chỉ là bản thử nghiệm; không báo lỗi
 * **chưa sẵn sàng**: chưa bắt đầu, hoặc còn xa mới sẵn sàng, không nên thử

## Ghi chú khác

Về lâu dài, chúng tôi dự kiến kho này và nội dung sẽ được hợp nhất vào `microsoft/TypeScript`.
Do đó, kho và trình theo dõi vấn đề của typescript-go cuối cùng sẽ đóng lại, hãy trao đổi/vấn đề phù hợp.

Xem danh sách thay đổi có chủ đích so với TypeScript 5.7 tại CHANGES.md.

## Đóng góp

Dự án này hoan nghênh mọi đóng góp và đề xuất.  Hầu hết các đóng góp yêu cầu bạn đồng ý với
Thỏa thuận cấp phép cho người đóng góp (CLA) xác nhận bạn có quyền, và thực sự, cấp quyền cho chúng tôi
sử dụng đóng góp của bạn. Xem chi tiết tại [Contributor License Agreements](https://cla.opensource.microsoft.com).

Khi bạn gửi pull request, một bot CLA sẽ tự động xác định liệu bạn có cần ký CLA không và đánh dấu PR tương ứng (ví dụ, kiểm tra trạng thái, bình luận). Chỉ cần làm theo hướng dẫn
do bot cung cấp. Bạn chỉ cần làm việc này một lần cho tất cả các kho dùng CLA của chúng tôi.

Dự án này đã áp dụng [Bộ quy tắc ứng xử mã nguồn mở của Microsoft](https://opensource.microsoft.com/codeofconduct/).
Để biết thêm thông tin, xem [Câu hỏi thường gặp về Quy tắc ứng xử](https://opensource.microsoft.com/codeofconduct/faq/) hoặc
liên hệ [opencode@microsoft.com](mailto:opencode@microsoft.com) nếu có câu hỏi hoặc nhận xét bổ sung.

## Nhãn hiệu

Dự án này có thể chứa nhãn hiệu hoặc logo của các dự án, sản phẩm hoặc dịch vụ. Việc sử dụng hợp pháp nhãn hiệu hoặc logo của Microsoft phải tuân thủ và làm theo
[Hướng dẫn sử dụng Nhãn hiệu & Thương hiệu của Microsoft](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general).
Việc sử dụng nhãn hiệu hoặc logo Microsoft trong phiên bản đã chỉnh sửa của dự án này không được gây nhầm lẫn hoặc ngụ ý được Microsoft tài trợ.
Việc sử dụng nhãn hiệu hoặc logo của bên thứ ba phải tuân thủ chính sách của bên thứ ba đó.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---