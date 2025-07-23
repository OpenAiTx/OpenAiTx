
# OpenUni: 統一マルチモーダル理解と生成のためのシンプルなベースライン

![](https://raw.githubusercontent.com/wusize/OpenUni/main/figures/teaser.png)

> **[OpenUni: 統一マルチモーダル理解と生成のためのシンプルなベースライン](https://arxiv.org/abs/2505.23661)**
>
> Size Wu, Zhonghua Wu, Zerui Gong, Qingyi Tao, Sheng Jin, Qinyue Li, Wei Li, Chen Change Loy
>
> [![report](https://img.shields.io/badge/arXiv-2505.23661-b31b1b.svg)](docs/report.pdf)
> [![Bibtex](https://img.shields.io/badge/Cite-BibTeX-blue)](https://github.com/wusize/OpenUni?tab=readme-ov-file#-citation)

## はじめに

これは構築中のリポジトリで、OpenUniという名前の、マルチモーダル理解と生成を統一するための[MetaQuery](https://xichenpan.com/metaquery)のオープンソース版です。最小限のアーキテクチャ選択により、OpenUniが以下を実現できることを示します：1) 高品質で指示に沿った画像の生成、2) GenEval、DPG-Bench、WISEなどの標準ベンチマークでの卓越した性能、1.1Bおよび3.1Bの有効パラメータのみで。現在、3つのモデルバリアントを提供しています：OpenUni-B-512、OpenUni-L-512、OpenUni-L-1024。事前学習およびファインチューニングのチェックポイントも提供しています。


## 🔥 モデルズー

| モデル名 | 画像サイズ | MLMMモデル | 拡散モデル | 事前学習済み | ファインチューニング済み |
|------------|------------|------------|-----------------|-------------|------------|
| OpenUni-B-512 | 512×512 | [InternVL3-1B](https://huggingface.co/OpenGVLab/InternVL3-1B) | [SANA-0.6B-512px](https://huggingface.co/Efficient-Large-Model/Sana_600M_512px_diffusers) | [リンク](https://huggingface.co/wusize/openuni/blob/main/openuni_b_internvl3_1b_sana_0_6b_512_hf_text2image23m.pth) | [リンク](https://huggingface.co/wusize/openuni/blob/main/openuni_b_internvl3_1b_sana_0_6b_512_hf_blip3o60k.pth) |
| OpenUni-L-512 | 512×512 | [InternVL3-2B](https://huggingface.co/OpenGVLab/InternVL3-2B) | [SANA-1.6B-512px](https://huggingface.co/Efficient-Large-Model/Sana_1600M_512px_diffusers) | [リンク](https://huggingface.co/wusize/openuni/blob/main/openuni_l_internvl3_2b_sana_1_6b_512_hf_text2image23m.pth) | [リンク](https://huggingface.co/wusize/openuni/blob/main/openuni_l_internvl3_2b_sana_1_6b_512_hf_blip3o60k.pth) |
| OpenUni-L-1024 | 1024×1024 | [InternVL3-2B](https://huggingface.co/OpenGVLab/InternVL3-2B) | [SANA1.5-1.6B-1024px](https://huggingface.co/Efficient-Large-Model/SANA1.5_1.6B_1024px_diffusers) | [リンク](https://huggingface.co/wusize/openuni/blob/main/openuni_l_internvl3_2b_sana_1_6b_512_hf_text2image23m.pth) | [リンク](https://huggingface.co/wusize/openuni/blob/main/openuni_l_internvl3_2b_sana_1_6b_1024_hf_blip3o60k.pth) |





## 環境

```
mmengine
xtuner
transformers
torch
flash_attn
```
## テキストから画像へ

リリースされたモデルの重みは🤗[wusize/openuni](https://huggingface.co/wusize/openuni)からダウンロードしてください。  
チェックポイントのダウンロードには以下のコマンドの使用を推奨します。


```bash
# pip install -U "huggingface_hub[cli]"
huggingface-cli download wusize/openuni  --local-dir checkpoints --repo-type model
```

```text
OpenUni/
├── checkpoints
    ├── openuni_b_internvl3_1b_sana_0_6b_512_hf_blip3o60k.pth
    ├── openuni_b_internvl3_1b_sana_0_6b_512_hf_text2image23m.pth
    ├── openuni_l_internvl3_2b_sana_1_6b_1024_hf_blip3o60k.pth
    ├── openuni_l_internvl3_2b_sana_1_6b_1024_hf_text2image23m.pth
    ├── openuni_l_internvl3_2b_sana_1_6b_512_hf_blip3o60k.pth
    ├── openuni_l_internvl3_2b_sana_1_6b_512_hf_text2image23m.pth
```
### 推論
[docs/INFERENCE.md](https://raw.githubusercontent.com/wusize/OpenUni/main/docs/INFERENCE.md) を参照してください。

### 評価
[docs/EVALUATION.md](https://raw.githubusercontent.com/wusize/OpenUni/main/docs/EVALUATION.md) を参照してください。

### トレーニング

データセットの準備については [docs/DATASETS.md](https://raw.githubusercontent.com/wusize/OpenUni/main/docs/DATASETS.md) と [docs/datasets](docs/datasets) を参照してください。データセットを用意した後、
[docs/TRAIN.md](https://raw.githubusercontent.com/wusize/OpenUni/main/docs/TRAIN.md) の指示に従い、トレーニングスクリプトを起動してください。

## 📚 引用

OpenUni が研究やアプリケーションに役立った場合は、以下の BibTeX を用いて論文を引用してください：


```bibtex
@article{wu2025openuni,
      title={OpenUni: A Simple Baseline for Unified Multimodal Understanding and Generation}, 
      author={Size Wu and Zhonghua Wu and Zerui Gong and Qingyi Tao and Sheng Jin and Qinyue Li and Wei Li and Chen Change Loy},
      year={2025},
      eprint={2505.23661},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.23661}, 
}
```
## 📜 ライセンス
このプロジェクトは [NTU S-Lab License 1.0](LICENSE) のもとでライセンスされています。


## 🙏 謝辞
本プロジェクトは以下の先駆的な研究を基に構築されています：
- [SANA](https://github.com/NVlabs/Sana): 効率性と高い性能を考慮し、拡散モジュールとしてSANAを使用しています。
- [InternVL3](https://github.com/OpenGVLab/InternVL): 最新のInternVL3をベースのマルチモーダルLLMとして使用しています。
- [MetaQuery](https://xichenpan.com/metaquery): OpenUniはMetaQueryに触発され、この研究のオープンソース実装です。
- [BLIP3-o](https://github.com/JiuhaiChen/BLIP3o): 貴重な高品質チューニングデータセットを公開してくださったBLIP3-oチームに感謝します。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---