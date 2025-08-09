*[English](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README.md) ∙ [日本語](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-ja.md) ∙ [简体中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-Hans.md) ∙ [繁體中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-TW.md) | [العَرَبِيَّة‎](https://github.com/donnemartin/system-design-primer/issues/170) ∙ [বাংলা](https://github.com/donnemartin/system-design-primer/issues/220) ∙ [Português do Brasil](https://github.com/donnemartin/system-design-primer/issues/40) ∙ [Deutsch](https://github.com/donnemartin/system-design-primer/issues/186) ∙ [ελληνικά](https://github.com/donnemartin/system-design-primer/issues/130) ∙ [עברית](https://github.com/donnemartin/system-design-primer/issues/272) ∙ [Italiano](https://github.com/donnemartin/system-design-primer/issues/104) ∙ [한국어](https://github.com/donnemartin/system-design-primer/issues/102) ∙ [فارسی](https://github.com/donnemartin/system-design-primer/issues/110) ∙ [Polski](https://github.com/donnemartin/system-design-primer/issues/68) ∙ [русский язык](https://github.com/donnemartin/system-design-primer/issues/87) ∙ [Español](https://github.com/donnemartin/system-design-primer/issues/136) ∙ [ภาษาไทย](https://github.com/donnemartin/system-design-primer/issues/187) ∙ [Türkçe](https://github.com/donnemartin/system-design-primer/issues/39) ∙ [tiếng Việt](https://github.com/donnemartin/system-design-primer/issues/127) ∙ [Français](https://github.com/donnemartin/system-design-primer/issues/250) | [Add Translation](https://github.com/donnemartin/system-design-primer/issues/28)*

**Hãy [dịch](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/TRANSLATIONS.md) hướng dẫn này!**

# Hướng Dẫn Thiết Kế Hệ Thống

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png">
  <br/>
</p>

## Động lực

> Học cách thiết kế các hệ thống quy mô lớn.
>
> Chuẩn bị cho phỏng vấn thiết kế hệ thống.

### Học cách thiết kế hệ thống quy mô lớn

Học cách thiết kế các hệ thống có khả năng mở rộng sẽ giúp bạn trở thành một kỹ sư giỏi hơn.

Thiết kế hệ thống là một chủ đề rộng. Có **rất nhiều tài nguyên phân tán trên web** về các nguyên tắc thiết kế hệ thống.

Kho lưu trữ này là một **bộ sưu tập tổ chức** các tài nguyên để giúp bạn học cách xây dựng hệ thống ở quy mô lớn.

### Học hỏi từ cộng đồng mã nguồn mở

Đây là một dự án mã nguồn mở, được cập nhật liên tục.

[Đóng góp](#contributing) luôn được hoan nghênh!

### Chuẩn bị cho phỏng vấn thiết kế hệ thống

Bên cạnh các cuộc phỏng vấn lập trình, thiết kế hệ thống là một **thành phần bắt buộc** trong **quy trình phỏng vấn kỹ thuật** tại nhiều công ty công nghệ.

**Thực hành các câu hỏi phỏng vấn thiết kế hệ thống phổ biến** và **so sánh** kết quả của bạn với **các giải pháp mẫu**: thảo luận, mã nguồn và sơ đồ.

Các chủ đề bổ sung để chuẩn bị phỏng vấn:

* [Hướng dẫn học tập](#study-guide)
* [Cách tiếp cận một câu hỏi phỏng vấn thiết kế hệ thống](#how-to-approach-a-system-design-interview-question)
* [Các câu hỏi phỏng vấn thiết kế hệ thống, **có giải pháp**](#system-design-interview-questions-with-solutions)
* [Các câu hỏi phỏng vấn thiết kế hướng đối tượng, **có giải pháp**](#object-oriented-design-interview-questions-with-solutions)
* [Các câu hỏi phỏng vấn thiết kế hệ thống bổ sung](#additional-system-design-interview-questions)

## Thẻ ghi nhớ Anki

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/zdCAkB3.png">
  <br/>
</p>

Bộ thẻ ghi nhớ [Anki](https://apps.ankiweb.net/) được cung cấp sử dụng phương pháp lặp lại ngắt quãng giúp bạn ghi nhớ các khái niệm thiết kế hệ thống quan trọng.

* [Bộ thẻ thiết kế hệ thống](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design.apkg)
* [Bộ thẻ bài tập thiết kế hệ thống](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design%20Exercises.apkg)
* [Bộ thẻ bài tập thiết kế hướng đối tượng](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/OO%20Design.apkg)

Rất tiện lợi khi sử dụng lúc di chuyển.

### Tài nguyên lập trình: Thử thách Lập trình Tương tác

Bạn đang tìm kiếm tài nguyên để luyện tập cho [**Phỏng vấn Lập trình**](https://github.com/donnemartin/interactive-coding-challenges)?

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/b4YtAEN.png">
  <br/>
</p>

Hãy xem kho lưu trữ chị em [**Thử thách Lập trình Tương tác**](https://github.com/donnemartin/interactive-coding-challenges), trong đó có thêm một bộ thẻ Anki:

* [Bộ thẻ lập trình](https://github.com/donnemartin/interactive-coding-challenges/tree/master/anki_cards/Coding.apkg)

## Đóng góp

> Học hỏi từ cộng đồng.

Bạn hoàn toàn có thể gửi pull request để giúp:

* Sửa lỗi
* Cải thiện các phần
* Thêm các mục mới
* [Dịch](https://github.com/donnemartin/system-design-primer/issues/28)

Nội dung cần hoàn thiện thêm được đặt [đang phát triển](#under-development).

Xem lại [Hướng dẫn đóng góp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/CONTRIBUTING.md).

## Mục lục các chủ đề thiết kế hệ thống

> Tóm tắt các chủ đề thiết kế hệ thống khác nhau, bao gồm ưu và nhược điểm. **Mọi thứ đều là sự đánh đổi**.
>
> Mỗi mục đều có liên kết đến các tài liệu chuyên sâu hơn.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png">
  <br/>
</p>

* [Chủ đề thiết kế hệ thống: bắt đầu tại đây](#system-design-topics-start-here)
    * [Bước 1: Xem lại bài giảng video về khả năng mở rộng](#step-1-review-the-scalability-video-lecture)
    * [Bước 2: Xem lại bài viết về khả năng mở rộng](#step-2-review-the-scalability-article)
    * [Các bước tiếp theo](#next-steps)
* [Hiệu năng so với khả năng mở rộng](#performance-vs-scalability)
* [Độ trễ so với thông lượng](#latency-vs-throughput)
* [Khả dụng so với tính nhất quán](#availability-vs-consistency)
    * [Định lý CAP](#cap-theorem)
        * [CP - tính nhất quán và chịu phân vùng](#cp---consistency-and-partition-tolerance)
        * [AP - khả dụng và chịu phân vùng](#ap---availability-and-partition-tolerance)
* [Các mẫu nhất quán](#consistency-patterns)
    * [Nhất quán yếu](#weak-consistency)
    * [Nhất quán cuối cùng](#eventual-consistency)
    * [Nhất quán mạnh](#strong-consistency)
* [Các mẫu khả dụng](#availability-patterns)
    * [Chuyển đổi dự phòng](#fail-over)
    * [Sao chép dữ liệu](#replication)
    * [Khả dụng theo các con số](#availability-in-numbers)
* [Hệ thống tên miền](#domain-name-system)
* [Mạng phân phối nội dung](#content-delivery-network)
    * [Push CDN](#push-cdns)
    * [Pull CDN](#pull-cdns)
* [Bộ cân bằng tải](#load-balancer)
    * [Hoạt động chủ động - bị động](#active-passive)
    * [Hoạt động chủ động - chủ động](#active-active)
    * [Cân bằng tải tầng 4](#layer-4-load-balancing)
    * [Cân bằng tải tầng 7](#layer-7-load-balancing)
    * [Mở rộng theo chiều ngang](#horizontal-scaling)
* [Proxy đảo chiều (máy chủ web)](#reverse-proxy-web-server)
    * [Bộ cân bằng tải vs proxy đảo chiều](#load-balancer-vs-reverse-proxy)
* [Tầng ứng dụng](#application-layer)
    * [Kiến trúc vi dịch vụ](#microservices)
    * [Khám phá dịch vụ](#service-discovery)
* [Cơ sở dữ liệu](#database)
    * [Hệ quản trị cơ sở dữ liệu quan hệ (RDBMS)](#relational-database-management-system-rdbms)
        * [Sao chép chủ-tớ](#master-slave-replication)
        * [Sao chép chủ-chủ](#master-master-replication)
        * [Liên kết liên bang](#federation)
        * [Phân mảnh dữ liệu](#sharding)
        * [Phi chuẩn hóa dữ liệu](#denormalization)
        * [Tối ưu hóa SQL](#sql-tuning)
    * [NoSQL](#nosql)
        * [Lưu trữ dạng khóa-giá trị](#key-value-store)
        * [Lưu trữ tài liệu](#document-store)
        * [Lưu trữ cột rộng](#wide-column-store)
        * [Cơ sở dữ liệu đồ thị](#graph-database)
    * [SQL hay NoSQL](#sql-or-nosql)
* [Bộ nhớ đệm](#cache)
    * [Bộ nhớ đệm phía khách hàng](#client-caching)
    * [Bộ nhớ đệm CDN](#cdn-caching)
    * [Bộ nhớ đệm máy chủ web](#web-server-caching)
    * [Bộ nhớ đệm cơ sở dữ liệu](#database-caching)
    * [Bộ nhớ đệm ứng dụng](#application-caching)
    * [Bộ nhớ đệm ở mức truy vấn cơ sở dữ liệu](#caching-at-the-database-query-level)
    * [Bộ nhớ đệm ở mức đối tượng](#caching-at-the-object-level)
    * [Khi nào cập nhật bộ nhớ đệm](#when-to-update-the-cache)
        * [Cache-aside](#cache-aside)
        * [Ghi-thẳng](#write-through)
        * [Ghi-ngầm (ghi-lại)](#write-behind-write-back)
        * [Làm mới trước](#refresh-ahead)
* [Tính phi đồng bộ](#asynchronism)
    * [Hàng đợi tin nhắn](#message-queues)
    * [Hàng đợi tác vụ](#task-queues)
    * [Áp lực ngược](#back-pressure)
* [Giao tiếp](#communication)
    * [Giao thức điều khiển truyền tải (TCP)](#transmission-control-protocol-tcp)
    * [Giao thức datagram người dùng (UDP)](#user-datagram-protocol-udp)
    * [Gọi thủ tục từ xa (RPC)](#remote-procedure-call-rpc)
    * [Chuyển trạng thái đại diện (REST)](#representational-state-transfer-rest)
* [Bảo mật](#security)
* [Phụ lục](#appendix)
    * [Bảng lũy thừa của hai](#powers-of-two-table)
    * [Các số liệu độ trễ mà mọi lập trình viên nên biết](#latency-numbers-every-programmer-should-know)
    * [Các câu hỏi phỏng vấn thiết kế hệ thống bổ sung](#additional-system-design-interview-questions)
    * [Kiến trúc thực tế](#real-world-architectures)
    * [Kiến trúc công ty](#company-architectures)
    * [Blog kỹ thuật công ty](#company-engineering-blogs)
* [Đang phát triển](#under-development)
* [Ghi nhận](#credits)
* [Thông tin liên hệ](#contact-info)
* [Giấy phép](#license)

## Hướng dẫn học tập

> Các chủ đề gợi ý để ôn tập dựa trên thời gian phỏng vấn của bạn (ngắn, trung bình, dài).

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/OfVllex.png)

**Q: Để phỏng vấn, tôi có cần biết tất cả mọi thứ ở đây không?**

**A: Không, bạn không cần phải biết tất cả mọi thứ ở đây để chuẩn bị cho buổi phỏng vấn**.

Những gì bạn được hỏi trong buổi phỏng vấn phụ thuộc vào các biến số như:

* Bạn có bao nhiêu kinh nghiệm
* Nền tảng kỹ thuật của bạn là gì
* Bạn đang phỏng vấn cho vị trí nào
* Bạn đang phỏng vấn với công ty nào
* May mắn

Các ứng viên có kinh nghiệm thường được kỳ vọng biết nhiều hơn về thiết kế hệ thống.  Kiến trúc sư hoặc trưởng nhóm có thể được yêu cầu biết nhiều hơn các thành viên cá nhân.  Các công ty công nghệ hàng đầu thường có một hoặc nhiều vòng phỏng vấn về thiết kế.

Bắt đầu từ tổng quan và đi sâu vào một vài lĩnh vực nhất định. Việc biết một chút về các chủ đề thiết kế hệ thống quan trọng sẽ rất hữu ích. Điều chỉnh hướng dẫn dưới đây dựa trên thời gian, kinh nghiệm, vị trí bạn đang phỏng vấn và công ty bạn ứng tuyển.

* **Thời gian ngắn** - Nhắm đến **độ rộng** với các chủ đề thiết kế hệ thống. Luyện tập bằng cách giải **một số** câu hỏi phỏng vấn.
* **Thời gian trung bình** - Nhắm đến **độ rộng** và **một số chiều sâu** với các chủ đề thiết kế hệ thống. Luyện tập bằng cách giải **nhiều** câu hỏi phỏng vấn.
* **Thời gian dài** - Nhắm đến **độ rộng** và **nhiều chiều sâu hơn** với các chủ đề thiết kế hệ thống. Luyện tập bằng cách giải **hầu hết** các câu hỏi phỏng vấn.

| | Ngắn | Trung bình | Dài |
|---|---|---|---|
| Đọc qua [Các chủ đề thiết kế hệ thống](#index-of-system-design-topics) để hiểu tổng quan về cách hệ thống hoạt động | :+1: | :+1: | :+1: |
| Đọc một vài bài viết trong [Blog kỹ thuật của công ty](#company-engineering-blogs) tại các công ty bạn đang ứng tuyển | :+1: | :+1: | :+1: |
| Đọc qua một số [Kiến trúc thực tế](#real-world-architectures) | :+1: | :+1: | :+1: |
| Xem lại [Cách tiếp cận câu hỏi phỏng vấn thiết kế hệ thống](#how-to-approach-a-system-design-interview-question) | :+1: | :+1: | :+1: |
| Giải [Câu hỏi phỏng vấn thiết kế hệ thống có đáp án](#system-design-interview-questions-with-solutions) | Một số | Nhiều | Hầu hết |
| Giải [Câu hỏi phỏng vấn thiết kế hướng đối tượng có đáp án](#object-oriented-design-interview-questions-with-solutions) | Một số | Nhiều | Hầu hết |
| Xem lại [Câu hỏi phỏng vấn thiết kế hệ thống bổ sung](#additional-system-design-interview-questions) | Một số | Nhiều | Hầu hết |

## Cách tiếp cận câu hỏi phỏng vấn thiết kế hệ thống

> Cách giải quyết một câu hỏi phỏng vấn thiết kế hệ thống.

Phỏng vấn thiết kế hệ thống là một **cuộc trò chuyện mở**. Bạn được mong đợi sẽ dẫn dắt buổi phỏng vấn.

Bạn có thể sử dụng các bước sau để định hướng cuộc thảo luận. Để củng cố quy trình này, hãy luyện tập với [Câu hỏi phỏng vấn thiết kế hệ thống có đáp án](#system-design-interview-questions-with-solutions) sử dụng các bước sau.

### Bước 1: Phác thảo các trường hợp sử dụng, ràng buộc, và giả định

Thu thập yêu cầu và xác định phạm vi vấn đề. Đặt câu hỏi để làm rõ trường hợp sử dụng và các ràng buộc. Thảo luận về các giả định.

* Ai sẽ sử dụng nó?
* Họ sẽ sử dụng nó như thế nào?
* Có bao nhiêu người dùng?
* Hệ thống sẽ làm gì?
* Đầu vào và đầu ra của hệ thống là gì?
* Dự kiến sẽ xử lý bao nhiêu dữ liệu?
* Dự kiến có bao nhiêu yêu cầu mỗi giây?
* Tỷ lệ đọc/ghi dự kiến là bao nhiêu?

### Bước 2: Tạo thiết kế cấp cao

Phác thảo thiết kế tổng quan với tất cả các thành phần quan trọng.

* Phác thảo các thành phần chính và kết nối
* Giải thích lý do cho các ý tưởng của bạn

### Bước 3: Thiết kế các thành phần cốt lõi

Đi sâu vào chi tiết cho từng thành phần cốt lõi. Ví dụ, nếu bạn được yêu cầu [thiết kế dịch vụ rút gọn url](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md), hãy thảo luận:

* Tạo và lưu trữ một hash của toàn bộ url
    * [MD5](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) và [Base62](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)
    * Va chạm hash
    * SQL hoặc NoSQL
    * Lược đồ cơ sở dữ liệu
* Chuyển đổi url đã băm về url đầy đủ
    * Truy vấn cơ sở dữ liệu
* Thiết kế API và hướng đối tượng

### Bước 4: Mở rộng thiết kế

Xác định và giải quyết các điểm nghẽn, dựa trên các ràng buộc. Ví dụ, bạn có cần các yếu tố sau để xử lý vấn đề mở rộng?

* Bộ cân bằng tải
* Mở rộng ngang
* Bộ nhớ đệm
* Phân mảnh cơ sở dữ liệu

Thảo luận về các giải pháp tiềm năng và các đánh đổi. Mọi thứ đều là sự đánh đổi. Giải quyết điểm nghẽn dựa trên [nguyên tắc thiết kế hệ thống mở rộng](#index-of-system-design-topics).

### Tính toán sơ bộ

Bạn có thể được yêu cầu thực hiện một số ước tính bằng tay. Tham khảo [Phụ lục](#appendix) cho các nguồn sau:

* [Sử dụng tính toán sơ bộ](http://highscalability.com/blog/2011/1/26/google-pro-tip-use-back-of-the-envelope-calculations-to-choo.html)
* [Bảng lũy thừa của hai](#powers-of-two-table)
* [Các con số độ trễ mà lập trình viên nào cũng nên biết](#latency-numbers-every-programmer-should-know)

### Nguồn và tài liệu đọc thêm

Xem các liên kết sau để có ý tưởng rõ hơn về những gì sẽ gặp phải:

* [Cách vượt qua phỏng vấn thiết kế hệ thống](https://www.palantir.com/2011/10/how-to-rock-a-systems-design-interview/)
* [Phỏng vấn thiết kế hệ thống](http://www.hiredintech.com/system-design)
* [Giới thiệu về phỏng vấn kiến trúc và thiết kế hệ thống](https://www.youtube.com/watch?v=ZgdS0EUmn70)
* [Mẫu thiết kế hệ thống](https://leetcode.com/discuss/career/229177/My-System-Design-Template)

## Các câu hỏi phỏng vấn thiết kế hệ thống kèm giải pháp

> Các câu hỏi phỏng vấn thiết kế hệ thống phổ biến kèm thảo luận mẫu, mã nguồn, và sơ đồ.
>
> Các giải pháp liên kết đến nội dung trong thư mục `solutions/`.

| Câu hỏi | |
|---|---|
| Thiết kế Pastebin.com (hoặc Bit.ly) | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) |
| Thiết kế dòng thời gian và tìm kiếm của Twitter (hoặc bảng tin và tìm kiếm của Facebook) | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md) |
| Thiết kế trình thu thập dữ liệu web | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md) |
| Thiết kế Mint.com | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md) |
| Thiết kế cấu trúc dữ liệu cho mạng xã hội | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md) |
| Thiết kế khoá-giá trị cho công cụ tìm kiếm | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md) |
| Thiết kế tính năng xếp hạng bán hàng theo danh mục của Amazon | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md) |
| Thiết kế hệ thống mở rộng cho hàng triệu người dùng trên AWS | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md) |
| Thêm câu hỏi thiết kế hệ thống | [Đóng góp](#contributing) |

### Thiết kế Pastebin.com (hoặc Bit.ly)

[Xem bài tập và giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4edXG0T.png)

### Thiết kế dòng thời gian và tìm kiếm của Twitter (hoặc bảng tin và tìm kiếm của Facebook)

[Xem bài tập và giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png)

### Thiết kế trình thu thập dữ liệu web

[Xem bài tập và giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bWxPtQA.png)

### Design Mint.com

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/V5q57vU.png)

### Design the data structures for a social network

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/cdCv5g7.png)

### Design a key-value store for a search engine

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4j99mhe.png)

### Design Amazon's sales ranking by category feature

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/MzExP06.png)

### Design a system that scales to millions of users on AWS

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png)

## Object-oriented design interview questions with solutions

> Common object-oriented design interview questions with sample discussions, code, and diagrams.
>
> Solutions linked to content in the `solutions/` folder.

>**Note: This section is under development**

| Question | |
|---|---|
| Thiết kế một bảng băm | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/hash_table/hash_map.ipynb)  |
| Thiết kế bộ nhớ đệm truy xuất gần nhất (LRU cache) | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/lru_cache/lru_cache.ipynb)  |
| Thiết kế tổng đài điện thoại | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/call_center/call_center.ipynb)  |
| Thiết kế bộ bài | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/deck_of_cards/deck_of_cards.ipynb)  |
| Thiết kế bãi đậu xe | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/parking_lot/parking_lot.ipynb)  |
| Thiết kế máy chủ chat | [Giải pháp](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/online_chat/online_chat.ipynb)  |
| Thiết kế mảng vòng tròn | [Đóng góp](#contributing)  |
| Thêm một câu hỏi thiết kế hướng đối tượng | [Đóng góp](#contributing) |

## Chủ đề thiết kế hệ thống: bắt đầu từ đây

Bạn mới làm quen với thiết kế hệ thống?

Trước tiên, bạn cần hiểu cơ bản về các nguyên tắc phổ biến, tìm hiểu chúng là gì, cách sử dụng, và điểm mạnh/yếu của chúng.

### Bước 1: Xem bài giảng video về khả năng mở rộng

[Bài giảng về khả năng mở rộng tại Harvard](https://www.youtube.com/watch?v=-W9F__D3oY4)

* Các chủ đề bao gồm:
    * Mở rộng theo chiều dọc
    * Mở rộng theo chiều ngang
    * Bộ nhớ đệm
    * Cân bằng tải
    * Nhân bản cơ sở dữ liệu
    * Phân vùng cơ sở dữ liệu

### Bước 2: Đọc bài viết về khả năng mở rộng

[Khả năng mở rộng](https://web.archive.org/web/20221030091841/http://www.lecloud.net/tagged/scalability/chrono)

* Các chủ đề bao gồm:
    * [Bản sao](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
    * [Cơ sở dữ liệu](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
    * [Bộ nhớ đệm](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
    * [Tính bất đồng bộ](https://web.archive.org/web/20220926171507/https://www.lecloud.net/post/9699762917/scalability-for-dummies-part-4-asynchronism)

### Các bước tiếp theo

Tiếp theo, chúng ta sẽ xem xét các sự đánh đổi ở cấp độ cao:

* **Hiệu năng** so với **khả năng mở rộng**
* **Độ trễ** so với **thông lượng**
* **Khả dụng** so với **tính nhất quán**

Hãy nhớ rằng **mọi thứ đều là sự đánh đổi**.

Sau đó, chúng ta sẽ đi sâu vào các chủ đề cụ thể hơn như DNS, CDN, và bộ cân bằng tải.

## Hiệu năng vs khả năng mở rộng

Một dịch vụ được gọi là **có khả năng mở rộng** nếu nó có thể tăng **hiệu năng** theo tỷ lệ với tài nguyên được thêm vào. Thông thường, tăng hiệu năng nghĩa là phục vụ được nhiều đơn vị công việc hơn, nhưng nó cũng có thể là xử lý các đơn vị công việc lớn hơn, ví dụ như khi bộ dữ liệu tăng lên.<sup><a href=http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html>1</a></sup>

Một cách khác để nhìn nhận về hiệu năng và khả năng mở rộng:

* Nếu bạn có vấn đề về **hiệu năng**, hệ thống của bạn chậm đối với một người dùng đơn lẻ.
* Nếu bạn có vấn đề về **khả năng mở rộng**, hệ thống của bạn nhanh với một người dùng đơn lẻ nhưng chậm khi tải lớn.

### Nguồn và đọc thêm

* [Một từ về khả năng mở rộng](http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html)
* [Khả năng mở rộng, khả dụng, ổn định, mẫu hình](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)

## Độ trễ vs thông lượng

**Độ trễ** là thời gian để thực hiện một hành động hoặc tạo ra một kết quả.

**Thông lượng** là số lượng các hành động hoặc kết quả đó trên mỗi đơn vị thời gian.

Thông thường, bạn nên hướng tới **thông lượng tối đa** với **độ trễ chấp nhận được**.

### Nguồn và đọc thêm

* [Hiểu về độ trễ so với thông lượng](https://community.cadence.com/cadence_blogs_8/b/fv/posts/understanding-latency-vs-throughput)

## Khả dụng vs tính nhất quán

### Định lý CAP

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bgLMI2u.png">
  <br/>
  <i><a href=http://robertgreiner.com/2014/08/cap-theorem-revisited>Nguồn: CAP theorem revisited</a></i>
</p>

Trong một hệ thống máy tính phân tán, bạn chỉ có thể đảm bảo hai trong ba yếu tố sau:

* **Tính nhất quán (Consistency)** - Mỗi lần đọc đều nhận được lần ghi mới nhất hoặc báo lỗi
* **Tính sẵn sàng (Availability)** - Mỗi yêu cầu đều nhận được phản hồi, nhưng không đảm bảo chứa phiên bản mới nhất của thông tin
* **Chịu phân vùng (Partition Tolerance)** - Hệ thống tiếp tục hoạt động mặc dù bị phân vùng tùy ý do lỗi mạng

*Mạng lưới không đáng tin cậy, do đó bạn cần hỗ trợ khả năng chịu phân vùng. Bạn sẽ cần phải đánh đổi phần mềm giữa tính nhất quán và tính sẵn sàng.*

#### CP - nhất quán và chịu phân vùng

Chờ phản hồi từ nút bị phân vùng có thể dẫn đến lỗi quá thời gian. CP là lựa chọn tốt nếu yêu cầu kinh doanh của bạn đòi hỏi đọc và ghi nguyên tử.

#### AP - sẵn sàng và chịu phân vùng

Phản hồi trả về phiên bản dữ liệu có sẵn nhất trên bất kỳ nút nào, có thể không phải là phiên bản mới nhất. Các thao tác ghi có thể mất thời gian để lan truyền khi phân vùng được giải quyết.

AP là lựa chọn phù hợp nếu nhu cầu kinh doanh cho phép [tính nhất quán cuối cùng](#eventual-consistency) hoặc khi hệ thống cần tiếp tục hoạt động dù xảy ra lỗi bên ngoài.

### Nguồn và tài liệu tham khảo

* [CAP theorem revisited](http://robertgreiner.com/2014/08/cap-theorem-revisited/)
* [A plain english introduction to CAP theorem](http://ksat.me/a-plain-english-introduction-to-cap-theorem)
* [CAP FAQ](https://github.com/henryr/cap-faq)
* [The CAP theorem](https://www.youtube.com/watch?v=k-Yaq8AHlFA)

## Các mẫu nhất quán

Khi có nhiều bản sao của cùng một dữ liệu, chúng ta phải lựa chọn cách đồng bộ để khách hàng có cái nhìn nhất quán về dữ liệu. Hãy nhớ lại định nghĩa về tính nhất quán từ [định lý CAP](#cap-theorem) - Mỗi lần đọc nhận được lần ghi mới nhất hoặc báo lỗi.

### Nhất quán yếu

Sau một lần ghi, các lần đọc có thể thấy hoặc không thấy kết quả đó. Một cách tiếp cận nỗ lực tốt nhất được áp dụng.

Cách tiếp cận này thường thấy ở các hệ thống như memcached. Tính nhất quán yếu hoạt động tốt trong các trường hợp thời gian thực như VoIP, video chat và trò chơi nhiều người chơi trực tuyến. Ví dụ, nếu bạn đang gọi điện thoại và mất sóng trong vài giây, khi kết nối lại bạn sẽ không nghe được những gì đã nói trong lúc mất kết nối.

### Tính nhất quán cuối cùng

Sau một lần ghi, các lần đọc cuối cùng sẽ thấy nó (thường trong vòng mili giây). Dữ liệu được sao chép bất đồng bộ.

Cách tiếp cận này được sử dụng trong các hệ thống như DNS và email. Tính nhất quán cuối cùng hoạt động tốt trong các hệ thống có độ khả dụng cao.

### Tính nhất quán mạnh

Sau một lần ghi, các lần đọc sẽ thấy nó. Dữ liệu được sao chép đồng bộ.

Cách tiếp cận này được sử dụng trong hệ thống tệp và các hệ quản trị cơ sở dữ liệu quan hệ (RDBMS). Tính nhất quán mạnh phù hợp với các hệ thống cần giao dịch.

### Nguồn và tài liệu đọc thêm

* [Giao dịch trên nhiều trung tâm dữ liệu](http://snarfed.org/transactions_across_datacenters_io.html)

## Mô hình khả dụng

Có hai mô hình bổ trợ để hỗ trợ khả dụng cao: **chuyển đổi dự phòng** và **sao chép dữ liệu**.

### Chuyển đổi dự phòng

#### Chủ động - bị động

Với chuyển đổi dự phòng chủ động - bị động, các tín hiệu nhịp tim được gửi giữa máy chủ chủ động và máy chủ bị động ở chế độ chờ. Nếu tín hiệu nhịp tim bị gián đoạn, máy chủ bị động sẽ tiếp nhận địa chỉ IP của máy chủ chủ động và tiếp tục dịch vụ.

Thời gian ngừng hoạt động phụ thuộc vào việc máy chủ bị động đã chạy ở chế độ chờ 'nóng' hay cần khởi động từ chế độ chờ 'lạnh'. Chỉ máy chủ chủ động xử lý lưu lượng.

Chuyển đổi dự phòng chủ động - bị động còn được gọi là chuyển đổi dự phòng chủ - tớ.

#### Chủ động - chủ động

Trong chuyển đổi dự phòng chủ động - chủ động, cả hai máy chủ đều xử lý lưu lượng, phân chia tải giữa chúng.

Nếu các máy chủ hướng ra công chúng, DNS cần biết về các địa chỉ IP công khai của cả hai máy chủ. Nếu các máy chủ hướng nội bộ, logic ứng dụng cần biết về cả hai máy chủ.

Chuyển đổi dự phòng chủ động - chủ động còn được gọi là chuyển đổi dự phòng chủ - chủ.

### Nhược điểm: chuyển đổi dự phòng

* Chuyển đổi dự phòng (fail-over) yêu cầu thêm phần cứng và tăng độ phức tạp.
* Có khả năng mất dữ liệu nếu hệ thống chủ động gặp sự cố trước khi dữ liệu mới được ghi được sao chép sang hệ thống bị động.

### Sao chép dữ liệu (Replication)

#### Mô hình chủ-tớ và chủ-chủ

Chủ đề này được thảo luận thêm trong phần [Cơ sở dữ liệu](#database):

* [Sao chép dữ liệu chủ-tớ](#master-slave-replication)
* [Sao chép dữ liệu chủ-chủ](#master-master-replication)

### Tỷ lệ sẵn sàng dưới dạng số liệu

Tỷ lệ sẵn sàng thường được định lượng bằng thời gian hoạt động (hoặc thời gian ngừng hoạt động) dưới dạng phần trăm thời gian dịch vụ có thể truy cập. Tỷ lệ sẵn sàng thường được đo bằng số lượng số 9--một dịch vụ có tỷ lệ sẵn sàng 99,99% được mô tả là có bốn số 9.

#### Tỷ lệ sẵn sàng 99,9% - ba số 9

| Thời lượng             | Thời gian ngừng hoạt động chấp nhận được|
|------------------------|-----------------------------------------|
| Ngừng hoạt động mỗi năm| 8 giờ 45 phút 57 giây                   |
| Ngừng hoạt động mỗi tháng| 43 phút 49,7 giây                    |
| Ngừng hoạt động mỗi tuần| 10 phút 4,8 giây                      |
| Ngừng hoạt động mỗi ngày| 1 phút 26,4 giây                      |

#### Tỷ lệ sẵn sàng 99,99% - bốn số 9

| Thời lượng             | Thời gian ngừng hoạt động chấp nhận được|
|------------------------|-----------------------------------------|
| Ngừng hoạt động mỗi năm| 52 phút 35,7 giây                       |
| Ngừng hoạt động mỗi tháng| 4 phút 23 giây                       |
| Ngừng hoạt động mỗi tuần| 1 phút 5 giây                         |
| Ngừng hoạt động mỗi ngày| 8,6 giây                              |

#### Tỷ lệ sẵn sàng song song so với tuần tự

Nếu một dịch vụ bao gồm nhiều thành phần có khả năng gặp sự cố, tỷ lệ sẵn sàng tổng thể của dịch vụ phụ thuộc vào việc các thành phần này được sắp xếp theo tuần tự hay song song.

###### Theo tuần tự

Tổng độ sẵn sàng giảm khi hai thành phần có độ sẵn sàng < 100% được kết nối nối tiếp:

```
Availability (Total) = Availability (Foo) * Availability (Bar)
```

Nếu cả `Foo` và `Bar` đều có độ sẵn sàng 99,9%, tổng độ sẵn sàng của chúng khi nối tiếp sẽ là 99,8%.

###### Song song

Độ sẵn sàng tổng thể tăng lên khi hai thành phần có độ sẵn sàng < 100% được kết nối song song:

```
Availability (Total) = 1 - (1 - Availability (Foo)) * (1 - Availability (Bar))
```
Nếu cả `Foo` và `Bar` đều có mức độ sẵn sàng 99,9%, tổng mức độ sẵn sàng khi chạy song song của chúng sẽ là 99,9999%.

## Hệ thống tên miền (Domain name system)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/IOyLj4i.jpg">
  <br/>
  <i><a href=http://www.slideshare.net/srikrupa5/dns-security-presentation-issa>Nguồn: Bài thuyết trình về bảo mật DNS</a></i>
</p>

Hệ thống tên miền (DNS) chuyển đổi một tên miền như www.example.com thành một địa chỉ IP.

DNS có cấu trúc phân cấp, với một vài máy chủ có thẩm quyền ở cấp cao nhất.  Bộ định tuyến hoặc nhà cung cấp dịch vụ internet (ISP) của bạn cung cấp thông tin về máy chủ DNS cần liên hệ khi thực hiện truy vấn.  Các máy chủ DNS cấp thấp hơn lưu bộ nhớ đệm các ánh xạ, có thể bị lỗi thời do độ trễ truyền bá DNS.  Kết quả DNS cũng có thể được trình duyệt hoặc hệ điều hành của bạn lưu vào bộ đệm trong một khoảng thời gian nhất định, được xác định bởi [thời gian tồn tại (TTL)](https://en.wikipedia.org/wiki/Time_to_live).

* **Bản ghi NS (name server)** - Chỉ định các máy chủ DNS cho miền/phụ miền của bạn.
* **Bản ghi MX (mail exchange)** - Chỉ định các máy chủ thư để nhận tin nhắn.
* **Bản ghi A (address)** - Trỏ một tên đến một địa chỉ IP.
* **CNAME (canonical)** - Trỏ một tên đến tên khác hoặc `CNAME` (example.com đến www.example.com) hoặc đến bản ghi `A`.

Các dịch vụ như [CloudFlare](https://www.cloudflare.com/dns/) và [Route 53](https://aws.amazon.com/route53/) cung cấp dịch vụ DNS được quản lý.  Một số dịch vụ DNS có thể định tuyến lưu lượng thông qua các phương pháp khác nhau:

* [Vòng lặp trọng số](https://www.jscape.com/blog/load-balancing-algorithms)
    * Ngăn lưu lượng truy cập đến các máy chủ đang bảo trì
    * Cân bằng giữa các cụm có kích thước khác nhau
    * Kiểm thử A/B
* [Dựa trên độ trễ](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-latency.html)
* [Dựa trên vị trí địa lý](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geo.html)

### Nhược điểm: DNS

* Truy cập một máy chủ DNS gây ra độ trễ nhỏ, mặc dù đã được giảm nhẹ bởi cơ chế lưu bộ nhớ đệm như trên.
* Quản lý máy chủ DNS có thể phức tạp và thường được quản lý bởi [chính phủ, ISP, và các công ty lớn](http://superuser.com/questions/472695/who-controls-the-dns-servers/472729).
* Các dịch vụ DNS gần đây đã bị [tấn công DDoS](http://dyn.com/blog/dyn-analysis-summary-of-friday-october-21-attack/), ngăn người dùng truy cập các website như Twitter nếu không biết địa chỉ IP của Twitter.

### Nguồn và tài liệu đọc thêm

* [Kiến trúc DNS](https://technet.microsoft.com/en-us/library/dd197427(v=ws.10).aspx)
* [Wikipedia](https://en.wikipedia.org/wiki/Domain_Name_System)
* [Các bài viết về DNS](https://support.dnsimple.com/categories/dns/)


## Mạng phân phối nội dung

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h9TAuGI.jpg">
  <br/>
  <i><a href=https://www.creative-artworks.eu/why-use-a-content-delivery-network-cdn/>Nguồn: Tại sao sử dụng CDN</a></i>
</p>

Mạng phân phối nội dung (CDN) là một mạng lưới các máy chủ proxy được phân phối toàn cầu, cung cấp nội dung từ các vị trí gần người dùng hơn. Thông thường, các tệp tĩnh như HTML/CSS/JS, ảnh và video được phục vụ từ CDN, mặc dù một số CDN như CloudFront của Amazon hỗ trợ cả nội dung động. Quá trình phân giải DNS của trang web sẽ cho khách truy cập biết nên liên hệ với máy chủ nào.

Việc cung cấp nội dung từ CDN có thể cải thiện hiệu suất đáng kể theo hai cách:

* Người dùng nhận nội dung từ trung tâm dữ liệu gần họ nhất
* Máy chủ của bạn không phải phục vụ các yêu cầu mà CDN đã đáp ứng

### Push CDN

Push CDN nhận nội dung mới mỗi khi có thay đổi trên máy chủ của bạn. Bạn hoàn toàn chịu trách nhiệm cung cấp nội dung, tải trực tiếp lên CDN và viết lại URL để trỏ tới CDN. Bạn có thể cấu hình thời điểm nội dung hết hạn và được cập nhật. Nội dung chỉ được tải lên khi có mới hoặc thay đổi, giảm thiểu lưu lượng nhưng tối đa hóa lưu trữ.

Các trang web có lưu lượng nhỏ hoặc nội dung không thường xuyên thay đổi rất phù hợp với Push CDN. Nội dung được đặt lên CDN một lần, thay vì bị lấy lại định kỳ.

### Pull CDN

Pull CDN lấy nội dung mới từ máy chủ của bạn khi người dùng đầu tiên yêu cầu nội dung đó. Bạn để nội dung trên máy chủ và viết lại URL để trỏ đến CDN. Điều này dẫn đến lần truy cập đầu tiên chậm hơn cho đến khi nội dung được cache trên CDN.

[Thời gian sống (TTL)](https://en.wikipedia.org/wiki/Time_to_live) xác định thời gian nội dung được cache. Pull CDN giảm thiểu không gian lưu trữ trên CDN, nhưng có thể tạo ra lưu lượng dư thừa nếu các tệp hết hạn và bị lấy lại trước khi chúng thực sự thay đổi.

Các trang web có lưu lượng lớn hoạt động hiệu quả với Pull CDN, vì lưu lượng được phân tán đều hơn và chỉ những nội dung vừa được yêu cầu mới ở lại trên CDN.

### Nhược điểm: CDN

* Chi phí CDN có thể đáng kể tùy theo lưu lượng, tuy nhiên nên cân nhắc với chi phí bổ sung nếu không sử dụng CDN.
* Nội dung có thể bị lỗi thời nếu được cập nhật trước khi TTL hết hạn.
* CDN yêu cầu thay đổi URL của nội dung tĩnh để trỏ tới CDN.

### Nguồn và đọc thêm

* [Phân phối nội dung toàn cầu](https://figshare.com/articles/Globally_distributed_content_delivery/6605972)
* [Sự khác biệt giữa Push và Pull CDN](http://www.travelblogadvice.com/technical/the-differences-between-push-and-pull-cdns/)
* [Wikipedia](https://en.wikipedia.org/wiki/Content_delivery_network)

## Bộ cân bằng tải

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h81n9iK.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>Nguồn: Các mẫu thiết kế hệ thống có khả năng mở rộng</a></i>
</p>

Bộ cân bằng tải phân phối các yêu cầu từ khách hàng đến các tài nguyên tính toán như máy chủ ứng dụng và cơ sở dữ liệu. Trong mỗi trường hợp, bộ cân bằng tải trả về phản hồi từ tài nguyên tính toán đến đúng khách hàng. Bộ cân bằng tải hiệu quả trong việc:

* Ngăn chặn các yêu cầu đến các máy chủ không khỏe mạnh
* Ngăn chặn việc quá tải tài nguyên
* Giúp loại bỏ điểm lỗi đơn lẻ

Bộ cân bằng tải có thể được triển khai bằng phần cứng (đắt tiền) hoặc phần mềm như HAProxy.

Các lợi ích bổ sung bao gồm:

* **Kết thúc SSL** - Giải mã các yêu cầu đến và mã hóa phản hồi từ máy chủ để các máy chủ backend không phải thực hiện những tác vụ tốn kém này
    * Loại bỏ nhu cầu cài đặt [chứng chỉ X.509](https://en.wikipedia.org/wiki/X.509) trên mỗi máy chủ
* **Duy trì phiên** - Phát hành cookie và định tuyến các yêu cầu của một khách hàng cụ thể đến cùng một phiên bản nếu ứng dụng web không lưu trữ phiên

Để bảo vệ chống lại sự cố, thông thường sẽ thiết lập nhiều bộ cân bằng tải, ở chế độ [active-passive](#active-passive) hoặc [active-active](#active-active).

Bộ cân bằng tải có thể định tuyến lưu lượng dựa trên nhiều chỉ số khác nhau, bao gồm:

* Ngẫu nhiên
* Tải ít nhất
* Phiên/cookie
* [Vòng luân phiên hoặc vòng luân phiên có trọng số](https://www.g33kinfo.com/info/round-robin-vs-weighted-round-robin-lb)
* [Tầng 4](#layer-4-load-balancing)
* [Tầng 7](#layer-7-load-balancing)

### Cân bằng tải tầng 4

Bộ cân bằng tải tầng 4 xem xét thông tin tại [tầng vận chuyển](#communication) để quyết định cách phân phối yêu cầu. Thông thường, điều này liên quan đến địa chỉ IP nguồn, đích và các cổng trong phần đầu, nhưng không phải nội dung của gói tin. Bộ cân bằng tải tầng 4 chuyển tiếp các gói mạng đến và từ máy chủ upstream, thực hiện [Chuyển đổi địa chỉ mạng (NAT)](https://www.nginx.com/resources/glossary/layer-4-load-balancing/).

### Cân bằng tải tầng 7
Bộ cân bằng tải tầng 7 kiểm tra [tầng ứng dụng](#communication) để quyết định cách phân phối các yêu cầu. Điều này có thể liên quan đến nội dung của tiêu đề, thông điệp và cookie. Bộ cân bằng tải tầng 7 sẽ chấm dứt lưu lượng mạng, đọc thông điệp, đưa ra quyết định cân bằng tải, sau đó mở kết nối đến máy chủ đã được chọn. Ví dụ, bộ cân bằng tải tầng 7 có thể chuyển hướng lưu lượng video đến các máy chủ lưu trữ video trong khi chuyển hướng lưu lượng thanh toán người dùng nhạy cảm đến các máy chủ đã được tăng cường bảo mật.

Đổi lại cho sự linh hoạt, cân bằng tải tầng 4 yêu cầu ít thời gian và tài nguyên tính toán hơn tầng 7, mặc dù tác động đến hiệu suất có thể không đáng kể trên phần cứng phổ thông hiện đại.

### Mở rộng theo chiều ngang

Bộ cân bằng tải cũng giúp mở rộng theo chiều ngang, cải thiện hiệu suất và độ sẵn sàng. Mở rộng bằng các máy phổ thông tiết kiệm chi phí hơn và mang lại độ sẵn sàng cao hơn so với mở rộng một máy chủ duy nhất trên phần cứng đắt tiền, gọi là **Mở rộng theo chiều dọc**. Việc tuyển dụng nhân sự làm việc với phần cứng phổ thông cũng dễ dàng hơn so với các hệ thống doanh nghiệp chuyên biệt.

#### Nhược điểm: mở rộng theo chiều ngang

* Mở rộng theo chiều ngang làm tăng độ phức tạp và liên quan đến việc nhân bản máy chủ
    * Máy chủ nên là không trạng thái: không nên chứa dữ liệu liên quan đến người dùng như phiên hoặc ảnh đại diện
    * Phiên có thể được lưu trong kho dữ liệu tập trung như [cơ sở dữ liệu](#database) (SQL, NoSQL) hoặc [bộ nhớ đệm](#cache) lâu dài (Redis, Memcached)
* Các máy chủ phía dưới như bộ đệm và cơ sở dữ liệu cần xử lý nhiều kết nối đồng thời hơn khi các máy chủ phía trên mở rộng

### Nhược điểm: bộ cân bằng tải

* Bộ cân bằng tải có thể trở thành nút thắt về hiệu suất nếu không đủ tài nguyên hoặc cấu hình không đúng.
* Việc thêm bộ cân bằng tải để loại bỏ điểm lỗi đơn lại làm tăng độ phức tạp.
* Một bộ cân bằng tải đơn là một điểm lỗi đơn, cấu hình nhiều bộ cân bằng tải sẽ càng tăng độ phức tạp.

### Nguồn và đọc thêm

* [Kiến trúc NGINX](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [Hướng dẫn kiến trúc HAProxy](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [Khả năng mở rộng](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
* [Wikipedia](https://en.wikipedia.org/wiki/Load_balancing_(computing))
* [Cân bằng tải tầng 4](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)
* [Cân bằng tải tầng 7](https://www.nginx.com/resources/glossary/layer-7-load-balancing/)
* [Cấu hình listener ELB](http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html)

## Reverse proxy (máy chủ web)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n41Azff.png">
  <br/>
  <i><a href=https://upload.wikimedia.org/wikipedia/commons/6/67/Reverse_proxy_h2g2bob.svg>Nguồn: Wikipedia</a></i>
  <br/>
</p>

Reverse proxy là một máy chủ web tập trung các dịch vụ nội bộ và cung cấp giao diện thống nhất cho công chúng.  Các yêu cầu từ khách hàng sẽ được chuyển tiếp đến máy chủ có thể xử lý trước khi reverse proxy trả về phản hồi của máy chủ cho khách hàng.

Các lợi ích bổ sung bao gồm:

* **Tăng cường bảo mật** - Ẩn thông tin về các máy chủ backend, chặn danh sách đen IP, giới hạn số lượng kết nối trên mỗi khách hàng
* **Tăng khả năng mở rộng và linh hoạt** - Khách hàng chỉ nhìn thấy IP của reverse proxy, cho phép bạn mở rộng máy chủ hoặc thay đổi cấu hình của chúng
* **Chấm dứt SSL** - Giải mã các yêu cầu đến và mã hóa phản hồi của máy chủ để các máy chủ backend không phải thực hiện những thao tác có thể tốn kém này
    * Loại bỏ nhu cầu cài đặt [chứng chỉ X.509](https://en.wikipedia.org/wiki/X.509) trên mỗi máy chủ
* **Nén** - Nén phản hồi của máy chủ
* **Bộ nhớ đệm** - Trả về phản hồi cho các yêu cầu đã được lưu trong bộ nhớ đệm
* **Nội dung tĩnh** - Phục vụ trực tiếp nội dung tĩnh
    * HTML/CSS/JS
    * Ảnh
    * Video
    * V.v.

### Bộ cân bằng tải vs reverse proxy

* Triển khai bộ cân bằng tải rất hữu ích khi bạn có nhiều máy chủ.  Thường thì các bộ cân bằng tải sẽ định tuyến lưu lượng đến một tập hợp các máy chủ phục vụ cùng chức năng.
* Reverse proxy có thể hữu ích ngay cả khi chỉ có một máy chủ web hoặc máy chủ ứng dụng, mở ra các lợi ích như đã mô tả ở phần trước.
* Các giải pháp như NGINX và HAProxy có thể hỗ trợ cả reverse proxy tầng 7 và cân bằng tải.

### Bất lợi: reverse proxy

* Việc giới thiệu reverse proxy làm tăng độ phức tạp.
* Một reverse proxy duy nhất là điểm lỗi duy nhất, cấu hình nhiều reverse proxy (ví dụ như [failover](https://en.wikipedia.org/wiki/Failover)) càng làm tăng độ phức tạp.

### Nguồn và đọc thêm

* [Reverse proxy vs load balancer](https://www.nginx.com/resources/glossary/reverse-proxy-vs-load-balancer/)
* [Kiến trúc NGINX](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [Hướng dẫn kiến trúc HAProxy](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [Wikipedia](https://en.wikipedia.org/wiki/Reverse_proxy)

## Tầng ứng dụng

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yB5SYwm.png">
  <br/>

  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>Nguồn: Giới thiệu về kiến trúc hệ thống cho khả năng mở rộng</a></i>
</p>

Tách biệt tầng web khỏi tầng ứng dụng (còn gọi là tầng nền tảng) cho phép bạn mở rộng và cấu hình cả hai tầng một cách độc lập. Việc thêm một API mới dẫn đến việc bổ sung máy chủ ứng dụng mà không nhất thiết phải thêm máy chủ web bổ sung. Nguyên tắc **single responsibility** khuyến khích các dịch vụ nhỏ và tự động làm việc cùng nhau. Các nhóm nhỏ với các dịch vụ nhỏ có thể lập kế hoạch phát triển nhanh chóng một cách tích cực hơn.

Các worker ở tầng ứng dụng cũng giúp kích hoạt [tính bất đồng bộ](#asynchronism).

### Microservices

Liên quan đến chủ đề này là [microservices](https://vi.wikipedia.org/wiki/Microservices), có thể được mô tả là một bộ các dịch vụ nhỏ, mô-đun, có thể triển khai độc lập. Mỗi dịch vụ chạy một tiến trình riêng biệt và giao tiếp qua một cơ chế nhẹ, được xác định rõ nhằm phục vụ mục tiêu kinh doanh. <sup><a href=https://smartbear.com/learn/api-design/what-are-microservices>1</a></sup>

Pinterest, ví dụ, có thể có các microservice như: hồ sơ người dùng, theo dõi, nguồn cấp, tìm kiếm, tải ảnh lên, v.v.

### Khám phá dịch vụ

Các hệ thống như [Consul](https://www.consul.io/docs/index.html), [Etcd](https://coreos.com/etcd/docs/latest), và [Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) có thể giúp các dịch vụ tìm nhau bằng cách theo dõi tên, địa chỉ và cổng đã đăng ký. [Kiểm tra sức khỏe](https://www.consul.io/intro/getting-started/checks.html) giúp xác minh tính toàn vẹn của dịch vụ và thường được thực hiện thông qua một endpoint [HTTP](#hypertext-transfer-protocol-http). Cả Consul và Etcd đều có [kho lưu trữ key-value](#key-value-store) tích hợp sẵn, hữu ích để lưu giá trị cấu hình và dữ liệu chia sẻ khác.

### Nhược điểm: tầng ứng dụng

* Thêm tầng ứng dụng với các dịch vụ liên kết lỏng lẻo đòi hỏi một cách tiếp cận khác về mặt kiến trúc, vận hành và quy trình (so với hệ thống nguyên khối).
* Microservice có thể làm tăng độ phức tạp trong triển khai và vận hành.

### Nguồn và tài liệu đọc thêm

* [Giới thiệu về kiến trúc hệ thống cho khả năng mở rộng](http://lethain.com/introduction-to-architecting-systems-for-scale)
* [Crack the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Kiến trúc hướng dịch vụ](https://vi.wikipedia.org/wiki/Ki%E1%BA%BFn_tr%C3%BAc_h%C6%B0%E1%BB%9Bng_d%E1%BB%8Bch_v%E1%BB%A5)
* [Giới thiệu về Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper)
* [Những điều bạn cần biết về xây dựng microservice](https://cloudncode.wordpress.com/2016/07/22/msa-getting-started/)

## Cơ sở dữ liệu

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Xkm5CXz.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>Nguồn: Mở rộng lên 10 triệu người dùng đầu tiên</a></i>
</p>

### Hệ quản trị cơ sở dữ liệu quan hệ (RDBMS)

Một cơ sở dữ liệu quan hệ như SQL là một tập hợp các mục dữ liệu được tổ chức trong các bảng.

**ACID** là một tập hợp các thuộc tính của [giao dịch](https://en.wikipedia.org/wiki/Database_transaction) trong cơ sở dữ liệu quan hệ.

* **Atomicity** - Mỗi giao dịch là tất cả hoặc không có gì
* **Consistency** - Bất kỳ giao dịch nào cũng sẽ đưa cơ sở dữ liệu từ một trạng thái hợp lệ này sang trạng thái hợp lệ khác
* **Isolation** - Việc thực thi đồng thời các giao dịch sẽ cho kết quả giống như khi các giao dịch được thực thi tuần tự
* **Durability** - Một khi giao dịch đã được cam kết, nó sẽ được giữ nguyên

Có nhiều kỹ thuật để mở rộng quy mô cơ sở dữ liệu quan hệ: **nhân bản chủ-tớ**, **nhân bản chủ-chủ**, **liên kết**, **phân mảnh**, **phi chuẩn hóa**, và **tối ưu hóa SQL**.

#### Nhân bản chủ-tớ

Chủ phục vụ cả đọc và ghi, nhân bản các thao tác ghi đến một hoặc nhiều tớ, các tớ chỉ phục vụ đọc. Các tớ cũng có thể nhân bản đến các tớ bổ sung theo dạng cây. Nếu chủ bị ngắt kết nối, hệ thống có thể tiếp tục hoạt động ở chế độ chỉ đọc cho đến khi một tớ được nâng cấp thành chủ hoặc một chủ mới được cung cấp.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/C9ioGtn.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Nguồn: Scalability, availability, stability, patterns</a></i>
</p>

##### Nhược điểm: nhân bản chủ-tớ

* Cần bổ sung logic để nâng cấp một tớ thành chủ.
* Xem [Nhược điểm: replication](#disadvantages-replication) cho các điểm liên quan đến **cả** nhân bản chủ-tớ và chủ-chủ.

#### Nhân bản chủ-chủ

Cả hai chủ đều phục vụ đọc và ghi và phối hợp với nhau về các thao tác ghi. Nếu một trong hai chủ gặp sự cố, hệ thống vẫn có thể tiếp tục hoạt động với cả đọc và ghi.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/krAHLGg.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Nguồn: Scalability, availability, stability, patterns</a></i>
</p>

##### Nhược điểm: nhân bản chủ-chủ

* Bạn sẽ cần bộ cân bằng tải hoặc cần sửa đổi logic ứng dụng để xác định vị trí ghi dữ liệu.
* Hầu hết các hệ thống chủ-chủ hoặc là nhất quán lỏng lẻo (vi phạm ACID) hoặc có độ trễ ghi tăng lên do đồng bộ hóa.
* Việc giải quyết xung đột trở nên quan trọng hơn khi có nhiều node ghi hơn và khi độ trễ tăng lên.
* Xem [Nhược điểm: nhân bản](#disadvantages-replication) để biết các điểm liên quan đến **cả** master-slave và master-master.

##### Nhược điểm: nhân bản

* Có khả năng mất dữ liệu nếu master bị lỗi trước khi bất kỳ dữ liệu mới nào được ghi có thể được nhân bản đến các node khác.
* Các ghi lại được phát lại đến các bản sao đọc. Nếu có nhiều ghi, các bản sao đọc có thể bị quá tải bởi việc phát lại ghi và không thể thực hiện nhiều đọc.
* Càng nhiều slave đọc thì càng phải nhân bản nhiều, dẫn đến độ trễ nhân bản lớn hơn.
* Trên một số hệ thống, ghi vào master có thể sinh ra nhiều luồng để ghi song song, trong khi bản sao đọc chỉ hỗ trợ ghi tuần tự với một luồng duy nhất.
* Nhân bản bổ sung thêm phần cứng và sự phức tạp.

##### Nguồn và tài liệu tham khảo thêm: nhân bản

* [Scalability, availability, stability, patterns](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [Nhân bản đa master](https://en.wikipedia.org/wiki/Multi-master_replication)

#### Federation

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/U3qV33e.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>Nguồn: Scaling up to your first 10 million users</a></i>
</p>

Federation (hoặc phân vùng chức năng) chia nhỏ cơ sở dữ liệu theo chức năng. Ví dụ, thay vì một cơ sở dữ liệu đơn lẻ, nguyên khối, bạn có thể có ba cơ sở dữ liệu: **forums**, **users**, và **products**, dẫn đến ít lưu lượng đọc và ghi đến mỗi cơ sở dữ liệu hơn và do đó ít độ trễ nhân bản hơn. Các cơ sở dữ liệu nhỏ hơn giúp nhiều dữ liệu có thể nằm trong bộ nhớ hơn, từ đó tăng số lần truy cập cache nhờ cải thiện tính cục bộ của cache. Không có master trung tâm duy nhất để tuần tự hóa ghi, bạn có thể ghi song song, tăng thông lượng.

##### Nhược điểm: federation

* Federation không hiệu quả nếu lược đồ của bạn yêu cầu các chức năng hoặc bảng quá lớn.
* Bạn sẽ cần cập nhật logic ứng dụng để xác định cơ sở dữ liệu nào cần đọc và ghi.
* Kết hợp dữ liệu từ hai cơ sở dữ liệu sẽ phức tạp hơn với một [server link](http://stackoverflow.com/questions/5145637/querying-data-by-joining-two-tables-in-two-database-on-different-servers).
* Federation bổ sung thêm phần cứng và sự phức tạp.

##### Nguồn và tài liệu tham khảo thêm: federation

* [Scaling up to your first 10 million users](https://www.youtube.com/watch?v=kKjm4ehYiMs)

#### Sharding

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wU8x5Id.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Nguồn: Scalability, availability, stability, patterns</a></i>
</p>

Sharding phân phối dữ liệu qua các cơ sở dữ liệu khác nhau sao cho mỗi cơ sở dữ liệu chỉ quản lý một phần của dữ liệu. Lấy ví dụ với cơ sở dữ liệu người dùng, khi số lượng người dùng tăng lên, nhiều shard hơn sẽ được thêm vào cụm.

Tương tự như lợi ích của [federation](#federation), sharding giúp giảm lưu lượng đọc và ghi, giảm việc nhân bản dữ liệu, và tăng tỷ lệ cache hit. Kích thước chỉ mục cũng được giảm, thường cải thiện hiệu năng với các truy vấn nhanh hơn. Nếu một shard gặp sự cố, các shard khác vẫn hoạt động, tuy nhiên bạn sẽ muốn thêm một số hình thức nhân bản để tránh mất dữ liệu. Giống như federation, không có một master trung tâm duy nhất serial hóa việc ghi, cho phép bạn ghi song song với thông lượng cao hơn.

Các cách phổ biến để shard bảng người dùng là dựa vào ký tự đầu của họ người dùng hoặc vị trí địa lý của người dùng.

##### Nhược điểm: sharding

* Bạn sẽ cần cập nhật logic ứng dụng để làm việc với các shard, điều này có thể dẫn đến các truy vấn SQL phức tạp.
* Phân phối dữ liệu có thể trở nên mất cân đối trong một shard. Ví dụ, một nhóm người dùng mạnh trên một shard có thể dẫn đến tải tăng lên cho shard đó so với các shard khác.
    * Cân bằng lại dữ liệu làm tăng độ phức tạp. Hàm sharding dựa trên [consistent hashing](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html) có thể giảm lượng dữ liệu cần chuyển.
* Kết nối dữ liệu từ nhiều shard trở nên phức tạp hơn.
* Sharding thêm nhiều phần cứng và độ phức tạp bổ sung.

##### Nguồn và đọc thêm: sharding

* [Sự xuất hiện của shard](http://highscalability.com/blog/2009/8/6/an-unorthodox-approach-to-database-design-the-coming-of-the.html)
* [Kiến trúc cơ sở dữ liệu shard](https://en.wikipedia.org/wiki/Shard_(database_architecture))
* [Consistent hashing](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)

#### Denormalization

Denormalization cố gắng cải thiện hiệu năng đọc bằng cách hy sinh một phần hiệu năng ghi. Các bản sao dư thừa của dữ liệu được ghi vào nhiều bảng để tránh các phép nối đắt đỏ. Một số RDBMS như [PostgreSQL](https://en.wikipedia.org/wiki/PostgreSQL) và Oracle hỗ trợ [materialized views](https://en.wikipedia.org/wiki/Materialized_view) giúp lưu trữ thông tin dư thừa và giữ các bản sao dư thừa nhất quán.

Khi dữ liệu được phân phối bằng các kỹ thuật như [federation](#federation) và [sharding](#sharding), việc quản lý các phép nối qua các trung tâm dữ liệu càng làm tăng độ phức tạp. Denormalization có thể giúp tránh được nhu cầu thực hiện các phép nối phức tạp như vậy.

Trong hầu hết các hệ thống, số lần đọc có thể vượt xa số lần ghi với tỷ lệ 100:1 hoặc thậm chí 1000:1. Một lần đọc dẫn đến phép nối dữ liệu phức tạp có thể rất tốn kém, tiêu tốn nhiều thời gian cho các thao tác ổ đĩa.

##### Nhược điểm: denormalization

* Dữ liệu bị trùng lặp.
* Các ràng buộc có thể giúp các bản sao dư thừa của thông tin luôn đồng bộ, làm tăng độ phức tạp của thiết kế cơ sở dữ liệu.
* Cơ sở dữ liệu denormalized dưới tải ghi lớn có thể hoạt động kém hơn so với cơ sở dữ liệu normalized.

###### Nguồn và đọc thêm: denormalization

* [Phi chuẩn hóa (Denormalization)](https://vi.wikipedia.org/wiki/Denormalization)

#### Tinh chỉnh SQL

Tinh chỉnh SQL là một chủ đề rộng lớn và nhiều [sách](https://www.amazon.com/s/ref=nb_sb_noss_2?url=search-alias%3Daps&field-keywords=sql+tuning) đã được viết làm tài liệu tham khảo.

Điều quan trọng là phải **kiểm thử hiệu năng** và **phân tích hồ sơ** để mô phỏng và phát hiện các nút thắt cổ chai.

* **Kiểm thử hiệu năng** - Mô phỏng tình huống tải cao với các công cụ như [ab](http://httpd.apache.org/docs/2.2/programs/ab.html).
* **Phân tích hồ sơ** - Kích hoạt các công cụ như [slow query log](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html) để giúp theo dõi các vấn đề về hiệu năng.

Kiểm thử hiệu năng và phân tích hồ sơ có thể giúp bạn xác định các tối ưu hóa sau.

##### Siết chặt lược đồ

* MySQL ghi ra đĩa thành các khối liên tiếp để truy cập nhanh.
* Dùng `CHAR` thay vì `VARCHAR` cho các trường có độ dài cố định.
    * `CHAR` thực sự cho phép truy cập ngẫu nhiên nhanh, trong khi với `VARCHAR`, bạn phải tìm điểm kết thúc của chuỗi trước khi chuyển sang chuỗi tiếp theo.
* Dùng `TEXT` cho các khối văn bản lớn như bài đăng blog. `TEXT` cũng cho phép tìm kiếm kiểu boolean. Dùng trường `TEXT` sẽ lưu một con trỏ trên đĩa để xác định vị trí khối văn bản.
* Dùng `INT` cho các số lớn lên đến 2^32 hoặc 4 tỷ.
* Dùng `DECIMAL` cho tiền tệ để tránh lỗi biểu diễn số thực.
* Tránh lưu trữ các `BLOB` lớn, thay vào đó lưu vị trí lấy đối tượng.
* `VARCHAR(255)` là số lượng ký tự lớn nhất có thể được đếm trong một số 8 bit, thường tối đa hóa việc sử dụng một byte ở một số Hệ quản trị CSDL.
* Đặt ràng buộc `NOT NULL` khi áp dụng để [cải thiện hiệu suất tìm kiếm](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search).

##### Sử dụng chỉ mục tốt

* Các cột mà bạn truy vấn (`SELECT`, `GROUP BY`, `ORDER BY`, `JOIN`) có thể nhanh hơn với chỉ mục.
* Chỉ mục thường được biểu diễn dưới dạng [B-tree](https://en.wikipedia.org/wiki/B-tree) tự cân bằng giúp dữ liệu được sắp xếp và cho phép tìm kiếm, truy cập tuần tự, chèn, xóa trong thời gian logarit.
* Đặt chỉ mục có thể giữ dữ liệu trong bộ nhớ, yêu cầu thêm không gian lưu trữ.
* Việc ghi dữ liệu cũng có thể chậm hơn vì cần cập nhật chỉ mục.
* Khi tải lượng lớn dữ liệu, có thể nhanh hơn nếu tắt chỉ mục, tải dữ liệu, rồi xây dựng lại chỉ mục.

##### Tránh các phép nối tốn kém

* [Phi chuẩn hóa](#denormalization) khi hiệu năng yêu cầu.

##### Phân vùng bảng

* Chia nhỏ một bảng bằng cách đưa các điểm nóng vào một bảng riêng biệt để giúp giữ nó trong bộ nhớ.

##### Tinh chỉnh bộ nhớ đệm truy vấn

* Trong một số trường hợp, [bộ nhớ đệm truy vấn](https://dev.mysql.com/doc/refman/5.7/en/query-cache.html) có thể dẫn đến [vấn đề hiệu năng](https://www.percona.com/blog/2016/10/12/mysql-5-7-performance-tuning-immediately-after-installation/).

##### Nguồn và tài liệu đọc thêm: Tinh chỉnh SQL

* [Mẹo tối ưu hóa truy vấn MySQL](http://aiddroid.com/10-tips-optimizing-mysql-queries-dont-suck/)
* [Có lý do gì để VARCHAR(255) được sử dụng phổ biến như vậy?](http://stackoverflow.com/questions/1217466/is-there-a-good-reason-i-see-varchar255-used-so-often-as-opposed-to-another-l)
* [Giá trị null ảnh hưởng đến hiệu suất như thế nào?](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)
* [Nhật ký truy vấn chậm](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html)

### NoSQL

NoSQL là tập hợp các mục dữ liệu được thể hiện bằng **key-value store**, **document store**, **wide column store**, hoặc **graph database**. Dữ liệu được phi chuẩn hóa và các phép nối thường được thực hiện trong mã ứng dụng. Hầu hết các kho NoSQL không có giao dịch ACID thực sự và ưu tiên [tính nhất quán cuối cùng](#eventual-consistency).

**BASE** thường được dùng để mô tả các đặc tính của cơ sở dữ liệu NoSQL. So với [Định lý CAP](#cap-theorem), BASE chọn tính sẵn sàng thay vì tính nhất quán.

* **Basically available** - hệ thống đảm bảo tính sẵn sàng.
* **Soft state** - trạng thái của hệ thống có thể thay đổi theo thời gian, ngay cả khi không có đầu vào.
* **Eventual consistency** - hệ thống sẽ trở nên nhất quán sau một khoảng thời gian, miễn là hệ thống không nhận thêm đầu vào trong khoảng thời gian đó.

Ngoài việc lựa chọn giữa [SQL hoặc NoSQL](#sql-or-nosql), việc hiểu loại cơ sở dữ liệu NoSQL nào phù hợp nhất với trường hợp sử dụng của bạn cũng rất hữu ích. Chúng ta sẽ xem xét **key-value store**, **document store**, **wide column store**, và **graph database** ở phần tiếp theo.

#### Key-value store

> Trừu tượng: bảng băm

Một key-value store thường cho phép đọc và ghi với độ phức tạp O(1), thường được hỗ trợ bởi bộ nhớ hoặc SSD. Các kho dữ liệu có thể duy trì khóa theo [thứ tự từ điển](https://en.wikipedia.org/wiki/Lexicographical_order), cho phép truy xuất phạm vi khóa hiệu quả. Key-value store có thể lưu trữ siêu dữ liệu cùng với giá trị.

Key-value store cung cấp hiệu năng cao và thường được dùng cho các mô hình dữ liệu đơn giản hoặc dữ liệu thay đổi nhanh, như lớp bộ nhớ đệm trong RAM. Vì chúng chỉ cung cấp một tập hợp thao tác hạn chế, độ phức tạp sẽ chuyển sang tầng ứng dụng nếu cần thêm thao tác.

Key-value store là nền tảng cho các hệ thống phức tạp hơn như document store, và trong một số trường hợp, graph database.

##### Nguồn và tài liệu đọc thêm: key-value store

* [Cơ sở dữ liệu key-value](https://en.wikipedia.org/wiki/Key-value_database)
* [Nhược điểm của key-value store](http://stackoverflow.com/questions/4056093/what-are-the-disadvantages-of-using-a-key-value-table-over-nullable-columns-or)
* [Kiến trúc Redis](http://qnimate.com/overview-of-redis-architecture/)
* [Kiến trúc Memcached](https://adayinthelifeof.nl/2011/02/06/memcache-internals/)

#### Kho lưu trữ tài liệu

> Trừu tượng: kho lưu trữ key-value với tài liệu được lưu trữ dưới dạng giá trị

Kho lưu trữ tài liệu tập trung vào các tài liệu (XML, JSON, nhị phân, v.v.), trong đó một tài liệu lưu trữ toàn bộ thông tin cho một đối tượng nhất định. Kho lưu trữ tài liệu cung cấp API hoặc ngôn ngữ truy vấn để truy vấn dựa trên cấu trúc nội bộ của chính tài liệu đó. *Lưu ý, nhiều kho key-value cũng bao gồm các chức năng làm việc với siêu dữ liệu của giá trị, làm mờ ranh giới giữa hai loại lưu trữ này.*

Tùy thuộc vào cách triển khai bên dưới, tài liệu được tổ chức theo bộ sưu tập, thẻ, siêu dữ liệu hoặc thư mục. Mặc dù tài liệu có thể được tổ chức hoặc nhóm lại, các trường của tài liệu có thể hoàn toàn khác nhau giữa các tài liệu.

Một số kho lưu trữ tài liệu như [MongoDB](https://www.mongodb.com/mongodb-architecture) và [CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/) còn cung cấp ngôn ngữ giống SQL để thực hiện các truy vấn phức tạp. [DynamoDB](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) hỗ trợ cả key-value và tài liệu.

Kho lưu trữ tài liệu mang lại tính linh hoạt cao và thường được sử dụng cho dữ liệu thay đổi không thường xuyên.

##### Nguồn và đọc thêm: kho lưu trữ tài liệu

* [Cơ sở dữ liệu hướng tài liệu](https://en.wikipedia.org/wiki/Document-oriented_database)
* [Kiến trúc MongoDB](https://www.mongodb.com/mongodb-architecture)
* [Kiến trúc CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/)
* [Kiến trúc Elasticsearch](https://www.elastic.co/blog/found-elasticsearch-from-the-bottom-up)

#### Kho lưu trữ cột rộng

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n16iOGk.png">
  <br/>
  <i><a href=http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html>Nguồn: SQL & NoSQL, lịch sử ngắn gọn</a></i>
</p>

> Trừu tượng: bản đồ lồng nhau `ColumnFamily<RowKey, Columns<ColKey, Value, Timestamp>>`

Đơn vị dữ liệu cơ bản của kho lưu trữ cột rộng là một cột (cặp tên/giá trị). Một cột có thể được nhóm thành các họ cột (tương tự như bảng trong SQL). Họ siêu cột tiếp tục nhóm các họ cột. Bạn có thể truy cập từng cột độc lập bằng khóa dòng, và các cột có cùng khóa dòng tạo thành một dòng. Mỗi giá trị chứa một dấu thời gian để phân phiên bản và giải quyết xung đột.

Google đã giới thiệu [Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) là kho lưu trữ cột rộng đầu tiên, ảnh hưởng đến [HBase](https://www.edureka.co/blog/hbase-architecture/) mã nguồn mở thường dùng trong hệ sinh thái Hadoop, và [Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html) của Facebook. Các kho như BigTable, HBase, và Cassandra duy trì các khóa theo thứ tự từ điển, cho phép truy xuất hiệu quả các dải khóa lựa chọn.

Kho lưu trữ cột rộng cung cấp tính sẵn sàng cao và khả năng mở rộng lớn. Chúng thường được sử dụng cho bộ dữ liệu rất lớn.

##### Nguồn và đọc thêm: kho lưu trữ cột rộng

* [SQL & NoSQL, lịch sử ngắn gọn](http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html)
* [Kiến trúc Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf)
* [Kiến trúc HBase](https://www.edureka.co/blog/hbase-architecture/)
* [Kiến trúc Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)

#### Cơ sở dữ liệu đồ thị

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/fNcl65g.png">
  <br/>
  <i><a href=https://en.wikipedia.org/wiki/File:GraphDatabase_PropertyGraph.png>Nguồn: Cơ sở dữ liệu đồ thị</a></i>
</p>

> Trừu tượng: đồ thị

Trong cơ sở dữ liệu đồ thị, mỗi nút là một bản ghi và mỗi cung là một mối quan hệ giữa hai nút. Cơ sở dữ liệu đồ thị được tối ưu hóa để biểu diễn các mối quan hệ phức tạp với nhiều khóa ngoại hoặc các quan hệ nhiều-nhiều.

Cơ sở dữ liệu đồ thị cung cấp hiệu năng cao cho các mô hình dữ liệu có mối quan hệ phức tạp, ví dụ như mạng xã hội. Chúng còn khá mới và chưa được sử dụng rộng rãi; có thể sẽ khó tìm công cụ và tài nguyên phát triển. Nhiều cơ sở dữ liệu đồ thị chỉ có thể truy cập qua [REST APIs](#representational-state-transfer-rest).

##### Nguồn và tài liệu đọc thêm: đồ thị

* [Cơ sở dữ liệu đồ thị](https://en.wikipedia.org/wiki/Graph_database)
* [Neo4j](https://neo4j.com/)
* [FlockDB](https://blog.twitter.com/2010/introducing-flockdb)

#### Nguồn và tài liệu đọc thêm: NoSQL

* [Giải thích các thuật ngữ cơ bản](http://stackoverflow.com/questions/3342497/explanation-of-base-terminology)
* [Khảo sát và hướng dẫn quyết định về cơ sở dữ liệu NoSQL](https://medium.com/baqend-blog/nosql-databases-a-survey-and-decision-guidance-ea7823a822d#.wskogqenq)
* [Khả năng mở rộng](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
* [Giới thiệu về NoSQL](https://www.youtube.com/watch?v=qI_g07C_Q5I)
* [Mẫu NoSQL](http://horicky.blogspot.com/2009/11/nosql-patterns.html)

### SQL hay NoSQL

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wXGqG5f.png">
  <br/>
  <i><a href=https://www.infoq.com/articles/Transition-RDBMS-NoSQL/>Nguồn: Chuyển đổi từ RDBMS sang NoSQL</a></i>
</p>

Lý do chọn **SQL**:

* Dữ liệu có cấu trúc
* Lược đồ nghiêm ngặt
* Dữ liệu quan hệ
* Cần kết hợp phức tạp (joins)
* Giao dịch
* Có các mô hình mở rộng rõ ràng
* Được sử dụng lâu đời: nhiều lập trình viên, cộng đồng, mã nguồn, công cụ, v.v.
* Tìm kiếm theo chỉ mục rất nhanh

Lý do chọn **NoSQL**:

* Dữ liệu bán cấu trúc
* Lược đồ động hoặc linh hoạt
* Dữ liệu phi quan hệ
* Không cần kết hợp phức tạp (joins)
* Lưu trữ nhiều TB (hoặc PB) dữ liệu
* Khối lượng công việc dữ liệu rất lớn
* Thông lượng IOPS rất cao

Dữ liệu mẫu phù hợp với NoSQL:

* Tiếp nhận nhanh dữ liệu clickstream và log
* Dữ liệu bảng xếp hạng hoặc điểm số
* Dữ liệu tạm thời, như giỏ hàng mua sắm
* Các bảng truy cập thường xuyên ('nóng')
* Bảng metadata/tra cứu

##### Nguồn và đọc thêm: SQL hay NoSQL

* [Mở rộng lên đến 10 triệu người dùng đầu tiên](https://www.youtube.com/watch?v=kKjm4ehYiMs)
* [Sự khác biệt giữa SQL và NoSQL](https://www.sitepoint.com/sql-vs-nosql-differences/)

## Bộ nhớ đệm (Cache)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Q6z24La.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>Nguồn: Các mẫu thiết kế hệ thống có khả năng mở rộng</a></i>
</p>

Bộ nhớ đệm giúp cải thiện thời gian tải trang và có thể giảm tải cho máy chủ và cơ sở dữ liệu của bạn. Trong mô hình này, bộ phân phối sẽ kiểm tra xem yêu cầu đã được thực hiện trước đó chưa và cố gắng tìm kết quả trước đó để trả về, nhằm tiết kiệm việc thực thi thực tế.

Cơ sở dữ liệu thường hưởng lợi từ việc phân phối đều các thao tác đọc và ghi trên các phân vùng của nó. Những mục phổ biến có thể làm lệch phân phối, gây ra điểm nghẽn. Đặt bộ nhớ đệm phía trước cơ sở dữ liệu có thể giúp hấp thụ tải không đều và các đợt tăng đột biến lưu lượng truy cập.

### Bộ nhớ đệm phía khách

Bộ nhớ đệm có thể được đặt ở phía khách (hệ điều hành hoặc trình duyệt), [phía máy chủ](#reverse-proxy-web-server), hoặc trong một tầng bộ nhớ đệm riêng biệt.

### Bộ nhớ đệm CDN

[CDN](#content-delivery-network) được xem là một loại bộ nhớ đệm.

### Bộ nhớ đệm máy chủ web

[Reverse proxy](#reverse-proxy-web-server) và các bộ nhớ đệm như [Varnish](https://www.varnish-cache.org/) có thể phục vụ nội dung tĩnh và động trực tiếp. Máy chủ web cũng có thể lưu bộ nhớ đệm các yêu cầu, trả về phản hồi mà không cần liên hệ với máy chủ ứng dụng.

### Bộ nhớ đệm cơ sở dữ liệu

Cơ sở dữ liệu của bạn thường bao gồm một mức bộ nhớ đệm nào đó trong cấu hình mặc định, được tối ưu cho trường hợp sử dụng tổng quát. Tinh chỉnh các thiết lập này cho các mẫu sử dụng cụ thể có thể tăng hiệu suất hơn nữa.

### Bộ nhớ đệm ứng dụng

Các bộ nhớ đệm trong RAM như Memcached và Redis là các kho lưu trữ key-value nằm giữa ứng dụng của bạn và bộ lưu trữ dữ liệu. Vì dữ liệu được giữ trong RAM, nó nhanh hơn nhiều so với các cơ sở dữ liệu thông thường nơi dữ liệu được lưu trên ổ đĩa. RAM bị giới hạn hơn so với ổ đĩa, vì vậy các thuật toán [hủy bộ nhớ đệm](https://en.wikipedia.org/wiki/Cache_algorithms) như [ít được sử dụng gần đây nhất (LRU)](https://en.wikipedia.org/wiki/Cache_replacement_policies#Least_recently_used_(LRU)) có thể giúp loại bỏ các mục 'lạnh' và giữ dữ liệu 'nóng' trong RAM.

Redis có các tính năng bổ sung sau:

* Tùy chọn lưu trữ bền vững
* Các cấu trúc dữ liệu tích hợp như tập hợp có thứ tự và danh sách

Có nhiều cấp độ bạn có thể lưu bộ nhớ đệm, chia thành hai loại chính: **truy vấn cơ sở dữ liệu** và **đối tượng**:

* Cấp độ dòng
* Cấp độ truy vấn
* Đối tượng đã được tuần tự hóa hoàn chỉnh
* HTML đã được render hoàn chỉnh

Thông thường, bạn nên tránh sử dụng bộ nhớ đệm dựa trên tệp, vì nó làm cho việc nhân bản và tự động mở rộng trở nên khó khăn hơn.

### Bộ nhớ đệm ở cấp độ truy vấn cơ sở dữ liệu

Bất cứ khi nào bạn truy vấn cơ sở dữ liệu, hãy băm truy vấn thành một khóa và lưu kết quả vào bộ nhớ đệm. Cách tiếp cận này gặp phải các vấn đề về hết hạn:

* Khó xóa một kết quả đã lưu trong bộ nhớ đệm với các truy vấn phức tạp
* Nếu một phần dữ liệu thay đổi như một ô trong bảng, bạn cần xóa tất cả các truy vấn đã lưu trong bộ nhớ đệm có thể chứa ô đã thay đổi

### Bộ nhớ đệm ở cấp độ đối tượng

Xem dữ liệu của bạn như một đối tượng, giống như cách bạn làm với mã ứng dụng của mình.  Hãy để ứng dụng của bạn tập hợp bộ dữ liệu từ cơ sở dữ liệu thành một thể hiện lớp hoặc một cấu trúc dữ liệu:

* Xóa đối tượng khỏi bộ nhớ đệm nếu dữ liệu cơ bản của nó đã thay đổi
* Cho phép xử lý bất đồng bộ: các worker tập hợp đối tượng bằng cách lấy đối tượng đã lưu trong bộ nhớ đệm mới nhất

Các đề xuất về những gì nên lưu trong bộ nhớ đệm:

* Phiên người dùng
* Các trang web đã được render đầy đủ
* Luồng hoạt động
* Dữ liệu đồ thị người dùng

### Khi nào cập nhật bộ nhớ đệm

Vì bạn chỉ có thể lưu một lượng dữ liệu giới hạn trong bộ nhớ đệm, bạn sẽ cần xác định chiến lược cập nhật bộ nhớ đệm nào phù hợp nhất với trường hợp sử dụng của mình.

#### Cache-aside

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/ONjORqk.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>Nguồn: From cache to in-memory data grid</a></i>
</p>

Ứng dụng chịu trách nhiệm đọc và ghi từ bộ lưu trữ. Bộ nhớ đệm không tương tác trực tiếp với bộ lưu trữ.  Ứng dụng sẽ thực hiện các bước sau:

* Tìm kiếm mục trong bộ nhớ đệm, dẫn đến cache miss
* Tải mục từ cơ sở dữ liệu
* Thêm mục vào bộ nhớ đệm
* Trả về mục

```python
def get_user(self, user_id):
    user = cache.get("user.{0}", user_id)
    if user is None:
        user = db.query("SELECT * FROM users WHERE user_id = {0}", user_id)
        if user is not None:
            key = "user.{0}".format(user_id)
            cache.set(key, json.dumps(user))
    return user
```

[Memcached](https://memcached.org/) thường được sử dụng theo cách này.

Các lần đọc dữ liệu tiếp theo được thêm vào bộ nhớ đệm sẽ rất nhanh. Cache-aside còn được gọi là lazy loading. Chỉ dữ liệu được yêu cầu mới được lưu vào cache, tránh làm đầy bộ nhớ đệm với dữ liệu không được yêu cầu.

##### Nhược điểm: cache-aside

* Mỗi lần cache miss sẽ tạo ra ba lượt truy cập, có thể gây ra độ trễ rõ rệt.
* Dữ liệu có thể trở nên lỗi thời nếu được cập nhật trong cơ sở dữ liệu. Vấn đề này được giảm nhẹ bằng cách đặt thời gian sống (TTL) để buộc cập nhật lại mục trong cache, hoặc sử dụng write-through.
* Khi một node bị lỗi, nó sẽ được thay thế bằng một node mới, rỗng, làm tăng độ trễ.

#### Write-through

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/0vBc0hN.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Nguồn: Scalability, availability, stability, patterns</a></i>
</p>

Ứng dụng sử dụng bộ nhớ đệm như kho lưu trữ dữ liệu chính, đọc và ghi dữ liệu vào đó, trong khi bộ nhớ đệm chịu trách nhiệm đọc và ghi vào cơ sở dữ liệu:

* Ứng dụng thêm/cập nhật mục trong bộ nhớ đệm
* Bộ nhớ đệm ghi mục vào kho dữ liệu một cách đồng bộ
* Trả về

Mã ứng dụng:

```python
set_user(12345, {"foo":"bar"})
```

Mã bộ nhớ đệm: 

```python
def set_user(user_id, values):
    user = db.query("UPDATE Users WHERE id = {0}", user_id, values)
    cache.set(user_id, user)
```
Ghi trực tiếp là một thao tác tổng thể chậm do thao tác ghi, nhưng các lần đọc sau đó đối với dữ liệu vừa được ghi thì nhanh. Người dùng thường dễ chấp nhận độ trễ khi cập nhật dữ liệu hơn là khi đọc dữ liệu. Dữ liệu trong bộ nhớ đệm không bị lỗi thời.

##### Bất lợi: ghi trực tiếp

* Khi một node mới được tạo ra do sự cố hoặc mở rộng, node mới sẽ không lưu vào bộ nhớ đệm các mục cho đến khi mục đó được cập nhật trong cơ sở dữ liệu. Kết hợp cache-aside với ghi trực tiếp có thể giảm thiểu vấn đề này.
* Hầu hết dữ liệu được ghi có thể không bao giờ được đọc, điều này có thể được giảm thiểu với TTL.

#### Ghi phía sau (ghi lại)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/rgSrvjG.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Nguồn: Scalability, availability, stability, patterns</a></i>
</p>

Trong ghi phía sau, ứng dụng thực hiện các bước sau:

* Thêm/cập nhật mục trong bộ nhớ đệm
* Ghi mục vào kho dữ liệu một cách bất đồng bộ, cải thiện hiệu năng ghi

##### Bất lợi: ghi phía sau

* Có thể mất dữ liệu nếu bộ nhớ đệm bị sập trước khi nội dung của nó được ghi vào kho dữ liệu.
* Việc triển khai ghi phía sau phức tạp hơn so với cache-aside hoặc ghi trực tiếp.

#### Làm mới trước (refresh-ahead)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/kxtjqgE.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>Nguồn: From cache to in-memory data grid</a></i>
</p>

Bạn có thể cấu hình bộ nhớ đệm để tự động làm mới bất kỳ mục bộ nhớ đệm nào vừa được truy cập trước khi nó hết hạn.

Làm mới trước có thể giảm độ trễ so với đọc thông qua nếu bộ nhớ đệm dự đoán chính xác các mục sẽ cần trong tương lai.

##### Bất lợi: làm mới trước


* Việc không dự đoán chính xác các mục nào có khả năng cần thiết trong tương lai có thể dẫn đến hiệu suất giảm hơn so với khi không sử dụng refresh-ahead.

### Nhược điểm: bộ nhớ đệm

* Cần duy trì tính nhất quán giữa các bộ nhớ đệm và nguồn dữ liệu gốc như cơ sở dữ liệu thông qua [làm mất hiệu lực bộ nhớ đệm](https://en.wikipedia.org/wiki/Cache_algorithms).
* Làm mất hiệu lực bộ nhớ đệm là một vấn đề khó, có thêm sự phức tạp liên quan đến việc khi nào cần cập nhật bộ nhớ đệm.
* Cần thay đổi ứng dụng như thêm Redis hoặc memcached.

### Nguồn và tài liệu đọc thêm

* [Từ cache đến in-memory data grid](http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast)
* [Các mẫu thiết kế hệ thống có thể mở rộng](http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html)
* [Giới thiệu về kiến trúc hệ thống để mở rộng](http://lethain.com/introduction-to-architecting-systems-for-scale/)
* [Scalability, availability, stability, patterns](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [Scalability](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
* [Chiến lược AWS ElastiCache](http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/Strategies.html)
* [Wikipedia](https://en.wikipedia.org/wiki/Cache_(computing))

## Bất đồng bộ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/54GYsSx.png">
  <br/>
  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>Nguồn: Giới thiệu về kiến trúc hệ thống để mở rộng</a></i>
</p>

Luồng công việc bất đồng bộ giúp giảm thời gian yêu cầu cho các thao tác tốn kém mà bình thường sẽ được thực hiện ngay lập tức. Chúng cũng có thể giúp thực hiện các công việc tốn nhiều thời gian trước, như tổng hợp dữ liệu định kỳ.

### Hàng đợi tin nhắn

Hàng đợi tin nhắn nhận, giữ và chuyển phát tin nhắn. Nếu một thao tác quá chậm để thực hiện ngay, bạn có thể sử dụng hàng đợi tin nhắn với quy trình sau:

* Ứng dụng gửi một công việc vào hàng đợi, sau đó thông báo cho người dùng về trạng thái công việc
* Một worker nhận công việc từ hàng đợi, xử lý, rồi báo hiệu công việc đã hoàn thành

Người dùng không bị chặn và công việc được xử lý ở chế độ nền. Trong thời gian này, client có thể tùy ý thực hiện một số xử lý nhỏ để khiến tác vụ có vẻ như đã hoàn thành. Ví dụ, khi đăng tweet, tweet có thể được đăng ngay lập tức lên timeline của bạn, nhưng có thể mất một thời gian trước khi tweet của bạn thực sự được gửi đến tất cả người theo dõi.

**[Redis](https://redis.io/)** hữu ích như một message broker đơn giản nhưng có thể bị mất tin nhắn.

**[RabbitMQ](https://www.rabbitmq.com/)** phổ biến nhưng yêu cầu bạn phải thích nghi với giao thức 'AMQP' và tự quản lý các node.

**[Amazon SQS](https://aws.amazon.com/sqs/)** là dịch vụ được lưu trữ nhưng có thể có độ trễ cao và có khả năng tin nhắn được gửi hai lần.

### Hàng đợi tác vụ

Hàng đợi tác vụ nhận các tác vụ và dữ liệu liên quan, thực hiện chúng, sau đó trả về kết quả. Chúng có thể hỗ trợ lập lịch và được sử dụng để chạy các công việc tính toán nặng ở chế độ nền.

**[Celery](https://docs.celeryproject.org/en/stable/)** hỗ trợ lập lịch và chủ yếu hỗ trợ python.

### Áp lực ngược (Back pressure)

Nếu các hàng đợi bắt đầu tăng lên đáng kể, kích thước hàng đợi có thể lớn hơn bộ nhớ, dẫn đến lỗi bộ nhớ cache, đọc từ đĩa và hiệu suất chậm hơn. [Áp lực ngược](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html) có thể giúp bằng cách giới hạn kích thước hàng đợi, giữ tốc độ thông lượng cao và thời gian phản hồi tốt cho các công việc đã có trong hàng đợi. Khi hàng đợi đầy, khách hàng sẽ nhận được thông báo máy chủ bận hoặc mã trạng thái HTTP 503 để thử lại sau. Khách hàng có thể thử lại yêu cầu vào thời điểm sau, có thể với [phương pháp lùi theo cấp số nhân](https://en.wikipedia.org/wiki/Exponential_backoff).

### Bất lợi: tính bất đồng bộ

* Các trường hợp sử dụng như tính toán giá rẻ và quy trình thời gian thực có thể phù hợp hơn với hoạt động đồng bộ, vì việc đưa hàng đợi vào có thể gây ra độ trễ và phức tạp.

### Nguồn và đọc thêm

* [Tất cả là một trò chơi số](https://www.youtube.com/watch?v=1KRYH75wgy4)
* [Áp dụng áp lực ngược khi quá tải](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html)
* [Định luật Little](https://en.wikipedia.org/wiki/Little%27s_law)
* [Sự khác biệt giữa hàng đợi tin nhắn và hàng đợi tác vụ là gì?](https://www.quora.com/What-is-the-difference-between-a-message-queue-and-a-task-queue-Why-would-a-task-queue-require-a-message-broker-like-RabbitMQ-Redis-Celery-or-IronMQ-to-function)

## Giao tiếp

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/5KeocQs.jpg">
  <br/>
  <i><a href=http://www.escotal.com/osilayer.html>Nguồn: Mô hình 7 lớp OSI</a></i>
</p>

### Giao thức truyền siêu văn bản (HTTP)

HTTP là một phương thức để mã hóa và truyền dữ liệu giữa máy khách và máy chủ. Đây là giao thức yêu cầu/đáp ứng: máy khách gửi yêu cầu và máy chủ phản hồi với nội dung liên quan và thông tin trạng thái hoàn thành về yêu cầu. HTTP là tự chứa, cho phép yêu cầu và phản hồi đi qua nhiều bộ định tuyến và máy chủ trung gian thực hiện cân bằng tải, bộ nhớ đệm, mã hóa và nén.

Một yêu cầu HTTP cơ bản gồm một động từ (phương thức) và một tài nguyên (điểm cuối). Dưới đây là các động từ HTTP phổ biến:

| Động từ | Mô tả | Idempotent* | An toàn | Có thể lưu vào bộ đệm |
|---|---|---|---|---|
| GET | Đọc một tài nguyên | Có | Có | Có |
| POST | Tạo một tài nguyên hoặc kích hoạt một tiến trình xử lý dữ liệu | Không | Không | Có nếu phản hồi chứa thông tin độ tươi mới |
| PUT | Tạo hoặc thay thế một tài nguyên | Có | Không | Không |
| PATCH | Cập nhật một phần tài nguyên | Không | Không | Có nếu phản hồi chứa thông tin độ tươi mới |
| DELETE | Xóa một tài nguyên | Có | Không | Không |

*Có thể gọi nhiều lần mà không có kết quả khác biệt.

HTTP là một giao thức tầng ứng dụng dựa vào các giao thức tầng thấp hơn như **TCP** và **UDP**.

#### Nguồn và đọc thêm: HTTP

* [HTTP là gì?](https://www.nginx.com/resources/glossary/http/)
* [Sự khác biệt giữa HTTP và TCP](https://www.quora.com/What-is-the-difference-between-HTTP-protocol-and-TCP-protocol)
* [Sự khác biệt giữa PUT và PATCH](https://laracasts.com/discuss/channels/general-discussion/whats-the-differences-between-put-and-patch?page=1)

### Giao thức điều khiển truyền tải (TCP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/JdAsdvG.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>Nguồn: Cách làm game nhiều người chơi</a></i>
</p>

TCP là một giao thức hướng kết nối hoạt động trên [mạng IP](https://en.wikipedia.org/wiki/Internet_Protocol). Kết nối được thiết lập và kết thúc bằng cách sử dụng [bắt tay](https://en.wikipedia.org/wiki/Handshaking). Tất cả các gói gửi đi đều được đảm bảo đến đích theo đúng thứ tự ban đầu và không bị lỗi thông qua:

* Số thứ tự và [trường kiểm tra tổng](https://en.wikipedia.org/wiki/Transmission_Control_Protocol#Checksum_computation) cho từng gói
* Gói [xác nhận](https://en.wikipedia.org/wiki/Acknowledgement_(data_networks)) và tự động truyền lại

Nếu người gửi không nhận được phản hồi đúng, nó sẽ gửi lại các gói. Nếu có nhiều lần hết thời gian chờ, kết nối sẽ bị ngắt. TCP cũng thực hiện [kiểm soát luồng](https://en.wikipedia.org/wiki/Flow_control_(data)) và [kiểm soát tắc nghẽn](https://en.wikipedia.org/wiki/Network_congestion#Congestion_control). Những đảm bảo này gây ra độ trễ và thường dẫn đến việc truyền dữ liệu kém hiệu quả hơn UDP.

Để đảm bảo thông lượng cao, các máy chủ web có thể giữ một số lượng lớn kết nối TCP mở, dẫn đến sử dụng bộ nhớ cao. Việc có nhiều kết nối mở giữa các luồng máy chủ web và ví dụ, một máy chủ [memcached](https://memcached.org/) có thể tốn kém. [Pooling kết nối](https://en.wikipedia.org/wiki/Connection_pool) có thể giúp ngoài việc chuyển sang UDP khi phù hợp.

TCP hữu ích cho các ứng dụng đòi hỏi độ tin cậy cao nhưng không quá nhạy về thời gian. Một số ví dụ bao gồm máy chủ web, dữ liệu cơ sở dữ liệu, SMTP, FTP và SSH.

Sử dụng TCP thay vì UDP khi:

* Bạn cần tất cả dữ liệu phải đến nguyên vẹn
* Bạn muốn tự động ước lượng tối ưu băng thông mạng

### Giao thức datagram người dùng (UDP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yzDrJtA.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>Nguồn: Cách tạo một trò chơi nhiều người chơi</a></i>
</p>

UDP là giao thức không kết nối. Datagram (tương tự như gói tin) chỉ được đảm bảo ở cấp độ datagram. Datagram có thể đến đích không theo thứ tự hoặc có thể không đến được. UDP không hỗ trợ kiểm soát tắc nghẽn. Không có các đảm bảo như TCP, UDP thường hiệu quả hơn.

UDP có thể phát sóng, gửi datagram đến tất cả các thiết bị trong mạng con. Điều này hữu ích với [DHCP](https://en.wikipedia.org/wiki/Dynamic_Host_Configuration_Protocol) vì máy khách chưa nhận được địa chỉ IP, do đó ngăn chặn việc TCP truyền dữ liệu mà không có địa chỉ IP.

UDP kém tin cậy hơn nhưng hoạt động tốt trong các trường hợp sử dụng thời gian thực như VoIP, trò chuyện video, streaming và trò chơi nhiều người chơi thời gian thực.

Sử dụng UDP thay cho TCP khi:

* Bạn cần độ trễ thấp nhất
* Dữ liệu đến muộn còn tệ hơn dữ liệu bị mất
* Bạn muốn tự triển khai cơ chế sửa lỗi

#### Nguồn và đọc thêm: TCP và UDP

* [Mạng cho lập trình game](http://gafferongames.com/networking-for-game-programmers/udp-vs-tcp/)
* [Sự khác biệt chính giữa các giao thức TCP và UDP](http://www.cyberciti.biz/faq/key-differences-between-tcp-and-udp-protocols/)
* [Sự khác biệt giữa TCP và UDP](http://stackoverflow.com/questions/5970383/difference-between-tcp-and-udp)
* [Giao thức điều khiển truyền tải](https://en.wikipedia.org/wiki/Transmission_Control_Protocol)
* [Giao thức datagram người dùng](https://en.wikipedia.org/wiki/User_Datagram_Protocol)
* [Scaling memcache tại Facebook](http://www.cs.bu.edu/~jappavoo/jappavoo.github.com/451/papers/memcache-fb.pdf)

### Gọi thủ tục từ xa (RPC)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/iF4Mkb5.png">
  <br/>
  <i><a href=http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview>Nguồn: Crack the system design interview</a></i>
</p>

Trong RPC, một máy khách gây ra việc thực thi một thủ tục ở không gian địa chỉ khác, thường là máy chủ từ xa. Thủ tục này được mã hóa như một lời gọi thủ tục cục bộ, trừu tượng hóa chi tiết về cách giao tiếp với máy chủ khỏi chương trình máy khách. Các lời gọi từ xa thường chậm hơn và kém tin cậy hơn các lời gọi cục bộ, vì vậy nên phân biệt các lời gọi RPC với lời gọi cục bộ. Các framework RPC phổ biến bao gồm [Protobuf](https://developers.google.com/protocol-buffers/), [Thrift](https://thrift.apache.org/), và [Avro](https://avro.apache.org/docs/current/).

RPC là giao thức yêu cầu-phản hồi:

* **Chương trình khách** - Gọi thủ tục stub phía khách. Các tham số được đẩy lên stack giống như một lời gọi thủ tục cục bộ.
* **Thủ tục stub phía khách** - Đóng gói (marshals) id thủ tục và các tham số vào một thông điệp yêu cầu.
* **Mô-đun truyền thông phía khách** - Hệ điều hành gửi thông điệp từ khách đến máy chủ.
* **Mô-đun truyền thông phía máy chủ** - Hệ điều hành chuyển các gói tin đến thủ tục stub phía máy chủ.
* **Thủ tục stub phía máy chủ** - Giải nén kết quả, gọi thủ tục máy chủ tương ứng với id thủ tục và truyền các tham số đã cho.
* Phản hồi từ máy chủ lặp lại các bước trên theo thứ tự ngược lại.

Ví dụ các lời gọi RPC:

```
GET /someoperation?data=anId

POST /anotheroperation
{
  "data":"anId";
  "anotherdata": "another value"
}
```
RPC tập trung vào việc phơi bày các hành vi. RPC thường được sử dụng vì lý do hiệu năng trong giao tiếp nội bộ, vì bạn có thể tự tay xây dựng các lệnh gọi gốc phù hợp hơn với trường hợp sử dụng của mình.

Chọn thư viện gốc (hay còn gọi là SDK) khi:

* Bạn biết nền tảng mục tiêu của mình.
* Bạn muốn kiểm soát cách "logic" của mình được truy cập.
* Bạn muốn kiểm soát cách kiểm soát lỗi xảy ra bên ngoài thư viện của mình.
* Hiệu năng và trải nghiệm người dùng cuối là mối quan tâm chính của bạn.

HTTP API tuân theo **REST** thường được sử dụng nhiều hơn cho các API công khai.

#### Nhược điểm: RPC

* Các client RPC trở nên phụ thuộc chặt chẽ vào cách triển khai dịch vụ.
* Một API mới phải được định nghĩa cho mỗi thao tác hoặc trường hợp sử dụng mới.
* Có thể khó gỡ lỗi RPC.
* Bạn có thể không tận dụng được các công nghệ hiện có ngay lập tức. Ví dụ, có thể cần thêm nỗ lực để đảm bảo [các lệnh gọi RPC được lưu vào bộ nhớ đệm đúng cách](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/) trên các máy chủ cache như [Squid](http://www.squid-cache.org/).

### Representational state transfer (REST)

REST là một kiểu kiến trúc áp đặt mô hình client/server, trong đó client thao tác trên tập hợp các tài nguyên do server quản lý. Server cung cấp đại diện của tài nguyên và các hành động có thể thao tác hoặc lấy đại diện mới của tài nguyên đó. Mọi giao tiếp đều phải không trạng thái và có thể lưu vào bộ nhớ đệm.

Có bốn đặc tính của một giao diện RESTful:

* **Định danh tài nguyên (URI trong HTTP)** - sử dụng cùng một URI bất kể thao tác nào.
* **Thay đổi theo đại diện (Động từ trong HTTP)** - sử dụng động từ, header và body.
* **Thông điệp lỗi tự mô tả (phản hồi trạng thái trong HTTP)** - sử dụng mã trạng thái, không phát minh lại bánh xe.
* **[HATEOAS](http://restcookbook.com/Basics/hateoas/) (giao diện HTML cho HTTP)** - dịch vụ web của bạn nên được truy cập đầy đủ qua trình duyệt.

Ví dụ các lệnh gọi REST:


```
GET /someresources/anId

PUT /someresources/anId
{"anotherdata": "another value"}
```
REST tập trung vào việc cung cấp dữ liệu. Nó giảm thiểu sự kết nối chặt chẽ giữa client/server và thường được sử dụng cho các HTTP API công khai. REST sử dụng phương pháp cung cấp tài nguyên thông qua URI một cách tổng quát và đồng nhất, [biểu diễn qua các header](https://github.com/for-GET/know-your-http-well/blob/master/headers.md), và hành động qua các động từ như GET, POST, PUT, DELETE và PATCH. Là stateless, REST rất phù hợp cho mở rộng ngang và phân vùng.

#### Nhược điểm: REST

* Vì REST tập trung vào việc cung cấp dữ liệu, nó có thể không phù hợp nếu tài nguyên không được tổ chức hoặc truy cập một cách tự nhiên trong một hệ thống phân cấp đơn giản. Ví dụ, trả về tất cả các bản ghi cập nhật trong giờ qua phù hợp với một tập hợp sự kiện cụ thể không dễ dàng thể hiện dưới dạng một đường dẫn. Với REST, có khả năng phải thực hiện với sự kết hợp của đường dẫn URI, tham số truy vấn và có thể là phần thân yêu cầu.
* REST thường dựa vào một vài động từ (GET, POST, PUT, DELETE và PATCH) mà đôi khi không phù hợp với trường hợp sử dụng của bạn. Ví dụ, di chuyển tài liệu hết hạn vào thư mục lưu trữ có thể không phù hợp một cách rõ ràng với các động từ này.
* Việc lấy các tài nguyên phức tạp với cấu trúc phân cấp lồng nhau cần nhiều lần trao đổi giữa client và server để hiển thị một view duy nhất, ví dụ như lấy nội dung của một bài blog và các bình luận trên bài đó. Đối với các ứng dụng di động hoạt động trong điều kiện mạng thay đổi, nhiều lần trao đổi này là điều rất không mong muốn.
* Theo thời gian, có thể có thêm nhiều trường dữ liệu được bổ sung vào phản hồi API và các client cũ sẽ nhận tất cả các trường dữ liệu mới, kể cả những trường mà chúng không cần, dẫn đến payload bị phình to và độ trễ lớn hơn.

### So sánh các gọi RPC và REST

| Hoạt động | RPC | REST |
|---|---|---|
| Đăng ký    | **POST** /signup | **POST** /persons |
| Nghỉ việc    | **POST** /resign<br/>{<br/>"personid": "1234"<br/>} | **DELETE** /persons/1234 |
| Đọc thông tin một người | **GET** /readPerson?personid=1234 | **GET** /persons/1234 |
| Đọc danh sách vật phẩm của một người | **GET** /readUsersItemsList?personid=1234 | **GET** /persons/1234/items |
| Thêm vật phẩm vào danh sách của một người | **POST** /addItemToUsersItemsList<br/>{<br/>"personid": "1234";<br/>"itemid": "456"<br/>} | **POST** /persons/1234/items<br/>{<br/>"itemid": "456"<br/>} |
| Cập nhật vật phẩm    | **POST** /modifyItem<br/>{<br/>"itemid": "456";<br/>"key": "value"<br/>} | **PUT** /items/456<br/>{<br/>"key": "value"<br/>} |
| Xóa vật phẩm | **POST** /removeItem<br/>{<br/>"itemid": "456"<br/>} | **DELETE** /items/456 |

<p align="center">
  <i><a href=https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/>Nguồn: Bạn có thật sự biết vì sao bạn thích REST hơn RPC không</a></i>
</p>

#### Nguồn và tài liệu đọc thêm: REST và RPC

* [Bạn có thật sự biết vì sao bạn thích REST hơn RPC không](https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/)
* [Khi nào cách tiếp cận kiểu RPC phù hợp hơn REST?](http://programmers.stackexchange.com/a/181186)
* [REST vs JSON-RPC](http://stackoverflow.com/questions/15056878/rest-vs-json-rpc)
* [Phá bỏ các huyền thoại về RPC và REST](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/)
* [Những bất lợi khi sử dụng REST](https://www.quora.com/What-are-the-drawbacks-of-using-RESTful-APIs)
* [Crack the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Thrift](https://code.facebook.com/posts/1468950976659943/)
* [Tại sao REST dùng cho nội bộ mà không phải RPC](http://arstechnica.com/civis/viewtopic.php?t=1190508)

## Bảo mật

Phần này có thể cần cập nhật. Hãy cân nhắc [đóng góp](#contributing)!

Bảo mật là một chủ đề rộng. Trừ khi bạn có kinh nghiệm đáng kể, có nền tảng về bảo mật, hoặc đang ứng tuyển vào vị trí yêu cầu kiến thức về bảo mật, bạn có lẽ chỉ cần biết những điều cơ bản sau:

* Mã hóa dữ liệu khi truyền và khi lưu trữ.
* Làm sạch tất cả dữ liệu đầu vào từ người dùng hoặc bất kỳ tham số nào được người dùng truy cập để ngăn chặn [XSS](https://en.wikipedia.org/wiki/Cross-site_scripting) và [SQL injection](https://en.wikipedia.org/wiki/SQL_injection).
* Sử dụng truy vấn tham số hóa để ngăn SQL injection.
* Áp dụng nguyên tắc [quyền hạn tối thiểu](https://en.wikipedia.org/wiki/Principle_of_least_privilege).

### Nguồn và tài liệu đọc thêm

* [Danh sách kiểm tra bảo mật API](https://github.com/shieldfy/API-Security-Checklist)
* [Hướng dẫn bảo mật cho lập trình viên](https://github.com/FallibleInc/security-guide-for-developers)
* [OWASP top ten](https://www.owasp.org/index.php/OWASP_Top_Ten_Cheat_Sheet)

## Phụ lục

Đôi khi bạn sẽ được yêu cầu ước lượng nhanh. Ví dụ, bạn có thể cần xác định mất bao lâu để tạo 100 ảnh thumbnail từ đĩa hoặc một cấu trúc dữ liệu sẽ tiêu tốn bao nhiêu bộ nhớ. **Bảng số mũ của hai** và **Các con số độ trễ mà lập trình viên nên biết** là những tài liệu tham khảo hữu ích.

### Bảng số mũ của hai


```
Power           Exact Value         Approx Value        Bytes
---------------------------------------------------------------
7                             128
8                             256
10                           1024   1 thousand           1 KB
16                         65,536                       64 KB
20                      1,048,576   1 million            1 MB
30                  1,073,741,824   1 billion            1 GB
32                  4,294,967,296                        4 GB
40              1,099,511,627,776   1 trillion           1 TB
```

#### Nguồn và tài liệu đọc thêm

* [Lũy thừa của hai](https://vi.wikipedia.org/wiki/L%C5%A9y_th%E1%BB%ABa_c%E1%BB%A7a_hai)

### Những con số độ trễ mà mọi lập trình viên nên biết

```
Latency Comparison Numbers
--------------------------
L1 cache reference                           0.5 ns
Branch mispredict                            5   ns
L2 cache reference                           7   ns                      14x L1 cache
Mutex lock/unlock                           25   ns
Main memory reference                      100   ns                      20x L2 cache, 200x L1 cache
Compress 1K bytes with Zippy            10,000   ns       10 us
Send 1 KB bytes over 1 Gbps network     10,000   ns       10 us
Read 4 KB randomly from SSD*           150,000   ns      150 us          ~1GB/sec SSD
Read 1 MB sequentially from memory     250,000   ns      250 us
Round trip within same datacenter      500,000   ns      500 us
Read 1 MB sequentially from SSD*     1,000,000   ns    1,000 us    1 ms  ~1GB/sec SSD, 4X memory
HDD seek                            10,000,000   ns   10,000 us   10 ms  20x datacenter roundtrip
Read 1 MB sequentially from 1 Gbps  10,000,000   ns   10,000 us   10 ms  40x memory, 10X SSD
Read 1 MB sequentially from HDD     30,000,000   ns   30,000 us   30 ms 120x memory, 30X SSD
Send packet CA->Netherlands->CA    150,000,000   ns  150,000 us  150 ms

Notes
-----
1 ns = 10^-9 seconds
1 us = 10^-6 seconds = 1,000 ns
1 ms = 10^-3 seconds = 1,000 us = 1,000,000 ns
```
Các chỉ số hữu ích dựa trên các con số ở trên:

* Đọc tuần tự từ HDD ở tốc độ 30 MB/s
* Đọc tuần tự từ Ethernet 1 Gbps ở tốc độ 100 MB/s
* Đọc tuần tự từ SSD ở tốc độ 1 GB/s
* Đọc tuần tự từ bộ nhớ chính ở tốc độ 4 GB/s
* 6-7 lượt đi/về toàn cầu mỗi giây
* 2.000 lượt đi/về mỗi giây trong một trung tâm dữ liệu

#### Hình minh họa các con số độ trễ

![](https://camo.githubusercontent.com/77f72259e1eb58596b564d1ad823af1853bc60a3/687474703a2f2f692e696d6775722e636f6d2f6b307431652e706e67)

#### Nguồn và tài liệu đọc thêm

* [Những con số độ trễ mà lập trình viên nên biết - 1](https://gist.github.com/jboner/2841832)
* [Những con số độ trễ mà lập trình viên nên biết - 2](https://gist.github.com/hellerbarde/2843375)
* [Thiết kế, bài học và lời khuyên khi xây dựng hệ thống phân tán lớn](http://www.cs.cornell.edu/projects/ladis2009/talks/dean-keynote-ladis2009.pdf)
* [Lời khuyên Kỹ thuật phần mềm từ việc xây dựng hệ thống phân tán quy mô lớn](https://static.googleusercontent.com/media/research.google.com/en//people/jeff/stanford-295-talk.pdf)

### Các câu hỏi phỏng vấn thiết kế hệ thống bổ sung

> Các câu hỏi phỏng vấn thiết kế hệ thống phổ biến, kèm liên kết đến tài liệu hướng dẫn cách giải.

| Câu hỏi | Tài liệu tham khảo |
|---|---|
| Thiết kế dịch vụ đồng bộ tập tin như Dropbox | [youtube.com](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| Thiết kế công cụ tìm kiếm như Google | [queue.acm.org](http://queue.acm.org/detail.cfm?id=988407)<br/>[stackexchange.com](http://programmers.stackexchange.com/questions/38324/interview-question-how-would-you-implement-google-search)<br/>[ardendertat.com](http://www.ardendertat.com/2012/01/11/implementing-search-engines/)<br/>[stanford.edu](http://infolab.stanford.edu/~backrub/google.html) |
| Thiết kế trình thu thập dữ liệu web có khả năng mở rộng như Google | [quora.com](https://www.quora.com/How-can-I-build-a-web-crawler-from-scratch) |
| Thiết kế Google Docs | [code.google.com](https://code.google.com/p/google-mobwrite/)<br/>[neil.fraser.name](https://neil.fraser.name/writing/sync/) |
| Thiết kế kho key-value như Redis | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| Thiết kế hệ thống cache như Memcached | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| Thiết kế hệ thống đề xuất như Amazon | [hulu.com](https://web.archive.org/web/20170406065247/http://tech.hulu.com/blog/2011/09/19/recommendation-system.html)<br/>[ijcai13.org](http://ijcai13.org/files/tutorial_slides/td3.pdf) |
| Thiết kế hệ thống tinyurl như Bitly | [n00tc0d3r.blogspot.com](http://n00tc0d3r.blogspot.com/) |
| Thiết kế ứng dụng chat như WhatsApp | [highscalability.com](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html)
| Thiết kế hệ thống chia sẻ ảnh như Instagram | [highscalability.com](http://highscalability.com/flickr-architecture)<br/>[highscalability.com](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html) |
| Thiết kế chức năng news feed của Facebook | [quora.com](http://www.quora.com/What-are-best-practices-for-building-something-like-a-News-Feed)<br/>[quora.com](http://www.quora.com/Activity-Streams/What-are-the-scaling-issues-to-keep-in-mind-while-developing-a-social-network-feed)<br/>[slideshare.net](http://www.slideshare.net/danmckinley/etsy-activity-feeds-architecture) |
| Thiết kế chức năng timeline của Facebook | [facebook.com](https://www.facebook.com/note.php?note_id=10150468255628920)<br/>[highscalability.com](http://highscalability.com/blog/2012/1/23/facebook-timeline-brought-to-you-by-the-power-of-denormaliza.html) |
| Thiết kế chức năng chat của Facebook | [erlang-factory.com](http://www.erlang-factory.com/upload/presentations/31/EugeneLetuchy-ErlangatFacebook.pdf)<br/>[facebook.com](https://www.facebook.com/note.php?note_id=14218138919&id=9445547199&index=0) |

| Thiết kế một chức năng tìm kiếm đồ thị giống Facebook | [facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-building-out-the-infrastructure-for-graph-search/10151347573598920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-indexing-and-ranking-in-graph-search/10151361720763920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-the-natural-language-interface-of-graph-search/10151432733048920) |
| Thiết kế một mạng phân phối nội dung giống CloudFlare | [figshare.com](https://figshare.com/articles/Globally_distributed_content_delivery/6605972) |
| Thiết kế hệ thống chủ đề thịnh hành giống Twitter | [michael-noll.com](http://www.michael-noll.com/blog/2013/01/18/implementing-real-time-trending-topics-in-storm/)<br/>[snikolov .wordpress.com](http://snikolov.wordpress.com/2012/11/14/early-detection-of-twitter-trends/) |
| Thiết kế hệ thống sinh ID ngẫu nhiên | [blog.twitter.com](https://blog.twitter.com/2010/announcing-snowflake)<br/>[github.com](https://github.com/twitter/snowflake/) |
| Trả về k yêu cầu hàng đầu trong một khoảng thời gian | [cs.ucsb.edu](https://www.cs.ucsb.edu/sites/default/files/documents/2005-23.pdf)<br/>[wpi.edu](http://davis.wpi.edu/xmdv/docs/EDBT11-diyang.pdf) |
| Thiết kế hệ thống phục vụ dữ liệu từ nhiều trung tâm dữ liệu | [highscalability.com](http://highscalability.com/blog/2009/8/24/how-google-serves-data-from-multiple-datacenters.html) |
| Thiết kế trò chơi bài đa người chơi trực tuyến | [indieflashblog.com](https://web.archive.org/web/20180929181117/http://www.indieflashblog.com/how-to-create-an-asynchronous-multiplayer-game.html)<br/>[buildnewgames.com](http://buildnewgames.com/real-time-multiplayer/) |
| Thiết kế hệ thống thu gom rác | [stuffwithstuff.com](http://journal.stuffwithstuff.com/2013/12/08/babys-first-garbage-collector/)<br/>[washington.edu](http://courses.cs.washington.edu/courses/csep521/07wi/prj/rick.pdf) |
| Thiết kế bộ giới hạn tần suất gọi API | [https://stripe.com/blog/](https://stripe.com/blog/rate-limiters) |
| Thiết kế một Sàn giao dịch chứng khoán (như NASDAQ hoặc Binance) | [Jane Street](https://youtu.be/b1e4t2k2KJY)<br/>[Golang Implementation](https://around25.com/blog/building-a-trading-engine-for-a-crypto-exchange/)<br/>[Go Implementation](http://bhomnick.net/building-a-simple-limit-order-in-go/) |
| Thêm một câu hỏi thiết kế hệ thống | [Đóng góp](#contributing) |

### Kiến trúc thực tế

> Các bài viết về cách hệ thống thực tế được thiết kế.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/TcUo2fw.png">
  <br/>
  <i><a href=https://www.infoq.com/presentations/Twitter-Timeline-Scalability>Nguồn: Twitter timelines at scale</a></i>
</p>

**Đừng tập trung vào chi tiết vụn vặt trong các bài viết sau, thay vào đó:**

* Xác định các nguyên lý chung, công nghệ phổ biến và mẫu thiết kế trong các bài viết này
* Tìm hiểu các vấn đề được giải quyết bởi từng thành phần, điểm mạnh, điểm yếu
* Xem lại các bài học kinh nghiệm

|Loại | Hệ thống | Tài liệu tham khảo |
|---|---|---|
| Xử lý dữ liệu | **MapReduce** - Xử lý dữ liệu phân tán từ Google | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/mapreduce-osdi04.pdf) |
| Xử lý dữ liệu | **Spark** - Xử lý dữ liệu phân tán từ Databricks | [slideshare.net](http://www.slideshare.net/AGrishchenko/apache-spark-architecture) |
| Xử lý dữ liệu | **Storm** - Xử lý dữ liệu phân tán từ Twitter | [slideshare.net](http://www.slideshare.net/previa/storm-16094009) |
| | | |
| Kho dữ liệu | **Bigtable** - Cơ sở dữ liệu cột phân tán từ Google | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) |
| Kho dữ liệu | **HBase** - Triển khai mã nguồn mở của Bigtable | [slideshare.net](http://www.slideshare.net/alexbaranau/intro-to-hbase) |
| Kho dữ liệu | **Cassandra** - Cơ sở dữ liệu cột phân tán từ Facebook | [slideshare.net](http://www.slideshare.net/planetcassandra/cassandra-introduction-features-30103666)
| Kho dữ liệu | **DynamoDB** - Cơ sở dữ liệu hướng tài liệu từ Amazon | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) |
| Kho dữ liệu | **MongoDB** - Cơ sở dữ liệu hướng tài liệu | [slideshare.net](http://www.slideshare.net/mdirolf/introduction-to-mongodb) |
| Kho dữ liệu | **Spanner** - Cơ sở dữ liệu phân tán toàn cầu từ Google | [research.google.com](http://research.google.com/archive/spanner-osdi2012.pdf) |
| Kho dữ liệu | **Memcached** - Hệ thống bộ nhớ đệm phân tán | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| Kho dữ liệu | **Redis** - Hệ thống bộ nhớ đệm phân tán có khả năng lưu trữ lâu dài và kiểu giá trị | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| | | |
| Hệ thống tập tin | **Google File System (GFS)** - Hệ thống tập tin phân tán | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/gfs-sosp2003.pdf) |
| Hệ thống tập tin | **Hadoop File System (HDFS)** - Phiên bản mã nguồn mở của GFS | [apache.org](http://hadoop.apache.org/docs/stable/hadoop-project-dist/hadoop-hdfs/HdfsDesign.html) |
| | | |
| Khác | **Chubby** - Dịch vụ khóa cho các hệ thống phân tán liên kết lỏng của Google | [research.google.com](http://static.googleusercontent.com/external_content/untrusted_dlcp/research.google.com/en/us/archive/chubby-osdi06.pdf) |
| Khác | **Dapper** - Hạ tầng truy vết hệ thống phân tán | [research.google.com](http://static.googleusercontent.com/media/research.google.com/en//pubs/archive/36356.pdf)
| Khác | **Kafka** - Hàng đợi thông điệp pub/sub từ LinkedIn | [slideshare.net](http://www.slideshare.net/mumrah/kafka-talk-tri-hug) |
| Khác | **Zookeeper** - Hạ tầng và dịch vụ tập trung hỗ trợ đồng bộ hóa | [slideshare.net](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) |
| | Thêm kiến trúc | [Đóng góp](#contributing) |

### Kiến trúc của các công ty

| Công ty | Tham khảo |
|---|---|
| Amazon | [Kiến trúc Amazon](http://highscalability.com/amazon-architecture) |
| Cinchcast | [Sản xuất 1.500 giờ âm thanh mỗi ngày](http://highscalability.com/blog/2012/7/16/cinchcast-architecture-producing-1500-hours-of-audio-every-d.html) |
| DataSift | [Khai thác dữ liệu thời gian thực với 120.000 tweet mỗi giây](http://highscalability.com/blog/2011/11/29/datasift-architecture-realtime-datamining-at-120000-tweets-p.html) |
| Dropbox | [Cách Dropbox mở rộng quy mô](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| ESPN | [Vận hành với 100.000 duh nuh nuhs mỗi giây](http://highscalability.com/blog/2013/11/4/espns-architecture-at-scale-operating-at-100000-duh-nuh-nuhs.html) |
| Google | [Kiến trúc Google](http://highscalability.com/google-architecture) |
| Instagram | [14 triệu người dùng, hàng terabyte ảnh](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html)<br/>[Công nghệ phía sau Instagram](http://instagram-engineering.tumblr.com/post/13649370142/what-powers-instagram-hundreds-of-instances) |
| Justin.tv | [Kiến trúc phát video trực tuyến của Justin.tv](http://highscalability.com/blog/2010/3/16/justintvs-live-video-broadcasting-architecture.html) |
| Facebook | [Mở rộng memcached tại Facebook](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/key-value/fb-memcached-nsdi-2013.pdf)<br/>[TAO: Kho dữ liệu phân tán cho social graph của Facebook](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/data-store/tao-facebook-distributed-datastore-atc-2013.pdf)<br/>[Lưu trữ ảnh của Facebook](https://www.usenix.org/legacy/event/osdi10/tech/full_papers/Beaver.pdf)<br/>[Cách Facebook Live phát trực tiếp đến 800.000 người xem đồng thời](http://highscalability.com/blog/2016/6/27/how-facebook-live-streams-to-800000-simultaneous-viewers.html) |
| Flickr | [Kiến trúc Flickr](http://highscalability.com/flickr-architecture) |
| Mailbox | [Từ 0 đến một triệu người dùng trong 6 tuần](http://highscalability.com/blog/2013/6/18/scaling-mailbox-from-0-to-one-million-users-in-6-weeks-and-1.html) |
| Netflix | [Toàn cảnh hệ thống Netflix](http://highscalability.com/blog/2015/11/9/a-360-degree-view-of-the-entire-netflix-stack.html)<br/>[Netflix: Chuyện gì xảy ra khi bạn nhấn Play?](http://highscalability.com/blog/2017/12/11/netflix-what-happens-when-you-press-play.html) |
| Pinterest | [Từ 0 đến hàng chục tỷ lượt xem trang mỗi tháng](http://highscalability.com/blog/2013/4/15/scaling-pinterest-from-0-to-10s-of-billions-of-page-views-a.html)<br/>[18 triệu khách truy cập, tăng trưởng 10 lần, 12 nhân viên](http://highscalability.com/blog/2012/5/21/pinterest-architecture-update-18-million-visitors-10x-growth.html) |
| Playfish | [50 triệu người dùng hàng tháng và tiếp tục tăng trưởng](http://highscalability.com/blog/2010/9/21/playfishs-social-gaming-architecture-50-million-monthly-user.html) |
| PlentyOfFish | [Kiến trúc PlentyOfFish](http://highscalability.com/plentyoffish-architecture) |
| Salesforce | [Cách họ xử lý 1,3 tỷ giao dịch mỗi ngày](http://highscalability.com/blog/2013/9/23/salesforce-architecture-how-they-handle-13-billion-transacti.html) |
| Stack Overflow | [Kiến trúc Stack Overflow](http://highscalability.com/blog/2009/8/5/stack-overflow-architecture.html) |
| TripAdvisor | [40 triệu khách truy cập, 200 triệu lượt xem trang động, 30TB dữ liệu](http://highscalability.com/blog/2011/6/27/tripadvisor-architecture-40m-visitors-200m-dynamic-page-view.html) |
| Tumblr | [15 tỷ lượt xem trang mỗi tháng](http://highscalability.com/blog/2012/2/13/tumblr-architecture-15-billion-page-views-a-month-and-harder.html) |
| Twitter | [Làm Twitter nhanh hơn 10.000 lần](http://highscalability.com/scaling-twitter-making-twitter-10000-percent-faster)<br/>[Lưu trữ 250 triệu tweet mỗi ngày bằng MySQL](http://highscalability.com/blog/2011/12/19/how-twitter-stores-250-million-tweets-a-day-using-mysql.html)<br/>[150 triệu người dùng hoạt động, 300K QPS, 22 MB/S dữ liệu lớn](http://highscalability.com/blog/2013/7/8/the-architecture-twitter-uses-to-deal-with-150m-active-users.html)<br/>[Timeline ở quy mô lớn](https://www.infoq.com/presentations/Twitter-Timeline-Scalability)<br/>[Dữ liệu lớn và nhỏ tại Twitter](https://www.youtube.com/watch?v=5cKTP36HVgI)<br/>[Vận hành tại Twitter: mở rộng vượt quá 100 triệu người dùng](https://www.youtube.com/watch?v=z8LU0Cj6BOU)<br/>[Cách Twitter xử lý 3.000 ảnh mỗi giây](http://highscalability.com/blog/2016/4/20/how-twitter-handles-3000-images-per-second.html) |
| Uber | [Cách Uber mở rộng nền tảng thị trường thời gian thực](http://highscalability.com/blog/2015/9/14/how-uber-scales-their-real-time-market-platform.html)<br/>[Bài học từ việc mở rộng Uber lên 2000 kỹ sư, 1000 dịch vụ, và 8000 kho Git](http://highscalability.com/blog/2016/10/12/lessons-learned-from-scaling-uber-to-2000-engineers-1000-ser.html) |
| WhatsApp | [Kiến trúc WhatsApp mà Facebook mua với giá 19 tỷ USD](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html) |
| YouTube | [Khả năng mở rộng của YouTube](https://www.youtube.com/watch?v=w5WVu624fY8)<br/>[Kiến trúc YouTube](http://highscalability.com/youtube-architecture) |

### Blog kỹ thuật của các công ty

> Kiến trúc của các công ty mà bạn đang phỏng vấn.
>
> Những câu hỏi bạn gặp phải có thể đến từ cùng một lĩnh vực.

* [Airbnb Engineering](http://nerds.airbnb.com/)
* [Atlassian Developers](https://developer.atlassian.com/blog/)
* [AWS Blog](https://aws.amazon.com/blogs/aws/)
* [Bitly Engineering Blog](http://word.bitly.com/)
* [Box Blogs](https://blog.box.com/blog/category/engineering)
* [Cloudera Developer Blog](http://blog.cloudera.com/)
* [Dropbox Tech Blog](https://tech.dropbox.com/)
* [Engineering at Quora](https://www.quora.com/q/quoraengineering)
* [Ebay Tech Blog](http://www.ebaytechblog.com/)
* [Evernote Tech Blog](https://blog.evernote.com/tech/)
* [Etsy Code as Craft](http://codeascraft.com/)
* [Facebook Engineering](https://www.facebook.com/Engineering)
* [Flickr Code](http://code.flickr.net/)
* [Foursquare Engineering Blog](http://engineering.foursquare.com/)
* [GitHub Engineering Blog](https://github.blog/category/engineering)
* [Google Research Blog](http://googleresearch.blogspot.com/)
* [Groupon Engineering Blog](https://engineering.groupon.com/)
* [Heroku Engineering Blog](https://engineering.heroku.com/)
* [Hubspot Engineering Blog](http://product.hubspot.com/blog/topic/engineering)
* [High Scalability](http://highscalability.com/)
* [Instagram Engineering](http://instagram-engineering.tumblr.com/)
* [Intel Software Blog](https://software.intel.com/en-us/blogs/)
* [Jane Street Tech Blog](https://blogs.janestreet.com/category/ocaml/)
* [LinkedIn Engineering](http://engineering.linkedin.com/blog)
* [Microsoft Engineering](https://engineering.microsoft.com/)
* [Microsoft Python Engineering](https://blogs.msdn.microsoft.com/pythonengineering/)
* [Netflix Tech Blog](http://techblog.netflix.com/)
* [Paypal Developer Blog](https://medium.com/paypal-engineering)
* [Pinterest Engineering Blog](https://medium.com/@Pinterest_Engineering)
* [Reddit Blog](http://www.redditblog.com/)
* [Salesforce Engineering Blog](https://developer.salesforce.com/blogs/engineering/)
* [Slack Engineering Blog](https://slack.engineering/)
* [Spotify Labs](https://labs.spotify.com/)
* [Stripe Engineering Blog](https://stripe.com/blog/engineering)
* [Twilio Engineering Blog](http://www.twilio.com/engineering)
* [Twitter Engineering](https://blog.twitter.com/engineering/)
* [Uber Engineering Blog](http://eng.uber.com/)
* [Yahoo Engineering Blog](http://yahooeng.tumblr.com/)
* [Yelp Engineering Blog](http://engineeringblog.yelp.com/)
* [Zynga Engineering Blog](https://www.zynga.com/blogs/engineering)

#### Nguồn và đọc thêm

Muốn thêm blog? Để tránh trùng lặp công việc, hãy cân nhắc thêm blog công ty của bạn vào kho lưu trữ sau:

* [kilimchoi/engineering-blogs](https://github.com/kilimchoi/engineering-blogs)

## Đang phát triển

Quan tâm đến việc thêm một mục hoặc giúp hoàn thành một mục đang tiến hành? [Đóng góp](#contributing)!

* Điện toán phân tán với MapReduce
* Băm nhất quán
* Scatter gather
* [Đóng góp](#contributing)

## Ghi công

Ghi công và nguồn được cung cấp xuyên suốt kho lưu trữ này.

Đặc biệt cảm ơn:

* [Hired in tech](http://www.hiredintech.com/system-design/the-system-design-process/)
* [Cracking the coding interview](https://www.amazon.com/dp/0984782850/)
* [High scalability](http://highscalability.com/)
* [checkcheckzz/system-design-interview](https://github.com/checkcheckzz/system-design-interview)
* [shashank88/system_design](https://github.com/shashank88/system_design)
* [mmcgrana/services-engineering](https://github.com/mmcgrana/services-engineering)
* [System design cheat sheet](https://gist.github.com/vasanthk/485d1c25737e8e72759f)
* [A distributed systems reading list](http://dancres.github.io/Pages/)
* [Cracking the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)

## Thông tin liên hệ

Hãy liên hệ với tôi để thảo luận về bất kỳ vấn đề, câu hỏi hoặc ý kiến nào.

Thông tin liên hệ của tôi có thể được tìm thấy trên [trang GitHub của tôi](https://github.com/donnemartin).

## Giấy phép

*Tôi cung cấp mã nguồn và tài nguyên trong kho lưu trữ này cho bạn theo giấy phép nguồn mở. Vì đây là kho lưu trữ cá nhân của tôi, giấy phép bạn nhận được đối với mã nguồn và tài nguyên là từ tôi chứ không phải từ công ty tôi (Facebook).*

    Bản quyền 2017 Donne Martin

    Giấy phép Creative Commons Attribution 4.0 International License (CC BY 4.0)

    http://creativecommons.org/licenses/by/4.0/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---