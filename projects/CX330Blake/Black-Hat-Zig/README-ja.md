# Black-Hat-Zig

<p align="center">
  <img alt="GitHub License" src="https://img.shields.io/github/license/CX330Blake/black-hat-zig">
  <img alt="GitHub top language" src="https://img.shields.io/github/languages/top/cx330blake/black-hat-zig">
  <img alt="GitHub repo size" src="https://img.shields.io/github/repo-size/cx330blake/black-hat-zig">
  <img alt="X (formerly Twitter) Follow" src="https://img.shields.io/twitter/follow/CX330Blake">
</p>

<p height="350px" align="center">
  <img src="https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Black-Hat-Zig.png">
  <br/>
  <b>こんにちは、ハッカーの皆さん。こんにちは、maldevsの皆さん。こんにちは、リバースエンジニアの皆さん。ここでZigのダークパワーを探索できて嬉しいです！</b><br/><br/>
  <b>メンテナンスおよび管理：<a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## 目次

- [イントロ](#intro)
- [なぜZigか？](#why-zig)
- [コードのコンパイル](#compiling-the-codes)
- [ペイロードの配置](#payload-placement)
- [ペイロードの難読化](#payload-obfuscation)
- [ペイロードの暗号化](#payload-encryption)
- [ペイロードの実行](#payload-execution)
- [リバースシェル](#reverse-shell)
- [マルウェア技術](#malware-techniques)
- [Maldevツール](#maldev-tools)
- [貢献者](#contributors)
- [クレジットと参考文献](#credits--references)
- [スター履歴](#star-history)
- [免責事項](#disclaimer)

## イントロ

> [!IMPORTANT]
> このプロジェクトは継続的に更新されています！

このプロジェクトでは、私がZigの大ファンであるため、Zigを使った多くのマルウェア技術の実装を提供しています。このリポジトリを使ってZigを武器化できます。Black-Hat-Zigはできる限り多くのコンテンツを含むように継続的に更新されています。このプロジェクトにPRを作成していただければ完璧です。

さあ、ハック・ザ・プラネット！

## なぜZigか？

- 🤝 C/C++ソースとの連携が簡単
- 🔎 新しい言語なので検出が難しい
- 💪 Cよりもさらに低レベルな制御が可能
- 😱 最新のコンパイラによりリバースエンジニアリングが困難
- 🛡️ 最小限のランタイム依存関係 – 大規模な標準ライブラリのフットプリントなし
- 🎯 未定義動作なし – 境界ケースの明示的な処理でクラッシュを防止

## コードのコンパイル

各ディレクトリ内のコードを確認できます。また、コードがWindows APIを使用している場合、該当するプロジェクトディレクトリの`README.md`にヒントが記載されています。例としては[こちら](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)をご覧ください。

Windows APIが必要な場合、デフォルトのビルドターゲットは`windows-x86_64`に設定してあるので、Linux、Windows、MacOSのどこからでも下記コマンドをコピー＆ペーストして簡単にコンパイルできます！（ただし実行ファイルの実行にはWindows環境が必要です）

```bash
zig build
```

## ペイロードの配置

実行ファイルの様々なセクションに悪意のあるペイロードを配置する技術。

- [.dataセクション](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdataセクション](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.textセクション](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrcセクション](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## ペイロードの難読化

ペイロードを静的解析やパターンマッチによる検出から隠すための難読化技術。

- [IPアドレス難読化](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [IPv4難読化](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [IPv4復号](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [IPv6難読化](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [IPv6復号](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [MACアドレス難読化](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [MACアドレス難読化](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [MACアドレス復号](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [UUID難読化](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [UUID難読化](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [UUID復号](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## ペイロードの暗号化

ペイロードの保存や送信時に実際の意図を隠すために用いられる様々な暗号化方式。

- [XOR暗号化](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [標準ライブラリによるXOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [RC4暗号化](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [SystemFunction032によるRC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [AES暗号化](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [Bcrypt.hによるAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [標準ライブラリによるAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [TinyAESによるAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## ペイロードの実行

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [シェルコード](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## リバースシェル

C2アクセスやポストエクスプロイト制御のためのリバースシェルのプリミティブ。

- [標準ライブラリによるリバースシェル](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## マルウェア技術

Zigに適応された一般的な攻撃的トレードクラフト技術のコレクション。

- [プロセスインジェクション](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [DLLインジェクション](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [シェルコードインジェクション](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [ペイロードステージング](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [Webサーバーから](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Windowsレジストリから](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [プロセス列挙](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [CreateToolhelp32Snapshotを使用](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [EnumProcessesを使用](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [NtQuerySystemInformationを使用](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Maldevツール

- [ZYRA: あなたのランタイムアーマー](https://github.com/cx330blake/zyra)
  - Zigで書かれた実行ファイルパッカー
- [ZYPE: あなたのペイロード暗号化器](https://github.com/cx330blake/zype)
  - 暗号化/難読化されたペイロードおよび対応する復号/難読解除関数を含むZigのコードテンプレートを生成

## 貢献者

このプロジェクトは主に[@CX330Blake](https://github.com/CX330Blake)によってメンテナンス・管理されています。PRは歓迎です。より多くの人がZigでマルウェア開発を行い、エコシステムがより成熟することを願っています。

これらの貢献者の皆様に心から感謝します！

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## クレジットと参考文献

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## スター履歴

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## 免責事項

このプロジェクトは倫理的かつ教育的目的のみです。サイバー犯罪者にならないでください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---