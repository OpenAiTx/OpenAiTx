# Memvid - ビデオベースAIメモリ 🧠📹

**AIメモリを大規模に実現する軽量で革新的なソリューション**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvidはテキストデータを動画にエンコードすることでAIメモリ管理を革新し、**数百万のテキストチャンクに対して超高速なセマンティック検索**と**サブセカンドの検索応答**を実現します。従来のベクターデータベースのように大量のRAMやストレージを必要とせず、Memvidは知識ベースをコンパクトな動画ファイルに圧縮し、あらゆる情報への即時アクセスを可能にします。

## 🎥 デモ

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ 主な特徴

- 🎥 **ビデオをデータベースとして利用**: 数百万のテキストチャンクを1つのMP4ファイルに保存
- 🔍 **セマンティック検索**: 自然言語のクエリで関連コンテンツを検索
- 💬 **内蔵チャット機能**: 文脈を理解した会話型インターフェース
- 📚 **PDF対応**: PDFドキュメントを直接インポート・インデックス化
- 🚀 **高速検索**: 大規模データセットでもサブセカンドで検索
- 💾 **効率的なストレージ**: 従来型データベースの10倍の圧縮率
- 🔌 **プラガブルなLLM対応**: OpenAI、Anthropic、ローカルモデルに対応
- 🌐 **オフラインファースト**: 動画生成後はインターネット不要
- 🔧 **シンプルなAPI**: たった3行で利用開始

## 🎯 利用例

- **📖 デジタルライブラリ**: 数千冊の書籍を1つの動画ファイルでインデックス
- **🎓 教育コンテンツ**: 講義資料を検索可能な動画メモリに
- **📰 ニュースアーカイブ**: 複数年分の記事を管理しやすい動画データベースに圧縮
- **💼 企業ナレッジ**: 会社全体のナレッジベースを検索可能に構築
- **🔬 論文管理**: 科学文献の高速セマンティック検索
- **📝 個人メモ**: 自分のノートを検索可能なAIアシスタントに変換

## 🚀 Memvidを選ぶ理由

### 革新的なイノベーション
- **ビデオをデータベースに**: 数百万のテキストチャンクを1つのMP4ファイルに保存
- **瞬時の検索応答**: 大規模データセットをサブセカンドでセマンティック検索
- **10倍のストレージ効率**: 動画圧縮でメモリ使用量を劇的に削減
- **インフラ不要**: データベースサーバー不要、どこでもコピー可能なファイルのみ
- **オフラインファースト**: 動画生成後は完全オフラインで動作

### 軽量なアーキテクチャ
- **最小限の依存関係**: コア機能は約1000行のPythonコード
- **CPUフレンドリー**: GPU不要で効率的に動作
- **ポータブル**: 1つの動画ファイルに知識ベース全体を格納
- **ストリーミング対応**: 動画はクラウドストレージからストリーミング可能

## 📦 インストール

### クイックインストール
```bash
pip install memvid
```

### PDFサポートを利用する場合
```bash
pip install memvid PyPDF2
```

### 推奨セットアップ（仮想環境）
```bash
# 新しいプロジェクトディレクトリを作成
mkdir my-memvid-project
cd my-memvid-project

# 仮想環境を作成
python -m venv venv

# 有効化
# macOS/Linuxの場合:
source venv/bin/activate
# Windowsの場合:
venv\Scripts\activate

# memvidをインストール
pip install memvid

# PDFサポートを利用する場合:
pip install PyPDF2
```

## 🎯 クイックスタート

### 基本的な使い方
```python
from memvid import MemvidEncoder, MemvidChat

# テキストチャンクから動画メモリを作成
chunks = ["重要な事実1", "重要な事実2", "歴史的な出来事の詳細"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# メモリとチャット
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("歴史的な出来事について何を知っていますか？")
print(response)
```

### ドキュメントからメモリを構築
```python
from memvid import MemvidEncoder
import os

# ドキュメントの読み込み
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# テキストファイルを追加
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# 最適化された動画を作成
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # FPSが高いほど1秒あたりのチャンク数が増加
    frame_size=512  # フレームサイズが大きいほど1フレームあたりのデータ量が増加
)
```

### 高度な検索・取得
```python
from memvid import MemvidRetriever

# リトリーバの初期化
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# セマンティック検索
results = retriever.search("機械学習アルゴリズム", top_k=5)
for chunk, score in results:
    print(f"Score: {score:.3f} | {chunk[:100]}...")

# コンテキストウィンドウの取得
context = retriever.get_context("ニューラルネットワークを説明して", max_tokens=2000)
print(context)
```

### インタラクティブチャットインターフェース
```python
from memvid import MemvidInteractive

# インタラクティブチャットUIを起動
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # Webインターフェースが http://localhost:7860 で開きます
```

### file_chat.py でのテスト
`examples/file_chat.py` スクリプトを使うことで、自分のドキュメントでMemvidを包括的にテストできます:

