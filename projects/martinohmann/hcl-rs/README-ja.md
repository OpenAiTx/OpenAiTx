# hcl-rs

[![Build Status](https://github.com/martinohmann/hcl-rs/workflows/ci/badge.svg)](https://github.com/martinohmann/hcl-rs/actions?query=workflow%3Aci)
[![License: Apache 2.0](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

このリポジトリには、Hashicorp Configuration Language（HCL）に関する以下のRustクレートが含まれています：

- [`hcl-rs`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-rs):
  `serde`および式評価のサポートを備えたHCLライブラリ。
- [`hcl-edit`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-edit):
  空白やコメントを保持しながらHCLドキュメントを解析および修正。
- [`hcl-primitives`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-primitives):
  HCLのサブ言語で使用されるプリミティブ。
- [`hcl2json`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl2json):
  HCLをJSONに変換するCLIプログラム。

## go-hcl実装との機能の同等性

このリポジトリのクレートは、Hashicorpの[HCL Go実装](https://github.com/hashicorp/hcl)の一部である以下の仕様にできるだけ忠実に従うことを目指しています：

- [HCL Syntax-Agnostic Information Model](https://github.com/hashicorp/hcl/blob/main/spec.md)
- [HCL Native Syntax Specification](https://github.com/hashicorp/hcl/blob/main/hclsyntax/spec.md)
- [HCL JSON Syntax Specification](https://github.com/hashicorp/hcl/blob/main/json/spec.md)

パーサーレベルでは、現在go-hclがサポートしているすべての機能をサポートするはずです。
ただし、`hcl-rs`におけるフォーマットおよび式評価の実装は現時点では比較的基本的なものです。  
フォーマットおよび式評価機能は`hcl-edit`に移行する計画があり（`hcl-rs`は内部で`hcl-edit`を使用し、パーサー実装も含みます）、これらをより強力にする予定です。

もう一つまだ含まれていない機能は、HCLスキーマのサポートです。  
これは、解析されたHCLドキュメントが許可されたセットのブロックと予期される属性のみを含むことを検証するためのもので（例えば、特定のterraform構成が正しく形成された`resource`や`data`ブロックのみを含むことを検証するなど）、将来的に対応予定です。









さらに、スキーマサポートはカスタムタイプを使用してより複雑な構成をエンコードしやすくするのに役立ちます。これらの構成は現在、`serde`モデルの制限により組み立てが面倒です。

## 貢献

貢献は歓迎します！PRを作成する前に
[`CONTRIBUTING.md`](https://github.com/martinohmann/hcl-rs/blob/main/CONTRIBUTING.md)
をお読みください。

## ライセンス

特に明記がない限り、このリポジトリ内のソースコードは
[Apache License, Version
2.0](https://github.com/martinohmann/hcl-rs/blob/main/LICENSE-APACHE) または
[MIT
license](https://github.com/martinohmann/hcl-rs/blob/main/LICENSE-MIT) のいずれかの
ライセンスの下で使用者の選択によりライセンスされています。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---