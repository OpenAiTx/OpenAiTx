# VSCode as MCP Server

[Marketplace](https://marketplace.visualstudio.com/items?itemName=acomagu.vscode-as-mcp-server)

VSCodeをMCPサーバーに変えるVSCode拡張機能で、Claude DesktopのようなMCPクライアントから高度なコーディング支援を可能にします。

## 主な機能

### コード編集サポート
- LLMからの提案コード変更をdiffで確認し、承認、拒否、フィードバックを提供可能。
- リアルタイムの診断メッセージ（例：型エラー）を即座にLLMへ送信し、即時修正を促進。

![コード編集のdiff](https://storage.googleapis.com/zenn-user-upload/778b7e9ad8c4-20250407.gif)

### ターミナル操作
- VSCode統合ターミナル内でコマンド実行（バックグラウンド/フォアグラウンド実行やタイムアウト設定に対応）。

### プレビューツール
- VSCode内蔵ブラウザでURLを直接プレビュー（例：Viteサーバー起動後に自動でブラウザプレビューを開く）。

![プレビューツール](https://storage.googleapis.com/zenn-user-upload/8968c9ad3920-20250407.gif)

### マルチインスタンス切替
- 複数の開いたVSCodeウィンドウ間でMCPサーバーを簡単に切り替え（ステータスバーアイテムをクリックするだけ）。

![インスタンス切替](https://storage.googleapis.com/zenn-user-upload/0a2bc2bee634-20250407.gif)

### リレー機能（実験的）
- VSCode 1.99で導入された組み込みMCPサーバーを外部にリレー・公開。
- GitHub Copilotなど他のMCP拡張が提供するツールへの外部アクセスを可能に。

## 利用可能な組み込みツール

- **execute_command**: VSCode統合ターミナルでコマンドを実行
- **code_checker**: 現在のコード診断情報を取得
- **focus_editor**: ファイル内の特定位置にフォーカス
- **list_debug_sessions** / **start_debug_session** / **restart_debug_session** / **stop_debug_session**: デバッグセッション管理
- **text_editor**: ファイル操作（表示、置換、作成、挿入、元に戻す）
- **list_directory**: ディレクトリ内容をツリー形式で一覧表示
- **get_terminal_output**: 指定ターミナルの出力を取得
- **list_vscode_commands** / **execute_vscode_command**: VSCodeの任意のコマンドを一覧表示および実行します
- **preview_url**: VSCodeの統合ブラウザ内でURLを開きます

## インストールと設定

1. [VSCodeマーケットプレイス](https://marketplace.visualstudio.com/items?itemName=acomagu.vscode-as-mcp-server)から拡張機能をインストールします。

2. MCPクライアントを設定します：

    - **mcp-installerを使用する場合**: 「vscode-as-mcp-server MCPサーバーをインストールする」と指示するだけで済みます。
    - **Claude Desktopなどの他のクライアントの場合**: 設定ファイル（`claude_desktop_config.json`）に以下を追加してください：

    ```json
    {
      "mcpServers": {
        "vscode": {
          "command": "npx",
          "args": ["vscode-as-mcp-server"]
        }
      }
    }
    ```
3. VSCodeの右下ステータスバーでMCPサーバーの状態を確認します：

    - （サーバーアイコン）：サーバーが稼働中
    - ∅：クリックしてサーバーを起動

![サーバーステータスインジケーター](https://storage.googleapis.com/zenn-user-upload/321704116d4a-20250408.png)

## 動機

この拡張機能は、メータリングされたコーディングツール（Roo CodeやCursorなど）に伴う高コストを軽減するために開発されました。VSCodeに直接組み込まれた、手頃でセルフホスト可能な代替手段です。

バグ報告やフィードバックは大歓迎です！🙇

## 今後のロードマップ

- 公開する組み込みMCPサーバーの選択機能
- WebViewベースの承認UI（Roo Codeに類似）
- VSCodeのファイル履歴（タイムライン）との統合
- 自動承認やツールの有効化/無効化の即時切り替え
- カスタマイズ可能なサーバーポート設定



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-26

---