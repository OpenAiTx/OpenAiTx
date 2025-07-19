<translate-content># :bulb: LaMP: 動作生成、検索、キャプショニングのための言語・動作事前学習 (ICLR 2025)
### [[プロジェクトページ]](https://aigc3d.github.io/LaMP/) [[論文]](https://arxiv.org/abs/2410.07093)
![teaser_image](https://github.com/gentlefress/LaMP/blob/main/teaser.png)

もし本コードや論文が役立った場合は、リポジトリのスターと引用をお願いいたします：</translate-content>
```
@article{li2024lamp,
  title={LaMP: Language-Motion Pretraining for Motion Generation, Retrieval, and Captioning},
  author={Li, Zhe and Yuan, Weihao and He, Yisheng and Qiu, Lingteng and Zhu, Shenhao and Gu, Xiaodong and Shen, Weichao and Dong, Yuan and Dong, Zilong and Yang, Laurence T},
  journal={arXiv preprint arXiv:2410.07093},
  year={2024}
}
```
## :postbox: ニュース
📢 **2025-01-22** --- 🔥🔥🔥 おめでとうございます！LaMPがICLR 2025に採択されました。

📢 **2025-4-28** --- LaMPのコードとモデルをリリース。トレーニング/評価/生成スクリプトを含みます。

📢 **2025-4-28** --- ウェブページとGitプロジェクトを初期化しました。  


## :1st_place_medal: 準備を整えましょう

<details>
  
### 1. Conda環境</details>

```
conda env create -f environment.yml
conda activate lamp
pip install git+https://github.com/openai/CLIP.git
```
<translate-content>私たちはPython 3.9.12およびPyTorch 1.12.1でコードをテストしています

### 2. モデルと依存関係

#### 事前学習済みモデルのダウンロード</translate-content>
```
bash prepare/download_models.sh
```
#### 評価モデルとグローブのダウンロード  
評価目的のみ。

```
bash prepare/download_evaluator.sh
bash prepare/download_glove.sh
```
#### （オプション）手動ダウンロード  
##### VQVAE 事前学習済み重み：  
https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/vq.tar  
##### LaMP 事前学習済み重み：  
HumanML3D: https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/h3d-qformer.tar  

KIT-ML: https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/kit-qformer.tar  
##### LaMP-T2M 事前学習済み重み：  
https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/t2m.tar  
##### M2T-LaMP 事前学習済み重み：  
https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/m2t.pth  
### 3. データ取得  

ここで2つの選択肢があります：  
* **データ取得をスキップ**、自分の説明文を使ってモーションを生成したい場合。  
* **完全なデータを取得**、モデルの*再訓練*や*評価*を行いたい場合。  

**(a). 完全なデータ（テキスト＋モーション）**  

**HumanML3D** - [HumanML3D](https://github.com/EricGuo5513/HumanML3D.git) の指示に従い、結果のデータセットを当リポジトリにコピーしてください：


```
cp -r ../HumanML3D/HumanML3D ./dataset/HumanML3D
```
**KIT**-[HumanML3D](https://github.com/EricGuo5513/HumanML3D.git)からダウンロードし、結果を`./dataset/KIT-ML`に配置してください。

#### 

</details>

## :fire: デモ
<details>

### (a) 単一のプロンプトから生成</details>
```
python gen_t2m.py --gpu_id 1 --ext exp1 --text_prompt "A person is running on a treadmill."
```
### (b) プロンプトファイルから生成する  
プロンプトファイルの例は `./assets/text_prompt.txt` にあります。各行は `<テキストの説明>#<モーションの長さ>` の形式に従ってください。モーションの長さはポーズ数を示し、整数でなければならず、4の倍数に丸められます。本研究ではモーションは20fpsです。  

もし `<テキストの説明>#NA` と書くと、モデルが長さを決定します。一度でも **1つ** のNAがあれば、他のすべても自動的に **NA** になります。

```
python gen_t2m.py --gpu_id 1 --ext exp2 --text_path ./assets/text_prompt.txt
```
興味があるかもしれないいくつかの追加パラメータ：
* `--repeat_times`：生成のための複製回数、デフォルトは `1`。
* `--motion_length`：生成するポーズの数を指定、(a)の場合のみ適用。

出力ファイルはフォルダ `./generation/<ext>/` に保存されます。内容は
* `numpyファイル`：形状が (nframe, 22, 3) の生成された動作、サブフォルダ `./joints` 配下。
* `動画ファイル`：スティックフィギュアアニメーションのmp4形式、サブフォルダ `./animation` 配下。
* `bvhファイル`：生成された動作のbvhファイル、サブフォルダ `./animation` 配下。

また、生成された動作に素朴なフットIKを適用しています。接尾辞が `_ik` のファイルをご覧ください。時にはうまく機能しますが、時には失敗します。
  
</details>

## :basketball_man: ビジュアライゼーション
<details>

すべてのアニメーションは手動でBlenderでレンダリングしています。[mixamo](https://www.mixamo.com/#/) のキャラクターを使用しています。スケルトン付きのTポーズでキャラクターをダウンロードする必要があります。

### リターゲティング
リターゲティングに関しては、rokokoでは足の誤差が大きくなることが多いです。一方、[keemap.rig.transfer](https://github.com/nkeeline/Keemap-Blender-Rig-ReTargeting-Addon/releases) はより正確なリターゲティングを示します。こちらの[tutorial](https://www.youtube.com/watch?v=EG-VCMkVpxg)をご覧ください。

以下の手順に従ってください：
* githubからkeemap.rig.transferをダウンロードし、Blenderにインストールします。
* Blenderにモーションファイル（.bvh）とキャラクターファイル（.fbx）を両方インポートします。
* ソースとターゲットのスケルトンを `Shift + 選択` します。（レストポジションである必要はありません）
* `ポーズモード`に切り替え、ビューウィンドウ右上の`KeeMapRig`ツールを展開します。
* `bone mapping file` には `./assets/mapping.json`（動作しない場合は `mapping6.json`）を指定し、`Read In Bone Mapping File`をクリックします。このファイルは手作業で作成したもので、mixamoのほとんどのキャラクターで機能します。
* （オプション）骨マッピングを手動で入力し、回転を調整して自分のキャラクターに合わせることもできます。`Save Bone Mapping File`でマッピング設定をローカルファイルに保存可能です。ファイルパスはマッピングファイルのパスで指定します。
* `Number of Samples`、`Source Rig`、`Destination Rig Name`を調整します。
* `Transfer Animation from Source Destination`をクリックし、数秒待ちます。

他のリターゲティングツールは試していません。より有用なものを見つけたらコメントを歓迎します。

</details>

## :flashlight: 自分のモデルを訓練する
<details>


**注意**：マスクド/残差トランスフォーマーを訓練する前に、必ずVQ-VAEを訓練してください。後者2つは同時に訓練可能です。

### VQ-VAEの訓練
スクリプトを実行するために評価モデルをダウンロードする必要がある場合があります。


```
python train_vq.py --name vq_name --gpu_id 1 --dataset_name t2m --batch_size 256  --max_epoch 50 --quantize_dropout_prob 0.2 --gamma 0.05
```
### LaMPの訓練

```
python train_lamp.py --name lamp_name --gpu_id 2 --dataset_name t2m --batch_size 64 --vq_name vq_name
```
### マスクドトランスフォーマーの訓練</translate-content>

```
python train_t2m_transformer.py --name mtrans_name --gpu_id 2 --dataset_name t2m --batch_size 64 --vq_name vq_name
```
<translate-content>
* `--dataset_name`: モーションデータセット、HumanML3Dには`t2m`、KIT-MLには`kit`を使用します。  
* `--name`: モデルの名前を指定します。これにより、モデルスペースが`./checkpoints/<dataset_name>/<name>`に作成されます。
* `--gpu_id`: GPUのID。
* `--batch_size`: vqトレーニングには`512`を使用します。マスクド／残差トランスフォーマーにはHumanML3Dで`64`、KIT-MLで`16`を使用します。
* `--quantize_drop_prob`: 量子化ドロップアウト率、`0.2`を使用します。
* `--vq_name`: マスクド／残差トランスフォーマーをトレーニングする際に、トークン化のためのvqモデルの名前を指定する必要があります。
* `--cond_drop_prob`: 条件ドロップ率、分類器なしガイダンス用。`0.2`を使用します。

すべての事前学習済みモデルと中間結果は、`./checkpoints/<dataset_name>/<name>`に保存されます。

### M2Tのトレーニング</translate-content>
```
python train_m2t.py --exp-name M2T --num-layers 12 --batch-size 80 --embed-dim-gpt 1024 --nb-code 512 --n-head-gpt 16 --block-size 51 --ff-rate 4 --drop-out-rate 0.1 --resume-pth your_own_vqvae --vq-name VQVAE --out-dir ./output --total-iter 150000 --lr-scheduler 75000 --lr 0.00005 --dataname kit --down-t 2 --depth 3 --quantizer ema_reset --eval-iter 10000 --pkeep 0.5 --dilation-growth-rate 3 --vq-act relu
```
</details>

## :artist: 評価
<details>

### VQ-VAE再構築の評価：
HumanML3D:</details>

```
python eval_t2m_vq.py --gpu_id 0 --name  --dataset_name t2m

```
KIT-ML:
```
python eval_t2m_vq.py --gpu_id 0 --name  --dataset_name kit
```
### LaMP-T2Mの評価：
HumanML3D：

```
python eval_t2m_trans_res.py --res_name mtrans_name --dataset_name t2m --name eval_name --gpu_id 1 --cond_scale 4 --time_steps 10 --ext evaluation
```
KIT-ML:
```
python eval_t2m_trans_res.py --res_name mtrans_name_k --dataset_name kit --name eval_name_k --gpu_id 0 --cond_scale 2 --time_steps 10 --ext evaluation
```
<translate-content>
* `--res_name`: `residual transformer`のモデル名。  
* `--name`: `masked transformer`のモデル名。  
* `--cond_scale`: クラス分類なしガイダンスのスケール。
* `--time_steps`: 推論の反復回数。
* `--ext`: 評価結果を保存するファイル名。
* `--which_epoch`: `masked transformer`のチェックポイント名。

最終評価結果は`./checkpoints/<dataset_name>/<name>/eval/<ext>.log`に保存されます。

### LaMP-M2Tの評価:</translate-content>
```
python M2T_eval.py --exp-name Test_M2T --num-layers 9 --batch-size 1 --embed-dim-gpt 1024 --nb-code 512 --n-head-gpt 16 --block-size 51 --ff-rate 4 --drop-out-rate 0.1 --resume-pth your_own_vqvae --vq-name VQVAE --out-dir ./output --total-iter 150000 --lr-scheduler 75000 --lr 0.0001 --dataname t2m --down-t 2 --depth 3 --quantizer ema_reset --eval-iter 10000 --pkeep 0.5 --dilation-growth-rate 3 --vq-act relu --resume-trans your_own_m2t
```
LaMP-BertScore メトリックは、まず LaMP-M2T を使って合成された動作のテキスト記述を生成し、  
その後、生成された記述と正解テキスト間の BertScore を計算することで算出されます。  

</details>  

## 謝辞  

我々のコードの基盤となっている以下のオープンソース作品に心より感謝いたします：  

[T2M-GPT](https://github.com/Mael-zys/T2M-GPT) および [MoMask](https://github.com/EricGuo5513/momask-codes/tree/main)。  

## ライセンス  
本コードは [MIT LICENSE](https://github.com/gentlefress/LaMP/blob/main/LICENSE.md) のもとで配布されています。  

本コードは SMPL、SMPL-X、PyTorch3D などの他のライブラリに依存しており、  
それぞれのライセンスに従う必要があるデータセットも使用しています。  

### その他  
ご質問は keycharon0122@gmail.com までご連絡ください。  

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---