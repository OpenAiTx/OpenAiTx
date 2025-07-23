
# 🧠 代理不要のLLMネットワーク検索エンジン

代理不要のマルチサーチエンジンLLMネットワーク検索ツールで、URLコンテンツ解析とウェブクローリングをサポートし、LangGraphと組み合わせてモジュラー型エージェントチェーンを実現。大規模言語モデルの外部知識呼び出しシナリオ向けに設計され、**Playwright + Crawl4AI**によるウェブ取得と解析、非同期並列処理、コンテンツスライスと再配置フィルタリングをサポート。

## ✨ 特徴一覧

- 🌐 **代理不要**：Playwrightで国内ブラウザを設定し、代理なしでネット検索が可能。
- 🔍 **マルチ検索エンジン対応**：Bing、Quark、百度、搜狗など主要検索エンジンをサポートし、情報源の多様性を強化。
- 🤖 **意図認識**：ユーザー入力に基づき、ネット検索かURL解析かを自動判定。
- 🔄 **クエリ分解**：ユーザーの検索意図に応じてクエリを複数のサブタスクに自動分解し、順次実行することで検索の関連性と効率を向上。
- ⚙️ **エージェント構造**：**LangGraph**をベースに封装された**「web_search」**と**「link_parser」**。
- 🏃‍♂️ **非同期並列タスク処理**：非同期並列処理をサポートし、複数の検索タスクを効率的に処理可能。
- 📝 **コンテンツ処理最適化**：

  - ✂️ **コンテンツスライス**：ウェブページの長い内容を段落ごとに分割。

  - 🔄 **コンテンツ再配置**：インテリジェントな並び替えで情報の関連性を向上。

  - 🚫 **コンテンツフィルタリング**：無関係または重複コンテンツを自動除去。
- 🌐 **マルチプラットフォーム対応**：

  - 🖥️ FastAPIバックエンドAPIを提供し、任意のシステムに統合可能。

  - 🌍 Gradio Web UIを提供し、視覚化アプリとして迅速にデプロイ可能。
  
  - 🧩[ **ブラウザ拡張機能対応**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension)：Edgeをサポートし、インテリジェントなURL解析プラグインを提供、ブラウザ内で直接ウェブ解析とコンテンツ抽出リクエストを発行可能。
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ クイックスタート

### 1. リポジトリをクローンする


```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```
### 2. 依存関係のインストール


```
pip install -r requirements.txt
python -m playwright install
```
### 3. クイックスタート

#### 環境変数の設定


```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```
#### デモ


```python
'''
python demo.py
'''

from pools import BrowserPool, CrawlerPool
from agent import ToolsGraph
import asyncio

async def main():
    browser_pool = BrowserPool(pool_size=1)
    crawler_pool = CrawlerPool(pool_size=1)
    
    graph = ToolsGraph(browser_pool, crawler_pool, engine="bing")

    await browser_pool._create_browser_instance(headless=True)
    await crawler_pool._get_instance()

    result = await graph.run("广州今日天气")

    await browser_pool.cleanup()
    await crawler_pool.cleanup()

    print(result)

if __name__ == "__main__":
    asyncio.run(main())
```
#### バックエンドAPI


```python
'''
python api_serve.py
'''
import requests

url = "http://localhost:8000/search"

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
#### gradio_demo


```
python gradio_demo.py
```
![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

## 🔍 オンラインウェブ検索テストとの比較

本プロジェクトをいくつかの主流オンラインAPIと比較し、複雑な問題に対するパフォーマンスを評価しました。

### 🔥 データセット

- データセットはアリババが公開した[WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA)から取得し、教育、学会、ゲームなど複数分野の680の難問を含みます。
- データセットには中英両言語の質問が含まれています。

### 🧑‍🏫 比較結果

| 検索エンジン/システム | ✅ 正解 | ❌ 不正解 | ⚠️ 部分的に正解 |
| --------------------- | ------- | -------- | --------------- |
| **火山方舟**          | 5.00%   | 72.21%   | 22.79%          |
| **百炼**              | 9.85%   | 62.79%   | 27.35%          |
| **Our**               | 19.85%  | 47.94%   | 32.06%          |

## 🙏 謝辞

本プロジェクトの一部機能は、以下のオープンソースプロジェクトの支援と着想により実現しました。心より感謝申し上げます：

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph)：モジュール式インテリジェントエージェントチェーンフレームワークの構築に使用。
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai)：強力なウェブコンテンツ解析ツール。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---