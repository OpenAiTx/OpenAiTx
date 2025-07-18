<translate-content># MASS: ポートフォリオ構築のためのマルチエージェントシミュレーションスケーリング

📜 [論文リンク](https://arxiv.org/abs/2505.10278)

## ✨ 概要

![MASSの概要](https://raw.githubusercontent.com/gta0804/MASS/main/img/MASS.pdf)

## 📝 知っておくべきこと

1. 現在、MASSを実行するための完全なデータセットのごく[小さなサブセット](https://github.com/gta0804/MASS/tree/main/stock_disagreement/example_dataset)のみを提供しています。完全なデータセットはレビュー完了後に公開されます。

## 🧑‍💻使い方
1. **依存関係のインストール**</translate-content>
```
conda create -n your_env_name python==3.10 -y
conda activate your_env_name
pip install pdm
pdm install
```
2. **データセットの取得**  
データセットを取得した後、すべての`ROOT_PATH`変数をあなたのデータセットディレクトリに変更してください。  
現在、SSE 50指数の例示データセットを公開しています。  

3. **独自データセットでMASSを拡張する**  
時間制限のため、私たちのデータソースは限られています。より多くのデータソースをMASSに組み込むことで、より有意義なパフォーマンスを得ることを推奨します。また、投資ポートフォリオ構築を超えてMASSを拡張することも推奨します！  
以下のステップであなたのデータソースを使用できます：  
  - **独自のデータモダリティを定義する。**  
  MASSでは、[こちら](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/basic_agent.py#L42)で複数のデータモダリティを事前定義しています。これらをあなたのデータソースに変更可能です。データソースを変更した後は、データロードコードも[こちら](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/basic_agent.py#L165)で変更することを忘れないでください。
  ```
  class Modality(IntFlag):  
      FUDAMENTAL_VALUTION = 0b00000001  
      FUDAMENTAL_DIVIDEND = 0b00000010 
      FUDAMENTAL_GROWTH = 0b000000100
      FUDAMENTAL_QUALITY = 0b000001000
      NEWS = 0b000010000      
      BASE_DATA = 0b000100000  
      CROSS_INDUSTRY_LABEL = 0b001000000
      RISK_FACTOR = 0b010000000
      PRICE_FEATURE = 0b100000000 
  ```
- **独自の集約関数を使用する。**  
  MASSでは、市場の意見の不一致仮説に基づいて個々の投資家の意思決定を集約します。実際には、独自の集約方法を使用することも可能です。独自の集約関数のために[ investor_analyzer.py](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/investment_analyzer.py)のコードを変更してください！  
- **異なる最適化手法を使用する**  
  MASSでは、エージェント分布の最適化にシミュレーテッドアニーリングを使用しています。[ agent_distribution.py](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/agent_distribution.py)で最適化フレームワークを実装しています。独自の最適化手法を定義可能です。  
  

4. **計算資源の構成。**  
基盤モデルとして[Qwen2.5-72B-Instruct](https://huggingface.co/Qwen/Qwen2.5-72B-Instruct)を使用しています。基盤モデルのURLは[こちら](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/basic_agent.py#L57)で変更できます。  
SSE 50とデフォルト構成では、80GiBのRAMが必要です。エージェントの並列度を[こちら](https://github.com/gta0804/MASS/blob/main/stock_disagreement/exp/trainer.py#L148)で調整してメモリ使用量を削減できます。  

5. **MASSの実行**
```
python stock_disagreement/main.py
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---