<div align="center">
    <h1>GitQuill</h1>
    <img alt="Logo" src="https://raw.githubusercontent.com/adamsol/GitQuill/master/img/logo.jpg" width="200" />
    <h2>GitのクロスプラットフォームGUI。</h2>
</div>

| ![](https://raw.githubusercontent.com/adamsol/GitQuill/master/img/screenshots/commit-history.png) | ![](https://raw.githubusercontent.com/adamsol/GitQuill/master/img/screenshots/file-diff.png) |
|-----------------------------------------|------------------------------------|


ユニークな機能
---------------

* 差分ビューで直接ファイルを編集。
* ファイル拡張子ごとに特定の構文ハイライトを選択可能。
* リベースツールで過去のコミットを素早く修正。
* コミットメッセージから課題管理ツールへのリンクを設定。
* 任意のGitコマンドをボタンで実行できるように設定可能。


動作要件
------------

* [Git](https://git-scm.com/) 2.23以上
* [Node.js](https://nodejs.org/) 18以上


インストール
-----------

```sh
npm install
npm run build
npm start
```


ノート
-----

* GitQuill は、従来のスタッシュではなくブランチを使用して作業中（WIP）の保存/復元を行う独自の仕組みを持っています。これは、Git のスタッシュに技術的な問題があり、UI に一貫して統合するのが難しいためです。
* ファイルを選択した状態でリベースを開始すると、GitQuill はインデックス内のコミット全体の内容を元に戻しつつ、作業ツリーには保持するため、アプリケーションを離れずにファイル編集が可能です。
* コンフリクトが検出されると、GitQuill は未マージファイルを自動的にリセットし、扱いが複雑になる特殊なリポジトリ状態を避けます。コンフリクトマーカーは手動で解決するために残されます。
* GitQuill はリポジトリ内のファイル変更を監視しません。ステータスはアプリケーションがフォーカスを受け取ったときや、UI で関連する操作を行ったときに更新されます。
* GitQuill は `git` コマンドを直接呼び出します。実行されたすべての操作は各リポジトリのログファイル `.git/.quill/app.log` で確認できます。


設定
-------------

* リポジトリごとの設定ファイル：`.git/.quill/config.json5`。例：

  ```js
  {
      autolinks: [
          ['#(\\d+)', 'https://github.com/adamsol/GitQuill/issues/$1'],
      ],
      custom_actions: [
          { icon: 'mdi-download-outline', label: 'Pull', command: ['pull'] },
          { icon: 'mdi-upload-outline', label: 'Push', command: ['push'], click_twice: true },
      ],
  }
  ```
* グローバル、自動設定ファイル（オープンリポジトリ、UIレイアウトなど）：Windowsの場合は`%AppData%/GitQuill/config.json`；他のプラットフォームについては https://electronjs.org/docs/api/app#appgetpathname を参照してください。


Contributing
------------

プロジェクトに興味を持っていただきありがとうございます！私は基本的にプルリクエストを受け付けていません。最良の貢献方法は、[Issues](https://github.com/adamsol/GitQuill/issues)を通じてバグを報告するか機能を提案することです。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---