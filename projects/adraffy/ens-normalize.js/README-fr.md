# ens-normalize.js
Normaliseur de noms [Ethereum Name Service](https://ens.domains/) (ENS) sans dépendance.

`npm i @adraffy/ens-normalize` [&check;](https://www.npmjs.com/package/@adraffy/ens-normalize)

* 🏛️ Conforme à [**ENSIP-15** : Norme de normalisation des noms ENS](https://docs.ens.domains/ensip/15)
	* Unicode : [`17.0.0`](./derive/data/17.0.0/) • CLDR : [`47`](./derive/data/CLDR-47/)
	* Autres implémentations :
		* Python — [namehash/**ens-normalize-python**](https://github.com/namehash/ens-normalize-python)
		* Rust — [sevenzing/**ens-normalize-rs**](https://github.com/sevenzing/ens-normalize-rs)
		* Zig — [evmts/**z-ens-normalize**](https://github.com/evmts/z-ens-normalize)
		* C# — [adraffy/**ENSNormalize.cs**](https://github.com/adraffy/ENSNormalize.cs)
		* Java — [adraffy/**ENSNormalize.java**](https://github.com/adraffy/ENSNormalize.java)
		* Swift – [adraffy/**ENSNormalize.swift**](https://github.com/adraffy/ENSNormalize.swift)
		* Go — [adraffy/**go-ens-normalize**](https://github.com/adraffy/go-ens-normalize)
		* Swift – [adraffy/**ENSNormalize.swift**](https://github.com/adraffy/ENSNormalize.swift)
	* Implémentation antérieure :
		* Javascript — [ensdomains/**eth-ens-namehash**](https://github.com/ensdomains/eth-ens-namehash)
	* [Rapports détaillés de ENSIP-1](https://adraffy.github.io/ens-norm-tests/test-breakdown/output-20230226/)	
* ✅️ Passe **100%** des [Tests de validation ENSIP-15](https://adraffy.github.io/ens-normalize.js/test/validate.html)
* ✅️ Passe **100%** des [Tests de normalisation Unicode](https://adraffy.github.io/ens-normalize.js/test/report-nf.html)
* Tailles des fichiers minifiés : 
	* [`29KB`](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/index-xnf.min.js) — NFC natif via [nf-native.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/nf-native.js) utilisant `String.normalize()` ⚠️
	* [`38KB` **Par défaut**](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/index.min.js) — NFC personnalisé via [nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/nf.js)
	* [`44KB`](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./dist/all.min.js) *Tout !* — NFC personnalisé + sous-bibliothèques : [parts.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/parts.js), [utils.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/utils.js)
* Applications incluses :
	* [**Démo du Résolveur**](https://adraffy.github.io/ens-normalize.js/test/resolver.html) ⭐
	* [Emoji supportés](https://adraffy.github.io/ens-normalize.js/test/emoji.html)
	* [Visionneuse de caractères](https://adraffy.github.io/ens-normalize.js/test/chars.html)
	* [Explicateur Confus](https://adraffy.github.io/ens-normalize.js/test/confused.html)
* Projets associés :
	* [Inscriptions .eth récentes](https://raffy.antistupid.com/eth/ens-regs.html) • [Renouvellements](https://raffy.antistupid.com/eth/ens-renews.html) • [Expirations](https://raffy.antistupid.com/eth/ens-exp.html)
	* [Base de données des labels](https://github.com/adraffy/ens-labels/) • [Labelhash⁻¹](https://adraffy.github.io/ens-labels/demo.html) • [Force brute](https://raffy.antistupid.com/eth/ens-brute.html)
	* [Explorateur de fréquence des emojis](https://raffy.antistupid.com/eth/ens-emoji-freq.html)
	* [adraffy/**punycode.js**](https://github.com/adraffy/punycode.js/) • [Codeur Punycode](https://adraffy.github.io/punycode.js/test/demo.html)
	* [adraffy/**keccak.js**](https://github.com/adraffy/keccak.js/) • [Hacheur Keccak](https://adraffy.github.io/keccak.js/test/demo.html)
	* [adraffy/**emoji.js**](https://github.com/adraffy/emoji.js/) • [Parseur d’Emoji](https://adraffy.github.io/emoji.js/test/demo.html)
	* Plus de liens en bas de la [Démo du Résolveur](https://adraffy.github.io/ens-normalize.js/test/resolver.html)

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
Formatez les noms avec des émojis pleinement qualifiés :

```js
// works like ens_normalize()
// output ready for display
let pretty = ens_beautify('1⃣2⃣.eth'); 
// => "1️⃣2️⃣.eth"

// note: normalization is unchanged:
// ens_normalize(ens_beautify(x)) == ens_normalize(x)
```

Normaliser les fragments de nom pour la [recherche par sous-chaîne](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./test/fragment.js) :
```js
// these fragments fail ens_normalize() 
// but will normalize fine as fragments
let frag1 = ens_normalize_fragment('AB--');    // expected error: label ext
let frag2 = ens_normalize_fragment('\u{303}'); // expected error: leading cm
let frag3 = ens_normalize_fragment('οо');      // expected error: mixture
```

Tokenisation basée sur l'entrée :
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
Tokenisation basée sur la sortie :

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

Générez un tableau trié des points de code emoji pris en charge (embellie) :
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
Déterminez si un caractère ne doit pas être imprimé directement :

```js
// number -> bool
should_escape(0x202E); // eg. RIGHT-TO-LEFT OVERRIDE => true
```

Déterminer si un caractère est un signe combinant :
```js
// number -> bool
is_combining_mark(0x20E3); // eg. COMBINING ENCLOSING KEYCAP => true
```

Formater les points de code comme une chaîne imprimable :
```js
// number[] -> string
safe_str_from_cps([0x300, 0, 32, 97]); // "◌̀{00} a"
safe_str_from_cps(Array(100).fill(97), 4); // "aa…aa" => middle-truncated
```

## Construction

* `git clone` ce dépôt, puis `npm install`  
* Suivez les instructions dans [/derive/](./derive/) pour générer les fichiers de données  
	* `npm run derive`  
		* [spec.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/spec.json)  
		* [nf.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/nf.json)  
		* [nf-tests.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/nf-tests.json)  
* `npm run make` — compresse les fichiers de données depuis [/derive/output/](./derive/output/)  
	* [include-ens.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-ens.js)  
	* [include-nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-nf.js)  
	* [include-versions.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-versions.js)  
* Suivez les instructions dans [/validate/](./validate/) pour générer les tests de validation  
	* `npm run validate`  
		* [tests.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./validate/tests.json)  
* `npm run test` — exécute les tests de validation  
* `npm run build` — crée [/dist/](./dist/)  
* `npm run rebuild` — exécute toutes les commandes ci-dessus  
* `npm run order` — crée un ordre optimal des groupes et reconstruit  

## Sécurité

* [Construire](#build) et comparer avec [include-versions.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-versions.js)  
	* `spec_hash` — SHA-256 des octets de [spec.json](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./derive/output/spec.json)  
	* `ens_hash_base64` — SHA-256 du littéral base64 de [include-ens.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-ens.js)  
	* `nf_hash_base64` — SHA-256 du littéral base64 de [include-nf.js](https://raw.githubusercontent.com/adraffy/ens-normalize.js/main/./src/include-nf.js)  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---