# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 プロジェクトが気に入ったら、ぜひGitHubでスター ⭐ を押して最新情報をチェックしてください。</h5>
**MemoryOS** は、パーソナライズされたAIエージェントのためのメモリオペレーティングシステムを提供することを目的としています。これにより、より一貫性があり、パーソナライズされ、文脈を理解したインタラクションが可能になります。オペレーティングシステムのメモリ管理原理から着想を得ており、階層型ストレージアーキテクチャと4つのコアモジュール（Storage、Updating、Retrieval、Generation）を採用することで、包括的かつ効率的なメモリ管理を実現しています。LoCoMoベンチマークにおいて、本モデルはF1スコアとBLEU-1スコアでそれぞれ**49.11%**と**46.18%**の平均的な向上を達成しました。







## 📣 最新情報
*   *<mark>[新着]</mark>* 🔥  **[2025-06-15]**:🛠️ オープンソース版 **MemoryOS-MCP** をリリース！エージェントクライアント側でシームレスな統合とカスタマイズが可能になりました。[👉 詳細を見る](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: 初期バージョンの **MemoryOS** を公開！短期・中期・長期パーソナメモリを搭載し、ユーザープロファイルおよび知識の自動更新機能を実現。

## デモ
[![Watch the video](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	システムアーキテクチャ
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## プロジェクト構成

```
memoryos/
├── __init__.py            # MemoryOSパッケージの初期化
├── __pycache__/           # Pythonキャッシュディレクトリ（自動生成）
├── long_term.py           # 長期パーソナメモリの管理（ユーザープロファイル、知識）
├── memoryos.py            # MemoryOSのメインクラス、全コンポーネントを統括
├── mid_term.py            # 中期メモリの管理、短期インタラクションの集約
├── prompts.py             # LLMインタラクション用プロンプト（要約、分析など）を格納
├── retriever.py           # 全メモリ層から関連情報を取得
├── short_term.py          # 直近インタラクションの短期メモリ管理
├── updater.py             # メモリ更新処理、層間の情報昇格などを実施
└── utils.py               # ライブラリ共通のユーティリティ関数
```

## 動作概要

1.  **初期化:** `Memoryos`はユーザーIDやアシスタントID、APIキー、データ保存パス、各種容量/閾値設定で初期化されます。ユーザーおよびアシスタントごとに専用ストレージを用意します。
2.  **メモリ追加:** ユーザー入力とエージェント応答をQAペアとして追加します。これらは最初は短期メモリに保存されます。
3.  **短期から中期への処理:** 短期メモリが一杯になると、`Updater`モジュールがこれらのインタラクションを処理し、有意義なセグメントにまとめて中期メモリに保存します。
4.  **中期分析 & LPM更新:** 中期メモリのセグメントは、訪問頻度やインタラクションの長さ等の要素に基づいて“熱度”が蓄積されます。熱度が閾値を超えると、内容が分析されます：
    *   ユーザープロファイルの洞察を抽出し、長期ユーザープロファイルを更新
    *   特定のユーザー情報を長期知識に追加
    *   アシスタント用の関連情報をアシスタント長期知識ベースに追加
5.  **応答生成:** ユーザーのクエリ受信時：
    *   `Retriever`モジュールが短期履歴・中期メモリ・ユーザープロファイル＆知識・アシスタント知識ベースから関連コンテキストを取得
    *   この包括的なコンテキストとユーザーのクエリを組み合わせて、LLMにより一貫性と情報性のある応答を生成

## MemoryOS_PYPI クイックスタート

### 必要条件

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### インストール

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### 基本的な使い方

```python

import os
from memoryos import Memoryos

# --- 基本設定 ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # ご自身のキーに置き換えてください
BASE_URL = ""  # オプション: カスタムOpenAIエンドポイント利用時
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS シンプルデモ")
    
    # 1. MemoryOSの初期化
    print("MemoryOSを初期化しています...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOSの初期化に成功しました！\n")
    except Exception as e:
        print(f"エラー: {e}")
        return

    # 2. 基本的なメモリの追加
    print("メモリを追加しています...")
    
    memo.add_memory(
        user_input="Hi! I'm Tom, I work as a data scientist in San Francisco.",
        agent_response="Hello Tom! Nice to meet you. Data science is such an exciting field. What kind of data do you work with?"
    )
     
    test_query = "What do you remember about my job?"
    print(f"ユーザー: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"アシスタント: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP クイックスタート
### 🔧 コアツール

#### 1. `add_memory`
ユーザーとAIアシスタント間の会話内容をメモリシステムに保存し、永続的な対話履歴とコンテキスト記録を構築します。

#### 2. `retrieve_memory`
クエリに基づいてメモリシステムから関連する過去の対話、ユーザー嗜好、知識情報を取得し、AIアシスタントがユーザーのニーズや背景を理解できるようにします。

#### 3. `get_user_profile`
過去の対話分析から生成されたユーザープロファイル（性格特性、興味・嗜好、関連知識背景など）を取得します。


### 1. 依存関係のインストール
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. 設定

`config.json`を編集：
```json
{
  "user_id": "あなたのユーザーID",
  "openai_api_key": "あなたのOpenAI APIキー",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. サーバーの起動
```bash
python server_new.py --config config.json
```
### 4. テスト
```bash
python test_comprehensive.py
```
### 5.Clineや他のクライアントでの設定
mcp.jsonファイルをコピーし、ファイルパスが正しいことを確認してください。
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#仮想環境のPythonインタプリタに変更してください
```
## 貢献について

コントリビューションは大歓迎です！IssueやPull Requestをお気軽にご提出ください。

## 論文引用
詳細を読みたい場合はこちらをクリックしてください: [全文を読む](https://arxiv.org/abs/2506.06326)

本プロジェクトが役立った場合は、ぜひ論文の引用をご検討ください。

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## お問い合わせ
百家AIは北京郵電大学の白婷副教授が指導する研究グループであり、シリコンベースの人類のために感情豊かで卓越した記憶を持つ脳の構築に取り組んでいます。<br>
ご協力やご提案：baiting@bupt.edu.cn<br>
百家Agent公式アカウントやWeChatグループのフォローも歓迎いたします。ぜひご交流ください！  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="百家Agent公式アカウント" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="WeChatグループQRコード" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---