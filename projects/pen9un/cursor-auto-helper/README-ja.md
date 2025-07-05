<h1 align="center">ご利用ありがとうございます&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> Cursor自動継続ツール、Cursor自動リトライ、Cursor自動確認、Cursor使用量統計、Cursor拡張ツール、Cursor補助ツール、Cursor自動化ツール、Cursorテーマ設定、Cursor Auto Continue Tool、Cursor Auto Retry Tool、Cursor Auto Confirm Tool、Cursor Usage Statistics Tool、Cursor Efficiency Tool、Cursor Automation Tool、Cursor Theme Settings、Cursor after 25 tool calls、Cursor Tool Call Limit🔧🤖🚀
> 

## 🏠 [ホームページ](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper は Cursor IDE 専用に設計された自動化拡張ツールで、使用量のリアルタイム表示、25回の会話制限の自動処理、ネットワーク接続失敗、確認プロンプトなどのシナリオを自動対応し、開発体験をよりスムーズにします。

**動画デモ：** [Cursor Auto Helper デモ動画](https://www.bilibili.com/video/BV1cajKzCEzv/)

高品質なプロンプト、しっかりしたプロジェクト要件設計があれば、このプログラムはCursorが人手を介さずにプロジェクトを自動で完了できるようにします。

> 🔒 **バージョン互換性**：現在、Cursor 0.49.6 および Cursor 1.0.0 バージョンで開発・テスト済み。理論的には Cursor 0.48.x - 1.0.0 バージョンに互換。

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖更新履歴

- 2025-06-01 v2.3 バージョンリリース、Cursor テーマ設定機能追加、コード注入の安定性向上、使用量表示が公式フォーマットと一致
- 2025-05-21 v2.1 バージョンリリース、アーキテクチャをリファクタリング、マルチプラットフォーム対応、リアルタイム使用量表示機能追加など
- 2025-04-25 v1.0 バージョン完成、25回会話制限自動処理、ネットワーク接続失敗・確認プロンプト自動対応など
- 2025-04-20 プロジェクト開始

## 🌟 Cursor Auto Helper ベストプラクティス

注：以下のドキュメントはCursor等のAIによる生成も可能ですが、必ず人による確認・調整が必要です。

**STEP 1：** プロジェクトシステム要件を詳細に設計（要件整理が明確なほど、プロジェクト品質が向上）、高品質なプロジェクト開発プロンプト **SYSTEM.md** を作成

**STEP 2：** **SYSTEM.md** に基づき、高品質なシステム開発設計ドキュメント **DESIGN.md** を出力

**STEP 3：** **SYSTEM.md** と **DESIGN.md** に基づき、高品質な開発計画ドキュメント **TODOLIST.md** を出力

**STEP 4：** **Cursor Auto Helper** を使用し、**SYSTEM.md**、**DESIGN.md**、**TODOLIST.md** を指定。自動継続プロンプトを使い、Cursorが開発計画に従ってプロジェクト開発を自動で進行し、完了するまで継続

**Cursor Auto Helper 自動継続プロンプト例：**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md 必ずTODOLIST開発計画に従って後続機能を開発し、随時TODOLIST開発計画を更新・記録してください。各作業完了後には「続けますか」と私に確認し、プロジェクト完了時には「プロジェクトは完了しました」と返してください。
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 使用方法

Starで応援をお願いします。ご質問等は [Issues](https://github.com/pen9un/cursor-auto-helper/issues) へどうぞ。

### 📝 設定ファイルについて

設定ファイル `config.ini` は**自動化挙動のカスタマイズ**用です（必要に応じて設定・テスト可能）。以下の設定項目に対応しています。

#### 基本設定
```ini
[common]
log_enable = true     # ログ有効/無効。記録不要な場合はfalseに変更

[cursor]
path = C:\Path\To\Cursor.exe  # Cursor IDEのインストールパス。自動でパス検出しますが、見つからない場合はここを修正
```

#### 自動アクション設定
各自動アクションは `action名.` をプレフィックスとし、以下のフィールドに対応：

- `type`：アクションタイプ
  - `click`：ボタンクリック
  - `input_and_submit`：入力して送信

- `text` / `text_list`：一致するテキスト内容
  - `text`：単一文字列
  - `text_list`：| 区切りの複数文字列。ページ内にいずれかが含まれれば発動

- `button_selector`：クリック対象ボタンのCSSセレクタ（`click`タイプのみ）
- `button_text`：ボタンのテキスト内容（任意、さらに限定したい場合）
- `input_box_selector`：入力ボックスのCSSセレクタ（`input_and_submit`タイプで必要）
- `input_content`：自動入力する内容
- `submit_btn_selector`：送信ボタンのCSSセレクタ
- `delay`：アクション実行前の遅延（ミリ秒）、ページ描画待ち用

##### 設定例
```ini
[auto_actions]
# 接続失敗時の自動リトライ
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# after 25 tool calls
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "请继续"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
```
action_continue.delay = 1000

# 自動確認続行
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **注意：**
> 1. 各 action の名前（例：`action_retry`、`action_continue`）はカスタマイズ可能ですが、同じ action の全てのフィールドのプレフィックスは統一してください
> 2. CSS セレクターはブラウザの開発者ツールで特定し、正確性を確保してください
> 3. 設定ファイルを変更した後は、プログラムを再起動する必要があります

## 🎯 利用シーン

### 💼 長時間対話開発
- 25回の対話制限を自動で処理し、連続した長時間の対話開発をサポート。対話フローを自動で継続し、開発効率を向上。

### 👥 ネットワーク不安定時
- ネットワーク異常を自動検知し、インテリジェントに再接続を試み、対話を自動で回復。開発の連続性を確保。

### 🏢 確認シーン
- 確認プロンプトのシーンをインテリジェントに認識し、自動で確認処理を実行。手動介入を削減。

### 📚 使用量モニタリング
- 対話回数をリアルタイムでカウントし、Cursorの使用量をモニタリング。利用データを記録し、効率化を支援。

ターミナルでの使用量表示：

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Cursor IDEでの使用量表示：

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟機能説明

### 🤖 長時間対話の自動継続
- Cursorの25回対話制限を自動で処理し、複数回の連続対話をサポート。

### 🎨 接続自動再試行
- ネットワーク接続失敗を自動で検出し、インテリジェントに再試行。接続状態をリアルタイム監視。

### 📱 確認プロンプト自動対応
- 複数の確認プロンプトシーンをインテリジェントに認識し、確認ダイアログを自動で処理。
- カスタム確認内容とレスポンスをサポートし、手動介入を削減。
- 柔軟なルール設定で多様な開発フローに対応。

### 🛍️ 使用量統計
- 対話回数と使用量をリアルタイムでカウントし、自動でデータを記録。
- 使用量データを可視化表示し、分析と最適化が容易。
- ターミナルのカラーログ表示やIDEの使用量パネルをサポートし、使いやすさ向上。

### 💡 ログシステム
- 複数レベルのログ（DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL）、ターミナルでのカラフルな出力。
- ログファイルは日付ごとに自動生成され、ファイル記録とドラッグ＆ドロップ表示パネルをサポート。
- リアルタイムパネルで開発者が監視・追跡しやすい設計。

### 🔒 バージョン互換性とパフォーマンス最適化
- Cursor 0.49.6に基づいて開発、コア機能は完全にテスト済み。
- 特定バージョンに最適化し、Cursorのバージョンアップデートを継続的にフォロー。
- 安定性・互換性が高く、商用環境にも適応。

## 🔮効果デモ

### 🤖 自動対話継続

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Cursor自動完了プログラムデモ

プロジェクト要件から実装完了まで、全て自動で完了：

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝作者

👤 **pen9un**

* ウェブサイト: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️サポート

本プロジェクトが役立った場合は、ぜひ無料の ⭐️⭐️ をお願いします。

## ✨スター履歴

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 アクセス統計

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---