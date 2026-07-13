# Blowfish

[![npm package][npm-badge]][npm]

[npm-badge]: https://img.shields.io/npm/v/egoroof-blowfish.svg?style=flat-square
[npm]: https://www.npmjs.com/package/egoroof-blowfish

브라우저와 Node.js용 [Blowfish](<https://en.wikipedia.org/wiki/Blowfish_(cipher)>) 암호화 라이브러리입니다.

변경 내역은 [CHANGELOG.md](https://github.com/egoroof/blowfish/blob/master/CHANGELOG.md)에서 확인하세요.

## 목차

- [설치](#installation)
  - [JS 모듈](#js-modules)
- [사용법](#usage)
  - [예제](#example)
  - [블록 암호 작동 모드](#block-cipher-mode-of-operation)
  - [패딩](#padding)
  - [반환 타입](#return-type)

## 설치

최신 버전은 [여기](https://unpkg.com/egoroof-blowfish)에서 받거나 npm으로 설치하세요:

```
npm install egoroof-blowfish --save
```

### JS 모듈

이 라이브러리는 [네이티브 JS 모듈](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules)로만 배포되므로, 브라우저에서는 `module` 타입의 `script`를 사용해야 합니다:

```html
<script type="module">
  import { Blowfish } from 'https://your-host/blowfish.mjs';
  // your code here..
</script>
```
또는 라이브러리를 코드에 번들로 포함하세요.

Nodejs에서는 쉽게 임포트할 수 있습니다:


```js
import { Blowfish } from 'egoroof-blowfish';
```

## 사용법

키, IV, 평문 및 암호문을 포함한 모든 입력 데이터는 `String` 또는 `ArrayBuffer` / `Buffer`여야 합니다.  
문자열은 이모지 ✨를 포함한 모든 유니코드를 지원합니다.

### 예제

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

### 반환 타입

`decode` 메서드가 반환해야 하는 데이터 타입:

```js
Blowfish.TYPE.STRING; // (default) String
Blowfish.TYPE.UINT8_ARRAY; // Uint8Array
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-13

---