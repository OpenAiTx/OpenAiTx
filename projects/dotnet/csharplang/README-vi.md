# Thiết Kế Ngôn Ngữ C#

[![Tham gia trò chuyện tại https://gitter.im/dotnet/csharplang](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Trò chuyện trên Discord](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

Chào mừng bạn đến với kho lưu trữ chính thức cho thiết kế ngôn ngữ C#. Đây là nơi các tính năng mới của ngôn ngữ C# được phát triển, chấp nhận và đặc tả.

C# được thiết kế bởi Nhóm Thiết Kế Ngôn Ngữ C# (LDT) phối hợp chặt chẽ với dự án [Roslyn](https://github.com/dotnet/roslyn), dự án triển khai ngôn ngữ này.

Bạn có thể tìm thấy:

- Các đề xuất tính năng ngôn ngữ C# đang hoạt động trong [thư mục proposals](proposals)
- Ghi chú từ các cuộc họp thiết kế ngôn ngữ C# trong [thư mục meetings](meetings)
- Tổng hợp [lịch sử phiên bản ngôn ngữ tại đây](Language-Version-History.md).

Nếu bạn phát hiện lỗi hoặc thiếu sót trong các mục trên, vui lòng để lại một issue để báo cáo, hoặc tốt hơn nữa: gửi một pull request để sửa lỗi đó.

Tuy nhiên, với *đề xuất tính năng mới*, vui lòng đưa ra để [thảo luận](https://github.com/dotnet/csharplang/labels/Discussion), và *chỉ* gửi đề xuất dưới dạng issue hoặc pull request nếu được một thành viên Nhóm Thiết Kế Ngôn Ngữ (gọi là "champion") mời làm như vậy.

Toàn bộ quy trình thiết kế được mô tả [tại đây](Design-Process.md). Dưới đây là tổng quan ngắn hơn.

## Thảo luận

Các cuộc tranh luận liên quan đến các tính năng ngôn ngữ được tiến hành dưới hình thức [Discussions](https://github.com/dotnet/csharplang/discussions) trong kho lưu trữ này.

Nếu bạn muốn đề xuất một tính năng, thảo luận về các ghi chú thiết kế hiện tại hoặc các đề xuất, v.v., vui lòng [mở một chủ đề Thảo luận mới](https://github.com/dotnet/csharplang/discussions/new).

Các cuộc thảo luận ngắn gọn và bám sát chủ đề sẽ có nhiều khả năng được đọc hơn. Nếu bạn là người bình luận thứ năm mươi, khả năng cao chỉ có một số ít người sẽ đọc nó. Để các cuộc thảo luận dễ theo dõi và hữu ích hơn, vui lòng tuân thủ một số nguyên tắc:

- Thảo luận nên liên quan đến thiết kế ngôn ngữ C#. Nếu không, chúng sẽ bị đóng ngay lập tức.
- Chọn chủ đề mô tả rõ ràng phạm vi của cuộc thảo luận.
- Bám sát chủ đề của cuộc thảo luận. Nếu một bình luận bị lệch chủ đề, hoặc đi sâu vào một chủ đề phụ, hãy bắt đầu một cuộc thảo luận mới và liên kết lại.
- Ý kiến của bạn có hữu ích cho người khác không, hay có thể thể hiện đầy đủ bằng một biểu cảm emoji cho một bình luận đã có?

Các đề xuất ngôn ngữ nhằm ngăn chặn cú pháp cụ thể có thể được thực hiện bằng một [trình phân tích Roslyn](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers). Những đề xuất chỉ biến cú pháp hiện tại thành bất hợp pháp một cách tuỳ chọn sẽ bị từ chối bởi uỷ ban thiết kế ngôn ngữ để tránh tăng độ phức tạp của ngôn ngữ.

## Đề xuất

Khi một thành viên của C# LDM nhận thấy một đề xuất xứng đáng được xem xét rộng rãi hơn, họ có thể [Champion](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22) nó, tức là họ sẽ đưa nó đến Cuộc họp Thiết kế Ngôn ngữ C#. Các đề xuất luôn được thảo luận trong các cuộc thảo luận liên kết, không phải trong issue champion. Trước đây chúng tôi không luôn tuân theo chính sách này, vì vậy nhiều issue champion vẫn còn thảo luận trong đó; hiện tại chúng tôi khoá các issue để ngăn thảo luận mới xảy ra. Mỗi issue champion sẽ có liên kết tới cuộc thảo luận của nó.

## Quy trình Thiết kế

Các [đề xuất](proposals) phát triển dựa trên các quyết định trong [các Cuộc họp Thiết kế Ngôn ngữ](meetings), được thông báo bởi [các cuộc thảo luận](https://github.com/dotnet/csharplang/discussions), các thử nghiệm và công việc thiết kế offline.

Trong nhiều trường hợp, cần phải triển khai và chia sẻ một nguyên mẫu của tính năng để đi đến thiết kế phù hợp, và cuối cùng quyết định có chấp nhận tính năng đó hay không. Nguyên mẫu giúp phát hiện cả vấn đề về triển khai và tính khả dụng của tính năng. Một nguyên mẫu nên được triển khai trong một nhánh của [repo Roslyn](https://github.com/dotnet/roslyn) và đáp ứng các tiêu chí sau:

- Phân tích cú pháp (nếu áp dụng) phải đủ bền bỉ để thử nghiệm: việc gõ không được gây ra sự cố.
- Bao gồm các kiểm thử tối thiểu chứng minh tính năng hoạt động từ đầu đến cuối.
- Bao gồm hỗ trợ IDE tối thiểu (tô màu từ khoá, định dạng, gợi ý hoàn thành).

Khi được phê duyệt, một tính năng nên được triển khai đầy đủ trong [Roslyn](https://github.com/dotnet/roslyn), và được đặc tả đầy đủ trong [đặc tả ngôn ngữ](spec), sau đó đề xuất sẽ được chuyển vào thư mục phù hợp cho tính năng đã hoàn thành, ví dụ [đề xuất C# 7.1](proposals/csharp-7.1).

**TUYÊN BỐ MIỄN TRỪ**: Một đề xuất đang hoạt động là đang được xem xét để đưa vào một phiên bản tương lai của ngôn ngữ lập trình C#, nhưng không đảm bảo sẽ được bao gồm trong phiên bản tiếp theo hoặc bất kỳ phiên bản nào của ngôn ngữ. Đề xuất có thể bị hoãn lại hoặc từ chối bất kỳ lúc nào trong bất kỳ giai đoạn nào của quy trình trên dựa trên phản hồi từ nhóm thiết kế, cộng đồng, người kiểm tra mã hoặc kiểm thử.

### Các cột mốc

Chúng tôi có một số cột mốc khác nhau cho các issue trên repo:
* [Working Set](https://github.com/dotnet/csharplang/milestone/19) là tập hợp các đề xuất đã được champion và đang được làm việc tích cực. Không phải tất cả trong cột mốc này sẽ có mặt trong phiên bản tiếp theo của C#, nhưng chúng sẽ được dành thời gian thiết kế trong đợt phát hành sắp tới.
* [Backlog](https://github.com/dotnet/csharplang/milestone/10) là tập hợp các đề xuất đã được champion và đã được phân loại, nhưng chưa được làm việc tích cực. Dù cộng đồng được khuyến khích thảo luận và đóng góp ý tưởng cho các đề xuất này, chi phí cho công việc thiết kế và đánh giá việc triển khai các tính năng này là quá cao để chúng tôi xem xét thực hiện bởi cộng đồng cho đến khi chúng tôi sẵn sàng.
* [Any Time](https://github.com/dotnet/csharplang/milestone/14) là tập hợp các đề xuất đã được champion và đã được phân loại, nhưng chưa được làm việc tích cực và mở cho cộng đồng triển khai. Các issue này có thể ở một trong hai trạng thái: cần bản đặc tả được phê duyệt và cần triển khai. Những đề xuất cần bản đặc tả vẫn cần được trình bày tại LDM để phê duyệt, nhưng chúng tôi sẵn sàng dành thời gian cho việc đó khi thuận tiện nhất.
* [Likely Never](https://github.com/dotnet/csharplang/milestone/13) là tập hợp các đề xuất mà LDM đã từ chối khỏi ngôn ngữ. Nếu không có nhu cầu mạnh mẽ hoặc phản hồi từ cộng đồng, các đề xuất này sẽ không được xem xét trong tương lai.
* Các cột mốc được đánh số là tập hợp các tính năng đã được triển khai cho phiên bản ngôn ngữ cụ thể đó. Với các cột mốc đã đóng, đây là tập hợp các tính năng đã được phát hành cùng với bản phát hành đó. Với các cột mốc đang mở, các tính năng có thể bị rút lại sau đó nếu chúng tôi phát hiện vấn đề về tương thích hoặc các vấn đề khác khi gần đến ngày phát hành.

## Các cuộc họp Thiết kế Ngôn ngữ

Các cuộc họp Thiết kế Ngôn ngữ (LDMs) được tổ chức bởi LDT và các khách mời không thường xuyên, và được ghi lại trong Ghi chú Cuộc họp Thiết kế trong thư mục [meetings](meetings), được tổ chức theo thư mục theo năm. Vòng đời của một ghi chú cuộc họp thiết kế được mô tả trong [meetings/README.md](meetings/README.md). LDM là nơi đưa ra các quyết định về các phiên bản C# tương lai, bao gồm các đề xuất nào sẽ được làm, làm thế nào để phát triển các đề xuất đó, và có nên hoặc khi nào nên áp dụng chúng.

## Đặc tả Ngôn ngữ

Đặc tả ECMA-334 hiện tại có thể được tìm thấy dưới dạng markdown trên kho lưu trữ [C# Language Standard](https://github.com/dotnet/csharpstandard/).

## Triển khai

Triển khai tham chiếu của ngôn ngữ C# có thể được tìm thấy trong [kho lưu trữ Roslyn](https://github.com/dotnet/roslyn). Kho lưu trữ này cũng theo dõi [trạng thái triển khai các tính năng ngôn ngữ](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md). Cho đến gần đây, đây cũng là nơi lưu trữ các tài liệu thiết kế ngôn ngữ. Vui lòng đợi một thời gian ngắn trong khi chúng tôi chuyển các đề xuất hoạt động sang nơi mới.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---