# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## .NET Aspire là gì?

.NET Aspire là một stack định hướng, sẵn sàng cho đám mây để xây dựng các ứng dụng phân tán có thể quan sát, sẵn sàng cho sản xuất. .NET Aspire được cung cấp thông qua tập hợp các gói NuGet xử lý các vấn đề cụ thể của ứng dụng gốc đám mây. Ứng dụng gốc đám mây thường bao gồm nhiều thành phần nhỏ, kết nối với nhau hoặc microservices thay vì một mã nguồn đơn lẻ, nguyên khối. Các ứng dụng gốc đám mây thường tiêu thụ một số lượng lớn các dịch vụ, như cơ sở dữ liệu, nhắn tin và bộ nhớ đệm.

.NET Aspire hỗ trợ:

[Dàn nhạc (Orchestration)](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspire cung cấp các tính năng để chạy và kết nối các ứng dụng nhiều dự án và các phụ thuộc của chúng.

[Tích hợp (Integrations)](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): Các tích hợp .NET Aspire là các gói NuGet cho các dịch vụ thường dùng, như Redis hoặc Postgres, với giao diện chuẩn hóa đảm bảo chúng kết nối nhất quán và liền mạch với ứng dụng của bạn.

[Công cụ (Tooling)](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspire đi kèm với các mẫu dự án và trải nghiệm công cụ cho Visual Studio và dotnet CLI giúp bạn tạo và tương tác với các ứng dụng .NET Aspire.

Để tìm hiểu thêm, hãy đọc đầy đủ [tổng quan và tài liệu .NET Aspire](https://learn.microsoft.com/dotnet/aspire/). Các ví dụ có sẵn tại [kho lưu trữ ví dụ .NET Aspire](https://github.com/dotnet/aspire-samples). Bạn có thể tìm ví dụ [eShop tại đây](https://github.com/dotnet/eshop) và phiên bản [Azure tại đây](https://github.com/Azure-Samples/eShopOnAzure).

## Repo này có gì?

Máy chủ ứng dụng .NET Aspire, dashboard, hạ tầng khám phá dịch vụ, và tất cả các tích hợp .NET Aspire. Repo này cũng bao gồm các mẫu dự án.

## Sử dụng bản dựng hàng ngày mới nhất

Làm theo hướng dẫn tại [https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md) để bắt đầu sử dụng .NET Aspire với bản dựng hàng ngày mới nhất.

## Tôi có thể đóng góp như thế nào?

Chúng tôi hoan nghênh mọi đóng góp! Nhiều người trên khắp thế giới đã giúp cải thiện .NET.

Làm theo hướng dẫn tại [https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) để làm việc với mã nguồn trong kho lưu trữ này.

## Báo cáo các vấn đề và lỗi bảo mật

Các vấn đề và lỗi bảo mật nên được báo cáo một cách riêng tư, qua email, tới Microsoft Security Response Center (MSRC) <secure@microsoft.com>. Bạn sẽ nhận được phản hồi trong vòng 24 giờ. Nếu vì lý do nào đó bạn không nhận được phản hồi, vui lòng gửi lại email để đảm bảo chúng tôi đã nhận được tin nhắn gốc của bạn. Thông tin thêm, bao gồm cả khóa PGP của MSRC, có thể được tìm thấy tại [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue). Bạn cũng có thể tìm thấy các hướng dẫn này trong [tài liệu bảo mật](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) của kho lưu trữ này.

Xem thêm thông tin về [Chương trình Bug Bounty cho Microsoft .NET Core và ASP.NET Core](https://www.microsoft.com/msrc/bounty-dot-net-core).

### Lưu ý về các container được sử dụng bởi tích hợp tài nguyên và client của .NET Aspire

Nhóm .NET không thể đánh giá các container bên thứ ba mà chúng tôi hỗ trợ API về mức độ phù hợp với các yêu cầu cụ thể của khách hàng.

Bạn nên tự đánh giá bất kỳ container nào bạn chọn để kết hợp và tự động hóa với Aspire để đảm bảo chúng đáp ứng các yêu cầu về bảo mật, an toàn, quy định mật mã và bất kỳ tiêu chuẩn quy định hoặc doanh nghiệp nào khác có thể áp dụng cho việc sử dụng container của bạn.

## .NET Foundation

.NET Aspire là một dự án của [.NET Foundation](https://www.dotnetfoundation.org/projects).

Có rất nhiều dự án liên quan đến .NET trên GitHub.

* [Repo chính của .NET](https://github.com/Microsoft/dotnet) - liên kết đến hàng trăm dự án .NET, từ Microsoft và cộng đồng.
* [Trang chủ ASP.NET Core](https://docs.microsoft.com/aspnet/core) - nơi tốt nhất để bắt đầu học về ASP.NET Core.

Dự án này đã áp dụng quy tắc ứng xử được định nghĩa bởi [Contributor Covenant](https://contributor-covenant.org) để làm rõ hành vi mong đợi trong cộng đồng của chúng tôi. Để biết thêm thông tin, xem [Quy tắc ứng xử của .NET Foundation](https://www.dotnetfoundation.org/code-of-conduct).

## Giấy phép

Mã nguồn trong repo này được cấp phép theo giấy phép [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---