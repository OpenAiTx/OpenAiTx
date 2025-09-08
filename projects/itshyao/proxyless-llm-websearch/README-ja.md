<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🧠 プロキシ不要のLLMウェブ検索エンジン

プロキシを必要としない複数検索エンジン対応のLLMウェブリトリーバルツールです。URLコンテンツ解析とウェブスクレイピングをサポートし、**LangGraph**と**LangGraph-MCP**を組み合わせてモジュラー型エージェントチェーンを実現します。大規模言語モデルによる外部知識参照シナリオ向けに設計され、**Playwright + Crawl4AI**によるウェブ取得と解析、非同期並列処理、コンテンツ分割・再ランキング・フィルタリングに対応しています。

## 🚀 更新履歴

- 🔥 2025-09-05：**langgraph-mcp**対応
- 🔥 2025-09-03：Dockerデプロイ追加、内蔵インテリジェント再ランキング機能、自作テキスト分割器・再ランキング器対応

## ✨ 機能一覧

- 🌐 **プロキシ不要**：Playwrightを用いた国内ブラウザ対応設定により、プロキシなしでウェブ検索が可能です。
- 🔍 **複数検索エンジン対応**：Bing、Quark、百度、Sogouなど主要検索エンジンをサポートし、情報ソースの多様性を強化します。
- 🤖 **インテント認識**：ユーザー入力に基づき、ウェブ検索かURL解析かを自動判別します。
- 🔄 **クエリ分解**：検索意図に応じてクエリを複数サブタスクに自動分解し、順次実行することで関連性と効率を向上させます。
- ⚙️ **エージェントアーキテクチャ**：**LangGraph**ベースでラップした**「web_search」**と**「link_parser」**。
- 🏃‍♂️ **非同期並列タスク処理**：非同期並列タスク処理に対応し、複数検索タスクを効率的に処理します。
- 📝 **コンテンツ処理最適化**：

  - ✂️ **コンテンツ分割**：ウェブページの長い内容を段落単位で分割。

  - 🔄 **コンテンツ再配置**：知能的な並べ替えで情報の関連性を向上。

  - 🚫 **コンテンツフィルタリング**：不要または重複する内容を自動で除去。
- 🌐 **マルチプラットフォーム対応**：
  - 🐳 **Dockerデプロイ対応**：ワンクリック起動でバックエンドサービスを迅速構築。

  - 🖥️ FastAPIバックエンドAPIを提供し、任意システムへの統合が可能。

  - 🌍 Gradio Web UIを提供し、迅速に可視化アプリとしてデプロイ可能。

  - 🧩[ **ブラウザ拡張機能対応**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension)：Edge対応、インテリジェントなURL解析拡張で、ブラウザ上で直接ウェブ解析やコンテンツ抽出要求が可能。


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ クイックスタート

### リポジトリのクローン

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 依存関係のインストール

```
pip install -r requirements.txt
python -m playwright install
```

### 環境変数の設定

```
# 百炼llm
OPENAI_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
OPENAI_API_KEY=sk-xxx
MODEL_NAME=qwen-plus-latest

# 百炼embedding
EMBEDDING_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
EMBEDDING_API_KEY=sk-xxx
EMBEDDING_MODEL_NAME=text-embedding-v4

# 百炼reranker
RERANK_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
RERANK_API_KEY=sk-xxx
RERANK_MODEL=gte-rerank-v2
```

### Langgraph-Agent

#### デモ

```shell
python agent/demo.py
```

#### API提供

```shell
python agent/api_serve.py
```

```python
import requests

url = "http://localhost:8800/search"

data = {
  "question": "广州今日天气",
  "engine": "bing",
  "split": {
    "chunk_size": 512,
    "chunk_overlap": 128
  },
  "rerank": {
    "top_k": 5
  }
}

try:
    response = requests.post(
        url,
        json=data
    )

    if response.status_code == 200:
        print("✅ 请求成功！")
        print("响应内容：", response.json())
    else:
        print(f"❌ 请求失败，状态码：{response.status_code}")
        print("错误信息：", response.text)

except requests.exceptions.RequestException as e:
    print(f"⚠️ 请求异常：{str(e)}")
```

#### Gradio（グラディオ）

```
python agent/gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

#### docker

```
docker-compose -f docker-compose-ag.yml up -d --build
```

### Langgrph-MCP

#### MCPサービスの起動

```
python mcp/websearch.py
```

#### デモ

```
python mcp/demo.py
```

#### API提供

```
python mcp/api_serve.py
```

```
import requests

url = "http://localhost:8800/search"

data = {
  "question": "广州今日天气"
}

try:
    response = requests.post(
        url,
        json=data
    )

    if response.status_code == 200:
        print("✅ 请求成功！")
        print("响应内容：", response.json())
    else:
        print(f"❌ 请求失败，状态码：{response.status_code}")
        print("错误信息：", response.text)

except requests.exceptions.RequestException as e:
    print(f"⚠️ 请求异常：{str(e)}")
```

#### docker

```
docker-compose -f docker-compose-mcp.yml up -d --build
```

### カスタムモジュール

#### カスタムチャンク

```
from typing import Optional, List

class YourSplitter:
    def __init__(self, text: str, chunk_size: int = 512, chunk_overlap: int = 128):
        self.text = text
        self.chunk_size = chunk_size
        self.chunk_overlap = chunk_overlap

    def split_text(self, text: Optional[str] = None) -> List:
        # TODO: implement splitting logic
        return ["your chunk"]
```

#### カスタムリオーダー

```
from typing import List, Union, Tuple

class YourReranker:
    async def get_reranked_documents(
        self,
        query: Union[str, List[str]],
        documents: List[str],
    ) -> Union[
        Tuple[List[str]],
        Tuple[List[int]],
    ]:
        return ["your chunk"], ["chunk index"]
```

## 🔍 オンラインネット検索テストとの比較

本プロジェクトをいくつかの主要なオンラインAPIと比較し、複雑な問題に対するパフォーマンスを評価しました。

### 🔥 データセット

- データセットはアリババが公開した [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) から取得し、教育、学会、ゲームなど複数分野を網羅した680件の高難度な質問が含まれています。
- データセットには中国語と英語の質問が含まれています。

### 🧑‍🏫 比較結果

| 検索エンジン/システム | ✅ 正解 | ❌ 不正解 | ⚠️ 部分的に正解 |
| --------------------- | ------- | -------- | -------------- |
| **火山方舟**           | 5.00%   | 72.21%   | 22.79%         |
| **百炼**               | 9.85%   | 62.79%   | 27.35%         |
| **Our**               | 19.85%  | 47.94%   | 32.06%         |
## 🙏 謝辞

本プロジェクトの一部の機能は、以下のオープンソースプロジェクトの支援とインスピレーションによるものです。ここに感謝の意を表します。

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph)：モジュラー型エージェントリンクフレームワークの構築に使用され、複雑なエージェントシステムの迅速な立ち上げを支援します。
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai)：強力なウェブコンテンツ解析ツールであり、高効率なウェブクローリングとデータ抽出に貢献します。
- 🌐 [Playwright](https://github.com/microsoft/playwright)：モダンなブラウザ自動化ツールで、クロスブラウザ対応のウェブクローリングとテスト自動化をサポートします。
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters)：複数チェーン処理MCPの構築に利用されます。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---