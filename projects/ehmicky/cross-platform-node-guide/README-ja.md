<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/ehmicky/design/main/cross-platform-nodejs/cross-platform-nodejs_dark.svg"/>
  <img alt="cross-platform-nodejs ロゴ" src="https://raw.githubusercontent.com/ehmicky/design/main/cross-platform-nodejs/cross-platform-nodejs.svg" width="500"/>
</picture>

[![ライセンス](https://img.shields.io/badge/-CC%20BY%204.0-808080?logo=creativecommons&colorA=404040&logoColor=66cc33)](https://creativecommons.org/licenses/by/4.0/)
[![Node](https://img.shields.io/badge/-Node.js-808080?logo=node.js&colorA=404040&logoColor=66cc33)](https://www.npmjs.com/package/cross-platform-node-guide)
[![Mastodon](https://img.shields.io/badge/-Mastodon-808080.svg?logo=mastodon&colorA=404040&logoColor=9590F9)](https://fosstodon.org/@ehmicky)
[![Medium](https://img.shields.io/badge/-Medium-808080.svg?logo=medium&colorA=404040)](https://medium.com/@ehmicky)

クロスプラットフォームの Node.js コードの書き方。

**なぜ気にするべきか**：  
[2018年の Node.js](https://nodejs.org/en/user-survey-report/#Primary-OS-Distro)  
[ユーザー調査](https://nodejs.org/en/user-survey-report/2018-nodejs-user-survey-raw-data.xlsx)によると、  
ローカル環境で 24% の Node.js 開発者が Windows を使用し、41% が Mac を使っています。  
本番環境では 85% が Linux を使用し、1% が BSD を使用しています。

# 目次

[概要](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/summary.md)

## 🤖 [開発環境](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/README.md)

- [Node セットアップ](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/node_setup.md)
- [コアユーティリティ](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/core_utilities.md)
- [テスト](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/1_development_environment/testing.md)

## 📝 [ファイルエンコーディング](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/README.md)

- [文字エンコーディング](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/character_encoding.md)
- [改行コード](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/newlines.md)
- [EOF と BOM](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/2_file_encoding/eof_bom.md)

## 📂 [ファイルシステム](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/README.md)

- [ディレクトリの場所](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/directory_locations.md)
- [ファイルパス](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/file_paths.md)
- [ファイル名](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/filenames.md)
- [シンボリックリンク](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/symlinks.md)
- [ファイルメタデータ](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/3_filesystem/file_metadata.md)

## 💻 [ターミナル](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/README.md)

- [シェル](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/shell.md)
- [ファイル実行](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/file_execution.md)
- [パッケージバイナリ](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/package_binaries.md)
- [環境変数](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/4_terminal/environment_variables.md)

## 🔒 [セキュリティ](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/5_security/README.md)

- [権限](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/5_security/permissions.md)
- [ユーザー](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/5_security/users.md)

## 📡 [ネットワーキング / IPC](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/README.md)

- [ネットワーキング](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/networking.md)
- [プロセス](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/processes.md)
- [シグナル](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/signals.md)
- [エラー](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/6_networking_ipc/errors.md)

## 🎛️ [システム](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/README.md)

- [OS の識別](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/os_identification.md)
- [システム設定](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/system_configuration.md)
- [ハードウェア](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/hardware.md)
- [時間](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/docs/7_system/time.md)

# 関連情報

- [cross-platform-terminal-characters](https://github.com/ehmicky/cross-platform-terminal-characters):  
  ほとんどのターミナルで動作する文字一覧
- https://github.com/bcoe/awesome-cross-platform-nodejs
- https://github.com/Microsoft/nodejs-guidelines
- https://shapeshed.com/writing-cross-platform-node/

# サポート

質問があれば、遠慮なく [GitHub で Issue を投稿してください](../../issues)。

個人の背景に関係なく誰でも歓迎します。  
ポジティブで包括的な環境を促進するために、  
[行動規範](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/CODE_OF_CONDUCT.md)を適用しています。

# 貢献について

このプロジェクトは ❤️ を込めて作られました。  
最も簡単な貢献方法はスターを付けて、オンラインで共有することです。

ドキュメントが不明瞭または誤字がある場合は、ページの `Edit` ボタン（鉛筆アイコン）をクリックして修正提案してください。

エラーの修正や情報追加を手伝いたい場合は、  
[ガイドライン](https://raw.githubusercontent.com/ehmicky/cross-platform-node-guide/main/CONTRIBUTING.md)を確認してください。プルリクエストも歓迎です！

以下の素晴らしい方々に感謝します：

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