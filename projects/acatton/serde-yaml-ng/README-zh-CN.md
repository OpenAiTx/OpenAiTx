Serde YAML
==========

[<img alt="github" src="https://img.shields.io/badge/github-acatton/serde--yaml--ng-8da0cb?style=for-the-badge&labelColor=555555&logo=github" height="20">](https://github.com/acatton/serde-yaml-ng)
[<img alt="crates.io" src="https://img.shields.io/crates/v/serde_yaml_ng.svg?style=for-the-badge&color=fc8d62&logo=rust" height="20">](https://crates.io/crates/serde_yaml_ng)
[<img alt="docs.rs" src="https://img.shields.io/badge/docs.rs-serde__yaml__ng-66c2a5?style=for-the-badge&labelColor=555555&logo=docs.rs" height="20">](https://docs.rs/serde_yaml_ng)
[<img alt="build status" src="https://img.shields.io/github/actions/workflow/status/acatton/serde-yaml-ng/ci.yml?branch=master&style=for-the-badge" height="20">](https://github.com/acatton/serde-yaml-ng/actions?query=branch%3Amaster)

用于在[YAML]文件格式中使用[Serde]序列化框架的Rust库。该库仅遵循[YAML规范1.1](https://yaml.org/spec/1.1/)。

该库是从[serde-yaml](https://github.com/dtolnay/serde-yaml)的最新提交`200950`分叉而来。
<sup>\[[原始](https://github.com/dtolnay/serde-yaml/commit/2009506d33767dfc88e979d6bc0d53d09f941c94)\]</sup>
<sup>\[[本项目](https://github.com/acatton/serde-yaml-ng/commit/2009506d33767dfc88e979d6bc0d53d09f941c94)\]</sup>
我的目标是尽可能兼容[David Tolnay](https://github.com/dtolnay)的原始库。

[Serde]: https://github.com/serde-rs/serde
[YAML]: https://yaml.org/

## 依赖



```toml
[dependencies]
serde = "1.0"
serde_yaml_ng = "0.10"
```

发行说明可在[GitHub 发行版]中查看。

[GitHub 发行版]: https://github.com/acatton/serde-yaml-ng/releases

## 使用 Serde YAML

[API 文档以 rustdoc 形式提供][docs.rs]，但总体思路是：

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
它也可以与Serde的派生宏一起使用，以处理程序中定义的结构体和枚举。



```toml
[dependencies]
serde = { version = "1.0", features = ["derive"] }
serde_yaml_ng = "0.10"
```
结构体以显而易见的方式序列化：


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

枚举使用 YAML 的 `!tag` 语法序列化，以标识变体名称。

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
## 为什么？

### 原文：2024年5月

*（此内容已过时，仅供历史参考，详见下一次更新）*

截至本项目启动时，我还没找到任何好的分支。最有潜力的是
[serde_yml](https://github.com/sebastienrousseau/serde_yml)，它基于
[主维护者的一个庞大的“初始提交”](https://github.com/sebastienrousseau/serde_yml/commit/4312d4a56225b223410b5133af571fd13e62f18a)。
这正是会导致[安全灾难](https://en.wikipedia.org/wiki/XZ_Utils_backdoor)的做法。

我不想和别人争论他们的做法，所以我
为自己，也为整个 Rust 生态系统维护这个库。
正如我们法语所说：“*自己动手，丰衣足食*”。😉

用就用，不用随意，我无所谓。我会尽力修复尽可能多的错误。
如果拉取请求合理或容易处理，我会接受。

### 更新：2025年7月

针对
[serde_yml](https://github.com/sebastienrousseau/serde_yml)，
Rust 原始作者 David Tolnay 在 [Twitter/X 上](https://xcancel.com/davidtolnay/status/1883906113428676938)引发了巨大反弹。

这里备份了他们的推文，以防
[xcancel.com](https://xcancel.com/) 被关闭。（顺便提一下，xcancel.com 接受捐赠）

> David Tolnay (@davidtolnay) - 2025年1月27日
>
> 不久前，我对 Rust 用户的印象还比较乐观。
> 我没想到这么多本来理智的人会去使用明显由 AI “维护”的 Rust 库。
>
> `serde_yml` 这个包是一个高质量但无人维护库的分支。
> 在这个分支中，AI 主动添加了大量各种无意义的内容（[docs.rs/serde_yml/0.0.11/ser…](https://docs.rs/serde_yml/0.0.11/serde_yml/macro.macro_get_field.html),
> [docs.rs/serde_yml/0.0.11/src…](https://docs.rs/serde_yml/0.0.11/src/serde_yml/macros/macro_get_field.rs.html#14-49)）
> 或者不安全的内容（[docs.rs/serde_yml/0.0.11/ser…](https://docs.rs/serde_yml/0.0.11/serde_yml/ser/struct.Serializer.html#structfield.emitter)）。
> 此外，这个包的文档在 docs.rs 上已经损坏了很长时间，导致最后



> 因为 AI 在该 crate 的配置中虚构了一个不存在的 rustdoc 标志，导致延迟了 5 个月。
>
> 然而，还有 134 个其他已发布的软件包选择采用这个？其中包括高知名度且维护得当的项目，如 Jiff（仅用于测试）、axodotdev、Wasmer、MiniJinja 和 Holochain。这情况不容乐观。
>
> 对于有人能做出更好的 YAML 库，门槛实在太低了。

这条推文附带的代码如下：




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

以及此控制台输出：

```
$ cargo run --release
    Finished `release` profile [optimized] target(s) in 0.01s
     Running `target/release/repro`
Segmentation fault (core dumped)
```
自从引发争议以来，`serde_yml` 团队清理了他们的 git 历史记录，  
并且断开了我所有批评他们 git 使用方式的链接。他们修复了我批评的那个问题。  
他们在原始的 serde_yaml 历史上进行了变基操作。然而，  
[vibe 编码](https://en.wikipedia.org/wiki/Vibe_coding) 部分让我无法信任，  
所以我仍然维护这个分支。  

再次声明，我不是在批评 `serde_yml` 团队，  
我只是说我个人不会使用他们的东西，因为我个人不信任他们。  
你想用哪个随你。  

这个库的用户越来越多，报告的问题也越来越多，  
以及拉取请求也在增加。我仍在努力  
[migrating away from unsafe-libyaml to libyaml-safer](https://github.com/acatton/serde-yaml-ng/issues/5)。  
据我所知，这将使这个库无与伦比。这个库是为我自己写的，  
请不要期望专业支持。  

现在有另一个原始 `serde_yaml` 的分支，叫做  
[`serde_norway`](https://docs.rs/serde_norway/latest/serde_norway/)。我还没评估它，  
那些指向原始 `serde_yaml` 的失效链接让我难以信任。  
但是其背后的人对我个人来说，看起来比  
`serde_yml` 背后的 AI-[cryptobros](https://en.wiktionary.org/wiki/cryptobro)  
可信得多。  

## 财务支持  

我只是一个晚上在车库工作，白天有份高薪工作的普通人。  
我不需要你的钱。**请！把钱捐给  
[David Tolnay](https://github.com/dtolnay)。**这个人  
[肩负着 Rust 生态系统的一半](https://crates.io/users/dtolnay)，  
在我分叉之前写了本项目的大部分代码。我只是个赶上这趟列车的失败者，别给我钱。  

## 许可证  

采用 <a href="LICENSE-MIT">MIT 许可证</a>。  

任何贡献都必须附带  
[开发者原始证书](https://developercertificate.org/) 的签名，  
通过在 `git commit` 时使用 `--signoff` 标志完成。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---