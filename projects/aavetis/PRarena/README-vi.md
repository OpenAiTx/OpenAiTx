### Phân tích PR: Khối lượng vs Tỷ lệ thành công (tự động cập nhật)

Xem [bảng điều khiển tương tác](https://prarena.ai) cho các số liệu thống kê này.

## Hiểu về các chỉ số

Các tác nhân AI lập trình khác nhau tuân theo các quy trình làm việc khác nhau khi tạo pull request:

- **Tất cả PR**: Mọi pull request được tạo bởi một tác nhân, bao gồm cả PR ở trạng thái DRAFT
- **PR sẵn sàng**: Pull request không phải bản nháp, đã sẵn sàng để được xem xét và hợp nhất
- **PR đã hợp nhất**: Pull request đã được hợp nhất thành mã nguồn

**Sự khác biệt chính trong quy trình làm việc**: Một số tác nhân như **Codex** lặp lại riêng tư và tạo PR sẵn sàng trực tiếp, dẫn đến rất ít bản nháp nhưng tỷ lệ hợp nhất cao. Các tác nhân khác như **Copilot** và **Codegen** tạo PR bản nháp trước, khuyến khích việc lặp lại công khai trước khi đánh dấu là sẵn sàng xem xét.

Các số liệu thống kê dưới đây chỉ tập trung vào **PR sẵn sàng** để so sánh công bằng các tác nhân qua các quy trình khác nhau, đo lường khả năng của mỗi tác nhân trong việc tạo ra mã có thể hợp nhất bất kể họ lặp lại công khai (có bản nháp) hay riêng tư.

## Nguồn dữ liệu

Khám phá các truy vấn tìm kiếm GitHub đã sử dụng:



- **Tất cả PR Copilot**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **PR Copilot đã hợp nhất**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **Tất cả PR Codex**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **PR Codex đã hợp nhất**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **Tất cả PR Cursor**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **PR Cursor đã hợp nhất**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **Tất cả PR Devin**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **PR Devin đã hợp nhất**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **Tất cả PR Codegen**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **PR Codegen đã hợp nhất**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## Thống kê hiện tại

| Dự án    | PR sẵn sàng | PR đã hợp nhất | Tỷ lệ thành công |
| -------- | ----------- | -------------- | ---------------- |
| Copilot  | 16,355      | 15,073         | 92.16%           |
| Codex    | 594,884     | 520,690        | 87.53%           |
| Cursor   | 7,474       | 5,560          | 74.39%           |
| Devin    | 29,168      | 19,221         | 65.9%            |
| Codegen  | 2,108       | 1,682          | 79.79%           |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---