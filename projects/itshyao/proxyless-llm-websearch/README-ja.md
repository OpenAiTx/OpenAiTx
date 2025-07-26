
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

プロキシを必要としないマルチ検索エンジン対応のLLMウェブ検索ツールです。URLコンテンツの解析やウェブクロールをサポートし、LangGraphと組み合わせてモジュール型エージェントチェーンを実現します。大規模言語モデルによる外部知識利用シナリオ向けに設計され、**Playwright + Crawl4AI** によるウェブ取得・解析、非同期並列処理、コンテンツ分割・再構成・フィルタリングに対応しています。

## ✨ 主な特徴

- 🌐 **プロキシ不要**：Playwrightで国内ブラウザの設定が可能。プロキシ不要でウェブ検索ができます。
- 🔍 **マルチ検索エンジン対応**：Bing、Quark、Baidu、Sogouなどの主要検索エンジンをサポートし、情報源の多様性を強化。
- 🤖 **インテント認識**：ユーザー入力に応じて、自動的にウェブ検索かURL解析かを判別します。
- 🔄 **クエリ分解**：検索意図に基づきクエリを複数サブタスクに自動分割し、順次実行して関連性と効率を向上。
- ⚙️ **エージェントアーキテクチャ**：**LangGraph** ベースの**「web_search」**および**「link_parser」**を搭載。
- 🏃‍♂️ **非同期並列タスク処理**：非同期並列タスク処理対応で、複数の検索タスクを効率的に処理可能。
- 📝 **コンテンツ処理最適化**：

  - ✂️ **コンテンツ分割**：長いウェブページ内容をセグメントで分割。

  - 🔄 **コンテンツ再構成**：インテリジェントな並べ替えで情報の関連性を向上。

  - 🚫 **コンテンツフィルタ**：不要・重複コンテンツを自動除去。
- 🌐 **マルチプラットフォーム対応**：

  - 🖥️ FastAPIバックエンドAPIを提供し、あらゆるシステムに統合可能。

  - 🌍 Gradio Web UIを用意し、可視化アプリとして迅速に展開可能。
  
  - 🧩[ **ブラウザ拡張機能対応**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension)：Edge対応。インテリジェントURL解析プラグインを提供し、ブラウザから直接ウェブページ解析・内容抽出リクエストが可能。
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ クイックスタート

### 1. リポジトリをクローン

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---