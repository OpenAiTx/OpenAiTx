<translate-content># 🚀 Xianyu AutoAgent - インテリジェントな闲鱼カスタマーサポートロボットシステム

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

闲鱼プラットフォーム向けに特化したAI監視ソリューションで、闲鱼プラットフォームの7×24時間自動監視を実現し、複数専門家の協調意思決定、インテリジェントな価格交渉およびコンテキスト認識対話をサポートします。

## 🎮 Playground - クイック体験（設定不要版）

ローカル環境やSecretsの設定は不要！**GitHub Actionsのウェブ上から直接パラメータを渡して**、ワンクリックで闲鱼ロボットを起動できます。

### 使い方
1. **リポジトリをFork** → 右上の `Fork` ボタンをクリック
2. **Actionをトリガー**：
   - 自分のリポジトリの `Actions` タブに移動
   - **`🚀 Run Service`** ワークフローを選択
   - **`Run workflow`** ボタンをクリックし、パラメータを入力：
      - `API Key`: 大規模モデルのAPIキーを貼り付け（例：阿里云 DashScope）
      - `Cookies`: 闲鱼ウェブの完全なCookie文字列を貼り付け
3. **実行ログを確認**：
   - ロボット起動後、自動的に闲鱼メッセージを監視
   - Actionログ内で `🤖 Reply:` を検索して対話履歴を確認

### 注意事項
⚠️ 一時的な実行制限にご注意ください：
- デフォルトで **30分** 実行（GitHub無料アカウントの制限）
- センシティブ情報（Cookieなど）は**保存されず**、一時的にのみ有効

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 コア機能

### インテリジェント対話エンジン
| 機能モジュール | 技術実装            | 主要特徴                                                       |
| -------------- | ------------------- | -------------------------------------------------------------- |
| コンテキスト認識 | 会話履歴保存        | 軽量な対話記憶管理、完全な対話履歴をLLMのコンテキスト入力として使用 |
| 専門家ルーティング | LLMプロンプト+ルールルーティング | プロンプトエンジニアリングによる意図認識 → 専門家Agentへ動的割り振り、交渉/技術/カスタマーサポートの複数シナリオ切替対応 |

### ビジネス機能マトリクス
| モジュール   | 実装済み                     | 計画中                       |
| ------------ | ---------------------------- | ---------------------------- |
| コアエンジン | ✅ LLM自動応答<br>✅ コンテキスト管理 | 🔄 感情分析強化               |
| 交渉システム | ✅ 階段的値下げ戦略           | 🔄 市場比較機能               |
| 技術サポート | ✅ ネット検索統合             | 🔄 RAGナレッジベース強化     |

## 🚴 クイックスタート

### 環境要件
- JDK 21+
- Maven 3.9.10+

### インストール手順</translate-content>
```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 参加と貢献

Issue を通じて提案を提出したり、PR でコードを貢献したりすることを歓迎します。必ず [貢献ガイドライン](https://contributing.md/) に従ってください。



## 🛡 注意事項

⚠️ 注意：**本プロジェクトは学習および交流のみを目的としており、著作権侵害があった場合は作者に連絡してください。**

プロジェクトの特殊性を考慮し、開発チームはいつでも**更新停止**または**プロジェクト削除**を行う可能性があります。


## 🧸 特別謝辞

本プロジェクトは以下のオープンソースプロジェクトを基に再構築されています：
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - インテリジェントな閑魚カスタマーサービスロボットシステム、[@shaxiu](https://github.com/shaxiu) と [@cv-cat](https://github.com/cv-cat) によって開発


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---