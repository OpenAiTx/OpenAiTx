# 🌟 500以上のAIエージェントプロジェクト／ユースケース

[![500-AI-Agents-Projects - UseCase](https://img.shields.io/badge/500--AI--Agents--Projects-UseCase-2ea44f?logo=https%3A%2F%2Fstatic-00.iconduck.com%2Fassets.00%2Frobot-emoji-2048x2044-kay057lt.png&logoColor=2ea44f)](https://github.com/ashishpatel26/500-AI-Agents-Projects)

![img](https://raw.githubusercontent.com/ashishpatel26/500-AI-Agents-Projects/main/images/AIAgentUseCase.jpg)

産業横断的なAIエージェントのユースケースを厳選して集め、実践的な応用例と実装のためのオープンソースプロジェクトへのリンクを紹介しています。AIエージェントが医療、金融、教育などの産業をどのように変革しているかを探求しましょう！🤖✨

---

## 📋 目次

- [はじめに](#introduction)
- [産業別ユースケース](#-industry-usecase-mindmap)
- [ユースケース一覧](#use-case-table)
- [フレームワーク別ユースケース](#framework-wise-usecases)
  - [CrewAIユースケース](#framework-name-crewai)
  - [AutoGenユースケース](#framework-name-autogen)
  - [Agnoユースケース](#framework-name-agno)
  - [Langgraphユースケース](#framework-name-langgraph)
- [貢献について](#contributing)
- [ライセンス](#license)

---

## 🧠 はじめに

人工知能（AI）エージェントは、産業の運営方法を革新しています。パーソナライズされた学習から金融取引ボットまで、AIエージェントは効率性、革新性、拡張性をもたらします。このリポジトリは以下を提供します：

- AIエージェントが影響を与えている産業の分類リスト。
- 実装のためのオープンソースプロジェクトへのリンクを含む詳細なユースケース。

開発者、研究者、ビジネス愛好家のいずれであっても、このリポジトリはAIエージェントのインスピレーションと学習のための必携リソースです。

---

## 🏭 産業別ユースケースマインドマップ

![](https://raw.githubusercontent.com/ashishpatel26/500-AI-Agents-Projects/main/images/industry_usecase1.png)

---

## 🧩 ユースケース表

| ユースケース                                | 業界             | 説明                                                     | コード GitHub                                                                                                                                                                         |
| ------------------------------------------- | ---------------- | -------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| **HIA (Health Insights Agent)**       | ヘルスケア       | 医療レポートを分析し、健康に関する洞察を提供します。        | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/harshhh28/hia.git)                                                                             |
| **AI Health Assistant**               | ヘルスケア       | 患者データを使って疾病を診断・監視します。                  | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/ahmadvh/AI-Agents-for-Medical-Diagnostics.git)                                                 |
| **Automated Trading Bot**             | 金融             | リアルタイムの市場分析で株式取引を自動化します。              | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/MingyuJ666/Stockagent.git)                                                                     |
| **Virtual AI Tutor**                  | 教育             | ユーザーに合わせたパーソナライズ教育を提供します。             | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/hqanhh/EduGPT.git)                                                                             |
| **24/7 AI Chatbot**                   | カスタマーサービス | 24時間体制で顧客の問い合わせに対応します。                   | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/NirDiamant/GenAI_Agents/blob/main/all_agents_tutorials/customer_support_agent_langgraph.ipynb) |
| **Product Recommendation Agent**      | 小売             | ユーザーの好みや履歴に基づいて商品を提案します。               | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/microsoft/RecAI)                                                                               |
| **Self-Driving Delivery Agent**       | 交通             | ルートを最適化し、自律的に荷物を配送します。                   | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/sled-group/driVLMe)                                                                            |
| **Factory Process Monitoring Agent**  | 製造             | 生産ラインを監視し、品質管理を確保します。                     | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/yuchenxia/llm4ias)                                                                             |
| **Property Pricing Agent**            | 不動産           | 市場動向を分析して物件価格を算出します。                       | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/AleksNeStu/ai-real-estate-assistant)                                                           |
| **Smart Farming Assistant**           | 農業             | 作物の健康状態や収量予測に関する洞察を提供します。              | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/mohammed97ashraf/LLM_Agri_Bot)                                                                 |
| **Energy Demand Forecasting Agent**   | エネルギー       | エネルギー使用量を予測し、グリッド管理を最適化します。          | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/yecchen/MIRAI)                                                                                 |
| **Content Personalization Agent**     | エンターテインメント | 好みに基づいたパーソナライズされたメディアを推奨します。          | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/crosleythomas/MirrorGPT)                                                                       |
| **Legal Document Review Assistant**   | 法律             | 書類のレビューを自動化し、重要な条項をハイライトします。          | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/firica/legalai)                                                                                |
| **Recruitment Recommendation Agent**  | 人事             | 求人に最適な候補者を提案します。                               | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/sentient-engineering/jobber)                                                                   |
| **Virtual Travel Assistant**          | ホスピタリティ   | ユーザーの好みに合わせた旅行計画を立てます。                     | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/nirbar1985/ai-travel-agent)                                                                    |
| **AI Game Companion Agent**           | ゲーム           | プレイヤーの体験をリアルタイムで支援します。                     | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/onjas-buidl/LLM-agent-game)                                                                    |
| **Real-Time Threat Detection Agent**  | サイバーセキュリティ | 潜在的な脅威を特定し、攻撃を軽減します。                         | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/NVISOsecurity/cyber-security-llm-agents)                                                       |
| **E-commerce Personal Shopper Agent** | Eコマース        | 顧客が気に入る商品を見つける手助けをします。                      | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/Hoanganhvu123/ShoppingGPT)                                                                     |
| **Logistics Optimization Agent**      | サプライチェーン | 効率的な配送ルートの計画と在庫管理を行います。                     | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/microsoft/OptiGuide)                                                                           |
| **Vibe Hacking Agent**                | サイバーセキュリティ | 自律的なマルチエージェントによるレッドチームテストサービス。         | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/PurpleAILAB/Decepticon) |
| **MediSuite-Ai-Agent**  | 医療保険         | 病院や保険の請求ワークフローの自動化を支援する医療AIエージェント。 | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/MahmoudRabea13/MediSuite-Ai-Agent)                                         | 
| **Lina-Egyptian-Medical-Chatbot**  | 医療保険         | 病院や保険の請求ワークフローの自動化を支援する医療AIエージェント。 | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/MahmoudRabea13/MediSuite-Ai-Agent)                                         |

