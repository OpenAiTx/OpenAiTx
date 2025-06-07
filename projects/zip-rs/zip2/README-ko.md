zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[문서](https://docs.rs/zip/latest/zip/)

정보
----

Rust용 ZIP 라이브러리로, 단순 ZIP 파일의 읽기 및 쓰기를 지원합니다. 이전에는 https://github.com/zip-rs/zip2 에서 호스팅되었습니다.

지원되는 압축 포맷:

* 저장(stored, 즉 무압축)
* deflate
* deflate64 (압축 해제만 지원)
* bzip2
* zstd
* lzma (압축 해제만 지원)
* xz (압축 해제만 지원)

현재 지원하지 않는 ZIP 확장:

* 다중 디스크(Multi-disk)

기능(Features)
--------

사용 가능한 기능은 다음과 같습니다:

* `aes-crypto`: AES로 암호화된 파일의 복호화를 활성화합니다. AE-1 및 AE-2 방식을 지원합니다.
* `deflate`: ZIP 파일의 기본 압축 알고리즘인 deflate의 미지정 구현(향후 버전에서 변경될 수 있음)을 사용하여 압축 및 압축 해제를 활성화합니다. 압축 품질 1..=264를 지원합니다.
* `deflate-flate2`: 백엔드를 활성화하는 모든 `flate2` 기능 플래그와 함께 사용하여 품질 1..=9에서 deflate 압축을 지원합니다.
* `deflate-zopfli`: `zopfli` 라이브러리를 사용하여(압축 품질이 10..=264일 때 사용) 파일을 deflate합니다. 가장 효과적인 deflate 구현이지만, 속도는 가장 느린 편입니다.
* `deflate64`: deflate64 압축 알고리즘을 활성화합니다. 압축 해제만 지원합니다.
* `lzma`: LZMA 압축 알고리즘을 활성화합니다. 압축 해제만 지원합니다.
* `bzip2`: BZip2 압축 알고리즘을 활성화합니다.
* `time`: [time](https://github.com/rust-lang-deprecated/time) 크레이트를 사용하는 기능을 활성화합니다.
* `chrono`: 마지막 수정된 `zip::DateTime`을 `chrono::NaiveDateTime`으로 변환하거나 그 반대로 변환하는 기능을 활성화합니다.
* `jiff-02`: 마지막 수정된 `zip::DateTime`을 `jiff::civil::DateTime`으로 변환하거나 그 반대로 변환하는 기능을 활성화합니다.
* `nt-time`: NTFS 추가 필드에 저장된 타임스탬프를 `nt_time::FileTime`으로 반환하는 기능을 활성화합니다.
* `zstd`: Zstandard 압축 알고리즘을 활성화합니다.

기본적으로 `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time`, `zstd`가 활성화되어 있습니다.

MSRV
----

현재 최소 지원 Rust 버전은 **1.75**입니다. 기능을 추가할 때 다음 가이드라인을 따릅니다:

- 항상 최소 6개월 이상 안정화된 마이너 Rust 버전을 지원합니다.
- MSRV 변경 시에는 **마이너** 버전 업이 동반됩니다.

예제
--------

[examples 디렉토리](https://raw.githubusercontent.com/zip-rs/zip2/master/examples)에서 다음 예제를 확인할 수 있습니다:
   * 파일을 zip으로 쓰는 방법
   * 디렉토리의 파일들을 zip으로 쓰는 방법 ([walkdir](https://github.com/BurntSushi/walkdir) 사용)
   * zip 파일을 추출하는 방법
   * zip에서 단일 파일을 추출하는 방법
   * 표준 입력에서 zip을 읽는 방법
   * 기존 아카이브에 디렉토리를 추가하는 방법

퍼징(Fuzzing)
-------

퍼징 지원은 [cargo afl](https://rust-fuzz.github.io/book/afl.html)을 통해 제공됩니다. cargo afl 설치 방법:

```bash
cargo install cargo-afl
```

zip 추출 퍼징 시작:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

zip 생성 퍼징 시작:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---