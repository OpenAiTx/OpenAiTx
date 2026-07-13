# Blowfish

[![npm package][npm-badge]][npm]

[npm-badge]: https://img.shields.io/npm/v/egoroof-blowfish.svg?style=flat-square
[npm]: https://www.npmjs.com/package/egoroof-blowfish

Bibliothèque de chiffrement [Blowfish](<https://en.wikipedia.org/wiki/Blowfish_(cipher)>) pour navigateurs et Node.js.

Trouvez le journal des modifications dans [CHANGELOG.md](https://github.com/egoroof/blowfish/blob/master/CHANGELOG.md)

## Table des matières

- [Installation](#installation)
  - [Modules JS](#js-modules)
- [Utilisation](#usage)
  - [Exemple](#example)
  - [Mode de fonctionnement du chiffrement par bloc](#block-cipher-mode-of-operation)
  - [Remplissage](#padding)
  - [Type de retour](#return-type)

## Installation

Prenez la dernière version [ici](https://unpkg.com/egoroof-blowfish) ou avec npm :

```
npm install egoroof-blowfish --save
```

### Modules JS

La bibliothèque est uniquement déployée en [modules JS natifs](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules), donc dans les navigateurs, vous devez utiliser `script` avec le type `module` :

```html
<script type="module">
  import { Blowfish } from 'https://your-host/blowfish.mjs';
  // your code here..
</script>
```

Ou intégrez la bibliothèque à votre code.

En Nodejs, elle s’importe facilement :

```js
import { Blowfish } from 'egoroof-blowfish';
```

## Utilisation

Toutes les données d'entrée, y compris la clé, le vecteur d'initialisation, le texte en clair et le texte chiffré doivent être une `String` ou un `ArrayBuffer` / `Buffer`.
Les chaînes prennent en charge tous les caractères unicode, y compris les emoji ✨.

### Exemple

```js
import { Blowfish } from 'egoroof-blowfish';

const bf = new Blowfish('super key', Blowfish.MODE.ECB, Blowfish.PADDING.NULL); // only key isn't optional
bf.setIv('abcdefgh'); // optional for ECB mode; bytes length should be equal 8

const encoded = bf.encode('input text even with emoji 🎅');
const decoded = bf.decode(encoded, Blowfish.TYPE.STRING); // type is optional
```

### Block cipher mode of operation

https://en.wikipedia.org/wiki/Block_cipher_mode_of_operation

```js
Blowfish.MODE.ECB; // (default) Electronic Codebook
Blowfish.MODE.CBC; // Cipher Block Chaining
```

### Padding

http://www.di-mgt.com.au/cryptopad.html

```js
Blowfish.PADDING.PKCS5; // (default) Pad with bytes all of the same value as the number of padding bytes
Blowfish.PADDING.ONE_AND_ZEROS; // Pad with 0x80 followed by zero bytes
Blowfish.PADDING.LAST_BYTE; // Pad with zeroes except make the last byte equal to the number of padding bytes
Blowfish.PADDING.NULL; // Pad with zero (null) characters
Blowfish.PADDING.SPACES; // Pad with spaces
```

### Type de retour

Quel type de données la méthode `decode` doit-elle retourner :

```js
Blowfish.TYPE.STRING; // (default) String
Blowfish.TYPE.UINT8_ARRAY; // Uint8Array
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-13

---