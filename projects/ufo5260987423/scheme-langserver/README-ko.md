<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

저의 [논문](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)을 읽으실 수 있으며, 아래와 같이 인용하실 수 있습니다.
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

GitHub가 중국 IP 주소를 차단할 수 있기 때문에, 이 저장소를 [여기](https://codeberg.org/ufo5260987423/scheme-langserver)와 [여기](https://gitee.com/ufo5260987423/scheme-langserver)로 복사하였습니다. 모든 저장소를 지속적으로 업데이트할 예정이지만, 보장할 수는 없습니다. 현재 [XmacsLabs](https://github.com/XmacsLabs)와도 협업 중이며, [여기](https://github.com/XmacsLabs/scheme-langserver)에서 포크를 찾으실 수 있습니다.

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**이제 VSCode에서 scheme-langserver를 사용할 수 있습니다!** 자세한 내용은 [여기](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)를 참고하세요.

>참고: scheme-langserver에는 많은 버그가 있습니다. 저는 현재 버그를 수정 중이며 커뮤니티의 도움을 요청하고 있습니다. 조금만 기다려 주세요.

>참고: 자동 생성된 타입 정보는 [여기](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result)에서 확인할 수 있습니다. 현재는 주로 다음 단계 개발(아마도 AKKU 포함) 및 디버깅에 사용됩니다.

자동 완성, 정의로 이동, 또는 hover에서 문서 표시와 같은 기능을 구현하는 것은 프로그래밍에서 상당한 노력이 필요합니다. 그러나 java, python, javascript, c와 같은 다른 언어에 비해 lisp 언어의 language server protocol 구현은 거의 진공 상태에서 이루어지고 있습니다. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver), [swish-lint](https://github.com/becls/swish-lint) 등은 모두 프로그래밍 대신 `repl`(Read-Eval-Print Loop) 또는 키워드 토크나이저에 기반을 두고 있습니다. 예를 들어, 만약 프로그래머가 완성되지 않은 프로젝트에서 코딩 중이라면, 이때 코드는 완전히 실행 가능하지 않습니다. 이 경우 [Geiser](https://gitlab.com/emacs-geiser)나 기타 도구들은 `environment-symbols` 프로시저(예: [Chez](https://cisco.github.io/ChezScheme/))로 나열된 최상위 바인딩 식별자만을 완성하거나, 식별자 대신 심볼만을 완성합니다. 즉, 로컬 바인딩이나 완성되지 않은 코드에 대해서는, 프로그래밍에 많은 노력이 들어가는 것이 중요함에도 불구하고, [Geiser](https://gitlab.com/emacs-geiser)와 그 유사 도구들은 식별자의 유효 범위를 인식하는 데 전혀 도움이 되지 않습니다. 정의로 이동 및 기타 많은 기능에서도 유사한 문제가 발생합니다.

주된 원인은, scheme 및 기타 lisp 계열 언어는 방대한 데이터 집합과 유연한 제어 구조로 인해 프로그램 분석에 큰 도전 과제를 안겨줍니다. 특히 매크로의 경우, scheme은 주로 천재적이고 메타/매크로 프로그래밍에 사용되는 것처럼 보이지만, 저는 그렇지 않다고 생각합니다. 더 나은 프로그래밍 환경이 제공된다면 scheme으로 많은 흥미로운 것들을 만들 수 있습니다. 지금 바로 [**여기서 시작**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)하실 수 있습니다.

이 패키지는 scheme 프로그래밍을 지원하는 language server protocol 구현체입니다. 완성, 정의, 타입 추론 기능을 제공합니다. 이 기능들은 [r6rs 표준](http://www.r6rs.org/) 및 완성되지 않은 코드를 위한 몇 가지 명확한 규칙에 기반한 정적 코드 분석 위에 구축되어 있습니다. 이 패키지 자체와 관련 라이브러리는 [Akku](https://akkuscm.org/)를 통해 배포되었거나 배포 예정입니다. Akku는 Scheme을 위한 패키지 관리자입니다.

이 패키지는 [Chez Scheme](https://cisco.github.io/ChezScheme/) 9.4 및 9.5 버전에서 테스트되었습니다. 10.0.0 버전에 대한 상세 테스트는 노트북 OS를 최신 버전으로 업그레이드한 후 진행할 예정입니다.

저는 이 오픈소스 작업을 여가 시간에만 진행하고 있으며, scheme-langserver에 데이터 흐름 분석을 내장하거나 다양한 아이디어를 커뮤니티에 기여할 수 있습니다. 그리고 지속적으로 더 많은 후원이나 기부를 요청하고 있습니다. [이 patreon 페이지](https://www.patreon.com/PoorProgrammer/membership) 또는 [爱发电](https://afdian.com/a/ufo5260987423)에서 후원하실 수 있습니다.


## 컴파일, 설치 및 설정은 [여기](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)에서 확인하세요.

## 최근 현황
계속해서 버그를 수정하고, 코드를 프로파일링하며, homemade 타입 추론 시스템에 관한 방대한 책을 집필하기 위해 정보를 수집하고 있습니다. 이 작업에는 약 1년이 걸릴 예정입니다. 추가 개발로는 [VScode](https://code.visualstudio.com/) 플러그인 및 데이터 흐름 분석이 포함됩니다. 하지만 실제로는 이 오픈소스 작업을 파트타임으로 진행하고 있어 일정은 보장할 수 없습니다.

## 릴리즈
1.2.9 이제 타입 추론을 즐기세요!

이전 릴리즈는 [이 파일](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md)을 참고하세요.

### 주요 기능
1. 최상위 및 로컬 식별자 바인딩 자동 완성.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. 정의로 이동.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. 패키지 관리자 Akku와 호환.
4. 파일 변경 동기화 및 관련 인덱스 변경.
5. Hover(마우스 오버 시 정보 제공).
6. 참조 및 문서 하이라이트(문서 범위 내 참조).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. 문서 심볼.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. *-syntax(define-syntax, let-syntax 등) 기반의 로컬 식별자 바인딩 포착.
9. 크로스 플랫폼 병렬 인덱싱.
10. .sps 파일 호환을 위한 자체 제작 소스 코드 주석 도구.
11. suspendable task로 API 요청에 대한 피프홀 최적화.
12. 자체 제작 DSL 인터프리터를 이용한 타입 추론(저는 이 기능을 매우 자랑스럽게 생각합니다!). 이제 자동 완성에도 내장되었습니다. 아래 그림에서 보듯이, "length-b"와 "length-a"는 "integer?" 타입을 가지고 있어 "<="에서 요구하는 파라미터 타입과 일치하므로 추천 옵션의 앞부분에 위치합니다.
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
테스트는 다음과 같이 진행할 수 있습니다. `scheme --script tests/protocol/apis/test-completion.sps`를 실행하면 로그 파일 `scheme-langserver.log`에 다음과 같은 결과가 기록됩니다:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. scm, ss, sps, sls, sld 등 다양한 파일 확장자 간 식별자 포착을 위한 추상 인터프리터.

### TODO
14. 이름 바꾸기.
15. [r6rs 표준](http://www.r6rs.org/)과 완벽하게 호환.
16. 단계별 매크로 확장기: 실제로 이미 구현했으나, 사용자 정의 매크로에서 식별자 바인딩 포착의 핵심 단계로 만들고 싶었습니다. 이제 보니 이 포착은 생각보다 훨씬 어렵고, 어디에 적용해야 할지 모르겠습니다.
17. 코드 평가.
18. 코드 진단.
19. 교차 언어 시맨틱 지원 추가. 자바, C, 파이썬 그리고 많은 다른 언어들이 AST 변환기를 통해 지원될 수 있을까?
20. 식/문장을 프로시저로 추출하기.

## TODO: 기여 

## 디버그

### 디버그 방법
https://www.scheme.com/debug/debug.html#g1

### 로그 출력
[빌드](#building), [Lunar Vim 설치](#installation-for-lunarvim), [VScode 설치](#todo-installation-for-vscode)에서 제공하는 팁을 따라, 개발을 하거나 로그를 남기고 싶은 경우 `path-to-log-file`을 추가하고 파일 `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua`를 다음과 같이 수정하면 편리합니다:
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
### 로그를 활용한 반복 디버깅
위의 [로그 출력](#output-log)을 사용하면 `tests/log-debug.sps`로 버그를 반복적으로 재현할 수 있습니다:
1. `{path-to-log}`(보통 `~/scheme-langserver.log`) 파일명을 `~/ready-for-analyse.log`로 변경합니다;
2. `scheme --script tests/log-debug.sps`를 실행합니다. 멀티스레드 환경을 재현하고 싶다면, 역시 `scheme --script tests/log-debug.sps`로 실행하면 됩니다.

## 테스트
거의 모든 주요 프로시저와 API가 테스트되어 있습니다. 제 작업은 거칠지만 유용합니다. 혹시 관심이 있으시다면 `tests` 디렉터리에서 확인하거나 `{scheme-langserver-root-directory}`에서 아래 명령어를 실행해보세요.
``` bash
bash test.sh
```
>참고  
스레드 환경에서 테스트하는 것은 어렵습니다. 그래서 현재 테스트는 단일 스레드에 집중되어 있습니다.

## Scheme-langserver의 기타 용도
### GIMP의 Script-Fu
Script-Fu는 Scheme이라는 인터프리터 언어를 기반으로 하며, GIMP의 내부 함수와 상호작용하는 함수들을 사용합니다. [이 페이지](https://dalelane.co.uk/blog/?p=628)의 스크립트 예시처럼, "SCM" 확장자를 가진 스크립트 파일에 scheme-langserver를 적용할 수 있습니다.

### 기타

저는 [OMN (Opusmodus Notation)](https://opusmodus.com/)과 AutoLisp에도 관심이 있습니다. 하지만 아직 해야 할 일이 많네요.

## 코드 라인 수
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## 상세 문서
1. [Scheme-langserver: Scheme 코드 편집을 최우선 과제로 다루다](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)
2. [식별자 바인딩 잡기](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [동기화](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [타입 추론](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(사용 중단됨, 그리고 이를 위한 중국어 책을 집필 중입니다)
5. [API 분석](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## 기여자

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---