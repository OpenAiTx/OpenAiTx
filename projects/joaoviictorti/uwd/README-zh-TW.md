# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` 是一個用於 Windows 呼叫堆疊偽造的 Rust 函式庫，可讓你以偽造的呼叫堆疊執行任意函數，以規避在堆疊展開過程中的分析、日誌記錄或偵測。

靈感來自 [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)，此 crate 將底層偽造能力帶入乾淨、慣用的 Rust 介面，並完全支援 `#[no_std]`、`MSVC` 與 `GNU` 工具鏈，以及自動化 gadget 解析。

## 功能特色

- ✅ 透過 `Synthetic` 及 `Desync` 進行呼叫堆疊偽造。
- ✅ 相容於 `MSVC` 及 `GNU` 工具鏈（**x64**）。
- ✅ 內嵌巨集：`spoof!`、`spoof_synthetic!`、`syscall!`、`syscall_synthetic!`。
- ✅ 支援 `#[no_std]` 環境（需搭配 `alloc`）。

## 快速開始

將 `uwd` 加入你的專案，更新你的 `Cargo.toml`：
```bash
cargo add uwd
```

## 用法

`uwd` 允許你在 Rust 中偽造呼叫堆疊，無論是呼叫標準 Windows API 還是進行間接系統呼叫。該函式庫會自動處理偽造堆疊幀、gadget 鏈，以及暫存器的準備，使執行看起來像是來自合法來源。

你可以偽造：

* 一般函數（如 `VirtualAlloc`、`WinExec` 等）
* 具自動 SSN 及 stub 解析的原生系統呼叫（如 `NtAllocateVirtualMemory`）

巨集 `spoof!` / `spoof_synthetic!` 及 `syscall!` / `syscall_synthetic!` 將所有複雜性抽象化。

### 偽造 WinExec

此範例展示如何利用偽造堆疊呼叫來啟動 `calc.exe`。我們用 Desync 技術呼叫一次 `WinExec`，再用 Synthetic 技術呼叫一次。

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // 解析要使用的 WinAPI 函數位址
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // 使用 `WinExec` 執行命令
    // 呼叫堆疊偽造（Desync）
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec 執行失敗");
        return Ok(());
    }

    // 呼叫堆疊偽造（Synthetic）
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec 執行失敗 [2]");
        return Ok(());
    }

    Ok(())
}
```

### 偽造間接系統呼叫

此範例利用偽造堆疊對 `NtAllocateVirtualMemory` 進行間接系統呼叫。

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // 使用呼叫堆疊偽造（Desync）執行間接系統呼叫
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory 執行失敗，狀態碼: {status:#X}");
        return Ok(())
    }

    println!("[+] 已配置位址: {:?}", addr);

    // 使用呼叫堆疊偽造（Synthetic）執行間接系統呼叫
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory 執行失敗 [2]，狀態碼: {status:#X}");
        return Ok(())
```
}

println!("[+] 已配置地址: {:?}", addr);

Ok(())
}
```

## 其他資源

如需更多範例，請查閱本儲存庫中的 [examples](/examples) 資料夾。

## 參考資料

我要感謝這些項目給予我靈感，讓我創建了 `uwd` 並貢獻了一些功能：

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

特別感謝：

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## 授權條款

本專案採用 MIT 授權條款。詳情請參閱 [LICENSE](/LICENSE) 檔案。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---