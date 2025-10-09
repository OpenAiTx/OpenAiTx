<div align="center">
<img src=assets/yume.png width="20%"/>
</div>

# Yume: インタラクティブな世界生成モデル

Yumeは、テキスト、画像、または動画の入力を通じて、インタラクティブでリアルかつ動的な世界を作り出すことを目指した長期プロジェクトです。


<div align="center">




[![project page](https://img.shields.io/badge/Project-Page-2ea44f)](https://stdstu12.github.io/YUME-Project/)&nbsp;
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2507.17744-b31b1b.svg)](https://arxiv.org/abs/2507.17744)&nbsp;
[![model](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Model-blue)](https://huggingface.co/stdstu123/Yume-I2V-540P)&nbsp;
[![YouTube](https://badges.aleen42.com/src/youtube.svg)](https://www.youtube.com/watch?v=51VII_iJ1EM)&nbsp;

</div>

- 動画DiTの蒸留レシピ。
- [FramePack-Like](https://github.com/lllyasviel/FramePack) トレーニングコード。
- DDP/FSDPサンプリング対応の長尺動画生成手法。



## 🔧 インストール
コードはPython 3.10.0、CUDA 12.1、A100上でテスト済みです。
```
./env_setup.sh fastvideo
pip install -r requirements.txt
```
コードを変更するたびに `pip install .` を実行する必要があります。あるいは、変更したファイルを直接仮想環境にコピーすることもできます。例えば、`wan/image2video.py` を変更し、仮想環境が `yume` の場合、次のようにファイルをコピーします：
`envs/yume/lib/python3.10/site-packages/wan/image2video.py`。

## 🚀 推論

### ODE
画像から動画生成には、入力画像ディレクトリを指定するために `--jpg_dir="./jpg"` を使用し、テキスト条件入力を提供するために `--caption_path="./caption.txt"` を使用します。ここで各行は、2秒間の動画出力を制御する生成インスタンスに対応します。
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample_jpg.sh 
```
また、`--test_data_dir="./val"`が例のデータの場所を指定する形で、`./val`のデータを使用して動画を生成することも検討しています。
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample.sh 
```
### SDE
TTSサンプリングを実行します。`args.sde`はSDEベースのサンプリングを使用するかどうかを制御します。
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample_tts.sh 
```
最適な結果を得るために、実際の距離、角速度（回転速度）、および視点回転速度を0.1から10の範囲内に保つことを推奨します。

主な調整ガイドライン：
1. カメラが静止している場合（·）、実際の距離の値を減らす
2. 人物が静止している場合、角速度と視点回転速度の両方の値を減らす

これらのパラメータ（実際の距離、角速度、視点回転速度）は生成結果に影響を与えることに注意してください。簡略化のために、これらのパラメータを完全に除去する方法も検討できます。



## 🎯 トレーニングと蒸留
モデルのトレーニングには、`args.MVDT`を使用してMVDTフレームワークを起動し、最低でも16台のA100 GPUが必要です。T5をCPUにロードすることでGPUメモリの節約が可能です。`args.Distil`を用いて敵対的蒸留を有効にします。

```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/finetune/finetune.sh
```

## 🧱 データセット準備
データセットのダウンロードについては https://github.com/Lixsp11/sekai-codebase を参照してください。処理済みデータの形式については `./test_video` を参照してください。
```
path_to_processed_dataset_folder/
├── Keys_None_Mouse_Down/ 
│   ├── video_id.mp4
│   ├── video_id.txt
├── Keys_None_Mouse_Up
│──  ...
└── Keys_S_Mouse_·
```
提供されたTXTファイルの内容は、カメラのモーションコントロールパラメータまたはアニメーションのキーフレームデータのいずれかを記録しており、以下のフィールド定義を持ちます：
```
Start Frame: 2 #Starting frame number (begins at frame 2 at origin video)

End Frame: 50 #Ending frame number

Duration: 49 frames #Total duration

Keys: W #Keyboard input

Mouse: ↓ #Mouse action
```
`scripts/finetune/finetune.sh` において、`args.root_dir` は `path_to_processed_dataset_folder` を表し、`args.root_dir` は Sekai データセットへのフルパスを表します。

## 📑 開発計画
- データセット処理
  - [ ] 処理済みデータセットの提供
- コード更新
  - [ ] fp8 サポート
  - [ ] より良い蒸留手法
- モデル更新
  - [ ] 量子化および蒸留モデル
  - [ ] 720p 解像度生成用モデル​

## 🤝 貢献
すべての貢献を歓迎します。

## 謝辞
以下のプロジェクトからコードを学び、再利用しました：
- [FastVideo](https://github.com/hao-ai-lab/FastVideo)
- [diffusers](https://github.com/huggingface/diffusers)
- [HunyuanVideo-I2V](https://github.com/Tencent-Hunyuan/HunyuanVideo-I2V)
- [Wan2.1](https://github.com/Wan-Video/Wan2.1)
- [Skywork-Reward-V2](https://github.com/SkyworkAI/Skywork-Reward-V2)
- [MDT](https://github.com/sail-sg/MDT)
- [AddSR](https://github.com/NJU-PCALab/AddSR)

## 引用
研究に Yume を使用する場合は、以下の論文を引用してください：



```bibtex
@article{mao2025yume,
  title={Yume: An Interactive World Generation Model},
  author={Mao, Xiaofeng and Lin, Shaoheng and Li, Zhen and Li, Chuanhao and Peng, Wenshuo and He, Tong and Pang, Jiangmiao and Chi, Mingmin and Qiao, Yu and Zhang, Kaipeng},
  journal={arXiv preprint arXiv:2507.17744},
  year={2025}
}

```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-09

---