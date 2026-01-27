<h1 align="center"> 敗北ペナルティ——コヨーテゲームコントローラー</h1>
<div align="center">
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/actions"><img src="https://img.shields.io/github/actions/workflow/status/hyperzlib/DG-Lab-Coyote-Game-Hub/node.js.yml"></a>
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases"><img src="https://img.shields.io/github/release-date/hyperzlib/DG-Lab-Coyote-Game-Hub"></a>
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/commits/main/"><img src="https://img.shields.io/github/last-commit/hyperzlib/DG-Lab-Coyote-Game-Hub"></a>
</div>
<p></p>
<div align="center">
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/actions">ダウンロード</a>
  |
  <a href="https://www.bilibili.com/video/BV17m421G7fm/">プレビュー</a>
  |
  <a href="docs/api.md">プラグインAPI</a>
</div>
<p></p>
<div align="center">
  <img src="https://raw.githubusercontent.com/hyperzlib/DG-Lab-Coyote-Game-Hub/main/docs/images/screenshot-widget.png" height="200" alt="ウィジェットスクリーンショット">
</div>

## 注意事項

配信プラットフォームの関連規定を遵守し、本コンポーネントを違反して使用しないでください。本コンポーネントの使用により配信チャンネルの禁止等の結果が生じた場合、当コンポーネントの作者は一切責任を負いません。

## 使用方法（Windowsバイナリ配布版）

1. [Releases](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases) から ```coyote-game-hub-windows-amd64-dist.zip``` をダウンロード：[クリックで移動](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases)
2. 解凍後、```start.bat``` を実行してサーバーを起動

## 使用方法（Linux/MacOSコマンドライン）
1. nodejsをインストール（Linuxではnvmの使用を推奨、Macは ```brew install node@22``` を使用）
2. [Releases](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases) から ```coyote-game-hub-nodejs-server.zip``` をダウンロード：[クリックで移動](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases)
3. 解凍したディレクトリで ```node server/index.js``` を実行

## 使用方法（ビルド使用）

（以下の例では依存関係のインストールに ```pnpm``` を使用していますが、```npm``` または ```yarn``` も使用可能です）

1. ```server``` ディレクトリに入り、```pnpm install``` を実行して依存関係をインストール

2. ```frontend``` ディレクトリに入り、```pnpm install``` を実行して依存関係をインストール
3. プロジェクトのルートディレクトリで```pnpm install```を実行して依存関係をインストールし、```npm run build```を実行してプロジェクトをビルドします

4. プロジェクトのルートディレクトリで```npm start```を実行してサーバーを起動します

5. ブラウザで```http://localhost:8920```を開くと、コントロールパネルが表示されます

## プロジェクト構造

- ```server```：サーバー側コード
- ```frontend```：フロントエンドコード



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-27

---