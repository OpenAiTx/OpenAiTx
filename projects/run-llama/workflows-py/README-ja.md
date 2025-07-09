# LlamaIndex Workflows

[![ユニットテスト](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![カバレッジステータス](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![GitHub コントリビューター](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - ダウンロード数](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflowsは、複雑なステップやイベントのシステムをオーケストレーションし、連鎖させるためのフレームワークです。

## Workflowsで何が構築できますか？

Workflowsは、AIモデル、API、意思決定を含む複雑で多段階なプロセスのオーケストレーションが必要な場合に特に力を発揮します。以下は構築可能な例です：

- **AIエージェント** - 複数のステップにわたり推論、意思決定、アクションを実行できるインテリジェントなシステムの作成
- **ドキュメント処理パイプライン** - 文書の取り込み、分析、要約、および様々な処理段階へのルーティングを行うシステムの構築
- **マルチモデルAIアプリケーション** - 異なるAIモデル（LLM、ビジョンモデル等）を連携させて複雑なタスクを解決
- **リサーチアシスタント** - 情報の検索、分析、統合を行い、包括的な回答を提供するワークフローの開発
- **コンテンツ生成システム** - コンテンツの生成、レビュー、編集、そして人間による承認を経て公開までを行うパイプラインの構築
- **カスタマーサポート自動化** - 顧客からの問い合わせを理解、分類、応答できるインテリジェントなルーティングシステムの構築

非同期・イベント駆動型アーキテクチャにより、異なる機能間のルーティング、並列処理パターンの実装、複雑なシーケンスのループ、多段階にわたる状態の維持などが容易になり、AIアプリケーションを本番運用に耐えうるものにします。
## 主な特徴

- **async-first** - ワークフローは Python の async 機能を中心に構築されています。ステップは asyncio キューからのイベントを処理し、新しいイベントを他のキューに発行する非同期関数です。つまり、FastAPI や Jupyter Notebooks などの非同期アプリで最も効果的に動作します。
- **イベント駆動型** - ワークフローはステップとイベントで構成されます。コードをイベントとステップで整理することで、理解やテストが容易になります。
- **状態管理** - 各ワークフローの実行は自己完結型であり、ワークフローを起動して情報を保存し、ワークフローの状態をシリアライズして後で再開することができます。
- **オブザーバビリティ** - ワークフローは自動的にオブザーバビリティ向けに計装されており、`Arize Phoenix` や `OpenTelemetry` などのツールをすぐに利用できます。

## クイックスタート

パッケージをインストールします：

```bash
pip install llama-index-workflows
```

そして、最初のワークフローを作成します：

```python
import asyncio
from pydantic import BaseModel, Field
from workflows import Context, Workflow, step
from workflows.events import Event, StartEvent, StopEvent

class MyEvent(Event):
    msg: list[str]

class RunState(BaseModel):
    num_runs: int = Field(default=0)

class MyWorkflow(Workflow):
    @step
    async def start(self, ctx: Context[RunState], ev: StartEvent) -> MyEvent:
        async with ctx.store.edit_state() as state:
            state.num_runs += 1

            return MyEvent(msg=[ev.input_msg] * state.num_runs)

    @step
    async def process(self, ctx: Context[RunState], ev: MyEvent) -> StopEvent:
        data_length = len("".join(ev.msg))
        new_msg = f"Processed {len(ev.msg)} times, data length: {data_length}"
        return StopEvent(result=new_msg)

async def main():
    workflow = MyWorkflow()
```
```
    # [オプション] ワークフローにコンテキストオブジェクトを提供する
    ctx = Context(workflow)
    result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
    print("Workflow result:", result)

    # 同じコンテキストで再実行すると、状態が保持される
    result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
    print("Workflow result:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

上記の例では
- `StartEvent` を受け入れるステップが最初に実行されます。
- `StopEvent` を返すステップがワークフローを終了させます。
- 中間イベントはユーザー定義であり、ステップ間で情報を渡すために使用できます。
- `Context` オブジェクトもステップ間で情報を共有するために使用されます。

`llama-index` を使ったさらなる例については、[完全なドキュメント](https://docs.llamaindex.ai/en/stable/understanding/workflows/)をご覧ください！

## さらに多くの例

- [基本機能のウォークスルー](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [`llama-index`を使った関数呼び出しエージェントの構築](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- 人間が介在する反復的なドキュメント抽出
  - [OpenTelemetry + インストルメンテーション入門](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## 関連パッケージ

- [Typescript Workflows](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---