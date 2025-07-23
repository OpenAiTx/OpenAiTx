
[![Node](https://img.shields.io/badge/-Node.js-808080?logo=node.js&colorA=404040&logoColor=66cc33)](https://www.npmjs.com/package/human-signals)
[![TypeScript](https://img.shields.io/badge/-Typed-808080?logo=typescript&colorA=404040&logoColor=0096ff)](/src/main.d.ts)
[![Codecov](https://img.shields.io/badge/-Tested%20100%25-808080?logo=codecov&colorA=404040)](https://codecov.io/gh/ehmicky/human-signals)
[![Mastodon](https://img.shields.io/badge/-Mastodon-808080.svg?logo=mastodon&colorA=404040&logoColor=9590F9)](https://fosstodon.org/@ehmicky)
[![Medium](https://img.shields.io/badge/-Medium-808080.svg?logo=medium&colorA=404040)](https://medium.com/@ehmicky)

사용자 친화적인 프로세스 신호.

이것은 각 신호에 대한 정보를 포함한 알려진 프로세스 신호들의 맵입니다.

[`os.constants.signals`](https://nodejs.org/api/os.html#os_signal_constants)와는 달리,
이 맵은 다음을 포함합니다:

- 사용자 친화적인 [설명](#description)
- [기본 동작](#action), 그리고 이것들이 [방지될 수 있는지 여부](#forced)
- 현재 OS에서 신호가 [지원되는지 여부](#supported)

# 예제


```js
import { signalsByName, signalsByNumber } from 'human-signals'

console.log(signalsByName.SIGINT)
// {
//   name: 'SIGINT',
//   number: 2,
//   description: 'User interruption with CTRL-C',
//   supported: true,
//   action: 'terminate',
//   forced: false,
//   standard: 'ansi'
// }

console.log(signalsByNumber[8])
// {
//   name: 'SIGFPE',
//   number: 8,
//   description: 'Floating point arithmetic error',
//   supported: true,
//   action: 'core',
//   forced: false,
//   standard: 'ansi'
// }
```


# 설치


```bash
npm install human-signals
```
This package works in Node.js >=18.18.0.

This is an ES module. It must be loaded using
[an `import` or `import()` statement](https://gist.github.com/sindresorhus/a39789f98801d908bbc7ff3ecc99d99c),
not `require()`. If TypeScript is used, it must be configured to
[output ES modules](https://www.typescriptlang.org/docs/handbook/esm-node.html),
not CommonJS.

# Usage

## signalsByName

_Type_: `object`

키가 신호 [이름](#name)이고 값이
[신호 객체](#signal)인 객체입니다.

## signalsByNumber

_Type_: `object`

키가 신호 [번호](#number)이고 값이
[신호 객체](#signal)인 객체입니다.

## signal

_Type_: `object`

다음 속성을 가진 신호 객체입니다.

### name

_Type_: `string`

신호의 표준 이름, 예를 들어 `'SIGINT'`.

### number

_Type_: `number`

신호의 코드 번호, 예를 들어 `2`. 대부분의 `number`는
플랫폼 간 공통이지만 일부는 OS마다 다릅니다.

### description

_Type_: `string`

신호에 대한 이해하기 쉬운 설명, 예를 들어
`'User interruption with CTRL-C'`.

### supported

_Type_: `boolean`

현재 OS가 Node.js에서 이 신호를
[`process.on(name, handler)`](https://nodejs.org/api/process.html#process_signal_events)으로 처리할 수 있는지 여부.

지원되는 신호 목록은
[OS별로 다릅니다](https://github.com/ehmicky/cross-platform-node-guide/blob/main/docs/6_networking_ipc/signals.md#cross-platform-signals).

### action

_Type_: `string`\
_Enum_: `'terminate'`, `'core'`, `'ignore'`, `'pause'`, `'unpause'`

이 신호가 처리되지 않았을 때의 기본 동작입니다.

### forced

_Type_: `boolean`

신호의 기본 동작을 막을 수 있는지 여부입니다. `SIGTERM`, `SIGKILL` 및 `SIGSTOP`의 경우 `true`입니다.

### standard

_Type_: `string`\
_Enum_: `'ansi'`, `'posix'`, `'bsd'`, `'systemv'`, `'other'`

어떤 표준이 이 신호를 정의했는지입니다.

# Support

질문이 있으면 _주저하지 말고_ [GitHub에서 이슈를 제출하세요](../../issues).

개인 배경과 상관없이 모두 환영합니다. 긍정적이고
포괄적인 환경을 조성하기 위해
[행동 강령](https://raw.githubusercontent.com/ehmicky/human-signals/main/CODE_OF_CONDUCT.md)을 시행합니다.

# Contributing

이 프로젝트는 ❤️와 함께 만들어졌습니다. 가장 간단한 환원 방법은 별을 주고
온라인에서 공유하는 것입니다.

문서가 불명확하거나 오타가 있으면 페이지의 `Edit`
버튼(연필 아이콘)을 클릭하여 수정 제안을 해주세요.

버그 수정이나 새 기능 추가를 도와주고 싶다면
[가이드라인](https://raw.githubusercontent.com/ehmicky/human-signals/main/CONTRIBUTING.md)을 확인하세요. 풀 리퀘스트를 환영합니다!


감사의 말씀을 우리 훌륭한 기여자들에게 전합니다:

<!-- ALL-CONTRIBUTORS-LIST:START -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tbody>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://fosstodon.org/@ehmicky"><img src="https://avatars2.githubusercontent.com/u/8136211?v=4?s=100" width="100px;" alt="ehmicky"/><br /><sub><b>ehmicky</b></sub></a><br /><a href="https://github.com/ehmicky/human-signals/commits?author=ehmicky" title="Code">💻</a> <a href="#design-ehmicky" title="Design">🎨</a> <a href="#ideas-ehmicky" title="Ideas, Planning, & Feedback">🤔</a> <a href="https://github.com/ehmicky/human-signals/commits?author=ehmicky" title="Documentation">📖</a></td>
      <td align="center" valign="top" width="14.28%"><a href="http://www.electrovir.com"><img src="https://avatars0.githubusercontent.com/u/1205860?v=4?s=100" width="100px;" alt="electrovir"/><br /><sub><b>electrovir</b></sub></a><br /><a href="https://github.com/ehmicky/human-signals/commits?author=electrovir" title="Code">💻</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://fzy.se"><img src="https://avatars.githubusercontent.com/u/2656517?v=4?s=100" width="100px;" alt="Felix Zedén Yverås"/><br /><sub><b>Felix Zedén Yverås</b></sub></a><br /><a href="https://github.com/ehmicky/human-signals/commits?author=FelixZY" title="Code">💻</a> <a href="https://github.com/ehmicky/human-signals/commits?author=FelixZY" title="Tests">⚠️</a></td>
    </tr>
  </tbody>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---