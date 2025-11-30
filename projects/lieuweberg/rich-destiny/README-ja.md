![GitHub all releases](https://img.shields.io/github/downloads/lieuweberg/rich-destiny/total) ![GitHub release (latest by date)](https://img.shields.io/github/downloads/lieuweberg/rich-destiny/latest/total) ![Time spent coding (15 minute timeout)](https://wakatime.com/badge/user/a637a12a-da87-4487-8b1e-660151dc3e7b/project/94fa2fc6-7e9b-4c74-b6eb-4ce6a09b4cdf.svg)

# rich-destiny
| <img src="https://richdestiny.app/favicon.ico" width="100"> | Discordのステータスに現在のDestiny 2のアクティビティを表示するプラグアンドプレイのバックグラウンドプログラム。モダンで、スクリーンショットを使わず、サイズも小さいです。 |
| :---: | :---: |

## 貢献について ✨

もし貢献したい場合は素晴らしいです！新機能については、まずDiscordサーバーで相談するか、作りたい内容を記載したIssueを作成してください。バグ修正の場合は、直接PRを作成してください。ただし「バグではなく機能です」ということもあるので、相談することを推奨します。

## 開発 🛠
前提条件:
 - (クライアント) 最近のGo 1.xバージョンをインストールしていること。
 - (クライアント) Windowsの場合はgit bashが必要です。ビルドスクリプトのコマンドは手動で実行しても構いませんが、私はbashスクリプトを使っています :)
 - (ウェブ) Node.jsとnpmの最近のバージョンをインストールしていること。

ビルド方法:
 - リポジトリをクローンします。
  
 - クライアント:
   - `cd client`
   - `config.go.example`を複製して`config.go`にし、値を入力します。リダイレクトURIには`https://richdestiny.app/login`を使用できます — Bungie.netの開発者ポータルでも同様です。これはlocalhostのリダイレクトへのリダイレクトにすぎません。
   - `go get`
   - `./build dev`
     - 有効なsemverのバージョン番号を使って`./build vX.Y.Z`も可能ですが、開発目的の場合はdevを使ってください。これにより自動的にアップデートや将来的に他の機能が無効になります。

 - ウェブサイト:
   - `cd web`
   - `npm install`
   - ローカル開発サーバーは`npm run start`、本番ビルドは`npm run build`を実行してください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-30

---