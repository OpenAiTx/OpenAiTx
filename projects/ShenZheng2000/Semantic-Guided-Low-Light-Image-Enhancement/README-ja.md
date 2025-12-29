# Semantic-Guided-Low-Light-Image-Enhancement
これは論文「**Semantic-Guided Zero-Shot Learning for Low-Light Image/Video Enhancement**」の公式Pytorch実装です。

# Updates
- 2021.11.27: モデルアーキテクチャの図をアップロードしました。
- 2021.11.10: 本研究は採択され、[WACV 2022](https://wacv2022.thecvf.com/home)で発表されます。
- 2021.10.8: mPAとmIOUスコアを計算する簡単な方法をこの[リポジトリ](https://github.com/ShenZheng2000/DarkCityScape_mIOU_mPA)で公開しました。
- 2021.10.6: GIF形式の低照度映像のサンプル強調動画を公開しました。
- 2021.10.5: 低照度映像のサンプルとその強調結果を以下で公開しています：[[Low-Light](https://www.youtube.com/watch?v=4Avy_xsczdU)] [[Enhanced](https://www.youtube.com/watch?v=rN6Tf1E-kE8)]
- 2021.10.5: 私の新しい[リポジトリ](https://github.com/ShenZheng2000/Awesome-Low-Light-Enhancement-with-Deep-Learning)には低照度強調手法のコレクションがあります。参考になれば幸いです。
- 2021.10.4: arxivリンクを http://arxiv.org/abs/2110.00970 にて公開しました。


# Abstract
Low-light images challenge both human perceptions and computer vision algorithms. It is crucial to make algorithms robust to enlighten low-light images for computational photography and computer vision applications such as real-time detection and segmentation tasks. This paper proposes a semantic-guided zero-shot low-light enhancement network which is trained in the absence of paired images, unpaired datasets, and segmentation annotation. Firstly, we design an efficient **enhancement factor extraction** network using depthwise separable convolution. Secondly, we propose a **recurrent image enhancement** network for progressively enhancing the low-light image. Finally, we introduce an **unsupervised semantic segmentation** network for preserving the semantic information. Extensive experiments on various benchmark datasets and a low-light video demonstrate that our model outperforms the previous state-of-the-art qualitatively and quantitatively. We further discuss the benefits of the proposed method for low-light detection and segmentation.
# モデルアーキテクチャ
以下のリンクをクリックすると、PDF形式のモデルアーキテクチャを見ることができます。

![Model Architecture](https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/main_architecture.pdf)

# サンプル結果
## 1. 低照度ビデオフレーム
左から右へ、上から下へ：Dark、Retinex [1]、KinD [2]、EnlightenGAN [3]、Zero-DCE [4]、Ours。

<p float="left">
<p align="middle">
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/F1.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/retinex_net.png" width="250" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/kind.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/enlighten_gan.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/zero_dce.png" width="250" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/F1Crop.png" width="250" />
</p>

## 2. 低照度画像（実世界）
左から右へ、上から下へ：Dark、PIE [5]、LIME [6]、Retinex [1]、MBLLEN [7]、KinD [2]、Zero-DCE [4]、Ours。

<p float="left">
<p align="middle">
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/Dark7.jpg" width="200" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/PIE7.jpg" width="200" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/LIME7.jpg" width="200" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/Retinex7.jpg" width="200" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/mbllen7.jpg" width="200" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/KinD7.jpg" width="200" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/ZeroDCE7.jpg" width="200" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/Ours7.jpg" width="200" />
</p>

# はじめに

## 1. 要件
* CUDA 10.0
* Python 3.6+

* Pytorch 1.0以上
* torchvision 0.4以上
* opencv-python
* numpy
* pillow
* scikit-image

## 2. データセットの準備
### テスト用データセット
- 公式のテスト画像を[BaiduYun](https://pan.baidu.com/s/1pbz0YlOmLqxnazeKrRRUQg)からパスワード `8itq` でダウンロードしました。
- 解凍したファイルを `data/test_data/` に移動してください。
- また、カスタムデータセットやご自身の暗所画像をこのフォルダに入れてテストすることも可能です。例：`data/test_data/yourDataset/`

### トレーニング用データセット
- 公式のトレーニング画像を[GoogleDrive](https://drive.google.com/file/d/1GAB3uGsmAyLgtDBDONbil08vVu5wJcG3/view)からダウンロードしました。
- 解凍したファイルを `data/train_data/` に移動してください。

注意：BaiduYunアカウントをお持ちでない場合は、[Google Drive](https://drive.google.com/drive/folders/1RIQsP5ap5QU7LstHPknOffQZeqht_FCh)からトレーニングデータセットとテストデータセットの両方をダウンロードできます。

準備後、データフォルダは以下のようになっているはずです：
```
data/
├── test_data/
│   ├── lowCUT/
│   ├── BDD/
│   ├── Cityscapes/
│   ├── DICM/
│   ├── LIME/
│   ├── LOL/
│   ├── MEF/
│   ├── NPE/
│   └── VV/
└── train_data/
    └── ...
```

## 3. 最初からのトレーニング
モデルをトレーニングするには：
```
python train.py \
  --lowlight_images_path path/to/train_images \
  --snapshots_folder path/to/save_weights
```

例（最初から学習）:
```
python train.py \
  --lowlight_images_path data/train_data \
  --snapshots_folder weight/
```

## 4. トレーニングの再開

チェックポイントからトレーニングを再開するには：
```
python train.py \
  --lowlight_images_path path/to/train_images \
  --snapshots_folder path/to/save_weights \
  --load_pretrain True \
  --pretrain_dir path/to/checkpoint.pth
```

例（Epoch99.pthから再開）：
```
python train.py \
  --lowlight_images_path data/train_data \
  --snapshots_folder weight/ \
  --load_pretrain True \
  --pretrain_dir weight/Epoch99.pth
```
 
## 5. テスト
**注意: モデル推論エラーを避けるため、`data`フォルダ内のすべてのreadme.txtを削除してください。**

モデルをテストするには:

```
python test.py \
  --input_dir path/to/your_input_images \
  --weight_dir path/to/pretrained_model.pth \
  --test_dir path/to/output_folder 
```
例：

```
python test.py \
  --input_dir data/test_data/lowCUT \
  --weight_dir weight/Epoch99.pth \
  --test_dir test_output
```

## 6. ビデオでのテスト
ビデオ（MP4形式）でのモデルテストは、ターミナルで次のコマンドを実行してください：
```
bash test_video.sh
```
`demo/make_video.py`にはビデオテスト用の5つのハイパーパラメータがあります。以下の説明を参照してください。  
- `video_path`: 低照度ビデオのパス  
- `image_lowlight_folder`: 低照度画像のパス  
- `image_folder`: 強調画像のパス  
- `save_path`: 強調ビデオのパス  
- `choice`: ビデオから画像への変換、または画像からビデオへの変換の選択  


# ハイパーパラメータ
| 名前                  | 型    | デフォルト          | 
|-----------------------|-------|--------------------|
| lowlight_images_path   | str   | data/train_data/    |         
| lr                    | float | 1e-3               |          
| weight_decay          | float | 1e-3               |            
| grad_clip_norm        | float | 0.1                |            
| num_epochs            | int   | 100                |          
| train_batch_size      | int   | 6                  |          
| val_batch_size        | int   | 8                  |           
| num_workers           | int   | 4                  |         
| display_iter          | int   | 10                 |         
| snapshot_iter         | int   | 10                 |        
| scale_factor          | int   | 1                  |         
| snapshots_folder      | str   | weight/            |         
| load_pretrain         | bool  | False              |       
| pretrain_dir          | str   | weight/Epoch99.pth |         
| num_of_SegClass       | int   | 21                 |        
| conv_type             | str   | dsc                |        
| patch_size            | int   | 4                  |        
| exp_level             | float | 0.6                |        


# TODO リスト
- [x] 重要なハイパーパラメータのリスト化  
- [x] モデル入力サイズの問題に対処  
- [x] 事前学習済み重みのアップロード  
- [x] training と testing の argparse を option.py に書き換え  
- [x] training をクラスとして書き換え  
- [x] testing をクラスとして書き換え  
- [x] テストデータセットのアップロード

- [x] Arxivリンクをアップロード  
- [x] ビデオでのテスト  
- [x] BibTeXをアップロード  
- [x] Readmeファイルを修正  
- [x] モデルアーキテクチャをアップロード  
- [ ] オンラインデモを提供  
# その他  
質問がある場合は zhengsh@kean.edu までご連絡ください。このリポジトリは [Zero-DCE](https://github.com/Li-Chongyi/Zero-DCE) に大きく基づいています。コードの共有に感謝します！  

# 引用文献  
このリポジトリが役に立った場合は、以下の論文を引用してください。
```
@inproceedings{zheng2022semantic,
  title={Semantic-guided zero-shot learning for low-light image/video enhancement},
  author={Zheng, Shen and Gupta, Gaurav},
  booktitle={Proceedings of the IEEE/CVF Winter Conference on Applications of Computer Vision},
  pages={581--590},
  year={2022}
}
```


# 参考文献
[1] Wei, Chen, et al. 「低照度強調のための深層Retinex分解」 arXivプレプリント arXiv:1808.04560 (2018).

[2] Zhang, Yonghua, Jiawan Zhang, and Xiaojie Guo. 「闇を灯す：実用的な低照度画像強調」 第27回ACM国際マルチメディア会議論文集. 2019.

[3] Jiang, Yifan, et al. 「Enlightengan：ペアなし教師あり深層光強調」 IEEE Transactions on Image Processing 30 (2021): 2340-2349.

[4] Guo, Chunle, et al. 「低照度画像強調のためのゼロリファレンス深層曲線推定」 IEEE/CVFコンピュータビジョン・パターン認識会議論文集. 2020.

[5] Fu, Xueyang, et al. 「照明と反射率の同時推定を伴う画像強調の確率的手法」 IEEE Transactions on Image Processing 24.12 (2015): 4965-4977.

[6] Guo, Xiaojie, Yu Li, and Haibin Ling. 「LIME：照明マップ推定による低照度画像強調」 IEEE Transactions on Image Processing 26.2 (2016): 982-993.

[7] Lv, Feifan, et al. 「MBLLEN：CNNを用いた低照度画像／動画強調」 BMVC. 2018.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-29

---