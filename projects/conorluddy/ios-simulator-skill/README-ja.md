# iOSシミュレーター用スキル for Claude Code

iOSアプリのテストとビルドのための本番対応オートメーション。人間の開発者とAIエージェントの両方に最適化された21のスクリプト。

これは基本的に私のXCode MCPのスキル版です: [https://github.com/conorluddy/xc-mcp](https://github.com/conorluddy/xc-mcp)

MCPはアクティブ時に多くのトークンをコンテキストウィンドウに読み込みますが、非常にうまく機能するようです。スキルはコンテキストを一切読み込みません。次はプラグインを作成してバランスを探ります...

更新: プラグイン版では異なるツールグループのMCPを簡単に無効化できます。使用中のツールだけを有効にしてコンテキストウィンドウを最適化しましょう。例: xcodebuild [https://github.com/conorluddy/xclaude-plugin](https://github.com/conorluddy/xclaude-plugin)

## 何をするか

UIが変わると壊れるピクセルベースのナビゲーションの代わりに：

```bash
# Fragile - breaks if UI changes
idb ui tap 320 400

# Robust - finds by meaning
python scripts/navigator.py --find-text "Login" --tap
```
アクセシビリティAPI上のセマンティックナビゲーションを使用し、座標ではなく要素の意味に基づいて操作します。異なる画面サイズに対応し、UIの再設計にも耐えます。

## 特徴

- **21の本番用スクリプト** でビルド、テスト、自動化を実現
- **セマンティックナビゲーション** - テキスト、タイプ、IDで要素を検索
- **トークン最適化** - 生のツールに比べ96%削減（デフォルト3〜5行）
- **ゼロコンフィギュレーション** - macOS上のXcodeですぐに動作
- **構造化された出力** - JSONおよびフォーマット済みテキストで解析が容易
- **自動UDID検出** - 毎回デバイスを指定する必要なし
- **バッチ操作** - 複数のシミュレータを一括起動、削除、消去
- **包括的なテスト** - WCAG準拠、ビジュアル差分、アクセシビリティ監査
- **CI/CD対応** - JSON出力、終了コード、自動デバイスライフサイクル

## インストール

### Claude Code Skillとして


```bash
# Personal installation
git clone https://github.com/conorluddy/ios-simulator-skill.git ~/.claude/skills/ios-simulator-skill

# Project installation
git clone https://github.com/conorluddy/ios-simulator-skill.git .claude/skills/ios-simulator-skill
```

クロードコードを再起動します。スキルは自動的に読み込まれます。

### リリースから

```bash
# Download latest release
curl -L https://github.com/conorluddy/ios-simulator-skill/releases/download/vX.X.X/ios-simulator-skill-vX.X.X.zip -o skill.zip

# Extract
unzip skill.zip -d ~/.claude/skills/ios-simulator-skill
```

## 前提条件

- macOS 12以上
- Xcode コマンドラインツール（`xcode-select --install`）
- Python 3
- IDB（オプション、インタラクティブ機能用：`brew tap facebook/fb && brew install idb-companion`）

## クイックスタート

```bash
# 1. Check environment
bash ~/.claude/skills/ios-simulator-skill/scripts/sim_health_check.sh

# 2. Launch your app
python ~/.claude/skills/ios-simulator-skill/scripts/app_launcher.py --launch com.example.app

# 3. See what's on screen
python ~/.claude/skills/ios-simulator-skill/scripts/screen_mapper.py
# Output:
# Screen: LoginViewController (45 elements, 7 interactive)
# Buttons: "Login", "Cancel", "Forgot Password"
# TextFields: 2 (0 filled)

# 4. Tap login button
python ~/.claude/skills/ios-simulator-skill/scripts/navigator.py --find-text "Login" --tap

# 5. Enter text
python ~/.claude/skills/ios-simulator-skill/scripts/navigator.py --find-type TextField --enter-text "user@test.com"

# 6. Check accessibility
python ~/.claude/skills/ios-simulator-skill/scripts/accessibility_audit.py
```
## カテゴリ別に整理された21のスクリプト

### ビルド＆開発
- **build_and_test.py** - プロジェクトのビルド、テスト実行、結果解析
- **log_monitor.py** - リアルタイムログ監視

### ナビゲーション＆インタラクション
- **screen_mapper.py** - 現在の画面を解析
- **navigator.py** - 要素の検出と操作
- **gesture.py** - スワイプ、スクロール、ピンチ操作
- **keyboard.py** - テキスト入力とハードウェアボタン
- **app_launcher.py** - アプリのライフサイクル制御

### テスト＆解析
- **accessibility_audit.py** - WCAG準拠チェック
- **visual_diff.py** - スクリーンショット比較
- **test_recorder.py** - 自動テスト記録
- **app_state_capture.py** - デバッグ用スナップショット
- **sim_health_check.sh** - 環境検証

### 高度なテスト＆権限管理
- **clipboard.py** - クリップボード管理
- **status_bar.py** - ステータスバー制御
- **push_notification.py** - プッシュ通知
- **privacy_manager.py** - 権限管理

### デバイスライフサイクル
- **simctl_boot.py** - シミュレーター起動
- **simctl_shutdown.py** - シミュレーターシャットダウン
- **simctl_create.py** - シミュレーター作成
- **simctl_delete.py** - シミュレーター削除
- **simctl_erase.py** - 工場出荷時リセット

完全なリファレンスは**SKILL.md**を参照してください。

## Claude Codeとの連携方法

Claude Codeはリクエストに基づいて自動的にこのスキルの使用を検出します。手動で呼び出す必要はありません。


**会話例:**

```
You: "Set up my iOS app for testing"
Claude: [Uses simctl_boot.py and app_launcher.py automatically]

You: "Tap the login button"
Claude: [Uses navigator.py to find and tap]

You: "Check if the form is accessible"
Claude: [Uses accessibility_audit.py]
```

必要に応じてスクリプトを手動で実行することもできます。

## 使用例

### 例1：ログインフロー

```bash
# Launch app
python scripts/app_launcher.py --launch com.example.app

# Map screen to find fields
python scripts/screen_mapper.py

# Enter credentials
python scripts/navigator.py --find-type TextField --index 0 --enter-text "user@test.com"
python scripts/navigator.py --find-type SecureTextField --enter-text "password"

# Tap login
python scripts/navigator.py --find-text "Login" --tap

# Verify accessibility
python scripts/accessibility_audit.py
```

### 例 2: テストドキュメンテーション

```bash
# Record test execution
python scripts/test_recorder.py --test-name "Login Flow" --output test-reports/

# Generates:
# - Screenshots per step
# - Accessibility trees
# - Markdown report with timing
```

### 例3: ビジュアルテスト

```bash
# Capture baseline
python scripts/app_state_capture.py --output baseline/

# Make changes...

# Compare
python scripts/visual_diff.py baseline/screenshot.png current/screenshot.png
```

### 例4：権限テスト

```bash
# Grant permissions
python scripts/privacy_manager.py --bundle-id com.example.app --grant camera,location

# Test app behavior with permissions...

# Revoke permissions
python scripts/privacy_manager.py --bundle-id com.example.app --revoke camera,location
```

### 例 5: CI/CDにおけるデバイスライフサイクル

```bash
# Create test device
DEVICE_ID=$(python scripts/simctl_create.py --device "iPhone 16 Pro" --json | jq -r '.new_udid')

# Run tests
python scripts/build_and_test.py --project MyApp.xcodeproj

# Clean up
python scripts/simctl_delete.py --udid $DEVICE_ID --yes
```
## 設計原則

**セマンティックナビゲーション**: ピクセル座標ではなく意味（テキスト、タイプ、ID）で要素を検出。UI変更に強く、デバイスサイズを問わず動作。

**トークン効率**: デフォルト出力は3～5行。詳細は `--verbose`、機械解析は `--json` を使用。生ツール比で96％削減。

**アクセシビリティファースト**: iOSアクセシビリティAPIを基盤に信頼性向上。アクセシビリティ利用者に優れ、自動化にも強固。

**ゼロコンフィギュレーション**: XcodeがあればmacOS上で即動作。複雑な設定や設定ファイル不要。

**構造化データ**: スクリプトは生ログでなくJSONや整形テキストを出力。解析、統合、理解が容易。

**自動学習**: ビルドシステムがデバイスの好みを学習し、次回に記憶。

## 要件

**システム:**
- macOS 12以降
- Xcodeコマンドラインツール
- Python 3

**オプション:**
- IDB（対話機能用）
- Pillow（visual_diff.py用: `pip3 install pillow`）

## ドキュメント

- **SKILL.md** - スクリプト完全リファレンスと目次
- **CLAUDE.md** - アーキテクチャと開発者ガイド
- **references/** - 特定トピックの詳細ドキュメント
- **examples/** - 完全自動化ワークフロー

## 出力効率

すべてのスクリプトはデフォルトで出力を最小化:

| タスク | 生ツール | 本スキル | 削減率 |
|------|-----------|-----------|---------|
| 画面解析 | 200行以上 | 5行 | 97.5% |

| ボタンを見つけてタップ | 100行以上 | 1行 | 99% |
| テキスト入力 | 50行以上 | 1行 | 98% |
| ログインフロー | 400行以上 | 15行 | 96% |

この効率性により、AIエージェントの会話は集中かつコスト効率が良くなります。

## トラブルシューティング

### 環境の問題

```bash
# Run health check
bash ~/.claude/skills/ios-simulator-skill/scripts/sim_health_check.sh

# Checks: macOS, Xcode, simctl, IDB, Python, simulators, packages
```

### スクリプトヘルプ

```bash
# All scripts support --help
python scripts/navigator.py --help
python scripts/accessibility_audit.py --help
```

### 要素が見つからない場合

```bash
# Use verbose mode to see all elements
python scripts/screen_mapper.py --verbose

# Check for exact text match
python scripts/navigator.py --find-text "Exact Button Text" --tap
```

## 貢献について

貢献は以下を守ること：
- トークン効率を維持（最小限のデフォルト出力）
- アクセシビリティ優先の設計を遵守
- `--help` ドキュメントをサポート
- CI/CD用に `--json` をサポート
- BlackフォーマッターとRuffリンターを通過
- 型ヒントを含める
- SKILL.mdを更新する

## ライセンス

MITライセンス - 商用利用および配布を許可。

## サポート

- **Issues**: 再現手順付きでGitHub issueを作成
- **ドキュメント**: SKILL.mdおよびreferences/を参照
- **例**: examples/ディレクトリを確認
- **スキルドキュメント**: https://docs.claude.com/en/docs/claude-code/skills

---

**AIエージェントのために構築。開発者に最適化。**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-18

---