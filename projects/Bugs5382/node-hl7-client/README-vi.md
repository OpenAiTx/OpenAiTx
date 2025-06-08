# Node HL7 Client

> Một client HL7 thuần TypeScript cho Node.js, cho phép giao tiếp liền mạch với các máy chủ HL7.

`node-hl7-client` là một thư viện nhẹ, không phụ thuộc, được xây dựng để giao tiếp hiệu năng cao với các broker/máy chủ HL7. Thư viện hỗ trợ gửi các thông điệp HL7 được định dạng đúng, xử lý phản hồi, và làm việc với cả định dạng thông điệp HL7 đơn lẻ và theo lô (MSH, BHS và FHS).

## ✨ Tính năng

* ⚡ **Không có Phụ Thuộc Bên Ngoài** – Hiệu năng cực nhanh, không rườm rà.
* 🔁 **Tự Động Kết Nối Lại & Thử Lại** – Tự động xử lý các gián đoạn kết nối.
* 🧠 **TypeScript + Định Nghĩa Kiểu** – Được định kiểu đầy đủ cho các môi trường phát triển hiện đại.
* 🤝 **Có Gói Đi Kèm** – Sử dụng cùng với [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server) để có giải pháp HL7 hoàn chỉnh.
* 💻 **Hỗ Trợ Đa Nền Tảng** – Hoạt động trên Windows, macOS và Linux.
* 🧭 **Dựa Trên Chuẩn** – Các builder được định kiểu đảm bảo các phân đoạn MSH, BHS và FHS tuân thủ các quy định của HL7.org.

## 📦 Cài đặt

```bash
npm install node-hl7-client
```

## 📚 Bao gồm những gì?

* **HL7 Client** – Kết nối tới máy chủ HL7 từ xa, gửi thông điệp và xử lý phản hồi.
* **HL7 Parser** – Phân tích chuỗi thông điệp HL7 thô thành các phân đoạn dễ truy xuất.
* **HL7 Builder** – Xây dựng thông điệp HL7 hợp lệ, lô hoặc các tệp lô HL7 hoàn chỉnh.

## 🧾 Mục lục

1. [Định nghĩa từ khóa](#keyword-definitions)
2. [Tài liệu](#documentation)
3. [Lời cảm ơn](#acknowledgements)
4. [Giấy phép](#license)

## Định nghĩa từ khóa

Gói NPM này được thiết kế để hỗ trợ các ứng dụng y tế có thể ảnh hưởng đến việc chăm sóc và chẩn đoán bệnh nhân. Tài liệu này, cùng với gói đồng cấp [node-hl7-server](https://www.npmjs.com/package/node-hl7-server), sử dụng các định nghĩa chuẩn hóa sau để đảm bảo rõ ràng và khả năng tương tác:

Các từ khóa như **"MUST"** (PHẢI), **"MUST NOT"** (KHÔNG ĐƯỢC), **"REQUIRED"** (BẮT BUỘC), **"SHALL"** (PHẢI), **"SHALL NOT"** (KHÔNG ĐƯỢC), **"SHOULD"** (NÊN), **"SHOULD NOT"** (KHÔNG NÊN), **"RECOMMENDED"** (KHUYẾN NGHỊ), **"MAY"** (CÓ THỂ), và **"OPTIONAL"** (TÙY CHỌN) được sử dụng nhất quán trong toàn bộ tài liệu. Các thuật ngữ này giữ nguyên ý nghĩa kể cả khi không viết hoa.

* **MUST** – Từ này, hoặc các thuật ngữ **"REQUIRED"** hoặc **"SHALL"**, chỉ ra một yêu cầu bắt buộc tuyệt đối của đặc tả.
* **MUST NOT** – Cụm từ này, hoặc **"SHALL NOT"**, chỉ ra một điều bị nghiêm cấm tuyệt đối trong đặc tả.
* **SHOULD** – Từ này, hoặc tính từ **"RECOMMENDED"**, nghĩa là có thể có lý do hợp lệ trong một số trường hợp cụ thể để bỏ qua một mục nào đó, nhưng phải hiểu và cân nhắc kỹ tất cả các hệ quả trước khi làm như vậy.
* **SHOULD NOT** – Cụm từ này, hoặc **"NOT RECOMMENDED"**, nghĩa là có thể có lý do hợp lệ trong một số trường hợp khi hành vi đó là chấp nhận được hoặc thậm chí hữu ích. Cần hiểu rõ tất cả các hệ quả và cân nhắc kỹ trước khi thực hiện.
* **MAY** – Từ này, hoặc tính từ **"OPTIONAL"**, nghĩa là mục đó thực sự là tùy chọn. Các triển khai không bao gồm một tùy chọn cụ thể PHẢI vẫn tương tác được với những triển khai có tùy chọn đó, mặc dù có thể với chức năng bị giảm. Tương tự, các triển khai có tùy chọn PHẢI tương tác được với những triển khai không có (trừ tính năng cụ thể do tùy chọn đó cung cấp).

## 📖 Tài liệu

Tài liệu API đầy đủ, ví dụ sử dụng và cấu hình nâng cao có trên trang dự án:
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 Lời cảm ơn

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – Cảm hứng về logic kết nối.
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – Tham khảo thiết kế cho parser và builder.
* Vợ và con gái nhỏ của tôi – vì tình yêu, sự kiên nhẫn và nguồn cảm hứng.

## 📄 Giấy phép

MIT © [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---