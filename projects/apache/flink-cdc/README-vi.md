<p align="center">
  <a href="https://nightlies.apache.org/flink/flink-cdc-docs-stable/"><img src="https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/flinkcdc-logo.png" alt="Flink CDC" style="width: 375px;"></a>
</p>
<p align="center">
<a href="https://github.com/apache/flink-cdc/" target="_blank">
    <img src="https://img.shields.io/github/stars/apache/flink-cdc?style=social&label=Star&maxAge=2592000" alt="Test">
</a>
<a href="https://github.com/apache/flink-cdc/releases" target="_blank">
    <img src="https://img.shields.io/github/v/release/apache/flink-cdc?color=yellow" alt="Release">
</a>
<a href="https://github.com/apache/flink-cdc/actions/workflows/flink_cdc_ci.yml" target="_blank">
    <img src="https://img.shields.io/github/actions/workflow/status/apache/flink-cdc/flink_cdc_ci.yml?branch=master" alt="Build">
</a>
<a href="https://github.com/apache/flink-cdc/actions/workflows/flink_cdc_ci_nightly.yml" target="_blank">
    <img src="https://img.shields.io/github/actions/workflow/status/apache/flink-cdc/flink_cdc_ci_nightly.yml?branch=master&label=nightly" alt="Nightly Build">
</a>
<a href="https://github.com/apache/flink-cdc/tree/master/LICENSE" target="_blank">
    <img src="https://img.shields.io/static/v1?label=license&message=Apache License 2.0&color=white" alt="License">
</a>
</p>


Flink CDC là một công cụ tích hợp dữ liệu phân tán cho dữ liệu thời gian thực và dữ liệu batch. Flink CDC mang lại sự đơn giản 
và tinh tế cho việc tích hợp dữ liệu thông qua YAML để mô tả việc di chuyển và biến đổi dữ liệu trong một 
[Pipeline Dữ Liệu](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md).


Flink CDC ưu tiên hiệu quả tích hợp dữ liệu end-to-end và cung cấp các chức năng nâng cao như 
đồng bộ hóa toàn bộ cơ sở dữ liệu, đồng bộ hóa bảng phân mảnh (sharding), tiến hóa schema và biến đổi dữ liệu.

![Thiết kế kiến trúc Flink CDC](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### Hướng Dẫn Bắt Đầu Nhanh

Flink CDC cung cấp tiện ích dòng lệnh CdcUp CLI để khởi động môi trường playground và chạy các job Flink CDC.
Bạn cần có một môi trường Docker và Docker Compose hoạt động để sử dụng nó.

1. Chạy `git clone https://github.com/apache/flink-cdc.git --depth=1` để lấy một bản sao mã nguồn Flink CDC.
2. Chạy `cd tools/cdcup/ && ./cdcup.sh init` để sử dụng công cụ CdcUp khởi động môi trường playground.
3. Chạy `./cdcup.sh up` để khởi động các container docker và chờ cho chúng sẵn sàng.
4. Chạy `./cdcup.sh mysql` để mở một phiên làm việc MySQL, và tạo ít nhất một bảng.

```sql
-- khởi tạo db và bảng
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- chèn dữ liệu kiểm thử
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- kiểm tra đã chèn thành công hay chưa
SELECT * FROM test_table;
```

5. Chạy `./cdcup.sh pipeline pipeline-definition.yaml` để submit pipeline job. Bạn cũng có thể chỉnh sửa file định nghĩa pipeline cho các cấu hình bổ sung.
6. Chạy `./cdcup.sh flink` để truy cập Flink Web UI.

### Bắt Đầu Sử Dụng

1. Chuẩn bị một cụm [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) và thiết lập biến môi trường `FLINK_HOME`.
2. [Tải về](https://github.com/apache/flink-cdc/releases) file tar Flink CDC, giải nén và đặt các file jar của pipeline connector vào thư mục `lib` của Flink.

> Nếu bạn sử dụng macOS hoặc Linux, bạn có thể dùng `brew install apache-flink-cdc` để cài đặt nhanh Flink CDC và các connector tương thích.

3. Tạo một file **YAML** để mô tả nguồn dữ liệu và đích dữ liệu, ví dụ sau sẽ đồng bộ tất cả các bảng dưới cơ sở dữ liệu app_db của MySQL sang Doris:
  ```yaml
   source:
     type: mysql
     hostname: localhost
     port: 3306
     username: root
     password: 123456
     tables: app_db.\.*

   sink:
     type: doris
     fenodes: 127.0.0.1:8030
     username: root
     password: ""

   transform:
     - source-table: adb.web_order01
       projection: \*, format('%S', product_name) as product_name
       filter: addone(id) > 10 AND order_id > 100
       description: project fields and filter
     - source-table: adb.web_order02
       projection: \*, format('%S', product_name) as product_name
       filter: addone(id) > 20 AND order_id > 200
       description: project fields and filter

   route:
     - source-table: app_db.orders
       sink-table: ods_db.ods_orders
     - source-table: app_db.shipments
       sink-table: ods_db.ods_shipments
     - source-table: app_db.products
       sink-table: ods_db.ods_products

   pipeline:
     name: Sync MySQL Database to Doris
     parallelism: 2
     user-defined-function:
       - name: addone
         classpath: com.example.functions.AddOneFunctionClass
       - name: format
         classpath: com.example.functions.FormatFunctionClass
  ```
4. Submit pipeline job bằng script `flink-cdc.sh`.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. Xem trạng thái thực thi job thông qua Flink WebUI hoặc cơ sở dữ liệu downstream.

Hãy tự trải nghiệm với [hướng dẫn](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md) chi tiết hơn của chúng tôi. 
Bạn cũng có thể xem [tổng quan connector](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) để khám phá danh mục đầy đủ các connector hiện có và hiểu rõ hơn các cấu hình chi tiết.

### Tham Gia Cộng Đồng

Có nhiều cách để tham gia vào cộng đồng Apache Flink CDC. [Danh sách email](https://flink.apache.org/what-is-flink/community/#mailing-lists) là nơi chính mà tất cả các committer Flink đều có mặt. Để hỗ trợ người dùng và hỏi đáp, hãy sử dụng danh sách email dành cho người dùng. Nếu bạn phát hiện vấn đề với Flink CDC,
hãy tạo một [Flink jira](https://issues.apache.org/jira/projects/FLINK/summary) và gắn tag `Flink CDC`.   
Các lỗi và yêu cầu tính năng có thể được thảo luận trên mailing list dev hoặc trên Jira.

### Đóng Góp

Chào mừng bạn đóng góp cho Flink CDC, vui lòng xem [Hướng Dẫn Phát Triển](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
và [Hướng Dẫn APIs](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md).

### Giấy Phép

[Giấy phép Apache 2.0](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).

### Lời Cảm Ơn Đặc Biệt

Cộng đồng Flink CDC chào đón tất cả mọi người sẵn sàng đóng góp, dù là thông qua việc gửi báo cáo lỗi,
nâng cao tài liệu, hay gửi mã nguồn cho các bản sửa lỗi, bổ sung kiểm thử, hoặc phát triển tính năng mới.     
Cảm ơn tất cả các cộng tác viên đã đóng góp nhiệt tình.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---