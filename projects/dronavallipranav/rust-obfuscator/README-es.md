# Rust-Obfuscator

`rust-obfuscator` es un conjunto de herramientas diseñadas para ofuscar automáticamente código fuente Rust insertando macros procedurales o proporcionando (opcionalmente) la ofuscación directamente en el código fuente. Para una ofuscación más detallada también se proporciona una biblioteca de macros procedurales [cryptify](https://crates.io/crates/cryptify).

## Actualmente Soportado
1. cifrado de literales de cadena
2. ofuscación de flujo de control
3. ofuscación de flujo de control (código fuente)
4. renombrado de variables (código fuente)

## Características

- **Cifrado de Cadenas**: Cifra automáticamente literales de cadena asignados a variables locales en tiempo de compilación.
    - También puede usarse para cadenas formateadas, pero actualmente requiere colocación manual
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **Ofuscación del Flujo de Control**: Introduce bucles dummy de compilación y variables aleatorias.  
- **Ofuscación Personalizable**: Ofrece flexibilidad para habilitar o deshabilitar funciones específicas de ofuscación según sus requisitos.  
- **Renombrado de Variables**: Ofuscación del código fuente directamente, si desea distribuir el código o simplemente quiere que su código se vea peor.  
- NOTA: el renombrado de variables no está completamente funcional desde la versión 1.1.1, se está trabajando en soporte completo ya que algunos casos aún no están cubiertos. Aún puede usar la herramienta y corregir los errores de compilación correspondientes.  

## Instalación  

Agregue `cryptify` a su `Cargo.toml` como una dependencia:

```toml
[dependencies]
cryptify = "3.2.1"
```

Para instalar `rust-obfuscator`, clona el repositorio y construye la herramienta usando Cargo desde la raíz:
```
cargo build --release --bin rust-obfuscator
```
El binario se puede encontrar entonces en /target/release, puedes copiarlo a la raíz del proyecto así
```
cp ./target/release/rust-obfuscator .
```

# Uso
Establezca la variable de entorno **CRYPTIFY_KEY** para una encriptación personalizada, de lo contrario, se utiliza la clave fija definida
- Agregue al código fuente que desea modificar
```rs
use cryptify;
```
El binario puede usarse en un archivo o en un directorio. Si se proporciona un directorio, solo modificará los archivos fuente de Rust dentro de ese directorio, no en subdirectorios.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- Todo el código ofuscado estará bajo el directorio **obfuscated_code** que se crea desde el directorio donde se ejecutó la herramienta.
- **Se recomienda usar un formateador de Rust con el código ofuscado ya que syn modifica naturalmente la estructura y se escribirá en el archivo como una sola línea**

## Opciones de bandera
- --no_string: Desactiva la ofuscación de cadenas.
- --no_flow: Desactiva la ofuscación del flujo de control.
- --disable_macro: Usa manipulación directa del código fuente para la ofuscación del flujo en lugar de macros procedurales.
- --var: Habilita la ofuscación del código fuente mediante renombrado de variables.

### Ejemplo de uso con bandera
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(desactiva la ofuscación de flujo)

# Entrada
-ejecutar la herramienta sin configuración
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
# Salida
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
## Salida Ampliada
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
# Licencia
rust-obfuscator está licenciado bajo la Licencia MIT - consulte el archivo [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) para más detalles.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-17

---