# Bộ sưu tập các mẫu `.gitignore`

Đây là bộ sưu tập các mẫu tệp [`.gitignore`][man] của GitHub.
Chúng tôi sử dụng danh sách này để cung cấp các lựa chọn mẫu `.gitignore`
trên giao diện GitHub.com khi tạo kho lưu trữ và tệp mới.

Để biết thêm thông tin về cách hoạt động của các tệp `.gitignore` và cách sử dụng chúng,
các tài nguyên sau đây là điểm khởi đầu tuyệt vời:

- [Chương Bỏ Qua Tệp][chapter] trong cuốn sách [Pro Git][progit].
- [Bài viết Bỏ Qua Tệp][help] trên trang Trợ giúp của GitHub.
- Trang hướng dẫn [gitignore(5)][man].

[man]: https://git-scm.com/docs/gitignore
[help]: https://help.github.com/articles/ignoring-files
[chapter]: https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository#_ignoring
[progit]: https://git-scm.com/book

## Cấu trúc thư mục

Chúng tôi hỗ trợ một bộ sưu tập các mẫu, được tổ chức như sau:

- Thư mục gốc chứa các mẫu được sử dụng phổ biến, giúp người dùng bắt đầu
  với các ngôn ngữ lập trình và công nghệ phổ biến. Những mẫu này định nghĩa một
  tập hợp các quy tắc hữu ích để bắt đầu, và đảm bảo bạn không đưa các tệp không quan trọng
  vào kho lưu trữ của mình.
