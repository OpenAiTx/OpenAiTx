<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/ehmicky/design/main/log-process-errors/log-process-errors_dark.svg"/>
  <img alt="log-process-errors 로고" src="https://raw.githubusercontent.com/ehmicky/design/main/log-process-errors/log-process-errors.svg" width="500"/>
</picture>

[![Node](https://img.shields.io/badge/-Node.js-808080?logo=node.js&colorA=404040&logoColor=66cc33)](https://www.npmjs.com/package/log-process-errors)
[![TypeScript](https://img.shields.io/badge/-Typed-808080?logo=typescript&colorA=404040&logoColor=0096ff)](/src/main.d.ts)
[![Codecov](https://img.shields.io/badge/-Tested%20100%25-808080?logo=codecov&colorA=404040)](https://codecov.io/gh/ehmicky/log-process-errors)
[![Mastodon](https://img.shields.io/badge/-Mastodon-808080.svg?logo=mastodon&colorA=404040&logoColor=9590F9)](https://fosstodon.org/@ehmicky)
[![Medium](https://img.shields.io/badge/-Medium-808080.svg?logo=medium&colorA=404040)](https://medium.com/@ehmicky)

[📰 Medium 글.](https://medium.com/@ehmicky/node-js-process-errors-are-broken-193980f0a77b)

Node.js 프로세스 오류에 ❤️를 보여주세요.

이 패키지는 프로세스 오류를 개선합니다:
[잡히지 않은](https://nodejs.org/api/process.html#process_event_uncaughtexception)
예외,
[처리되지 않은](https://nodejs.org/api/process.html#process_event_unhandledrejection)
프로미스, 너무 늦게
[처리된](https://nodejs.org/api/process.html#process_event_rejectionhandled)
프로미스 및 [경고](https://nodejs.org/api/process.html#process_event_warning).

# 기능

- 경고 및
  [`rejectionHandled`](https://nodejs.org/api/process.html#process_event_rejectionhandled)
  에 대한 스택 추적
- 모든 프로세스 오류에 대해 [단일 이벤트 핸들러](#onerror)
- [중복된](#onerror) 프로세스 오류 무시
- 잘못된 오류 [정규화](#error)
- [프로세스 종료](#exit)이 우아하며 방지 가능

# 설치

프로덕션 코드(예: 서버)는 이 패키지를 프로덕션 또는
개발 의존성으로 설치할 수 있습니다:
```bash
npm install log-process-errors
```
그러나, 라이브러리는 이것을 개발 의존성으로 설치해야 합니다:


```bash
npm install -D log-process-errors
```
<translate-content>
이는 로깅이 전역적으로 수정되기 때문이며, 라이브러리 사용자는 이러한 부작용을 예상하지 못할 수 있습니다. 또한, 이는 라이브러리 간 충돌을 초래할 수 있습니다.

이 패키지는 Node.js >=18.18.0에서 작동합니다.

이것은 ES 모듈입니다. 반드시
[import 또는 import() 문](https://gist.github.com/sindresorhus/a39789f98801d908bbc7ff3ecc99d99c)을 사용하여 로드해야 하며,
require()를 사용하면 안 됩니다. TypeScript를 사용하는 경우,
[ES 모듈을 출력하도록](https://www.typescriptlang.org/docs/handbook/esm-node.html)
설정해야 하며, CommonJS가 아니어야 합니다.

# API

## logProcessErrors(options?)

[`options`](#options) `객체?`\
_반환 값_: `() => void`

프로세스 오류 처리를 시작합니다.
</translate-content>

```js
import logProcessErrors from 'log-process-errors'
logProcessErrors(options)
```
<translate-content>
반환 값은 Node.js의 기본 동작을 복원합니다.
</translate-content>
```js
const restore = logProcessErrors(options)
restore()
```
## 옵션

### exit

_유형_: `boolean`

[처리되지 않은 예외](https://nodejs.org/api/process.html#process_event_uncaughtexception)
또는
[처리되지 않은 프로미스](https://nodejs.org/api/process.html#process_event_unhandledrejection)
발생 시 프로세스를 종료할지 여부.

다른 라이브러리가 해당 이벤트를 수신하는 경우 기본값은 `false`이며,
그들이 종료를 수행할 수 있도록 합니다. 그렇지 않으면 `true`입니다.

일부 작업이 아직 진행 중인 경우, 종료는 최대 3초 동안 완료를 기다립니다.

### onError

_유형_: `(error, event) => Promise<void> | void`\
_기본값_: `console.error(error)`

프로세스 오류가 발생할 때마다 호출되는 함수입니다. 중복 프로세스 오류는 무시됩니다.



```js
// Log process errors with Winston instead
logProcessErrors({
  onError: (error, event) => {
    winstonLogger.error(error.stack)
  },
})
```
#### error

_Type_: `Error`

프로세스 오류입니다. 이는
[정규화된](https://github.com/ehmicky/normalize-exception) 오류 인스턴스임이 보장됩니다.
[event](#event)의 간단한 설명도 메시지에 추가됩니다.

#### event

_Type_: `Event`

다음 중 프로세스 이벤트 이름:
[`'uncaughtException'`](https://nodejs.org/api/process.html#process_event_uncaughtexception),
[`'unhandledRejection'`](https://nodejs.org/api/process.html#process_event_unhandledrejection),
[`'rejectionHandled'`](https://nodejs.org/api/process.html#process_event_rejectionhandled),
[`'warning'`](https://nodejs.org/api/process.html#process_event_warning).

# 관련 프로젝트

- [`modern-errors`](https://github.com/ehmicky/modern-errors): 오류를
  간단하고 안정적이며 일관되게 처리
- [`modern-errors-process`](https://github.com/ehmicky/modern-errors-process):
  프로세스 오류 처리
- [`error-custom-class`](https://github.com/ehmicky/error-custom-class): 하나의
  오류 클래스 생성
- [`error-class-utils`](https://github.com/ehmicky/error-class-utils): 오류 클래스
  적절히 생성하는 유틸리티
- [`error-serializer`](https://github.com/ehmicky/error-serializer): 오류를 일반
  객체로부터/일반 객체로 변환
- [`normalize-exception`](https://github.com/ehmicky/normalize-exception):
  예외/오류 정규화
- [`is-error-instance`](https://github.com/ehmicky/is-error-instance): 값이
  `Error` 인스턴스인지 확인
- [`merge-error-cause`](https://github.com/ehmicky/merge-error-cause): 오류와
  그 `cause` 병합
- [`set-error-class`](https://github.com/ehmicky/set-error-class): 오류 클래스
  적절히 업데이트
- [`set-error-message`](https://github.com/ehmicky/set-error-message): 오류 메시지
  적절히 업데이트
- [`wrap-error-message`](https://github.com/ehmicky/wrap-error-message):
  오류 메시지 적절히 감싸기
- [`set-error-props`](https://github.com/ehmicky/set-error-props): 오류 속성
  적절히 업데이트
- [`set-error-stack`](https://github.com/ehmicky/set-error-stack): 오류 스택
  적절히 업데이트
- [`error-cause-polyfill`](https://github.com/ehmicky/error-cause-polyfill):
  `error.cause` 폴리필
- [`handle-cli-error`](https://github.com/ehmicky/handle-cli-error): 💣 CLI
  애플리케이션용 오류 처리기 💥
- [`beautiful-error`](https://github.com/ehmicky/beautiful-error): 오류 메시지와
  스택 예쁘게 출력
- [`error-http-response`](https://github.com/ehmicky/error-http-response):
  HTTP 오류 응답 생성
- [`winston-error-format`](https://github.com/ehmicky/winston-error-format):
  Winston으로 오류 로그 기록

# 지원

질문이 있으면, _주저하지 말고_ [GitHub에서 이슈 제출](../../issues)해 주세요.

개인 배경과 관계없이 모두 환영합니다. 긍정적이고 포용적인 환경 조성을 위해
[행동 강령](https://raw.githubusercontent.com/ehmicky/log-process-errors/main/CODE_OF_CONDUCT.md)을 시행합니다.

# 기여

이 프로젝트는 ❤️와 함께 만들어졌습니다. 가장 간단한 보답 방법은 별을 주고
온라인에서 공유하는 것입니다.

문서가 불명확하거나 오타가 있으면, 페이지의 `Edit` 버튼(연필 아이콘)을 클릭해
수정 제안을 해 주세요.

버그 수정이나 새 기능 추가를 도와주고 싶다면,
[가이드라인](https://raw.githubusercontent.com/ehmicky/log-process-errors/main/CONTRIBUTING.md)을
확인해 주세요. 풀 리퀘스트 환영합니다!

멋진 기여자분들께 감사드립니다:

<!-- ALL-CONTRIBUTORS-LIST:START -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
    <td align="center"><a href="https://fosstodon.org/@ehmicky"><img src="https://avatars2.githubusercontent.com/u/8136211?v=4" width="100px;" alt=""/><br /><sub><b>ehmicky</b></sub></a><br /><a href="https://github.com/ehmicky/log-process-errors/commits?author=ehmicky" title="Code">💻</a> <a href="#design-ehmicky" title="Design">🎨</a> <a href="#ideas-ehmicky" title="Ideas, Planning, & Feedback">🤔</a> <a href="https://github.com/ehmicky/log-process-errors/commits?author=ehmicky" title="Documentation">📖</a></td>
    <td align="center"><a href="https://svachon.com"><img src="https://avatars0.githubusercontent.com/u/170197?v=4" width="100px;" alt=""/><br /><sub><b>Steven Vachon</b></sub></a><br /><a href="#question-stevenvachon" title="Answering Questions">💬</a></td>
    <td align="center"><a href="https://github.com/Hongarc"><img src="https://avatars1.githubusercontent.com/u/19208123?v=4" width="100px;" alt=""/><br /><sub><b>Hongarc</b></sub></a><br /><a href="https://github.com/ehmicky/log-process-errors/commits?author=Hongarc" title="Documentation">📖</a> <a href="https://github.com/ehmicky/log-process-errors/commits?author=Hongarc" title="Code">💻</a></td>
    <td align="center"><a href="https://github.com/abrenneke"><img src="https://avatars0.githubusercontent.com/u/342540?v=4" width="100px;" alt=""/><br /><sub><b>Andy Brenneke</b></sub></a><br /><a href="https://github.com/ehmicky/log-process-errors/issues?q=author%3Aabrenneke" title="Bug reports">🐛</a></td>
  </tr>
</table>

<!-- markdownlint-enable -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---