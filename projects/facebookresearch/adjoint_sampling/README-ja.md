
# アジョイントサンプリング

このリポジトリは、アジョイントサンプリング：アジョイントマッチングによる高スケーラブル拡散サンプラーの公式実装と実験を含みます。

アジョイントサンプリングは、正規化されていない密度から参照データなしでサンプリングを学習する、高度にスケーラブルな拡散ベースのサンプリングフレームワークです。アジョイントサンプリングは、生成モデルとエネルギー関数の両方の複雑さに関してスケーラブルであり、最先端のニューラルエネルギー関数の使用を可能にします。

**[Arxiv](https://arxiv.org/abs/2504.11713)（ICML 2025採択）**  
*著者：_アーロン・ヘイヴンズ、ベンジャミン・カート・ミラー、ビン・ヤン、カーレス・ドミンゴ＝エンリッチ、アヌループ・スリラム、ブランドン・ウッド、ダニエル・レビン、ビン・フー、ブランドン・エイモス、ブライアン・キャラー、シアン・フー、グアン＝ホルング・リウ、リッキー・T・Q・チェン_*

![](https://raw.githubusercontent.com/facebookresearch/adjoint_sampling/main/./assets/molecule_progression.png)

我々は、新しい償却型コンフォーマ生成タスクであるeSENエネルギー関数とSPICEを用いてアジョイントサンプリングを評価します。SPICEは有機薬物様分子の大規模データセットで、原子種や結合構造を含む分子グラフ情報を提供します。

## インストール

依存関係をインストールしてください。

```bash
micromamba env create -f environment.yml
micromamba activate adjoint_sampling
```
エネルギーモデルに対してトレーニングを行うには、[Hugging Faceリポジトリ](https://huggingface.co/facebook/adjoint_sampling)にある[eSEN](https://arxiv.org/abs/2502.12147)のチェックポイントが必要です。  
コードを実行する際に、`huggingface-cli`に[トークン](https://huggingface.co/settings/tokens)を提供すれば、自動的にダウンロードされます。トークンを使用するには、まず[リポジトリへのアクセス申請](https://huggingface.co/facebook/adjoint_sampling)を行う必要があります。
```bash
huggingface-cli login
```
## データ

分子は `data/{drugs_test,spice_test,spice_train}.txt` 内の行に3つの列で整理されています：回転可能結合数、SMILES文字列、ハッシュ。分子の [CREST](https://github.com/crest-lab/crest) コンフォーマーを見つけるにはハッシュが必要です。`{drugs,spice}` の分子に対し `${hash}` がある場合、コンフォーマーは `data/{drugs,spice}_test_conformers/${hash}` ディレクトリ以下の単一テキストファイルに連結された `.xyz` ブロックとして書かれています。

`drugs` のコンフォーマーは [GEOM](https://github.com/learningmatter-mit/geom) 由来です。`spice` のコンフォーマーは FAIR Chemistry によって計算されました。

## モデル

すべてのモデルは [Hugging Face](https://huggingface.co/facebook/adjoint_sampling) でホスティングされています。ローカルディレクトリ `models` にファイルをダウンロードするスクリプトを提供しています。モデルのダウンロードには [トークン](https://huggingface.co/settings/tokens) が必要です。ダウンロード前に必ず [リポジトリへのアクセス申請](https://huggingface.co/facebook/adjoint_sampling) を行ってください。


```bash
python download_models.py
```
モデルがダウンロードされたら、評価や自身のプロジェクトで使用するためにパスをコピーできます。 チェックポイントは次のように識別できます:

```
Cartesian AdjSampling             -   models/am/checkpoints/checkpoint_4999.pt
Cartesian AdjSampling (+pretrain) -   models/bmam/checkpoints/checkpoint_4999.pt
Torsional AdjSampling             -   models/torsion/checkpoints/checkpoint_3000.pt

Pretrained Cartesian              -   pretrain_for_bmam/checkpoints/checkpoint_2000.pt
```
`Cartesian AdjSampling (+pretrain)` のトレーニング目的で `Pretrained Cartesian` を提供しています。


## SPICEデータセットでのトレーニング

各モデルは8つのGPUを使用し72時間かけてトレーニングしました。これらのコマンドは対応するモデルをトレーニングします。

トレーニングを開始する**前に**、多くのCPUを持つ単一ノードで以下のコマンドを実行してください！2つ目のコマンドは、Torsional AdjSamplingモデルをトレーニングする場合にのみ必要です。
```bash
python cache_dataset.py
python cache_dataset.py --learn_torsions
```


私たちのリポジトリは、共有ファイルが設定で `shared_dir` として知られる共有ディレクトリに置かれる分散トレーニングを可能にします。デフォルトでは `/home/${oc.env:USER}` に設定されています。これは [hydra](https://hydra.cc/docs/intro/) の変数展開構文によりトレーニング時に `/home/${USER}` に評価されます。

##### Cartesian AdjSampling

```bash
python train.py experiment=spice_cartesian
```
##### Cartesian AdjSampling (+pretrain)

このモデルは逐次学習が必要です。最初に、最初のコマンドを使用して「事前学習済み」モデルを学習させる必要があります。次に、2番目のモデルを最初のモデルから初期化するように、`init_model=...`で初期チェックポイントを指し示す必要があります。`init_model`を指定しない場合でもエラーは発生しませんが、モデルは事前学習されません。


```bash
python train.py experiment=spice_cartesian_pretrain_for_bmam
python train.py experiment=spice_cartesian_bmam init_model=???
```
##### ねじり調整サンプリング

```bash
python train.py experiment=spice_torsion
```
## 評価
訓練済みモデルを評価するには、`eval.py`を使用します。報告された結果では`max_n_refs`を512に設定しています。



```bash
python eval.py \
--test_mols data/spice_test.txt \
--true_confs data/spice_test_conformers \
--save_path results \
--checkpoint_path path/to/checkpoint.pt \
--max_n_refs 512
```
分散方式での評価も可能です。`eval_distributed.sh` をご覧ください。


## 📚 引用

このコードが研究やプロジェクトで役立った場合は、ぜひ私たちの研究論文を引用してください：


```bibtex
@article{adjoint_sampling,
  title={{A}djoint {S}ampling: Highly Scalable Diffusion Samplers via {A}djoint {M}atching},
  author={Havens, Aaron and Miller, Benjamin Kurt and Yan, Bing and Domingo-Enrich, Carles and Sriram, Anuroop and Wood, Brandon and Levine, Daniel and Hu, Bin and Amos, Brandon and Karrer, Brian and Fu, Xiang and Liu, Guan-Horng and Chen, Ricky T. Q.},
  journal={International Conference on Machine Learning},
  year={2025}
}
```
## ライセンス
このリポジトリは
[CC BY-NC 4.0 ライセンス](https://creativecommons.org/licenses/by-nc/4.0/)の下でライセンスされています。

### お知らせ
Adjoint Samplingの大部分はCC-BY-NCの下でライセンスされていますが、プロジェクトの一部は別のライセンス条件で提供されています：[DEM](https://github.com/jarridrb/DEM)、[EGNN](https://github.com/vgsatorras/egnn)、[torsional-diffusion](https://github.com/gcorso/torsional-diffusion)、[fairchem](https://github.com/FAIR-Chem/fairchem)はMITライセンスの下でライセンスされています。[SPICE](https://github.com/openmm/spice-dataset)および[GEOM](https://github.com/learningmatter-mit/geom)はCC0ライセンスの下でライセンスされています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---