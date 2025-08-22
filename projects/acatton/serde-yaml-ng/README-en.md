Serde YAML
==========

[<img alt="github" src="https://img.shields.io/badge/github-acatton/serde--yaml--ng-8da0cb?style=for-the-badge&labelColor=555555&logo=github" height="20">](https://github.com/acatton/serde-yaml-ng)
[<img alt="crates.io" src="https://img.shields.io/crates/v/serde_yaml_ng.svg?style=for-the-badge&color=fc8d62&logo=rust" height="20">](https://crates.io/crates/serde_yaml_ng)
[<img alt="docs.rs" src="https://img.shields.io/badge/docs.rs-serde__yaml__ng-66c2a5?style=for-the-badge&labelColor=555555&logo=docs.rs" height="20">](https://docs.rs/serde_yaml_ng)
[<img alt="build status" src="https://img.shields.io/github/actions/workflow/status/acatton/serde-yaml-ng/ci.yml?branch=master&style=for-the-badge" height="20">](https://github.com/acatton/serde-yaml-ng/actions?query=branch%3Amaster)

Rust library for using the [Serde] serialization framework with data in [YAML]
file format. This library only follows the [YAML specification 1.1.](https://yaml.org/spec/1.1/).

This library is a fork from the latest commit of [serde-yaml](https://github.com/dtolnay/serde-yaml),
which was `200950`.
<sup>\[[original](https://github.com/dtolnay/serde-yaml/commit/2009506d33767dfc88e979d6bc0d53d09f941c94)\]</sup>
<sup>\[[this project](https://github.com/acatton/serde-yaml-ng/commit/2009506d33767dfc88e979d6bc0d53d09f941c94)\]</sup>
My goal is to be compatible as much as possible with [David Tolnay](https://github.com/dtolnay)'s original library.

[Serde]: https://github.com/serde-rs/serde
[YAML]: https://yaml.org/

## Dependency

```toml
[dependencies]
serde = "1.0"
serde_yaml_ng = "0.10"
```

Release notes are available under [GitHub releases].

[GitHub releases]: https://github.com/acatton/serde-yaml-ng/releases

## Using Serde YAML

[API documentation is available in rustdoc form][docs.rs] but the general idea
is:

[docs.rs]: https://docs.rs/serde_yaml_ng

```rust
use std::collections::BTreeMap;

fn main() -> Result<(), serde_yaml_ng::Error> {
    // You have some type.
    let mut map = BTreeMap::new();
    map.insert("x".to_string(), 1.0);
    map.insert("y".to_string(), 2.0);

    // Serialize it to a YAML string.
    let yaml = serde_yaml_ng::to_string(&map)?;
    assert_eq!(yaml, "x: 1.0\ny: 2.0\n");

    // Deserialize it back to a Rust type.
    let deserialized_map: BTreeMap<String, f64> = serde_yaml_ng::from_str(&yaml)?;
    assert_eq!(map, deserialized_map);
    Ok(())
}
```
It can also be used with Serde's derive macros to handle structs and enums  
defined in your program.


```toml
[dependencies]
serde = { version = "1.0", features = ["derive"] }
serde_yaml_ng = "0.10"
```
Structs serialize in the obvious way:


```rust
use serde::{Serialize, Deserialize};

#[derive(Debug, PartialEq, Serialize, Deserialize)]
struct Point {
    x: f64,
    y: f64,
}

fn main() -> Result<(), serde_yaml_ng::Error> {
    let point = Point { x: 1.0, y: 2.0 };

    let yaml = serde_yaml_ng::to_string(&point)?;
    assert_eq!(yaml, "x: 1.0\ny: 2.0\n");

    let deserialized_point: Point = serde_yaml_ng::from_str(&yaml)?;
    assert_eq!(point, deserialized_point);
    Ok(())
}
```

Enums serialize using YAML's `!tag` syntax to identify the variant name.

```rust
use serde::{Serialize, Deserialize};

#[derive(Serialize, Deserialize, PartialEq, Debug)]
enum Enum {
    Unit,
    Newtype(usize),
    Tuple(usize, usize, usize),
    Struct { x: f64, y: f64 },
}

fn main() -> Result<(), serde_yaml_ng::Error> {
    let yaml = "
        - !Newtype 1
        - !Tuple [0, 0, 0]
        - !Struct {x: 1.0, y: 2.0}
    ";
    let values: Vec<Enum> = serde_yaml_ng::from_str(yaml).unwrap();
    assert_eq!(values[0], Enum::Newtype(1));
    assert_eq!(values[1], Enum::Tuple(0, 0, 0));
    assert_eq!(values[2], Enum::Struct { x: 1.0, y: 2.0 });

    // The last two in YAML's block style instead:
    let yaml = "
        - !Tuple
          - 0
          - 0
          - 0
        - !Struct
          x: 1.0
          y: 2.0
    ";
    let values: Vec<Enum> = serde_yaml_ng::from_str(yaml).unwrap();
    assert_eq!(values[0], Enum::Tuple(0, 0, 0));
    assert_eq!(values[1], Enum::Struct { x: 1.0, y: 2.0 });

    // Variants with no data can be written using !Tag or just the string name.
    let yaml = "
        - Unit  # serialization produces this one
        - !Unit
    ";
    let values: Vec<Enum> = serde_yaml_ng::from_str(yaml).unwrap();
    assert_eq!(values[0], Enum::Unit);
    assert_eq!(values[1], Enum::Unit);

    Ok(())
}
```

## Why?

### Original: May 2024

*(This is out of date, provided for historical context, see the next update)*

I haven't found any good fork as of the start of this project. The best candidate was
[serde\_yml](https://github.com/sebastienrousseau/serde_yml) which is based on
[a giant "Initial commit" from the main maintainer](https://github.com/sebastienrousseau/serde_yml/commit/4312d4a56225b223410b5133af571fd13e62f18a).
This is the type of practices which leads to [security disasters](https://en.wikipedia.org/wiki/XZ_Utils_backdoor).

I don't want to fight with people about their practices, that's why I'm
maintaining this library for myself, and for the rust ecosystem as a whole.
As we say in French: "*You are never better served than by yourself*". 😉

Use it, don't use it, I don't care. I'll try to fix as many bugs as I can.
I'll accept pull requests if they're reasonable or easy to work with.

### Update: July 2025

There was a huge backlash against
[serde\_yml](https://github.com/sebastienrousseau/serde\_yml) on [Twitter/X by
David Tolnay, the original author of serde-yaml](https://xcancel.com/davidtolnay/status/1883906113428676938).

A copy of their tweet is provided here in case
[xcancel.com](https://xcancel.com/) gets shut down. (By the way, xcancel.com accepts donations)

> David Tolnay (@davidtolnay) - Jan 27 2025
>
> Not long ago, I used to have a more optimistic impression of Rust users. I
> would not have guessed that so many otherwise-judicious people would go for
> blatantly AI-"maintained" Rust libraries.
>
> The `serde_yml` crate is a fork of a high-quality but unmaintained library.
> In the fork, the AI has taken initiative to add a big heap of stuff that is
> variously complete nonsense ([docs.rs/serde_yml/0.0.11/ser…](https://docs.rs/serde_yml/0.0.11/serde_yml/macro.macro_get_field.html),
> [docs.rs/serde_yml/0.0.11/src…](https://docs.rs/serde_yml/0.0.11/src/serde_yml/macros/macro_get_field.rs.html#14-49))
> or unsound ([docs.rs/serde_yml/0.0.11/ser…](https://docs.rs/serde_yml/0.0.11/serde_yml/ser/struct.Serializer.html#structfield.emitter)). On
> top of this, the crate's documentation has been broken in docs.rs for the last
> 5 months because AI hallucinated a nonexistent rustdoc flag into the crate's
> configuration.
>
> And yet 134 other published packages have chosen to adopt this? Including
> high-profile competently maintained projects like Jiff (for tests only),
> axodotdev, Wasmer, MiniJinja, and Holochain. This does not bode well.
>
> The bar for someone to do better at a YAML library is so low.

Attached to this tweet was the following code:

```rust
fn main() {
	let a = ".".repeat(100);
	let emitter = {
		let mut buf = [0u8; 100];
		serde_yml::Serializer::new(&mut buf.as_mut_slice()).emitter
	};
	let s = ".".repeat(100);
	emitter.into_inner().write_all(&[1u8; 100]).unwrap();
	println!("{}\n{}", a, s);
}
```

And this console output:

```
$ cargo run --release
    Finished `release` profile [optimized] target(s) in 0.01s
     Running `target/release/repro`
Segmentation fault (core dumped)
```
Since the backlash, the `serde_yml` folks cleaned up their git history and  
broke all my links criticizing their way of doing git. They fixed the one  
thing I was criticizing them for. They rebased on the original serde_yaml  
history. However the [vibe coding](https://en.wikipedia.org/wiki/Vibe_coding)  
part doesn't inspire trust on my side, so I'm still maintaining this fork.  

Again, I'm not criticizing the `serde_yml` folks, I'm just saying that I,  
personally, won't use their stuff because I, personally, don't trust them. You  
do whatever you want.  

This library has seen more and more users, and more and more issues reported as  
well as pull requests. I'm still working on [migrating away from unsafe-libyaml  
to libyaml-safer](https://github.com/acatton/serde-yaml-ng/issues/5). This will  
make this library unrivaled AFAIK. This is a library for myself, don't expect  
professional support please.  

There is another fork of the original `serde_yaml` now, called  
[`serde_norway`](https://docs.rs/serde_norway/latest/serde_norway/). I haven't  
evaluated it, the broken links still referencing the original `serde_yaml`  
don't inspire trust. But the people behind it look much much much more  
trustworthy, to me, personally, than the  
AI-[cryptobros](https://en.wiktionary.org/wiki/cryptobro) behind `serde_yml`.  

## Financial Support  

I'm a guy working out of his garage at night with a well-paid job during the day. I  
do not need your money. **Please! Instead, give money to  
[David Tolnay](https://github.com/dtolnay).** This guy  
[carries half of the Rust ecosystem on his shoulders](https://crates.io/users/dtolnay),  
and wrote most of the code for this project before I forked it. I'm just a  
loser who jumped on the train, don't give me any money.  

## License  

Licensed <a href="LICENSE-MIT">MIT license</a>.  

Any contribution must be accompanied with a signature of the  
[Developer Certificate of Origin](https://developercertificate.org/),  
by using the `--signoff` flag on `git commit`.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---