# Containerization

Gói Containerization cho phép các ứng dụng sử dụng các container Linux.  
Containerization được viết bằng [Swift](https://www.swift.org) và sử dụng [Virtualization.framework](https://developer.apple.com/documentation/virtualization) trên Apple silicon.

Containerization cung cấp các API để:

- [Quản lý hình ảnh OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).  
- [Tương tác với các registry từ xa](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).  
- [Tạo và lấp đầy hệ thống file ext4](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).  
- [Tương tác với họ socket Netlink](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).  
- [Tạo kernel Linux tối ưu cho thời gian khởi động nhanh](https://raw.githubusercontent.com/apple/containerization/main/kernel/).  
- [Tạo máy ảo nhẹ và quản lý môi trường runtime](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).  
- [Tạo và tương tác với các tiến trình container hóa](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).  
- Sử dụng Rosetta 2 để chạy các container linux/amd64 trên Apple silicon.

Vui lòng xem [tài liệu API](https://apple.github.io/containerization/documentation/) để biết thông tin về các gói Swift mà Containerization cung cấp.

## Thiết kế

Containerization thực thi mỗi container Linux bên trong một máy ảo nhẹ riêng biệt. Khách hàng có thể tạo địa chỉ IP riêng cho từng container để loại bỏ nhu cầu chuyển tiếp cổng riêng lẻ. Các container đạt thời gian khởi động dưới một giây nhờ cấu hình [kernel Linux tối ưu](/kernel) và hệ thống file root tối giản với hệ thống init nhẹ.

[vminitd](/vminitd) là một hệ thống init nhỏ, là một dự án con trong Containerization.  
`vminitd` được khởi tạo như tiến trình đầu tiên bên trong máy ảo và cung cấp API GRPC qua vsock.  
API cho phép cấu hình môi trường runtime và khởi chạy các tiến trình container hóa.  
`vminitd` cung cấp I/O, tín hiệu và sự kiện tới tiến trình gọi khi tiến trình được chạy.

## Yêu cầu

Bạn cần một máy Mac Apple silicon để xây dựng và chạy Containerization.

Để xây dựng gói Containerization, hệ thống của bạn cần:

- macOS 15 hoặc mới hơn và Xcode 26 beta  
- macOS 26 beta hoặc mới hơn

Các ứng dụng được xây dựng bằng gói này sẽ chạy trên macOS 15 trở lên, nhưng các tính năng sau không có trên macOS 15:

- Mạng container không cô lập - với macOS 15, các container trên cùng mạng vmnet không thể giao tiếp với nhau.

## Ví dụ sử dụng

Để xem ví dụ về cách sử dụng một số thư viện, thực thi cctl là một điểm bắt đầu tốt. Công cụ này chủ yếu là sân chơi để thử nghiệm API. Nó chứa các lệnh thử nghiệm một số chức năng cốt lõi của các sản phẩm khác nhau, như:

1. [Thao tác với hình ảnh OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)  
2. [Đăng nhập vào các registry container](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)  
3. [Tạo các khối hệ thống file root](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)  
4. [Chạy các container Linux đơn giản](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)  

## Kernel Linux

Một kernel Linux là cần thiết để tạo máy ảo nhẹ trên macOS.  
Containerization cung cấp cấu hình kernel tối ưu nằm trong thư mục [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel).

Thư mục này bao gồm môi trường build container hóa để dễ dàng biên dịch kernel sử dụng với Containerization.

Cấu hình kernel là một tập hợp tối giản các tính năng để hỗ trợ thời gian khởi động nhanh và môi trường nhẹ.

Mặc dù cấu hình này sẽ phù hợp với phần lớn các khối lượng công việc, chúng tôi hiểu rằng một số trường hợp cần các tính năng bổ sung.  
Để giải quyết điều này, Containerization cung cấp API hàng đầu để sử dụng các cấu hình và phiên bản kernel khác nhau trên từng container.  
Điều này cho phép các container được phát triển và kiểm thử trên nhiều phiên bản kernel khác nhau.

Xem [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) trong thư mục kernel để biết hướng dẫn biên dịch kernel tối ưu.

### Kernel xây dựng sẵn

Nếu bạn muốn sử dụng kernel xây dựng sẵn, kernel đó phải có driver `VIRTIO` được biên dịch vào kernel, không phải dưới dạng module.

Dự án [Kata Containers](https://github.com/kata-containers/kata-containers) cung cấp một kernel tối ưu cho container với tất cả các tùy chọn cấu hình cần thiết được bật, có trên trang [releases](https://github.com/kata-containers/kata-containers/releases/).

Một ảnh kernel tên `vmlinux.container` có thể được tìm thấy trong thư mục `/opt/kata/share/kata-containers/` của các tệp phát hành.

## Chuẩn bị xây dựng gói

Cài đặt Swiftly, [Swift](https://www.swift.org), và [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html):

```bash
make cross-prep
```

Nếu bạn dùng ứng dụng terminal tùy chỉnh, bạn có thể cần chuyển lệnh này từ `.zprofile` sang `.zshrc` (thay `<USERNAME>`):

```bash
# Added by swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

Khởi động lại ứng dụng terminal. Đảm bảo lệnh này trả về `/Users/<USERNAME>/.swiftly/bin/swift` (thay `<USERNAME>`):

```bash
which swift
```

Nếu bạn đã cài hoặc dùng Static Linux SDK trước đó, bạn có thể cần xóa các phiên bản SDK cũ khỏi hệ thống (thay `<SDK-ID>`):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## Xây dựng gói

Xây dựng Containerization từ mã nguồn:

```bash
make all
```

## Kiểm thử gói

Sau khi xây dựng, chạy các bài kiểm thử cơ bản và tích hợp:

```bash
make test integration
```

Một kernel là cần thiết để chạy kiểm thử tích hợp.  
Nếu bạn không có kernel cục bộ để sử dụng, một kernel mặc định có thể được tải về bằng mục tiêu `make fetch-default-kernel`.

Việc tải kernel mặc định chỉ cần thực hiện sau lần xây dựng đầu tiên hoặc sau khi chạy `make clean`.

```bash
make fetch-default-kernel
make all test integration
```

## Protobufs

Containerization phụ thuộc vào các phiên bản cụ thể của `grpc-swift` và `swift-protobuf`. Bạn có thể cài đặt và tái tạo các giao diện RPC với:

```bash
make protos
```

## Tài liệu

Tạo tài liệu API để xem cục bộ bằng:

```bash
make docs
make serve-docs
```

Xem trước tài liệu bằng cách chạy lệnh sau trong terminal khác:

```bash
open http://localhost:8000/documentation/
```

## Đóng góp

Chúng tôi hoan nghênh và khuyến khích đóng góp cho Containerization. Vui lòng xem [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) để biết thêm thông tin.

## Trạng thái dự án

Phiên bản 0.1.0 là bản phát hành chính thức đầu tiên của Containerization. Các phiên bản trước không đảm bảo sự ổn định về mã nguồn.

Vì thư viện Containerization đang trong quá trình phát triển tích cực, sự ổn định mã nguồn chỉ được đảm bảo trong phạm vi các phiên bản nhỏ (ví dụ: giữa 0.1.1 và 0.1.2). Nếu bạn không muốn các cập nhật có thể phá vỡ mã nguồn, bạn có thể chỉ định phụ thuộc gói bằng `.upToNextMinorVersion(from: "0.1.0")`.

Các phiên bản nhỏ trong tương lai có thể giới thiệu các thay đổi về các quy tắc này khi cần thiết.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---