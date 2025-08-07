# SongGen: テキストから歌への生成のための単一段階自己回帰型トランスフォーマー

🚀🚀🚀 **SongGen: テキストから歌への生成のための単一段階自己回帰型トランスフォーマー** の公式実装  
<p align="center" style="font-size: 1 em; margin-top: -1em">
<a href="https://scholar.google.com/citations?user=iELd-Q0AAAAJ">劉子涵</a>,  
<a href="https://mark12ding.github.io/">丁爽睿</a>,  
<a href="https://github.com/rookiexiong7/">張志雄</a>, 
<a href="https://lightdxy.github.io/">董曉怡</a>,  
<a href="https://panzhang0212.github.io/">張攀</a>,
<a href="https://yuhangzang.github.io/">臧宇航</a>,  
<a href="https://scholar.google.com/citations?user=sJkqsqkAAAAJ">曹宇航</a>, </br>  
<a href="http://dahua.site/">林大華</a>,  
<a href="https://myownskyw7.github.io/">王嘉琪</a> 
</p>

<p align="center" style="font-size: 5 em; margin-top: 0.5em">
<a href="https://arxiv.org/abs/2502.13128"><img src="https://img.shields.io/badge/arXiv-<color>"></a>
<a href="https://github.com/LiuZH-19/SongGen"><img src="https://img.shields.io/badge/Code-red"></a>
<a href="https://liuzh-19.github.io/SongGen/"><img src="https://img.shields.io/badge/Demo-20d67c"></a>
<a href="https://huggingface.co/collections/LiuZH-19/songgen-a-single-stage-auto-regressive-transformer-for-text-6867ec21169d808034f6d252">
    <img src="https://img.shields.io/badge/HF-Collection-yellow"></a>
</p>





## 📜 ニュース
🚀 [2025/7/4] 詳細な[トレーニングガイド](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/./training/README.md)と共にトレーニングコードを公開しました。

