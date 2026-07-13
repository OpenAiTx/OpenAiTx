# Blowfish

[![npm package][npm-badge]][npm]

[npm-badge]: https://img.shields.io/npm/v/egoroof-blowfish.svg?style=flat-square
[npm]: https://www.npmjs.com/package/egoroof-blowfish

[Blowfish](<https://en.wikipedia.org/wiki/Blowfish_(cipher)>) 加密库，适用于浏览器和 Node.js。

在 [CHANGELOG.md](https://github.com/egoroof/blowfish/blob/master/CHANGELOG.md) 中查看更新日志

## 目录

- [安装](#installation)
  - [JS 模块](#js-modules)
- [用法](#usage)
  - [示例](#example)
  - [分组密码工作模式](#block-cipher-mode-of-operation)
  - [填充](#padding)
  - [返回类型](#return-type)

## 安装

获取最新版本 [这里](https://unpkg.com/egoroof-blowfish) 或使用 npm：

```
npm install egoroof-blowfish --save
```

### JS 模块

该库仅以[原生 JS 模块](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules)形式部署，因此在浏览器中必须使用 type 为 `module` 的 `script`：

```html
<script type="module">
  import { Blowfish } from 'https://your-host/blowfish.mjs';
  // your code here..
</script>
```
或者将库打包到你的代码中。

在 Nodejs 中它可以轻松导入：


```js
import { Blowfish } from 'egoroof-blowfish';
```

## 用法

所有输入数据包括密钥、IV、明文和密文应为 `String` 或 `ArrayBuffer` / `Buffer`。
字符串支持所有unicode字符，包括表情符号 ✨。

### 示例

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

### 返回类型

方法 `decode` 应返回哪种类型的数据：

```js
Blowfish.TYPE.STRING; // (default) String
Blowfish.TYPE.UINT8_ARRAY; // Uint8Array
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-13

---