## フレームワーク別ユースケース

---

### **フレームワーク名**: **CrewAI**

| ユースケース                      | 業界                    | 説明                                                                                     | GitHub                                                                                                                                            |
| -------------------------------- | ----------------------- | ---------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------- |
| 📧 Email Auto Responder Flow     | 🗣️ コミュニケーション    | 事前定義された基準に基づきメール応答を自動化し、コミュニケーション効率を向上させます。        | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/flows/email_auto_responder_flow) |
| 📝 Meeting Assistant Flow        | 🛠️ 生産性               | 会議のスケジューリングやアジェンダ準備など、会議の整理と管理を支援します。                  | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/flows/meeting_assistant_flow) |
| 🔄 Self Evaluation Loop Flow     | 👥 人事                 | 組織内の自己評価プロセスを促進し、パフォーマンスレビューを支援します。                      | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/flows/self_evaluation_loop_flow) |
| 📈 リードスコアフロー               | 💼 セールス                | 見込み顧客を評価しスコアリングして、セールス戦略における優先的なアプローチを支援します。             | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/flows/lead-score-flow) |
| 📊 マーケティング戦略ジェネレーター  | 📢 マーケティング            | 市場動向やオーディエンスデータを分析してマーケティング戦略を構築します。                  | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/marketing_strategy) |
| 📝 求人投稿ジェネレーター         | 🧑‍💼 採用          | 求人要件を分析して求人投稿を作成し、採用プロセスを支援します。         | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/job-posting) |
| 🔄 採用ワークフロー          | 🧑‍💼 採用          | 採用に関わる様々なタスクを自動化し、採用プロセスを効率化します。          | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/recruitment) |
| 🔍 プロフィールとポジションのマッチング    | 🧑‍💼 採用          | 候補者のプロフィールを適切な職種にマッチングし、採用効率を向上させます。      | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/match_profile_to_positions) |
| 📸 Instagram投稿ジェネレーター      | 📱 ソーシャルメディア         | Instagram投稿を自動生成・スケジュール設定し、ソーシャルメディア管理を効率化します。 | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/instagram_post)             |
| 🌐 ランディングページジェネレーター        | 💻 ウェブ開発      | ウェブサイトのランディングページ作成を自動化し、ウェブ開発作業を支援します。    | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/landing_page_generator)     |
| 🎮 ゲームビルダークルー             | 🎮 ゲーム開発     | ゲーム制作の一部を自動化してゲーム開発を支援します。          | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/game-builder-crew)          |
| 💹 株式分析ツール           | 💰 金融              | 株式市場データの分析ツールを提供し、金融判断を支援します。       | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/stock_analysis)             |
| 🗺️ 旅行プランナー                  | ✈️ 旅行               | 旅程を整理し旅行の詳細を管理して旅行計画を支援します。             | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/trip_planner)               |
| 🎁 サプライズ旅行プランナー         | ✈️ 旅行               | ユーザーの好みに基づき目的地やアクティビティを選択してサプライズ旅行を計画します。     | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/surprise_trip)              |
| 📚 フローで本を書く       | ✍️ クリエイティブライティング     | 著者を支援するための構造化されたワークフローと執筆支援を提供します。   | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/flows/write_a_book_with_flows) |
| 🎬 脚本ライター             | ✍️ クリエイティブライティング     | 脚本作成のためのテンプレートやガイダンスを提供し、脚本執筆を支援します。       | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/screenplay_writer)          |
| ✅ Markdownバリデーター            | 📄 ドキュメント        | Markdownファイルの形式や基準への準拠を検証します。             | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/markdown_validator)         |
| 🧠 Meta Questナレッジ          | 📚 ナレッジマネジメント | Meta Questに関する知識を管理・整理し、情報検索を容易にします。   | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/meta_quest_knowledge)       |
| 🤖 NVIDIAモデル統合     | 🤖 AI統合       | NVIDIAのAIモデルをワークフローに統合し、計算能力を強化します。            | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/integrations/nvidia_models) |
| 🗂️ 会議準備            | 🛠️ 生産性         | 資料の整理や議題設定を支援し、会議準備を効率化します。               | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/prep-for-a-meeting)         |
| 🛠️ スターターテンプレート               | 🛠️ 開発          | 新規プロジェクトのセットアップを効率化するスターターテンプレートを提供します。                | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/starter_template)           |
| 🔗CrewAI + LangGraph統合 | 🤖 AI統合       | CrewAIとLangGraphの統合を実演し、ワークフロー自動化を強化します。      | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/integrations/CrewAI-LangGraph)           |


