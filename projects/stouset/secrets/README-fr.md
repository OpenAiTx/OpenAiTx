secrets
=======

[![Build Status][badge-ci]][ci]
<!-- [![Test Coverage][badge-coverage]][coverage] -->
[![Cargo Crate][badge-package]][package]
[![Docs][badge-docs]][docs]
[![License][badge-license]][license]

`secrets` est une bibliothèque pour aider les programmeurs Rust à conserver en mémoire
des secrets cryptographiques en toute sécurité.

C’est principalement une interface ergonomique autour des utilitaires de protection de mémoire
fournis par [libsodium].

Les tampons de taille fixe alloués sur la pile bénéficient des protections suivantes :

* [`mlock(2)`][mlock] est appelé sur la mémoire sous-jacente
* la mémoire sous-jacente est mise à zéro lorsqu’elle n’est plus utilisée
* ils sont empruntés pendant toute leur durée de vie, donc ne peuvent pas être déplacés
* ils sont comparés en temps constant
* ils sont empêchés d’être affichés par `Debug`
* ils sont empêchés d’être `Clone`és

Les tampons de taille fixe ou variable peuvent être alloués sur le tas et bénéficient
des protections suivantes :

* la mémoire sous-jacente est protégée contre la lecture ou l’écriture
  avec [`mprotect(2)`][mprotect] sauf si un emprunt actif est en cours
* [`mlock(2)`][mlock] est appelé sur la mémoire allouée
* la mémoire sous-jacente est mise à zéro lorsqu’elle n’est plus utilisée
* les dépassements et sous-dépassements sont détectés grâce à des pages de garde inaccessibles,
  provoquant un segfault immédiat et la terminaison du programme
* les petits sous-dépassements qui écrivent en mémoire sont détectés lors de la libération de la mémoire grâce à des canaris, et entraînent un segfault et
  la terminaison du programme

Sécurité en cas de panic
------------


Cette bibliothèque n’est explicitement pas à l’abri des paniques. Pour garantir la sécurité de
l’espace mémoire protégé, cette bibliothèque peut et va paniquer si elle est incapable
de faire respecter les garanties annoncées.

De même, cette bibliothèque provoquera des erreurs de segmentation si (et seulement si)
elle détecte certaines violations de sécurité. Par exemple, cela peut se produire si
un processus tente de lire ou d’écrire directement dans le contenu de la mémoire
qui n’a pas été correctement déverrouillée, ou si les canaris ont été
écrasés. Cette bibliothèque a été conçue pour garantir que de telles
violations devraient être impossibles à causer via un Rust bien formé, et
doivent donc seulement survenir à la suite d’une vulnérabilité de sécurité.

Exemples
--------

### Exemple : génération de clés cryptographiques

```rust
Secret::<[u8; 16]>::random(|s| {
    // use `s` as if it were a `&mut [u8; 16]`
    //
    // the memory is `mlock(2)`ed and will be zeroed when this closure
    // exits
});
```

### Exemple : charger une clé principale depuis le disque et générer des sous-clés à partir de celle-ci

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

### Exemple : stockage sécurisé d’un texte chiffré déchiffré en mémoire

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

Licence
-------

Distribué sous l'une des licences suivantes

 * [Licence Apache, version 2.0](LICENSE-APACHE)
 * [Licence MIT](LICENSE-MIT)

à votre choix.

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