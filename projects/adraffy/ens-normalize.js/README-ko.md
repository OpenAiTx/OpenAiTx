# ens-normalize.js
0-의존성 [Ethereum Name Service](https://ens.domains/) (ENS) 이름 정규화기.

`npm i @adraffy/ens-normalize` [&check;](https://www.npmjs.com/package/@adraffy/ens-normalize)

* 🏛️ [**ENSIP-15**: ENS 이름 정규화 표준](https://docs.ens.domains/ensip/15)을 준수
	* 유니코드: [`17.0.0`](./derive/data/17.0.0/) • CLDR: [`47`](./derive/data/CLDR-47/)
	* 기타 구현체:
		* 파이썬 — [namehash/**ens-normalize-python**](https://github.com/namehash/ens-normalize-python)
		* 러스트 — [sevenzing/**ens-normalize-rs**](https://github.com/sevenzing/ens-normalize-rs)
		* 직(Zig) — [evmts/**z-ens-normalize**](https://github.com/evmts/z-ens-normalize)
		* C# — [adraffy/**ENSNormalize.cs**](https://github.com/adraffy/ENSNormalize.cs)
		* 자바 — [adraffy/**ENSNormalize.java**](https://github.com/adraffy/ENSNormalize.java)
		* 스위프트 – [adraffy/**ENSNormalize.swift**](https://github.com/adraffy/ENSNormalize.swift)
		* 고 — [adraffy/**go-ens-normalize**](https://github.com/adraffy/go-ens-normalize)
		* 스위프트 – [adraffy/**ENSNormalize.swift**](https://github.com/adraffy/ENSNormalize.swift)
	* 이전 구현체:
		* 자바스크립트 — [ensdomains/**eth-ens-namehash**](https://github.com/ensdomains/eth-ens-namehash)
	* [ENSIP-1 분해 보고서](https://adraffy.github.io/ens-norm-tests/test-breakdown/output-20230226/)	
* ✅️ **100%** [ENSIP-15 검증 테스트](https://adraffy.github.io/ens-normalize.js/test/validate.html) 통과
* ✅️ **100%** [유니코드 정규화 테스트](https://adraffy.github.io/ens-normalize.js/test/report-nf.html) 통과
* 압축 파일 크기: 
	* [`29KB`](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/index-xnf.min.js) — `String.normalize()`를 사용한 [nf-native.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/nf-native.js) 기반 네이티브 NFC ⚠️
	* [`38KB` **기본**](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/index.min.js) — [nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/nf.js) 기반 커스텀 NFC
	* [`44KB`](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/all.min.js) *모두 포함!* — 커스텀 NFC + 서브 라이브러리: [parts.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/parts.js), [utils.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/utils.js)
* 포함된 앱:
	* [**리졸버 데모**](https://adraffy.github.io/ens-normalize.js/test/resolver.html) ⭐
	* [지원하는 이모지](https://adraffy.github.io/ens-normalize.js/test/emoji.html)
	* [문자 뷰어](https://adraffy.github.io/ens-normalize.js/test/chars.html)
	* [혼란스러운 설명기](https://adraffy.github.io/ens-normalize.js/test/confused.html)
* 관련 프로젝트:
	* [최근 .eth 등록](https://raffy.antistupid.com/eth/ens-regs.html) • [갱신](https://raffy.antistupid.com/eth/ens-renews.html) • [만료](https://raffy.antistupid.com/eth/ens-exp.html)
	* [라벨 데이터베이스](https://github.com/adraffy/ens-labels/) • [Labelhash⁻¹](https://adraffy.github.io/ens-labels/demo.html) • [무차별 대입](https://raffy.antistupid.com/eth/ens-brute.html)
	* [이모지 빈도 탐색기](https://raffy.antistupid.com/eth/ens-emoji-freq.html)
	* [adraffy/**punycode.js**](https://github.com/adraffy/punycode.js/) • [Punycode 인코더](https://adraffy.github.io/punycode.js/test/demo.html)
	* [adraffy/**keccak.js**](https://github.com/adraffy/keccak.js/) • [Keccak 해시](https://adraffy.github.io/keccak.js/test/demo.html)
	* [adraffy/**emoji.js**](https://github.com/adraffy/emoji.js/) • [이모지 파서](https://adraffy.github.io/emoji.js/test/demo.html)
	* 더 많은 링크는 [리졸버 데모](https://adraffy.github.io/ens-normalize.js/test/resolver.html) 하단에 있음

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

이모지로 완전히 한정된 형식 이름:
```js
// works like ens_normalize()
// output ready for display
let pretty = ens_beautify('1⃣2⃣.eth'); 
// => "1️⃣2️⃣.eth"

// note: normalization is unchanged:
// ens_normalize(ens_beautify(x)) == ens_normalize(x)
```

[부분 문자열 검색](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./test/fragment.js)을 위한 이름 조각 정규화:
```js
// these fragments fail ens_normalize() 
// but will normalize fine as fragments
let frag1 = ens_normalize_fragment('AB--');    // expected error: label ext
let frag2 = ens_normalize_fragment('\u{303}'); // expected error: leading cm
let frag3 = ens_normalize_fragment('οо');      // expected error: mixture
```
입력 기반 토큰화:

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
출력 기반 토크나이제이션:

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

지원되는 이모지 코드포인트의 정렬된 배열(보기 좋게) 생성:
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

문자가 직접 출력되지 않아야 하는지 확인하십시오:
```js
// number -> bool
should_escape(0x202E); // eg. RIGHT-TO-LEFT OVERRIDE => true
```

문자가 결합 부호인지 확인:
```js
// number -> bool
is_combining_mark(0x20E3); // eg. COMBINING ENCLOSING KEYCAP => true
```

코드포인트를 출력 안전 문자열로 포맷:
```js
// number[] -> string
safe_str_from_cps([0x300, 0, 32, 97]); // "◌̀{00} a"
safe_str_from_cps(Array(100).fill(97), 4); // "aa…aa" => middle-truncated
```
## 빌드

* 이 저장소를 `git clone` 한 후, `npm install` 실행
* [/derive/](./derive/) 내 지침에 따라 데이터 파일 생성
	* `npm run derive` 
		* [spec.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/spec.json)
		* [nf.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/nf.json)
		* [nf-tests.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/nf-tests.json)
* `npm run make` — [/derive/output/](./derive/output/)에서 데이터 파일 압축
	* [include-ens.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-ens.js)
	* [include-nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-nf.js)
	* [include-versions.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-versions.js)
* [/validate/](./validate/) 내 지침에 따라 검증 테스트 생성
	* `npm run validate`
		* [tests.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./validate/tests.json)
* `npm run test` — 검증 테스트 수행
* `npm run build` — [/dist/](./dist/) 생성
* `npm run rebuild` — 위 명령 모두 실행
* `npm run order` — 최적 그룹 순서 생성 후 다시 빌드

## 보안

* [빌드](#build) 후 [include-versions.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-versions.js)와 비교
	* `spec_hash` — [spec.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/spec.json) 바이트의 SHA-256
	* `ens_hash_base64` — [include-ens.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-ens.js) base64 리터럴의 SHA-256
	* `nf_hash_base64` — [include-nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-nf.js) base64 리터럴의 SHA-256



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---