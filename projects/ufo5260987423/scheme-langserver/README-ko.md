![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

제 [논문](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)을 읽으실 수 있으며, 아래와 같이 인용하실 수 있습니다.  
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

GitHub에서 중국 IP 주소를 차단할 수 있기 때문에, 이 저장소를 [여기](https://codeberg.org/ufo5260987423/scheme-langserver)와 [여기](https://gitee.com/ufo5260987423/scheme-langserver)로 복사하였습니다. 모든 저장소를 계속 업데이트할 예정이지만, 보장할 수는 없습니다. 현재 [XmacsLabs](https://github.com/XmacsLabs)와도 협업 중이며, 포크를 [여기](https://github.com/XmacsLabs/scheme-langserver)에서도 찾으실 수 있습니다.

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**이제 VSCode에서 scheme-langserver를 사용할 수 있습니다!** 자세한 내용은 [여기](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)를 참고하세요.

>참고: scheme-langserver에는 많은 버그가 있습니다. 현재 수정 중이며 커뮤니티의 도움을 요청하고 있습니다. 조금만 더 기다려주세요.

>참고: 자동 생성된 타입 정보는 [여기](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result)에서 확인하실 수 있습니다. 현재는 주로 다음 단계 개발(AKKU 포함 가능성 있음) 및 디버깅에 사용됩니다.

자동 완성, 정의로 이동, 또는 문서 hover와 같은 지원을 구현하는 것은 프로그래밍에서 상당한 노력이 필요합니다. 그러나 java, python, javascript, c와 같은 다른 언어와 비교하면, lisp 언어용 언어 서버 프로토콜 구현은 거의 진공 상태에서 만들어졌습니다. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver), [swish-lint](https://github.com/becls/swish-lint) 등은 모두 프로그래밍이 아닌 `repl`(Read-Eval-Print Loop)이나 키워드 토크나이저에 기반을 두고 있습니다. 예를 들어, 프로그래머가 아직 완성되지 않은 프로젝트에서 코딩할 경우, 코드가 완전히 실행 가능하지 않다면, [Geiser](https://gitlab.com/emacs-geiser)나 기타 도구들은 `environment-symbols` 프로시저(예: [Chez](https://cisco.github.io/ChezScheme/))로 나열된 최상위 바인딩 식별자만 완성하거나, 심볼만 완성할 뿐 식별자는 완성하지 않습니다. 즉, 로컬 바인딩이나 완성되지 않은 코드에 대해서는 프로그래밍 지원이 매우 중요함에도 불구하고, [Geiser](https://gitlab.com/emacs-geiser)와 유사 도구들은 식별자의 유효 범위 인식에 전혀 도움이 되지 않습니다. 정의로 이동 및 기타 여러 기능에서도 유사한 사례가 발생합니다.

주요 원인 중 하나는, scheme 및 기타 lisp 계열 언어의 방대한 데이터 세트와 유연한 제어 구조가 프로그램 분석에 큰 도전 과제를 제공하기 때문입니다. 특히 매크로의 경우, scheme은 천재적이고 메타/매크로 프로그래밍에 주로 사용되는 것처럼 보이지만, 저는 그렇게 생각하지 않습니다. 더 나은 프로그래밍 환경이 제공된다면 scheme으로도 많은 흥미로운 것을 만들 수 있습니다. 이제 여러분도 [**여기서 시작**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)하실 수 있습니다.

이 패키지는 scheme 프로그래밍을 돕는 언어 서버 프로토콜 구현입니다. 완성, 정의, 타입 추론 기능을 제공합니다. 이러한 기능들은 [r6rs 표준](http://www.r6rs.org/)과 일부 명확한 미완성 코드 규칙에 기반한 정적 코드 분석에 의해 구축되었습니다. 이 패키지 자체와 관련 라이브러리는 Scheme용 패키지 매니저인 [Akku](https://akkuscm.org/)를 통해 배포되었거나 배포될 예정입니다.

이 패키지는 [Chez Scheme](https://cisco.github.io/ChezScheme/) 9.4 및 9.5 버전에서 테스트되었습니다. 랩탑 OS를 새 버전으로 업그레이드 한 후 10.0.0 버전에 대한 상세 테스트도 진행할 예정입니다.

이 오픈소스 작업은 여가 시간에 진행하고 있으며, scheme-langserver에 데이터 흐름 분석 내장 등 커뮤니티에 많은 훌륭한 아이디어를 기여할 수 있습니다. 더 많은 후원과 펀딩을 계속 요청하고 있습니다. [이 patreon 페이지](https://www.patreon.com/PoorProgrammer/membership)나 [爱发电](https://afdian.com/a/ufo5260987423)에서 후원하실 수 있습니다.


## 컴파일, 설치 및 설정은 [여기](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)에서 확인하세요.

## 최근 현황
버그 수정, 코드 프로파일링, 직접 만든 타입 추론 시스템에 관한 대형 책 집필을 위한 정보 수집을 계속할 예정입니다. 약 1년 정도 소요될 것으로 예상합니다. 추가 개발로는 [VScode](https://code.visualstudio.com/) 플러그인 및 데이터 흐름 분석이 포함됩니다. 하지만 현재 이 오픈소스 작업은 파트타임으로 진행 중이므로 일정은 보장할 수 없습니다.

## 릴리즈 
1.2.9 이제, 타입 추론을 즐기세요!

이전 릴리즈는 [이 파일](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md)을 참고하세요.

### 기능
1. 최상위 및 로컬 식별자 바인딩 자동 완성.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. 정의로 이동.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. 패키지 매니저 Akku와 호환.
4. 파일 변경 동기화 및 해당 인덱스 변경.
5. Hover 기능.
6. 참조 및 문서 강조 표시(문서 범위 참조).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. 문서 심볼.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. *-syntax(define-syntax, let-syntax 등) 기반 로컬 식별자 바인딩 포착.
9. 크로스플랫폼 병렬 인덱싱.
10. .sps 파일과 호환되는 자체 제작 소스 코드 주석 처리기.
11. 중단 가능한 작업이 포함된 API 요청을 위한 피프홀 최적화.
12. 자체 제작 DSL 인터프리터를 이용한 타입 추론(정말 자랑스럽게 생각합니다!). 이제 자동 완성에도 내장되어 있습니다. 아래 그림과 같이, "<="에서 요구되는 파라미터 타입과 일치하는 "integer?" 타입의 "length-b"와 "length-a"가 추천 옵션의 앞에 나옵니다.
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
이 결과는 실제 테스트로 증명할 수 있습니다. `scheme --script tests/protocol/apis/test-completion.sps`를 실행하면 로그 파일 `scheme-langserver.log`에 다음과 같은 결과가 포함됩니다:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. scm, ss, sps, sls, sld 등 다양한 파일 확장자 간 식별자 포착을 위한 추상 인터프리터.

### TODOs
14. 리네이밍(Renaming).
15. [r6rs 표준](http://www.r6rs.org/)과 완전 호환.
16. 단계별 매크로 확장기: 실제로 하나를 구현했으며, 사용자 정의 매크로에서 식별자 바인딩 포착의 핵심 단계로 만들고자 했습니다. 하지만 이 포착은 생각보다 훨씬 어렵고, 확장기가 어디서 동작할지 모르겠습니다.
17. 코드 평가(Code eval).
18. 코드 진단(Code diagnostic).
19. 교차 언어 의미 지원 추가. Java, C, Python 등 다른 언어들도 AST 변환기로 지원 가능할까요?
20. 식(expression)/문(statement)을 프로시저로 추출.

## TODO:기여 

## 디버그

### 디버그 방법
https://www.scheme.com/debug/debug.html#g1

### 로그 출력
[빌드](#building), [Lunar Vim 설치](#installation-for-lunarvim), [VScode 설치](#todo-installation-for-vscode) 안내를 참고하여, 개발 및 로그 기록을 원하는 경우, `path-to-log-file`을 추가하고 `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` 파일을 다음과 같이 수정하면 편리합니다:
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, a language server protocol implementation for scheme
]]   ,
  },
}
```
### 로그를 사용한 반복(Recurring with Log)
위의 [출력 로그](#output-log)를 사용하여 `tests/log-debug.sps`로 버그를 반복 재현할 수 있습니다:
1. `{path-to-log}`(보통 `~/scheme-langserver.log`)를 `~/ready-for-analyse.log`로 이름을 바꿉니다;
2. `scheme --script tests/log-debug.sps`를 실행합니다. 멀티스레드 환경을 재현하고 싶다면, 역시 `scheme --script tests/log-debug.sps`를 실행하면 됩니다.

## 테스트
거의 모든 주요 프로시저와 API들이 테스트되어 있습니다. 제 작업은 다소 거칠지만 유용합니다. `tests` 디렉터리에서 제가 한 일을 찾아보거나, `{scheme-langserver-root-directory}`에서 아래 명령어를 실행해 보십시오.
``` bash
bash test.sh
```
>참고  
스레드 환경에서 테스트를 수행하는 것은 어렵습니다. 그래서 현재 테스트는 단일 스레드에 초점을 맞추고 있습니다.

## 다른 목적으로 Scheme-langserver 사용하기
### GIMP에서 Script-Fu
Script-Fu는 Scheme이라는 인터프리터 언어를 기반으로 하며, GIMP의 내부 함수와 상호작용하는 함수들을 사용합니다. [이 페이지](https://dalelane.co.uk/blog/?p=628)의 스크립트를 예로 들어, "SCM" 확장자를 가진 스크립트 파일에 scheme-langserver를 적용할 수 있습니다.

### 기타

저 역시 [OMN (Opusmodus Notation)](https://opusmodus.com/)과 AutoLisp에도 관심이 있습니다. 하지만 아직 해야 할 일이 많습니다.

## 코드 수 집계
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## 상세 문서
1. [Scheme-langserver: Scheme 코드 편집을 1급 관심사로 다루기](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)
2. [식별자 바인딩 잡아내기](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [동기화](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [타입 추론](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(폐기됨, 현재 이를 위한 중국어 책을 집필 중)
5. [API 분석](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Star 히스토리

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## 기여자

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---