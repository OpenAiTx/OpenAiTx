<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/ehmicky/design/main/cross-platform-nodejs/cross-platform-nodejs_dark.svg"/>
  <img alt="cross-platform-nodejs 标志" src="https://raw.githubusercontent.com/ehmicky/design/main/cross-platform-nodejs/cross-platform-nodejs.svg" width="500"/>
</picture>

[![许可证](https://img.shields.io/badge/-CC%20BY%204.0-808080?logo=creativecommons&colorA=404040&logoColor=66cc33)](https://creativecommons.org/licenses/by/4.0/)
[![Node](https://img.shields.io/badge/-Node.js-808080?logo=node.js&colorA=404040&logoColor=66cc33)](https://www.npmjs.com/package/cross-platform-node-guide)
[![Mastodon](https://img.shields.io/badge/-Mastodon-808080.svg?logo=mastodon&colorA=404040&logoColor=9590F9)](https://fosstodon.org/@ehmicky)
[![Medium](https://img.shields.io/badge/-Medium-808080.svg?logo=medium&colorA=404040)](https://medium.com/@ehmicky)

如何编写跨平台的 Node.js 代码。

**为什么你应该关心**：根据
[2018 Node.js](https://nodejs.org/en/user-survey-report/#Primary-OS-Distro)
[用户调查](https://nodejs.org/en/user-survey-report/2018-nodejs-user-survey-raw-data.xlsx)，
24% 的 Node.js 开发者在本地使用 Windows，41% 使用 Mac。在生产环境中，85%
使用 Linux，1% 使用 BSD。

# 目录

[摘要](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/summary.md)

## 🤖 [开发环境](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/README.md)

- [Node 设置](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/node_setup.md)
- [核心工具](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/core_utilities.md)
- [测试](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/testing.md)

## 📝 [文件编码](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/README.md)

- [字符编码](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/character_encoding.md)
- [换行符](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/newlines.md)
- [EOF 和 BOM](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/eof_bom.md)

## 📂 [文件系统](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/README.md)

- [目录位置](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/directory_locations.md)
- [文件路径](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/file_paths.md)
- [文件名](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/filenames.md)
- [符号链接](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/symlinks.md)
- [文件元数据](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/file_metadata.md)

## 💻 [终端](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/README.md)

- [Shell](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/shell.md)
- [文件执行](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/file_execution.md)
- [包二进制文件](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/package_binaries.md)
- [环境变量](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/environment_variables.md)

## 🔒 [安全](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/5_security/README.md)

- [权限](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/5_security/permissions.md)
- [用户](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/5_security/users.md)

## 📡 [网络 / 进程间通信](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/README.md)

- [网络](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/networking.md)
- [进程](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/processes.md)
- [信号](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/signals.md)
- [错误](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/errors.md)

## 🎛️ [系统](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/README.md)

- [操作系统识别](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/os_identification.md)
- [系统配置](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/system_configuration.md)
- [硬件](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/hardware.md)
- [时间](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/time.md)

# 参见

- [cross-platform-terminal-characters](https://github.com/ehmicky/cross-platform-terminal-characters):
  所有在大多数终端上都可用的字符
- https://github.com/bcoe/awesome-cross-platform-nodejs
- https://github.com/Microsoft/nodejs-guidelines
- https://shapeshed.com/writing-cross-platform-node/

# 支持

如有任何问题，_请随时_ [在 GitHub 提交 issue](../../issues)。

欢迎任何背景的人士参与。我们执行
[行为准则](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/CODE_OF_CONDUCT.md)，以促进积极和包容的环境。

# 贡献

本项目由 ❤️ 制作。最简单的回馈方式是给本项目加星并
在线分享。

如果文档内容不清楚或有错别字，请点击页面上的 `编辑`
按钮（铅笔图标）并提出修改建议。

如果你想帮助我们修复错误或添加更多信息，请查看
我们的[指南](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/CONTRIBUTING.md)。欢迎提交 pull request！

感谢以下优秀贡献者：

<!-- ALL-CONTRIBUTORS-LIST:START -->
<!-- prettier-ignore -->
<table>

<tr>
    <td align="center"><a href="https://fosstodon.org/@ehmicky"><img src="https://avatars2.githubusercontent.com/u/8136211?v=4" width="100px;" alt="ehmicky"/><br /><sub><b>ehmicky</b></sub></a><br /><a href="https://github.com/ehmicky/cross-platform-node-guide/commits?author=ehmicky" title="代码">💻</a> <a href="#design-ehmicky" title="设计">🎨</a> <a href="#ideas-ehmicky" title="想法，规划与反馈">🤔</a> <a href="https://github.com/ehmicky/cross-platform-node-guide/commits?author=ehmicky" title="文档">📖</a></td>
    <td align="center"><a href="https://github.com/thatalextaylor"><img src="https://avatars3.githubusercontent.com/u/1481643?v=4" width="100px;" alt="thatalextaylor"/><br /><sub><b>thatalextaylor</b></sub></a><br /><a href="#ideas-thatalextaylor" title="想法，规划与反馈">🤔</a> <a href="https://github.com/ehmicky/cross-platform-node-guide/commits?author=thatalextaylor" title="文档">📖</a></td>
    <td align="center"><a href="https://github.com/bnoordhuis"><img src="https://avatars0.githubusercontent.com/u/275871?v=4" width="100px;" alt="Ben Noordhuis"/><br /><sub><b>Ben Noordhuis</b></sub></a><br /><a href="#ideas-bnoordhuis" title="想法，规划与反馈">🤔</a> <a href="https://github.com/ehmicky/cross-platform-node-guide/commits?author=bnoordhuis" title="文档">📖</a></td>
    <td align="center"><a href="https://github.com/OpenDirective"><img src="https://avatars2.githubusercontent.com/u/618922?v=4" width="100px;" alt="Steve Lee"/><br /><sub><b>Steve Lee</b></sub></a><br /><a href="#ideas-SteveALee" title="想法，规划与反馈">🤔</a> <a href="#talk-SteveALee" title="演讲">📢</a></td>
    <td align="center"><a href="http://tracker1.info/"><img src="https://avatars3.githubusercontent.com/u/444316?v=4" width="100px;" alt="Michael J. Ryan"/><br /><sub><b>Michael J. Ryan</b></sub></a><br /><a href="#ideas-tracker1" title="想法，规划与反馈">🤔</a></td>
    <td align="center"><a href="http://twitter.com/fabiospampinato"><img src="https://avatars1.githubusercontent.com/u/1812093?v=4" width="100px;" alt="Fabio Spampinato"/><br /><sub><b>Fabio Spampinato</b></sub></a><br /><a href="#ideas-fabiospampinato" title="想法，规划与反馈">🤔</a></td>
    <td align="center"><a href="https://github.com/AyrA"><img src="https://avatars0.githubusercontent.com/u/1301960?v=4" width="100px;" alt="AyrA"/><br /><sub><b>AyrA</b></sub></a><br /><a href="#ideas-AyrA" title="想法，规划与反馈">🤔</a></td>
  </tr>
  <tr>
    <td align="center"><a href="https://twitter.com/felixfbecker"><img src="https://avatars0.githubusercontent.com/u/10532611?v=4" width="100px;" alt="Felix Becker"/><br /><sub><b>Felix Becker</b></sub></a><br /><a href="https://github.com/ehmicky/cross-platform-node-guide/commits?author=felixfbecker" title="文档">📖</a> <a href="#ideas-felixfbecker" title="想法，规划与反馈">🤔</a></td>
    <td align="center"><a href="https://github.com/niktekusho"><img src="https://avatars1.githubusercontent.com/u/18280135?v=4" width="100px;" alt="Nicola Dal Maso"/><br /><sub><b>Nicola Dal Maso</b></sub></a><br /><a href="#ideas-niktekusho" title="想法，规划与反馈">🤔</a></td>
  </tr>
</table>

<!-- ALL-CONTRIBUTORS-LIST:END -->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---