```bash
# ドキュメントディレクトリを処理
python examples/file_chat.py --input-dir /path/to/documents --provider google

# 特定ファイルを処理
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# H.265圧縮を利用（Dockerが必要）
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# 大きなドキュメント用にカスタムチャンク化
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# 既存メモリの読み込み
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### 完全例: PDF書籍とチャット
```bash
# 1. 新しいディレクトリを作成し環境をセットアップ
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # Windowsの場合: venv\Scripts\activate

# 2. 依存関係をインストール
pip install memvid PyPDF2

# 3. book_chat.pyを作成
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# あなたのPDFファイル
book_pdf = "book.pdf"  # あなたのPDFパスに置き換えてください

# 動画メモリを構築
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# 書籍とチャット
api_key = os.getenv("OPENAI_API_KEY")  # オプション: AI応答用
```markdown
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. 実行する
export OPENAI_API_KEY="your-api-key"  # オプション
python book_chat.py
```

## 🛠️ 高度な設定

### カスタム埋め込み
```python
from sentence_transformers import SentenceTransformer

# カスタム埋め込みモデルを使用
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### ビデオ最適化
```python
# 最大圧縮のために
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # フレームレートを上げる
    frame_size=256,  # フレームサイズを小さく
    video_codec='h265',  # より良い圧縮
    crf=28  # 圧縮品質（値が小さいほど高品質）
)
```

### 分散処理
```python
# 大規模データセットを並列処理
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 トラブルシューティング

### よくある問題

**ModuleNotFoundError: No module named 'memvid'**
```bash
# 正しいPythonを使っているか確認
which python  # 仮想環境のパスが表示されるはず
# そうでない場合は、仮想環境を有効化:
source venv/bin/activate  # Windowsの場合: venv\Scripts\activate
```

**ImportError: PyPDF2 is required for PDF support**
```bash
pip install PyPDF2
```

**LLM APIキーの問題**
```bash
# APIキーを設定（https://platform.openai.com で取得可能）
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# Windowsの場合:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**大容量PDFの処理**
```python
# 非常に大きなPDFの場合、小さいチャンクサイズを使用
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 コントリビューション

貢献を歓迎します！ 詳細は [CONTRIBUTINGガイド](https://raw.githubusercontent.com/Olow304/memvid/main/CONTRIBUTING.md) をご覧ください。

```bash
# テストを実行
pytest tests/

# カバレッジ付きで実行
pytest --cov=memvid tests/

# コードの整形
black memvid/
```

## 🆚 従来型ソリューションとの比較

| 機能 | Memvid | ベクトルDB | 従来型DB |
|---------|--------|------------|-----------------|
| 保存効率 | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐ |
| セットアップの複雑さ | シンプル | 複雑 | 複雑 |
| セマンティック検索 | ✅ | ✅ | ❌ |
| オフライン利用 | ✅ | ❌ | ✅ |
| ポータビリティ | ファイルベース | サーバーベース | サーバーベース |
| スケーラビリティ | 数百万 | 数百万 | 数十億 |
| コスト | 無料 | $$$$ | $$$ |


## 📚 例

[examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) ディレクトリを参照してください:
- Wikipediaダンプからメモリを構築
- 個人ナレッジベースの作成
- 多言語対応
- リアルタイムメモリアップデート
- 人気LLMとの統合

## 🆘 ヘルプを得るには

- 📖 [ドキュメント](https://github.com/olow304/memvid/wiki) - 包括的なガイド
- 💬 [ディスカッション](https://github.com/olow304/memvid/discussions) - 質問はこちら
- 🐛 [イシュートラッカー](https://github.com/olow304/memvid/issues) - バグ報告
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - プロジェクト共有

## 🔗 リンク

- [GitHubリポジトリ](https://github.com/olow304/memvid)
- [PyPIパッケージ](https://pypi.org/project/memvid)
- [Changelog](https://github.com/olow304/memvid/releases)


## 📄 ライセンス

MITライセンス - 詳細は [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) ファイルを参照してください。

## 🙏 謝辞

[Olow304](https://github.com/olow304) と Memvid コミュニティによって作成されました。

❤️ を込めて以下を利用して構築:
- [sentence-transformers](https://www.sbert.net/) - セマンティック検索のための最先端埋め込み
- [OpenCV](https://opencv.org/) - コンピュータビジョンおよびビデオ処理
- [qrcode](https://github.com/lincolnloop/python-qrcode) - QRコード生成
- [FAISS](https://github.com/facebookresearch/faiss) - 高効率な類似検索
- [PyPDF2](https://github.com/py-pdf/pypdf) - PDFテキスト抽出

Memvidをより良くするために貢献してくださった全ての方に感謝します！

---

**AIのメモリ管理を革新する準備はできましたか？Memvidをインストールして構築を始めましょう！** 🚀
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---