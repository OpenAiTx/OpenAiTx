
# ローカルチャットRAG

**ローカルでプライバシー重視のRetrieval-Augmented Generation (RAG)チャットアプリ**。ドキュメントをアップロードし、質問し、ソース付きの回答を得られます—オープンソースのLLMをあなたのマシンで動作させて実現。

---

## 特徴

- **ローカルRAGパイプライン**：クラウド不要、データ漏洩なし—全てあなたのマシン上で実行。
- **ファイルアップロード＆解析**：DOCX、PDFなど対応（`unstructured`、`python-docx`、`pdfplumber`経由）。
- **モダンUI**：Geminiスタイル、ミニマルでアクセシブル。Vite、React、TypeScript、Zustand、Chakra UIで構築。
- **ソース付きチャット**：質問して、回答がどのドキュメント／セクションから来ているか確認可能。
- **FastAPIバックエンド**：堅牢なAPI、フロントエンドとの明確な分離、`/api`ルート管理。
- **Ollama LLM統合**：Mistral、Llama2等のオープンソースモデルをOllama経由でローカル利用。
- **拡張可能＆文書化**：モジュラーでテスト可能なコード、厳格なドキュメントと変更管理ポリシー。

---

## クイックスタート

### 1. **要件**
- Python 3.9+
- Node.js 18+
- [Ollama](https://ollama.com/)（ローカルLLMと埋め込み用）

---

## 🚀 クイックセットアップチェックリスト

1. **Ollamaをインストール**（ローカルLLMと埋め込み用）
2. **必要なモデルをプル**：`mistral`（チャット用）と`nomic-embed-text`（埋め込み用）
3. **Ollamaサーバーを起動**：`ollama serve`（バックエンド稼働には必須）
4. **バックエンドをセットアップ**（Python、FastAPI）
5. **フロントエンドをセットアップ**（Node.js、Vite）
6. **ブラウザでアプリを開く**：[http://localhost:5173](http://localhost:5173)

---

### 2. Ollamaと必要モデルのインストール
- **Ollamaをダウンロード：** [ollama.com/download](https://ollama.com/download)（macOS、Windows、Linux）
- **またはHomebrewで（macOS）：**
  ```bash
  brew install ollama
  ```
- **Ollamaサーバーを起動する:**（バックエンドが動作するためには必須）
  ```bash
  ollama serve
  ```
- **必要なモデルをプルする：**
  ```bash
  ollama pull mistral
  ollama pull nomic-embed-text
  ```
  - `mistral`：チャットや質問応答に使用  
  - `nomic-embed-text`：ドキュメント埋め込みに使用  
  > `mistral`は任意の互換モデル（例：`llama3`、`llama2`）に置き換え可能ですが、バックエンドのデフォルトは`mistral`です。  

### 3. バックエンド設定（FastAPI）  
- **仮想環境を作成して有効化する：**
  ```bash
  cd backend
  python -m venv .venv
  source .venv/bin/activate
  ```
- **Pythonの依存関係をインストールする：**
  ```bash
  pip install --upgrade pip
  pip install -r requirements.txt
  ```
- **バックエンドサーバーを起動する:**
  ```bash
  uvicorn app.main:app --reload
  ```
- バックエンドAPIは次のURLで利用可能です: [http://localhost:8000/api](http://localhost:8000/api)

### 4. フロントエンドのセットアップ（Vite）
- **Node.jsの依存関係をインストールする:**
  ```bash
  cd frontend
  npm install
  ```
- **フロントエンド開発サーバーを起動する：**
  ```bash
  npm run dev
  ```
  - フロントエンドアプリは以下で利用可能です: [http://localhost:5173](http://localhost:5173)

---

## ✅ クイックセットアップチェックリスト
- [ ] Ollamaがインストールされている
- [ ] `mistral` と `nomic-embed-text` モデルがプルされている
- [ ] `ollama serve` が実行中
- [ ] バックエンドが [http://localhost:8000/api](http://localhost:8000/api) で稼働中
- [ ] フロントエンドが [http://localhost:5173](http://localhost:5173) で稼働中

---

## アプリの使い方
- ブラウザで [http://localhost:5173](http://localhost:5173) を開く。
- サイドバーからファイルをアップロードする。
- チャットボックスで質問する；回答はドキュメントの出典を引用します。
- 処理はすべてローカルで行われ、データはデバイスを離れません。

---

## トラブルシューティング & ヒント
- **Ollamaが動作していない、またはモデルエラーの場合:**
  - バックエンド起動前にターミナルで `ollama serve` が実行されていることを確認する。
  - `llama3` と `nomic-embed-text` の両モデルをプルしていることを確認する。
  - 実行中のモデルは `ollama list` で確認可能。
- **Python依存関係のエラー:**
  - 仮想環境が有効で、`pip` が最新であることを確認する。
- **Node/npmのエラー:**
  - Node.js 18以上を使用し、問題が続く場合は `node_modules` を削除して再インストールする。
- **PDF/DOCXの解析エラー:**
  - `libmagic` と `poppler-utils` をインストールする（バックエンドの注意事項参照）。
- **さらにサポートが必要な場合:**
  - [`backend/gotchas.md`](https://raw.githubusercontent.com/TAMustafa/Local_Chat_RAG/main/backend/app/gotchas.md) と [`backend/implementation_details.md`](https://raw.githubusercontent.com/TAMustafa/Local_Chat_RAG/main/backend/app/implementation_details.md) を参照。

---

## 使用方法
- サイドバーで **ファイルをアップロード**。
- チャットで **質問する** — 回答はドキュメントをコンテキストに生成される。
- 回答ごとに **出典** が表示される（ファイルごとに重複削除）。
- **処理はすべてローカル** — データはデバイスを離れません。

---

## アーキテクチャ

- **フロントエンド**: Vite + React + TypeScript + Zustand + Chakra UI
- **バックエンド**: FastAPI + SQLAlchemy + LangChain + ChromaDB + Unstructured
- **LLM**: Ollama (Mistral, Llama2等) を `langchain-ollama` 経由で使用
- **RAGパイプライン**: チャンク分割、埋め込み、検索、ソース付きチャット

### フォルダ構成
```
ChatRAG/
  backend/
    app/
      main.py           # FastAPI app & API endpoints
      db/               # Database models & session
      rag/              # RAG pipeline logic
    requirements.txt
    ...
  frontend/
    src/
      components/       # UI components (Chat, Files, Layout)
      state/            # Zustand stores
      ...
    vite.config.ts
    ...
```
---

## カスタマイズ
- **LLMモデルの変更:** `backend/app/main.py` 内のモデル名を編集 (`OllamaLLM(model="mistral")`)。
- **ファイルタイプの追加:** バックエンドパイプラインでのファイル解析を拡張。
- **UI/UX:** `frontend/src/components` 内のChakra UIテーマやコンポーネント構造を調整。

---

## ドキュメント＆ポリシー
- すべての運用上の注意点、アーキテクチャの決定事項、トラブルポイントは `backend/implementation_details.md`、`gotchas.md`、および `quick_reference.md` に記録。
- 厳格なドキュメントおよびコード品質ポリシーを遵守—詳細はプロジェクトドキュメント参照。

---

## クレジット
- Tarek Adam Mustafa とコントリビューターによって構築。
- オープンソースにより支えられています: [Ollama](https://ollama.com/)、[LangChain](https://github.com/langchain-ai/langchain)、[ChromaDB](https://www.trychroma.com/)、[Unstructured](https://unstructured.io/)、[Chakra UI](https://chakra-ui.com/)、[Vite](https://vitejs.dev/)。

---

## ライセンス
[MIT](LICENSE)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---