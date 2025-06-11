# KVzip: コンテキスト再構築によるクエリ非依存型KVキャッシュ圧縮

[[論文](https://arxiv.org/abs/2505.23416)] [[ブログ](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## 新機能
- KVzipはKVキャッシュを圧縮し、**多様な将来のクエリ**に対応します。
- [コンテキスト依存] **3〜4倍のKVキャッシュサイズ削減**および**2倍のデコードレイテンシ削減**を達成し、性能劣化は最小限です。
- [コンテキスト非依存] [DuoAttention](https://github.com/mit-han-lab/duo-attention)スタイルのヘッド単位KV圧縮を強化し、ヘッド単位の重要度スコア最適化を**1分以内に数回のフォワードパスのみで**行います（100倍高速化）。
- demo.pyを実行:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### クエリ非依存設定でのベンチマーク
- タスク: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294)。 
- モデル: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## インストール
CUDA 12.1とPython 3.10を使用しています。
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- [QServe](https://github.com/mit-han-lab/omniserve)量子化を使用する場合は、[`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model)を参照してください。
### データセット
- 前処理済みSCBenchデータセットは[Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link)からダウンロードしてください。
- ファイルを解凍した場合は、単にscbenchフォルダを移動します。
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## クイックスタート
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "これは私の基本プロフィールです。私の名前はキムで、ソウルに住んでいます。専攻はコンピュータサイエンスです。"
queries = ["私の名前は何ですか？", "私はソウルに住んでいますか？"]

kv = model.prefill(context, load_score=False)  # KVキャッシュの事前生成＋重要度スコアリング
kv.prune(ratio=0.3)  # 圧縮率、70%のKVを削除

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # 効率的な推論
    print(q, output)
```
- 対応モデルは[`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py)に記載されており、**LLaMA3, Qwen2.5/3, Gemma3**を含みます。
- `load_score=True`を設定すると圧縮オーバーヘッドがなくなり、コンテキスト非依存のKV削除が可能になります。圧縮率は`ratio=0.6`でトレードオフがあります。
- 生成後、クエリと生成トークンに対応するKVペアはさらに処理のために選択的にキャッシュから削除されます。`update_cache=True`を設定するとマルチターン推論が可能になり、推論中の全ての対話履歴が保持されます。

## メモリと計算時間のプロファイリング
### コンテキスト依存削除
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- 上記コードは、フルKVキャッシュと削減されたKVキャッシュの生成結果も比較します。
- 簡易テストには`-d squad`を使用。長文コンテキストテストには`-d scbench_kv`を使用。
  - 利用可能なデータ名は[`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py)を参照。
  - 利用可能なモデル名は[`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py)を参照。例: llama3.1-8b, qwen2.5-7b（またはQwen/Qwen2.5-7B-Instruct-1M）。
- CUDAカーネルは[AdaKV](https://github.com/FFY0/AdaKV/tree/main)から適応し、非一様なヘッド予算割り当てをサポート。
  - 現状、Gemma3用の静的KVキャッシュに最適化されたカーネルがなく、実際の効率化はありませんが、KVサブサンプリングによる削減注意でモデル性能評価は可能（`--kv_type retain`）。

### コンテキスト非依存削除（ランタイム圧縮オーバーヘッドなし）
- `--level head`フラグと`--ratio 0.6`（推奨）を使用。
  - システムプロンプトとクエリのKVペアは保持しつつ、特定ヘッドに紐づく全てのコンテキストKVペアを削除します。
  - LLaMA3.1-8BおよびQwen2.5-7/14B用の事前計算済みヘッドスコアは`./utils/head_score`にあります。
- 他モデルのヘッドスコア計算方法:
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - 結果は`./utils/head_score`に保存されます。
  - コーディングタスクを対象にする場合は、`-d scbench_repoqa`でも同様に実行することを推奨します。自然言語とコーディング言語の両方から最大のヘッドスコアを使用でき、性能が向上します。
- これらのスコアは[DuoAttention](https://github.com/mit-han-lab/duo-attention)の最適化推論エンジンにシームレスに統合可能で、ヘッドスコアデータを置換するだけで利用できます。

## 評価
- KV圧縮率0.1〜1.0の範囲でモデル応答を生成するには:
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - 結果は`./results/[data_name]`に保存されます。
  - 対応データセットは`data/load.py`に記載。
- 生成結果から評価指標を計算するには:
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## 新規モデルへの適用
KVzipを新規モデルに統合するには、以下のファイルを更新する必要があります:
- `attention/attn.py`  
  注意のフォワードパスロジックを必要に応じて修正。場合によっては`kvcache.py`や`score.py`の更新も必要。
- `model/monkeypatch.py`  
  モデル固有のモンキーパッチを実装。
- `model/template.py`   
  モデルのシステムプロンプトやチャットフォーマットテンプレートを定義。

## 引用
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## ライセンス
MIT License

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---