<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Stationは、[Space Station 14](https://github.com/space-wizards/space-station-14) をフォークしたプロジェクトであり、C#で書かれた [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) エンジン上で動作します。

これはFrontier Stationのメインリポジトリです。

Frontier Stationのホスティングやコンテンツ制作を行いたい場合、このリポジトリが必要です。RobustToolboxおよび新しいコンテンツパック開発用のコンテンツパックが含まれています。

## リンク

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## ドキュメント／Wiki

[wiki](https://frontierstation.wiki.gg/) にはFrontier Stationのコンテンツに関するドキュメントがあります。

## 貢献について

誰からの貢献も歓迎しています。ヘルプしたい方はDiscordに参加してください。誰でも取り組める [アイデアリスト](https://discord.com/channels/1123826877245694004/1127017858833068114) がありますので、ぜひご活用ください。質問もお気軽にどうぞ！

現在、当メインリポジトリではゲームの翻訳を受け付けていません。他の言語への翻訳を希望される場合は、フォークを作成するか、既存のフォークへ貢献することをご検討ください。

何か貢献を行う場合は、必ず [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md) のマーカーセクションをお読みください。
アップストリームに属するファイルへの変更は、そこに記載された規定に従い、適切にマークを付けてください。

## ビルド方法

1. リポジトリをクローンします:
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. プロジェクトフォルダに移動し、`RUN_THIS.py` を実行してサブモジュールの初期化とエンジンのロードを行います:
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. ソリューションをコンパイルします:  

`dotnet build` でサーバーをビルドします。

[プロジェクトのビルドに関するより詳細な手順はこちら。](https://docs.spacestation14.com/en/general-development/setup.html)

## ライセンス

コミット 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 以降に本リポジトリへ寄稿されたコンテンツは、特記がない限りGNU Affero General Public License バージョン3.0の下でライセンスされています（下記帰属事項も参照）。`LICENSE-AGPLv3.txt` をご覧ください。
コミット 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 より前に寄稿されたコンテンツは、特記がない限りMITライセンスの下でライセンスされています。`LICENSE-MIT.txt` をご覧ください。

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) は2024年7月1日 16:04 UTCにプッシュされました。

ほとんどのアセットは特記がない限り [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) の下でライセンスされています。アセットのライセンスや著作権はメタデータファイルに記載されています。例として、[バールのメタデータ](https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json) をご覧ください。

一部のアセットは非商用 [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) または類似の非商用ライセンスの下でライセンスされており、本プロジェクトを商用利用したい場合は削除する必要がありますのでご注意ください。

## 帰属事項

他のフォークからコンテンツを取り込む際、帰属管理とマージ時の競合を減らすため、各フォーク固有のサブフォルダに整理しています。

これらのサブディレクトリ内のコンテンツは各フォーク由来であり、改変が加えられている場合があります。改変部分は該当行のコメントで示されています。

| サブディレクトリ | フォーク名 | フォークリポジトリ | ライセンス |
|--------------|-----------|-----------------|---------|
| `_NF` | Frontier Station | https://github.com/new-frontiers-14/frontier-station-14 | AGPL 3.0 |
| `_CD` | Cosmatic Drift | https://github.com/cosmatic-drift-14/cosmatic-drift | MIT |
| `_Corvax` | Corvax | https://github.com/space-syndicate/space-station-14 | MIT |
| `_Corvax` | Corvax Frontier | https://github.com/Corvax-Frontier/Frontier | AGPL 3.0 |
| `_DV` | Delta-V | https://github.com/DeltaV-Station/Delta-v | AGPL 3.0 |
| `_EE` | Einstein Engines | https://github.com/Simple-Station/Einstein-Engines | AGPL 3.0 |
| `_Emberfall` | Emberfall | https://github.com/emberfall-14/emberfall | MPL 2.0 |
| `_EstacaoPirata` | Estacao Pirata | https://github.com/Day-OS/estacao-pirata-14 | AGPL 3.0 |
| `_Goobstation` | Goob Station | https://github.com/Goob-Station/Goob-Station | AGPL 3.0 |
| `_Impstation` | Impstation | https://github.com/impstation/imp-station-14 | AGPL 3.0 |
| `_NC14` | Nuclear 14 | https://github.com/Vault-Overseers/nuclear-14 | AGPL 3.0 |
| `Nyanotrasen` | Nyanotrasen | https://github.com/Nyanotrasen/Nyanotrasen | MIT |

サブディレクトリを使わずに機能を移植した追加リポジトリは下記の通りです。

| フォーク名 | フォークリポジトリ | ライセンス |
|-----------|-----------------|---------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---