- [`Global`](./Global) chứa các mẫu cho nhiều trình soạn thảo, công cụ và
  hệ điều hành khác nhau có thể được sử dụng trong các tình huống khác nhau. Khuyến nghị
  rằng bạn nên [thêm các mẫu này vào mẫu toàn cục](https://docs.github.com/en/get-started/getting-started-with-git/ignoring-files#configuring-ignored-files-for-all-repositories-on-your-computer)
  hoặc gộp các quy tắc này vào mẫu riêng cho dự án nếu muốn sử dụng lâu dài.
- [`community`](./community) chứa các mẫu chuyên biệt cho các ngôn ngữ,
  công cụ và dự án phổ biến khác, hiện chưa thuộc về các mẫu chính thống.
  Những mẫu này nên được thêm vào mẫu riêng của dự án khi bạn quyết định sử dụng framework hoặc công cụ đó.

## Một mẫu tốt cần có gì?

Một mẫu nên chứa một tập hợp các quy tắc giúp kho Git hoạt động hiệu quả với một
ngôn ngữ lập trình, framework, công cụ hoặc môi trường cụ thể.

Nếu không thể xây dựng một tập hợp quy tắc hữu ích và gọn gàng cho trường hợp này,
thì mẫu đó không phù hợp với bộ sưu tập này.

Nếu một mẫu chủ yếu là danh sách các tệp được cài đặt bởi một phiên bản phần mềm nào đó
(ví dụ: một framework PHP), nó có thể nằm trong thư mục `community`.
Xem thêm [mẫu theo phiên bản](#versioned-templates) để biết chi tiết.

Nếu bạn có một bộ quy tắc nhỏ, hoặc muốn hỗ trợ một công nghệ chưa được sử dụng rộng rãi,
nhưng vẫn tin rằng điều này sẽ hữu ích cho người khác, vui lòng đọc phần về
[các mẫu chuyên biệt](#specialized-templates) để biết thêm chi tiết.

Hãy ghi rõ chi tiết khi mở pull request nếu mẫu của bạn quan trọng và dễ nhìn thấy.
Chúng tôi có thể chưa chấp nhận ngay, nhưng có thể sẽ đưa lên thư mục gốc sau này
dựa trên mức độ quan tâm.

Xin lưu ý rằng chúng tôi không thể liệt kê mọi công cụ từng tồn tại.
Mục tiêu của chúng tôi là chọn lọc bộ sưu tập các mẫu _phổ biến và hữu ích nhất_,
không phải bao phủ mọi dự án có thể có. Nếu chúng tôi không chọn
ngôn ngữ, công cụ hoặc dự án của bạn, không có nghĩa là nó không tuyệt vời.

## Hướng dẫn đóng góp

Chúng tôi rất hoan nghênh bạn giúp cải thiện dự án này. Để giúp chúng tôi giữ bộ sưu tập
ở chất lượng cao, vui lòng tuân theo các hướng dẫn sau khi đóng góp.

- **Cung cấp liên kết tới trang chủ của ứng dụng hoặc dự án**. Trừ khi nó
  cực kỳ phổ biến, có thể các người duy trì chưa biết hoặc chưa sử dụng
  ngôn ngữ, framework, trình soạn thảo, ứng dụng hoặc dự án mà thay đổi của bạn áp dụng.

- **Cung cấp liên kết tới tài liệu** hỗ trợ cho thay đổi bạn thực hiện.
  Tài liệu hiện tại, chính thống đề cập tới các tệp bị bỏ qua là tốt nhất.
  Nếu không có tài liệu hỗ trợ, hãy cố gắng giải thích rõ các tệp bị bỏ qua dùng để làm gì.

- **Giải thích lý do bạn thực hiện thay đổi**. Dù có vẻ hiển nhiên,
  hãy dành một hai câu để cho chúng tôi biết vì sao thay đổi hoặc bổ sung này nên được thực hiện.
  Đặc biệt hữu ích khi bạn chỉ ra được vì sao thay đổi này áp dụng cho _tất cả_
  những ai làm việc với công nghệ liên quan, thay vì chỉ bạn hoặc nhóm của bạn.

- **Cân nhắc phạm vi thay đổi của bạn**. Nếu thay đổi chỉ áp dụng cho
  một ngôn ngữ hoặc framework nhất định, hãy chắc chắn rằng thay đổi được thực hiện
  trong mẫu của ngôn ngữ hoặc framework đó, thay vì mẫu cho trình soạn thảo, công cụ hoặc hệ điều hành.

- **Chỉ sửa _một mẫu_ cho mỗi pull request**. Điều này giúp pull request và phản hồi
  tập trung vào một dự án hoặc công nghệ cụ thể.

Nhìn chung, bạn càng giúp chúng tôi hiểu rõ hơn về thay đổi bạn thực hiện,
chúng tôi càng dễ dàng chấp nhận đóng góp của bạn một cách nhanh chóng.

## Mẫu theo phiên bản

Một số mẫu có thể thay đổi đáng kể giữa các phiên bản, nếu bạn muốn đóng góp
vào kho lưu trữ này, chúng ta cần tuân theo quy trình sau:

- Mẫu ở thư mục gốc nên là phiên bản hiện được hỗ trợ
- Mẫu ở thư mục gốc không nên có phiên bản trong tên tệp (tức là
  "evergreen")
- Các phiên bản cũ của mẫu nên nằm trong `community/`
- Tên tệp của mẫu phiên bản cũ nên chứa phiên bản để dễ nhận biết

Điều này giúp đảm bảo người dùng nhận được phiên bản mới nhất (vì họ sẽ dùng mẫu ở thư mục gốc)
và giúp người duy trì vẫn hỗ trợ các phiên bản cũ còn sử dụng ngoài thực tế.

## Mẫu chuyên biệt

Nếu bạn có một mẫu muốn đóng góp nhưng chưa thực sự phổ biến, hãy cân nhắc thêm vào thư mục
`community` dưới một thư mục phù hợp nhất với vị trí của nó.

Các quy tắc trong mẫu chuyên biệt của bạn nên dành riêng cho framework hoặc công cụ đó,
và bất kỳ mẫu bổ sung nào nên được nhắc đến trong phần chú thích ở đầu mẫu.

Ví dụ, mẫu này có thể nằm tại `community/DotNet/InforCRM.gitignore`:

```
# gitignore template for InforCRM (formerly SalesLogix)
# website: https://www.infor.com/product-summary/cx/infor-crm/
#
# Recommended: VisualStudio.gitignore

# Ignore model files that are auto-generated
ModelIndex.xml
ExportedFiles.xml

# Ignore deployment files
[Mm]odel/[Dd]eployment

# Force include portal SupportFiles
!Model/Portal/*/SupportFiles/[Bb]in/
!Model/Portal/PortalTemplates/*/SupportFiles/[Bb]in
```

## Quy trình đóng góp

Đây là cách chúng tôi khuyến nghị bạn đề xuất thay đổi cho dự án này:

1. [Fork dự án này][fork] vào tài khoản của bạn.
2. [Tạo một nhánh][branch] cho thay đổi bạn định thực hiện.
3. Thực hiện thay đổi trên fork của bạn.
4. [Gửi pull request][pr] từ nhánh fork của bạn tới nhánh `main` của chúng tôi.

Sử dụng giao diện web để thực hiện thay đổi cũng rất tốt, và sẽ tự động fork dự án cũng như nhắc bạn gửi pull request.

[fork]: https://help.github.com/articles/fork-a-repo/
[branch]: https://help.github.com/articles/creating-and-deleting-branches-within-your-repository
[pr]: https://help.github.com/articles/using-pull-requests/

## Giấy phép

[CC0-1.0](./LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---