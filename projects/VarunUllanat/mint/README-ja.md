<h1 align="center">
  タンパク質間相互作用の言語を学ぶ
</h1>

## 🌿 MINTの概要

MINT（Multimeric INteraction Transformer）は、相互作用するタンパク質配列の**文脈的かつスケーラブル**なモデリングのために設計されたタンパク質言語モデル（PLM）です。STRINGデータベースから得られた**9600万件のタンパク質間相互作用（PPI）**の大規模かつ厳選されたセットで訓練されており、MINTは以下を含む多様なタスクおよびタンパク質タイプにおいて既存のPLMを上回る性能を発揮します：

- 結合親和性予測
- 突然変異効果の推定
- 複合タンパク質の組み立てモデリング
- 抗体-抗原相互作用モデリング
- T細胞受容体-エピトープ結合予測

🔬 **なぜMINTなのか？**

✅ 大規模PPIデータで訓練された初のPLM

✅ 複数のPPIタスクで最先端の性能

✅ 多様なタンパク質相互作用に対応可能でスケーラブル

## 🖥️ インストール 

1. 提供された `enviroment.yml` ファイルから新しい[conda](https://docs.anaconda.com/miniconda/install/)環境を作成します。

```
conda env create --name mint --file=environment.yml
```

2. 環境を有効化し、ソースからパッケージをインストールします。

```
conda activate mint
pip install -e .
```
3. パッケージをインポートできるか確認してください。


```
python -c "import mint; print('Success')" 
```

4. モデルチェックポイントをダウンロードし、保存されたファイルパスを確認してください。

```
wget https://huggingface.co/varunullanat2012/mint/resolve/main/mint.ckpt
```

## 🚀 使い方

### 埋め込みの生成

相互作用する配列を含むCSVファイル（こちらの例 [here](https://raw.githubusercontent.com/VarunUllanat/mint/main/./data/protein_sequences.csv)）から埋め込みを生成することをお勧めします。次に、以下のコードを実行するだけで、すべての入力配列の平均埋め込みを取得できます。 

```
import torch
from mint.helpers.extract import load_config, CSVDataset, CollateFn, MINTWrapper

cfg = load_config("data/esm2_t33_650M_UR50D.json") # model config
device = 'cuda:0' # GPU device
checkpoint_path = '' # Where you stored the model checkpoint

dataset = CSVDataset('data/protein_sequences.csv', 'Protein_Sequence_1', 'Protein_Sequence_2')
loader = torch.utils.data.DataLoader(dataset, batch_size=2, collate_fn=CollateFn(512), shuffle=False) 

wrapper = MINTWrapper(cfg, checkpoint_path, device=device)

chains, chain_ids = next(iter(loader)) # Get the first batch
chains = chains.to(device)
chain_ids = chain_ids.to(device)
embeddings = wrapper(chains, chain_ids)  # Generate embeddings
print(embeddings.shape) # Should be of shape (2, 1280)
```
しかし、下流タスクで最大のパフォーマンスを得るために、ラッパークラスで `sep_chains=True` 引数を使用することを**推奨**します。これにより、**すべてのシーケンス**のシーケンスレベルの埋め込みを取得し、入力と同じ順序で連結して返します。


```
wrapper = MINTWrapper(cfg, checkpoint_path, sep_chains=True, device=device)

chains, chain_ids = next(iter(loader)) # Get the first batch
chains = chains.to(device)
chain_ids = chain_ids.to(device)
embeddings = wrapper(chains, chain_ids)  # Generate embeddings
print(embeddings.shape) # Should be of shape (2, 2560)
```

### バイナリPPI分類

2つの入力シーケンスが相互作用するかどうかを予測するためのコードと[モデルチェックポイント](https://huggingface.co/varunullanat2012/mint/blob/main/bernett_mlp.pth)を提供しています。ダウンストリームモデルであるMLPは、[Bernettら](./downstream/GeneralPPI/ppi)のゴールドスタンダードデータを使用して訓練されています。 

```
import torch
from mint.helpers.extract import load_config, CSVDataset, CollateFn, MINTWrapper
from mint.helpers.predict import SimpleMLP

cfg = load_config("data/esm2_t33_650M_UR50D.json") # model config
device = 'cuda:0' # GPU device
checkpoint_path = 'mint.ckpt' # Where you stored the model checkpoint
mlp_checkpoint_path = 'bernett_mlp.pth' # Where you stored the Bernett MLP checkpoint

dataset = CSVDataset('data/protein_sequences.csv', 'Protein_Sequence_1', 'Protein_Sequence_2')
loader = torch.utils.data.DataLoader(dataset, batch_size=2, collate_fn=CollateFn(512), shuffle=False) 

wrapper = MINTWrapper(cfg, checkpoint_path, sep_chains=True, device=device)

# Generate embeddings 
chains, chain_ids = next(iter(loader)) 
chains = chains.to(device)
chain_ids = chain_ids.to(device)
embeddings = wrapper(chains, chain_ids) # Should be of shape (2, 2560)

# Predict using trained MLP
model = SimpleMLP() 
mlp_checkpoint = torch.load(mlp_checkpoint_path)
model.load_state_dict(mlp_checkpoint)
model.eval()
model.to(device)

predictions = torch.sigmoid(model(embeddings)) # Should be of shape (2, 1)
print(predictions) # Probability of interaction (0 is no, 1 is yes)
```

### ファインチューニング

新しい教師ありデータセットでモデルをファインチューニングするには、`freeze_percent` パラメータを1以外の値に設定します。0.5に設定すると、モデルの最後の50％のレイヤーが訓練可能になります。例えば、 

```
import torch
from mint.helpers.extract import MINTWrapper

cfg = load_config("data/esm2_t33_650M_UR50D.json") # model config
device = 'cuda:0' # GPU device
checkpoint_path = '' # path where you stored the model checkpoint

wrapper = MINTWrapper(cfg, checkpoint_path, freeze_percent=0.5, device=device)
for name, param in wrapper.model.named_parameters():
    print(f"Parameter: {name}, Trainable: {param.requires_grad}")
```

### STRING-DBでの事前学習

このセクションでは、STRING-DBからのPPIでMINTを事前学習するために必要な手順を説明します。まず、トレイン-バリデーション分割を作成するために、[STRING-DB](https://stringdb-downloads.org/download/)から`protein.physical.links.v12.0.txt.gz`と`protein.sequences.v12.0.fa.gz`をダウンロードします。

次に、[mmseqs](https://github.com/soedinglab/MMseqs2)を使用して50％の配列類似度閾値で配列をクラスタリングするために、以下のコマンドを実行します。

```
mmseqs createdb protein.sequences.v12.0.fa DB100
mmseqs cluster DB100 clu50 /tmp/mmseqs --min-seq-id 0.50 --remove-tmp-files
mmseqs createtsv DB100 DB100 clu50 clu50.tsv
```

次に、`stringdb.py`を実行します。このスクリプト内のファイルパスが、`protein.sequences.v12.0.fa`、`clu50.tsv`（前のステップの出力）、および`protein.physical.links.full.v12.0.txt.gz`ファイルを保存したパスと一致していることを確認してください。

最後に、以下のようにトレーニングを実行します：

```
python train.py --batch_size 2 --crop_len 512 --model 650M --val_check_interval 320000 --accumulate_grad 32 --run_name 650M_nofreeze_filtered --copy_weights --wandb --dataset_split filtered
```

### 例

`downstream`フォルダ内に、さまざまな教師ありタスクおよび異なるタンパク質タイプにおけるMINTの使用例をいくつか提供しています。

1. [2つのタンパク質が相互作用するかどうかを予測する](./downstream/GeneralPPI/ppi)
2. [タンパク質複合体の結合親和性を予測する](./downstream/GeneralPPI/pdb-bind)
3. [変異後に2つのタンパク質が相互作用するかどうかを予測する](./downstream/GeneralPPI/mutational-ppi)
4. [変異によるタンパク質複合体の結合親和性の差を予測する](./downstream/GeneralPPI/SKEMPI_v2)


## 📝 引用について 

```
@article{ullanat2026learning,
  title={Learning the language of protein-protein interactions},
  author={Ullanat, Varun and Jing, Bowen and Sledzieski, Samuel and Berger, Bonnie},
  journal={Nature Communications},
  year={2026},
  publisher={Nature Publishing Group UK London}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-10

---