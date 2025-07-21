<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/ehmicky/design/main/cross-platform-nodejs/cross-platform-nodejs_dark.svg"/>
  <img alt="cross-platform-nodejs 로고" src="https://raw.githubusercontent.com/ehmicky/design/main/cross-platform-nodejs/cross-platform-nodejs.svg" width="500"/>
</picture>

[![License](https://img.shields.io/badge/-CC%20BY%204.0-808080?logo=creativecommons&colorA=404040&logoColor=66cc33)](https://creativecommons.org/licenses/by/4.0/)
[![Node](https://img.shields.io/badge/-Node.js-808080?logo=node.js&colorA=404040&logoColor=66cc33)](https://www.npmjs.com/package/cross-platform-node-guide)
[![Mastodon](https://img.shields.io/badge/-Mastodon-808080.svg?logo=mastodon&colorA=404040&logoColor=9590F9)](https://fosstodon.org/@ehmicky)
[![Medium](https://img.shields.io/badge/-Medium-808080.svg?logo=medium&colorA=404040)](https://medium.com/@ehmicky)

크로스 플랫폼 Node.js 코드를 작성하는 방법.

**왜 중요할까요**: 
[2018 Node.js](https://nodejs.org/en/user-survey-report/#Primary-OS-Distro)
[사용자 설문조사](https://nodejs.org/en/user-survey-report/2018-nodejs-user-survey-raw-data.xlsx)에 따르면,
Node.js 개발자의 24%가 로컬에서 Windows를 사용하고 41%가 Mac을 사용합니다. 프로덕션에서는 85%가 Linux를, 1%가 BSD를 사용합니다.

# 목차

[요약](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/summary.md)

## 🤖 [개발 환경](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/README.md)

- [Node 설정](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/node_setup.md)
- [핵심 유틸리티](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/core_utilities.md)
- [테스트](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/testing.md)

## 📝 [파일 인코딩](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/README.md)

- [문자 인코딩](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/character_encoding.md)
- [줄바꿈](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/newlines.md)
- [EOF 및 BOM](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/eof_bom.md)

## 📂 [파일 시스템](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/README.md)

- [디렉터리 위치](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/directory_locations.md)
- [파일 경로](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/file_paths.md)
- [파일명](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/filenames.md)
- [심볼릭 링크](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/symlinks.md)
- [파일 메타데이터](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/file_metadata.md)

## 💻 [터미널](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/README.md)

- [셸](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/shell.md)
- [파일 실행](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/file_execution.md)
- [패키지 바이너리](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/package_binaries.md)
- [환경 변수](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/environment_variables.md)

## 🔒 [보안](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/5_security/README.md)

- [권한](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/5_security/permissions.md)
- [사용자](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/5_security/users.md)

## 📡 [네트워킹 / IPC](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/README.md)

- [네트워킹](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/networking.md)
- [프로세스](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/processes.md)
- [시그널](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/signals.md)
- [오류](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/errors.md)

## 🎛️ [시스템](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/README.md)

- [운영체제 식별](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/os_identification.md)
- [시스템 구성](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/system_configuration.md)
- [하드웨어](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/hardware.md)
- [시간](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/time.md)

# 참고 자료

- [cross-platform-terminal-characters](https://github.com/ehmicky/cross-platform-terminal-characters):
  대부분의 터미널에서 작동하는 모든 문자
- https://github.com/bcoe/awesome-cross-platform-nodejs
- https://github.com/Microsoft/nodejs-guidelines
- https://shapeshed.com/writing-cross-platform-node/

# 지원

질문이 있으시면, _주저하지 말고_ [GitHub에서 이슈를 제출하세요](../../issues).

개인의 배경과 관계없이 모두 환영합니다. 긍정적이고 포용적인 환경을 조성하기 위해
[행동 강령](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/CODE_OF_CONDUCT.md)을 시행하고 있습니다.

# 기여하기

이 프로젝트는 ❤️로 만들어졌습니다. 가장 간단한 환원 방법은 별을 누르고
온라인에서 공유하는 것입니다.

문서가 불명확하거나 오타가 있으면, 페이지의 `Edit` 버튼(연필 아이콘)을 클릭해
수정을 제안해 주세요.

오류를 수정하거나 추가 정보를 더하고 싶다면,
[가이드라인](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/CONTRIBUTING.md)을 확인해 주세요. 풀 리퀘스트도 환영합니다!

아래 멋진 분들께 감사드립니다:

<!-- ALL-CONTRIBUTORS-LIST:START -->
<!-- prettier-ignore -->
<table>


<tr>
    <td align="center"><a href="https://fosstodon.org/@ehmicky"><img src="https://avatars2.githubusercontent.com/u/8136211?v=4" width="100px;" alt="ehmicky"/><br /><sub><b>ehmicky</b></sub></a><br /><a href="https://github.com/ehmicky/cross-platform-node-guide/commits?author=ehmicky" title="Code">💻</a> <a href="#design-ehmicky" title="Design">🎨</a> <a href="#ideas-ehmicky" title="Ideas, Planning, & Feedback">🤔</a> <a href="https://github.com/ehmicky/cross-platform-node-guide/commits?author=ehmicky" title="Documentation">📖</a></td>
    <td align="center"><a href="https://github.com/thatalextaylor"><img src="https://avatars3.githubusercontent.com/u/1481643?v=4" width="100px;" alt="thatalextaylor"/><br /><sub><b>thatalextaylor</b></sub></a><br /><a href="#ideas-thatalextaylor" title="Ideas, Planning, & Feedback">🤔</a> <a href="https://github.com/ehmicky/cross-platform-node-guide/commits?author=thatalextaylor" title="Documentation">📖</a></td>
    <td align="center"><a href="https://github.com/bnoordhuis"><img src="https://avatars0.githubusercontent.com/u/275871?v=4" width="100px;" alt="Ben Noordhuis"/><br /><sub><b>Ben Noordhuis</b></sub></a><br /><a href="#ideas-bnoordhuis" title="Ideas, Planning, & Feedback">🤔</a> <a href="https://github.com/ehmicky/cross-platform-node-guide/commits?author=bnoordhuis" title="Documentation">📖</a></td>
    <td align="center"><a href="https://github.com/OpenDirective"><img src="https://avatars2.githubusercontent.com/u/618922?v=4" width="100px;" alt="Steve Lee"/><br /><sub><b>Steve Lee</b></sub></a><br /><a href="#ideas-SteveALee" title="Ideas, Planning, & Feedback">🤔</a> <a href="#talk-SteveALee" title="Talks">📢</a></td>
    <td align="center"><a href="http://tracker1.info/"><img src="https://avatars3.githubusercontent.com/u/444316?v=4" width="100px;" alt="Michael J. Ryan"/><br /><sub><b>Michael J. Ryan</b></sub></a><br /><a href="#ideas-tracker1" title="Ideas, Planning, & Feedback">🤔</a></td>
    <td align="center"><a href="http://twitter.com/fabiospampinato"><img src="https://avatars1.githubusercontent.com/u/1812093?v=4" width="100px;" alt="Fabio Spampinato"/><br /><sub><b>Fabio Spampinato</b></sub></a><br /><a href="#ideas-fabiospampinato" title="Ideas, Planning, & Feedback">🤔</a></td>
    <td align="center"><a href="https://github.com/AyrA"><img src="https://avatars0.githubusercontent.com/u/1301960?v=4" width="100px;" alt="AyrA"/><br /><sub><b>AyrA</b></sub></a><br /><a href="#ideas-AyrA" title="Ideas, Planning, & Feedback">🤔</a></td>
  </tr>
  <tr>
    <td align="center"><a href="https://twitter.com/felixfbecker"><img src="https://avatars0.githubusercontent.com/u/10532611?v=4" width="100px;" alt="Felix Becker"/><br /><sub><b>Felix Becker</b></sub></a><br /><a href="https://github.com/ehmicky/cross-platform-node-guide/commits?author=felixfbecker" title="Documentation">📖</a> <a href="#ideas-felixfbecker" title="Ideas, Planning, & Feedback">🤔</a></td>
    <td align="center"><a href="https://github.com/niktekusho"><img src="https://avatars1.githubusercontent.com/u/18280135?v=4" width="100px;" alt="Nicola Dal Maso"/><br /><sub><b>Nicola Dal Maso</b></sub></a><br /><a href="#ideas-niktekusho" title="Ideas, Planning, & Feedback">🤔</a></td>
  </tr>
</table>

<!-- ALL-CONTRIBUTORS-LIST:END -->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---