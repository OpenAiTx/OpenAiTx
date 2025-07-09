<div align="center">
<h2>ディテール豊かで時間的一貫性のあるビデオ超解像のためのワンステップ拡散</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>香港理工大学, <sup>2</sup>OPPO研究所
</div>

<div>
    <h4 align="center">
        <a href="https://yjsunnn.github.io/DLoRAL-project/" target='_blank'>
        <img src="https://img.shields.io/badge/💡-Project%20Page-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Demo%20Video-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/2--Min%20Explainer-brightgreen?logo=YouTube&logoColor=white">
        </a>
        </a>
        <a href="https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion" target="_blank">
        <img src="https://img.shields.io/badge/GitHub-Awesome--VSR--Diffusion-181717.svg?logo=github&logoColor=white">
        </a>
<!--         <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/1--Min%20Algorithm%20Explainer-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a> -->
        <a href="https://github.com/yjsunnn/DLoRAL" target='_blank' style="text-decoration: none;"><img src="https://visitor-badge.laobi.icu/badge?page_id=yjsunnn/DLoRAL"></a>
    </h4>
</div>

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Visual Results">

</p>
## ⏰ アップデート

- **2025.07.08**: 推論コードおよび事前学習済み重みを公開しました。
- **2025.06.24**: プロジェクトページを公開しました。2分間の簡単な解説動画、より多くのビジュアル結果や関連研究を掲載しています。
- **2025.06.17**: リポジトリを公開しました。

:star: DLoRALがあなたの動画やプロジェクトに役立った場合は、このリポジトリにスターを付けていただけると幸いです。ありがとうございます！ :hugs:

😊 関連する私たちの研究もご覧ください：

1. **OSEDiff (NIPS2024)** [論文](https://arxiv.org/abs/2406.08177) | [コード](https://github.com/cswry/OSEDiff/)  

   OPPO Find X8シリーズに適用されたリアルタイム画像超解像アルゴリズムです。

2. **PiSA-SR (CVPR2025)** [論文](https://arxiv.org/pdf/2412.03017) | [コード](https://github.com/csslc/PiSA-SR) 

   画像超解像におけるDual-LoRAパラダイムの先駆的な研究です。

3. **Awesome Diffusion Models for Video Super-Resolution** [リポジトリ](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   拡散モデルを用いた映像超解像（VSR）のためのリソースをまとめたキュレーションリストです。
## 👀 TODO
- [x] 推論コードの公開。
- [ ] 簡単にテストできるColabおよびHuggingface UI（近日公開！）。
- [ ] 学習コードの公開。
- [ ] 学習データの公開。


## 🌟 概要フレームワーク

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**学習**: 動的な二段階学習方式により、時間的コヒーレンスの最適化（コンシステンシーステージ）と高周波空間ディテールの改善（エンハンスメントステージ）を交互に行い、滑らかな損失補間で安定性を確保します。

**推論**: 推論時には、C-LoRAとD-LoRAの両方を凍結されたDiffusion UNetに統合し、低品質入力を高品質出力へワンステップで強化します。
## 🔧 依存関係とインストール

1. リポジトリをクローン
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. 依存パッケージをインストール
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. モデルをダウンロード 
#### 依存モデル
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) → **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base** に配置
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) → **/path/to/DLoRAL/preset_models/bert-base-uncased** に配置
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) → **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth** に配置
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) → **/path/to/DLoRAL/preset/models/DAPE.pth** に配置
* [Pretrained Weights](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) → **/path/to/DLoRAL/preset/models/checkpoints/model.pkl** に配置

各パスは自身の要件に応じて変更可能であり、コマンドラインやコードにも対応する変更を適用してください。
## 🖼️ クイック推論
実世界のビデオ超解像の場合：

```
python src/test_DLoRAL.py     \
--pretrained_model_path /path/to/stable-diffusion-2-1-base     \
--ram_ft_path /path/to/DAPE.pth     \
--ram_path '/path/to/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/path/to/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /path/to/model_checkpoint.pkl     \
--stages 1     \
-i /path/to/input_videos/     \
-o /path/to/results
```
### 引用
本コードがあなたの研究や業務に役立った場合は、ぜひ本論文を引用してください。
以下はBibTeX形式の参考文献です：

```
@misc{sun2025onestepdiffusiondetailrichtemporally,
      title={One-Step Diffusion for Detail-Rich and Temporally Consistent Video Super-Resolution}, 
      author={Yujing Sun and Lingchen Sun and Shuaizheng Liu and Rongyuan Wu and Zhengqiang Zhang and Lei Zhang},
      year={2025},
      eprint={2506.15591},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.15591}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---