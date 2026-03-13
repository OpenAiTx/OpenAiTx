# No-QAnon

QAnon、陰謀論、フェイクニュース、極右、差別的なウェブサイトのアンチファシストドメインブロックリスト。

ヘイトグループや悪意ある行為者に関連するウェブサイトをブロックすることで、採用活動やプロパガンダを抑制し、心理作戦、アストロターフィング、トロール、偽旗作戦、ソックパペッティング、確率的テロリズム、FUDなどの戦術による誤情報の拡散を遅らせることを目的としています。

ドメインのブロックリストはウェブサイト全体のみをブロックします：残念ながら、過激化がよく起きるソーシャルメディア上の何かをブロックすることはできません。
それでも誤った有害な情報への露出は確実に減少します。
ファシストは弱者を狙うので警戒を怠らず、必要に応じてソーシャルメディアのブロックリストも検討してください。

[アンチファシストライセンス](https://github.com/rimu/no-qanon/blob/master/LICENSE.txt)のもとで配布されています。

## Hosts形式

[Hosts形式のブロックリスト](https://raw.githubusercontent.com/rimu/no-qanon/master/hosts.txt)は[hosts](https://en.wikipedia.org/wiki/Hosts_(file))ファイルやPiHoleで使用可能です。

[IPv6版](https://raw.githubusercontent.com/rimu/no-qanon/master/hosts.txt.ipv6)。

- [Windowsコンピュータへのインストール手順](https://github.com/yui-konnu/qanon-block-guide)

- [PiHoleへのインストール手順](https://www.reddit.com/r/QAnonCasualties/comments/wekhem/how_to_use_pihole_to_block_q_related_websites/)

既知の問題：FirefoxのDNS over HTTPSオプションはコンピュータのhostsファイルのルールセットをバイパスします。 https://bugzilla.mozilla.org/show_bug.cgi?id=1453207

## Dnsmasq形式

[Dnsmasq形式のブロックリスト](https://raw.githubusercontent.com/rimu/no-qanon/master/dnsmasq.txt)は[Dnsmasq](https://thekelleys.org.uk/dnsmasq/doc.html) DNSサーバーソフトウェアで使用可能です。

## ブラウザ拡張機能

### Netsane形式

[Netsane形式のブロックリスト](https://raw.githubusercontent.com/rimu/no-qanon/master/netsane.txt)は[Netsane](https://github.com/rimu/netsane)ソフトウェアで使用可能です。

### AdBlock Plus構文

[AdBlock形式のブロックリスト](https://raw.githubusercontent.com/rimu/no-qanon/master/adblock.txt)は広告ブロッカー（[uBlock Origin](https://ublockorigin.com)、[Adguard](https://adguard.com)など）やAdguard Homeで使用可能です。ブラウザ上でこれらのサイトへのアクセスをブロックするために[厳格なブロックルール](https://github.com/gorhill/uBlock/wiki/Strict-blocking)を使用しています。

[こちらをクリックして購読してください。](https://subscribe.adblockplus.org/?location=https://raw.githubusercontent.com/rimu/no-qanon/master/adblock.txt&title=No-QAnon)

### uBlacklist の構文

[uBlacklist形式のブロックリスト](https://raw.githubusercontent.com/rimu/no-qanon/master/ublacklist.txt) は [uBlacklist](https://github.com/iorate/ublacklist) で使用します。検索エンジンの結果からブロックされたサイトを除外します。

[こちらをクリックして購読してください。](https://iorate.github.io/ublacklist/subscribe?name=No-QAnon&url=https://raw.githubusercontent.com/rimu/no-qanon/master/ublacklist.txt) （この自動購読リンクはChromeのみ対応しており、他のブラウザでは手動で追加する必要があります！）

### ドメインリスト

[ドメインリスト形式](https://raw.githubusercontent.com/rimu/no-qanon/master/domains.txt) は [Search Engine Spam Blocker](https://github.com/no-cmyk/Search-Engine-Spam-Blocker) で使用します。検索エンジンの結果からブロックされたサイトを除外します。

## 貢献方法

このリポジトリをクローンし、`sources` フォルダ内の適切な `.txt` ファイルに新しいドメインを追加してください。カテゴリ分けしない場合は、`sources/default.txt` に入れるだけでブロックされます。

> `https://www.example.com` のサイトの場合は、`sources/default.txt` に `example.com` を追加してください。

その後、変更を `sources` フォルダにプッシュすると、GitHub Actions が起動して自動的に新しいブロックリストのバージョンが生成されます。自分で生成したい場合は、`scripts/update.sh` スクリプトを実行できます（前提条件：bash、python）。

最後にプルリクエストを作成してください。数日以内にレビューして承認します。

### カテゴリ分け

ブロックされたサイトは `sources` フォルダ内のサブフォルダや `.txt` ファイルで整理されています。マークダウン（`.md`）ファイルやコメント（`#`）を使って追加情報や参照を記載してください。

### 貢献方法（簡単モード）

Gitの使い方がわからなくても貢献できます！追加したいURLを言語やカテゴリ別にまとめて、[イシューを開いて](https://github.com/rimu/no-qanon/issues)ください。確認してすぐに追加します。

## その他の便利なリスト

[Jmdugan ブロックリスト](https://github.com/jmdugan/blocklists/tree/master/corporations)：Twitter、YouTube、Facebookは偽ニュースを多く流すため、これらのブロックを検討してください。

[Antifa-n ブロックリスト](https://github.com/antifa-n/pihole/blob/master/blocklist.txt) はファシスト系サイトに焦点を当てた優れたブロックリストです。

[バイパス方法ブロックリスト](https://github.com/nextdns/metadata/blob/master/parentalcontrol/bypass-methods) はバイパス手段（VPN、プロキシ、DNSなど）をブロックするために使用できます。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-13

---