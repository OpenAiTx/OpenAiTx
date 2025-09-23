# Node Monkey

웹 브라우저 또는 SSH 인터페이스를 통해 Node.js 애플리케이션을 검사, 디버깅 및 명령할 수 있는 도구 (사용자 정의 명령 포함).

Node Monkey는 간단한 서버를 실행하거나 기존 서버에 연결하며, [Socket.IO](https://github.com/LearnBoost/socket.io)를 사용해 브라우저와 서버 간에 웹소켓 연결을 생성합니다. 주요 기능은 터미널에 일반적으로 기록되는 모든 내용을 캡처하여 브라우저에서 검사할 수 있도록 전달하는 것입니다.

시작하기 매우 쉽습니다 (아래 [빠른 사용법](#quick-usage) 참고) 하지만 Node Monkey는 추가 기능과 고급 사용을 위한 상당한 유연성을 제공합니다. 실제로 Node Monkey가 명령줄 인터페이스를 제공하는 SSH를 통해 앱에 접속하여 사용자 정의 명령을 실행할 수 있습니다. 이는 디버깅, 모니터링 또는 실행 중인 애플리케이션을 제어하는 데 매우 유용할 수 있습니다. 프로덕션 애플리케이션에서 보안을 위한 인증을 제공합니다.

## 목차

- [동기](#motivation)
- [기능](#features)
- [설치](#installation)
- [빠른 사용법](#quick-usage)
- [서버](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md)
  - [직접 제공하기](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#provide-your-own)
  - [옵션](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#options)
  - [속성](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#properties)
  - [메서드](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#methods)
- [클라이언트 (브라우저)](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md)
  - [속성](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md#properties)
  - [메서드](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md#methods)
- [SSH](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md)
  - [설정](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md#setup)
  - [사용법](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md#usage)
- [사용자 관리](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/user-management.md)
- [기여하기](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/contributing.md)
- [변경 로그](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/CHANGELOG.md)
- [MIT 라이선스](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/LICENSE.md)

## 동기

이 프로젝트의 동기는 내가 작성한 웹소켓을 사용하는 Node.js 서버를 디버깅하려고 시도하면서 나왔습니다. 터미널에서 객체를 검사하는 것이 너무 크고 탐색하기 어려워 문제를 겪었습니다. Eclipse에서 [Chrome 개발자 도구 플러그인](https://github.com/joyent/node/wiki/using-eclipse-as-node-applications-debugger)과 함께 작동하는 내장 디버깅을 사용해 보았지만, 객체를 검사하기 위해 중단점을 설정하면 서버가 하트비트에 응답하지 않아 클라이언트가 연결이 끊기는 문제가 발생했습니다. 이는 디버깅 작업을 완전히 망쳤습니다. 내가 진정으로 필요했던 것은 객체를 잘 검사할 수 있는 방법이었습니다.

구글을 검색해보니 [node-inspector](https://github.com/dannycoates/node-inspector) 같은 프로젝트가 있었지만 최신 Node 버전과 호환되지 않았고, [node-codein](http://thomashunter.name/blog/nodejs-console-object-debug-inspector/)은 많은 버그가 있었습니다. 게다가 둘 다 Firefox와 호환되지 않았습니다. 그래서 Node Monkey가 탄생했습니다!

## 기능

- 앱의 콘솔 출력을 브라우저 콘솔로 전송하여 쉽게 검사 가능
  - Bunyan 사용자용 스트림 제공 (자세한 내용은 [여기](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#nodemonkeybunyan_stream) 참고)
- SSH 기능을 제공하여 앱에 셸로 접속하여 검사, 디버깅 또는 앱 제어가 가능합니다.
- 브라우저 콘솔 또는 SSH 인터페이스에서 실행할 수 있는 애플리케이션 명령어를 등록합니다.

## 설치

```
npm install --save node-monkey
```

실험적이고 다가오는 기능을 테스트해보고 싶다면, 대신 다음을 실행하세요:

```
npm install --save node-monkey@next
```
## 빠른 사용법

Node Monkey는 많은 기능을 지원하지만, 시작하기는 매우 간단하도록 설계되었습니다. 애플리케이션에 한두 줄을 포함하기만 하면 됩니다. 이 후 콘솔에 기록되는 모든 내용은 연결되면 브라우저 콘솔에 표시됩니다. 대부분의 `console.*` 함수 호출에 대한 출력을 캡처하여 브라우저로 전달해 검사할 수 있습니다.

가장 간단한 사용법은 다음과 같습니다:


```js
const NodeMonkey = require("node-monkey")
NodeMonkey()
```
Node Monkey는 또한 많은 구성 [옵션](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#options)과 명명된 인스턴스를 지원합니다. 호출 형식은 `NodeMonkey([options[, name])`입니다. 예를 들어, 로컬 콘솔 출력을 억제하고 연결된 브라우저나 터미널에서만 출력을 보려면 다음과 같이 할 수 있습니다:


```js
const NodeMonkey = require("node-monkey")
const monkey = NodeMonkey({
  server: {
    disableLocalOutput: true,
  },
})
```

앱 내에서 원하는 모든 파일에 Node Monkey를 포함할 수 있으며, 위의 예제처럼 사용하면 `NodeMonkey()`를 호출할 때마다 처음 생성한 동일한 인스턴스를 반환하며 이후 호출 시 전달된 옵션은 무시됩니다. 하지만, 다른 옵션으로 새 인스턴스를 생성하고 싶을 수 있습니다. 이렇게 하려면 인스턴스에 이름을 지정하세요:

```js
const NodeMonkey = require("node-monkey")
const monkey1 = NodeMonkey() // Creates an instance named 'default'
const monkey2 = NodeMonkey("george") // Creates a new instance with default options
const monkey3 = NodeMonkey(
  {
    // Creates a new instance with custom options named 'ninja'
    server: {
      silent: true,
    },
  },
  "ninja",
)
```

추가 인스턴스에 대해 포트를 지정하지 않으면 자동으로 설정되며 기본값에서 증가합니다(예: 웹소켓 서버는 50502, 50504, SSH 서버는 50503, 50505).

다른 파일에서 이미 생성된 인스턴스를 가져오려면 이름으로 다시 호출하면 됩니다:

```js
const NodeMonkey = require("node-monkey")
const monkey3 = NodeMonkey("ninja")
```

앱을 시작하면 다음과 같은 출력이 표시됩니다:

```
Node Monkey listening at http://0.0.0.0:50500
```
브라우저에 연결하려면 웹 브라우저에 표시된 주소(`http://0.0.0.0:50500` 이 경우)를 입력하세요. 기본 `host`와 `port` 바인딩을 변경하거나 자체 서버를 사용하는 경우 URL을 적절히 조정해야 합니다. 사용자 이름과 비밀번호를 입력하라는 메시지가 표시됩니다. 사용자를 설정하기 전까지 기본값은 `guest`와 `guest`입니다.

자체 서버를 제공하는 경우 웹 애플리케이션 콘솔에서 출력을 볼 수 있습니다. 자체 서버 제공 방법은 [문서](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#provide-your-own)를 참조하세요. Node Monkey 출력을 앱과 통합하려면 HTML 소스에 다음 `<script>` 태그를 포함해야 합니다:


```html
<script type="text/javascript" src="http://0.0.0.0:50500/monkey.js"></script>
```

**NOTE**: You do NOT have to refresh the page when you restart your Node.js application to continue to receive output. Node Monkey will automatically reconnect.

---

### LICENSE: [MIT](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/LICENSE.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-23

---