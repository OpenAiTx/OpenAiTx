# TeamSpeak 6 Server - Beta Release README

Chào mừng bạn đến với bản phát hành Beta của TeamSpeak 6 Server! Chúng tôi rất vui khi có bạn đồng hành khám phá thế hệ tiếp theo của TeamSpeak. Tài liệu này sẽ hướng dẫn bạn bắt đầu và nêu bật những chi tiết quan trọng về phiên bản Beta hiện tại.

Vì đây là phiên bản Beta, một số tính năng vẫn đang được phát triển và bạn có thể gặp phải lỗi. Phản hồi của bạn rất quan trọng và sẽ giúp chúng tôi hoàn thiện phiên bản chính thức ổn định và đầy đủ hơn.

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;Giới thiệu về TeamSpeak</h2>

Được thử nghiệm và kiểm chứng trong gần 25 năm, chúng tôi có một giải pháp phù hợp với mọi nhu cầu. TeamSpeak cung cấp giải pháp giao tiếp thoại lý tưởng cho chơi game, giáo dục và đào tạo, giao tiếp nội bộ doanh nghiệp, cũng như giữ liên lạc với bạn bè và gia đình. Mục tiêu chính của chúng tôi là mang đến một giải pháp dễ sử dụng, tiêu chuẩn bảo mật cao, chất lượng thoại xuất sắc và sử dụng ít tài nguyên hệ thống cũng như băng thông.

## ℹ️ Trạng thái Beta & Vấn đề đã biết
**Đây là bản phát hành beta. Mục tiêu chính là thu thập phản hồi đa dạng và xác định các vấn đề tiềm ẩn trước khi ra mắt phiên bản ổn định.**

**Tập tin Server Tự Lưu Trữ:** Phần mềm server chuyên dụng cho TeamSpeak 6 vẫn đang được phát triển tích cực và chưa đầy đủ tính năng. Chúng tôi cam kết mang lại trải nghiệm TS6 hoàn chỉnh cho các máy chủ tự lưu trữ.

**Tính Năng Chưa Ổn Định:** Một số tính năng mới có thể chưa ổn định hoặc sẽ thay đổi khi chúng tôi tiếp tục hoàn thiện chúng.

**Phản Hồi Là Quan Trọng:** Trải nghiệm của bạn là vô giá và ý kiến đóng góp của bạn rất quan trọng đối với chúng tôi. Vui lòng báo cáo mọi vấn đề hoặc chia sẻ ý kiến tại [Diễn đàn Cộng đồng](https://community.teamspeak.com/c/teamspeak-6-server/45) hoặc trực tiếp tại [GitHub](https://github.com/teamspeak/teamspeak6-server/issues).

**Hạn Chế:** Lưu ý rằng **giấy phép Server TeamSpeak 3 không tương thích** với TeamSpeak 6 Server, và hiện tại **không có phương án chuyển đổi giữa hai phiên bản**.

**Giấy Phép Xem Trước:** Đáp lại phản hồi của bạn, server hiện đi kèm với **giấy phép xem trước tạm thời** cho phép tối đa 32 slot để tăng sự linh hoạt trong giai đoạn đánh giá. Lưu ý rằng giấy phép này **chỉ hợp lệ trong hai tháng**.

Ngoài ra, hiện tại **chưa thể nhận hoặc nâng cấp lên giấy phép lớn hơn cho TeamSpeak 6**.

Chúng tôi thực sự cảm ơn sự kiên nhẫn và thông cảm của bạn khi chúng tôi tiếp tục phát triển các giải pháp để hỗ trợ tốt hơn cho nhu cầu của bạn trong tương lai.

## 👇 Bắt đầu với TS6
Để bắt đầu với TeamSpeak 6 Client, vui lòng truy cập trang [Tải về](https://teamspeak.com/en/downloads/) của chúng tôi.

Để biết thông tin về tự lưu trữ, xem hướng dẫn ngắn bên dưới. Để cập nhật mới nhất, thông báo và tham gia cùng cộng đồng TeamSpeak, hãy xem [Diễn đàn Cộng đồng](https://community.teamspeak.com/) và theo dõi chúng tôi trên [Twitter](https://x.com/teamspeak).

Không muốn tự lưu trữ hoặc chỉ cần một cách dễ dàng hơn để bắt đầu với TeamSpeak 6? Bạn có thể thuê các máy chủ TeamSpeak 6 Chính Thức và đáng tin cậy trực tiếp từ chúng tôi tại [TeamSpeak Communities](https://www.myteamspeak.com/communities).
## ⚙️ Cấu hình
### Bạn có thể cấu hình server theo ba cách chính:

1. **Tham số dòng lệnh:** Truyền tuỳ chọn trực tiếp khi khởi động server (ví dụ: ./tsserver --default-voice-port 9987). Thích hợp cho các thay đổi tạm thời hoặc khi sử dụng script.

2. **Biến môi trường:** Đặt biến môi trường trước khi khởi động server. Thích hợp cho Docker hoặc khi bạn muốn tránh làm rối dòng lệnh.

3. **Tập tin cấu hình YAML:** Để cấu hình lâu dài, nên sử dụng tập tin tsserver.yaml. Bạn có thể tạo tập tin cấu hình mặc định bằng cách sử dụng cờ --write-config-file.

Các thiết lập quan trọng bạn có thể điều chỉnh bao gồm cổng mạng (thoại, truyền tệp), kết nối cơ sở dữ liệu (hỗ trợ SQLite và MariaDB), IP ràng buộc và tuỳ chọn ghi log.

Để xem đầy đủ các tuỳ chọn khả dụng, hãy chạy server với cờ `--help` hoặc tham khảo [CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md).

### Chạy Server với File Nhị Phân
Nếu bạn không sử dụng Docker, bạn có thể chạy server trực tiếp trên hệ điều hành của mình.

<h2><img width="22" src="/icons/linux.svg">&nbsp;Trên Linux:</h2>

Cấp quyền thực thi cho file nhị phân server:
```sh
chmod +x tsserver
```

Chạy server từ terminal, nhớ chấp nhận điều khoản sử dụng:

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;Trên Windows:</h2>

Mở Command Prompt hoặc PowerShell và chuyển đến thư mục nơi bạn đã giải nén các tệp server.

Chạy file thực thi của server, nhớ chấp nhận điều khoản sử dụng:
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;Chạy Server với Docker (Khuyến nghị):</h2>
Docker là cách dễ dàng nhất để chạy TeamSpeak 6 server trong môi trường tách biệt và dễ quản lý.

### 1. Lệnh docker run đơn giản:

Để bắt đầu nhanh, bạn có thể sử dụng lệnh docker run.

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. Sử dụng docker-compose.yaml (cho thiết lập lâu dài):
Đây là cách tốt nhất cho server bạn muốn duy trì liên tục. Tạo tập tin docker-compose.yaml:

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # Cổng thoại
      - "30033:30033/tcp" # Truyền tệp
      # - "10080:10080/tcp" # Web Query
    environment:
```
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volumes:
  teamspeak-data:
```

## 🔗 Liên kết hữu ích
[Trang web chính thức](https://teamspeak.com/en/)<br>
[Diễn đàn cộng đồng](https://community.teamspeak.com)<br>
[Vấn đề trên GitHub](https://github.com/teamspeak/teamspeak6-server/issues)<br>

Sự tham gia và phản hồi của bạn sẽ giúp chúng tôi định hình tương lai của TeamSpeak! 💙<br>
Cảm ơn bạn đã là một phần của chương trình Beta TeamSpeak 6 và đóng góp vào sự phát triển của nó! 🫡

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---