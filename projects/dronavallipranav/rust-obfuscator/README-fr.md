# Rust-Obfuscator

`rust-obfuscator` est un ensemble d'outils conçus pour obfusquer automatiquement le code source Rust en insérant des macros procédurales ou en fournissant (optionnellement) l'obfuscation directement dans le code source. Pour une obfuscation plus fine, une bibliothèque de macros procédurales [cryptify](https://crates.io/crates/cryptify) est également fournie.

## Actuellement pris en charge
1. chiffrement des littéraux de chaîne
2. obfuscation du flux de contrôle
3. obfuscation du flux de contrôle (code source)
4. renommage de variables (code source)

## Fonctionnalités

- **Chiffrement de chaîne** : chiffre automatiquement les littéraux de chaîne assignés aux variables locales à la compilation.
    - Peut aussi être utilisé pour les chaînes formatées, mais nécessite actuellement un placement manuel
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **Obfuscation du flux de contrôle** : Introduit des boucles factices de compilation et des variables aléatoires.
- **Obfuscation personnalisable** : Offre la flexibilité d'activer ou de désactiver des fonctionnalités spécifiques d'obfuscation selon vos besoins.
- **Renommage des variables** : Obfuscation directe du code source, si vous souhaitez distribuer le code ou simplement rendre votre code plus difficile à comprendre.
- NOTE : le renommage des variables n'est pas entièrement fonctionnel à partir de la version 1.1.1, un support complet est en cours car certains cas ne sont pas encore couverts. Vous pouvez toujours utiliser l'outil et corriger les erreurs de compilation appropriées.

## Installation

Ajoutez `cryptify` à votre `Cargo.toml` en tant que dépendance :

```toml
[dependencies]
cryptify = "3.2.1"
```

Pour installer `rust-obfuscator`, clonez le dépôt et compilez l'outil avec Cargo depuis la racine :
```
cargo build --release --bin rust-obfuscator
```
Le binaire peut ensuite être trouvé sous /target/release, vous pouvez le copier à la racine du projet de cette façon
```
cp ./target/release/rust-obfuscator .
```

# Utilisation
Définissez la variable d'environnement **CRYPTIFY_KEY** pour un chiffrement personnalisé sinon elle utilise la clé fixe définie
- Ajoutez au code source que vous souhaitez modifier
```rs
use cryptify;
```
Le binaire peut être utilisé sur un fichier ou un répertoire. S'il est fourni avec un répertoire, il ne modifiera que les fichiers source Rust dans ce répertoire, pas dans les sous-répertoires.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- Tout le code obfusqué se trouvera sous le répertoire **obfuscated_code** créé à partir du répertoire où l'outil a été exécuté.  
- **Il est recommandé d'utiliser un formateur Rust avec le code obfusqué car syn modifie naturellement la structure et il sera écrit dans le fichier sur une seule ligne**  

## Options des drapeaux  
- --no_string : Désactive l'obfuscation des chaînes.  
- --no_flow : Désactive l'obfuscation du flux de contrôle.  
- --disable_macro : Utilise la manipulation directe du code source pour l'obfuscation du flux au lieu des macros procédurales.  
- --var : Active l'obfuscation du code source par renommage des variables.  

### Exemple d'utilisation avec un drapeau
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(désactive l'obfuscation du flux)

# Entrée
-exécution de l'outil sans configuration
```rs
use cryptify;
mod word_counter;
use std::env;
use std::fs;
use word_counter::count_words;
fn main() {
    let b = "Hello World";
    println!("{}", b);
    let args: Vec<String> = env::args().collect();
    if args.len() < 2 {
        eprintln!("Usage: {} <filename>", args[0]);
        return;
    }
    let filename = &args[1];
    let content = fs::read_to_string(filename).expect("Could not read file");
    let word_counts = count_words(&content);
    for (word, count) in word_counts.iter() {
        println!("{}: {}", word, count);
    }
}

fn dummy() {
    let a = 1;
    let b = 2;
    let c = a + b;
    println!("{}", c);
}

fn calc_sum(a: i32, b: i32) -> i32 {
    cryptify::flow_stmt!();
    let c = a + b;
    c
}

fn helloooo(){
    println!("hi");
}

```
# Sortie
```rs
fn main() {
    cryptify::flow_stmt!();
    let b = cryptify::encrypt_string!("Hello World");
    println!("{}", b);
    let args: Vec<String> = env::args().collect();
    if args.len() < 2 {
        eprintln!("Usage: {} <filename>", args[0]);
        return;
    }
    let filename = &args[1];
    let content = fs::read_to_string(filename).expect("Could not read file");
    let word_counts = count_words(&content);
    for (word, count) in word_counts.iter() {
        println!("{}: {}", word, count);
    }
}
fn dummy() {
    cryptify::flow_stmt!();
    let a = 1;
    let b = 2;
    let c = a + b;
    println!("{}", c);
}
fn calc_sum(a: i32, b: i32) -> i32 {
    cryptify::flow_stmt!();
    let c = a + b;
    c
}
fn helloooo() {
    println!("hi");
}
```
## Sortie étendue
```rs
fn main() {
    {
        let _is_dummy_145 = true;
        let mut _dummy_counter = std::hint::black_box(4i32 as i32);
        let _dummy_increment = std::hint::black_box(1i32 as i32);
        let _dummy_upper_bound = std::hint::black_box(53i32 as i32);
        loop {
            if std::hint::black_box(_dummy_counter)
                > std::hint::black_box(_dummy_upper_bound)
            {
                break;
            }
            _dummy_counter = std::hint::black_box(
                std::hint::black_box(_dummy_counter)
                    + std::hint::black_box(_dummy_increment),
            );
        }
    };
    match (&1, &1) {
        (left_val, right_val) => {
            if !(*left_val == *right_val) {
                let kind = ::core::panicking::AssertKind::Eq;
                ::core::panicking::assert_failed(
                    kind,
                    &*left_val,
                    &*right_val,
                    ::core::option::Option::None,
                );
            }
        }
    };
}
fn dummy() {
    {
        let _is_dummy_145 = true;
        let mut _dummy_counter = 4i32;
        let _dummy_upper_bound = 100;
        let _dummy_increment = 3i32;
        loop {
            if _dummy_counter > _dummy_upper_bound {
                break;
            }
            unsafe {
                std::ptr::write_volatile(
                    &mut _dummy_counter,
                    _dummy_counter + _dummy_increment,
                );
            }
        }
    };
    let a = 1;
    let b = 2;
    let c = a + b;
    {
        ::std::io::_print(format_args!("{0}\n", c));
    };
}
fn calc_sum(a: i32, b: i32) -> i32 {
    {
        let _is_dummy_145 = true;
        let mut _dummy_counter = 8i32;
        let _dummy_increment = 3i32;
        let _extra_dummy_var = 4i32;
        let _dummy_upper_bound = 100;
        loop {
            if _dummy_counter > _dummy_upper_bound {
                break;
            }
            unsafe {
                std::ptr::write_volatile(
                    &mut _dummy_counter,
                    _dummy_counter + _dummy_increment,
                );
            }
        }
    };
    let c = a + b;
    c
}
fn helloooo() {
    {
        ::std::io::_print(format_args!("hi\n"));
    };
}
```
# Licence
rust-obfuscator est sous licence MIT - voir le fichier [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) pour plus de détails.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-17

---