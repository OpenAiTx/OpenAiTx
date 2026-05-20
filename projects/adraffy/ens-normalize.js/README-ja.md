# ens-normalize.js
0依存 [Ethereum Name Service](https://ens.domains/) (ENS) 名称正規化ツール。

`npm i @adraffy/ens-normalize` [&check;](https://www.npmjs.com/package/@adraffy/ens-normalize)

* 🏛️ [**ENSIP-15**: ENS 名称正規化標準](https://docs.ens.domains/ensip/15) に準拠
	* Unicode: [`17.0.0`](./derive/data/17.0.0/) • CLDR: [`47`](./derive/data/CLDR-47/)
	* 他の実装例:
		* Python — [namehash/**ens-normalize-python**](https://github.com/namehash/ens-normalize-python)
		* Rust — [sevenzing/**ens-normalize-rs**](https://github.com/sevenzing/ens-normalize-rs)
		* Zig — [evmts/**z-ens-normalize**](https://github.com/evmts/z-ens-normalize)
		* C# — [adraffy/**ENSNormalize.cs**](https://github.com/adraffy/ENSNormalize.cs)
		* Java — [adraffy/**ENSNormalize.java**](https://github.com/adraffy/ENSNormalize.java)
		* Swift – [adraffy/**ENSNormalize.swift**](https://github.com/adraffy/ENSNormalize.swift)
		* Go — [adraffy/**go-ens-normalize**](https://github.com/adraffy/go-ens-normalize)
		* Swift – [adraffy/**ENSNormalize.swift**](https://github.com/adraffy/ENSNormalize.swift)
	* 以前の実装:
		* Javascript — [ensdomains/**eth-ens-namehash**](https://github.com/ensdomains/eth-ens-namehash)
	* [ENSIP-1からの内訳レポート](https://adraffy.github.io/ens-norm-tests/test-breakdown/output-20230226/)	
* ✅️ **100%** 合格 [ENSIP-15 検証テスト](https://adraffy.github.io/ens-normalize.js/test/validate.html)
* ✅️ **100%** 合格 [Unicode 正規化テスト](https://adraffy.github.io/ens-normalize.js/test/report-nf.html)
* ミニファイドファイルサイズ: 
	* [`29KB`](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/index-xnf.min.js) — ネイティブNFC、[nf-native.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/nf-native.js) による `String.normalize()` 使用 ⚠️
	* [`38KB` **デフォルト**](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/index.min.js) — カスタムNFC、[nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/nf.js)
	* [`44KB`](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/all.min.js) *全て含む!* — カスタムNFC + サブライブラリ: [parts.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/parts.js), [utils.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/utils.js)
* 含まれるアプリ:
	* [**リゾルバーデモ**](https://adraffy.github.io/ens-normalize.js/test/resolver.html) ⭐
	* [対応絵文字](https://adraffy.github.io/ens-normalize.js/test/emoji.html)
	* [文字ビューア](https://adraffy.github.io/ens-normalize.js/test/chars.html)
	* [混乱解説](https://adraffy.github.io/ens-normalize.js/test/confused.html)
* 関連プロジェクト:
	* [最新の .eth 登録](https://raffy.antistupid.com/eth/ens-regs.html) • [更新](https://raffy.antistupid.com/eth/ens-renews.html) • [期限切れ](https://raffy.antistupid.com/eth/ens-exp.html)
	* [ラベルデータベース](https://github.com/adraffy/ens-labels/) • [Labelhash⁻¹](https://adraffy.github.io/ens-labels/demo.html) • [総当たり](https://raffy.antistupid.com/eth/ens-brute.html)
	* [絵文字頻度エクスプローラー](https://raffy.antistupid.com/eth/ens-emoji-freq.html)
	* [adraffy/**punycode.js**](https://github.com/adraffy/punycode.js/) • [Punycode コーダー](https://adraffy.github.io/punycode.js/test/demo.html)
	* [adraffy/**keccak.js**](https://github.com/adraffy/keccak.js/) • [Keccak ハッシャー](https://adraffy.github.io/keccak.js/test/demo.html)
	* [adraffy/**emoji.js**](https://github.com/adraffy/emoji.js/) • [絵文字パーサー](https://adraffy.github.io/emoji.js/test/demo.html)
	* [リゾルバーデモ](https://adraffy.github.io/ens-normalize.js/test/resolver.html) 下部にさらにリンクあり

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
絵文字を完全修飾形式でフォーマットする:

```js
// works like ens_normalize()
// output ready for display
let pretty = ens_beautify('1⃣2⃣.eth'); 
// => "1️⃣2️⃣.eth"

// note: normalization is unchanged:
// ens_normalize(ens_beautify(x)) == ens_normalize(x)
```

[部分文字列検索](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./test/fragment.js)のために名前の断片を正規化する:
```js
// these fragments fail ens_normalize() 
// but will normalize fine as fragments
let frag1 = ens_normalize_fragment('AB--');    // expected error: label ext
let frag2 = ens_normalize_fragment('\u{303}'); // expected error: leading cm
let frag3 = ens_normalize_fragment('οо');      // expected error: mixture
```
入力ベースのトークン化:

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
出力ベースのトークン化:

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

（整形された）サポートされている絵文字コードポイントのソート済み配列を生成してください：
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

文字が直接印刷されるべきでないかどうかを判断する:
```js
// number -> bool
should_escape(0x202E); // eg. RIGHT-TO-LEFT OVERRIDE => true
```

文字が結合記号かどうかを判定する:
```js
// number -> bool
is_combining_mark(0x20E3); // eg. COMBINING ENCLOSING KEYCAP => true
```
コードポイントを印刷可能な文字列としてフォーマットする:

```js
// number[] -> string
safe_str_from_cps([0x300, 0, 32, 97]); // "◌̀{00} a"
safe_str_from_cps(Array(100).fill(97), 4); // "aa…aa" => middle-truncated
```
## ビルド

* このリポジトリを `git clone` し、次に `npm install` を実行
* [/derive/](./derive/) 内の指示に従いデータファイルを生成
	* `npm run derive`
		* [spec.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/spec.json)
		* [nf.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/nf.json)
		* [nf-tests.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/nf-tests.json)
* `npm run make` — [/derive/output/](./derive/output/) からデータファイルを圧縮
	* [include-ens.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-ens.js)
	* [include-nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-nf.js)
	* [include-versions.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-versions.js)
* [/validate/](./validate/) 内の指示に従い検証テストを生成
	* `npm run validate`
		* [tests.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./validate/tests.json)
* `npm run test` — 検証テストを実行
* `npm run build` — [/dist/](./dist/) を作成
* `npm run rebuild` — 上記すべてのコマンドを実行
* `npm run order` — 最適なグループ順序を作成して再ビルド

## セキュリティ

* [ビルド](#build) を実行し、[include-versions.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-versions.js) と比較
	* `spec_hash` — [spec.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/spec.json) の SHA-256 ハッシュ値（バイト単位）
	* `ens_hash_base64` — [include-ens.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-ens.js) の base64 リテラルの SHA-256 ハッシュ値
	* `nf_hash_base64` — [include-nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-nf.js) の base64 リテラルの SHA-256 ハッシュ値



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---