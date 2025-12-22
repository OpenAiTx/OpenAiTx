# ExpeRepair

**ExpeRepair** は、二重メモリシステムを通じて過去の修復経験を継続的に蓄積・再利用する新しいLLMベースのプログラム修復フレームワークです。以下の2つの主要コンポーネントで構成されます：
- **プログラム修復モジュール**：テストエージェントとパッチエージェントからなり、テスト生成、パッチ生成、パッチ検証の3つの主要タスクを協調して処理します。
- **メモリモジュール**：プログラム修復モジュールから修復軌跡をキャプチャし、具体的なデモンストレーションを抽出し、高レベルの修復戦略を要約します。これらはそれぞれ**エピソードメモリ**と**セマンティックメモリ**に保存されます。将来の修復時には、ExpeRepairは関連するデモンストレーションと洞察を検索し、新しい問題に対する修復戦略を強化します。

## 🚀 クイックスタート

### インストール
```bash
git clone <repository-url>
cd ExpeRepair-v1.0
pip install -r requirements.txt
```

### 環境設定

APIキーを環境変数として設定してください：
```bash
export PYTHONPATH=$PYTHONPATH:$(pwd)
# OpenAI key
export OPENAI_KEY="your-openai-key"
# Anthropic Key
export CLAUDE_KEY="your-anthropic-key"
```
[Agentless](https://arxiv.org/abs/2407.01489)に従い、ExpeRepairは**リポジトリ構造フォーマット**を使用して疑わしいファイルを特定します。  
リポジトリを自分で前処理するか、準備済みのデータをダウンロードできます: [swebench_lite_repo_structure.zip](https://github.com/OpenAutoCoder/Agentless/releases/tag/v1.5.0)。  

ダウンロード後、解凍してその場所をエクスポートしてください:

```bash
export PROJECT_FILE_LOC={folder which you saved}
```
最後に、[auto-code-roverプロジェクト](https://github.com/AutoCodeRoverSG/auto-code-rover#setting-up-testbed)の指示に従ってテストベッドを設定してください。

### フルベンチマークでのExpeRepairの実行
1. **すべてのインスタンスID**で`run_reproduce_initial.sh`を実行します。
2. **すべてのインスタンスID**で`run_localization.sh`を実行します。
3. 再現に成功したインスタンス（つまり、有効な`reproducer_X.py`スクリプトが生成されたもの）については、`generate_initial.py`を実行します。
4. 残りのインスタンスについては、蓄積されたメモリを活用し更新を続ける`generate_w_memory.py`を実行します。
5. 最後に、**すべてのインスタンスID**で`validation.py`と`obtain_predictions.py`を実行します。

### 使用方法


```bash
# reproduce the issue
bash inference/run_reproduce_initial.sh

# localize potential bug locations
bash inference/run_localization.sh

# generate candidate patches
bash inference/run_generate.sh

# validate candidate patches and select the best one
python inference/validation.py

# obtain the prediction results
python inference/obtain_predictions.py
```

## 🙏 謝辞

* [SWE-bench](https://www.swebench.com/)
* [auto-code-rover](https://github.com/AutoCodeRoverSG/auto-code-rover)
* [Agentless](https://github.com/OpenAutoCoder/Agentless/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---