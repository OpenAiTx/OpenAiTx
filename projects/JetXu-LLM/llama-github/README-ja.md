
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[詳細ドキュメント] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPIバージョン](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![ダウンロード数](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![ライセンス](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-githubは、Agentic RAGに基づいて、GitHubから最も関連性の高いコードスニペット、イシュー、リポジトリ情報をクエリに基づいて取得し、それらを価値ある知識コンテキストに変換する強力なツールです。LLMチャットボット、AIエージェント、Auto-devエージェントに複雑なコーディングタスクの解決を支援します。開発者が素早く解決策を探す場合や、高度なAuto Dev AIエージェントを導入する技術者にも、llama-githubは簡単かつ効率的に利用できます。
このプロジェクトが気に入った場合や可能性を感じた場合は、ぜひ⭐️を付けてください。あなたのサポートが私たちの最大の原動力です！

## アーキテクチャ
![ハイレベルアーキテクチャ](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## インストール

```
pip install llama-github
```

現在の維持されている実行対象: Python `3.10+`。

## 使用方法

llama-githubの使用方法の簡単な例を以下に示します:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```
`retrieve_context()` はコンテキスト辞書のリストを返します。各アイテムには少なくとも `context` と `url` が含まれます。

より高度な使い方や例については、[ドキュメント](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md) を参照してください。実行可能で低コストな例は [`examples/`](examples) にも用意されています。

## 主な特徴

- **🔍 インテリジェントなGitHub検索**：llama-githubの力を活用し、ユーザーのクエリに基づいてGitHubから高い関連性を持つコードスニペット、イシュー、リポジトリ情報を取得できます。高度な検索技術により、最も適切な情報を迅速かつ効率的に見つけられます。

- **⚡ リポジトリプールキャッシュ**：llama-githubは革新的なリポジトリプールキャッシュ機構を備えています。スレッド間でリポジトリ（README、構造、コード、イシューを含む）をキャッシュすることで、GitHub検索の効率を大幅に向上させ、GitHub APIトークンの消費も最小限に抑えます。

- **🧠 LLM駆動の質問解析**：最先端の言語モデルを活用し、ユーザーの質問を分析して非常に効果的な検索戦略と基準を生成します。llama-githubは複雑なクエリを知的に分解し、GitHubの広大なリポジトリネットワークから最も関連性の高い情報を引き出します。

- **📚 包括的なコンテキスト生成**：GitHubから取得した情報と高度な言語モデルの推論能力をシームレスに組み合わせることで、豊富でコンテキストに適した回答を生成します。llama-githubは、最も複雑で長大な質問にも対応し、開発ニーズを支える広範なコンテキストを含む包括的かつ洞察に富んだ応答を提供します。

- **🚀 非同期処理の卓越性**：llama-githubは、非同期プログラミングの潜在能力を最大限に活用するよう設計されています。コードベース全体に緻密に実装された非同期メカニズムにより、複数リクエストを同時に処理し、全体的なパフォーマンスを大幅に向上させます。

- **🔧 柔軟なLLM統合**：llama-githubは様々なLLMプロバイダ、埋め込みモデル、リランキングモデル、またはLangChain互換のチャットモデルとの統合を簡単に行え、ライブラリの機能を特定の要件に合わせてカスタマイズできます。

- **🔒 強力な認証オプション**：llama-githubはパーソナルアクセストークンとGitHub App認証の両方をサポートし、さまざまな開発環境への統合が可能です。個人開発者でも組織環境でも、llama-githubは安全で信頼性の高い認証機構を提供します。

- **🛠️ ロギングとエラーハンドリング**：スムーズな運用と容易なトラブルシューティングの重要性を理解しています。そのため、llama-githubには包括的なロギングとエラーハンドリング機構が備わっています。ライブラリの挙動を詳細に把握し、問題を迅速に特定して、安定かつ信頼性の高い開発ワークフローを維持できます。

## 🤖 AI搭載PRレビューアシスタント「LlamaPReview」をお試しください

llama-githubが役立つと感じた方には、AI駆動のGitHub PRレビューアシスタント「LlamaPReview」もおすすめします。開発ワークフローを補完し、さらなるコード品質向上を実現します。

### LlamaPReviewの主な特徴：
- 🚀 ワンクリックでインストール、設定不要、完全自動実行
- 💯 現在無料で利用可能 - クレジットカードや支払い情報不要
- 🧠 AI搭載で自動的にPRを深く理解しレビュー
- 🌐 複数のプログラミング言語に対応

**LlamaPReviewはllama-githubの高度なコンテキスト取得とLLM解析を活用**し、インテリジェントかつコンテキスト認識型のコードレビューを提供します。まるでリポジトリの全コンテキストを把握したシニア開発者が、すべてのPRを自動でレビューしてくれるような体験です！

👉 [今すぐLlamaPReviewをインストール](https://github.com/marketplace/llamapreview/)（無料）

llama-githubでコンテキストを取得し、LlamaPReviewでコードレビューを行うことで、AIによる強力な開発環境を構築できます。

## ビジョンとロードマップ


### ビジョン

私たちのビジョンは、AI駆動の開発ソリューションの未来において重要なモジュールとなり、GitHubとシームレスに統合して、LLMが複雑なコーディングタスクを自動的に解決できるよう支援することです。

![ビジョンアーキテクチャ](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### ロードマップ

初期のロードマップの履歴については、[ビジョンとロードマップ](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md)をご覧ください。

## 謝辞

以下のオープンソースプロジェクトのサポートと貢献に深く感謝いたします。

- **[LangChain](https://github.com/langchain-ai/langchain)**: llama-githubのLLMプロンプトおよび処理機能を強化する基盤フレームワークの提供に感謝します。
- **[Jina.ai](https://github.com/jina-ai/reader)**: s.jina.ai APIおよびオープンソースのリランカー・埋め込みモデルの提供によって、llama-githubで生成されるコンテキストの精度と関連性を向上させていただきました。

これらの貢献はllama-githubの開発に不可欠であり、より革新的なソリューションを求める方はぜひ各プロジェクトをご覧ください。

## コントリビューション

llama-githubへのご貢献を歓迎します！詳細については、[貢献ガイドライン](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md)をご覧ください。

## ライセンス

本プロジェクトはApache 2.0ライセンスの条件の下で提供されています。詳細は[LICENSE](LICENSE)ファイルをご参照ください。

## お問い合わせ

ご質問、ご提案、ご意見がございましたら、[Jet Xuのメール](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com)までお気軽にご連絡ください。

---

llama-githubをお選びいただきありがとうございます！このライブラリがAI開発体験を向上させ、強力なアプリケーションの構築に役立つことを願っています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---