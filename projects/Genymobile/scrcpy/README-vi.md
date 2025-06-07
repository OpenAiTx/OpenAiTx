**Kho lưu trữ GitHub này (<https://github.com/Genymobile/scrcpy>) là nguồn chính thức duy nhất cho dự án. Không tải xuống các bản phát hành từ các trang web không rõ nguồn gốc, ngay cả khi tên của chúng có chứa `scrcpy`.**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_phát âm "**scr**een **c**o**py**"_

Ứng dụng này phản chiếu thiết bị Android (video và âm thanh) được kết nối qua USB hoặc [TCP/IP](doc/connection.md#tcpip-wireless) và cho phép điều khiển bằng bàn phím và chuột của máy tính. Không yêu cầu quyền _root_ hoặc cài đặt ứng dụng trên thiết bị. Hoạt động trên _Linux_, _Windows_, và _macOS_.

![screenshot](assets/screenshot-debian-600.jpg)

Tập trung vào:

 - **nhẹ**: chạy gốc, chỉ hiển thị màn hình thiết bị
 - **hiệu năng**: 30~120fps, tùy thuộc vào thiết bị
 - **chất lượng**: 1920×1080 trở lên
 - **độ trễ thấp**: [35~70ms][lowlatency]
 - **khởi động nhanh**: ~1 giây để hiển thị hình ảnh đầu tiên
 - **không xâm lấn**: không để lại gì được cài đặt trên thiết bị Android
 - **lợi ích người dùng**: không tài khoản, không quảng cáo, không cần internet
 - **tự do**: phần mềm miễn phí và mã nguồn mở

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

Các tính năng bao gồm:
 - [chuyển tiếp âm thanh](doc/audio.md) (Android 11+)
 - [ghi hình](doc/recording.md)
 - [màn hình ảo](doc/virtual_display.md)
 - phản chiếu khi [màn hình thiết bị Android tắt](doc/device.md#turn-screen-off)
 - [sao chép-dán](doc/control.md#copy-paste) hai chiều
 - [chất lượng có thể cấu hình](doc/video.md)
 - [phản chiếu camera](doc/camera.md) (Android 12+)
 - [phản chiếu như webcam (V4L2)](doc/v4l2.md) (chỉ dành cho Linux)
 - mô phỏng [bàn phím][hid-keyboard] và [chuột][hid-mouse] vật lý (HID)
 - hỗ trợ [tay cầm chơi game](doc/gamepad.md)
 - [chế độ OTG](doc/otg.md)
 - và nhiều hơn nữa…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## Yêu cầu trước

Thiết bị Android yêu cầu ít nhất API 21 (Android 5.0).

[Chuyển tiếp âm thanh](doc/audio.md) được hỗ trợ với API >= 30 (Android 11+).

Đảm bảo bạn đã [bật gỡ lỗi USB][enable-adb] trên thiết bị của mình.

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

Trên một số thiết bị (đặc biệt là Xiaomi), bạn có thể gặp lỗi sau:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

Trong trường hợp đó, bạn cần bật [một tùy chọn bổ sung][control] `Gỡ lỗi USB (Cài đặt bảo mật)` (đây là một mục khác với `Gỡ lỗi USB`) để điều khiển thiết bị bằng bàn phím và chuột. Cần khởi động lại thiết bị sau khi thiết lập tùy chọn này.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

Lưu ý rằng không cần bật gỡ lỗi USB để chạy scrcpy ở [chế độ OTG](doc/otg.md).


## Tải ứng dụng

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) (xem [cách chạy](doc/windows.md#run))
 - [macOS](doc/macos.md)


## Mẹo cần biết

 - [Giảm độ phân giải](doc/video.md#size) có thể cải thiện hiệu năng đáng kể (`scrcpy -m1024`)
 - [_Nhấp chuột phải_](doc/mouse.md#mouse-bindings) kích hoạt `BACK`
 - [_Nhấp chuột giữa_](doc/mouse.md#mouse-bindings) kích hoạt `HOME`
 - <kbd>Alt</kbd>+<kbd>f</kbd> chuyển đổi [toàn màn hình](doc/window.md#fullscreen)
 - Có rất nhiều [phím tắt](doc/shortcuts.md) khác


## Ví dụ sử dụng

Có rất nhiều tùy chọn, được [tài liệu hóa](#user-documentation) ở các trang riêng. Dưới đây là một số ví dụ phổ biến.

 - Quay màn hình ở định dạng H.265 (chất lượng tốt hơn), giới hạn kích thước 1920, giới hạn tốc độ khung hình 60fps, tắt âm thanh, và điều khiển thiết bị bằng mô phỏng bàn phím vật lý:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # phiên bản rút gọn
    ```

 - Khởi động VLC trong một màn hình ảo mới (tách biệt với màn hình thiết bị):

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - Ghi lại camera thiết bị ở H.265 với độ phân giải 1920x1080 (và micro) ra tệp MP4:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - Thu hình từ camera trước của thiết bị và xuất ra như webcam trên máy tính (Linux):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - Điều khiển thiết bị mà không phản chiếu màn hình bằng cách mô phỏng bàn phím và chuột vật lý (không cần bật gỡ lỗi USB):

    ```bash
    scrcpy --otg
    ```

 - Điều khiển thiết bị bằng tay cầm chơi game cắm vào máy tính:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # phiên bản rút gọn
    ```

## Tài liệu người dùng

Ứng dụng cung cấp rất nhiều tính năng và tùy chọn cấu hình. Chúng được tài liệu hóa ở các trang sau:

 - [Kết nối](doc/connection.md)
 - [Video](doc/video.md)
 - [Âm thanh](doc/audio.md)
 - [Điều khiển](doc/control.md)
 - [Bàn phím](doc/keyboard.md)
 - [Chuột](doc/mouse.md)
 - [Tay cầm chơi game](doc/gamepad.md)
 - [Thiết bị](doc/device.md)
 - [Cửa sổ](doc/window.md)
 - [Ghi hình](doc/recording.md)
 - [Màn hình ảo](doc/virtual_display.md)
 - [Tunnels](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [Camera](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [Phím tắt](doc/shortcuts.md)


## Tài nguyên

 - [Câu hỏi thường gặp (FAQ)](FAQ.md)
 - [Bản dịch][wiki] (không nhất thiết cập nhật mới nhất)
 - [Hướng dẫn xây dựng](doc/build.md)
 - [Dành cho nhà phát triển](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki


## Bài viết

- [Giới thiệu scrcpy][article-intro]
- [Scrcpy hiện đã hoạt động không dây][article-tcpip]
- [Scrcpy 2.0, có âm thanh][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## Liên hệ

Bạn có thể tạo một [issue] để báo lỗi, yêu cầu tính năng hoặc hỏi đáp chung.

Đối với báo cáo lỗi, vui lòng đọc trước [FAQ](FAQ.md), bạn có thể tìm được giải pháp ngay lập tức.

[issue]: https://github.com/Genymobile/scrcpy/issues

Bạn cũng có thể sử dụng:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)


## Ủng hộ

Tôi là [@rom1v](https://github.com/rom1v), tác giả và người duy trì _scrcpy_.

Nếu bạn đánh giá cao ứng dụng này, bạn có thể [ủng hộ công việc mã nguồn mở của tôi][donate]:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## Giấy phép

    Bản quyền (C) 2018 Genymobile
    Bản quyền (C) 2018-2025 Romain Vimont

    Được cấp phép theo Giấy phép Apache, Phiên bản 2.0 ("Giấy phép");
    Bạn không được sử dụng tệp này trừ khi tuân thủ Giấy phép.
    Bạn có thể lấy bản sao của Giấy phép tại

        http://www.apache.org/licenses/LICENSE-2.0

    Trừ khi luật pháp yêu cầu hoặc được đồng ý bằng văn bản, phần mềm
    được phân phối theo Giấy phép được phân phối trên cơ sở "NGUYÊN TRẠNG",
    KHÔNG CÓ BẤT KỲ BẢO ĐẢM NÀO, dù rõ ràng hay ngụ ý.
    Xem Giấy phép để biết các quyền và giới hạn cụ thể.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---