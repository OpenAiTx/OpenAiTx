# GraspVLA: 10億規模の合成アクションデータで事前学習された把持基盤モデル
[![arXiv](https://img.shields.io/badge/arXiv-2505.03233-df2a2a.svg)](https://arxiv.org/pdf/2505.03233)
[![Static Badge](https://img.shields.io/badge/Project-Page-a)](https://pku-epic.github.io/GraspVLA-web/)

<!-- [Shengliang Deng](https://shengliangd.github.io/about/), [Mi Yan](https://miyandoris.github.io/), [Songlin Wei](https://songlin.github.io/), Haixin Ma, Yuxin Yang, [Jiayi Chen](https://jychen18.github.io/), Zhiqi Zhang, Taoyu Yang, Xuheng Zhang, [Heming Cui](https://i.cs.hku.hk/~heming/), [Zhizheng Zhang](https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=en), [He Wang](https://hughw19.github.io/) -->

本研究では、合成データのみを用いたコスト効率の高いVLAモデルの事前学習パラダイムを提案し、直接的なシムツーリアル転送とロボット把持の強力なゼロショット汎化を実現します。主な貢献は以下の通りです：

- **SynGrasp-1B**：24万カテゴリ、10,000以上のオブジェクトを網羅する10億フレームの合成把持データセット。

- **GraspVLA**：SynGrasp-1Bで事前学習されたVLAモデルで、ファインチューニングなしに実世界の把持へゼロショット汎化を達成。

- **統一CoTフレームワーク**：GraspVLAは自己回帰的知覚とフローマッチングに基づくアクション生成を単一の推論プロセスに統合し、合成アクションデータとインターネット規模の意味データの共同学習を可能にし、オープンボキャブラリー把持を実現。

![teaser](https://raw.githubusercontent.com/PKU-EPIC/GraspVLA/main/./figs/teaser.jpg)

TODO リスト:
- [ ] 補足資料の公開
- [ ] モデル重みの公開
- [ ] SynGrasp-1Bデータセットの公開

[![License](https://licensebuttons.net/l/by-nc/4.0/88x31.png)](LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---