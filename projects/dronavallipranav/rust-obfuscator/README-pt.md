
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rust-Obfuscator

`rust-obfuscator` é um conjunto de ferramentas projetadas para ofuscar automaticamente o código-fonte Rust inserindo macros procedurais ou (opcionalmente) fornecendo a ofuscação diretamente no código-fonte. Para uma ofuscação mais detalhada, uma biblioteca de macro procedural [cryptify](https://crates.io/crates/cryptify) também é fornecida.

## Atualmente Suportado
1. criptografia de literais de string
2. ofuscação de fluxo de controle
3. ofuscação de fluxo de controle (código-fonte)
4. renomeação de variáveis (código-fonte)

## Funcionalidades

- **Criptografia de Strings**: Criptografa automaticamente literais de strings atribuídas a variáveis locais durante a compilação.
    - Também pode ser usada para strings formatadas, mas atualmente requer colocação manual
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **Obfuscação do Fluxo de Controle**: Introduz laços fictícios de compilação e variáveis aleatórias.
- **Obfuscação Personalizável**: Oferece flexibilidade para ativar ou desativar recursos específicos de ofuscação conforme suas necessidades.
- **Renomeação de Variáveis**: Ofuscação do código-fonte diretamente, caso queira distribuir o código ou apenas dificultar sua leitura.
- NOTA: a renomeação de variáveis não está totalmente funcional na versão 1.1.1, trabalhando para suporte total, pois alguns casos ainda não são cobertos. Ainda é possível usar a ferramenta e corrigir os erros de compilador apropriados.

## Instalação

Adicione `cryptify` como dependência no seu `Cargo.toml`:

```toml
[dependencies]
cryptify = "3.2.1"
```

Para instalar o `rust-obfuscator`, clone o repositório e construa a ferramenta usando o Cargo a partir do diretório raiz:
```
cargo build --release --bin rust-obfuscator
```
O binário pode então ser encontrado em /target/release, você pode copiá-lo para a raiz do projeto da seguinte forma
```
cp ./target/release/rust-obfuscator .
```

# Uso
Defina a variável de ambiente **CRYPTIFY_KEY** para uma criptografia personalizada, caso contrário, será usado o valor padrão definido como chave fixa
- Adicione ao código-fonte que deseja modificar
```rs
use cryptify;
```
O binário pode ser usado tanto em um arquivo quanto em um diretório. Se fornecido com um diretório, ele modificará apenas arquivos fonte Rust dentro desse diretório, não em subdiretórios.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- Todo o código ofuscado estará sob o diretório **obfuscated_code**, que é criado a partir do diretório onde a ferramenta foi executada.
- **Recomenda-se usar um Formatador Rust com o código ofuscado, pois o syn naturalmente modifica a estrutura e ele será escrito no arquivo como uma única linha**

## Flags de Opção
- --no_string: Desativa a ofuscação de strings.
- --no_flow: Desativa a ofuscação do fluxo de controle.
- --disable_macro: Usa manipulação direta do código-fonte para ofuscação de fluxo ao invés de macros procedurais.
- --var: Habilita a ofuscação de renomeação de variáveis no código-fonte.

### Exemplo de uso com flag
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(desativa a ofuscação de fluxo)

# Entrada
-executando a ferramenta sem configuração
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
# Saída
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
## Saída Expandida
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
# Licença
rust-obfuscator está licenciado sob a Licença MIT - veja o arquivo [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) para mais detalhes.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---