### **フレームワーク名**: **Autogen**

> **コード生成、実行、デバッグ**

| ユースケース                                                                                | 業界                | 説明                                                                       | ノートブック                                                                                                                                                                   |
| --------------------------------------------------------------------------------------- | ----------------------- | --------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🤖 コード生成・実行・デバッグによる自動タスク解決                   | 💻 ソフトウェア開発 | コードを生成・実行・デバッグして自動タスク解決を実演します。 | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_auto_feedback_from_code_execution) |
| 🧑‍💻 リトリーバル強化エージェントによる自動コード生成と質問応答 | 💻 ソフトウェア開発 | リトリーバル強化手法を用いてコード生成と質問応答を行います。           | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_RetrieveChat)                      |
| 🧠 Qdrantベースのリトリーバルによる自動コード生成と質問応答         | 💻 ソフトウェア開発 | Qdrantを活用したリトリーバル強化エージェントの性能向上を図ります。               | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_RetrieveChat_qdrant)               |

> **マルチエージェント協調（3エージェント以上）**

| ユースケース                                                                 | 業界                    | 説明                                                         | ノートブック                                                                                                                                                            |
| :----------------------------------------------------------------------- | :-------------------------- | :------------------------------------------------------------------ | :------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| 🤝 グループチャットによる自動タスク解決（メンバー3人、マネージャー1人）           | 🤝 協調            | マルチエージェントの協調によるグループタスク解決を実演します。      | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_groupchat)                  |
| 📊 グループチャットによる自動データ可視化（メンバー3人、マネージャー1人）     | 📊 データ分析            | マルチエージェント協調を用いてデータ可視化を行います。       | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_groupchat_vis)              |
| 🧩 グループチャットによる自動複雑タスク解決（メンバー6人、マネージャー1人）   | 🤝 協調            | 大人数のエージェントで協調し複雑なタスクを解決します。 | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_groupchat_research)         |
| 🧑‍💻 コーディング＆プランニングエージェントによる自動タスク解決              | 🛠️ 計画・開発 | コーディングとプランニングエージェントを組み合わせて効率的にタスクを解決します。  | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_planning.ipynb)             |
| 📐 グラフで指定した遷移経路による自動タスク解決     | 🤝 協調            | グラフ上の定義済み遷移経路を用いてタスクを解決します。      | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/docs/notebooks/agentchat_groupchat_finite_state_machine) |
| 🧠 SocietyOfMindAgentによる内的独白としてのグループチャットの実行            | 🧠 認知科学                 | グループチャットを用いた問題解決のための内的独白をシミュレート。                                  | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_society_of_mind)            |
| 🔧 カスタム話者選択関数を用いたグループチャットの実行                        | 🤝 コラボレーション          | グループチャットにおける話者選択のためのカスタム関数を実装。                                    | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_groupchat_customized)       |

> **連続的なマルチエージェントチャット**

| ユースケース                                                                       | 業界                       | 説明                                                                                      | ノートブック                                                                                                                                                     |
| :--------------------------------------------------------------------------------- | :------------------------- | :---------------------------------------------------------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🔄 単一エージェントによる連続チャットで複数タスクを解決                           | 🔄 ワークフロー自動化       | 単一の開始エージェントによる連続的なタスク解決を自動化。                                  | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_multi_task_chats)       |
| ⏳ 単一エージェントによる連続チャットで非同期に複数タスクを解決                  | 🔄 ワークフロー自動化       | 一つのエージェントが開始する連続チャットで非同期のタスク解決を処理。                      | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_multi_task_async_chats) |
| 🤝 異なるエージェントが開始する連続チャットで複数タスクを解決                   | 🔄 ワークフロー自動化       | 各チャットを異なるエージェントが開始する連続的なタスク解決を促進。                        | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchats_sequential_chats)      |

> **ネストチャット**

| ユースケース                                                                     | 業界                         | 説明                                                                                      | ノートブック                                                                                                                                                     |
| :------------------------------------------------------------------------------- | :--------------------------- | :---------------------------------------------------------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🧠 ネストチャットを用いた複雑なタスクの解決                                     | 🧠 問題解決                  | 階層的かつ複雑な問題を解決するためにネストチャットを利用。                                | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_nestedchat)              |
| 🔄 ネストチャットの連続で複雑なタスクを解決                                    | 🧠 問題解決                  | ネストチャットを用いた連続的なタスク解決を示す。                                          | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_nested_sequential_chats) |
| 🏭 ネストチャットを用いたサプライチェーン最適化問題のOptiGuide                 | 🏭 サプライチェーン最適化    | ネストチャット、コーディングエージェント、セーフガードエージェントを用いた最適化問題の解決例。 | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_nestedchat_optiguide)    |
| ♟️ ネストチャットとツール利用による対話型チェス                               | 🎮 ゲーム                    | 統合ツールを用いた対話型チェスのためのネストチャット利用を探求。                          | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_nested_chats_chess)      |

> **アプリケーション**

