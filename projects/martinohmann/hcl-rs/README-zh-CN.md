# hcl-rs

[![构建状态](https://github.com/martinohmann/hcl-rs/workflows/ci/badge.svg)](https://github.com/martinohmann/hcl-rs/actions?query=workflow%3Aci)
[![许可证: Apache 2.0](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![许可证: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

本仓库包含了围绕 Hashicorp 配置语言（HCL）的以下 Rust 库：

- [`hcl-rs`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-rs):
  支持 `serde` 和表达式求值的 HCL 库。
- [`hcl-edit`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-edit):
  解析和修改 HCL 文档，同时保留空白和注释。
- [`hcl-primitives`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-primitives):
  HCL 子语言使用的原始类型。
- [`hcl2json`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl2json):
  用于将 HCL 转换为 JSON 的命令行程序。

## 与 go-hcl 实现的功能一致性

本仓库中的库试图紧密遵循以下作为 Hashicorp [HCL Go
实现](https://github.com/hashicorp/hcl)一部分的规范：

- [HCL 语法无关的信息模型](https://github.com/hashicorp/hcl/blob/main/spec.md)
- [HCL 原生语法规范](https://github.com/hashicorp/hcl/blob/main/hclsyntax/spec.md)
- [HCL JSON 语法规范](https://github.com/hashicorp/hcl/blob/main/json/spec.md)

在解析器层面，它应支持 go-hcl 目前支持的所有功能。
然而，`hcl-rs` 中的格式化和表达式求值实现目前相对基础。
计划将格式化和表达式求值功能移入 `hcl-edit`（`hcl-rs` 在底层使用它且它也包含解析器实现），
并使其更加强大。

另外，目前还未包含的是对 HCL 模式的支持，
用于验证解析后的 HCL 文档只包含允许的块和预期的属性（例如，验证给定的 terraform 配置只包含格式正确的 `resource` 和 `data` 块等）。







此外，模式支持可以帮助更容易地使用自定义类型编码更复杂的配置。  
由于 `serde` 模型的限制，这些配置目前组装起来比较繁琐。  

## 贡献  

欢迎贡献！请在创建 PR 之前阅读  
[`CONTRIBUTING.md`](https://github.com/martinohmann/hcl-rs/blob/main/CONTRIBUTING.md)。  

## 许可证  

除非另有说明，本仓库中的源代码均根据  
[Apache 许可证，第 2.0 版](https://github.com/martinohmann/hcl-rs/blob/main/LICENSE-APACHE)  
或 [MIT 许可证](https://github.com/martinohmann/hcl-rs/blob/main/LICENSE-MIT)  
由您自行选择授权。






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---