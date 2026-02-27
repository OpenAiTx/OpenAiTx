# Cobalt Strike Linux Beacon

Cobalt StrikeチームサーバーとHTTP/Sプロトコルで通信する、Cで書かれたカスタムLinux Beaconの概念実証。

このプロジェクトの目的は、完全な機能を持つインプラントであることでも、Linuxに限定することでもありません。任意のプラットフォーム向けにCobalt Strikeのカスタムインプラントを作成できることを示すことです。唯一の要件はチームサーバーと正しく通信することです。

カスタムインプラントを使えば、カスタムの動作を定義したり、新機能を追加したり、異なるプラットフォームやファイルタイプをサポートしたり、コンパイル時に難読化を適用したりできます。可能性は無限です。

いつかCobalt Strikeが公式にカスタムBeaconの開発をサポートし、より多くのドキュメントや利便性の高い機能を追加することを願っています。


## 機能
- HTTP/Sリスナーサポート（デフォルトC2プロファイル）
- いくつかの組み込みコマンドを含む：`sleep`、`cd`、`pwd`、`shell`、`ls`、`exit`、`upload`、`download`
- TrustedSecのELFLoaderを使ったLinux BOF実行。TrustedSecおよびOutflank BOFの両方をサポート
- SOCKSプロキシ

## デモ
Aggressorスクリプトでのペイロード生成
![Linux Beacon Payload Generation](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/demo/generate_payloads.gif)

Linux Beaconでのコマンド＆BOF実行
![Linux Beacon Commands Demo](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/demo/commands.gif)

## セットアップ
[SETUP](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/SETUP.md)ファイルでセットアップ手順を確認できます。

## 特別な感謝
BOF実行の統合やインプラントのテストに協力してくれた[Kyle Avery](https://x.com/kyleavery)に感謝します。

## 今後の目標
* カスタムC2プロファイルのサポート追加
* TCPリスナーおよび接続機能の追加
* バグ修正の継続

## リソース
- Cobalt Strike (すごい！)
- [TrustedSecのELFLoader & BOF](https://github.com/trustedsec/ELFLoader)
- [OutflankのBOF](https://github.com/outflanknl/nix_bof_template)
- [PaloAltoNetworks Unit42](https://unit42.paloaltonetworks.com/cobalt-strike-metadata-encryption-decryption/)
- [SANS ISC](https://isc.sans.edu/diary/27968)
- [cs-decrypt-metadata-py](https://blog.didierstevens.com/2021/10/22/new-tool-cs-decrypt-metadata-py/)
- [SentinelOne CobaltStrikeParser](https://github.com/Sentinel-One/CobaltStrikeParser)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-27

---