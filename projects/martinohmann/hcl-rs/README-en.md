# hcl-rs

[![Build Status](https://github.com/martinohmann/hcl-rs/workflows/ci/badge.svg)](https://github.com/martinohmann/hcl-rs/actions?query=workflow%3Aci)
[![License: Apache 2.0](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This repository contains the following rust crates around the Hashicorp
Configuration Language (HCL):

- [`hcl-rs`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-rs):
  HCL library with `serde` and expression evaluation support.
- [`hcl-edit`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-edit):
  Parse and modify HCL documents while preserving whitespace and comments.
- [`hcl-primitives`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-primitives):
  Primitives used by the HCL sub-languages.
- [`hcl2json`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl2json):
  CLI program for converting HCL to JSON.

## Feature parity with the go-hcl implementation

The crates in this repository try to closely follow these specifications that
are part of the Hashicorp's [HCL Go
implementation](https://github.com/hashicorp/hcl):

- [HCL Syntax-Agnostic Information Model](https://github.com/hashicorp/hcl/blob/main/spec.md)
- [HCL Native Syntax Specification](https://github.com/hashicorp/hcl/blob/main/hclsyntax/spec.md)
- [HCL JSON Syntax Specification](https://github.com/hashicorp/hcl/blob/main/json/spec.md)

At the parser level it should support all features that go-hcl does today.
However, the implementations for formatting and expression evaluation in `hcl-rs`
are relatively basic at the moment. There are plans to move formatting and
expression evaluation capabilities into `hcl-edit` (which is used by `hcl-rs` under
the hood and also contains the parser implementation) and to make them more
powerful.

Another thing that is not included (yet), is the support for HCL schemas in
order to validate that a parsed HCL document only contains an allowed set of
blocks with expected attributes (e.g. to enable validation that a given
terraform configuration only contains well-formed `resource` and `data` blocks
etc.).
Additionally, schema support can help to make it easier to encode more complex  
configurations using custom types. These configurations are currently  
cumbersome to assemble because of limitations of the `serde` model.  

## Contributing  

Contributions are welcome! Please read  
[`CONTRIBUTING.md`](https://github.com/martinohmann/hcl-rs/blob/main/CONTRIBUTING.md)  
before creating a PR.  

## License  

If not stated otherwise, the source code inside this repository is licensed  
under either of [Apache License, Version  
2.0](https://github.com/martinohmann/hcl-rs/blob/main/LICENSE-APACHE) or [MIT  
license](https://github.com/martinohmann/hcl-rs/blob/main/LICENSE-MIT) at your  
option.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---