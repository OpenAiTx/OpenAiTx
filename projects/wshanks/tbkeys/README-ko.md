[![Contributor Covenant](https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg)](code_of_conduct.md)

# <a name="intro"></a>tbkeys

`tbkeys`는 [Mousetrap](https://craig.is/killing/mice)을 사용하여 키 시퀀스를 사용자 명령에 바인딩하는 Thunderbird용 애드온입니다.

## 설치

- [GitHub 릴리스 페이지](https://github.com/willsALMANJ/tbkeys/releases)에 나열된 릴리스 중 하나에서 tbkeys.xpi 파일을 다운로드합니다.
- Thunderbird에서 애드온 관리자(도구->애드온)를 엽니다.
- 우측 상단의 톱니바퀴 아이콘을 클릭하고 "파일에서 애드온 설치..."를 선택한 후 다운로드한 tbkeys.xpi 파일을 선택합니다.
- 애드온은 추후 업데이트가 릴리스되면 GitHub 릴리스 페이지에서 자동으로 업데이트됩니다.

[addons.thunderbird.net](https://addons.thunderbird.net/en-US/thunderbird/addon/tbkeys-lite/)에서 "tbkeys-lite"를 검색하여 Thunderbird 애드온 관리자에서 설치하거나 위 페이지에서 xpi 파일을 다운로드하고 위 단계를 따라 설치할 수도 있습니다.

## 기본 키 바인딩

기본 키 바인딩은 메인 창에서 GMail의 키 바인딩을 모델로 합니다.

| 키 | 기능                                             |
| --- | ------------------------------------------------- |
| c   | 새 메시지 작성                                  |
| r   | 답장                                             |
| a   | 모두에게 답장                                   |
| f   | 전달                                             |
| #   | 삭제                                             |
| u   | 메일 새로 고침. 메시지 탭이 열려 있으면 닫음.      |
| j   | 다음 메시지                                      |
| k   | 이전 메시지                                     |
| o   | 메시지 열기                                     |
| x   | 메시지 보관                                     |

## 키 바인딩 사용자 지정

키 바인딩을 사용자 지정하려면 애드온 관리자에서 애드온 항목의 환경설정 창에 있는 "키 바인딩" 항목을 수정하세요 ("Thunderbird 메뉴 -> 애드온").
키 바인딩 설정 시 고려할 사항은 다음과 같습니다:

- "키 바인딩" 항목은 키 바인딩(Mousetrap 문법, 자세한 내용은 [여기](https://craig.is/killing/mice) 참조)을 유효한 명령어([명령어 문법](#command-syntax) 섹션 참조)에 매핑하는 JSON 객체여야 합니다.
- 환경설정 페이지에는 메인 Thunderbird 창과 작성 창 각각에 대해 키 바인딩을 설정하는 별도의 필드가 있습니다.
  키 바인딩은 다른 창에서는 작동하지 않습니다.
- 텍스트 입력 필드에서는 첫 번째 키 조합에 `shift` 이외의 수정자가 포함되지 않으면 키 바인딩이 작동하지 않습니다.
- 환경설정 페이지는 유효하지 않은 JSON 제출을 허용하지 않지만, 키 바인딩에 대해서는 별도의 유효성 검사를 하지 않습니다.
- 이 [Keyconfig에 관한 오래된 위키 페이지](http://kb.mozillazine.org/Keyconfig_extension:_Thunderbird)에도 여전히 유효한 일부 명령어가 있습니다.
- 개발자 도구 상자(메뉴에서 도구->개발자 도구->개발자 도구 상자)는 UI를 조사하여 함수 호출 대상 요소 이름을 찾는 데 유용할 수 있습니다.
- 시퀀스 키(연속된 여러 키)에서 첫 번째 키 조합이 내장 단축키와 동일한 경우(예: `ctrl+j ctrl+k`)는 지원하지 않습니다.
  수정자가 포함된 단일 키는 내장 단축키를 덮어쓸 수 있으나 시퀀스는 불가능합니다.

### 명령어 문법

키 바인딩에 대해 몇 가지 다른 스타일의 명령어를 지정할 수 있습니다.
다음과 같습니다:

- **단순 명령어**: 이 명령어는 `cmd:<command_name>` 형식을 따르며, `<command_name>`은 Thunderbird가 `goDoCommand()`로 실행할 수 있는 명령어입니다.
  대부분의 명령어 이름은 Thunderbird 소스 코드의 [주요 명령어 세트 파일](https://hg.mozilla.org/comm-central/file/tip/mail/base/content/mainCommandSet.inc.xhtml)에서 찾을 수 있습니다.
- **단순 함수 호출**: 이 명령어는 `func:<func_name>` 형식을 따르며, `<func_name>`은 Thunderbird 창 객체에 정의된 함수 이름입니다.
  해당 함수는 인자 없이 호출됩니다.
- **사용자 정의 함수 호출**: 이 명령어는 `tbkeys:<func_name>` 형식을 따르며, `<func_name>`은 tbkeys에서 작성한 사용자 정의 함수 이름입니다.
  현재 사용 가능한 사용자 정의 함수는 `closeMessageAndRefresh`뿐이며, 이는 첫 번째 탭이 아닌 경우 열린 탭을 닫고 모든 계정을 새로 고칩니다.
  이 동작은 GMail 키 바인딩의 `u`와 유사합니다.
- **바인딩 해제**: 이 항목은 단순히 `unset` 텍스트를 포함합니다.
  `unset` 키 바인딩이 트리거되면 아무 동작도 하지 않습니다.
  이는 실수로 실행하고 싶지 않은 내장 Thunderbird 키 바인딩을 해제할 때 유용할 수 있습니다.
- **MailExtension 메시지**: 이 명령어는 `memsg:<extensionID>:<message>` 형식을 따르며, `<extensionID>`는 메시지를 보낼 Thunderbird 확장 프로그램 ID이고, `<message>`는 `browser.runtime.sendMessage()` MailExtension API를 사용하여 확장 프로그램에 보낼 문자열 메시지입니다.
  현재는 `tbkeys`가 명령어를 문자열로 저장하기 때문에 문자열 메시지만 지원하며, 이 제한은 향후 완화될 수 있습니다.
- <a name="eval"></a>**Eval 명령어**: 이 항목은 tbkeys가 키 바인딩이 트리거될 때 `eval()`을 호출하는 임의의 자바스크립트 코드를 포함할 수 있습니다.
  다른 명령어 유형의 접두사와 일치하지 않는 모든 항목은 eval 명령어로 처리됩니다.
  **참고:** eval 명령어는 tbkeys-lite에서는 사용할 수 없으며, 대신 unset 명령어와 동일하게 동작합니다.

## 일반적인 키 바인딩

다음은 일반적으로 원하는 키 바인딩에 대한 eval 명령어 예시입니다:

- **다음 탭**: `window.document.getElementById('tabmail-tabs').advanceSelectedTab(1, true)`
- **이전 탭**: `window.document.getElementById('tabmail-tabs').advanceSelectedTab(-1, true)`
- **탭 닫기**: `func:CloseTabOrWindow`
- **메시지 목록 아래로 스크롤**: `window.document.getElementById('threadTree').scrollByLines(1)`
- **메시지 목록 위로 스크롤**: `window.document.getElementById('threadTree').scrollByLines(-1)`
- **메시지 본문 아래로 스크롤**:
  - v115+: `window.gTabmail.currentAboutMessage.getMessagePaneBrowser().contentWindow.scrollBy(0, 100)`
  - v102: `window.document.getElementById('messagepane').contentDocument.documentElement.getElementsByTagName('body')[0].scrollBy(0, 100)`
- **메시지 본문 위로 스크롤**:
  - v115+: `window.gTabmail.currentAboutMessage.getMessagePaneBrowser().contentWindow.scrollBy(0, -100)`
  - v102: `window.document.getElementById('messagepane').contentDocument.documentElement.getElementsByTagName('body')[0].scrollBy(0, -100)`
- **새 폴더 만들기**: `window.goDoCommand('cmd_newFolder')`
- **피드 구독하기**: `window.openSubscriptionsDialog(window.GetSelectedMsgFolders()[0])`

## 기본 키 바인딩 해제

환경설정 창의 "Unset singles" 버튼은 메인 창에서 Thunderbird의 기본 단일 키 바인딩을 해제하는 데 사용할 수 있습니다.
이 기능은 tbkey 환경설정에 현재 설정되어 있지 않은 경우를 제외하고 Thunderbird의 기본 단일 키 단축키를 모두 `unset`으로 설정합니다(즉, tbkeys의 기존 단일 키 단축키 설정을 덮어쓰지 않습니다).

## <a name="tbkeys-lite"></a>tbkeys와 tbkeys-lite

tbkeys-lite는 임의의 자바스크립트 실행 기능이 제거된 tbkeys 버전입니다.

## 보안, 개인정보 보호 및 구현

설치 전, Thunderbird는 확장 기능이 "Thunderbird 및 컴퓨터에 대한 완전하고 무제한적인 접근 권한"을 요구한다고 알립니다.
이 권한 요청의 이유는 tbkeys가 키 바인딩을 감지하기 위해 Thunderbird 사용자 인터페이스에 키 리스너를 주입해야 하기 때문입니다.
이를 위해 tbkeys는 MailExtensions 이전의 구형 Thunderbird 확장 인터페이스를 사용합니다.
이 인터페이스는 Thunderbird 68 이전 모든 확장 기능이 사용하던 방식입니다.
확장 기능이 할 수 있는 일을 더 엄격히 제한하는 새로운 MailExtensions API에는 키보드 단축키 API가 포함되어 있지 않습니다.
Thunderbird에 키보드 단축키 API 추가에 관심이 있으시면 프로젝트에 코드 기여를 고려해 주세요.
아마도 [이 티켓](https://bugzilla.mozilla.org/show_bug.cgi?id=1591730)이 Thunderbird 이슈 트래커에서 출발점이 될 수 있습니다.

tbkeys와 관련된 보안 문제를 더 논의하려면 구현 방식을 검토할 필요가 있습니다.
[소개](#intro)에서 언급했듯이, tbkeys는 키 바인딩 관리를 위해 Mousetrap 라이브러리를 사용합니다.
tbkeys의 주요 로직은 [implementation.js](https://raw.githubusercontent.com/wshanks/tbkeys/main/addon/implementation.js)에 있으며, 이는 [MailExtension 실험](https://developer.thunderbird.net/add-ons/mailextensions/experiments)입니다.
`implementation.js`는 tbkey의 표준(범위가 제한된) MailExtension에서 호출할 수 있는 실험 API를 설정하여 키보드 단축키를 함수에 바인딩(바인딩 해제를 위한 null 함수 포함)하고 다른 확장에 보낼 메시지로 바인딩할 수 있게 합니다.
`implementation.js`는 또한 각 Thunderbird 창에 Mousetrap을 로드하고, Thunderbird 특정 UI 요소를 고려하여 Mousetrap이 키 이벤트를 캡처하는 조건을 조정하며, 사용자가 각 키 바인딩에 지정한 동작을 실행하는 함수를 정의합니다.
`implementation.js`가 하는 일은 여기까지입니다.
로컬 파일 시스템이나 메시지 데이터에 접근하지 않으며 네트워크에도 접근하지 않습니다.

tbkeys가 지원하는 명령 모드 중 하나는 [eval](#eval)입니다.
이 모드는 `implementation.js`에서 `eval()`을 사용하여 사용자가 제공한 임의 코드를 Thunderbird 내부에 완전 접근 권한으로 실행합니다.
임의 코드 바인딩이 필요하지 않다면 eval 명령을 지원하지 않는 [tbkeys-lite](#tbkeys-lite)를 사용하는 것이 보안상 이점이 있을 수 있습니다.
tbkeys-lite는 [Thunderbird 부가기능 페이지](https://addons.thunderbird.net/en-US/thunderbird/addon/tbkeys-lite/)에 게시된 버전입니다.
그곳에 게시된 부가기능은 독립적인 수동 검토를 거칩니다.
개발자와 사용자 사이에 그러한 검토 장벽이 존재하는 것은 추가적인 보안 계층을 제공합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-02

---