secrets
=======

[![Estado de Construcción][badge-ci]][ci]
<!-- [![Cobertura de Pruebas][badge-coverage]][coverage] -->
[![Paquete Cargo][badge-package]][package]
[![Documentación][badge-docs]][docs]
[![Licencia][badge-license]][license]

`secrets` es una biblioteca para ayudar a los programadores de Rust a mantener
de forma segura secretos criptográficos en memoria.

Es principalmente un envoltorio ergonómico alrededor de las utilidades de
protección de memoria proporcionadas por [libsodium].

Los búferes de tamaño fijo asignados en la pila obtienen las siguientes protecciones:

* Se llama a [`mlock(2)`][mlock] sobre la memoria subyacente
* la memoria subyacente se borra cuando ya no se usa
* se toman prestados durante toda su vida útil, por lo que no pueden moverse
* se comparan en tiempo constante
* se evita que se impriman con `Debug`
* se evita que se `Clone`en

Los búferes de tamaño fijo y variable pueden asignarse en el montón y obtienen
las siguientes protecciones:

* la memoria subyacente está protegida contra lectura o escritura
  con [`mprotect(2)`][mprotect] a menos que haya un préstamo activo en alcance
* se llama a [`mlock(2)`][mlock] en la memoria asignada
* la memoria subyacente se borra cuando ya no se usa
* los desbordamientos y subdesbordamientos se detectan usando páginas centinela inaccesibles,
  causando una falla de segmentación inmediata y terminación del programa
* los subdesbordamientos cortos que escriben en memoria se detectan cuando la memoria es
  liberada usando canarios, y resultarán en una falla de segmentación y
  terminación del programa

Seguridad ante Panic
------------

Esta biblioteca no es explícitamente segura contra pánicos. Para garantizar la seguridad del
espacio de memoria protegido, esta biblioteca puede y generará un pánico si no puede
hacer cumplir las garantías anunciadas.

De manera similar, esta biblioteca causará fallos de segmentación si (y solo si)
detecta ciertas violaciones de seguridad. Por ejemplo, esto puede suceder si
un proceso intenta leer o escribir directamente en el contenido de la memoria
que no ha sido correctamente desbloqueada, o si las canarias han sido
sobrescritas. Esta biblioteca ha sido escrita para asegurar que tales
violaciones deberían ser imposibles de causar mediante Rust bien formado, y
por lo tanto solo deberían ocurrir como resultado de una vulnerabilidad de seguridad.

Ejemplos
--------

### Ejemplo: generación de claves criptográficas

```rust
Secret::<[u8; 16]>::random(|s| {
    // use `s` as if it were a `&mut [u8; 16]`
    //
    // the memory is `mlock(2)`ed and will be zeroed when this closure
    // exits
});
```

### Ejemplo: cargar una clave maestra desde el disco y generar subclaves a partir de ella

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

### Ejemplo: almacenamiento seguro de un texto cifrado descifrado en memoria

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
Licencia
--------

Licenciado bajo cualquiera de

 * [Licencia Apache, Versión 2.0](LICENSE-APACHE)
 * [Licencia MIT](LICENSE-MIT)

a su elección.

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