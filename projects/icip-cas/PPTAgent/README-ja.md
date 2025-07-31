# PPTAgent: テキストからスライド生成を超えたプレゼンテーションの生成と評価
<p align="center">
  📄 <a href="https://arxiv.org/abs/2501.03936" target="_blank">論文</a> &nbsp; | &nbsp;
  🤗 <a href="https://huggingface.co/datasets/Forceless/Zenodo10K" target="_blank">データセット</a> &nbsp; | &nbsp;
  📝 <a href="./DOC.md" target="_blank">ドキュメント</a> &nbsp; | &nbsp;
  🙏 <a href="#citation-" target="_blank">引用</a> &nbsp; | &nbsp;
  <a href="https://deepwiki.com/icip-cas/PPTAgent" target="_blank"><img src="https://deepwiki.com/icon.png" alt="Ask DeepWiki"> DeepWiki</a>
</p>

我々はPPTAgentを紹介します。これは文書から自動的にプレゼンテーションを生成する革新的なシステムです。人間のプレゼンテーション作成方法から着想を得て、本システムは全体の品質を保証するために二段階のプロセスを採用しています。加えて、多面的にプレゼンテーションを評価する包括的評価フレームワーク**PPTEval**も提案します。

> [!TIP]
> 🚀 事前構築済みDockerイメージで素早く開始可能 - [Dockerの使い方はこちら](DOC.md/#docker-)

## デモ動画 🎥

https://github.com/user-attachments/assets/c3935a98-4d2b-4c46-9b36-e7c598d14863

## 特徴 ✨

- **動的コンテンツ生成**：テキストと画像がシームレスに統合されたスライドを作成
- **スマート参照学習**：手動アノテーション不要で既存プレゼンテーションを活用
- **包括的品質評価**：複数の品質指標でプレゼンテーションを評価

## ケーススタディ 💡

- #### [Iphone 16 Pro](https://www.apple.com/iphone-16-pro/)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0001.jpg" alt="画像1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0002.jpg" alt="画像2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0003.jpg" alt="画像3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0004.jpg" alt="画像4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0005.jpg" alt="画像5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0006.jpg" alt="画像6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0007.jpg" alt="画像7" width="200"/>

</div>

- #### [Build Effective Agents](https://www.anthropic.com/research/building-effective-agents)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0001.jpg" alt="画像1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0002.jpg" alt="画像2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0003.jpg" alt="画像3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0004.jpg" alt="画像4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0005.jpg" alt="画像5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0006.jpg" alt="画像6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0007.jpg" alt="画像7" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0008.jpg" alt="画像8" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0009.jpg" alt="画像9" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0010.jpg" alt="画像10" width="200"/>

</div>

## PPTAgent 🤖

PPTAgentは二段階のアプローチを採用しています：
1. **分析フェーズ**：参照プレゼンテーションのパターンを抽出し学習
2. **生成フェーズ**：構造化されたアウトラインを作成し、視覚的に統一感あるスライドを生成

本システムのワークフローは以下の通りです：


![PPTAgent Workflow](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig2.jpg)

## PPTEval ⚖️

PPTEvalはプレゼンテーションを三つの次元で評価します：
- **コンテンツ**：スライドの正確性と関連性をチェック
- **デザイン**：視覚的魅力と一貫性を評価
- **一貫性**：アイデアの論理的な流れを保証

PPTEvalのワークフローは以下の通りです：
<p align="center">
<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig3.jpg" alt="PPTEval Workflow" style="width:70%;"/>
</p>


## 引用 🙏

本プロジェクトが役立った場合、以下の文献を引用してください：
```bibtex
@article{zheng2025pptagent,
  title={PPTAgent: Generating and Evaluating Presentations Beyond Text-to-Slides},
  author={Zheng, Hao and Guan, Xinyan and Kong, Hao and Zheng, Jia and Zhou, Weixiang and Lin, Hongyu and Lu, Yaojie and He, Ben and Han, Xianpei and Sun, Le},
  journal={arXiv preprint arXiv:2501.03936},
  year={2025}
}
```

[![Star History Chart](https://api.star-history.com/svg?repos=icip-cas/PPTAgent&type=Date)](https://star-history.com/#icip-cas/PPTAgent&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-31

---