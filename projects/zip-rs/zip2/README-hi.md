zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[डॉक्यूमेंटेशन](https://docs.rs/zip/latest/zip/)

जानकारी
----

रस्ट के लिए एक ज़िप लाइब्रेरी, जो साधारण ZIP फ़ाइलों के पढ़ने और लिखने का समर्थन करती है। पहले यह https://github.com/zip-rs/zip2 पर होस्ट की गई थी।

समर्थित कंप्रेशन फॉर्मेट्स:

* stored (अर्थात् कोई नहीं)
* deflate
* deflate64 (केवल डिकंप्रेशन)
* bzip2
* zstd
* lzma (केवल डिकंप्रेशन)
* xz (केवल डिकंप्रेशन)

वर्तमान में असमर्थित zip एक्सटेंशन:

* मल्टी-डिस्क

विशेषताएँ
--------

उपलब्ध विशेषताएँ:

* `aes-crypto`: उन फ़ाइलों के डिक्रिप्शन को सक्षम करता है जिन्हें AES के साथ एन्क्रिप्ट किया गया था। AE-1 और AE-2 विधियों का समर्थन करता है।
* `deflate`: डिफ़्लेट कंप्रेशन एल्गोरिदम के एक अनिर्दिष्ट इम्प्लीमेंटेशन (जो भविष्य के वर्शन में बदल सकता है) के कंप्रेस और डिकंप्रेस को सक्षम करता है, जो zip फ़ाइलों के लिए डिफ़ॉल्ट है। कंप्रेशन क्वालिटी 1..=264 का समर्थन करता है।
* `deflate-flate2`: इसे किसी भी `flate2` फीचर फ्लैग के साथ जोड़ें जो एक बैक-एंड को सक्षम करता है, ताकि क्वालिटी 1..=9 पर डिफ़्लेट कंप्रेशन का समर्थन हो सके।
* `deflate-zopfli`: `zopfli` लाइब्रेरी के साथ फाइलों को डिफ्लेट करने को सक्षम करता है (जब कंप्रेशन क्वालिटी 10..=264 हो)। यह उपलब्ध सबसे प्रभावी `deflate` इम्प्लीमेंटेशन है, लेकिन सबसे धीमे में से भी है।
* `deflate64`: डिफ़्लेट64 कंप्रेशन एल्गोरिदम को सक्षम करता है। केवल डिकंप्रेशन समर्थित है।
* `lzma`: LZMA कंप्रेशन एल्गोरिदम को सक्षम करता है। केवल डिकंप्रेशन समर्थित है।
* `bzip2`: BZip2 कंप्रेशन एल्गोरिदम को सक्षम करता है।
* `time`: [time](https://github.com/rust-lang-deprecated/time) क्रेट का उपयोग करने वाली विशेषताओं को सक्षम करता है।
* `chrono`: अंतिम-संशोधित `zip::DateTime` को और से `chrono::NaiveDateTime` में बदलने को सक्षम करता है।
* `jiff-02`: अंतिम-संशोधित `zip::DateTime` को और से `jiff::civil::DateTime` में बदलने को सक्षम करता है।
* `nt-time`: NTFS अतिरिक्त फील्ड में संग्रहीत टाइमस्टैम्प को `nt_time::FileTime` के रूप में लौटाने को सक्षम करता है।
* `zstd`: Zstandard कंप्रेशन एल्गोरिदम को सक्षम करता है।

डिफ़ॉल्ट रूप से `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time` और `zstd` सक्षम हैं।

MSRV
----

हमारा वर्तमान न्यूनतम समर्थित रस्ट वर्शन **1.75** है। जब फीचर्स जोड़े जाते हैं, हम इन दिशानिर्देशों का पालन करेंगे:

- हम हमेशा एक मिनर रस्ट वर्शन का समर्थन करेंगे जो कम से कम 6 महीने से स्थिर है।
- MSRV में किसी भी बदलाव के साथ **माइनर** वर्शन बंप किया जाएगा।

उदाहरण
--------

[examples directory](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) देखें:
   * किसी फाइल को ज़िप में कैसे लिखें।
   * फाइलों की डायरेक्टरी को ज़िप में कैसे लिखें ([walkdir](https://github.com/BurntSushi/walkdir) का उपयोग करते हुए)।
   * ज़िप फाइल को कैसे निकालें।
   * ज़िप से किसी एक फाइल को कैसे निकालें।
   * स्टैंडर्ड इनपुट से ज़िप कैसे पढ़ें।
   * किसी मौजूदा आर्काइव में डायरेक्टरी कैसे जोड़ें।

फजिंग
-------

फजिंग सपोर्ट [cargo afl](https://rust-fuzz.github.io/book/afl.html) के माध्यम से है। cargo afl इंस्टॉल करने के लिए:

```bash
cargo install cargo-afl
```

ज़िप एक्सट्रैक्शन के लिए फजिंग शुरू करने के लिए:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

ज़िप क्रिएशन के लिए फजिंग शुरू करने के लिए:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---