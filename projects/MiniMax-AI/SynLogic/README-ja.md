<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

このリポジトリには、SynLogic のコードとデータが含まれています。SynLogic は、多様で検証可能な推論データを大規模に生成できる、包括的な論理推論データ合成フレームワークです。本研究は、大規模言語モデル（LLM）の一般的な推論能力開発のための高品質な論理推論トレーニングデータの重大なギャップに対応します。

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## News
- **[2025/07/07]** :fire: SynLogic データを使用して Verl フレームワークによる RL トレーニングを行うためのガイダンスを提供しています。詳細は [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) をご参照ください。

- **[2025/06/03]** :fire: Hugging Face にて学習済みモデルを公開しました:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: 論文 "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond" のリソース公開を発表します

## 📋 概要

**SynLogic** は、以下の特徴を持つデータ合成フレームワークおよび包括的なデータセットです:
- 📊 **数独、24ゲーム、暗号、矢印迷路など、35種類の多様な論理推論タスクをカバー**
- 🎯 **各タスクごとに調整可能なパラメータによる難易度コントロール合成が可能**
- ✅ **RLトレーニング用のルールベース検証による検証可能な報酬を提供**
- 🚀 **オープンソースデータセット中で SOTA 性能を達成、BBEH で DeepSeek-R1-Distill-Qwen-32B を6ポイント上回る**

### 主な特徴
- **スケーラブルなデータ生成**: 難易度を制御した無制限なデータ合成
- **包括的なタスク網羅**: 35種の独自論理推論タスク、カスタム生成器および検証器付き
- **RL 対応**: 全ての例は単純なルールで検証可能、強化学習に最適
- **クロスドメイン転移**: 数学・コーディング領域への強い汎化性能

## 🚀 クイックスタート

### インストール
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### サンプルデータ生成（矢印迷路の例）
```bash
# 矢印迷路のクイック例
bash games/tasks/arrow_maze/run.sh

# またはカスタムパラメータで
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### RL トレーニング用

強化学習トレーニングで SynLogic データを活用するための包括的なガイダンスを提供しています。Verl フレームワークとの統合方法の詳細は [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) をご覧ください。

## :rocket: リソース

### データセット
| データセット名 | 説明 | リンク |
|:------------:|:------------|:----:|
| **SynLogic** | データセット | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### モデル


| モデル名 | 説明 | リンク |
|:-----------|:------------|:----:|
| **SynLogic-7B** | SynLogic で学習した 7B モデル | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | SynLogic で学習した 32B モデル | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | SynLogic・数学・コーディングデータで学習した 32B モデル | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 今後のアップデート
私たちは、SynLogicをより多くの論理的推論タスクへ拡張するために積極的に取り組んでいます。

最新のアップデートとリリース情報については、ぜひ私たちのリポジトリをフォローしてください！

## 引用
本研究が役立った場合は、以下の論文を引用してください：

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---