# vmprotect ![crates.io](https://img.shields.io/crates/v/vmprotect.svg)

SDK VMProtect en desarrollo para rust

## Funciones básicas de VMProtect

### Atributo `protected`

Necesitas agregar [este script](https://raw.githubusercontent.com/CertainLach/vmprotect/master/./script.lua) al proyecto vmprotect para este atributo

Sintaxis:

```rust
#[protected(TYPE[, lock])]
fn some_fn() { ... }
```

- TIPO: Tipo de protección
- [, bloqueo]: Requiere licencia para que esta función funcione.

Ejemplo:

```rust
#[protected(virtualize)]
fn stringify<T: Display>(value: T) -> String {
    format!("{}", value)
}
```

### Macro `protected!` para código

Sintaxis:

```rust
use vmprotect::protected;

protected!(TYPE[, lock] "NAME"; { /*CODE*/ })
```
- NOMBRE: Qué nombre se mostrará en la interfaz gráfica de VMProtect  
- TIPO: Tipo de protección (mutar/virtualizar/ultra según la documentación de VMProtect)  
- [, bloqueo]: Solo para virtualizar/ultra, requiere activación de licencia para que esta función funcione  
- CÓDIGO: Tu código va aquí  

El bloque de código protegido funciona como cualquier otro bloque de Rust, es decir:  


```rust
use vmprotect::protected;

// Before protection
let a = {2+3};
// After protection
let a = protected!(virtualize "Addiction"; { 2 + 3 });
```
Ejemplo:


```rust
fn main() {
    println!("{} + {} = {}", a, b, protected!(ultra "Adding"; {
        a + b
    }));
}
```

### Macro `protected!` para textos

Sintaxis:

```rust
use vmprotect::protected;

protected!(TYPE "TEXT")
```

- TYPE: Tipo de texto, valores posibles: cstr (para cadenas c normales)/cwstr (para cadenas c uint16_t (usadas por ejemplo en Windows))
- TEXT: Su texto, debe ser compatible con el tipo de texto seleccionado

Esta macro devuelve una cadena, que puede ser transformada en una normal. Esta cadena se libera cuando se descarta, la implementación está ubicada en `vmprotect::strings::{encrypted_a::EncryptedStringA, encrypted_w::EncryptedStringW}`

```rust
use vmprotect::protected;

// Before protection
let a = "Hello, world!";
// After protection
let a = protected!(cstr "Hello, world!");
// Also for wide-strings:
let a = protected!(cwstr "Привет, мир!");
```
Ejemplo:


```rust
use vmprotect::protected;

fn main() {
    println!("Hello, {:?}!", protected!(A; "%Username%").into() as String);
}
```

## Licenciamiento

Sección TODO, consulte la documentación por ahora

### HWID

Ejemplo:

```rust
println!("Your hwid is \"{}\"", vmprotect::licensing::get_hwid().to_str().unwrap());
```

## Problemas conocidos

### MacOS: No hay suficiente espacio para el nuevo segmento en el encabezado del archivo

Se puede solucionar añadiendo `-C link-arg=-Wl,-headerpad,0x500` a los argumentos de rustc

Para cargo:

```rs
export RUSTFLAGS="-C link-arg=-Wl,-headerpad,0x500"
```
(Basado en <http://vmpsoft.com/forum/viewtopic.php?f=2&t=6837&start=15#p10527>)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-26

---