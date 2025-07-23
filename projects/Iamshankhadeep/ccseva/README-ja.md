
# CCSeva 🤖

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![GitHub release](https://img.shields.io/github/release/Iamshankhadeep/ccseva.svg)](https://github.com/Iamshankhadeep/ccseva/releases)
[![Build Status](https://img.shields.io/github/actions/workflow/status/Iamshankhadeep/ccseva/ci.yml?branch=main)](https://github.com/Iamshankhadeep/ccseva/actions)
[![Downloads](https://img.shields.io/github/downloads/Iamshankhadeep/ccseva/total.svg)](https://github.com/Iamshankhadeep/ccseva/releases)
[![macOS](https://img.shields.io/badge/macOS-10.15%2B-blue)](https://github.com/Iamshankhadeep/ccseva)

Claude Codeの使用状況をリアルタイムで追跡する、美しいmacOSメニューバーアプリ。トークン消費、コスト、使用パターンをエレガントなインターフェースで監視します。

## スクリーンショット

![Dashboard](https://raw.githubusercontent.com/Iamshankhadeep/ccseva/main/./screenshots/dashboard.png)
![Analytics](https://raw.githubusercontent.com/Iamshankhadeep/ccseva/main/./screenshots/analytics.png)
![Terminal](https://raw.githubusercontent.com/Iamshankhadeep/ccseva/main/./screenshots/terminal.png)

## 機能

- **リアルタイム監視** - 30秒ごとの更新でトークン使用量をライブ追跡
- **メニューバー統合** - 色分けされたステータス付きのパーセンテージ表示
- **スマートプラン検出** - Pro/Max5/Max20/カスタムプランを自動検出
- **使用分析** - 7日間チャート、モデル別内訳、トレンド分析
- **スマート通知** - 70％および90％の閾値でクールダウン付きアラート
- **コスト追跡** - 日別コスト推定と燃焼率計算
- **美しいUI** - グラデーションデザインとグラスモーフィズム効果

## インストール

### ダウンロード（推奨）
[GitHub Releases](https://github.com/Iamshankhadeep/ccseva/releases)から最新リリースをダウンロードしてください：
- **macOS（Apple Silicon）**: `CCSeva-darwin-arm64.dmg`
- **macOS（Intel）**: `CCSeva-darwin-x64.dmg`

### ソースからビルド

```bash
git clone https://github.com/Iamshankhadeep/ccseva.git
cd ccseva
npm install
npm run build
npm start
```
### 開発

```bash
npm run electron-dev  # Hot reload development
```
## 使い方

1. **起動** - メニューバーにCCSevaが表示されます
2. **クリック** - 詳細な使用統計を表示します
3. **右クリック** - 更新および終了オプションにアクセスします

アプリは`~/.claude`ディレクトリからClaude Codeの設定を自動検出し、30秒ごとに更新します。

## 必要条件

- macOS 10.15以上
- Node.js 18以上（ソースからのビルド用）
- Claude Code CLIがインストールおよび設定済み

## 技術スタック

- Electron 36 + React 19 + TypeScript 5
- Tailwind CSS 3 + Radix UIコンポーネント
- データ統合用ccusageパッケージ

## ライセンス

MITライセンス - 詳細は[LICENSE](LICENSE)ファイルを参照してください。

## クレジット

[Electron](https://electronjs.org)、[React](https://reactjs.org)、[Tailwind CSS](https://tailwindcss.com)、および[ccusage](https://github.com/ryoppippi/ccusage)を使って❤️で作成。

---

**注意**: これはClaude Codeの使用状況を追跡する非公式ツールです。有効なClaude Codeのインストールと設定が必要です。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---