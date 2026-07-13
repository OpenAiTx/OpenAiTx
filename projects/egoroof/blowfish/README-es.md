# Blowfish

[![npm package][npm-badge]][npm]

[npm-badge]: https://img.shields.io/npm/v/egoroof-blowfish.svg?style=flat-square
[npm]: https://www.npmjs.com/package/egoroof-blowfish

Biblioteca de encriptación [Blowfish](<https://en.wikipedia.org/wiki/Blowfish_(cipher)>) para navegadores y Node.js.

Encuentra el registro de cambios en [CHANGELOG.md](https://github.com/egoroof/blowfish/blob/master/CHANGELOG.md)

## Tabla de Contenidos

- [Instalación](#installation)
  - [Módulos JS](#js-modules)
- [Uso](#usage)
  - [Ejemplo](#example)
  - [Modo de operación del cifrado por bloques](#block-cipher-mode-of-operation)
  - [Relleno](#padding)
  - [Tipo de retorno](#return-type)

## Instalación

Obtén la última versión [aquí](https://unpkg.com/egoroof-blowfish) o con npm:

```
npm install egoroof-blowfish --save
```

### Módulos JS

La biblioteca solo se implementa en [módulos JS nativos](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules), por lo que en los navegadores debes usar `script` con tipo `module`:

```html
<script type="module">
  import { Blowfish } from 'https://your-host/blowfish.mjs';
  // your code here..
</script>
```
O agrupe la biblioteca con su código.

En Nodejs se importa fácilmente:


```js
import { Blowfish } from 'egoroof-blowfish';
```

## Uso

Todos los datos de entrada, incluyendo la clave, IV, texto plano y texto cifrado, deben ser un `String` o `ArrayBuffer` / `Buffer`.
Los strings soportan todo unicode incluyendo emoji ✨.

### Ejemplo

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

### Tipo de retorno

Qué tipo de datos debe devolver el método `decode`:

```js
Blowfish.TYPE.STRING; // (default) String
Blowfish.TYPE.UINT8_ARRAY; // Uint8Array
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-13

---