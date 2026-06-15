# 트리머

[![ci](https://github.com/jonlabelle/Trimmer/actions/workflows/ci.yml/badge.svg?branch=master)](https://github.com/jonlabelle/Trimmer/actions/workflows/ci.yml)
[![Package Control Installs](https://img.shields.io/packagecontrol/dt/Trimmer.svg?label=installs)](https://packagecontrol.io/packages/Trimmer)
[![Latest Release](https://img.shields.io/github/tag/jonlabelle/Trimmer.svg?label=version)](https://github.com/jonlabelle/Trimmer/releases)
[![MIT License](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/jonlabelle/Trimmer/blob/master/LICENSE.md)

> [Trimmer](https://github.com/jonlabelle/Trimmer)는 공백을 정리하는 [Sublime Text](http://www.sublimetext.com) 플러그인입니다.

## 기능

- 각 줄 끝의 공백을 제거합니다.
- 각 줄 시작의 공백을 제거합니다.
- 각 줄 시작과 끝의 공백을 제거합니다.
- 선택 영역의 공백을 제거합니다.
- 빈 줄, 공백만 있는 줄을 삭제합니다.
- 연속된 여러 빈 줄을 하나의 빈 줄로 축소합니다.
- 연속된 여러 공백을 하나의 공백으로 축소합니다.
- 파일 시작과 끝의 빈 줄, 공백만 있는 줄을 제거합니다.
- 공백 문자를 제거합니다.
- 공백을 정규화합니다 (연속 공백 축소, 빈 줄 제거 및 줄 트리밍).
- 연속된 공백을 축소하고 양쪽 공백을 제거하여 문자열을 토큰화합니다.
- 빈, 공백만 있는 HTML 및 XML 태그를 삭제합니다.
- 코드 주석을 제거하고 줄을 축소합니다.
- 인접한 중복 줄을 삭제합니다.

## 추가 기능

다음 작업을 수행하는 **스마트 문자 대체** 명령어:

- **스마트 작은따옴표:** `’` _를_ `'` 로
- **스마트 큰따옴표:** `“` _를_ `"` 로
- **프라임:** `′` _를_ `'` 로
- **더블 프라임:** `″` _를_ `"` 로
- **독일 따옴표:** `„` _를_ `"` 로 및 `‚` _를_ `'` 로
- **생략 부호:** `…` _를_ `...` 로
- **긴 대시(Em dash):** `—` _를_ `---` 로
- **중간 대시(En dash):** `–` _를_ `--` 로
- **글머리 기호:** `•` _를_ `*` 로
- **중간 점:** `·` _를_ `-` 로
- **Em space** _을_ 세 개의 공백으로
- **En space** _을_ 두 개의 공백으로
- **Non-breaking space** _을_ 한 개의 공백으로
- **Thin space** _을_ 한 개의 공백으로
- **Hair space** _을_ 한 개의 공백으로
- **왼쪽 꺾쇠 괄호:** `«` _를_ `<<` 로
- **오른쪽 꺾쇠 괄호:** `»` _를_ `>>` 로
- **저작권 기호:** `©` _를_ `(C)` 로
- **상표 기호:** `™` _를_ `(T)` 로
- **등록 상표 기호:** `®` _를_ `(R)` 로

![ScreenShot](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/command_palette.png)

[**빠른 데모**](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/demo.gif) 보기

## 설치

Trimmer는 Sublime Text 2와 3 모두 및 모든 지원 운영 체제와 호환됩니다.

### 패키지 컨트롤

Trimmer를 설치하는 가장 쉽고 권장되는 방법은 [패키지 컨트롤](https://packagecontrol.io)을 사용하는 것입니다.

주요 애플리케이션 메뉴에서 다음으로 이동하세요:

- `Tools` -> `Command Palette...` -> `Package Control: Install Package`를 선택하고
  **_Trimmer_** 라는 단어를 입력한 후 선택하여 설치를 완료하세요.

### Git

Git을 사용하여 Trimmer를 설치하려면, **Sublime Text Packages** 디렉터리로 이동한 후
[Trimmer 저장소](https://github.com/jonlabelle/Trimmer)를 클론하세요.

예를 들어, **OS X**에서... 새 **터미널** 세션을 열고 다음 명령어를 입력합니다:


```shell
$ cd ~/Library/Application\ Support/Sublime\ Text\ 3/Packages/
$ git clone https://github.com/jonlabelle/Trimmer
```
### 수동 설치

[zip](https://github.com/jonlabelle/Trimmer/zipball/master) 또는 [tarball](https://github.com/jonlabelle/Trimmer/tarball/master)을 **다운로드**하고
압축을 풀어 Sublime Text 패키지 디렉토리에 넣으세요.

**기본 Sublime Text 패키지 경로:**

- **OS X:** `~/Library/Application Support/Sublime Text [2|3]/Packages`
- **Linux:** `~/.Sublime Text [2|3]/Packages`
- **Windows:** `%APPDATA%/Sublime Text [2|3]/Packages`

> **참고** 설치한 Sublime Text 버전에 맞게 `[2|3]` 부분을 교체하세요.

## 사용법

모든 명령어는 **명령 팔레트(Command Palette)**에서 **_Trimmer_** 접두어로 접근 가능하며,
**메인 메뉴(Main Menu)**의 `편집(Edit)` -> `줄(Line)` -> _Trimmer_ 명령어에서도 사용할 수 있습니다.

- [명령 팔레트 스크린샷](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/command_palette.png)
- [메인 메뉴 스크린샷](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/main_menu.png)

### 단축키

_기본_ 단축키는 각 줄 끝의 후행 공백을 제거합니다 (전체 파일 대상).

- **OS X**: `Ctrl + S`
- **Linux**: `Ctrl + Alt + S`
- **Windows**: `Ctrl + Alt + S`

### Trimmer 명령 API

| 명령어                             | 설명                                                                                                  | 컨텍스트                   |
| ---------------------------------- | ------------------------------------------------------------------------------------------------------ | ------------------------- |
| `trimmer`                          | 각 줄 끝의 공백을 제거                                                                                 | 전체 파일                 |
| `trim_leading_whitespace`          | 각 줄 시작 부분의 공백을 제거                                                                          | 선택 영역 또는 전체 파일  |
| `trim_leading_trailing_whitespace` | 각 줄 시작과 끝 부분의 공백을 모두 제거                                                                | 선택 영역 또는 전체 파일  |




| `trim_selections`                  | 선택 영역의 공백을 제거                                                                              | selection                 |
| `delete_empty_lines`               | 빈 줄, 공백만 있는 줄 삭제                                                                           | selection, or entire file |
| `collapse_lines`                   | 여러 개의 연속된 빈 줄을 하나의 빈 줄로 축소                                                        | selection, or entire file |
| `collapse_spaces`                  | 여러 개의 연속된 공백을 하나의 공백으로 축소                                                        | selection, or entire file |
| `trim_edges`                       | 파일의 시작과 끝에 있는 빈 줄, 공백만 있는 줄 제거                                                  | entire file               |
| `remove_blank_spaces`              | 모든 공백 문자(탭, 캐리지 리턴, 폼 피드, 수직 탭, 스페이스) 제거                                  | selection, or entire file |
| `normalize_spaces`                 | 연속된 공백 축소, 빈 줄 제거 및 줄 다듬기                                                           | selection, or entire file |
| `replace_smart_characters`         | 스마트 문자(스마트 따옴표, em/en 대시, 줄임표, nbsp) 교체                                         | selection, or entire file |
| `tokenize_string`                  | 연속된 공백을 축소하고 앞뒤 공백을 제거하여 문자열을 토큰으로 변환                                  | selection, or entire file |
| `delete_empty_tags`                | 빈, 공백만 있는 HTML 및 XML 태그 삭제                                                              | selection, or entire file |
| `remove_comments`                  | 코드 주석 제거 및 줄 축소                                                                           | selection, or entire file |
| `delete_adjacent_duplicate_lines`  | 인접한 중복 줄 삭제                                                                                | selection, or entire file |

## Author

[Jon LaBelle](https://jonlabelle.com)

## License

Trimmer는 [MIT 라이선스](http://opensource.org/licenses/MIT) 하에 라이선스가 부여되어 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-15

---