<div align="center">
  <div>
    <a href="https://strandsagents.com">
      <img src="https://strandsagents.com/latest/assets/logo-auto.svg" alt="Strands Agents" width="55px" height="105px">
    </a>
  </div>

  <h1>
    Strands Agents サンプル
  </h1>

  <h2>
    数行のコードでAIエージェントを構築するモデル駆動型アプローチ。
  </h2>

  <div align="center">
    <a href="https://github.com/strands-agents/samples/graphs/commit-activity"><img alt="GitHub commit activity" src="https://img.shields.io/github/commit-activity/m/strands-agents/samples"/></a>
    <a href="https://github.com/strands-agents/samples/issues"><img alt="GitHub open issues" src="https://img.shields.io/github/issues/strands-agents/samples"/></a>
    <a href="https://github.com/strands-agents/samples/pulls"><img alt="GitHub open pull requests" src="https://img.shields.io/github/issues-pr/strands-agents/samples"/></a>
    <a href="https://github.com/strands-agents/samples/blob/main/LICENSE"><img alt="License" src="https://img.shields.io/github/license/strands-agents/samples"/></a>
  </div>
  
  <p>
    <a href="https://strandsagents.com/">ドキュメント</a>
    ◆ <a href="https://github.com/strands-agents/samples">サンプル</a>
    ◆ <a href="https://github.com/strands-agents/sdk-python">Python SDK</a>
    ◆ <a href="https://github.com/strands-agents/tools">ツール</a>
    ◆ <a href="https://github.com/strands-agents/agent-builder">エージェントビルダー</a>
    ◆ <a href="https://github.com/strands-agents/mcp-server">MCPサーバー</a>
  </p>
</div>

Strands Agents サンプルリポジトリへようこそ！

<a href="https://strandsagents.com">Strands Agents</a> を始めるための使いやすい例を探検してください。

このリポジトリのサンプルは**デモおよび教育目的**のみです。概念や技術を示しますが、**本番環境での直接使用は意図していません**。本番環境で使用する前に、必ず適切な**セキュリティ**と**テスト**手順を適用してください。

## 📚 目次

- [📚 目次](#-table-of-contents)
- [🏁 はじめに](#-getting-started)
  - [ステップ1: 必要なパッケージをインストール](#step-1-install-required-packages)
  - [ステップ2: モデルプロバイダーの設定](#step-2-setup-model-provider)
  - [ステップ3: 最初のStrandsエージェントを構築](#step-3-build-your-first-strands-agent)
  - [ステップ4: SDKの使い方](#step-4-getting-started-with-the-sdk)
  - [ステップ5: さらにサンプルを探る](#step-5-explore-more-samples)

## 🏁 はじめに

### ステップ1: 必要なパッケージをインストール

```bash
pip install strands-agents
pip install strands-agents-tools
```
### ステップ 2: モデルプロバイダーの設定

モデルプロバイダーとモデルアクセスの設定については、[こちら](https://strandsagents.com/latest/user-guide/quickstart/#model-providers)の手順に従ってください。

### ステップ 3: 最初の Strands エージェントを作成する


```python
from strands import Agent, tool
from strands_tools import calculator, current_time, python_repl

@tool
def letter_counter(word: str, letter: str) -> int:
    """
    Count the occurrences of a specific letter in a word.
    """
    if not isinstance(word, str) or not isinstance(letter, str):
        return 0
    if len(letter) != 1:
        raise ValueError("The 'letter' parameter must be a single character")
    return word.lower().count(letter.lower())

agent = Agent(tools=[calculator, current_time, python_repl, letter_counter])

message = """
I have 4 requests:

1. What is the time right now?
2. Calculate 3111696 / 74088
3. Tell me how many letter R's are in the word "strawberry" 🍓
4. Output a script that does what we just spoke about!
   Use your python tools to confirm that the script works before outputting it
"""

agent(message)
```
### ステップ4：SDKの使い始め

[01-tutorials](./01-tutorials/) ディレクトリから始めましょう。  
[最初のエージェント](./01-tutorials/01-fundamentals/01-first-agent/)を作成し、コア機能をカバーするノートブックベースの例を探検してください。

### ステップ5：さらにサンプルを探る

インスピレーションをお探しですか？  
実際のユースケースのための例は、[02-samples](./02-samples/) フォルダでご覧いただけます。

## 貢献 ❤️

貢献を歓迎します！詳細は[Contributing Guide](https://raw.githubusercontent.com/strands-agents/samples/main/CONTRIBUTING.md)をご覧ください：  
- バグや機能の報告  
- 開発環境のセットアップ  
- プルリクエストによる貢献  
- 行動規範  
- セキュリティ問題の報告  

## ライセンス

本プロジェクトはApache License 2.0の下でライセンスされています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。

## セキュリティ

詳細は[CONTRIBUTING](https://raw.githubusercontent.com/strands-agents/samples/main/CONTRIBUTING.md#security-issue-notifications)をご参照ください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---