| ユースケース                                                                                         | 業界                         | 説明                                                                                          | ノートブック                                                                                                                                                    |
| :------------------------------------------------------------------------------------------------- | :--------------------------- | :-------------------------------------------------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🔄 新しいデータからの自動継続学習                                                                    | 📊 機械学習                  | 新しいデータ入力から継続的に学習し適応するAIを実現。                                        | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_stream.ipynb)         |
| 🏭 OptiGuide - コーディング・ツール利用・セーフガード・質問応答を統合したサプライチェーン最適化 | 🏭 サプライチェーン最適化    | サプライチェーン最適化のためにコーディング、ツール利用、セーフガードを組み合わせたソリューション。 | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_nestedchat_optiguide) |
| 🤖 AutoAnny - AutoGenを用いて構築されたDiscordボット                                           | 💬 コミュニケーションツール  | AutoGenを利用した高度なインタラクションのためのDiscordボットの開発例。                    | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/tree/main/samples/apps/auto-anny)                 |

> **ツール**

| ユースケース                                                           | 業界                         | 説明                                                                                      | ノートブック                                                                                                                                                      |
| :--------------------------------------------------------------------- | :--------------------------- | :--------------------------------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🌐 ウェブ検索: ウェブ情報を必要とするタスクの解決                     | 🔍 情報検索                  | タスク完了に必要な情報をウェブから検索収集。                                            | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_web_info.ipynb)          |
| 🔧 既存ツールを関数として利用                                         | 🛠️ ツール統合               | 提供されたツールをAutoGen内で呼び出し可能な関数として使用する方法を示す。                | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_function_call_currency_calculator)       |
| 🔗 同期・非同期関数呼び出しによるツール利用                           | 🛠️ ツール統合               | AutoGenワークフロー内での同期・非同期ツール使用を説明。                                | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_function_call_async)                     |
| 🧩 Langchain提供ツールを関数として用いたタスク解決                   | 🔍 言語処理                  | AutoGen内でLangchainツールを活用したタスク解決。                                      | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_langchain.ipynb)                         |
| 📚 RAG: 検索強化生成を用いたグループチャット                        | 🤝 コラボレーション          | 検索強化生成（RAG）を用いた情報共有を支援するグループチャットを可能に。                | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_groupchat_RAG)                           |
| ⚙️ Function Inception: 会話中の関数更新・削除                        | 🔧 開発ツール                | 会話中にAutoGenエージェントが関数を動的に変更可能にする機能。                          | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_inception_function.ipynb)                |
| 🔊 Whisperを用いたエージェントチャット                               | 🎙️ 音声処理                 | Whisperを利用した文字起こしおよび翻訳機能を備えたAIエージェントの能力を示す。          | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_video_transcript_translate_with_whisper) |
| 📏 ガイダンスによる応答の制約                                         | 💡 自然言語処理              | エージェントの生成する応答をガイダンスで制約する方法を示す。                            | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_guidance.ipynb)                          |
| 🌍 エージェントでウェブをブラウズ                                       | 🌐 情報検索                  | エージェントを設定してウェブから情報を取得・検索する方法を説明します。                                  | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_surfer.ipynb)                            |
| 📊 SQL: Spiderベンチマークを使った自然言語テキストからSQLクエリへの変換       | 💾 データベース管理           | 自然言語入力をSpiderベンチマークを使ってSQLクエリに変換します。                                      | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_sql_spider.ipynb)                        |
| 🕸️ Apifyを使ったウェブスクレイピング                                    | 🌐 データ収集                | AutoGenを用いたApifyでのウェブスクレイピング技術を示します。                                        | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_webscraping_with_apify)                  |
| 🕷️ Web Crawling: Spider APIでドメイン全体をクロール                          | 🌐 データ収集                | Spider APIを使ってドメイン全体をクロールする方法を説明します。                                       | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_webcrawling_with_spider)                 |
| 💻 特別設計関数でタスクごとにソフトウェアアプリを作成                          | 💻 ソフトウェア開発           | 設計された関数を使って段階的にソフトウェアアプリケーションを構築します。                             | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_function_call_code_writing.ipynb)        |

> **人間の開発**

| ユースケース                                                       | 業界                      | 説明                                                                                           | ノートブック                                                                                                                                                   |
| :--------------------------------------------------------------- | :------------------------ | :--------------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 💬 ChatGPTスタイルのシンプルな例                                   | 🧠 会話型AI               | ChatGPT風のシンプルな会話例を示します。                                                        | [![Example](https://img.shields.io/badge/View-Example-blue?logo=openai)](https://github.com/microsoft/autogen/blob/0.2/samples/simple_chat.py)                     |
| 🤖 自動コード生成・実行・デバッグと人間のフィードバック             | 💻 ソフトウェア開発         | コード生成、実行、デバッグに人間のフィードバックを組み込んだワークフローを紹介します。          | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_human_feedback.ipynb) |
| 👥 GPT-4と複数人のユーザーによる自動タスク解決                      | 🤝 コラボレーション         | 複数の人間ユーザーがGPT-4と協力してタスク解決を行う方法を紹介します。                           | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_two_users.ipynb)      |
| 🔄 非同期の人間入力に対応したエージェントチャット                     | 🧠 会話型AI               | エージェントの会話中に非同期の人間入力をサポートします。                                       | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/Async_human_input.ipynb)        |

> **エージェントの教育と学習**

