# Spicetify DJ Info

Spicetify DJ Info 拡張機能へようこそ！この拡張機能は、各トラックのキー、BPM、人気度、リリース年などの貴重な楽曲分析データを提供し、Spicetifyの体験を向上させます。この拡張機能を使うことで、音楽ライブラリをより深く理解し、DJセットやプレイリストに完璧にマッチする曲を発見できます。

## ⭐Features

- **Key:** 各曲のキーを標準表記（Dbm）またはキャメロットシステム（3B）で識別します。キャメロットシステムは、調和的に互換性のあるキーをグループ分けすることでハーモニックミキシングを簡素化し、DJセットや一貫性のあるプレイリスト作成時に曲間のスムーズな移行を可能にします。
- **BPM ♫ (Beats Per Minute):** 各曲のテンポ（音楽の速さやペース）を取得します。BPMは、似た速さの曲でプレイリストを作成したり、特定の活動に適した曲を選んだりするのに役立ちます。
- **Popularity ♥:** 曲の人気度評価にアクセスして、どれだけ人気があるかを確認できます。このデータは、曲の全体的な評価や人気を理解するのに役立ちます。
- **Year:** 曲のリリース年を調べます。このデータは、特定の時期の曲でプレイリストを作成する際に役立ちます。

![Screenshot](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/img/playlist.png)
![Screenshot](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/img/now-playing.png)

## 💻 Installation

`dist/djinfo.mjs` をあなたの [Spicetify](https://github.com/spicetify/spicetify-cli) 拡張機能ディレクトリにコピーしてください：

| **Platform** | **Path**                                                                             |
| ------------ | ------------------------------------------------------------------------------------ |
| **Linux**    | `~/.config/spicetify/Extensions` または `$XDG_CONFIG_HOME/.config/spicetify/Extensions/` |
| **MacOS**    | `~/.config/spicetify/Extensions` または `$SPICETIFY_CONFIG/Extensions`                   |
| **Windows**  | `%appdata%/spicetify/Extensions/`                                                    |

拡張機能ファイルを正しいフォルダに入れた後、以下のコマンドを実行して拡張機能をインストールしてください：

```bash
spicetify config extensions djinfo.mjs
spicetify apply
```

または、`config-xpui.ini` ファイルを手動で編集することもできます。extensions キーに希望する拡張子のファイル名を追加し、| 文字で区切ってください。
例:

```ini
[AdditionalOptions]
...
extensions = autoSkipExplicit.js|shuffle+.js|trashbin.js|djinfo.mjs
```

次に実行してください：

```bash
spicetify apply
```

**星評価に問題を引き起こす可能性があります！**

## ❌ アンインストール

以下のコマンドを実行して拡張機能をアンインストールしてください（末尾の - に注意してください）：

```bash
spicetify config extensions djinfo.mjs-
spicetify apply
```

`config-xpui.ini` ファイルを手動で編集することもできます。拡張機能のファイル名を完全に削除してください。
例：

```ini
[AdditionalOptions]
...
extensions = autoSkipExplicit.js|shuffle+.js|trashbin.js
```
それから実行してください：


```bash
spicetify apply
```
## ⚙️ 設定

拡張機能内でDJ情報の表示・非表示を切り替えるオプションがあります。デフォルトでは、各曲および現在再生中の曲の横にKey、BPM、Popularity、YearなどのDJ情報が表示されます。しかし、よりシンプルなインターフェースを好む場合は、これらを個別に簡単に非表示にできます。

DJ情報の表示・非表示を切り替える手順は以下の通りです：

1. Spotifyを開く
2. インターフェース右上のメニューアイコン（プロフィール画像）を探し、クリックする
3. メニュー内で「DJ Info」オプションを見つける
4. サブメニューでトグルスイッチをクリックして、表示・非表示を切り替える
5. 「変更を適用」をクリックして設定を反映する

## 📜 変更履歴

### V 2.4.0

- 別のAPIに更新
- スタイリングを改善
- 新しいオーディオ機能用の新しいオプションを追加

### V 2.3.3

- ログスパムを修正

### V 2.3.2

- 新しいミックスUIに合わせてレイアウトを修正

### V 2.3.1

- APIの問題で拡張機能が動作しなくなる問題を修正
- 新しいAPIで利用できなくなったため、DanceabilityとEnergyを削除
- DJ Infoの新UIを追加し、古いバージョンもリッチUIを無効にすることで使用可能に改善
- キャッシュを修正し、LocalStorageの代わりにIndexedDBを使用する新システムに移行
- 新しいキャメロットキーの色はCSS変数の上書きでカスタマイズ可能に

### V 2.2.1

- 推薦機能でようやく正しく動作するように修正

- キャッシュが大幅に改善されました  
- データはバッチで取得され、レート制限によるデータ欠落が修正されました  
- 新しいプレイリストUIでも再び動作するようになりました  
- ロードパフォーマンスが向上しました  
- エラーロギングが改善されました  
- #16、#23、#24、#25 のバグ修正  

### V 2.1.1  

- 推薦曲セクションのスタイルを修正しました  

### V 2.1.0  

- 推薦曲セクションにDJ情報を表示するオプションを追加しました  
- ディスコグラフィーセクションでDJ情報が表示されないバグを修正しました（[#2](https://github.com/L3-N0X/spicetify-dj-info/issues/2)）  
- キューのバグを修正しました（[#9](https://github.com/L3-N0X/spicetify-dj-info/issues/9)）  

### V 2.0.0  

- ロード時間短縮とAPIコール削減のためにデータをローカル保存することでパフォーマンスを向上させました  
- 設定メニューを再設計し、DJ情報の表示切替がより簡単になりました  

### V 1.1.0  

- 標準表記での年、人気度、ダンサビリティ、キーの表示切替オプションを追加しました  
- バグ修正  

## 🌐 クレジット＆感謝  

内部APIの破損後に拡張機能を修正し、API全体を内部のprotobufベースAPIに移行、さらにバンドルを含むより良いファイル構造を追加してくれた[obafgkmdh](https://github.com/obafgkmdh)と[FixeQD](https://github.com/FixeQD)に大きな感謝を！  

また、プレイリストでのDJ情報のより良い配置のアイデアを提供してくれた[Golevka2001](https://github.com/Golevka2001)にも感謝します！  

プレイリストとNow Playingウィジェットに何かを表示するメインコードを提供してくれた[duffey](https://github.com/Tetrax-10)にも大きな感謝を！  

さらに、キーの標準表記とキャメロットシステムの両方を表示するコードと、Now Playingの左側に表示するオプションを提供してくれた[je09](https://github.com/je09)にも感謝します！  

## 💬 フィードバックと貢献  

問題が発生した場合や拡張機能の改善案がある場合は、[GitHubリポジトリ](https://github.com/L3-N0X/spicetify-dj-info)でIssueを開いてください。貢献も歓迎します！リポジトリをフォークし、変更を加え、改善内容を含むプルリクエストを送ってください。

## ⚖️ ライセンス

このプロジェクトは[MITライセンス](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/LICENSE.md)の下でライセンスされています。このライセンスの条件に従って、コードの使用、変更、配布は自由に行えます。

---

Spicetify DJ Info Extensionで強化された音楽解析体験をお楽しみください！この拡張機能が役立つと感じたら、GitHubで⭐️を付けてください。DJ Infoをご利用いただきありがとうございます！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-06

---