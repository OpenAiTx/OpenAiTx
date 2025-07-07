# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` là một thư viện Rust cho kỹ thuật giả mạo ngăn xếp lệnh gọi trên Windows, cho phép bạn thực thi các hàm tùy ý với một ngăn xếp lệnh gọi giả mạo nhằm tránh bị phân tích, ghi log hoặc phát hiện trong quá trình unwind ngăn xếp.

Lấy cảm hứng từ [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk), crate này mang lại khả năng giả mạo cấp thấp vào một giao diện Rust sạch sẽ, chuẩn mực với hỗ trợ đầy đủ cho `#[no_std]`, các bộ công cụ `MSVC` và `GNU`, cùng khả năng tự động phân giải gadget.

## Tính năng

- ✅ Giả mạo ngăn xếp lệnh gọi thông qua `Synthetic` và `Desync`.
- ✅ Tương thích với cả hai bộ công cụ `MSVC` và `GNU` (**x64**).
- ✅ Macro nội tuyến: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`.
- ✅ Hỗ trợ môi trường `#[no_std]` (với `alloc`).

## Bắt đầu

Thêm `uwd` vào dự án của bạn bằng cách cập nhật `Cargo.toml`:
```bash
cargo add uwd
```

## Cách sử dụng

`uwd` cho phép bạn giả mạo ngăn xếp lệnh gọi trong Rust khi gọi cả các API Windows tiêu chuẩn hoặc thực hiện các syscall gián tiếp. Thư viện này xử lý hoàn chỉnh việc thiết lập các khung giả, chuỗi gadget, và chuẩn bị thanh ghi để làm cho việc thực thi trông như đến từ một nguồn hợp lệ.

Bạn có thể giả mạo:

* Các hàm thông thường (như `VirtualAlloc`, `WinExec`, v.v.)
* Các syscall gốc với khả năng tự động phân giải SSN và stub (như `NtAllocateVirtualMemory`)

Các macro `spoof!` / `spoof_synthetic!` và `syscall!` / `syscall_synthetic!` giúp trừu tượng hóa toàn bộ sự phức tạp này.

### Giả mạo WinExec

Ví dụ này minh họa cách khởi chạy `calc.exe` bằng ngăn xếp lệnh gọi đã bị giả mạo. Chúng ta gọi `WinExec` hai lần, một lần sử dụng kỹ thuật Desync, và một lần sử dụng Synthetic.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Phân giải địa chỉ các hàm WinAPI sẽ sử dụng
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // Thực thi lệnh với `WinExec`
    // Giả mạo ngăn xếp lệnh gọi (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Thất bại");
        return Ok(());
    }

    // Giả mạo ngăn xếp lệnh gọi (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Thất bại [2]");
        return Ok(());
    }

    Ok(())
}
```

### Giả mạo một Syscall gián tiếp

Ví dụ này thực hiện một syscall hệ thống gián tiếp tới `NtAllocateVirtualMemory` với ngăn xếp lệnh gọi đã bị giả mạo.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Thực thi syscall gián tiếp với giả mạo ngăn xếp lệnh gọi (Desync)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory Thất bại với Status: {status:#X}");
        return Ok(())
    }

    println!("[+] Địa chỉ đã được cấp phát: {:?}", addr);

    // Thực thi syscall gián tiếp với giả mạo ngăn xếp lệnh gọi (Synthetic)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory Thất bại với Status [2]: {status:#X}");
        return Ok(())
```
}

println!("[+] Địa chỉ đã được cấp phát: {:?}", addr);

Ok(())
}
```

## Tài nguyên bổ sung

Để xem thêm các ví dụ, hãy kiểm tra thư mục [examples](/examples) trong kho lưu trữ.

## Tham khảo

Tôi muốn bày tỏ lòng biết ơn đến các dự án đã truyền cảm hứng cho tôi tạo ra `uwd` và đóng góp một số tính năng:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

Đặc biệt cảm ơn:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## Giấy phép

Dự án này được cấp phép theo Giấy phép MIT. Xem tệp [LICENSE](/LICENSE) để biết chi tiết.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---