| ユースケース                                                         | 業界                      | 説明                                                                                         | ノートブック                                                                                                                                                   |
| :------------------------------------------------------------------- | :------------------------ | :------------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 📘 エージェントに新スキルを教え、自動チャットで再利用                 | 🎓 教育・研修             | エージェントに新しいスキルを教え、自動チャットでの再利用を可能にする方法を示します。          | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_teaching)                       |
| 🧠 エージェントにコード以外の新事実、ユーザー好み、スキルを教える     | 🎓 教育・研修             | エージェントに新しい事実、ユーザーの好み、コーディング以外のスキルを教える方法を紹介します。    | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_teachability)                   |
| 🤖 GPTAssistantAgentを通じてOpenAIアシスタントを教える                | 💻 AIアシスタント開発      | GPTAssistantAgentを使ってOpenAIアシスタントの能力を強化する方法を示します。                  | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_teachable_oai_assistants.ipynb) |
| 🔄 エージェント最適化器: エージェント的手法による訓練                 | 🛠️ 最適化                | Agent Optimizerを使った効果的なエージェント訓練方法を説明します。                           | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_agentoptimizer.ipynb)           |

> **OpenAIアシスタントを組み込んだマルチエージェントチャット**

| ユースケース                                                  | 業界                      | 説明                                                                                     | ノートブック                                                                                                                                                   |
| :------------------------------------------------------------ | :------------------------ | :--------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🌟 AutoGenでOpenAIアシスタントとのHello-Worldチャット          | 🤖 会話型AI               | AutoGenを使ってOpenAIアシスタントとチャットする基本例。                                   | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_oai_assistant_twoagents_basic.ipynb) |
| 🔧 関数呼び出しを使ったOpenAIアシスタントとのチャット           | 🔧 開発ツール             | OpenAIアシスタントとチャットで関数呼び出しを使う方法を説明します。                       | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_oai_assistant_function_call.ipynb)   |
| 🧠 コードインタープリターとしてのOpenAIアシスタントとのチャット   | 💻 ソフトウェア開発         | OpenAIアシスタントをコードインタープリターとして使うチャット例を示します。               | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_oai_code_interpreter.ipynb)          |
| 🔍 検索拡張機能付きOpenAIアシスタントとのチャット               | 📚 情報検索                | 検索拡張を用いたOpenAIアシスタントとの会話を可能にします。                               | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_oai_assistant_retrieval.ipynb)       |
| 🤝 グループチャットでのOpenAIアシスタント                         | 🤝 コラボレーション         | OpenAIアシスタントが他のエージェントとグループチャットで協力する様子を示します。          | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_oai_assistant_groupchat.ipynb)       |
| 🛠️ GPTAssistantAgentを使ったマルチエージェントツールの利用         | 🔧 開発ツール             | GPTAssistantAgentを用いたマルチエージェントツールの使い方を説明します。                  | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/gpt_assistant_agent_function_call.ipynb)       |

> **非OpenAIモデル**

| ユースケース                                            | 業界      | 説明                                                           | ノートブック                                                                                                                                                       |
| :----------------------------------------------------- | :-------- | :------------------------------------------------------------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| ♟️ 非OpenAIモデルを使った会話型チェス                     | 🎮 ゲーム | 非OpenAIモデルで実装した会話型チェスを探求します。             | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_nested_chats_chess_altmodels) |
> **マルチモーダルエージェント**

| ユースケース                                      | 業界               | 説明                                                                              | ノートブック                                                                                                                                                     |
| :--------------------------------------------- | :------------------ | :-------------------------------------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🎨 DALLEとGPT-4Vによるマルチモーダルエージェントチャット | 🖼️ マルチメディアAI | DALLEとGPT-4Vを組み合わせたマルチモーダルエージェントのコミュニケーション。              | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_dalle_and_gpt4v.ipynb) |
| 🖌️ Llavaを使ったマルチモーダルエージェントチャット      | 📷 画像処理          | Llavaを使用して画像処理を伴うマルチモーダルエージェント会話を実現。                     | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_lmm_llava.ipynb)       |
| 🖼️ GPT-4Vを使ったマルチモーダルエージェントチャット       | 🖼️ マルチメディアAI | GPT-4Vを活用した視覚的かつ会話的なマルチモーダルエージェントのインタラクション。         | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_lmm_gpt-4v.ipynb)      |

> **長文コンテキスト処理**

| ユースケース                              | 業界               | 説明                                                                        | ノートブック                                                                                                                                                  |
| :--------------------------------------- | :----------------- | :-------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| 📜 長文コンテキスト処理機能としての対応    | 🧠 AI機能           | AIワークフロー内で長文コンテキストを効果的に処理する技術を示す。                  | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_transform_messages) |

> **評価とアセスメント**

| ユースケース                                                                                | 業界                | 説明                                                                                      | ノートブック                                                                                                                                           |
| :----------------------------------------------------------------------------------------- | :------------------ | :---------------------------------------------------------------------------------------- | :----------------------------------------------------------------------------------------------------------------------------------------------------- |
| 📊 AgentEval: LLM搭載アプリの有用性評価用マルチエージェントシステム                       | 📈 パフォーマンス評価 | LLMベースのアプリケーションの性能評価とアセスメントのためのAgentEvalを紹介。                  | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agenteval_cq_math.ipynb) |

> **自動エージェント構築**

| ユースケース                                                      | 業界              | 説明                                                                                   | ノートブック                                                                                                                                               |
| :------------------------------------------------------------ | :---------------- | :------------------------------------------------------------------------------------ | :--------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🏗️ AgentBuilderによるマルチエージェントシステムの自動構築       | 🤖 AI開発          | AgentBuilderツールを使ったマルチエージェントシステムの自動構築方法を解説。               | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/autobuild_basic.ipynb)         |
| 📚 エージェントライブラリからのマルチエージェントシステム自動構築 | 🤖 AI開発          | 事前定義されたエージェントライブラリを活用したマルチエージェントシステムの構築方法を示す。 | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/autobuild_agent_library.ipynb) |

