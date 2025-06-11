# Black-Hat-Zig

<p align="center">
  <img alt="GitHub License" src="https://img.shields.io/github/license/CX330Blake/black-hat-zig">
  <img alt="GitHub top language" src="https://img.shields.io/github/languages/top/cx330blake/black-hat-zig">
  <img alt="GitHub repo size" src="https://img.shields.io/github/repo-size/cx330blake/black-hat-zig">
  <img alt="X (formerly Twitter) Follow" src="https://img.shields.io/twitter/follow/CX330Blake">
</p>

<p height="350px" align="center">
  <img src="https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Black-Hat-Zig.png">
  <br/>
  <b>Xin chào các hacker. Xin chào các maldev. Xin chào các reverser. Rất vui được gặp bạn ở đây để khám phá sức mạnh đen tối của Zig!</b><br/><br/>
  <b>Bảo trì và quản lý bởi <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## Mục lục

- [Giới thiệu](#intro)
- [Tại sao chọn Zig?](#why-zig)
- [Biên dịch mã nguồn](#compiling-the-codes)
- [Đặt Payload](#payload-placement)
- [Làm rối Payload](#payload-obfuscation)
- [Mã hóa Payload](#payload-encryption)
- [Thực thi Payload](#payload-execution)
- [Reverse Shell](#reverse-shell)
- [Kỹ thuật Malware](#malware-techniques)
- [Công cụ Maldev](#maldev-tools)
- [Người đóng góp](#contributors)
- [Nguồn và Tham khảo](#credits--references)
- [Lịch sử Star](#star-history)
- [Tuyên bố miễn trừ](#disclaimer)

## Giới thiệu

> [!IMPORTANT]
> Dự án này liên tục được cập nhật!

Dự án này cung cấp nhiều kỹ thuật malware được triển khai bằng Zig vì tôi là một fan lớn của ngôn ngữ này. Bạn có thể sử dụng repo này để vũ khí hóa Zig. Black-Hat-Zig liên tục được cập nhật để đảm bảo chứa càng nhiều nội dung càng tốt. Sẽ thật tuyệt nếu bạn muốn tạo PR cho dự án này.

Được rồi, hãy cùng hack thế giới!

## Tại sao chọn Zig?

- 🤝 Dễ dàng tương tác với mã nguồn C/C++
- 🔎 Nó mới, nên khó bị phát hiện hơn
- 💪 Kiểm soát cấp thấp mạnh mẽ, thậm chí thấp hơn C
- 😱 Khó đảo ngược hơn nhờ trình biên dịch hiện đại
- 🛡️ Phụ thuộc thư viện thời gian chạy tối thiểu - Không có dấu chân thư viện chuẩn lớn
- 🎯 Không có hành vi không xác định - Xử lý tường minh các trường hợp biên giúp tránh crash

## Biên dịch mã nguồn

Bạn có thể kiểm tra mã trong từng thư mục. Ngoài ra, nếu mã sử dụng Windows API, bạn sẽ thấy gợi ý trong file `README.md` của thư mục dự án tương ứng, ví dụ, [tại đây](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

Tôi đã đặt sẵn mục tiêu biên dịch mặc định là `windows-x86_64` cho những đoạn mã cần Windows API, vì vậy bạn chỉ cần sao chép & dán lệnh sau để biên dịch trên Linux, Windows, thậm chí MacOS! (Nhưng bạn vẫn cần môi trường Windows để chạy file thực thi)

```bash
zig build
```

## Đặt Payload

Các kỹ thuật để đặt payload độc hại vào các vùng khác nhau của file thực thi.

- [.data Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## Làm rối Payload

Kỹ thuật làm rối nhằm ngụy trang payload và tránh bị phát hiện qua phân tích tĩnh hoặc dò mẫu.

- [Làm rối địa chỉ IP](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [Làm rối IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [Giải rối IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [Làm rối IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [Giải rối IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [Làm rối địa chỉ MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [Làm rối địa chỉ MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [Giải rối địa chỉ MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [Làm rối UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [Làm rối UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [Giải rối UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## Mã hóa Payload

Các phương pháp mã hóa khác nhau được sử dụng để che giấu mục đích thật của payload trong quá trình lưu trữ hoặc truyền tải.

- [Mã hóa XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR với thư viện chuẩn](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [Mã hóa RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 với SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [Mã hóa AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES với Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES với thư viện chuẩn](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES với TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## Thực thi Payload

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## Reverse Shell

Các primitive để thiết lập reverse shell cho truy cập C2 hoặc kiểm soát sau khai thác.

- [Reverse Shell với thư viện chuẩn](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## Kỹ thuật Malware

Tổng hợp các kỹ thuật tấn công phổ biến được điều chỉnh cho Zig.

- [Tiêm tiến trình (Process Injection)](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [Tiêm DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Tiêm Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [Tải payload nhiều giai đoạn (Payload Staging)](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [Từ máy chủ Web](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Từ Registry của Windows](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [Liệt kê tiến trình (Process Enumeration)](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [Sử dụng CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [Sử dụng EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [Sử dụng NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Công cụ Maldev

- [ZYRA: Giáp Runtime của bạn](https://github.com/cx330blake/zyra)
  - Trình packer file thực thi viết bằng Zig
- [ZYPE: Công cụ mã hóa Payload của bạn](https://github.com/cx330blake/zype)
  - Sinh mẫu code Zig chứa payload đã mã hóa/làm rối cùng hàm giải mã/giải rối tương ứng.

## Người đóng góp

Dự án này chủ yếu được bảo trì & quản lý bởi [@CX330Blake](https://github.com/CX330Blake). PR rất được chào đón. Hy vọng sẽ có nhiều người sử dụng Zig để phát triển malware để hệ sinh thái trở nên trưởng thành hơn.

Xin gửi lời cảm ơn lớn đến những người đóng góp sau!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## Nguồn và Tham khảo

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Lịch sử Star

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## Tuyên bố miễn trừ

Dự án này chỉ phục vụ mục đích đạo đức và giáo dục. Đừng trở thành tội phạm mạng.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---