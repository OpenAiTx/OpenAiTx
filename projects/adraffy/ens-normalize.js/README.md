# ens-normalize.js
0-dependency [Ethereum Name Service](https://ens.domains/) (ENS) Name Normalizer.

`npm i @adraffy/ens-normalize` [&check;](https://www.npmjs.com/package/@adraffy/ens-normalize)

* 🏛️ Follows [**ENSIP-15**: ENS Name Normalization Standard](https://docs.ens.domains/ensip/15)
	* Unicode: [`17.0.0`](./derive/data/17.0.0/) • CLDR: [`47`](./derive/data/CLDR-47/)
	* Other implementations:
		* Python — [namehash/**ens-normalize-python**](https://github.com/namehash/ens-normalize-python)
		* Rust — [sevenzing/**ens-normalize-rs**](https://github.com/sevenzing/ens-normalize-rs)
		* Zig — [evmts/**z-ens-normalize**](https://github.com/evmts/z-ens-normalize)
		* C# — [adraffy/**ENSNormalize.cs**](https://github.com/adraffy/ENSNormalize.cs)
		* Java — [adraffy/**ENSNormalize.java**](https://github.com/adraffy/ENSNormalize.java)
		* Swift – [adraffy/**ENSNormalize.swift**](https://github.com/adraffy/ENSNormalize.swift)
		* Go — [adraffy/**go-ens-normalize**](https://github.com/adraffy/go-ens-normalize)
		* Swift – [adraffy/**ENSNormalize.swift**](https://github.com/adraffy/ENSNormalize.swift)
	* Prior implementation:
		* Javascript — [ensdomains/**eth-ens-namehash**](https://github.com/ensdomains/eth-ens-namehash)
	* [Breakdown Reports from ENSIP-1](https://adraffy.github.io/ens-norm-tests/test-breakdown/output-20230226/)	
* ✅️ Passes **100%** [ENSIP-15 Validation Tests](https://adraffy.github.io/ens-normalize.js/test/validate.html)
* ✅️ Passes **100%** [Unicode Normalization Tests](https://adraffy.github.io/ens-normalize.js/test/report-nf.html)
* Minified File Sizes: 
	* [`29KB`](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/index-xnf.min.js) — native NFC via [nf-native.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/nf-native.js) using `String.normalize()` ⚠️
	* [`38KB` **Default**](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/index.min.js) — custom NFC via [nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/nf.js)
	* [`44KB`](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/all.min.js) *Everything!* — custom NFC + sub-libraries: [parts.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/parts.js), [utils.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/utils.js)
* Included Apps:
	* [**Resolver Demo**](https://adraffy.github.io/ens-normalize.js/test/resolver.html) ⭐
	* [Supported Emoji](https://adraffy.github.io/ens-normalize.js/test/emoji.html)
	* [Character Viewer](https://adraffy.github.io/ens-normalize.js/test/chars.html)
	* [Confused Explainer](https://adraffy.github.io/ens-normalize.js/test/confused.html)
* Related Projects:
	* [Recent .eth Registrations](https://raffy.antistupid.com/eth/ens-regs.html) • [Renews](https://raffy.antistupid.com/eth/ens-renews.html) • [Expirations](https://raffy.antistupid.com/eth/ens-exp.html)
	* [Label Database](https://github.com/adraffy/ens-labels/) • [Labelhash⁻¹](https://adraffy.github.io/ens-labels/demo.html) • [Brute-force](https://raffy.antistupid.com/eth/ens-brute.html)
	* [Emoji Frequency Explorer](https://raffy.antistupid.com/eth/ens-emoji-freq.html)
	* [adraffy/**punycode.js**](https://github.com/adraffy/punycode.js/) • [Punycode Coder](https://adraffy.github.io/punycode.js/test/demo.html)
	* [adraffy/**keccak.js**](https://github.com/adraffy/keccak.js/) • [Keccak Hasher](https://adraffy.github.io/keccak.js/test/demo.html)
	* [adraffy/**emoji.js**](https://github.com/adraffy/emoji.js/) • [Emoji Parser](https://adraffy.github.io/emoji.js/test/demo.html)
	* More links at bottom of [Resolver Demo](https://adraffy.github.io/ens-normalize.js/test/resolver.html)

```js
import {ens_normalize} from '@adraffy/ens-normalize'; // or require()
// browser: https://cdn.jsdelivr.net/npm/@adraffy/ens-normalize@latest/dist/index.min.mjs (or .cjs)

// *** ALL errors thrown by this library are safe to print ***
// - characters are shown as {HEX} if should_escape()
// - potentially different bidi directions inside "quotes"
// - 200E is used near "quotes" to prevent spillover
// - an "error type" can be extracted by slicing up to the first (:)
// - labels are middle-truncated with ellipsis (…) at 63 cps

// string -> string
// throws on invalid names
// output ready for namehash
let normalized = ens_normalize('RaFFY🚴‍♂️.eTh');
// => "raffy🚴‍♂.eth"

// note: does not enforce .eth registrar 3-character minimum
```

Format names with fully-qualified emoji:
```js
// works like ens_normalize()
// output ready for display
let pretty = ens_beautify('1⃣2⃣.eth'); 
// => "1️⃣2️⃣.eth"

// note: normalization is unchanged:
// ens_normalize(ens_beautify(x)) == ens_normalize(x)
```

Normalize name fragments for [substring search](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./test/fragment.js):
```js
// these fragments fail ens_normalize() 
// but will normalize fine as fragments
let frag1 = ens_normalize_fragment('AB--');    // expected error: label ext
let frag2 = ens_normalize_fragment('\u{303}'); // expected error: leading cm
let frag3 = ens_normalize_fragment('οо');      // expected error: mixture
```

Input-based tokenization:
```js
// string -> Token[]
// never throws
let tokens = ens_tokenize('_R💩\u{FE0F}a\u{FE0F}\u{304}\u{AD}./');
// [
//     { type: 'valid', cps: [ 95 ] }, // valid (as-is)
//     {
//         type: 'mapped', 
//         cp: 82,         // input
//         cps: [ 114 ]    // output
//     }, 
//     { 
//         type: 'emoji',
//         input: Emoji(2) [ 128169, 65039 ],  // input 
//         emoji: [ 128169, 65039 ],           // fully-qualified
//         cps: Emoji(1) [ 128169 ]            // output (normalized)
//     },
//     {
//         type: 'nfc',
//         input: [ 97, 772 ],  // input (before nfc)
//         cps: [ 257 ],        // output (after nfc)
//         tokens0: [           // tokens (before nfc)
//             { type: 'valid', cps: [ 97 ] },
//             { type: 'ignored', cp: 65039 },
//             { type: 'valid', cps: [ 772 ] }
//         ],
//         tokens: [            // tokens (after nfc)
//             { type: 'valid', cps: [ 257 ] }
//         ]
//     },
//     { type: 'ignored', cp: 173 },
//     { type: 'stop', cp: 46 },
//     { type: 'disallowed', cp: 47 }
// ]

// note: if name is normalizable, then:
// ens_normalize(ens_tokenize(name).map(token => {
//     ** convert valid/mapped/nfc/stop to string **
// }).join('')) == ens_normalize(name)
```

Output-based tokenization:
```js
// string -> Label[]
// never throws
let labels = ens_split('💩Raffy.eth_');
// [
//   {
//     input: [ 128169, 82, 97, 102, 102, 121 ],  
//     offset: 0, // index of codepoint, not substring index!
//                // (corresponding length can be inferred from input)
//     tokens: [
//       Emoji(2) [ 128169, 65039 ],   // emoji
//       [ 114, 97, 102, 102, 121 ]    // nfc-text
//     ],
//     output: [ 128169, 114, 97, 102, 102, 121 ],
//     emoji: true,
//     type: 'Latin'
//   },
//   {
//     input: [ 101, 116, 104, 95 ],
//     offset: 7,
//     tokens: [ [ 101, 116, 104, 95 ] ],
//     output: [ 101, 116, 104, 95 ],
//     error: Error('underscore allowed only at start')
//   }
// ]
```

Generate a sorted array of (beautified) supported emoji codepoints:
```js
// () -> number[][]
let emojis = ens_emoji();
// [
//     [ 2764 ],
//     [ 128169, 65039 ],
//     [ 128105, 127997, 8205, 9877, 65039 ],
//     ...
// ]
```

Determine if a character shouldn't be printed directly:
```js
// number -> bool
should_escape(0x202E); // eg. RIGHT-TO-LEFT OVERRIDE => true
```

Determine if a character is a combining mark:
```js
// number -> bool
is_combining_mark(0x20E3); // eg. COMBINING ENCLOSING KEYCAP => true
```

Format codepoints as print-safe string:
```js
// number[] -> string
safe_str_from_cps([0x300, 0, 32, 97]); // "◌̀{00} a"
safe_str_from_cps(Array(100).fill(97), 4); // "aa…aa" => middle-truncated
```

## Build

* `git clone` this repo, then `npm install` 
* Follow instructions in [/derive/](./derive/) to generate data files
	* `npm run derive` 
		* [spec.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/spec.json)
		* [nf.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/nf.json)
		* [nf-tests.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/nf-tests.json)
* `npm run make` — compress data files from [/derive/output/](./derive/output/)
	* [include-ens.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-ens.js)
	* [include-nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-nf.js)
	* [include-versions.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-versions.js)
* Follow instructions in [/validate/](./validate/) to generate validation tests
	* `npm run validate`
		* [tests.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./validate/tests.json)
* `npm run test` — perform validation tests
* `npm run build` — create [/dist/](./dist/)
* `npm run rebuild` — run all the commands above
* `npm run order` — create optimal group ordering and rebuild again

## Security

* [Build](#build) and compare against [include-versions.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-versions.js)
	* `spec_hash` — SHA-256 of [spec.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/spec.json) bytes
	* `ens_hash_base64` — SHA-256 of [include-ens.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-ens.js) base64 literal
	* `nf_hash_base64` — SHA-256 of [include-nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-nf.js) base64 literal