> **可観測性**

| ユースケース                                                        | 業界                      | 説明                                                                                  | ノートブック                                                                                                                                          |
| :---------------------------------------------------------------- | :------------------------ | :----------------------------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------- |
| 📊 AgentOpsを使ったLLM呼び出し、ツール使用、アクション、エラーの追跡 | 📈 モニタリング＆分析      | AgentOpsを使ってLLMのインタラクション、ツール使用状況、エラーを監視する方法を示す。         | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_agentops.ipynb) |

> **強化推論**

| ユースケース                                                           | 業界               | 説明                                                                                     | ノートブック                                                                                                                                                                   |
| :--------------------------------------------------------------------- | :----------------- | :--------------------------------------------------------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🔗 API統合                                                            | 🔧 API管理         | ドキュメントとコード例を用いてAPI使用を統合する方法を解説。                                      | [![Documentation](https://img.shields.io/badge/View-Documentation-blue?logo=readthedocs)](https://microsoft.github.io/autogen/docs/Use-Cases/enhanced_inference/#api-unification) |
| ⚙️ API設定管理を効率化するユーティリティ関数                           | 🔧 API管理         | API設定をより効果的に管理するためのユーティリティ関数を紹介。                                  | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/topics/llm_configuration)                                |

| 💰 コスト計算                                                         | 📈 コスト管理       | LLMとの対話におけるトークン使用量の追跡方法とコスト推定手法を紹介します。                                                | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_cost_token_tracking.ipynb)           |
| ⚡ コード生成の最適化                                                | 📊 最適化          | LLMによるコード生成を改善するためのコスト効果の高い最適化技術を強調しています。                                         | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/oai_completion.ipynb)                          |
| 📐 数学問題解決の最適化                                             | 📊 最適化          | 数学問題を解くためにLLMのパフォーマンスを最適化する手法について説明しています。                                         | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/oai_chatgpt_gpt4.ipynb)                        |

### **フレームワーク名**: **Agno**

> **ユースケース**

| ユースケース                       | 業界                                           | 説明                                                                                                                                                                                                                                               | ノートブック                                                                                                                                                                                                   |
| :--------------------------------- | :--------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🤖 サポートエージェント            | 💻 ソフトウェア開発 / AI / フレームワーク支援   | Agnoサポートエージェントは、開発者に対してリアルタイムの回答、説明、コード例を提供し、Agnoフレームワークの支援を行います。                                                                                                                 | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/agno_support_agent.py)         |
| 🎥 YouTubeエージェント             | 📺 メディア & コンテンツ                        | AIツールを用いてYouTube動画を解析し、詳細な要約、タイムスタンプ、テーマ、内容の分解を生成するインテリジェントエージェントです。                                                                                                               | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/youtube_agent.py)              |
| 📊 ファイナンスエージェント         | 💼 ファイナンス                                 | リアルタイムの株式市場情報、アナリストの推奨、財務詳細分析、業界別トレンドを提供する高度なAI市場アナリスト。AAPL、TSLA、NVDAなどの企業分析用のプロンプトをサポートします。                                                               | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/thinking_finance_agent.py)     |
| 📚 スタディパートナー              | 🎓 教育                                        | リソースの検索、質問への回答、学習計画の作成を通じてユーザーの学習を支援します。                                                                                                                                                               | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/study_partner.py)              |
| 🛍️ ショッピングパートナーエージェント | 🏬 Eコマース                                    | AmazonやFlipkartなどの信頼できるプラットフォームからの好みに基づき、マッチする商品を探す商品推薦エージェントです。                                                                                                                           | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/shopping_partner.py)           |
| 🎓 研究学者エージェント             | 🧠 教育 / 研究                                 | 高度な学術検索を行い、最新の論文を分析し、分野横断的に知見を統合、適切な引用付きで構造化された学術レポートを作成するAIアカデミックアシスタントです。                                                                                         | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/research_agent_exa.py)         |
| 🧠 研究エージェント                | 🗞️ メディア & ジャーナリズム                    | ウェブ検索とプロのジャーナリズム執筆を組み合わせ、深い調査を行い、NYタイムズ風のレポートを作成する調査エージェントです。                                                                                                                     | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/research_agent.py)             |
| 🍳 レシピクリエイター              | 🍽️ 食品 & 料理                                 | 材料、好み、時間制約に基づいてパーソナライズされたレシピを提供するAIレシピ推薦エージェントです。                                                                                                                                                | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/recipe_creator.py)             |
| 🗞️ ファイナンスエージェント         | 💼 ファイナンス                                 | リアルタイム株価データ、アナリストの洞察、企業基礎情報、市場ニュースを組み合わせた強力な金融分析エージェント。Apple、Tesla、NVIDIAなどの企業や半導体、自動車などのセクター分析に最適です。                                               | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/finance_agent.py)              |
| 🧠 ファイナンシャルリーズニングエージェント | 📈 ファイナンス                                 | Claude-3.5 Sonnetベースのエージェントを使用し、ツールとYahoo Financeデータを用いてNVDAなどの株式を分析します。                                                                                                                              | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/reasoning_finance_agent.py)    |
| 🤖 README生成エージェント           | 💻 ソフトウェア開発                              | リポジトリのメタデータを利用してGitHubリポジトリの高品質なREADMEを自動生成するエージェントです。                                                                                                                                               | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/readme_generator.py)           |
| 🎬 映画推薦エージェント             | 🎥 エンターテインメント                          | ExaとGPT-4oを活用し、ジャンル、テーマ、最新評価を分析してパーソナライズされた映画推薦を行うインテリジェントエージェントです。                                                                                                           | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/movie_recommedation.py)        |
| 🔍 メディアトレンド分析エージェント   | 📰 メディア & ニュース                           | AIエージェントとスクレイピングを用いてデジタルプラットフォームから新興トレンド、パターン、インフルエンサーを分析します。                                                                                                                  | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/media_trend_analysis_agent.py) |
| ⚖️ 法律文書分析エージェント          | 🏛️ 法律テック                                  | PDFのURLから法律文書を解析し、ベクトル埋め込みとGPT-4oを用いた知識ベースに基づき法律的洞察を提供するAIエージェントです。                                                                                                                   | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/legal_consultant.py)           |
| 🤔 DeepKnowledge                   | 🧠 研究                                        | 知識ベースを用いた反復検索を行い、複雑な問い合わせをサブクエスチョンに分解して包括的な回答を統合します。Agnoドキュメントでデモを行い、深い推論と探求のために設計されています。                                                             | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/deep_knowledge.py)             |
| 📚 書籍推薦エージェント             | 🧠 出版 & メディア                              | 文学データ、読者の好み、レビュー、リリース情報を用いてパーソナライズされた書籍推薦を行うインテリジェントエージェントです。                                                                                                              | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/book_recommendation.py)        |
| 🏠 MCP Airbnbエージェント           | 🛎️ ホスピタリティ                             | MCPとLlama 4を使用して、ワークスペースや交通アクセスなどのフィルターを用いてAirbnbのリスティングを検索するAIエージェントを作成します。                                                                                                   | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/airbnb_mcp.py)                 |
| 🤖 アシストエージェント             | 🧠 AIフレームワーク                            | GPT-4oを使い、ハイブリッド検索と組み込み知識を活用してAgnoフレームワークに関する質問に答えるAIエージェントです。                                                                                                                             | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/agno_assist.py)                |

