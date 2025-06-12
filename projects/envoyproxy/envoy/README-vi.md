![Envoy Logo](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[Proxy biên/middle/service hiệu năng cao, cloud-native](https://www.envoyproxy.io/)

Envoy được tổ chức bởi [Cloud Native Computing Foundation](https://cncf.io) (CNCF). Nếu bạn là
một công ty muốn đóng góp vào sự phát triển của các công nghệ đóng gói container,
lên lịch động và định hướng microservices, hãy cân nhắc tham gia CNCF. Để biết chi tiết về những ai
tham gia và vai trò của Envoy, hãy đọc thông báo của CNCF
[announcement](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/).

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## Tài liệu

* [Tài liệu chính thức](https://www.envoyproxy.io/)
* [Câu hỏi thường gặp (FAQ)](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [Tài liệu ví dụ](https://github.com/envoyproxy/examples/)
* [Blog](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310) về mô hình luồng của Envoy
* [Blog](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5) về khởi động lại nóng
* [Blog](https://medium.com/@mattklein123/envoy-stats-b65c7f363342) về kiến trúc thống kê
* [Blog](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a) về Universal Data Plane API
* [Blog](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1) về bảng điều khiển Envoy của Lyft

## Liên quan

* [data-plane-api](https://github.com/envoyproxy/data-plane-api): Định nghĩa API v2 dưới dạng một kho lưu trữ độc lập. Đây là bản mirror chỉ đọc của [api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/).
* [envoy-perf](https://github.com/envoyproxy/envoy-perf): Khung kiểm thử hiệu năng.
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example): Ví dụ về cách thêm bộ lọc mới và liên kết tới kho lưu trữ chính.

## Liên hệ

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce): Danh sách gửi thư tần suất thấp, chỉ gửi thông báo.
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce): Danh sách gửi thư tần suất thấp, chỉ gửi thông báo liên quan đến bảo mật.
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users): Thảo luận chung cho người dùng.
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev): Thảo luận phát triển Envoy (API, thiết kế tính năng, v.v.).
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers): Sử dụng danh sách này để liên hệ với tất cả các maintainer chính của Envoy.
* [Twitter](https://twitter.com/EnvoyProxy/): Theo dõi trên Twitter!
* [Slack](https://envoyproxy.slack.com/): Tham gia Slack, để được mời hãy vào [đây](https://communityinviter.com/apps/envoyproxy/envoy).
  * LƯU Ý: Phản hồi các câu hỏi của người dùng trên Slack là nỗ lực tốt nhất. Để có phản hồi "đảm bảo" vui lòng gửi email tới envoy-users@ theo hướng dẫn trong chuỗi liên kết sau.

Vui lòng xem chuỗi email [này](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY) để biết thông tin về việc sử dụng danh sách email.

## Đóng góp

Đóng góp cho Envoy rất thú vị và C++ hiện đại ít đáng sợ hơn bạn nghĩ ngay cả khi bạn chưa có kinh nghiệm trước đó. Để bắt đầu:

* [Hướng dẫn đóng góp](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [Vấn đề cho người mới bắt đầu](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [Bắt đầu nhanh build/test sử dụng docker](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [Hướng dẫn cho nhà phát triển](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* Cân nhắc cài đặt [bộ công cụ hỗ trợ phát triển Envoy](https://github.com/envoyproxy/envoy/blob/main/support/README.md), giúp tự động hóa một số phần của quy trình phát triển, đặc biệt là các phần liên quan đến review code.
* Vui lòng đảm bảo rằng bạn thông báo nếu bạn đang làm việc trên một vấn đề để tránh trùng lặp công việc!

## Họp cộng đồng

Nhóm Envoy có lịch họp hai lần mỗi tháng vào thứ Ba lúc 9 giờ sáng PT. Lịch Google công khai [ở đây](https://goo.gl/PkDijT).  Cuộc họp chỉ được tổ chức
nếu có các mục trong [biên bản họp](https://goo.gl/5Cergb).  Bất kỳ thành viên nào của cộng đồng cũng có thể
đề xuất nội dung họp bằng cách thêm vào biên bản.  Các maintainer sẽ xác nhận bổ sung này hoặc hủy cuộc họp trong vòng 24 giờ trước lịch họp nếu không có nội dung xác nhận.

## Bảo mật

### Đánh giá bảo mật

Đã có một số đơn vị bên thứ ba tập trung vào bảo mật của Envoy:
* Năm 2018 Cure53 đã thực hiện kiểm toán bảo mật, [báo cáo đầy đủ](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf).
* Năm 2021 Ada Logics đã đánh giá hạ tầng fuzzing của chúng tôi và đưa ra các đề xuất cải tiến, [báo cáo đầy đủ](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf).

### Báo cáo lỗ hổng bảo mật

Nếu bạn phát hiện ra lỗ hổng hoặc khả năng có lỗ hổng trong Envoy, vui lòng thông báo cho chúng tôi tại
[envoy-security](mailto:envoy-security@googlegroups.com). Chúng tôi sẽ gửi email xác nhận đã nhận báo cáo, và sẽ gửi thêm email khi xác định chính xác hoặc loại trừ vấn đề.

Để biết thêm chi tiết, vui lòng xem toàn bộ [quy trình phát hành bảo mật](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md).

### Build ppc64le

Build cho kiến trúc ppc64le hoặc sử dụng aws-lc không nằm trong phạm vi chính sách bảo mật của envoy. Kiến trúc ppc64le hiện chỉ được hỗ trợ ở mức best-effort và không được các maintainer Envoy bảo trì.

## Phát hành

Để biết thêm chi tiết, vui lòng xem [quy trình phát hành](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---