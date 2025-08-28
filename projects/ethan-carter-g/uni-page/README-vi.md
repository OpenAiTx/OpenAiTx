
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Uni-Page Khung Phân Trang

Uni-Page là một khung phân trang tổng quát dựa trên Java, thông qua thiết kế trừu tượng, cung cấp giao diện truy vấn phân trang thống nhất cho các nguồn dữ liệu khác nhau. Khung này sử dụng kiến trúc dạng module, hiện tại đã tích hợp nhiều nguồn dữ liệu như JDBC, Mybatis, MongoDB, Elasticsearch, đồng thời cung cấp cơ chế mở rộng linh hoạt.

## Thiết kế cốt lõi

Thiết kế cốt lõi của khung xoay quanh bốn thành phần chính:

1. **Câu lệnh phân trang (PaginationStatement)**
    - Hỗ trợ định nghĩa câu lệnh truy vấn phân trang cho bất kỳ ngôn ngữ nào
    - Cung cấp giao diện tham số phân trang thống nhất
    - Cho phép tùy chỉnh logic phân trang

2. **Trình thực thi phân trang (PaginationStatementExecutor)**
    - Chịu trách nhiệm thực thi câu lệnh truy vấn phân trang
    - Cung cấp chức năng truy vấn thông tin phân trang
    - Cơ chế thực thi có thể mở rộng

3. **Tập kết quả phân trang (PaginationResultSet)**
    - Giao diện tập kết quả thống nhất
    - Hỗ trợ truy cập dữ liệu theo tên cột và chỉ số
    - Cung cấp chức năng chuyển đổi kiểu dữ liệu
    - Thiết kế tương tự JDBC ResultSet

4. **Trình xử lý tập kết quả (PaginationResultSetHandler)**
    - Hỗ trợ chuyển đổi tập kết quả tùy chỉnh
    - Cung cấp chức năng ánh xạ đối tượng


## Mục tiêu thiết kế

1. **Tính thống nhất**
    - Cung cấp giao diện truy vấn phân trang thống nhất
    - Ẩn sự khác biệt trong triển khai của các nguồn dữ liệu
    - Đơn giản hóa cách sử dụng truy vấn phân trang

2. **Tính linh hoạt**
    - Hỗ trợ câu lệnh phân trang tùy chỉnh
    - Cho phép mở rộng trình thực thi
    - Cung cấp nhiều cách xử lý tập kết quả

3. **Tính mở rộng**
    - Thiết kế dạng mô-đun
    - Hỗ trợ kết nối nhanh nguồn dữ liệu mới
    - Cung cấp cơ chế điểm mở rộng

4. **Tính dễ sử dụng**
    - API đơn giản, trực quan
    - Chuyển đổi kiểu dữ liệu hoàn thiện
    - Hỗ trợ đa dạng các lớp công cụ tiện ích
## Các trường hợp áp dụng

- Dự án cần quản lý tập trung nhiều nguồn dữ liệu phân trang
- Ứng dụng cấp doanh nghiệp cần hỗ trợ phân trang trên nhiều nguồn dữ liệu

## Các mô-đun cốt lõi

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
Thư viện phân trang cốt lõi, cung cấp các giao diện phân trang cơ bản và các triển khai trừu tượng.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
Mô-đun hỗ trợ nguồn dữ liệu JDBC, cung cấp triển khai phân trang dựa trên JDBC.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
Mô-đun tích hợp MyBatis, cung cấp hỗ trợ tích hợp với framework MyBatis.
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
Mô-đun hỗ trợ nguồn dữ liệu MongoDB, cung cấp triển khai phân trang dựa trên MongoDB.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Mô-đun hỗ trợ nguồn dữ liệu Elasticsearch, cung cấp triển khai phân trang dựa trên ES.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Mô-đun hỗ trợ phân trang trong môi trường Spring MVC, cung cấp khả năng tích hợp với Spring MVC, đơn giản như viết một controller thông thường.
- Tự động liên kết tham số phân trang
- Tự động chuyển đổi kết quả phân trang

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Mô-đun kiểm thử phân trang trong môi trường Spring Boot Web, cung cấp kiểm thử tích hợp chức năng phân trang.


## Bắt đầu nhanh, lấy uni-page-jdbc làm ví dụ

### Phụ thuộc Maven

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### Ví dụ đơn giản

```java
public class PaginationTest {
   
    public void page() {
        PaginationStatementTemplate operations = new PaginationStatementTemplate();
        operations.addStatementExecutor(new Sql2oPaginationNamedParameterStatementExecutor(dataSource));
        
        // 1. 创建分页语句
        PaginationStatement statement = of(b -> b
                .sql("SELECT * FROM user WHERE username LIKE :username")
                .paramMap("username", "%admin%")
                .pageable(0, 10)
                .sort("id", Sort.Direction.DESC));
        
        // 2. 执行查询
        PageInformation information = operations.queryForInformation(statement);
        Page<User> page = operations.queryForResultSet(statement, new JdbcBeanPropertyPaginationRowMapper<>(User.class));
    }

    // User实体类
    class User {
        private Long id;
        private String username;
        // getters and setters
    }
}
```


## Lời cảm ơn

Trong quá trình phát triển khung công tác này, tôi đã nhận được nhiều ảnh hưởng và cảm hứng từ cộng đồng mã nguồn mở. Xin cảm ơn những bậc tiền bối đã chia sẻ kinh nghiệm kỹ thuật một cách vô tư, chính trí tuệ và đóng góp của các bạn đã giúp khung công tác này ra đời. Đặc biệt cảm ơn các dự án mã nguồn mở xuất sắc đã mang lại cảm hứng thiết kế và ý tưởng triển khai, những kinh nghiệm quý giá đó đã giúp tôi có thể tiếp tục tiến bước trên vai những người khổng lồ.

Xin cảm ơn tất cả các bậc tiền bối kỹ thuật đã đóng góp cho cộng đồng mã nguồn mở!

## 🌟 Ủng hộ dự án
Nếu bạn cảm thấy dự án này hữu ích với mình, hãy nhấn nút ⭐Star ở góc phải phía trên để ủng hộ tôi nhé!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---