### **フレームワーク名**: **Langgraph**

> **ユースケース**

| ユースケース                          | 業界                        | 説明                                                      | ノートブック                                                 |
| :------------------------------------ | :---------------------------- | :--------------------------------------------------------- | :----------------------------------------------------------- |
| 🤖 チャットボットシミュレーション評価    | 💻 💬 AI / 品質保証             | ユーザー対話をシミュレートし、チャットボットの性能を評価。実運用環境での堅牢性と信頼性を確保します。                              | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/chatbot-simulation-evaluation/agent-simulation-evaluation.ipynb) |
| 🧠 プロンプトによる情報収集            | 🧠 AI / 研究開発               | プロンプト技術を用いて効率的に情報収集を行うLangGraphワークフローの設計方法を示します。インテリジェントエージェント構築のためのプロンプト構造と情報管理を紹介。 | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/chatbots/information-gather-prompting.ipynb) |
| 🧠 LangGraphによるコードアシスタント    | 💻 ソフトウェア開発             | LangGraphを使った堅牢なコードアシスタントの構築方法を示します。コード生成、エラーチェック、反復的な改良を行うグラフベースのエージェント作成を案内。                     | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/code_assistant/langgraph_code_assistant.ipynb) |
| 🧑‍💼 カスタマーサポートエージェント      | 🧑‍💼 カスタマーサポートエージェント | LangGraphを使ってカスタマーサポートエージェントを構築する方法を示します。顧客の問い合わせ対応、自動サポート、ユーザー体験向上を実現。                                     | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/customer-support/customer-support.ipynb) |
| 🔁 リトライ付き抽出                  | 🧠 AI / データ抽出             | LangGraphワークフローにリトライ機構を実装し、過渡的エラーに対応し信頼性を高める堅牢なデータ抽出処理を実現する方法を示します。                                             | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/extraction/retries.ipynb) |
| 🧠 マルチエージェントワークフロー                | 🧠 AI / ワークフローオーケストレーション | このチュートリアルでは、LangGraphのエージェントスーパーバイザーを使用してマルチエージェントシステムを構築する方法を示します。複数の専門エージェントを管理し、タスクの委任と通信の流れを制御するスーパーバイザーエージェントの作成手順を案内します。 | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/multi_agent/agent_supervisor.ipynb) |
| 🧠 階層型エージェントチーム            | 🧠 AI / ワークフローオーケストレーション | このチュートリアルでは、LangGraphを使って階層型エージェントシステムを構築する方法を示します。トップレベルのスーパーバイザーエージェントが専門のサブエージェントにタスクを委任し、明確なタスク委任と通信で複雑なワークフローを実現する手順を案内します。 | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/multi_agent/hierarchical_agent_teams.ipynb) |
| 🤝 マルチエージェントコラボレーション           | 🧠 AI / ワークフローオーケストレーション | このチュートリアルでは、LangGraphを使用したマルチエージェントコラボレーションの実装方法を示します。複数の専門エージェントが協力して複雑なタスクを達成する手順を案内し、AIワークフローにおけるエージェントコラボレーションの強力さを紹介します。 | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/multi_agent/multi-agent-collaboration.ipynb) |
| 🧠 計画と実行エージェント              | 🧠 AI / ワークフローオーケストレーション | このチュートリアルでは、LangGraphを使って「計画と実行」スタイルのエージェントを構築する方法を示します。まず多段階の計画を生成し、その後各ステップを順次実行し、必要に応じて計画を見直し修正するエージェントの作成手順を案内します。このアプローチはPlan-and-Solve論文やBaby-AGIプロジェクトに着想を得ており、AIワークフローにおける長期的な計画とタスク実行の向上を目指しています。 | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/plan-and-execute/plan-and-execute.ipynb) |
| 🧠 SQLエージェント | 🧠 AI / データベース操作 | このチュートリアルでは、SQLデータベースに関する質問に答えられるエージェントの構築方法を示します。エージェントは利用可能なテーブルを取得し、質問に関連するか判断し、スキーマを取得、クエリを生成し、エラーをチェックして実行し、回答を作成します。 | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/sql-agent.ipynb) |
| 🧠 リフレクションエージェント | 🧠 AI / ワークフローオーケストレーション | このチュートリアルでは、LangGraphを使ってリフレクションエージェントを構築する方法を示します。自身の出力を批評し修正できるエージェントの作成手順を案内し、生成コンテンツの質と信頼性を向上させます。 | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/reflection/reflection.ipynb)|
| 🧠 リフレクションエージェント | 🧠 AI / ワークフローオーケストレーション | このチュートリアルでは、LangGraphを使ってリフレクションエージェントを構築する方法を示します。自身の行動と結果を振り返り、反復的な改善と複雑なワークフローにおけるより正確な意思決定を可能にするエージェントの作成手順を案内します。 | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/reflexion/reflexion.ipynb)|
| **LangGraph エージェンシックRAG**           |                               |                                                              |                                                              |
| 🧠 **適応型RAG**           | 🧠 AI / 情報検索 | このチュートリアルでは、LangGraphを使って適応型RAGシステムを構築する方法を示します。クエリの複雑さに応じて動的に検索プロセスを調整し、情報検索の効率と精度を向上させる手順を案内します。 | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_adaptive_rag.ipynb) |
| 🧠 **適応型RAG（ローカル）**   | 🧠 AI / 情報検索 | このチュートリアルはローカルモデルを用いた適応型RAGの実装に焦点を当てており、オフラインでの検索と生成を可能にします。インターネット接続が制限される環境やプライバシーが重要な場合に有用です。                                           | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_adaptive_rag_local.ipynb) |
| 🤖 **エージェンシックRAG**            | 🤖 AI / インテリジェントエージェント    | エージェントが最適な検索戦略を決定してから応答を生成するエージェンシックRAGシステムの構築方法を学び、回答の関連性と精度を向上させます。                                                                          | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_agentic_rag.ipynb) |
| 🤖 **エージェンシックRAG（ローカル）**    | 🤖 AI / インテリジェントエージェント    | このチュートリアルは、エージェンシックRAGをローカル環境に拡張し、ローカルモデルとデータソースを用いた検索と生成タスクを可能にします。                                                                                                     | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_agentic_rag_local.ipynb) |
| 🧠 **補正型RAG（CRAG）**  | 🧠 AI / 情報検索 | 取得した文書を評価し生成器に渡す前に洗練する補正型RAGシステムを実装し、より高品質な出力を保証します。                                                                                            | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_crag.ipynb) |
| 🧠 **補正型RAG（ローカル）** | 🧠 AI / 情報検索 | このチュートリアルはローカルリソースを使用した補正型RAGシステムの構築に焦点を当てており、オフラインでの文書評価と洗練プロセスを可能にします。                                                                                                | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_crag_local.ipynb)       |
| 🧠 **セルフRAG**               | 🧠 AI / 情報検索 | システムが自身の応答を振り返り必要に応じて追加情報を取得するセルフRAGの実装を学び、生成コンテンツの精度と関連性を向上させます。                                                              | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_self_rag.ipynb)                       |
| 🧠 **セルフRAG（ローカル）**       | 🧠 AI / 情報検索 | このチュートリアルでは、ローカルモデルとデータソースを用いてセルフRAGを実装し、オフラインでの振り返りと検索プロセスを可能にする方法を示します。                                                                                                     | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_self_rag_local.ipynb)         |





