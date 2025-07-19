<p align="center">
  <img src="https://raw.githubusercontent.com/elkar-ai/elkar-a2a/main/./images/logo.jpeg" alt="Elkar product screenshot"

**ElkarはAIエージェント向けのオープンソースのタスク管理レイヤーです** — GoogleのAgent2Agentプロトコル（A2A）に基づいています。
**AIエージェント間でタスクを送信、追跡、オーケストレーション** — 簡単に行えます。

[Elkarアプリ](https://app.elkar.co/)  &nbsp;&nbsp;&nbsp; [ウェブサイト](https://elkar.co) &nbsp;&nbsp;&nbsp; [💬 Discord](https://discord.gg/f5Znhcvm) &nbsp;&nbsp;&nbsp; 

## ✨ Elkarとは？

Elkarは、開発者がインフラ管理の複雑さを気にせずに、A2Aプロトコルを用いた協調型の自律マルチエージェントシステムを構築するのを支援します。

Elkarが提供するもの：

- 🐍 Python SDK（他言語もまもなく対応予定）で、A2Aプロトコルを使ったAIエージェントの構築と接続、ストアおよびキュー管理が可能。
- 🖥️ エージェントタスクの管理、監視、デバッグを行うためのアプリケーションとAPI。

インフラの心配は不要—Elkarが複雑さを処理し、エージェントは重要なこと、すなわち協働に集中できます。
エージェントの挙動をデバッグしたいときも、タスクをストリーミングしたいときも — ElkarはA2Aを簡単にします。





## 🔧 Elkarで何ができるの？

社内外問わず、AIエージェント間のシームレスな協力を実現します：
使用例：
- **長時間実行タスクを簡単に追跡・管理**、永続的なタスクストアによる非同期操作の強力なサポート付き
- **タスク履歴の閲覧・管理**で可観測性とデバッグを実現
- **専用SDKを通じてリアルタイムにタスクをストリーミング**
- **タスク履歴、成果物、サーバー通信の完全な可視化でエージェントタスクとA2Aサーバーの深いデバッグ**
<p align="center">
  <img src="https://raw.githubusercontent.com/elkar-ai/elkar-a2a/main/./images/debugger-ui.png" alt="Elkar product screenshot"

  
**免責事項:** 本プロジェクトはまだ初期開発段階です。

## 👩‍💻 ソフトウェア開発キット

ElkarはA2Aプロトコルの実装を簡素化するPython SDK（他言語対応もまもなく）を提供します。

主な特徴：
- A2Aプロトコルの完全実装
- タスク実行に特化した設計でインフラ管理不要
- キューイングとストレージを簡素化した組み込みタスク管理
- ストリーミングレスポンスのサポート
- `RequestContext`によるカスタム認証

## 🚀 クイックスタートオンボーディング

以下の手順でElkarプラットフォームを始めましょう：

### ステップ1: サインアップとAPIキーの取得

以下の手順でElkarプラットフォームを始めましょう：

1. [Elkarプラットフォーム](https://app.elkar.co/login)で**アカウントを作成**します。
2. **新しいエージェントを作成**：**Agents \> Add a new agent**へ移動。
3. **APIキーを生成**

   ⚠️ **APIキーは今すぐコピーしてください** — 再表示されません。

### ステップ2: Elkar SDKのインストール

```python
pip install elkar
```
### ステップ3：タスクハンドラーを作成する

タスクハンドラーは、タスクのステータスとアーティファクトを管理し、タスクストアとのやり取りの複雑さを抽象化します。サポートされている操作は `set_status`、`add_messages_to_history`、および `upsert_artifact` の3つです。

現在、タスクハンドラーには厳密なシグネチャがあります：`async def my_handler(task: TaskModifierBase, request_context: RequestContext) -> None.`このシグネチャは現時点では強制されていますが、将来的にはより柔軟になる可能性があります。


```python
from elkar.a2a_types import *
from elkar.server.server import A2AServer
from elkar.task_manager.task_manager_base import RequestContext
from elkar.task_manager.task_manager_with_task_modifier import TaskManagerWithModifier
from elkar.task_modifier.base import TaskModifierBase

async def task_handler(
    task: TaskModifierBase, request_context: RequestContext | None
) -> None:

    await task.set_status(
        TaskStatus(
            state=TaskState.WORKING,
            message=Message(
                role="agent",
                parts=[TextPart(text="I understand the task, I'm working on it...")],
            ),
        )
    )

    await task.upsert_artifacts(
        [
            Artifact(
                parts=[TextPart(text="I've finished the task, here is the result...")],
                index=0,
            )
        ]
    )

    await task.set_status(
        TaskStatus(
            state=TaskState.COMPLETED,
            message=Message(
                role="agent",
                parts=[TextPart(text="I've finished the task!")],
            ),
        ),
        is_final=True,
    )
```
### ステップ4：エージェントカードを作成する

エージェントカードは、A2Aプロトコルの要件に従って定義されます。


```python
agent_card = AgentCard(
    name="Test Agent",
    description="Test Agent Description",
    url="https://example.com",
    provider=AgentProvider(organization="Elkar", url="https://www.elkar.co"),
    documentationUrl="https://example.com/documentation",
    version="1.0.0",
    skills=[
        AgentSkill(
            id="1",
            name="Generate image",
            description="Generate images from prompt description",
            inputModes=["text"],
            outputModes=["image"],
        ),
    ],
    capabilities=AgentCapabilities(
        streaming=True,
        pushNotifications=True,
        stateTransitionHistory=True,
    ),
)
```
### ステップ5：A2Aサーバーの作成

Managed Serviceをタスクストアとして使用して、A2Aサーバーをインスタンス化します。


```python
api_key = "YOUR_ELKAR_API_KEY"  # Replace with your actual Elkar API key
store = ElkarClientStore(base_url="https://api.elkar.co/api", api_key=api_key)

task_manager: TaskManagerWithModifier = TaskManagerWithModifier(
    agent_card, 
    send_task_handler=task_handler,
    store=store
)

# Create the server instance
server = A2AServer(task_manager, host="0.0.0.0", port=5001, endpoint="/")

server.start() # This is blocking. For production, use an ASGI server like Uvicorn.
```
<translate-content>
この例を実行するには（例えば、[main.py](http://main.py)として保存し、[server.app](http://server.app)をappとして公開する場合）： uvicorn main:app --host 0.0.0.0 --port 5001
</translate-content>
```bash
uvicorn main:app --host 0.0.0.0 --port 5001
```
## 📦 セルフホスティングパッケージ

Elkarのセルフホスト版は、ローカルメモリ内でタスク管理とストリーミングを実装したシンプルなライブラリとして利用できます。  
PostgreSQLやRedisなど他のタスクストアのサポートもまもなく提供予定です。

詳細な統合手順については、[オープンソースドキュメント](https://docs.elkar.co/opensource/selfhost)をご覧ください。


## 🛠️ A2A デバッガ専用モード

認証やタスク管理を設定せずにA2Aサーバーのデバッグのみを行いたい場合：

1. **デバッガ専用モードで実行**
```bash
cd a2a-client
npm run a2adebugger
```
2. **ブラウザを開く** `http://localhost:5173`

このモードは、Supabase認証やバックエンドサーバーの統合を必要とせず、A2A対応サーバーのデバッグに特化した簡易インターフェースを提供します。

## ✅ 対応しているタスクの更新

1. **ステータス更新**
タスクの状態およびエージェントの進捗を説明します。ステータス内のメッセージはタスクの履歴に追加されます。


```python
await task.set_status(
    TaskStatus(
        state=TaskState.COMPLETED,
        message=Message(parts=[TextPart(text="I've finished the task!")])
    )
)
```
2. **アーティファクトの更新**

アーティファクトはタスクの結果を表します。インデックスはタスク内のアーティファクトを識別するために使用されます。  
インデックスが一致し、チャンクが最後のものでない場合、更新は既存のアーティファクトに追加されます。
```python
await task.upsert_artifact(
    Artifact(parts=[TextPart(text="I've finished the task!")], index=0)
)
```
3. **メッセージを履歴に追加する**

タスクに関連する思考や過去の通信などの関連情報を保存します。 ([elkarbackup/elkarbackup-docker - GitHub](https://github.com/elkarbackup/elkarbackup-docker?utm_source=chatgpt.com))


```python
await task.add_messages_to_history(
    [Message(parts=[TextPart(text="I'm working on the task...")])]
)
```
<translate-content>



### 📚 ロードマップ
- フルドキュメント
- タスクストア：
    - PostgreSQL、Redis、ホスティング
- タスクキュー：
    - PostgreSQL、Redis、ホスティング
- SDK：
    - JavaScript/TypeScript
    - Go
    - Rust
- テストとコードサンプル
- プッシュ通知サポート
- タスク履歴検索機能
- 強化されたタスク管理のためのモデルコンテキストプロトコル（MCP）との統合。

詳細は[ドキュメント](https://docs.elkar.co/)をご覧ください！

## 💬 コミュニティ
ヘルプを得たり、アイデアを共有したり、最新情報を受け取るには[Discordサーバー](https://discord.gg/HDB4rkqn)に参加してください

## 🤝 貢献する

私たちはフィードバック、PR、アイデアを❤️しています！貢献方法はこちら：

- Elkarが役立つと思ったら、GitHubで⭐️をお願いします！— プロジェクトの支援になります！
- バグ報告や機能リクエストは[issues](https://github.com/elkar-ai/elkar/issues)からどうぞ。
- Elkarで作ったものを[こちら](https://discord.gg/HDB4rkqn)で披露してください！
- [プルリクエスト](https://github.com/elkar-ai/elkar/pulls)を送っていただければ、できるだけ早くレビューします。

## 🔒 ライセンス  
本プロジェクトはMITライセンスの下で提供されています – 詳細は[LICENSE](https://github.com/elkar-ai/elkar-a2a/blob/main/LICENCE)ファイルをご覧ください。



</translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---