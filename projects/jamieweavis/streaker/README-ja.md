# Streaker <img alt="Streaker Logo" align="right" width=40 height=40 alt="Screenshot" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/./.github/icons/icon.svg">

リマインダー通知付きのクロスプラットフォームGitHub貢献連続記録および統計追跡メニューバーアプリケーション

[![ci](https://github.com/jamieweavis/streaker/actions/workflows/ci.yml/badge.svg)](https://github.com/jamieweavis/streaker/actions)
[![downloads](https://img.shields.io/github/downloads/jamieweavis/streaker/total.svg)](https://github.com/jamieweavis/streaker/releases)
[![version](https://img.shields.io/github/release/jamieweavis/streaker.svg)](https://github.com/jamieweavis/streaker/releases)
[![license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/jamieweavis/streaker/blob/main/LICENSE)

<img width="716" alt="Screenshot" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/screenshot.png">

## インストール

最新バージョンのStreakerは**[GitHubリリース](https://github.com/jamieweavis/streaker/releases)**ページからダウンロードしてください（または**[開発](#development)**セクションで自分でビルドする方法もあります）。

## 特徴

- メニューバーの貢献統計
  - 連続記録
    - 最高記録
    - 現在の連続
    - 前回の連続
  - 貢献数
    - 最多（日）
    - 今日
    - 合計（年）
- メニューバーのアイコンは貢献状況に応じて変化
  - 空白 - 今日貢献していない
  - 塗りつぶし - 今日貢献している
  - 王冠 - 現在最高連続記録中
- 3種類のメニューバーアイコンテーマ
  - 炎
  - タイル
  - オクトキャット
- 連続記録を失わないためのリマインダー通知

### メニューバーアイコン

#### ライトモード

| 状態 | 火炎 | タイル | オクトキャット |
| ----- | ----- | ---- | ------- |
| 保留中 | <img width="20" alt="Flame Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-flame-mac.svg"> | <img width="20" alt="Tile Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-tile-mac.svg"> | <img width="20" alt="Octocat Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-octocat-mac.svg"> |
| 貢献済み | <img width="20" alt="Flame Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-flame-mac.svg"> | <img width="20" alt="Tile Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-tile-mac.svg"> | <img width="20" alt="Octocat Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-octocat-mac.svg"> |
| 連続中 | <img width="20" alt="Flame Crown" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-flame-mac.svg"> | <img width="20" alt="Tile Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-tile-mac.svg"> | <img width="20" alt="Octocat Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-octocat-mac.svg"> |

#### ダークモード

| 状態 | 火炎 | タイル | オクトキャット |
| ----- | ----- | ---- | ------- |
| 保留中 | <img width="20" alt="Flame Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-flame-mac-white.svg"> | <img width="20" alt="Tile Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-tile-mac-white.svg"> | <img width="20" alt="Octocat Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-octocat-mac-white.svg"> |
| 貢献済み | <img width="20" alt="Flame Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-flame-mac-white.svg"> | <img width="20" alt="Tile Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-tile-mac-white.svg"> | <img width="20" alt="Octocat Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-octocat-mac-white.svg"> |
| 連続中 | <img width="20" alt="Flame Crown" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-flame-mac-white.svg"> | <img width="20" alt="Tile Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-tile-mac-white.svg"> | <img width="20" alt="Octocat Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-octocat-mac-white.svg"> |

## 開発

### 前提条件

- [Node.js](https://github.com/nodejs/node) (>=22.x.x)
- [pnpm](https://github.com/pnpm/pnpm) (>=10.x.x)

### はじめに

リポジトリをクローンし、依存関係をインストールします:

```sh
git clone https://github.com/jamieweavis/streaker.git

cd streaker

pnpm install
```
現在のプラットフォーム向けにアプリをパッケージ化する:

```bash
pnpm package
```
_パッケージ化されたアプリは現在 `out/` ディレクトリにあります_

開発モードでアプリを実行する:

```bash
pnpm start
```
*現在、ホットリロードをサポートしているのはレンダラープロセスのみで、`src/main/` の変更は再起動が必要です*

## 関連

- [Streaker CLI](https://github.com/jamieweavis/streaker-cli) - ASCII貢献グラフ付きのGitHub貢献連続記録＆統計追跡コマンドラインアプリケーション
- [Contribution](https://github.com/jamieweavis/contribution) - GitHub貢献グラフパーサー。ユーザーのGitHub貢献グラフページから貢献連続記録とコミット統計を計算します



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-11

---