🚀 [2025/6/30] MusicCapsテストセットがテキストから歌への評価用に[Huggingface🤗](https://huggingface.co/datasets/LiuZH-19/MusicCaps_Test_Song)で利用可能になりました。

🚀 [2025/6/27] SongGen Interleaving (A-V) のチェックポイントを[Huggingface🤗](https://huggingface.co/LiuZH-19/SongGen_interleaving_A_V)で公開しました。

🎉 [2025/5/1] SongGenがICML 2025に採択されました！

🚀 [2025/3/18] SongGen Mixed_Pro のチェックポイントを[Huggingface🤗](https://huggingface.co/LiuZH-19/SongGen_mixed_pro)で公開しました。

🚀 [2025/2/19] [論文](https://arxiv.org/abs/2502.13128)と[デモページ](https://liuzh-19.github.io/SongGen/)を公開しました！

## 💡 ハイライト
- 🔥SongGenは、歌詞、説明文、オプションの参照ボイスを通じて多様な制御を可能にする、**単一段階**の自己回帰型トランスフォーマーによる**テキストから歌**への生成モデルを導入します。
- 🔥SongGenは、**混合モード**と**二重トラックモード**の両方をサポートし、多様な要件に対応します。実験により両モードの最適化に関する**貴重な知見**を提供します。
- 🔥**モデル重み**、**コード**、**注釈付きデータ**、および**前処理パイプライン**を公開することで、将来の歌生成研究のためのシンプルで効果的なベースラインの構築を目指します。
<!-- <img align="center" src="https://raw.githubusercontent.com/LiuZH-19/SongGen/master/assets/imgs/motivation1.jpg" style="  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 50%;" /> -->

## 👨‍💻 Todo
- [ ] 注釈付きデータと前処理パイプラインの公開
- [x] Musiccapsテストセットの公開
- [x] SongGenトレーニングコードの公開
- [x] SongGen (Interleaving A-V) チェックポイントの公開
- [x] SongGen Mixed_pro チェックポイントの公開
- [x] SongGen推論コードの公開
- [x] SongGenデモ

## 🛠️ 使い方

### 1. 環境と依存関係のインストール
```bash
git clone https://github.com/LiuZH-19/SongGen.git
cd SongGen
# We recommend using conda to create a new environment.
conda create -n songgen_env python=3.9.18 
conda activate songgen_env
# Install CUDA >= 11.8 and PyTorch, e.g.,
pip install torch==2.3.0 torchvision==0.18.0 torchaudio==2.3.0 --index-url https://download.pytorch.org/whl/cu118
pip install flash-attn==2.6.1 --no-build-isolation
```
SongGenを推論モードのみで使用するには、次のコマンドでインストールしてください：
```bash
pip install -e .
```
### 2. xcodecのダウンロード

X-Codecのチェックポイントを[🤗](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/
https://huggingface.co/ZhenYe234/xcodec/blob/main/xcodec_hubert_general_audio_v2.pth)からダウンロードし、以下のディレクトリに配置してください : SongGen/songgen/xcodec_wrapper/xcodec_infer/ckpts/general_more

```
xcodec_infer
    ├── ckpts
    │   └── general_more
    │       ├── config_hubert_general.yaml
    │       └── xcodec_hubert_general_audio_v2.pth

```

### 3. 推論を実行する

#### (1). ミックスドプロモード

```python
import torch
import os
from songgen import (
    VoiceBpeTokenizer,
    SongGenMixedForConditionalGeneration,
    SongGenProcessor
)
import soundfile as sf

ckpt_path = "LiuZH-19/SongGen_mixed_pro" # Path to the pretrained model
device = "cuda:0" if torch.cuda.is_available() else "cpu"
model = SongGenMixedForConditionalGeneration.from_pretrained(
    ckpt_path,
    attn_implementation='sdpa').to(device)
processor = SongGenProcessor(ckpt_path, device)

# Define input text and lyrics
lyrics = "..." # The lyrics text
text = "..." # The music description text
ref_voice_path = 'path/to/your/reference_audio.wav' # Path to reference audio, optional
separate= True # Whether to separate the vocal track from the reference voice audio

model_inputs = processor(text=text, lyrics=lyrics, ref_voice_path=ref_voice_path, separate=separate) 
generation = model.generate(**model_inputs,
                do_sample=True,
            )
audio_arr = generation.cpu().numpy().squeeze()
sf.write("songgen_out.wav", audio_arr, model.config.sampling_rate)
```



#### (2). Interleaving A-V  (Dual-track mode)
```python
import torch
import os
from songgen import (
    VoiceBpeTokenizer,
    SongGenDualTrackForConditionalGeneration,
    SongGenProcessor
)
import soundfile as sf

ckpt_path = "LiuZH-19/SongGen_interleaving_A_V" # Path to the pretrained model
device = "cuda:0" if torch.cuda.is_available() else "cpu"
model = SongGenDualTrackForConditionalGeneration.from_pretrained(
    ckpt_path,
    attn_implementation='sdpa').to(device)
processor = SongGenProcessor(ckpt_path, device)

# Define input text and lyrics
lyrics = "..." # The lyrics text
text = "..." # The music description text
ref_voice_path = 'path/to/your/reference_audio.wav' # Path to reference audio, optional
separate= True # Whether to separate the vocal track from the reference voice audio

model_inputs = processor(text=text, lyrics=lyrics, ref_voice_path=ref_voice_path, separate=True) 
generation = model.generate(**model_inputs,
                do_sample=True,
            )

acc_array = generation[0].cpu().numpy()
vocal_array = generation[1].cpu().numpy()
min_len =min(vocal_array.shape[0], acc_array.shape[0])
acc_array = acc_array[:min_len]
vocal_array = vocal_array[:min_len]
audio_arr = vocal_array + acc_array
sf.write("songgen_out.wav", audio_arr, model.config.sampling_rate)
```
### 4. トレーニング

[trainingフォルダ](./training)には、独自のSongGenモデルをトレーニングまたはファインチューニングするためのすべての情報が含まれています。ステップバイステップの手順については、[トレーニングガイド](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/./training/README.md)を参照してください。



## ❤️ 謝辞
このライブラリは多くのオープンソースの巨人たちの上に構築されています。これらのツールを提供してくださった方々に心より感謝いたします！

特に感謝を表したいのは：

- [Parler-tts](https://github.com/huggingface/parler-tts): 私たちが基盤としたコードベース。 
- [X-Codec](https://github.com/zhenye234/xcodec): 私たちの研究で使用されたオーディオコーデック。
- [lp-music-caps](https://github.com/seungheondoh/lp-music-caps): 音楽のキャプション生成を目的としたプロジェクト。 

これまでにいただいたすべての支援に深く感謝しています。

## ☎️ 制限と今後の課題

これは**テキストから歌への**生成に焦点を当てた**研究作業**です。現在のトレーニングデータセットの制約により、当モデルは現在英語の歌のみ、最大30秒の生成に限定されています。
しかし、**2k時間**のデータと**1.3B**パラメータのモデルでトレーニングされているにもかかわらず、私たちのアプローチは一貫性があり表現力豊かな歌を生成する上で強力な効果と有望な可能性を示しています。データとモデルサイズの両方を拡大することで、歌詞の整合性や音楽性がさらに向上すると考えています。
とはいえ、データセットの拡大は時間がかかり困難です。モデルの改善と機能拡張のための新しい方法を探求するために、協力や議論を歓迎します。
ご質問や潜在的な協力については、お気軽にお問い合わせください：Zihan Liu (liuzihan@pjlab.org.cn) と Jiaqi Wang (wangjiaqi@pjlab.org.cn)。

## ✒️ 引用
もし私たちの研究があなたの研究に役立った場合は、スター⭐と引用📝を検討してください。

```bibtex
@misc{liu2025songgen,
      title={SongGen: A Single Stage Auto-regressive Transformer for Text-to-Song Generation}, 
      author={Zihan Liu and Shuangrui Ding and Zhixiong Zhang and Xiaoyi Dong and Pan Zhang and Yuhang Zang and Yuhang Cao and Dahua Lin and Jiaqi Wang},
      year={2025},
      eprint={2502.13128},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2502.13128}, 
}

```







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---