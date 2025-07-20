<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - インテリジェント閑魚カスタマーサービスロボットシステム

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

閑魚プラットフォーム専用のAI常駐ソリューションで、閑魚プラットフォームの7×24時間自動対応を実現。複数エキスパートによる協調判断、インテリジェント値引き、コンテキスト認識対話をサポート。

## 🎮 Playground - クイック体験（設定不要版）

ローカル環境やSecretsの設定は不要！**GitHub ActionsのWeb画面でパラメータを入力するだけで**、ワンクリックで閑魚ロボットを起動可能。

### 使い方
1. **本リポジトリをFork** → 右上の `Fork` ボタンをクリック
2. **Actionをトリガー**：
   - あなたのリポジトリの `Actions` タブに移動
   - **`🚀 Run Service`** ワークフローを選択
   - **`Run workflow`** ボタンをクリックし、パラメータを入力：
      - `API Key`: あなたの大規模モデルAPIキー（例：アリクラウドDashScope等）を貼り付け
      - `Cookies`: 閑魚Web版の完全なCookie文字列を貼り付け
3. **実行ログを確認**：
   - ロボット起動後、自動で閑魚メッセージを監視
   - Actionログで `🤖 Reply:` を検索し、対話履歴を確認

### 注意事項
⚠️ 一時的な実行制限にご注意ください：
- デフォルト実行時間は **30分**（GitHub無料アカウントの制限）
- 機密情報（Cookie等）は**保存されません**。その都度有効となります

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 コア機能

### インテリジェント対話エンジン
| 機能モジュール | 技術実装              | 主な特徴                                                    |
| -------------- | --------------------- | ----------------------------------------------------------- |
| コンテキスト認識 | 会話履歴の保存         | 軽量な会話メモリ管理で、全会話履歴をLLMコンテキストとして入力 |
| エキスパートルーティング | LLMプロンプト＋ルールルーティング | プロンプトエンジニアリングによる意図認識→エキスパートAgent動的分配、値引/技術/カスタマー対応の多シーン切替対応 |

### ビジネス機能マトリクス
| モジュール   | 実装済み                        | 計画中                       |
| ------------ | ------------------------------ | ------------------------ |
| コアエンジン | ✅ LLM自動応答<br>✅ コンテキスト管理 | 🔄 感情分析強化                 |
| 値引きシステム | ✅ ステップ値下げ戦略               | 🔄 市場価格比較機能               |
| 技術サポート   | ✅ Web検索統合                    | 🔄 RAGナレッジベース強化           |

## 🚴 クイックスタート

### 必要な環境
- JDK 21以上
- Maven 3.9.10以上

### インストール手順

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---