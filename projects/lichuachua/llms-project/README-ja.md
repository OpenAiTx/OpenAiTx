# 大規模モデルアプリ開発学習ロードマップ（速習版）

本リポジトリは私が🔥大規模モデルアプリ開発🔥を学習する際に整理した資料で、すべて実用的な内容のみで、余計な拡張はありません。💰稼ぐことが最優先💰です。ご覧いただき、役に立ったら🌟 star をお願いします、ありがとうございます！

# ✅ 読みどころ

本プロジェクトは大規模モデルアプリ開発におけるRAGとAgentの簡単なデモを示しており、すべてLangChainフレームワークを使用しています。最も基本的な入門コースも含み、みなさんの🧐素早い入門🧐をサポートします。  
ディレクトリ構造は3つに分かれています：  
- **LangChain_RAGフォルダ**：RAG関連のプロジェクトデモと学習資料；  
- **LangChain_Agentフォルダ**：Agent関連のデモと学習資料；  
- **Interview**：大規模モデルRAGとAgentの面接用定番問題。

# ✅ LangChain_RAG

この部分は合計**4つのセクション**に分かれています：  
- llms-1とllms-2はBilibiliの🕶️**入門講座**🕶️で、2名のアップ主が明快かつ簡潔に解説。入門理解用で、さっと流してもらってOKです；  
- llms-3はLangChain公式のRAGチュートリアルで、ここにはオリジナルと国内翻訳版の動画があります。RAGプロセスの主要な流れと最適化ポイントを解説しており、**🔥特にここを重点的に見ることを推奨、面接で多く問われます🔥**；  
- llms-4はLangChain公式提供の**💡RAGプロジェクト💡**例で、基本的なRAGプロジェクトの流れを含み、すぐに動かせるシンプルなコード構成です。

## llms-1
### 動画URL（シリーズ全体を見る場合）：
- https://www.bilibili.com/video/BV1qC4y1F7Dy
### コード：
- 🌹コードURL（実行可能版）：https://github.com/lichuachua/llms-project/tree/main/LangChain_RAG/llms-1/  
  - note（✅こちらの実行版のダウンロードと実行を推奨します✅）：私が動作確認済みで、一部パッケージを更新済み（元作者コードの一部パッケージは古い）  
  - original：元作者コード（同じコードの元リポジトリですが推奨しません、パッケージ更新が必要な可能性あり）  
