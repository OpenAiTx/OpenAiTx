<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/ehmicky/design/main/cross-platform-nodejs/cross-platform-nodejs_dark.svg"/>
  <img alt="cross-platform-nodejs logo" src="https://raw.githubusercontent.com/ehmicky/design/main/cross-platform-nodejs/cross-platform-nodejs.svg" width="500"/>
</picture>

[![License](https://img.shields.io/badge/-CC%20BY%204.0-808080?logo=creativecommons&colorA=404040&logoColor=66cc33)](https://creativecommons.org/licenses/by/4.0/)
[![Node](https://img.shields.io/badge/-Node.js-808080?logo=node.js&colorA=404040&logoColor=66cc33)](https://www.npmjs.com/package/cross-platform-node-guide)
[![Mastodon](https://img.shields.io/badge/-Mastodon-808080.svg?logo=mastodon&colorA=404040&logoColor=9590F9)](https://fosstodon.org/@ehmicky)
[![Medium](https://img.shields.io/badge/-Medium-808080.svg?logo=medium&colorA=404040)](https://medium.com/@ehmicky)

How to write cross-platform Node.js code.

**Why you should care**: according to the
[2018 Node.js](https://nodejs.org/en/user-survey-report/#Primary-OS-Distro)
[user survey](https://nodejs.org/en/user-survey-report/2018-nodejs-user-survey-raw-data.xlsx),
24% of Node.js developers use Windows locally and 41% use Mac. In production 85%
use Linux and 1% use BSD.

# Table of contents

[Summary](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/summary.md)

## 🤖 [Development environment](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/README.md)

- [Node setup](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/node_setup.md)
- [Core utilities](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/core_utilities.md)
- [Testing](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/testing.md)

## 📝 [File encoding](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/README.md)

- [Character encoding](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/character_encoding.md)
- [Newlines](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/newlines.md)
- [EOF and BOM](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/eof_bom.md)

## 📂 [Filesystem](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/README.md)

- [Directory locations](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/directory_locations.md)
- [File paths](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/file_paths.md)
- [Filenames](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/filenames.md)
- [Symlinks](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/symlinks.md)
- [File metadata](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/file_metadata.md)

## 💻 [Terminal](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/README.md)

- [Shell](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/shell.md)
- [File execution](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/file_execution.md)
- [Package binaries](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/package_binaries.md)
- [Environment variables](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/environment_variables.md)

## 🔒 [Security](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/5_security/README.md)

- [Permissions](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/5_security/permissions.md)
- [Users](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/5_security/users.md)

## 📡 [Networking / IPC](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/README.md)

- [Networking](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/networking.md)
- [Processes](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/processes.md)
- [Signals](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/signals.md)
- [Errors](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/errors.md)

## 🎛️ [System](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/README.md)

- [OS identification](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/os_identification.md)
- [System configuration](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/system_configuration.md)
- [Hardware](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/hardware.md)
- [Time](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/time.md)

# See also

- [cross-platform-terminal-characters](https://github.com/ehmicky/cross-platform-terminal-characters):
  All the characters that work on most terminals
- https://github.com/bcoe/awesome-cross-platform-nodejs
- https://github.com/Microsoft/nodejs-guidelines
- https://shapeshed.com/writing-cross-platform-node/

# Support

For any question, _don't hesitate_ to [submit an issue on GitHub](../../issues).

Everyone is welcome regardless of personal background. We enforce a
[Code of conduct](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/CODE_OF_CONDUCT.md) in order to promote a positive and
inclusive environment.

# Contributing

This project was made with ❤️. The simplest way to give back is by starring and
sharing it online.

If the documentation is unclear or has a typo, please click on the page's `Edit`
button (pencil icon) and suggest a correction.

If you would like to help us fix an error or add more information, please check
our [guidelines](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/CONTRIBUTING.md). Pull requests are welcome!

Thanks go to these wonderful people:

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