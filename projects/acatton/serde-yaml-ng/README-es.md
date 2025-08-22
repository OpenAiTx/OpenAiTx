Serde YAML
==========

[<img alt="github" src="https://img.shields.io/badge/github-acatton/serde--yaml--ng-8da0cb?style=for-the-badge&labelColor=555555&logo=github" height="20">](https://github.com/acatton/serde-yaml-ng)
[<img alt="crates.io" src="https://img.shields.io/crates/v/serde_yaml_ng.svg?style=for-the-badge&color=fc8d62&logo=rust" height="20">](https://crates.io/crates/serde_yaml_ng)
[<img alt="docs.rs" src="https://img.shields.io/badge/docs.rs-serde__yaml__ng-66c2a5?style=for-the-badge&labelColor=555555&logo=docs.rs" height="20">](https://docs.rs/serde_yaml_ng)
[<img alt="build status" src="https://img.shields.io/github/actions/workflow/status/acatton/serde-yaml-ng/ci.yml?branch=master&style=for-the-badge" height="20">](https://github.com/acatton/serde-yaml-ng/actions?query=branch%3Amaster)

Biblioteca Rust para usar el framework de serialización [Serde] con datos en formato de archivo [YAML]. Esta biblioteca solo sigue la [especificación YAML 1.1.](https://yaml.org/spec/1.1/).

Esta biblioteca es un fork del último commit de [serde-yaml](https://github.com/dtolnay/serde-yaml),
que fue `200950`.
<sup>\[[original](https://github.com/dtolnay/serde-yaml/commit/2009506d33767dfc88e979d6bc0d53d09f941c94)\]</sup>
<sup>\[[este proyecto](https://github.com/acatton/serde-yaml-ng/commit/2009506d33767dfc88e979d6bc0d53d09f941c94)\]</sup>
Mi objetivo es ser compatible tanto como sea posible con la biblioteca original de [David Tolnay](https://github.com/dtolnay).

[Serde]: https://github.com/serde-rs/serde
[YAML]: https://yaml.org/

## Dependencia


```toml
[dependencies]
serde = "1.0"
serde_yaml_ng = "0.10"
```

Las notas de la versión están disponibles en [GitHub releases].

[GitHub releases]: https://github.com/acatton/serde-yaml-ng/releases

## Uso de Serde YAML

[La documentación API está disponible en formato rustdoc][docs.rs] pero la idea general
es:

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
También se puede usar con las macros derive de Serde para manejar structs y enums  
definidos en su programa.


```toml
[dependencies]
serde = { version = "1.0", features = ["derive"] }
serde_yaml_ng = "0.10"
```

Las estructuras se serializan de la manera obvia:

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

Los enums se serializan usando la sintaxis `!tag` de YAML para identificar el nombre de la variante.

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

## ¿Por qué?

### Original: Mayo 2024

*(Esto está desactualizado, se proporciona para contexto histórico, vea la siguiente actualización)*

No he encontrado ningún buen fork desde el inicio de este proyecto. El mejor candidato fue
[serde\_yml](https://github.com/sebastienrousseau/serde_yml) que está basado en
[un enorme "commit inicial" del mantenedor principal](https://github.com/sebastienrousseau/serde_yml/commit/4312d4a56225b223410b5133af571fd13e62f18a).
Este tipo de prácticas lleva a [desastres de seguridad](https://es.wikipedia.org/wiki/XZ_Utils_backdoor).

No quiero pelear con la gente por sus prácticas, por eso estoy
mantenimiento esta biblioteca para mí mismo y para el ecosistema de Rust en general.
Como decimos en francés: "*Nunca estás mejor servido que por ti mismo*". 😉

Úsalo, no lo uses, no me importa. Trataré de arreglar tantos errores como pueda.
Aceptaré pull requests si son razonables o fáciles de manejar.

### Actualización: Julio 2025

Hubo una gran reacción contra
[serde\_yml](https://github.com/sebastienrousseau/serde\_yml) en [Twitter/X por
David Tolnay, el autor original de serde-yaml](https://xcancel.com/davidtolnay/status/1883906113428676938).

Se proporciona una copia de su tuit aquí en caso de que
[xcancel.com](https://xcancel.com/) sea cerrado. (Por cierto, xcancel.com acepta donaciones)

> David Tolnay (@davidtolnay) - 27 de ene. de 2025
>
> No hace mucho, solía tener una impresión más optimista de los usuarios de Rust. No
> habría adivinado que tantas personas por lo demás juiciosas optarían por
> bibliotecas Rust claramente "mantenidas" por IA.
>
> El crate `serde_yml` es un fork de una biblioteca de alta calidad pero sin mantenimiento.
> En el fork, la IA tomó la iniciativa de añadir una gran cantidad de cosas que son
> en varios casos un completo sinsentido ([docs.rs/serde_yml/0.0.11/ser…](https://docs.rs/serde_yml/0.0.11/serde_yml/macro.macro_get_field.html),
> [docs.rs/serde_yml/0.0.11/src…](https://docs.rs/serde_yml/0.0.11/src/serde_yml/macros/macro_get_field.rs.html#14-49))
> o inseguras ([docs.rs/serde_yml/0.0.11/ser…](https://docs.rs/serde_yml/0.0.11/serde_yml/ser/struct.Serializer.html#structfield.emitter)). Además,
> la documentación del crate ha estado rota en docs.rs durante el último
> 5 meses porque la IA alucinó un flag inexistente de rustdoc en la configuración del crate.
>
> ¿Y aun así 134 otros paquetes publicados han elegido adoptar esto? Incluyendo
> proyectos de alto perfil y mantenidos competentemente como Jiff (solo para pruebas),
> axodotdev, Wasmer, MiniJinja y Holochain. Esto no es una buena señal.
>
> El nivel para que alguien haga algo mejor en una biblioteca YAML es muy bajo.

Adjunto a este tweet estaba el siguiente código:


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

Y esta salida de consola:

```
$ cargo run --release
    Finished `release` profile [optimized] target(s) in 0.01s
     Running `target/release/repro`
Segmentation fault (core dumped)
```
Desde la controversia, los de `serde_yml` limpiaron su historial de git y
rompieron todos mis enlaces criticando su forma de usar git. Arreglaron la única
cosa por la que los estaba criticando. Hicieron un rebase sobre el historial original de serde_yaml.
Sin embargo, la parte de [vibe coding](https://en.wikipedia.org/wiki/Vibe_coding)
no inspira confianza de mi parte, así que sigo manteniendo este fork.

De nuevo, no estoy criticando a los de `serde_yml`, solo digo que yo,
personalmente, no usaré sus cosas porque, personalmente, no confío en ellos. Tú
haz lo que quieras.

Esta biblioteca ha visto cada vez más usuarios, y cada vez más problemas reportados así
como solicitudes de extracción. Sigo trabajando en [migrar de unsafe-libyaml
a libyaml-safer](https://github.com/acatton/serde-yaml-ng/issues/5). Esto
hará que esta biblioteca sea insuperable que yo sepa. Esta es una biblioteca para mí mismo, no esperes
soporte profesional por favor.

Ahora hay otro fork del `serde_yaml` original, llamado
[`serde_norway`](https://docs.rs/serde_norway/latest/serde_norway/). No lo he
evaluado, los enlaces rotos que aún hacen referencia al `serde_yaml` original
no inspiran confianza. Pero las personas detrás parecen mucho, mucho, mucho más
confiables, para mí, personalmente, que los
AI-[cryptobros](https://en.wiktionary.org/wiki/cryptobro) detrás de `serde_yml`.

## Apoyo financiero

Soy un tipo que trabaja desde su garaje por la noche con un trabajo bien pagado durante el día. No
necesito tu dinero. **¡Por favor! En cambio, da dinero a
[David Tolnay](https://github.com/dtolnay).** Este tipo
[carga con la mitad del ecosistema Rust sobre sus hombros](https://crates.io/users/dtolnay),
y escribió la mayor parte del código para este proyecto antes de que yo hiciera el fork. Yo solo soy un
perdedor que se subió al tren, no me des dinero.

## Licencia

Licenciado bajo <a href="LICENSE-MIT">licencia MIT</a>.

Cualquier contribución debe estar acompañada de una firma del
[Certificado de Origen del Desarrollador](https://developercertificate.org/),
usando la bandera `--signoff` en `git commit`.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---