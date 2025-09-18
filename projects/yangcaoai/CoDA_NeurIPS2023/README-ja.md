
## :book: CoDA: 協調型新規ボックス発見とクロスモーダル整合によるオープンボキャブラリー3D物体検出 (NeurIPS2023)
<p align="center">
  <small> 🔥CoDAにスター⭐を付けてシェアしてください。ありがとうございます🔥 </small>
</p>

> [[論文](https://arxiv.org/abs/2310.02960)] &emsp; [[プロジェクトページ](https://yangcaoai.github.io/publications/CoDA.html)] <br>
<!-- > [Yang Cao](https://yangcaoai.github.io/), Yihan Zeng, [Hang Xu](https://xuhangcn.github.io/), [Dan Xu](https://www.danxurgb.net) <br> -->
<!-- > 香港科技大学、Huawei Noah's Ark Lab -->
> [Yang Cao](https://yangcaoai.github.io/), Yihan Zeng, [Hang Xu](https://xuhangcn.github.io/), [Dan Xu](https://www.danxurgb.net) <br>
> 香港科技大学<br>
> Huawei Noah's Ark Lab

:triangular_flag_on_post: **アップデート**  

&#9745; 新作 **CoDAv2** がTPAMIに採択されました。こちらからご覧ください [here](https://arxiv.org/pdf/2406.00830v2)！

&#9745; 3Dガウシアン・スプラッティングを3D物体検出に初導入した研究、3DGS-DETを公開しました [here](https://arxiv.org/pdf/2410.01647)！

&#9745; オープンボキャブラリー認識に関する最新論文＆コードをこちらにまとめています [here](https://github.com/yangcaoai/Awesome-Open-Vocabulary-Perception)。

&#9745; すべてのコード、データ、事前学習モデルを公開しました！

&#9745; 学習とテスト用コードを公開しました。

&#9745; 事前学習モデルを公開しました。

&#9745; OV設定のSUN-RGBDデータセットを公開しました。  

&#9745; OV設定のScanNetデータセットを公開しました。

&#9745; 論文のLaTeXコードは https://scienhub.com/Yang/CoDA で入手可能です。

## フレームワーク  
<img src="https://raw.githubusercontent.com/yangcaoai/CoDA_NeurIPS2023/main/assets/ov3d_det.png">

## サンプル  
<img src="https://raw.githubusercontent.com/yangcaoai/CoDA_NeurIPS2023/main/assets/CoDA_sup_fig0_v3_cropped_compressed_v2.jpg">

## インストール
私たちのコードはPyTorch 1.8.1、torchvision==0.9.1、CUDA 10.1、およびPython 3.7をベースにしています。その他のバージョンでも動作する可能性があります。

以下のPython依存関係もインストールしてください：

```
matplotlib
opencv-python
plyfile
'trimesh>=2.35.39,<2.35.40'
'networkx>=2.2,<2.3'
scipy
```

`pointnet2` レイヤーをインストールするには、以下を実行してください

```
cd third_party/pointnet2 && python setup.py install
```

高速なトレーニングのために、gIOUのCython化された実装をインストールしてください。
```
conda install cython
cd utils && python cython_compile.py build_ext --inplace
```

## データセット準備

OV設定を実現するために、元の[ScanNet](https://github.com/facebookresearch/votenet/tree/main/scannet)および[SUN RGB-D](https://github.com/facebookresearch/votenet/tree/main/sunrgbd)を再編成し、より多くのカテゴリのアノテーションを採用しました。ここから直接、提供するOV設定データセットをダウンロードしてください：[OV SUN RGB-D](https://huggingface.co/datasets/YangCaoCS/Open-Vocabulary-SUN-RGBD)および[OV ScanNet](https://hkustconnect-my.sharepoint.com/:f:/g/personal/ycaobd_connect_ust_hk/EsqoPe7-VFxOlY0a-v1-vPwBSiEHoGRTgK5cLIhnjyXiEQ?e=jY7nKT)。

次に、ダウンロードした*.tarファイルに対して以下を実行してください：
```
bash data_preparation.sh
```

## 評価
事前学習済みモデルは[こちら](https://drive.google.com/file/d/1fTKX1ML5u8jJ249GwAYqdCZGs941907H/view?usp=drive_link)からダウンロードしてください。
次に以下を実行します:
```
bash test_release_models.sh
```

## トレーニング
```
bash scripts/coda_sunrgbd_stage1.sh
bash scripts/coda_sunrgbd_stage2.sh
```
## サンプルの実行
```
bash run_samples.sh
```

## :scroll: BibTeX
CoDAが役立った場合は、以下を引用してください：
```
@inproceedings{cao2023coda,
  title={CoDA: Collaborative Novel Box Discovery and Cross-modal Alignment for Open-vocabulary 3D Object Detection},
  author={Cao, Yang and Zeng, Yihan and Xu, Hang and Xu, Dan},
  booktitle={NeurIPS},
  year={2023}
}

@article{cao2024collaborative,
  title={Collaborative Novel Object Discovery and Box-Guided Cross-Modal Alignment for Open-Vocabulary 3D Object Detection},
  author={Cao, Yang and Zeng, Yihan and Xu, Hang and Xu, Dan},
  journal={IEEE Transactions on Pattern Analysis and Machine Intelligence (TPAMI)},
  year={2025}
}
```

## :e-mail: お問い合わせ

ご質問やコラボレーションのご依頼（研究目的または商用目的）がある場合は、`yangcao.cs@gmail.com` までメールをお送りください。

## :scroll: 謝辞
CoDAは[CLIP](https://github.com/openai/CLIP)および[3DETR](https://github.com/facebookresearch/3detr)に触発されています。これらの素晴らしいコードに感謝します。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-18

---