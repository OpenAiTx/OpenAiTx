Serde YAML
==========

[<img alt="github" src="https://img.shields.io/badge/github-acatton/serde--yaml--ng-8da0cb?style=for-the-badge&labelColor=555555&logo=github" height="20">](https://github.com/acatton/serde-yaml-ng)
[<img alt="crates.io" src="https://img.shields.io/crates/v/serde_yaml_ng.svg?style=for-the-badge&color=fc8d62&logo=rust" height="20">](https://crates.io/crates/serde_yaml_ng)
[<img alt="docs.rs" src="https://img.shields.io/badge/docs.rs-serde__yaml__ng-66c2a5?style=for-the-badge&labelColor=555555&logo=docs.rs" height="20">](https://docs.rs/serde_yaml_ng)
[<img alt="build status" src="https://img.shields.io/github/actions/workflow/status/acatton/serde-yaml-ng/ci.yml?branch=master&style=for-the-badge" height="20">](https://github.com/acatton/serde-yaml-ng/actions?query=branch%3Amaster)

Bibliothèque Rust pour utiliser le cadre de sérialisation [Serde] avec des données au format de fichier [YAML]. Cette bibliothèque suit uniquement la [spécification YAML 1.1.](https://yaml.org/spec/1.1/).

Cette bibliothèque est un fork du dernier commit de [serde-yaml](https://github.com/dtolnay/serde-yaml),
qui était `200950`.
<sup>\[[original](https://github.com/dtolnay/serde-yaml/commit/2009506d33767dfc88e979d6bc0d53d09f941c94)\]</sup>
<sup>\[[ce projet](https://github.com/acatton/serde-yaml-ng/commit/2009506d33767dfc88e979d6bc0d53d09f941c94)\]</sup>
Mon objectif est d’être compatible autant que possible avec la bibliothèque originale de [David Tolnay](https://github.com/dtolnay).

[Serde]: https://github.com/serde-rs/serde
[YAML]: https://yaml.org/

## Dépendance


```toml
[dependencies]
serde = "1.0"
serde_yaml_ng = "0.10"
```

Les notes de version sont disponibles sous [GitHub releases].

[GitHub releases]: https://github.com/acatton/serde-yaml-ng/releases

## Utilisation de Serde YAML

[La documentation API est disponible au format rustdoc][docs.rs] mais l'idée générale
est :

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

Il peut également être utilisé avec les macros derive de Serde pour gérer les structs et enums
définis dans votre programme.

```toml
[dependencies]
serde = { version = "1.0", features = ["derive"] }
serde_yaml_ng = "0.10"
```

Les structures se sérialisent de manière évidente :

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

Les énumérations se sérialisent en utilisant la syntaxe `!tag` de YAML pour identifier le nom de la variante.

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
## Pourquoi ?

### Original : mai 2024

*(Ceci est obsolète, fourni pour le contexte historique, voir la prochaine mise à jour)*

Je n’ai pas trouvé de bon fork au début de ce projet. Le meilleur candidat était
[serde\_yml](https://github.com/sebastienrousseau/serde_yml) qui est basé sur
[un énorme « commit initial » du mainteneur principal](https://github.com/sebastienrousseau/serde_yml/commit/4312d4a56225b223410b5133af571fd13e62f18a).
Ce sont ce type de pratiques qui conduisent à des [désastres de sécurité](https://fr.wikipedia.org/wiki/Backdoor_dans_XZ_Utils).

Je ne veux pas me battre avec les gens à propos de leurs pratiques, c’est pourquoi je
maintiens cette bibliothèque pour moi-même, et pour l’écosystème Rust dans son ensemble.
Comme on dit en français : « *On n’est jamais mieux servi que par soi-même* ». 😉

Utilisez-la, n’utilisez pas, je m’en fiche. Je vais essayer de corriger autant de bugs que possible.
J’accepterai les pull requests si elles sont raisonnables ou faciles à gérer.

### Mise à jour : juillet 2025

Il y a eu un énorme retour de bâton contre
[serde\_yml](https://github.com/sebastienrousseau/serde_yml) sur [Twitter/X par
David Tolnay, l’auteur original de serde-yaml](https://xcancel.com/davidtolnay/status/1883906113428676938).

Une copie de leur tweet est fournie ici au cas où
[xcancel.com](https://xcancel.com/) serait fermé. (Au fait, xcancel.com accepte les dons)

> David Tolnay (@davidtolnay) - 27 janv. 2025
>
> Il n’y a pas longtemps, j’avais une impression plus optimiste des utilisateurs de Rust. Je
> n’aurais pas imaginé que tant de personnes par ailleurs judicieuses choisiraient des
> bibliothèques Rust manifestement « maintenues » par une IA.
>
> Le crate `serde_yml` est un fork d’une bibliothèque de haute qualité mais non maintenue.
> Dans ce fork, l’IA a pris l’initiative d’ajouter une grande quantité de choses qui sont
> tantôt un non-sens complet ([docs.rs/serde_yml/0.0.11/ser…](https://docs.rs/serde_yml/0.0.11/serde_yml/macro.macro_get_field.html),
> [docs.rs/serde_yml/0.0.11/src…](https://docs.rs/serde_yml/0.0.11/src/serde_yml/macros/macro_get_field.rs.html#14-49))
> ou non sûres ([docs.rs/serde_yml/0.0.11/ser…](https://docs.rs/serde_yml/0.0.11/serde_yml/ser/struct.Serializer.html#structfield.emitter)). En
> plus de cela, la documentation du crate est cassée sur docs.rs depuis la dernière

> 5 mois parce que l'IA a halluciné un drapeau rustdoc inexistant dans la configuration du crate.
>
> Et pourtant, 134 autres paquets publiés ont choisi d'adopter cela ? Y compris des projets bien maintenus et de haut niveau comme Jiff (uniquement pour les tests),
> axodotdev, Wasmer, MiniJinja, et Holochain. Cela ne présage rien de bon.
>
> Le seuil pour faire mieux qu'une bibliothèque YAML est tellement bas.

Attaché à ce tweet se trouvait le code suivant :



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

Et cette sortie de console :

```
$ cargo run --release
    Finished `release` profile [optimized] target(s) in 0.01s
     Running `target/release/repro`
Segmentation fault (core dumped)
```
Depuis la controverse, les gens de `serde_yml` ont nettoyé leur historique git et
ont cassé tous mes liens critiquant leur manière de gérer git. Ils ont corrigé la seule
chose que je leur reprochais. Ils ont rebasé sur l'historique original de serde_yaml.
Cependant, la partie [vibe coding](https://fr.wikipedia.org/wiki/Vibe_coding)
n'inspire pas confiance de mon côté, donc je maintiens toujours ce fork.

Encore une fois, je ne critique pas les gens de `serde_yml`, je dis juste que moi,
personnellement, je n'utiliserai pas leurs outils parce que, personnellement, je ne leur fais pas confiance.
Faites comme vous voulez.

Cette bibliothèque a vu de plus en plus d'utilisateurs, ainsi que de plus en plus de problèmes signalés
et de demandes de tirage. Je travaille toujours sur [la migration d'unsafe-libyaml
vers libyaml-safer](https://github.com/acatton/serde-yaml-ng/issues/5). Cela
rendra cette bibliothèque sans égal à ma connaissance. C'est une bibliothèque pour moi-même, ne comptez pas
sur un support professionnel s'il vous plaît.

Il existe un autre fork de l'original `serde_yaml` maintenant, appelé
[`serde_norway`](https://docs.rs/serde_norway/latest/serde_norway/). Je ne l'ai pas
évalué, les liens cassés qui référencent toujours l'original `serde_yaml`
n'inspirent pas confiance. Mais les personnes derrière semblent bien plus
fiables, à mes yeux, personnellement, que les
AI-[cryptobros](https://fr.wiktionary.org/wiki/cryptobro) derrière `serde_yml`.

## Support financier

Je suis un gars qui travaille dans son garage la nuit avec un travail bien payé le jour.
Je n'ai pas besoin de votre argent. **S'il vous plaît ! Donnez plutôt de l'argent à
[David Tolnay](https://github.com/dtolnay).** Ce gars
[porte la moitié de l'écosystème Rust sur ses épaules](https://crates.io/users/dtolnay),
et a écrit la plupart du code pour ce projet avant que je ne le fork. Je ne suis qu'un
perdant qui a sauté dans le train, ne me donnez pas d'argent.

## Licence

Sous licence <a href="LICENSE-MIT">MIT</a>.

Toute contribution doit être accompagnée d'une signature du
[Certificat d'Origine du Développeur](https://developercertificate.org/),
en utilisant l'option `--signoff` sur `git commit`.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---