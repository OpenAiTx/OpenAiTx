# ens-normalize.js
0 依赖 [以太坊域名服务](https://ens.domains/)（ENS）名称标准化工具。

`npm i @adraffy/ens-normalize` [&check;](https://www.npmjs.com/package/@adraffy/ens-normalize)

* 🏛️ 遵循 [**ENSIP-15**：ENS 名称标准化规范](https://docs.ens.domains/ensip/15)
	* Unicode: [`17.0.0`](./derive/data/17.0.0/) • CLDR: [`47`](./derive/data/CLDR-47/)
	* 其他实现：
		* Python — [namehash/**ens-normalize-python**](https://github.com/namehash/ens-normalize-python)
		* Rust — [sevenzing/**ens-normalize-rs**](https://github.com/sevenzing/ens-normalize-rs)
		* Zig — [evmts/**z-ens-normalize**](https://github.com/evmts/z-ens-normalize)
		* C# — [adraffy/**ENSNormalize.cs**](https://github.com/adraffy/ENSNormalize.cs)
		* Java — [adraffy/**ENSNormalize.java**](https://github.com/adraffy/ENSNormalize.java)
		* Swift – [adraffy/**ENSNormalize.swift**](https://github.com/adraffy/ENSNormalize.swift)
		* Go — [adraffy/**go-ens-normalize**](https://github.com/adraffy/go-ens-normalize)
		* Swift – [adraffy/**ENSNormalize.swift**](https://github.com/adraffy/ENSNormalize.swift)
	* 早期实现：
		* Javascript — [ensdomains/**eth-ens-namehash**](https://github.com/ensdomains/eth-ens-namehash)
	* [ENSIP-1 解析报告](https://adraffy.github.io/ens-norm-tests/test-breakdown/output-20230226/)	
* ✅️ 通过 **100%** [ENSIP-15 验证测试](https://adraffy.github.io/ens-normalize.js/test/validate.html)
* ✅️ 通过 **100%** [Unicode 标准化测试](https://adraffy.github.io/ens-normalize.js/test/report-nf.html)
* 压缩文件大小：
	* [`29KB`](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/index-xnf.min.js) — 原生 NFC 通过 [nf-native.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/nf-native.js) 使用 `String.normalize()` ⚠️
	* [`38KB` **默认**](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/index.min.js) — 自定义 NFC 通过 [nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/nf.js)
	* [`44KB`](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/all.min.js) *全部功能！* — 自定义 NFC + 子库：[parts.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/parts.js), [utils.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/utils.js)
* 包含应用：
	* [**解析器演示**](https://adraffy.github.io/ens-normalize.js/test/resolver.html) ⭐
	* [支持的表情符号](https://adraffy.github.io/ens-normalize.js/test/emoji.html)
	* [字符查看器](https://adraffy.github.io/ens-normalize.js/test/chars.html)
	* [混淆说明](https://adraffy.github.io/ens-normalize.js/test/confused.html)
* 相关项目：
	* [近期 .eth 注册](https://raffy.antistupid.com/eth/ens-regs.html) • [续费](https://raffy.antistupid.com/eth/ens-renews.html) • [过期](https://raffy.antistupid.com/eth/ens-exp.html)
	* [标签数据库](https://github.com/adraffy/ens-labels/) • [Labelhash⁻¹](https://adraffy.github.io/ens-labels/demo.html) • [暴力破解](https://raffy.antistupid.com/eth/ens-brute.html)
	* [表情符号频率探查器](https://raffy.antistupid.com/eth/ens-emoji-freq.html)
	* [adraffy/**punycode.js**](https://github.com/adraffy/punycode.js/) • [Punycode 编码器](https://adraffy.github.io/punycode.js/test/demo.html)
	* [adraffy/**keccak.js**](https://github.com/adraffy/keccak.js/) • [Keccak 哈希器](https://adraffy.github.io/keccak.js/test/demo.html)
	* [adraffy/**emoji.js**](https://github.com/adraffy/emoji.js/) • [表情符号解析器](https://adraffy.github.io/emoji.js/test/demo.html)
	* 更多链接见 [解析器演示](https://adraffy.github.io/ens-normalize.js/test/resolver.html) 底部

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
用完全限定的表情符号格式化名称：

```js
// works like ens_normalize()
// output ready for display
let pretty = ens_beautify('1⃣2⃣.eth'); 
// => "1️⃣2️⃣.eth"

// note: normalization is unchanged:
// ens_normalize(ens_beautify(x)) == ens_normalize(x)
```

规范化名称片段以进行[子字符串搜索](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./test/fragment.js)：
```js
// these fragments fail ens_normalize() 
// but will normalize fine as fragments
let frag1 = ens_normalize_fragment('AB--');    // expected error: label ext
let frag2 = ens_normalize_fragment('\u{303}'); // expected error: leading cm
let frag3 = ens_normalize_fragment('οо');      // expected error: mixture
```
基于输入的分词：

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
基于输出的分词：

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
生成一个已排序的（美化过的）支持的表情符号代码点数组：

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
判断一个字符是否不应直接打印：

```js
// number -> bool
should_escape(0x202E); // eg. RIGHT-TO-LEFT OVERRIDE => true
```
确定字符是否为组合标记：

```js
// number -> bool
is_combining_mark(0x20E3); // eg. COMBINING ENCLOSING KEYCAP => true
```

将代码点格式化为打印安全字符串：
```js
// number[] -> string
safe_str_from_cps([0x300, 0, 32, 97]); // "◌̀{00} a"
safe_str_from_cps(Array(100).fill(97), 4); // "aa…aa" => middle-truncated
```

## 构建

* 使用 `git clone` 克隆此仓库，然后运行 `npm install` 
* 按照 [/derive/](./derive/) 中的说明生成数据文件
	* 运行 `npm run derive` 
		* [spec.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/spec.json)
		* [nf.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/nf.json)
		* [nf-tests.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/nf-tests.json)
* 运行 `npm run make` — 压缩来自 [/derive/output/](./derive/output/) 的数据文件
	* [include-ens.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-ens.js)
	* [include-nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-nf.js)
	* [include-versions.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-versions.js)
* 按照 [/validate/](./validate/) 中的说明生成验证测试
	* 运行 `npm run validate`
		* [tests.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./validate/tests.json)
* 运行 `npm run test` — 执行验证测试
* 运行 `npm run build` — 创建 [/dist/](./dist/)
* 运行 `npm run rebuild` — 运行上述所有命令
* 运行 `npm run order` — 创建最优组顺序并重新构建

## 安全

* [构建](#build) 并与 [include-versions.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-versions.js) 进行比较
	* `spec_hash` — [spec.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/spec.json) 字节的 SHA-256
	* `ens_hash_base64` — [include-ens.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-ens.js) 的 base64 字面量的 SHA-256
	* `nf_hash_base64` — [include-nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-nf.js) 的 base64 字面量的 SHA-256


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---