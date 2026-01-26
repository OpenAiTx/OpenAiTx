## PSICHIC: 配列データからタンパク質-リガンド相互作用フィンガープリントを学習する物理化学的グラフニューラルネットワーク [[Nature Machine Intelligence](https://www.nature.com/articles/s42256-024-00847-1)]

<img src="https://raw.githubusercontent.com/huankoh/PSICHIC/main/image/PSICHIC.jpg" width="500"/>

## PSICHIC ウェブサーバー <a href="http://www.psichicserver.com" target="_blank"><img src="https://raw.githubusercontent.com/huankoh/PSICHIC/main/image/crystal_ball.png" alt="PSICHIC Webserver" width="30"/></a>

朗報❗ PSICHICウェブサーバー（ベータ版）が利用可能になりました！ 🚀 タンパク質-リガンド相互作用解析の未来を [www.psichicserver.com](https://www.psichicserver.com/) で体験してください。

_探索を始めましょう。あなたの次の発見が_ 🌐🔬 _すぐそこにあります！_

<sub>注：このサーバーは論文の公式サーバーではありません。公式バージョンは以下のColabおよびローカル展開設定を参照してください。</sub>

## PSICHIC バーチャルスクリーニングプラットフォーム <a href="https://colab.research.google.com/github/huankoh/PSICHIC/blob/main/PSICHIC.ipynb" target="_parent"><img src="https://colab.research.google.com/assets/colab-badge.svg" alt="Open In Colab"/></a>

- **配列データのみ**：必要なのはタンパク質配列＋リガンドのSMILESペアだけです。
- **高速スクリーニング**：最大10万化合物を1時間で処理。
- **詳細解析**：PSICHIC搭載のファーマコフォアおよび標的変異解析で分子の洞察を発見。

**アップデート:** 選択性サブフォルダにJupyterノートブックを追加し、PSICHICによる選択性プロファイリングの使い方を示しています。

## PSICHIC ローカル展開の環境設定
<details>
<summary>PSICHICローカル開発環境の内容を表示/非表示</summary>

現在、PSICHICはMacOS（OSX）、Linux、Windowsでの使用が検証されています。conda経由のインストール、あるいはより高速なmambaパッケージ・環境マネージャーの使用を推奨します。mambaはコマンド ``conda install mamba -n base -c conda-forge`` でインストール可能です。condaまたはmambaを使ったセットアップ方法については、以下の該当コード行を参照してください。


```
## OSX 
conda env create -f environment_osx.yml  # if mamba: mamba env create -f environment_osx.yml
## LINUX or Windows GPU
conda env create -f environment_gpu.yml # if mamba: mamba env create -f environment_gpu.yml
conda activate psichic_fp
pip install torch_scatter torch_sparse torch_cluster torch_spline_conv -f https://data.pyg.org/whl/torch-2.1.0+cu118.html
## LINUX or Windows CPU
conda env create -f environment_cpu.yml  # if mamba: mamba env create -f environment_cpu.yml
conda activate psichic_fp
pip install torch_scatter torch_sparse torch_cluster torch_spline_conv -f https://data.pyg.org/whl/torch-2.1.0+cpu.html
```

あるいは、環境設定に役立つコマンドライン（Linux上でPython 3.8でテスト済み）。 
```
conda create --name psichic_fp python=3.8
conda install pytorch==2.0.0 torchvision==0.15.0 torchaudio==2.0.0 pytorch-cuda=11.7 -c pytorch -c nvidia
conda install pyg -c pyg
conda install -c conda-forge rdkit==2022.09.5
pip install scipy biopython pandas biopandas timeout_decorator py3Dmol umap-learn plotly mplcursors lifelines reprint
pip install "fair-esm"
```

## 注釈付き配列データを用いたBYO-PSICHIC

データフォルダにtrain、valid、testのcsvファイルを作成してください（例はdatasetフォルダを参照）。データフォルダには少なくともtrain.csvとtest.csvファイルが含まれている必要があります。注釈付きラベルに応じて、連続値ラベル（例：結合親和性）の場合は ``--regression_task True``、二値クラスラベル（例：相互作用の有無）の場合は ``--classification_task True``、多クラスラベルの場合はクラス数Cを指定して ``--mclassification_task C``（例：当社のタンパク質-リガンド機能応答データセットを使用する場合は3）を使用してください。複数のラベルタイプを含むデータセットも可能であり、PSICHICを用いて複数のタンパク質-リガンド相互作用特性を予測することができます（以下のPSICHIC-MultiTaskを参照）。

```
python main.py --datafolder annotated_folder --result_path result/annotated_result --regression_task True 
```

例えば、PDBBind v2020ベンチマークを用いたベンチマークデータセットでのBYO-PSICHICの使用：
```
python main.py --datafolder dataset/pdb2020 --result_path result/PDB2020_BENCHMARK --regression_task True 
```
モデルおよびオプティマイザの設定は、PDBBind v2016を除くすべてのベンチマークデータセットで一貫しています。PDBBind v2016では、オプティマイザのトレーニングイテレーション数、betasおよびepsをそれぞれ30000、"(0.9,0.99)"、1e-5に変更したい場合、コマンドラインに ``--total_iters 30000 --betas "(0.9,0.99)" --eps 1e-5`` を追加してください。バイナリ分類タスクの場合は、``--regression_task True`` を ``--classification_task True`` に置き換えてください。タンパク質機能効果データセットの場合は、``--regression_task True`` を ``--mclassification_task 3`` に置き換えてください。config.jsonファイル内のモデルハイパーパラメータは自由に調整してください。興味深い結果があればお知らせください！


## データセット構造とBYOフォーマットガイドライン
論文で参照しているすべてのデータセットはGoogleドライブで入手可能です（[Dataset](https://drive.google.com/drive/folders/1ZRpnwXtllCP89hjhfDuPivBlarBIXnmu?usp=sharing)）。PSICHICのベンチマーク評価に使用したデータセットには、既定の分割設定に基づいて作成されたtrain、valid、testのCSVファイルがあります。Googleドライブリンクのデータセットセクションには、各データセットの目的を説明するREADME.mdが別途用意されています（これは論文の拡張データ表1に類似しています）。

BYO-PSICHICデータセット：BYO-PSICHICのトレーニングに興味がある場合、各ファイルは以下のような形式になっているはずです。検証用CSVファイルがなくても問題ありません。たとえば、結果を外部実験で適用する予定の場合です。

__結合親和性回帰__

| Protein | Ligand | regression_label | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 6.7 | 
| GGALVSVISAFQASV....  | O=C(C)Oc1ccccc1C(=O)O | 4.0 |
|...|...| ...|
| MIPSAYIGIEVLI... | CCO | 8.1 | 

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --regression_task True 
```

__二元相互作用の分類__

| タンパク質 | リガンド | 分類ラベル | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 1 | 
| GGALVSVISAFQASV.... | O=C(C)Oc1ccccc1C(=O)O | 0 |
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 1 | 

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --classification_task True
```

__機能的効果分類（三元分類）__

| タンパク質 | リガンド | multiclass_label | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | -1 |  # アンタゴニスト
| GGALVSVISAFQASV.... | O=C(C)Oc1ccccc1C(=O)O | 0 | # 非結合体
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 1 | # アゴニスト

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --mclassification_task 3
```

__マルチタスク PSICHIC__

| タンパク質 | リガンド | 回帰ラベル | 多クラスラベル | 
|:----------:|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 6.7 | -1 |  # アンタゴニスト
| GGALVSVISAFQASV....  | O=C(C)Oc1ccccc1C(=O)O | 4.0 | 0 | # 非結合体
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 8.1 | 1 | # アゴニスト

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --regression_task True --mclassification_task 3
```

**戦略的にデータセットを分割しますか？** データセットフォルダ内のJupyterノートブックでは、ランダム分割、未見のタンパク質分割、および未見のリガンドスキャフォールド分割をどのように行い、PSICHICや他の手法の汎用性を評価するかを示しています。これは、BYO-PSICHICがあなたの注釈付き配列データで機能するかどうかを評価するのに役立ちます。
 
## PSICHIC<sub>XL</sub>：大規模相互作用データセットにおけるマルチタスク予測トレーニング
PSICHIC<sub>XL</sub>は以前、事前学習済みマルチタスクPSICHICと呼ばれていました。PSICHIC<sub>A1R</sub>は以前、ファインチューニング済みマルチタスクPSICHICと呼ばれていました。PSICHIC<sub>XL</sub>は追加のトレーニングなしでそのまま使用できることを明確にするために名前を変更しました。ただし、PSICHIC<sub>XL</sub>は、特定のタンパク質ターゲットに特化したデータでファインチューニングすることで、仮想スクリーニングにおけるランキング能力を向上させる可能性があります。例えば、以下に示すA<sub>1</sub>R関連データを用いたPSICHIC<sub>A<sub>1</sub>R</sub>です。

### PSICHIC<sub>XL</sub>のトレーニング（プレプリントでの事前学習済みPSICHICとしても知られる）
```
python main.py --datafolder dataset/large_scale_interaction_dataset --result_path PSICHIC_MultiTask_Pretrain --lrate 1e-5 --sampling_col pretrain_sampling_weight --regression_task True --mclassification_task 3 --total_iters 300000 --evaluate_step 25000
```
### PSICHIC<sub>XL</sub>をPSICHIC<sub>A<sub>1</sub>R</sub>（別名：PreprintでのFine-tuned PSICHIC）にファインチューニング  
A<sub>1</sub>R関連タンパク質に対して、PSICHIC<sub>XL</sub>のアプリケーション層のみを1000回イテレーションでファインチューニングします。コマンドは以下の通りです：
```
python main.py --regression_task True --mclassification_task 3 --datafolder dataset/A1R_FineTune --result_path PSICHIC_A1R_FineTune --lrate 1e-5 --total_iters 1000 --finetune_modules "['reg_out','mcls_out']" --trained_model_path trained_weights/multitask_PSICHIC
```
広範な相互作用データセットでトレーニングされたPSICHICバージョンをPSICHIC<sub>XL</sub>に、A<sub>1</sub>Rデータに焦点を当てたサブセットをPSICHIC<sub>A<sub>1</sub>R</sub>に名称変更しました。以前は、PSICHIC<sub>XL</sub>とPSICHIC<sub>A<sub>1</sub>R</sub>はそれぞれ事前学習済みPSICHICとファインチューニング済みPSICHICとして知られていました。この変更は、PSICHIC<sub>XL</sub>の広範な適用性とPSICHIC<sub>A<sub>1</sub>R</sub>のA1Rに特化した強調をより正確に反映しています。

他のタンパク質の場合は、大規模相互作用データセットから関連のないタンパク質や非結合体を除外し、PSICHICを他の実験に適用できます。
</details>



## 参考文献

詳細については、当研究をご参照ください： 

```
PSICHIC: physicochemical graph neural network for learning protein-ligand interaction fingerprints from sequence data
Huan Yee Koh, Anh T.N. Nguyen, Shirui Pan, Lauren T. May, Geoffrey I. Webb
bioRxiv 2023.09.17.558145; doi: https://doi.org/10.1101/2023.09.17.558145
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-26

---