secrets
=======

[![Build Status][badge-ci]][ci]
<!-- [![Test Coverage][badge-coverage]][coverage] -->
[![Cargo Crate][badge-package]][package]
[![Docs][badge-docs]][docs]
[![License][badge-license]][license]

`secrets` は Rust プログラマーが暗号化された秘密情報を安全にメモリに保持するのを助けるライブラリです。

これは主に [libsodium] が提供するメモリ保護ユーティリティの使いやすいラッパーです。

スタック上に割り当てられた固定サイズのバッファは以下の保護を受けます：

* 基盤となるメモリに対して [`mlock(2)`][mlock] が呼び出されます
* 使用されなくなったときに基盤となるメモリはゼロクリアされます
* ライフスパン全体で借用されるため移動できません
* 定数時間で比較されます
* `Debug` による表示が防止されます
* `Clone` されることが防止されます

固定サイズおよび可変サイズのバッファはヒープ上に割り当てられ、以下の保護を受けます：

* 基盤となるメモリはアクティブな借用がスコープ内にない限り
  [`mprotect(2)`][mprotect] によって読み書きから保護されます
* 割り当てられたメモリに対して [`mlock(2)`][mlock] が呼び出されます
* 使用されなくなったときに基盤となるメモリはゼロクリアされます
* 不正なオーバーフローとアンダーフローはアクセス不可のガードページを使って検出され、
  即座にセグメンテーションフォルトとプログラムの終了を引き起こします
* メモリ解放時にカナリアを用いて短いアンダーフローによるメモリ書き込みを検出し、
  セグメンテーションフォルトとプログラムの終了を引き起こします

パニック安全性
------------





このライブラリは明示的にパニックセーフではありません。保護されたメモリ空間の安全性を確保するために、
このライブラリは、宣言された保証を強制できない場合にパニックを起こすことがあります。

同様に、このライブラリは（かつ唯一）特定の安全違反を検出した場合にセグメンテーションフォルトを引き起こします。
例えば、プロセスが適切にロック解除されていないメモリの内容を直接読み書きしようとした場合や、
カナリアが上書きされた場合にこれが発生する可能性があります。このライブラリは、
そのような違反が適切に形成されたRustコードを通じて起こることが不可能であるように書かれており、
したがって、セキュリティ脆弱性の結果としてのみ発生するはずです。

Examples
--------

### 例：暗号鍵の生成




```rust
Secret::<[u8; 16]>::random(|s| {
    // use `s` as if it were a `&mut [u8; 16]`
    //
    // the memory is `mlock(2)`ed and will be zeroed when this closure
    // exits
});
```

### 例：マスターキーをディスクから読み込み、そこからサブキーを生成する

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

### 例：復号された暗号文をメモリに安全に保存する方法

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
ライセンス
-------

以下のいずれかのライセンスの下で許諾されています

 * [Apache License, Version 2.0](LICENSE-APACHE)
 * [MIT license](LICENSE-MIT)

お好みで選択可能です。

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