- 元コードリポジトリ：https://github.com/blackinkkkxi/RAG_langchain/tree/main  
- 実行環境：langchain_hfを除きColabで実行可能。Kaggleでも実行可能。Kaggle入門はこちら：[無料で計算資源を利用、量は少ないが十分——Kaggle](https://mp.weixin.qq.com/s/SK5VXzx2zijzjc8OYJICKA)；  
## llms-2
### 動画URL（単一動画のみ視聴でOK）：
- https://www.bilibili.com/video/BV1Cp421R7Y7
### コード：
- 🌹コードURL（実行可能版）：https://github.com/lichuachua/llms-project/tree/main/LangChain_RAG/llms-2/  
  - note（✅こちらの実行版のダウンロードと実行を推奨します✅）：私が動作確認済みで、一部パッケージを更新済み（元作者コードの一部パッケージは古い）  
  - original：元作者コード（同じコードの元リポジトリですが推奨しません、パッケージ更新が必要な可能性あり）  
- 元コードリポジトリ：https://github.com/owenliang/rag-retrieval/tree/main  
- 実行環境：Kaggleで実行可能。Kaggle入門はこちら：[無料で計算資源を利用、量は少ないが十分——Kaggle](https://mp.weixin.qq.com/s/SK5VXzx2zijzjc8OYJICKA)；  
## llms-3
### 動画URL（シリーズ全体）：
- 海外オリジナル動画（英語）：https://www.youtube.com/playlist?list=PLfaIDFEXuae2LXbO1_PKyVJiQ23ZztA0x
- 国内中文版：https://www.bilibili.com/video/BV1dm41127jc/
### 代码：
- 🌹コード住所（実行可能版）：https://github.com/lichuachua/llms-project/tree/main/LangChain_RAG/llms-3/
  - note（✅こちらのダウンロード・実行を推奨します✅）：私がコードを実行し、一部パッケージの更新を行いました（元作者のコードの一部パッケージは期限切れ）
  - original：元作者のコード（同じコード元、推奨しません、パッケージ更新が必要な可能性あり）
  - PPT：公式動画対応のPPT
- コード元：https://github.com/langchain-ai/rag-from-scratch/tree/main  
- 実行環境：Kaggle実行、Kaggle入門参考：[無料計算リソースを活用、量は少ないが十分——Kaggle](https://mp.weixin.qq.com/s/SK5VXzx2zijzjc8OYJICKA)；
## llms-4
### 代码：
- 🌹コード住所（✅私が変更したコードでそのまま実行可能✅）：https://github.com/lichuachua/chat-langchain-study/
- コード元（実行に問題あり、自分で修正が必要）：https://github.com/langchain-ai/chat-langchain
### 説明：
- langchain-chatは公式提供のRAGプロジェクト例で、初心者向けにおすすめのプロジェクトです。要望に応じて、手取り足取りの実行動画を録画し、確実に動かせるようにしています。
### 参考資料：
- https://www.bilibili.com/video/BV1eB4y1Z752/
- https://github.com/webup/agi-talks/blob/master/301-langchain-chatdoc/src/slides.md
- https://blog.langchain.dev/building-chat-langchain-2/
            

# ✅ LangChain_Agent

本部分は**2つのパート**で構成されており、Bilibiliの2つのシンプルなAgentデモで、わかりやすい内容です。
- AI_Agent は OPENAI_API ベース
- QW_Agent は QWen_API ベース


## AI_Agent
### 動画リンク：
- https://www.bilibili.com/video/BV1JV411F7Yj/
### 代码：
- 🌹コード住所（✅私が修正したコードで直接実行可能✅）：https://github.com/lichuachua/llms-project/tree/main/LangChain_Agents/AI_Agent/
- コード元：https://github.com/parallel75/AI_Agent  
- 実行環境：ローカル

## QW_Agent
### 動画リンク：
- https://www.bilibili.com/video/BV1QF4m177Rx/
### 説明：
- このプロジェクトは【千問関連のkeyとapi】の申請が必要で、難所があります。私が修正したコードをダウンロードすると直接実行できます。千問の新しいバージョンはコードの更新が必要で、私が対応済みです。
### コード：
- 🌹コードの場所（✅本人が変更したコードで、直接実行可能✅）：https://github.com/lichuachua/llms-project/blob/main/LangChain_Agents/QW_Agent/
- コードの元の場所（実行に問題があり、自分で変更が必要）：https://github.com/owenliang/agent
- 実行環境：ローカル

# ✅ Interview
本セクションは二部構成の面接定型文であり、本人が就職活動中に収集・整理した大規模モデル応用開発の定型文です。本人の実測によると、これらを用いていくつかの大手企業の**上級AI開発エンジニア**関連の職を見つけることができました。
- [大規模モデル応用開発の定型文](https://mp.weixin.qq.com/mp/appmsgalbum?__biz=Mzk1NzgzMjY3OQ==&action=getalbum&album_id=3987723560113356813&scene=126&uin=&key=&devicetype=iMac+MacBookPro18%2C3+OSX+OSX+15.4.1+build(24E263)&version=13080a10&lang=zh_CN&nettype=WIFI&ascene=78&fontScale=100)
## RAG
- 大規模モデル（LLMs）RAG検索強化生成学習および面接で遭遇する可能性のある知識点を詳細に紹介し、全文4万字以上、処理フローに沿って整理：[大規模モデルRAG知識ノート](https://mp.weixin.qq.com/s/zmUTGAMoljXSmnoo_cBQig)
## Agent
- 大規模モデル（LLMs）エージェントAgent学習および面接で遭遇する可能性のある知識点を詳細に紹介し、全文1万字以上、モジュール別に整理：[大規模モデルAgent知識ノート](https://mp.weixin.qq.com/s/TSioLS_RhrX57YEnY3mkag)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-03

---