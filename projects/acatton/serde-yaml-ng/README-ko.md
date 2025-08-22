Serde YAML
==========

[<img alt="github" src="https://img.shields.io/badge/github-acatton/serde--yaml--ng-8da0cb?style=for-the-badge&labelColor=555555&logo=github" height="20">](https://github.com/acatton/serde-yaml-ng)
[<img alt="crates.io" src="https://img.shields.io/crates/v/serde_yaml_ng.svg?style=for-the-badge&color=fc8d62&logo=rust" height="20">](https://crates.io/crates/serde_yaml_ng)
[<img alt="docs.rs" src="https://img.shields.io/badge/docs.rs-serde__yaml__ng-66c2a5?style=for-the-badge&labelColor=555555&logo=docs.rs" height="20">](https://docs.rs/serde_yaml_ng)
[<img alt="build status" src="https://img.shields.io/github/actions/workflow/status/acatton/serde-yaml-ng/ci.yml?branch=master&style=for-the-badge" height="20">](https://github.com/acatton/serde-yaml-ng/actions?query=branch%3Amaster)

[YAML] 파일 형식의 데이터를 사용하는 [Serde] 직렬화 프레임워크용 Rust 라이브러리입니다. 이 라이브러리는 [YAML 사양 1.1](https://yaml.org/spec/1.1/)만을 준수합니다.

이 라이브러리는 최신 커밋 `200950`의 [serde-yaml](https://github.com/dtolnay/serde-yaml) 포크입니다.
<sup>\[[original](https://github.com/dtolnay/serde-yaml/commit/2009506d33767dfc88e979d6bc0d53d09f941c94)\]</sup>
<sup>\[[this project](https://github.com/acatton/serde-yaml-ng/commit/2009506d33767dfc88e979d6bc0d53d09f941c94)\]</sup>
제 목표는 [David Tolnay](https://github.com/dtolnay)의 원본 라이브러리와 최대한 호환되는 것입니다.

[Serde]: https://github.com/serde-rs/serde
[YAML]: https://yaml.org/

## 의존성



```toml
[dependencies]
serde = "1.0"
serde_yaml_ng = "0.10"
```
릴리스 노트는 [GitHub 릴리스]에서 확인할 수 있습니다.

[GitHub 릴리스]: https://github.com/acatton/serde-yaml-ng/releases

## Serde YAML 사용하기

[API 문서는 rustdoc 형태로 제공됩니다][docs.rs]만, 일반적인 개념은 다음과 같습니다:

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

프로그램에 정의된 구조체와 열거형을 처리하기 위해 Serde의 derive 매크로와 함께 사용할 수도 있습니다.


```toml
[dependencies]
serde = { version = "1.0", features = ["derive"] }
serde_yaml_ng = "0.10"
```

구조체는 명백한 방식으로 직렬화됩니다:

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

Enums는 변형 이름을 식별하기 위해 YAML의 `!tag` 구문을 사용하여 직렬화됩니다.

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
## 왜?

### 원본: 2024년 5월

*(이 내용은 오래된 것으로, 역사적 맥락을 위해 제공됩니다. 다음 업데이트를 참고하세요)*

이 프로젝트 시작 시점에 좋은 포크를 찾지 못했습니다. 최고의 후보는
[serde_yml](https://github.com/sebastienrousseau/serde_yml)로,
[주요 유지관리자가 작성한 거대한 "첫 커밋"](https://github.com/sebastienrousseau/serde_yml/commit/4312d4a56225b223410b5133af571fd13e62f18a)에 기반합니다.
이런 유형의 관행은 [보안 재앙](https://en.wikipedia.org/wiki/XZ_Utils_backdoor)으로 이어질 수 있습니다.

저는 사람들과 그들의 관행에 대해 싸우고 싶지 않아서,
이 라이브러리를 제 자신과 Rust 생태계 전체를 위해 유지하고 있습니다.
프랑스어로는 이렇게 말하죠: "*자기 자신보다 더 잘 돌봐줄 사람은 없다*". 😉

사용하든 말든 저는 상관없습니다. 가능한 한 많은 버그를 고치려고 노력할 것입니다.
합리적이거나 다루기 쉬운 풀 리퀘스트는 받아들일 것입니다.

### 업데이트: 2025년 7월

[serde_yml](https://github.com/sebastienrousseau/serde_yml)에 대해
[serde-yaml의 원 저자인 David Tolnay가 Twitter/X에서 큰 반발](https://xcancel.com/davidtolnay/status/1883906113428676938)을 받았습니다.

[xcancel.com](https://xcancel.com/)이 폐쇄될 경우를 대비해 그들의 트윗 사본을 여기에 제공합니다. (참고로, xcancel.com은 기부를 받습니다)

> David Tolnay (@davidtolnay) - 2025년 1월 27일
>
> 얼마 전까지만 해도, 저는 Rust 사용자에 대해 더 낙관적인 인상을 가지고 있었습니다.
> 그렇게 많은 신중한 사람들이 명백히 AI-"유지" Rust 라이브러리를 선택할 줄은 몰랐습니다.
>
> `serde_yml` 크레이트는 고품질이지만 유지보수되지 않는 라이브러리의 포크입니다.
> 이 포크에서 AI는 완전히 터무니없는 것들([docs.rs/serde_yml/0.0.11/ser…](https://docs.rs/serde_yml/0.0.11/serde_yml/macro.macro_get_field.html),
> [docs.rs/serde_yml/0.0.11/src…](https://docs.rs/serde_yml/0.0.11/src/serde_yml/macros/macro_get_field.rs.html#14-49))
> 또는 부적합한([docs.rs/serde_yml/0.0.11/ser…](https://docs.rs/serde_yml/0.0.11/serde_yml/ser/struct.Serializer.html#structfield.emitter)) 것들을 대거 추가했습니다. 게다가,
> 크레이트 문서는 docs.rs에서 최근까지 깨져 있었습니다.





> 5개월 동안 AI가 존재하지 않는 rustdoc 플래그를 크레이트 구성에 환각하여 넣었기 때문입니다.
>
> 그런데도 134개의 다른 배포된 패키지가 이를 채택하기로 선택했습니다. Jiff(테스트 전용), axodotdev, Wasmer, MiniJinja, Holochain 같은
> 고도로 유지 관리되는 유명 프로젝트들도 포함되어 있습니다. 이는 좋은 징조가 아닙니다.
>
> YAML 라이브러리에서 더 잘할 수 있는 사람의 기준이 너무 낮습니다.

이 트윗에 첨부된 코드는 다음과 같습니다:



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
그리고 이 콘솔 출력:


```
$ cargo run --release
    Finished `release` profile [optimized] target(s) in 0.01s
     Running `target/release/repro`
Segmentation fault (core dumped)
```
백래시 이후, `serde_yml` 팀은 그들의 git 히스토리를 정리했고  
내가 그들의 git 사용 방식을 비판하며 올렸던 모든 링크를 깨뜨렸습니다. 그들은 내가 비판했던 한 가지를 고쳤습니다.  
원래 `serde_yaml` 히스토리에 리베이스를 했습니다. 그러나 [바이브 코딩](https://en.wikipedia.org/wiki/Vibe_coding) 부분은  
내 입장에서는 신뢰를 주지 않으므로, 나는 여전히 이 포크를 유지하고 있습니다.  

다시 말하지만, 나는 `serde_yml` 팀을 비판하는 것이 아니라,  
개인적으로 그들을 신뢰하지 않기 때문에 그들의 것을 사용하지 않겠다는 것입니다.  
당신은 원하는 대로 하십시오.  

이 라이브러리는 점점 더 많은 사용자와 더 많은 이슈 및 풀 리퀘스트를 받았습니다.  
나는 여전히 [unsafe-libyaml에서 libyaml-safer로 마이그레이션하는 작업](https://github.com/acatton/serde-yaml-ng/issues/5)을 하고 있습니다.  
이 작업은 이 라이브러리를 AFAIK 독보적으로 만들 것입니다.  
이 라이브러리는 나 자신을 위한 것이므로, 전문적인 지원을 기대하지 마십시오.  

지금은 원본 `serde_yaml`의 또 다른 포크가 있는데,  
이름은 [`serde_norway`](https://docs.rs/serde_norway/latest/serde_norway/)입니다.  
나는 아직 평가하지 않았으며, 원본 `serde_yaml`을 참조하는 깨진 링크들이 신뢰를 주지 않습니다.  
하지만 그 뒤에 있는 사람들은 개인적으로 나에게  
`serde_yml` 뒤의 AI-[cryptobros](https://en.wiktionary.org/wiki/cryptobro)보다 훨씬 훨씬 더 신뢰할 만해 보입니다.  

## 재정 지원  

나는 낮에는 잘 나가는 직업을 가진, 밤에는 차고에서 일하는 사람입니다.  
당신의 돈은 필요 없습니다. **대신 [David Tolnay](https://github.com/dtolnay)에게 돈을 주세요.**  
이 사람은 [러스트 생태계의 절반을 짊어지고 있습니다](https://crates.io/users/dtolnay),  
그리고 내가 포크하기 전에 이 프로젝트의 대부분 코드를 작성했습니다. 나는 그냥 기차에 올라탄 루저일 뿐이니, 나에게는 돈을 주지 마세요.  

## 라이선스  

<a href="LICENSE-MIT">MIT 라이선스</a> 하에 라이선스가 부여됩니다.  

모든 기여는  
[개발자 기원 증명서](https://developercertificate.org/) 서명과 함께 해야 하며,  
`git commit` 시 `--signoff` 플래그를 사용해야 합니다.








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---