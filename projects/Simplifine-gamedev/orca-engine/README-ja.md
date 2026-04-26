## Orca エンジン

Discord: https://discord.gg/bvdpdT26Tq

Godot エンジンをベースに、Simplifine による拡張を加えています。


### 何が特徴ですか？
Godot への完全アクセスを持つチャットボットを統合しています。  
チャットボットは以下が可能です：
  - ファイルの読み取り／編集／作成／削除
  - プロジェクト全体をコンテキストとして理解
  - 画像を生成し、生成した画像間での一貫性を維持
  - Godot ネイティブオブジェクト（ノード、シーンなど）の編集

### AI アシスタントの機能

統合されたチャットボットは Godot 開発のための包括的なツールにアクセス可能です：

#### シーン & ノード管理
- **シーン操作**：シーンの開く、作成、保存、インスタンス化
- **ノード操作**：シーンツリー内のノードの作成、削除、移動、名前変更
- **ノード検査**：ノードのプロパティ、スクリプト、階層情報の取得
- **ノード選択**：エディタで現在選択されているノードの操作
- **クラス探索**：利用可能な全 Godot ノードクラスとその機能へのアクセス

#### スクリプト & コード管理
- **ファイル操作**：任意のプロジェクトファイルの読み取り、書き込み、行単位の編集
- **スクリプト生成**：AIによるコード生成で新しい GDScript ファイルを作成
- **コード編集**：自然言語プロンプトによる既存スクリプトへのインテリジェントな編集適用
- **エラー検出**：単一ファイルまたはプロジェクト全体のコンパイルエラー検査
- **スクリプト添付**：ノードへのスクリプトの添付と管理

#### プロジェクトナビゲーション & 検索
- **ファイルシステム**：フィルタリングオプション付きでプロジェクトのディレクトリやファイルを閲覧
- **高度なセマンティック検索**：自然言語クエリで関連ファイルやコードを関数レベルの知能で検索
- **マルチホップ依存関係追跡**：プロジェクト全体の関数呼び出しチェーンやシグナルの流れを理解
- **グラフ解析**：接続ファイル、中心的なプロジェクトコンポーネント、アーキテクチャの関係性を発見
- **スマート検索モード**：セマンティック（AI理解）、キーワード（正確なテキスト）、ハイブリッド（組合せ）検索

> 🔍 **[高度なインデックス作成ドキュメントを見る](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)** 関数レベルのチャンク処理、シグナルフロー追跡、および依存関係分析に関する技術的詳細

#### ビジュアルコンテンツ作成
- **画像生成**：テキスト記述から様々なアートスタイルの新しい画像を作成
- **画像編集**：AI駆動の編集で既存の画像を修正
- **3Dモデル生成**：テキストプロンプトまたは画像から3Dモデルを生成（設定時）
- **アセット管理**：生成された画像を特定のプロジェクトパスに保存
- **スタイル一貫性**：生成されたアセット間で視覚的一貫性を維持

#### 物理＆ゲームオブジェクト
- **衝突形状**：物理ボディに衝突検出を追加（長方形、円、カプセル）
- **ノードプロパティ**：変換、物理、およびゲームプレイプロパティを変更
- **メソッド呼び出し**：カスタムパラメータでノードメソッドを実行

#### シグナル＆接続システム
- **シグナル検査**：利用可能なシグナルとその接続をリストアップ
- **接続管理**：ノード間のシグナル接続を作成・管理
- **シグナル追跡**：軽量イベント追跡でシグナルフローをデバッグ
- **接続検証**：シグナル接続の整合性を確認

#### 開発ワークフロー
- **マルチモデル対応**：GPT-5、Claude-4、Gemini-2.5、GPT-4oから選択可能
- **リアルタイム支援**：ツール実行フィードバック付きで応答をストリーム
- **エラー回復**：信頼性のためAIプロバイダー間でインテリジェントなフォールバック
- **認証**：OAuth（Google、GitHub、Microsoft）またはゲストモードで安全アクセス

### 高度なインデックス作成システム

Orca Engineは、**最高クラスのGodotインデックス作成システム**を搭載し、コードを**関数レベルで**理解します：

- **🎯 関数レベルのインテリジェンス**：各GDScript関数、シグナル、エクスポートが豊富なメタデータを持つ検索可能な単位に
- **🔗 シグナルフロー追跡**：シグナルの発信 → 接続 → ハンドラのチェーンをプロジェクト全体で完全に理解
- **🕸️ マルチホップ依存関係追跡**：関数呼び出しチェーンを追跡（例：Input → Controller → Physics → Animation）
- **📊 グラフ中心性分析**：構造上重要なファイルとその役割を特定
- **🔍 スマート検索モード**：意味的（AI理解）、キーワード（正確テキスト）、ハイブリッド（両方組み合わせ）検索

**パフォーマンス**：従来の行単位インデックスより約2.7倍インテリジェントなチャンクを実現し、複雑なゲームメカニクスの精密な理解を可能にします。

> 📚 **[技術的詳細：高度なインデックス作成](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)** | **[バックエンドセットアップガイド](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)**

### クイックスタート（エディターのみ）

エディターをビルドして実行します。AI機能はデフォルトで当社のクラウドバックエンドに接続されます。ローカルバックエンドの設定は不要です。

macOS:
```bash
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
brew install scons pkg-config python3 git
scons platform=macos target=editor dev_build=yes vulkan=no -j"$(sysctl -n hw.ncpu)"
./bin/godot.macos.editor.dev.arm64
```
Windows (PowerShell):

