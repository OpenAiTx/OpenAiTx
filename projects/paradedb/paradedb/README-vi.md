<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>Postgres cho Tìm kiếm và Phân tích</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">Website</a> &bull;
  <a href="https://docs.paradedb.com">Tài liệu</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">Cộng đồng</a> &bull;
  <a href="https://paradedb.com/blog/">Blog</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">Lịch sử thay đổi</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) là một giải pháp thay thế Elasticsearch hiện đại được xây dựng trên nền Postgres. Được thiết kế cho các tác vụ thời gian thực với nhiều cập nhật.

## Lộ trình phát triển

- [x] Tìm kiếm
  - [x] Tìm kiếm toàn văn với BM25 sử dụng [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [x] Tìm kiếm vector dày và thưa với [pgvector](https://github.com/pgvector/pgvector#pgvector)
  - [ ] Tìm kiếm phân tán
- [ ] Phân tích
  - [x] Tìm kiếm theo phân loại (faceted search) trên dữ liệu Postgres với [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [ ] Phương thức truy cập bảng Postgres theo cột

Để xem lộ trình chi tiết, vui lòng xem [Lộ trình ParadeDB cho năm 2025](https://github.com/orgs/paradedb/discussions/2041).

## Bắt đầu

Để bắt đầu, vui lòng truy cập [tài liệu](https://docs.paradedb.com) của chúng tôi.

## Triển khai ParadeDB

ParadeDB và các phần mở rộng của nó có thể được triển khai theo hai cách:

- Ảnh Docker dựa trên [Postgres](https://hub.docker.com/_/postgres) ([xem hướng dẫn triển khai](https://docs.paradedb.com/deploy/aws))
- Biểu đồ Helm cho Kubernetes dựa trên [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) ([xem hướng dẫn triển khai](https://docs.paradedb.com/deploy/helm))

Để biết thêm thông tin, bao gồm các tính năng doanh nghiệp và hỗ trợ, vui lòng [liên hệ với chúng tôi qua email](mailto:sales@paradedb.com).

### Phần mở rộng

Bạn có thể tìm thấy các tệp nhị phân dựng sẵn cho các phần mở rộng ParadeDB Postgres trên Debian 11, 12, Ubuntu 22.04 và 24.04, Red Hat Enterprise Linux 8 và 9, cũng như macOS 14 (Sonoma) và 15 (Sequoia) cho Postgres 14+ tại [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest).

ParadeDB hỗ trợ tất cả các phiên bản được hỗ trợ bởi Nhóm Phát triển Toàn cầu PostgreSQL, bao gồm PostgreSQL 14+, và bạn có thể biên dịch các phần mở rộng cho các phiên bản Postgres khác bằng cách làm theo hướng dẫn trong README của từng phần mở rộng.

### Ảnh Docker

Để nhanh chóng khởi động một instance ParadeDB, chỉ cần pull và chạy ảnh Docker mới nhất:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

Lệnh này sẽ khởi động một instance ParadeDB với người dùng mặc định là `postgres` và mật khẩu là `password`. Sau đó, bạn có thể kết nối tới cơ sở dữ liệu bằng `psql`:

```bash
docker exec -it paradedb psql -U postgres
```

Để cài đặt ParadeDB cục bộ hoặc tại chỗ, chúng tôi khuyên bạn sử dụng tệp `docker-compose.yml` của chúng tôi. Ngoài ra, bạn có thể truyền các biến môi trường phù hợp vào lệnh `docker run`, thay thế <> bằng giá trị mong muốn:

```bash
docker run \
  --name paradedb \
  -e POSTGRES_USER=<user> \
  -e POSTGRES_PASSWORD=<password> \
  -e POSTGRES_DB=<dbname> \
  -v paradedb_data:/var/lib/postgresql/data/ \
  -p 5432:5432 \
  -d \
  paradedb/paradedb:latest
```

Lệnh này sẽ khởi động một instance ParadeDB với người dùng không phải root là `<user>` và mật khẩu `<password>`. Tham số `-v` giúp dữ liệu ParadeDB của bạn được lưu trữ bền vững trên volume Docker có tên `paradedb_data`.

Bạn có thể kết nối tới cơ sở dữ liệu bằng `psql` như sau:

```bash
docker exec -it paradedb psql -U <user> -d <dbname> -p 5432 -W
```

### Biểu đồ Helm

ParadeDB cũng có sẵn cho Kubernetes thông qua biểu đồ Helm của chúng tôi. Bạn có thể tìm biểu đồ Helm tại [Kho lưu trữ ParadeDB Helm Chart trên GitHub](https://github.com/paradedb/charts) hoặc tải trực tiếp từ [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb).

### ParadeDB Cloud

Hiện tại, ParadeDB chưa có sẵn dưới dạng dịch vụ đám mây được quản lý. Nếu bạn quan tâm đến dịch vụ ParadeDB Cloud, vui lòng cho chúng tôi biết bằng cách tham gia [danh sách chờ](https://form.typeform.com/to/jHkLmIzx).

## Hỗ trợ

Nếu bạn thiếu một tính năng hoặc phát hiện lỗi, vui lòng mở một
[GitHub Issue](https://github.com/paradedb/paradedb/issues/new/choose).

Để nhận hỗ trợ từ cộng đồng, bạn có thể:

- Đặt câu hỏi trong [Cộng đồng ParadeDB trên Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
- Hỏi trên [GitHub Discussions của chúng tôi](https://github.com/paradedb/paradedb/discussions)

Nếu bạn cần hỗ trợ thương mại, vui lòng [liên hệ đội ngũ ParadeDB](mailto:sales@paradedb.com).

## Đóng góp

Chúng tôi hoan nghênh mọi đóng góp từ cộng đồng, dù lớn hay nhỏ, và sẽ hướng dẫn bạn trong suốt quá trình. Để bắt đầu đóng góp, hãy kiểm tra các [vấn đề dành cho người mới](https://github.com/paradedb/paradedb/labels/good%20first%20issue)
hoặc nhắn tin cho chúng tôi trong [Cộng đồng ParadeDB trên Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw). Khi bạn đóng góp, hãy ping chúng tôi trên Slack để nhận quà lưu niệm ParadeDB!

Để biết thêm thông tin về cách đóng góp, vui lòng xem
[Hướng dẫn Đóng góp](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md).

Dự án này được phát hành kèm theo [Bộ Quy tắc Ứng xử của Người đóng góp](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md).
Bằng việc tham gia vào dự án, bạn đồng ý tuân thủ các điều khoản của bộ quy tắc này.

Cảm ơn bạn đã giúp chúng tôi làm ParadeDB tốt hơn cho mọi người :heart:.

## Giấy phép

ParadeDB được cấp phép theo [Giấy phép Công cộng GNU Affero phiên bản 3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) và dưới dạng phần mềm thương mại. Để mua bản quyền thương mại, vui lòng liên hệ chúng tôi tại [sales@paradedb.com](mailto:sales@paradedb.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---