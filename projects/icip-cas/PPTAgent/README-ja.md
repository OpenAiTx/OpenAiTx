
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# PPTAgent: テキストからスライドを超えたプレゼンテーションの生成と評価
<p align="center">
  📄 <a href="https://arxiv.org/abs/2501.03936" target="_blank">論文</a> &nbsp; | &nbsp;
  🤗 <a href="#open-source-" target="_blank">オープンソース</a> &nbsp; | &nbsp;
  📝 <a href="./DOC.md" target="_blank">ドキュメント</a> &nbsp; | &nbsp;
  🙏 <a href="#citation-" target="_blank">引用</a> &nbsp; | &nbsp;
  <a href="https://deepwiki.com/icip-cas/PPTAgent" target="_blank"><img src="https://deepwiki.com/icon.png" alt="Ask DeepWiki"> DeepWiki</a>
</p>

私たちはPPTAgentという革新的なシステムを発表します。これは文書から自動でプレゼンテーションを生成します。人間のプレゼン作成手法に着想を得て、システムは二段階プロセスを採用し、全体の品質を高めています。さらに、プレゼンテーションを多角的に評価する包括的なフレームワーク**PPTEval**を導入しています。

> [!TIP]
> 🚀 事前構築済みのDockerイメージですぐに始められます - [Dockerの手順はこちら](DOC.md/#docker-)

## オープンソース 🤗
**PPTAgentコードモデル**とデータセットを公開しています: [PPTAgent-Coder](https://huggingface.co/Forceless/PPTAgent-coder-3B)、[Zenodo10k](https://huggingface.co/datasets/Forceless/Zenodo10K)、[pptagent-code26k](https://huggingface.co/datasets/Forceless/pptagent-code26k)。

## デモ動画 🎥

https://github.com/user-attachments/assets/c3935a98-4d2b-4c46-9b36-e7c598d14863

## 独自の特徴 ✨

- **動的なコンテンツ生成**：テキストと画像をシームレスに統合したスライドを作成
- **スマート参照学習**：手動で注釈することなく既存プレゼンを活用
- **包括的な品質評価**：複数の品質指標でプレゼンを評価

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

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0001.jpg" alt="图片1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0002.jpg" alt="图片2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0003.jpg" alt="图片3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0004.jpg" alt="图片4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0005.jpg" alt="图片5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0006.jpg" alt="图片6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0007.jpg" alt="图片7" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0008.jpg" alt="图片8" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0009.jpg" alt="图片9" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0010.jpg" alt="图片10" width="200"/>

</div>

## PPTAgent 🤖

PPTAgent follows a two-phase approach:
1. **Analysis Phase**: Extracts and learns from patterns in reference presentations
2. **Generation Phase**: Develops structured outlines and produces visually cohesive slides

Our system's workflow is illustrated below:


![PPTAgent Workflow](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig2.jpg)

## PPTEval ⚖️

PPTEvalは、プレゼンテーションを以下の三つの観点から評価します：
- **内容**：スライドの正確性と関連性を確認します。
- **デザイン**：視覚的な魅力と一貫性を評価します。
- **一貫性**：アイデアの論理的な流れを保証します。

PPTEvalのワークフローは以下の通りです：
<p align="center">
<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig3.jpg" alt="PPTEval Workflow" style="width:70%;"/>
</p>


## 引用 🙏

このプロジェクトが役立った場合は、以下の方法で引用してください：
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---