<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />


  <p>
    <strong>Triển khai mạng lightning nhanh và mô-đun cho mọi mục đích sử dụng, được viết bằng Rust.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">Trang Chủ Dự Án</a>
  </h4>
</div>

## Crates

Đây là danh sách đầy đủ các crate đang được hỗ trợ hiện tại:

| Crate       | Mô tả                                           | Phiên bản   |
|:------------|:-----------------------------------------------:|------------:|
| lampod-cli  | Giao diện dòng lệnh Lampo Daemon để chạy daemon | _không liên quan_ |
| lampo-cli   | Giao diện dòng lệnh Lampo đơn giản để tương tác với daemon | _không liên quan_ |

## Cách Cài Đặt

Để cài đặt tất cả các yêu cầu và tệp nhị phân Lampo, bạn cần
cài đặt rust, sau đó chạy lệnh sau:

```
make install
```

Sau khi bạn đã có `lampod-cli` và `lampo-cli`, bạn có thể
chạy lệnh sau để khởi chạy Lampo ở chế độ signet:

```
➜  ~ lampod-cli --network signet
✓ Đã tạo ví, vui lòng lưu trữ những từ này một cách an toàn
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
Hãy lưu trữ các từ khóa ví của bạn, sau đó sử dụng lại chúng để khôi phục ví với `--restore-wallet`.
Nếu bạn không lưu trữ các từ này ở đâu đó, số dư của bạn sẽ bị mất khi Lampo khởi động lần sau!

Lưu ý rằng bạn cần có một tệp `lampo.conf` trong đường dẫn `~/.lampo/signet`. Chạy
lệnh sau để sử dụng tệp cấu hình ví dụ:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

Sau đó bạn có thể truy vấn node với lệnh sau:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### Để chạy kiểm thử tích hợp với core lightning:

Đảm bảo bạn đã biên dịch core-lightning ở chế độ nhà phát triển. Hướng dẫn cài đặt có thể được tìm thấy [tại đây](https://docs.corelightning.org/docs/installation).

Các kiểm thử tích hợp có thể chạy bằng lệnh sau:

```
make integration
```

## Nguyên tắc đóng góp

Vui lòng đọc [Hướng dẫn đóng góp](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md).

## Cộng đồng

Nhằm duy trì sự rõ ràng, chúng tôi lựa chọn các kênh giao tiếp cụ thể:
- Nhà phát triển, hãy tham gia cùng chúng tôi trên [Zulip](https://lampo-dev.zulipchat.com/).
- Thành viên cộng đồng, [cộng đồng Twitter](https://twitter.com/i/communities/1736414802849706087) của chúng tôi chờ đợi đóng góp của bạn.
- Đối với các câu hỏi kỹ thuật và yêu cầu tính năng, hãy tham gia thảo luận trên GitHub.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---