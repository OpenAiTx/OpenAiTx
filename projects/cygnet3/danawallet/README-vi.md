# Ví Dana

Dana là một ứng dụng flutter được sử dụng để nhận quyên góp bitcoin. Nó sử dụng silent payments, một giao thức thanh toán tĩnh mới, để nhận quyên góp đồng thời bảo vệ quyền riêng tư trên chuỗi.

## Thử sử dụng ví Dana

**Ví Dana hiện vẫn đang trong giai đoạn thử nghiệm. Chúng tôi khuyến nghị sử dụng testnet/signet. Nếu bạn thực sự muốn thử ví trên mainnet, chỉ sử dụng số tiền bạn sẵn sàng mất. Chúng tôi không chịu trách nhiệm cho các khoản tiền bị mất.**

Chúng tôi đang xem xét phát hành ví Dana trên các cửa hàng ứng dụng phổ biến khi ứng dụng ổn định hơn.

Trong khi chờ đợi, có hai cách để thử ví Dana:

- Tải APK ví Dana mới nhất từ [trang phát hành](https://github.com/cygnet3/danawallet/releases)
- Tải ví Dana qua [kho lưu trữ F-Droid tự lưu trữ của chúng tôi](https://fdroid.silentpayments.dev/fdroid/repo)

### Tải qua F-Droid

Chúng tôi khuyến nghị lựa chọn F-Droid, vì nó hỗ trợ cập nhật tự động và chỉ cần thiết lập một lần.

- Mở F-Droid trên điện thoại android của bạn
- Vào 'Cài đặt' (Settings)
- Trong phần 'Ứng dụng của tôi' (My Apps), nhấp vào 'Kho lưu trữ' (Repositories)
- Thêm kho lưu trữ mới bằng cách nhấp vào biểu tượng '+'
- Quét mã QR có trên trang này: https://fdroid.silentpayments.dev/fdroid/repo

Bạn đã thêm kho lưu trữ tự lưu trữ của chúng tôi. Để tải ứng dụng, tìm kiếm 'Dana Wallet' trong phần cửa hàng ứng dụng của F-Droid (có thể bạn cần làm mới danh sách ứng dụng trước, bằng cách vuốt xuống trên màn hình cửa hàng F-Droid).

## Biên dịch ví Dana từ mã nguồn

Dưới đây là một số hướng dẫn để biên dịch ví Dana từ mã nguồn. Điều này chỉ được khuyến nghị nếu bạn muốn tham gia phát triển ví Dana.

### Biên dịch cho linux (máy tính để bàn)

Biên dịch cho linux không yêu cầu thêm bước nào, chỉ cần thực thi

```
flutter run
```

Điều này cũng có thể hoạt động trên các nền tảng khác (macOS, Windows), nhưng chúng tôi chưa thử nghiệm.

### Biên dịch cho android

Biên dịch cho thiết bị android yêu cầu một số công việc chuẩn bị, để tạo ra các tệp nhị phân cho kiến trúc này.

Trước tiên, bạn cần `cargo-ndk`. Bạn cũng có thể cần thêm các toolchain mong muốn:

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

Sau khi cài đặt xong, vào thư mục rust và chạy `just build-android`.

```
cd rust
just build-android
```

Nếu bạn chưa cài `just`, bạn cũng có thể sao chép các lệnh trong `justfile`.
Điều này sẽ tạo ra các tệp nhị phân.

Tiếp theo, kết nối điện thoại và bật chế độ gỡ lỗi.
Kiểm tra điện thoại đã kết nối chưa bằng lệnh

```
flutter devices
```

Cuối cùng, để biên dịch và cài đặt ứng dụng cho thiết bị android của bạn:

```
flutter run
```

## Quyên góp cho Dana

Bạn có thể quyên góp cho ví Dana bằng địa chỉ:

> ₿donate@danawallet.app

hoặc bạn có thể sử dụng địa chỉ thanh toán silent sau:

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---