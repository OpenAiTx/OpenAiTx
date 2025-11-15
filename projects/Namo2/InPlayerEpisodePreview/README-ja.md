<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <p>以下の翻訳はAIによって自動生成されています。正確性に欠ける場合や、このREADMEの古いバージョンを参照している可能性があることにご注意ください。</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

In Player Episode Preview
====================
## 📄 概要
このプラグインは、ビデオプレイヤーにエピソードリストを追加し、プレイヤーから離れることなくテレビ番組の各エピソードをプレビューできます。

この改造は、以下のクライアントをサポートしています:
* [Jellyfin Web クライアント](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin メディアプレイヤー](https://github.com/jellyfin/jellyfin-media-player) (JMP) デスクトップクライアント

## ✨ 機能
* シーズン内の全エピソードを一覧表示
* シーズン間の切り替え
* エピソードのタイトル、説明、サムネイル、再生進行状況を表示
* コミュニティ評価などのエピソード詳細を表示
* エピソードを視聴済みまたはお気に入りとしてマーク
* 新しいエピソードの再生を開始
* カスタムテーマにも対応

## 📸 プレビュー
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

使用テーマ: (SkinManager) Kaleidochromic
<br>
このプレビューには、エピソードを完了またはお気に入りとしてマークする新しいボタンが表示されていません。

## 🔧 インストール方法

### Jellyfin Web クライアント（サーバー）

> [!NOTE]
> [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) v2.2.1.0 以上のインストールを強く推奨します。これにより、どのようなインストール形態でも index.html の変更時に発生する権限問題を回避できます！
<details open>
<summary> 手順を見る... </summary>

1. サーバーの Jellyfin プラグインリポジトリとして、`https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` のマニフェストを追加します。
2. リポジトリからプラグイン `InPlayerEpisodePreview` をインストールします。
3. Jellyfin サーバーを再起動します。
</details>

### Jellyfin Media Player (JMP) デスクトップクライアント（非推奨）
<details>
<summary> 手順を見る... </summary>

**JMP バージョン [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0) で非推奨**

新しい JMP クライアントでは、サーバーから現在のウェブプレーヤーを使用するため、クライアントコードに直接変更を加える必要はありません。

これがデスクトップクライアントでスクリプトをインストールする推奨方法です。
もし自分で nativeshell.js ファイルを編集することに不安がある場合（ステップ3から6）、スクリプトがすでに nativeshell.js ファイルに追加されている完全版リリースを代わりにダウンロードすることができます。
リリース版の nativeshell.js ファイルを置き換えることで潜在的な問題が生じるかはまだ不明なため、以下のすべての手順に従うことを推奨します。

1. 最新リリース [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) または [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip)（スクリプトが nativeshell.js ファイルにすでに追加済み）をダウンロードします。
2. zipファイルを Jellyfin ディレクトリ（例: C:\Program Files\Jellyfin\Jellyfin Media Player）に展開します。
3. Jellyfin ディレクトリ内で "web-client\extension" フォルダーのパスをたどります。
4. "nativeshell.js" ファイルをテキストエディターで開きます。
5. ファイル内で `const plugins = [];` セクションを探します。リストの先頭に新しい行を追加し、 `'inPlayerEpisodePreviewPlugin',` を貼り付けます。セクションは次のようになります。
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
6. ファイルを保存して、JMPクライアントを再起動します。
</details>

## 💡 トラブルシューティング

### 1. プレビュー ボタンが表示されない
これはほとんどの場合、`index.html` ファイルの権限が正しくないことが原因です。

<details>
<summary> 考えられる解決策の一覧を見る... </summary>

#### 1.1 [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) プラグインを使うことでこの問題を回避できます。

#### 1.2 Dockerコンテナ内で所有権を変更する
jellyfinをDockerコンテナで実行している場合、次のコマンドで所有権を変更できます
（jellyfinはあなたのコンテナ名、userとgroupはコンテナのユーザーとグループに置き換えてください）：
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
これをシステム起動時に cron ジョブとして実行することができます。
（[muisje](https://github.com/muisje) に、[この](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530)解決策の協力に感謝します）

#### 1.3 Windows インストール環境で所有権を変更する
1. 次の場所に移動します: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. `index.html`を右クリック → 「プロパティ」→「セキュリティ」タブ →「編集」をクリック
3. リストから自分のユーザーを選択し、「書き込み」権限のチェックボックスをオンにします。
4. サーバーとクライアントの両方を再起動します。
   （[xeuc](https://github.com/xeuc) に、[この](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069)解決策の協力に感謝します）

上記の解決策でうまくいかない場合は、過去の issue をご参照ください。例えば[こちら](https://github.com/Namo2/InPlayerEpisodePreview/issues/10)や[こちら](https://github.com/Namo2/InPlayerEpisodePreview/issues/49)などです。
</details>

<br/>
<br/>
自力で解決できないエラーに遭遇した場合は、遠慮なく issue を作成してください。
<br/>システムによって動作が異なる場合があるため、予期しない挙動の可能性を考慮し、できるだけ多くの情報を追加してください。
<br/>Jellyfin のログやブラウザのコンソールログ（[InPlayerEpisodePreview] で始まるもの）は常に役立ちます。

## クレジット
このプラグインの構造は [NickNSY](https://github.com/nicknsy) 氏による [Jellyscrub](https://github.com/nicknsy/jellyscrub) プラグインを参考・インスパイアしています。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---