In Player Episode Preview
====================
## About ##
このプラグインはビデオプレーヤーにエピソードリストを追加し、プレーヤーを離れることなくTV番組のすべてのエピソードをプレビューできるようにします。

この改造は以下のクライアントをサポートしています：
* [Jellyfin Web Client](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin Media Player](https://github.com/jellyfin/jellyfin-media-player) (JMP) デスクトップクライアント

### Features ###
* シーズンのすべてのエピソードを一覧表示
* シーズン間の切り替え
* エピソードのタイトル、説明、サムネイル、再生進捗を表示
* コミュニティランキングなどエピソードの詳細を表示
* エピソードを再生済みまたはお気に入りとしてマーク
* 新しいエピソードを開始
* カスタムテーマでも動作するはず

## Preview ##
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

使用テーマ：（SkinManager）Kaleidochromic
<br>
このプレビューにはエピソードを完了済みまたはお気に入りとしてマークする新しいボタンがありません。

## Installation ##

### Jellyfin Web Client (Server) ###
1. マニフェスト `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` をJellyfinプラグインリポジトリとしてサーバーに追加します。
2. リポジトリからプラグイン `InPlayerEpisodePreview` をインストールします。
3. Jellyfinサーバーを再起動します。

<br/>

### Jellyfin Media Player (JMP) Desktop Client ###
### **JMPバージョン [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0) で非推奨** ###
新しいJMPクライアントはサーバーの現在のウェブプレーヤーを使用しているため、クライアントコードに直接変更を加える必要はなくなりました。

これはデスクトップクライアントにスクリプトをインストールする推奨方法です。
nativeshell.jsファイルの編集（ステップ3から6）に自信がない場合は、スクリプトがすでにnativeshell.jsファイルに追加されているフルリリースをダウンロードできます。
リリース版の nativeshell.js ファイルに置き換えた場合に潜在的な問題が発生する可能性がまだ不明なため、以下のすべての手順に従うことを推奨します。

1. 最新リリースの [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) または [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) をダウンロードします（nativeshell.js ファイルにスクリプトが既に追加されています）
2. zip ファイルを Jellyfin のディレクトリ（例: C:\Program Files\Jellyfin\Jellyfin Media Player）に解凍します
3. Jellyfin のディレクトリ内で "web-client\extension" フォルダパスに従います
4. "nativeshell.js" ファイルをテキストエディタで開きます
5. ファイル内で `const plugins = [];` セクションを見つけます。リストの先頭に新しい行を追加し、`'inPlayerEpisodePreviewPlugin',` を貼り付けます。このセクションは以下のようになります：
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. ファイルを保存し、JMPクライアントを再起動します。

## トラブルシューティング ##

### 1. プレビューボタンが表示されない ###
これは `index.html` ファイルの権限設定が間違っていることが最も考えられます。

#### 1.1 Dockerコンテナ内で所有権を変更する ####
もしjellyfinをDockerコンテナで実行している場合、以下のコマンドで所有権を変更できます
（jellyfinをコンテナ名に、userとgroupをコンテナのユーザーとグループに置き換えてください）：
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
システム起動時にcronジョブとして実行できます。

([muisje](https://github.com/muisje) さんがこの[解決策](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530)を手伝ってくれました。感謝します)

#### 1.2 Windowsインストールでの所有権変更 ####
1. 次の場所に移動します：`C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. `index.html` を右クリック → `プロパティ` → `セキュリティ` タブ → `編集` をクリック
3. リストから自分のユーザーを選択し、書き込み `権限` ボックスにチェックを入れます。
4. サーバーとクライアントの両方を再起動します。

([xeuc](https://github.com/xeuc) さんによるこの[解決策](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069)に感謝します)

これで解決しない場合は、[こちら](https://github.com/Namo2/InPlayerEpisodePreview/issues/10)（または[こちら](https://github.com/Namo2/InPlayerEpisodePreview/issues/49)）の議論を参照してください。

<br/>
自力で解決できないエラーが発生した場合は、遠慮なくIssueを開いてください。
<br/>システムはそれぞれ異なり予期しない動作を引き起こす可能性があるため、できるだけ多くの情報を提供してください。
<br/>Jellyfinのログとブラウザのコンソールログ（[InPlayerEpisodePreview]というプレフィックス付き）は常に役立ちます。

## 欠点 ##
* プラグインはサーバーからエピソードの説明などの追加データをダウンロードします。

## クレジット ##
プラグイン構造は、[NickNSY](https://github.com/nicknsy)による[Jellyscrub](https://github.com/nicknsy/jellyscrub)プラグインを基にし、そこから着想を得ています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---