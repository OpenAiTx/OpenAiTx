![Hình ảnh banner](https://user-images.githubusercontent.com/10284570/173569848-c624317f-42b1-45a6-ab09-f0ea3c247648.png)

# n8n - Tự động hóa quy trình làm việc an toàn cho các đội ngũ kỹ thuật

n8n là nền tảng tự động hóa quy trình làm việc mang đến cho các đội ngũ kỹ thuật sự linh hoạt của code cùng với tốc độ của no-code. Với hơn 400 tích hợp, khả năng AI gốc và giấy phép fair-code, n8n cho phép bạn xây dựng các quy trình tự động hóa mạnh mẽ đồng thời duy trì toàn quyền kiểm soát dữ liệu và triển khai của mình.

![n8n.io - Ảnh chụp màn hình](https://raw.githubusercontent.com/n8n-io/n8n/master/assets/n8n-screenshot-readme.png)

## Các tính năng chính

- **Viết mã khi cần thiết**: Viết JavaScript/Python, thêm các gói npm, hoặc sử dụng giao diện trực quan
- **Nền tảng AI gốc**: Xây dựng các quy trình tác tử AI dựa trên LangChain với dữ liệu và mô hình của riêng bạn
- **Toàn quyền kiểm soát**: Tự triển khai với giấy phép fair-code hoặc sử dụng [dịch vụ đám mây](https://app.n8n.cloud/login) của chúng tôi
- **Sẵn sàng cho doanh nghiệp**: Phân quyền nâng cao, SSO và triển khai air-gapped
- **Cộng đồng năng động**: Hơn 400 tích hợp và hơn 900 [mẫu](https://n8n.io/workflows) sẵn sàng sử dụng

## Bắt đầu nhanh

Thử ngay n8n với [npx](https://docs.n8n.io/hosting/installation/npm/) (yêu cầu [Node.js](https://nodejs.org/en/)):

```
npx n8n
```

Hoặc triển khai với [Docker](https://docs.n8n.io/hosting/installation/docker/):

```
docker volume create n8n_data
docker run -it --rm --name n8n -p 5678:5678 -v n8n_data:/home/node/.n8n docker.n8n.io/n8nio/n8n
```

Truy cập trình chỉnh sửa tại http://localhost:5678

## Tài nguyên

- 📚 [Tài liệu hướng dẫn](https://docs.n8n.io)
- 🔧 [400+ Tích hợp](https://n8n.io/integrations)
- 💡 [Quy trình mẫu](https://n8n.io/workflows)
- 🤖 [Hướng dẫn AI & LangChain](https://docs.n8n.io/langchain/)
- 👥 [Diễn đàn cộng đồng](https://community.n8n.io)
- 📖 [Hướng dẫn cộng đồng](https://community.n8n.io/c/tutorials/28)

## Hỗ trợ

Cần trợ giúp? Diễn đàn cộng đồng là nơi để bạn nhận hỗ trợ và kết nối với những người dùng khác:
[community.n8n.io](https://community.n8n.io)

## Giấy phép

n8n là [fair-code](https://faircode.io) được phân phối theo [Giấy phép Sử dụng Bền vững](https://github.com/n8n-io/n8n/blob/master/LICENSE.md) và [Giấy phép Doanh nghiệp n8n](https://github.com/n8n-io/n8n/blob/master/LICENSE_EE.md).

- **Mã nguồn mở**: Luôn minh bạch mã nguồn
- **Tự triển khai**: Triển khai ở bất cứ đâu
- **Có thể mở rộng**: Thêm node và chức năng của riêng bạn

[Các giấy phép doanh nghiệp](mailto:license@n8n.io) có sẵn cho các tính năng và hỗ trợ bổ sung.

Thông tin thêm về mô hình giấy phép có thể xem tại [tài liệu](https://docs.n8n.io/reference/license/).

## Đóng góp

Phát hiện lỗi 🐛 hoặc có ý tưởng tính năng ✨? Xem [Hướng dẫn đóng góp](https://github.com/n8n-io/n8n/blob/master/CONTRIBUTING.md) của chúng tôi để bắt đầu.

## Tham gia đội ngũ

Muốn định hình tương lai của tự động hóa? Xem [các vị trí tuyển dụng](https://n8n.io/careers) và gia nhập đội ngũ của chúng tôi!

## n8n có nghĩa là gì?

**Trả lời ngắn:** Nó có nghĩa là "nodemation" và được phát âm là n-eight-n.

**Trả lời dài:** "Tôi thường nhận được câu hỏi đó (nhiều hơn tôi nghĩ) nên tôi quyết định trả lời luôn ở đây. Khi tìm kiếm một cái tên phù hợp cho dự án với domain còn trống, tôi nhận ra rất nhanh rằng tất cả những cái tên hay tôi nghĩ ra đều đã bị lấy mất. Cuối cùng, tôi chọn nodemation. 'node-' ở đây vì nó sử dụng Node-View và Node.js, còn '-mation' là từ 'automation', đúng với mục đích của dự án. Tuy nhiên, tôi không thích tên dài như vậy và cũng không muốn phải gõ một cái tên dài mỗi lần trên CLI. Đó là lý do tôi chọn 'n8n'." - **Jan Oberhauser, Nhà sáng lập & CEO, n8n.io**

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---