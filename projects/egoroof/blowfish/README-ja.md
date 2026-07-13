# Blowfish

[![npm package][npm-badge]][npm]

[npm-badge]: https://img.shields.io/npm/v/egoroof-blowfish.svg?style=flat-square
[npm]: https://www.npmjs.com/package/egoroof-blowfish

[Blowfish](<https://en.wikipedia.org/wiki/Blowfish_(cipher)>) はブラウザと Node.js 用の暗号化ライブラリです。

変更履歴は [CHANGELOG.md](https://github.com/egoroof/blowfish/blob/master/CHANGELOG.md) を参照してください。

## 目次

- [インストール](#installation)
  - [JS モジュール](#js-modules)
- [使い方](#usage)
  - [例](#example)
  - [ブロック暗号の動作モード](#block-cipher-mode-of-operation)
  - [パディング](#padding)
  - [戻り値の型](#return-type)

## インストール

最新バージョンは [こちら](https://unpkg.com/egoroof-blowfish) から取得するか、npm で：

```
npm install egoroof-blowfish --save
```

### JSモジュール

このライブラリは[ネイティブJSモジュール](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules)でのみ展開されるため、ブラウザではtypeが`module`の`script`を使用する必要があります:

```html
<script type="module">
  import { Blowfish } from 'https://your-host/blowfish.mjs';
  // your code here..
</script>
```

またはライブラリをコードにバンドルします。

Node.jsでは簡単にインポートできます：

```js
import { Blowfish } from 'egoroof-blowfish';
```

## 使用法

キー、IV、平文、暗号文を含むすべての入力データは `String` または `ArrayBuffer` / `Buffer` である必要があります。
文字列は絵文字を含むすべてのユニコードをサポートします ✨。

### 例

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

### 戻り値の型

メソッド `decode` が返すべきデータの型:

```js
Blowfish.TYPE.STRING; // (default) String
Blowfish.TYPE.UINT8_ARRAY; // Uint8Array
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-13

---