# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` 是一个用于 Windows 调用栈伪造的 Rust 库，允许你以伪造的调用栈执行任意函数，从而在栈展开分析、日志记录或检测过程中实现规避。

受 [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk) 启发，该 crate 将底层伪造能力引入到一个简洁、符合 Rust 习惯的接口中，完全支持 `#[no_std]`、`MSVC` 与 `GNU` 工具链，并带有自动化的 gadget 解析。

## 功能特性

- ✅ 通过 `Synthetic` 和 `Desync` 实现调用栈伪造。
- ✅ 同时兼容 `MSVC` 和 `GNU` 工具链（**x64**）。
- ✅ 内联宏：`spoof!`、`spoof_synthetic!`、`syscall!`、`syscall_synthetic!`。
- ✅ 支持 `#[no_std]` 环境（需配合 `alloc`）。

## 快速开始

通过更新你的 `Cargo.toml` 文件将 `uwd` 添加到你的项目中：
```bash
cargo add uwd
```

## 用法

`uwd` 允许你在 Rust 中调用标准 Windows API 或执行间接系统调用时进行调用栈伪造。该库会自动处理伪造帧、gadget 链与寄存器准备，使得执行看起来像是来自合法来源。

你可以伪造：

* 普通函数（如 `VirtualAlloc`、`WinExec` 等）
* 自动 SSN 和存根解析的原生系统调用（如 `NtAllocateVirtualMemory`）

宏 `spoof!` / `spoof_synthetic!` 以及 `syscall!` / `syscall_synthetic!` 封装了所有复杂性。

### 伪造 WinExec

以下示例展示了如何使用伪造的调用栈启动 `calc.exe`。我们分别用 Desync 技术和 Synthetic 技术调用了两次 `WinExec`。

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // 解析要调用的 WinAPI 函数地址
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // 使用 `WinExec` 执行命令
    // 调用栈伪造（Desync）
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Failed");
        return Ok(());
    }

    // 调用栈伪造（Synthetic）
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Failed [2]");
        return Ok(());
    }

    Ok(())
}
```

### 伪造间接系统调用

以下示例展示了如何对 `NtAllocateVirtualMemory` 进行间接系统调用，并伪造调用栈。

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // 使用调用栈伪造（Desync）运行间接系统调用
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory Failed With Status: {status:#X}");
        return Ok(())
    }

    println!("[+] Address allocated: {:?}", addr);

    // 使用调用栈伪造（Synthetic）运行间接系统调用
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory Failed With Status [2]: {status:#X}");
        return Ok(())
```
}

println!("[+] 地址已分配: {:?}", addr);

Ok(())
}
```

## 其他资源

更多示例请参见仓库中的 [examples](/examples) 文件夹。

## 参考资料

我要感谢以下项目，它们启发我创建了 `uwd` 并贡献了一些功能：

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

特别感谢：

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## 许可证

本项目采用 MIT 许可证。详情请参见 [LICENSE](/LICENSE) 文件。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---