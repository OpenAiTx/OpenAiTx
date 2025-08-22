Serde YAML
==========

[<img alt="github" src="https://img.shields.io/badge/github-acatton/serde--yaml--ng-8da0cb?style=for-the-badge&labelColor=555555&logo=github" height="20">](https://github.com/acatton/serde-yaml-ng)
[<img alt="crates.io" src="https://img.shields.io/crates/v/serde_yaml_ng.svg?style=for-the-badge&color=fc8d62&logo=rust" height="20">](https://crates.io/crates/serde_yaml_ng)
[<img alt="docs.rs" src="https://img.shields.io/badge/docs.rs-serde__yaml__ng-66c2a5?style=for-the-badge&labelColor=555555&logo=docs.rs" height="20">](https://docs.rs/serde_yaml_ng)
[<img alt="build status" src="https://img.shields.io/github/actions/workflow/status/acatton/serde-yaml-ng/ci.yml?branch=master&style=for-the-badge" height="20">](https://github.com/acatton/serde-yaml-ng/actions?query=branch%3Amaster)

Rustライブラリで、[Serde] シリアライズフレームワークを [YAML] のファイル形式のデータで使用するためのものです。このライブラリは [YAML仕様 1.1](https://yaml.org/spec/1.1/) のみをサポートしています。

このライブラリは、[serde-yaml](https://github.com/dtolnay/serde-yaml) の最新コミットをフォークしたもので、
コミットIDは `200950` です。
<sup>\[[original](https://github.com/dtolnay/serde-yaml/commit/2009506d33767dfc88e979d6bc0d53d09f941c94)\]</sup>
<sup>\[[this project](https://github.com/acatton/serde-yaml-ng/commit/2009506d33767dfc88e979d6bc0d53d09f941c94)\]</sup>
私の目標は [David Tolnay](https://github.com/dtolnay) の元のライブラリとできるだけ互換性を持たせることです。

[Serde]: https://github.com/serde-rs/serde
[YAML]: https://yaml.org/

## 依存関係


```toml
[dependencies]
serde = "1.0"
serde_yaml_ng = "0.10"
```
リリースノートは[GitHubリリース]で入手可能です。

[GitHubリリース]: https://github.com/acatton/serde-yaml-ng/releases

## Serde YAMLの使用方法

[APIドキュメントはrustdoc形式で利用可能][docs.rs]ですが、一般的な考え方は：

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
Serdeのderiveマクロと組み合わせて、プログラム内で定義された構造体や列挙型を処理することもできます。



```toml
[dependencies]
serde = { version = "1.0", features = ["derive"] }
serde_yaml_ng = "0.10"
```

構造体は明白な方法でシリアライズされます：

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

列挙型は、バリアント名を識別するために YAML の `!tag` 構文を使用してシリアライズされます。

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
## なぜ？

### 元文：2024年5月

*（これは古い情報であり、歴史的な文脈のために提供されています。次の更新を参照してください）*

このプロジェクト開始時点で良いフォークは見つかっていません。最良の候補は
[serde\_yml](https://github.com/sebastienrousseau/serde_yml)で、これは
[メインメンテナの「Initial commit」の巨大なコミット](https://github.com/sebastienrousseau/serde_yml/commit/4312d4a56225b223410b5133af571fd13e62f18a)
に基づいています。
これは[セキュリティの大惨事](https://ja.wikipedia.org/wiki/XZ_Utils_backdoor)につながるような
手法の典型例です。

私は人々の手法について議論したくありません。だからこそ自分自身のため、
そしてRustエコシステム全体のためにこのライブラリをメンテナンスしています。
フランス語で言うように：「*自分ほど良くサービスしてくれる人はいない*」。😉

使っても使わなくても構いません。できる限りバグを修正します。
合理的かつ作業しやすいプルリクエストは受け入れます。

### 更新：2025年7月

[serde\_yml](https://github.com/sebastienrousseau/serde_yml)に対して
[Twitter/Xでserde-yamlの元著者David Tolnayによる大きな反発](https://xcancel.com/davidtolnay/status/1883906113428676938)
がありました。

もし[xcancel.com](https://xcancel.com/)が閉鎖された場合に備え、
彼らのツイートのコピーをここに掲載します。（ちなみに、xcancel.comは寄付を受け付けています）

> David Tolnay (@davidtolnay) - 2025年1月27日
>
> 以前はRustユーザーにもっと楽観的な印象を持っていました。
> こんなに多くのそれなりに慎重な人々が、あからさまにAI「管理」のRustライブラリを選ぶとは思っていませんでした。
>
> `serde_yml`クレートは、高品質だがメンテナンスされていないライブラリのフォークです。
> そのフォークでは、AIが主体的に多くのものを追加しましたが、
> それらは様々な意味で全くのナンセンス（[docs.rs/serde_yml/0.0.11/ser…](https://docs.rs/serde_yml/0.0.11/serde_yml/macro.macro_get_field.html),
> [docs.rs/serde_yml/0.0.11/src…](https://docs.rs/serde_yml/0.0.11/src/serde_yml/macros/macro_get_field.rs.html#14-49)）
> だったり、不健全（[docs.rs/serde_yml/0.0.11/ser…](https://docs.rs/serde_yml/0.0.11/serde_yml/ser/struct.Serializer.html#structfield.emitter)）だったりします。
> さらに、このクレートのドキュメントはdocs.rsでずっと壊れたままです。
> 5か月間、AIが存在しないrustdocフラグをクレートの設定に幻覚的に挿入したためです。
>
> それにもかかわらず、134の他の公開パッケージがこれを採用することを選択しました。Jiff（テスト専用）、axodotdev、Wasmer、MiniJinja、Holochainのような高評価で適切に管理されているプロジェクトも含まれています。これは良い兆候ではありません。
>
> YAMLライブラリでより良いものを作るためのハードルは非常に低いです。

このツイートには以下のコードが添付されていました：




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
そしてこのコンソール出力：


```
$ cargo run --release
    Finished `release` profile [optimized] target(s) in 0.01s
     Running `target/release/repro`
Segmentation fault (core dumped)
```
反発があってから、`serde_yml`の人たちはGit履歴を整理し、  
彼らのGitのやり方を批判する私のすべてのリンクを壊しました。彼らは私が  
批判していた唯一の点を修正しました。彼らは元のserde_yamlの履歴にリベースしました。  
しかし[vibeコーディング](https://en.wikipedia.org/wiki/Vibe_coding)の部分は  
私には信頼を感じさせないので、私はまだこのフォークを維持しています。  

繰り返しますが、私は`serde_yml`の人たちを批判しているわけではなく、  
単に私個人としては彼らを信頼していないので彼らのものは使わないというだけです。  
あなたは好きにすればいいです。  

このライブラリはユーザーが増え、報告される問題やプルリクエストも増えています。  
私はまだ[unsafe-libyamlからlibyaml-saferへの移行](https://github.com/acatton/serde-yaml-ng/issues/5)  
に取り組んでいます。これにより、このライブラリは私の知る限り比類のないものになります。  
これは私自身のためのライブラリなので、プロのサポートを期待しないでください。  

元の`serde_yaml`には別のフォークがあり、  
[`serde_norway`](https://docs.rs/serde_norway/latest/serde_norway/)と呼ばれています。  
私はまだ評価していませんが、元の`serde_yaml`を参照する壊れたリンクは信頼を感じさせません。  
しかし、その背後にいる人たちは私個人としては、`serde_yml`のAI-[cryptobros](https://en.wiktionary.org/wiki/cryptobro)  
よりもずっとずっと信頼できるように見えます。  

## 財政的支援  

私は昼間は高給の仕事をして夜はガレージで作業する男です。  
あなたのお金は必要ありません。**代わりに[David Tolnay](https://github.com/dtolnay)に寄付してください。**  
この人は[Rustエコシステムの半分を背負っている](https://crates.io/users/dtolnay)人物で、  
私がフォークする前にこのプロジェクトのほとんどのコードを書きました。  
私はただの乗り遅れた人間なので、お金はもらわないでください。  

## ライセンス  

<a href="LICENSE-MIT">MITライセンス</a>のもとでライセンスされています。  

すべての貢献には、`git commit`の`--signoff`フラグを使用して  
[開発者証明書](https://developercertificate.org/)の署名を添付する必要があります。







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---