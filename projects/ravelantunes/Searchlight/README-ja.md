# Searchlight - Postgres MacOS クライアント

![Searchlightのスクリーンショット](https://raw.githubusercontent.com/ravelantunes/Searchlight/main/./docs/screenshot1.png)

SearchlightはネイティブなmacOS向けのオープンソースPostgreSQLクライアントで、シンプルで軽量かつ開発者に優しい設計です。フルスケールのデータベース管理ツールの複雑さを排除し、データベースの管理やクエリの実行を直感的かつクリーンなインターフェースで提供します。SearchlightはPostgreSQLデータベースへの迅速かつ簡単なアクセスを必要とする開発者に対して、スムーズで効率的な体験を届けることに注力しています。

## インストール

最新リリースは[リリースページ](https://github.com/ravelantunes/Searchlight/releases)からダウンロードしてください。

> 私は個人のApple開発者アカウントを使用しているため、Appleによるアプリの公証ができません。GitHubのリリースページからインストールしようとすると、MacOSが開発者の身元を確認できないと警告しますので、設定 > プライバシーでインストールを許可する必要があります。またはソースからビルドしてください。

## 現在の機能

### 接続管理

- お気に入り接続の保存と管理
- キーベース認証によるSSHトンネルサポート
- SSL/TLS接続サポート

### データベースブラウザ

- データベース、スキーマ、テーブルの閲覧
- テーブルデータのクイック検索とフィルター
- 外部キー関係のリンク機能 — 関連レコードへのクリックナビゲーション
- カラム統計ポップオーバー — ユニーク値、NULLカウント、値の分布チャートの表示

### データ操作

- テーブル内での新規行挿入
- セル値、行、カラムのコピー（複数フォーマット対応）
- データ挿入時の外部キー参照からの自動補完/データ参照
- エクスポートフォーマット：プレーンテキスト、CSV、SQL INSERT文

### クエリエディタ

- 自由形式のSQLクエリ実行
- SQL LSPサポートによる自動補完、診断、ホバー時ドキュメント表示

## ソースからのビルド
1. リポジトリをクローンする  
2. Xcodeで`Searchlight.xcodeproj`を開く  
3. 2回ビルドする（⌘B、⌘B）— 最初のビルドで依存関係をダウンロードし、2回目でそれらを組み込む  
4. 実行する（⌘R）  

最初のビルドは自動的にSQLの自動補完、構文チェック、ホバー表示用の[Postgres Language Server](https://github.com/supabase-community/postgres-language-server)バイナリ（約16MB）をダウンロードします。アプリにバンドルするには2回目のビルドが必要です。  

> **注意：** LSPバイナリはApple Silicon（arm64）のみ対応しています。  

## 技術スタック  

- **Swift & SwiftUI** — 高度なテーブルビューのためにAppKit統合を行ったネイティブmacOSアプリ  
- **PostgresKit / PostgresNIO** — コネクションプーリング対応のPostgreSQLドライバー  
- **SwiftNIO** — 非同期ネットワーク基盤  
- **System SSH** — macOSのシステムツールを使用したネイティブSSHトンネルサポート  
- **Postgres Language Server** — SQLインテリジェンス（自動補完、診断、ホバードキュメント）  

## コントリビュート  

貢献は歓迎します！問題の報告やプルリクエストの提出をお気軽にどうぞ。  

## ライセンス  

詳細は[LICENSE](LICENSE)を参照してください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-09

---