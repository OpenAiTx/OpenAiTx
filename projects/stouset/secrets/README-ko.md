secrets
=======

[![Build Status][badge-ci]][ci]
<!-- [![Test Coverage][badge-coverage]][coverage] -->
[![Cargo Crate][badge-package]][package]
[![Docs][badge-docs]][docs]
[![License][badge-license]][license]

`secrets`는 Rust 프로그래머가 암호화된 비밀을 안전하게 메모리에 보관할 수 있도록 도와주는 라이브러리입니다.

이 라이브러리는 주로 [libsodium]에서 제공하는 메모리 보호 유틸리티를
인체공학적으로 감싼 래퍼입니다.

스택에 할당된 고정 크기 버퍼는 다음과 같은 보호 기능을 갖습니다:

* 기본 메모리에 대해 [`mlock(2)`][mlock]이 호출됩니다
* 더 이상 사용하지 않을 때 기본 메모리가 0으로 초기화됩니다
* 전체 수명 동안 빌림되어 이동할 수 없습니다
* 상수 시간에 비교됩니다
* `Debug`에 의해 출력되는 것을 방지합니다
* `Clone`되는 것을 방지합니다

고정 및 가변 크기 버퍼는 힙에 할당될 수 있으며 다음과 같은 보호 기능을 갖습니다:

* 활성 빌림이 범위 내에 있지 않으면 [`mprotect(2)`][mprotect]로 인해 기본 메모리를 읽거나 쓸 수 없습니다
* 할당된 메모리에 대해 [`mlock(2)`][mlock]이 호출됩니다
* 더 이상 사용하지 않을 때 기본 메모리가 0으로 초기화됩니다
* 접근 불가능한 가드 페이지를 사용하여 오버플로우와 언더플로우를 감지하며,
  즉시 세그먼트 오류 및 프로그램 종료를 유발합니다
* 메모리가 해제될 때 카나리를 사용하여 짧은 언더플로우로 메모리에 쓰는 것을 감지하며,
  세그먼트 오류 및 프로그램 종료를 초래합니다

패닉 안전성
------------





이 라이브러리는 명시적으로 패닉 안전하지 않습니다.  
보호된 메모리 공간의 안전성을 보장하기 위해, 이 라이브러리는 보장된 조건을  
준수할 수 없을 경우 패닉을 발생시킬 수 있으며 실제로 발생시킵니다.  

마찬가지로, 이 라이브러리는 특정 안전 위반이 감지되면 (그리고 그 경우에만)  
세그멘테이션 오류(segmentation fault)를 일으킵니다. 예를 들어,  
프로세스가 적절히 잠금 해제되지 않은 메모리 내용을 직접 읽거나 쓰려고 하거나,  
카나리아(canary)가 덮어쓰여진 경우에 발생할 수 있습니다. 이 라이브러리는  
잘 작성된 러스트 코드를 통해서는 이러한 위반이 발생할 수 없도록 작성되었으며,  
따라서 이런 문제는 보안 취약점으로 인해 발생할 수 있습니다.  

예제  
--------  

### 예제: 암호화 키 생성하기


```rust
Secret::<[u8; 16]>::random(|s| {
    // use `s` as if it were a `&mut [u8; 16]`
    //
    // the memory is `mlock(2)`ed and will be zeroed when this closure
    // exits
});
```

### 예제: 마스터 키를 디스크에서 불러와 서브키를 생성하기

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

### 예제: 복호화된 암호문을 메모리에 안전하게 저장하기

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
라이선스
-------

다음 중 하나의 라이선스에 따라 제공됩니다

 * [아파치 라이선스, 버전 2.0](LICENSE-APACHE)
 * [MIT 라이선스](LICENSE-MIT)

선택에 따라 사용 가능합니다.

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