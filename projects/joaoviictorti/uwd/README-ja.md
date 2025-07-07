# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd`はWindows上でコールスタックスプーフィングを行うためのRustライブラリであり、スタックの巻き戻し中に解析、ログ記録、または検出を回避する偽装されたコールスタックで任意の関数を実行することを可能にします。

[SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)にインスパイアされ、このクレートは低レベルのスプーフィング機能を、クリーンでイディオマティックなRustインターフェースにまとめ、`#[no_std]`、`MSVC`および`GNU`ツールチェーン、そして自動ガジェット解決に完全対応しています。

## 特徴

- ✅ `Synthetic`と`Desync`によるコールスタックスプーフィング。
- ✅ `MSVC`および`GNU`ツールチェーン（**x64**）の両方に対応。
- ✅ インラインマクロ: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`。
- ✅ `#[no_std]`環境（`alloc`が必要）をサポート。

## はじめに

`Cargo.toml`を更新して`uwd`をプロジェクトに追加します:
```bash
cargo add uwd
```

## 使い方

`uwd`は、標準のWindows API呼び出しや間接的なシステムコールを実行する際に、Rustでコールスタックを偽装することを可能にします。このライブラリは、偽のフレーム、ガジェットチェーン、レジスタの準備の全てを処理し、実行が正規のソースから発生したように見せかけます。

スプーフィングできるもの:

* 通常の関数（例: `VirtualAlloc`, `WinExec`など）
* SSNとスタブの自動解決を備えたネイティブシステムコール（例: `NtAllocateVirtualMemory`）

マクロ`spoof!` / `spoof_synthetic!`、`syscall!` / `syscall_synthetic!`が全ての複雑さを抽象化します。

### WinExecのスプーフィング

この例では、スプーフィングされたコールスタックを使って`calc.exe`を起動する方法を示します。`WinExec`をDesync手法とSynthetic手法でそれぞれ2回呼び出しています。

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // 使用するWinAPI関数のアドレスを解決
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // `WinExec`でコマンド実行
    // コールスタックスプーフィング（Desync）
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Failed");
        return Ok(());
    }

    // コールスタックスプーフィング（Synthetic）
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Failed [2]");
        return Ok(());
    }

    Ok(())
}
```

### 間接Syscallのスプーフィング

この例は、スプーフィングされたコールスタックで`NtAllocateVirtualMemory`への間接的なシステムコールを実行します。

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // コールスタックスプーフィング（Desync）による間接Syscallの実行
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory Failed With Status: {status:#X}");
        return Ok(())
    }

    println!("[+] Address allocated: {:?}", addr);

    // コールスタックスプーフィング（Synthetic）による間接Syscallの実行
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory Failed With Status [2]: {status:#X}");
        return Ok(())
```
}

println!("[+] アドレスが割り当てられました: {:?}", addr);

Ok(())
}
```

## 追加リソース

さらに例を確認したい場合は、リポジトリ内の [examples](/examples) フォルダーをご覧ください。

## 参考文献

`uwd` を作成し、いくつかの機能を追加するにあたりインスピレーションを与えてくれた以下のプロジェクトに感謝します：

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

特別な感謝を以下の方々へ：

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## ライセンス

このプロジェクトはMITライセンスの下でライセンスされています。詳細については [LICENSE](/LICENSE) ファイルをご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---