```powershell
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
# If needed: scoop install python scons git   (or: choco install python scons git)
scons platform=windows target=editor dev_build=yes vulkan=no -j $env:NUMBER_OF_PROCESSORS
.\bin\godot.windows.editor.dev.x86_64.exe
```

Linux（Ubuntu/Debian）：
```bash
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
sudo apt update
sudo apt install -y build-essential scons pkg-config libx11-dev libxcursor-dev libxinerama-dev \
  libgl1-mesa-dev libglu1-mesa-dev libasound2-dev libpulse-dev libudev-dev libxi-dev libxrandr-dev \
  python3 python3-pip git
scons platform=linuxbsd target=editor dev_build=yes vulkan=no -j"$(nproc)"
./bin/godot.linuxbsd.editor.dev.x86_64
```
注意事項:  
- Vulkan SDKは不要です。エディターはプラットフォームのデフォルトレンダラー（macOSではMetal、WindowsではD3D12、LinuxではGLES3）を使用します。Vulkanはオプションであり、エディターのビルドや実行には必要ありません。  
- クラウドではなくセルフホスト型のバックエンドを指す方法については、以下のバックエンドセクションを参照してください。  

### バックエンド（オプションのローカル / クラウド展開）  

- ローカル開発やセルフホスティングの場合は、**[バックエンドセットアップガイド](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)**に従ってください。環境変数の設定、ローカルでの実行、`backend/deploy.sh`を使ったGoogle Cloud Runへのデプロイ方法が記載されています。  
- 詳細なインデックス作成（関数レベルのチャンク、依存グラフ）については、**[backend/indexing.md](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)**を参照してください。  

#### 環境設定  

APIキーを含む `.env` ファイルを `backend/` ディレクトリに作成してください:


```env
# Required: AI provider for embeddings and chat
OPENAI_API_KEY=YOUR_OPENAI_API_KEY
# ANTHROPIC_API_KEY=YOUR_ANTHROPIC_API_KEY
# GOOGLE_API_KEY=YOUR_GOOGLE_API_KEY

# Required: For advanced vector search and function-level indexing
WEAVIATE_URL=https://YOUR-WEAVIATE-ENDPOINT
WEAVIATE_API_KEY=YOUR_WEAVIATE_API_KEY

# Optional: Additional configuration
FLASK_SECRET_KEY=YOUR_RANDOM_SECRET_KEY

# Development mode (set to 'false' in production)
DEV_MODE=true
```

> ⚙️ **[バックエンド設定ガイドを見る](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)** 完全な環境変数のドキュメントとデプロイ手順について

#### インデックス作成のパフォーマンス（大規模プロジェクト）

エディターはサーバー側のインデックス作成を自動的にトリガーします。大規模なコードベースの場合、これらを設定して速度を上げてください（ローカルの `backend/.env` または `backend/deploy.sh` 実行前に設定し、Cloud Runがシークレットとして認識するようにします）：

```env
# Parallelism and batching
INDEX_MAX_WORKERS=32         # number of parallel file workers on the backend
EMBED_MAX_PARALLEL=12        # concurrent embedding batches (respect provider limits)
EMBED_BATCH_SIZE=256         # embeddings per batch
CHUNK_MAX_LINES=100          # larger chunks = fewer embedding calls

# Small response caches
SEARCH_CACHE_TTL=45
GRAPH_CACHE_TTL=45
```
メモ：
- エディターから環境変数として `INDEX_MAX_WORKERS` を渡すことも可能で、`index_project`/`index_files` のためにバックエンドへ転送されます。
- Cloud Run にデプロイする際は、十分なリソース（例：`--cpu 4`、`--memory 8Gi`、より高い `--concurrency`）を確保してください。

### Godot Docs Search (RAG)

**[Godot Docs Search: インデックス作成とクエリ](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/./godot_doc_search.md)** を参照してください。

#### トラブルシューティング

**エディター＆ビルドの問題：**
- **ビルドエラー**：プラットフォーム固有の問題は [上流の Godot ビルドドキュメント](https://docs.godotengine.org/en/stable/development/compiling/index.html) を参照
- **Python 依存関係の問題**：Python 3.8 以上を使用し、仮想環境の利用を検討してください
- **ツールが見つからない**：バックエンド接続が確立されるまでチャットボットツールは表示されません

**AI バックエンドの問題：**
- **接続問題**：バックエンドが http://localhost:8000 で稼働しており、API キーが正しく設定されていることを確認してください
- **検索が機能しない**：Weaviate の接続（.env の WEAVIATE_URL と WEAVIATE_API_KEY）を確認してください
- **インデックス作成の問題**：関数抽出と依存関係追跡のログを参照してください

> 🔧 **[詳細なバックエンドトラブルシューティング](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md#troubleshooting)** ベクター検索、インデックス作成、API 設定の問題について

### ライセンス
- 上流の Godot Engine コード：Expat (MIT)。`LICENSE.txt` を参照してください。
- サードパーティコンポーネント：`COPYRIGHT.txt` および `thirdparty/` 以下のライセンスを参照してください。
- Simplifine 独自の貢献部分：非商用のソース公開。`NOTICE` と `LICENSES/COMPANY-NONCOMMERCIAL.md` を参照してください。

商用ライセンスも利用可能です。お問い合わせ先：[support@simplifine.com]

### 帰属
本プロジェクトは Godot Engine の貢献者である Juan Linietsky と Ariel Manzur による Godot Engine を基にしています。Godot プロジェクトとは提携していません。

### ブランディング
本プロジェクトは Simplifine による独立した配布物です。「Godot」および関連する商標はそれぞれの所有者の財産です。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-26

---