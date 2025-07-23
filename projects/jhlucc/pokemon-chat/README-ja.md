📘 中文 | [English](https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/./README.en.md)

<img src="https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/resources/picture/11.png" alt="图标" style="width: 27%;" />

# 「可萌」 <img src="https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/resources/picture/brain-removebg-preview.png" alt="图标" style="width: 11%;" /> 知識ベースと知識グラフに基づく専用ドメインチャットアシスタント

![Python](https://img.shields.io/badge/Python-3.11-blue?style=flat&logo=python)
![FastAPI](https://img.shields.io/badge/FastAPI-005571?style=flat&logo=fastapi)
![Docker](https://img.shields.io/badge/Docker-2496ED?style=flat&logo=docker&logoColor=ffffff)
![LangGraph](https://img.shields.io/badge/LangGraph-Flow-green?style=flat&logo=databricks)
![GraphRAG](https://img.shields.io/badge/GraphRAG-KG-blueviolet?style=flat)
![Agent](https://img.shields.io/badge/Agent-System-orange?style=flat)
![Vue3](https://img.shields.io/badge/Vue-3.0-4FC08D?style=flat&logo=vue.js)
![License](https://img.shields.io/github/license/bitcookies/winrar-keygen.svg?logo=github)



<img src="https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/resources/picture/img.png" alt="図標" style="width: 90%;" />



---

## 📝 プロジェクト紹介

ポケットモンスター（Pokémon）は、世界で最も影響力のあるIPの一つとして、膨大な世界観設定と大量のキャラクターデータを持っています。ゲーム、アニメ、カードゲーム、映画など多分野での長年の蓄積により、その知識体系は複雑かつ高度に構造化されており、知識グラフのモデリングとインテリジェントな質問応答シーンに非常に適しています。

大規模言語モデル（LLM）と知識強化技術の発展に伴い、ポケモンの宇宙を**マルチモーダルで構造化され、インタラクティブなAIシステム**として構築することが可能になりました。本プロジェクトは百度贴吧とウィキペディアなどのデータソースを基に、ポケモンのキャラクター、属性、技、地域、進化経路などの要素を網羅した知識グラフを構築し、大規模モデルの能力と組み合わせて、**専用ポケモン世界のインテリジェント対話アシスタント**「可萌」を作り上げました。

これを基に、**LangGraph推論フロー編成**、**GraphRAG検索強化技術**、および**知識グラフの可視化探索能力**を融合し、ユーザーは自然言語で質問して正確な答えを得られるだけでなく、グラフ形式でポケモンの世界を直感的に探索することも可能です。また、地理位置に基づくマップロケーション機能をサポートし、ポケモンの世界と現実世界の座標を一対一でマッピングし、**ポケモンの場所知識の空間可視化**を実現しています :earth_asia: 。

本プロジェクトは、移植性、拡張性を備えた愛好者向けの**専用ドメインインテリジェントアシスタントテンプレートシステム**の構築を目指しています。知識源とグラフ構造を変更するだけで、他のキャラクター（例：「蘇軾」、「金融」、「行政サービス」など）に簡単に移植して専用ドメインのインテリジェントアシスタントを作成でき、高品質なセマンティックQAと可視化知識探索体験を実現できます。

---

## 🎯 システムアーキテクチャ

本プロジェクトの実施により、Vue3+FastAPIの完全なプロジェクトを完成させただけでなく、ポケモン知識グラフに基づくインテリジェント質問応答システムを構築しました。BERT+TF-IDF+ルールマッチング機構などのセマンティック構造モデリング、及びグラフ融合と生成的質問応答の豊富な実践経験を積みました。システムはポケモンの進化関係、属性相性、技の特徴、地理的分布などに対して正確に質問応答をサポートし、インタラクティブな探索体験を大幅に向上させています。

今後は、多ターンQA、複雑なグラフ推論、地図ナビゲーションなどのシーンでのシステム性能を継続的に最適化し、推論QA、ポケモン図鑑自動補完、キャラクター対戦戦略提案などの対応タスクを拡充していきます。また、知識グラフは時効性、完全性、一貫性を保証するために継続的に更新・拡張し、ポケモン分野のインテリジェントシステム構築とAI応用の展開を支援します。

以下は本プロジェクトのコア技術アーキテクチャ図です：



 <img src="https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/resources/picture/now.png" alt="図標" style="width: 100%;" />

##  🎯 プロジェクトの特徴

1. スクレイピングしたデータに基づき、ポケモン専用大規模モデル——[可萌](https://huggingface.co/qwqqwq/qwen2.5-14b-instruct-pokemon-int4)を微調整しました。
2. スクレイピングデータを基にポケモン知識グラフ（ウィキペディア）を構築しました。
3. 自動化された注釈付きNERデータをトレーニングし、roberta+TF-IDF+ルールマッチングを使ってグラフ内のエンティティと属性を検出しました。
4. Whisperを使用してASR機能を実装しました。
5. MCPサービスを実現し、ポケモン世界の場所取得や対応する現実世界の緯度経度座標をフロントエンドに表示します。
6. RAGflow内のdeepdocを抽出して知識ベースの解析と抽出能力を強化しました。
7. LangGraphフレームワークを用いて独自データに基づきgraphrag+ウェブ検索+知識ベースのエージェントを実装しました。
8. エージェント基底クラスを封装し、多エージェント機能を実現しました。
9. 知識グラフ検索、ネット検索、知識ベース検索、MCP検索、音声検索をサポートし、同時統合または単独利用が可能です。

---

## 🚀 クイックスタート

> **前提条件**：Docker / Docker Compose、Node.js ≥ 18、Python ≥ 3.11がインストール済み

1. データを[resources](https://pan.baidu.com/s/1o48ankI6l9jaky5MeRqgYw?pwd=rkdy)フォルダに配置してください

2. **リポジトリをクローンし環境変数を設定する**

   ```bash
   git clone 
   cd Smart-Assistant
   cp src/.env.template src/.env   # 按需填写 API-KEY，可留空
   cp Smart-Assistant/config/settings_example.py  config/settings.py  # 填写 
   ```
3. **依存関係のインストール**


   ```bash
   pip install -r requirements.txt
   ```
4. **コアサービスの起動**


   ```bash
   cd docker
   docker compose up -d            # Neo4j · Milvus · Whisper · MySQL 等
   ```
5. **グラフおよびマップデータのインポート**


   ```bash
   cd scripts
   python import_graph.py          # 写入 Neo4j
   python import_pokemon_map.py    # 写入 MySQL
   ```

   

6. **启动后端服务**

   ```bash
   cd server
   python main.py                  # FastAPI + LangGraph
   cd ../src/mcp
   python mcp_server.py            # SSE 模式示例
   ```
7. **フロントエンドの起動**


   ```bash
   cd web
   npm install
   npm run dev
   # 浏览器访问 http://localhost:3100/
   ```

---

## 🔭 参考项目

- https://github.com/xerrors/Yuxi-Know

- https://github.com/BinNong/meet-libai

  

---

## 📄 License

本项目遵循 **MIT License**，可自由用于商业或个人项目。二次开发请保留原作者与来源信息。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---