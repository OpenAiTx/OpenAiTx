# UnblockPro — DiscordとYouTubeのブロック回避


<p align="center">
  <strong>macOSとWindows向けの自動DPIバイパス</strong><br>
  クリック一つでDiscord、YouTube、その他のサービスをアンロック
</p>

<p align="center">
  <a href="https://github.com/by-sonic/unblock-pro/releases/latest"><img src="https://img.shields.io/github/v/release/by-sonic/unblock-pro?style=for-the-badge&color=blue&label=version" alt="Version"></a>
  <a href="https://github.com/by-sonic/unblock-pro/releases/latest"><img src="https://img.shields.io/github/downloads/by-sonic/unblock-pro/total?style=for-the-badge&color=green&label=downloads" alt="Downloads"></a>
  <a href="https://github.com/by-sonic/unblock-pro/blob/main/LICENSE"><img src="https://img.shields.io/github/license/by-sonic/unblock-pro?style=for-the-badge&color=purple" alt="License"></a>
  <img src="https://img.shields.io/badge/platform-macOS%20%7C%20Windows-blue?style=for-the-badge" alt="Platform">
</p>

---

## ダウンロード

| プラットフォーム | ファイル | 説明 |
|-----------|------|----------|
| **macOS** Apple Silicon (M1/M2/M3/M4) | [UnblockPro-mac-arm64.zip](https://github.com/by-sonic/unblock-pro/releases/latest) | Mチップ搭載Mac用 |
| **macOS** Intel | [UnblockPro-mac-x64.zip](https://github.com/by-sonic/unblock-pro/releases/latest) | Intel搭載Mac用 |
| **Windows** | [UnblockPro-win-setup.exe](https://github.com/by-sonic/unblock-pro/releases/latest) | インストーラー |
| **Windows** | [UnblockPro-win-portable.exe](https://github.com/by-sonic/unblock-pro/releases/latest) | ポータブル版（インストール不要） |

> [Releases](https://github.com/by-sonic/unblock-pro/releases/latest) にアクセスして、ご使用のOSに合ったバージョンをダウンロードしてください

---

## これは何？

**UnblockPro** は、DPIブロックを回避するためのデスクトップアプリケーションで、VPNなしでDiscord、YouTube、その他のサービスを利用できます。macOSとWindowsで動作します。

### 主な機能

- **ワンクリック** — 「接続」ボタンを押すだけで動作開始
- **自動戦略選択** — アプリがユーザーのプロバイダーに最適な回避方法を自動で見つける
- **接続確認** — 戦略は実際のリクエストで検証され、推測ではない
- **macOS + Windows** — 両プラットフォームを完全サポート
- **自動起動** — システムと一緒に起動します  
- **自動接続** — 起動時に自動的に接続します  
- **システムトレイ** — バックグラウンドで動作し、邪魔になりません  
- **安全なクリーンアップ** — 終了時にプロキシ設定が自動的にリセットされます  

---

## 仕組み

UnblockProはDeep Packet Inspection（DPI）を回避するために[zapret](https://github.com/bol-van/zapret)技術を使用しています：

| プラットフォーム | 方法 |
|-----------|-------|
| **macOS** | `tpws` — パケットを改変するSOCKS5プロキシ。アプリは自動的にシステムプロキシを設定します |
| **Windows** | `winws` — WinDivertドライバレベルでパケットを傍受。プロキシ設定は不要です |

アプリは複数の戦略（split+disorder、split-tls、methodeol、oobなど）を順にテストし、あなたのプロバイダに合った動作する方法を見つけます。

---

## インストール

### macOS

1. [Releases](https://github.com/by-sonic/unblock-pro/releases/latest)から`UnblockPro-*-mac.zip`をダウンロードしてください  
2. ZIPを解凍し、`UnblockPro.app`を「アプリケーション」フォルダにドラッグしてください  
3. **ターミナルを開き、以下のコマンドを実行してください：**  

```bash
xattr -cr /Applications/UnblockPro.app
```
4. アプリケーションを起動し、「接続」をクリックします

> **このコマンドはなぜ必要ですか？** macOSは有料のApple Developer署名（年間99ドル）がないアプリをブロックします。`xattr -cr`コマンドは検疫フラグを解除します — これは安全で、プロジェクトのコードは完全にオープンです。IntelおよびApple Silicon（M1/M2/M3）で動作します。

### Windows

1. [Releases](https://github.com/by-sonic/unblock-pro/releases/latest)からインストーラーまたはポータブル版をダウンロードします
2. 管理者として実行します
3. 「接続」をクリックします

> **重要:** WindowsではWinDivertの動作に管理者権限が必要です

---

## スクリーンショット

<p align="center">
  <em>メイン画面 — 接続状態、一クリックで操作可能</em>
</p>

---

## FAQ

<details>
<summary><strong>これはVPNですか？</strong></summary>
いいえ。UnblockProはトラフィックを暗号化せず、リモートサーバー経由でルーティングしません。ローカルでネットワークパケットを変更し、プロバイダーのDPIシステムがDiscord/YouTubeへのリクエストを検出・ブロックできないようにします。
</details>

<details>
<summary><strong>安全ですか？</strong></summary>
はい。アプリはオープンソースで、データを収集せず、トラフィックをサードパーティのサーバーに送信しません。コードはすべて監査可能です。
</details>

<details>
<summary><strong>アプリがクラッシュしたらどうなりますか？</strong></summary>
プロキシ設定は正常終了、異常終了、killによる終了時いずれの場合も自動的にリセットされます。次回起動時にも設定は信頼性のためにクリアされます。
</details>


<details>
<summary><strong>Discord/YouTube がまだ動作しない場合</strong></summary>
切断して再接続を試みてください — アプリケーションは他の戦略を試みます。どれも効果がなければ、プロバイダーが高度な DPI を使用している可能性があります — Issue を作成してください。
</details>

<details>
<summary><strong>macOS: 「ファイルが開けませんでした」 / Gatekeeper</strong></summary>

ターミナルを開き、以下を実行してください：
```bash
xattr -cr /Applications/UnblockPro.app
```
これでアプリケーションは正常に起動します。これは一度だけ行えば十分です。

もし`.zip`をダウンロードして別のフォルダに解凍した場合は、`/Applications/UnblockPro.app`の代わりに`.app`へのパスを指定してください。
</details>

---

## 開発

```bash
# Клонировать репозиторий
git clone https://github.com/by-sonic/unblock-pro.git
cd unblock-pro

# Установить зависимости
npm install

# Запустить в режиме разработки
npm start

# Собрать для текущей ОС
npm run build

# Собрать для macOS
npm run build:mac

# Собрать для Windows
npm run build:win
```

---

## スタック

- **Electron** — クロスプラットフォームフレームワーク
- **zapret** — DPI回避エンジン ([bol-van/zapret](https://github.com/bol-van/zapret))
- **electron-builder** — ビルドと配布
- **GitHub Actions** — リリース時の自動ビルド

---

## ライセンス

[MIT](LICENSE) — 自由な使用、改変、配布が可能。

---

<p align="center">
  <strong>by sonic</strong><br>
  <sub>プロジェクトが役に立ったら⭐️を押してください</sub>
</p>

---

### キーワード / Keywords

> discord アンロック, youtube アンロック, discord ブロック回避, youtube ブロック回避, dpi バイパス, アンチブロック, discord アンロック, discord ロシア, youtube ロシア, zapret gui, dpi 回避, discord unblock russia, youtube unblock russia, anti dpi, bypass discord block, unblock discord, unblock youtube


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-08

---