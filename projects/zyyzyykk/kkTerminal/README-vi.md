# kkTerminal

> kkTerminal, một trình terminal cho kết nối Web SSH
>
> Tác giả: [zyyzyykk](https://github.com/zyyzyykk/)
>
> Mã nguồn: https://github.com/zyyzyykk/kkTerminal
>
> Địa chỉ Docker Hub: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> Xem trước: https://ssh.kkbpro.com/
>
> Thời gian cập nhật: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ Tích hợp nhanh

Sử dụng thẻ `iframe` trong trang HTML để tích hợp nhanh:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 Triển khai bằng Docker

1. Kéo image:

```bash
docker pull zyyzyykk/kkterminal
```

2. Tạo và chạy container với ánh xạ cổng: `-p port:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. Tùy chỉnh chữ nghệ thuật: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. Truy cập qua trình duyệt: `http://server-ip:3000/`

### 🛸 Xem trước

Truy cập website sau: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**Xem trước các mô-đun khác**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 Mô tả chức năng

1. kkTerminal là trình terminal cho kết nối Web SSH. Nhấn vào biểu tượng terminal ở góc trên bên trái và chọn thiết lập kết nối để thiết lập kết nối SSH

2. Hỗ trợ sử dụng thẻ `iframe` trong trang web để tích hợp nhanh vào website bên thứ ba

3. Hỗ trợ tùy chỉnh cấu hình terminal thông qua [Tham số URL](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)

4. Hỗ trợ quốc tế hóa và chuyển đổi ngôn ngữ giữa tiếng Trung và tiếng Anh

5. Hỗ trợ triển khai cục bộ trên PC, tự động mở cửa sổ trình duyệt khi khởi động

6. Hỗ trợ tự động điều chỉnh kích thước cửa sổ và nhập tiếng Trung

7. Hỗ trợ tùy chỉnh cài đặt ưu tiên, cho phép người dùng chọn màu nền/màu chữ, cỡ chữ, kiểu hiển thị con trỏ, bật TCode cho terminal, v.v.

8. Hỗ trợ khởi động lại: Tự động khởi động lại sau khi sửa đổi thiết lập kết nối SSH hoặc cài đặt ưu tiên tùy chỉnh, hoặc có thể khởi động lại thủ công sau khi ngắt kết nối SSH

9. Hỗ trợ sao chép và dán:

   - Sao chép: Tương tự terminal `Git`, chọn văn bản sẽ tự động sao chép

   - Dán: Tương tự terminal `Cmd`, nhấp chuột phải để dán (cần cấp quyền truy cập trình duyệt)


9. Hỗ trợ quản lý tệp, mở Mô-đun Quản lý Tệp để xem, giải nén, tải lên và tải xuống tệp/thư mục

10. Hỗ trợ thao tác phím tắt như chọn nhiều/tất cả tệp, sao chép và dán, cắt, chuyển đổi lựa chọn, mở, v.v.

11. Hỗ trợ duyệt và chỉnh sửa tệp, chỉnh sửa tệp và lưu lên máy chủ từ xa bằng `ctrl+s`

12. Hỗ trợ [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md), cho phép tự động hóa Workflow tương tự script Shell thông qua TCode tùy chỉnh

13. Hỗ trợ ghi lại thao tác và đồng bộ hóa đám mây

14. Hỗ trợ các chức năng Hợp tác, Giám sát và Docker nâng cao

### 👨‍💻 Nhật ký cập nhật

##### zyyzyykk/kkterminal:3.6.0: latest

- Thêm chức năng Hợp tác nâng cao
- Thêm chức năng Giám sát nâng cao
- Thêm chức năng Docker nâng cao
- Tối ưu hóa dung lượng đóng gói & hiển thị trang web

##### zyyzyykk/kkterminal:3.5.6: 

- Hỗ trợ nhiều tham số URL hơn
- Thêm phần trăm cỡ chữ & hình ảnh trong trình soạn thảo
- Tối ưu hóa hiển thị trang web

##### zyyzyykk/kkterminal:3.5.3: 

- Thêm tham số URL để tùy chỉnh cấu hình terminal
- Sửa lỗi khởi động lại nhiều cửa sổ
- Thêm chức năng ghi lại thao tác và đồng bộ hóa đám mây
- Tái cấu trúc một số logic mã nguồn

[**Lịch sử cập nhật**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 Kiến trúc

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ Về dự án này

Gửi người dùng thân mến,

Tôi rất tiếc phải thông báo rằng do thời gian và năng lượng có hạn, tôi sẽ không thể tiếp tục bảo trì `kkTerminal` trong tương lai.

Nếu bạn quan tâm đến `kkTerminal` hoặc muốn tiếp tục duy trì, vui lòng liên hệ với tôi hoặc tạo issue.

Nếu bạn phát hiện lỗi hoặc muốn phát triển tính năng mới, cũng hãy tạo issue.

Cuối cùng, cảm ơn bạn đã ủng hộ `kkTerminal` và tôi chân thành hy vọng `kkTerminal` thực sự có thể giúp ích cho bạn.

Trân trọng,

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 Sao

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---