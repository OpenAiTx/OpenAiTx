# vmprotect ![crates.io](https://img.shields.io/crates/v/vmprotect.svg)

SDK VMProtect en cours de développement pour Rust

## Fonctionnalités de base de VMProtect

### Attribut `protected`

Vous devez ajouter [ce script](https://raw.githubusercontent.com/CertainLach/vmprotect/master/./script.lua) au projet vmprotect pour cet attribut

Syntaxe :

```rust
#[protected(TYPE[, lock])]
fn some_fn() { ... }
```

- TYPE : Type de protection
- [, verrouiller] : Nécessite une licence pour que cette fonction fonctionne.

Exemple :

```rust
#[protected(virtualize)]
fn stringify<T: Display>(value: T) -> String {
    format!("{}", value)
}
```

### Macro `protected!` pour le code

Syntaxe :

```rust
use vmprotect::protected;

protected!(TYPE[, lock] "NAME"; { /*CODE*/ })
```

- NAME : Quel nom sera affiché dans l'interface graphique de VMProtect  
- TYPE : Type de protection (muter/virtualiser/ultra selon la documentation de VMProtect)  
- [, lock] : Pour virtualiser/ultra uniquement, nécessite l'activation de la licence pour que cette fonction fonctionne  
- CODE : Votre code va ici  

Le bloc de code protégé fonctionne comme n'importe quel autre bloc Rust, c'est-à-dire :

```rust
use vmprotect::protected;

// Before protection
let a = {2+3};
// After protection
let a = protected!(virtualize "Addiction"; { 2 + 3 });
```
Exemple :


```rust
fn main() {
    println!("{} + {} = {}", a, b, protected!(ultra "Adding"; {
        a + b
    }));
}
```

### Macro `protected!` pour les textes

Syntaxe :

```rust
use vmprotect::protected;

protected!(TYPE "TEXT")
```

- TYPE : Type de texte, valeurs possibles : cstr (pour les chaînes c normales) / cwstr (pour les chaînes c uint16_t (utilisées par ex. sous Windows))
- TEXT : Votre texte, doit être compatible avec le type de texte sélectionné

Cette macro renvoie une chaîne, qui peut être transformée en une chaîne normale. Cette chaîne est libérée lorsqu'elle est supprimée, l'implémentation se trouve dans `vmprotect::strings::{encrypted_a::EncryptedStringA, encrypted_w::EncryptedStringW}`

```rust
use vmprotect::protected;

// Before protection
let a = "Hello, world!";
// After protection
let a = protected!(cstr "Hello, world!");
// Also for wide-strings:
let a = protected!(cwstr "Привет, мир!");
```
Exemple :


```rust
use vmprotect::protected;

fn main() {
    println!("Hello, {:?}!", protected!(A; "%Username%").into() as String);
}
```

## Licence

Section TODO, voir la documentation pour l'instant

### HWID

Exemple :

```rust
println!("Your hwid is \"{}\"", vmprotect::licensing::get_hwid().to_str().unwrap());
```

## Problèmes connus

### MacOS : Pas assez d'espace pour le nouveau segment dans l'en-tête du fichier

Peut être corrigé en ajoutant `-C link-arg=-Wl,-headerpad,0x500` aux arguments de rustc

Pour cargo :

```rs
export RUSTFLAGS="-C link-arg=-Wl,-headerpad,0x500"
```

(Basé sur <http://vmpsoft.com/forum/viewtopic.php?f=2&t=6837&start=15#p10527>)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-26

---