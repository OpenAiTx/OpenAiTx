# ens-normalize.js
Normalizador de Nombres de [Ethereum Name Service](https://ens.domains/) (ENS) sin dependencias.

`npm i @adraffy/ens-normalize` [&check;](https://www.npmjs.com/package/@adraffy/ens-normalize)

* 🏛️ Sigue [**ENSIP-15**: Estándar de Normalización de Nombres ENS](https://docs.ens.domains/ensip/15)
	* Unicode: [`17.0.0`](./derive/data/17.0.0/) • CLDR: [`47`](./derive/data/CLDR-47/)
	* Otras implementaciones:
		* Python — [namehash/**ens-normalize-python**](https://github.com/namehash/ens-normalize-python)
		* Rust — [sevenzing/**ens-normalize-rs**](https://github.com/sevenzing/ens-normalize-rs)
		* Zig — [evmts/**z-ens-normalize**](https://github.com/evmts/z-ens-normalize)
		* C# — [adraffy/**ENSNormalize.cs**](https://github.com/adraffy/ENSNormalize.cs)
		* Java — [adraffy/**ENSNormalize.java**](https://github.com/adraffy/ENSNormalize.java)
		* Swift – [adraffy/**ENSNormalize.swift**](https://github.com/adraffy/ENSNormalize.swift)
		* Go — [adraffy/**go-ens-normalize**](https://github.com/adraffy/go-ens-normalize)
		* Swift – [adraffy/**ENSNormalize.swift**](https://github.com/adraffy/ENSNormalize.swift)
	* Implementación previa:
		* Javascript — [ensdomains/**eth-ens-namehash**](https://github.com/ensdomains/eth-ens-namehash)
	* [Informes de desglose de ENSIP-1](https://adraffy.github.io/ens-norm-tests/test-breakdown/output-20230226/)	
* ✅️ Pasa **100%** las [Pruebas de Validación ENSIP-15](https://adraffy.github.io/ens-normalize.js/test/validate.html)
* ✅️ Pasa **100%** las [Pruebas de Normalización Unicode](https://adraffy.github.io/ens-normalize.js/test/report-nf.html)
* Tamaños de archivo minificados: 
	* [`29KB`](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/index-xnf.min.js) — NFC nativo vía [nf-native.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/nf-native.js) usando `String.normalize()` ⚠️
	* [`38KB` **Por defecto**](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/index.min.js) — NFC personalizado vía [nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/nf.js)
	* [`44KB`](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/all.min.js) *¡Todo!* — NFC personalizado + subbibliotecas: [parts.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/parts.js), [utils.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/utils.js)
* Aplicaciones incluidas:
	* [**Demo del Resolver**](https://adraffy.github.io/ens-normalize.js/test/resolver.html) ⭐
	* [Emoji soportados](https://adraffy.github.io/ens-normalize.js/test/emoji.html)
	* [Visor de caracteres](https://adraffy.github.io/ens-normalize.js/test/chars.html)
	* [Explicador Confundido](https://adraffy.github.io/ens-normalize.js/test/confused.html)
* Proyectos relacionados:
	* [Registros recientes .eth](https://raffy.antistupid.com/eth/ens-regs.html) • [Renovaciones](https://raffy.antistupid.com/eth/ens-renews.html) • [Expiraciones](https://raffy.antistupid.com/eth/ens-exp.html)
	* [Base de datos de etiquetas](https://github.com/adraffy/ens-labels/) • [Labelhash⁻¹](https://adraffy.github.io/ens-labels/demo.html) • [Fuerza bruta](https://raffy.antistupid.com/eth/ens-brute.html)
	* [Explorador de frecuencia de emoji](https://raffy.antistupid.com/eth/ens-emoji-freq.html)
	* [adraffy/**punycode.js**](https://github.com/adraffy/punycode.js/) • [Codificador Punycode](https://adraffy.github.io/punycode.js/test/demo.html)
	* [adraffy/**keccak.js**](https://github.com/adraffy/keccak.js/) • [Hasher Keccak](https://adraffy.github.io/keccak.js/test/demo.html)
	* [adraffy/**emoji.js**](https://github.com/adraffy/emoji.js/) • [Parser de Emoji](https://adraffy.github.io/emoji.js/test/demo.html)
	* Más enlaces al final de [Demo del Resolver](https://adraffy.github.io/ens-normalize.js/test/resolver.html)

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
Formatee los nombres con emoji totalmente cualificado:

```js
// works like ens_normalize()
// output ready for display
let pretty = ens_beautify('1⃣2⃣.eth'); 
// => "1️⃣2️⃣.eth"

// note: normalization is unchanged:
// ens_normalize(ens_beautify(x)) == ens_normalize(x)
```
Normalizar fragmentos de nombres para [búsqueda de subcadenas](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./test/fragment.js):

```js
// these fragments fail ens_normalize() 
// but will normalize fine as fragments
let frag1 = ens_normalize_fragment('AB--');    // expected error: label ext
let frag2 = ens_normalize_fragment('\u{303}'); // expected error: leading cm
let frag3 = ens_normalize_fragment('οо');      // expected error: mixture
```
Tokenización basada en la entrada:

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
Tokenización basada en la salida:

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
Generar un arreglo ordenado de puntos de código emoji compatibles (embellecidos):

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
Determinar si un carácter no debe imprimirse directamente:

```js
// number -> bool
should_escape(0x202E); // eg. RIGHT-TO-LEFT OVERRIDE => true
```
Determinar si un carácter es una marca combinante:

```js
// number -> bool
is_combining_mark(0x20E3); // eg. COMBINING ENCLOSING KEYCAP => true
```
Formatear puntos de código como cadena segura para impresión:

```js
// number[] -> string
safe_str_from_cps([0x300, 0, 32, 97]); // "◌̀{00} a"
safe_str_from_cps(Array(100).fill(97), 4); // "aa…aa" => middle-truncated
```

## Construcción

* `git clone` este repositorio, luego `npm install` 
* Siga las instrucciones en [/derive/](./derive/) para generar archivos de datos
	* `npm run derive` 
		* [spec.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/spec.json)
		* [nf.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/nf.json)
		* [nf-tests.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/nf-tests.json)
* `npm run make` — comprime archivos de datos de [/derive/output/](./derive/output/)
	* [include-ens.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-ens.js)
	* [include-nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-nf.js)
	* [include-versions.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-versions.js)
* Siga las instrucciones en [/validate/](./validate/) para generar pruebas de validación
	* `npm run validate`
		* [tests.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./validate/tests.json)
* `npm run test` — realizar pruebas de validación
* `npm run build` — crear [/dist/](./dist/)
* `npm run rebuild` — ejecutar todos los comandos anteriores
* `npm run order` — crear un orden óptimo de grupos y reconstruir de nuevo

## Seguridad

* [Construcción](#build) y comparación con [include-versions.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-versions.js)
	* `spec_hash` — SHA-256 de los bytes de [spec.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/spec.json)
	* `ens_hash_base64` — SHA-256 del literal base64 de [include-ens.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-ens.js)
	* `nf_hash_base64` — SHA-256 del literal base64 de [include-nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-nf.js)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---