---

## 🤝 コントリビューティング

貢献は大歓迎です！🎉 ご協力いただける方法は以下の通りです：

1. リポジトリをフォークしてください。
2. 新しいユースケースを追加するか既存のものを改善してください。
3. 変更内容を含むプルリクエストを提出してください。

詳しくは[貢献ガイドライン](https://raw.githubusercontent.com/ashishpatel26/500-AI-Agents-Projects/main/CONTRIBUTING.md)をご参照ください。

---

## スター履歴

<picture>
  <source
    media="(prefers-color-scheme: dark)"
    srcset="
      https://api.star-history.com/svg?repos=ashishpatel26/500-AI-Agents-Projects&type=date&legend=top-left
    "
  />
  <source
    media="(prefers-color-scheme: light)"
    srcset="
      https://api.star-history.com/svg?repos=ashishpatel26/500-AI-Agents-Projects&type=date&legend=top-left
    "
  />
  <img
    alt="スター履歴チャート"
    src="https://api.star-history.com/svg?repos=ashishpatel26/500-AI-Agents-Projects&type=date&legend=top-left"
  />
</picture>

---

## 📜 ライセンス

このリポジトリはMITライセンスの下でライセンスされています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。

---

## 🚀 一緒に作りましょう！

このリポジトリをネットワークで共有し、有用だと思ったらスター⭐を付けてください。AIエージェントのユースケースの究極のリソースを一緒に作りましょう！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---