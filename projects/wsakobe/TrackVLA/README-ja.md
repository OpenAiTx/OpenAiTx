<p align="center">
<h1 align="center"><strong>TrackVLA: 野外におけるエンボディッドビジュアルトラッキング</strong></h1>
  <p align="center">
    <!--   	<strong>CoRL 2025</strong><br> -->
    <a href='https://wsakobe.github.io/' target='_blank'>Shaoan Wang</a>&emsp;
	<a href='https://jzhzhang.github.io/' target='_blank'>Jiazhao Zhang</a>&emsp;
    Minghan Li&emsp;
    Jiahang Liu&emsp;
    Anqi Li&emsp; <br>
    Kui Wu&emsp;
    <a href='https://fangweizhong.xyz/' target='_blank'>Fangwei Zhong</a>&emsp;
    <a href='https://www.coe.pku.edu.cn/teaching/manufacturing/9993.html' target='_blank'>Junzhi Yu</a>&emsp;
	<a href='https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=zh-CN' target='_blank'>Zhizheng Zhang</a>&emsp;
  <a href='https://hughw19.github.io/' target='_blank'>He Wang</a>&emsp;
    <br>
    北京大学&emsp; 
    Galbot&emsp; <br>
    北京航空航天大学&emsp;
    北京師範大学&emsp;
    北京人工知能アカデミー&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![Project](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![Video](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 概要
<strong><em>TrackVLA</em></strong>は、170万サンプルのデータセットで学習された、同時に物体認識とビジュアルトラッキングが可能なビジョン・ランゲージ・アクションモデルです。多様で困難な環境において、堅牢な追跡、長期的な追跡、およびクロスドメインな汎化性能を示します。
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 ニュース

* [25/07/02]: EVT-Benchが公開されました。

## 💡 インストール
1. **conda環境の準備**

   まず、[conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/)をインストールしてください。condaのインストール後、新しい環境を作成します:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **Condaでhabitat-simをインストール**
   
   habitat-sim v0.3.1をインストールする必要があります。
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **habitat-labをソースからインストール**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **データセットの準備**

    Habitat Matterport 3D（HM3D）データセットを[こちら](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d)から、Matterport3D（MP3D）を[こちら](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset)からダウンロードしてください。

    その後、データセットを`data/scene_datasets`ディレクトリに移動します。データセットの構造は以下の通りです:
    ```
    data/
     └── scene_datasets/
        ├── hm3d/
        │ ├── train/
        │ │   └── ...
        │ ├── val/
        │ │   └── ...
        │ └── minival
        │     └── ...
        └── mp3d/
          ├── 1LXtFkjw3qL
          │   └── ...
          └── ...
    ```

    次に、以下のコードを実行してヒューマノイドアバター用のデータを取得します:
      ```
      python download_humanoid_data.py
      ```


## 🧪 評価
  以下のスクリプトを実行します:

    bash eval.sh

  結果は指定したSAVE_PATHに保存され、ログディレクトリとビデオディレクトリが含まれます。評価プロセス中に結果を監視するには、次を実行してください:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  評価を停止するには、以下を使用してください:

    bash kill_eval.sh


## 📝 TODOリスト
- [x] 2025年5月にarXiv論文を公開
- [x] EVT-Bench（Embodied Visual Tracking Benchmark）の公開
- [ ] 大規模Embodied Visual Trackingデータセットの公開
- [ ] TrackVLAのチェックポイントおよびコードの公開

## ✉️ お問い合わせ
ご質問がございましたら、wangshaoan@stu.pku.edu.cn までお気軽にご連絡ください。できるだけ早くご返信いたします。


## 🔗 引用
本研究が参考になりましたら、以下のように引用をご検討ください:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 ライセンス
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
本作品は <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">クリエイティブ・コモンズ 表示-非営利-継承 4.0 国際ライセンス</a> の下に提供されています。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---