secrets
=======

[![构建状态][badge-ci]][ci]
<!-- [![测试覆盖率][badge-coverage]][coverage] -->
[![Cargo 包][badge-package]][package]
[![文档][badge-docs]][docs]
[![许可证][badge-license]][license]

`secrets` 是一个库，帮助 Rust 程序员安全地在内存中保存加密
密钥。

它主要是对 [libsodium] 提供的内存保护工具的一个符合人体工学的封装。

在栈上分配的固定大小缓冲区获得以下保护：

* 在底层内存上调用 [`mlock(2)`][mlock]
* 不再使用时底层内存被清零
* 在整个生命周期内被借用，因此不能被移动
* 以常量时间进行比较
* 防止通过 `Debug` 打印
* 防止被 `Clone`

固定和可变大小的缓冲区可以在堆上分配，并获得以下保护：

* 除非有活动借用处于作用域，否则底层内存通过 [`mprotect(2)`][mprotect] 
  被保护，防止读写
* 在分配的内存上调用 [`mlock(2)`][mlock]
* 不再使用时底层内存被清零
* 使用不可访问的保护页检测溢出和下溢，导致立即段错误和程序终止
* 使用金丝雀检测释放内存时写入内存的短下溢，会导致段错误和程序终止

恐慌安全
------------






此库明确不保证恐慌安全。为了确保受保护内存空间的安全性，  
如果无法执行其声明的保证，该库可能并且会触发恐慌。  

同样地，如果（且仅当）检测到某些安全违规行为，该库将导致段错误。  
例如，如果进程试图直接读取或写入未正确解锁的内存内容，或者金丝雀已被  
覆盖，就可能发生这种情况。该库的编写确保通过良构的 Rust 代码不可能  
引起此类违规，因此这类情况应仅因安全漏洞而发生。  

示例  
--------  

### 示例：生成加密密钥





```rust
Secret::<[u8; 16]>::random(|s| {
    // use `s` as if it were a `&mut [u8; 16]`
    //
    // the memory is `mlock(2)`ed and will be zeroed when this closure
    // exits
});
```

### 示例：从磁盘加载主密钥并从中生成子密钥

```rust
use std::fs::File;
use std::io::Read;

use libsodium_sys as sodium;
use secrets::SecretBox;

const KEY_LEN : usize = sodium::crypto_kdf_KEYBYTES     as _;
const CTX_LEN : usize = sodium::crypto_kdf_CONTEXTBYTES as _;

const CONTEXT : &[u8; CTX_LEN] = b"example\0";

fn derive_subkey(
    key:       &[u8; KEY_LEN],
    context:   &[u8; CTX_LEN],
    subkey_id: u64,
    subkey:    &mut [u8],
) {
    unsafe {
        libsodium_sys::crypto_kdf_derive_from_key(
            subkey.as_mut_ptr(),
            subkey.len(),
            subkey_id,
            context.as_ptr().cast(),
            key.as_ptr()
        );
    }
}

let master_key = SecretBox::<[u8; KEY_LEN]>::try_new(|mut s| {
    File::open("example/master_key/key")?.read_exact(s)
})?;

let subkey_0 = SecretBox::<[u8; 16]>::new(|mut s| {
    derive_subkey(&master_key.borrow(), CONTEXT, 0, s);
});

let subkey_1 = SecretBox::<[u8; 16]>::new(|mut s| {
    derive_subkey(&master_key.borrow(), CONTEXT, 1, s);
});

assert_ne!(
    subkey_0.borrow(),
    subkey_1.borrow(),
);
```

### 示例：在内存中安全存储解密后的密文

```rust
use std::fs::File;
use std::io::Read;

use libsodium_sys as sodium;
use secrets::{SecretBox, SecretVec};

const KEY_LEN   : usize = sodium::crypto_secretbox_KEYBYTES   as _;
const NONCE_LEN : usize = sodium::crypto_secretbox_NONCEBYTES as _;
const MAC_LEN   : usize = sodium::crypto_secretbox_MACBYTES   as _;

let mut key        = SecretBox::<[u8; KEY_LEN]>::zero();
let mut nonce      = [0; NONCE_LEN];
let mut ciphertext = Vec::new();

File::open("example/decrypted_ciphertext/key")?
    .read_exact(key.borrow_mut().as_mut())?;

File::open("example/decrypted_ciphertext/nonce")?
    .read_exact(&mut nonce)?;

File::open("example/decrypted_ciphertext/ciphertext")?
    .read_to_end(&mut ciphertext)?;

let plaintext = SecretVec::<u8>::new(ciphertext.len() - MAC_LEN, |mut s| {
    if -1 == unsafe {
        sodium::crypto_secretbox_open_easy(
            s.as_mut_ptr(),
            ciphertext.as_ptr(),
            ciphertext.len() as _,
            nonce.as_ptr(),
            key.borrow().as_ptr(),
        )
    } {
        panic!("failed to authenticate ciphertext during decryption");
    }
});

assert_eq!(
    *b"attack at dawn",
    *plaintext.borrow(),
);
```
许可证
-------

您可以选择以下任一许可证：

 * [Apache 许可证，版本 2.0](LICENSE-APACHE)
 * [MIT 许可证](LICENSE-MIT)

由您决定。

[ci]:       https://github.com/stouset/secrets/actions/workflows/test.yml
<!-- [coverage]: https://coveralls.io/github/stouset/secrets -->
[docs]:     https://docs.rs/secrets/latest/secrets/
[license]:  https://github.com/stouset/secrets/blob/master/LICENSE
[package]:  https://crates.io/crates/secrets

[badge-ci]:       https://github.com/stouset/secrets/actions/workflows/test.yml/badge.svg
<!-- [badge-coverage]: https://coveralls.io/repos/github/stouset/secrets/badge.svg -->
[badge-docs]:     https://docs.rs/secrets/badge.svg
[badge-license]:  https://img.shields.io/crates/l/secrets.svg
[badge-package]:  https://img.shields.io/crates/v/secrets.svg

[libsodium]: https://download.libsodium.org/doc/memory_management
[mlock]:     http://man7.org/linux/man-pages/man2/mlock.2.html
[mprotect]:  http://man7.org/linux/man-pages/man2/mprotect.2.html



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-04

---